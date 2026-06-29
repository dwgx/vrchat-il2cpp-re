// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI
// Classes: 3
// Methods: 59

namespace VRC.UI
{
    /// <summary>Originally: ÏÏÍÏÍÍÍÌÏÌÍÏÏÎÍÎÏÌÍÍÎÍÍ</summary>
    public class ButtonIndicatorBaseImpl_304B : ButtonIndicatorBase_5B5C
    {
        public object f_F1D;
        public object f_812;
        public object f_C75;
        public object f_A63;
        public object f_B8B;
        public object f_A8C;
        public object f_C54;
        public object f_049;

        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x99B9AF0
        public void OnPointerExit(){} // RVA: 0x99B9B90
        public void OnPointerDown(){} // RVA: 0x99B9F00
        public void OnPointerUp(){} // RVA: 0x99BA1F0
        public void OnPointerClick(){} // RVA: 0x99BA560
        public void Start(){} // RVA: 0x99BA8D0
        public void OnSelect(){} // RVA: 0x99BAA00
        public void OnDeselect(){} // RVA: 0x99BAA70
        public void OnSubmit(){} // RVA: 0x99BADE0
        public void OnCancel(){} // RVA: 0x99BAF10
        public void OnEnable(){} // RVA: 0x99BB230
        public void OnDisable(){} // RVA: 0x99BB2A0
        public void .ctor(){} // RVA: 0x99BB340
        public void Initialize(){} // RVA: 0x99BB4E0
    }

    /// <summary>Originally: ÌÏÏÌÌÏÍÎÏÏÌÎÏÍÏÍÍÍÎÌÏÍÌ</summary>
    public class ButtonIndicatorBaseSibling_E49B : MonoBehaviour
    {
        public object _m_CancellationTokenSource;
        public object f_ABD;
        public object _groupsListBinding;
        public object _groupCell;
        public object _searchButton;
        public object f_D55;
        public object f_B58;
        public object f_5AC;
        public object f_C1B;
        public object f_5A3;
        public object f_AE2;
        public object f_6AE;
        public object f_73B;
        public object f_F4E;
        public object f_19A;
        public object f_C73;
        public object f_4C5;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0xBE58B0
        public void RaiseCancellation(){} // RVA: 0xB70160
        public void IsInvoking(){} // RVA: 0x99C6B30
        public void CancelInvoke(){} // RVA: 0xBC1B30
        public void Invoke(){} // RVA: 0x99C6B80
        public void InvokeRepeating(){} // RVA: 0xBE58B0
        public void StartCoroutine(){} // RVA: 0x99C6C90
        public void StartCoroutine_Auto(){} // RVA: 0xD05CA0
        public void StopCoroutine(){} // RVA: 0x99C6DA0
        public void StopAllCoroutines(){} // RVA: 0x99C6F40
        public void get_useGUILayout(){} // RVA: 0x99C71C0
        public void set_useGUILayout(){} // RVA: 0x99C7250
        public void get_didStart(){} // RVA: 0x99C7590
        public void get_didAwake(){} // RVA: 0x114DE40
        public void print(){} // RVA: 0xE3F480
        public void Internal_CancelInvokeAll(){} // RVA: 0x99C7730
        public void .ctor(){} // RVA: 0x99C7840
        public void Initialize(){} // RVA: 0x5C8BB10
        public void IsObjectMonoBehaviour(){} // RVA: 0x99C7920
        public void StartCoroutineManaged(){} // RVA: 0x99C7A10
        public void StartCoroutineManaged2(){} // RVA: 0x99C7CA0
        public void StopCoroutineManaged(){} // RVA: 0x99C7D30
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0xBFDA40
        public void GetScriptClassName(){} // RVA: 0x99C7E40
        public void OnCancellationTokenCreated(){} // RVA: 0xE3F480
        public void OnPointerEnter(){} // RVA: 0x99C7F40
        public void StopCoroutine_Injected(){} // RVA: 0x99C8030
        public void StopAllCoroutines_Injected(){} // RVA: 0x99C83F0
    }

    /// <summary>Originally: ÏÌÍÍÍÌÌÌÍÏÌÏÎÎÎÌÏÎÌÍÏÌÍ</summary>
    public class ButtonIndicatorBase_5B5C : MonoBehaviour
    {
        public object _allowRenaming;
        public object _showSortingDropddown;
        public object _showCellSizeToggle;
        public object f_D55;
        public object f_B58;
        public object f_C1B;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0xC38360
        public void RaiseCancellation(){} // RVA: 0xB70160
        public void IsInvoking(){} // RVA: 0x114DE40
        public void CancelInvoke(){} // RVA: 0xB708C0
        public void Invoke(){} // RVA: 0xF45EE0
        public void InvokeRepeating(){} // RVA: 0x246F130
        public void StartCoroutine(){} // RVA: 0xB70160
        public void StartCoroutine_Auto(){} // RVA: 0x246F130
        public void StopCoroutine(){} // RVA: 0xB708C0
        public void StopAllCoroutines(){} // RVA: 0x114DE40
        public void get_useGUILayout(){} // RVA: 0xD33E60
        public void set_useGUILayout(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0x9E5BEA0
        public void Initialize(){} // RVA: 0xB44DC0
        public void print(){} // RVA: 0xD09D70
        public void Internal_CancelInvokeAll(){} // RVA: 0xD09D70
        public void Internal_IsInvokingAll(){} // RVA: 0xD05CA0
    }

}