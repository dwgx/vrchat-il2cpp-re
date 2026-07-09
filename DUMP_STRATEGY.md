# VRChat IL2CPP Memory Dump Strategy
## Using D:\Tool\debugger Toolkit for Precise Extraction

---

## 1. RECOMMENDED APPROACH

**Primary: launch_bypass.exe + ctypes MiniDumpWriteDump + extract_reverse_unity6.py**

The existing pipeline is the correct architecture. The debugger toolkit supplements
it for anti-debug bypass, not replaces it. The optimal flow is:

```
launch_bypass.exe (skip EAC)
  -> wait for type init (60s after world load)
  -> take_new_dump.py (MiniDumpWithFullMemory via ctypes)
  -> extract_reverse_unity6.py (parse MDMP, walk MethodInfo structs)
```

The toolkit's MCP tools (CE read_memory, x64dbg read_memory) are unsuitable for
full-process dumps (1MB cap per call, hex-string encoding, no MDMP output). They
are useful for live verification and anti-debug only.

**When EAC is active (cannot use launch_bypass.exe):**

```
ScyllaHide InjectorCLIx64.exe (hide debugger from EAC usermode checks)
  -> take_new_dump.py (MiniDumpWriteDump still works once anti-debug is patched)
```

**Alternative live path (no dump file, faster, smaller output):**

```
launch_bypass.exe -> extract_live_dump.py (Frida-based, reads only managed heap)
```

---

## 2. STEP-BY-STEP COMMANDS

### Phase A: Launch VRChat without EAC

```powershell
# Option 1: launch_bypass.exe (already compiled, place in VRChat install dir)
copy "D:\Project\vrchat-il2cpp-re\tools\launch_bypass.exe" "C:\Program Files (x86)\Steam\steamapps\common\VRChat\launch_bypass.exe"
& "C:\Program Files (x86)\Steam\steamapps\common\VRChat\launch_bypass.exe" --no-vr

# Option 2: Direct launch (if Steam overlay not needed)
& "C:\Program Files (x86)\Steam\steamapps\common\VRChat\VRChat.exe" --no-vr
```

### Phase B: Wait for Type Initialization

```powershell
# Wait 60-90 seconds after VRChat reaches the home world.
# The managed heap must be populated with IL2CPP class instances.
# Indicators of readiness:
#   - UI menus are responsive
#   - Avatar has loaded
#   - World objects are visible
# Minimum: wait until the loading screen completes + 30 seconds
Start-Sleep -Seconds 90
```

### Phase C: Take the Dump

```powershell
# Primary method (requires running as Administrator)
cd D:\Project\vrchat-il2cpp-re
python tools\take_new_dump.py
# Output: dumps\VRChat_<pid>_<timestamp>_full.dmp (~3-6 GB)

# Fallback: procdump64 from Sysinternals in toolkit
& "D:\Tool\debugger\System-Forensics\SysinternalsSuite\procdump64.exe" -ma -accepteula (Get-Process VRChat).Id "D:\Project\vrchat-il2cpp-re\dumps\VRChat_procdump.dmp"
```

### Phase D: Extract IL2CPP Data

```powershell
python tools\extract_reverse_unity6.py --dump "D:\Project\vrchat-il2cpp-re\dumps\VRChat_<pid>_<timestamp>_full.dmp"
# Output: data/precise_dump.json
```

### Phase E (Optional): Anti-Debug Bypass for EAC Builds

```powershell
# If VRChat was launched WITH EAC (e.g., via Steam normally), inject ScyllaHide first:
$pid = (Get-Process VRChat).Id

# Inject anti-debug hooks (VMProtect x64 profile: PEB patches, NtQueryInformationProcess, NtClose, NtSetInformationThread)
& "D:\Tool\debugger\Debuggers\ScyllaHide\InjectorCLIx64.exe" pid:$pid "D:\Tool\debugger\Debuggers\ScyllaHide\HookLibraryx64.dll"

# Now MiniDumpWriteDump can proceed without EAC interfering:
python tools\take_new_dump.py
```

---

## 3. PRE-REQUISITES

### Must Have (for primary workflow):

| Requirement | Status | Path/Action |
|-------------|--------|-------------|
| Python 3.10+ | Needed | System Python or venv |
| Administrator privileges | Needed | Required for OpenProcess(PROCESS_ALL_ACCESS) |
| VRChat installed | Needed | Steam install path |
| launch_bypass.exe | Ready | `D:\Project\vrchat-il2cpp-re\tools\launch_bypass.exe` |
| dumps/ directory | Auto-created | `take_new_dump.py` creates it |
| 6+ GB free disk space | Needed | For the full memory dump file |

### For ScyllaHide bypass (EAC-active builds):

| Requirement | Status | Path |
|-------------|--------|------|
| ScyllaHide x64 | Ready | `D:\Tool\debugger\Debuggers\ScyllaHide\InjectorCLIx64.exe` |
| HookLibraryx64.dll | Ready | `D:\Tool\debugger\Debuggers\ScyllaHide\HookLibraryx64.dll` |
| scylla_hide.ini configured | Ready | Profile: "VMProtect x86/x64" (PEB+NtQIP+NtClose+NtSIT) |

### For Frida live-extraction alternative:

| Requirement | Status | Action |
|-------------|--------|--------|
| frida Python package | Needed | `pip install frida frida-tools` |
| No EAC (or EAC bypassed) | Needed | Frida injection is detectable by EAC |

### For procdump64 fallback:

| Requirement | Status | Path |
|-------------|--------|------|
| procdump64.exe | Ready | `D:\Tool\debugger\System-Forensics\SysinternalsSuite\procdump64.exe` |
| EULA acceptance | First-run | Pass `-accepteula` flag on first invocation |

---

## 4. TIMING: When to Capture

### Critical Window

The dump must capture VRChat AFTER IL2CPP type initialization but BEFORE any
unload or garbage collection cycle that might compact the heap.

```
Timeline:
  T+0s    VRChat.exe starts
  T+5s    Unity engine init, GameAssembly.dll loaded
  T+10s   il2cpp_init() runs, metadata parsed
  T+15s   Global type registration begins
  T+30s   Home world loading starts
  T+45s   Avatars and world scripts trigger lazy class loading
  T+60s   Most types initialized <-- EARLIEST safe dump point
  T+90s   Menus opened, settings loaded <-- OPTIMAL dump point
  T+120s+ Fully settled state           <-- SAFEST dump point
```

### Signals That the Process is Ready:

1. `GameAssembly.dll` module size in memory is stable (not being paged in)
2. VRChat UI is interactive (Quick Menu opens, settings accessible)
3. At least one world has fully loaded (objects visible, avatars rendered)
4. The process working set has plateaued (check via Task Manager: Memory column stable)

### What Degrades Over Time:

- GC cycles may move objects (but IL2CPP metadata is pinned, not GC-managed)
- Anti-tamper timers may activate (EAC heartbeat checks if running)
- Memory fragmentation increases (more VA ranges to parse)

**Recommendation: Dump at T+90s to T+120s after world load completes.**

---

## 5. VALIDATION: Verifying Dump Quality

### Immediate Checks (before running extractor):

```powershell
# Check 1: File exists and is large enough (expect 3-6 GB)
$dmp = Get-Item "D:\Project\vrchat-il2cpp-re\dumps\VRChat_*_full.dmp" | Sort-Object LastWriteTime -Descending | Select-Object -First 1
if ($dmp.Length -lt 2GB) { Write-Warning "Dump too small - may be incomplete" }

# Check 2: MDMP header magic
$bytes = [System.IO.File]::ReadAllBytes($dmp.FullName)[0..3]
if ([System.Text.Encoding]::ASCII.GetString($bytes) -ne "MDMP") { Write-Error "Invalid dump format" }

# Check 3: Memory64ListStream exists (stream type 9)
# The extractor will fail fast if this is missing, so just run it:
python tools\extract_reverse_unity6.py --dump $dmp.FullName 2>&1 | Select-Object -First 20
```

### Extractor Output Quality Indicators:

| Metric | Good Dump | Bad Dump |
|--------|-----------|----------|
| Classes found | 8,000 - 15,000+ | < 2,000 |
| Methods resolved | 50,000 - 100,000+ | < 10,000 |
| Namespaces | 200+ (UnityEngine.*, VRC.*, System.*) | < 50 |
| Named (non-obfuscated) classes | 3,000+ | < 500 |
| Beebyte-obfuscated names | Present (strings of U+00CC-U+00CF) | Absent = wrong build |

### Pre-Dump Verification via CE MCP (optional, for paranoid validation):

If Cheat Engine + MCP bridge is running, verify heap readiness before dumping:

```python
# Via MCP: check that GameAssembly.dll is mapped and executable
# attach_process("VRChat.exe")
# enum_memory_regions_full() -> filter for 0x7FF* range with RX protection
# aob_scan("4D 5A 90 00", "+X") -> should find GameAssembly.dll PE header
# read_memory(ga_base + 0x3C, 4) -> PE offset (should be valid, ~0x100-0x200)
```

---

## 6. FALLBACK: When Primary Approach Fails

### Failure: "OpenProcess failed" / Access Denied

```powershell
# Solution 1: Run as Administrator
Start-Process powershell -Verb RunAs -ArgumentList "-Command cd D:\Project\vrchat-il2cpp-re; python tools\take_new_dump.py"

# Solution 2: Use procdump64 (sometimes has better privilege handling)
& "D:\Tool\debugger\System-Forensics\SysinternalsSuite\procdump64.exe" -ma -accepteula (Get-Process VRChat).Id "D:\Project\vrchat-il2cpp-re\dumps\fallback.dmp"

# Solution 3: comsvcs.dll (built into Windows, last resort)
$pid = (Get-Process VRChat).Id
rundll32.exe comsvcs.dll, MiniDump $pid "D:\Project\vrchat-il2cpp-re\dumps\comsvcs.dmp" full
```

### Failure: EAC Blocks OpenProcess Even as Admin

```powershell
# ScyllaHide injection before dump attempt:
$pid = (Get-Process VRChat).Id
& "D:\Tool\debugger\Debuggers\ScyllaHide\InjectorCLIx64.exe" pid:$pid "D:\Tool\debugger\Debuggers\ScyllaHide\HookLibraryx64.dll"
Start-Sleep -Seconds 2
python tools\take_new_dump.py
```

### Failure: Dump File Corrupt / Too Small

```powershell
# Cause: VRChat crashed during dump, or disk ran out of space.
# Fix: Ensure 10GB+ free space, try again with process suspended:

# Suspend via NtSuspendProcess (CE MCP if connected):
# pause_process() -> take dump -> unpause_process()

# Or use procdump with -s flag (suspend):
& "D:\Tool\debugger\System-Forensics\SysinternalsSuite\procdump64.exe" -ma -s -accepteula (Get-Process VRChat).Id "D:\Project\vrchat-il2cpp-re\dumps\suspended.dmp"
```

### Failure: Extractor Finds < 2000 Classes

```
Cause: Dumped too early (types not initialized) or wrong memory layout.
Fix:
  1. Wait longer before dumping (2+ minutes after world load)
  2. Open VRChat menus, change settings, join another world (forces more type loading)
  3. Verify GameAssembly.dll version matches extractor offsets (Unity 6 vs Unity 2022)
```

### Failure: Cannot Launch Without EAC At All

```powershell
# Nuclear option: Use Frida live extraction (no dump file needed)
python tools\extract_live_dump.py
# Requires: VRChat running (any mode), Frida installed, admin privileges
# If Frida injection also blocked: ScyllaHide first, then Frida
```

---

## 7. AUTOMATION POTENTIAL

### One-Click Script (recommended implementation):

```powershell
# dump_vrchat.ps1 - Complete automated dump workflow
# Run as Administrator

param(
    [int]$WaitSeconds = 90,
    [switch]$WithScyllaHide,
    [switch]$LiveMode
)

$ErrorActionPreference = "Stop"
$ProjectRoot = "D:\Project\vrchat-il2cpp-re"
$DumpsDir = Join-Path $ProjectRoot "dumps"
$ToolkitRoot = "D:\Tool\debugger"

# Ensure dumps directory exists
New-Item -ItemType Directory -Force -Path $DumpsDir | Out-Null

# Step 1: Find or launch VRChat
$vrc = Get-Process VRChat -ErrorAction SilentlyContinue
if (-not $vrc) {
    Write-Host "[+] Launching VRChat via launch_bypass.exe..."
    & (Join-Path $ProjectRoot "tools\launch_bypass.exe") --no-vr
    Write-Host "[+] Waiting for VRChat to start..."
    do { Start-Sleep -Seconds 2; $vrc = Get-Process VRChat -ErrorAction SilentlyContinue } while (-not $vrc)
    Write-Host "[+] VRChat started (PID $($vrc.Id)). Waiting ${WaitSeconds}s for type init..."
    Start-Sleep -Seconds $WaitSeconds
} else {
    Write-Host "[+] VRChat already running (PID $($vrc.Id))"
}

# Step 2: Anti-debug bypass (if requested)
if ($WithScyllaHide) {
    Write-Host "[+] Injecting ScyllaHide..."
    & "$ToolkitRoot\Debuggers\ScyllaHide\InjectorCLIx64.exe" "pid:$($vrc.Id)" "$ToolkitRoot\Debuggers\ScyllaHide\HookLibraryx64.dll"
    Start-Sleep -Seconds 2
}

# Step 3: Take dump or live extract
if ($LiveMode) {
    Write-Host "[+] Running live extraction via Frida..."
    python (Join-Path $ProjectRoot "tools\extract_live_dump.py")
} else {
    Write-Host "[+] Taking full memory dump..."
    python (Join-Path $ProjectRoot "tools\take_new_dump.py")

    # Step 4: Run extractor on latest dump
    $latest = Get-ChildItem $DumpsDir -Filter "*.dmp" | Sort-Object LastWriteTime -Descending | Select-Object -First 1
    if ($latest -and $latest.Length -gt 2GB) {
        Write-Host "[+] Running IL2CPP extractor on $($latest.Name)..."
        python (Join-Path $ProjectRoot "tools\extract_reverse_unity6.py") --dump $latest.FullName
    } else {
        Write-Error "Dump failed or too small: $($latest.Length / 1MB) MB"
    }
}

Write-Host "[+] Done. Output: $ProjectRoot\data\precise_dump.json"
```

### Automation Level: FULLY SCRIPTABLE

All steps are non-interactive:
- launch_bypass.exe exits immediately after spawning VRChat
- take_new_dump.py auto-discovers PID via tasklist
- extract_reverse_unity6.py accepts --dump path argument
- ScyllaHide InjectorCLIx64.exe is a CLI tool (no GUI)
- procdump64.exe supports -accepteula for unattended use

**The only human-in-the-loop requirement:** Deciding when VRChat has loaded enough
types. This can be approximated by a fixed 90-second delay after process start, or
by polling working set size until it stabilizes.

---

## 8. COMPARISON: How This Improves Over Previous Approach

### Previous: BSOD Kernel Dump

| Aspect | BSOD Approach | New Approach |
|--------|---------------|--------------|
| Trigger | Force system crash (NotMyFault/BSoD) | Controlled API call |
| Risk | Full system crash, potential data loss | Zero system risk |
| Repeatability | Must reboot after each dump | Can dump multiple times per session |
| Size | Full physical RAM (16-64 GB) | VRChat process only (3-6 GB) |
| Format | Kernel crash dump (needs Volatility) | Standard MDMP (native to DumpReader) |
| Speed | Reboot + dump write: 5-10 minutes | Dump: 60-120 seconds |
| Targeting | Contains ALL processes, must filter | Single-process, clean |

### Previous: procdump -ma (External)

| Aspect | Raw procdump | New Approach |
|--------|--------------|--------------|
| Anti-debug | None (EAC blocks it) | ScyllaHide pre-injection available |
| Reliability | Fails silently on protected processes | ctypes fallback chain (3 methods) |
| Integration | Separate tool, manual path management | Integrated into project scripts |
| Validation | Manual file size check | Extractor auto-validates on parse |
| Automation | Requires manual PID lookup | Auto-discovers VRChat PID |

### Key Improvements:

1. **No system crash required** - dump via API call, not BSOD
2. **Repeatable** - dump 5 times in one session to compare states
3. **Anti-cheat ready** - ScyllaHide injection path for EAC builds
4. **Fallback chain** - ctypes -> procdump64 -> comsvcs.dll (never "all methods failed")
5. **Timing control** - dump at the exact right moment (after type init, before GC)
6. **Validation built-in** - extractor immediately reports class count as quality signal
7. **Fully automated** - single PowerShell script from launch to extracted JSON
8. **Toolkit procdump64 on PATH** - `D:\Tool\debugger\System-Forensics\SysinternalsSuite\procdump64.exe` is a reliable fallback without needing system-wide install

---

## Appendix: Toolkit Asset Inventory

| Tool | Path | Role in Pipeline |
|------|------|-----------------|
| procdump64.exe | `D:\Tool\debugger\System-Forensics\SysinternalsSuite\procdump64.exe` | Fallback dump method |
| ScyllaHide CLI | `D:\Tool\debugger\Debuggers\ScyllaHide\InjectorCLIx64.exe` | Anti-debug bypass |
| ScyllaHide DLL | `D:\Tool\debugger\Debuggers\ScyllaHide\HookLibraryx64.dll` | Hook library |
| Cheat Engine | `D:\Tool\debugger\Debuggers\Cheat Engine\cheatengine-x86_64.exe` | Pre-dump verification |
| CE MCP Bridge | `D:\Tool\debugger\MCP\cheatengine-mcp-bridge\MCP_Server\mcp_cheatengine.py` | AI-driven verification |
| CE Lua Bridge | `D:\Tool\debugger\MCP\cheatengine-mcp-bridge\MCP_Server\ce_mcp_bridge.lua` | CE automation backend |
| Debugger Router | `D:\Tool\debugger\MCP\debugger-router\server.py` | Multi-tool orchestration |
| Il2CppDumper | `D:\Tool\debugger\Unpackers-Game\Il2CppDumper-net6-win-v6.7.46\Il2CppDumper.exe` | Offline metadata parse |
| .NET Runtime | `D:\Tool\debugger\MCP\Runtime\dotnet\dotnet.exe` | For Il2CppDumper |
