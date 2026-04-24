// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 65
// Methods: 585

public class WIN32_FILE_ATTRIBUTE_DATA : ValueType
{
    // ── Methods ──
    public void PopulateFrom(){} // RVA: 0x7FFD537AA420
}

public class WaitAsyncSource : Object
{
    public ileFullDirectoryInformation<object> Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.NextNode;
    public eObjectDelegate.ion<essor<T1717653680>> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev;
    public essor<T1717653680> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next;
    public eObjectDelegate.onPropertyInfo<T1717653680> parent;
    public sageKind.TICMAP_SIZE cancellationToken;
    public sageKind.sition cancellationTokenRegistration;
    public eObjectDelegate.ataProperty>k__BackingField<T1717653680> core;
    public eObjectDelegate.eationHandlingForProperty<T1717653680> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField;
    public eObjectDelegate.eationHandlingForProperty<T1717653680> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField;

    // ── Methods ──
    public void Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AsyncReactiveProperty<T>.WaitAsyncSource>.get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){}
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
    public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void OnCompleted(){} // RVA: 0x7FFD4E090980 | overloaded x2
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7FFD4E078E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7FFD4E090A40
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7FFD4E078E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7FFD4E090A40
    public void OnCanceled(){} // RVA: 0x7FFD4E090BF0
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
}

public class WaitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53AEAE10
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
}

public class WaitForEndOfFramePromise : Object
{
    public eObjectDelegate.ion<sOverriddenOrShadowedBy> NextNode;
    public sOverriddenOrShadowedBy System.Collections.IEnumerator.Current; // 0x10
    public eObjectDelegate.ataProperty>k__BackingField<object> core; // 0x18
    public sageKind.TICMAP_SIZE cancellationToken; // 0x40
    public sageKind.sition cancellationTokenRegistration; // 0x48
    public bool cancelImmediately; // 0x60
    public s waitForEndOfFrameYieldInstruction; // 0x10
    public bool isFirst; // 0x61

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548AD700
    public void .ctor(){} // RVA: 0x7FFD548AD910
    public void Create(){} // RVA: 0x7FFD548AD920
    public void GetResult(){} // RVA: 0x7FFD548ADC80
    public void GetStatus(){} // RVA: 0x7FFD548ADE20
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548ADE70
    public void OnCompleted(){} // RVA: 0x7FFD548ADEB0
    public void TryReturn(){} // RVA: 0x7FFD548ADF30
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD548ADFE0
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFD548AE040
    public void Reset(){} // RVA: 0x7FFD548AD910
}

public class WaitForLastPresentationAndUpdateTime : ValueType
{
}

public class WaitUntilCanceledPromise : Object
{
    public eObjectDelegate.ion<kingField> NextNode;
    public kingField nextNode; // 0x10
    public sageKind.TICMAP_SIZE cancellationToken; // 0x18
    public sageKind.sition cancellationTokenRegistration; // 0x20
    public bool cancelImmediately; // 0x38
    public eObjectDelegate.ataProperty>k__BackingField<object> core; // 0x40

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548B3020
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548B31A0
    public void GetResult(){} // RVA: 0x7FFD548B3520
    public void GetStatus(){} // RVA: 0x7FFD548B36C0
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B3710
    public void OnCompleted(){} // RVA: 0x7FFD548B3750
    public void MoveNext(){} // RVA: 0x7FFD548B37D0
    public void TryReturn(){} // RVA: 0x7FFD548B3860
}

public class WaitUntilPromise : Object
{
    public eObjectDelegate.ion<ngField> NextNode;
    public ngField nextNode; // 0x10
    public ormation<bool> predicate; // 0x18
    public sageKind.TICMAP_SIZE cancellationToken; // 0x20
    public sageKind.sition cancellationTokenRegistration; // 0x28
    public bool cancelImmediately; // 0x40
    public eObjectDelegate.ataProperty>k__BackingField<object> core; // 0x48

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548B17E0
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548B1960
    public void GetResult(){} // RVA: 0x7FFD548B1D60
    public void GetStatus(){} // RVA: 0x7FFD548B1F50
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B1FA0
    public void OnCompleted(){} // RVA: 0x7FFD548B1FE0
    public void MoveNext(){} // RVA: 0x7FFD548B2060
    public void TryReturn(){} // RVA: 0x7FFD548B2170
}

public class WaitUntilPromise`1 : Object
{
    public eObjectDelegate.ion<ured>k__BackingField<T1717659296>> NextNode;
    public ured>k__BackingField<T1717659296> nextNode;
    public n<T1717659296,bool> predicate;
    public T1717659296 argument;
    public sageKind.TICMAP_SIZE cancellationToken;
    public sageKind.sition cancellationTokenRegistration;
    public bool cancelImmediately;
    public eObjectDelegate.ataProperty>k__BackingField<object> core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
}

public class WaitUntilValueChangedStandardObjectPromise`2 : Object
{
    public eObjectDelegate.ion<rialize>k__BackingField<T1717659440,T1717659456>> NextNode;
    public rialize>k__BackingField<T1717659440,T1717659456> nextNode;
    public numValuesAndNames<T1717659440> target;
    public T1717659456 currentValue;
    public n<T1717659440,T1717659456> monitorFunction;
    public URA.hEraNames<T1717659456> equalityComparer;
    public sageKind.TICMAP_SIZE cancellationToken;
    public sageKind.sition cancellationTokenRegistration;
    public bool cancelImmediately;
    public eObjectDelegate.ataProperty>k__BackingField<T1717659456> core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
}

public class WaitUntilValueChangedUnityObjectPromise`2 : Object
{
    public eObjectDelegate.ion<k__BackingField<T1717659376,T1717659392>> NextNode;
    public k__BackingField<T1717659376,T1717659392> nextNode;
    public T1717659376 target;
    public object targetAsUnityObject;
    public T1717659392 currentValue;
    public n<T1717659376,T1717659392> monitorFunction;
    public URA.hEraNames<T1717659392> equalityComparer;
    public sageKind.TICMAP_SIZE cancellationToken;
    public sageKind.sition cancellationTokenRegistration;
    public bool cancelImmediately;
    public eObjectDelegate.ataProperty>k__BackingField<T1717659392> core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
}

public class WaitWhilePromise : Object
{
    public eObjectDelegate.ion<d> NextNode;
    public d nextNode; // 0x10
    public ormation<bool> predicate; // 0x18
    public sageKind.TICMAP_SIZE cancellationToken; // 0x20
    public sageKind.sition cancellationTokenRegistration; // 0x28
    public bool cancelImmediately; // 0x40
    public eObjectDelegate.ataProperty>k__BackingField<object> core; // 0x48

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548B2400
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548B2580
    public void GetResult(){} // RVA: 0x7FFD548B2980
    public void GetStatus(){} // RVA: 0x7FFD548B2B70
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B2BC0
    public void OnCompleted(){} // RVA: 0x7FFD548B2C00
    public void MoveNext(){} // RVA: 0x7FFD548B2C80
    public void TryReturn(){} // RVA: 0x7FFD548B2D90
}

public class WaitWhilePromise`1 : Object
{
    public eObjectDelegate.ion<aluesOnWrite>k__BackingField<T1717659328>> NextNode;
    public aluesOnWrite>k__BackingField<T1717659328> nextNode;
    public n<T1717659328,bool> predicate;
    public T1717659328 argument;
    public sageKind.TICMAP_SIZE cancellationToken;
    public sageKind.sition cancellationTokenRegistration;
    public bool cancelImmediately;
    public eObjectDelegate.ataProperty>k__BackingField<object> core;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void TryReturn(){} // RVA: 0x7FFD4E079D00
}

public class Waypoint : ValueType
{
    public amut position; // 0x10
    public float roll; // 0x1C
}

public class WebFile : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class WellKnownNoReferenceContainsType`1 : Object
{
    public bool IsWellKnownType;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD527A58C0
}

public class WhenAllPromise : Object
{
    public utes.Line[] m_tasks; // 0x58
    public int m_count; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD548B3AB0
    public void TryInvokeContinuation(){} // RVA: 0x7FFD548B3D80
    public void GetResult(){} // RVA: 0x7FFD548B3EA0
    public void GetStatus(){} // RVA: 0x7FFD548B3F20
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B3F70
    public void OnCompleted(){} // RVA: 0x7FFD548B3FB0
}

public class WhenAllPromise`1 : Object
{
    public utes.?<T1717588240>[] m_tasks;
    public int m_count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD527A62A0
    public void TryInvokeContinuation(){} // RVA: 0x7FFD527A6720
    public void GetResult(){} // RVA: 0x7FFD527A6860
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD527A68F0
    public void GetStatus(){} // RVA: 0x7FFD527A6990
    public void UnsafeGetStatus(){} // RVA: 0x7FFD527A69B0
    public void OnCompleted(){} // RVA: 0x7FFD527A69D0
}

public class WhenAllPromise`10 : Object
{
    public T1717661072 t1;
    public T1717661088 t2;
    public T1717661104 t3;
    public T1717661120 t4;
    public T1717661136 t5;
    public T1717661152 t6;
    public T1717661168 t7;
    public T1717661184 t8;
    public T1717661200 t9;
    public T1717661216 t10;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<T1717661072,T1717661088,T1717661104,T1717661120,T1717661136,T1717661152,T1717661168,E<T1717661184,T1717661200,T1717661216>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`11 : Object
{
    public T1717661408 t1;
    public T1717661424 t2;
    public T1717661440 t3;
    public T1717661456 t4;
    public T1717661472 t5;
    public T1717661488 t6;
    public T1717661504 t7;
    public T1717661520 t8;
    public T1717661536 t9;
    public T1717661552 t10;
    public T1717661568 t11;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<T1717661408,T1717661424,T1717661440,T1717661456,T1717661472,T1717661488,T1717661504,5AAF70FA8EA2EBFFB72DF72B5D29A339CC9B8DB464EFC14<T1717661520,T1717661536,T1717661552,T1717661568>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`12 : Object
{
    public T1717661776 t1;
    public T1717661792 t2;
    public T1717661808 t3;
    public T1717661824 t4;
    public T1717661840 t5;
    public T1717661856 t6;
    public T1717661872 t7;
    public T1717661888 t8;
    public T1717661904 t9;
    public T1717661920 t10;
    public T1717661936 t11;
    public T1717661952 t12;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<T1717661776,T1717661792,T1717661808,T1717661824,T1717661840,T1717661856,T1717661872,DF72B5D29A339CC9B8DB464EFC14<T1717661888,T1717661904,T1717661920,T1717661936,T1717661952>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`13 : Object
{
    public T1717662176 t1;
    public T1717662192 t2;
    public T1717662208 t3;
    public T1717662224 t4;
    public T1717662240 t5;
    public T1717662256 t6;
    public T1717662272 t7;
    public T1717662288 t8;
    public T1717662304 t9;
    public T1717662320 t10;
    public T1717662336 t11;
    public T1717662352 t12;
    public T1717662368 t13;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<T1717662176,T1717662192,T1717662208,T1717662224,T1717662240,T1717662256,T1717662272,?<T1717662288,T1717662304,T1717662320,T1717662336,T1717662352,T1717662368>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`14 : Object
{
    public T1717662608 t1;
    public T1717662624 t2;
    public T1717662640 t3;
    public T1717662656 t4;
    public T1717662672 t5;
    public T1717662688 t6;
    public T1717662704 t7;
    public T1717662720 t8;
    public T1717662736 t9;
    public T1717662752 t10;
    public T1717662768 t11;
    public T1717662784 t12;
    public T1717662800 t13;
    public T1717662816 t14;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<T1717662608,T1717662624,T1717662640,T1717662656,T1717662672,T1717662688,T1717662704,itten<T1717662720,T1717662736,T1717662752,T1717662768,T1717662784,T1717662800,T1717662816>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`15 : Object
{
    public T1717663072 t1;
    public T1717663088 t2;
    public T1717663104 t3;
    public T1717663120 t4;
    public T1717663136 t5;
    public T1717663152 t6;
    public T1717663168 t7;
    public T1717663184 t8;
    public T1717663200 t9;
    public T1717663216 t10;
    public T1717663232 t11;
    public T1717663248 t12;
    public T1717663264 t13;
    public T1717663280 t14;
    public T1717663296 t15;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<T1717663072,T1717663088,T1717663104,T1717663120,T1717663136,T1717663152,T1717663168,CLSCompliantAttribute<T1717663184,T1717663200,T1717663216,T1717663232,T1717663248,T1717663264,T1717663280,94A3DC0EDC472CB13D08BCA7B5CC287C51E0E3E<T1717663296>>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT15(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`2 : Object
{
    public T1717659536 t1;
    public T1717659552 t2;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<8BCA7B5CC287C51E0E3E<T1717659536,T1717659552>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`3 : Object
{
    public T1717659616 t1;
    public T1717659632 t2;
    public T1717659648 t3;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<E<T1717659616,T1717659632,T1717659648>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`4 : Object
{
    public T1717659728 t1;
    public T1717659744 t2;
    public T1717659760 t3;
    public T1717659776 t4;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<5AAF70FA8EA2EBFFB72DF72B5D29A339CC9B8DB464EFC14<T1717659728,T1717659744,T1717659760,T1717659776>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`5 : Object
{
    public T1717659872 t1;
    public T1717659888 t2;
    public T1717659904 t3;
    public T1717659920 t4;
    public T1717659936 t5;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<DF72B5D29A339CC9B8DB464EFC14<T1717659872,T1717659888,T1717659904,T1717659920,T1717659936>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`6 : Object
{
    public T1717660048 t1;
    public T1717660064 t2;
    public T1717660080 t3;
    public T1717660096 t4;
    public T1717660112 t5;
    public T1717660128 t6;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<?<T1717660048,T1717660064,T1717660080,T1717660096,T1717660112,T1717660128>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`7 : Object
{
    public T1717660256 t1;
    public T1717660272 t2;
    public T1717660288 t3;
    public T1717660304 t4;
    public T1717660320 t5;
    public T1717660336 t6;
    public T1717660352 t7;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<itten<T1717660256,T1717660272,T1717660288,T1717660304,T1717660320,T1717660336,T1717660352>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`8 : Object
{
    public T1717660496 t1;
    public T1717660512 t2;
    public T1717660528 t3;
    public T1717660544 t4;
    public T1717660560 t5;
    public T1717660576 t6;
    public T1717660592 t7;
    public T1717660608 t8;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<T1717660496,T1717660512,T1717660528,T1717660544,T1717660560,T1717660576,T1717660592,94A3DC0EDC472CB13D08BCA7B5CC287C51E0E3E<T1717660608>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAllPromise`9 : Object
{
    public T1717660768 t1;
    public T1717660784 t2;
    public T1717660800 t3;
    public T1717660816 t4;
    public T1717660832 t5;
    public T1717660848 t6;
    public T1717660864 t7;
    public T1717660880 t8;
    public T1717660896 t9;
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<T1717660768,T1717660784,T1717660800,T1717660816,T1717660832,T1717660848,T1717660864,8BCA7B5CC287C51E0E3E<T1717660880,T1717660896>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class WhenAnyLRPromise`1 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<8BCA7B5CC287C51E0E3E<bool,T1717663328>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryLeftInvokeContinuation(){} // RVA: 0x7FFD4E090C80
    public void TryRightInvokeContinuation(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise : Object
{
    public int completedCount; // 0x10
    public eObjectDelegate.ataProperty>k__BackingField<int> core; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD548B41D0
    public void TryInvokeContinuation(){} // RVA: 0x7FFD548B4490
    public void GetResult(){} // RVA: 0x7FFD548B4580
    public void GetStatus(){} // RVA: 0x7FFD548B4600
    public void OnCompleted(){} // RVA: 0x7FFD548B4650
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B46D0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD548B4580
}

public class WhenAnyPromise`1 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<8BCA7B5CC287C51E0E3E<int,T1717663360>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E097970
    public void TryInvokeContinuation(){} // RVA: 0x7FFD4E099C70
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`10 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717664944,T1717664960,T1717664976,T1717664992,T1717665008,T1717665024,5AAF70FA8EA2EBFFB72DF72B5D29A339CC9B8DB464EFC14<T1717665040,T1717665056,T1717665072,T1717665088>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`11 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717665280,T1717665296,T1717665312,T1717665328,T1717665344,T1717665360,DF72B5D29A339CC9B8DB464EFC14<T1717665376,T1717665392,T1717665408,T1717665424,T1717665440>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`12 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717665648,T1717665664,T1717665680,T1717665696,T1717665712,T1717665728,?<T1717665744,T1717665760,T1717665776,T1717665792,T1717665808,T1717665824>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`13 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717666048,T1717666064,T1717666080,T1717666096,T1717666112,T1717666128,itten<T1717666144,T1717666160,T1717666176,T1717666192,T1717666208,T1717666224,T1717666240>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`14 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717666480,T1717666496,T1717666512,T1717666528,T1717666544,T1717666560,CLSCompliantAttribute<T1717666576,T1717666592,T1717666608,T1717666624,T1717666640,T1717666656,T1717666672,94A3DC0EDC472CB13D08BCA7B5CC287C51E0E3E<T1717666688>>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`15 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717666944,T1717666960,T1717666976,T1717666992,T1717667008,T1717667024,CLSCompliantAttribute<T1717667040,T1717667056,T1717667072,T1717667088,T1717667104,T1717667120,T1717667136,8BCA7B5CC287C51E0E3E<T1717667152,T1717667168>>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT10(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT11(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT12(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT13(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT14(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT15(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`2 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<E<int,T1717663408,T1717663424>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`3 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<5AAF70FA8EA2EBFFB72DF72B5D29A339CC9B8DB464EFC14<int,T1717663488,T1717663504,T1717663520>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`4 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<DF72B5D29A339CC9B8DB464EFC14<int,T1717663600,T1717663616,T1717663632,T1717663648>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`5 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<?<int,T1717663744,T1717663760,T1717663776,T1717663792,T1717663808>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`6 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<itten<int,T1717663920,T1717663936,T1717663952,T1717663968,T1717663984,T1717664000>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`7 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717664128,T1717664144,T1717664160,T1717664176,T1717664192,T1717664208,94A3DC0EDC472CB13D08BCA7B5CC287C51E0E3E<T1717664224>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`8 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717664368,T1717664384,T1717664400,T1717664416,T1717664432,T1717664448,8BCA7B5CC287C51E0E3E<T1717664464,T1717664480>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class WhenAnyPromise`9 : Object
{
    public int completedCount;
    public eObjectDelegate.ataProperty>k__BackingField<CLSCompliantAttribute<int,T1717664640,T1717664656,T1717664672,T1717664688,T1717664704,T1717664720,E<T1717664736,T1717664752,T1717664768>>> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void TryInvokeContinuationT1(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT2(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT3(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT4(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT5(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT6(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT7(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT8(){} // RVA: 0x7FFD4E090C80
    public void TryInvokeContinuationT9(){} // RVA: 0x7FFD4E090C80
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
}

public class Where : Object
{
    public 2.eResetEvent<T1717602208> m_Observable;
    public yPermissionCheck<T1717602208> m_Observer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void OnCompleted(){} // RVA: 0x7FFD4E090980
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
}

public class WhereArrayIterator`1 : Iterator`1
{
    public m.Int64[] source; // 0x20
    public n<m.Int64,bool> predicate; // 0x28
    public int index; // 0x30
}

public class WhereEnumerableIterator`1 : Iterator`1
{
    public URA.bbrevEraNames<T1717677552> source;
    public n<T1717677552,bool> predicate;
    public URA.saAbbrevEnglishEraNames<T1717677552> enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD528E15E0
    public void Clone(){} // RVA: 0x7FFD528E16C0
    public void Dispose(){} // RVA: 0x7FFD528E40C0
    public void MoveNext(){} // RVA: 0x7FFD528E4170
    public void Select(){} // RVA: 0x7FFD4E078F40
    public void Where(){} // RVA: 0x7FFD528E3A80
}

public class WhereListIterator`1 : Iterator`1
{
    public URA.woDigitYearMax<T1717677616> source;
    public n<T1717677616,bool> predicate;
    public eDeviceInformation<T1717677616> enumerator;
}

public class WhereSelectArrayIterator`2 : Iterator`1
{
    public T1717677696[] source;
    public n<T1717677696,bool> predicate;
    public n<T1717677696,T1717677712> selector;
    public int index;
}

public class WhereSelectEnumerableIterator`2 : Iterator`1
{
    public URA.bbrevEraNames<T1717677648> source;
    public n<T1717677648,bool> predicate;
    public n<T1717677648,T1717677664> selector;
    public URA.saAbbrevEnglishEraNames<T1717677648> enumerator;
}

public class WhereSelectListIterator`2 : Iterator`1
{
    public URA.woDigitYearMax<T1717677744> source;
    public n<T1717677744,bool> predicate;
    public n<T1717677744,T1717677760> selector;
    public eDeviceInformation<T1717677744> enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD528EDF50
    public void Clone(){} // RVA: 0x7FFD528EE080
    public void MoveNext(){} // RVA: 0x7FFD529B9A50
    public void Select(){} // RVA: 0x7FFD4E078F40
    public void Where(){} // RVA: 0x7FFD529A48B0
}

public class WillRenderCanvases : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class WindUpdate : ValueType
{
}

public class WindowFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E432370
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class WithoutCurrentEnumerable : Object
{
    public eObjectDelegate.onPropertyInfo<T1717653696> parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetAsyncEnumerator(){}
}

public class WorkRequest : ValueType
{
    public sageKind.st m_DelagateCallback; // 0x10
    public object m_DelagateState; // 0x18
    public sageKind.tion m_WaitHandle; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F88FCC0
    public void Invoke(){} // RVA: 0x7FFD54CE8EF0
}

public class WorkStealingQueue : Object
{
    public sageKind._internal[] DangerousCount; // 0x10
    public int m_mask; // 0x18
    public int m_headIndex; // 0x1C
    public int m_tailIndex; // 0x20
    public sageKind.ceJapaneseEraYearRanges m_foreignLock; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void LocalPush(){} // RVA: 0x7FFD4E2ADC40
    public void TryLocalPop(){} // RVA: 0x7FFD4E079F60
    public void TrySteal(){}
    public void DangerousCopyTo(){}
    public void get_DangerousCount(){} // RVA: 0x7FFD4E079960
}

public class WorldFetchParameters : Object
{
    public object Endpoint;
    public object Parameters;

    // ── Methods ──
    public void get_Endpoint(){} // RVA: 0x7FFD4E35C380
    public void set_Endpoint(){} // RVA: 0x7FFD4E342E30
    public void get_Parameters(){} // RVA: 0x7FFD4E3447C0
    public void set_Parameters(){} // RVA: 0x7FFD4E3A7E80
    public void .ctor(){} // RVA: 0x7FFD573180E0
}

public class WriteDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class WriteFileJson : ValueType
{
    public string name; // 0x10
    public ebSocket[] maps; // 0x18
    public eration[] controlSchemes; // 0x20
}

public class WriteFileJsonNoName : ValueType
{
    public ebSocket[] maps; // 0x10
    public eration[] controlSchemes; // 0x18
}
