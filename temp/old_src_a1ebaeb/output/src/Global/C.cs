// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 664

public class COpenVRContext : Object
{
    public object m_pVRChaperoneSetup; // 0x34C24F30
    public object m_pVROverlay; // 0x34C24F30
    public object m_pVRExtendedDisplay; // 0x34C24F30
    public object m_pVRScreenshots; // 0x34C24F30
    public object m_pVRIOBuffer; // 0x34C24F30
    public object m_pVRDebug; // 0x34C24F30

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf226770
    public void Clear(){} // RVA: 0x7ffaaf226780
    public void VRSystem(){} // RVA: 0x7ffaaf226e20
    public void VRChaperone(){} // RVA: 0x7ffaaf227110
    public void VRChaperoneSetup(){} // RVA: 0x7ffaaf227390
    public void VRCompositor(){} // RVA: 0x7ffaaf227650
    public void VRHeadsetView(){} // RVA: 0x7ffaaf227910
    public void VROverlay(){} // RVA: 0x7ffaaf227b90
    public void VROverlayView(){} // RVA: 0x7ffaaf227e50
    public void VRRenderModels(){} // RVA: 0x7ffaaf2280c0
    public void VRExtendedDisplay(){} // RVA: 0x7ffaaf228380
    public void VRSettings(){} // RVA: 0x7ffaaf2285f0
    public void VRApplications(){} // RVA: 0x7ffaaf228880
    public void VRScreenshots(){} // RVA: 0x7ffaaf228b60
    public void VRTrackedCamera(){} // RVA: 0x7ffaaf228de0
    public void VRInput(){} // RVA: 0x7ffaaf229070
    public void VRIOBuffer(){} // RVA: 0x7ffaaf229330
    public void VRSpatialAnchors(){} // RVA: 0x7ffaaf2295b0
    public void VRDebug(){} // RVA: 0x7ffaaf229830
    public void VRNotifications(){} // RVA: 0x7ffaaf229ab0
    // ── Binary Analysis Named ──
    public void CheckClear(){} // RVA: 0x7ffaaf226d60
}

public class Cache : ValueType
{
    // ── Original Methods ──
    public void Clear(){} // RVA: 0x7ffaaef71df0
    public void FindOrLoadLayout(){} // RVA: 0x7ffaaef71e50
}

public class CacheCurve : Object
{
    public object m_Cache; // 0x34B4D9F0
    public object Count; // 0x170000DE

    // ── Original Methods ──
    public void get_Count(){} // RVA: 0x7ffaaa2580f0
    public void .ctor(){} // RVA: 0x7ffaaa258140
    public void Add(){} // RVA: 0x7ffaaa258260
    public void AddUntil(){} // RVA: 0x7ffaaa258340
    public void Evaluate(){} // RVA: 0x7ffaaa258640
}

public class CacheEntry : Object
{
    // ── Original Methods ──
    public void AddRawItem(){} // RVA: 0x7ffaaa258a50
    public void CreateCurves(){} // RVA: 0x7ffaaa258ea0
    public void .ctor(){} // RVA: 0x7ffaaa259360
}

public class CacheRefInstance : ValueType
{
    // ── Original Methods ──
    public void Dispose(){} // RVA: 0x7ffaaef71fd0
}

public class Cache`1 : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
}

public class CachedCodeEntry : Object
{
    public object Key; // 0x34C27AE0
    public object Capnames; // 0x34C27AE0
    public object Runnerref; // 0x34C27AE0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaedc19c0
}

public class CachedCodeEntryKey : ValueType
{
    public object _pattern; // 0x34C27950
    public object Next; // 0x34C27AE0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaacc42ec0
    public void Equals(){} // RVA: 0x7ffaaedc1860
    public void Equals(){} // RVA: 0x7ffaaedc1860
    public void op_Equality(){} // RVA: 0x7ffaaedc1920
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaaedc1950
}

public class Callback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa8660d80
    public void EndInvoke(){} // RVA: 0x7ffaa8660d80
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa865b1c0
}

public class CallbackContext : ValueType
{
    // ── Original Methods ──
    public void get_actionIndex(){} // RVA: 0x7ffaaa3cef80
    public void get_bindingIndex(){} // RVA: 0x7ffaaef3fd80
    public void get_controlIndex(){} // RVA: 0x7ffaaef3fdb0
    public void get_interactionIndex(){} // RVA: 0x7ffaaef3fdf0
    public void get_phase(){} // RVA: 0x7ffaaef3fe30
    public void get_started(){} // RVA: 0x7ffaaef3fe50
    public void get_performed(){} // RVA: 0x7ffaaef3fe80
    public void get_canceled(){} // RVA: 0x7ffaaef3feb0
    public void get_action(){} // RVA: 0x7ffaaef3fee0
    public void get_control(){} // RVA: 0x7ffaaef3ff10
    public void get_interaction(){} // RVA: 0x7ffaaef3ff70
    public void get_time(){} // RVA: 0x7ffaaef3ffd0
    public void get_startTime(){} // RVA: 0x7ffaaef3fff0
    public void get_duration(){} // RVA: 0x7ffaaef40010
    public void get_valueType(){} // RVA: 0x7ffaaef40050
    public void get_valueSizeInBytes(){} // RVA: 0x7ffaaef400b0
    public void ReadValue(){} // RVA: 0x7ffaa887e5c0
    public void ReadValue(){} // RVA: 0x7ffaa887e5c0
    public void ReadValueAsButton(){} // RVA: 0x7ffaaef40390
    public void ReadValueAsObject(){} // RVA: 0x7ffaaef40570
    public void ToString(){} // RVA: 0x7ffaaef40600
}

public class CalloutTarget : ValueType
{
}

public class CameraCallback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa898db80
    public void Invoke(){} // RVA: 0x7ffaa898dc60
}

public class CanceledResultSource : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8933e30
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa9099760
    public void OnCompleted(){} // RVA: 0x7ffaab6649c0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeeb33e0
    public void GetStatus(){} // RVA: 0x7ffaa9099760
}

public class CanceledResultSource`1 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660f30
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
    public void OnCompleted(){}
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
    public void GetStatus(){}
}

public class CanceledUniTaskCache`1 : Object
{
    // ── Original Methods ──
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
}

public class CancellationTokenDisposable : Object
{
    // ── Original Methods ──
    public void get_Token(){} // RVA: 0x7ffaa887e5c0
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class CanvasInfo : Object
{
    public object mCanvasParent; // 0x34B3D1E0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class Capabilities : ValueType
{
    public object flags; // 0x34C27390
    public object Initialize; // 0xB3F6FFF0
}

public class Capability : ValueType
{
}

public class CastInstructionT`1 : CastInstruction
{
    // ── Original Methods ──
    public void Run(){} // RVA: 0x7ffaa864e9f0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class CategoryPrefix : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab1949270
}

public class ChangeTokenRegistration`1 : Object
{
    public object _state; // 0x30B409E0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void OnChangeTokenFired(){} // RVA: 0x7ffaa8660cc0
    public void RegisterChangeTokenCallback(){} // RVA: 0x7ffaa8660d80
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    // ── Binary Analysis Named ──
    public void SetDisposable(){} // RVA: 0x7ffaa8660d80
}

public class ChangeTrackerDisposable : Object
{
    public object _listener; // 0x35073C40

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8669e70
    public void OnChange(){} // RVA: 0x7ffaa887e5c0
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
}

public class ChannelTransformer`2 : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa887e5c0
}

public class CharacterSubstitution : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8e055a0
}

public class CheckTexFieldInput : ValueType
{
}

public class ChildrenSection`1 : Object
{
    public object _settingComponents; // 0x30DEF690
    public object ValueToAppear; // 0x1700003C

    // ── Original Methods ──
    public void set_SettingComponents(){} // RVA: 0x7ffaa86491d0
    public void get_SettingComponents(){} // RVA: 0x7ffaa86491d0
    public void set_ValueToAppear(){} // RVA: 0x7ffaa86491d0
    public void get_ValueToAppear(){} // RVA: 0x7ffaa887e5c0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Initialize(){} // RVA: 0x7ffaa86491d0
    public void get_name(){} // RVA: 0x7ffaa86491d0
    public void set_name(){} // RVA: 0x7ffaa86491d0
    public void Instantiate(){} // RVA: 0x7ffaa86491d0
    // ── Binary Analysis Named ──
    public void GetInstanceID(){} // RVA: 0x7ffaa86491d0
}

public class ChildrenSection`1 : Object
{
    public object _settingComponents; // 0x34976150

    // ── Original Methods ──
    public void set_SettingComponents(){} // RVA: 0x7ffaa89600c0
    public void get_SettingComponents(){} // RVA: 0x7ffaa89600c0
    public void set_ValueToAppear(){} // RVA: 0x7ffaa89600c0
    public void get_ValueToAppear(){} // RVA: 0x7ffaa8b945a0
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Initialize(){} // RVA: 0x7ffaa89600c0
    public void get_name(){} // RVA: 0x7ffaa89600c0
    public void set_name(){} // RVA: 0x7ffaa89600c0
    public void Instantiate(){} // RVA: 0x7ffaa89600c0
    // ── Binary Analysis Named ──
    public void GetInstanceID(){} // RVA: 0x7ffaa89600c0
}

public class ChildrenSection`1 : Object
{
    public object _settingComponents; // 0x349762C8

    // ── Original Methods ──
    public void set_SettingComponents(){} // RVA: 0x7ffaa89600c0
    public void get_SettingComponents(){} // RVA: 0x7ffaa89600c0
    public void set_ValueToAppear(){} // RVA: 0x7ffaa89600c0
    public void get_ValueToAppear(){} // RVA: 0x7ffaa894d4e0
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Initialize(){} // RVA: 0x7ffaa89600c0
    public void get_name(){} // RVA: 0x7ffaa89600c0
    public void set_name(){} // RVA: 0x7ffaa89600c0
    public void Instantiate(){} // RVA: 0x7ffaa89600c0
    // ── Binary Analysis Named ──
    public void GetInstanceID(){} // RVA: 0x7ffaa89600c0
}

public class CinemachineCameraOffset : CinemachineExtension
{
    public object m_PreserveComposition; // 0x336844B0

    // ── Original Methods ──
    public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa1f3f10
    public void .ctor(){} // RVA: 0x7ffaaa1f44b0
}

public class CinemachineMixer : PlayableBehaviour
{
    public object m_BrainOverrideId; // 0x33976360
    public object 00; // 0x33036D70

    // ── Original Methods ──
    public void OnPlayableDestroy(){} // RVA: 0x7ffaaa1f4f90
    public void PrepareFrame(){} // RVA: 0x7ffaaa1f4ff0
    public void ProcessFrame(){} // RVA: 0x7ffaaa1f5000
    public void .ctor(){} // RVA: 0x7ffaaa1f5b30
    // ── Binary Analysis Named ──
    public void GetDeltaTime(){} // RVA: 0x7ffaaa1f59e0
}

public class CinemachineRecomposer : CinemachineExtension
{
    public object m_Pan; // 0x333A97B0
    public object m_FollowAttachment; // 0x333A97B0
    public object TouchSensitivityY; // 0x3353B850

    // ── Original Methods ──
    public void Reset(){} // RVA: 0x7ffaaa1f4540
    public void OnValidate(){} // RVA: 0x7ffaaa1f4570
    public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7ffaaa1f45d0
    public void PostPipelineStageCallback(){} // RVA: 0x7ffaaa1f45f0
    public void .ctor(){} // RVA: 0x7ffaa8932d50
}

public class CinemachineShot : PlayableAsset
{
    // ── Original Methods ──
    public void CreatePlayable(){} // RVA: 0x7ffaaa1f5b40
    public void GatherProperties(){} // RVA: 0x7ffaaa1f5da0
    public void .ctor(){} // RVA: 0x7ffaa8b59ae0
}

public class CinemachineShotPlayable : PlayableBehaviour
{
    // ── Original Methods ──
    public void get_IsValid(){} // RVA: 0x7ffaaa1f5f80
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class CinemachineTouchInputMapper : MonoBehaviour
{
    public object TouchXInputMapTo; // 0x3353B850

    // ── Original Methods ──
    public void Start(){} // RVA: 0x7ffaaa1f4bc0
    public void .ctor(){} // RVA: 0x7ffaaa1f4e40
    // ── Binary Analysis Named ──
    public void GetInputAxis(){} // RVA: 0x7ffaaa1f4cc0
}

public class CinemachineTrack : TrackAsset
{
    // ── Original Methods ──
    public void CreateTrackMixer(){} // RVA: 0x7ffaaa1f6050
    public void .ctor(){} // RVA: 0x7ffaaa1f6190
}

public class ClearImmediateRenderers : ValueType
{
}

public class ClearIntermediateRenderers : ValueType
{
}

public class ClearLines : ValueType
{
}

public class ClearLines : ValueType
{
}

public class Clipper : ClipperBase
{
    public object ioPreserveCollinear; // 0x34B577F0
    public object m_SortedEdges; // 0x34B577F0
    public object m_ExecuteLocked; // 0x34B577F0
    public object m_Joins; // 0x34B577F0
    public object _reverseSolution; // 0x34B577F0, was: <ReverseSolution>k__BackingFie
    public object 00; // 0x34B75270

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa269660
    public void InsertMaxima(){} // RVA: 0x7ffaaa269c80
    public void get_ReverseSolution(){} // RVA: 0x7ffaaa26a0a0
    public void set_ReverseSolution(){} // RVA: 0x7ffaaa26a0b0
    public void get_StrictlySimple(){} // RVA: 0x7ffaa9969490
    public void set_StrictlySimple(){} // RVA: 0x7ffaaa26a0c0
    public void Execute(){} // RVA: 0x7ffaaa26a2c0
    public void Execute(){} // RVA: 0x7ffaaa26a2c0
    public void Execute(){} // RVA: 0x7ffaaa26a2c0
    public void Execute(){} // RVA: 0x7ffaaa26a2c0
    public void FixHoleLinkage(){} // RVA: 0x7ffaaa26a3a0
    public void ExecuteInternal(){} // RVA: 0x7ffaaa26a440
    public void DisposeAllPolyPts(){} // RVA: 0x7ffaaa26aaf0
    public void AddJoin(){} // RVA: 0x7ffaaa26aca0
    public void AddGhostJoin(){} // RVA: 0x7ffaaa26adf0
    public void InsertLocalMinimaIntoAEL(){} // RVA: 0x7ffaaa26aee0
    public void InsertEdgeIntoAEL(){} // RVA: 0x7ffaaa26b500
    public void E2InsertsBeforeE1(){} // RVA: 0x7ffaaa26b8c0
    public void IsEvenOddFillType(){} // RVA: 0x7ffaaa26b9d0
    public void IsEvenOddAltFillType(){} // RVA: 0x7ffaaa26ba00
    public void IsContributing(){} // RVA: 0x7ffaaa26ba30
    public void AddEdgeToSEL(){} // RVA: 0x7ffaaa26be10
    public void PopEdgeFromSEL(){} // RVA: 0x7ffaaa26c0d0
    public void CopyAELToSEL(){} // RVA: 0x7ffaaa26c2e0
    public void SwapPositionsInSEL(){} // RVA: 0x7ffaaa26c410
    public void AddLocalMaxPoly(){} // RVA: 0x7ffaaa26c840
    public void AddLocalMinPoly(){} // RVA: 0x7ffaaa26c900
    public void AddOutPt(){} // RVA: 0x7ffaaa26cba0
    public void SwapPoints(){} // RVA: 0x7ffaaa26d060
    public void HorzSegmentsOverlap(){} // RVA: 0x7ffaaa26d090
    public void FirstIsBottomPt(){} // RVA: 0x7ffaaa26d2e0
    public void OutRec1RightOfOutRec2(){} // RVA: 0x7ffaaa26d9c0
    public void AppendPolygon(){} // RVA: 0x7ffaaa26daa0
    public void ReversePolyPtLinks(){} // RVA: 0x7ffaaa26ead0
    public void SwapSides(){} // RVA: 0x7ffaaa26ebd0
    public void SwapPolyIndexes(){} // RVA: 0x7ffaaa26ec00
    public void IntersectEdges(){} // RVA: 0x7ffaaa26ec30
    public void DeleteFromSEL(){} // RVA: 0x7ffaaa26f250
    public void ProcessHorizontals(){} // RVA: 0x7ffaaa26f470
    public void ProcessHorizontal(){} // RVA: 0x7ffaaa26f720
    public void IsMinima(){} // RVA: 0x7ffaaa270130
    public void IsMaxima(){} // RVA: 0x7ffaaa270170
    public void IsIntermediate(){} // RVA: 0x7ffaaa2701a0
    public void ProcessIntersections(){} // RVA: 0x7ffaaa270320
    public void BuildIntersectList(){} // RVA: 0x7ffaaa2705a0
    public void EdgesAdjacent(){} // RVA: 0x7ffaaa270970
    public void IntersectNodeSort(){} // RVA: 0x7ffaaa2709b0
    public void FixupIntersectionOrder(){} // RVA: 0x7ffaaa2709d0
    public void ProcessIntersectList(){} // RVA: 0x7ffaaa270d80
    public void Round(){} // RVA: 0x7ffaaa270ed0
    public void TopX(){} // RVA: 0x7ffaaa270f00
    public void IntersectPoint(){} // RVA: 0x7ffaaa270f70
    public void ProcessEdgesAtTopOfScanbeam(){} // RVA: 0x7ffaaa2713d0
    public void ReversePaths(){} // RVA: 0x7ffaaa271bc0
    public void Orientation(){} // RVA: 0x7ffaaa271e40
    public void PointCount(){} // RVA: 0x7ffaaa271e60
    public void BuildResult(){} // RVA: 0x7ffaaa271e90
    public void BuildResult2(){} // RVA: 0x7ffaaa2720e0
    public void FixupOutPolyline(){} // RVA: 0x7ffaaa272470
    public void FixupOutPolygon(){} // RVA: 0x7ffaaa272580
    public void DupOutPt(){} // RVA: 0x7ffaaa272a80
    public void JoinHorz(){} // RVA: 0x7ffaaa272ee0
    public void JoinPoints(){} // RVA: 0x7ffaaa2734f0
    public void PointInPolygon(){} // RVA: 0x7ffaaa274920
    public void PointInPolygon(){} // RVA: 0x7ffaaa274920
    public void Poly2ContainsPoly1(){} // RVA: 0x7ffaaa274a70
    public void FixupFirstLefts1(){} // RVA: 0x7ffaaa274c00
    public void FixupFirstLefts2(){} // RVA: 0x7ffaaa274dc0
    public void FixupFirstLefts3(){} // RVA: 0x7ffaaa275010
    public void ParseFirstLeft(){} // RVA: 0x7ffaaa2751b0
    public void JoinCommonEdges(){} // RVA: 0x7ffaaa2751d0
    public void UpdateOutPtIdxs(){} // RVA: 0x7ffaaa275ba0
    public void Area(){} // RVA: 0x7ffaaa2760e0
    public void Area(){} // RVA: 0x7ffaaa2760e0
    public void Area(){} // RVA: 0x7ffaaa2760e0
    public void SimplifyPolygon(){} // RVA: 0x7ffaaa276150
    public void SimplifyPolygons(){} // RVA: 0x7ffaaa276250
    public void DistanceSqrd(){} // RVA: 0x7ffaaa276350
    public void DistanceFromLineSqrd(){} // RVA: 0x7ffaaa276390
    public void SlopesNearCollinear(){} // RVA: 0x7ffaaa276410
    public void PointsAreClose(){} // RVA: 0x7ffaaa276640
    public void ExcludeOp(){} // RVA: 0x7ffaaa276680
    public void CleanPolygon(){} // RVA: 0x7ffaaa276770
    public void CleanPolygons(){} // RVA: 0x7ffaaa276db0
    public void Minkowski(){} // RVA: 0x7ffaaa276f20
    public void MinkowskiSum(){} // RVA: 0x7ffaaa277a90
    public void TranslatePath(){} // RVA: 0x7ffaaa2778b0
    public void MinkowskiSum(){} // RVA: 0x7ffaaa277a90
    public void MinkowskiDiff(){} // RVA: 0x7ffaaa277cc0
    public void PolyTreeToPaths(){} // RVA: 0x7ffaaa277d90
    public void AddPolyNodeToPaths(){} // RVA: 0x7ffaaa277e50
    public void OpenPathsFromPolyTree(){} // RVA: 0x7ffaaa278040
    public void ClosedPathsFromPolyTree(){} // RVA: 0x7ffaaa2781e0
    // ── Binary Analysis Named ──
    public void SetWindingCount(){} // RVA: 0x7ffaaa26bbd0
    public void GetLastOutPt(){} // RVA: 0x7ffaaa26cfc0
    public void SetHoleState(){} // RVA: 0x7ffaaa26d0d0
    public void GetDx(){} // RVA: 0x7ffaaa26d2a0
    public void GetBottomPt(){} // RVA: 0x7ffaaa26d720
    public void GetLowermostRec(){} // RVA: 0x7ffaaa26d840
    public void GetOutRec(){} // RVA: 0x7ffaaa26d9f0
    public void GetHorzDirection(){} // RVA: 0x7ffaaa26f6c0
    public void GetNextInAEL(){} // RVA: 0x7ffaaa270100
    public void GetMaximaPair(){} // RVA: 0x7ffaaa2701e0
    public void GetMaximaPairEx(){} // RVA: 0x7ffaaa270260
    public void DoMaxima(){} // RVA: 0x7ffaaa271960
    public void GetOverlap(){} // RVA: 0x7ffaaa272dc0
    public void DoSimplePolygons(){} // RVA: 0x7ffaaa275bd0
}

public class ClipperBase : Object
{
    public object Unassigned; // 0x34B573A0
    public object hiRange; // 0x34B573A0
    public object m_edges; // 0x34B573A0
    public object m_ActiveEdges; // 0x34B573A0
    public object _preserveCollinear; // 0x34B573A0, was: <PreserveCollinear>k__BackingF
    public object PreserveCollinear; // 0x170000F2
    public object ntAny; // 0x34B57540

    // ── Original Methods ──
    public void near_zero(){} // RVA: 0x7ffaaa264af0
    public void get_PreserveCollinear(){} // RVA: 0x7ffaa8bfb090
    public void set_PreserveCollinear(){} // RVA: 0x7ffaa8bfb660
    public void Swap(){} // RVA: 0x7ffaaa264b10
    public void IsHorizontal(){} // RVA: 0x7ffaaa264b20
    public void PointIsVertex(){} // RVA: 0x7ffaaa264b40
    public void PointOnLineSegment(){} // RVA: 0x7ffaaa264b90
    public void PointOnPolygon(){} // RVA: 0x7ffaaa264d50
    public void SlopesEqual(){} // RVA: 0x7ffaaa265200
    public void SlopesEqual(){} // RVA: 0x7ffaaa265200
    public void SlopesEqual(){} // RVA: 0x7ffaaa265200
    public void .ctor(){} // RVA: 0x7ffaaa265350
    public void Clear(){} // RVA: 0x7ffaaa2654c0
    public void DisposeLocalMinimaList(){} // RVA: 0x7ffaaa2657b0
    public void RangeTest(){} // RVA: 0x7ffaaa2658f0
    public void InitEdge(){} // RVA: 0x7ffaaa2659d0
    public void InitEdge2(){} // RVA: 0x7ffaaa265ab0
    public void FindNextLocMin(){} // RVA: 0x7ffaaa265b60
    public void ProcessBound(){} // RVA: 0x7ffaaa265c70
    public void AddPath(){} // RVA: 0x7ffaaa266340
    public void AddPaths(){} // RVA: 0x7ffaaa267770
    public void Pt2IsBetweenPt1AndPt3(){} // RVA: 0x7ffaaa267860
    public void RemoveEdge(){} // RVA: 0x7ffaaa2678e0
    public void InsertLocalMinima(){} // RVA: 0x7ffaaa267a90
    public void PopLocalMinima(){} // RVA: 0x7ffaaa267cb0
    public void ReverseHorizontal(){} // RVA: 0x7ffaaa267da0
    public void Reset(){} // RVA: 0x7ffaaa267dd0
    public void InsertScanbeam(){} // RVA: 0x7ffaaa2686c0
    public void PopScanbeam(){} // RVA: 0x7ffaaa2689c0
    public void LocalMinimaPending(){} // RVA: 0x7ffaaa268a50
    public void CreateOutRec(){} // RVA: 0x7ffaaa268a60
    public void DisposeOutRec(){} // RVA: 0x7ffaaa268c90
    public void UpdateEdgeIntoAEL(){} // RVA: 0x7ffaaa268da0
    public void SwapPositionsInAEL(){} // RVA: 0x7ffaaa269180
    public void DeleteFromAEL(){} // RVA: 0x7ffaaa269440
    // ── Binary Analysis Named ──
    public void SetDx(){} // RVA: 0x7ffaaa267a30
    public void GetBounds(){} // RVA: 0x7ffaaa268240
}

public class ClipperException : Exception
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa27cbf0
}

public class ClipperOffset : Object
{
    public object m_destPoly; // 0x34B57990
    public object m_sinA; // 0x34B57990
    public object m_miterLim; // 0x34B57990
    public object m_polyNodes; // 0x34B57990
    public object two_pi; // 0x34B57990
    public object 00; // 0x34B75C50

    // ── Original Methods ──
    public void get_ArcTolerance(){} // RVA: 0x7ffaaa2782a0
    public void set_ArcTolerance(){} // RVA: 0x7ffaaa2782b0
    public void get_MiterLimit(){} // RVA: 0x7ffaaa2782c0
    public void set_MiterLimit(){} // RVA: 0x7ffaaa2782d0
    public void .ctor(){} // RVA: 0x7ffaaa2782e0
    public void Clear(){} // RVA: 0x7ffaaa278460
    public void Round(){} // RVA: 0x7ffaaa270ed0
    public void AddPath(){} // RVA: 0x7ffaaa2784e0
    public void AddPaths(){} // RVA: 0x7ffaaa278b70
    public void FixOrientations(){} // RVA: 0x7ffaaa278ce0
    public void Execute(){} // RVA: 0x7ffaaa27abb0
    public void Execute(){} // RVA: 0x7ffaaa27abb0
    public void OffsetPoint(){} // RVA: 0x7ffaaa27b2f0
    // ── Binary Analysis Named ──
    public void GetUnitNormal(){} // RVA: 0x7ffaaa278f60
    public void DoOffset(){} // RVA: 0x7ffaaa279060
    public void DoSquare(){} // RVA: 0x7ffaaa27bd10
    public void DoMiter(){} // RVA: 0x7ffaaa27c350
    public void DoRound(){} // RVA: 0x7ffaaa27c610
}

public class Codec : Object
{
    public object mapTag; // 0x30E041D0
    public object KeyCodec; // 0x17000223

    // ── Original Methods ──
    public void .ctor(){}
    public void get_KeyCodec(){} // RVA: 0x7ffaa86491d0
    public void get_ValueCodec(){} // RVA: 0x7ffaa86491d0
    public void get_MapTag(){} // RVA: 0x7ffaa8649ca0
}

public class Collection : ValueType
{
    public object layoutStrings; // 0x33B3C850
    public object layoutOverrides; // 0x33B3C850
    public object layoutMatchers; // 0x33B3C850
    public object totalSize; // 0x3379FB50

    // ── Original Methods ──
    public void Allocate(){} // RVA: 0x7ffaaf0b6ab0
    public void TryFindLayoutForType(){} // RVA: 0x7ffaaf0b7130
    public void TryFindMatchingLayout(){} // RVA: 0x7ffaaf0b7330
    public void HasLayout(){} // RVA: 0x7ffaaf0b75e0
    public void TryLoadLayoutInternal(){} // RVA: 0x7ffaaf0b7710
    public void TryLoadLayout(){} // RVA: 0x7ffaaf0b7e30
    public void ComputeDistanceInInheritanceHierarchy(){} // RVA: 0x7ffaaf0b8760
    public void FindLayoutThatIntroducesControl(){} // RVA: 0x7ffaaf0b8870
    public void ValueTypeIsAssignableFrom(){} // RVA: 0x7ffaaf0b8e00
    public void IsGeneratedLayout(){} // RVA: 0x7ffaaf0b8f10
    public void IsBasedOn(){} // RVA: 0x7ffaaf0b90f0
    public void AddMatcher(){} // RVA: 0x7ffaaf0b9240
    // ── Binary Analysis Named ──
    public void GetBaseLayoutName(){} // RVA: 0x7ffaaf0b8500
    public void GetRootLayoutName(){} // RVA: 0x7ffaaf0b8620
    public void GetControlTypeForLayout(){} // RVA: 0x7ffaaf0b8b30
    public void GetBaseLayouts(){} // RVA: 0x7ffaaf0b8f90
}

public class CollectionHeaderTypeInfo`2 : HeaderTypeInfo`2
{
    public object parser; // 0x30E04350
    public object Separator; // 0x17000040

    // ── Original Methods ──
    public void .ctor(){}
    public void get_Separator(){} // RVA: 0x7ffaa86491d0
    public void TryParse(){} // RVA: 0x7ffaa864d540
}

public class CollisionModule : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void get_enabled(){} // RVA: 0x7ffaaf36f130
    public void set_enabled(){} // RVA: 0x7ffaaf36f180
    public void get_type(){} // RVA: 0x7ffaaf36f1e0
    public void set_type(){} // RVA: 0x7ffaaf36f230
    public void get_mode(){} // RVA: 0x7ffaaf36f290
    public void set_mode(){} // RVA: 0x7ffaaf36f2e0
    public void get_dampen(){} // RVA: 0x7ffaaf36f340
    public void set_dampen(){} // RVA: 0x7ffaaf36f3b0
    public void get_dampenMultiplier(){} // RVA: 0x7ffaaf36f410
    public void set_dampenMultiplier(){} // RVA: 0x7ffaaf36f460
    public void get_bounce(){} // RVA: 0x7ffaaf36f4c0
    public void set_bounce(){} // RVA: 0x7ffaaf36f530
    public void get_bounceMultiplier(){} // RVA: 0x7ffaaf36f590
    public void set_bounceMultiplier(){} // RVA: 0x7ffaaf36f5e0
    public void get_lifetimeLoss(){} // RVA: 0x7ffaaf36f640
    public void set_lifetimeLoss(){} // RVA: 0x7ffaaf36f6b0
    public void get_lifetimeLossMultiplier(){} // RVA: 0x7ffaaf36f710
    public void set_lifetimeLossMultiplier(){} // RVA: 0x7ffaaf36f760
    public void get_minKillSpeed(){} // RVA: 0x7ffaaf36f7c0
    public void set_minKillSpeed(){} // RVA: 0x7ffaaf36f810
    public void get_maxKillSpeed(){} // RVA: 0x7ffaaf36f870
    public void set_maxKillSpeed(){} // RVA: 0x7ffaaf36f8c0
    public void get_collidesWith(){} // RVA: 0x7ffaaf36f920
    public void set_collidesWith(){} // RVA: 0x7ffaaf36f980
    public void get_enableDynamicColliders(){} // RVA: 0x7ffaaf36f9e0
    public void set_enableDynamicColliders(){} // RVA: 0x7ffaaf36fa30
    public void get_maxCollisionShapes(){} // RVA: 0x7ffaaf36fa90
    public void set_maxCollisionShapes(){} // RVA: 0x7ffaaf36fae0
    public void get_quality(){} // RVA: 0x7ffaaf36fb40
    public void set_quality(){} // RVA: 0x7ffaaf36fb90
    public void get_voxelSize(){} // RVA: 0x7ffaaf36fbf0
    public void set_voxelSize(){} // RVA: 0x7ffaaf36fc40
    public void get_radiusScale(){} // RVA: 0x7ffaaf36fca0
    public void set_radiusScale(){} // RVA: 0x7ffaaf36fcf0
    public void get_sendCollisionMessages(){} // RVA: 0x7ffaaf36fd50
    public void set_sendCollisionMessages(){} // RVA: 0x7ffaaf36fda0
    public void get_colliderForce(){} // RVA: 0x7ffaaf36fe00
    public void set_colliderForce(){} // RVA: 0x7ffaaf36fe50
    public void get_multiplyColliderForceByCollisionAngle(){} // RVA: 0x7ffaaf36feb0
    public void set_multiplyColliderForceByCollisionAngle(){} // RVA: 0x7ffaaf36ff00
    public void get_multiplyColliderForceByParticleSpeed(){} // RVA: 0x7ffaaf36ff60
    public void set_multiplyColliderForceByParticleSpeed(){} // RVA: 0x7ffaaf36ffb0
    public void get_multiplyColliderForceByParticleSize(){} // RVA: 0x7ffaaf370010
    public void set_multiplyColliderForceByParticleSize(){} // RVA: 0x7ffaaf370060
    public void AddPlane(){} // RVA: 0x7ffaaf3700c0
    public void RemovePlane(){} // RVA: 0x7ffaaf370180
    public void RemovePlane(){} // RVA: 0x7ffaaf370180
    public void RemovePlaneObject(){} // RVA: 0x7ffaaf370180
    public void get_planeCount(){} // RVA: 0x7ffaaf3702b0
    public void get_enabled_Injected(){} // RVA: 0x7ffaaf36f130
    public void set_enabled_Injected(){} // RVA: 0x7ffaaf36f180
    public void get_type_Injected(){} // RVA: 0x7ffaaf36f1e0
    public void set_type_Injected(){} // RVA: 0x7ffaaf36f230
    public void get_mode_Injected(){} // RVA: 0x7ffaaf36f290
    public void set_mode_Injected(){} // RVA: 0x7ffaaf36f2e0
    public void get_dampen_Injected(){} // RVA: 0x7ffaaf370300
    public void set_dampen_Injected(){} // RVA: 0x7ffaaf370360
    public void get_dampenMultiplier_Injected(){} // RVA: 0x7ffaaf36f410
    public void set_dampenMultiplier_Injected(){} // RVA: 0x7ffaaf36f460
    public void get_bounce_Injected(){} // RVA: 0x7ffaaf3703c0
    public void set_bounce_Injected(){} // RVA: 0x7ffaaf370420
    public void get_bounceMultiplier_Injected(){} // RVA: 0x7ffaaf36f590
    public void set_bounceMultiplier_Injected(){} // RVA: 0x7ffaaf36f5e0
    public void get_lifetimeLoss_Injected(){} // RVA: 0x7ffaaf370480
    public void set_lifetimeLoss_Injected(){} // RVA: 0x7ffaaf3704e0
    public void get_lifetimeLossMultiplier_Injected(){} // RVA: 0x7ffaaf36f710
    public void set_lifetimeLossMultiplier_Injected(){} // RVA: 0x7ffaaf36f760
    public void get_minKillSpeed_Injected(){} // RVA: 0x7ffaaf36f7c0
    public void set_minKillSpeed_Injected(){} // RVA: 0x7ffaaf36f810
    public void get_maxKillSpeed_Injected(){} // RVA: 0x7ffaaf36f870
    public void set_maxKillSpeed_Injected(){} // RVA: 0x7ffaaf36f8c0
    public void get_collidesWith_Injected(){} // RVA: 0x7ffaaf370540
    public void set_collidesWith_Injected(){} // RVA: 0x7ffaaf3705a0
    public void get_enableDynamicColliders_Injected(){} // RVA: 0x7ffaaf36f9e0
    public void set_enableDynamicColliders_Injected(){} // RVA: 0x7ffaaf36fa30
    public void get_maxCollisionShapes_Injected(){} // RVA: 0x7ffaaf36fa90
    public void set_maxCollisionShapes_Injected(){} // RVA: 0x7ffaaf36fae0
    public void get_quality_Injected(){} // RVA: 0x7ffaaf36fb40
    public void set_quality_Injected(){} // RVA: 0x7ffaaf36fb90
    public void get_voxelSize_Injected(){} // RVA: 0x7ffaaf36fbf0
    public void set_voxelSize_Injected(){} // RVA: 0x7ffaaf36fc40
    public void get_radiusScale_Injected(){} // RVA: 0x7ffaaf36fca0
    public void set_radiusScale_Injected(){} // RVA: 0x7ffaaf36fcf0
    public void get_sendCollisionMessages_Injected(){} // RVA: 0x7ffaaf36fd50
    public void set_sendCollisionMessages_Injected(){} // RVA: 0x7ffaaf36fda0
    public void get_colliderForce_Injected(){} // RVA: 0x7ffaaf36fe00
    public void set_colliderForce_Injected(){} // RVA: 0x7ffaaf36fe50
    public void get_multiplyColliderForceByCollisionAngle_Injected(){} // RVA: 0x7ffaaf36feb0
    public void set_multiplyColliderForceByCollisionAngle_Injected(){} // RVA: 0x7ffaaf36ff00
    public void get_multiplyColliderForceByParticleSpeed_Injected(){} // RVA: 0x7ffaaf36ff60
    public void set_multiplyColliderForceByParticleSpeed_Injected(){} // RVA: 0x7ffaaf36ffb0
    public void get_multiplyColliderForceByParticleSize_Injected(){} // RVA: 0x7ffaaf370010
    public void set_multiplyColliderForceByParticleSize_Injected(){} // RVA: 0x7ffaaf370060
    public void AddPlane_Injected(){} // RVA: 0x7ffaaf3700c0
    public void RemovePlane_Injected(){} // RVA: 0x7ffaaf370120
    public void RemovePlaneObject_Injected(){} // RVA: 0x7ffaaf370180
    public void get_planeCount_Injected(){} // RVA: 0x7ffaaf3702b0
    // ── Binary Analysis Named ──
    public void SetPlane(){} // RVA: 0x7ffaaf3701e0
    public void GetPlane(){} // RVA: 0x7ffaaf370250
    public void SetPlane_Injected(){} // RVA: 0x7ffaaf3701e0
    public void GetPlane_Injected(){} // RVA: 0x7ffaaf370250
}

public class CollisionRecord : ValueType
{
    public object triggerProxy; // 0x341A5CF0
}

public class ColorBySpeedModule : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void get_enabled(){} // RVA: 0x7ffaaf3778f0
    public void set_enabled(){} // RVA: 0x7ffaaf377940
    public void get_color(){} // RVA: 0x7ffaaf3779a0
    public void set_color(){} // RVA: 0x7ffaaf377a20
    public void get_range(){} // RVA: 0x7ffaaf377a80
    public void set_range(){} // RVA: 0x7ffaaf377ae0
    public void get_enabled_Injected(){} // RVA: 0x7ffaaf3778f0
    public void set_enabled_Injected(){} // RVA: 0x7ffaaf377940
    public void get_color_Injected(){} // RVA: 0x7ffaaf377b40
    public void set_color_Injected(){} // RVA: 0x7ffaaf377ba0
    public void get_range_Injected(){} // RVA: 0x7ffaaf377c00
    public void set_range_Injected(){} // RVA: 0x7ffaaf377c60
}

public class ColorOverLifetimeModule : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void get_enabled(){} // RVA: 0x7ffaaf3776a0
    public void set_enabled(){} // RVA: 0x7ffaaf3776f0
    public void get_color(){} // RVA: 0x7ffaaf377750
    public void set_color(){} // RVA: 0x7ffaaf3777d0
    public void get_enabled_Injected(){} // RVA: 0x7ffaaf3776a0
    public void set_enabled_Injected(){} // RVA: 0x7ffaaf3776f0
    public void get_color_Injected(){} // RVA: 0x7ffaaf377830
    public void set_color_Injected(){} // RVA: 0x7ffaaf377890
}

public class ColorPaletteData : Object
{
    public object highlights; // 0x341049D0
    public object backgrounds; // 0x341049D0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class Comparers : Object
{
    public object _valueComparer; // 0x30E079D0
    public object KeyComparer; // 0x1700003C

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8669e70
    public void get_KeyComparer(){} // RVA: 0x7ffaa86491d0
    public void get_KeyOnlyComparer(){} // RVA: 0x7ffaa86491d0
    public void get_ValueComparer(){} // RVA: 0x7ffaa86491d0
    public void Equals(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0x7ffaa887e5c0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaa887e5c0
    public void Get(){} // RVA: 0x7ffaa8649330
}

public class Comparers : Object
{
    public object _valueComparer; // 0x30E07D30
    public object KeyComparer; // 0x1700004B

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8669e70
    public void get_KeyComparer(){} // RVA: 0x7ffaa86491d0
    public void get_KeyOnlyComparer(){} // RVA: 0x7ffaa86491d0
    public void get_ValueComparer(){} // RVA: 0x7ffaa86491d0
    public void get_HashBucketEqualityComparer(){} // RVA: 0x7ffaa86491d0
    public void Equals(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0x7ffaa887e5c0
    public void WithValueComparer(){} // RVA: 0x7ffaa8649280
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaa887e5c0
    public void Get(){} // RVA: 0x7ffaa8649330
}

public class ConfigurationListDebugView : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void get_Items(){} // RVA: 0x7ffaa86491d0
}

public class ConfiguredTaskAwaiter : ValueType
{
    public object m_task; // 0x34FA9720

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8666840
    public void get_IsCompleted(){} // RVA: 0x7ffaa864a040
    public void OnCompleted(){} // RVA: 0x7ffaa8660d80
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaa8660d80
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void get_IsCompleted(){} // RVA: 0x7ffaa864a040
    public void OnCompleted(){} // RVA: 0x7ffaa8660d80
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaa8660d80
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa887e5c0
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Original Methods ──
    public void OnCompleted(){} // RVA: 0x7ffaa8660d80
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaa8660d80
}

public class ConnectDisposable : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
}

public class ConstraintManagerUpdate : ValueType
{
}

public class ConstructJob : ValueType
{
    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaef338d0
}

public class ConstructJob : ValueType
{
    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaef338d0
}

public class ConstructJobList : ValueType
{
    public object m_Stream; // 0x3379CC00

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaef338a0
}

public class ConstructJobList : ValueType
{
    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaef338a0
}

public class ContactEventDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaabba2a50
    public void Invoke(){} // RVA: 0x7ffaab656810
}

public class ContainerHeight : Object
{
    // ── Original Methods ──
    public void get_Height(){} // RVA: 0x7ffab1024f30
    public void Computeposition_Inj(){} // RVA: 0x7ffab1024f30
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Initialize(){} // RVA: 0x7ffab1024f30
    public void CompareBaseObjects(){} // RVA: 0x7ffab1024f30
    public void IsNativeObjectAlive(){} // RVA: 0x7ffab1024f30
    public void get_name(){} // RVA: 0x7ffab1024f30
    public void set_name(){} // RVA: 0x7ffab1024f30
    public void Instantiate(){} // RVA: 0x7ffab1024f30
    // ── Binary Analysis Named ──
    public void GetCachedPtr(){} // RVA: 0x7ffab1024f30
}

public class Content : ValueType
{
}

public class Content : ValueType
{
    public object observableText; // 0x3345EE40
}

public class Content : ValueType
{
}

public class Content : ValueType
{
}

public class Content : ValueType
{
}

public class Content : ValueType
{
}

public class Content : ValueType
{
}

public class Content : ValueType
{
    public object LayoutMode; // 0x33856800
    public object spacing; // 0x33856800
    public object paddingTop; // 0x33856800
    public object fillY; // 0x33856800
    public object oddElementsPaddingLeft; // 0x33856800
    public object oddElementsPaddingBottom; // 0x33856800
    public object GridConstraint; // 0x33856800
    public object Scrollable; // 0x33856800
    public object 000; // 0x852DFDA0
}

public class Content : ValueType
{
}

public class Content : ValueType
{
    public object WorldFilterLevel; // 0x3397FD80
    public object IsWorldPrivate; // 0x3397FD80
    public object Thumbnail; // 0x3397FD80
    public object IsWorldDownloading; // 0x3397FD80
    public object value__; // 0x85272D50
    public object Favorite; // 0x85272D50
}

public class Content : ValueType
{
    public object inVRMode; // 0x33A554F0
}

public class Content : ValueType
{
    public object IsSelected; // 0x33A6D2A0
}

public class Content : ValueType
{
    public object DisplayPrice; // 0x33CD3B00
    public object IsFavorited; // 0x33CD3B00
    public object CanTryOn; // 0x33CD3B00
    public object ShowDisplayName; // 0x33CD3B00
    public object ShowFunctionButtons; // 0x33CD3B00
    public object DetailsButtonTooltip; // 0x33CD3B00
    public object Wear; // 0x852720D0
    public object AddFavorite; // 0x852720D0
}

public class ContentHeightCacheInfo : ValueType
{
    // ── Original Methods ──
    public void .ctor(){}
}

public class ContentSectionElementSet : ValueType
{
    public object contentListHeaderLabel; // 0x349C39F0
}

public class Context : ValueType
{
    public object AlwaysMatchFlags; // 0x34E69210
    public object PrevCode; // 0x34E69210

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaddbc490
}

public class ContingentProperties : Object
{
    public object m_exceptionsHolder; // 0x34FA17A0
    public object m_internalCancellationRequested; // 0x34FA17A0

    // ── Original Methods ──
    public void UnregisterCancellationCallback(){} // RVA: 0x7ffaae107bc0
    public void .ctor(){} // RVA: 0x7ffaae107cb0
    // ── Binary Analysis Named ──
    public void SetCompleted(){} // RVA: 0x7ffaae107b90
}

public class ContinuationWrapper : Object
{
    public object m_innerTask; // 0x341A5060

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaadf007b0
    public void Invoke(){} // RVA: 0x7ffaac0ad2d0
}

public class Control : Object
{
    public object type; // 0x33E55620
    public object style; // 0x33E55620
    public object labels; // 0x33E55620
    public object _control; // 0xB41EDE30, was: ÏÌÌÌÎÏÎÌÌÍÍÏÌÌÍÎÍÌÍÍÍÏÍ

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa989ed50
    // ── Binary Analysis Named ──
    public void GetSubParameter(){} // RVA: 0x7ffab1a30b00
    public void GetLabel(){} // RVA: 0x7ffab1a30b40
}

public class ControlBitRangeNode : ValueType
{
    public object controlStartIndex; // 0x33BBCD30

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaefb64c0
}

public class ControlBuilder : ValueType
{
    // ── Original Methods ──
    public void get_control(){} // RVA: 0x7ffaa950bda0
    public void set_control(){} // RVA: 0x7ffaa930eca0
    public void At(){} // RVA: 0x7ffaaefab540
    public void WithParent(){} // RVA: 0x7ffaaefab620
    public void WithName(){} // RVA: 0x7ffaaefab690
    public void WithDisplayName(){} // RVA: 0x7ffaaefab730
    public void WithShortDisplayName(){} // RVA: 0x7ffaaefab810
    public void WithLayout(){} // RVA: 0x7ffaaefab8f0
    public void WithUsages(){} // RVA: 0x7ffaaefab960
    public void WithAliases(){} // RVA: 0x7ffaaefab990
    public void WithChildren(){} // RVA: 0x7ffaaefab9c0
    public void WithStateBlock(){} // RVA: 0x7ffaaefab9f0
    public void WithDefaultState(){} // RVA: 0x7ffaaefaba20
    public void WithMinAndMax(){} // RVA: 0x7ffaaefaba60
    public void WithProcessor(){} // RVA: 0x7ffaa887e5c0
    public void IsNoisy(){} // RVA: 0x7ffaaefabaa0
    public void IsSynthetic(){} // RVA: 0x7ffaaefabad0
    public void IsButton(){} // RVA: 0x7ffaaefabb70
    public void Finish(){} // RVA: 0x7ffaaefabbb0
    // ── Binary Analysis Named ──
    public void DontReset(){} // RVA: 0x7ffaaefabb10
}

public class ControlDataForExport : Object
{
    public object leftEyePath; // 0x33F9CDD0
    public object maxEyeDownBoneAngle; // 0x33F9CDD0
    public object isEyeBallDefaultSet; // 0x33F9CDD0
    public object isEyeBoneLookUpSet; // 0x33F9CDD0
    public object leftBoneEyeRotationLimiter; // 0x33F9CDD0
    public object rightEyeballEyeRotationLimiter; // 0x33F9CDD0
    public object upperEyeLidLeftPath; // 0x33F9CDD0
    public object lowerEyeLidRightPath; // 0x33F9CDD0
    public object isEyelidBonesLookUpSet; // 0x33F9CDD0
    public object upperRightLimiter; // 0x33F9CDD0
    public object eyeWidenOrSquint; // 0x33F9CDD0
    public object blendshapesForLookingDown; // 0x33F9CDD0
    public object isEyelidBlendshapeClosedSet; // 0x33F9CDD0
    public object MecanimEyeBones; // 0x33F9CF50
    public object value__; // 0x33F9D200
    public object Blendshapes; // 0x33F9D200
    public object RotationAndPosition; // 0x33F9D4B0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class ControlItem : ValueType
{
    public object _variants; // 0x33BBE360, was: <variants>k__BackingField
    public object _shortDisplayName; // 0x33BBE360, was: <shortDisplayName>k__BackingFi
    public object _parameters; // 0x33BBE360, was: <parameters>k__BackingField
    public object _bit; // 0x33BBE360, was: <bit>k__BackingField
    public object _flags; // 0x33BBE360, was: <flags>k__BackingField
    public object _minValue; // 0x33BBE360, was: <minValue>k__BackingField
    public object m_StartIndex; // 0x360ED500

    // ── Original Methods ──
    public void get_name(){} // RVA: 0x7ffaa8ce3e60
    public void set_name(){} // RVA: 0x7ffaaa4a3e50
    public void get_layout(){} // RVA: 0x7ffaa9e49b20
    public void set_layout(){} // RVA: 0x7ffaaa49cf60
    public void get_variants(){} // RVA: 0x7ffaaa4204b0
    public void set_variants(){} // RVA: 0x7ffaaa4204c0
    public void get_useStateFrom(){} // RVA: 0x7ffaa8bfcc80
    public void set_useStateFrom(){} // RVA: 0x7ffaa8960890
    public void get_displayName(){} // RVA: 0x7ffaa8bf45b0
    public void set_displayName(){} // RVA: 0x7ffaa8bf45c0
    public void get_shortDisplayName(){} // RVA: 0x7ffaa89af740
    public void set_shortDisplayName(){} // RVA: 0x7ffaa895a200
    public void get_usages(){} // RVA: 0x7ffaaa481ea0
    public void set_usages(){} // RVA: 0x7ffaaf0b1330
    public void get_aliases(){} // RVA: 0x7ffaa95fffb0
    public void set_aliases(){} // RVA: 0x7ffaaf0b1390
    public void get_parameters(){} // RVA: 0x7ffaab9e9f20
    public void set_parameters(){} // RVA: 0x7ffaab9e9f30
    public void get_processors(){} // RVA: 0x7ffaae455040
    public void set_processors(){} // RVA: 0x7ffaaf0b13f0
    public void get_offset(){} // RVA: 0x7ffaa9221d50
    public void set_offset(){} // RVA: 0x7ffaa92217c0
    public void get_bit(){} // RVA: 0x7ffaab965cc0
    public void set_bit(){} // RVA: 0x7ffaabfb3540
    public void get_sizeInBits(){} // RVA: 0x7ffaa8c4abe0
    public void set_sizeInBits(){} // RVA: 0x7ffaa8efe560
    public void get_format(){} // RVA: 0x7ffaa8c4abd0
    public void set_format(){} // RVA: 0x7ffaa8e5e660
    public void get_flags(){} // RVA: 0x7ffaaa2a8330
    public void set_flags(){} // RVA: 0x7ffaaa2a8340
    public void get_arraySize(){} // RVA: 0x7ffaaa2a7db0
    public void set_arraySize(){} // RVA: 0x7ffaaa2a7dc0
    public void get_defaultState(){} // RVA: 0x7ffaae2e8390
    public void set_defaultState(){} // RVA: 0x7ffaae2e83a0
    public void get_minValue(){} // RVA: 0x7ffaa90be220
    public void set_minValue(){} // RVA: 0x7ffaa90bec80
    public void get_maxValue(){} // RVA: 0x7ffaae56f2d0
    public void set_maxValue(){} // RVA: 0x7ffaae56f2e0
    public void get_isModifyingExistingControl(){} // RVA: 0x7ffaaf0b1450
    public void set_isModifyingExistingControl(){} // RVA: 0x7ffaaf0b1460
    public void get_isNoisy(){} // RVA: 0x7ffaaf0b1480
    public void set_isNoisy(){} // RVA: 0x7ffaaf0b1490
    public void get_isSynthetic(){} // RVA: 0x7ffaaf0b14b0
    public void set_isSynthetic(){} // RVA: 0x7ffaaf0b14c0
    public void get_dontReset(){} // RVA: 0x7ffaaf0b14e0
    public void set_dontReset(){} // RVA: 0x7ffaaf0b14f0
    public void get_isFirstDefinedInThisLayout(){} // RVA: 0x7ffaaf0b1510
    public void set_isFirstDefinedInThisLayout(){} // RVA: 0x7ffaaf0b1520
    public void get_isArray(){} // RVA: 0x7ffaaf0b1540
    public void Merge(){} // RVA: 0x7ffaaf0b1550
}

public class ControlItemJson : Object
{
    public object variants; // 0x33BBE7E0
    public object useStateFrom; // 0x33BBE7E0
    public object sizeInBits; // 0x33BBE7E0
    public object usages; // 0x33BBE7E0
    public object processors; // 0x33BBE7E0
    public object noisy; // 0x33BBE7E0
    public object defaultState; // 0x33BBE7E0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf0b5040
    public void ToLayout(){} // RVA: 0x7ffaaf0b5050
    public void FromControlItems(){} // RVA: 0x7ffaaf0b5e30
}

public class ControlSchemeSyntax : ValueType
{
    public object m_ControlScheme; // 0x31A644C0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaef63d90
    public void .ctor(){} // RVA: 0x7ffaaef63d90
    public void WithBindingGroup(){} // RVA: 0x7ffaaef63e60
    public void WithRequiredDevice(){} // RVA: 0x7ffaaef64060
    public void WithOptionalDevice(){} // RVA: 0x7ffaaef640b0
    public void OrWithRequiredDevice(){} // RVA: 0x7ffaaef64100
    public void OrWithOptionalDevice(){} // RVA: 0x7ffaaef64150
    public void WithRequiredDevice(){} // RVA: 0x7ffaaef64060
    public void WithOptionalDevice(){} // RVA: 0x7ffaaef640b0
    public void OrWithRequiredDevice(){} // RVA: 0x7ffaaef64100
    public void OrWithOptionalDevice(){} // RVA: 0x7ffaaef64150
    public void DeviceTypeToControlPath(){} // RVA: 0x7ffaa86491d0
    public void AddDeviceEntry(){} // RVA: 0x7ffaaef642d0
    // ── Binary Analysis Named ──
    public void Done(){} // RVA: 0x7ffaaef641a0
}

public class CounterItem : Object
{
    // ── Original Methods ──
    public void get_Value(){} // RVA: 0x7ffaa8649ca0
    public void Add(){} // RVA: 0x7ffaa8661210
    public void Increment(){} // RVA: 0x7ffaa8660cc0
    public void ReadAndReset(){} // RVA: 0x7ffaa8649ca0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class CreatePipelineDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa214cc0
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa9655380
}

public class CreateRigDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa214cc0
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa9655380
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa887e5c0
}

public class CullStateChangedEvent : UnityEvent`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf676df0
}

public class CustomBlend : ValueType
{
    public object m_Blend; // 0x34B458C0
}

public class CustomBlendable : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa95e0660
}

public class CustomDataModule : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa930eca0
    public void get_enabled(){} // RVA: 0x7ffaaf37e980
    public void set_enabled(){} // RVA: 0x7ffaaf37e9d0
    public void get_enabled_Injected(){} // RVA: 0x7ffaaf37e980
    public void set_enabled_Injected(){} // RVA: 0x7ffaaf37e9d0
    // ── Binary Analysis Named ──
    public void SetMode(){} // RVA: 0x7ffaaf37ea30
    public void GetMode(){} // RVA: 0x7ffaaf37eaa0
    public void SetVectorComponentCount(){} // RVA: 0x7ffaaf37eb00
    public void GetVectorComponentCount(){} // RVA: 0x7ffaaf37eb70
    public void SetVector(){} // RVA: 0x7ffaaf37ebd0
    public void GetVector(){} // RVA: 0x7ffaaf37ec50
    public void SetColor(){} // RVA: 0x7ffaaf37ece0
    public void GetColor(){} // RVA: 0x7ffaaf37ed50
    public void SetMode_Injected(){} // RVA: 0x7ffaaf37ea30
    public void GetMode_Injected(){} // RVA: 0x7ffaaf37eaa0
    public void SetVectorComponentCount_Injected(){} // RVA: 0x7ffaaf37eb00
    public void GetVectorComponentCount_Injected(){} // RVA: 0x7ffaaf37eb70
    public void SetVector_Injected(){} // RVA: 0x7ffaaf37ede0
    public void GetVector_Injected(){} // RVA: 0x7ffaaf37ee60
    public void SetColor_Injected(){} // RVA: 0x7ffaaf37eee0
    public void GetColor_Injected(){} // RVA: 0x7ffaaf37ef50
}

public class CustomEmojiParticleSystemList : ScriptableObject
{
    // ── Original Methods ──
    public void IndexOf(){} // RVA: 0x7ffaa9de5360
    public void CreateInstance(){} // RVA: 0x7ffaa9de5430
    public void Equals(){} // RVA: 0x7ffaa9de5500
    public void CreateScriptableObject(){} // RVA: 0x7ffaa9de56e0
    public void set_Count(){} // RVA: 0x7ffaa9de5bc0
    public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    public void get_Count(){} // RVA: 0x7ffaa9de5bc0
    public void ToString(){} // RVA: 0x7ffaa9de5c10
    // ── Binary Analysis Named ──
    public void DoGetFormattedFallbackText(){} // RVA: 0x7ffaa9de57b0
    public void DoCompareOrdinalHelper(){} // RVA: 0x7ffaa9de5a00
    public void GetHashCode(){} // RVA: 0x7ffaa9de5bd0
    public void DoThrowArgumentException(){} // RVA: 0x7ffaa9de5ce0
    public void GetItemByIndex(){} // RVA: 0x7ffaa9de5ee0
}
