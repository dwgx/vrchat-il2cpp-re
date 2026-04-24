// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Network
// Classes: 99
// Methods: 1781

namespace VRC.Network
{
    /// <summary>Originally: ÏÎÍÏÏÌÏÏÎÎÍÍÍÏÏÌÎÌÍÎÎÍÏ</summary>
    public class FlatBufferNetworkSerializer : NetworkReadyHandler_68D0
    {
        public int _typeId;
        public VRC.Core.Networking.ConcurrentLimitedCapacityList`1<VRC.Core.Networking.Pose.PoseEvent> _useDirectPoseCodec; // 0x58
        public ÏÎÏÏÎÍÌÎÌÏÍÏÏÎÎÏÎÍÎÌÎÎÍ f_150; // 0x60
        public ÌÎÎÌÎÌÏÍÌÎÎÌÏÌÌÎÌÎÎÌÏÌÍ f_2A1; // 0x68
        public ÌÌÍÌÌÏÎÎÏÎÌÏÍÏÍÌÌÌÌÏÎÌÍ f_DD3; // 0x70
        public UnityEngine.Animator f_3DB; // 0x78
        public ÏÌÎÍÏÎÌÌÎÍÍÎÌÏÌÏÌÎÍÌÎÌÎ ÎÏÌÍÎÎÎÍÎÎÏÌÌÍÍÏÏÏÎÎÌÎÌ; // 0x80
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÍÎÍÍÎÏÌÎÌÌÍÍÍÎÍÌÌÍÎÌÍÌÌ; // 0x88
        public ÎÎÏÌÏÎÌÏÌÌÎÏÎÍÎÌÏÌÌÍÏÍÌ ÍÌÍÏÍÏÎÎÎÌÎÎÎÎÎÎÌÍÎÏÎÌÏ; // 0x90
        public ÏÍÍÏÎÍÏÎÍÏÌÍÍÏÎÏÍÎÎÎÏÏÏ ÎÏÎÍÏÏÍÌÌÏÎÏÌÌÌÍÎÎÎÎÎÎÌ; // 0x98
        public ÍÍÎÎÍÎÎÏÍÌÏÏÌÎÍÍÎÎÍÏÌÏÎ ÍÍÎÎÌÏÌÍÏÌÎÌÍÌÎÌÎÌÍÏÎÌÎ; // 0xA0
        public ÍÌÌÏÍÎÎÍÍÏÌÎÏÏÎÍÍÏÎÌÌÌÎ ÏÌÌÎÏÏÍÏÎÌÏÌÏÎÍÌÎÏÎÍÍÎÏ; // 0xA8
        public UnityEngine.Transform ÏÏÌÎÌÍÍÏÍÏÏÌÌÏÎÍÌÏÌÎÍÎÎ; // 0xB0
        public VRC.Core.Networking.Pose.PoseEvent ÌÍÍÏÌÎÏÌÍÍÎÌÎÎÏÏÎÍÌÌÌÌÎ; // 0xB8
        public UnityEngine.HumanPose ÍÎÌÍÎÌÎÍÍÎÎÎÌÌÏÏÍÌÎÌÎÍÍ; // 0xC0
        public ÍÏÌÍÌ ÍÌÏÏÌÏÏÎÎÌÌÌÎÍÎÍÎÍÏÏÎÎÏ; // 0xE8
        public ÌÎÌÎÏÏÍÏÍÎÍÏÍÏÍÏÌÌÍÏÌÌÌ ÏÏÏÎÌÎÏÍÏÍÍÎÌÍÌÌÍÎÍÏÏÍÍ; // 0xF0
        public float ÍÍÌÏÎÎÎÍÌÍÏÎÎÏÍÌÎÌÍÍÏÏÌ; // 0xF8
        public float ÎÍÍÏÎÌÏÍÌÍÏÍÏÍÎÎÍÌÌÎÍÎÌ;
        public bool ÎÎÏÌÌÎÌÎÎÏÌÌÎÌÎÌÎÏÎÍÏÎÎ; // 0xFC
        public VRC.Core.Networking.Pose.PoseCodec`1<VRC.Core.Networking.FlatBuffers.FlatBuffers8.PoseRecorder> ÎÎÏÌÍÌÌÎÍÌÍÌÏÌÎÎÎÌÍÌÍÌÌ; // 0x100
        public VRC.Core.Networking.Pose.PoseCodec`1<Google.FlatBuffers8.ByteBuffer> ÌÌÌÌÎÌÍÎÏÎÌÌÎÏÌÌÍÎÍÏÍÏÎ; // 0x108
        public bool <ÍÍÌÎÎÍÍÌÏÍÎÎÍÏÌÎÏÍÎÎÎÌÎ>k__BackingField; // 0x110
        public VRC.Core.Networking.Pose.PoseEvent ÍÎÌÏÎÏÎÎÍÎÍÎÏÏÏÌÌÏÎÏÏÌÍ; // 0x118
        public VRC.Core.Networking.Pose.PoseEvent ÏÏÌÌÏÎÍÎÏÏÏÌÌÌÏÍÏÍÎÍÌÍÎ; // 0x120
        public ÍÌÌÍÎÌÎÍÌÎÌÍÎÎÌÌÌÏÎÌÍÌÏ ÏÍÌÏÏÌÎÏÌÍÏÍÎÎÎÍÍÌÍÌÎÏÎ; // 0x128
        public UnityEngine.Object ÏÎÌÏÌÎÍÍÏÌÍÏÍÎÍÍÎÍÌÌÏÌÏ; // 0x130
        public VRC.Profiling.ProfilerMarker ÎÏÎÏÌÌÌÌÌÍÎÎÍÍÎÎÎÌÏÍÏÎÍ; // 0x138
        public VRC.Profiling.ProfilerMarker ÍÏÏÏÏÌÎÎÌÍÍÏÌÌÍÏÍÍÎÎÏÌÏ; // 0x148
        public VRC.Profiling.ProfilerMarker ÏÌÏÍÌÎÏÌÍÏÌÍÎÏÎÍÌÏÍÌÎÌÎ; // 0x158
        public VRC.Profiling.ProfilerMarker ÎÎÏÌÌÌÏÌÌÎÏÎÍÌÏÎÏÍÏÌÏÎÍ; // 0x168
        public VRC.Profiling.ProfilerMarker ÎÎÎÎÎÎÏÏÏÎÏÌÍÍÌÏÎÎÌÎÍÏÎ; // 0x178
        public VRC.Profiling.ProfilerMarker ÌÍÍÍÎÎÏÎÍÏÌÎÎÌÎÎÏÌÌÎÍÏÎ; // 0x188
        public VRC.Profiling.ProfilerMarker ÎÍÌÏÌÍÍÎÍÌÎÎÍÎÍÏÌÍÌÍÌÏÍ; // 0x198
        public VRC.Profiling.ProfilerMarker ÏÎÏÍÎÌÌÌÌÏÏÌÎÎÌÎÌÍÏÌÏÍÏ; // 0x1A8
        public VRC.Profiling.ProfilerMarker ÍÏÎÌÌÍÍÌÎÍÍÌÍÍÎÌÌÏÍÎÍÍÍ; // 0x1B8
        public VRC.Profiling.ProfilerMarker ÍÌÌÎÎÍÏÎÌÏÍÌÏÌÏÌÎÏÎÎÏÎÎ; // 0x1C8

        // ── Methods ──
        public void Decode(){} // RVA: 0x7FFD4E607D50 | overloaded x3
        public void Encode(){} // RVA: 0x7FFD4E6022C0 | overloaded x2
        public void GetLanguage(){} // RVA: 0x7FFD4E5FFD80
        public void ReadComponentState(){} // RVA: 0x7FFD4E600000
        public void GetComponentTransform(){} // RVA: 0x7FFD4E600200
        public void .ctor(){} // RVA: 0x7FFD4E6010F0
        public void NeedsSync(){} // RVA: 0x7FFD4E6017F0
        public void ProcessGameObject(){} // RVA: 0x7FFD4E601800
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E341320
        public void CheckAndGetSerializedData(){} // RVA: 0x7FFD4E601D50
        public void GetOutputBuffer(){} // RVA: 0x7FFD4E602110
        public void set_TypeId(){} // RVA: 0x7FFD4E602300
        public void SetActive_DED(){} // RVA: 0x7FFD4E603800
        public void StartCoroutine(){} // RVA: 0x7FFD4E603D50
        public void get_TypeId(){} // RVA: 0x7FFD4E6048B0
        public void DoSetTriggerString_235(){} // RVA: 0x7FFD4E6048C0
        public void print(){} // RVA: 0x7FFD4E426850
        public void CanProcessDataType2(){} // RVA: 0x7FFD4E604A90
        public void Awake(){} // RVA: 0x7FFD4E604B60
        public void OnDestroy(){} // RVA: 0x7FFD4E604F30
        public void get_hidden(){} // RVA: 0x7FFD4E604FA0
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7FFD4E605070
        public void DoIsSafe(){} // RVA: 0x7FFD4E605170
        public void DoBaseCopy(){} // RVA: 0x7FFD4E605210
        public void ReadRectTransformState(){} // RVA: 0x7FFD4E605740
        public void GetOrCreateNetworkSyncableValue(){} // RVA: 0x7FFD4E605870
        public void set_UseDirectPoseCodec(){} // RVA: 0x7FFD4E605C40
        public void CanProcessDataType4(){} // RVA: 0x7FFD4E605C50
        public void IsNetworkSerializationReady(){} // RVA: 0x7FFD4E605CA0
        public void GetRect(){} // RVA: 0x7FFD4E605E70
        public void CanProcessDataPart(){} // RVA: 0x7FFD4E605FC0
        public void Updateposition_Inj(){} // RVA: 0x7FFD4E606850
        public void Reset(){} // RVA: 0x7FFD4E606900
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E426850
        public void CanSerializeSpecificData(){} // RVA: 0x7FFD4E6076F0
        public void SerializedName(){} // RVA: 0x7FFD4E607900
        public void DoSetLocalPositionAndRotation_Injected_906(){} // RVA: 0x7FFD4E607A70
        public void DoSetLocalPositionAndRotation_Injected_A12(){} // RVA: 0x7FFD4E607C40
        public void Update(){} // RVA: 0x7FFD4E55BE20
        public void NeedsImportant(){} // RVA: 0x7FFD4E426850
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFD4E607D90
        public void Start(){} // RVA: 0x7FFD4E607DA0
    }

    /// <summary>Originally: ÌÌÏÏÍÏÏÍÎÍÌÎÎÏÏÎÌÍÎÎÎÎÏ</summary>
    public class NetworkCancelRPCComponent_3006 : MonoBehaviour
    {
        public UnityEngine.Animator _destroyCancellationToken; // 0x20
        public ÏÌÎÍÏÎÌÌÎÍÍÎÌÏÌÏÌÎÍÌÎÌÎ _useGUILayout; // 0x28
        public ÌÌÍÌÌÏÎÎÏÎÌÏÍÏÍÌÌÌÌÏÎÌÍ ÌÏÏÍÌÌÍÎÎÍÌÍÌÏÎÍÌÍÎÌÍÌÏ; // 0x30
        public ÏÎÏÏÎÍÌÎÌÏÍÏÏÎÎÏÎÍÎÌÎÎÍ ÎÎÎÍÌÎÏÎÏÎÏÏÏÏÏÌÏÎÏÍÎÍÍ; // 0x38
        public bool ÎÎÏÎÌÎÌÎÎÍÏÌÌÏÏÍÏÏÌÌÎÏÎ; // 0x40
        public bool ÌÎÍÎÌÍÌÌÌÍÌÎÏÌÏÌÍÌÌÍÎÍÏ; // 0x41
        public float ÎÎÍÏÏÌÍÎÏÌÌÎÌÍÏÌÏÌÌÎÌÏÍ; // 0x44
        public float ÌÎÌÏÏÏÏÎÌÎÎÎÌÎÌÏÎÎÌÎÏÏÌ; // 0x48
        public UnityEngine.AnimatorTransitionInfo ÏÍÌÏÍÏÎÏÍÍÍÍÌÎÌÍÏÎÍÎÏÍÎ; // 0x4C
        public int ÌÍÍÏÍÍÌÍÍÍÍÎÎÎÍÎÌÍÌÎÌÏÌ; // 0x6C
        public int ÎÏÎÎÌÎÍÍÏÏÌÏÏÌÏÌÏÏÏÏÏÌÍ; // 0x70
        public float ÎÌÎÍÎÏÏÏÍÌÍÎÍÌÍÍÍÏÏÎÏÏÏ; // 0x74
        public float ÍÏÍÍÎÎÍÏÎÍÎÎÍÎÍÏÏÏÍÍÏÍÍ; // 0x78
        public float ÎÍÍÎÌÍÏÎÍÌÍÍÍÍÏÌÍÏÎÌÎÏÍ; // 0x7C
        public float ÍÎÌÎÎÏÌÏÎÍÏÍÌÏÌÎÏÏÌÎÏÍÏ; // 0x80
        public bool ÍÏÏÎÎÍÍÍÎÍÍÍÍÌÏÍÏÏÎÍÍÎÌ; // 0x84
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ ÎÎÏÍÍÎÎÏÌÎÍÌÎÎÎÌÍÏÏÎÌÌÎ; // 0x88
        public ÍÏÎÍÍÌÎÍÌÌÎÏÌÎÌÏÏÌÌÌÎÏÏ ÍÎÌÎÌÎÍÍÎÌÍÌÏÎÎÍÌÌÏÌÌÍÏ; // 0x90
        public ÍÌÌÏÍÎÎÍÍÏÌÎÏÏÎÍÍÏÎÌÌÌÎ ÍÎÎÌÎÍÌÎÏÍÎÌÌÍÎÌÎÍÌÎÎÎÍ; // 0x98
        public ÍÌÎÍÌÌÎÌÏÍÏÍÍÏÍÎÎÏÌÌÎÌÏ ÎÏÌÏÎÏÍÌÍÌÍÎÍÏÏÏÌÍÏÌÎÌÎ; // 0xA0
        public ÎÌÎÌÏÎÏÍÎÏÌÍÏÏÌÏÌÌÎÎÌÏÍ ÍÍÏÎÏÍÌÌÍÏÍÍÍÏÏÌÏÏÏÎÌÍÍ; // 0xA8
        public bool ÏÌÍÍÎÏÎÎÎÎÏÎÏÎÌÌÍÏÏÍÎÏÌ; // 0xB0
        public bool ÎÌÍÎÏÎÏÍÎÎÌÏÏÏÌÏÎÌÍÌÎÍÍ; // 0xB1
        public bool ÍÎÎÏÍÎÍÎÍÌÌÏÌÏÍÍÌÎÌÌÍÎÏ; // 0xB2
        public int ÍÍÏÎÌÎÎÍÌÏÍÎÍÏÌÌÌÏÏÌÍÌÏ; // 0xB4
        public int ÌÏÍÏÎÌÍÏÍÏÍÌÏÏÌÏÏÎÏÌÍÍÍ; // 0xB8
        public float ÌÏÏÏÎÏÎÏÎÌÎÌÌÍÏÌÍÍÎÌÏÎÍ; // 0xBC
        public System.Action ÍÍÏÍÎÎÏÏÏÍÏÎÎÍÏÌÏÍÎÏÌÌÌ; // 0xC0

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EF9C330
        public void RaiseCancellation(){} // RVA: 0x7FFD4EF9C460
        public void IsInvoking(){} // RVA: 0x7FFD4EF9CBC0
        public void CancelInvoke(){} // RVA: 0x7FFD4EF9CBE0
        public void Invoke(){} // RVA: 0x7FFD4EF9CFA0
        public void Awake(){} // RVA: 0x7FFD4EF9D350
        public void Start(){} // RVA: 0x7FFD4EF9D360
        public void IsInvoking_75ECBA8B2434(){} // RVA: 0x7FFD4EF9D980
        public void StartCoroutine(){} // RVA: 0x7FFD4EF9DAA0
        public void Update(){} // RVA: 0x7FFD4EF9DC50
        public void LateUpdate(){} // RVA: 0x7FFD4EF9DF10
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E341320
        public void OnDestroy(){} // RVA: 0x7FFD4EF9DF20
        public void StopCoroutine(){} // RVA: 0x7FFD4EF9DF70
        public void OnApplicationQuit(){} // RVA: 0x7FFD4EF9E320
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EF9E470
        public void get_useGUILayout(){} // RVA: 0x7FFD4EF9E620
        public void .ctor(){} // RVA: 0x7FFD4EF9E750
        public void Initialize(){} // RVA: 0x7FFD4EF9E7B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EF9EA80
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4EF9DF20
        public void CancelRPC(){} // RVA: 0x7FFD4EF9EB70
        public void OnTriggerExit(){} // RVA: 0x7FFD4EF9EC70
        public void OnBecameInvisible(){} // RVA: 0x7FFD4EF9D350
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4EF9EC90
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4EF9ECA0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4EF9ED90
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4EF9EE90
    }

    /// <summary>Originally: ÏÎÌÎÏÎÎÎÍÌÎÌÏÏÏÍÏÍÎÏÏÎÍ</summary>
    public class NetworkDeserializeImplementationSerializeImplem_C9A8 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<string> ÍÌÏÏÎÍÍÍÍÌÌÍÎÏÍÎÌÌÌÍÌÎÎ;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FB720E0
        public void SerializeImplementation(){} // RVA: 0x7FFD4FB72140
        public void DeserializeImplementation(){} // RVA: 0x7FFD4FB721F0
        public void .cctor(){} // RVA: 0x7FFD4FB723D0
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E919180
    }

    /// <summary>Originally: ÌÏÏÏÏÍÏÏÌÍÎÏÌÌÏÍÏÌÌÍÌÍÌ</summary>
    public class NetworkDisposeAsyncImplSibling_3E50
    {
        public object f_076;
        public object f_A65;
        public object f_90F;

        // ── Methods ──
        public void GetLast(){} // RVA: 0x7FFD4E078E90
        public void GetLast_20A8D13A070C(){} // RVA: 0x7FFD4E078E90
        public void ProcessNetworkDispose(){} // RVA: 0x7FFD4E090980
        public void ExecuteNetworkDisposeAsync(){} // RVA: 0x7FFD4E079960
        public void GetLast_C8DD9D875857(){} // RVA: 0x7FFD4E078E90
    }

    /// <summary>Originally: ÏÍÎÎÏÏÍÏÌÌÎÌÌÏÏÎÎÏÏÎÎÏÌ</summary>
    public class NetworkDisposeAsyncImplSibling_56AC
    {
        public object f_803;
        public object f_052;
        public object f_3E8;
        public object f_0F5;

        // ── Methods ──
        public void GetLast(){} // RVA: 0x7FFD4E078E90
        public void Short(){} // RVA: 0x7FFD4E079960
        public void GetLast_EF4A25D8D0A6(){} // RVA: 0x7FFD4E078E90
        public void GetLast_3AAD54467D56(){} // RVA: 0x7FFD4E078E90
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_FBF8F73880B1(){} // RVA: 0x7FFD4E090A40
        public void GetLast_C8DD9D875857(){} // RVA: 0x7FFD4E078E90
    }

    /// <summary>Originally: ÏÍÍÌÏÏÍÏÌÌÌÌÏÎÍÌÌÌÍÏÍÍÏ</summary>
    public class NetworkDisposeAsyncImpl_1879 : NetworkDisposeAsync_9716
    {
        public object _1879;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F0A20E0
        public void Init(){} // RVA: 0x7FFD4F0A2270
        public void .ctor(){} // RVA: 0x7FFD4F0A2400
        public void Initialize(){} // RVA: 0x7FFD4F0A2410
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F0A25A0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F0A26B0
        public void GetCachedPtr(){} // RVA: 0x7FFD4F0A2840
        public void get_name(){} // RVA: 0x7FFD4F0A29D0
    }

    /// <summary>Originally: ÎÍÍÌÌÏÍÎÍÍÏÏÎÏÌÌÌÏÍÌÌÏÎ</summary>
    public class NetworkDisposeAsyncImpl_B240 : NetworkDisposeAsync_9716
    {
        public 0x6640CE60 f_803; // 0x28
        public System.Nullable`1<System.ValueTuple`2<string,0x66366498>> f_052; // 0x30

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FA70AF0
        public void Instantiate(){} // RVA: 0x7FFD4FA70B30
        public void get_ValidExpressions(){} // RVA: 0x7FFD4FA70C40
        public void set_ValidExpressions(){} // RVA: 0x7FFD4FA70CF0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FA70D30
        public void .ctor(){} // RVA: 0x7FFD4FA70DD0
        public void Initialize(){} // RVA: 0x7FFD4FA70E10
        public void get_name(){} // RVA: 0x7FFD4FA70E20
        public void set_name(){} // RVA: 0x7FFD4FA70EA0
        public void DefaultEquals(){} // RVA: 0x7FFD4FA70F20
        public void Initialize_174CA6559733(){} // RVA: 0x7FFD4FA71030
        public void GetTextureTransparency(){} // RVA: 0x7FFD4E70C4C0
        public void Initialize_4267D378B801(){} // RVA: 0x7FFD4FA71190
        public void DisposeAsync(){} // RVA: 0x7FFD4FA71210
        public void DisposeAsync_2D731A7CE1A1(){} // RVA: 0x7FFD4FA712B0
        public void ApplyRandomizedSequenceNumbers(){} // RVA: 0x7FFD4FA71430
        public void ApplyRandomizedSequenceNumbers_6C5244C4E64E(){} // RVA: 0x7FFD4FA71570
        public void Initialize_C8DD9D875857(){} // RVA: 0x7FFD4FA70E10
        public void OnDisable(){} // RVA: 0x7FFD4FA71700
        public void Instantiate_977FEBB0B276(){} // RVA: 0x7FFD4FA70B30
        public void OnDisable_3AAD54467D56(){} // RVA: 0x7FFD4FA71780
        public void GetTextureTransparency_249D44EAA04F(){} // RVA: 0x7FFD4FA71800
        public void ExecuteNetworkDispose(){} // RVA: 0x7FFD4FA71960
    }

    /// <summary>Originally: ÍÍÏÎÌÏÎÌÌÏÍÍÍÏÎÍÌÎÎÌÍÏÏ</summary>
    public class NetworkDisposeAsyncImpl_EDC8 : NetworkDisposeAsync_9716
    {
        public object f_076;
        public object f_A65;
        public object f_90F;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F139D60
        public void Init(){} // RVA: 0x7FFD4F139D70
        public void get_ValidExpressions(){} // RVA: 0x7FFD4F139E80
        public void set_ValidExpressions(){} // RVA: 0x7FFD4F139F90
        public void .ctor(){} // RVA: 0x7FFD4F0A2400
        public void Initialize(){} // RVA: 0x7FFD4F13A0A0
        public void GetCachedPtr(){} // RVA: 0x7FFD4F13A1B0
        public void get_name(){} // RVA: 0x7FFD4F139D60
        public void set_name(){} // RVA: 0x7FFD4F13A2C0
        public void ReadTransformState(){} // RVA: 0x7FFD4F13A3D0
        public void GetUnityEngine(){} // RVA: 0x7FFD4F13A560
        public void DisposeAsync(){} // RVA: 0x7FFD4F13A5E0
        public void Initialize_37B6A3E87812(){} // RVA: 0x7FFD4F13A6F0
    }

    /// <summary>Originally: ÌÎÎÌÌÍÍÌÌÏÏÌÍÎÌÎÌÎÍÎÍÏÎ</summary>
    public class NetworkDisposeAsyncImpl_F230 : NetworkDisposeAsync_9716
    {
        public object _f230;

        // ── Methods ──
        public void GetComputedValue(){} // RVA: 0x7FFD4FA76FF0
        public void Init(){} // RVA: 0x7FFD4FA77180
        public void get_ValidExpressions(){} // RVA: 0x7FFD4FA77190
        public void set_ValidExpressions(){} // RVA: 0x7FFD4FA772A0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FA773B0
        public void .ctor(){} // RVA: 0x7FFD4F0A2400
        public void Initialize(){} // RVA: 0x7FFD4FA77540
        public void get_name(){} // RVA: 0x7FFD4FA77180
        public void set_name(){} // RVA: 0x7FFD4FA77180
        public void Instantiate(){} // RVA: 0x7FFD4FA77650
        public void GetUnityEngine(){} // RVA: 0x7FFD4FA777E0
        public void Initialize_07F305931803(){} // RVA: 0x7FFD4FA77540
        public void Initialize_08541A0F1873(){} // RVA: 0x7FFD4FA77190
    }

    /// <summary>Originally: ÍÎÏÌÍÏÏÌÍÌÌÏÍÌÏÍÎÏÎÌÌÏÍ</summary>
    public class NetworkDisposeAsyncSibling_BBCE
    {
        public object f_226;
        public object f_539;
        public object f_F94;
        public object f_E56;

        // ── Methods ──
        public void ForwardCallArgs(){} // RVA: 0x7FFD4E079960
        public void ForwardCallArgs_174CA6559733(){} // RVA: 0x7FFD4E079960
        public void GetLast(){} // RVA: 0x7FFD4E078E90
        public void InitializeForwardCallArgs(){} // RVA: 0x7FFD4E0788A0
        public void SerializeForwardCallArgs(){}
        public void DeserializeForwardCallArgs(){}
        public void GetLast_C8DD9D875857(){} // RVA: 0x7FFD4E078E90
    }

    /// <summary>Originally: ÏÎÎÌÏÏÌÍÎÏÌÎÎÌÌÏÍÍÏÍÎÍÍ</summary>
    public class NetworkDisposeAsync_2F8D : Object
    {
        public 0x664A1B88 _name; // 0x10
        public System.Threading.CancellationTokenSource _hideFlags; // 0x18
        public System.Collections.Concurrent.ConcurrentQueue`1<byte[]> ÍÏÎÎÌÎÍÍÎÍÏÌÍÌÎÍÍÏÍÍÍÌÌ; // 0x20
        public 0x66637F80 ÏÌÌÎÍÍÎÍÍÎÎÌÌÌÌÌÎÍÌÌÏÎÌ; // 0x28
        public int ÎÎÏÍÍÏÎÏÌÌÍÍÏÍÌÏÍÏÌÎÌÍÌ; // 0x30
        public bool <ÏÎÌÌÍÎÍÌÍÌÎÎÍÏÌÏÌÍÎÍÎÏÎ>k__BackingField; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F9CC340
        public void Initialize(){} // RVA: 0x7FFD4F9CC860
        public void Equals(){} // RVA: 0x7FFD4F9CC920
        public void op_Implicit(){} // RVA: 0x7FFD4F9CCB10
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F9CCD40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F9CCF70
        public void StartWithHighestBandwidth(){} // RVA: 0x7FFD4E377C20
        public void DisposeAsync(){} // RVA: 0x7FFD4F9CD000
        public void set_name(){} // RVA: 0x7FFD4F9CD190
        public void Instantiate(){} // RVA: 0x7FFD4F9CD220
        public void Dispose(){} // RVA: 0x7FFD4F9CD260
        public void Cleanup(){} // RVA: 0x7FFD4F9CD2F0
        public void GetHashCode(){} // RVA: 0x7FFD4F9CD330
        public void set_inContact(){} // RVA: 0x7FFD4E37BAC0
    }

    /// <summary>Originally: ÍÏÍÍÌÎÏÎÍÍÌÏÍÍÎÌÎÎÌÎÎÏÍ</summary>
    public class NetworkDisposeAsync_9716 : Object
    {
        public ÎÎÎÏÍÍÌÎÍÍÎÍÎÎÌÍÎÍÎÏÍÎÏ _name; // 0x10
        public System.WeakReference`1<ÌÍÌÌÏÍÌÎÌÏÏÍÌÍÎÌÍÏÍÍÏÍÌ> _hideFlags; // 0x18
        public bool f_226; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E3447C0
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void get_ValidExpressions(){} // RVA: 0x7FFD4E42F9D0
        public void set_ValidExpressions(){} // RVA: 0x7FFD4E42F9E0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FA71A10
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FA71B20
        public void GetCachedPtr(){} // RVA: 0x7FFD4FA71C30
        public void get_name(){} // RVA: 0x7FFD4FA71D40
        public void set_name(){} // RVA: 0x7FFD4FA71F20
        public void Instantiate(){} // RVA: 0x7FFD4FA720C0
        public void Equals(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4FA72280
        public void Initialize(){} // RVA: 0x7FFD4FA723C0
        public void Dispose(){} // RVA: 0x7FFD4FA72510
        public void DisposeAsync(){} // RVA: 0x7FFD4FA72590
        public void Finalize(){} // RVA: 0x7FFD4FA72720
    }

    /// <summary>Originally: ÎÌÏÍÍÍÎÍÍÏÌÎÏÏÍÏÍÎÏÏÎÍÎ</summary>
    public class NetworkEnableMeshRPCSetPresetRPCComponent_033F : MonoBehaviour
    {
        public UnityEngine.Light ÏÏÏÍÌÎÎÍÍÏÍÌÌÎÍÌÎÌÌÍÍÍÏ; // 0x20
        public System.Collections.Generic.List`1<ÎÍÌÎÌÍÌÎÌÍÏÏÍÍÌÎÍÏÎÍÌÏÎ> ÏÍÏÍÎÌÌÌÍÌÏÍÍÍÌÌÎÎÎÏÍÌÎ; // 0x28
        public int ÍÏÍÌÏÌÏÌÍÌÎÍÍÍÏÏÌÍÎÏÎÍÌ; // 0x30

        // ── Methods ──
        public void Use(){} // RVA: 0x7FFD4EA9C180
        public void SetPresetRPC(){} // RVA: 0x7FFD4EA9C4B0
        public void IsInvoking(){} // RVA: 0x7FFD4EA9C580
        public void CancelInvoke(){} // RVA: 0x7FFD4EA9C8B0
        public void Invoke(){} // RVA: 0x7FFD4EA9CF60
        public void Pickup(){} // RVA: 0x7FFD4EA9D110
        public void Start(){} // RVA: 0x7FFD4EA9D340
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4EA9D590
        public void Drop(){} // RVA: 0x7FFD4EA9D840
        public void EnableMeshRPC(){} // RVA: 0x7FFD4EA9DB00
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EA9DCB0
        public void StopCoroutine(){} // RVA: 0x7FFD4EA9DF50
        public void OnApplicationQuit(){} // RVA: 0x7FFD4EA9E600
        public void OnBecameVisible(){} // RVA: 0x7FFD4EA9E730
    }

    /// <summary>Originally: ÎÎÍÍÎÌÌÎÍÏÌÌÏÎÎÏÍÎÏÍÏÎÍ</summary>
    public class NetworkEnumeratorContainsSibling_8DE4 : Object
    {
        public int ÍÌÌÌÎÌÏÏÏÎÌÍÏÎÌÎÎÍÎÌÏÍÌ;
        public System.IFormatProvider ÏÏÍÎÏÌÍÍÌÎÍÏÌÌÌÎÌÏÏÍÌÍÏ; // 0x8
        public System.Collections.Generic.IDictionary`2<System.Type,ÏÍÏÌÍÌÌÎÍÏÍÏÏÌÍÏÏÍÌÏÌÎÌ> ÎÌÏÎÏÍÏÏÍÏÍÎÏÎÎÏÍÏÏÎÍÍÍ; // 0x10
        public System.Collections.Generic.IDictionary`2<System.Type,ÏÍÏÌÍÌÌÎÍÏÍÏÏÌÍÏÏÍÌÏÌÎÌ> ÍÏÎÍÍÍÏÏÎÌÎÎÎÏÍÎÌÍÌÌÎÎÌ; // 0x18
        public System.Collections.Generic.IDictionary`2<System.Type,System.Collections.Generic.IDictionary`2<System.Type,ÌÏÍÌÎÏÌÎÌÎÍÌÌÌÍÍÏÎÍÍÎÌÏ>> ÌÎÍÎÌÌÎÏÍÏÏÍÎÍÍÌÌÌÎÍÏÎÌ; // 0x20
        public System.Collections.Generic.IDictionary`2<System.Type,System.Collections.Generic.IDictionary`2<System.Type,ÌÏÍÌÎÏÌÎÌÎÍÌÌÌÍÍÏÎÍÍÎÌÏ>> ÏÍÎÍÌÏÎÏÏÍÏÌÌÎÍÍÎÌÎÌÌÏÎ; // 0x28
        public System.Collections.Generic.IDictionary`2<System.Type,ÍÏÏÍÎÎÏÌÏÎÏÏÏÎÏÏÍÍÍÏÎÏÌ> ÏÌÏÎÍÎÏÍÌÏÍÌÌÌÎÍÏÌÍÏÌÍÏ; // 0x30
        public object ÏÎÏÌÌÍÍÌÍÏÏÌÏÏÌÎÌÎÎÎÍÌÏ; // 0x38
        public System.Collections.Generic.IDictionary`2<System.Type,System.Collections.Generic.IDictionary`2<System.Type,System.Reflection.MethodInfo>> ÍÎÍÎÎÌÌÌÌÌÎÎÌÎÌÎÏÍÎÎÌÎÎ; // 0x40
        public object ÍÍÎÌÎÏÏÎÎÎÍÌÏÎÏÌÎÍÎÍÏÏÏ; // 0x48
        public System.Collections.Generic.IDictionary`2<System.Type,ÏÏÏÏÏÍÏÌÎÏÎÎÌÌÎÍÍÌÏÌÏÌÌ> ÏÍÌÎÌÎÏÌÎÏÍÎÌÏÎÏÍÌÍÏÍÎÎ; // 0x50
        public object ÌÍÏÌÌÏÌÌÍÌÌÏÎÌÌÍÌÌÎÏÌÍÏ; // 0x58
        public System.Collections.Generic.IDictionary`2<System.Type,System.Collections.Generic.IList`1<ÍÎÏÏÎÎÏÎÍÌÍÎÌÏÍÎÌÌÍÏÏÏÎ>> ÍÎÎÎÌÍÍÌÏÌÎÍÎÍÎÏÎÌÍÌÍÏÏ; // 0x60
        public object ÍÎÎÏÌÎÏÍÎÎÌÍÎÎÍÌÍÍÌÍÎÍÌ; // 0x68
        public ÎÎÍÏÎÎÌÍÎÎÏÏÎÌÎÌÏÌÌÍÌÏÌ ÏÌÎÌÌÎÎÍÌÏÌÏÌÎÎÎÍÌÏÎÏÎÍ; // 0x70
        public object ÌÎÏÎÎÌÎÏÏÌÏÏÍÌÌÎÏÏÍÍÌÏÏ; // 0x78

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4EEF08B0
        public void MoveNext(){} // RVA: 0x7FFD4EEF1A50
        public void get_Current(){} // RVA: 0x7FFD4EEF1C90
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
        public void .cctor(){} // RVA: 0x7FFD4EEF1F20
        public void get_name(){} // RVA: 0x7FFD4EEF2AC0
        public void set_name(){} // RVA: 0x7FFD4EEF3190
        public void Destroy_DB7E67687709(){} // RVA: 0x7FFD4EEF6EC0 | overloaded x2
        public void ToString_3860F281C6FB(){} // RVA: 0x7FFD4EEF5600 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4EEF53F0
        public void Instantiate(){} // RVA: 0x7FFD4EEF5660
        public void Equals(){} // RVA: 0x7FFD4EEF5C80
        public void BeginProfilerSample(){} // RVA: 0x7FFD4EEF66F0
        public void GetNextSibling(){} // RVA: 0x7FFD4EEF72F0
        public void DestroyImmediate(){} // RVA: 0x7FFD4EEF7390
        public void InitializeStaticResources_0DCB82A736FE(){} // RVA: 0x7FFD4EEF9D30 | overloaded x2
        public void FindObjectsOfType(){} // RVA: 0x7FFD4EEF7DC0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EEF7E40
        public void FindObjectsByType(){} // RVA: 0x7FFD4EEF7FF0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4EEF9C20
        public void get_hideFlags(){} // RVA: 0x7FFD4EEF9CA0
        public void set_hideFlags_BCFF478072A7(){} // RVA: 0x7FFD4EEF9DD0 | overloaded x2
        public void FindObjectOfType(){} // RVA: 0x7FFD4EEF9DA0
    }

    /// <summary>Originally: ÎÌÌÎÌÍÌÍÍÌÌÌÏÍÍÍÏÌÎÎÎÍÌ</summary>
    public class NetworkEnumeratorContainsSibling_B68B
    {
        public object f_1DA;
        public object f_598;
        public object f_E82;
        public object f_A2C;
        public object f_34C;
        public object f_18A;
        public object f_1B2;

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFD4E079D00
        public void get_Current(){} // RVA: 0x7FFD4E079D00
        public void InvokeDelegate(){} // RVA: 0x7FFD4E079D00
        public void InvokeDelegate_170B84DE3876(){} // RVA: 0x7FFD4E079D00
        public void InvokeDelegate_5100C9C5E968(){} // RVA: 0x7FFD4E079D00
        public void InvokeDelegate_BB95E632CDCC(){} // RVA: 0x7FFD4E079D00
        public void InvokeDelegate_FA4F4937C3C1(){} // RVA: 0x7FFD4E079D00
        public void InvokeDelegate_3A78B05D521A(){} // RVA: 0x7FFD4E079D00
        public void GetCurrentTime(){} // RVA: 0x7FFD4E07EB60
        public void MarshalValueToNative(){} // RVA: 0x7FFD4E079960
        public void MarshalValueFromNative(){} // RVA: 0x7FFD4E079960
        public void GetLast(){} // RVA: 0x7FFD4E078E90
        public void GetLast_31C54EA5A4DA(){} // RVA: 0x7FFD4E078E90
        public void Enable(){} // RVA: 0x7FFD4E091060
        public void Seek(){} // RVA: 0x7FFD4E092080
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void RemoveAt_8D778E63E9E3(){} // RVA: 0x7FFD4E090ED0
        public void OnCanceled(){} // RVA: 0x7FFD4E090BF0
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void MoveNext_0DCB82(){} // RVA: 0x7FFD4E090A40 | overloaded x2
    }

    /// <summary>Originally: ÌÎÏÏÍÏÍÎÏÎÏÌÌÎÌÏÍÍÍÎÌÎÌ</summary>
    public class NetworkItemSiblingSiblingSibliSibling_E49B
    {
        public object f_54C;
        public object f_6F4;

        // ── Methods ──
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_FF669DB73A89(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_39480E4922EE(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_0BA94B1CE8BE(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_2A0DAD19532C(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_7AE9BC3354F3(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_AA3FEC7DAA18(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_628E592C3BB2(){} // RVA: 0x7FFD4E090A40
        public void GetLast(){} // RVA: 0x7FFD4E090980
        public void Encode(){} // RVA: 0x7FFD4E079D00
        public void GetLast_A688D9563EAF(){} // RVA: 0x7FFD4E078E90
    }

    /// <summary>Originally: ÍÍÏÏÏÌÎÎÌÌÍÌÎÍÍÌÎÍÏÍÎÌÌ</summary>
    public class NetworkItemSiblingSiblingSibling_3955 : NetworkItemSiblingSiblingSibling_8C0A
    {
        public TMPro.TextMeshProUGUI f_6F9; // 0x40
        public TMPro.TextMeshProUGUI f_54C; // 0x48
        public UnityEngine.GameObject f_6F4; // 0x50
        public VRC.DataModel.KeyboardData _keyboardData; // 0x58
        public bool _manualTrigger; // 0x60
        public string ÏÍÏÎÍÎÌÌÌÏÏÍÍÏÎÍÌÎÍÌÎÎÏ; // 0x68
        public UnityEngine.UI.Button ÎÌÏÏÏÍÌÎÏÏÎÎÍÏÌÌÍÍÏÏÏÏÎ; // 0x70
        public UnityEngine.UI.Button ÌÌÍÎÏÏÎÏÌÌÏÏÌÍÌÏÎÎÎÌÌÍÍ; // 0x78

        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFD56BE5660
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void IsInvoking(){} // RVA: 0x7FFD56BE5890
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void IsInvoking_ACC61E44F513(){} // RVA: 0x7FFD56BE58B0
        public void InvokeRepeating(){} // RVA: 0x7FFD56BE5BF0
        public void ProcessInputAndCallMethod(){} // RVA: 0x7FFD56BE5C40
        public void Initialize(){} // RVA: 0x7FFD4F6A1240
        public void StartCoroutine(){} // RVA: 0x7FFD56BE5DA0
        public void StartCoroutine_800C8BC57F46(){} // RVA: 0x7FFD56BE5E60
        public void Initialize_835A3CCA07B6(){} // RVA: 0x7FFD56BE6090
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD56BE65A0
        public void OnSerializing(){} // RVA: 0x7FFD4E409500
        public void OnPointerClick(){} // RVA: 0x7FFD56BE65A0
        public void UpdateLabelFilterActiveState(){} // RVA: 0x7FFD56BE65E0
        public void OnUpdate(){} // RVA: 0x7FFD4EB28F90
        public void get_useGUILayout(){} // RVA: 0x7FFD56BE66E0
        public void SetBehaviourEnabledState(){} // RVA: 0x7FFD56BE6A20
        public void Initialize_ADAE53BABA41(){} // RVA: 0x7FFD56BE6A50
        public void SetBehaviourEnabledStateDuplicate(){} // RVA: 0x7FFD56BE6A80
        public void .ctor(){} // RVA: 0x7FFD56BE6DC0
        public void Initialize_C87F8B22F49E(){} // RVA: 0x7FFD4FCD62F0
        public void SendNetworkEvent(){} // RVA: 0x7FFD56BE6E90
        public void ReceiveNetworkEvent(){} // RVA: 0x7FFD56BE6E90
        public void Awake(){} // RVA: 0x7FFD56BE6EF0
    }

    /// <summary>Originally: ÏÎÌÌÍÍÏÌÌÌÌÎÏÎÌÍÍÌÎÍÏÎÍ</summary>
    public class NetworkItemSiblingSiblingSibling_5AD6 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E078FF0
        public void GetHashCode_ADAE53BABA41(){} // RVA: 0x7FFD4E078FF0 | overloaded x2
        public void Create(){} // RVA: 0x7FFD4E078F80
        public void Distinct(){} // RVA: 0x7FFD4E089600
        public void Equals(){} // RVA: 0x7FFD4E089600 | overloaded x3
        public void Instantiate(){} // RVA: 0x7FFD4E08B4C0 | overloaded x4
        public void Instantiate_44751D44E461(){} // RVA: 0x7FFD4E078F80
        public void Equals_5C036EE51A73(){} // RVA: 0x7FFD4E078FF0
    }

    /// <summary>Originally: ÎÏÌÌÎÏÎÍÍÏÎÌÏÎÍÌÎÌÌÎÎÏÌ</summary>
    public class NetworkItemSiblingSiblingSibling_712E
    {
        public object f_36F;
        public object f_549;
        public object f_ED6;

        // ── Methods ──
        public void GetLast(){} // RVA: 0x7FFD4E078E90
        public void GetLast_2E028277DD30(){} // RVA: 0x7FFD4E078E90
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void DelegateCall_C398F7A495BD(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void DelegateCall_89252E85F7AD(){} // RVA: 0x7FFD4E079D00
    }

    /// <summary>Originally: ÎÍÌÍÍÌÌÌÍÍÌÏÏÍÍÎÌÎÌÌÏÌÎ</summary>
    public class NetworkItemSiblingSiblingSibling_754B : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F80F750
        public void Equals(){} // RVA: 0x7FFD4F80F930
        public void GetHashCode(){} // RVA: 0x7FFD4F80FB10
        public void CompareBaseObjects_5D59C620C13A(){} // RVA: 0x7FFD4F80FD30 | overloaded x2
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F810680
        public void ToString(){} // RVA: 0x7FFD4F810C90 | overloaded x3
        public void set_name(){} // RVA: 0x7FFD4F810970
        public void ToString_49DBDAEB42DE(){} // RVA: 0x7FFD4F811100
        public void UpdateComponentSiblingProperties(){} // RVA: 0x7FFD4F811970
        public void UpdateComponentSiblingState(){} // RVA: 0x7FFD4F812170
        public void AssignComponentReference(){} // RVA: 0x7FFD4F812930
        public void HandleComponentUpdateEvent(){} // RVA: 0x7FFD4F812B70
        public void CheckAndProcessUserStatus(){} // RVA: 0x7FFD4F812D40
        public void DoIsFriendsWith(){} // RVA: 0x7FFD4F812EE0
        public void CompareSiblingComponents(){} // RVA: 0x7FFD4F813590
        public void ValidateComponentState(){} // RVA: 0x7FFD4F813660
        public void Destroy(){} // RVA: 0x7FFD4F813780
    }

    /// <summary>Originally: ÍÍÏÏÏÎÎÏÎÌÏÎÍÍÎÎÏÍÎÍÏÌÎ</summary>
    public class NetworkItemSiblingSiblingSibling_8ADD : MonoBehaviour
    {
        public UnityEngine.UI.Button _destroyCancellationToken; // 0x20
        public UnityEngine.GameObject _useGUILayout; // 0x28
        public VRC.UI.Core.Styles.StyleElement f_F2F; // 0x30
        public bool ÎÏÎÎÍÌÍÍÌÎÌÎÏÌÏÎÏÍÎÎÌÌÎ; // 0x38
        public ÍÍÏÏÏÎÎÏÎÌÏÎÍÍÎÎÏÍÎÍÏÌÎ[] ÌÎÎÌÌÎÏÎÏÌÎÌÎÌÍÏÌÎÏÍÎÍÏ; // 0x40

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD56D63E80
        public void RaiseCancellation(){} // RVA: 0x7FFD56D63FD0
        public void IsResource(){} // RVA: 0x7FFD4E5F95D0
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void Invoke(){} // RVA: 0x7FFD4E5F95D0
        public void InvokeRepeating(){} // RVA: 0x7FFD4E36F0D0
        public void CancelInvoke(){} // RVA: 0x7FFD56D64230
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4E36F0D0
        public void StartCoroutine(){} // RVA: 0x7FFD56D64560
        public void Initialize_190F072EFE3F(){} // RVA: 0x7FFD4E5F95D0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E36F0C0
        public void StopCoroutine(){} // RVA: 0x7FFD56D64690
    }

    /// <summary>Originally: ÌÍÏÎÎÌÍÌÍÍÌÌÏÌÏÍÍÍÏÎÍÎÌ</summary>
    public class NetworkItemSiblingSiblingSibling_8C0A : MonoBehaviour
    {
        public System.Action _destroyCancellationToken; // 0x20
        public System.Action`1<string> _useGUILayout; // 0x28
        public System.Action`1<string> ÎÎÎÏÍÌÏÍÎÏÎÍÌÎÎÏÏÎÍÌÏÎÍ; // 0x30
        public System.Action ÎÌÎÍÎÏÏÍÏÎÌÎÌÎÏÍÍÌÏÎÍÎÎ; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4FCD5B30
        public void RaiseCancellation(){} // RVA: 0x7FFD4FCD5C20
        public void IsInvoking(){} // RVA: 0x7FFD4FCD5D10
        public void CancelInvoke(){} // RVA: 0x7FFD4FCD5E10
        public void Invoke(){} // RVA: 0x7FFD4FCD5F10
        public void InvokeRepeating(){} // RVA: 0x7FFD4FCD6010
        public void ProcessInputAndCallMethod(){} // RVA: 0x7FFD4FCD6110
        public void IsInvoking_628E592C3BB2(){} // RVA: 0x7FFD4FCD6200
        public void StartCoroutine(){} // RVA: 0x7FFD4E090980
        public void .ctor_939675AF829B(){} // RVA: 0x7FFD4E079D00
        public void Initialize(){} // RVA: 0x7FFD4E091060
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E078E90
        public void StopCoroutine(){} // RVA: 0x7FFD4E090A40
        public void StopCoroutine_0AFA5E00FDCF(){} // RVA: 0x7FFD4E6232C0
        public void UpdateLabelFilterActiveState(){} // RVA: 0x7FFD4E959CE0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EBED440
        public void get_useGUILayout(){} // RVA: 0x7FFD4FCD62F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    /// <summary>Originally: ÏÌÌÎÌÎÍÏÍÏÎÏÌÌÎÍÎÌÌÏÌÌÌ</summary>
    public class NetworkItemSiblingSiblingSibling_90C4 : Object
    {
        public 0x6637D258 _name; // 0x10
        public bool _hideFlags; // 0x12
        public string f_C33; // 0x18
        public ÍÍÎÎÌÏÌÌÏÏÏÌÍÏÎÎÍÎÏÌÍÎÏ ÎÍÌÏÌÎÍÏÌÌÍÍÍÏÍÌÌÎÌÍÎÏÏ; // 0x20
        public ÍÍÎÎÌÏÌÌÏÏÏÌÍÏÎÎÍÎÏÌÍÎÏ ÌÌÍÏÎÏÎÌÍÌÌÎÎÎÌÌÏÍÎÍÌÍÎ; // 0x28
        public long ÍÌÌÏÎÍÍÎÌÍÏÏÎÎÍÏÏÌÎÍÍÍÎ; // 0x30
        public long ÏÌÏÏÎÌÎÏÏÏÎÍÌÏÍÏÎÍÌÌÌÌÌ; // 0x38
        public float ÎÍÍÎÏÏÎÌÏÍÌÌÏÌÍÍÏÌÏÏÍÍÍ; // 0x40
        public System.Nullable`1<float> ÍÎÍÍÎÏÏÌÎÎÎÎÏÏÏÏÍÌÏÌÏÌÌ; // 0x44
        public float ÍÎÎÍÌÎÍÌÌÌÎÍÎÌÌÏÌÌÎÏÏÏÎ; // 0x4C
        public float ÏÎÏÏÏÎÎÍÍÏÌÏÌÍÏÏÌÍÍÍÌÌÏ; // 0x50
        public float ÏÍÌÎÎÌÏÏÌÌÏÏÏÏÌÍÎÎÌÎÌÌÍ; // 0x54
        public float ÏÎÍÎÌÌÌÏÏÍÍÌÌÍÌÏÌÎÎÌÎÍÍ; // 0x58
        public float ÎÎÏÎÎÏÎÏÎÌÎÎÍÍÍÏÏÎÎÎÏÎÎ; // 0x5C
        public float ÎÌÍÎÏÏÍÍÍÏÏÍÌÏÍÍÍÏÌÍÎÍÌ; // 0x60
        public float ÎÏÍÏÏÏÌÏÎÍÏÌÏÏÌÏÏÎÍÏÍÌÎ; // 0x64
        public System.Nullable`1<float> ÌÎÏÏÍÌÌÏÌÌÏÌÌÎÌÏÌÏÍÎÎÏÏ; // 0x68
        public System.Nullable`1<float> ÏÏÍÌÍÌÎÏÏÏÎÏÍÏÎÍÍÏÌÌÌÏÌ; // 0x70

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FABACC0
        public void Equals(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD4FABBB10 | overloaded x2
        public void get_IsContainer(){} // RVA: 0x7FFD4EF01A90
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FABAE40
        public void get_Current(){} // RVA: 0x7FFD4FABAEC0
        public void set_KeysNormalized(){} // RVA: 0x7FFD4F831DE0
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void Instantiate(){} // RVA: 0x7FFD4FABAED0
        public void GetHashCode(){} // RVA: 0x7FFD4FABAF10
        public void ToString_F5A069F61385(){} // RVA: 0x7FFD4FABB9E0 | overloaded x2
        public void GetInterface(){} // RVA: 0x7FFD4E3BCD50
        public void set_hideFlags(){} // RVA: 0x7FFD4E5F95E0
        public void InvokeServiceActionWithBooleanArgument(){} // RVA: 0x7FFD4FABB070
        public void ManageServiceData(){} // RVA: 0x7FFD4E5080B0
        public void GetEvent(){} // RVA: 0x7FFD4FABB0A0
        public void InvokeServiceDelegate(){} // RVA: 0x7FFD4FABB0D0
        public void .ctor_C9663121B3F8(){} // RVA: 0x7FFD4FABB0F0
        public void Destroy(){} // RVA: 0x7FFD4FABB110
        public void GetInstanceID_44A01FBB59B8(){} // RVA: 0x7FFD4FABB6D0
        public void DestroyImmediate(){} // RVA: 0x7FFD4FABB6E0
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void FindObjectsOfType(){} // RVA: 0x7FFD4FABAE40
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4FABBCA0
        public void get_hideFlags(){} // RVA: 0x7FFD4EF01A90
        public void FindObjectsOfType_EE9A1976EA50(){} // RVA: 0x7FFD4FABAE40
        public void RetrieveServiceLongWithIntegerArgument(){} // RVA: 0x7FFD4E451E10
    }

    /// <summary>Originally: ÎÌÏÌÎÌÌÎÏÌÍÍÍÌÍÍÌÌÌÎÌÍÎ</summary>
    public class NetworkItemSiblingSiblingSibling_A5CE : Object
    {
        public Unity.Profiling.ProfilerRecorder ÎÏÏÌÌÎÌÍÎÌÎÍÍÎÌÏÌÏÍÍÎÍÌ; // 0x10
        public ÌÌÌÏÍÎÌÍÌÏÎÍÍÏÍÍÌÌÌÎÍÎÎ ÎÏÍÎÍÎÌÏÎÏÏÏÌÎÍÍÌÏÏÌÌÍÍ; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FA173E0
        public void Equals(){} // RVA: 0x7FFD4FA17450
        public void GetHashCode(){} // RVA: 0x7FFD4FA17490
        public void op_Implicit(){} // RVA: 0x7FFD4FA174B0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FA174E0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FA17520
        public void GetCachedPtr(){} // RVA: 0x7FFD4FA17540
        public void get_name(){} // RVA: 0x7FFD4FA17570
        public void set_name(){} // RVA: 0x7FFD4FA174B0
        public void Instantiate(){} // RVA: 0x7FFD4FA17490
        public void ToString(){} // RVA: 0x7FFD4FA175B0
        public void .ctor(){} // RVA: 0x7FFD4FA17620
        public void Initialize(){} // RVA: 0x7FFD4FA17520
        public void ToString_468641690E2E(){} // RVA: 0x7FFD4FA173E0
        public void ProcessInternalDataAndReturnResult(){} // RVA: 0x7FFD4FA174B0
    }

    /// <summary>Originally: ÎÎÎÎÌÌÌÎÍÎÎÏÍÌÌÎÎÌÍÍÍÌÏ</summary>
    public class NetworkItemSiblingSiblingSibling_B743 : Object
    {
        public System.Collections.Generic.List`1<object> ÎÍÏÍÎÏÌÏÎÌÍÏÍÍÎÌÎÎÎÌÏÎÎ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F355030
        public void Equals(){} // RVA: 0x7FFD4F99B770 | overloaded x5
        public void get_name_AB2F1777055F(){} // RVA: 0x7FFD4F99BBC0 | overloaded x2
        public void set_name(){} // RVA: 0x7FFD4F99BC90
        public void Instantiate(){} // RVA: 0x7FFD4F99C1B0
        public void ToString(){} // RVA: 0x7FFD4F99C450
        public void Equals_513365B2C634(){} // RVA: 0x7FFD4E4D4AD0
        public void .cctor(){} // RVA: 0x7FFD4F99C6D0
    }

    /// <summary>Originally: ÏÏÍÍÌÌÍÏÌÏÏÌÌÍÌÍÎÎÌÌÌÎÍ</summary>
    public class NetworkItemSiblingSiblingSibling_C239 : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E078FF0
        public void Create(){} // RVA: 0x7FFD4E078F80
    }

    /// <summary>Originally: ÏÏÌÏÏÏÎÏÎÌÌÏÍÍÎÎÍÏÏÎÍÎÏ</summary>
    public class NetworkItemSiblingSiblingSibling_C4BF : Object
    {
        public System.Nullable`1<float> _name;
        public System.Collections.Generic.Dictionary`2<string,ÏÌÌÎÌÎÍÏÍÏÎÏÌÌÎÍÎÌÌÏÌÌÌ> _hideFlags; // 0x8

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4FAB4CA0
        public void Equals(){} // RVA: 0x7FFD4FAB4F10
        public void GetHashCode(){} // RVA: 0x7FFD4FAB50B0
        public void op_Implicit(){} // RVA: 0x7FFD4FAB5560
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FAB5790
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FAB59E0
        public void GetCachedPtr(){} // RVA: 0x7FFD4FAB5AB0
        public void set_name_F5A069F61385(){} // RVA: 0x7FFD4FAB61B0 | overloaded x2
        public void ToString_FF740F5E5BF1(){} // RVA: 0x7FFD4FAB68A0 | overloaded x2
        public void Instantiate_DFC623671173(){} // RVA: 0x7FFD4FAB6F80 | overloaded x2
        public void ProcessDateTime_938018A1505E(){} // RVA: 0x7FFD4FAB7530 | overloaded x2
        public void ProcessInputState_A2004B572ACC(){} // RVA: 0x7FFD4FAB7A20 | overloaded x2
        public void DoInternal_FromEu(){} // RVA: 0x7FFD4FAB7E60
        public void SetComponentFlags(){} // RVA: 0x7FFD4FAB8120
        public void Destroy(){} // RVA: 0x7FFD4FAB83D0
        public void HandleDateTimeProcessing(){} // RVA: 0x7FFD4FAB8690
        public void DestroyImmediate(){} // RVA: 0x7FFD4FAB8940
        public void ProcessDateTimeComparison(){} // RVA: 0x7FFD4FAB8BF0
        public void FindObjectsOfType(){} // RVA: 0x7FFD4FAB8ED0
        public void FindObjectsOfType_44A01FBB59B8(){} // RVA: 0x7FFD4FAB9190
        public void FindObjectsByType(){} // RVA: 0x7FFD4FAB9450
        public void FindObjectsByType_4FD083C0972B(){} // RVA: 0x7FFD4FAB9720
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4FAB99F0
        public void get_hideFlags(){} // RVA: 0x7FFD4FAB9CC0
        public void set_hideFlags(){} // RVA: 0x7FFD4FAB9F70
        public void GetQwordBasedOnInputState(){} // RVA: 0x7FFD4FABA770
        public void .cctor(){} // RVA: 0x7FFD4FABABD0
    }

    /// <summary>Originally: ÎÏÍÎÏÏÎÌÌÏÍÎÎÎÎÌÎÌÍÎÍÌÌ</summary>
    public class NetworkItemSiblingSiblingSibling_C8FC : Object
    {
        public System.Collections.Generic.List`1<int> _c8FC;
        public System.Collections.Generic.Dictionary`2<int,T> ÌÏÏÎÏÏÌÌÍÏÍÍÎÎÎÎÍÎÏÌÍÏÎ;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4E092E60
        public void Equals(){} // RVA: 0x7FFD4E092E60
        public void GetHashCode(){} // RVA: 0x7FFD4E092E60
        public void op_Implicit(){} // RVA: 0x7FFD4E079960
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E090980
        public void Initialize_7635B47B3DF7(){} // RVA: 0x7FFD4E07D200 | overloaded x2
        public void GetCachedPtr(){} // RVA: 0x7FFD4E090980
        public void get_name(){} // RVA: 0x7FFD4E090980
        public void set_name(){} // RVA: 0x7FFD4E2ADC40
        public void Instantiate(){} // RVA: 0x7FFD4E092E60
        public void ToString(){} // RVA: 0x7FFD4E090980
        public void GetTextComponentValue(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateOrInitializeComponent(){} // RVA: 0x7FFD4E2ADC40
        public void DoGetIntegerString_495(){} // RVA: 0x7FFD4E092E60
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void IsAlternativeContextInitialized(){} // RVA: 0x7FFD4E092E60
    }

    /// <summary>Originally: ÎÏÏÏÎÌÍÏÎÎÏÏÍÌÏÏÌÍÌÌÌÏÏ</summary>
    public class NetworkItemSiblingSiblingSibling_D04E : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Reflection.MethodInfo,System.Reflection.ParameterInfo[]> ÎÎÌÏÏÎÌÍÍÎÌÎÌÌÌÏÍÌÍÎÌÌÏ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E4D4560
        public void Equals(){} // RVA: 0x7FFD4E4D47E0 | overloaded x4
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E4D4800
        public void GetCachedPtr(){} // RVA: 0x7FFD4E4D4AD0
        public void .cctor(){} // RVA: 0x7FFD4E4D4B10
    }

    /// <summary>Originally: ÍÎÏÎÌÎÌÎÍÏÏÏÌÎÍÍÌÌÏÎÏÎÎ</summary>
    public class NetworkItemSiblingSiblingSibling_D5D4 : Object
    {
        public object _name;
        public object _hideFlags;
        public object f_ED6;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4EB94840
        public void Equals(){} // RVA: 0x7FFD4EB948D0
        public void GetHashCode(){} // RVA: 0x7FFD4EB94960
        public void op_Implicit(){} // RVA: 0x7FFD4EB949F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4EB94A30
        public void get_name_C398F7A495BD(){} // RVA: 0x7FFD4EB94B00 | overloaded x2
        public void set_name(){} // RVA: 0x7FFD4EB94B40
        public void Instantiate(){} // RVA: 0x7FFD4EB94BD0
        public void ToString(){} // RVA: 0x7FFD4EB94C10
        public void UpdateNetworkItem(){} // RVA: 0x7FFD4EB94C50
        public void ProcessNetworkItem(){} // RVA: 0x7FFD4EB94CE0
        public void .cctor(){} // RVA: 0x7FFD4E341320
        public void SyncNetworkItem(){} // RVA: 0x7FFD4EB94D70
    }

    /// <summary>Originally: ÏÎÏÎÌÍÌÏÏÎÏÌÌÍÌÏÏÏÏÌÌÌÍ</summary>
    public class NetworkItemSiblingSiblingSibling_DBD6 : Object
    {
        public System.Random ÍÏÏÏÍÍÎÎÏÍÌÏÍÍÍÍÍÍÌÎÎÍÌ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F355650
        public void GetHashCode_513365B2C634(){} // RVA: 0x7FFD4F355AF0 | overloaded x2
        public void IsNativeObjectAlive_EC1278BD1966(){} // RVA: 0x7FFD4F355EC0 | overloaded x2
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F355C70
        public void GetCachedPtr(){} // RVA: 0x7FFD4F356310
        public void get_name(){} // RVA: 0x7FFD4F3563D0
        public void set_name(){} // RVA: 0x7FFD4F356460
        public void Instantiate(){} // RVA: 0x7FFD4F356900
        public void ToString(){} // RVA: 0x7FFD4F356B30
        public void Create(){} // RVA: 0x7FFD4E078F80
        public void Equals(){} // RVA: 0x7FFD4F356DE0
        public void GetRange(){} // RVA: 0x7FFD4E2ADC40
        public void Awake(){} // RVA: 0x7FFD4F357250
        public void GetConverter(){} // RVA: 0x7FFD4E078F80
        public void Start(){} // RVA: 0x7FFD4F357490
        public void Update(){} // RVA: 0x7FFD4F3574E0
        public void OnDestroy(){} // RVA: 0x7FFD4F357540
        public void Destroy(){} // RVA: 0x7FFD4F3575A0
        public void DestroyImmediate_46A1A52B0D42(){} // RVA: 0x7FFD4F3576F0 | overloaded x2
        public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
        public void .cctor(){} // RVA: 0x7FFD4F3577D0
    }

    /// <summary>Originally: ÍÍÏÎÎÏÍÎÌÎÏÌÍÍÏÌÏÏÌÌÎÌÌ</summary>
    public class NetworkItemSiblingSibling_4E3A : ValueType
    {
        public ÏÏÍÍÎÏÌÎÎÏÎÏÎÌÏÌÏÍÎÎÌÏÏ f_E21; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4ED0F6A0
        public void InternalEquals(){} // RVA: 0x7FFD4ED0F870
        public void DefaultEquals(){} // RVA: 0x7FFD4ED0F890
        public void GetHashCode(){} // RVA: 0x7FFD4ED0F8B0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4ED0F8D0
        public void ToString(){} // RVA: 0x7FFD4ED0F8F0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4ED0F970
        public void get_Current(){} // RVA: 0x7FFD4ED0F990
        public void OnDestroy(){} // RVA: 0x7FFD4ED0FB60
        public void Reset(){} // RVA: 0x7FFD4ED11270
        public void Dispose(){} // RVA: 0x7FFD4ED112B0
        public void InternalGetHashCode_2E028FAA97BD(){} // RVA: 0x7FFD4ED0F8D0
        public void Clone(){} // RVA: 0x7FFD4ED112D0
        public void GetEnumerator(){} // RVA: 0x7FFD4ED112F0
        public void CompareTo(){} // RVA: 0x7FFD4ED11370
        public void SetValue(){} // RVA: 0x7FFD4ED11270
        public void GetValue(){} // RVA: 0x7FFD4ED113A0
        public void CreateItem(){} // RVA: 0x7FFD4ED113C0
        public void UpdateItem(){} // RVA: 0x7FFD4ED113E0
        public void DestroyItem(){} // RVA: 0x7FFD4ED11400
        public void MoveNext(){} // RVA: 0x7FFD4ED11420
        public void GetHashCodeOfPtr_A5A12EB8EAB9(){} // RVA: 0x7FFD4ED0F970
        public void ProcessItem(){} // RVA: 0x7FFD4ED11440
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void Initialize(){} // RVA: 0x7FFD4ED11460
        public void Initialize_E14EE631AFD9(){} // RVA: 0x7FFD4ED11460
        public void ValidateItem(){} // RVA: 0x7FFD4ED11480
        public void CopyTo(){} // RVA: 0x7FFD4ED114A0
        public void CompareItems(){} // RVA: 0x7FFD4ED114C0
    }

    /// <summary>Originally: ÏÍÍÏÌÌÍÎÏÍÏÏÏÏÍÎÏÌÏÏÍÌÌ</summary>
    public class NetworkItemSiblingSibling_5241 : ValueType
    {
        public string ÌÍÏÏÍÏÍÏÎÎÏÍÌÎÏÏÍÎÎÏÏÍÍ; // 0x10
        public VRC.Localization.LocalizableString ÏÎÌÏÌÍÌÌÏÍÌÌÎÎÎÌÏÎÎÍÍÍÏ; // 0x18
        public ÎÍÏÏÏÏÍÍÏÍÎÏÏÌÏÏÎÌÏÍÏÎÍ<System.Collections.Generic.IList`1<ÎÎÏÍÏÌÏÌÎÎÏÎÎÍÍÎÎÎÍÏÍÍÏ>> ÎÍÏÏÏÍÌÍÌÌÌÎÍÏÍÍÍÏÍÍÏÍÌ; // 0x40
        public ÍÌÏÍÏÍÎÍÍÌÏÌÏÍÎÏÍÎÏÌÎÎÌ<ÎÎÏÍÏÌÏÌÎÎÏÎÎÍÍÎÎÎÍÏÍÍÏ> ÎÎÎÎÌÍÏÍÎÎÌÍÍÌÎÍÍÍÌÏÎÎÍ; // 0x48
        public int ÍÌÌÍÎÏÎÍÌÏÌÏÏÎÏÏÏÏÍÍÍÎÌ; // 0x50

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD56A7F9E0
        public void InternalEquals(){} // RVA: 0x7FFD56A7FB10
        public void GetHashCode(){} // RVA: 0x7FFD56A7FB60
        public void GetHashCode_9D8101715583(){} // RVA: 0x7FFD56A7FD40
        public void Equals(){} // RVA: 0x7FFD56A80030 | overloaded x2
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD56A800F0
        public void HandleSecondPointerOffsetIntCtor(){} // RVA: 0x7FFD56A80300
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD56A7FB10
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD56A80380
        public void .ctor(){} // RVA: 0x7FFD56A80590
        public void HandlePointerHover(){} // RVA: 0x7FFD56A80800
    }

    /// <summary>Originally: ÌÏÌÏÍÍÌÏÍÌÏÌÌÎÎÏÌÏÍÍÍÎÎ</summary>
    public class NetworkItemSiblingSibling_6734
    {
        // ── Methods ──
        public void CopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo_75BB91A2055C(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo_E862ED212F7E(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo_13A6D5541BE0(){} // RVA: 0x7FFD4E2ADC40
        public void GetItem(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÏÍÎÏÍÌÍÍÎÏÎÎÎÏÎÏÌÏÍÍÏÎÍ</summary>
    public class NetworkItemSiblingSibling_A471 : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> _name;
        public string _hideFlags; // 0x10
        public string f_EBE; // 0x18
        public string[] f_FC8; // 0x20
        public System.Collections.Generic.Dictionary`2<string,string> ÌÎÏÌÌÏÌÎÌÎÏÎÌÎÏÍÏÎÎÍÌÎÏ; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD566537D0
        public void GetHashCode(){} // RVA: 0x7FFD5405A320
        public void GetHashCode_ADF4ABEFDDA0(){} // RVA: 0x7FFD4E36F130
        public void op_Implicit(){} // RVA: 0x7FFD56653820
        public void CompareBaseObjects(){} // RVA: 0x7FFD56653890
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD56653820
        public void .ctor(){} // RVA: 0x7FFD566538F0
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void set_name(){} // RVA: 0x7FFD56654360
        public void Instantiate(){} // RVA: 0x7FFD4E36F0C0
        public void DoSetValue(){} // RVA: 0x7FFD4E36F130
        public void Instantiate_E0932B1B869E(){} // RVA: 0x7FFD4E3447C0
        public void Instantiate_0ECC0A862302(){} // RVA: 0x7FFD56653820
        public void DoSetValue_9B9982CA4FDF(){} // RVA: 0x7FFD4E3447C0
        public void DoSetValue_FCCB81438CFE(){} // RVA: 0x7FFD4E3447C0
        public void .cctor(){} // RVA: 0x7FFD566543C0
        public void ToString(){} // RVA: 0x7FFD4E35C380
        public void ProcessEventFilter(){} // RVA: 0x7FFD4E35C380
        public void InitializeEventFilterState(){} // RVA: 0x7FFD4E3A7E80
        public void Equals(){} // RVA: 0x7FFD566544A0
        public void Destroy(){} // RVA: 0x7FFD4E36F130
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void DestroyImmediate(){} // RVA: 0x7FFD4E36F0C0
        public void Initialize(){} // RVA: 0x7FFD4E342E30
    }

    /// <summary>Originally: ÎÏÏÍÍÌÍÍÏÏÎÏÎÎÌÎÌÎÍÏÏÏÏ</summary>
    public class NetworkItemSiblingSibling_C2BF : ValueType
    {
        public ÏÏÍÍÎÏÌÎÎÏÎÏÎÌÏÌÏÍÎÎÌÏÏ f_BED; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4ECF9890
        public void InternalEquals(){} // RVA: 0x7FFD4ECFC970
        public void DefaultEquals(){} // RVA: 0x7FFD4ECFC990
        public void GetHashCode(){} // RVA: 0x7FFD4ECFC9B0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4ECFC9D0
        public void ToString(){} // RVA: 0x7FFD4ECFC9F0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4ECFCA30
        public void CreateNetworkItem(){} // RVA: 0x7FFD4ECFCA50
        public void UpdateNetworkItem(){} // RVA: 0x7FFD4ECFCA70
        public void DestroyNetworkItem(){} // RVA: 0x7FFD4ECFCA70
        public void GetEngineStatus(){} // RVA: 0x7FFD4ECFCA90
        public void FindObjectsOfType(){} // RVA: 0x7FFD4ECFCAB0
        public void GetInstanceID(){} // RVA: 0x7FFD4ECFFB90
        public void set_name(){} // RVA: 0x7FFD4ECFFD60
        public void Equals_4F5991E81F5C(){} // RVA: 0x7FFD4ECFFD80
        public void set_Singleton(){} // RVA: 0x7FFD4ECFFDA0
        public void set_Singleton_0195D0BD03A9(){} // RVA: 0x7FFD4ECFFDC0
        public void set_Singleton_B93903AF59B3(){} // RVA: 0x7FFD4ECFFDE0
        public void Initialize(){} // RVA: 0x7FFD4ECFFE00
        public void Equals_1CCC4BF2FDB7(){} // RVA: 0x7FFD4ECFFE20
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void set_Singleton_34DD7595D000(){} // RVA: 0x7FFD4ECFFEA0
        public void OnCollisionStay(){} // RVA: 0x7FFD4ECFFEC0
        public void set_Singleton_F11522590C97(){} // RVA: 0x7FFD4ECFFEF0
        public void set_Singleton_48DCAFDC80F7(){} // RVA: 0x7FFD4ECFFF10
        public void CreateNetworkItem_DC0D5B268080(){} // RVA: 0x7FFD4ECFCA50
        public void GetTransform_DEB(){} // RVA: 0x7FFD4ED02210
        public void DispatchRequest(){} // RVA: 0x7FFD4ED023E0
        public void set_name_5A69A30A4769(){} // RVA: 0x7FFD4ECFFD60
        public void Equals_734499302A06(){} // RVA: 0x7FFD4ECFFE20
        public void SendRequest(){} // RVA: 0x7FFD4ED02400
        public void InitializeCachedMethods(){} // RVA: 0x7FFD4ED02420
        public void InitializeCachedMethods_1379F13F17AA(){} // RVA: 0x7FFD4ED02440
        public void ReceiveRequest(){} // RVA: 0x7FFD4ED024C0
        public void BuildValuePayload(){} // RVA: 0x7FFD4ED024E0
        public void set_Singleton_0CDAB42F0F52(){} // RVA: 0x7FFD4ECFFDE0
        public void BuildValuePayload_88F6D7BE86E6(){} // RVA: 0x7FFD4ED02500
        public void BuildValuePayload_45751F28AADA(){} // RVA: 0x7FFD4ED02520
        public void CreateManagedObject(){} // RVA: 0x7FFD4ED025A0
    }

    /// <summary>Originally: ÏÍÌÌÌÍÍÏÍÏÏÍÎÌÎÌÏÎÏÌÍÎÍ</summary>
    public class NetworkItemSiblingSibling_D57F : ValueType
    {
        public ÌÌÌÏÍÎÌÍÌÏÎÍÍÏÍÍÌÌÌÎÍÎÎ ÎÏÍÎÍÎÌÏÎÏÏÏÌÎÍÍÌÏÏÌÌÍÍ; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4FA81800
        public void InternalEquals(){} // RVA: 0x7FFD4FA81830
        public void DefaultEquals(){} // RVA: 0x7FFD4FA81850
        public void GetHashCode(){} // RVA: 0x7FFD4FA81880
        public void InternalGetHashCode(){} // RVA: 0x7FFD4FA818B0
        public void ToString(){} // RVA: 0x7FFD4FA818E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4FA818B0
        public void ToString_729052684FC4(){} // RVA: 0x7FFD4FA818E0
        public void ToString_6F6E51AEF7B0(){} // RVA: 0x7FFD4FA818E0
        public void ToString_087ECB259306(){} // RVA: 0x7FFD4FA81830
        public void GetInstanceID(){} // RVA: 0x7FFD4FA81800
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void Initialize(){} // RVA: 0x7FFD4FA81850
    }

    /// <summary>Originally: ÍÏÌÎÌÎÏÏÍÏÌÌÎÌÍÏÎÎÍÌÌÌÏ</summary>
    public class NetworkItemSiblingSibling_F6EF : ValueType
    {
        public ÌÌÌÏÍÎÌÍÌÏÎÍÍÏÍÍÌÌÌÎÍÎÎ ÎÏÍÎÍÎÌÏÎÏÏÏÌÎÍÍÌÏÏÌÌÍÍ; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4FA81900
        public void InternalEquals(){} // RVA: 0x7FFD4FA818B0
        public void DefaultEquals(){} // RVA: 0x7FFD4FA81920
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void Initialize(){} // RVA: 0x7FFD4FA81830
        public void GetHashCode(){} // RVA: 0x7FFD4FA81900
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4FA81940
        public void ToString(){} // RVA: 0x7FFD4FA81830
        public void .ctor_B9E1DD8611CF(){} // RVA: 0x7FFD4FA81940
        public void HasValue(){} // RVA: 0x7FFD4FA81830
        public void ToString_2F2B3E0EC6AE(){} // RVA: 0x7FFD4FA81830
    }

    /// <summary>Originally: ÌÌÎÍÎÍÌÏÌÍÏÏÏÏÏÌÍÏÏÎÎÏÍ</summary>
    public class NetworkItemSibling_0C0E : Object
    {
        public string _name;
        public string _hideFlags;
        public System.Nullable`1<bool> ÌÎÎÌÍÌÎÎÍÎÌÎÍÌÏÍÏÎÏÏÌÏÍ; // 0x10
        public string <ÏÍÌÎÍÌÎÎÌÎÎÏÌÏÏÍÍÎÏÌÏÎÌ>k__BackingField; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E3447C0
        public void Equals(){} // RVA: 0x7FFD4FCBA870
        public void GetHashCode(){} // RVA: 0x7FFD4FCBA880
        public void set_name_D45A011958AB(){} // RVA: 0x7FFD4FCBAE90 | overloaded x2
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FCBA9A0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E3447C0
        public void GetCachedPtr(){} // RVA: 0x7FFD4FCBAAA0
        public void get_name(){} // RVA: 0x7FFD4FCBAD90
        public void Instantiate(){} // RVA: 0x7FFD4FCBA870
        public void ToString(){} // RVA: 0x7FFD4FCBAFA0
        public void GetHashCode_87214D0CDB49(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD4FCBB2C0
    }

    /// <summary>Originally: ÌÌÌÎÌÌÎÏÏÏÌÍÎÌÏÌÌÌÎÌÍÎÎ</summary>
    public class NetworkItemSibling_33D1 : ValueType
    {
        public ÏÏÍÍÎÏÌÎÎÏÎÏÎÌÏÌÏÍÎÎÌÏÏ f_524; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4ED09310
        public void InternalEquals(){} // RVA: 0x7FFD4ED09330
        public void DefaultEquals(){} // RVA: 0x7FFD4ED09350
        public void GetHashCode(){} // RVA: 0x7FFD4ED09380
        public void InternalGetHashCode(){} // RVA: 0x7FFD4ED093A0
        public void ToString(){} // RVA: 0x7FFD4ED093C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4ED093E0
        public void ComputeShaderPropertyId(){} // RVA: 0x7FFD4ED09400
        public void FetchShaderPropertyId(){} // RVA: 0x7FFD4ED09420
        public void BuildShaderPropertyId(){} // RVA: 0x7FFD4ED095F0
        public void ReadShaderPropertyId(){} // RVA: 0x7FFD4ED09610
        public void Awake(){} // RVA: 0x7FFD4ED09650
        public void CacheShaderPropertyId(){} // RVA: 0x7FFD4ED09670
        public void CheckExitStationProximityStatus(){} // RVA: 0x7FFD4ED09690
        public void Update(){} // RVA: 0x7FFD4ED0B030
        public void ResolveShaderPropertyId(){} // RVA: 0x7FFD4ED09610
        public void Equals_C3BD04AAFA92(){} // RVA: 0x7FFD4ED09310
        public void GetHashCodeOfPtr_589FA6224BC5(){} // RVA: 0x7FFD4ED093E0
        public void LateUpdate(){} // RVA: 0x7FFD4ED0B050
        public void OnEnable(){} // RVA: 0x7FFD4ED0B0D0
        public void OnDisable(){} // RVA: 0x7FFD4ED0B0F0
        public void MapShaderPropertyId(){} // RVA: 0x7FFD4ED09400
        public void Start(){} // RVA: 0x7FFD4ED0B110
        public void FixedUpdate(){} // RVA: 0x7FFD4ED0B130
        public void InternalEquals_CBA7636C4DB2(){} // RVA: 0x7FFD4ED09330
        public void get_isPlaying(){} // RVA: 0x7FFD4ED0DC00
        public void InternalGetHashCode_010E85F06392(){} // RVA: 0x7FFD4ED093A0
        public void InitializeShaderStatics(){} // RVA: 0x7FFD4ED0F5A0
        public void InitializeGlobals(){} // RVA: 0x7FFD4ED0F620
        public void OnDestroy(){} // RVA: 0x7FFD4ED0B030
        public void ProcessNetworkItem(){} // RVA: 0x7FFD4ED0F640
        public void UpdateNetworkItem(){} // RVA: 0x7FFD4ED0F660
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void Initialize(){} // RVA: 0x7FFD4ED0F680
    }

    /// <summary>Originally: ÍÌÎÍÌÌÎÌÏÏÍÌÍÎÎÎÍÏÍÌÏÍÎ</summary>
    public class NetworkItemSibling_50DD : Object
    {
        public string _name;
        public ÍÌÎÍÌÌÎÌÏÏÍÌÍÎÎÎÍÏÍÌÏÍÎ _hideFlags;
        public string f_53C; // 0x10
        public VRC.Localization.LocalizableString <ÌÎÏÏÍÍÌÍÎÎÎÏÌÌÌÍÍÌÍÍÌÎÌ>k__BackingField; // 0x18
        public System.TimeZoneInfo <ÌÍÎÎÏÏÍÌÌÎÍÏÌÏÏÏÏÌÍÍÌÌÏ>k__BackingField; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FCCEEF0 | overloaded x3
        public void Initialize(){} // RVA: 0x7FFD4FCCEB50
        public void Equals(){} // RVA: 0x7FFD4E35C380
        public void get_Current(){} // RVA: 0x7FFD4ED4AAD0
        public void .cctor(){} // RVA: 0x7FFD4FCCEB70
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4FCCEB50
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void get_name(){} // RVA: 0x7FFD4E3BE740
        public void Instantiate(){} // RVA: 0x7FFD4FCCEB50
        public void GetHashCode(){} // RVA: 0x7FFD4E35C380
        public void ToString(){} // RVA: 0x7FFD4E35C380
    }

    /// <summary>Originally: ÎÌÍÌÏÌÏÌÍÎÏÎÏÎÎÌÌÍÍÏÏÎÍ</summary>
    public class NetworkItemSibling_7524 : ValueType
    {
        public ÏÌÍÍÏÌÍÎÏÍÏÍÌÎÎÍÎÌÌÍÎÌÍ _7524; // 0x10
        public UnityEngine.Vector4 ÎÎÍÎÏÌÍÎÎÏÍÌÎÎÎÎÎÌÌÏÏÏÌ; // 0x20
        public float ÎÌÎÌÌÏÌÌÍÍÌÎÎÍÌÌÌÏÎÌÍÍÏ; // 0x30
        public float ÍÍÌÏÍÏÏÎÏÍÌÎÎÎÌÎÎÏÏÏÌÌÎ; // 0x34

        // ── Methods ──
        public void set_normalColor(){} // RVA: 0x7FFD4F92BA60
        public void FromColorf(){} // RVA: 0x7FFD4F92BA70
        public void DefaultEquals(){} // RVA: 0x7FFD4F92BA60
        public void Equals(){} // RVA: 0x7FFD4F92BA60
        public void .ctor(){} // RVA: 0x7FFD4F92BA90
        public void Initialize(){} // RVA: 0x7FFD4F92BB30
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F92BA60
        public void op_Implicit(){} // RVA: 0x7FFD4E6E0590
        public void .ctor_1186B409473D(){} // RVA: 0x7FFD4F92BE80
        public void Initialize_D45A011958AB(){} // RVA: 0x7FFD4E6E0590
        public void AssignVector3(){} // RVA: 0x7FFD4F92BA70
    }

    /// <summary>Originally: ÏÏÏÌÎÏÎÌÍÏÎÏÍÏÍÎÏÎÌÎÌÏÌ</summary>
    public class NetworkItemSibling_8AC1 : Object
    {
        public object _8AC1; // 0x10
        public int ÌÌÍÌÍÌÍÌÏÎÌÌÏÍÍÌÎÎÌÌÍÌÎ; // 0x18

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4EDC5B80
        public void Equals(){} // RVA: 0x7FFD4EDC5BE0
        public void ToString_9FF7E415362B(){} // RVA: 0x7FFD4EDC6050 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD4EDC5C40
        public void GetCachedPtr_1830D2CBAF23(){} // RVA: 0x7FFD4EDC5E40 | overloaded x2
        public void IsNativeObjectAlive_70283CA1CEAF(){} // RVA: 0x7FFD4EDC6450 | overloaded x2
        public void get_name(){} // RVA: 0x7FFD4EDC5F50
        public void set_name(){} // RVA: 0x7FFD4EDC5FB0
        public void Instantiate(){} // RVA: 0x7FFD4EDC5FB0
        public void Dispose(){} // RVA: 0x7FFD4EDC5C40
        public void Cleanup(){} // RVA: 0x7FFD4EDC6130
        public void .ctor(){} // RVA: 0x7FFD4EDC64F0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD4EDC6340
        public void GetHashCode(){} // RVA: 0x7FFD4EDC5B80
        public void Clone_7546FB2737D7(){} // RVA: 0x7FFD4EDC64E0 | overloaded x2
        public void Destroy(){} // RVA: 0x7FFD4EDC65F0
    }

    /// <summary>Originally: ÎÏÍÏÌÍÍÏÌÍÍÌÎÌÌÌÌÎÌÍÏÎÏ</summary>
    public class NetworkItemSibling_F266 : ValueType
    {
        public UnityEngine.Animations.AnimatorControllerPlayable ÏÏÏÎÏÌÍÎÏÏÌÏÎÍÍÏÎÍÏÌÎÎÍ; // 0x10
        public UnityEngine.Playables.PlayableHandle ÏÌÌÎÍÍÍÎÎÎÏÎÌÏÌÏÍÏÏÏÏÏÏ; // 0x20

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD4E6E0400
        public void InternalEquals(){} // RVA: 0x7FFD4E6E0450
        public void GetHashCodeOfPtr_D45A011958AB(){} // RVA: 0x7FFD4E6E0590 | overloaded x2
        public void __Rotate__UnityEngineVector3__SystemVoid(){} // RVA: 0x7FFD4E6E04F0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E6E0450
        public void RotateVector(){} // RVA: 0x7FFD4E6E0540
        public void GetPtrHashCode(){} // RVA: 0x7FFD4E6E0480
        public void op_Implicit(){} // RVA: 0x7FFD4E6E0590
        public void Equals(){} // RVA: 0x7FFD4E6E0610 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD4E6E06E0
        public void Initialize_9D8101715583(){} // RVA: 0x7FFD4E6E06E0
        public void .ctor(){} // RVA: 0x7FFD4E6E0710
        public void Initialize_849AD057DFE4(){} // RVA: 0x7FFD4E6E06E0
        public void GetHashCode(){} // RVA: 0x7FFD4E6E0770
    }

    /// <summary>Originally: ÌÌÌÏÍÎÌÍÌÏÎÍÍÏÍÍÌÌÌÎÍÎÎ</summary>
    public class NetworkItemSibling_FEF9 : Object
    {
        public ulong ÌÎÍÌÏÌÎÎÎÎÍÎÌÌÌÎÍÏÍÎÍÍÏ; // 0x10
        public float ÍÌÎÌÎÎÏÏÍÌÎÍÌÏÏÍÎÌÌÍÌÍÎ; // 0x18
        public float ÏÎÏÏÏÎÎÍÍÏÌÏÌÍÏÏÌÍÍÍÌÌÏ; // 0x1C
        public float ÍÎÍÎÍÏÍÌÎÌÍÌÏÍÌÍÍÌÍÍÍÎÏ; // 0x20
        public float ÌÎÏÏÍÌÌÏÌÌÏÌÌÎÌÏÌÏÍÎÎÏÏ; // 0x24
        public float ÏÏÍÌÍÌÎÏÏÏÎÏÍÏÎÍÍÏÌÌÌÏÌ; // 0x28
        public float ÎÎÌÏÏÎÏÌÏÏÍÏÌÎÍÍÏÌÏÎÎÎÎ; // 0x2C
        public float ÎÎÌÎÏÎÍÍÌÌÎÌÎÌÍÏÍÏÏÍÌÍÍ; // 0x30
        public float ÎÌÌÏÎÏÏÌÍÌÎÎÌÎÎÍÎÍÍÏÍÌÏ; // 0x34
        public float ÎÍÌÍÍÌÍÌÌÍÍÌÎÏÎÌÏÍÎÎÎÍÎ; // 0x38
        public float ÏÍÏÎÌÎÏÌÍÌÌÌÎÏÌÌÍÏÌÎÏÍÎ; // 0x3C
        public float ÌÍÏÏÍÎÍÏÏÎÌÍÎÎÏÌÎÎÏÍÍÎÎ; // 0x40
        public float ÎÌÍÎÍÎÌÍÍÎÎÍÏÏÍÏÎÏÌÌÌÍÍ; // 0x44
        public float ÌÌÌÎÎÍÎÎÍÏÎÏÎÍÎÎÎÏÏÎÎÍÍ; // 0x48
        public float ÍÏÏÍÎÌÌÎÌÎÎÌÌÏÏÌÏÎÏÎÍÏÏ; // 0x4C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FA812F0 | overloaded x4
        public void get_scale(){} // RVA: 0x7FFD4E80AB80
        public void GetMaxDampTime(){} // RVA: 0x7FFD4E420210
        public void op_Implicit(){} // RVA: 0x7FFD4E35C380
        public void CompareBaseObjects(){} // RVA: 0x7FFD4FA80EE0
        public void get_currentScale(){} // RVA: 0x7FFD4EB55280
        public void get_AreaX(){} // RVA: 0x7FFD4F9E0DE0
        public void get_name(){} // RVA: 0x7FFD4FA80F30
        public void set_name(){} // RVA: 0x7FFD4FA80F80
        public void Instantiate(){} // RVA: 0x7FFD4FA81000
        public void get_defaultDeadzoneMax(){} // RVA: 0x7FFD4E349970
        public void get_preferredPeakBitRate(){} // RVA: 0x7FFD4E5080B0
        public void Equals(){} // RVA: 0x7FFD4FA81050
        public void GetHashCode(){} // RVA: 0x7FFD4F9E0DE0
        public void ToString(){} // RVA: 0x7FFD4FA81070
        public void Initialize(){} // RVA: 0x7FFD4FA81130
        public void Update_D45A011958AB(){} // RVA: 0x7FFD4FA81200 | overloaded x2
        public void GetMaxHealth(){} // RVA: 0x7FFD4E36A080
        public void Destroy(){} // RVA: 0x7FFD4FA811E0
        public void DestroyImmediate(){} // RVA: 0x7FFD4E80AB80
        public void SetActive_E90(){} // RVA: 0x7FFD4FA81220
        public void FindObjectsOfType(){} // RVA: 0x7FFD4FA812B0
        public void FindObjectsByType(){} // RVA: 0x7FFD4FA81300
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4FA81530
        public void get_hideFlags(){} // RVA: 0x7FFD4FA81550
        public void set_hideFlags(){} // RVA: 0x7FFD4FA815A0
        public void InitializeStaticResources(){} // RVA: 0x7FFD4FA815C0
        public void GetCurrentHealth(){} // RVA: 0x7FFD4E4AEF50
    }

    /// <summary>Originally: ÎÍÎÎÍÏÎÌÌÏÎÏÌÏÍÌÎÎÏÍÌÏÏ</summary>
    public class NetworkReadyHandlerImplSibling_5AC4
    {
        public object f_83C;
        public object f_392;
        public object f_45B;
        public object f_DD3;

        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFD4E078E90
        public void Process(){} // RVA: 0x7FFD4E078E90
        public void OnReceive(){} // RVA: 0x7FFD4E078E90
        public void OnEvent(){} // RVA: 0x7FFD4E078E90
    }

    /// <summary>Originally: ÏÏÏÏÌÌÏÍÎÏÎÌÌÏÎÎÏÌÎÍÏÍÎ</summary>
    public class NetworkReadyHandlerImpl_C904 : NetworkReadyHandler_68D0
    {
        public float f_3DB;
        public int f_C05;
        public float f_93E; // 0x58
        public bool f_AAB; // 0x5C
        public ÌÌÎÎÌÍÍÎÌÌÎÌÍÍÏÏÍÍÎÏÌÎÎ f_617; // 0x60
        public ÍÏÍÍÌÍÍÍÍÍÌÎÎÏÎÌÎÍÌÍÏÍÏ f_5AB; // 0x68
        public System.Collections.Generic.List`1<ÌÏÏÏÍÏÎÌÍÎÏÏÍÏÎÎÍÍÎÏÌÍÎ> f_ABC; // 0x70
        public System.Collections.Generic.Dictionary`2<0x665B17A0,VRC.Profiling.ProfilerMarker> f_8D0;
        public ÏÏÏÏÌÌÏÍÎÏÎÌÌÏÎÎÏÌÎÍÏÍÎ ÍÎÍÏÍÎÍÏÍÌÌÎÏÍÍÌÎÌÏÌÍÌÏ; // 0x8
        public VRC.Profiling.ProfilerMarker ÍÌÍÍÏÍÍÌÌÏÌÌÎÌÌÏÌÌÌÎÎÌÍ; // 0x78
        public VRC.Profiling.ProfilerMarker ÌÍÌÌÎÏÎÎÎÏÎÎÌÌÌÍÏÎÎÌÌÎÎ; // 0x88

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFD4F263370
        public void set_ValidExpressions(){} // RVA: 0x7FFD4F263AE0
        public void GetLanguage(){} // RVA: 0x7FFD4F263D10
        public void AddSubtraction(){} // RVA: 0x7FFD4F263F70
        public void OnDestroy(){} // RVA: 0x7FFD4F264240
        public void OnDestroy_1FC3C0D69973(){} // RVA: 0x7FFD4F264480
        public void .cctor(){} // RVA: 0x7FFD4F2644D0
        public void GetHashCode(){} // RVA: 0x7FFD4F2646C0
        public void Start(){} // RVA: 0x7FFD4F264870
        public void GetTypeCode(){} // RVA: 0x7FFD4F2654F0
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F265500
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F265560
        public void OnNetworkReady(){} // RVA: 0x7FFD4F265570
        public void ProcessSystemInputWithFlags(){} // RVA: 0x7FFD4F265720
        public void StartCoroutine(){} // RVA: 0x7FFD4F265770
        public void BeginProfilingSample(){} // RVA: 0x7FFD4F265810
        public void GetBufferedTimes(){} // RVA: 0x7FFD4F265C80
        public void SetOverlay(){} // RVA: 0x7FFD4F265CD0
        public void print(){} // RVA: 0x7FFD4F265F00
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F265F50
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F265FC0
        public void Awake(){} // RVA: 0x7FFD4F266550
        public void .ctor(){} // RVA: 0x7FFD4F266820
        public void Initialize(){} // RVA: 0x7FFD4F266A80
        public void get_alreadySelecting(){} // RVA: 0x7FFD4F266A90
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFD4E341320
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F266EC0
        public void GetIKSolver(){} // RVA: 0x7FFD4F267930
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFD4F267980
        public void HandleNetworkReady(){} // RVA: 0x7FFD4F2679F0
        public void GetTransformPose(){} // RVA: 0x7FFD4F267E60
        public void DoFormatInt32(){} // RVA: 0x7FFD4F2683F0
        public void Reset(){} // RVA: 0x7FFD4F268D50
        public void ConfigureTransform(){} // RVA: 0x7FFD4F269260
    }

    /// <summary>Originally: ÍÎÍÎÍÍÍÎÍÌÏÍÎÎÌÏÏÍÌÏÎÎÏ</summary>
    public class NetworkReadyHandler_1A42 : WorldProximityExitStation_FE46
    {
        // ── Methods ──
        public void __Clone__SystemObject(){} // RVA: 0x7FFD4F5C3520
        public void get_name(){} // RVA: 0x7FFD4F5C4B20
        public void .ctor(){} // RVA: 0x7FFD4F5C6140
        public void Initialize(){} // RVA: 0x7FFD4F5C6190
        public void HandleNetworkReady(){} // RVA: 0x7FFD4F5C65F0
        public void OnNetworkReady(){} // RVA: 0x7FFD4F5C6A70
        public void ProvideEvents(){} // RVA: 0x7FFD4F5C6A90
        public void DoSetOnlineMode(){} // RVA: 0x7FFD4F5C6EF0
        public void Start(){} // RVA: 0x7FFD4F5C84E0
    }

    /// <summary>Originally: ÌÎÌÍÎÌÌÍÏÏÍÍÍÎÍÌÍÎÎÎÍÏÎ</summary>
    public class NetworkReadyHandler_202B : MonoBehaviour
    {
        public System.Collections.Generic.List`1<string> _destroyCancellationToken; // 0x20
        public System.Collections.Generic.HashSet`1<VRC.SDKBase.VRC_Trigger> _useGUILayout;
        public VRC.SDKBase.VRC_Trigger f_8D0; // 0x28
        public VRC.SDKBase.VRC_DataStorage f_03E; // 0x30
        public UnityEngine.Collider f_648; // 0x38
        public bool hasTimerTriggers; // 0x40
        public bool hasColliderTriggers; // 0x41
        public bool hasKeyTriggers; // 0x42
        public bool ÍÍÌÏÍÏÏÎÌÏÍÍÎÎÌÏÌÎÎÎÍÏÏ; // 0x43
        public System.Collections.Generic.List`1<UnityEngine.MonoBehaviour> ÌÎÍÌÏÍÍÏÎÌÌÏÌÌÌÎÏÎÍÎÎÌÏ; // 0x48
        public int ÏÏÌÎÌÌÏÏÏÎÎÌÎÏÎÏÏÍÍÍÎÎÍ; // 0x50
        public bool ÍÌÍÍÌÍÏÌÏÌÌÍÎÏÍÏÎÌÎÍÏÏÏ; // 0x54
        public System.Collections.Generic.HashSet`1<ÏÏÎÌÌÍÍÍÌÌÌÏÏÌÌÌÏÍÌÌÏÏÌ> ÏÎÏÌÍÎÌÎÍÏÏÌÏÎÌÎÍÌÌÏÏÍÌ; // 0x58
        public VRC.SDKBase.VRC_EventHandler ÎÌÌÌÏÎÎÎÍÍÎÎÍÌÎÏÌÍÎÏÏÌÍ; // 0x60
        public System.Collections.Generic.List`1<TriggerEvent> ÎÏÎÌÌÍÎÍÍÎÌÎÌÍÌÏÏÎÌÎÍÌÍ; // 0x68

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F62A190
        public void RaiseCancellation(){} // RVA: 0x7FFD4F62A620
        public void IsInvoking(){} // RVA: 0x7FFD4F62A640
        public void CancelInvoke(){} // RVA: 0x7FFD4F62A780
        public void OnEnable(){} // RVA: 0x7FFD4F62A9A0
        public void InvokeRepeating(){} // RVA: 0x7FFD4F62AB30
        public void Awake(){} // RVA: 0x7FFD4F62AD90
        public void Update(){} // RVA: 0x7FFD4F62B350
        public void StartCoroutine(){} // RVA: 0x7FFD4F62B380
        public void FixedUpdate(){} // RVA: 0x7FFD4F62B3B0
        public void StartCoroutine_DFA5D4C1065F(){} // RVA: 0x7FFD4F62B830
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F62B9F0
        public void StopCoroutine(){} // RVA: 0x7FFD4F62BA20
        public void OnBecameVisible(){} // RVA: 0x7FFD4F62C100
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F62C7F0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F62C8F0
        public void .cctor(){} // RVA: 0x7FFD4F62CA30
        public void set_useGUILayout(){} // RVA: 0x7FFD4F62CB10
        public void print(){} // RVA: 0x7FFD4F62CF40
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F62D100
        public void OnDestroy(){} // RVA: 0x7FFD4F62D2E0
        public void Start(){} // RVA: 0x7FFD4F62DB20
        public void OnDisable(){} // RVA: 0x7FFD4F62F5A0
        public void .ctor(){} // RVA: 0x7FFD4F62F730
        public void Initialize(){} // RVA: 0x7FFD4F62FA60
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F62FC40
        public void OnNetworkReady(){} // RVA: 0x7FFD4F62FC70
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4F62FF80
        public void OnSpawn(){} // RVA: 0x7FFD4F62FFE0
        public void GetScriptClassName(){} // RVA: 0x7FFD4F62A620
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F630010
        public void OnCollisionEnter(){} // RVA: 0x7FFD4F6304D0
        public void OnCollisionStay(){} // RVA: 0x7FFD4F631220
        public void OnCollisionExit(){} // RVA: 0x7FFD4F6313B0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F631400
        public void OnTriggerStay(){} // RVA: 0x7FFD4F6319D0
        public void OnTriggerExit(){} // RVA: 0x7FFD4F631FB0
        public void Awake_D96EDC188FF5(){} // RVA: 0x7FFD4F632510
    }

    /// <summary>Originally: ÌÍÌÎÍÍÌÌÌÏÌÌÎÏÏÎÍÌÎÎÎÍÍ</summary>
    public class NetworkReadyHandler_55A3 : WorldProximityExitStation_FE46
    {
        public VRC.Udon.ProgramSources.SerializedUdonProgramAsset ÍÏÌÌÍÍÎÏÏÎÍÎÎÏÏÌÍÎÏÌÍÎÍ;

        // ── Methods ──
        public void __Clone__SystemObject(){} // RVA: 0x7FFD4F5EC520
        public void set_ValidExpressions(){} // RVA: 0x7FFD4F5ECA00
        public void GetLanguage(){} // RVA: 0x7FFD4F5ECEE0
        public void AddSubtraction(){} // RVA: 0x7FFD4F5ED3C0
        public void .ctor(){} // RVA: 0x7FFD4F5ED8A0
        public void OnNetworkReady(){} // RVA: 0x7FFD4F5ED8F0
        public void get_caretColor(){} // RVA: 0x7FFD4F5ED910
        public void Awake(){} // RVA: 0x7FFD4F5EDDF0
    }

    /// <summary>Originally: ÏÌÎÍÏÎÌÌÎÍÍÎÌÏÌÏÌÎÍÌÎÌÎ</summary>
    public class NetworkReadyHandler_6881 : NetworkReadyHandler_68D0
    {
        public System.Lazy`1<System.Collections.Immutable.ImmutableArray`1<ÌÌÎÍ>> f_3DB;
        public bool f_C03; // 0x58
        public ÎÍÌÌÌÍÎÎÌÍÎÍÍÍÎÍÏÍÏÎÌÌÎ f_410; // 0x60
        public UnityEngine.GameObject f_800; // 0x68
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ f_972; // 0x70
        public UnityEngine.Animator f_092; // 0x78
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ f_8D0; // 0x80
        public ÌÌÍÎÍÏÏÌÎÏÍÏÌÏÏÏÏÌÎÌÍÍÌ f_ABC; // 0x88
        public ÏÍÍÏÎÍÏÎÍÏÌÍÍÏÎÏÍÎÎÎÏÏÏ ÎÍÏÏÍÌÌÌÍÏÍÍÍÌÌÌÏÎÌÏÏÏÌ; // 0x90
        public ÏÎÌÌÍÌÍÎÌÌÏÏÏÌÏÏÌÏÌÏÍÎÌ ÏÌÍÌÏÍÏÎÏÎÌÏÎÏÏÏÎÍÍÌÏÎÍ; // 0x98
        public ÎÎÏÌÏÎÌÏÌÌÎÏÎÍÎÌÏÌÌÍÏÍÌ ÏÎÎÏÌÎÎÌÍÌÍÏÌÍÍÍÍÌÏÎÌÍÎ; // 0xA0
        public ÏÍÎÌÍÏÎÌÍÎÎÎÌÎÎÎÏÎÌÌÏÏÎ ÎÌÌÍÎÎÌÎÎÎÎÌÍÍÏÏÍÎÍÎÏÍÍ; // 0xA8
        public ÍÍÎÎÍÎÎÏÍÌÏÏÌÎÍÍÎÎÍÏÌÏÎ ÌÍÎÏÍÌÌÎÌÎÏÍÏÏÏÏÌÍÌÏÌÍÏ; // 0xB0
        public ÎÍÍÌÎÏÌÍÏÎÍÍÌÎÌÏÏÎÏÍÍÏÍ ÌÎÏÍÍÌÎÏÍÍÎÌÍÏÌÌÏÍÎÌÍÍÏ; // 0xB8
        public ÌÍÍÏÎÍÍÍÏÌÍÍÏÏÍÌÌÏÌÏÍÌÎ ÏÏÏÌÍÏÌÍÌÌÎÌÌÏÏÍÍÏÍÌÍÍÎ; // 0xC0
        public ÌÌÍÌÌÏÎÎÏÎÌÏÍÏÍÌÌÌÌÏÎÌÍ ÏÍÏÎÏÍÎÌÎÍÏÍÍÍÌÏÍÏÌÌÌÏÎ; // 0xC8
        public UnityEngine.Transform ÍÍÏÌÏÍÍÍÍÎÍÌÎÏÍÏÎÌÎÌÍÌÏ; // 0xD0
        public UnityEngine.Transform ÍÏÏÎÎÌÏÍÌÍÌÍÍÏÏÌÌÌÎÍÌÌÏ; // 0xD8
        public bool ÎÌÏÍÌÌÏÌÎÏÌÏÌÎÎÌÏÏÍÎÌÏÌ; // 0xE0
        public ÏÎÏÌÎÏÍÌÍÎÏÌÌÌÍÎÏÏÍÏÏÏÍ ÌÌÌÌÏÌÎÎÎÎÌÏÏÎÌÍÏÏÎÎÎÍÏ; // 0xE8
        public ÏÎÏÏÎÍÌÎÌÏÍÏÏÎÎÏÎÍÎÌÎÎÍ ÌÎÏÏÌÏÏÌÌÎÏÎÌÌÏÏÍÎÍÍÏÍÌ; // 0xF0
        public ÌÎÎÌÎÌÏÍÌÎÎÌÏÌÌÎÌÎÎÌÏÌÍ ÎÏÌÌÎÎÌÍÍÍÎÌÎÍÍÍÍÎÏÏÌÎÎ; // 0xF8
        public bool ÏÏÏÏÌÎÎÎÌÏÎÏÌÍÌÏÏÏÍÏÎÍÎ; // 0x100
        public bool ÍÏÏÍÎÌÍÏÎÍÍÎÏÏÏÎÎÎÏÌÏÎÍ; // 0x101
        public ÌÏÌÎÍÏÏÏÍÍÏÌÏÎÌÎÏÌÏÎÌÏÎ ÏÎÍÌÏÍÌÌÎÏÏÎÏÌÎÏÌÏÌÏÏÎÍ; // 0x108
        public RootMotion.FinalIK.IKExecutionOrder ÏÍÎÍÏÍÌÌÌÍÎÎÌÌÍÍÎÏÌÍÍÍÎ; // 0x110
        public RootMotion.FinalIK.VRIK ÎÍÏÏÍÌÍÎÌÏÌÌÍÎÎÏÎÎÍÏÌÌÍ; // 0x118
        public RootMotion.FinalIK.FullBodyBipedIK ÎÎÏÎÏÎÌÍÍÏÍÎÌÌÌÌÍÏÎÎÎÌÏ; // 0x120
        public ÍÌÌÏÍÎÎÍÍÏÌÎÏÏÎÍÍÏÎÌÌÌÎ ÏÌÌÎÏÏÍÏÎÌÏÌÏÎÍÌÎÏÎÍÍÎÏ; // 0x128
        public bool ÎÌÍÌÍÏÌÌÏÌÍÏÏÎÍÎÎÍÌÌÏÍÍ; // 0x130
        public VRC.Profiling.ProfilerMarker ÍÌÎÌÎÍÎÏÌÏÌÌÌÎÍÎÎÌÎÎÌÏÍ; // 0x8
        public bool <ÏÏÏÎÍÍÏÎÌÍÌÎÍÌÎÎÎÏÎÌÍÌÍ>k__BackingField; // 0x131
        public System.Collections.Generic.Dictionary`2<ÌÌÎÍ,UnityEngine.Quaternion> ÌÏÍÏÍÌÍÏÌÌÎÍÍÌÏÌÏÏÎÌÎÎÌ; // 0x138
        public System.Collections.Generic.Dictionary`2<ÌÌÎÍ,UnityEngine.Vector3> ÍÍÎÌÏÌÎÌÏÍÏÌÌÌÌÏÏÎÏÏÏÏÍ; // 0x140
        public float ÎÎÍÍÌÏÍÎÌÌÎÎÎÎÌÌÌÏÌÍÏÏÍ; // 0x148
        public bool ÌÍÏÍÌÍÏÎÏÎÏÌÎÌÌÏÍÌÌÌÌÏÌ; // 0x14C
        public bool ÌÎÏÌÎÏÍÌÍÌÌÌÍÏÍÏÍÏÌÍÍÍÏ; // 0x14D
        public bool ÍÎÏÎÎÏÏÏÏÍÏÏÎÏÎÌÍÍÎÏÎÎÏ; // 0x14E

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFD4F033210
        public void set_ValidExpressions(){} // RVA: 0x7FFD4F0334D0
        public void GetLanguage(){} // RVA: 0x7FFD4F0335D0
        public void ComputeParent(){} // RVA: 0x7FFD4F033CA0
        public void Awake_59C6C5(){} // RVA: 0x7FFD4F03A470 | overloaded x2
        public void GetTypeCode(){} // RVA: 0x7FFD4F035CE0
        public void OnDestroy_0048E988D155(){} // RVA: 0x7FFD4F035CF0
        public void Awake_4ED4DDC2FBFA(){} // RVA: 0x7FFD4F035D40
        public void Start(){} // RVA: 0x7FFD4F035E70
        public void OnDestroy_453B173AFAC6(){} // RVA: 0x7FFD4F035CF0
        public void LateUpdate_B7EA9C133E7E(){} // RVA: 0x7FFD4F036030
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E341320
        public void OnNetworkReady_F736E789A2F0(){} // RVA: 0x7FFD4F036040
        public void StopCoroutine(){} // RVA: 0x7FFD4F036170
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F036270
        public void LateUpdate(){} // RVA: 0x7FFD4F036370
        public void GetAudioTracks(){} // RVA: 0x7FFD4E70F640
        public void SetOverlay(){} // RVA: 0x7FFD4F036610
        public void Invoke(){} // RVA: 0x7FFD4F036820
        public void OnDestroy(){} // RVA: 0x7FFD4F035CF0
        public void Internal_IsInvokingAll_0FC17ED3DC94(){} // RVA: 0x7FFD4F037EA0 | overloaded x2
        public void __GetAxis__SystemString__SystemSingle(){} // RVA: 0x7FFD4F036960
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFD4F0369E0
        public void set_hidden(){} // RVA: 0x7FFD4F0369F0
        public void get_alreadySelecting(){} // RVA: 0x7FFD4F036A00
        public void Awake(){} // RVA: 0x7FFD4F036E30
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F037500
        public void DoFloatToHalf_06B(){} // RVA: 0x7FFD4F0376B0
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFD4E426850
        public void Update(){} // RVA: 0x7FFD4F037730
        public void OnEnable(){} // RVA: 0x7FFD4F0379F0
        public void UpdateBipedIK(){} // RVA: 0x7FFD4E3F5BE0
        public void OnDisable(){} // RVA: 0x7FFD4F037F40
        public void IsAsyncOperationDone(){} // RVA: 0x7FFD4F0381A0
        public void GetAudioTracks_8F2F97419925(){} // RVA: 0x7FFD4E70F640
        public void .cctor(){} // RVA: 0x7FFD4F038460
        public void UpdatecullingMode(){} // RVA: 0x7FFD4F038760
        public void OnDestroy_F341583F27D9(){} // RVA: 0x7FFD4F038920
        public void Reset(){} // RVA: 0x7FFD4F038BD0
        public void Clear(){} // RVA: 0x7FFD4F038BE0
        public void Dispose(){} // RVA: 0x7FFD4F039DB0
        public void OnNetworkReady(){} // RVA: 0x7FFD4F03A4F0
        public void .ctor(){} // RVA: 0x7FFD4F03A660
    }

    /// <summary>Originally: ÎÎÍÏÏÎÌÎÎÌÎÌÎÌÍÏÍÌÍÌÎÏÍ</summary>
    public class NetworkReadyHandler_68D0 : MonoBehaviour
    {
        public bool _destroyCancellationToken;
        public bool _useGUILayout; // 0x20
        public ÍÌÍÍÍÍÎÍÏÍÎÎÎÌÏÌÎÎÌÍÏÎÏ f_1FA; // 0x28
        public float f_5B8; // 0x30
        public VRC.SDKBase.VRC_EventHandler f_AB7; // 0x38
        public ÎÍÏÎÎÌÏÏÎÏÍÌÌÍÎÌÍÍÍÎÌÎÌ f_F88; // 0x40
        public bool f_B1A; // 0x48
        public bool f_B11; // 0x49
        public ÎÎÌÏÏÏÎÌÏÌÌÏÍÍÏÌÌÍÏÎÍÏÍ f_8CE; // 0x50

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFD4E42F9D0
        public void set_ValidExpressions(){} // RVA: 0x7FFD4E42F9E0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void Invoke(){} // RVA: 0x7FFD4F22DC50
        public void InvokeRepeating(){} // RVA: 0x7FFD4E341310
        public void OnEnable(){} // RVA: 0x7FFD4F22DD40
        public void Awake(){} // RVA: 0x7FFD4E4A21C0
        public void Start(){} // RVA: 0x7FFD4F22DDB0
        public void StartCoroutine(){} // RVA: 0x7FFD4F22DE50
        public void LateUpdate(){} // RVA: 0x7FFD4F22DEF0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E2ADC40
        public void OnNetworkReady(){} // RVA: 0x7FFD4F22EA60
        public void StopCoroutine(){} // RVA: 0x7FFD4F22EC40
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F22EDC0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F22F070
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void SetOverlay(){} // RVA: 0x7FFD4E369200
        public void print(){} // RVA: 0x7FFD4F22F180
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F22F180
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F22F1E0
        public void InvokeDelayed(){} // RVA: 0x7FFD4F22F240
        public void get_hidden(){} // RVA: 0x7FFD4E3F8D30
        public void set_hidden(){} // RVA: 0x7FFD4E3F8D40
        public void get_alreadySelecting(){} // RVA: 0x7FFD4F22F350
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFD4F22F360
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F22F370
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFD4E4994D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void .cctor(){} // RVA: 0x7FFD4F22F3D0
    }

    /// <summary>Originally: ÍÏÏÍÎÏÎÎÎÏÍÎÏÏÏÎÍÍÌÏÎÌÍ</summary>
    public class NetworkReadyHandler_D4BC : MonoBehaviour
    {
        public UnityEngine.CanvasGroup _d4BC; // 0x20
        public UnityEngine.UI.RawImage ÌÎÎÏÏÌÍÍÎÎÏÏÏÍÌÎÏÏÍÏÏÎÍ; // 0x28
        public UnityEngine.UI.RawImage ÏÌÎÏÌÍÌÏÍÌÌÍÌÎÍÍÏÍÍÍÌÍÏ; // 0x30
        public UnityEngine.GameObject invalidAvatarGraphics; // 0x38
        public UnityEngine.Texture2D loadingTexture; // 0x40
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ ÍÌÎÏÍÎÎÍÌÌÍÏÌÎÏÎÍÌÌÍÏÌÌ; // 0x48
        public VRC.SDKBase.VRC_AvatarPedestal ÍÌÌÎÍÍÍÎÏÎÏÌÌÎÏÏÍÌÌÍÏÎÎ; // 0x50
        public VRC.Core.ApiAvatar ÌÏÌÍÌÌÎÏÏÌÎÌÍÏÍÏÍÍÎÎÌÍÍ; // 0x58
        public bool ÍÌÏÎÌÏÏÌÏÏÍÌÌÏÏÌÍÍÌÏÍÎÎ; // 0x60
        public string ÌÏÍÎÍÎÎÏÍÏÌÍÍÏÎÌÍÎÍÍÎÏÏ; // 0x68
        public ÎÌÍÍÏÏÏÎÏÎÌÏÎÎÌÍÏÎÍÏÌÍÌ ÎÍÏÌÍÌÌÌÎÏÍÌÍÍÌÏÎÎÍÎÌÌÌ; // 0x70
        public bool ÎÌÏÏÍÌÎÌÎÎÏÌÌÎÎÍÍÏÏÌÍÍÏ; // 0x90

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F5790E0
        public void OnDestroy(){} // RVA: 0x7FFD4F579180
        public void SetAvatarUse(){} // RVA: 0x7FFD4F5792B0
        public void CancelInvoke(){} // RVA: 0x7FFD4F579430
        public void OnNetworkReady(){} // RVA: 0x7FFD4F579560
        public void InvokeRepeating(){} // RVA: 0x7FFD4F579570
        public void OnCollisionEnter(){} // RVA: 0x7FFD4F579610
        public void Awake(){} // RVA: 0x7FFD4F579BF0
        public void StartCoroutine(){} // RVA: 0x7FFD4F579C20
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F579E80
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Start(){} // RVA: 0x7FFD4F579F60
        public void get_IsVirtual(){} // RVA: 0x7FFD4F22D160
        public void StopCoroutine(){} // RVA: 0x7FFD4F57A5D0
        public void LateUpdate(){} // RVA: 0x7FFD4F57A840
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F22D160
        public void get_useGUILayout(){} // RVA: 0x7FFD4F57AEB0
        public void set_useGUILayout(){} // RVA: 0x7FFD4F57B410
        public void Update(){} // RVA: 0x7FFD4F57B4F0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F57B620
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F57BB50
        public void InvokeDelayed(){} // RVA: 0x7FFD4E341310
        public void OnCollisionStay(){} // RVA: 0x7FFD4F57BDF0
        public void IsInvoking(){} // RVA: 0x7FFD4F57BE70
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F57BF00
        public void RefreshAvatar(){} // RVA: 0x7FFD4F57C160
    }

    /// <summary>Originally: ÌÏÏÏÍÏÎÌÍÎÏÏÍÏÎÎÍÍÎÏÌÍÎ</summary>
    public class NetworkShouldBroadcastInstigator_AC3B : Object
    {
        public int _shouldBroadcast; // 0x10
        public int _store; // 0x14
        public int _sender; // 0x18
        public 0x665B1900 _instigator; // 0x20
        public string _serialize; // 0x28
        public float _time; // 0x30
        public float f_007; // 0x34
        public object[] f_3AF; // 0x38
        public 0x665B17F8 f_6A9; // 0x40
        public byte[] f_078; // 0x48
        public int f_01E; // 0x50

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F26BAF0
        public void set_ShouldBroadcast(){} // RVA: 0x7FFD4F26BBA0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void op_Implicit(){} // RVA: 0x7FFD4F26BC60
        public void get_ShouldBroadcast(){} // RVA: 0x7FFD4F26BCC0
        public void GetNativeOffset(){} // RVA: 0x7FFD4E7F5A20
        public void GetCachedPtr(){} // RVA: 0x7FFD4F26BE40
        public void GetHashCode(){} // RVA: 0x7FFD4E577800
        public void set_name(){} // RVA: 0x7FFD4F26BEF0
        public void get_preferredPeakBitRate(){} // RVA: 0x7FFD4F060670
        public void set_Store(){} // RVA: 0x7FFD4E36F0C0
        public void get_Store(){} // RVA: 0x7FFD4F26C050
        public void Instantiate(){} // RVA: 0x7FFD4F26C150
        public void DeepClone(){} // RVA: 0x7FFD4F26C240
        public void Equals(){} // RVA: 0x7FFD4F26C440
        public void set_Sender(){} // RVA: 0x7FFD4E5F9010
        public void set_Instigator(){} // RVA: 0x7FFD4F26C4A0
        public void get_Instigator(){} // RVA: 0x7FFD4E577800
        public void ToString(){} // RVA: 0x7FFD4F26C500
        public void get_Serialize(){} // RVA: 0x7FFD4F26C9F0
        public void .ctor(){} // RVA: 0x7FFD4F26CAA0
        public void Initialize(){} // RVA: 0x7FFD4E36F0C0
        public void set_Time(){} // RVA: 0x7FFD4F26C4A0
        public void get_Time(){} // RVA: 0x7FFD4F26CAB0
        public void FindObjectsOfType(){} // RVA: 0x7FFD4F060670
        public void FindObjectsByType(){} // RVA: 0x7FFD4F26CBA0
        public void ProcessBroadcastInstigator(){} // RVA: 0x7FFD4E36F0C0
        public void get_Sender(){} // RVA: 0x7FFD4E5110E0
        public void get_hideFlags(){} // RVA: 0x7FFD4F26CC90
    }

    /// <summary>Originally: ÎÏÏÍÏÏÍÌÌÌÍÌÌÎÏÌÌÏÍÏÏÏÏ</summary>
    public class NetworkSyncableRelatedRelated_1244 : Object
    {
        public System.Collections.Generic.List`1<int> _name; // 0x10

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F5E42F0
        public void Equals(){} // RVA: 0x7FFD4F5E43B0
        public void GetHashCode(){} // RVA: 0x7FFD4F5E4480
        public void op_Implicit(){} // RVA: 0x7FFD4F5E44D0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F5E4520
        public void .ctor(){} // RVA: 0x7FFD4F5E45E0
        public void Initialize(){} // RVA: 0x7FFD4F5E46A0
        public void get_name(){} // RVA: 0x7FFD4F5E4770
        public void set_name(){} // RVA: 0x7FFD4F5E4830
        public void Instantiate(){} // RVA: 0x7FFD4F5E48D0
        public void ToString(){} // RVA: 0x7FFD4F5E4970
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F5E49C0
        public void get_destroyCancellationToken_2B9F89A2D0EF(){} // RVA: 0x7FFD4F5E4A90
    }

    /// <summary>Originally: ÌÍÎÌÍÍÏÏÍÌÍÎÌÍÍÌÍÏÏÏÌÍÍ</summary>
    public class NetworkSyncableRelatedRelated_4E56 : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,ÏÎÍÌÌÌÏÌÍÍÎÎÍÍÎÍÌÍÏÏÏÍÍ> ÍÎÍÌÌÍÎÍÏÌÌÏÍÌÏÍÌÏÌÍÏÎÌ; // 0x10
        public System.Collections.Generic.List`1<ÏÎÍÌÌÌÏÌÍÍÎÎÍÍÎÍÌÍÏÏÏÍÍ> ÎÎÏÏÎÎÏÍÎÏÎÌÌÌÍÌÎÏÏÍÎÏÎ; // 0x18
        public ÏÎÎÍÌÍÏÌÍÎÎÌÍÎÌÍÍÍÏÎÌÍÎ ÎÍÍÍÎÏÏÍÍÌÍÎÌÌÏÍÎÎÏÏÏÏÌ; // 0x20

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F9978D0
        public void Equals(){} // RVA: 0x7FFD4F997A20
        public void get_name_93747BCD0B5D(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD4F997C30
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F997E50
        public void IsNativeObjectAlive_28349F04784C(){} // RVA: 0x7FFD4F998EB0 | overloaded x2
        public void GetCachedPtr(){} // RVA: 0x7FFD4E078E90
        public void set_name(){} // RVA: 0x7FFD4F9981B0
        public void Instantiate(){} // RVA: 0x7FFD4F998680
        public void GetHashCode_A7FB9E22711A(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD4F9987A0
        public void SyncState(){} // RVA: 0x7FFD4E078F40
        public void CopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateNetworkObject(){} // RVA: 0x7FFD4F9988C0
        public void CopyTo_194394E3A2F2(){} // RVA: 0x7FFD4E2ADC40
        public void ValidateSync(){} // RVA: 0x7FFD4F998D90
        public void Destroy(){} // RVA: 0x7FFD4F9990F0
        public void CopyTo_7DCC82B25262(){} // RVA: 0x7FFD4E2ADC40
        public void DestroyImmediate(){} // RVA: 0x7FFD4F999280
        public void .ctor(){} // RVA: 0x7FFD4F999750
        public void Initialize(){} // RVA: 0x7FFD4E079F60
        public void FindObjectsOfType(){} // RVA: 0x7FFD4F9998B0
    }

    /// <summary>Originally: ÌÌÌÍÏÎÎÏÎÌÍÎÍÎÎÏÍÍÌÌÎÌÌ</summary>
    public class NetworkSyncableRelated_B4DB : Object
    {
        public System.Collections.Generic.HashSet`1<UnityEngine.Events.UnityAction`3<U,V,T>> ÎÎÏÍÎÎÎÏÌÍÌÌÎÍÎÎÍÌÌÎÏÎÏ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E090980
        public void Equals(){} // RVA: 0x7FFD4E090980
        public void GetHashCode(){} // RVA: 0x7FFD4E090980
        public void op_Implicit(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Initialize(){} // RVA: 0x7FFD4E090980
        public void GetCachedPtr(){} // RVA: 0x7FFD4E2ADC40
        public void get_name(){} // RVA: 0x7FFD4E090980
        public void set_name(){} // RVA: 0x7FFD4E090980
        public void Instantiate(){} // RVA: 0x7FFD4E090980
        public void ToString(){} // RVA: 0x7FFD4E090A40
        public void ToString_FEA86851AEF4(){} // RVA: 0x7FFD4E090A40
        public void GetNetworkSyncableRelatedValue(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÎÎÎÌÏÍÍÌÌÍÌÎÏÌÏÌÏÏÎÎÏÎÍ</summary>
    public class NetworkSyncableSiblingSibling_03BC : Object
    {
        public VRC.Profiling.ProfilerMarker _name; // 0x10
        public VRC.Profiling.ProfilerMarker _hideFlags; // 0x20
        public ÏÎÍÏÏÌÏÏÎÎÍÍÍÏÏÌÎÌÍÎÎÍÏ f_943; // 0x30
        public bool <ÏÌÎÎÍÎÌÍÎÎÌÌÌÍÎÌÏÎÌÍÌÏÍ>k__BackingField; // 0x38

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E5F95A0
        public void SetCompletedSynchronously(){} // RVA: 0x7FFD4E5F95C0
        public void IsResource(){} // RVA: 0x7FFD4E5F95D0
        public void op_Implicit(){} // RVA: 0x7FFD4E341310
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void Dispose(){} // RVA: 0x7FFD4E341310
        public void Cleanup(){} // RVA: 0x7FFD4E5F95F0
        public void set_name(){} // RVA: 0x7FFD4E5FA650
        public void .ctor(){} // RVA: 0x7FFD4E5FB6B0
        public void Initialize(){} // RVA: 0x7FFD4E5F95C0
        public void Instantiate(){} // RVA: 0x7FFD4E341310
        public void Equals(){} // RVA: 0x7FFD4E341310
        public void DoToUpper(){} // RVA: 0x7FFD4E5F95C0
        public void GetHashCode(){} // RVA: 0x7FFD4E341310
        public void ToString(){} // RVA: 0x7FFD4E341310
        public void SetConnectedBody(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÌÎÌÎÏÏÍÏÍÎÍÏÍÏÍÏÌÌÍÏÌÌÌ</summary>
    public class NetworkSyncableSiblingSibling_5BEB
    {
        public object f_844;
        public object f_943;

        // ── Methods ──
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void Enable(){} // RVA: 0x7FFD4E091060
        public void Getter(){} // RVA: 0x7FFD4E090980
        public void Getter_7B4CBB445E50(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÍÌÎÎÌÎÍÌÏÍÏÍÎÏÏÏÍÌÌÏÍÍÏ</summary>
    public class NetworkSyncableSibling_19B1 : MonoBehaviour
    {
        public UnityEngine.GameObject lockIcon; // 0x20
        public UnityEngine.GameObject checkIcon; // 0x28
        public UnityEngine.GameObject preUnlockTexts; // 0x30
        public UnityEngine.GameObject postUnlockTexts; // 0x38
        public ÌÎÍÏÎÌÌÍÍÌÍÎÍÌÌÎÌÍÏÎÎÍÍ icon; // 0x40
        public UnityEngine.CanvasGroup canvasGroup; // 0x48

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD566BC560
        public void RaiseCancellation(){} // RVA: 0x7FFD566BC600
        public void IsInvoking(){} // RVA: 0x7FFD566BC6A0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD566BC740
        public void InvokeRepeating(){} // RVA: 0x7FFD566BC7E0
        public void CancelInvoke(){} // RVA: 0x7FFD566BC9E0
        public void RegisterCancellationOrCoroutine(){} // RVA: 0x7FFD566BCA80
        public void StartCoroutine(){} // RVA: 0x7FFD566BCC70
    }

    /// <summary>Originally: ÌÌÏÍÎÎÍÎÍÌÎÌÏÏÎÍÌÎÌÏÏÌÎ</summary>
    public class NetworkSyncableSibling_5A19 : Object
    {
        public VRC.Profiling.ProfilerMarker _name; // 0x10
        public VRC.Profiling.ProfilerMarker _hideFlags; // 0x20
        public VRC.Profiling.ProfilerMarker f_943; // 0x30
        public ÏÎÍÏÏÌÏÏÎÎÍÍÍÏÏÌÎÌÍÎÎÍÏ <ÏÌÌÎÏÎÎÌÎÍÍÎÍÎÌÏÎÎÍÏÍÌÎ>k__BackingField; // 0x40
        public bool <ÏÌÎÎÍÎÌÍÎÎÌÌÌÍÎÌÏÎÌÍÌÏÍ>k__BackingField; // 0x48
        public UnityEngine.Animations.AnimationScriptPlayable ÎÎÌÏÌÏÏÏÎÏÍÏÌÌÌÌÌÏÍÍÏÍÍ; // 0x50
        public bool ÍÌÏÏÌÎÌÏÎÌÏÌÌÏÏÎÍÏÍÏÌÍÏ; // 0x60
        public bool ÏÎÏÌÍÏÏÏÍÍÍÍÏÍÎÌÌÏÏÎÍÌÌ; // 0x61
        public bool ÌÍÍÎÎÎÏÍÌÌÌÌÎÍÏÍÎÌÏÎÌÌÏ; // 0x62
        public Unity.Collections.NativeArray`1<float> ÎÌÍÌÌÏÎÌÎÌÍÎÌÏÎÏÌÌÏÍÍÎÍ; // 0x68
        public Unity.Collections.NativeArray`1<float> ÏÎÌÏÌÌÎÎÌÎÍÌÏÎÎÏÏÌÏÌÌÎÌ; // 0x78
        public Unity.Collections.NativeArray`1<float> ÏÍÎÏÌÏÏÍÎÎÍÏÌÎÌÎÌÌÎÌÏÍÍ; // 0x88
        public Unity.Collections.NativeArray`1<UnityEngine.Animations.MuscleHandle> ÍÌÎÏÍÎÌÎÎÍÍÏÎÏÏÌÏÎÎÎÎÌÍ; // 0x98
        public Unity.Collections.NativeArray`1<int> ÎÌÌÏÌÏÌÏÏÎÍÏÌÌÏÌÍÍÎÍÌÍÏ; // 0xA8
        public Unity.Collections.NativeArray`1<int> ÍÍÏÎÏÎÌÍÏÌÏÍÎÍÎÎÏÏÎÍÏÍÏ; // 0xB8
        public Unity.Collections.NativeArray`1<int> ÏÍÏÎÏÎÌÌÌÏÏÌÎÎÍÎÎÏÏÎÎÏÏ; // 0xC8

        // ── Methods ──
        public void set_hidden(){} // RVA: 0x7FFD4E3F8D40
        public void Equals(){} // RVA: 0x7FFD4E5FCAA0
        public void GetHashCode(){} // RVA: 0x7FFD4E5FCBA0
        public void op_Implicit(){} // RVA: 0x7FFD4E5FCE60
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E3F8D40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E3F8D40
        public void GetCachedPtr(){} // RVA: 0x7FFD4E5FCE80
        public void get_name(){} // RVA: 0x7FFD4E5FD410
        public void set_name(){} // RVA: 0x7FFD4E5FDE10
        public void Instantiate(){} // RVA: 0x7FFD4E5FE0D0
        public void ToString(){} // RVA: 0x7FFD4E5FE100
        public void ComputegameObject(){} // RVA: 0x7FFD4E5FE150
        public void SetOverlay(){} // RVA: 0x7FFD4E369200
        public void get_hidden(){} // RVA: 0x7FFD4E3F8D30
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void ReadByte(){} // RVA: 0x7FFD4E5FE5C0
        public void ReadDeltaTime(){} // RVA: 0x7FFD4E5FEA40
        public void Instantiate_84CEA4C230F0(){} // RVA: 0x7FFD4E3F8D30
        public void Initialize(){} // RVA: 0x7FFD4E3F8D40
        public void .ctor(){} // RVA: 0x7FFD4E5FEFD0
        public void Dispose(){} // RVA: 0x7FFD4E5FF7A0
        public void Cleanup(){} // RVA: 0x7FFD4E5FFA60
    }

    /// <summary>Originally: ÏÎÌÎÌÏÏÏÍÎÏÎÎÎÌÎÍÌÎÍÎÎÌ</summary>
    public class NetworkSyncableSibling_7FE1
    {
        public object f_75C;
        public object f_F09;

        // ── Methods ──
        public void GetLast(){} // RVA: 0x7FFD4E078E90
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_07B7C46F42C2(){} // RVA: 0x7FFD4E090A40
        public void Short(){} // RVA: 0x7FFD4E079D00
        public void Enable(){} // RVA: 0x7FFD4E091060
    }

    /// <summary>Originally: ÎÏÌÏÏÌÏÏÎÎÍÍÎÍÍÌÏÎÎÌÌÏÏ</summary>
    public class NetworkSyncableSibling_BA61 : MonoBehaviour
    {
        public ÌÎÌÍÎÌÌÍÏÏÍÍÍÎÍÌÍÎÎÎÍÏÎ ÎÌÏÎÌÎÎÌÎÎÍÎÎÌÎÎÌÌÍÏÍÍÎ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F632540
        public void RaiseCancellation(){} // RVA: 0x7FFD4F6326E0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F632880
        public void Invoke(){} // RVA: 0x7FFD4F632A20
        public void InvokeRepeating(){} // RVA: 0x7FFD4F632BC0
        public void CancelInvoke(){} // RVA: 0x7FFD4F632D60
        public void IsInvoking(){} // RVA: 0x7FFD4F632F00
    }

    /// <summary>Originally: ÍÏÌÏÌÍÏÏÏÌÌÌÌÎÏÎÏÍÎÍÏÎÍ</summary>
    public class NetworkSyncableSibling_DA24 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E58C220
        public void Equals(){} // RVA: 0x7FFD4E58EAC0
        public void GetHashCode(){} // RVA: 0x7FFD4E58F020
        public void op_Implicit(){} // RVA: 0x7FFD4E58F0D0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E58F170
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E58F1C0
        public void GetCachedPtr(){} // RVA: 0x7FFD4E58F270
        public void get_name(){} // RVA: 0x7FFD4E58F310
        public void set_name(){} // RVA: 0x7FFD4E58F3C0
        public void Instantiate(){} // RVA: 0x7FFD4E58F460
        public void ToString(){} // RVA: 0x7FFD4E58F510
        public void Instantiate_DFFEB6DEB75A(){} // RVA: 0x7FFD4E58F5B0
        public void OvrAudioMaterialSetFrequencyWwise(){} // RVA: 0x7FFD4E58F660
        public void FindObjectsWithSpecificFilter(){} // RVA: 0x7FFD4E58F750
        public void OvrAudioGetPluginContextWwise(){} // RVA: 0x7FFD4E58F800
        public void OvrAudioGeometrySetTransformWwise(){} // RVA: 0x7FFD4E58F8B0
        public void OvrAudioMaterialGetFrequencyWwise(){} // RVA: 0x7FFD4E58F960
        public void FindObjectByParameter(){} // RVA: 0x7FFD4E58FA10
        public void FindObjectsByMultipleCriteria(){} // RVA: 0x7FFD4E58FAB0
        public void Destroy(){} // RVA: 0x7FFD4E58FB50
        public void UpdateWwiseAudioMesh(){} // RVA: 0x7FFD4E58FC00
        public void DestroyImmediate(){} // RVA: 0x7FFD4E58FCB0
        public void SyncAudioGeometry(){} // RVA: 0x7FFD4E58FD60
        public void FindObjectsOfType(){} // RVA: 0x7FFD4E58FE10
        public void WriteOculusWwiseAudioGeometryMeshFile(){} // RVA: 0x7FFD4E58FEC0
        public void FindObjectsByType(){} // RVA: 0x7FFD4E58FF70
        public void ReadOculusWwiseAudioGeometryMeshFile(){} // RVA: 0x7FFD4E590020
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4E5900D0
        public void get_hideFlags(){} // RVA: 0x7FFD4E590180
        public void set_hideFlags(){} // RVA: 0x7FFD4E590220
        public void FindObjectOfType(){} // RVA: 0x7FFD4E5902D0
        public void UpdateSync(){} // RVA: 0x7FFD4E590370
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4E590420
        public void Initialize(){} // RVA: 0x7FFD4E590540
        public void CheckNullArgument(){} // RVA: 0x7FFD4E590600
        public void SetOvrAudioPropagationThreadAffinity(){} // RVA: 0x7FFD4E5907B0
        public void FindFirstObjectByType_FE265C9DA524(){} // RVA: 0x7FFD4E590860
        public void OvrAudioDestroyAudioMaterialWwise(){} // RVA: 0x7FFD4E590A70
        public void SyncAudioGeometry_CF1548EA25D6(){} // RVA: 0x7FFD4E590B20
        public void UpdateWwiseAudioMesh_EF887C2F0082(){} // RVA: 0x7FFD4E590D30
        public void op_Equality(){} // RVA: 0x7FFD4E590DE0
        public void op_Inequality(){} // RVA: 0x7FFD4E590FF0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFD4E5910A0
    }

    /// <summary>Originally: ÎÌÎÍÍÍÏÎÌÏÏÍÏÏÌÌÎÎÎÏÍÏÏ</summary>
    public class NetworkSyncable_13B8 : NetworkReadyHandler_68D0
    {
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneBase> _typeId; // 0x58
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ ÎÌÍÌÌÎÎÏÎÍÎÍÎÍÏÎÍÌÏÌÌÍÏ; // 0x60
        public bool ÏÎÍÍÍÎÌÏÌÎÌÍÎÌÌÎÌÎÏÎÌÏÌ; // 0x68
        public System.Collections.Generic.List`1<ÍÏÏÍÌÍÎÍÎÏÌÍÏÎÍÌÍÎÏÎÍÎÎ> ÎÏÌÎÎÎÍÍÏÌÎÎÎÍÍÍÌÌÎÎÎÏÏ; // 0x70
        public System.Collections.Generic.List`1<ÏÏÏÌÎÍÏÍÍÍÍÎÌÏÎÍÍÎÍÎÎÏÌ> ÏÏÏÏÍÏÍÏÏÌÍÌÌÏÌÌÌÏÍÏÎÏÍ; // 0x78
        public byte[] ÏÎÍÍÍÎÍÍÎÏÍÌÎÍÏÎÏÌÍÌÍÎÍ; // 0x80
        public byte[] ÎÎÏÌÍÎÍÌÏÍÎÏÏÍÎÏÍÍÎÍÏÏÌ; // 0x88
        public ÎÏÍÍÌÍÏÎÎÌÏÍÍÍÏÍÏÌÌÏÌÌÌ ÎÌÌÌÎÍÌÍÏÌÍÏÌÍÏÌÍÎÌÏÏÏÎ; // 0x90
        public ÎÏÍÍÌÍÏÎÎÌÏÍÍÍÏÍÏÌÌÏÌÌÌ ÍÌÌÏÍÏÏÌÌÍÏÏÍÌÌÍÏÍÌÎÍÍÍ; // 0x98
        public bool ÍÌÍÏÎÍÍÏÌÍÏÎÍÎÎÎÍÍÎÏÌÌÍ; // 0xA0
        public bool ÍÏÏÎÌÌÎÏÏÍÎÍÌÌÍÌÎÌÏÍÍÎÍ; // 0xA1

        // ── Methods ──
        public void SerializedName(){} // RVA: 0x7FFD4EEC4B50
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EEC4CC0
        public void GetLanguage(){} // RVA: 0x7FFD4EEC4D50
        public void AddSubtraction(){} // RVA: 0x7FFD4EEC4F50
        public void InsertDictionaryValue(){} // RVA: 0x7FFD4EEC50C0
        public void GetFieldOffset(){} // RVA: 0x7FFD4EEC5240
        public void OnEnable(){} // RVA: 0x7FFD4EEC5310
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E426850
        public void Start_96AFB855537C(){} // RVA: 0x7FFD4EEC53C0
        public void Decode(){} // RVA: 0x7FFD4EEC6900 | overloaded x2
        public void LateUpdate(){} // RVA: 0x7FFD4EEC5530
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EEC5770
        public void OnNetworkReady(){} // RVA: 0x7FFD4EEC59B0
        public void .ctor(){} // RVA: 0x7FFD4EEC59F0
        public void Initialize(){} // RVA: 0x7FFD4EEC5E00
        public void set_TypeId(){} // RVA: 0x7FFD4EEC5F80
        public void GetGameObject_9B2(){} // RVA: 0x7FFD4EEC63E0
        public void get_TypeId(){} // RVA: 0x7FFD4EEC6690
        public void Update(){} // RVA: 0x7FFD4EEC66A0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EEC66E0
        public void NeedsSync(){} // RVA: 0x7FFD4E409570
        public void NeedsImportant(){} // RVA: 0x7FFD4E341320
        public void Update_540CB71AC481(){} // RVA: 0x7FFD4E55BE20
        public void get_alreadySelecting(){} // RVA: 0x7FFD4EEC6AE0
        public void NeedsSync_CCF94E27A30D(){} // RVA: 0x7FFD4E409570
        public void Start(){} // RVA: 0x7FFD4EEC7A20
        public void GetIKSolver(){} // RVA: 0x7FFD4EEC7AC0
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E341320
        public void Awake(){} // RVA: 0x7FFD4EEC7B40
        public void Encode(){} // RVA: 0x7FFD4EEC8CF0 | overloaded x2
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EEC7C90
        public void GetGameObject_B49(){} // RVA: 0x7FFD4EEC8890
        public void GetFieldOffset_5BFDB549C292(){} // RVA: 0x7FFD4EEC5240
        public void OnDestroy(){} // RVA: 0x7FFD4EEC8960
        public void Update_1E914A16A244(){} // RVA: 0x7FFD4EEC8A90
        public void SetPosition(){} // RVA: 0x7FFD4EEC8C80
    }

    /// <summary>Originally: ÍÍÎÎÍÍÏÏÍÏÍÎÎÌÍÏÌÎÏÍÎÎÎ</summary>
    public class NetworkSyncable_656B : NetworkReadyHandler_68D0
    {
        public bool _uniqueHash; // 0x58
        public VRC.Udon.UdonBehaviour _typeId; // 0x60
        public ÍÎÎÎÍÎÍÏÏÌÎÍÎÏÏÏÎÏÏÎÏÎÎ[] f_8D0; // 0x68
        public VRC.Core.Networking.LimitedCapacityList`1<ÏÎÌÍÍÎÎÎÍÍÏÌÌÌÏÏÍÌÏÎÏÌÏ> f_ABC; // 0x70
        public ÏÎÌÍÍÎÎÎÍÍÏÌÌÌÏÏÍÌÏÎÏÌÏ f_DDB; // 0x78
        public bool f_ADC; // 0x80
        public ÏÎÌÍÍÎÎÎÍÍÏÌÌÌÏÏÍÌÏÎÏÌÏ ÍÌÍÍÌÌÏÎÏÍÍÏÌÏÌÍÌÍÏÍÎÍÌ; // 0x88
        public System.Collections.Generic.Dictionary`2<ÍÎÎÎÍÎÍÏÏÌÎÍÎÏÏÏÎÏÏÎÏÎÎ,int> ÎÏÍÎÎÏÎÍÌÏÌÌÏÌÍÎÏÍÍÎÍÌÍ; // 0x90

        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFD4E5E5CA0 | overloaded x2
        public void set_ValidExpressions(){} // RVA: 0x7FFD4E5E0430
        public void NeedsSync(){} // RVA: 0x7FFD4E5E0610
        public void GenerateComponentInfo(){} // RVA: 0x7FFD4E5E07D0
        public void SyncData(){} // RVA: 0x7FFD4E5E0CE0
        public void InvokeRepeating(){} // RVA: 0x7FFD4E5E12D0
        public void OnEnable(){} // RVA: 0x7FFD4E5E1440
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E5E1A30
        public void Start(){} // RVA: 0x7FFD4E5E1CD0
        public void SerializedName(){} // RVA: 0x7FFD4E5E1D70
        public void OnDestroy_E5EE5FD706E0(){} // RVA: 0x7FFD4E5E1EE0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E5E1F30
        public void OnNetworkReady(){} // RVA: 0x7FFD4E5E1FD0
        public void StopCoroutine(){} // RVA: 0x7FFD4E5E2430
        public void OnApplicationQuit(){} // RVA: 0x7FFD4E42F9E0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4E5E35E0
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E5E3820
        public void SetOverlay(){} // RVA: 0x7FFD4E5E39D0
        public void Decode(){} // RVA: 0x7FFD4E5E3DE0 | overloaded x2
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4E5E3C40
        public void set_UniqueHash(){} // RVA: 0x7FFD4E5E3F90
        public void get_hidden(){} // RVA: 0x7FFD4E5E41D0
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E426850
        public void GetInstanceID(){} // RVA: 0x7FFD4E5E43F0
        public void get_UniqueHash(){} // RVA: 0x7FFD4E5E4570
        public void CanUsePersistenceHashes(){} // RVA: 0x7FFD4E5E4580
        public void Update(){} // RVA: 0x7FFD4E55BE20
        public void set_TypeId(){} // RVA: 0x7FFD4E5E4D70
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD4E5E4DA0
        public void .ctor(){} // RVA: 0x7FFD4E5E4E10
        public void Initialize(){} // RVA: 0x7FFD4E5E4FF0
        public void get_TypeId(){} // RVA: 0x7FFD4E5E5240
        public void EmitRethrow(){} // RVA: 0x7FFD4E5E5350
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E5E54F0
        public void NeedsImportant(){} // RVA: 0x7FFD4E341320
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E5E55D0
        public void OnDestroy(){} // RVA: 0x7FFD4E5E1EE0
        public void InvokeVirtualInterface(){} // RVA: 0x7FFD4E5E5780
        public void GetInstanceID_B974F67B935C(){} // RVA: 0x7FFD4E5E5930
        public void Equals(){} // RVA: 0x7FFD4E5E5B00
        public void Awake(){} // RVA: 0x7FFD4E5E5D50
        public void OnNetworkUpdate(){} // RVA: 0x7FFD4E5E5D80
        public void SerializeState(){} // RVA: 0x7FFD4E5E5E60
        public void DeserializeState(){} // RVA: 0x7FFD4E5E5F50
    }

    /// <summary>Originally: ÎÏÌÌÌÌÍÏÏÍÏÎÍÍÏÎÍÌÌÍÍÏÎ</summary>
    public class NetworkSyncable_8A3D : NetworkReadyHandler_68D0
    {
        public VRC.SDK3.Components.VRCObjectPool _uniqueHash; // 0x58
        public byte[] _typeId; // 0x60
        public bool ÎÏÌÍÍÎÏÍÏÏÍÎÌÏÏÎÏÎÌÍÏÎÍ; // 0x68

        // ── Methods ──
        public void get_ValidExpressions(){} // RVA: 0x7FFD4F5B1A70
        public void NeedsSync(){} // RVA: 0x7FFD4E409570
        public void Encode(){} // RVA: 0x7FFD4F5B39A0 | overloaded x2
        public void set_UniqueHash(){} // RVA: 0x7FFD4F5B1C80
        public void OnSyncState(){} // RVA: 0x7FFD4E919180
        public void StopCoroutine(){} // RVA: 0x7FFD4F5B1F60
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E426850
        public void get_UniqueHash(){} // RVA: 0x7FFD4F5B2070
        public void Start_02F25AE11978(){} // RVA: 0x7FFD4F5B2080
        public void Decode(){} // RVA: 0x7FFD4F5B44E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4F5B2680
        public void Initialize(){} // RVA: 0x7FFD4F5B2700
        public void set_TypeId(){} // RVA: 0x7FFD4F5B2A10
        public void NeedsImportant(){} // RVA: 0x7FFD4E341320
        public void get_TypeId(){} // RVA: 0x7FFD4F5B2070
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F5B2CF0
        public void GetBufferedTimes(){} // RVA: 0x7FFD4F5B2F00
        public void CanUsePersistenceHashes(){} // RVA: 0x7FFD4F5B3600
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E426850
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F5B3A40
        public void Update(){} // RVA: 0x7FFD4E55BE20
        public void SerializedName(){} // RVA: 0x7FFD4F5B3A50
        public void Start(){} // RVA: 0x7FFD4F5B3BC0
        public void get_alreadySelecting(){} // RVA: 0x7FFD4F5B3C60
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFD4F5B4000
        public void GetIKSolver(){} // RVA: 0x7FFD4F5B47F0
        public void GenerateComponentInfo(){} // RVA: 0x7FFD4F5B4890
    }

    /// <summary>Originally: ÏÍÎÏÍÏÌÎÏÍÍÌÎÍÍÏÍÏÍÎÍÍÎ</summary>
    public class NetworkSyncable_D45C : NetworkReadyHandler_68D0
    {
        public UnityEngine.Animator _typeId; // 0x58
        public UnityEngine.Animation f_8D0; // 0x60
        public bool f_ABC; // 0x68
        public VRC.Core.Networking.LimitedCapacityList`1<VRC.Core.Networking.Tween.AnimationEvent> ÍÍÌÍÏÍÌÏÍÍÌÏÌÍÌÎÍÍÍÏÌÍÏ; // 0x70
        public VRC.Core.Networking.LimitedCapacityList`1<VRC.Core.Networking.Tween.AnimatorEvent> ÌÌÌÎÍÎÎÎÌÎÍÌÌÎÏÌÏÌÏÍÍÏÏ; // 0x78
        public float ÏÍÍÌÍÍÎÏÏÏÏÌÍÏÏÍÎÍÎÏÍÍÍ; // 0x80
        public VRC.Core.Networking.Tween.AnimationEvent ÏÏÌÎÍÏÌÌÏÏÏÍÏÌÎÍÏÌÎÎÎÌÌ; // 0x88
        public VRC.Core.Networking.Tween.AnimatorEvent ÌÌÍÌÌÎÌÍÏÎÍÎÍÎÎÌÌÏÏÏÌÍÏ; // 0x90

        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFD4F5FFC60 | overloaded x2
        public void set_ValidExpressions(){} // RVA: 0x7FFD4F5FCF20
        public void Decode(){} // RVA: 0x7FFD4F600D10 | overloaded x2
        public void AddSubtraction(){} // RVA: 0x7FFD4F5FE550
        public void AddSubtraction_D2DFE4C64695(){} // RVA: 0x7FFD4F5FE5E0
        public void InvokeRepeating(){} // RVA: 0x7FFD4F5FE780
        public void Awake(){} // RVA: 0x7FFD4F5FE920
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD4F5FF0E0
        public void Initialize(){} // RVA: 0x7FFD4F5FF2B0
        public void LateUpdate_296C28E95A39(){} // RVA: 0x7FFD4F600EC0 | overloaded x2
        public void OnDestroy_0048E988D155(){} // RVA: 0x7FFD4F5FFA40
        public void Update(){} // RVA: 0x7FFD4E55BE20
        public void Start(){} // RVA: 0x7FFD4F5FFA90
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F5FFB30
        public void get_Current(){} // RVA: 0x7FFD4F5FFB80
        public void NeedsSync(){} // RVA: 0x7FFD4E426850
        public void SetOverlay(){} // RVA: 0x7FFD4F5FFC20
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E426850
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4E341320
        public void set_TypeId(){} // RVA: 0x7FFD4F600740
        public void get_hidden(){} // RVA: 0x7FFD4F6009F0
        public void OnDestroy(){} // RVA: 0x7FFD4F5FFA40
        public void get_alreadySelecting(){} // RVA: 0x7FFD4F600B70
        public void get_TypeId(){} // RVA: 0x7FFD4EAC9850
        public void NeedsImportant(){} // RVA: 0x7FFD4E341320
        public void SerializedName(){} // RVA: 0x7FFD4F600D50
        public void ComputeparameterCoun(){} // RVA: 0x7FFD4F601B50
    }

    /// <summary>Originally: ÌÎÏÍÍÌÍÏÏÍÍÌÎÏÏÍÍÍÍÌÍÍÎ</summary>
    public class OVRLipSyncContextCannedSibling_7B88 : LifecycleComponent_9959
    {
        public UnityEngine.Transform ÌÎÏÌÌÌÍÌÍÌÏÏÏÌÍÍÏÍÌÏÌÎÌ; // 0x28
        public UnityEngine.UI.Graphic ÎÌÎÍÏÏÍÎÏÍÏÎÍÎÍÍÍÎÌÏÍÌÍ; // 0x30
        public UnityEngine.UI.Graphic ÍÏÏÍÎÎÍÍÎÍÍÌÍÌÏÌÏÎÏÌÏÎÍ; // 0x38
        public UnityEngine.UI.Graphic ÏÎÍÏÌÌÏÌÌÍÏÌÍÌÌÎÏÍÏÎÏÏÏ; // 0x40
        public UnityEngine.UI.Graphic ÏÍÎÌÌÍÍÍÏÌÌÏÏÏÍÍÎÏÏÏÎÎÌ; // 0x48
        public UnityEngine.UI.Graphic ÌÏÌÏÏÎÎÌÎÍÏÍÌÍÌÎÍÌÏÌÌÍÌ; // 0x50
        public UnityEngine.UI.Graphic ÎÌÌÏÎÌÏÌÎÌÎÏÎÌÍÎÏÎÎÎÌÎÎ; // 0x58

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F10A490
        public void RaiseCancellation(){} // RVA: 0x7FFD4F10AD20
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Start(){} // RVA: 0x7FFD4F10B5B0
        public void Initialize(){} // RVA: 0x7FFD4F10B9B0
        public void Update_940DE3A402D7(){} // RVA: 0x7FFD4F10BA50
        public void Update(){} // RVA: 0x7FFD4F10C2E0
        public void GetTransform_F24(){} // RVA: 0x7FFD4F10CB60
        public void UpdateLipSync(){} // RVA: 0x7FFD4F10B9B0
    }

    /// <summary>Originally: ÎÌÌÎÍÌÌÎÏÎÌÌÏÍÍÍÍÏÍÍÍÌÌ</summary>
    public class OVRLipSyncSiblingSibling_69E1 : LifecycleComponentSibling_D6FE
    {
        public UnityEngine.UI.RawImage captchaImage; // 0x148

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4F79B060
        public void Initialize_5162BAECEAA6(){} // RVA: 0x7FFD4F79B060
        public void .ctor(){} // RVA: 0x7FFD4EB29000
        public void CancelInvoke(){} // RVA: 0x7FFD4F79B060
        public void Initialize_D351DC14A642(){} // RVA: 0x7FFD4F79B060
        public void Initialize_B63649840D96(){} // RVA: 0x7FFD4F79B060
        public void Initialize_1B5EA1659B63(){} // RVA: 0x7FFD4F79B060
    }

    /// <summary>Originally: ÍÎÎÏÎÌÏÍÎÏÌÌÎÏÏÎÍÌÏÎÌÎÎ</summary>
    public class OVRLipSyncSibling_B774 : MonoBehaviour
    {
        public UnityEngine.RuntimeAnimatorController ÏÍÍÎÏÌÍÌÎÏÌÎÌÏÍÎÌÏÎÌÎÏÎ; // 0x20
        public UnityEngine.Transform ÍÏÏÍÎÍÍÎÎÍÌÍÏÍÌÎÌÌÏÍÎÎÍ; // 0x28
        public UnityEngine.Transform ÏÌÌÏÎÏÎÏÍÌÏÏÏÍÍÍÌÌÏÏÎÏÎ; // 0x30
        public UnityEngine.Transform ÍÍÎÎÌÌÍÎÌÍÌÎÍÎÍÎÏÏÏÍÏÏÌ; // 0x38
        public UnityEngine.Animator ÏÍÍÍÌÍÏÌÏÎÏÏÍÌÎÎÎÌÌÎÏÌÌ; // 0x40
        public RootMotion.FinalIK.VRIK ÍÌÍÏÏÏÎÌÏÏÌÏÌÌÍÍÎÍÌÏÎÌÎ; // 0x48
        public float ÌÌÍÎÍÍÌÎÏÏÏÌÎÍÎÏÏÍÏÌÎÌÍ; // 0x50
        public float ÎÏÌÌÏÏÏÍÎÍÎÍÏÎÌÏÍÌÎÎÍÌÍ; // 0x54

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F015E80
        public void RaiseCancellation(){} // RVA: 0x7FFD4F016FA0
        public void IsInvoking(){} // RVA: 0x7FFD4F0170C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F017420
        public void InvokeRepeating(){} // RVA: 0x7FFD4F016FA0
        public void CancelInvoke(){} // RVA: 0x7FFD4F016FA0
        public void RegisterCancellationOrCoroutine(){} // RVA: 0x7FFD4F0185A0
        public void StartCoroutine(){} // RVA: 0x7FFD4F018900
    }

    /// <summary>Originally: ÍÌÎÍÏÏÍÍÍÍÍÏÎÏÎÌÍÏÏÏÏÎÍ</summary>
    public class OVRLipSyncSibling_DFF0 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EFBBA00
        public void RaiseCancellation(){} // RVA: 0x7FFD4EFBBFF0
        public void IsInvoking(){} // RVA: 0x7FFD4EFBC5E0
        public void CancelInvoke(){} // RVA: 0x7FFD4EFBCBD0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4EFBD1C0
        public void Initialize_B63649840D96(){} // RVA: 0x7FFD4EFBD7B0
    }

    /// <summary>Originally: ÏÍÎÌÍÏÎÌÍÎÎÎÌÎÎÎÏÎÌÌÏÏÎ</summary>
    public class OVRLipSyncSibling_E227 : MonoBehaviour
    {
        public UnityEngine.Vector3 ÍÎÎÍÎÌÏÏÏÎÍÎÍÌÌÏÍÎÎÎÏÌÍ; // 0x20
        public UnityEngine.Transform ÍÍÏÏÎÎÏÎÌÎÌÍÍÏÌÎÎÍÍÍÍÌÌ; // 0x30
        public bool ÍÍÎÏÏÍÍÍÍÎÍÏÏÎÏÏÏÏÍÍÎÏÏ; // 0x38
        public UnityEngine.Vector3 ÍÎÎÍÏÎÍÎÏÍÎÌÎÎÎÎÌÏÏÌÍÌÏ; // 0x3C

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EF97640
        public void RaiseCancellation(){} // RVA: 0x7FFD4EF978E0
        public void IsInvoking(){} // RVA: 0x7FFD4EF97AC0
        public void CancelInvoke(){} // RVA: 0x7FFD4EF97D60
        public void Invoke(){} // RVA: 0x7FFD4EF978E0
        public void InvokeRepeating(){} // RVA: 0x7FFD4EF978E0
        public void Update(){} // RVA: 0x7FFD4EF978E0
        public void .ctor_296C28E95A39(){} // RVA: 0x7FFD4EF978E0
        public void .ctor(){} // RVA: 0x7FFD4EF98000
        public void Initialize(){} // RVA: 0x7FFD4EF98090
    }

    /// <summary>Originally: ÍÏÍÏÎÏÎÍÏÎÎÌÍÍÌÌÏÏÎÎÌÏÌ</summary>
    public class PhotonConnectionHandlerSiblingSibling_3076 : Object
    {
        public string _name; // 0x10
        public ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ _hideFlags; // 0x18
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ> f_E90; // 0x20
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_5F1; // 0x28
        public string f_2A4; // 0x30
        public bool <ÍÎÍÎÎÌÏÏÏÍÍÍÌÎÍÎÎÎÏÍÏÍÏ>k__BackingField; // 0x38

        // ── Methods ──
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void Equals(){} // RVA: 0x7FFD4E36F0C0
        public void GetHashCode(){} // RVA: 0x7FFD4EAFFDF0
        public void op_Implicit(){} // RVA: 0x7FFD4EAFFE10
        public void .ctor(){} // RVA: 0x7FFD4EB003B0
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void get_name(){} // RVA: 0x7FFD4E36F890
        public void IsResource(){} // RVA: 0x7FFD4E5F95D0
        public void Instantiate(){} // RVA: 0x7FFD4EAFFDF0
        public void ToString(){} // RVA: 0x7FFD4EAFFDF0
        public void .cctor(){} // RVA: 0x7FFD4E342E90
        public void ToString_8FA2130B40A2(){} // RVA: 0x7FFD4E342E30
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void OnConnected(){} // RVA: 0x7FFD4E35C380
        public void GetActiveInHierarchy_E12(){} // RVA: 0x7FFD4E5F95D0
        public void AddUnitNode_80DE6458B5D9(){} // RVA: 0x7FFD4E36F890
    }

    /// <summary>Originally: ÏÏÌÍÎÌÍÌÎÏÎÏÎÏÌÌÍÎÏÏÌÌÎ</summary>
    public class PhotonConnectionHandlerSiblingSibling_9D6D
    {
        public object f_4F1;
        public object f_4BC;
        public object f_01E;
        public object f_2C9;
        public object f_FBB;
        public object f_86D;
        public object f_E90;
        public object f_3EE;
        public object f_7EC;
        public object f_E91;
        public object f_0B2;
        public object f_990;
        public object f_6C6;
        public object f_257;

        // ── Methods ──
        public void GetLast(){} // RVA: 0x7FFD4E078E90
        public void GetLast_E941DF1E792B(){} // RVA: 0x7FFD4E078E90
        public void GetLast_D6394369B346(){} // RVA: 0x7FFD4E078E90
        public void QueuePhotonConnectionTask(){} // RVA: 0x7FFD4E078E90
        public void GetLast_A5C1FFC70DCA(){} // RVA: 0x7FFD4E078E90
        public void PollPhotonConnection(){} // RVA: 0x7FFD4E078E90
        public void ProcessPhotonConnection(){} // RVA: 0x7FFD4E078E90
        public void GetLast_B09C48BC227C(){} // RVA: 0x7FFD4E078E90
        public void GetLast_552AB1B2135C(){} // RVA: 0x7FFD4E078E90
        public void RefreshPhotonConnection(){} // RVA: 0x7FFD4E078E90
        public void UpdatePhotonConnectionState(){} // RVA: 0x7FFD4E078E90
        public void GetLast_715D67B149C7(){} // RVA: 0x7FFD4E078E90
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void GetLast_74488E2DC65A(){} // RVA: 0x7FFD4E078E90
        public void ContainsChild_F8216ED5818D(){} // RVA: 0x7FFD4E090A40
        public void UnboxThunk(){} // RVA: 0x7FFD4E090980
        public void UnboxThunk_E75990743388(){} // RVA: 0x7FFD4E079D00
    }

    /// <summary>Originally: ÏÌÎÌÎÌÏÎÏÌÌÌÏÎÏÍÌÏÏÍÍÍÍ</summary>
    public class PhotonConnectionHandlerSiblingSibling_B6DC : Object
    {
        public string _name; // 0x10
        public string _hideFlags; // 0x18
        public string f_BB5; // 0x20
        public ÎÎÌÏÌÌÎÌÍÏÌÌÍÌÏÏÌÍÍÍÏÎÌ<ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ> f_4BC; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4EC2D1D0
        public void Equals(){} // RVA: 0x7FFD4EC2D1E0
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void op_Implicit(){} // RVA: 0x7FFD4E35C380
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EC2D470
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EC2D5B0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void get_name(){} // RVA: 0x7FFD4E36F0C0
        public void set_name(){} // RVA: 0x7FFD4E36F130
        public void Instantiate(){} // RVA: 0x7FFD4E3447C0
        public void GetHashCode(){} // RVA: 0x7FFD4EC2D1D0
        public void .cctor(){} // RVA: 0x7FFD4E36F130
        public void .ctor(){} // RVA: 0x7FFD4EC2D6F0
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void ToString(){} // RVA: 0x7FFD4E3A7E80
        public void AddSubtraction_E009047AABDC(){} // RVA: 0x7FFD4E342E90
        public void GetName(){} // RVA: 0x7FFD4E36F0C0
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
    }

    /// <summary>Originally: ÌÎÏÏÌÍÌÌÍÌÌÎÌÌÌÍÎÎÍÍÎÏÏ</summary>
    public class PhotonConnectionHandlerSibling_CE19 : Object
    {
        public ÌÎÏÍÌÏÏÍÏÌÌÍÏÌÍÏÍÍÌÏÍÍÏ _name; // 0x10
        public ÏÎÏÍÌÎÌÍÎÏÍÌÎÎÎÏÌÌÏÏÌÍÍ _hideFlags; // 0x18
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_01E; // 0x20
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_2C9; // 0x28
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_FBB; // 0x30
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_86D; // 0x38
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_E90; // 0x40
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_3EE; // 0x48
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> f_7EC; // 0x50
        public System.Action`1<ÍÎÏÎÌÌÌÎÍÏÎÌÏÎÍÏÌÏÏÌÎÍÌ> f_E91; // 0x58
        public System.Action`1<ÍÎÏÎÌÌÌÎÍÏÎÌÏÎÍÏÌÏÏÌÎÍÌ> f_0B2; // 0x60

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E426850
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EB8BB40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E35C380
        public void SetResources(){} // RVA: 0x7FFD4E409510
        public void set_trackerAnchor(){} // RVA: 0x7FFD4E3DF380
        public void set_name(){} // RVA: 0x7FFD4E3447C0
        public void Instantiate(){} // RVA: 0x7FFD4E36F0C0
        public void Equals(){} // RVA: 0x7FFD4EB8BB80
        public void GetHashCode(){} // RVA: 0x7FFD4E3DF380
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void ToString(){} // RVA: 0x7FFD4E3BE740
        public void set_element(){} // RVA: 0x7FFD4E5F0C20
        public void HandlePhotonConnection(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4EB8BBC0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void DestroyImmediate(){} // RVA: 0x7FFD4E5F0C20
        public void SetModelShader(){} // RVA: 0x7FFD4E3BC740
        public void SetModelAlphaBlendShader(){} // RVA: 0x7FFD4E4994D0
        public void SetOverlay(){} // RVA: 0x7FFD4E369200
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4EB8C170
        public void get_hideFlags(){} // RVA: 0x7FFD4E36F0C0
        public void set_hideFlags(){} // RVA: 0x7FFD4E3BC730
        public void FindObjectsByType(){} // RVA: 0x7FFD4E36F130
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4E341320
        public void Initialize(){} // RVA: 0x7FFD4E342E30
    }

    /// <summary>Originally: ÌÎÌÎÎÏÍÌÌÍÎÎÎÎÏÍÌÏÎÍÌÏÍ</summary>
    public class PhotonConnectionHandler_0081 : MonoBehaviour
    {
        public string _destroyCancellationToken;
        public int _useGUILayout;
        public ÌÎÌÎÎÏÍÌÌÍÎÎÎÎÏÍÌÏÎÍÌÏÍ f_0AD;
        public VRC.Localization.LocalizableString f_B5B; // 0x20
        public 0x66377E78 f_586; // 0x48
        public System.Nullable`1<float> ÌÌÌÏÎÍÏÎÎÌÎÏÏÍÍÏÌÎÍÌÎÌÎ; // 0x4C
        public float ÏÏÏÎÌÍÎÍÎÏÎÍÌÎÌÍÌÎÌÏÍÌÍ;
        public System.Nullable`1<0x66415260> ÎÏÌÏÏÎÎÍÏÌÍÌÍÌÌÏÏÏÍÏÌÍÌ; // 0x54
        public int ÍÌÎÏÏÌÏÎÍÍÏÏÏÎÏÍÍÍÎÎÍÍÎ;
        public string ÏÍÍÎÍÎÌÍÍÍÍÏÏÏÎÎÏÎÌÎÎÎÏ;
        public bool ÍÏÍÏÍÍÌÎÍÍÏÌÍÍÎÍÏÏÏÍÌÏÏ; // 0x5C

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F1B0D30
        public void OnDestroy(){} // RVA: 0x7FFD4F1B0DF0
        public void IsInvoking(){} // RVA: 0x7FFD4F1B1540
        public void OnConnectedToMaster(){} // RVA: 0x7FFD4F1B15A0
        public void Invoke(){} // RVA: 0x7FFD4F1B1750
        public void InvokeRepeating(){} // RVA: 0x7FFD4F1B1C90
        public void CancelInvoke(){} // RVA: 0x7FFD4E909F20
        public void OnCollisionStay(){} // RVA: 0x7FFD4F1B2490
        public void StartCoroutine(){} // RVA: 0x7FFD4F1B28E0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F1B2A70
        public void OnTriggerStay(){} // RVA: 0x7FFD4F1B2C90
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F1B2DD0
        public void StopCoroutine(){} // RVA: 0x7FFD4F1B2EF0
        public void MoveNext(){} // RVA: 0x7FFD4F1B3000
        public void GetHashCode(){} // RVA: 0x7FFD4F1B31D0
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F1B3210
        public void get_source(){} // RVA: 0x7FFD4E90A3D0
        public void set_LostPackagesOut(){} // RVA: 0x7FFD4E3E20D0
        public void OnDisable(){} // RVA: 0x7FFD4F1B32B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F1B3310
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F1B33C0
        public void InvokeDelayed(){} // RVA: 0x7FFD4F1B34C0
        public void OnBecameVisible(){} // RVA: 0x7FFD4F1B35D0
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F1B3650
        public void OnCustomAuthenticationFailed(){} // RVA: 0x7FFD4F1B3710
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F1B38B0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F1B3970
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4F1B47A0
        public void OnEnable(){} // RVA: 0x7FFD4F1B49C0
        public void GetScriptClassName(){} // RVA: 0x7FFD4F1B4A20
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F1B4AD0
        public void Start(){} // RVA: 0x7FFD4F1B4B20
        public void Update(){} // RVA: 0x7FFD4F1B4BC0
        public void HandlePhotonConnection(){} // RVA: 0x7FFD4F1B4BD0
        public void LateUpdate(){} // RVA: 0x7FFD4F1B4DA0
        public void Awake(){} // RVA: 0x7FFD4F1B5050
        public void OnApplicationQuit(){} // RVA: 0x7FFD4F1B5240
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4F1B5280
        public void OnCollisionEnter(){} // RVA: 0x7FFD4F1B5410
        public void print(){} // RVA: 0x7FFD4F1B6E10
        public void OnCollisionExit(){} // RVA: 0x7FFD4F1B6FE0
        public void CalculateLostPackages(){} // RVA: 0x7FFD4F1B7050
        public void OnApplicationPause(){} // RVA: 0x7FFD4F1B70F0
        public void OnTriggerExit(){} // RVA: 0x7FFD4F1B35D0
        public void GetStatus(){} // RVA: 0x7FFD4E3E20C0
    }

    /// <summary>Originally: ÎÏÍÍÌÌÌÍÏÎÎÏÌÌÌÏÌÏÌÎÎÍÏ</summary>
    public class PhotonConnectionHandler_A702
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFD4E090980
        public void OnConnectedToMaster(){} // RVA: 0x7FFD4E090980
        public void Process(){} // RVA: 0x7FFD4E090ED0
        public void OnReceive(){} // RVA: 0x7FFD4E090A40
        public void OnCustomAuthenticationResponse(){} // RVA: 0x7FFD4E090A40
        public void OnCustomAuthenticationFailed(){} // RVA: 0x7FFD4E090A40
    }

    /// <summary>Originally: ÎÏÌÏÌÍÏÍÎÍÌÌÏÎÍÏÍÌÏÏÎÎÎ</summary>
    public class PhotonConnectionHandler_AB56 : List`1
    {
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ ÎÌÍÌÎÏÍÎÎÍÏÎÏÌÍÏÌÎÍÎÏÎÍ; // 0x28

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E341310
        public void HandlePhotonConnection(){} // RVA: 0x7FFD4E341310
        public void HandleConnection(){} // RVA: 0x7FFD4F988840
        public void get_Capacity(){} // RVA: 0x7FFD4F988BB0
        public void set_Capacity(){} // RVA: 0x7FFD4F988F20
        public void get_Count(){} // RVA: 0x7FFD4F989220
        public void OnConnectedToMaster(){} // RVA: 0x7FFD4F989510
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4F989790
        public void OnCustomAuthenticationFailed(){} // RVA: 0x7FFD4F989B50
        public void .ctor(){} // RVA: 0x7FFD4F989EC0
        public void Initialize(){} // RVA: 0x7FFD4F989F80
        public void get_Item(){} // RVA: 0x7FFD4F98A200
        public void OnCustomAuthenticationResponse(){} // RVA: 0x7FFD4F98A5C0
    }

    /// <summary>Originally: ÎÌÍÏÌÌÌÍÌÎÎÍÍÏÏÏÏÏÏÎÎÍÎ</summary>
    public class PhotonHashtableDerived_31E3 : PhotonHashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F9C8370
    }

    /// <summary>Originally: ÏÏÌÍÌÌÏÍÌÎÌÎÎÎÏÏÎÏÎÍÏÌÌ</summary>
    public class PhotonMasterHandlerSiblingSibling_87E7
    {
        public object f_6ED;
        public object f_31E;
        public object f_E08;

        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFD4E090A40
        public void Process(){} // RVA: 0x7FFD4E090A40
        public void OnReceive(){} // RVA: 0x7FFD4E078E90
        public void OnEvent(){} // RVA: 0x7FFD4E078E90
        public void GetLast(){} // RVA: 0x7FFD4E078E90
    }

    /// <summary>Originally: ÌÏÏÌÎÏÍÌÏÌÌÏÍÌÍÎÎÏÏÌÍÎÏ</summary>
    public class PhotonMasterHandlerSibling_32EF : Object
    {
        public ÏÍÎÎÎÌÏÍÎÎÎÌÌÏÎÍÏÍÍÎÏÍÌ<ÌÎÏÌÏÏÏÎÍÌÍÌÍÍÍÎÏÌÌÎÏÏÎ> _name; // 0x10
        public ÏÍÎÎÎÌÏÍÎÎÎÌÌÏÎÍÏÍÍÎÏÍÌ<ÌÎÏÌÏÏÏÎÍÌÍÌÍÍÍÎÏÌÌÎÏÏÎ> _hideFlags; // 0x18
        public ÏÍÎÎÎÌÏÍÎÎÎÌÌÏÎÍÏÍÍÎÏÍÌ<ÌÎÏÌÏÏÏÎÍÌÍÌÍÍÍÎÏÌÌÎÏÏÎ> f_E08; // 0x20
        public System.Action ÏÍÌÌÍÍÍÌÎÎÌÌÏÌÎÏÌÎÎÌÌÍÏ; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E3447C0
        public void Equals(){} // RVA: 0x7FFD4E36F0C0
        public void Initialize(){} // RVA: 0x7FFD4E342E30
        public void Init(){} // RVA: 0x7FFD4E3A7E80
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EB91DD0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EB91EC0
        public void OnPointerExit(){} // RVA: 0x7FFD4EB91FB0
        public void .ctor(){} // RVA: 0x7FFD4EB91FD0
        public void set_name(){} // RVA: 0x7FFD4E36F0C0
        public void Instantiate(){} // RVA: 0x7FFD4E36F0C0
        public void GetHashCode(){} // RVA: 0x7FFD4EB92180
        public void GetHashCode_394BA3C06F01(){} // RVA: 0x7FFD4E342E30
        public void Computerotation_Inj(){} // RVA: 0x7FFD4E36F0D0
        public void ToString(){} // RVA: 0x7FFD4E36F0D0
        public void Awake(){} // RVA: 0x7FFD4E35C380
    }

    /// <summary>Originally: ÎÎÍÎÍÎÏÍÌÎÍÌÏÌÌÏÍÍÏÎÌÏÌ</summary>
    public class PhotonMasterHandler_A1CC
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFD4E090A40
        public void Process(){} // RVA: 0x7FFD4E090A40
        public void OnReceive(){} // RVA: 0x7FFD4E090A40
        public void OnEvent(){} // RVA: 0x7FFD4E099B30
        public void OnMasterClientSwitched(){} // RVA: 0x7FFD4E090A40
    }

    /// <summary>Originally: ÌÌÍÍÌÎÏÍÏÍÎÍÏÌÏÎÎÏÌÌÍÌÏ</summary>
    public class PhotonMasterHandler_B82D : List`1
    {
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ ÎÌÍÌÎÏÍÎÎÍÏÎÏÌÍÏÌÎÍÎÏÎÍ; // 0x28

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4F98D300
        public void OnMasterClientSwitched(){} // RVA: 0x7FFD4F98D5B0
        public void Contains(){} // RVA: 0x7FFD4F98D8A0
        public void .ctor(){} // RVA: 0x7FFD4F98DB90
        public void Initialize(){} // RVA: 0x7FFD4F98DC50
        public void get_Count(){} // RVA: 0x7FFD4F98DF30
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4F98E210
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4F98E500
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4F98E7B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4F98EAA0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4F98ED90
        public void get_Item(){} // RVA: 0x7FFD4F98F080
    }

    /// <summary>Originally: ÎÎÎÎÌÍÏÌÌÎÍÍÎÍÏÌÌÌÌÍÌÎÏ</summary>
    public class PhotonRoomHandler_25C7 : ConnectionHandler
    {
        public ÎÎÎÎÌÍÏÌÌÎÍÍÎÍÏÌÌÌÌÍÌÎÏ ÍÎÍÏÍÎÍÏÍÌÌÎÏÍÍÌÎÌÏÌÍÌÏ;
        public int ÌÏÌÍÏÎÏÎÎÌÌÏÏÎÏÌÎÍÏÏÌÍÌ; // 0x58
        public int ÏÎÏÌÌÍÎÎÍÏÌÍÏÏÍÌÏÍÍÏÎÎÌ; // 0x5C
        public int ÏÎÍÍÌÍÍÎÎÏÎÍÌÏÍÏÏÍÌÌÍÏÍ; // 0x60
        public int ÍÎÌÍÏÎÏÍÎÌÏÍÍÍÎÏÍÌÌÌÌÎÍ; // 0x64
        public VRC.Profiling.ProfilerMarker ÏÏÌÌÍÏÎÏÍÍÍÌÍÌÌÎÎÍÌÌÏÌÏ; // 0x8
        public VRC.Profiling.ProfilerMarker ÎÏÏÎÏÏÏÏÏÎÌÏÍÌÎÎÏÏÎÎÎÎÍ; // 0x18
        public VRC.Profiling.ProfilerMarker ÏÎÌÌÎÏÏÎÎÍÏÏÍÍÏÍÎÏÏÎÍÏÏ; // 0x28
        public int ÎÍÍÎÏÏÌÎÍÎÎÎÌÏÍÍÍÏÏÏÏÌÎ; // 0x38
        public bool ÍÍÎÎÎÎÎÏÏÌÍÎÌÎÎÌÍÌÎÎÏÍÌ; // 0x3C
        public int ÏÍÌÎÍÎÎÎÎÍÌÌÍÎÎÎÌÏÍÍÎÎÎ;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E341310
        public void OnJoinedRoom(){} // RVA: 0x7FFD4E341310
        public void IsInvoking(){} // RVA: 0x7FFD4E341310
        public void CancelInvoke(){} // RVA: 0x7FFD4E341310
        public void OnDisable_3695460B40D7(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4F9590E0
        public void Start(){} // RVA: 0x7FFD4F9591C0
        public void OnMasterClientSwitched(){} // RVA: 0x7FFD4E341310
        public void StartCoroutine(){} // RVA: 0x7FFD4E341310
        public void OnDisable(){} // RVA: 0x7FFD4F959330
        public void GetFileLineNumber(){} // RVA: 0x7FFD4E341310
        public void AssignPhotonRoomBody(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void StopCoroutine(){} // RVA: 0x7FFD4E341310
        public void OnCreatedRoom(){} // RVA: 0x7FFD4E341310
        public void OnLeftRoom(){} // RVA: 0x7FFD4E341310
        public void LateUpdate(){} // RVA: 0x7FFD4F959390
        public void set_useGUILayout(){} // RVA: 0x7FFD4E341310
        public void OnEnable(){} // RVA: 0x7FFD4F9596E0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4E341310
        public void FixedUpdate(){} // RVA: 0x7FFD4F959740
        public void Awake(){} // RVA: 0x7FFD4F959B60
        public void .cctor(){} // RVA: 0x7FFD4F95A0B0
        public void Start_CA57BA303BB0(){} // RVA: 0x7FFD4E341310
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E341310
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4E341310
    }

    /// <summary>Originally: ÍÍÎÎÍÍÍÌÎÏÍÏÍÌÍÏÏÎÍÏÌÏÍ</summary>
    public class PhotonRoomHandler_D258
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFD4E090A40
        public void OnCreatedRoom(){} // RVA: 0x7FFD4E090980
        public void Process(){}
        public void OnJoinedRoom(){} // RVA: 0x7FFD4E090980
        public void OnReceive(){}
        public void OnEvent(){}
        public void OnLeftRoom(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÍÏÌÎÏÎÏÎÌÌÌÍÎÏÍÍÎÌÎÍÏÍÌ</summary>
    public class PhotonRoomHandler_F649 : List`1
    {
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ ÎÌÍÌÎÏÍÎÎÍÏÎÏÌÍÏÌÎÍÎÏÎÍ; // 0x28

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4F98A8B0
        public void Contains(){} // RVA: 0x7FFD4F98AB30
        public void OnCreatedRoom(){} // RVA: 0x7FFD4F98AE10
        public void OnJoinedRoom(){} // RVA: 0x7FFD4F98B090
        public void set_Capacity(){} // RVA: 0x7FFD4F98B310
        public void get_Count(){} // RVA: 0x7FFD4F98B710
        public void .ctor(){} // RVA: 0x7FFD4F98B9F0
        public void Initialize(){} // RVA: 0x7FFD4F98BAB0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4F98BDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4F98C040
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4F98C440
        public void get_Item(){} // RVA: 0x7FFD4F98C720
        public void set_Item(){} // RVA: 0x7FFD4F98CA00
        public void OnLeftRoom(){} // RVA: 0x7FFD4F98CC80
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4F98CF00
    }

    /// <summary>Originally: ÍÌÌÎÍÏÎÏÏÌÎÌÏÍÎÏÍÌÌÎÏÍÎ</summary>
    public class VRCNetworkBehaviour : NetworkReadyHandler_68D0
    {
        public VRC.SDKBase.VRC_DataStorage _typeId; // 0x58
        public System.Collections.Generic.Dictionary`2<string,int> ÌÌÎÎÎÍÍÍÍÌÏÏÎÍÎÎÏÏÌÌÍÌÎ; // 0x60
        public UnityEngine.Animator ÎÎÍÌÌÎÎÌÍÌÎÏÍÎÌÎÏÌÍÌÍÎÏ; // 0x68
        public bool ÎÏÌÍÍÎÏÍÏÏÍÎÌÏÏÎÏÎÌÍÏÎÍ; // 0x70

        // ── Methods ──
        public void ComputegameObject(){} // RVA: 0x7FFD4F625AB0
        public void DoRequest_Internal_Texture_1_Injected_1E1(){} // RVA: 0x7FFD4F625DB0
        public void Encode_sub(){} // RVA: 0x7FFD4F626380
        public void OnCollisionEnter_2D781DD7C4C1(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E341320
        public void set_TypeId_108D3B62727A(){} // RVA: 0x7FFD4F629290 | overloaded x2
        public void OnNetworkReady(){} // RVA: 0x7FFD4F6264D0
        public void get_TypeId(){} // RVA: 0x7FFD4F626550
        public void Decode(){} // RVA: 0x7FFD4F627A20 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD4F6265A0
        public void SerializedName(){} // RVA: 0x7FFD4F6267B0
        public void WasLastEyeDataValid(){} // RVA: 0x7FFD4E3BD320
        public void Awake(){} // RVA: 0x7FFD4E090A40
        public void Start(){} // RVA: 0x7FFD4F626920
        public void Update(){} // RVA: 0x7FFD4E55BE20
        public void NeedsSync(){} // RVA: 0x7FFD4E3BD320
        public void LateUpdate(){} // RVA: 0x7FFD4F6269C0
        public void OnDisable(){} // RVA: 0x7FFD4F627130
        public void OnApplicationQuit_33ABE28C7140(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void OnApplicationPause(){} // RVA: 0x7FFD4F627920
        public void NeedsImportant(){} // RVA: 0x7FFD4E341320
        public void OnCollisionStay(){} // RVA: 0x7FFD4F628160
        public void .ctor(){} // RVA: 0x7FFD4F628730
        public void Encode(){} // RVA: 0x7FFD4F629060 | overloaded x2
        public void OnTriggerStay(){} // RVA: 0x7FFD4E341320
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E426850
        public void GetGameObject(){} // RVA: 0x7FFD4F6290A0
        public void OnDestroy(){} // RVA: 0x7FFD4F6291A0
        public void GetGameObject_A35(){} // RVA: 0x7FFD4F6291E0
        public void OnBecameVisible(){} // RVA: 0x7FFD4F629780
    }

    /// <summary>Originally: ÍÍÎÏÏÎÎÏÍÌÌÍÍÏÌÎÎÎÌÎÍÎÍ</summary>
    public class VRCNetworkBehaviourBase : NetworkReadyHandler_68D0
    {
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ _typeId; // 0x58
        public int f_8D0;
        public System.Collections.Generic.List`1<ÎÏÏÎÏÏÎÍÍÎÌÌÏÏÏÌÌÌÌÌÍÏÍ> f_BB3; // 0x60
        public System.Collections.Generic.HashSet`1<uint> f_08A; // 0x68
        public bool ÌÌÎÍÎÎÎÌÎÏÎÌÏÍÌÏÌÍÌÌÏÌÌ; // 0x70

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E5B5650
        public void Update(){} // RVA: 0x7FFD4E5B56F0
        public void Update_540CB71AC481(){} // RVA: 0x7FFD4E55BE20
        public void set_TypeId(){} // RVA: 0x7FFD4E5B5750
        public void CanUsePersistenceHashes(){} // RVA: 0x7FFD4E5B5810
        public void Awake(){} // RVA: 0x7FFD4E5B59F0
        public void OnApplicationPause(){} // RVA: 0x7FFD4E5B5EA0
        public void get_TypeId(){} // RVA: 0x7FFD4E5B5EF0
        public void NeedsImportant(){} // RVA: 0x7FFD4E3BD320
        public void OnBecameInvisible(){} // RVA: 0x7FFD4E5B5F00
        public void OnEnable(){} // RVA: 0x7FFD4E5B6160
        public void OnCollisionStay(){} // RVA: 0x7FFD4E5B6340
        public void OnDestroy(){} // RVA: 0x7FFD4E5B6500
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E341320
        public void Decode(){} // RVA: 0x7FFD4E5B8620 | overloaded x2
        public void OnDisable(){} // RVA: 0x7FFD4E5B6BC0
        public void Encode(){} // RVA: 0x7FFD4E5B7800 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E5B7070
        public void CanSerialize8Bit(){} // RVA: 0x7FFD4E341320
        public void OnBecameVisible(){} // RVA: 0x7FFD4E5B7220
        public void GenerateComponentInfo(){} // RVA: 0x7FFD4E5B7390
        public void NeedsSync(){} // RVA: 0x7FFD4E3BD320
        public void OnTriggerExit(){} // RVA: 0x7FFD4E341320
        public void OnCollisionExit(){} // RVA: 0x7FFD4E5B6500
        public void GetGameObject_1AE(){} // RVA: 0x7FFD4E5B7540
        public void OnTriggerStay(){} // RVA: 0x7FFD4E5B75A0
        public void SerializedName(){} // RVA: 0x7FFD4E5B7750
        public void CanSerialize32Bit(){} // RVA: 0x7FFD4E426850
        public void DoBitUnpack(){} // RVA: 0x7FFD4E5B7790
        public void ComputegameObject(){} // RVA: 0x7FFD4E5B77A0
        public void EncodeComponentState(){} // RVA: 0x7FFD4E5B7DD0
        public void DecodeComponentState(){} // RVA: 0x7FFD4E5B7E10
        public void GetNetworkComponentGameObject(){} // RVA: 0x7FFD4E5B7FC0
    }

    /// <summary>Originally: ÍÌÏÌÌÌÌÏÌÏÎÍÎÎÎÎÌÌÍÍÌÍÏ</summary>
    public class VRCNetworkBehaviourSiblinRelated_673C : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F4A1E60
        public void Equals(){} // RVA: 0x7FFD4F4A1EC0
        public void GetHashCode(){} // RVA: 0x7FFD4F4A1F20
        public void op_Implicit(){} // RVA: 0x7FFD4F4A1F80
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F4A1FE0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4F4A2040
        public void get_name(){} // RVA: 0x7FFD4F4A20A0
        public void set_name(){} // RVA: 0x7FFD4F4A2100
        public void Instantiate(){} // RVA: 0x7FFD4F4A2160
    }

    /// <summary>Originally: ÏÍÌÎÍÎÏÍÎÍÎÍÎÍÎÌÏÌÌÎÏÌÍ</summary>
    public class VRCNetworkBehaviourSiblinRelated_B611 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4ECCE600
        public void Equals(){} // RVA: 0x7FFD4ECCE600
        public void GetHashCode(){} // RVA: 0x7FFD4ECCE600
        public void op_Implicit(){} // RVA: 0x7FFD4ECCE600
        public void CompareBaseObjects(){} // RVA: 0x7FFD4ECCE600
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4ECCE600
        public void GetCachedPtr(){} // RVA: 0x7FFD4ECCE600
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4ECCE600
    }

    /// <summary>Originally: ÎÎÏÌÌÏÎÏÏÏÍÍÏÍÎÍÎÍÍÌÍÎÏ</summary>
    public class VRCNetworkBehaviourSiblinRelated_E2BA : ValueType
    {
        public ushort ÌÍÍÍÎÌÏÏÎÍÌÏÍÌÍÏÍÌÏÍÍÍÎ; // 0x10
        public ushort ÍÎÍÏÍÎÎÎÍÏÎÎÎÌÎÏÎÎÎÎÏÌÏ; // 0x12
        public ushort ÍÎÏÏÌÎÎÌÎÌÌÏÌÌÏÌÏÍÏÌÍÌÎ; // 0x14

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4F9B0620
        public void InternalEquals(){} // RVA: 0x7FFD4F9B06E0
        public void DefaultEquals(){} // RVA: 0x7FFD4F9B07A0
        public void GetHashCode(){} // RVA: 0x7FFD4F9B0860
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F9B0920
        public void ToString(){} // RVA: 0x7FFD4F9B09E0
    }

    /// <summary>Originally: ÎÍÎÎÏÍÌÌÍÏÏÎÌÍÏÎÌÎÎÍÌÏÍ</summary>
    public class VRCNetworkBehaviourSiblinRelated_F64A : Object
    {
        // ── Methods ──
        public void set_name(){} // RVA: 0x7FFD4F7F7BB0
        public void op_Implicit(){} // RVA: 0x7FFD4F7F7C90
        public void Equals(){} // RVA: 0x7FFD4F7F7E00
        public void Initialize(){} // RVA: 0x7FFD4F7F7F70
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Instantiate(){} // RVA: 0x7FFD4F7F8050
        public void get_name(){} // RVA: 0x7FFD4F7F80C0
        public void GetHashCode(){} // RVA: 0x7FFD4F7F81A0
    }

    /// <summary>Originally: ÎÍÏÌÍÎÌÌÌÏÏÏÍÌÌÏÌÌÍÎÎÍÌ</summary>
    public class VRCNetworkBehaviourSiblinRelated_FBC6 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4ECCE600
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4ECCE600
        public void op_Implicit(){} // RVA: 0x7FFD4ECCE600
        public void CompareBaseObjects(){} // RVA: 0x7FFD4ECCE600
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4ECCE600
        public void GetCachedPtr(){} // RVA: 0x7FFD4ECCE600
        public void get_name(){} // RVA: 0x7FFD4ECCE600
    }

    /// <summary>Originally: ÏÏÏÍÌÌÍÎÎÍÏÎÍÏÍÎÌÌÌÎÎÌÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_1CFA : Object
    {
        public ÎÎÎÏÌÌÍÏÎÍÎÌÎÌÌÏÌÌÍÌÎÏÏ _name; // 0x10
        public int _hideFlags; // 0x18
        public ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ f_09A; // 0x20
        public bool f_986; // 0x28
        public bool f_A6E; // 0x29
        public string f_823; // 0x30
        public string f_E4A; // 0x38
        public bool f_DFC; // 0x40
        public Photon.Client.PhotonHashtable <ÏÌÌÏÏÏÏÏÌÎÎÌÎÌÍÍÌÍÎÏÌÌÎ>k__BackingField; // 0x48
        public object ÏÎÍÏÌÌÎÌÎÎÏÌÎÎÏÍÏÍÎÌÌÍÌ; // 0x50

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD4E577800
        public void DoRequest_Internal_Texture_1_Injected_1E1(){} // RVA: 0x7FFD4F9AF1D0
        public void ToString(){} // RVA: 0x7FFD4F9AF1F0
        public void op_Implicit(){} // RVA: 0x7FFD4E35C380
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F9AF2A0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F9AF4E0
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BC730
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFD4E3FCC10
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void Instantiate(){} // RVA: 0x7FFD4F9AF510
        public void GetHashCode_2C8E9BCEF691(){} // RVA: 0x7FFD4E577800
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void Awake(){} // RVA: 0x7FFD4E35C380
        public void Start(){} // RVA: 0x7FFD4F9AF5E0
        public void VRCSetAvatarMainIK_BC59B32AFB7E(){} // RVA: 0x7FFD4E3FCC10
        public void Initialize(){} // RVA: 0x7FFD4E342E30
        public void GetIKSolver_2DDE7AD04D43(){} // RVA: 0x7FFD4E3BC730
        public void set_element(){} // RVA: 0x7FFD4E5F0C20
        public void .ctor(){} // RVA: 0x7FFD4F9AF5F0
        public void get_DisableInteractive(){} // RVA: 0x7FFD4E3FCC00
        public void Destroy(){} // RVA: 0x7FFD4F9AF750
        public void SetUdonEnabled(){} // RVA: 0x7FFD4F7D4D70
        public void DestroyImmediate(){} // RVA: 0x7FFD4F9AF9B0
        public void Equals(){} // RVA: 0x7FFD4F9AFBA0
        public void get_HideUiWhenRecording(){} // RVA: 0x7FFD4EC8C550
        public void GetIKSolver_0D34FDBADE79(){} // RVA: 0x7FFD4F9AFC80
        public void FindObjectOfType_A46C7AED6628(){} // RVA: 0x7FFD4F9AFE30 | overloaded x2
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4E5F0140
        public void get_hideFlags(){} // RVA: 0x7FFD4F9AFD60
        public void set_hideFlags(){} // RVA: 0x7FFD4F9AFE20
        public void SetModelShader(){} // RVA: 0x7FFD4E3BC740
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4F9B0090
    }

    /// <summary>Originally: ÏÎÎÎÌÌÎÌÎÏÍÏÎÌÌÎÎÌÏÏÏÏÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_7BB7
    {
        // ── Methods ──
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
    }

    /// <summary>Originally: ÏÎÍÍÎÏÌÍÌÏÏÌÎÏÍÏÌÌÎÏÍÌÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_A760 : Object
    {
        public string _a760;
        public T ÏÏÍÌÎÏÍÍÍÍÏÎÍÌÍÍÌÎÍÍÏÌÏ;
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<T> ÏÏÎÎÍÌÏÎÌÌÎÏÏÌÌÎÏÏÎÌÏÏÌ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD4E090A40
        public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void CompareBaseObjects(){} // RVA: 0x7FFD4E090A40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E078E90
        public void GetCachedPtr(){} // RVA: 0x7FFD4E090A40
        public void get_name(){} // RVA: 0x7FFD4E090A40
        public void set_name(){} // RVA: 0x7FFD4E090A40
        public void Instantiate(){} // RVA: 0x7FFD4E090A40
        public void ToString(){} // RVA: 0x7FFD4E090A40
        public void InitializeVectorMemory(){} // RVA: 0x7FFD4E090A40
        public void Dispose(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    }

    /// <summary>Originally: ÏÏÌÎÍÎÌÏÌÎÎÎÏÌÍÍÍÌÏÏÌÏÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_C4B5 : ValueType
    {
        public ÏÏÍÍÎÏÌÎÎÏÎÏÎÌÏÌÏÍÎÎÌÏÏ f_867; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4ED025C0
        public void InternalEquals(){} // RVA: 0x7FFD4ED025E0
        public void DefaultEquals(){} // RVA: 0x7FFD4ED02600
        public void GetHashCode(){} // RVA: 0x7FFD4ED02620
        public void InternalGetHashCode(){} // RVA: 0x7FFD4ED02650
        public void ToString(){} // RVA: 0x7FFD4ED03520
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4ED03560
        public void get_TypeId(){} // RVA: 0x7FFD4ED03580
        public void Decode(){} // RVA: 0x7FFD4ED035A0
        public void FormatNetworkStateMachine(){} // RVA: 0x7FFD4ED03770
        public void EvaluateAndProcessNetworkState(){} // RVA: 0x7FFD4ED04FB0
        public void WasLastEyeDataValid(){} // RVA: 0x7FFD4ED067F0
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
        public void Initialize(){} // RVA: 0x7FFD4ED06810
        public void Update(){} // RVA: 0x7FFD4ED08050
        public void NeedsSync(){} // RVA: 0x7FFD4ED080D0
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFD4ED080F0
        public void OnDisable(){} // RVA: 0x7FFD4ED082C0
        public void OnApplicationQuit(){} // RVA: 0x7FFD4ED08340
        public void AddCachedQueriedProductDetails_D02E15A6E469(){} // RVA: 0x7FFD4ED08360
        public void OnApplicationQuit_D45A011958AB(){} // RVA: 0x7FFD4ED083E0
        public void Decode_379598958ADE(){} // RVA: 0x7FFD4ED08400
        public void NeedsImportant(){} // RVA: 0x7FFD4ED083E0
        public void OnCollisionEnter(){} // RVA: 0x7FFD4ED08420
        public void AddCachedQueriedProductDetails_300E161D26C4(){} // RVA: 0x7FFD4ED08440
    }

}