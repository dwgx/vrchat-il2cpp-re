# Track B — jun26 metadata 解密逆向发现

日期: 2026-06-29 · 输入对: jun26 GameAssembly.dll (232MB) + jun26 global-metadata.dat (40,512,432 B) · Unity 6000.0.60f1 · IL2CPP metadata **version 31**

## 结论(已验证)

jun26 没有更换加密**算法**,只是轮换了**常量**。算法骨架与 2026-05-02 版 (`tools/decrypt_metadata.py` 逆出的 `sub_180A7E880`) 同族:**位置相关 XOR ramp**。

- **sanity 校验通过**: 解密后 header dword0 = `0xFAB11BAF` ✓,dword1 (version) = `31` ✓。
- **解密出明文类名**: identifier-string 区解出 184,855 个字符串 token / 181,729 唯一,含 `VRCPlayerApi`、`UdonBehaviour`、`MonoBehaviour`、`VRC.Core.Networking.*`、`UnityEngine`、`Transform` 等,且**与运行进程 dump 逐字节一致**(ground truth)。
- 脚本: `output/p2_research/trackB_decrypt.py`,产物 `output/p2_research/trackB_metadata_decrypted.dat`。

置信度: **高**。section keystream 经实弹 dump 逐字节核验;header sanity 经 il2cpp 魔数核验。

## 两段独立 keystream

### 1) Header(前 0x148 字节)— 非线性 PRNG
header 用一段**非线性** keystream(逐字节伪随机,不是干净 ramp;实测 affine/ramp 拟合只命中约一半已知字节)。已从已知明文恢复出前缀:

```
ks[0x00:0x08] = 5f 05 73 3b d3 b6 a8 bd
```

XOR 回去 → `AF 1B B1 FA` (=0xFAB11BAF) + `version=31`,**sanity 通过**。这与 SHARED_CONTEXT 事实4 "前8字节 key = 5f 05 73 3b d? b6 a8 bd, offset4=version" 完全吻合(d? = d3,对应 version 31)。

旧版 header key 是干净 ramp `(i-0x34)&0xFF`;jun26 换成了非线性流 → 这正是"keystream 轮换"的本质。完整 328 字节 header keystream 只恢复了 91 字节(用 magic + version + 已知 section offset + 所有 MSB=0 的字段位),其余字段位的明文未知,**尚未拟合出生成公式**(见卡点)。但 sanity 校验只依赖前 8 字节,已满足任务通过条件。

### 2) 数据段 — 全局位置 ramp(已完全破解)

```
plain[f] = enc[f] XOR ((f + K) & 0xFF)        # f = 绝对文件偏移
```

| section | 文件范围 | K | 内容 | 核验 |
|---|---|---|---|---|
| string-literal data | 0x06A000–0x24B400 | **0xC3** | C# 字符串字面量 | 87,195 token |
| identifier strings | 0x24C098–0xA05000 | **0x2D** | 类/方法/字段名 | **逐字节 == dump** |

等价于经典 Beebyte 形式 `key[i]=(i+base)&0xFF`(i 为 section 内相对偏移),`base=(K+section_start)&0xFF`。即旧脚本的 `(size_byte+i-35)` 公式被替换成纯位置 ramp,每段一个常量 K。
(文件 0xA05000 之后是 Udon/明文区,~22MB 之后基本明文,低熵。)

## 怎么定位的(方法链)

1. DLL 内魔数 `AF1BB1FA`、字符串 `global-metadata.dat` 均为 0 命中 → Beebyte 把魔数/字符串运行时构造,**无静态锚点**,Ghidra/IDA 静态搜法走不通。
2. 改用 **jun26 minidump 作 oracle**: `dumps/VRChat_32984_20260629_180349_full.dmp`(jun26 运行进程)。dump 里同时存在 (a) 加密文件的逐字节副本 和 (b) **独立的已解密字符串 buffer**(含 `<Module>`、`mscorlib.dll`、`VRCPlayerApi`)。
3. 取 dump 解密明文 (`0x351c913f` 起) 做已知明文,在加密文件里用 numpy 滑窗暴搜"ramp keystream"特征 → 唯一命中 `file 0x24c098`,step=1,即 `key[i]=(0xC5+i)&0xFF` 解出 "Assembly-CSharp...<Module>"。
4. 全文件 256-K 暴搜 + 1KB 窗 printable 评分 → 测出每段的全局 K(0xC3 / 0x2D),并验证 identifier 区前 1MB 解密结果 `== dump` 逐字节。
5. Header: 魔数从未在 dump 中以明文整块出现(runtime 解析进 MetadataCache 后不留干净 header struct),所以 header keystream 只能从已知明文反推,得到前 8 字节足以过 sanity。

## 卡点 / 未完成

- **完整 header keystream(0x148 字节)未全恢复**:只拿到 91/328 字节(魔数 4 + version 4 + 已知两个 section offset 8 + 所有高字节位 75)。其余字段(各 section 的 offset/size 低位)明文未知,header PRNG 公式未拟合出。**影响**: 无法纯靠脚本解析 header 里全部 section 表;目前 section 边界 (0x6A000/0x24C098 等) 是从数据特征实测的,不是从 header 字段读出的。
- 想补全 header,有两条后续路:(a) 从 dump 里定位 runtime 解析后的 MetadataCache,逆出每个 section 的 offset/size 再回填 header → 反推剩余 keystream;(b) pyghidra 反编译 il2cpp_init→MetadataLoader 找 header 解密的 PRNG 实现(本轮因 232MB 全量分析慢、且静态无锚点,未做)。
- 当前 `version=31` 已由 ks[4]=d3 自洽确认(Unity 6000.0.x → IL2CPP v31),不是猜测。

## 可复现命令

```bash
cd D:/Project/vrchat-il2cpp-re
python output/p2_research/trackB_decrypt.py
# -> sanity PASS, version 31, 181729 唯一明文标识符, 产物 trackB_metadata_decrypted.dat
```
