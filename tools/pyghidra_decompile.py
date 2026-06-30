#!/usr/bin/env python
"""Decompile target EAs from GameAssembly.dll via pyghidra (Ghidra 12 API).

Avoids the headless .bat + Jython problem: pyghidra.open_program gives a flat
Python API. We import once, then for each target EA force a function and run the
decompiler, dumping pseudocode JSON aligned with the existing codex-batch schema
(key/class/method/pseudocode).

Usage:
  GHIDRA_INSTALL_DIR=<ghidra> python tools/pyghidra_decompile.py <targets.json> <out.json>

The DLL and decompiler output are UNTRUSTED; we only read text, never exec.
"""
import json
import os
import sys
from pathlib import Path

os.environ.setdefault(
    "GHIDRA_INSTALL_DIR",
    r"D:\Tool\debugger\Static-Reversing\Ghidra\ghidra_12.1.2_PUBLIC")

import pyghidra  # noqa: E402

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
DLL = BASE / "dumps" / "GameAssembly_jun13.dll"


def main():
    targets_path = Path(sys.argv[1])
    out_path = Path(sys.argv[2])
    targets = json.load(open(targets_path, encoding="utf-8"))
    print(f"[pyghidra] opening {DLL.name} for {len(targets)} targets "
          f"(analysis off, point decompile)")

    results = []
    # analyze=False: skip full 226MB analysis; we force functions at target EAs.
    with pyghidra.open_program(str(DLL), analyze=False) as flat:
        from ghidra.app.decompiler import DecompInterface
        from ghidra.util.task import ConsoleTaskMonitor
        prog = flat.getCurrentProgram()
        af = prog.getAddressFactory().getDefaultAddressSpace()
        fm = prog.getFunctionManager()
        decomp = DecompInterface()
        decomp.openProgram(prog)
        monitor = ConsoleTaskMonitor()

        for i, t in enumerate(targets):
            ea = t["ea"]
            ea = int(ea, 16) if isinstance(ea, str) else ea
            addr = af.getAddress(ea)
            func = fm.getFunctionContaining(addr)
            if func is None:
                try:
                    func = fm.createFunction(None, addr,
                                             None, 0)  # SourceType.DEFAULT=0 fallback
                except Exception:
                    func = None
                if func is None:
                    func = flat.createFunction(addr, None)
            rec = {"key": t.get("key"), "class": t.get("class"),
                   "method": t.get("method"), "ea": hex(ea),
                   "pseudocode": "", "ok": False}
            if func is not None:
                res = decomp.decompileFunction(func, 60, monitor)
                if res is not None and res.decompileCompleted():
                    df = res.getDecompiledFunction()
                    if df is not None:
                        rec["pseudocode"] = df.getC()
                        rec["ok"] = True
            results.append(rec)
            if (i + 1) % 5 == 0 or rec["ok"]:
                print(f"  [{i+1}/{len(targets)}] {rec['key']} ok={rec['ok']} "
                      f"len={len(rec['pseudocode'])}")

    out_path.parent.mkdir(parents=True, exist_ok=True)
    json.dump(results, open(out_path, "w", encoding="utf-8"),
              ensure_ascii=False, indent=1)
    ok = sum(1 for r in results if r["ok"])
    print(f"[done] {ok}/{len(results)} decompiled -> {out_path}")


if __name__ == "__main__":
    main()
