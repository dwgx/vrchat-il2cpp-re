#!/bin/bash
# Run Gemini batch predictions for method name deobfuscation
# Usage: bash tools/run_gemini_predictions.sh [start_batch] [end_batch]
#   Default: processes all 15 mega batches (0-14)

BASE_DIR="D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools"
BATCH_DIR="$BASE_DIR/output/llm_batches/mega"
RESULT_DIR="$BASE_DIR/output/llm_batches/results"
mkdir -p "$RESULT_DIR"

START=${1:-0}
END=${2:-14}
PARALLEL=3  # max concurrent gemini calls

PROMPT_TEMPLATE='Read the file %s. It contains %d obfuscated VRChat IL2CPP methods that need C# name prediction.

Each method entry has:
- class/parent: class context
- method: hash placeholder (m_XXX)
- named_methods: other named methods in same class
- fields: class fields with types
- strings: string literals referenced by compiled code (STRONGEST naming hint)
- call_count: complexity indicator
- pseudocode: Hex-Rays decompiled C pseudocode (STRONGEST signal — read the actual logic)

For each method, predict a meaningful C# PascalCase method name. Priority:
1. Pseudocode logic (if available — the decompiled code reveals what the method ACTUALLY does)
2. String refs (e.g. "DynamicBone" in strings → method likely manages dynamic bones)
3. Named siblings (if class has UpdateAvatar, LoadTexture → related method likely avatar/texture related)
4. Class purpose from name/parent

Rules:
- PascalCase (UpdatePlayerPosition, HandleNetworkEvent)
- Be specific not generic
- If strings mention Unity APIs, use those as hints (SetActive → likely a visibility toggle)

Write results as JSON to %s in format:
{"ClassName::m_XXX": "PredictedName", ...}

Write ONLY the JSON file. No other output or explanation.'

running=0
for i in $(seq $START $END); do
    batch=$(printf "mega_%02d.json" $i)
    result=$(printf "result_%02d.json" $i)
    input_file="$BATCH_DIR/$batch"
    output_file="$RESULT_DIR/$result"

    if [ -f "$output_file" ]; then
        echo "[$batch] Already exists, skipping"
        continue
    fi

    count=$(python3 -c "import json; print(len(json.load(open('$input_file'))))" 2>/dev/null || echo "?")
    prompt=$(printf "$PROMPT_TEMPLATE" "$input_file" "$count" "$output_file")

    echo "[$batch] Starting ($count methods)..."
    (
        cd "$BASE_DIR"
        logfile="/tmp/gemini-batch-$(openssl rand -hex 4).log"
        gemini -y -p "$prompt" 2>>"$logfile"
        exit_code=$?
        if [ $exit_code -eq 0 ] && [ -f "$output_file" ]; then
            echo "[$batch] Done! → $result"
        else
            echo "[$batch] FAILED (exit=$exit_code), log: $logfile"
        fi
    ) &

    running=$((running + 1))
    if [ $running -ge $PARALLEL ]; then
        wait -n
        running=$((running - 1))
    fi
done

wait
echo "All batches complete. Results in: $RESULT_DIR"
