// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 87
// Methods: 260

public class DeviceJson : ValueType
{
    // ── Methods ──
    public void ToDeviceEntry(){} // RVA: 0x7FFE87923500
    public void From(){} // RVA: 0x7FFE87923590
}

public class DeviceLostEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE879D7C60
}

public class DeviceRegainedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE879D7CA0
}

public class DeviceRequirement : ValueType
{
    public string m_ControlPath; // 0x10
    public 0x6653FB74 m_Flags; // 0x18
    public object field_2; // 0xFEF8
    public object field_3;

    // ── Methods ──
    public void get_controlPath(){} // RVA: 0x7FFE8284EF60
    public void set_controlPath(){} // RVA: 0x7FFE81D7E9E0
    public void get_isOptional(){} // RVA: 0x7FFE87922840
    public void set_isOptional(){} // RVA: 0x7FFE87922850
    public void get_isAND(){} // RVA: 0x7FFE87922870
    public void set_isAND(){} // RVA: 0x7FFE87922880
    public void get_isOR(){} // RVA: 0x7FFE879228A0
    public void set_isOR(){} // RVA: 0x7FFE879228B0
    public void ToString(){} // RVA: 0x7FFE879228D0
    public void Equals(){} // RVA: 0x7FFE87922A70 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE87922B10
    public void op_Equality(){} // RVA: 0x7FFE87922BE0
    public void op_Inequality(){} // RVA: 0x7FFE87922C00
}

public class DeviceToFree : ValueType
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFE87E7EF20
}

public class DictationCompletedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811EC370
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class DictationErrorHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE9920
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class DictationHypothesisDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class DictationResultDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE9920
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class DictionaryEnumerator : Object
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<U,T>> _enumerator;
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,Microsoft.Extensions.Logging.ILogger>> _enumerator; // 0x10
    public object field_2; // 0x42C8
    public object field_3; // 0x9200

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Entry(){} // RVA: 0x7FFE80E2DCF0
    public void get_Key(){} // RVA: 0x7FFE80E2E2E0
    public void get_Value(){} // RVA: 0x7FFE80E2E2E0
    public void get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Reset(){} // RVA: 0x7FFE80E45FE0
}

public class DictionaryEnumerator`2 : ValueType
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<W,T>> _e;
    public object field_1; // 0xC4
    public object field_2; // 0xC5
    public object field_3; // 0xC6

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Entry(){} // RVA: 0x7FFE80E2DCF0
    public void get_Key(){} // RVA: 0x7FFE80E2E2E0
    public void get_Value(){} // RVA: 0x7FFE80E2E2E0
    public void get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Reset(){} // RVA: 0x7FFE80E45FE0
}

public class DictionaryIterator`2 : ValueType
{
    public System.Collections.Generic.Dictionary`2<U,T> dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void GetEnumerator(){} // RVA: 0x7FFE810A1420
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class DictionaryNode : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DictionaryPoolImpl`2 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class DictionaryValueIterator`2 : ValueType
{
    public System.Collections.Generic.Dictionary`2<U,T> dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void GetEnumerator(){} // RVA: 0x7FFE810A1420
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class DictionaryWrapper`1 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
}

public class DigStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89F83F60
    public void WriteByte(){} // RVA: 0x7FFE89F84000
    public void Write(){} // RVA: 0x7FFE89F84060
}

public class DigestAndSignerInfoGeneratorHolder : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.ISignerInfoGenerator signerInf; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void get_DigestAlgorithm(){} // RVA: 0x7FFE8A10A940
}

public class DigitsAndNullTerminator : ValueType
{
}

public class DirectParams : ValueType
{
}

public class DirectToArchiveWriterStream : Stream
{
    public long _position; // 0x28
    public System.IO.Compression.CheckSumAndSizeWriteStream _crcSizeStream; // 0x30
    public bool _everWritten; // 0x38
    public bool _isDisposed; // 0x39
    public System.IO.Compression.ZipArchiveEntry _entry; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87331840
    public void get_Length(){} // RVA: 0x7FFE87331960
    public void get_Position(){} // RVA: 0x7FFE873319C0
    public void set_Position(){} // RVA: 0x7FFE873319E0
    public void get_CanRead(){} // RVA: 0x7FFE810FB320
    public void get_CanSeek(){} // RVA: 0x7FFE810FB320
    public void get_CanWrite(){} // RVA: 0x7FFE820ED800
    public void ThrowIfDisposed(){} // RVA: 0x7FFE87331A40
    public void Read(){} // RVA: 0x7FFE87331AD0
    public void Seek(){} // RVA: 0x7FFE87331B30
    public void SetLength(){} // RVA: 0x7FFE87331B90
    public void Write(){} // RVA: 0x7FFE87331BF0
    public void Flush(){} // RVA: 0x7FFE87331DF0
    public void Dispose(){} // RVA: 0x7FFE87331E30
}

public class DirectionalStatus : ValueType
{
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

public class DisconnectMsg : Object
{
    // ── Methods ──
    public void Process(){} // RVA: 0x7FFE879AA850
}

public class Discord_FreeFn : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class Discord_RelationshipHandleSpan : ValueType
{
}

public class Discord_String : ValueType
{
}

public class DispatchContext : ValueType
{
}

public class DispatchEventQueueEvents : ValueType
{
}

public class Display : ATypeName
{
    public string displayName; // 0x10
    public string internal_name; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE848F76F0
    public void get_DisplayName(){} // RVA: 0x7FFE81116380
    public void get_InternalName(){} // RVA: 0x7FFE86A563A0
    public void GetInternalName(){} // RVA: 0x7FFE86A56510
}

public class DisplayNameOptions : ValueType
{
    public bool _fullName; // 0x10
    public bool _includeGenericParameterNames; // 0x11

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8114F2A0
    public void get_FullName(){} // RVA: 0x7FFE82BC9920
    public void get_IncludeGenericParameterNames(){} // RVA: 0x7FFE82BC9940
}

public class DisplayRefreshRateChangedData : ValueType
{
}

public class DisplaysUpdatedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class DisposableData : CriticalDisposableObject
{
    public System.IDisposable _accessor; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86E27620
    public void Release(){} // RVA: 0x7FFE86E277E0
    public void get_Pointer(){} // RVA: 0x7FFE811290C0
}

public class DisposableObserver : Object
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFE87A1F9B0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DisposeHandle : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Dispose(){} // RVA: 0x7FFE86EF4550
}

public class DisposeJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE878BD8C0
}

public class DisposingLoggerFactory : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void Dispose(){} // RVA: 0x7FFE866F3640
    public void CreateLogger(){} // RVA: 0x7FFE866F3680
    public void AddProvider(){} // RVA: 0x7FFE866F36E0
}

public class DivDouble : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87154380
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DivInt16 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87153A20
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DivInt32 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87153B80
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DivInt64 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87153CD0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DivSingle : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87154220
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DivUInt16 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87153E20
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DivUInt32 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87153F80
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DivUInt64 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871540D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class DnQualifier : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE867128B0
}

public class Domain : ApiModel
{
    public string _domain; // 0x68

    // ── Methods ──
    public void get_domain(){} // RVA: 0x7FFE81176D50
    public void set_domain(){} // RVA: 0x7FFE81176D60
    public void .ctor(){} // RVA: 0x7FFE8A2D8320
}

public class DomainComponent : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE867125C0
}

public class DoubleBuffers : ValueType
{
    public void** deviceToBufferMapping; // 0x10

    // ── Methods ──
    public void get_valid(){} // RVA: 0x7FFE8412EC80
    public void SetFrontBuffer(){} // RVA: 0x7FFE87A2C030
    public void SetBackBuffer(){} // RVA: 0x7FFE87A2C050
    public void GetFrontBuffer(){} // RVA: 0x7FFE87A2C070
    public void GetBackBuffer(){} // RVA: 0x7FFE87A2C090
    public void SwapBuffers(){} // RVA: 0x7FFE87A2C0B0
}

public class DoubleByteUnion : ValueType
{
}

public class DoubleHelper : Object
{
    // ── Methods ──
    public void Exponent(){} // RVA: 0x7FFE86E00470
    public void Mantissa(){} // RVA: 0x7FFE86E00490
}

public class DoubleInput : TextValueInput
{
    // ── Methods ──
    public void get_parentDoubleField(){} // RVA: 0x7FFE87E54D40
    public void .ctor(){} // RVA: 0x7FFE87E54DC0
    public void get_allowedCharacters(){} // RVA: 0x7FFE87E54F80
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87E54FE0
    public void ValueToString(){} // RVA: 0x7FFE87E551B0
    public void StringToValue(){} // RVA: 0x7FFE87E55250
}

public class DoublePoint : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AC4150 | overloaded x3
}

public class DownloadContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
}

public class DpadAxisControl : AxisControl
{
    public int _component; // 0x130

    // ── Methods ──
    public void get_component(){} // RVA: 0x7FFE8162C320
    public void set_component(){} // RVA: 0x7FFE879054D0
    public void FinishSetup(){} // RVA: 0x7FFE879054E0
    public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE879055D0
    public void .ctor(){} // RVA: 0x7FFE879056F0
}

public class DragPosition : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE87F1E910 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE87F1EA10
}

public class DrawStatistics : ValueType
{
}

public class Drone : Object
{
    // ── Methods ──
    public void get__GetDroneFromGameObject(){} // RVA: 0x7FFE8822F550
    public void set__GetDroneFromGameObject(){} // RVA: 0x7FFE8822F590
}

public class DroneSkinMap : DroneSkinMapCore
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class DropData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83BB2D90
}

public class DropdownEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87AED660
}

public class DropdownItem : MonoBehaviour
{
    public TMPro.TMP_Text m_Text; // 0x20
    public UnityEngine.UI.Image m_Image; // 0x28
    public UnityEngine.RectTransform m_RectTransform; // 0x30
    public UnityEngine.UI.Toggle m_Toggle; // 0x38

    // ── Methods ──
    public void get_text(){} // RVA: 0x7FFE811290C0
    public void set_text(){} // RVA: 0x7FFE811290D0
    public void get_image(){} // RVA: 0x7FFE81129130
    public void set_image(){} // RVA: 0x7FFE810FCE90
    public void get_rectTransform(){} // RVA: 0x7FFE8144E200
    public void set_rectTransform(){} // RVA: 0x7FFE81129890
    public void get_toggle(){} // RVA: 0x7FFE8143BA80
    public void set_toggle(){} // RVA: 0x7FFE81437330
    public void OnPointerEnter(){} // RVA: 0x7FFE87AED400
    public void OnCancel(){} // RVA: 0x7FFE87AED4B0
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class DtdDefaultAttributeInfoToNodeDataComparer : Object
{
    public System.Collections.Generic.IComparer`1<object> s_instance;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7FFE87568DE0
    public void Compare(){} // RVA: 0x7FFE87568E40
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE875691B0
}

public class DtdParserProxy : Object
{
    public System.Xml.XmlTextReaderImpl reader; // 0x10
    public object field_1; // 0x119
    public object field_2; // 0x11A
    public object field_3; // 0x11B
    public object field_4; // 0x11C
    public object field_5; // 0x11D
    public object field_6; // 0x11E
    public object field_7; // 0x11F
    public object field_8; // 0x120
    public object field_9; // 0x121
    public object field_10; // 0x122
    public object field_11; // 0x123
    public object field_12; // 0x124
    public object field_13; // 0x125
    public object field_14; // 0x126
    public object field_15; // 0x127

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void System.Xml.IDtdParserAdapter.get_NameTable(){} // RVA: 0x7FFE81CDDE10
    public void System.Xml.IDtdParserAdapter.get_NamespaceResolver(){} // RVA: 0x7FFE81C8FCB0
    public void System.Xml.IDtdParserAdapter.get_BaseUri(){} // RVA: 0x7FFE87567210
    public void System.Xml.IDtdParserAdapter.get_IsEof(){} // RVA: 0x7FFE829BF150
    public void System.Xml.IDtdParserAdapter.get_ParsingBuffer(){} // RVA: 0x7FFE8189B9F0
    public void System.Xml.IDtdParserAdapter.get_ParsingBufferLength(){} // RVA: 0x7FFE875672D0
    public void System.Xml.IDtdParserAdapter.get_CurrentPosition(){} // RVA: 0x7FFE875672F0
    public void System.Xml.IDtdParserAdapter.set_CurrentPosition(){} // RVA: 0x7FFE87567310
    public void System.Xml.IDtdParserAdapter.get_EntityStackLength(){} // RVA: 0x7FFE87567330
    public void System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized(){} // RVA: 0x7FFE87567350
    public void System.Xml.IDtdParserAdapter.OnNewLine(){} // RVA: 0x7FFE87567370
    public void System.Xml.IDtdParserAdapter.get_LineNo(){} // RVA: 0x7FFE82B6F020
    public void System.Xml.IDtdParserAdapter.get_LineStartPosition(){} // RVA: 0x7FFE875673A0
    public void System.Xml.IDtdParserAdapter.ReadData(){} // RVA: 0x7FFE875673C0
    public void System.Xml.IDtdParserAdapter.ParseNumericCharRef(){} // RVA: 0x7FFE875673E0
    public void System.Xml.IDtdParserAdapter.ParseNamedCharRef(){} // RVA: 0x7FFE875674B0
    public void System.Xml.IDtdParserAdapter.ParsePI(){} // RVA: 0x7FFE875674D0
    public void System.Xml.IDtdParserAdapter.ParseComment(){} // RVA: 0x7FFE87567530
    public void System.Xml.IDtdParserAdapter.PushEntity(){} // RVA: 0x7FFE87567550
    public void System.Xml.IDtdParserAdapter.PopEntity(){} // RVA: 0x7FFE87567630
    public void System.Xml.IDtdParserAdapter.PushExternalSubset(){} // RVA: 0x7FFE87567740
    public void System.Xml.IDtdParserAdapter.PushInternalDtd(){} // RVA: 0x7FFE875678D0
    public void System.Xml.IDtdParserAdapter.Throw(){} // RVA: 0x7FFE875679C0
    public void System.Xml.IDtdParserAdapter.OnSystemId(){} // RVA: 0x7FFE875679F0
    public void System.Xml.IDtdParserAdapter.OnPublicId(){} // RVA: 0x7FFE87567AE0
    public void System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation(){} // RVA: 0x7FFE87567BD0
    public void System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling(){} // RVA: 0x7FFE87567C00
    public void System.Xml.IDtdParserAdapterV1.get_Normalization(){} // RVA: 0x7FFE87566860
    public void System.Xml.IDtdParserAdapterV1.get_Namespaces(){} // RVA: 0x7FFE81D3A2A0
    public void System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode(){} // RVA: 0x7FFE81D38340
}

public class DualSenseHIDBluetoothInputReport : ValueType
{
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFE87A19660
}

public class DualSenseHIDGenericInputReport : ValueType
{
    public byte reportId; // 0x10

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFE87A00A00
}

public class DualSenseHIDMinimalInputReport : ValueType
{
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFE87A196B0
    public void .cctor(){} // RVA: 0x7FFE87A19700
}

public class DualSenseHIDUSBInputReport : ValueType
{
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFE87A19610
}

public class DualShock4HIDGenericInputReport : ValueType
{
    public byte leftStickX; // 0x10

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFE87A00A00
    public void ToHIDInputReport(){} // RVA: 0x7FFE87A1A720
}

public class DummyJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE810FB310
}

public class DynamicBone : MonoBehaviour
{
    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFE812846D0
    public void RaiseCancellation(){} // RVA: 0x7FFE81284A60
    public void IsInvoking(){} // RVA: 0x7FFE81284EA0
    public void OnDisable(){} // RVA: 0x7FFE81285190
    public void Invoke(){} // RVA: 0x7FFE812851D0
    public void .ctor(){} // RVA: 0x7FFE81285250
    public void Initialize(){} // RVA: 0x7FFE81285510
    public void OnBecameVisible(){} // RVA: 0x7FFE81285950
    public void StartCoroutine(){} // RVA: 0x7FFE81286770
    public void OnCollisionEnter(){} // RVA: 0x7FFE812867A0
    public void OnCollisionStay(){} // RVA: 0x7FFE81287250
    public void StartCoroutine_Auto(){} // RVA: 0x7FFE812875E0
    public void StopCoroutine(){} // RVA: 0x7FFE81287A30
    public void OnTriggerStay(){} // RVA: 0x7FFE81287F10
    public void OnTriggerExit(){} // RVA: 0x7FFE812881E0
    public void StopAllCoroutines(){} // RVA: 0x7FFE812882D0
    public void OnValidate(){} // RVA: 0x7FFE81289250
    public void set_useGUILayout(){} // RVA: 0x7FFE81289330
    public void print(){} // RVA: 0x7FFE81289770
    public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE812897C0
    public void Internal_IsInvokingAll(){} // RVA: 0x7FFE81289EC0
    public void InvokeDelayed(){} // RVA: 0x7FFE8128A670
    public void CancelInvoke(){} // RVA: 0x7FFE8128AAB0
    public void OnEnable(){} // RVA: 0x7FFE8128AB50
    public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8128AB90
    public void StartCoroutineManaged(){} // RVA: 0x7FFE8128AFD0
}

public class DynamicBoneCollider : MonoBehaviour
{
    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFE8128C010
    public void RaiseCancellation(){} // RVA: 0x7FFE8128C800
    public void IsInvoking(){} // RVA: 0x7FFE8128CFF0
    public void OnDrawGizmosSelected(){} // RVA: 0x7FFE8128D100
    public void OnValidate(){} // RVA: 0x7FFE8128D6E0
    public void InvokeRepeating(){} // RVA: 0x7FFE8128D710
    public void CancelInvoke(){} // RVA: 0x7FFE8128D9D0
    public void StartCoroutine(){} // RVA: 0x7FFE8128DB10
    public void OnEnable(){} // RVA: 0x7FFE8128DB10
    public void OnDisable(){} // RVA: 0x7FFE8128DB10
    public void StartCoroutine_Auto(){} // RVA: 0x7FFE8128DC10
    public void StopCoroutine(){} // RVA: 0x7FFE8128E360
    public void .ctor_16862B8D4B67(){} // RVA: 0x7FFE8128EB60
    public void .ctor(){} // RVA: 0x7FFE8128EE40
    public void Initialize(){} // RVA: 0x7FFE8128EED0
    // ── Unresolved (hash) ──
    public void m_33C(){} // RVA: 0x7FFE8128DA00
}

public class DynamicBoneColliderData : ValueType
{
}

public class DynamicBoneData : ValueType
{
}

public class DynamicPartitionEnumerator_Abstract`2 : Object
{
    public T _sharedReader;
    public int s_defaultMaxChunkSize;
    public SharedInt _currentChunkSize;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void GrabNextChunk(){} // RVA: 0x7FFE80E2F760
    public void get_HasNoElementsLeft(){} // RVA: 0x7FFE80E2F150
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void Reset(){} // RVA: 0x7FFE80E45FE0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class DynamicPartitionerForIEnumerable`1 : OrderablePartitioner`1
{
    public System.Collections.Generic.IEnumerable`1<T> _source;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4D070
    public void GetOrderableDynamicPartitions(){} // RVA: 0x7FFE80E2E2E0
    public void get_SupportsDynamicPartitions(){} // RVA: 0x7FFE80E2F150
}

public class DynamicPropertyReg : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}
