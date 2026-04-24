#!/usr/bin/env python3
"""Wait for IDA to finish, then report."""
import time, subprocess, os, sys

DB = "D:/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools/ga_analysis"

while True:
    r = subprocess.run(["tasklist"], capture_output=True, text=True)
    if "idat.exe" not in r.stdout:
        break

    size = os.path.getsize(f"{DB}.id0") / 1024 / 1024
    print(f"\r  IDA running... id0={size:.0f}MB, waiting...", end="", flush=True)
    time.sleep(15)

# Check result
i64 = f"{DB}.i64"
if os.path.exists(i64):
    size = os.path.getsize(i64) / 1024 / 1024
    print(f"\n\nIDA DONE! Database: {i64} ({size:.0f}MB)")
else:
    print(f"\n\nIDA finished but no .i64 found. Check files:")
    for f in os.listdir(os.path.dirname(DB)):
        if f.startswith("ga_analysis"):
            fp = os.path.join(os.path.dirname(DB), f)
            print(f"  {f}: {os.path.getsize(fp)/1024/1024:.0f}MB")
