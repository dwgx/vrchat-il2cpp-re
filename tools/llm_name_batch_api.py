#!/usr/bin/env python3
"""Direct API batch naming for hash methods. Hits aixj.vip endpoint.

Usage: python tools/llm_name_batch_api.py <start> <end> [--concurrent N]
"""
import json, sys, os, time, concurrent.futures
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
OUTPUT_DIR = BASE_DIR / 'output'

API_KEY = os.environ.get('OPENAI_API_KEY', '')
API_BASE = os.environ.get('API_BASE', 'https://api.shqbb.com')
MODEL = os.environ.get('LLM_MODEL', 'gpt-5.5')

SYSTEM_PROMPT = """You are a VRChat IL2CPP reverse engineer. Given class context, predict semantic names for hash methods (m_XXX).

Rules:
- Use PascalCase method names (C# convention)
- Infer from: class name, parent, readable methods, fields
- Common patterns: Get/Set + field name, On + event, Handle + action, Update/Initialize/Process + noun
- Return ONLY valid JSON: {"ClassName::m_hash": "PredictedName", ...}
- No explanations, no markdown fences, just the JSON object"""


def call_api(prompt: str) -> str:
    import urllib.request
    import urllib.error

    headers = {
        'Content-Type': 'application/json',
        'Authorization': f'Bearer {API_KEY}',
    }
    body = json.dumps({
        'model': MODEL,
        'messages': [
            {'role': 'system', 'content': SYSTEM_PROMPT},
            {'role': 'user', 'content': prompt},
        ],
        'temperature': 0.3,
        'max_tokens': 4096,
    }).encode('utf-8')

    req = urllib.request.Request(
        f'{API_BASE}/v1/chat/completions',
        data=body, headers=headers, method='POST'
    )
    for attempt in range(3):
        try:
            with urllib.request.urlopen(req, timeout=120) as resp:
                data = json.loads(resp.read().decode('utf-8'))
                return data['choices'][0]['message']['content']
        except urllib.error.HTTPError as e:
            err_body = e.read().decode('utf-8', errors='replace')[:200]
            if e.code in (429, 503) and attempt < 2:
                time.sleep(10 * (attempt + 1))
                continue
            return f'ERROR:{e.code}:{err_body}'
        except Exception as e:
            if attempt < 2:
                time.sleep(5)
                continue
            return f'ERROR:{e}'
    return 'ERROR:max_retries'


def build_prompt(batch: list) -> str:
    lines = []
    for cls_ctx in batch:
        lines.append(f"\nClass: {cls_ctx['class']} (parent: {cls_ctx['parent']})")
        if cls_ctx['readable_methods']:
            lines.append(f"  Known methods: {', '.join(cls_ctx['readable_methods'][:15])}")
        if cls_ctx['fields']:
            lines.append(f"  Fields: {', '.join(cls_ctx['fields'][:10])}")
        lines.append(f"  Name these: {', '.join(cls_ctx['hash_methods'])}")
    return '\n'.join(lines)


def run_batch(batch_idx: int) -> int:
    pred_path = OUTPUT_DIR / f'codex_pred_{batch_idx:03d}.json'
    batch_path = OUTPUT_DIR / f'codex_batch_{batch_idx:03d}.json'

    if pred_path.exists():
        existing = json.load(open(pred_path, 'r', encoding='utf-8'))
        if existing:
            print(f'  [{batch_idx:03d}] skip ({len(existing)} cached)')
            return len(existing)

    if not batch_path.exists():
        return 0

    batch = json.load(open(batch_path, 'r', encoding='utf-8'))
    prompt = build_prompt(batch)

    response = call_api(prompt)

    if response.startswith('ERROR:'):
        print(f'  [{batch_idx:03d}] {response[:80]}')
        return 0

    # Extract JSON
    start = response.find('{')
    end = response.rfind('}')
    if start >= 0 and end > start:
        try:
            predictions = json.loads(response[start:end+1])
            with open(pred_path, 'w', encoding='utf-8') as f:
                json.dump(predictions, f, indent=2, ensure_ascii=False)
            print(f'  [{batch_idx:03d}] +{len(predictions)} predictions')
            return len(predictions)
        except json.JSONDecodeError:
            print(f'  [{batch_idx:03d}] JSON parse fail')
            return 0
    else:
        print(f'  [{batch_idx:03d}] no JSON in response')
        return 0


def main():
    if len(sys.argv) < 3:
        print(f'Usage: {sys.argv[0]} <start> <end> [--concurrent N]')
        sys.exit(1)

    start = int(sys.argv[1])
    end = int(sys.argv[2])
    concurrent_n = 4
    for i, arg in enumerate(sys.argv):
        if arg == '--concurrent' and i + 1 < len(sys.argv):
            concurrent_n = int(sys.argv[i + 1])

    if not API_KEY:
        print('ERROR: OPENAI_API_KEY not set')
        sys.exit(1)

    print(f'Running batches {start}-{end} with {concurrent_n} concurrent workers')
    t0 = time.time()
    total = 0

    with concurrent.futures.ThreadPoolExecutor(max_workers=concurrent_n) as pool:
        futures = {pool.submit(run_batch, i): i for i in range(start, end + 1)}
        for future in concurrent.futures.as_completed(futures):
            total += future.result()

    elapsed = time.time() - t0
    print(f'\nDone: {total} predictions in {elapsed:.1f}s')


if __name__ == '__main__':
    main()
