// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI
// Classes: 6
// Methods: 43

namespace VRC.UI
{
    /// <summary>Originally: ÍÏÌÍÏÌÌÍÌÍÌÎÌÏÎÍÎÌÍÍÏÌÏ</summary>
    public class ImageCropPreviewPanel : MonoBehaviour
    {
        public object notePreview;
        public object preview;
        public object cropControlsParent;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x1134300
        public void RaiseCancellation(){} // RVA: 0x1134340
        public void IsInvoking(){} // RVA: 0x11343C0
        public void CancelInvoke(){} // RVA: 0x1134400
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x1134340
        public void StartCoroutine(){} // RVA: 0x1134470
        public void StartCoroutine_Auto(){} // RVA: 0x1134340
    }

    public class ImageEx : Image
    {
        // ── Methods ──
        public void OnPopulateMesh(){} // RVA: 0x975BED0
        public void Width(){} // RVA: 0xBC5B30
        public void .ctor(){} // RVA: 0x975C2F0
        public void Initialize(){} // RVA: 0xBA9AB0
        public void ImageFormat(){} // RVA: 0xBA9AB0
        public void Raycast(){} // RVA: 0x975C380
        // ── 11 unresolved (hash) ──
        public void m_FB9(){} // RVA: 0x975BEC0
        public void m_115(){} // RVA: 0x7E45D60
        public void m_8E2(){} // RVA: 0xBA9AB0
        public void m_984(){} // RVA: 0x975BEC0
        public void m_54B(){} // RVA: 0xBC5B30
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÍÌÎÎÍÍÎÎÏÏÍÏÌÎÍÍÎÍÍÏÍÎÎ</summary>
    public class InitializePotentialDragPointerDownHandler_DA28 : MonoBehaviour
    {
        public object _dA28;

        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x6C48C50
        public void Start(){} // RVA: 0x9F56BE0
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x9F56BF0
        public void Invoke(){} // RVA: 0xB43310
        public void OnInitializePotentialDrag(){} // RVA: 0x13CB610
        public void StartCoroutine(){} // RVA: 0x9F56EF0
        public void StartCoroutine_Auto(){} // RVA: 0x5BA5570
        public void StopCoroutine(){} // RVA: 0xB43310
        public void StopAllCoroutines(){} // RVA: 0x5BA5570
        public void get_useGUILayout(){} // RVA: 0xB43310
        public void OnDrag(){} // RVA: 0x6C48C50
    }

    /// <summary>Originally: ÌÌÏÍÏÏÎÏÌÏÍÌÎÌÌÎÌÏÏÎÍÍÎ</summary>
    public class InitializePotentialDragPointerDownHandler_colorPickerRectTransformcolorPicker_5E21 : InitializePotentialDragPointerDownHandler_DA28
    {
        public object colorPicker;
        public object colorPickerRectTransform;

        // ── Methods ──
        public void Handle(){} // RVA: 0x9F571F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    /// <summary>Originally: ÍÍÎÏÏÌÌÎÎÎÌÌÎÌÏÎÌÎÌÏÌÍÎ</summary>
    public class InitializePotentialDragPointerDownHandler_colorPickerhueRect_4FD8 : InitializePotentialDragPointerDownHandler_DA28
    {
        public object colorPicker;
        public object hueRect;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
        public void Handle(){} // RVA: 0x9F572D0
    }

    /// <summary>Originally: ÍÎÌÍÍÌÌÌÎÏÌÌÏÍÍÌÍÌÌÎÌÍÍ</summary>
    public class InitializePotentialDragPointerDownHandler_saturationValueRectcolorPicker_C0E5 : InitializePotentialDragPointerDownHandler_DA28
    {
        public object colorPicker;
        public object saturationValueRect;

        // ── Methods ──
        public void Handle(){} // RVA: 0x9F57400
        public void .ctor(){} // RVA: 0xB43D60
    }

}