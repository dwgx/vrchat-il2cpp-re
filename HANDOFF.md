# VRChat IL2CPP 逆向项目 — AI 交接文档

> 写给下一个接手的 AI。本文档记录项目目标、当前真实状态、已踩的坑、下一步该做什么。
> 所有数字均为实测(`tools/compute_final_stats.py` 官方口径),非估计。
> 最后更新:2026-06-29

---

## 0. 一句话现状

VRChat 升级到 **Unity 6 (6000.0.60f1)**,旧 IL2CPP 提取器全部失效。本项目已**重新破解 Unity 6 的类/方法/字段内存布局**并跑通命名 pipeline。当前覆盖率:**方法 93.5% / 类 62.6% / 字段 82.7%**。P1(修 9 个 weak 命名)已完成;**做 P2 前必先解决 §5.5 的命名持久性隐患**(命名是手动 patch、不在 pipeline 内,重跑会丢)。

---

## 1. 项目目标与边界

**目标**:对 VRChat 客户端做 IL2CPP 反混淆 —— 从内存 dump 提取类/方法/字段,给混淆名(Beebyte 风格,字符是 U+00CC..U+00CF)推断语义名,最终产出可读的 C# 源码树。

**安全边界(必须遵守)**:
- ✅ **离线直启 `VRChat.exe`(绕过 `start_protected_game.exe` 引导器)** → EAC 反作弊根本不加载,纯离线、不连官方服务器。这是干净的逆向研究,零风险。
- ✅ 所有分析都是**只读** dump 文件 + 纯计算。
- ❌ **不做**"EAC 活动时 dump 而不被检测" = 规避活动反作弊,封号不可逆,拒绝。
- IL2CPP 元数据在引擎初始化阶段(登录前)就解密驻留,离线 dump 和线上结构完全一样,所以不需要碰 EAC。

---

## 2. Unity 6 结构图谱(已破解,核心资产)

旧版(June-13/Unity 2022)偏移在 Unity 6 全部失效。已用 ground-truth 重新测绘验证:

| 结构字段 | June-13(旧) | **Unity 6(现)** |
|---|---|---|
| MethodInfo.name | +0x10 | +0x10 |
| MethodInfo → klass | +0x18 | **+0x20** |
| klass.name | +0xA8 | **+0x98** |
| klass.namespace | +0x18 | +0x18 |
| klass self-ref(自检锚) | — | +0x10 |
| klass.parent | 不同 | **+0xA0**(运行时共识探测,非硬编码) |
| klass.fields 数组 | — | **+0xA8** |
| FieldInfo stride | 0x30 | **0x20** |
| FieldInfo.name | +0x10 | **+0x08** |
| FieldInfo.parent(枚举终止锚) | — | **+0x18** |
| FieldInfo.type(Il2CppType*) | — | +0x00(**尚未解码**) |

**关键技术点**:
- metadata 加密 + 导出符号剥离 → 静态工具(Il2CppDumper)无效。改用**反向 MethodInfo 枚举**:全 heap 扫所有 MethodInfo,反查 klass,重建类树。
- 提取器三层自适应(对未来 build 也稳):ASLR 堆段自动探测 / Transform 自检 / parent 偏移运行时共识检测。
- ground truth 验证:Transform 重建出 157 方法;字段用 Vector3(x/y/z)、Color(r/g/b/a)、Vector2(x/y)三者收敛确认。
- field_count slot 不可靠,字段靠 **parent==klass 的 walk 枚举**(干净终止)。

---

## 3. 关键文件地图

```
tools/extract_reverse_unity6.py   # Unity6 提取器(核心,带方法+字段提取+自检)
tools/compute_final_stats.py      # 官方覆盖率计算(唯一权威口径!见§5)
tools/run_full_pipeline.py        # 完整命名 pipeline(5 stage,纯计算 ~27s)
data/precise_dump.json            # canonical 输入(=Unity6 高质量版,71MB,gitignore)
output/deobfuscated_dump.json     # pipeline 输出主产物(62MB,gitignore)
output/coverage_stats.json        # 覆盖率快照
output/cross_version_method_names.json  # 跨版本名库 40,223 条(方法回填资产)
output/workflow_class_names.json  # workflow 命名结果 430 条
output/a1_class_names.json        # Stage A1 命名结果 670 条
output/rename_targets_clean.json  # ★官方口径的干净待命名目标 2383 个(§5新生成)
UPGRADE_PLAN.md                   # 升级计划书(注意:其中7118数字是错的,见§5)
dumps/VRChat_32984_20260629_180349_full.dmp  # 当前高质量 Unity6 dump(4.1GB)
```

**memory** 在 `~/.claude/projects/D--Project/memory/`,关键条目:
`vrchat-unity6-struct-map`、`vrchat-unity6-fields-and-workflow`。

---

## 4. 本 session 已完成(6 个提交,均未 push,领先 origin/master 6)

| commit | 内容 |
|---|---|
| 2a8eaeff / 6ca97a0d | June-13 布局破解 + 提取器加固 |
| 0e4b45eb | Unity 6 提取器(反向 MethodInfo 枚举),65042 类 |
| 429debfa | **FieldInfo 破解 + 188K 字段提取**(字段从 0 到有) |
| 4a768a67 | workflow 并行命名:430 个混淆类(workflow 命名源) |
| d88b62be | Stage A1 并行命名:670 个类(但有效仅 234,见§5) |

**命名方法论(已验证有效)**:把"有可读字段签名的混淆类"切片,多个 sonnet subagent **并行**据字段名推断语义类名。例:`avatarImage/cameraButton`→相机UI;`_eventCode/_targets`→Photon网络;`AuthenticateWithOculus/Discord/Steam`→`LoginAuthenticationScreen`。产出质量高的真实例子:`PhotonSocketImplementation`、`FaceDetectionTaskInput`、`MicrophoneSettingsPanel`。

---

## 5. ⚠️ 关键诊断结论 — 接手必读

**Stage A1 暴露了一个重要 bug,直接影响后续策略:**

1. **目标筛选口径错了**。我之前用自定义的 `is_fallback`(检测 `_数字`后缀/beebyte)筛"待命名类",但**很多类的 name 已被 pipeline 用别的命名源起过正常英文名**(不带这些特征),我的正则没识别出"已命名",把它们也喂进去了。
   - 结果:A1 产出 670 命名,但**只有 234 个真正是待命名 fallback 类**,其余 436 个是在已命名类上重复劳动 → **65% 算力浪费**。
   - 官方覆盖只 +2.3%(60.3%→62.6%),与 234 自洽。

2. **唯一权威口径是 `tools/compute_final_stats.py`**:它只看 9928 个混淆类(有 `original_name` 的)里,name 非 weak 的比例。`is_weak_name` 只拦特定前缀(`Type/Struct/Mono/Service/Obf_/Class_/Unknown/...`)。**不要再自己写覆盖率口径**(我写过一个,口径松,误报成 86%,差点报假成绩)。

3. **计划书 UPGRADE_PLAN.md 里的 7118 是错的**。用官方口径,**真实待命名缺口只有 2383 个**(已存到 `output/rename_targets_clean.json`),其中强信号8 / 中信号16 / **2359 个靠方法签名**。

4. ~~遗留待修:8 个 A1 命名撞 weak 前缀~~ **✅ 已修(commit 8ef8abc9)**:实际 9 个。2 个 `Typed*` 是真名误伤(撞 `Type` 前缀)→ 改 `IconLayoutItem`/`TitledDescriptionPanel`;7 个 `Unknown*` 无真实信号(纯 hex 字段 + 样板方法)→ 诚实降级为 fallback(从源文件删除,不伪造名骗 weak 检测)。类 semantic 6214→6216。

5. **⚠️ 持久性隐患(新发现,重要)**:`a1_class_names.json`/`workflow_class_names.json` 等命名结果是**手动 patch 进 `output/deobfuscated_dump.json` 的,没有任何 pipeline 脚本引用它们**(grep `field_signature_a1` 在 tools/ 下零命中)。→ **重跑 `run_full_pipeline.py` 会覆盖 dump、丢失全部 1212 个混淆类命名**。P1 修复已同步写回所有源文件(a1/workflow 的 class_names+final_names+rename_targets),但**根本解法**是写一个 apply 脚本把这些命名源纳入 pipeline 的 stage,或在 pipeline 末尾自动 re-apply。下一个 AI 做 P2 前务必先解决这个,否则命名成果不稳。

---

## 6. 下一步建议(按优先级)

**P0 — 先 push 锁住成果**:9 个提交未 push,机器有反复 KMODE 蓝屏史(见§7),`git push -u origin master` 防丢。push 是 outward 操作,先跟用户确认。

**P1 — ~~修那 8 个 weak 名~~ ✅ 已完成(commit 8ef8abc9)**。

**P1.5 — 修持久性隐患(新增,做 P2 前必做)**:见§5.5,命名是手动 patch 不在 pipeline 内,重跑会丢。需把命名源纳入 pipeline 或末尾 re-apply。

**P2 — 用干净目标集做命名**:`output/rename_targets_clean.json`(2383 个,官方口径)。注意 2359 个靠方法签名(字段弱),命名指令要:
   - 避免泛化名(`XxxWrapper/XxxSubtype/XxxEnumerator`)和 `_数字` 后缀(会被官方判 weak 或低质)。
   - **过滤 Unity codegen 噪音**:字段全是 `_kInstanceID_None/_offsetOfInstanceID/_objectIsNull/_cloneDestroyed` + 方法全是 `MoveNext/Dispose/get_Current/op_Implicit` 的类是协程状态机/迭代器,**跳过不命名**(A1 时一个 agent 正确发现了这点,80 个这种类已被剔除)。
   - agent **一律用 Write 写文件**、只回报条数 —— 直接返回长 JSON 会撞 32k 输出上限被截断(已踩坑两次)。

**P3 — Stage B 字段**:32,543 个 `f_XXX` 字段。需先解码 `FieldInfo.type`(Il2CppType*,低位编码类型索引)→ 可补字段类型。再用 cross-version 字段映射回填。目标字段 82.7%→90%。

**P4 — Stage C 方法**:36,873 个 hash 方法,用 `cross_version_method_names.json`(40,223 条)回填。目标 93.5%→95%。

---

## 7. 工程纪律(踩坑总结)

- **机器稳定性**:这台机器有第三方内核驱动冲突史(`nvlddmkm`+VeryKuai加速器`vktap`+EAC),反复 KMODE(0x1E)蓝屏。**不是我们代码的错**(用户态只读脚本碰不到内核),但**大内存操作(VRChat 3.4GB + mmap 4GB dump)是压力诱因**。→ 命名/pipeline 全是纯计算不 mmap 大 dump,安全;**取完 dump 立即 taskkill VRChat 释放内存**;别同时 mmap dump + 开着游戏。
- 项目里有 `tools/bsod/`(NotMyFault + Complete dump + 34GB pagefile 配置),是历史抓内核 dump 用的,**这套配置让系统在高内存压力下更脆弱**,建议最终还原成安全态。
- **Workflow DSL 工具在本沙箱不可用**(模块格式报矛盾错)→ 直接用多个 Agent 并行调用做 fan-out,效果等同。
- **结构破解是串行迭代活**(每步发现决定下步),别撒 agent;**破解后的大规模命名/审计才适合 fan-out**。
- commit **零 AI 署名**(项目惯例);大派生文件(dump/precise_dump/deobfuscated_dump/name_mapping)走 gitignore;scratch/probe 脚本用完即删。
- **诚实验收**:每次报覆盖率必须跑 `compute_final_stats.py`,不自己造口径,不邀功。
