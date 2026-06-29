# VRChat IL2CPP — Unity 6 基线冻结记录

> 本文件记录 **Unity 6 (6000.0.60f1) 基础**的冻结状态与复现步骤。
> 决策:打完这个基础后**冻结不动**,等 VRChat 出现重大结构变动(新 Unity 版本 / 混淆器换代)再出手。
> 冻结日期:2026-06-29 | 所有数字均为 `tools/compute_final_stats.py` 官方口径实测。

---

## 1. 冻结基线 = 什么

| 项 | 值 | 验证方式 |
|---|---|---|
| 游戏引擎 | **Unity 6 (6000.0.60f1)** | `UnityPlayer.dll` 二进制直读确认(非记忆) |
| 二进制时间 | GameAssembly/UnityPlayer = 2026-06-26 | 文件 mtime |
| 数据源 dump | `VRChat_32984_20260629_180349_full.dmp` (4.1GB) | dump summary 标记 `unity6-6000.0` |
| 提取规模 | 64,773 类 / 569,859 方法 / 188,384 字段 | dump summary |
| **类语义覆盖** | **62.7%** (6223/9928 混淆类) | compute_final_stats.py |
| **方法语义覆盖** | **93.5%** | 同上 |
| **字段语义覆盖** | **82.7%** | 同上 |

结构正确性硬证据(ground-truth,可证伪):Vector3=x/y/z、Quaternion=x/y/z/w、Vector2=x/y、Color=r/g/b/a、Transform=157 方法 —— 全部吻合引擎定义。

---

## 2. 一键复现步骤(基础可重建的保证)

前提:本地有 `data/precise_dump.json`(Unity6 提取产物,71MB,gitignore)。
若需从原始 dump 重新提取见 §3。

```bash
cd vrchat-il2cpp-re
# 纯计算,不 mmap 大 dump,机器安全(~30s)
python tools/run_full_pipeline.py --stage 1,2,3 --skip-binary --force
python tools/compute_final_stats.py        # 应得 类62.7 / 方法93.5 / 字段82.7
```

**关键**:pipeline 的 **stage 2d**(commit 273f52e5)会自动调用 `apply_class_names.py`,
把 workflow+A1 的 1212 个混淆类命名套回去。**这是命名持久化的核心** —— 在此之前命名是
手动 patch,重跑 pipeline 会丢(实测会从 62.6% 掉回 60.3%)。现在重跑自动恢复到 62.7%,零手动。

`apply_class_names.py` 是**幂等**的:只填 weak/混淆名,绝不覆盖 pipeline 已起的好名(skip 970 / apply 235)。

---

## 3. 从原始 dump 重新提取(仅当 precise_dump.json 丢失)

```bash
# 离线直启 VRChat.exe(绕 EAC,纯离线零风险),等内存稳定在高位再 dump
# 取完立即 taskkill 释放内存(机器有蓝屏史,见 HANDOFF §7)
python tools/extract_reverse_unity6.py <dump.dmp> --output-json data/precise_dump.json
# 提取器自带自检:Transform 解析 + Color r/g/b/a 字段校验,布局变了会报错不吐垃圾
```

提取器三层自适应(对未来 build 也稳):ASLR 堆段自动探测 / Transform 偏移自检 / parent 偏移运行时共识检测。

---

## 4. 冻结边界 — 什么时候该重新出手

基础冻结后**不主动改动**。以下情况才重新介入:

- **VRChat 升级 Unity 版本**(6000.0.60f1 → 其他)→ IL2CPP 布局可能再次重排,提取器自检会报错,届时按 §3 的 ground-truth 法重新测绘偏移(HANDOFF §2 有完整偏移表)。
- **混淆器换代**(Beebyte 字符集变化)→ `is_obf` 判定需更新。
- **想继续提升覆盖率** → 见 HANDOFF §6 的 P2/P3/P4(干净目标集 `rename_targets_clean.json` 已备好 2383 个)。

冻结**不代表完成 100%**:62.7% 类覆盖意味着仍有 3705 个混淆类是 fallback 名;混淆类的语义命名是 AI 推断,不保证逐个正确。这是有意识的停点,不是终点。

---

## 5. 核心资产清单(都已 tracked,基础不依赖任何本地未提交文件)

```
tools/extract_reverse_unity6.py    # Unity6 提取器(方法+字段+自检)
tools/run_full_pipeline.py         # 5-stage pipeline(含 2d 命名恢复)
tools/apply_class_names.py         # 幂等命名恢复(P1.5 核心)
tools/compute_final_stats.py       # 唯一权威覆盖率口径
output/workflow_class_names.json   # 430 条混淆类命名
output/a1_class_names.json         # 663 条混淆类命名
output/cross_version_method_names.json  # 40,223 条跨版本名库
output/rename_targets_clean.json   # 2383 个官方口径待命名目标(留给未来)
HANDOFF.md / UPGRADE_PLAN.md       # 交接 / 计划
```

大派生文件(precise_dump / deobfuscated_dump / *.dmp / name_mapping)走 gitignore,可从上述资产 + 原始 dump 复现。
