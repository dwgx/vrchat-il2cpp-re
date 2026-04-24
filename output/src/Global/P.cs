// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 85
// Methods: 348

public class PCMReaderCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class PCMSetPositionCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E432370
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class PagedGroupResult : Object
{
    public System.Collections.Generic.IReadOnlyList`1<VRC.Core.APIGroup> Groups; // 0x10
    public string NextCursor; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class Pair : ValueType
{
    public ushort shapeA; // 0x10
    public bool isReceiverA; // 0x12
    public ushort shapeB; // 0x14
    public bool isReceiverB; // 0x16
}

public class PairIterator : ValueType
{
    public int System.Collections.IEnumerator.Current; // 0x10
    public Photon.Client.NonAllocDictionary`2<int,Photon.Client.NCommand> Current; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Reset(){} // RVA: 0x7FFD4E090980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class PanicFunction_ : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class ParallelForJobStruct`1 : ValueType
{
    public SharedStatic`1<UIntPtr> jobReflectionData;

    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFD4E0909B0
    public void Execute(){} // RVA: 0x7FFD4E099720
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class ParallelWriter : ValueType
{
    public ParallelWriter<Pair,bool> m_Buffer; // 0x10
}

public class Parameter : Object
{
    public 0x665AE410 hash; // 0x10
    public string _hash; // 0x18
    public string source; // 0x20
    public float value; // 0x28
    public float valueMin; // 0x2C
    public float valueMax; // 0x30
    public float chance; // 0x34
    public bool preventRepeats; // 0x38
    public bool convertRange; // 0x39
    public float sourceMin; // 0x3C
    public float sourceMax; // 0x40
    public float destMin; // 0x44
    public float destMax; // 0x48
    public object sourceParam; // 0x50
    public object destParam; // 0x58

    // ── Methods ──
    public void get_hash(){} // RVA: 0x7FFD57434ED0
    public void IsNull(){} // RVA: 0x7FFD57434F40
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ParameterConfig : Object
{
    public string name; // 0x10
    public InputParameter input; // 0x18
    public OutputParameter output; // 0x20
    public string stringType; // 0x28
    public N parameterType; // 0x30
    public int hash; // 0x34

    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFD4EFDF910
    public void GetDefaultAddressFor(){} // RVA: 0x7FFD4EFDFD50
    public void .ctor(){} // RVA: 0x7FFD4EFDFDD0
}

public class ParameterEnumerable : ValueType
{
    public UnityEngine.InputSystem.InputActionState m_State; // 0x10
    public ParameterOverride m_Parameter; // 0x18
    public int m_MapIndex; // 0x90

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54951CD0
    public void GetEnumerator(){} // RVA: 0x7FFD54951DE0
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator(){} // RVA: 0x7FFD54951F10
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54951FE0
}

public class ParameterEnumerator : ValueType
{
    public UnityEngine.InputSystem.InputActionState Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x18
    public int m_BindingCurrentIndex; // 0x1C
    public int m_BindingEndIndex; // 0x20
    public int m_InteractionCurrentIndex; // 0x24
    public int m_InteractionEndIndex; // 0x28
    public int m_ProcessorCurrentIndex; // 0x2C
    public int m_ProcessorEndIndex; // 0x30
    public UnityEngine.InputSystem.InputBinding m_BindingMask; // 0x38
    public System.Type m_ObjectType; // 0x90
    public string m_ParameterName; // 0x98
    public bool m_MayBeInteraction; // 0xA0
    public bool m_MayBeProcessor; // 0xA1
    public bool m_MayBeComposite; // 0xA2
    public bool m_CurrentBindingIsComposite; // 0xA3
    public object m_CurrentObject; // 0xA8
    public System.Reflection.FieldInfo m_CurrentParameter; // 0xB0

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD549520B0
    public void MoveToNextBinding(){} // RVA: 0x7FFD54952480
    public void MoveToNextInteraction(){} // RVA: 0x7FFD549526A0
    public void MoveToNextProcessor(){} // RVA: 0x7FFD54952710
    public void FindParameter(){} // RVA: 0x7FFD54952780
    public void MoveNext(){} // RVA: 0x7FFD54952930
    public void Reset(){} // RVA: 0x7FFD54952AB0
    public void get_Current(){} // RVA: 0x7FFD54952C20
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD54952D00
    public void Dispose(){} // RVA: 0x7FFD4E341310
}

public class ParameterOverride : ValueType
{
    public string objectType; // 0x10
    public string parameter; // 0x18
    public UnityEngine.InputSystem.InputBinding bindingMask; // 0x20
    public UnityEngine.InputSystem.Utilities.PrimitiveValue value; // 0x78

    // ── Methods ──
    public void get_objectType(){} // RVA: 0x7FFD54952D70
    public void .ctor(){} // RVA: 0x7FFD549530B0 | overloaded x2
    public void Find(){} // RVA: 0x7FFD54953540 | overloaded x2
    public void PickMoreSpecificOne(){} // RVA: 0x7FFD54953A50
}

public class ParameterizedConstructorDelegate`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class ParentHash : ValueType
{
    public int m_Hash; // 0x10
    public int m_ParentHash; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E7F6D50
}

public class PartBinding : ValueType
{
    public int part; // 0x10
    public UnityEngine.InputSystem.InputControl control; // 0x18

    // ── Methods ──
    public void get_part(){} // RVA: 0x7FFD4F840210
    public void set_part(){} // RVA: 0x7FFD4E78D8B0
    public void get_control(){} // RVA: 0x7FFD4F840220
    public void set_control(){} // RVA: 0x7FFD4F840240
}

public class Particle : ValueType
{
    public UnityEngine.Vector3 lifetime; // 0x10
    public UnityEngine.Vector3 position; // 0x1C
    public UnityEngine.Vector3 velocity; // 0x28
    public UnityEngine.Vector3 animatedVelocity; // 0x34
    public UnityEngine.Vector3 totalVelocity; // 0x40
    public UnityEngine.Vector3 remainingLifetime; // 0x4C
    public UnityEngine.Vector3 startLifetime; // 0x58
    public UnityEngine.Vector3 startColor; // 0x64
    public UnityEngine.Color32 randomSeed; // 0x70
    public uint axisOfRotation; // 0x74
    public uint startSize; // 0x78
    public float startSize3D; // 0x7C
    public float rotation; // 0x80
    public int rotation3D; // 0x84
    public float angularVelocity; // 0x88
    public float angularVelocity3D; // 0x8C
    public uint m_Flags; // 0x90

    // ── Methods ──
    public void set_lifetime(){} // RVA: 0x7FFD4E36A090
    public void get_position(){} // RVA: 0x7FFD54C31DA0
    public void set_position(){} // RVA: 0x7FFD5072B6C0
    public void get_velocity(){} // RVA: 0x7FFD54C31DC0
    public void set_velocity(){} // RVA: 0x7FFD54C31DE0
    public void get_animatedVelocity(){} // RVA: 0x7FFD54C50D10
    public void get_totalVelocity(){} // RVA: 0x7FFD54D702D0
    public void get_remainingLifetime(){} // RVA: 0x7FFD54D70310
    public void set_remainingLifetime(){} // RVA: 0x7FFD4E36A090
    public void get_startLifetime(){} // RVA: 0x7FFD54D70320
    public void set_startLifetime(){} // RVA: 0x7FFD4E36A0B0
    public void get_startColor(){} // RVA: 0x7FFD54D70330
    public void set_startColor(){} // RVA: 0x7FFD4E558C10
    public void get_randomSeed(){} // RVA: 0x7FFD54D70340
    public void set_randomSeed(){} // RVA: 0x7FFD4FAF5120
    public void get_axisOfRotation(){} // RVA: 0x7FFD54D70350
    public void set_axisOfRotation(){} // RVA: 0x7FFD4EBBD810
    public void get_startSize(){} // RVA: 0x7FFD54D70370
    public void set_startSize(){} // RVA: 0x7FFD54D70380
    public void get_startSize3D(){} // RVA: 0x7FFD54D703A0
    public void set_startSize3D(){} // RVA: 0x7FFD54D703C0
    public void get_rotation(){} // RVA: 0x7FFD54D703E0
    public void set_rotation(){} // RVA: 0x7FFD54D703F0
    public void get_rotation3D(){} // RVA: 0x7FFD54D70410
    public void set_rotation3D(){} // RVA: 0x7FFD54D70450
    public void get_angularVelocity(){} // RVA: 0x7FFD54D70490
    public void set_angularVelocity(){} // RVA: 0x7FFD54D704A0
    public void get_angularVelocity3D(){} // RVA: 0x7FFD54D704C0
    public void set_angularVelocity3D(){} // RVA: 0x7FFD54D70500
    public void GetCurrentSize(){} // RVA: 0x7FFD54D70540
    public void GetCurrentSize3D(){} // RVA: 0x7FFD54D705B0
    public void GetCurrentColor(){} // RVA: 0x7FFD54D70650
    public void SetMeshIndex(){} // RVA: 0x7FFD54D706D0
    public void GetMeshIndex(){} // RVA: 0x7FFD54D706E0
}

public class ParticleSystemBeginUpdateAll : ValueType
{
}

public class ParticleSystemEndUpdateAll : ValueType
{
}

public class PassthroughCapabilities : Object
{
    public bool SupportsPassthrough; // 0x10
    public bool SupportsColorPassthrough; // 0x11

    // ── Methods ──
    public void get_SupportsPassthrough(){} // RVA: 0x7FFD4E40B5E0
    public void get_SupportsColorPassthrough(){} // RVA: 0x7FFD4EB91DA0
    public void .ctor(){} // RVA: 0x7FFD537B1A70
}

public class PerCoreLockedStacks : Object
{
    public LockedStack<0x665C6FB8<Transmtn.DTO.Notifications.Notification>>[] _perCoreStacks; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void TryPush(){} // RVA: 0x7FFD4E090A40
    public void TryPop(){} // RVA: 0x7FFD4E078E90
    public void Trim(){} // RVA: 0x7FFD4E2ADC40
}

public class PerTypeValues`1 : Object
{
    public bool IsReferenceOrContainsReferences;
    public T[] EmptyArray;
    public UIntPtr ArrayAdjustment;

    // ── Methods ──
    public void MeasureArrayAdjustment(){} // RVA: 0x7FFD4E078A90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class PerformanceAnalyticsUpdate : ValueType
{
}

public class PersonalMirrorIcons : ValueType
{
    public UnityEngine.Texture2D mirror; // 0x10
    public UnityEngine.Texture2D mirrorOpacity; // 0x18
    public UnityEngine.Texture2D mirrorScale; // 0x20
    public UnityEngine.Texture2D mirrorTracking; // 0x28
    public UnityEngine.Texture2D mirrorVisibility; // 0x30
    public UnityEngine.Texture2D mirrorReset; // 0x38
    public UnityEngine.Texture2D mirrorPlus; // 0x40
    public UnityEngine.Texture2D mirrorMinus; // 0x48
    public UnityEngine.Texture2D faceMirror; // 0x50
    public UnityEngine.Texture2D faceOpacity; // 0x58
    public UnityEngine.Texture2D facePosition; // 0x60
    public UnityEngine.Texture2D faceScale; // 0x68
    public UnityEngine.Texture2D faceReset; // 0x70
}

public class PhotoCaptureResult : ValueType
{
    public 0x664E1668 resultType; // 0x10
    public long hResult; // 0x18
}

public class PhraseRecognizedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5132DE10
    public void Invoke(){} // RVA: 0x7FFD510CCDC0
}

public class PhysBoneJob : ValueType
{
    public float currentTime; // 0x10
    public Unity.Mathematics.float3 distanceCullOrigin; // 0x14
    public Unity.Collections.NativeArray`1<int> chainIndices; // 0x20
    public Unity.Collections.NativeArray`1<ChainRoot> roots; // 0x30
    public Unity.Collections.NativeArray`1<Chain> chains; // 0x40
    public Unity.Collections.NativeArray`1<Bone> bones; // 0x50
    public Unity.Collections.NativeArray`1<0x664E1038> transformAccess; // 0x60
    public Unity.Collections.NativeArray`1<TransformData> transformData; // 0x70
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x80
    public Unity.Collections.NativeArray`1<0x665BFD40> errorBuffer; // 0x90
    public int FABRIK_MAX_ITERATIONS;
    public float FABRIK_SOLVED_MARGIN;

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD55263D00
    public void InitializeChain(){} // RVA: 0x7FFD55265590
    public void SolveAnimation(){} // RVA: 0x7FFD55265D80
    public void SolveChain(){} // RVA: 0x7FFD552667A0
    public void UpdateColliders(){} // RVA: 0x7FFD55269730
    public void LerpColliders(){} // RVA: 0x7FFD55269DF0
    public void SolveCollisions(){} // RVA: 0x7FFD5526A040
    public void ApplyAngleLimits(){} // RVA: 0x7FFD5526ACC0
    public void ClampGlobalBoneLength(){} // RVA: 0x7FFD5526B780
    public void SolveGrabIK(){} // RVA: 0x7FFD5526B950
}

public class Physics : Object
{
    // ── Methods ──
    public void SetOrientationOnPath(){} // RVA: 0x7FFD4FDD0E00
    public void HasRigidbody2D(){} // RVA: 0x7FFD4FDD0FA0
    public void HasRigidbody(){} // RVA: 0x7FFD4FDD10A0
    public void CreateDOTweenPathTween(){} // RVA: 0x7FFD4FDD11A0
}

public class Physics2DEarlyUpdate : ValueType
{
}

public class Physics2DFixedUpdate : ValueType
{
}

public class Physics2DLateUpdate : ValueType
{
}

public class Physics2DUpdate : ValueType
{
}

public class PhysicsClothFixedUpdate : ValueType
{
}

public class PhysicsClothUpdate : ValueType
{
}

public class PhysicsFixedUpdate : ValueType
{
}

public class PhysicsLateUpdate : ValueType
{
}

public class PhysicsResetInterpolatedTransformPosition : ValueType
{
}

public class PhysicsSkinnedClothBeginUpdate : ValueType
{
}

public class PhysicsSkinnedClothFinishUpdate : ValueType
{
}

public class PhysicsUpdate : ValueType
{
}

public class PictureManager : Object
{
    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4F6BF980
    public void Equals(){} // RVA: 0x7FFD4F6BFD80
    public void GetHashCode(){} // RVA: 0x7FFD4F6BFEC0
    public void op_Implicit(){} // RVA: 0x7FFD4F6C00C0
    public void CompareBaseObjects(){} // RVA: 0x7FFD4F6C03A0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F6C05B0
    public void GetCachedPtr(){} // RVA: 0x7FFD4E341310
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void set_name(){} // RVA: 0x7FFD4F6C0870
    public void Instantiate(){} // RVA: 0x7FFD4F6C0AC0
    public void ToString(){} // RVA: 0x7FFD4E341310
    public void .ctor_934187086F08(){} // RVA: 0x7FFD4F6C0D80
    public void GetHashCode_A7E3EED14C22(){} // RVA: 0x7FFD4F6C1050
    public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFD4F6C11D0
    public void ToString_083F1EFF312E(){} // RVA: 0x7FFD4E341310
    public void GetLongFromDelegate(){} // RVA: 0x7FFD4F6C1270
    public void GetBooleanFromDelegate(){} // RVA: 0x7FFD4F6C13B0
    public void Initialize(){} // RVA: 0x7FFD4F6C1560
    public void FailFast(){} // RVA: 0x7FFD4F6C1630
    public void Destroy(){} // RVA: 0x7FFD4E341310
    public void GetOrInitializePictureData(){} // RVA: 0x7FFD4F6C1770
}

public class PinchData : ValueType
{
    public float Distance; // 0x10
    public float Amount; // 0x14
    public UnityEngine.Vector3 Center; // 0x18
}

public class PinnedArray`1 : ValueType
{
    public System.Runtime.InteropServices.GCHandle _handle;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
}

public class PipelineSaver : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class PlatformAsset : Object
{
    public 0x664C9720 Platform; // 0x10
    public UnityEngine.Sprite Icon; // 0x18
    public UnityEngine.Color Color; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class PlatformOptions : Object
{
    public 0x665D6160 httpHeaders; // 0x10
    public RenderHeads.Media.AVProVideo.KeyAuthData keyAuth; // 0x18

    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFD4FBE24F0
    public void GetKeyServerAuthToken(){} // RVA: 0x7FFD4E98C7D0
    public void GetOverrideDecryptionKey(){} // RVA: 0x7FFD4FBE2590
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFD4E341320
    public void .ctor(){} // RVA: 0x7FFD4FBE25B0
}

public class PlaybackState : ValueType
{
    public float m_AccumulatedDt; // 0x10
    public float m_StartDelay; // 0x14
    public float m_PlaybackTime; // 0x18
    public int m_RingBufferIndex; // 0x1C
    public 0x665E5D58 m_Emission; // 0x20
    public 0x665E5DB0 m_Initial; // 0x38
    public 0x665E5E08 m_Shape; // 0x78
    public 0x665E5E60 m_Force; // 0xD4
    public 0x665E5EB8 m_Collision; // 0x114
    public 0x665E5F10 m_Noise; // 0x154
    public 0x665E5F68 m_Lights; // 0x158
    public 0x665E5FC0 m_Trail; // 0x16C
}

public class PlayerCleanupCachedData : ValueType
{
}

public class PlayerEmitCanvasGeometry : ValueType
{
}

public class PlayerModComponentHealth : NetworkReadyHandler_68D0
{
    public float f_3DB; // 0x58
    public float f_ABC; // 0x5C
    public ÎÌÎÏÍÌÍÏÍÌÎÌÏÏÏÎÍÌÏÍÎÏÎ f_8D0; // 0x60
    public 0x66625940 ÏÌÌÌÌÎÍÌÏÍÏÌÎÌÏÍÏÎÏÏÍÌÏ; // 0x68
    public bool ÍÍÏÌÌÎÏÏÎÌÏÎÎÎÎÌÎÏÎÎÌÏÏ; // 0x6C
    public ÍÍÎÎÍÎÎÏÍÌÏÏÌÎÍÍÎÎÍÏÌÏÎ ÎÏÌÎÌÌÍÌÌÌÌÏÍÍÌÏÍÍÎÌÌÌÏ; // 0x70
    public UnityEngine.Coroutine ÎÎÍÍÍÏÏÎÏÌÏÏÌÍÌÍÎÌÌÌÏÍÏ; // 0x78

    // ── Methods ──
    public void print(){} // RVA: 0x7FFD4F2EB600
    public void set_ValidExpressions(){} // RVA: 0x7FFD4F2EB6A0
    public void SetXMotion(){} // RVA: 0x7FFD4E341320
    public void GetUnscaledTime(){} // RVA: 0x7FFD4F2EB6F0
    public void GetStatus(){} // RVA: 0x7FFD4EA8FE20
    public void GetUnscaledTime_465DCBC01E05(){} // RVA: 0x7FFD4F2EB8A0
    public void ShowDeath(){} // RVA: 0x7FFD4F2EBA60
    public void .ctor(){} // RVA: 0x7FFD4F2EBCE0
    public void Awake(){} // RVA: 0x7FFD4F2EBD60
    public void OnEnable(){} // RVA: 0x7FFD4F2EBD90
    public void ResetHealthRPC(){} // RVA: 0x7FFD4F2EBDB0
    public void SetProperties(){} // RVA: 0x7FFD4F2EBF20
    public void Update(){} // RVA: 0x7FFD4F2EC3C0
    public void LateUpdate(){} // RVA: 0x7FFD4F2EC530
    public void OnDisable(){} // RVA: 0x7FFD4F2EC7B0
    public void OnTriggerStay(){} // RVA: 0x7FFD4E55BE20
    public void OnApplicationPause(){} // RVA: 0x7FFD4F2EC980
    public void OnApplicationQuit(){} // RVA: 0x7FFD4F2ECB40
    public void OnDisable_E5EE5FD706E0(){} // RVA: 0x7FFD4F2ECD20
    public void OnDestroy(){} // RVA: 0x7FFD4F2ECD20
    public void RemoveHealthRPC(){} // RVA: 0x7FFD4F2ECD70
    public void ComputeHealthHash(){} // RVA: 0x7FFD4F2ECF40
    public void OnCollisionExit(){} // RVA: 0x7FFD4F2ED070
    public void AddHealthRPC(){} // RVA: 0x7FFD4F2ED690
    public void Start(){} // RVA: 0x7FFD4F2ED820
    public void ApplyHealthUpdate(){} // RVA: 0x7FFD4F2ED8C0
    public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F2EDA90
    public void OnApplicationPause_6E31DE36D14C(){} // RVA: 0x7FFD4F2EDC50
    public void Update_DFA5D4C1065F(){} // RVA: 0x7FFD4F2EDCF0
}

public class PlayerModComponentJump : MonoBehaviour
{
    public ÍÌÎÍÌÌÎÌÏÍÏÍÍÏÍÎÎÏÌÌÎÌÏ ÎÌÎÎÍÏÎÏÎÌÍÏÍÌÎÏÍÏÌÎÌÎÎ; // 0x20
    public float ÌÌÍÌÎÏÏÎÌÌÎÏÍÍÎÌÌÏÍÌÏÎÎ; // 0x28
    public float ÌÌÎÌÍÌÌÏÍÌÎÍÍÍÍÏÏÎÏÏÍÍÎ; // 0x2C
    public bool ÎÎÍÍÎÎÍÎÌÎÌÍÎÏÎÍÎÍÌÍÍÏÌ; // 0x30

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F2F03F0
    public void RaiseCancellation(){} // RVA: 0x7FFD4F2F0520
    public void Start(){} // RVA: 0x7FFD4F2F0920
    public void CancelInvoke(){} // RVA: 0x7FFD4F2F0B10
    public void OnDestroy(){} // RVA: 0x7FFD4F2F0C10
    public void InvokeRepeating(){} // RVA: 0x7FFD4F2F0C20
    public void OnDisable(){} // RVA: 0x7FFD4F2F0C10
    public void IsInvoking(){} // RVA: 0x7FFD4F2F0C10
    public void StartCoroutine(){} // RVA: 0x7FFD4F2F0D20
    public void SetProperties(){} // RVA: 0x7FFD4F2F0E20
    public void OnBecameVisible(){} // RVA: 0x7FFD4F2F0C10
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class PlayerModComponentSpeed : MonoBehaviour
{
    public ÍÌÎÍÌÌÎÌÏÍÏÍÍÏÍÎÎÏÌÌÎÌÏ ÍÎÏÍÌÍÌÎÎÍÌÏÏÌÍÎÏÍÎÏÌÏÍ; // 0x20
    public float ÍÏÎÍÎÏÌÍÍÌÏÍÍÌÌÌÎÏÎÏÍÎÍ; // 0x28
    public float ÎÏÍÎÍÍÌÍÌÌÏÎÌÎÌÎÎÎÎÍÌÍÌ; // 0x2C
    public float ÍÌÌÏÏÏÍÍÏÏÎÍÍÍÍÍÌÏÌÍÍÍÌ; // 0x30
    public float ÎÍÌÏÎÍÌÍÏÏÏÍÎÏÏÍÎÏÏÎÏÎÏ; // 0x34
    public float ÏÏÌÏÌÍÏÍÍÍÌÏÏÍÎÍÌÍÌÍÏÌÏ; // 0x38
    public float ÎÎÎÍÌÌÎÍÏÌÏÎÎÌÍÍÍÎÎÏÍÌÍ; // 0x3C
    public bool ÏÌÎÏÏÌÌÍÍÌÎÌÌÏÎÌÏÌÌÌÌÍÌ; // 0x40

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFD4F2F1150
    public void RaiseCancellation(){} // RVA: 0x7FFD4F2F12A0
    public void OnDestroy(){} // RVA: 0x7FFD4F2F12A0
    public void CancelInvoke(){} // RVA: 0x7FFD4F2F1400
    public void SetProperties(){} // RVA: 0x7FFD4F2F15F0
    public void InvokeRepeating(){} // RVA: 0x7FFD4F2F1A90
    public void OnBecameInvisible(){} // RVA: 0x7FFD4F2F1C80
    public void IsInvoking(){} // RVA: 0x7FFD4F2F2120
    public void Start(){} // RVA: 0x7FFD4F2F25C0
    public void StartCoroutine(){} // RVA: 0x7FFD4F2F27B0
    public void OnTriggerEnter(){} // RVA: 0x7FFD4F2F29A0
    public void .ctor(){} // RVA: 0x7FFD4E341D50
    public void Initialize(){} // RVA: 0x7FFD4F2F2B90
    public void StopCoroutine(){} // RVA: 0x7FFD4F2F2CF0
}

public class PlayerModComponentVoice : MonoBehaviour
{
    public float ÏÎÍÏÏÎÍÏÏÌÏÍÎÍÎÌÏÎÏÍÌÌÌ; // 0x20
    public float ÎÍÌÏÌÎÌÌÎÍÏÌÏÍÏÍÍÌÎÎÎÎÍ; // 0x24
    public bool ÍÌÏÎÎÏÍÌÍÍÎÏÌÌÍÌÌÍÌÍÎÌÏ; // 0x28
    public ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏÎÍÍ ÍÌÏÎÏÏÌÌÍÏÌÌÏÌÏÌÌÎÏÎÏÎÍ; // 0x30

    // ── Methods ──
    public void OnDestroy(){} // RVA: 0x7FFD4F2F2EE0
    public void RaiseCancellation(){} // RVA: 0x7FFD4F2F2EF0
    public void IsInvoking(){} // RVA: 0x7FFD4F2F3000
    public void CancelInvoke(){} // RVA: 0x7FFD4F2F3090
    public void Invoke(){} // RVA: 0x7FFD4F2F2EE0
    public void SetProperties(){} // RVA: 0x7FFD4F2F3120
    public void .ctor(){} // RVA: 0x7FFD4E341D50
    public void Initialize(){} // RVA: 0x7FFD4F2F3530
    public void Awake(){} // RVA: 0x7FFD4F2F35C0
    public void StartCoroutine(){} // RVA: 0x7FFD4F2F3650
    public void OnTriggerExit(){} // RVA: 0x7FFD4F2F3800
    public void Start(){} // RVA: 0x7FFD4F2F3C10
}

public class PlayerRenderUIEBatchModeOffscreen : ValueType
{
}

public class PlayerSendFrameComplete : ValueType
{
}

public class PlayerSendFramePostPresent : ValueType
{
}

public class PlayerSendFrameStarted : ValueType
{
}

public class PlayerUpdateCanvases : ValueType
{
}

public class Point : Object
{
    public float frequency; // 0x10
    public float data; // 0x14

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4EF4F270
    public void Equals(){} // RVA: 0x7FFD4EF4F270
    public void GetCachedPtr_D45A011958AB(){} // RVA: 0x7FFD4EF4F270 | overloaded x2
    public void op_Implicit(){} // RVA: 0x7FFD4EF4F300
    public void CompareBaseObjects(){} // RVA: 0x7FFD4EF4F360
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EF4F270
    public void .ctor(){} // RVA: 0x7FFD4EF4F3C0
}

public class PollHtcsPlayerConnection : ValueType
{
}

public class PollNextEventUnion : ValueType
{
    public _PollNextEvent pPollNextEvent; // 0x10
    public _PollNextEventPacked pPollNextEventPacked; // 0x10
}

public class PollNextOverlayEventUnion : ValueType
{
    public _PollNextOverlayEvent pPollNextOverlayEvent; // 0x10
    public _PollNextOverlayEventPacked pPollNextOverlayEventPacked; // 0x10
}

public class PollPlayerConnection : ValueType
{
}

public class PolyNode : Object
{
    public PolyNode ChildCount; // 0x10
    public System.Collections.Generic.List`1<IntPoint> Contour; // 0x18
    public int Childs; // 0x20
    public 0x6658C548 Parent; // 0x24
    public 0x6658C5A0 IsHole; // 0x28
    public System.Collections.Generic.List`1<PolyNode> IsOpen; // 0x30
    public bool <IsOpen>k__BackingField; // 0x38

    // ── Methods ──
    public void IsHoleNode(){} // RVA: 0x7FFD4FC7C110
    public void get_ChildCount(){} // RVA: 0x7FFD4FC7C130
    public void get_Contour(){} // RVA: 0x7FFD4E3447C0
    public void AddChild(){} // RVA: 0x7FFD4FC7C180
    public void GetNext(){} // RVA: 0x7FFD4FC7C250
    public void GetNextSiblingUp(){} // RVA: 0x7FFD4FC7C2F0
    public void get_Childs(){} // RVA: 0x7FFD4E5F95E0
    public void get_Parent(){} // RVA: 0x7FFD4E35C380
    public void get_IsHole(){} // RVA: 0x7FFD4FC7C110
    public void get_IsOpen(){} // RVA: 0x7FFD4E5F95D0
    public void set_IsOpen(){} // RVA: 0x7FFD4E5F95C0
    public void .ctor(){} // RVA: 0x7FFD4FC7C3B0
}

public class PolyTree : PolyNode
{
    public System.Collections.Generic.List`1<PolyNode> Total; // 0x40

    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFD4FC7BDD0
    public void GetFirst(){} // RVA: 0x7FFD4FC7BF00
    public void get_Total(){} // RVA: 0x7FFD4FC7BF90
    public void .ctor(){} // RVA: 0x7FFD4FC7C040
}

public class PolyfillExtensions : Object
{
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Reflection.ParameterInfo,0x66502198> parameterCache;
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Reflection.PropertyInfo,0x66502198> propertyCache; // 0x8
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Reflection.EventInfo,0x66502198> eventCache; // 0x10
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Reflection.FieldInfo,0x66502198> fieldCache; // 0x18
    public long TicksPerMicrosecond;

    // ── Methods ──
    public void GetNullabilityInfo(){} // RVA: 0x7FFD53E488F0 | overloaded x5
    public void GetNullability(){} // RVA: 0x7FFD53E48AA0 | overloaded x5
    public void IsNullable(){} // RVA: 0x7FFD53E48E10 | overloaded x6
    public void GetReadOrWriteState(){} // RVA: 0x7FFD53E48BE0
    public void GetKnownState(){} // RVA: 0x7FFD53E48C10
    public void CancelAsync(){} // RVA: 0x7FFD53E48E80
    public void GetStreamAsync(){} // RVA: 0x7FFD53E491C0 | overloaded x2
    public void GetByteArrayAsync(){} // RVA: 0x7FFD53E494B0 | overloaded x2
    public void GetStringAsync(){} // RVA: 0x7FFD53E497A0 | overloaded x2
    public void ReadAsStreamAsync(){} // RVA: 0x7FFD53E49840
    public void ReadAsByteArrayAsync(){} // RVA: 0x7FFD53E49910
    public void ReadAsStringAsync(){} // RVA: 0x7FFD53E49B60
    public void MaxBy(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void MinBy(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void SkipLast(){} // RVA: 0x7FFD4E088090
    public void GetValueOrDefault(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void Deconstruct(){} // RVA: 0x7FFD4E2ADC40
    public void Contains(){} // RVA: 0x7FFD53E4BAB0 | overloaded x4
    public void SequenceEqual(){} // RVA: 0x7FFD53E49CE0 | overloaded x2
    public void StartsWith(){} // RVA: 0x7FFD53E4B7F0 | overloaded x3
    public void EndsWith(){} // RVA: 0x7FFD53E4B830 | overloaded x3
    public void Nanoseconds(){} // RVA: 0x7FFD53E4A440
    public void Nanosecond(){} // RVA: 0x7FFD53E4A540 | overloaded x2
    public void Microseconds(){} // RVA: 0x7FFD53E4A5D0
    public void Microsecond(){} // RVA: 0x7FFD53E4A6D0 | overloaded x2
    public void AddMicroseconds(){} // RVA: 0x7FFD53E4A810 | overloaded x2
    public void TicksComponent(){} // RVA: 0x7FFD53E4ACC0 | overloaded x3
    public void ReadAsync(){} // RVA: 0x7FFD53E4C200 | overloaded x2
    public void WriteAsync(){} // RVA: 0x7FFD53E4C5F0 | overloaded x2
    public void CopyToAsync(){} // RVA: 0x7FFD53E4B330
    public void CopyTo(){} // RVA: 0x7FFD53E4BAE0 | overloaded x2
    public void TryCopyTo(){} // RVA: 0x7FFD53E4B450
    public void GetHashCode(){} // RVA: 0x7FFD53E4B500
    public void FromComparison(){} // RVA: 0x7FFD53E4B680
    public void Split(){} // RVA: 0x7FFD53E4B990 | overloaded x2
    public void Append(){} // RVA: 0x7FFD53E4BBB0
    public void Equals(){} // RVA: 0x7FFD53E4BC50
    public void WaitAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
    public void ReadToEndAsync(){} // RVA: 0x7FFD53E4C510
    public void WriteLineAsync(){} // RVA: 0x7FFD53E4C8E0
    public void Write(){} // RVA: 0x7FFD53E4CBD0
    public void WriteLine(){} // RVA: 0x7FFD53E4CE00
    public void TryFormat(){} // RVA: 0x7FFD53E4E190 | overloaded x14
    public void CopyToSpan(){} // RVA: 0x7FFD53E4E320
    public void HasSameMetadataDefinitionAs(){} // RVA: 0x7FFD53E4E450
    public void IsGenericMethodParameter(){} // RVA: 0x7FFD53E4E520
    public void GetMemberWithSameMetadataDefinitionAs(){} // RVA: 0x7FFD53E4E5B0
    public void ReadAsStream(){} // RVA: 0x7FFD53E4E7B0
    public void WriteRawValue(){} // RVA: 0x7FFD53E4E960
    public void .cctor(){} // RVA: 0x7FFD53E4EC30
}

public class PolygonSolution : ValueType
{
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> IsNull; // 0x10
    public float frustumHeight; // 0x18

    // ── Methods ──
    public void StateChanged(){} // RVA: 0x7FFD4FC6C1E0
    public void get_IsNull(){} // RVA: 0x7FFD4FC6C2F0
}

public class PopupTextElement : TextElement
{
    // ── Methods ──
    public void DoMeasure(){}
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class PortalSkinMap : MonoBehaviour
{
    public UnityEngine.Animator Animator; // 0x20
    public UnityEngine.MeshRenderer ThumbnailRenderer; // 0x28
    public float DespawnDuration; // 0x30
    public UnityEngine.Transform PortalUIOverridePosition; // 0x38
    public UnityEngine.Transform PortalPlatformBadgesOverridePosition; // 0x40
    public UnityEngine.Transform PortalLabsBadgeOverridePosition; // 0x48
    public float PreviewScale; // 0x50
    public UnityEngine.Vector3 PreviewOffset; // 0x54

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5527DC40
}

public class Pose : Object
{
    public VRC.Dynamics.ChainId chainId; // 0x10
    public bool prevIsAnimated; // 0x20
    public System.Collections.Generic.List`1<0x665C0210> prevData; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5526E9E0
}

public class PostLateUpdater : MonoBehaviour
{
    public VRC.Udon.UdonManager udonManager; // 0x20

    // ── Methods ──
    public void LateUpdate(){} // RVA: 0x7FFD552A7A40
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class PrecompiledLayout : ValueType
{
    public System.Func`1<UnityEngine.InputSystem.InputDevice> factoryMethod; // 0x10
    public string metadata; // 0x18
}

public class PresentAfterDraw : ValueType
{
}

public class PresentBeforeUpdate : ValueType
{
}

public class PresetSaveData : Object
{
    public int SelectedPreset; // 0x10
    public System.Collections.Generic.Dictionary`2<int,ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ> Presets; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class PreviousInfo : ValueType
{
    public int Code; // 0x10
    public byte* SortKey; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD537BB310
}

public class ProbabilisticMap : ValueType
{
}

public class ProcessExtractedFrame : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class ProcessMouseInWindow : ValueType
{
}

public class ProcessRemoteInput : ValueType
{
}

public class ProcessWebSendMessages : ValueType
{
}

public class ProfilerEndFrame : ValueType
{
}

public class ProfilerStartFrame : ValueType
{
}

public class ProfilerSynchronizeStats : ValueType
{
}

public class ProviderRegistration : ValueType
{
    public Microsoft.Extensions.Logging.ILoggerProvider Provider; // 0x10
    public bool ShouldDispose; // 0x18
}
