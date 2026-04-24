// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics
// Classes: 51
// Methods: 658

namespace VRC.Dynamics
{
    public class AbstractVRCConstraintBinding`2 : Object
    {
        public T1717704240 ApplicationUnityConstraint;
        public T1717704256 ApplicationVrcConstraint;
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
        public stfix boolVal; // 0x10
        public int intVal; // 0x18
        public lution floatVal; // 0x1C
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
        public ÍÏÎÎÌÍÍ.arker A;
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
        public ÍÏÎÎÌÍÍ.tails <scene>k__BackingField; // 0x10
        public ÍÎÏÎÎ.ateUpdateEvent<lutionZ,int> shapeMap; // 0x18
        public ÍÎÏÎÎ.ateUpdateProfilerMarker<int> shapesToUpdate; // 0x28
        public ÍÎÏÎÎ.ÌÌ<int> collisions; // 0x30

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
        public ÍÏÎÎÌÍÍ.tails <scene>k__BackingField; // 0x10
        public ÍÎÏÎÎ.ateUpdateProfilerMarker<ushort> shapesToUpdate; // 0x18
        public ÍÎÏÎÎ.<OnInit>k__BackingField<?,bool> collisionPairs; // 0x20
        public ÍÎÏÎÎ.AssignProgramAndVariables<?> prevCollisionPairs; // 0x30
        public ÍÎÏÎÎ.les<lutionZ,int> gridMap; // 0x38
        public ÍÎÏÎÎ.AssignProgramAndVariables<onfigOptions> gridCells; // 0x40
        public ÍÎÏÎÎ.AssignProgramAndVariables<int> cellCache; // 0x48

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
        public ÍÏÎÎÌÍÍ.etric broadphase; // 0x10
        public URA.onsDepth<ushort> CastBuffer;
        public URA.woDigitYearMax<gSmoothFactor> deadShapes; // 0x18
        public int MAX_SHAPES_NONWORLD;
        public int MAX_SHAPES_WORLD;
        public int MAX_SHAPES;
        public int MAX_TRANSFORMS;
        public int MAX_COLLISION_EVENTS;
        public gSmoothFactor[] shapes; // 0x20
        public URA.onsDepth<gSmoothFactor> shapesToAdd; // 0x28
        public URA.onsDepth<gSmoothFactor> shapesToRemove; // 0x30
        public ÍÎÏÎÎ.AssignProgramAndVariables<ushort> activeShapes; // 0x38
        public ÍÎÏÎÎ.ÌÌ<?> shapeData; // 0x40
        public ushort totalActiveNonWorldShapes; // 0x50
        public ushort totalActiveWorldShapes; // 0x52
        public ÍÎÏÎÎ.ateUpdateProfilerMarker<oom> collisionEvents; // 0x58
        public ÍÏÎÎÌÍÍ.ntAssetCreationEditorSettings transforms; // 0x60
        public ÍÎÏÎÎ.ÌÌ<rdLeastSignificantDecimal> transformData; // 0x68
        public gAxis.andleSelfFittingAlongAxis jobHandle; // 0x78
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
        public n<ÍÏÎÎÌÍÍ.ation,bool> AffectedByAllowFlags;
        public object rootTransform; // 0x28
        public cationCallback shapeType; // 0x30
        public float radius; // 0x34
        public float height; // 0x38
        public amut position; // 0x3C
        public R_12x12 rotation; // 0x48
        public bool localOnly; // 0x58
        public ÍÏÎÎÌÍÍ.oipStateChangeCallback contentTypes; // 0x5C
        public URA.woDigitYearMax<string> collisionTags; // 0x60
        public ÍÏÎÎÌÍÍ.AC1449C527105 manager; // 0x68
        public bool allowInit; // 0x70
        public bool hasInitParams; // 0x71
        public bool hasInit; // 0x72
        public gSmoothFactor shape; // 0x78
        public n<led,int> getPlayerIdCallback; // 0x80
        public int playerId; // 0x88
        public bool pendingShapeUpdate; // 0x8C
        public nalInformation<int,int,bool> OnValidatePlayers; // 0x8

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
        public T1717704400 isValid;
        public ellSize.artCorner contactShapeId;

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
        public ÍÏÎÎÌÍÍ.9287EE6327F8A74D0617C5 contactSender; // 0x10
        public ÍÏÎÎÌÍÍ.5DD51EECC0A8037DAFB1A52F12E04CC696BF57AAC1449C527105 contactReceiver; // 0x18
        public amut enterVelocity; // 0x20
        public amut contactPoint; // 0x2C
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
        public ÍÏÎÎÌÍÍ.AC1449C527105 Inst;
        public ÍÏÎÎÌÍÍ.tails collision; // 0x20
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.ation> contacts; // 0x28
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.ation> updateList; // 0x30
        public object Marker_CollisionScene; // 0x8
        public object Marker_CopyShapeIds; // 0x10
        public object Marker_Trigger; // 0x18
        public float _timer; // 0x38
        public float FRAME_TIME;
        public float performanceTimeMs; // 0x3C
        public ernal_index_icall.mUri _stopwatch; // 0x40
        public ameHashCode _jobState; // 0x48
        public bool drawGizmos; // 0x4C
        public int MAX_COLLISION_RECORDS; // 0x20
        public int THREAD_BATCH_SIZE; // 0x24
        public ÍÎÏÎÎ.AssignProgramAndVariables<int> receivesToUpdate; // 0x50
        public ÍÎÏÎÎ.ÌÌ<ularStyleWeight> receiverData; // 0x58
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.set_tabMultiple> needsShapeID; // 0x68

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
        public popts receiverType; // 0x94
        public string parameter; // 0x98
        public float minVelocity; // 0xA0
        public int receiverId; // 0xA4
        public ÍÏÎÎÌÍÍ.ultiple _udonEmitter; // 0xA8
        public URA.woDigitYearMax<dStyleWeight> collisionRecords; // 0xB0
        public URA.woDigitYearMax<dStyleWeight> unvalidatedCollisionRecords; // 0xB8
        public float collisionValue; // 0xC0
        public URA.onsDepth<string> TagIntersectionSet;
        public bool hasTriggered; // 0xC4
        public float paramValue; // 0xC8
        public float restoreParamValue; // 0xCC
        public ellSize.te paramAccess; // 0xD0
        public URA.onsDepth<int> collisionTagsHash; // 0xD8

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
        public platMaterialPropertyBlock[] _udonBehaviours; // 0x10
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
        public ÍÏÎÎÌÍÍ.nCallback DefaultUsage;
        public ÍÏÎÎÌÍÍ.nCallback Usage; // 0x20

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
        public ÏÍÎÎÎÍÎÌÌÍÌÍÎÍÌÎÏÌÎÎÌ transformArray; // 0x10
        public ÍÎÏÎÎ.ÌÌ<int> lookupToId; // 0x18
        public ÍÎÏÎÎ.ÌÌ<int> lookupFromId; // 0x28
        public URA.woDigitYearMax<int> emptyQueue; // 0x38
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
        public ÍÎÏÎÎ.les<ÍÏÎÎÌÍÍ.arker,int> spanMap; // 0x18
        public ÍÎÏÎÎ.AssignProgramAndVariables<MarkAdjustmentRecords>b__27_0> spans; // 0x20
        public ÍÏÎÎÌÍÍ.rds>b__25_0 spanList; // 0x28
        public ÍÏÎÎÌÍÍ.entRecords>b__25_1 dataList; // 0x30

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
        public ÎÌÍÏÏÌÍÏ OnParentChanged; // 0x20

        // ── Methods ──
        public void add_OnParentChanged(){} // RVA: 0x7FFD5521EF50
        public void remove_OnParentChanged(){} // RVA: 0x7FFD5521F040
        public void Awake(){} // RVA: 0x7FFD5521F130
        public void OnTransformParentChanged(){} // RVA: 0x7FFD4E6232C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PhysBoneGrabbedInfo : ValueType
    {
        public ellSize.artCorner player; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    }

    public class PhysBoneGroup : Object
    {
        public int MIN_CHAINS_CAPACITY;
        public ÍÏÎÎÌÍÍ.lyphTable>b__37_0 manager; // 0x10
        public int groupIndex; // 0x18
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.arker> chainIds; // 0x20
        public ÍÎÏÎÎ.AssignProgramAndVariables<int> indexList; // 0x28
        public bool isListDirty; // 0x30
        public int MIN_SHAPES_CAPACITY;
        public ÍÎÏÎÎ.AssignProgramAndVariables<ushort> shapes; // 0x38

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
        public ÍÏÎÎÌÍÍ.lyphTable>b__37_0 Inst;
        public amut distanceCullOrigin; // 0x20
        public bool IsSDK; // 0x2C
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.VRC.Dynamics.dll> rootsToUpdate; // 0x30
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.T_CAPACITY> compsToAdd; // 0x38
        public URA.woDigitYearMax<DING> compsToRemove; // 0x40
        public float MAX_BOUNDS_SIZE;
        public float MIN_BONE_LENGTH;
        public float MIN_SIMULATE_BONE;
        public es.ap DebugLineAxis; // 0x8
        public bool DisableTiming; // 0x14
        public float DebugTimeElapsed; // 0x18
        public ÍÏÎÎÌÍÍ.teAtlasTexture DebugDraw; // 0x20
        public ÍÏÎÎÌÍÍ.eChunkExtension buffer; // 0x48
        public ÍÏÎÎÌÍÍ.tString chainBuffer; // 0x50
        public ÍÏÎÎÌÍÍ.rialManager boneBuffer; // 0x58
        public ÍÏÎÎÌÍÍ.entRecords>b__27_0 rootBuffer; // 0x60
        public ghtFromCharacterIndex editorInfo; // 0x68
        public ÍÎÏÎÎ.ÌÌ<Size> errorBuffer; // 0x90
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
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.ns> colliderComponents; // 0xA0
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.ns> collidersToAdd; // 0xA8
        public URA.woDigitYearMax<J> collidersToRemove; // 0xB0
        public float CUSTOM_EPSILON;
        public float QUATERNION_EPSILON;
        public float MATRIX_EPSILON;
        public bool hasInit; // 0xB8
        public object Marker_UpdateRoots; // 0x30
        public object Marker_AddRemoveChains; // 0x38
        public object Marker_AddRemoveColliders; // 0x40
        public object Marker_UpdateStaleGroups; // 0x48
        public object Marker_UpdateChains; // 0x50
        public object Marker_JobsTotal; // 0xC0
        public float FRAME_TIME;
        public float fixedTimeElapsed; // 0xC8
        public float realTimeElapsed; // 0xCC
        public bool hasReportedCriticalError; // 0x58
        public float fullFrameTimeElapsed; // 0xD0
        public bool executeShapeUpdates; // 0xD4
        public bool drawGizmos; // 0xD5
        public int MAX_EXECUTION_GROUPS;
        public int MAX_EXECUTION_GROUPS_NONWORLD;
        public ÍÏÎÎÌÍÍ.ials[] executionGroups; // 0xD8
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.T_CAPACITY> _staleGroupPhysBones; // 0xE0
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.ns> _staleGroupPhysBoneColliders; // 0xE8
        public URA.onsDepth<?> _staleGroupRoots; // 0xF0
        public URA.DateTime<ÍÏÎÎÌÍÍ.ions,int> _formerExecutionGroupBuffer; // 0xF8
        public URA.woDigitYearMax<gSpriteCharacterUnicode> sortingData; // 0x60
        public ÍÏÎÎÌÍÍ.tails collision; // 0x100
        public int MAX_COLLIDERS_PER_CHAIN;
        public URA.woDigitYearMax<?> grabs; // 0x108
        public float GRAB_RAY_LENGTH;
        public URA.woDigitYearMax<gSmoothFactor> GrabBuffer; // 0x110
        public URA.woDigitYearMax<?> poses; // 0x118

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
        public gCharactersLookup RootDefinition; // 0x20
        public ÍÏÎÎÌÍÍ.VRC.Dynamics.dll Timing; // 0x28

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
        public object <Transform>k__BackingField; // 0x20
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
        public platMaterialPropertyBlock[] _udonBehaviours; // 0x10
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
        public egister<rdLeastSignificantDecimal> transformDataBuffer; // 0x10

        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFD55222990
    }

    public class RootsBuffer : Object
    {
        public ÍÎÏÎÎ.AssignProgramAndVariables<tCursorPositionFromStringIndexUsingCharacterHeight> roots; // 0x10
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.VRC.Dynamics.dll> comps; // 0x18
        public ÏÍÎÎÎÍÎÌÌÍÌÍÎÍÌÎÏÌÎÎÌ rootTransformsArray; // 0x20
        public URA.woDigitYearMax<int> available; // 0x28

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
        public object ScaleMode; // 0x30
        public bool AffectsPosition; // 0x38
        public bool AffectsRotation; // 0x39
        public bool AffectsScale; // 0x3A
        public bool NativeIndex; // 0x3B
        public ÍÏÎÎÌÍÍ.e CachedExecutionGroupIndex; // 0x40
        public int LatestValidExecutionGroupIndex; // 0x2D8
        public int DependencyRoot; // 0x2DC
        public int DependsOnLocalAvatarProcessing; // 0x2E0
        public object IsPendingUnprocessed; // 0x2E8
        public bool _isRuntimeTargetTransformAssigned; // 0x2F0
        public object _cachedTargetTransform; // 0x2F8
        public bool _hasCachedTargetParentTransform; // 0x300
        public object _cachedTargetParentTransform; // 0x308
        public object _assignedDependencyRoot; // 0x310
        public bool _initialRegistrationComplete; // 0x318
        public int _cachedTransformCount; // 0x31C
        public ÍÏÎÎÌÍÍ.e _constraintBinding; // 0x320
        public bool _fullNativeUpdatePending; // 0x328
        public IsUnlocked _pendingReallocation; // 0x32C
        public stfix _containingAnimator; // 0x330
        public bool _hasContainingAnimator; // 0x338
        public bool _containingAnimatorLatestActiveState; // 0x339
        public bool _isAttachedToClone; // 0x33A
        public ÍÏÎÎÌÍÍ.T_CAPACITY[] _monitoredPhysBones; // 0x340
        public ÍÏÎÎÌÍÍ.stHash _playerLoopStage; // 0x348
        public ssList _physBoneDependency; // 0x34C
        public bool _dependsOnLocalAvatarProcessing; // 0x350
        public URA.onsDepth<ileFullDirectoryInformation<ÍÏÎÎÌÍÍ.therInApplication>> _registeredBakeListeners; // 0x358
        public URA.DateTime<BuffersImpl,URA.woDigitYearMax<ÍÏÎÎÌÍÍ.therInApplication>> OrderInfoPerGameObject;
        public int _localGameObjectOrder; // 0x360
        public bool _isInLocalGameObjectOrder; // 0x364
        public bool <IsPendingUnprocessed>k__BackingField; // 0x365
        public URA.onsDepth<ÍÏÎÎÌÍÍ.therInApplication> _dependents; // 0x368
        public URA.onsDepth<ÍÏÎÎÌÍÍ.therInApplication> _rootNodes; // 0x8
        public mePatterns.mes _dependencyTraversalMarks; // 0x10
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
        public egister<int> MemberConstraintIndices; // 0x10

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
        public URA.ap<int,ÍÏÎÎÌÍÍ.efinitions> GroupsAreStale; // 0x10
        public URA.onsDepth<?> ExecutionGroups; // 0x18
        public bool _objectDisposed; // 0x20
        public URA.DateTime<int,URA.woDigitYearMax<ÍÏÎÎÌÍÍ.therInApplication>> _unprocessedConstraints; // 0x28
        public URA.onsDepth<int> RemovedGroupIndicesBuffer;
        public object _reorganizeGroupsProfilerMarker; // 0x8

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
        public ÍÏÎÎÌÍÍ.stHash playerLoopStage; // 0x10
        public egister<int> targetConstraintIndices; // 0x18
        public egister<ÍÏÎÎÌÍÍ.TP_Get> constraints; // 0x30
        public egister<rdLeastSignificantDecimal> transformDataBuffer; // 0x48
        public es.ap Float3Right;
        public es.ap Float3Up; // 0xC
        public es.ap Float3Forward; // 0x18
        public es.ap Float3One; // 0x24
        public es.eout QuaternionZero; // 0x30

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
        public ÍÏÎÎÌÍÍ.eamingStartResult PositionConstraintMode; // 0x14
        public ÍÏÎÎÌÍÍ.CommentsVisible RotationConstraintMode; // 0x18
        public ÍÏÎÎÌÍÍ.abled ScaleConstraintMode; // 0x1C
        public bool HasParentTransform; // 0x20
        public bool IsActive; // 0x21
        public float GlobalWeight; // 0x24
        public bool SolveInLocalSpace; // 0x28
        public bool FreezeToWorld; // 0x29
        public bool FreezeToWorldHasTrs; // 0x2A
        public es.ap FrozenWorldPosition; // 0x2C
        public es.eout FrozenWorldRotation; // 0x38
        public es.ap FrozenWorldScale; // 0x48
        public ÍÏÎÎÌÍÍ.stHash PlayerLoopStage; // 0x54
        public bool AttachedToAvatarClone; // 0x58
        public bool Locked; // 0x59
        public _SetVoipStreamMode PositionConfig; // 0x5C
        public _SetVoipStreamMode RotationConfig; // 0x78
        public _SetVoipStreamMode ScaleConfig; // 0x94
        public es.ap AimAxis; // 0xB0
        public es.ap UpAxis; // 0xBC
        public bool UseUpTransform; // 0xC8
        public float Roll; // 0xCC
        public VoipAttenuation WorldUpType; // 0xD0
        public es.ap WorldUpVector; // 0xD4
        public int WorldUpTransformIndex; // 0xE0
        public float TotalValidSourceWeight; // 0xE4
        public es.ap OriginalLocalEulersHint; // 0xE8
        public bool HasOriginalLocalEulersHint; // 0xF4
        public egister<Sync_SetVoipMicSource> Sources; // 0xF8
    }

    public class VRCConstraintManager : Object
    {
        public int IsInitialized;
        public int CanExecuteConstraintJobsInEditMode;
        public bool _instanceInitialized;
        public bool _canExecuteConstraintJobsInEditMode; // 0x1
        public bool _isEditor; // 0x2
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.therInApplication> _constraintsManaged; // 0x8
        public URA.onsDepth<ÍÏÎÎÌÍÍ.therInApplication> _constraintsManagedSet; // 0x10
        public egister<ÍÏÎÎÌÍÍ.TP_Get> _constraintsNative; // 0x18
        public ÏÍÎÎÎÍÎÌÌÍÌÍÎÍÌÎÏÌÎÎÌ _transformBuffer; // 0x30
        public ÏÍÎÎÎÍÎÌÌÍÌÍÎÍÌÎÏÌÎÎÌ _transformBufferOnlyTargets; // 0x38
        public egister<rdLeastSignificantDecimal> _transformDataBuffer; // 0x40
        public URA.woDigitYearMax<nt> _emptyTransformRanges; // 0x58
        public URA.woDigitYearMax<8BCA7B5CC287C51E0E3E<?,bool>> _constraintTransformsBuffer; // 0x60
        public object _updateConstraintsProfilerMarkerSync; // 0x68
        public object _updateConstraintsProfilerMarkerReAlloc; // 0x70
        public object _updateConstraintsProfilerMarkerJobData; // 0x78
        public ÍÏÎÎÌÍÍ.eById _constraintGrouper; // 0x80
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.therInApplication> UpdatedConstraintsBuffer; // 0x88

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
        public object ShouldBakeAtRest; // 0x10
        public float ShouldBakeOffsets; // 0x18
        public onId _bakeOptions; // 0x1C

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
        public object SourceTransform; // 0x10
        public float Weight; // 0x18
        public amut ParentPositionOffset; // 0x1C
        public amut ParentRotationOffset; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5523C7E0 | overloaded x2
        public void CreateDefault(){} // RVA: 0x7FFD5523C860
    }

    public class VRCConstraintSourceKeyableList : ValueType
    {
        public int Count;
        public ÍÏÎÎÌÍÍ.killLevel OverflowList; // 0x10
        public ÍÏÎÎÌÍÍ.killLevel ValueEnumerator; // 0x38
        public ÍÏÎÎÌÍÍ.killLevel IsReadOnly; // 0x60
        public ÍÏÎÎÌÍÍ.killLevel IsFixedSize; // 0x88
        public ÍÏÎÎÌÍÍ.killLevel System.Collections.ICollection.IsSynchronized; // 0xB0
        public ÍÏÎÎÌÍÍ.killLevel System.Collections.ICollection.SyncRoot; // 0xD8
        public ÍÏÎÎÌÍÍ.killLevel System.Collections.IList.Item; // 0x100
        public ÍÏÎÎÌÍÍ.killLevel Item; // 0x128
        public ÍÏÎÎÌÍÍ.killLevel source8; // 0x150
        public ÍÏÎÎÌÍÍ.killLevel source9; // 0x178
        public ÍÏÎÎÌÍÍ.killLevel source10; // 0x1A0
        public ÍÏÎÎÌÍÍ.killLevel source11; // 0x1C8
        public ÍÏÎÎÌÍÍ.killLevel source12; // 0x1F0
        public ÍÏÎÎÌÍÍ.killLevel source13; // 0x218
        public ÍÏÎÎÌÍÍ.killLevel source14; // 0x240
        public ÍÏÎÎÌÍÍ.killLevel source15; // 0x268
        public int totalLength; // 0x290
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.killLevel> overflowList; // 0x298
        public URA.saAbbrevEnglishEraNames<ÍÏÎÎÌÍÍ.killLevel> _valueEnumerator; // 0x2A0

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
        public URA.woDigitYearMax<eObjectDelegate.ingField> ÌÌÌÌÎÌÌÍÌÏÍÎÏÏÍÍÍÎÏÍÍÍÌ;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4EEC9630
        public void Equals(){} // RVA: 0x7FFD4EEC9780
        public void GetHashCode(){} // RVA: 0x7FFD4EEC9870
    }

    public class VRCDynamicsScheduler : Object
    {
        public gAxis.andleSelfFittingAlongAxis _currentDynamicsJobHandle;
        public ÎÌÍÏÏÌÍÏ OnFrameComplete; // 0x10
        public ÎÌÍÏÏÌÍÏ OnFrameCompleteLate; // 0x18
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
        public object version; // 0x30
        public object LatestVersion;
        public object integrationType; // 0x34
        public object rootTransform; // 0x38
        public URA.woDigitYearMax<?> ignoreTransforms; // 0x40
        public bool ignoreOtherPhysBones; // 0x48
        public amut endpointPosition; // 0x4C
        public object multiChildType; // 0x58
        public float pull; // 0x5C
        public ÍÎÌÍÍÌÌÎÏÏ pullCurve; // 0x60
        public float spring; // 0x68
        public ÍÎÌÍÍÌÌÎÏÏ springCurve; // 0x70
        public float stiffness; // 0x78
        public ÍÎÌÍÍÌÌÎÏÏ stiffnessCurve; // 0x80
        public float gravity; // 0x88
        public ÍÎÌÍÍÌÌÎÏÏ gravityCurve; // 0x90
        public float gravityFalloff; // 0x98
        public ÍÎÌÍÍÌÌÎÏÏ gravityFalloffCurve; // 0xA0
        public omponent immobileType; // 0xA8
        public float immobile; // 0xAC
        public ÍÎÌÍÍÌÌÎÏÏ immobileCurve; // 0xB0
        public Sphere_Capsule allowCollision; // 0xB8
        public e collisionFilter; // 0xBC
        public float radius; // 0xC4
        public ÍÎÌÍÍÌÌÎÏÏ radiusCurve; // 0xC8
        public URA.woDigitYearMax<ÍÏÎÎÌÍÍ.ns> colliders; // 0xD0
        public _ElementInitializerMethodStatic limitType; // 0xD8
        public float maxAngleX; // 0xDC
        public ÍÎÌÍÍÌÌÎÏÏ maxAngleXCurve; // 0xE0
        public float maxAngleZ; // 0xE8
        public ÍÎÌÍÍÌÌÎÏÏ maxAngleZCurve; // 0xF0
        public amut limitRotation; // 0xF8
        public ÍÎÌÍÍÌÌÎÏÏ limitRotationXCurve; // 0x108
        public ÍÎÌÍÍÌÌÎÏÏ limitRotationYCurve; // 0x110
        public ÍÎÌÍÍÌÌÎÏÏ limitRotationZCurve; // 0x118
        public amut staticFreezeAxis; // 0x120
        public Sphere_Capsule allowGrabbing; // 0x12C
        public e grabFilter; // 0x130
        public Sphere_Capsule allowPosing; // 0x138
        public e poseFilter; // 0x13C
        public bool snapToHand; // 0x144
        public float grabMovement; // 0x148
        public float maxStretch; // 0x14C
        public ÍÎÌÍÍÌÌÎÏÏ maxStretchCurve; // 0x150
        public float maxSquish; // 0x158
        public ÍÎÌÍÍÌÌÎÏÏ maxSquishCurve; // 0x160
        public float stretchMotion; // 0x168
        public ÍÎÌÍÍÌÌÎÏÏ stretchMotionCurve; // 0x170
        public bool isAnimated; // 0x178
        public bool resetWhenDisabled; // 0x179
        public string parameter; // 0x180
        public bool showGizmos; // 0x188
        public float boneOpacity; // 0x18C
        public float limitOpacity; // 0x190
        public bool configHasUpdated; // 0x194
        public URA.woDigitYearMax<radius> bones; // 0x198
        public int maxBoneChainIndex; // 0x1A0
        public ÍÏÎÎÌÍÍ.arker chainId; // 0x1A8
        public ÎÌÍÏÏÌÍÏ OnNeedsNetworkSync; // 0x1B8
        public n<led,int> getPlayerIdCallback; // 0x1C0
        public int playerId; // 0x1C8
        public int netId; // 0x1CC
        public int netSubId; // 0x1D0
        public bool collidersHaveUpdated; // 0x1D4
        public object worldImmobileTransform; // 0x1D8
        public object grab; // 0x1E0
        public ÍÏÎÎÌÍÍ.VRC.Dynamics.dll root; // 0x1E8
        public ÍÏÎÎÌÍÍ.ck _parentChangeDetector; // 0x1F0
        public int <ExecutionGroup>k__BackingField; // 0x1F8
        public ÎÌÍÏÏÌÍÏ OnPoseUpdated; // 0x200
        public ileFullDirectoryInformation<ÍÏÎÎÌÍÍ.T_CAPACITY> OnInitialize; // 0x8
        public bool hasInitParams; // 0x208
        public bool hasInitTransform; // 0x209
        public nalInformation<int,int,bool> OnVerifyCollision; // 0x10
        public gSmoothFactor shape; // 0x210
        public URA.woDigitYearMax<dStyleWeight> collisionRecords; // 0x218
        public bool param_IsGrabbedValue; // 0x220
        public bool param_IsPosedValue; // 0x221
        public float param_AngleValue; // 0x224
        public float param_StretchValue; // 0x228
        public float param_SquishValue; // 0x22C
        public ellSize.te param_IsGrabbed; // 0x230
        public ellSize.te param_IsPosed; // 0x238
        public ellSize.te param_Angle; // 0x240
        public ellSize.te param_Stretch; // 0x248
        public ellSize.te param_Squish; // 0x250
        public ÍÏÎÎÌÍÍ.es _udonEmitter; // 0x258
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
        public object axis; // 0x28
        public cationCallback isGlobalCollider; // 0x30
        public bool MaximumExecutionGroups; // 0x34
        public float ExecutionGroup; // 0x38
        public float SortingBaseTransform; // 0x3C
        public amut GlobalColliderFlags; // 0x40
        public R_12x12 rotation; // 0x4C
        public bool bonesAsSpheres; // 0x5C
        public ÍÏÎÎÌÍÍ.oipStateChangeCallback globalCollisionFlags; // 0x60
        public bool _hasClientDefinedGlobalCollisionState; // 0x64
        public n<led,int> getPlayerIdCallback; // 0x68
        public int playerId; // 0x70
        public gSmoothFactor shape; // 0x78
        public ÍÏÎÎÌÍÍ.ck _parentChangeDetector; // 0x80
        public int <ExecutionGroup>k__BackingField; // 0x88
        public ileFullDirectoryInformation<ÍÏÎÎÌÍÍ.ns> OnPreShapeInitialize;

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