// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 12
// Methods: 195

namespace VRC.Misc
{
    /// <summary>Originally: ÍÌÍÍÎÎÍÌÎÎÍÌÌÎÍÏÎÎÍÌÍÌÎ</summary>
    public class LightManager : MonoBehaviour
    {
        public ÎÎÏÏÎÎÏÌÏÍÎÍÎÌÏÌÎÏÏÌÌÌÍ _lightReservedLayerMask; // 0x20
        public 0x6641FB7C f_906; // 0x78
        public bool f_CD9; // 0x7C
        public bool f_098; // 0x7D
        public UnityEngine.GameObject propInstanceContainer; // 0x80
        public UnityEngine.Transform propInstanceFollowerPositionRotation; // 0x88
        public UnityEngine.Transform propInstanceFollowerScaleFactor; // 0x90
        public UnityEngine.MeshFilter hiddenPreviewMeshFilter; // 0x98
        public UnityEngine.AudioSource propSpawnAudioSource; // 0xA0
        public UnityEngine.AudioClip propSpawnAudioClip; // 0xA8
        public ÍÎÎÌÏÍÎÌÎÏÍÌÎÍÍÏÌÏÎÌÏÌÍ f_E9C; // 0xB0

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81178740
        public void RaiseCancellation(){} // RVA: 0x7FFE81588EC0
        public void OnDestroy(){} // RVA: 0x7FFE8158A180
        public void CancelInvoke(){} // RVA: 0x7FFE8158A770
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist.CleanWhitelist(){} // RVA: 0x7FFE8158A780
        public void InvokeRepeating(){} // RVA: 0x7FFE8158A7D0
        public void OnBecameInvisible(){} // RVA: 0x7FFE8158A7F0
        public void IsInvoking(){} // RVA: 0x7FFE8158AAF0
        public void StartCoroutine(){} // RVA: 0x7FFE8158AB40
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFE8158B030
        public void OnTriggerEnter(){} // RVA: 0x7FFE81129130
        public void ToString(){} // RVA: 0x7FFE8158B090
        public void StopCoroutine(){} // RVA: 0x7FFE8158B210
        public void Equals(){} // RVA: 0x7FFE8158B8D0
        public void VRC.Udon.Common.Interfaces.IUdonSecurityFilter<UnityEngine.Object>.ApplyFilter(){} // RVA: 0x7FFE8158BA50
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist<UnityEngine.Object>.Whitelist(){} // RVA: 0x7FFE8158D170 | overloaded x2
        public void get_useGUILayout(){} // RVA: 0x7FFE8158BB20
        public void set_useGUILayout(){} // RVA: 0x7FFE8158BC00
        public void print(){} // RVA: 0x7FFE8158D120 | overloaded x2
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE8158C060
        public void VRC.Udon.Common.Interfaces.IUdonVMFactory.ConstructUdonVM(){} // RVA: 0x7FFE8158C190
        public void VRC.Udon.Common.Interfaces.IUdonWrapperFactory.GetWrapper(){} // RVA: 0x7FFE8158C1E0
        public void GetHashCode(){} // RVA: 0x7FFE8158C230
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.get_DebugLogging(){} // RVA: 0x7FFE8158C5E0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE811290C0
        public void StartCoroutineManaged(){} // RVA: 0x7FFE8158C5F0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE8130D470
        public void StopCoroutineManaged(){} // RVA: 0x7FFE8158C650
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE8158C8E0
        public void GetScriptClassName(){} // RVA: 0x7FFE8158CB70
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE8158CBC0
        public void Update(){} // RVA: 0x7FFE8158D040
        public void VRC.Udon.Common.Interfaces.IUdonSecurityFilter.ApplyFilter(){} // RVA: 0x7FFE80E460A0
        public void OnDisable(){} // RVA: 0x7FFE8158D0B0
        public void OnApplicationPause(){} // RVA: 0x7FFE8158D130
        public void .cctor(){} // RVA: 0x7FFE8158D1D0
        public void OnBecameInvisible_CE6C864201C0(){} // RVA: 0x7FFE8158D5D0
        public void RegisterLight(){} // RVA: 0x7FFE8158D5E0
        public void OnCollisionStay(){} // RVA: 0x7FFE8158D990
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.get_DebugLogging_D203CCF0CBFD(){} // RVA: 0x7FFE811662A0
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist<UnityEngine.Object>.IsWhitelisted(){} // RVA: 0x7FFE8158DD40
        public void OnTriggerStay(){} // RVA: 0x7FFE81178740
        public void .ctor_C752C6231642(){} // RVA: 0x7FFE8158DDA0
        public void .ctor(){} // RVA: 0x7FFE8158E150
        public void Initialize(){} // RVA: 0x7FFE8158E3A0
        public void get_LightReservedLayerMask_BD00582FED6D(){} // RVA: 0x7FFE8158E3F0
        public void VRC.Udon.Common.Interfaces.IUdonWrapperFactory.GetWrapper_DCB34FB9707F(){} // RVA: 0x7FFE8158E550
        public void Awake(){} // RVA: 0x7FFE8158E850
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.set_DebugLogging(){} // RVA: 0x7FFE8158E950
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFE8158E960
        public void FixedUpdate(){} // RVA: 0x7FFE8158D5D0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFE8158EBE0
        public void LateUpdate(){} // RVA: 0x7FFE8158EC40
        public void UnregisterLight(){} // RVA: 0x7FFE8158EC50
        public void UpdateLightSettings(){} // RVA: 0x7FFE8158ED80
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFE8158EDD0
    }

    /// <summary>Originally: ÎÏÍÎÍÎÎÎÍÎÏÎÎÏÏÎÍÍÍÌÏÎÍ</summary>
    public class LightManagerSibling_BA16
    {
        // ── Unresolved (hash) ──
        public void m_FB0(){} // RVA: 0x7FFE80E2E2E0
        public void m_CAC(){} // RVA: 0x7FFE80E2E2E0
        public void m_A8F(){} // RVA: 0x7FFE80E2E2E0
        public void m_F2E(){} // RVA: 0x7FFE80E2F150
        public void m_37B(){} // RVA: 0x7FFE80E2E2E0
        public void m_D20(){} // RVA: 0x7FFE80E2E2E0
        public void m_54E(){} // RVA: 0x7FFE80E2F3B0
        public void m_3EC(){} // RVA: 0x7FFE80E466C0
        public void m_E9E(){} // RVA: 0x7FFE80E460A0
        public void m_056(){} // RVA: 0x7FFE80E45FE0
    }

    /// <summary>Originally: ÍÍÎÍÏÏÌÍÎÏÌÌÏÏÍÍÎÏÍÍÏÏÎ</summary>
    public class List1DerivedSibling_D585
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE80E45FE0
        // ── Unresolved (hash) ──
        public void m_5C0(){} // RVA: 0x7FFE80E45FE0
        public void m_466(){} // RVA: 0x7FFE80E460A0
        public void m_9F2(){} // RVA: 0x7FFE80E460A0
    }

    /// <summary>Originally: ÏÍÎÏÌÏÌÌÍÎÎÎÎÏÌÎÏÎÍÏÌÎÎ</summary>
    public class List1Derived_464A : List`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE81E9EB20
        public void Contains(){} // RVA: 0x7FFE81E9ED10
        public void CopyTo(){} // RVA: 0x7FFE81E9EEC0
        public void get_Capacity(){} // RVA: 0x7FFE81E9F070
        public void set_Capacity(){} // RVA: 0x7FFE81E9F260
        public void get_Count(){} // RVA: 0x7FFE81E9F450
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE81E9F640
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE81E9F7F0
        public void .ctor(){} // RVA: 0x7FFE81E9F9A0
        public void Initialize(){} // RVA: 0x7FFE81E9FA20
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE81E9FC10
    }

    /// <summary>Originally: ÍÌÌÍÌÍÎÌÍÌÏÎÎÎÌÏÎÎÌÏÏÌÍ</summary>
    public class List1Derived_5166 : List`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE8283E3C0
        public void Contains(){} // RVA: 0x7FFE8283E6B0
        public void CopyTo(){} // RVA: 0x7FFE8283E930
        public void get_Capacity(){} // RVA: 0x7FFE8283EC20
        public void set_Capacity(){} // RVA: 0x7FFE8283EE90
        public void get_Count(){} // RVA: 0x7FFE8283F100
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE8283F370
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE8283F660
        public void .ctor(){} // RVA: 0x7FFE8283F950
        public void Initialize(){} // RVA: 0x7FFE8283FA10
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE8283FC90
    }

    /// <summary>Originally: ÏÍÌÏÌÎÎÎÏÏÏÎÏÏÏÏÏÏÍÌÎÌÏ</summary>
    public class List1Derived_A71D : List`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE8283FF10
        public void .ctor(){} // RVA: 0x7FFE82840290
        public void Initialize(){} // RVA: 0x7FFE82840350
        public void get_Capacity(){} // RVA: 0x7FFE828406D0
        public void set_Capacity(){} // RVA: 0x7FFE82840A50
        public void get_Count(){} // RVA: 0x7FFE82840DD0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE82841150
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE828414D0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE82841850
    }

    /// <summary>Originally: ÏÎÏÍÏÏÍÌÌÎÎÎÎÎÏÍÎÎÌÌÏÏÎ</summary>
    public class ListContentView1Derived_3FD3 : ListContentView`1
    {
        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x7FFE80E45FE0
        public void get_MaxContentCount(){} // RVA: 0x7FFE80E3FC10
        public void get_ObservableList(){} // RVA: 0x7FFE80E2E390
        public void Start(){} // RVA: 0x7FFE80E2E390
        public void OnEnable(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    /// <summary>Originally: ÏÌÌÎÌÍÏÌÌÎÏÍÍÎÎÏÏÏÏÌÌÌÎ</summary>
    public class LocalizationManagerSibling_4972
    {
        // ── 27 unresolved (hash) ──
        public void m_1D1(){} // RVA: 0x7FFE80E2F150
        public void m_C5E(){} // RVA: 0x7FFE80E45FE0
        public void m_B30(){} // RVA: 0x7FFE80E460A0
        public void m_123(){} // RVA: 0x7FFE80E2E2E0
        public void m_ADF(){} // RVA: 0x7FFE80E2E2E0
        // ... 22 more unresolved methods
    }

    /// <summary>Originally: ÏÌÎÍÌÏÎÍÎÏÎÌÏÍÍÍÎÎÎÏÌÌÏ</summary>
    public class LogoutExit_8B9E : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE825F3E30
        public void RaiseCancellation(){} // RVA: 0x7FFE825F4060
        public void IsInvoking(){} // RVA: 0x7FFE825F4290
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE825F44C0
        public void InvokeRepeating(){} // RVA: 0x7FFE825F4510
        public void Exit(){} // RVA: 0x7FFE825F4740
        public void Logout(){} // RVA: 0x7FFE81B0FF50
        public void StartCoroutine(){} // RVA: 0x7FFE825F4790
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE825F49E0
        // ── Unresolved (hash) ──
        public void m_A30(){} // RVA: 0x7FFE81B0FF50
        public void m_503(){} // RVA: 0x7FFE82523D40
    }

    /// <summary>Originally: ÍÍÍÌÌÏÍÍÍÍÎÏÎÌÌÌÍÌÎÌÌÍÌ</summary>
    public class landscapeScalelandscapePosComponent_FFCB : MonoBehaviour
    {
        public UnityEngine.Vector2 landscapePos; // 0x20
        public UnityEngine.Vector3 landscapeScale; // 0x28

        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFE81859B50
        public void RaiseCancellation(){} // RVA: 0x7FFE81859C50
        public void IsInvoking(){} // RVA: 0x7FFE81859C60
        public void CancelInvoke(){} // RVA: 0x7FFE81859C70
        public void Invoke(){} // RVA: 0x7FFE81859C60
        public void InvokeRepeating(){} // RVA: 0x7FFE81859E00
        public void OnCollisionStay(){} // RVA: 0x7FFE81859C50
        public void Start(){} // RVA: 0x7FFE81859E90
        public void StartCoroutine(){} // RVA: 0x7FFE8185A100
        public void OnTriggerStay(){} // RVA: 0x7FFE8185A1F0
        public void OnTriggerExit(){} // RVA: 0x7FFE8185A380
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE8185A480
        public void StopCoroutine(){} // RVA: 0x7FFE8185A4A0
        public void OnApplicationPause(){} // RVA: 0x7FFE8185A590
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE8185A690
        public void Awake(){} // RVA: 0x7FFE8185A820
        public void set_useGUILayout(){} // RVA: 0x7FFE8185A8B0
    }

    /// <summary>Originally: ÎÎÏÍÌÏÎÎÏÎÎÏÌÏÌÎÎÌÎÌÎÍÎ</summary>
    public class lowerCaseValuetypeComponentSibling_36BA
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        // ── Unresolved (hash) ──
        public void m_C11(){} // RVA: 0x7FFE80E2E2E0
        public void m_7BF(){} // RVA: 0x7FFE80E460A0
        public void m_2F7(){} // RVA: 0x7FFE80E2EDB0
        public void m_A08(){} // RVA: 0x7FFE80E45FE0
        public void m_7B1(){} // RVA: 0x7FFE80E45FE0
        public void m_967(){} // RVA: 0x7FFE80E466C0
        public void m_F10(){} // RVA: 0x7FFE80E466C0
    }

    /// <summary>Originally: ÎÌÏÏÏÏÏÎÎÍÎÌÎÏÎÏÍÍÍÏÏÍÏ</summary>
    public class lowerCaseValuetypeComponent_9847 : MonoBehaviour
    {
        public 0x66565BE4 _type; // 0x20
        public string _lowerCaseValue; // 0x28

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81176730
        public void .ctor(){} // RVA: 0x7FFE89974930
        public void Awake(){} // RVA: 0x7FFE89974990
        public void OnDestroy(){} // RVA: 0x7FFE81176730
        public void Invoke(){} // RVA: 0x7FFE89974AD0
        public void InvokeRepeating(){} // RVA: 0x7FFE81176730
        public void CancelInvoke(){} // RVA: 0x7FFE89974B50
        public void IsInvoking(){} // RVA: 0x7FFE8151D690
        public void StartCoroutine(){} // RVA: 0x7FFE89974BD0
        public void OnBecameInvisible(){} // RVA: 0x7FFE89974BF0
        public void OnApplicationPause(){} // RVA: 0x7FFE81176740
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE89974DA0
        public void StopCoroutine(){} // RVA: 0x7FFE89974F50
        public void OnCollisionEnter(){} // RVA: 0x7FFE89974FD0
        public void StopAllCoroutines(){} // RVA: 0x7FFE89974FD0
        public void ToString(){} // RVA: 0x7FFE89974FE0
        public void set_useGUILayout(){} // RVA: 0x7FFE8151D690
        public void print(){} // RVA: 0x7FFE89975070
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE8151D690
        // ── Unresolved (hash) ──
        public void m_517(){} // RVA: 0x7FFE81176730
    }

}