# Release Notes

## v1.0 — 2026-04-25

Initial public release of the IL2CPP memory-dump toolkit.

### Tooling shipped

- `tools/kerneldump_to_minidump.py` — convert a Windows complete
  memory dump (`MEMORY.DMP`) into a per-process MDMP minidump using
  Volatility3.
- `tools/extract_precise_dump.py` — read an MDMP minidump and
  enumerate `Il2CppClass` structs in the heap; supports `--auto-heap`
  to scan every user-mode region.
- `tools/extract_field_types_from_dump.py` — resolve the FieldInfo
  array hanging off each class to (name, type, offset) tuples.
- `tools/cross_version_class_map.py` — match classes across two
  dumps (e.g. before/after a game update) using method-body byte
  hashes plus a (namespace, class-name, field count, method-name
  signature) fallback fingerprint.
- `tools/lift_apr18_to_apr25_vocab.py` — example of carrying a
  user's own previously-built vocabulary forward across an update,
  using the cross-version map.
- `tools/run_full_pipeline.py` — orchestrator that stitches user
  vocabulary sources into one symbol pass.

### Compatibility

- Tested on Windows 11 26200, Python 3.12, Volatility3 2.27.0,
  Frida 17.7.3.
- Targets MDMP minidumps written by Volatility3, Procdump, or
  Windows Task Manager. Anything that emits the standard
  `MEMORY_LIST_STREAM_64` (stream type 9) is accepted.

### Provenance / non-redistribution

Nothing in this release contains or distributes any third-party
copyrighted work. The user supplies their own minidump from
software they legitimately own. Any class or field names produced
by the pipeline are derived locally on the user's machine from
the user's own dump and are not committed to this repository.

### DMCA contact

For takedown requests, open an issue or contact via the address
listed in the repository profile. Response window: 7 days.
