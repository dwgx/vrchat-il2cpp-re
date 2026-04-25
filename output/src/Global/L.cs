// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 46
// Methods: 278

public class Label : ValueType
{
    public string name; // 0x10
    public UnityEngine.Texture2D icon; // 0x18
}

public class LambdaSignature`1 : Object
{
    public LambdaSignature`1<T> Instance;
    public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression> Parameters;
    public 0x6654CA68 ReturnLabel;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7FFD4E078A90
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class LayoutJson : ValueType
{
    public string name; // 0x10
    public string extend; // 0x18
    public string[] extendMultiple; // 0x20
    public string format; // 0x28
    public string beforeRender; // 0x30
    public string runInBackground; // 0x38
    public string[] commonUsages; // 0x40
    public string displayName; // 0x48
    public string description; // 0x50
    public string type; // 0x58
    public string variant; // 0x60
    public bool isGenericTypeOfDevice; // 0x68
    public bool hideInUI; // 0x69
    public ControlItemJson[] controls; // 0x70

    // ── Methods ──
    public void ToLayout(){} // RVA: 0x7FFD54AB19A0
    public void FromLayout(){} // RVA: 0x7FFD54AB2670
}

public class LayoutJsonNameAndDescriptorOnly : ValueType
{
    public string name; // 0x10
    public string extend; // 0x18
    public string[] extendMultiple; // 0x20
    public MatcherJson device; // 0x28
}

public class LayoutMatcher : ValueType
{
    public UnityEngine.InputSystem.Utilities.InternedString layoutName; // 0x10
    public UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher; // 0x20
}

public class LayoutNotFoundException : Exception
{
    public string layout; // 0x90

    // ── Methods ──
    public void get_layout(){} // RVA: 0x7FFD4E70F640
    public void .ctor(){} // RVA: 0x7FFD5496FDA0 | overloaded x5
}

public class LazyCAttrData : Object
{
    public System.Reflection.Assembly assembly; // 0x10
    public UIntPtr data; // 0x18
    public uint data_length; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class LegacyAnimationUpdate : ValueType
{
}

public class LegacyFixedAnimationUpdate : ValueType
{
}

public class LegacySignalSource : Object
{
    public Cinemachine.CinemachineImpulseDefinition SignalDuration; // 0x10
    public UnityEngine.Vector3 m_Velocity; // 0x18
    public float m_StartTimeOffset; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC77B20
    public void get_SignalDuration(){} // RVA: 0x7FFD4FC77BE0
    public void GetSignal(){} // RVA: 0x7FFD4FC77C20
}

public class LifetimeByEmitterSpeedModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
}

public class LightsModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D7AC90
    public void set_enabled(){} // RVA: 0x7FFD54D7ACE0
    public void get_ratio(){} // RVA: 0x7FFD54D7AD40
    public void set_ratio(){} // RVA: 0x7FFD54D7AD90
    public void get_useRandomDistribution(){} // RVA: 0x7FFD54D7ADF0
    public void set_useRandomDistribution(){} // RVA: 0x7FFD54D7AE40
    public void get_light(){} // RVA: 0x7FFD54D7AEA0
    public void set_light(){} // RVA: 0x7FFD54D7AEF0
    public void get_useParticleColor(){} // RVA: 0x7FFD54D7AF50
    public void set_useParticleColor(){} // RVA: 0x7FFD54D7AFA0
    public void get_sizeAffectsRange(){} // RVA: 0x7FFD54D7B000
    public void set_sizeAffectsRange(){} // RVA: 0x7FFD54D7B050
    public void get_alphaAffectsIntensity(){} // RVA: 0x7FFD54D7B0B0
    public void set_alphaAffectsIntensity(){} // RVA: 0x7FFD54D7B100
    public void get_range(){} // RVA: 0x7FFD54D7B160
    public void set_range(){} // RVA: 0x7FFD54D7B1D0
    public void get_rangeMultiplier(){} // RVA: 0x7FFD54D7B230
    public void set_rangeMultiplier(){} // RVA: 0x7FFD54D7B280
    public void get_intensity(){} // RVA: 0x7FFD54D7B2E0
    public void set_intensity(){} // RVA: 0x7FFD54D7B350
    public void get_intensityMultiplier(){} // RVA: 0x7FFD54D7B3B0
    public void set_intensityMultiplier(){} // RVA: 0x7FFD54D7B400
    public void get_maxLights(){} // RVA: 0x7FFD54D7B460
    public void set_maxLights(){} // RVA: 0x7FFD54D7B4B0
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D7AC90
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D7ACE0
    public void get_ratio_Injected(){} // RVA: 0x7FFD54D7AD40
    public void set_ratio_Injected(){} // RVA: 0x7FFD54D7AD90
    public void get_useRandomDistribution_Injected(){} // RVA: 0x7FFD54D7ADF0
    public void set_useRandomDistribution_Injected(){} // RVA: 0x7FFD54D7AE40
    public void get_light_Injected(){} // RVA: 0x7FFD54D7AEA0
    public void set_light_Injected(){} // RVA: 0x7FFD54D7AEF0
    public void get_useParticleColor_Injected(){} // RVA: 0x7FFD54D7AF50
    public void set_useParticleColor_Injected(){} // RVA: 0x7FFD54D7AFA0
    public void get_sizeAffectsRange_Injected(){} // RVA: 0x7FFD54D7B000
    public void set_sizeAffectsRange_Injected(){} // RVA: 0x7FFD54D7B050
    public void get_alphaAffectsIntensity_Injected(){} // RVA: 0x7FFD54D7B0B0
    public void set_alphaAffectsIntensity_Injected(){} // RVA: 0x7FFD54D7B100
    public void get_range_Injected(){} // RVA: 0x7FFD54D7B510
    public void set_range_Injected(){} // RVA: 0x7FFD54D7B570
    public void get_rangeMultiplier_Injected(){} // RVA: 0x7FFD54D7B230
    public void set_rangeMultiplier_Injected(){} // RVA: 0x7FFD54D7B280
    public void get_intensity_Injected(){} // RVA: 0x7FFD54D7B5D0
    public void set_intensity_Injected(){} // RVA: 0x7FFD54D7B630
    public void get_intensityMultiplier_Injected(){} // RVA: 0x7FFD54D7B3B0
    public void set_intensityMultiplier_Injected(){} // RVA: 0x7FFD54D7B400
    public void get_maxLights_Injected(){} // RVA: 0x7FFD54D7B460
    public void set_maxLights_Injected(){} // RVA: 0x7FFD54D7B4B0
}

public class LimitVelocityOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D73B70
    public void set_enabled(){} // RVA: 0x7FFD54D73BC0
    public void get_limitX(){} // RVA: 0x7FFD54D73C20
    public void set_limitX(){} // RVA: 0x7FFD54D73C90
    public void get_limitXMultiplier(){} // RVA: 0x7FFD54D73CF0
    public void set_limitXMultiplier(){} // RVA: 0x7FFD54D73D40
    public void get_limitY(){} // RVA: 0x7FFD54D73DA0
    public void set_limitY(){} // RVA: 0x7FFD54D73E10
    public void get_limitYMultiplier(){} // RVA: 0x7FFD54D73E70
    public void set_limitYMultiplier(){} // RVA: 0x7FFD54D73EC0
    public void get_limitZ(){} // RVA: 0x7FFD54D73F20
    public void set_limitZ(){} // RVA: 0x7FFD54D73F90
    public void get_limitZMultiplier(){} // RVA: 0x7FFD54D73FF0
    public void set_limitZMultiplier(){} // RVA: 0x7FFD54D74040
    public void get_limit(){} // RVA: 0x7FFD54D740A0
    public void set_limit(){} // RVA: 0x7FFD54D74110
    public void get_limitMultiplier(){} // RVA: 0x7FFD54D74170
    public void set_limitMultiplier(){} // RVA: 0x7FFD54D741C0
    public void get_dampen(){} // RVA: 0x7FFD54D74220
    public void set_dampen(){} // RVA: 0x7FFD54D74270
    public void get_separateAxes(){} // RVA: 0x7FFD54D742D0
    public void set_separateAxes(){} // RVA: 0x7FFD54D74320
    public void get_space(){} // RVA: 0x7FFD54D74380
    public void set_space(){} // RVA: 0x7FFD54D743D0
    public void get_drag(){} // RVA: 0x7FFD54D74430
    public void set_drag(){} // RVA: 0x7FFD54D744A0
    public void get_dragMultiplier(){} // RVA: 0x7FFD54D74500
    public void set_dragMultiplier(){} // RVA: 0x7FFD54D74550
    public void get_multiplyDragByParticleSize(){} // RVA: 0x7FFD54D745B0
    public void set_multiplyDragByParticleSize(){} // RVA: 0x7FFD54D74600
    public void get_multiplyDragByParticleVelocity(){} // RVA: 0x7FFD54D74660
    public void set_multiplyDragByParticleVelocity(){} // RVA: 0x7FFD54D746B0
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D73B70
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D73BC0
    public void get_limitX_Injected(){} // RVA: 0x7FFD54D74710
    public void set_limitX_Injected(){} // RVA: 0x7FFD54D74770
    public void get_limitXMultiplier_Injected(){} // RVA: 0x7FFD54D73CF0
    public void set_limitXMultiplier_Injected(){} // RVA: 0x7FFD54D73D40
    public void get_limitY_Injected(){} // RVA: 0x7FFD54D747D0
    public void set_limitY_Injected(){} // RVA: 0x7FFD54D74830
    public void get_limitYMultiplier_Injected(){} // RVA: 0x7FFD54D73E70
    public void set_limitYMultiplier_Injected(){} // RVA: 0x7FFD54D73EC0
    public void get_limitZ_Injected(){} // RVA: 0x7FFD54D74890
    public void set_limitZ_Injected(){} // RVA: 0x7FFD54D748F0
    public void get_limitZMultiplier_Injected(){} // RVA: 0x7FFD54D73FF0
    public void set_limitZMultiplier_Injected(){} // RVA: 0x7FFD54D74040
    public void get_limit_Injected(){} // RVA: 0x7FFD54D74950
    public void set_limit_Injected(){} // RVA: 0x7FFD54D749B0
    public void get_limitMultiplier_Injected(){} // RVA: 0x7FFD54D74170
    public void set_limitMultiplier_Injected(){} // RVA: 0x7FFD54D741C0
    public void get_dampen_Injected(){} // RVA: 0x7FFD54D74220
    public void set_dampen_Injected(){} // RVA: 0x7FFD54D74270
    public void get_separateAxes_Injected(){} // RVA: 0x7FFD54D742D0
    public void set_separateAxes_Injected(){} // RVA: 0x7FFD54D74320
    public void get_space_Injected(){} // RVA: 0x7FFD54D74380
    public void set_space_Injected(){} // RVA: 0x7FFD54D743D0
    public void get_drag_Injected(){} // RVA: 0x7FFD54D74A10
    public void set_drag_Injected(){} // RVA: 0x7FFD54D74A70
    public void get_dragMultiplier_Injected(){} // RVA: 0x7FFD54D74500
    public void set_dragMultiplier_Injected(){} // RVA: 0x7FFD54D74550
    public void get_multiplyDragByParticleSize_Injected(){} // RVA: 0x7FFD54D745B0
    public void set_multiplyDragByParticleSize_Injected(){} // RVA: 0x7FFD54D74600
    public void get_multiplyDragByParticleVelocity_Injected(){} // RVA: 0x7FFD54D74660
    public void set_multiplyDragByParticleVelocity_Injected(){} // RVA: 0x7FFD54D746B0
}

public class LineSegment : ValueType
{
    public UnityEngine.Vector3 Point1; // 0x10
    public UnityEngine.Vector3 Point2; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E34ADF0
}

public class LinkImage : Object
{
    public string url; // 0x10
    public UnityEngine.Texture texture; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class Linked1CancellationTokenSource : CancellationTokenSource
{
    public System.Threading.CancellationTokenRegistration _reg1; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53ADEE00
    public void Dispose(){} // RVA: 0x7FFD53ADEF80
}

public class Linked2CancellationTokenSource : CancellationTokenSource
{
    public System.Threading.CancellationTokenRegistration _reg1; // 0x40
    public System.Threading.CancellationTokenRegistration _reg2; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53ADEFC0
    public void Dispose(){} // RVA: 0x7FFD53ADF230
}

public class LinkedNCancellationTokenSource : CancellationTokenSource
{
    public System.Action`1<object> s_linkedTokenCancelDelegate;
    public System.Threading.CancellationTokenRegistration[] _linkingRegistrations; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53ADF280
    public void Dispose(){} // RVA: 0x7FFD53ADF4B0
    public void .cctor(){} // RVA: 0x7FFD53ADF540
}

public class LinkedSlot : Object
{
    public LinkedSlot<int> Next; // 0x10
    public LinkedSlot<int> Previous; // 0x18
    public LinkedSlotVolatile<int>[] SlotArray; // 0x20
    public int Value; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
}

public class LinkedSlotVolatile : ValueType
{
    public LinkedSlot<int> Value; // 0x10
}

public class ListBuilder`1 : ValueType
{
    public System.Reflection.PropertyInfo[] Item; // 0x10
    public System.Reflection.PropertyInfo Count; // 0x18
    public int _count; // 0x20
    public int _capacity; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    public void ToArray(){} // RVA: 0x7FFD4E078E90
    public void CopyTo(){} // RVA: 0x7FFD4E097970
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void Add(){} // RVA: 0x7FFD4E2ADC40
}

public class ListDummy`1 : Object
{
    public T[] Items;
}

public class ListElementProperty : Property`2
{
    public int Index;

    // ── Methods ──
    public void get_Index(){} // RVA: 0x7FFD4E079960
    public void get_Name(){} // RVA: 0x7FFD4E078E90
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class ListIterator`1 : ValueType
{
    public bool Current;
    public System.Collections.Generic.List`1<T> list;
    public Enumerator<T> enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class ListOfTWrapper`1 : Object
{
    public System.Collections.Generic.IList`1<T> Count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class ListPoolImpl`1 : Object
{
    public VRC.Core.Pool.ObjectPool`1<System.Collections.Generic.List`1<VRC.SDKBase.INetworkID>> Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class ListQueryMatcher`1 : UQueryMatcher
{
    public System.Collections.Generic.List`1<T> matches;

    // ── Methods ──
    public void get_matches(){} // RVA: 0x7FFD4E078E90
    public void set_matches(){} // RVA: 0x7FFD4E090A40
    public void OnRuleMatchedElement(){}
    public void Reset(){} // RVA: 0x7FFD4E090980
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class ListWrapper`1 : ValueType
{
    public System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.IReadOnlyDictionary`2<string,object>> Count; // 0x10

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void get_Item(){}
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class LiteralList : ValueType
{
    public System.Collections.Generic.List`1<string> literals; // 0x10
    public System.IO.Hashing.XxHash3 xxhash; // 0xFFFF

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void GetHashCode(){} // RVA: 0x7FFD5750CCD0
    public void Equals(){} // RVA: 0x7FFD5750D110
}

public class LoadOptions : ValueType
{
    public 0x6650B148 StorageLocation; // 0x10
    public int MaxAnchorCount; // 0x14
    public double Timeout; // 0x18
    public System.Collections.Generic.IReadOnlyList`1<System.Guid> Uuids; // 0x20

    // ── Methods ──
    public void get_StorageLocation(){} // RVA: 0x7FFD4F840210
    public void set_StorageLocation(){} // RVA: 0x7FFD4E78D8B0
    public void get_MaxAnchorCount(){} // RVA: 0x7FFD4F8402A0
    public void set_MaxAnchorCount(){} // RVA: 0x7FFD4F840230
    public void get_Timeout(){} // RVA: 0x7FFD4FBF1AE0
    public void set_Timeout(){} // RVA: 0x7FFD4FED3ED0
    public void get_Uuids(){} // RVA: 0x7FFD4E35C380
    public void set_Uuids(){} // RVA: 0x7FFD4E342E30
    public void ToQueryOptions(){} // RVA: 0x7FFD53D4BBA0
}

public class LoadingInfoData : ScriptableObject
{
    public string _textureName; // 0x18
    public float weight; // 0x20
    public bool isAnnouncement; // 0x24
    public System.Collections.Generic.List`1<string> paragraphs; // 0x28
    public UnityEngine.Texture _loadedTexture; // 0x30

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFD4F6A4850
    public void CreateInstance(){} // RVA: 0x7FFD4F6A49F0
    public void GetHashCode(){} // RVA: 0x7FFD4F6A4C40
    public void CreateScriptableObject(){} // RVA: 0x7FFD4F6A4DE0
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFD4F6A4F80
    public void ToString(){} // RVA: 0x7FFD4F6A5120
    public void DoSlerp_Injected_4C0(){} // RVA: 0x7FFD4F6A5370
    public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    public void Initialize(){} // RVA: 0x7FFD4F6A55C0
}

public class LoadingInfoSet : ScriptableObject
{
    public System.Collections.Generic.List`1<LoadingInfoData> loadingInfos; // 0x18
    public LoadingInfoData announcementLoadingInfo; // 0x20
    public LoadingInfoData twoFactorAuthenticationLoadingInfo; // 0x28
    public LoadingInfoData communityLabsLoadingInfo; // 0x30
    public System.Collections.Generic.List`1<int> loadingInfoCyclesBeforeRepeat; // 0x38
    public int cyclesBeforeRepeat;
    public bool displayCommunityLabsInfo; // 0x40
    public System.Collections.Generic.List`1<UnityEngine.UI.Text> texts; // 0x48
    public System.Collections.Generic.List`1<string> announcementsSeen;
    public LoadingInfoData _currentLoadingInfoData; // 0x50

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFD4F6A6D40
    public void CreateInstance(){} // RVA: 0x7FFD4F6A75B0
    public void Awake(){} // RVA: 0x7FFD4F6A7840
    public void OnDestroy(){} // RVA: 0x7FFD4F6A79D0
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFD4F6A7A00
    public void GetHashCode(){} // RVA: 0x7FFD4F6A7B70
    public void ToString(){} // RVA: 0x7FFD4F6A7FF0
    public void ComputeMaterial(){} // RVA: 0x7FFD4F6A86A0
    public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    public void Initialize(){} // RVA: 0x7FFD4F6A88E0
    public void OnDisable_impl(){} // RVA: 0x7FFD4F6A8B60
    public void ProcessLoadingInformation(){} // RVA: 0x7FFD4F6A8BE0
    public void InitializeLoadingContext(){} // RVA: 0x7FFD4F6A8FF0
    public void CreateLoadingContext(){} // RVA: 0x7FFD4F6A9860
    public void ConfiguremainTexture(){} // RVA: 0x7FFD4F6A99D0
    public void Initialize_482C69232443(){} // RVA: 0x7FFD4F6A9C10
    public void Initialize_532BBB6E7A4E(){} // RVA: 0x7FFD4F6A9DA0
    public void GetOrProcessLoadingInfo(){} // RVA: 0x7FFD4F6A9FA0
    public void VRCSetAvatarMainIK(){} // RVA: 0x7FFD4E3FCC10
}

public class LocalMinima : Object
{
    public long Y; // 0x10
    public TEdge LeftBound; // 0x18
    public TEdge RightBound; // 0x20
    public LocalMinima Next; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class LockedStack : Object
{
    public 0x665C6FB8<Transmtn.DTO.Notifications.Notification>[][] _arrays; // 0x10
    public int _count; // 0x18
    public uint _firstStackItemMS; // 0x1C

    // ── Methods ──
    public void TryPush(){} // RVA: 0x7FFD4E079F60
    public void TryPop(){} // RVA: 0x7FFD4E078E90
    public void Trim(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class LogCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C75000
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
}

public class LogValues`1 : ValueType
{
    public System.Func`3<LogValues`1<T>,System.Exception,string> Item;
    public Microsoft.Extensions.Logging.LogValuesFormatter Count;
    public T _value0;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Item(){}
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void ToString(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class LogValues`2 : ValueType
{
    public System.Func`3<LogValues`2<U,T>,System.Exception,string> Item;
    public Microsoft.Extensions.Logging.LogValuesFormatter Count;
    public U _value0;
    public T _value1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Item(){}
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void ToString(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class LogValues`3 : ValueType
{
    public System.Func`3<LogValues`3<U,V,T>,System.Exception,string> Count;
    public Microsoft.Extensions.Logging.LogValuesFormatter Item;
    public U _value0;
    public V _value1;
    public T _value2;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void get_Item(){}
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void ToString(){} // RVA: 0x7FFD4E078E90
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class LogValues`4 : ValueType
{
    public System.Func`3<LogValues`4<U,V,W,T>,System.Exception,string> Count;
    public Microsoft.Extensions.Logging.LogValuesFormatter Item;
    public U _value0;
    public V _value1;
    public W _value2;
    public T _value3;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void get_Item(){}
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void ToArray(){} // RVA: 0x7FFD4E078E90
    public void ToString(){} // RVA: 0x7FFD4E078E90
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class LogValues`5 : ValueType
{
    public System.Func`3<LogValues`5<U,V,W,T4,T>,System.Exception,string> Count;
    public Microsoft.Extensions.Logging.LogValuesFormatter Item;
    public U _value0;
    public V _value1;
    public W _value2;
    public T4 _value3;
    public T _value4;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void get_Item(){}
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void ToArray(){} // RVA: 0x7FFD4E078E90
    public void ToString(){} // RVA: 0x7FFD4E078E90
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class LogValues`6 : ValueType
{
    public System.Func`3<LogValues`6<U,V,W,T4,T5,T>,System.Exception,string> Count;
    public Microsoft.Extensions.Logging.LogValuesFormatter Item;
    public U _value0;
    public V _value1;
    public W _value2;
    public T4 _value3;
    public T5 _value4;
    public T _value5;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void get_Item(){}
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void ToArray(){} // RVA: 0x7FFD4E078E90
    public void ToString(){} // RVA: 0x7FFD4E078E90
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class LoggerDebugView : Object
{
}

public class LoggerFactoryDebugView : Object
{
}

public class Lookup`2 : Object
{
    public Lookup`2<U,T> Item;
    public System.Collections.Generic.Dictionary`2<U,Grouping`2<U,T>> Count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void CreateEmpty(){} // RVA: 0x7FFD4E078A90
    public void Create(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void CreateAsync(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
    public void get_Item(){} // RVA: 0x7FFD4E2ADC40
    public void get_Count(){} // RVA: 0x7FFD4E079960
    public void Contains(){} // RVA: 0x7FFD4E2ADC40
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class LowMemoryCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class LowerCaseMapping : ValueType
{
    public char ChMin; // 0x10
    public char ChMax; // 0x12
    public int LcOp; // 0x14
    public int Data; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD547C89D0
}
