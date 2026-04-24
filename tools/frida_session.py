#!/usr/bin/env python3
"""
Frida Session Manager for VRChat runtime analysis.

Wraps Frida attach/spawn with auto-loading of vrc_frida_lib.js and config.
Provides a simple API for interactive exploration.

Usage:
  # Auto-attach to running VRChat:
  python tools/frida_session.py

  # Launch + attach:
  python tools/frida_session.py --launch

  # Run a script:
  python tools/frida_session.py -l tools/trace_auth_flow.js

  # Execute one-liner:
  python tools/frida_session.py -e "VRC.dumpClass(ptr('0x33757620'))"
"""
import argparse
import frida
import json
import os
import subprocess
import sys
import time

sys.stdout.reconfigure(encoding='utf-8')

TOOLS_DIR = os.path.dirname(os.path.abspath(__file__))
LIB_PATH = os.path.join(TOOLS_DIR, 'vrc_frida_lib.js')
CONFIG_PATH = os.path.join(TOOLS_DIR, 'vrc_frida_config.json')
STEAM_DIR = r"D:\Steam\steamapps\common\VRChat"
LAUNCH_EXE = os.path.join(STEAM_DIR, "launch.exe")


def safe_print(text):
    """ASCII-safe print for Windows GBK terminals."""
    safe = ''.join(c if ord(c) < 128 else '?' for c in str(text))
    print(safe, flush=True)


def wait_for_vrchat(device, timeout=60):
    """Wait for VRChat process with GameAssembly.dll loaded."""
    for i in range(timeout):
        time.sleep(1)
        try:
            for p in device.enumerate_processes():
                if p.name == 'VRChat.exe':
                    session = device.attach(p.pid)
                    probe = session.create_script(
                        'try{Process.getModuleByName("GameAssembly.dll");send("ok")}catch(e){send("wait")}'
                    )
                    result = []
                    probe.on('message', lambda m, d: result.append(m.get('payload', '')))
                    probe.load()
                    time.sleep(0.5)
                    probe.unload()
                    session.detach()
                    if 'ok' in result:
                        return p.pid
        except Exception:
            pass
    return None


def create_session(pid, extra_scripts=None, eval_code=None):
    """Create Frida session with vrc_frida_lib.js preloaded."""
    device = frida.get_local_device()
    session = device.attach(pid)

    # Build combined script: lib + config loader + user code
    parts = []

    # Load library
    with open(LIB_PATH, 'r', encoding='utf-8') as f:
        parts.append(f.read())

    # Auto-load config
    parts.append(f"""
// Auto-load config
(function() {{
    try {{
        var cfg = VRC.loadConfig({json.dumps(CONFIG_PATH)});
        if (cfg) send({{type:'config', msg:'Config loaded: ' + Object.keys(cfg.rva || {{}}).length + ' RVAs'}});
    }} catch(e) {{
        send({{type:'config', msg:'Config load failed: ' + e}});
    }}
}})();
""")

    # Load extra scripts
    if extra_scripts:
        for sp in extra_scripts:
            with open(sp, 'r', encoding='utf-8') as f:
                parts.append(f'\n// === {os.path.basename(sp)} ===\n' + f.read())

    # Eval code
    if eval_code:
        parts.append(f"""
(function() {{
    try {{
        var result = eval({json.dumps(eval_code)});
        if (result !== undefined) send({{type:'eval', result: String(result)}});
    }} catch(e) {{
        send({{type:'eval', error: String(e)}});
    }}
}})();
""")

    combined = '\n'.join(parts)
    script = session.create_script(combined)

    def on_message(message, data):
        payload = message.get('payload', '')
        if isinstance(payload, dict):
            mtype = payload.get('type', '')
            if mtype == 'config':
                safe_print(f"  [config] {payload.get('msg', '')}")
            elif mtype == 'eval':
                if 'error' in payload:
                    safe_print(f"  [eval ERROR] {payload['error']}")
                else:
                    safe_print(f"  [eval] {payload.get('result', '')}")
            else:
                safe_print(f"  {payload}")
        elif isinstance(payload, str):
            safe_print(f"  {payload}")
        elif message.get('type') == 'error':
            safe_print(f"  [ERR] {message.get('description', '')[:200]}")

    script.on('message', on_message)
    script.load()
    return session, script


def main():
    parser = argparse.ArgumentParser(description='VRChat Frida Session Manager')
    parser.add_argument('--launch', action='store_true', help='Launch VRChat before attaching')
    parser.add_argument('-p', '--pid', type=int, help='Attach to specific PID')
    parser.add_argument('-l', '--load', action='append', help='Load additional JS script(s)')
    parser.add_argument('-e', '--eval', help='Execute JS one-liner')
    parser.add_argument('--wait', type=int, default=0, help='Wait N seconds after load (0=interactive)')
    args = parser.parse_args()

    device = frida.get_local_device()

    # Find or launch VRChat
    pid = args.pid
    if args.launch:
        safe_print('[*] Launching VRChat...')
        subprocess.Popen([LAUNCH_EXE], cwd=STEAM_DIR)

    if not pid:
        safe_print('[*] Waiting for VRChat + GA...')
        pid = wait_for_vrchat(device, timeout=60 if args.launch else 10)
        if not pid:
            # Try to find already running
            for p in device.enumerate_processes():
                if p.name == 'VRChat.exe':
                    pid = p.pid
                    break

    if not pid:
        safe_print('[!] VRChat not found')
        return 1

    safe_print(f'[+] VRChat PID={pid}')
    safe_print('[*] Loading vrc_frida_lib.js + config...')

    session, script = create_session(pid, extra_scripts=args.load, eval_code=args.eval)
    safe_print('[*] Session ready.')

    if args.eval:
        time.sleep(2)  # Wait for eval result
        return 0

    if args.wait > 0:
        safe_print(f'[*] Running for {args.wait}s...')
        time.sleep(args.wait)
        return 0

    # Interactive mode
    safe_print('[*] Interactive mode. Type JS to evaluate, "quit" to exit.')
    safe_print('    VRC.klassGetName(ptr("0x33757620"))')
    safe_print('    VRC.findInstances(ptr("0x33757620"))')

    try:
        while True:
            try:
                line = input('vrc> ').strip()
            except EOFError:
                break
            if not line:
                continue
            if line.lower() in ('quit', 'exit', 'q'):
                break
            # Execute via script.exports or eval
            try:
                # Re-create script with eval
                _, eval_script = create_session(pid, eval_code=line)
                time.sleep(1)
                eval_script.unload()
            except Exception as e:
                safe_print(f'  Error: {e}')
    except KeyboardInterrupt:
        pass

    safe_print('[*] Done.')
    return 0


if __name__ == '__main__':
    sys.exit(main() or 0)
