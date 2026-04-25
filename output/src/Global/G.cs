// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 39
// Methods: 138

public class GPUBuffer`1 : Object
{
    public object ElementStride;
    public object BufferPointer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E092E60
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void UpdateRanges(){} // RVA: 0x7FFD4E2ADC40
    public void get_ElementStride(){} // RVA: 0x7FFD4E079960
    public void get_BufferPointer(){} // RVA: 0x7FFD4E078E90
}

public class GUIClearEvents : ValueType
{
}

public class GUIGlobals : ValueType
{
}

public class GalleryObject : ApiModel
{
    public object name;
    public object description;
    public object membersOnly;
    public object roleIdsToView;
    public object roleIdsToSubmit;
    public object roleIdsToAutoApprove;
    public object roleIdsToManage;
    public object createdAt;
    public object updatedAt;

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFD4E3BCD50
    public void set_name(){} // RVA: 0x7FFD4E3BCD60
    public void get_description(){} // RVA: 0x7FFD4E409590
    public void set_description(){} // RVA: 0x7FFD4E4095A0
    public void get_membersOnly(){} // RVA: 0x7FFD4E7EE5C0
    public void set_membersOnly(){} // RVA: 0x7FFD4F140B50
    public void get_roleIdsToView(){} // RVA: 0x7FFD4E70F410
    public void set_roleIdsToView(){} // RVA: 0x7FFD4E8F4AA0
    public void get_roleIdsToSubmit(){} // RVA: 0x7FFD4E380010
    public void set_roleIdsToSubmit(){} // RVA: 0x7FFD4E96E300
    public void get_roleIdsToAutoApprove(){} // RVA: 0x7FFD4E70F640
    public void set_roleIdsToAutoApprove(){} // RVA: 0x7FFD4E96E360
    public void get_roleIdsToManage(){} // RVA: 0x7FFD4E96DFB0
    public void set_roleIdsToManage(){} // RVA: 0x7FFD4E96E3C0
    public void get_createdAt(){} // RVA: 0x7FFD4E963900
    public void set_createdAt(){} // RVA: 0x7FFD53BAD950
    public void get_updatedAt(){} // RVA: 0x7FFD4E96B1A0
    public void set_updatedAt(){} // RVA: 0x7FFD4F9E9F60
    public void .ctor(){} // RVA: 0x7FFD5733CF20
}

public class GameObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD5749B970
    public void SetObjectData(){} // RVA: 0x7FFD5749BC00
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class GateFitParameters : ValueType
{
    public object mode;
    public object aspect;

    // ── Methods ──
    public void get_mode(){} // RVA: 0x7FFD4F840210
    public void set_mode(){} // RVA: 0x7FFD4E78D8B0
    public void get_aspect(){} // RVA: 0x7FFD4FEBB900
    public void set_aspect(){} // RVA: 0x7FFD4FEBB8F0
    public void .ctor(){} // RVA: 0x7FFD4E78D8D0
}

public class GenericPoolImpl`1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void Release(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class GenericSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD5749E230
    public void SetObjectData(){} // RVA: 0x7FFD5749F2C0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class GestureIcon : ValueType
{
}

public class GestureIndicator : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class GestureInputState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class GetAllQueuedEventsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5098C080
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
    public void BeginInvoke(){} // RVA: 0x7FFD4E39FA60
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class GetAvatarsResult : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class GetBinderAdapter : GetMemberBinder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void FallbackGetMember(){} // RVA: 0x7FFD4E08A6F0
}

public class GetBlendOverrideDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC636A0
    public void Invoke(){} // RVA: 0x7FFD4FC63820
    public void BeginInvoke(){} // RVA: 0x7FFD4FC63880
    public void EndInvoke(){} // RVA: 0x7FFD4FC63930
}

public class GetClassValueAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
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
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510D2620
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class GetDroneFromGameObjectDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5210BC10
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD5518CE60
    public void EndInvoke(){} // RVA: 0x7FFD53D8F1B0
}

public class GetEventCameraDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD522C1B30
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class GetLookRayDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510D2320
    public void Invoke(){} // RVA: 0x7FFD510CEA60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD5746E340
}

public class GetPropApiDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD52104810
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD522C1C10
    public void EndInvoke(){} // RVA: 0x7FFD53D8F1B0
}

public class GetPropFromGameObjectDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5210BC10
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD5518CE60
    public void EndInvoke(){} // RVA: 0x7FFD53D8F1B0
}

public class GetQueuedEventsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510DD490
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
    public void EndInvoke(){} // RVA: 0x7FFD4F8420D0
}

public class GetSecurityInfoNativeCall : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5387F700
    public void Invoke(){} // RVA: 0x7FFD510E1930
}

public class GetStructValueAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class GetterAdapter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EEF0660
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class Getter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class GiftDisplayReference : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class GpuTimestamp : ValueType
{
}

public class Grab : Object
{
    public object GlobalPosition;
    public object LocalOffset;

    // ── Methods ──
    public void get_GlobalPosition(){} // RVA: 0x7FFD5526E920
    public void set_GlobalPosition(){} // RVA: 0x7FFD5526E950
    public void get_LocalOffset(){} // RVA: 0x7FFD5526E980
    public void set_LocalOffset(){} // RVA: 0x7FFD5526E9B0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class GraphicsWarmupPreloadedShaders : ValueType
{
}

public class GridCell : ValueType
{
    // ── Methods ──
    public void IsValid(){} // RVA: 0x7FFD4FD7DDF0
    public void Init(){} // RVA: 0x7FFD55214F30
    public void Dispose(){} // RVA: 0x7FFD55215130
    public void RemoveShape(){} // RVA: 0x7FFD552151F0
    public void AddShape(){} // RVA: 0x7FFD55215290
}

public class Grouping : Object
{
    public object Key;
    public object System.Collections.Generic.ICollection<TElement>.Count;
    public object System.Collections.Generic.ICollection<TElement>.IsReadOnly;
    public object System.Collections.Generic.IList<TElement>.Item;

    // ── Methods ──
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void get_Key(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.ICollection<TElement>.get_Count(){} // RVA: 0x7FFD4E079960
    public void System.Collections.Generic.ICollection<TElement>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.ICollection<TElement>.Clear(){} // RVA: 0x7FFD4E090980
    public void System.Collections.Generic.ICollection<TElement>.Contains(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.ICollection<TElement>.CopyTo(){} // RVA: 0x7FFD4E097970
    public void System.Collections.Generic.ICollection<TElement>.Remove(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.IList<TElement>.IndexOf(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.IList<TElement>.Insert(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.IList<TElement>.RemoveAt(){} // RVA: 0x7FFD4E090ED0
    public void System.Collections.Generic.IList<TElement>.get_Item(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.IList<TElement>.set_Item(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class Grouping`2 : Object
{
    public object Key;

    // ── Methods ──
    public void get_Key(){} // RVA: 0x7FFD4E2ADC40
    public void set_Key(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void GetAsyncEnumerator(){}
    public void ToString(){} // RVA: 0x7FFD4E078E90
}

public class GrowableArrayEnumerator : ValueType
{
    public object System.Collections.IEnumerator.Current;
    public object Current;

    // ── Methods ──
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Reset(){} // RVA: 0x7FFD4E090980
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
}

public class GuidResult : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFD4E3440C0
    public void SetFailure(){} // RVA: 0x7FFD53A4E130 | overloaded x4
    public void GetGuidParseException(){} // RVA: 0x7FFD53A4E2D0
}
