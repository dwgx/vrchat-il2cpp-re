// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 407

public class PCMReaderCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class PCMSetPositionCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811EC370
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class PackageEntry : ValueType
{
    public string _packageId; // 0x10
    public string _packageVersion; // 0x18

    // ── Methods ──
    public void get_packageId(){} // RVA: 0x7FFE8284EF60
    public void set_packageId(){} // RVA: 0x7FFE81D7E9E0
    public void get_packageVersion(){} // RVA: 0x7FFE826F4210
    public void set_packageVersion(){} // RVA: 0x7FFE826F4230
    public void ToJObject(){} // RVA: 0x7FFE8A392CE0
}

public class PacketsCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class Page : ValueType
{
}

public class PagedGroupResult : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Pair : ValueType
{
}

public class PairIterator : ValueType
{
    public int _index;
    public Photon.Client.NonAllocDictionary`2<U,T> _dict;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Reset(){} // RVA: 0x7FFE80E45FE0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class PanicFunction_ : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class PanoSpec : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ParallelForJobStruct`1 : ValueType
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFE80E46010
    public void Execute(){} // RVA: 0x7FFE80E4EE20
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class ParallelWriter : ValueType
{
}

public class ParamInfo : Object
{
    public 0x6655F2B4 _ftype; // 0x10
    public int _minargs; // 0x14
    public int _maxargs; // 0x18
    public 0x665569E4[] _argTypes; // 0x20

    // ── Methods ──
    public void get_FType(){} // RVA: 0x7FFE811485C0
    public void get_Minargs(){} // RVA: 0x7FFE8164B230
    public void get_Maxargs(){} // RVA: 0x7FFE813DB630
    public void get_ArgTypes(){} // RVA: 0x7FFE811290C0
    public void .ctor(){} // RVA: 0x7FFE8754FC90
}

public class Parameter : Object
{
    public string name; // 0x10

    // ── Methods ──
    public void get_hash(){} // RVA: 0x7FFE8A47A780
    public void IsNull(){} // RVA: 0x7FFE8A47A7F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ParameterBox : InitializeLocalInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FE0C0
    public void Run(){} // RVA: 0x7FFE87185510
    public void get_InstructionName(){} // RVA: 0x7FFE87185640
}

public class ParameterConfig : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFE81E84B20
    public void GetDefaultAddressFor(){} // RVA: 0x7FFE81E84F60
    public void .ctor(){} // RVA: 0x7FFE81E84FE0
}

public class ParameterEnumerable : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE878DA410
    public void GetEnumerator(){} // RVA: 0x7FFE878DA520
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator(){} // RVA: 0x7FFE878DA650
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE878DA720
}

public class ParameterEnumerator : ValueType
{
    public UnityEngine.InputSystem.InputActionState m_State; // 0x10
    public int m_MapIndex; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE878DA7F0
    public void MoveToNextBinding(){} // RVA: 0x7FFE878DABC0
    public void MoveToNextInteraction(){} // RVA: 0x7FFE878DADE0
    public void MoveToNextProcessor(){} // RVA: 0x7FFE878DAE50
    public void FindParameter(){} // RVA: 0x7FFE878DAEC0
    public void MoveNext(){} // RVA: 0x7FFE878DB070
    public void Reset(){} // RVA: 0x7FFE878DB1F0
    public void get_Current(){} // RVA: 0x7FFE878DB360
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE878DB440
    public void Dispose(){} // RVA: 0x7FFE810FB310
}

public class ParameterExpressionProxy : Object
{
    public System.Linq.Expressions.ParameterExpression _node; // 0x10
    public object field_1; // 0x110
    public object field_2; // 0x111
    public object field_3; // 0x112
    public object field_4; // 0x113
    public object field_5; // 0x114

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8711A6D0
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_IsByRef(){} // RVA: 0x7FFE86853DF0
    public void get_Name(){} // RVA: 0x7FFE8189BB90
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class ParameterLookupKey : Object
{
    public string _name; // 0x10
    public System.Type _type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void get_Name(){} // RVA: 0x7FFE81116380
    public void get_Type(){} // RVA: 0x7FFE810FE7C0
    public void GetHashCode(){} // RVA: 0x7FFE86EA0DF0
    public void Equals(){} // RVA: 0x7FFE86EA0EA0
}

public class ParameterLookupValue : Object
{
    public string _duplicateName; // 0x10
    public System.Text.Json.Serialization.Metadata.JsonPropertyInfo _jsonPropertyInfo; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81161E80
    public void get_DuplicateName(){} // RVA: 0x7FFE81116380
    public void set_DuplicateName(){} // RVA: 0x7FFE810FCE30
    public void get_JsonPropertyInfo(){} // RVA: 0x7FFE810FE7C0
}

public class ParameterOverride : ValueType
{
    public string objectRegistrationName; // 0x10

    // ── Methods ──
    public void get_objectType(){} // RVA: 0x7FFE878DB4B0
    public void .ctor(){} // RVA: 0x7FFE878DB7F0 | overloaded x2
    public void Find(){} // RVA: 0x7FFE878DBC80 | overloaded x2
    public void PickMoreSpecificOne(){} // RVA: 0x7FFE878DC190
}

public class ParameterizedConstructorDelegate`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class ParentClipScope : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87CBE8E0
    public void Dispose(){} // RVA: 0x7FFE87CBE990
}

public class ParentHash : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8164E250
}

public class ParseElementOnlyContent_LocalFrame : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE875BB670
}

public class ParsedPathComponent : ValueType
{
    public UnityEngine.InputSystem.Utilities.Substring m_Layout; // 0x10
    public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.Substring> m_Usages; // 0x20
    public UnityEngine.InputSystem.Utilities.Substring m_Name; // 0x40
    public UnityEngine.InputSystem.Utilities.Substring m_DisplayName; // 0x50
    public string m_String; // 0x10
    public int m_Index; // 0x18

    // ── Methods ──
    public void get_layout(){} // RVA: 0x7FFE87935B10
    public void get_usages(){} // RVA: 0x7FFE87935B70
    public void get_name(){} // RVA: 0x7FFE87935D20
    public void get_displayName(){} // RVA: 0x7FFE87935D80
    public void get_isWildcard(){} // RVA: 0x7FFE87935DE0
    public void get_isDoubleWildcard(){} // RVA: 0x7FFE87935F00
    public void ToHumanReadableString(){} // RVA: 0x7FFE879371D0 | overloaded x2
    public void Matches(){} // RVA: 0x7FFE87937260
    public void ComparePathElementToString(){} // RVA: 0x7FFE87937780
}

public class Parser : Object
{
    public System.IO.StringReader json; // 0x10
    public object `/00; // 0x1
    public object `/00; // 0x2
    public object `/00; // 0x3

    // ── Methods ──
    public void IsWordBreak(){} // RVA: 0x7FFE86D91E70
    public void .ctor(){} // RVA: 0x7FFE86D91F10
    public void Parse(){} // RVA: 0x7FFE86D91FD0
    public void Dispose(){} // RVA: 0x7FFE86D92150
    public void ParseObject(){} // RVA: 0x7FFE86D921D0
    public void ParseArray(){} // RVA: 0x7FFE86D92360
    public void ParseValue(){} // RVA: 0x7FFE86D92450
    public void ParseByToken(){} // RVA: 0x7FFE86D92480
    public void ParseString(){} // RVA: 0x7FFE86D92870
    public void ParseNumber(){} // RVA: 0x7FFE86D92B70
    public void EatWhitespace(){} // RVA: 0x7FFE86D92E60
    public void get_PeekChar(){} // RVA: 0x7FFE86D92F10
    public void get_NextChar(){} // RVA: 0x7FFE86D92FC0
    public void get_NextWord(){} // RVA: 0x7FFE86D93070
    public void get_NextToken(){} // RVA: 0x7FFE86D931C0
}

public class ParsingState : ValueType
{
    public char[] chars; // 0x10
    public int charPos; // 0x18

    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFE87566BB0
    public void Close(){} // RVA: 0x7FFE87566EA0
    public void get_LineNo(){} // RVA: 0x7FFE8119C0C0
    public void get_LinePos(){} // RVA: 0x7FFE87566F00
}

public class PartBinding : ValueType
{
    public int _part; // 0x10
    public UnityEngine.InputSystem.InputControl _control; // 0x18

    // ── Methods ──
    public void get_part(){} // RVA: 0x7FFE826F4220
    public void set_part(){} // RVA: 0x7FFE815BF990
    public void get_control(){} // RVA: 0x7FFE826F4210
    public void set_control(){} // RVA: 0x7FFE826F4230
}

public class PartialStateForRollback : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86E67620
    public void GetStartPosition(){} // RVA: 0x7FFE86E67690
}

public class Particle : ValueType
{
    public UnityEngine.Vector3 m_Position; // 0x10
    public UnityEngine.Vector3 m_Velocity; // 0x1C
    public UnityEngine.Vector3 m_AnimatedVelocity; // 0x28
    public UnityEngine.Vector3 m_InitialVelocity; // 0x34
    public UnityEngine.Vector3 m_AxisOfRotation; // 0x40
    public UnityEngine.Vector3 m_Rotation; // 0x4C
    public UnityEngine.Vector3 m_AngularVelocity; // 0x58
    public UnityEngine.Vector3 m_StartSize; // 0x64
    public UnityEngine.Color32 m_StartColor; // 0x70
    public uint m_RandomSeed; // 0x74
    public uint m_ParentRandomSeed; // 0x78
    public float m_Lifetime; // 0x7C
    public float m_StartLifetime; // 0x80
    public int m_MeshIndex; // 0x84
    public float m_EmitAccumulator0; // 0x88
    public float m_EmitAccumulator1; // 0x8C

    // ── Methods ──
    public void set_lifetime(){} // RVA: 0x7FFE81124090
    public void get_position(){} // RVA: 0x7FFE87BBA310
    public void set_position(){} // RVA: 0x7FFE835C1F00
    public void get_velocity(){} // RVA: 0x7FFE87BBA330
    public void set_velocity(){} // RVA: 0x7FFE87BBA350
    public void get_animatedVelocity(){} // RVA: 0x7FFE87BD9260
    public void get_totalVelocity(){} // RVA: 0x7FFE87CF8B70
    public void get_remainingLifetime(){} // RVA: 0x7FFE87CF8BB0
    public void set_remainingLifetime(){} // RVA: 0x7FFE81124090
    public void get_startLifetime(){} // RVA: 0x7FFE87CF8BC0
    public void set_startLifetime(){} // RVA: 0x7FFE811240B0
    public void get_startColor(){} // RVA: 0x7FFE87CF8BD0
    public void set_startColor(){} // RVA: 0x7FFE8139E520
    public void get_randomSeed(){} // RVA: 0x7FFE87CF8BE0
    public void set_randomSeed(){} // RVA: 0x7FFE829DF320
    public void get_axisOfRotation(){} // RVA: 0x7FFE87CF8BF0
    public void set_axisOfRotation(){} // RVA: 0x7FFE818C13F0
    public void get_startSize(){} // RVA: 0x7FFE87CF8C10
    public void set_startSize(){} // RVA: 0x7FFE87CF8C20
    public void get_startSize3D(){} // RVA: 0x7FFE87CF8C40
    public void set_startSize3D(){} // RVA: 0x7FFE87CF8C60
    public void get_rotation(){} // RVA: 0x7FFE87CF8C80
    public void set_rotation(){} // RVA: 0x7FFE87CF8C90
    public void get_rotation3D(){} // RVA: 0x7FFE87CF8CB0
    public void set_rotation3D(){} // RVA: 0x7FFE87CF8CF0
    public void get_angularVelocity(){} // RVA: 0x7FFE87CF8D30
    public void set_angularVelocity(){} // RVA: 0x7FFE87CF8D40
    public void get_angularVelocity3D(){} // RVA: 0x7FFE87CF8D60
    public void set_angularVelocity3D(){} // RVA: 0x7FFE87CF8DA0
    public void GetCurrentSize(){} // RVA: 0x7FFE87CF8DE0
    public void GetCurrentSize3D(){} // RVA: 0x7FFE87CF8E50
    public void GetCurrentColor(){} // RVA: 0x7FFE87CF8EF0
    public void SetMeshIndex(){} // RVA: 0x7FFE87CF8F70
    public void GetMeshIndex(){} // RVA: 0x7FFE87CF8F80
}

public class ParticleSystemBeginUpdateAll : ValueType
{
}

public class ParticleSystemEndUpdateAll : ValueType
{
}

public class PassthroughCapabilities : Object
{
    public bool _supportsPassthrough; // 0x10
    public bool _supportsColorPassthrough; // 0x11

    // ── Methods ──
    public void get_SupportsPassthrough(){} // RVA: 0x7FFE811C55E0
    public void get_SupportsColorPassthrough(){} // RVA: 0x7FFE81346E30
    public void .ctor(){} // RVA: 0x7FFE8673B370
}

public class PassthroughMeshInstance : ValueType
{
}

public class PathListComparer : Object
{
    // ── Methods ──
    public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFE8767C4D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE8767C740
}

public class PathParser : ValueType
{
    public string path; // 0x10

    // ── Methods ──
    public void get_isAtEnd(){} // RVA: 0x7FFE87937A40
    public void .ctor(){} // RVA: 0x7FFE87937A50
    public void MoveToNextComponent(){} // RVA: 0x7FFE87937AE0
    public void ParseComponentPart(){} // RVA: 0x7FFE87938240
}

public class PathResolver : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8526B7D0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class PayloadBuffer : MemoryStream
{
    // ── Methods ──
    public void ToTruncatedByteArray(){} // RVA: 0x7FFE89F91000
    public void .ctor(){} // RVA: 0x7FFE89F83F50
}

public class PcgRandom : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87C0C160
    public void GetUInt(){} // RVA: 0x7FFE87C0C190
    public void RotateRight(){} // RVA: 0x7FFE867D9B10
    public void XshRr(){} // RVA: 0x7FFE87C0C1E0
    public void Step(){} // RVA: 0x7FFE87C0C210
}

public class Pelvis : Object
{
    public UnityEngine.Vector3 _iKOffset; // 0x10
    public float _heightOffset; // 0x1C

    // ── Methods ──
    public void get_IKOffset(){} // RVA: 0x7FFE811188D0
    public void set_IKOffset(){} // RVA: 0x7FFE811188F0
    public void get_heightOffset(){} // RVA: 0x7FFE811C8570
    public void set_heightOffset(){} // RVA: 0x7FFE811C8580
    public void Initiate(){} // RVA: 0x7FFE811C8590
    public void Reset(){} // RVA: 0x7FFE811C8710
    public void OnEnable(){} // RVA: 0x7FFE811C8890
    public void Process(){} // RVA: 0x7FFE811C89D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class PerCoreLockedStacks : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void TryPush(){} // RVA: 0x7FFE80E460A0
    public void TryPop(){} // RVA: 0x7FFE80E2E2E0
    public void Trim(){} // RVA: 0x7FFE810A1420
}

public class PerTypeValues`1 : Object
{
    // ── Methods ──
    public void MeasureArrayAdjustment(){} // RVA: 0x7FFE80E2DEE0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class PerfMetrics : Object
{
    // ── Methods ──
    public void ToJSON(){} // RVA: 0x7FFE86D08D80
    public void LoadFromJSON(){} // RVA: 0x7FFE86D09450
    public void .ctor(){} // RVA: 0x7FFE86D09FB0
}

public class PerformanceAnalyticsUpdate : ValueType
{
}

public class PermissionFilter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8270E0E0 | overloaded x3
    public void IsAllowed(){} // RVA: 0x7FFE88205180 | overloaded x2
}

public class PersonalMirrorIcons : ValueType
{
}

public class Perspective : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class PerspectiveDataBuffer : SyncedStructuredBuffer`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BB7F30
}

public class PhotoCaptureResult : ValueType
{
}

public class PhraseRecognizedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84261750
    public void Invoke(){} // RVA: 0x7FFE8400B040
}

public class PhysBoneJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE881F4730
    public void InitializeChain(){} // RVA: 0x7FFE881F5FE0
    public void SolveAnimation(){} // RVA: 0x7FFE881F67D0
    public void SolveChain(){} // RVA: 0x7FFE881F71F0
    public void UpdateColliders(){} // RVA: 0x7FFE881FA180
    public void LerpColliders(){} // RVA: 0x7FFE881FA8D0
    public void SolveCollisions(){} // RVA: 0x7FFE881FAB20
    public void ApplyAngleLimits(){} // RVA: 0x7FFE881FB7A0
    public void ClampGlobalBoneLength(){} // RVA: 0x7FFE881FC260
    public void SolveGrabIK(){} // RVA: 0x7FFE881FC430
}

public class PhysBoneStats : ValueType
{
}

public class Physics : Object
{
    // ── Methods ──
    public void SetOrientationOnPath(){} // RVA: 0x7FFE82C1C900
    public void HasRigidbody2D(){} // RVA: 0x7FFE82C1CAA0
    public void HasRigidbody(){} // RVA: 0x7FFE82C1CBA0
    public void CreateDOTweenPathTween(){} // RVA: 0x7FFE82C1CCA0
}

public class Physics2DEarlyUpdate : ValueType
{
}

public class Physics2DFixedUpdate : ValueType
{
}

public class Physics2DLateUpdate : ValueType
{
}

public class Physics2DUpdate : ValueType
{
}

public class PhysicsClothFixedUpdate : ValueType
{
}

public class PhysicsClothUpdate : ValueType
{
}

public class PhysicsFixedUpdate : ValueType
{
}

public class PhysicsLateUpdate : ValueType
{
}

public class PhysicsResetInterpolatedTransformPosition : ValueType
{
}

public class PhysicsSkinnedClothBeginUpdate : ValueType
{
}

public class PhysicsSkinnedClothFinishUpdate : ValueType
{
}

public class PhysicsUpdate : ValueType
{
}

public class Pico : ApiModel
{
    public string _sku; // 0x68
    public string _user_id; // 0x70
    public string _subscription_start_time; // 0x78
    public int _subscription_end_time; // 0x80
    public int _subscription_type; // 0x84
    public int _status; // 0x88
    public bool _free_trial; // 0x8C
    public string _next_period; // 0x90

    // ── Methods ──
    public void get_sku(){} // RVA: 0x7FFE81176D50
    public void set_sku(){} // RVA: 0x7FFE81176D60
    public void get_user_id(){} // RVA: 0x7FFE811C3590
    public void set_user_id(){} // RVA: 0x7FFE811C35A0
    public void get_subscription_start_time(){} // RVA: 0x7FFE81463AE0
    public void set_subscription_start_time(){} // RVA: 0x7FFE81464570
    public void get_subscription_end_time(){} // RVA: 0x7FFE81D30560
    public void set_subscription_end_time(){} // RVA: 0x7FFE81D307B0
    public void get_subscription_type(){} // RVA: 0x7FFE829DF2E0
    public void set_subscription_type(){} // RVA: 0x7FFE829DF3B0
    public void get_status(){} // RVA: 0x7FFE8194AD00
    public void set_status(){} // RVA: 0x7FFE8194A400
    public void get_free_trial(){} // RVA: 0x7FFE81163520
    public void set_free_trial(){} // RVA: 0x7FFE81163530
    public void get_next_period(){} // RVA: 0x7FFE8154EB60
    public void set_next_period(){} // RVA: 0x7FFE818CE320
    public void .ctor(){} // RVA: 0x7FFE8A350110
}

public class PictureManager : Object
{
    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFE810FB310
    public void Equals(){} // RVA: 0x7FFE8255FBB0
    public void GetHashCode(){} // RVA: 0x7FFE8255FE80
    public void op_Implicit(){} // RVA: 0x7FFE82560280
    public void CompareBaseObjects(){} // RVA: 0x7FFE825604D0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFE82560890
    public void GetCachedPtr(){} // RVA: 0x7FFE82560AE0
    public void get_name(){} // RVA: 0x7FFE82560C60
    public void set_name(){} // RVA: 0x7FFE82560D30
    public void Instantiate(){} // RVA: 0x7FFE82560E10
    public void ToString(){} // RVA: 0x7FFE82560F90
    public void Initialize(){} // RVA: 0x7FFE825610D0
    public void GetOrCreateImage(){} // RVA: 0x7FFE825611A0
    public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFE82561480
    public void ProcessPictureManagerData(){} // RVA: 0x7FFE82561690
    public void GetLongFromDelegate(){} // RVA: 0x7FFE82561770
    public void GetBooleanFromDelegate(){} // RVA: 0x7FFE82561A40
    public void Initialize_5947DD5DEA10(){} // RVA: 0x7FFE82561AE0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Destroy(){} // RVA: 0x7FFE82561DA0
    public void GetOrInitializePictureData(){} // RVA: 0x7FFE82561EE0
}

public class PinchData : ValueType
{
}

public class PinnedArray`1 : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void op_Implicit(){} // RVA: 0x7FFE810A1420
}

public class PinnedBlob : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A539F0
    public void GetMemoryBlock(){} // RVA: 0x7FFE86E23730
}

public class PipelineEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AF3A20 | overloaded x2
    public void HasFlag(){} // RVA: 0x7FFE87813C90
}

public class PipelineSaver : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class Plane : ValueType
{
    // ── Methods ──
    public void ClosestPoint(){} // RVA: 0x7FFE881AB530
}

public class PlatformAsset : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class PlatformOptions : Object
{
    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFE82A2A890
    public void GetKeyServerAuthToken(){} // RVA: 0x7FFE81D29350
    public void GetOverrideDecryptionKey(){} // RVA: 0x7FFE82A2A930
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFE810FB320
    public void .ctor(){} // RVA: 0x7FFE82A2A950
}

public class PlaybackState : ValueType
{
}

public class PlayerActions : ValueType
{
    public UnityEngine.InputSystem.DefaultInputActions m_Wrapper; // 0x10
    public object field_1; // 0x2E0
    public object field_2; // 0x2E1
    public object field_3; // 0x2E2

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_Move(){} // RVA: 0x7FFE81D7EA40
    public void get_Look(){} // RVA: 0x7FFE81D7EAC0
    public void get_Fire(){} // RVA: 0x7FFE81D83F40
    public void Get(){} // RVA: 0x7FFE81D7EA60
    public void Enable(){} // RVA: 0x7FFE81D7E8C0
    public void Disable(){} // RVA: 0x7FFE81D7EAE0
    public void get_enabled(){} // RVA: 0x7FFE81D7E7D0
    public void op_Implicit(){} // RVA: 0x7FFE81D7E800
    public void SetCallbacks(){} // RVA: 0x7FFE879CA330
}

public class PlayerBucketRestoredDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE881904E0
    public void Invoke(){} // RVA: 0x7FFE81998A70
    public void BeginInvoke(){} // RVA: 0x7FFE881905B0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class PlayerCleanupCachedData : ValueType
{
}

public class PlayerEmitCanvasGeometry : ValueType
{
}

public class PlayerInstance : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class PlayerJoinedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE879DA980
}

public class PlayerLeftEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE879DA9C0
}

public class PlayerModComponentHealth : NetworkReadyHandler_FB37
{
    public float f_942; // 0x58
    public float f_F6A; // 0x5C
    public ÍÎÏÎÎÏÏÌÌÎÏÍÌÍÌÏÌÍÍÏÍÍÍ f_772; // 0x60

    // ── Methods ──
    public void ResetHealthRPC(){} // RVA: 0x7FFE8218AE70
    public void OnDestroy(){} // RVA: 0x7FFE8218AFE0
    public void OnApplicationPause(){} // RVA: 0x7FFE813A7540
    public void SetProperties(){} // RVA: 0x7FFE8218B030
    public void OnBecameVisible(){} // RVA: 0x7FFE8218B4D0
    public void .ctor(){} // RVA: 0x7FFE8218B660
    public void Initialize(){} // RVA: 0x7FFE8218B6E0
    public void OnCollisionStay(){} // RVA: 0x7FFE817BF630
    public void Start(){} // RVA: 0x7FFE8218B700
    public void ShowDeath(){} // RVA: 0x7FFE8218B7A0
    public void OnTriggerStay(){} // RVA: 0x7FFE8218BA20
    public void OnTriggerExit(){} // RVA: 0x7FFE8218BAC0
    public void Heal(){} // RVA: 0x7FFE8218BC80
    public void TakeDamage(){} // RVA: 0x7FFE8218BF20
    public void Heal_DBD97727D5BF(){} // RVA: 0x7FFE8218C0D0
    public void OnApplicationQuit(){} // RVA: 0x7FFE8218C350
    public void GetHealth(){} // RVA: 0x7FFE8218C750
    public void OnBecameInvisible(){} // RVA: 0x7FFE8218C910
    public void OnCollisionEnter(){} // RVA: 0x7FFE8218C930
    public void SetHealth(){} // RVA: 0x7FFE8218C980
    public void GetHealth_7D1DBE8DB0AE(){} // RVA: 0x7FFE810FB320
    public void RemoveHealthRPC(){} // RVA: 0x7FFE8218CA20
    public void OnDeath(){} // RVA: 0x7FFE8218CC70
    public void Respawn(){} // RVA: 0x7FFE8218CDE0
    public void AddHealthRPC(){} // RVA: 0x7FFE8218D5B0
    public void Awake(){} // RVA: 0x7FFE8218D910
    public void OnEnable(){} // RVA: 0x7FFE8218AFE0
    // ── Unresolved (hash) ──
    public void m_E9D(){} // RVA: 0x7FFE8218CF90
    public void m_DD2(){} // RVA: 0x7FFE8218D740
    public void m_267(){} // RVA: 0x7FFE8218D870
}

public class PlayerModComponentJump : MonoBehaviour
{
    // ── Methods ──
    public void OnDestroy(){} // RVA: 0x7FFE821915B0
    public void .ctor(){} // RVA: 0x7FFE810FBD50
    public void Initialize(){} // RVA: 0x7FFE821915C0
    public void CancelInvoke(){} // RVA: 0x7FFE821916C0
    public void Start(){} // RVA: 0x7FFE821917C0
    public void InvokeRepeating(){} // RVA: 0x7FFE821915B0
    public void OnCollisionStay(){} // RVA: 0x7FFE821919B0
    public void IsInvoking(){} // RVA: 0x7FFE821915B0
    public void StartCoroutine(){} // RVA: 0x7FFE82191CE0
    public void OnTriggerStay(){} // RVA: 0x7FFE82191FB0
    public void SetProperties(){} // RVA: 0x7FFE821920B0
    public void StartCoroutine_Auto(){} // RVA: 0x7FFE821923E0
}

public class PlayerModComponentSpeed : MonoBehaviour
{
    // ── Methods ──
    public void OnDestroy(){} // RVA: 0x7FFE82192510
    public void RaiseCancellation(){} // RVA: 0x7FFE82192670
    public void SetProperties(){} // RVA: 0x7FFE821927D0
    public void CancelInvoke(){} // RVA: 0x7FFE82192C70
    public void Invoke(){} // RVA: 0x7FFE82192DC0
    public void Start(){} // RVA: 0x7FFE82192F10
    public void Update(){} // RVA: 0x7FFE82192510
    public void .ctor(){} // RVA: 0x7FFE810FBD50
    public void Initialize(){} // RVA: 0x7FFE82193100
    public void StartCoroutine(){} // RVA: 0x7FFE82192670
    public void OnTriggerExit(){} // RVA: 0x7FFE82193250
    public void StartCoroutine_Auto(){} // RVA: 0x7FFE821933B0
}

public class PlayerRenderUIEBatchModeOffscreen : ValueType
{
}

public class PlayerSendFrameComplete : ValueType
{
}

public class PlayerSendFramePostPresent : ValueType
{
}

public class PlayerSendFrameStarted : ValueType
{
}

public class PlayerStorageIdDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8400E430
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE88190840
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class PlayerUpdateCanvases : ValueType
{
}

public class Point : Object
{
    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFE81E15540
    public void get_name(){} // RVA: 0x7FFE81E15690 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE81E15540
    public void op_Implicit(){} // RVA: 0x7FFE81E15570
    public void CompareBaseObjects(){} // RVA: 0x7FFE81E155D0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFE81E15540
    public void GetCachedPtr(){} // RVA: 0x7FFE81E15630
    public void .ctor(){} // RVA: 0x7FFE81E156F0
    public void Initialize(){} // RVA: 0x7FFE81E15540
}

public class PointAccum : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A438470
}

public class PointExt : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A438750
}

public class PointPrecomp : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A4389B0
}

public class PointerEvent : Object
{
    public int _pointerId; // 0x10
    public string _pointerType; // 0x18
    public bool _isPrimary; // 0x20
    public int _button; // 0x24
    public int _pressedButtons; // 0x28
    public UnityEngine.Vector3 _position; // 0x2C
    public UnityEngine.Vector3 _localPosition; // 0x38
    public UnityEngine.Vector3 _deltaPosition; // 0x44
    public float _deltaTime; // 0x50
    public int _clickCount; // 0x54
    public float _pressure; // 0x58
    public float _tangentialPressure; // 0x5C
    public float _altitudeAngle; // 0x60
    public float _azimuthAngle; // 0x64
    public float _twist; // 0x68
    public UnityEngine.Vector2 _tilt; // 0x6C
    public 0x666D362C _penStatus; // 0x74
    public UnityEngine.Vector2 _radius; // 0x78
    public UnityEngine.Vector2 _radiusVariance; // 0x80
    public 0x66679374 _modifiers; // 0x88
    public object field_20; // 0x16E
    public object field_21; // 0x16F
    public object field_22; // 0x170
    public object field_23; // 0x171
    public object field_24; // 0x172

    // ── Methods ──
    public void get_pointerId(){} // RVA: 0x7FFE811485C0
    public void set_pointerId(){} // RVA: 0x7FFE810FE0C0
    public void get_pointerType(){} // RVA: 0x7FFE810FE7C0
    public void set_pointerType(){} // RVA: 0x7FFE81161E80
    public void get_isPrimary(){} // RVA: 0x7FFE811E99D0
    public void set_isPrimary(){} // RVA: 0x7FFE811E99E0
    public void get_button(){} // RVA: 0x7FFE81A56130
    public void set_button(){} // RVA: 0x7FFE82447980
    public void get_pressedButtons(){} // RVA: 0x7FFE81549710
    public void set_pressedButtons(){} // RVA: 0x7FFE817E4800
    public void get_position(){} // RVA: 0x7FFE81161F10
    public void set_position(){} // RVA: 0x7FFE81161F30
    public void get_localPosition(){} // RVA: 0x7FFE81161F40
    public void set_localPosition(){} // RVA: 0x7FFE81161F60
    public void get_deltaPosition(){} // RVA: 0x7FFE81161F70
    public void set_deltaPosition(){} // RVA: 0x7FFE81161F90
    public void get_deltaTime(){} // RVA: 0x7FFE81163460
    public void set_deltaTime(){} // RVA: 0x7FFE81163470
    public void get_clickCount(){} // RVA: 0x7FFE819EA920
    public void set_clickCount(){} // RVA: 0x7FFE819EA900
    public void get_pressure(){} // RVA: 0x7FFE81123FE0
    public void set_pressure(){} // RVA: 0x7FFE81123FF0
    public void get_tangentialPressure(){} // RVA: 0x7FFE81124000
    public void set_tangentialPressure(){} // RVA: 0x7FFE81124010
    public void get_altitudeAngle(){} // RVA: 0x7FFE8120BE10
    public void set_altitudeAngle(){} // RVA: 0x7FFE81D5D9B0
    public void get_azimuthAngle(){} // RVA: 0x7FFE81124040
    public void set_azimuthAngle(){} // RVA: 0x7FFE81124050
    public void get_twist(){} // RVA: 0x7FFE81124060
    public void set_twist(){} // RVA: 0x7FFE81124070
    public void get_tilt(){} // RVA: 0x7FFE829DF300
    public void set_tilt(){} // RVA: 0x7FFE829DF350
    public void get_penStatus(){} // RVA: 0x7FFE826A9B90
    public void set_penStatus(){} // RVA: 0x7FFE82B1F9C0
    public void get_radius(){} // RVA: 0x7FFE87F28A10
    public void set_radius(){} // RVA: 0x7FFE865EFE40
    public void get_radiusVariance(){} // RVA: 0x7FFE88021C60
    public void set_radiusVariance(){} // RVA: 0x7FFE82C95C90
    public void get_modifiers(){} // RVA: 0x7FFE8194AD00
    public void set_modifiers(){} // RVA: 0x7FFE8194A400
    public void get_shiftKey(){} // RVA: 0x7FFE88021C80
    public void get_ctrlKey(){} // RVA: 0x7FFE88021C90
    public void get_commandKey(){} // RVA: 0x7FFE88021CA0
    public void get_altKey(){} // RVA: 0x7FFE88021CB0
    public void get_actionKey(){} // RVA: 0x7FFE88021CC0
    public void Read(){} // RVA: 0x7FFE88021DC0
    public void SetPosition(){} // RVA: 0x7FFE88022420
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void <Read>g__InRange|90_0(){} // RVA: 0x7FFE88022450
}

public class PointerLocation : ValueType
{
    public UnityEngine.Vector2 _position; // 0x10
    public UnityEngine.UIElements.IPanel _panel; // 0x18
    public 0x66516AE4 _flags; // 0x20

    // ── Methods ──
    public void get_Position(){} // RVA: 0x7FFE8284EF60
    public void set_Position(){} // RVA: 0x7FFE82889220
    public void get_Panel(){} // RVA: 0x7FFE826F4210
    public void set_Panel(){} // RVA: 0x7FFE826F4230
    public void get_Flags(){} // RVA: 0x7FFE811485C0
    public void set_Flags(){} // RVA: 0x7FFE810FE0C0
    public void SetLocation(){} // RVA: 0x7FFE87F35C30
}
