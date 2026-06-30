# Ghidra headless postScript (Jython 2.7).
# Decompiles a list of target EAs and dumps pseudocode JSON.
# Usage (via analyzeHeadless):
#   analyzeHeadless <proj_dir> <proj_name> -import <dll> \
#       -scriptPath tools -postScript ghidra_decompile_targets.py <targets.json> <out.json>
# Targets file: [{"key","ea","class","method",...}]
import json
import sys
from ghidra.app.decompiler import DecompInterface
from ghidra.util.task import ConsoleTaskMonitor

args = getScriptArgs()
targets_path = args[0]
out_path = args[1]

with open(targets_path) as f:
    targets = json.load(f)

prog = getCurrentProgram()
# Image base of the loaded program; target EAs in mass_targets are file-style
# VAs (0x180000000-based), matching Ghidra's default PE image base.
af = prog.getAddressFactory().getDefaultAddressSpace()

decomp = DecompInterface()
decomp.openProgram(prog)
monitor = ConsoleTaskMonitor()

results = []
for t in targets:
    ea = t["ea"]
    if isinstance(ea, str):
        ea = int(ea, 16)
    addr = af.getAddress(ea)
    func = getFunctionContaining(addr)
    if func is None:
        # No function defined at the address yet; try to create one.
        func = createFunction(addr, None)
    rec = {"key": t.get("key"), "class": t.get("class"),
           "method": t.get("method"), "ea": hex(ea), "pseudocode": "", "ok": False}
    if func is not None:
        res = decomp.decompileFunction(func, 60, monitor)
        if res is not None and res.decompileCompleted():
            dfunc = res.getDecompiledFunction()
            if dfunc is not None:
                rec["pseudocode"] = dfunc.getC()
                rec["ok"] = True
    results.append(rec)
    print("[decomp] %s ok=%s len=%d" % (rec["key"], rec["ok"], len(rec["pseudocode"])))

with open(out_path, "w") as f:
    json.dump(results, f, indent=1)
print("[done] wrote %d -> %s" % (len(results), out_path))
