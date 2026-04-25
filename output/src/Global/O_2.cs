// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 40
// Methods: 222

public class ObjectReaperDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class ObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD5749BDD0
    public void SetObjectData(){} // RVA: 0x7FFD5749C6B0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ObjectValueCollection : Object
{
    public System.Collections.Generic.IReadOnlyList`1<Token> Count; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD57231880
    public void get_Count(){} // RVA: 0x7FFD57231940
    public void get_Item(){} // RVA: 0x7FFD57231990
    public void set_Item(){} // RVA: 0x7FFD57231A80
    public void System.Collections.Generic.IReadOnlyList<System.Object>.get_Item(){} // RVA: 0x7FFD57231AC0
    public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0x7FFD57231BD0
    public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0x7FFD57231CE0
    public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD57231D20
    public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD57231E30
    public void get_IsReadOnly(){} // RVA: 0x7FFD4E426850
    public void get_SyncRoot(){} // RVA: 0x7FFD57231E70
    public void get_IsSynchronized(){} // RVA: 0x7FFD4E341320
    public void get_IsFixedSize(){} // RVA: 0x7FFD4E426850
    public void Contains(){} // RVA: 0x7FFD57231F30 | overloaded x2
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD57231FE0
    public void CopyTo(){} // RVA: 0x7FFD572324C0 | overloaded x2
    public void Add(){} // RVA: 0x7FFD57232760 | overloaded x2
    public void System.Collections.IList.Add(){} // RVA: 0x7FFD572327A0
    public void Clear(){} // RVA: 0x7FFD572327E0
    public void Remove(){} // RVA: 0x7FFD57232860 | overloaded x2
    public void System.Collections.IList.Remove(){} // RVA: 0x7FFD572328A0
    public void Insert(){} // RVA: 0x7FFD57232920 | overloaded x2
    public void RemoveAt(){} // RVA: 0x7FFD57232960
    public void GetEnumerator(){} // RVA: 0x7FFD572329A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD572329F0
    public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0x7FFD57232A30
    public void IndexOf(){} // RVA: 0x7FFD57232B70 | overloaded x2
}

public class OculusSpatializerUnity : MonoBehaviour
{
    public UnityEngine.LayerMask layerMask; // 0x20
    public bool visualizeRoom; // 0x24
    public bool ÎÌÏÌÎÌÌÏÌÍÍÎÏÌÍÎÍÌÍÏÏÌÎ; // 0x25
    public int raysPerSecond; // 0x28
    public float roomInterpSpeed; // 0x2C
    public float maxWallDistance; // 0x30
    public int rayCacheSize; // 0x34
    public bool dynamicReflectionsEnabled; // 0x38
    public float ÌÍÎÎÌÎÎÌÌÎÌÏÍÌÎÍÏÏÏÎÌÌÎ; // 0x3C
    public float ÎÏÍÌÎÍÍÌÏÏÌÍÌÏÎÌÏÎÌÏÍÎÌ; // 0x40
    public UnityEngine.GameObject ÍÎÎÌÎÎÎÍÌÍÎÍÎÍÏÏÏÍÍÏÌÌÌ; // 0x48
    public UnityEngine.Renderer[] ÍÎÎÏÎÌÏÍÎÏÍÎÍÏÌÎÌÍÌÎÎÍÍ; // 0x50
    public float[] ÏÌÏÎÏÌÌÏÎÎÌÏÌÍÌÎÏÌÎÎÌÍÍ; // 0x58
    public float[] ÌÏÍÏÌÍÎÎÌÎÍÍÎÍÏÌÍÏÏÏÏÏÎ; // 0x60
    public int ÌÌÌÎÏÍÌÌÌÏÍÍÌÏÏÏÍÏÏÌÌÏÌ;
    public UnityEngine.Vector3[] ÏÎÌÌÍÏÌÌÎÏÏÌÎÍÏÍÏÍÍÌÍÏÎ; // 0x68
    public UnityEngine.Vector3[] ÌÏÌÌÍÍÍÎÍÍÎÍÎÎÍÌÎÎÎÌÎÌÍ; // 0x70
    public UnityEngine.ParticleSystem ÎÏÎÎÌÏÌÎÏÏÎÎÍÎÏÎÏÍÌÎÎÍÍ; // 0x78
    public Particle[] ÌÎÏÏÌÏÍÎÍÏÎÏÎÌÌÏÎÍÌÎÌÌÏ; // 0x80
    public UnityEngine.AudioListener ÎÎÏÏÏÍÏÌÌÎÌÏÍÎÏÌÌÌÍÍÏÎÎ;
    public UnityEngine.LayerMask ÌÍÍÎÎÏÎÏÎÏÍÎÎÎÏÍÏÌÎÌÎÍÎ; // 0x8
    public string ÌÌÌÎÏÏÏÍÏÎÍÌÌÍÏÌÍÎÎÌÍÍÎ;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4EEA4B30
    public void RaiseCancellation(){} // RVA: 0x7FFD4EEA4B70
    public void IsInvoking(){} // RVA: 0x7FFD4EEA4BC0
    public void CancelInvoke(){} // RVA: 0x7FFD4EEA4C40
    public void Invoke(){} // RVA: 0x7FFD4EEA56D0
    public void Update(){} // RVA: 0x7FFD4EEA5750
    public void LateUpdate(){} // RVA: 0x7FFD4EEA63A0
    public void OnDisable(){} // RVA: 0x7FFD4EEA6810
    public void StartCoroutine(){} // RVA: 0x7FFD4EEA68B0
    public void Start(){} // RVA: 0x7FFD4EEA83C0
    public void OnApplicationQuit(){} // RVA: 0x7FFD4EEA8460
    public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EEA8500
    public void StopCoroutine(){} // RVA: 0x7FFD4EEA85B0
    public void .ctor(){} // RVA: 0x7FFD4EEA8630
    public void Initialize(){} // RVA: 0x7FFD4EEA8990
    public void Internal_IsInvokingAll_86359B378FE3(){} // RVA: 0x7FFD4EEA9090 | overloaded x2
    public void get_useGUILayout(){} // RVA: 0x7FFD4EEA8AA0
    public void set_useGUILayout(){} // RVA: 0x7FFD4EEA8B50
    public void print(){} // RVA: 0x7FFD4EEA8FC0
    public void OnDestroy(){} // RVA: 0x7FFD4EEA9040
    public void InvokeDelayed(){} // RVA: 0x7FFD4EEA9130
    public void OnTriggerEnter(){} // RVA: 0x7FFD4EEA9180
    public void FromFlippedZVector3f(){} // RVA: 0x7FFD4EEA9B70
}

public class Offset : ValueType
{
    public ushort Scheme; // 0x10
    public ushort User; // 0x12
    public ushort Host; // 0x14
    public ushort PortValue; // 0x16
    public ushort Path; // 0x18
    public ushort Query; // 0x1A
    public ushort Fragment; // 0x1C
    public ushort End; // 0x1E
}

public class OffsetAndRule : Object
{
    public int Year; // 0x10
    public System.TimeSpan Offset; // 0x18
    public AdjustmentRule Rule; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53923240
}

public class OnCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class OnCapturedToDiskCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C390
    public void Invoke(){} // RVA: 0x7FFD5098C460
}

public class OnCapturedToMemoryCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD980F0
    public void Invoke(){} // RVA: 0x7FFD4FD981C0
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55067810
}

public class OnCultureInfoChangedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class OnGUIDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class OnNavMeshPreUpdate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class OnOverrideControllerDirtyCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class OnPerformCulling : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54D10260
    public void Invoke(){} // RVA: 0x7FFD54D103E0
}

public class OnPhotoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C390
    public void Invoke(){} // RVA: 0x7FFD5098C460
}

public class OnPhotoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C390
    public void Invoke(){} // RVA: 0x7FFD5098C460
}

public class OnScreenDeviceInfo : ValueType
{
    public UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr; // 0x10
    public Unity.Collections.NativeArray`1<byte> buffer; // 0x18
    public UnityEngine.InputSystem.InputDevice device; // 0x28
    public UnityEngine.InputSystem.OnScreen.OnScreenControl firstControl; // 0x30

    // ── Methods ──
    public void AddControl(){} // RVA: 0x7FFD54A7A350
    public void RemoveControl(){} // RVA: 0x7FFD54A7A450
    public void Destroy(){} // RVA: 0x7FFD54A7A7E0
}

public class OnStartedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C390
    public void Invoke(){} // RVA: 0x7FFD5098C460
}

public class OnStoppedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C390
    public void Invoke(){} // RVA: 0x7FFD5098C460
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54BA6DB0
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD550676E0
    public void EndInvoke(){} // RVA: 0x7FFD54BA6F40
}

public class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class OnVideoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C390
    public void Invoke(){} // RVA: 0x7FFD5098C460
}

public class OnVideoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C390
    public void Invoke(){} // RVA: 0x7FFD5098C460
}

public class OnlyValueChangedProgress`1 : Object
{
    public System.Action`1<T> action;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public bool isFirstCall;
    public T latestValue;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void Report(){} // RVA: 0x7FFD4E2ADC40
}

public class Option : Object
{
    public VRC.Localization.LocalizableString OptionText; // 0x10
    public VRC.Localization.LocalizableString Tooltip; // 0x38
    public object Value; // 0x60
    public System.Func`1<bool> IsEnabled; // 0x68

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4E9FB780
    public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
    public void Equals(){} // RVA: 0x7FFD4EC344E0
    public void set_Tooltip(){} // RVA: 0x7FFD4FD51910
    public void CompareBaseObjects(){} // RVA: 0x7FFD4EC344E0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E3BCD50
    public void StartPickedUp(){} // RVA: 0x7FFD4E3BCD60
    public void get_Value(){} // RVA: 0x7FFD4E3DF370
    public void get_IsEnabled(){} // RVA: 0x7FFD4E3BCD50
    public void get_OptionText(){} // RVA: 0x7FFD4EC33C20
    public void set_Value(){} // RVA: 0x7FFD4E3DF380
    public void Instantiate(){} // RVA: 0x7FFD4EC344E0
    public void set_OptionText(){} // RVA: 0x7FFD4EC344E0
    public void .ctor(){} // RVA: 0x7FFD56CF1820
    public void get_Tooltip(){} // RVA: 0x7FFD4E9FB780
    public void set_IsEnabled(){} // RVA: 0x7FFD4E3BCD60
}

public class OptionData : Object
{
    public string text; // 0x10
    public UnityEngine.Sprite image; // 0x18

    // ── Methods ──
    public void get_text(){} // RVA: 0x7FFD4E35C380
    public void set_text(){} // RVA: 0x7FFD4E342E30
    public void get_image(){} // RVA: 0x7FFD4E3447C0
    public void set_image(){} // RVA: 0x7FFD4E3A7E80
    public void .ctor(){} // RVA: 0x7FFD4E90C240 | overloaded x4
}

public class OptionDataList : Object
{
    public System.Collections.Generic.List`1<OptionData> options; // 0x10

    // ── Methods ──
    public void get_options(){} // RVA: 0x7FFD4E35C380
    public void set_options(){} // RVA: 0x7FFD4E342E30
    public void .ctor(){} // RVA: 0x7FFD54B65030
}

public class OptionsAndroid : PlatformOptions
{
    public 0x665D3BE8 preferredMaximumResolution; // 0x20
    public 0x665D3B38 customPreferredMaximumResolution; // 0x24
    public UnityEngine.Vector2Int preferredPeakBitRate; // 0x28
    public float preferredPeakBitRateUnits; // 0x30
    public 0x665D3B90 _preferredPeakBitRateUnits; // 0x34
    public 0x665D5190 videoApi; // 0x38
    public bool useFastOesPath; // 0x3C
    public bool showPosterFrame; // 0x3D
    public 0x665D51E8 audioOutput; // 0x40
    public 0x665D53A0 audio360ChannelMode; // 0x44
    public bool preferSoftwareDecoder; // 0x48
    public bool forceRtpTCP; // 0x49
    public 0x665D5240 blitTextureFiltering; // 0x4C
    public int fileOffset; // 0x50
    public bool startWithHighestBitrate; // 0x54
    public int minBufferMs; // 0x58
    public int maxBufferMs; // 0x5C
    public int bufferForPlaybackMs; // 0x60
    public int bufferForPlaybackAfterRebufferMs; // 0x64
    public bool enableAudio360; // 0x68

    // ── Methods ──
    public void get_preferredMaximumResolution(){} // RVA: 0x7FFD4ED41980
    public void set_preferredMaximumResolution(){} // RVA: 0x7FFD4FBE2C90
    public void get_customPreferredMaximumResolution(){} // RVA: 0x7FFD4E36F130
    public void set_customPreferredMaximumResolution(){} // RVA: 0x7FFD4FBE2CA0
    public void get_preferredPeakBitRate(){} // RVA: 0x7FFD4F060670
    public void set_preferredPeakBitRate(){} // RVA: 0x7FFD4FBE2CD0
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x7FFD4EEFEDC0
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x7FFD4FBE2CF0
    public void IsModified(){} // RVA: 0x7FFD4FBE2D00
    public void BitRateInBitsPerSecond(){} // RVA: 0x7FFD4FBE2AD0
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x7FFD4FBE2DA0
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFD4F9C0C60
    public void HasChanged(){} // RVA: 0x7FFD4FBE2DE0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD4FBE2E00
    public void .ctor(){} // RVA: 0x7FFD4FBE2E20
}

public class OptionsApple : PlatformOptions
{
    public 0x665D38D0 previousAudioMode; // 0x20
    public 0x665D3980 audioMode; // 0x24
    public 0x665D38D0 flags; // 0x28
    public 0x665D3928 preferredPeakBitRate; // 0x2C
    public 0x665D3928 preferredPeakBitRateUnits; // 0x30
    public 0x665D3980 preferredForwardBufferDuration; // 0x34
    public float preferredMaximumResolution; // 0x38
    public 0x665D3A88 customPreferredMaximumResolution; // 0x3C
    public float _preferredPeakBitRate; // 0x40
    public 0x665D3A30 _preferredPeakBitRateUnits; // 0x44
    public double _preferredForwardBufferDuration; // 0x48
    public 0x665D39D8 _preferredMaximumResolution; // 0x50
    public UnityEngine.Vector2Int _customPreferredMaximumResolution; // 0x54

    // ── Methods ──
    public void get_previousAudioMode(){} // RVA: 0x7FFD4F0A91D0
    public void get_audioMode(){} // RVA: 0x7FFD4E39CCD0
    public void set_audioMode(){} // RVA: 0x7FFD4FBE29D0
    public void get_flags(){} // RVA: 0x7FFD4EEFEDC0
    public void set_flags(){} // RVA: 0x7FFD4FBE29F0
    public void get_preferredPeakBitRate(){} // RVA: 0x7FFD4E5080B0
    public void set_preferredPeakBitRate(){} // RVA: 0x7FFD4FBE2A20
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x7FFD4E3E20A0
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x7FFD4FBE2A40
    public void get_preferredForwardBufferDuration(){} // RVA: 0x7FFD4FBE2A50
    public void set_preferredForwardBufferDuration(){} // RVA: 0x7FFD4FBE2A60
    public void get_preferredMaximumResolution(){} // RVA: 0x7FFD4E5110E0
    public void set_preferredMaximumResolution(){} // RVA: 0x7FFD4FBE2A80
    public void get_customPreferredMaximumResolution(){} // RVA: 0x7FFD4FBE2A90
    public void set_customPreferredMaximumResolution(){} // RVA: 0x7FFD4FBE2AA0
    public void BitRateInBitsPerSecond(){} // RVA: 0x7FFD4FBE2AD0
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x7FFD4FBE2B10
    public void .ctor(){} // RVA: 0x7FFD4FBE2B50
    public void IsModified(){} // RVA: 0x7FFD4FBE2C10
    public void HasChanged(){} // RVA: 0x7FFD4FBE2C70
    public void ClearChanges(){} // RVA: 0x7FFD4FBE2C80
}

public class OptionsWebGL : PlatformOptions
{
    public 0x665D52F0 externalLibrary; // 0x20
    public bool useTextureMips; // 0x24

    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFD4FBE2EA0
    public void GetKeyServerAuthToken(){} // RVA: 0x7FFD4E919180
    public void GetOverrideDecryptionKey(){} // RVA: 0x7FFD4E919180
    public void .ctor(){} // RVA: 0x7FFD4FBE2ED0
}

public class OptionsWindows : PlatformOptions
{
    public 0x665D4F80 videoApi; // 0x20
    public bool useHardwareDecoding; // 0x24
    public bool useTextureMips; // 0x25
    public bool use10BitTextures; // 0x26
    public bool hintAlphaChannel; // 0x27
    public bool useLowLatency; // 0x28
    public bool useCustomMovParser; // 0x29
    public bool useHapNotchLC; // 0x2A
    public bool useStereoDetection; // 0x2B
    public bool useTextTrackSupport; // 0x2C
    public bool useFacebookAudio360Support; // 0x2D
    public bool useAudioDelay; // 0x2E
    public 0x665D46E8 bufferedFrameSelection; // 0x30
    public bool pauseOnPrerollComplete; // 0x34
    public string forceAudioOutputDeviceName; // 0x38
    public System.Collections.Generic.List`1<string> preferredFilters; // 0x40
    public 0x665D4FD8 audioOutput; // 0x48
    public 0x665D53A0 audio360ChannelMode; // 0x4C
    public bool startWithHighestBitrate; // 0x50
    public bool useLowLiveLatency; // 0x51
    public int parallelFrameCount; // 0x54
    public int prerollFrameCount; // 0x58
    public bool useUnityAudio; // 0x5C
    public bool enableAudio360; // 0x5D

    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFD4FBE26D0
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFD4E3FB8E0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD4FBE27C0
    public void .ctor(){} // RVA: 0x7FFD4FBE27F0
}

public class OptionsWindowsUWP : PlatformOptions
{
    public bool useHardwareDecoding; // 0x20
    public bool useTextureMips; // 0x21
    public bool use10BitTextures; // 0x22
    public bool hintOutput10Bit; // 0x23
    public bool useLowLatency; // 0x24
    public 0x665D5088 videoApi; // 0x28
    public 0x665D50E0 audioOutput; // 0x2C
    public 0x665D53A0 audio360ChannelMode; // 0x30
    public bool startWithHighestBitrate; // 0x34
    public bool useLowLiveLatency; // 0x35

    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFD4FBE2950
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFD4E377C20
    public void .ctor(){} // RVA: 0x7FFD4FBE29B0
}

public class OpusCodec : Object
{
    public int ÏÏÎÍÏÍÎÍÍÍÍÍÎÍÍÌÎÌÍÍÏÍÏ;
    public ÎÌÎÍÏÎÍÌÏÏÏÌÍÌÍÏÍÏÌÏÍÌÏ ÍÏÏÍÏÌÌÌÌÍÏÍÌÎÎÏÏÍÎÌÌÏÏ; // 0x10
    public ÌÏÌÌÍÍÌÌÎÎÌÎÌÍÍÏÏÌÎÌÎÌÍ ÌÌÎÍÏÌÍÌÍÌÍÌÌÏÍÏÍÏÏÎÌÌÏ; // 0x18
    public int ÏÌÏÍÎÏÎÎÎÌÍÏÏÌÏÌÎÏÍÌÎÏÎ; // 0x20
    public int ÌÌÏÍÏÍÌÎÍÎÏÏÎÏÌÍÏÏÏÏÍÌÍ; // 0x24
    public int ÏÏÏÎÎÍÌÏÍÎÍÌÎÍÍÏÍÎÏÌÎÏÏ; // 0x28
    public 0x66379D10 ÎÎÌÏÎÍÍÌÎÍÍÏÏÌÌÏÎÎÏÏÍÎÍ; // 0x2C
    public bool ÏÏÏÏÍÌÌÎÍÎÏÎÍÎÎÌÍÍÌÍÏÏÌ; // 0x30

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4E4FB160
    public void Equals(){} // RVA: 0x7FFD4E4FB1F0
    public void GetHashCode(){} // RVA: 0x7FFD4E4FB580
    public void op_Implicit(){} // RVA: 0x7FFD4E4FB700
    public void CompareBaseObjects(){} // RVA: 0x7FFD4E4FBBA0
    public void GetSkeletonType(){} // RVA: 0x7FFD4E4FBBE0
    public void GetCachedPtr(){} // RVA: 0x7FFD4E4FBBF0
    public void get_name(){} // RVA: 0x7FFD4E4FBC80
    public void set_name(){} // RVA: 0x7FFD4E4FBCA0
    public void Instantiate(){} // RVA: 0x7FFD4E4FBFD0
    public void ToString(){} // RVA: 0x7FFD4E4FBBE0
    public void .ctor_12114D51CACA(){} // RVA: 0x7FFD4E4FC350
    public void GetHashCode_9C64B201F254(){} // RVA: 0x7FFD4E4FC680
    public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFD4E4FC800
    public void .ctor(){} // RVA: 0x7FFD4E4FC840
    public void Initialize(){} // RVA: 0x7FFD4E4FC860
    public void GetBooleanFromDelegate(){} // RVA: 0x7FFD4E4FCD00
    public void GetIntegerFromDelegate(){} // RVA: 0x7FFD4E4FBBE0
}

public class Orbit : ValueType
{
    public float m_Height; // 0x10
    public float m_Radius; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E364D10
}

public class OscView : Object
{
    public bool dirty; // 0x10
    public ÍÎÍÍÍÏÍÎÎÍÍÌÍÍÌÏÏÎÍÎÏÏÍ parent; // 0x18
    public string pathName; // 0x20
    public UnityEngine.Transform currentViewObject; // 0x28
    public 0x6635CA98 queuedType; // 0x30
    public 0x6635CA98 appliedType; // 0x34
    public float queuedValue; // 0x38
    public float receivedTime; // 0x3C
    public float minValue; // 0x40
    public float maxValue; // 0x44
    public UnityEngine.UI.Text valueDisplay; // 0x48
    public UnityEngine.UI.Text minDisplay; // 0x50
    public UnityEngine.UI.Text maxDisplay; // 0x58
    public UnityEngine.UI.Image pulse; // 0x60
    public UnityEngine.GameObject checkMark; // 0x68
    public UnityEngine.RectTransform fill; // 0x70
    public UnityEngine.Transform pointDisplay; // 0x78
    public UnityEngine.Transform axisDisplay; // 0x80
    public OscView sibling; // 0x88
    public UnityEngine.Transform valueBG; // 0x90
    public System.Collections.Generic.List`1<UnityEngine.RectTransform> fills; // 0x98
    public System.Collections.Generic.List`1<UnityEngine.UI.Text> minDisplays; // 0xA0
    public System.Collections.Generic.List`1<UnityEngine.UI.Text> maxDisplays; // 0xA8
    public System.Collections.Generic.List`1<UnityEngine.UI.Text> valueDisplays; // 0xB0
    public float[] queuedValues; // 0xB8
    public float[] minValues; // 0xC0
    public float[] maxValues; // 0xC8
    public float firstValue; // 0xD0
    public float secondValue; // 0xD4
    public int numValuesReceived; // 0xD8

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4F2C1DF0
    public void Equals(){} // RVA: 0x7FFD4F2C1E00
    public void .ctor(){} // RVA: 0x7FFD4F2C1E90
    public void Initialize(){} // RVA: 0x7FFD4F2C22F0
    public void CompareBaseObjects(){} // RVA: 0x7FFD4F2C24F0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F2C3F20
    public void GetCachedPtr(){} // RVA: 0x7FFD4F2C4370
    public void get_name(){} // RVA: 0x7FFD4F2C47C0
    public void set_name(){} // RVA: 0x7FFD4F2C4950
    public void Instantiate(){} // RVA: 0x7FFD4F2C63E0
    public void GetHashCode(){} // RVA: 0x7FFD4F2C63F0
    public void ToString(){} // RVA: 0x7FFD4F2C1DF0
    public void GetHashCode_EAA173EA84A2(){} // RVA: 0x7FFD4F2C7D70
    public void ToString_56D017530C41(){} // RVA: 0x7FFD4E96E300
    public void ProcessInternalDataAndReturnResult(){} // RVA: 0x7FFD4E96E300
    public void get_name_A2D2DFEDC491(){} // RVA: 0x7FFD4F2C47C0
}

public class OutPt : Object
{
    public int Idx; // 0x10
    public IntPoint Pt; // 0x18
    public OutPt Next; // 0x28
    public OutPt Prev; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class OutRec : Object
{
    public int Idx; // 0x10
    public bool IsHole; // 0x14
    public bool IsOpen; // 0x15
    public OutRec FirstLeft; // 0x18
    public OutPt Pts; // 0x20
    public OutPt BottomPt; // 0x28
    public PolyNode PolyNode; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class OutputEventArgs : ValueType
{
    public Mediapipe.Packet`1<T> packet;
    public long timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E0961B0
}

public class OutputParameter : Object
{
    public string address; // 0x10
    public string type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFE0310
}
