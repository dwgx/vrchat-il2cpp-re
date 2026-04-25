#!/usr/bin/env python3
"""
Convert a Windows kernel crash dump into a synthetic process minidump that
contains only a MINIDUMP_MEMORY64_LIST stream.

This script shells out to Volatility3 for process discovery, VAD metadata, and
process memory extraction:

1. `windows.pslist.PsList` finds the target process and its EPROCESS offset.
2. `windows.vadinfo.VadInfo` enumerates VAD regions for stats.
3. `windows.memmap.Memmap --dump` emits the present user pages into
   `pid.<PID>.dmp` plus the virtual/file-offset mapping we need to repack those
   bytes as a synthetic MDMP stream type 9.

The output file is intentionally minimal because the downstream readers in this
repo only consume the MDMP header, stream directory, and Memory64List stream.
"""

from __future__ import annotations

import argparse
import json
import math
import shutil
import struct
import subprocess
import sys
from dataclasses import dataclass
from pathlib import Path
from typing import Iterable


ROOT = Path(__file__).resolve().parent.parent
DEFAULT_KERNEL_DUMP = Path(r"C:\Windows\MEMORY.DMP")
DEFAULT_OUTPUT = ROOT / "tools" / "VRChat_kernel_full.dmp"
DEFAULT_WORKDIR = ROOT / "tools" / "kernel_minidump_work"
DEFAULT_PROCESS_NAME = "VRChat.exe"
USER_VA_LIMIT = 0x0000800000000000
MDMP_SIGNATURE = 0x504D444D  # "MDMP" little-endian
MDMP_VERSION = 0x0000A793
STREAM_TYPE_MEMORY64_LIST = 9
COPY_CHUNK_SIZE = 64 * 1024 * 1024


@dataclass(frozen=True)
class ProcessInfo:
    pid: int
    name: str
    eprocess: int
    create_time: str | None


@dataclass(frozen=True)
class VadRegion:
    start: int
    end: int
    size: int
    commit_charge: int
    private_memory: int
    protection: str


@dataclass(frozen=True)
class MemoryRange:
    start: int
    size: int
    source_offset: int

    @property
    def end(self) -> int:
        return self.start + self.size


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--kernel-dump", default=str(DEFAULT_KERNEL_DUMP))
    parser.add_argument("--output", default=str(DEFAULT_OUTPUT))
    parser.add_argument("--workdir", default=str(DEFAULT_WORKDIR))
    parser.add_argument("--process-name", default=DEFAULT_PROCESS_NAME)
    parser.add_argument("--pid", type=int, default=None, help="Skip pslist lookup and use this PID directly")
    parser.add_argument("--vol-cmd", default="vol", help="Volatility3 CLI executable")
    parser.add_argument("--clear-workdir", action="store_true", help="Delete previous workdir contents before running")
    parser.add_argument("--keep-workdir", action="store_true", help="Keep intermediate Volatility outputs")
    parser.add_argument("--offline", action="store_true", help="Pass --offline to Volatility")
    return parser.parse_args()


def parse_hexish(value: object) -> int:
    if isinstance(value, int):
        return value
    if isinstance(value, str):
        text = value.strip()
        if text.lower().startswith("0x"):
            return int(text, 16)
        return int(text, 10)
    raise TypeError(f"Cannot parse integer value from {value!r}")


def align_up(value: int, alignment: int) -> int:
    return (value + alignment - 1) & ~(alignment - 1)


def ensure_json_list(raw: str) -> list[dict[str, object]]:
    text = raw.strip()
    if not text:
        raise RuntimeError("Volatility returned no JSON output")
    data = json.loads(text)
    if not isinstance(data, list):
        raise RuntimeError(f"Unexpected Volatility JSON payload: {type(data).__name__}")
    return [row for row in data if isinstance(row, dict)]


def get_offset_value(row: dict[str, object]) -> object:
    for key, value in row.items():
        if key.startswith("Offset"):
            return value
    raise RuntimeError(f"Volatility row is missing an Offset column: {row}")


def run_volatility(
    vol_cmd: str,
    kernel_dump: Path,
    plugin: str,
    plugin_args: Iterable[str],
    *,
    workdir: Path | None = None,
    output_dir: Path | None = None,
    offline: bool = False,
) -> list[dict[str, object]]:
    cmd = [vol_cmd, "-q", "-f", str(kernel_dump)]
    if offline:
        cmd.append("--offline")
    if output_dir is not None:
        cmd.extend(["-o", str(output_dir)])
    cmd.extend(["-r", "json", plugin, *plugin_args])

    # Note: vol3 expects -o (output_dir) relative to its own cwd. Keep
    # cwd at the script's working dir (None) and pass output_dir as an
    # absolute path so it resolves correctly regardless of cwd.
    if output_dir is not None:
        # Replace last "-o" arg with absolute path
        for i, a in enumerate(cmd):
            if a == "-o" and i + 1 < len(cmd):
                cmd[i + 1] = str(Path(cmd[i + 1]).resolve())
                break
    proc = subprocess.run(
        cmd,
        capture_output=True,
        text=True,
        encoding="utf-8",
        errors="replace",
    )
    if proc.returncode != 0:
        details = proc.stderr.strip() or proc.stdout.strip() or "unknown volatility failure"
        raise RuntimeError(f"Volatility failed for {plugin}: {details}")

    return ensure_json_list(proc.stdout)


def pick_process(rows: list[dict[str, object]], process_name: str) -> ProcessInfo:
    wanted = process_name.lower()
    matches: list[ProcessInfo] = []
    for row in rows:
        name = str(row.get("ImageFileName") or "")
        if name.lower() != wanted:
            continue
        exit_time = row.get("ExitTime")
        if exit_time not in (None, "", "N/A"):
            continue
        matches.append(
            ProcessInfo(
                pid=int(row["PID"]),
                name=name,
                eprocess=parse_hexish(get_offset_value(row)),
                create_time=str(row.get("CreateTime")) if row.get("CreateTime") else None,
            )
        )

    if not matches:
        raise RuntimeError(f"Process {process_name!r} was not found in pslist output")

    matches.sort(key=lambda item: (item.create_time or "", item.pid), reverse=True)
    return matches[0]


def load_vads(
    vol_cmd: str,
    kernel_dump: Path,
    pid: int,
    *,
    workdir: Path,
    offline: bool,
) -> list[VadRegion]:
    rows = run_volatility(
        vol_cmd,
        kernel_dump,
        "windows.vadinfo.VadInfo",
        ["--pid", str(pid)],
        workdir=workdir,
        offline=offline,
    )

    vads: list[VadRegion] = []
    for row in rows:
        start = parse_hexish(row["Start VPN"])
        end = parse_hexish(row["End VPN"])
        if start >= USER_VA_LIMIT:
            continue
        end = min(end, USER_VA_LIMIT - 1)
        if end < start:
            continue
        size = end - start + 1
        vads.append(
            VadRegion(
                start=start,
                end=end,
                size=size,
                commit_charge=int(row.get("CommitCharge") or 0),
                private_memory=int(row.get("PrivateMemory") or 0),
                protection=str(row.get("Protection") or ""),
            )
        )

    vads.sort(key=lambda item: item.start)
    return vads


def load_memmap(
    vol_cmd: str,
    kernel_dump: Path,
    pid: int,
    *,
    workdir: Path,
    offline: bool,
) -> tuple[Path, list[MemoryRange]]:
    rows = run_volatility(
        vol_cmd,
        kernel_dump,
        "windows.memmap.Memmap",
        ["--pid", str(pid), "--dump"],
        workdir=workdir,
        output_dir=workdir,
        offline=offline,
    )

    source_dump = workdir / f"pid.{pid}.dmp"
    if not source_dump.exists():
        raise RuntimeError(f"Volatility did not create expected dump file: {source_dump}")

    ranges: list[MemoryRange] = []
    for row in rows:
        start = parse_hexish(row["Virtual"])
        size = parse_hexish(row["Size"])
        file_offset = parse_hexish(row["Offset in File"])
        if size <= 0 or start >= USER_VA_LIMIT:
            continue
        if start + size > USER_VA_LIMIT:
            size = USER_VA_LIMIT - start
        ranges.append(MemoryRange(start=start, size=size, source_offset=file_offset))

    ranges.sort(key=lambda item: (item.start, item.source_offset))
    return source_dump, coalesce_ranges(ranges)


def coalesce_ranges(ranges: list[MemoryRange]) -> list[MemoryRange]:
    if not ranges:
        return []

    merged: list[MemoryRange] = []
    current = ranges[0]
    for item in ranges[1:]:
        contiguous_va = item.start == current.start + current.size
        contiguous_file = item.source_offset == current.source_offset + current.size
        if contiguous_va and contiguous_file:
            current = MemoryRange(
                start=current.start,
                size=current.size + item.size,
                source_offset=current.source_offset,
            )
            continue
        merged.append(current)
        current = item
    merged.append(current)
    return merged


def count_vads_with_pages(vads: list[VadRegion], ranges: list[MemoryRange]) -> int:
    count = 0
    range_index = 0
    for vad in vads:
        while range_index < len(ranges) and ranges[range_index].end <= vad.start:
            range_index += 1
        hit = False
        probe_index = range_index
        while probe_index < len(ranges) and ranges[probe_index].start <= vad.end:
            if ranges[probe_index].end > vad.start:
                hit = True
                break
            probe_index += 1
        if hit:
            count += 1
    return count


def build_minidump(source_dump: Path, ranges: list[MemoryRange], output_path: Path) -> int:
    stream_rva = 32 + 12
    stream_rva = align_up(stream_rva, 8)
    memory64_size = 16 + len(ranges) * 16
    base_rva = align_up(stream_rva + memory64_size, 8)

    output_path.parent.mkdir(parents=True, exist_ok=True)

    with source_dump.open("rb") as src, output_path.open("wb") as dst:
        header = struct.pack(
            "<IIIIIIQ",
            MDMP_SIGNATURE,
            MDMP_VERSION,
            1,
            32,
            0,
            0,
            0,
        )
        dst.write(header)

        stream_dir = struct.pack("<III", STREAM_TYPE_MEMORY64_LIST, memory64_size, stream_rva)
        dst.write(stream_dir)

        if dst.tell() < stream_rva:
            dst.write(b"\x00" * (stream_rva - dst.tell()))

        dst.write(struct.pack("<QQ", len(ranges), base_rva))
        for item in ranges:
            dst.write(struct.pack("<QQ", item.start, item.size))

        if dst.tell() < base_rva:
            dst.write(b"\x00" * (base_rva - dst.tell()))

        total_written = 0
        for item in ranges:
            remaining = item.size
            src.seek(item.source_offset)
            while remaining:
                chunk = src.read(min(COPY_CHUNK_SIZE, remaining))
                if not chunk:
                    raise RuntimeError(
                        f"Unexpected EOF in {source_dump} at offset 0x{src.tell():X}"
                    )
                dst.write(chunk)
                total_written += len(chunk)
                remaining -= len(chunk)

    return total_written


def format_gib(size: int) -> str:
    return f"{size / (1024 ** 3):.2f} GiB"


def maybe_clear_dir(path: Path) -> None:
    if path.exists():
        shutil.rmtree(path)
    path.mkdir(parents=True, exist_ok=True)


def main() -> int:
    args = parse_args()
    kernel_dump = Path(args.kernel_dump)
    output_path = Path(args.output)
    workdir = Path(args.workdir)

    if args.clear_workdir:
        maybe_clear_dir(workdir)
    else:
        workdir.mkdir(parents=True, exist_ok=True)

    if not kernel_dump.exists():
        print(f"[-] Kernel dump not found: {kernel_dump}", file=sys.stderr)
        return 1

    try:
        if args.pid is None:
            ps_rows = run_volatility(
                args.vol_cmd,
                kernel_dump,
                "windows.pslist.PsList",
                [],
                workdir=workdir,
                offline=args.offline,
            )
            proc = pick_process(ps_rows, args.process_name)
        else:
            proc = ProcessInfo(pid=args.pid, name=args.process_name, eprocess=0, create_time=None)

        vads = load_vads(
            args.vol_cmd,
            kernel_dump,
            proc.pid,
            workdir=workdir,
            offline=args.offline,
        )
        source_dump, ranges = load_memmap(
            args.vol_cmd,
            kernel_dump,
            proc.pid,
            workdir=workdir,
            offline=args.offline,
        )

        if not ranges:
            raise RuntimeError("Memmap returned no user-mode ranges to copy")

        copied_bytes = build_minidump(source_dump, ranges, output_path)
        vads_with_pages = count_vads_with_pages(vads, ranges)

        summary = {
            "kernel_dump": str(kernel_dump),
            "output_path": str(output_path),
            "output_size": output_path.stat().st_size,
            "process_name": proc.name,
            "pid": proc.pid,
            "eprocess": f"0x{proc.eprocess:X}" if proc.eprocess else None,
            "vad_regions_total": len(vads),
            "vad_regions_with_pages": vads_with_pages,
            "memory_ranges": len(ranges),
            "bytes_copied": copied_bytes,
            "source_dump": str(source_dump),
            "source_dump_size": source_dump.stat().st_size,
        }

        print(json.dumps(summary, indent=2))
        print(
            f"[+] Wrote {output_path} | PID {proc.pid} | "
            f"{vads_with_pages}/{len(vads)} VADs with pages | "
            f"{len(ranges)} memory ranges | {format_gib(copied_bytes)} copied"
        )
    except Exception as exc:
        print(f"[-] {exc}", file=sys.stderr)
        return 1
    finally:
        if not args.keep_workdir:
            for path in workdir.glob("pid.*.dmp"):
                try:
                    path.unlink()
                except OSError:
                    pass

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
