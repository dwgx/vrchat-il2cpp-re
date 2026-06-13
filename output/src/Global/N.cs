// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 541

public class NameObjectEntry
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xF19AE0
}

public class NameObjectKeysEnumerator
{
    public int _pos; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6CBD670
    public void MoveNext(){} // RVA: 0x6CBD6F0
    public void Reset(){} // RVA: 0x6CBD7D0
    public void get_Current(){} // RVA: 0x6CBD860
}

public class NamePart
{
    public Google.Protobuf.MessageParser`1<NamePart> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public string NamePart_DefaultValue; // 0x8
    public string namePart_; // 0x20
    public bool IsExtensionDefaultValue; // 0x10
    public bool isExtension_; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x5A77940
    public void get_Descriptor(){} // RVA: 0x5A779A0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5A77A20
    public void .ctor(){} // RVA: 0x5A77AD0 | overloaded x2
    public void Clone(){} // RVA: 0x5A77C40
    public void get_NamePart_(){} // RVA: 0x5A77DE0
    public void set_NamePart_(){} // RVA: 0x5A77E50
    public void get_HasNamePart_(){} // RVA: 0x1E3EC10
    public void ClearNamePart_(){} // RVA: 0x5A57060
    public void get_IsExtension(){} // RVA: 0x5A77F50
    public void set_IsExtension(){} // RVA: 0x5A77FC0
    public void get_HasIsExtension(){} // RVA: 0x5A5C3B0
    public void ClearIsExtension(){} // RVA: 0x5A5C3C0
    public void Equals(){} // RVA: 0x5A78100 | overloaded x2
    public void GetHashCode(){} // RVA: 0x5A78200
    public void ToString(){} // RVA: 0x5A782D0
    public void WriteTo(){} // RVA: 0x5A39740
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A78320
    public void CalculateSize(){} // RVA: 0x5A783B0
    public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A78570
    public void .cctor(){} // RVA: 0x5A78640
}

public class NameType : `
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xF19AE0
    public void CompareTo(){} // RVA: 0x673CE50
}

public class NameType : `
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xF19AE0
    public void CompareTo(){} // RVA: 0x6754780
}

public class Namespace
{
    // ── Methods ──
    public void Set(){} // RVA: 0x6A30750
}

public class Namespace
{
    // ── Methods ──
    public void Set(){} // RVA: 0x6A3FB40
    public void WriteDecl(){} // RVA: 0x6A3FC00
}

public class NamespaceDecl
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x68FD500
}

public class NamespaceDeclaration
{
    // ── Methods ──
    public void Set(){} // RVA: 0x6A8F5C0
}

public class NamespaceDeclaration
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class NamespaceManager
{
    // ── Methods ──
    public void LookupNamespace(){} // RVA: 0x13DCE00
    public void .ctor(){} // RVA: 0x2DD310
}

public class NamespacePrefixForQName
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5F28620
    public void LookupNamespace(){} // RVA: 0x699EF00
    public void LookupPrefix(){} // RVA: 0x699EF60
    public void GetNamespacesInScope(){} // RVA: 0x699EFC0
}

public class NamespaceResolverProxy
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DEE30
    public void System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(){} // RVA: 0x6A3F8B0
    public void System.Xml.IXmlNamespaceResolver.LookupNamespace(){} // RVA: 0x6A3F8F0
    public void System.Xml.IXmlNamespaceResolver.LookupPrefix(){} // RVA: 0x6A3F910
}

public class Native
{
    // ── Methods ──
    public void IsChangedTracks(){} // RVA: 0x1CB0B30
    public void GetTrackCount(){} // RVA: 0x1CB0BC0
    public void GetTrackInfo(){} // RVA: 0x1CB0C50
    public void SetActiveTrack(){} // RVA: 0x1CB0DC0
    public void IsChangedTextCue(){} // RVA: 0x1CB0E60
    public void GetCurrentTextCue(){} // RVA: 0x1CB0EE0
    public void GetTimeRanges(){} // RVA: 0x1CB0F60
    public void Init(){} // RVA: 0x1CB1090
    public void Deinit(){} // RVA: 0x1CB1110
    public void GetPluginVersion(){} // RVA: 0x1CB1180
    public void IsTrialVersion(){} // RVA: 0x1CB11F0
    public void BeginOpenSource(){} // RVA: 0x1CB1260
    public void EndOpenSource(){} // RVA: 0x1CB13F0
    public void OpenSourceFromBuffer(){} // RVA: 0x1CB1490
    public void StartOpenSourceFromBuffer(){} // RVA: 0x1CB1640
    public void AddChunkToSourceBuffer(){} // RVA: 0x1CB16E0
    public void EndOpenSourceFromBuffer(){} // RVA: 0x1CB17A0
    public void CloseSource(){} // RVA: 0x1CB1920
    public void GetPlayerDescription(){} // RVA: 0x1CB19A0
    public void SetCustomMovParserEnabled(){} // RVA: 0x1CB1A20
    public void SetHapNotchLCEnabled(){} // RVA: 0x1CB1AB0
    public void SetFrameBufferingEnabled(){} // RVA: 0x1CB1B40
    public void SetStereoDetectEnabled(){} // RVA: 0x1CB1BE0
    public void SetTextTrackSupportEnabled(){} // RVA: 0x1CB1C70
    public void SetAudioDelayEnabled(){} // RVA: 0x1CB1D00
    public void SetFacebookAudio360SupportEnabled(){} // RVA: 0x1CB1DB0
    public void SetDecoderHints(){} // RVA: 0x1CB1E40
    public void GetDecoderPerformance(){} // RVA: 0x1CB1EE0
    public void GetLastErrorCode(){} // RVA: 0x1CB1F90
    public void GetLastExtendedErrorCode(){} // RVA: 0x1CB2010
    public void Play(){} // RVA: 0x1CB2090
    public void Pause(){} // RVA: 0x1CB2110
    public void SetMuted(){} // RVA: 0x1CB2190
    public void SetVolume(){} // RVA: 0x1CB2220
    public void SetBalance(){} // RVA: 0x1CB22B0
    public void SetLooping(){} // RVA: 0x1CB2340
    public void HasVideo(){} // RVA: 0x1CB23D0
    public void HasAudio(){} // RVA: 0x1CB2450
    public void GetWidth(){} // RVA: 0x1CB24D0
    public void GetHeight(){} // RVA: 0x1CB2550
    public void GetFrameRate(){} // RVA: 0x1CB25D0
    public void GetStereoPacking(){} // RVA: 0x1CB2650
    public void GetDuration(){} // RVA: 0x1CB26D0
    public void IsPlaybackStalled(){} // RVA: 0x1CB2750
    public void HasMetaData(){} // RVA: 0x1CB27D0
    public void CanPlay(){} // RVA: 0x1CB2850
    public void IsSeeking(){} // RVA: 0x1CB28D0
    public void IsPlaying(){} // RVA: 0x1CB2950
    public void IsFinished(){} // RVA: 0x1CB29D0
    public void IsBuffering(){} // RVA: 0x1CB2A50
    public void GetCurrentTime(){} // RVA: 0x1CB2AD0
    public void SetCurrentTime(){} // RVA: 0x1CB2B50
    public void GetPlaybackRate(){} // RVA: 0x1CB2BF0
    public void SetPlaybackRate(){} // RVA: 0x1CB2C70
    public void StartExtractFrame(){} // RVA: 0x1CB2D00
    public void WaitForExtract(){} // RVA: 0x1CB2D80
    public void Update(){} // RVA: 0x1CB2E00
    public void EndUpdate(){} // RVA: 0x1CB2E80
    public void GetTexturePointer(){} // RVA: 0x1CB2F00
    public void GetTextureFormat(){} // RVA: 0x1CB2F80
    public void IsTextureTopDown(){} // RVA: 0x1CB3000
    public void IsTextureSampleLinear(){} // RVA: 0x1CB3080
    public void GetTextureFrameCount(){} // RVA: 0x1CB3100
    public void GetTextureTimeStamp(){} // RVA: 0x1CB3180
    public void GetTexturePixelAspectRatio(){} // RVA: 0x1CB3200
    public void GetRenderEventFunc(){} // RVA: 0x1CB3280
    public void GrabAudio(){} // RVA: 0x1CB32F0
    public void GetAudioBufferedSampleCount(){} // RVA: 0x1CB33B0
    public void GetAudioChannelCount(){} // RVA: 0x1CB3430
    public void GetAudioChannelMask(){} // RVA: 0x1CB34B0
    public void SetAudioChannelMode(){} // RVA: 0x1CB3530
    public void SetHeadOrientation(){} // RVA: 0x1CB35C0
    public void SetAudioFocusEnabled(){} // RVA: 0x1CB3680
    public void SetAudioFocusProps(){} // RVA: 0x1CB3710
    public void SetAudioFocusRotation(){} // RVA: 0x1CB37B0
    public void GetBufferedFramesState(){} // RVA: 0x1CB3870
    public void LockTextureFrame(){} // RVA: 0x1CB3900
    public void UnlockTextureFrame(){} // RVA: 0x1CB39C0
    public void ReleaseTextureFrame(){} // RVA: 0x1CB3A50
    public void FlushFrameBuffering(){} // RVA: 0x1CB3AE0
}

public class Native
{
    // ── Methods ──
    public void IsChangedTracks(){} // RVA: 0x1CB7370
    public void GetTrackCount(){} // RVA: 0x1CB7400
    public void GetTrackInfo(){} // RVA: 0x1CB7490
    public void SetActiveTrack(){} // RVA: 0x1CB7600
    public void IsChangedTextCue(){} // RVA: 0x1CB76A0
    public void GetCurrentTextCue(){} // RVA: 0x1CB7720
    public void GetPluginVersionStringPointer(){} // RVA: 0x1CB77A0
    public void GetPluginVersion(){} // RVA: 0x1CB7810
    public void CreatePlayer(){} // RVA: 0x1CB78E0
    public void DestroyPlayer(){} // RVA: 0x1CB7950
    public void OpenMedia(){} // RVA: 0x1CB79D0
    public void CloseMedia(){} // RVA: 0x1CB7AB0
    public void Pause(){} // RVA: 0x1CB7B30
    public void Play(){} // RVA: 0x1CB7BB0
    public void SetAudioVolume(){} // RVA: 0x1CB7C30
    public void SetAudioBalance(){} // RVA: 0x1CB7CC0
    public void SetPlaybackRate(){} // RVA: 0x1CB7D50
    public void SetAudioMuted(){} // RVA: 0x1CB7DE0
    public void GetAudioVolume(){} // RVA: 0x1CB7E70
    public void IsAudioMuted(){} // RVA: 0x1CB7EF0
    public void GetAudioBalance(){} // RVA: 0x1CB7F70
    public void GetPlaybackRate(){} // RVA: 0x1CB7FF0
    public void SetLooping(){} // RVA: 0x1CB8070
    public void IsLooping(){} // RVA: 0x1CB8100
    public void GetLastErrorCode(){} // RVA: 0x1CB8180
    public void Update(){} // RVA: 0x1CB8200
    public void GetDuration(){} // RVA: 0x1CB8280
    public void GetStereoPacking(){} // RVA: 0x1CB8300
    public void GetCurrentPosition(){} // RVA: 0x1CB8380
    public void GetLatestFrame(){} // RVA: 0x1CB8400
    public void GetPlaybackState(){} // RVA: 0x1CB84D0
    public void GetActiveVideoTrackInfo(){} // RVA: 0x1CB8550
    public void GetActiveAudioTrackInfo(){} // RVA: 0x1CB85E0
    public void GetCurrentDateTimeSecondsSince1970(){} // RVA: 0x1CB8670
    public void SetLiveOffset(){} // RVA: 0x1CB86F0
    public void DebugValues(){} // RVA: 0x1CB8780
    public void Seek(){} // RVA: 0x1CB8830
    public void SetNextAuthData(){} // RVA: 0x1CB8AF0 | overloaded x2
    public void GetTimeRanges(){} // RVA: 0x1CB8CF0
    public void GetRenderEventFunc(){} // RVA: 0x1CB8E20
    public void IssueRenderThreadEvent_UpdateAllTextures(){} // RVA: 0x1CB5610
    public void IssueRenderThreadEvent_FreeAllTextures(){} // RVA: 0x1CB8E90
}

public class Native
{
    // ── Methods ──
    public void SteamAPI_Init(){} // RVA: 0x20AC9F0
    public void SteamAPI_Shutdown(){} // RVA: 0x20ACA60
    public void SteamAPI_GetHSteamPipe(){} // RVA: 0x20ACAD0
    public void SteamAPI_RestartAppIfNecessary(){} // RVA: 0x20ACB40
}

public class NativeArrayHelper`1 : _handle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BAA0
    public void Dispose(){} // RVA: 0x24A50
}

public class NativeBorderParams
{
}

public class NativeColorPage
{
}

public class NativeIoCompletionCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5BF4850
    public void Invoke(){} // RVA: 0x33B3F20
}

public class NativePacketCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5AD59F0
    public void Invoke(){} // RVA: 0x33B1CF0
}

public class NativePacketsCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x439410
    public void Invoke(){} // RVA: 0x4394E0
}

public class NativeRectParams
{
}

public class NativeResourceProvider
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4437670
    public void Invoke(){} // RVA: 0x439370
}

public class NativeSelectFunc
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x61E1DE0
    public void Invoke(){} // RVA: 0xC09580
}

public class NativeServerNameFunc
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1969CF0
    public void Invoke(){} // RVA: 0x338C60
}

public class NativeVerifyFunc
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x61DF5C0
    public void Invoke(){} // RVA: 0x4394E0
}

public class NegateCheckedInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664B8B0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NegateCheckedInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664B790
    public void .ctor(){} // RVA: 0x2DD310
}

public class NegateCheckedInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664BA10
    public void .ctor(){} // RVA: 0x2DD310
}

public class NegateDouble
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664B390
    public void .ctor(){} // RVA: 0x2DD310
}

public class NegateInt16
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664AF70
    public void .ctor(){} // RVA: 0x2DD310
}

public class NegateInt32
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664B040
    public void .ctor(){} // RVA: 0x2DD310
}

public class NegateInt64
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664B110
    public void .ctor(){} // RVA: 0x2DD310
}

public class NegateSingle
{
    // ── Methods ──
    public void Run(){} // RVA: 0x664B250
    public void .ctor(){} // RVA: 0x2DD310
}

public class NestedBinXml
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x68FD7D0
}

public class NetworkCalling
{
    public object _GetDroneFromGameObject;
    public object get__GetPropFromGameObject;

    // ── Methods ──
    public void get_SendCustomNetworkEventProxy(){} // RVA: 0x76F2390
    public void set_SendCustomNetworkEventProxy(){} // RVA: 0x76F2430
    public void get_GetQueuedEventsProxy(){} // RVA: 0x76F2520
    public void set_GetQueuedEventsProxy(){} // RVA: 0x76F25C0
    public void get_GetAllQueuedEventsProxy(){} // RVA: 0x76F26B0
    public void set_GetAllQueuedEventsProxy(){} // RVA: 0x76F2750
    public void WithNetworkCallingContext(){} // RVA: 0x76F2840
}

public class NetworkSurrogateSelector
{
    // ── Methods ──
    public void ChainSelector(){} // RVA: 0x9A9D780
    public void GetNextSelector(){} // RVA: 0x2F8380
    public void GetSurrogate(){} // RVA: 0x9A9D890
    public void IsAllowedType(){} // RVA: 0x9A9DDC0
    public void .ctor(){} // RVA: 0x2DD310
}

public class NeverPromise`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x24CC0
    public void CancellationCallback(){} // RVA: 0x24AE0
    public void GetResult(){} // RVA: 0x283FA0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0xD840
    public void OnCompleted(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x24C40
    public void .cctor(){} // RVA: 0x24A80
}

public class NewArrayExpressionProxy
{
    public System.Linq.Expressions.NewArrayExpression _node; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x65DB630
    public void get_CanReduce(){} // RVA: 0x7F02E0
    public void get_DebugView(){} // RVA: 0x65DA6E0
    public void get_Expressions(){} // RVA: 0xB2EEA0
    public void get_NodeType(){} // RVA: 0x7F01B0
    public void get_Type(){} // RVA: 0x7F0250
}

public class NewDeviceMsg
{
    // ── Methods ──
    public void Create(){} // RVA: 0x6E6A130
    public void Process(){} // RVA: 0x6E6A760
}

public class NewEventsMsg
{
    // ── Methods ──
    public void CreateResetEvent(){} // RVA: 0x6E6B100
    public void CreateStateEvent(){} // RVA: 0x6E6B200
    public void Create(){} // RVA: 0x6E6B310
    public void Process(){} // RVA: 0x6E6B490
}

public class NewExpressionProxy
{
    public System.Linq.Expressions.NewExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x65DB710
    public void get_Arguments(){} // RVA: 0x65DB7F0
    public void get_CanReduce(){} // RVA: 0x7F02E0
    public void get_Constructor(){} // RVA: 0xB2EEA0
    public void get_DebugView(){} // RVA: 0x65DA6E0
    public void get_Members(){} // RVA: 0xB2E530
    public void get_NodeType(){} // RVA: 0x7F01B0
    public void get_Type(){} // RVA: 0x7F0250
}

public class NewInputFixedUpdate
{
}

public class NewInputUpdate
{
}

public class NewLayoutMsg
{
    // ── Methods ──
    public void Create(){} // RVA: 0x6E69A60
    public void Process(){} // RVA: 0x6E69EC0
}

public class NextFramePromise
{
    public Cysharp.Threading.Tasks.TaskPool`1<NextFramePromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x3DF6A30
    public void .cctor(){} // RVA: 0x6CF43F0
    public void .ctor(){} // RVA: 0x2DD310
    public void Create(){} // RVA: 0x6CF4570
    public void GetResult(){} // RVA: 0x6CF4970
    public void GetStatus(){} // RVA: 0x6CF4B10
    public void UnsafeGetStatus(){} // RVA: 0x6CF4B60
    public void OnCompleted(){} // RVA: 0x6CF4BA0
    public void MoveNext(){} // RVA: 0x6CF4C20
    public void TryReturn(){} // RVA: 0x6CF4D60
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2A620
}

public class NextResult
{
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class NextResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA8650
}

public class Nnapi
{
    public Google.Protobuf.MessageParser`1<Nnapi> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public string CacheDirDefaultValue; // 0x8
    public string cacheDir_; // 0x18
    public string ModelTokenDefaultValue; // 0x10
    public string modelToken_; // 0x20
    public string AcceleratorNameDefaultValue; // 0x18
    public string acceleratorName_; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x5AE8080
    public void get_Descriptor(){} // RVA: 0x5AE80E0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AE8160
    public void .ctor(){} // RVA: 0x5AE8210 | overloaded x2
    public void Clone(){} // RVA: 0x5AE8430
    public void get_CacheDir(){} // RVA: 0x5AE8490
    public void set_CacheDir(){} // RVA: 0x5AE8500
    public void get_HasCacheDir(){} // RVA: 0x1D3B060
    public void ClearCacheDir(){} // RVA: 0x26AD280
    public void get_ModelToken(){} // RVA: 0x5AE8600
    public void set_ModelToken(){} // RVA: 0x5AE8670
    public void get_HasModelToken(){} // RVA: 0x1E3EC10
    public void ClearModelToken(){} // RVA: 0x5A57060
    public void get_AcceleratorName(){} // RVA: 0x5AE8770
    public void set_AcceleratorName(){} // RVA: 0x5AE87E0
    public void get_HasAcceleratorName(){} // RVA: 0x5A67FD0
    public void ClearAcceleratorName(){} // RVA: 0x29FDA70
    public void Equals(){} // RVA: 0x5AE8940 | overloaded x2
    public void GetHashCode(){} // RVA: 0x5AE8AC0
    public void ToString(){} // RVA: 0x5AE8BA0
    public void WriteTo(){} // RVA: 0x5A39740
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AE8BF0
    public void CalculateSize(){} // RVA: 0x5AE8CB0
    public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AE8F00
    public void .cctor(){} // RVA: 0x5AE9010
}

public class NoInput
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x2DD320
    public void GetAxisRaw(){} // RVA: 0xAFF380
    public void get_touchCount(){} // RVA: 0x519240
    public void GetTouch(){} // RVA: 0x73D6B50
    public void ClearLastPenContactEvent(){} // RVA: 0x2DD310
    public void GetLastPenContactEvent(){} // RVA: 0x14E9030
    public void get_mousePresent(){} // RVA: 0x2DD320
    public void GetMouseButtonDown(){} // RVA: 0x2DD320
    public void GetMouseButtonUp(){} // RVA: 0x2DD320
    public void get_mousePosition(){} // RVA: 0x4827050
    public void get_mouseButtonCount(){} // RVA: 0x519240
    public void get_anyKey(){} // RVA: 0x2DD320
    public void get_unscaledTime(){} // RVA: 0xAFF380
    public void get_doubleClickTime(){} // RVA: 0x73D6B70
    public void .ctor(){} // RVA: 0x2DD310
}

public class NoNamespaceManager
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
    public void get_DefaultNamespace(){} // RVA: 0x6A27E80
    public void PushScope(){} // RVA: 0x2DD310
    public void PopScope(){} // RVA: 0x2DD320
    public void AddNamespace(){} // RVA: 0x2DD310
    public void RemoveNamespace(){} // RVA: 0x2DD310
    public void GetEnumerator(){} // RVA: 0x519240
    public void GetNamespacesInScope(){} // RVA: 0x519240
    public void LookupNamespace(){} // RVA: 0x6A27EC0
    public void LookupPrefix(){} // RVA: 0x519240
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D310
}

public class Node
{
    public Node<U,T> EmptyNode;
    public U _key;
    public T _value;
    public bool _frozen;
    public byte _height;
    public Node<U,T> _left;
    public Node<U,T> _right;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
    public void get_IsEmpty(){} // RVA: 0xDBE0
    public void get_Height(){} // RVA: 0xD840
    public void get_Left(){} // RVA: 0xCD60
    public void get_Right(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0x283FA0
    public void get_Keys(){} // RVA: 0xCD60
    public void get_Values(){} // RVA: 0xCD60
    public void GetEnumerator(){} // RVA: 0x283FA0 | overloaded x2
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    public void CopyTo(){}
    public void NodeTreeFromSortedDictionary(){} // RVA: 0xCE50
    public void Add(){} // RVA: 0x283FA0
    public void SetItem(){} // RVA: 0x283FA0
    public void TryGetValue(){} // RVA: 0x283FA0
    public void ContainsKey(){} // RVA: 0x283FA0
    public void ContainsValue(){} // RVA: 0x283FA0
    public void Contains(){} // RVA: 0x283FA0
    public void Freeze(){} // RVA: 0x24A50
    public void RotateLeft(){} // RVA: 0xCE50
    public void RotateRight(){} // RVA: 0xCE50
    public void DoubleLeft(){} // RVA: 0xCE50
    public void DoubleRight(){} // RVA: 0xCE50
    public void Balance(){} // RVA: 0xD920
    public void IsRightHeavy(){} // RVA: 0xDCC0
    public void IsLeftHeavy(){} // RVA: 0xDCC0
    public void MakeBalanced(){} // RVA: 0xCE50
    public void NodeTreeFromList(){} // RVA: 0x1DEC0
    public void SetOrAdd(){} // RVA: 0x283FA0
    public void Mutate(){} // RVA: 0x1E6A0
    public void Search(){} // RVA: 0x283FA0
    public void .cctor(){} // RVA: 0x24A80
}

public class Node
{
    public Node<U,T> EmptyNode;
    public U _key;
    public T _value;
    public bool _frozen;
    public byte _height;
    public Node<U,T> _left;
    public Node<U,T> _right;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24A50
    public void get_IsEmpty(){} // RVA: 0xDBE0
    public void get_Height(){} // RVA: 0xD840
    public void get_Left(){} // RVA: 0xCD60
    public void get_Right(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0x283FA0
    public void get_Keys(){} // RVA: 0xCD60
    public void get_Values(){} // RVA: 0xCD60
    public void GetEnumerator(){} // RVA: 0x283FA0
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0xCD60
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    public void CopyTo(){}
    public void TryGetValue(){} // RVA: 0x283FA0
    public void ContainsKey(){} // RVA: 0x283FA0
    public void ContainsValue(){} // RVA: 0x283FA0
    public void Contains(){} // RVA: 0x283FA0
    public void Search(){} // RVA: 0x283FA0
    public void .cctor(){} // RVA: 0x24A80
}

public class Node
{
    public T Count;
    public Node<T> System.Collections.Generic.ICollection<T>.IsReadOnly;
    public Node<T> System.Collections.ICollection.IsSynchronized;
    public 0x65853D10 System.Collections.ICollection.SyncRoot;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void IsNonNullRed(){} // RVA: 0xDCC0
    public void IsNullOrBlack(){} // RVA: 0xDCC0
    public void get_Item(){} // RVA: 0x283FA0
    public void set_Item(){} // RVA: 0x283FA0
    public void get_Left(){} // RVA: 0xCD60
    public void set_Left(){} // RVA: 0x24B10
    public void get_Right(){} // RVA: 0xCD60
    public void set_Right(){} // RVA: 0x24B10
    public void get_Color(){} // RVA: 0xDBE0
    public void set_Color(){} // RVA: 0x25130
    public void get_IsBlack(){} // RVA: 0xDBE0
    public void get_IsRed(){} // RVA: 0xDBE0
    public void get_Is2Node(){} // RVA: 0xDBE0
    public void get_Is4Node(){} // RVA: 0xDBE0
    public void ColorBlack(){} // RVA: 0x24A50
    public void ColorRed(){} // RVA: 0x24A50
    public void GetRotation(){} // RVA: 0x11120
    public void GetSibling(){} // RVA: 0xCE10
    public void Split4Node(){} // RVA: 0x24A50
    public void Rotate(){}
    public void RotateLeft(){} // RVA: 0xCD60
    public void RotateLeftRight(){} // RVA: 0xCD60
    public void RotateRight(){} // RVA: 0xCD60
    public void RotateRightLeft(){} // RVA: 0xCD60
    public void Merge2Nodes(){} // RVA: 0x24A50
    public void ReplaceChild(){} // RVA: 0x2DC60
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
}

public class Node
{
    public Node<T> EmptyNode;
    public T _key;
    public bool _frozen;
    public byte _height;
    public int _count;
    public Node<T> _left;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24A50
    public void get_IsEmpty(){} // RVA: 0xDBE0
    public void get_Height(){} // RVA: 0xD840
    public void get_Left(){} // RVA: 0xCD60
    public void get_Right(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0x283FA0
    public void get_Count(){} // RVA: 0xD840
    public void ItemRef(){} // RVA: 0x1BCC0
    public void GetEnumerator(){} // RVA: 0x283FA0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    public void IndexOf(){} // RVA: 0x283FA0 | overloaded x2
    public void Contains(){} // RVA: 0x283FA0 | overloaded x2
    public void CopyTo(){} // RVA: 0x2BAA0 | overloaded x2
    public void Freeze(){} // RVA: 0x24A50
    public void .cctor(){} // RVA: 0x24A80
}

public class Node
{
    public Node<T> EmptyNode;
    public T _key;
    public bool _frozen;
    public byte _height;
    public int _count;
    public Node<T> _left;
    public Node<T> _right;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0 | overloaded x2
    public void get_IsEmpty(){} // RVA: 0xDBE0
    public void get_Height(){} // RVA: 0xD840
    public void get_Left(){} // RVA: 0xCD60
    public void get_Right(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0x283FA0
    public void get_Count(){} // RVA: 0xD840
    public void ItemRef(){} // RVA: 0x1BCC0
    public void ItemRefUnchecked(){} // RVA: 0x1BCC0
    public void GetEnumerator(){} // RVA: 0x283FA0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    public void Add(){} // RVA: 0x283FA0
    public void ReplaceAt(){} // RVA: 0x283FA0
    public void IndexOf(){} // RVA: 0x283FA0 | overloaded x2
    public void Contains(){} // RVA: 0x283FA0 | overloaded x2
    public void CopyTo(){} // RVA: 0x2BAA0 | overloaded x2
    public void Freeze(){} // RVA: 0x24A50
    public void RotateLeft(){} // RVA: 0xCD60
    public void DoubleLeft(){} // RVA: 0xCD60
    public void get_BalanceFactor(){} // RVA: 0xD840
    public void get_IsBalanced(){} // RVA: 0xDBE0
    public void BalanceRight(){} // RVA: 0xCD60
    public void MutateBoth(){} // RVA: 0x1E6A0
    public void MutateLeft(){} // RVA: 0xCE10
    public void MutateRight(){} // RVA: 0xCE10
    public void ParentHeight(){} // RVA: 0xE230
    public void ParentCount(){} // RVA: 0x12610
    public void MutateKey(){} // RVA: 0x283FA0
    public void CreateLeaf(){} // RVA: 0x283FA0
    public void .cctor(){} // RVA: 0x24A80
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D310
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D310
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C91CB0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public System.Collections.Generic.KeyValuePair`2<0x65885B98,ÎÌÎÏÌÎÎÎÌÍÏÎÎÌÍÍÎÌÎÏÍÎÍ> <Item>k__BackingField; // 0x10
    public Node<System.Collections.Generic.KeyValuePair`2<0x65885B98,ÎÌÎÏÌÎÎÎÌÍÏÎÎÌÍÍÎÌÎÏÍÎÍ>> <Left>k__BackingField; // 0x20
    public Node<System.Collections.Generic.KeyValuePair`2<0x65885B98,ÎÌÎÏÌÎÎÎÌÍÏÎÎÌÍÍÎÌÎÏÍÎÍ>> <Right>k__BackingField; // 0x28
    public 0x65853D10 <Color>k__BackingField; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C7BE60
    public void IsNonNullRed(){} // RVA: 0x3C7BEC0
    public void IsNullOrBlack(){} // RVA: 0x3C7BF00
    public void get_Item(){} // RVA: 0x196ABE0
    public void set_Item(){} // RVA: 0x3C7BF40
    public void get_Left(){} // RVA: 0x30B0C0
    public void set_Left(){} // RVA: 0x30B0D0
    public void get_Right(){} // RVA: 0x30B130
    public void set_Right(){} // RVA: 0x2DEE90
    public void get_Color(){} // RVA: 0x303450
    public void set_Color(){} // RVA: 0x303460
    public void get_IsBlack(){} // RVA: 0x3C7BFA0
    public void get_IsRed(){} // RVA: 0x3C7BFB0
    public void get_Is2Node(){} // RVA: 0x3C7BFC0
    public void get_Is4Node(){} // RVA: 0x3C7C080
    public void ColorBlack(){} // RVA: 0x6205A0
    public void ColorRed(){} // RVA: 0x17B5330
    public void GetRotation(){} // RVA: 0x3C7C120
    public void GetSibling(){} // RVA: 0x3C7C1A0
    public void Split4Node(){} // RVA: 0x3C7C1B0
    public void Rotate(){} // RVA: 0x3C7C1E0
    public void RotateLeft(){} // RVA: 0x3C7C260
    public void RotateLeftRight(){} // RVA: 0x3C7C330
    public void RotateRight(){} // RVA: 0x3C7C4C0
    public void RotateRightLeft(){} // RVA: 0x3C7C590
    public void Merge2Nodes(){} // RVA: 0x3C7C720
    public void ReplaceChild(){} // RVA: 0x3C7C750
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D310
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public System.Collections.Generic.KeyValuePair`2<int,VRC.Dynamics.VRCConstraintGroup> <Item>k__BackingField; // 0x10
    public Node<System.Collections.Generic.KeyValuePair`2<int,VRC.Dynamics.VRCConstraintGroup>> <Left>k__BackingField; // 0x20
    public Node<System.Collections.Generic.KeyValuePair`2<int,VRC.Dynamics.VRCConstraintGroup>> <Right>k__BackingField; // 0x28
    public 0x65853D10 <Color>k__BackingField; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C7BE60
    public void IsNonNullRed(){} // RVA: 0x3C7BEC0
    public void IsNullOrBlack(){} // RVA: 0x3C7BF00
    public void get_Item(){} // RVA: 0x196ABE0
    public void set_Item(){} // RVA: 0x3C7BF40
    public void get_Left(){} // RVA: 0x30B0C0
    public void set_Left(){} // RVA: 0x30B0D0
    public void get_Right(){} // RVA: 0x30B130
    public void set_Right(){} // RVA: 0x2DEE90
    public void get_Color(){} // RVA: 0x303450
    public void set_Color(){} // RVA: 0x303460
    public void get_IsBlack(){} // RVA: 0x3C7BFA0
    public void get_IsRed(){} // RVA: 0x3C7BFB0
    public void get_Is2Node(){} // RVA: 0x3C7BFC0
    public void get_Is4Node(){} // RVA: 0x3C7C080
    public void ColorBlack(){} // RVA: 0x6205A0
    public void ColorRed(){} // RVA: 0x17B5330
    public void GetRotation(){} // RVA: 0x3C7C120
    public void GetSibling(){} // RVA: 0x3C7C1A0
    public void Split4Node(){} // RVA: 0x3C7C1B0
    public void Rotate(){} // RVA: 0x3C7C1E0
    public void RotateLeft(){} // RVA: 0x3C7C260
    public void RotateLeftRight(){} // RVA: 0x3C7C330
    public void RotateRight(){} // RVA: 0x3C7C4C0
    public void RotateRightLeft(){} // RVA: 0x3C7C590
    public void Merge2Nodes(){} // RVA: 0x3C7C720
    public void ReplaceChild(){} // RVA: 0x3C7C750
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D4B0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C91F20
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D440
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> EmptyNode;
    public System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol> _key; // 0x10
    public bool _frozen; // 0x20
    public byte _height; // 0x21
    public int _count; // 0x24
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _left; // 0x28
    public Node<System.Collections.Generic.KeyValuePair`2<uint,VRC.Udon.Common.Interfaces.IUdonSymbol>> _right; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3C8D9D0
}

public class Node
{
    public ScheduledFrameEvent <Item>k__BackingField; // 0x10
    public Node<ScheduledFrameEvent> <Left>k__BackingField; // 0x30
    public Node<ScheduledFrameEvent> <Right>k__BackingField; // 0x38
    public 0x65853D10 <Color>k__BackingField; // 0x40
}

public class Node
{
    public ScheduledTimeEvent <Item>k__BackingField; // 0x10
    public Node<ScheduledTimeEvent> <Left>k__BackingField; // 0x30
    public Node<ScheduledTimeEvent> <Right>k__BackingField; // 0x38
    public 0x65853D10 <Color>k__BackingField; // 0x40
}
