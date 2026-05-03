// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.RealisticEyeMovements.RealisticEyeMovements
// Classes: 8
// Methods: 214

namespace ThirdParty.RealisticEyeMovements.RealisticEyeMovements
{
    public class ControlData : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE827CC610
        public void Equals(){} // RVA: 0x7FFE827CC890
        public void GetHashCode(){} // RVA: 0x7FFE827CC8E0
        public void op_Implicit(){} // RVA: 0x7FFE827CC900
        public void CompareBaseObjects(){} // RVA: 0x7FFE827CCC30
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE827CD9B0
        public void GetCachedPtr(){} // RVA: 0x7FFE827CE0C0
        public void get_name(){} // RVA: 0x7FFE827CE940
        public void set_name(){} // RVA: 0x7FFE827CEC70
        public void Instantiate(){} // RVA: 0x7FFE827CECB0
        public void ToString(){} // RVA: 0x7FFE827CEF90
        public void InitializeControlData(){} // RVA: 0x7FFE827CF7A0
        public void InitializeControlDataDestroy(){} // RVA: 0x7FFE827D0740
        public void UpdateConditionalField(){} // RVA: 0x7FFE827D0A80
        public void GetIndexedField(){} // RVA: 0x7FFE827D1810
        public void RetrieveAndProcessInternalData(){} // RVA: 0x7FFE827D1DD0
        public void InitializeStaticContext(){} // RVA: 0x7FFE827D1FF0
        public void GetInitializedValue(){} // RVA: 0x7FFE827D2CC0
        public void InitializeManagerState(){} // RVA: 0x7FFE827D2FF0
        public void Destroy(){} // RVA: 0x7FFE827D3210
        public void ProcessIndexedEyeControl(){} // RVA: 0x7FFE827D3240
        public void DestroyImmediate(){} // RVA: 0x7FFE827D3FD0
        public void .ctor(){} // RVA: 0x7FFE827D4A00
        public void Initialize(){} // RVA: 0x7FFE827D4F10
        public void FindObjectsOfType(){} // RVA: 0x7FFE827D5130
        public void FindObjectsByType(){} // RVA: 0x7FFE827D5240
        public void SetIndexedByteConditional(){} // RVA: 0x7FFE827D5570
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE827D55B0
        public void get_hideFlags(){} // RVA: 0x7FFE827D5DC0
        public void set_hideFlags(){} // RVA: 0x7FFE827D60D0
    }

    public class EyeAndHeadAnimator : MonoBehaviour
    {
        public float _m_CancellationTokenSource;
        public float f_AF4;
        public float f_538;
        public float f_D0B;
        public System.Action f_8C6; // 0x20
        public float headSpeedModifier; // 0x28
        public float headWeight; // 0x2C
        public UnityEngine.Transform headBoneNonMecanimXform; // 0x30

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE810FB310
        public void RaiseCancellation(){} // RVA: 0x7FFE81124040
        public void IsInvoking(){} // RVA: 0x7FFE827DA4B0
        public void OnDrawGizmos(){} // RVA: 0x7FFE827DAA00
        public void Invoke(){} // RVA: 0x7FFE827DC0A0
        public void OnDisable(){} // RVA: 0x7FFE827DC270
        public void CancelInvoke(){} // RVA: 0x7FFE827DC2D0
        public void OnApplicationPause(){} // RVA: 0x7FFE827DC430
        public void .cctor(){} // RVA: 0x7FFE827DD020
        public void StartCoroutine(){} // RVA: 0x7FFE827DD1B0
        public void OnBecameVisible(){} // RVA: 0x7FFE820CF690
        public void OnDestroy(){} // RVA: 0x7FFE827DD1C0
        public void StopCoroutine(){} // RVA: 0x7FFE813AB650
        public void OnCollisionStay(){} // RVA: 0x7FFE827E4690 | overloaded x2
        public void OnCollisionExit(){} // RVA: 0x7FFE813A18F0
        public void StopAllCoroutines(){} // RVA: 0x7FFE827DD450
        public void get_useGUILayout(){} // RVA: 0x7FFE827DD6D0
        public void set_useGUILayout(){} // RVA: 0x7FFE81124070
        public void LateUpdate(){} // RVA: 0x7FFE827DEFC0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE827DF280
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE827E00A0
        public void InvokeDelayed(){} // RVA: 0x7FFE827E00B0
        public void OnApplicationQuit(){} // RVA: 0x7FFE813AB650
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE827E4860 | overloaded x2
        public void StartCoroutineManaged(){} // RVA: 0x7FFE827E1620
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE827E16F0
        public void StopCoroutineManaged(){} // RVA: 0x7FFE827E1700
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE827E1B80
        public void GetScriptClassName(){} // RVA: 0x7FFE827E1BA0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE827E1C90
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void Start(){} // RVA: 0x7FFE827E3A30 | overloaded x2
        public void FixedUpdate(){} // RVA: 0x7FFE81B27D50
        public void .ctor(){} // RVA: 0x7FFE827E2EC0
        public void Initialize(){} // RVA: 0x7FFE827E3090
        public void OnBecameInvisible(){} // RVA: 0x7FFE827E3C20
        public void OnCollisionEnter(){} // RVA: 0x7FFE827E3E20
        public void OnTriggerEnter(){} // RVA: 0x7FFE827E4380
        public void OnTriggerStay(){} // RVA: 0x7FFE827E4430
        public void OnTriggerExit(){} // RVA: 0x7FFE827E4590
        public void Update(){} // RVA: 0x7FFE827E4F30
        public void OnAnimatorIK(){} // RVA: 0x7FFE827E5DB0
        // ── 42 unresolved (hash) ──
        public void m_52A(){} // RVA: 0x7FFE827E0670
        public void m_682(){} // RVA: 0x7FFE827E1FE0
        public void m_0BD(){} // RVA: 0x7FFE827E31F0
        public void m_33D(){} // RVA: 0x7FFE827E35B0
        public void m_5F6(){} // RVA: 0x7FFE827E35F0
        // ... 37 more unresolved methods
    }

    public class EyeAndHeadAnimatorForExport : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EyeRotationLimiter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE827C8190
        public void Equals(){} // RVA: 0x7FFE827C8340
        public void op_Implicit(){} // RVA: 0x7FFE827C87B0
        public void CompareBaseObjects(){} // RVA: 0x7FFE827C87F0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE827C89E0
        public void GetCachedPtr(){} // RVA: 0x7FFE827C8A40
        public void get_name(){} // RVA: 0x7FFE827C8BF0
        public void set_name(){} // RVA: 0x7FFE827C8DE0
        public void Instantiate(){} // RVA: 0x7FFE827C8E50
        public void GetHashCode(){} // RVA: 0x7FFE827C8EE0
        public void ToString(){} // RVA: 0x7FFE827C8F70
        public void ToString_6B16899F6CBA(){} // RVA: 0x7FFE827C93E0
        public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFE827C9450
        public void GetLongFromDelegate(){} // RVA: 0x7FFE827C9530
        public void GetBooleanFromDelegate(){} // RVA: 0x7FFE827C9570
        public void GetIntegerFromDelegate(){} // RVA: 0x7FFE827C9630
        public void FailFast(){} // RVA: 0x7FFE827C9BE0
        public void Destroy(){} // RVA: 0x7FFE827C9CA0
        // ── Unresolved (hash) ──
        public void m_318(){} // RVA: 0x7FFE827C94C0
    }

    public class EyelidRotationLimiter : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE827C9D10
        public void Equals(){} // RVA: 0x7FFE827C9D80
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE827C9E90
        public void CompareBaseObjects(){} // RVA: 0x7FFE827C9FA0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE827CA0C0
        public void GetCachedPtr(){} // RVA: 0x7FFE827CA1E0
        public void get_name(){} // RVA: 0x7FFE827CA2F0
        public void set_name(){} // RVA: 0x7FFE827CA5E0
        public void Instantiate(){} // RVA: 0x7FFE827CAB00
        public void GetHashCode(){} // RVA: 0x7FFE827CB000
        public void ToString(){} // RVA: 0x7FFE827CB100
        public void InitializeNameEyelidRotationLimiter(){} // RVA: 0x7FFE827CB210
        public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFE827CB310
        public void InitializeEyelidRotationLimiter(){} // RVA: 0x7FFE827CB420
        public void .ctor_48FD300A4127(){} // RVA: 0x7FFE827CB940
        public void Initialize_13C0813CE5A1(){} // RVA: 0x7FFE827CBE30
        public void GetIntegerFromDelegate(){} // RVA: 0x7FFE827CC350
    }

    public class LookTargetController : MonoBehaviour
    {
        // ── Methods ──
        public void FixedUpdate(){} // RVA: 0x7FFE827ED0D0 | overloaded x2
        public void RaiseCancellation(){} // RVA: 0x7FFE827EB030
        public void IsInvoking(){} // RVA: 0x7FFE827EB0D0
        public void CancelInvoke(){} // RVA: 0x7FFE827EB620
        public void Invoke(){} // RVA: 0x7FFE827EB700
        public void LateUpdate(){} // RVA: 0x7FFE827EC5C0
        public void DoRange(){} // RVA: 0x7FFE827ED250
        public void Update(){} // RVA: 0x7FFE827ED260
        public void OnDestroy(){} // RVA: 0x7FFE827ED530
        public void .ctor(){} // RVA: 0x7FFE827ED7C0
        public void Initialize(){} // RVA: 0x7FFE827ED860
        public void StopCoroutine(){} // RVA: 0x7FFE827ED9E0
        public void Start(){} // RVA: 0x7FFE810FB310
        public void OnCollisionExit(){} // RVA: 0x7FFE827EDC70
        public void StopAllCoroutines(){} // RVA: 0x7FFE827EDD30
        public void get_useGUILayout(){} // RVA: 0x7FFE827EDFB0
        public void set_useGUILayout(){} // RVA: 0x7FFE827EE340
        public void print(){} // RVA: 0x7FFE827ED250
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE827EE6F0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE827EE940
        public void InvokeDelayed(){} // RVA: 0x7FFE827EF440
        public void OnBecameInvisible(){} // RVA: 0x7FFE827EF4B0
        public void Awake(){} // RVA: 0x7FFE827EF4F0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE827EF640
        public void StartCoroutineManaged(){} // RVA: 0x7FFE827EF700
        public void StartCoroutineManaged2(){} // RVA: 0x7FFE827EF4B0
        public void StopCoroutineManaged(){} // RVA: 0x7FFE827EFB30
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE827EFF60
        public void GetScriptClassName(){} // RVA: 0x7FFE827F04F0
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFE810FB310
        public void OnApplicationPause(){} // RVA: 0x7FFE827F0B80
        public void OnApplicationQuit(){} // RVA: 0x7FFE827F1040
        public void OnBecameVisible(){} // RVA: 0x7FFE827F11C0
        // ── Unresolved (hash) ──
        public void m_110(){} // RVA: 0x7FFE827F1710
    }

    public class SerializableQuaternion : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE827F4FC0
        public void Equals(){} // RVA: 0x7FFE827D9F70 | overloaded x2
        public void DefaultEquals(){} // RVA: 0x7FFE827D9F70
        public void .ctor(){} // RVA: 0x7FFE8111F570
        public void Initialize(){} // RVA: 0x7FFE827D9F70
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE827D9F70
        public void GetHashCode(){} // RVA: 0x7FFE827D9F70
        public void GetHashCode_F86DB6EEA3C5(){} // RVA: 0x7FFE827D9F70
        public void HasValue(){} // RVA: 0x7FFE827D9F70
    }

    public class SerializableVector3 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE827F5210
        public void InternalEquals(){} // RVA: 0x7FFE827F5210
        public void .ctor(){} // RVA: 0x7FFE8111ED70
        public void Initialize(){} // RVA: 0x7FFE827F5210
        public void InternalGetHashCode(){} // RVA: 0x7FFE827F5210
        public void GetHashCode(){} // RVA: 0x7FFE827F5210
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE827F5210 | overloaded x2
        public void Initialize_7CC3E192C492(){} // RVA: 0x7FFE827F5210
        public void ToString_6608280D05AB(){} // RVA: 0x7FFE827F5210
        public void ToString(){} // RVA: 0x7FFE827F5230
    }

}