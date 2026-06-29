// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Transform
// Classes: 9
// Methods: 137

namespace VRC.Core.Transform
{
    /// <summary>Originally: ÎÎÎÏÌÏÎÎÍÎÏÍÌÌÍÍÌÏÏÌÌÎÌ</summary>
    public class OrientationAdaptiveTransform : MonoBehaviour
    {
        public object landscapePos;
        public object landscapeScale;
        public object portraitPos;
        public object portraitScale;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    /// <summary>Originally: ÏÎÌÍÌÏÏÏÎÌÍÎÍÌÌÍÎÏÏÌÎÌÏ</summary>
    public class RectTransformDimensionsCh_3B42 : UIBehaviour
    {
        public object f_EF7;
        public object f_FB1;
        public object f_45F;
        public object f_CF0;

        // ── Methods ──
        public void Awake(){} // RVA: 0x9F0B4F0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x9F0B610
        public void Start(){} // RVA: 0x9F0B620
        public void .ctor(){} // RVA: 0x9F0B640
        public void OnEnable(){} // RVA: 0x9F0B690
        public void IsActive(){} // RVA: 0x9F0B7D0
        public void Update(){} // RVA: 0x9F0B620
        public void OnBeforeTransformParentChanged(){} // RVA: 0x9F0BAB0
        public void OnTransformParentChanged(){} // RVA: 0x9F0BC40
        public void OnDisable(){} // RVA: 0x9F0BC60
        public void OnCanvasGroupChanged(){} // RVA: 0x9F0BDA0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x9F0BF30
        public void IsDestroyed(){} // RVA: 0x9F0C210
        public void OnCollisionStay(){} // RVA: 0x9F0C210
        public void OnCollisionExit(){} // RVA: 0x9F0C230
        public void OnTriggerEnter(){} // RVA: 0x9F0B620
    }

    /// <summary>Originally: ÏÍÍÌÎÌÌÌÌÍÍÌÎÎÏÍÍÎÍÍÍÎÎ</summary>
    public class RectTransformDimensionsChparent_77D7 : ContentSizeFitter
    {
        public object _parent;
        public object _root;
        public object _this;

        // ── Methods ──
        public void get_horizontalFit(){} // RVA: 0x9B38160
        public void set_horizontalFit(){} // RVA: 0x9B38160
        public void OnRectTransformDimensionsChange(){} // RVA: 0x9B38190
        public void set_verticalFit(){} // RVA: 0x9B38160
        public void get_rectTransform(){} // RVA: 0x9B38160
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x9B38160
        public void OnDisable(){} // RVA: 0x9B38160
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x9B38160
        // ── Unresolved (hash) ──
        public void m_707(){} // RVA: 0x9B38160
    }

    /// <summary>Originally: ÍÏÏÍÌÏÌÎÏÍÌÎÌÏÍÌÌÎÏÏÍÏÎ</summary>
    public class SwapTransform_F66F : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0xB43310
        public void RaiseCancellation(){} // RVA: 0xB43310
        public void IsInvoking(){} // RVA: 0xB43310
        public void CancelInvoke(){} // RVA: 0xB43310
        public void Invoke(){} // RVA: 0xB43310
        public void InvokeRepeating(){} // RVA: 0xB43310
        public void StartCoroutine(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
        public void SwapTransform(){} // RVA: 0xB43310
        public void StopAllCoroutines(){} // RVA: 0xB43310
    }

    /// <summary>Originally: ÌÍÌÎÏÌÏÎÌÏÎÏÏÌÌÎÌÏÏÏÏÍÎ</summary>
    public class TransformChildrenChangedSetLayoutHorizonHandler_0D18 : MonoBehaviour
    {
        public object _m_CancellationTokenSource;
        public object f_7C7;
        public object f_F85;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0xF15890
        public void SetLayoutVertical(){} // RVA: 0x101EE20
        public void IsInvoking(){} // RVA: 0x7ADB170
        public void CancelInvoke(){} // RVA: 0x101EE20
        public void SetLayoutHorizontal(){} // RVA: 0xF15890
        public void InvokeRepeating(){} // RVA: 0x7ADB170
        public void StartCoroutine(){} // RVA: 0x7ADB170
        public void .ctor(){} // RVA: 0xB43D60
        public void OnTransformChildrenChanged(){} // RVA: 0x7ADB170
        public void StopAllCoroutines(){} // RVA: 0x101EE20
        public void get_useGUILayout(){} // RVA: 0x101EE20
    }

    /// <summary>Originally: ÍÏÍÍÌÌÍÏÍÎÏÏÍÍÍÎÎÎÏÎÍÌÍ</summary>
    public class TransformParentChangedresizeLayoutElemenHandler_8FD6 : MonoBehaviour
    {
        public object _resizeLayoutElement;
        public object f_6B5;
        public object f_900;
        public object f_9E6;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x9AE3A60
        public void Start(){} // RVA: 0x9AE3B70
        public void IsInvoking(){} // RVA: 0x9AE3D70
        public void CancelInvoke(){} // RVA: 0x9AE41C0
        public void Invoke(){} // RVA: 0x9AE43C0
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x9AE4810
        public void OnTransformParentChanged(){} // RVA: 0x9AE49E0
        public void StopCoroutine(){} // RVA: 0x9AE4AF0
        public void StopAllCoroutines(){} // RVA: 0x9AE4C00
        public void Awake(){} // RVA: 0x9AE4DE0
        public void OnDestroy(){} // RVA: 0x9AE4FB0
        public void get_didStart(){} // RVA: 0x9AE5190
    }

    /// <summary>Originally: ÍÎÎÎÍÌÏÎÍÍÍÍÌÏÏÎÍÌÍÏÍÎÎ</summary>
    public class backgroundTransformlineComponent_08C9 : MonoBehaviour
    {
        public object _m_CancellationTokenSource;
        public object f_68F;
        public object f_C23;
        public object f_3FE;
        public object f_ADC;
        public object f_601;
        public object f_ADC;
        public object f_8A2;
        public object f_714;
        public object f_575;
        public object f_D81;
        public object backgroundTransform;
        public object line;
        public object mask;
        public object f_9A2;
        public object f_6D9;
        public object f_8AA;
        public object f_8B5;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0xD1FBA0
        public void RaiseCancellation(){} // RVA: 0xD20320
        public void OnDisable(){} // RVA: 0xD20530
        public void CancelInvoke(){} // RVA: 0xD20750
        public void Invoke(){} // RVA: 0xD20A30
        public void InvokeRepeating(){} // RVA: 0xD20A40
        public void StartCoroutine(){} // RVA: 0xD20C40
        public void StartCoroutine_Auto(){} // RVA: 0xD20E60
        public void Update(){} // RVA: 0xD21080
        public void StopAllCoroutines(){} // RVA: 0xD21170
        public void get_useGUILayout(){} // RVA: 0xD21320
        public void set_useGUILayout(){} // RVA: 0xD21520
        public void get_didStart(){} // RVA: 0xD21530
        public void .ctor(){} // RVA: 0xD21730
        public void Initialize(){} // RVA: 0xD217A0
        public void Internal_CancelInvokeAll(){} // RVA: 0xD219A0
        public void Internal_IsInvokingAll(){} // RVA: 0xD20750
    }

    /// <summary>Originally: ÎÏÍÎÌÏÏÎÌÍÏÎÏÎÎÏÌÍÌÌÏÍÌ</summary>
    public class cameraTransform_DA62 : ControllerRightBase_0185
    {
        public object f_975;
        public object _cameraTransform;
        public object f_EEA;
        public object f_39D;
        public object f_C0B;
        public object f_04E;
        public object f_E3C;
        public object f_153;

        // ── Methods ──
        public void Update(){} // RVA: 0x1E91C60
        public void .ctor(){} // RVA: 0x1E92020
        public void Initialize(){} // RVA: 0x1E92070
        public void Start(){} // RVA: 0x1E921E0
        public void Awake(){} // RVA: 0x1E929D0
        public void OnDestroy(){} // RVA: 0x1E92A60
        // ── 27 unresolved (hash) ──
        public void m_15E(){} // RVA: 0xB43310
        public void m_493(){} // RVA: 0xDAC980
        public void m_A84(){} // RVA: 0x1E91BF0
        public void m_4B4(){} // RVA: 0x1E76420
        public void m_739(){} // RVA: 0x1DF7CC0
        // ... 22 more unresolved methods
    }

    /// <summary>Originally: ÏÏÎÏÎÎÌÏÍÏÏÍÍÏÌÌÌÌÌÌÎÎÎ</summary>
    public class contentTransformToRebuildsubscriptionEleComponent_AC67 : MonoBehaviour
    {
        public object _contentTransformToRebuild;
        public object _activeFoldout;
        public object _expiredFoldout;
        public object _activeSubscriptions;
        public object _expiredSubscriptions;
        public object _expiredScroll;
        public object _subscriptionElementPrefab;
        public object sortActiveDropdown;
        public object sortExpiredDropdown;
        public object _canvas;
        public object _raycaster;
        public object f_23A;
        public object f_529;
        public object f_54E;
        public object f_E18;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x984CF60
        public void OnDisable(){} // RVA: 0x984D070
        public void Start(){} // RVA: 0x984D080
        public void .ctor(){} // RVA: 0x984DFE0
        public void Initialize(){} // RVA: 0x984E190
        public void InvokeRepeating(){} // RVA: 0x984E2A0
        public void StartCoroutine(){} // RVA: 0xBE58B0
        public void StartCoroutine_Auto(){} // RVA: 0x984D070
        public void StopCoroutine(){} // RVA: 0xBE58B0
        public void StopAllCoroutines(){} // RVA: 0x984E460
        public void get_useGUILayout(){} // RVA: 0x984D070
        public void set_useGUILayout(){} // RVA: 0x984E500
        public void get_didStart(){} // RVA: 0x984E510
        public void Awake(){} // RVA: 0x984E620
        public void OnDestroy(){} // RVA: 0x984E700
        public void Internal_CancelInvokeAll(){} // RVA: 0x984E740
        public void Internal_IsInvokingAll(){} // RVA: 0x984D070
        public void InvokeDelayed(){} // RVA: 0x984E790
        public void IsObjectMonoBehaviour(){} // RVA: 0x984E870
        public void StartCoroutineManaged(){} // RVA: 0x984EB00
        public void StartCoroutineManaged2(){} // RVA: 0x984D070
        public void StopCoroutineManaged(){} // RVA: 0x984ED30
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x984D070
        public void GetScriptClassName(){} // RVA: 0x984EE40
        public void OnCancellationTokenCreated(){} // RVA: 0x984F0F0
        public void OnCollisionEnter(){} // RVA: 0x984F3A0
    }

}