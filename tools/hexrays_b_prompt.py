#!/usr/bin/env python3
"""
Path B prompt generator — maximum-context prompt for Gemini/codex.

Writes a single prompt to stdout combining:
- Beebyte/IL2CPP context so the LLM understands the noise
- Per-method context: class, parent, named siblings, fields, strings, pseudocode
- Few-shot examples of good reasoning
- Strict output contract
"""
import json, sys
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

if len(sys.argv) < 2:
    print("Usage: hexrays_b_prompt.py <batch_file>", file=sys.stderr)
    sys.exit(1)

batch_file = Path(sys.argv[1])
with open(batch_file, 'r', encoding='utf-8') as f:
    entries = json.load(f)

SYSTEM = """You are a senior reverse engineer with 10+ years of .NET/IL2CPP experience, \
fluent in decompiling Unity games. You are analyzing VRChat, a Unity IL2CPP title obfuscated \
by Beebyte Obfuscator (class/method/field names replaced with ÌÍÎÏ codepoints; here already \
demangled to m_XXX hash placeholders for hash-fallback methods).

## How to read the evidence

**Pseudocode** is your PRIMARY signal. IDA Hex-Rays output has noise:
- `sub_XXXXXXXX` = unresolved callees (often IL2CPP runtime: il2cpp_object_new, GC.AllocateArray, \
string format, property getters/setters; or obfuscated internal helpers).
- `qword_XXX` / `byte_XXX` / `unk_XXX` = static fields/globals (class metadata, lazy-init flags, \
cached reflection tokens).
- `ZukurNdowUx_0`, `sub_180A45F20`, `sub_180A5F200`, `sub_1809E99F0`, `sub_1809D1C80` = common \
Beebyte helper stubs (class-init, null-check-throw, metadata lookup). **Ignore these.**
- Patterns like `*(_QWORD *)(a1 + OFFSET)` = field access. Offset 16/24 often = m_CachedPtr / data; \
32-96 = instance fields in layout order.
- `if (!a1) sub_1809E99F0(...)` = null argument check; means this is an instance method.
- `_InterlockedOr` / `byte_XXX = 1` followed by `qword_XXX + 224` = static constructor guard \
(cctor pattern); method uses this static.

**Signature shape** tells a lot:
- `__int64 a1` (first param) = `this` pointer on instance methods.
- Last param is often the IL2CPP `MethodInfo*` — ignore.
- Return type `__int64` + returning offset = getter. Returning 1 byte = bool check.
- `void`-style + writes to `*(_QWORD*)(a1+X) = a2` = setter.

**Named siblings** anchor the class theme. If a class already has \
`SetPosition, GetPosition, Reset, Spawn`, the unknown method is likely in the same domain \
(transform/spawning). Use them to narrow the semantic space.

**Strings** are ground truth when present (log messages, error text, Unity API names).

## Naming rules (strict)

- **PascalCase**, 4-50 chars, no underscores except for Unity patterns like `OnEnable`, `IL_Process`.
- **Be specific**: `ApplyInventorySlotVisibility` > `UpdateUI`; `EvaluateAntiAliasingLevel` > `Process`.
- **Ban generic verbs alone**: NO bare `Update`, `Process`, `Handle`, `Execute`, `Init`, `Setup`, \
`Run`, `DoWork`, `Method`, `Call`, `Invoke`, `Helper`, `Wrapper`, `Utility`.
- Getter pattern → `Get<Thing>` or `<Thing>` (noun). Setter → `Set<Thing>`. Boolean → `Is/Has/Can<Thing>`.
- Event-shaped → `On<Event>` or `Handle<Event>`. Coroutine/async → `<Verb>Async` / `<Verb>Coroutine`.
- If it's a property getter/setter thunk (single offset read/write), name the PROPERTY not the verb: \
e.g. `get_IsReady` / `set_IsReady`.
- If class already has `get_X/set_X` pairs, mirror the style.

## Confidence discipline — THIS IS CRITICAL

Emit a prediction ONLY if you are ≥70% confident. A correct omission is better than a wrong \
name that pollutes the vocabulary. If pseudocode is just `return sub_XXX(a1+16);` with no \
siblings giving a hint, OMIT the key — don't guess `GetValue` or `Process`. Quality over quantity.

Expected hit rate: 40-70% of methods. The rest are genuinely unanalyzable from the given evidence.

## Few-shot examples

Example A (strong signal):
  Class: SteamVR_Action_Pose (extends SteamVR_Action)
  Named siblings: GetLocalPosition, GetLastVelocity, GetLocalRotation
  Pseudocode: returns *(Vector3*)(a1 + 120); // read 12-byte at offset 120
  → Good name: "GetLastAngularVelocity"  (sibling pattern + Vector3 getter)

Example B (ambiguous — OMIT):
  Class: ObjectPool_1
  Pseudocode: return sub_1809E99B0(*(_QWORD*)(a1+16));
  Named siblings: (none)
  → OMIT. Could be Get/Peek/Pop/Rent — no way to disambiguate.

Example C (string evidence):
  Class: HttpWebRequest
  Pseudocode: logs "HttpWebRequest.BeginGetRequestStream timed out"
  → Good name: "RunWithTimeoutWorker" or "BeginGetRequestStream" (string anchors verb)

## Output contract — ONLY a raw JSON object

Keys: the exact "class::m_XXX" provided (use `cv_key` verbatim).
Values: the PascalCase predicted name (string).
Omit keys you are not confident about.

NO markdown fences. NO explanation. NO "reasoning" prose. Just:
{"Class::m_AB1": "SemanticName", "Class::m_CD2": "AnotherName"}
"""

# Build compact method blocks
blocks = []
for e in entries:
    block = f"### {e['cv_key']}\n"
    block += f"Class: {e['class']}"
    if e.get('parent'):
        block += f" (extends {e['parent']})"
    block += "\n"
    if e.get('named_methods'):
        block += f"Named siblings ({len(e['named_methods'])}): {', '.join(e['named_methods'])}\n"
    if e.get('fields'):
        block += f"Fields: {', '.join(e['fields'])}\n"
    if e.get('strings'):
        block += f"String refs: {', '.join(repr(s) for s in e['strings'])}\n"
    if e.get('pseudocode'):
        lines = e['pseudocode'].split('\n')
        # Keep signature (first ~3 lines) + up to 50 body lines
        keep = lines[:55]
        body = '\n'.join(keep)
        if len(lines) > 55:
            body += f'\n// ... {len(lines)} lines total, truncated'
        block += f"Pseudocode:\n```c\n{body}\n```\n"
    blocks.append(block)

print(SYSTEM)
print()
print(f"## Methods to analyze ({len(entries)} total)")
print()
print('\n'.join(blocks))
print()
print("## Your response (raw JSON only, no fences, no prose)")
