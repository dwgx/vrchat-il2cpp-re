# VRChat IL2CPP RE — 完整工作流文档

> 最后更新: 2026-06-07 (v2.3, 全量审计后) | 覆盖率: 90.7% | cross_version: 39,623 条
> 本文档面向**接手的 AI 或开发者**，记录项目全貌、已验证的策略、踩过的坑。
> 权威数字以 `output/coverage_stats.json` 为准（每次 pipeline 自动刷新）。

---

## 一、项目概况

**目标**: 反混淆 VRChat 的 GameAssembly.dll（IL2CPP 编译，Beebyte 混淆）

**Beebyte 混淆特征**:
- 类/方法/字段名替换为 `ÌÍÎÏ` 字符串（U+00CC-00CF，23字符）
- Il2CppClass 结构体字段位置**每个版本随机打乱**（核心难点）
- 264 个 IL2CPP 导出函数被重命名，仅 3 个保留原名
- 正则匹配混淆名: `^[Ì-Ï]{3,}$`

**当前成果 (June 5 build, v2.3 全量审计后)**:
- 88,400 类提取，528,135 方法，2,870 字段
- 478,923 方法已命名 (**90.7%**)
- 49,212 方法仍为 hash fallback (m_XXX)
- 39,623 条 cross_version 方法名映射
- 7,813 / 11,503 混淆类有语义名 (67.9%)

> 注: 覆盖率从 94.1% 降到 90.7% 是**有意为之**——全量 122 批质量审计删除了 ~13.8K
> 低置信度预测（主要是 `<>c` 闭包/编译器生成方法的泛化命名）。**精确率换覆盖率**，
> 剩余命名的可信度更高。dump.cs 和 src/ 现在输出 RVA（兼容 Il2CppDumper/IDA/Ghidra）。

---

## 二、关键文件说明

### 核心数据文件

| 文件 | 说明 | 大小 |
|------|------|------|
| `data/precise_dump.json` | IL2CPP 内存提取的原始类/方法/字段数据 | ~40 MB |
| `output/cross_version_method_names.json` | **最重要的产物** — 跨版本方法名映射 `Class::m_XXX → name` | ~5 MB |
| `output/unified_vocabulary.json` | 合并后的命名词汇表 (7,926 条) | ~800 KB |
| `output/name_mapping.json` | 完整的混淆名→语义名映射 | ~9 MB |
| `output/deobfuscated_dump.json` | 反混淆后的完整 dump | ~36 MB |
| `output/deobfuscated_dump.cs` | C# stub 输出 | ~18 MB |
| `output/src/` | 按命名空间组织的 1,126 个 .cs 文件 | — |
| `output/struct_layout_report.json` | reverse_struct_layout.py 的输出，记录当前 build 的偏移 | — |

### 核心工具

| 工具 | 用途 | 关键参数 |
|------|------|---------|
| `tools/run_full_pipeline.py` | 主编排器，5 阶段 pipeline | `--skip-binary`, `--stage N` |
| `tools/deobfuscate.py` | 8 阶段重命名引擎 | — |
| `tools/reverse_struct_layout.py` | **新 build 必跑** — 自动发现 Beebyte 的 struct 偏移 | `--auto-heap`, `--dump` |
| `tools/extract_precise_dump.py` | 从内存 dump 提取 IL2CPP 类 | `--auto-heap`, `--offsets` |
| `tools/rva_propagate_v2.py` | RVA 传播命名（零幻觉） | — |
| `tools/rva_cascade.py` | 级联传播：新名字 → 共享 RVA 组 | — |
| `tools/sibling_context_batches.py` | 构建 LLM 推测批次（无伪代码） | — |
| `tools/codex_worker.py` | Codex CLI 并行工作器 | `--mode`, `--start`, `--end`, `--worker` |
| `tools/merge_sibling_preds.py` | 合并 + 质量过滤预测结果 | — |
| `tools/merge_new_name_sources.py` | 合并所有命名来源到 cross_version | — |
| `tools/build_audit_batches.py` | 构建质量审计批次 | — |

---

## 三、Pipeline 完整流程

### 3.1 新 Build 适配（每次 VRChat 更新必做）

```bash
# 1. 获取内存 dump (需要 VRChat 离线运行)
#    方法 A: Frida 注入 + 内存导出
#    方法 B: 蓝屏 crash dump (详见 tools/bsod/)
#    方法 C: Process Explorer / procdump

# 2. 发现 struct 偏移（Beebyte 每版本打乱）
python tools/reverse_struct_layout.py --dump YOUR_DUMP.dmp --auto-heap
# 输出: output/struct_layout_report.json
# 包含: OFF_NAME, OFF_ELEM, OFF_CAST, OFF_FIELDS, OFF_METHODS, OFF_PARENT, MI_NAME, FI_STRIDE, FI_NAME

# 3. 提取 IL2CPP 类数据
python tools/extract_precise_dump.py YOUR_DUMP.dmp --auto-heap \
    --offsets output/struct_layout_report.json
# 输出: data/precise_dump.json

# 4. 更新 extract_precise_dump.py 中的硬编码偏移（用 struct_layout_report.json 的值）
# 然后跑 pipeline
python tools/run_full_pipeline.py
```

### 3.2 命名扩展（提升覆盖率）

**策略优先级（按可靠性排序）**:

1. **RVA 传播**（零幻觉，最可靠）
   ```bash
   python tools/rva_propagate_v2.py    # 相同函数指针 = 相同函数
   python tools/rva_cascade.py         # 级联传播到共享 RVA 组
   ```

2. **Hex-Rays 伪代码分析**（有证据支撑）
   ```bash
   # 在 IDA 中: 批量反编译 → 导出伪代码
   python tools/ida_hexrays_export.py  # (在 IDA 脚本中运行)
   # 然后用 Codex 从伪代码推测方法名
   python tools/codex_worker.py --mode mega --start 0 --end 262 --worker 0
   ```

3. **Sibling-context 推测**（无伪代码，靠上下文）
   ```bash
   python tools/sibling_context_batches.py   # 生成批次
   python tools/codex_worker.py --mode sibling --start 0 --end 111 --worker 0
   python tools/codex_worker.py --mode sibling --start 111 --end 222 --worker 1
   python tools/codex_worker.py --mode sibling --start 222 --end 333 --worker 2
   python tools/merge_sibling_preds.py       # 质量过滤 + 合并
   python tools/rva_cascade.py               # 级联新名字
   ```

4. **Neighbor-class 推测**（单类上下文，收益最低）
   ```bash
   # 已有 6,242 个 batch 在 output/llm_batches_neighbor/
   python tools/codex_worker.py --mode neighbor --start 0 --end 2081 --worker 0
   ```

5. **质量审计**
   ```bash
   python tools/build_audit_batches.py
   python tools/codex_worker.py --mode audit --start 0 --end 41 --worker 0
   # audit 结果: {"remove": [...], "fix": {...}}
   ```

### 3.3 最终合并 + 输出

```bash
python tools/merge_new_name_sources.py    # 合并所有来源 → cross_version
python tools/rva_cascade.py               # 最后一次级联
python tools/run_full_pipeline.py         # 重跑 pipeline 生成最终输出
```

---

## 四、Codex Worker 使用指南

### 启动方式（Windows PowerShell）

```powershell
# 后台启动，不占终端
Start-Process python -ArgumentList "tools/codex_worker.py","--mode","sibling","--start","0","--end","111","--worker","0" `
    -RedirectStandardOutput "output/worker_0.log" `
    -RedirectStandardError "output/worker_0_err.log" `
    -WindowStyle Hidden -WorkingDirectory "D:\Project\vrchat-il2cpp-re"
```

### 四种模式

| 模式 | 输入目录 | 输出前缀 | 超时 | 说明 |
|------|---------|---------|------|------|
| `mega` | `output/codex_mega_batches/` | `pred_` | 900s | 伪代码分析，最精确 |
| `sibling` | `output/sibling_batches/` | `pred_` | 300s | 类上下文推测 |
| `neighbor` | `output/llm_batches_neighbor/` | `pred_` | 120s | 单类推测，收益低 |
| `audit` | `output/audit_batches/` | `audit_` | 300s | 审计已有预测质量 |

### 注意事项
- Worker 自动跳过已存在的 pred 文件（可重启不重跑）
- Codex 命令: `codex exec --skip-git-repo-check --dangerously-bypass-approvals-and-sandbox`
- 环境变量 `CODEX_CMD` 可覆盖 codex 路径
- 最多同时跑 3 个 worker（Codex 配额限制）
- pred 文件可能有 UTF-8 BOM，merge 脚本已处理

---

## 五、已验证的经验教训

### 5.1 Prompt 工程

**失败**: 保守 prompt "SKIP is always better than a guess" → 100% 输出 SKIP，零有效预测
**成功**: 激进 prompt "You MUST predict a name for EVERY method — do NOT output SKIP" + 列出 9 种具体策略 + VRChat 领域知识 → 平均每 batch 65 个预测

**关键**: prompt 要包含：
- 明确的输出格式要求
- 禁止使用的泛化名字黑名单（Update, Init, Process, Handle...）
- VRChat 领域关键词（Photon, Avatar, Udon, UI, Audio, Safety, Social）
- 多种推测策略（pattern completion, property pairs, event patterns...）

### 5.2 质量控制

合并预测时必须过滤：
- **泛化名字黑名单**: Update, Initialize, Process, Handle, Execute, Method, Func 等
- **C# 样板黑名单**: .ctor, Dispose, MoveNext, GetHashCode, Equals 等
- **每类去重**: 同一个类不能有超过 2 个相同名字的方法
- **全局频率上限**: 同一个名字在 cross_version 中出现超过 50 次就丢弃
- **Fallback 类过滤**: AsyncStateMachine_*, Clone_*, Compare_* 等 fallback 类的预测基本都是废的

### 5.3 Windows 特殊处理

- `sys.stdout.reconfigure(encoding='utf-8')` — 所有 Python 脚本开头必加，否则 CJK 输出崩溃
- `tmp.replace(target)` 在 Windows 上可能 PermissionError → 需要 try/except fallback 用 os.remove + os.rename
- Codex 输出文件可能带 UTF-8 BOM (0xEF 0xBB 0xBF) → 读取时 `encoding='utf-8-sig'`
- PowerShell 启动后台进程用 `Start-Process -WindowStyle Hidden`，不要用 bash 的 `nohup &`

### 5.4 Git 规范

- **绝对不许有 Co-Authored-By 或 claude 引用** — 所有贡献归 dwgx
- 如果之前的 commit 带了，用 `git filter-branch -f --msg-filter 'sed "/Co-Authored-By/d"'` 清除后 force push
- `.gitignore` 要覆盖：batch 文件、pred 文件、tmp 文件、.env、备份文件
- 提交前检查 `git log --format='%B' | grep -i claude` 确保干净

---

## 六、目前遗留和下一步

### 已完成 ✅
- [x] Jun 5 build 完整 pipeline (94.1% coverage)
- [x] RVA propagation v1 + v2 + cascade
- [x] Codex mega-batch (262 batch, 2,812 predictions)
- [x] Sibling-context (333 batch, 22,314 raw → 13,565 merged)
- [x] Neighbor batch (6,242 batch, 4,157 有结果)
- [x] 质量审计 pipeline 搭建并运行中
- [x] reverse_struct_layout.py 自动检测（支持新 build）
- [x] extract_precise_dump.py --offsets 支持
- [x] GitHub 清理（无 claude 引用）
- [x] v2.1 release 发布

### 已完成 (v2.3, 全量审计) ✅
- [x] 全量 122 批质量审计完成并应用（删 13,777 + 修 137），cross_version 53,292→39,623
- [x] `tools/apply_audit_results.py` — 自动应用 remove/fix（自动备份）
- [x] `tools/compute_final_stats.py` — 单一真相源统计，已接入 pipeline Stage 3c
- [x] dump.cs + src/ 输出 RVA 格式（兼容 Il2CppDumper/IDA/Ghidra）+ 字段类型/偏移
- [x] 全文档数字统一到权威值（README/WORKFLOW/dashboard/coverage_report）
- [x] 所有文件名/代码中 claude 引用清除

### 已完成 (v2.4) ✅
- [x] **运行时字段恢复**【最大缺口已解决】: 字段 2,870 → **71,972**（92.1% 带类型）。
      由配套私有项目 `vrc-runtime-re` 走 dump 的 FieldInfo→Il2CppType 提取，
      产出 `output/field_types.json`，pipeline Stage 2b 自动按 VA 合并。
      混淆 VRChat 类现在带真实类型（VRCPlayerApi/PositionEvent/VRCStation…），
      可作为方法/类命名的新上下文。

### 已完成 (v2.5) ✅
- [x] **字段类型反哺命名**: 用 71K 字段类型给 fallback 混淆类证据支撑的真名。
      源 `output/fieldtype_class_names.json`（118 唯一名，全部客观证据验证：引用的
      字段类型必须真在 dump 里），pipeline Stage 2c 自动应用（189 个类实例）。
      例: VRCPlayer_F618→VRCPlayerAvatarRuntimeState, NetworkSyncable_9834→
      UdonBehaviourNetworkSyncQueue, WorldProximityExitStation_C9A0→WorldStationInteractableBinding。

### 未做 ❌（按 ROI 排序）
- [ ] **扩大字段命名**: 当前只覆盖有 ≥2 域字段类型的 fallback 类。可放宽到方法+字段联合证据。
- [ ] **运行时实时探测**: VM 物理 RAM 快照 + memprocfs 后端（见 vrc-runtime-re 私有项目）。
- [ ] **IDA 分析深化**【中价值】: 28K 函数已反编译，剩余 hash 方法可继续补伪代码走 mega-batch。
- [ ] **剩余 ~49K hash 方法**【低价值】: 大部分是 `<>c` 闭包/lambda/编译器生成/极通用方法，
      审计已证明强行命名 = 幻觉。边际收益极低，不建议盲目冲覆盖率。

### 接手者：从这里开始 👇

**第一步永远是**：确认当前 build 是否还是 June 5。VRChat 自动更新后偏移会变。
```bash
# 1. 新 dump 后必跑（发现新偏移）
python tools/reverse_struct_layout.py --dump <NEW>.dmp --auto-heap
# 2. 提取
python tools/extract_precise_dump.py <NEW>.dmp --auto-heap --offsets output/struct_layout_report.json
# 3. 重跑
python tools/run_full_pipeline.py --force
# 4. 看权威数字
type output\coverage_stats.json
```

**最高 ROI 的下一步工作 = Frida 字段提取**（理由见上）：
```bash
start "" "D:\Steam\steamapps\common\VRChat\VRChat.exe" --no-vr
python tools/extract_field_types_v2.py        # 需先把 extract_field_types_v2.js 偏移更新到当前 build
python tools/merge_field_types.py
python tools/run_full_pipeline.py --force
```
⚠️ Frida JS 脚本（`extract_field_types_v2.js` 等）的偏移**仍是旧 build 的硬编码**，
运行前必须按 `output/coverage_stats.json` 同期的 `reverse_struct_report` 更新。

**不要做的事**（已验证死路）：
- ❌ 再跑 neighbor batch（平均 <1 有效预测/batch）
- ❌ 强行给 `<>c`/lambda hash 方法命名（审计会再删掉）
- ❌ 本地 EAC/EOS 伪造来联机（服务端校验，客户端改无效）

---

## 七、偏移速查表

### June 5 Build (当前)

| 偏移 | 值 | 说明 |
|------|-----|------|
| OFF_NAME | 0x50 | Il2CppClass.name 指针 |
| OFF_NS | 0x18 | Il2CppClass.namespaceString |
| OFF_ELEM | 0x10 | Il2CppClass.element_class (自引用) |
| OFF_CAST | 0x40 | Il2CppClass.castClass (自引用) |
| OFF_FIELDS | 0x1D8 | Il2CppClass.fields 指针 |
| OFF_METHODS | 0x88 | Il2CppClass.methods 指针 |
| OFF_PARENT | 0x80 | Il2CppClass.parent 指针 |
| OFF_MCNT | 0x120 | method_count (u16) |
| OFF_FCNT | 0x122 | field_count (u16) |
| MI_NAME | 0x18 | MethodInfo.name 指针 |
| FI_STRIDE | 0x30 | FieldInfo 结构体大小 |
| FI_NAME | 0x08 | FieldInfo.name 指针 |

**注意**: 这些值**每个 VRChat 版本都会变**。新版本必须先跑 `reverse_struct_layout.py --auto-heap` 重新发现。

---

## 八、环境配置

```
Python 3.14
Codex CLI: C:\Users\dwgx1\AppData\Roaming\npm\codex.cmd
    codex exec --skip-git-repo-check --dangerously-bypass-approvals-and-sandbox
LLM API: OPENAI_API_BASE + OPENAI_API_KEY (env vars from .env)
IDA Pro: 9.x + MCP
Frida: 17.10.1
VRChat: D:\Steam\steamapps\common\VRChat\
项目目录: D:\Project\vrchat-il2cpp-re\
GitHub: https://github.com/dwgx/vrchat-il2cpp-re
```
