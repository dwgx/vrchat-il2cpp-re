#!/usr/bin/env python
"""
sample_instances.py - Driver for the hybrid runtime instance-value sampler.

Attaches Frida to a RUNNING VRChat.exe and injects a single combined script:
  1. agent.js          - frida-compiled frida-il2cpp-bridge (exposes global Il2Cpp)
  2. vrc_frida_lib.js  - our Beebyte-offset readers (exposes global VRC)
  3. hybrid_sampler.js  - the sampler (uses Il2Cpp.gc.choose + VRC readers)

The bridge handles instance ENUMERATION only (gc.choose); all field VALUES are read
with our verified Beebyte offsets. See A_DESIGN.md for the full rationale.

The dump 'va' fields in the target list are STALE (prior ASLR base) and are NOT used
for resolution: the agent re-resolves every target to its CURRENT klass pointer by
matching obfuscated original_name + field/method counts against a fresh class
enumeration this session.

Usage:
  # one-time: build the bridge agent (needs node/npm; see --build help below)
  python sample_instances.py --build-agent

  python sample_instances.py                 # auto-find VRChat.exe, sample DTO targets
  python sample_instances.py --pid 12345
  python sample_instances.py --all           # all 4282 weak classes (slow)
  python sample_instances.py --limit 200     # cap number of targets
  python sample_instances.py --max-instances 50
  python sample_instances.py --tostring      # enable ToString() (RISKY, see design)

Prerequisites:
  pip install frida frida-tools          (frida-python 17.x verified)
  agent.js built once via frida-compile   (see build_agent()/--build-agent)

Do NOT run this unless VRChat is already running and you accept the EAC note:
launch VRChat.exe with --no-vr offline for own-client research.
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

AGENT_JS = os.path.join(SCRIPT_DIR, "agent.js")
VRC_LIB_JS = os.path.join(TOOLS_DIR, "vrc_frida_lib.js")
SAMPLER_JS = os.path.join(SCRIPT_DIR, "hybrid_sampler.js")
MEMSCAN_JS = os.path.join(SCRIPT_DIR, "memscan_sampler.js")

TARGETS_JSON = os.path.join(
    REPO_DIR, "output", "p2_research", "runtime_sample_targets.json"
)
OUT_JSON = os.path.join(
    REPO_DIR, "output", "p2_research", "runtime_instance_values.json"
)

# frida-il2cpp-bridge entrypoint we compile into agent.js. The published package
# is "frida-il2cpp-bridge" (vfsfitvnm). Importing it for side effects installs the
# global `Il2Cpp` object that hybrid_sampler.js relies on. We align with the
# existing package.json in this dir, whose build script is `frida-compile agent.ts`.
BRIDGE_PKG = "frida-il2cpp-bridge"
BRIDGE_ENTRY_SRC = 'import "frida-il2cpp-bridge";\n'
AGENT_ENTRY = os.path.join(SCRIPT_DIR, "agent.ts")


# ---------------------------------------------------------------------------
# Agent build (frida-compile bundles the bridge + its deps into one agent.js).
# Reuses the existing package.json / node_modules in this directory; only writes
# package.json if absent so we never clobber a parallel setup.
# ---------------------------------------------------------------------------
def build_agent():
    """Compile frida-il2cpp-bridge into a standalone agent.js using frida-compile."""
    pkg_json = os.path.join(SCRIPT_DIR, "package.json")

    if not os.path.exists(pkg_json):
        with open(pkg_json, "w", encoding="utf-8") as f:
            json.dump(
                {
                    "name": "vrc-runtime-sampler",
                    "version": "1.0.0",
                    "private": True,
                    "scripts": {"build": "frida-compile agent.ts -o agent.js"},
                    "dependencies": {
                        "frida-il2cpp-bridge": "^0.13.1",
                        "frida-compile": "^19.0.5",
                        "@types/frida-gum": "^19.7.0",
                    },
                },
                f,
                indent=2,
            )
        print(f"[+] Wrote {pkg_json}")

    if not os.path.exists(AGENT_ENTRY):
        with open(AGENT_ENTRY, "w", encoding="utf-8") as f:
            f.write(BRIDGE_ENTRY_SRC)
        print(f"[+] Wrote {AGENT_ENTRY}")

    npm = "npm.cmd" if os.name == "nt" else "npm"
    if not os.path.isdir(os.path.join(SCRIPT_DIR, "node_modules", BRIDGE_PKG)):
        print("[+] Installing npm deps (frida-il2cpp-bridge, frida-compile)...")
        subprocess.check_call([npm, "install"], cwd=SCRIPT_DIR)
    else:
        print("[*] node_modules already has frida-il2cpp-bridge; skipping npm install.")

    print("[+] Compiling agent.js via frida-compile (agent.ts)...")
    npx = "npx.cmd" if os.name == "nt" else "npx"
    subprocess.check_call(
        [npx, "frida-compile", "agent.ts", "-o", "agent.js"],
        cwd=SCRIPT_DIR,
    )
    if not os.path.exists(AGENT_JS):
        raise SystemExit("[-] frida-compile did not produce agent.js")
    print(f"[+] Built {AGENT_JS} ({os.path.getsize(AGENT_JS)} bytes)")


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


def load_targets(path, dto_only, limit):
    with open(path, "r", encoding="utf-8") as f:
        rows = json.load(f)
    # De-duplicate by obfuscated name + counts; the dump lists one row per stale
    # instance va, but we resolve per-class, so collapse to unique class shapes.
    seen = {}
    uniq = []
    for r in rows:
        key = (r.get("name"), r.get("nfields"), r.get("nmethods"))
        if key in seen:
            continue
        seen[key] = True
        uniq.append(
            {
                "name": r.get("name"),
                "nfields": r.get("nfields"),
                "nmethods": r.get("nmethods"),
                "is_dto": r.get("is_dto", False),
                "callee_hint": r.get("callee_hint", []),
            }
        )
    if dto_only:
        uniq = [t for t in uniq if t.get("is_dto")]
    if limit and limit > 0:
        uniq = uniq[:limit]
    return uniq


class Collector:
    def __init__(self):
        self.results = []
        self.done = False
        self.done_summary = None
        self.errors = []

    def on_message(self, message, data):
        if message["type"] == "send":
            payload = message["payload"]
            if not isinstance(payload, dict):
                print(f"  [msg] {payload}")
                return
            mtype = payload.get("type", "")
            if mtype == "class_result":
                rec = payload.get("payload", {})
                self.results.append(rec)
                ni = len(rec.get("instances", []))
                print(
                    f"  [class] {rec.get('original_name')} "
                    f"live={rec.get('live_count', '?')} sampled={ni} "
                    f"({rec.get('matched_by', '?')})"
                )
            elif mtype == "progress":
                print(f"  [progress] {payload.get('done')}/{payload.get('total')}")
            elif mtype == "info":
                print(f"  [*] {payload.get('msg', '')}")
            elif mtype == "error":
                self.errors.append(payload.get("msg", ""))
                print(f"  [!] {payload.get('msg', '')}")
            elif mtype == "done":
                self.done_summary = payload
                self.done = True
                print(f"  [done] {payload}")
            else:
                print(f"  [*] {payload}")
        elif message["type"] == "error":
            self.errors.append(message.get("description", str(message)))
            print(f"  [ERR] {message.get('description', message)}")


def build_combined_script(mode="auto"):
    # mode: "bridge" = agent.js (frida-il2cpp-bridge) + vrc_frida_lib + hybrid_sampler;
    #       "memscan" = vrc_frida_lib + memscan_sampler ONLY (zero bridge dependency,
    #         the reliable path given B's finding that GameAssembly.dll's il2cpp_*
    #         exports are stripped and a return-address anti-tamper check rejects
    #         bridge NativeFunction calls — see EXPORT_FINDING.md / B_DESIGN.md);
    #       "auto" = memscan (we default to the path proven to run end-to-end).
    if mode == "auto":
        mode = "memscan"

    if mode == "memscan":
        chain = (VRC_LIB_JS, MEMSCAN_JS)
    elif mode == "bridge":
        chain = (AGENT_JS, VRC_LIB_JS, SAMPLER_JS)
    else:
        raise SystemExit(f"[-] Unknown mode: {mode}")

    for p in chain:
        if not os.path.exists(p):
            if p == AGENT_JS:
                raise SystemExit(
                    f"[-] {p} missing. Build it first: "
                    f"python sample_instances.py --build-agent"
                )
            raise SystemExit(f"[-] Required script missing: {p}")
    parts = []
    for p in chain:
        with open(p, "r", encoding="utf-8") as f:
            parts.append(f"// ===== {os.path.basename(p)} =====\n" + f.read())
    return "\n\n".join(parts)


def main():
    parser = argparse.ArgumentParser(description="VRChat hybrid runtime instance sampler")
    parser.add_argument("--pid", type=int, help="VRChat PID (default: auto-find)")
    parser.add_argument("--build-agent", action="store_true",
                        help="Build agent.js from frida-il2cpp-bridge and exit")
    parser.add_argument("--all", action="store_true",
                        help="Sample all weak classes (default: DTO-priority only)")
    parser.add_argument("--limit", type=int, default=0, help="Cap number of target classes")
    parser.add_argument("--max-instances", type=int, default=50,
                        help="Max instances sampled per class (default 50)")
    parser.add_argument("--tostring", action="store_true",
                        help="Invoke ToString() per instance (RISKY: anti-tamper)")
    parser.add_argument("--mode", choices=["auto", "memscan", "bridge"], default="auto",
                        help="Enumeration path: memscan (pure-memory, reliable on this "
                             "Beebyte binary) or bridge (frida-il2cpp-bridge, needs "
                             "il2cpp_* exports — likely fails here). auto=memscan.")
    parser.add_argument("--targets", default=TARGETS_JSON, help="Target list JSON path")
    parser.add_argument("--out", default=OUT_JSON, help="Output JSON path")
    parser.add_argument("--timeout", type=int, default=600,
                        help="Max seconds to wait for completion")
    args = parser.parse_args()

    if args.build_agent:
        build_agent()
        return

    import frida  # imported late so --build-agent works without frida installed

    targets = load_targets(args.targets, dto_only=not args.all, limit=args.limit)
    print(f"[+] Loaded {len(targets)} unique target classes "
          f"({'all weak' if args.all else 'DTO-priority'})")

    pid = args.pid or find_vrchat_pid()
    if not pid:
        print("[-] VRChat.exe not found. Start it (VRChat.exe --no-vr) or pass --pid.")
        sys.exit(1)
    print(f"[+] Attaching to PID {pid}...")

    script_src = build_combined_script(mode=args.mode)
    print(f"[+] Mode: {args.mode} "
          f"({'pure-memory, no bridge' if args.mode != 'bridge' else 'frida-il2cpp-bridge'})")

    session = frida.attach(pid)
    script = session.create_script(script_src)
    collector = Collector()
    script.on("message", collector.on_message)
    script.load()

    cfg = {
        "maxInstancesPerClass": args.max_instances,
        "invokeToString": bool(args.tostring),
    }
    print("[+] Posting target list to agent...")
    script.post({"type": "start", "targets": targets, "config": cfg})

    deadline = time.time() + args.timeout
    while not collector.done and time.time() < deadline:
        time.sleep(0.2)

    if not collector.done:
        print(f"[!] Timed out after {args.timeout}s; writing partial results.")

    out = {
        "session_pid": pid,
        "target_count": len(targets),
        "sampled_classes": len(collector.results),
        "summary": collector.done_summary,
        "errors": collector.errors,
        "results": collector.results,
    }
    os.makedirs(os.path.dirname(args.out), exist_ok=True)
    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(out, f, indent=2, ensure_ascii=False)
    print(f"[+] Wrote {args.out} "
          f"({len(collector.results)} classes, {os.path.getsize(args.out)} bytes)")

    try:
        session.detach()
    except Exception:
        pass


if __name__ == "__main__":
    main()
