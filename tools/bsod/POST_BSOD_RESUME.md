# Post-BSOD Resume Checklist

## 当前进度
- Config applied: CrashDumpEnabled=1 (Complete), pagefile 34-40GB, AutoReboot=1
- Tools ready: `tools/bsod/NotMyFault64.exe`, `tools/bsod/notmyfaultc64.exe`, volatility3 via `vol` CLI
- Previous commits: 4930b6a (78%), 94b1c50 (90.85%)

## User 做 (before BSOD)
1. 保存所有 unsaved 工作
2. 关闭不必要 apps（保留 Steam + VRChat + 这个终端）
3. **重启一次**（apply 34GB pagefile — 当前 runtime 仍是 23GB）
4. 重启后：Steam 启动 VRChat → 进 world → memory ≥ 5GB
5. 告诉 Claude "ready"

## Claude 做 (trigger BSOD)
```bash
# Verify VRChat loaded
powershell -Command "(Get-Process VRChat).WorkingSet64 / 1GB"  # should be >5

# Trigger BSOD via signed Sysinternals driver (no prompts)
./tools/bsod/notmyfaultc64.exe /crash
# OR: NotMyFault64.exe GUI, click "Crash"
```

Windows 会：
- BSOD → 写 C:\Windows\MEMORY.DMP (~32GB)
- AutoReboot=1 自动重启

## Post-Reboot (VRChat 已死，MEMORY.DMP 在磁盘)

User 重新打开终端 → 回到项目 → 告诉 Claude "back"

Claude 做：
```bash
ls -la /c/Windows/MEMORY.DMP  # verify exists, ~32GB
```

### 提取 VRChat memory
```bash
# Find VRChat PID in kernel dump
vol -f C:\\Windows\\MEMORY.DMP windows.pslist.PsList | grep -i vrchat

# Dump all user memory regions for VRChat
vol -f C:\\Windows\\MEMORY.DMP -o /d/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools/tools/vol_out windows.memmap.Memmap --pid <PID> --dump
```

这会产出 `pid.<PID>.dmp` 的各 VAD range。合并成单 minidump 要 custom script (volatility 默认 per-VAD dump)。

**替代路径**: 写一个 Python 脚本用 Volatility3 API 直接提取 VRChat 的完整 VA→memory mapping，写成 minidump 格式 (MDMP)，这样现有 `extract_field_types_from_dump.py` 能直接吃。

### 跑 pipeline
```bash
cd /d/WorkSpace/VRChat/VRChat_Data/il2cpp_dump_tools
python tools/extract_precise_dump.py tools/VRChat_from_kernel.dmp
python tools/extract_field_types_from_dump.py --dump tools/VRChat_from_kernel.dmp
python tools/run_full_pipeline.py --stage 3
python tools/merge_field_types.py
python tools/generate_source_tree.py
# Verify coverage > 95%
```

### Commit + push
```bash
git add -A
git commit -m "Field types from kernel crash dump"
git push origin main
```

## Restore if anything broken

```bash
reg import tools/crashcontrol_backup.reg  # 若要 revert Complete dump config
```

Pagefile 变更需要另一次重启才能还原 auto-managed（在 systempropertiesadvanced GUI）。
