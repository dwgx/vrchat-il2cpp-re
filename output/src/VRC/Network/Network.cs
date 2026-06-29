// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Network
// Classes: 54
// Methods: 1012

namespace VRC.Network
{
    /// <summary>Originally: ÎÌÎÍÌÎÎÍÍÌÎÍÌÍÌÎÌÎÍÌÌÎÍ</summary>
    public class FlatBufferNetworkSerializer : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7A83FF160
        public void Awake(){} // RVA: 0x7A83FC390
        public void Decode(){} // RVA: 0x7A8401590
        public void CanProcessDataPart(){} // RVA: 0x7A83FCAD0
        public void CanSerialize32Bit(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7A83FF250
        public void Initialize(){} // RVA: 0x7A83FF930
        public void Reset(){} // RVA: 0x7A8400430
        public void NeedsSync(){} // RVA: 0x7A8401410
        public void SerializedName(){} // RVA: 0x7A8401430
        public void set_UseDirectPoseCodec(){} // RVA: 0x7A84017D0
        public void get_UseDirectPoseCodec(){} // RVA: 0x7A8401420
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7A84017E0
        public void CanSerialize8Bit(){} // RVA: 0x7A81BD750
        public void set_TypeId(){} // RVA: 0x7A84018E0
        public void get_TypeId(){} // RVA: 0x7A8401A30
        public void Start(){} // RVA: 0x7A8402920
        public void NeedsImportant(){} // RVA: 0x7A81BD750
        public void OnDestroy(){} // RVA: 0x7A8403740
        // ── 22 unresolved (hash) ──
        public void m_715(){} // RVA: 0x7A83FC090
        public void m_B10(){} // RVA: 0x7A83FC2A0
        public void m_F23(){} // RVA: 0x7A83FC340
        public void m_A1A(){} // RVA: 0x7A80D7320
        public void m_144(){} // RVA: 0x7A83FC760
        // ... 17 more unresolved methods
    }

    /// <summary>Originally: ÏÍÌÌÌÎÌÍÍÌÌÌÏÎÏÌÎÌÏÎÎÎÏ</summary>
    public class FlatBufferNetworkSerializerSibSibling_2850
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7A7E18800
        public void Deserialize(){} // RVA: 0x7A7E18C30
        public void Read(){} // RVA: 0x7A7E18770
        public void Write(){} // RVA: 0x7A7E18770
    }

    /// <summary>Originally: ÍÍÏÎÏÏÌÎÌÌÏÏÎÎÌÍÍÎÏÎÎÎÍ</summary>
    public class FlatBufferNetworkSerializerSibSibling_74EA : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A83F8E80
        public void Equals(){} // RVA: 0x7A83F8F80
        public void GetHashCode(){} // RVA: 0x7A83F9AA0
        public void op_Implicit(){} // RVA: 0x7A83F9D60
        public void CompareBaseObjects(){} // RVA: 0x7A83FA1D0
        public void Dispose(){} // RVA: 0x7A83FA640
        public void Cleanup(){} // RVA: 0x7A8154D80
        public void get_name(){} // RVA: 0x7A83FA8F0
        public void set_name(){} // RVA: 0x7A83FA910
        public void Instantiate(){} // RVA: 0x7A83FAA10
        public void Destroy(){} // RVA: 0x7A83FAE90
        public void .ctor(){} // RVA: 0x7A83FAEE0
        public void Initialize(){} // RVA: 0x7A80FF440
        public void FindObjectsByType(){} // RVA: 0x7A83FB820
        public void DontDestroyOnLoad(){} // RVA: 0x7A83FBDB0
        public void get_hideFlags(){} // RVA: 0x7A818F860
        public void set_hideFlags(){} // RVA: 0x7A83FA8F0
        public void FindObjectOfType(){} // RVA: 0x7A818F850
        public void FindFirstObjectByType(){} // RVA: 0x7A83FBDE0
    }

    /// <summary>Originally: ÍÌÎÌÍÍÍÏÎÍÎÎÌÎÎÌÏÌÎÌÏÌÌ</summary>
    public class FlatBufferNetworkSerializerSibling_980A : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A80D7310
        public void Equals(){} // RVA: 0x7A83F47F0
        public void GetHashCode(){} // RVA: 0x7A82A20A0
        public void .ctor(){} // RVA: 0x7A83F5820
        public void Initialize(){} // RVA: 0x7A8105A90
        public void IsNativeObjectAlive(){} // RVA: 0x7A82A2C90
        public void GetCachedPtr(){} // RVA: 0x7A83F5990
        public void get_name(){} // RVA: 0x7A83F59B0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void Cleanup(){} // RVA: 0x7A83F69F0
        public void Destroy(){} // RVA: 0x7A83F69F0
        public void DestroyImmediate(){} // RVA: 0x7A83F6A00
        public void FindObjectsOfType(){} // RVA: 0x7A80D7310
        public void FindObjectsByType(){} // RVA: 0x7A82A2C90
        public void DontDestroyOnLoad(){} // RVA: 0x7A83F5990
        public void get_hideFlags(){} // RVA: 0x7A83F5990
        public void set_hideFlags(){} // RVA: 0x7A83F5990
    }

    /// <summary>Originally: ÎÎÎÎÏÌÌÎÌÍÌÌÎÍÏÌÎÌÍÏÌÏÏ</summary>
    public class NetworkCancelRPCComponent_4A51 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7A8E8D460
        public void RaiseCancellation(){} // RVA: 0x7A8E8D5B0
        public void IsInvoking(){} // RVA: 0x7A8E8D6E0
        public void CancelInvoke(){} // RVA: 0x7A8E8D6F0
        public void OnDestroy(){} // RVA: 0x7A8E8DD00
        public void InvokeRepeating(){} // RVA: 0x7A80D7320
        public void Awake(){} // RVA: 0x7A8E8DD50
        public void StartCoroutine_Auto(){} // RVA: 0x7A8E8DD60
        public void StopCoroutine(){} // RVA: 0x7A8E8DD00
        public void .ctor(){} // RVA: 0x7A8E8DDB0
        public void Initialize(){} // RVA: 0x7A8E8DE10
        public void set_useGUILayout(){} // RVA: 0x7A8E8DF10
        public void print(){} // RVA: 0x7A8E8E140
        public void Internal_CancelInvokeAll(){} // RVA: 0x7A8E8E400
        public void Internal_IsInvokingAll(){} // RVA: 0x7A8E8E540
        public void InvokeDelayed(){} // RVA: 0x7A8E8E560
        public void IsObjectMonoBehaviour(){} // RVA: 0x7A8E8E820
        public void StartCoroutineManaged(){} // RVA: 0x7A8E8EF80
        public void StartCoroutineManaged2(){} // RVA: 0x7A8E8D6E0
        public void StopCoroutineManaged(){} // RVA: 0x7A8E8F080
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7A8E8DD60
        public void CancelRPC(){} // RVA: 0x7A8E8F220
        public void OnCancellationTokenCreated(){} // RVA: 0x7A8E8F320
        public void OnTriggerExit(){} // RVA: 0x7A8E8F6D0
        // ── Unresolved (hash) ──
        public void m_86C(){} // RVA: 0x7A8E8F7D0
        public void m_619(){} // RVA: 0x7A8E8F7E0
        public void m_986(){} // RVA: 0x7A8E8F800
    }

    /// <summary>Originally: ÌÎÌÎÍÏÌÎÌÍÍÌÏÏÌÏÌÍÌÌÎÎÏ</summary>
    public class NetworkDeserializeImplementationSerializeImplem_BEEC : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A82D1140
        public void DeserializeImplementation(){} // RVA: 0x7A82D1270
        public void GetUninitializedObject(){} // RVA: 0x7A82D1450
        public void .ctor(){} // RVA: 0x7A82D1460
        public void SerializeImplementation(){} // RVA: 0x7A82D14C0
    }

    /// <summary>Originally: ÎÌÎÎÍÎÎÌÍÎÎÍÏÎÎÌÏÏÏÍÌÎÌ</summary>
    public class NetworkDisposeAsyncImplSibling_2597
    {
        // ── Unresolved (hash) ──
        public void m_A3D(){} // RVA: 0x7A7E00680
        public void m_BFA(){} // RVA: 0x7A7E00680
        public void m_97C(){} // RVA: 0x7A7E18770
        public void m_3E5(){} // RVA: 0x7A7E00710
        public void m_C5E(){} // RVA: 0x7A7E00680
    }

    /// <summary>Originally: ÏÎÎÎÍÌÍÌÎÏÏÌÍÌÍÎÎÌÍÏÍÎÍ</summary>
    public class NetworkDisposeAsyncImplSibling_DBF2
    {
        // ── Unresolved (hash) ──
        public void m_C6C(){} // RVA: 0x7A7E00680
        public void m_23D(){} // RVA: 0x7A7E18800
        public void m_80C(){} // RVA: 0x7A7E18800
        public void m_C5E(){} // RVA: 0x7A7E00680
    }

    /// <summary>Originally: ÏÎÍÎÍÌÎÌÌÍÌÌÍÏÌÎÏÌÍÏÎÍÌ</summary>
    public class NetworkDisposeAsyncImplSibling_E255
    {
        // ── Unresolved (hash) ──
        public void m_C6C(){} // RVA: 0x7A7E00680
        public void m_02F(){} // RVA: 0x7A7E00710
        public void m_72C(){} // RVA: 0x7A7E00680
        public void m_D8F(){} // RVA: 0x7A7E00680
        public void m_1A6(){} // RVA: 0x7A7E1D590
        public void m_23D(){} // RVA: 0x7A7E18800
        public void m_80C(){} // RVA: 0x7A7E18800
        public void m_C5E(){} // RVA: 0x7A7E00680
    }

    /// <summary>Originally: ÏÍÎÏÍÏÍÎÏÎÍÍÌÌÎÌÍÌÎÎÏÌÍ</summary>
    public class NetworkDisposeAsyncImpl_53CB : NetworkDisposeAsync_122A
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A997E3D0
        public void Initialize(){} // RVA: 0x7A997E410
        // ── 20 unresolved (hash) ──
        public void m_1A6(){} // RVA: 0x7A997DAD0
        public void m_47A(){} // RVA: 0x7A997DC50
        public void m_A1C(){} // RVA: 0x7A997DD90
        public void m_C6C(){} // RVA: 0x7A997DDA0
        public void m_6A1(){} // RVA: 0x7A997DF40
        // ... 15 more unresolved methods
    }

    /// <summary>Originally: ÌÌÏÏÏÏÍÏÏÌÎÍÌÍÏÍÎÏÌÏÌÌÍ</summary>
    public class NetworkDisposeAsyncImpl_5E9C : NetworkDisposeAsync_122A
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8F8C970
        // ── 12 unresolved (hash) ──
        public void m_97C(){} // RVA: 0x7A9018210
        public void m_B0B(){} // RVA: 0x7A9018320
        public void m_A1A(){} // RVA: 0x7A9018430
        public void m_1E5(){} // RVA: 0x7A90185D0
        public void m_BFA(){} // RVA: 0x7A90185E0
        // ... 7 more unresolved methods
    }

    /// <summary>Originally: ÏÏÏÎÎÏÍÍÌÎÏÏÎÍÍÍÏÌÍÏÎÍÏ</summary>
    public class NetworkDisposeAsyncImpl_5F32 : NetworkDisposeAsync_122A
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8F8C970
        // ── 11 unresolved (hash) ──
        public void m_C5E(){} // RVA: 0x7A9986AB0
        public void m_977(){} // RVA: 0x7A9986AC0
        public void m_63B(){} // RVA: 0x7A9986AB0
        public void m_681(){} // RVA: 0x7A9986AB0
        public void m_F2B(){} // RVA: 0x7A9986AB0
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÏÍÍÏÍÎÍÏÎÏÍÌÌÍÏÍÌÍÍÎÍÌÍ</summary>
    public class NetworkDisposeAsyncImpl_6971 : NetworkDisposeAsync_122A
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8F8C970
        public void Initialize(){} // RVA: 0x7A997F420
        // ── 12 unresolved (hash) ──
        public void m_CCC(){} // RVA: 0x7A997ED30
        public void m_C6C(){} // RVA: 0x7A997EDD0
        public void m_0B1(){} // RVA: 0x7A997EF70
        public void m_80C(){} // RVA: 0x7A997EF80
        public void m_BB5(){} // RVA: 0x7A997F030
        // ... 7 more unresolved methods
    }

    /// <summary>Originally: ÎÏÏÏÎÌÎÏÌÍÏÍÍÏÍÎÌÏÏÏÏÌÍ</summary>
    public class NetworkDisposeAsyncImpl_B157 : NetworkDisposeAsync_122A
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8F8C970
        public void Initialize(){} // RVA: 0x7A8F8C980
        // ── Unresolved (hash) ──
        public void m_A03(){} // RVA: 0x7A8F8C630
        public void m_8E1(){} // RVA: 0x7A8F8C7D0
        public void m_D3F(){} // RVA: 0x7A8F8CB20
        public void m_31A(){} // RVA: 0x7A8F8CCC0
        public void m_DBF(){} // RVA: 0x7A8F8CE60
        public void m_C5E(){} // RVA: 0x7A8F8D000
    }

    /// <summary>Originally: ÍÌÍÍÏÎÌÌÍÌÎÏÌÍÌÌÎÌÎÌÏÌÍ</summary>
    public class NetworkDisposeAsyncSibling_4298
    {
        // ── Unresolved (hash) ──
        public void m_47A(){} // RVA: 0x7A7E00710
        public void m_431(){} // RVA: 0x7A7E00710
        public void m_252(){} // RVA: 0x7A7E00680
        public void m_8E2(){} // RVA: 0x7A7E00490
        public void m_696(){} // RVA: 0x7A7E00490
        public void m_DAE(){} // RVA: 0x7A7E00490
        public void m_C5E(){} // RVA: 0x7A7E00680
    }

    /// <summary>Originally: ÌÏÌÎÍÌÏÌÏÌÍÏÍÎÏÍÏÌÌÌÍÏÍ</summary>
    public class NetworkDisposeAsyncSibling_F8DA
    {
        // ── Unresolved (hash) ──
        public void m_3E1(){} // RVA: 0x7A7E00680
        public void m_880(){} // RVA: 0x7A7E00680
        public void m_C37(){} // RVA: 0x7A7E00680
    }

    /// <summary>Originally: ÏÏÌÌÏÏÌÏÎÌÍÏÌÏÎÏÌÎÌÌÏÎÎ</summary>
    public class NetworkDisposeAsync_122A : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7A813E420
        public void GetHashCode(){} // RVA: 0x7A81C68D0
        public void op_Implicit(){} // RVA: 0x7A81C68E0
        public void CompareBaseObjects(){} // RVA: 0x7A997F670
        public void IsNativeObjectAlive(){} // RVA: 0x7A997F780
        public void GetCachedPtr(){} // RVA: 0x7A997F890
        public void get_name(){} // RVA: 0x7A997F9A0
        public void set_name(){} // RVA: 0x7A997FB80
        public void Instantiate(){} // RVA: 0x7A997FD20
        public void Destroy(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A997FEF0
        public void Initialize(){} // RVA: 0x7A9980030
        public void Dispose(){} // RVA: 0x7A9980180
        public void DisposeAsync(){} // RVA: 0x7A9980200
        public void Finalize(){} // RVA: 0x7A9980390
    }

    /// <summary>Originally: ÌÏÍÍÏÏÎÎÍÏÍÏÍÏÎÌÏÏÌÏÏÏÎ</summary>
    public class NetworkDisposeAsync_7DD9 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A8105330
        public void .ctor(){} // RVA: 0x7A8C83920
        public void Initialize(){} // RVA: 0x7A81052D0
        public void op_Implicit(){} // RVA: 0x7A8C841B0
        public void CompareBaseObjects(){} // RVA: 0x7A8C842E0
        public void IsNativeObjectAlive(){} // RVA: 0x7A8C843A0
        public void GetCachedPtr(){} // RVA: 0x7A8C84600
        public void get_name(){} // RVA: 0x7A80D8E80
        public void DisposeAsync(){} // RVA: 0x7A8C84730
        public void Instantiate(){} // RVA: 0x7A80D8E80
        public void Destroy(){} // RVA: 0x7A8C848C0
        public void DestroyImmediate(){} // RVA: 0x7A8C84980
        public void FindObjectsOfType(){} // RVA: 0x7A8C84BE0
        public void Dispose(){} // RVA: 0x7A8C84E50
        public void Cleanup(){} // RVA: 0x7A8C84EF0
        public void get_hideFlags(){} // RVA: 0x7A81052C0
        public void set_hideFlags(){} // RVA: 0x7A8C84F90
        public void Finalize(){} // RVA: 0x7A8C851F0
        public void FindFirstObjectByType(){} // RVA: 0x7A8C853E0
        public void CheckNullArgument(){} // RVA: 0x7A8C854A0
    }

    /// <summary>Originally: ÍÌÌÌÎÏÍÎÎÍÎÎÏÎÌÎÍÍÏÎÎÎÏ</summary>
    public class NetworkEnableMeshRPCSetPresetRPCComponent_8409 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7A87FA130
        public void SetPresetRPC(){} // RVA: 0x7A87FA7E0
        public void IsInvoking(){} // RVA: 0x7A87FA870
        public void CancelInvoke(){} // RVA: 0x7A87FAB30
        public void Invoke(){} // RVA: 0x7A87FAD60
        public void InvokeRepeating(){} // RVA: 0x7A87FB410
        public void StartCoroutine(){} // RVA: 0x7A87FB6D0
        public void StartCoroutine_Auto(){} // RVA: 0x7A87FBA00
        public void EnableMeshRPC(){} // RVA: 0x7A87FBB80
        public void Pickup(){} // RVA: 0x7A87FBD00
        public void get_useGUILayout(){} // RVA: 0x7A87FBF30
        public void Use(){} // RVA: 0x7A87FC260
        public void print(){} // RVA: 0x7A87FC590
        public void Drop(){} // RVA: 0x7A87FC6C0
        public void Start(){} // RVA: 0x7A87FC980
        public void InvokeDelayed(){} // RVA: 0x7A87FCBD0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    /// <summary>Originally: ÎÎÌÎÌÍÍÍÌÌÎÌÎÎÍÍÌÌÏÏÌÌÏ</summary>
    public class NetworkEnumeratorContainsSibling_2C44
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7A7E01900
        public void get_Current(){} // RVA: 0x7A7E01900
        // ── 18 unresolved (hash) ──
        public void m_E75(){} // RVA: 0x7A7E01900
        public void m_744(){} // RVA: 0x7A7E01900
        public void m_607(){} // RVA: 0x7A7E01900
        public void m_B07(){} // RVA: 0x7A7E01900
        public void m_AB1(){} // RVA: 0x7A7E01900
        // ... 13 more unresolved methods
    }

    /// <summary>Originally: ÍÎÍÏÎÌÍÌÍÌÍÍÍÌÎÌÎÍÌÌÌÌÎ</summary>
    public class NetworkInternalApplyOverrideRPCPlayerJoinedHandler_3DEC : MonoBehaviour
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7A9462870
        public void Start(){} // RVA: 0x7A9462980
        public void Awake(){} // RVA: 0x7A9462D70
        public void InternalApplyOverrideRPC(){} // RVA: 0x7A9463170
        public void Invoke(){} // RVA: 0x7A9463590
        public void InvokeRepeating(){} // RVA: 0x7A94637A0
        public void StartCoroutine(){} // RVA: 0x7A94638B0
        public void StartCoroutine_Auto(){} // RVA: 0x7A9463B50
        public void StopCoroutine(){} // RVA: 0x7A9464120
        public void StopAllCoroutines(){} // RVA: 0x7A94644B0
        public void .ctor(){} // RVA: 0x7A9464750
        public void Initialize(){} // RVA: 0x7A9464820
        public void print(){} // RVA: 0x7A9464E00
        public void Internal_CancelInvokeAll(){} // RVA: 0x7A9464F90
        public void OnPlayerJoined(){} // RVA: 0x7A9465190
    }

    /// <summary>Originally: ÏÍÌÍÎÏÌÏÍÌÌÎÌÎÍÌÏÏÍÍÎÍÎ</summary>
    public class NetworkReadyHandlerImplSibling_AFC4
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7A7E00680
        public void Process(){} // RVA: 0x7A7E00680
        public void OnReceive(){} // RVA: 0x7A7E00680
        public void OnEvent(){} // RVA: 0x7A7E00680
    }

    /// <summary>Originally: ÏÍÎÌÏÌÎÍÍÏÎÎÏÍÎÏÏÌÏÏÍÌÏ</summary>
    public class NetworkReadyHandlerImpl_9267 : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7A9165BC0
        public void Reset(){} // RVA: 0x7A9165EB0
        public void Awake(){} // RVA: 0x7A9167B10
        public void .cctor(){} // RVA: 0x7A9169000
        public void .ctor(){} // RVA: 0x7A9169420
        public void Initialize(){} // RVA: 0x7A9169660
        // ── 29 unresolved (hash) ──
        public void m_FBA(){} // RVA: 0x7A9165BB0
        public void m_3C2(){} // RVA: 0x7A9165E00
        public void m_634(){} // RVA: 0x7A9165E50
        public void m_0E3(){} // RVA: 0x7A9165EA0
        public void m_9F5(){} // RVA: 0x7A91663C0
        // ... 24 more unresolved methods
    }

    /// <summary>Originally: ÏÎÌÏÍÍÌÎÌÎÍÌÍÏÎÎÎÍÏÏÎÏÎ</summary>
    public class NetworkReadyHandlerRelated_9374 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A8B42BF0
        public void Equals(){} // RVA: 0x7A8B43360
        public void GetHashCode(){} // RVA: 0x7A8B435F0
        public void op_Implicit(){} // RVA: 0x7A8B43660
        public void CompareBaseObjects(){} // RVA: 0x7A8B43B10
        public void IsNativeObjectAlive(){} // RVA: 0x7A8B43F80
        public void GetCachedPtr(){} // RVA: 0x7A8B448B0
        public void .cctor(){} // RVA: 0x7A8B44980
    }

    /// <summary>Originally: ÌÎÌÌÍÍÏÌÎÌÌÏÎÎÎÏÏÎÏÏÏÎÌ</summary>
    public class NetworkReadyHandler_031C : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7A8F27320
        public void OnDestroy(){} // RVA: 0x7A8F26C90
        public void .ctor(){} // RVA: 0x7A8F295D0
        public void Initialize(){} // RVA: 0x7A8F29860
        public void .cctor(){} // RVA: 0x7A8F29960
        public void OnNetworkReady(){} // RVA: 0x7A8F2C130
        public void LateUpdate(){} // RVA: 0x7A8F2C4A0
        // ── 32 unresolved (hash) ──
        public void m_AF8(){} // RVA: 0x7A8F23FD0
        public void m_DF4(){} // RVA: 0x7A8F24190
        public void m_F30(){} // RVA: 0x7A8F242C0
        public void m_80B(){} // RVA: 0x7A80D7320
        public void m_1D0(){} // RVA: 0x7A8F26C00
        // ... 27 more unresolved methods
    }

    /// <summary>Originally: ÌÏÌÏÍÍÍÎÌÍÍÍÍÎÏÏÍÎÎÍÏÍÎ</summary>
    public class NetworkReadyHandler_0A13 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7A9467450
        public void RaiseCancellation(){} // RVA: 0x7A9467A30
        public void IsInvoking(){} // RVA: 0x7A9467F60
        public void CancelInvoke(){} // RVA: 0x7A80D7310
        public void OnNetworkReady(){} // RVA: 0x7A9467FF0
        public void InvokeRepeating(){} // RVA: 0x7A9468000
        public void StartCoroutine(){} // RVA: 0x7A9468080
        public void StartCoroutine_Auto(){} // RVA: 0x7A9468330
        public void SetAvatarUse(){} // RVA: 0x7A9468590
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void OnDestroy(){} // RVA: 0x7A9468710
        public void set_useGUILayout(){} // RVA: 0x7A9468840
        public void Awake(){} // RVA: 0x7A94688E0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7A94688E0
        public void Update(){} // RVA: 0x7A9468910
        public void InvokeDelayed(){} // RVA: 0x7A9468A40
        public void IsObjectMonoBehaviour(){} // RVA: 0x7A9468A50
        public void Start(){} // RVA: 0x7A9468CF0
        public void RefreshAvatar(){} // RVA: 0x7A9469370
        public void StopCoroutineManaged(){} // RVA: 0x7A9101D40
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7A9469920
        public void GetScriptClassName(){} // RVA: 0x7A9469B90
        public void OnCancellationTokenCreated(){} // RVA: 0x7A9469CC0
        public void OnBecameInvisible(){} // RVA: 0x7A9469DA0
        public void OnCollisionEnter(){} // RVA: 0x7A946A420
        public void OnCollisionStay(){} // RVA: 0x7A9101D40
    }

    /// <summary>Originally: ÌÍÍÌÎÍÏÍÌÍÎÎÍÏÎÎÌÍÏÍÌÍÏ</summary>
    public class NetworkReadyHandler_3FBA : WorldProximityExitStation_7D8E
    {
        // ── Methods ──
        public void OnNetworkReady(){} // RVA: 0x7A94D3200
        public void .ctor(){} // RVA: 0x7A94D4210
        public void Initialize(){} // RVA: 0x7A94D4260
        // ── Unresolved (hash) ──
        public void m_DEC(){} // RVA: 0x7A94D2210
        public void m_325(){} // RVA: 0x7A94D2760
        public void m_290(){} // RVA: 0x7A94D2CB0
        public void m_6A7(){} // RVA: 0x7A94D3220
        public void m_BEA(){} // RVA: 0x7A94D3770
        public void m_D52(){} // RVA: 0x7A94D3CC0
        public void m_A47(){} // RVA: 0x7A94D47B0
        public void m_513(){} // RVA: 0x7A94D4D00
    }

    /// <summary>Originally: ÌÌÏÎÎÎÌÎÍÎÌÌÏÍÌÌÌÍÍÏÍÌÎ</summary>
    public class NetworkReadyHandler_494C : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7A950DCC0
        public void RaiseCancellation(){} // RVA: 0x7A950E100
        public void .cctor(){} // RVA: 0x7A950E130
        public void CancelInvoke(){} // RVA: 0x7A950E210
        public void Awake(){} // RVA: 0x7A950E8C0
        public void InvokeRepeating(){} // RVA: 0x7A950EE80
        public void StartCoroutine(){} // RVA: 0x7A950F340
        public void StartCoroutine_Auto(){} // RVA: 0x7A9510070
        public void StopCoroutine(){} // RVA: 0x7A9510170
        public void StopAllCoroutines(){} // RVA: 0x7A95102B0
        public void get_useGUILayout(){} // RVA: 0x7A9510510
        public void OnEnable(){} // RVA: 0x7A95106E0
        public void print(){} // RVA: 0x7A9510880
        public void Internal_CancelInvokeAll(){} // RVA: 0x7A9510D40
        public void OnDisable(){} // RVA: 0x7A9510F60
        public void InvokeDelayed(){} // RVA: 0x7A9511100
        public void IsObjectMonoBehaviour(){} // RVA: 0x7A9511240
        public void StartCoroutineManaged(){} // RVA: 0x7A9511420
        public void StartCoroutineManaged2(){} // RVA: 0x7A9511980
        public void StopCoroutineManaged(){} // RVA: 0x7A95119B0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7A9511AF0
        public void GetScriptClassName(){} // RVA: 0x7A9511F80
        public void Start(){} // RVA: 0x7A9511FB0
        public void Update(){} // RVA: 0x7A9513A30
        public void OnDestroy(){} // RVA: 0x7A9513BF0
        public void OnTriggerEnter(){} // RVA: 0x7A9514450
        public void OnTriggerStay(){} // RVA: 0x7A9514620
        public void OnTriggerExit(){} // RVA: 0x7A9514680
        public void OnSpawn(){} // RVA: 0x7A95146A0
        public void OnApplicationQuit(){} // RVA: 0x7A95146D0
        public void OnBecameVisible(){} // RVA: 0x7A9514810
        public void OnBecameInvisible(){} // RVA: 0x7A9514680
        public void OnCollisionEnter(){} // RVA: 0x7A9515540
        public void OnCollisionStay(){} // RVA: 0x7A9515B40
        public void OnNetworkReady(){} // RVA: 0x7A9515B70
        public void .ctor(){} // RVA: 0x7A95164B0
        // ── Unresolved (hash) ──
        public void m_E20(){} // RVA: 0x7A9515E80
        public void m_753(){} // RVA: 0x7A9516460
    }

    /// <summary>Originally: ÏÍÎÎÍÎÍÎÎÍÏÏÏÍÍÎÏÌÌÍÎÌÎ</summary>
    public class NetworkReadyHandler_5724 : WorldProximityExitStation_7D8E
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A94CE1F0
        public void ProvideEvents(){} // RVA: 0x7A94CE240
        public void OnNetworkReady(){} // RVA: 0x7A94CEB20
        // ── Unresolved (hash) ──
        public void m_A2A(){} // RVA: 0x7A94CB4F0
        public void m_B72(){} // RVA: 0x7A94CCB70
        public void m_094(){} // RVA: 0x7A94CE6A0
        public void m_1C0(){} // RVA: 0x7A94CEB40
        public void m_845(){} // RVA: 0x7A94CEFA0
        public void m_9F9(){} // RVA: 0x7A94D0610
        public void m_19D(){} // RVA: 0x7A94D0A90
    }

    /// <summary>Originally: ÎÍÎÍÌÏÎÍÎÎÍÌÏÏÌÎÌÌÍÌÏÎÍ</summary>
    public class NetworkReadyHandler_6CE9 : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7A91064B0
        public void RaiseCancellation(){} // RVA: 0x7A81C68D0
        public void IsInvoking(){} // RVA: 0x7A81C68E0
        public void CancelInvoke(){} // RVA: 0x7A8105330
        public void Invoke(){} // RVA: 0x7A80D8E80
        public void InvokeRepeating(){} // RVA: 0x7A9106590
        public void StartCoroutine(){} // RVA: 0x7A80D7310
        public void OnEnable(){} // RVA: 0x7A9106680
        public void Awake(){} // RVA: 0x7A82393C0
        public void Start(){} // RVA: 0x7A91066F0
        public void get_useGUILayout(){} // RVA: 0x7A9106790
        public void set_useGUILayout(){} // RVA: 0x7A9106830
        public void print(){} // RVA: 0x7AA0626F0
        public void OnNetworkReady(){} // RVA: 0x7A9107390
        public void Internal_IsInvokingAll(){} // RVA: 0x7A9107570
        public void InvokeDelayed(){} // RVA: 0x7A91076F0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7A91079A0
        public void StartCoroutineManaged(){} // RVA: 0x7A8154D80
        public void StartCoroutineManaged2(){} // RVA: 0x7A80FF440
        public void StopCoroutineManaged(){} // RVA: 0x7A9107AB0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7A9107AB0
        public void GetScriptClassName(){} // RVA: 0x7A9107AC0
        public void OnCancellationTokenCreated(){} // RVA: 0x7A9107AD0
        public void OnTriggerExit(){} // RVA: 0x7A818F850
        public void OnTriggerStay(){} // RVA: 0x7A818F860
        public void .ctor(){} // RVA: 0x7A80D7D60
        // ── Unresolved (hash) ──
        public void m_E01(){} // RVA: 0x7A9107BC0
        public void m_212(){} // RVA: 0x7A9107BD0
        public void m_566(){} // RVA: 0x7A9107BE0
        public void m_2F1(){} // RVA: 0x7A8178B90
        public void m_4B2(){} // RVA: 0x7A8230620
    }

    /// <summary>Originally: ÌÎÌÍÎÎÏÌÌÏÎÍÌÌÎÍÌÏÏÌÌÎÎ</summary>
    public class NetworkShouldBroadcastInstigator_175F : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A81052C0
        public void get_Sender(){} // RVA: 0x7A8355950
        public void Equals(){} // RVA: 0x7A8261690
        public void op_Implicit(){} // RVA: 0x7A916EA20
        public void CompareBaseObjects(){} // RVA: 0x7A916EAD0
        public void .ctor(){} // RVA: 0x7A916EB30
        public void DeepClone(){} // RVA: 0x7A916EB40
        public void ToString(){} // RVA: 0x7A916ED40
        public void set_name(){} // RVA: 0x7A916F230
        public void Instantiate(){} // RVA: 0x7A916F2E0
        public void Destroy(){} // RVA: 0x7A916F340
        public void DestroyImmediate(){} // RVA: 0x7A8355950
        public void FindObjectsOfType(){} // RVA: 0x7A8668BC0
        public void FindObjectsByType(){} // RVA: 0x7A916F2E0
        public void DontDestroyOnLoad(){} // RVA: 0x7A916EA20
        public void get_hideFlags(){} // RVA: 0x7A916F430
        public void set_Time(){} // RVA: 0x7A916F4E0
        public void get_Time(){} // RVA: 0x7A916F5C0
        public void set_Serialize(){} // RVA: 0x7A916F6B0
        public void get_Serialize(){} // RVA: 0x7A916F710
        public void GetHashCode(){} // RVA: 0x7A916F7C0
        public void op_Equality(){} // RVA: 0x7A916F880
        public void op_Inequality(){} // RVA: 0x7A8105330
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7A83782A0
        public void get_Instigator(){} // RVA: 0x7A83782A0
        public void set_Sender(){} // RVA: 0x7A83F4180
        public void set_Instigator(){} // RVA: 0x7A916F6B0
        public void set_Store(){} // RVA: 0x7A916EA20
        public void get_Store(){} // RVA: 0x7A916F940
        public void get_ShouldBroadcast(){} // RVA: 0x7A916FA40
    }

    /// <summary>Originally: ÍÎÏÏÌÏÏÍÏÏÏÌÎÎÍÏÍÍÏÎÏÎÍ</summary>
    public class NetworkSyncableSiblingSibling_1B4F : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Initialize(){} // RVA: 0x7A80F2570
        public void op_Implicit(){} // RVA: 0x7A80F2570
        public void CompareBaseObjects(){} // RVA: 0x7A80D8E20
        public void IsNativeObjectAlive(){} // RVA: 0x7A80DA7B0
        public void GetCachedPtr(){} // RVA: 0x7A80F2570
        public void get_name(){} // RVA: 0x7A80D8E20
        public void set_name(){} // RVA: 0x7A80D8E20
        public void Instantiate(){} // RVA: 0x7A80F2570
        public void Destroy(){} // RVA: 0x7A813E420
        public void DestroyImmediate(){} // RVA: 0x7A80D8E20
    }

    /// <summary>Originally: ÌÏÌÏÍÌÌÌÏÍÌÍÍÎÎÎÏÏÌÍÎÌÌ</summary>
    public class NetworkSyncableSibling_14E2 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A8387EA0
        public void Equals(){} // RVA: 0x7A838A740
        public void GetHashCode(){} // RVA: 0x7A838ACA0
        public void op_Implicit(){} // RVA: 0x7A838AD50
        public void CompareBaseObjects(){} // RVA: 0x7A838ADF0
        public void IsNativeObjectAlive(){} // RVA: 0x7A838AE40
        public void GetCachedPtr(){} // RVA: 0x7A838AEF0
        public void get_name(){} // RVA: 0x7A838AF90
        public void set_name(){} // RVA: 0x7A838B040
        public void Instantiate(){} // RVA: 0x7A838B0E0
        public void Destroy(){} // RVA: 0x7A838B190
        public void DestroyImmediate(){} // RVA: 0x7A838B230
        public void FindObjectsOfType(){} // RVA: 0x7A838B2E0
        public void FindObjectsByType(){} // RVA: 0x7A838B3D0
        public void DontDestroyOnLoad(){} // RVA: 0x7A838B480
        public void get_hideFlags(){} // RVA: 0x7A838B530
        public void set_hideFlags(){} // RVA: 0x7A838B5E0
        public void FindObjectOfType(){} // RVA: 0x7A838B690
        public void FindFirstObjectByType(){} // RVA: 0x7A838B730
        public void CheckNullArgument(){} // RVA: 0x7A838B7D0
        public void ToString(){} // RVA: 0x7A838B880
        public void op_Equality(){} // RVA: 0x7A838B930
        public void op_Inequality(){} // RVA: 0x7A838B9E0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7A838BA90
        public void Internal_CloneSingle(){} // RVA: 0x7A838BB40
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7A838BBF0
        public void Internal_InstantiateSingle(){} // RVA: 0x7A838BCA0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7A838BD50
        public void GetName(){} // RVA: 0x7A838BE00
        public void SetName(){} // RVA: 0x7A838BEA0
        public void FindObjectFromInstanceID(){} // RVA: 0x7A838BF50
        public void ForceLoadFromInstanceID(){} // RVA: 0x7A838BFF0
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7A838C280
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7A838C430
        // ── Unresolved (hash) ──
        public void m_B83(){} // RVA: 0x7A838C0A0
        public void m_AE2(){} // RVA: 0x7A838C1C0
        public void m_753(){} // RVA: 0x7A838C4E0
        public void m_77E(){} // RVA: 0x7A838C6F0
        public void m_7E8(){} // RVA: 0x7A838C7A0
        public void m_201(){} // RVA: 0x7A838C9B0
        public void m_028(){} // RVA: 0x7A838CA60
        public void m_F9C(){} // RVA: 0x7A838CC70
        public void m_D01(){} // RVA: 0x7A838CD20
    }

    /// <summary>Originally: ÌÏÎÎÍÍÏÌÏÍÍÌÌÍÌÍÎÍÌÎÏÎÌ</summary>
    public class NetworkSyncableSibling_75E6
    {
        // ── Unresolved (hash) ──
        public void m_83C(){} // RVA: 0x7A7E00680
        public void m_88F(){} // RVA: 0x7A7E18800
        public void m_DAC(){} // RVA: 0x7A7E18800
        public void m_7CB(){} // RVA: 0x7A7E01900
        public void m_467(){} // RVA: 0x7A7E18C30
    }

    /// <summary>Originally: ÎÎÏÎÏÏÍÏÍÏÍÏÍÎÍÌÎÍÌÎÌÎÍ</summary>
    public class NetworkSyncableSibling_DA7F : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A80D8E20
        public void Equals(){} // RVA: 0x7B10FF0F0
        public void GetHashCode(){} // RVA: 0x7B10FF1B0
        public void op_Implicit(){} // RVA: 0x7B10FF270
        public void CompareBaseObjects(){} // RVA: 0x7B10FF350
        public void IsNativeObjectAlive(){} // RVA: 0x7A80F2570
        public void .cctor(){} // RVA: 0x7B10FF420
        public void get_name(){} // RVA: 0x7B10FF500
        public void .ctor(){} // RVA: 0x7B10FF5D0
        public void Initialize(){} // RVA: 0x7B10FF6F0
        public void Destroy(){} // RVA: 0x7B10FF7C0
        public void DestroyImmediate(){} // RVA: 0x7A80D8E20
        public void FindObjectsOfType(){} // RVA: 0x7B10FF890
        public void FindObjectsByType(){} // RVA: 0x7B10FF960
        public void DontDestroyOnLoad(){} // RVA: 0x7A80F2570
        public void get_hideFlags(){} // RVA: 0x7A80D8E20
    }

    /// <summary>Originally: ÎÎÏÍÌÌÌÏÍÏÎÎÏÍÍÎÌÍÌÏÌÏÏ</summary>
    public class NetworkSyncable_267B : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void Update(){} // RVA: 0x7A8C4F5D0
        public void NeedsImportant(){} // RVA: 0x7A80D7320
        public void Decode(){} // RVA: 0x7A8C4FDB0
        public void CanSerialize32Bit(){} // RVA: 0x7A81BD750
        public void set_TypeId(){} // RVA: 0x7A8C4FDF0
        public void CanSerialize8Bit(){} // RVA: 0x7A80D7320
        public void get_TypeId(){} // RVA: 0x7A8C50BC0
        public void SerializedName(){} // RVA: 0x7A8C511A0
        public void Start(){} // RVA: 0x7A8C522A0
        public void Encode(){} // RVA: 0x7A8C52FB0
        public void .ctor(){} // RVA: 0x7A8C52810
        public void NeedsSync(){} // RVA: 0x7A81A00C0
        public void OnDestroy(){} // RVA: 0x7A8C52BF0
        // ── 22 unresolved (hash) ──
        public void m_0C5(){} // RVA: 0x7A8C4F2C0
        public void m_80B(){} // RVA: 0x7A8C4F390
        public void m_7B4(){} // RVA: 0x7A8C4F610
        public void m_7D2(){} // RVA: 0x7A8C4F680
        public void m_BA8(){} // RVA: 0x7A8C4FBD0
        // ... 17 more unresolved methods
    }

    /// <summary>Originally: ÍÏÍÍÍÍÎÍÌÌÏÌÌÏÎÍÍÍÍÍÎÏÏ</summary>
    public class NetworkSyncable_A848 : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7A94E44D0
        public void Encode(){} // RVA: 0x7A94E91E0
        public void CanSerialize32Bit(){} // RVA: 0x7A80D7320
        public void NeedsSync(){} // RVA: 0x7A81BD750
        public void SerializedName(){} // RVA: 0x7A94E53B0
        public void Decode(){} // RVA: 0x7A94E6A20
        public void .ctor(){} // RVA: 0x7A94E5550
        public void Initialize(){} // RVA: 0x7A94E44D0
        public void CanSerialize8Bit(){} // RVA: 0x7A81BD750
        public void set_TypeId(){} // RVA: 0x7A94E5B90
        public void Start(){} // RVA: 0x7A94E6980
        public void get_TypeId(){} // RVA: 0x7A8842E60
        public void NeedsImportant(){} // RVA: 0x7A80D7320
        public void Awake(){} // RVA: 0x7A94E8A20
        // ── 14 unresolved (hash) ──
        public void m_929(){} // RVA: 0x7A94E44D0
        public void m_B13(){} // RVA: 0x7A94E5700
        public void m_1C8(){} // RVA: 0x7A94E5210
        public void m_F1C(){} // RVA: 0x7A94E5250
        public void m_86C(){} // RVA: 0x7A94E59B0
        // ... 9 more unresolved methods
    }

    /// <summary>Originally: ÏÎÏÎÌÏÎÌÌÍÎÏÏÏÏÍÍÏÎÏÌÎÎ</summary>
    public class NetworkSyncable_A87F : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void CanSerialize8Bit(){} // RVA: 0x7A80D7320
        public void NeedsSync(){} // RVA: 0x7A8153980
        public void Decode(){} // RVA: 0x7A83B2350
        public void Start(){} // RVA: 0x7A83B2820
        public void .ctor(){} // RVA: 0x7A83B28C0
        public void Initialize(){} // RVA: 0x7A83B2A50
        public void OnEnable(){} // RVA: 0x7A83B2AB0
        public void NeedsImportant(){} // RVA: 0x7A8153980
        public void Encode(){} // RVA: 0x7A83B3300
        public void SerializedName(){} // RVA: 0x7A83B2E50
        public void CanSerialize32Bit(){} // RVA: 0x7A81BD750
        public void OnDisable(){} // RVA: 0x7A83B2E90
        public void set_TypeId(){} // RVA: 0x7A83B38F0
        public void OnDestroy(){} // RVA: 0x7A83B2DC0
        public void get_TypeId(){} // RVA: 0x7A83B4040
        // ── 18 unresolved (hash) ──
        public void m_464(){} // RVA: 0x7A80D7320
        public void m_3DB(){} // RVA: 0x7A83B1890
        public void m_C13(){} // RVA: 0x7A83B18D0
        public void m_1D0(){} // RVA: 0x7A83B1A30
        public void m_206(){} // RVA: 0x7A83B1C10
        // ... 13 more unresolved methods
    }

    /// <summary>Originally: ÎÍÏÎÌÎÍÏÌÏÎÌÎÏÍÌÎÌÏÎÌÌÍ</summary>
    public class NetworkSyncable_F112 : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void GenerateComponentInfo(){} // RVA: 0x7A83DCB10
        public void Start(){} // RVA: 0x7A83DD020
        public void Decode(){} // RVA: 0x7A83DE1A0
        public void .ctor(){} // RVA: 0x7A83DD2E0
        public void Initialize(){} // RVA: 0x7A83DD490
        public void Awake(){} // RVA: 0x7A83DD890
        public void set_UniqueHash(){} // RVA: 0x7A83DD8C0
        public void get_UniqueHash(){} // RVA: 0x7A83DE350
        public void NeedsSync(){} // RVA: 0x7A83DE360
        public void NeedsImportant(){} // RVA: 0x7A80D7320
        public void SerializedName(){} // RVA: 0x7A83DF890
        public void Encode(){} // RVA: 0x7A83E07D0
        public void set_TypeId(){} // RVA: 0x7A83E0410
        public void OnDestroy(){} // RVA: 0x7A83DC780
        public void get_TypeId(){} // RVA: 0x7A83E0880
        public void CanSerialize8Bit(){} // RVA: 0x7A83E0CD0
        public void CanSerialize32Bit(){} // RVA: 0x7A81BD750
        public void CanUsePersistenceHashes(){} // RVA: 0x7A83E1710
        // ── 26 unresolved (hash) ──
        public void m_CFB(){} // RVA: 0x7A83DC5E0
        public void m_D66(){} // RVA: 0x7A83DC780
        public void m_1DB(){} // RVA: 0x7A81C68E0
        public void m_923(){} // RVA: 0x7A83DC7D0
        public void m_428(){} // RVA: 0x7A83DC8C0
        // ... 21 more unresolved methods
    }

    /// <summary>Originally: ÏÏÍÍÎÍÌÎÍÏÎÏÎÎÌÏÎÏÍÏÎÎÌ</summary>
    public class PhotonConnectionHandlerSibling_2CF9 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A80F2570
        public void Equals(){} // RVA: 0x7A8154D80
        public void GetHashCode(){} // RVA: 0x7A80FF440
        public void op_Implicit(){} // RVA: 0x7A8175DF0
        public void CompareBaseObjects(){} // RVA: 0x7A80D8E80
        public void IsNativeObjectAlive(){} // RVA: 0x7A8152D90
        public void GetCachedPtr(){} // RVA: 0x7A8152D80
        public void get_name(){} // RVA: 0x7A8154D80
        public void set_name(){} // RVA: 0x7A88C4B10
        public void Instantiate(){} // RVA: 0x7A8105A90
        public void Destroy(){} // RVA: 0x7A8154D80
        public void DestroyImmediate(){} // RVA: 0x7A813E420
        public void FindObjectsOfType(){} // RVA: 0x7A83F69F0
        public void FindObjectsByType(){} // RVA: 0x7A88C4B60
        public void DontDestroyOnLoad(){} // RVA: 0x7A81052C0
        public void get_hideFlags(){} // RVA: 0x7A81BD750
        public void set_hideFlags(){} // RVA: 0x7A8296DE0
        public void FindObjectOfType(){} // RVA: 0x7A80D7310
        public void FindFirstObjectByType(){} // RVA: 0x7A8175E00
        public void CheckNullArgument(){} // RVA: 0x7A8178B90
        public void ToString(){} // RVA: 0x7A8292C30
        public void .ctor(){} // RVA: 0x7A88C4BA0
        public void Initialize(){} // RVA: 0x7A80D8E20
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7A8296DE0
        public void Internal_CloneSingle(){} // RVA: 0x7A81A0050
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7A80D8E20
        public void Internal_InstantiateSingle(){} // RVA: 0x7A81052D0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7A8175E00
        public void GetName(){} // RVA: 0x7A8105A90
        public void SetName(){} // RVA: 0x7A8230620
        public void FindObjectFromInstanceID(){} // RVA: 0x7A8152D80
        public void ForceLoadFromInstanceID(){} // RVA: 0x7A81A0060
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7A8105330
        // ── Unresolved (hash) ──
        public void m_944(){} // RVA: 0x7A80DA7B0
        public void m_0EB(){} // RVA: 0x7A80D8E80
    }

    /// <summary>Originally: ÏÍÎÏÎÍÍÌÌÎÎÏÏÌÎÍÍÌÍÌÏÌÏ</summary>
    public class PhotonConnectionHandlerSibling_B41C
    {
        // ── 17 unresolved (hash) ──
        public void m_48A(){} // RVA: 0x7A7E00680
        public void m_94F(){} // RVA: 0x7A7E00680
        public void m_944(){} // RVA: 0x7A7E00680
        public void m_C05(){} // RVA: 0x7A7E00680
        public void m_9F5(){} // RVA: 0x7A7E00680
        // ... 12 more unresolved methods
    }

    /// <summary>Originally: ÎÏÌÍÏÌÍÎÌÌÌÌÌÍÍÏÏÏÍÏÍÏÍ</summary>
    public class PhotonConnectionHandler_66A6
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7A7E18770
        public void OnConnectedToMaster(){} // RVA: 0x7A7E18770
        public void Process(){} // RVA: 0x7A7E189D0
        public void OnReceive(){} // RVA: 0x7A7E18800
        public void OnCustomAuthenticationResponse(){} // RVA: 0x7A7E18800
        public void OnCustomAuthenticationFailed(){} // RVA: 0x7A7E18800
    }

    /// <summary>Originally: ÎÌÌÎÏÎÍÌÍÌÍÌÍÏÏÌÏÍÏÌÏÎÍ</summary>
    public class PhotonConnectionHandler_DC2D : List`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7A986DB90
        public void get_Capacity(){} // RVA: 0x7A986DEB0
        public void set_Capacity(){} // RVA: 0x7A986E290
        public void OnCustomAuthenticationResponse(){} // RVA: 0x7A986E510
        public void OnConnectedToMaster(){} // RVA: 0x7A986E820
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7A986EAA0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A80D7310
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A986EE20
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A986F200
        public void get_Item(){} // RVA: 0x7A986F5E0
        public void OnCustomAuthenticationFailed(){} // RVA: 0x7A986F860
        public void IsCompatibleObject(){} // RVA: 0x7A986FBE0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7A986FF00
        public void .ctor(){} // RVA: 0x7A9870280
        public void Initialize(){} // RVA: 0x7A9870340
    }

    /// <summary>Originally: ÎÍÎÍÎÏÎÍÎÌÍÎÎÏÎÎÍÌÍÌÎÏÏ</summary>
    public class PhotonConnectionHandler_F9DD : MonoBehaviour
    {
        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7A90897C0
        public void RaiseCancellation(){} // RVA: 0x7A9089900
        public void IsInvoking(){} // RVA: 0x7A9089940
        public void CancelInvoke(){} // RVA: 0x7A8A08E60
        public void Invoke(){} // RVA: 0x7A90899C0
        public void InvokeRepeating(){} // RVA: 0x7A908AA00
        public void StartCoroutine(){} // RVA: 0x7A908AAA0
        public void StartCoroutine_Auto(){} // RVA: 0x7A908AC50
        public void Awake(){} // RVA: 0x7A908CAB0
        public void StopAllCoroutines(){} // RVA: 0x7A908CCA0
        public void get_useGUILayout(){} // RVA: 0x7A908CEC0
        public void set_useGUILayout(){} // RVA: 0x7A908CFC0
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void Initialize(){} // RVA: 0x7A908EC00
        public void Internal_IsInvokingAll(){} // RVA: 0x7A908F140
        public void InvokeDelayed(){} // RVA: 0x7A908F940
        public void IsObjectMonoBehaviour(){} // RVA: 0x7A908F980
        public void StartCoroutineManaged(){} // RVA: 0x7A908FA30
        public void OnDestroy(){} // RVA: 0x7A908FA90
        public void StopCoroutineManaged(){} // RVA: 0x7A90901E0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7A90902E0
        public void GetScriptClassName(){} // RVA: 0x7A90903F0
        public void OnCancellationTokenCreated(){} // RVA: 0x7A90904B0
        public void OnDisable(){} // RVA: 0x7A9090760
        public void OnTriggerStay(){} // RVA: 0x7A90907C0
        public void OnTriggerExit(){} // RVA: 0x7A9090880
        public void OnTriggerEnter(){} // RVA: 0x7A9090A10
        public void OnConnectedToMaster(){} // RVA: 0x7A9090A20
        public void OnCustomAuthenticationFailed(){} // RVA: 0x7A9090BD0
        public void OnCollisionEnter(){} // RVA: 0x7A9090D70
        public void OnCollisionStay(){} // RVA: 0x7A8178B70
        public void Start(){} // RVA: 0x7A9090DC0
        public void Update(){} // RVA: 0x7A9090E60
        public void OnEnable(){} // RVA: 0x7A9090F20
        public void LateUpdate(){} // RVA: 0x7A9090F80
        public void FixedUpdate(){} // RVA: 0x7A9091110
        public void OnApplicationPause(){} // RVA: 0x7A90912E0
        public void OnApplicationQuit(){} // RVA: 0x7A9091400
        public void OnBecameVisible(){} // RVA: 0x7A8178B80
        public void OnBecameInvisible(){} // RVA: 0x7A9091850
        public void OnCollisionExit(){} // RVA: 0x7A9091CC0
        // ── Unresolved (hash) ──
        public void m_036(){} // RVA: 0x7A8A092E0
        public void m_408(){} // RVA: 0x7A9091960
        public void m_D58(){} // RVA: 0x7A9091B30
        public void m_BE5(){} // RVA: 0x7A90924C0
        public void m_485(){} // RVA: 0x7A8178B70
        public void m_94F(){} // RVA: 0x7A9092530
    }

    /// <summary>Originally: ÍÌÎÏÏÏÏÌÌÍÍÌÌÎÌÏÌÍÏÏÎÌÍ</summary>
    public class PhotonHashtableDerived_B3A4 : PhotonHashtable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B2AE0
    }

    /// <summary>Originally: ÎÍÎÎÍÏÌÌÏÏÎÎÎÏÌÍÍÎÌÍÎÌÍ</summary>
    public class PhotonMasterHandler_145B : ConnectionHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A983DE60
        public void FixedUpdate(){} // RVA: 0x7A983DF40
        public void .cctor(){} // RVA: 0x7A983E360
        public void LateUpdate(){} // RVA: 0x7A983E5C0
        public void OnMasterClientSwitched(){} // RVA: 0x7A80D7310
        public void OnApplicationFocus(){} // RVA: 0x7A80D7310
        public void OnApplicationPause(){} // RVA: 0x7A80D7310
        public void Start(){} // RVA: 0x7A983E900
        public void OnJoinedRoom(){} // RVA: 0x7A80D7310
        public void OnLeftRoom(){} // RVA: 0x7A80D7310
        public void OnDisable(){} // RVA: 0x7A983EDB0
        public void Awake(){} // RVA: 0x7A983EE10
        public void OnDestroy(){} // RVA: 0x7A80D7310
        public void OnCreatedRoom(){} // RVA: 0x7A80D7310
        public void OnEnable(){} // RVA: 0x7A983F360
        // ── 11 unresolved (hash) ──
        public void m_AD4(){} // RVA: 0x7A80D7310
        public void m_C84(){} // RVA: 0x7A80D7310
        public void m_F31(){} // RVA: 0x7A80D7310
        public void m_01E(){} // RVA: 0x7A80D7310
        public void m_F24(){} // RVA: 0x7A80D7310
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÌÎÌÏÍÏÎÌÍÌÎÏÏÍÎÌÏÎÏÍÍÍÎ</summary>
    public class PhotonMasterHandler_AAAC
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7A7E18800
        public void Process(){} // RVA: 0x7A7E18800
        public void OnReceive(){} // RVA: 0x7A7E18800
        public void OnEvent(){} // RVA: 0x7A7E18890
        public void OnMasterClientSwitched(){} // RVA: 0x7A7E18800
    }

    /// <summary>Originally: ÎÍÏÍÍÏÌÏÌÍÏÌÌÏÍÌÎÏÎÎÏÌÏ</summary>
    public class PhotonMasterHandler_C125 : List`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7A98731E0
        public void .ctor(){} // RVA: 0x7A98734E0
        public void Initialize(){} // RVA: 0x7A98735A0
        public void get_Count(){} // RVA: 0x7A98738A0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7A9873B90
        public void OnMasterClientSwitched(){} // RVA: 0x7A9873E90
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A9874190
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A9874450
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A9874750
        public void get_Item(){} // RVA: 0x7A9874A10
        public void set_Item(){} // RVA: 0x7A9874D00
        public void IsCompatibleObject(){} // RVA: 0x7A9875000
        public void System.Collections.IList.get_Item(){} // RVA: 0x7A9875300
        public void System.Collections.IList.set_Item(){} // RVA: 0x7A98755F0
    }

    /// <summary>Originally: ÎÍÏÏÏÎÎÍÍÏÎÌÎÏÏÏÌÎÍÌÌÌÎ</summary>
    public class PhotonRoomHandlerSibling_44D7 : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7A81052C0
        public void Equals(){} // RVA: 0x7A813E420
        public void GetHashCode(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7A88F28F0
        public void Initialize(){} // RVA: 0x7A81052C0
        public void IsNativeObjectAlive(){} // RVA: 0x7A81052D0
        public void GetCachedPtr(){} // RVA: 0x7A88F2AA0
        public void get_name(){} // RVA: 0x7A80DA7B0
        public void set_name(){} // RVA: 0x7A81052D0
        public void Instantiate(){} // RVA: 0x7A88F2AC0
        public void Destroy(){} // RVA: 0x7A80F2570
        public void DestroyImmediate(){} // RVA: 0x7A813E420
        public void FindObjectsOfType(){} // RVA: 0x7A81052C0
        public void FindObjectsByType(){} // RVA: 0x7A88F2BB0
        public void DontDestroyOnLoad(){} // RVA: 0x7A80D8E20
        public void get_hideFlags(){} // RVA: 0x7A88F2CA0
    }

    /// <summary>Originally: ÌÌÏÎÎÎÌÎÌÏÍÍÏÎÌÍÎÍÏÌÏÎÌ</summary>
    public class PhotonRoomHandlerSibling_718B
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7A7E18800
        public void Process(){} // RVA: 0x7A7E18800
        public void OnReceive(){} // RVA: 0x7A7E00680
        public void OnEvent(){} // RVA: 0x7A7E00680
        // ── Unresolved (hash) ──
        public void m_902(){} // RVA: 0x7A7E00680
    }

    /// <summary>Originally: ÍÌÏÍÌÎÏÍÌÌÍÎÍÍÎÍÌÌÍÎÏÍÌ</summary>
    public class PhotonRoomHandler_88A4 : List`1
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7A9870660
        public void get_Capacity(){} // RVA: 0x7A9870A70
        public void set_Capacity(){} // RVA: 0x7A9870E80
        public void OnJoinedRoom(){} // RVA: 0x7A9871100
        public void OnCreatedRoom(){} // RVA: 0x7A9871380
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7A9871600
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7A9871A10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A9871C90
        public void OnLeftRoom(){} // RVA: 0x7A9871F80
        public void get_Item(){} // RVA: 0x7A9872200
        public void set_Item(){} // RVA: 0x7A9872480
        public void IsCompatibleObject(){} // RVA: 0x7A9872770
        public void System.Collections.IList.get_Item(){} // RVA: 0x7A9872A90
        public void .ctor(){} // RVA: 0x7A9872EA0
        public void Initialize(){} // RVA: 0x7A9872F60
    }

    /// <summary>Originally: ÏÎÏÎÏÌÏÎÏÍÎÌÌÌÏÎÍÍÏÎÏÌÎ</summary>
    public class PhotonRoomHandler_8F6F
    {
        // ── Methods ──
        public void Handle(){} // RVA: 0x7A7E18800
        public void OnCreatedRoom(){} // RVA: 0x7A7E18770
        public void Process(){} // RVA: 0x7A7E1A5A0
        public void OnJoinedRoom(){} // RVA: 0x7A7E18770
        public void OnReceive(){} // RVA: 0x7A7E1A5A0
        public void OnEvent(){} // RVA: 0x7A7E1A5A0
        public void OnLeftRoom(){} // RVA: 0x7A7E18770
    }

    /// <summary>Originally: ÎÏÌÎÍÎÍÍÍÌÎÎÌÌÎÍÎÎÍÌÎÏÏ</summary>
    public class VRCNetworkBehaviour : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void Initialize(){} // RVA: 0x7A7E18800
        public void SerializedName(){} // RVA: 0x7A95094B0
        public void set_TypeId(){} // RVA: 0x7A9509610
        public void get_TypeId(){} // RVA: 0x7A95096B0
        public void CanSerialize8Bit(){} // RVA: 0x7A81BD750
        public void CanSerialize32Bit(){} // RVA: 0x7A80D7320
        public void Decode(){} // RVA: 0x7A950C7E0
        public void Awake(){} // RVA: 0x7A950B190
        public void OnNetworkReady(){} // RVA: 0x7A950B1D0
        public void Start(){} // RVA: 0x7A950B250
        public void OnDestroy(){} // RVA: 0x7A950B2F0
        public void Update(){} // RVA: 0x7A950B330
        public void LateUpdate(){} // RVA: 0x7A950B930
        public void OnDisable(){} // RVA: 0x7A8051B10
        public void OnApplicationPause(){} // RVA: 0x7A950BF40
        public void NeedsSync(){} // RVA: 0x7A8153980
        public void OnBecameVisible(){} // RVA: 0x7A950BFE0
        public void NeedsImportant(){} // RVA: 0x7A80D7320
        public void Encode(){} // RVA: 0x7A950D750
        // ── Unresolved (hash) ──
        public void m_CF2(){} // RVA: 0x7A95096C0
        public void m_E0A(){} // RVA: 0x7A9509900
        public void m_751(){} // RVA: 0x7A9509C50
        public void m_053(){} // RVA: 0x7A950A220
        public void m_F20(){} // RVA: 0x7A950A7F0
        public void m_205(){} // RVA: 0x7A950B430
        public void m_180(){} // RVA: 0x7A8051B10
        public void m_9E4(){} // RVA: 0x7A8358D90
        public void m_8F2(){} // RVA: 0x7A950AA00
        public void m_C06(){} // RVA: 0x7A950B970
    }

    /// <summary>Originally: ÏÌÌÌÏÎÏÏÏÏÏÍÌÍÏÎÏÌÏÌÍÎÎ</summary>
    public class VRCNetworkBehaviourBase : NetworkReadyHandler_6CE9
    {
        // ── Methods ──
        public void CanSerialize8Bit(){} // RVA: 0x7A81BD750
        public void CanUsePersistenceHashes(){} // RVA: 0x7A94B90F0
        public void CanSerialize32Bit(){} // RVA: 0x7A81BD750
        public void Awake(){} // RVA: 0x7A94B9D10
        public void Decode(){} // RVA: 0x7A94BA490
        public void Start(){} // RVA: 0x7A94BA350
        public void Update(){} // RVA: 0x7A94BA3F0
        public void NeedsSync(){} // RVA: 0x7A81A00C0
        public void Encode(){} // RVA: 0x7A94BBD70
        public void OnDestroy(){} // RVA: 0x7A81BD750
        public void SerializedName(){} // RVA: 0x7A94BAB90
        public void OnApplicationQuit(){} // RVA: 0x7A94BACF0
        public void OnBecameVisible(){} // RVA: 0x7A8358D90
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void GenerateComponentInfo(){} // RVA: 0x7A94BB3F0
        public void OnCollisionStay(){} // RVA: 0x7A94BB580
        public void OnCollisionExit(){} // RVA: 0x7A94BB9B0
        public void OnTriggerEnter(){} // RVA: 0x7A81BD750
        public void set_TypeId(){} // RVA: 0x7A94BBE10
        public void set_UniqueHash(){} // RVA: 0x7A94BBF40
        public void NeedsImportant(){} // RVA: 0x7A80D7320
        public void get_TypeId(){} // RVA: 0x7A94BC410
        public void get_UniqueHash(){} // RVA: 0x7A94BC410
        // ── Unresolved (hash) ──
        public void m_144(){} // RVA: 0x7A94B9520
        public void m_037(){} // RVA: 0x7A94B9830
        public void m_1DF(){} // RVA: 0x7A94BA7B0
        public void m_EEE(){} // RVA: 0x7A94BC150
    }

}