#!/usr/bin/env python3
"""Remove suspicious generic/hash-like method predictions."""

from __future__ import annotations

import json
import re
import shutil
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
PREDICTIONS_PATH = ROOT / "output" / "cross_version_method_names.json"
BACKUP_PATH = ROOT / "output" / "cross_version_method_names.pre_cleanup.json"

EXACT_SUSPICIOUS = {
    "Update",
    "Init",
    "Initialize",
    "Start",
    "Awake",
    "OnDestroy",
    "OnEnable",
    "OnDisable",
    "Reset",
    "GetHashCode",
    "ToString",
    "Equals",
    "MoveNext",
    "SetStateMachine",
    "Dispose",
}

SHORT_GENERIC = {"Run", "Do", "Go", "Set", "Get", "Add", "Log", "End"}
HASH_LIKE_RE = re.compile(r"m_[0-9A-Fa-f]{3}")


def suspicious_reason(name: object) -> str | None:
    if not isinstance(name, str):
        return "non-string prediction"

    if name in EXACT_SUSPICIOUS:
        return "exact suspicious name"

    if len(name) <= 4 and name in SHORT_GENERIC:
        return "short generic name"

    if HASH_LIKE_RE.fullmatch(name):
        return "still hash-like"

    return None


def main() -> int:
    with PREDICTIONS_PATH.open("r", encoding="utf-8") as f:
        predictions = json.load(f)

    if not isinstance(predictions, dict):
        raise TypeError(f"{PREDICTIONS_PATH} must contain a JSON object")

    if not BACKUP_PATH.exists():
        shutil.copy2(PREDICTIONS_PATH, BACKUP_PATH)
        backup_status = "created"
    else:
        backup_status = "already exists; left unchanged"

    cleaned: dict[str, object] = {}
    removed: list[dict[str, str]] = []

    for signature, predicted_name in predictions.items():
        reason = suspicious_reason(predicted_name)
        if reason:
            removed.append(
                {
                    "signature": str(signature),
                    "predicted_name": str(predicted_name),
                    "reason": reason,
                }
            )
            continue
        cleaned[signature] = predicted_name

    with PREDICTIONS_PATH.open("w", encoding="utf-8") as f:
        json.dump(cleaned, f, indent=2, ensure_ascii=False)
        f.write("\n")

    print(f"backup: {BACKUP_PATH} ({backup_status})")
    print(f"removed count: {len(removed)}")
    print(f"kept count: {len(cleaned)}")
    print("sample of removed:")
    print(json.dumps(removed[:20], indent=2, ensure_ascii=False))
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
