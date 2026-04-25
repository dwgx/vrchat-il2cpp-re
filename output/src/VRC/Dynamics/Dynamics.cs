// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics
// Classes: 51
// Methods: 658

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
        public void get_ApplicationUnityConstraint(){} // RVA: 0x7FFD4E078E90
        public void get_ApplicationVrcConstraint(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Synchronize(){} // RVA: 0x7FFD4E07FB50
        public void SynchronizeInternal(){} // RVA: 0x7FFD4E079960
        public void RestoreUnityConstraintEnabledState(){} // RVA: 0x7FFD4E090980
        public void ChangeProperty(){} // RVA: 0x7FFD4E07A350 | overloaded x5
        public void <Synchronize>g__PushResult|11_0(){} // RVA: 0x7FFD4E096370
    }

    public class AnimParameterAccessAvatarSDK : Object
    {
        public UnityEngine.Animator boolVal; // 0x10
        public int intVal; // 0x18
        public lay floatVal; // 0x1C
        public bool valid; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552404D0
        public void get_boolVal(){} // RVA: 0x7FFD55240760
        public void set_boolVal(){} // RVA: 0x7FFD55240860
        public void get_intVal(){} // RVA: 0x7FFD55240970
        public void set_intVal(){} // RVA: 0x7FFD55240A60
        public void get_floatVal(){} // RVA: 0x7FFD55240B70
        public void set_floatVal(){} // RVA: 0x7FFD55240C60
    }

    public class ChainId : ValueType
    {
        public VRC.Dynamics.ChainId A;
        public ulong B; // 0x10
        public ulong b; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC7CA00
        public void Equals(){} // RVA: 0x7FFD55249C50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD55249D70
        public void op_Equality(){} // RVA: 0x7FFD4FC7CA30
        public void op_Inequality(){} // RVA: 0x7FFD4FC7CA50
        public void ToString(){} // RVA: 0x7FFD55249F50
        public void get_A(){} // RVA: 0x7FFD4EEF9F60
        public void get_B(){} // RVA: 0x7FFD4F840220
        public void .cctor(){} // RVA: 0x7FFD4E341310
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
        public void get_scene(){} // RVA: 0x7FFD4E35C380
        public void set_scene(){} // RVA: 0x7FFD4E342E30
        public void AddShape(){} // RVA: 0x7FFD55210280
        public void RemoveShape(){} // RVA: 0x7FFD552102D0
        public void CastShape(){} // RVA: 0x7FFD4E341310
        public void DrawGizmos(){} // RVA: 0x7FFD4E341310
        public void ScheduleJobs(){} // RVA: 0x7FFD55210500
        public void OnComplete(){} // RVA: 0x7FFD4E341310
        public void Dispose(){} // RVA: 0x7FFD55210C80
        public void .ctor(){} // RVA: 0x7FFD55210D10
        public void .cctor(){} // RVA: 0x7FFD55210EC0
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
        public void get_scene(){} // RVA: 0x7FFD4E35C380
        public void set_scene(){} // RVA: 0x7FFD4E342E30
        public void AddShape(){} // RVA: 0x7FFD4E341310
        public void RemoveShape(){} // RVA: 0x7FFD55212E10
        public void CastShape(){} // RVA: 0x7FFD552141D0 | overloaded x2
        public void ScheduleJobs(){} // RVA: 0x7FFD552135E0
        public void OnComplete(){} // RVA: 0x7FFD4E341310
        public void Dispose(){} // RVA: 0x7FFD55213EB0
        public void DrawGizmos(){} // RVA: 0x7FFD55214660
        public void .ctor(){} // RVA: 0x7FFD55214CC0
        public void .cctor(){} // RVA: 0x7FFD55214ED0
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
        public Unity.Collections.NativeArray`1<0x664E1038> transformData; // 0x68
        public VRC.Core.Burst.DisposableJobHandle jobHandle; // 0x78
        public bool jobHandlePendingCompletion; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552180B0 | overloaded x2
        public void SetBroadphase(){} // RVA: 0x7FFD55218750
        public void GetBroadphase(){} // RVA: 0x7FFD4E35C380
        public void AddShape(){} // RVA: 0x7FFD55218870
        public void RemoveShape(){} // RVA: 0x7FFD55218920
        public void UpdateShapeData(){} // RVA: 0x7FFD552189C0
        public void GetShapeData(){} // RVA: 0x7FFD55218DF0 | overloaded x2
        public void ShapeCount(){} // RVA: 0x7FFD55218E90
        public void CastSphere(){} // RVA: 0x7FFD55218EE0
        public void UpdateBounds(){} // RVA: 0x7FFD552194A0
        public void UpdateAndSchedule(){} // RVA: 0x7FFD55219670
        public void ScheduleReadTransforms(){} // RVA: 0x7FFD55219830
        public void ScheduleUpdateShapePositions(){} // RVA: 0x7FFD55219A10
        public void Complete(){} // RVA: 0x7FFD55219CD0
        public void Dispose(){} // RVA: 0x7FFD55219EC0
        public void SyncShapesNow(){} // RVA: 0x7FFD5521A0F0
        public void RemoveShapes(){} // RVA: 0x7FFD5521A100
        public void AddShapes(){} // RVA: 0x7FFD5521A900
        public void FindAvailableId(){} // RVA: 0x7FFD5521AFE0
        public void DrawGizmos(){} // RVA: 0x7FFD5521B080
        public void .cctor(){} // RVA: 0x7FFD5521B150
    }

    public class ContactBase : DynamicsComponent
    {
        public float axis;
        public int IsLocalOnly;
        public System.Func`2<VRC.Dynamics.ContactBase,bool> AffectedByAllowFlags;
        public UnityEngine.Transform rootTransform; // 0x28
        public 0x665BED70 shapeType; // 0x30
        public float radius; // 0x34
        public float height; // 0x38
        public UnityEngine.Vector3 position; // 0x3C
        public UnityEngine.Quaternion rotation; // 0x48
        public bool localOnly; // 0x58
        public 0x665BDAE0 contentTypes; // 0x5C
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
        public void GetRootTransform(){} // RVA: 0x7FFD55240D80
        public void get_axis(){} // RVA: 0x7FFD55240EA0
        public void get_IsLocalOnly(){} // RVA: 0x7FFD4E55F600
        public void Start(){} // RVA: 0x7FFD552410A0
        public void OnEnable(){} // RVA: 0x7FFD55241210
        public void OnDisable(){} // RVA: 0x7FFD55241290
        public void ValidateTagsList(){} // RVA: 0x7FFD55241310
        public void InitParameters(){} // RVA: 0x7FFD55241470
        public void Init(){} // RVA: 0x7FFD552414E0
        public void GetPlayerId(){} // RVA: 0x7FFD552415F0
        public void IsReceiver(){} // RVA: 0x7FFD4E079D00
        public void RequiresUpdate(){} // RVA: 0x7FFD55241620
        public void get_AffectedByAllowFlags(){} // RVA: 0x7FFD55241660
        public void UpdateContact(){} // RVA: 0x7FFD552416A0
        public void InitShape(){} // RVA: 0x7FFD55241830
        public void UpdateShape(){} // RVA: 0x7FFD55241AE0
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFD55241C80
        public void UpdateContentTypes(){} // RVA: 0x7FFD4EA4EB40
        public void UpdateCollisionTags(){} // RVA: 0x7FFD55241C90
        public void .ctor(){} // RVA: 0x7FFD55241DB0
    }

    public class ContactBaseProxy`2 : Object
    {
        public T isValid;
        public VRC.SDKBase.VRCPlayerApi contactShapeId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_isValid(){} // RVA: 0x7FFD4E079D00
        public void get_contactShapeId(){} // RVA: 0x7FFD4E078DC0
        public void get_player(){} // RVA: 0x7FFD4E078E90
        public void get_usage(){} // RVA: 0x7FFD4E079960
        public void get_position(){} // RVA: 0x7FFD4E0788A0
        public void get_rotation(){} // RVA: 0x7FFD4E0788A0
        public void get_scale(){} // RVA: 0x7FFD4E0788A0
        public void Equals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class ContactEnterInfo : ValueType
    {
        public 0x665BEF28 contactSender; // 0x10
        public 0x665BEF80 contactReceiver; // 0x18
        public UnityEngine.Vector3 enterVelocity; // 0x20
        public UnityEngine.Vector3 contactPoint; // 0x2C
        public string[] matchingTags; // 0x38

        // ── Methods ──
        public void get_contactSender(){} // RVA: 0x7FFD4EEF9F60
        public void set_contactSender(){} // RVA: 0x7FFD4ECFFE40
        public void get_contactReceiver(){} // RVA: 0x7FFD4F840220
        public void set_contactReceiver(){} // RVA: 0x7FFD4F840240
        public void get_enterVelocity(){} // RVA: 0x7FFD4E35E8D0
        public void set_enterVelocity(){} // RVA: 0x7FFD4E35E8F0
        public void get_contactPoint(){} // RVA: 0x7FFD54A585C0
        public void set_contactPoint(){} // RVA: 0x7FFD54A585E0
        public void get_matchingTags(){} // RVA: 0x7FFD4E36F130
        public void set_matchingTags(){} // RVA: 0x7FFD4E342E90
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
        public 0x665BEFD8 _jobState; // 0x48
        public bool drawGizmos; // 0x4C
        public int MAX_COLLISION_RECORDS; // 0x20
        public int THREAD_BATCH_SIZE; // 0x24
        public Unity.Collections.NativeList`1<int> receivesToUpdate; // 0x50
        public Unity.Collections.NativeArray`1<0x665BF030> receiverData; // 0x58
        public System.Collections.Generic.List`1<VRC.Dynamics.ContactReceiver> needsShapeID; // 0x68

        // ── Methods ──
        public void AddContact(){} // RVA: 0x7FFD55242560
        public void RemoveContact(){} // RVA: 0x7FFD55242AE0
        public void GetContacts(){} // RVA: 0x7FFD55242EE0
        public void CalcClosestPoint(){} // RVA: 0x7FFD55242FB0
        public void CalcRelativeVelocity(){} // RVA: 0x7FFD552437A0
        public void Awake(){} // RVA: 0x7FFD55243C00
        public void OnDestroy(){} // RVA: 0x7FFD55244030
        public void LateUpdate(){} // RVA: 0x7FFD552446A0
        public void ScheduleUpdateReceiversJob(){} // RVA: 0x7FFD55244730
        public void HandleDynamicsFrameComplete(){} // RVA: 0x7FFD55244ED0
        public void OnDrawGizmos(){} // RVA: 0x7FFD55245110
        public void FindAvailableId(){} // RVA: 0x7FFD55245140
        public void .ctor(){} // RVA: 0x7FFD552451D0
        public void .cctor(){} // RVA: 0x7FFD552453D0
        public void Initialize$UpdateReceiversFunctions_CalcProximity_000001C3$BurstDirectCall(){} // RVA: 0x7FFD552455A0
    }

    public class ContactReceiver : ContactBase
    {
        public bool EffectiveReceiverType; // 0x90
        public bool allowOthers; // 0x91
        public 0x665BF240 receiverType; // 0x94
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
        public void get_EffectiveReceiverType(){} // RVA: 0x7FFD55246980
        public void IsReceiver(){} // RVA: 0x7FFD4E426850
        public void Start(){} // RVA: 0x7FFD552469B0
        public void OnDisable(){} // RVA: 0x7FFD55246D70
        public void OnDisableInCollisionScene(){} // RVA: 0x7FFD55246E20
        public void OnReenableInCollisionScene(){} // RVA: 0x7FFD55246EC0
        public void OnShapeEnter(){} // RVA: 0x7FFD55246EE0
        public void OnShapeExit(){} // RVA: 0x7FFD552471D0
        public void AddCollision(){} // RVA: 0x7FFD552471E0
        public void RemoveCollision(){} // RVA: 0x7FFD55247C20
        public void RemoveFromManagerData(){} // RVA: 0x7FFD55247F20
        public void BuildMatchingTagsArray(){} // RVA: 0x7FFD55248160
        public void AttemptAddCollision(){} // RVA: 0x7FFD55248550
        public void ValidateCollider(){} // RVA: 0x7FFD552487A0
        public void ValidateColliderPermissions(){} // RVA: 0x7FFD55248A50
        public void IsColliding(){} // RVA: 0x7FFD55248C00
        public void RequiresUpdate(){} // RVA: 0x7FFD55248C50
        public void UpdateContact(){} // RVA: 0x7FFD55248CC0
        public void RefreshValidatedCollisions(){} // RVA: 0x7FFD55249060
        public void UpdateParameter(){} // RVA: 0x7FFD55249150
        public void SetParameter(){} // RVA: 0x7FFD552491E0
        public void AssignUdonEmitter(){} // RVA: 0x7FFD4E76B370
        public void CalculateProximity(){} // RVA: 0x7FFD55249300 | overloaded x2
        public void UpdateCollisionTags(){} // RVA: 0x7FFD55249410
        public void InitCollisionTags(){} // RVA: 0x7FFD55249540
        public void CheckForMask(){} // RVA: 0x7FFD552496D0
        public void .ctor(){} // RVA: 0x7FFD55249890
        public void .cctor(){} // RVA: 0x7FFD55249AD0
    }

    public class ContactReceiverUdonEmitter : Object
    {
        public VRC.Udon.Common.Interfaces.IUdonBehaviour[] _udonBehaviours; // 0x10
        public string EventOnContactEnter;
        public string EventOnContactExit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552C2930
        public void OnContactEnter(){} // RVA: 0x7FFD552C29E0
        public void OnContactExit(){} // RVA: 0x7FFD552C2D20
    }

    public class ContactSender : ContactBase
    {
        // ── Methods ──
        public void IsReceiver(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD55249BB0
    }

    public class CorrectQuaternion_000000BA$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5130DF60
        public void Invoke(){} // RVA: 0x7FFD4E49D370
        public void BeginInvoke(){} // RVA: 0x7FFD55229E10
        public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
    }

    public class DynamicsComponent : MonoBehaviour
    {
        public 0x665BDA88 DefaultUsage;
        public 0x665BDA88 Usage; // 0x20

        // ── Methods ──
        public void get_DefaultUsage(){} // RVA: 0x7FFD5521EE10
        public void set_DefaultUsage(){} // RVA: 0x7FFD5521EE50
        public void get_Usage(){} // RVA: 0x7FFD5521EE90
        public void set_Usage(){} // RVA: 0x7FFD4E9FB7A0
        public void get_RawUsage(){} // RVA: 0x7FFD4E4FBBE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DynamicsSetup : Object
    {
        // ── Methods ──
        public void RuntimeInit(){} // RVA: 0x7FFD4EEBBB60
        public void Equals(){} // RVA: 0x7FFD4EEBBE10
        public void GetHashCode(){} // RVA: 0x7FFD4EEBC1B0
        public void op_Implicit(){} // RVA: 0x7FFD4EEBC5E0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EEBC960
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EEBCAC0
    }

    public class DynamicsUsageFlagsExtensions : Object
    {
        // ── Methods ──
        public void Contains(){} // RVA: 0x7FFD545B8D60 | overloaded x2
    }

    public class FixedTransformAccessArray : Object
    {
        public UnityEngine.Jobs.TransformAccessArray transformArray; // 0x10
        public Unity.Collections.NativeArray`1<int> lookupToId; // 0x18
        public Unity.Collections.NativeArray`1<int> lookupFromId; // 0x28
        public System.Collections.Generic.List`1<int> emptyQueue; // 0x38
        public int length; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5524A020
        public void Add(){} // RVA: 0x7FFD5524A230
        public void Remove(){} // RVA: 0x7FFD5524A410
        public void ChangeId(){} // RVA: 0x7FFD5524A540
        public void FindTransform(){} // RVA: 0x7FFD5524A560
        public void Dispose(){} // RVA: 0x7FFD5524A590
        public void GetLength(){} // RVA: 0x7FFD4E3E2080
        public void GetTransformAccessArray(){} // RVA: 0x7FFD4E35C380
        public void GetLookupToId(){} // RVA: 0x7FFD4E9F3330
        public void GetLookupFromId(){} // RVA: 0x7FFD4EFEF020
    }

    public class FromToRotation_000000BC$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53D8FA30
        public void Invoke(){} // RVA: 0x7FFD4E49D4E0
        public void BeginInvoke(){} // RVA: 0x7FFD5522A460
        public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
    }

    public class ICollisionBroadphase
    {
        public object scene;

        // ── Methods ──
        public void get_scene(){} // RVA: 0x7FFD4E078E90
        public void set_scene(){} // RVA: 0x7FFD4E090A40
        public void AddShape(){}
        public void RemoveShape(){}
        public void CastShape(){}
        public void ScheduleJobs(){}
        public void OnComplete(){} // RVA: 0x7FFD4E090980
        public void DrawGizmos(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class IContactReceiverUdonEmitter
    {
        // ── Methods ──
        public void OnContactEnter(){}
        public void OnContactExit(){}
    }

    public class IParameterSetup
    {
        // ── Methods ──
        public void InitParameters(){} // RVA: 0x7FFD4E090980
    }

    public class IPhysBoneDebugDrawer
    {
        public object Alpha;

        // ── Methods ──
        public void get_Alpha(){} // RVA: 0x7FFD4E08D880
        public void set_Alpha(){} // RVA: 0x7FFD4E09E480
        public void Line(){} // RVA: 0x7FFD4E2ADC40
        public void Sphere(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPhysBoneRoot
    {
        // ── Methods ──
        public void AddPhysBone(){} // RVA: 0x7FFD4E078F40
        public void RemovePhysBone(){} // RVA: 0x7FFD4E078F40
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
        public void get_ApplicationUnityConstraint(){} // RVA: 0x7FFD4E078E90
        public void get_ApplicationVrcConstraint(){} // RVA: 0x7FFD4E078E90
        public void Synchronize(){} // RVA: 0x7FFD4E07FB50
        public void RestoreUnityConstraintEnabledState(){} // RVA: 0x7FFD4E090980
    }

    public class IsLowWeightSource_000000B9$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552296E0
        public void Invoke(){} // RVA: 0x7FFD4E49D370
        public void BeginInvoke(){} // RVA: 0x7FFD552297C0
        public void EndInvoke(){} // RVA: 0x7FFD4EF03450
    }

    public class MathUtil : Object
    {
        // ── Methods ──
        public void DistancePointToPlane(){} // RVA: 0x7FFD5524A640
        public void ClosestPointOnPlane(){} // RVA: 0x7FFD5524A6A0
        public void AngleBetweenTwoNormals(){} // RVA: 0x7FFD5524A7D0 | overloaded x2
        public void CartesianToPolar(){} // RVA: 0x7FFD5524AB30
        public void PolarToCartesian(){} // RVA: 0x7FFD5524ACA0
        public void QuaternionToSwingTwist(){} // RVA: 0x7FFD5524AE30
        public void SwingTwistToQuaternion(){} // RVA: 0x7FFD5524AF20
        public void ClosestPointOnLineSegment_Ratio(){} // RVA: 0x7FFD5524B120
        public void ClosestPointOnLineSegment(){} // RVA: 0x7FFD5524B1F0
        public void ClosestPointsBetweenLineSegments(){} // RVA: 0x7FFD5524B320
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MemoryBuffer : Object
    {
        public int usedSpace; // 0x10
        public Unity.Collections.NativeHashMap`2<VRC.Dynamics.ChainId,int> spanMap; // 0x18
        public Unity.Collections.NativeList`1<MemorySpan> spans; // 0x20
        public 0x665BF7C0 spanList; // 0x28
        public 0x665BF818 dataList; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5524B6D0
        public void Dispose(){} // RVA: 0x7FFD5524B870
        public void Clear(){} // RVA: 0x7FFD5524B980
        public void ContainsId(){} // RVA: 0x7FFD5524BA70
        public void FindIndex(){} // RVA: 0x7FFD5524BB00
        public void Request(){} // RVA: 0x7FFD5524BBE0
        public void Release(){} // RVA: 0x7FFD5524BE00
        public void Compact(){} // RVA: 0x7FFD5524C0A0
        public void PrintDebug(){} // RVA: 0x7FFD5524C490
        public void GetFinalDataIndex(){} // RVA: 0x7FFD5524C7C0
    }

    public class ParentChangeDetector : MonoBehaviour
    {
        public System.Action OnParentChanged; // 0x20

        // ── Methods ──
        public void add_OnParentChanged(){} // RVA: 0x7FFD5521EF50
        public void remove_OnParentChanged(){} // RVA: 0x7FFD5521F040
        public void Awake(){} // RVA: 0x7FFD5521F130
        public void OnTransformParentChanged(){} // RVA: 0x7FFD4E6232C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PhysBoneGrabbedInfo : ValueType
    {
        public VRC.SDKBase.VRCPlayerApi player; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
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
        public void .ctor(){} // RVA: 0x7FFD5524ED50
        public void Dispose(){} // RVA: 0x7FFD5524EF40
        public void AddPhysBone(){} // RVA: 0x7FFD5524EFA0
        public void RemovePhysBone(){} // RVA: 0x7FFD5524F1E0
        public void MarkDirty(){} // RVA: 0x7FFD4F689BA0
        public void GetChains(){} // RVA: 0x7FFD5524F350
        public void AddShape(){} // RVA: 0x7FFD5524F5C0
        public void RemoveShape(){} // RVA: 0x7FFD5524F7E0
        public void GetShapes(){} // RVA: 0x7FFD4E5F0140
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
        public 0x665BF9D0 chainBuffer; // 0x50
        public 0x665BFA28 boneBuffer; // 0x58
        public VRC.Dynamics.RootsBuffer rootBuffer; // 0x60
        public EditorDebugInfo editorInfo; // 0x68
        public Unity.Collections.NativeArray`1<0x665BFD40> errorBuffer; // 0x90
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
        public void AddPhysBone(){} // RVA: 0x7FFD5524F900
        public void RemovePhysBone(){} // RVA: 0x7FFD5524FBA0
        public void HasPhysBone(){} // RVA: 0x7FFD5524FEA0
        public void FindPhysBone(){} // RVA: 0x7FFD5524FF30
        public void MarkRootDirty(){} // RVA: 0x7FFD5524FFE0
        public void UpdateStaleGroups(){} // RVA: 0x7FFD552500A0
        public void UpdateRoots(){} // RVA: 0x7FFD55250B10
        public void GetOrCreateRoot(){} // RVA: 0x7FFD55250D10
        public void ReassignPhysBoneToRoot(){} // RVA: 0x7FFD55250F40
        public void RemoveChains(){} // RVA: 0x7FFD55251210
        public void AddChains(){} // RVA: 0x7FFD55251860
        public void ApplyExtraTransforms(){} // RVA: 0x7FFD55254030
        public void AddCollider(){} // RVA: 0x7FFD552542D0
        public void RemoveCollider(){} // RVA: 0x7FFD552544E0
        public void GetColliderComponents(){} // RVA: 0x7FFD4E963900
        public void RemoveColliders(){} // RVA: 0x7FFD552545B0
        public void AddColliders(){} // RVA: 0x7FFD55254830
        public void GetChains(){} // RVA: 0x7FFD55254E60
        public void FindChainIndex(){} // RVA: 0x7FFD55254F00
        public void GetChain(){} // RVA: 0x7FFD55254FF0
        public void GetChainComponent(){} // RVA: 0x7FFD552550F0
        public void SetChain(){} // RVA: 0x7FFD55255170
        public void GetBone(){} // RVA: 0x7FFD55255270
        public void SetBone(){} // RVA: 0x7FFD55255380
        public void GetTransformData(){} // RVA: 0x7FFD55255480
        public void CalcLimitAxis(){} // RVA: 0x7FFD552556F0 | overloaded x2
        public void AlmostEquals(){} // RVA: 0x7FFD55255D70 | overloaded x2
        public void HasChanged(){} // RVA: 0x7FFD55255E70 | overloaded x2
        public void SafeInverse(){} // RVA: 0x7FFD55255F90
        public void Awake(){} // RVA: 0x7FFD552560A0
        public void OnDestroy(){} // RVA: 0x7FFD55256270
        public void Init(){} // RVA: 0x7FFD552566D0
        public void FixedUpdate(){} // RVA: 0x7FFD552570D0
        public void LateUpdate(){} // RVA: 0x7FFD55257140
        public void UpdateChains(){} // RVA: 0x7FFD552571F0
        public void ScheduleReadBoneJob(){} // RVA: 0x7FFD55257CB0
        public void ReportCriticalError(){} // RVA: 0x7FFD55257F00
        public void DumpObject(){} // RVA: 0x7FFD55258300
        public void ScheduleExecutionJob(){} // RVA: 0x7FFD55258550
        public void ScheduleUpdateRootsJob(){} // RVA: 0x7FFD552587F0
        public void ScheduleExecutionGroupJob(){} // RVA: 0x7FFD55258B50
        public void CalcBoneScale(){} // RVA: 0x7FFD54CC8C70
        public void CompleteJob(){} // RVA: 0x7FFD55259160
        public void PrintDebug(){} // RVA: 0x7FFD55259BE0 | overloaded x2
        public void OnDrawGizmos(){} // RVA: 0x7FFD55259EF0
        public void MarkExecutionGroupStale(){} // RVA: 0x7FFD5525A080 | overloaded x2
        public void IsCyclicDependency(){} // RVA: 0x7FFD5525A1E0
        public void UpdateExecutionGroupsForComponent(){} // RVA: 0x7FFD5525A430
        public void UpdateExecutionGroupsForRoot(){} // RVA: 0x7FFD5525A5E0 | overloaded x2
        public void UpdateExecutionGroups(){} // RVA: 0x7FFD5525A6E0
        public void UpdateExecutionGroup(){} // RVA: 0x7FFD5525BCA0
        public void RemoveFromExecutionGroup(){} // RVA: 0x7FFD5525C170
        public void AddToExecutionGroup(){} // RVA: 0x7FFD5525C2D0
        public void MarkGroupListDirty(){} // RVA: 0x7FFD5525C420
        public void GetExecutionGroup(){} // RVA: 0x7FFD5525C460
        public void ClearRootTiming(){} // RVA: 0x7FFD5525C4A0
        public void InitCollision(){} // RVA: 0x7FFD5525C650
        public void UpdateAndScheduleColliders(){} // RVA: 0x7FFD5525C750
        public void UpdateCollidersForChain(){} // RVA: 0x7FFD5525C830
        public void UpdateGrabs(){} // RVA: 0x7FFD5525D180
        public void InteractAllowed(){} // RVA: 0x7FFD5525D4C0
        public void AttemptGrab(){} // RVA: 0x7FFD5525F470 | overloaded x3
        public void IsChainGrabbed(){} // RVA: 0x7FFD5525F510
        public void ReleaseGrab(){} // RVA: 0x7FFD55260050 | overloaded x2
        public void AddGrab(){} // RVA: 0x7FFD5525F850
        public void GetGrabs(){} // RVA: 0x7FFD55260870
        public void CreatePose(){} // RVA: 0x7FFD55260920
        public void FindOrCreatePose(){} // RVA: 0x7FFD55260FA0
        public void RemovePoseForChain(){} // RVA: 0x7FFD552610A0
        public void RemovePose(){} // RVA: 0x7FFD55261220
        public void FindPose(){} // RVA: 0x7FFD552617B0
        public void .ctor(){} // RVA: 0x7FFD552618F0
        public void .cctor(){} // RVA: 0x7FFD552620E0
        public void <IsCyclicDependency>g__RecusriveSearch|122_0(){} // RVA: 0x7FFD55262490
        public void <UpdateExecutionGroups>g__FindSortingData|126_0(){} // RVA: 0x7FFD55262640
        public void <UpdateExecutionGroups>g__FindParentDependency|126_1(){} // RVA: 0x7FFD552627A0
    }

    public class PhysBoneRoot : MonoBehaviour
    {
        public 0x665C05D8 RootDefinition; // 0x20
        public VRC.Dynamics.PhysBoneRootDefinition Timing; // 0x28

        // ── Methods ──
        public void get_RootDefinition(){} // RVA: 0x7FFD4E36F130
        public void set_RootDefinition(){} // RVA: 0x7FFD4E342E90
        public void get_Timing(){} // RVA: 0x7FFD4E4FBBE0
        public void set_Timing(){} // RVA: 0x7FFD5526F730
        public void Awake(){} // RVA: 0x7FFD5526F800
        public void get_RequiredHideFlags(){} // RVA: 0x7FFD4E919180
        public void .ctor(){} // RVA: 0x7FFD4E341D50
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
        public void get_Transform(){} // RVA: 0x7FFD4E36F0C0
        public void get_AutoEvaluateFixedTime(){} // RVA: 0x7FFD4E516BA0
        public void set_AutoEvaluateFixedTime(){} // RVA: 0x7FFD5526F870
        public void get_UseFixedTime(){} // RVA: 0x7FFD4EC8C550
        public void set_UseFixedTime(){} // RVA: 0x7FFD5526F900
        public void .ctor(){} // RVA: 0x7FFD5526F990
    }

    public class PhysBoneUdonEmitter : Object
    {
        public VRC.Udon.Common.Interfaces.IUdonBehaviour[] _udonBehaviours; // 0x10
        public string EventOnPhysBoneGrabbed;
        public string EventOnPhysBoneReleased;
        public string EventOnPhysBonePosed;
        public string EventOnPhysBoneUnPosed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552C3010
        public void OnPhysBoneGrabbed(){} // RVA: 0x7FFD552C30C0
        public void OnPhysBoneReleased(){} // RVA: 0x7FFD552C32D0
        public void OnPhysBonePosed(){} // RVA: 0x7FFD552C34E0
        public void OnPhysBoneUnPosed(){} // RVA: 0x7FFD552C36F0
    }

    public class ReadTransformJob : ValueType
    {
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<0x664E1038> transformDataBuffer; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD55222990
    }

    public class RootsBuffer : Object
    {
        public Unity.Collections.NativeList`1<ChainRoot> roots; // 0x10
        public System.Collections.Generic.List`1<VRC.Dynamics.PhysBoneRootDefinition> comps; // 0x18
        public UnityEngine.Jobs.TransformAccessArray rootTransformsArray; // 0x20
        public System.Collections.Generic.List`1<int> available; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5524C8A0
        public void Dispose(){} // RVA: 0x7FFD5524CAA0
        public void AddBoneToRoot(){} // RVA: 0x7FFD5524CB10
        public void RemoveBoneFromRoot(){} // RVA: 0x7FFD5524CB30
        public void TryAddRoot(){} // RVA: 0x7FFD5524CBC0
        public void TryRemoveRoot(){} // RVA: 0x7FFD5524CF10
        public void FindRoot(){} // RVA: 0x7FFD5524D090
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
        public 0x665BE4D8 _pendingReallocation; // 0x32C
        public UnityEngine.Animator _containingAnimator; // 0x330
        public bool _hasContainingAnimator; // 0x338
        public bool _containingAnimatorLatestActiveState; // 0x339
        public bool _isAttachedToClone; // 0x33A
        public VRC.Dynamics.VRCPhysBoneBase[] _monitoredPhysBones; // 0x340
        public 0x665BEB60 _playerLoopStage; // 0x348
        public 0x665BE530 _physBoneDependency; // 0x34C
        public bool _dependsOnLocalAvatarProcessing; // 0x350
        public System.Collections.Generic.HashSet`1<System.Action`1<VRC.Dynamics.VRCConstraintBase>> _registeredBakeListeners; // 0x358
        public System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase>> OrderInfoPerGameObject;
        public int _localGameObjectOrder; // 0x360
        public bool _isInLocalGameObjectOrder; // 0x364
        public bool <IsPendingUnprocessed>k__BackingField; // 0x365
        public System.Collections.Generic.HashSet`1<VRC.Dynamics.VRCConstraintBase> _dependents; // 0x368
        public System.Collections.Generic.HashSet`1<VRC.Dynamics.VRCConstraintBase> _rootNodes; // 0x8
        public 0x6643E088 _dependencyTraversalMarks; // 0x10
        public int _dependencyTraversalMarksCounter; // 0x18
        public int _dependencyTraversalMarkIndex; // 0x370
        public bool _dependencyActiveMark; // 0x374
        public int MAX_TRAVERSAL_STEPS;
        public int _dependencyTraversalTotalSteps; // 0x1C
        public int _dependencyTraversalHighestDepth; // 0x378
        public int MAX_DEPENDENCY_DEPTH;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFD4E079960
        public void get_RotationMode(){} // RVA: 0x7FFD4E079960
        public void get_ScaleMode(){} // RVA: 0x7FFD4E079960
        public void get_AffectsPosition(){} // RVA: 0x7FFD5522AAE0
        public void get_AffectsRotation(){} // RVA: 0x7FFD5522AB10
        public void get_AffectsScale(){} // RVA: 0x7FFD5522AB40
        public void IsLocalPostProcessIndependent(){} // RVA: 0x7FFD5522AB70
        public void get_NativeIndex(){} // RVA: 0x7FFD5522ABF0
        public void set_NativeIndex(){} // RVA: 0x7FFD5522AC00
        public void get_CachedExecutionGroupIndex(){} // RVA: 0x7FFD54B76090
        public void get_LatestValidExecutionGroupIndex(){} // RVA: 0x7FFD5522AC10
        public void SetCachedExecutionGroupIndex(){} // RVA: 0x7FFD5522AC20
        public void get_DependencyRoot(){} // RVA: 0x7FFD5522AC30
        public void get_DependsOnLocalAvatarProcessing(){} // RVA: 0x7FFD5522ADF0
        public void set_DependsOnLocalAvatarProcessing(){} // RVA: 0x7FFD5522AE00
        public void ActivateConstraint(){} // RVA: 0x7FFD5522AE20
        public void ZeroConstraint(){} // RVA: 0x7FFD5522AE50
        public void ApplyZeroOffset(){} // RVA: 0x7FFD4E090980
        public void TryBakeCurrentOffsets(){} // RVA: 0x7FFD5522AF40
        public void TryBakeCurrentOffsetsRuntime(){} // RVA: 0x7FFD5522AFF0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFD4E090A40
        public void RegisterBakeListener(){} // RVA: 0x7FFD5522B380
        public void UnRegisterBakeListener(){} // RVA: 0x7FFD5522B3F0
        public void AssignBinding(){} // RVA: 0x7FFD5522B450
        public void GetBoundUnityConstraint(){} // RVA: 0x7FFD5522B900
        public void AddToLocalGameObjectOrder(){} // RVA: 0x7FFD5522B960
        public void RemoveFromLocalGameObjectOrder(){} // RVA: 0x7FFD5522BF40
        public void CalculateOrder(){} // RVA: 0x7FFD5522C190
        public void IsDependentOnTransform(){} // RVA: 0x7FFD5522C4A0
        public void GetEffectiveTargetTransform(){} // RVA: 0x7FFD5522C600
        public void SetupAvatarConstraint(){} // RVA: 0x7FFD5522C730
        public void SetupWorldConstraint(){} // RVA: 0x7FFD5522C9C0
        public void SetupPropConstraint(){} // RVA: 0x7FFD5522CB00
        public void Awake(){} // RVA: 0x7FFD5522CC40
        public void Start(){} // RVA: 0x7FFD5522CFD0
        public void OnEnable(){} // RVA: 0x7FFD5522D040
        public void OnDisable(){} // RVA: 0x7FFD5522D140
        public void OnDestroy(){} // RVA: 0x7FFD5522D210
        public void Dispose(){} // RVA: 0x7FFD5522D220
        public void GetTransformCount(){} // RVA: 0x7FFD5522D300
        public void RecalculateTransformCount(){} // RVA: 0x7FFD5522D350
        public void GetTransforms(){} // RVA: 0x7FFD5522D560
        public void GetManagedWorldUpTransform(){} // RVA: 0x7FFD4E919180
        public void AllocateJobData(){} // RVA: 0x7FFD5522D8C0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD5522DCE0
        public void ShouldCheckForChangingTargetParent(){} // RVA: 0x7FFD5522DCF0
        public void RequiresReallocation(){} // RVA: 0x7FFD5522DD50
        public void SynchronizeWithBinding(){} // RVA: 0x7FFD5522E290
        public void CheckReallocation(){} // RVA: 0x7FFD5522E320
        public void EstablishTargetTransform(){} // RVA: 0x7FFD5522E440
        public void ReEvaluatePhysBoneOrder(){} // RVA: 0x7FFD5522E810
        public void GatherPotentiallyDependentPhysBones(){} // RVA: 0x7FFD5522EAA0
        public void DeterminePhysBoneDependency(){} // RVA: 0x7FFD5522ECE0
        public void EstablishPlayerLoopStage(){} // RVA: 0x7FFD5522EF20
        public void AssignPlayerLoopStage(){} // RVA: 0x7FFD5522F110
        public void InvalidatePlayerLoopStage(){} // RVA: 0x7FFD5522F2A0
        public void UpdateJobData(){} // RVA: 0x7FFD5522F2B0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFD4E090A40
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7FFD4E341310
        public void AffectsAnyAxis(){} // RVA: 0x7FFD4E079D00
        public void PostUpdateJobData(){} // RVA: 0x7FFD5522F7E0
        public void CreateAxisBitfield(){} // RVA: 0x7FFD5522F840
        public void RequestFullNativeUpdate(){} // RVA: 0x7FFD5522DCE0
        public void GetPerSourcePositionOffsets(){} // RVA: 0x7FFD5522F860
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD5522F930
        public void get_IsPendingUnprocessed(){} // RVA: 0x7FFD5522FBF0
        public void set_IsPendingUnprocessed(){} // RVA: 0x7FFD5522FC00
        public void CalculateDependencies(){} // RVA: 0x7FFD5522FC10
        public void TraverseDependencies(){} // RVA: 0x7FFD5522FF10
        public void ReorganizeGroupsFastForRoot(){} // RVA: 0x7FFD552301D0
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFD5522DCE0
        public void .ctor(){} // RVA: 0x7FFD55230C80
        public void .cctor(){} // RVA: 0x7FFD55230E40
    }

    public class VRCConstraintGroup : Object
    {
        public int MemberCount;
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<int> MemberConstraintIndices; // 0x10

        // ── Methods ──
        public void get_MemberCount(){} // RVA: 0x7FFD552202A0
        public void .ctor(){} // RVA: 0x7FFD552202E0
        public void Dispose(){} // RVA: 0x7FFD552203A0
        public void AddConstraint(){} // RVA: 0x7FFD552203E0
        public void RemoveConstraintSwapBack(){} // RVA: 0x7FFD55220630
        public void RemoveConstraintAtSwapBack(){} // RVA: 0x7FFD552206F0
        public void UpdateNativeIndex(){} // RVA: 0x7FFD55220730
        public void RemoveAtSwapBack(){} // RVA: 0x7FFD552208C0
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
        public void get_GroupsAreStale(){} // RVA: 0x7FFD552209F0
        public void get_ExecutionGroups(){} // RVA: 0x7FFD55220A70
        public void .ctor(){} // RVA: 0x7FFD55220AE0
        public void Dispose(){} // RVA: 0x7FFD55220CE0
        public void RecordConstraintToAdd(){} // RVA: 0x7FFD55220FC0
        public void RecordConstraintToRemove(){} // RVA: 0x7FFD552210A0
        public void MarkRootStale(){} // RVA: 0x7FFD552217F0
        public void GetConstraintListForRoot(){} // RVA: 0x7FFD55221870
        public void RefreshGroups(){} // RVA: 0x7FFD55221990
        public void PrepareGroupsForReorganize(){} // RVA: 0x7FFD552220C0
        public void .cctor(){} // RVA: 0x7FFD55222840
    }

    public class VRCConstraintJob : ValueType
    {
        public 0x665BEB60 playerLoopStage; // 0x10
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<int> targetConstraintIndices; // 0x18
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<VRC.Dynamics.VRCConstraintJobData> constraints; // 0x30
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<0x664E1038> transformDataBuffer; // 0x48
        public Unity.Mathematics.float3 Float3Right;
        public Unity.Mathematics.float3 Float3Up; // 0xC
        public Unity.Mathematics.float3 Float3Forward; // 0x18
        public Unity.Mathematics.float3 Float3One; // 0x24
        public Unity.Mathematics.quaternion QuaternionZero; // 0x30

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD552229F0
        public void ProcessSource(){} // RVA: 0x7FFD55224770
        public void FinalizeLocalScaleResult(){} // RVA: 0x7FFD55225800
        public void PerformAimAt(){} // RVA: 0x7FFD55225B70
        public void TransformPoint(){} // RVA: 0x7FFD55226A60 | overloaded x2
        public void IsAnyAxisZero(){} // RVA: 0x7FFD55226AD0
        public void IsValidTrsMatrix(){} // RVA: 0x7FFD55226B20
        public void ConstraintHasSingleLowWeightSource(){} // RVA: 0x7FFD55226B70
        public void IsLowWeightSource(){} // RVA: 0x7FFD55226BC0
        public void CorrectQuaternion(){} // RVA: 0x7FFD55226C20
        public void GetTransformLossyScale(){} // RVA: 0x7FFD5521CD80
        public void FromToRotation(){} // RVA: 0x7FFD55226C80
        public void CalculateEulerZXY(){} // RVA: 0x7FFD55226CF0
        public void .cctor(){} // RVA: 0x7FFD55226F10
        public void TransformPoint$BurstManaged(){} // RVA: 0x7FFD55227070 | overloaded x2
        public void IsAnyAxisZero$BurstManaged(){} // RVA: 0x7FFD55227120
        public void IsValidTrsMatrix$BurstManaged(){} // RVA: 0x7FFD55227150
        public void ConstraintHasSingleLowWeightSource$BurstManaged(){} // RVA: 0x7FFD552271B0
        public void IsLowWeightSource$BurstManaged(){} // RVA: 0x7FFD55227270
        public void CorrectQuaternion$BurstManaged(){} // RVA: 0x7FFD552272A0
        public void FromToRotation$BurstManaged(){} // RVA: 0x7FFD55227400
    }

    public class VRCConstraintJobData : ValueType
    {
        public int TransformStartIndex; // 0x10
        public 0x665BEA00 PositionConstraintMode; // 0x14
        public 0x665BEA58 RotationConstraintMode; // 0x18
        public 0x665BEAB0 ScaleConstraintMode; // 0x1C
        public bool HasParentTransform; // 0x20
        public bool IsActive; // 0x21
        public float GlobalWeight; // 0x24
        public bool SolveInLocalSpace; // 0x28
        public bool FreezeToWorld; // 0x29
        public bool FreezeToWorldHasTrs; // 0x2A
        public Unity.Mathematics.float3 FrozenWorldPosition; // 0x2C
        public Unity.Mathematics.quaternion FrozenWorldRotation; // 0x38
        public Unity.Mathematics.float3 FrozenWorldScale; // 0x48
        public 0x665BEB60 PlayerLoopStage; // 0x54
        public bool AttachedToAvatarClone; // 0x58
        public bool Locked; // 0x59
        public 0x665BE378 PositionConfig; // 0x5C
        public 0x665BE378 RotationConfig; // 0x78
        public 0x665BE378 ScaleConfig; // 0x94
        public Unity.Mathematics.float3 AimAxis; // 0xB0
        public Unity.Mathematics.float3 UpAxis; // 0xBC
        public bool UseUpTransform; // 0xC8
        public float Roll; // 0xCC
        public 0x665BE428 WorldUpType; // 0xD0
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
        public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<0x664E1038> _transformDataBuffer; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.RangeInt> _emptyTransformRanges; // 0x58
        public System.Collections.Generic.List`1<System.ValueTuple`2<UnityEngine.Transform,bool>> _constraintTransformsBuffer; // 0x60
        public Unity.Profiling.ProfilerMarker _updateConstraintsProfilerMarkerSync; // 0x68
        public Unity.Profiling.ProfilerMarker _updateConstraintsProfilerMarkerReAlloc; // 0x70
        public Unity.Profiling.ProfilerMarker _updateConstraintsProfilerMarkerJobData; // 0x78
        public VRC.Dynamics.VRCConstraintGrouper _constraintGrouper; // 0x80
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCConstraintBase> UpdatedConstraintsBuffer; // 0x88

        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7FFD55235460
        public void get_CanExecuteConstraintJobsInEditMode(){} // RVA: 0x7FFD552354C0
        public void Initialize(){} // RVA: 0x7FFD55235520
        public void HandleQuit(){} // RVA: 0x7FFD55235D00
        public void UnInitialize(){} // RVA: 0x7FFD55235D70
        public void RegisterConstraint(){} // RVA: 0x7FFD55236170
        public void UnregisterConstraint(){} // RVA: 0x7FFD55236D90
        public void ReRegisterConstraint(){} // RVA: 0x7FFD55238020
        public void ReRegisterSameObjectConstraint(){} // RVA: 0x7FFD552380B0
        public void IsConstraintRegistered(){} // RVA: 0x7FFD55238180
        public void GetBufferedTransform(){} // RVA: 0x7FFD55238230
        public void SetBufferedTransform(){} // RVA: 0x7FFD552382E0
        public void GetFinalTransformIndex(){} // RVA: 0x7FFD55238580
        public void UpdateConstraints(){} // RVA: 0x7FFD55238980
        public void ScheduleReadJob(){} // RVA: 0x7FFD55238F50
        public void ScheduleExecutionJobs(){} // RVA: 0x7FFD55239150
        public void PostUpdateConstraints(){} // RVA: 0x7FFD552397C0
        public void TryCreateSubstituteConstraint(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD55239A40
    }

    public class VRCConstraintOffsetBaker : Object
    {
        public UnityEngine.Transform ShouldBakeAtRest; // 0x10
        public float ShouldBakeOffsets; // 0x18
        public 0x665BE588 _bakeOptions; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55239D30
        public void get_ShouldBakeAtRest(){} // RVA: 0x7FFD544B4450
        public void get_ShouldBakeOffsets(){} // RVA: 0x7FFD54893320
        public void Bake(){} // RVA: 0x7FFD5523A3B0 | overloaded x5
        public void CalculateBakedPositionOffset(){} // RVA: 0x7FFD5523AE50
        public void CalculateBakedRotationOffset(){} // RVA: 0x7FFD5523B7A0
        public void CalculateBakedScaleOffset(){} // RVA: 0x7FFD5523BF30
        public void AsSignedEulers(){} // RVA: 0x7FFD5523C4E0
        public void <AsSignedEulers>g__TreatEuler|16_0(){} // RVA: 0x7FFD5523C5D0
    }

    public class VRCConstraintSource : ValueType
    {
        public UnityEngine.Transform SourceTransform; // 0x10
        public float Weight; // 0x18
        public UnityEngine.Vector3 ParentPositionOffset; // 0x1C
        public UnityEngine.Vector3 ParentRotationOffset; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5523C7E0 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFD5523C860
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
        public void get_Count(){} // RVA: 0x7FFD5523C970
        public void get_OverflowList(){} // RVA: 0x7FFD5523C980
        public void get_ValueEnumerator(){} // RVA: 0x7FFD5523CA50
        public void .ctor(){} // RVA: 0x7FFD5523D000 | overloaded x2
        public void Get(){} // RVA: 0x7FFD5523E4C0
        public void Set(){} // RVA: 0x7FFD5523E7C0
        public void GetEnumerator(){} // RVA: 0x7FFD5523EE00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5523EE00
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD5523EE10
        public void Add(){} // RVA: 0x7FFD5523EEC0
        public void Clear(){} // RVA: 0x7FFD5523EF10
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD5523EF90
        public void IndexOf(){} // RVA: 0x7FFD5523F030
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD5523F160
        public void Contains(){} // RVA: 0x7FFD5523F230
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD5523F360
        public void CopyTo(){} // RVA: 0x7FFD5523F560
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD5523F770
        public void Remove(){} // RVA: 0x7FFD5523F810
        public void RemoveAt(){} // RVA: 0x7FFD5523F950
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD5523FB30
        public void Insert(){} // RVA: 0x7FFD5523FBD0
        public void SetLength(){} // RVA: 0x7FFD5523FD20
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void get_IsFixedSize(){} // RVA: 0x7FFD4E341320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E426850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD55240090
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD552400E0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD55240160
        public void get_Item(){} // RVA: 0x7FFD55240200
        public void set_Item(){} // RVA: 0x7FFD55240240
    }

    public class VRCDynamicsLoop : Object
    {
        public System.Collections.Generic.List`1<Cysharp.Threading.Tasks.UniTaskCompletionSource> ÍÌÍÌÏÎÍÎÌÌÌÍÏÍÍÎÍÍÍÌÎÎÍ;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4EEC9630
        public void Equals(){} // RVA: 0x7FFD4EEC9780
        public void GetHashCode(){} // RVA: 0x7FFD4EEC9870
    }

    public class VRCDynamicsScheduler : Object
    {
        public VRC.Core.Burst.DisposableJobHandle _currentDynamicsJobHandle;
        public System.Action OnFrameComplete; // 0x10
        public System.Action OnFrameCompleteLate; // 0x18
        public int _latestCompletedFrameNumber; // 0x20

        // ── Methods ──
        public void add_OnFrameComplete(){} // RVA: 0x7FFD5521F190
        public void remove_OnFrameComplete(){} // RVA: 0x7FFD5521F2E0
        public void add_OnFrameCompleteLate(){} // RVA: 0x7FFD5521F430
        public void remove_OnFrameCompleteLate(){} // RVA: 0x7FFD5521F580
        public void Initialize(){} // RVA: 0x7FFD5521F6D0
        public void UpdateConstraints(){} // RVA: 0x7FFD5521F830
        public void PreScheduleDynamics(){} // RVA: 0x7FFD5521F8C0
        public void PostScheduleDynamics(){} // RVA: 0x7FFD5521FC80
        public void CompleteDynamicsFrame(){} // RVA: 0x7FFD5521FDF0
        public void OnCameraPreCull(){} // RVA: 0x7FFD5521FF90
        public void FinalizeJob(){} // RVA: 0x7FFD5521FFE0
        public void SignalFrameComplete(){} // RVA: 0x7FFD552200B0
        public void HandleEditorPlayModeToggle(){} // RVA: 0x7FFD552201E0
        public void .cctor(){} // RVA: 0x7FFD55220240
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
        public 0x665C06E0 version; // 0x30
        public 0x665C06E0 LatestVersion;
        public 0x665C07E8 integrationType; // 0x34
        public UnityEngine.Transform rootTransform; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.Transform> ignoreTransforms; // 0x40
        public bool ignoreOtherPhysBones; // 0x48
        public UnityEngine.Vector3 endpointPosition; // 0x4C
        public 0x665C0840 multiChildType; // 0x58
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
        public 0x665C0898 immobileType; // 0xA8
        public float immobile; // 0xAC
        public UnityEngine.AnimationCurve immobileCurve; // 0xB0
        public 0x665C0738 allowCollision; // 0xB8
        public 0x665C0790 collisionFilter; // 0xBC
        public float radius; // 0xC4
        public UnityEngine.AnimationCurve radiusCurve; // 0xC8
        public System.Collections.Generic.List`1<VRC.Dynamics.VRCPhysBoneColliderBase> colliders; // 0xD0
        public 0x665C08F0 limitType; // 0xD8
        public float maxAngleX; // 0xDC
        public UnityEngine.AnimationCurve maxAngleXCurve; // 0xE0
        public float maxAngleZ; // 0xE8
        public UnityEngine.AnimationCurve maxAngleZCurve; // 0xF0
        public UnityEngine.Vector3 limitRotation; // 0xF8
        public UnityEngine.AnimationCurve limitRotationXCurve; // 0x108
        public UnityEngine.AnimationCurve limitRotationYCurve; // 0x110
        public UnityEngine.AnimationCurve limitRotationZCurve; // 0x118
        public UnityEngine.Vector3 staticFreezeAxis; // 0x120
        public 0x665C0738 allowGrabbing; // 0x12C
        public 0x665C0790 grabFilter; // 0x130
        public 0x665C0738 allowPosing; // 0x138
        public 0x665C0790 poseFilter; // 0x13C
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
        public System.Collections.Generic.List`1<0x665C0948> bones; // 0x198
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
        public System.Collections.Generic.List`1<0x665C09A0> collisionRecords; // 0x218
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
        public void GetRootTransform(){} // RVA: 0x7FFD5526FA00
        public void IsCollisionAllowed(){} // RVA: 0x7FFD5526FB20
        public void IsGrabAllowed(){} // RVA: 0x7FFD5526FBB0
        public void IsPoseAllowed(){} // RVA: 0x7FFD5526FC90
        public void GetPlayerId(){} // RVA: 0x7FFD5526FD50
        public void BuildChainId(){} // RVA: 0x7FFD5526FD80
        public void GenerateArbitraryChainId(){} // RVA: 0x7FFD5526FEA0
        public void get_SortingBaseTransform(){} // RVA: 0x7FFD5526FFD0
        public void GetKnownDependencies(){} // RVA: 0x7FFD5526FFE0
        public void get_MaximumExecutionGroups(){} // RVA: 0x7FFD55270210
        public void get_ExecutionGroup(){} // RVA: 0x7FFD55270240
        public void set_ExecutionGroup(){} // RVA: 0x7FFD55270250
        public void HandleTransformParentChanged(){} // RVA: 0x7FFD55270260
        public void ReEstablishPhysBoneRoot(){} // RVA: 0x7FFD55270430
        public void Reset(){} // RVA: 0x7FFD55270890
        public void Awake(){} // RVA: 0x7FFD552708F0
        public void Start(){} // RVA: 0x7FFD55270A90
        public void OnEnable(){} // RVA: 0x7FFD55270C80
        public void OnDisable(){} // RVA: 0x7FFD55270D80
        public void OnDestroy(){} // RVA: 0x7FFD55270EA0
        public void InitParameters(){} // RVA: 0x7FFD55270FE0
        public void InitColliders(){} // RVA: 0x7FFD55271070
        public void InitTransforms(){} // RVA: 0x7FFD55271350
        public void ResetTransformsToRestPosition(){} // RVA: 0x7FFD552716E0
        public void CalcBoneRatio(){} // RVA: 0x7FFD55271A00
        public void CalcTransformRatio(){} // RVA: 0x7FFD55271B10
        public void CalcRadius(){} // RVA: 0x7FFD55271BF0
        public void CalcPull(){} // RVA: 0x7FFD55271C90
        public void CalcSpring(){} // RVA: 0x7FFD55271D50
        public void CalcStiffness(){} // RVA: 0x7FFD55271E10
        public void CalcImmobile(){} // RVA: 0x7FFD55271ED0
        public void CalcMaxAngle(){} // RVA: 0x7FFD55271FA0
        public void CalcLimitRotation(){} // RVA: 0x7FFD552720F0
        public void CalcMaxStretch(){} // RVA: 0x7FFD552722E0
        public void CalcStretchMotion(){} // RVA: 0x7FFD55272390
        public void CalcMaxSquish(){} // RVA: 0x7FFD55272460
        public void CalcGravity(){} // RVA: 0x7FFD55272530
        public void CalcGravityFalloff(){} // RVA: 0x7FFD552725D0
        public void SafeEvaluate(){} // RVA: 0x7FFD552726A0
        public void OnShapeEnter(){} // RVA: 0x7FFD55272730
        public void OnShapeExit(){} // RVA: 0x7FFD55272AF0
        public void OnCollidersUpdated(){} // RVA: 0x7FFD55272BD0
        public void IsInteractionAllowed(){} // RVA: 0x7FFD55272BE0
        public void get_HasUdonEmitter(){} // RVA: 0x7FFD55272CB0
        public void get_IsGrabbed(){} // RVA: 0x7FFD53E1E710
        public void get_IsPosed(){} // RVA: 0x7FFD55272CC0
        public void get_Angle(){} // RVA: 0x7FFD55272CD0
        public void get_Stretch(){} // RVA: 0x7FFD4F54E510
        public void get_Squish(){} // RVA: 0x7FFD55272CE0
        public void GetIsGrabbed(){} // RVA: 0x7FFD53E1E710
        public void SetGrab(){} // RVA: 0x7FFD55272CF0
        public void SetIsPosed(){} // RVA: 0x7FFD55272FE0
        public void SetAngle(){} // RVA: 0x7FFD55273280
        public void SetStretch(){} // RVA: 0x7FFD552732F0
        public void SetSquish(){} // RVA: 0x7FFD55273360
        public void ApplyConfigurationChanges(){} // RVA: 0x7FFD552733D0
        public void ReleaseGrabs(){} // RVA: 0x7FFD552733E0
        public void ReleasePoses(){} // RVA: 0x7FFD55273470
        public void AssignUdonEmitter(){} // RVA: 0x7FFD4E76B310
        public void .ctor(){} // RVA: 0x7FFD55273560
        public void .cctor(){} // RVA: 0x7FFD552739B0
        public void <InitTransforms>g__GetTransforms|119_0(){} // RVA: 0x7FFD552739F0
    }

    public class VRCPhysBoneColliderBase : DynamicsComponent
    {
        public UnityEngine.Transform axis; // 0x28
        public 0x665C0AA8 isGlobalCollider; // 0x30
        public bool MaximumExecutionGroups; // 0x34
        public float ExecutionGroup; // 0x38
        public float SortingBaseTransform; // 0x3C
        public UnityEngine.Vector3 GlobalColliderFlags; // 0x40
        public UnityEngine.Quaternion rotation; // 0x4C
        public bool bonesAsSpheres; // 0x5C
        public 0x665BDAE0 globalCollisionFlags; // 0x60
        public bool _hasClientDefinedGlobalCollisionState; // 0x64
        public System.Func`2<UnityEngine.Component,int> getPlayerIdCallback; // 0x68
        public int playerId; // 0x70
        public Shape shape; // 0x78
        public VRC.Dynamics.ParentChangeDetector _parentChangeDetector; // 0x80
        public int <ExecutionGroup>k__BackingField; // 0x88
        public System.Action`1<VRC.Dynamics.VRCPhysBoneColliderBase> OnPreShapeInitialize;

        // ── Methods ──
        public void GetRootTransform(){} // RVA: 0x7FFD552743D0
        public void get_axis(){} // RVA: 0x7FFD552744F0
        public void get_isGlobalCollider(){} // RVA: 0x7FFD552746F0
        public void set_isGlobalCollider(){} // RVA: 0x7FFD55274700
        public void GetPlayerId(){} // RVA: 0x7FFD55274720
        public void get_MaximumExecutionGroups(){} // RVA: 0x7FFD55270210
        public void get_ExecutionGroup(){} // RVA: 0x7FFD4EC0E8C0
        public void set_ExecutionGroup(){} // RVA: 0x7FFD4EC19DE0
        public void get_SortingBaseTransform(){} // RVA: 0x7FFD55274740
        public void GetKnownDependencies(){} // RVA: 0x7FFD4E341310
        public void get_GlobalColliderFlags(){} // RVA: 0x7FFD55274750
        public void set_GlobalColliderFlags(){} // RVA: 0x7FFD55274830
        public void Awake(){} // RVA: 0x7FFD55274840
        public void OnEnable(){} // RVA: 0x7FFD552749E0
        public void OnDisable(){} // RVA: 0x7FFD55274A50
        public void OnDestroy(){} // RVA: 0x7FFD55274C40
        public void InitShape(){} // RVA: 0x7FFD55274D80
        public void UpdateShape(){} // RVA: 0x7FFD55275050
        public void GetBounds(){} // RVA: 0x7FFD55275250
        public void HandleParentChanged(){} // RVA: 0x7FFD55275920
        public void .ctor(){} // RVA: 0x7FFD55275AE0
    }

}