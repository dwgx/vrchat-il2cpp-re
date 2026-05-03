// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Player
// Classes: 6
// Methods: 432

namespace VRC.Player
{
    /// <summary>Originally: ÍÎÎÌÏÍÎÌÎÏÍÌÎÍÍÏÌÏÎÌÏÌÍ</summary>
    public class VRCPlayer : NetworkReadyHandler_FB37
    {
        public ÍÎÎÌÏÍÎÌÎÏÍÌÎÍÍÏÌÏÎÌÏÌÍ f_A6F;
        public ÏÏÎÍÍÎÌÏÎÍÍÏÍÏÌÍÏÎÏÏÍÏÏ _player; // 0x58
        public ÍÎÍÌÌÎÎÍÏÍÏÍÍÎÎÍÎÎÏÍÎÍÌ _serializer; // 0x60
        public ÎÏÍÌÌÍÍÎÏÌÌÏÏÍÍÎÎÏÏÍÍÏÌ _poseRecorder; // 0x68
        public ÌÌÍÎÌÎÍÏÏÍÍÎÌÎÏÏÌÎÍÍÍÏÎ _syncPhysics; // 0x70
        public bool f_ADC; // 0x78
        public ÌÍÍÌÎÎÌÎÌÎÏÏÎÏÏÎÌÏÌÍÎÍÎ f_65A; // 0x80
        public UnityEngine.GameObject f_9A4; // 0x88
        public ÏÍÏÍÏÎÏÎÍÏÍÍÌÏÌÎÌÎÎÏÍÌÏ f_D82; // 0x90
        public ÌÍÏÏÎÏÌÎÍÎÏÍÎÌÏÎÎÎÌÍÍÏÏ f_D69; // 0x98
        public string f_715; // 0xA0
        public UnityEngine.Texture2D f_CB7; // 0xA8
        public bool f_5AB; // 0xB0
        public float f_CF0; // 0xB4
        public float f_E5C; // 0xB8
        public System.Collections.Generic.HashSet`1<string> f_834; // 0xC0
        public ÌÍÍÏÍÌÏÍÌÏÍÎÏÏÍÍÍÍÌÏÎÍÏ f_85E; // 0xC8
        public ÏÍÍÍÌÏÏÌÌÌÍÌÏÏÎÏÎÍÍÎÏÌÍ f_08F; // 0xD0
        public ÍÌÌÏÍÍÍÍÍÎÎÌÍÌÌÍÏÏÎÎÏÎÎ f_8E9; // 0xD8
        public UnityEngine.GameObject[] f_519; // 0xE0
        public UnityEngine.GameObject[] f_5E4; // 0xE8
        public ÏÍÍÎÍÍÎÌÏÎÎÏÍÌÏÌÏÏÍÌÏÎÌ f_7C2; // 0xF0
        public ÏÍÍÎÍÍÎÌÏÎÎÏÍÌÏÌÏÏÍÌÏÎÌ f_6B1; // 0xF8
        public bool f_524; // 0x100
        public float f_7A6; // 0x8
        public UnityEngine.Vector3 f_286; // 0x104
        public float f_D5D; // 0x110
        public float f_FB2;
        public string f_176; // 0x118
        public string f_751; // 0x120
        public ÎÏÏÏÎÍÎÌÍÏÏÍÏÍÎÌÏÌÎÏÍÎÎ f_BD5; // 0x128
        public bool f_40A; // 0x130
        public bool f_110; // 0x131
        public ÎÎÎÏÏÏÍÌÍÍÎÏÎÍÌÎÍÏÎÍÏÎÎ f_294; // 0x138
        public UnityEngine.Transform f_FE8; // 0x140
        public bool f_74C; // 0x148
        public ÎÍÌÏÍÍÎÌÏÌÎÏÎÏÎÌÏÎÏÍÎÍÌ f_100; // 0x150
        public UnityEngine.GameObject f_4CE; // 0x158
        public UnityEngine.Animator f_788; // 0x160
        public ÍÍÏÌÎÎÎÌÎÌÎÎÌÎÌÍÎÍÍÌÏÍÍ f_2A1; // 0x168
        public System.Collections.Generic.Dictionary`2<string,string> f_A7F; // 0x170
        public System.Collections.Generic.HashSet`1<int> f_F83; // 0x178
        public System.Collections.Generic.Dictionary`2<int,int> f_DE4; // 0x180
        public ÏÌÎÌÌÏÌÎÎÎÏÎÏÍÏÎÍÌÍÍÎÎÍ f_93E; // 0x188
        public bool f_6A7; // 0x190
        public System.Nullable`1<int> f_B77; // 0x194
        public VRC.SDKBase.VRCPlayerApi f_84B; // 0x1A0
        public System.Collections.Generic.List`1<ÍÌÍÎÍÌÏÌÎÎÌÌÎÌÌÌÌÍÍÌÏÎÌ> f_340; // 0x1A8
        public ÍÌÍÎÍÌÏÌÎÎÌÌÎÌÌÌÌÍÍÌÏÎÌ f_8CE; // 0x1B0
        public ÍÌÍÎÍÌÏÌÎÎÌÌÎÌÌÌÌÍÍÌÏÎÌ f_0E5; // 0x1B8
        public bool f_776; // 0x1C0
        public bool f_122; // 0x1C1
        public bool f_339; // 0x1C2
        public bool f_9F9; // 0x1C3
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<ÍÏÎÌÎÌÏÏÌÎÍÎÌÏÌÌÏÏÎÏÌÌÏ> f_EC6; // 0x1C8
        public ÌÍÍÏÌÏÍÏÎÍÌÍÏÍÏÍÌÏÎÌÏÏÌ f_995; // 0x1D0
        public VRC.Core.ApiAvatar f_C77; // 0x1D8
        public VRC.Core.ApiAvatar f_415; // 0x1E0
        public VRC.Core.ApiInventoryItem f_8BB; // 0x1E8
        public bool f_17F; // 0x1F0
        public bool f_E52; // 0x1F1
        public string f_F50; // 0x1F8
        public bool f_284; // 0x200
        public ulong f_984; // 0x208
        public bool f_B25; // 0x210
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_D74; // 0x218
        public ÏÏÌÍÌÎÏÌÍÍÍÌÏÍÌÎÏÏÍÏÏÎÎ<bool> f_245; // 0x220

        // ── Methods ──
        public void InitializePlayer(){} // RVA: 0x7FFE823E4020
        public void InitializePhotonConnectionPlayer(){} // RVA: 0x7FFE823E5950
        public void OnDestroy(){} // RVA: 0x7FFE823E6520
        public void .cctor(){} // RVA: 0x7FFE823E6ED0
        public void .ctor(){} // RVA: 0x7FFE823E7C60
        public void Initialize(){} // RVA: 0x7FFE81253460
        public void set_SerializedDataField(){} // RVA: 0x7FFE823EB7E0
        public void Awake(){} // RVA: 0x7FFE823EC300
        public void ToString(){} // RVA: 0x7FFE823EEFE0
        public void set_SerializedDataField_FC4C32(){} // RVA: 0x7FFE823F3890
        public void SetPlayerTagWithoutNotify(){} // RVA: 0x7FFE823F4FB0
        public void InitializeNetworkState(){} // RVA: 0x7FFE823F5A60
        public void Start(){} // RVA: 0x7FFE823F65F0
        public void ResetVoiceAndMuteState(){} // RVA: 0x7FFE823F6F60
        public void get_ExecutingTaskCollection(){} // RVA: 0x7FFE823F8A30
        public void ReloadAvatarNetworkedRPC(){} // RVA: 0x7FFE823F9920
        public void PlayEmoteRPC(){} // RVA: 0x7FFE823FB420
        // ── 225 unresolved (hash) ──
        public void m_927(){} // RVA: 0x7FFE816611A0
        public void m_6EA(){} // RVA: 0x7FFE823E4580
        public void m_09F(){} // RVA: 0x7FFE823E4660
        public void m_63E(){} // RVA: 0x7FFE81176D50
        public void m_AE2(){} // RVA: 0x7FFE823E4670
        // ... 220 more unresolved methods
    }

    /// <summary>Originally: ÏÏÏÌÌÍÌÌÎÌÍÌÌÌÎÍÎÌÎÍÎÍÏ</summary>
    public class VRCPlayerSiblingSibling_2E83 : Object
    {
        public System.Action f_49A; // 0x10
        public ÌÍÌÏÌÍÍÌÎÎÎÎÎÎÌÍÎÎÌÎÎÎÎ<ÍÏÎÌÎÌÏÏÌÎÍÎÌÏÌÌÏÏÎÏÌÌÏ> _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public object f_49A; // 0xD1
        public object f_819;
        public object f_D84;
        public object f_C7C;
        public object f_A1E;
        public object f_6C0;
        public object f_102;
        public object ÌÌÌÍÏÍÏÍÍÎÎÍÌÏÏÏÍÍÎÎÍÍÌ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE81161E80
        public void Equals(){} // RVA: 0x7FFE81CB4380
        public void GetHashCode(){} // RVA: 0x7FFE81CB43F0
        public void op_Implicit(){} // RVA: 0x7FFE81CB4530
        public void CompareBaseObjects(){} // RVA: 0x7FFE81CB4660
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81CB4770
        public void GetCachedPtr(){} // RVA: 0x7FFE81CB4950
        public void get_name(){} // RVA: 0x7FFE81CB4A40
        public void set_name(){} // RVA: 0x7FFE81CB4B30
        public void .ctor(){} // RVA: 0x7FFE81CB4CA0
        public void Initialize(){} // RVA: 0x7FFE81CB4EB0
        public void Instantiate(){} // RVA: 0x7FFE81CB5220
        public void ToString(){} // RVA: 0x7FFE81CB5390
        public void ComputegameObject(){} // RVA: 0x7FFE81CB5610
        public void ReadTransformState(){} // RVA: 0x7FFE81CB5890
        public void get_PlayerApiReference(){} // RVA: 0x7FFE81CB5A00
        public void get_IsInvisible(){} // RVA: 0x7FFE81CB60E0
        public void Destroy(){} // RVA: 0x7FFE81CB6150
        public void DoFindRelativeTransformWithPath_C62(){} // RVA: 0x7FFE810FE7C0
        public void DestroyImmediate(){} // RVA: 0x7FFE81CB6240
        public void FindObjectsOfType(){} // RVA: 0x7FFE81CB67A0
        public void set_statusDescription(){} // RVA: 0x7FFE81CB6950
        public void FindObjectsByType(){} // RVA: 0x7FFE81CB6A80
        public void .cctor(){} // RVA: 0x7FFE81CB6BC0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE81CB6DA0
        public void get_hideFlags(){} // RVA: 0x7FFE81CB6EE0
        // ── Unresolved (hash) ──
        public void m_4FF(){} // RVA: 0x7FFE81CB5C30
        public void m_4D4(){} // RVA: 0x7FFE81CB5FA0
        public void m_F58(){} // RVA: 0x7FFE81CB65F0
    }

    /// <summary>Originally: ÍÍÍÏÎÎÌÍÌÏÌÏÎÏÌÌÌÏÍÌÌÌÌ</summary>
    public class VRCPlayerSiblingSibling_8B6F
    {
        // ── 18 unresolved (hash) ──
        public void m_122(){} // RVA: 0x7FFE80E45FE0
        public void m_805(){} // RVA: 0x7FFE80E2F150
        public void m_32B(){} // RVA: 0x7FFE80E2E2E0
        public void m_450(){} // RVA: 0x7FFE80E50660
        public void m_4FF(){} // RVA: 0x7FFE80E50660
        // ... 13 more unresolved methods
    }

    /// <summary>Originally: ÎÎÎÏÎÍÏÎÎÌÍÍÎÎÏÍÍÍÏÎÌÏÎ</summary>
    public class VRCPlayerSibling_0E38 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE8207E9D0
        public void RaiseCancellation(){} // RVA: 0x7FFE8207EE00
        public void IsInvoking(){} // RVA: 0x7FFE8207EE40
        public void CancelInvoke(){} // RVA: 0x7FFE8207EEB0
        public void Invoke(){} // RVA: 0x7FFE8207F010
        public void InvokeRepeating(){} // RVA: 0x7FFE8207F080
        public void StartCoroutine(){} // RVA: 0x7FFE8207F3A0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE8207FA90
        public void StopCoroutine(){} // RVA: 0x7FFE8207FBA0
        public void StopAllCoroutines(){} // RVA: 0x7FFE820800D0
        public void get_useGUILayout(){} // RVA: 0x7FFE82080180
        public void set_useGUILayout(){} // RVA: 0x7FFE820805D0
        public void print(){} // RVA: 0x7FFE820806E0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE82080A40
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE82080AB0
        public void InvokeDelayed(){} // RVA: 0x7FFE82080BD0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE82080DF0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE82081490
        public void StopCoroutineManaged(){} // RVA: 0x7FFE82081620
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE820817E0
        public void GetScriptClassName(){} // RVA: 0x7FFE820818F0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE82081940
        // ── 69 unresolved (hash) ──
        public void m_7A0(){} // RVA: 0x7FFE8207F180
        public void m_2EE(){} // RVA: 0x7FFE8207F1D0
        public void m_C00(){} // RVA: 0x7FFE8207F520
        public void m_C0B(){} // RVA: 0x7FFE8207F570
        public void m_EFD(){} // RVA: 0x7FFE8207FBF0
        // ... 64 more unresolved methods
    }

    /// <summary>Originally: ÌÌÏÍÌÌÎÌÍÏÏÌÍÌÎÎÍÏÏÎÍÏÎ</summary>
    public class VRCPlayerSibling_695D : Object
    {
        public System.Action f_49A; // 0x10
        public VRC.Core.APIUser _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public ÌÍÌÏÌÍÍÌÎÎÎÎÎÎÌÍÎÎÌÎÎÎÎ<ÍÏÎÌÎÌÏÏÌÎÍÎÌÏÌÌÏÏÎÏÌÌÏ> f_EC6; // 0x20
        public object f_49A; // 0xB1
        public IntPtr f_0A9; // 0x3620
        public TM f_21D;
        public TM f_F3A;
        public IntPtr f_6C0;
        public IntPtr f_102;
        public object ÌÌÌÍÏÍÏÍÍÎÎÍÌÏÏÏÍÍÎÎÍÍÌ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8111F210
        public void Equals(){} // RVA: 0x7FFE81899E00
        public void GetHashCode(){} // RVA: 0x7FFE81899E40
        public void op_Implicit(){} // RVA: 0x7FFE811E0850
        public void CompareBaseObjects(){} // RVA: 0x7FFE81899E80
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81899EC0
        public void GetCachedPtr(){} // RVA: 0x7FFE810FB320
        public void get_name(){} // RVA: 0x7FFE81899FB0
        public void set_name(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE81899FF0
        public void Initialize(){} // RVA: 0x7FFE8189A0F0
        public void Instantiate(){} // RVA: 0x7FFE8189A240
        public void ToString(){} // RVA: 0x7FFE8189A2D0
        public void ComputegameObject(){} // RVA: 0x7FFE81161E80
        public void ReadTransformState(){} // RVA: 0x7FFE8189A310
        public void get_PlayerApiReference(){} // RVA: 0x7FFE8111ED80
        public void get_IsInvisible(){} // RVA: 0x7FFE8189A430
        public void Destroy(){} // RVA: 0x7FFE810FB320
        public void DoFindRelativeTransformWithPath_C62(){} // RVA: 0x7FFE811290C0
        public void DestroyImmediate(){} // RVA: 0x7FFE8189A470
        public void FindObjectsOfType(){} // RVA: 0x7FFE811E0850
        public void set_statusDescription(){} // RVA: 0x7FFE810FE7C0
        public void FindObjectsByType(){} // RVA: 0x7FFE8189A4F0
        public void .cctor(){} // RVA: 0x7FFE8189A640
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE8189A730
        // ── Unresolved (hash) ──
        public void m_F58(){} // RVA: 0x7FFE810FB320
        public void m_32B(){} // RVA: 0x7FFE8189A3A0
        public void m_E16(){} // RVA: 0x7FFE8189A4B0
    }

    /// <summary>Originally: ÍÌÏÎÏÍÎÌÏÎÏÍÏÌÍÏÌÎÏÌÏÌÌ</summary>
    public class VRCPlayerSibling_738A
    {
        // ── Unresolved (hash) ──
        public void m_162(){} // RVA: 0x7FFE80E2E2E0
        public void m_BB0(){} // RVA: 0x7FFE80E2E2E0
        public void m_457(){} // RVA: 0x7FFE80E2E2E0
        public void m_B19(){} // RVA: 0x7FFE80E2DCF0
        public void m_E2C(){} // RVA: 0x7FFE80E2DCF0
        public void m_6BF(){} // RVA: 0x7FFE80E2DCF0
        public void m_A3B(){} // RVA: 0x7FFE80E2DCF0
        public void m_B49(){} // RVA: 0x7FFE80E2F150
        public void m_73D(){} // RVA: 0x7FFE80E466C0
    }

}