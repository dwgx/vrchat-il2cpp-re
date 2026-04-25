#!/usr/bin/env python3
"""Generate Gemini prompt from a focus batch file and output to stdout."""
import json, sys
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

if len(sys.argv) < 2:
    print("Usage: python gemini_batch_worker.py <batch_file>", file=sys.stderr)
    sys.exit(1)

batch_file = Path(sys.argv[1])
batch_name = batch_file.stem

with open(batch_file, 'r', encoding='utf-8') as f:
    methods = json.load(f)

# Build compact method descriptions
method_blocks = []
for m in methods:
    key = f"{m['class']}::{m['method']}"
    block = f"### {key}\n"
    block += f"Class: {m['class']} (extends {m['parent']})\n"

    if m.get('named_methods'):
        block += f"Named siblings: {', '.join(m['named_methods'][:15])}\n"

    if m.get('fields'):
        block += f"Fields: {', '.join(m['fields'][:10])}\n"

    if m.get('strings'):
        block += f"String refs: {', '.join(repr(s) for s in m['strings'][:10])}\n"

    if m.get('pseudocode'):
        # Truncate pseudocode to first 40 lines for prompt efficiency
        lines = m['pseudocode'].split('\n')
        code = '\n'.join(lines[:40])
        if len(lines) > 40:
            code += f'\n// ... ({len(lines)} lines total)'
        block += f"Pseudocode:\n```c\n{code}\n```\n"

    method_blocks.append(block)

methods_text = '\n'.join(method_blocks)

prompt = f"""You are an expert C# reverse engineer analyzing decompiled VRChat (Unity IL2CPP) methods.

Each method below has an obfuscated name (m_XXX) that needs a meaningful C# PascalCase name.

## Analysis Priority
1. **Pseudocode logic** — the decompiled code reveals what the method ACTUALLY does. This is the strongest signal.
2. **String references** — string literals in the code hint at the method's purpose.
3. **Named siblings** — other named methods in the same class provide context.
4. **Class context** — the class name and parent class indicate the domain.

## Rules
- Use PascalCase (e.g., UpdatePlayerPosition, HandleNetworkEvent)
- Be specific, not generic (NO: Update, Process, Handle, Execute, Init, Setup, Run, DoWork)
- Method names should reflect WHAT the method does based on the pseudocode
- If pseudocode shows a boolean return with checks → likely Is/Has/Can prefix
- If pseudocode shows setting fields → likely Set/Update/Apply prefix
- If pseudocode shows event/callback patterns → likely On/Handle prefix
- If pseudocode shows iteration/search → likely Find/Get/Enumerate prefix
- Length: 4-50 chars, no underscores except for Unity patterns

## Methods to analyze

{methods_text}

## Output Format
Return ONLY a valid JSON object mapping "ClassName::m_XXX" to "PredictedName".
Example: {{"VRC_Secondary::m_D91": "EvaluateVSyncSettings", "AnotherClass::m_ABC": "InitializeNetworkState"}}

No explanation, no markdown code blocks, ONLY the raw JSON object."""

print(prompt)
