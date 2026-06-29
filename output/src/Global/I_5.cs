// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 420

public class IActivationFactory : Object
{
    // ── Methods ──
    public void ActivateInstance(){} // RVA: 0x87C0A0
}

public class IAttrList
{
    // ── Methods ──
    public void get_Length(){} // RVA: 0x87C130
    public void GetName(){} // RVA: 0x87C160
    public void GetValue(){} // RVA: 0x87C540
    public void get_Names(){} // RVA: 0x87C0A0
    public void get_Values(){} // RVA: 0x87C0A0
}

public class IConstraintSubstituteCreator
{
    // ── Methods ──
    public void CreateSubstituteComponent(){} // RVA: 0xA94080
}

public class IContentHandler
{
    // ── Methods ──
    public void OnStartParsing(){} // RVA: 0x894320
    public void OnEndParsing(){} // RVA: 0x894320
    public void OnStartElement(){} // RVA: 0x8943B0
    public void OnEndElement(){} // RVA: 0x894320
    public void OnProcessingInstruction(){} // RVA: 0x8943B0
    public void OnChars(){} // RVA: 0x894320
    public void OnIgnorableWhitespace(){} // RVA: 0x894320
}

public class IEncryption
{
    // ── Methods ──
    public void Encrypt(){} // RVA: 0x87C5F0
    public void TryDecrypt(){} // RVA: 0x87D710
}

public class IEventSanitizer
{
    // ── Methods ──
    public void Reset(){} // RVA: 0x894290
    public void BeforeProviderUpdate(){} // RVA: 0x894290
    public void AfterProviderUpdate(){} // RVA: 0x894290
    public void Inspect(){} // RVA: 0x894320
}

public class IFactoryControls
{
    // ── Methods ──
    public void CreateGameObject(){} // RVA: 0x87C5F0
}

public class IInput
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0x87D350
    public void GetAxisRaw(){} // RVA: 0x891020
    public void ClearLastPenContactEvent(){} // RVA: 0x894290
    public void GetLastPenContactEvent(){} // RVA: 0x87BEB0
    public void get_touchCount(){} // RVA: 0x87C130
    public void GetTouch(){} // RVA: 0x87BF40
    public void get_mousePresent(){} // RVA: 0x87D280
    public void GetMouseButtonDown(){} // RVA: 0x87DD20
    public void GetMouseButtonUp(){} // RVA: 0x87DD20
    public void get_mousePosition(){} // RVA: 0x87BEB0
    public void get_mouseButtonCount(){} // RVA: 0x87C130
    public void get_anyKey(){} // RVA: 0x87D280
    public void get_unscaledTime(){} // RVA: 0x890F90
    public void get_doubleClickTime(){} // RVA: 0x890F90
}

public class IInput
{
    // ── Methods ──
    public void get_compositionString(){} // RVA: 0x87C0A0
    public void GetKey(){} // RVA: 0x87DD20
    public void GetButtonDown(){} // RVA: 0x87D350
    public void GetAxisRaw(){} // RVA: 0x891020
    public void GetLastPenContactEvent(){} // RVA: 0x87BEB0
    public void get_touchSupported(){} // RVA: 0x87D280
    public void get_touchCount(){} // RVA: 0x87C130
    public void GetTouch(){} // RVA: 0x87BF40
    public void get_mousePresent(){} // RVA: 0x87D280
    public void GetMouseButton(){} // RVA: 0x87DD20
    public void GetMouseButtonDown(){} // RVA: 0x87DD20
    public void GetMouseButtonUp(){} // RVA: 0x87DD20
    public void get_mousePosition(){} // RVA: 0x87BEB0
    public void get_mouseScrollDelta(){} // RVA: 0x87C0A0
}

public class IJobSortable
{
    // ── Methods ──
    public void get_SortingBaseTransform(){} // RVA: 0x87C0A0
    public void get_MaximumExecutionGroups(){} // RVA: 0x87C130
    public void GetKnownDependencies(){} // RVA: 0x894320
    public void get_ExecutionGroup(){} // RVA: 0x87C130
    public void set_ExecutionGroup(){} // RVA: 0x8944F0
}

public class ILEmitResolverBuilderRuntimeContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class IListWrapper : ArrayList
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x687FE00
    public void set_Capacity(){} // RVA: 0x687FE80
    public void get_Count(){} // RVA: 0x687FF10
    public void get_IsReadOnly(){} // RVA: 0x687FF60
    public void get_IsFixedSize(){} // RVA: 0x687FFB0
    public void get_IsSynchronized(){} // RVA: 0x6880000
    public void get_Item(){} // RVA: 0x6880050
    public void set_Item(){} // RVA: 0x68800B0
    public void get_SyncRoot(){} // RVA: 0x6880130
    public void Add(){} // RVA: 0x6880180
    public void AddRange(){} // RVA: 0x68801F0
    public void Clear(){} // RVA: 0x6880240
    public void Clone(){} // RVA: 0x6880300
    public void Contains(){} // RVA: 0x6880360
    public void CopyTo(){} // RVA: 0x6880430
    public void GetEnumerator(){} // RVA: 0x6880760
    public void IndexOf(){} // RVA: 0x68807B0
    public void Insert(){} // RVA: 0x6880810
    public void InsertRange(){} // RVA: 0x6880890
    public void Remove(){} // RVA: 0x687F5F0
    public void RemoveAt(){} // RVA: 0x6880BF0
    public void RemoveRange(){} // RVA: 0x6880C60
    public void Reverse(){} // RVA: 0x6880E60
    public void Sort(){} // RVA: 0x6881240
    public void ToArray(){} // RVA: 0x68815D0
}

public class IMapFn`1
{
    // ── Methods ──
    public void Map(){} // RVA: 0xA94080
}

public class IOVRMeshDataProvider
{
    // ── Methods ──
    public void GetMeshType(){} // RVA: 0x87C130
}

public class IOVRMeshRendererDataProvider
{
    // ── Methods ──
    public void GetMeshRendererData(){} // RVA: 0x87BEB0
}

public class IOVRSceneComponent
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x894290
}

public class IOVRSkeletonRendererDataProvider
{
    // ── Methods ──
    public void GetSkeletonRendererData(){} // RVA: 0x87C0A0
}

public class IPSQuery : ApiModel
{
    // ── Methods ──
    public void get_require(){} // RVA: 0xBBFF90
    public void set_require(){} // RVA: 0xBBFFA0
    public void get_include(){} // RVA: 0xC10050
    public void set_include(){} // RVA: 0xC10060
    public void .ctor(){} // RVA: 0xA51C0D0
}

public class IPlayerActions
{
    // ── Methods ──
    public void OnMove(){} // RVA: 0x894320
    public void OnLook(){} // RVA: 0x894320
    public void OnFire(){} // RVA: 0x894320
}

public class ITime
{
    // ── Methods ──
    public void get_timeAsRational(){} // RVA: 0x87BEB0
}

public class ITokenReader
{
    // ── Methods ──
    public void Read(){} // RVA: 0x87C130
}

public class ITypeConstructor
{
    // ── Methods ──
    public void get_CanBeInstantiated(){} // RVA: 0x87D280
    public void Instantiate(){} // RVA: 0x87C0A0
}

public class ITypeConstructor`1
{
    // ── Methods ──
    public void Instantiate(){} // RVA: 0xA94080
    public void SetExplicitConstructor(){} // RVA: 0x894320
}

public class IUIActions
{
    // ── Methods ──
    public void OnNavigate(){} // RVA: 0x894320
    public void OnSubmit(){} // RVA: 0x894320
    public void OnCancel(){} // RVA: 0x894320
    public void OnPoint(){} // RVA: 0x894320
    public void OnClick(){} // RVA: 0x894320
    public void OnScrollWheel(){} // RVA: 0x894320
    public void OnMiddleClick(){} // RVA: 0x894320
    public void OnRightClick(){} // RVA: 0x894320
    public void OnTrackedDevicePosition(){} // RVA: 0x894320
    public void OnTrackedDeviceOrientation(){} // RVA: 0x894320
}

public class IVisualPredicateWrapper
{
    // ── Methods ──
    public void Predicate(){} // RVA: 0x87D350
}

public class IWebSocketReceiveResultGetter`1
{
    // ── Methods ──
    public void GetResult(){} // RVA: 0xA94080
}

public class Icon : ApiModel
{
    // ── Methods ──
    public void get_imageUrl(){} // RVA: 0xBBFF90
    public void set_imageUrl(){} // RVA: 0xBBFFA0
    public void .ctor(){} // RVA: 0xA59A7B0
}

public class IdentityTokenChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
}

public class IgnoresCaseHashtable : Object
{
    // ── Methods ──
    public void Clear(){} // RVA: 0xA55CDC0
    public void GetEnumerator(){} // RVA: 0xA55CE30
    public void get_Keys(){} // RVA: 0xA55CE80
    public void Remove(){} // RVA: 0xA55CED0
    public void get_Item(){} // RVA: 0xA55D000
    public void set_Item(){} // RVA: 0xA55D0E0
    public void get_Values(){} // RVA: 0xA55D210
    public void .ctor(){} // RVA: 0xA55D260
}

public class ImageHandle : SafeHandleZeroOrMinusOneIsInvalid
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x669B320
    public void ReleaseHandle(){} // RVA: 0x830D420
}

public class ImmutableCollectionTypeInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xC27FD0
    public void get_ContractTypeName(){} // RVA: 0xB5DBF0
    public void set_ContractTypeName(){} // RVA: 0xB44D60
    public void get_CreatedTypeName(){} // RVA: 0xB465B0
    public void set_CreatedTypeName(){} // RVA: 0xBA9BA0
    public void get_BuilderTypeName(){} // RVA: 0xB700F0
    public void set_BuilderTypeName(){} // RVA: 0xB70100
}

public class ImportStruct[] : Array
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

public class IndexedConverter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
}

public class IndirectDrawIndexedArgs : ValueType
{
    // ── Methods ──
    public void set_indexCountPerInstance(){} // RVA: 0x29580
    public void set_instanceCount(){} // RVA: 0x77EE0
    public void set_startIndex(){} // RVA: 0x92DD0
    public void set_baseVertexIndex(){} // RVA: 0x92DF0
    public void set_startInstance(){} // RVA: 0x8C7F0
}

public class InfiniteTimer : Timer
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7595300
    public void get_HasExpired(){} // RVA: 0xB43320
    public void Cancel(){} // RVA: 0x7595320
}

public class InfiniteTimerQueue : Queue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x16756E0
    public void CreateTimer(){} // RVA: 0x7594C10
}

public class Info : ApiModel
{
    // ── Methods ──
    public void get_period(){} // RVA: 0xBBFF90
    public void set_period(){} // RVA: 0xBBFFA0
    public void get_periodAmount(){} // RVA: 0x19C6270
    public void set_periodAmount(){} // RVA: 0xCE5450
    public void get_Period(){} // RVA: 0xA59AB60
    public void .ctor(){} // RVA: 0xA59AC40
}

public class InheritVelocityModule : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x97BD30
    public void set_enabled(){} // RVA: 0x97BD80
    public void get_mode(){} // RVA: 0x97BD90
    public void set_mode(){} // RVA: 0x97BDE0
    public void get_curve(){} // RVA: 0x97BE40
    public void set_curve(){} // RVA: 0x97BE70
    public void get_curveBlittable(){} // RVA: 0x97BEA0
    public void set_curveBlittable(){} // RVA: 0x97BF30
    public void get_curveMultiplier(){} // RVA: 0x97BFA0
    public void set_curveMultiplier(){} // RVA: 0x97BFF0
    public void get_curveBlittable_Injected(){} // RVA: 0x7CC84B0
    public void set_curveBlittable_Injected(){} // RVA: 0x7CC8510
}

public class Initial : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x664A5E0
}

public class Input : Object
{
    // ── Methods ──
    public void GetButtonDown(){} // RVA: 0xB618B0
    public void GetAxisRaw(){} // RVA: 0x8045DD0
    public void ClearLastPenContactEvent(){} // RVA: 0x7CA9790
    public void GetLastPenContactEvent(){} // RVA: 0x7CA8110
    public void get_touchCount(){} // RVA: 0x7CA81A0
    public void GetTouch(){} // RVA: 0x7CA81F0
    public void get_mousePresent(){} // RVA: 0x7CA82A0
    public void GetMouseButtonDown(){} // RVA: 0x7CA8300
    public void GetMouseButtonUp(){} // RVA: 0x7CA8350
    public void get_mousePosition(){} // RVA: 0xB61AB0
    public void get_mouseButtonCount(){} // RVA: 0x12FC4A0
    public void get_anyKey(){} // RVA: 0x7CA9810
    public void get_unscaledTime(){} // RVA: 0x7932A40
    public void get_doubleClickTime(){} // RVA: 0x8045DE0
    public void .ctor(){} // RVA: 0xB43310
}

public class InputEventControlCollection : ValueType
{
    // ── Methods ──
    public void get_eventPtr(){} // RVA: 0x77ED0
    public void GetEnumerator(){} // RVA: 0x931E00
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputControl>.GetEnumerator(){} // RVA: 0x931EB0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x931FC0
}

public class InputEventControlEnumerator : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x932190
    public void CheckDefault(){} // RVA: 0x9321A0
    public void CheckCurrent(){} // RVA: 0x9321D0
    public void MoveNext(){} // RVA: 0x932200
    public void Reset(){} // RVA: 0x932210
    public void Dispose(){} // RVA: 0x932220
    public void get_Current(){} // RVA: 0xC26F0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xC26F0
}

public class InputForUIProcessor : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x803FDE0
    public void OnEvent(){} // RVA: 0x803FFB0
    public void ProcessInputForUIEvents(){} // RVA: 0x8040060
    public void GetModifiers(){} // RVA: 0x80408C0
    public void ProcessPointerEvent(){} // RVA: 0x8040930
    public void ProcessNavigationEvent(){} // RVA: 0x8041580
    public void ProcessKeyEvent(){} // RVA: 0x8041D70
    public void ProcessTextInputEvent(){} // RVA: 0x80420D0
    public void ProcessCommandEvent(){} // RVA: 0x8042400
    public void ProcessIMECompositionEvent(){} // RVA: 0x8042490
}

public class InputMerger : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0x8943B0
}

public class InputPairing : Object
{
    // ── Methods ──
    public void GetKeyDown(){} // RVA: 0xA694D20
    public void .ctor(){} // RVA: 0xB43310
}

public class InputPairing[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class InspectedTypeScope`1 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void Dispose(){} // RVA: 0x894290
}

public class InstanceRefMethodCaller`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0x894320
    public void BeginInvoke(){} // RVA: 0x882090
    public void EndInvoke(){} // RVA: 0x8943B0
}

public class InstanceRefMethodCaller`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
    public void BeginInvoke(){} // RVA: 0xA94080
    public void EndInvoke(){} // RVA: 0x8943B0
}

public class InstanceRestoredDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x828CCC0
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0x828CDB0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class Instruction[] : Array
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

public class Instruction[] : Array
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

public class IntPoint[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EBFE10
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E774D0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class IntegerInput : TextValueInput
{
    // ── Methods ──
    public void get_parentIntegerField(){} // RVA: 0x7FF2EE0
    public void .ctor(){} // RVA: 0x7FF2F60
    public void get_allowedCharacters(){} // RVA: 0x7FF3120
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FF3180
    public void ValueToString(){} // RVA: 0x7FF33B0
    public void StringToValue(){} // RVA: 0x7FF34A0
}

public class Interaction : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class InteractionDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xCA8B20
    public void Invoke(){} // RVA: 0xCA8BF0
    public void BeginInvoke(){} // RVA: 0xCA8C00
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class InteractionEvent : Object
{
    // ── Methods ──
    public void Activate(){} // RVA: 0xCA2360
    public void .ctor(){} // RVA: 0xB43310
}

public class InteractionEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xCA8C90
    public void Invoke(){} // RVA: 0xCA8D60
    public void BeginInvoke(){} // RVA: 0xCA8D80
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class InteractionEvent[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class InteractionState : ValueType
{
    // ── Methods ──
    public void get_triggerControlIndex(){} // RVA: 0x92ADE0
    public void set_triggerControlIndex(){} // RVA: 0x92AE00
    public void get_startTime(){} // RVA: 0x85010
    public void set_startTime(){} // RVA: 0xDA1A0
    public void get_performedTime(){} // RVA: 0x92AE10
    public void set_performedTime(){} // RVA: 0x92AE20
    public void get_timerStartTime(){} // RVA: 0x26D8B0
    public void set_timerStartTime(){} // RVA: 0x92AE30
    public void get_timerDuration(){} // RVA: 0xD1B60
    public void set_timerDuration(){} // RVA: 0xD1B40
    public void get_totalTimeoutCompletionDone(){} // RVA: 0x9B0D0
    public void set_totalTimeoutCompletionDone(){} // RVA: 0x9B0A0
    public void get_totalTimeoutCompletionTimeRemaining(){} // RVA: 0x9B050
    public void set_totalTimeoutCompletionTimeRemaining(){} // RVA: 0x9B080
    public void get_timerMonitorIndex(){} // RVA: 0x8C700
    public void set_timerMonitorIndex(){} // RVA: 0x89060
    public void get_isTimerRunning(){} // RVA: 0x92AE40
    public void set_isTimerRunning(){} // RVA: 0x92AE50
    public void get_phase(){} // RVA: 0x90550
    public void set_phase(){} // RVA: 0x54210
}

public class InternalCollisionIgnoreSettings : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBBA2E0
}

public class Interop : Object
{
    // ── Methods ──
    public void GetRandomBytes(){} // RVA: 0x6668A30
    public void MemAlloc(){} // RVA: 0x6668B40
}

public class InvocationContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void Invoke(){} // RVA: 0x5DC5120
}

public class InvocationEntryDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1500
    public void Invoke(){} // RVA: 0xB9E010
}

public class IsAutoDispose : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x77D2400
}

public class IsBurstEnabledDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DFF2E0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class IsBurstEnabled_00000145$BurstDirectCall : Object
{
    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x77CB0A0
    public void GetFunctionPointer(){} // RVA: 0x77CB260
    public void Invoke(){} // RVA: 0x77CB420
}

public class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DFF2E0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void GetResult(){} // RVA: 0x77511D0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7751260
    public void GetStatus(){} // RVA: 0x77512E0
    public void UnsafeGetStatus(){} // RVA: 0x7751340
    public void OnCompleted(){} // RVA: 0x7751390
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsOfType`1 : Object
{
    // ── Methods ──
    public void Predicate(){} // RVA: 0x87D350
    public void .ctor(){} // RVA: 0x894290
    public void .cctor(){} // RVA: 0x8942F0
}

public class IsolatingRunSequence : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x651B3C0
}

public class ItemAttribute : ApiModel
{
    // ── Methods ──
    public void get_defaultValue(){} // RVA: 0xBBFF90
    public void set_defaultValue(){} // RVA: 0xBBFFA0
    public void get_validator(){} // RVA: 0xC10050
    public void set_validator(){} // RVA: 0xC10060
    public void .ctor(){} // RVA: 0xA522E50
}

public class ItemAttributeValidation : ApiModel
{
    // ── Methods ──
    public void get_type(){} // RVA: 0xBBFF90
    public void set_type(){} // RVA: 0xBBFFA0
    public void .ctor(){} // RVA: 0xA522EA0
}

public class iOSInfo : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x650B2C0
    public void FetchInfo(){} // RVA: 0x650B2D0
    public void get_CacheDir(){} // RVA: 0x650B390
    public void CheckMemoryStatusThread(){} // RVA: 0x650B4D0
    public void PollMemoryStatus(){} // RVA: 0x650B790
    public void GetMemoryStatus(){} // RVA: 0x650B910
    public void FetchMemoryStatus(){} // RVA: 0x650BA80
    public void get_FreeDiskSpaceBytes(){} // RVA: 0x650BA90
    public void .ctor(){} // RVA: 0xB43310
}

public class iOSVibration : Object
{
    // ── Methods ──
    public void Vibrate(){} // RVA: 0xB43000
    public void VibrateSimple(){} // RVA: 0xB43080
    public void .cctor(){} // RVA: 0xB43100
}

public class image_load_settings_t : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6E1050
    public void SetAllocationLimit(){} // RVA: 0x9CAAD0
    public void SetResolutionLimit(){} // RVA: 0x9CAB60
    public void op_Implicit(){} // RVA: 0x830D5A0
}
