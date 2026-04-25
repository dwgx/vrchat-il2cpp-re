// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 31
// Methods: 151

public class BakeTextureOutput : ValueType
{
}

public class BakedSolution : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC6B2A0
    public void IsValid(){} // RVA: 0x7FFD4FC6B3D0
    public void ConfinePoint(){} // RVA: 0x7FFD4FC6B3E0
    public void FindIntersection(){} // RVA: 0x7FFD4FC6BA50
    public void <ConfinePoint>g__IntPointLerp|9_0(){} // RVA: 0x7FFD4FC6BC70
    public void <ConfinePoint>g__IsInsideOriginal|9_1(){} // RVA: 0x7FFD4FC6BD10
    public void <ConfinePoint>g__ClosestPointOnSegment|9_2(){} // RVA: 0x7FFD4FC6BDF0
    public void <ConfinePoint>g__DoesIntersectOriginal|9_3(){} // RVA: 0x7FFD4FC6BE80
    public void <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(){} // RVA: 0x7FFD4FC6C0F0
}

public class BakingStateCache : ValueType
{
}

public class BaseVisualElementScheduledItem : ScheduledItem
{
    public object element;

    // ── Methods ──
    public void get_element(){} // RVA: 0x7FFD4E5F0140
    public void set_element(){} // RVA: 0x7FFD4E5F0C20
    public void .ctor(){} // RVA: 0x7FFD55013DB0
    public void StartingIn(){} // RVA: 0x7FFD55013FD0
    public void Every(){} // RVA: 0x7FFD55013FE0
    public void OnItemUnscheduled(){} // RVA: 0x7FFD550140F0
    public void Resume(){} // RVA: 0x7FFD55014130
    public void Pause(){} // RVA: 0x7FFD55014160
    public void ExecuteLater(){} // RVA: 0x7FFD55014190
    public void OnPanelActivate(){} // RVA: 0x7FFD55014210
    public void OnPanelDeactivate(){} // RVA: 0x7FFD550142E0
    public void CanBeActivated(){} // RVA: 0x7FFD55014360
}

public class BatchModeUpdate : ValueType
{
}

public class BinderState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A95550
}

public class BindingSyntax : ValueType
{
    public object valid;
    public object bindingIndex;
    public object binding;

    // ── Methods ──
    public void get_valid(){} // RVA: 0x7FFD5495F330
    public void get_bindingIndex(){} // RVA: 0x7FFD5495F3A0
    public void get_binding(){} // RVA: 0x7FFD5495F420
    public void .ctor(){} // RVA: 0x7FFD5495F520
    public void WithName(){} // RVA: 0x7FFD5495F5E0
    public void WithPath(){} // RVA: 0x7FFD5495F740
    public void WithGroup(){} // RVA: 0x7FFD5495F8B0
    public void WithGroups(){} // RVA: 0x7FFD5495FAC0
    public void WithInteraction(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void WithInteractions(){} // RVA: 0x7FFD5495FF60
    public void WithProcessor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void WithProcessors(){} // RVA: 0x7FFD54960400
    public void Triggering(){} // RVA: 0x7FFD54960690
    public void To(){} // RVA: 0x7FFD549608A0
    public void NextBinding(){} // RVA: 0x7FFD54960A40
    public void PreviousBinding(){} // RVA: 0x7FFD54960A80
    public void NextPartBinding(){} // RVA: 0x7FFD54960AC0
    public void PreviousPartBinding(){} // RVA: 0x7FFD54960B50
    public void NextCompositeBinding(){} // RVA: 0x7FFD54960BE0
    public void PreviousCompositeBinding(){} // RVA: 0x7FFD54960C20
    public void Iterate(){} // RVA: 0x7FFD54960C60
    public void IterateCompositeBinding(){} // RVA: 0x7FFD54960D60
    public void IteratePartBinding(){} // RVA: 0x7FFD54961080
    public void Erase(){} // RVA: 0x7FFD549612E0
    public void InsertPartBinding(){} // RVA: 0x7FFD54961720
}

public class BitRegion : ValueType
{
    public object isEmpty;

    // ── Methods ──
    public void get_isEmpty(){} // RVA: 0x7FFD5498A470
    public void .ctor(){} // RVA: 0x7FFD5498A480 | overloaded x2
    public void Overlap(){} // RVA: 0x7FFD5498A490
}

public class BlendshapesConfig : Object
{
    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4F92A230
    public void Equals(){} // RVA: 0x7FFD4F92A430
    public void GetHashCode(){} // RVA: 0x7FFD4F92A830
    public void op_Implicit(){} // RVA: 0x7FFD4F92AA30
    public void CompareBaseObjects(){} // RVA: 0x7FFD4F92AC40
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F92AE50
    public void GetCachedPtr(){} // RVA: 0x7FFD4F92B060
    public void get_name(){} // RVA: 0x7FFD4F92B460
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Initialize(){} // RVA: 0x7FFD4F92B660
    public void Instantiate(){} // RVA: 0x7FFD4F92B860
}

public class BlendshapesConfigForExport : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class Block : ValueType
{
    public object Bytes;
    public object AllocatedBytes;
    public object Alignment;

    // ── Methods ──
    public void get_Bytes(){} // RVA: 0x7FFD5492F3E0
    public void get_AllocatedBytes(){} // RVA: 0x7FFD5492F3F0
    public void get_Alignment(){} // RVA: 0x7FFD5492F400
    public void set_Alignment(){} // RVA: 0x7FFD5492F410
    public void Dispose(){} // RVA: 0x7FFD5492F460
    public void TryFree(){} // RVA: 0x7FFD5492F460
}

public class Bone : ValueType
{
    public object isSimulated;

    // ── Methods ──
    public void get_isSimulated(){} // RVA: 0x7FFD55262AC0
}

public class BoolChildrenSection : ChildrenSection`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD56CF3280
}

public class BoolDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EF032D0
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4EF03450
}

public class BoolEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD56B837A0
}

public class BoundedChannelReader : ChannelReader`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void TryRead(){} // RVA: 0x7FFD4E079F60
    public void WaitToReadAsync(){}
    public void DequeueItemAndPostProcess(){} // RVA: 0x7FFD4E2ADC40
}

public class BoundedChannelWriter : ChannelWriter`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void TryComplete(){} // RVA: 0x7FFD4E079F60
    public void TryWrite(){} // RVA: 0x7FFD4E2ADC40
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7FFD4E2ADC40
}

public class BoxAvoidance : Object
{
    // ── Methods ──
    public void ToInt(){} // RVA: 0x7FFD4E2ADC40
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class BrainEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC174A0
}

public class BrainFrame : Object
{
    public object Active;

    // ── Methods ──
    public void get_Active(){} // RVA: 0x7FFD4FC175C0
    public void .ctor(){} // RVA: 0x7FFD4FC175E0
}

public class Bucket : Object
{
    public object Id;

    // ── Methods ──
    public void .ctor(){}
    public void get_Id(){} // RVA: 0x7FFD4E079960
    public void Rent(){} // RVA: 0x7FFD4E078E90
    public void Return(){} // RVA: 0x7FFD4E090A40
}

public class BufferedAsyncEnumerable : Object
{
    // ── Methods ──
    public void GetAsyncEnumerator(){}
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class BufferedAudioStream : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53C384F0
    public void Update(){} // RVA: 0x7FFD53C386E0
    public void Stop(){} // RVA: 0x7FFD53C388D0
    public void AddData(){} // RVA: 0x7FFD53C389A0
}

public class Builder : Object
{
    public object Capacity;
    public object Count;
    public object Item;
    public object System.Collections.Generic.ICollection<T>.IsReadOnly;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void get_Capacity(){} // RVA: 0x7FFD4E079960
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void set_Count(){} // RVA: 0x7FFD4E090ED0
    public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFD4E0909B0
    public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    public void set_Item(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
    public void MoveToImmutable(){} // RVA: 0x7FFD4E2ADC40
    public void Clear(){} // RVA: 0x7FFD4E090980
    public void Insert(){} // RVA: 0x7FFD4E2ADC40
    public void Add(){} // RVA: 0x7FFD4E2ADC40
    public void Remove(){} // RVA: 0x7FFD4E2ADC40
    public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
    public void Contains(){} // RVA: 0x7FFD4E2ADC40
    public void CopyTo(){} // RVA: 0x7FFD4E097970
    public void EnsureCapacity(){} // RVA: 0x7FFD4E090ED0
    public void IndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class BuiltInUriParser : UriParser
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD547B1540
}

public class Burst : ValueType
{
    public object time;
    public object count;
    public object minCount;
    public object maxCount;
    public object cycleCount;
    public object repeatInterval;
    public object probability;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54D709D0 | overloaded x5
    public void get_time(){} // RVA: 0x7FFD4E364D20
    public void set_time(){} // RVA: 0x7FFD4FEBB910
    public void get_count(){} // RVA: 0x7FFD54D70A50
    public void set_count(){} // RVA: 0x7FFD54D70A70
    public void get_minCount(){} // RVA: 0x7FFD54D70AD0
    public void set_minCount(){} // RVA: 0x7FFD54D70AE0
    public void get_maxCount(){} // RVA: 0x7FFD54D70AF0
    public void set_maxCount(){} // RVA: 0x7FFD54D70B00
    public void get_cycleCount(){} // RVA: 0x7FFD54D70B10
    public void set_cycleCount(){} // RVA: 0x7FFD54D70B20
    public void get_repeatInterval(){} // RVA: 0x7FFD54D5FB10
    public void set_repeatInterval(){} // RVA: 0x7FFD54D70BD0
    public void get_probability(){} // RVA: 0x7FFD54D70C80
    public void set_probability(){} // RVA: 0x7FFD54D70C90
}

public class BurstCompilerHelper : Object
{
    // ── Methods ──
    public void IsBurstEnabled(){} // RVA: 0x7FFD54926440
    public void DiscardedMethod(){} // RVA: 0x7FFD4FDDD6A0
    public void IsCompiledByBurst(){} // RVA: 0x7FFD54926490
    public void .cctor(){} // RVA: 0x7FFD54926570
    public void IsBurstEnabled$BurstManaged(){} // RVA: 0x7FFD549267F0
}

public class Button : ValueType
{
}

public class ButtonClickedEvent : UnityEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC74470
}

public class ButtonState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F6F7180
}

public class bucket : ValueType
{
}
