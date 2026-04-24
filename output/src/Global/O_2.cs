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
    public object Count;
    public object Item;
    public object System.Collections.Generic.IReadOnlyList<System.Object>.Item;
    public object System.Collections.Generic.IList<System.Object>.Item;
    public object System.Collections.IList.Item;
    public object IsReadOnly;
    public object SyncRoot;
    public object IsSynchronized;
    public object IsFixedSize;

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
    public object layerMask; // 0x20
    public bool visualizeRoom; // 0x24
    public bool ÏÍÎÎÏÎÍÎÍÏÌÌÌÏÌÏÎÍÏÌÍÏÎ; // 0x25
    public int raysPerSecond; // 0x28
    public float roomInterpSpeed; // 0x2C
    public float maxWallDistance; // 0x30
    public int rayCacheSize; // 0x34
    public bool dynamicReflectionsEnabled; // 0x38
    public float ÌÏÏÍÌÎÏÍÏÍÏÎÌÎÎÎÏÍÏÌÌÏÌ; // 0x3C
    public float ÎÌÌÍÏÎÍÌÎÌÌÍÌÍÍÎÌÌÌÌÍÍÎ; // 0x40
    public BuffersImpl ÌÏÎÍÌÍÍÎÍÎÎÎÏÍÎÏÌÎÍÎÌÍÎ; // 0x48
    public rical[] ÏÍÍÌÍÎÎÏÌÏÏÏÌÌÍÌÎÏÌÏÌÌÏ; // 0x50
    public float[] ÍÏÎÎÎÌÎÍÌÍÍÍÍÏÎÍÎÍÌÍÏÏÎ; // 0x58
    public float[] ÍÏÍÍÎÌÌÍÎÌÍÍÍÍÍÏÌÌÏÏÌÍÏ; // 0x60
    public int ÌÎÎÎÌÍÍÎÌÏÎÌÍÏÍÍÌÌÍÏÎÍÌ;
    public amut[] ÏÍÎÍÎÏÏÌÍÍÏÎÌÍÍÌÎÌÍÌÌÌÏ; // 0x68
    public amut[] ÌÌÌÍÎÍÏÎÏÍÎÎÍÎÏÏÍÌÎÍÌÍÏ; // 0x70
    public InDuration ÏÎÏÏÍÎÍÌÍÌÍÍÏÏÎÌÍÏÏÎÌÎÌ; // 0x78
    public ?[] ÎÏÌÏÏÍÍÌÌÏÍÍÍÎÎÎÎÌÏÎÏÏÍ; // 0x80
    public e ÌÌÎÏÏÍÎÏÎÍÌÍÏÍÌÌÌÍÌÍÌÍÍ;
    public object ÌÎÌÍÌÎÍÏÍÏÏÏÌÎÍÎÏÎÍÏÍÎÍ; // 0x8
    public string ÌÍÏÎÎÌÍÎÍÏÎÍÎÏÍÎÍÎÎÎÏÍÍ;

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
}

public class OffsetAndRule : Object
{
    public int Year; // 0x10
    public ializable.GetObjectData Offset; // 0x18
    public ositionInfo Rule; // 0x20

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
    public Device.ckingField eventPtr; // 0x10
    public ÍÎÏÎÎ.ÌÌ<byte> buffer; // 0x18
    public ilAddress.ActionProperty device; // 0x28
    public _deviceLostEvent.ChangedEvent firstControl; // 0x30

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
    public ileFullDirectoryInformation<T1717654368> action;
    public URA.hEraNames<T1717654368> comparer;
    public bool isFirstCall;
    public T1717654368 latestValue;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void Report(){} // RVA: 0x7FFD4E2ADC40
}

public class Option : Object
{
    public itTypeSize=876 OptionText; // 0x10
    public itTypeSize=876 Tooltip; // 0x38
    public object Value; // 0x60
    public ormation<bool> IsEnabled; // 0x68

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
    public ÍÍÍÍÌÌÏÍÌÌÏÏÏÏÎÎÌÌÏÎ>k__BackingField image; // 0x18

    // ── Methods ──
    public void get_text(){} // RVA: 0x7FFD4E35C380
    public void set_text(){} // RVA: 0x7FFD4E342E30
    public void get_image(){} // RVA: 0x7FFD4E3447C0
    public void set_image(){} // RVA: 0x7FFD4E3A7E80
    public void .ctor(){} // RVA: 0x7FFD4E90C240 | overloaded x4
}

public class OptionDataList : Object
{
    public URA.woDigitYearMax<Src> options; // 0x10

    // ── Methods ──
    public void get_options(){} // RVA: 0x7FFD4E35C380
    public void set_options(){} // RVA: 0x7FFD4E342E30
    public void .ctor(){} // RVA: 0x7FFD54B65030
}

public class OptionsAndroid : PlatformOptions
{
    public object preferredMaximumResolution;
    public object customPreferredMaximumResolution;
    public object preferredPeakBitRate;
    public object preferredPeakBitRateUnits;

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
    public object previousAudioMode;
    public object audioMode;
    public object flags;
    public object preferredPeakBitRate;
    public object preferredPeakBitRateUnits;
    public object preferredForwardBufferDuration;
    public object preferredMaximumResolution;
    public object customPreferredMaximumResolution;

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
    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFD4FBE2EA0
    public void GetKeyServerAuthToken(){} // RVA: 0x7FFD4E919180
    public void GetOverrideDecryptionKey(){} // RVA: 0x7FFD4E919180
    public void .ctor(){} // RVA: 0x7FFD4FBE2ED0
}

public class OptionsWindows : PlatformOptions
{
    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFD4FBE26D0
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFD4E3FB8E0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD4FBE27C0
    public void .ctor(){} // RVA: 0x7FFD4FBE27F0
}

public class OptionsWindowsUWP : PlatformOptions
{
    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFD4FBE2950
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFD4E377C20
    public void .ctor(){} // RVA: 0x7FFD4FBE29B0
}

public class OpusCodec : Object
{
    public int ÏÏÍÍÎÏÍÍÏÌÎÍÍÎÌÌÎÍÎÎÏÌÏ;
    public ÎÍÏÍÏÌÏ ÍÏÏÌÏÌÌÎÍÎÏÏÍÏÎÏÌÌÎÍÏÌÎ; // 0x10
    public ÎÎÎÍÎ ÏÏÏÌÍÏÎÌÎÏÎÏÍÌÌÎÎÏÎÎÏÏÏ; // 0x18
    public int ÌÎÏÍÎÎÌÌÎÎÏÍÌÏÍÏÌÎÌÍÏÍÍ; // 0x20
    public int ÍÎÍÎÎÍÏÌÎÎÌÌÎÍÎÌÎÍÎÏÍÏÏ; // 0x24
    public int ÎÍÍÌÌÏÎÎÌÏÌÍÍÍÌÍÏÍÏÎÎÎÏ; // 0x28
    public Ï ÏÍÌÍÌÏÏÏÌÏÏÏÍÎÍÍÍÏÏÎÍÍÎ; // 0x2C
    public bool ÌÍÌÍÍÏÍÏÍÍÌÍÌÌÍÍÌÍÍÍÏÌÏ; // 0x30

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
    public ÏÌ parent; // 0x18
    public string pathName; // 0x20
    public object currentViewObject; // 0x28
    public object queuedType; // 0x30
    public object appliedType; // 0x34
    public float queuedValue; // 0x38
    public float receivedTime; // 0x3C
    public float minValue; // 0x40
    public float maxValue; // 0x44
    public ePathName117.? valueDisplay; // 0x48
    public ePathName117.? minDisplay; // 0x50
    public ePathName117.? maxDisplay; // 0x58
    public ePathName117.ÎÌÍÍÎÏÌ pulse; // 0x60
    public BuffersImpl checkMark; // 0x68
    public 16 fill; // 0x70
    public object pointDisplay; // 0x78
    public object axisDisplay; // 0x80
    public object sibling; // 0x88
    public object valueBG; // 0x90
    public URA.woDigitYearMax<16> fills; // 0x98
    public URA.woDigitYearMax<ePathName117.?> minDisplays; // 0xA0
    public URA.woDigitYearMax<ePathName117.?> maxDisplays; // 0xA8
    public URA.woDigitYearMax<ePathName117.?> valueDisplays; // 0xB0
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
    public lfFrustumHeight Pt; // 0x18
    public Speed Next; // 0x28
    public Speed Prev; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class OutRec : Object
{
    public int Idx; // 0x10
    public bool IsHole; // 0x14
    public bool IsOpen; // 0x15
    public SetCartPosition FirstLeft; // 0x18
    public Speed Pts; // 0x20
    public Speed BottomPt; // 0x28
    public hCache PolyNode; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class OutputEventArgs : ValueType
{
    public etBestGrabbingType.ionEnabled<T1717692464> packet;
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
