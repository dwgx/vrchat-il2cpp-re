#!/usr/bin/env python3
"""
Path B merger — validate predictions, filter junk, merge into cross_version_method_names.json.
"""
import json, re, sys
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE = Path(__file__).resolve().parent.parent

HP = re.compile(r'^m_[0-9A-F]{3}$')
VALID_NAME = re.compile(r'^[A-Za-z_][A-Za-z0-9_]{2,79}$')
BANNED_GENERIC = {
    'update', 'process', 'handle', 'execute', 'init', 'initialize', 'setup',
    'run', 'dowork', 'method', 'call', 'invoke', 'helper', 'wrapper', 'utility',
    'start', 'main', 'action', 'callback', 'event', 'data', 'info',
    'getvalue', 'setvalue', 'get', 'set', 'check', 'test',
}


def is_valid(name: str) -> bool:
    if not isinstance(name, str):
        return False
    if not VALID_NAME.match(name):
        return False
    if HP.match(name):
        return False
    if name.lower() in BANNED_GENERIC:
        return False
    if name.startswith('sub_') or name.startswith('loc_') or name.startswith('unk_'):
        return False
    return True


def main():
    cv_path = BASE / 'output/cross_version_method_names.json'
    cv = json.load(open(cv_path, 'r', encoding='utf-8'))

    batch_dir = BASE / 'output/llm_batches_hexrays_b'
    preds = sorted(batch_dir.glob('pred_*.json'))
    if not preds:
        print('No predictions. Run run_hexrays_b.py first.')
        return

    total_emitted = 0
    added = 0
    rejected = 0
    rejection_samples = []

    for pf in preds:
        try:
            d = json.load(open(pf, 'r', encoding='utf-8'))
        except Exception:
            continue
        if not isinstance(d, dict):
            continue
        for k, v in d.items():
            total_emitted += 1
            if not isinstance(k, str) or '::m_' not in k:
                rejected += 1
                continue
            if not is_valid(v):
                rejected += 1
                if len(rejection_samples) < 10:
                    rejection_samples.append(f'{k!r} → {v!r}')
                continue
            if k in cv:
                # Don't overwrite existing
                continue
            cv[k] = v
            added += 1

    with open(cv_path, 'w', encoding='utf-8') as f:
        json.dump(cv, f, indent=2, ensure_ascii=False)

    print(f'Predictions emitted: {total_emitted}')
    print(f'Added to cross_version: {added}')
    print(f'Rejected (invalid/generic): {rejected}')
    if rejection_samples:
        print('Rejection samples:')
        for s in rejection_samples:
            print(f'  {s}')


if __name__ == '__main__':
    main()
