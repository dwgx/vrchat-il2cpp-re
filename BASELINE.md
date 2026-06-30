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
| **类语义覆盖** | **46.8%** (4642/9928 混淆类) | compute_final_stats.py |
| **方法语义覆盖** | **93.5%** | 同上 |
| **字段语义覆盖** | **82.7%** | 同上 |

> **2026-06 口径修正**:此前报告的 62.7% 类覆盖是**虚高**的。官方 `is_weak_name`
> 漏判了一整类**结构占位符**(`BaseClass290ImplImpl_31B9`、`BackingFieldBase_16D7`
> 等从类拓扑合成、无语义的名字),把它们误算为 semantic。修正口径(剥离合成 token 后
> 无有意义残留即判 fallback)后,真实类覆盖从虚高的 62.7% 落到 **45.4%**;统一口径后
> workflow/A1 的真实字段签名名能正确覆盖占位符,加上 8 个证据合成名,为 **46.7%**。
> 判定逻辑统一到 `tools/name_quality.py`,pipeline、统计、apply、grader、hexrays-targets
> 共用同一标准,杜绝口径漂移。详见 §5。
>
> **2026-06 二次修正(误判反向)**:`is_weak_name` 用裸 `startswith(("Mono","Service",
> "Type","Static","Struct","Record",...))` 判占位符,把 `MonoBehaviour`/`ServiceProvider`/
> `TypeConverterRegistry`/`ServiceCanvasRoot` 等**合法真名误判为 fallback**(15/15 实测全错)
> ——这是 62.7% 虚高的**镜像 bug**,方向相反:它**低估**覆盖率、并让 apply 静默丢弃真名
> (a1 的 `ServiceCanvasRoot` 被丢、类退回 `Mono1m_84FB`)。根因:pipeline 占位符恒为
> `<前缀><数字>`(`Mono1m`/`Service31m`/`Type5m3f`),真名前缀后必跟**字母**。修正为
> 要求前缀后是数字/下划线边界。恢复 `ServiceCanvasRoot`(D→A),类覆盖 46.7%→**46.8%**
> (4642/9928)。8 个新 golden case 锁死(`test_name_quality.py` 34 例全绿)。

**证据分级(可审计)**:9928 个混淆类每个都带 `confidence` 等级(`tools/grade_evidence.py`,确定性):

| 等级 | 数量 | 含义 |
|---|---|---|
| A | 2045 (20.6%) | 名字 token 与类自身真实字段/方法吻合,二进制符号背书 |
| B | 972 (9.8%) | 强信号(≥2 真字段或 ≥4 真方法)+ 有来源,无 token 重叠 |
| C | 1163 (11.7%) | 信号薄弱,名字未验证 |
| D | 5748 (57.9%) | 纯占位符/无证据 —— 诚实标记为未命名/猜测 |

结构正确性硬证据(ground-truth,可证伪):Vector3=x/y/z、Quaternion=x/y/z/w、Vector2=x/y、Color=r/g/b/a、Transform=157 方法 —— 全部吻合引擎定义。

---

## 2. 一键复现步骤(基础可重建的保证)

前提:本地有 `data/precise_dump.json`(Unity6 提取产物,71MB,gitignore)。
若需从原始 dump 重新提取见 §3。

```bash
cd vrchat-il2cpp-re
# 纯计算,不 mmap 大 dump,机器安全(~30s)
python tools/run_full_pipeline.py --stage 1,2,3 --skip-binary --force
python tools/compute_final_stats.py        # 应得 类46.7 / 方法93.5 / 字段82.7
python tools/test_name_quality.py          # 口径回归守卫,应 ALL GREEN
```

**口径守卫**:`tools/test_name_quality.py` 用 20 个黄金样例 + 残留抽查 + 实时重算
(从 dump 重数覆盖率,须等于已提交的 `coverage_stats.json`)锁死判定逻辑。pipeline 启动时
自动跑黄金样例,漂移则 `exit 2` 中止,**在产出任何数字前**就拦截 62.7% 那种虚高复发
(实测:破坏口径会让重算回到 6233/9928≈62.8%,守卫立即捕获)。改 `name_quality.py` 前先跑它。

**关键**:pipeline 的 **stage 2d**(commit 273f52e5)会自动调用 `apply_class_names.py`,
把 workflow+A1 的 1212 个混淆类命名套回去。**这是命名持久化的核心** —— 在此之前命名是
手动 patch,重跑 pipeline 会丢。现在重跑自动恢复到稳定覆盖率,零手动。

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

冻结**不代表完成 100%**:46.7% 类覆盖意味着仍有 5287 个混淆类是 fallback 名;且混淆类真名在编译期已被 Beebyte 永久销毁(实测:磁盘 metadata 存的就是 `ÌÍÎÏ` 乱码),任何命名本质是据字段/方法/调用推断的语义名,不是找回真名。每个名字带 `confidence` 等级可审计(见 §1)。这是有意识的停点,不是终点。

---

## 5. 覆盖率口径(唯一标准,杜绝漂移)

`tools/name_quality.py` 是"什么算真实语义名"的唯一判定源,`run_full_pipeline.py`、
`compute_final_stats.py`、`apply_class_names.py`、`grade_evidence.py` 都 import 它。
一个名字判为 **fallback** 当且仅当:
1. 命中 legacy 弱前缀(`Type/Struct/Mono/.../Class_`),或
2. 是**结构占位符** —— 剥离合成 token(`BaseClassN/BackingField/Sibling/Impl/Derived/Related/k__BackingField`)
   与尾部 `_HEX` 后,无 ≥3 字符的有意义残留。

例:`BaseClass290ImplImpl_31B9` → 残留空 → fallback;`GestureLocomotionBase_D955`
→ 残留 `GestureLocomotion` → 真名保留。此前**四处口径各自硬编码**导致漂移,把 2553 个
占位符误算 semantic(虚高 62.7%);统一后真实基线 45.4%,再经统一口径下的真名覆盖 + 证据
合成名达到 46.7%。

`tools/synthesize_names.py` 从混淆类**自身字段 token** 确定性合成语义名(仅当有 ≥2 真字段
且能凝出领域 token 才命名,否则诚实留空),名字溯源即二进制符号本身、可复现零猜测。实测
全 D 级里仅 8 个类满足(如 `SliderInteractText`、`MobileOpacityPulse`、`BlurRenderTexture`);
其余 codegen 噪声(322 个 `GetHashCode` 比较器)和仅继承 Unity 方法的类,诚实保留为未命名。

`tools/grade_evidence.py` 在此基础上对每个混淆类做确定性证据分级(A/B/C/D),
结果写入 dump 的 `confidence` + `semantic_source` 字段,输出 `output/evidence_grades.json`。
boilerplate 过滤已校正:`Instantiate/Destroy/FindObjectsOfType/InvokeRepeating/InternalEquals`
等继承自 `UnityEngine.Object`/`MonoBehaviour` 的方法(实测各出现在 500-2000 个类)不算领域信号。

---

## 6. 核心资产清单(都已 tracked,基础不依赖任何本地未提交文件)

```
tools/extract_reverse_unity6.py    # Unity6 提取器(方法+字段+自检)
tools/run_full_pipeline.py         # 5-stage pipeline(含 2d 命名恢复)
tools/apply_class_names.py         # 幂等命名恢复(P1.5 核心)
tools/compute_final_stats.py       # 唯一权威覆盖率口径
tools/name_quality.py              # 覆盖率判定唯一源(pipeline+统计+apply+grader 共用)
tools/test_name_quality.py         # 口径回归守卫(pipeline 启动自动跑,漂移即中止)
tools/synthesize_names.py          # 字段证据→语义名(确定性,零猜测)
tools/grade_evidence.py            # 确定性证据分级(A/B/C/D)
output/synthesized_names.json      # 8 个字段证据合成名(stage 2d 自动套用)
output/evidence_grades.json        # 9928 混淆类逐个分级(stage 2e 自动刷新)
output/workflow_class_names.json   # 430 条混淆类命名
output/a1_class_names.json         # 663 条混淆类命名
output/cross_version_method_names.json  # 40,223 条跨版本名库
output/rename_targets_clean.json   # 2383 个官方口径待命名目标(留给未来)
HANDOFF.md / UPGRADE_PLAN.md       # 交接 / 计划
```

大派生文件(precise_dump / deobfuscated_dump / *.dmp / name_mapping)走 gitignore,可从上述资产 + 原始 dump 复现。
