#!/usr/bin/env python3
"""
Build prediction batches for LLM method-name inference.

Mirrors gemini_auto_loop.build_batches() but writes a fixed batch layout the
Claude orchestrator can hand off to subagents:

  output/llm_batches/batch_NNN.json   - 50 classes per batch, hash methods + known methods
  output/llm_batches/manifest.json    - batch index + class counts

Usage:
  python tools/build_llm_method_batches.py
"""
import hashlib
import json
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE = Path(__file__).resolve().parent.parent
OUT = BASE / 'output' / 'llm_batches'
HASH_RE = re.compile(r'^m_[0-9A-F]{3}$')
BATCH_SIZE = 15
MIN_KNOWN = 5
MIN_HASH = 3


def sh(s: str, length: int = 3) -> str:
    return hashlib.sha256(s.encode('utf-8')).hexdigest()[:length].upper()


def main() -> None:
    nm = json.loads((BASE / 'output' / 'name_mapping.json').read_text(encoding='utf-8'))
    pd = json.loads((BASE / 'data' / 'precise_dump.json').read_text(encoding='utf-8'))
    cv = json.loads((BASE / 'output' / 'cross_version_method_names.json').read_text(encoding='utf-8'))
    methods_map = nm['methods']
    classes_map = nm['classes']

    targets = []
    for ns, cl in pd['namespaces'].items():
        if not isinstance(cl, list):
            continue
        for c in cl:
            cls_obf = c.get('name', '')
            cls_sem = classes_map.get(cls_obf, cls_obf)
            if '<>' in cls_sem or 'AsyncStateMachine_' in cls_sem:
                continue
            methods = c.get('methods', [])
            if len(methods) < 5:
                continue

            known = []
            hkeys = []
            for m in methods:
                if not isinstance(m, str):
                    continue
                key = f'{cls_obf}::{m}'
                cur = methods_map.get(key, '')
                cv_key = f'{cls_sem}::m_{sh(m, 3)}'
                if isinstance(cur, str) and HASH_RE.match(cur) and cv_key not in cv:
                    hkeys.append(cv_key)
                elif cur and not HASH_RE.match(cur):
                    known.append(cur)

            if len(hkeys) >= MIN_HASH and len(known) >= MIN_KNOWN:
                # Skip generic Unity-only signal: known methods are all
                # MonoBehaviour / Object inherited stuff and class name has no
                # specific theme keywords. Those classes give no usable context.
                useful_known = [
                    m for m in known
                    if m not in {
                        'GetInstanceID', 'Equals', 'GetHashCode', 'op_Implicit',
                        'CompareBaseObjects', 'IsNativeObjectAlive', 'GetCachedPtr',
                        'get_name', 'set_name', 'Instantiate', 'ToString', 'Destroy',
                        'DestroyImmediate', 'FindObjectsOfType', 'FindObjectsByType',
                        'DontDestroyOnLoad', 'get_hideFlags', 'set_hideFlags',
                        'FindObjectOfType', 'FindFirstObjectByType', 'CheckNullArgument',
                        'op_Equality', 'op_Inequality',
                        'GetOffsetOfInstanceIDInCPlusPlusObject',
                        'Internal_CloneSingle', 'Internal_CloneSingleWithParent',
                        'Internal_InstantiateSingle', 'Internal_InstantiateSingleWithParent',
                        'GetName', 'SetName',
                        'get_destroyCancellationToken', 'RaiseCancellation',
                        'IsInvoking', 'CancelInvoke', 'Invoke', 'InvokeRepeating',
                        'StartCoroutine', 'StopCoroutine', 'StopAllCoroutines',
                        'get_useGUILayout', 'set_useGUILayout', 'print',
                        'Internal_CancelInvokeAll', 'Internal_IsInvokingAll',
                        'InvokeDelayed', 'IsObjectMonoBehaviour',
                        'StartCoroutineManaged', 'StartCoroutineManaged2',
                        'StopCoroutineManaged', 'OnCancellationTokenCreated',
                        'OnApplicationPause', 'OnApplicationQuit',
                        'OnBecameVisible', 'OnBecameInvisible',
                        'OnCollisionEnter', 'OnCollisionStay', 'OnCollisionExit',
                        'OnTriggerEnter', 'OnTriggerStay', 'OnTriggerExit',
                    }
                ]
                targets.append({
                    'class': cls_sem,
                    'parent': c.get('parent', ''),
                    'namespace': ns,
                    'known_methods': useful_known[:20],
                    'hash_keys': hkeys[:20],
                    'signal_score': len(useful_known) + len(hkeys),
                })

    # Sort high-signal first: classes with more useful known methods + hash keys
    targets.sort(key=lambda t: (-t['signal_score'], -len(t['hash_keys'])))
    OUT.mkdir(exist_ok=True)
    for old in OUT.glob('batch_*.json'):
        old.unlink()
    for old in OUT.glob('pred_*.json'):
        old.unlink()

    manifest = []
    for idx in range(0, len(targets), BATCH_SIZE):
        chunk = targets[idx:idx + BATCH_SIZE]
        path = OUT / f'batch_{idx // BATCH_SIZE:03d}.json'
        path.write_text(json.dumps(chunk, indent=1, ensure_ascii=False), encoding='utf-8')
        manifest.append({
            'batch_id': idx // BATCH_SIZE,
            'file': path.name,
            'class_count': len(chunk),
            'hash_keys_total': sum(len(t['hash_keys']) for t in chunk),
        })

    (OUT / 'manifest.json').write_text(
        json.dumps({
            'batch_size': BATCH_SIZE,
            'total_targets': len(targets),
            'total_hash_keys': sum(len(t['hash_keys']) for t in targets),
            'batches': manifest,
        }, indent=2, ensure_ascii=False),
        encoding='utf-8',
    )

    print(f'targets        : {len(targets)}')
    print(f'hash keys      : {sum(len(t["hash_keys"]) for t in targets)}')
    print(f'batches        : {len(manifest)} of {BATCH_SIZE} classes each')
    print(f'manifest       : {OUT / "manifest.json"}')


if __name__ == '__main__':
    main()
