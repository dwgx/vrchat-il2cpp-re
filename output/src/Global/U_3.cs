// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 237

public class UIActions : ValueType
{
    public object m_Wrapper;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_Navigate(){} // RVA: 0x4FA60
    public void get_Submit(){} // RVA: 0x4FA10
    public void get_Cancel(){} // RVA: 0x4F930
    public void get_Point(){} // RVA: 0x4F9B0
    public void get_Click(){} // RVA: 0x4F900
    public void get_ScrollWheel(){} // RVA: 0x4F8D0
    public void get_MiddleClick(){} // RVA: 0x4F9D0
    public void get_RightClick(){} // RVA: 0x4F950
    public void get_TrackedDevicePosition(){} // RVA: 0x4FA30
    public void get_TrackedDeviceOrientation(){} // RVA: 0x4F9F0
    public void Get(){} // RVA: 0x4F770
    public void Enable(){} // RVA: 0x935270
    public void Disable(){} // RVA: 0x9352F0
    public void get_enabled(){} // RVA: 0x935330
    public void op_Implicit(){} // RVA: 0x263CCE0
    public void SetCallbacks(){} // RVA: 0x935360
}

public class UISupport : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x77D48B0
}

public class UQueryMatcher : HierarchyTraversal
{
    public object m_Matchers;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void Traverse(){} // RVA: 0x7F14C00
    public void OnRuleMatchedElement(){} // RVA: 0x263B110
    public void NoProcessResult(){} // RVA: 0xB43310
    public void TraverseRecursive(){} // RVA: 0x7F14C20
    public void Run(){} // RVA: 0x7F14EE0
}

public class Union : Object
{
    public object TagReader;
    public object Cases;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
}

public class UnionCase : Object
{
    public object Tag;
    public object Name;
    public object Fields;
    public object FieldReader;
    public object Constructor;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6AD8CB0
}

public class UnityEventHandlerAsyncEnumerator : MoveNextSource
{
    public object cancel1;
    public object cancel2;
    public object unityEvent;
    public object cancellationToken1;
    public object cancellationToken2;
    public object unityAction;
    public object registration1;
    public object registration2;
    public object isDisposed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5096AA0
    public void get_Current(){} // RVA: 0xB43320
    public void MoveNextAsync(){} // RVA: 0x779F7B0
    public void Invoke(){} // RVA: 0x779FBA0
    public void OnCanceled1(){} // RVA: 0x779FBE0
    public void OnCanceled2(){} // RVA: 0x779FD30
    public void DisposeAsync(){} // RVA: 0x779FE40
    public void .cctor(){} // RVA: 0x779FF20
}

public class UnityOpenXR : Object
{
    public object Enabled;

    // ── Methods ──
    public void SetClientVersion(){} // RVA: 0x6BE8470
    public void HookGetInstanceProcAddr(){} // RVA: 0x6BE8660
    public void OnInstanceCreate(){} // RVA: 0x6BE8800
    public void OnInstanceDestroy(){} // RVA: 0x6BE89A0
    public void OnSessionCreate(){} // RVA: 0x6BE8B30
    public void OnAppSpaceChange(){} // RVA: 0x6BE8CC0
    public void OnSessionStateChange(){} // RVA: 0x6BE8E50
    public void OnSessionBegin(){} // RVA: 0x6BE8FF0
    public void OnSessionEnd(){} // RVA: 0x6BE9180
    public void OnSessionExiting(){} // RVA: 0x6BE9310
    public void OnSessionDestroy(){} // RVA: 0x6BE94A0
    public void .ctor(){} // RVA: 0xB43310
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x77D4930
    public void .ctor(){} // RVA: 0xB43310
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x776B040
    public void .ctor(){} // RVA: 0xB43310
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x6C3FDE0
    public void .ctor(){} // RVA: 0xB43310
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0xB43F70
    public void .ctor(){} // RVA: 0xB43310
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x77410C0
    public void .ctor(){} // RVA: 0xB43310
}

public class UnityWebRequestAsyncOperationConfiguredSource : Object
{
    public object pool;
    public object nextNode;
    public object asyncOperation;
    public object progress;
    public object cancellationToken;
    public object cancellationTokenRegistration;
    public object cancelImmediately;
    public object completed;
    public object core;
    public object continuationAction;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x4865E00
    public void .cctor(){} // RVA: 0x779C000
    public void .ctor(){} // RVA: 0x779C140
    public void Create(){} // RVA: 0x779C200
    public void GetResult(){} // RVA: 0x779C770
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x779C9F0
    public void GetStatus(){} // RVA: 0x779CA00
    public void UnsafeGetStatus(){} // RVA: 0x779CA50
    public void OnCompleted(){} // RVA: 0x779CA90
    public void MoveNext(){} // RVA: 0x779CB10
    public void TryReturn(){} // RVA: 0x779CDB0
    public void Continuation(){} // RVA: 0x779CF20
}

public class UnsignedIntegerInput : TextValueInput
{
    // ── Methods ──
    public void get_parentUnsignedIntegerField(){} // RVA: 0x803B810
    public void .ctor(){} // RVA: 0x803B890
    public void get_allowedCharacters(){} // RVA: 0x803BA50
    public void ApplyInputDeviceDelta(){} // RVA: 0x803BAB0
    public void ValueToString(){} // RVA: 0x803BCD0
    public void StringToValue(){} // RVA: 0x803BDC0
}

public class UnsignedLongInput : TextValueInput
{
    // ── Methods ──
    public void get_parentUnsignedLongField(){} // RVA: 0x803CA90
    public void .ctor(){} // RVA: 0x803CB10
    public void get_allowedCharacters(){} // RVA: 0x803CCD0
    public void ApplyInputDeviceDelta(){} // RVA: 0x803CD30
    public void ClampToMinMaxULongValue(){} // RVA: 0x803D010
    public void ValueToString(){} // RVA: 0x803D0B0
    public void StringToValue(){} // RVA: 0x803D1A0
}

public class UpdateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
    public void BeginInvoke(){} // RVA: 0xBA10C0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class UpdateStepCount : ValueType
{
    public object m_WasUpdated;
    public object _value;

    // ── Methods ──
    public void get_value(){} // RVA: 0x77E50
    public void set_value(){} // RVA: 0x77EE0
    public void OnBeforeUpdate(){} // RVA: 0x93C840
    public void OnUpdate(){} // RVA: 0x93C850
}

public class UpdaterArray : Object
{
    public object m_VisualTreeUpdaters;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7F38AF0
    public void set_Item(){} // RVA: 0x7F38B80
    public void get_Item(){} // RVA: 0x753C8F0
}

public class UsingEntry : ValueType
{
    public object comparer;
    public object alias;
    public object path;
    public object asset;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x940E80
    public void .cctor(){} // RVA: 0x7F293E0
}

public class UsingEntryComparer : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7F29490
    public void .ctor(){} // RVA: 0xB43310
}

public class UsingEntry[] : Array
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

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF2E50
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF3670
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF4760
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF5660
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF9BA0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x800AFF0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x800C5D0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x800E940
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8010A70
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8011AF0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x80142A0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8015280
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8017410
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8021B50
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8023D20
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x80257C0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x80292F0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x802F110
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x80302F0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8032F30
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8034F30
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8038C20
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x803B780
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x803CA00
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8082780
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7EC17A0
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void get_uxmlName(){} // RVA: 0x7EEC990
    public void get_uxmlQualifiedName(){} // RVA: 0x7EEC9D0
    public void .ctor(){} // RVA: 0x7EECA50
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7F080C0
}

public class UxmlObjectEntry : ValueType
{
    public object parentId;
    public object uxmlObjectAssets;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3616C0
    public void GetField(){} // RVA: 0x99B410
    public void ToString(){} // RVA: 0x99B420
}

public class UxmlObjectEntry[] : Array
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

public class UxmlObjectFactory : UxmlObjectFactory`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFCB10
}

public class UxmlObjectFactory : UxmlObjectFactory`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8005440
}

public class UxmlObjectFactory : UxmlObjectFactory`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x800D8E0
}

public class UxmlObjectFactory : UxmlObjectFactory`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x800E560
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x894290
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F1E40
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x894290
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F1E40
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x894290
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F1E40
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x894290
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F1E40
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public object m_Name;
    public object m_Text;
    public object m_Visible;
    public object m_Width;
    public object m_MinWidth;
    public object m_MaxWidth;
    public object m_Stretch;
    public object m_Sortable;
    public object m_Optional;
    public object m_Resizable;
    public object m_HeaderTemplateId;
    public object m_CellTemplateId;
    public object m_BindingPath;

    // ── Methods ──
    public void ParseLength(){} // RVA: 0xA94080
    public void Init(){} // RVA: 0x8954D0
    public void .ctor(){} // RVA: 0x894290
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public object m_PrimaryColumnName;
    public object m_StretchMode;
    public object m_Reorderable;
    public object m_Resizable;
    public object m_ResizePreview;
    public object m_Columns;

    // ── Methods ──
    public void Init(){} // RVA: 0x8954D0
    public void .ctor(){} // RVA: 0x894290
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public object m_ColumnName;
    public object m_ColumnIndex;
    public object m_SortDescription;

    // ── Methods ──
    public void Init(){} // RVA: 0x8954D0
    public void .ctor(){} // RVA: 0x894290
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public object m_SortColumnDescriptions;

    // ── Methods ──
    public void Init(){} // RVA: 0x8954D0
    public void .ctor(){} // RVA: 0x894290
}

public class UxmlTraits : TextValueFieldTraits`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF2EA0
}

public class UxmlTraits : UxmlTraits
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF36C0
}

public class UxmlTraits : UxmlTraits
{
    public object m_ItemTemplate;

    // ── Methods ──
    public void Init(){} // RVA: 0x7FF47B0
    public void .ctor(){} // RVA: 0x7FF4910
}

public class UxmlTraits : UxmlTraits
{
    public object m_Label;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F6890
    public void Init(){} // RVA: 0x50F5C30
}

public class UxmlTraits : TextValueFieldTraits`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF56B0
}

public class UxmlTraits : UxmlTraits
{
    public object m_MinValue;
    public object m_MaxValue;
    public object m_LowLimit;
    public object m_HighLimit;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF9BF0
    public void Init(){} // RVA: 0x7FFA050
}

public class UxmlTraits : UxmlTraits
{
    public object m_SortingMode;
    public object m_Columns;
    public object m_SortColumnDescriptions;

    // ── Methods ──
    public void Init(){} // RVA: 0x800B040
    public void .ctor(){} // RVA: 0x800B460
}

public class UxmlTraits : UxmlTraits
{
    public object m_SortingMode;
    public object m_Columns;
    public object m_SortColumnDescriptions;

    // ── Methods ──
    public void Init(){} // RVA: 0x800C620
    public void .ctor(){} // RVA: 0x800CA40
}

public class UxmlTraits : UxmlTraits
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FF36C0
}

public class UxmlTraits : UxmlTraits
{
    public object m_LowValue;
    public object m_HighValue;
    public object m_Value;
    public object m_Title;

    // ── Methods ──
    public void Init(){} // RVA: 0x8010100
    public void .ctor(){} // RVA: 0x8010580
}

public class UxmlTraits : UxmlTraits
{
    public object m_Label;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F5AB0
    public void Init(){} // RVA: 0x50F5C30
}

public class UxmlTraits : BaseFieldTraits`2
{
    public object m_Text;

    // ── Methods ──
    public void Init(){} // RVA: 0x8011B40
    public void .ctor(){} // RVA: 0x8011C90
}

public class UxmlTraits : BaseFieldTraits`2
{
    public object m_Choices;

    // ── Methods ──
    public void Init(){} // RVA: 0x80142F0
    public void .ctor(){} // RVA: 0x8014450
}

public class UxmlTraits : UxmlTraits
{
    public object m_Delay;
    public object m_Interval;

    // ── Methods ──
    public void Init(){} // RVA: 0x80152D0
    public void .ctor(){} // RVA: 0x8015490
}

public class UxmlTraits : UxmlTraits
{
    public object m_LowValue;
    public object m_HighValue;
    public object m_Direction;
    public object m_Value;

    // ── Methods ──
    public void Init(){} // RVA: 0x8017460
    public void .ctor(){} // RVA: 0x8017700
}

public class UxmlTraits : UxmlTraits
{
    public object m_ScrollViewMode;
    public object m_NestedInteractionKind;
    public object m_ShowHorizontal;
    public object m_ShowVertical;
    public object m_HorizontalScrollerVisibility;
    public object m_VerticalScrollerVisibility;
    public object m_HorizontalPageSize;
    public object m_VerticalPageSize;
    public object m_MouseWheelScrollSize;
    public object m_TouchScrollBehavior;
    public object m_ScrollDecelerationRate;
    public object m_Elasticity;

    // ── Methods ──
    public void Init(){} // RVA: 0x8021BA0
    public void .ctor(){} // RVA: 0x80223F0
}

public class UxmlTraits : UxmlTraits`1
{
    public object m_LowValue;
    public object m_HighValue;
    public object m_PageSize;
    public object m_ShowInputField;
    public object m_Direction;
    public object m_Inverted;

    // ── Methods ──
    public void Init(){} // RVA: 0x8023D70
    public void .ctor(){} // RVA: 0x8024100
}

public class UxmlTraits : UxmlTraits`1
{
    public object m_LowValue;
    public object m_HighValue;
    public object m_PageSize;
    public object m_ShowInputField;
    public object m_Direction;
    public object m_Inverted;

    // ── Methods ──
    public void Init(){} // RVA: 0x8025810
    public void .ctor(){} // RVA: 0x8025C40
}

public class UxmlTraits : UxmlTraits
{
    public object m_Label;
    public object m_IconImage;
    public object m_Closeable;

    // ── Methods ──
    public void Init(){} // RVA: 0x8029340
    public void .ctor(){} // RVA: 0x8029670
}

public class UxmlTraits : UxmlTraits
{
    public object m_Reorderable;

    // ── Methods ──
    public void Init(){} // RVA: 0x802F160
    public void .ctor(){} // RVA: 0x802F2B0
}

public class UxmlTraits : BaseFieldTraits`2
{
    public object m_Text;

    // ── Methods ──
    public void Init(){} // RVA: 0x8030340
    public void .ctor(){} // RVA: 0x8030490
}

public class UxmlTraits : UxmlTraits
{
    public object m_Label;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F9490
    public void Init(){} // RVA: 0x50F6570
}

public class UxmlTraits : UxmlTraits
{
    public object m_IsMultipleSelection;
    public object m_AllowEmptySelection;

    // ── Methods ──
    public void Init(){} // RVA: 0x8032F80
    public void .ctor(){} // RVA: 0x8033270
}

public class UxmlTraits : UxmlTraits
{
    public object m_ItemTemplate;

    // ── Methods ──
    public void Init(){} // RVA: 0x8034F80
    public void .ctor(){} // RVA: 0x80350E0
}

public class UxmlTraits : UxmlTraits
{
    public object m_FixedPaneIndex;
    public object m_FixedPaneInitialDimension;
    public object m_Orientation;

    // ── Methods ──
    public void Init(){} // RVA: 0x8038C70
    public void .ctor(){} // RVA: 0x8038E80
}

public class UxmlTraits : UxmlTraits
{
    public object m_Label;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F9610
    public void Init(){} // RVA: 0x50F5C30
}

public class UxmlTraits : TextValueFieldTraits`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x803B7D0
}

public class UxmlTraits : UxmlTraits
{
    public object m_Label;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x50F9790
    public void Init(){} // RVA: 0x50F5C30
}

public class UxmlTraits : TextValueFieldTraits`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x803CA50
}

public class UxmlTraits : UxmlTraits
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x80827D0
}

public class UxmlTraits : UxmlTraits
{
    public object m_Template;

    // ── Methods ──
    public void Init(){} // RVA: 0x7EECAA0
    public void .ctor(){} // RVA: 0x7EED190
}

public class UxmlTraits`1 : BaseFieldTraits`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x50FBDC0
}

public class UxmlTraits`1 : BaseFieldTraits`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x50FBD50
}
