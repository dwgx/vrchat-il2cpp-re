// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 86
// Methods: 250

public class DeviceLostEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC962F520
}

public class DeviceRegainedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC962F560
}

public class DeviceRequirement : ValueType
{
    public string controlPath; // 0x10
    public 0x6B146C50 isOptional; // 0x18

    // ── Methods ──
    public void get_controlPath(){} // RVA: 0x7FFAC3AD9F60
    public void set_controlPath(){} // RVA: 0x7FFAC38DFE40
    public void get_isOptional(){} // RVA: 0x7FFAC957A100
    public void set_isOptional(){} // RVA: 0x7FFAC957A110
    public void get_isAND(){} // RVA: 0x7FFAC957A130
    public void set_isAND(){} // RVA: 0x7FFAC957A140
    public void get_isOR(){} // RVA: 0x7FFAC957A160
    public void set_isOR(){} // RVA: 0x7FFAC957A170
    public void ToString(){} // RVA: 0x7FFAC957A190
    public void Equals(){} // RVA: 0x7FFAC957A330 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC957A3D0
    public void op_Equality(){} // RVA: 0x7FFAC957A4A0
    public void op_Inequality(){} // RVA: 0x7FFAC957A4C0
}

public class DeviceToFree : ValueType
{
    public uint handle; // 0x10
    public UnityEngine.UIElements.UIR.Page page; // 0x18

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC9AD6680
}

public class DictationCompletedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class DictationErrorHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DE20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class DictationHypothesisDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class DictationResultDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DE20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class DictionaryEnumerator : Object
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type>> _enumerator; // 0x10
}

public class DictionaryEnumerator`2 : ValueType
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<W,T>> Entry;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Entry(){} // RVA: 0x7FFAC2C588A0
    public void get_Key(){} // RVA: 0x7FFAC2C58E90
    public void get_Value(){} // RVA: 0x7FFAC2C58E90
    public void get_Current(){} // RVA: 0x7FFAC2C58E90
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Reset(){} // RVA: 0x7FFAC2C70980
}

public class DictionaryIterator`2 : ValueType
{
    public System.Collections.Generic.Dictionary`2<U,T> Current;
    public Enumerator<U,T> enumerator;
    public bool isNull;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class DictionaryNode : Object
{
    public object key; // 0x10
    public object value; // 0x18
    public DictionaryNode next; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DictionaryPoolImpl`2 : Object
{
    public VRC.Core.Pool.ObjectPool`1<System.Collections.Generic.Dictionary`2<U,T>> Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class DictionaryValueIterator`2 : ValueType
{
    public System.Collections.Generic.Dictionary`2<U,T> Current;
    public Enumerator<U,T> enumerator;
    public bool isNull;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class DictionaryWrapper`1 : ValueType
{
    public System.Collections.Generic.IReadOnlyDictionary`2<string,T> Dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class DigStream : BaseOutputStream
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest d; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBB2A940
    public void WriteByte(){} // RVA: 0x7FFACBB2A9E0
    public void Write(){} // RVA: 0x7FFACBB2AA40
}

public class DigestAndSignerInfoGeneratorHolder : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.ISignerInfoGenerator DigestAlgorithm; // 0x10
    public string digestOID; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void get_DigestAlgorithm(){} // RVA: 0x7FFACBCB1320
}

public class DigitsAndNullTerminator : ValueType
{
}

public class DirectParams : ValueType
{
    public float x0; // 0x10
    public float y0; // 0x14
    public float x1; // 0x18
    public float y1; // 0x1C
    public float W; // 0x20
    public float overshootX; // 0x24
    public float overshootY; // 0x28
    public float gamma; // 0x2C
}

public class DirectToArchiveWriterStream : Stream
{
    public long Length; // 0x28
    public System.IO.Compression.CheckSumAndSizeWriteStream Position; // 0x30
    public bool CanRead; // 0x38
    public bool CanSeek; // 0x39
    public System.IO.Compression.ZipArchiveEntry CanWrite; // 0x40
    public bool _usedZip64inLH; // 0x48
    public bool _canWrite; // 0x49

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8F89420
    public void get_Length(){} // RVA: 0x7FFAC8F89540
    public void get_Position(){} // RVA: 0x7FFAC8F895A0
    public void set_Position(){} // RVA: 0x7FFAC8F895C0
    public void get_CanRead(){} // RVA: 0x7FFAC2F21320
    public void get_CanSeek(){} // RVA: 0x7FFAC2F21320
    public void get_CanWrite(){} // RVA: 0x7FFAC3E0F350
    public void ThrowIfDisposed(){} // RVA: 0x7FFAC8F89620
    public void Read(){} // RVA: 0x7FFAC8F896B0
    public void Seek(){} // RVA: 0x7FFAC8F89710
    public void SetLength(){} // RVA: 0x7FFAC8F89770
    public void Write(){} // RVA: 0x7FFAC8F897D0
    public void Flush(){} // RVA: 0x7FFAC8F899D0
    public void Dispose(){} // RVA: 0x7FFAC8F89A10
}

public class DirectionalStatus : ValueType
{
    public byte paragraphEmbeddingLevel; // 0x10
    public byte directionalOverrideStatus; // 0x11
    public bool directionalIsolateStatus; // 0x12
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
    public void Process(){} // RVA: 0x7FFAC9602110
}

public class Discord_FreeFn : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class Discord_RelationshipHandleSpan : ValueType
{
    public RelationshipHandle* ptr; // 0x10
    public object size; // 0x18
}

public class Discord_String : ValueType
{
    public byte* ptr; // 0x10
    public object size; // 0x18
}

public class DispatchContext : ValueType
{
    public uint m_GateCount; // 0x10
    public System.Collections.Generic.Queue`1<EventRecord> m_Queue; // 0x18
}

public class DispatchEventQueueEvents : ValueType
{
}

public class Display : ATypeName
{
    public string DisplayName; // 0x10
    public string InternalName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC65A7C60
    public void get_DisplayName(){} // RVA: 0x7FFAC2F3C380
    public void get_InternalName(){} // RVA: 0x7FFAC86ACBF0
    public void GetInternalName(){} // RVA: 0x7FFAC86ACD60
}

public class DisplayNameOptions : ValueType
{
    public bool FullName; // 0x10
    public bool IncludeGenericParameterNames; // 0x11

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F752A0
    public void get_FullName(){} // RVA: 0x7FFAC495DDF0
    public void get_IncludeGenericParameterNames(){} // RVA: 0x7FFAC495DE10
}

public class DisplayRefreshRateChangedData : ValueType
{
    public float FromRefreshRate; // 0x10
    public float ToRefreshRate; // 0x14
}

public class DisplaysUpdatedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class DisposableData : CriticalDisposableObject
{
    public System.IDisposable Pointer; // 0x10
    public System.Runtime.InteropServices.SafeBuffer _safeBuffer; // 0x18
    public byte* _pointer; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8A7DF90
    public void Release(){} // RVA: 0x7FFAC8A7E150
    public void get_Pointer(){} // RVA: 0x7FFAC2F4F0C0
}

public class DisposableObserver : Object
{
    public System.IObserver`1<UnityEngine.InputSystem.LowLevel.InputEventPtr> observer; // 0x10

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC9677250
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DisposeHandle : Object
{
    public Sentry.IHub _localHub; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Dispose(){} // RVA: 0x7FFAC8B4AEE0
}

public class DisposeJob : ValueType
{
    public Unity.Collections.LowLevel.Unsafe.UnsafeStream Container; // 0x10

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9515180
}

public class DisposingLoggerFactory : Object
{
    public Microsoft.Extensions.Logging.ILoggerFactory _loggerFactory; // 0x10
    public Microsoft.Extensions.DependencyInjection.ServiceProvider _serviceProvider; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void Dispose(){} // RVA: 0x7FFAC8349D40
    public void CreateLogger(){} // RVA: 0x7FFAC8349D80
    public void AddProvider(){} // RVA: 0x7FFAC8349DE0
}

public class DivDouble : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DABF50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DivInt16 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAB5F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DivInt32 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAB750
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DivInt64 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAB8A0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DivSingle : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DABDF0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DivUInt16 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAB9F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DivUInt32 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DABB50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DivUInt64 : DivInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DABCA0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class DnQualifier : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368FB0
}

public class Domain : ApiModel
{
    public string domain; // 0x68

    // ── Methods ──
    public void get_domain(){} // RVA: 0x7FFAC2F9CD50
    public void set_domain(){} // RVA: 0x7FFAC2F9CD60
    public void .ctor(){} // RVA: 0x7FFACBE794D0
}

public class DomainComponent : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368CC0
}

public class DoubleBuffers : ValueType
{
    public void** valid; // 0x10
    public int deviceCount; // 0x18

    // ── Methods ──
    public void get_valid(){} // RVA: 0x7FFAC5DC6CA0
    public void SetFrontBuffer(){} // RVA: 0x7FFAC96838D0
    public void SetBackBuffer(){} // RVA: 0x7FFAC96838F0
    public void GetFrontBuffer(){} // RVA: 0x7FFAC9683910
    public void GetBackBuffer(){} // RVA: 0x7FFAC9683930
    public void SwapBuffers(){} // RVA: 0x7FFAC9683950
}

public class DoubleByteUnion : ValueType
{
    public byte Byte0; // 0x10
    public byte Byte1; // 0x11
    public byte Byte2; // 0x12
    public byte Byte3; // 0x13
    public byte Byte4; // 0x14
    public byte Byte5; // 0x15
    public byte Byte6; // 0x16
    public byte Byte7; // 0x17
    public double Value; // 0x10
}

public class DoubleHelper : Object
{
    // ── Methods ──
    public void Exponent(){} // RVA: 0x7FFAC8A56DE0
    public void Mantissa(){} // RVA: 0x7FFAC8A56E00
}

public class DoubleInput : TextValueInput
{
    public object parentDoubleField;
    public object allowedCharacters;

    // ── Methods ──
    public void get_parentDoubleField(){} // RVA: 0x7FFAC9AAC4A0
    public void .ctor(){} // RVA: 0x7FFAC9AAC520
    public void get_allowedCharacters(){} // RVA: 0x7FFAC9AAC6E0
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9AAC740
    public void ValueToString(){} // RVA: 0x7FFAC9AAC910
    public void StringToValue(){} // RVA: 0x7FFAC9AAC9B0
}

public class DoublePoint : ValueType
{
    public double X; // 0x10
    public double Y; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC485BDB0 | overloaded x3
}

public class DownloadContext : Object
{
    public System.Action`1<byte[]> OnSuccess; // 0x10
    public System.Action`1<string> OnError; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
}

public class DpadAxisControl : AxisControl
{
    public int component; // 0x130

    // ── Methods ──
    public void get_component(){} // RVA: 0x7FFAC33BC1B0
    public void set_component(){} // RVA: 0x7FFAC955CD90
    public void FinishSetup(){} // RVA: 0x7FFAC955CDA0
    public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC955CE90
    public void .ctor(){} // RVA: 0x7FFAC955CFB0
}

public class DragPosition : ValueType
{
    public int insertAtIndex; // 0x10
    public int parentId; // 0x14
    public int childIndex; // 0x18
    public UnityEngine.UIElements.ReusableCollectionItem recycledItem; // 0x20
    public 0x6B11A938 dropPosition; // 0x28

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC9B76070 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC9B76170
}

public class DrawStatistics : ValueType
{
    public int currentFrameIndex; // 0x10
    public uint totalIndices; // 0x14
    public uint commandCount; // 0x18
    public uint drawCommandCount; // 0x1C
    public uint materialSetCount; // 0x20
    public uint drawRangeCount; // 0x24
    public uint drawRangeCallCount; // 0x28
    public uint immediateDraws; // 0x2C
    public uint stencilRefChanges; // 0x30
}

public class Drone : Object
{
    public object _GetDroneFromGameObject;

    // ── Methods ──
    public void get__GetDroneFromGameObject(){} // RVA: 0x7FFAC9E7CAC0
    public void set__GetDroneFromGameObject(){} // RVA: 0x7FFAC9E7CB00
}

public class DroneSkinMap : DroneSkinMapCore
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class DropData : Object
{
    public int[] expandedIdsBeforeDrag; // 0x10
    public int[] draggedIds; // 0x18
    public int lastItemId; // 0x20
    public float expandItemBeginTimerMs; // 0x24
    public UnityEngine.Vector2 expandItemBeginPosition; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5875C30
}

public class DropdownEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97450F0
}

public class DropdownItem : MonoBehaviour
{
    public TMPro.TMP_Text text; // 0x20
    public UnityEngine.UI.Image image; // 0x28
    public UnityEngine.RectTransform rectTransform; // 0x30
    public UnityEngine.UI.Toggle toggle; // 0x38

    // ── Methods ──
    public void get_text(){} // RVA: 0x7FFAC2F4F0C0
    public void set_text(){} // RVA: 0x7FFAC2F4F0D0
    public void get_image(){} // RVA: 0x7FFAC2F4F130
    public void set_image(){} // RVA: 0x7FFAC2F22E90
    public void get_rectTransform(){} // RVA: 0x7FFAC31D95E0
    public void set_rectTransform(){} // RVA: 0x7FFAC2F4F890
    public void get_toggle(){} // RVA: 0x7FFAC31D0140
    public void set_toggle(){} // RVA: 0x7FFAC31D0C20
    public void OnPointerEnter(){} // RVA: 0x7FFAC9744E90
    public void OnCancel(){} // RVA: 0x7FFAC9744F40
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class DtdDefaultAttributeInfoToNodeDataComparer : Object
{
    public System.Collections.Generic.IComparer`1<object> Instance;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7FFAC91C0670
    public void Compare(){} // RVA: 0x7FFAC91C06D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC91C0A40
}

public class DtdParserProxy : Object
{
    public System.Xml.XmlTextReaderImpl System.Xml.IDtdParserAdapter.NameTable; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void System.Xml.IDtdParserAdapter.get_NameTable(){} // RVA: 0x7FFAC3523400
    public void System.Xml.IDtdParserAdapter.get_NamespaceResolver(){} // RVA: 0x7FFAC34D4740
    public void System.Xml.IDtdParserAdapter.get_BaseUri(){} // RVA: 0x7FFAC91BEA80
    public void System.Xml.IDtdParserAdapter.get_IsEof(){} // RVA: 0x7FFAC46B5320
    public void System.Xml.IDtdParserAdapter.get_ParsingBuffer(){} // RVA: 0x7FFAC3773190
    public void System.Xml.IDtdParserAdapter.get_ParsingBufferLength(){} // RVA: 0x7FFAC91BEB40
    public void System.Xml.IDtdParserAdapter.get_CurrentPosition(){} // RVA: 0x7FFAC91BEB60
    public void System.Xml.IDtdParserAdapter.set_CurrentPosition(){} // RVA: 0x7FFAC91BEB80
    public void System.Xml.IDtdParserAdapter.get_EntityStackLength(){} // RVA: 0x7FFAC91BEBA0
    public void System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized(){} // RVA: 0x7FFAC91BEBC0
    public void System.Xml.IDtdParserAdapter.OnNewLine(){} // RVA: 0x7FFAC91BEBE0
    public void System.Xml.IDtdParserAdapter.get_LineNo(){} // RVA: 0x7FFAC4907130
    public void System.Xml.IDtdParserAdapter.get_LineStartPosition(){} // RVA: 0x7FFAC91BEC10
    public void System.Xml.IDtdParserAdapter.ReadData(){} // RVA: 0x7FFAC91BEC30
    public void System.Xml.IDtdParserAdapter.ParseNumericCharRef(){} // RVA: 0x7FFAC91BEC50
    public void System.Xml.IDtdParserAdapter.ParseNamedCharRef(){} // RVA: 0x7FFAC91BED20
    public void System.Xml.IDtdParserAdapter.ParsePI(){} // RVA: 0x7FFAC91BED40
    public void System.Xml.IDtdParserAdapter.ParseComment(){} // RVA: 0x7FFAC91BEDA0
    public void System.Xml.IDtdParserAdapter.PushEntity(){} // RVA: 0x7FFAC91BEDC0
    public void System.Xml.IDtdParserAdapter.PopEntity(){} // RVA: 0x7FFAC91BEEA0
    public void System.Xml.IDtdParserAdapter.PushExternalSubset(){} // RVA: 0x7FFAC91BEFB0
    public void System.Xml.IDtdParserAdapter.PushInternalDtd(){} // RVA: 0x7FFAC91BF140
    public void System.Xml.IDtdParserAdapter.Throw(){} // RVA: 0x7FFAC91BF230
    public void System.Xml.IDtdParserAdapter.OnSystemId(){} // RVA: 0x7FFAC91BF260
    public void System.Xml.IDtdParserAdapter.OnPublicId(){} // RVA: 0x7FFAC91BF350
    public void System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation(){} // RVA: 0x7FFAC91BF440
    public void System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling(){} // RVA: 0x7FFAC91BF470
    public void System.Xml.IDtdParserAdapterV1.get_Normalization(){} // RVA: 0x7FFAC91BE0D0
    public void System.Xml.IDtdParserAdapterV1.get_Namespaces(){} // RVA: 0x7FFAC91BE0B0
    public void System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode(){} // RVA: 0x7FFAC91BF490
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
    public void ToHIDInputReport(){} // RVA: 0x7FFAC9670F00
}

public class DualSenseHIDGenericInputReport : ValueType
{
    public byte Format; // 0x10

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFAC96582A0
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
    public void ToHIDInputReport(){} // RVA: 0x7FFAC9670F50
    public void .cctor(){} // RVA: 0x7FFAC9670FA0
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
    public void ToHIDInputReport(){} // RVA: 0x7FFAC9670EB0
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
    public void get_Format(){} // RVA: 0x7FFAC96582A0
    public void ToHIDInputReport(){} // RVA: 0x7FFAC9671FC0
}

public class DummyJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC2F21310
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
    public 0x6AFE7438 m_FreezeAxis; // 0xC0
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
    public void get_destroyCancellationToken(){} // RVA: 0x7FFAC30A60E0
    public void RaiseCancellation(){} // RVA: 0x7FFAC30A6130
    public void IsInvoking(){} // RVA: 0x7FFAC30A6570
    public void CancelInvoke(){} // RVA: 0x7FFAC30A6A50
    public void Invoke(){} // RVA: 0x7FFAC30A7200
    public void InvokeRepeating(){} // RVA: 0x7FFAC30A72A0
    public void AccessdeltaTime(){} // RVA: 0x7FFAC30A80C0
    public void GetTrackingOriginMode(){} // RVA: 0x7FFAC30A8370
    public void StartCoroutine(){} // RVA: 0x7FFAC30A8640
    public void OnEnable(){} // RVA: 0x7FFAC30A8930
    public void Start(){} // RVA: 0x7FFAC30A8970
    public void .ctor(){} // RVA: 0x7FFAC30A9070
    public void Initialize(){} // RVA: 0x7FFAC30A9330
    public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC30AA140
    public void StopCoroutine(){} // RVA: 0x7FFAC30AA580
    public void StopAllCoroutines(){} // RVA: 0x7FFAC30AA870
    public void get_useGUILayout(){} // RVA: 0x7FFAC30AACB0
    public void set_useGUILayout(){} // RVA: 0x7FFAC30AAD30
    public void print(){} // RVA: 0x7FFAC30AAD60
    public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC30AB810
    public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC30AB8B0
    public void InvokeDelayed(){} // RVA: 0x7FFAC30ABD00
    public void OnDisable(){} // RVA: 0x7FFAC30AC4E0
    public void OnDestroy(){} // RVA: 0x7FFAC30AC520
    public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC30AC8B0
    public void OnValidate(){} // RVA: 0x7FFAC30ACCF0
    public void StartCoroutineManaged2(){} // RVA: 0x7FFAC30ACDD0
}

public class DynamicBoneCollider : MonoBehaviour
{
    public UnityEngine.Vector3 m_Center; // 0x20
    public float m_Radius; // 0x2C
    public float m_Height; // 0x30
    public 0x6AFE7598 m_Direction; // 0x34
    public 0x6AFE75F0 m_Bound; // 0x38

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFAC30AE380
    public void RaiseCancellation(){} // RVA: 0x7FFAC30AE480
    public void .ctor(){} // RVA: 0x7FFAC30AE760
    public void Initialize(){} // RVA: 0x7FFAC30AE7F0
    public void OnValidate(){} // RVA: 0x7FFAC30AE900
    public void InvokeRepeating(){} // RVA: 0x7FFAC30AE380
    public void CancelInvoke(){} // RVA: 0x7FFAC30AE930
    public void IsInvoking(){} // RVA: 0x7FFAC30AEC10
    public void StartCoroutine(){} // RVA: 0x7FFAC30AF350
    public void AdjustPointForCollision(){} // RVA: 0x7FFAC30AF380
    public void AccesslossyScale_Injected(){} // RVA: 0x7FFAC30AF490
    public void StartCoroutine_Auto(){} // RVA: 0x7FFAC30AFBE0
    public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC30AFEA0
    public void StopCoroutine(){} // RVA: 0x7FFAC30B0480
}

public class DynamicBoneColliderData : ValueType
{
    public UnityEngine.GameObject gameObject; // 0x10
    public 0x6B2DCDE0 bound; // 0x18
    public float radius; // 0x1C
    public float height; // 0x20
    public UnityEngine.Vector3 center; // 0x24
    public 0x6B2DCE38 direction; // 0x30
}

public class DynamicBoneData : ValueType
{
    public UnityEngine.GameObject gameObject; // 0x10
    public bool enabled; // 0x18
    public UnityEngine.Transform root; // 0x20
    public System.Collections.Generic.List`1<UnityEngine.Transform> exclusions; // 0x28
    public float endLength; // 0x30
    public UnityEngine.Vector3 endOffset; // 0x34
    public float elasticity; // 0x40
    public UnityEngine.AnimationCurve elasticityDistrib; // 0x48
    public float damping; // 0x50
    public UnityEngine.AnimationCurve dampingDistrib; // 0x58
    public float inert; // 0x60
    public UnityEngine.AnimationCurve inertDistrib; // 0x68
    public float radius; // 0x70
    public UnityEngine.AnimationCurve radiusDistrib; // 0x78
    public 0x6B2DCD30 freezeAxis; // 0x80
    public float stiffness; // 0x84
    public UnityEngine.AnimationCurve stiffnessDistrib; // 0x88
    public UnityEngine.Vector3 gravity; // 0x90
    public UnityEngine.Vector3 force; // 0x9C
    public System.Collections.Generic.List`1<int> colliders; // 0xA8
    public VRC.SDK3.Dynamics.PhysBone.Components.VRCPhysBone physBone; // 0xB0
}

public class DynamicPartitionEnumerator_Abstract`2 : Object
{
    public T HasNoElementsLeft;
    public int Current;
    public SharedInt System.Collections.IEnumerator.Current;
    public SharedInt _localOffset;
    public int _doublingCountdown;
    public int _maxChunkSize;
    public SharedLong _sharedIndex;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void GrabNextChunk(){} // RVA: 0x7FFAC2C5A310
    public void get_HasNoElementsLeft(){} // RVA: 0x7FFAC2C59D00
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class DynamicPartitionerForIEnumerable`1 : OrderablePartitioner`1
{
    public System.Collections.Generic.IEnumerable`1<T> SupportsDynamicPartitions;
    public bool _useSingleChunking;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C77970
    public void GetOrderableDynamicPartitions(){} // RVA: 0x7FFAC2C58E90
    public void get_SupportsDynamicPartitions(){} // RVA: 0x7FFAC2C59D00
}

public class DynamicPropertyReg : Object
{
    public System.Runtime.Remoting.Contexts.IDynamicProperty Property; // 0x10
    public System.Runtime.Remoting.Contexts.IDynamicMessageSink Sink; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}
