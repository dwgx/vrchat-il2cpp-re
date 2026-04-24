#!/usr/bin/env python3
"""Bulk LLM prediction runner — dispatches focus batches to Gemini CLI.

Usage:
    python tools/run_llm_bulk.py [--start N] [--end N] [--workers N] [--model MODEL]

Processes focus batches sequentially (or with limited concurrency).
Saves results to output/llm_batches/results/focus_XX_results.json.
Skips batches that already have results (resume-safe).
"""
import json, sys, os, subprocess, re, time, argparse
from pathlib import Path
from concurrent.futures import ThreadPoolExecutor, as_completed

sys.stdout.reconfigure(encoding='utf-8')

ROOT = Path(__file__).resolve().parent.parent
FOCUS_DIR = ROOT / 'output' / 'llm_batches' / 'focus'
RESULTS_DIR = ROOT / 'output' / 'llm_batches' / 'results'
WORKER_SCRIPT = ROOT / 'tools' / 'gemini_batch_worker.py'

RESULTS_DIR.mkdir(parents=True, exist_ok=True)


def parse_json_from_output(text: str) -> dict:
    """Extract JSON object from LLM output (handles markdown fences, preamble, etc.)."""
    # Try direct parse first
    text = text.strip()
    if text.startswith('{'):
        try:
            return json.loads(text)
        except json.JSONDecodeError:
            pass

    # Try extracting from markdown code block
    patterns = [
        r'```(?:json)?\s*\n?(.*?)\n?```',
        r'(\{[^{}]*(?:\{[^{}]*\}[^{}]*)*\})',
    ]
    for pat in patterns:
        m = re.search(pat, text, re.DOTALL)
        if m:
            try:
                return json.loads(m.group(1))
            except json.JSONDecodeError:
                continue

    # Last resort: find first { to last }
    start = text.find('{')
    end = text.rfind('}')
    if start >= 0 and end > start:
        try:
            return json.loads(text[start:end+1])
        except json.JSONDecodeError:
            pass

    return {}


def run_batch(batch_idx: int, model: str = 'gemini-2.5-flash') -> dict:
    """Run a single focus batch through Gemini CLI."""
    batch_file = FOCUS_DIR / f'focus_{batch_idx:02d}.json'
    result_file = RESULTS_DIR / f'focus_{batch_idx:02d}_results.json'

    if not batch_file.exists():
        return {'batch': batch_idx, 'status': 'skip', 'reason': 'no batch file'}

    if result_file.exists():
        existing = json.loads(result_file.read_text(encoding='utf-8'))
        if len(existing) > 0:
            return {'batch': batch_idx, 'status': 'cached', 'count': len(existing)}

    # Generate prompt
    prompt_proc = subprocess.run(
        ['python', str(WORKER_SCRIPT), str(batch_file)],
        capture_output=True, text=True, encoding='utf-8'
    )
    if prompt_proc.returncode != 0:
        return {'batch': batch_idx, 'status': 'error', 'reason': f'prompt gen failed: {prompt_proc.stderr[:200]}'}

    prompt = prompt_proc.stdout
    if not prompt or not prompt.strip():
        return {'batch': batch_idx, 'status': 'error', 'reason': 'empty prompt generated'}

    # Write prompt to temp file (Windows cmd line limit ~32K, prompts can be 80K+)
    prompt_file = RESULTS_DIR / f'_prompt_{batch_idx:02d}.txt'
    prompt_file.write_text(prompt, encoding='utf-8')

    # Call Gemini CLI with prompt piped via stdin (-p "" enables headless with stdin input)
    try:
        result = subprocess.run(
            ['gemini', '-y', '-p', '', '--model', model],
            input=prompt,
            capture_output=True, text=True, encoding='utf-8',
            timeout=300  # 5 min timeout per batch
        )
    except subprocess.TimeoutExpired:
        prompt_file.unlink(missing_ok=True)
        return {'batch': batch_idx, 'status': 'timeout'}
    except FileNotFoundError:
        prompt_file.unlink(missing_ok=True)
        return {'batch': batch_idx, 'status': 'error', 'reason': 'gemini CLI not found'}
    finally:
        prompt_file.unlink(missing_ok=True)

    if result.returncode != 0:
        return {'batch': batch_idx, 'status': 'error', 'reason': result.stderr[:200]}

    # Parse results
    predictions = parse_json_from_output(result.stdout)
    if not predictions:
        # Save raw output for debugging
        debug_file = RESULTS_DIR / f'focus_{batch_idx:02d}_raw.txt'
        debug_file.write_text(result.stdout, encoding='utf-8')
        return {'batch': batch_idx, 'status': 'parse_error', 'raw_len': len(result.stdout)}

    # Save
    result_file.write_text(json.dumps(predictions, ensure_ascii=False, indent=2), encoding='utf-8')
    return {'batch': batch_idx, 'status': 'ok', 'count': len(predictions)}


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--start', type=int, default=0)
    parser.add_argument('--end', type=int, default=999)
    parser.add_argument('--workers', type=int, default=1, help='Concurrent workers (careful with rate limits)')
    parser.add_argument('--model', default='gemini-2.5-flash')
    parser.add_argument('--delay', type=float, default=2.0, help='Delay between batches (seconds)')
    args = parser.parse_args()

    # Find all focus batches in range
    batch_indices = []
    for f in sorted(FOCUS_DIR.glob('focus_*.json')):
        idx = int(f.stem.split('_')[1])
        if args.start <= idx <= args.end:
            batch_indices.append(idx)

    print(f'Found {len(batch_indices)} batches (focus_{args.start:02d} to focus_{min(args.end, max(batch_indices) if batch_indices else 0):02d})')
    print(f'Model: {args.model}, Workers: {args.workers}, Delay: {args.delay}s')

    total_ok = 0
    total_cached = 0
    total_err = 0
    total_preds = 0
    start_time = time.time()

    if args.workers <= 1:
        # Sequential
        for i, idx in enumerate(batch_indices):
            result = run_batch(idx, args.model)
            status = result['status']
            count = result.get('count', 0)

            if status == 'ok':
                total_ok += 1
                total_preds += count
            elif status == 'cached':
                total_cached += 1
                total_preds += count
            else:
                total_err += 1

            elapsed = time.time() - start_time
            rate = (i + 1) / elapsed * 60 if elapsed > 0 else 0
            remaining = len(batch_indices) - i - 1

            print(f'[{i+1}/{len(batch_indices)}] focus_{idx:02d}: {status} ({count} preds) | '
                  f'ok={total_ok} cached={total_cached} err={total_err} | '
                  f'{rate:.1f}/min ETA {remaining/rate:.0f}min' if rate > 0 else '')

            if status == 'ok' and args.delay > 0:
                time.sleep(args.delay)
    else:
        # Concurrent
        with ThreadPoolExecutor(max_workers=args.workers) as executor:
            futures = {executor.submit(run_batch, idx, args.model): idx for idx in batch_indices}
            for i, future in enumerate(as_completed(futures)):
                idx = futures[future]
                result = future.result()
                status = result['status']
                count = result.get('count', 0)
                if status == 'ok': total_ok += 1; total_preds += count
                elif status == 'cached': total_cached += 1; total_preds += count
                else: total_err += 1
                print(f'[{i+1}/{len(batch_indices)}] focus_{idx:02d}: {status} ({count})')

    elapsed = time.time() - start_time
    print(f'\n=== DONE in {elapsed:.0f}s ===')
    print(f'OK: {total_ok}, Cached: {total_cached}, Errors: {total_err}')
    print(f'Total predictions: {total_preds}')


if __name__ == '__main__':
    main()
