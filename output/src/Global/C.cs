// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 591

public class COpenVRContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ACD600
    public void Clear(){} // RVA: 0x7ACD610
    public void CheckClear(){} // RVA: 0x7ACDBF0
    public void VRSystem(){} // RVA: 0x7ACDCB0
    public void VRChaperone(){} // RVA: 0x7ACDF70
    public void VRChaperoneSetup(){} // RVA: 0x7ACE1C0
    public void VRCompositor(){} // RVA: 0x7ACE450
    public void VRHeadsetView(){} // RVA: 0x7ACE6E0
    public void VROverlay(){} // RVA: 0x7ACE930
    public void VROverlayView(){} // RVA: 0x7ACEBC0
    public void VRRenderModels(){} // RVA: 0x7ACEE00
    public void VRExtendedDisplay(){} // RVA: 0x7ACF090
    public void VRSettings(){} // RVA: 0x7ACF2D0
    public void VRApplications(){} // RVA: 0x7ACF530
    public void VRScreenshots(){} // RVA: 0x7ACF7E0
    public void VRTrackedCamera(){} // RVA: 0x7ACFA30
    public void VRInput(){} // RVA: 0x7ACFC90
    public void VRIOBuffer(){} // RVA: 0x7ACFF20
    public void VRSpatialAnchors(){} // RVA: 0x7AD0160
    public void VRDebug(){} // RVA: 0x7AD03A0
    public void VRNotifications(){} // RVA: 0x7AD05E0
}

public class CacheCurve : Object
{
    // ── Methods ──
    public void get_Count(){} // RVA: 0x25D8AD0
    public void .ctor(){} // RVA: 0x25D8B20
    public void Add(){} // RVA: 0x25D8C40
    public void AddUntil(){} // RVA: 0x25D8D30
    public void Evaluate(){} // RVA: 0x25D9030
}

public class CacheEntry : Object
{
    // ── Methods ──
    public void AddRawItem(){} // RVA: 0x25D9440
    public void CreateCurves(){} // RVA: 0x25D9980
    public void .ctor(){} // RVA: 0x25D9E50
}

public class CacheEntry : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA73620
    public void get_TTL(){} // RVA: 0xA73630
    public void get_Valid(){} // RVA: 0xA73640
    public void CompareTo(){} // RVA: 0xA73660
    public void Equals(){} // RVA: 0xA73710
}

public class CacheEntry[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class CachedCodeEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7668460
}

public class CachedCodeEntryKey : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6E7490
    public void Equals(){} // RVA: 0x91DC40
    public void op_Equality(){} // RVA: 0x76683C0
    public void GetHashCode(){} // RVA: 0x91DC70
}

public class CachedData : Object
{
    // ── Methods ──
    public void GetCurrentOneYearLocal(){} // RVA: 0x67E4030
    public void GetOneYearLocalFromUtc(){} // RVA: 0x67E41A0
    public void CreateLocal(){} // RVA: 0x67E4460
    public void get_Local(){} // RVA: 0x67E46C0
    public void GetCorrespondingKind(){} // RVA: 0x67E46F0
    public void .ctor(){} // RVA: 0xB43310
}

public class Callback : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x76310
    public void Invoke(){} // RVA: 0x922CD0
}

public class CallbackContext : ValueType
{
    // ── Methods ──
    public void ReadValue(){} // RVA: 0xA94080
    public void get_actionIndex(){} // RVA: 0x14790
    public void get_bindingIndex(){} // RVA: 0x924C40
    public void get_controlIndex(){} // RVA: 0x924C70
    public void get_interactionIndex(){} // RVA: 0x924CB0
    public void get_phase(){} // RVA: 0x924CF0
    public void get_started(){} // RVA: 0x924D10
    public void get_performed(){} // RVA: 0x924D40
    public void get_canceled(){} // RVA: 0x924D70
    public void get_action(){} // RVA: 0x924DA0
    public void get_control(){} // RVA: 0x924DD0
    public void get_interaction(){} // RVA: 0x924DE0
    public void get_time(){} // RVA: 0x924E40
    public void get_startTime(){} // RVA: 0x924E70
    public void get_duration(){} // RVA: 0x924EA0
    public void get_valueType(){} // RVA: 0x924EF0
    public void get_valueSizeInBytes(){} // RVA: 0x924F50
    public void ReadValueAsButton(){} // RVA: 0x924F70
    public void ReadValueAsObject(){} // RVA: 0x924F80
    public void ToString(){} // RVA: 0x924F90
}

public class Callback[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Callback[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class CameraCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
}

public class CanceledResultSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void GetResult(){} // RVA: 0x7756BD0
    public void GetStatus(){} // RVA: 0x12FC4A0
    public void UnsafeGetStatus(){} // RVA: 0x12FC4A0
    public void OnCompleted(){} // RVA: 0x3DC7FC0
}

public class CanvasInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class CastDataSourceVisitor : ConcreteTypeVisitor
{
    // ── Methods ──
    public void get_Binding(){} // RVA: 0xB5DBF0
    public void set_Binding(){} // RVA: 0xB44D60
    public void get_bindingContext(){} // RVA: 0x7E55C30
    public void set_bindingContext(){} // RVA: 0x7E55CC0
    public void get_result(){} // RVA: 0x6D09B60
    public void set_result(){} // RVA: 0x7E55DA0
    public void Reset(){} // RVA: 0x7E55E00
    public void VisitContainer(){} // RVA: 0x894320
    public void .ctor(){} // RVA: 0xB43310
}

public class CategoryPrefix : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA743E0
}

public class CenterProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7D61B10
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7D61B50
    public void SetValue(){} // RVA: 0x7D61B70
    public void .ctor(){} // RVA: 0x7D61B90
}

public class ChainItemInfo : ValueType
{
    // ── Methods ──
    public void get_Order(){} // RVA: 0x77E60
    public void get_ImplementationType(){} // RVA: 0x77ED0
    public void .ctor(){} // RVA: 0x3616C0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2370
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6F15870
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095CF0
    public void Invoke(){} // RVA: 0x40E51E0
    public void BeginInvoke(){} // RVA: 0x6F1D530
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095E60
    public void Invoke(){} // RVA: 0x5095FD0
    public void BeginInvoke(){} // RVA: 0x6F3E0D0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2370
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x6F45B00
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095CF0
    public void Invoke(){} // RVA: 0x40E51E0
    public void BeginInvoke(){} // RVA: 0x6F48980
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095E60
    public void Invoke(){} // RVA: 0x5095FD0
    public void BeginInvoke(){} // RVA: 0x6F51210
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5095FF0
    public void Invoke(){} // RVA: 0x5096160
    public void BeginInvoke(){} // RVA: 0x6F51E10
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ChangeTrackerDisposable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943B0
    public void OnChange(){} // RVA: 0xA94080
    public void Dispose(){} // RVA: 0x894290
}

public class ChangeTrackerDisposable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xD5EFE0
    public void OnChange(){} // RVA: 0x5DC7240
    public void Dispose(){} // RVA: 0x62996E0
}

public class ChangesFromUI : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x991300
    public void get_IsValid(){} // RVA: 0x991310
}

public class ChannelTransformer`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
}

public class ChildConstraint : Object
{
    // ── Methods ──
    public void get_nominalDistance(){} // RVA: 0xC27360
    public void set_nominalDistance(){} // RVA: 0xC27370
    public void get_isRigid(){} // RVA: 0xC27380
    public void set_isRigid(){} // RVA: 0xC27390
    public void .ctor(){} // RVA: 0xC273A0
    public void Initiate(){} // RVA: 0xC27460
    public void OnPreSolve(){} // RVA: 0xC274C0
    public void Solve(){} // RVA: 0xC27820
}

public class ChildrenSection`1 : Object
{
    // ── Methods ──
    public void get_SettingComponents(){} // RVA: 0x87C0A0
    public void .ctor(){} // RVA: 0x894290
    public void Initialize(){} // RVA: 0x87C0A0
    public void get_ValueToAppear(){} // RVA: 0xA94080
    public void set_ValueToAppear(){} // RVA: 0x87C0A0
    public void IsNativeObjectAlive(){} // RVA: 0x87C0A0
    public void GetCachedPtr(){} // RVA: 0x87C0A0
    public void get_name(){} // RVA: 0x87C0A0
    public void set_name(){} // RVA: 0x87C0A0
    public void Instantiate(){} // RVA: 0x87C0A0
    public void Destroy(){} // RVA: 0x87C0A0
}

public class ChildrenSection`1 : Object
{
    // ── Methods ──
    public void get_SettingComponents(){} // RVA: 0xB700F0
    public void .ctor(){} // RVA: 0xB43310
    public void Initialize(){} // RVA: 0xB700F0
    public void get_ValueToAppear(){} // RVA: 0xE62D00
    public void set_ValueToAppear(){} // RVA: 0xB700F0
    public void IsNativeObjectAlive(){} // RVA: 0xB700F0
    public void GetCachedPtr(){} // RVA: 0xB700F0
    public void get_name(){} // RVA: 0xB700F0
    public void set_name(){} // RVA: 0xB700F0
    public void Instantiate(){} // RVA: 0xB700F0
    public void Destroy(){} // RVA: 0xB700F0
}

public class ChildrenSection`1 : Object
{
    // ── Methods ──
    public void get_SettingComponents(){} // RVA: 0xB700F0
    public void .ctor(){} // RVA: 0xB43310
    public void Initialize(){} // RVA: 0xB700F0
    public void get_ValueToAppear(){} // RVA: 0xB5DD50
    public void set_ValueToAppear(){} // RVA: 0xB700F0
    public void IsNativeObjectAlive(){} // RVA: 0xB700F0
    public void GetCachedPtr(){} // RVA: 0xB700F0
    public void get_name(){} // RVA: 0xB700F0
    public void set_name(){} // RVA: 0xB700F0
    public void Instantiate(){} // RVA: 0xB700F0
    public void Destroy(){} // RVA: 0xB700F0
}

public class CinemachineCameraOffset : CinemachineExtension
{
    // ── Methods ──
    public void PostPipelineStageCallback(){} // RVA: 0x2574C80
    public void .ctor(){} // RVA: 0x2575230
}

public class CinemachineMixer : PlayableBehaviour
{
    // ── Methods ──
    public void OnPlayableDestroy(){} // RVA: 0x2575CD0
    public void PrepareFrame(){} // RVA: 0x2575D30
    public void ProcessFrame(){} // RVA: 0x2575D40
    public void GetDeltaTime(){} // RVA: 0x2576710
    public void .ctor(){} // RVA: 0x2576860
}

public class CinemachineRecomposer : CinemachineExtension
{
    // ── Methods ──
    public void Reset(){} // RVA: 0x25752C0
    public void OnValidate(){} // RVA: 0x25752F0
    public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x2575350
    public void PostPipelineStageCallback(){} // RVA: 0x2575370
    public void .ctor(){} // RVA: 0xB43D60
}

public class CinemachineShot : PlayableAsset
{
    // ── Methods ──
    public void CreatePlayable(){} // RVA: 0x2576870
    public void GatherProperties(){} // RVA: 0x2576BE0
    public void .ctor(){} // RVA: 0xDD1AC0
}

public class CinemachineShotPlayable : PlayableBehaviour
{
    // ── Methods ──
    public void get_IsValid(){} // RVA: 0x2576DC0
    public void .ctor(){} // RVA: 0xB43310
}

public class CinemachineTouchInputMapper : MonoBehaviour
{
    // ── Methods ──
    public void Start(){} // RVA: 0x2575940
    public void GetInputAxis(){} // RVA: 0x2575A40
    public void .ctor(){} // RVA: 0x2575B80
}

public class CinemachineTrack : TrackAsset
{
    // ── Methods ──
    public void CreateTrackMixer(){} // RVA: 0x2576E90
    public void .ctor(){} // RVA: 0x2576FD0
}

public class ClaimNetworkControlDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23E7D60
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Clipper : ClipperBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25E9E50
    public void InsertMaxima(){} // RVA: 0x25EA470
    public void get_ReverseSolution(){} // RVA: 0x24BB4D0
    public void set_ReverseSolution(){} // RVA: 0x24BB3A0
    public void get_StrictlySimple(){} // RVA: 0x1D61360
    public void set_StrictlySimple(){} // RVA: 0x25EA890
    public void Execute(){} // RVA: 0x25EAA90
    public void FixHoleLinkage(){} // RVA: 0x25EAB70
    public void ExecuteInternal(){} // RVA: 0x25EAC10
    public void DisposeAllPolyPts(){} // RVA: 0x25EB2B0
    public void AddJoin(){} // RVA: 0x25EB460
    public void AddGhostJoin(){} // RVA: 0x25EB5B0
    public void InsertLocalMinimaIntoAEL(){} // RVA: 0x25EB6A0
    public void InsertEdgeIntoAEL(){} // RVA: 0x25EBD90
    public void E2InsertsBeforeE1(){} // RVA: 0x25EC150
    public void IsEvenOddFillType(){} // RVA: 0x25EC260
    public void IsEvenOddAltFillType(){} // RVA: 0x25EC290
    public void IsContributing(){} // RVA: 0x25EC2C0
    public void SetWindingCount(){} // RVA: 0x25EC470
    public void AddEdgeToSEL(){} // RVA: 0x25EC6B0
    public void PopEdgeFromSEL(){} // RVA: 0x25EC970
    public void CopyAELToSEL(){} // RVA: 0x25ECB80
    public void SwapPositionsInSEL(){} // RVA: 0x25ECCB0
    public void AddLocalMaxPoly(){} // RVA: 0x25ED0E0
    public void AddLocalMinPoly(){} // RVA: 0x25ED1A0
    public void AddOutPt(){} // RVA: 0x25ED4F0
    public void GetLastOutPt(){} // RVA: 0x25ED910
    public void SwapPoints(){} // RVA: 0x25ED9B0
    public void HorzSegmentsOverlap(){} // RVA: 0x25ED9E0
    public void SetHoleState(){} // RVA: 0x25EDA20
    public void GetDx(){} // RVA: 0x25EDBF0
    public void FirstIsBottomPt(){} // RVA: 0x25EDC30
    public void GetBottomPt(){} // RVA: 0x25EE070
    public void GetLowermostRec(){} // RVA: 0x25EE160
    public void OutRec1RightOfOutRec2(){} // RVA: 0x25EE2E0
    public void GetOutRec(){} // RVA: 0x25EE310
    public void AppendPolygon(){} // RVA: 0x25EE3D0
    public void ReversePolyPtLinks(){} // RVA: 0x25EF3E0
    public void SwapSides(){} // RVA: 0x25EF4E0
    public void SwapPolyIndexes(){} // RVA: 0x25EF510
    public void IntersectEdges(){} // RVA: 0x25EF540
    public void DeleteFromSEL(){} // RVA: 0x25EFB30
    public void ProcessHorizontals(){} // RVA: 0x25EFD50
    public void GetHorzDirection(){} // RVA: 0x25EFFA0
    public void ProcessHorizontal(){} // RVA: 0x25F0000
    public void GetNextInAEL(){} // RVA: 0x25F09D0
    public void IsMinima(){} // RVA: 0x25F0A00
    public void IsMaxima(){} // RVA: 0x25F0A40
    public void IsIntermediate(){} // RVA: 0x25F0A70
    public void GetMaximaPair(){} // RVA: 0x25F0AB0
    public void GetMaximaPairEx(){} // RVA: 0x25F0B30
    public void ProcessIntersections(){} // RVA: 0x25F0BF0
    public void BuildIntersectList(){} // RVA: 0x25F0E70
    public void EdgesAdjacent(){} // RVA: 0x25F1240
    public void IntersectNodeSort(){} // RVA: 0x25F1280
    public void FixupIntersectionOrder(){} // RVA: 0x25F12A0
    public void ProcessIntersectList(){} // RVA: 0x25F1670
    public void Round(){} // RVA: 0x25F17D0
    public void TopX(){} // RVA: 0x25F1800
    public void IntersectPoint(){} // RVA: 0x25F1870
    public void ProcessEdgesAtTopOfScanbeam(){} // RVA: 0x25F1CF0
    public void DoMaxima(){} // RVA: 0x25F2360
    public void ReversePaths(){} // RVA: 0x25F25C0
    public void Orientation(){} // RVA: 0x25F2850
    public void PointCount(){} // RVA: 0x25F2870
    public void BuildResult(){} // RVA: 0x25F28A0
    public void BuildResult2(){} // RVA: 0x25F2B00
    public void FixupOutPolyline(){} // RVA: 0x25F2EA0
    public void FixupOutPolygon(){} // RVA: 0x25F2FC0
    public void DupOutPt(){} // RVA: 0x25F34C0
    public void GetOverlap(){} // RVA: 0x25F3800
    public void JoinHorz(){} // RVA: 0x25F3920
    public void JoinPoints(){} // RVA: 0x25F3F10
    public void PointInPolygon(){} // RVA: 0x25F5350
    public void Poly2ContainsPoly1(){} // RVA: 0x25F54A0
    public void FixupFirstLefts1(){} // RVA: 0x25F5630
    public void FixupFirstLefts2(){} // RVA: 0x25F57F0
    public void FixupFirstLefts3(){} // RVA: 0x25F5A40
    public void ParseFirstLeft(){} // RVA: 0x25F5BF0
    public void JoinCommonEdges(){} // RVA: 0x25F5C10
    public void UpdateOutPtIdxs(){} // RVA: 0x25F6600
    public void DoSimplePolygons(){} // RVA: 0x25F6630
    public void Area(){} // RVA: 0x25F6B60
    public void SimplifyPolygon(){} // RVA: 0x25F6BD0
    public void SimplifyPolygons(){} // RVA: 0x25F6CD0
    public void DistanceSqrd(){} // RVA: 0x25F6DD0
    public void DistanceFromLineSqrd(){} // RVA: 0x25F6E10
    public void SlopesNearCollinear(){} // RVA: 0x25F6E90
    public void PointsAreClose(){} // RVA: 0x25F7110
    public void ExcludeOp(){} // RVA: 0x25F7150
    public void CleanPolygon(){} // RVA: 0x25F7240
    public void CleanPolygons(){} // RVA: 0x25F7890
    public void Minkowski(){} // RVA: 0x25F7A20
    public void MinkowskiSum(){} // RVA: 0x25F85B0
    public void TranslatePath(){} // RVA: 0x25F83C0
    public void MinkowskiDiff(){} // RVA: 0x25F87E0
    public void PolyTreeToPaths(){} // RVA: 0x25F88B0
    public void AddPolyNodeToPaths(){} // RVA: 0x25F8970
    public void OpenPathsFromPolyTree(){} // RVA: 0x25F8B60
    public void ClosedPathsFromPolyTree(){} // RVA: 0x25F8D10
}

public class ClipperBase : Object
{
    // ── Methods ──
    public void near_zero(){} // RVA: 0x25E53B0
    public void get_PreserveCollinear(){} // RVA: 0xEEA480
    public void set_PreserveCollinear(){} // RVA: 0xEEA470
    public void Swap(){} // RVA: 0x25E53D0
    public void IsHorizontal(){} // RVA: 0x25E53E0
    public void PointIsVertex(){} // RVA: 0x25E5400
    public void PointOnLineSegment(){} // RVA: 0x25E5450
    public void PointOnPolygon(){} // RVA: 0x25E5610
    public void SlopesEqual(){} // RVA: 0x25E5AA0
    public void .ctor(){} // RVA: 0x25E5BE0
    public void Clear(){} // RVA: 0x25E5D50
    public void DisposeLocalMinimaList(){} // RVA: 0x25E6040
    public void RangeTest(){} // RVA: 0x25E6180
    public void InitEdge(){} // RVA: 0x25E6260
    public void InitEdge2(){} // RVA: 0x25E6340
    public void FindNextLocMin(){} // RVA: 0x25E63F0
    public void ProcessBound(){} // RVA: 0x25E6500
    public void AddPath(){} // RVA: 0x25E6BA0
    public void AddPaths(){} // RVA: 0x25E7FC0
    public void Pt2IsBetweenPt1AndPt3(){} // RVA: 0x25E80B0
    public void RemoveEdge(){} // RVA: 0x25E8120
    public void SetDx(){} // RVA: 0x25E8270
    public void InsertLocalMinima(){} // RVA: 0x25E82D0
    public void PopLocalMinima(){} // RVA: 0x25E84F0
    public void ReverseHorizontal(){} // RVA: 0x25E85E0
    public void Reset(){} // RVA: 0x25E8610
    public void GetBounds(){} // RVA: 0x25E8A80
    public void InsertScanbeam(){} // RVA: 0x25E8EC0
    public void PopScanbeam(){} // RVA: 0x25E91C0
    public void LocalMinimaPending(){} // RVA: 0x25E9250
    public void CreateOutRec(){} // RVA: 0x25E9260
    public void DisposeOutRec(){} // RVA: 0x25E9490
    public void UpdateEdgeIntoAEL(){} // RVA: 0x25E95A0
    public void SwapPositionsInAEL(){} // RVA: 0x25E9970
    public void DeleteFromAEL(){} // RVA: 0x25E9C30
}

public class ClipperException : Exception
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25FD710
}

public class ClipperOffset : Object
{
    // ── Methods ──
    public void get_ArcTolerance(){} // RVA: 0x25F8DD0
    public void set_ArcTolerance(){} // RVA: 0x25F8DE0
    public void get_MiterLimit(){} // RVA: 0x25F8DF0
    public void set_MiterLimit(){} // RVA: 0x25F8E00
    public void .ctor(){} // RVA: 0x25F8E10
    public void Clear(){} // RVA: 0x25F8F90
    public void Round(){} // RVA: 0x25F17D0
    public void AddPath(){} // RVA: 0x25F9010
    public void AddPaths(){} // RVA: 0x25F96A0
    public void FixOrientations(){} // RVA: 0x25F9830
    public void GetUnitNormal(){} // RVA: 0x25F9AF0
    public void DoOffset(){} // RVA: 0x25F9BF0
    public void Execute(){} // RVA: 0x25FB770
    public void OffsetPoint(){} // RVA: 0x25FBED0
    public void DoSquare(){} // RVA: 0x25FC8C0
    public void DoMiter(){} // RVA: 0x25FCEA0
    public void DoRound(){} // RVA: 0x25FD150
}

public class Codec : Object
{
    // ── Methods ──
    public void get_KeyCodec(){} // RVA: 0x87C0A0
    public void get_ValueCodec(){} // RVA: 0x87C0A0
    public void get_MapTag(){} // RVA: 0x87C130
}

public class Collection : ValueType
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x93E4E0
    public void TryFindLayoutForType(){} // RVA: 0x93E4F0
    public void TryFindMatchingLayout(){} // RVA: 0x93E520
    public void HasLayout(){} // RVA: 0x93E580
    public void TryLoadLayoutInternal(){} // RVA: 0x93E5A0
    public void TryLoadLayout(){} // RVA: 0x93E5C0
    public void GetBaseLayoutName(){} // RVA: 0x93E5E0
    public void GetRootLayoutName(){} // RVA: 0x93E620
    public void ComputeDistanceInInheritanceHierarchy(){} // RVA: 0x93E760
    public void FindLayoutThatIntroducesControl(){} // RVA: 0x93E7A0
    public void GetControlTypeForLayout(){} // RVA: 0x93E7D0
    public void ValueTypeIsAssignableFrom(){} // RVA: 0x93E7F0
    public void IsGeneratedLayout(){} // RVA: 0x93E910
    public void GetBaseLayouts(){} // RVA: 0x93E990
    public void IsBasedOn(){} // RVA: 0x93EAF0
    public void AddMatcher(){} // RVA: 0x93EB20
}

public class CollisionEnterDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class CollisionEventsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x9C61B0
}

public class CollisionExitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DB94B0
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0x23E7ED0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class CollisionsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x9C5CA0
    public void GetCollision(){} // RVA: 0x9C5CB0
    public void SetCollision(){} // RVA: 0x9C5CC0
    public void FindCollision(){} // RVA: 0x9C5CD0
}

public class ColorPaletteData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ColorPaletteRoot : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43D60
}

public class ColorProperty : InlineStyleColorProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7E9F4D0
    public void get_ussName(){} // RVA: 0x7E9F510
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7E9F550
    public void SetValue(){} // RVA: 0x7E9F5C0
    public void .ctor(){} // RVA: 0x7E9D9F0
}

public class ColorProperty : ResolvedColorProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECA8E0
    public void get_ussName(){} // RVA: 0x7ECA920
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECA960
    public void SetValue(){} // RVA: 0x7ECA9D0
    public void .ctor(){} // RVA: 0x7EC9370
}

public class ColorProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0xB465B0
    public void get_IsReadOnly(){} // RVA: 0xC38360
    public void GetValue(){} // RVA: 0x7F09F00
    public void SetValue(){} // RVA: 0x7F09F10
    public void .ctor(){} // RVA: 0x7F09F20
}

public class Configuration : ValueType
{
    // ── Methods ──
    public void GetDefaultConfiguration(){} // RVA: 0x77FD770
}

public class Configuration : ValueType
{
    // ── Methods ──
    public void GetDefaultConfiguration(){} // RVA: 0x7CA7D70
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899250
    public void get_IsCompleted(){} // RVA: 0x87D280
    public void OnCompleted(){} // RVA: 0x894320
    public void UnsafeOnCompleted(){} // RVA: 0x894320
    public void GetResult(){} // RVA: 0xA94080
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x212FA0
    public void GetResult(){} // RVA: 0x2145D0
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x212FA0
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x213130
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void get_IsCompleted(){} // RVA: 0x87D280
    public void GetResult(){} // RVA: 0xA94080
    public void OnCompleted(){} // RVA: 0x894320
    public void UnsafeOnCompleted(){} // RVA: 0x894320
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x229E10
    public void GetResult(){} // RVA: 0x22B250
    public void OnCompleted(){} // RVA: 0x22B2B0
    public void UnsafeOnCompleted(){} // RVA: 0x22B2C0
}

public class ConstructJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x924470
}

public class ConstructJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x924470
}

public class ConstructJobList : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x924460
}

public class ConstructJobList : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x924460
}

public class ContainerHeight : Object
{
    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x9B1B550
    public void Equals(){} // RVA: 0x9B1B550
    public void GetHashCode(){} // RVA: 0x9B1B550
    public void op_Implicit(){} // RVA: 0x9B1B550
    public void CompareBaseObjects(){} // RVA: 0x9B1B550
    public void IsNativeObjectAlive(){} // RVA: 0x9B1B550
    public void .ctor(){} // RVA: 0xB43310
    public void get_Height(){} // RVA: 0x9B1B550
    public void set_Height(){} // RVA: 0x9B1B550
}

public class ContingentProperties : Object
{
    // ── Methods ──
    public void SetCompleted(){} // RVA: 0x69C68E0
    public void UnregisterCancellationCallback(){} // RVA: 0x69C6910
    public void .ctor(){} // RVA: 0x69C6A00
}

public class Control : Object
{
    // ── Methods ──
    public void GetSubParameter(){} // RVA: 0xA6C8490
    public void GetLabel(){} // RVA: 0xA6C84D0
    public void .ctor(){} // RVA: 0x1C0D7B0
}

public class ControlBitRangeNode : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x933050
}

public class ControlBitRangeNode[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EC0FB0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7BE20
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC6C00
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E780C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7BE20
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class ControlDataForExport : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ConverterKey : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x76310
}

public class ConverterKey : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x76310
}

public class ConverterKeyComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7D44640
    public void GetHashCode(){} // RVA: 0x7D446C0
    public void .ctor(){} // RVA: 0xB43310
}

public class ConverterKeyComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7D44640
    public void GetHashCode(){} // RVA: 0x7D446C0
    public void .ctor(){} // RVA: 0xB43310
}

public class CreateJointParams : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4F70
}

public class CreatePipelineDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2595D70
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x1A4D0B0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class CreateRigDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2595D70
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x1A4D0B0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CreationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4F6ECE0
    public void Invoke(){} // RVA: 0xB9E010
}

public class CursorProperty : InlineStyleCursorProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7E9F630
    public void get_ussName(){} // RVA: 0x7E9F670
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7E9F6B0
    public void SetValue(){} // RVA: 0x7E9F730
    public void .ctor(){} // RVA: 0x7E9F810
}

public class CustomBlend[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class CustomBlendable : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x54930
}

public class CustomEmojiParticleSystemList : ScriptableObject
{
    // ── Methods ──
    public void IndexOf(){} // RVA: 0x21D26B0
    public void CreateInstance(){} // RVA: 0x21D26F0
    public void CreateScriptableObject(){} // RVA: 0x21D26B0
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x21D2940
    public void .ctor(){} // RVA: 0xDD1AC0
    public void Initialize(){} // RVA: 0x21D2A10
    public void set_Count(){} // RVA: 0x21D26B0
    public void get_Count(){} // RVA: 0x21D2C60
    public void Equals(){} // RVA: 0x21D2C70
    public void GetHashCode(){} // RVA: 0x21D26B0
}
