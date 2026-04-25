// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 9
// Methods: 143

namespace VRC.Misc
{
    /// <summary>Originally: ÏÎÌÍÏÎÎÎÍÏÏÌÌÎÌÎÎÌÍÎÍÌÎ</summary>
    public class LightManagerSibling_4A7C
    {
        public object f_CD8;
        public object f_462;
        public object f_9EB;
        public object f_EA4;
        public object f_B07;
        public object f_DD3;

        // ── Methods ──
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFAC2C58E90
        public void RaiseCancellation(){} // RVA: 0x7FFAC2C58E90
        public void GetLanguage(){} // RVA: 0x7FFAC2C58E90
        public void CancelInvoke(){} // RVA: 0x7FFAC2C59D00
        public void ResolveLastServiceDescriptor(){} // RVA: 0x7FFAC2C58E90
        public void InvokeRepeating(){} // RVA: 0x7FFAC2C58E90
        public void OnTriggerStay(){} // RVA: 0x7FFAC2C59F60
        public void Enable(){} // RVA: 0x7FFAC2C71060
        public void ContainsChild(){} // RVA: 0x7FFAC2C70A40
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAC2C70980
    }

    /// <summary>Originally: ÍÌÌÏÎÎÎÎÎÌÍÏÌÍÏÍÏÎÎÌÍÏÌ</summary>
    public class LightManager_B4B6 : MonoBehaviour
    {
        public ÏÌÍÎÏÌÎÌÎÎÎÎÍÏÍÎÎÏÎÌÍÌÍ _lightReservedLayerMask; // 0x20
        public 0x6B029750 _useGUILayout; // 0x78
        public bool f_839; // 0x7C
        public bool f_9F6; // 0x7D
        public UnityEngine.GameObject f_9EB; // 0x80
        public UnityEngine.Transform f_EA4; // 0x88
        public UnityEngine.Transform f_B07; // 0x90
        public UnityEngine.MeshFilter f_DD3; // 0x98
        public UnityEngine.AudioSource f_2E6; // 0xA0
        public UnityEngine.AudioClip f_096; // 0xA8
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ f_99A; // 0xB0
        public UnityEngine.GameObject ÌÎÍÏÎÌÏÏÎÌÌÍÍÍÍÍÎÍÎÌÍÍÏ; // 0xB8
        public UnityEngine.Transform ÎÎÌÏÏÌÏÎÏÏÏÎÍÏÎÍÍÌÎÌÍÎÎ; // 0xC0
        public int ÌÏÌÎÍÏÏÍÍÍÌÍÏÍÍÌÍÏÌÌÌÏÎ; // 0xC8
        public bool ÏÏÎÍÌÌÍÍÏÏÎÌÍÌÏÎÌÌÎÍÎÎÏ; // 0xCC
        public bool ÏÎÌÍÎÍÌÍÌÏÏÏÎÍÌÎÏÍÎÏÏÌÏ; // 0xCD
        public 0x6B0297A8 ÌÌÎÏÍÌÏÏÏÏÍÏÍÍÏÍÎÏÎÏÍÏÎ; // 0xD0
        public UnityEngine.Vector3 ÌÌÏÏÌÎÏÍÌÎÍÏÍÍÍÍÎÌÏÏÌÌÎ; // 0xD4
        public float ÌÍÌÌÎÏÎÍÎÌÎÏÎÎÏÌÏÏÍÎÌÏÌ; // 0xE0
        public DG.Tweening.Core.TweenerCore`3<UnityEngine.Vector3,UnityEngine.Vector3,DG.Tweening.Plugins.Options.VectorOptions> ÎÏÎÎÌÍÍÏÌÎÍÏÏÏÏÎÍÍÏÎÏÌÏ; // 0xE8
        public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<bool> <ÍÌÎÍÌÌÍÏÎÎÍÍÎÎÎÎÎÎÏÏÎÏÎ>k__BackingField; // 0xF0
        public ÌÌÎÎÍÎÏÎÏÎÎÎÌÏÎÏÌÌÌÎÏÍÍ selector; // 0xF8
        public UnityEngine.Vector3 ÎÏÍÌÏÏÌÏÎÌÌÏÏÏÍÍÏÌÎÏÎÏÏ; // 0x100
        public float ÌÍÎÎÏÎÎÏÌÏÌÍÍÎÏÏÏÎÌÌÍÏÌ; // 0x10C
        public float ÎÏÍÎÍÎÎÎÍÍÍÏÍÌÌÍÏÎÎÎÏÎÍ;
        public float ÏÌÎÍÍÎÏÏÎÌÍÎÏÎÏÍÏÌÌÍÏÎÍ;
        public float ÏÏÏÎÍÎÍÍÍÏÍÍÍÎÏÏÍÍÌÌÎÏÎ;
        public ÍÌÌÏÍÏÎÎÎÏÎÏÏÏÏÌÎÍÌÎÏÍÌ ÍÎÎÏÍÌÌÌÍÍÎÌÏÍÌÏÍÍÏÌÌÏÎ; // 0x110
        public VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface ÎÍÍÎÍÏÏÏÌÎÌÌÏÌÏÎÌÎÍÏÌÍÏ; // 0x118
        public VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist`1<UnityEngine.Object> ÍÌÍÎÏÌÎÎÍÍÏÍÌÏÏÌÎÌÍÏÌÌÎ; // 0x120
        public System.Collections.Generic.HashSet`1<System.Type> ÌÎÏÎÎÏÌÏÎÎÍÌÍÏÏÏÍÍÍÍÏÍÏ;
        public bool <ÍÏÎÎÎÍÎÏÌÌÌÍÎÍÎÍÎÌÏÌÍÌÌ>k__BackingField; // 0x128
        public System.Collections.Concurrent.ConcurrentDictionary`2<VRC.Udon.Security.IUdonSignatureHolder,bool> ÌÌÏÎÏÏÎÌÏÏÍÍÎÍÏÎÍÎÏÏÏÏÎ; // 0x130
        public System.Nullable`1<VerifyKey> ÏÏÍÍÏÏÎÏÎÎÎÎÌÎÎÏÏÍÍÌÏÍÍ; // 0x138

        // ── Methods ──
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFAC332CA00
        public void RaiseCancellation(){} // RVA: 0x7FFAC332CC80
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void CancelInvoke(){} // RVA: 0x7FFAC332CD60
        public void Invoke(){} // RVA: 0x7FFAC332CDA0
        public void InvokeRepeating(){} // RVA: 0x7FFAC2F4F0C0
        public void OnTriggerStay_D9D42DA66D2C_D9D42DA66D2C(){} // RVA: 0x7FFAC3331A60 | overloaded x2
        public void IsInvoking(){} // RVA: 0x7FFAC332D420
        public void StartCoroutine(){} // RVA: 0x7FFAC332D7D0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAC332D900
        public void GetHashCode(){} // RVA: 0x7FFAC332D960
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC332DA40
        public void VRC.Udon.Common.Interfaces.IUdonSecurityFilter.ApplyFilter(){} // RVA: 0x7FFAC2C70A40
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.set_DebugLogging(){} // RVA: 0x7FFAC332DA60
        public void .cctor(){} // RVA: 0x7FFAC332DA70
        public void StopAllCoroutines(){} // RVA: 0x7FFAC332DE70
        public void VRC.Udon.Common.Interfaces.IUdonVMFactory.ConstructUdonVM(){} // RVA: 0x7FFAC332DFD0
        public void set_useGUILayout(){} // RVA: 0x7FFAC332E020
        public void ToString(){} // RVA: 0x7FFAC332E090
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC332E210
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
        public void InvokeDelayed(){} // RVA: 0x7FFAC332E700
        public void get_ipsQuery(){} // RVA: 0x7FFAC2F8C2A0
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist<UnityEngine.Object>.Whitelist(){} // RVA: 0x7FFAC332E940 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAC332E8E0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC332E9B0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC332ECB0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC332F060
        public void GetScriptClassName(){} // RVA: 0x7FFAC332F4E0
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist.CleanWhitelist(){} // RVA: 0x7FFAC332F770
        public void Update(){} // RVA: 0x7FFAC332F7C0
        public void Equals(){} // RVA: 0x7FFAC332FE80
        public void OnDisable(){} // RVA: 0x7FFAC332FED0
        public void OnDestroy(){} // RVA: 0x7FFAC332FF20
        public void OnApplicationPause(){} // RVA: 0x7FFAC2F4F130
        public void VRC.Udon.Common.Interfaces.IUdonSecurityFilter<UnityEngine.Object>.ApplyFilter(){} // RVA: 0x7FFAC3330510
        public void OnBecameVisible(){} // RVA: 0x7FFAC3330570
        public void OnBecameInvisible(){} // RVA: 0x7FFAC33305C0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC3330720
        public void OnCollisionStay(){} // RVA: 0x7FFAC3330780
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.get_DebugLogging(){} // RVA: 0x7FFAC3331A00
        public void OnTriggerEnter(){} // RVA: 0x7FFAC3331A10
        public void .ctor(){} // RVA: 0x7FFAC3331A70
        public void Initialize(){} // RVA: 0x7FFAC3331CC0
        public void get_article(){} // RVA: 0x7FFAC3331F50
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAC3331F60
        public void VRC.Udon.Common.Interfaces.IUdonWrapperFactory.GetWrapper(){} // RVA: 0x7FFAC3331FC0
        public void get_cageUpdateEveryFrame(){} // RVA: 0x7FFAC3332010
        public void FixedUpdate(){} // RVA: 0x7FFAC3332020
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist<UnityEngine.Object>.IsWhitelisted(){} // RVA: 0x7FFAC3332120
        public void LateUpdate(){} // RVA: 0x7FFAC3332180
        public void CheckAndApplyLightSettings(){} // RVA: 0x7FFAC3332190
        public void UpdateLightState(){} // RVA: 0x7FFAC3332540
        public void GetBufferedTimes_9F3E255BC5B7(){} // RVA: 0x7FFAC2F9E740
    }

    /// <summary>Originally: ÍÌÏÌÌÏÌÌÏÍÍÌÏÏÌÏÍÎÍÎÏÍÏ</summary>
    public class List1Derived_5A8D_5A8D : List`1
    {
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ ÎÌÍÌÎÏÍÎÎÍÏÎÏÌÍÏÌÎÍÎÏÎÍ; // 0x28

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAC4570C40
        public void Contains(){} // RVA: 0x7FFAC4570FC0
        public void Add(){} // RVA: 0x7FFAC4571340
        public void get_Capacity(){} // RVA: 0x7FFAC45716C0
        public void set_Capacity(){} // RVA: 0x7FFAC4571A40
        public void get_Count(){} // RVA: 0x7FFAC4571DC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC4572140
        public void .ctor(){} // RVA: 0x7FFAC45724C0
    }

    /// <summary>Originally: ÎÏÌÏÍÏÏÌÌÌÎÍÍÎÎÎÏÎÎÌÌÌÍ</summary>
    public class List1Derived_7631_7631 : List`1
    {
        public object _7631;

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAC3BD8A20
        public void Contains(){} // RVA: 0x7FFAC3BD8C10
        public void .ctor(){} // RVA: 0x7FFAC3BD8E00
        public void Initialize(){} // RVA: 0x7FFAC3BD8E80
        public void set_Capacity(){} // RVA: 0x7FFAC3BD9070
        public void get_Count(){} // RVA: 0x7FFAC3BD9220
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC3BD9410
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC3BD9600
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC3BD97F0
    }

    /// <summary>Originally: ÏÍÏÌÎÍÌÍÌÏÏÌÌÍÌÏÍÎÏÍÌÌÌ</summary>
    public class List1Derived_B854Sibling_EEEC
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAC2C70980
        // ── Unresolved (hash) ──
        public void m_BB5(){} // RVA: 0x7FFAC2C70980
        public void m_68E(){} // RVA: 0x7FFAC2C70A40
        public void m_BEE(){} // RVA: 0x7FFAC2C70A40
    }

    /// <summary>Originally: ÌÎÏÍÎÌÌÍÍÌÍÍÍÎÍÏÍÎÏÏÌÏÌ</summary>
    public class List1Derived_B854_B854 : List`1
    {
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ ÎÌÍÌÎÏÍÎÎÍÏÎÏÌÍÏÌÎÍÎÏÎÍ; // 0x28

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAC456F370
        public void Contains(){} // RVA: 0x7FFAC456F660
        public void CopyTo(){} // RVA: 0x7FFAC456F950
        public void .ctor(){} // RVA: 0x7FFAC456FC40
        public void Initialize(){} // RVA: 0x7FFAC456FD00
        public void get_Count(){} // RVA: 0x7FFAC456FF70
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC45701F0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC4570470
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC4570760
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC45709D0
    }

    /// <summary>Originally: ÌÏÍÌÏÎÏÍÎÎÎÎÏÏÌÎÍÍÎÏÎÎÎ</summary>
    public class ListContentView1Derived_1FA4_1FA4 : ListContentView`1
    {
        public UnityEngine.GameObject _headerPrefab;
        public UnityEngine.GameObject _layoutContainer;

        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x7FFAC2C70980
        public void get_MaxContentCount(){} // RVA: 0x7FFAC2C6A6F0
        public void GetTargets(){} // RVA: 0x7FFAC2C58F40
        public void GetMaterial(){} // RVA: 0x7FFAC2C58F40
        public void OnEnable(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    /// <summary>Originally: ÍÍÍÌÌÍÏÍÎÏÎÍÌÎÍÍÏÏÍÍÍÏÍ</summary>
    public class LocalizationManagerSibling_4BBA
    {
        public object f_708;
        public object f_510;
        public object f_86E;
        public object f_032;
        public object f_D44;
        public object f_B88;
        public object f_DAF;

        // ── Methods ──
        public void GetLocalizedText(){} // RVA: 0x7FFAC2C59D00
        public void SetLocalizedText(){} // RVA: 0x7FFAC2C70980
        public void ContainsChild(){} // RVA: 0x7FFAC2C70A40
        public void GetLast(){} // RVA: 0x7FFAC2C58E90
        public void GetLast_6DECA2D0F913(){} // RVA: 0x7FFAC2C58E90
        public void GetLast_6BDF262CBE83(){} // RVA: 0x7FFAC2C58E90
        public void GetLast_A260552D1012(){} // RVA: 0x7FFAC2C58E90
        public void GetLast_E516F5B08CE8(){} // RVA: 0x7FFAC2C58E90
        public void GetLast_C39871086522(){} // RVA: 0x7FFAC2C58E90
        public void GetLast_9CB5E8859466(){} // RVA: 0x7FFAC2C58E90
        public void GetLast_8ECD0B9CAFCE(){} // RVA: 0x7FFAC2C58E90
        public void GetLocalizedText_2EFCA22C9EC8(){} // RVA: 0x7FFAC2C59960
        public void UpdateLocalization(){}
        public void GetLocalizedFormat(){}
        public void HasLocalizedText(){}
        public void AddChild(){}
        public void RemoveChild(){}
        public void ClearChildren(){} // RVA: 0x7FFAC2C58F40
        public void GetFirst(){} // RVA: 0x7FFAC2C58F40
        public void ChangeEndValue(){} // RVA: 0x7FFAC2C696F0
        public void GetChild(){} // RVA: 0x7FFAC2C58F40
        public void ChangeEndValue_48C85416073C(){} // RVA: 0x7FFAC2C696F0
        public void GetChildCount(){} // RVA: 0x7FFAC2C58F40
        public void ChangeStartValue(){} // RVA: 0x7FFAC2C58F40
        public void ChangeEndValue_BCB8BEC580C1(){} // RVA: 0x7FFAC2C696F0
        public void GetLocalizationKey(){} // RVA: 0x7FFAC2C58F40
        public void SetLocalizationKey(){} // RVA: 0x7FFAC2C58F40
        public void ApplyLocalization(){}
    }

    /// <summary>Originally: ÏÍÍÏÍÌÍÏÏÎÎÏÏÎÎÌÌÌÌÍÍÏÎ</summary>
    public class LogoutExit_E6FB_E6FB : MonoBehaviour
    {
        // ── Methods ──
        public void Logout(){} // RVA: 0x7FFAC39B4E30
        public void RaiseCancellation(){} // RVA: 0x7FFAC42FF560
        public void IsInvoking(){} // RVA: 0x7FFAC42FF790
        public void CancelInvoke(){} // RVA: 0x7FFAC42FF7E0
        public void Exit(){} // RVA: 0x7FFAC42FFA10
        public void BackPressed(){} // RVA: 0x7FFAC39B4E30
        public void ReadColliderState(){} // RVA: 0x7FFAC42FFA60
        public void IsInvoking_1CD5E3FD4BB4(){} // RVA: 0x7FFAC42FFCB0
        public void StartCoroutine(){} // RVA: 0x7FFAC42FFEE0
        public void StartCoroutine_89164256BB10(){} // RVA: 0x7FFAC4300110
        public void GetFlagByte579(){} // RVA: 0x7FFAC39B4E30
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}