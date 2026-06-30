# Track A 发现 — Il2CppDumper v6.7.46 能否自动处理 jun26 VRChat

日期: 2026-06-29 (运行日 2026-06-30)
负责人: Track A agent
结论一句话: **不通**。Il2CppDumper v6.7.46 对 jun26 加密 metadata 直接失败，且无任何内建解密/绕过校验能力。这确认了"必须先离线解密 metadata"这一前提。

---

## 1. 输入(自洽配对，jun26 同一次安装)

| 文件 | 路径 | 大小 | mtime |
|---|---|---|---|
| GameAssembly.dll | `D:/Steam/steamapps/common/VRChat/GameAssembly.dll` | 232,778,240 (232MB) | Jun 26 15:40 |
| global-metadata.dat | `D:/Steam/.../il2cpp_data/Metadata/global-metadata.dat` | 40,512,432 (40.5MB) | Jun 26 15:40 |

metadata 前 32 字节(加密态):
```
00000000: f01e c2c1 ccb6 a8bd 845c 5cb8 885b b5b7
00000010: 3c82 d4b3 e0c2 a8ad fc3f 91ab b8ed 20a4
```
- 实际魔数 = `f0 1e c2 c1`(小端读 0xC1C21EF0)
- 合法 IL2CPP 魔数 = `AF 1B B1 FA`(0xFAB11BAF)
- 不匹配 → metadata 确为加密态(与 SHARED_CONTEXT 事实 #3/#5 一致)

## 2. 工具

- `D:/Tool/debugger/Unpackers-Game/Il2CppDumper-net6-win-v6.7.46/Il2CppDumper.exe`(13.4MB, .NET6, 2024-07-06)
- 同目录另有 x86 版与 ghidra/ida 脚本，无 README/txt，无 VRChat/Beebyte 专用插件。

### config.json 全部选项(默认值)
```json
{
  "DumpMethod": true, "DumpField": true, "DumpProperty": true,
  "DumpAttribute": true, "DumpFieldOffset": true, "DumpMethodOffset": true,
  "DumpTypeDefIndex": true, "GenerateDummyDll": true, "GenerateStruct": true,
  "DummyDllAddToken": true, "RequireAnyKey": true,
  "ForceIl2CppVersion": false, "ForceVersion": 16,
  "ForceDump": false, "NoRedirectedPointer": false
}
```
关键: 没有任何 "解密 metadata"、"key"、"brute-force" 选项。`ForceIl2CppVersion`/`ForceVersion` 只在魔数校验**通过后**强制 IL2CPP 结构版本号，`ForceDump` 只在已能解析的前提下强行 dump。三者都无法越过 metadata 魔数校验。

## 3. 尝试的所有命令与结果

### Run 1 — 默认 config，标准三参用法
命令(Git Bash，工作目录 = dumper 目录):
```
echo "" | ./Il2CppDumper.exe \
  "D:/Steam/steamapps/common/VRChat/GameAssembly.dll" \
  "D:/Steam/.../Metadata/global-metadata.dat" \
  "D:/Project/vrchat-il2cpp-re/output/p2_research/trackA_out"
```
输出(确切报错):
```
ERROR: Metadata file not found or encrypted.
Press any key to exit...
Unhandled exception. System.InvalidOperationException: Cannot read keys when ...
   at Il2CppDumper.Program.Main(String[] args) in C:\projects\il2cppdumper\Il2CppDumper\Program.cs:line 109
```
- 实际错误 = `ERROR: Metadata file not found or encrypted.`(注: v6.7.46 把魔数失败的提示合并成 "not found or encrypted"，等价于旧版 "Metadata file supplied is not valid"，含义相同：魔数校验失败)
- 末尾的 InvalidOperationException 只是因为 `RequireAnyKey:true` 又被管道重定向 stdin 触发 Console.ReadKey 崩溃，与解密无关。
- trackA_out 空，无任何产物。

### Run 2 — 强制版本 + ForceDump + 关 RequireAnyKey
临时改 config(跑完已还原为默认): `ForceIl2CppVersion:true, ForceVersion:29, ForceDump:true, RequireAnyKey:false`
```
./Il2CppDumper.exe <dll> <metadata> <trackA_out>
```
输出:
```
ERROR: Metadata file not found or encrypted.
```
- 在魔数校验阶段就退出，强制版本/ForceDump 完全没机会生效。证明 **没有任何 config 开关能绕过 metadata 魔数校验**。
- config.json 已确认还原为原始默认值(ForceIl2CppVersion:false / ForceVersion:16 / ForceDump:false / RequireAnyKey:true)。

## 4. Il2CppInspector 搜索

```
find D:/Tool -iname "*Il2CppInspector*"   → 无结果
find D:/Tool -iname "*il2cpp*"            → 仅 Il2CppDumper(net6/win 两套 + zip + staging 副本)
```
**工具站没有 Il2CppInspector**。如果后续要走"工具自带 brute-force key 搜索"路线，需要先获取 Il2CppInspector(它有针对加密/混淆 metadata 的 search/brute-force 功能)，但本机当前不可用。

## 5. 置信度结论

| 判断 | 置信度 | 依据 |
|---|---|---|
| Il2CppDumper v6.7.46 无法处理 jun26 加密 metadata | 高(已实测两次) | 两种 config 均在魔数校验阶段报 "not found or encrypted" |
| 无 config 开关可绕过魔数校验 | 高(实测) | ForceVersion/ForceDump 均在校验后才生效 |
| Il2CppDumper 无内建 VRChat/Beebyte 解密 | 高 | 无相关插件/选项/README，net6 公版 |
| 工具站无 Il2CppInspector | 高 | find 全盘无结果 |

**这条路通不通: 不通。** 但这是有价值的负面结论——它把问题钉死在"必须先离线把 jun26 global-metadata 解密成魔数 0xFAB11BAF 的明文文件，再喂给 Il2CppDumper"。Il2CppDumper 本身在解密完成后仍是可用的下游工具(它能正常解析合法 metadata 并产出 dump.cs/DummyDll/struct)，只是它**不负责解密**。

## 6. 下一步建议(供主线/其他 track 参考，本 track 不执行)

1. jun26 解密必须自己做(SHARED_CONTEXT 事实 #4: jun26 keystream 已知明文前 8 字节 `5f 05 73 3b d? b6 a8 bd`，但无线性规律，需从 jun26 DLL 的解密函数重新逆向，类似旧 sub_180A7E880 路线)。
2. 解密成功的验证标准: 输出文件前 4 字节 == `AF 1B B1 FA`，紧随合法 version(24/27/29/31)。
3. 拿到明文 metadata 后，可直接用本 track 验证过的命令喂回 Il2CppDumper(默认 config 即可)产出符号。
4. 若要走工具自动 brute-force 路线，需先引入 Il2CppInspector(本机当前没有)。

## 附: 未做/边界声明
- 未运行 VRChat 游戏；只用磁盘静态文件。
- 只写了 trackA_findings.md 与 trackA_out/(空)；config.json 临时改动已还原。
- 未触碰其他 track 文件、未改 tools/ 下脚本。
