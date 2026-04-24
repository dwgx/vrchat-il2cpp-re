#!/bin/bash
# Orchestrator: dispatches 8 at a time, waits, continues until all 76 done
cd "D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools"

NEXT=8  # already dispatched 0-7
TOTAL=76

while [ $NEXT -lt $TOTAL ]; do
  # Wait until all currently running codex processes down to safe level
  while true; do
    count=$(ls output/llm_weak_body_*.json 2>/dev/null | wc -l)
    if [ "$count" -ge "$NEXT" ]; then
      break
    fi
    sleep 30
  done
  # Dispatch next 8
  END=$((NEXT + 8))
  if [ $END -gt $TOTAL ]; then
    END=$TOTAL
  fi
  echo "$(date +%H:%M) Dispatching chunks $NEXT..$((END-1))"
  for i in $(seq $NEXT $((END-1))); do
    num=$(printf "%03d" $i)
    filename=$(openssl rand -hex 4)
    codex exec --skip-git-repo-check --full-auto \
      -C "D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools" \
      --config model_reasoning_effort="medium" \
      2>>"/tmp/codex-${filename}.log" <<INEOF &
Read data/weak_body_chunks/chunk_${num}.json. 100 hash methods with class+strings+callees+body_preview.

For each, predict a C#/Unity PascalCase method name. Be aggressive 40-60% coverage.
Output: output/llm_weak_body_${num}.json as {'key': name, ...}
Execute. Report count. No chat.
INEOF
  done
  NEXT=$END
  sleep 15
done
echo "All 76 dispatched. Waiting for completion..."
while true; do
  count=$(ls output/llm_weak_body_*.json 2>/dev/null | wc -l)
  if [ "$count" -ge "$TOTAL" ]; then
    break
  fi
  sleep 60
done
echo "All 76 complete!"
