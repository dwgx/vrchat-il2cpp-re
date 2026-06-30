#!/usr/bin/env python
"""dry_run_check.py - STATIC readiness validator for the runtime sampler pipeline.

Verifies the whole pipeline wires together WITHOUT running Frida (VRChat does not
need to be running). It checks, for every component:

  - all expected files exist (design docs, JS agents, Python tools, shared deps),
  - every .js passes `node --check` (syntax),
  - every .py passes py_compile,
  - the target list parses and has the expected shape,
  - any already-produced runtime JSON parses (absent ones are PENDING LIVE, not
    failures: they only exist after a live capture),
  - extract_realnames's behaviour test (test_extract_realnames.py) passes.

Prints a readiness table (component | file | status) and exits 0 ONLY if every
component is GREEN. PENDING-LIVE rows (outputs that cannot exist until a live
capture runs) do not fail the check; anything actually broken does.

Run: python tools/runtime_sampler/dry_run_check.py
"""
import json
import os
import subprocess
import sys
from pathlib import Path

try:
    sys.stdout.reconfigure(encoding="utf-8", errors="replace")
except Exception:
    pass

HERE = Path(__file__).resolve().parent          # tools/runtime_sampler
TOOLS = HERE.parent                             # tools
REPO = TOOLS.parent                             # repo root
P2 = REPO / "output" / "p2_research"

# Status tokens. PENDING_LIVE and OPTIONAL never fail the run; FAIL does.
OK = "OK"
PENDING_LIVE = "PENDING LIVE"
OPTIONAL = "OPTIONAL"
FAIL = "FAIL"

rows = []   # (component, file-display, status, note)


def rel(p: Path) -> str:
    try:
        return str(p.relative_to(REPO)).replace(os.sep, "/")
    except ValueError:
        return str(p)


def record(component, path, status, note=""):
    rows.append((component, rel(Path(path)), status, note))


# ---------------------------------------------------------------------------
# 1) Required files exist.
# ---------------------------------------------------------------------------
REQUIRED_DESIGN = [
    "A_DESIGN.md", "B_DESIGN.md", "EXPORT_FINDING.md", "EXTRACT_DESIGN.md",
    "JSON_HOOK_DESIGN.md",
]
REQUIRED_JS = ["memscan_sampler.js", "hybrid_sampler.js", "pure_bridge_sampler.js"]
REQUIRED_PY = [
    "sample_instances.py", "extract_realnames.py", "find_json_hooks.py",
    "test_extract_realnames.py",
]
# Shared, repo-level dependencies the pipeline imports / injects.
SHARED_DEPS = [
    TOOLS / "vrc_frida_lib.js",
    TOOLS / "name_quality.py",
    TOOLS / "gate_decompile_names.py",
    TOOLS / "apply_class_names.py",
]


def check_exists():
    for name in REQUIRED_DESIGN:
        p = HERE / name
        record("design-doc", p, OK if p.is_file() else FAIL,
               "" if p.is_file() else "missing")
    for dep in SHARED_DEPS:
        record("shared-dep", dep, OK if dep.is_file() else FAIL,
               "" if dep.is_file() else "missing")


# ---------------------------------------------------------------------------
# 2) JS syntax via `node --check`.
# ---------------------------------------------------------------------------
def node_available():
    try:
        subprocess.run(["node", "--version"], capture_output=True, check=True)
        return True
    except Exception:
        return False


def check_js():
    have_node = node_available()
    for name in REQUIRED_JS:
        p = HERE / name
        if not p.is_file():
            record("js-agent", p, FAIL, "missing")
            continue
        if not have_node:
            record("js-agent", p, FAIL, "node not on PATH; cannot syntax-check")
            continue
        proc = subprocess.run(["node", "--check", str(p)],
                              capture_output=True, text=True, errors="replace")
        if proc.returncode == 0:
            record("js-agent", p, OK, "node --check")
        else:
            err = (proc.stderr or proc.stdout or "").strip().splitlines()
            record("js-agent", p, FAIL, err[0] if err else "node --check failed")


# ---------------------------------------------------------------------------
# 3) Python syntax via py_compile.
# ---------------------------------------------------------------------------
def check_py():
    import py_compile
    targets = [HERE / n for n in REQUIRED_PY] + [
        d for d in SHARED_DEPS if d.suffix == ".py"
    ]
    for p in targets:
        if not p.is_file():
            record("py-tool", p, FAIL, "missing")
            continue
        try:
            py_compile.compile(str(p), doraise=True)
            record("py-tool", p, OK, "py_compile")
        except py_compile.PyCompileError as ex:
            record("py-tool", p, FAIL, str(ex).strip().splitlines()[-1])


# ---------------------------------------------------------------------------
# 4) JSON inputs / outputs parse. Inputs are required; live outputs are pending.
# ---------------------------------------------------------------------------
def parse_json(p: Path):
    with open(p, encoding="utf-8") as f:
        return json.load(f)


def check_json():
    # Required input: the target list (must exist + have the expected shape).
    tgt = P2 / "runtime_sample_targets.json"
    if not tgt.is_file():
        record("target-list", tgt, FAIL, "missing (required input)")
    else:
        try:
            data = parse_json(tgt)
            if not isinstance(data, list) or not data:
                record("target-list", tgt, FAIL, "expected non-empty JSON array")
            else:
                need = {"name", "nfields", "nmethods", "is_dto"}
                missing = need - set(data[0].keys())
                if missing:
                    record("target-list", tgt, FAIL,
                           f"row0 missing keys: {sorted(missing)}")
                else:
                    n_dto = sum(1 for r in data if r.get("is_dto"))
                    record("target-list", tgt, OK,
                           f"{len(data)} rows, {n_dto} DTO-priority")
        except Exception as ex:
            record("target-list", tgt, FAIL, f"parse error: {ex}")

    # Static JSON-hook map: produced by find_json_hooks.py. Optional (regenerable)
    # but if present it must parse.
    hooks = P2 / "json_hook_points.json"
    if hooks.is_file():
        try:
            parse_json(hooks)
            record("json-hook-map", hooks, OK, "parses")
        except Exception as ex:
            record("json-hook-map", hooks, FAIL, f"parse error: {ex}")
    else:
        record("json-hook-map", hooks, OPTIONAL,
               "regenerate: python tools/runtime_sampler/find_json_hooks.py")

    # Live capture outputs: do not exist until Steps 2-4 run against the game.
    live_outputs = [
        ("instance-values", P2 / "runtime_instance_values.json",
         "python tools/runtime_sampler/sample_instances.py --mode memscan"),
        ("json-keys", P2 / "runtime_json_keys.json",
         "live JSON-key capture (Step 3)"),
        ("name-candidates",
         P2 / "naming_results" / "runtime_sampler_slice_realnames.json",
         "python tools/runtime_sampler/extract_realnames.py"),
    ]
    for comp, p, how in live_outputs:
        if p.is_file():
            try:
                parse_json(p)
                record(comp, p, OK, "live output present + parses")
            except Exception as ex:
                record(comp, p, FAIL, f"parse error: {ex}")
        else:
            record(comp, p, PENDING_LIVE, how)


# ---------------------------------------------------------------------------
# 5) extract_realnames behaviour test (the scorer's contract lock).
# ---------------------------------------------------------------------------
def check_extract_test():
    test = HERE / "test_extract_realnames.py"
    if not test.is_file():
        record("scorer-test", test, FAIL, "missing")
        return
    proc = subprocess.run([sys.executable, str(test)],
                          capture_output=True, text=True, errors="replace")
    if proc.returncode == 0:
        last = [l for l in (proc.stdout or "").splitlines() if l.strip()]
        record("scorer-test", test, OK, last[-1] if last else "all green")
    else:
        tail = (proc.stdout or proc.stderr or "").strip().splitlines()
        record("scorer-test", test, FAIL, tail[-1] if tail else "test failed")


# ---------------------------------------------------------------------------
# Report.
# ---------------------------------------------------------------------------
def print_table():
    comp_w = max(len("component"), *(len(r[0]) for r in rows))
    file_w = max(len("file"), *(len(r[1]) for r in rows))
    stat_w = max(len("status"), *(len(r[2]) for r in rows))
    line = (f"{'component':<{comp_w}}  {'file':<{file_w}}  "
            f"{'status':<{stat_w}}  note")
    print(line)
    print("-" * len(line))
    for comp, fil, status, note in rows:
        print(f"{comp:<{comp_w}}  {fil:<{file_w}}  {status:<{stat_w}}  {note}")


def main():
    check_exists()
    check_js()
    check_py()
    check_json()
    check_extract_test()

    print_table()

    fails = [r for r in rows if r[2] == FAIL]
    pending = [r for r in rows if r[2] == PENDING_LIVE]
    print()
    print(f"summary: {len(rows)} components | "
          f"{sum(1 for r in rows if r[2] == OK)} ok | "
          f"{len(pending)} pending-live | "
          f"{sum(1 for r in rows if r[2] == OPTIONAL)} optional | "
          f"{len(fails)} fail")

    if fails:
        print("\nNOT READY — failing components:")
        for comp, fil, _, note in fails:
            print(f"  - {comp} ({fil}): {note}")
        return 1

    if pending:
        print("\nREADY (static). Pending-live outputs appear after a live "
              "capture; they are not failures:")
        for comp, fil, _, note in pending:
            print(f"  - {comp}: {note}")
    else:
        print("\nREADY — every component green.")
    return 0


if __name__ == "__main__":
    sys.exit(main())
