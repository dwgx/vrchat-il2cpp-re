// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI
// Classes: 6
// Methods: 37

namespace VRC.UI
{
    /// <summary>Originally: ÏÎÎÎÏÎÎÎÌÎÏÌÍÌÏÏÌÌÎÎÍÍÌ</summary>
    public class IPageEnumerator_D7D2_D7D2 : Object
    {
        public int System.Collections.Generic.IEnumerator<VRC.UI.Shared.IPage>.Current; // 0x10
        public ÍÍÎÍÏÌÌÍÌÎÌÏÌÍÌÎÌÌÏÎÌÍÍ System.Collections.IEnumerator.Current; // 0x18
        public int ÌÍÎÎÎÏÍÌÍÌÏÎÌÎÌÍÌÍÍÏÌÌÌ; // 0x20
        public ÏÏÌÏÎÏÏÎÏÌÌÌÌÍÍÌÏÏÍÌÎÏÏ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public ÏÏÏÏÌÍÏÌÎÎÏÏÏÌÌÍÏÌÍÌÌÍÍ ÍÎÏÍÌÍÌÎÎÍÌÏÏÌÍÎÏÍÎÏÌÏÍ; // 0x30
        public ÏÏÏÏÌÍÏÌÎÎÏÏÏÌÌÍÏÌÍÌÌÍÍ ÌÍÍÎÎÌÍÍÌÌÍÍÏÌÍÌÏÌÎÌÍÎÍ; // 0x38
        public System.Collections.Generic.IEnumerator`1<ÌÍÍÍÏÎÏÎÏÍÌÌÏÍÌÏÎÏÎÍÏÍÏ> ÍÍÎÏÎÍÍÌÌÍÍÌÍÎÎÍÌÎÌÏÎÌÏ; // 0x40

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFACB78A120
        public void System.Collections.Generic.IEnumerable<VRC.UI.Shared.IPage>.GetEnumerator(){} // RVA: 0x7FFACB78A680
        public void GetEnumerator(){} // RVA: 0x7FFACB78A7D0
        public void System.Collections.Generic.IEnumerator<VRC.UI.Shared.IPage>.get_Current(){} // RVA: 0x7FFAC2F247C0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFACB78AD10
        public void .ctor(){} // RVA: 0x7FFAC327C740
        public void Initialize(){} // RVA: 0x7FFACB78AD70
        public void set_name(){} // RVA: 0x7FFAC2F247C0
        public void Instantiate(){} // RVA: 0x7FFACB78AEC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACB78A680
        public void get_Current(){} // RVA: 0x7FFAC2F247C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFACB78AF80
        public void Equals(){} // RVA: 0x7FFAC2F247C0
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFACB78AFC0
    }

    public class ImageEx : Image
    {
        // ── Methods ──
        public void OnPopulateMesh(){} // RVA: 0x7FFACB232BD0
        public void .ctor(){} // RVA: 0x7FFACB232FB0
        public void Raycast(){} // RVA: 0x7FFACB233040
    }

    /// <summary>Originally: ÍÏÍÌÎÍÌÌÎÏÏÍÍÎÌÎÎÍÍÏÎÍÏ</summary>
    public class InitializePotentialDragPointerDownHandlerImpl_18B6_18B6 : InitializePotentialDragPointerDownHandler_518E_518E
    {
        public ÎÍÏÍÌÍÏÍÍÌÌÎÏÎÎÏÎÍÌÍÎÍÎ colorPicker; // 0x28
        public UnityEngine.RectTransform hueRect; // 0x30

        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFACB9A3A20
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÎÏÍÌÌÏÍÍÍÍÍÏÎÍÍÍÌÍÌÍÏÌÌ</summary>
    public class InitializePotentialDragPointerDownHandlerImpl_2DD5_2DD5 : InitializePotentialDragPointerDownHandler_518E_518E
    {
        public ÎÍÏÎÌÍÏÎÏÍÏÍÌÏÍÏÏÏÌÎÌÌÏ colorPicker; // 0x28
        public UnityEngine.RectTransform colorPickerRectTransform; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Handle(){} // RVA: 0x7FFACB9A3940
    }

    /// <summary>Originally: ÏÍÎÍÏÏÍÌÌÏÎÌÎÎÏÏÌÍÎÎÎÌÎ</summary>
    public class InitializePotentialDragPointerDownHandlerImpl_4062_4062 : InitializePotentialDragPointerDownHandler_518E_518E
    {
        public ÎÍÏÍÌÍÏÍÍÌÌÎÏÎÎÏÎÍÌÍÎÍÎ colorPicker; // 0x28
        public UnityEngine.RectTransform saturationValueRect; // 0x30

        // ── Methods ──
        public void Handle(){} // RVA: 0x7FFACB9A3B50
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    /// <summary>Originally: ÏÍÎÏÌÍÎÍÍÎÏÎÌÎÏÎÌÍÎÌÎÍÌ</summary>
    public class InitializePotentialDragPointerDownHandler_518E_518E : MonoBehaviour
    {
        public UnityEngine.Camera ÏÎÎÌÌÎÎÌÏÎÏÍÍÏÏÏÎÍÌÏÍÏÌ; // 0x20

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC371D9D0
        public void RaiseCancellation(){} // RVA: 0x7FFAC87DF6E0
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC371D9D0
        public void CancelInvoke(){} // RVA: 0x7FFAC371D9F0
        public void Invoke(){} // RVA: 0x7FFACB9A3320
        public void OnPointerDown(){} // RVA: 0x7FFAC87DF6E0
        public void OnDrag(){} // RVA: 0x7FFAC87DF6E0
        public void IsInvoking(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC371D9F0
        public void StartCoroutine(){} // RVA: 0x7FFAC87DF6E0
        public void Start(){} // RVA: 0x7FFACB9A3650
        public void StopCoroutine(){} // RVA: 0x7FFAC2F21310
    }

}