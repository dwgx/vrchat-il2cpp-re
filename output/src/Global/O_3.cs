// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 83
// Methods: 346

public class ObjectEnumerator : Object
{
    public JObject Key; // 0x10
    public int System.Collections.IDictionaryEnumerator.Key; // 0x18

    // ── Methods ──
    public void get_Key(){} // RVA: 0x7FFACBE10B70
    public void System.Collections.IDictionaryEnumerator.get_Key(){} // RVA: 0x7FFACBE10B70
    public void get_Value(){} // RVA: 0x7FFACBE10BB0
    public void System.Collections.IDictionaryEnumerator.get_Value(){} // RVA: 0x7FFACBE10C10
    public void get_Current(){} // RVA: 0x7FFACBE10CB0
    public void System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current(){} // RVA: 0x7FFACBE10D70
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFACBE10E70
    public void System.Collections.IDictionaryEnumerator.get_Entry(){} // RVA: 0x7FFACBE10F40
    public void Dispose(){} // RVA: 0x7FFACBE11030
    public void MoveNext(){} // RVA: 0x7FFACBE111C0
    public void Reset(){} // RVA: 0x7FFAC47EDC40
    public void .ctor(){} // RVA: 0x7FFAC47EDC40
}

public class ObjectReaperDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFACC07BDD0
    public void SetObjectData(){} // RVA: 0x7FFACC07C6B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ObjectValueCollection : Object
{
    public System.Collections.Generic.IReadOnlyList`1<Token> Count; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBE11880
    public void get_Count(){} // RVA: 0x7FFACBE11940
    public void get_Item(){} // RVA: 0x7FFACBE11990
    public void set_Item(){} // RVA: 0x7FFACBE11A80
    public void System.Collections.Generic.IReadOnlyList<System.Object>.get_Item(){} // RVA: 0x7FFACBE11AC0
    public void System.Collections.Generic.IList<System.Object>.get_Item(){} // RVA: 0x7FFACBE11BD0
    public void System.Collections.Generic.IList<System.Object>.set_Item(){} // RVA: 0x7FFACBE11CE0
    public void System.Collections.IList.get_Item(){} // RVA: 0x7FFACBE11D20
    public void System.Collections.IList.set_Item(){} // RVA: 0x7FFACBE11E30
    public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
    public void get_SyncRoot(){} // RVA: 0x7FFACBE11E70
    public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
    public void get_IsFixedSize(){} // RVA: 0x7FFAC3006850
    public void Contains(){} // RVA: 0x7FFACBE11F30 | overloaded x2
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFACBE11FE0
    public void CopyTo(){} // RVA: 0x7FFACBE124C0 | overloaded x2
    public void Add(){} // RVA: 0x7FFACBE12760 | overloaded x2
    public void System.Collections.IList.Add(){} // RVA: 0x7FFACBE127A0
    public void Clear(){} // RVA: 0x7FFACBE127E0
    public void Remove(){} // RVA: 0x7FFACBE12860 | overloaded x2
    public void System.Collections.IList.Remove(){} // RVA: 0x7FFACBE128A0
    public void Insert(){} // RVA: 0x7FFACBE12920 | overloaded x2
    public void RemoveAt(){} // RVA: 0x7FFACBE12960
    public void GetEnumerator(){} // RVA: 0x7FFACBE129A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACBE129F0
    public void System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator(){} // RVA: 0x7FFACBE12A30
    public void IndexOf(){} // RVA: 0x7FFACBE12B70 | overloaded x2
}

public class ObserverState : Object
{
    public UnityEngine.InputSystem.Utilities.InlinedArray`1<System.IObserver`1<UnityEngine.InputSystem.LowLevel.InputEventPtr>> observers; // 0x10
    public System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice> onEventDelegate; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9677070
    public void <.ctor>b__2_0(){} // RVA: 0x7FFAC9677130
}

public class OculusInitParams : ValueType
{
    public int sType; // 0x10
    public string email; // 0x18
    public string password; // 0x20
    public ulong appId; // 0x28
    public string uriPrefixOverride; // 0x30
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
    public void .cctor(){} // RVA: 0x7FFAC3A84B30
    public void RaiseCancellation(){} // RVA: 0x7FFAC3A84B70
    public void IsInvoking(){} // RVA: 0x7FFAC3A84BC0
    public void CancelInvoke(){} // RVA: 0x7FFAC3A84C40
    public void Invoke(){} // RVA: 0x7FFAC3A856D0
    public void Update(){} // RVA: 0x7FFAC3A85750
    public void LateUpdate(){} // RVA: 0x7FFAC3A863A0
    public void OnDisable(){} // RVA: 0x7FFAC3A86810
    public void StartCoroutine(){} // RVA: 0x7FFAC3A868B0
    public void Start(){} // RVA: 0x7FFAC3A883C0
    public void OnApplicationQuit(){} // RVA: 0x7FFAC3A88460
    public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3A88500
    public void StopCoroutine(){} // RVA: 0x7FFAC3A885B0
    public void .ctor(){} // RVA: 0x7FFAC3A88630
    public void Initialize(){} // RVA: 0x7FFAC3A88990
    public void Internal_IsInvokingAll_86359B378FE3_86359B378FE3(){} // RVA: 0x7FFAC3A89090 | overloaded x2
    public void get_useGUILayout(){} // RVA: 0x7FFAC3A88AA0
    public void set_useGUILayout(){} // RVA: 0x7FFAC3A88B50
    public void print(){} // RVA: 0x7FFAC3A88FC0
    public void OnDestroy(){} // RVA: 0x7FFAC3A89040
    public void InvokeDelayed(){} // RVA: 0x7FFAC3A89130
    public void OnTriggerEnter(){} // RVA: 0x7FFAC3A89180
    public void FromFlippedZVector3f(){} // RVA: 0x7FFAC3A89B70
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
    public void .ctor(){} // RVA: 0x7FFAC8503240
}

public class OffsetLimits : Object
{
    public 0x6B1C0330 effector; // 0x10
    public float spring; // 0x14
    public bool x; // 0x18
    public bool y; // 0x19
    public bool z; // 0x1A
    public float minX; // 0x1C
    public float maxX; // 0x20
    public float minY; // 0x24
    public float maxY; // 0x28
    public float minZ; // 0x2C
    public float maxZ; // 0x30

    // ── Methods ──
    public void Apply(){} // RVA: 0x7FFAC3094830
    public void SpringAxis(){} // RVA: 0x7FFAC3094CC0
    public void Spring(){} // RVA: 0x7FFAC3094D50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Oid : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368E00
}

public class OnAttachedToHandDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class OnCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class OnCapturedToDiskCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C390
    public void Invoke(){} // RVA: 0x7FFAC556C460
}

public class OnCapturedToMemoryCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC49780F0
    public void Invoke(){} // RVA: 0x7FFAC49781C0
}

public class OnChangeEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C47810
}

public class OnConnectionLost : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class OnCultureInfoChangedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class OnDecodeError : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9DEB450
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC9DEB530
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class OnDefaultAttributeUseDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC45B91D0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class OnDestroyedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class OnDetachedFromHandDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class OnGUIDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class OnNavMeshPreUpdate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class OnOverrideControllerDirtyCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class OnPerformCulling : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC98F0260
    public void Invoke(){} // RVA: 0x7FFAC98F03E0
}

public class OnPhotoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C390
    public void Invoke(){} // RVA: 0x7FFAC556C460
}

public class OnPhotoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C390
    public void Invoke(){} // RVA: 0x7FFAC556C460
}

public class OnReady : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class OnScreenDeviceInfo : ValueType
{
    public UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr; // 0x10
    public Unity.Collections.NativeArray`1<byte> buffer; // 0x18
    public UnityEngine.InputSystem.InputDevice device; // 0x28
    public UnityEngine.InputSystem.OnScreen.OnScreenControl firstControl; // 0x30

    // ── Methods ──
    public void AddControl(){} // RVA: 0x7FFAC965A350
    public void RemoveControl(){} // RVA: 0x7FFAC965A450
    public void Destroy(){} // RVA: 0x7FFAC965A7E0
}

public class OnStartedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C390
    public void Invoke(){} // RVA: 0x7FFAC556C460
}

public class OnStatusChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DF00
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class OnStoppedRecordingVideoCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C390
    public void Invoke(){} // RVA: 0x7FFAC556C460
}

public class OnValidateInput : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9786DB0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC9C476E0
    public void EndInvoke(){} // RVA: 0x7FFAC9786F40
}

public class OnVideoCaptureResourceCreatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class OnVideoModeStartedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C390
    public void Invoke(){} // RVA: 0x7FFAC556C460
}

public class OnVideoModeStoppedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C390
    public void Invoke(){} // RVA: 0x7FFAC556C460
}

public class OngoingAccountSelection : ValueType
{
    public UnityEngine.InputSystem.InputDevice device; // 0x10
    public uint userId; // 0x18
}

public class OnlyValueChangedProgress`1 : Object
{
    public System.Action`1<T> action;
    public System.Collections.Generic.IEqualityComparer`1<T> comparer;
    public bool isFirstCall;
    public T latestValue;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void Report(){} // RVA: 0x7FFAC2E8DC40
}

public class Op : Object
{
    public 0x6B139680 Code; // 0x10
    public string Argument; // 0x18
    public Op Next; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC945D920
}

public class OpacityIdUpdateJob : ValueType
{
    public Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex> oldVerts; // 0x10
    public Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex> newVerts; // 0x20
    public UnityEngine.Color32 opacityData; // 0x30

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9ADEB00
}

public class OpenVRControllerDetails : ValueType
{
    public OVR.OpenVR.VRControllerState_t state; // 0x10
    public 0x6B1A44A8 controllerType; // 0x50
    public uint deviceID; // 0x58
    public UnityEngine.Vector3 localPosition; // 0x5C
    public UnityEngine.Quaternion localOrientation; // 0x68
}

public class Operator : Object
{
    public 0x6B17A188 op; // 0x10
    public int precedence; // 0x14
    public 0x6B17A1E0 associativity; // 0x18
    public int inputs; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9863CE0
}

public class Option : Object
{
    public VRC.Localization.LocalizableString OptionText; // 0x10
    public VRC.Localization.LocalizableString Tooltip; // 0x38
    public object Value; // 0x60
    public System.Func`1<bool> IsEnabled; // 0x68

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC35DB780
    public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
    public void Equals(){} // RVA: 0x7FFAC38144E0
    public void set_Tooltip(){} // RVA: 0x7FFAC4931910
    public void CompareBaseObjects(){} // RVA: 0x7FFAC38144E0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2F9CD50
    public void StartPickedUp(){} // RVA: 0x7FFAC2F9CD60
    public void get_Value(){} // RVA: 0x7FFAC2FBF370
    public void get_IsEnabled(){} // RVA: 0x7FFAC2F9CD50
    public void get_OptionText(){} // RVA: 0x7FFAC3813C20
    public void set_Value(){} // RVA: 0x7FFAC2FBF380
    public void Instantiate(){} // RVA: 0x7FFAC38144E0
    public void set_OptionText(){} // RVA: 0x7FFAC38144E0
    public void .ctor(){} // RVA: 0x7FFACB8D1820
    public void get_Tooltip(){} // RVA: 0x7FFAC35DB780
    public void set_IsEnabled(){} // RVA: 0x7FFAC2F9CD60
}

public class OptionData : Object
{
    public string text; // 0x10
    public UnityEngine.Sprite image; // 0x18

    // ── Methods ──
    public void get_text(){} // RVA: 0x7FFAC2F3C380
    public void set_text(){} // RVA: 0x7FFAC2F22E30
    public void get_image(){} // RVA: 0x7FFAC2F247C0
    public void set_image(){} // RVA: 0x7FFAC2F87E80
    public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x4
}

public class OptionDataList : Object
{
    public System.Collections.Generic.List`1<OptionData> options; // 0x10

    // ── Methods ──
    public void get_options(){} // RVA: 0x7FFAC2F3C380
    public void set_options(){} // RVA: 0x7FFAC2F22E30
    public void .ctor(){} // RVA: 0x7FFAC9745030
}

public class OptionPropertyDescriptor : PropertyDescriptor
{
    public DesignerOptionCollection ComponentType; // 0x88

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC944C0F0
    public void get_ComponentType(){} // RVA: 0x7FFAC944C180
    public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
    public void get_PropertyType(){} // RVA: 0x7FFAC944C180
    public void CanResetValue(){} // RVA: 0x7FFAC2F21320
    public void GetValue(){} // RVA: 0x7FFAC2F60010
    public void ResetValue(){} // RVA: 0x7FFAC2F21310
    public void SetValue(){} // RVA: 0x7FFAC2F21310
    public void ShouldSerializeValue(){} // RVA: 0x7FFAC2F21320
}

public class Options : ValueType
{
    public int MaxResults;
    public System.Guid[] Timeout;
    public 0x6B1A8758[] Location; // 0x8
    public int QueryType; // 0x10
    public double ActionType; // 0x18
    public 0x6B1AB148 ComponentFilter; // 0x20
    public 0x6B1A88B8 UuidFilter; // 0x24
    public 0x6B1A8860 <ActionType>k__BackingField; // 0x28
    public 0x6B1AB1F8 _componentFilter; // 0x2C
    public System.Collections.Generic.IReadOnlyList`1<System.Guid> _uuidFilter; // 0x30

    // ── Methods ──
    public void get_MaxResults(){} // RVA: 0x7FFAC4420210
    public void set_MaxResults(){} // RVA: 0x7FFAC336D8B0
    public void get_Timeout(){} // RVA: 0x7FFAC47D1AE0
    public void set_Timeout(){} // RVA: 0x7FFAC4AB3ED0
    public void get_Location(){} // RVA: 0x7FFAC2F6E5C0
    public void set_Location(){} // RVA: 0x7FFAC2F240C0
    public void get_QueryType(){} // RVA: 0x7FFAC33D5A20
    public void set_QueryType(){} // RVA: 0x7FFAC33D4990
    public void get_ActionType(){} // RVA: 0x7FFAC3157800
    public void set_ActionType(){} // RVA: 0x7FFAC392CD10
    public void get_ComponentFilter(){} // RVA: 0x7FFAC44357F0
    public void set_ComponentFilter(){} // RVA: 0x7FFAC8927790
    public void get_UuidFilter(){} // RVA: 0x7FFAC2F4F0C0
    public void set_UuidFilter(){} // RVA: 0x7FFAC89278A0
    public void .ctor(){} // RVA: 0x7FFAC8927A90
    public void TryQuerySpaces(){} // RVA: 0x7FFAC8927B70
    public void .cctor(){} // RVA: 0x7FFAC89282F0
}

public class OptionsAndroid : PlatformOptions
{
    public 0x6B273BE8 preferredMaximumResolution; // 0x20
    public 0x6B273B38 customPreferredMaximumResolution; // 0x24
    public UnityEngine.Vector2Int preferredPeakBitRate; // 0x28
    public float preferredPeakBitRateUnits; // 0x30
    public 0x6B273B90 _preferredPeakBitRateUnits; // 0x34
    public 0x6B275190 videoApi; // 0x38
    public bool useFastOesPath; // 0x3C
    public bool showPosterFrame; // 0x3D
    public 0x6B2751E8 audioOutput; // 0x40
    public 0x6B2753A0 audio360ChannelMode; // 0x44
    public bool preferSoftwareDecoder; // 0x48
    public bool forceRtpTCP; // 0x49
    public 0x6B275240 blitTextureFiltering; // 0x4C
    public int fileOffset; // 0x50
    public bool startWithHighestBitrate; // 0x54
    public int minBufferMs; // 0x58
    public int maxBufferMs; // 0x5C
    public int bufferForPlaybackMs; // 0x60
    public int bufferForPlaybackAfterRebufferMs; // 0x64
    public bool enableAudio360; // 0x68

    // ── Methods ──
    public void get_preferredMaximumResolution(){} // RVA: 0x7FFAC3921980
    public void set_preferredMaximumResolution(){} // RVA: 0x7FFAC47C2C90
    public void get_customPreferredMaximumResolution(){} // RVA: 0x7FFAC2F4F130
    public void set_customPreferredMaximumResolution(){} // RVA: 0x7FFAC47C2CA0
    public void get_preferredPeakBitRate(){} // RVA: 0x7FFAC3C40670
    public void set_preferredPeakBitRate(){} // RVA: 0x7FFAC47C2CD0
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x7FFAC3ADEDC0
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x7FFAC47C2CF0
    public void IsModified(){} // RVA: 0x7FFAC47C2D00
    public void BitRateInBitsPerSecond(){} // RVA: 0x7FFAC47C2AD0
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x7FFAC47C2DA0
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFAC45A0C60
    public void HasChanged(){} // RVA: 0x7FFAC47C2DE0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC47C2E00
    public void .ctor(){} // RVA: 0x7FFAC47C2E20
}

public class OptionsApple : PlatformOptions
{
    public 0x6B2738D0 previousAudioMode; // 0x20
    public 0x6B273980 audioMode; // 0x24
    public 0x6B2738D0 flags; // 0x28
    public 0x6B273928 preferredPeakBitRate; // 0x2C
    public 0x6B273928 preferredPeakBitRateUnits; // 0x30
    public 0x6B273980 preferredForwardBufferDuration; // 0x34
    public float preferredMaximumResolution; // 0x38
    public 0x6B273A88 customPreferredMaximumResolution; // 0x3C
    public float _preferredPeakBitRate; // 0x40
    public 0x6B273A30 _preferredPeakBitRateUnits; // 0x44
    public double _preferredForwardBufferDuration; // 0x48
    public 0x6B2739D8 _preferredMaximumResolution; // 0x50
    public UnityEngine.Vector2Int _customPreferredMaximumResolution; // 0x54

    // ── Methods ──
    public void get_previousAudioMode(){} // RVA: 0x7FFAC3C891D0
    public void get_audioMode(){} // RVA: 0x7FFAC2F7CCD0
    public void set_audioMode(){} // RVA: 0x7FFAC47C29D0
    public void get_flags(){} // RVA: 0x7FFAC3ADEDC0
    public void set_flags(){} // RVA: 0x7FFAC47C29F0
    public void get_preferredPeakBitRate(){} // RVA: 0x7FFAC30E80B0
    public void set_preferredPeakBitRate(){} // RVA: 0x7FFAC47C2A20
    public void get_preferredPeakBitRateUnits(){} // RVA: 0x7FFAC2FC20A0
    public void set_preferredPeakBitRateUnits(){} // RVA: 0x7FFAC47C2A40
    public void get_preferredForwardBufferDuration(){} // RVA: 0x7FFAC47C2A50
    public void set_preferredForwardBufferDuration(){} // RVA: 0x7FFAC47C2A60
    public void get_preferredMaximumResolution(){} // RVA: 0x7FFAC30F10E0
    public void set_preferredMaximumResolution(){} // RVA: 0x7FFAC47C2A80
    public void get_customPreferredMaximumResolution(){} // RVA: 0x7FFAC47C2A90
    public void set_customPreferredMaximumResolution(){} // RVA: 0x7FFAC47C2AA0
    public void BitRateInBitsPerSecond(){} // RVA: 0x7FFAC47C2AD0
    public void GetPreferredPeakBitRateInBitsPerSecond(){} // RVA: 0x7FFAC47C2B10
    public void .ctor(){} // RVA: 0x7FFAC47C2B50
    public void IsModified(){} // RVA: 0x7FFAC47C2C10
    public void HasChanged(){} // RVA: 0x7FFAC47C2C70
    public void ClearChanges(){} // RVA: 0x7FFAC47C2C80
}

public class OptionsBoundJsonTypeInfoResolverChain : JsonTypeInfoResolverChain
{
    public System.Text.Json.JsonSerializerOptions IsReadOnly; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9045AD0
    public void get_IsReadOnly(){} // RVA: 0x7FFAC9045A30
    public void ValidateAddedValue(){} // RVA: 0x7FFAC9045B60
    public void OnCollectionModifying(){} // RVA: 0x7FFAC9045B90
}

public class OptionsWebGL : PlatformOptions
{
    public 0x6B2752F0 externalLibrary; // 0x20
    public bool useTextureMips; // 0x24

    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFAC47C2EA0
    public void GetKeyServerAuthToken(){} // RVA: 0x7FFAC34F9180
    public void GetOverrideDecryptionKey(){} // RVA: 0x7FFAC34F9180
    public void .ctor(){} // RVA: 0x7FFAC47C2ED0
}

public class OptionsWindows : PlatformOptions
{
    public 0x6B274F80 videoApi; // 0x20
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
    public 0x6B2746E8 bufferedFrameSelection; // 0x30
    public bool pauseOnPrerollComplete; // 0x34
    public string forceAudioOutputDeviceName; // 0x38
    public System.Collections.Generic.List`1<string> preferredFilters; // 0x40
    public 0x6B274FD8 audioOutput; // 0x48
    public 0x6B2753A0 audio360ChannelMode; // 0x4C
    public bool startWithHighestBitrate; // 0x50
    public bool useLowLiveLatency; // 0x51
    public int parallelFrameCount; // 0x54
    public int prerollFrameCount; // 0x58
    public bool useUnityAudio; // 0x5C
    public bool enableAudio360; // 0x5D

    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFAC47C26D0
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFAC2FDB8E0
    public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
    public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC47C27C0
    public void .ctor(){} // RVA: 0x7FFAC47C27F0
}

public class OptionsWindowsUWP : PlatformOptions
{
    public bool useHardwareDecoding; // 0x20
    public bool useTextureMips; // 0x21
    public bool use10BitTextures; // 0x22
    public bool hintOutput10Bit; // 0x23
    public bool useLowLatency; // 0x24
    public 0x6B275088 videoApi; // 0x28
    public 0x6B2750E0 audioOutput; // 0x2C
    public 0x6B2753A0 audio360ChannelMode; // 0x30
    public bool startWithHighestBitrate; // 0x34
    public bool useLowLiveLatency; // 0x35

    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFAC47C2950
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFAC2F57C20
    public void .ctor(){} // RVA: 0x7FFAC47C29B0
}

public class OpusCodec : Object
{
    public int ÏÏÎÍÏÍÎÍÍÍÍÍÎÍÍÌÎÌÍÍÏÍÏ;
    public ÎÌÎÍÏÎÍÌÏÏÏÌÍÌÍÏÍÏÌÏÍÌÏ ÍÏÏÍÏÌÌÌÌÍÏÍÌÎÎÏÏÍÎÌÌÏÏ; // 0x10
    public ÌÏÌÌÍÍÌÌÎÎÌÎÌÍÍÏÏÌÎÌÎÌÍ ÌÌÎÍÏÌÍÌÍÌÍÌÌÏÍÏÍÏÏÎÌÌÏ; // 0x18
    public int ÏÌÏÍÎÏÎÎÎÌÍÏÏÌÏÌÎÏÍÌÎÏÎ; // 0x20
    public int ÌÌÏÍÏÍÌÎÍÎÏÏÎÏÌÍÏÏÏÏÍÌÍ; // 0x24
    public int ÏÏÏÎÎÍÌÏÍÎÍÌÎÍÍÏÍÎÏÌÎÏÏ; // 0x28
    public 0x6B019D10 ÎÎÌÏÎÍÍÌÎÍÍÏÏÌÌÏÎÎÏÏÍÎÍ; // 0x2C
    public bool ÏÏÏÏÍÌÌÎÍÎÏÎÍÎÎÌÍÍÌÍÏÏÌ; // 0x30

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC30DB160
    public void Equals(){} // RVA: 0x7FFAC30DB1F0
    public void GetHashCode(){} // RVA: 0x7FFAC30DB580
    public void op_Implicit(){} // RVA: 0x7FFAC30DB700
    public void CompareBaseObjects(){} // RVA: 0x7FFAC30DBBA0
    public void GetSkeletonType(){} // RVA: 0x7FFAC30DBBE0
    public void GetCachedPtr(){} // RVA: 0x7FFAC30DBBF0
    public void get_name(){} // RVA: 0x7FFAC30DBC80
    public void set_name(){} // RVA: 0x7FFAC30DBCA0
    public void Instantiate(){} // RVA: 0x7FFAC30DBFD0
    public void ToString(){} // RVA: 0x7FFAC30DBBE0
    public void .ctor_12114D51CACA(){} // RVA: 0x7FFAC30DC350
    public void GetHashCode_9C64B201F254(){} // RVA: 0x7FFAC30DC680
    public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFAC30DC800
    public void .ctor(){} // RVA: 0x7FFAC30DC840
    public void Initialize(){} // RVA: 0x7FFAC30DC860
    public void GetBooleanFromDelegate(){} // RVA: 0x7FFAC30DCD00
    public void GetIntegerFromDelegate(){} // RVA: 0x7FFAC30DBBE0
}

public class OrBoolean : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE9BB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OrByte : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE9670
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OrInt16 : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE92C0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OrInt32 : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE93D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OrInt64 : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE94E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OrSByte : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE91B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OrUInt16 : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE9780
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OrUInt32 : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE9890
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OrUInt64 : OrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DE9A20
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Orbit : ValueType
{
    public float m_Height; // 0x10
    public float m_Radius; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F44D10
}

public class OrderBlock : ValueType
{
    public int order; // 0x10
    public UnityEngine.Events.UnityAction callback; // 0x18
}

public class OrderedDictionaryEnumerator : Object
{
    public int Current; // 0x10
    public System.Collections.IEnumerator Entry; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9450F00
    public void get_Current(){} // RVA: 0x7FFAC9450FA0
    public void get_Entry(){} // RVA: 0x7FFAC9451250
    public void get_Key(){} // RVA: 0x7FFAC9451360
    public void get_Value(){} // RVA: 0x7FFAC94513F0
    public void MoveNext(){} // RVA: 0x7FFAC9451480
    public void Reset(){} // RVA: 0x7FFAC94514D0
}

public class OrderedDictionaryKeyValueCollection : Object
{
    public System.Collections.ArrayList System.Collections.ICollection.Count; // 0x10
    public bool System.Collections.ICollection.IsSynchronized; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC45687E0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC9451520
    public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC8593680
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC8593930
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9451880
}

public class OrganizationName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368AE0
}

public class OrganizationalUnitName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368B80
}

public class OriginalEnumValueHelper : Object
{
    public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.Dictionary`2<object,string>> dictionaries;

    // ── Methods ──
    public void GetOriginalName(){} // RVA: 0x7FFAC81C3710
    public void GetNameMapping(){} // RVA: 0x7FFAC81C3A00
    public void .cctor(){} // RVA: 0x7FFAC81C3F30
}

public class OscView : Object
{
    public bool dirty; // 0x10
    public ÍÎÍÍÍÏÍÎÎÍÍÌÍÍÌÏÏÎÍÎÏÏÍ parent; // 0x18
    public string pathName; // 0x20
    public UnityEngine.Transform currentViewObject; // 0x28
    public 0x6AFFCA98 queuedType; // 0x30
    public 0x6AFFCA98 appliedType; // 0x34
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
    public void GetInstanceID(){} // RVA: 0x7FFAC3EA1DF0
    public void Equals(){} // RVA: 0x7FFAC3EA1E00
    public void .ctor(){} // RVA: 0x7FFAC3EA1E90
    public void Initialize(){} // RVA: 0x7FFAC3EA22F0
    public void CompareBaseObjects(){} // RVA: 0x7FFAC3EA24F0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3EA3F20
    public void GetCachedPtr(){} // RVA: 0x7FFAC3EA4370
    public void get_name(){} // RVA: 0x7FFAC3EA47C0
    public void set_name(){} // RVA: 0x7FFAC3EA4950
    public void Instantiate(){} // RVA: 0x7FFAC3EA63E0
    public void GetHashCode(){} // RVA: 0x7FFAC3EA63F0
    public void ToString(){} // RVA: 0x7FFAC3EA1DF0
    public void GetHashCode_EAA173EA84A2(){} // RVA: 0x7FFAC3EA7D70
    public void ToString_56D017530C41(){} // RVA: 0x7FFAC354E300
    public void ProcessInternalDataAndReturnResult(){} // RVA: 0x7FFAC354E300
    public void get_name_A2D2DFEDC491(){} // RVA: 0x7FFAC3EA47C0
}

public class OutOfSpaceException : IOException
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC81B83F0
}

public class OutPt : Object
{
    public int Idx; // 0x10
    public IntPoint Pt; // 0x18
    public OutPt Next; // 0x28
    public OutPt Prev; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
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
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OutputEventArgs : ValueType
{
    public Mediapipe.Packet`1<T> packet;
    public long timestampMicrosecond;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C761B0
}

public class OutputParameter : Object
{
    public string address; // 0x10
    public string type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BC0310
}

public class OverlappedData : Object
{
    public System.Runtime.InteropServices.GCHandle[] _pinnedData; // 0x10
    public System.Threading.IOCompletionCallback _callback; // 0x18
    public object _state; // 0x20
    public System.Threading.ExecutionContext _executionContext; // 0x28
    public System.Threading.ThreadPoolBoundHandle _boundHandle; // 0x30
    public System.Threading.PreAllocatedOverlapped _preAllocated; // 0x38
    public bool _completed; // 0x40

    // ── Methods ──
    public void Reset(){} // RVA: 0x7FFAC86C1FD0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class OverlaySettings : Object
{
    public bool linearDepth; // 0x10
    public float motionColorIntensity; // 0x14
    public int motionGridSize; // 0x18
    public 0x6B272220 colorBlindnessType; // 0x1C
    public float colorBlindnessStrength; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC96CCAC0
}

public class ovrKeyValuePair : ValueType
{
    public string key_; // 0x10
    public 0x6B255000 valueType_; // 0x18
    public string stringValue_; // 0x20
    public int intValue_; // 0x28
    public double doubleValue_; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC884A250 | overloaded x3
}

public class ovrMatchmakingCriterion : ValueType
{
    public string key_; // 0x10
    public 0x6B255370 importance_; // 0x18
    public UIntPtr parameterArray; // 0x20
    public uint parameterArrayCount; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC884A310
}

public class ovrMatchmakingCustomQueryData : ValueType
{
    public UIntPtr dataArray; // 0x10
    public uint dataArrayCount; // 0x18
    public UIntPtr criterionArray; // 0x20
    public uint criterionArrayCount; // 0x28
}

public class ovrNetSyncVec3 : ValueType
{
    public float x; // 0x10
    public float y; // 0x14
    public float z; // 0x18
}
