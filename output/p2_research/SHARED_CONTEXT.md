# P2 元数据解密 — 共享事实基线(所有 agent 必读)

## 目标
为 VRChat IL2CPP 静态符号恢复扫清地基:拿到 GameAssembly.dll 里每个方法的**正确 file-VA(磁盘 PE 地址)→ 真实方法名**映射。这是反编译伪代码可命名化的硬前提。

## 已确认的事实(不要重新验证,直接用)
1. 现有所有 dump(precise_dump*.json, precise_dump.cs, deobfuscated_dump.json)都是**扫活进程内存**得到的 **runtime VA(0x7FFF... / 0x7FFA...)**,与磁盘 PE 的 file VA(0x180...)**无线性映射**(已用 Ghidra ground-truth FUN_ 地址暴力细扫验证:9/80 命中,无解)。
2. 旧 rebase 公式 `IDA_BASE + (rva & ~0xFFFFFF)` 是错的(24位掩码 vs 220MB 代码段,9% 碰撞别名)。tools/resolve_symbols.py 已标记 DO-NOT-USE。
3. 旧解密器 tools/decrypt_metadata.py 是从 **2026-05-02** 版 DLL 的 sub_180A7E880 逆出的,header key = `(i-0x34)&0xFF`,section 用两种 keystream。**对 jun26 metadata 失效**(sanity 0x0E0CD33C ≠ 0xFAB11BAF)。
4. jun26 global-metadata 的 keystream 已知明文恢复:前8字节 key = `5f 05 73 3b d? b6 a8 bd`(offset4=version),**无简单位置线性规律**——加密方案在 jun26 轮换了。
5. il2cpp metadata 合法魔数 = `0xFAB11BAF`(小端 `AF 1B B1 FA`),version 紧随其后(候选 24/27/29/31)。

## 版本矩阵(关键!)
- `dumps/GameAssembly_jun13.dll`(226MB)+ `dumps/GameAssembly_jun05.dll`(+.i64+.asm 分析)
- Steam 当前安装:`D:/Steam/steamapps/common/VRChat/GameAssembly.dll`(jun26, 232MB)+ `D:/Steam/.../Metadata/global-metadata.dat`(jun26, 40.5MB 加密)
- **自洽配对 = jun26 DLL + jun26 metadata**(同一次安装,加密 key 必然匹配)

## 工具站
- Il2CppDumper v6.7.46 net6: `D:/Tool/debugger/Unpackers-Game/Il2CppDumper-net6-win-v6.7.46/Il2CppDumper.exe`(自带 ghidra.py / il2cpp_header_to_ghidra.py)
- Ghidra 12.1.2: `D:/Tool/debugger/Static-Reversing/Ghidra/ghidra_12.1.2_PUBLIC`,pyghidra 3.1.0 已装,GHIDRA_INSTALL_DIR 同路径
- pyghidra 反编译器已验证可用:tools/pyghidra_decompile.py
- IDA: 工具站无 IDA,但有 jun05 的 .i64/.asm(IDA 已分析过的产物可读)

## 铁律
- 严守宁缺毋滥:任何符号映射必须能验证正确(用魔数/已知明文/交叉核对),不可信的不要产出。
- 只读你负责的输入,只写你自己的输出文件。不碰别的 track 的文件,不改 tools/ 下现有脚本(新脚本写到你的目录)。
- 把发现写成结构化 markdown,包含:结论、证据、可复现的命令/代码、置信度、卡点。

## ★更新(突破): 地基已通过 Track D 解决 — metadata 解密不再是关键路径
Track D 发现并经主控独立复现确认: `file_va = runtime_va - (minidump模块base - 0x180000000)`,
jun13 build 命中 89.4% .pdata 真函数起始(信噪比20x),三重独立验证通过。
**必须 build-matched**: jun13 DLL ↔ precise_dump_jun13.json ↔ jun13 dump 的模块base。
若你(Track A/B/C)还在跑: metadata 解密现在是"锦上添花"而非必需。Track B 若能逆出 jun26
解密仍有价值(可拿到 jun26 自洽的更全符号 + il2cpp.h 结构体),但不阻塞 P2。
