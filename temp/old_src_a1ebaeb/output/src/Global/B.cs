// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 44
// Methods: 215

public class BakeTextureOutput : ValueType
{
}

public class BakedSolution : Object
{
    public object m_HasBones; // 0x34B4C760
    public object m_Solution; // 0x34B4C760
    public object m_InverseAspect; // 0x34B4C8E0
    public object 00; // 0x34B68610

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa2531b0
    public void IsValid(){} // RVA: 0x7ffaaa2532e0
    public void ConfinePoint(){} // RVA: 0x7ffaaa2532f0
    public void FindIntersection(){} // RVA: 0x7ffaaa253960
    public void <ConfinePoint>g__IntPointLerp|9_0(){} // RVA: 0x7ffaaa253b80
    public void <ConfinePoint>g__IsInsideOriginal|9_1(){} // RVA: 0x7ffaaa253c20
    public void <ConfinePoint>g__ClosestPointOnSegment|9_2(){} // RVA: 0x7ffaaa253d00
    public void <ConfinePoint>g__DoesIntersectOriginal|9_3(){} // RVA: 0x7ffaaa253d90
    public void <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(){} // RVA: 0x7ffaaa254000
}

public class BakingStateCache : ValueType
{
    public object rightCandidate; // 0x34B4CE90
    public object stepSize; // 0x34B4CE90
    public object theoriticalMaxFrustumHeight; // 0x34B4CE90
    public object 00; // 0x34B68ED0
}

public class BaseVisualElementScheduledItem : ScheduledItem
{
    public object m_Activator; // 0x314CA430
    public object element; // 0x170004B1

    // ── Original Methods ──
    public void get_element(){} // RVA: 0x7ffaa8bf45b0
    public void set_element(){} // RVA: 0x7ffaa8bf45c0
    public void .ctor(){} // RVA: 0x7ffaaf615d20
    public void StartingIn(){} // RVA: 0x7ffaaf615f40
    public void Every(){} // RVA: 0x7ffaaf615f50
    public void OnItemUnscheduled(){} // RVA: 0x7ffaaf616060
    public void Resume(){} // RVA: 0x7ffaaf6160a0
    public void Pause(){} // RVA: 0x7ffaaf6160d0
    public void ExecuteLater(){} // RVA: 0x7ffaaf616100
    public void OnPanelActivate(){} // RVA: 0x7ffaaf616180
    public void OnPanelDeactivate(){} // RVA: 0x7ffaaf616250
    public void CanBeActivated(){} // RVA: 0x7ffaaf6162d0
}

public class BatchModeUpdate : ValueType
{
}

public class BinderState : Object
{
    public object m_isParamArray; // 0x34E51F00

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae096780
}

public class BindingSyntax : ValueType
{
    public object m_BindingIndexInMap; // 0x31A641C0
    public object valid; // 0x170000D7

    // ── Original Methods ──
    public void get_valid(){} // RVA: 0x7ffaaef61300
    public void get_bindingIndex(){} // RVA: 0x7ffaaef61370
    public void get_binding(){} // RVA: 0x7ffaaef613f0
    public void .ctor(){} // RVA: 0x7ffaaef614f0
    public void WithName(){} // RVA: 0x7ffaaef615b0
    public void WithPath(){} // RVA: 0x7ffaaef61710
    public void WithGroup(){} // RVA: 0x7ffaaef61880
    public void WithGroups(){} // RVA: 0x7ffaaef61a90
    public void WithInteraction(){} // RVA: 0x7ffaa887e5c0
    public void WithInteractions(){} // RVA: 0x7ffaaef61f30
    public void WithInteraction(){} // RVA: 0x7ffaa887e5c0
    public void WithProcessor(){} // RVA: 0x7ffaa887e5c0
    public void WithProcessors(){} // RVA: 0x7ffaaef623d0
    public void WithProcessor(){} // RVA: 0x7ffaa887e5c0
    public void Triggering(){} // RVA: 0x7ffaaef62660
    public void To(){} // RVA: 0x7ffaaef62870
    public void NextBinding(){} // RVA: 0x7ffaaef62a10
    public void PreviousBinding(){} // RVA: 0x7ffaaef62a50
    public void NextPartBinding(){} // RVA: 0x7ffaaef62a90
    public void PreviousPartBinding(){} // RVA: 0x7ffaaef62b20
    public void NextCompositeBinding(){} // RVA: 0x7ffaaef62bb0
    public void PreviousCompositeBinding(){} // RVA: 0x7ffaaef62bf0
    public void Iterate(){} // RVA: 0x7ffaaef62c30
    public void IterateCompositeBinding(){} // RVA: 0x7ffaaef62d30
    public void IteratePartBinding(){} // RVA: 0x7ffaaef63050
    public void Erase(){} // RVA: 0x7ffaaef632b0
    public void InsertPartBinding(){} // RVA: 0x7ffaaef636f0
}

public class BitRegion : ValueType
{
    // ── Original Methods ──
    public void get_isEmpty(){} // RVA: 0x7ffaaef8c450
    public void .ctor(){} // RVA: 0x7ffaaef8c460
    public void .ctor(){} // RVA: 0x7ffaaef8c460
    public void Overlap(){} // RVA: 0x7ffaaef8c470
}

public class BlendshapesConfig : Object
{
    public object blendshapeNames; // 0x33F9DBE0

    // ── Original Methods ──
    public void Computetransform(){} // RVA: 0x7ffaa9f29a60
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Initialize(){} // RVA: 0x7ffaa9f29e70
    public void get_name(){} // RVA: 0x7ffaa9f2a880
    public void set_name(){} // RVA: 0x7ffaa9f2ac80
    public void Instantiate(){} // RVA: 0x7ffaa9f2ae80
    public void Equals(){} // RVA: 0x7ffaa9f2b090
    // ── Binary Analysis Named ──
    public void DoGetKeyDownInt_7D6(){} // RVA: 0x7ffaa9f29850
    public void DoFindRelativeTran(){} // RVA: 0x7ffaa9f29c60
    public void DoGetMouseButtonUp_E21(){} // RVA: 0x7ffaa9f2a070
    public void DoFindRelativeTransformWithPath(){} // RVA: 0x7ffaa9f2a470
}

public class BlendshapesConfigForExport : Object
{
    public object blendshapeNames; // 0x33F9DA60

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class Block : ValueType
{
    public object AllocatedItems; // 0x31669DA0
    public object Padding1; // 0x31669DA0
    public object Items; // 0x34E6BAB0

    // ── Original Methods ──
    public void get_Bytes(){} // RVA: 0x7ffaaef313b0
    public void get_AllocatedBytes(){} // RVA: 0x7ffaaef313c0
    public void get_Alignment(){} // RVA: 0x7ffaaef313d0
    public void set_Alignment(){} // RVA: 0x7ffaaef313e0
    public void Dispose(){} // RVA: 0x7ffaaef31430
    public void TryFree(){} // RVA: 0x7ffaaef31430
}

public class Bone : ValueType
{
    public object isEndBone; // 0x3510FC10
    public object localPoseRotation; // 0x3510FC10
    public object originalLocalPosition; // 0x3510FC10
    public object originalLocalBoneLength; // 0x3510FC10
    public object originalLocalGravityNormal; // 0x3510FC10
    public object prevVelocity; // 0x3510FC10
    public object prevVector; // 0x3510FC10
    public object totalLength; // 0x3510FC10
    public object grabStatus; // 0x3510FC10
    public object stiffness; // 0x3510FC10
    public object immobile; // 0x3510FC10
    public object globalRadiusBegin; // 0x3510FC10
    public object limitAxisX; // 0x3510FC10
    public object stretchMotion; // 0x3510FC10
    public object x; // 0x31A7EF90
    public object Xũf; // 0xAAD11B50
    public object Xũf; // 0x1D0000

    // ── Original Methods ──
    public void get_isSimulated(){} // RVA: 0x7ffaaf8654e0
}

public class BoolChildrenSection : ChildrenSection`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab12ffcf0
}

public class BoolDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9511710
    public void Invoke(){} // RVA: 0x7ffaa898dc60
    public void EndInvoke(){} // RVA: 0x7ffaa9511890
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa898dc70
}

public class BoolEvent : UnityEvent`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab118de40
}

public class BoundedChannelReader : ChannelReader`1
{
    public object _waiterSingleton; // 0x30DE4030

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void TryRead(){} // RVA: 0x7ffaa864a2a0
    public void WaitToReadAsync(){}
    public void DequeueItemAndPostProcess(){} // RVA: 0x7ffaa887e5c0
}

public class BoundedChannelWriter : ChannelWriter`1
{
    public object _waiterSingleton; // 0x30DE47F0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void TryComplete(){} // RVA: 0x7ffaa864a2a0
    public void TryWrite(){} // RVA: 0x7ffaa887e5c0
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7ffaa887e5c0
}

public class BoxAvoidance : Object
{
    // ── Original Methods ──
    public void ToInt(){} // RVA: 0x7ffaa887e5c0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
}

public class BrainEvent : UnityEvent`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa1ff390
}

public class BrainFrame : Object
{
    public object workingBlend; // 0x34B067E0
    public object blendStartPosition; // 0x34B067E0
    public object Active; // 0x17000013

    // ── Original Methods ──
    public void get_Active(){} // RVA: 0x7ffaaa1ff4b0
    public void .ctor(){} // RVA: 0x7ffaaa1ff4d0
}

public class Bucket : Object
{
    public object _poolId; // 0x30DE5100

    // ── Original Methods ──
    public void .ctor(){}
    public void get_Id(){} // RVA: 0x7ffaa8649ca0
    public void Rent(){} // RVA: 0x7ffaa86491d0
    public void Return(){} // RVA: 0x7ffaa8660d80
}

public class Bucket : Object
{
    public object _poolId; // 0x30DE5420

    // ── Original Methods ──
    public void .ctor(){}
    public void get_Id(){} // RVA: 0x7ffaa8649ca0
    public void Rent(){} // RVA: 0x7ffaa86491d0
    public void Return(){} // RVA: 0x7ffaa8660d80
}

public class BufferedAsyncEnumerable : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    // ── Binary Analysis Named ──
    public void GetAsyncEnumerator(){}
}

public class BufferedAsyncEnumerable : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    // ── Binary Analysis Named ──
    public void GetAsyncEnumerator(){}
}

public class BufferedAudioStream : Object
{
    public object audioBuffer; // 0x33CC65A0
    public object sampleRate; // 0x33CC65A0
    public object playbackDelayRemaining; // 0x33CC65A0
    public object 00; // 0x400000C
    public object `Ǐf; // 0x672CE639
    public object 00; // 0x400000F

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae239700
    public void Update(){} // RVA: 0x7ffaae2398f0
    public void Stop(){} // RVA: 0x7ffaae239ae0
    public void AddData(){} // RVA: 0x7ffaae239bb0
}

public class Builder : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8661210
    public void get_Capacity(){} // RVA: 0x7ffaa8649ca0
    public void get_Count(){} // RVA: 0x7ffaa8649ca0
    public void set_Count(){} // RVA: 0x7ffaa8661210
    public void ThrowIndexOutOfRangeException(){} // RVA: 0x7ffaa8660cf0
    public void get_Item(){} // RVA: 0x7ffaa887e5c0
    public void set_Item(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa864a040
    public void MoveToImmutable(){} // RVA: 0x7ffaa887e5c0
    public void Clear(){} // RVA: 0x7ffaa8660cc0
    public void Insert(){} // RVA: 0x7ffaa887e5c0
    public void Add(){} // RVA: 0x7ffaa887e5c0
    public void Remove(){} // RVA: 0x7ffaa887e5c0
    public void RemoveAt(){} // RVA: 0x7ffaa8661210
    public void Contains(){} // RVA: 0x7ffaa887e5c0
    public void CopyTo(){} // RVA: 0x7ffaa8667cb0
    public void EnsureCapacity(){} // RVA: 0x7ffaa8661210
    public void IndexOf(){} // RVA: 0x7ffaa887e5c0
    public void IndexOf(){} // RVA: 0x7ffaa887e5c0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
}

public class Builder : Object
{
    // ── Original Methods ──
    public void get_Version(){} // RVA: 0x7ffaa8649ca0
}

public class Builder : Object
{
    // ── Original Methods ──
    public void get_Version(){} // RVA: 0x7ffaa8649ca0
}

public class Builder : Object
{
    // ── Original Methods ──
    public void get_Version(){} // RVA: 0x7ffaa8649ca0
}

public class Builder : Object
{
    // ── Original Methods ──
    public void get_Version(){} // RVA: 0x7ffaa8649ca0
}

public class Builder : Object
{
    public object _count; // 0x30DE6AB0

    // ── Original Methods ──
    public void get_Version(){} // RVA: 0x7ffaa8649ca0
    public void ToImmutable(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
}

public class Builder : Object
{
    public object _valueComparer; // 0x30DE6E20
    public object _version; // 0x30DE6E20
    public object Version; // 0x17000079
    public object Root; // 0x1700007A

    // ── Original Methods ──
    public void get_Version(){} // RVA: 0x7ffaa8649ca0
    public void get_Root(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    public void ToImmutable(){} // RVA: 0x7ffaa86491d0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
}

public class Builder : Object
{
    // ── Original Methods ──
    public void get_Version(){} // RVA: 0x7ffaa8649ca0
}

public class Builder : Object
{
    public object _type; // 0x31A64AF0, was: <type>k__BackingField
    public object m_ExtendsLayout; // 0x31A64AF0
    public object m_Controls; // 0x31A64AF0
    public object name; // 0x17000583
    public object displayName; // 0x17000584
    public object type; // 0x17000585

    // ── Original Methods ──
    public void get_name(){} // RVA: 0x7ffaa894d380
    public void set_name(){} // RVA: 0x7ffaa8933e30
    public void get_displayName(){} // RVA: 0x7ffaa89357c0
    public void set_displayName(){} // RVA: 0x7ffaa8998e80
    public void get_type(){} // RVA: 0x7ffaa89600c0
    public void set_type(){} // RVA: 0x7ffaa89600d0
    public void get_stateFormat(){} // RVA: 0x7ffaa8d14570
    public void set_stateFormat(){} // RVA: 0x7ffaa90c0cd0
    public void get_stateSizeInBytes(){} // RVA: 0x7ffaa96cc980
    public void set_stateSizeInBytes(){} // RVA: 0x7ffaa9fdb500
    public void get_extendsLayout(){} // RVA: 0x7ffaa8bfcc80
    public void set_extendsLayout(){} // RVA: 0x7ffaaf0b1d40
    public void get_updateBeforeRender(){} // RVA: 0x7ffaac78b560
    public void set_updateBeforeRender(){} // RVA: 0x7ffaae5915e0
    public void get_controls(){} // RVA: 0x7ffaaf0b1e10
    public void AddControl(){} // RVA: 0x7ffaaf0b1ec0
    public void WithName(){} // RVA: 0x7ffaaa3a2600
    public void WithDisplayName(){} // RVA: 0x7ffaaa0f83e0
    public void WithType(){} // RVA: 0x7ffaa86491d0
    public void WithFormat(){} // RVA: 0x7ffaaf0b2350
    public void WithFormat(){} // RVA: 0x7ffaaf0b2350
    public void WithSizeInBytes(){} // RVA: 0x7ffaaf0b2380
    public void Extend(){} // RVA: 0x7ffaaf0b2390
    public void Build(){} // RVA: 0x7ffaaf0b23b0
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class Builder : Object
{
}

public class Builder : Object
{
}

public class Burst : ValueType
{
    public object m_RepeatCount; // 0x32D12860
    public object m_Mode; // 0x32D129E0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf372930
    public void .ctor(){} // RVA: 0x7ffaaf372930
    public void .ctor(){} // RVA: 0x7ffaaf372930
    public void .ctor(){} // RVA: 0x7ffaaf372930
    public void .ctor(){} // RVA: 0x7ffaaf372930
    public void get_time(){} // RVA: 0x7ffaa8955d20
    public void set_time(){} // RVA: 0x7ffaaa49daf0
    public void get_count(){} // RVA: 0x7ffaaf3729b0
    public void set_count(){} // RVA: 0x7ffaaf3729d0
    public void get_minCount(){} // RVA: 0x7ffaaf372a30
    public void set_minCount(){} // RVA: 0x7ffaaf372a40
    public void get_maxCount(){} // RVA: 0x7ffaaf372a50
    public void set_maxCount(){} // RVA: 0x7ffaaf372a60
    public void get_cycleCount(){} // RVA: 0x7ffaaf372a70
    public void set_cycleCount(){} // RVA: 0x7ffaaf372a80
    public void get_repeatInterval(){} // RVA: 0x7ffaaf361a70
    public void set_repeatInterval(){} // RVA: 0x7ffaaf372b30
    public void get_probability(){} // RVA: 0x7ffaaf372be0
    public void set_probability(){} // RVA: 0x7ffaaf372bf0
}

public class BurstCompilerHelper : Object
{
    // ── Original Methods ──
    public void IsBurstEnabled(){} // RVA: 0x7ffaaef28410
    public void DiscardedMethod(){} // RVA: 0x7ffaaa3c5120
    public void IsCompiledByBurst(){} // RVA: 0x7ffaaef28460
    public void .cctor(){} // RVA: 0x7ffaaef28540
    public void IsBurstEnabled$BurstManaged(){} // RVA: 0x7ffaaef287c0
}

public class Button : ValueType
{
    public object previousText; // 0x33F57E40
}

public class ButtonClickedEvent : UnityEvent
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa25c380
}

public class ButtonState : Object
{
    public object offset; // 0x33F46F20
    public object overshoot; // 0x33F46F20

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9cfe920
}

public class ButtonState : ValueType
{
    public object m_PressTime; // 0x34427E40
    public object m_RawPressObject; // 0x34427E40
    public object m_PressPosition; // 0x34427E40
    public object m_Dragging; // 0x34427E40
    public object m_GameObject; // 0x335E1320
    public object index; // 0x335E1320
    public object sortingGroupOrder; // 0x335E1320

    // ── Original Methods ──
    public void get_isPressed(){} // RVA: 0x7ffaaa365870
    public void set_isPressed(){} // RVA: 0x7ffaaf0741c0
    public void get_ignoreNextClick(){} // RVA: 0x7ffaa9969490
    public void set_ignoreNextClick(){} // RVA: 0x7ffaaa26a0c0
    public void get_pressTime(){} // RVA: 0x7ffaaa49dab0
    public void set_pressTime(){} // RVA: 0x7ffaaa49dae0
    public void get_clickedOnSameGameObject(){} // RVA: 0x7ffaaa26a0a0
    public void set_clickedOnSameGameObject(){} // RVA: 0x7ffaaa26a0b0
    public void get_wasPressedThisFrame(){} // RVA: 0x7ffaaf074210
    public void get_wasReleasedThisFrame(){} // RVA: 0x7ffaaf074230
    public void CopyPressStateTo(){} // RVA: 0x7ffaaf074250
    public void CopyPressStateFrom(){} // RVA: 0x7ffaaf074430
    public void OnEndFrame(){} // RVA: 0x7ffaaf074670
}

public class ButtonState : Object
{
    // ── Original Methods ──
    public void get_eventData(){} // RVA: 0x7ffaa89357c0
    public void set_eventData(){} // RVA: 0x7ffaa8998e80
    public void get_button(){} // RVA: 0x7ffaa897f5c0
    public void set_button(){} // RVA: 0x7ffaa89350c0
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class bucket : ValueType
{
    public object hash_coll; // 0x34CA62C0
}
