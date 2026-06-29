// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 545

public class IActivationFactory : Object
{
    // ── Methods ──
    public void ActivateInstance(){} // RVA: 0x7A7E00680
}

public class IAttrList
{
    // ── Methods ──
    public void get_Length(){} // RVA: 0x7A7E00710
    public void GetName(){} // RVA: 0x7A7E00740
    public void GetValue(){} // RVA: 0x7A7E00B20
    public void get_Names(){} // RVA: 0x7A7E00680
    public void get_Values(){} // RVA: 0x7A7E00680
}

public class IContentHandler
{
    // ── Methods ──
    public void OnStartParsing(){} // RVA: 0x7A7E18800
    public void OnEndParsing(){} // RVA: 0x7A7E18800
    public void OnStartElement(){} // RVA: 0x7A7E18890
    public void OnEndElement(){} // RVA: 0x7A7E18800
    public void OnProcessingInstruction(){} // RVA: 0x7A7E18890
    public void OnChars(){} // RVA: 0x7A7E18800
    public void OnIgnorableWhitespace(){} // RVA: 0x7A7E18800
}

public class IEncryption
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x7A7E00BD0
    public void TryDecrypt(){} // RVA: 0x7A7E01D90
}

public class IExtensionReflectionHelper
{
    // ── Methods ──
    public void GetExtension(){} // RVA: 0x7A7E00B20
    public void SetExtension(){} // RVA: 0x7A7E18890
    public void HasExtension(){} // RVA: 0x7A7E019D0
    public void ClearExtension(){} // RVA: 0x7A7E18800
}

public class IFactoryControls
{
    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x7A7E00BD0
}

public class IInput
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7A7E019D0
    public void GetAxisRaw(){} // RVA: 0x7A7E15640
    public void ClearLastPenContactEvent(){} // RVA: 0x7A7E18770
    public void GetLastPenContactEvent(){} // RVA: 0x7A7E00490
    public void get_touchCount(){} // RVA: 0x7A7E00710
    public void GetTouch(){} // RVA: 0x7A7E00520
    public void get_mousePresent(){} // RVA: 0x7A7E01900
    public void GetMouseButtonDown(){} // RVA: 0x7A7E01F00
    public void GetMouseButtonUp(){} // RVA: 0x7A7E01F00
    public void get_mousePosition(){} // RVA: 0x7A7E00490
    public void get_mouseButtonCount(){} // RVA: 0x7A7E00710
    public void get_anyKey(){} // RVA: 0x7A7E01900
    public void get_unscaledTime(){} // RVA: 0x7A7E155B0
    public void get_doubleClickTime(){} // RVA: 0x7A7E155B0
}

public class IJobSortable
{
    // ── Methods ──
    public void get_SortingBaseTransform(){} // RVA: 0x7A7E00680
    public void get_MaximumExecutionGroups(){} // RVA: 0x7A7E00710
    public void GetKnownDependencies(){} // RVA: 0x7A7E18800
    public void get_ExecutionGroup(){} // RVA: 0x7A7E00710
    public void set_ExecutionGroup(){} // RVA: 0x7A7E189D0
}

public class ILEmitResolverBuilderRuntimeContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class IListWrapper : ArrayList
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADBF4BC0
    public void set_Capacity(){} // RVA: 0x7ADBF4C40
    public void get_Count(){} // RVA: 0x7ADBF4CD0
    public void get_IsReadOnly(){} // RVA: 0x7ADBF4D20
    public void get_IsFixedSize(){} // RVA: 0x7ADBF4D70
    public void get_IsSynchronized(){} // RVA: 0x7ADBF4DC0
    public void get_Item(){} // RVA: 0x7ADBF4E10
    public void set_Item(){} // RVA: 0x7ADBF4E70
    public void get_SyncRoot(){} // RVA: 0x7ADBF4EF0
    public void Add(){} // RVA: 0x7ADBF4F40
    public void AddRange(){} // RVA: 0x7ADBF4FB0
    public void Clear(){} // RVA: 0x7ADBF5000
    public void Clone(){} // RVA: 0x7ADBF50C0
    public void Contains(){} // RVA: 0x7ADBF5120
    public void CopyTo(){} // RVA: 0x7ADBF51F0
    public void GetEnumerator(){} // RVA: 0x7ADBF5520
    public void IndexOf(){} // RVA: 0x7ADBF5570
    public void Insert(){} // RVA: 0x7ADBF55D0
    public void InsertRange(){} // RVA: 0x7ADBF5650
    public void Remove(){} // RVA: 0x7ADBF4390
    public void RemoveAt(){} // RVA: 0x7ADBF59B0
    public void RemoveRange(){} // RVA: 0x7ADBF5A20
    public void Reverse(){} // RVA: 0x7ADBF5C20
    public void Sort(){} // RVA: 0x7ADBF6000
    public void ToArray(){} // RVA: 0x7ADBF6390
}

public class IOVRMeshDataProvider
{
    // ── Methods ──
    public void GetMeshType(){} // RVA: 0x7A7E00710
}

public class IOVRMeshRendererDataProvider
{
    // ── Methods ──
    public void GetMeshRendererData(){} // RVA: 0x7A7E00490
}

public class IOVRSceneComponent
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7A7E18770
}

public class IOVRSkeletonDataProvider
{
    // ── Methods ──
    public void GetSkeletonType(){} // RVA: 0x7A7E00710
    public void GetSkeletonPoseData(){} // RVA: 0x7A7E00490
    public void get_enabled(){} // RVA: 0x7A7E01900
}

public class IOVRSkeletonRendererDataProvider
{
    // ── Methods ──
    public void GetSkeletonRendererData(){} // RVA: 0x7A7E00680
}

public class IPSQuery : ApiModel
{
    // ── Methods ──
    public void get_require(){} // RVA: 0x7A8153390
    public void set_require(){} // RVA: 0x7A81533A0
    public void get_include(){} // RVA: 0x7A81A00E0
    public void set_include(){} // RVA: 0x7A81A00F0
    public void .ctor(){} // RVA: 0x7B16B0D90
}

public class IPlayerActions
{
    // ── Methods ──
    public void OnMove(){} // RVA: 0x7A7E18800
    public void OnLook(){} // RVA: 0x7A7E18800
    public void OnFire(){} // RVA: 0x7A7E18800
}

public class IReflectionHelper
{
    // ── Methods ──
    public void CreateFuncIMessageInt32(){} // RVA: 0x7A7E00B20
    public void CreateActionIMessage(){} // RVA: 0x7A7E00B20
    public void CreateFuncIMessageObject(){} // RVA: 0x7A7E00B20
    public void CreateActionIMessageObject(){} // RVA: 0x7A7E00B20
    public void CreateFuncIMessageBool(){} // RVA: 0x7A7E00B20
}

public class ITokenReader
{
    // ── Methods ──
    public void Read(){} // RVA: 0x7A7E00710
}

public class ITypeConstructor
{
    // ── Methods ──
    public void get_CanBeInstantiated(){} // RVA: 0x7A7E01900
    public void Instantiate(){} // RVA: 0x7A7E00680
}

public class IUIActions
{
    // ── Methods ──
    public void OnNavigate(){} // RVA: 0x7A7E18800
    public void OnSubmit(){} // RVA: 0x7A7E18800
    public void OnCancel(){} // RVA: 0x7A7E18800
    public void OnPoint(){} // RVA: 0x7A7E18800
    public void OnClick(){} // RVA: 0x7A7E18800
    public void OnScrollWheel(){} // RVA: 0x7A7E18800
    public void OnMiddleClick(){} // RVA: 0x7A7E18800
    public void OnRightClick(){} // RVA: 0x7A7E18800
    public void OnTrackedDevicePosition(){} // RVA: 0x7A7E18800
    public void OnTrackedDeviceOrientation(){} // RVA: 0x7A7E18800
}

public class IUIGroupItemDatasource
{
    // ── Methods ──
    public void get_name(){} // RVA: 0x7A7E00680
}

public class IVisualPredicateWrapper
{
    // ── Methods ──
    public void Predicate(){} // RVA: 0x7A7E019D0
}

public class Icons[] : Array
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

public class IdentityTokenChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8132FA0
    public void Invoke(){} // RVA: 0x7A8133090
}

public class IgnoresCaseHashtable : Object
{
    // ── Methods ──
    public void Clear(){} // RVA: 0x7B16F1780
    public void GetEnumerator(){} // RVA: 0x7B16F17F0
    public void get_Keys(){} // RVA: 0x7B16F1840
    public void Remove(){} // RVA: 0x7B16F1890
    public void get_Item(){} // RVA: 0x7B16F19D0
    public void set_Item(){} // RVA: 0x7B16F1AC0
    public void get_Values(){} // RVA: 0x7B16F1C00
    public void .ctor(){} // RVA: 0x7B16F1C50
}

public class ImageLoadSettings : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7A7679760
    public void InternalEquals(){} // RVA: 0x7A7679770
    public void DefaultEquals(){} // RVA: 0x7A7679770
    public void GetHashCode(){} // RVA: 0x7A7679780
    public void InternalGetHashCode(){} // RVA: 0x7A7679790
    public void ToString(){} // RVA: 0x7A7679850
    public void GetHashCodeOfPtr(){} // RVA: 0x7A7679860
    public void .ctor(){} // RVA: 0x7A7679E10
    public void Initialize(){} // RVA: 0x7A7679E40
    // ── 15 unresolved (hash) ──
    public void m_564(){} // RVA: 0x7A7679890
    public void m_85B(){} // RVA: 0x7A7679900
    public void m_677(){} // RVA: 0x7A7679910
    public void m_EEB(){} // RVA: 0x7A76799D0
    public void m_6C5(){} // RVA: 0x7A7679A30
    // ... 10 more unresolved methods
}

public class ImageLoadSettings : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7679E10
    public void GetAllocationLimit(){} // RVA: 0x7A7FC71C0
    public void SetAllocationLimit(){} // RVA: 0x7A7FC7220
    public void GetResolutionLimit(){} // RVA: 0x7A7FC72E0
    public void SetResolutionLimit(){} // RVA: 0x7A7FC7340
    public void GetVerticalFlip(){} // RVA: 0x7A7679D60
    public void SetVerticalFlip(){} // RVA: 0x7A7679F70
    public void GetResizeResolution(){} // RVA: 0x7A7FC7400
    public void SetResizeResolution(){} // RVA: 0x7A7FC74A0
    public void SetFastResize(){} // RVA: 0x7A7679BC0
    public void GetFastResize(){} // RVA: 0x7A7679B00
    public void GetOutputFormatOverride(){} // RVA: 0x7A7FC7570
    public void SetOutputFormatOverride(){} // RVA: 0x7A7FC75C0
    public void SetGenerateMipMaps(){} // RVA: 0x7A7679890
    public void GetGenerateMipMaps(){} // RVA: 0x7A7679780
    public void HasFlag(){} // RVA: 0x7A7679770
}

public class ImmutableCollectionTypeInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A81B7C50
    public void get_ContractTypeName(){} // RVA: 0x7A80F2570
    public void set_ContractTypeName(){} // RVA: 0x7A80D8E20
    public void get_CreatedTypeName(){} // RVA: 0x7A80DA7B0
    public void set_CreatedTypeName(){} // RVA: 0x7A813E420
    public void get_BuilderTypeName(){} // RVA: 0x7A81052C0
    public void set_BuilderTypeName(){} // RVA: 0x7A81052D0
}

public class ImportStruct[] : Array
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

public class IndexTree : RBTree`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE5223F0
    public void CompareNode(){} // RVA: 0x7AE5224A0
    public void CompareSateliteTreeNode(){} // RVA: 0x7AE5224C0
}

public class IndirectDrawIndexedArgs : ValueType
{
    // ── Methods ──
    public void set_indexCountPerInstance(){} // RVA: 0x7A76134D0
    public void set_instanceCount(){} // RVA: 0x7A765F090
    public void set_startIndex(){} // RVA: 0x7A767FBC0
    public void set_baseVertexIndex(){} // RVA: 0x7A767FBE0
    public void set_startInstance(){} // RVA: 0x7A7677B10
}

public class InfiniteTimer : Timer
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE921BF0
    public void get_HasExpired(){} // RVA: 0x7A80D7320
    public void Cancel(){} // RVA: 0x7AE921C10
}

public class InfiniteTimerQueue : Queue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8B7F8D0
    public void CreateTimer(){} // RVA: 0x7AE921500
}

public class Info : ApiModel
{
    // ── Methods ──
    public void get_period(){} // RVA: 0x7A8153390
    public void set_period(){} // RVA: 0x7A81533A0
    public void get_periodAmount(){} // RVA: 0x7A8EA8210
    public void set_periodAmount(){} // RVA: 0x7A8270510
    public void get_Period(){} // RVA: 0x7B172EA90
    public void .ctor(){} // RVA: 0x7B172EB80
}

public class InheritVelocityModule : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7637E60
    public void get_enabled(){} // RVA: 0x7A7EEDEB0
    public void set_enabled(){} // RVA: 0x7A7EEDF00
    public void get_mode(){} // RVA: 0x7A7EEDF10
    public void set_mode(){} // RVA: 0x7A7EEDF60
    public void get_curve(){} // RVA: 0x7A7EEDFC0
    public void set_curve(){} // RVA: 0x7A7EEE050
    public void get_curveMultiplier(){} // RVA: 0x7A7EEE0C0
    public void set_curveMultiplier(){} // RVA: 0x7A7EEE110
    public void get_enabled_Injected(){} // RVA: 0x7AEF9C760
    public void set_enabled_Injected(){} // RVA: 0x7AEF9C7B0
    public void get_mode_Injected(){} // RVA: 0x7AEF9C810
    public void set_mode_Injected(){} // RVA: 0x7AEF9C860
    public void get_curve_Injected(){} // RVA: 0x7AEF9CA40
    public void set_curve_Injected(){} // RVA: 0x7AEF9CAA0
    public void get_curveMultiplier_Injected(){} // RVA: 0x7AEF9C990
    public void set_curveMultiplier_Injected(){} // RVA: 0x7AEF9C9E0
}

public class Initial : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AD9BF7B0
}

public class Input : Object
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x7A80F6210
    public void GetAxisRaw(){} // RVA: 0x7AF1B5C80
    public void ClearLastPenContactEvent(){} // RVA: 0x7AEF87CB0
    public void GetLastPenContactEvent(){} // RVA: 0x7AF1B5CD0
    public void get_touchCount(){} // RVA: 0x7AEF881E0
    public void GetTouch(){} // RVA: 0x7AF1B5D60
    public void get_mousePresent(){} // RVA: 0x7AEF88190
    public void GetMouseButtonDown(){} // RVA: 0x7AF1B5E10
    public void GetMouseButtonUp(){} // RVA: 0x7AF1B5E60
    public void get_mousePosition(){} // RVA: 0x7A80F6490
    public void get_mouseButtonCount(){} // RVA: 0x7A87EE0F0
    public void get_anyKey(){} // RVA: 0x7AEF87DF0
    public void get_unscaledTime(){} // RVA: 0x7AECC51C0
    public void get_doubleClickTime(){} // RVA: 0x7AF1B5EB0
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class InputEventControlCollection : ValueType
{
    // ── Methods ──
    public void get_eventPtr(){} // RVA: 0x7A765F080
    public void GetEnumerator(){} // RVA: 0x7A7EB0B00
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator(){} // RVA: 0x7A7EB0BB0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7EB0CC0
}

public class InputEventControlEnumerator : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7EB0DF0
    public void CheckDefault(){} // RVA: 0x7A7EB0E00
    public void CheckCurrent(){} // RVA: 0x7A7EB0E30
    public void MoveNext(){} // RVA: 0x7A7EB0E60
    public void Reset(){} // RVA: 0x7A7EB0E70
    public void Dispose(){} // RVA: 0x7A7EB0E80
    public void get_Current(){} // RVA: 0x7A76AAE30
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7A76AAE30
}

public class InputPairing : Object
{
    // ── Methods ──
    public void GetKeyDown(){} // RVA: 0x7B1829430
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class InputPairing[] : Array
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

public class InstanceRestoredDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AF4320D0
    public void Invoke(){} // RVA: 0x7A8234660
    public void BeginInvoke(){} // RVA: 0x7AF4321C0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class InstantiateMrcCameraDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF28640
    public void Invoke(){} // RVA: 0x7A82344F0
    public void BeginInvoke(){} // RVA: 0x7ADF28730
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class InstantiationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B18B98E0
    public void Invoke(){} // RVA: 0x7B18B99B0
    public void BeginInvoke(){} // RVA: 0x7B18B99F0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class Instruction[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1330
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DF80
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2C90
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250480
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DF80
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class Int32TaskSocketAsyncEventArgs : TaskSocketAsyncEventArgs`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE999750
}

public class IntChildrenSection[] : Array
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

public class IntPoint[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2DEE00
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA29AD70
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class IntegerInput : TextValueInput
{
    // ── Methods ──
    public void get_parentIntegerField(){} // RVA: 0x7AF185970
    public void .ctor(){} // RVA: 0x7AF1859F0
    public void get_allowedCharacters(){} // RVA: 0x7AF185BB0
    public void ApplyInputDeviceDelta(){} // RVA: 0x7AF185C10
    public void ValueToString(){} // RVA: 0x7AF185E40
    public void StringToValue(){} // RVA: 0x7AF185F30
}

public class Interaction : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class InteractionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8234420
    public void Invoke(){} // RVA: 0x7A82344F0
    public void BeginInvoke(){} // RVA: 0x7A8234500
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class InteractionEvent : Object
{
    // ── Methods ──
    public void Activate(){} // RVA: 0x7A822DA30
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class InteractionEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8234590
    public void Invoke(){} // RVA: 0x7A8234660
    public void BeginInvoke(){} // RVA: 0x7A8234680
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class InteractionEvent[] : Array
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

public class InteractionState : ValueType
{
    // ── Methods ──
    public void get_triggerControlIndex(){} // RVA: 0x7A7EAA5A0
    public void set_triggerControlIndex(){} // RVA: 0x7A7EAA5C0
    public void get_startTime(){} // RVA: 0x7A766FF70
    public void set_startTime(){} // RVA: 0x7A76BF780
    public void get_performedTime(){} // RVA: 0x7A7EAA5D0
    public void set_performedTime(){} // RVA: 0x7A7EAA5E0
    public void get_timerStartTime(){} // RVA: 0x7A782AEE0
    public void set_timerStartTime(){} // RVA: 0x7A7EAA5F0
    public void get_timerDuration(){} // RVA: 0x7A76B8960
    public void set_timerDuration(){} // RVA: 0x7A76B8940
    public void get_totalTimeoutCompletionDone(){} // RVA: 0x7A7687050
    public void set_totalTimeoutCompletionDone(){} // RVA: 0x7A7687080
    public void get_totalTimeoutCompletionTimeRemaining(){} // RVA: 0x7A76870A0
    public void set_totalTimeoutCompletionTimeRemaining(){} // RVA: 0x7A76870D0
    public void get_timerMonitorIndex(){} // RVA: 0x7A7677A20
    public void set_timerMonitorIndex(){} // RVA: 0x7A7673F30
    public void get_isTimerRunning(){} // RVA: 0x7A7EAA600
    public void set_isTimerRunning(){} // RVA: 0x7A7EAA610
    public void get_phase(){} // RVA: 0x7A767CB00
    public void set_phase(){} // RVA: 0x7A763C9C0
}

public class InternalCollisionIgnoreSettings : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A814DD60
}

public class Interop : Object
{
    // ── Methods ──
    public void GetRandomBytes(){} // RVA: 0x7AD9DDCA0
    public void MemAlloc(){} // RVA: 0x7AD9DDDB0
}

public class Interval : Object
{
    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7AD8F21B0
    public void get_Descriptor(){} // RVA: 0x7AD8F2210
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD8F2290
    public void .ctor(){} // RVA: 0x7AD8F2340
    public void Clone(){} // RVA: 0x7AD8F2440
    public void get_Y(){} // RVA: 0x7AD8F2570
    public void set_Y(){} // RVA: 0x7AD848D30
    public void get_HasY(){} // RVA: 0x7AD848D40
    public void ClearY(){} // RVA: 0x7AD848D50
    public void get_LeftX(){} // RVA: 0x7AD8F25E0
    public void set_LeftX(){} // RVA: 0x7AD848DD0
    public void get_HasLeftX(){} // RVA: 0x7AD848DE0
    public void ClearLeftX(){} // RVA: 0x7AD848DF0
    public void get_RightX(){} // RVA: 0x7AD8F2650
    public void set_RightX(){} // RVA: 0x7AD8D9620
    public void get_HasRightX(){} // RVA: 0x7AD84BFE0
    public void ClearRightX(){} // RVA: 0x7AD84BFF0
    public void Equals(){} // RVA: 0x7AD8F27E0
    public void GetHashCode(){} // RVA: 0x7AD8F28C0
    public void ToString(){} // RVA: 0x7AD8F2940
    public void WriteTo(){} // RVA: 0x7AD825C30
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD8F2990
    public void CalculateSize(){} // RVA: 0x7AD8F2A40
    public void MergeFrom(){} // RVA: 0x7AD825F70
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8F2C80
    public void .cctor(){} // RVA: 0x7AD8F2D40
}

public class Interval[] : Array
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

public class IntializationDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A81577F0
    public void Invoke(){} // RVA: 0x7A8133090
    public void BeginInvoke(){} // RVA: 0x7A81330A0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class InvocationContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8CE4080
    public void Invoke(){} // RVA: 0x7ACF618E0
}

public class InvocationEntryDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9C64DA0
    public void Invoke(){} // RVA: 0x7A8133090
}

public class IsAutoDispose : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AEB65B30
}

public class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB15CF60
    public void Invoke(){} // RVA: 0x7A8135ED0
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
    public void GetResult(){} // RVA: 0x7AEAE2030
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7AEAE20C0
    public void GetStatus(){} // RVA: 0x7AEAE2140
    public void UnsafeGetStatus(){} // RVA: 0x7AEAE21A0
    public void OnCompleted(){} // RVA: 0x7AEAE21F0
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
}

public class IsolatingRunSequence : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AD88DDA0
}

public class Item : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
    public void Set(){} // RVA: 0x7A9AC8120
}

public class ItemAttribute : ApiModel
{
    // ── Methods ──
    public void get_defaultValue(){} // RVA: 0x7A8153390
    public void set_defaultValue(){} // RVA: 0x7A81533A0
    public void get_validator(){} // RVA: 0x7A81A00E0
    public void set_validator(){} // RVA: 0x7A81A00F0
    public void .ctor(){} // RVA: 0x7B16B75C0
}

public class ItemAttributeValidation : ApiModel
{
    // ── Methods ──
    public void get_type(){} // RVA: 0x7A8153390
    public void set_type(){} // RVA: 0x7A81533A0
    public void .ctor(){} // RVA: 0x7B16B7610
}

public class Item[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A23D0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E490
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E35B0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA251170
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E490
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class Iterator`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB3FE370
    public void get_Current(){} // RVA: 0x7A80804D0
    public void Clone(){} // RVA: 0x7A7E00680
    public void Dispose(){} // RVA: 0x7AB3FE470
    public void GetEnumerator(){} // RVA: 0x7AB3FE550
    public void MoveNext(){} // RVA: 0x7A7E01900
    public void Select(){} // RVA: 0x7A7E00B20
    public void Where(){} // RVA: 0x7A7E00B20
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AB3FE710
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB3FE7C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7AB136F70
}

public class Iterator`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB3FE370
    public void get_Current(){} // RVA: 0x7A80804D0
    public void Clone(){} // RVA: 0x7A7E00680
    public void Dispose(){} // RVA: 0x7AB3FE470
    public void GetEnumerator(){} // RVA: 0x7AB3FE550
    public void MoveNext(){} // RVA: 0x7A7E01900
    public void Select(){} // RVA: 0x7A7E00B20
    public void Where(){} // RVA: 0x7A7E00B20
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AB3FE710
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB3FE7C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7AB136F70
}

public class Iterator`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB3FE370
    public void get_Current(){} // RVA: 0x7A80804D0
    public void Clone(){} // RVA: 0x7A7E00680
    public void Dispose(){} // RVA: 0x7AB3FE470
    public void GetEnumerator(){} // RVA: 0x7AB3FE550
    public void MoveNext(){} // RVA: 0x7A7E01900
    public void Select(){} // RVA: 0x7A7E00B20
    public void Where(){} // RVA: 0x7A7E00B20
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AB3FE710
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB3FE7C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7AB136F70
}

public class Iterator`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB3FE370
    public void get_Current(){} // RVA: 0x7A80804D0
    public void Clone(){} // RVA: 0x7A7E00680
    public void Dispose(){} // RVA: 0x7AB3FE470
    public void GetEnumerator(){} // RVA: 0x7AB3FE550
    public void MoveNext(){} // RVA: 0x7A7E01900
    public void Select(){} // RVA: 0x7A7E00B20
    public void Where(){} // RVA: 0x7A7E00B20
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7AB3FE710
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB3FE7C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7AB136F70
}

public class iOSInfo : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7AD87DE00
    public void FetchInfo(){} // RVA: 0x7AD87DE10
    public void get_CacheDir(){} // RVA: 0x7AD87DED0
    public void CheckMemoryStatusThread(){} // RVA: 0x7AD87E010
    public void PollMemoryStatus(){} // RVA: 0x7AD87E2D0
    public void GetMemoryStatus(){} // RVA: 0x7AD87E440
    public void FetchMemoryStatus(){} // RVA: 0x7AD87E5B0
    public void get_FreeDiskSpaceBytes(){} // RVA: 0x7AD87E5C0
    public void .ctor(){} // RVA: 0x7A80D7310
    public void _hasFetchedInfo(){} // RVA: 0x7B3F8D368
}

public class iOSVibration : Object
{
    // ── Methods ──
    public void Vibrate(){} // RVA: 0x7A80D7000
    public void VibrateSimple(){} // RVA: 0x7A80D7080
    public void .cctor(){} // RVA: 0x7A80D7100
}
