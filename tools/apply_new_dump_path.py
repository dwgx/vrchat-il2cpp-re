#!/usr/bin/env python3
"""
Update the default DUMP_PATH constant inside tools/extract_precise_dump.py.

The extractor itself is CLI-arg driven; this helper only rewrites the fallback
default path so the next dump can be made the new implicit target.
"""

from __future__ import annotations

import argparse
import re
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent
DEFAULT_EXTRACTOR_PATH = BASE_DIR / "tools" / "extract_precise_dump.py"
DEFAULT_DUMP_PATH = Path(r"D:\WorkSpace\VRChat\VRChat_Data\VRChat_NEW_full.dmp")

DUMP_PATH_RE = re.compile(r'^DUMP_PATH\s*=\s*r".*"$', re.MULTILINE)


def parse_args():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument(
        "dump_path",
        nargs="?",
        default=str(DEFAULT_DUMP_PATH),
        help=f"New default dump path (default: {DEFAULT_DUMP_PATH})",
    )
    parser.add_argument(
        "--extractor",
        default=str(DEFAULT_EXTRACTOR_PATH),
        help=f"Path to extract_precise_dump.py (default: {DEFAULT_EXTRACTOR_PATH})",
    )
    return parser.parse_args()


def main() -> int:
    args = parse_args()
    extractor_path = Path(args.extractor)
    new_dump_path = Path(args.dump_path)

    if not extractor_path.exists():
        print(f"[-] Extractor not found: {extractor_path}")
        return 1

    source = extractor_path.read_text(encoding="utf-8")
    replacement = f'DUMP_PATH = r"{new_dump_path}"'

    if not DUMP_PATH_RE.search(source):
        print("[-] Could not find DUMP_PATH assignment in extractor.")
        return 1

    updated = DUMP_PATH_RE.sub(replacement, source, count=1)
    if updated == source:
        print(f"[+] No change needed; DUMP_PATH already points to {new_dump_path}")
        return 0

    extractor_path.write_text(updated, encoding="utf-8")
    print(f"[+] Updated {extractor_path}")
    print(f"    DUMP_PATH = {new_dump_path}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
