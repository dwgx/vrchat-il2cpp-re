#!/usr/bin/env python3
"""Collect and parse Gemini prediction results from raw output files."""
import json, sys, re
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
RESULTS_DIR = BASE_DIR / 'output' / 'llm_batches' / 'results'
RESULTS_DIR.mkdir(parents=True, exist_ok=True)

# Task output directory where background Gemini tasks write their output
TASK_DIR = Path(sys.argv[1]) if len(sys.argv) > 1 else None

def extract_json_from_text(text):
    """Extract JSON object from Gemini's response text."""
    # Try markdown code blocks first
    m = re.search(r'```(?:json)?\s*(\{.*?\})\s*```', text, re.DOTALL)
    if m:
        try:
            return json.loads(m.group(1))
        except json.JSONDecodeError:
            pass

    # Try to find a JSON object directly
    # Find the first { and the last matching }
    start = text.find('{')
    if start == -1:
        return None

    depth = 0
    end = -1
    for i in range(start, len(text)):
        if text[i] == '{':
            depth += 1
        elif text[i] == '}':
            depth -= 1
            if depth == 0:
                end = i + 1
                break

    if end == -1:
        return None

    try:
        return json.loads(text[start:end])
    except json.JSONDecodeError:
        # Try fixing common issues (trailing commas, etc)
        fixed = re.sub(r',\s*}', '}', text[start:end])
        fixed = re.sub(r',\s*$', '', fixed, flags=re.MULTILINE)
        try:
            return json.loads(fixed)
        except json.JSONDecodeError:
            return None


def process_raw_output(raw_text, batch_idx):
    """Process raw Gemini output, save results."""
    result = extract_json_from_text(raw_text)
    if not result:
        print(f'  focus_{batch_idx:02d}: FAILED to parse JSON ({len(raw_text)} chars raw)')
        # Save raw for debugging
        raw_path = RESULTS_DIR / f'focus_{batch_idx:02d}_raw.txt'
        raw_path.write_text(raw_text, encoding='utf-8')
        return 0

    # Validate: keys should be ClassName::m_XXX format
    valid = {}
    for k, v in result.items():
        if '::' in k and isinstance(v, str) and len(v) >= 3:
            valid[k] = v

    if not valid:
        print(f'  focus_{batch_idx:02d}: No valid predictions in {len(result)} entries')
        return 0

    out_path = RESULTS_DIR / f'focus_{batch_idx:02d}_results.json'
    with open(out_path, 'w', encoding='utf-8') as f:
        json.dump(valid, f, indent=1, ensure_ascii=False)

    print(f'  focus_{batch_idx:02d}: {len(valid)} predictions saved')
    return len(valid)


# Process from task output files if directory provided
if TASK_DIR and TASK_DIR.is_dir():
    print(f'Scanning task outputs from {TASK_DIR}...\n')
    total = 0
    for task_file in sorted(TASK_DIR.glob('*.output')):
        # Try to match batch index from content or filename
        raw = task_file.read_text(encoding='utf-8', errors='replace')
        if not raw.strip():
            continue
        # Extract batch index from the JSON keys
        m = re.search(r'"(\w+)::m_[0-9a-fA-F]{3}"', raw)
        if m:
            # Try to figure out which batch this is from content
            pass
        print(f'Processing {task_file.name}...')
        result = extract_json_from_text(raw)
        if result:
            print(f'  Found {len(result)} predictions')
            total += len(result)

# Also check for any existing raw files
print('\nChecking existing result files...')
total = 0
for f in sorted(RESULTS_DIR.glob('focus_*_results.json')):
    try:
        data = json.load(open(f, 'r', encoding='utf-8'))
        print(f'  {f.name}: {len(data)} predictions')
        total += len(data)
    except Exception as e:
        print(f'  {f.name}: ERROR - {e}')

print(f'\nTotal existing predictions: {total}')
