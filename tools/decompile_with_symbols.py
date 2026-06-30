#!/usr/bin/env python
"""Decompile target methods WITH the 176k verified file-VA symbols applied first,
so callees in the pseudocode render as real names (PlayerActions::get_Move) instead
of FUN_<ea>. This is the quality input the naming agents consume.

Pipeline (spec items 28-30):
  1. open jun13 DLL in pyghidra (ImageBase 0x180000000)
  2. for each (file_ea -> name) in jun13_file_va_symbols.json: force a function at
     ea and set its name  -- this is the cheap symbol injection, no full analysis
  3. for each target obfuscated method: decompile, dump pseudocode

We apply names by forcing functions at the symbol EAs (createFunction) and setting
labels; the decompiler then resolves call targets to those names.

Usage:
  GHIDRA_INSTALL_DIR=<ghidra> python tools/decompile_with_symbols.py \
      <targets.json> <out.json> [--symbols jun13_file_va_symbols.json]
"""
import json
import os
import sys
from pathlib import Path

BASE = Path(__file__).resolve().parent.parent
DLL = BASE / "dumps" / "GameAssembly_jun13.dll"
SYMS = BASE / "output" / "p2_research" / "jun13_file_va_symbols.json"


def main():
    targets_path = Path(sys.argv[1])
    out_path = Path(sys.argv[2])
    syms_path = Path(sys.argv[sys.argv.index("--symbols") + 1]) \
        if "--symbols" in sys.argv else SYMS
    dll_path = Path(sys.argv[sys.argv.index("--dll") + 1]) \
        if "--dll" in sys.argv else DLL

    import pyghidra
    pyghidra.start()

    targets = json.load(open(targets_path, encoding="utf-8"))
    symbols = json.load(open(syms_path, encoding="utf-8"))
    print(f"[+] {len(targets)} targets, {len(symbols)} symbols to inject")

    from ghidra.program.model.symbol import SourceType
    from ghidra.util.task import ConsoleTaskMonitor

    results = []
    with pyghidra.open_program(str(dll_path), analyze=False) as flat:
        program = flat.getCurrentProgram()
        af = program.getAddressFactory().getDefaultAddressSpace()
        fm = program.getFunctionManager()
        st = program.getSymbolTable()
        monitor = ConsoleTaskMonitor()

        def to_addr(ea_int):
            return af.getAddress(ea_int)

        # --- inject symbols: label + force function at each EA ---
        applied = 0
        for ea_hex, name in symbols.items():
            ea = to_addr(int(ea_hex, 16))
            safe = name.replace("::", "__").replace("`", "_").replace("<", "_") \
                       .replace(">", "_").replace(".", "_").replace(",", "_") \
                       .replace(" ", "")
            try:
                fn = fm.getFunctionAt(ea)
                if fn is None:
                    fn = fm.createFunction(safe, ea, None, SourceType.USER_DEFINED)
                else:
                    fn.setName(safe, SourceType.USER_DEFINED)
                if fn is not None:
                    applied += 1
            except Exception:
                # last resort: a plain label so the decompiler still shows a name
                try:
                    st.createLabel(ea, safe, SourceType.USER_DEFINED)
                    applied += 1
                except Exception:
                    pass
        print(f"[+] injected {applied}/{len(symbols)} symbols")

        # --- decompile targets ---
        from ghidra.app.decompiler import DecompInterface
        from ghidra.app.cmd.function import CreateFunctionCmd
        decomp = DecompInterface()
        decomp.openProgram(program)
        for i, t in enumerate(targets):
            ea = to_addr(int(t["ea"], 16))
            fn = fm.getFunctionAt(ea)
            if fn is None:
                try:
                    fn = fm.createFunction(None, ea, None, SourceType.DEFAULT)
                except Exception:
                    fn = None
            if fn is None:
                # off-.pdata leaf: createFunction can't auto-compute a body that
                # contains the entrypoint. CreateFunctionCmd disassembles and
                # traces the body properly. (verified: recovers off-.pdata leaves)
                try:
                    CreateFunctionCmd(ea).applyTo(program, monitor)
                    fn = fm.getFunctionAt(ea)
                except Exception:
                    fn = None
            ok, code = False, ""
            if fn is not None:
                res = decomp.decompileFunction(fn, 60, monitor)
                if res.decompileCompleted():
                    code = res.getDecompiledFunction().getC()
                    ok = True
            results.append({"key": t.get("key", t["ea"]), "class": t.get("class"),
                            "method": t.get("method"), "ea": t["ea"],
                            "ok": ok, "pseudocode": code})
            if (i + 1) % 50 == 0:
                print(f"  [{i+1}/{len(targets)}] ok={ok}")

    out_path.parent.mkdir(parents=True, exist_ok=True)
    json.dump(results, open(out_path, "w", encoding="utf-8"), ensure_ascii=False)
    ok_n = sum(1 for r in results if r["ok"])
    print(f"[done] {ok_n}/{len(results)} decompiled -> {out_path}")


if __name__ == "__main__":
    main()
