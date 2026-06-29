// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 611

public class COpenVRContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEE4AF50
    public void Clear(){} // RVA: 0x7AEE4AF60
    public void CheckClear(){} // RVA: 0x7AEE4B540
    public void VRSystem(){} // RVA: 0x7AEE4B600
    public void VRChaperone(){} // RVA: 0x7AEE4B8F0
    public void VRChaperoneSetup(){} // RVA: 0x7AEE4BB70
    public void VRCompositor(){} // RVA: 0x7AEE4BE30
    public void VRHeadsetView(){} // RVA: 0x7AEE4C0F0
    public void VROverlay(){} // RVA: 0x7AEE4C370
    public void VROverlayView(){} // RVA: 0x7AEE4C630
    public void VRRenderModels(){} // RVA: 0x7AEE4C8A0
    public void VRExtendedDisplay(){} // RVA: 0x7AEE4CB60
    public void VRSettings(){} // RVA: 0x7AEE4CDD0
    public void VRApplications(){} // RVA: 0x7AEE4D060
    public void VRScreenshots(){} // RVA: 0x7AEE4D340
    public void VRTrackedCamera(){} // RVA: 0x7AEE4D5C0
    public void VRInput(){} // RVA: 0x7AEE4D850
    public void VRIOBuffer(){} // RVA: 0x7AEE4DB10
    public void VRSpatialAnchors(){} // RVA: 0x7AEE4DD80
    public void VRDebug(){} // RVA: 0x7AEE4DFF0
    public void VRNotifications(){} // RVA: 0x7AEE4E260
}

public class CacheCurve : Object
{
    // ── Methods ──
    public void get_Count(){} // RVA: 0x7A9B2CE00
    public void .ctor(){} // RVA: 0x7A9B2CE50
    public void Add(){} // RVA: 0x7A9B2CF70
    public void AddUntil(){} // RVA: 0x7A9B2D060
    public void Evaluate(){} // RVA: 0x7A9B2D360
}

public class CacheEntry : Object
{
    // ── Methods ──
    public void AddRawItem(){} // RVA: 0x7A9B2D770
    public void CreateCurves(){} // RVA: 0x7A9B2DBC0
    public void .ctor(){} // RVA: 0x7A9B2E090
}

public class CacheEntry : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7FC4E40
    public void get_TTL(){} // RVA: 0x7A7FC4E50
    public void get_Valid(){} // RVA: 0x7A7FC4E60
    public void CompareTo(){} // RVA: 0x7A7FC4E80
    public void Equals(){} // RVA: 0x7A7FC4F30
}

public class Cache`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class CachedCodeEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE9F6350
}

public class CachedCodeEntryKey : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7C77620
    public void Equals(){} // RVA: 0x7A7E9D760
    public void op_Equality(){} // RVA: 0x7AE9F62B0
    public void GetHashCode(){} // RVA: 0x7A7E9D790
}

public class CachedData : Object
{
    // ── Methods ──
    public void GetCurrentOneYearLocal(){} // RVA: 0x7ADB59460
    public void GetOneYearLocalFromUtc(){} // RVA: 0x7ADB595D0
    public void CreateLocal(){} // RVA: 0x7ADB59890
    public void get_Local(){} // RVA: 0x7ADB59AF0
    public void GetCorrespondingKind(){} // RVA: 0x7ADB59B20
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class CalcProximity_000001D5$BurstDirectCall : Object
{
    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7AF476200
    public void GetFunctionPointer(){} // RVA: 0x7AF476340
    public void Constructor(){} // RVA: 0x7AF4764C0
    public void Initialize(){} // RVA: 0x7A80D7310
    public void .cctor(){} // RVA: 0x7AF4764C0
    public void Invoke(){} // RVA: 0x7AF476580
}

public class Callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DFE0
    public void Invoke(){} // RVA: 0x7A7E18800
    public void BeginInvoke(){} // RVA: 0x7A7E06710
    public void EndInvoke(){} // RVA: 0x7A7E18800
}

public class CallbackContext : ValueType
{
    // ── Methods ──
    public void get_actionIndex(){} // RVA: 0x7A75FEFA0
    public void get_bindingIndex(){} // RVA: 0x7A7EA4A60
    public void get_controlIndex(){} // RVA: 0x7A7EA4A90
    public void get_interactionIndex(){} // RVA: 0x7A7EA4AD0
    public void get_phase(){} // RVA: 0x7A7EA4B10
    public void get_started(){} // RVA: 0x7A7EA4B30
    public void get_performed(){} // RVA: 0x7A7EA4B60
    public void get_canceled(){} // RVA: 0x7A7EA4B90
    public void get_action(){} // RVA: 0x7A7EA4BC0
    public void get_control(){} // RVA: 0x7A7EA4BF0
    public void get_interaction(){} // RVA: 0x7A7EA4C00
    public void get_time(){} // RVA: 0x7A7EA4C60
    public void get_startTime(){} // RVA: 0x7A7EA4C90
    public void get_duration(){} // RVA: 0x7A7EA4CC0
    public void get_valueType(){} // RVA: 0x7A7EA4D10
    public void get_valueSizeInBytes(){} // RVA: 0x7A7EA4D70
    public void ReadValue(){} // RVA: 0x7A773E110
    public void ReadValueAsButton(){} // RVA: 0x7A7EA4D90
    public void ReadValueAsObject(){} // RVA: 0x7A7EA4DA0
    public void ToString(){} // RVA: 0x7A7EA4DB0
}

public class Callback[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class Callback[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class CameraCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8132FA0
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CanceledResultSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
    public void GetResult(){} // RVA: 0x7AEAE7BE0
    public void GetStatus(){} // RVA: 0x7A87EE0F0
    public void UnsafeGetStatus(){} // RVA: 0x7A87EE0F0
    public void OnCompleted(){} // RVA: 0x7AB10E320
    public void cancellationToken(){} // RVA: 0x7B3FA72E8
}

public class CanceledResultSource`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E188D0
    public void GetResult(){} // RVA: 0x7A8051B10
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7A7E18950
    public void GetStatus(){} // RVA: 0x7A7E015F0
    public void UnsafeGetStatus(){} // RVA: 0x7A7E00710
    public void OnCompleted(){} // RVA: 0x7A7E22030
}

public class CanceledUniTaskCache`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class CancellationTokenDisposable : Object
{
    // ── Methods ──
    public void get_Token(){} // RVA: 0x7A8051B10
    public void Dispose(){} // RVA: 0x7A7E18770
    public void .ctor(){} // RVA: 0x7A7E18770
}

public class CanvasInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class CastInstructionT`1 : CastInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7A7E01630
    public void .ctor(){} // RVA: 0x7A7E18770
}

public class CategoryPrefix : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7FC5C00
}

public class ChainItemInfo : ValueType
{
    // ── Methods ──
    public void get_Order(){} // RVA: 0x7A765F070
    public void get_ImplementationType(){} // RVA: 0x7A765F080
    public void .ctor(){} // RVA: 0x7A790A7A0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AC386470
    public void Invoke(){} // RVA: 0x7AB4CD710
    public void BeginInvoke(){} // RVA: 0x7AE2C9BD0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AC3865E0
    public void Invoke(){} // RVA: 0x7AC386750
    public void BeginInvoke(){} // RVA: 0x7AE2D23D0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AC386770
    public void Invoke(){} // RVA: 0x7AC3868E0
    public void BeginInvoke(){} // RVA: 0x7AE2D2FD0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class ChangeTokenRegistration`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8051B10
    public void OnChangeTokenFired(){} // RVA: 0x7A7E18770
    public void RegisterChangeTokenCallback(){} // RVA: 0x7A7E18800
    public void SetDisposable(){} // RVA: 0x7A7E18800
    public void Dispose(){} // RVA: 0x7A7E18770
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class ChangeTrackerDisposable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E18890
    public void OnChange(){} // RVA: 0x7A8051B10
    public void Dispose(){} // RVA: 0x7A7E18770
}

public class ChangeTrackerDisposable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9A41AA0
    public void OnChange(){} // RVA: 0x7ACF647F0
    public void Dispose(){} // RVA: 0x7AD53E410
}

public class ChannelTransformer`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DFE0
    public void Invoke(){} // RVA: 0x7A8051B10
}

public class ChildrenSection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E18770
    public void get_SettingComponents(){} // RVA: 0x7A7E00680
    public void set_SettingComponents(){} // RVA: 0x7A7E00680
    public void get_ValueToAppear(){} // RVA: 0x7A8051B10
    public void set_ValueToAppear(){} // RVA: 0x7A7E00680
    public void IsNativeObjectAlive(){} // RVA: 0x7A7E00680
    public void GetCachedPtr(){} // RVA: 0x7A7E00680
    public void get_name(){} // RVA: 0x7A7E00680
    public void set_name(){} // RVA: 0x7A7E00680
    public void Instantiate(){} // RVA: 0x7A7E00680
}

public class ChildrenSection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
    public void get_SettingComponents(){} // RVA: 0x7A81052C0
    public void set_SettingComponents(){} // RVA: 0x7A81052C0
    public void get_ValueToAppear(){} // RVA: 0x7A83782A0
    public void set_ValueToAppear(){} // RVA: 0x7A81052C0
    public void IsNativeObjectAlive(){} // RVA: 0x7A81052C0
    public void GetCachedPtr(){} // RVA: 0x7A81052C0
    public void get_name(){} // RVA: 0x7A81052C0
    public void set_name(){} // RVA: 0x7A81052C0
    public void Instantiate(){} // RVA: 0x7A81052C0
}

public class ChildrenSection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
    public void get_SettingComponents(){} // RVA: 0x7A81052C0
    public void set_SettingComponents(){} // RVA: 0x7A81052C0
    public void get_ValueToAppear(){} // RVA: 0x7A80F26D0
    public void set_ValueToAppear(){} // RVA: 0x7A81052C0
    public void IsNativeObjectAlive(){} // RVA: 0x7A81052C0
    public void GetCachedPtr(){} // RVA: 0x7A81052C0
    public void get_name(){} // RVA: 0x7A81052C0
    public void set_name(){} // RVA: 0x7A81052C0
    public void Instantiate(){} // RVA: 0x7A81052C0
}

public class CinemachineCameraOffset : CinemachineExtension
{
    // ── Methods ──
    public void PostPipelineStageCallback(){} // RVA: 0x7A9AC8B90
    public void .ctor(){} // RVA: 0x7A9AC9140
}

public class CinemachineMixer : PlayableBehaviour
{
    // ── Methods ──
    public void OnPlayableDestroy(){} // RVA: 0x7A9AC9C20
    public void PrepareFrame(){} // RVA: 0x7A9AC9C80
    public void ProcessFrame(){} // RVA: 0x7A9AC9C90
    public void GetDeltaTime(){} // RVA: 0x7A9ACA660
    public void .ctor(){} // RVA: 0x7A9ACA7B0
}

public class CinemachineRecomposer : CinemachineExtension
{
    // ── Methods ──
    public void Reset(){} // RVA: 0x7A9AC91D0
    public void OnValidate(){} // RVA: 0x7A9AC9200
    public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7A9AC9260
    public void PostPipelineStageCallback(){} // RVA: 0x7A9AC9280
    public void .ctor(){} // RVA: 0x7A80D7D60
}

public class CinemachineShot : PlayableAsset
{
    // ── Methods ──
    public void CreatePlayable(){} // RVA: 0x7A9ACA7C0
    public void GatherProperties(){} // RVA: 0x7A9ACAA40
    public void .ctor(){} // RVA: 0x7A82F4A40
}

public class CinemachineShotPlayable : PlayableBehaviour
{
    // ── Methods ──
    public void get_IsValid(){} // RVA: 0x7A9ACAC20
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class CinemachineTouchInputMapper : MonoBehaviour
{
    // ── Methods ──
    public void Start(){} // RVA: 0x7A9AC9850
    public void GetInputAxis(){} // RVA: 0x7A9AC9950
    public void .ctor(){} // RVA: 0x7A9AC9AD0
}

public class CinemachineTrack : TrackAsset
{
    // ── Methods ──
    public void CreateTrackMixer(){} // RVA: 0x7A9ACACF0
    public void .ctor(){} // RVA: 0x7A9ACAE30
}

public class ClaimNetworkControlDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98B8320
    public void Invoke(){} // RVA: 0x7A82344F0
    public void BeginInvoke(){} // RVA: 0x7A98B8490
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class Clipper : ClipperBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9B3E490
    public void InsertMaxima(){} // RVA: 0x7A9B3EAB0
    public void get_ReverseSolution(){} // RVA: 0x7A99A0EA0
    public void set_ReverseSolution(){} // RVA: 0x7A99A1F70
    public void get_StrictlySimple(){} // RVA: 0x7A924A130
    public void set_StrictlySimple(){} // RVA: 0x7A9B3EED0
    public void Execute(){} // RVA: 0x7A9B3F0D0
    public void FixHoleLinkage(){} // RVA: 0x7A9B3F1B0
    public void ExecuteInternal(){} // RVA: 0x7A9B3F250
    public void DisposeAllPolyPts(){} // RVA: 0x7A9B3F8F0
    public void AddJoin(){} // RVA: 0x7A9B3FAA0
    public void AddGhostJoin(){} // RVA: 0x7A9B3FBF0
    public void InsertLocalMinimaIntoAEL(){} // RVA: 0x7A9B3FCE0
    public void InsertEdgeIntoAEL(){} // RVA: 0x7A9B403D0
    public void E2InsertsBeforeE1(){} // RVA: 0x7A9B40790
    public void IsEvenOddFillType(){} // RVA: 0x7A9B408A0
    public void IsEvenOddAltFillType(){} // RVA: 0x7A9B408D0
    public void IsContributing(){} // RVA: 0x7A9B40900
    public void SetWindingCount(){} // RVA: 0x7A9B40AB0
    public void AddEdgeToSEL(){} // RVA: 0x7A9B40CF0
    public void PopEdgeFromSEL(){} // RVA: 0x7A9B40FB0
    public void CopyAELToSEL(){} // RVA: 0x7A9B411C0
    public void SwapPositionsInSEL(){} // RVA: 0x7A9B412F0
    public void AddLocalMaxPoly(){} // RVA: 0x7A9B41720
    public void AddLocalMinPoly(){} // RVA: 0x7A9B417E0
    public void AddOutPt(){} // RVA: 0x7A9B41B30
    public void GetLastOutPt(){} // RVA: 0x7A9B41F50
    public void SwapPoints(){} // RVA: 0x7A9B41FF0
    public void HorzSegmentsOverlap(){} // RVA: 0x7A9B42020
    public void SetHoleState(){} // RVA: 0x7A9B42060
    public void GetDx(){} // RVA: 0x7A9B42230
    public void FirstIsBottomPt(){} // RVA: 0x7A9B42270
    public void GetBottomPt(){} // RVA: 0x7A9B426B0
    public void GetLowermostRec(){} // RVA: 0x7A9B427A0
    public void OutRec1RightOfOutRec2(){} // RVA: 0x7A9B42920
    public void GetOutRec(){} // RVA: 0x7A9B42950
    public void AppendPolygon(){} // RVA: 0x7A9B42A10
    public void ReversePolyPtLinks(){} // RVA: 0x7A9B43A20
    public void SwapSides(){} // RVA: 0x7A9B43B20
    public void SwapPolyIndexes(){} // RVA: 0x7A9B43B50
    public void IntersectEdges(){} // RVA: 0x7A9B43B80
    public void DeleteFromSEL(){} // RVA: 0x7A9B44170
    public void ProcessHorizontals(){} // RVA: 0x7A9B44390
    public void GetHorzDirection(){} // RVA: 0x7A9B445E0
    public void ProcessHorizontal(){} // RVA: 0x7A9B44640
    public void GetNextInAEL(){} // RVA: 0x7A9B45010
    public void IsMinima(){} // RVA: 0x7A9B45040
    public void IsMaxima(){} // RVA: 0x7A9B45080
    public void IsIntermediate(){} // RVA: 0x7A9B450B0
    public void GetMaximaPair(){} // RVA: 0x7A9B450F0
    public void GetMaximaPairEx(){} // RVA: 0x7A9B45170
    public void ProcessIntersections(){} // RVA: 0x7A9B45230
    public void BuildIntersectList(){} // RVA: 0x7A9B454B0
    public void EdgesAdjacent(){} // RVA: 0x7A9B45880
    public void IntersectNodeSort(){} // RVA: 0x7A9B458C0
    public void FixupIntersectionOrder(){} // RVA: 0x7A9B458E0
    public void ProcessIntersectList(){} // RVA: 0x7A9B45CB0
    public void Round(){} // RVA: 0x7A9B45E10
    public void TopX(){} // RVA: 0x7A9B45E40
    public void IntersectPoint(){} // RVA: 0x7A9B45EB0
    public void ProcessEdgesAtTopOfScanbeam(){} // RVA: 0x7A9B46330
    public void DoMaxima(){} // RVA: 0x7A9B469A0
    public void ReversePaths(){} // RVA: 0x7A9B46C00
    public void Orientation(){} // RVA: 0x7A9B46E90
    public void PointCount(){} // RVA: 0x7A9B46EB0
    public void BuildResult(){} // RVA: 0x7A9B46EE0
    public void BuildResult2(){} // RVA: 0x7A9B47140
    public void FixupOutPolyline(){} // RVA: 0x7A9B474E0
    public void FixupOutPolygon(){} // RVA: 0x7A9B47600
    public void DupOutPt(){} // RVA: 0x7A9B47B00
    public void GetOverlap(){} // RVA: 0x7A9B47E40
    public void JoinHorz(){} // RVA: 0x7A9B47F60
    public void JoinPoints(){} // RVA: 0x7A9B48550
    public void PointInPolygon(){} // RVA: 0x7A9B49990
    public void Poly2ContainsPoly1(){} // RVA: 0x7A9B49AE0
    public void FixupFirstLefts1(){} // RVA: 0x7A9B49C70
    public void FixupFirstLefts2(){} // RVA: 0x7A9B49E30
    public void FixupFirstLefts3(){} // RVA: 0x7A9B4A080
    public void ParseFirstLeft(){} // RVA: 0x7A9B4A230
    public void JoinCommonEdges(){} // RVA: 0x7A9B4A250
    public void UpdateOutPtIdxs(){} // RVA: 0x7A9B4AC40
    public void DoSimplePolygons(){} // RVA: 0x7A9B4AC70
    public void Area(){} // RVA: 0x7A9B4B1A0
    public void SimplifyPolygon(){} // RVA: 0x7A9B4B210
    public void SimplifyPolygons(){} // RVA: 0x7A9B4B310
    public void DistanceSqrd(){} // RVA: 0x7A9B4B410
    public void DistanceFromLineSqrd(){} // RVA: 0x7A9B4B450
    public void SlopesNearCollinear(){} // RVA: 0x7A9B4B4D0
    public void PointsAreClose(){} // RVA: 0x7A9B4B750
    public void ExcludeOp(){} // RVA: 0x7A9B4B790
    public void CleanPolygon(){} // RVA: 0x7A9B4B880
    public void CleanPolygons(){} // RVA: 0x7A9B4BED0
    public void Minkowski(){} // RVA: 0x7A9B4C060
    public void MinkowskiSum(){} // RVA: 0x7A9B4CBF0
    public void TranslatePath(){} // RVA: 0x7A9B4CA00
    public void MinkowskiDiff(){} // RVA: 0x7A9B4CE20
    public void PolyTreeToPaths(){} // RVA: 0x7A9B4CEF0
    public void AddPolyNodeToPaths(){} // RVA: 0x7A9B4CFB0
    public void OpenPathsFromPolyTree(){} // RVA: 0x7A9B4D1A0
    public void ClosedPathsFromPolyTree(){} // RVA: 0x7A9B4D350
}

public class ClipperBase : Object
{
    // ── Methods ──
    public void near_zero(){} // RVA: 0x7A9B399F0
    public void get_PreserveCollinear(){} // RVA: 0x7A83F4170
    public void set_PreserveCollinear(){} // RVA: 0x7A83F3DC0
    public void Swap(){} // RVA: 0x7A9B39A10
    public void IsHorizontal(){} // RVA: 0x7A9B39A20
    public void PointIsVertex(){} // RVA: 0x7A9B39A40
    public void PointOnLineSegment(){} // RVA: 0x7A9B39A90
    public void PointOnPolygon(){} // RVA: 0x7A9B39C50
    public void SlopesEqual(){} // RVA: 0x7A9B3A0E0
    public void .ctor(){} // RVA: 0x7A9B3A220
    public void Clear(){} // RVA: 0x7A9B3A390
    public void DisposeLocalMinimaList(){} // RVA: 0x7A9B3A680
    public void RangeTest(){} // RVA: 0x7A9B3A7C0
    public void InitEdge(){} // RVA: 0x7A9B3A8A0
    public void InitEdge2(){} // RVA: 0x7A9B3A980
    public void FindNextLocMin(){} // RVA: 0x7A9B3AA30
    public void ProcessBound(){} // RVA: 0x7A9B3AB40
    public void AddPath(){} // RVA: 0x7A9B3B1E0
    public void AddPaths(){} // RVA: 0x7A9B3C600
    public void Pt2IsBetweenPt1AndPt3(){} // RVA: 0x7A9B3C6F0
    public void RemoveEdge(){} // RVA: 0x7A9B3C760
    public void SetDx(){} // RVA: 0x7A9B3C8B0
    public void InsertLocalMinima(){} // RVA: 0x7A9B3C910
    public void PopLocalMinima(){} // RVA: 0x7A9B3CB30
    public void ReverseHorizontal(){} // RVA: 0x7A9B3CC20
    public void Reset(){} // RVA: 0x7A9B3CC50
    public void GetBounds(){} // RVA: 0x7A9B3D0C0
    public void InsertScanbeam(){} // RVA: 0x7A9B3D500
    public void PopScanbeam(){} // RVA: 0x7A9B3D800
    public void LocalMinimaPending(){} // RVA: 0x7A9B3D890
    public void CreateOutRec(){} // RVA: 0x7A9B3D8A0
    public void DisposeOutRec(){} // RVA: 0x7A9B3DAD0
    public void UpdateEdgeIntoAEL(){} // RVA: 0x7A9B3DBE0
    public void SwapPositionsInAEL(){} // RVA: 0x7A9B3DFB0
    public void DeleteFromAEL(){} // RVA: 0x7A9B3E270
}

public class ClipperException : Exception
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9B51D50
}

public class ClipperOffset : Object
{
    // ── Methods ──
    public void get_ArcTolerance(){} // RVA: 0x7A9B4D410
    public void set_ArcTolerance(){} // RVA: 0x7A9B4D420
    public void get_MiterLimit(){} // RVA: 0x7A9B4D430
    public void set_MiterLimit(){} // RVA: 0x7A9B4D440
    public void .ctor(){} // RVA: 0x7A9B4D450
    public void Clear(){} // RVA: 0x7A9B4D5D0
    public void Round(){} // RVA: 0x7A9B45E10
    public void AddPath(){} // RVA: 0x7A9B4D650
    public void AddPaths(){} // RVA: 0x7A9B4DCE0
    public void FixOrientations(){} // RVA: 0x7A9B4DE70
    public void GetUnitNormal(){} // RVA: 0x7A9B4E130
    public void DoOffset(){} // RVA: 0x7A9B4E230
    public void Execute(){} // RVA: 0x7A9B4FDB0
    public void OffsetPoint(){} // RVA: 0x7A9B50510
    public void DoSquare(){} // RVA: 0x7A9B50F00
    public void DoMiter(){} // RVA: 0x7A9B514E0
    public void DoRound(){} // RVA: 0x7A9B51790
}

public class Codec : Object
{
    // ── Methods ──
    public void get_KeyCodec(){} // RVA: 0x7A7E00680
    public void get_ValueCodec(){} // RVA: 0x7A7E00680
    public void get_MapTag(){} // RVA: 0x7A7E00710
}

public class Collection : ValueType
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x7A7EBBAF0
    public void TryFindLayoutForType(){} // RVA: 0x7A7EBBB00
    public void TryFindMatchingLayout(){} // RVA: 0x7A7EBBB30
    public void HasLayout(){} // RVA: 0x7A7EBBB90
    public void TryLoadLayoutInternal(){} // RVA: 0x7A7EBBBB0
    public void TryLoadLayout(){} // RVA: 0x7A7EBBBD0
    public void GetBaseLayoutName(){} // RVA: 0x7A7EBBBF0
    public void GetRootLayoutName(){} // RVA: 0x7A7EBBC30
    public void ComputeDistanceInInheritanceHierarchy(){} // RVA: 0x7A7EBBD70
    public void FindLayoutThatIntroducesControl(){} // RVA: 0x7A7EBBDB0
    public void GetControlTypeForLayout(){} // RVA: 0x7A7EBBDE0
    public void ValueTypeIsAssignableFrom(){} // RVA: 0x7A7EBBE00
    public void IsGeneratedLayout(){} // RVA: 0x7A7EBBF10
    public void GetBaseLayouts(){} // RVA: 0x7A7EBBF90
    public void IsBasedOn(){} // RVA: 0x7A7EBC0F0
    public void AddMatcher(){} // RVA: 0x7A7EBC120
}

public class CollectionHeaderTypeInfo`2 : HeaderTypeInfo`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E223F0
    public void get_Separator(){} // RVA: 0x7A7E00680
    public void TryParse(){} // RVA: 0x7A7E01A40
}

public class CollisionEnterDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB0FF420
    public void Invoke(){} // RVA: 0x7A82344F0
    public void BeginInvoke(){} // RVA: 0x7A98B8490
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class CollisionEventsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7A7F1CA00
}

public class CollisionExitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB0FF420
    public void Invoke(){} // RVA: 0x7A82344F0
    public void BeginInvoke(){} // RVA: 0x7A98B8490
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class CollisionsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7A7F1C4F0
    public void GetCollision(){} // RVA: 0x7A7F1C500
    public void SetCollision(){} // RVA: 0x7A7F1C510
    public void FindCollision(){} // RVA: 0x7A7F1C520
}

public class ColorPaletteData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class ColorPaletteRoot : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7D60
}

public class Comparers : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E18890
    public void get_KeyComparer(){} // RVA: 0x7A7E00680
    public void get_KeyOnlyComparer(){} // RVA: 0x7A7E00680
    public void get_ValueComparer(){} // RVA: 0x7A7E00680
    public void Equals(){} // RVA: 0x7A8051B10
    public void GetHashCode(){} // RVA: 0x7A8051B10
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0x7A8051B10
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0x7A8051B10
    public void Get(){} // RVA: 0x7A7E00C10
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class Comparers : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E18890
    public void get_KeyComparer(){} // RVA: 0x7A7E00680
    public void get_KeyOnlyComparer(){} // RVA: 0x7A7E00680
    public void get_ValueComparer(){} // RVA: 0x7A7E00680
    public void get_HashBucketEqualityComparer(){} // RVA: 0x7A7E00680
    public void Equals(){} // RVA: 0x7A8051B10
    public void GetHashCode(){} // RVA: 0x7A8051B10
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0x7A8051B10
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0x7A8051B10
    public void Get(){} // RVA: 0x7A7E00C10
    public void WithValueComparer(){} // RVA: 0x7A7E00B20
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class ConfigurationListDebugView : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E18800
    public void get_Items(){} // RVA: 0x7A7E00680
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1D550
    public void get_IsCompleted(){} // RVA: 0x7A7E01900
    public void OnCompleted(){} // RVA: 0x7A7E18800
    public void UnsafeOnCompleted(){} // RVA: 0x7A7E18800
    public void GetResult(){} // RVA: 0x7A8051B10
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void OnCompleted(){} // RVA: 0x7A77D9540
    public void UnsafeOnCompleted(){} // RVA: 0x7A77D9600
    public void .ctor(){} // RVA: 0x7A76236F0
    public void get_IsCompleted(){} // RVA: 0x7A77D9530
    public void GetResult(){} // RVA: 0x7A77DBF20
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A76236F0
    public void get_IsCompleted(){} // RVA: 0x7A77D9530
    public void OnCompleted(){} // RVA: 0x7A77D9540
    public void UnsafeOnCompleted(){} // RVA: 0x7A77D9600
    public void GetResult(){} // RVA: 0x7A77DBF30
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8051B10
    public void get_IsCompleted(){} // RVA: 0x7A7E01900
    public void GetResult(){} // RVA: 0x7A8051B10
    public void OnCompleted(){} // RVA: 0x7A7E18800
    public void UnsafeOnCompleted(){} // RVA: 0x7A7E18800
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Methods ──
    public void OnCompleted(){} // RVA: 0x7A7E18800
    public void UnsafeOnCompleted(){} // RVA: 0x7A7E18800
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A76BA6C0
    public void get_IsCompleted(){} // RVA: 0x7A77E53B0
    public void GetResult(){} // RVA: 0x7A77E6B50
    public void OnCompleted(){} // RVA: 0x7A77E6BB0
    public void UnsafeOnCompleted(){} // RVA: 0x7A77E6BC0
}

public class ConnectDisposable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E18800
    public void Dispose(){} // RVA: 0x7A7E18770
}

public class ConstructJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7A7EA3D80
}

public class ConstructJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7A7EA3D80
}

public class ConstructJobList : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7A7EA3D70
}

public class ConstructJobList : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7A7EA3D70
}

public class ContainerHeight : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
    public void Initialize(){} // RVA: 0x7B0CC2880
    public void Equals(){} // RVA: 0x7B0CC2880
    public void op_Implicit(){} // RVA: 0x7B0CC2880
    public void CompareBaseObjects(){} // RVA: 0x7B0CC2880
    public void IsNativeObjectAlive(){} // RVA: 0x7B0CC2880
    public void GetCachedPtr(){} // RVA: 0x7B0CC2880
    public void set_Height(){} // RVA: 0x7B0CC2880
    public void get_Height(){} // RVA: 0x7B0CC2880
    public void Instantiate(){} // RVA: 0x7B0CC2880
}

public class ContentHeightCacheInfo : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E26420
}

public class ContentType[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class ContingentProperties : Object
{
    // ── Methods ──
    public void SetCompleted(){} // RVA: 0x7ADD3DB30
    public void UnregisterCancellationCallback(){} // RVA: 0x7ADD3DB60
    public void .ctor(){} // RVA: 0x7ADD3DC50
}

public class Control : Object
{
    // ── Methods ──
    public void GetSubParameter(){} // RVA: 0x7B185C1A0
    public void GetLabel(){} // RVA: 0x7B185C1E0
    public void .ctor(){} // RVA: 0x7A91597B0
}

public class ControlBitRangeNode : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7EB1B20
}

public class ControlBitRangeNode[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2DFFA0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29F3C0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E5490
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA29B960
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29F3C0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class ControlBuilder : ValueType
{
    // ── Methods ──
    public void get_control(){} // RVA: 0x7A765F710
    public void set_control(){} // RVA: 0x7A7637E60
    public void At(){} // RVA: 0x7A7EB0EB0
    public void WithParent(){} // RVA: 0x7A7EB0EC0
    public void WithName(){} // RVA: 0x7A7EB0ED0
    public void WithDisplayName(){} // RVA: 0x7A7EB0EE0
    public void WithShortDisplayName(){} // RVA: 0x7A7EB0EF0
    public void WithLayout(){} // RVA: 0x7A7EB0F00
    public void WithUsages(){} // RVA: 0x7A7EB0F70
    public void WithAliases(){} // RVA: 0x7A7EB0FB0
    public void WithChildren(){} // RVA: 0x7A7EB0FF0
    public void WithStateBlock(){} // RVA: 0x7A7EB1030
    public void WithDefaultState(){} // RVA: 0x7A7EB1060
    public void WithMinAndMax(){} // RVA: 0x7A7EB10B0
    public void WithProcessor(){} // RVA: 0x7A8051B10
    public void IsNoisy(){} // RVA: 0x7A7EB10F0
    public void IsSynthetic(){} // RVA: 0x7A7EB1120
    public void DontReset(){} // RVA: 0x7A7EB1160
    public void IsButton(){} // RVA: 0x7A7EB1170
    public void Finish(){} // RVA: 0x7A7EB11B0
}

public class ControlDataForExport : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class ControlSchemeSyntax : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7EAA3B0
    public void WithBindingGroup(){} // RVA: 0x7A7EAA3E0
    public void WithRequiredDevice(){} // RVA: 0x7A7EAA420
    public void WithOptionalDevice(){} // RVA: 0x7A7EAA470
    public void OrWithRequiredDevice(){} // RVA: 0x7A7EAA4C0
    public void OrWithOptionalDevice(){} // RVA: 0x7A7EAA510
    public void DeviceTypeToControlPath(){} // RVA: 0x7A7E00680
    public void Done(){} // RVA: 0x7A7EAA560
    public void AddDeviceEntry(){} // RVA: 0x7A7EAA590
}

public class ControlSurface : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class ControlSurface[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class CounterItem : Object
{
    // ── Methods ──
    public void get_Value(){} // RVA: 0x7A7E00710
    public void Add(){} // RVA: 0x7A7E189D0
    public void Increment(){} // RVA: 0x7A7E18770
    public void ReadAndReset(){} // RVA: 0x7A7E00710
    public void .ctor(){} // RVA: 0x7A7E18770
}

public class CreatePipelineDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9AE9960
    public void Invoke(){} // RVA: 0x7A8234660
    public void BeginInvoke(){} // RVA: 0x7A8F31640
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class CreateRigDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9AE9960
    public void Invoke(){} // RVA: 0x7A8234660
    public void BeginInvoke(){} // RVA: 0x7A8F31640
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DFE0
    public void Invoke(){} // RVA: 0x7A8051B10
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A98C1360
    public void Invoke(){} // RVA: 0x7A8133090
}

public class CustomBlendable : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A763CAD0
}

public class CustomEmojiParticleSystemList : ScriptableObject
{
    // ── Methods ──
    public void IndexOf(){} // RVA: 0x7A96CC7F0
    public void CreateInstance(){} // RVA: 0x7A96CC8C0
    public void .ctor(){} // RVA: 0x7A82F4A40
    public void Initialize(){} // RVA: 0x7A96CC900
    public void set_Count(){} // RVA: 0x7A96CC940
    public void Equals(){} // RVA: 0x7A96CCA10
    public void GetHashCode(){} // RVA: 0x7A96CCAE0
    public void ToString(){} // RVA: 0x7A96CC900
    public void get_Count(){} // RVA: 0x7A96CCBB0
    // ── Unresolved (hash) ──
    public void m_974(){} // RVA: 0x7A96CCBC0
    public void m_F2E(){} // RVA: 0x7A96CCE10
}
