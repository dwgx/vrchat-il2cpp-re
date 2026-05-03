// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 90
// Methods: 320

public class GCCDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828B3700
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class GPUBuffer`1 : Object
{
    public UIntPtr buffer;
    public int elemCount;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E484C0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void UpdateRanges(){} // RVA: 0x7FFE810A1420
    public void get_ElementStride(){} // RVA: 0x7FFE80E2EDB0
    public void get_BufferPointer(){} // RVA: 0x7FFE80E2E2E0
}

public class GPlay : Object
{
    public int _acknowledgementState; // 0x10
    public bool _autoRenewing; // 0x14
    public string _countryCode; // 0x18
    public string _expiryTimeMillis; // 0x20
    public string _kind; // 0x28
    public string _orderId; // 0x30
    public int _paymentState; // 0x38
    public string _priceAmountMicros; // 0x40
    public string _priceCurrencyCode; // 0x48
    public int _purchaseType; // 0x50
    public string _startTimeMillis; // 0x58

    // ── Methods ──
    public void get_acknowledgementState(){} // RVA: 0x7FFE811485C0
    public void set_acknowledgementState(){} // RVA: 0x7FFE810FE0C0
    public void get_autoRenewing(){} // RVA: 0x7FFE8124ABD0
    public void set_autoRenewing(){} // RVA: 0x7FFE8124ABE0
    public void get_countryCode(){} // RVA: 0x7FFE810FE7C0
    public void set_countryCode(){} // RVA: 0x7FFE81161E80
    public void get_expiryTimeMillis(){} // RVA: 0x7FFE811290C0
    public void set_expiryTimeMillis(){} // RVA: 0x7FFE811290D0
    public void get_kind(){} // RVA: 0x7FFE81129130
    public void set_kind(){} // RVA: 0x7FFE810FCE90
    public void get_orderId(){} // RVA: 0x7FFE8144E200
    public void set_orderId(){} // RVA: 0x7FFE81129890
    public void get_paymentState(){} // RVA: 0x7FFE81D46090
    public void set_paymentState(){} // RVA: 0x7FFE81D46A00
    public void get_priceAmountMicros(){} // RVA: 0x7FFE81178740
    public void set_priceAmountMicros(){} // RVA: 0x7FFE81123200
    public void get_priceCurrencyCode(){} // RVA: 0x7FFE81176730
    public void set_priceCurrencyCode(){} // RVA: 0x7FFE81176740
    public void get_purchaseType(){} // RVA: 0x7FFE8139DAD0
    public void set_purchaseType(){} // RVA: 0x7FFE81463B00
    public void get_startTimeMillis(){} // RVA: 0x7FFE811C3500
    public void set_startTimeMillis(){} // RVA: 0x7FFE811C3510
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GPtrArray : ValueType
{
}

public class GUIClearEvents : ValueType
{
}

public class GUID : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GUIGlobals : ValueType
{
}

public class GalleryObject : ApiModel
{
    public string _name; // 0x68
    public string _description; // 0x70
    public bool _membersOnly; // 0x78
    public System.Collections.Generic.List`1<string> _roleIdsToView; // 0x80
    public System.Collections.Generic.List`1<string> _roleIdsToSubmit; // 0x88
    public System.Collections.Generic.List`1<string> _roleIdsToAutoApprove; // 0x90
    public System.Collections.Generic.List`1<string> _roleIdsToManage; // 0x98
    public System.DateTime _createdAt; // 0xA0
    public System.DateTime _updatedAt; // 0xA8

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFE81176D50
    public void set_name(){} // RVA: 0x7FFE81176D60
    public void get_description(){} // RVA: 0x7FFE811C3590
    public void set_description(){} // RVA: 0x7FFE811C35A0
    public void get_membersOnly(){} // RVA: 0x7FFE816400C0
    public void set_membersOnly(){} // RVA: 0x7FFE81FE6AC0
    public void get_roleIdsToView(){} // RVA: 0x7FFE81280C30
    public void set_roleIdsToView(){} // RVA: 0x7FFE81282380
    public void get_roleIdsToSubmit(){} // RVA: 0x7FFE8113A010
    public void set_roleIdsToSubmit(){} // RVA: 0x7FFE81280F90
    public void get_roleIdsToAutoApprove(){} // RVA: 0x7FFE8154EB60
    public void set_roleIdsToAutoApprove(){} // RVA: 0x7FFE818CE320
    public void get_roleIdsToManage(){} // RVA: 0x7FFE817AE360
    public void set_roleIdsToManage(){} // RVA: 0x7FFE8171B470
    public void get_createdAt(){} // RVA: 0x7FFE8179C860
    public void set_createdAt(){} // RVA: 0x7FFE86B370C0
    public void get_updatedAt(){} // RVA: 0x7FFE817AB5E0
    public void set_updatedAt(){} // RVA: 0x7FFE82904630
    public void .ctor(){} // RVA: 0x7FFE8A37D600
}

public class GameObjectBinding : ValueType
{
}

public class GameObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFE8A4E1940
    public void SetObjectData(){} // RVA: 0x7FFE8A4E1BD0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GateFitParameters : ValueType
{
    public 0x6657315C _mode; // 0x10
    public float _aspect; // 0x14

    // ── Methods ──
    public void get_mode(){} // RVA: 0x7FFE826F4220
    public void set_mode(){} // RVA: 0x7FFE815BF990
    public void get_aspect(){} // RVA: 0x7FFE82D03B70
    public void set_aspect(){} // RVA: 0x7FFE82D03BD0
    public void .ctor(){} // RVA: 0x7FFE815BF9B0
}

public class GeneratedMethod : ValueType
{
}

public class GenericParamInfo : ValueType
{
}

public class GenericPoolImpl`1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x7FFE810A1420 | overloaded x2
    public void Release(){} // RVA: 0x7FFE810A1420
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class GenericSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFE8A4E4200
    public void SetObjectData(){} // RVA: 0x7FFE8A4E5290
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GestureIcon : ValueType
{
}

public class GestureIndicator : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GestureInputState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GetAllQueuedEventsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83871300
    public void Invoke(){} // RVA: 0x7FFE81159A50
    public void BeginInvoke(){} // RVA: 0x7FFE81159A60
    public void EndInvoke(){} // RVA: 0x7FFE826F5E00
}

public class GetAvatarsResult : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GetBinderAdapter : GetMemberBinder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void FallbackGetMember(){} // RVA: 0x7FFE80E3FC10
}

public class GetBlendOverrideDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AABA40
    public void Invoke(){} // RVA: 0x7FFE82AABBC0
    public void BeginInvoke(){} // RVA: 0x7FFE82AABC20
    public void EndInvoke(){} // RVA: 0x7FFE82AABCD0
}

public class GetBucketLimitsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8526B7D0
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE82DC25A0
}

public class GetClassValueAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class GetCompanionApiDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8506ACF0
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE8526B8B0
    public void EndInvoke(){} // RVA: 0x7FFE86D18840
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

public class GetCursorIdFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87EC4120
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class GetDroneDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE840108A0
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class GetDroneFromGameObjectDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE850720F0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881169B0
    public void EndInvoke(){} // RVA: 0x7FFE86D18840
}

public class GetEventCameraDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8526B7D0
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class GetHashCodeClass : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87196DB0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GetHostAddressesCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8526B7D0
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class GetLookRayDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE840105A0
    public void Invoke(){} // RVA: 0x7FFE8400CCE0
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE8A4B3E20
}

public class GetNetworkIdDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D1C380
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE826F5E00
}

public class GetPropApiDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8506ACF0
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE8526B8B0
    public void EndInvoke(){} // RVA: 0x7FFE86D18840
}

public class GetPropFromGameObjectDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE850720F0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE881169B0
    public void EndInvoke(){} // RVA: 0x7FFE86D18840
}

public class GetQueuedEventsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8401B8D0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE826F5E00
}

public class GetRayIntersectionAllCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8801A520
    public void Invoke(){} // RVA: 0x7FFE8801A5F0
    public void BeginInvoke(){} // RVA: 0x7FFE8801AB30
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8801A700
    public void Invoke(){} // RVA: 0x7FFE8801A3E0
    public void BeginInvoke(){} // RVA: 0x7FFE8801AC00
    public void EndInvoke(){} // RVA: 0x7FFE826F5E00
}

public class GetRaycastNonAllocCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8801A700
    public void Invoke(){} // RVA: 0x7FFE8801A3E0
    public void BeginInvoke(){} // RVA: 0x7FFE8801A7D0
    public void EndInvoke(){} // RVA: 0x7FFE826F5E00
}

public class GetSecurityInfoNativeCall : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86809010
    public void Invoke(){} // RVA: 0x7FFE8401FE60
}

public class GetStructValueAction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class GetValue : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871968A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GetValueOrDefault : NullableMethodCallInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87196910
    public void Run(){} // RVA: 0x7FFE87196990
}

public class GetValueOrDefault1 : NullableMethodCallInstruction
{
    // ── Methods ──
    public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
    public void Run(){} // RVA: 0x7FFE87196A70
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GetterAdapter : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828B3580
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class Getter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class GiftDisplayReference : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GiftInfo : Info
{
    public int _bulkSize; // 0x80
    public bool _isBulkGift; // 0x84

    // ── Methods ──
    public void get_bulkSize(){} // RVA: 0x7FFE81D30560
    public void set_bulkSize(){} // RVA: 0x7FFE81D307B0
    public void get_isBulkGift(){} // RVA: 0x7FFE811DACE0
    public void set_isBulkGift(){} // RVA: 0x7FFE811DACF0
    public void .ctor(){} // RVA: 0x7FFE8A350390
}

public class GivenName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE867129F0
}

public class GlobalState : ValueType
{
}

public class GotoExpressionProxy : Object
{
    public System.Linq.Expressions.GotoExpression _node; // 0x10
    public object field_1; // 0xC1
    public object field_2; // 0xC2
    public object field_3; // 0xC3
    public object field_4; // 0xC4
    public object field_5; // 0xC5
    public object field_6; // 0xC6

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87119B90
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_Kind(){} // RVA: 0x7FFE867E6130
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Target(){} // RVA: 0x7FFE8189B810
    public void get_Type(){} // RVA: 0x7FFE815888E0
    public void get_Value(){} // RVA: 0x7FFE8189C080
}

public class Gpu : Object
{
    public Google.Protobuf.MessageParser`1<Gpu> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public bool UseAdvancedGpuApiDefaultValue; // 0x8
    public bool useAdvancedGpuApi_; // 0x1C
    public 0x6660A194 ApiDefaultValue; // 0xC
    public 0x6660A194 api_; // 0x20
    public bool AllowPrecisionLossDefaultValue; // 0x10
    public bool allowPrecisionLoss_; // 0x24
    public string CachedKernelPathDefaultValue; // 0x18
    public string cachedKernelPath_; // 0x28
    public string SerializedModelDirDefaultValue; // 0x20
    public string serializedModelDir_; // 0x30
    public 0x6660A1EC CacheWritingBehaviorDefaultValue; // 0x28
    public 0x6660A1EC cacheWritingBehavior_; // 0x38
    public string ModelTokenDefaultValue; // 0x30
    public string modelToken_; // 0x40
    public 0x6660A244 UsageDefaultValue; // 0x38
    public 0x6660A244 usage_; // 0x48

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE866273A0
    public void get_Descriptor(){} // RVA: 0x7FFE86627400
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86627480
    public void .ctor(){} // RVA: 0x7FFE86627530 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE86627760
    public void get_UseAdvancedGpuApi(){} // RVA: 0x7FFE866277C0
    public void set_UseAdvancedGpuApi(){} // RVA: 0x7FFE86627830
    public void get_HasUseAdvancedGpuApi(){} // RVA: 0x7FFE8659D0B0
    public void ClearUseAdvancedGpuApi(){} // RVA: 0x7FFE8659D0C0
    public void get_Api(){} // RVA: 0x7FFE86627840
    public void set_Api(){} // RVA: 0x7FFE866278B0
    public void get_HasApi(){} // RVA: 0x7FFE865A0350
    public void ClearApi(){} // RVA: 0x7FFE865A0360
    public void get_AllowPrecisionLoss(){} // RVA: 0x7FFE866278C0
    public void set_AllowPrecisionLoss(){} // RVA: 0x7FFE86627930
    public void get_HasAllowPrecisionLoss(){} // RVA: 0x7FFE8659D150
    public void ClearAllowPrecisionLoss(){} // RVA: 0x7FFE8659D160
    public void get_CachedKernelPath(){} // RVA: 0x7FFE86627940
    public void set_CachedKernelPath(){} // RVA: 0x7FFE866279B0
    public void get_HasCachedKernelPath(){} // RVA: 0x7FFE865A8CD0
    public void ClearCachedKernelPath(){} // RVA: 0x7FFE836E7F30
    public void get_SerializedModelDir(){} // RVA: 0x7FFE86627AB0
    public void set_SerializedModelDir(){} // RVA: 0x7FFE86627B20
    public void get_HasSerializedModelDir(){} // RVA: 0x7FFE85C00B10
    public void ClearSerializedModelDir(){} // RVA: 0x7FFE865A8E50
    public void get_CacheWritingBehavior(){} // RVA: 0x7FFE86627C20
    public void set_CacheWritingBehavior(){} // RVA: 0x7FFE86627C90
    public void get_HasCacheWritingBehavior(){} // RVA: 0x7FFE865A0B80
    public void ClearCacheWritingBehavior(){} // RVA: 0x7FFE865A0B90
    public void get_ModelToken(){} // RVA: 0x7FFE86627CA0
    public void set_ModelToken(){} // RVA: 0x7FFE86627D10
    public void get_HasModelToken(){} // RVA: 0x7FFE85C00F00
    public void ClearModelToken(){} // RVA: 0x7FFE865A0650
    public void get_Usage(){} // RVA: 0x7FFE86627E10
    public void set_Usage(){} // RVA: 0x7FFE86627E80
    public void get_HasUsage(){} // RVA: 0x7FFE865A0910
    public void ClearUsage(){} // RVA: 0x7FFE865A0920
    public void Equals(){} // RVA: 0x7FFE86627EF0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE86628110
    public void ToString(){} // RVA: 0x7FFE866282A0
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866282F0
    public void CalculateSize(){} // RVA: 0x7FFE86628480
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86628890
    public void .cctor(){} // RVA: 0x7FFE86628A70
}

public class GpuTimestamp : ValueType
{
}

public class Grab : Object
{
    public int playerId; // 0x10
    public VRC.Dynamics.ChainId chainId; // 0x18

    // ── Methods ──
    public void get_GlobalPosition(){} // RVA: 0x7FFE881FF400
    public void set_GlobalPosition(){} // RVA: 0x7FFE881FF430
    public void get_LocalOffset(){} // RVA: 0x7FFE881FF460
    public void set_LocalOffset(){} // RVA: 0x7FFE881FF490
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GraphicsWarmupPreloadedShaders : ValueType
{
}

public class GreaterThanByte : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE871592F0
}

public class GreaterThanChar : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE87158ED0
}

public class GreaterThanDouble : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE871599D0
}

public class GreaterThanInt16 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE87158D70
}

public class GreaterThanInt32 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE87159030
}

public class GreaterThanInt64 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE87159190
}

public class GreaterThanOrEqualByte : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715B030
}

public class GreaterThanOrEqualChar : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715AC10
}

public class GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715B710
}

public class GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715AAB0
}

public class GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715AD70
}

public class GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715AED0
}

public class GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715A950
}

public class GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715B5B0
}

public class GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715B190
}

public class GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715B2F0
}

public class GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE8715B450
}

public class GreaterThanSByte : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE87158C10
}

public class GreaterThanSingle : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE87159870
}

public class GreaterThanUInt16 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE87159450
}

public class GreaterThanUInt32 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE871595B0
}

public class GreaterThanUInt64 : GreaterThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Run(){} // RVA: 0x7FFE87159710
}

public class GridCell : ValueType
{
    // ── Methods ──
    public void IsValid(){} // RVA: 0x7FFE82BC9920
    public void Init(){} // RVA: 0x7FFE8819D900
    public void Dispose(){} // RVA: 0x7FFE8819DB00
    public void RemoveShape(){} // RVA: 0x7FFE8819DBC0
    public void AddShape(){} // RVA: 0x7FFE8819DC70
}

public class GrounderDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
    public void BeginInvoke(){} // RVA: 0x7FFE81159A60
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class GroupContent : Object
{
    // ── Methods ──
    public void Copy(){} // RVA: 0x7FFE874D7F80 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class GroupState : ValueType
{
}

public class Grouping : Object
{
    public U key;
    public int hashCode;
    public T[] elements;
    public int count;

    // ── Methods ──
    public void Add(){} // RVA: 0x7FFE810A1420
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void get_Key(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.ICollection<TElement>.get_Count(){} // RVA: 0x7FFE80E2EDB0
    public void System.Collections.Generic.ICollection<TElement>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
    public void System.Collections.Generic.ICollection<TElement>.Add(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.ICollection<TElement>.Clear(){} // RVA: 0x7FFE80E45FE0
    public void System.Collections.Generic.ICollection<TElement>.Contains(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.ICollection<TElement>.CopyTo(){} // RVA: 0x7FFE80E4D070
    public void System.Collections.Generic.ICollection<TElement>.Remove(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.IList<TElement>.IndexOf(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.IList<TElement>.Insert(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.IList<TElement>.RemoveAt(){} // RVA: 0x7FFE80E46530
    public void System.Collections.Generic.IList<TElement>.get_Item(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.IList<TElement>.set_Item(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class Grouping`2 : Object
{
    public System.Collections.Generic.List`1<T> elements;

    // ── Methods ──
    public void get_Key(){} // RVA: 0x7FFE810A1420
    public void set_Key(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void Add(){} // RVA: 0x7FFE810A1420
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void GetAsyncEnumerator(){}
    public void ToString(){} // RVA: 0x7FFE80E2E2E0
}

public class GrowableArrayEnumerator : ValueType
{
    public int cur;
    public int end;

    // ── Methods ──
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Reset(){} // RVA: 0x7FFE80E45FE0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void .ctor(){} // RVA: 0x7FFE810A1420
}

public class GuidByteUnion : ValueType
{
}

public class GuidResult : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE810FE0C0
    public void SetFailure(){} // RVA: 0x7FFE869D7900 | overloaded x4
    public void GetGuidParseException(){} // RVA: 0x7FFE869D7AA0
}

public class GzipContent : HttpContent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86F6A300
    public void TryComputeLength(){} // RVA: 0x7FFE86F6A6C0
    public void SerializeToStreamAsync(){} // RVA: 0x7FFE86F6A6D0
}
