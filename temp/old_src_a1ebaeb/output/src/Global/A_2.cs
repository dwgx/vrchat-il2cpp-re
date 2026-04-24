// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 507

public class ActionSettings : ValueType
{
    public object m_BoostAmount; // 0x34B4E850
    public object m_Event; // 0x34B4E850
    public object 00; // 0x4000380

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa25b7e0
    public void Invoke(){} // RVA: 0x7ffaaa25b950
}

public class Activity : ValueType
{
    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaaa37d510
    public void Drop(){} // RVA: 0x7ffaaa37d590
    public void Assets(){} // RVA: 0x7ffaaa37d6a0
    public void Timestamps(){} // RVA: 0x7ffaaa37d7c0
    public void Party(){} // RVA: 0x7ffaaa37d8e0
    public void Secrets(){} // RVA: 0x7ffaaa37da00
    // ── Binary Analysis Named ──
    public void SetState(){} // RVA: 0x7ffaaa37d610
    public void SetAssets(){} // RVA: 0x7ffaaa37d730
    public void SetTimestamps(){} // RVA: 0x7ffaaa37d850
    public void SetParty(){} // RVA: 0x7ffaaa37d970
    public void SetSecrets(){} // RVA: 0x7ffaaa37da90
}

public class ActivityAssets : ValueType
{
    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaaa37cbe0
    public void Drop(){} // RVA: 0x7ffaaa37cc60
    // ── Binary Analysis Named ──
    public void SetLargeImage(){} // RVA: 0x7ffaaa37cce0
    public void SetLargeText(){} // RVA: 0x7ffaaa37cd70
    public void SetSmallImage(){} // RVA: 0x7ffaaa37ce00
    public void SetSmallText(){} // RVA: 0x7ffaaa37ce90
}

public class ActivityBaggageLogScopeWrapper : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8933e30
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaadd6c0f0
    public void ToString(){} // RVA: 0x7ffaadd6c1c0
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaadd6c020
}

public class ActivityJoinCallback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa898db80
    public void Invoke(){} // RVA: 0x7ffaa898dc60
}

public class ActivityJoinCallback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa37fb70
    public void Invoke(){} // RVA: 0x7ffaaa37fc40
}

public class ActivityLogScope : Object
{
    public object _count; // 0x3509F1B0, was: <Count>k__BackingField
    public object Count; // 0x1700000A

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaadd6b3c0
    public void get_Count(){} // RVA: 0x7ffaa8aeced0
    public void get_Item(){} // RVA: 0x7ffaadd6bb00
    public void ToString(){} // RVA: 0x7ffaadd6bb90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaadd6be20
    // ── Binary Analysis Named ──
    public void GetEnumerator(){} // RVA: 0x7ffaadd6be20
}

public class ActivityParty : ValueType
{
    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaaa37d0b0
    public void Drop(){} // RVA: 0x7ffaaa37d130
    // ── Binary Analysis Named ──
    public void SetId(){} // RVA: 0x7ffaaa37d1b0
    public void SetCurrentSize(){} // RVA: 0x7ffaaa37d250
    public void SetMaxSize(){} // RVA: 0x7ffaaa37d2e0
}

public class ActivitySecrets : ValueType
{
    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaaa37d370
    public void Drop(){} // RVA: 0x7ffaaa37d3f0
    // ── Binary Analysis Named ──
    public void SetJoin(){} // RVA: 0x7ffaaa37d470
}

public class ActivityTimestamps : ValueType
{
    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaaa37cf20
    public void Drop(){} // RVA: 0x7ffaaa37cfa0
    // ── Binary Analysis Named ──
    public void SetStart(){} // RVA: 0x7ffaaa37d020
}

public class AddEventAdapter : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9fdcf70
    public void Invoke(){} // RVA: 0x7ffaa8a8e370
}

public class AdjustmentRule : Object
{
    public object _daylightDelta; // 0x34FA3090
    public object _baseUtcOffsetDelta; // 0x34FA3090
    public object _month; // 0x34FA33C0

    // ── Original Methods ──
    public void get_DateStart(){} // RVA: 0x7ffaa894d380
    public void get_DateEnd(){} // RVA: 0x7ffaa89357c0
    public void get_DaylightDelta(){} // RVA: 0x7ffaa89600c0
    public void get_DaylightTransitionStart(){} // RVA: 0x7ffaaa56e760
    public void get_DaylightTransitionEnd(){} // RVA: 0x7ffaa893be10
    public void get_BaseUtcOffsetDelta(){} // RVA: 0x7ffaa89fa500
    public void get_NoDaylightTransitions(){} // RVA: 0x7ffaa895b020
    public void get_HasDaylightSaving(){} // RVA: 0x7ffaadf244f0
    public void Equals(){} // RVA: 0x7ffaadf246d0
    public void .ctor(){} // RVA: 0x7ffaadf25c80
    public void CreateAdjustmentRule(){} // RVA: 0x7ffaadf249e0
    public void IsStartDateMarkerForBeginningOfYear(){} // RVA: 0x7ffaadf24b20
    public void IsEndDateMarkerForEndOfYear(){} // RVA: 0x7ffaadf24c70
    public void ValidateAdjustmentRule(){} // RVA: 0x7ffaadf24dc0
    public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7ffaadf25530
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7ffaadf25610
    public void .ctor(){} // RVA: 0x7ffaadf25c80
    public void .ctor(){} // RVA: 0x7ffaadf25c80
    // ── Binary Analysis Named ──
    public void GetHashCode(){} // RVA: 0x7ffaadf24840
}

public class AllowedAsciiCodePoints : ValueType
{
    // ── Original Methods ──
    public void PopulateAllowedCodePoints(){} // RVA: 0x7ffaae4a6f60
}

public class AnyKeyObj : Object
{
    // ── Original Methods ──
    public void ToString(){} // RVA: 0x7ffaadd420a0
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class ApiBundleDropNotificationDetails : ApiModel
{
    public object _imageUrl; // 0x344B79C0, was: <imageUrl>k__BackingField

    // ── Original Methods ──
    public void get_title(){} // RVA: 0x7ffaa89add50
    public void set_title(){} // RVA: 0x7ffaa89add60
    public void get_body(){} // RVA: 0x7ffaa89fa590
    public void set_body(){} // RVA: 0x7ffaa89fa5a0
    public void get_imageUrl(){} // RVA: 0x7ffaa8af68f0
    public void set_imageUrl(){} // RVA: 0x7ffaa8af19e0
    public void .ctor(){} // RVA: 0x7ffab1895d10
}

public class ApiPopupBuilderData : ApiModel
{
    public object _spacing; // 0x35D795A0, was: <spacing>k__BackingField

    // ── Original Methods ──
    public void get_key(){} // RVA: 0x7ffaa89add50
    public void set_key(){} // RVA: 0x7ffaa89add60
    public void get_title(){} // RVA: 0x7ffaa89fa590
    public void set_title(){} // RVA: 0x7ffaa89fa5a0
    public void get_spacing(){} // RVA: 0x7ffaa895b0e0
    public void set_spacing(){} // RVA: 0x7ffaa895b0f0
    public void get_content(){} // RVA: 0x7ffaa8d1a3b0
    public void set_content(){} // RVA: 0x7ffaa8efece0
    public void .ctor(){} // RVA: 0x7ffab18954f0
}

public class ApiPopupBuilderRecipe : ApiModel
{
    // ── Original Methods ──
    public void get_pages(){} // RVA: 0x7ffaa89add50
    public void set_pages(){} // RVA: 0x7ffaa89add60
    public void .ctor(){} // RVA: 0x7ffab18954a0
}

public class ApiPromotionNotification : ApiModel
{
    public object _imageUrl; // 0x35D78F80, was: <imageUrl>k__BackingField

    // ── Original Methods ──
    public void get_title(){} // RVA: 0x7ffaa89add50
    public void set_title(){} // RVA: 0x7ffaa89add60
    public void get_body(){} // RVA: 0x7ffaa89fa590
    public void set_body(){} // RVA: 0x7ffaa89fa5a0
    public void get_imageUrl(){} // RVA: 0x7ffaa8af68f0
    public void set_imageUrl(){} // RVA: 0x7ffaa8af19e0
    public void get_command(){} // RVA: 0x7ffaa8d1a3b0
    public void set_command(){} // RVA: 0x7ffaa8efece0
    public void get_parameter(){} // RVA: 0x7ffaa8971010
    public void set_parameter(){} // RVA: 0x7ffaa8f7b010
    public void .ctor(){} // RVA: 0x7ffab1895450
}

public class ApiRequestData : ValueType
{
    public object FormData; // 0x3515DB30
    public object onFailure; // 0x30BD8C30

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffab187bca0
    public void .ctor(){} // RVA: 0x7ffab187bca0
    public void .ctor(){} // RVA: 0x7ffab187bca0
    public void op_Implicit(){} // RVA: 0x7ffab187be10
    public void op_Implicit(){} // RVA: 0x7ffab187be10
    public void op_Implicit(){} // RVA: 0x7ffab187be10
}

public class ApiVRChatProductStore : ApiModel
{
    // ── Original Methods ──
    public void get_planId(){} // RVA: 0x7ffaa89add50
    public void set_planId(){} // RVA: 0x7ffaa89add60
    public void .ctor(){} // RVA: 0x7ffab190cf30
}

public class Appearance : Object
{
    public object width; // 0x34B46770

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa24d900
}

public class Array16`1 : ValueType
{
    public object f2; // 0x34F201B0
    public object f5; // 0x34F201B0
    public object f8; // 0x34F201B0
    public object f11; // 0x34F201B0
    public object f14; // 0x34F201B0
    public object 00; // 0x4000039
    public object 00; // 0x400003C
    public object 00; // 0x400003F
}

public class Array256`1 : ValueType
{
    public object f2; // 0x34F20330
    public object f5; // 0x34F20330
    public object f8; // 0x34F20330
    public object f11; // 0x34F20330
    public object f14; // 0x34F20330
    public object 00; // 0x4000049
    public object 00; // 0x400004C
    public object 00; // 0x400004F
}

public class Array4096`1 : ValueType
{
    public object f2; // 0x34F204B0
    public object f5; // 0x34F204B0
    public object f8; // 0x34F204B0
    public object f11; // 0x34F204B0
    public object f14; // 0x34F204B0
    public object 00; // 0x30300D10
    public object IIndexable`1; // 0xB40CCD60
}

public class ArrayPoolImpl`1 : Object
{
    public object Instance; // 0x35755300
    public object `Ǐf; // 0x35755508

    // ── Original Methods ──
    public void get_ObjectType(){} // RVA: 0x7ffaabd8ffe0
    public void get_CountInactive(){} // RVA: 0x7ffaabd8ac40
    public void .ctor(){} // RVA: 0x7ffaabd90020
    public void Contains(){} // RVA: 0x7ffaabd8b4a0
    public void Release(){} // RVA: 0x7ffaabd8b6f0
    public void Cleanup(){} // RVA: 0x7ffaabd90530
    public void .cctor(){} // RVA: 0x7ffaabd90c50
    // ── Binary Analysis Named ──
    public void Get(){} // RVA: 0x7ffaabd901b0
}

public class AsciiPreescapedData : ValueType
{
    // ── Original Methods ──
    public void PopulatePreescapedData(){} // RVA: 0x7ffaae9ef930
    public void TryGetPreescapedData(){} // RVA: 0x7ffaae4a72c0
}

public class AspectStretcher : ValueType
{
    public object m_CenterX; // 0x34B4C8E0

    // ── Original Methods ──
    public void get_Aspect(){} // RVA: 0x7ffaaa254060
    public void .ctor(){} // RVA: 0x7ffaaa254070
    public void Stretch(){} // RVA: 0x7ffaaa254090
    public void Unstretch(){} // RVA: 0x7ffaaa2540c0
}

public class AttachExternalCancellationSource`1 : Object
{
    public object tokenRegistration; // 0x357F2678

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad638d20
    public void RunTask(){} // RVA: 0x7ffaad639040
    public void CancellationCallback(){} // RVA: 0x7ffaad6391c0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaad639270
    public void OnCompleted(){} // RVA: 0x7ffaad6392b0
    public void UnsafeGetStatus(){} // RVA: 0x7ffaad6392e0
    public void .cctor(){} // RVA: 0x7ffaad639300
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaad639270
    public void GetStatus(){} // RVA: 0x7ffaad639290
}

public class AttributeInfo : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa2965c0
    public void get_Usage(){} // RVA: 0x7ffaa894d380
    public void get_InheritanceLevel(){} // RVA: 0x7ffaa8b945a0
}

public class AuthorizationArgs : ValueType
{
    // ── Original Methods ──
    public void Init(){} // RVA: 0x7ffaaa37de40
    public void Drop(){} // RVA: 0x7ffaaa37dec0
    // ── Binary Analysis Named ──
    public void SetClientId(){} // RVA: 0x7ffaaa37df40
    public void SetScopes(){} // RVA: 0x7ffaaa37dfd0
}

public class AuthorizationCallback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa385720
    public void Invoke(){} // RVA: 0x7ffaa8a8e4e0
}

public class AuthorizationCallback : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa37f870
    public void Invoke(){} // RVA: 0x7ffaaa37f950
}

public class AutoDolly : ValueType
{
    public object m_SearchRadius; // 0x34B44030
    public object m_PathPosition; // 0x33665270

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa23b510
}

public class Avx : Object
{
    // ── Original Methods ──
    public void mm256_load_ps(){} // RVA: 0x7ffaaa5ba1a0
    public void mm256_store_ps(){} // RVA: 0x7ffaaef2f090
    public void mm256_loadu_si256(){} // RVA: 0x7ffaaa5ba1a0
    public void mm256_storeu_si256(){} // RVA: 0x7ffaaef2f090
    public void mm256_set1_epi32(){} // RVA: 0x7ffaaef2f0a0
}

public class Avx2 : Object
{
    // ── Original Methods ──
    public void get_IsAvx2Supported(){} // RVA: 0x7ffaa8932320
    public void mm256_xor_si256(){} // RVA: 0x7ffaaef2f0c0
    public void mm256_add_epi64(){} // RVA: 0x7ffaaef2f120
    public void mm256_mul_epu32(){} // RVA: 0x7ffaaef2f190
    public void mm256_slli_epi64(){} // RVA: 0x7ffaaef2f200
    public void mm256_srli_epi64(){} // RVA: 0x7ffaaef2f330
    public void mm256_shuffle_epi32(){} // RVA: 0x7ffaaef2f490
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63d4d0
    public void get_IsCompleted(){} // RVA: 0x7ffaad63d540
    public void OnCompleted(){} // RVA: 0x7ffaad6609a0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad660aa0
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63d780
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8cd05a0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63d840
    public void get_IsCompleted(){} // RVA: 0x7ffaad63d8a0
    public void OnCompleted(){} // RVA: 0x7ffaad65f3a0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad65f4a0
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63dae0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8e01080
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63d840
    public void get_IsCompleted(){} // RVA: 0x7ffaad63d8a0
    public void OnCompleted(){} // RVA: 0x7ffaad6611a0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad6612a0
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63dae0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8e01080
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63d840
    public void get_IsCompleted(){} // RVA: 0x7ffaad63d8a0
    public void OnCompleted(){} // RVA: 0x7ffaad65c5f0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad65c6f0
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63dae0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8e01080
}

public class Awaiter : ValueType
{
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63d4d0
    public void get_IsCompleted(){} // RVA: 0x7ffaad63d540
    public void OnCompleted(){} // RVA: 0x7ffaad65f7a0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad65f8a0
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63d780
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8cd05a0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63d840
    public void get_IsCompleted(){} // RVA: 0x7ffaad63d8a0
    public void OnCompleted(){} // RVA: 0x7ffaad65c5f0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad65c6f0
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63dae0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8e01080
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaad63dc00
    public void OnCompleted(){} // RVA: 0x7ffaad662010
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662110
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63d840
    public void get_IsCompleted(){} // RVA: 0x7ffaad63d8a0
    public void OnCompleted(){} // RVA: 0x7ffaad65f3a0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad65f4a0
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63dae0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8e01080
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63fa10
    public void get_IsCompleted(){} // RVA: 0x7ffaad63fa80
    public void OnCompleted(){} // RVA: 0x7ffaad662210
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662310
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63fd80
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaad63fac0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63d840
    public void get_IsCompleted(){} // RVA: 0x7ffaad63d8a0
    public void OnCompleted(){} // RVA: 0x7ffaad65f3a0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad65f4a0
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63dae0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8e01080
}

public class Awaiter : ValueType
{
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class Awaiter : ValueType
{
}

public class Awaiter : ValueType
{
}

public class Awaiter : ValueType
{
}

public class Awaiter : ValueType
{
}

public class Awaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaad63dba0
    public void get_IsCompleted(){} // RVA: 0x7ffaa8c6c8c0
    public void OnCompleted(){} // RVA: 0x7ffaad662410
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaad662510
    public void SourceOnCompleted(){} // RVA: 0x7ffaad63de40
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaa8c6c9d0
}

public class AxisInputDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa24b4d0
    public void Invoke(){} // RVA: 0x7ffaa898dc60
    public void EndInvoke(){} // RVA: 0x7ffaa9a347f0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaa898dc70
}
