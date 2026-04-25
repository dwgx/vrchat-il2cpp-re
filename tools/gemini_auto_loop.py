#!/usr/bin/env python3
"""
Gemini 自动循环命名：
1. 扫描还没命名的 hash 方法
2. 按类+邻居生成 batch
3. 逐个调 Gemini（限流自动重试）
4. Merge + pipeline + commit
5. 循环直到没新增
"""
import json, re, sys, os, hashlib, subprocess, time, glob
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE = Path(__file__).resolve().parent.parent

def sh(s, L=3):
    return hashlib.sha256(s.encode('utf-8')).hexdigest()[:L].upper()

def build_batches():
    nm = json.load(open(BASE / 'output/name_mapping.json', 'r', encoding='utf-8'))
    pd = json.load(open(BASE / 'data/precise_dump.json', 'r', encoding='utf-8'))
    cv = json.load(open(BASE / 'output/cross_version_method_names.json', 'r', encoding='utf-8'))
    mm = nm['methods']; cm = nm['classes']
    hp = re.compile(r'^m_[0-9A-F]{3}$')

    targets = []
    for ns, cl in pd['namespaces'].items():
        if not isinstance(cl, list): continue
        for c in cl:
            cls_obf = c.get('name', '')
            cls_sem = cm.get(cls_obf, cls_obf)
            if '<>' in cls_sem or 'AsyncStateMachine_' in cls_sem: continue
            methods = c.get('methods', [])
            if len(methods) < 5: continue

            known = []
            hkeys = []
            for m in methods:
                if not isinstance(m, str): continue
                key = f'{cls_obf}::{m}'
                cur = mm.get(key, '')
                h = sh(m, 3)
                cv_key = f'{cls_sem}::m_{h}'
                if isinstance(cur, str) and hp.match(cur) and cv_key not in cv:
                    hkeys.append(cv_key)
                elif cur and not hp.match(cur):
                    known.append(cur)

            if hkeys and len(known) >= 3:
                targets.append({
                    'class': cls_sem,
                    'parent': c.get('parent', ''),
                    'known_methods': known[:30],
                    'hash_keys': hkeys[:20],
                })

    total_hash = sum(len(t['hash_keys']) for t in targets)
    print(f'  {total_hash} hash methods in {len(targets)} classes')

    out_dir = BASE / 'output/gemini_auto'
    out_dir.mkdir(exist_ok=True)
    # Clean only batch files, preserve pred files from concurrent runs
    for f in out_dir.glob('batch_*.json'):
        f.unlink()

    batches = []
    for i in range(0, len(targets), 15):
        batch_file = out_dir / f'batch_{i//15:03d}.json'
        with open(batch_file, 'w', encoding='utf-8') as f:
            json.dump(targets[i:i+15], f, indent=1, ensure_ascii=False)
        batches.append(batch_file)

    print(f'  {len(batches)} batches')
    return batches, total_hash

import shutil
GEMINI_CMD = shutil.which('gemini.cmd') or shutil.which('gemini') or r'C:\Users\dwgx1\AppData\Roaming\npm\gemini.cmd'

def run_gemini_batch(batch_file, pred_file):
    rel = str(batch_file.relative_to(BASE)).replace('\\', '/')
    prompt = (
        f"Read {rel} . "
        "Each has class+parent+known_methods+hash_keys. "
        "Predict PascalCase names by class theme. "
        "Output ONLY JSON {key: name}. 50-70% coverage."
    )
    for attempt in range(5):
        try:
            result = subprocess.run(
                [GEMINI_CMD, '-p', prompt, '-y'],
                capture_output=True, text=True, timeout=300,
                cwd=str(BASE), shell=False, encoding='utf-8', errors='replace'
            )
        except Exception as e:
            print(f'    Error: {e}')
            return False
        output = result.stdout or ''
        if '429' in output or 'authentication' in output.lower() or 'Attempt' in output[:500]:
            wait = 30 * (attempt + 1)
            print(f'    Rate limited, waiting {wait}s...')
            time.sleep(wait)
            continue
        with open(pred_file, 'w', encoding='utf-8') as f:
            f.write(output)
        return True
    return False

def merge_predictions():
    cv = json.load(open(BASE / 'output/cross_version_method_names.json', 'r', encoding='utf-8'))
    added = 0
    hp = re.compile(r'^m_[0-9A-F]{3}$')
    for f in sorted(glob.glob(str(BASE / 'output/gemini_auto/pred_*.json'))):
        try:
            raw = open(f, 'r', encoding='utf-8').read()
            j1 = raw.find('{'); j2 = raw.rfind('}')
            if j1 < 0 or j2 <= j1: continue
            d = json.loads(raw[j1:j2+1])
            for k, v in d.items():
                if '::m_' in k and v and k not in cv and not hp.match(v):
                    cv[k] = v; added += 1
        except Exception:
            pass
    with open(BASE / 'output/cross_version_method_names.json', 'w', encoding='utf-8') as f:
        json.dump(cv, f, indent=2, ensure_ascii=False)
    print(f'  New entries: {added}')
    return added

def run_pipeline():
    r = subprocess.run(
        [sys.executable, 'tools/run_full_pipeline.py', '--skip-binary', '--force'],
        capture_output=True, text=True, timeout=300, cwd=str(BASE)
    )
    for line in r.stdout.split('\n'):
        if 'Semantic' in line or 'semantic' in line or 'Renamed' in line or 'coverage' in line.lower():
            print(f'  {line.strip()}')

def git_commit(round_num):
    subprocess.run(['git', 'add', 'output/cross_version_method_names.json',
                     'output/.pipeline_cache.json', 'output/pipeline_coverage_report.md',
                     'output/src/'], cwd=str(BASE), capture_output=True)
    subprocess.run(['git', 'commit', '-m', f'Gemini auto-loop round {round_num}'],
                    cwd=str(BASE), capture_output=True)

def main():
    print('=' * 50)
    print('  Gemini Auto-Loop')
    print('  Ctrl+C to stop')
    print('=' * 50)

    round_num = 0
    while True:
        round_num += 1
        print(f'\n{"="*20} Round {round_num} {"="*20}')

        print('[1] Building batches...')
        batches, total = build_batches()
        if total == 0:
            print('  No more hash methods to name. Done!')
            break

        print(f'[2] Running Gemini ({len(batches)} batches)...')
        for i, bf in enumerate(batches):
            pred_file = bf.parent / f'pred_{i:03d}.json'
            print(f'  batch {i}/{len(batches)}...', end=' ')
            ok = run_gemini_batch(bf, pred_file)
            print('OK' if ok else 'FAIL')
            time.sleep(3)  # small delay

        print('[3] Merging...')
        added = merge_predictions()

        if added == 0:
            print('  No new predictions. Stopping.')
            break

        print('[4] Pipeline...')
        run_pipeline()

        print('[5] Committing...')
        git_commit(round_num)

        print(f'[6] Round {round_num} done. +{added} entries.')
        print('  Waiting 15s...')
        time.sleep(15)

    print('\nDone!')

if __name__ == '__main__':
    try:
        main()
    except KeyboardInterrupt:
        print('\nStopped by user.')
