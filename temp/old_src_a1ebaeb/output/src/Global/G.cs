// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 42
// Methods: 176

public class GPUBuffer`1 : Object
{
    public object elemStride; // 0x30FBFE30

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa86631a0
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    public void UpdateRanges(){} // RVA: 0x7ffaa887e5c0
    public void get_ElementStride(){} // RVA: 0x7ffaa8649ca0
    public void get_BufferPointer(){} // RVA: 0x7ffaa86491d0
}

public class GUIClearEvents : ValueType
{
}

public class GUIGlobals : ValueType
{
    public object contentColor; // 0x35BC3610
    public object changed; // 0x35BC3610
}

public class GalleryObject : ApiModel
{
    public object _membersOnly; // 0x3444D970, was: <membersOnly>k__BackingField
    public object _roleIdsToAutoApprove; // 0x3444D970, was: <roleIdsToAutoApprove>k__Backi
    public object _updatedAt; // 0x3444D970, was: <updatedAt>k__BackingField

    // ── Original Methods ──
    public void get_name(){} // RVA: 0x7ffaa89add50
    public void set_name(){} // RVA: 0x7ffaa89add60
    public void get_description(){} // RVA: 0x7ffaa89fa590
    public void set_description(){} // RVA: 0x7ffaa89fa5a0
    public void get_membersOnly(){} // RVA: 0x7ffaa8e00670
    public void set_membersOnly(){} // RVA: 0x7ffaa97510e0
    public void get_roleIdsToView(){} // RVA: 0x7ffaa8d1a3b0
    public void set_roleIdsToView(){} // RVA: 0x7ffaa8efece0
    public void get_roleIdsToSubmit(){} // RVA: 0x7ffaa8971010
    public void set_roleIdsToSubmit(){} // RVA: 0x7ffaa8f7b010
    public void get_roleIdsToAutoApprove(){} // RVA: 0x7ffaa8d1b980
    public void set_roleIdsToAutoApprove(){} // RVA: 0x7ffaa8f7b070
    public void get_roleIdsToManage(){} // RVA: 0x7ffaa8f75d20
    public void set_roleIdsToManage(){} // RVA: 0x7ffaa8f7b0d0
    public void get_createdAt(){} // RVA: 0x7ffaa8f78170
    public void set_createdAt(){} // RVA: 0x7ffaae1aeb60
    public void get_updatedAt(){} // RVA: 0x7ffaa8f74720
    public void set_updatedAt(){} // RVA: 0x7ffaa9fee770
    public void .ctor(){} // RVA: 0x7ffab1938bf0
}

public class GameObjectSurrogate : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetObjectData(){} // RVA: 0x7ffab1a97880
    public void SetObjectData(){} // RVA: 0x7ffab1a97b10
}

public class GateFitParameters : ValueType
{
    // ── Original Methods ──
    public void get_mode(){} // RVA: 0x7ffaa9e47550
    public void set_mode(){} // RVA: 0x7ffaa8d92880
    public void get_aspect(){} // RVA: 0x7ffaaa49daa0
    public void set_aspect(){} // RVA: 0x7ffaaa49db00
    public void .ctor(){} // RVA: 0x7ffaa8d928a0
}

public class GenericPoolImpl`1 : Object
{
    // ── Original Methods ──
    public void Release(){} // RVA: 0x7ffaa887e5c0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
    // ── Binary Analysis Named ──
    public void Get(){} // RVA: 0x7ffaa887e5c0
    public void Get(){} // RVA: 0x7ffaa887e5c0
}

public class GenericPoolImpl`1 : Object
{
    // ── Original Methods ──
    public void Release(){} // RVA: 0x7ffaab7aff10
    public void .cctor(){} // RVA: 0x7ffaab7afff0
    // ── Binary Analysis Named ──
    public void Get(){} // RVA: 0x7ffaab7afe10
    public void Get(){} // RVA: 0x7ffaab7afe10
}

public class GenericSurrogate : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetObjectData(){} // RVA: 0x7ffab1a9a140
    public void SetObjectData(){} // RVA: 0x7ffab1a9b1d0
}

public class GestureIcon : ValueType
{
}

public class GestureIndicator : Object
{
    public object gestureImages; // 0x334AEB80

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class GestureInputState : Object
{
    public object IsLeftHand; // 0x33EFF2E0
    public object IsAvailable; // 0x33EFF2E0
    public object EndAction; // 0x33EFF2E0
    public object HoldTimer; // 0x33EFF2E0
    public object deactivateSound; // 0x33EFF2E0
    public object f_AB2; // 0x336A4640, was: ÌÏÌÎÏÏÎÍÌÏÎÏÏÍÌÎÌÌÎÎÎÍÎ

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class GetAllQueuedEventsDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaaf72450
    public void Invoke(){} // RVA: 0x7ffaa8990a50
    public void EndInvoke(){} // RVA: 0x7ffaa9e48d90
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa8990a60
}

public class GetAvatarsResult : Object
{
    public object PassedValidation; // 0x34780790
    public object GetStatus; // 0xB419EFA0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class GetBinderAdapter : GetMemberBinder
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void FallbackGetMember(){} // RVA: 0x7ffaa865aa30
}

public class GetBlendOverrideDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa24b5b0
    public void Invoke(){} // RVA: 0x7ffaaa24b730
    public void EndInvoke(){} // RVA: 0x7ffaaa24b840
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaaa24b790
}

public class GetClassValueAction : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa887e5c0
}

public class GetComponentStateUnion : ValueType
{
}

public class GetControllerStateUnion : ValueType
{
}

public class GetControllerStateWithPoseUnion : ValueType
{
}

public class GetDroneDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab6ba650
    public void Invoke(){} // RVA: 0x7ffaa898dc60
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa898dc70
}

public class GetDroneFromGameObjectDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac6fcbb0
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
    public void EndInvoke(){} // RVA: 0x7ffaae3903c0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaaf78f890
}

public class GetEventCameraDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac8b29f0
    public void Invoke(){} // RVA: 0x7ffaa898dc60
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa898dc70
}

public class GetLookRayDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab6ba350
    public void Invoke(){} // RVA: 0x7ffaab6b6a90
    public void EndInvoke(){} // RVA: 0x7ffab1a69d30
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa898dc70
}

public class GetPropApiDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac6f57b0
    public void Invoke(){} // RVA: 0x7ffaa898dc60
    public void EndInvoke(){} // RVA: 0x7ffaae3903c0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaac8b2ad0
}

public class GetPropFromGameObjectDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac6fcbb0
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
    public void EndInvoke(){} // RVA: 0x7ffaae3903c0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaaf78f890
}

public class GetQueuedEventsDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab6c54c0
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
    public void EndInvoke(){} // RVA: 0x7ffaa9e48d90
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa94f9e30
}

public class GetSecurityInfoNativeCall : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaade808b0
    public void Invoke(){} // RVA: 0x7ffaab6ef8a0
}

public class GetStructValueAction : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa887e5c0
}

public class GetterAdapter : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa94f9e70
    public void Invoke(){} // RVA: 0x7ffaa898dc60
}

public class Getter`2 : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7ffaa887e5c0
}

public class GiftDisplayReference : Object
{
    public object display; // 0x33FD4830

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class GpuTimestamp : ValueType
{
}

public class Grab : Object
{
    public object bone; // 0x35135420
    public object pose; // 0x35135420
    public object Capacity; // 0x170008CD
    public object Count; // 0x170008CE

    // ── Original Methods ──
    public void get_GlobalPosition(){} // RVA: 0x7ffaaf871340
    public void set_GlobalPosition(){} // RVA: 0x7ffaaf871370
    public void get_LocalOffset(){} // RVA: 0x7ffaaf8713a0
    public void set_LocalOffset(){} // RVA: 0x7ffaaf8713d0
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class GraphicsWarmupPreloadedShaders : ValueType
{
}

public class GridCell : ValueType
{
    public object activeList; // 0x3510E080
    public object 00; // 0x351212E8

    // ── Original Methods ──
    public void IsValid(){} // RVA: 0x7ffaaa365870
    public void Init(){} // RVA: 0x7ffaaf817950
    public void Dispose(){} // RVA: 0x7ffaaf817b50
    public void RemoveShape(){} // RVA: 0x7ffaaf817c10
    public void AddShape(){} // RVA: 0x7ffaaf817cb0
}

public class Grouping : Object
{
    public object elements; // 0x30C79AC0
    public object next; // 0x30C79AC0
    public object Key; // 0x17000037
    public object System.Collections.Generic.ICollection<TElement>.Count; // 0x17000038

    // ── Original Methods ──
    public void Add(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void get_Key(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.ICollection<TElement>.get_Count(){} // RVA: 0x7ffaa8649ca0
    public void System.Collections.Generic.ICollection<TElement>.get_IsReadOnly(){} // RVA: 0x7ffaa864a040
    public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.ICollection<TElement>.Clear(){} // RVA: 0x7ffaa8660cc0
    public void System.Collections.Generic.ICollection<TElement>.Contains(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.ICollection<TElement>.CopyTo(){} // RVA: 0x7ffaa8667cb0
    public void System.Collections.Generic.ICollection<TElement>.Remove(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IList<TElement>.IndexOf(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IList<TElement>.Insert(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IList<TElement>.RemoveAt(){} // RVA: 0x7ffaa8661210
    public void System.Collections.Generic.IList<TElement>.get_Item(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IList<TElement>.set_Item(){} // RVA: 0x7ffaa887e5c0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
}

public class Grouping : Object
{
    public object elements; // 0x37A0AA00
    public object next; // 0x37A0AA00

    // ── Original Methods ──
    public void Add(){} // RVA: 0x7ffaab7bd4d0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaab7bd2d0
    public void get_Key(){} // RVA: 0x7ffaa894d380
    public void System.Collections.Generic.ICollection<TElement>.get_Count(){} // RVA: 0x7ffaa8d14570
    public void System.Collections.Generic.ICollection<TElement>.get_IsReadOnly(){} // RVA: 0x7ffaa8a17850
    public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7ffaab7bd370
    public void System.Collections.Generic.ICollection<TElement>.Clear(){} // RVA: 0x7ffaab7bd390
    public void System.Collections.Generic.ICollection<TElement>.Contains(){} // RVA: 0x7ffaab7bd580
    public void System.Collections.Generic.ICollection<TElement>.CopyTo(){} // RVA: 0x7ffaab7bd5c0
    public void System.Collections.Generic.ICollection<TElement>.Remove(){} // RVA: 0x7ffaab7bd370
    public void System.Collections.Generic.IList<TElement>.IndexOf(){} // RVA: 0x7ffaab7bd5f0
    public void System.Collections.Generic.IList<TElement>.Insert(){} // RVA: 0x7ffaab7bd450
    public void System.Collections.Generic.IList<TElement>.RemoveAt(){} // RVA: 0x7ffaab7bd370
    public void System.Collections.Generic.IList<TElement>.get_Item(){} // RVA: 0x7ffaab7bd620
    public void System.Collections.Generic.IList<TElement>.set_Item(){} // RVA: 0x7ffaab7bd450
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaab7bd240
}

public class Grouping : Object
{
    public object elements; // 0x37B640F0
    public object next; // 0x37B640F0

    // ── Original Methods ──
    public void Add(){} // RVA: 0x7ffaab7bd4d0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaab7bd2d0
    public void get_Key(){} // RVA: 0x7ffaa894d380
    public void System.Collections.Generic.ICollection<TElement>.get_Count(){} // RVA: 0x7ffaa8d14570
    public void System.Collections.Generic.ICollection<TElement>.get_IsReadOnly(){} // RVA: 0x7ffaa8a17850
    public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7ffaab7bd370
    public void System.Collections.Generic.ICollection<TElement>.Clear(){} // RVA: 0x7ffaab7bd390
    public void System.Collections.Generic.ICollection<TElement>.Contains(){} // RVA: 0x7ffaab7bd580
    public void System.Collections.Generic.ICollection<TElement>.CopyTo(){} // RVA: 0x7ffaab7bd5c0
    public void System.Collections.Generic.ICollection<TElement>.Remove(){} // RVA: 0x7ffaab7bd370
    public void System.Collections.Generic.IList<TElement>.IndexOf(){} // RVA: 0x7ffaab7bd5f0
    public void System.Collections.Generic.IList<TElement>.Insert(){} // RVA: 0x7ffaab7bd450
    public void System.Collections.Generic.IList<TElement>.RemoveAt(){} // RVA: 0x7ffaab7bd370
    public void System.Collections.Generic.IList<TElement>.get_Item(){} // RVA: 0x7ffaab7bd620
    public void System.Collections.Generic.IList<TElement>.set_Item(){} // RVA: 0x7ffaab7bd450
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaab7bd240
}

public class Grouping`2 : Object
{
    // ── Original Methods ──
    public void get_Key(){} // RVA: 0x7ffaa887e5c0
    public void set_Key(){} // RVA: 0x7ffaa887e5c0
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void Add(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void ToString(){} // RVA: 0x7ffaa86491d0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void GetAsyncEnumerator(){}
}

public class GrowableArrayEnumerator : ValueType
{
    public object array; // 0x30FF6DD0

    // ── Original Methods ──
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaa86491d0
    public void get_Current(){} // RVA: 0x7ffaa887e5c0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Reset(){} // RVA: 0x7ffaa8660cc0
    public void Dispose(){} // RVA: 0x7ffaa8660cc0
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
}

public class GuidResult : ValueType
{
    public object _failure; // 0x3444FB70
    public object _failureArgumentName; // 0x3444FB70

    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaa89350c0
    // ── Binary Analysis Named ──
    public void SetFailure(){} // RVA: 0x7ffaae04f340
    public void SetFailure(){} // RVA: 0x7ffaae04f340
    public void SetFailure(){} // RVA: 0x7ffaae04f340
    public void SetFailure(){} // RVA: 0x7ffaae04f340
    public void GetGuidParseException(){} // RVA: 0x7ffaae04f4e0
}
