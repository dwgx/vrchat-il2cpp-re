// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Component
// Classes: 100
// Methods: 1486

namespace VRC.Core.Component
{
    /// <summary>Originally: ÍÌÎÎÏÏÍÎÎÏÎÎÍÍÌÌÍÍÎÎÎÌÌ</summary>
    public class LateUpdateComponent_789C : MonoBehaviour
    {
        public object _buffer; // 0x33687940, was: ÍÍÏÏÌÎÎÍÍÎÏÎÏÏÌÍÏÌÌÏÏÍÎ
        public object _collider; // 0x33687940, was: ÌÌÏÏÏÎÍÏÏÏÎÎÍÌÌÌÏÌÎÌÏÍÍ
        public object _amount; // 0x33687940, was: ÎÏÎÌÌÏÎÏÌÍÎÌÍÍÍÎÍÏÍÎÎÍÌ
        public object _stfix; // 0x33687940, was: ÎÍÌÌÌÏÌÎÌÌÍÏÌÏÍÏÍÍÌÍÎÌÏ
        public object _matrix; // 0x33687940, was: ÏÏÏÎÌÍÏÌÍÏÏÍÌÍÌÌÎÌÏÏÏÎÍ
        public object _amut; // 0x33687940, was: ÎÎÎÌÎÏÍÏÎÎÎÌÍÏÍÏÏÍÎÎÌÌÍ
        public object _dateTime; // 0x33687940, was: ÏÍÍÍÍÌÍÎÏÎÌÌÌÎÎÏÍÎÍÌÍÌÎ
        public object _flag; // 0x33687940, was: ÌÎÎÍÌÎÎÎÎÎÎÎÎÎÌÎÎÏÍÌÎÍÎ
        public object _text; // 0x33687940, was: ÌÎÍÎÍÍÏÏÍÎÎÌÌÍÎÍÏÏÍÎÌÏÍ

        // ── Original Methods ──
        public void Computeparameters(){} // RVA: 0x7ffaaa09ec00
        public void RaiseCancellation(){} // RVA: 0x7ffaaa09ece0
        public void IsInvoking(){} // RVA: 0x7ffaaa09f020
        public void LateUpdate(){} // RVA: 0x7ffaaa09f100
        public void InvokeRepeating(){} // RVA: 0x7ffaaa09f460
        public void OnApplicationQuit(){} // RVA: 0x7ffaaa09f520
        public void StartCoroutine(){} // RVA: 0x7ffaaa09f600
        public void UpdateActive(){} // RVA: 0x7ffaaa09f810
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaaa09fb30
        public void OnDisable(){} // RVA: 0x7ffaaa09fc50
        public void StopCoroutine(){} // RVA: 0x7ffaaa09fc60
        public void StopAllCoroutines(){} // RVA: 0x7ffaaa09fd20
        public void .ctor(){} // RVA: 0x7ffaaa09fe00
        public void Initialize(){} // RVA: 0x7ffaaa0a0240
        public void print(){} // RVA: 0x7ffaaa0a0560
        public void OnEnable(){} // RVA: 0x7ffaaa0a0ac0
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffaaa0a0c40
        public void InvokeDelayed(){} // RVA: 0x7ffaaa0a0db0
        public void CancelInvoke(){} // RVA: 0x7ffaa8a4f100
        public void UpdatelocalScale_I(){} // RVA: 0x7ffaaa0a0e90
        public void IsObjectMonoBehaviour(){} // RVA: 0x7ffaaa0a2000
        public void StartCoroutineManaged(){} // RVA: 0x7ffaaa0a20c0
        public void StartCoroutineManaged2(){} // RVA: 0x7ffaaa0a21e0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7ffaaa0a2930
        public void UpdaterenderQueue(){} // RVA: 0x7ffaaa0a2d40
        public void OnCollisionStay(){} // RVA: 0x7ffaaa0a2e40
        public void OnCollisionExit(){} // RVA: 0x7ffaaa0a2ed0
        public void OnTriggerEnter(){} // RVA: 0x7ffaaa0a3260
        public void OnTriggerStay(){} // RVA: 0x7ffaaa0a34c0
        public void ComputeLateUpdateData(){} // RVA: 0x7ffaaa0a39f0
        public void ProcessConcurrentLateUpdateOperations(){} // RVA: 0x7ffaaa0a3a80
        // ── Binary Analysis Named ──
        public void CheckIsDone_EE8(){} // RVA: 0x7ffaaa09f210
        public void GetMaterial(){} // RVA: 0x7ffaa89add50
        public void DoDestroy_EE1(){} // RVA: 0x7ffaaa09f100
        public void GetTexture(){} // RVA: 0x7ffaa8a4f100
        public void DoStringToHash(){} // RVA: 0x7ffaaa0a2310
        public void DoNameToID(){} // RVA: 0x7ffaaa0a29c0
        public void DoGetGraphicsUVStartsAtTop_0A1(){} // RVA: 0x7ffaaa0a3660
    }

    /// <summary>Originally: ÌÌÏÍÎÎÎÏÎÍÎÍÍÏÎÌÍÌÎÍÍÏÌ</summary>
    public class LifecycleComponentImplSibling_A3B6 : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab10df1b0
        public void RaiseCancellation(){} // RVA: 0x7ffab10df410
        public void IsInvoking(){} // RVA: 0x7ffab10df650
        public void CancelInvoke(){} // RVA: 0x7ffab10df890
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab10dfaf0
        // ── Binary Analysis Named ──
        public void SetCancellationCallback(){} // RVA: 0x7ffab10dfd30
        // ── Obfuscated Methods ──
        public void m_CF9(){} // RVA: 0x7ffab10dff90
    }

    /// <summary>Originally: ÎÍÌÏÌÏÏÌÍÍÎÌÎÎÎÎÌÏÍÍÎÎÎ</summary>
    public class LifecycleComponentImpl_1CB1 : LifecycleComponent_4809
    {
        // ── Original Methods ──
        public void InitializeComponentDependencies(){} // RVA: 0x7ffab0df2320
        public void .ctor(){} // RVA: 0x7ffab0df2420
        public void Initialize(){} // RVA: 0x7ffab0df2460
        public void PerformComplexLifecycleUpdate(){} // RVA: 0x7ffab0df2630
        // ── Binary Analysis Named ──
        public void SetupInternalResources(){} // RVA: 0x7ffab0df1e50
        public void GetPropertyValueForLifecycle(){} // RVA: 0x7ffab0df2580
    }

    /// <summary>Originally: ÌÏÏÎÍÎÎÏÌÏÏÎÏÌÎÌÎÍÎÏÍÏÏ</summary>
    public class LifecycleComponentImpl_2162 : LifecycleComponent_CD20
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab0fff030
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef71320
        public void Computetransform(){} // RVA: 0x7ffab0fff5e0
        // ── Binary Analysis Named ──
        public void GetLifecycleProcessedValue(){} // RVA: 0x7ffab0fff590
    }

    /// <summary>Originally: ÍÍÍÍÌÏÌÏÍÎÏÌÎÍÌÍÎÌÍÎÏÍÌ</summary>
    public class LifecycleComponentImpl_2466 : LifecycleComponent_14F3
    {
        public object _flag; // 0x336D66E0, was: ÌÎÌÌÎÏÏÌÍÎÏÎÍÍÌÏÍÍÏÌÏÍÎ
        public object f_B38; // 0x33C649B0, was: ÌÏÎÍÍÏÎÏÏÌÏÍÌÌÎÌÏÍÏÌÎÏÍ

        // ── Original Methods ──
        public void IsComponentActiveAndReady(){} // RVA: 0x7ffaa9cd2990
        public void Awake(){} // RVA: 0x7ffaa9cd2620
        public void OnEnable(){} // RVA: 0x7ffaa9cd2ac0
        public void .ctor(){} // RVA: 0x7ffaa9cd2ae0
        public void Update(){} // RVA: 0x7ffaa9cd2b40
        public void Start(){} // RVA: 0x7ffaa9cd2ee0
        // ── Binary Analysis Named ──
        public void SetFlagAndNotifyIfUnchanged(){} // RVA: 0x7ffaa9cd22b0
        public void DoFindRelativeTran(){} // RVA: 0x7ffaa9cd22d0
        public void SetFlagAndNotifyIfChanged(){} // RVA: 0x7ffaa9cd2620
        public void DoFindRelativeTransformWithPath(){} // RVA: 0x7ffaa9cd2640
        public void SetSecondaryFlagAndNotifyIfChanged(){} // RVA: 0x7ffaa9cd2ac0
        // ── Obfuscated Methods ──
        public void m_DDF(){} // RVA: 0x7ffaa9cd22b0
    }

    /// <summary>Originally: ÎÎÏÌÍÌÏÌÍÎÎÍÏÍÎÌÌÎÎÎÍÍÍ</summary>
    public class LifecycleComponentImpl_2EE7 : LifecycleComponent_33D4
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9a29440
        public void LateUpdate(){} // RVA: 0x7ffaa9a29760
        public void OnDisable(){} // RVA: 0x7ffaa9a298a0
        public void OnDestroy(){} // RVA: 0x7ffaa9a29a30
        public void OnApplicationPause(){} // RVA: 0x7ffaa9a29b70
        public void Awake(){} // RVA: 0x7ffaa9a29c00
        public void Start(){} // RVA: 0x7ffaa9a29d90
        public void Update(){} // RVA: 0x7ffaa9a29e50
        public void OnCollisionEnter(){} // RVA: 0x7ffaa9a29fe0
        public void OnCollisionStay(){} // RVA: 0x7ffaa9a2a120
        public void OnCollisionExit(){} // RVA: 0x7ffaa9a2a260
        // ── Binary Analysis Named ──
        public void GetterrainData(){} // RVA: 0x7ffaa9a295d0
    }

    /// <summary>Originally: ÏÍÌÎÎÌÏÌÍÏÍÌÌÎÏÍÌÏÍÍÍÍÌ</summary>
    public class LifecycleComponentImpl_C64A : LifecycleComponent_33D4
    {
        // ── Original Methods ──
        public void CreateAndInitializeComponentStructure(){} // RVA: 0x7ffaa9a20440
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9a204d0
        // ── Binary Analysis Named ──
        public void SetBoolPropertyAndInvokeMethod(){} // RVA: 0x7ffaa9a20340
    }

    /// <summary>Originally: ÎÌÍÍÌÎÎÎÍÎÍÏÍÎÎÏÎÍÍÌÏÏÌ</summary>
    public class LifecycleComponentImpl_F7E0 : LifecycleComponent_5E9C
    {
        // ── Original Methods ──
        public void HandleLifecycleEvent(){} // RVA: 0x7ffaa920db50
        public void .ctor(){} // RVA: 0x7ffaa898c060
    }

    /// <summary>Originally: ÍÍÌÍÎÎÏÌÍÌÌÌÏÌÎÏÏÎÍÎÎÏÏ</summary>
    public class LifecycleComponentSiblingSibliSibling_170B : MonoBehaviour
    {
        public object _170B; // 0x3366E860, was: ÌÌÍÎÏÍÎÎÍÌÍÎÌÍÏÍÎÎÌÏÌÌÌ
        public object _selectionBinding; // 0x319BEE90

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab1378240
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab1378310
        public void CancelInvoke(){} // RVA: 0x7ffab13783e0
        public void Invoke(){} // RVA: 0x7ffab1378770
        public void InvokeRepeating(){} // RVA: 0x7ffab1378b00
        public void InitializeStaticVariables1(){} // RVA: 0x7ffab1378bd0
        public void IsInvoking(){} // RVA: 0x7ffab1378c60
        public void StartCoroutine(){} // RVA: 0x7ffab1378ff0
        public void InitializeStaticVariables2(){} // RVA: 0x7ffab1379080
    }

    /// <summary>Originally: ÍÌÏÏÎÎÎÎÏÍÎÌÏÎÎÌÏÏÏÌÎÎÏ</summary>
    public class LifecycleComponentSiblingSibliSibling_C1DA : LifecycleComponent_6D56
    {
        public object rotator; // 0x3374E6B0
        public object _c1DA; // 0x3374E6B0, was: ÍÌÎÎÏÏÏÏÌÌÎÌÏÏÍÌÎÏÍÏÌÎÌ

        // ── Original Methods ──
        public void UpdateRotationAndTransform(){} // RVA: 0x7ffab11e5440
        public void Updateenabled(){} // RVA: 0x7ffab11e58e0
        public void UpdateAndVerifyTransform(){} // RVA: 0x7ffab11e5c80
        public void .ctor(){} // RVA: 0x7ffab11e6240
        public void ComputerectTransform(){} // RVA: 0x7ffab11e67b0
        // ── Binary Analysis Named ──
        public void Getrect_Injected(){} // RVA: 0x7ffab11e4980
        public void GetTransform_7F0(){} // RVA: 0x7ffab11e4cf0
        public void GetTransform_53B(){} // RVA: 0x7ffab11e4d90
        public void GetTransform_A8F(){} // RVA: 0x7ffab11e5230
        public void Setenabled(){} // RVA: 0x7ffab11e5ab0
        public void GetGameObject_F54(){} // RVA: 0x7ffab11e5de0
        public void GetTransform_2E0(){} // RVA: 0x7ffab11e61e0
        public void GetTransform_47D(){} // RVA: 0x7ffab11e6310
        public void GetTransform_2E0(){} // RVA: 0x7ffab11e61e0
        public void SetBehaviourEnabledState(){} // RVA: 0x7ffab11e6c10
        public void SetBehaviourEnabledStateDuplicate(){} // RVA: 0x7ffab11e6de0
        public void SetBehaviourEnabledStateThird(){} // RVA: 0x7ffab11e6fb0
        // ── Obfuscated Methods ──
        public void m_26F(){} // RVA: 0x7ffab11e6bb0
    }

    /// <summary>Originally: ÍÍÎÍÌÎÎÎÏÎÎÌÎÏÍÌÎÌÏÎÎÎÍ</summary>
    public class LifecycleComponentSibling_2EAF : MonoBehaviour
    {
        public object cropControlsParent; // 0x3366DE30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void UpdateActive(){} // RVA: 0x7ffaa8dcc5a0
        public void IsInvoking(){} // RVA: 0x7ffaa8dcc5a0
        public void CancelInvoke(){} // RVA: 0x7ffaa8dcc720
        public void Invoke(){} // RVA: 0x7ffaa8dcc8a0
        public void InvokeRepeating(){} // RVA: 0x7ffaa8dcca10
        public void EnableControlAndSetActive(){} // RVA: 0x7ffaa8dccb80
        public void DisableControlAndSetInactive(){} // RVA: 0x7ffaa8dccbc0
    }

    /// <summary>Originally: ÎÌÏÏÏÍÏÍÌÏÍÍÌÏÌÌÎÍÍÎÌÌÌ</summary>
    public class LifecycleComponentSibling_43D9
    {
        // ── Original Methods ──
        public void InvokeGetBufferCallback(){} // RVA: 0x7ffaa8660d80
        public void InvokeGetBufferWithTwoArguments(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void CheckBufferAvailability(){} // RVA: 0x7ffaa864a040
        public void GetBuffer(){} // RVA: 0x7ffaa8658120
        // ── Obfuscated Methods ──
        public void m_9A0(){} // RVA: 0x7ffaa86491d0
        public void m_960(){} // RVA: 0x7ffaa86491d0
        public void m_7B2(){} // RVA: 0x7ffaa86491d0
        public void m_39C(){} // RVA: 0x7ffaa86491d0
        public void m_C96(){} // RVA: 0x7ffaa86491d0
        public void m_C22(){}
        public void m_A35(){}
        public void m_2C8(){}
    }

    /// <summary>Originally: ÌÏÏÌÍÌÏÎÎÌÎÍÍÎÌÍÏÍÏÎÏÌÎ</summary>
    public class LifecycleComponentSibling_DCB3
    {
        // ── Obfuscated Methods ──
        public void m_FF7(){} // RVA: 0x7ffaa86491d0
        public void m_BB4(){} // RVA: 0x7ffaa86491d0
        public void m_7FD(){} // RVA: 0x7ffaa86491d0
    }

    /// <summary>Originally: ÍÎÎÍÏÍÍÌÌÌÎÎÏÎÍÎÍÏÎÌÍÌÎ</summary>
    public class LifecycleComponent_00530 : MonoBehaviour
    {
        public object _ePathName; // 0x336BE7C0, was: ÎÎÌÌÏÎÎÌÏÍÏÌÍÎÎÏÏÏÎÌÏÌÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab11ce370
        public void Start(){} // RVA: 0x7ffab11ce460
        public void IsInvoking(){} // RVA: 0x7ffab11ce7e0
        public void CancelInvoke(){} // RVA: 0x7ffab11ce970
        public void Invoke(){} // RVA: 0x7ffab11ceb20
        public void InvokeRepeating(){} // RVA: 0x7ffab11cec10
        public void OnDisable(){} // RVA: 0x7ffab11ceda0
        public void OnDestroy(){} // RVA: 0x7ffab11cee90
        public void StartCoroutine(){} // RVA: 0x7ffab11cf210
        public void OnEnable(){} // RVA: 0x7ffab11cf590
        public void OnBecameInvisible(){} // RVA: 0x7ffab11cf690
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab11cf780
        public void StopCoroutine(){} // RVA: 0x7ffab11cfb00
    }

    /// <summary>Originally: ÎÎÎÏÌÍÍÏÍÍÌÏÎÍÍÎÌÎÎÍÎÏÍ</summary>
    public class LifecycleComponent_014A : MonoBehaviour
    {
        public object _014A; // 0x337268B0, was: ÎÌÌÍÍÏÌÎÌÍÌÍÏÏÌÌÍÍÎÏÏÏÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0d7bfa0
        public void RaiseCancellation(){} // RVA: 0x7ffab0d7c280
        public void IsInvoking(){} // RVA: 0x7ffab0d7c7b0
        public void CancelInvoke(){} // RVA: 0x7ffab0d7ca70
        public void Invoke(){} // RVA: 0x7ffab0d7cd80
        public void InvokeRepeating(){} // RVA: 0x7ffab0d7cde0
        public void ResetInternalState(){} // RVA: 0x7ffab0d7cde0
        public void FixedUpdate(){} // RVA: 0x7ffab0d7cdf0
        public void Awake(){} // RVA: 0x7ffab0d7cf50
        public void StartCoroutine(){} // RVA: 0x7ffab0d7d230
        public void OnDisable(){} // RVA: 0x7ffab0d7d2d0
        public void OnDestroy(){} // RVA: 0x7ffab0d7d520
        public void Start(){} // RVA: 0x7ffab0d7d830
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab0d7daf0
    }

    /// <summary>Originally: ÍÏÎÍÍÍÍÌÍÌÎÌÌÎÏÎÎÏÏÎÌÌÏ</summary>
    public class LifecycleComponent_01C2 : MonoBehaviour
    {
        public object visualAid; // 0x33726DE0
        public object _amount; // 0x33726DE0, was: ÍÍÏÏÎÍÎÌÌÎÏÌÎÍÌÌÏÍÌÎÎÍÌ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9493a70
        public void UpdatelocalScale_I(){} // RVA: 0x7ffaa94941a0
        public void Invoke(){} // RVA: 0x7ffaa94948a0
        public void Updateposition_Inj(){} // RVA: 0x7ffaa9494970
        public void UpdateActive(){} // RVA: 0x7ffaa9494ba0
        public void IsInvoking(){} // RVA: 0x7ffaa9494df0
        public void StartCoroutine(){} // RVA: 0x7ffaa9494eb0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9494df0
        public void StopCoroutine(){} // RVA: 0x7ffaa94953e0
        public void Awake(){} // RVA: 0x7ffaa9495480
        public void Start(){} // RVA: 0x7ffaa9495520
        public void get_useGUILayout(){} // RVA: 0x7ffaa9495770
        // ── Binary Analysis Named ──
        public void CheckIsDone_9F0(){} // RVA: 0x7ffaa9493ac0
        public void CheckIsDone_3F4(){} // RVA: 0x7ffaa94947d0
        public void Gettransform(){} // RVA: 0x7ffaa9494f80
        public void CheckIsDone_F23(){} // RVA: 0x7ffaa94951b0
        public void CheckIsDone_3F8(){} // RVA: 0x7ffaa9494df0
    }

    /// <summary>Originally: ÌÏÎÌÏÎÏÌÍÏÏÌÎÍÌÌÍÌÏÌÍÏÎ</summary>
    public class LifecycleComponent_0352 : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab111fc90
        public void RaiseCancellation(){} // RVA: 0x7ffab111ff20
        public void IsInvoking(){} // RVA: 0x7ffab11201b0
        public void Start(){} // RVA: 0x7ffab1120440
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab1120960
        // ── Binary Analysis Named ──
        public void SetActive_348(){} // RVA: 0x7ffab11206d0
    }

    /// <summary>Originally: ÌÍÎÎÎÎÍÌÎÌÌÏÍÍÎÏÍÍÏÍÏÎÌ</summary>
    public class LifecycleComponent_053F : MonoBehaviour
    {
        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffaa90c0dd0
        public void OnHandFocusAcquired(){} // RVA: 0x7ffaa9572620
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9572620
        public void Invoke(){} // RVA: 0x7ffaa90c0dd0
        public void InvokeRepeating(){} // RVA: 0x7ffaa90c0dd0
        public void CancelInvoke(){} // RVA: 0x7ffaa9572620
        public void Start(){} // RVA: 0x7ffaa90c0dd0
    }

    /// <summary>Originally: ÏÌÍÍÌÏÎÏÍÏÍÍÎÌÎÌÍÎÏÏÍÍÏ</summary>
    public class LifecycleComponent_0645 : MonoBehaviour
    {
        public object titleText; // 0x3370D490
        public object groupPrevButton; // 0x3370D490
        public object insertObj; // 0x3370D490
        public object actionMenu; // 0x3370D490
        public object moveIcon; // 0x3370D490
        public object f_652; // 0x3370D490, was: ÎÏÍÏÏÎÌÏÌÎÍÍÍÍÎÎÎÍÌÎÌÍÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0d39500
        public void UpdateActive(){} // RVA: 0x7ffab0d39650
        public void IsInvoking(){} // RVA: 0x7ffab0d397d0
        public void CancelInvoke(){} // RVA: 0x7ffab0d39aa0
        public void OnDisable(){} // RVA: 0x7ffab0d39e20
        public void InvokeRepeating(){} // RVA: 0x7ffab0d39e30
        public void OnApplicationQuit(){} // RVA: 0x7ffab0d3a750
        public void StartCoroutine(){} // RVA: 0x7ffab0d3a7c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void StopCoroutine(){} // RVA: 0x7ffab0d3ada0
        public void OnTriggerEnter(){} // RVA: 0x7ffab0d3af50
        public void ConfigureTag(){} // RVA: 0x7ffab0d3b040
        public void StopAllCoroutines(){} // RVA: 0x7ffab0d3be80
        public void get_useGUILayout(){} // RVA: 0x7ffab0d3c080
        public void set_useGUILayout(){} // RVA: 0x7ffab0d3c160
        public void Start(){} // RVA: 0x7ffab0d3c490
        public void InvokeDelayed(){} // RVA: 0x7ffab0d3c6f0
        public void Update(){} // RVA: 0x7ffab0d3c7f0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7ffab0d3cd70
        public void StartCoroutineManaged(){} // RVA: 0x7ffab0d3cde0
        public void StartCoroutineManaged2(){} // RVA: 0x7ffab0d3d180
        public void StopCoroutineManaged(){} // RVA: 0x7ffab0d3d3b0
        // ── Binary Analysis Named ──
        public void DoGetFormattedFallbackText(){} // RVA: 0x7ffab0d3a1b0
        public void GetGameObject_CEF(){} // RVA: 0x7ffab0d3a9e0
        public void GetGameObject_F83(){} // RVA: 0x7ffab0d3aad0
        public void GetGameObject_0F3(){} // RVA: 0x7ffab0d3c1f0
        public void GetGameObject_9C5(){} // RVA: 0x7ffab0d3c260
        public void GetGameObject_C2B(){} // RVA: 0x7ffab0d3c970
        public void GetGameObject_ABE(){} // RVA: 0x7ffab0d3d7b0
        public void GetGameObject_312(){} // RVA: 0x7ffab0d3d840
        public void GetGameObject_32F(){} // RVA: 0x7ffab0d3d940
        public void GetGameObject_A7E(){} // RVA: 0x7ffab0d3d9b0
        public void GetGameObject_BA5(){} // RVA: 0x7ffab0d3daf0
    }

    /// <summary>Originally: ÎÍÎÏÌÌÎÎÌÌÎÍÎÍÌÍÏÍÌÏÌÌÎ</summary>
    public class LifecycleComponent_08EB : MonoBehaviour
    {
        public object _flag; // 0x336D4A10, was: ÏÌÍÍÎÌÍÌÎÌÎÎÌÍÌÌÍÌÎÎÎÍÏ
        public object _text; // 0x336D4A10, was: ÌÎÎÍÍÌÌÎÌÎÏÍÌÌÌÌÍÌÎÌÍÌÍ
        public object f_335; // 0xB3F6FFF0, was: ÏÎÍÏÌÏÍÎÍÏÎÎÍÌÍÍÎÍÍÎÎÏÎ

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa9de6040
        public void get_Loop(){} // RVA: 0x7ffaa894d7c0
        public void CancelInvoke(){} // RVA: 0x7ffaa9de6310
        public void Invoke(){} // RVA: 0x7ffaa9de63b0
        public void InvokeRepeating(){} // RVA: 0x7ffaa894d7c0
        public void OnApplicationPause(){} // RVA: 0x7ffaa9de6540
        public void IsInvoking(){} // RVA: 0x7ffaa9de66e0
        public void StartCoroutine(){} // RVA: 0x7ffaa9de6800
        public void OnBecameInvisible(){} // RVA: 0x7ffaa9de68a0
        public void OnCollisionEnter(){} // RVA: 0x7ffaa9de6940
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa894d7c0
        public void StopCoroutine(){} // RVA: 0x7ffaa9de69e0
        public void OnTriggerEnter(){} // RVA: 0x7ffaa894d7c0
        public void OnTriggerStay(){} // RVA: 0x7ffaa9de6a80
        public void StopAllCoroutines(){} // RVA: 0x7ffaa9de6b20
        public void get_useGUILayout(){} // RVA: 0x7ffaa9de6e70
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9de6f10
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffaa9de7150
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffaa9de7300
        public void InvokeDelayed(){} // RVA: 0x7ffaa9de73a0
        public void UpdateLifecycleState(){} // RVA: 0x7ffaa9de7530
        public void InitializeLifecycleReference(){} // RVA: 0x7ffaa9de7a00
        // ── Binary Analysis Named ──
        public void DoToUnixTimeSeconds(){} // RVA: 0x7ffaa9de6160
    }

    /// <summary>Originally: ÏÎÏÏÎÍÏÌÏÏÎÎÍÍÏÌÌÍÎÏÎÌÏ</summary>
    public class LifecycleComponent_095B : MonoBehaviour
    {
        public object _itTypeSize; // 0x336A50E0, was: ÍÍÎÏÍÎÍÍÌÌÏÏÌÏÎÍÍÌÎÍÏÌÏ
        public object _networkCallableAttribute; // 0x336A50E0, was: ÏÌÎÍÌÏÏÌÎÍÌÌÍÏÏÍÌÍÌÎÎÎÍ
        public object _vector; // 0x336A50E0, was: <ÍÎÏÌÏÌÍÌÌÎÏÎÍÍÌÌÎÏÌÍÌÍÏ>k__Ba
        public object _kBackingField; // 0x336A50E0, was: <ÏÎÌÎÍÍÍÏÌÍÏÏÌÍÍÏÏÌÎÎÎÌÎ>k__Ba
        public object f_520; // 0x336A50E0, was: ÎÏÌÎÎÎÏÏÍÏÎÌÌÎÌÏÎÎÏÌÌÎÌ
        public object f_F73; // 0x336A50E0, was: ÏÌÏÏÏÏÍÎÌÍÎÏÎÍÌÌÏÌÌÏÎÍÌ
        public object f_044; // 0x170006E0, was: ÎÌÎÎÍÌÍÎÌÏÍÌÎÍÏÍÍÍÏÎÏÌÎ
        public object f_2BB; // 0x170006E1, was: ÎÍÎÌÍÏÏÍÍÎÏÌÌÌÍÍÏÍÍÎÍÏÏ
        public object f_97F; // 0x170006E2, was: ÏÌÌÏÍÎÎÍÍÍÌÎÎÍÎÍÍÎÎÎÎÏÍ
        public object f_C67; // 0x170006E3, was: ÍÎÍÏÏÍÏÍÍÍÍÌÏÍÍÎÎÌÍÍÌÌÍ
        public object f_EDB; // 0x170006E4, was: ÍÏÍÏÎÍÎÎÍÌÎÏÌÏÎÏÌÍÌÍÌÏÍ
        public object f_519; // 0x170006E5, was: ÍÌÎÎÌÍÎÍÍÏÍÎÏÍÎÍÌÍÎÍÌÍÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffaa9ddefc0
        public void RaiseCancellation(){} // RVA: 0x7ffaa89600c0
        public void IsInvoking(){} // RVA: 0x7ffaa9ddf4e0
        public void VRCSetAvatarMainIK(){} // RVA: 0x7ffaa89edc10
        public void Awake(){} // RVA: 0x7ffaa9ddf570
        public void StartCoroutine(){} // RVA: 0x7ffaa9ddf9d0
        public void LateUpdate(){} // RVA: 0x7ffaa9ddfcc0
        public void OnDisable(){} // RVA: 0x7ffaa9ddfde0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void StopCoroutine(){} // RVA: 0x7ffaa9ddff20
        public void StopAllCoroutines(){} // RVA: 0x7ffaa8bfcc80
        public void get_useGUILayout(){} // RVA: 0x7ffaa8bf45b0
        public void set_useGUILayout(){} // RVA: 0x7ffaa9de01d0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffaa9de0370
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffaa9de03d0
        public void InvokeDelayed(){} // RVA: 0x7ffaa9de0680
        public void CancelInvoke(){} // RVA: 0x7ffaa9de0950
        public void set_element(){} // RVA: 0x7ffaa8bf45c0
        public void StartCoroutineManaged(){} // RVA: 0x7ffaa9de19d0
        public void RegisterOnDisconnected(){} // RVA: 0x7ffaa8933e90
        public void get_DisableInteractive(){} // RVA: 0x7ffaa89edc00
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7ffaa9de1cc0
        public void .cctor(){} // RVA: 0x7ffaa9de37d0
        // ── Binary Analysis Named ──
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void GetShapes(){} // RVA: 0x7ffaa8bf45b0
        public void DoLocalizeVariant(){} // RVA: 0x7ffaa9ddf720
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
        public void SetStoreCallback(){} // RVA: 0x7ffaa8960890
        public void SetExecutionContextHelper(){} // RVA: 0x7ffaa89600d0
        public void DoGetEnumerator(){} // RVA: 0x7ffaa9de0e70
        public void GetScriptClassName(){} // RVA: 0x7ffaa9de1f90
        public void SetComponentEnabled(){} // RVA: 0x7ffaa89edc10
    }

    /// <summary>Originally: ÎÍÌÌÎÍÎÎÏÌÏÌÌÏÎÏÍÌÏÎÍÍÎ</summary>
    public class LifecycleComponent_0B91 : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnAnimatorMove(){} // RVA: 0x7ffaa8932310
        public void RaiseCancellation(){} // RVA: 0x7ffaa8932310
        public void IsInvoking(){} // RVA: 0x7ffaa8932310
        public void CancelInvoke(){} // RVA: 0x7ffaa8932310
        public void Invoke(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa8932310
    }

    /// <summary>Originally: ÌÌÏÎÌÍÌÍÏÌÍÎÍÍÏÍÌÏÏÌÏÌÍ</summary>
    public class LifecycleComponent_0E2C : MonoBehaviour
    {
        public object propNameLabel; // 0x3346EDE0

        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffaa8d0f4c0
        public void RaiseCancellation(){} // RVA: 0x7ffaa8d0fe60
        public void IsInvoking(){} // RVA: 0x7ffaa8d0ffc0
        public void CancelInvoke(){} // RVA: 0x7ffaa8d10120
        public void Invoke(){} // RVA: 0x7ffaa8d10460
        public void InvokeRepeating(){} // RVA: 0x7ffaa8d105c0
        public void Awake(){} // RVA: 0x7ffaa8d108f0
        public void Start(){} // RVA: 0x7ffaa8d10c20
        public void StartCoroutine(){} // RVA: 0x7ffaa8d10de0
        public void OnDisable(){} // RVA: 0x7ffaa8d10f40
        public void OnDestroy(){} // RVA: 0x7ffaa8d11280
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa8d11440
        public void StopCoroutine(){} // RVA: 0x7ffaa8d11dd0
    }

    /// <summary>Originally: ÍÎÏÏÍÍÍÌÌÍÍÏÎÏÏÎÏÌÎÎÎÌÏ</summary>
    public class LifecycleComponent_1233 : MonoBehaviour
    {
        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffab133f950
        public void RaiseCancellation(){} // RVA: 0x7ffab133fa00
        public void IsInvoking(){} // RVA: 0x7ffab133fc40
        public void CancelInvoke(){} // RVA: 0x7ffab133fcf0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void set_Error(){} // RVA: 0x7ffaa900aa90
        public void StartCoroutine(){} // RVA: 0x7ffab133ff30
        public void Awake(){} // RVA: 0x7ffab133ffe0
        public void OnDestroy(){} // RVA: 0x7ffab1340130
        public void StopCoroutine(){} // RVA: 0x7ffaa8aeced0
        // ── Binary Analysis Named ──
        public void SetIntProperty(){} // RVA: 0x7ffaa900aa90
        public void GetSkeletonType(){} // RVA: 0x7ffaa8aeced0
        public void GetIntProperty(){} // RVA: 0x7ffaa8aeced0
        // ── Obfuscated Methods ──
        public void m_303(){} // RVA: 0x7ffab133ff30
    }

    /// <summary>Originally: ÍÎÌÍÍÎÌÎÌÍÏÍÍÍÍÏÎÍÏÍÏÌÌ</summary>
    public class LifecycleComponent_14F3 : MonoBehaviour
    {
        public object _rical; // 0x336D6880, was: ÌÍÍÍÌÍÍÏÌÎÎÍÌÌÎÎÏÌÎÌÍÏÏ
        public object _flag; // 0x336D6880, was: ÏÎÏÏÍÏÏÍÌÍÌÏÌÎÏÌÏÍÌÏÎÍÎ

        // ── Original Methods ──
        public void RaiseCancellation(){} // RVA: 0x7ffaa9cf0b90
        public void ComputegameObject(){} // RVA: 0x7ffaa9cf0be0
        public void CancelInvoke(){} // RVA: 0x7ffaa9cf0c90
        public void Invoke(){} // RVA: 0x7ffaa9cf0ca0
        public void InvokeRepeating(){} // RVA: 0x7ffaa8932320
        public void UpdateRenderComponent(){} // RVA: 0x7ffaa9cf0cf0
        public void IsInvoking(){} // RVA: 0x7ffaa9cf0e30
        public void .ctor(){} // RVA: 0x7ffaa9098990
        public void OnEnable(){} // RVA: 0x7ffaa9cf0c90
        public void OnDisable(){} // RVA: 0x7ffaa8a17850
        public void StopCoroutine(){} // RVA: 0x7ffaa9cf0f70
        // ── Binary Analysis Named ──
        public void GetParent_E03(){} // RVA: 0x7ffaa9cf0890
        public void DoDrawLine_Injected_F64(){} // RVA: 0x7ffaa9cf0b90
    }

    /// <summary>Originally: ÏÍÍÌÏÎÍÍÍÌÍÏÌÏÍÌÏÌÌÎÎÍÌ</summary>
    public class LifecycleComponent_160D : MonoBehaviour
    {
        public object _ypointLabelesourceProvider; // 0x3370E810, was: ÍÎÎÏÌÍÎÍÎÍÌÏÏÌÏÍÏÎÏÌÏÏÎ
        public object f_03F; // 0x3370E810, was: ÌÌÌÎÍÌÎÍÍÍÏÎÏÌÏÏÏÌÎÌÍÎÎ

        // ── Original Methods ──
        public void IsInvoking(){} // RVA: 0x7ffaa8b0bae0
        public void OnEnable(){} // RVA: 0x7ffaa8b0be00
        public void OnDisable(){} // RVA: 0x7ffaa8b0c270
        public void CancelInvoke(){} // RVA: 0x7ffaa8b0cb30
        public void .cctor(){} // RVA: 0x7ffaa8b0cf80
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void DoForceUpdateR(){} // RVA: 0x7ffaa8b0b360
        public void DoRandomRangeInt(){} // RVA: 0x7ffaa8b0b680
        public void GetGameObject_02C(){} // RVA: 0x7ffaa8b0c6e0
        public void DoForceUpdateRectTransforms(){} // RVA: 0x7ffaa8b0d000
    }

    /// <summary>Originally: ÏÏÌÌÍÎÎÏÏÌÌÍÎÍÌÍÌÎÍÍÎÎÏ</summary>
    public class LifecycleComponent_1F24 : MonoBehaviour
    {
        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffab0f85bb0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab0f85db0
        public void Start(){} // RVA: 0x7ffab0f85fb0
        public void Invoke(){} // RVA: 0x7ffab0f85fc0
        public void InvokeRepeating(){} // RVA: 0x7ffab0f85fd0
        public void CancelInvoke(){} // RVA: 0x7ffab0f861d0
        public void IsInvoking(){} // RVA: 0x7ffab0f85fc0
    }

    /// <summary>Originally: ÎÎÍÍÍÏÎÍÌÌÎÏÌÎÍÎÏÌÏÍÍÏÍ</summary>
    public class LifecycleComponent_212A : MonoBehaviour
    {
        public object _212A; // 0x33CC6F00, was: ÍÌÍÍÍÏÎÎÏÏÍÌÍÎÏÎÍÌÎÎÏÏÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab113fbb0
        public void RaiseCancellation(){} // RVA: 0x7ffab113fc90
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Start(){} // RVA: 0x7ffab113fd30
        public void Invoke(){} // RVA: 0x7ffab1140040
        public void InvokeRepeating(){} // RVA: 0x7ffab11400e0
        public void CancelInvoke(){} // RVA: 0x7ffab1140250
        public void OnDestroy(){} // RVA: 0x7ffab1140330
        public void StartCoroutine(){} // RVA: 0x7ffab11404a0
        public void OnApplicationPause(){} // RVA: 0x7ffab1140580
    }

    /// <summary>Originally: ÎÍÎÌÎÏÍÏÌÌÏÎÍÎÏÏÍÌÎÌÍÏÎ</summary>
    public class LifecycleComponent_2313 : MonoBehaviour
    {
        public object _productPrefab; // 0x33686140
        public object f_A68; // 0x33686140, was: ÌÍÌÌÎÏÎÍÍÏÌÎÏÌÎÎÎÌÌÌÌÏÍ
        public object _uRAwoDigitYearMax; // 0x33686140, was: ÍÌÏÏÏÏÏÎÏÌÍÏÎÏÍÍÍÌÎÎÏÌÍ

        // ── Original Methods ──
        public void RaiseCancellation(){} // RVA: 0x7ffab10e83b0
        public void Invoke(){} // RVA: 0x7ffab10e8bb0
        public void InvokeRepeating(){} // RVA: 0x7ffaa8bfcc80
        public void CancelInvoke(){} // RVA: 0x7ffab0dca5f0
        public void .ctor(){} // RVA: 0x7ffab10e8d30
        public void StopCoroutine(){} // RVA: 0x7ffaa89ad730
        public void InitializeProductPrefab(){} // RVA: 0x7ffab10e97c0
        public void InitializeStaticConfiguration(){} // RVA: 0x7ffab10e97d0
        public void StopAllCoroutines(){} // RVA: 0x7ffaa89d30e0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffab10e97c0
        public void Start(){} // RVA: 0x7ffab10e9f10
        // ── Binary Analysis Named ──
        public void DoInitBuffer_EBF(){} // RVA: 0x7ffab10e8100
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
        public void DoSort(){} // RVA: 0x7ffab10e88e0
        public void SetEnabled_CF9(){} // RVA: 0x7ffab10e8e50
        public void GetRoot(){} // RVA: 0x7ffaa89d30e0
        public void GetPublicKey(){} // RVA: 0x7ffaa89ad730
        public void SetEnabled_348(){} // RVA: 0x7ffab10e9290
        public void DoSetGlobalTexture_Impl_422(){} // RVA: 0x7ffab10e9ab0
        public void DoReleaseTemporaryRT_2DB(){} // RVA: 0x7ffab10e9c30
        public void GetInternalMethodName(){} // RVA: 0x7ffaa89af740
    }

    /// <summary>Originally: ÏÎÏÎÌÏÍÎÎÏÏÎÎÍÏÎÍÍÌÎÍÌÏ</summary>
    public class LifecycleComponent_257B : MonoBehaviour
    {
        public object _tagsListBinding; // 0x336EC8F0
        public object _viewMorePrefab; // 0x336EC8F0
        public object _tagPrefab; // 0x336EC8F0
        public object ContentWarningsHeader; // 0x336EC8F0
        public object _newInstanceButton; // 0x336EC8F0
        public object _addToPlaylistButton; // 0x336EC8F0
        public object _resetUserDataButton; // 0x336EC8F0
        public object _youAreHere; // 0x336EC8F0
        public object _lastUpdatedText; // 0x336EC8F0
        public object f_F26; // 0x336EC8F0, was: ÍÎÌÌÎÎÌÏÍÏÎÎÎÍÏÌÌÎÎÎÎÌÌ
        public object _text; // 0x336EC8F0, was: ÌÎÎÍÍÎÏÎÎÍÌÌÍÌÌÏÏÏÍÍÍÎÍ
        public object _mePatternseseCalendarDTFI; // 0x336EC8F0, was: ÏÍÍÎÎÌÌÍÌÎÌÎÌÏÏÏÌÎÎÎÏÏÌ
        public object _itTypeSize; // 0x336EC8F0, was: ÏÌÌÍÏÏÏÎÌÌÏÏÏÎÍÎÎÎÌÍÌÍÏ
        public object f_745; // 0x336EC8F0, was: ÌÍÌÍÏÌÌÍÌÎÏÍÍÍÌÎÌÍÌÍÍÍÍ
        public object _sageKindinternal; // 0x336EC8F0, was: ÌÎÌÎÎÌÍÎÏÍÎÍÏÍÏÎÎÏÍÌÏÏÌ
        public object f_8B8; // 0xB3F6FFF0, was: ÏÌÏÎÍÎÍÍÎÏÌÏÏÏÏÍÎÍÎÎÏÎÏ

        // ── Original Methods ──
        public void RaiseCancellation(){} // RVA: 0x7ffab0db2920
        public void IsInvoking(){} // RVA: 0x7ffab0db2a30
        public void CancelInvoke(){} // RVA: 0x7ffab0db2b20
        public void Invoke(){} // RVA: 0x7ffab0db2bf0
        public void UpdateActive(){} // RVA: 0x7ffab0db2f20
        public void StartCoroutine(){} // RVA: 0x7ffab0db3ef0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab0db40e0
        public void StopCoroutine(){} // RVA: 0x7ffab0db42f0
        public void InitializeComponentWithLifecycleLogic(){} // RVA: 0x7ffab0db4400
        public void InitializeOrUpdateList(){} // RVA: 0x7ffab0db4d20
        public void StopAllCoroutines(){} // RVA: 0x7ffab0db4d40
        public void get_useGUILayout(){} // RVA: 0x7ffab0db4fc0
        public void set_useGUILayout(){} // RVA: 0x7ffab0db51c0
        public void print(){} // RVA: 0x7ffab0db5510
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffab0db5710
        public void StartCoroutineManaged(){} // RVA: 0x7ffab0db5ec0
        public void StartCoroutineManaged2(){} // RVA: 0x7ffab0db60c0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7ffab0db61b0
        public void OnCancellationTokenCreated(){} // RVA: 0x7ffab0db5510
        public void Start(){} // RVA: 0x7ffab0db7040
        public void .ctor(){} // RVA: 0x7ffab0db78a0
        public void OnApplicationPause(){} // RVA: 0x7ffab0db83c0
        public void get_promotion(){} // RVA: 0x7ffaa8de7450
        public void OnCollisionEnter(){} // RVA: 0x7ffab0db8830
        // ── Binary Analysis Named ──
        public void SetActive_D62(){} // RVA: 0x7ffab0db2770
        public void DoConcat(){} // RVA: 0x7ffab0db3ac0
        public void GetSpecificUIElementOrData(){} // RVA: 0x7ffab0db3d10
        public void SetEnabled_94C(){} // RVA: 0x7ffab0db3e20
        public void GetGameObject_CD6(){} // RVA: 0x7ffab0db55d0
        public void SetEnabled_3F1(){} // RVA: 0x7ffab0db5860
        public void SetEnabled_E49(){} // RVA: 0x7ffab0db5a30
        public void GetMaterial(){} // RVA: 0x7ffaa89add50
        public void GetTargets(){} // RVA: 0x7ffaa89d0370
        public void GetGameObject_3FD(){} // RVA: 0x7ffab0db6120
        public void GetActiveSelf_8BA(){} // RVA: 0x7ffab0db6640
        public void GetGameObject_7D6(){} // RVA: 0x7ffab0db6d70
        public void GetGameObject_E1F(){} // RVA: 0x7ffab0db6e90
        public void GetGameObject_CD2(){} // RVA: 0x7ffab0db7770
        public void GetGameObject_56F(){} // RVA: 0x7ffab0db7db0
        public void GetActiveSelf_9ED(){} // RVA: 0x7ffab0db8030
        public void GetGameObject_3C2(){} // RVA: 0x7ffab0db8200
        public void GetGameObject_E31(){} // RVA: 0x7ffab0db85b0
        public void GetActiveSelf_CC4(){} // RVA: 0x7ffab0db8700
        public void GetGameObject_AFC(){} // RVA: 0x7ffab0db94c0
        public void GetTransform_A59(){} // RVA: 0x7ffab0db9680
        // ── Obfuscated Methods ──
        public void m_374(){} // RVA: 0x7ffab0db3fa0
    }

    /// <summary>Originally: ÍÌÎÏÏÏÌÌÏÎÍÏÌÍÏÌÎÎÏÎÎÎÍ</summary>
    public class LifecycleComponent_2C28 : MonoBehaviour
    {
        public object _tionX; // 0x33658FC0, was: ÍÍÏÌÍÍÎÍÏÎÌÏÏÌÌÎÍÌÍÏÌÎÏ
        public object _searchAllButton; // 0x33658FC0
        public object _searchAvatarsButton; // 0x33658FC0
        public object _searchUsersCountText; // 0x33658FC0
        public object _searchEventsButton; // 0x33658FC0
        public object _saveSearchButtonText; // 0x33658FC0
        public object _modifySearchButtonStyleElement; // 0x33658FC0
        public object _noResultsPanel; // 0x33658FC0
        public object _searchTitleMaxcharacters; // 0x33658FC0
        public object _groupCellPrefab; // 0x33658FC0
        public object _topEventCellPrefab; // 0x33658FC0
        public object _topGroupCellPrefab; // 0x33658FC0
        public object _allTabAvatarsResultsList; // 0x33658FC0
        public object _allTabEventsResultsList; // 0x33658FC0
        public object _allTabUsersResultsButton; // 0x33658FC0
        public object _searchResultsLayout; // 0x33658FC0
        public object _avatarsAllPage; // 0x33658FC0
        public object _eventsAllPage; // 0x33658FC0
        public object _nGroupValue; // 0x33658FC0, was: ÎÎÌÏÎÎÎÎÌÏÌÌÌÏÍÏÎÌÎÎÌÍÎ
        public object _itTypeSize; // 0x33658FC0, was: ÎÍÌÌÍÍÏÌÍÌÌÏÏÍÏÏÍÏÏÏÍÍÏ
        public object _flag; // 0x33658FC0, was: ÍÏÎÏÎÍÎÏÍÏÍÏÍÏÍÌÎÍÍÏÎÌÎ
        public object _mePatternseseCalendarDTFI; // 0x33658FC0, was: ÍÏÎÍÌÍÏÍÎÍÍÏÍÏÎÏÎÎÎÏÍÌÍ
        public object .ctor; // 0xB3F6FFF0
        public object f_780; // 0x349B1450, was: ÎÍÍÌÍÍÍÎÌÏÏÌÌÎÌÍÎÎÎÍÏÎÍ
        public object _renamePlaylistButton; // 0x33C272E0
        public object _setPrivacyPrivateButton; // 0x33C272E0
        public object _setPrivacyFriendsButtonEnabledIcon; // 0x33C272E0
        public object f_F9B; // 0x33C272E0, was: ÌÎÍÎÏÎÌÍÍÎÎÌÏÎÍÎÍÍÌÍÏÌÌ
        public object f_6A4; // 0x33C272E0, was: ÎÍÏÍÎÏÍÍÌÍÍÏÍÎÌÌÌÌÏÏÏÏÎ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0e42dd0
        public void RaiseCancellation(){} // RVA: 0x7ffab0e42e20
        public void IsInvoking(){} // RVA: 0x7ffab0e43060
        public void CancelInvoke(){} // RVA: 0x7ffab0e43290
        public void Invoke(){} // RVA: 0x7ffab0e43310
        public void OnDestroy(){} // RVA: 0x7ffab0e43420
        public void OnApplicationPause(){} // RVA: 0x7ffab0e437b0
        public void OnApplicationQuit(){} // RVA: 0x7ffab0e43800
        public void UpdateActive(){} // RVA: 0x7ffab0e438c0
        public void StartCoroutine(){} // RVA: 0x7ffab0e439f0
        public void OnCollisionEnter(){} // RVA: 0x7ffab0e43a70
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab0e43ba0
        public void StopCoroutine(){} // RVA: 0x7ffab0e43cb0
        public void OnTriggerEnter(){} // RVA: 0x7ffab0e43ce0
        public void OnTriggerStay(){} // RVA: 0x7ffab0e43d90
        public void StopAllCoroutines(){} // RVA: 0x7ffab0e43e10
        public void get_useGUILayout(){} // RVA: 0x7ffab0e43e90
        public void set_useGUILayout(){} // RVA: 0x7ffab0e43ef0
        public void print(){} // RVA: 0x7ffab0e43f70
        public void .ctor(){} // RVA: 0x7ffab0e441b0
        public void Initialize(){} // RVA: 0x7ffab0e443d0
        public void InvokeDelayed(){} // RVA: 0x7ffab0e44510
        public void ComputegameObject(){} // RVA: 0x7ffab0e44d20
        public void StartCoroutineManaged(){} // RVA: 0x7ffab0e44dd0
        public void StartCoroutineManaged2(){} // RVA: 0x7ffab0e45130
        public void StopCoroutineManaged(){} // RVA: 0x7ffab0e45370
        public void Start(){} // RVA: 0x7ffab0e453d0
        public void LateUpdate(){} // RVA: 0x7ffab0e469e0
        public void OnDisable(){} // RVA: 0x7ffab0e46b10
        public void Awake(){} // RVA: 0x7ffab0e476f0
        public void OnEnable(){} // RVA: 0x7ffab0e48440
        public void OnBecameVisible(){} // RVA: 0x7ffab0e485a0
        public void ConfigureconstraintCount(){} // RVA: 0x7ffab0e48620
        public void Update(){} // RVA: 0x7ffab0e48fd0
        public void OnCollisionStay(){} // RVA: 0x7ffab0e49060
        public void OnCollisionExit(){} // RVA: 0x7ffab0e49280
        public void ProcessSearchPanelStates(){} // RVA: 0x7ffab0e495b0
        public void OnTriggerExit(){} // RVA: 0x7ffab0e497e0
        public void UpdateSearchControls(){} // RVA: 0x7ffab0e49860
        public void OnBecameInvisible(){} // RVA: 0x7ffab0e4a450
        public void UpdateSearchUIState(){} // RVA: 0x7ffab0e4a4d0
        // ── Binary Analysis Named ──
        public void GetSearchRelatedCalculatedValue(){} // RVA: 0x7ffab0e44c90
        public void GetScriptClassName(){} // RVA: 0x7ffab0e46180
        public void DoFormatInt32(){} // RVA: 0x7ffab0e46290
        public void CheckAndInitializeDependencies(){} // RVA: 0x7ffab0e47040
        public void SetComponentDisplayMode(){} // RVA: 0x7ffab0e49530
        // ── Obfuscated Methods ──
        public void m_081(){} // RVA: 0x7ffab0e447c0
    }

    /// <summary>Originally: ÌÌÌÎÍÏÍÍÌÌÌÏÍÏÏÏÎÌÌÍÌÎÌ</summary>
    public class LifecycleComponent_3117 : MonoBehaviour
    {
        public object styleElement; // 0x336BC9A0
        public object button; // 0x336BC9A0

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab125f8b0
        public void Updateenabled(){} // RVA: 0x7ffab125f900
        public void IsInvoking(){} // RVA: 0x7ffab125f9e0
        public void CancelInvoke(){} // RVA: 0x7ffab125f9e0
        public void Invoke(){} // RVA: 0x7ffab125f8b0
        public void InvokeRepeating(){} // RVA: 0x7ffab125f9e0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab125fa20
        public void Start(){} // RVA: 0x7ffab125fab0
        public void StartCoroutine(){} // RVA: 0x7ffab125fb40
        public void Update(){} // RVA: 0x7ffab125f8b0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab125f8b0
    }

    /// <summary>Originally: ÏÌÌÍÎÎÍÍÍÌÎÎÌÍÍÏÍÎÎÏÌÌÌ</summary>
    public class LifecycleComponent_3474 : MonoBehaviour
    {
        public object _itemSeller; // 0x33685B40
        public object _balance; // 0x33685B40
        public object f_D8B; // 0x33685B40, was: ÍÍÏÌÍÍÎÍÏÌÎÍÎÏÌÌÌÌÏÏÍÏÌ
        public object f_DD7; // 0x170001BD, was: ÍÏÍÏÎÍÍÍÎÌÌÌÍÌÍÍÎÏÏÍÍÏÍ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab10a6790
        public void OnEnable(){} // RVA: 0x7ffab10a6790
        public void ComputeCurrentCulture(){} // RVA: 0x7ffab10a67d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab10a7550
        public void InvokeRepeating(){} // RVA: 0x7ffab10a7610
        public void CancelInvoke(){} // RVA: 0x7ffab10a7660
        public void StartCoroutine(){} // RVA: 0x7ffab10a7720
        public void OnApplicationQuit(){} // RVA: 0x7ffab10a78d0
        public void Awake(){} // RVA: 0x7ffab10a7910
        public void Start(){} // RVA: 0x7ffab10a7960
        public void StopCoroutine(){} // RVA: 0x7ffab10a7b10
        // ── Binary Analysis Named ──
        public void GetTargets(){} // RVA: 0x7ffaa89d0370
    }

    /// <summary>Originally: ÏÏÌÎÎÍÍÌÌÏÍÏÌÌÌÌÍÍÏÏÎÌÏ</summary>
    public class LifecycleComponent_36AA : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void InvokeRepeating(){} // RVA: 0x7ffaa9163880
        public void CancelInvoke(){} // RVA: 0x7ffaa9163a00
        public void OnPreRender(){} // RVA: 0x7ffaa9163b80
        // ── Binary Analysis Named ──
        public void DoPropertyToID_D06(){} // RVA: 0x7ffaa9163280
        public void DoPropertyToID_322(){} // RVA: 0x7ffaa9163400
        public void DoPropertyToID_BDE(){} // RVA: 0x7ffaa9163580
        public void DoPropertyToID_D61(){} // RVA: 0x7ffaa9163700
    }

    /// <summary>Originally: ÍÏÌÌÌÍÍÎÎÌÌÍÎÏÎÍÍÎÏÌÎÌÌ</summary>
    public class LifecycleComponent_3C4D : MonoBehaviour
    {
        public object _ePathName; // 0x336CFCE0, was: ÌÌÍÎÏÍÎÎÍÌÍÎÌÍÏÍÎÎÌÏÌÌÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab113eb40
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void RegisterOnDisconnected(){} // RVA: 0x7ffaa8933e90
        public void Start(){} // RVA: 0x7ffab113eca0
        public void Invoke(){} // RVA: 0x7ffab113ee00
        public void InvokeRepeating(){} // RVA: 0x7ffab113ef70
        public void OnDestroy(){} // RVA: 0x7ffab113f050
        public void IsInvoking(){} // RVA: 0x7ffab113f1c0
        public void Awake(){} // RVA: 0x7ffab113f380
        public void StartCoroutine(){} // RVA: 0x7ffab113f540
        public void OnApplicationQuit(){} // RVA: 0x7ffab113f700
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab113f7e0
        public void StopCoroutine(){} // RVA: 0x7ffab113f9a0
        public void OnCollisionEnter(){} // RVA: 0x7ffab113f9f0
    }

    /// <summary>Originally: ÏÍÍÍÏÏÍÍÌÌÎÍÌÌÌÏÏÎÌÍÌÎÍ</summary>
    public class LifecycleComponent_44EE : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0e31cf0
        public void RaiseCancellation(){} // RVA: 0x7ffab0e31d90
        public void IsInvoking(){} // RVA: 0x7ffab0e31e30
        public void CancelInvoke(){} // RVA: 0x7ffab0e31ed0
        public void Invoke(){} // RVA: 0x7ffab0e31f70
        public void Start(){} // RVA: 0x7ffab0e32010
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab0e320b0
    }

    /// <summary>Originally: ÌÌÌÎÍÎÌÏÎÎÎÎÍÍÌÏÌÍÎÎÎÍÌ</summary>
    public class LifecycleComponent_4809 : MonoBehaviour
    {
        public object CategoryFilter; // 0x336B7598
        public object CategoryScrollRect; // 0x336B7598
        public object PageDownButton; // 0x336B7598
        public object _string; // 0x336B7598, was: ÎÌÎÏÌÏÎÌÍÏÍÍÎÌÏÍÏÍÌÎÌÌÎ
        public object _text; // 0x336B7598, was: <ÏÎÎÌÏÍÌÏÎÏÎÍÍÍÏÎÎÌÏÏÍÍÏ>k__Ba
        public object f_30C; // 0x17000110, was: ÌÏÌÏÌÏÍÏÎÏÌÌÎÎÎÍÍÎÎÎÎÍÏ

        // ── Original Methods ──
        public void set_roleIdsToSubmit(){} // RVA: 0x7ffaa8f7b010
        public void Start(){} // RVA: 0x7ffaab689be0
        public void CancelInvoke(){} // RVA: 0x7ffaa8660cc0
        public void OnEnable(){} // RVA: 0x7ffaad0ace90
        public void OnDisable(){} // RVA: 0x7ffaa8660cc0
        public void IsInvoking(){} // RVA: 0x7ffaa86491d0
        public void StartCoroutine(){} // RVA: 0x7ffaad0ad060
        public void ComputeisActiveAndE(){} // RVA: 0x7ffaad0ad290
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa8660cc0
        public void RemoveAt(){} // RVA: 0x7ffaad0ad390
        public void StopCoroutine(){} // RVA: 0x7ffaa8649ca0
        public void .ctor(){} // RVA: 0x7ffaad0ad850
        public void Initialize(){} // RVA: 0x7ffaad0adaf0
        public void get_useGUILayout(){} // RVA: 0x7ffaad0adb10
        // ── Binary Analysis Named ──
        public void GetCurrentFocusedGameObject(){} // RVA: 0x7ffaa8971010
        public void DoGetFormattedFallbackText(){} // RVA: 0x7ffaad0aced0
        public void GetMethod(){} // RVA: 0x7ffaa8960130
    }

    /// <summary>Originally: ÏÍÌÌÌÌÏÎÌÎÌÌÌÏÏÌÏÎÏÎÍÍÌ</summary>
    public class LifecycleComponent_4BB7 : MonoBehaviour
    {
        public object _matrix; // 0x3365BE00, was: ÎÎÏÏÍÍÏÌÎÌÏÎÌÌÌÍÏÌÌÍÌÏÏ
        public object _matrix2; // 0x3365BE00, was: ÏÎÎÏÍÍÎÏÏÍÌÏÍÎÍÏÍÏÏÌÎÎÏ
        public object _matrix3; // 0x3365BE00, was: ÎÎÌÍÍÎÍÏÍÍÏÏÎÌÎÏÏÎÍÌÎÎÍ
        public object Text; // 0x3357DD60

        // ── Original Methods ──
        public void ComputegameObject(){} // RVA: 0x7ffaa9941c00
        public void RaiseCancellation(){} // RVA: 0x7ffaa9941dd0
        public void Awake(){} // RVA: 0x7ffaa99421b0
        public void InvokeRepeating(){} // RVA: 0x7ffaa9942590
        public void .ctor(){} // RVA: 0x7ffaa9942970
        // ── Binary Analysis Named ──
        public void GetGameObject_EFC(){} // RVA: 0x7ffaa9941fa0
        public void GetGameObject_C7C(){} // RVA: 0x7ffaa9942380
        public void GetGameObject_D52(){} // RVA: 0x7ffaa99427a0
        public void GetGameObject_404(){} // RVA: 0x7ffaa9942a70
        public void GetGameObject_9A7(){} // RVA: 0x7ffaa9942e30
    }

    /// <summary>Originally: ÍÍÍÏÏÏÏÏÎÏÍÏÏÎÍÍÎÍÏÌÍÌÌ</summary>
    public class LifecycleComponent_4BE7 : MonoBehaviour
    {
        public object loadingDisplay; // 0x336ED5C0
        public object _vector; // 0x336ED5C0, was: ÏÌÏÏÌÌÏÍÍÎÍÎÌÏÍÌÎÏÌÏÌÌÌ
        public object f_EC3; // 0x335238E0, was: ÌÌÍÎÏÍÎÎÍÌÍÎÌÍÏÍÎÎÌÏÌÌÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab1126fd0
        public void Start(){} // RVA: 0x7ffab1127060
        public void Updateenabled(){} // RVA: 0x7ffab11270f0
        public void Invoke(){} // RVA: 0x7ffab11274d0
        public void CancelInvoke(){} // RVA: 0x7ffab11279d0
        public void IsInvoking(){} // RVA: 0x7ffab1127d20
        public void StartCoroutine(){} // RVA: 0x7ffab1127fd0
        public void OnBecameVisible(){} // RVA: 0x7ffab1128060
        public void OnBecameInvisible(){} // RVA: 0x7ffab1128310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab11284a0
        // ── Binary Analysis Named ──
        public void GetGameObject_A99(){} // RVA: 0x7ffab1127280
        public void GetGameObject_C37(){} // RVA: 0x7ffab1127720
    }

    /// <summary>Originally: ÏÌÌÎÎÎÏÍÎÏÌÍÍÌÍÏÌÌÏÍÎÏÌ</summary>
    public class LifecycleComponent_4DE6 : MonoBehaviour
    {
        public object disableButton; // 0x33784330
        public object header; // 0x337BC820

        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffab1335890
        public void OnDestroy(){} // RVA: 0x7ffab1335bd0
        public void IsInvoking(){} // RVA: 0x7ffab1335e00
        public void CancelInvoke(){} // RVA: 0x7ffab1336140
        public void Invoke(){} // RVA: 0x7ffab1336480
        public void InvokeRepeating(){} // RVA: 0x7ffab13366b0
        public void OnCollisionEnter(){} // RVA: 0x7ffab1336860
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab1336990
        public void Awake(){} // RVA: 0x7ffab1336bc0
        public void StartCoroutine(){} // RVA: 0x7ffab1336dc0
    }

    /// <summary>Originally: ÏÏÏÍÌÍÏÍÍÏÏÏÎÏÍÌÏÌÏÏÍÍÎ</summary>
    public class LifecycleComponent_514E : MonoBehaviour
    {
        public object tooltip; // 0x3372D230
        public object enabledNotificationString; // 0x3372D230
        public object _flag; // 0x3372D230, was: ÍÎÎÍÍÎÎÏÍÌÎÍÌÌÎÎÏÌÌÎÎÎÌ
        public object f_210; // 0x3372D230, was: ÍÍÎÍÌÍÍÏÏÌÍÏÌÌÎÏÎÌÍÏÍÎÎ
        public object f_401; // 0x33AA76F0, was: ÎÌÌÍÍÏÌÎÌÍÌÍÏÏÌÌÍÍÎÏÏÏÌ

        // ── Original Methods ──
        public void IsInvoking(){} // RVA: 0x7ffab112ef80
        public void CancelInvoke(){} // RVA: 0x7ffab112f300
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab112f380
        public void ProcessStateDataUpdate(){} // RVA: 0x7ffab112f450
        public void StartCoroutine(){} // RVA: 0x7ffab112f760
        public void UpdateFlagAndRetrieveStatus(){} // RVA: 0x7ffab112fa70
        public void ComputeComplexState(){} // RVA: 0x7ffab112fb40
        public void get_allowOffhandGrab(){} // RVA: 0x7ffaa8a209d0
        public void StopCoroutine(){} // RVA: 0x7ffab112fec0
        public void Start(){} // RVA: 0x7ffab1130090
        public void Update(){} // RVA: 0x7ffab1130140
        public void StopAllCoroutines(){} // RVA: 0x7ffab1130450
        // ── Binary Analysis Named ──
        public void GetGameObject_214(){} // RVA: 0x7ffab112ebf0
        public void GetGameObject_5D5(){} // RVA: 0x7ffab112ec70
        public void SetAndProcessProperties(){} // RVA: 0x7ffab112f300
    }

    /// <summary>Originally: ÏÍÎÌÍÍÎÏÍÍÌÎÍÏÍÎÌÏÍÎÏÌÏ</summary>
    public class LifecycleComponent_519B : MonoBehaviour
    {
        public object _showMoreButtonPaddingActive; // 0x337556A0
        public object _layoutGroup; // 0x337556A0
        public object _toggleButton; // 0x337556A0

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab101eb90
        public void UpdateActive(){} // RVA: 0x7ffab101ee50
        public void Start(){} // RVA: 0x7ffab101efb0
        public void Invoke(){} // RVA: 0x7ffab101f0a0
        public void InvokeRepeating(){} // RVA: 0x7ffab101f230
        public void CancelInvoke(){} // RVA: 0x7ffab101f320
        public void IsInvoking(){} // RVA: 0x7ffab101f390
        public void StartCoroutine(){} // RVA: 0x7ffab101f390
        public void .ctor(){} // RVA: 0x7ffab101f3d0
        public void Initialize(){} // RVA: 0x7ffab101f430
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab101f590
        public void StopCoroutine(){} // RVA: 0x7ffab101f590
        public void OnCollisionEnter(){} // RVA: 0x7ffab101f5b0
        // ── Binary Analysis Named ──
        public void SetActive_12B(){} // RVA: 0x7ffab101ecc0
    }

    /// <summary>Originally: ÎÏÌÎÏÍÏÏÌÏÎÌÎÍÍÏÏÌÌÌÍÌÎ</summary>
    public class LifecycleComponent_552B : MonoBehaviour
    {
        public object _flag; // 0x33666200, was: ÌÍÎÏÎÍÌÏÏÎÍÎÏÍÍÌÌÍÌÏÎÍÎ

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffab0d44e50
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Computetransform(){} // RVA: 0x7ffab0d44f20
        public void ConfigureanchoredPosition(){} // RVA: 0x7ffab0d45290
        public void Computerect_Inj(){} // RVA: 0x7ffab0d455a0
        public void CancelInvoke(){} // RVA: 0x7ffab0d459d0
        public void IsInvoking(){} // RVA: 0x7ffab0d45b60
        public void OnDestroy(){} // RVA: 0x7ffab0d45c80
        public void StartCoroutine(){} // RVA: 0x7ffab0d45e10
        public void Accessrect_Injected(){} // RVA: 0x7ffab0d45f30
        // ── Binary Analysis Named ──
        public void GetGameObject_6AB(){} // RVA: 0x7ffab0d457b0
    }

    /// <summary>Originally: ÍÌÌÏÌÌÍÎÏÎÍÌÌÌÎÎÌÍÏÏÍÎÍ</summary>
    public class LifecycleComponent_57C9 : MonoBehaviour
    {
        public object _ePathName; // 0x3370D190, was: ÌÌÍÎÏÍÎÎÍÌÍÎÌÍÏÍÎÎÌÏÌÌÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0e40a40
        public void RaiseCancellation(){} // RVA: 0x7ffab0e40b00
        public void IsInvoking(){} // RVA: 0x7ffab0e40b90
        public void CancelInvoke(){} // RVA: 0x7ffab0e40c40
        public void Invoke(){} // RVA: 0x7ffab0e40cd0
        public void Awake(){} // RVA: 0x7ffab0e411a0
        public void Start(){} // RVA: 0x7ffab0e41660
        public void FixedUpdate(){} // RVA: 0x7ffab0e41770
        public void StartCoroutine(){} // RVA: 0x7ffab0e417d0
        public void Update(){} // RVA: 0x7ffab0e418d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void OnDestroy(){} // RVA: 0x7ffab0e419d0
        public void OnDisable(){} // RVA: 0x7ffab0e41d50
        public void StopCoroutine(){} // RVA: 0x7ffab0e41e40
        public void OnApplicationQuit(){} // RVA: 0x7ffab0e42300
        public void StopAllCoroutines(){} // RVA: 0x7ffab0e423b0
        public void set_useGUILayout(){} // RVA: 0x7ffab0e42550
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffab0e426f0
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffab0e427d0
        public void InvokeDelayed(){} // RVA: 0x7ffab0e428e0
        public void OnEnable(){} // RVA: 0x7ffab0e42970
        // ── Binary Analysis Named ──
        public void SetActive_539(){} // RVA: 0x7ffab0e424b0
        public void SetActive_E03(){} // RVA: 0x7ffab0e42650
    }

    /// <summary>Originally: ÎÍÎÍÎÍÏÍÏÍÌÌÌÍÏÏÎÎÍÍÎÎÌ</summary>
    public class LifecycleComponent_581F : MonoBehaviour
    {
        public object landscapeScale; // 0x33726C60
        public object _buffer; // 0x33726C60, was: ÌÏÏÎÌÏÍÏÎÎÏÍÏÍÏÌÌÌÌÌÏÍÌ

        // ── Original Methods ──
        public void ComputegameObject(){} // RVA: 0x7ffaa9c67f60
        public void RaiseCancellation(){} // RVA: 0x7ffaa9c68180
        public void Awake(){} // RVA: 0x7ffaa9c68360
        public void OnDestroy(){} // RVA: 0x7ffaa9c68580
        public void Invoke(){} // RVA: 0x7ffaa9c68620
        public void InvokeRepeating(){} // RVA: 0x7ffaa9c68800
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9c688a0
        public void Start(){} // RVA: 0x7ffaa9c68940
        public void UpdatelocalScale_I(){} // RVA: 0x7ffaa9c68c00
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9c694a0
        public void Configureparent(){} // RVA: 0x7ffaa9c69540
        // ── Binary Analysis Named ──
        public void DoGetChild(){} // RVA: 0x7ffaa9c689e0
    }

    /// <summary>Originally: ÎÌÍÎÍÎÏÍÍÎÍÎÏÍÎÎÏÍÎÏÌÏÏ</summary>
    public class LifecycleComponent_5AE8 : MonoBehaviour
    {
        public object _5AE8; // 0x3370FCE0, was: ÍÍÌÍÍÎÍÌÎÏÏÎÌÍÏÍÍÌÏÌÍÍÎ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab10f0ab0
        public void UpdatesystemCopyB(){} // RVA: 0x7ffab10f0b40
        public void AccesssystemCopyBuffer(){} // RVA: 0x7ffab10f0cf0
        public void CancelInvoke(){} // RVA: 0x7ffab10f0ea0
        public void Invoke(){} // RVA: 0x7ffab10f0f30
        public void Start(){} // RVA: 0x7ffab10f1180
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetTransform_8EE(){} // RVA: 0x7ffab10f10f0
        public void GetTransform_61A(){} // RVA: 0x7ffab10f1210
    }

    /// <summary>Originally: ÎÌÎÍÍÍÎÍÎÌÎÏÎÍÎÎÎÍÏÌÌÌÏ</summary>
    public class LifecycleComponent_5E9C : MonoBehaviour
    {
        public object canvasGroup; // 0x3368DBD0
        public object _5E9C; // 0x1700129B, was: ÏÎÏÌÎÌÎÏÌÏÍÏÌÎÌÌÎÌÎÎÎÌÎ

        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffaa9213230
        public void OnDestroy(){} // RVA: 0x7ffaa92134f0
        public void IsInvoking(){} // RVA: 0x7ffaa92135e0
        public void CancelInvoke(){} // RVA: 0x7ffaa9213720
        public void Invoke(){} // RVA: 0x7ffaa92137c0
        public void .ctor(){} // RVA: 0x7ffaa898c060
        public void Initialize(){} // RVA: 0x7ffaa9213860
        public void OnCollisionStay(){} // RVA: 0x7ffaa9213950
        public void StartCoroutine(){} // RVA: 0x7ffaa92139f0
        public void Awake(){} // RVA: 0x7ffaa9213a90
        public void Start(){} // RVA: 0x7ffaa9213b30
    }

    /// <summary>Originally: ÍÌÏÍÍÍÏÍÍÍÏÌÍÎÎÌÎÌÍÏÌÌÍ</summary>
    public class LifecycleComponent_6328 : MonoBehaviour
    {
        public object _6328; // 0x3376D4A0, was: ÏÌÎÎÌÏÍÍÎÍÍÎÏÏÍÍÌÍÌÏÍÍÍ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa913f160
        public void IsInvoking(){} // RVA: 0x7ffaa913f170
        public void CancelInvoke(){} // RVA: 0x7ffaa913f180
        public void get_useGUILayout(){} // RVA: 0x7ffaa913fb80
        public void Start(){} // RVA: 0x7ffaa913f3d0
        public void Update(){} // RVA: 0x7ffaa913f6c0
        public void StartCoroutine(){} // RVA: 0x7ffaa913f7b0
        public void OnDisable(){} // RVA: 0x7ffaa913f810
        public void OnDestroy(){} // RVA: 0x7ffaa913f890
        public void .cctor(){} // RVA: 0x7ffaa913f8f0
        public void StopCoroutine(){} // RVA: 0x7ffaa913f170
        public void OnBecameVisible(){} // RVA: 0x7ffaa913f950
        public void OnBecameInvisible(){} // RVA: 0x7ffaa913f9c0
        public void StopAllCoroutines(){} // RVA: 0x7ffaa913f9d0
        public void get_useGUILayout(){} // RVA: 0x7ffaa913fb80
        public void set_useGUILayout(){} // RVA: 0x7ffaa913fd30
        public void print(){} // RVA: 0x7ffaa913fdb0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffaa913fe10
        // ── Binary Analysis Named ──
        public void SetLifecycleFlagValue(){} // RVA: 0x7ffaa913f730
    }

    /// <summary>Originally: ÍÌÌÍÌÍÍÏÍÍÍÌÌÎÌÌÎÎÎÏÎÌÏ</summary>
    public class LifecycleComponent_6547 : MonoBehaviour
    {
        public object _6547; // 0x33685CC0, was: ÎÎÍÎÌÏÎÍÌÌÌÏÍÌÏÎÌÌÏÍÏÎÍ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffaa9525f20
        public void RaiseCancellation(){} // RVA: 0x7ffaa9526400
        public void IsInvoking(){} // RVA: 0x7ffaa95268e0
        public void CancelInvoke(){} // RVA: 0x7ffaa9526dc0
        public void Invoke(){} // RVA: 0x7ffaa95272a0
        public void InvokeRepeating(){} // RVA: 0x7ffaa9527780
        public void StartCoroutine(){} // RVA: 0x7ffaa95282f0
        public void Awake(){} // RVA: 0x7ffaa9528840
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9528c30
        public void StopCoroutine(){} // RVA: 0x7ffaa9529110
        public void FixedUpdate(){} // RVA: 0x7ffaa95295f0
        public void Update(){} // RVA: 0x7ffaa9529880
        public void StopAllCoroutines(){} // RVA: 0x7ffaa9529d60
        public void get_useGUILayout(){} // RVA: 0x7ffaa952a240
        public void OnDestroy(){} // RVA: 0x7ffaa95282f0
        public void .ctor(){} // RVA: 0x7ffaa952a4c0
        public void Initialize(){} // RVA: 0x7ffaa952a690
        public void InvokeDelayed(){} // RVA: 0x7ffaa952ac70
        public void StartCoroutineManaged(){} // RVA: 0x7ffaa952bff0
        public void StartCoroutineManaged2(){} // RVA: 0x7ffaa952c4d0
        public void StopCoroutineManaged(){} // RVA: 0x7ffaa952c9b0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7ffaa952cda0
        public void OnCancellationTokenCreated(){} // RVA: 0x7ffaa952d760
        public void UpdateMonoBehaviour(){} // RVA: 0x7ffaa952df40
        public void ProcessComponentActionByType(){} // RVA: 0x7ffaa952f540
        public void OnEnable(){} // RVA: 0x7ffaa952fcb0
        public void Start(){} // RVA: 0x7ffaa9530190
        // ── Binary Analysis Named ──
        public void GetExceptionWrapper(){} // RVA: 0x7ffaa9527c60
        public void SetLifecycleState(){} // RVA: 0x7ffaa95282c0
        public void GetTime_766(){} // RVA: 0x7ffaa952a790
        public void GetGameObject_C48(){} // RVA: 0x7ffaa952b150
        public void GetGameObject_EE6(){} // RVA: 0x7ffaa952b630
        public void GetGameObject_CD8(){} // RVA: 0x7ffaa952bb10
        public void GetScriptClassName(){} // RVA: 0x7ffaa952d280
        public void GetStatus(){} // RVA: 0x7ffaa89d3080
        // ── Obfuscated Methods ──
        public void m_E8F(){} // RVA: 0x7ffaa9528360
        public void m_A53(){} // RVA: 0x7ffaa952db50
        public void m_ED6(){} // RVA: 0x7ffaa952e1c0
        public void m_AD5(){} // RVA: 0x7ffaa952e6a0
        public void m_ABA(){} // RVA: 0x7ffaa952eb80
        public void m_CA1(){} // RVA: 0x7ffaa952f060
        public void m_170(){} // RVA: 0x7ffaa952f7d0
        public void m_0FB(){} // RVA: 0x7ffaa95301a0
    }

    /// <summary>Originally: ÎÌÍÏÌÍÌÍÏÌÌÏÌÍÏÎÏÍÍÌÎÎÎ</summary>
    public class LifecycleComponent_6652 : MonoBehaviour
    {
        public object _uRAgeEitTypeSizekBackingFieldfloat; // 0x336CD9A0, was: ÌÏÎÏÍÌÍÏÎÏÏÌÎÍÎÎÍÏÌÏÎÎÎ
        public object _value; // 0x336CD9A0, was: ÏÏÍÍÏÍÍÍÌÍÏÎÎÎÌÏÎÎÏÌÌÏÏ
        public object _amount; // 0x336CD9A0, was: ÌÎÎÍÌÏÎÏÏÏÌÏÎÎÏÍÍÏÌÏÎÏÌ
        public object _amount2; // 0x336CD9A0, was: ÎÎÎÎÏÌÎÎÎÍÎÏÌÌÌÎÌÍÏÌÎÌÏ
        public object _kBackingField; // 0x336CD9A0, was: ÍÍÎÍÌÍÎÎÌÍÍÌÏÍÍÎÏÎÎÍÌÍÌ
        public object _kBackingField2; // 0x336CD9A0, was: ÍÏÍÏÍÏÍÌÌÌÌÎÏÎÎÎÎÏÎÍÌÍÏ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Awake(){} // RVA: 0x7ffaa9381c20
        public void Computetransform(){} // RVA: 0x7ffaa93820c0
        public void CancelInvoke(){} // RVA: 0x7ffaa93823f0
        public void Invoke(){} // RVA: 0x7ffaa9382690
        public void UpdateAsLastSibling(){} // RVA: 0x7ffaa93830a0
        public void IsInvoking(){} // RVA: 0x7ffaa9383470
        public void StartCoroutine(){} // RVA: 0x7ffaa9383690
        public void Inverse_Injected(){} // RVA: 0x7ffaa9383800
        public void UpdatelocalScale_I(){} // RVA: 0x7ffaa9383a30
        public void StopCoroutine(){} // RVA: 0x7ffaa9384950
        // ── Binary Analysis Named ──
        public void DoInverse_Injected_365(){} // RVA: 0x7ffaa93829d0
        public void DoDOScale(){} // RVA: 0x7ffaa9384230
        public void SetEnabled_9D2(){} // RVA: 0x7ffaa9384b50
    }

    /// <summary>Originally: ÏÎÏÍÎÌÌÌÎÍÍÌÍÏÍÎÌÍÍÏÌÏÍ</summary>
    public class LifecycleComponent_69D7 : MonoBehaviour
    {
        public object _giftsText; // 0x336874C0

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0cbf560
        public void RaiseCancellation(){} // RVA: 0x7ffab0cbf7f0
        public void IsInvoking(){} // RVA: 0x7ffab0cbf880
        public void CancelInvoke(){} // RVA: 0x7ffab0cbfb10
        public void Invoke(){} // RVA: 0x7ffab0cbfda0
        public void InvokeRepeating(){} // RVA: 0x7ffab0cc0030
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Start(){} // RVA: 0x7ffab0cc00c0
        public void StartCoroutine(){} // RVA: 0x7ffab0cc0150
    }

    /// <summary>Originally: ÏÍÎÎÏÏÌÏÎÎÌÌÎÌÍÏÍÏÎÍÎÎÍ</summary>
    public class LifecycleComponent_6D43 : MonoBehaviour
    {
        public object _moryFailureown; // 0x336D6220, was: ÌÎÏÏÎÍÎÍÏÍÍÍÎÍÌÎÍÍÍÎÏÏÍ
        public object _amount; // 0x336D6220, was: ÍÌÏÍÏÎÎÎÌÎÎÍÌÏÎÍÏÌÏÍÏÌÏ

        // ── Original Methods ──
        public void UpdatelocalScale_I(){} // RVA: 0x7ffaa98825c0
        public void OnEnable(){} // RVA: 0x7ffaa98827f0
        public void Awake(){} // RVA: 0x7ffaa98828e0
        public void OnDestroy(){} // RVA: 0x7ffaa9882f70
        public void Invoke(){} // RVA: 0x7ffaa98830a0
        public void InvokeRepeating(){} // RVA: 0x7ffaa98831b0
        public void CancelInvoke(){} // RVA: 0x7ffaa98832e0
        public void IsInvoking(){} // RVA: 0x7ffaa9883440
        public void StartCoroutine(){} // RVA: 0x7ffaa9883670
        public void OnApplicationQuit(){} // RVA: 0x7ffaa98837c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void OnDisable(){} // RVA: 0x7ffaa9883c40
        public void StopAllCoroutines(){} // RVA: 0x7ffaa9883f60
        // ── Binary Analysis Named ──
        public void DoLookRotation_Injected_CB8(){} // RVA: 0x7ffaa9883920
        public void DoLookRotation_Injected_2E9(){} // RVA: 0x7ffaa9883a10
        public void DoLookRotation_Injected_A3E(){} // RVA: 0x7ffaa9883d30
    }

    /// <summary>Originally: ÏÌÏÍÎÌÍÌÎÍÍÎÏÌÏÏÎÌÎÍÌÍÎ</summary>
    public class LifecycleComponent_6D56 : MonoBehaviour
    {
        public object _previousImageButton; // 0x3374E870
        public object _listBinding; // 0x3374E870
        public object _scrollDuration; // 0x3374E870
        public object f_819; // 0x3374E870, was: ÍÎÍÌÌÎÏÎÌÎÍÏÍÌÏÌÌÎÍÌÌÍÎ
        public object _kBackingField; // 0x3374E870, was: ÌÍÌÌÌÏÏÎÌÍÍÎÌÎÎÎÌÎÌÎÌÍÏ
        public object f_3EB; // 0x33745B10, was: ÌÏÌÌÏÎÌÍÍÌÌÏÎÌÏÏÎÏÌÍÎÎÏ
        public object f_7AF; // 0x170001F8, was: ÍÍÌÎÍÌÏÏÏÌÍÍÌÌÌÍÌÏÎÎÎÌÎ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab11925f0
        public void UpdateActive(){} // RVA: 0x7ffab1192690
        public void IsInvoking(){} // RVA: 0x7ffab1192b10
        public void CancelInvoke(){} // RVA: 0x7ffab1192cc0
        public void Invoke(){} // RVA: 0x7ffab1192ce0
        public void InvokeRepeating(){} // RVA: 0x7ffab1192dd0
        public void StartCoroutine(){} // RVA: 0x7ffab1193190
        public void Awake(){} // RVA: 0x7ffab1193230
        public void OnDestroy(){} // RVA: 0x7ffab11933b0
        public void StopCoroutine(){} // RVA: 0x7ffab11934d0
        public void FixedUpdate(){} // RVA: 0x7ffab11936a0
        public void UpdateblocksRayc(){} // RVA: 0x7ffab1193a60
        public void StopAllCoroutines(){} // RVA: 0x7ffab1193c50
        public void get_useGUILayout(){} // RVA: 0x7ffab1193ca0
        public void Updateenabled(){} // RVA: 0x7ffab1193d40
        public void .ctor(){} // RVA: 0x7ffab1193fa0
        public void Initialize(){} // RVA: 0x7ffab1194180
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffab1194220
        public void InvokeDelayed(){} // RVA: 0x7ffab1194310
        public void OnCollisionEnter(){} // RVA: 0x7ffab1194520
        public void OnCollisionStay(){} // RVA: 0x7ffab1194610
        public void IsObjectMonoBehaviour(){} // RVA: 0x7ffab1194700
        public void StartCoroutineManaged(){} // RVA: 0x7ffab1194960
        public void StartCoroutineManaged2(){} // RVA: 0x7ffab1194980
        public void StopCoroutineManaged(){} // RVA: 0x7ffab1194aa0
        // ── Binary Analysis Named ──
        public void GetEnabled_A06(){} // RVA: 0x7ffab1192ef0
        public void GetEnabled_894(){} // RVA: 0x7ffab1192f90
        public void GetPublicKey(){} // RVA: 0x7ffaa89ad730
        public void DoHasKey_7B5(){} // RVA: 0x7ffab1194b40
        public void GetScriptClassName(){} // RVA: 0x7ffab1194d70
    }

    /// <summary>Originally: ÏÎÎÍÎÎÌÏÌÎÏÌÎÌÍÏÌÌÏÍÌÍÎ</summary>
    public class LifecycleComponent_7203 : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void UpdateanchorMi(){} // RVA: 0x7ffaa9cee0f0
        public void IsInvoking(){} // RVA: 0x7ffaa9cee0f0
        public void OnDestroy(){} // RVA: 0x7ffaa9cee3b0
        public void Invoke(){} // RVA: 0x7ffaa9cee4b0
        public void AccessanchorMin_Injected(){} // RVA: 0x7ffaa9cee0f0
        public void OnBecameInvisible(){} // RVA: 0x7ffaa9cee7b0
        public void Awake(){} // RVA: 0x7ffaa9cee930
        // ── Binary Analysis Named ──
        public void GetTransform_404(){} // RVA: 0x7ffaa9cee630
    }

    /// <summary>Originally: ÏÎÌÌÏÌÍÏÏÌÏÎÌÌÏÏÎÏÍÏÎÏÎ</summary>
    public class LifecycleComponent_7220 : MonoBehaviour
    {
        public object _buffer; // 0x33685E40, was: ÏÏÎÎÎÍÏÎÌÌÏÌÎÏÌÌÌÍÎÏÌÏÍ
        public object f_967; // 0x33685E40, was: ÍÏÏÍÌÌÍÍÏÏÌÍÏÍÌÎÍÍÌÌÌÌÎ

        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffab126d710
        public void RaiseCancellation(){} // RVA: 0x7ffab126de30
        public void IsInvoking(){} // RVA: 0x7ffab126ded0
        public void OnEnable(){} // RVA: 0x7ffab126df80
        public void OnDisable(){} // RVA: 0x7ffab126df90
        public void Awake(){} // RVA: 0x7ffab126e060
        public void CancelInvoke(){} // RVA: 0x7ffab126e110
        public void LateUpdate(){} // RVA: 0x7ffab126e2c0
        public void StartCoroutine(){} // RVA: 0x7ffab126e370
        public void Update(){} // RVA: 0x7ffab126ea90
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab126ee20
        public void Start(){} // RVA: 0x7ffab126ef40
        public void OnDestroy(){} // RVA: 0x7ffab126f060
        public void ComputeisActiveAndE(){} // RVA: 0x7ffab126f130
    }

    /// <summary>Originally: ÎÏÏÍÍÍÏÏÍÎÍÎÌÍÎÎÌÍÏÏÌÍÍ</summary>
    public class LifecycleComponent_72BB : MonoBehaviour
    {
        public object f_25D; // 0x336A6AA0, was: ÎÍÎÎÎÎÍÌÌÍÍÏÎÍÏÎÏÍÌÍÏÎÎ
        public object f_775; // 0x336A6AA0, was: ÍÏÎÏÍÌÍÎÍÏÏÍÎÌÏÌÏÍÌÎÌÍÏ
        public object f_047; // 0x336A6AA0, was: ÏÍÌÍÌÎÌÎÌÌÎÌÍÏÌÏÌÍÌÌÏÏÌ

        // ── Original Methods ──
        public void OnDestroy(){} // RVA: 0x7ffab126a110
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab126a210
        public void Updateenabled(){} // RVA: 0x7ffab126a310
        public void Invoke(){} // RVA: 0x7ffab126aaf0
        public void ComputegameObject(){} // RVA: 0x7ffab126ab00
        public void CancelInvoke(){} // RVA: 0x7ffab126ae30
        public void IsInvoking(){} // RVA: 0x7ffab126af30
        public void StartCoroutine(){} // RVA: 0x7ffab126b710
        public void OnTriggerStay(){} // RVA: 0x7ffab126aaf0
        public void OnTriggerExit(){} // RVA: 0x7ffab126aaf0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab126b810
        public void Start(){} // RVA: 0x7ffab126b9b0
        public void StopCoroutine(){} // RVA: 0x7ffab126bce0
    }

    /// <summary>Originally: ÌÌÍÌÍÎÌÌÎÌÌÎÍÌÌÎÎÍÏÏÏÏÎ</summary>
    public class LifecycleComponent_72FC : MonoBehaviour
    {
        public object sensitivitySlider; // 0x3374C960
        public object volumeSliderRaw; // 0x3374C960
        public object f_337; // 0x33C9EB60, was: ÌÎÏÎÌÍÏÍÍÍÏÌÏÍÌÏÍÏÎÌÌÏÏ
        public object f_861; // 0x334EAAB0, was: ÎÏÏÍÏÌÎÍÌÏÌÏÍÎÎÌÎÎÏÏÍÎÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffaa9141800
        public void Start(){} // RVA: 0x7ffaa9141940
        public void IsInvoking(){} // RVA: 0x7ffaa9141a50
        public void Invoke(){} // RVA: 0x7ffaa9141d40
        public void InvokeRepeating(){} // RVA: 0x7ffaa9141e50
        public void UpdateActive(){} // RVA: 0x7ffaa9141f60
        public void OnApplicationPause(){} // RVA: 0x7ffaa9141fd0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9141fe0
        public void StartCoroutine(){} // RVA: 0x7ffaa91424c0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9141f60
        public void StopCoroutine(){} // RVA: 0x7ffaa9142710
        public void Awake(){} // RVA: 0x7ffaa91428c0
        public void OnDestroy(){} // RVA: 0x7ffaa9142a00
        public void OnEnable(){} // RVA: 0x7ffaa9142bb0
        public void OnDisable(){} // RVA: 0x7ffaa9141fd0
        // ── Binary Analysis Named ──
        public void DoFormatInt32(){} // RVA: 0x7ffaa9141b90
    }

    /// <summary>Originally: ÎÌÏÍÎÌÌÎÏÌÍÍÍÏÎÎÏÍÌÍÏÍÌ</summary>
    public class LifecycleComponent_75CD : MonoBehaviour
    {
        public object calloutString; // 0x336BCB20

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab135db40
        public void UpdateActive(){} // RVA: 0x7ffab135dc50
        public void IsInvoking(){} // RVA: 0x7ffab135de80
        public void CancelInvoke(){} // RVA: 0x7ffab135dfe0
        public void Start(){} // RVA: 0x7ffab135e140
        public void OnDestroy(){} // RVA: 0x7ffab135e250
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab135e350
        public void StartCoroutine(){} // RVA: 0x7ffab135e4b0
        public void OnBecameInvisible(){} // RVA: 0x7ffab135e5c0
        public void OnApplicationPause(){} // RVA: 0x7ffab135e6d0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab135e7d0
    }

    /// <summary>Originally: ÍÍÌÌÎÏÏÍÏÏÌÍÏÍÎÎÍÏÍÌÍÏÍ</summary>
    public class LifecycleComponent_7629 : MonoBehaviour
    {
        public object _vector; // 0x33667010, was: <ÍÏÎÏÌÏÏÎÏÌÎÎÏÎÌÍÎÍÎÎÍÏÎ>k__Ba
        public object _7629; // 0x17000204, was: ÌÍÏÌÍÏÏÏÍÎÍÏÌÎÍÏÌÌÌÍÏÌÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab11ea130
        public void IsInvoking(){} // RVA: 0x7ffaa8d14570
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void CancelInvoke(){} // RVA: 0x7ffab11ea1a0
        public void OnDisable(){} // RVA: 0x7ffab11ea360
        public void OnDestroy(){} // RVA: 0x7ffab11ea5a0
        public void Start(){} // RVA: 0x7ffab11ea9a0
        public void StopCoroutine(){} // RVA: 0x7ffaa8d14570
        public void OnCollisionEnter(){} // RVA: 0x7ffaa8d14570
        // ── Binary Analysis Named ──
        public void GetTextureTransparency(){} // RVA: 0x7ffaa8d14570
        public void SetStoreCallback(){} // RVA: 0x7ffaa8960890
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
        public void GetGameObject_623(){} // RVA: 0x7ffab11ea760
        public void GetGameObject_7FF(){} // RVA: 0x7ffab11eac10
    }

    /// <summary>Originally: ÎÎÏÌÌÍÏÏÏÍÌÍÌÎÌÌÎÍÌÏÎÍÌ</summary>
    public class LifecycleComponent_78D1 : MonoBehaviour
    {
        public object _amount; // 0x3365B8C0, was: ÍÍÎÍÏÍÌÏÍÌÌÎÎÏÏÎÍÍÌÍÎÍÌ
        public object _flag; // 0x3365B8C0, was: ÎÍÏÏÎÎÌÌÍÍÏÍÌÌÏÌÌÏÏÌÏÌÌ

        // ── Original Methods ──
        public void ComputeMaterial(){} // RVA: 0x7ffaa94d5f90
        public void UpdateTextureOffsetI(){} // RVA: 0x7ffaa94d6150
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void InvokeRepeating(){} // RVA: 0x7ffaa94d6590
        public void IsInvoking(){} // RVA: 0x7ffaa94d6930
        public void StartCoroutine(){} // RVA: 0x7ffaa94d6950
        public void .cctor(){} // RVA: 0x7ffaa94d6b10
        public void OnDisable(){} // RVA: 0x7ffaa94d6bb0
        public void OnDestroy(){} // RVA: 0x7ffaa94d6930
        public void StopCoroutine(){} // RVA: 0x7ffaa94d6d70
        // ── Binary Analysis Named ──
        public void GetGameObject_168(){} // RVA: 0x7ffaa94d6330
        public void SetEnabled_751(){} // RVA: 0x7ffaa94d63d0
        public void DoPingPong(){} // RVA: 0x7ffaa94d6750
    }

    /// <summary>Originally: ÏÍÎÌÍÏÍÍÍÍÌÏÍÏÌÌÏÏÍÌÎÎÎ</summary>
    public class LifecycleComponent_7975 : MonoBehaviour
    {
        public object targetToggle; // 0x33687640

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9163d00
        public void IsInvoking(){} // RVA: 0x7ffaa9163e00
        public void Start(){} // RVA: 0x7ffaa9163f00
        public void Invoke(){} // RVA: 0x7ffaa9164010
        public void InvokeRepeating(){} // RVA: 0x7ffaa91640c0
        public void CancelInvoke(){} // RVA: 0x7ffaa9164600
        public void OnDestroy(){} // RVA: 0x7ffaa91646b0
        // ── Binary Analysis Named ──
        public void DoGetIsLoadedInternal_C57(){} // RVA: 0x7ffaa91647b0
        public void DoGetIsLoadedInternal_8EE(){} // RVA: 0x7ffaa9164860
    }

    /// <summary>Originally: ÏÍÌÎÎÏÎÍÍÏÍÍÌÌÏÌÎÍÏÎÏÌÎ</summary>
    public class LifecycleComponent_7B90 : MonoBehaviour
    {
        public object f_E0E; // 0x3365B040, was: ÏÌÏÌÍÎÏÏÏÏÍÏÏÌÏÎÎÍÏÍÏÍÏ
        public object _flag; // 0x3365B040, was: ÎÏÌÍÏÎÏÎÍÍÍÎÎÎÏÏÎÌÏÏÌÍÏ

        // ── Original Methods ──
        public void RaiseCancellation(){} // RVA: 0x7ffab123d1b0
        public void IsInvoking(){} // RVA: 0x7ffaa89600c0
        public void CancelInvoke(){} // RVA: 0x7ffab123d2b0
        public void Invoke(){} // RVA: 0x7ffab123d5d0
        public void .ctor(){} // RVA: 0x7ffab123d7a0
        public void Initialize(){} // RVA: 0x7ffab123d8a0
        public void Awake(){} // RVA: 0x7ffab123d9a0
        public void Start(){} // RVA: 0x7ffab123dbc0
        public void StartCoroutine(){} // RVA: 0x7ffab123dd90
        public void Reset(){} // RVA: 0x7ffab123df60
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa89600c0
        public void StopCoroutine(){} // RVA: 0x7ffab123e180
        public void OnApplicationPause(){} // RVA: 0x7ffab123e250
        // ── Binary Analysis Named ──
        public void DoReset(){} // RVA: 0x7ffab123d0c0
        public void SetModelShader(){} // RVA: 0x7ffaa89ad740
    }

    /// <summary>Originally: ÌÍÌÏÎÎÏÏÎÏÏÌÍÏÏÎÍÎÌÍÍÎÍ</summary>
    public class LifecycleComponent_7D6C : MonoBehaviour
    {
        public object _flag; // 0x3374ECA0, was: ÏÏÍÍÌÌÍÌÌÌÍÏÍÌÍÏÌÌÎÍÍÌÏ
        public object f_692; // 0x170001AB, was: ÌÏÍÍÎÎÎÎÎÍÎÍÏÏÎÎÍÌÎÎÏÎÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab106cb30
        public void IsValid(){} // RVA: 0x7ffaa8958450
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa8958450
        public void InvokeRepeating(){} // RVA: 0x7ffab106cdc0
        public void OnEnable(){} // RVA: 0x7ffab106cdc0
        // ── Binary Analysis Named ──
        public void GetGameObject_870(){} // RVA: 0x7ffab106cb40
        public void SetActive_B9E(){} // RVA: 0x7ffab106cdd0
        public void GetGameObject_462(){} // RVA: 0x7ffab106cb30
        public void GetGameObject_86F(){} // RVA: 0x7ffab106d050
    }

    /// <summary>Originally: ÏÏÏÌÍÌÍÍÌÎÎÏÍÍÌÏÏÍÎÎÍÎÍ</summary>
    public class LifecycleComponent_8A0C : MonoBehaviour
    {
        public object f_637; // 0x336A6070, was: ÏÍÏÌÍÎÍÌÍÍÏÍÎÏÎÏÎÌÎÍÌÏÌ
        public object _rCUdonCommonInterfaceseMismatchException; // 0x336A6070, was: ÌÏÍÌÌÎÎÌÌÌÏÌÍÍÌÍÏÍÌÍÎÌÏ
        public object f_4A5; // 0x336A6070, was: ÌÍÎÌÍÌÌÎÏÏÏÍÌÍÏÏÎÍÏÍÏÎÌ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9dce3e0
        public void Initialize(){} // RVA: 0x7ffaa9dce4e0
        public void IsInvoking(){} // RVA: 0x7ffaa9dcecf0
        public void CancelInvoke(){} // RVA: 0x7ffaa9dcee40
        public void Invoke(){} // RVA: 0x7ffaa9dcee50
        public void UpdateActive(){} // RVA: 0x7ffaa9dcef60
        public void Start(){} // RVA: 0x7ffaa9dcf2d0
        public void FixedUpdate(){} // RVA: 0x7ffaa9dcf350
        public void StartCoroutine(){} // RVA: 0x7ffaa9dcf480
        public void LateUpdate(){} // RVA: 0x7ffaa9dcf9f0
        public void OnDisable(){} // RVA: 0x7ffaa9dcfb30
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9dcfce0
        public void StopCoroutine(){} // RVA: 0x7ffaa9dd06a0
        public void OnApplicationQuit(){} // RVA: 0x7ffaa9dd0760
        public void OnBecameVisible(){} // RVA: 0x7ffaa9dd0880
        public void StopAllCoroutines(){} // RVA: 0x7ffaa9dd0990
        public void set_useGUILayout(){} // RVA: 0x7ffaa9dd0b50
        public void print(){} // RVA: 0x7ffaa9dd0b80
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffaa9dd0c00
        public void Computehash(){} // RVA: 0x7ffaa9dd0d40
        public void InvokeDelayed(){} // RVA: 0x7ffaa9dd1170
        public void ComputegameObject(){} // RVA: 0x7ffaa9dd19d0
        public void OnEnable(){} // RVA: 0x7ffaa9dd1c60
        public void IsObjectMonoBehaviour(){} // RVA: 0x7ffaa9dd1e50
        public void StartCoroutineManaged(){} // RVA: 0x7ffaa9dd2140
        // ── Binary Analysis Named ──
        public void DoGetLastValueAsDouble_Injected_73A(){} // RVA: 0x7ffaa9dd0aa0
    }

    /// <summary>Originally: ÌÌÏÌÌÍÏÏÎÏÍÌÏÏÍÎÌÍÌÌÏÍÏ</summary>
    public class LifecycleComponent_8ADF : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0e36120
        public void RaiseCancellation(){} // RVA: 0x7ffab0e36260
        public void CancelInvoke(){} // RVA: 0x7ffab0e364e0
        public void Invoke(){} // RVA: 0x7ffab0e36620
        public void InvokeRepeating(){} // RVA: 0x7ffab0e36760
        public void Awake(){} // RVA: 0x7ffab0e368a0
        public void Start(){} // RVA: 0x7ffab0e369e0
        public void StartCoroutine(){} // RVA: 0x7ffab0e36b20
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetParent_8BA(){} // RVA: 0x7ffab0e363a0
    }

    /// <summary>Originally: ÎÎÌÌÏÎÌÍÌÎÏÏÍÍÍÏÌÍÌÏÌÎÌ</summary>
    public class LifecycleComponent_8BAC : MonoBehaviour
    {
        public object page; // 0x336F4380
        public object f_2EB; // 0x336F4380, was: ÎÎÏÎÌÍÎÍÌÍÎÍÎÍÎÌÏÎÎÎÎÏÍ
        public object f_3B4; // 0x336196B0, was: ÍÍÏÍÌÌÎÎÍÍÏÎÌÍÎÏÌÍÏÏÌÍÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab11a2ca0
        public void RaiseCancellation(){} // RVA: 0x7ffab11a2ea0
        public void IsInvoking(){} // RVA: 0x7ffab11a3290
        public void Invoke(){} // RVA: 0x7ffab11a3ff0
        public void Start(){} // RVA: 0x7ffab11a4090
        public void CancelInvoke(){} // RVA: 0x7ffab11a4130
        public void Update(){} // RVA: 0x7ffab11a4310
        public void StartCoroutine(){} // RVA: 0x7ffab11a4dd0
        public void OnDisable(){} // RVA: 0x7ffab11a4fb0
        public void .ctor(){} // RVA: 0x7ffab11a5010
        public void Initialize(){} // RVA: 0x7ffab11a51a0
        public void StopCoroutine(){} // RVA: 0x7ffab11a55c0
        public void OnBecameVisible(){} // RVA: 0x7ffab11a55c0
        public void OnBecameInvisible(){} // RVA: 0x7ffab11a5620
        public void StopAllCoroutines(){} // RVA: 0x7ffab11a6100
        public void get_useGUILayout(){} // RVA: 0x7ffab11a62e0
        public void OnDestroy(){} // RVA: 0x7ffab11a6470
        public void print(){} // RVA: 0x7ffab11a6640
        // ── Binary Analysis Named ──
        public void DoDestroy(){} // RVA: 0x7ffab11a3510
    }

    /// <summary>Originally: ÎÎÏÎÏÏÍÌÌÎÎÌÏÏÌÌÏÏÎÌÌÌÍ</summary>
    public class LifecycleComponent_8CEB : MonoBehaviour
    {
        public object gradientIndicator; // 0x3366D170
        public object indicatorOffsetMulti; // 0x3366D170

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab139f4a0
        public void RaiseCancellation(){} // RVA: 0x7ffab139f550
        public void Initialize(){} // RVA: 0x7ffab139fdf0
        public void CancelInvoke(){} // RVA: 0x7ffab139fb00
        public void Invoke(){} // RVA: 0x7ffab139fb50
        public void InvokeRepeating(){} // RVA: 0x7ffab139fc50
        public void .cctor(){} // RVA: 0x7ffab139fd50
        public void OnApplicationQuit(){} // RVA: 0x7ffab139fdf0
        public void StartCoroutine(){} // RVA: 0x7ffab139fe20
        public void OnBecameInvisible(){} // RVA: 0x7ffab139fb00
        public void .ctor(){} // RVA: 0x7ffab139fed0
        public void Initialize(){} // RVA: 0x7ffab139fdf0
        public void StopCoroutine(){} // RVA: 0x7ffab139fdf0
        public void OnTriggerEnter(){} // RVA: 0x7ffab139ff20
        public void StopAllCoroutines(){} // RVA: 0x7ffab13a0120
        // ── Binary Analysis Named ──
        public void DoRGBToHSVHelper(){} // RVA: 0x7ffab13a0020
    }

    /// <summary>Originally: ÍÍÎÌÎÏÏÏÎÏÍÌÏÍÌÌÍÏÎÍÏÌÎ</summary>
    public class LifecycleComponent_8E78 : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffaa8ae67f0
        public void Start(){} // RVA: 0x7ffaa8ae68a0
        public void OnEnable(){} // RVA: 0x7ffaa8ae69a0
        public void OnDisable(){} // RVA: 0x7ffaa8ae6a50
        public void Computetransform(){} // RVA: 0x7ffaa8ae6b00
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void ComputeParent(){} // RVA: 0x7ffaa8ae6c00
        public void IsInvoking(){} // RVA: 0x7ffaa8ae6e80
        public void StartCoroutine(){} // RVA: 0x7ffaa8ae6f80
    }

    /// <summary>Originally: ÌÎÎÌÎÎÌÎÌÌÍÎÏÏÌÎÏÌÍÍÌÏÌ</summary>
    public class LifecycleComponent_8EED : MonoBehaviour
    {
        public object groupInstanceTypeSeparator; // 0x336648D0
        public object groupPublicInstanceTypeButton; // 0x336648D0

        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffab110c660
        public void Start(){} // RVA: 0x7ffab110caf0
        public void IsInvoking(){} // RVA: 0x7ffab110cc10
        public void CancelInvoke(){} // RVA: 0x7ffab110cc40
        public void Invoke(){} // RVA: 0x7ffab110d0d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab110d1f0
        public void OnApplicationPause(){} // RVA: 0x7ffab110cc10
        // ── Binary Analysis Named ──
        public void GetActiveSelf_598(){} // RVA: 0x7ffab110d1f0
        public void GetActiveSelf_2E0(){} // RVA: 0x7ffab110d260
        public void GetActiveSelf_C7A(){} // RVA: 0x7ffab110d380
        public void GetActiveSelf_1EC(){} // RVA: 0x7ffab110d3d0
        public void GetActiveSelf_45D(){} // RVA: 0x7ffab110d860
        public void GetActiveSelf_54F(){} // RVA: 0x7ffab110d8d0
    }

    /// <summary>Originally: ÎÎÎÍÏÍÌÍÎÌÍÏÍÏÍÍÌÍÍÍÏÎÏ</summary>
    public class LifecycleComponent_91EB : MonoBehaviour
    {
        public object _ePathName; // 0x336BC820, was: ÌÏÍÍÍÌÏÍÎÌÍÌÍÌÎÏÎÏÎÍÍÌÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab11f55d0
        public void RaiseCancellation(){} // RVA: 0x7ffab11f5760
        public void IsInvoking(){} // RVA: 0x7ffab11f5910
        public void CancelInvoke(){} // RVA: 0x7ffab11f5920
        public void Invoke(){} // RVA: 0x7ffab11f5ad0
        public void InvokeRepeating(){} // RVA: 0x7ffab11f5ae0
        public void Awake(){} // RVA: 0x7ffab11f5c70
        public void Start(){} // RVA: 0x7ffab11f5c80
        public void StartCoroutine(){} // RVA: 0x7ffab11f5db0
        public void Update(){} // RVA: 0x7ffab11f5f40
        public void OnEnable(){} // RVA: 0x7ffab11f5ad0
        public void OnDisable(){} // RVA: 0x7ffab11f6070
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab11f6200
        public void StopCoroutine(){} // RVA: 0x7ffab11f5910
    }

    /// <summary>Originally: ÏÏÌÎÏÌÍÍÍÌÎÏÏÏÌÏÏÍÍÌÏÌÌ</summary>
    public class LifecycleComponent_9585 : MonoBehaviour
    {
        public object _groupName; // 0x3366CA60
        public object _button; // 0x33C4C700

        // ── Original Methods ──
        public void RaiseCancellation(){} // RVA: 0x7ffab112c150
        public void Start(){} // RVA: 0x7ffab112c530
        public void Invoke(){} // RVA: 0x7ffab112c640
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void StartCoroutine(){} // RVA: 0x7ffab112cc10
        // ── Binary Analysis Named ──
        public void GetGameObject_348(){} // RVA: 0x7ffab112c040
        public void GetGameObject_8BA(){} // RVA: 0x7ffab112c420
        public void GetGameObject_49F(){} // RVA: 0x7ffab112c750
        public void GetGameObject_D92(){} // RVA: 0x7ffab112c830
        public void GetGameObject_DFA(){} // RVA: 0x7ffab112cb00
        public void GetGameObject_960(){} // RVA: 0x7ffab112cee0
    }

    /// <summary>Originally: ÌÍÌÎÌÌÌÍÎÎÌÏÏÍÌÏÌÌÍÌÌÎÌ</summary>
    public class LifecycleComponent_9789 : MonoBehaviour
    {
        public object _varintSlowPath; // 0x336D4890, was: ÌÌÍÌÌÎÏÍÌÏÌÏÍÌÍÎÍÎÌÌÌÏÏ
        public object f_BF7; // 0x336D4890, was: ÎÌÎÏÌÏÌÏÍÍÌÏÏÎÏÍÍÏÌÏÌÌÌ
        public object _toggle; // 0x33BCF920
        public object f_D58; // 0x33BCF920, was: ÍÏÍÎÎÏÏÎÏÏÌÏÎÎÍÏÌÏÎÎÍÍÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab1252b70
        public void ComputegameObject(){} // RVA: 0x7ffab1252f60
        public void IsInvoking(){} // RVA: 0x7ffab12531c0
        public void CancelInvoke(){} // RVA: 0x7ffab1253420
        public void Start(){} // RVA: 0x7ffab1253430
        public void OnDestroy(){} // RVA: 0x7ffab1253680
        public void Update(){} // RVA: 0x7ffab1253690
        public void LateUpdate(){} // RVA: 0x7ffab1253a80
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab1253b40
        public void StartCoroutine(){} // RVA: 0x7ffab1253c00
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab1253d70
        public void StopCoroutine(){} // RVA: 0x7ffab1254160
        public void OnBecameInvisible(){} // RVA: 0x7ffab1253680
    }

    /// <summary>Originally: ÏÌÏÌÌÏÌÍÍÌÏÏÎÏÏÍÍÎÌÏÏÌÌ</summary>
    public class LifecycleComponent_9796 : MonoBehaviour
    {
        public object _buffer; // 0x3366E2A0, was: ÏÍÌÍÌÎÎÍÌÎÍÎÎÎÍÏÌÌÍÌÌÏÎ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffaa9d18c10
        public void RaiseCancellation(){} // RVA: 0x7ffaa9d18c10
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9d195d0
        public void Awake(){} // RVA: 0x7ffaa9d18c10
        public void OnDestroy(){} // RVA: 0x7ffaa9d195d0
        public void UpdateActive(){} // RVA: 0x7ffaa9d19f90
        public void StartCoroutine(){} // RVA: 0x7ffaa9d1a2b0
        public void Update(){} // RVA: 0x7ffaa9d1a5d0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9d18c10
        // ── Binary Analysis Named ──
        public void DoFindRelativeTran(){} // RVA: 0x7ffaa9d18c20
        public void DoFindRelativeTransformWithPath(){} // RVA: 0x7ffaa9d195e0
    }

    /// <summary>Originally: ÌÍÍÎÎÏÏÌÎÎÍÍÌÏÍÍÏÌÏÌÌÎÍ</summary>
    public class LifecycleComponent_99CD : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab1131a10
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab1132090
        public void CancelInvoke(){} // RVA: 0x7ffab11323c0
        public void IsInvoking(){} // RVA: 0x7ffab11328e0
        public void StartCoroutine(){} // RVA: 0x7ffab1132e00
        public void OnBecameVisible(){} // RVA: 0x7ffab1133130
        public void Reset(){} // RVA: 0x7ffab1133460
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab11334f0
        // ── Binary Analysis Named ──
        public void GetGameObject_6B4(){} // RVA: 0x7ffab11316e0
        public void GetGameObject_DFA(){} // RVA: 0x7ffab1131ac0
        public void GetGameObject_30E(){} // RVA: 0x7ffab1131b70
    }

    /// <summary>Originally: ÍÏÎÌÏÍÍÌÎÏÏÏÍÏÏÏÎÍÍÍÍÍÎ</summary>
    public class LifecycleComponent_9E9B : MonoBehaviour
    {
        public object _buffer; // 0x33734C20, was: ÎÍÌÌÎÏÏÏÌÍÏÌÏÏÍÌÍÌÌÎÎÌÌ

        // ── Original Methods ──
        public void UpdatelocalRotatio(){} // RVA: 0x7ffaa9b828a0
        public void InvokeRepeating(){} // RVA: 0x7ffaa9b82e00
        public void OnDestroy(){} // RVA: 0x7ffaa9b82eb0
        public void StartCoroutine(){} // RVA: 0x7ffaa9b82ec0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa9b83230
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9b83550
        public void StopCoroutine(){} // RVA: 0x7ffaa9b838c0
        public void ValidateAgainstExecutionFlags(){} // RVA: 0x7ffaa8bf45b0
        // ── Binary Analysis Named ──
        public void DoValidateAgainstExecutionFlags_4D6(){} // RVA: 0x7ffaa9b82250
        public void DoInternal_GetStoredColorSpace_883(){} // RVA: 0x7ffaa9b82340
        public void DoCopyTexture_Internal_5FF(){} // RVA: 0x7ffaa9b82760
        public void DoSetTextureImpl_3B8(){} // RVA: 0x7ffaa9b82cc0
        public void GetShapes(){} // RVA: 0x7ffaa8bf45b0
        public void SetTextureImpl(){} // RVA: 0x7ffaa9b83970
    }

    /// <summary>Originally: ÌÌÍÏÏÌÎÌÏÌÏÍÎÍÎÍÎÎÏÎÌÏÍ</summary>
    public class LifecycleComponent_A06B : MonoBehaviour
    {
        public object _amount; // 0x3374CF80, was: ÍÍÍÏÎÏÏÌÎÏÏÎÌÏÍÍÏÌÍÌÍÌÍ
        public object _ePathName; // 0x3374CF80, was: ÍÏÎÎÏÍÌÎÎÍÍÎÌÍÏÏÏÎÍÎÌÎÍ
        public object f_347; // 0x3346CC90, was: ÏÌÏÏÏÏÎÌÍÏÎÍÌÍÎÍÍÍÎÍÎÎÎ

        // ── Original Methods ──
        public void Computeposition_Inj(){} // RVA: 0x7ffaa9d1b3d0
        public void RaiseCancellation(){} // RVA: 0x7ffaa9d1b660
        public void IsInvoking(){} // RVA: 0x7ffaa9d1bc00
        public void Updateposition_Inj(){} // RVA: 0x7ffaa9d1bf00
        public void Invoke(){} // RVA: 0x7ffaa9d1c020
        public void InvokeRepeating(){} // RVA: 0x7ffaa9d1c2b0
        public void CancelInvoke(){} // RVA: 0x7ffaa9d1bf00
        public void set_referenceSpritePixelsPerUnit(){} // RVA: 0x7ffaa89fc640
        public void ConfigureminValue(){} // RVA: 0x7ffaa9d1c3d0
        public void .ctor(){} // RVA: 0x7ffaa9d1c480
        public void Initialize(){} // RVA: 0x7ffaa9d1c510
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9d1c510
        public void Awake(){} // RVA: 0x7ffaa9d1c620
        public void OnDestroy(){} // RVA: 0x7ffaa9d1cbb0
        public void StopCoroutine(){} // RVA: 0x7ffaa9d1cc50
    }

    /// <summary>Originally: ÌÌÌÎÌÌÍÏÏÌÎÏÎÏÌÍÎÏÌÌÎÍÍ</summary>
    public class LifecycleComponent_A2A2 : MonoBehaviour
    {
        public object _a2A2; // 0x3366F3C0, was: ÍÏÍÎÎÏÏÎÏÏÌÏÎÎÍÏÌÏÎÎÍÍÏ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab1343c50
        public void RaiseCancellation(){} // RVA: 0x7ffab13441c0
        public void Awake(){} // RVA: 0x7ffab13442e0
        public void OnDestroy(){} // RVA: 0x7ffab1344390
        public void Invoke(){} // RVA: 0x7ffab13444b0
        public void InvokeRepeating(){} // RVA: 0x7ffab13445d0
        public void CancelInvoke(){} // RVA: 0x7ffab13447a0
        public void IsInvoking(){} // RVA: 0x7ffab1344d10
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab1344ee0
    }

    /// <summary>Originally: ÍÎÌÍÍÍÎÏÏÎÌÍÏÏÌÎÍÍÍÎÏÎÌ</summary>
    public class LifecycleComponent_A8F0 : MonoBehaviour
    {
        public object f_DD3; // 0x3374E530, was: ÌÏÌÎÍÏÍÎÌÌÍÎÎÎÎÏÏÍÏÏÍÏÍ
        public object _amount; // 0x3374E530, was: ÍÌÌÍÏÎÎÎÌÌÏÌÌÏÍÏÌÎÏÏÏÌÌ
        public object 8؏f; // 0x66DE495E

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8ad1270
        public void Start(){} // RVA: 0x7ffaa8ad12d0
        public void IsInvoking(){} // RVA: 0x7ffaa8ad13f0
        public void CancelInvoke(){} // RVA: 0x7ffaa8ad1490
        public void ComputeMaterial(){} // RVA: 0x7ffaa8ad1650
        public void OnApplicationPause(){} // RVA: 0x7ffaa8ad1890
        public void StartCoroutine(){} // RVA: 0x7ffaa8ad1930
        public void OnBecameVisible(){} // RVA: 0x7ffaa8ad19d0
        // ── Binary Analysis Named ──
        public void GetGameObject_DFA(){} // RVA: 0x7ffaa8ad1530
        public void DoGetMaterial(){} // RVA: 0x7ffaa8ad1770
    }

    /// <summary>Originally: ÌÎÎÍÍÌÌÏÌÎÍÎÎÌÍÎÏÎÌÌÍÌÍ</summary>
    public class LifecycleComponent_A8FF : MonoBehaviour
    {
        public object filterDropdown; // 0x336D57C0
        public object _a8FF; // 0x336D57C0, was: ÏÍÏÍÎÍÌÎÏÎÌÏÍÍÎÎÏÏÍÎÎÌÏ

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab0d1ab70
        public void Invoke(){} // RVA: 0x7ffab0d1b9b0
        public void InvokeRepeating(){} // RVA: 0x7ffab0d1bbf0
        public void UpdateActive(){} // RVA: 0x7ffab0d1bde0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void StartCoroutine(){} // RVA: 0x7ffab0d1bde0
        public void OnEnable(){} // RVA: 0x7ffab0d1c460
        public void OnDisable(){} // RVA: 0x7ffaa8960130
        public void StopCoroutine(){} // RVA: 0x7ffab0d1c460
        // ── Binary Analysis Named ──
        public void GetGameObject_0D1(){} // RVA: 0x7ffab0d1a650
        public void GetGameObject_E89(){} // RVA: 0x7ffab0d1a660
        public void DoAdd(){} // RVA: 0x7ffab0d1b7c0
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void DoAddMonths(){} // RVA: 0x7ffab0d1bf40
        public void DoDateToTicks(){} // RVA: 0x7ffab0d1c490
    }

    /// <summary>Originally: ÌÌÍÎÎÎÌÌÎÌÏÏÎÎÏÍÍÍÍÏÎÏÍ</summary>
    public class LifecycleComponent_AA84 : MonoBehaviour
    {
        public object _itTypeSize; // 0x33784030, was: ÌÏÌÌÏÌÍÏÍÎÌÍÍÏÎÎÍÌÌÎÍÏÌ
        public object f_EC3; // 0x337268B0, was: ÌÌÍÎÏÍÎÎÍÌÍÎÌÍÏÍÎÎÌÏÌÌÌ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab0d7bb20
        public void IsInvoking(){} // RVA: 0x7ffab0d7bb20
        public void Awake(){} // RVA: 0x7ffab0d7bb50
        public void OnDestroy(){} // RVA: 0x7ffab0d7bb20
        public void InvokeRepeating(){} // RVA: 0x7ffab0d7bb20
        public void CancelInvoke(){} // RVA: 0x7ffab0d7bb20
        public void Update(){} // RVA: 0x7ffab0d7bb20
        public void StartCoroutine(){} // RVA: 0x7ffab0d7bcf0
        public void OnDisable(){} // RVA: 0x7ffab0d7be90
        // ── Binary Analysis Named ──
        public void SetComponentActivity(){} // RVA: 0x7ffab0d7bb20
    }

    /// <summary>Originally: ÍÌÌÌÏÌÎÌÍÎÍÏÍÌÏÍÏÍÎÌÎÎÍ</summary>
    public class LifecycleComponent_B104 : MonoBehaviour
    {
        public object _b104; // 0x3381E4C0, was: ÌÍÌÏÍÌÏÏÌÍÍÍÎÏÏÏÎÎÌÍÍÍÌ

        // ── Original Methods ──
        public void UpdateActive(){} // RVA: 0x7ffab116ce60
        public void ConfigureconstraintCount(){} // RVA: 0x7ffab116cfc0
        public void CancelInvoke(){} // RVA: 0x7ffab116d120
        public void Invoke(){} // RVA: 0x7ffab116d280
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Start(){} // RVA: 0x7ffab116d3e0
        // ── Binary Analysis Named ──
        public void GetGameObject_30B(){} // RVA: 0x7ffab116cd00
    }

    /// <summary>Originally: ÌÏÎÌÏÎÌÌÌÏÏÎÎÎÏÍÎÏÌÏÏÍÍ</summary>
    public class LifecycleComponent_B483 : MonoBehaviour
    {
        public object _uRAwoDigitYearMax; // 0x33659D00, was: ÍÎÏÌÎÏÌÍÎÏÏÎÎÍÏÌÍÌÏÍÌÌÏ
        public object f_EBA; // 0x33AE5240, was: ÎÌÎÌÌÌÌÍÍÍÏÌÍÍÌÎÌÏÍÎÍÎÍ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffaa8960130
        public void CancelInvoke(){} // RVA: 0x7ffaa8960130
        public void Invoke(){} // RVA: 0x7ffab0d266e0
        public void OnEnable(){} // RVA: 0x7ffab0d26810
        public void OnDisable(){} // RVA: 0x7ffab0d26820
        public void IsInvoking(){} // RVA: 0x7ffab0d26940
        public void StartCoroutine(){} // RVA: 0x7ffaa8960130
        public void LateUpdate(){} // RVA: 0x7ffab0d26810
        // ── Binary Analysis Named ──
        public void GetMethod(){} // RVA: 0x7ffaa8960130
    }

    /// <summary>Originally: ÏÌÍÌÏÎÎÎÌÏÏÍÎÎÍÍÎÎÍÏÍÌÏ</summary>
    public class LifecycleComponent_B715 : MonoBehaviour
    {
        // ── Original Methods ──
        public void UpdateGlobalFloatImpl(){} // RVA: 0x7ffaa8e81090
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void .cctor(){} // RVA: 0x7ffaa8e811d0
        public void Invoke(){} // RVA: 0x7ffaa8e81270
        public void InvokeRepeating(){} // RVA: 0x7ffaa8e81310
        public void OnPostRender(){} // RVA: 0x7ffaa8e813b0
        public void IsInvoking(){} // RVA: 0x7ffaa8e81450
        public void OnPreRender(){} // RVA: 0x7ffaa8e814f0
        public void StartCoroutine(){} // RVA: 0x7ffaa8e81590
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa8e816d0
        // ── Binary Analysis Named ──
        public void DoSetGlobalFloatImpl(){} // RVA: 0x7ffaa8e81130
        public void SetGlobalFloatImpl(){} // RVA: 0x7ffaa8e81630
    }

    /// <summary>Originally: ÌÌÌÎÎÍÎÍÍÍÎÎÏÌÌÏÏÌÌÎÏÏÎ</summary>
    public class LifecycleComponent_BBFB : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffab10674f0
        public void Awake(){} // RVA: 0x7ffab1067740
        public void RegisterOnDisconnected(){} // RVA: 0x7ffaa8933e90
        public void ComputegameObject(){} // RVA: 0x7ffab1067820
        public void StartCoroutine(){} // RVA: 0x7ffaa8933e90
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab1067900
        // ── Binary Analysis Named ──
        public void SetActive_30B(){} // RVA: 0x7ffab1066c40
        public void SetActive_49B(){} // RVA: 0x7ffab1066db0
        public void GetGameObject_D4C(){} // RVA: 0x7ffab1067150
        public void SetActive_98A(){} // RVA: 0x7ffab1067660
    }

    /// <summary>Originally: ÏÏÌÎÏÌÍÏÏÏÌÏÌÍÏÍÌÎÏÍÌÎÎ</summary>
    public class LifecycleComponent_BE1F : MonoBehaviour
    {
        public object _noThumbnailTexture; // 0x33724F50
        public object _unavailableOverlay; // 0x33724F50
        public object _securityCheckFailedIcon; // 0x33724F50
        public object _gFieldldKeyboardOverride; // 0x33724F50, was: ÍÏÍÏÌÌÌÌÍÍÏÏÍÍÎÌÌÍÏÍÏÎÍ
        public object f_DD3; // 0xB3F6FFF0, was: ÍÏÏÏÏÌÎÌÌÎÏÎÏÍÎÏÌÏÌÏÌÏÎ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab12afec0
        public void UpdateActive(){} // RVA: 0x7ffab12aff00
        public void IsInvoking(){} // RVA: 0x7ffab12b0d10
        public void CancelInvoke(){} // RVA: 0x7ffab12b1bc0
        public void Invoke(){} // RVA: 0x7ffab12b1d20
        public void InvokeRepeating(){} // RVA: 0x7ffab12b1ed0
        public void Start(){} // RVA: 0x7ffab12b21b0
        public void Update(){} // RVA: 0x7ffab12b2310
        public void Awake(){} // RVA: 0x7ffab12b23c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab12b2570
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab12b2850
        public void StopCoroutine(){} // RVA: 0x7ffab12b28b0
        public void OnDisable(){} // RVA: 0x7ffab12b2a10
        public void OnDestroy(){} // RVA: 0x7ffab12b2e60
        public void OnEnable(){} // RVA: 0x7ffab12b3010
        public void get_useGUILayout(){} // RVA: 0x7ffab12b33f0
        public void set_useGUILayout(){} // RVA: 0x7ffab12b34a0
    }

    /// <summary>Originally: ÎÏÏÎÌÌÏÍÏÏÍÌÏÏÌÌÌÏÏÍÌÏÍ</summary>
    public class LifecycleComponent_BEBA : MonoBehaviour
    {
        public object _amount; // 0x336D5160, was: ÎÌÏÌÏÎÍÎÏÍÏÏÍÏÏÏÍÏÌÎÎÌÌ
        public object _enableWhenMinimized; // 0x336D5160
        public object _minimizeButton; // 0x336D5160
        public object f_840; // 0x336D5160, was: ÍÌÍÌÏÌÎÌÎÎÌÍÏÎÎÏÏÌÏÏÌÌÎ
        public object f_69D; // 0x17000011, was: ÎÌÌÍÌÏÍÌÎÍÎÎÍÎÏÍÍÏÌÌÍÎÏ

        // ── Original Methods ──
        public void RaiseCancellation(){} // RVA: 0x7ffab0cc88b0
        public void UpdateActive(){} // RVA: 0x7ffab0cc88f0
        public void Invoke(){} // RVA: 0x7ffab0cc9580
        public void InvokeRepeating(){} // RVA: 0x7ffaa8bf45b0
        public void CancelInvoke(){} // RVA: 0x7ffab0cc9bd0
        public void Awake(){} // RVA: 0x7ffab0cc9cb0
        public void OnDestroy(){} // RVA: 0x7ffaa8bf45b0
        public void StartCoroutine(){} // RVA: 0x7ffab0cc9d60
        public void FixedUpdate(){} // RVA: 0x7ffab0cc9da0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab0cca3f0
        // ── Binary Analysis Named ──
        public void GetShapes(){} // RVA: 0x7ffaa8bf45b0
        public void DoDOLocalRotate(){} // RVA: 0x7ffab0cc8f30
    }

    /// <summary>Originally: ÎÏÌÎÌÎÍÎÍÏÍÍÍÎÎÌÌÏÍÌÌÏÍ</summary>
    public class LifecycleComponent_C034 : MonoBehaviour
    {
        public object _endpoint; // 0x33725FC0, was: <ÏÌÍÏÌÎÍÌÍÍÌÍÏÌÍÍÍÎÎÌÏÍÎ>k__Ba

        // ── Original Methods ──
        public void RegisterOnDisconnected(){} // RVA: 0x7ffaa8933e90
        public void RaiseCancellation(){} // RVA: 0x7ffaa8ec3cd0
        public void IsInvoking(){} // RVA: 0x7ffaa8ec3d70
        public void CancelInvoke(){} // RVA: 0x7ffaa8933e90
        public void .ctor(){} // RVA: 0x7ffaa8ec3fd0
        public void Awake(){} // RVA: 0x7ffaa8ec4240
        public void OnDestroy(){} // RVA: 0x7ffaa89600c0
        public void StartCoroutine(){} // RVA: 0x7ffaa8ec4300
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa89600d0
        public void StopCoroutine(){} // RVA: 0x7ffaa8bfcc80
        public void LateUpdate(){} // RVA: 0x7ffaa8bfcc80
        public void Start(){} // RVA: 0x7ffaa8ec4560
        public void get_useGUILayout(){} // RVA: 0x7ffaa89600c0
        // ── Binary Analysis Named ──
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
        public void SetExecutionContextHelper(){} // RVA: 0x7ffaa89600d0
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void GetRealtime_8F6(){} // RVA: 0x7ffaa8ec4600
    }

    /// <summary>Originally: ÎÎÏÎÏÌÎÌÏÌÌÍÏÌÍÌÍÎÌÎÌÏÍ</summary>
    public class LifecycleComponent_C611 : MonoBehaviour
    {
        public object _ePathName; // 0x336D4030, was: ÏÍÎÍÍÏÌÌÎÎÌÏÎÎÎÍÏÍÏÌÍÏÎ
        public object f_401; // 0x336D4030, was: ÎÌÌÍÍÏÌÎÌÍÌÍÏÏÌÌÍÍÎÏÏÏÌ
        public object f_C04; // 0x338B76D0, was: ÌÌÏÎÎÏÌÍÍÏÌÎÏÏÎÏÎÎÏÏÎÎÎ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab1118430
        public void RaiseCancellation(){} // RVA: 0x7ffab1118470
        public void Start(){} // RVA: 0x7ffab1118bf0
        public void Invoke(){} // RVA: 0x7ffab1118f20
        public void OnDisable(){} // RVA: 0x7ffab1118fd0
        public void OnDestroy(){} // RVA: 0x7ffab1119210
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab1119810
        public void OnEnable(){} // RVA: 0x7ffab11198c0
        public void StopCoroutine(){} // RVA: 0x7ffab1119a10
        public void OnCollisionStay(){} // RVA: 0x7ffab1119b20
        public void StopAllCoroutines(){} // RVA: 0x7ffab1118430
        public void get_useGUILayout(){} // RVA: 0x7ffab1119bd0
        // ── Binary Analysis Named ──
        public void SetActive_984(){} // RVA: 0x7ffab1118500
        public void DoRange_12A(){} // RVA: 0x7ffab1119160
        public void GetGameObject_1CA(){} // RVA: 0x7ffab11195e0
        public void DoRange_07C(){} // RVA: 0x7ffab1119760
    }

    /// <summary>Originally: ÍÍÌÌÎÎÎÍÎÍÍÍÍÏÍÍÎÌÎÌÏÍÎ</summary>
    public class LifecycleComponent_CA35 : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab1356a30
        public void OnEnable(){} // RVA: 0x7ffab1356b20
        public void OnDestroy(){} // RVA: 0x7ffab1356b30
        public void CancelInvoke(){} // RVA: 0x7ffab1356c20
        public void Invoke(){} // RVA: 0x7ffab1356f60
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Start(){} // RVA: 0x7ffab1357050
        public void IsInvoking(){} // RVA: 0x7ffab1357140
        public void StartCoroutine(){} // RVA: 0x7ffab1357150
        public void OnApplicationQuit(){} // RVA: 0x7ffab1357240
        public void OnBecameVisible(){} // RVA: 0x7ffab1356b20
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab1357580
        public void StopCoroutine(){} // RVA: 0x7ffab1357670
    }

    /// <summary>Originally: ÏÏÎÎÌÍÏÏÍÍÏÌÍÌÍÌÌÎÍÍÎÎÎ</summary>
    public class LifecycleComponent_CCD4 : MonoBehaviour
    {
        public object _cancelProcessingButton; // 0x33737960
        public object _value; // 0x33737960, was: ÏÎÏÌÍÏÌÎÍÎÏÍÌÎÌÎÏÌÎÍÏÎÍ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab104aed0
        public void IsInvoking(){} // RVA: 0x7ffab104b170
        public void Invoke(){} // RVA: 0x7ffab104b730
        public void InvokeRepeating(){} // RVA: 0x7ffab104b8c0
        public void OnDestroy(){} // RVA: 0x7ffab104bab0
        public void OnApplicationPause(){} // RVA: 0x7ffab104be10
        public void OnEnable(){} // RVA: 0x7ffab104c000
        public void StartCoroutine(){} // RVA: 0x7ffab104c310
        public void OnBecameInvisible(){} // RVA: 0x7ffab104c4c0
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab104c4d0
        public void ComputeactiveSelf(){} // RVA: 0x7ffab104c6c0
        public void ComputeisActiveAndE(){} // RVA: 0x7ffab104c980
        public void StopCoroutine(){} // RVA: 0x7ffab104cbf0
        public void Start(){} // RVA: 0x7ffab104ceb0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void UpdateActive(){} // RVA: 0x7ffab104d090
        public void OnDisable(){} // RVA: 0x7ffab104d190
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffab104d490
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffab104d530
        public void InvokeDelayed(){} // RVA: 0x7ffab104d5d0
        // ── Binary Analysis Named ──
        public void SetActive_B9E(){} // RVA: 0x7ffab104b0c0
        public void DoFormatInt32(){} // RVA: 0x7ffab104b470
    }

    /// <summary>Originally: ÏÌÏÏÎÍÌÎÌÍÏÎÎÌÍÍÎÌÌÌÎÌÌ</summary>
    public class LifecycleComponent_CD20 : MonoBehaviour
    {
        public object _mePatternseseCalendarDTFI; // 0x33642A30, was: ÎÎÏÏÍÏÎÎÌÌÌÍÎÏÌÏÌÍÍÌÌÍÎ
        public object _flag; // 0x33642A30, was: ÎÏÌÌÎÎÏÏÍÎÏÎÎÌÍÎÏÎÌÏÎÍÌ
        public object _recents; // 0x335391F0

        // ── Original Methods ──
        public void get_hidden(){} // RVA: 0x7ffaa89e9d30
        public void Start(){} // RVA: 0x7ffab0ffb370
        public void IsInvoking(){} // RVA: 0x7ffaa86491d0
        public void ToSingle(){} // RVA: 0x7ffaa865e2d0
        public void Invoke(){} // RVA: 0x7ffaa8649280
        public void Updateenabled(){} // RVA: 0x7ffab0ffb810
        public void CancelInvoke(){} // RVA: 0x7ffab0ffbb40
        public void Computetransform(){} // RVA: 0x7ffab0ffbbe0
        public void ComputesizeDelta(){} // RVA: 0x7ffab0ffbdb0
        public void .ctor(){} // RVA: 0x7ffab0ffbff0
        // ── Binary Analysis Named ──
        public void GetTransform_718(){} // RVA: 0x7ffab0ffbf80
    }

    /// <summary>Originally: ÍÍÏÍÏÍÏÌÏÏÍÏÏÌÎÏÏÍÌÍÎÍÌ</summary>
    public class LifecycleComponent_CDA9 : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0cf99e0
        public void RaiseCancellation(){} // RVA: 0x7ffab0cf9a70
        public void IsInvoking(){} // RVA: 0x7ffab0cf9b00
        public void Awake(){} // RVA: 0x7ffab0cf9b90
        public void OnDestroy(){} // RVA: 0x7ffab0cf9c20
        public void InvokeRepeating(){} // RVA: 0x7ffab0cf9cb0
        public void UpdateActive(){} // RVA: 0x7ffab0cf9d40
        public void Start(){} // RVA: 0x7ffab0cfa200
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void SetActive_984(){} // RVA: 0x7ffab0cf9f10
        public void SetActive_E66(){} // RVA: 0x7ffab0cfa0e0
        public void SetActive_B21(){} // RVA: 0x7ffab0cfa170
    }

    /// <summary>Originally: ÏÌÎÏÏÍÎÎÏÌÍÍÌÎÌÎÍÏÎÎÍÍÍ</summary>
    public class LifecycleComponent_CDB7 : MonoBehaviour
    {
        public object _ePathName; // 0x336A7930, was: ÌÎÏÍÎÍÍÍÏÌÍÎÍÎÌÏÏÏÏÎÌÎÏ
        public object _buffer; // 0x336A7930, was: ÎÏÎÌÍÌÎÏÌÌÏÎÎÍÏÍÍÌÌÎÌÎÌ
        public object _buffer2; // 0x336A7930, was: ÎÏÏÏÎÌÌÏÎÌÌÏÎÌÏÎÍÍÌÎÍÏÍ
        public object subscriptionPricePerMonthText; // 0x336A7930
        public object f_401; // 0x336A7930, was: ÎÌÌÍÍÏÌÎÌÍÌÍÏÏÌÌÍÍÎÏÏÏÌ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab1195a50
        public void UpdateActive(){} // RVA: 0x7ffab1195d90
        public void IsInvoking(){} // RVA: 0x7ffab1195f60
        public void .ctor(){} // RVA: 0x7ffab1195f70
        public void Initialize(){} // RVA: 0x7ffab1195fc0
        public void InvokeRepeating(){} // RVA: 0x7ffab1196190
        public void ComputeactiveSelf(){} // RVA: 0x7ffab1196360
        public void StartCoroutine(){} // RVA: 0x7ffab1196780
        public void AccessactiveSelf(){} // RVA: 0x7ffab1196360
        public void OnDisable(){} // RVA: 0x7ffab11967a0
        public void StopCoroutine(){} // RVA: 0x7ffab1196a40
        public void OnEnable(){} // RVA: 0x7ffab1196a50
        public void get_useGUILayout(){} // RVA: 0x7ffab1196cf0
        public void Start(){} // RVA: 0x7ffab1197610
        public void Awake(){} // RVA: 0x7ffab11976a0
        public void StartCoroutineManaged(){} // RVA: 0x7ffab11979c0
        public void OnDestroy(){} // RVA: 0x7ffab1197ab0
        // ── Binary Analysis Named ──
        public void GetActiveSelf_454(){} // RVA: 0x7ffab11964c0
        public void DoAngleAxis_Injected_9F4(){} // RVA: 0x7ffab11965b0
        public void DoAngleAxis_Injected_31A(){} // RVA: 0x7ffab1196790
        public void DoAngleAxis_Injected_588(){} // RVA: 0x7ffab1196950
        public void DoAngleAxis_Injected_68B(){} // RVA: 0x7ffab1197030
        public void DoAngleAxis_Injected_B9E(){} // RVA: 0x7ffab1197040
        public void DoAngleAxis_Injected_D10(){} // RVA: 0x7ffab11971a0
        public void DoAngleAxis_Injected_6ED(){} // RVA: 0x7ffab1197200
        public void DoAngleAxis_Injected_E1D(){} // RVA: 0x7ffab11973d0
        public void DoAngleAxis_Injected_3A7(){} // RVA: 0x7ffab11975a0
    }

    /// <summary>Originally: ÍÏÎÏÎÎÍÏÎÌÌÏÎÎÌÎÎÌÌÎÎÍÌ</summary>
    public class LifecycleComponent_D20F : MonoBehaviour
    {
        public object f_2E3; // 0x336841B0, was: ÏÌÍÌÌÏÌÎÎÏÍÌÍÎÍÎÍÎÏÎÌÍÍ
        public object f_FC3; // 0x336841B0, was: ÍÍÌÍÏÏÍÌÍÍÍÏÍÎÏÍÌÌÏÍÌÌÌ
        public object f_7BA; // 0x336841B0, was: ÎÍÏÏÌÌÌÏÌÏÍÌÎÍÍÌÏÌÏÍÎÌÏ
        public object f_CE8; // 0x336841B0, was: ÌÌÏÏÎÍÍÍÌÏÍÍÏÎÍÎÍÏÌÎÍÏÌ
        public object f_247; // 0x336841B0, was: ÌÍÏÍÏÍÏÎÍÎÌÌÎÏÍÍÏÍÎÌÍÎÏ
        public object f_801; // 0x336841B0, was: ÎÏÎÎÍÏÏÍÎÎÎÍÌÌÏÎÌÏÎÏÌÎÍ
        public object f_2E7; // 0x336841B0, was: ÎÎÏÏÌÏÏÏÌÍÍÎÏÍÎÏÎÎÎÍÍÏÍ
        public object f_2A4; // 0x336841B0, was: ÌÎÍÍÍÎÌÏÎÍÎÎÎÍÎÍÎÍÏÌÍÌÍ
        public object f_835; // 0x336841B0, was: ÍÍÍÍÌÎÎÍÌÏÍÏÎÍÍÏÏÍÎÏÎÍÌ
        public object f_532; // 0x336841B0, was: ÍÏÏÎÍÎÌÎÏÏÎÎÌÍÎÌÍÌÏÏÏÏÍ
        public object _matrix; // 0x336841B0, was: ÏÎÏÍÏÍÌÏÎÎÍÍÎÏÎÍÏÏÎÏÎÌÍ
        public object _matrix2; // 0x336841B0, was: ÍÍÌÌÍÍÌÌÌÍÌÎÌÍÎÌÏÎÌÏÌÎÎ
        public object f_F3C; // 0x33619530, was: ÌÌÎÌÏÏÍÍÏÎÏÌÏÌÏÍÍÏÎÍÍÏÌ
        public object _touchButton; // 0x33538030
        public object f_E05; // 0x3385E1D0, was: ÌÍÏÏÍÌÏÌÍÍÎÍÍÍÎÏÍÎÌÍÍÍÌ
        public object Yk;
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9c90fa0
        public void Invoke(){} // RVA: 0x7ffaa9c91a00
        public void Awake(){} // RVA: 0x7ffaa9c91f70
        public void Updateenabled(){} // RVA: 0x7ffaa9c92460
        public void StartCoroutine(){} // RVA: 0x7ffaa9c92530
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa9c929c0
        // ── Binary Analysis Named ──
        public void GetGameObject_74B(){} // RVA: 0x7ffaa9c90b40
        public void GetGameObject_CF4(){} // RVA: 0x7ffaa9c91100
        public void GetDeltaTime_3A5(){} // RVA: 0x7ffaa9c915a0
        public void GetTransform_A72(){} // RVA: 0x7ffaa9c91ab0
        public void DoInternal_FromEulerRad_Injected_C0B(){} // RVA: 0x7ffaa9c92460
        public void DoInternal_FromEulerRad_Injected_413(){} // RVA: 0x7ffaa9c925e0
        public void Doop_Equality(){} // RVA: 0x7ffaa9c93290
        public void GetTransform_76F(){} // RVA: 0x7ffaa9c93670
        public void DoLerp_Injected_F15(){} // RVA: 0x7ffaa9c93b20
    }

    /// <summary>Originally: ÏÌÌÎÌÍÍÏÎÏÌÍÍÎÍÍÌÎÍÌÏÍÍ</summary>
    public class LifecycleComponent_D9A2 : MonoBehaviour
    {
        public object _collapsedIconTexture; // 0x336A7AC0
        public object _uRAwoDigitYearMax; // 0x336A7AC0, was: ÎÌÌÌÌÍÏÏÍÌÌÏÎÎÍÎÌÏÌÏÌÌÏ
        public object _blockedUsers; // 0x33A4E080

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab0eba270
        public void VRCSetAvatarMainIK(){} // RVA: 0x7ffaa89ec8f0
        public void Invoke(){} // RVA: 0x7ffab0eba510
        public void InvokeRepeating(){} // RVA: 0x7ffab0eba510
        public void CancelInvoke(){} // RVA: 0x7ffab0eba540
        public void IsInvoking(){} // RVA: 0x7ffaa89ec8f0
        public void StartCoroutine(){} // RVA: 0x7ffab0eba7c0
        public void StartWithHighestBandwidth(){} // RVA: 0x7ffaa89ec8e0
        public void Awake(){} // RVA: 0x7ffab0ebaa00
        public void OnDestroy(){} // RVA: 0x7ffab0ebaab0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab0ebaad0
        // ── Binary Analysis Named ──
        public void SetActive_F6B(){} // RVA: 0x7ffab0eba360
        public void SetActive_A6C(){} // RVA: 0x7ffab0eba4f0
        public void SetActive_2C1(){} // RVA: 0x7ffab0eba510
        public void SetActive_8D1(){} // RVA: 0x7ffab0eba630
        public void GetGameObject_F58(){} // RVA: 0x7ffab0eba840
        public void GetGameObject_55C(){} // RVA: 0x7ffab0eba860
        public void GetGameObject_404(){} // RVA: 0x7ffab0eba950
    }

    /// <summary>Originally: ÎÎÌÎÏÏÏÌÎÌÍÏÏÎÍÏÌÏÌÎÏÏÎ</summary>
    public class LifecycleComponent_EB6D : MonoBehaviour
    {
        public object _triggerInteraction; // 0x3365A940
        public object _color; // 0x3365A940, was: ÍÍÏÍÍÌÏÏÏÎÏÏÍÍÌÏÌÍÏÏÍÎÍ
        public object _curveRenderer; // 0x3365A940
        public object _hitColor; // 0x3365A940
        public object _vector; // 0x3365A940, was: ÎÏÍÎÏÍÌÎÎÎÍÎÎÍÎÍÏÎÏÍÏÏÎ
        public object _vector2; // 0x33941F68, was: ÎÍÍÌÏÏÌÏÌÌÎÎÌÎÎÏÍÍÌÌÎÌÎ

        // ── Original Methods ──
        public void CancelInvoke(){} // RVA: 0x7ffaa98f1b50
        public void Awake(){} // RVA: 0x7ffaa98f21f0
        public void Computeenabled(){} // RVA: 0x7ffaa8998de0
        public void Updateenabled(){} // RVA: 0x7ffaa98f2390
        public void StartCoroutine(){} // RVA: 0x7ffaa98f2680
        public void StartCoroutine_Auto(){} // RVA: 0x7ffaa98f2970
        public void StopCoroutine(){} // RVA: 0x7ffaa98f3170
        public void print(){} // RVA: 0x7ffaa98f4000
        public void .ctor(){} // RVA: 0x7ffaa98f42f0
        public void UpdatePositions(){} // RVA: 0x7ffaa98f4380
        public void Computetransform(){} // RVA: 0x7ffaa98f4740
        // ── Binary Analysis Named ──
        public void DoDrawWireSphere_Injected_B5B(){} // RVA: 0x7ffaa98f1060
        public void DoInverseTransformPoint_Injected_CDA(){} // RVA: 0x7ffaa98f1800
        public void DoInverseTransformPoint_Injected_106(){} // RVA: 0x7ffaa98f1900
        public void DoAngleAxis_Injected_0F3(){} // RVA: 0x7ffaa98f1c50
        public void GetTransform_C5D(){} // RVA: 0x7ffaa98f1d50
        public void GetTransform_D92(){} // RVA: 0x7ffaa98f1e50
        public void GetTransform_A87(){} // RVA: 0x7ffaa98f29d0
        public void DoCreatePrimitive_07C(){} // RVA: 0x7ffaa98f3300
        public void DoCreatePrimitive_98A(){} // RVA: 0x7ffaa98f3360
        public void GetTransform_CEF(){} // RVA: 0x7ffaa98f3500
        public void GetTransform_257(){} // RVA: 0x7ffaa98f3db0
        public void GetTransform_17B(){} // RVA: 0x7ffaa98f2970
    }

    /// <summary>Originally: ÏÍÏÎÏÌÏÏÌÏÍÌÌÌÎÌÍÍÍÎÏÍÍ</summary>
    public class LifecycleComponent_EED7 : MonoBehaviour
    {
        public object _flag; // 0x336F6F60, was: ÎÏÌÏÎÌÎÌÌÎÍÏÌÌÏÌÌÎÎÎÍÏÎ

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffab106faf0
        public void RaiseCancellation(){} // RVA: 0x7ffab106fc00
        public void IsInvoking(){} // RVA: 0x7ffab106fd10
        public void CancelInvoke(){} // RVA: 0x7ffab106fe20
        public void Invoke(){} // RVA: 0x7ffab106fe60
        public void InvokeRepeating(){} // RVA: 0x7ffab106fe70
        public void ProcessInternalFlag(){} // RVA: 0x7ffab106ff80
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab106fe60
        public void StartCoroutine(){} // RVA: 0x7ffab10700d0
        public void Awake(){} // RVA: 0x7ffab1070310
        // ── Binary Analysis Named ──
        public void SetActive_F50(){} // RVA: 0x7ffab1070200
        public void SetActive_C8F(){} // RVA: 0x7ffab1070460
    }

    /// <summary>Originally: ÎÎÌÌÍÍÍÎÌÏÍÍÌÏÏÏÏÍÏÎÍÍÏ</summary>
    public class LifecycleComponent_F183 : MonoBehaviour
    {
        public object _text; // 0x3365A7C0, was: ÎÏÎÌÏÍÌÎÎÏÍÍÏÍÎÍÍÌÍÍÎÍÍ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void Initialize(){} // RVA: 0x7ffab0cc2ac0
        public void CancelInvoke(){} // RVA: 0x7ffab112e980
        public void Awake(){} // RVA: 0x7ffab112ea20
        public void OnDestroy(){} // RVA: 0x7ffab0cc2ac0
        public void Start(){} // RVA: 0x7ffab112eaa0
        // ── Binary Analysis Named ──
        public void GetGameObject_2F3(){} // RVA: 0x7ffab112e7a0
        public void GetGameObject_106(){} // RVA: 0x7ffab112e840
        public void GetGameObject_D2B(){} // RVA: 0x7ffab112e8e0
        public void SetStoreCallback(){} // RVA: 0x7ffaa8960890
        public void GetGameObject_C84(){} // RVA: 0x7ffab112eb50
    }

    /// <summary>Originally: ÎÌÍÍÏÏÏÍÎÌÌÏÍÍÏÏÎÎÍÌÍÎÍ</summary>
    public class LifecycleComponent_F6ED : MonoBehaviour
    {
        public object _members; // 0x3372EBF0
        public object _canvas; // 0x3372EBF0
        public object f_7D3; // 0x3372EBF0, was: ÏÎÎÍÏÍÎÏÍÍÍÌÍÌÍÌÍÎÌÎÏÌÌ
        public object _mePatternseseCalendarDTFI; // 0x3372EBF0, was: ÍÍÎÌÌÎÍÌÎÎÌÍÌÍÎÎÏÍÌÎÏÍÌ
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void Updatebottom(){} // RVA: 0x7ffab10e29d0
        public void RaiseCancellation(){} // RVA: 0x7ffab10e3210
        public void .ctor(){} // RVA: 0x7ffab10e3b80
        public void Updateenabled(){} // RVA: 0x7ffab10e3df0
        public void CancelInvoke(){} // RVA: 0x7ffab10e3eb0
        public void StartCoroutine(){} // RVA: 0x7ffab10e41b0
        public void InitializeComponentResources(){} // RVA: 0x7ffab10e4290
        public void StartCoroutine_Auto(){} // RVA: 0x7ffab10e44d0
        public void StopCoroutine(){} // RVA: 0x7ffab10e47d0
        public void Awake(){} // RVA: 0x7ffab10e4830
        public void Start(){} // RVA: 0x7ffab10e5080
        // ── Binary Analysis Named ──
        public void GetGameObject_1C1(){} // RVA: 0x7ffab10e3aa0
        public void GetGameObject_B54(){} // RVA: 0x7ffab10e3d30
        public void GetGameObject_8C4(){} // RVA: 0x7ffab10e40f0
        public void SetActive_686(){} // RVA: 0x7ffab10e4150
    }

    /// <summary>Originally: ÍÎÌÏÌÎÎÏÍÏÍÎÏÎÎÌÍÍÏÌÏÌÍ</summary>
    public class LifecycleComponent_F7EC : MonoBehaviour
    {
        public object _ePathNamehInputPathName; // 0x33642180, was: ÌÎÍÎÌÎÏÍÌÎÏÎÎÏÍÌÌÎÍÌÍÏÍ
        public object _amount; // 0x33642180, was: ÌÍÎÌÎÌÍÍÌÏÏÌÎÎÏÏÏÌÎÏÌÌÏ
        public object _bool; // 0x33642180, was: ÎÍÌÏÍÌÎÎÎÌÎÌÎÌÎÌÍÌÎÌÏÏÌ
        public object targetTransform; // 0x33589310

        // ── Original Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7ffaa8b02ff0
        public void RaiseCancellation(){} // RVA: 0x7ffaa8b03100
        public void Start(){} // RVA: 0x7ffaa8b03170
        public void Invoke(){} // RVA: 0x7ffaa8b031a0
        public void Dispose(){} // RVA: 0x7ffaa8b031f0
        public void Cleanup(){} // RVA: 0x7ffaa8b03210
        public void IsInvoking(){} // RVA: 0x7ffaa8b03260
        public void .ctor(){} // RVA: 0x7ffaa8b03280
        public void UpdateActive(){} // RVA: 0x7ffaa8b03590
        public void StartCoroutine(){} // RVA: 0x7ffaa8b03780
        public void Updateenabled(){} // RVA: 0x7ffaa8b037a0
        public void OnDestroy(){} // RVA: 0x7ffaa8b03910
        public void StopCoroutine(){} // RVA: 0x7ffaa8b03980
        public void OnCollisionExit(){} // RVA: 0x7ffaa89af740
        public void Dispose_sub(){} // RVA: 0x7ffaa8b04250
        public void get_useGUILayout(){} // RVA: 0x7ffaa8b04900
        public void set_useGUILayout(){} // RVA: 0x7ffaa8b04ae0
        public void print(){} // RVA: 0x7ffaa8b04c40
        public void Internal_CancelInvokeAll(){} // RVA: 0x7ffaa8b04df0
        public void Internal_IsInvokingAll(){} // RVA: 0x7ffaa8b04e40
        public void Computetransform(){} // RVA: 0x7ffaa8b04ff0
        public void CancelInvoke(){} // RVA: 0x7ffaa8932320
        public void ApplyTransformCalculation(){} // RVA: 0x7ffaa8b051b0
        // ── Binary Analysis Named ──
        public void GetInternalMethodName(){} // RVA: 0x7ffaa89af740
    }

}