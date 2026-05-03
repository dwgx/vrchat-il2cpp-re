// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics
// Classes: 81
// Methods: 813

namespace VRC.Dynamics
{
    public class AbstractVRCConstraintBinding`2 : Object
    {
        public U UnityConstraint;
        public T VrcConstraint;

        // ── Methods ──
        public void get_ApplicationUnityConstraint(){} // RVA: 0x7FFE80E2E2E0
        public void get_ApplicationVrcConstraint(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Synchronize(){} // RVA: 0x7FFE80E34FA0
        public void SynchronizeInternal(){} // RVA: 0x7FFE80E2EDB0
        public void RestoreUnityConstraintEnabledState(){} // RVA: 0x7FFE80E45FE0
        public void ChangeProperty(){} // RVA: 0x7FFE80E2F7A0 | overloaded x5
        public void <Synchronize>g__PushResult|11_0(){} // RVA: 0x7FFE80E4BA70
    }

    public class AimVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881C1320
        public void SynchronizeInternal(){} // RVA: 0x7FFE881C1380
        public void ToVrcWorldUpType(){} // RVA: 0x7FFE881C1B80
    }

    public class AnimParameterAccessAvatarSDK : Object
    {
        public UnityEngine.Animator animator; // 0x10
        public int paramHash; // 0x18
        public 0x666964E4 paramType; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881CD0A0
        public void get_boolVal(){} // RVA: 0x7FFE881CD330
        public void set_boolVal(){} // RVA: 0x7FFE881CD430
        public void get_intVal(){} // RVA: 0x7FFE881CD540
        public void set_intVal(){} // RVA: 0x7FFE881CD630
        public void get_floatVal(){} // RVA: 0x7FFE881CD740
        public void set_floatVal(){} // RVA: 0x7FFE881CD830
    }

    public class BoneBuffer : Object
    {
        public Unity.Collections.NativeList`1<Bone> bones; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881DEA30
        public void get_Length(){} // RVA: 0x7FFE881DEBC0
        public void set_Length(){} // RVA: 0x7FFE881DEC10
        public void Move(){} // RVA: 0x7FFE881DEE50
        public void Dispose(){} // RVA: 0x7FFE881DF330
        public void Clear(){} // RVA: 0x7FFE881DF420
        public void Invalidate(){} // RVA: 0x7FFE881DF530
    }

    public class ChainBuffer : Object
    {
        public Unity.Collections.NativeList`1<Chain> chains; // 0x10
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneBase> comps; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881DDBF0
        public void get_Length(){} // RVA: 0x7FFE881DDD30
        public void set_Length(){} // RVA: 0x7FFE881DDD80
        public void get_Capacity(){} // RVA: 0x7FFE881DDF10
        public void Move(){} // RVA: 0x7FFE881DDF60
        public void Dispose(){} // RVA: 0x7FFE881DE2A0
        public void Clear(){} // RVA: 0x7FFE881DE510
        public void UpdateSpan(){} // RVA: 0x7FFE881DE7C0
        public void RemoveAt(){} // RVA: 0x7FFE881DE990
        public void Invalidate(){} // RVA: 0x7FFE810FB310
    }

    public class ChainId : ValueType
    {
        public VRC.Dynamics.ChainId Null;
        public ulong a; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AC4DA0
        public void Equals(){} // RVA: 0x7FFE881D7870 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE881D7990
        public void op_Equality(){} // RVA: 0x7FFE82AC4DD0
        public void op_Inequality(){} // RVA: 0x7FFE82AC4DF0
        public void ToString(){} // RVA: 0x7FFE881D7B70
        public void get_A(){} // RVA: 0x7FFE8284EF60
        public void get_B(){} // RVA: 0x7FFE826F4210
        public void .cctor(){} // RVA: 0x7FFE810FB310
    }

    public class CollisionBroadphase_HashGrid : Object
    {
        public int SHAPE_BATCH_COUNT;

        // ── Methods ──
        public void get_scene(){} // RVA: 0x7FFE81116380
        public void set_scene(){} // RVA: 0x7FFE810FCE30
        public void AddShape(){} // RVA: 0x7FFE88198A90
        public void RemoveShape(){} // RVA: 0x7FFE88198AE0
        public void CastShape(){} // RVA: 0x7FFE810FB310
        public void DrawGizmos(){} // RVA: 0x7FFE810FB310
        public void ScheduleJobs(){} // RVA: 0x7FFE88198D20
        public void OnComplete(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE881994A0
        public void .ctor(){} // RVA: 0x7FFE88199530
        public void .cctor(){} // RVA: 0x7FFE881996E0
    }

    public class CollisionBroadphase_HybridSAP : Object
    {
        public int SHAPE_BATCH_COUNT;

        // ── Methods ──
        public void get_scene(){} // RVA: 0x7FFE81116380
        public void set_scene(){} // RVA: 0x7FFE810FCE30
        public void AddShape(){} // RVA: 0x7FFE810FB310
        public void RemoveShape(){} // RVA: 0x7FFE8819B770
        public void CastShape(){} // RVA: 0x7FFE8819CB60 | overloaded x2
        public void ScheduleJobs(){} // RVA: 0x7FFE8819BF70
        public void OnComplete(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE8819C840
        public void DrawGizmos(){} // RVA: 0x7FFE8819D030
        public void .ctor(){} // RVA: 0x7FFE8819D690
        public void .cctor(){} // RVA: 0x7FFE8819D8A0
    }

    public class CollisionScene : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881A0C00 | overloaded x2
        public void SetBroadphase(){} // RVA: 0x7FFE881A12A0
        public void GetBroadphase(){} // RVA: 0x7FFE81116380
        public void AddShape(){} // RVA: 0x7FFE881A13C0
        public void RemoveShape(){} // RVA: 0x7FFE881A1470
        public void UpdateShapeData(){} // RVA: 0x7FFE881A1510
        public void GetShapeData(){} // RVA: 0x7FFE881A19B0 | overloaded x2
        public void ShapeCount(){} // RVA: 0x7FFE881A1A50
        public void CastSphere(){} // RVA: 0x7FFE881A1AA0
        public void UpdateBounds(){} // RVA: 0x7FFE881A2070
        public void UpdateAndSchedule(){} // RVA: 0x7FFE881A2270
        public void ScheduleReadTransforms(){} // RVA: 0x7FFE881A2430
        public void ScheduleUpdateShapePositions(){} // RVA: 0x7FFE881A2610
        public void Complete(){} // RVA: 0x7FFE881A28D0
        public void Dispose(){} // RVA: 0x7FFE881A2AC0
        public void SyncShapesNow(){} // RVA: 0x7FFE881A2CF0
        public void RemoveShapes(){} // RVA: 0x7FFE881A2D00
        public void AddShapes(){} // RVA: 0x7FFE881A3550
        public void FindAvailableId(){} // RVA: 0x7FFE881A3C90
        public void DrawGizmos(){} // RVA: 0x7FFE881A3D30
        public void .cctor(){} // RVA: 0x7FFE881A3E00
    }

    public class CollisionShapes : Object
    {
        // ── Methods ──
        public void CheckCollision(){} // RVA: 0x7FFE881A79D0
        public void CheckCollision_AABB(){} // RVA: 0x7FFE881A7DE0
        public void CheckCollision_Sphere(){} // RVA: 0x7FFE881A7FB0
        public void CheckCollision_Capsule(){} // RVA: 0x7FFE881A83C0
        public void CheckCollision_Box(){} // RVA: 0x7FFE881A86B0
        public void Overlap_AABB_Sphere(){} // RVA: 0x7FFE881A8B30
        public void Overlap_AABB_Capsule(){} // RVA: 0x7FFE881A8C50
        public void Overlap_AABB_Box(){} // RVA: 0x7FFE881A8D70
        public void Overlap_Sphere_Sphere(){} // RVA: 0x7FFE881A8DB0
        public void Overlap_Sphere_Capsule(){} // RVA: 0x7FFE881A8E10
        public void Overlap_Sphere_Box(){} // RVA: 0x7FFE881A8FA0
        public void Overlap_Capsule_Capsule(){} // RVA: 0x7FFE881A9030
        public void Overlap_Capsule_Box(){} // RVA: 0x7FFE881A9160
        public void Overlap_Box_Box(){} // RVA: 0x7FFE881A92D0
    }

    public class ConstraintHasSingleLowWeightSource_000000C8$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE881B5CD0
        public void GetFunctionPointer(){} // RVA: 0x7FFE881B5E10
        public void Constructor(){} // RVA: 0x7FFE881B5F80
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE881B5F80
        public void Invoke(){} // RVA: 0x7FFE881B6040
    }

    public class ConstraintHasSingleLowWeightSource_000000C8$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83FBB0C0
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE881B5C40
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class ContactBase : DynamicsComponent
    {
        public float MAX_SIZE;
        public int MAX_COLLISION_TAGS;
        public System.Func`2<VRC.Dynamics.ContactBase,bool> OnInitialize;
        public UnityEngine.Transform rootTransform; // 0x28

        // ── Methods ──
        public void GetRootTransform(){} // RVA: 0x7FFE881CD950
        public void get_axis(){} // RVA: 0x7FFE881CDA70
        public void get_boxSizeAbsolute(){} // RVA: 0x7FFE881CDC70
        public void get_IsLocalOnly(){} // RVA: 0x7FFE821FF050
        public void Start(){} // RVA: 0x7FFE881CDCB0
        public void OnEnable(){} // RVA: 0x7FFE881CDE40
        public void OnDisable(){} // RVA: 0x7FFE881CDED0
        public void ValidateTagsList(){} // RVA: 0x7FFE881CDF60
        public void InitParameters(){} // RVA: 0x7FFE881CE0C0
        public void Init(){} // RVA: 0x7FFE881CE140
        public void GetPlayerId(){} // RVA: 0x7FFE881CE270
        public void IsReceiver(){} // RVA: 0x7FFE80E2F150
        public void RequiresUpdate(){} // RVA: 0x7FFE881CE2A0
        public void get_AffectedByAllowFlags(){} // RVA: 0x7FFE881CE2E0
        public void UpdateContact(){} // RVA: 0x7FFE881CE320
        public void InitShape(){} // RVA: 0x7FFE881CE440
        public void UpdateShape(){} // RVA: 0x7FFE881CE660
        public void PerformShapeUpdate(){} // RVA: 0x7FFE881CE780
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFE881CE8E0
        public void UpdateContentTypes(){} // RVA: 0x7FFE82A22F00
        public void UpdateCollisionTags(){} // RVA: 0x7FFE881CE8F0
        public void .ctor(){} // RVA: 0x7FFE881CEA10
    }

    public class ContactBaseProxy`2 : Object
    {
        public T Component;
        public VRC.SDKBase.VRCPlayerApi _ownerPlayerApi;
        public object field_2; // 0x3B
        public object field_3; // 0x3C
        public object field_4; // 0x3D
        public object field_5; // 0x3E
        public object field_6; // 0x3F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_isValid(){} // RVA: 0x7FFE80E2F150
        public void get_contactShapeId(){} // RVA: 0x7FFE80E2E210
        public void get_player(){} // RVA: 0x7FFE80E2E2E0
        public void get_usage(){} // RVA: 0x7FFE80E2EDB0
        public void get_position(){} // RVA: 0x7FFE80E2DCF0
        public void get_rotation(){} // RVA: 0x7FFE80E2DCF0
        public void get_scale(){} // RVA: 0x7FFE80E2DCF0
        public void Equals(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class ContactEnterInfo : ValueType
    {
        public VRC.Dynamics.ContactSenderProxy _contactSender; // 0x10
        public VRC.Dynamics.ContactReceiverProxy _contactReceiver; // 0x18
        public UnityEngine.Vector3 _enterVelocity; // 0x20
        public UnityEngine.Vector3 _contactPoint; // 0x2C
        public string[] _matchingTags; // 0x38

        // ── Methods ──
        public void get_contactSender(){} // RVA: 0x7FFE8284EF60
        public void set_contactSender(){} // RVA: 0x7FFE81D7E9E0
        public void get_contactReceiver(){} // RVA: 0x7FFE826F4210
        public void set_contactReceiver(){} // RVA: 0x7FFE826F4230
        public void get_enterVelocity(){} // RVA: 0x7FFE811188D0
        public void set_enterVelocity(){} // RVA: 0x7FFE811188F0
        public void get_contactPoint(){} // RVA: 0x7FFE879E0D00
        public void set_contactPoint(){} // RVA: 0x7FFE879E0D20
        public void get_matchingTags(){} // RVA: 0x7FFE81129130
        public void set_matchingTags(){} // RVA: 0x7FFE810FCE90
    }

    public class ContactExitInfo : ValueType
    {
        public VRC.Dynamics.ContactSenderProxy _contactSender; // 0x10
        public VRC.Dynamics.ContactReceiverProxy _contactReceiver; // 0x18
        public string[] _matchingTags; // 0x20

        // ── Methods ──
        public void get_contactSender(){} // RVA: 0x7FFE8284EF60
        public void set_contactSender(){} // RVA: 0x7FFE81D7E9E0
        public void get_contactReceiver(){} // RVA: 0x7FFE826F4210
        public void set_contactReceiver(){} // RVA: 0x7FFE826F4230
        public void get_matchingTags(){} // RVA: 0x7FFE81116380
        public void set_matchingTags(){} // RVA: 0x7FFE810FCE30
    }

    public class ContactManager : MonoBehaviour
    {
        // ── Methods ──
        public void AddContact(){} // RVA: 0x7FFE881CF200
        public void RemoveContact(){} // RVA: 0x7FFE881CF780
        public void GetContacts(){} // RVA: 0x7FFE881CFB80
        public void CalcClosestPoint(){} // RVA: 0x7FFE881CFC50
        public void CalcRelativeVelocity(){} // RVA: 0x7FFE881D0C90
        public void Awake(){} // RVA: 0x7FFE881D1110
        public void OnDestroy(){} // RVA: 0x7FFE881D1540
        public void LateUpdate(){} // RVA: 0x7FFE881D1BB0
        public void ScheduleUpdateReceiversJob(){} // RVA: 0x7FFE881D1C40
        public void HandleDynamicsFrameComplete(){} // RVA: 0x7FFE881D23F0
        public void OnDrawGizmos(){} // RVA: 0x7FFE881D2630
        public void FindAvailableId(){} // RVA: 0x7FFE881D2660
        public void .ctor(){} // RVA: 0x7FFE881D26F0
        public void .cctor(){} // RVA: 0x7FFE881D28F0
        public void Initialize$UpdateReceiversFunctions_CalcProximity_000001D5$BurstDirectCall(){} // RVA: 0x7FFE881D2AC0
    }

    public class ContactReceiver : ContactBase
    {
        public bool allowSelf; // 0xA0

        // ── Methods ──
        public void get_EffectiveReceiverType(){} // RVA: 0x7FFE881D4440
        public void IsReceiver(){} // RVA: 0x7FFE811E0850
        public void Start(){} // RVA: 0x7FFE881D4470
        public void OnDisable(){} // RVA: 0x7FFE881D4870
        public void OnDisableInCollisionScene(){} // RVA: 0x7FFE881D4920
        public void OnReenableInCollisionScene(){} // RVA: 0x7FFE881D49C0
        public void PerformShapeUpdate(){} // RVA: 0x7FFE881D49E0
        public void OnShapeEnter(){} // RVA: 0x7FFE881D4B60
        public void OnShapeExit(){} // RVA: 0x7FFE881D4E60
        public void AddCollision(){} // RVA: 0x7FFE881D4E70
        public void RemoveCollision(){} // RVA: 0x7FFE881D58B0
        public void RemoveFromManagerData(){} // RVA: 0x7FFE881D5BB0
        public void BuildMatchingTagsArray(){} // RVA: 0x7FFE881D5DF0
        public void AttemptAddCollision(){} // RVA: 0x7FFE881D61E0
        public void ValidateCollider(){} // RVA: 0x7FFE881D6430
        public void ValidateColliderPermissions(){} // RVA: 0x7FFE881D66E0
        public void IsColliding(){} // RVA: 0x7FFE881D6890
        public void RequiresUpdate(){} // RVA: 0x7FFE881D68E0
        public void UpdateContact(){} // RVA: 0x7FFE881D6950
        public void RefreshValidatedCollisions(){} // RVA: 0x7FFE881D6C70
        public void UpdateParameter(){} // RVA: 0x7FFE881D6D60
        public void SetParameter(){} // RVA: 0x7FFE881D6DF0
        public void AssignUdonEmitter(){} // RVA: 0x7FFE811660C0
        public void CalculateProximity(){} // RVA: 0x7FFE881D6F10 | overloaded x2
        public void UpdateCollisionTags(){} // RVA: 0x7FFE881D7030
        public void InitCollisionTags(){} // RVA: 0x7FFE881D7160
        public void CheckForMask(){} // RVA: 0x7FFE881D72F0
        public void .ctor(){} // RVA: 0x7FFE881D74B0
        public void .cctor(){} // RVA: 0x7FFE881D76F0
    }

    public class ContactReceiverProxy : ContactBaseProxy`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881CEEE0
        public void Equals(){} // RVA: 0x7FFE881CEF40
        public void op_Equality(){} // RVA: 0x7FFE881CF070
        public void op_Inequality(){} // RVA: 0x7FFE881CF0E0
        public void GetHashCode(){} // RVA: 0x7FFE881CF150
        public void IsValid(){} // RVA: 0x7FFE881CF1C0
    }

    public class ContactReceiverUdonEmitter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE882553F0
        public void OnContactEnter(){} // RVA: 0x7FFE882554A0
        public void OnContactExit(){} // RVA: 0x7FFE882557E0
    }

    public class ContactSender : ContactBase
    {
        // ── Methods ──
        public void IsReceiver(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE881D77D0
    }

    public class ContactSenderProxy : ContactBaseProxy`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881CEBE0
        public void Equals(){} // RVA: 0x7FFE881CEC40
        public void op_Equality(){} // RVA: 0x7FFE881CED50
        public void op_Inequality(){} // RVA: 0x7FFE881CEDC0
        public void GetHashCode(){} // RVA: 0x7FFE881CEE30
        public void IsValid(){} // RVA: 0x7FFE881CEEA0
    }

    public class CorrectQuaternion_000000CA$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE881B8BE0
        public void GetFunctionPointer(){} // RVA: 0x7FFE881B8D20
        public void Constructor(){} // RVA: 0x7FFE881B8E90
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE881B8E90
        public void Invoke(){} // RVA: 0x7FFE881B8F50
    }

    public class CorrectQuaternion_000000CA$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84253010
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE881B8B30
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class DynamicsComponent : MonoBehaviour
    {
        public 0x6665755C _defaultUsage;
        public 0x6665755C _assignedUsage; // 0x20
        public object field_2; // 0x7

        // ── Methods ──
        public void get_DefaultUsage(){} // RVA: 0x7FFE881AB5D0
        public void set_DefaultUsage(){} // RVA: 0x7FFE881AB610
        public void get_Usage(){} // RVA: 0x7FFE881AB650
        public void set_Usage(){} // RVA: 0x7FFE8170B670
        public void get_RawUsage(){} // RVA: 0x7FFE8151D690
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DynamicsSetup : Object
    {
        // ── Methods ──
        public void RuntimeInit(){} // RVA: 0x7FFE81BDE280
        public void Equals(){} // RVA: 0x7FFE81BDE530
        public void GetHashCode(){} // RVA: 0x7FFE81BDE8D0
        public void op_Implicit(){} // RVA: 0x7FFE81BDED00
        public void CompareBaseObjects(){} // RVA: 0x7FFE81BDF080
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81BDF1E0
    }

    public class DynamicsUsageFlagsExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFE87541510 | overloaded x2
    }

    public class FixedTransformAccessArray : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881D7C40
        public void Add(){} // RVA: 0x7FFE881D7E50
        public void Remove(){} // RVA: 0x7FFE881D8030
        public void ChangeId(){} // RVA: 0x7FFE881D8160
        public void FindTransform(){} // RVA: 0x7FFE881D8180
        public void Dispose(){} // RVA: 0x7FFE881D81B0
        public void GetLength(){} // RVA: 0x7FFE8119C080
        public void GetTransformAccessArray(){} // RVA: 0x7FFE81116380
        public void GetLookupToId(){} // RVA: 0x7FFE81703940
        public void GetLookupFromId(){} // RVA: 0x7FFE81E90600
    }

    public class FromToRotation_000000CC$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE881B9250
        public void GetFunctionPointer(){} // RVA: 0x7FFE881B9390
        public void Constructor(){} // RVA: 0x7FFE881B9500
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE881B9500
        public void Invoke(){} // RVA: 0x7FFE881B95C0
    }

    public class FromToRotation_000000CC$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D190C0
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE881B9180
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class ICollisionBroadphase
    {
        // ── Methods ──
        public void get_scene(){} // RVA: 0x7FFE80E2E2E0
        public void set_scene(){} // RVA: 0x7FFE80E460A0
        public void AddShape(){}
        public void RemoveShape(){}
        public void CastShape(){}
        public void ScheduleJobs(){}
        public void OnComplete(){} // RVA: 0x7FFE80E45FE0
        public void DrawGizmos(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class IContactReceiverUdonEmitter
    {
        // ── Methods ──
        public void OnContactEnter(){}
        public void OnContactExit(){}
    }

    public class IMemoryBufferList
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void set_Length(){} // RVA: 0x7FFE80E46530
        public void Move(){}
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Invalidate(){} // RVA: 0x7FFE80E484C0
    }

    public class IMemoryBufferSpanList
    {
        // ── Methods ──
        public void UpdateSpan(){}
    }

    public class IParameterSetup
    {
        // ── Methods ──
        public void InitParameters(){} // RVA: 0x7FFE80E45FE0
    }

    public class IPhysBoneDebugDrawer
    {
        // ── Methods ──
        public void get_Alpha(){} // RVA: 0x7FFE80E42E10
        public void set_Alpha(){} // RVA: 0x7FFE80E53B80
        public void Line(){} // RVA: 0x7FFE810A1420
        public void Sphere(){} // RVA: 0x7FFE810A1420
    }

    public class IPhysBoneRoot
    {
        // ── Methods ──
        public void AddPhysBone(){} // RVA: 0x7FFE80E2E390
        public void RemovePhysBone(){} // RVA: 0x7FFE80E2E390
    }

    public class IPhysBoneUdonEmitter
    {
        // ── Methods ──
        public void OnPhysBoneGrabbed(){}
        public void OnPhysBoneReleased(){}
        public void OnPhysBonePosed(){}
        public void OnPhysBoneUnPosed(){}
    }

    public class IVRCConstraintBinding
    {
        // ── Methods ──
        public void get_ApplicationUnityConstraint(){} // RVA: 0x7FFE80E2E2E0
        public void get_ApplicationVrcConstraint(){} // RVA: 0x7FFE80E2E2E0
        public void Synchronize(){} // RVA: 0x7FFE80E34FA0
        public void RestoreUnityConstraintEnabledState(){} // RVA: 0x7FFE80E45FE0
    }

    public class IsAnyAxisZero_000000C6$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE881B5090
        public void GetFunctionPointer(){} // RVA: 0x7FFE881B51D0
        public void Constructor(){} // RVA: 0x7FFE881B5340
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE881B5340
        public void Invoke(){} // RVA: 0x7FFE881B5400
    }

    public class IsAnyAxisZero_000000C6$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83FBB0C0
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE881B5000
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class IsLowWeightSource_000000C9$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE881B8590
        public void GetFunctionPointer(){} // RVA: 0x7FFE881B86D0
        public void Constructor(){} // RVA: 0x7FFE881B8840
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE881B8840
        public void Invoke(){} // RVA: 0x7FFE881B8900
    }

    public class IsLowWeightSource_000000C9$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881B6260
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE881B6340
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class IsValidTrsMatrix_000000C7$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE881B56B0
        public void GetFunctionPointer(){} // RVA: 0x7FFE881B57F0
        public void Constructor(){} // RVA: 0x7FFE881B5960
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE881B5960
        public void Invoke(){} // RVA: 0x7FFE881B5A20
    }

    public class IsValidTrsMatrix_000000C7$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83FBB0C0
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE881B5620
        public void EndInvoke(){} // RVA: 0x7FFE828C6E90
    }

    public class LookAtVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881C1BB0
        public void SynchronizeInternal(){} // RVA: 0x7FFE881C1C10
    }

    public class MathUtil : Object
    {
        // ── Methods ──
        public void DistancePointToPlane(){} // RVA: 0x7FFE881D8260
        public void ClosestPointOnPlane(){} // RVA: 0x7FFE881D82C0
        public void AngleBetweenTwoNormals(){} // RVA: 0x7FFE881D83F0 | overloaded x2
        public void CartesianToPolar(){} // RVA: 0x7FFE881D8750
        public void PolarToCartesian(){} // RVA: 0x7FFE881D88C0
        public void QuaternionToSwingTwist(){} // RVA: 0x7FFE881D8A50
        public void SwingTwistToQuaternion(){} // RVA: 0x7FFE881D8B40
        public void ClosestPointOnLineSegment_Ratio(){} // RVA: 0x7FFE881D8D40
        public void ClosestPointOnLineSegment(){} // RVA: 0x7FFE881D8E10
        public void ClosestPointsBetweenLineSegments(){} // RVA: 0x7FFE881D8F40
        public void ClosestPointToAABB(){} // RVA: 0x7FFE881D92F0
        public void ClosestPointOnLineSegmentToAABB(){} // RVA: 0x7FFE881D95A0
        public void SignedDistanceFromPointToAABB(){} // RVA: 0x7FFE881DA380
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void <ClosestPointOnLineSegmentToAABB>g__EvaluateLineEnd|12_0(){} // RVA: 0x7FFE881DA510
        public void <ClosestPointOnLineSegmentToAABB>g__EvaluateEdge|12_1(){} // RVA: 0x7FFE881DA790
    }

    public class MemoryBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881DA8E0
        public void Dispose(){} // RVA: 0x7FFE881DAA80
        public void Clear(){} // RVA: 0x7FFE881DAB90
        public void ContainsId(){} // RVA: 0x7FFE881DAC80
        public void FindIndex(){} // RVA: 0x7FFE881DAD10
        public void Request(){} // RVA: 0x7FFE881DADF0
        public void Release(){} // RVA: 0x7FFE881DB010
        public void Compact(){} // RVA: 0x7FFE881DB2B0
        public void PrintDebug(){} // RVA: 0x7FFE881DB6A0
        public void GetFinalDataIndex(){} // RVA: 0x7FFE881DB9D0
    }

    public class ParentChangeDetector : MonoBehaviour
    {
        // ── Methods ──
        public void add_OnParentChanged(){} // RVA: 0x7FFE881AB710
        public void remove_OnParentChanged(){} // RVA: 0x7FFE881AB800
        public void Awake(){} // RVA: 0x7FFE881AB8F0
        public void OnTransformParentChanged(){} // RVA: 0x7FFE8148FC70
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ParentVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881C0AC0
        public void SynchronizeInternal(){} // RVA: 0x7FFE881C0B20
    }

    public class PhysBoneGrabbedInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    }

    public class PhysBoneGroup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881DF630
        public void Dispose(){} // RVA: 0x7FFE881DF820
        public void AddPhysBone(){} // RVA: 0x7FFE881DF880
        public void RemovePhysBone(){} // RVA: 0x7FFE881DFAC0
        public void MarkDirty(){} // RVA: 0x7FFE825203D0
        public void GetChains(){} // RVA: 0x7FFE881DFC30
        public void AddShape(){} // RVA: 0x7FFE881DFEA0
        public void RemoveShape(){} // RVA: 0x7FFE881E00C0
        public void GetShapes(){} // RVA: 0x7FFE8143BA80
    }

    public class PhysBoneManager : MonoBehaviour
    {
        // ── Methods ──
        public void AddPhysBone(){} // RVA: 0x7FFE881E01E0
        public void RemovePhysBone(){} // RVA: 0x7FFE881E0480
        public void HasPhysBone(){} // RVA: 0x7FFE881E0780
        public void FindPhysBone(){} // RVA: 0x7FFE881E0810
        public void MarkRootDirty(){} // RVA: 0x7FFE881E08C0
        public void UpdateStaleGroups(){} // RVA: 0x7FFE881E0980
        public void UpdateRoots(){} // RVA: 0x7FFE881E13F0
        public void GetOrCreateRoot(){} // RVA: 0x7FFE881E15F0
        public void ReassignPhysBoneToRoot(){} // RVA: 0x7FFE881E1820
        public void RemoveChains(){} // RVA: 0x7FFE881E1AF0
        public void AddChains(){} // RVA: 0x7FFE881E2140
        public void ApplyExtraTransforms(){} // RVA: 0x7FFE881E4920
        public void AddCollider(){} // RVA: 0x7FFE881E4BC0
        public void RemoveCollider(){} // RVA: 0x7FFE881E4DD0
        public void GetColliderComponents(){} // RVA: 0x7FFE8179C860
        public void RemoveColliders(){} // RVA: 0x7FFE881E4EA0
        public void AddColliders(){} // RVA: 0x7FFE881E5120
        public void GetChains(){} // RVA: 0x7FFE881E5760
        public void FindChainIndex(){} // RVA: 0x7FFE881E5800
        public void GetChain(){} // RVA: 0x7FFE881E58F0
        public void GetChainComponent(){} // RVA: 0x7FFE881E59F0
        public void SetChain(){} // RVA: 0x7FFE881E5A70
        public void GetBone(){} // RVA: 0x7FFE881E5B70
        public void SetBone(){} // RVA: 0x7FFE881E5C80
        public void GetTransformData(){} // RVA: 0x7FFE881E5D80
        public void CalcLimitAxis(){} // RVA: 0x7FFE881E5FF0 | overloaded x2
        public void AlmostEquals(){} // RVA: 0x7FFE881E6670 | overloaded x2
        public void HasChanged(){} // RVA: 0x7FFE881E6770 | overloaded x2
        public void SafeInverse(){} // RVA: 0x7FFE881E6890
        public void Awake(){} // RVA: 0x7FFE881E69A0
        public void OnDestroy(){} // RVA: 0x7FFE881E6B70
        public void Init(){} // RVA: 0x7FFE881E6FD0
        public void FixedUpdate(){} // RVA: 0x7FFE881E79D0
        public void LateUpdate(){} // RVA: 0x7FFE881E7A40
        public void UpdateChains(){} // RVA: 0x7FFE881E7AF0
        public void UpdateColliderShapes(){} // RVA: 0x7FFE881E85B0
        public void ScheduleReadBoneJob(){} // RVA: 0x7FFE881E8600
        public void ReportCriticalError(){} // RVA: 0x7FFE881E8850
        public void DumpObject(){} // RVA: 0x7FFE881E8C50
        public void ScheduleExecutionJob(){} // RVA: 0x7FFE881E8EA0
        public void ScheduleUpdateRootsJob(){} // RVA: 0x7FFE881E9180
        public void ScheduleExecutionGroupJob(){} // RVA: 0x7FFE881E94E0
        public void CalcBoneScale(){} // RVA: 0x7FFE87C51570
        public void CompleteJob(){} // RVA: 0x7FFE881E9AF0
        public void PrintDebug(){} // RVA: 0x7FFE881EA570 | overloaded x2
        public void OnDrawGizmos(){} // RVA: 0x7FFE881EA880
        public void MarkExecutionGroupStale(){} // RVA: 0x7FFE881EAA10 | overloaded x2
        public void IsCyclicDependency(){} // RVA: 0x7FFE881EAB70
        public void UpdateExecutionGroupsForComponent(){} // RVA: 0x7FFE881EADC0
        public void UpdateExecutionGroupsForRoot(){} // RVA: 0x7FFE881EAF70 | overloaded x2
        public void UpdateExecutionGroups(){} // RVA: 0x7FFE881EB070
        public void UpdateExecutionGroup(){} // RVA: 0x7FFE881EC630
        public void RemoveFromExecutionGroup(){} // RVA: 0x7FFE881ECB10
        public void AddToExecutionGroup(){} // RVA: 0x7FFE881ECC70
        public void MarkGroupListDirty(){} // RVA: 0x7FFE881ECDC0
        public void GetExecutionGroup(){} // RVA: 0x7FFE881ECE00
        public void ClearRootTiming(){} // RVA: 0x7FFE881ECE40
        public void InitCollision(){} // RVA: 0x7FFE881ECFF0
        public void UpdateAndScheduleColliders(){} // RVA: 0x7FFE881ED0F0
        public void UpdateCollidersForChain(){} // RVA: 0x7FFE881ED1D0
        public void UpdateGrabs(){} // RVA: 0x7FFE881EDB30
        public void InteractAllowed(){} // RVA: 0x7FFE881EDE70
        public void AttemptGrab(){} // RVA: 0x7FFE881EFE20 | overloaded x3
        public void IsChainGrabbed(){} // RVA: 0x7FFE881EFEC0
        public void ReleaseGrab(){} // RVA: 0x7FFE881F0A00 | overloaded x2
        public void AddGrab(){} // RVA: 0x7FFE881F0200
        public void GetGrabs(){} // RVA: 0x7FFE881F1220
        public void CreatePose(){} // RVA: 0x7FFE881F12D0
        public void FindOrCreatePose(){} // RVA: 0x7FFE881F1950
        public void RemovePoseForChain(){} // RVA: 0x7FFE881F1A50
        public void RemovePose(){} // RVA: 0x7FFE881F1BD0
        public void FindPose(){} // RVA: 0x7FFE881F2160
        public void .ctor(){} // RVA: 0x7FFE881F22A0
        public void .cctor(){} // RVA: 0x7FFE881F2A90
        public void <IsCyclicDependency>g__RecusriveSearch|124_0(){} // RVA: 0x7FFE881F2EC0
        public void <UpdateExecutionGroups>g__FindSortingData|128_0(){} // RVA: 0x7FFE881F3070
        public void <UpdateExecutionGroups>g__FindParentDependency|128_1(){} // RVA: 0x7FFE881F31D0
    }

    public class PhysBonePosedInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    }

    public class PhysBoneReleasedInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    }

    public class PhysBoneRoot : MonoBehaviour
    {
        public 0x6665A104 timing; // 0x20
        public VRC.Dynamics.PhysBoneRootDefinition _rootDefinition; // 0x28
        public object field_2; // 0x55

        // ── Methods ──
        public void get_RootDefinition(){} // RVA: 0x7FFE81129130
        public void set_RootDefinition(){} // RVA: 0x7FFE810FCE90
        public void get_Timing(){} // RVA: 0x7FFE8151D690
        public void set_Timing(){} // RVA: 0x7FFE88200210
        public void Awake(){} // RVA: 0x7FFE882002E0
        public void get_RequiredHideFlags(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class PhysBoneRootDefinition : Object
    {
        public int NullId;
        public int chainCount; // 0x10
        public int bufferIndex; // 0x14

        // ── Methods ──
        public void get_Transform(){} // RVA: 0x7FFE811290C0
        public void get_AutoEvaluateFixedTime(){} // RVA: 0x7FFE815F1380
        public void set_AutoEvaluateFixedTime(){} // RVA: 0x7FFE88200350
        public void get_UseFixedTime(){} // RVA: 0x7FFE819C2EA0
        public void set_UseFixedTime(){} // RVA: 0x7FFE882003E0
        public void .ctor(){} // RVA: 0x7FFE88200470
    }

    public class PhysBoneUdonEmitter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88255AD0
        public void OnPhysBoneGrabbed(){} // RVA: 0x7FFE88255B80
        public void OnPhysBoneReleased(){} // RVA: 0x7FFE88255D90
        public void OnPhysBonePosed(){} // RVA: 0x7FFE88255FA0
        public void OnPhysBoneUnPosed(){} // RVA: 0x7FFE882561B0
    }

    public class PhysBoneUnPosedInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    }

    public class PositionVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881BFDA0
        public void SynchronizeInternal(){} // RVA: 0x7FFE881BFE00
    }

    public class ReadTransformJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE881AF510
    }

    public class RootsBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881DBAB0
        public void Dispose(){} // RVA: 0x7FFE881DBCB0
        public void AddBoneToRoot(){} // RVA: 0x7FFE881DBD20
        public void RemoveBoneFromRoot(){} // RVA: 0x7FFE881DBD40
        public void TryAddRoot(){} // RVA: 0x7FFE881DBDD0
        public void TryRemoveRoot(){} // RVA: 0x7FFE881DC120
        public void FindRoot(){} // RVA: 0x7FFE881DC2A0
    }

    public class RotationVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881C0200
        public void SynchronizeInternal(){} // RVA: 0x7FFE881C0260
    }

    public class ScaleVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881C0660
        public void SynchronizeInternal(){} // RVA: 0x7FFE881C06C0
    }

    public class TransformPoint_000000C4$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE881B43D0
        public void GetFunctionPointer(){} // RVA: 0x7FFE881B4510
        public void Constructor(){} // RVA: 0x7FFE881B4680
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE881B4680
        public void Invoke(){} // RVA: 0x7FFE881B4740
    }

    public class TransformPoint_000000C4$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D190C0
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE881B4300
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class TransformPoint_000000C5$BurstDirectCall : Object
    {
        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFE881B4A50
        public void GetFunctionPointer(){} // RVA: 0x7FFE881B4B90
        public void Constructor(){} // RVA: 0x7FFE881B4D00
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE881B4D00
        public void Invoke(){} // RVA: 0x7FFE881B4DC0
    }

    public class TransformPoint_000000C5$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D190C0
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE881B4980
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class VRCConstraintBase : DynamicsComponent
    {
        public bool IsActive; // 0x28
        public float GlobalWeight; // 0x2C
        public UnityEngine.Transform TargetTransform; // 0x30
        public bool SolveInLocalSpace; // 0x38
        public bool FreezeToWorld; // 0x39
        public bool RebakeOffsetsWhenUnfrozen; // 0x3A
        public bool Locked; // 0x3B
        public VRC.Dynamics.VRCConstraintSourceKeyableList Sources; // 0x40
        public int _nativeIndex; // 0x2D8
        public int cachedExecutionGroupIndex; // 0x2DC
        public int latestValidExecutionGroupIndex; // 0x2E0
        public UnityEngine.Transform _runtimeTargetTransform; // 0x2E8

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFE80E2EDB0
        public void get_RotationMode(){} // RVA: 0x7FFE80E2EDB0
        public void get_ScaleMode(){} // RVA: 0x7FFE80E2EDB0
        public void get_AffectsPosition(){} // RVA: 0x7FFE881B9800
        public void get_AffectsRotation(){} // RVA: 0x7FFE881B9830
        public void get_AffectsScale(){} // RVA: 0x7FFE881B9860
        public void IsLocalPostProcessIndependent(){} // RVA: 0x7FFE881B9890
        public void get_NativeIndex(){} // RVA: 0x7FFE881B9910
        public void set_NativeIndex(){} // RVA: 0x7FFE881B9920
        public void get_CachedExecutionGroupIndex(){} // RVA: 0x7FFE87AFE610
        public void get_LatestValidExecutionGroupIndex(){} // RVA: 0x7FFE881B9930
        public void SetCachedExecutionGroupIndex(){} // RVA: 0x7FFE881B9940
        public void get_DependencyRoot(){} // RVA: 0x7FFE881B9950
        public void get_DependsOnLocalAvatarProcessing(){} // RVA: 0x7FFE881B9B10
        public void set_DependsOnLocalAvatarProcessing(){} // RVA: 0x7FFE881B9B20
        public void ActivateConstraint(){} // RVA: 0x7FFE881B9B40
        public void ZeroConstraint(){} // RVA: 0x7FFE881B9B70
        public void ApplyZeroOffset(){} // RVA: 0x7FFE80E45FE0
        public void TryBakeCurrentOffsets(){} // RVA: 0x7FFE881B9C60
        public void TryBakeCurrentOffsetsRuntime(){} // RVA: 0x7FFE881B9D10
        public void AcceptOffsetBaker(){} // RVA: 0x7FFE80E460A0
        public void RegisterBakeListener(){} // RVA: 0x7FFE881BA0A0
        public void UnRegisterBakeListener(){} // RVA: 0x7FFE881BA110
        public void AssignBinding(){} // RVA: 0x7FFE881BA170
        public void GetBoundUnityConstraint(){} // RVA: 0x7FFE881BA620
        public void AddToLocalGameObjectOrder(){} // RVA: 0x7FFE881BA680
        public void RemoveFromLocalGameObjectOrder(){} // RVA: 0x7FFE881BAC60
        public void CalculateOrder(){} // RVA: 0x7FFE881BAEB0
        public void IsDependentOnTransform(){} // RVA: 0x7FFE881BB1C0
        public void GetEffectiveTargetTransform(){} // RVA: 0x7FFE881BB320
        public void SetupAvatarConstraint(){} // RVA: 0x7FFE881BB450
        public void SetupWorldConstraint(){} // RVA: 0x7FFE881BB6E0
        public void SetupPropConstraint(){} // RVA: 0x7FFE881BB820
        public void Awake(){} // RVA: 0x7FFE881BB960
        public void Start(){} // RVA: 0x7FFE881BBCF0
        public void OnEnable(){} // RVA: 0x7FFE881BBD60
        public void OnDisable(){} // RVA: 0x7FFE881BBE60
        public void OnDestroy(){} // RVA: 0x7FFE881BBF30
        public void Dispose(){} // RVA: 0x7FFE881BBF40
        public void GetTransformCount(){} // RVA: 0x7FFE881BC020
        public void RecalculateTransformCount(){} // RVA: 0x7FFE881BC070
        public void GetTransforms(){} // RVA: 0x7FFE881BC280
        public void GetManagedWorldUpTransform(){} // RVA: 0x7FFE813240E0
        public void AllocateJobData(){} // RVA: 0x7FFE881BC5E0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE881BCA00
        public void ShouldCheckForChangingTargetParent(){} // RVA: 0x7FFE881BCA10
        public void RequiresReallocation(){} // RVA: 0x7FFE881BCA70
        public void SynchronizeWithBinding(){} // RVA: 0x7FFE881BCFB0
        public void CheckReallocation(){} // RVA: 0x7FFE881BD040
        public void EstablishTargetTransform(){} // RVA: 0x7FFE881BD160
        public void ReEvaluatePhysBoneOrder(){} // RVA: 0x7FFE881BD530
        public void GatherPotentiallyDependentPhysBones(){} // RVA: 0x7FFE881BD7C0
        public void DeterminePhysBoneDependency(){} // RVA: 0x7FFE881BDA00
        public void EstablishPlayerLoopStage(){} // RVA: 0x7FFE881BDC40
        public void AssignPlayerLoopStage(){} // RVA: 0x7FFE881BDE30
        public void InvalidatePlayerLoopStage(){} // RVA: 0x7FFE881BDFC0
        public void UpdateJobData(){} // RVA: 0x7FFE881BDFD0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFE80E460A0
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7FFE810FB310
        public void AffectsAnyAxis(){} // RVA: 0x7FFE80E2F150
        public void PostUpdateJobData(){} // RVA: 0x7FFE881BE500
        public void CreateAxisBitfield(){} // RVA: 0x7FFE881BE560
        public void RequestFullNativeUpdate(){} // RVA: 0x7FFE881BCA00
        public void GetPerSourcePositionOffsets(){} // RVA: 0x7FFE881BE580
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE881BE650
        public void get_IsPendingUnprocessed(){} // RVA: 0x7FFE881BE910
        public void set_IsPendingUnprocessed(){} // RVA: 0x7FFE881BE920
        public void CalculateDependencies(){} // RVA: 0x7FFE881BE930
        public void TraverseDependencies(){} // RVA: 0x7FFE881BEC30
        public void ReorganizeGroupsFastForRoot(){} // RVA: 0x7FFE881BEEF0
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFE881BCA00
        public void .ctor(){} // RVA: 0x7FFE881BF9A0
        public void .cctor(){} // RVA: 0x7FFE881BFB60
    }

    public class VRCConstraintGroup : Object
    {
        public int MinGroupCapacity;

        // ── Methods ──
        public void get_MemberCount(){} // RVA: 0x7FFE881ACE20
        public void .ctor(){} // RVA: 0x7FFE881ACE60
        public void Dispose(){} // RVA: 0x7FFE881ACF20
        public void AddConstraint(){} // RVA: 0x7FFE881ACF60
        public void RemoveConstraintSwapBack(){} // RVA: 0x7FFE881AD1B0
        public void RemoveConstraintAtSwapBack(){} // RVA: 0x7FFE881AD270
        public void UpdateNativeIndex(){} // RVA: 0x7FFE881AD2B0
        public void RemoveAtSwapBack(){} // RVA: 0x7FFE881AD440
    }

    public class VRCConstraintGrouper : Object
    {
        public System.Collections.Generic.SortedDictionary`2<int,VRC.Dynamics.VRCConstraintGroup> _executionGroups; // 0x10
        public System.Collections.Generic.HashSet`1<UnityEngine.Transform> _staleRootTransforms; // 0x18

        // ── Methods ──
        public void get_GroupsAreStale(){} // RVA: 0x7FFE881AD570
        public void get_ExecutionGroups(){} // RVA: 0x7FFE881AD5F0
        public void .ctor(){} // RVA: 0x7FFE881AD660
        public void Dispose(){} // RVA: 0x7FFE881AD860
        public void RecordConstraintToAdd(){} // RVA: 0x7FFE881ADB40
        public void RecordConstraintToRemove(){} // RVA: 0x7FFE881ADC20
        public void MarkRootStale(){} // RVA: 0x7FFE881AE370
        public void GetConstraintListForRoot(){} // RVA: 0x7FFE881AE3F0
        public void RefreshGroups(){} // RVA: 0x7FFE881AE510
        public void PrepareGroupsForReorganize(){} // RVA: 0x7FFE881AEC40
        public void .cctor(){} // RVA: 0x7FFE881AF3C0
    }

    public class VRCConstraintJob : ValueType
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE881AF570
        public void ProcessSource(){} // RVA: 0x7FFE881B12F0
        public void FinalizeLocalScaleResult(){} // RVA: 0x7FFE881B2380
        public void PerformAimAt(){} // RVA: 0x7FFE881B26F0
        public void TransformPoint(){} // RVA: 0x7FFE881B35E0 | overloaded x2
        public void IsAnyAxisZero(){} // RVA: 0x7FFE881B3650
        public void IsValidTrsMatrix(){} // RVA: 0x7FFE881B36A0
        public void ConstraintHasSingleLowWeightSource(){} // RVA: 0x7FFE881B36F0
        public void IsLowWeightSource(){} // RVA: 0x7FFE881B3740
        public void CorrectQuaternion(){} // RVA: 0x7FFE881B37A0
        public void GetTransformLossyScale(){} // RVA: 0x7FFE881A6A30
        public void FromToRotation(){} // RVA: 0x7FFE881B3800
        public void CalculateEulerZXY(){} // RVA: 0x7FFE881B3870
        public void .cctor(){} // RVA: 0x7FFE881B3A90
        public void TransformPoint$BurstManaged(){} // RVA: 0x7FFE881B3BF0 | overloaded x2
        public void IsAnyAxisZero$BurstManaged(){} // RVA: 0x7FFE881B3CA0
        public void IsValidTrsMatrix$BurstManaged(){} // RVA: 0x7FFE881B3CD0
        public void ConstraintHasSingleLowWeightSource$BurstManaged(){} // RVA: 0x7FFE881B3D30
        public void IsLowWeightSource$BurstManaged(){} // RVA: 0x7FFE881B3DF0
        public void CorrectQuaternion$BurstManaged(){} // RVA: 0x7FFE881B3E20
        public void FromToRotation$BurstManaged(){} // RVA: 0x7FFE881B3F80
    }

    public class VRCConstraintJobData : ValueType
    {
    }

    public class VRCConstraintManager : Object
    {
        public int JobBatchCount;
        public int MinArrayCapacity;

        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7FFE881C2030
        public void get_CanExecuteConstraintJobsInEditMode(){} // RVA: 0x7FFE881C2090
        public void Initialize(){} // RVA: 0x7FFE881C20F0
        public void HandleQuit(){} // RVA: 0x7FFE881C28D0
        public void UnInitialize(){} // RVA: 0x7FFE881C2940
        public void RegisterConstraint(){} // RVA: 0x7FFE881C2D40
        public void UnregisterConstraint(){} // RVA: 0x7FFE881C3960
        public void ReRegisterConstraint(){} // RVA: 0x7FFE881C4BF0
        public void ReRegisterSameObjectConstraint(){} // RVA: 0x7FFE881C4C80
        public void IsConstraintRegistered(){} // RVA: 0x7FFE881C4D50
        public void GetBufferedTransform(){} // RVA: 0x7FFE881C4E00
        public void SetBufferedTransform(){} // RVA: 0x7FFE881C4EB0
        public void GetFinalTransformIndex(){} // RVA: 0x7FFE881C5150
        public void UpdateConstraints(){} // RVA: 0x7FFE881C5550
        public void ScheduleReadJob(){} // RVA: 0x7FFE881C5B20
        public void ScheduleExecutionJobs(){} // RVA: 0x7FFE881C5D20
        public void PostUpdateConstraints(){} // RVA: 0x7FFE881C6390
        public void TryCreateSubstituteConstraint(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE881C6610
    }

    public class VRCConstraintOffsetBaker : Object
    {
        public UnityEngine.Transform _targetTransform; // 0x10
        public float _weightSum; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881C6900
        public void get_ShouldBakeAtRest(){} // RVA: 0x7FFE8743CC00
        public void get_ShouldBakeOffsets(){} // RVA: 0x7FFE8781BA60
        public void Bake(){} // RVA: 0x7FFE881C6F80 | overloaded x5
        public void CalculateBakedPositionOffset(){} // RVA: 0x7FFE881C7A20
        public void CalculateBakedRotationOffset(){} // RVA: 0x7FFE881C8370
        public void CalculateBakedScaleOffset(){} // RVA: 0x7FFE881C8B00
        public void AsSignedEulers(){} // RVA: 0x7FFE881C90B0
        public void <AsSignedEulers>g__TreatEuler|16_0(){} // RVA: 0x7FFE881C91A0
    }

    public class VRCConstraintSource : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881C93B0 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFE881C9430
    }

    public class VRCConstraintSourceKeyableList : ValueType
    {
        public int MaxFlatLength;
        public VRC.Dynamics.VRCConstraintSource source0; // 0x10
        public VRC.Dynamics.VRCConstraintSource source1; // 0x38
        public VRC.Dynamics.VRCConstraintSource source2; // 0x60
        public VRC.Dynamics.VRCConstraintSource source3; // 0x88
        public VRC.Dynamics.VRCConstraintSource source4; // 0xB0
        public VRC.Dynamics.VRCConstraintSource source5; // 0xD8
        public VRC.Dynamics.VRCConstraintSource source6; // 0x100
        public VRC.Dynamics.VRCConstraintSource source7; // 0x128

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE881C9540
        public void get_OverflowList(){} // RVA: 0x7FFE881C9550
        public void get_ValueEnumerator(){} // RVA: 0x7FFE881C9620
        public void .ctor(){} // RVA: 0x7FFE881C9BD0 | overloaded x2
        public void Get(){} // RVA: 0x7FFE881CB090
        public void Set(){} // RVA: 0x7FFE881CB390
        public void GetEnumerator(){} // RVA: 0x7FFE881CB9D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE881CB9D0
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE881CB9E0
        public void Add(){} // RVA: 0x7FFE881CBA90
        public void Clear(){} // RVA: 0x7FFE881CBAE0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE881CBB60
        public void IndexOf(){} // RVA: 0x7FFE881CBC00
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE881CBD30
        public void Contains(){} // RVA: 0x7FFE881CBE00
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE881CBF30
        public void CopyTo(){} // RVA: 0x7FFE881CC130
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE881CC340
        public void Remove(){} // RVA: 0x7FFE881CC3E0
        public void RemoveAt(){} // RVA: 0x7FFE881CC520
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE881CC700
        public void Insert(){} // RVA: 0x7FFE881CC7A0
        public void SetLength(){} // RVA: 0x7FFE881CC8F0
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE811E0850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE881CCC60
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE881CCCB0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE881CCD30
        public void get_Item(){} // RVA: 0x7FFE881CCDD0
        public void set_Item(){} // RVA: 0x7FFE881CCE10
    }

    public class VRCDynamicsLoop : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE81BE93D0
        public void Equals(){} // RVA: 0x7FFE81BE9520
        public void GetHashCode(){} // RVA: 0x7FFE81BE9610
    }

    public class VRCDynamicsScheduler : Object
    {
        // ── Methods ──
        public void add_OnPreScheduleComplete(){} // RVA: 0x7FFE881AB950
        public void remove_OnPreScheduleComplete(){} // RVA: 0x7FFE881ABAA0
        public void add_OnFrameComplete(){} // RVA: 0x7FFE881ABBF0
        public void remove_OnFrameComplete(){} // RVA: 0x7FFE881ABD40
        public void add_OnFrameCompleteLate(){} // RVA: 0x7FFE881ABE90
        public void remove_OnFrameCompleteLate(){} // RVA: 0x7FFE881ABFE0
        public void Initialize(){} // RVA: 0x7FFE881AC130
        public void UpdateConstraints(){} // RVA: 0x7FFE881AC290
        public void PreScheduleDynamics(){} // RVA: 0x7FFE881AC320
        public void HandleFinishedPreScheduleDynamics(){} // RVA: 0x7FFE881AC760
        public void PostScheduleDynamics(){} // RVA: 0x7FFE881AC800
        public void CompleteDynamicsFrame(){} // RVA: 0x7FFE881AC970
        public void OnCameraPreCull(){} // RVA: 0x7FFE881ACB10
        public void FinalizeJob(){} // RVA: 0x7FFE881ACB60
        public void SignalFrameComplete(){} // RVA: 0x7FFE881ACC30
        public void HandleEditorPlayModeToggle(){} // RVA: 0x7FFE881ACD60
        public void .cctor(){} // RVA: 0x7FFE881ACDC0
    }

    public class VRCPhysBoneBase : DynamicsComponent
    {
        public bool foldout_transforms; // 0x28
        public bool foldout_forces; // 0x29
        public bool foldout_collision; // 0x2A
        public bool foldout_stretchsquish; // 0x2B
        public bool foldout_limits; // 0x2C
        public bool foldout_grabpose; // 0x2D
        public bool foldout_options; // 0x2E
        public bool foldout_gizmos; // 0x2F
        public string PARAM_ISGRABBED;

        // ── Methods ──
        public void GetRootTransform(){} // RVA: 0x7FFE882004E0
        public void IsCollisionAllowed(){} // RVA: 0x7FFE88200600
        public void IsGrabAllowed(){} // RVA: 0x7FFE88200690
        public void IsPoseAllowed(){} // RVA: 0x7FFE88200770
        public void GetPlayerId(){} // RVA: 0x7FFE88200830
        public void BuildChainId(){} // RVA: 0x7FFE88200860
        public void GenerateArbitraryChainId(){} // RVA: 0x7FFE88200980
        public void get_SortingBaseTransform(){} // RVA: 0x7FFE88200AB0
        public void GetKnownDependencies(){} // RVA: 0x7FFE88200AC0
        public void get_MaximumExecutionGroups(){} // RVA: 0x7FFE88200CF0
        public void get_ExecutionGroup(){} // RVA: 0x7FFE88200D20
        public void set_ExecutionGroup(){} // RVA: 0x7FFE88200D30
        public void HandleTransformParentChanged(){} // RVA: 0x7FFE88200D40
        public void ReEstablishPhysBoneRoot(){} // RVA: 0x7FFE88200F10
        public void Reset(){} // RVA: 0x7FFE88201370
        public void Awake(){} // RVA: 0x7FFE882013D0
        public void Start(){} // RVA: 0x7FFE88201570
        public void OnEnable(){} // RVA: 0x7FFE88201760
        public void OnDisable(){} // RVA: 0x7FFE88201860
        public void OnDestroy(){} // RVA: 0x7FFE88201980
        public void InitParameters(){} // RVA: 0x7FFE88201AC0
        public void InitColliders(){} // RVA: 0x7FFE88201B50
        public void InitTransforms(){} // RVA: 0x7FFE88201E30
        public void ResetTransformsToRestPosition(){} // RVA: 0x7FFE882021C0
        public void CalcBoneRatio(){} // RVA: 0x7FFE882024E0
        public void CalcTransformRatio(){} // RVA: 0x7FFE882025F0
        public void CalcRadius(){} // RVA: 0x7FFE882026D0
        public void CalcPull(){} // RVA: 0x7FFE88202770
        public void CalcSpring(){} // RVA: 0x7FFE88202830
        public void CalcStiffness(){} // RVA: 0x7FFE882028F0
        public void CalcImmobile(){} // RVA: 0x7FFE882029B0
        public void CalcMaxAngle(){} // RVA: 0x7FFE88202A80
        public void CalcLimitRotation(){} // RVA: 0x7FFE88202BD0
        public void CalcMaxStretch(){} // RVA: 0x7FFE88202DC0
        public void CalcStretchMotion(){} // RVA: 0x7FFE88202E70
        public void CalcMaxSquish(){} // RVA: 0x7FFE88202F40
        public void CalcGravity(){} // RVA: 0x7FFE88203010
        public void CalcGravityFalloff(){} // RVA: 0x7FFE882030B0
        public void SafeEvaluate(){} // RVA: 0x7FFE88203180
        public void OnShapeEnter(){} // RVA: 0x7FFE88203210
        public void OnShapeExit(){} // RVA: 0x7FFE882035D0
        public void OnCollidersUpdated(){} // RVA: 0x7FFE882036B0
        public void IsInteractionAllowed(){} // RVA: 0x7FFE882036C0
        public void get_HasUdonEmitter(){} // RVA: 0x7FFE88203790
        public void get_IsGrabbed(){} // RVA: 0x7FFE86DA7D90
        public void get_IsPosed(){} // RVA: 0x7FFE882037A0
        public void get_Angle(){} // RVA: 0x7FFE882037B0
        public void get_Stretch(){} // RVA: 0x7FFE87AFD4C0
        public void get_Squish(){} // RVA: 0x7FFE882037C0
        public void GetIsGrabbed(){} // RVA: 0x7FFE86DA7D90
        public void SetGrab(){} // RVA: 0x7FFE882037D0
        public void SetIsPosed(){} // RVA: 0x7FFE88203AC0
        public void SetAngle(){} // RVA: 0x7FFE88203D60
        public void SetStretch(){} // RVA: 0x7FFE88203DD0
        public void SetSquish(){} // RVA: 0x7FFE88203E40
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFE88203EB0
        public void ReleaseGrabs(){} // RVA: 0x7FFE88203EC0
        public void ReleasePoses(){} // RVA: 0x7FFE88203F50
        public void AssignUdonEmitter(){} // RVA: 0x7FFE815ADA20
        public void .ctor(){} // RVA: 0x7FFE88204040
        public void .cctor(){} // RVA: 0x7FFE88204490
        public void <InitTransforms>g__GetTransforms|119_0(){} // RVA: 0x7FFE882044D0
    }

    public class VRCPhysBoneColliderBase : DynamicsComponent
    {
        public UnityEngine.Transform rootTransform; // 0x28
        public 0x6665A5D4 shapeType; // 0x30
        public bool insideBounds; // 0x34
        public float radius; // 0x38
        public float height; // 0x3C

        // ── Methods ──
        public void GetRootTransform(){} // RVA: 0x7FFE882051C0
        public void get_axis(){} // RVA: 0x7FFE882052E0
        public void get_isGlobalCollider(){} // RVA: 0x7FFE882054E0
        public void set_isGlobalCollider(){} // RVA: 0x7FFE882054F0
        public void GetPlayerId(){} // RVA: 0x7FFE88205510
        public void get_MaximumExecutionGroups(){} // RVA: 0x7FFE88200CF0
        public void get_ExecutionGroup(){} // RVA: 0x7FFE8194AD00
        public void set_ExecutionGroup(){} // RVA: 0x7FFE8194A400
        public void get_SortingBaseTransform(){} // RVA: 0x7FFE88205530
        public void GetKnownDependencies(){} // RVA: 0x7FFE810FB310
        public void Awake(){} // RVA: 0x7FFE88205540
        public void OnEnable(){} // RVA: 0x7FFE882056E0
        public void OnDisable(){} // RVA: 0x7FFE88205750
        public void OnDestroy(){} // RVA: 0x7FFE88205940
        public void InitShape(){} // RVA: 0x7FFE88205A80
        public void UpdateShape(){} // RVA: 0x7FFE88205D60
        public void GetBounds(){} // RVA: 0x7FFE88205F70
        public void HandleParentChanged(){} // RVA: 0x7FFE88206640
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFE88206800
        public void UpdatePendingColliderShapes(){} // RVA: 0x7FFE882068A0
        public void IsShapeStale(){} // RVA: 0x7FFE88206BA0
        public void .ctor(){} // RVA: 0x7FFE88206DC0
        public void .cctor(){} // RVA: 0x7FFE88206EA0
        public void <IsShapeStale>g__FloatsEqual|42_0(){} // RVA: 0x7FFE88206F80
    }

}