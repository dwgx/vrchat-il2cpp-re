// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Misc
// Classes: 9
// Methods: 143

namespace VRC.Misc
{
    /// <summary>Originally: ÍÌÌÏÎÎÎÎÎÌÍÏÌÍÏÍÏÎÎÌÍÏÌ</summary>
    public class LightManager : MonoBehaviour
    {
        public ÏÌÍÎÏÌÎÌÎÎÎÎÍÏÍÎÎÏÎÌÍÌÍ _lightReservedLayerMask; // 0x20
        public 0x66389750 _useGUILayout; // 0x78
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
        public 0x663897A8 ÌÌÎÏÍÌÏÏÏÏÍÏÍÍÏÍÎÏÎÏÍÏÎ; // 0xD0
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
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFD4E74CA00
        public void RaiseCancellation(){} // RVA: 0x7FFD4E74CC80
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void CancelInvoke(){} // RVA: 0x7FFD4E74CD60
        public void Invoke(){} // RVA: 0x7FFD4E74CDA0
        public void InvokeRepeating(){} // RVA: 0x7FFD4E36F0C0
        public void OnTriggerStay_D9D42DA66D2C(){} // RVA: 0x7FFD4E751A60 | overloaded x2
        public void IsInvoking(){} // RVA: 0x7FFD4E74D420
        public void StartCoroutine(){} // RVA: 0x7FFD4E74D7D0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFD4E74D900
        public void GetHashCode(){} // RVA: 0x7FFD4E74D960
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E74DA40
        public void VRC.Udon.Common.Interfaces.IUdonSecurityFilter.ApplyFilter(){} // RVA: 0x7FFD4E090A40
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.set_DebugLogging(){} // RVA: 0x7FFD4E74DA60
        public void .cctor(){} // RVA: 0x7FFD4E74DA70
        public void StopAllCoroutines(){} // RVA: 0x7FFD4E74DE70
        public void VRC.Udon.Common.Interfaces.IUdonVMFactory.ConstructUdonVM(){} // RVA: 0x7FFD4E74DFD0
        public void set_useGUILayout(){} // RVA: 0x7FFD4E74E020
        public void ToString(){} // RVA: 0x7FFD4E74E090
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4E74E210
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void InvokeDelayed(){} // RVA: 0x7FFD4E74E700
        public void get_ipsQuery(){} // RVA: 0x7FFD4E3AC2A0
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist<UnityEngine.Object>.Whitelist(){} // RVA: 0x7FFD4E74E940 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFD4E74E8E0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4E74E9B0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4E74ECB0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4E74F060
        public void GetScriptClassName(){} // RVA: 0x7FFD4E74F4E0
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist.CleanWhitelist(){} // RVA: 0x7FFD4E74F770
        public void Update(){} // RVA: 0x7FFD4E74F7C0
        public void Equals(){} // RVA: 0x7FFD4E74FE80
        public void OnDisable(){} // RVA: 0x7FFD4E74FED0
        public void OnDestroy(){} // RVA: 0x7FFD4E74FF20
        public void OnApplicationPause(){} // RVA: 0x7FFD4E36F130
        public void VRC.Udon.Common.Interfaces.IUdonSecurityFilter<UnityEngine.Object>.ApplyFilter(){} // RVA: 0x7FFD4E750510
        public void OnBecameVisible(){} // RVA: 0x7FFD4E750570
        public void OnBecameInvisible(){} // RVA: 0x7FFD4E7505C0
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E750720
        public void OnCollisionStay(){} // RVA: 0x7FFD4E750780
        public void VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface.get_DebugLogging(){} // RVA: 0x7FFD4E751A00
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E751A10
        public void .ctor(){} // RVA: 0x7FFD4E751A70
        public void Initialize(){} // RVA: 0x7FFD4E751CC0
        public void get_article(){} // RVA: 0x7FFD4E751F50
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFD4E751F60
        public void VRC.Udon.Common.Interfaces.IUdonWrapperFactory.GetWrapper(){} // RVA: 0x7FFD4E751FC0
        public void get_cageUpdateEveryFrame(){} // RVA: 0x7FFD4E752010
        public void FixedUpdate(){} // RVA: 0x7FFD4E752020
        public void VRC.Udon.Security.Interfaces.IUdonSecurityWhitelist<UnityEngine.Object>.IsWhitelisted(){} // RVA: 0x7FFD4E752120
        public void LateUpdate(){} // RVA: 0x7FFD4E752180
        public void CheckAndApplyLightSettings(){} // RVA: 0x7FFD4E752190
        public void UpdateLightState(){} // RVA: 0x7FFD4E752540
        public void GetBufferedTimes_9F3E255BC5B7(){} // RVA: 0x7FFD4E3BE740
    }

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
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFD4E078E90
        public void RaiseCancellation(){} // RVA: 0x7FFD4E078E90
        public void GetLanguage(){} // RVA: 0x7FFD4E078E90
        public void CancelInvoke(){} // RVA: 0x7FFD4E079D00
        public void ResolveLastServiceDescriptor(){} // RVA: 0x7FFD4E078E90
        public void InvokeRepeating(){} // RVA: 0x7FFD4E078E90
        public void OnTriggerStay(){} // RVA: 0x7FFD4E079F60
        public void Enable(){} // RVA: 0x7FFD4E091060
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFD4E090980
    }

    /// <summary>Originally: ÏÍÏÌÎÍÌÍÌÏÏÌÌÍÌÏÍÎÏÍÌÌÌ</summary>
    public class List1DerivedSibling_EEEC
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E090980
        public void Short(){} // RVA: 0x7FFD4E090980
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void ContainsChild_BEEDC29A6EBA(){} // RVA: 0x7FFD4E090A40
    }

    /// <summary>Originally: ÍÌÏÌÌÏÌÌÏÍÍÌÏÏÌÏÍÎÍÎÏÍÏ</summary>
    public class List1Derived_5A8D : List`1
    {
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ ÎÌÍÌÎÏÍÎÎÍÏÎÏÌÍÏÌÎÍÎÏÎÍ; // 0x28

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4F990C40
        public void Contains(){} // RVA: 0x7FFD4F990FC0
        public void Add(){} // RVA: 0x7FFD4F991340
        public void get_Capacity(){} // RVA: 0x7FFD4F9916C0
        public void set_Capacity(){} // RVA: 0x7FFD4F991A40
        public void get_Count(){} // RVA: 0x7FFD4F991DC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4F992140
        public void .ctor(){} // RVA: 0x7FFD4F9924C0
    }

    /// <summary>Originally: ÎÏÌÏÍÏÏÌÌÌÎÍÍÎÎÎÏÎÎÌÌÌÍ</summary>
    public class List1Derived_7631 : List`1
    {
        public object _7631;

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4EFF8A20
        public void Contains(){} // RVA: 0x7FFD4EFF8C10
        public void .ctor(){} // RVA: 0x7FFD4EFF8E00
        public void Initialize(){} // RVA: 0x7FFD4EFF8E80
        public void set_Capacity(){} // RVA: 0x7FFD4EFF9070
        public void get_Count(){} // RVA: 0x7FFD4EFF9220
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4EFF9410
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4EFF9600
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4EFF97F0
    }

    /// <summary>Originally: ÌÎÏÍÎÌÌÍÍÌÍÍÍÎÍÏÍÎÏÏÌÏÌ</summary>
    public class List1Derived_B854 : List`1
    {
        public ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ ÎÌÍÌÎÏÍÎÎÍÏÎÏÌÍÏÌÎÍÎÏÎÍ; // 0x28

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4F98F370
        public void Contains(){} // RVA: 0x7FFD4F98F660
        public void CopyTo(){} // RVA: 0x7FFD4F98F950
        public void .ctor(){} // RVA: 0x7FFD4F98FC40
        public void Initialize(){} // RVA: 0x7FFD4F98FD00
        public void get_Count(){} // RVA: 0x7FFD4F98FF70
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4F9901F0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4F990470
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4F990760
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4F9909D0
    }

    /// <summary>Originally: ÌÏÍÌÏÎÏÍÎÎÎÎÏÏÌÎÍÍÎÏÎÎÎ</summary>
    public class ListContentView1Derived_1FA4 : ListContentView`1
    {
        // ── Methods ──
        public void get_CountFormat(){} // RVA: 0x7FFD4E090980
        public void get_MaxContentCount(){} // RVA: 0x7FFD4E08A6F0
        public void GetTargets(){} // RVA: 0x7FFD4E078F40
        public void GetMaterial(){} // RVA: 0x7FFD4E078F40
        public void OnEnable(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
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
        public void GetLocalizedText(){} // RVA: 0x7FFD4E079D00
        public void SetLocalizedText(){} // RVA: 0x7FFD4E090980
        public void ContainsChild(){} // RVA: 0x7FFD4E090A40
        public void GetLast(){} // RVA: 0x7FFD4E078E90
        public void GetLast_6DECA2D0F913(){} // RVA: 0x7FFD4E078E90
        public void GetLast_6BDF262CBE83(){} // RVA: 0x7FFD4E078E90
        public void GetLast_A260552D1012(){} // RVA: 0x7FFD4E078E90
        public void GetLast_E516F5B08CE8(){} // RVA: 0x7FFD4E078E90
        public void GetLast_C39871086522(){} // RVA: 0x7FFD4E078E90
        public void GetLast_9CB5E8859466(){} // RVA: 0x7FFD4E078E90
        public void GetLast_8ECD0B9CAFCE(){} // RVA: 0x7FFD4E078E90
        public void GetLocalizedText_2EFCA22C9EC8(){} // RVA: 0x7FFD4E079960
        public void UpdateLocalization(){}
        public void GetLocalizedFormat(){}
        public void HasLocalizedText(){}
        public void AddChild(){}
        public void RemoveChild(){}
        public void ClearChildren(){} // RVA: 0x7FFD4E078F40
        public void GetFirst(){} // RVA: 0x7FFD4E078F40
        public void ChangeEndValue(){} // RVA: 0x7FFD4E0896F0
        public void GetChild(){} // RVA: 0x7FFD4E078F40
        public void ChangeEndValue_48C85416073C(){} // RVA: 0x7FFD4E0896F0
        public void GetChildCount(){} // RVA: 0x7FFD4E078F40
        public void ChangeStartValue(){} // RVA: 0x7FFD4E078F40
        public void ChangeEndValue_BCB8BEC580C1(){} // RVA: 0x7FFD4E0896F0
        public void GetLocalizationKey(){} // RVA: 0x7FFD4E078F40
        public void SetLocalizationKey(){} // RVA: 0x7FFD4E078F40
        public void ApplyLocalization(){}
    }

    /// <summary>Originally: ÏÍÍÏÍÌÍÏÏÎÎÏÏÎÎÌÌÌÌÍÍÏÎ</summary>
    public class LogoutExit_E6FB : MonoBehaviour
    {
        // ── Methods ──
        public void Logout(){} // RVA: 0x7FFD4EDD4E30
        public void RaiseCancellation(){} // RVA: 0x7FFD4F71F560
        public void IsInvoking(){} // RVA: 0x7FFD4F71F790
        public void CancelInvoke(){} // RVA: 0x7FFD4F71F7E0
        public void Exit(){} // RVA: 0x7FFD4F71FA10
        public void BackPressed(){} // RVA: 0x7FFD4EDD4E30
        public void ReadColliderState(){} // RVA: 0x7FFD4F71FA60
        public void IsInvoking_1CD5E3FD4BB4(){} // RVA: 0x7FFD4F71FCB0
        public void StartCoroutine(){} // RVA: 0x7FFD4F71FEE0
        public void StartCoroutine_89164256BB10(){} // RVA: 0x7FFD4F720110
        public void GetFlagByte579(){} // RVA: 0x7FFD4EDD4E30
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}