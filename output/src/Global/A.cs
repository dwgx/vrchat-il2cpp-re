// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 611

public class Action`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
    public void BeginInvoke(){} // RVA: 0xA94080
    public void EndInvoke(){} // RVA: 0x894320
}

public class AlphaButtonClickMask : MonoBehaviour
{
    public object _image;

    // ── Methods ──
    public void Start(){} // RVA: 0xB43330
    public void IsRaycastLocationValid(){} // RVA: 0xB43720
    public void .ctor(){} // RVA: 0xB43D60
}

public class AnimatedButton : Object
{
    public object Button;
    public object InAnimationDuration;
    public object OutAnimationDuration;
    public object ScaleAnimationDuration;
    public object OutPosition;
    public object InPosition;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ApplyToFarPlane_CameraApplier : MonoBehaviour
{
    public object _material;

    // ── Methods ──
    public void get_Material(){} // RVA: 0xB700F0
    public void set_Material(){} // RVA: 0xB70100
    public void OnWillRenderObject(){} // RVA: 0x25357D0
    public void .ctor(){} // RVA: 0xB43D60
}

public class AssetBundleRequestAwaiter : ValueType
{
    public object asyncOperation;
    public object continuationAction;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x54A90
    public void get_IsCompleted(){} // RVA: 0x9232C0
    public void GetResult(){} // RVA: 0x9232D0
    public void OnCompleted(){} // RVA: 0x9233C0
    public void UnsafeOnCompleted(){} // RVA: 0x9233D0
}

public class AssetPreloader : Object
{
    public object _kInstanceID_None;
    public object _m_CachedPtr;
    public object _offsetOfInstanceIDInCPlusPlusObject;
    public object _objectIsNullMessage;
    public object _cloneDestroyedMessage;

    // ── Methods ──
    public void Dispose(){} // RVA: 0x1A50A20
    public void Cleanup(){} // RVA: 0x1A50AF0
    public void Equals(){} // RVA: 0x1A50CB0
    public void op_Implicit(){} // RVA: 0x1A51190
    public void CompareBaseObjects(){} // RVA: 0x1A512C0
    public void IsNativeObjectAlive(){} // RVA: 0x1A51460
    public void GetCachedPtr(){} // RVA: 0x1A51650
    public void Finalize(){} // RVA: 0x1A51840
    public void set_name(){} // RVA: 0x1A51A60
    public void Initialize(){} // RVA: 0x1A51BF0
    public void Destroy(){} // RVA: 0x1A51D00
    public void DestroyImmediate(){} // RVA: 0x1A52250
    public void FindObjectsOfType(){} // RVA: 0x1A523E0
    public void FindObjectsByType(){} // RVA: 0x1A525D0
    public void DontDestroyOnLoad(){} // RVA: 0x1A526A0
    public void get_hideFlags(){} // RVA: 0x1A52B10
    public void set_hideFlags(){} // RVA: 0x1A52CD0
    public void FindObjectOfType(){} // RVA: 0x1A52E90
    public void FindFirstObjectByType(){} // RVA: 0x1A53010
    public void .ctor(){} // RVA: 0x1A531E0
    public void GetHashCode(){} // RVA: 0x1A536B0
    public void op_Equality(){} // RVA: 0x1A538B0
    public void op_Inequality(){} // RVA: 0x1A53D90
    public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x1A53F80
    public void Internal_CloneSingle(){} // RVA: 0xB465B0
    public void Internal_CloneSingleWithParent(){} // RVA: 0x1A541C0
    public void Internal_InstantiateSingle(){} // RVA: 0x1A543B0
}

public class AutoScope : ValueType
{
    public object m_Ptr;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x95ED20
    public void Dispose(){} // RVA: 0x95ED80
}

public class AvatarCullingMonitor : Object
{
    public object _avatarScreenSizeThresholdLower;
    public object _avatarScreenSizeThresholdUpper;
    public object _validAvatarKinds;
    public object _owningPlayer;
    public object _hasOwningPlayer;
    public object _isBoundToAvatarKind;
    public object _hasValidAvatarKind;
    public object _isBoundToAvatarScreenSize;
    public object _aboveTriggerThreshold;
    public object _cullingChangedCallback;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x19A0F90
    public void .ctor(){} // RVA: 0x19A1090
    public void Initialize(){} // RVA: 0x19A10A0
    public void get_AvatarScreenSizeAboveTriggerThreshold(){} // RVA: 0x19A11A0
    public void set_AvatarScreenSizeAboveTriggerThreshold(){} // RVA: 0x19A11B0
    public void set_AvatarKindValidForExecution(){} // RVA: 0x19A12B0
    public void get_AvatarKindValidForExecution(){} // RVA: 0x19A1390
    public void set_AvatarCullableShouldRun(){} // RVA: 0x19A1400
    public void get_AvatarCullableShouldRun(){} // RVA: 0x19A1460
    public void CompareBaseObjects(){} // RVA: 0x19A14D0
    public void Destroy(){} // RVA: 0x19A1640
    public void DestroyImmediate(){} // RVA: 0x19A17D0
    public void FindObjectsOfType(){} // RVA: 0x19A1B80
    public void FindObjectsByType(){} // RVA: 0x19A1C00
    public void Dispose(){} // RVA: 0x19A1C30
    public void Cleanup(){} // RVA: 0x19A1CB0
}

public class AvatarOscConfig : Object
{
    public object id;
    public object name;
    public object hash;
    public object parameters;
    public object _supportedTypes;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x19EAF10
    public void GetByName(){} // RVA: 0x19EADF0
}

public class AwaitableAndFrameIndex : ValueType
{
    public object _awaitable;
    public object _frameIndex;

    // ── Methods ──
    public void get_Awaitable(){} // RVA: 0x77900
    public void get_FrameIndex(){} // RVA: 0x14790
    public void .ctor(){} // RVA: 0x28E70
}

public class AwaitableAndFrameIndex[] : Array
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

public class AwaitableHandle : ValueType
{
    public object _handle;
    public object ManagedHandle;
    public object NullHandle;

    // ── Methods ──
    public void get_IsNull(){} // RVA: 0x88E70
    public void get_IsManaged(){} // RVA: 0x965D50
    public void .ctor(){} // RVA: 0x93050
    public void op_Implicit(){} // RVA: 0x2303260
    public void .cctor(){} // RVA: 0x7BF8E30
}

public class Awaiter : ValueType
{
    public object playerLoopTiming;
    public object cancellationToken;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3616C0
    public void get_IsCompleted(){} // RVA: 0x9206D0
    public void GetResult(){} // RVA: 0x9206E0
    public void OnCompleted(){} // RVA: 0x9206F0
    public void UnsafeOnCompleted(){} // RVA: 0x920750
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_IsCompleted(){} // RVA: 0x87D280
    public void GetResult(){} // RVA: 0xA94080
    public void OnCompleted(){} // RVA: 0x894320
    public void UnsafeOnCompleted(){} // RVA: 0x894320
    public void SourceOnCompleted(){} // RVA: 0x8943B0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x768C50
    public void GetResult(){} // RVA: 0x76FC40
    public void OnCompleted(){} // RVA: 0x76FC50
    public void UnsafeOnCompleted(){} // RVA: 0x76FD50
    public void SourceOnCompleted(){} // RVA: 0x7690E0
}

public class Awaiter : ValueType
{
    public object switchToCallback;

    // ── Methods ──
    public void get_IsCompleted(){} // RVA: 0x20C460
    public void GetResult(){} // RVA: 0x3FC0
    public void OnCompleted(){} // RVA: 0x920970
    public void UnsafeOnCompleted(){} // RVA: 0x9209D0
    public void Callback(){} // RVA: 0x775C890
    public void .cctor(){} // RVA: 0x775C900
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x920160
    public void GetResult(){} // RVA: 0x920170
    public void OnCompleted(){} // RVA: 0x9201D0
    public void UnsafeOnCompleted(){} // RVA: 0x9202B0
    public void SourceOnCompleted(){} // RVA: 0x9202C0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x747D90
    public void GetResult(){} // RVA: 0x771160
    public void OnCompleted(){} // RVA: 0x771190
    public void UnsafeOnCompleted(){} // RVA: 0x771290
    public void SourceOnCompleted(){} // RVA: 0x748070
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76DDB0
    public void UnsafeOnCompleted(){} // RVA: 0x76DEB0
    public void SourceOnCompleted(){} // RVA: 0x746690
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object timing;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x29580
    public void get_IsCompleted(){} // RVA: 0x20C460
    public void GetResult(){} // RVA: 0x3FC0
    public void OnCompleted(){} // RVA: 0x920460
    public void UnsafeOnCompleted(){} // RVA: 0x9204C0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x769C70
    public void UnsafeOnCompleted(){} // RVA: 0x769D70
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7467B0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x76D880
    public void UnsafeOnCompleted(){} // RVA: 0x76D980
    public void SourceOnCompleted(){} // RVA: 0x746A00
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x75B010
    public void GetResult(){} // RVA: 0x7702A0
    public void OnCompleted(){} // RVA: 0x7702B0
    public void UnsafeOnCompleted(){} // RVA: 0x7703B0
    public void SourceOnCompleted(){} // RVA: 0x75B2C0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x769C70
    public void UnsafeOnCompleted(){} // RVA: 0x769D70
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7467B0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x746AD0
    public void UnsafeOnCompleted(){} // RVA: 0x746BD0
    public void SourceOnCompleted(){} // RVA: 0x746A00
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
    public void get_IsCompleted(){} // RVA: 0x746020
    public void GetResult(){} // RVA: 0x746060
    public void OnCompleted(){} // RVA: 0x7715D0
    public void UnsafeOnCompleted(){} // RVA: 0x7716D0
    public void SourceOnCompleted(){} // RVA: 0x746290
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7473D0
    public void get_IsCompleted(){} // RVA: 0x747440
    public void GetResult(){} // RVA: 0x76B7B0
    public void OnCompleted(){} // RVA: 0x7714C0
    public void UnsafeOnCompleted(){} // RVA: 0x7715C0
    public void SourceOnCompleted(){} // RVA: 0x7475D0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x769C70
    public void UnsafeOnCompleted(){} // RVA: 0x769D70
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7467B0
    public void GetResult(){} // RVA: 0x7467F0
    public void OnCompleted(){} // RVA: 0x7694F0
    public void UnsafeOnCompleted(){} // RVA: 0x7695F0
    public void SourceOnCompleted(){} // RVA: 0x746A00
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x75B010
    public void GetResult(){} // RVA: 0x770170
    public void OnCompleted(){} // RVA: 0x770180
    public void UnsafeOnCompleted(){} // RVA: 0x770280
    public void SourceOnCompleted(){} // RVA: 0x770290
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x772450
    public void UnsafeOnCompleted(){} // RVA: 0x772550
    public void SourceOnCompleted(){} // RVA: 0x746690
}

public class Awaiter : ValueType
{
    public object _awaited;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void OnCompleted(){} // RVA: 0x965CF0
    public void get_IsCompleted(){} // RVA: 0x965D10
    public void GetResult(){} // RVA: 0x965D30
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
    public void get_IsCompleted(){} // RVA: 0x746020
    public void GetResult(){} // RVA: 0x747280
    public void OnCompleted(){} // RVA: 0x76F7B0
    public void UnsafeOnCompleted(){} // RVA: 0x76F8B0
    public void SourceOnCompleted(){} // RVA: 0x746290
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76D660
    public void UnsafeOnCompleted(){} // RVA: 0x76D760
    public void SourceOnCompleted(){} // RVA: 0x746690
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x748B30
    public void get_IsCompleted(){} // RVA: 0x748B40
    public void GetResult(){} // RVA: 0x764CA0
    public void OnCompleted(){} // RVA: 0x764CE0
    public void UnsafeOnCompleted(){} // RVA: 0x764DE0
    public void SourceOnCompleted(){} // RVA: 0x748E30
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x748B30
    public void get_IsCompleted(){} // RVA: 0x748B40
    public void GetResult(){} // RVA: 0x764CA0
    public void OnCompleted(){} // RVA: 0x771F40
    public void UnsafeOnCompleted(){} // RVA: 0x772040
    public void SourceOnCompleted(){} // RVA: 0x748E30
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7473D0
    public void get_IsCompleted(){} // RVA: 0x747440
    public void GetResult(){} // RVA: 0x76B7B0
    public void OnCompleted(){} // RVA: 0x76B7E0
    public void UnsafeOnCompleted(){} // RVA: 0x76B8E0
    public void SourceOnCompleted(){} // RVA: 0x76B8F0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
    public void get_IsCompleted(){} // RVA: 0x746020
    public void GetResult(){} // RVA: 0x747280
    public void OnCompleted(){} // RVA: 0x76F7B0
    public void UnsafeOnCompleted(){} // RVA: 0x76F8B0
    public void SourceOnCompleted(){} // RVA: 0x746290
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x75B010
    public void GetResult(){} // RVA: 0x7702A0
    public void OnCompleted(){} // RVA: 0x7702B0
    public void UnsafeOnCompleted(){} // RVA: 0x7703B0
    public void SourceOnCompleted(){} // RVA: 0x75B2C0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76D660
    public void UnsafeOnCompleted(){} // RVA: 0x76D760
    public void SourceOnCompleted(){} // RVA: 0x746690
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x748EF0
    public void get_IsCompleted(){} // RVA: 0x748F00
    public void GetResult(){} // RVA: 0x7716E0
    public void OnCompleted(){} // RVA: 0x771720
    public void UnsafeOnCompleted(){} // RVA: 0x771820
    public void SourceOnCompleted(){} // RVA: 0x749200
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7473D0
    public void get_IsCompleted(){} // RVA: 0x747440
    public void GetResult(){} // RVA: 0x76B7B0
    public void OnCompleted(){} // RVA: 0x771C30
    public void UnsafeOnCompleted(){} // RVA: 0x771D30
    public void SourceOnCompleted(){} // RVA: 0x7475D0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xD3E60
    public void get_IsCompleted(){} // RVA: 0x768C50
    public void GetResult(){} // RVA: 0x768FC0
    public void OnCompleted(){} // RVA: 0x768FD0
    public void UnsafeOnCompleted(){} // RVA: 0x7690D0
    public void SourceOnCompleted(){} // RVA: 0x7690E0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x748B30
    public void get_IsCompleted(){} // RVA: 0x748B40
    public void GetResult(){} // RVA: 0x764CA0
    public void OnCompleted(){} // RVA: 0x76A490
    public void UnsafeOnCompleted(){} // RVA: 0x76A590
    public void SourceOnCompleted(){} // RVA: 0x76A5A0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76D770
    public void UnsafeOnCompleted(){} // RVA: 0x76D870
    public void SourceOnCompleted(){} // RVA: 0x746690
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76E000
    public void UnsafeOnCompleted(){} // RVA: 0x76E100
    public void SourceOnCompleted(){} // RVA: 0x746690
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x769C70
    public void UnsafeOnCompleted(){} // RVA: 0x769D70
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76D770
    public void UnsafeOnCompleted(){} // RVA: 0x76D870
    public void SourceOnCompleted(){} // RVA: 0x746690
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76D990
    public void UnsafeOnCompleted(){} // RVA: 0x76DA90
    public void SourceOnCompleted(){} // RVA: 0x746690
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76DCA0
    public void UnsafeOnCompleted(){} // RVA: 0x76DDA0
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7473D0
    public void get_IsCompleted(){} // RVA: 0x747440
    public void GetResult(){} // RVA: 0x747480
    public void OnCompleted(){} // RVA: 0x7474C0
    public void UnsafeOnCompleted(){} // RVA: 0x7475C0
    public void SourceOnCompleted(){} // RVA: 0x7475D0
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76DCA0
    public void UnsafeOnCompleted(){} // RVA: 0x76DDA0
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x748EF0
    public void get_IsCompleted(){} // RVA: 0x748F00
    public void GetResult(){} // RVA: 0x76E660
    public void OnCompleted(){} // RVA: 0x76E6B0
    public void UnsafeOnCompleted(){} // RVA: 0x76E7B0
    public void SourceOnCompleted(){} // RVA: 0x749200
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746010
    public void get_IsCompleted(){} // RVA: 0x746020
    public void GetResult(){} // RVA: 0x747280
    public void OnCompleted(){} // RVA: 0x76EAD0
    public void UnsafeOnCompleted(){} // RVA: 0x76EBD0
    public void SourceOnCompleted(){} // RVA: 0x746290
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76DCA0
    public void UnsafeOnCompleted(){} // RVA: 0x76DDA0
    public void SourceOnCompleted(){} // RVA: 0x769D80
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746750
    public void get_IsCompleted(){} // RVA: 0x7705E0
    public void GetResult(){} // RVA: 0x746AC0
    public void OnCompleted(){} // RVA: 0x770620
    public void UnsafeOnCompleted(){} // RVA: 0x770720
    public void SourceOnCompleted(){} // RVA: 0x770730
}

public class Awaiter : ValueType
{
    public object task;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x746350
    public void get_IsCompleted(){} // RVA: 0x7463B0
    public void GetResult(){} // RVA: 0x7463F0
    public void OnCompleted(){} // RVA: 0x76F8C0
    public void UnsafeOnCompleted(){} // RVA: 0x76F9C0
    public void SourceOnCompleted(){} // RVA: 0x746690
}
