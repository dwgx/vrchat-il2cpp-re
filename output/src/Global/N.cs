// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 569

public class NameObjectEntry : Object
{
    public string Key; // 0x10
    public object Value; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
}

public class NameObjectKeysEnumerator : Object
{
    public int Current; // 0x10
    public System.Collections.Specialized.NameObjectCollectionBase _coll; // 0x18
    public int _version; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9455DD0
    public void MoveNext(){} // RVA: 0x7FFAC9455E50
    public void Reset(){} // RVA: 0x7FFAC9455F30
    public void get_Current(){} // RVA: 0x7FFAC9455FC0
}

public class NamePart : Object
{
    public Google.Protobuf.MessageParser`1<NamePart> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public string NamePart_; // 0x8
    public string HasNamePart_; // 0x20
    public bool IsExtension; // 0x10
    public bool HasIsExtension; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC820ED60
    public void get_Descriptor(){} // RVA: 0x7FFAC820EDC0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC820EE40
    public void .ctor(){} // RVA: 0x7FFAC820EEF0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC820F060
    public void get_NamePart_(){} // RVA: 0x7FFAC820F200
    public void set_NamePart_(){} // RVA: 0x7FFAC820F270
    public void get_HasNamePart_(){} // RVA: 0x7FFAC495C6A0
    public void ClearNamePart_(){} // RVA: 0x7FFAC81EE480
    public void get_IsExtension(){} // RVA: 0x7FFAC820F370
    public void set_IsExtension(){} // RVA: 0x7FFAC820F3E0
    public void get_HasIsExtension(){} // RVA: 0x7FFAC81F3770
    public void ClearIsExtension(){} // RVA: 0x7FFAC81F3780
    public void Equals(){} // RVA: 0x7FFAC820F520 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC820F620
    public void ToString(){} // RVA: 0x7FFAC820F6F0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC820F740
    public void CalculateSize(){} // RVA: 0x7FFAC820F7D0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC820F990
    public void .cctor(){} // RVA: 0x7FFAC820FA60
}

public class NameType : Object
{
    public string name; // 0x10
    public System.Type type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void CompareTo(){} // RVA: 0x7FFAC8ED3900
}

public class Namespace : ValueType
{
    public string prefix; // 0x10
    public string ns; // 0x18
    public bool declared; // 0x20
    public int prevNsIndex; // 0x24

    // ── Methods ──
    public void Set(){} // RVA: 0x7FFAC91C72D0
}

public class NamespaceDecl : Object
{
    public string prefix; // 0x10
    public string uri; // 0x18
    public NamespaceDecl scopeLink; // 0x20
    public NamespaceDecl prevLink; // 0x28
    public int scope; // 0x30
    public bool implied; // 0x34

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9094020
}

public class NamespaceDeclaration : ValueType
{
    public string prefix; // 0x10
    public string uri; // 0x18
    public int scopeId; // 0x20
    public int previousNsIndex; // 0x24

    // ── Methods ──
    public void Set(){} // RVA: 0x7FFAC9226140
}

public class NamespaceManager : XmlNamespaceManager
{
    // ── Methods ──
    public void LookupNamespace(){} // RVA: 0x7FFAC3E92FB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NamespacePrefixForQName : Object
{
    public string prefix; // 0x10
    public string ns; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86BFC90
    public void LookupNamespace(){} // RVA: 0x7FFAC9135A20
    public void LookupPrefix(){} // RVA: 0x7FFAC9135A80
    public void GetNamespacesInScope(){} // RVA: 0x7FFAC9135AE0
}

public class NamespaceResolverProxy : Object
{
    public System.Xml.XmlWellFormedWriter wfWriter; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x7FFAC91D6430
    public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x7FFAC91D6470
    public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x7FFAC91D6490
}

public class Native : ValueType
{
    // ── Methods ──
    public void IsChangedTracks(){} // RVA: 0x7FFAC47DA210
    public void GetTrackCount(){} // RVA: 0x7FFAC47DA2A0
    public void GetTrackInfo(){} // RVA: 0x7FFAC47DA330
    public void SetActiveTrack(){} // RVA: 0x7FFAC47DA4A0
    public void IsChangedTextCue(){} // RVA: 0x7FFAC47DA540
    public void GetCurrentTextCue(){} // RVA: 0x7FFAC47DA5C0
    public void GetTimeRanges(){} // RVA: 0x7FFAC47DA640
    public void Init(){} // RVA: 0x7FFAC47DA770
    public void Deinit(){} // RVA: 0x7FFAC47DA7F0
    public void GetPluginVersion(){} // RVA: 0x7FFAC47DA860
    public void IsTrialVersion(){} // RVA: 0x7FFAC47DA8D0
    public void BeginOpenSource(){} // RVA: 0x7FFAC47DA940
    public void EndOpenSource(){} // RVA: 0x7FFAC47DAAD0
    public void OpenSourceFromBuffer(){} // RVA: 0x7FFAC47DAB70
    public void StartOpenSourceFromBuffer(){} // RVA: 0x7FFAC47DAD20
    public void AddChunkToSourceBuffer(){} // RVA: 0x7FFAC47DADC0
    public void EndOpenSourceFromBuffer(){} // RVA: 0x7FFAC47DAE80
    public void CloseSource(){} // RVA: 0x7FFAC47DB000
    public void GetPlayerDescription(){} // RVA: 0x7FFAC47DB080
    public void SetCustomMovParserEnabled(){} // RVA: 0x7FFAC47DB100
    public void SetHapNotchLCEnabled(){} // RVA: 0x7FFAC47DB190
    public void SetFrameBufferingEnabled(){} // RVA: 0x7FFAC47DB220
    public void SetStereoDetectEnabled(){} // RVA: 0x7FFAC47DB2C0
    public void SetTextTrackSupportEnabled(){} // RVA: 0x7FFAC47DB350
    public void SetAudioDelayEnabled(){} // RVA: 0x7FFAC47DB3E0
    public void SetFacebookAudio360SupportEnabled(){} // RVA: 0x7FFAC47DB490
    public void SetDecoderHints(){} // RVA: 0x7FFAC47DB520
    public void GetDecoderPerformance(){} // RVA: 0x7FFAC47DB5C0
    public void GetLastErrorCode(){} // RVA: 0x7FFAC47DB670
    public void GetLastExtendedErrorCode(){} // RVA: 0x7FFAC47DB6F0
    public void Play(){} // RVA: 0x7FFAC47DB770
    public void Pause(){} // RVA: 0x7FFAC47DB7F0
    public void SetMuted(){} // RVA: 0x7FFAC47DB870
    public void SetVolume(){} // RVA: 0x7FFAC47DB900
    public void SetBalance(){} // RVA: 0x7FFAC47DB990
    public void SetLooping(){} // RVA: 0x7FFAC47DBA20
    public void HasVideo(){} // RVA: 0x7FFAC47DBAB0
    public void HasAudio(){} // RVA: 0x7FFAC47DBB30
    public void GetWidth(){} // RVA: 0x7FFAC47DBBB0
    public void GetHeight(){} // RVA: 0x7FFAC47DBC30
    public void GetFrameRate(){} // RVA: 0x7FFAC47DBCB0
    public void GetStereoPacking(){} // RVA: 0x7FFAC47DBD30
    public void GetDuration(){} // RVA: 0x7FFAC47DBDB0
    public void IsPlaybackStalled(){} // RVA: 0x7FFAC47DBE30
    public void HasMetaData(){} // RVA: 0x7FFAC47DBEB0
    public void CanPlay(){} // RVA: 0x7FFAC47DBF30
    public void IsSeeking(){} // RVA: 0x7FFAC47DBFB0
    public void IsPlaying(){} // RVA: 0x7FFAC47DC030
    public void IsFinished(){} // RVA: 0x7FFAC47DC0B0
    public void IsBuffering(){} // RVA: 0x7FFAC47DC130
    public void GetCurrentTime(){} // RVA: 0x7FFAC47DC1B0
    public void SetCurrentTime(){} // RVA: 0x7FFAC47DC230
    public void GetPlaybackRate(){} // RVA: 0x7FFAC47DC2D0
    public void SetPlaybackRate(){} // RVA: 0x7FFAC47DC350
    public void StartExtractFrame(){} // RVA: 0x7FFAC47DC3E0
    public void WaitForExtract(){} // RVA: 0x7FFAC47DC460
    public void Update(){} // RVA: 0x7FFAC47DC4E0
    public void EndUpdate(){} // RVA: 0x7FFAC47DC560
    public void GetTexturePointer(){} // RVA: 0x7FFAC47DC5E0
    public void GetTextureFormat(){} // RVA: 0x7FFAC47DC660
    public void IsTextureTopDown(){} // RVA: 0x7FFAC47DC6E0
    public void IsTextureSampleLinear(){} // RVA: 0x7FFAC47DC760
    public void GetTextureFrameCount(){} // RVA: 0x7FFAC47DC7E0
    public void GetTextureTimeStamp(){} // RVA: 0x7FFAC47DC860
    public void GetTexturePixelAspectRatio(){} // RVA: 0x7FFAC47DC8E0
    public void GetRenderEventFunc(){} // RVA: 0x7FFAC47DC960
    public void GrabAudio(){} // RVA: 0x7FFAC47DC9D0
    public void GetAudioBufferedSampleCount(){} // RVA: 0x7FFAC47DCA90
    public void GetAudioChannelCount(){} // RVA: 0x7FFAC47DCB10
    public void GetAudioChannelMask(){} // RVA: 0x7FFAC47DCB90
    public void SetAudioChannelMode(){} // RVA: 0x7FFAC47DCC10
    public void SetHeadOrientation(){} // RVA: 0x7FFAC47DCCA0
    public void SetAudioFocusEnabled(){} // RVA: 0x7FFAC47DCD60
    public void SetAudioFocusProps(){} // RVA: 0x7FFAC47DCDF0
    public void SetAudioFocusRotation(){} // RVA: 0x7FFAC47DCE90
    public void GetBufferedFramesState(){} // RVA: 0x7FFAC47DCF50
    public void LockTextureFrame(){} // RVA: 0x7FFAC47DCFE0
    public void UnlockTextureFrame(){} // RVA: 0x7FFAC47DD0A0
    public void ReleaseTextureFrame(){} // RVA: 0x7FFAC47DD130
    public void FlushFrameBuffering(){} // RVA: 0x7FFAC47DD1C0
}

public class NativeArrayHelper`1 : ValueType
{
    public Unity.Collections.NativeArray`1<T> UnityNativeArray;
    public System.Runtime.InteropServices.GCHandle _handle;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C77970
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class NativeBorderParams : ValueType
{
    public UnityEngine.Rect rect; // 0x10
    public UnityEngine.Color leftColor; // 0x20
    public UnityEngine.Color topColor; // 0x30
    public UnityEngine.Color rightColor; // 0x40
    public UnityEngine.Color bottomColor; // 0x50
    public float leftWidth; // 0x60
    public float topWidth; // 0x64
    public float rightWidth; // 0x68
    public float bottomWidth; // 0x6C
    public UnityEngine.Vector2 topLeftRadius; // 0x70
    public UnityEngine.Vector2 topRightRadius; // 0x78
    public UnityEngine.Vector2 bottomRightRadius; // 0x80
    public UnityEngine.Vector2 bottomLeftRadius; // 0x88
    public NativeColorPage leftColorPage; // 0x90
    public NativeColorPage topColorPage; // 0x98
    public NativeColorPage rightColorPage; // 0xA0
    public NativeColorPage bottomColorPage; // 0xA8
}

public class NativeColorPage : ValueType
{
    public int isValid; // 0x10
    public UnityEngine.Color32 pageAndID; // 0x14
}

public class NativeIoCompletionCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC838BDA0
    public void Invoke(){} // RVA: 0x7FFAC5CC1930
}

public class NativePacketCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC826CF00
    public void Invoke(){} // RVA: 0x7FFAC5CBF810
}

public class NativePacketsCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC307D410
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class NativeRectParams : ValueType
{
    public UnityEngine.Rect rect; // 0x10
    public UnityEngine.Rect subRect; // 0x20
    public UnityEngine.Rect uv; // 0x30
    public UnityEngine.Rect uvRegion; // 0x40
    public UnityEngine.Color color; // 0x50
    public 0x6B27F8A0 scaleMode; // 0x60
    public UnityEngine.Vector2 topLeftRadius; // 0x64
    public UnityEngine.Vector2 topRightRadius; // 0x6C
    public UnityEngine.Vector2 bottomRightRadius; // 0x74
    public UnityEngine.Vector2 bottomLeftRadius; // 0x7C
    public UnityEngine.Vector2 contentSize; // 0x84
    public UnityEngine.Vector2 textureSize; // 0x8C
    public float texturePixelsPerPoint; // 0x94
    public int leftSlice; // 0x98
    public int topSlice; // 0x9C
    public int rightSlice; // 0xA0
    public int bottomSlice; // 0xA4
    public float sliceScale; // 0xA8
    public UnityEngine.Vector4 rectInset; // 0xAC
    public NativeColorPage colorPage; // 0xBC
}

public class NativeResourceProvider : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6CEBC10
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class NativeSelectFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89795F0
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class NativeServerNameFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4421F80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class NativeVerifyFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976DD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class NegateCheckedInt16 : NegateCheckedInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE2370
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NegateCheckedInt32 : NegateCheckedInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE2250
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NegateCheckedInt64 : NegateCheckedInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE24D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NegateDouble : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE1E50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NegateInt16 : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE1A30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NegateInt32 : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE1B00
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NegateInt64 : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE1BD0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NegateSingle : NegateInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE1D10
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NestedBinXml : Object
{
    public SymbolTables symbolTables; // 0x10
    public int docState; // 0x30
    public NestedBinXml next; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC90942F0
}

public class NetworkCalling : Object
{
    public object SendCustomNetworkEventProxy;
    public object GetQueuedEventsProxy;
    public object GetAllQueuedEventsProxy;

    // ── Methods ──
    public void get_SendCustomNetworkEventProxy(){} // RVA: 0x7FFAC9E7C5B0
    public void set_SendCustomNetworkEventProxy(){} // RVA: 0x7FFAC9E7C650
    public void get_GetQueuedEventsProxy(){} // RVA: 0x7FFAC9E7C740
    public void set_GetQueuedEventsProxy(){} // RVA: 0x7FFAC9E7C7E0
    public void get_GetAllQueuedEventsProxy(){} // RVA: 0x7FFAC9E7C8D0
    public void set_GetAllQueuedEventsProxy(){} // RVA: 0x7FFAC9E7C970
    public void WithNetworkCallingContext(){} // RVA: 0x7FFAC9E7CA60
}

public class NetworkSurrogateSelector : Object
{
    public System.Runtime.Serialization.ISurrogateSelector _next; // 0x10

    // ── Methods ──
    public void ChainSelector(){} // RVA: 0x7FFACC079CC0
    public void GetNextSelector(){} // RVA: 0x7FFAC2F3C380
    public void GetSurrogate(){} // RVA: 0x7FFACC079DD0
    public void IsAllowedType(){} // RVA: 0x7FFACC07A300
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NeverPromise`1 : Object
{
    public System.Action`1<object> cancellationCallback;
    public System.Threading.CancellationToken cancellationToken;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70BF0
    public void CancellationCallback(){} // RVA: 0x7FFAC2C70A10
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class NewArrayExpressionProxy : Object
{
    public System.Linq.Expressions.NewArrayExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D72090
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Expressions(){} // RVA: 0x7FFAC356B610
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class NewDeviceMsg : Object
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFAC9602880
    public void Process(){} // RVA: 0x7FFAC9602EB0
}

public class NewEventsMsg : Object
{
    // ── Methods ──
    public void CreateResetEvent(){} // RVA: 0x7FFAC9603850
    public void CreateStateEvent(){} // RVA: 0x7FFAC9603950
    public void Create(){} // RVA: 0x7FFAC9603A60
    public void Process(){} // RVA: 0x7FFAC9603BE0
}

public class NewExpressionProxy : Object
{
    public System.Linq.Expressions.NewExpression Arguments; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D72170
    public void get_Arguments(){} // RVA: 0x7FFAC8D72250
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_Constructor(){} // RVA: 0x7FFAC356B610
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Members(){} // RVA: 0x7FFAC37735E0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
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
    public void Create(){} // RVA: 0x7FFAC96021B0
    public void Process(){} // RVA: 0x7FFAC9602610
}

public class NextFramePromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<NextFramePromise> NextNode;
    public NextFramePromise nextNode; // 0x10
    public int frameCount; // 0x18
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x48
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x50
    public bool cancelImmediately; // 0x68

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC948CB50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC948CCD0
    public void GetResult(){} // RVA: 0x7FFAC948D0D0
    public void GetStatus(){} // RVA: 0x7FFAC948D270
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC948D2C0
    public void OnCompleted(){} // RVA: 0x7FFAC948D300
    public void MoveNext(){} // RVA: 0x7FFAC948D380
    public void TryReturn(){} // RVA: 0x7FFAC948D4C0
}

public class NextResult : ValueType
{
    public Mediapipe.Packet`1<T> packet;
    public bool ok;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C76500
}

public class Nnapi : Object
{
    public Google.Protobuf.MessageParser`1<Nnapi> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
    public string CacheDir; // 0x18
    public string HasCacheDir; // 0x10
    public string ModelToken; // 0x20
    public string HasModelToken; // 0x18
    public string AcceleratorName; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC827F590
    public void get_Descriptor(){} // RVA: 0x7FFAC827F5F0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC827F670
    public void .ctor(){} // RVA: 0x7FFAC827F720 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC827F940
    public void get_CacheDir(){} // RVA: 0x7FFAC827F9A0
    public void set_CacheDir(){} // RVA: 0x7FFAC827FA10
    public void get_HasCacheDir(){} // RVA: 0x7FFAC4860B40
    public void ClearCacheDir(){} // RVA: 0x7FFAC515CC20
    public void get_ModelToken(){} // RVA: 0x7FFAC827FB10
    public void set_ModelToken(){} // RVA: 0x7FFAC827FB80
    public void get_HasModelToken(){} // RVA: 0x7FFAC495C6A0
    public void ClearModelToken(){} // RVA: 0x7FFAC81EE480
    public void get_AcceleratorName(){} // RVA: 0x7FFAC827FC80
    public void set_AcceleratorName(){} // RVA: 0x7FFAC827FCF0
    public void get_HasAcceleratorName(){} // RVA: 0x7FFAC81FF390
    public void ClearAcceleratorName(){} // RVA: 0x7FFAC53F2F70
    public void Equals(){} // RVA: 0x7FFAC827FE50 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC827FFD0
    public void ToString(){} // RVA: 0x7FFAC82800B0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8280100
    public void CalculateSize(){} // RVA: 0x7FFAC82801C0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8280410
    public void .cctor(){} // RVA: 0x7FFAC8280520
}

public class NoInput : Object
{
    public object touchCount;
    public object mousePresent;
    public object mousePosition;
    public object mouseButtonCount;
    public object anyKey;
    public object unscaledTime;
    public object doubleClickTime;

    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7FFAC2F21320
    public void GetAxisRaw(){} // RVA: 0x7FFAC37432E0
    public void get_touchCount(){} // RVA: 0x7FFAC34F9180
    public void GetTouch(){} // RVA: 0x7FFAC9B6E450
    public void ClearLastPenContactEvent(){} // RVA: 0x7FFAC2F21310
    public void GetLastPenContactEvent(){} // RVA: 0x7FFAC4024FF0
    public void get_mousePresent(){} // RVA: 0x7FFAC2F21320
    public void GetMouseButtonDown(){} // RVA: 0x7FFAC2F21320
    public void GetMouseButtonUp(){} // RVA: 0x7FFAC2F21320
    public void get_mousePosition(){} // RVA: 0x7FFAC7096B80
    public void get_mouseButtonCount(){} // RVA: 0x7FFAC34F9180
    public void get_anyKey(){} // RVA: 0x7FFAC2F21320
    public void get_unscaledTime(){} // RVA: 0x7FFAC37432E0
    public void get_doubleClickTime(){} // RVA: 0x7FFAC9B6E470
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NoNamespaceManager : XmlNamespaceManager
{
    public object DefaultNamespace;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void get_DefaultNamespace(){} // RVA: 0x7FFAC91BEA00
    public void PushScope(){} // RVA: 0x7FFAC2F21310
    public void PopScope(){} // RVA: 0x7FFAC2F21320
    public void AddNamespace(){} // RVA: 0x7FFAC2F21310
    public void RemoveNamespace(){} // RVA: 0x7FFAC2F21310
    public void GetEnumerator(){} // RVA: 0x7FFAC34F9180
    public void GetNamespacesInScope(){} // RVA: 0x7FFAC34F9180
    public void LookupNamespace(){} // RVA: 0x7FFAC91BEA40
    public void LookupPrefix(){} // RVA: 0x7FFAC34F9180
}

public class Node : Object
{
    public Newtonsoft.Json.Utilities.StructMultiKey`2<string,string> _key; // 0x10
    public System.Type _value; // 0x20
    public Node<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type> _next; // 0x28
    public int _hashcode; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC65B2CC0
}

public class NodeData : Object
{
    public NodeData None;
    public 0x6B15D5F0 LineNo; // 0x10
    public string LinePos; // 0x18
    public string IsEmptyElement; // 0x20
    public string IsDefaultAttribute; // 0x28
    public string ValueBuffered; // 0x30
    public string StringValue; // 0x38
    public char[] chars; // 0x40
    public int valueStartPos; // 0x48
    public int valueLength; // 0x4C
    public System.Xml.LineInfo lineInfo; // 0x50
    public System.Xml.LineInfo lineInfo2; // 0x58
    public char quoteChar; // 0x60
    public int depth; // 0x64
    public bool isEmptyOrDefault; // 0x68
    public int entityId; // 0x6C
    public bool xmlContextPushed; // 0x70
    public NodeData nextAttrValueChunk; // 0x78
    public object schemaType; // 0x80
    public object typedValue; // 0x88

    // ── Methods ──
    public void get_None(){} // RVA: 0x7FFAC91BF4B0
    public void .ctor(){} // RVA: 0x7FFAC91BF5A0
    public void get_LineNo(){} // RVA: 0x7FFAC30F10E0
    public void get_LinePos(){} // RVA: 0x7FFAC38913D0
    public void get_IsEmptyElement(){} // RVA: 0x7FFAC91BF5C0
    public void set_IsEmptyElement(){} // RVA: 0x7FFAC2FE9580
    public void get_IsDefaultAttribute(){} // RVA: 0x7FFAC91BF5D0
    public void set_IsDefaultAttribute(){} // RVA: 0x7FFAC2FE9580
    public void get_ValueBuffered(){} // RVA: 0x7FFAC3EB2D00
    public void get_StringValue(){} // RVA: 0x7FFAC91BF5E0
    public void TrimSpacesInValue(){} // RVA: 0x7FFAC91BF670
    public void Clear(){} // RVA: 0x7FFAC91BF7F0
    public void ClearName(){} // RVA: 0x7FFAC91BF9D0
    public void SetLineInfo(){} // RVA: 0x7FFAC91BFB90
    public void SetLineInfo2(){} // RVA: 0x7FFAC91BFBA0
    public void SetValueNode(){} // RVA: 0x7FFAC91BFC30 | overloaded x2
    public void SetNamedNode(){} // RVA: 0x7FFAC91BFDA0 | overloaded x2
    public void SetValue(){} // RVA: 0x7FFAC91C0020 | overloaded x2
    public void OnBufferInvalidated(){} // RVA: 0x7FFAC91C00F0
    public void CopyTo(){} // RVA: 0x7FFAC91C0210 | overloaded x2
    public void GetNameWPrefix(){} // RVA: 0x7FFAC91C0290
    public void CreateNameWPrefix(){} // RVA: 0x7FFAC91C0400
    public void System.IComparable.CompareTo(){} // RVA: 0x7FFAC91C0550
}

public class NodeEnumerator : Object
{
    public System.Collections.ListDictionaryInternal Current; // 0x10
    public DictionaryNode Entry; // 0x18
    public int Key; // 0x20
    public bool Value; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8591DC0
    public void get_Current(){} // RVA: 0x7FFAC8591EA0
    public void get_Entry(){} // RVA: 0x7FFAC8591F60
    public void get_Key(){} // RVA: 0x7FFAC8591FE0
    public void get_Value(){} // RVA: 0x7FFAC8592050
    public void MoveNext(){} // RVA: 0x7FFAC85920C0
    public void Reset(){} // RVA: 0x7FFAC85921E0
}

public class NodeKeyValueCollection : Object
{
    public System.Collections.ListDictionaryInternal System.Collections.ICollection.Count; // 0x10
    public bool System.Collections.ICollection.IsSynchronized; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC45687E0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC85922B0
    public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC85924B0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC85924F0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC85925B0
}

public class NodeKeyValueEnumerator : Object
{
    public System.Collections.ListDictionaryInternal Current; // 0x10
    public DictionaryNode current; // 0x18
    public int version; // 0x20
    public bool isKeys; // 0x24
    public bool start; // 0x25

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85926D0
    public void get_Current(){} // RVA: 0x7FFAC85927C0
    public void MoveNext(){} // RVA: 0x7FFAC8592840
    public void Reset(){} // RVA: 0x7FFAC8592960
}

public class NodePath : ValueType
{
    public int _nodeID;
    public int _mainTreeNodeID;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C72E60
}

public class Noise : ValueType
{
    public float m_ScrollOffset; // 0x10
}

public class NoiseModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9958D70
    public void set_enabled(){} // RVA: 0x7FFAC9958DC0
    public void get_separateAxes(){} // RVA: 0x7FFAC9958E20
    public void set_separateAxes(){} // RVA: 0x7FFAC9958E70
    public void get_strength(){} // RVA: 0x7FFAC9958ED0
    public void set_strength(){} // RVA: 0x7FFAC9958F40
    public void get_strengthMultiplier(){} // RVA: 0x7FFAC9958FA0
    public void set_strengthMultiplier(){} // RVA: 0x7FFAC9958FF0
    public void get_strengthX(){} // RVA: 0x7FFAC9959050
    public void set_strengthX(){} // RVA: 0x7FFAC99590C0
    public void get_strengthXMultiplier(){} // RVA: 0x7FFAC9959120
    public void set_strengthXMultiplier(){} // RVA: 0x7FFAC9959170
    public void get_strengthY(){} // RVA: 0x7FFAC99591D0
    public void set_strengthY(){} // RVA: 0x7FFAC9959240
    public void get_strengthYMultiplier(){} // RVA: 0x7FFAC99592A0
    public void set_strengthYMultiplier(){} // RVA: 0x7FFAC99592F0
    public void get_strengthZ(){} // RVA: 0x7FFAC9959350
    public void set_strengthZ(){} // RVA: 0x7FFAC99593C0
    public void get_strengthZMultiplier(){} // RVA: 0x7FFAC9959420
    public void set_strengthZMultiplier(){} // RVA: 0x7FFAC9959470
    public void get_frequency(){} // RVA: 0x7FFAC99594D0
    public void set_frequency(){} // RVA: 0x7FFAC9959520
    public void get_damping(){} // RVA: 0x7FFAC9959580
    public void set_damping(){} // RVA: 0x7FFAC99595D0
    public void get_octaveCount(){} // RVA: 0x7FFAC9959630
    public void set_octaveCount(){} // RVA: 0x7FFAC9959680
    public void get_octaveMultiplier(){} // RVA: 0x7FFAC99596E0
    public void set_octaveMultiplier(){} // RVA: 0x7FFAC9959730
    public void get_octaveScale(){} // RVA: 0x7FFAC9959790
    public void set_octaveScale(){} // RVA: 0x7FFAC99597E0
    public void get_quality(){} // RVA: 0x7FFAC9959840
    public void set_quality(){} // RVA: 0x7FFAC9959890
    public void get_scrollSpeed(){} // RVA: 0x7FFAC99598F0
    public void set_scrollSpeed(){} // RVA: 0x7FFAC9959960
    public void get_scrollSpeedMultiplier(){} // RVA: 0x7FFAC99599C0
    public void set_scrollSpeedMultiplier(){} // RVA: 0x7FFAC9959A10
    public void get_remapEnabled(){} // RVA: 0x7FFAC9959A70
    public void set_remapEnabled(){} // RVA: 0x7FFAC9959AC0
    public void get_remap(){} // RVA: 0x7FFAC9959B20
    public void set_remap(){} // RVA: 0x7FFAC9959B90
    public void get_remapMultiplier(){} // RVA: 0x7FFAC9959BF0
    public void set_remapMultiplier(){} // RVA: 0x7FFAC9959C40
    public void get_remapX(){} // RVA: 0x7FFAC9959CA0
    public void set_remapX(){} // RVA: 0x7FFAC9959D10
    public void get_remapXMultiplier(){} // RVA: 0x7FFAC9959D70
    public void set_remapXMultiplier(){} // RVA: 0x7FFAC9959DC0
    public void get_remapY(){} // RVA: 0x7FFAC9959E20
    public void set_remapY(){} // RVA: 0x7FFAC9959E90
    public void get_remapYMultiplier(){} // RVA: 0x7FFAC9959EF0
    public void set_remapYMultiplier(){} // RVA: 0x7FFAC9959F40
    public void get_remapZ(){} // RVA: 0x7FFAC9959FA0
    public void set_remapZ(){} // RVA: 0x7FFAC995A010
    public void get_remapZMultiplier(){} // RVA: 0x7FFAC995A070
    public void set_remapZMultiplier(){} // RVA: 0x7FFAC995A0C0
    public void get_positionAmount(){} // RVA: 0x7FFAC995A120
    public void set_positionAmount(){} // RVA: 0x7FFAC995A190
    public void get_rotationAmount(){} // RVA: 0x7FFAC995A1F0
    public void set_rotationAmount(){} // RVA: 0x7FFAC995A260
    public void get_sizeAmount(){} // RVA: 0x7FFAC995A2C0
    public void set_sizeAmount(){} // RVA: 0x7FFAC995A330
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9958D70
    public void set_enabled_Injected(){} // RVA: 0x7FFAC9958DC0
    public void get_separateAxes_Injected(){} // RVA: 0x7FFAC9958E20
    public void set_separateAxes_Injected(){} // RVA: 0x7FFAC9958E70
    public void get_strength_Injected(){} // RVA: 0x7FFAC995A390
    public void set_strength_Injected(){} // RVA: 0x7FFAC995A3F0
    public void get_strengthMultiplier_Injected(){} // RVA: 0x7FFAC9958FA0
    public void set_strengthMultiplier_Injected(){} // RVA: 0x7FFAC9958FF0
    public void get_strengthX_Injected(){} // RVA: 0x7FFAC995A450
    public void set_strengthX_Injected(){} // RVA: 0x7FFAC995A4B0
    public void get_strengthXMultiplier_Injected(){} // RVA: 0x7FFAC9959120
    public void set_strengthXMultiplier_Injected(){} // RVA: 0x7FFAC9959170
    public void get_strengthY_Injected(){} // RVA: 0x7FFAC995A510
    public void set_strengthY_Injected(){} // RVA: 0x7FFAC995A570
    public void get_strengthYMultiplier_Injected(){} // RVA: 0x7FFAC99592A0
    public void set_strengthYMultiplier_Injected(){} // RVA: 0x7FFAC99592F0
    public void get_strengthZ_Injected(){} // RVA: 0x7FFAC995A5D0
    public void set_strengthZ_Injected(){} // RVA: 0x7FFAC995A630
    public void get_strengthZMultiplier_Injected(){} // RVA: 0x7FFAC9959420
    public void set_strengthZMultiplier_Injected(){} // RVA: 0x7FFAC9959470
    public void get_frequency_Injected(){} // RVA: 0x7FFAC99594D0
    public void set_frequency_Injected(){} // RVA: 0x7FFAC9959520
    public void get_damping_Injected(){} // RVA: 0x7FFAC9959580
    public void set_damping_Injected(){} // RVA: 0x7FFAC99595D0
    public void get_octaveCount_Injected(){} // RVA: 0x7FFAC9959630
    public void set_octaveCount_Injected(){} // RVA: 0x7FFAC9959680
    public void get_octaveMultiplier_Injected(){} // RVA: 0x7FFAC99596E0
    public void set_octaveMultiplier_Injected(){} // RVA: 0x7FFAC9959730
    public void get_octaveScale_Injected(){} // RVA: 0x7FFAC9959790
    public void set_octaveScale_Injected(){} // RVA: 0x7FFAC99597E0
    public void get_quality_Injected(){} // RVA: 0x7FFAC9959840
    public void set_quality_Injected(){} // RVA: 0x7FFAC9959890
    public void get_scrollSpeed_Injected(){} // RVA: 0x7FFAC995A690
    public void set_scrollSpeed_Injected(){} // RVA: 0x7FFAC995A6F0
    public void get_scrollSpeedMultiplier_Injected(){} // RVA: 0x7FFAC99599C0
    public void set_scrollSpeedMultiplier_Injected(){} // RVA: 0x7FFAC9959A10
    public void get_remapEnabled_Injected(){} // RVA: 0x7FFAC9959A70
    public void set_remapEnabled_Injected(){} // RVA: 0x7FFAC9959AC0
    public void get_remap_Injected(){} // RVA: 0x7FFAC995A750
    public void set_remap_Injected(){} // RVA: 0x7FFAC995A7B0
    public void get_remapMultiplier_Injected(){} // RVA: 0x7FFAC9959BF0
    public void set_remapMultiplier_Injected(){} // RVA: 0x7FFAC9959C40
    public void get_remapX_Injected(){} // RVA: 0x7FFAC995A810
    public void set_remapX_Injected(){} // RVA: 0x7FFAC995A870
    public void get_remapXMultiplier_Injected(){} // RVA: 0x7FFAC9959D70
    public void set_remapXMultiplier_Injected(){} // RVA: 0x7FFAC9959DC0
    public void get_remapY_Injected(){} // RVA: 0x7FFAC995A8D0
    public void set_remapY_Injected(){} // RVA: 0x7FFAC995A930
    public void get_remapYMultiplier_Injected(){} // RVA: 0x7FFAC9959EF0
    public void set_remapYMultiplier_Injected(){} // RVA: 0x7FFAC9959F40
    public void get_remapZ_Injected(){} // RVA: 0x7FFAC995A990
    public void set_remapZ_Injected(){} // RVA: 0x7FFAC995A9F0
    public void get_remapZMultiplier_Injected(){} // RVA: 0x7FFAC995A070
    public void set_remapZMultiplier_Injected(){} // RVA: 0x7FFAC995A0C0
    public void get_positionAmount_Injected(){} // RVA: 0x7FFAC995AA50
    public void set_positionAmount_Injected(){} // RVA: 0x7FFAC995AAB0
    public void get_rotationAmount_Injected(){} // RVA: 0x7FFAC995AB10
    public void set_rotationAmount_Injected(){} // RVA: 0x7FFAC995AB70
    public void get_sizeAmount_Injected(){} // RVA: 0x7FFAC995ABD0
    public void set_sizeAmount_Injected(){} // RVA: 0x7FFAC995AC30
}

public class NoiseParams : ValueType
{
    public float Frequency; // 0x10
    public float Amplitude; // 0x14
    public bool Constant; // 0x18

    // ── Methods ──
    public void GetValueAt(){} // RVA: 0x7FFAC484D480
}

public class NonConstructable : Object
{
    public object Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated;

    // ── Methods ──
    public void Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated(){} // RVA: 0x7FFAC2F21320
    public void Instantiate(){} // RVA: 0x7FFAC99A5330
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NoopDisposable : Object
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class NotBoolean : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE5640
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotByte : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE5D30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualBoolean : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE3900
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualByte : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE3EA0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualByteLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4A20
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualChar : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE3BD0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualCharLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE46F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualDouble : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4360
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualDoubleLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4F90
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualInt16 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE3AE0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualInt16LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE45E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualInt32 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE3CC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualInt32LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4800
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualInt64 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE3DB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualInt64LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4910
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualReference : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4460
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualSByte : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE39F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualSByteLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE44D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualSingle : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4260
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualSingleLiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4E60
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualUInt16 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE3F90
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualUInt16LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4B30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualUInt32 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4080
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualUInt32LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4C40
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualUInt64 : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4170
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotEqualUInt64LiftedToNull : NotEqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE4D50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotInt16 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE5920
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotInt32 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE5850
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotInt64 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE5710
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotSByte : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE5E00
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotUInt16 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE5C60
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotUInt32 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE5B30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NotUInt64 : NotInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE59F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class NoteOnEvent : ValueType
{
    public float StartTimeMs; // 0x10
    public byte Velocity; // 0x14
    public int Count; // 0x18

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFACBFFDB40
    public void GetHashCode(){} // RVA: 0x7FFAC8649D10
}

public class NotificationEntry : ValueType
{
    public double triggerInEditor; // 0x10
    public UnityEngine.Playables.INotification prewarm; // 0x18
    public bool triggerOnce; // 0x20
    public 0x6B282398 flags; // 0x22

    // ── Methods ──
    public void get_triggerInEditor(){} // RVA: 0x7FFAC8F78840
    public void get_prewarm(){} // RVA: 0x7FFAC97D8590
    public void get_triggerOnce(){} // RVA: 0x7FFAC97D85A0
}

public class NotificationType : Object
{
    public string ALL;
    public string BROADCAST;
    public string FRIEND_REQUEST;
    public string INVITE;
    public string REQUEST_INVITE;
    public string INVITE_RESPONSE;
    public string REQUEST_INVITE_RESPONSE;
    public string MESSAGE;
    public string LOCAL_NOTIFS;
    public string GROUP;
    public string ECONOMY;
    public string IMPOSTOR;
    public string MODERATION;
    public string SHARING;
    public string PROMOTION;
    public string EVENT;
    public string BOOP;
    public string All;
    public string Broadcast;
    public string Friendrequest;
    public string Invite;
    public string Requestinvite;
    public string InviteResponse;
    public string RequestInviteResponse;
    public string Message;
    public string Group;
    public string LocalNotifs;
    public string Boop;
}

public class NtDll : Object
{
    // ── Methods ──
    public void NtCreateFile(){} // RVA: 0x7FFAC838A660
    public void CreateFile(){} // RVA: 0x7FFAC838A710
    public void NtQueryDirectoryFile(){} // RVA: 0x7FFAC838A980
    public void RtlNtStatusToDosError(){} // RVA: 0x7FFAC838AA50
}

public class NullDisposable : Object
{
    public System.IDisposable Instance;

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC2F21310
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFACC0ED6C0
}

public class NullProgress`1 : Object
{
    public System.IProgress`1<T> Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Report(){} // RVA: 0x7FFAC2E8DC40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class NullStream : Stream
{
    public System.Threading.Tasks.Task`1<int> CanRead;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85EA120
    public void get_CanRead(){} // RVA: 0x7FFAC3006850
    public void get_CanWrite(){} // RVA: 0x7FFAC3006850
    public void get_CanSeek(){} // RVA: 0x7FFAC3006850
    public void get_Length(){} // RVA: 0x7FFAC34F9180
    public void get_Position(){} // RVA: 0x7FFAC34F9180
    public void set_Position(){} // RVA: 0x7FFAC2F21310
    public void CopyTo(){} // RVA: 0x7FFAC85EA170
    public void CopyToAsync(){} // RVA: 0x7FFAC85EA180
    public void Dispose(){} // RVA: 0x7FFAC2F21310
    public void Flush(){} // RVA: 0x7FFAC2F21310
    public void FlushAsync(){} // RVA: 0x7FFAC85EA290
    public void BeginRead(){} // RVA: 0x7FFAC85EA370
    public void EndRead(){} // RVA: 0x7FFAC85EA400
    public void BeginWrite(){} // RVA: 0x7FFAC85EA5A0
    public void EndWrite(){} // RVA: 0x7FFAC85EA630
    public void Read(){} // RVA: 0x7FFAC34F9180 | overloaded x2
    public void ReadAsync(){} // RVA: 0x7FFAC85EA830 | overloaded x2
    public void ReadByte(){} // RVA: 0x7FFAC32BD0E0
    public void Write(){} // RVA: 0x7FFAC2F21310 | overloaded x2
    public void WriteAsync(){} // RVA: 0x7FFAC85EA9B0 | overloaded x2
    public void WriteByte(){} // RVA: 0x7FFAC2F21310
    public void Seek(){} // RVA: 0x7FFAC34F9180
    public void SetLength(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC85EAB20
}

public class NullStreamReader : StreamReader
{
    public object BaseStream;
    public object CurrentEncoding;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85C5D30
    public void get_BaseStream(){} // RVA: 0x7FFAC85C5F10
    public void get_CurrentEncoding(){} // RVA: 0x7FFAC85C5F70
    public void Dispose(){} // RVA: 0x7FFAC2F21310
    public void Peek(){} // RVA: 0x7FFAC32BD0E0
    public void Read(){} // RVA: 0x7FFAC34F9180 | overloaded x2
    public void ReadLine(){} // RVA: 0x7FFAC34F9180
    public void ReadToEnd(){} // RVA: 0x7FFAC85C5F80
    public void ReadBuffer(){} // RVA: 0x7FFAC34F9180
}

public class NullTextReader : TextReader
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85CFCE0
    public void Read(){} // RVA: 0x7FFAC34F9180
    public void ReadLine(){} // RVA: 0x7FFAC34F9180
}

public class NullTextWriter : TextWriter
{
    public object Encoding;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85D2900
    public void get_Encoding(){} // RVA: 0x7FFAC85C5F70
    public void Write(){} // RVA: 0x7FFAC2F21310 | overloaded x3
    public void WriteLine(){} // RVA: 0x7FFAC2F21310 | overloaded x3
}
