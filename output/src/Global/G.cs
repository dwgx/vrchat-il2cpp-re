// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 88
// Methods: 316

public class GCCDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AD07E0
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class GPUBuffer`1 : Object
{
    public UIntPtr ElementStride;
    public int BufferPointer;
    public int elemStride;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C72E60
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void UpdateRanges(){} // RVA: 0x7FFAC2E8DC40
    public void get_ElementStride(){} // RVA: 0x7FFAC2C59960
    public void get_BufferPointer(){} // RVA: 0x7FFAC2C58E90
}

public class GPlay : Object
{
    public int acknowledgementState; // 0x10
    public bool autoRenewing; // 0x14
    public string countryCode; // 0x18
    public string expiryTimeMillis; // 0x20
    public string kind; // 0x28
    public string orderId; // 0x30
    public int paymentState; // 0x38
    public string priceAmountMicros; // 0x40
    public string priceCurrencyCode; // 0x48
    public int purchaseType; // 0x50
    public string startTimeMillis; // 0x58

    // ── Methods ──
    public void get_acknowledgementState(){} // RVA: 0x7FFAC2F6E5C0
    public void set_acknowledgementState(){} // RVA: 0x7FFAC2F240C0
    public void get_autoRenewing(){} // RVA: 0x7FFAC3070BD0
    public void set_autoRenewing(){} // RVA: 0x7FFAC3070BE0
    public void get_countryCode(){} // RVA: 0x7FFAC2F247C0
    public void set_countryCode(){} // RVA: 0x7FFAC2F87E80
    public void get_expiryTimeMillis(){} // RVA: 0x7FFAC2F4F0C0
    public void set_expiryTimeMillis(){} // RVA: 0x7FFAC2F4F0D0
    public void get_kind(){} // RVA: 0x7FFAC2F4F130
    public void set_kind(){} // RVA: 0x7FFAC2F22E90
    public void get_orderId(){} // RVA: 0x7FFAC31D95E0
    public void set_orderId(){} // RVA: 0x7FFAC2F4F890
    public void get_paymentState(){} // RVA: 0x7FFAC358A870
    public void set_paymentState(){} // RVA: 0x7FFAC3588350
    public void get_priceAmountMicros(){} // RVA: 0x7FFAC2F9E740
    public void set_priceAmountMicros(){} // RVA: 0x7FFAC2F49200
    public void get_priceCurrencyCode(){} // RVA: 0x7FFAC2F9C730
    public void set_priceCurrencyCode(){} // RVA: 0x7FFAC2F9C740
    public void get_purchaseType(){} // RVA: 0x7FFAC30F10E0
    public void set_purchaseType(){} // RVA: 0x7FFAC31D9010
    public void get_startTimeMillis(){} // RVA: 0x7FFAC2FE9500
    public void set_startTimeMillis(){} // RVA: 0x7FFAC2FE9510
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GPtrArray : ValueType
{
    public UIntPtr* data; // 0x10
    public int len; // 0x18
}

public class GUIClearEvents : ValueType
{
}

public class GUID : Object
{
    public int a; // 0x10
    public short b; // 0x14
    public short c; // 0x16
    public byte d0; // 0x18
    public byte d1; // 0x19
    public byte d2; // 0x1A
    public byte d3; // 0x1B
    public byte d4; // 0x1C
    public byte d5; // 0x1D
    public byte d6; // 0x1E
    public byte d7; // 0x1F

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GUIGlobals : ValueType
{
    public UnityEngine.Matrix4x4 matrix; // 0x10
    public UnityEngine.Color color; // 0x50
    public UnityEngine.Color contentColor; // 0x60
    public UnityEngine.Color backgroundColor; // 0x70
    public bool enabled; // 0x80
    public bool changed; // 0x81
    public int displayIndex; // 0x84
}

public class GalleryObject : ApiModel
{
    public string name; // 0x68
    public string description; // 0x70
    public bool membersOnly; // 0x78
    public System.Collections.Generic.List`1<string> roleIdsToView; // 0x80
    public System.Collections.Generic.List`1<string> roleIdsToSubmit; // 0x88
    public System.Collections.Generic.List`1<string> roleIdsToAutoApprove; // 0x90
    public System.Collections.Generic.List`1<string> roleIdsToManage; // 0x98
    public System.DateTime createdAt; // 0xA0
    public System.DateTime updatedAt; // 0xA8

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFAC2F9CD50
    public void set_name(){} // RVA: 0x7FFAC2F9CD60
    public void get_description(){} // RVA: 0x7FFAC2FE9590
    public void set_description(){} // RVA: 0x7FFAC2FE95A0
    public void get_membersOnly(){} // RVA: 0x7FFAC33CE5C0
    public void set_membersOnly(){} // RVA: 0x7FFAC3D20B50
    public void get_roleIdsToView(){} // RVA: 0x7FFAC32EF410
    public void set_roleIdsToView(){} // RVA: 0x7FFAC34D4AA0
    public void get_roleIdsToSubmit(){} // RVA: 0x7FFAC2F60010
    public void set_roleIdsToSubmit(){} // RVA: 0x7FFAC354E300
    public void get_roleIdsToAutoApprove(){} // RVA: 0x7FFAC32EF640
    public void set_roleIdsToAutoApprove(){} // RVA: 0x7FFAC354E360
    public void get_roleIdsToManage(){} // RVA: 0x7FFAC354DFB0
    public void set_roleIdsToManage(){} // RVA: 0x7FFAC354E3C0
    public void get_createdAt(){} // RVA: 0x7FFAC3543900
    public void set_createdAt(){} // RVA: 0x7FFAC878D950
    public void get_updatedAt(){} // RVA: 0x7FFAC354B1A0
    public void set_updatedAt(){} // RVA: 0x7FFAC45C9F60
    public void .ctor(){} // RVA: 0x7FFACBF1CF20
}

public class GameObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFACC07B970
    public void SetObjectData(){} // RVA: 0x7FFACC07BC00
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GateFitParameters : ValueType
{
    public 0x6B1798F0 mode; // 0x10
    public float aspect; // 0x14

    // ── Methods ──
    public void get_mode(){} // RVA: 0x7FFAC4420210
    public void set_mode(){} // RVA: 0x7FFAC336D8B0
    public void get_aspect(){} // RVA: 0x7FFAC4A9B900
    public void set_aspect(){} // RVA: 0x7FFAC4A9B8F0
    public void .ctor(){} // RVA: 0x7FFAC336D8D0
}

public class GeneratedMethod : ValueType
{
    public System.Func`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceProviderEngineScope,object> Lambda; // 0x10
    public ILEmitResolverBuilderRuntimeContext Context; // 0x18
    public System.Reflection.Emit.DynamicMethod DynamicMethod; // 0x20
}

public class GenericParamInfo : ValueType
{
    public MonoClass* pklass; // 0x10
    public UIntPtr name; // 0x18
    public ushort flags; // 0x20
    public uint token; // 0x24
    public MonoClass** constraints; // 0x28
}

public class GenericPoolImpl`1 : Object
{
    public VRC.Core.Pool.ObjectPool`1<T> Pool;

    // ── Methods ──
    public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void Release(){} // RVA: 0x7FFAC2E8DC40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class GenericSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFACC07E230
    public void SetObjectData(){} // RVA: 0x7FFACC07F2C0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GestureIcon : ValueType
{
    public 0x6AFFF900 Type; // 0x10
    public UnityEngine.Sprite Icon; // 0x18
}

public class GestureIndicator : Object
{
    public UnityEngine.Sprite Right; // 0x10
    public UnityEngine.Sprite Left; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GestureInputState : Object
{
    public 0x6AFFF900 Type; // 0x10
    public 0x6B000878 Finger; // 0x14
    public bool IsLeftHand; // 0x18
    public bool IsHold; // 0x19
    public bool IsImmuneToGestureLock; // 0x1A
    public System.Func`2<GestureInputState,bool> IsAvailable; // 0x20
    public System.Func`2<GestureInputState,bool> StartAction; // 0x28
    public System.Action`1<GestureInputState> UpdateAction; // 0x30
    public System.Action`1<GestureInputState> EndAction; // 0x38
    public 0x6AFFF8A8 PreviousActivationState; // 0x40
    public 0x6AFFF8A8 ActivationState; // 0x44
    public float HoldTimer; // 0x48
    public float HoldDuration; // 0x4C
    public UnityEngine.AudioClip startSound; // 0x50
    public UnityEngine.AudioClip deactivateSound; // 0x58
    public UnityEngine.Sprite Icon; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GetAllQueuedEventsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC556C080
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class GetAvatarsResult : Object
{
    public System.Collections.Generic.IReadOnlyList`1<VRC.Core.ApiAvatar> Avatars; // 0x10
    public int Total; // 0x18
    public bool PassedValidation; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GetBinderAdapter : GetMemberBinder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void FallbackGetMember(){} // RVA: 0x7FFAC2C6A6F0
}

public class GetBlendOverrideDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC48436A0
    public void Invoke(){} // RVA: 0x7FFAC4843820
    public void BeginInvoke(){} // RVA: 0x7FFAC4843880
    public void EndInvoke(){} // RVA: 0x7FFAC4843930
}

public class GetBucketLimitsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6EA1B30
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC4B58720
}

public class GetClassValueAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class GetComponentStateUnion : ValueType
{
    public _GetComponentState pGetComponentState; // 0x10
    public _GetComponentStatePacked pGetComponentStatePacked; // 0x10
}

public class GetControllerStateUnion : ValueType
{
    public _GetControllerState pGetControllerState; // 0x10
    public _GetControllerStatePacked pGetControllerStatePacked; // 0x10
}

public class GetControllerStateWithPoseUnion : ValueType
{
    public _GetControllerStateWithPose pGetControllerStateWithPose; // 0x10
    public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked; // 0x10
}

public class GetCursorIdFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9B1B880
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class GetDroneDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB2620
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class GetDroneFromGameObjectDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6CEBC10
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CE60
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class GetEventCameraDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6EA1B30
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class GetHashCodeClass : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEE980
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GetHostAddressesCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6EA1B30
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class GetLookRayDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CB2320
    public void Invoke(){} // RVA: 0x7FFAC5CAEA60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFACC04E340
}

public class GetNetworkIdDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8972CF0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class GetPropApiDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6CE4810
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC6EA1C10
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class GetPropFromGameObjectDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6CEBC10
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC9D6CE60
    public void EndInvoke(){} // RVA: 0x7FFAC896F1B0
}

public class GetQueuedEventsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CBD490
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class GetRayIntersectionAllCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C71CD0
    public void Invoke(){} // RVA: 0x7FFAC9C71DA0
    public void BeginInvoke(){} // RVA: 0x7FFAC9C722E0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C71EB0
    public void Invoke(){} // RVA: 0x7FFAC9C71B90
    public void BeginInvoke(){} // RVA: 0x7FFAC9C723B0
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class GetRaycastNonAllocCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C71EB0
    public void Invoke(){} // RVA: 0x7FFAC9C71B90
    public void BeginInvoke(){} // RVA: 0x7FFAC9C71F80
    public void EndInvoke(){} // RVA: 0x7FFAC44220D0
}

public class GetSecurityInfoNativeCall : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC845F700
    public void Invoke(){} // RVA: 0x7FFAC5CC1930
}

public class GetStructValueAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class GetValue : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEE470
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GetValueOrDefault : NullableMethodCallInstruction
{
    public System.Type _defaultValueType; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8DEE4E0
    public void Run(){} // RVA: 0x7FFAC8DEE560
}

public class GetValueOrDefault1 : NullableMethodCallInstruction
{
    public object ConsumedStack;

    // ── Methods ──
    public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
    public void Run(){} // RVA: 0x7FFAC8DEE640
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GetterAdapter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AD0660
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class Getter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class GiftDisplayReference : Object
{
    public string name; // 0x10
    public UnityEngine.GameObject hologram; // 0x18
    public UnityEngine.GameObject display; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GiftInfo : Info
{
    public int bulkSize; // 0x80
    public bool isBulkGift; // 0x84

    // ── Methods ──
    public void get_bulkSize(){} // RVA: 0x7FFAC35729C0
    public void set_bulkSize(){} // RVA: 0x7FFAC3572BF0
    public void get_isBulkGift(){} // RVA: 0x7FFAC3000CE0
    public void set_isBulkGift(){} // RVA: 0x7FFAC3000CF0
    public void .ctor(){} // RVA: 0x7FFACBEF1220
}

public class GivenName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83690F0
}

public class GlobalState : ValueType
{
    public UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Runtime.InteropServices.GCHandle> globalList; // 0x10
    public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`2<object,0x6B1457B0>> onActionChange; // 0x28
    public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<object>> onActionControlsChanged; // 0x78
}

public class GotoExpressionProxy : Object
{
    public System.Linq.Expressions.GotoExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71760
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Kind(){} // RVA: 0x7FFAC843C820
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Target(){} // RVA: 0x7FFAC37735E0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
    public void get_Value(){} // RVA: 0x7FFAC356B610
}

public class Gpu : Object
{
    public Google.Protobuf.MessageParser`1<Gpu> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public bool UseAdvancedGpuApi; // 0x8
    public bool HasUseAdvancedGpuApi; // 0x1C
    public 0x6B2108D0 Api; // 0xC
    public 0x6B2108D0 HasApi; // 0x20
    public bool AllowPrecisionLoss; // 0x10
    public bool HasAllowPrecisionLoss; // 0x24
    public string CachedKernelPath; // 0x18
    public string HasCachedKernelPath; // 0x28
    public string SerializedModelDir; // 0x20
    public string HasSerializedModelDir; // 0x30
    public 0x6B210928 CacheWritingBehavior; // 0x28
    public 0x6B210928 HasCacheWritingBehavior; // 0x38
    public string ModelToken; // 0x30
    public string HasModelToken; // 0x40
    public 0x6B210980 Usage; // 0x38
    public 0x6B210980 HasUsage; // 0x48

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC827DA80
    public void get_Descriptor(){} // RVA: 0x7FFAC827DAE0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC827DB60
    public void .ctor(){} // RVA: 0x7FFAC827DC10 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC827DE40
    public void get_UseAdvancedGpuApi(){} // RVA: 0x7FFAC827DEA0
    public void set_UseAdvancedGpuApi(){} // RVA: 0x7FFAC827DF10
    public void get_HasUseAdvancedGpuApi(){} // RVA: 0x7FFAC81F3770
    public void ClearUseAdvancedGpuApi(){} // RVA: 0x7FFAC81F3780
    public void get_Api(){} // RVA: 0x7FFAC827DF20
    public void set_Api(){} // RVA: 0x7FFAC827DF90
    public void get_HasApi(){} // RVA: 0x7FFAC81F6A10
    public void ClearApi(){} // RVA: 0x7FFAC81F6A20
    public void get_AllowPrecisionLoss(){} // RVA: 0x7FFAC827DFA0
    public void set_AllowPrecisionLoss(){} // RVA: 0x7FFAC827E010
    public void get_HasAllowPrecisionLoss(){} // RVA: 0x7FFAC81F3810
    public void ClearAllowPrecisionLoss(){} // RVA: 0x7FFAC81F3820
    public void get_CachedKernelPath(){} // RVA: 0x7FFAC827E020
    public void set_CachedKernelPath(){} // RVA: 0x7FFAC827E090
    public void get_HasCachedKernelPath(){} // RVA: 0x7FFAC81FF390
    public void ClearCachedKernelPath(){} // RVA: 0x7FFAC53F2F70
    public void get_SerializedModelDir(){} // RVA: 0x7FFAC827E190
    public void set_SerializedModelDir(){} // RVA: 0x7FFAC827E200
    public void get_HasSerializedModelDir(){} // RVA: 0x7FFAC781E0A0
    public void ClearSerializedModelDir(){} // RVA: 0x7FFAC81FF510
    public void get_CacheWritingBehavior(){} // RVA: 0x7FFAC827E300
    public void set_CacheWritingBehavior(){} // RVA: 0x7FFAC827E370
    public void get_HasCacheWritingBehavior(){} // RVA: 0x7FFAC81F7240
    public void ClearCacheWritingBehavior(){} // RVA: 0x7FFAC81F7250
    public void get_ModelToken(){} // RVA: 0x7FFAC827E380
    public void set_ModelToken(){} // RVA: 0x7FFAC827E3F0
    public void get_HasModelToken(){} // RVA: 0x7FFAC781E0B0
    public void ClearModelToken(){} // RVA: 0x7FFAC81F6D10
    public void get_Usage(){} // RVA: 0x7FFAC827E4F0
    public void set_Usage(){} // RVA: 0x7FFAC827E560
    public void get_HasUsage(){} // RVA: 0x7FFAC81F6FD0
    public void ClearUsage(){} // RVA: 0x7FFAC81F6FE0
    public void Equals(){} // RVA: 0x7FFAC827E5D0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC827E7F0
    public void ToString(){} // RVA: 0x7FFAC827E980
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC827E9D0
    public void CalculateSize(){} // RVA: 0x7FFAC827EB60
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC827EF70
    public void .cctor(){} // RVA: 0x7FFAC827F150
}

public class GpuTimestamp : ValueType
{
}

public class Grab : Object
{
    public int GlobalPosition; // 0x10
    public VRC.Dynamics.ChainId LocalOffset; // 0x18
    public int bone; // 0x28
    public Unity.Mathematics.float3 globalPosition; // 0x2C
    public Unity.Mathematics.float3 localOffset; // 0x38
    public Pose pose; // 0x48

    // ── Methods ──
    public void get_GlobalPosition(){} // RVA: 0x7FFAC9E4E920
    public void set_GlobalPosition(){} // RVA: 0x7FFAC9E4E950
    public void get_LocalOffset(){} // RVA: 0x7FFAC9E4E980
    public void set_LocalOffset(){} // RVA: 0x7FFAC9E4E9B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GraphicsWarmupPreloadedShaders : ValueType
{
}

public class GreaterThanByte : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB0EC0
}

public class GreaterThanChar : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB0AA0
}

public class GreaterThanDouble : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB15A0
}

public class GreaterThanInt16 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB0940
}

public class GreaterThanInt32 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB0C00
}

public class GreaterThanInt64 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB0D60
}

public class GreaterThanOrEqualByte : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB2C00
}

public class GreaterThanOrEqualChar : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB27E0
}

public class GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB32E0
}

public class GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB2680
}

public class GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB2940
}

public class GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB2AA0
}

public class GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB2520
}

public class GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB3180
}

public class GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB2D60
}

public class GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB2EC0
}

public class GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB3020
}

public class GreaterThanSByte : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB07E0
}

public class GreaterThanSingle : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB1440
}

public class GreaterThanUInt16 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB1020
}

public class GreaterThanUInt32 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB1180
}

public class GreaterThanUInt64 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DB12E0
}

public class GridCell : ValueType
{
    public bool isValid; // 0x10
    public UnityEngine.Vector3Int position; // 0x14
    public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<CellRecord> activeList; // 0x20
    public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<CellRecord> records; // 0x38
    public Unity.Collections.LowLevel.Unsafe.UnsafeList`1<Pair> collisions; // 0x50

    // ── Methods ──
    public void IsValid(){} // RVA: 0x7FFAC495DDF0
    public void Init(){} // RVA: 0x7FFAC9DF4F30
    public void Dispose(){} // RVA: 0x7FFAC9DF5130
    public void RemoveShape(){} // RVA: 0x7FFAC9DF51F0
    public void AddShape(){} // RVA: 0x7FFAC9DF5290
}

public class GrounderDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class GroupContent : Object
{
    public uint _MinVal; // 0x10
    public uint _MaxVal; // 0x14
    public bool _HasMaxAttr; // 0x18
    public bool _HasMinAttr; // 0x19
    public int _Order; // 0x1C

    // ── Methods ──
    public void Copy(){} // RVA: 0x7FFAC912F7D0 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class GroupState : ValueType
{
    public System.Collections.Generic.List`1<UnityEngine.PhysicsShape2D> m_Shapes; // 0x10
    public System.Collections.Generic.List`1<UnityEngine.Vector2> m_Vertices; // 0x18
    public UnityEngine.Matrix4x4 m_LocalToWorld; // 0x20
}

public class Grouping : Object
{
    public U Key;
    public int System.Collections.Generic.ICollection<TElement>.Count;
    public T[] System.Collections.Generic.ICollection<TElement>.IsReadOnly;
    public int System.Collections.Generic.IList<TElement>.Item;
    public Grouping<U,T> hashNext;
    public Grouping<U,T> next;

    // ── Methods ──
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void get_Key(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.ICollection<TElement>.get_Count(){} // RVA: 0x7FFAC2C59960
    public void System.Collections.Generic.ICollection<TElement>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
    public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.ICollection<TElement>.Clear(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.Generic.ICollection<TElement>.Contains(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.ICollection<TElement>.CopyTo(){} // RVA: 0x7FFAC2C77970
    public void System.Collections.Generic.ICollection<TElement>.Remove(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.IList<TElement>.IndexOf(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.IList<TElement>.Insert(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.IList<TElement>.RemoveAt(){} // RVA: 0x7FFAC2C70ED0
    public void System.Collections.Generic.IList<TElement>.get_Item(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.IList<TElement>.set_Item(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class Grouping`2 : Object
{
    public System.Collections.Generic.List`1<T> Key;
    public T <Key>k__BackingField;

    // ── Methods ──
    public void get_Key(){} // RVA: 0x7FFAC2E8DC40
    public void set_Key(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void GetAsyncEnumerator(){}
    public void ToString(){} // RVA: 0x7FFAC2C58E90
}

public class GrowableArrayEnumerator : ValueType
{
    public int System.Collections.IEnumerator.Current;
    public int Current;
    public T[] array;

    // ── Methods ──
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Reset(){} // RVA: 0x7FFAC2C70980
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
}

public class GuidByteUnion : ValueType
{
    public byte Byte0; // 0x10
    public byte Byte1; // 0x11
    public byte Byte2; // 0x12
    public byte Byte3; // 0x13
    public byte Byte4; // 0x14
    public byte Byte5; // 0x15
    public byte Byte6; // 0x16
    public byte Byte7; // 0x17
    public byte Byte8; // 0x18
    public byte Byte9; // 0x19
    public byte Byte10; // 0x1A
    public byte Byte11; // 0x1B
    public byte Byte12; // 0x1C
    public byte Byte13; // 0x1D
    public byte Byte14; // 0x1E
    public byte Byte15; // 0x1F
    public System.Guid Value; // 0x10
}

public class GuidResult : ValueType
{
    public System.Guid _parsedGuid; // 0x10
    public 0x6B0BF600 _throwStyle; // 0x20
    public 0x6B0BF658 _failure; // 0x24
    public string _failureMessageID; // 0x28
    public object _failureMessageFormatArgument; // 0x30
    public string _failureArgumentName; // 0x38
    public System.Exception _innerException; // 0x40

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC2F240C0
    public void SetFailure(){} // RVA: 0x7FFAC862E130 | overloaded x4
    public void GetGuidParseException(){} // RVA: 0x7FFAC862E2D0
}

public class GzipContent : HttpContent
{
    public System.Net.Http.HttpContent _content; // 0x30
    public 0x6B139788 _compressionLevel; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8BC0C80
    public void TryComputeLength(){} // RVA: 0x7FFAC8BC1040
    public void SerializeToStreamAsync(){} // RVA: 0x7FFAC8BC1050
}
