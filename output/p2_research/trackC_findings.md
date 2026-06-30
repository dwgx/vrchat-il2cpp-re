# Track C — 纯密码分析 jun26 global-metadata 加密(findings)

输入:`D:/Steam/steamapps/common/VRChat/VRChat_Data/il2cpp_data/Metadata/global-metadata.dat`
大小:40,512,432 字节 (0x26A2A30)。脚本:`trackC_cryptanalysis.py`(+本目录临时分析,已记录在下)。

---

## 结论速览(置信度)

1. **文件只有约 62% 被加密,约 38% 是明文。**【高,熵分析+strings 实测】
2. **所有类型名/方法名/字段名/字符串字面量都在明文区,不需要解密就能直接读。**【高,实测 9976 个 `ns|name` 标识符】
3. **加密区使用周期=256 字节的逐位置字节变换(与重复 XOR 一致),整文件同一把 body key。**【高,自相关+直方图不变性+前后半 key 100% 一致】
4. **header(前 264B)用的是和 body 不同的 keystream(两套密钥,印证 SHARED_CONTEXT 事实3)。**【高,共享密钥检验 0.2% 命中=失败】
5. **magic 确认 `0xFAB11BAF`;version 高位 nibble=d,但 24/27/29/31 全部自洽,纯密码分析无法定死具体版本。**【中,见下】
6. **body XOR key 无法仅靠统计恢复**——明文是 il2cpp 索引 int32 数组,每列有约 20% 占优字节但非 0/非定值,且全区找不到任何 ≥256B 的定值明文串(crib)。需要已知明文 crib 或二进制辅助才能拿到 body key。【高】

净效果:对"恢复方法名"这个总目标,**名字本身根本不用解密**;真正还需要解密的是开头加密区里的 *结构表*(MethodDefinition/TypeDefinition 等,含 nameIndex 与 token),而那需要一个 crib(Track B 的 DLL 或明文区交叉)才能撬开 body key。

---

## 攻击 1:已知明文扩展(header 结构约束)

- magic+version 已知明文 `AF 1B B1 FA <ver> 00 00 00`,恢复 header keystream:
  - `HK[0:8] = 5f 05 73 3b d1 b6 a8 bd`(d1 对应假设 version=29;见攻击4)
- 利用 il2cpp header = int32 (offset,size) 对、且 offset/size < 40MB ⇒ 每个 int32 的最高字节(file_off%4==3)=0x00,恢复 header keystream 在 MSB 列(c=3,7,…,263)的 64 个字节:
  ```
  3b bd b8 b7 b3 ad ab a4 a1 9d 99 94 91 8d 88 84 83 7d 79 74 71 6f 69 67
  63 5c 59 55 51 4f 49 45 41 3d 39 35 31 2f 29 24 21 1c 18 15 13 0f 08 07
  01 ff f9 f5 f1 ef e9 e5 e0 dd d9 d4 d0 cd c9 c7 c0 bc
  ```
- 仅拿到 1/4 的 header keystream 列(MSB),其余 3 列(LSB/中间字节)无已知明文约束,**无法读出 offset/size 的具体数值**,因此读不出 section 表。
- 结论:header 已知明文扩展只能恢复 25% 的 header keystream,**不足以解析 section 布局**。成:部分;卡点:缺中低字节 crib。

## 攻击 2:周期性检测(自相关)

- 对加密区 [0:0xA00000] 做 XOR-shift 零字节符合率:
  - lag=256 → 0.165;lag=512/768/1024 → 0.10~0.21(全是 256 的倍数尖峰)
  - lag=64 → 0.0005,lag=128 → 0.0001(**低于随机基线 0.0039**)
- 这是"周期=256 的逐位置密钥"的指纹:同位置(差 256 倍数)抵消出明文自相似;非整周期位移反而打散。
- **直方图不变性判定(决定性):** body 每列 256 个值的排序直方图形状几乎一致(rank0 相对标准差仅 **0.017**)。这说明每个位置施加的是固定字节变换、周期 256——与重复 XOR 完全一致。
- **key 跨区一致性:** 用列众数法在 [0:0x500000] 和 [0x500000:0xA00000] 各取一把 256B key,**逐字节 100% 相同(0 处不一致)**。⇒ 整个加密区同一把 256B 周期密钥。
- 结论:body = 周期 256 的重复 XOR(或等价的逐位置 S-box)。成。

## 攻击 3:结构化明文区(string literal 已知明文)

- 全文件直接 strings 命中(**未解密**):`UnityEngine` ×5165、`VRC` ×6649、`System.` ×895、`MonoBehaviour` ×11、`Transform` ×171、`mscorlib` ×7…
- 明文区 1 [0x1660000:0x1C60000](6.3MB):**48,370 个 ASCII 标识符,其中 9976 个是 il2cpp `namespace|name` 形式**。样例:
  `VRC.Purchasing|PurchasingManager`、`VRC.RemoteLogging|SentryTagManager`、
  `Photon.Realtime|ErrorInfo`、`VRC.Core|SubscriptionManager`、`VRC.Networking.Test|MockUdonBehaviour`…
  字符串字面量也在这里(URL、`Avatar.Wear`、`VRChat User` 等)。
- 明文区 2 [0x1E30000:0x26A0000](8.85MB):结构化 int32 索引表(明文,递增计数器肉眼可见)。
- 200 条样例已导出:`trackC_plaintext_names_sample.txt`。
- 结论:**名字区根本没加密**,已知明文攻击都不必做——直接读即可。成,且是本 track 最高价值发现。

## 攻击 4:版本确定

- cipher[4]=0xCC,pt[5:8]=0 已证实(给出 ks[5:8]=b6 a8 bd)。
- pt[4]=version=0xCC^ks4。对候选:
  | version | ks4 |
  |---|---|
  | 24 (0x18) | 0xd4 |
  | 27 (0x1b) | 0xd7 |
  | 29 (0x1d) | 0xd1 |
  | 31 (0x1f) | 0xd3 |
- SHARED_CONTEXT 给的 ks4="d?"(高位 d)对 0x10–0x1f 的任意 version 都成立(0xC^0x1=0xD),**无法区分**。
- 加密 header 的 section 表读不出(攻击1),也无法靠 header 大小(v29=264B vs v31=272B)区分,因为边界都在加密 blob 内不可观测。
- **纯密码分析无法定死版本。** 项目记忆有一条 "Unity6(6000.0.60f1)" 的 VRChat build —— 若 jun26 是 Unity 6,则 metadata version=**31**(ks4=0xd3);若是 Unity 2022.3 则=29(ks4=0xd1)。这需要 DLL/Il2CppDumper(Track B)定。本 track 仅能给:version ∈ {24,27,29,31},Unity6 线索偏向 31。置信度:中。

## 攻击 5:熵分析(加密边界)

- 4KB 分块熵,整文件均值 6.61。加密区熵 ~7.97(均匀),明文区 2.6~5.2。
- **分区图(64KB 粒度,阈值熵 7.5):**
  | 类型 | 范围 | 大小 |
  |---|---|---|
  | ENC | 0x00000000–0x00A00000 | 10.5MB |
  | ENC | 0x00A10000–0x01660000 | 12.9MB |
  | PLAIN(名字+字面量) | 0x01660000–0x01C60000 | 6.3MB |
  | ENC | 0x01C60000–0x01E30000 | 1.9MB |
  | PLAIN(索引表) | 0x01E30000–0x026A0000 | 8.85MB |
- 合计:加密 ~25.3MB(62.4%),明文 ~15.2MB(37.6%)。
- 结论:**部分加密**。开头连续 ~23MB 加密(含 header + 多数定义表),名字区与尾部索引表是明文。成。

---

## 为什么 body key 没被完全恢复(诚实卡点)

- 列众数法只能拿到 `K[c] ⊕ (该列占优明文字节)`。本加密区明文是 il2cpp 索引 int32 数组,每列确实有约 20% 占优字节(per-column max-freq 实测 0.195~0.210),但**那个占优字节不是 0、也不是跨列同一个常数**,所以减不掉。
- 用列众数 key 解密 body:熵只从 7.97 降到 ~7.23/6.5,无 ASCII 串,token 落在 0x02/0x06 区间的计数(5639/5075)低于随机期望(~9400),即**全是噪声**。
- 全加密区**没有任何 ≥256 字节的定值明文串**(0 个),拿不到直接 crib。
- 所以纯统计/纯结构约束到此为止:**要拿 body key,必须有一段加密区的已知明文**(例如 Track B 从 jun26 DLL 的 Il2CppCodeRegistration 推出某张表的内容,或某索引表跨明文/密文边界连续)。一旦有任意 256 字节连续已知明文,body key 立即全恢复,整个加密区随即解开。

---

## 可复现命令

```
cd D:/Project/vrchat-il2cpp-re/output/p2_research
python trackC_cryptanalysis.py basic      # magic/version/header keystream
python trackC_cryptanalysis.py entropy     # 分区/边界
python trackC_cryptanalysis.py autocorr    # 周期 256 检测
python trackC_cryptanalysis.py period       # 周期密钥列检验
```

## 给主控的建议(下一步)

- **马上能用:** 名字区(0x1660000–0x1C60000)是明文,9976 个 `ns|name` 直接可作命名词典,无需解密。
- **撬开结构表:** 给 Track C 喂一段加密区已知明文(Track B 从 DLL 推一张表,或找一张跨边界的索引表),body 的 256B 周期 key 即可一次性恢复 → 解开全部 25MB 加密区 → 拿到 MethodDefinition 的 nameIndex/token,补全 VA→name。
- **版本:** 用 Il2CppDumper/DLL 定死 29 vs 31(影响 header 结构体大小与字段偏移)。
