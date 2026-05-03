// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.World
// Classes: 3
// Methods: 90

namespace VRC.World
{
    /// <summary>Originally: ÌÏÍÏÌÏÍÌÎÏÏÍÌÌÎÎÏÌÏÌÎÌÌ</summary>
    public class RoomManager : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82431AD0
        public void Initialize(){} // RVA: 0x7FFE82431BA0
        public void IsInvoking(){} // RVA: 0x7FFE82431CB0
        public void CancelInvoke(){} // RVA: 0x7FFE82431EB0
        public void Invoke(){} // RVA: 0x7FFE82432460
        public void InvokeRepeating(){} // RVA: 0x7FFE82432A10
        public void InternalApplyOverrideRPC_500FE7F27C33(){} // RVA: 0x7FFE82432E30
        public void InternalApplyOverrideRPC(){} // RVA: 0x7FFE824333E0
        public void OnPlayerJoined(){} // RVA: 0x7FFE82433800
        public void StartCoroutine(){} // RVA: 0x7FFE82433AA0
        public void Start(){} // RVA: 0x7FFE82434040
        public void Awake(){} // RVA: 0x7FFE82434430
        public void StopCoroutine(){} // RVA: 0x7FFE82434830
        public void OnDisable(){} // RVA: 0x7FFE82434A40
        public void OnDestroy(){} // RVA: 0x7FFE82434E60
        public void StopAllCoroutines(){} // RVA: 0x7FFE82434F70
    }

    /// <summary>Originally: ÏÎÏÏÏÏÌÎÎÍÎÌÍÌÏÏÎÌÌÏÍÍÎ</summary>
    public class WorldProximityExitStation_F272 : NetworkReadyHandler_FB37
    {
        public ÏÎÏÏÏÏÌÎÎÍÎÌÍÌÏÏÎÌÌÏÍÍÎ[] _proximity;
        public System.Collections.Generic.Dictionary`2<uint,ÏÎÏÏÏÏÌÎÎÍÎÌÍÌÏÏÎÌÌÏÍÍÎ> f_313; // 0x8
        public VRC.SDKBase.VRCStation f_17D; // 0x58
        public VRCSDK2.VRC_Station f_082; // 0x60
        public VRC.SDK3.Components.VRCStation f_E60; // 0x68
        public VRC.Udon.UdonBehaviour f_280; // 0x70
        public VRC.SDKBase.VRC_Interactable f_092; // 0x78
        public VRC.SDKBase.VRC_PropController f_8E2; // 0x80
        public CustomTriggerTarget f_8BE; // 0x88
        public UnityEngine.Vector3 f_0EC; // 0x90
        public UnityEngine.Vector3 f_BE1; // 0x9C

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE82472680
        public void Start(){} // RVA: 0x7FFE82472BE0
        public void Update(){} // RVA: 0x7FFE82472D20
        public void UseStation(){} // RVA: 0x7FFE82473B10
        public void ExitStation(){} // RVA: 0x7FFE824753E0
        public void set_Proximity(){} // RVA: 0x7FFE824754D0
        public void get_Proximity(){} // RVA: 0x7FFE824772C0
        public void OnDestroy(){} // RVA: 0x7FFE8247ABA0
        public void OnEnable(){} // RVA: 0x7FFE8247ADA0
        public void OnDisable(){} // RVA: 0x7FFE8247AE90
        public void .ctor(){} // RVA: 0x7FFE8247B070
        public void .cctor(){} // RVA: 0x7FFE8247B2D0
        // ── 42 unresolved (hash) ──
        public void m_5AC(){} // RVA: 0x7FFE82471710
        public void m_941(){} // RVA: 0x7FFE82471AA0
        public void m_4E9(){} // RVA: 0x7FFE8247A920
        public void m_902(){} // RVA: 0x7FFE82471F00
        public void m_1B6(){} // RVA: 0x7FFE82471FB0
        // ... 37 more unresolved methods
    }

    /// <summary>Originally: ÎÍÍÏÌÍÏÍÌÎÍÍÍÍÎÏÎÎÍÏÍÌÏ</summary>
    public class WorldSpawnHandler_A43A : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE89686DE0
        public void RaiseCancellation(){} // RVA: 0x7FFE89686E30
        public void IsInvoking(){} // RVA: 0x7FFE89687180
        public void CancelInvoke(){} // RVA: 0x7FFE896871D0
        public void Invoke(){} // RVA: 0x7FFE896873D0
        public void InvokeRepeating(){} // RVA: 0x7FFE89687730
        public void StartCoroutine(){} // RVA: 0x7FFE89687B30
        public void Initialize(){} // RVA: 0x7FFE89687E90
        public void StartCoroutine_F7950F570AFE(){} // RVA: 0x7FFE89688920
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE89688970
        public void StopCoroutine(){} // RVA: 0x7FFE89688CC0
        public void Start(){} // RVA: 0x7FFE89688DB0
        public void Update(){} // RVA: 0x7FFE89688EC0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void OnSpawn(){} // RVA: 0x7FFE89688F10
        public void set_useGUILayout(){} // RVA: 0x7FFE89689220
        // ── Unresolved (hash) ──
        public void m_123(){} // RVA: 0x7FFE89687840
        public void m_0D8(){} // RVA: 0x7FFE89687930
    }

}