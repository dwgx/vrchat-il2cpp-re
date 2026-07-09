# dump_vrchat.ps1 - Complete automated VRChat IL2CPP dump workflow
# Run as Administrator: Start-Process powershell -Verb RunAs -ArgumentList "-File D:\Project\vrchat-il2cpp-re\dump_vrchat.ps1"

param(
    [int]$WaitSeconds = 90,
    [switch]$WithScyllaHide,
    [switch]$LiveMode,
    [switch]$SkipExtract
)

$ErrorActionPreference = "Stop"
$ProjectRoot = "D:\Project\vrchat-il2cpp-re"
$DumpsDir = Join-Path $ProjectRoot "dumps"
$ToolkitRoot = "D:\Tool\debugger"

# Ensure dumps directory exists
New-Item -ItemType Directory -Force -Path $DumpsDir | Out-Null

Write-Host "=== VRChat IL2CPP Dump Workflow ===" -ForegroundColor Cyan
Write-Host "Project: $ProjectRoot"
Write-Host "Toolkit: $ToolkitRoot"
Write-Host ""

# Step 1: Find or launch VRChat
$vrc = Get-Process VRChat -ErrorAction SilentlyContinue
if (-not $vrc) {
    $bypassExe = Join-Path $ProjectRoot "tools\launch_bypass.exe"
    if (Test-Path $bypassExe) {
        Write-Host "[1/4] Launching VRChat via launch_bypass.exe (EAC skipped)..." -ForegroundColor Green
        & $bypassExe --no-vr
    } else {
        Write-Host "[1/4] launch_bypass.exe not found. Attempting direct launch..." -ForegroundColor Yellow
        $vrchatDir = "C:\Program Files (x86)\Steam\steamapps\common\VRChat"
        if (Test-Path "$vrchatDir\VRChat.exe") {
            Start-Process "$vrchatDir\VRChat.exe" -ArgumentList "--no-vr" -WorkingDirectory $vrchatDir
        } else {
            Write-Error "Cannot find VRChat.exe. Launch manually, then re-run this script."
        }
    }

    Write-Host "    Waiting for VRChat process to appear..."
    $timeout = 60
    $elapsed = 0
    do {
        Start-Sleep -Seconds 2
        $elapsed += 2
        $vrc = Get-Process VRChat -ErrorAction SilentlyContinue
    } while (-not $vrc -and $elapsed -lt $timeout)

    if (-not $vrc) { Write-Error "VRChat did not start within ${timeout}s" }

    Write-Host "    VRChat started (PID $($vrc.Id))"
    Write-Host "    Waiting ${WaitSeconds}s for IL2CPP type initialization..."
    Start-Sleep -Seconds $WaitSeconds
} else {
    Write-Host "[1/4] VRChat already running (PID $($vrc.Id))" -ForegroundColor Green
}

# Step 2: Anti-debug bypass (if requested)
if ($WithScyllaHide) {
    Write-Host "[2/4] Injecting ScyllaHide anti-debug..." -ForegroundColor Green
    $injector = "$ToolkitRoot\Debuggers\ScyllaHide\InjectorCLIx64.exe"
    $hookDll = "$ToolkitRoot\Debuggers\ScyllaHide\HookLibraryx64.dll"

    if (-not (Test-Path $injector)) { Write-Error "ScyllaHide not found at: $injector" }
    if (-not (Test-Path $hookDll)) { Write-Error "HookLibrary not found at: $hookDll" }

    & $injector "pid:$($vrc.Id)" $hookDll
    if ($LASTEXITCODE -ne 0) { Write-Warning "ScyllaHide injection may have failed (exit code $LASTEXITCODE)" }
    Start-Sleep -Seconds 2
    Write-Host "    ScyllaHide injected (PEB patched, NtQueryInformationProcess hooked)"
} else {
    Write-Host "[2/4] Anti-debug bypass: skipped (use -WithScyllaHide if needed)" -ForegroundColor DarkGray
}

# Step 3: Take dump or live extract
if ($LiveMode) {
    Write-Host "[3/4] Running live extraction via Frida..." -ForegroundColor Green
    python (Join-Path $ProjectRoot "tools\extract_live_dump.py")
    if ($LASTEXITCODE -ne 0) { Write-Error "Live extraction failed" }
    Write-Host "    Output: $ProjectRoot\data\precise_dump.json"
} else {
    Write-Host "[3/4] Taking full memory dump..." -ForegroundColor Green
    $dumpScript = Join-Path $ProjectRoot "tools\take_new_dump.py"

    python $dumpScript
    if ($LASTEXITCODE -ne 0) {
        Write-Host "    ctypes dump failed. Trying procdump64 fallback..." -ForegroundColor Yellow
        $procdump = "$ToolkitRoot\System-Forensics\SysinternalsSuite\procdump64.exe"
        $fallbackPath = Join-Path $DumpsDir "VRChat_$($vrc.Id)_fallback.dmp"
        & $procdump -ma -accepteula $vrc.Id $fallbackPath
        if (-not (Test-Path $fallbackPath)) { Write-Error "All dump methods failed. Run as Administrator." }
    }

    # Find latest dump
    $latest = Get-ChildItem $DumpsDir -Filter "*.dmp" | Sort-Object LastWriteTime -Descending | Select-Object -First 1
    if (-not $latest) { Write-Error "No dump file found in $DumpsDir" }

    $sizeMB = [math]::Round($latest.Length / 1MB)
    $sizeGB = [math]::Round($latest.Length / 1GB, 1)
    Write-Host "    Dump: $($latest.Name) (${sizeGB} GB)"

    if ($latest.Length -lt 1GB) {
        Write-Warning "Dump is smaller than expected (${sizeMB} MB). May be incomplete."
    }

    # Step 4: Run extractor
    if (-not $SkipExtract) {
        Write-Host "[4/4] Extracting IL2CPP metadata..." -ForegroundColor Green
        python (Join-Path $ProjectRoot "tools\extract_reverse_unity6.py") --dump $latest.FullName

        if ($LASTEXITCODE -eq 0) {
            $output = Join-Path $ProjectRoot "data\precise_dump.json"
            if (Test-Path $output) {
                $json = Get-Content $output -Raw | ConvertFrom-Json
                Write-Host ""
                Write-Host "=== Extraction Complete ===" -ForegroundColor Cyan
                Write-Host "    Output: $output"
                if ($json.summary) {
                    Write-Host "    Classes: $($json.summary.total_classes)"
                    Write-Host "    Methods: $($json.summary.total_methods)"
                    Write-Host "    Namespaces: $($json.summary.namespace_count)"
                }
            }
        } else {
            Write-Error "Extraction failed. Check dump validity."
        }
    } else {
        Write-Host "[4/4] Extraction skipped (-SkipExtract)" -ForegroundColor DarkGray
    }
}

Write-Host ""
Write-Host "Done." -ForegroundColor Green
