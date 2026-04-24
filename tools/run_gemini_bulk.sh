#!/bin/bash
# Bulk Gemini CLI runner for focus batches
# Usage: bash tools/run_gemini_bulk.sh [START] [END] [MODEL]
#
# Processes focus_XX.json batches through Gemini CLI via stdin pipe.
# Saves results to output/llm_batches/results/focus_XX_results.json
# Resume-safe: skips batches that already have results.

set -euo pipefail
cd "$(dirname "$0")/.."

START=${1:-28}
END=${2:-387}
MODEL=${3:-gemini-2.5-flash}
DELAY=${4:-3}

FOCUS_DIR="output/llm_batches/focus"
RESULTS_DIR="output/llm_batches/results"
WORKER="tools/gemini_batch_worker.py"

mkdir -p "$RESULTS_DIR"

ok=0
skip=0
err=0
total=0

for i in $(seq "$START" "$END"); do
    idx=$(printf "%02d" "$i")
    # handle 3-digit indices
    if [ "$i" -ge 100 ]; then
        idx=$(printf "%03d" "$i")
    fi

    batch="$FOCUS_DIR/focus_${idx}.json"
    result="$RESULTS_DIR/focus_${idx}_results.json"

    [ ! -f "$batch" ] && continue
    total=$((total + 1))

    # Skip if already has results
    if [ -f "$result" ] && [ -s "$result" ]; then
        count=$(python -c "import json; print(len(json.load(open('$result'))))" 2>/dev/null || echo 0)
        if [ "$count" -gt 0 ]; then
            skip=$((skip + 1))
            echo "[$total] focus_${idx}: SKIP (cached, $count preds) ok=$ok skip=$skip err=$err"
            continue
        fi
    fi

    # Generate prompt and pipe to Gemini
    echo -n "[$total] focus_${idx}: running..."

    tmpfile=$(mktemp)
    if python "$WORKER" "$batch" > "$tmpfile" 2>/dev/null; then
        # Pipe prompt to Gemini via stdin
        raw=$(cat "$tmpfile" | gemini -y -p "IMPORTANT: Return ONLY the raw JSON object mapping method names. No tool calls, no file reads, no explanation, no markdown." --model "$MODEL" 2>/dev/null || echo "ERROR")
        rm -f "$tmpfile"

        # Save raw to temp file first (avoids bash variable size issues)
        rawfile="$RESULTS_DIR/focus_${idx}_raw.txt"
        echo "$raw" > "$rawfile"

        # Extract JSON directly from file (skip grep check - it fails on large output)
        json_str=$(python -c '
import sys, re, json
text = open(sys.argv[1], "r", encoding="utf-8", errors="replace").read()
start = text.find("{")
end = text.rfind("}")
if start >= 0 and end > start:
    try:
        obj = json.loads(text[start:end+1])
        if len(obj) > 0:
            print(json.dumps(obj, ensure_ascii=False, indent=2))
            sys.exit(0)
    except: pass
m = re.search(r"```(?:json)?\s*\n(.*?)\n```", text, re.DOTALL)
if m:
    try:
        obj = json.loads(m.group(1))
        if len(obj) > 0:
            print(json.dumps(obj, ensure_ascii=False, indent=2))
            sys.exit(0)
    except: pass
sys.exit(1)
' "$rawfile" 2>/dev/null)

        if [ $? -eq 0 ] && [ -n "$json_str" ]; then
            echo "$json_str" > "$result"
            count=$(python -c "import json; print(len(json.load(open('$result'))))" 2>/dev/null || echo 0)
            ok=$((ok + 1))
            rm -f "$rawfile"
            echo -e "\r[$total] focus_${idx}: OK ($count preds) ok=$ok skip=$skip err=$err"
        else
            err=$((err + 1))
            echo -e "\r[$total] focus_${idx}: PARSE_ERROR ok=$ok skip=$skip err=$err"
        fi
    else
        rm -f "$tmpfile"
        err=$((err + 1))
        echo -e "\r[$total] focus_${idx}: PROMPT_ERROR ok=$ok skip=$skip err=$err"
    fi

    # Rate limit delay
    [ "$ok" -gt 0 ] && sleep "$DELAY"
done

echo ""
echo "=== DONE ==="
echo "OK: $ok, Skip: $skip, Errors: $err, Total: $total"
