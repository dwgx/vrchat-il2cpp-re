"""
Apply generated deobfuscated names whose keys are runtime VAs.

The generated output/ida_apply_names.py labels its keys as RVAs, but the
June 5 file contains runtime VAs such as 0x7FFAF2ABC770. This script parses
that RENAMES dict, infers or reads the runtime base, and applies names at:

    IDA imagebase + (runtime_va - runtime_base)

Environment:
  IDA_NAMES_SCRIPT  path to generated script
  IDA_RUNTIME_BASE  optional runtime base, e.g. 0x7FFAF2000000
"""

import ast
import os
import re
import traceback

import idaapi
import ida_name
import idc


DEFAULT_ROOT = r"D:\Project\vrchat-il2cpp-re"
DEFAULT_SCRIPT = os.path.join(DEFAULT_ROOT, "output", "ida_apply_names.py")


def extract_renames(path):
    with open(path, "r", encoding="utf-8") as handle:
        source = handle.read()
    match = re.search(r"RENAMES\s*=\s*(\{.*?\n\})", source, re.S)
    if not match:
        raise RuntimeError("RENAMES dict not found in %s" % path)
    return ast.literal_eval(match.group(1))


def infer_runtime_base(renames):
    minimum = min(int(key) for key in renames)
    # GameAssembly is loaded on a 0x01000000 boundary in the generated dump.
    return minimum & ~0xFFFFFF


def main():
    script_path = os.environ.get("IDA_NAMES_SCRIPT", DEFAULT_SCRIPT)
    print("[*] Loading generated names from %s" % script_path)
    renames = extract_renames(script_path)

    runtime_base_env = os.environ.get("IDA_RUNTIME_BASE", "")
    runtime_base = int(runtime_base_env, 0) if runtime_base_env else infer_runtime_base(renames)
    ida_base = idaapi.get_imagebase()

    print("[*] IDA image base: 0x%X" % ida_base)
    print("[*] Runtime base:   0x%X" % runtime_base)
    print("[*] Rename entries: %d" % len(renames))

    sn_nowarn = getattr(idc, "SN_NOWARN", ida_name.SN_NOWARN)
    sn_force = getattr(idc, "SN_FORCE", ida_name.SN_FORCE)
    set_name_flags = sn_nowarn | sn_force

    renamed = 0
    skipped = 0
    for runtime_va, name in renames.items():
        ea = ida_base + (int(runtime_va) - runtime_base)
        if idc.set_name(ea, name, set_name_flags):
            renamed += 1
        else:
            skipped += 1
        if (renamed + skipped) % 25000 == 0:
            print("[*] Progress: %d/%d, renamed=%d, skipped=%d" % (
                renamed + skipped, len(renames), renamed, skipped
            ))

    print("[*] Renamed %d/%d functions, skipped %d" % (renamed, len(renames), skipped))
    idc.qexit(0)


if __name__ == "__main__":
    try:
        main()
    except Exception as exc:
        print("[!] FATAL: %s" % exc)
        traceback.print_exc()
        idc.qexit(1)
