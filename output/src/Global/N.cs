// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 603

public class NameObjectEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
}

public class NameObjectKeysEnumerator : Object
{
    public int _pos; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE877FE510
    public void MoveNext(){} // RVA: 0x7FFE877FE590
    public void Reset(){} // RVA: 0x7FFE877FE670
    public void get_Current(){} // RVA: 0x7FFE877FE700
}

public class NamePart : Object
{
    public Google.Protobuf.MessageParser`1<NamePart> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public string NamePart_DefaultValue; // 0x8
    public string namePart_; // 0x20
    public bool IsExtensionDefaultValue; // 0x10
    public bool isExtension_; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE865B86A0
    public void get_Descriptor(){} // RVA: 0x7FFE865B8700
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865B8780
    public void .ctor(){} // RVA: 0x7FFE865B8830 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE865B89A0
    public void get_NamePart_(){} // RVA: 0x7FFE865B8B40
    public void set_NamePart_(){} // RVA: 0x7FFE865B8BB0
    public void get_HasNamePart_(){} // RVA: 0x7FFE82BC81D0
    public void ClearNamePart_(){} // RVA: 0x7FFE86597DC0
    public void get_IsExtension(){} // RVA: 0x7FFE865B8CB0
    public void set_IsExtension(){} // RVA: 0x7FFE865B8D20
    public void get_HasIsExtension(){} // RVA: 0x7FFE8659D0B0
    public void ClearIsExtension(){} // RVA: 0x7FFE8659D0C0
    public void Equals(){} // RVA: 0x7FFE865B8E60 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE865B8F60
    public void ToString(){} // RVA: 0x7FFE865B9030
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865B9080
    public void CalculateSize(){} // RVA: 0x7FFE865B9110
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE865B92D0
    public void .cctor(){} // RVA: 0x7FFE865B93A0
}

public class NameType : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void CompareTo(){} // RVA: 0x7FFE8727BD50
}

public class Namespace : ValueType
{
    // ── Methods ──
    public void Set(){} // RVA: 0x7FFE8756FA40
}

public class NamespaceDecl : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8743C7D0
}

public class NamespaceDeclaration : ValueType
{
    // ── Methods ──
    public void Set(){} // RVA: 0x7FFE875CE8B0
}

public class NamespaceManager : XmlNamespaceManager
{
    // ── Methods ──
    public void LookupNamespace(){} // RVA: 0x7FFE82153650
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NamespacePrefixForQName : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A69440
    public void LookupNamespace(){} // RVA: 0x7FFE874DE1D0
    public void LookupPrefix(){} // RVA: 0x7FFE874DE230
    public void GetNamespacesInScope(){} // RVA: 0x7FFE874DE290
}

public class NamespaceResolverProxy : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFE8757EBA0
    public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFE8757EBE0
    public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFE8757EC00
}

public class Native : ValueType
{
    // ── Methods ──
    public void IsChangedTracks(){} // RVA: 0x7FFE82A425B0
    public void GetTrackCount(){} // RVA: 0x7FFE82A42640
    public void GetTrackInfo(){} // RVA: 0x7FFE82A426D0
    public void SetActiveTrack(){} // RVA: 0x7FFE82A42840
    public void IsChangedTextCue(){} // RVA: 0x7FFE82A428E0
    public void GetCurrentTextCue(){} // RVA: 0x7FFE82A42960
    public void GetTimeRanges(){} // RVA: 0x7FFE82A429E0
    public void Init(){} // RVA: 0x7FFE82A42B10
    public void Deinit(){} // RVA: 0x7FFE82A42B90
    public void GetPluginVersion(){} // RVA: 0x7FFE82A42C00
    public void IsTrialVersion(){} // RVA: 0x7FFE82A42C70
    public void BeginOpenSource(){} // RVA: 0x7FFE82A42CE0
    public void EndOpenSource(){} // RVA: 0x7FFE82A42E70
    public void OpenSourceFromBuffer(){} // RVA: 0x7FFE82A42F10
    public void StartOpenSourceFromBuffer(){} // RVA: 0x7FFE82A430C0
    public void AddChunkToSourceBuffer(){} // RVA: 0x7FFE82A43160
    public void EndOpenSourceFromBuffer(){} // RVA: 0x7FFE82A43220
    public void CloseSource(){} // RVA: 0x7FFE82A433A0
    public void GetPlayerDescription(){} // RVA: 0x7FFE82A43420
    public void SetCustomMovParserEnabled(){} // RVA: 0x7FFE82A434A0
    public void SetHapNotchLCEnabled(){} // RVA: 0x7FFE82A43530
    public void SetFrameBufferingEnabled(){} // RVA: 0x7FFE82A435C0
    public void SetStereoDetectEnabled(){} // RVA: 0x7FFE82A43660
    public void SetTextTrackSupportEnabled(){} // RVA: 0x7FFE82A436F0
    public void SetAudioDelayEnabled(){} // RVA: 0x7FFE82A43780
    public void SetFacebookAudio360SupportEnabled(){} // RVA: 0x7FFE82A43830
    public void SetDecoderHints(){} // RVA: 0x7FFE82A438C0
    public void GetDecoderPerformance(){} // RVA: 0x7FFE82A43960
    public void GetLastErrorCode(){} // RVA: 0x7FFE82A43A10
    public void GetLastExtendedErrorCode(){} // RVA: 0x7FFE82A43A90
    public void Play(){} // RVA: 0x7FFE82A43B10
    public void Pause(){} // RVA: 0x7FFE82A43B90
    public void SetMuted(){} // RVA: 0x7FFE82A43C10
    public void SetVolume(){} // RVA: 0x7FFE82A43CA0
    public void SetBalance(){} // RVA: 0x7FFE82A43D30
    public void SetLooping(){} // RVA: 0x7FFE82A43DC0
    public void HasVideo(){} // RVA: 0x7FFE82A43E50
    public void HasAudio(){} // RVA: 0x7FFE82A43ED0
    public void GetWidth(){} // RVA: 0x7FFE82A43F50
    public void GetHeight(){} // RVA: 0x7FFE82A43FD0
    public void GetFrameRate(){} // RVA: 0x7FFE82A44050
    public void GetStereoPacking(){} // RVA: 0x7FFE82A440D0
    public void GetDuration(){} // RVA: 0x7FFE82A44150
    public void IsPlaybackStalled(){} // RVA: 0x7FFE82A441D0
    public void HasMetaData(){} // RVA: 0x7FFE82A44250
    public void CanPlay(){} // RVA: 0x7FFE82A442D0
    public void IsSeeking(){} // RVA: 0x7FFE82A44350
    public void IsPlaying(){} // RVA: 0x7FFE82A443D0
    public void IsFinished(){} // RVA: 0x7FFE82A44450
    public void IsBuffering(){} // RVA: 0x7FFE82A444D0
    public void GetCurrentTime(){} // RVA: 0x7FFE82A44550
    public void SetCurrentTime(){} // RVA: 0x7FFE82A445D0
    public void GetPlaybackRate(){} // RVA: 0x7FFE82A44670
    public void SetPlaybackRate(){} // RVA: 0x7FFE82A446F0
    public void StartExtractFrame(){} // RVA: 0x7FFE82A44780
    public void WaitForExtract(){} // RVA: 0x7FFE82A44800
    public void Update(){} // RVA: 0x7FFE82A44880
    public void EndUpdate(){} // RVA: 0x7FFE82A44900
    public void GetTexturePointer(){} // RVA: 0x7FFE82A44980
    public void GetTextureFormat(){} // RVA: 0x7FFE82A44A00
    public void IsTextureTopDown(){} // RVA: 0x7FFE82A44A80
    public void IsTextureSampleLinear(){} // RVA: 0x7FFE82A44B00
    public void GetTextureFrameCount(){} // RVA: 0x7FFE82A44B80
    public void GetTextureTimeStamp(){} // RVA: 0x7FFE82A44C00
    public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFE82A44C80
    public void GetRenderEventFunc(){} // RVA: 0x7FFE82A44D00
    public void GrabAudio(){} // RVA: 0x7FFE82A44D70
    public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFE82A44E30
    public void GetAudioChannelCount(){} // RVA: 0x7FFE82A44EB0
    public void GetAudioChannelMask(){} // RVA: 0x7FFE82A44F30
    public void SetAudioChannelMode(){} // RVA: 0x7FFE82A44FB0
    public void SetHeadOrientation(){} // RVA: 0x7FFE82A45040
    public void SetAudioFocusEnabled(){} // RVA: 0x7FFE82A45100
    public void SetAudioFocusProps(){} // RVA: 0x7FFE82A45190
    public void SetAudioFocusRotation(){} // RVA: 0x7FFE82A45230
    public void GetBufferedFramesState(){} // RVA: 0x7FFE82A452F0
    public void LockTextureFrame(){} // RVA: 0x7FFE82A45380
    public void UnlockTextureFrame(){} // RVA: 0x7FFE82A45440
    public void ReleaseTextureFrame(){} // RVA: 0x7FFE82A454D0
    public void FlushFrameBuffering(){} // RVA: 0x7FFE82A45560
}

public class NativeArrayHelper`1 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4D070
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class NativeBorderParams : ValueType
{
}

public class NativeColorPage : ValueType
{
}

public class NativeIoCompletionCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE867356A0
    public void Invoke(){} // RVA: 0x7FFE8401FE60
}

public class NativePacketCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86616820
    public void Invoke(){} // RVA: 0x7FFE8401DC50
}

public class NativePacketsCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81257410
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class NativeRectParams : ValueType
{
}

public class NativeResourceProvider : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE850720F0
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class NativeSelectFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D22C80
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class NativeServerNameFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE826F5CB0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class NativeVerifyFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D20460
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class NegateCheckedInt16 : NegateCheckedInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718A7A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NegateCheckedInt32 : NegateCheckedInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718A680
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NegateCheckedInt64 : NegateCheckedInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718A900
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NegateDouble : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718A280
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NegateInt16 : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87189E60
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NegateInt32 : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87189F30
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NegateInt64 : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718A000
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NegateSingle : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718A140
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NestedBinXml : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8743CAA0
}

public class NetworkCalling : Object
{
    // ── Methods ──
    public void get_SendCustomNetworkEventProxy(){} // RVA: 0x7FFE8822F040
    public void set_SendCustomNetworkEventProxy(){} // RVA: 0x7FFE8822F0E0
    public void get_GetQueuedEventsProxy(){} // RVA: 0x7FFE8822F1D0
    public void set_GetQueuedEventsProxy(){} // RVA: 0x7FFE8822F270
    public void get_GetAllQueuedEventsProxy(){} // RVA: 0x7FFE8822F360
    public void set_GetAllQueuedEventsProxy(){} // RVA: 0x7FFE8822F400
    public void WithNetworkCallingContext(){} // RVA: 0x7FFE8822F4F0
}

public class NetworkSurrogateSelector : Object
{
    // ── Methods ──
    public void ChainSelector(){} // RVA: 0x7FFE8A4DFC90
    public void GetNextSelector(){} // RVA: 0x7FFE81116380
    public void GetSurrogate(){} // RVA: 0x7FFE8A4DFDA0
    public void IsAllowedType(){} // RVA: 0x7FFE8A4E02D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NeverPromise`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E46250
    public void CancellationCallback(){} // RVA: 0x7FFE80E46070
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class NewArrayExpressionProxy : Object
{
    public System.Linq.Expressions.NewArrayExpression _node; // 0x10
    public object field_1; // 0x104
    public object field_2; // 0x105
    public object field_3; // 0x106
    public object field_4; // 0x107

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8711A4C0
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_Expressions(){} // RVA: 0x7FFE8189C080
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class NewDeviceMsg : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFE879AAFC0
    public void Process(){} // RVA: 0x7FFE879AB5F0
}

public class NewEventsMsg : Object
{
    // ── Methods ──
    public void CreateResetEvent(){} // RVA: 0x7FFE879ABF90
    public void CreateStateEvent(){} // RVA: 0x7FFE879AC090
    public void Create(){} // RVA: 0x7FFE879AC1A0
    public void Process(){} // RVA: 0x7FFE879AC320
}

public class NewExpressionProxy : Object
{
    public System.Linq.Expressions.NewExpression _node; // 0x10
    public object field_1; // 0x109
    public object field_2; // 0x10A
    public object field_3; // 0x10B
    public object field_4; // 0x10C
    public object field_5; // 0x10D
    public object field_6; // 0x10E

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8711A5A0
    public void get_Arguments(){} // RVA: 0x7FFE8711A680
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_Constructor(){} // RVA: 0x7FFE8189C080
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_Members(){} // RVA: 0x7FFE8189B810
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class NewInputFixedUpdate : ValueType
{
}

public class NewInputUpdate : ValueType
{
}

public class NewLayoutMsg : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFE879AA8F0
    public void Process(){} // RVA: 0x7FFE879AAD50
}

public class NextFramePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<NextFramePromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE87835290
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE87835410
    public void GetResult(){} // RVA: 0x7FFE87835810
    public void GetStatus(){} // RVA: 0x7FFE878359B0
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87835A00
    public void OnCompleted(){} // RVA: 0x7FFE87835A40
    public void MoveNext(){} // RVA: 0x7FFE87835AC0
    public void TryReturn(){} // RVA: 0x7FFE87835C00
}

public class NextResult : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4BC00
}

public class Nnapi : Object
{
    public Google.Protobuf.MessageParser`1<Nnapi> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public string CacheDirDefaultValue; // 0x8
    public string cacheDir_; // 0x18
    public string ModelTokenDefaultValue; // 0x10
    public string modelToken_; // 0x20
    public string AcceleratorNameDefaultValue; // 0x18
    public string acceleratorName_; // 0x28
    public object field_8; // 0x4A

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE86628EB0
    public void get_Descriptor(){} // RVA: 0x7FFE86628F10
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86628F90
    public void .ctor(){} // RVA: 0x7FFE86629040 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE86629260
    public void get_CacheDir(){} // RVA: 0x7FFE866292C0
    public void set_CacheDir(){} // RVA: 0x7FFE86629330
    public void get_HasCacheDir(){} // RVA: 0x7FFE82AC8EE0
    public void ClearCacheDir(){} // RVA: 0x7FFE8340D8D0
    public void get_ModelToken(){} // RVA: 0x7FFE86629430
    public void set_ModelToken(){} // RVA: 0x7FFE866294A0
    public void get_HasModelToken(){} // RVA: 0x7FFE82BC81D0
    public void ClearModelToken(){} // RVA: 0x7FFE86597DC0
    public void get_AcceleratorName(){} // RVA: 0x7FFE866295A0
    public void set_AcceleratorName(){} // RVA: 0x7FFE86629610
    public void get_HasAcceleratorName(){} // RVA: 0x7FFE865A8CD0
    public void ClearAcceleratorName(){} // RVA: 0x7FFE836E7F30
    public void Equals(){} // RVA: 0x7FFE86629770 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE866298F0
    public void ToString(){} // RVA: 0x7FFE866299D0
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86629A20
    public void CalculateSize(){} // RVA: 0x7FFE86629AE0
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86629D30
    public void .cctor(){} // RVA: 0x7FFE86629E40
}

public class NoInput : Object
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7FFE810FB320
    public void GetAxisRaw(){} // RVA: 0x7FFE8186F320
    public void get_touchCount(){} // RVA: 0x7FFE813240E0
    public void GetTouch(){} // RVA: 0x7FFE87F16CF0
    public void ClearLastPenContactEvent(){} // RVA: 0x7FFE810FB310
    public void GetLastPenContactEvent(){} // RVA: 0x7FFE822599E0
    public void get_mousePresent(){} // RVA: 0x7FFE810FB320
    public void GetMouseButtonDown(){} // RVA: 0x7FFE810FB320
    public void GetMouseButtonUp(){} // RVA: 0x7FFE810FB320
    public void get_mousePosition(){} // RVA: 0x7FFE8543D940
    public void get_mouseButtonCount(){} // RVA: 0x7FFE813240E0
    public void get_anyKey(){} // RVA: 0x7FFE810FB320
    public void get_unscaledTime(){} // RVA: 0x7FFE8186F320
    public void get_doubleClickTime(){} // RVA: 0x7FFE87F16D10
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NoNamespaceManager : XmlNamespaceManager
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void get_DefaultNamespace(){} // RVA: 0x7FFE87567190
    public void PushScope(){} // RVA: 0x7FFE810FB310
    public void PopScope(){} // RVA: 0x7FFE810FB320
    public void AddNamespace(){} // RVA: 0x7FFE810FB310
    public void RemoveNamespace(){} // RVA: 0x7FFE810FB310
    public void GetEnumerator(){} // RVA: 0x7FFE813240E0
    public void GetNamespacesInScope(){} // RVA: 0x7FFE813240E0
    public void LookupNamespace(){} // RVA: 0x7FFE875671D0
    public void LookupPrefix(){} // RVA: 0x7FFE813240E0
}

public class Node : Object
{
    public Node<U,T> EmptyNode;
    public U _key;
    public T _value;
    public bool _frozen;
    public byte _height;
    public Node<U,T> _left;
    public Node<U,T> _right;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
    public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
    public void get_Height(){} // RVA: 0x7FFE80E2EDB0
    public void get_Left(){} // RVA: 0x7FFE80E2E2E0
    public void get_Right(){} // RVA: 0x7FFE80E2E2E0
    public void get_Value(){} // RVA: 0x7FFE810A1420
    public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
    public void get_Values(){} // RVA: 0x7FFE80E2E2E0
    public void GetEnumerator(){} // RVA: 0x7FFE810A1420 | overloaded x2
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void CopyTo(){}
    public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFE80E2E3D0
    public void Add(){} // RVA: 0x7FFE810A1420
    public void SetItem(){} // RVA: 0x7FFE810A1420
    public void TryGetValue(){} // RVA: 0x7FFE810A1420
    public void ContainsKey(){} // RVA: 0x7FFE810A1420
    public void ContainsValue(){} // RVA: 0x7FFE810A1420
    public void Contains(){} // RVA: 0x7FFE810A1420
    public void Freeze(){} // RVA: 0x7FFE80E45FE0
    public void RotateLeft(){} // RVA: 0x7FFE80E2E3D0
    public void RotateRight(){} // RVA: 0x7FFE80E2E3D0
    public void DoubleLeft(){} // RVA: 0x7FFE80E2E3D0
    public void DoubleRight(){} // RVA: 0x7FFE80E2E3D0
    public void Balance(){} // RVA: 0x7FFE80E2EE90
    public void IsRightHeavy(){} // RVA: 0x7FFE80E2F230
    public void IsLeftHeavy(){} // RVA: 0x7FFE80E2F230
    public void MakeBalanced(){} // RVA: 0x7FFE80E2E3D0
    public void NodeTreeFromList(){} // RVA: 0x7FFE80E3F430
    public void SetOrAdd(){} // RVA: 0x7FFE810A1420
    public void Mutate(){} // RVA: 0x7FFE80E3FC10
    public void Search(){} // RVA: 0x7FFE810A1420
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class NodeData : Object
{
    public NodeData s_None;
    public 0x66556674 type; // 0x10
    public string localName; // 0x18
    public string prefix; // 0x20
    public string ns; // 0x28
    public string nameWPrefix; // 0x30
    public string value; // 0x38

    // ── Methods ──
    public void get_None(){} // RVA: 0x7FFE87567C20
    public void .ctor(){} // RVA: 0x7FFE87567D10
    public void get_LineNo(){} // RVA: 0x7FFE8139DAD0
    public void get_LinePos(){} // RVA: 0x7FFE819EA920
    public void get_IsEmptyElement(){} // RVA: 0x7FFE87567D30
    public void set_IsEmptyElement(){} // RVA: 0x7FFE811C3580
    public void get_IsDefaultAttribute(){} // RVA: 0x7FFE87567D40
    public void set_IsDefaultAttribute(){} // RVA: 0x7FFE811C3580
    public void get_ValueBuffered(){} // RVA: 0x7FFE821751E0
    public void get_StringValue(){} // RVA: 0x7FFE87567D50
    public void TrimSpacesInValue(){} // RVA: 0x7FFE87567DE0
    public void Clear(){} // RVA: 0x7FFE87567F60
    public void ClearName(){} // RVA: 0x7FFE87568140
    public void SetLineInfo(){} // RVA: 0x7FFE87568300
    public void SetLineInfo2(){} // RVA: 0x7FFE87568310
    public void SetValueNode(){} // RVA: 0x7FFE875683A0 | overloaded x2
    public void SetNamedNode(){} // RVA: 0x7FFE87568510 | overloaded x2
    public void SetValue(){} // RVA: 0x7FFE87568790 | overloaded x2
    public void OnBufferInvalidated(){} // RVA: 0x7FFE87568860
    public void CopyTo(){} // RVA: 0x7FFE87568980 | overloaded x2
    public void GetNameWPrefix(){} // RVA: 0x7FFE87568A00
    public void CreateNameWPrefix(){} // RVA: 0x7FFE87568B70
    public void System.IComparable.CompareTo(){} // RVA: 0x7FFE87568CC0
}

public class NodeEnumerator : Object
{
    public System.Collections.ListDictionaryInternal list; // 0x10
    public DictionaryNode current; // 0x18
    public int version; // 0x20
    public bool start; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8693B5D0
    public void get_Current(){} // RVA: 0x7FFE8693B6B0
    public void get_Entry(){} // RVA: 0x7FFE8693B770
    public void get_Key(){} // RVA: 0x7FFE8693B7F0
    public void get_Value(){} // RVA: 0x7FFE8693B860
    public void MoveNext(){} // RVA: 0x7FFE8693B8D0
    public void Reset(){} // RVA: 0x7FFE8693B9F0
}

public class NodeKeyValueCollection : Object
{
    public System.Collections.ListDictionaryInternal list; // 0x10
    public bool isKeys; // 0x18
    public object field_2; // 0x7C9

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828378F0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE8693BAC0
    public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE8693BCC0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE8693BD00
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8693BDC0
}

public class NodeKeyValueEnumerator : Object
{
    public System.Collections.ListDictionaryInternal list; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8693BEE0
    public void get_Current(){} // RVA: 0x7FFE8693BFD0
    public void MoveNext(){} // RVA: 0x7FFE8693C050
    public void Reset(){} // RVA: 0x7FFE8693C170
}

public class NodePath : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E484C0
}

public class Noise : ValueType
{
}

public class NoiseModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x163
    public object field_2; // 0x164
    public object field_3; // 0x165
    public object field_4; // 0x166
    public object field_5; // 0x167
    public object field_6; // 0x168
    public object field_7; // 0x169
    public object field_8; // 0x16A
    public object field_9; // 0x16B
    public object field_10; // 0x16C
    public object field_11; // 0x16D
    public object field_12; // 0x16E
    public object field_13; // 0x16F
    public object field_14; // 0x170
    public object field_15; // 0x171
    public object field_16; // 0x172
    public object field_17; // 0x173
    public object field_18; // 0x174
    public object field_19; // 0x175
    public object field_20; // 0x176
    public object field_21; // 0x177
    public object field_22; // 0x178
    public object field_23; // 0x179
    public object field_24; // 0x17A
    public object field_25; // 0x17B
    public object field_26; // 0x17C
    public object field_27; // 0x17D
    public object field_28; // 0x17E
    public object field_29; // 0x17F

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87D01610
    public void set_enabled(){} // RVA: 0x7FFE87D01660
    public void get_separateAxes(){} // RVA: 0x7FFE87D016C0
    public void set_separateAxes(){} // RVA: 0x7FFE87D01710
    public void get_strength(){} // RVA: 0x7FFE87D01770
    public void set_strength(){} // RVA: 0x7FFE87D017E0
    public void get_strengthMultiplier(){} // RVA: 0x7FFE87D01840
    public void set_strengthMultiplier(){} // RVA: 0x7FFE87D01890
    public void get_strengthX(){} // RVA: 0x7FFE87D018F0
    public void set_strengthX(){} // RVA: 0x7FFE87D01960
    public void get_strengthXMultiplier(){} // RVA: 0x7FFE87D019C0
    public void set_strengthXMultiplier(){} // RVA: 0x7FFE87D01A10
    public void get_strengthY(){} // RVA: 0x7FFE87D01A70
    public void set_strengthY(){} // RVA: 0x7FFE87D01AE0
    public void get_strengthYMultiplier(){} // RVA: 0x7FFE87D01B40
    public void set_strengthYMultiplier(){} // RVA: 0x7FFE87D01B90
    public void get_strengthZ(){} // RVA: 0x7FFE87D01BF0
    public void set_strengthZ(){} // RVA: 0x7FFE87D01C60
    public void get_strengthZMultiplier(){} // RVA: 0x7FFE87D01CC0
    public void set_strengthZMultiplier(){} // RVA: 0x7FFE87D01D10
    public void get_frequency(){} // RVA: 0x7FFE87D01D70
    public void set_frequency(){} // RVA: 0x7FFE87D01DC0
    public void get_damping(){} // RVA: 0x7FFE87D01E20
    public void set_damping(){} // RVA: 0x7FFE87D01E70
    public void get_octaveCount(){} // RVA: 0x7FFE87D01ED0
    public void set_octaveCount(){} // RVA: 0x7FFE87D01F20
    public void get_octaveMultiplier(){} // RVA: 0x7FFE87D01F80
    public void set_octaveMultiplier(){} // RVA: 0x7FFE87D01FD0
    public void get_octaveScale(){} // RVA: 0x7FFE87D02030
    public void set_octaveScale(){} // RVA: 0x7FFE87D02080
    public void get_quality(){} // RVA: 0x7FFE87D020E0
    public void set_quality(){} // RVA: 0x7FFE87D02130
    public void get_scrollSpeed(){} // RVA: 0x7FFE87D02190
    public void set_scrollSpeed(){} // RVA: 0x7FFE87D02200
    public void get_scrollSpeedMultiplier(){} // RVA: 0x7FFE87D02260
    public void set_scrollSpeedMultiplier(){} // RVA: 0x7FFE87D022B0
    public void get_remapEnabled(){} // RVA: 0x7FFE87D02310
    public void set_remapEnabled(){} // RVA: 0x7FFE87D02360
    public void get_remap(){} // RVA: 0x7FFE87D023C0
    public void set_remap(){} // RVA: 0x7FFE87D02430
    public void get_remapMultiplier(){} // RVA: 0x7FFE87D02490
    public void set_remapMultiplier(){} // RVA: 0x7FFE87D024E0
    public void get_remapX(){} // RVA: 0x7FFE87D02540
    public void set_remapX(){} // RVA: 0x7FFE87D025B0
    public void get_remapXMultiplier(){} // RVA: 0x7FFE87D02610
    public void set_remapXMultiplier(){} // RVA: 0x7FFE87D02660
    public void get_remapY(){} // RVA: 0x7FFE87D026C0
    public void set_remapY(){} // RVA: 0x7FFE87D02730
    public void get_remapYMultiplier(){} // RVA: 0x7FFE87D02790
    public void set_remapYMultiplier(){} // RVA: 0x7FFE87D027E0
    public void get_remapZ(){} // RVA: 0x7FFE87D02840
    public void set_remapZ(){} // RVA: 0x7FFE87D028B0
    public void get_remapZMultiplier(){} // RVA: 0x7FFE87D02910
    public void set_remapZMultiplier(){} // RVA: 0x7FFE87D02960
    public void get_positionAmount(){} // RVA: 0x7FFE87D029C0
    public void set_positionAmount(){} // RVA: 0x7FFE87D02A30
    public void get_rotationAmount(){} // RVA: 0x7FFE87D02A90
    public void set_rotationAmount(){} // RVA: 0x7FFE87D02B00
    public void get_sizeAmount(){} // RVA: 0x7FFE87D02B60
    public void set_sizeAmount(){} // RVA: 0x7FFE87D02BD0
    public void get_enabled_Injected(){} // RVA: 0x7FFE87D01610
    public void set_enabled_Injected(){} // RVA: 0x7FFE87D01660
    public void get_separateAxes_Injected(){} // RVA: 0x7FFE87D016C0
    public void set_separateAxes_Injected(){} // RVA: 0x7FFE87D01710
    public void get_strength_Injected(){} // RVA: 0x7FFE87D02C30
    public void set_strength_Injected(){} // RVA: 0x7FFE87D02C90
    public void get_strengthMultiplier_Injected(){} // RVA: 0x7FFE87D01840
    public void set_strengthMultiplier_Injected(){} // RVA: 0x7FFE87D01890
    public void get_strengthX_Injected(){} // RVA: 0x7FFE87D02CF0
    public void set_strengthX_Injected(){} // RVA: 0x7FFE87D02D50
    public void get_strengthXMultiplier_Injected(){} // RVA: 0x7FFE87D019C0
    public void set_strengthXMultiplier_Injected(){} // RVA: 0x7FFE87D01A10
    public void get_strengthY_Injected(){} // RVA: 0x7FFE87D02DB0
    public void set_strengthY_Injected(){} // RVA: 0x7FFE87D02E10
    public void get_strengthYMultiplier_Injected(){} // RVA: 0x7FFE87D01B40
    public void set_strengthYMultiplier_Injected(){} // RVA: 0x7FFE87D01B90
    public void get_strengthZ_Injected(){} // RVA: 0x7FFE87D02E70
    public void set_strengthZ_Injected(){} // RVA: 0x7FFE87D02ED0
    public void get_strengthZMultiplier_Injected(){} // RVA: 0x7FFE87D01CC0
    public void set_strengthZMultiplier_Injected(){} // RVA: 0x7FFE87D01D10
    public void get_frequency_Injected(){} // RVA: 0x7FFE87D01D70
    public void set_frequency_Injected(){} // RVA: 0x7FFE87D01DC0
    public void get_damping_Injected(){} // RVA: 0x7FFE87D01E20
    public void set_damping_Injected(){} // RVA: 0x7FFE87D01E70
    public void get_octaveCount_Injected(){} // RVA: 0x7FFE87D01ED0
    public void set_octaveCount_Injected(){} // RVA: 0x7FFE87D01F20
    public void get_octaveMultiplier_Injected(){} // RVA: 0x7FFE87D01F80
    public void set_octaveMultiplier_Injected(){} // RVA: 0x7FFE87D01FD0
    public void get_octaveScale_Injected(){} // RVA: 0x7FFE87D02030
    public void set_octaveScale_Injected(){} // RVA: 0x7FFE87D02080
    public void get_quality_Injected(){} // RVA: 0x7FFE87D020E0
    public void set_quality_Injected(){} // RVA: 0x7FFE87D02130
    public void get_scrollSpeed_Injected(){} // RVA: 0x7FFE87D02F30
    public void set_scrollSpeed_Injected(){} // RVA: 0x7FFE87D02F90
    public void get_scrollSpeedMultiplier_Injected(){} // RVA: 0x7FFE87D02260
    public void set_scrollSpeedMultiplier_Injected(){} // RVA: 0x7FFE87D022B0
    public void get_remapEnabled_Injected(){} // RVA: 0x7FFE87D02310
    public void set_remapEnabled_Injected(){} // RVA: 0x7FFE87D02360
    public void get_remap_Injected(){} // RVA: 0x7FFE87D02FF0
    public void set_remap_Injected(){} // RVA: 0x7FFE87D03050
    public void get_remapMultiplier_Injected(){} // RVA: 0x7FFE87D02490
    public void set_remapMultiplier_Injected(){} // RVA: 0x7FFE87D024E0
    public void get_remapX_Injected(){} // RVA: 0x7FFE87D030B0
    public void set_remapX_Injected(){} // RVA: 0x7FFE87D03110
    public void get_remapXMultiplier_Injected(){} // RVA: 0x7FFE87D02610
    public void set_remapXMultiplier_Injected(){} // RVA: 0x7FFE87D02660
    public void get_remapY_Injected(){} // RVA: 0x7FFE87D03170
    public void set_remapY_Injected(){} // RVA: 0x7FFE87D031D0
    public void get_remapYMultiplier_Injected(){} // RVA: 0x7FFE87D02790
    public void set_remapYMultiplier_Injected(){} // RVA: 0x7FFE87D027E0
    public void get_remapZ_Injected(){} // RVA: 0x7FFE87D03230
    public void set_remapZ_Injected(){} // RVA: 0x7FFE87D03290
    public void get_remapZMultiplier_Injected(){} // RVA: 0x7FFE87D02910
    public void set_remapZMultiplier_Injected(){} // RVA: 0x7FFE87D02960
    public void get_positionAmount_Injected(){} // RVA: 0x7FFE87D032F0
    public void set_positionAmount_Injected(){} // RVA: 0x7FFE87D03350
    public void get_rotationAmount_Injected(){} // RVA: 0x7FFE87D033B0
    public void set_rotationAmount_Injected(){} // RVA: 0x7FFE87D03410
    public void get_sizeAmount_Injected(){} // RVA: 0x7FFE87D03470
    public void set_sizeAmount_Injected(){} // RVA: 0x7FFE87D034D0
}

public class NoiseParams : ValueType
{
    // ── Methods ──
    public void GetValueAt(){} // RVA: 0x7FFE82AB5820
}

public class NonConstructable : Object
{
    // ── Methods ──
    public void Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated(){} // RVA: 0x7FFE810FB320
    public void Instantiate(){} // RVA: 0x7FFE87D4DBD0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NoopDisposable : Object
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class NotBoolean : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718DA70
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotByte : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718E160
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualBoolean : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718BD30
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualByte : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C2D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualByteLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718CE50
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualChar : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C000
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualCharLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718CB20
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualDouble : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C790
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualDoubleLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718D3C0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualInt16 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718BF10
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualInt16LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718CA10
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualInt32 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C0F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualInt32LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718CC30
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualInt64 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C1E0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualInt64LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718CD40
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualReference : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C890
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualSByte : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718BE20
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualSByteLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C900
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualSingle : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C690
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualSingleLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718D290
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualUInt16 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C3C0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualUInt16LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718CF60
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualUInt32 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C4B0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualUInt32LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718D070
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualUInt64 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718C5A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotEqualUInt64LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718D180
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotInt16 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718DD50
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotInt32 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718DC80
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotInt64 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718DB40
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotSByte : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718E230
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotUInt16 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718E090
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotUInt32 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718DF60
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NotUInt64 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE8718DE20
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class NoteOnEvent : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE8A463340
    public void GetHashCode(){} // RVA: 0x7FFE869F3500
}

public class NotificationEntry : ValueType
{
    public double time; // 0x10
    public UnityEngine.Playables.INotification payload; // 0x18
    public bool notificationFired; // 0x20

    // ── Methods ──
    public void get_triggerInEditor(){} // RVA: 0x7FFE87320C90
    public void get_prewarm(){} // RVA: 0x7FFE87B80B10
    public void get_triggerOnce(){} // RVA: 0x7FFE87B80B20
}

public class NotificationType : Object
{
}

public class NtDll : Object
{
    // ── Methods ──
    public void NtCreateFile(){} // RVA: 0x7FFE86733F60
    public void CreateFile(){} // RVA: 0x7FFE86734010
    public void NtQueryDirectoryFile(){} // RVA: 0x7FFE86734280
    public void RtlNtStatusToDosError(){} // RVA: 0x7FFE86734350
}

public class NullDisposable : Object
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFE810FB310
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE8A553690
}

public class NullProgress`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Report(){} // RVA: 0x7FFE810A1420
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class NullStream : Stream
{
    public System.Threading.Tasks.Task`1<int> s_zeroTask;
    public object field_1; // 0x962
    public object field_2; // 0x963
    public object field_3; // 0x964
    public object field_4; // 0x965

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE869938F0
    public void get_CanRead(){} // RVA: 0x7FFE811E0850
    public void get_CanWrite(){} // RVA: 0x7FFE811E0850
    public void get_CanSeek(){} // RVA: 0x7FFE811E0850
    public void get_Length(){} // RVA: 0x7FFE813240E0
    public void get_Position(){} // RVA: 0x7FFE813240E0
    public void set_Position(){} // RVA: 0x7FFE810FB310
    public void CopyTo(){} // RVA: 0x7FFE86993940
    public void CopyToAsync(){} // RVA: 0x7FFE86993950
    public void Dispose(){} // RVA: 0x7FFE810FB310
    public void Flush(){} // RVA: 0x7FFE810FB310
    public void FlushAsync(){} // RVA: 0x7FFE86993A60
    public void BeginRead(){} // RVA: 0x7FFE86993B40
    public void EndRead(){} // RVA: 0x7FFE86993BD0
    public void BeginWrite(){} // RVA: 0x7FFE86993D70
    public void EndWrite(){} // RVA: 0x7FFE86993E00
    public void Read(){} // RVA: 0x7FFE813240E0 | overloaded x2
    public void ReadAsync(){} // RVA: 0x7FFE86994000 | overloaded x2
    public void ReadByte(){} // RVA: 0x7FFE81517DA0
    public void Write(){} // RVA: 0x7FFE810FB310 | overloaded x2
    public void WriteAsync(){} // RVA: 0x7FFE86994180 | overloaded x2
    public void WriteByte(){} // RVA: 0x7FFE810FB310
    public void Seek(){} // RVA: 0x7FFE813240E0
    public void SetLength(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE869942F0
}

public class NullStreamReader : StreamReader
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8696F500
    public void get_BaseStream(){} // RVA: 0x7FFE8696F6E0
    public void get_CurrentEncoding(){} // RVA: 0x7FFE8696F740
    public void Dispose(){} // RVA: 0x7FFE810FB310
    public void Peek(){} // RVA: 0x7FFE81517DA0
    public void Read(){} // RVA: 0x7FFE813240E0 | overloaded x2
    public void ReadLine(){} // RVA: 0x7FFE813240E0
    public void ReadToEnd(){} // RVA: 0x7FFE8696F750
    public void ReadBuffer(){} // RVA: 0x7FFE813240E0
}

public class NullTextReader : TextReader
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE869794B0
    public void Read(){} // RVA: 0x7FFE813240E0
    public void ReadLine(){} // RVA: 0x7FFE813240E0
}

public class NullTextWriter : TextWriter
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8697C0D0
    public void get_Encoding(){} // RVA: 0x7FFE8696F740
    public void Write(){} // RVA: 0x7FFE810FB310 | overloaded x3
    public void WriteLine(){} // RVA: 0x7FFE810FB310 | overloaded x3
}
