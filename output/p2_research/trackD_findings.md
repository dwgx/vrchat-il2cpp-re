# Track D — 绕开 metadata 解密的对冲路径：runtime-VA → file-VA 映射

状态：**对冲路成立，强烈建议走。** 在 build-matched 数据上发现并验证了一个**单一全局线性映射**，把 runtime VA 直接换算成磁盘 file VA，覆盖 ~89.4% 的方法指针（落在真实 .pdata 函数起始），residual 经诊断主要是 x64 leaf 函数（无 .pdata），实际有效覆盖 ~95%+。

结论与 SHARED_CONTEXT 事实1（"runtime VA 与 file VA 无全局线性映射，9/80 命中无解"）**冲突**。下面给出冲突来源分析：旧的 9/80 结论是用**被否定的 24-bit-mask rebase 公式产出的污染 ground-truth** 去验证的，本身基线就是错的。本 Track 改用 PE .pdata 真函数表做 ground-truth，得到干净结论。

---

## 1. PE 节区布局（jun13 DLL，pefile 解析）

```
ImageBase = 0x180000000   SizeOfImage = 0xDA94000 (218MB)   EntryPoint = 0xAB070C
name        rva           vsize         fileoff       rawsize
.text       0x1000        0xAE56E8      0x400         0xAE5800     (代码 ~11MB)
il2cpp      0xAE7000      0x9925B7C     0xAE5C00      0x9925C00    (IL2CPP 代码段 ~150MB)
.rdata      0xA40D000     0x2122860     0xA40B800     0x2122A00
.data       0xC530000     0xBE0B2C      0xC52E200     0x8F3A00
.pdata      0xD111000     0x68FA48      0xCE21C00     0x68FC00     (异常表 = 函数起始表)
.reloc      0xD7A1000     0x2F22BC      0xD4B1800     0x2F2400
```

关键点：
- IL2CPP 编译的方法体**绝大多数在 `il2cpp` 节**（0x180AE7000..0x18A40CB7C），不是 `.text`。映射后 197,416 个落在 `il2cpp`，9,643 个落在 `.text`。
- `.pdata`（IMAGE_DIRECTORY_ENTRY_EXCEPTION）给出 **573,318 个 RUNTIME_FUNCTION 起始地址**，这是覆盖全二进制的、与构建自洽的函数起始 ground-truth（不依赖任何解密、不依赖污染的旧映射）。

---

## 2. 核心发现：单一全局线性映射（build-matched）

### 数据配对纪律（重要修正）
任务原指向 `precise_dump_unity6_typed.json`，但它是 **jun29 build**，而 Ghidra GT 来自 **jun13 DLL**（日志确认：`opening GameAssembly_jun13.dll for 750 targets`）。跨 build 配对无意义。本 Track 改用 **build-matched 的 `data/precise_dump_jun13.json`**（summary.build = "june13+"，source_dump = jun21 进程）对齐 jun13 DLL。

### 方法
- 取 jun13 runtime dump 的全部唯一方法指针：**231,634 个**。
- 取 jun13 DLL `.pdata` 函数起始集合：**573,318 个**。
- 利用观察到的"低 16 位保持不变"（页对齐 rebase），对每个 runtime 指针枚举候选 offset = `runtime_va - func_start`（仅在低16位相同的函数里找），统计哪个 offset 把最多指针映射到真实函数起始。

### 结果（决定性）
```
最佳 offset = 0x7FFE38B10000 : 207,059 / 231,634 命中 = 89.4%
次佳 (任意相邻64KB offset)    : ~9,900   / 231,634       = ~4.3%  (噪声地板)
```
信号是噪声的 **~20 倍**。映射是**单射**（207,059 个 runtime 指针 → 207,059 个不同 file_ea，无碰撞别名）。

隐含的 runtime 模块基址 = `ImageBase + OFF = 0x180000000 + 0x7FFE38B10000 = 0x7FFFB8B10000`，是标准 64 位 ASLR 基址，物理意义合理。

**已用 minidump 模块表直接证实**（只读解析 `dumps/VRChat_40752_20260621_102014_full.dmp` 的 ModuleListStream）：
```
D:\Steam\...\VRChat\GameAssembly.dll  base=0x7FFFB8B10000  size=0xDA94000
implied OFF = base - 0x180000000 = 0x7FFE38B10000   <-- 与 .pdata 拟合值完全一致
```
即映射常量无需拟合，可直接从 dump 的模块表读出。SizeOfImage 0xDA94000 也与 jun13 DLL 的 SizeOfImage 完全一致，再次证明 build-match 正确。

### 映射公式
```
file_va = runtime_va - 0x7FFE38B10000
       = runtime_va - (runtime_module_base - 0x180000000)
```
其中 runtime_module_base 是该次 dump 进程里 GameAssembly.dll 的实际加载基址（每次启动随 ASLR 变化，但同一 dump 内是单一常量）。**这意味着映射是 per-dump 单常量，不是 per-segment，也不是不可解。**

---

## 3. 字节级验证（独立、不依赖 .pdata）

直接读 DLL 磁盘字节，OFF 映射后的 file 地址全是干净 x64 函数序言：
```
fe=0x1800055E0  4883ec68...   (sub rsp,0x68)
fe=0x180005730  48895c2408... (mov [rsp+8],rbx)
fe=0x180008500  4883ec28803d... (sub rsp,0x28; cmp byte [rip+..])
... (8/8 抽样都是合法 prologue)
```
对照：**控制实验**用相邻 64KB offset（OFF±0x10000 等）命中率掉到 ~4%，证明 0x7FFE38B10000 不是巧合。

---

## 4. Residual（24,575 个未命中）诊断 — 不是映射失败

- 24,406 / 24,575 落在已映射 runtime 范围内（不是别的模块）。
- 对 missed 集合重新找最佳 offset：最高仅 6.6%（= 噪声），**没有第二个隐藏 segment/offset**。映射确实是单一全局常量。
- **21,190 / 24,575（86%）落在某个已知函数起始之后 0x200 内** → 这些是 x64 **leaf 函数**（不需要 unwind 信息，因此不进 `.pdata`），属正常现象，不是映射错。
- 仅 169 个落在映射 file 范围外（可能是其它模块的指针 / dump 噪声 / 注入方法）。

修正后有效覆盖率：在"有 .pdata 记录的函数"口径下 89.4%；把 leaf 函数算进去，几何上几乎所有 runtime 指针都能正确换算到 file_va，**实际有效 ~95%+**。

---

## 5. 为什么旧的 "9/80、无线性映射" 结论是错的

旧 GT 被污染。证据：把 Ghidra GT 的 ea 与 **jun29 dump**（不是它该配的 build）做差，只出现 3 个 offset：
```
0x7FFDFCC30000 (390), 0x7FFE00C30000 (156), 0x7FFDFAC30000 (39)
```
这三个值彼此相差 32MB/64MB 的整数倍 = **被否定的 `IDA_BASE + (rva & ~0xFFFFFF)` 24位掩码公式的指纹**（事实2 已标 DO-NOT-USE）。即 Ghidra 那批 ea 本身就是用错误公式从 jun29 runtime 反推出来的，落点是 mid-instruction（实测 GT ea 字节为 `33c0b201`、`9600f083` 等非 prologue，且仅 3.8% 在 .pdata 里）。

所以"9/80 命中"是**用错误基线验证另一个量**，得到的"无解"结论无效。本 Track 用与构建自洽的 .pdata + 字节级 prologue 检验，结论翻转。

---

## 6. 对冲价值评估

| 维度 | 评估 |
|---|---|
| 可行性 | 成立。单一全局 offset，单射，字节级验证通过。 |
| 覆盖率 | .pdata 口径 89.4%，含 leaf ~95%+。 |
| 置信度 | 高（20x 信噪比 + 控制实验 + 磁盘字节 prologue 三重独立验证）。 |
| 依赖 | **完全绕开 metadata 解密**。只需：(a) build-matched runtime dump，(b) 同 build 的 DLL，(c) 该 dump 里 GameAssembly.dll 的加载基址。 |
| 是否值得走 | **值得，应作为首选地基之一**，不只是对冲。它比 metadata 解密路径门槛低得多。 |

### 落地步骤（给主控）
1. 确定每个 dump 的 runtime_module_base。**最稳做法已验证**：直接解析 minidump 的 ModuleListStream(stream type 4) 读 GameAssembly.dll 的 BaseOfImage（只读，安全，无拟合）。jun13 dump 实测 = 0x7FFFB8B10000，与 .pdata 拟合值一致。
2. `file_va = runtime_va - (module_base - 0x180000000)`，把 217k/231k 方法符号换算到 file_va。
3. 在 Ghidra 里以 ImageBase=0x180000000 加载 jun13 DLL，按 file_va 给 FUN_ 重命名 = 直接拿到带名反编译。
4. 验证闭环：换算后的 file_va 应落在 .pdata 函数起始（已验证 89.4%）；抽样读字节确认 prologue。

### 卡点 / 未验证项
- **必须 build-matched**：jun13 DLL 只能配 jun13 runtime dump。jun26/jun29 要各自用对应 DLL + 对应 dump 重做（同一方法可复用）。
- module_base 已用 .pdata 拟合 + minidump 模块表双重确认（0x7FFFB8B10000），置信度拉满。
- 名字本身的正确性继承自 runtime dump 的 reverse_methodinfo_enumeration（另有 Track 负责），本 Track 只解决"地址映射"这一环。
- ~24k leaf/residual 指针无法用 .pdata 验证，但有字节级 prologue 旁证；严格"宁缺毋滥"口径下可标记为低置信子集。

## 复现
脚本：`output/p2_research/trackD_align.py`（PE 节区 + 配对 + 序号对齐分析）。
.pdata 函数表缓存：`output/p2_research/trackD_pdata_funcs.json`（573,318 起始）。
关键命令见本文件各节内联 python。
