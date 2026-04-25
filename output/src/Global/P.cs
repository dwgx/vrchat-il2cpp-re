// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 411

public class PCMReaderCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class PCMSetPositionCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class PackageEntry : ValueType
{
    public string packageId; // 0x10
    public string packageVersion; // 0x18

    // ── Methods ──
    public void get_packageId(){} // RVA: 0x7FFAC3AD9F60
    public void set_packageId(){} // RVA: 0x7FFAC38DFE40
    public void get_packageVersion(){} // RVA: 0x7FFAC4420220
    public void set_packageVersion(){} // RVA: 0x7FFAC4420240
    public void ToJObject(){} // RVA: 0x7FFACBF32410
}

public class PacketsCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class Page : ValueType
{
    public Unity.Collections.NativeArray`1<T> array;
    public int used;
}

public class PagedGroupResult : Object
{
    public System.Collections.Generic.IReadOnlyList`1<VRC.Core.APIGroup> Groups; // 0x10
    public string NextCursor; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Pair : ValueType
{
    public int a; // 0x10
    public float b; // 0x14
}

public class PairIterator : ValueType
{
    public int System.Collections.IEnumerator.Current;
    public Photon.Client.NonAllocDictionary`2<U,T> Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Reset(){} // RVA: 0x7FFAC2C70980
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class PanicFunction_ : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class PanoSpec : Object
{
    public string url; // 0x10
    public UnityEngine.Texture2D texture; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ParallelForJobStruct`1 : ValueType
{
    public SharedStatic`1<UIntPtr> jobReflectionData;

    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAC2C709B0
    public void Execute(){} // RVA: 0x7FFAC2C79720
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class ParallelWriter : ValueType
{
    public ParallelWriter<T,T> m_Writer;
}

public class ParamInfo : Object
{
    public 0x6B166230 FType; // 0x10
    public int Minargs; // 0x14
    public int Maxargs; // 0x18
    public 0x6B15D960[] ArgTypes; // 0x20

    // ── Methods ──
    public void get_FType(){} // RVA: 0x7FFAC2F6E5C0
    public void get_Minargs(){} // RVA: 0x7FFAC33D5A20
    public void get_Maxargs(){} // RVA: 0x7FFAC3157800
    public void get_ArgTypes(){} // RVA: 0x7FFAC2F4F0C0
    public void .ctor(){} // RVA: 0x7FFAC91A74E0
}

public class Parameter : Object
{
    public string hash; // 0x10
    public int _hash; // 0x18

    // ── Methods ──
    public void get_hash(){} // RVA: 0x7FFACC014ED0
    public void IsNull(){} // RVA: 0x7FFACC014F40
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ParameterBox : InitializeLocalInstruction
{
    public object InstructionName;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void Run(){} // RVA: 0x7FFAC8DDD0E0
    public void get_InstructionName(){} // RVA: 0x7FFAC8DDD210
}

public class ParameterConfig : Object
{
    public string name; // 0x10
    public InputParameter input; // 0x18
    public OutputParameter output; // 0x20
    public string stringType; // 0x28
    public 0x6B027E38 parameterType; // 0x30
    public int hash; // 0x34

    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAC3BBF910
    public void GetDefaultAddressFor(){} // RVA: 0x7FFAC3BBFD50
    public void .ctor(){} // RVA: 0x7FFAC3BBFDD0
}

public class ParameterEnumerable : ValueType
{
    public UnityEngine.InputSystem.InputActionState m_State; // 0x10
    public ParameterOverride m_Parameter; // 0x18
    public int m_MapIndex; // 0x90

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9531CD0
    public void GetEnumerator(){} // RVA: 0x7FFAC9531DE0
    public void System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator(){} // RVA: 0x7FFAC9531F10
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9531FE0
}

public class ParameterEnumerator : ValueType
{
    public UnityEngine.InputSystem.InputActionState Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x18
    public int m_BindingCurrentIndex; // 0x1C
    public int m_BindingEndIndex; // 0x20
    public int m_InteractionCurrentIndex; // 0x24
    public int m_InteractionEndIndex; // 0x28
    public int m_ProcessorCurrentIndex; // 0x2C
    public int m_ProcessorEndIndex; // 0x30
    public UnityEngine.InputSystem.InputBinding m_BindingMask; // 0x38
    public System.Type m_ObjectType; // 0x90
    public string m_ParameterName; // 0x98
    public bool m_MayBeInteraction; // 0xA0
    public bool m_MayBeProcessor; // 0xA1
    public bool m_MayBeComposite; // 0xA2
    public bool m_CurrentBindingIsComposite; // 0xA3
    public object m_CurrentObject; // 0xA8
    public System.Reflection.FieldInfo m_CurrentParameter; // 0xB0

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC95320B0
    public void MoveToNextBinding(){} // RVA: 0x7FFAC9532480
    public void MoveToNextInteraction(){} // RVA: 0x7FFAC95326A0
    public void MoveToNextProcessor(){} // RVA: 0x7FFAC9532710
    public void FindParameter(){} // RVA: 0x7FFAC9532780
    public void MoveNext(){} // RVA: 0x7FFAC9532930
    public void Reset(){} // RVA: 0x7FFAC9532AB0
    public void get_Current(){} // RVA: 0x7FFAC9532C20
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC9532D00
    public void Dispose(){} // RVA: 0x7FFAC2F21310
}

public class ParameterExpressionProxy : Object
{
    public System.Linq.Expressions.ParameterExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D722A0
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_IsByRef(){} // RVA: 0x7FFAC84AA530
    public void get_Name(){} // RVA: 0x7FFAC3511350
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class ParameterLookupKey : Object
{
    public string Name; // 0x10
    public System.Type Type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void get_Name(){} // RVA: 0x7FFAC2F3C380
    public void get_Type(){} // RVA: 0x7FFAC2F247C0
    public void GetHashCode(){} // RVA: 0x7FFAC8AF7790
    public void Equals(){} // RVA: 0x7FFAC8AF7840
}

public class ParameterLookupValue : Object
{
    public string DuplicateName; // 0x10
    public System.Text.Json.Serialization.Metadata.JsonPropertyInfo JsonPropertyInfo; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F87E80
    public void get_DuplicateName(){} // RVA: 0x7FFAC2F3C380
    public void set_DuplicateName(){} // RVA: 0x7FFAC2F22E30
    public void get_JsonPropertyInfo(){} // RVA: 0x7FFAC2F247C0
}

public class ParameterOverride : ValueType
{
    public string objectType; // 0x10
    public string parameter; // 0x18
    public UnityEngine.InputSystem.InputBinding bindingMask; // 0x20
    public UnityEngine.InputSystem.Utilities.PrimitiveValue value; // 0x78

    // ── Methods ──
    public void get_objectType(){} // RVA: 0x7FFAC9532D70
    public void .ctor(){} // RVA: 0x7FFAC95330B0 | overloaded x2
    public void Find(){} // RVA: 0x7FFAC9533540 | overloaded x2
    public void PickMoreSpecificOne(){} // RVA: 0x7FFAC9533A50
}

public class ParameterizedConstructorDelegate`5 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class ParentClipScope : ValueType
{
    public bool m_Disposed; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9916040
    public void Dispose(){} // RVA: 0x7FFAC99160F0
}

public class ParentHash : ValueType
{
    public int m_Hash; // 0x10
    public int m_ParentHash; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC33D6D50
}

public class ParseElementOnlyContent_LocalFrame : Object
{
    public int startParenEntityId; // 0x10
    public 0x6B15C990 parsingSchema; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9212F00
}

public class ParsedPathComponent : ValueType
{
    public UnityEngine.InputSystem.Utilities.Substring layout; // 0x10
    public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.Utilities.Substring> usages; // 0x20
    public UnityEngine.InputSystem.Utilities.Substring name; // 0x40
    public UnityEngine.InputSystem.Utilities.Substring displayName; // 0x50

    // ── Methods ──
    public void get_layout(){} // RVA: 0x7FFAC958D3D0
    public void get_usages(){} // RVA: 0x7FFAC958D430
    public void get_name(){} // RVA: 0x7FFAC958D5E0
    public void get_displayName(){} // RVA: 0x7FFAC958D640
    public void get_isWildcard(){} // RVA: 0x7FFAC958D6A0
    public void get_isDoubleWildcard(){} // RVA: 0x7FFAC958D7C0
    public void ToHumanReadableString(){} // RVA: 0x7FFAC958EA90 | overloaded x2
    public void Matches(){} // RVA: 0x7FFAC958EB20
    public void ComparePathElementToString(){} // RVA: 0x7FFAC958F040
}

public class Parser : Object
{
    public System.IO.StringReader PeekChar; // 0x10

    // ── Methods ──
    public void IsWordBreak(){} // RVA: 0x7FFAC89E87F0
    public void .ctor(){} // RVA: 0x7FFAC89E8890
    public void Parse(){} // RVA: 0x7FFAC89E8950
    public void Dispose(){} // RVA: 0x7FFAC89E8AD0
    public void ParseObject(){} // RVA: 0x7FFAC89E8B50
    public void ParseArray(){} // RVA: 0x7FFAC89E8CE0
    public void ParseValue(){} // RVA: 0x7FFAC89E8DD0
    public void ParseByToken(){} // RVA: 0x7FFAC89E8E00
    public void ParseString(){} // RVA: 0x7FFAC89E91F0
    public void ParseNumber(){} // RVA: 0x7FFAC89E94F0
    public void EatWhitespace(){} // RVA: 0x7FFAC89E97E0
    public void get_PeekChar(){} // RVA: 0x7FFAC89E9890
    public void get_NextChar(){} // RVA: 0x7FFAC89E9940
    public void get_NextWord(){} // RVA: 0x7FFAC89E99F0
    public void get_NextToken(){} // RVA: 0x7FFAC89E9B40
}

public class ParsingState : ValueType
{
    public char[] LineNo; // 0x10
    public int LinePos; // 0x18
    public int charsUsed; // 0x1C
    public System.Text.Encoding encoding; // 0x20
    public bool appendMode; // 0x28
    public System.IO.Stream stream; // 0x30
    public System.Text.Decoder decoder; // 0x38
    public byte[] bytes; // 0x40
    public int bytePos; // 0x48
    public int bytesUsed; // 0x4C
    public System.IO.TextReader textReader; // 0x50
    public int lineNo; // 0x58
    public int lineStartPos; // 0x5C
    public string baseUriStr; // 0x60
    public System.Uri baseUri; // 0x68
    public bool isEof; // 0x70
    public bool isStreamEof; // 0x71
    public System.Xml.IDtdEntityInfo entity; // 0x78
    public int entityId; // 0x80
    public bool eolNormalized; // 0x84
    public bool entityResolvedManually; // 0x85

    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFAC91BE420
    public void Close(){} // RVA: 0x7FFAC91BE710
    public void get_LineNo(){} // RVA: 0x7FFAC2FC20C0
    public void get_LinePos(){} // RVA: 0x7FFAC91BE770
}

public class PartBinding : ValueType
{
    public int part; // 0x10
    public UnityEngine.InputSystem.InputControl control; // 0x18

    // ── Methods ──
    public void get_part(){} // RVA: 0x7FFAC4420210
    public void set_part(){} // RVA: 0x7FFAC336D8B0
    public void get_control(){} // RVA: 0x7FFAC4420220
    public void set_control(){} // RVA: 0x7FFAC4420240
}

public class PartialStateForRollback : ValueType
{
    public long _prevTotalConsumed; // 0x10
    public long _prevBytePositionInLine; // 0x18
    public int _prevConsumed; // 0x20
    public System.SequencePosition _prevCurrentPosition; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8ABDFA0
    public void GetStartPosition(){} // RVA: 0x7FFAC8ABE010
}

public class Particle : ValueType
{
    public UnityEngine.Vector3 lifetime; // 0x10
    public UnityEngine.Vector3 position; // 0x1C
    public UnityEngine.Vector3 velocity; // 0x28
    public UnityEngine.Vector3 animatedVelocity; // 0x34
    public UnityEngine.Vector3 totalVelocity; // 0x40
    public UnityEngine.Vector3 remainingLifetime; // 0x4C
    public UnityEngine.Vector3 startLifetime; // 0x58
    public UnityEngine.Vector3 startColor; // 0x64
    public UnityEngine.Color32 randomSeed; // 0x70
    public uint axisOfRotation; // 0x74
    public uint startSize; // 0x78
    public float startSize3D; // 0x7C
    public float rotation; // 0x80
    public int rotation3D; // 0x84
    public float angularVelocity; // 0x88
    public float angularVelocity3D; // 0x8C
    public uint m_Flags; // 0x90

    // ── Methods ──
    public void set_lifetime(){} // RVA: 0x7FFAC2F4A090
    public void get_position(){} // RVA: 0x7FFAC9811DA0
    public void set_position(){} // RVA: 0x7FFAC530B6C0
    public void get_velocity(){} // RVA: 0x7FFAC9811DC0
    public void set_velocity(){} // RVA: 0x7FFAC9811DE0
    public void get_animatedVelocity(){} // RVA: 0x7FFAC9830D10
    public void get_totalVelocity(){} // RVA: 0x7FFAC99502D0
    public void get_remainingLifetime(){} // RVA: 0x7FFAC9950310
    public void set_remainingLifetime(){} // RVA: 0x7FFAC2F4A090
    public void get_startLifetime(){} // RVA: 0x7FFAC9950320
    public void set_startLifetime(){} // RVA: 0x7FFAC2F4A0B0
    public void get_startColor(){} // RVA: 0x7FFAC9950330
    public void set_startColor(){} // RVA: 0x7FFAC3138C10
    public void get_randomSeed(){} // RVA: 0x7FFAC9950340
    public void set_randomSeed(){} // RVA: 0x7FFAC46D5120
    public void get_axisOfRotation(){} // RVA: 0x7FFAC9950350
    public void set_axisOfRotation(){} // RVA: 0x7FFAC379D810
    public void get_startSize(){} // RVA: 0x7FFAC9950370
    public void set_startSize(){} // RVA: 0x7FFAC9950380
    public void get_startSize3D(){} // RVA: 0x7FFAC99503A0
    public void set_startSize3D(){} // RVA: 0x7FFAC99503C0
    public void get_rotation(){} // RVA: 0x7FFAC99503E0
    public void set_rotation(){} // RVA: 0x7FFAC99503F0
    public void get_rotation3D(){} // RVA: 0x7FFAC9950410
    public void set_rotation3D(){} // RVA: 0x7FFAC9950450
    public void get_angularVelocity(){} // RVA: 0x7FFAC9950490
    public void set_angularVelocity(){} // RVA: 0x7FFAC99504A0
    public void get_angularVelocity3D(){} // RVA: 0x7FFAC99504C0
    public void set_angularVelocity3D(){} // RVA: 0x7FFAC9950500
    public void GetCurrentSize(){} // RVA: 0x7FFAC9950540
    public void GetCurrentSize3D(){} // RVA: 0x7FFAC99505B0
    public void GetCurrentColor(){} // RVA: 0x7FFAC9950650
    public void SetMeshIndex(){} // RVA: 0x7FFAC99506D0
    public void GetMeshIndex(){} // RVA: 0x7FFAC99506E0
}

public class ParticleSystemBeginUpdateAll : ValueType
{
}

public class ParticleSystemEndUpdateAll : ValueType
{
}

public class PassthroughCapabilities : Object
{
    public bool SupportsPassthrough; // 0x10
    public bool SupportsColorPassthrough; // 0x11

    // ── Methods ──
    public void get_SupportsPassthrough(){} // RVA: 0x7FFAC2FEB5E0
    public void get_SupportsColorPassthrough(){} // RVA: 0x7FFAC3771DA0
    public void .ctor(){} // RVA: 0x7FFAC8391A70
}

public class PassthroughMeshInstance : ValueType
{
    public ulong meshHandle; // 0x10
    public ulong instanceHandle; // 0x18
    public bool updateTransform; // 0x20
    public UnityEngine.Matrix4x4 localToWorld; // 0x24
}

public class PathListComparer : Object
{
    public PathListComparer StaticInstance;

    // ── Methods ──
    public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFAC92D3DA0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC92D4010
}

public class PathParser : ValueType
{
    public string isAtEnd; // 0x10
    public int length; // 0x18
    public int leftIndexInPath; // 0x1C
    public int rightIndexInPath; // 0x20
    public ParsedPathComponent current; // 0x28

    // ── Methods ──
    public void get_isAtEnd(){} // RVA: 0x7FFAC958F300
    public void .ctor(){} // RVA: 0x7FFAC958F310
    public void MoveToNextComponent(){} // RVA: 0x7FFAC958F3A0
    public void ParseComponentPart(){} // RVA: 0x7FFAC958FB00
}

public class PathResolver : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6EA1B30
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class PayloadBuffer : MemoryStream
{
    // ── Methods ──
    public void ToTruncatedByteArray(){} // RVA: 0x7FFACBB379E0
    public void .ctor(){} // RVA: 0x7FFACBB2A930
}

public class PcgRandom : ValueType
{
    public ulong increment; // 0x10
    public ulong state; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9863C10
    public void GetUInt(){} // RVA: 0x7FFAC9863C40
    public void RotateRight(){} // RVA: 0x7FFAC8430200
    public void XshRr(){} // RVA: 0x7FFAC9863C90
    public void Step(){} // RVA: 0x7FFAC9863CC0
}

public class Pelvis : Object
{
    public UnityEngine.Vector3 IKOffset; // 0x10
    public float heightOffset; // 0x1C
    public RootMotion.FinalIK.Grounding grounding; // 0x20
    public UnityEngine.Vector3 lastRootPosition; // 0x28
    public float damperF; // 0x34
    public bool initiated; // 0x38
    public float lastTime; // 0x3C

    // ── Methods ──
    public void get_IKOffset(){} // RVA: 0x7FFAC2F3E8D0
    public void set_IKOffset(){} // RVA: 0x7FFAC2F3E8F0
    public void get_heightOffset(){} // RVA: 0x7FFAC2FEE570
    public void set_heightOffset(){} // RVA: 0x7FFAC2FEE580
    public void Initiate(){} // RVA: 0x7FFAC2FEE590
    public void Reset(){} // RVA: 0x7FFAC2FEE710
    public void OnEnable(){} // RVA: 0x7FFAC2FEE890
    public void Process(){} // RVA: 0x7FFAC2FEE9D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class PerCoreLockedStacks : Object
{
    public LockedStack<T>[] _perCoreStacks;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void TryPush(){} // RVA: 0x7FFAC2C70A40
    public void TryPop(){} // RVA: 0x7FFAC2C58E90
    public void Trim(){} // RVA: 0x7FFAC2E8DC40
}

public class PerTypeValues`1 : Object
{
    public bool IsReferenceOrContainsReferences;
    public T[] EmptyArray;
    public UIntPtr ArrayAdjustment;

    // ── Methods ──
    public void MeasureArrayAdjustment(){} // RVA: 0x7FFAC2C58A90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class PerfMetrics : Object
{
    public int frameCount; // 0x10
    public float frameTime; // 0x14
    public float deltaFrameTime; // 0x18
    public bool appCpuTime_IsValid; // 0x1C
    public float appCpuTime; // 0x20
    public bool appGpuTime_IsValid; // 0x24
    public float appGpuTime; // 0x28
    public bool compositorCpuTime_IsValid; // 0x2C
    public float compositorCpuTime; // 0x30
    public bool compositorGpuTime_IsValid; // 0x34
    public float compositorGpuTime; // 0x38
    public bool compositorDroppedFrameCount_IsValid; // 0x3C
    public int compositorDroppedFrameCount; // 0x40
    public bool compositorSpaceWarpMode_IsValid; // 0x44
    public int compositorSpaceWarpMode; // 0x48
    public bool systemGpuUtilPercentage_IsValid; // 0x4C
    public float systemGpuUtilPercentage; // 0x50
    public bool systemCpuUtilAveragePercentage_IsValid; // 0x54
    public float systemCpuUtilAveragePercentage; // 0x58
    public bool systemCpuUtilWorstPercentage_IsValid; // 0x5C
    public float systemCpuUtilWorstPercentage; // 0x60
    public bool deviceCpuClockFrequencyInMHz_IsValid; // 0x64
    public float deviceCpuClockFrequencyInMHz; // 0x68
    public bool deviceGpuClockFrequencyInMHz_IsValid; // 0x6C
    public float deviceGpuClockFrequencyInMHz; // 0x70
    public bool deviceCpuClockLevel_IsValid; // 0x74
    public int deviceCpuClockLevel; // 0x78
    public bool deviceGpuClockLevel_IsValid; // 0x7C
    public int deviceGpuClockLevel; // 0x80
    public bool[] deviceCpuCoreUtilPercentage_IsValid; // 0x88
    public float[] deviceCpuCoreUtilPercentage; // 0x90

    // ── Methods ──
    public void ToJSON(){} // RVA: 0x7FFAC895F6F0
    public void LoadFromJSON(){} // RVA: 0x7FFAC895FDC0
    public void .ctor(){} // RVA: 0x7FFAC8960920
}

public class PerformanceAnalyticsUpdate : ValueType
{
}

public class PermissionFilter : ValueType
{
    public bool allowSelf; // 0x10
    public bool allowOthers; // 0x11
    public 0x6B25DAE0 contentTypes; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC443C600 | overloaded x3
    public void IsAllowed(){} // RVA: 0x7FFAC9E54390 | overloaded x2
}

public class PersonalMirrorIcons : ValueType
{
    public UnityEngine.Texture2D mirror; // 0x10
    public UnityEngine.Texture2D mirrorOpacity; // 0x18
    public UnityEngine.Texture2D mirrorScale; // 0x20
    public UnityEngine.Texture2D mirrorTracking; // 0x28
    public UnityEngine.Texture2D mirrorVisibility; // 0x30
    public UnityEngine.Texture2D mirrorReset; // 0x38
    public UnityEngine.Texture2D mirrorPlus; // 0x40
    public UnityEngine.Texture2D mirrorMinus; // 0x48
    public UnityEngine.Texture2D faceMirror; // 0x50
    public UnityEngine.Texture2D faceOpacity; // 0x58
    public UnityEngine.Texture2D facePosition; // 0x60
    public UnityEngine.Texture2D faceScale; // 0x68
    public UnityEngine.Texture2D faceReset; // 0x70
}

public class Perspective : Object
{
    public UnityEngine.Vector2 depthImageSize; // 0x10
    public UnityEngine.Vector2 depthPrincipalPoint; // 0x18
    public UnityEngine.Vector2 depthFocalLength; // 0x20
    public float farClip; // 0x28
    public float nearClip; // 0x2C
    public UnityEngine.Matrix4x4 extrinsics; // 0x30
    public UnityEngine.Matrix4x4 extrinsicsInv; // 0x70
    public UnityEngine.Vector4 crop; // 0xB0
    public float clipEpsilon; // 0xC0
    public UnityEngine.Vector3 cameraNormal; // 0xC4
    public UnityEngine.Vector3 cameraCenter; // 0xD0

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class PerspectiveDataBuffer : SyncedStructuredBuffer`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC494C430
}

public class PhotoCaptureResult : ValueType
{
    public 0x6B181668 resultType; // 0x10
    public long hResult; // 0x18
}

public class PhraseRecognizedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5F0DE10
    public void Invoke(){} // RVA: 0x7FFAC5CACDC0
}

public class PhysBoneJob : ValueType
{
    public float currentTime; // 0x10
    public Unity.Mathematics.float3 distanceCullOrigin; // 0x14
    public Unity.Collections.NativeArray`1<int> chainIndices; // 0x20
    public Unity.Collections.NativeArray`1<ChainRoot> roots; // 0x30
    public Unity.Collections.NativeArray`1<Chain> chains; // 0x40
    public Unity.Collections.NativeArray`1<Bone> bones; // 0x50
    public Unity.Collections.NativeArray`1<UnityEngine.Jobs.TransformAccess> transformAccess; // 0x60
    public Unity.Collections.NativeArray`1<TransformData> transformData; // 0x70
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x80
    public Unity.Collections.NativeArray`1<0x6B25FD40> errorBuffer; // 0x90
    public int FABRIK_MAX_ITERATIONS;
    public float FABRIK_SOLVED_MARGIN;

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9E43D00
    public void InitializeChain(){} // RVA: 0x7FFAC9E45590
    public void SolveAnimation(){} // RVA: 0x7FFAC9E45D80
    public void SolveChain(){} // RVA: 0x7FFAC9E467A0
    public void UpdateColliders(){} // RVA: 0x7FFAC9E49730
    public void LerpColliders(){} // RVA: 0x7FFAC9E49DF0
    public void SolveCollisions(){} // RVA: 0x7FFAC9E4A040
    public void ApplyAngleLimits(){} // RVA: 0x7FFAC9E4ACC0
    public void ClampGlobalBoneLength(){} // RVA: 0x7FFAC9E4B780
    public void SolveGrabIK(){} // RVA: 0x7FFAC9E4B950
}

public class PhysBoneStats : ValueType
{
    public int componentCount; // 0x10
    public int transformCount; // 0x14
    public int colliderCount; // 0x18
    public int collisionCheckCount; // 0x1C
}

public class Physics : Object
{
    // ── Methods ──
    public void SetOrientationOnPath(){} // RVA: 0x7FFAC49B0E00
    public void HasRigidbody2D(){} // RVA: 0x7FFAC49B0FA0
    public void HasRigidbody(){} // RVA: 0x7FFAC49B10A0
    public void CreateDOTweenPathTween(){} // RVA: 0x7FFAC49B11A0
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
    public string sku; // 0x68
    public string user_id; // 0x70
    public string subscription_start_time; // 0x78
    public int subscription_end_time; // 0x80
    public int subscription_type; // 0x84
    public int status; // 0x88
    public bool free_trial; // 0x8C
    public string next_period; // 0x90

    // ── Methods ──
    public void get_sku(){} // RVA: 0x7FFAC2F9CD50
    public void set_sku(){} // RVA: 0x7FFAC2F9CD60
    public void get_user_id(){} // RVA: 0x7FFAC2FE9590
    public void set_user_id(){} // RVA: 0x7FFAC2FE95A0
    public void get_subscription_start_time(){} // RVA: 0x7FFAC30E5600
    public void set_subscription_start_time(){} // RVA: 0x7FFAC30E06F0
    public void get_subscription_end_time(){} // RVA: 0x7FFAC35729C0
    public void set_subscription_end_time(){} // RVA: 0x7FFAC3572BF0
    public void get_subscription_type(){} // RVA: 0x7FFAC46D5110
    public void set_subscription_type(){} // RVA: 0x7FFAC46D5150
    public void get_status(){} // RVA: 0x7FFAC37EE8C0
    public void set_status(){} // RVA: 0x7FFAC37F9DE0
    public void get_free_trial(){} // RVA: 0x7FFAC2F89520
    public void set_free_trial(){} // RVA: 0x7FFAC2F89530
    public void get_next_period(){} // RVA: 0x7FFAC32EF640
    public void set_next_period(){} // RVA: 0x7FFAC354E360
    public void .ctor(){} // RVA: 0x7FFACBEF0FA0
}

public class PictureManager : Object
{
    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC429F980
    public void Equals(){} // RVA: 0x7FFAC429FD80
    public void GetHashCode(){} // RVA: 0x7FFAC429FEC0
    public void op_Implicit(){} // RVA: 0x7FFAC42A00C0
    public void CompareBaseObjects(){} // RVA: 0x7FFAC42A03A0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC42A05B0
    public void GetCachedPtr(){} // RVA: 0x7FFAC2F21310
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void set_name(){} // RVA: 0x7FFAC42A0870
    public void Instantiate(){} // RVA: 0x7FFAC42A0AC0
    public void ToString(){} // RVA: 0x7FFAC2F21310
    public void .ctor_934187086F08(){} // RVA: 0x7FFAC42A0D80
    public void GetHashCode_A7E3EED14C22(){} // RVA: 0x7FFAC42A1050
    public void NodeTreeFromSortedDictionary(){} // RVA: 0x7FFAC42A11D0
    public void ToString_083F1EFF312E(){} // RVA: 0x7FFAC2F21310
    public void GetLongFromDelegate(){} // RVA: 0x7FFAC42A1270
    public void GetBooleanFromDelegate(){} // RVA: 0x7FFAC42A13B0
    public void Initialize(){} // RVA: 0x7FFAC42A1560
    public void FailFast(){} // RVA: 0x7FFAC42A1630
    public void Destroy(){} // RVA: 0x7FFAC2F21310
    public void GetOrInitializePictureData(){} // RVA: 0x7FFAC42A1770
}

public class PinchData : ValueType
{
    public float Distance; // 0x10
    public float Amount; // 0x14
    public UnityEngine.Vector3 Center; // 0x18
}

public class PinnedArray`1 : ValueType
{
    public System.Runtime.InteropServices.GCHandle _handle;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
}

public class PinnedBlob : ValueType
{
    public System.Runtime.InteropServices.GCHandle Handle; // 0x10
    public int Length; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC47EB650
    public void GetMemoryBlock(){} // RVA: 0x7FFAC8A7A0A0
}

public class PipelineEntry : Object
{
    public string Command; // 0x10
    public 0x6B13A020 Flags; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC488C310 | overloaded x2
    public void HasFlag(){} // RVA: 0x7FFAC946B550
}

public class PipelineSaver : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class Plane : ValueType
{
    public Unity.Mathematics.float3 position; // 0x10
    public Unity.Mathematics.float3 normal; // 0x1C

    // ── Methods ──
    public void ClosestPoint(){} // RVA: 0x7FFAC9DFED70
}

public class PlatformAsset : Object
{
    public 0x6B169720 Platform; // 0x10
    public UnityEngine.Sprite Icon; // 0x18
    public UnityEngine.Color Color; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class PlatformOptions : Object
{
    public RenderHeads.Media.AVProVideo.HttpHeaderData httpHeaders; // 0x10
    public RenderHeads.Media.AVProVideo.KeyAuthData keyAuth; // 0x18

    // ── Methods ──
    public void IsModified(){} // RVA: 0x7FFAC47C24F0
    public void GetKeyServerAuthToken(){} // RVA: 0x7FFAC356C7D0
    public void GetOverrideDecryptionKey(){} // RVA: 0x7FFAC47C2590
    public void StartWithHighestBandwidth(){} // RVA: 0x7FFAC2F21320
    public void .ctor(){} // RVA: 0x7FFAC47C25B0
}

public class PlaybackState : ValueType
{
    public float m_AccumulatedDt; // 0x10
    public float m_StartDelay; // 0x14
    public float m_PlaybackTime; // 0x18
    public int m_RingBufferIndex; // 0x1C
    public Emission m_Emission; // 0x20
    public Initial m_Initial; // 0x38
    public Shape m_Shape; // 0x78
    public Force m_Force; // 0xD4
    public Collision m_Collision; // 0x114
    public Noise m_Noise; // 0x154
    public Lights m_Lights; // 0x158
    public Trail m_Trail; // 0x16C
}

public class PlayerActions : ValueType
{
    public UnityEngine.InputSystem.DefaultInputActions Move; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_Move(){} // RVA: 0x7FFAC38DFDE0
    public void get_Look(){} // RVA: 0x7FFAC38E24E0
    public void get_Fire(){} // RVA: 0x7FFAC38DFEA0
    public void Get(){} // RVA: 0x7FFAC38DCA70
    public void Enable(){} // RVA: 0x7FFAC38E2520
    public void Disable(){} // RVA: 0x7FFAC38DC9F0
    public void get_enabled(){} // RVA: 0x7FFAC38DFEC0
    public void op_Implicit(){} // RVA: 0x7FFAC38DFDA0
    public void SetCallbacks(){} // RVA: 0x7FFAC9621BF0
}

public class PlayerBucketRestoredDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9DEB730
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC9DEB800
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class PlayerCleanupCachedData : ValueType
{
}

public class PlayerEmitCanvasGeometry : ValueType
{
}

public class PlayerInstance : Object
{
    public System.Collections.Generic.HashSet`1<RenderHeads.Media.AVProVideo.AudioOutput> outputs; // 0x10
    public float[] pcmData; // 0x18
    public bool isPcmDataReady; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class PlayerJoinedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9632240
}

public class PlayerLeftEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9632280
}

public class PlayerModComponentHealth : NetworkReadyHandler_68D0_68D0
{
    public float f_3DB; // 0x58
    public float f_ABC; // 0x5C
    public ÎÌÎÏÍÌÍÏÍÌÎÌÏÏÏÎÍÌÏÍÎÏÎ f_8D0; // 0x60
    public 0x6B2C5940 ÏÌÌÌÌÎÍÌÏÍÏÌÎÌÏÍÏÎÏÏÍÌÏ; // 0x68
    public bool ÍÍÏÌÌÎÏÏÎÌÏÎÎÎÎÌÎÏÎÎÌÏÏ; // 0x6C
    public ÍÍÎÎÍÎÎÏÍÌÏÏÌÎÍÍÎÎÍÏÌÏÎ ÎÏÌÎÌÌÍÌÌÌÌÏÍÍÌÏÍÍÎÌÌÌÏ; // 0x70
    public UnityEngine.Coroutine ÎÎÍÍÍÏÏÎÏÌÏÏÌÍÌÍÎÌÌÌÏÍÏ; // 0x78

    // ── Methods ──
    public void print(){} // RVA: 0x7FFAC3ECB600
    public void set_ValidExpressions(){} // RVA: 0x7FFAC3ECB6A0
    public void SetXMotion(){} // RVA: 0x7FFAC2F21320
    public void GetUnscaledTime(){} // RVA: 0x7FFAC3ECB6F0
    public void GetStatus(){} // RVA: 0x7FFAC366FE20
    public void GetUnscaledTime_465DCBC01E05(){} // RVA: 0x7FFAC3ECB8A0
    public void ShowDeath(){} // RVA: 0x7FFAC3ECBA60
    public void .ctor(){} // RVA: 0x7FFAC3ECBCE0
    public void Awake(){} // RVA: 0x7FFAC3ECBD60
    public void OnEnable(){} // RVA: 0x7FFAC3ECBD90
    public void ResetHealthRPC(){} // RVA: 0x7FFAC3ECBDB0
    public void SetProperties(){} // RVA: 0x7FFAC3ECBF20
    public void Update(){} // RVA: 0x7FFAC3ECC3C0
    public void LateUpdate(){} // RVA: 0x7FFAC3ECC530
    public void OnDisable(){} // RVA: 0x7FFAC3ECC7B0
    public void OnTriggerStay(){} // RVA: 0x7FFAC313BE20
    public void OnApplicationPause(){} // RVA: 0x7FFAC3ECC980
    public void OnApplicationQuit(){} // RVA: 0x7FFAC3ECCB40
    public void OnDisable_E5EE5FD706E0(){} // RVA: 0x7FFAC3ECCD20
    public void OnDestroy(){} // RVA: 0x7FFAC3ECCD20
    public void RemoveHealthRPC(){} // RVA: 0x7FFAC3ECCD70
    public void ComputeHealthHash(){} // RVA: 0x7FFAC3ECCF40
    public void OnCollisionExit(){} // RVA: 0x7FFAC3ECD070
    public void AddHealthRPC(){} // RVA: 0x7FFAC3ECD690
    public void Start(){} // RVA: 0x7FFAC3ECD820
    public void ApplyHealthUpdate(){} // RVA: 0x7FFAC3ECD8C0
    public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3ECDA90
    public void OnApplicationPause_6E31DE36D14C(){} // RVA: 0x7FFAC3ECDC50
    public void Update_DFA5D4C1065F(){} // RVA: 0x7FFAC3ECDCF0
}

public class PlayerModComponentJump : MonoBehaviour
{
    public ÍÌÎÍÌÌÎÌÏÍÏÍÍÏÍÎÎÏÌÌÎÌÏ ÎÌÎÎÍÏÎÏÎÌÍÏÍÌÎÏÍÏÌÎÌÎÎ; // 0x20
    public float ÌÌÍÌÎÏÏÎÌÌÎÏÍÍÎÌÌÏÍÌÏÎÎ; // 0x28
    public float ÌÌÎÌÍÌÌÏÍÌÎÍÍÍÍÏÏÎÏÏÍÍÎ; // 0x2C
    public bool ÎÎÍÍÎÎÍÎÌÎÌÍÎÏÎÍÎÍÌÍÍÏÌ; // 0x30

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3ED03F0
    public void RaiseCancellation(){} // RVA: 0x7FFAC3ED0520
    public void Start(){} // RVA: 0x7FFAC3ED0920
    public void CancelInvoke(){} // RVA: 0x7FFAC3ED0B10
    public void OnDestroy(){} // RVA: 0x7FFAC3ED0C10
    public void InvokeRepeating(){} // RVA: 0x7FFAC3ED0C20
    public void OnDisable(){} // RVA: 0x7FFAC3ED0C10
    public void IsInvoking(){} // RVA: 0x7FFAC3ED0C10
    public void StartCoroutine(){} // RVA: 0x7FFAC3ED0D20
    public void SetProperties(){} // RVA: 0x7FFAC3ED0E20
    public void OnBecameVisible(){} // RVA: 0x7FFAC3ED0C10
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class PlayerModComponentSpeed : MonoBehaviour
{
    public ÍÌÎÍÌÌÎÌÏÍÏÍÍÏÍÎÎÏÌÌÎÌÏ ÍÎÏÍÌÍÌÎÎÍÌÏÏÌÍÎÏÍÎÏÌÏÍ; // 0x20
    public float ÍÏÎÍÎÏÌÍÍÌÏÍÍÌÌÌÎÏÎÏÍÎÍ; // 0x28
    public float ÎÏÍÎÍÍÌÍÌÌÏÎÌÎÌÎÎÎÎÍÌÍÌ; // 0x2C
    public float ÍÌÌÏÏÏÍÍÏÏÎÍÍÍÍÍÌÏÌÍÍÍÌ; // 0x30
    public float ÎÍÌÏÎÍÌÍÏÏÏÍÎÏÏÍÎÏÏÎÏÎÏ; // 0x34
    public float ÏÏÌÏÌÍÏÍÍÍÌÏÏÍÎÍÌÍÌÍÏÌÏ; // 0x38
    public float ÎÎÎÍÌÌÎÍÏÌÏÎÎÌÍÍÍÎÎÏÍÌÍ; // 0x3C
    public bool ÏÌÎÏÏÌÌÍÍÌÎÌÌÏÎÌÏÌÌÌÌÍÌ; // 0x40

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3ED1150
    public void RaiseCancellation(){} // RVA: 0x7FFAC3ED12A0
    public void OnDestroy(){} // RVA: 0x7FFAC3ED12A0
    public void CancelInvoke(){} // RVA: 0x7FFAC3ED1400
    public void SetProperties(){} // RVA: 0x7FFAC3ED15F0
    public void InvokeRepeating(){} // RVA: 0x7FFAC3ED1A90
    public void OnBecameInvisible(){} // RVA: 0x7FFAC3ED1C80
    public void IsInvoking(){} // RVA: 0x7FFAC3ED2120
    public void Start(){} // RVA: 0x7FFAC3ED25C0
    public void StartCoroutine(){} // RVA: 0x7FFAC3ED27B0
    public void OnTriggerEnter(){} // RVA: 0x7FFAC3ED29A0
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
    public void Initialize(){} // RVA: 0x7FFAC3ED2B90
    public void StopCoroutine(){} // RVA: 0x7FFAC3ED2CF0
}

public class PlayerModComponentVoice : MonoBehaviour
{
    public float ÏÎÍÏÏÎÍÏÏÌÏÍÎÍÎÌÏÎÏÍÌÌÌ; // 0x20
    public float ÎÍÌÏÌÎÌÌÎÍÏÌÏÍÏÍÍÌÎÎÎÎÍ; // 0x24
    public bool ÍÌÏÎÎÏÍÌÍÍÎÏÌÌÍÌÌÍÌÍÎÌÏ; // 0x28
    public ÌÍÎÎÍÎÌÌÍÎÌÌÍÏÎÎÍÍÍÏÎÍÍ ÍÌÏÎÏÏÌÌÍÏÌÌÏÌÏÌÌÎÏÎÏÎÍ; // 0x30

    // ── Methods ──
    public void OnDestroy(){} // RVA: 0x7FFAC3ED2EE0
    public void RaiseCancellation(){} // RVA: 0x7FFAC3ED2EF0
    public void IsInvoking(){} // RVA: 0x7FFAC3ED3000
    public void CancelInvoke(){} // RVA: 0x7FFAC3ED3090
    public void Invoke(){} // RVA: 0x7FFAC3ED2EE0
    public void SetProperties(){} // RVA: 0x7FFAC3ED3120
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
    public void Initialize(){} // RVA: 0x7FFAC3ED3530
    public void Awake(){} // RVA: 0x7FFAC3ED35C0
    public void StartCoroutine(){} // RVA: 0x7FFAC3ED3650
    public void OnTriggerExit(){} // RVA: 0x7FFAC3ED3800
    public void Start(){} // RVA: 0x7FFAC3ED3C10
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
    public void .ctor(){} // RVA: 0x7FFAC5CB01B0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC9DEBA90
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class PlayerUpdateCanvases : ValueType
{
}

public class Point : Object
{
    public float frequency; // 0x10
    public float data; // 0x14

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC3B2F270
    public void Equals(){} // RVA: 0x7FFAC3B2F270
    public void GetCachedPtr_D45A011958AB_D45A011958AB(){} // RVA: 0x7FFAC3B2F270 | overloaded x2
    public void op_Implicit(){} // RVA: 0x7FFAC3B2F300
    public void CompareBaseObjects(){} // RVA: 0x7FFAC3B2F360
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3B2F270
    public void .ctor(){} // RVA: 0x7FFAC3B2F3C0
}

public class PointAccum : Object
{
    public int[] x; // 0x10
    public int[] y; // 0x18
    public int[] z; // 0x20
    public int[] u; // 0x28
    public int[] v; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBFD7900
}

public class PointExt : Object
{
    public int[] x; // 0x10
    public int[] y; // 0x18
    public int[] z; // 0x20
    public int[] t; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBFD7BE0
}

public class PointPrecomp : Object
{
    public int[] ypx_h; // 0x10
    public int[] ymx_h; // 0x18
    public int[] xyd; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBFD7E40
}

public class PointerEvent : Object
{
    public int pointerId; // 0x10
    public string pointerType; // 0x18
    public bool isPrimary; // 0x20
    public int button; // 0x24
    public int pressedButtons; // 0x28
    public UnityEngine.Vector3 position; // 0x2C
    public UnityEngine.Vector3 localPosition; // 0x38
    public UnityEngine.Vector3 deltaPosition; // 0x44
    public float deltaTime; // 0x50
    public int clickCount; // 0x54
    public float pressure; // 0x58
    public float tangentialPressure; // 0x5C
    public float altitudeAngle; // 0x60
    public float azimuthAngle; // 0x64
    public float twist; // 0x68
    public UnityEngine.Vector2 tilt; // 0x6C
    public 0x6B2D9160 penStatus; // 0x74
    public UnityEngine.Vector2 radius; // 0x78
    public UnityEngine.Vector2 radiusVariance; // 0x80
    public 0x6B27F588 modifiers; // 0x88

    // ── Methods ──
    public void get_pointerId(){} // RVA: 0x7FFAC2F6E5C0
    public void set_pointerId(){} // RVA: 0x7FFAC2F240C0
    public void get_pointerType(){} // RVA: 0x7FFAC2F247C0
    public void set_pointerType(){} // RVA: 0x7FFAC2F87E80
    public void get_isPrimary(){} // RVA: 0x7FFAC300F9D0
    public void set_isPrimary(){} // RVA: 0x7FFAC300F9E0
    public void get_button(){} // RVA: 0x7FFAC3921980
    public void set_button(){} // RVA: 0x7FFAC41674D0
    public void get_pressedButtons(){} // RVA: 0x7FFAC32EC4C0
    public void set_pressedButtons(){} // RVA: 0x7FFAC369A6E0
    public void get_position(){} // RVA: 0x7FFAC2F87F10
    public void set_position(){} // RVA: 0x7FFAC2F87F30
    public void get_localPosition(){} // RVA: 0x7FFAC2F87F40
    public void set_localPosition(){} // RVA: 0x7FFAC2F87F60
    public void get_deltaPosition(){} // RVA: 0x7FFAC2F87F70
    public void set_deltaPosition(){} // RVA: 0x7FFAC2F87F90
    public void get_deltaTime(){} // RVA: 0x7FFAC2F89460
    public void set_deltaTime(){} // RVA: 0x7FFAC2F89470
    public void get_clickCount(){} // RVA: 0x7FFAC38913D0
    public void set_clickCount(){} // RVA: 0x7FFAC3890750
    public void get_pressure(){} // RVA: 0x7FFAC2F49FE0
    public void set_pressure(){} // RVA: 0x7FFAC2F49FF0
    public void get_tangentialPressure(){} // RVA: 0x7FFAC2F4A000
    public void set_tangentialPressure(){} // RVA: 0x7FFAC2F4A010
    public void get_altitudeAngle(){} // RVA: 0x7FFAC3031E10
    public void set_altitudeAngle(){} // RVA: 0x7FFAC3735550
    public void get_azimuthAngle(){} // RVA: 0x7FFAC2F4A040
    public void set_azimuthAngle(){} // RVA: 0x7FFAC2F4A050
    public void get_twist(){} // RVA: 0x7FFAC2F4A060
    public void set_twist(){} // RVA: 0x7FFAC2F4A070
    public void get_tilt(){} // RVA: 0x7FFAC46D50C0
    public void set_tilt(){} // RVA: 0x7FFAC46D50B0
    public void get_penStatus(){} // RVA: 0x7FFAC43D9E20
    public void set_penStatus(){} // RVA: 0x7FFAC48B4C80
    public void get_radius(){} // RVA: 0x7FFAC9B80160
    public void set_radius(){} // RVA: 0x7FFAC8246500
    public void get_radiusVariance(){} // RVA: 0x7FFAC9C79410
    public void set_radiusVariance(){} // RVA: 0x7FFAC4A2BA90
    public void get_modifiers(){} // RVA: 0x7FFAC37EE8C0
    public void set_modifiers(){} // RVA: 0x7FFAC37F9DE0
    public void get_shiftKey(){} // RVA: 0x7FFAC9C79430
    public void get_ctrlKey(){} // RVA: 0x7FFAC9C79440
    public void get_commandKey(){} // RVA: 0x7FFAC9C79450
    public void get_altKey(){} // RVA: 0x7FFAC9C79460
    public void get_actionKey(){} // RVA: 0x7FFAC9C79470
    public void Read(){} // RVA: 0x7FFAC9C79570
    public void SetPosition(){} // RVA: 0x7FFAC9C79BD0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void <Read>g__InRange|90_0(){} // RVA: 0x7FFAC9C79C00
}
