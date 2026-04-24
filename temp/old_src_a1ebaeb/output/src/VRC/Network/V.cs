// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Network
// Classes: 48
// Methods: 461

namespace VRC.Network
{
    /// <summary>Originally: ÍÌÍÌÎÍÎÎÎÌÎÏÎÌÌÌÌÎÏÏÏÌÏ</summary>
    public class VRCNetworkBehaviour : NetworkReadyHandler_30DA
    {
        public object _typeId; // 0x319BE890, was: ÏÌÍÌÏÏÎÎÎÎÌÌÏÎÎÏÎÏÍÌÍÎÎ

        // ── Original Methods ──
        public void ComputegameObject(){} // RVA: 0x7ffaa9c25960
        public void Encode_sub(){} // RVA: 0x7ffaa9c25e80
        public void SerializeNetworkData(){} // RVA: 0x7ffaa9c25f80
        public void OnNetworkReady(){} // RVA: 0x7ffaa9c269d0
        public void Encode(){} // RVA: 0x7ffaa9c28790
        public void Decode(){} // RVA: 0x7ffaa9c28050
        public void CanSerialize8Bit(){} // RVA: 0x7ffaa8a17850
        public void IsNetworkOperationPermitted(){} // RVA: 0x7ffaa8932320
        public void SerializedName(){} // RVA: 0x7ffaa9c26ad0
        public void NeedsSync(){} // RVA: 0x7ffaa89ae320
        public void Initialize(){} // RVA: 0x7ffaa887e5c0
        public void NeedsImportant(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaa9c26c40
        public void Initialize(){} // RVA: 0x7ffaa887e5c0
        public void ProcessNetworkOperation(){} // RVA: 0x7ffaa8b6f8a0
        public void DeserializeNetworkData(){} // RVA: 0x7ffaa9c271b0
        public void InvokeNetworkDelegate(){} // RVA: 0x7ffaa8660d80
        public void HandleFatalNetworkError(){} // RVA: 0x7ffaa9c27780
        public void set_TypeId(){} // RVA: 0x7ffaa9c277c0
        public void Awake(){} // RVA: 0x7ffaa9c27d90
        public void Start(){} // RVA: 0x7ffaa9c27fa0
        public void get_TypeId(){} // RVA: 0x7ffaa9c28040
        public void Update(){} // RVA: 0x7ffaa8b6f8a0
        public void Decode(){} // RVA: 0x7ffaa9c28050
        public void Encode(){} // RVA: 0x7ffaa9c28790
        public void OnDestroy(){} // RVA: 0x7ffaa9c29040
        public void CanSerialize32Bit(){} // RVA: 0x7ffaa8932320
        public void OnBecameVisible(){} // RVA: 0x7ffaa9c293f0
        // ── Binary Analysis Named ──
        public void DoRequest_Internal_Texture_1_Injected_1E1(){} // RVA: 0x7ffaa9c25e40
        public void DoParameterDecoder(){} // RVA: 0x7ffaa9c266f0
        public void GetGameObject_A35(){} // RVA: 0x7ffaa9c29340
        public void DoInitializeArray(){} // RVA: 0x7ffaa9c27e30
        public void GetGameObject_A35(){} // RVA: 0x7ffaa9c29340
        // ── Obfuscated Methods ──
        public void m_361(){} // RVA: 0x7ffaa887e5c0
        public void m_361(){} // RVA: 0x7ffaa887e5c0
    }

    /// <summary>Originally: ÍÏÍÎÏÍÎÎÌÌÎÏÏÍÏÎÌÏÏÎÏÌÏ</summary>
    public class VRCNetworkBehaviourBase : NetworkReadyHandler_30DA
    {
        public object _uniqueHash; // 0x334E9F30, was: ÎÎÏÌÍÏÎÌÏÏÌÏÎÎÍÍÏÏÏÌÍÌÏ
        public object _typeId; // 0x170005CB, was: ÌÎÏÌÎÎÌÏÍÍÌÌÏÍÌÏÎÎÎÎÍÎÌ

        // ── Original Methods ──
        public void ProcessNetworkBehaviourData(){} // RVA: 0x7ffaa9bd6560
        public void CanSerialize8Bit(){} // RVA: 0x7ffaa8a17850
        public void Decode(){} // RVA: 0x7ffaa9bd79e0
        public void CanUsePersistenceHashes(){} // RVA: 0x7ffaa9bd7110
        public void ConfigureNetworkBehavior(){} // RVA: 0x7ffaa9bd7540
        public void Decode(){} // RVA: 0x7ffaa9bd79e0
        public void SerializedName(){} // RVA: 0x7ffaa9bd7cf0
        public void .ctor(){} // RVA: 0x7ffaa9bd7e60
        public void Initialize(){} // RVA: 0x7ffaa9bd7ee0
        public void ComputeactiveSelf(){} // RVA: 0x7ffaa9bd80f0
        public void set_UniqueHash(){} // RVA: 0x7ffaa9bd8200
        public void Awake(){} // RVA: 0x7ffaa9bd86f0
        public void get_UniqueHash(){} // RVA: 0x7ffaa9bd8880
        public void Start(){} // RVA: 0x7ffaa9bd8890
        public void Update(){} // RVA: 0x7ffaa9bd8930
        public void GenerateComponentInfo(){} // RVA: 0x7ffaa9bd89d0
        public void Updaterotation_Inj(){} // RVA: 0x7ffaa9bd8b60
        public void OnDisable(){} // RVA: 0x7ffaa8932320
        public void NeedsImportant(){} // RVA: 0x7ffaa8932320
        public void CanSerialize32Bit(){} // RVA: 0x7ffaa8a17850
        public void Encode(){} // RVA: 0x7ffaa9bd8ee0
        public void NeedsSync(){} // RVA: 0x7ffaa89fa570
        public void Encode(){} // RVA: 0x7ffaa9bd8ee0
        public void ComputegameObject(){} // RVA: 0x7ffaa9bd9330
        public void get_TypeId(){} // RVA: 0x7ffaa9bd8880
        // ── Binary Analysis Named ──
        public void SetupNetworkBehavior(){} // RVA: 0x7ffaa9bd6c60
        public void DoGet(){} // RVA: 0x7ffaa9bd76d0
        public void GetNetworkInstanceId(){} // RVA: 0x7ffaa8b6f8a0
        public void GetPersistenceHash(){} // RVA: 0x7ffaa8b6f8a0
        public void GetConstantTypeId(){} // RVA: 0x7ffaa9bd86e0
        public void DoBitUnpack(){} // RVA: 0x7ffaa9bd9050
    }

    /// <summary>Originally: ÌÌÏÏÌÏÌÏÏÏÍÎÍÏÌÌÌÍÏÌÍÎÏ</summary>
    public class VRCNetworkBehaviourSiblinRelated_092A
    {
        // ── Original Methods ──
        public void InvokeNetworkSiblingMethod(){} // RVA: 0x7ffaa8660cc0
        // ── Obfuscated Methods ──
        public void m_E42(){} // RVA: 0x7ffaa887e5c0
        public void m_62A(){} // RVA: 0x7ffaa887e5c0
        public void m_D08(){} // RVA: 0x7ffaa887e5c0
        public void m_AC9(){} // RVA: 0x7ffaa887e5c0
    }

    /// <summary>Originally: ÌÌÏÏÌÏÌÏÏÏÍÎÍÏÌÌÌÍÏÌÍÎÏ</summary>
    public class VRCNetworkBehaviourSiblinRelated_092A
    {
    }

    /// <summary>Originally: ÌÎÍÍÍÌÌÎÎÏÌÏÏÌÏÍÍÌÌÏÍÌÌ</summary>
    public class VRCNetworkBehaviourSiblinRelated_55A5 : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaa081670
        public void InternalEquals(){} // RVA: 0x7ffaaa0816a0
        public void DefaultEquals(){} // RVA: 0x7ffaaa0816a0
        public void InternalGetHashCode(){} // RVA: 0x7ffaaa0816a0
        public void ToString(){} // RVA: 0x7ffaaa0816f0
        public void .ctor(){} // RVA: 0x7ffaa930eca0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa0816d0
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaaa081720
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7ffaaa0816a0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7ffaaa0816d0
        // ── Obfuscated Methods ──
        public void m_AC9(){} // RVA: 0x7ffaaa081780
    }

    /// <summary>Originally: ÌÌÍÌÏÌÏÏÍÏÎÌÍÍÏÍÎÍÏÍÎÌÌ</summary>
    public class VRCNetworkBehaviourSiblinRelated_64E4 : Object
    {
        // ── Original Methods ──
        public void ComputeLastValueAsDouble(){} // RVA: 0x7ffaaa016ab0
        public void .ctor(){} // RVA: 0x7ffaaa016b20
        public void Initialize(){} // RVA: 0x7ffaaa016bf0
        public void op_Implicit(){} // RVA: 0x7ffaaa016c10
        public void CompareBaseObjects(){} // RVA: 0x7ffaaa016c30
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaaa016c30
        public void ComputeValid(){} // RVA: 0x7ffaaa016c60
        public void get_name(){} // RVA: 0x7ffaaa016c30
        public void set_name(){} // RVA: 0x7ffaaa016c10
        public void Instantiate(){} // RVA: 0x7ffaaa016ca0
        public void Equals(){} // RVA: 0x7ffaaa016bf0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa016d10
    }

    /// <summary>Originally: ÍÌÌÌÍÌÏÎÎÍÍÎÌÎÏÎÍÌÎÏÍÌÍ</summary>
    public class VRCNetworkBehaviourSiblingSiblSibling_385E : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaa0816f0
        public void InternalEquals(){} // RVA: 0x7ffaaa0817a0
        public void DefaultEquals(){} // RVA: 0x7ffaaa081720
        public void InternalGetHashCode(){} // RVA: 0x7ffaaa0817e0
        public void ToString(){} // RVA: 0x7ffaaa0817c0
        public void ResetNetworkBehaviour(){} // RVA: 0x7ffaaa0816f0
        public void .ctor(){} // RVA: 0x7ffaa930eca0
        public void Initialize(){} // RVA: 0x7ffaaa0817a0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa0817c0
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaaa0817c0
        // ── Obfuscated Methods ──
        public void m_465(){} // RVA: 0x7ffaaa0817e0
        public void m_B59(){} // RVA: 0x7ffaaa0817c0
        public void m_E42(){} // RVA: 0x7ffaaa0816d0
        public void m_62A(){} // RVA: 0x7ffaaa0817a0
    }

    /// <summary>Originally: ÎÏÎÍÎÍÌÏÌÎÌÌÌÎÎÏÎÍÏÏÌÎÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_02AF : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Initialize(){} // RVA: 0x7ffaa92d9da0
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa92d9da0
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa92d9da0
        public void GetterrainData(){} // RVA: 0x7ffaa92d9da0
        public void Gettransform(){} // RVA: 0x7ffaa92d9da0
        public void GetCachedPtr(){} // RVA: 0x7ffaa92d9da0
        public void GetGameObject_0EE(){} // RVA: 0x7ffaa92d9da0
    }

    /// <summary>Originally: ÏÌÍÍÎÍÍÍÎÎÌÏÌÌÌÏÏÌÎÎÎÏÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_19F5 : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa93145b0
        public void InternalEquals(){} // RVA: 0x7ffaa93145d0
        public void DefaultEquals(){} // RVA: 0x7ffaa93145f0
        public void InternalGetHashCode(){} // RVA: 0x7ffaa9314630
        public void ToString(){} // RVA: 0x7ffaa93145d0
        public void CompareStructFields(){} // RVA: 0x7ffaa9315e90
        public void UpdateNetworkBindingAtomically(){} // RVA: 0x7ffaa93195b0
        public void HasProperty216(){} // RVA: 0x7ffaa93197a0
        public void EvaluateAndProcessNetworkState(){} // RVA: 0x7ffaa93197f0
        public void .ctor(){} // RVA: 0x7ffaa930eca0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9314610
        public void DoRemoveCallback(){} // RVA: 0x7ffaa9314650
        public void GetProperty216(){} // RVA: 0x7ffaa93176d0
        public void GetProperty280(){} // RVA: 0x7ffaa93145d0
        public void GetProperty288(){} // RVA: 0x7ffaa93176f0
        public void DoAddCallback(){} // RVA: 0x7ffaa9317710
        public void GetOrInitializeProperty216(){} // RVA: 0x7ffaa93185e0
        public void GetProperty232(){} // RVA: 0x7ffaa9318620
        public void SetupNetworkBindings(){} // RVA: 0x7ffaa9318640
        public void DoResolveBindings(){} // RVA: 0x7ffaa9319510
        public void GetProperty240(){} // RVA: 0x7ffaa9319590
        public void GetProperty296(){} // RVA: 0x7ffaa9319780
        public void GetProperty248(){} // RVA: 0x7ffaa93197d0
        public void GetProperty264(){} // RVA: 0x7ffaa93145b0
        // ── Obfuscated Methods ──
        public void m_533(){} // RVA: 0x7ffaa93145f0
    }

    /// <summary>Originally: ÍÏÏÍÏÏÏÏÎÎÎÏÍÌÍÎÌÎÍÍÎÏÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_1E07
    {
        // ── Original Methods ──
        public void InitializeNetworkModule(){} // RVA: 0x7ffaa887e5c0
    }

    /// <summary>Originally: ÌÌÏÌÌÎÎÏÎÍÏÎÌÌÌÍÎÌÌÍÏÍÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_2B42 : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa949bdd0
        public void InternalEquals(){} // RVA: 0x7ffaa949bdf0
        public void DefaultEquals(){} // RVA: 0x7ffaa949be10
        public void InternalGetHashCode(){} // RVA: 0x7ffaa949be50
        public void ToString(){} // RVA: 0x7ffaa949be70
        public void InitializeAndProcessNetworkData(){} // RVA: 0x7ffaa949d7a0
        public void RetrieveNetworkComponentData(){} // RVA: 0x7ffaa949d990
        public void .ctor(){} // RVA: 0x7ffaa930eca0
        public void Initialize(){} // RVA: 0x7ffaa949be50
        public void TryProcessNetworkAction(){} // RVA: 0x7ffaa94a16c0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa949be30
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa949be90
        public void CheckIsDone_E5A(){} // RVA: 0x7ffaa949c080
        public void CheckIsDone_DF3(){} // RVA: 0x7ffaa949c0a0
        public void CheckIsDone_613(){} // RVA: 0x7ffaa949c120
        public void GetNetworkComponentDataOffset(){} // RVA: 0x7ffaa949d970
        public void CheckIsDone_992(){} // RVA: 0x7ffaa949c060
        public void GetNetworkComponentOffset(){} // RVA: 0x7ffaa949d9d0
        public void GetValueAtOffset504(){} // RVA: 0x7ffaa949d9f0
        public void GetValueAtOffset480(){} // RVA: 0x7ffaa949da10
        public void GetValueAtOffset568(){} // RVA: 0x7ffaa949be70
        public void DoAddCallback(){} // RVA: 0x7ffaa949da30
        public void DoIsVersionCached_Injected_2B4(){} // RVA: 0x7ffaa949f0b0
        public void GetValueAtOffset496(){} // RVA: 0x7ffaa949f100
        public void DoRemoveCallback(){} // RVA: 0x7ffaa949f120
        public void GetValueAtOffset536(){} // RVA: 0x7ffaa94a16a0
        public void GetValueAtOffset448(){} // RVA: 0x7ffaa949be50
        public void GetValueAtOffset560(){} // RVA: 0x7ffaa94a1740
        // ── Obfuscated Methods ──
        public void m_E76(){} // RVA: 0x7ffaa949c060
        public void m_C90(){} // RVA: 0x7ffaa949be70
        public void m_092(){} // RVA: 0x7ffaa949da10
        public void m_243(){} // RVA: 0x7ffaa949f0d0
    }

    /// <summary>Originally: ÌÎÍÍÏÏÍÎÍÍÌÌÌÏÍÍÍÏÏÍÍÎÏ</summary>
    public class VRCNetworkBehaviourSiblingSibling_2ED0 : Object
    {
        public object _amount; // 0x33FDF490, was: ÌÌÌÌÎÏÍÌÎÏÌÏÏÍÎÏÍÍÎÎÏÍÍ
        public object _amount2; // 0x33FDF490, was: ÎÎÌÏÍÏÎÎÏÌÍÏÌÏÎÎÏÏÌÎÎÎÏ
        public object f_E42; // 0x170009F0, was: ÌÌÌÎÏÏÏÌÍÏÍÌÎÌÏÌÍÏÎÎÍÌÎ
        public object f_AC2; // 0x170009F1, was: ÎÌÌÏÌÍÎÍÎÍÌÌÏÏÌÍÏÍÏÎÌÌÏ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa081a30
        public void Initialize(){} // RVA: 0x7ffaaa081890
        public void op_Implicit(){} // RVA: 0x7ffaaa0818f0
        public void CompareBaseObjects(){} // RVA: 0x7ffaaa081930
        public void .ctor(){} // RVA: 0x7ffaaa081a30
        public void get_name(){} // RVA: 0x7ffaaa0819e0
        public void set_name(){} // RVA: 0x7ffaa8a5c320
        public void .ctor(){} // RVA: 0x7ffaaa081a30
        public void Instantiate(){} // RVA: 0x7ffaaa0818f0
        public void Equals(){} // RVA: 0x7ffaaa081a70
        public void ToString(){} // RVA: 0x7ffaa8a9ff50
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaaa081800
        public void GetCurrentHealth(){} // RVA: 0x7ffaa8a9ff50
        public void GetHashCode(){} // RVA: 0x7ffaa8a5c320
        public void GetNetworkDataCombined(){} // RVA: 0x7ffaaa081a80
        public void SetNormalizedAmounts(){} // RVA: 0x7ffaaa081ad0
        public void SetAmountAndOtherField(){} // RVA: 0x7ffaaa081a70
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
        // ── Original Methods ──
        public void InvokeNetworkSiblingMethodWithArgs(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void SetNetworkSiblingValue(){} // RVA: 0x7ffaa887e5c0
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
        // ── Original Methods ──
        public void InvokeNetworkSiblingMethodWithArgs(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void SetNetworkSiblingValue(){} // RVA: 0x7ffaa8648be0
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
        // ── Original Methods ──
        public void InvokeNetworkSiblingMethodWithArgs(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void SetNetworkSiblingValue(){} // RVA: 0x7ffaa8648be0
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÏÏÏÎÏÏÍÏÌÍÌÍÏÌÍÎÎÏÌÌÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3110
    {
    }

    /// <summary>Originally: ÎÌÏÎÌÍÏÌÍÏÌÎÍÏÎÏÏÎÌÍÌÏÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_3DF6 : Object
    {
        public object _objectIsNullMessage; // 0x33FC4530, was: ÍÏÌÎÎÎÍÏÌÎÏÏÎÏÎÏÌÍÎÎÍÌÌ
        public object _text; // 0x33FC4530, was: ÍÍÌÌÎÎÎÌÌÍÎÍÌÌÎÏÌÎÎÎÏÌÌ
        public object _easeOut; // 0x33FC4530, was: <ÍÍÏÏÏÎÌÍÍÍÏÍÍÎÍÌÏÍÌÎÌÏÎ>k__Ba

        // ── Original Methods ──
        public void ConfigureItem(){} // RVA: 0x7ffaa9fafdc0
        public void op_Implicit(){} // RVA: 0x7ffaa894d380
        public void Instantiate(){} // RVA: 0x7ffaa9fb0130
        public void get_name(){} // RVA: 0x7ffaa9fafeb0
        public void set_name(){} // RVA: 0x7ffaa9fafed0
        public void Instantiate(){} // RVA: 0x7ffaa9fb0130
        public void ToString(){} // RVA: 0x7ffaa9fb0390
        public void OnOperationResponse_impl(){} // RVA: 0x7ffaa9fb0440
        public void get_HandleNullOnWrite(){} // RVA: 0x7ffaa92971f0
        public void OnEvent_impl(){} // RVA: 0x7ffaa9fb0500
        public void VRCSetAvatarMainIK(){} // RVA: 0x7ffaa89edc10
        public void .ctor(){} // RVA: 0x7ffaa9fb05d0
        public void set_element(){} // RVA: 0x7ffaa8bf45c0
        public void get_DisableInteractive(){} // RVA: 0x7ffaa89edc00
        public void DestroyImmediate(){} // RVA: 0x7ffaa9fb0920
        public void Initialize(){} // RVA: 0x7ffaa8933e30
        public void FindObjectsOfType(){} // RVA: 0x7ffaa8bf45c0
        public void FindObjectsByType(){} // RVA: 0x7ffaa8b945a0
        public void Equals(){} // RVA: 0x7ffaa9fb0c50
        public void ConfigureDisplayTexture(){} // RVA: 0x7ffaa9fb0d30
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa9fafdb0
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
        public void GetHashCode(){} // RVA: 0x7ffaa8b945a0
        public void GetCachedPtr(){} // RVA: 0x7ffaa9fafea0
        public void SetModelShader(){} // RVA: 0x7ffaa89ad740
        public void DoWorldToScreenPoint_Injected_90B(){} // RVA: 0x7ffaa9fb0730
        public void SetUdonEnabled(){} // RVA: 0x7ffaa9dde1d0
        public void DoWorldToScreenPoint_Injected_234(){} // RVA: 0x7ffaa9fb0950
        public void DoInverse_Injected_4D8(){} // RVA: 0x7ffaa9fb0a10
        public void DontDestroyOnLoad(){} // RVA: 0x7ffaa8bfcc80
        public void GetPublicKey(){} // RVA: 0x7ffaa89ad730
        public void GetShapes(){} // RVA: 0x7ffaa8bf45b0
        // ── Obfuscated Methods ──
        public void m_B8D(){} // RVA: 0x7ffaa89edc00
    }

    /// <summary>Originally: ÎÌÌÎÏÎÌÎÍÎÌÏÌÏÌÌÍÏÏÏÍÌÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_4242 : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa9497360
        public void InternalEquals(){} // RVA: 0x7ffaa9497390
        public void InternalGetHashCode(){} // RVA: 0x7ffaa9499ea0
        public void ToString(){} // RVA: 0x7ffaa9497360
        public void InitializeNetworkBindings(){} // RVA: 0x7ffaa9499fc0
        public void HasProperty304(){} // RVA: 0x7ffaa9497360
        public void .ctor(){} // RVA: 0x7ffaa930eca0
        public void Initialize(){} // RVA: 0x7ffaa9499f00
        public void EvaluateAndProcessNetworkState(){} // RVA: 0x7ffaa949ba60
        public void UpdateNetworkBindingAtomically(){} // RVA: 0x7ffaa949bae0
        // ── Binary Analysis Named ──
        public void DoRemoveCallback(){} // RVA: 0x7ffaa94973b0
        public void GetHashCode(){} // RVA: 0x7ffaa9499e80
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa9499ec0
        public void GetProperty368(){} // RVA: 0x7ffaa9499ee0
        public void GetProperty320(){} // RVA: 0x7ffaa9499f00
        public void GetProperty416(){} // RVA: 0x7ffaa9499f20
        public void DoResolveBindings(){} // RVA: 0x7ffaa9499f40
        public void GetProperty376(){} // RVA: 0x7ffaa949b9e0
        public void GetProperty304(){} // RVA: 0x7ffaa949ba00
        public void GetProperty432(){} // RVA: 0x7ffaa949ba20
        public void GetProperty392(){} // RVA: 0x7ffaa9499ec0
        public void GetProperty328(){} // RVA: 0x7ffaa949ba40
        public void GetProperty384(){} // RVA: 0x7ffaa9499e80
        public void GetProperty424(){} // RVA: 0x7ffaa949bcb0
        public void GetProperty352(){} // RVA: 0x7ffaa949bcf0
        public void GetProperty440(){} // RVA: 0x7ffaa949bd10
        public void GetProperty344(){} // RVA: 0x7ffaa949bd30
        public void GetProperty360(){} // RVA: 0x7ffaa949bd50
        public void GetOrInitializeProperty304(){} // RVA: 0x7ffaa949bd70
        public void GetProperty408(){} // RVA: 0x7ffaa949bdb0
        // ── Obfuscated Methods ──
        public void m_6CB(){} // RVA: 0x7ffaa9499f20
        public void m_C53(){} // RVA: 0x7ffaa949bcd0
        public void m_E75(){} // RVA: 0x7ffaa949ba00
    }

    /// <summary>Originally: ÌÎÌÌÎÏÌÌÌÏÍÏÎÏÎÍÎÏÌÌÎÎÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_4A30
    {
        // ── Original Methods ──
        public void RemoveAt(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void GetCount(){} // RVA: 0x7ffaa8649ca0
    }

    /// <summary>Originally: ÌÍÌÌÎÎÎÍÍÎÎÏÏÎÍÎÎÎÏÍÎÏÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_4AA4 : Object
    {
        public object _dateTime; // 0x3198A6F0, was: ÌÎÏÏÎÎÎÍÍÎÍÍÎÏÎÏÎÍÍÌÍÎÏ

        // ── Original Methods ──
        public void AreEqualityComparersEqual(){} // RVA: 0x7ffaa864a690
        public void Equals(){} // RVA: 0x7ffab0c7c650
        public void op_Implicit(){} // RVA: 0x7ffab0c7c8a0
        public void CompareBaseObjects(){} // RVA: 0x7ffab0c7c9b0
        public void .cctor(){} // RVA: 0x7ffab0c7cb80
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffab0c7c700
    }

    /// <summary>Originally: ÏÌÌÎÏÎÎÎÎÌÌÎÏÏÍÎÏÍÏÏÏÎÏ</summary>
    public class VRCNetworkBehaviourSiblingSibling_5803 : Object
    {
        public object _value; // 0x33F94A10, was: ÌÎÎÌÎÍÏÌÍÍÎÏÌÌÏÌÎÏÏÌÎÍÍ
        public object _name; // 0x33F94A10, was: ÌÍÌÍÎÏÏÏÌÍÍÌÎÍÍÏÍÍÎÎÌÍÎ
        public object f_86F; // 0x33F94A10, was: ÏÎÌÏÎÍÍÎÎÎÍÌÍÏÏÏÍÏÏÏÌÏÍ
        public object `;

        // ── Original Methods ──
        public void op_Implicit(){} // RVA: 0x7ffaa9f0b890
        public void CompareBaseObjects(){} // RVA: 0x7ffaa9f0b8d0
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa9f0b910
        public void set_name(){} // RVA: 0x7ffaa9f0bf30
        public void Instantiate(){} // RVA: 0x7ffaa9f0bf70
        public void Equals(){} // RVA: 0x7ffaa9f0bfa0
        public void System.IDisposable.Dispose(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa9f0c060
        public void ToString(){} // RVA: 0x7ffaa9f0c460
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa9f0b800
        public void Getradius(){} // RVA: 0x7ffaa9f0b840
        public void Getposition_Injected(){} // RVA: 0x7ffaa9f0b850
        public void GetCachedPtr(){} // RVA: 0x7ffaa9f0b9c0
        public void DoInverseTransformPoint_Injected_834(){} // RVA: 0x7ffaa9f0ba70
        public void DoInverseTransformPoint_Injected_290(){} // RVA: 0x7ffaa9f0c360
        public void GetTransform_DB8(){} // RVA: 0x7ffaa9f0c3a0
        public void GetHashCode(){} // RVA: 0x7ffaa8932310
    }

    /// <summary>Originally: ÍÍÎÌÍÎÎÍÏÎÎÎÎÍÎÍÍÌÌÎÏÎÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_68B8 : Object
    {
        public object _objectIsNullMessage; // 0x33FC46B0, was: ÏÎÍÎÏÎÎÍÏÍÍÎÌÎÌÎÎÍÎÌÍÎÎ
        public object _name; // 0x33FC4830, was: ÏÍÍÏÏÍÍÏÏÍÍÎÌÏÏÌÏÌÏÎÍÏÌ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9fb0f20
        public void op_Implicit(){} // RVA: 0x7ffaa9fb0fd0
        public void CompareBaseObjects(){} // RVA: 0x7ffaa9fb0ff0
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa9fb1010
        public void get_name(){} // RVA: 0x7ffaa9fb1050
        public void OnOperationResponse_impl(){} // RVA: 0x7ffaa9fb1070
        public void Instantiate(){} // RVA: 0x7ffaa9fb1180
        public void Equals(){} // RVA: 0x7ffaa9fb11a0
        public void ToString(){} // RVA: 0x7ffaa9fb11e0
        public void InitializeNetworkInt(){} // RVA: 0x7ffaa9fb1200
        public void InitializeNetworkInt2(){} // RVA: 0x7ffaa9fb1220
        // ── Binary Analysis Named ──
        public void DoInverse_Injected_42C(){} // RVA: 0x7ffaa9fb0f90
        public void Getposition_Injected(){} // RVA: 0x7ffaa9fb0fb0
        public void GetCachedPtr(){} // RVA: 0x7ffaa9fb1030
        public void GetHashCode(){} // RVA: 0x7ffaa9fb11c0
        public void DoLookRotation_Injected_976(){} // RVA: 0x7ffaa9fb1240
    }

    /// <summary>Originally: ÌÎÍÎÎÎÏÎÍÎÌÏÏÌÌÌÍÌÏÍÌÎÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_7324
    {
        // ── Obfuscated Methods ──
        public void m_361(){} // RVA: 0x7ffaa8660d80
    }

    /// <summary>Originally: ÏÏÍÏÏÍÌÎÍÎÎÎÏÌÌÏÎÌÎÍÌÍÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_7C32 : Object
    {
        public object _amount; // 0x33FDF0C0, was: ÌÍÌÌÌÍÏÌÌÎÌÏÎÎÏÏÍÍÎÎÎÌÎ
        public object _amount2; // 0x33FDF0C0, was: ÎÏÏÍÌÌÎÏÌÌÌÍÎÍÏÎÍÌÏÍÍÌÏ
        public object _amount3; // 0x33FDF0C0, was: ÌÌÌÌÎÏÍÌÎÏÌÏÏÍÎÏÍÍÎÎÏÍÍ
        public object _amount4; // 0x33FDF0C0, was: ÍÌÍÍÏÍÌÌÌÏÍÌÌÌÍÏÏÎÏÏÌÏÎ
        public object _amount5; // 0x33FDF0C0, was: ÌÏÌÎÏÏÍÎÌÎÌÍÎÍÏÌÏÍÍÏÏÏÎ

        // ── Original Methods ──
        public void DestroyImmediate(){} // RVA: 0x7ffaaa0815d0
        public void get_currentScale(){} // RVA: 0x7ffaa9168110
        public void ComputeMagnitude(){} // RVA: 0x7ffaa8a11210
        public void get_match(){} // RVA: 0x7ffaa9fe53d0
        public void get_name(){} // RVA: 0x7ffaaa081180
        public void get_height(){} // RVA: 0x7ffaa893a970
        public void Instantiate(){} // RVA: 0x7ffaaa081200
        public void get_preferredPeakBitRate(){} // RVA: 0x7ffaa8af93a0
        public void get_scale(){} // RVA: 0x7ffaa8e22440
        public void ToString(){} // RVA: 0x7ffaaa081430
        public void .ctor(){} // RVA: 0x7ffaaa081660
        public void Initialize(){} // RVA: 0x7ffaaa0814e0
        public void Equals(){} // RVA: 0x7ffaaa081530
        public void CalculateNetworkInterpolation(){} // RVA: 0x7ffaaa081550
        public void Destroy(){} // RVA: 0x7ffaa894d380
        public void DestroyImmediate(){} // RVA: 0x7ffaaa0815d0
        public void FindObjectsOfType(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaaa081660
        public void FindObjectsByType(){} // RVA: 0x7ffaaa081630
        public void .ctor(){} // RVA: 0x7ffaaa081660
        public void .ctor(){} // RVA: 0x7ffaaa081660
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa894d380
        public void GetHashCode(){} // RVA: 0x7ffaaa081100
        public void GetCachedPtr(){} // RVA: 0x7ffaaa081120
        public void GetMaxHealth(){} // RVA: 0x7ffaa895b080
        public void GetNetworkPropertyDouble(){} // RVA: 0x7ffaaa081590
        public void GetNetworkPropertyFloat(){} // RVA: 0x7ffaaa0815b0
        public void GetCurrentHealth(){} // RVA: 0x7ffaa8a9ff50
        // ── Obfuscated Methods ──
        public void m_620(){} // RVA: 0x7ffaa894d380
    }

    /// <summary>Originally: ÍÎÍÏÎÎÌÎÏÎÍÎÏÏÏÌÏÌÌÌÍÌÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_807A : ValueType
    {
        public object _code; // 0x33FC4830, was: ÏÌÏÏÎÎÏÏÏÎÏÏÍÎÍÎÎÌÎÎÎÎÍ

        // ── Original Methods ──
        public void DefaultEquals(){} // RVA: 0x7ffaa9fb1420
        public void InternalGetHashCode(){} // RVA: 0x7ffaa9fb15a0
        public void Equals(){} // RVA: 0x7ffaa9fb1660
        // ── Binary Analysis Named ──
        public void DoLookRotation_Injected_0EE(){} // RVA: 0x7ffaa9fb12a0
        public void DoLookRotation_Injected_AAB(){} // RVA: 0x7ffaa9fb1360
        public void DoLookRotation_Injected_D10(){} // RVA: 0x7ffaa9fb14e0
    }

    /// <summary>Originally: ÎÎÎÏÏÌÎÏÏÏÎÌÌÌÎÌÌÍÎÍÎÌÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_831B : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa930eb30
        public void InternalEquals(){} // RVA: 0x7ffaa930eb60
        public void DefaultEquals(){} // RVA: 0x7ffaa930eba0
        public void InternalGetHashCode(){} // RVA: 0x7ffaa930ec40
        public void ToString(){} // RVA: 0x7ffaa930ec60
        public void .ctor(){} // RVA: 0x7ffaa930eca0
        public void Initialize(){} // RVA: 0x7ffaa930ed00
        public void ProcessNetworkBindings(){} // RVA: 0x7ffaa930ed40
        public void PerformNetworkBehaviorUpdate(){} // RVA: 0x7ffaa9311080
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa930ec20
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa930ec80
        public void GetInternalValue208(){} // RVA: 0x7ffaa9311160
        public void DoResolveBindings(){} // RVA: 0x7ffaa9311080
        public void GetInternalValue112(){} // RVA: 0x7ffaa9311390
        public void GetInternalValue144(){} // RVA: 0x7ffaa930ed00
        public void GetInternalValue176(){} // RVA: 0x7ffaa93113b0
        public void GetInternalValue160(){} // RVA: 0x7ffaa93113d0
        public void GetInternalValue128(){} // RVA: 0x7ffaa93113f0
        public void GetInternalValue168(){} // RVA: 0x7ffaa9311430
        public void GetInternalValue200(){} // RVA: 0x7ffaa9311450
        public void Doremove_canceled(){} // RVA: 0x7ffaa9311490
        // ── 18 Obfuscated Methods ──
        public void m_CDF(){} // RVA: 0x7ffaa930ed20
        public void m_623(){} // RVA: 0x7ffaa930ec80
        public void m_0B7(){} // RVA: 0x7ffaa9311040
        public void m_322(){} // RVA: 0x7ffaa9311060
        public void m_D3D(){} // RVA: 0x7ffaa9311100
        // ... 13 more obfuscated methods
    }

    /// <summary>Originally: ÌÍÌÍÌÎÍÎÏÏÏÍÍÌÏÍÎÍÎÎÎÍÏ</summary>
    public class VRCNetworkBehaviourSiblingSibling_86B4 : Object
    {
        // ── Original Methods ──
        public void set_name(){} // RVA: 0x7ffaa9e020f0
        public void get_name(){} // RVA: 0x7ffaa9e023d0
        public void Initialize(){} // RVA: 0x7ffaa9e02440
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetGameObject_ED3(){} // RVA: 0x7ffaa9e02010
        public void GetCachedPtr(){} // RVA: 0x7ffaa9e02260
        public void DoInitializeArray(){} // RVA: 0x7ffaa9e025b0
    }

    /// <summary>Originally: ÌÍÌÍÌÎÍÎÏÏÏÍÍÌÏÍÎÍÎÎÎÍÏ</summary>
    public class VRCNetworkBehaviourSiblingSibling_86B4 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Initialize(){} // RVA: 0x7ffab10269e0
        public void get_name(){} // RVA: 0x7ffab1026d10
        public void set_name(){} // RVA: 0x7ffab1026d80
        // ── Binary Analysis Named ──
        public void SetActive_AC6(){} // RVA: 0x7ffab1026820
        public void GetGameObject_ED3(){} // RVA: 0x7ffab1026890
        public void DoInitializeArray(){} // RVA: 0x7ffab1026970
        public void SetActive_FCE(){} // RVA: 0x7ffab1026ac0
        public void GetCachedPtr(){} // RVA: 0x7ffab1026ba0
    }

    /// <summary>Originally: ÌÍÏÌÌÏÍÏÌÌÍÎÍÏÏÎÏÎÌÌÍÎÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_AF12 : Object
    {
        public object _objectIsNullMessage; // 0x315D0A60, was: ÏÌÎÏÎÌÍÌÎÍÍÌÍÏÌÏÍÏÌÍÎÌÌ
        public object _name; // 0x17000CCE, was: ÎÎÌÏÌÏÏÎÎÎÏÏÍÍÌÌÍÎÍÏÏÍÎ

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa8660d80
        public void op_Implicit(){} // RVA: 0x7ffaa887e5c0
        public void CompareBaseObjects(){} // RVA: 0x7ffaa8660d80
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa887e5c0
        public void get_name(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void Initialize(){} // RVA: 0x7ffaa8660d80
        public void Instantiate(){} // RVA: 0x7ffaa86491d0
        public void ToString(){} // RVA: 0x7ffaa8660d80
        public void FailFast(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa86491d0
        public void GetHashCode(){} // RVA: 0x7ffaa8660d80
        public void GetCachedPtr(){} // RVA: 0x7ffaa8660d80
        public void GetSiblingBehavior(){} // RVA: 0x7ffaa8660d80
        public void GetNetworkBehavior(){} // RVA: 0x7ffaa8660d80
    }

    /// <summary>Originally: ÎÌÏÌÏÌÌÎÏÏÍÌÏÏÏÌÌÏÏÍÎÎÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_B5F2 : Object
    {
        public object _isPowerOfTwo; // 0x34034400, was: ÌÏÌÏÍÍÏÎÎÌÍÏÌÍÏÍÍÏÌÎÏÏÏ
        public object _name; // 0xB3FA17E0, was: ÎÍÎÎÌÍÍÎÎÏÍÏÎÏÍÌÎÏÍÏÏÎÌ

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa8c0eba0
        public void Finalize(){} // RVA: 0x7ffaa8c0ec30
        public void CompareBaseObjects(){} // RVA: 0x7ffaa8c0ec90
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa8c0eca0
        public void get_name(){} // RVA: 0x7ffaa8c0ef10
        public void set_name(){} // RVA: 0x7ffaa8c0efa0
        public void Instantiate(){} // RVA: 0x7ffaa8c0efd0
        public void ToString(){} // RVA: 0x7ffaa8c0f000
        public void HandleNetworkMessage(){} // RVA: 0x7ffaa8c0f090
        public void ResetAndHandleNetworkBehaviour(){} // RVA: 0x7ffaa8c0eb00
        public void ProcessNetworkState(){} // RVA: 0x7ffaa8c0f1e0
        public void .ctor(){} // RVA: 0x7ffaa8c0f2b0
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa8c0eb00
        public void GetgameObject(){} // RVA: 0x7ffaa8c0eb70
        public void GetCachedPtr(){} // RVA: 0x7ffaa8c0eec0
        public void GetHashCode(){} // RVA: 0x7ffaa8c0ec90
        public void GetInternalPropertyValue(){} // RVA: 0x7ffaa8c0f040
    }

    /// <summary>Originally: ÎÍÎÎÍÌÏÏÏÏÍÌÏÏÎÍÏÍÏÏÍÌÍ</summary>
    public class VRCNetworkBehaviourSiblingSibling_CEBB
    {
        // ── Obfuscated Methods ──
        public void m_C53(){} // RVA: 0x7ffaa8660d80
    }

    /// <summary>Originally: ÌÍÎÏÌÏÍÌÍÌÏÎÍÌÌÌÎÌÍÍÌÎÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_D3F6
    {
        // ── Original Methods ──
        public void IsNetworkSiblingFlagged(){} // RVA: 0x7ffaa864a040
        public void InvokeNetworkSiblingMethodWithArgs(){} // RVA: 0x7ffaa8669e70
        public void InvokeNetworkSiblingMethod(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetNetworkSiblingValue(){} // RVA: 0x7ffaa8648be0
        public void GetNetworkSiblingValue(){} // RVA: 0x7ffaa86491d0
        // ── Obfuscated Methods ──
        public void m_B72(){} // RVA: 0x7ffaa864a040
        public void m_808(){} // RVA: 0x7ffaa8660cc0
        public void m_F85(){} // RVA: 0x7ffaa864a040
        public void m_0F6(){} // RVA: 0x7ffaa8660d80
        public void m_B1F(){} // RVA: 0x7ffaa86491d0
        public void m_A37(){} // RVA: 0x7ffaa8660d80
    }

    /// <summary>Originally: ÎÏÎÌÍÏÍÏÏÏÎÍÏÏÌÎÎÍÍÎÎÍÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_D4AF
    {
        // ── Binary Analysis Named ──
        public void GetNetworkSiblingValue(){} // RVA: 0x7ffaa887e5c0
    }

    /// <summary>Originally: ÎÏÎÌÍÏÍÏÏÏÎÍÏÏÌÎÎÍÍÎÎÍÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_D4AF
    {
        // ── Binary Analysis Named ──
        public void GetNetworkSiblingValue(){} // RVA: 0x7ffaa86491d0
    }

    /// <summary>Originally: ÎÏÎÌÍÏÍÏÏÏÎÍÏÏÌÎÎÍÍÎÎÍÌ</summary>
    public class VRCNetworkBehaviourSiblingSibling_D4AF
    {
        // ── Binary Analysis Named ──
        public void GetNetworkSiblingValue(){} // RVA: 0x7ffaa86491d0
    }

    /// <summary>Originally: ÌÍÎÍÏÌÏÎÌÌÏÎÍÎÎÏÏÍÎÎÍÎÎ</summary>
    public class VRCNetworkBehaviourSiblingSibling_D67F : Object
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa92d9da0
        public void op_Implicit(){} // RVA: 0x7ffaa92d9da0
        public void CompareBaseObjects(){} // RVA: 0x7ffaa92d9da0
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaa92d9da0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Initialize(){} // RVA: 0x7ffaa92d9da0
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa92d9da0
        public void GetHashCode(){} // RVA: 0x7ffaa92d9da0
        public void GetCachedPtr(){} // RVA: 0x7ffaa92d9da0
    }

    /// <summary>Originally: ÏÍÌÏÏÏÌÎÍÏÍÌÎÏÍÍÍÌÎÌÌÎÏ</summary>
    public class VRCNetworkBehaviourSiblingSibling_E243 : Object
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa9aa72b0
        public void op_Implicit(){} // RVA: 0x7ffaa9aa7370
        public void CompareBaseObjects(){} // RVA: 0x7ffaa9aa73d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Initialize(){} // RVA: 0x7ffaa9aa7430
        public void set_name(){} // RVA: 0x7ffaa9aa74f0
        public void Instantiate(){} // RVA: 0x7ffaa9aa7550
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa9aa7250
        public void GetHashCode(){} // RVA: 0x7ffaa9aa7310
        public void SetActive_A92(){} // RVA: 0x7ffaa9aa7490
    }

}