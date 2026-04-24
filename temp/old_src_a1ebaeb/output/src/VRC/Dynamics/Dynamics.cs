// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics
// Classes: 64
// Methods: 724

namespace VRC.Dynamics
{
    public class AbstractVRCConstraintBinding`2 : Object
    {
        public object _unityConstraintPendingReEnable; // 0x30CC1AB0

        // ── Original Methods ──
        public void get_ApplicationUnityConstraint(){} // RVA: 0x7ffaa86491d0
        public void get_ApplicationVrcConstraint(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void Synchronize(){} // RVA: 0x7ffaa864fe90
        public void SynchronizeInternal(){} // RVA: 0x7ffaa8649ca0
        public void RestoreUnityConstraintEnabledState(){} // RVA: 0x7ffaa8660cc0
        public void ChangeProperty(){} // RVA: 0x7ffaa864a690
        public void ChangeProperty(){} // RVA: 0x7ffaa864a690
        public void ChangeProperty(){} // RVA: 0x7ffaa864a690
        public void ChangeProperty(){} // RVA: 0x7ffaa864a690
        public void ChangeProperty(){} // RVA: 0x7ffaa864a690
        public void <Synchronize>g__PushResult|11_0(){} // RVA: 0x7ffaa86666b0
    }

    public class AnimParameterAccessAvatarSDK : Object
    {
        public object paramType; // 0x339DD620

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf842ef0
        public void get_boolVal(){} // RVA: 0x7ffaaf843180
        public void set_boolVal(){} // RVA: 0x7ffaaf843280
        public void get_intVal(){} // RVA: 0x7ffaaf843390
        public void set_intVal(){} // RVA: 0x7ffaaf843480
        public void get_floatVal(){} // RVA: 0x7ffaaf843590
        public void set_floatVal(){} // RVA: 0x7ffaaf843680
    }

    public class ChainId : ValueType
    {
        public object b; // 0x338EF620

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa264910
        public void Equals(){} // RVA: 0x7ffaaf84c670
        public void Equals(){} // RVA: 0x7ffaaf84c670
        public void op_Equality(){} // RVA: 0x7ffaaa264940
        public void op_Inequality(){} // RVA: 0x7ffaaa264960
        public void ToString(){} // RVA: 0x7ffaaf84c970
        public void get_A(){} // RVA: 0x7ffaa950bda0
        public void get_B(){} // RVA: 0x7ffaa9e47540
        public void .cctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf84c790
    }

    public class CollisionBroadphase_HashGrid : Object
    {
        public object GRID_MULTI; // 0x334ACA00
        public object MAX_SHAPE_UPDATE; // 0x334ACA00
        public object shapeMap; // 0x334ACA00
        public object 00; // 0x351132A0

        // ── Original Methods ──
        public void get_scene(){} // RVA: 0x7ffaa894d380
        public void set_scene(){} // RVA: 0x7ffaa8933e30
        public void AddShape(){} // RVA: 0x7ffaaf812ca0
        public void RemoveShape(){} // RVA: 0x7ffaaf812cf0
        public void CastShape(){} // RVA: 0x7ffaa8932310
        public void DrawGizmos(){} // RVA: 0x7ffaa8932310
        public void ScheduleJobs(){} // RVA: 0x7ffaaf812f20
        public void OnComplete(){} // RVA: 0x7ffaa8932310
        public void Dispose(){} // RVA: 0x7ffaaf8136a0
        public void .ctor(){} // RVA: 0x7ffaaf813730
        public void .cctor(){} // RVA: 0x7ffaaf8138e0
    }

    public class CollisionBroadphase_HybridSAP : Object
    {
        public object GRID_SIZE; // 0x339FCD30
        public object GRID_CELL_MAX_CACHE; // 0x339FCD30
        public object INITIAL_COLLISIONS_PER_CELL; // 0x339FCD30
        public object shapesToUpdate; // 0x339FCD30
        public object gridMap; // 0x339FCD30
        public object 00; // 0x35119048

        // ── Original Methods ──
        public void get_scene(){} // RVA: 0x7ffaa894d380
        public void set_scene(){} // RVA: 0x7ffaa8933e30
        public void AddShape(){} // RVA: 0x7ffaa8932310
        public void RemoveShape(){} // RVA: 0x7ffaaf815830
        public void CastShape(){} // RVA: 0x7ffaaf816bf0
        public void ScheduleJobs(){} // RVA: 0x7ffaaf816000
        public void OnComplete(){} // RVA: 0x7ffaa8932310
        public void Dispose(){} // RVA: 0x7ffaaf8168d0
        public void CastShape(){} // RVA: 0x7ffaaf816bf0
        public void DrawGizmos(){} // RVA: 0x7ffaaf817080
        public void .ctor(){} // RVA: 0x7ffaaf8176e0
        public void .cctor(){} // RVA: 0x7ffaaf8178f0
    }

    public class CollisionScene : Object
    {
        public object deadShapes; // 0x3389E2E0
        public object MAX_SHAPES; // 0x3389E2E0
        public object shapes; // 0x3389E2E0
        public object activeShapes; // 0x3389E2E0
        public object totalActiveWorldShapes; // 0x3389E2E0
        public object transformData; // 0x3389E2E0
        public object 00; // 0x351048F8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf81aad0
        public void .ctor(){} // RVA: 0x7ffaaf81aad0
        public void AddShape(){} // RVA: 0x7ffaaf81b290
        public void RemoveShape(){} // RVA: 0x7ffaaf81b340
        public void UpdateShapeData(){} // RVA: 0x7ffaaf81b3e0
        public void ShapeCount(){} // RVA: 0x7ffaaf81b8b0
        public void CastSphere(){} // RVA: 0x7ffaaf81b900
        public void UpdateBounds(){} // RVA: 0x7ffaaf81bec0
        public void UpdateAndSchedule(){} // RVA: 0x7ffaaf81c090
        public void ScheduleReadTransforms(){} // RVA: 0x7ffaaf81c250
        public void ScheduleUpdateShapePositions(){} // RVA: 0x7ffaaf81c430
        public void Complete(){} // RVA: 0x7ffaaf81c6f0
        public void Dispose(){} // RVA: 0x7ffaaf81c8e0
        public void SyncShapesNow(){} // RVA: 0x7ffaaf81cb10
        public void RemoveShapes(){} // RVA: 0x7ffaaf81cb20
        public void AddShapes(){} // RVA: 0x7ffaaf81d320
        public void FindAvailableId(){} // RVA: 0x7ffaaf81da00
        public void DrawGizmos(){} // RVA: 0x7ffaaf81daa0
        public void .cctor(){} // RVA: 0x7ffaaf81db70
        // ── Binary Analysis Named ──
        public void SetBroadphase(){} // RVA: 0x7ffaaf81b170
        public void GetBroadphase(){} // RVA: 0x7ffaa894d380
        public void GetShapeData(){} // RVA: 0x7ffaaf81b810
        public void GetShapeData(){} // RVA: 0x7ffaaf81b810
    }

    public class ConstraintHasSingleLowWeightSource_000000B8$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaf82be20
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf82be20
        public void Invoke(){} // RVA: 0x7ffaaf82bee0
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf82bb70
        public void GetFunctionPointer(){} // RVA: 0x7ffaaf82bcb0
    }

    public class ConstraintHasSingleLowWeightSource_000000B8$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab68a640
        public void Invoke(){} // RVA: 0x7ffaa898dc60
        public void EndInvoke(){} // RVA: 0x7ffaa9511890
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf82bae0
    }

    public class ContactBase : DynamicsComponent
    {
        public object OnInitialize; // 0x333FC3D0
        public object radius; // 0x333FC3D0
        public object rotation; // 0x333FC3D0
        public object collisionTags; // 0x333FC3D0
        public object hasInitParams; // 0x333FC3D0
        public object getPlayerIdCallback; // 0x333FC3D0
        public object OnValidatePlayers; // 0x333FC3D0
        public object axis; // 0x1700002F
        public object IsLocalOnly; // 0x17000030
        public object AffectedByAllowFlags; // 0x17000031

        // ── Original Methods ──
        public void get_axis(){} // RVA: 0x7ffaaf8438c0
        public void get_IsLocalOnly(){} // RVA: 0x7ffaa8b6c110
        public void Start(){} // RVA: 0x7ffaaf843ac0
        public void OnEnable(){} // RVA: 0x7ffaaf843c30
        public void OnDisable(){} // RVA: 0x7ffaaf843cb0
        public void ValidateTagsList(){} // RVA: 0x7ffaaf843d30
        public void InitParameters(){} // RVA: 0x7ffaaf843e90
        public void Init(){} // RVA: 0x7ffaaf843f00
        public void IsReceiver(){} // RVA: 0x7ffaa864a040
        public void RequiresUpdate(){} // RVA: 0x7ffaaf844040
        public void get_AffectedByAllowFlags(){} // RVA: 0x7ffaaf844080
        public void UpdateContact(){} // RVA: 0x7ffaaf8440c0
        public void InitShape(){} // RVA: 0x7ffaaf844250
        public void UpdateShape(){} // RVA: 0x7ffaaf844500
        public void ApplyConfigurationChanges(){} // RVA: 0x7ffaaf8446a0
        public void UpdateContentTypes(){} // RVA: 0x7ffaa905bdd0
        public void UpdateCollisionTags(){} // RVA: 0x7ffaaf8446b0
        public void .ctor(){} // RVA: 0x7ffaaf8447d0
        // ── Binary Analysis Named ──
        public void GetRootTransform(){} // RVA: 0x7ffaaf8437a0
        public void GetPlayerId(){} // RVA: 0x7ffaaf844010
    }

    public class ContactBaseProxy`2 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void get_isValid(){} // RVA: 0x7ffaa864a040
        public void get_contactShapeId(){} // RVA: 0x7ffaa8649100
        public void get_player(){} // RVA: 0x7ffaa86491d0
        public void get_usage(){} // RVA: 0x7ffaa8649ca0
        public void get_position(){} // RVA: 0x7ffaa8648be0
        public void get_rotation(){} // RVA: 0x7ffaa8648be0
        public void get_scale(){} // RVA: 0x7ffaa8648be0
        public void Equals(){} // RVA: 0x7ffaa887e5c0
        public void Equals(){} // RVA: 0x7ffaa887e5c0
    }

    public class ContactEnterInfo : ValueType
    {
        public object _enterVelocity; // 0x332DB4C0, was: <enterVelocity>k__BackingField

        // ── Original Methods ──
        public void get_contactSender(){} // RVA: 0x7ffaa950bda0
        public void set_contactSender(){} // RVA: 0x7ffaa930eca0
        public void get_contactReceiver(){} // RVA: 0x7ffaa9e47540
        public void set_contactReceiver(){} // RVA: 0x7ffaa9e47560
        public void get_enterVelocity(){} // RVA: 0x7ffaa894f8d0
        public void set_enterVelocity(){} // RVA: 0x7ffaa894f8f0
        public void get_contactPoint(){} // RVA: 0x7ffaaf05a5a0
        public void set_contactPoint(){} // RVA: 0x7ffaaf05a5c0
        public void get_matchingTags(){} // RVA: 0x7ffaa8960130
        public void set_matchingTags(){} // RVA: 0x7ffaa8933e90
    }

    public class ContactManager : MonoBehaviour
    {
        public object contacts; // 0x33C7EBA0
        public object Marker_CopyShapeIds; // 0x33C7EBA0
        public object FRAME_TIME; // 0x33C7EBA0
        public object _jobState; // 0x33C7EBA0
        public object THREAD_BATCH_SIZE; // 0x33C7EBA0
        public object needsShapeID; // 0x33C7EBA0
        public object 00; // 0x350F5E80

        // ── Original Methods ──
        public void AddContact(){} // RVA: 0x7ffaaf844f80
        public void RemoveContact(){} // RVA: 0x7ffaaf845500
        public void CalcClosestPoint(){} // RVA: 0x7ffaaf8459d0
        public void CalcRelativeVelocity(){} // RVA: 0x7ffaaf8461c0
        public void Awake(){} // RVA: 0x7ffaaf846620
        public void OnDestroy(){} // RVA: 0x7ffaaf846a50
        public void LateUpdate(){} // RVA: 0x7ffaaf8470c0
        public void ScheduleUpdateReceiversJob(){} // RVA: 0x7ffaaf847150
        public void HandleDynamicsFrameComplete(){} // RVA: 0x7ffaaf8478f0
        public void OnDrawGizmos(){} // RVA: 0x7ffaaf847b30
        public void FindAvailableId(){} // RVA: 0x7ffaaf847b60
        public void .ctor(){} // RVA: 0x7ffaaf847bf0
        public void .cctor(){} // RVA: 0x7ffaaf847df0
        public void Initialize$UpdateReceiversFunctions_CalcProximity_000001C3$BurstDirectCall(){} // RVA: 0x7ffaaf847fc0
        // ── Binary Analysis Named ──
        public void GetContacts(){} // RVA: 0x7ffaaf845900
    }

    public class ContactReceiver : ContactBase
    {
        public object receiverType; // 0x333FC1B0
        public object receiverId; // 0x333FC1B0
        public object unvalidatedCollisionRecords; // 0x333FC1B0
        public object hasTriggered; // 0x333FC1B0
        public object paramAccess; // 0x333FC1B0
        public object animator; // 0x33A8E180
        public object _effectiveReceiverType; // 0x33A8E180, was: ÎÌÌÎÎÏÌÌÍÏÍÍÌÍÎÎÍÍÌÎÌÏÏ

        // ── Original Methods ──
        public void get_EffectiveReceiverType(){} // RVA: 0x7ffaaf8493a0
        public void IsReceiver(){} // RVA: 0x7ffaa8a17850
        public void Start(){} // RVA: 0x7ffaaf8493d0
        public void OnDisable(){} // RVA: 0x7ffaaf849790
        public void OnDisableInCollisionScene(){} // RVA: 0x7ffaaf849840
        public void OnReenableInCollisionScene(){} // RVA: 0x7ffaaf8498e0
        public void OnShapeEnter(){} // RVA: 0x7ffaaf849900
        public void OnShapeExit(){} // RVA: 0x7ffaaf849bf0
        public void AddCollision(){} // RVA: 0x7ffaaf849c00
        public void RemoveCollision(){} // RVA: 0x7ffaaf84a640
        public void RemoveFromManagerData(){} // RVA: 0x7ffaaf84a940
        public void BuildMatchingTagsArray(){} // RVA: 0x7ffaaf84ab80
        public void AttemptAddCollision(){} // RVA: 0x7ffaaf84af70
        public void ValidateCollider(){} // RVA: 0x7ffaaf84b1c0
        public void ValidateColliderPermissions(){} // RVA: 0x7ffaaf84b470
        public void IsColliding(){} // RVA: 0x7ffaaf84b620
        public void RequiresUpdate(){} // RVA: 0x7ffaaf84b670
        public void UpdateContact(){} // RVA: 0x7ffaaf84b6e0
        public void RefreshValidatedCollisions(){} // RVA: 0x7ffaaf84ba80
        public void UpdateParameter(){} // RVA: 0x7ffaaf84bb70
        public void AssignUdonEmitter(){} // RVA: 0x7ffaa8d71dc0
        public void CalculateProximity(){} // RVA: 0x7ffaaf84bd20
        public void CalculateProximity(){} // RVA: 0x7ffaaf84bd20
        public void UpdateCollisionTags(){} // RVA: 0x7ffaaf84be30
        public void InitCollisionTags(){} // RVA: 0x7ffaaf84bf60
        public void .ctor(){} // RVA: 0x7ffaaf84c2b0
        public void .cctor(){} // RVA: 0x7ffaaf84c4f0
        // ── Binary Analysis Named ──
        public void SetParameter(){} // RVA: 0x7ffaaf84bc00
        public void CheckForMask(){} // RVA: 0x7ffaaf84c0f0
    }

    public class ContactReceiverUdonEmitter : Object
    {
        public object EventOnContactExit; // 0x337DEAF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf8c5350
        public void OnContactEnter(){} // RVA: 0x7ffaaf8c5400
        public void OnContactExit(){} // RVA: 0x7ffaaf8c5740
    }

    public class ContactSender : ContactBase
    {
        // ── Original Methods ──
        public void IsReceiver(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaaf84c5d0
    }

    public class CorrectQuaternion_000000BA$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaf82cb90
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf82cb90
        public void Invoke(){} // RVA: 0x7ffaaf82cc50
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf82c8e0
        public void GetFunctionPointer(){} // RVA: 0x7ffaaf82ca20
    }

    public class CorrectQuaternion_000000BA$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab8f1290
        public void Invoke(){} // RVA: 0x7ffaa8a8e370
        public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf82c830
    }

    public class DynamicsComponent : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_DefaultUsage(){} // RVA: 0x7ffaaf821830
        public void set_DefaultUsage(){} // RVA: 0x7ffaaf821870
        public void get_Usage(){} // RVA: 0x7ffaaf8218b0
        public void set_Usage(){} // RVA: 0x7ffaa900aa90
        public void get_RawUsage(){} // RVA: 0x7ffaa8aeced0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class DynamicsSetup : Object
    {
        // ── Original Methods ──
        public void RuntimeInit(){} // RVA: 0x7ffaa94c8a10
        public void op_Implicit(){} // RVA: 0x7ffaa94c93b0
        // ── Binary Analysis Named ──
        public void DoGetPlayerId(){} // RVA: 0x7ffaa94c8be0
        public void SetActive_708(){} // RVA: 0x7ffaa94c8f80
    }

    public class DynamicsUsageFlagsExtensions : Object
    {
        // ── Original Methods ──
        public void Contains(){} // RVA: 0x7ffaaebbad30
        public void Contains(){} // RVA: 0x7ffaaebbad30
    }

    public class FixedTransformAccessArray : Object
    {
        public object lookupFromId; // 0x33AE41B0
        public object  ; // 0x36CDFB48

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf84ca40
        public void Add(){} // RVA: 0x7ffaaf84cc50
        public void Remove(){} // RVA: 0x7ffaaf84ce30
        public void ChangeId(){} // RVA: 0x7ffaaf84cf60
        public void FindTransform(){} // RVA: 0x7ffaaf84cf80
        public void Dispose(){} // RVA: 0x7ffaaf84cfb0
        // ── Binary Analysis Named ──
        public void GetLength(){} // RVA: 0x7ffaa89d3080
        public void GetTransformAccessArray(){} // RVA: 0x7ffaa894d380
        public void GetLookupToId(){} // RVA: 0x7ffaa8ffff10
        public void GetLookupFromId(){} // RVA: 0x7ffaa95ffd80
    }

    public class FromToRotation_000000BC$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaf82d200
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf82d200
        public void Invoke(){} // RVA: 0x7ffaaf82d2c0
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf82cf50
        public void GetFunctionPointer(){} // RVA: 0x7ffaaf82d090
    }

    public class FromToRotation_000000BC$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae390c40
        public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
        public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf82ce80
    }

    public class ICollisionBroadphase
    {
        // ── Original Methods ──
        public void get_scene(){} // RVA: 0x7ffaa86491d0
        public void set_scene(){} // RVA: 0x7ffaa8660d80
        public void AddShape(){}
        public void RemoveShape(){}
        public void CastShape(){}
        public void ScheduleJobs(){}
        public void OnComplete(){} // RVA: 0x7ffaa8660cc0
        public void DrawGizmos(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
    }

    public class IContactReceiverUdonEmitter
    {
        // ── Original Methods ──
        public void OnContactEnter(){}
        public void OnContactExit(){}
    }

    public class IParameterSetup
    {
        // ── Original Methods ──
        public void InitParameters(){} // RVA: 0x7ffaa8660cc0
    }

    public class IPhysBoneDebugDrawer
    {
        // ── Original Methods ──
        public void get_Alpha(){} // RVA: 0x7ffaa865dbc0
        public void set_Alpha(){} // RVA: 0x7ffaa866e7c0
        public void Line(){} // RVA: 0x7ffaa887e5c0
        public void Sphere(){} // RVA: 0x7ffaa887e5c0
    }

    public class IPhysBoneRoot
    {
        // ── Original Methods ──
        public void AddPhysBone(){} // RVA: 0x7ffaa8649280
        public void RemovePhysBone(){} // RVA: 0x7ffaa8649280
    }

    public class IPhysBoneUdonEmitter
    {
        // ── Original Methods ──
        public void OnPhysBoneGrabbed(){}
        public void OnPhysBoneReleased(){}
        public void OnPhysBonePosed(){}
        public void OnPhysBoneUnPosed(){}
    }

    public class IVRCConstraintBinding
    {
        // ── Original Methods ──
        public void get_ApplicationUnityConstraint(){} // RVA: 0x7ffaa86491d0
        public void get_ApplicationVrcConstraint(){} // RVA: 0x7ffaa86491d0
        public void Synchronize(){} // RVA: 0x7ffaa864fe90
        public void RestoreUnityConstraintEnabledState(){} // RVA: 0x7ffaa8660cc0
    }

    public class IsAnyAxisZero_000000B6$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaf82b1e0
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf82b1e0
        public void Invoke(){} // RVA: 0x7ffaaf82b2a0
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf82af30
        public void GetFunctionPointer(){} // RVA: 0x7ffaaf82b070
    }

    public class IsAnyAxisZero_000000B6$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab68a640
        public void Invoke(){} // RVA: 0x7ffaa898dc60
        public void EndInvoke(){} // RVA: 0x7ffaa9511890
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf82aea0
    }

    public class IsLowWeightSource_000000B9$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaf82c540
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf82c540
        public void Invoke(){} // RVA: 0x7ffaaf82c600
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf82c290
        public void GetFunctionPointer(){} // RVA: 0x7ffaaf82c3d0
    }

    public class IsLowWeightSource_000000B9$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf82c100
        public void Invoke(){} // RVA: 0x7ffaa8a8e370
        public void EndInvoke(){} // RVA: 0x7ffaa9511890
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf82c1e0
    }

    public class IsValidTrsMatrix_000000B7$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaf82b800
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf82b800
        public void Invoke(){} // RVA: 0x7ffaaf82b8c0
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf82b550
        public void GetFunctionPointer(){} // RVA: 0x7ffaaf82b690
    }

    public class IsValidTrsMatrix_000000B7$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab68a640
        public void Invoke(){} // RVA: 0x7ffaa898dc60
        public void EndInvoke(){} // RVA: 0x7ffaa9511890
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf82b4c0
    }

    public class MathUtil : Object
    {
        // ── Original Methods ──
        public void DistancePointToPlane(){} // RVA: 0x7ffaaf84d060
        public void ClosestPointOnPlane(){} // RVA: 0x7ffaaf84d0c0
        public void AngleBetweenTwoNormals(){} // RVA: 0x7ffaaf84d1f0
        public void AngleBetweenTwoNormals(){} // RVA: 0x7ffaaf84d1f0
        public void CartesianToPolar(){} // RVA: 0x7ffaaf84d550
        public void PolarToCartesian(){} // RVA: 0x7ffaaf84d6c0
        public void QuaternionToSwingTwist(){} // RVA: 0x7ffaaf84d850
        public void SwingTwistToQuaternion(){} // RVA: 0x7ffaaf84d940
        public void ClosestPointOnLineSegment_Ratio(){} // RVA: 0x7ffaaf84db40
        public void ClosestPointOnLineSegment(){} // RVA: 0x7ffaaf84dc10
        public void ClosestPointsBetweenLineSegments(){} // RVA: 0x7ffaaf84dd40
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class MemoryBuffer : Object
    {
        public object spans; // 0x33349150
        public object 00; // 0x36A728C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf84e0f0
        public void Dispose(){} // RVA: 0x7ffaaf84e290
        public void Clear(){} // RVA: 0x7ffaaf84e3a0
        public void ContainsId(){} // RVA: 0x7ffaaf84e490
        public void FindIndex(){} // RVA: 0x7ffaaf84e520
        public void Request(){} // RVA: 0x7ffaaf84e600
        public void Release(){} // RVA: 0x7ffaaf84e820
        public void Compact(){} // RVA: 0x7ffaaf84eac0
        public void PrintDebug(){} // RVA: 0x7ffaaf84eeb0
        // ── Binary Analysis Named ──
        public void GetFinalDataIndex(){} // RVA: 0x7ffaaf84f1e0
    }

    public class ParentChangeDetector : MonoBehaviour
    {
        // ── Original Methods ──
        public void add_OnParentChanged(){} // RVA: 0x7ffaaf821970
        public void remove_OnParentChanged(){} // RVA: 0x7ffaaf821a60
        public void Awake(){} // RVA: 0x7ffaaf821b50
        public void OnTransformParentChanged(){} // RVA: 0x7ffaa8c26ca0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PhysBoneGrabbedInfo : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa930eca0
    }

    public class PhysBoneGroup : Object
    {
        public object groupIndex; // 0x33C0D060
        public object isListDirty; // 0x33C0D060
        public object System.Collections.Generic; // 0x8185D4D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf851770
        public void Dispose(){} // RVA: 0x7ffaaf851960
        public void AddPhysBone(){} // RVA: 0x7ffaaf8519c0
        public void RemovePhysBone(){} // RVA: 0x7ffaaf851c00
        public void MarkDirty(){} // RVA: 0x7ffaa9c8b610
        public void AddShape(){} // RVA: 0x7ffaaf851fe0
        public void RemoveShape(){} // RVA: 0x7ffaaf852200
        // ── Binary Analysis Named ──
        public void GetChains(){} // RVA: 0x7ffaaf851d70
        public void GetShapes(){} // RVA: 0x7ffaa8bf45b0
    }

    public class PhysBoneManager : MonoBehaviour
    {
        public object IsSDK; // 0x33610030
        public object compsToRemove; // 0x33610030
        public object MIN_SIMULATE_BONE; // 0x33610030
        public object DebugTimeElapsed; // 0x33610030
        public object chainBuffer; // 0x33610030
        public object editorInfo; // 0x33610030
        public object MAX_TRANSFORMS_PER_CHAIN; // 0x33610030
        public object INITIAL_CAPACITY_CHAINS; // 0x33610030
        public object EXTRA_TRANSFORM_COUNT; // 0x33610030
        public object colliderComponents; // 0x33610030
        public object CUSTOM_EPSILON; // 0x33610030
        public object hasInit; // 0x33610030
        public object Marker_AddRemoveColliders; // 0x33610030
        public object Marker_JobsTotal; // 0x33610030
        public object realTimeElapsed; // 0x33610030
        public object executeShapeUpdates; // 0x33610030
        public object MAX_EXECUTION_GROUPS_NONWORLD; // 0x33610030
        public object _staleGroupPhysBoneColliders; // 0x33610030
        public object sortingData; // 0x33610030
        public object grabs; // 0x33610030
        public object poses; // 0x33610030
        public object chainCount; // 0x35134840
        public object boneCapacity; // 0x35134840
        public object bytesUsed; // 0x35134840
        public object `Ǐf; // 0x66A9C8C8
        public object Invoke; // 0xB3F6FFF0

        // ── Original Methods ──
        public void AddPhysBone(){} // RVA: 0x7ffaaf852320
        public void RemovePhysBone(){} // RVA: 0x7ffaaf8525c0
        public void HasPhysBone(){} // RVA: 0x7ffaaf8528c0
        public void FindPhysBone(){} // RVA: 0x7ffaaf852950
        public void MarkRootDirty(){} // RVA: 0x7ffaaf852a00
        public void UpdateStaleGroups(){} // RVA: 0x7ffaaf852ac0
        public void UpdateRoots(){} // RVA: 0x7ffaaf853530
        public void ReassignPhysBoneToRoot(){} // RVA: 0x7ffaaf853960
        public void RemoveChains(){} // RVA: 0x7ffaaf853c30
        public void AddChains(){} // RVA: 0x7ffaaf854280
        public void ApplyExtraTransforms(){} // RVA: 0x7ffaaf856a50
        public void AddCollider(){} // RVA: 0x7ffaaf856cf0
        public void RemoveCollider(){} // RVA: 0x7ffaaf856f00
        public void RemoveColliders(){} // RVA: 0x7ffaaf856fd0
        public void AddColliders(){} // RVA: 0x7ffaaf857250
        public void FindChainIndex(){} // RVA: 0x7ffaaf857920
        public void CalcLimitAxis(){} // RVA: 0x7ffaaf858110
        public void CalcLimitAxis(){} // RVA: 0x7ffaaf858110
        public void AlmostEquals(){} // RVA: 0x7ffaaf858790
        public void AlmostEquals(){} // RVA: 0x7ffaaf858790
        public void HasChanged(){} // RVA: 0x7ffaaf858890
        public void HasChanged(){} // RVA: 0x7ffaaf858890
        public void SafeInverse(){} // RVA: 0x7ffaaf8589b0
        public void Awake(){} // RVA: 0x7ffaaf858ac0
        public void OnDestroy(){} // RVA: 0x7ffaaf858c90
        public void Init(){} // RVA: 0x7ffaaf8590f0
        public void FixedUpdate(){} // RVA: 0x7ffaaf859af0
        public void LateUpdate(){} // RVA: 0x7ffaaf859b60
        public void UpdateChains(){} // RVA: 0x7ffaaf859c10
        public void ScheduleReadBoneJob(){} // RVA: 0x7ffaaf85a6d0
        public void ReportCriticalError(){} // RVA: 0x7ffaaf85a920
        public void DumpObject(){} // RVA: 0x7ffaaf85ad20
        public void ScheduleExecutionJob(){} // RVA: 0x7ffaaf85af70
        public void ScheduleUpdateRootsJob(){} // RVA: 0x7ffaaf85b210
        public void ScheduleExecutionGroupJob(){} // RVA: 0x7ffaaf85b570
        public void CalcBoneScale(){} // RVA: 0x7ffaaf2cabd0
        public void CompleteJob(){} // RVA: 0x7ffaaf85bb80
        public void PrintDebug(){} // RVA: 0x7ffaaf85c600
        public void PrintDebug(){} // RVA: 0x7ffaaf85c600
        public void OnDrawGizmos(){} // RVA: 0x7ffaaf85c910
        public void MarkExecutionGroupStale(){} // RVA: 0x7ffaaf85caa0
        public void MarkExecutionGroupStale(){} // RVA: 0x7ffaaf85caa0
        public void IsCyclicDependency(){} // RVA: 0x7ffaaf85cc00
        public void UpdateExecutionGroupsForComponent(){} // RVA: 0x7ffaaf85ce50
        public void UpdateExecutionGroupsForRoot(){} // RVA: 0x7ffaaf85d000
        public void UpdateExecutionGroupsForRoot(){} // RVA: 0x7ffaaf85d000
        public void UpdateExecutionGroups(){} // RVA: 0x7ffaaf85d100
        public void UpdateExecutionGroup(){} // RVA: 0x7ffaaf85e6c0
        public void RemoveFromExecutionGroup(){} // RVA: 0x7ffaaf85eb90
        public void AddToExecutionGroup(){} // RVA: 0x7ffaaf85ecf0
        public void MarkGroupListDirty(){} // RVA: 0x7ffaaf85ee40
        public void ClearRootTiming(){} // RVA: 0x7ffaaf85eec0
        public void InitCollision(){} // RVA: 0x7ffaaf85f070
        public void UpdateAndScheduleColliders(){} // RVA: 0x7ffaaf85f170
        public void UpdateCollidersForChain(){} // RVA: 0x7ffaaf85f250
        public void UpdateGrabs(){} // RVA: 0x7ffaaf85fba0
        public void InteractAllowed(){} // RVA: 0x7ffaaf85fee0
        public void AttemptGrab(){} // RVA: 0x7ffaaf861e90
        public void AttemptGrab(){} // RVA: 0x7ffaaf861e90
        public void AttemptGrab(){} // RVA: 0x7ffaaf861e90
        public void IsChainGrabbed(){} // RVA: 0x7ffaaf861f30
        public void ReleaseGrab(){} // RVA: 0x7ffaaf862a70
        public void AddGrab(){} // RVA: 0x7ffaaf862270
        public void ReleaseGrab(){} // RVA: 0x7ffaaf862a70
        public void CreatePose(){} // RVA: 0x7ffaaf863340
        public void FindOrCreatePose(){} // RVA: 0x7ffaaf8639c0
        public void RemovePoseForChain(){} // RVA: 0x7ffaaf863ac0
        public void RemovePose(){} // RVA: 0x7ffaaf863c40
        public void FindPose(){} // RVA: 0x7ffaaf8641d0
        public void .ctor(){} // RVA: 0x7ffaaf864310
        public void .cctor(){} // RVA: 0x7ffaaf864b00
        public void <IsCyclicDependency>g__RecusriveSearch|122_0(){} // RVA: 0x7ffaaf864eb0
        public void <UpdateExecutionGroups>g__FindSortingData|126_0(){} // RVA: 0x7ffaaf865060
        public void <UpdateExecutionGroups>g__FindParentDependency|126_1(){} // RVA: 0x7ffaaf8651c0
        // ── Binary Analysis Named ──
        public void GetOrCreateRoot(){} // RVA: 0x7ffaaf853730
        public void GetColliderComponents(){} // RVA: 0x7ffaa8f78170
        public void GetChains(){} // RVA: 0x7ffaaf857880
        public void GetChain(){} // RVA: 0x7ffaaf857a10
        public void GetChainComponent(){} // RVA: 0x7ffaaf857b10
        public void SetChain(){} // RVA: 0x7ffaaf857b90
        public void GetBone(){} // RVA: 0x7ffaaf857c90
        public void SetBone(){} // RVA: 0x7ffaaf857da0
        public void GetTransformData(){} // RVA: 0x7ffaaf857ea0
        public void GetExecutionGroup(){} // RVA: 0x7ffaaf85ee80
        public void GetGrabs(){} // RVA: 0x7ffaaf863290
    }

    public class PhysBoneRoot : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_RootDefinition(){} // RVA: 0x7ffaa8960130
        public void set_RootDefinition(){} // RVA: 0x7ffaa8933e90
        public void get_Timing(){} // RVA: 0x7ffaa8aeced0
        public void set_Timing(){} // RVA: 0x7ffaaf872150
        public void Awake(){} // RVA: 0x7ffaaf872220
        public void get_RequiredHideFlags(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PhysBoneRootDefinition : Object
    {
        public object bufferIndex; // 0x339B4AB0
        public object _autoEvaluateFixedTime; // 0x339B4AB0

        // ── Original Methods ──
        public void get_Transform(){} // RVA: 0x7ffaa89600c0
        public void get_AutoEvaluateFixedTime(){} // RVA: 0x7ffaa8b0edb0
        public void set_AutoEvaluateFixedTime(){} // RVA: 0x7ffaaf872290
        public void get_UseFixedTime(){} // RVA: 0x7ffaa92971f0
        public void set_UseFixedTime(){} // RVA: 0x7ffaaf872320
        public void .ctor(){} // RVA: 0x7ffaaf8723b0
    }

    public class PhysBoneUdonEmitter : Object
    {
        public object EventOnPhysBoneReleased; // 0x33538600

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf8c5a30
        public void OnPhysBoneGrabbed(){} // RVA: 0x7ffaaf8c5ae0
        public void OnPhysBoneReleased(){} // RVA: 0x7ffaaf8c5cf0
        public void OnPhysBonePosed(){} // RVA: 0x7ffaaf8c5f00
        public void OnPhysBoneUnPosed(){} // RVA: 0x7ffaaf8c6110
    }

    public class ReadTransformJob : ValueType
    {
        // ── Original Methods ──
        public void Execute(){} // RVA: 0x7ffaaf8253b0
    }

    public class RootsBuffer : Object
    {
        public object rootTransformsArray; // 0x339DEFE0
        public object oSMg;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf84f2c0
        public void Dispose(){} // RVA: 0x7ffaaf84f4c0
        public void AddBoneToRoot(){} // RVA: 0x7ffaaf84f530
        public void RemoveBoneFromRoot(){} // RVA: 0x7ffaaf84f550
        public void TryAddRoot(){} // RVA: 0x7ffaaf84f5e0
        public void TryRemoveRoot(){} // RVA: 0x7ffaaf84f930
        public void FindRoot(){} // RVA: 0x7ffaaf84fab0
    }

    public class TransformPoint_000000B4$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaf82a520
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf82a520
        public void Invoke(){} // RVA: 0x7ffaaf82a5e0
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf82a270
        public void GetFunctionPointer(){} // RVA: 0x7ffaaf82a3b0
    }

    public class TransformPoint_000000B4$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae390c40
        public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
        public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf82a1a0
    }

    public class TransformPoint_000000B5$BurstDirectCall : Object
    {
        // ── Original Methods ──
        public void Constructor(){} // RVA: 0x7ffaaf82aba0
        public void Initialize(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf82aba0
        public void Invoke(){} // RVA: 0x7ffaaf82ac60
        // ── Binary Analysis Named ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaf82a8f0
        public void GetFunctionPointer(){} // RVA: 0x7ffaaf82aa30
    }

    public class TransformPoint_000000B5$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae390c40
        public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
        public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaaf82a820
    }

    public class VRCConstraintBase : DynamicsComponent
    {
        public object TargetTransform; // 0x30CC2390
        public object RebakeOffsetsWhenUnfrozen; // 0x30CC2390
        public object _nativeIndex; // 0x30CC2390, was: <NativeIndex>k__BackingField
        public object _runtimeTargetTransform; // 0x30CC2390
        public object _hasCachedTargetParentTransform; // 0x30CC2390
        public object _initialRegistrationComplete; // 0x30CC2390
        public object _fullNativeUpdatePending; // 0x30CC2390
        public object _hasContainingAnimator; // 0x30CC2390
        public object _monitoredPhysBones; // 0x30CC2390
        public object _dependsOnLocalAvatarProcessing; // 0x30CC2390
        public object _localGameObjectOrder; // 0x30CC2390
        public object _dependents; // 0x30CC2390
        public object _dependencyTraversalMarksCounter; // 0x30CC2390
        public object MAX_TRAVERSAL_STEPS; // 0x30CC2390
        public object MAX_DEPENDENCY_DEPTH; // 0x30CC2390
        public object source1; // 0x336F4030
        public object source4; // 0x336F4030
        public object source7; // 0x336F4030
        public object source10; // 0x336F4030
        public object source13; // 0x336F4030
        public object totalLength; // 0x336F4030
        public object SourceTransform; // 0x33A155D0

        // ── Original Methods ──
        public void get_PositionMode(){} // RVA: 0x7ffaa8649ca0
        public void get_RotationMode(){} // RVA: 0x7ffaa8649ca0
        public void get_ScaleMode(){} // RVA: 0x7ffaa8649ca0
        public void get_AffectsPosition(){} // RVA: 0x7ffaaf82d500
        public void get_AffectsRotation(){} // RVA: 0x7ffaaf82d530
        public void get_AffectsScale(){} // RVA: 0x7ffaaf82d560
        public void IsLocalPostProcessIndependent(){} // RVA: 0x7ffaaf82d590
        public void get_NativeIndex(){} // RVA: 0x7ffaaf82d610
        public void set_NativeIndex(){} // RVA: 0x7ffaaf82d620
        public void get_CachedExecutionGroupIndex(){} // RVA: 0x7ffaaf178070
        public void get_LatestValidExecutionGroupIndex(){} // RVA: 0x7ffaaf82d630
        public void get_DependencyRoot(){} // RVA: 0x7ffaaf82d650
        public void get_DependsOnLocalAvatarProcessing(){} // RVA: 0x7ffaaf82d810
        public void set_DependsOnLocalAvatarProcessing(){} // RVA: 0x7ffaaf82d820
        public void ActivateConstraint(){} // RVA: 0x7ffaaf82d840
        public void ZeroConstraint(){} // RVA: 0x7ffaaf82d870
        public void ApplyZeroOffset(){} // RVA: 0x7ffaa8660cc0
        public void TryBakeCurrentOffsets(){} // RVA: 0x7ffaaf82d960
        public void TryBakeCurrentOffsetsRuntime(){} // RVA: 0x7ffaaf82da10
        public void AcceptOffsetBaker(){} // RVA: 0x7ffaa8660d80
        public void RegisterBakeListener(){} // RVA: 0x7ffaaf82dda0
        public void UnRegisterBakeListener(){} // RVA: 0x7ffaaf82de10
        public void AssignBinding(){} // RVA: 0x7ffaaf82de70
        public void AddToLocalGameObjectOrder(){} // RVA: 0x7ffaaf82e380
        public void RemoveFromLocalGameObjectOrder(){} // RVA: 0x7ffaaf82e960
        public void CalculateOrder(){} // RVA: 0x7ffaaf82ebb0
        public void IsDependentOnTransform(){} // RVA: 0x7ffaaf82eec0
        public void Awake(){} // RVA: 0x7ffaaf82f660
        public void Start(){} // RVA: 0x7ffaaf82f9f0
        public void OnEnable(){} // RVA: 0x7ffaaf82fa60
        public void OnDisable(){} // RVA: 0x7ffaaf82fb60
        public void OnDestroy(){} // RVA: 0x7ffaaf82fc30
        public void Dispose(){} // RVA: 0x7ffaaf82fc40
        public void RecalculateTransformCount(){} // RVA: 0x7ffaaf82fd70
        public void AllocateJobData(){} // RVA: 0x7ffaaf8302e0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaaf830700
        public void ShouldCheckForChangingTargetParent(){} // RVA: 0x7ffaaf830710
        public void RequiresReallocation(){} // RVA: 0x7ffaaf830770
        public void SynchronizeWithBinding(){} // RVA: 0x7ffaaf830cb0
        public void EstablishTargetTransform(){} // RVA: 0x7ffaaf830e60
        public void ReEvaluatePhysBoneOrder(){} // RVA: 0x7ffaaf831230
        public void GatherPotentiallyDependentPhysBones(){} // RVA: 0x7ffaaf8314c0
        public void DeterminePhysBoneDependency(){} // RVA: 0x7ffaaf831700
        public void EstablishPlayerLoopStage(){} // RVA: 0x7ffaaf831940
        public void AssignPlayerLoopStage(){} // RVA: 0x7ffaaf831b30
        public void InvalidatePlayerLoopStage(){} // RVA: 0x7ffaaf831cc0
        public void UpdateJobData(){} // RVA: 0x7ffaaf831cd0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7ffaa8660d80
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7ffaa8932310
        public void AffectsAnyAxis(){} // RVA: 0x7ffaa864a040
        public void PostUpdateJobData(){} // RVA: 0x7ffaaf832200
        public void CreateAxisBitfield(){} // RVA: 0x7ffaaf832260
        public void RequestFullNativeUpdate(){} // RVA: 0x7ffaaf830700
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaaf832350
        public void get_IsPendingUnprocessed(){} // RVA: 0x7ffaaf832610
        public void set_IsPendingUnprocessed(){} // RVA: 0x7ffaaf832620
        public void CalculateDependencies(){} // RVA: 0x7ffaaf832630
        public void TraverseDependencies(){} // RVA: 0x7ffaaf832930
        public void ReorganizeGroupsFastForRoot(){} // RVA: 0x7ffaaf832bf0
        public void ApplyConfigurationChanges(){} // RVA: 0x7ffaaf830700
        public void .ctor(){} // RVA: 0x7ffaaf8336a0
        public void .cctor(){} // RVA: 0x7ffaaf833860
        // ── Binary Analysis Named ──
        public void SetCachedExecutionGroupIndex(){} // RVA: 0x7ffaaf82d640
        public void GetBoundUnityConstraint(){} // RVA: 0x7ffaaf82e320
        public void GetEffectiveTargetTransform(){} // RVA: 0x7ffaaf82f020
        public void SetupAvatarConstraint(){} // RVA: 0x7ffaaf82f150
        public void SetupWorldConstraint(){} // RVA: 0x7ffaaf82f3e0
        public void SetupPropConstraint(){} // RVA: 0x7ffaaf82f520
        public void GetTransformCount(){} // RVA: 0x7ffaaf82fd20
        public void GetTransforms(){} // RVA: 0x7ffaaf82ff80
        public void GetManagedWorldUpTransform(){} // RVA: 0x7ffaa8f22da0
        public void CheckReallocation(){} // RVA: 0x7ffaaf830d40
        public void GetPerSourcePositionOffsets(){} // RVA: 0x7ffaaf832280
    }

    public class VRCConstraintGroup : Object
    {
        // ── Original Methods ──
        public void get_MemberCount(){} // RVA: 0x7ffaaf822cc0
        public void .ctor(){} // RVA: 0x7ffaaf822d00
        public void Dispose(){} // RVA: 0x7ffaaf822dc0
        public void AddConstraint(){} // RVA: 0x7ffaaf822e00
        public void RemoveConstraintSwapBack(){} // RVA: 0x7ffaaf823050
        public void RemoveConstraintAtSwapBack(){} // RVA: 0x7ffaaf823110
        public void UpdateNativeIndex(){} // RVA: 0x7ffaaf823150
        public void RemoveAtSwapBack(){} // RVA: 0x7ffaaf8232e0
    }

    public class VRCConstraintGrouper : Object
    {
        public object _objectDisposed; // 0x3363AE20
        public object _reorganizeGroupsProfilerMarker; // 0x3363AE20
        public object GroupsAreStale; // 0x1700000B
        public object ExecutionGroups; // 0x1700000C

        // ── Original Methods ──
        public void get_GroupsAreStale(){} // RVA: 0x7ffaaf823410
        public void get_ExecutionGroups(){} // RVA: 0x7ffaaf823490
        public void .ctor(){} // RVA: 0x7ffaaf823500
        public void Dispose(){} // RVA: 0x7ffaaf823700
        public void RecordConstraintToAdd(){} // RVA: 0x7ffaaf8239e0
        public void RecordConstraintToRemove(){} // RVA: 0x7ffaaf823ac0
        public void MarkRootStale(){} // RVA: 0x7ffaaf824210
        public void RefreshGroups(){} // RVA: 0x7ffaaf8243b0
        public void PrepareGroupsForReorganize(){} // RVA: 0x7ffaaf824ae0
        public void .cctor(){} // RVA: 0x7ffaaf825260
        // ── Binary Analysis Named ──
        public void GetConstraintListForRoot(){} // RVA: 0x7ffaaf824290
    }

    public class VRCConstraintJob : ValueType
    {
        public object constraints; // 0x33C0D490
        public object Float3Up; // 0x33C0D490
        public object QuaternionZero; // 0x33C0D490
        public object 00; // 0x350FD680

        // ── Original Methods ──
        public void Execute(){} // RVA: 0x7ffaaf825410
        public void ProcessSource(){} // RVA: 0x7ffaaf827190
        public void FinalizeLocalScaleResult(){} // RVA: 0x7ffaaf828220
        public void PerformAimAt(){} // RVA: 0x7ffaaf828590
        public void TransformPoint(){} // RVA: 0x7ffaaf829480
        public void TransformPoint(){} // RVA: 0x7ffaaf829480
        public void IsAnyAxisZero(){} // RVA: 0x7ffaaf8294f0
        public void IsValidTrsMatrix(){} // RVA: 0x7ffaaf829540
        public void ConstraintHasSingleLowWeightSource(){} // RVA: 0x7ffaaf829590
        public void IsLowWeightSource(){} // RVA: 0x7ffaaf8295e0
        public void CorrectQuaternion(){} // RVA: 0x7ffaaf829640
        public void FromToRotation(){} // RVA: 0x7ffaaf8296a0
        public void CalculateEulerZXY(){} // RVA: 0x7ffaaf829710
        public void .cctor(){} // RVA: 0x7ffaaf829930
        public void TransformPoint$BurstManaged(){} // RVA: 0x7ffaaf829a90
        public void TransformPoint$BurstManaged(){} // RVA: 0x7ffaaf829a90
        public void IsAnyAxisZero$BurstManaged(){} // RVA: 0x7ffaaf829b40
        public void IsValidTrsMatrix$BurstManaged(){} // RVA: 0x7ffaaf829b70
        public void ConstraintHasSingleLowWeightSource$BurstManaged(){} // RVA: 0x7ffaaf829bd0
        public void IsLowWeightSource$BurstManaged(){} // RVA: 0x7ffaaf829c90
        public void CorrectQuaternion$BurstManaged(){} // RVA: 0x7ffaaf829cc0
        public void FromToRotation$BurstManaged(){} // RVA: 0x7ffaaf829e20
        // ── Binary Analysis Named ──
        public void GetTransformLossyScale(){} // RVA: 0x7ffaaf81f7a0
    }

    public class VRCConstraintJobData : ValueType
    {
        public object RotationConstraintMode; // 0x3353B3C0
        public object IsActive; // 0x3353B3C0
        public object FreezeToWorld; // 0x3353B3C0
        public object FrozenWorldRotation; // 0x3353B3C0
        public object AttachedToAvatarClone; // 0x3353B3C0
        public object RotationConfig; // 0x3353B3C0
        public object UpAxis; // 0x3353B3C0
        public object WorldUpType; // 0x3353B3C0
        public object TotalValidSourceWeight; // 0x3353B3C0
        public object Sources; // 0x3353B3C0
        public object Axes; // 0x350E7E10
        public object 00; // 0x35100A20
    }

    public class VRCConstraintManager : Object
    {
        public object _instanceInitialized; // 0x3194A3B0
        public object _constraintsManaged; // 0x3194A3B0
        public object _transformBuffer; // 0x3194A3B0
        public object _emptyTransformRanges; // 0x3194A3B0
        public object _updateConstraintsProfilerMarkerReAlloc; // 0x3194A3B0
        public object UpdatedConstraintsBuffer; // 0x3194A3B0
        public object IsInitialized; // 0x1700001D
        public object CanExecuteConstraintJobsInEditMode; // 0x1700001E
        public object System.Collections.Generic; // 0xB40F3310
        public object  ;

        // ── Original Methods ──
        public void get_IsInitialized(){} // RVA: 0x7ffaaf837e80
        public void get_CanExecuteConstraintJobsInEditMode(){} // RVA: 0x7ffaaf837ee0
        public void Initialize(){} // RVA: 0x7ffaaf837f40
        public void HandleQuit(){} // RVA: 0x7ffaaf838720
        public void UnInitialize(){} // RVA: 0x7ffaaf838790
        public void RegisterConstraint(){} // RVA: 0x7ffaaf838b90
        public void UnregisterConstraint(){} // RVA: 0x7ffaaf8397b0
        public void ReRegisterConstraint(){} // RVA: 0x7ffaaf83aa40
        public void ReRegisterSameObjectConstraint(){} // RVA: 0x7ffaaf83aad0
        public void IsConstraintRegistered(){} // RVA: 0x7ffaaf83aba0
        public void UpdateConstraints(){} // RVA: 0x7ffaaf83b3a0
        public void ScheduleReadJob(){} // RVA: 0x7ffaaf83b970
        public void ScheduleExecutionJobs(){} // RVA: 0x7ffaaf83bb70
        public void PostUpdateConstraints(){} // RVA: 0x7ffaaf83c1e0
        public void TryCreateSubstituteConstraint(){} // RVA: 0x7ffaa887e5c0
        public void TryCreateSubstituteConstraint(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaaf83c460
        // ── Binary Analysis Named ──
        public void GetBufferedTransform(){} // RVA: 0x7ffaaf83ac50
        public void SetBufferedTransform(){} // RVA: 0x7ffaaf83ad00
        public void GetFinalTransformIndex(){} // RVA: 0x7ffaaf83afa0
    }

    public class VRCConstraintOffsetBaker : Object
    {
        public object _bakeOptions; // 0x333B38E0
        public object ShouldBakeAtRest; // 0x1700001F

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf83c750
        public void get_ShouldBakeAtRest(){} // RVA: 0x7ffaaeab6420
        public void get_ShouldBakeOffsets(){} // RVA: 0x7ffaaee952f0
        public void Bake(){} // RVA: 0x7ffaaf83cdd0
        public void Bake(){} // RVA: 0x7ffaaf83cdd0
        public void Bake(){} // RVA: 0x7ffaaf83cdd0
        public void Bake(){} // RVA: 0x7ffaaf83cdd0
        public void Bake(){} // RVA: 0x7ffaaf83cdd0
        public void CalculateBakedPositionOffset(){} // RVA: 0x7ffaaf83d870
        public void CalculateBakedRotationOffset(){} // RVA: 0x7ffaaf83e1c0
        public void CalculateBakedScaleOffset(){} // RVA: 0x7ffaaf83e950
        public void AsSignedEulers(){} // RVA: 0x7ffaaf83ef00
        public void <AsSignedEulers>g__TreatEuler|16_0(){} // RVA: 0x7ffaaf83eff0
    }

    public class VRCConstraintSource : ValueType
    {
        public object ParentPositionOffset; // 0x33A155D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf83f200
        public void .ctor(){} // RVA: 0x7ffaaf83f200
        public void CreateDefault(){} // RVA: 0x7ffaaf83f280
    }

    public class VRCConstraintSourceKeyableList : ValueType
    {
        public object source1; // 0x336F4030
        public object source4; // 0x336F4030
        public object source7; // 0x336F4030
        public object source10; // 0x336F4030
        public object source13; // 0x336F4030
        public object totalLength; // 0x336F4030
        public object SourceTransform; // 0x33A155D0
        public object ParentRotationOffset; // 0x33A155D0
        public object Capacity; // 0x170008CD
        public object Count; // 0x170008CE
        public object System.Collections.IList.IsFixedSize; // 0x170008CF
        public object System.Collections.Generic.ICollection<T>.IsReadOnly; // 0x170008D0

        // ── Original Methods ──
        public void get_Count(){} // RVA: 0x7ffaaf83f390
        public void get_OverflowList(){} // RVA: 0x7ffaaf83f3a0
        public void get_ValueEnumerator(){} // RVA: 0x7ffaaf83f470
        public void .ctor(){} // RVA: 0x7ffaaf83fa20
        public void .ctor(){} // RVA: 0x7ffaaf83fa20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaf841820
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaaf841830
        public void Add(){} // RVA: 0x7ffaaf8418e0
        public void Clear(){} // RVA: 0x7ffaaf841930
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaaf8419b0
        public void IndexOf(){} // RVA: 0x7ffaaf841a50
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaaf841b80
        public void Contains(){} // RVA: 0x7ffaaf841c50
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaaf841d80
        public void CopyTo(){} // RVA: 0x7ffaaf841f80
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaaf842190
        public void Remove(){} // RVA: 0x7ffaaf842230
        public void RemoveAt(){} // RVA: 0x7ffaaf842370
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaaf842550
        public void Insert(){} // RVA: 0x7ffaaf8425f0
        public void get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8a17850
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaaf842ab0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaaf842b00
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaaf842b80
        public void get_Item(){} // RVA: 0x7ffaaf842c20
        public void set_Item(){} // RVA: 0x7ffaaf842c60
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaaf840ee0
        public void Set(){} // RVA: 0x7ffaaf8411e0
        public void GetEnumerator(){} // RVA: 0x7ffaaf841820
        public void SetLength(){} // RVA: 0x7ffaaf842740
    }

    public class VRCDynamicsLoop : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa94d4d70
        // ── Binary Analysis Named ──
        public void DoInverseTransformPoint_Injected_7FD(){} // RVA: 0x7ffaa94d4ec0
        public void DoTrySignalCompletion(){} // RVA: 0x7ffaa94d4fb0
    }

    public class VRCDynamicsScheduler : Object
    {
        public object OnFrameCompleteLate; // 0x3397C3E0

        // ── Original Methods ──
        public void add_OnFrameComplete(){} // RVA: 0x7ffaaf821bb0
        public void remove_OnFrameComplete(){} // RVA: 0x7ffaaf821d00
        public void add_OnFrameCompleteLate(){} // RVA: 0x7ffaaf821e50
        public void remove_OnFrameCompleteLate(){} // RVA: 0x7ffaaf821fa0
        public void Initialize(){} // RVA: 0x7ffaaf8220f0
        public void UpdateConstraints(){} // RVA: 0x7ffaaf822250
        public void PreScheduleDynamics(){} // RVA: 0x7ffaaf8222e0
        public void PostScheduleDynamics(){} // RVA: 0x7ffaaf8226a0
        public void CompleteDynamicsFrame(){} // RVA: 0x7ffaaf822810
        public void OnCameraPreCull(){} // RVA: 0x7ffaaf8229b0
        public void FinalizeJob(){} // RVA: 0x7ffaaf822a00
        public void SignalFrameComplete(){} // RVA: 0x7ffaaf822ad0
        public void HandleEditorPlayModeToggle(){} // RVA: 0x7ffaaf822c00
        public void .cctor(){} // RVA: 0x7ffaaf822c60
    }

    public class VRCPhysBoneBase : DynamicsComponent
    {
        public object foldout_collision; // 0x3366C6E0
        public object foldout_grabpose; // 0x3366C6E0
        public object PARAM_ISGRABBED; // 0x3366C6E0
        public object PARAM_STRETCH; // 0x3366C6E0
        public object LatestVersion; // 0x3366C6E0
        public object ignoreTransforms; // 0x3366C6E0
        public object multiChildType; // 0x3366C6E0
        public object spring; // 0x3366C6E0
        public object stiffnessCurve; // 0x3366C6E0
        public object gravityFalloff; // 0x3366C6E0
        public object immobile; // 0x3366C6E0
        public object collisionFilter; // 0x3366C6E0
        public object colliders; // 0x3366C6E0
        public object maxAngleXCurve; // 0x3366C6E0
        public object limitRotation; // 0x3366C6E0
        public object limitRotationZCurve; // 0x3366C6E0
        public object grabFilter; // 0x3366C6E0
        public object snapToHand; // 0x3366C6E0
        public object maxStretchCurve; // 0x3366C6E0
        public object stretchMotion; // 0x3366C6E0
        public object resetWhenDisabled; // 0x3366C6E0
        public object boneOpacity; // 0x3366C6E0
        public object bones; // 0x3366C6E0
        public object OnNeedsNetworkSync; // 0x3366C6E0
        public object netId; // 0x3366C6E0
        public object worldImmobileTransform; // 0x3366C6E0
        public object _parentChangeDetector; // 0x3366C6E0
        public object OnInitialize; // 0x3366C6E0
        public object OnVerifyCollision; // 0x3366C6E0
        public object param_IsGrabbedValue; // 0x3366C6E0
        public object param_StretchValue; // 0x3366C6E0
        public object param_IsPosed; // 0x3366C6E0
        public object param_Squish; // 0x3366C6E0
        public object allowSelf; // 0x81C2CDE0
        public object `Ǐf; // 0x81CA1C08

        // ── Original Methods ──
        public void IsCollisionAllowed(){} // RVA: 0x7ffaaf872540
        public void IsGrabAllowed(){} // RVA: 0x7ffaaf8725d0
        public void IsPoseAllowed(){} // RVA: 0x7ffaaf8726b0
        public void BuildChainId(){} // RVA: 0x7ffaaf8727a0
        public void GenerateArbitraryChainId(){} // RVA: 0x7ffaaf8728c0
        public void get_SortingBaseTransform(){} // RVA: 0x7ffaaf8729f0
        public void get_MaximumExecutionGroups(){} // RVA: 0x7ffaaf872c30
        public void get_ExecutionGroup(){} // RVA: 0x7ffaaf872c60
        public void set_ExecutionGroup(){} // RVA: 0x7ffaaf872c70
        public void HandleTransformParentChanged(){} // RVA: 0x7ffaaf872c80
        public void ReEstablishPhysBoneRoot(){} // RVA: 0x7ffaaf872e50
        public void Reset(){} // RVA: 0x7ffaaf8732b0
        public void Awake(){} // RVA: 0x7ffaaf873310
        public void Start(){} // RVA: 0x7ffaaf8734b0
        public void OnEnable(){} // RVA: 0x7ffaaf8736a0
        public void OnDisable(){} // RVA: 0x7ffaaf8737a0
        public void OnDestroy(){} // RVA: 0x7ffaaf8738c0
        public void InitParameters(){} // RVA: 0x7ffaaf873a00
        public void InitColliders(){} // RVA: 0x7ffaaf873a90
        public void InitTransforms(){} // RVA: 0x7ffaaf873d70
        public void ResetTransformsToRestPosition(){} // RVA: 0x7ffaaf874100
        public void CalcBoneRatio(){} // RVA: 0x7ffaaf874420
        public void CalcTransformRatio(){} // RVA: 0x7ffaaf874530
        public void CalcRadius(){} // RVA: 0x7ffaaf874610
        public void CalcPull(){} // RVA: 0x7ffaaf8746b0
        public void CalcSpring(){} // RVA: 0x7ffaaf874770
        public void CalcStiffness(){} // RVA: 0x7ffaaf874830
        public void CalcImmobile(){} // RVA: 0x7ffaaf8748f0
        public void CalcMaxAngle(){} // RVA: 0x7ffaaf8749c0
        public void CalcLimitRotation(){} // RVA: 0x7ffaaf874b10
        public void CalcMaxStretch(){} // RVA: 0x7ffaaf874d00
        public void CalcStretchMotion(){} // RVA: 0x7ffaaf874db0
        public void CalcMaxSquish(){} // RVA: 0x7ffaaf874e80
        public void CalcGravity(){} // RVA: 0x7ffaaf874f50
        public void CalcGravityFalloff(){} // RVA: 0x7ffaaf874ff0
        public void SafeEvaluate(){} // RVA: 0x7ffaaf8750c0
        public void OnShapeEnter(){} // RVA: 0x7ffaaf875150
        public void OnShapeExit(){} // RVA: 0x7ffaaf875510
        public void OnCollidersUpdated(){} // RVA: 0x7ffaaf8755f0
        public void IsInteractionAllowed(){} // RVA: 0x7ffaaf875600
        public void get_HasUdonEmitter(){} // RVA: 0x7ffaaf8756d0
        public void get_IsGrabbed(){} // RVA: 0x7ffaae41f920
        public void get_IsPosed(){} // RVA: 0x7ffaaf8756e0
        public void get_Angle(){} // RVA: 0x7ffaaf8756f0
        public void get_Stretch(){} // RVA: 0x7ffaa9b5f240
        public void get_Squish(){} // RVA: 0x7ffaaf875700
        public void ApplyConfigurationChanges(){} // RVA: 0x7ffaaf875df0
        public void ReleaseGrabs(){} // RVA: 0x7ffaaf875e00
        public void ReleasePoses(){} // RVA: 0x7ffaaf875e90
        public void AssignUdonEmitter(){} // RVA: 0x7ffaa8d71d60
        public void .ctor(){} // RVA: 0x7ffaaf875f80
        public void .cctor(){} // RVA: 0x7ffaaf8763d0
        public void <InitTransforms>g__GetTransforms|119_0(){} // RVA: 0x7ffaaf876410
        // ── Binary Analysis Named ──
        public void GetRootTransform(){} // RVA: 0x7ffaaf872420
        public void GetPlayerId(){} // RVA: 0x7ffaaf872770
        public void GetKnownDependencies(){} // RVA: 0x7ffaaf872a00
        public void GetIsGrabbed(){} // RVA: 0x7ffaae41f920
        public void SetGrab(){} // RVA: 0x7ffaaf875710
        public void SetIsPosed(){} // RVA: 0x7ffaaf875a00
        public void SetAngle(){} // RVA: 0x7ffaaf875ca0
        public void SetStretch(){} // RVA: 0x7ffaaf875d10
        public void SetSquish(){} // RVA: 0x7ffaaf875d80
    }

    public class VRCPhysBoneColliderBase : DynamicsComponent
    {
        public object insideBounds; // 0x3376DE30
        public object position; // 0x3376DE30
        public object globalCollisionFlags; // 0x3376DE30
        public object playerId; // 0x3376DE30
        public object _executionGroup; // 0x3376DE30, was: <ExecutionGroup>k__BackingFiel

        // ── Original Methods ──
        public void get_axis(){} // RVA: 0x7ffaaf876f10
        public void get_isGlobalCollider(){} // RVA: 0x7ffaaf877110
        public void set_isGlobalCollider(){} // RVA: 0x7ffaaf877120
        public void get_MaximumExecutionGroups(){} // RVA: 0x7ffaaf872c30
        public void get_ExecutionGroup(){} // RVA: 0x7ffaa9221d50
        public void set_ExecutionGroup(){} // RVA: 0x7ffaa92217c0
        public void get_SortingBaseTransform(){} // RVA: 0x7ffaaf877160
        public void get_GlobalColliderFlags(){} // RVA: 0x7ffaaf877170
        public void set_GlobalColliderFlags(){} // RVA: 0x7ffaaf877250
        public void Awake(){} // RVA: 0x7ffaaf877260
        public void OnEnable(){} // RVA: 0x7ffaaf877400
        public void OnDisable(){} // RVA: 0x7ffaaf877470
        public void OnDestroy(){} // RVA: 0x7ffaaf877660
        public void InitShape(){} // RVA: 0x7ffaaf8777a0
        public void UpdateShape(){} // RVA: 0x7ffaaf877a70
        public void HandleParentChanged(){} // RVA: 0x7ffaaf878340
        public void .ctor(){} // RVA: 0x7ffaaf878500
        // ── Binary Analysis Named ──
        public void GetRootTransform(){} // RVA: 0x7ffaaf876df0
        public void GetPlayerId(){} // RVA: 0x7ffaaf877140
        public void GetKnownDependencies(){} // RVA: 0x7ffaa8932310
        public void GetBounds(){} // RVA: 0x7ffaaf877c70
    }

}