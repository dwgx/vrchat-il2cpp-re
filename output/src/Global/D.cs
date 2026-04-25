// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 78
// Methods: 319

public class DESEncryption : Object
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7FFD56E4EA40
    public void TryDecrypt(){} // RVA: 0x7FFD56E4EF00
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class DYNAMIC_TIME_ZONE_INFORMATION : ValueType
{
}

public class Data : ValueType
{
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
    public object disposed;

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
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class DataTokenFormatter : BaseFormatter`1
{
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
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53F25910
    public void ContainsAddress(){} // RVA: 0x7FFD53F25A50
}

public class DebugMessage : ValueType
{
}

public class DebugView : Object
{
    public object Json;
    public object Path;
    public object Value;

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
    public object High;
    public object Low;
    public object Mid;
    public object IsNegative;
    public object Scale;
    public object Low64;

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
    public object HasState;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5380F5C0
    public void Reset(){} // RVA: 0x7FFD5380F5D0
    public void get_HasState(){} // RVA: 0x7FFD5380F600
}

public class DecomposedGuid : ValueType
{
}

public class DefaultComparer`1 : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFD4E2ADC40
}

public class DefaultDecoder : Decoder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD538157B0 | overloaded x2
    public void GetRealObject(){} // RVA: 0x7FFD53815AF0
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD53815BA0
    public void GetCharCount(){} // RVA: 0x7FFD53815C70 | overloaded x3
    public void GetChars(){} // RVA: 0x7FFD53815CE0 | overloaded x3
}

public class DefaultEncoder : Encoder
{
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
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void GetResult(){} // RVA: 0x7FFD548B1460
    public void GetStatus(){} // RVA: 0x7FFD548B14C0
    public void OnCompleted(){} // RVA: 0x7FFD548B16A0
    public void UnsafeGetStatus(){} // RVA: 0x7FFD548B1750
}

public class DeferPromiseWithState`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
}

public class DeferPromiseWithState`2 : Object
{
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
    public object NextNode;

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
    public object NextNode;

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
    public object NextNode;

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
    public object NextNode;

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
    // ── Methods ──
    public void IndexOf(){} // RVA: 0x7FFD54946E90
    public void Remove(){} // RVA: 0x7FFD54946F30
    public void Get(){} // RVA: 0x7FFD54946FF0
    public void Set(){} // RVA: 0x7FFD54947160
}

public class DeviceDescriptionJson : ValueType
{
}

public class DeviceJson : ValueType
{
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
}

public class DictionaryEnumerator`2 : ValueType
{
    public object Entry;
    public object Key;
    public object Value;
    public object Current;

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
    public object Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class DictionaryPoolImpl`2 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class DictionaryValueIterator`2 : ValueType
{
    public object Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class DictionaryWrapper`1 : ValueType
{
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
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void Dispose(){} // RVA: 0x7FFD53F6AEE0
}

public class DisposingLoggerFactory : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E90C240
    public void Dispose(){} // RVA: 0x7FFD53769D40
    public void CreateLogger(){} // RVA: 0x7FFD53769D80
    public void AddProvider(){} // RVA: 0x7FFD53769DE0
}

public class DoubleBuffers : ValueType
{
    public object valid;

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
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC7BDB0 | overloaded x3
}

public class DpadAxisControl : AxisControl
{
    public object component;

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
    public object text;
    public object image;
    public object rectTransform;
    public object toggle;

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
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A90F00
}

public class DualSenseHIDGenericInputReport : ValueType
{
    public object Format;

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFD54A782A0
}

public class DualSenseHIDMinimalInputReport : ValueType
{
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A90F50
    public void .cctor(){} // RVA: 0x7FFD54A90FA0
}

public class DualSenseHIDUSBInputReport : ValueType
{
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A90EB0
}

public class DualShock4HIDGenericInputReport : ValueType
{
    public object Format;

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
    public object HasNoElementsLeft;
    public object Current;
    public object System.Collections.IEnumerator.Current;

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
    public object SupportsDynamicPartitions;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E097970
    public void GetOrderableDynamicPartitions(){} // RVA: 0x7FFD4E078E90
    public void get_SupportsDynamicPartitions(){} // RVA: 0x7FFD4E079D00
}
