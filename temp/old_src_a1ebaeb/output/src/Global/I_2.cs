// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 168

public class IJobSortable
{
    // ── Original Methods ──
    public void get_SortingBaseTransform(){} // RVA: 0x7ffaa86491d0
    public void get_MaximumExecutionGroups(){} // RVA: 0x7ffaa8649ca0
    public void get_ExecutionGroup(){} // RVA: 0x7ffaa8649ca0
    public void set_ExecutionGroup(){} // RVA: 0x7ffaa8661210
    // ── Binary Analysis Named ──
    public void GetKnownDependencies(){} // RVA: 0x7ffaa8660d80
}

public class IKBone : ValueType
{
    public object position; // 0x3510EB50
    public object localAxis; // 0x3510EB50
    public object Vh;
}

public class IListWrapper : ArrayList
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaadfbec90
    public void set_Capacity(){} // RVA: 0x7ffaadfbed10
    public void get_Count(){} // RVA: 0x7ffaadfbeda0
    public void get_IsReadOnly(){} // RVA: 0x7ffaadfbedf0
    public void get_IsFixedSize(){} // RVA: 0x7ffaadfbee40
    public void get_IsSynchronized(){} // RVA: 0x7ffaadfbee90
    public void get_Item(){} // RVA: 0x7ffaadfbeee0
    public void set_Item(){} // RVA: 0x7ffaadfbef40
    public void get_SyncRoot(){} // RVA: 0x7ffaadfbefc0
    public void Add(){} // RVA: 0x7ffaadfbf010
    public void AddRange(){} // RVA: 0x7ffaadfbf080
    public void Clear(){} // RVA: 0x7ffaadfbf0d0
    public void Clone(){} // RVA: 0x7ffaadfbf190
    public void Contains(){} // RVA: 0x7ffaadfbf1f0
    public void CopyTo(){} // RVA: 0x7ffaadfbf2c0
    public void CopyTo(){} // RVA: 0x7ffaadfbf2c0
    public void IndexOf(){} // RVA: 0x7ffaadfbf640
    public void Insert(){} // RVA: 0x7ffaadfbf6a0
    public void InsertRange(){} // RVA: 0x7ffaadfbf720
    public void Remove(){} // RVA: 0x7ffaadfbe460
    public void RemoveAt(){} // RVA: 0x7ffaadfbfaa0
    public void RemoveRange(){} // RVA: 0x7ffaadfbfb10
    public void Reverse(){} // RVA: 0x7ffaadfbfd10
    public void Sort(){} // RVA: 0x7ffaadfc00f0
    public void ToArray(){} // RVA: 0x7ffaadfc0470
    public void ToArray(){} // RVA: 0x7ffaadfc0470
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaadfbf5f0
}

public class Icons : ValueType
{
    public object gallery; // 0x349BA660
}

public class Icons : ValueType
{
}

public class Icons : ValueType
{
    public object gallery; // 0x349BAAE0
}

public class ImageInfo : ValueType
{
    public object format; // 0x345FE240
}

public class ImageLoadSettings : ValueType
{
    public object _resolutionLimit; // 0x345FE7F0
    public object _outputFormatOverride; // 0x345FE7F0
    public object q5;

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa2e9e80
    public void HasFlag(){} // RVA: 0x7ffaaa2ea460
    // ── Binary Analysis Named ──
    public void GetAllocationLimit(){} // RVA: 0x7ffab1a20800
    public void SetAllocationLimit(){} // RVA: 0x7ffab1a20860
    public void GetResolutionLimit(){} // RVA: 0x7ffab1a20900
    public void SetResolutionLimit(){} // RVA: 0x7ffab1a20960
    public void GetVerticalFlip(){} // RVA: 0x7ffaaa2ea2a0
    public void SetVerticalFlip(){} // RVA: 0x7ffaaa2ea470
    public void GetResizeResolution(){} // RVA: 0x7ffab1a20a00
    public void SetResizeResolution(){} // RVA: 0x7ffab1a20aa0
    public void SetFastResize(){} // RVA: 0x7ffaaa2e9d30
    public void GetFastResize(){} // RVA: 0x7ffaaa2ea4c0
    public void GetOutputFormatOverride(){} // RVA: 0x7ffab1a20b40
    public void SetOutputFormatOverride(){} // RVA: 0x7ffab1a20b90
    public void SetGenerateMipMaps(){} // RVA: 0x7ffaaa2ea250
    public void GetGenerateMipMaps(){} // RVA: 0x7ffaaa2ea350
}

public class ImageResult : ValueType
{
    public object error; // 0x345FE3C0
}

public class ImpulseEvent : Object
{
    public object m_SignalSource; // 0x34B54610
    public object m_DirectionMode; // 0x34B54610
    public object m_DissipationDistance; // 0x34B54610
    public object .ctor; // 0xB3F6FFF0

    // ── Original Methods ──
    public void get_Expired(){} // RVA: 0x7ffaaa261bf0
    public void Cancel(){} // RVA: 0x7ffaaa261ca0
    public void DistanceDecay(){} // RVA: 0x7ffaaa261ce0
    public void Clear(){} // RVA: 0x7ffaaa262610
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void GetDecayedSignal(){} // RVA: 0x7ffaaa261e50
}

public class ImpulseReaction : ValueType
{
    public object m_FrequencyGain; // 0x34B4FB40
    public object m_CurrentTime; // 0x34B4FB40
    public object m_NoiseOffsets; // 0x34B4FB40
    public object m_Gain; // 0x33311D40

    // ── Original Methods ──
    public void ReSeed(){} // RVA: 0x7ffaaa2606e0
    // ── Binary Analysis Named ──
    public void GetReaction(){} // RVA: 0x7ffaaa260810
}

public class InputActionReferenceState : ValueType
{
}

public class InstantiateMrcCameraDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaae2f4bf0
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
    public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaae2f4cd0
}

public class Instruction : ValueType
{
    public object m_Blend; // 0x34B05D80
}

public class Instruction : ValueType
{
    public object m_ActivateAfter; // 0x34B3CAB0
    public object 00; // 0x34B37EF8
}

public class Int128 : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa263cb0
    public void .ctor(){} // RVA: 0x7ffaaa263cb0
    public void .ctor(){} // RVA: 0x7ffaaa263cb0
    public void IsNegative(){} // RVA: 0x7ffaaa264440
    public void op_Equality(){} // RVA: 0x7ffaaa264450
    public void op_Inequality(){} // RVA: 0x7ffaaa264510
    public void Equals(){} // RVA: 0x7ffaaa2645d0
    public void op_GreaterThan(){} // RVA: 0x7ffaaa264680
    public void op_LessThan(){} // RVA: 0x7ffaaa2646a0
    public void op_Addition(){} // RVA: 0x7ffaaa2646c0
    public void op_Subtraction(){} // RVA: 0x7ffaaa2646f0
    public void op_UnaryNegation(){} // RVA: 0x7ffaaa264760
    public void op_Explicit(){} // RVA: 0x7ffaaa2647a0
    public void Int128Mul(){} // RVA: 0x7ffaaa264860
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaaa264660
}

public class IntChildrenSection : ChildrenSection`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab12fec10
}

public class IntPoint : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa263cb0
    public void .ctor(){} // RVA: 0x7ffaaa263cb0
    public void .ctor(){} // RVA: 0x7ffaaa263cb0
    public void op_Equality(){} // RVA: 0x7ffaaa264940
    public void op_Inequality(){} // RVA: 0x7ffaaa264960
    public void Equals(){} // RVA: 0x7ffaaa264980
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaaa264a10
}

public class IntRect : ValueType
{
    public object right; // 0x34B551C0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa264a90
    public void .ctor(){} // RVA: 0x7ffaaa264a90
}

public class InternalEnumerator`1 : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab8f6670
    public void Dispose(){} // RVA: 0x7ffaa8932310
    public void MoveNext(){} // RVA: 0x7ffaab8f66e0
    public void get_Current(){} // RVA: 0x7ffaab8f6960
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaab8f68d0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaab924ca0
}

public class InternalEnumerator`1 : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab8f6670
    public void Dispose(){} // RVA: 0x7ffaa8932310
    public void MoveNext(){} // RVA: 0x7ffaab8f66e0
    public void get_Current(){} // RVA: 0x7ffaab8f6960
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaab8f68d0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaab924ca0
}

public class InternalEnumerator`1 : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab8f6670
    public void Dispose(){} // RVA: 0x7ffaa8932310
    public void MoveNext(){} // RVA: 0x7ffaab8f66e0
    public void get_Current(){} // RVA: 0x7ffaab8f6960
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaab8f68d0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaab924ca0
}

public class InternalEnumerator`1 : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab8f6670
    public void Dispose(){} // RVA: 0x7ffaa8932310
    public void MoveNext(){} // RVA: 0x7ffaab8f66e0
    public void get_Current(){} // RVA: 0x7ffaab8f6960
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaab8f68d0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaab924ca0
}

public class Interop : Object
{
    // ── Original Methods ──
    public void MemAlloc(){} // RVA: 0x7ffaadda8850
    // ── Binary Analysis Named ──
    public void GetRandomBytes(){} // RVA: 0x7ffaadda8740
}

public class IntersectNode : Object
{
    public object Pt; // 0x34B56790
    public object System.Collections.Generic; // 0xB40EC9C0

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class IsBurstEnabledDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab6b2d70
    public void Invoke(){} // RVA: 0x7ffaa8990a50
}

public class IsBurstEnabled_00000145$BurstDirectCall : Object
{
    // ── Original Methods ──
    public void Constructor(){} // RVA: 0x7ffaaef28ac0
    public void Initialize(){} // RVA: 0x7ffaa8932310
    public void .cctor(){} // RVA: 0x7ffaaef28ac0
    public void Invoke(){} // RVA: 0x7ffaaef28b80
    // ── Binary Analysis Named ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7ffaaef28810
    public void GetFunctionPointer(){} // RVA: 0x7ffaaef28950
}

public class IsBurstEnabled_00000145$PostfixBurstDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab6b2d70
    public void Invoke(){} // RVA: 0x7ffaa8990a50
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsCanceledSource : Object
{
}

public class IsRegistered`1 : Object
{
}

public class Item : ValueType
{
    // ── Original Methods ──
    public void Lerp(){} // RVA: 0x7ffaaa258890
    public void get_Empty(){} // RVA: 0x7ffaaa2589f0
}

public class Item : ValueType
{
    public object time; // 0x34B5CCD0
}

public class Iterator`1 : Object
{
    public object current; // 0x351F69E8

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab94ab90
    public void get_Current(){} // RVA: 0x7ffaa8b06f30
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void Dispose(){} // RVA: 0x7ffaab94b130
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaab94b150
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaab94ad40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaab68dbd0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaab94ac30
}

public class Iterator`1 : Object
{
    public object current; // 0x35881CC8

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab94ab90
    public void get_Current(){} // RVA: 0x7ffaa89357c0
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void Dispose(){} // RVA: 0x7ffaab94af50
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaa89357c0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaab94ad40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaab68dbd0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaab94ac30
}

public class Iterator`1 : Object
{
    public object current; // 0x3591D090

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab94ab90
    public void get_Current(){} // RVA: 0x7ffaa8b945a0
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void Dispose(){} // RVA: 0x7ffaab94b0f0
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaab94b100
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaab94ad40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaab68dbd0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaab94ac30
}

public class Iterator`1 : Object
{
    public object current; // 0x3591D630
    public object source; // 0x3591D3E8

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaab94ab90
    public void get_Current(){} // RVA: 0x7ffaaa470130
    public void Clone(){} // RVA: 0x7ffaa86491d0
    public void Dispose(){} // RVA: 0x7ffaab94ac10
    public void MoveNext(){} // RVA: 0x7ffaa864a040
    public void Select(){} // RVA: 0x7ffaa8649280
    public void Where(){} // RVA: 0x7ffaa8649280
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7ffaab94ad00
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaab94ad40
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7ffaab68dbd0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaab94ac30
}
