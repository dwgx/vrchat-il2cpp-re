#!/usr/bin/env python
"""
collect_json_keys.py - Driver for the JSON-key deserialisation leak capture.

Attaches Frida to a RUNNING VRChat.exe and injects two scripts in order:
  1. vrc_frida_lib.js       - Beebyte-offset readers (exposes global VRC)
  2. json_hook_installer.js - read-only Interceptor.attach hooks on
                              Newtonsoft JsonSerializerInternalReader::SetPropertyValue
                              (both linked copies). Emits {type:'json_keys',
                              obf_class, key} for every (target class, real field
                              name) pair it observes during deserialisation.

You then EXERCISE the game for the configured duration (open the menu, load
avatars/worlds, browse - anything that deserialises API JSON). Each menu/avatar/
world fetch funnels through Newtonsoft and fires the hook. The driver aggregates
the pairs into  output/p2_research/runtime_json_keys.json  keyed by obf_class ->
sorted unique keys.

This is READ-ONLY at the hook (no game functions are called), so it does NOT
trip VRChat's return-address anti-tamper check. See JSON_INSTALLER_DESIGN.md.

Usage:
  python collect_json_keys.py                 # auto-find VRChat.exe, 180s capture
  python collect_json_keys.py --pid 12345
  python collect_json_keys.py --duration 600  # capture for 10 minutes
  python collect_json_keys.py --out some.json

Prerequisites:
  pip install frida frida-tools          (frida-python 17.x verified)
  VRChat already running (VRChat.exe --no-vr offline for own-client research).
"""

import argparse
import json
import os
import subprocess
import sys
import time

try:
    sys.stdout.reconfigure(encoding="utf-8", errors="replace")
except Exception:
    pass

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
TOOLS_DIR = os.path.dirname(SCRIPT_DIR)
REPO_DIR = os.path.dirname(TOOLS_DIR)

VRC_LIB_JS = os.path.join(TOOLS_DIR, "vrc_frida_lib.js")
HOOK_JS = os.path.join(SCRIPT_DIR, "json_hook_installer.js")

OUT_JSON = os.path.join(
    REPO_DIR, "output", "p2_research", "runtime_json_keys.json"
)


def find_vrchat_pid():
    try:
        out = subprocess.check_output(
            ["tasklist", "/FI", "IMAGENAME eq VRChat.exe", "/FO", "CSV", "/NH"],
            text=True,
            errors="replace",
        )
        for line in out.strip().split("\n"):
            parts = line.strip().strip('"').split('","')
            if len(parts) >= 2 and "VRChat" in parts[0]:
                return int(parts[1].strip('"'))
    except Exception:
        pass
    return None


def build_combined_script():
    """Concatenate vrc_frida_lib.js + json_hook_installer.js (lib first so the
    installer can use the global VRC). Mirrors sample_instances.build_combined_script."""
    chain = (VRC_LIB_JS, HOOK_JS)
    for p in chain:
        if not os.path.exists(p):
            raise SystemExit(f"[-] Required script missing: {p}")
    parts = []
    for p in chain:
        with open(p, "r", encoding="utf-8") as f:
            parts.append(f"// ===== {os.path.basename(p)} =====\n" + f.read())
    return "\n\n".join(parts)


class Collector:
    """Aggregates json_keys messages into {obf_class: set(keys)}; mirrors the
    message-handling style of sample_instances.Collector."""

    def __init__(self):
        self.classes = {}        # obf_class -> set(keys)
        self.pair_count = 0
        self.errors = []
        self.last_stats = None

    def on_message(self, message, data):
        if message["type"] == "send":
            payload = message["payload"]
            if not isinstance(payload, dict):
                print(f"  [msg] {payload}")
                return
            mtype = payload.get("type", "")
            if mtype == "json_keys":
                cls = payload.get("obf_class")
                key = payload.get("key")
                if cls and key:
                    self.classes.setdefault(cls, set()).add(key)
                    self.pair_count += 1
                    if self.pair_count % 50 == 0:
                        print(f"  [pairs] {self.pair_count} "
                              f"({len(self.classes)} classes)")
            elif mtype == "stats":
                self.last_stats = payload
                print(f"  [stats] fires={payload.get('hook_fires')} "
                      f"unique_pairs={payload.get('unique_pairs')}")
            elif mtype == "info":
                print(f"  [*] {payload.get('msg', '')}")
            elif mtype == "error":
                self.errors.append(payload.get("msg", ""))
                print(f"  [!] {payload.get('msg', '')}")
            else:
                print(f"  [*] {payload}")
        elif message["type"] == "error":
            self.errors.append(message.get("description", str(message)))
            print(f"  [ERR] {message.get('description', message)}")


def main():
    parser = argparse.ArgumentParser(
        description="VRChat Newtonsoft JSON-key deserialisation leak capture")
    parser.add_argument("--pid", type=int, help="VRChat PID (default: auto-find)")
    parser.add_argument("--duration", type=int, default=180,
                        help="Seconds to capture while you exercise the game "
                             "(default 180)")
    parser.add_argument("--out", default=OUT_JSON, help="Output JSON path")
    args = parser.parse_args()

    import frida  # late import so --help works without frida installed

    pid = args.pid or find_vrchat_pid()
    if not pid:
        print("[-] VRChat.exe not found. Start it (VRChat.exe --no-vr) or pass --pid.")
        sys.exit(1)
    print(f"[+] Attaching to PID {pid}...")

    script_src = build_combined_script()
    session = frida.attach(pid)
    script = session.create_script(script_src)
    collector = Collector()
    script.on("message", collector.on_message)
    script.load()

    print(f"[+] Hooks installed. Capturing for {args.duration}s.")
    print("[+] EXERCISE THE GAME NOW: open the menu, load avatars/worlds, browse "
          "search results - anything that fetches API JSON.")

    deadline = time.time() + args.duration
    try:
        while time.time() < deadline:
            time.sleep(0.5)
    except KeyboardInterrupt:
        print("\n[!] Interrupted; writing what was captured so far.")

    # serialise: obf_class -> sorted unique keys
    result = {
        cls: sorted(keys) for cls, keys in sorted(collector.classes.items())
    }
    out = {
        "session_pid": pid,
        "duration_s": args.duration,
        "class_count": len(result),
        "pair_count": collector.pair_count,
        "last_stats": collector.last_stats,
        "errors": collector.errors,
        "classes": result,
    }
    os.makedirs(os.path.dirname(args.out), exist_ok=True)
    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(out, f, indent=2, ensure_ascii=False)
    print(f"[+] Wrote {args.out} "
          f"({len(result)} classes, {collector.pair_count} pairs, "
          f"{os.path.getsize(args.out)} bytes)")

    try:
        session.detach()
    except Exception:
        pass


if __name__ == "__main__":
    main()
