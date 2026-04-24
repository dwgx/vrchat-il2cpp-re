// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 78
// Methods: 319

public class DESEncryption : Object
{
    public int Iterations;

    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7FFD56E4EA40
    public void TryDecrypt(){} // RVA: 0x7FFD56E4EF00
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class DYNAMIC_TIME_ZONE_INFORMATION : ValueType
{
    public 0x6641A698 TZI; // 0x10
    public string TimeZoneKeyName; // 0xC0
    public byte DynamicDaylightTimeDisabled; // 0xC8
}

public class Data : ValueType
{
    public 0x6640F9B0 <name>k__BackingField; // 0x68
    public 0x6640F9B0 <shortName>k__BackingField; // 0x70
    public string <template>k__BackingField; // 0x78
    public string <thumbnailImageUrl>k__BackingField; // 0x80
    public string <imageUrl>k__BackingField; // 0x88
    public string <iconImageUrl>k__BackingField; // 0x90
    public 0x6640F9B0 <description>k__BackingField; // 0x98
    public 0x6640F9B0 <tooltipDescription>k__BackingField; // 0xA0
    public 0x6640F9B0 <taglineText>k__BackingField; // 0xA8
    public string <version>k__BackingField; // 0xB0
    public bool <isNew>k__BackingField; // 0xB8
    public j <onPressed>k__BackingField; // 0xC0
    public string <disclaimerText>k__BackingField; // 0xC8
    public string <worldTag>k__BackingField; // 0xD0
    public 0x6640E720 <contentList>k__BackingField; // 0xD8
    public System.Collections.Generic.List`1<0x6640E778> <domainList>k__BackingField; // 0xE0
    public 0x6640E7D0 <search>k__BackingField; // 0xE8
    public 0x6640E828 <ipsQuery>k__BackingField; // 0xF0
    public 0x6640E8D8 <article>k__BackingField; // 0xF8
    public System.Collections.Generic.List`1<MarketplaceCategoryData> <categories>k__BackingField; // 0x100
    public string <experimentKey>k__BackingField; // 0x108
    public string <segment>k__BackingField; // 0x110
    public 0x6640E9E0 <promotion>k__BackingField; // 0x118
    public string <featuredAvatarCategoryId>k__BackingField; // 0x120
    public System.Collections.Generic.List`1<string> <listingIds>k__BackingField; // 0x128
}

public class DataElementDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F53D4B0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD57494E60
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class DataSet`1 : Object
{
    public bool disposed;
    public GPUBuffer`1<T> gpuData;
    public Unity.Collections.NativeArray`1<T> cpuData;
    public Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> updateRanges;
    public 0x66487E58 allocator;
    public uint m_UpdateRangePoolSize;
    public uint m_ElemStride;
    public uint m_UpdateRangeMin;
    public uint m_UpdateRangeMax;
    public uint m_UpdateRangesEnqueued;
    public uint m_UpdateRangesBatchStart;
    public bool m_UpdateRangesSaturated;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_disposed(){} // RVA: 0x7FFD4E079D00
    public void set_disposed(){} // RVA: 0x7FFD4E091060
    public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
    public void RegisterUpdate(){}
    public void HasMappedBufferRange(){} // RVA: 0x7FFD4E079D00
    public void SendUpdates(){} // RVA: 0x7FFD4E090980
    public void SendFullRange(){} // RVA: 0x7FFD4E090980
    public void SendPartialRanges(){} // RVA: 0x7FFD4E090980
    public void ResetUpdateState(){} // RVA: 0x7FFD4E090980
}

public class DataStorageShadow : Object
{
    public string ParameterString; // 0x10
    public string ParameterBoolOp; // 0x18
    public string ParameterFloat; // 0x20
    public string ParameterInt; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class DataTokenFormatter : BaseFormatter`1
{
    public VRC.Udon.Serialization.OdinSerializer.Serializer`1<object> _referenceReaderWriter;

    // ── Methods ──
    public void DeserializeImplementation(){} // RVA: 0x7FFD552A7A60
    public void SerializeImplementation(){} // RVA: 0x7FFD552A8190
    public void .ctor(){} // RVA: 0x7FFD552A86B0
    public void .cctor(){} // RVA: 0x7FFD552A8710
}

public class DeactivateControllerLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD51475BD0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD574929E0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class DeactivateObjectLabelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class DebugImageInfo : Object
{
    public 0x664FA840 Image; // 0x10
    public System.Nullable`1<long> StartAddress; // 0x18
    public System.Nullable`1<long> EndAddress; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53F25910
    public void ContainsAddress(){} // RVA: 0x7FFD53F25A50
}

public class DebugMessage : ValueType
{
    public ypeToggleOn Type; // 0x10
    public string Msg; // 0x18
}

public class DebugView : Object
{
    public System.Text.Json.Nodes.JsonValue`1<T> Json;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void get_Json(){} // RVA: 0x7FFD4E078E90
    public void get_Path(){} // RVA: 0x7FFD4E078E90
    public void get_Value(){} // RVA: 0x7FFD4E2ADC40
}

public class DebuggerProxy : Object
{
}

public class DecCalc : ValueType
{
    public uint High; // 0x10
    public uint Low; // 0x14
    public uint Mid; // 0x18
    public uint IsNegative; // 0x1C
    public ulong Scale; // 0x18
    public uint[] Low64;
    public ulong[] s_ulongPowers10; // 0x8
    public double[] s_doublePowers10; // 0x10
    public 0x66425118[] PowerOvflValues; // 0x18

    // ── Methods ──
    public void get_High(){} // RVA: 0x7FFD4F8402A0
    public void set_High(){} // RVA: 0x7FFD4F840230
    public void get_Low(){} // RVA: 0x7FFD4FDE7500
    public void set_Low(){} // RVA: 0x7FFD4FDE7510
    public void get_Mid(){} // RVA: 0x7FFD4FDE7520
    public void set_Mid(){} // RVA: 0x7FFD4FDE7530
    public void get_IsNegative(){} // RVA: 0x7FFD53A4EBA0
    public void get_Scale(){} // RVA: 0x7FFD4FD7DE20
    public void get_Low64(){} // RVA: 0x7FFD53AD4B80
    public void set_Low64(){} // RVA: 0x7FFD4FE268C0
    public void GetExponent(){} // RVA: 0x7FFD53AD4BA0 | overloaded x2
    public void UInt32x32To64(){} // RVA: 0x7FFD539D6350
    public void UInt64x64To128(){} // RVA: 0x7FFD53AD4BB0
    public void Div96By32(){} // RVA: 0x7FFD53AD4D20
    public void Div96ByConst(){} // RVA: 0x7FFD53AD4D90
    public void Unscale(){} // RVA: 0x7FFD53AD4E00
    public void Div96By64(){} // RVA: 0x7FFD53AD5010
    public void Div128By96(){} // RVA: 0x7FFD53AD5160
    public void IncreaseScale(){} // RVA: 0x7FFD53AD5280
    public void IncreaseScale64(){} // RVA: 0x7FFD53AD5310
    public void ScaleResult(){} // RVA: 0x7FFD53AD5390
    public void DivByConst(){} // RVA: 0x7FFD53AD5A80
    public void LeadingZeroCount(){} // RVA: 0x7FFD53AD5B00
    public void OverflowUnscale(){} // RVA: 0x7FFD53AD5B60
    public void SearchScale(){} // RVA: 0x7FFD53AD5C90
    public void Add32To96(){} // RVA: 0x7FFD53AD5E70
    public void DecAddSub(){} // RVA: 0x7FFD53AD5E90
    public void VarCyFromDec(){} // RVA: 0x7FFD53AD6560
    public void VarDecCmp(){} // RVA: 0x7FFD53AD6770
    public void VarDecCmpSub(){} // RVA: 0x7FFD53AD6890
    public void VarDecMul(){} // RVA: 0x7FFD53AD6A90
    public void VarDecFromR4(){} // RVA: 0x7FFD53AD6F70
    public void VarDecFromR8(){} // RVA: 0x7FFD53AD7370
    public void VarR4FromDec(){} // RVA: 0x7FFD53AD7760
    public void VarR8FromDec(){} // RVA: 0x7FFD53AD77C0
    public void GetHashCode(){} // RVA: 0x7FFD53AD78E0
    public void VarDecDiv(){} // RVA: 0x7FFD53AD7A30
    public void VarDecMod(){} // RVA: 0x7FFD53AD8460
    public void VarDecModFull(){} // RVA: 0x7FFD53AD8850
    public void InternalRound(){} // RVA: 0x7FFD53AD8C90
    public void DecDivMod1E9(){} // RVA: 0x7FFD53AD8FA0
    public void .cctor(){} // RVA: 0x7FFD53AD9020
}

public class Decoder : DecoderNLS
{
    public int HasState; // 0x30
    public char lastChar; // 0x34

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5380F5C0
    public void Reset(){} // RVA: 0x7FFD5380F5D0
    public void get_HasState(){} // RVA: 0x7FFD5380F600
}

public class DecomposedGuid : ValueType
{
    public System.Guid Guid; // 0x10
    public byte Byte00; // 0x10
    public byte Byte01; // 0x11
    public byte Byte02; // 0x12
    public byte Byte03; // 0x13
    public byte Byte04; // 0x14
    public byte Byte05; // 0x15
    public byte Byte06; // 0x16
    public byte Byte07; // 0x17
    public byte Byte08; // 0x18
    public byte Byte09; // 0x19
    public byte Byte10; // 0x1A
    public byte Byte11; // 0x1B
    public byte Byte12; // 0x1C
    public byte Byte13; // 0x1D
    public byte Byte14; // 0x1E
    public byte Byte15; // 0x1F
}

public class DefaultComparer`1 : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFD4E2ADC40
}

public class DefaultDecoder : Decoder
{
    public System.Text.Encoding m_encoding; // 0x20
    public bool m_hasInitializedEncoding; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD538157B0 | overloaded x2
    public void GetRealObject(){} // RVA: 0x7FFD53815AF0
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD53815BA0
    public void GetCharCount(){} // RVA: 0x7FFD53815C70 | overloaded x3
    public void GetChars(){} // RVA: 0x7FFD53815CE0 | overloaded x3
}

public class DefaultEncoder : Encoder
{
    public System.Text.Encoding m_encoding; // 0x20
    public bool m_hasInitializedEncoding; // 0x28
    public char charLeftOver; // 0x2A

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53815150 | overloaded x2
    public void GetRealObject(){} // RVA: 0x7FFD53815520
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD53815640
    public void GetByteCount(){} // RVA: 0x7FFD53815710 | overloaded x2
    public void GetBytes(){} // RVA: 0x7FFD53815780 | overloaded x2
}

public class DeferBindingResolutionWrapper : Object
{
    // ── Methods ──
    public void Acquire(){} // RVA: 0x7FFD54958130
    public void Dispose(){} // RVA: 0x7FFD54958190
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class DeferPromise : Object
{
    public System.Func`1<Cysharp.Threading.Tasks.UniTask> factory; // 0x10
    public Cysharp.Threading.Tasks.UniTask task; // 0x18
    public Awaiter awaiter; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void GetResult(){} // RVA: 0x7FFD548B1460
    public void GetStatus(){} // RVA: 0x7FFD548B14C0
    public void OnCompleted(){} // RVA: 0x7FFD548B16A0
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B1750
}

public class DeferPromiseWithState`1 : Object
{
    public System.Func`2<T,Cysharp.Threading.Tasks.UniTask> factory;
    public T argument;
    public Cysharp.Threading.Tasks.UniTask task;
    public Awaiter awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
}

public class DeferPromiseWithState`2 : Object
{
    public System.Func`2<U,Cysharp.Threading.Tasks.UniTask`1<T>> factory;
    public U argument;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public Awaiter<T> awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
}

public class DeferPromise`1 : Object
{
    public System.Func`1<Cysharp.Threading.Tasks.UniTask`1<T>> factory;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public Awaiter<T> awaiter;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
}

public class DelayFramePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayFramePromise> NextNode;
    public DelayFramePromise nextNode; // 0x10
    public int initialFrame; // 0x18
    public int delayFrameCount; // 0x1C
    public System.Threading.CancellationToken cancellationToken; // 0x20
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x28
    public bool cancelImmediately; // 0x40
    public int currentFrameCount; // 0x44
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x48

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548AE290
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548AE410
    public void GetResult(){} // RVA: 0x7FFD548AE830
    public void GetStatus(){} // RVA: 0x7FFD548AE9D0
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548AEA20
    public void OnCompleted(){} // RVA: 0x7FFD548AEA60
    public void MoveNext(){} // RVA: 0x7FFD548AEAE0
    public void TryReturn(){} // RVA: 0x7FFD548AEC00
}

public class DelayIgnoreTimeScalePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayIgnoreTimeScalePromise> NextNode;
    public DelayIgnoreTimeScalePromise nextNode; // 0x10
    public float delayFrameTimeSpan; // 0x18
    public float elapsed; // 0x1C
    public int initialFrame; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x50

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548AFAB0
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548AFC30
    public void GetResult(){} // RVA: 0x7FFD548B00A0
    public void GetStatus(){} // RVA: 0x7FFD548B0240
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B0290
    public void OnCompleted(){} // RVA: 0x7FFD548B02D0
    public void MoveNext(){} // RVA: 0x7FFD548B0350
    public void TryReturn(){} // RVA: 0x7FFD548B04E0
}

public class DelayPromise : Object
{
    public System.Threading.CancellationToken NextNode; // 0x58
    public System.Threading.CancellationTokenRegistration Registration; // 0x60
    public System.Threading.Timer Timer; // 0x78

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548AEE40
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548AEFC0
    public void GetResult(){} // RVA: 0x7FFD548AF430
    public void GetStatus(){} // RVA: 0x7FFD548AF5D0
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548AF620
    public void OnCompleted(){} // RVA: 0x7FFD548AF660
    public void MoveNext(){} // RVA: 0x7FFD548AF6E0
    public void TryReturn(){} // RVA: 0x7FFD548AF870
}

public class DelayRealtimePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<DelayRealtimePromise> NextNode;
    public DelayRealtimePromise nextNode; // 0x10
    public long delayTimeSpanTicks; // 0x18
    public Cysharp.Threading.Tasks.Internal.ValueStopwatch stopwatch; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x50

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFD51B3A9E0
    public void .cctor(){} // RVA: 0x7FFD548B0720
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Create(){} // RVA: 0x7FFD548B08A0
    public void GetResult(){} // RVA: 0x7FFD548B0CE0
    public void GetStatus(){} // RVA: 0x7FFD548B0E80
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B0ED0
    public void OnCompleted(){} // RVA: 0x7FFD548B0F10
    public void MoveNext(){} // RVA: 0x7FFD548B0F90
    public void TryReturn(){} // RVA: 0x7FFD548B10D0
}

public class DelegateEnumerator : FileSystemEnumerator`1
{
    public System.IO.Enumeration.FileSystemEnumerable`1<System.IO.FileInfo> _enumerable; // 0x70

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void TransformEntry(){} // RVA: 0x7FFD4E2ADC40
    public void ShouldRecurseIntoEntry(){} // RVA: 0x7FFD4E079F60
    public void ShouldIncludeEntry(){} // RVA: 0x7FFD4E079F60
}

public class DeliverIosPlatformEvents : ValueType
{
}

public class DeltaStateEventBuffer : ValueType
{
    public UnityEngine.InputSystem.LowLevel.DeltaStateEvent stateEvent; // 0x10
    public int kMaxSize;
    public 0x664A6F68 data; // 0x2D
}

public class DeserializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510DE090
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD5518CE60
    public void EndInvoke(){} // RVA: 0x7FFD53D8F1B0
}

public class DestroyPipelineDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class DestroyRigDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class Development : Object
{
    // ── Methods ──
    public void Log(){} // RVA: 0x7FFD53D4C6A0
    public void LogWarning(){} // RVA: 0x7FFD53D4C720
    public void LogError(){} // RVA: 0x7FFD53D4C7A0
    public void LogRequest(){} // RVA: 0x7FFD4E341310
    public void LogRequestResult(){} // RVA: 0x7FFD4E341310
}

public class DeviceArray : ValueType
{
    public bool m_HaveValue; // 0x10
    public int m_DeviceCount; // 0x14
    public UnityEngine.InputSystem.InputDevice[] m_DeviceArray; // 0x18

    // ── Methods ──
    public void IndexOf(){} // RVA: 0x7FFD54946E90
    public void Remove(){} // RVA: 0x7FFD54946F30
    public void Get(){} // RVA: 0x7FFD54946FF0
    public void Set(){} // RVA: 0x7FFD54947160
}

public class DeviceDescriptionJson : ValueType
{
    public string interface; // 0x10
    public string type; // 0x18
    public string product; // 0x20
    public string serial; // 0x28
    public string version; // 0x30
    public string manufacturer; // 0x38
    public string capabilities; // 0x40
}

public class DeviceJson : ValueType
{
    public string devicePath; // 0x10
    public bool isOptional; // 0x18
    public bool isOR; // 0x19

    // ── Methods ──
    public void ToDeviceEntry(){} // RVA: 0x7FFD5499ADC0
    public void From(){} // RVA: 0x7FFD5499AE50
}

public class DictationCompletedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E432370
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class DictationErrorHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD9DE20
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class DictationHypothesisDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class DictationResultDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD9DE20
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class DictionaryEnumerator : Object
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,{>> _enumerator; // 0x10
}

public class DictionaryEnumerator`2 : ValueType
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<W,T>> Entry;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void get_Entry(){} // RVA: 0x7FFD4E0788A0
    public void get_Key(){} // RVA: 0x7FFD4E078E90
    public void get_Value(){} // RVA: 0x7FFD4E078E90
    public void get_Current(){} // RVA: 0x7FFD4E078E90
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Reset(){} // RVA: 0x7FFD4E090980
}

public class DictionaryIterator`2 : ValueType
{
    public System.Collections.Generic.Dictionary`2<U,T> Current;
    public Enumerator<U,T> enumerator;
    public bool isNull;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class DictionaryPoolImpl`2 : Object
{
    public VRC.Core.Pool.ObjectPool`1<System.Collections.Generic.Dictionary`2<UnityEngine.Material,UnityEngine.Material>> Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class DictionaryValueIterator`2 : ValueType
{
    public System.Collections.Generic.Dictionary`2<U,T> Current;
    public Enumerator<U,T> enumerator;
    public bool isNull;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class DictionaryWrapper`1 : ValueType
{
    public System.Collections.Generic.IReadOnlyDictionary`2<string,Token> Dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class DirectorDeferredEvaluate : ValueType
{
}

public class DirectorFixedSampleTime : ValueType
{
}

public class DirectorFixedUpdate : ValueType
{
}

public class DirectorFixedUpdatePostPhysics : ValueType
{
}

public class DirectorLateUpdate : ValueType
{
}

public class DirectorRenderImage : ValueType
{
}

public class DirectorSampleTime : ValueType
{
}

public class DirectorUpdate : ValueType
{
}

public class DirectorUpdateAnimationBegin : ValueType
{
}

public class DirectorUpdateAnimationEnd : ValueType
{
}

public class DispatchEventQueueEvents : ValueType
{
}

public class DisplaysUpdatedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class DisposeHandle : Object
{
    public 0x664F7458 _localHub; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void Dispose(){} // RVA: 0x7FFD53F6AEE0
}

public class DisposingLoggerFactory : Object
{
    public Microsoft.Extensions.Logging.ILoggerFactory _loggerFactory; // 0x10
    public Microsoft.Extensions.DependencyInjection.ServiceProvider _serviceProvider; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E90C240
    public void Dispose(){} // RVA: 0x7FFD53769D40
    public void CreateLogger(){} // RVA: 0x7FFD53769D80
    public void AddProvider(){} // RVA: 0x7FFD53769DE0
}

public class DoubleBuffers : ValueType
{
    public void** valid; // 0x10
    public int deviceCount; // 0x18

    // ── Methods ──
    public void get_valid(){} // RVA: 0x7FFD511E6CA0
    public void SetFrontBuffer(){} // RVA: 0x7FFD54AA38D0
    public void SetBackBuffer(){} // RVA: 0x7FFD54AA38F0
    public void GetFrontBuffer(){} // RVA: 0x7FFD54AA3910
    public void GetBackBuffer(){} // RVA: 0x7FFD54AA3930
    public void SwapBuffers(){} // RVA: 0x7FFD54AA3950
}

public class DoublePoint : ValueType
{
    public double X; // 0x10
    public double Y; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC7BDB0 | overloaded x3
}

public class DpadAxisControl : AxisControl
{
    public int component; // 0x130

    // ── Methods ──
    public void get_component(){} // RVA: 0x7FFD4E7DC1B0
    public void set_component(){} // RVA: 0x7FFD5497CD90
    public void FinishSetup(){} // RVA: 0x7FFD5497CDA0
    public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD5497CE90
    public void .ctor(){} // RVA: 0x7FFD5497CFB0
}

public class DroneSkinMap : DroneSkinMapCore
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class DropdownEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54B650F0
}

public class DropdownItem : MonoBehaviour
{
    public TMPro.TMP_Text text; // 0x20
    public UnityEngine.UI.Image image; // 0x28
    public UnityEngine.RectTransform rectTransform; // 0x30
    public UnityEngine.UI.Toggle toggle; // 0x38

    // ── Methods ──
    public void get_text(){} // RVA: 0x7FFD4E36F0C0
    public void set_text(){} // RVA: 0x7FFD4E36F0D0
    public void get_image(){} // RVA: 0x7FFD4E36F130
    public void set_image(){} // RVA: 0x7FFD4E342E90
    public void get_rectTransform(){} // RVA: 0x7FFD4E5F95E0
    public void set_rectTransform(){} // RVA: 0x7FFD4E36F890
    public void get_toggle(){} // RVA: 0x7FFD4E5F0140
    public void set_toggle(){} // RVA: 0x7FFD4E5F0C20
    public void OnPointerEnter(){} // RVA: 0x7FFD54B64E90
    public void OnCancel(){} // RVA: 0x7FFD54B64F40
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class DualSenseHIDBluetoothInputReport : ValueType
{
    public int ExpectedReportId;
    public byte reportId; // 0x10
    public byte leftStickX; // 0x12
    public byte leftStickY; // 0x13
    public byte rightStickX; // 0x14
    public byte rightStickY; // 0x15
    public byte leftTrigger; // 0x16
    public byte rightTrigger; // 0x17
    public byte buttons0; // 0x19
    public byte buttons1; // 0x1A
    public byte buttons2; // 0x1B

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A90F00
}

public class DualSenseHIDGenericInputReport : ValueType
{
    public byte Format; // 0x10

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFD54A782A0
}

public class DualSenseHIDMinimalInputReport : ValueType
{
    public int ExpectedSize1;
    public int ExpectedSize2; // 0x4
    public byte reportId; // 0x10
    public byte leftStickX; // 0x11
    public byte leftStickY; // 0x12
    public byte rightStickX; // 0x13
    public byte rightStickY; // 0x14
    public byte buttons0; // 0x15
    public byte buttons1; // 0x16
    public byte buttons2; // 0x17
    public byte leftTrigger; // 0x18
    public byte rightTrigger; // 0x19

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A90F50
    public void .cctor(){} // RVA: 0x7FFD54A90FA0
}

public class DualSenseHIDUSBInputReport : ValueType
{
    public int ExpectedReportId;
    public byte reportId; // 0x10
    public byte leftStickX; // 0x11
    public byte leftStickY; // 0x12
    public byte rightStickX; // 0x13
    public byte rightStickY; // 0x14
    public byte leftTrigger; // 0x15
    public byte rightTrigger; // 0x16
    public byte buttons0; // 0x18
    public byte buttons1; // 0x19
    public byte buttons2; // 0x1A

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A90EB0
}

public class DualShock4HIDGenericInputReport : ValueType
{
    public byte Format; // 0x10
    public byte leftStickY; // 0x11
    public byte rightStickX; // 0x12
    public byte rightStickY; // 0x13
    public byte buttons0; // 0x14
    public byte buttons1; // 0x15
    public byte buttons2; // 0x16
    public byte leftTrigger; // 0x17
    public byte rightTrigger; // 0x18

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFD54A782A0
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A91FC0
}

public class DummyJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD4E341310
}

public class DynamicBone : MonoBehaviour
{
    public System.Action ÎÎÍÏÍÎÎÎÍÏÏÎÍÎÏÌÍÏÌÏÎÍÍ; // 0x20
    public System.Action ÏÍÍÎÍÌÎÏÏÍÏÏÍÍÏÏÌÏÍÍÍÍÌ; // 0x28
    public UnityEngine.Transform m_Root; // 0x30
    public float m_UpdateRate; // 0x38
    public float m_Damping; // 0x3C
    public UnityEngine.AnimationCurve m_DampingDistrib; // 0x40
    public float m_Elasticity; // 0x48
    public UnityEngine.AnimationCurve m_ElasticityDistrib; // 0x50
    public float m_Stiffness; // 0x58
    public UnityEngine.AnimationCurve m_StiffnessDistrib; // 0x60
    public float m_Inert; // 0x68
    public UnityEngine.AnimationCurve m_InertDistrib; // 0x70
    public float m_Radius; // 0x78
    public UnityEngine.AnimationCurve m_RadiusDistrib; // 0x80
    public float m_EndLength; // 0x88
    public UnityEngine.Vector3 m_EndOffset; // 0x8C
    public UnityEngine.Vector3 m_Gravity; // 0x98
    public UnityEngine.Vector3 m_Force; // 0xA4
    public System.Collections.Generic.List`1<DynamicBoneCollider> m_Colliders; // 0xB0
    public System.Collections.Generic.List`1<UnityEngine.Transform> m_Exclusions; // 0xB8
    public 0x66347438 m_FreezeAxis; // 0xC0
    public bool m_DistantDisable; // 0xC4
    public UnityEngine.Transform m_ReferenceObject; // 0xC8
    public float m_DistanceToObject; // 0xD0
    public UnityEngine.Vector3 ÎÎÌÌÍÎÎÍÎÌÏÏÎÏÌÍÌÍÍÌÎÎÍ; // 0xD4
    public UnityEngine.Vector3 ÍÌÎÏÌÍÍÎÌÎÎÎÎÌÏÏÎÎÌÍÍÌÍ; // 0xE0
    public UnityEngine.Vector3 ÏÍÎÏÎÎÏÏÌÍÎÎÏÍÍÍÎÍÎÌÌÎÏ; // 0xEC
    public float ÏÍÌÍÎÏÎÌÍÍÏÎÌÌÏÏÌÎÍÎÎÌÎ; // 0xF8
    public float ÎÍÌÌÌÍÌÎÎÍÌÌÎÌÏÏÌÌÎÍÎÌÎ; // 0xFC
    public float ÎÏÍÍÎÏÏÏÌÍÏÍÍÎÎÍÏÎÎÏÍÌÌ; // 0x100
    public float ÍÍÎÎÌÍÎÍÍÌÍÍÎÍÏÎÌÎÍÎÎÌÎ; // 0x104
    public bool ÍÎÌÏÏÍÎÌÏÌÌÏÍÏÌÍÌÍÎÏÏÎÍ; // 0x108
    public System.Collections.Generic.List`1<ÍÍÎÎÍÎÎÌÎÍÌÎÌÍÍÌÏÍÌÍÌÏÍ> ÌÎÍÏÍÌÍÍÎÍÍÏÌÏÎÌÎÌÎÍÍÎÍ; // 0x110
    public float ÌÌÎÏÎÏÏÏÍÌÏÏÌÏÏÍÌÍÏÏÍÌÎ; // 0x118
    public bool ÎÌÍÌÍÏÍÎÏÌÌÏÍÎÏÎÎÍÌÏÎÏÏ; // 0x11C

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E4C60E0
    public void RaiseCancellation(){} // RVA: 0x7FFD4E4C6130
    public void IsInvoking(){} // RVA: 0x7FFD4E4C6570
    public void CancelInvoke(){} // RVA: 0x7FFD4E4C6A50
    public void Invoke(){} // RVA: 0x7FFD4E4C7200
    public void InvokeRepeating(){} // RVA: 0x7FFD4E4C72A0
    public void AccessdeltaTime(){} // RVA: 0x7FFD4E4C80C0
    public void GetTrackingOriginMode(){} // RVA: 0x7FFD4E4C8370
    public void StartCoroutine(){} // RVA: 0x7FFD4E4C8640
    public void OnEnable(){} // RVA: 0x7FFD4E4C8930
    public void Start(){} // RVA: 0x7FFD4E4C8970
    public void .ctor(){} // RVA: 0x7FFD4E4C9070
    public void Initialize(){} // RVA: 0x7FFD4E4C9330
    public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E4CA140
    public void StopCoroutine(){} // RVA: 0x7FFD4E4CA580
    public void StopAllCoroutines(){} // RVA: 0x7FFD4E4CA870
    public void get_useGUILayout(){} // RVA: 0x7FFD4E4CACB0
    public void set_useGUILayout(){} // RVA: 0x7FFD4E4CAD30
    public void print(){} // RVA: 0x7FFD4E4CAD60
    public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4E4CB810
    public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4E4CB8B0
    public void InvokeDelayed(){} // RVA: 0x7FFD4E4CBD00
    public void OnDisable(){} // RVA: 0x7FFD4E4CC4E0
    public void OnDestroy(){} // RVA: 0x7FFD4E4CC520
    public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4E4CC8B0
    public void OnValidate(){} // RVA: 0x7FFD4E4CCCF0
    public void StartCoroutineManaged2(){} // RVA: 0x7FFD4E4CCDD0
}

public class DynamicBoneCollider : MonoBehaviour
{
    public UnityEngine.Vector3 m_Center; // 0x20
    public float m_Radius; // 0x2C
    public float m_Height; // 0x30
    public 0x66347598 m_Direction; // 0x34
    public 0x663475F0 m_Bound; // 0x38

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E4CE380
    public void RaiseCancellation(){} // RVA: 0x7FFD4E4CE480
    public void .ctor(){} // RVA: 0x7FFD4E4CE760
    public void Initialize(){} // RVA: 0x7FFD4E4CE7F0
    public void OnValidate(){} // RVA: 0x7FFD4E4CE900
    public void InvokeRepeating(){} // RVA: 0x7FFD4E4CE380
    public void CancelInvoke(){} // RVA: 0x7FFD4E4CE930
    public void IsInvoking(){} // RVA: 0x7FFD4E4CEC10
    public void StartCoroutine(){} // RVA: 0x7FFD4E4CF350
    public void AdjustPointForCollision(){} // RVA: 0x7FFD4E4CF380
    public void AccesslossyScale_Injected(){} // RVA: 0x7FFD4E4CF490
    public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E4CFBE0
    public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E4CFEA0
    public void StopCoroutine(){} // RVA: 0x7FFD4E4D0480
}

public class DynamicPartitionEnumerator_Abstract`2 : Object
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>> HasNoElementsLeft; // 0x10
    public int Current;
    public SharedInt System.Collections.IEnumerator.Current; // 0x18
    public SharedInt _localOffset; // 0x20
    public int _doublingCountdown; // 0x28
    public int _maxChunkSize; // 0x2C
    public SharedLong _sharedIndex; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void GrabNextChunk(){} // RVA: 0x7FFD4E07A310
    public void get_HasNoElementsLeft(){} // RVA: 0x7FFD4E079D00
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class DynamicPartitionerForIEnumerable`1 : OrderablePartitioner`1
{
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>> SupportsDynamicPartitions; // 0x18
    public bool _useSingleChunking; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E097970
    public void GetOrderableDynamicPartitions(){} // RVA: 0x7FFD4E078E90
    public void get_SupportsDynamicPartitions(){} // RVA: 0x7FFD4E079D00
}
