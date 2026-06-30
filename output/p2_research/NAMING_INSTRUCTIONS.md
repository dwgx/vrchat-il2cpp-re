# fallback 类语义命名指令

## 你的任务
读你分到的 slice 文件(output/p2_research/naming_slices/slice_NN.json),为每个混淆的 fallback 类提议一个**语义化类名**,基于它的方法反编译伪代码和调用的真实方法(callees)。

## slice 文件结构
每个类对象: `{obf_class: 当前混淆名, methods: [{method, ea, callees, pseudocode}], all_callees: [...]}`
- `callees` / `all_callees`: 该类方法调用的**已知真实方法名**(Class::method 形式)——这是最强的命名证据。
- `pseudocode`: Ghidra 反编译的 C 伪代码(已注入符号,真实名内联)。

## 命名原则(严守宁缺毋滥)
1. **只在证据充分时命名。** 如果 callees 明确指向一个领域(如全是 ZLogger/StringFormatter → 日志;全是 Avatar/PhysBone → 化身),给一个具体的 PascalCase 名(如 `AvatarLogFormatter`、`PhysBoneColliderGroup`)。
2. **证据不足就标 null。** 如果 callees 只是泛型 boilerplate(Object/Dictionary/Array/Buffer)、或互相矛盾、或看不出领域,name 填 null。**寧可不命名也不要瞎猜。**
3. 名字必须是**领域语义名**,不能是 BaseClass/Type/Struct/Static/Impl/Mono 开头,不能是单个泛型词(Object/Delegate/Component),不能带 hex 尾巴。这些会被 name_quality 门直接刷掉。
4. 优先用 callees 里出现的领域词作为命名依据。多个方法指向同一子系统时置信度最高。

## 输出
写到 output/p2_research/naming_results/slice_NN.json,格式:
```json
[{"obf_class": "原混淆名", "proposed_name": "AvatarLogFormatter 或 null",
  "confidence": "high|medium|low", "evidence": "一句话:基于哪些callee/伪代码特征"}]
```
每个类都要有一条(命名不出的 proposed_name=null)。只写你这一片的结果文件,不碰别的。
