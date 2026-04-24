#!/usr/bin/env python3
"""Run a single codex naming batch. Called by codex exec.

Usage: python tools/codex_name_batch.py <batch_start> <batch_end>
Processes codex_batch_{start:03d}.json through codex_batch_{end:03d}.json
Outputs: output/codex_pred_{NNN}.json
"""
import json, sys, os, subprocess, time
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
OUTPUT_DIR = BASE_DIR / 'output'

PROMPT_TEMPLATE = """You are a VRChat IL2CPP reverse engineer. Given class context, predict semantic names for hash methods (m_XXX).

Rules:
- Use PascalCase method names (C# convention)
- Infer from: class name, parent, readable methods, fields
- Common patterns: Get/Set + field name, On + event, Handle + action, Update/Initialize/Process + noun
- If uncertain, prefix with likely verb: Check, Process, Update, Handle, Initialize
- Return ONLY a JSON object: {"class::m_hash": "PredictedName", ...}
- No explanations, no markdown, just JSON

Context:
"""

def run_batch(batch_idx: int) -> dict:
    batch_path = OUTPUT_DIR / f'codex_batch_{batch_idx:03d}.json'
    pred_path = OUTPUT_DIR / f'codex_pred_{batch_idx:03d}.json'

    if pred_path.exists():
        existing = json.load(open(pred_path, 'r', encoding='utf-8'))
        if existing:
            print(f'  Batch {batch_idx:03d}: already done ({len(existing)} predictions)')
            return existing

    if not batch_path.exists():
        print(f'  Batch {batch_idx:03d}: NOT FOUND')
        return {}

    batch = json.load(open(batch_path, 'r', encoding='utf-8'))

    context_lines = []
    for cls_ctx in batch:
        context_lines.append(f"\nClass: {cls_ctx['class']} (parent: {cls_ctx['parent']})")
        if cls_ctx['readable_methods']:
            context_lines.append(f"  Readable methods: {', '.join(cls_ctx['readable_methods'][:15])}")
        if cls_ctx['fields']:
            context_lines.append(f"  Fields: {', '.join(cls_ctx['fields'][:10])}")
        context_lines.append(f"  Hash methods to name: {', '.join(cls_ctx['hash_methods'])}")

    prompt = PROMPT_TEMPLATE + '\n'.join(context_lines)

    # Call codex via subprocess
    env = os.environ.copy()
    try:
        result = subprocess.run(
            ['codex', 'exec', prompt],
            capture_output=True, text=True, timeout=120,
            cwd=str(BASE_DIR), env=env,
            input=''
        )
        output = result.stdout.strip()

        # Try to extract JSON from output
        predictions = {}
        # Find JSON in output
        start = output.find('{')
        end = output.rfind('}')
        if start >= 0 and end > start:
            json_str = output[start:end+1]
            try:
                predictions = json.loads(json_str)
            except json.JSONDecodeError:
                print(f'  Batch {batch_idx:03d}: JSON parse failed')
                predictions = {}

        if predictions:
            with open(pred_path, 'w', encoding='utf-8') as f:
                json.dump(predictions, f, indent=2, ensure_ascii=False)
            print(f'  Batch {batch_idx:03d}: {len(predictions)} predictions saved')
        else:
            print(f'  Batch {batch_idx:03d}: no predictions (output: {output[:200]})')

        return predictions

    except subprocess.TimeoutExpired:
        print(f'  Batch {batch_idx:03d}: TIMEOUT')
        return {}
    except Exception as e:
        print(f'  Batch {batch_idx:03d}: ERROR: {e}')
        return {}


def main():
    if len(sys.argv) < 3:
        print(f'Usage: python {sys.argv[0]} <start> <end>')
        sys.exit(1)

    start = int(sys.argv[1])
    end = int(sys.argv[2])

    total_preds = 0
    for i in range(start, end + 1):
        preds = run_batch(i)
        total_preds += len(preds)
        time.sleep(0.5)

    print(f'\nDone: batches {start}-{end}, total {total_preds} predictions')


if __name__ == '__main__':
    main()
