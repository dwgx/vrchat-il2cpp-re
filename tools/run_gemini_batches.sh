#!/bin/bash
# Run Gemini predictions on focus batches in parallel waves
# Usage: bash tools/run_gemini_batches.sh [start] [end]

cd "$(dirname "$0")/.." || exit 1

FOCUS_DIR="output/llm_batches/focus"
RESULTS_DIR="output/llm_batches/results"
TOOLS_DIR="tools"

mkdir -p "$RESULTS_DIR"

START=${1:-0}
END=${2:-19}
PARALLEL=${3:-4}

echo "=== Gemini Batch Predictions ==="
echo "Range: focus_$(printf '%02d' $START) to focus_$(printf '%02d' $END)"
echo "Parallel: $PARALLEL"
echo ""

run_batch() {
    local idx=$1
    local batch_file="$FOCUS_DIR/focus_$(printf '%02d' $idx).json"
    local result_file="$RESULTS_DIR/focus_$(printf '%02d' $idx)_results.json"
    local log_file="/tmp/gemini-focus-$(printf '%02d' $idx).log"

    if [ -f "$result_file" ]; then
        local count=$(python -c "import json; print(len(json.load(open('$result_file'))))" 2>/dev/null)
        if [ "$count" -gt "10" ] 2>/dev/null; then
            echo "[focus_$(printf '%02d' $idx)] SKIP - already has $count results"
            return 0
        fi
    fi

    if [ ! -f "$batch_file" ]; then
        echo "[focus_$(printf '%02d' $idx)] SKIP - file not found"
        return 1
    fi

    echo "[focus_$(printf '%02d' $idx)] Starting..."

    local prompt
    prompt=$(python "$TOOLS_DIR/gemini_batch_worker.py" "$batch_file" 2>/dev/null)

    if [ -z "$prompt" ]; then
        echo "[focus_$(printf '%02d' $idx)] ERROR - failed to generate prompt"
        return 1
    fi

    local response
    response=$(echo "$prompt" | gemini --yolo 2>"$log_file")
    local exit_code=$?

    if [ $exit_code -ne 0 ]; then
        echo "[focus_$(printf '%02d' $idx)] ERROR - gemini exit code $exit_code"
        cat "$log_file" | tail -5
        return 1
    fi

    # Extract JSON from response (handle markdown code blocks)
    local json_str
    json_str=$(echo "$response" | python -c "
import sys, re, json
text = sys.stdin.read()
# Try to find JSON in code blocks first
m = re.search(r'\`\`\`(?:json)?\s*(\{.*?\})\s*\`\`\`', text, re.DOTALL)
if m:
    text = m.group(1)
# Try to find raw JSON object
m = re.search(r'(\{[^{}]*(?:\{[^{}]*\}[^{}]*)*\})', text, re.DOTALL)
if m:
    obj = json.loads(m.group(1))
    json.dump(obj, sys.stdout, ensure_ascii=False, indent=1)
else:
    print('{}')
" 2>/dev/null)

    if [ -z "$json_str" ] || [ "$json_str" = "{}" ]; then
        echo "[focus_$(printf '%02d' $idx)] WARNING - no valid JSON in response"
        echo "$response" > "$result_file.raw"
        return 1
    fi

    echo "$json_str" > "$result_file"
    local count=$(python -c "import json; print(len(json.load(open('$result_file'))))" 2>/dev/null)
    echo "[focus_$(printf '%02d' $idx)] Done - $count predictions"
    return 0
}

# Run in parallel waves
active=0
pids=()
for idx in $(seq $START $END); do
    run_batch $idx &
    pids+=($!)
    active=$((active + 1))

    if [ $active -ge $PARALLEL ]; then
        # Wait for any to finish
        wait -n 2>/dev/null || wait "${pids[0]}"
        active=$((active - 1))
        pids=("${pids[@]:1}")
    fi
done

# Wait for remaining
wait

echo ""
echo "=== Results ==="
total=0
for idx in $(seq $START $END); do
    local_file="$RESULTS_DIR/focus_$(printf '%02d' $idx)_results.json"
    if [ -f "$local_file" ]; then
        count=$(python -c "import json; print(len(json.load(open('$local_file'))))" 2>/dev/null)
        total=$((total + count))
        echo "  focus_$(printf '%02d' $idx): $count predictions"
    else
        echo "  focus_$(printf '%02d' $idx): MISSING"
    fi
done
echo "Total: $total predictions"
