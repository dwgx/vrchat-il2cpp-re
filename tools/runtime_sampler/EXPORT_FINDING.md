# 决定性发现: GameAssembly.dll 导出表被剥离 — pure-bridge 不可直接用

工具: 主控直接 PE 导出表解析 (2026-06-29)

## 证据
- 导出表 RVA=0xcac2cc0, 共 **251 个导出**
- 其中 **il2cpp_* 只有 3 个**: `il2cpp_free`, `il2cpp_gchandle_get_target`, `il2cpp_native_stack_trace`
- 其余导出是随机混淆名 (ABOOGaFuykF, AEMdtrMwuxr, ...) — Beebyte/打包器剥离+重命名
- frida-il2cpp-bridge v0.13.1 **依赖** il2cpp_class_get_name / il2cpp_class_get_fields /
  il2cpp_field_get_name / il2cpp_object_get_class / il2cpp_domain_get_assemblies /
  il2cpp_gc_disable / il2cpp_capture_memory_snapshot —— **全部 ✗ 不导出**

## 结论 (A vs B 裁决的硬证据)
- **B (纯 bridge auto-detect) 走不通**: bridge 的 Module.getExportByName('GameAssembly.dll','il2cpp_*')
  会全部返回 null。bridge 无法初始化。
- bridge 仍可用的前提: 必须**手动定位**这些 il2cpp_* 函数的内部地址 (RVA) 并喂给 bridge,
  或用 bridge 的 `Il2Cpp.$config` / 手动 `Il2Cpp.initialize` 指针注入。工作量大。
- **A (混合) 是对的路**: gc.choose 仍可用 —— 但注意 il2cpp_gc 相关也没导出,所以连
  gc.choose 都需要先解决 bridge 初始化。这改变了架构: 实例枚举可能要回退到我们自己的
  堆扫描 (vrc_frida_lib.js findInstances, 不依赖任何导出),而非 bridge。

## 影响
A 方案的实例枚举应**双路**: (1) 优先尝试 bridge gc.choose; (2) 若 bridge 初始化失败
(导出缺失), 回退到 vrc_frida_lib.js 的对象头堆扫描 (纯内存扫描, 0 依赖导出)。
这恰好是"混合"的真正价值 —— 我们手搓的堆扫描在导出被剥离时反而更鲁棒。
