// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.UI.Core
// Classes: 7
// Methods: 94

namespace VRC.UI.Core
{
    public class FoldoutStateService : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;

        // ── Methods ──
        public void StaticInitialize(){} // RVA: 0x9F4D760
        public void Equals(){} // RVA: 0x9F4D860
        public void GetHashCode(){} // RVA: 0x9F4D920
        public void op_Implicit(){} // RVA: 0x9F4DBC0
        public void .cctor(){} // RVA: 0x9F4DDF0
    }

    public class UIElement : MonoBehaviour
    {
        public object _uIElement;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0xB43310
        public void RaiseCancellation(){} // RVA: 0xB700F0
        public void IsInvoking(){} // RVA: 0xB700F0
        public void CancelInvoke(){} // RVA: 0xB70100
        public void Invoke(){} // RVA: 0xB70100
        public void InvokeRepeating(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0xB70100
        public void StopCoroutine(){} // RVA: 0xB70100
        public void Awake(){} // RVA: 0xB43310
        public void OnDestroy(){} // RVA: 0xB43310
        public void set_useGUILayout(){} // RVA: 0xB70100
    }

    public class UIInvisibleGraphic : MaskableGraphic
    {
        public object interactibility;
        public object interactableOverride;

        // ── Methods ──
        public void Raycast(){} // RVA: 0x9762950
        public void Rebuild(){} // RVA: 0xB43310
        public void OnPopulateMesh(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x97629E0
    }

    public class UIManager : MonoBehaviour
    {
        public object _uIManager;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x97629F0
        public void RaiseCancellation(){} // RVA: 0x9762DC0
        public void OnDestroy(){} // RVA: 0x9762F80
        public void CancelInvoke(){} // RVA: 0x9763120
        public void Invoke(){} // RVA: 0x97634F0
        public void InvokeRepeating(){} // RVA: 0x97638C0
        public void OnDisable(){} // RVA: 0xB43310
        public void Awake(){} // RVA: 0x9763900
        public void StopCoroutine(){} // RVA: 0xB43310
        public void StopAllCoroutines(){} // RVA: 0x9763BD0
        public void OnEnable(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x9763C10
        public void Start(){} // RVA: 0xB43310
        public void print(){} // RVA: 0xB43310
    }

    /// <summary>Originally: ÍÏÌÎÏÍÌÎÏÍÎÌÎÌÌÌÍÌÌÍÎÍÍ</summary>
    public class UIcullDisableBoxmatManagerSibling_3D5E : UIcullDisableBoxmatManager_C06C
    {
        public object f_3B5;
        public object f_581;
        public object f_DEA;
        public object f_D17;
        public object f_E4E;
        public object f_608;
        public object f_1C6;
        public object f_794;
        public object f_B01;
        public object f_DAB;
        public object f_5A3;
        public object f_4A4;
        public object f_CCF;
        public object f_E55;
        public object f_EC5;
        public object f_7F8;
        public object f_A50;
        public object f_D52;
        public object f_B5D;
        public object f_4D0;
        public object f_D71;
        public object f_BD9;
        public object f_87E;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x1366550
        public void OnDestroy(){} // RVA: 0x13668B0
        public void .ctor(){} // RVA: 0x1368A70
        public void Initialize(){} // RVA: 0x1368B10
        public void Awake(){} // RVA: 0x136A9C0
        // ── 18 unresolved (hash) ──
        public void m_CF5(){} // RVA: 0x1365F10
        public void m_8C1(){} // RVA: 0x1366480
        public void m_31D(){} // RVA: 0x136B9D0
        public void m_E87(){} // RVA: 0x13682A0
        public void m_CCF(){} // RVA: 0x13683D0
        // ... 13 more unresolved methods
    }

    /// <summary>Originally: ÏÌÌÎÌÏÌÍÍÏÏÎÎÌÎÍÎÎÎÎÍÏÌ</summary>
    public class UIcullDisableBoxmatManagerSibling_F4B8 : UIcullDisableBoxmatManagerSibling_3D5E
    {
        public object f_EC3;
        public object f_AB7;
        public object f_DEA;
        public object f_7CC;
        public object f_8A2;
        public object f_3C9;
        public object f_F8A;
        public object f_DEA;
        public object f_D17;
        public object f_718;
        public object f_BD2;
        public object f_9EC;

        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x23B42A0
        public void .ctor(){} // RVA: 0x23B5280
        public void Initialize(){} // RVA: 0x23B5360
        public void Start(){} // RVA: 0x23B5DE0
        // ── 13 unresolved (hash) ──
        public void m_209(){} // RVA: 0x23B3F00
        public void m_DF2(){} // RVA: 0x23B3FF0
        public void m_EB1(){} // RVA: 0x23B3FF0
        public void m_FFA(){} // RVA: 0x23B40F0
        public void m_75F(){} // RVA: 0x23B45A0
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÎÌÌÎÏÎÍÏÏÍÎÍÍÎÍÏÍÎÎÏÍÍÍ</summary>
    public class UIcullDisableBoxmatManager_C06C : MonoBehaviour
    {
        public object _m_CancellationTokenSource;
        public object f_24F;
        public object matManager;
        public object cullDisableBox;
        public object rootCanvas;
        public object f_A0C;
        public object f_30E;
        public object f_DEA;
        public object f_1A9;
        public object f_4D4;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x11F3A90
        public void Awake(){} // RVA: 0x11F3B80
        public void Start(){} // RVA: 0x11F3E20
        public void OnDestroy(){} // RVA: 0x11F3FA0
        public void OnEnable(){} // RVA: 0xCADE00
        public void OnDisable(){} // RVA: 0x11F4110
        public void StartCoroutine(){} // RVA: 0x11F4130
        public void StartCoroutine_Auto(){} // RVA: 0x11F44B0
        public void StopCoroutine(){} // RVA: 0x11F4770
        public void StopAllCoroutines(){} // RVA: 0x8A3630
        public void get_useGUILayout(){} // RVA: 0x11F4C20
        public void set_useGUILayout(){} // RVA: 0x11F4C70
        public void get_didStart(){} // RVA: 0x11F4D70
        public void get_didAwake(){} // RVA: 0x11F5030
        public void print(){} // RVA: 0x11F5090
        public void Internal_CancelInvokeAll(){} // RVA: 0x11F54B0
        public void .ctor(){} // RVA: 0x11DF980
    }

}