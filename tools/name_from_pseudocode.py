#!/usr/bin/env python3
"""
Auto-name hash methods from Hex-Rays pseudocode using pattern matching.
No LLM needed — pure rule-based extraction from C pseudocode.
"""
import json, re, sys, hashlib, glob
from pathlib import Path
from collections import Counter

sys.stdout.reconfigure(encoding='utf-8')
BASE = Path(__file__).resolve().parent.parent

def stable_hash(s, L=3):
    return hashlib.sha256(s.encode('utf-8')).hexdigest()[:L].upper()

# Patterns to extract from pseudocode
CALL_RE = re.compile(r'(\w+(?:::\w+)?)\s*\(')  # function calls
STRING_RE = re.compile(r'"([^"]{4,80})"')  # string literals
ASSIGN_RE = re.compile(r'(\w+)\s*=\s*')  # assignments
RETURN_RE = re.compile(r'return\s+(\w+)')  # return values
IF_RE = re.compile(r'if\s*\(\s*(\w+)')  # condition checks

# Unity/C# method name inference rules
RULES = [
    # (pattern_in_pseudocode, predicted_name, priority)
    (r'SetActive\s*\(\s*\w+\s*,\s*1\s*\)', 'ActivateGameObject', 5),
    (r'SetActive\s*\(\s*\w+\s*,\s*0\s*\)', 'DeactivateGameObject', 5),
    (r'set_position', 'SetPosition', 4),
    (r'set_localPosition', 'SetLocalPosition', 4),
    (r'set_rotation', 'SetRotation', 4),
    (r'set_localRotation', 'SetLocalRotation', 4),
    (r'set_localScale', 'SetLocalScale', 4),
    (r'get_position.*get_rotation', 'ReadTransform', 4),
    (r'set_position.*set_rotation', 'ApplyTransform', 4),
    (r'get_transform', 'GetTransform', 3),
    (r'get_gameObject', 'GetGameObject', 3),
    (r'get_enabled', 'GetEnabled', 3),
    (r'set_enabled', 'SetEnabled', 3),
    (r'get_activeSelf', 'GetActiveSelf', 3),
    (r'get_activeInHierarchy', 'CheckActiveInHierarchy', 3),
    (r'Instantiate', 'InstantiateObject', 4),
    (r'Destroy\s*\(', 'DestroyObject', 4),
    (r'DestroyImmediate', 'DestroyImmediate', 4),
    (r'DontDestroyOnLoad', 'MarkDontDestroy', 4),
    (r'StartCoroutine', 'StartCoroutine', 3),
    (r'StopCoroutine', 'StopCoroutine', 3),
    (r'StopAllCoroutines', 'StopAllCoroutines', 3),
    (r'Invoke\s*\(', 'InvokeDelayed', 3),
    (r'InvokeRepeating', 'InvokeRepeating', 3),
    (r'CancelInvoke', 'CancelInvoke', 3),
    (r'FindObjectOfType', 'FindObjectOfType', 3),
    (r'FindObjectsOfType', 'FindObjectsOfType', 3),
    (r'GetComponent', 'GetComponent', 3),
    (r'GetComponentInChildren', 'GetComponentInChildren', 3),
    (r'GetComponentInParent', 'GetComponentInParent', 3),
    (r'AddComponent', 'AddComponent', 3),
    (r'SendMessage', 'SendMessage', 3),
    (r'BroadcastMessage', 'BroadcastMessage', 3),
    (r'Play\s*\(', 'Play', 3),
    (r'AudioSource.*Play', 'PlayAudio', 4),
    (r'AudioSource.*Stop', 'StopAudio', 4),
    (r'set_volume', 'SetVolume', 3),
    (r'set_clip', 'SetAudioClip', 3),
    (r'set_material', 'SetMaterial', 3),
    (r'set_color', 'SetColor', 3),
    (r'set_sprite', 'SetSprite', 3),
    (r'set_texture', 'SetTexture', 3),
    (r'set_text', 'SetText', 3),
    (r'get_text', 'GetText', 3),
    (r'set_alpha', 'SetAlpha', 3),
    (r'Lerp', 'LerpValue', 3),
    (r'Slerp', 'SlerpValue', 3),
    (r'MoveTowards', 'MoveTowards', 3),
    (r'LookRotation', 'ComputeLookRotation', 4),
    (r'get_deltaTime', 'GetDeltaTime', 3),
    (r'get_time', 'GetTime', 3),
    (r'get_unscaledTime', 'GetUnscaledTime', 3),
    (r'get_unscaledDeltaTime', 'GetUnscaledDeltaTime', 3),
    (r'get_realtimeSinceStartup', 'GetRealtimeSinceStartup', 3),
    (r'Debug.*Log', 'DebugLog', 2),
    (r'Debug.*Break', 'DebugBreak', 3),
    (r'DrawLine', 'DrawDebugLine', 3),
    (r'DrawRay', 'DrawDebugRay', 3),
    (r'Gizmos', 'DrawGizmos', 3),
    (r'Raycast', 'PerformRaycast', 4),
    (r'SphereCast', 'PerformSphereCast', 4),
    (r'OverlapSphere', 'CheckOverlapSphere', 4),
    (r'OnCollision', 'HandleCollision', 3),
    (r'OnTrigger', 'HandleTrigger', 3),
    (r'set_velocity', 'SetVelocity', 3),
    (r'set_angularVelocity', 'SetAngularVelocity', 3),
    (r'AddForce', 'AddForce', 3),
    (r'AddTorque', 'AddTorque', 3),
    (r'set_isKinematic', 'SetKinematic', 3),
    (r'set_useGravity', 'SetUseGravity', 3),
    (r'Serialize', 'Serialize', 4),
    (r'Deserialize', 'Deserialize', 4),
    (r'JsonUtility', 'ProcessJson', 3),
    (r'PlayerPrefs', 'AccessPlayerPrefs', 3),
    (r'WWW|UnityWebRequest', 'SendWebRequest', 4),
    (r'Download', 'DownloadContent', 3),
    (r'Upload', 'UploadContent', 3),
    (r'AssetBundle', 'LoadAssetBundle', 3),
    (r'Resources\.Load', 'LoadResource', 3),
    (r'SceneManager', 'ManageScene', 3),
    (r'Application\.Quit', 'QuitApplication', 4),
    (r'get_isPlaying', 'CheckIsPlaying', 3),
    (r'get_isFocused', 'CheckIsFocused', 3),
    (r'Screen.*Resolution', 'GetScreenResolution', 3),
    (r'QualitySettings', 'ConfigureQuality', 3),
    (r'set_targetFrameRate', 'SetTargetFrameRate', 4),
    (r'XRSettings', 'ConfigureXR', 3),
]

def analyze_pseudocode(code: str) -> list[tuple[str, int]]:
    """Return list of (predicted_name, priority) from pseudocode."""
    results = []
    for pattern, name, priority in RULES:
        if re.search(pattern, code):
            results.append((name, priority))
    return results

def pick_best_name(candidates: list[tuple[str, int]], used: set) -> str | None:
    """Pick highest priority non-conflicting name."""
    candidates.sort(key=lambda x: -x[1])
    for name, _ in candidates:
        if name not in used:
            return name
    # Try with suffix
    for name, _ in candidates:
        for i in range(2, 10):
            suffixed = f'{name}{i}'
            if suffixed not in used:
                return suffixed
    return None

def main():
    nm = json.load(open(BASE / 'output' / 'name_mapping.json', 'r', encoding='utf-8'))
    methods_map = nm['methods']
    classes_map = nm['classes']
    hash_pat = re.compile(r'^m_[0-9A-F]{3}$')

    # Load all batches
    batch_dir = BASE / 'output' / 'llm_batches_hexrays'
    all_targets = []
    for bf in sorted(batch_dir.glob('batch_*.json')):
        all_targets.extend(json.load(open(bf, 'r', encoding='utf-8')))
    print(f'Total targets: {len(all_targets)}')

    predictions = {}
    used_per_class = {}
    matched = 0
    no_match = 0
    by_rule = Counter()

    for t in all_targets:
        key = t['key']
        cls = t['class']
        pseudocode = t.get('pseudocode', '')
        strings = t.get('strings', [])
        callees = t.get('callee_names', [])

        if cls not in used_per_class:
            used_per_class[cls] = set()

        candidates = []

        # From pseudocode
        if pseudocode:
            candidates.extend(analyze_pseudocode(pseudocode))

        # From strings
        for s in strings:
            for pattern, name, priority in RULES:
                if re.search(pattern, s):
                    candidates.append((name, priority + 1))

        # From callee names
        for c in callees:
            if c and not hash_pat.match(c):
                candidates.append((c, 2))

        if not candidates:
            no_match += 1
            continue

        best = pick_best_name(candidates, used_per_class[cls])
        if best:
            predictions[key] = best
            used_per_class[cls].add(best)
            matched += 1
            by_rule[best.rstrip('0123456789')] = by_rule.get(best.rstrip('0123456789'), 0) + 1

    print(f'Predictions: {matched}')
    print(f'No match: {no_match}')
    print(f'Top rules:')
    for name, count in by_rule.most_common(20):
        print(f'  {name}: {count}')

    out = BASE / 'output' / 'pseudocode_rule_names.json'
    with open(out, 'w', encoding='utf-8') as f:
        json.dump(predictions, f, indent=2, ensure_ascii=False)
    print(f'Saved to {out}')

if __name__ == '__main__':
    main()
