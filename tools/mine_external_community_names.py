#!/usr/bin/env python3
"""
Mine external community deobfuscation maps for readable names not yet present in
output/name_mapping.json and write them to output/external_mined_names.json.
"""

from __future__ import annotations

import gzip
import json
import re
from pathlib import Path


ROOT = Path(__file__).resolve().parent.parent
OUTPUT_PATH = ROOT / "output" / "external_mined_names.json"
NAME_MAP_PATH = ROOT / "output" / "name_mapping.json"

SEARCH_ROOTS = [
    ROOT / "external" / "deob-maps",
    ROOT / "external" / "LavaGang-Maps",
    ROOT / "external" / "VRChat-Deobfuscation-Maps",
    ROOT / "external" / "EWorldTools-Maps",
]

TEXT_SUFFIXES = {".json", ".csv", ".txt", ".md"}
ENCODED_PREFIXES = (
    "MonoBehaviour",
    "Object",
    "ValueType",
    "Interface",
    "Enum",
    "CustomYieldInstruction",
    "PropertyAttribute",
    "ScriptableObject",
    "MulticastDelegate",
    "Exception",
)
ENCODED_MARKERS = (
    "Public",
    "Private",
    "Abstract",
    "Sealed",
    "Unique",
    "NPublic",
    "NPrivate",
    "NInternal",
    "IEnumerator",
    "IDisposable",
    "IAsyncStateMachine",
)
STOP_NAMES = {
    "None",
    "NONE",
    "Error",
    "Success",
    "Default",
    "Unknown",
    "Invalid",
    "Unused",
    "Empty",
    "Null",
}
PAIR_KEY_SETS = (
    ("obf", "real"),
    ("obfuscated", "real_name"),
    ("signature", "name"),
    ("sig", "name"),
    ("old", "new"),
    ("from", "to"),
)
SIG_RE = re.compile(r"^[\u00CC-\u00CF]+$")
ENCODED_NAME_RE = re.compile(
    r"^(?:MonoBehaviour|Object\d*|Object|ValueType|Interface|Enum|CustomYieldInstruction|"
    r"PropertyAttribute|ScriptableObject|MulticastDelegate|Exception)"
    r".*(?:Public|Private|Abstract|Sealed|Unique|NPublic|NPrivate|NInternal)"
)
ITERATOR_RE = re.compile(r"(^|[.])_?[A-Za-z0-9]+_d__\d+$")


def load_known_names() -> set[str]:
    data = json.loads(NAME_MAP_PATH.read_text(encoding="utf-8"))
    known: set[str] = set()
    for section in ("classes", "methods", "fields"):
        values = data.get(section, {})
        if not isinstance(values, dict):
            continue
        for value in values.values():
            if isinstance(value, str) and value:
                known.add(value)
    return known


def is_supported_file(path: Path) -> bool:
    suffixes = [suffix.lower() for suffix in path.suffixes]
    if path.suffix.lower() in TEXT_SUFFIXES:
        return True
    return len(suffixes) >= 2 and suffixes[-2:] == [".csv", ".gz"]


def source_sort_key(path: Path) -> tuple[int, int, int, str]:
    rel = path.relative_to(ROOT).as_posix()
    repo_rank = 50
    if "EWorldTools-Maps" in rel:
        repo_rank = 0
    elif "lilfluff-Maps" in rel:
        repo_rank = 1
    elif "VRChat-Deobfuscation-Maps" in rel:
        repo_rank = 2
    elif "LavaGang-Maps" in rel:
        repo_rank = 3

    build_nums = [int(num) for num in re.findall(r"(?<![A-Za-z])(\d{3,4})(?![A-Za-z])", path.name)]
    build_rank = -max(build_nums) if build_nums else 0

    if path.name.lower().endswith(".csv.gz") or path.suffix.lower() == ".csv":
        type_rank = 0
    elif path.suffix.lower() == ".json":
        type_rank = 1
    elif path.suffix.lower() == ".txt":
        type_rank = 2
    else:
        type_rank = 3
    return repo_rank, build_rank, type_rank, rel


def iter_candidate_files() -> list[Path]:
    seen: set[Path] = set()
    files: list[Path] = []
    for root in SEARCH_ROOTS:
        if not root.exists():
            continue
        for path in root.rglob("*"):
            if not path.is_file() or not is_supported_file(path):
                continue
            resolved = path.resolve()
            if resolved in seen:
                continue
            seen.add(resolved)
            files.append(path)
    return sorted(files, key=source_sort_key)


def normalize_sig(sig: str) -> str:
    return sig.strip().lstrip(".")


def looks_sig_like(value: str) -> bool:
    text = normalize_sig(value)
    if not text:
        return False
    return (
        "::" in text
        or SIG_RE.fullmatch(text) is not None
        or text.startswith(ENCODED_PREFIXES)
        or "." in text
    )


def is_quality_name(name: str) -> bool:
    if not isinstance(name, str):
        return False
    name = name.strip()
    if not name or len(name) < 3 or len(name) > 180:
        return False
    if any(ch.isspace() for ch in name):
        return False
    if name in STOP_NAMES:
        return False
    if name.startswith("__c") or name.startswith("<>"):
        return False
    if name.startswith("_PrivateImplementationDetails_"):
        return False
    if "_Duplicate_" in name:
        return False
    if ITERATOR_RE.search(name):
        return False
    if ENCODED_NAME_RE.search(name):
        return False
    if "Unique" in name and any(marker in name for marker in ENCODED_MARKERS):
        return False
    return True


def parse_csvish_file(path: Path) -> list[tuple[str, str]]:
    suffixes = [suffix.lower() for suffix in path.suffixes]
    if len(suffixes) >= 2 and suffixes[-2:] == [".csv", ".gz"]:
        opener = gzip.open
    else:
        opener = open

    pairs: list[tuple[str, str]] = []
    with opener(path, "rt", encoding="utf-8-sig") as handle:
        for raw_line in handle:
            line = raw_line.strip()
            if not line or line.startswith("#"):
                continue
            parts = line.split(";", 2)
            if len(parts) < 2:
                continue
            sig = normalize_sig(parts[0])
            name = parts[1].strip()
            if sig and name:
                pairs.append((sig, name))
    return pairs


def parse_text_file(path: Path) -> list[tuple[str, str]]:
    pairs: list[tuple[str, str]] = []
    text = path.read_text(encoding="utf-8-sig", errors="ignore")
    for raw_line in text.splitlines():
        line = raw_line.strip()
        if not line or line.startswith("#"):
            continue
        if ";" in line:
            left, right = line.split(";", 1)
        elif "->" in line:
            left, right = line.split("->", 1)
        elif "=>" in line:
            left, right = line.split("=>", 1)
        else:
            continue
        sig = normalize_sig(left)
        name = right.strip().split(";", 1)[0].strip()
        if looks_sig_like(sig) and name:
            pairs.append((sig, name))
    return pairs


def parse_json_node(node: object) -> list[tuple[str, str]]:
    pairs: list[tuple[str, str]] = []

    if isinstance(node, dict):
        lower_map = {str(key).lower(): key for key in node.keys()}
        for left_key, right_key in PAIR_KEY_SETS:
            if left_key in lower_map and right_key in lower_map:
                left_value = node[lower_map[left_key]]
                right_value = node[lower_map[right_key]]
                if isinstance(left_value, str) and isinstance(right_value, str):
                    pairs.append((normalize_sig(left_value), right_value.strip()))

        string_items = [(key, value) for key, value in node.items() if isinstance(key, str) and isinstance(value, str)]
        if string_items and all(looks_sig_like(key) for key, _ in string_items):
            for key, value in string_items:
                pairs.append((normalize_sig(key), value.strip()))

        for value in node.values():
            pairs.extend(parse_json_node(value))

    elif isinstance(node, list):
        for item in node:
            pairs.extend(parse_json_node(item))

    return pairs


def parse_json_file(path: Path) -> list[tuple[str, str]]:
    try:
        data = json.loads(path.read_text(encoding="utf-8-sig"))
    except json.JSONDecodeError:
        return []
    return parse_json_node(data)


def parse_file(path: Path) -> list[tuple[str, str]]:
    suffixes = [suffix.lower() for suffix in path.suffixes]
    if len(suffixes) >= 2 and suffixes[-2:] == [".csv", ".gz"]:
        return parse_csvish_file(path)
    if path.suffix.lower() == ".csv":
        return parse_csvish_file(path)
    if path.suffix.lower() == ".json":
        return parse_json_file(path)
    return parse_text_file(path)


def mine_external_names() -> tuple[list[dict[str, object]], int, int]:
    known_names = load_known_names()
    emitted_names: set[str] = set()
    results: list[dict[str, object]] = []

    for path in iter_candidate_files():
        mappings: dict[str, str] = {}
        for sig, name in parse_file(path):
            if not looks_sig_like(sig):
                continue
            if not is_quality_name(name):
                continue
            if sig in mappings:
                continue
            if name in known_names or name in emitted_names:
                continue
            mappings[sig] = name
            emitted_names.add(name)
        if mappings:
            results.append(
                {
                    "source": path.relative_to(ROOT).as_posix(),
                    "mappings": dict(sorted(mappings.items())),
                }
            )

    OUTPUT_PATH.parent.mkdir(parents=True, exist_ok=True)
    OUTPUT_PATH.write_text(json.dumps(results, ensure_ascii=False, indent=2), encoding="utf-8")
    return results, len(emitted_names), len(results)


def main() -> None:
    _, novel_count, source_count = mine_external_names()
    print(f"Found {novel_count} novel names from {source_count} sources")


if __name__ == "__main__":
    main()
