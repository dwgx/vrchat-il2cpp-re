// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics
// Classes: 81
// Methods: 793

namespace VRC.Dynamics
{
    public class AbstractVRCConstraintBinding`2 : Object
    {
        public U ApplicationUnityConstraint;
        public T ApplicationVrcConstraint;
        public bool _unityConstraintPendingReEnable;
        public bool _hasEverFullySynced;
        public bool _isDisposed;

        // ── Methods ──
        public void get_ApplicationUnityConstraint(){} // RVA: 0x7FFAC2C58E90
        public void get_ApplicationVrcConstraint(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Synchronize(){} // RVA: 0x7FFAC2C5FB50
        public void SynchronizeInternal(){} // RVA: 0x7FFAC2C59960
        public void RestoreUnityConstraintEnabledState(){} // RVA: 0x7FFAC2C70980
        public void ChangeProperty(){} // RVA: 0x7FFAC2C5A350 | overloaded x5
        public void <Synchronize>g__PushResult|11_0(){} // RVA: 0x7FFAC2C76370
    }

    public class AimVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E14750
        public void SynchronizeInternal(){} // RVA: 0x7FFAC9E147B0
        public void ToVrcWorldUpType(){} // RVA: 0x7FFAC9E14FB0
    }

    public class AnimParameterAccessAvatarSDK : Object
    {
        public UnityEngine.Animator boolVal; // 0x10
        public int intVal; // 0x18
        public 0x6B29C6F8 floatVal; // 0x1C
        public bool valid; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E204D0
        public void get_boolVal(){} // RVA: 0x7FFAC9E20760
        public void set_boolVal(){} // RVA: 0x7FFAC9E20860
        public void get_intVal(){} // RVA: 0x7FFAC9E20970
        public void set_intVal(){} // RVA: 0x7FFAC9E20A60
        public void get_floatVal(){} // RVA: 0x7FFAC9E20B70
        public void set_floatVal(){} // RVA: 0x7FFAC9E20C60
    }

    public class BoneBuffer : Object
    {
        public Unity.Collections.NativeList`1<Bone> Length; // 0x10
        public Unity.Collections.NativeList`1<TransformData> transformData; // 0x18
        public Unity.Collections.NativeList`1<UnityEngine.Jobs.TransformAccess> transformAccess; // 0x20
        public UnityEngine.Jobs.TransformAccessArray transformArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E2E150
        public void get_Length(){} // RVA: 0x7FFAC9E2E2E0
        public void set_Length(){} // RVA: 0x7FFAC9E2E330
        public void Move(){} // RVA: 0x7FFAC9E2E570
        public void Dispose(){} // RVA: 0x7FFAC9E2EA50
        public void Clear(){} // RVA: 0x7FFAC9E2EB40
        public void Invalidate(){} // RVA: 0x7FFAC9E2EC50
    }

    public class ChainBuffer : Object
    {
        public Unity.Collections.NativeList`1<Chain> Length; // 0x10
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneBase> Capacity; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E2D310
        public void get_Length(){} // RVA: 0x7FFAC9E2D450
        public void set_Length(){} // RVA: 0x7FFAC9E2D4A0
        public void get_Capacity(){} // RVA: 0x7FFAC9E2D630
        public void Move(){} // RVA: 0x7FFAC9E2D680
        public void Dispose(){} // RVA: 0x7FFAC9E2D9C0
        public void Clear(){} // RVA: 0x7FFAC9E2DC30
        public void UpdateSpan(){} // RVA: 0x7FFAC9E2DEE0
        public void RemoveAt(){} // RVA: 0x7FFAC9E2E0B0
        public void Invalidate(){} // RVA: 0x7FFAC2F21310
    }

    public class ChainId : ValueType
    {
        public VRC.Dynamics.ChainId A;
        public ulong B; // 0x10
        public ulong b; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC485CA00
        public void Equals(){} // RVA: 0x7FFAC9E29C50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9E29D70
        public void op_Equality(){} // RVA: 0x7FFAC485CA30
        public void op_Inequality(){} // RVA: 0x7FFAC485CA50
        public void ToString(){} // RVA: 0x7FFAC9E29F50
        public void get_A(){} // RVA: 0x7FFAC3AD9F60
        public void get_B(){} // RVA: 0x7FFAC4420220
        public void .cctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CollisionBroadphase_HashGrid : Object
    {
        public int scene;
        public float GRID_SIZE;
        public float GRID_MULTI;
        public int MAX_COLLISIONS_PER_SHAPE;
        public int MAX_COLLISIONS;
        public int MAX_SHAPE_UPDATE;
        public int MAP_START_CAPACITY;
        public VRC.Dynamics.CollisionScene <scene>k__BackingField; // 0x10
        public Unity.Collections.NativeParallelMultiHashMap`2<UnityEngine.Vector3Int,int> shapeMap; // 0x18
        public Unity.Collections.NativeQueue`1<int> shapesToUpdate; // 0x28
        public Unity.Collections.NativeArray`1<int> collisions; // 0x30

        // ── Methods ──
        public void get_scene(){} // RVA: 0x7FFAC2F3C380
        public void set_scene(){} // RVA: 0x7FFAC2F22E30
        public void AddShape(){} // RVA: 0x7FFAC9DF0280
        public void RemoveShape(){} // RVA: 0x7FFAC9DF02D0
        public void CastShape(){} // RVA: 0x7FFAC2F21310
        public void DrawGizmos(){} // RVA: 0x7FFAC2F21310
        public void ScheduleJobs(){} // RVA: 0x7FFAC9DF0500
        public void OnComplete(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC9DF0C80
        public void .ctor(){} // RVA: 0x7FFAC9DF0D10
        public void .cctor(){} // RVA: 0x7FFAC9DF0EC0
    }

    public class CollisionBroadphase_HybridSAP : Object
    {
        public int scene;
        public int CELL_BATCH_COUNT; // 0x4
        public float GRID_SIZE;
        public float GRID_MULTI;
        public int GRID_MAP_START_CAPACITY;
        public int GRID_CELL_MAX_CACHE;
        public int GRID_CELL_MAX_ACTIVE_LIST;
        public int MAX_COLLISION_PAIRS;
        public int INITIAL_COLLISIONS_PER_CELL;
        public int MAX_COLLISIONS_PER_CELL;
        public VRC.Dynamics.CollisionScene <scene>k__BackingField; // 0x10
        public Unity.Collections.NativeQueue`1<ushort> shapesToUpdate; // 0x18
        public Unity.Collections.NativeParallelHashMap`2<Pair,bool> collisionPairs; // 0x20
        public Unity.Collections.NativeList`1<Pair> prevCollisionPairs; // 0x30
        public Unity.Collections.NativeHashMap`2<UnityEngine.Vector3Int,int> gridMap; // 0x38
        public Unity.Collections.NativeList`1<GridCell> gridCells; // 0x40
        public Unity.Collections.NativeList`1<int> cellCache; // 0x48

        // ── Methods ──
        public void get_scene(){} // RVA: 0x7FFAC2F3C380
        public void set_scene(){} // RVA: 0x7FFAC2F22E30
        public void AddShape(){} // RVA: 0x7FFAC2F21310
        public void RemoveShape(){} // RVA: 0x7FFAC9DF2E10
        public void CastShape(){} // RVA: 0x7FFAC9DF41D0 | overloaded x2
        public void ScheduleJobs(){} // RVA: 0x7FFAC9DF35E0
        public void OnComplete(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC9DF3EB0
        public void DrawGizmos(){} // RVA: 0x7FFAC9DF4660
        public void .ctor(){} // RVA: 0x7FFAC9DF4CC0
        public void .cctor(){} // RVA: 0x7FFAC9DF4ED0
    }

    public class CollisionScene : Object
    {
        public VRC.Dynamics.ICollisionBroadphase broadphase; // 0x10
        public System.Collections.Generic.HashSet`1<ushort> CastBuffer;
        public System.Collections.Generic.List`1<Shape> deadShapes; // 0x18
        public int MAX_SHAPES_NONWORLD;
        public int MAX_SHAPES_WORLD;
        public int MAX_SHAPES;
        public int MAX_TRANSFORMS;
        public int MAX_COLLISION_EVENTS;
        public Shape[] shapes; // 0x20
        public System.Collections.Generic.HashSet`1<Shape> shapesToAdd; // 0x28
        public System.Collections.Generic.HashSet`1<Shape> shapesToRemove; // 0x30
        public Unity.Collections.NativeList`1<ushort> activeShapes; // 0x38
        public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x40
        public ushort totalActiveNonWorldShapes; // 0x50
        public ushort totalActiveWorldShapes; // 0x52
        public Unity.Collections.NativeQueue`1<CollisionEvent> collisionEvents; // 0x58
        public VRC.Dynamics.FixedTransformAccessArray transforms; // 0x60
        public Unity.Collections.NativeArray`1<UnityEngine.Jobs.TransformAccess> transformData; // 0x68
        public VRC.Core.Burst.DisposableJobHandle jobHandle; // 0x78
        public bool jobHandlePendingCompletion; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9DF80B0 | overloaded x2
        public void SetBroadphase(){} // RVA: 0x7FFAC9DF8750
        public void GetBroadphase(){} // RVA: 0x7FFAC2F3C380
        public void AddShape(){} // RVA: 0x7FFAC9DF8870
        public void RemoveShape(){} // RVA: 0x7FFAC9DF8920
        public void UpdateShapeData(){} // RVA: 0x7FFAC9DF89C0
        public void GetShapeData(){} // RVA: 0x7FFAC9DF8DF0 | overloaded x2
        public void ShapeCount(){} // RVA: 0x7FFAC9DF8E90
        public void CastSphere(){} // RVA: 0x7FFAC9DF8EE0
        public void UpdateBounds(){} // RVA: 0x7FFAC9DF94A0
        public void UpdateAndSchedule(){} // RVA: 0x7FFAC9DF9670
        public void ScheduleReadTransforms(){} // RVA: 0x7FFAC9DF9830
        public void ScheduleUpdateShapePositions(){} // RVA: 0x7FFAC9DF9A10
        public void Complete(){} // RVA: 0x7FFAC9DF9CD0
        public void Dispose(){} // RVA: 0x7FFAC9DF9EC0
        public void SyncShapesNow(){} // RVA: 0x7FFAC9DFA0F0
        public void RemoveShapes(){} // RVA: 0x7FFAC9DFA100
        public void AddShapes(){} // RVA: 0x7FFAC9DFA900
        public void FindAvailableId(){} // RVA: 0x7FFAC9DFAFE0
        public void DrawGizmos(){} // RVA: 0x7FFAC9DFB080
        public void .cctor(){} // RVA: 0x7FFAC9DFB150
    }

    public class CollisionShapes : Object
    {
        // ── Methods ──
        public void CheckCollision(){} // RVA: 0x7FFAC9DFDCB0
        public void CheckCollision_AABB(){} // RVA: 0x7FFAC9DFE080
        public void CheckCollision_Sphere(){} // RVA: 0x7FFAC9DFE0B0
        public void CheckCollision_Capsule(){} // RVA: 0x7FFAC9DFE1D0
        public void Overlap_AABB_Sphere(){} // RVA: 0x7FFAC3006850
        public void Overlap_AABB_Capsule(){} // RVA: 0x7FFAC3006850
        public void Overlap_Sphere_Sphere(){} // RVA: 0x7FFAC9DFE3B0
        public void Overlap_Sphere_Capsule(){} // RVA: 0x7FFAC9DFE410
        public void Overlap_Capsule_Capsule(){} // RVA: 0x7FFAC9DFE5A0
    }

    public class ConstraintHasSingleLowWeightSource_000000B8$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9E09150
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9E09290
        public void Constructor(){} // RVA: 0x7FFAC9E09400
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9E09400
        public void Invoke(){} // RVA: 0x7FFAC9E094C0
    }

    public class ConstraintHasSingleLowWeightSource_000000B8$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5C82610
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC9E090C0
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class ContactBase : DynamicsComponent
    {
        public float axis;
        public int IsLocalOnly;
        public System.Func`2<VRC.Dynamics.ContactBase,bool> AffectedByAllowFlags;
        public UnityEngine.Transform rootTransform; // 0x28
        public 0x6B25ED70 shapeType; // 0x30
        public float radius; // 0x34
        public float height; // 0x38
        public UnityEngine.Vector3 position; // 0x3C
        public UnityEngine.Quaternion rotation; // 0x48
        public bool localOnly; // 0x58
        public 0x6B25DAE0 contentTypes; // 0x5C
        public System.Collections.Generic.List`1<string> collisionTags; // 0x60
        public VRC.Dynamics.ContactManager manager; // 0x68
        public bool allowInit; // 0x70
        public bool hasInitParams; // 0x71
        public bool hasInit; // 0x72
        public Shape shape; // 0x78
        public System.Func`2<UnityEngine.Component,int> getPlayerIdCallback; // 0x80
        public int playerId; // 0x88
        public bool pendingShapeUpdate; // 0x8C
        public System.Func`3<int,int,bool> OnValidatePlayers; // 0x8

        // ── Methods ──
        public void GetRootTransform(){} // RVA: 0x7FFAC9E20D80
        public void get_axis(){} // RVA: 0x7FFAC9E20EA0
        public void get_IsLocalOnly(){} // RVA: 0x7FFAC313F600
        public void Start(){} // RVA: 0x7FFAC9E210A0
        public void OnEnable(){} // RVA: 0x7FFAC9E21210
        public void OnDisable(){} // RVA: 0x7FFAC9E21290
        public void ValidateTagsList(){} // RVA: 0x7FFAC9E21310
        public void InitParameters(){} // RVA: 0x7FFAC9E21470
        public void Init(){} // RVA: 0x7FFAC9E214E0
        public void GetPlayerId(){} // RVA: 0x7FFAC9E215F0
        public void IsReceiver(){} // RVA: 0x7FFAC2C59D00
        public void RequiresUpdate(){} // RVA: 0x7FFAC9E21620
        public void get_AffectedByAllowFlags(){} // RVA: 0x7FFAC9E21660
        public void UpdateContact(){} // RVA: 0x7FFAC9E216A0
        public void InitShape(){} // RVA: 0x7FFAC9E21830
        public void UpdateShape(){} // RVA: 0x7FFAC9E21AE0
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFAC9E21C80
        public void UpdateContentTypes(){} // RVA: 0x7FFAC362EB40
        public void UpdateCollisionTags(){} // RVA: 0x7FFAC9E21C90
        public void .ctor(){} // RVA: 0x7FFAC9E21DB0
    }

    public class ContactBaseProxy`2 : Object
    {
        public T isValid;
        public VRC.SDKBase.VRCPlayerApi contactShapeId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_isValid(){} // RVA: 0x7FFAC2C59D00
        public void get_contactShapeId(){} // RVA: 0x7FFAC2C58DC0
        public void get_player(){} // RVA: 0x7FFAC2C58E90
        public void get_usage(){} // RVA: 0x7FFAC2C59960
        public void get_position(){} // RVA: 0x7FFAC2C588A0
        public void get_rotation(){} // RVA: 0x7FFAC2C588A0
        public void get_scale(){} // RVA: 0x7FFAC2C588A0
        public void Equals(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class ContactEnterInfo : ValueType
    {
        public VRC.Dynamics.ContactSenderProxy contactSender; // 0x10
        public VRC.Dynamics.ContactReceiverProxy contactReceiver; // 0x18
        public UnityEngine.Vector3 enterVelocity; // 0x20
        public UnityEngine.Vector3 contactPoint; // 0x2C
        public string[] matchingTags; // 0x38

        // ── Methods ──
        public void get_contactSender(){} // RVA: 0x7FFAC3AD9F60
        public void set_contactSender(){} // RVA: 0x7FFAC38DFE40
        public void get_contactReceiver(){} // RVA: 0x7FFAC4420220
        public void set_contactReceiver(){} // RVA: 0x7FFAC4420240
        public void get_enterVelocity(){} // RVA: 0x7FFAC2F3E8D0
        public void set_enterVelocity(){} // RVA: 0x7FFAC2F3E8F0
        public void get_contactPoint(){} // RVA: 0x7FFAC96385C0
        public void set_contactPoint(){} // RVA: 0x7FFAC96385E0
        public void get_matchingTags(){} // RVA: 0x7FFAC2F4F130
        public void set_matchingTags(){} // RVA: 0x7FFAC2F22E90
    }

    public class ContactExitInfo : ValueType
    {
        public VRC.Dynamics.ContactSenderProxy contactSender; // 0x10
        public VRC.Dynamics.ContactReceiverProxy contactReceiver; // 0x18
        public string[] matchingTags; // 0x20

        // ── Methods ──
        public void get_contactSender(){} // RVA: 0x7FFAC3AD9F60
        public void set_contactSender(){} // RVA: 0x7FFAC38DFE40
        public void get_contactReceiver(){} // RVA: 0x7FFAC4420220
        public void set_contactReceiver(){} // RVA: 0x7FFAC4420240
        public void get_matchingTags(){} // RVA: 0x7FFAC2F3C380
        public void set_matchingTags(){} // RVA: 0x7FFAC2F22E30
    }

    public class ContactManager : MonoBehaviour
    {
        public VRC.Dynamics.ContactManager Inst;
        public VRC.Dynamics.CollisionScene collision; // 0x20
        public System.Collections.Generic.List`1<VRC.Dynamics.ContactBase> contacts; // 0x28
        public System.Collections.Generic.List`1<VRC.Dynamics.ContactBase> updateList; // 0x30
        public Unity.Profiling.ProfilerMarker Marker_CollisionScene; // 0x8
        public Unity.Profiling.ProfilerMarker Marker_CopyShapeIds; // 0x10
        public Unity.Profiling.ProfilerMarker Marker_Trigger; // 0x18
        public float _timer; // 0x38
        public float FRAME_TIME;
        public float performanceTimeMs; // 0x3C
        public System.Diagnostics.Stopwatch _stopwatch; // 0x40
        public 0x6B25EFD8 _jobState; // 0x48
        public bool drawGizmos; // 0x4C
        public int MAX_COLLISION_RECORDS; // 0x20
        public int THREAD_BATCH_SIZE; // 0x24
        public Unity.Collections.NativeList`1<int> receivesToUpdate; // 0x50
        public Unity.Collections.NativeArray`1<ReceiverData> receiverData; // 0x58
        public System.Collections.Generic.List`1<VRC.Dynamics.ContactReceiver> needsShapeID; // 0x68

        // ── Methods ──
        public void AddContact(){} // RVA: 0x7FFAC9E22560
        public void RemoveContact(){} // RVA: 0x7FFAC9E22AE0
        public void GetContacts(){} // RVA: 0x7FFAC9E22EE0
        public void CalcClosestPoint(){} // RVA: 0x7FFAC9E22FB0
        public void CalcRelativeVelocity(){} // RVA: 0x7FFAC9E237A0
        public void Awake(){} // RVA: 0x7FFAC9E23C00
        public void OnDestroy(){} // RVA: 0x7FFAC9E24030
        public void LateUpdate(){} // RVA: 0x7FFAC9E246A0
        public void ScheduleUpdateReceiversJob(){} // RVA: 0x7FFAC9E24730
        public void HandleDynamicsFrameComplete(){} // RVA: 0x7FFAC9E24ED0
        public void OnDrawGizmos(){} // RVA: 0x7FFAC9E25110
        public void FindAvailableId(){} // RVA: 0x7FFAC9E25140
        public void .ctor(){} // RVA: 0x7FFAC9E251D0
        public void .cctor(){} // RVA: 0x7FFAC9E253D0
        public void Initialize$UpdateReceiversFunctions_CalcProximity_000001C3$BurstDirectCall(){} // RVA: 0x7FFAC9E255A0
    }

    public class ContactReceiver : ContactBase
    {
        public bool EffectiveReceiverType; // 0x90
        public bool allowOthers; // 0x91
        public 0x6B25F240 receiverType; // 0x94
        public string parameter; // 0x98
        public float minVelocity; // 0xA0
        public int receiverId; // 0xA4
        public VRC.Dynamics.IContactReceiverUdonEmitter _udonEmitter; // 0xA8
        public System.Collections.Generic.List`1<CollisionRecord> collisionRecords; // 0xB0
        public System.Collections.Generic.List`1<CollisionRecord> unvalidatedCollisionRecords; // 0xB8
        public float collisionValue; // 0xC0
        public System.Collections.Generic.HashSet`1<string> TagIntersectionSet;
        public bool hasTriggered; // 0xC4
        public float paramValue; // 0xC8
        public float restoreParamValue; // 0xCC
        public VRC.SDKBase.IAnimParameterAccess paramAccess; // 0xD0
        public System.Collections.Generic.HashSet`1<int> collisionTagsHash; // 0xD8

        // ── Methods ──
        public void get_EffectiveReceiverType(){} // RVA: 0x7FFAC9E26980
        public void IsReceiver(){} // RVA: 0x7FFAC3006850
        public void Start(){} // RVA: 0x7FFAC9E269B0
        public void OnDisable(){} // RVA: 0x7FFAC9E26D70
        public void OnDisableInCollisionScene(){} // RVA: 0x7FFAC9E26E20
        public void OnReenableInCollisionScene(){} // RVA: 0x7FFAC9E26EC0
        public void OnShapeEnter(){} // RVA: 0x7FFAC9E26EE0
        public void OnShapeExit(){} // RVA: 0x7FFAC9E271D0
        public void AddCollision(){} // RVA: 0x7FFAC9E271E0
        public void RemoveCollision(){} // RVA: 0x7FFAC9E27C20
        public void RemoveFromManagerData(){} // RVA: 0x7FFAC9E27F20
        public void BuildMatchingTagsArray(){} // RVA: 0x7FFAC9E28160
        public void AttemptAddCollision(){} // RVA: 0x7FFAC9E28550
        public void ValidateCollider(){} // RVA: 0x7FFAC9E287A0
        public void ValidateColliderPermissions(){} // RVA: 0x7FFAC9E28A50
        public void IsColliding(){} // RVA: 0x7FFAC9E28C00
        public void RequiresUpdate(){} // RVA: 0x7FFAC9E28C50
        public void UpdateContact(){} // RVA: 0x7FFAC9E28CC0
        public void RefreshValidatedCollisions(){} // RVA: 0x7FFAC9E29060
        public void UpdateParameter(){} // RVA: 0x7FFAC9E29150
        public void SetParameter(){} // RVA: 0x7FFAC9E291E0
        public void AssignUdonEmitter(){} // RVA: 0x7FFAC334B370
        public void CalculateProximity(){} // RVA: 0x7FFAC9E29300 | overloaded x2
        public void UpdateCollisionTags(){} // RVA: 0x7FFAC9E29410
        public void InitCollisionTags(){} // RVA: 0x7FFAC9E29540
        public void CheckForMask(){} // RVA: 0x7FFAC9E296D0
        public void .ctor(){} // RVA: 0x7FFAC9E29890
        public void .cctor(){} // RVA: 0x7FFAC9E29AD0
    }

    public class ContactReceiverProxy : ContactBaseProxy`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E22240
        public void Equals(){} // RVA: 0x7FFAC9E222A0
        public void op_Equality(){} // RVA: 0x7FFAC9E223D0
        public void op_Inequality(){} // RVA: 0x7FFAC9E22440
        public void GetHashCode(){} // RVA: 0x7FFAC9E224B0
        public void IsValid(){} // RVA: 0x7FFAC9E22520
    }

    public class ContactReceiverUdonEmitter : Object
    {
        public VRC.Udon.Common.Interfaces.IUdonBehaviour[] _udonBehaviours; // 0x10
        public string EventOnContactEnter;
        public string EventOnContactExit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9EA2930
        public void OnContactEnter(){} // RVA: 0x7FFAC9EA29E0
        public void OnContactExit(){} // RVA: 0x7FFAC9EA2D20
    }

    public class ContactSender : ContactBase
    {
        // ── Methods ──
        public void IsReceiver(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC9E29BB0
    }

    public class ContactSenderProxy : ContactBaseProxy`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E21F40
        public void Equals(){} // RVA: 0x7FFAC9E21FA0
        public void op_Equality(){} // RVA: 0x7FFAC9E220B0
        public void op_Inequality(){} // RVA: 0x7FFAC9E22120
        public void GetHashCode(){} // RVA: 0x7FFAC9E22190
        public void IsValid(){} // RVA: 0x7FFAC9E22200
    }

    public class CorrectQuaternion_000000BA$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9E09EC0
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9E0A000
        public void Constructor(){} // RVA: 0x7FFAC9E0A170
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9E0A170
        public void Invoke(){} // RVA: 0x7FFAC9E0A230
    }

    public class CorrectQuaternion_000000BA$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5EEDF60
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC9E09E10
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class DynamicsComponent : MonoBehaviour
    {
        public 0x6B25DA88 DefaultUsage;
        public 0x6B25DA88 Usage; // 0x20

        // ── Methods ──
        public void get_DefaultUsage(){} // RVA: 0x7FFAC9DFEE10
        public void set_DefaultUsage(){} // RVA: 0x7FFAC9DFEE50
        public void get_Usage(){} // RVA: 0x7FFAC9DFEE90
        public void set_Usage(){} // RVA: 0x7FFAC35DB7A0
        public void get_RawUsage(){} // RVA: 0x7FFAC30DBBE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class DynamicsSetup : Object
    {
        // ── Methods ──
        public void RuntimeInit(){} // RVA: 0x7FFAC3A9BB60
        public void Equals(){} // RVA: 0x7FFAC3A9BE10
        public void GetHashCode(){} // RVA: 0x7FFAC3A9C1B0
        public void op_Implicit(){} // RVA: 0x7FFAC3A9C5E0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3A9C960
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3A9CAC0
    }

    public class DynamicsUsageFlagsExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFAC9198D60 | overloaded x2
    }

    public class FixedTransformAccessArray : Object
    {
        public UnityEngine.Jobs.TransformAccessArray transformArray; // 0x10
        public Unity.Collections.NativeArray`1<int> lookupToId; // 0x18
        public Unity.Collections.NativeArray`1<int> lookupFromId; // 0x28
        public System.Collections.Generic.List`1<int> emptyQueue; // 0x38
        public int length; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E2A020
        public void Add(){} // RVA: 0x7FFAC9E2A230
        public void Remove(){} // RVA: 0x7FFAC9E2A410
        public void ChangeId(){} // RVA: 0x7FFAC9E2A540
        public void FindTransform(){} // RVA: 0x7FFAC9E2A560
        public void Dispose(){} // RVA: 0x7FFAC9E2A590
        public void GetLength(){} // RVA: 0x7FFAC2FC2080
        public void GetTransformAccessArray(){} // RVA: 0x7FFAC2F3C380
        public void GetLookupToId(){} // RVA: 0x7FFAC35D3330
        public void GetLookupFromId(){} // RVA: 0x7FFAC3BCF020
    }

    public class FromToRotation_000000BC$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9E0A530
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9E0A670
        public void Constructor(){} // RVA: 0x7FFAC9E0A7E0
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9E0A7E0
        public void Invoke(){} // RVA: 0x7FFAC9E0A8A0
    }

    public class FromToRotation_000000BC$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC896FA30
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC9E0A460
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class ICollisionBroadphase
    {
        public object scene;

        // ── Methods ──
        public void get_scene(){} // RVA: 0x7FFAC2C58E90
        public void set_scene(){} // RVA: 0x7FFAC2C70A40
        public void AddShape(){}
        public void RemoveShape(){}
        public void CastShape(){}
        public void ScheduleJobs(){}
        public void OnComplete(){} // RVA: 0x7FFAC2C70980
        public void DrawGizmos(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class IContactReceiverUdonEmitter
    {
        // ── Methods ──
        public void OnContactEnter(){}
        public void OnContactExit(){}
    }

    public class IMemoryBufferList
    {
        public object Length;

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void set_Length(){} // RVA: 0x7FFAC2C70ED0
        public void Move(){}
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Invalidate(){} // RVA: 0x7FFAC2C72E60
    }

    public class IMemoryBufferSpanList
    {
        // ── Methods ──
        public void UpdateSpan(){}
    }

    public class IParameterSetup
    {
        // ── Methods ──
        public void InitParameters(){} // RVA: 0x7FFAC2C70980
    }

    public class IPhysBoneDebugDrawer
    {
        public object Alpha;

        // ── Methods ──
        public void get_Alpha(){} // RVA: 0x7FFAC2C6D880
        public void set_Alpha(){} // RVA: 0x7FFAC2C7E480
        public void Line(){} // RVA: 0x7FFAC2E8DC40
        public void Sphere(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPhysBoneRoot
    {
        // ── Methods ──
        public void AddPhysBone(){} // RVA: 0x7FFAC2C58F40
        public void RemovePhysBone(){} // RVA: 0x7FFAC2C58F40
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
        public object ApplicationUnityConstraint;
        public object ApplicationVrcConstraint;

        // ── Methods ──
        public void get_ApplicationUnityConstraint(){} // RVA: 0x7FFAC2C58E90
        public void get_ApplicationVrcConstraint(){} // RVA: 0x7FFAC2C58E90
        public void Synchronize(){} // RVA: 0x7FFAC2C5FB50
        public void RestoreUnityConstraintEnabledState(){} // RVA: 0x7FFAC2C70980
    }

    public class IsAnyAxisZero_000000B6$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9E08510
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9E08650
        public void Constructor(){} // RVA: 0x7FFAC9E087C0
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9E087C0
        public void Invoke(){} // RVA: 0x7FFAC9E08880
    }

    public class IsAnyAxisZero_000000B6$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5C82610
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC9E08480
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class IsLowWeightSource_000000B9$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9E09870
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9E099B0
        public void Constructor(){} // RVA: 0x7FFAC9E09B20
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9E09B20
        public void Invoke(){} // RVA: 0x7FFAC9E09BE0
    }

    public class IsLowWeightSource_000000B9$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E096E0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC9E097C0
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class IsValidTrsMatrix_000000B7$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9E08B30
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9E08C70
        public void Constructor(){} // RVA: 0x7FFAC9E08DE0
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9E08DE0
        public void Invoke(){} // RVA: 0x7FFAC9E08EA0
    }

    public class IsValidTrsMatrix_000000B7$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5C82610
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC9E08AA0
        public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
    }

    public class LookAtVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E14FE0
        public void SynchronizeInternal(){} // RVA: 0x7FFAC9E15040
    }

    public class MathUtil : Object
    {
        // ── Methods ──
        public void DistancePointToPlane(){} // RVA: 0x7FFAC9E2A640
        public void ClosestPointOnPlane(){} // RVA: 0x7FFAC9E2A6A0
        public void AngleBetweenTwoNormals(){} // RVA: 0x7FFAC9E2A7D0 | overloaded x2
        public void CartesianToPolar(){} // RVA: 0x7FFAC9E2AB30
        public void PolarToCartesian(){} // RVA: 0x7FFAC9E2ACA0
        public void QuaternionToSwingTwist(){} // RVA: 0x7FFAC9E2AE30
        public void SwingTwistToQuaternion(){} // RVA: 0x7FFAC9E2AF20
        public void ClosestPointOnLineSegment_Ratio(){} // RVA: 0x7FFAC9E2B120
        public void ClosestPointOnLineSegment(){} // RVA: 0x7FFAC9E2B1F0
        public void ClosestPointsBetweenLineSegments(){} // RVA: 0x7FFAC9E2B320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MemoryBuffer : Object
    {
        public int usedSpace; // 0x10
        public Unity.Collections.NativeHashMap`2<VRC.Dynamics.ChainId,int> spanMap; // 0x18
        public Unity.Collections.NativeList`1<MemorySpan> spans; // 0x20
        public VRC.Dynamics.IMemoryBufferSpanList spanList; // 0x28
        public VRC.Dynamics.IMemoryBufferList dataList; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E2B6D0
        public void Dispose(){} // RVA: 0x7FFAC9E2B870
        public void Clear(){} // RVA: 0x7FFAC9E2B980
        public void ContainsId(){} // RVA: 0x7FFAC9E2BA70
        public void FindIndex(){} // RVA: 0x7FFAC9E2BB00
        public void Request(){} // RVA: 0x7FFAC9E2BBE0
        public void Release(){} // RVA: 0x7FFAC9E2BE00
        public void Compact(){} // RVA: 0x7FFAC9E2C0A0
        public void PrintDebug(){} // RVA: 0x7FFAC9E2C490
        public void GetFinalDataIndex(){} // RVA: 0x7FFAC9E2C7C0
    }

    public class ParentChangeDetector : MonoBehaviour
    {
        public System.Action OnParentChanged; // 0x20

        // ── Methods ──
        public void add_OnParentChanged(){} // RVA: 0x7FFAC9DFEF50
        public void remove_OnParentChanged(){} // RVA: 0x7FFAC9DFF040
        public void Awake(){} // RVA: 0x7FFAC9DFF130
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC32032C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ParentVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E13EF0
        public void SynchronizeInternal(){} // RVA: 0x7FFAC9E13F50
    }

    public class PhysBoneGrabbedInfo : ValueType
    {
        public VRC.SDKBase.VRCPlayerApi player; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
    }

    public class PhysBoneGroup : Object
    {
        public int MIN_CHAINS_CAPACITY;
        public VRC.Dynamics.PhysBoneManager manager; // 0x10
        public int groupIndex; // 0x18
        public System.Collections.Generic.List`1<VRC.Dynamics.ChainId> chainIds; // 0x20
        public Unity.Collections.NativeList`1<int> indexList; // 0x28
        public bool isListDirty; // 0x30
        public int MIN_SHAPES_CAPACITY;
        public Unity.Collections.NativeList`1<ushort> shapes; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E2ED50
        public void Dispose(){} // RVA: 0x7FFAC9E2EF40
        public void AddPhysBone(){} // RVA: 0x7FFAC9E2EFA0
        public void RemovePhysBone(){} // RVA: 0x7FFAC9E2F1E0
        public void MarkDirty(){} // RVA: 0x7FFAC4269BA0
        public void GetChains(){} // RVA: 0x7FFAC9E2F350
        public void AddShape(){} // RVA: 0x7FFAC9E2F5C0
        public void RemoveShape(){} // RVA: 0x7FFAC9E2F7E0
        public void GetShapes(){} // RVA: 0x7FFAC31D0140
    }

    public class PhysBoneManager : MonoBehaviour
    {
        public VRC.Dynamics.PhysBoneManager Inst;
        public UnityEngine.Vector3 distanceCullOrigin; // 0x20
        public bool IsSDK; // 0x2C
        public System.Collections.Generic.List`1<VRC.Dynamics.PhysBoneRootDefinition> rootsToUpdate; // 0x30
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneBase> compsToAdd; // 0x38
        public System.Collections.Generic.List`1<ToRemoveData> compsToRemove; // 0x40
        public float MAX_BOUNDS_SIZE;
        public float MIN_BONE_LENGTH;
        public float MIN_SIMULATE_BONE;
        public Unity.Mathematics.float3 DebugLineAxis; // 0x8
        public bool DisableTiming; // 0x14
        public float DebugTimeElapsed; // 0x18
        public VRC.Dynamics.IPhysBoneDebugDrawer DebugDraw; // 0x20
        public VRC.Dynamics.MemoryBuffer buffer; // 0x48
        public VRC.Dynamics.ChainBuffer chainBuffer; // 0x50
        public VRC.Dynamics.BoneBuffer boneBuffer; // 0x58
        public VRC.Dynamics.RootsBuffer rootBuffer; // 0x60
        public EditorDebugInfo editorInfo; // 0x68
        public Unity.Collections.NativeArray`1<0x6B25FD40> errorBuffer; // 0x90
        public int THREAD_BATCH_SIZE; // 0x28
        public int MAX_TRANSFORMS_PER_CHAIN;
        public float MAX_DELTA_TIME;
        public int INITIAL_CAPACITY_ROOTS;
        public int INITIAL_CAPACITY_CHAINS;
        public int INITIAL_CAPACITY_BONES;
        public float COLLISION_FRICTION;
        public int EXTRA_TRANSFORM_COUNT;
        public int EXTRA_TRANSFORM_ROOT_PARENT;
        public int EXTRA_TRANSFORM_SCENE_ROOT;
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneColliderBase> colliderComponents; // 0xA0
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneColliderBase> collidersToAdd; // 0xA8
        public System.Collections.Generic.List`1<ColliderToRemoveData> collidersToRemove; // 0xB0
        public float CUSTOM_EPSILON;
        public float QUATERNION_EPSILON;
        public float MATRIX_EPSILON;
        public bool hasInit; // 0xB8
        public Unity.Profiling.ProfilerMarker Marker_UpdateRoots; // 0x30
        public Unity.Profiling.ProfilerMarker Marker_AddRemoveChains; // 0x38
        public Unity.Profiling.ProfilerMarker Marker_AddRemoveColliders; // 0x40
        public Unity.Profiling.ProfilerMarker Marker_UpdateStaleGroups; // 0x48
        public Unity.Profiling.ProfilerMarker Marker_UpdateChains; // 0x50
        public Unity.Profiling.ProfilerMarker Marker_JobsTotal; // 0xC0
        public float FRAME_TIME;
        public float fixedTimeElapsed; // 0xC8
        public float realTimeElapsed; // 0xCC
        public bool hasReportedCriticalError; // 0x58
        public float fullFrameTimeElapsed; // 0xD0
        public bool executeShapeUpdates; // 0xD4
        public bool drawGizmos; // 0xD5
        public int MAX_EXECUTION_GROUPS;
        public int MAX_EXECUTION_GROUPS_NONWORLD;
        public VRC.Dynamics.PhysBoneGroup[] executionGroups; // 0xD8
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneBase> _staleGroupPhysBones; // 0xE0
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneColliderBase> _staleGroupPhysBoneColliders; // 0xE8
        public System.Collections.Generic.HashSet`1<UnityEngine.Transform> _staleGroupRoots; // 0xF0
        public System.Collections.Generic.Dictionary`2<VRC.Dynamics.DynamicsComponent,int> _formerExecutionGroupBuffer; // 0xF8
        public System.Collections.Generic.List`1<SortingData> sortingData; // 0x60
        public VRC.Dynamics.CollisionScene collision; // 0x100
        public int MAX_COLLIDERS_PER_CHAIN;
        public System.Collections.Generic.List`1<Grab> grabs; // 0x108
        public float GRAB_RAY_LENGTH;
        public System.Collections.Generic.List`1<Shape> GrabBuffer; // 0x110
        public System.Collections.Generic.List`1<Pose> poses; // 0x118

        // ── Methods ──
        public void AddPhysBone(){} // RVA: 0x7FFAC9E2F900
        public void RemovePhysBone(){} // RVA: 0x7FFAC9E2FBA0
        public void HasPhysBone(){} // RVA: 0x7FFAC9E2FEA0
        public void FindPhysBone(){} // RVA: 0x7FFAC9E2FF30
        public void MarkRootDirty(){} // RVA: 0x7FFAC9E2FFE0
        public void UpdateStaleGroups(){} // RVA: 0x7FFAC9E300A0
        public void UpdateRoots(){} // RVA: 0x7FFAC9E30B10
        public void GetOrCreateRoot(){} // RVA: 0x7FFAC9E30D10
        public void ReassignPhysBoneToRoot(){} // RVA: 0x7FFAC9E30F40
        public void RemoveChains(){} // RVA: 0x7FFAC9E31210
        public void AddChains(){} // RVA: 0x7FFAC9E31860
        public void ApplyExtraTransforms(){} // RVA: 0x7FFAC9E34030
        public void AddCollider(){} // RVA: 0x7FFAC9E342D0
        public void RemoveCollider(){} // RVA: 0x7FFAC9E344E0
        public void GetColliderComponents(){} // RVA: 0x7FFAC3543900
        public void RemoveColliders(){} // RVA: 0x7FFAC9E345B0
        public void AddColliders(){} // RVA: 0x7FFAC9E34830
        public void GetChains(){} // RVA: 0x7FFAC9E34E60
        public void FindChainIndex(){} // RVA: 0x7FFAC9E34F00
        public void GetChain(){} // RVA: 0x7FFAC9E34FF0
        public void GetChainComponent(){} // RVA: 0x7FFAC9E350F0
        public void SetChain(){} // RVA: 0x7FFAC9E35170
        public void GetBone(){} // RVA: 0x7FFAC9E35270
        public void SetBone(){} // RVA: 0x7FFAC9E35380
        public void GetTransformData(){} // RVA: 0x7FFAC9E35480
        public void CalcLimitAxis(){} // RVA: 0x7FFAC9E356F0 | overloaded x2
        public void AlmostEquals(){} // RVA: 0x7FFAC9E35D70 | overloaded x2
        public void HasChanged(){} // RVA: 0x7FFAC9E35E70 | overloaded x2
        public void SafeInverse(){} // RVA: 0x7FFAC9E35F90
        public void Awake(){} // RVA: 0x7FFAC9E360A0
        public void OnDestroy(){} // RVA: 0x7FFAC9E36270
        public void Init(){} // RVA: 0x7FFAC9E366D0
        public void FixedUpdate(){} // RVA: 0x7FFAC9E370D0
        public void LateUpdate(){} // RVA: 0x7FFAC9E37140
        public void UpdateChains(){} // RVA: 0x7FFAC9E371F0
        public void ScheduleReadBoneJob(){} // RVA: 0x7FFAC9E37CB0
        public void ReportCriticalError(){} // RVA: 0x7FFAC9E37F00
        public void DumpObject(){} // RVA: 0x7FFAC9E38300
        public void ScheduleExecutionJob(){} // RVA: 0x7FFAC9E38550
        public void ScheduleUpdateRootsJob(){} // RVA: 0x7FFAC9E387F0
        public void ScheduleExecutionGroupJob(){} // RVA: 0x7FFAC9E38B50
        public void CalcBoneScale(){} // RVA: 0x7FFAC98A8C70
        public void CompleteJob(){} // RVA: 0x7FFAC9E39160
        public void PrintDebug(){} // RVA: 0x7FFAC9E39BE0 | overloaded x2
        public void OnDrawGizmos(){} // RVA: 0x7FFAC9E39EF0
        public void MarkExecutionGroupStale(){} // RVA: 0x7FFAC9E3A080 | overloaded x2
        public void IsCyclicDependency(){} // RVA: 0x7FFAC9E3A1E0
        public void UpdateExecutionGroupsForComponent(){} // RVA: 0x7FFAC9E3A430
        public void UpdateExecutionGroupsForRoot(){} // RVA: 0x7FFAC9E3A5E0 | overloaded x2
        public void UpdateExecutionGroups(){} // RVA: 0x7FFAC9E3A6E0
        public void UpdateExecutionGroup(){} // RVA: 0x7FFAC9E3BCA0
        public void RemoveFromExecutionGroup(){} // RVA: 0x7FFAC9E3C170
        public void AddToExecutionGroup(){} // RVA: 0x7FFAC9E3C2D0
        public void MarkGroupListDirty(){} // RVA: 0x7FFAC9E3C420
        public void GetExecutionGroup(){} // RVA: 0x7FFAC9E3C460
        public void ClearRootTiming(){} // RVA: 0x7FFAC9E3C4A0
        public void InitCollision(){} // RVA: 0x7FFAC9E3C650
        public void UpdateAndScheduleColliders(){} // RVA: 0x7FFAC9E3C750
        public void UpdateCollidersForChain(){} // RVA: 0x7FFAC9E3C830
        public void UpdateGrabs(){} // RVA: 0x7FFAC9E3D180
        public void InteractAllowed(){} // RVA: 0x7FFAC9E3D4C0
        public void AttemptGrab(){} // RVA: 0x7FFAC9E3F470 | overloaded x3
        public void IsChainGrabbed(){} // RVA: 0x7FFAC9E3F510
        public void ReleaseGrab(){} // RVA: 0x7FFAC9E40050 | overloaded x2
        public void AddGrab(){} // RVA: 0x7FFAC9E3F850
        public void GetGrabs(){} // RVA: 0x7FFAC9E40870
        public void CreatePose(){} // RVA: 0x7FFAC9E40920
        public void FindOrCreatePose(){} // RVA: 0x7FFAC9E40FA0
        public void RemovePoseForChain(){} // RVA: 0x7FFAC9E410A0
        public void RemovePose(){} // RVA: 0x7FFAC9E41220
        public void FindPose(){} // RVA: 0x7FFAC9E417B0
        public void .ctor(){} // RVA: 0x7FFAC9E418F0
        public void .cctor(){} // RVA: 0x7FFAC9E420E0
        public void <IsCyclicDependency>g__RecusriveSearch|122_0(){} // RVA: 0x7FFAC9E42490
        public void <UpdateExecutionGroups>g__FindSortingData|126_0(){} // RVA: 0x7FFAC9E42640
        public void <UpdateExecutionGroups>g__FindParentDependency|126_1(){} // RVA: 0x7FFAC9E427A0
    }

    public class PhysBonePosedInfo : ValueType
    {
        public VRC.SDKBase.VRCPlayerApi player; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
    }

    public class PhysBoneReleasedInfo : ValueType
    {
        public VRC.SDKBase.VRCPlayerApi player; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
    }

    public class PhysBoneRoot : MonoBehaviour
    {
        public 0x6B2605D8 RootDefinition; // 0x20
        public VRC.Dynamics.PhysBoneRootDefinition Timing; // 0x28

        // ── Methods ──
        public void get_RootDefinition(){} // RVA: 0x7FFAC2F4F130
        public void set_RootDefinition(){} // RVA: 0x7FFAC2F22E90
        public void get_Timing(){} // RVA: 0x7FFAC30DBBE0
        public void set_Timing(){} // RVA: 0x7FFAC9E4F730
        public void Awake(){} // RVA: 0x7FFAC9E4F800
        public void get_RequiredHideFlags(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class PhysBoneRootDefinition : Object
    {
        public int Transform;
        public int AutoEvaluateFixedTime; // 0x10
        public int UseFixedTime; // 0x14
        public string avatarId; // 0x18
        public UnityEngine.Transform <Transform>k__BackingField; // 0x20
        public bool _autoEvaluateFixedTime; // 0x28
        public bool _useFixedTime; // 0x29

        // ── Methods ──
        public void get_Transform(){} // RVA: 0x7FFAC2F4F0C0
        public void get_AutoEvaluateFixedTime(){} // RVA: 0x7FFAC30F6BA0
        public void set_AutoEvaluateFixedTime(){} // RVA: 0x7FFAC9E4F870
        public void get_UseFixedTime(){} // RVA: 0x7FFAC386C550
        public void set_UseFixedTime(){} // RVA: 0x7FFAC9E4F900
        public void .ctor(){} // RVA: 0x7FFAC9E4F990
    }

    public class PhysBoneUdonEmitter : Object
    {
        public VRC.Udon.Common.Interfaces.IUdonBehaviour[] _udonBehaviours; // 0x10
        public string EventOnPhysBoneGrabbed;
        public string EventOnPhysBoneReleased;
        public string EventOnPhysBonePosed;
        public string EventOnPhysBoneUnPosed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9EA3010
        public void OnPhysBoneGrabbed(){} // RVA: 0x7FFAC9EA30C0
        public void OnPhysBoneReleased(){} // RVA: 0x7FFAC9EA32D0
        public void OnPhysBonePosed(){} // RVA: 0x7FFAC9EA34E0
        public void OnPhysBoneUnPosed(){} // RVA: 0x7FFAC9EA36F0
    }

    public class PhysBoneUnPosedInfo : ValueType
    {
        public VRC.SDKBase.VRCPlayerApi player; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
    }

    public class PositionVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E131D0
        public void SynchronizeInternal(){} // RVA: 0x7FFAC9E13230
    }

    public class ReadTransformJob : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<UnityEngine.Jobs.TransformAccess> transformDataBuffer; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9E02990
    }

    public class RootsBuffer : Object
    {
        public Unity.Collections.NativeList`1<ChainRoot> roots; // 0x10
        public System.Collections.Generic.List`1<VRC.Dynamics.PhysBoneRootDefinition> comps; // 0x18
        public UnityEngine.Jobs.TransformAccessArray rootTransformsArray; // 0x20
        public System.Collections.Generic.List`1<int> available; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E2C8A0
        public void Dispose(){} // RVA: 0x7FFAC9E2CAA0
        public void AddBoneToRoot(){} // RVA: 0x7FFAC9E2CB10
        public void RemoveBoneFromRoot(){} // RVA: 0x7FFAC9E2CB30
        public void TryAddRoot(){} // RVA: 0x7FFAC9E2CBC0
        public void TryRemoveRoot(){} // RVA: 0x7FFAC9E2CF10
        public void FindRoot(){} // RVA: 0x7FFAC9E2D090
    }

    public class RotationVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E13630
        public void SynchronizeInternal(){} // RVA: 0x7FFAC9E13690
    }

    public class ScaleVRCConstraintBinding : AbstractVRCConstraintBinding`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E13A90
        public void SynchronizeInternal(){} // RVA: 0x7FFAC9E13AF0
    }

    public class TransformPoint_000000B4$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9E07850
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9E07990
        public void Constructor(){} // RVA: 0x7FFAC9E07B00
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9E07B00
        public void Invoke(){} // RVA: 0x7FFAC9E07BC0
    }

    public class TransformPoint_000000B4$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC896FA30
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC9E07780
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class TransformPoint_000000B5$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC9E07ED0
        public void GetFunctionPointer(){} // RVA: 0x7FFAC9E08010
        public void Constructor(){} // RVA: 0x7FFAC9E08180
        public void Initialize(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9E08180
        public void Invoke(){} // RVA: 0x7FFAC9E08240
    }

    public class TransformPoint_000000B5$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC896FA30
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC9E07E00
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class VRCConstraintBase : DynamicsComponent
    {
        public bool PositionMode; // 0x28
        public float RotationMode; // 0x2C
        public UnityEngine.Transform ScaleMode; // 0x30
        public bool AffectsPosition; // 0x38
        public bool AffectsRotation; // 0x39
        public bool AffectsScale; // 0x3A
        public bool NativeIndex; // 0x3B
        public VRC.Dynamics.VRCConstraintSourceKeyableList CachedExecutionGroupIndex; // 0x40
        public int LatestValidExecutionGroupIndex; // 0x2D8
        public int DependencyRoot; // 0x2DC
        public int DependsOnLocalAvatarProcessing; // 0x2E0
        public UnityEngine.Transform IsPendingUnprocessed; // 0x2E8
        public bool _isRuntimeTargetTransformAssigned; // 0x2F0
        public UnityEngine.Transform _cachedTargetTransform; // 0x2F8
        public bool _hasCachedTargetParentTransform; // 0x300
        public UnityEngine.Transform _cachedTargetParentTransform; // 0x308
        public UnityEngine.Transform _assignedDependencyRoot; // 0x310
        public bool _initialRegistrationComplete; // 0x318
        public int _cachedTransformCount; // 0x31C
        public VRC.Dynamics.IVRCConstraintBinding _constraintBinding; // 0x320
        public bool _fullNativeUpdatePending; // 0x328
        public 0x6B25E4D8 _pendingReallocation; // 0x32C
        public UnityEngine.Animator _containingAnimator; // 0x330
        public bool _hasContainingAnimator; // 0x338
        public bool _containingAnimatorLatestActiveState; // 0x339
        public bool _isAttachedToClone; // 0x33A
        public VRC.Dynamics.VRCPhysBoneBase[] _monitoredPhysBones; // 0x340
        public 0x6B25EB60 _playerLoopStage; // 0x348
        public 0x6B25E530 _physBoneDependency; // 0x34C
        public bool _dependsOnLocalAvatarProcessing; // 0x350
        public System.Collections.Generic.HashSet`1<System.Action`1<VRC.Dynamics.VRCConstraintBase>> _registeredBakeListeners; // 0x358
        public System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> OrderInfoPerGameObject;
        public int _localGameObjectOrder; // 0x360
        public bool _isInLocalGameObjectOrder; // 0x364
        public bool <IsPendingUnprocessed>k__BackingField; // 0x365
        public System.Collections.Generic.HashSet`1<VRC.Dynamics.VRCConstraintBase> _dependents; // 0x368
        public System.Collections.Generic.HashSet`1<VRC.Dynamics.VRCConstraintBase> _rootNodes; // 0x8
        public System.Collections.BitArray _dependencyTraversalMarks; // 0x10
        public int _dependencyTraversalMarksCounter; // 0x18
        public int _dependencyTraversalMarkIndex; // 0x370
        public bool _dependencyActiveMark; // 0x374
        public int MAX_TRAVERSAL_STEPS;
        public int _dependencyTraversalTotalSteps; // 0x1C
        public int _dependencyTraversalHighestDepth; // 0x378
        public int MAX_DEPENDENCY_DEPTH;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAC2C59960
        public void get_RotationMode(){} // RVA: 0x7FFAC2C59960
        public void get_ScaleMode(){} // RVA: 0x7FFAC2C59960
        public void get_AffectsPosition(){} // RVA: 0x7FFAC9E0AAE0
        public void get_AffectsRotation(){} // RVA: 0x7FFAC9E0AB10
        public void get_AffectsScale(){} // RVA: 0x7FFAC9E0AB40
        public void IsLocalPostProcessIndependent(){} // RVA: 0x7FFAC9E0AB70
        public void get_NativeIndex(){} // RVA: 0x7FFAC9E0ABF0
        public void set_NativeIndex(){} // RVA: 0x7FFAC9E0AC00
        public void get_CachedExecutionGroupIndex(){} // RVA: 0x7FFAC9756090
        public void get_LatestValidExecutionGroupIndex(){} // RVA: 0x7FFAC9E0AC10
        public void SetCachedExecutionGroupIndex(){} // RVA: 0x7FFAC9E0AC20
        public void get_DependencyRoot(){} // RVA: 0x7FFAC9E0AC30
        public void get_DependsOnLocalAvatarProcessing(){} // RVA: 0x7FFAC9E0ADF0
        public void set_DependsOnLocalAvatarProcessing(){} // RVA: 0x7FFAC9E0AE00
        public void ActivateConstraint(){} // RVA: 0x7FFAC9E0AE20
        public void ZeroConstraint(){} // RVA: 0x7FFAC9E0AE50
        public void ApplyZeroOffset(){} // RVA: 0x7FFAC2C70980
        public void TryBakeCurrentOffsets(){} // RVA: 0x7FFAC9E0AF40
        public void TryBakeCurrentOffsetsRuntime(){} // RVA: 0x7FFAC9E0AFF0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAC2C70A40
        public void RegisterBakeListener(){} // RVA: 0x7FFAC9E0B380
        public void UnRegisterBakeListener(){} // RVA: 0x7FFAC9E0B3F0
        public void AssignBinding(){} // RVA: 0x7FFAC9E0B450
        public void GetBoundUnityConstraint(){} // RVA: 0x7FFAC9E0B900
        public void AddToLocalGameObjectOrder(){} // RVA: 0x7FFAC9E0B960
        public void RemoveFromLocalGameObjectOrder(){} // RVA: 0x7FFAC9E0BF40
        public void CalculateOrder(){} // RVA: 0x7FFAC9E0C190
        public void IsDependentOnTransform(){} // RVA: 0x7FFAC9E0C4A0
        public void GetEffectiveTargetTransform(){} // RVA: 0x7FFAC9E0C600
        public void SetupAvatarConstraint(){} // RVA: 0x7FFAC9E0C730
        public void SetupWorldConstraint(){} // RVA: 0x7FFAC9E0C9C0
        public void SetupPropConstraint(){} // RVA: 0x7FFAC9E0CB00
        public void Awake(){} // RVA: 0x7FFAC9E0CC40
        public void Start(){} // RVA: 0x7FFAC9E0CFD0
        public void OnEnable(){} // RVA: 0x7FFAC9E0D040
        public void OnDisable(){} // RVA: 0x7FFAC9E0D140
        public void OnDestroy(){} // RVA: 0x7FFAC9E0D210
        public void Dispose(){} // RVA: 0x7FFAC9E0D220
        public void GetTransformCount(){} // RVA: 0x7FFAC9E0D300
        public void RecalculateTransformCount(){} // RVA: 0x7FFAC9E0D350
        public void GetTransforms(){} // RVA: 0x7FFAC9E0D560
        public void GetManagedWorldUpTransform(){} // RVA: 0x7FFAC34F9180
        public void AllocateJobData(){} // RVA: 0x7FFAC9E0D8C0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC9E0DCE0
        public void ShouldCheckForChangingTargetParent(){} // RVA: 0x7FFAC9E0DCF0
        public void RequiresReallocation(){} // RVA: 0x7FFAC9E0DD50
        public void SynchronizeWithBinding(){} // RVA: 0x7FFAC9E0E290
        public void CheckReallocation(){} // RVA: 0x7FFAC9E0E320
        public void EstablishTargetTransform(){} // RVA: 0x7FFAC9E0E440
        public void ReEvaluatePhysBoneOrder(){} // RVA: 0x7FFAC9E0E810
        public void GatherPotentiallyDependentPhysBones(){} // RVA: 0x7FFAC9E0EAA0
        public void DeterminePhysBoneDependency(){} // RVA: 0x7FFAC9E0ECE0
        public void EstablishPlayerLoopStage(){} // RVA: 0x7FFAC9E0EF20
        public void AssignPlayerLoopStage(){} // RVA: 0x7FFAC9E0F110
        public void InvalidatePlayerLoopStage(){} // RVA: 0x7FFAC9E0F2A0
        public void UpdateJobData(){} // RVA: 0x7FFAC9E0F2B0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAC2C70A40
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7FFAC2F21310
        public void AffectsAnyAxis(){} // RVA: 0x7FFAC2C59D00
        public void PostUpdateJobData(){} // RVA: 0x7FFAC9E0F7E0
        public void CreateAxisBitfield(){} // RVA: 0x7FFAC9E0F840
        public void RequestFullNativeUpdate(){} // RVA: 0x7FFAC9E0DCE0
        public void GetPerSourcePositionOffsets(){} // RVA: 0x7FFAC9E0F860
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC9E0F930
        public void get_IsPendingUnprocessed(){} // RVA: 0x7FFAC9E0FBF0
        public void set_IsPendingUnprocessed(){} // RVA: 0x7FFAC9E0FC00
        public void CalculateDependencies(){} // RVA: 0x7FFAC9E0FC10
        public void TraverseDependencies(){} // RVA: 0x7FFAC9E0FF10
        public void ReorganizeGroupsFastForRoot(){} // RVA: 0x7FFAC9E101D0
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFAC9E0DCE0
        public void .ctor(){} // RVA: 0x7FFAC9E10C80
        public void .cctor(){} // RVA: 0x7FFAC9E10E40
    }

    public class VRCConstraintGroup : Object
    {
        public int MemberCount;
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<int> MemberConstraintIndices; // 0x10

        // ── Methods ──
        public void get_MemberCount(){} // RVA: 0x7FFAC9E002A0
        public void .ctor(){} // RVA: 0x7FFAC9E002E0
        public void Dispose(){} // RVA: 0x7FFAC9E003A0
        public void AddConstraint(){} // RVA: 0x7FFAC9E003E0
        public void RemoveConstraintSwapBack(){} // RVA: 0x7FFAC9E00630
        public void RemoveConstraintAtSwapBack(){} // RVA: 0x7FFAC9E006F0
        public void UpdateNativeIndex(){} // RVA: 0x7FFAC9E00730
        public void RemoveAtSwapBack(){} // RVA: 0x7FFAC9E008C0
    }

    public class VRCConstraintGrouper : Object
    {
        public System.Collections.Generic.SortedDictionary`2<int,VRC.Dynamics.VRCConstraintGroup> GroupsAreStale; // 0x10
        public System.Collections.Generic.HashSet`1<UnityEngine.Transform> ExecutionGroups; // 0x18
        public bool _objectDisposed; // 0x20
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> _unprocessedConstraints; // 0x28
        public System.Collections.Generic.HashSet`1<int> RemovedGroupIndicesBuffer;
        public Unity.Profiling.ProfilerMarker _reorganizeGroupsProfilerMarker; // 0x8

        // ── Methods ──
        public void get_GroupsAreStale(){} // RVA: 0x7FFAC9E009F0
        public void get_ExecutionGroups(){} // RVA: 0x7FFAC9E00A70
        public void .ctor(){} // RVA: 0x7FFAC9E00AE0
        public void Dispose(){} // RVA: 0x7FFAC9E00CE0
        public void RecordConstraintToAdd(){} // RVA: 0x7FFAC9E00FC0
        public void RecordConstraintToRemove(){} // RVA: 0x7FFAC9E010A0
        public void MarkRootStale(){} // RVA: 0x7FFAC9E017F0
        public void GetConstraintListForRoot(){} // RVA: 0x7FFAC9E01870
        public void RefreshGroups(){} // RVA: 0x7FFAC9E01990
        public void PrepareGroupsForReorganize(){} // RVA: 0x7FFAC9E020C0
        public void .cctor(){} // RVA: 0x7FFAC9E02840
    }

    public class VRCConstraintJob : ValueType
    {
        public 0x6B25EB60 playerLoopStage; // 0x10
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<int> targetConstraintIndices; // 0x18
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<VRC.Dynamics.VRCConstraintJobData> constraints; // 0x30
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<UnityEngine.Jobs.TransformAccess> transformDataBuffer; // 0x48
        public Unity.Mathematics.float3 Float3Right;
        public Unity.Mathematics.float3 Float3Up; // 0xC
        public Unity.Mathematics.float3 Float3Forward; // 0x18
        public Unity.Mathematics.float3 Float3One; // 0x24
        public Unity.Mathematics.quaternion QuaternionZero; // 0x30

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC9E029F0
        public void ProcessSource(){} // RVA: 0x7FFAC9E04770
        public void FinalizeLocalScaleResult(){} // RVA: 0x7FFAC9E05800
        public void PerformAimAt(){} // RVA: 0x7FFAC9E05B70
        public void TransformPoint(){} // RVA: 0x7FFAC9E06A60 | overloaded x2
        public void IsAnyAxisZero(){} // RVA: 0x7FFAC9E06AD0
        public void IsValidTrsMatrix(){} // RVA: 0x7FFAC9E06B20
        public void ConstraintHasSingleLowWeightSource(){} // RVA: 0x7FFAC9E06B70
        public void IsLowWeightSource(){} // RVA: 0x7FFAC9E06BC0
        public void CorrectQuaternion(){} // RVA: 0x7FFAC9E06C20
        public void GetTransformLossyScale(){} // RVA: 0x7FFAC9DFCD80
        public void FromToRotation(){} // RVA: 0x7FFAC9E06C80
        public void CalculateEulerZXY(){} // RVA: 0x7FFAC9E06CF0
        public void .cctor(){} // RVA: 0x7FFAC9E06F10
        public void TransformPoint$BurstManaged(){} // RVA: 0x7FFAC9E07070 | overloaded x2
        public void IsAnyAxisZero$BurstManaged(){} // RVA: 0x7FFAC9E07120
        public void IsValidTrsMatrix$BurstManaged(){} // RVA: 0x7FFAC9E07150
        public void ConstraintHasSingleLowWeightSource$BurstManaged(){} // RVA: 0x7FFAC9E071B0
        public void IsLowWeightSource$BurstManaged(){} // RVA: 0x7FFAC9E07270
        public void CorrectQuaternion$BurstManaged(){} // RVA: 0x7FFAC9E072A0
        public void FromToRotation$BurstManaged(){} // RVA: 0x7FFAC9E07400
    }

    public class VRCConstraintJobData : ValueType
    {
        public int TransformStartIndex; // 0x10
        public 0x6B25EA00 PositionConstraintMode; // 0x14
        public 0x6B25EA58 RotationConstraintMode; // 0x18
        public 0x6B25EAB0 ScaleConstraintMode; // 0x1C
        public bool HasParentTransform; // 0x20
        public bool IsActive; // 0x21
        public float GlobalWeight; // 0x24
        public bool SolveInLocalSpace; // 0x28
        public bool FreezeToWorld; // 0x29
        public bool FreezeToWorldHasTrs; // 0x2A
        public Unity.Mathematics.float3 FrozenWorldPosition; // 0x2C
        public Unity.Mathematics.quaternion FrozenWorldRotation; // 0x38
        public Unity.Mathematics.float3 FrozenWorldScale; // 0x48
        public 0x6B25EB60 PlayerLoopStage; // 0x54
        public bool AttachedToAvatarClone; // 0x58
        public bool Locked; // 0x59
        public ConstraintConfigurationData PositionConfig; // 0x5C
        public ConstraintConfigurationData RotationConfig; // 0x78
        public ConstraintConfigurationData ScaleConfig; // 0x94
        public Unity.Mathematics.float3 AimAxis; // 0xB0
        public Unity.Mathematics.float3 UpAxis; // 0xBC
        public bool UseUpTransform; // 0xC8
        public float Roll; // 0xCC
        public 0x6B25E428 WorldUpType; // 0xD0
        public Unity.Mathematics.float3 WorldUpVector; // 0xD4
        public int WorldUpTransformIndex; // 0xE0
        public float TotalValidSourceWeight; // 0xE4
        public Unity.Mathematics.float3 OriginalLocalEulersHint; // 0xE8
        public bool HasOriginalLocalEulersHint; // 0xF4
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<ConstraintSourceData> Sources; // 0xF8
    }

    public class VRCConstraintManager : Object
    {
        public int IsInitialized;
        public int CanExecuteConstraintJobsInEditMode;
        public bool _instanceInitialized;
        public bool _canExecuteConstraintJobsInEditMode; // 0x1
        public bool _isEditor; // 0x2
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase> _constraintsManaged; // 0x8
        public System.Collections.Generic.HashSet`1<VRC.Dynamics.VRCConstraintBase> _constraintsManagedSet; // 0x10
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<VRC.Dynamics.VRCConstraintJobData> _constraintsNative; // 0x18
        public UnityEngine.Jobs.TransformAccessArray _transformBuffer; // 0x30
        public UnityEngine.Jobs.TransformAccessArray _transformBufferOnlyTargets; // 0x38
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<UnityEngine.Jobs.TransformAccess> _transformDataBuffer; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.RangeInt> _emptyTransformRanges; // 0x58
        public System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Transform,bool>> _constraintTransformsBuffer; // 0x60
        public Unity.Profiling.ProfilerMarker _updateConstraintsProfilerMarkerSync; // 0x68
        public Unity.Profiling.ProfilerMarker _updateConstraintsProfilerMarkerReAlloc; // 0x70
        public Unity.Profiling.ProfilerMarker _updateConstraintsProfilerMarkerJobData; // 0x78
        public VRC.Dynamics.VRCConstraintGrouper _constraintGrouper; // 0x80
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase> UpdatedConstraintsBuffer; // 0x88

        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7FFAC9E15460
        public void get_CanExecuteConstraintJobsInEditMode(){} // RVA: 0x7FFAC9E154C0
        public void Initialize(){} // RVA: 0x7FFAC9E15520
        public void HandleQuit(){} // RVA: 0x7FFAC9E15D00
        public void UnInitialize(){} // RVA: 0x7FFAC9E15D70
        public void RegisterConstraint(){} // RVA: 0x7FFAC9E16170
        public void UnregisterConstraint(){} // RVA: 0x7FFAC9E16D90
        public void ReRegisterConstraint(){} // RVA: 0x7FFAC9E18020
        public void ReRegisterSameObjectConstraint(){} // RVA: 0x7FFAC9E180B0
        public void IsConstraintRegistered(){} // RVA: 0x7FFAC9E18180
        public void GetBufferedTransform(){} // RVA: 0x7FFAC9E18230
        public void SetBufferedTransform(){} // RVA: 0x7FFAC9E182E0
        public void GetFinalTransformIndex(){} // RVA: 0x7FFAC9E18580
        public void UpdateConstraints(){} // RVA: 0x7FFAC9E18980
        public void ScheduleReadJob(){} // RVA: 0x7FFAC9E18F50
        public void ScheduleExecutionJobs(){} // RVA: 0x7FFAC9E19150
        public void PostUpdateConstraints(){} // RVA: 0x7FFAC9E197C0
        public void TryCreateSubstituteConstraint(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9E19A40
    }

    public class VRCConstraintOffsetBaker : Object
    {
        public UnityEngine.Transform ShouldBakeAtRest; // 0x10
        public float ShouldBakeOffsets; // 0x18
        public 0x6B25E588 _bakeOptions; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E19D30
        public void get_ShouldBakeAtRest(){} // RVA: 0x7FFAC9094450
        public void get_ShouldBakeOffsets(){} // RVA: 0x7FFAC9473320
        public void Bake(){} // RVA: 0x7FFAC9E1A3B0 | overloaded x5
        public void CalculateBakedPositionOffset(){} // RVA: 0x7FFAC9E1AE50
        public void CalculateBakedRotationOffset(){} // RVA: 0x7FFAC9E1B7A0
        public void CalculateBakedScaleOffset(){} // RVA: 0x7FFAC9E1BF30
        public void AsSignedEulers(){} // RVA: 0x7FFAC9E1C4E0
        public void <AsSignedEulers>g__TreatEuler|16_0(){} // RVA: 0x7FFAC9E1C5D0
    }

    public class VRCConstraintSource : ValueType
    {
        public UnityEngine.Transform SourceTransform; // 0x10
        public float Weight; // 0x18
        public UnityEngine.Vector3 ParentPositionOffset; // 0x1C
        public UnityEngine.Vector3 ParentRotationOffset; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9E1C7E0 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFAC9E1C860
    }

    public class VRCConstraintSourceKeyableList : ValueType
    {
        public int Count;
        public VRC.Dynamics.VRCConstraintSource OverflowList; // 0x10
        public VRC.Dynamics.VRCConstraintSource ValueEnumerator; // 0x38
        public VRC.Dynamics.VRCConstraintSource IsReadOnly; // 0x60
        public VRC.Dynamics.VRCConstraintSource IsFixedSize; // 0x88
        public VRC.Dynamics.VRCConstraintSource System.Collections.ICollection.IsSynchronized; // 0xB0
        public VRC.Dynamics.VRCConstraintSource System.Collections.ICollection.SyncRoot; // 0xD8
        public VRC.Dynamics.VRCConstraintSource System.Collections.IList.Item; // 0x100
        public VRC.Dynamics.VRCConstraintSource Item; // 0x128
        public VRC.Dynamics.VRCConstraintSource source8; // 0x150
        public VRC.Dynamics.VRCConstraintSource source9; // 0x178
        public VRC.Dynamics.VRCConstraintSource source10; // 0x1A0
        public VRC.Dynamics.VRCConstraintSource source11; // 0x1C8
        public VRC.Dynamics.VRCConstraintSource source12; // 0x1F0
        public VRC.Dynamics.VRCConstraintSource source13; // 0x218
        public VRC.Dynamics.VRCConstraintSource source14; // 0x240
        public VRC.Dynamics.VRCConstraintSource source15; // 0x268
        public int totalLength; // 0x290
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintSource> overflowList; // 0x298
        public System.Collections.Generic.IEnumerator`1<VRC.Dynamics.VRCConstraintSource> _valueEnumerator; // 0x2A0

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC9E1C970
        public void get_OverflowList(){} // RVA: 0x7FFAC9E1C980
        public void get_ValueEnumerator(){} // RVA: 0x7FFAC9E1CA50
        public void .ctor(){} // RVA: 0x7FFAC9E1D000 | overloaded x2
        public void Get(){} // RVA: 0x7FFAC9E1E4C0
        public void Set(){} // RVA: 0x7FFAC9E1E7C0
        public void GetEnumerator(){} // RVA: 0x7FFAC9E1EE00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9E1EE00
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC9E1EE10
        public void Add(){} // RVA: 0x7FFAC9E1EEC0
        public void Clear(){} // RVA: 0x7FFAC9E1EF10
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC9E1EF90
        public void IndexOf(){} // RVA: 0x7FFAC9E1F030
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC9E1F160
        public void Contains(){} // RVA: 0x7FFAC9E1F230
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC9E1F360
        public void CopyTo(){} // RVA: 0x7FFAC9E1F560
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC9E1F770
        public void Remove(){} // RVA: 0x7FFAC9E1F810
        public void RemoveAt(){} // RVA: 0x7FFAC9E1F950
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC9E1FB30
        public void Insert(){} // RVA: 0x7FFAC9E1FBD0
        public void SetLength(){} // RVA: 0x7FFAC9E1FD20
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC3006850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC9E20090
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC9E200E0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC9E20160
        public void get_Item(){} // RVA: 0x7FFAC9E20200
        public void set_Item(){} // RVA: 0x7FFAC9E20240
    }

    public class VRCDynamicsLoop : Object
    {
        public System.Collections.Generic.List`1<Cysharp.Threading.Tasks.UniTaskCompletionSource> ÍÌÍÌÏÎÍÎÌÌÌÍÏÍÍÎÍÍÍÌÎÎÍ;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC3AA9630
        public void Equals(){} // RVA: 0x7FFAC3AA9780
        public void GetHashCode(){} // RVA: 0x7FFAC3AA9870
    }

    public class VRCDynamicsScheduler : Object
    {
        public VRC.Core.Burst.DisposableJobHandle _currentDynamicsJobHandle;
        public System.Action OnFrameComplete; // 0x10
        public System.Action OnFrameCompleteLate; // 0x18
        public int _latestCompletedFrameNumber; // 0x20

        // ── Methods ──
        public void add_OnFrameComplete(){} // RVA: 0x7FFAC9DFF190
        public void remove_OnFrameComplete(){} // RVA: 0x7FFAC9DFF2E0
        public void add_OnFrameCompleteLate(){} // RVA: 0x7FFAC9DFF430
        public void remove_OnFrameCompleteLate(){} // RVA: 0x7FFAC9DFF580
        public void Initialize(){} // RVA: 0x7FFAC9DFF6D0
        public void UpdateConstraints(){} // RVA: 0x7FFAC9DFF830
        public void PreScheduleDynamics(){} // RVA: 0x7FFAC9DFF8C0
        public void PostScheduleDynamics(){} // RVA: 0x7FFAC9DFFC80
        public void CompleteDynamicsFrame(){} // RVA: 0x7FFAC9DFFDF0
        public void OnCameraPreCull(){} // RVA: 0x7FFAC9DFFF90
        public void FinalizeJob(){} // RVA: 0x7FFAC9DFFFE0
        public void SignalFrameComplete(){} // RVA: 0x7FFAC9E000B0
        public void HandleEditorPlayModeToggle(){} // RVA: 0x7FFAC9E001E0
        public void .cctor(){} // RVA: 0x7FFAC9E00240
    }

    public class VRCPhysBoneBase : DynamicsComponent
    {
        public bool SortingBaseTransform; // 0x28
        public bool MaximumExecutionGroups; // 0x29
        public bool ExecutionGroup; // 0x2A
        public bool HasUdonEmitter; // 0x2B
        public bool IsGrabbed; // 0x2C
        public bool IsPosed; // 0x2D
        public bool Angle; // 0x2E
        public bool Stretch; // 0x2F
        public string Squish;
        public string PARAM_ISPOSED;
        public string PARAM_ANGLE;
        public string PARAM_STRETCH;
        public string PARAM_SQUISH;
        public 0x6B2606E0 version; // 0x30
        public 0x6B2606E0 LatestVersion;
        public 0x6B2607E8 integrationType; // 0x34
        public UnityEngine.Transform rootTransform; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.Transform> ignoreTransforms; // 0x40
        public bool ignoreOtherPhysBones; // 0x48
        public UnityEngine.Vector3 endpointPosition; // 0x4C
        public 0x6B260840 multiChildType; // 0x58
        public float pull; // 0x5C
        public UnityEngine.AnimationCurve pullCurve; // 0x60
        public float spring; // 0x68
        public UnityEngine.AnimationCurve springCurve; // 0x70
        public float stiffness; // 0x78
        public UnityEngine.AnimationCurve stiffnessCurve; // 0x80
        public float gravity; // 0x88
        public UnityEngine.AnimationCurve gravityCurve; // 0x90
        public float gravityFalloff; // 0x98
        public UnityEngine.AnimationCurve gravityFalloffCurve; // 0xA0
        public 0x6B260898 immobileType; // 0xA8
        public float immobile; // 0xAC
        public UnityEngine.AnimationCurve immobileCurve; // 0xB0
        public 0x6B260738 allowCollision; // 0xB8
        public PermissionFilter collisionFilter; // 0xBC
        public float radius; // 0xC4
        public UnityEngine.AnimationCurve radiusCurve; // 0xC8
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneColliderBase> colliders; // 0xD0
        public 0x6B2608F0 limitType; // 0xD8
        public float maxAngleX; // 0xDC
        public UnityEngine.AnimationCurve maxAngleXCurve; // 0xE0
        public float maxAngleZ; // 0xE8
        public UnityEngine.AnimationCurve maxAngleZCurve; // 0xF0
        public UnityEngine.Vector3 limitRotation; // 0xF8
        public UnityEngine.AnimationCurve limitRotationXCurve; // 0x108
        public UnityEngine.AnimationCurve limitRotationYCurve; // 0x110
        public UnityEngine.AnimationCurve limitRotationZCurve; // 0x118
        public UnityEngine.Vector3 staticFreezeAxis; // 0x120
        public 0x6B260738 allowGrabbing; // 0x12C
        public PermissionFilter grabFilter; // 0x130
        public 0x6B260738 allowPosing; // 0x138
        public PermissionFilter poseFilter; // 0x13C
        public bool snapToHand; // 0x144
        public float grabMovement; // 0x148
        public float maxStretch; // 0x14C
        public UnityEngine.AnimationCurve maxStretchCurve; // 0x150
        public float maxSquish; // 0x158
        public UnityEngine.AnimationCurve maxSquishCurve; // 0x160
        public float stretchMotion; // 0x168
        public UnityEngine.AnimationCurve stretchMotionCurve; // 0x170
        public bool isAnimated; // 0x178
        public bool resetWhenDisabled; // 0x179
        public string parameter; // 0x180
        public bool showGizmos; // 0x188
        public float boneOpacity; // 0x18C
        public float limitOpacity; // 0x190
        public bool configHasUpdated; // 0x194
        public System.Collections.Generic.List`1<Bone> bones; // 0x198
        public int maxBoneChainIndex; // 0x1A0
        public VRC.Dynamics.ChainId chainId; // 0x1A8
        public System.Action OnNeedsNetworkSync; // 0x1B8
        public System.Func`2<UnityEngine.Component,int> getPlayerIdCallback; // 0x1C0
        public int playerId; // 0x1C8
        public int netId; // 0x1CC
        public int netSubId; // 0x1D0
        public bool collidersHaveUpdated; // 0x1D4
        public UnityEngine.Transform worldImmobileTransform; // 0x1D8
        public Grab grab; // 0x1E0
        public VRC.Dynamics.PhysBoneRootDefinition root; // 0x1E8
        public VRC.Dynamics.ParentChangeDetector _parentChangeDetector; // 0x1F0
        public int <ExecutionGroup>k__BackingField; // 0x1F8
        public System.Action OnPoseUpdated; // 0x200
        public System.Action`1<VRC.Dynamics.VRCPhysBoneBase> OnInitialize; // 0x8
        public bool hasInitParams; // 0x208
        public bool hasInitTransform; // 0x209
        public System.Func`3<int,int,bool> OnVerifyCollision; // 0x10
        public Shape shape; // 0x210
        public System.Collections.Generic.List`1<CollisionRecord> collisionRecords; // 0x218
        public bool param_IsGrabbedValue; // 0x220
        public bool param_IsPosedValue; // 0x221
        public float param_AngleValue; // 0x224
        public float param_StretchValue; // 0x228
        public float param_SquishValue; // 0x22C
        public VRC.SDKBase.IAnimParameterAccess param_IsGrabbed; // 0x230
        public VRC.SDKBase.IAnimParameterAccess param_IsPosed; // 0x238
        public VRC.SDKBase.IAnimParameterAccess param_Angle; // 0x240
        public VRC.SDKBase.IAnimParameterAccess param_Stretch; // 0x248
        public VRC.SDKBase.IAnimParameterAccess param_Squish; // 0x250
        public VRC.Dynamics.IPhysBoneUdonEmitter _udonEmitter; // 0x258
        public float MAX_STRETCH;

        // ── Methods ──
        public void GetRootTransform(){} // RVA: 0x7FFAC9E4FA00
        public void IsCollisionAllowed(){} // RVA: 0x7FFAC9E4FB20
        public void IsGrabAllowed(){} // RVA: 0x7FFAC9E4FBB0
        public void IsPoseAllowed(){} // RVA: 0x7FFAC9E4FC90
        public void GetPlayerId(){} // RVA: 0x7FFAC9E4FD50
        public void BuildChainId(){} // RVA: 0x7FFAC9E4FD80
        public void GenerateArbitraryChainId(){} // RVA: 0x7FFAC9E4FEA0
        public void get_SortingBaseTransform(){} // RVA: 0x7FFAC9E4FFD0
        public void GetKnownDependencies(){} // RVA: 0x7FFAC9E4FFE0
        public void get_MaximumExecutionGroups(){} // RVA: 0x7FFAC9E50210
        public void get_ExecutionGroup(){} // RVA: 0x7FFAC9E50240
        public void set_ExecutionGroup(){} // RVA: 0x7FFAC9E50250
        public void HandleTransformParentChanged(){} // RVA: 0x7FFAC9E50260
        public void ReEstablishPhysBoneRoot(){} // RVA: 0x7FFAC9E50430
        public void Reset(){} // RVA: 0x7FFAC9E50890
        public void Awake(){} // RVA: 0x7FFAC9E508F0
        public void Start(){} // RVA: 0x7FFAC9E50A90
        public void OnEnable(){} // RVA: 0x7FFAC9E50C80
        public void OnDisable(){} // RVA: 0x7FFAC9E50D80
        public void OnDestroy(){} // RVA: 0x7FFAC9E50EA0
        public void InitParameters(){} // RVA: 0x7FFAC9E50FE0
        public void InitColliders(){} // RVA: 0x7FFAC9E51070
        public void InitTransforms(){} // RVA: 0x7FFAC9E51350
        public void ResetTransformsToRestPosition(){} // RVA: 0x7FFAC9E516E0
        public void CalcBoneRatio(){} // RVA: 0x7FFAC9E51A00
        public void CalcTransformRatio(){} // RVA: 0x7FFAC9E51B10
        public void CalcRadius(){} // RVA: 0x7FFAC9E51BF0
        public void CalcPull(){} // RVA: 0x7FFAC9E51C90
        public void CalcSpring(){} // RVA: 0x7FFAC9E51D50
        public void CalcStiffness(){} // RVA: 0x7FFAC9E51E10
        public void CalcImmobile(){} // RVA: 0x7FFAC9E51ED0
        public void CalcMaxAngle(){} // RVA: 0x7FFAC9E51FA0
        public void CalcLimitRotation(){} // RVA: 0x7FFAC9E520F0
        public void CalcMaxStretch(){} // RVA: 0x7FFAC9E522E0
        public void CalcStretchMotion(){} // RVA: 0x7FFAC9E52390
        public void CalcMaxSquish(){} // RVA: 0x7FFAC9E52460
        public void CalcGravity(){} // RVA: 0x7FFAC9E52530
        public void CalcGravityFalloff(){} // RVA: 0x7FFAC9E525D0
        public void SafeEvaluate(){} // RVA: 0x7FFAC9E526A0
        public void OnShapeEnter(){} // RVA: 0x7FFAC9E52730
        public void OnShapeExit(){} // RVA: 0x7FFAC9E52AF0
        public void OnCollidersUpdated(){} // RVA: 0x7FFAC9E52BD0
        public void IsInteractionAllowed(){} // RVA: 0x7FFAC9E52BE0
        public void get_HasUdonEmitter(){} // RVA: 0x7FFAC9E52CB0
        public void get_IsGrabbed(){} // RVA: 0x7FFAC89FE710
        public void get_IsPosed(){} // RVA: 0x7FFAC9E52CC0
        public void get_Angle(){} // RVA: 0x7FFAC9E52CD0
        public void get_Stretch(){} // RVA: 0x7FFAC412E510
        public void get_Squish(){} // RVA: 0x7FFAC9E52CE0
        public void GetIsGrabbed(){} // RVA: 0x7FFAC89FE710
        public void SetGrab(){} // RVA: 0x7FFAC9E52CF0
        public void SetIsPosed(){} // RVA: 0x7FFAC9E52FE0
        public void SetAngle(){} // RVA: 0x7FFAC9E53280
        public void SetStretch(){} // RVA: 0x7FFAC9E532F0
        public void SetSquish(){} // RVA: 0x7FFAC9E53360
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFAC9E533D0
        public void ReleaseGrabs(){} // RVA: 0x7FFAC9E533E0
        public void ReleasePoses(){} // RVA: 0x7FFAC9E53470
        public void AssignUdonEmitter(){} // RVA: 0x7FFAC334B310
        public void .ctor(){} // RVA: 0x7FFAC9E53560
        public void .cctor(){} // RVA: 0x7FFAC9E539B0
        public void <InitTransforms>g__GetTransforms|119_0(){} // RVA: 0x7FFAC9E539F0
    }

    public class VRCPhysBoneColliderBase : DynamicsComponent
    {
        public UnityEngine.Transform axis; // 0x28
        public 0x6B260AA8 isGlobalCollider; // 0x30
        public bool MaximumExecutionGroups; // 0x34
        public float ExecutionGroup; // 0x38
        public float SortingBaseTransform; // 0x3C
        public UnityEngine.Vector3 GlobalColliderFlags; // 0x40
        public UnityEngine.Quaternion rotation; // 0x4C
        public bool bonesAsSpheres; // 0x5C
        public 0x6B25DAE0 globalCollisionFlags; // 0x60
        public bool _hasClientDefinedGlobalCollisionState; // 0x64
        public System.Func`2<UnityEngine.Component,int> getPlayerIdCallback; // 0x68
        public int playerId; // 0x70
        public Shape shape; // 0x78
        public VRC.Dynamics.ParentChangeDetector _parentChangeDetector; // 0x80
        public int <ExecutionGroup>k__BackingField; // 0x88
        public System.Action`1<VRC.Dynamics.VRCPhysBoneColliderBase> OnPreShapeInitialize;

        // ── Methods ──
        public void GetRootTransform(){} // RVA: 0x7FFAC9E543D0
        public void get_axis(){} // RVA: 0x7FFAC9E544F0
        public void get_isGlobalCollider(){} // RVA: 0x7FFAC9E546F0
        public void set_isGlobalCollider(){} // RVA: 0x7FFAC9E54700
        public void GetPlayerId(){} // RVA: 0x7FFAC9E54720
        public void get_MaximumExecutionGroups(){} // RVA: 0x7FFAC9E50210
        public void get_ExecutionGroup(){} // RVA: 0x7FFAC37EE8C0
        public void set_ExecutionGroup(){} // RVA: 0x7FFAC37F9DE0
        public void get_SortingBaseTransform(){} // RVA: 0x7FFAC9E54740
        public void GetKnownDependencies(){} // RVA: 0x7FFAC2F21310
        public void get_GlobalColliderFlags(){} // RVA: 0x7FFAC9E54750
        public void set_GlobalColliderFlags(){} // RVA: 0x7FFAC9E54830
        public void Awake(){} // RVA: 0x7FFAC9E54840
        public void OnEnable(){} // RVA: 0x7FFAC9E549E0
        public void OnDisable(){} // RVA: 0x7FFAC9E54A50
        public void OnDestroy(){} // RVA: 0x7FFAC9E54C40
        public void InitShape(){} // RVA: 0x7FFAC9E54D80
        public void UpdateShape(){} // RVA: 0x7FFAC9E55050
        public void GetBounds(){} // RVA: 0x7FFAC9E55250
        public void HandleParentChanged(){} // RVA: 0x7FFAC9E55920
        public void .ctor(){} // RVA: 0x7FFAC9E55AE0
    }

}