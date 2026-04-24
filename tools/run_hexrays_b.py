#!/usr/bin/env python3
"""
Path B runner — iterate batches, call Gemini, save raw predictions.
Resumable: skips batches with existing pred_NNN.json.
"""
import json, re, sys, subprocess, time, shutil
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE = Path(__file__).resolve().parent.parent

GEMINI = shutil.which('gemini.cmd') or shutil.which('gemini') or r'C:\Users\dwgx1\AppData\Roaming\npm\gemini.cmd'
BATCH_DIR = BASE / 'output/llm_batches_hexrays_b'
PROMPT_TOOL = BASE / 'tools/hexrays_b_prompt.py'


def extract_json(text: str) -> dict:
    # Strip code fences if any
    m = re.search(r'```(?:json)?\s*(\{.*?\})\s*```', text, re.DOTALL)
    if m:
        text = m.group(1)
    # Find outermost {...}
    j1 = text.find('{')
    j2 = text.rfind('}')
    if j1 < 0 or j2 <= j1:
        return {}
    try:
        return json.loads(text[j1:j2 + 1])
    except Exception:
        return {}


def run_batch(bf: Path, pred_file: Path) -> int:
    rel = str(bf.relative_to(BASE)).replace('\\', '/')
    # Directive short prompt — Gemini reads the batch file via its FS tool.
    # Key facts crammed in: context, signals, anti-patterns, confidence, output contract.
    short_cmd = (
        f"TASK: Read {rel} and output ONLY a raw JSON object mapping each entry's `cv_key` "
        f"to a predicted PascalCase C# method name. No greeting, no prose, no code fences.\n\n"
        f"CONTEXT: VRChat IL2CPP binary obfuscated by Beebyte. Each entry is a hash-fallback "
        f"method (m_XXX) needing a semantic name. Primary signal is `pseudocode` (IDA Hex-Rays); "
        f"secondary are `named_methods` (sibling methods in the same class), `fields`, "
        f"`strings`, `class`, `parent`.\n\n"
        f"PSEUDOCODE READING GUIDE:\n"
        f"- `sub_XXX` calls = obfuscated helpers (il2cpp runtime/Beebyte stubs) — ignore names, "
        f"focus on STRUCTURE.\n"
        f"- `qword_XXX`, `byte_XXX` = static fields / class-init flags. `_InterlockedOr` + "
        f"`qword+224` = cctor guard — ignore.\n"
        f"- `*(_QWORD*)(a1+N)` = instance field read at offset N. Offset 16 often = cached ptr, "
        f"24 = count, 32+ = fields.\n"
        f"- Return type + access pattern tells you the shape: offset read → Getter; "
        f"offset write → Setter; boolean-shaped (compare + return 0/1) → Is/Has/Can.\n"
        f"- First param `a1` = `this` on instance methods. Last `__int64` is often MethodInfo* "
        f"— ignore.\n\n"
        f"NAMING RULES:\n"
        f"- PascalCase, 4-50 chars.\n"
        f"- BE SPECIFIC. Use class theme + siblings to pick a concrete domain verb + noun.\n"
        f"- BANNED generic names alone: Update, Process, Handle, Execute, Init, Setup, Run, "
        f"DoWork, Method, Call, Invoke, Helper, Wrapper, Utility, Get, Set, Check.\n"
        f"- Getter thunks (single offset read) → `get_<Thing>` matching the class's existing "
        f"property style if any; else use the noun.\n"
        f"- If class has SteamVR/Unity/ZLogger/JsonSerializer theme, mirror the library's "
        f"naming idioms.\n\n"
        f"CONFIDENCE: Only emit predictions you are ≥70% confident about. OMIT keys you can't "
        f"disambiguate from the evidence — a missing prediction is better than a wrong one. "
        f"Expected hit rate 40-70% per batch.\n\n"
        f"OUTPUT: Exactly one JSON object, nothing else. Keys must match the `cv_key` strings "
        f"verbatim. Example: {{\"VRC_Secondary::m_D91\": \"EvaluateVSync\", "
        f"\"NetworkUI::m_7AB\": \"RenderLatencyOverlay\"}}"
    )

    for attempt in range(4):
        try:
            r = subprocess.run(
                [GEMINI, '-p', short_cmd, '-y'],
                capture_output=True, text=True, encoding='utf-8', errors='replace',
                cwd=str(BASE), timeout=420, shell=False,
            )
        except subprocess.TimeoutExpired:
            print(f'    [!] timeout')
            return 0
        out = r.stdout or ''
        if '429' in out or 'rate limit' in out.lower() or 'quota' in out.lower():
            wait = 60 * (attempt + 1)
            print(f'    [!] rate limited, waiting {wait}s...')
            time.sleep(wait)
            continue
        d = extract_json(out)
        if d:
            with open(pred_file, 'w', encoding='utf-8') as f:
                json.dump(d, f, indent=1, ensure_ascii=False)
            return len(d)
        # Save raw on failure
        with open(str(pred_file) + '.raw.txt', 'w', encoding='utf-8') as f:
            f.write(out)
        return 0
    return 0


def main():
    batches = sorted(BATCH_DIR.glob('batch_*.json'))
    if not batches:
        print('No batches. Run build_hexrays_b_batches.py first.')
        return

    print(f'Running {len(batches)} batches via Gemini...')
    total_pred = 0
    for i, bf in enumerate(batches):
        pf = BATCH_DIR / f'pred_{bf.stem.split("_")[1]}.json'
        if pf.exists():
            try:
                n = len(json.load(open(pf, 'r', encoding='utf-8')))
                total_pred += n
                print(f'[{i + 1}/{len(batches)}] {bf.name} SKIP ({n} existing)')
                continue
            except Exception:
                pass
        t0 = time.time()
        n = run_batch(bf, pf)
        total_pred += n
        print(f'[{i + 1}/{len(batches)}] {bf.name} → {n} preds ({time.time() - t0:.0f}s)')
        time.sleep(2)

    print(f'\nDone. Total predictions: {total_pred}')


if __name__ == '__main__':
    try:
        main()
    except KeyboardInterrupt:
        print('\nInterrupted.')
