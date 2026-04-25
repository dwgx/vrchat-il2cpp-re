// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 470

public class BCrypt : Object
{
    // ── Methods ──
    public void BCryptGenRandom(){} // RVA: 0x7FFAC838A450
}

public class BaggageEnumerator : ValueType
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,string>> Current; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_Current(){} // RVA: 0x7FFAC834B6F0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC834B8D0
    public void Dispose(){} // RVA: 0x7FFAC834B930
    public void MoveNext(){} // RVA: 0x7FFAC834B980
    public void Reset(){} // RVA: 0x7FFAC834B9D0
}

public class BaggageLinkedList : Object
{
    public System.Diagnostics.DiagNode`1<System.Collections.Generic.KeyValuePair`2<string,string>> First; // 0x10

    // ── Methods ──
    public void get_First(){} // RVA: 0x7FFAC2F3C380
    public void GetEnumerator(){} // RVA: 0x7FFAC8F733B0
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator(){} // RVA: 0x7FFAC8F73410
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8F734A0
}

public class BakeTextureOutput : ValueType
{
    public UnityEngine.Texture2D vertices; // 0x10
    public UnityEngine.Texture2D indices; // 0x18
}

public class BakedSolution : Object
{
    public float m_FrustumSizeIntSpace; // 0x10
    public AspectStretcher m_AspectStretcher; // 0x14
    public bool m_HasBones; // 0x20
    public double m_SqrPolygonDiagonal; // 0x28
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> m_OriginalPolygon; // 0x30
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> m_Solution; // 0x38
    public double k_ClipperEpsilon;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC484B2A0
    public void IsValid(){} // RVA: 0x7FFAC484B3D0
    public void ConfinePoint(){} // RVA: 0x7FFAC484B3E0
    public void FindIntersection(){} // RVA: 0x7FFAC484BA50
    public void <ConfinePoint>g__IntPointLerp|9_0(){} // RVA: 0x7FFAC484BC70
    public void <ConfinePoint>g__IsInsideOriginal|9_1(){} // RVA: 0x7FFAC484BD10
    public void <ConfinePoint>g__ClosestPointOnSegment|9_2(){} // RVA: 0x7FFAC484BDF0
    public void <ConfinePoint>g__DoesIntersectOriginal|9_3(){} // RVA: 0x7FFAC484BE80
    public void <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(){} // RVA: 0x7FFAC484C0F0
}

public class BakingStateCache : ValueType
{
    public ClipperOffset offsetter; // 0x10
    public System.Collections.Generic.List`1<PolygonSolution> solutions; // 0x18
    public PolygonSolution rightCandidate; // 0x20
    public PolygonSolution leftCandidate; // 0x30
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> maxCandidate; // 0x40
    public float stepSize; // 0x48
    public float maxFrustumHeight; // 0x4C
    public float userSetMaxFrustumHeight; // 0x50
    public float theoriticalMaxFrustumHeight; // 0x54
    public float currentFrustumHeight; // 0x58
    public float bakeTime; // 0x5C
}

public class BaseVisualElementScheduledItem : ScheduledItem
{
    public UnityEngine.UIElements.VisualElement element; // 0x38
    public bool isScheduled; // 0x40
    public UnityEngine.UIElements.VisualElementPanelActivator m_Activator; // 0x48

    // ── Methods ──
    public void get_element(){} // RVA: 0x7FFAC31D0140
    public void set_element(){} // RVA: 0x7FFAC31D0C20
    public void .ctor(){} // RVA: 0x7FFAC9BF3DB0
    public void StartingIn(){} // RVA: 0x7FFAC9BF3FD0
    public void Every(){} // RVA: 0x7FFAC9BF3FE0
    public void OnItemUnscheduled(){} // RVA: 0x7FFAC9BF40F0
    public void Resume(){} // RVA: 0x7FFAC9BF4130
    public void Pause(){} // RVA: 0x7FFAC9BF4160
    public void ExecuteLater(){} // RVA: 0x7FFAC9BF4190
    public void OnPanelActivate(){} // RVA: 0x7FFAC9BF4210
    public void OnPanelDeactivate(){} // RVA: 0x7FFAC9BF42E0
    public void CanBeActivated(){} // RVA: 0x7FFAC9BF4360
}

public class BasicEntropySource : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.IsPredictionResistant; // 0x10
    public bool BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.EntropySize; // 0x18
    public int mEntropySize; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC98BA7E0
    public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.get_IsPredictionResistant(){} // RVA: 0x7FFAC2F3C4E0
    public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.GetEntropy(){} // RVA: 0x7FFACBB835F0
    public void BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IEntropySource.get_EntropySize(){} // RVA: 0x7FFAC44357F0
}

public class BatchModeUpdate : ValueType
{
}

public class BehaviourDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class BendBone : Object
{
    public UnityEngine.Transform transform; // 0x10
    public float weight; // 0x18
    public UnityEngine.Quaternion defaultLocalRotation; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FFC300 | overloaded x2
    public void StoreDefaultLocalState(){} // RVA: 0x7FFAC2FFC3C0
    public void FixTransforms(){} // RVA: 0x7FFAC2FFC440
}

public class BigNumberBuffer : ValueType
{
    public System.Text.StringBuilder digits; // 0x10
    public int precision; // 0x18
    public int scale; // 0x1C
    public bool sign; // 0x20

    // ── Methods ──
    public void Create(){} // RVA: 0x7FFAC8FC5EF0
}

public class BinaryExpressionProxy : Object
{
    public System.Linq.Expressions.BinaryExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D70FD0
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_Conversion(){} // RVA: 0x7FFAC4426B30
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_IsLifted(){} // RVA: 0x7FFAC8D710D0
    public void get_IsLiftedToNull(){} // RVA: 0x7FFAC8D710F0
    public void get_Left(){} // RVA: 0x7FFAC356B610
    public void get_Method(){} // RVA: 0x7FFAC84AA530
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Right(){} // RVA: 0x7FFAC3511350
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class BinaryMask : Object
{
    public Google.Protobuf.MessageParser`1<BinaryMask> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Width;
    public int HasWidth; // 0x8
    public int Height; // 0x1C
    public int HasHeight;
    public int Rasterization; // 0xC
    public int height_; // 0x20
    public int RasterizationFieldNumber;
    public Mediapipe.Rasterization rasterization_; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC82B2030
    public void get_Descriptor(){} // RVA: 0x7FFAC82B2090
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82B2110
    public void .ctor(){} // RVA: 0x7FFAC82B21C0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC82B2340
    public void get_Width(){} // RVA: 0x7FFAC82B24F0
    public void set_Width(){} // RVA: 0x7FFAC81F3760
    public void get_HasWidth(){} // RVA: 0x7FFAC81F3770
    public void ClearWidth(){} // RVA: 0x7FFAC81F3780
    public void get_Height(){} // RVA: 0x7FFAC82B2560
    public void set_Height(){} // RVA: 0x7FFAC81F3800
    public void get_HasHeight(){} // RVA: 0x7FFAC81F3810
    public void ClearHeight(){} // RVA: 0x7FFAC81F3820
    public void get_Rasterization(){} // RVA: 0x7FFAC2F4F130
    public void set_Rasterization(){} // RVA: 0x7FFAC2F22E90
    public void Equals(){} // RVA: 0x7FFAC82B2700 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC82B27F0
    public void ToString(){} // RVA: 0x7FFAC82B2880
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82B28D0
    public void CalculateSize(){} // RVA: 0x7FFAC82B2980
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82B2D90
    public void .cctor(){} // RVA: 0x7FFAC82B2EB0
}

public class BinderState : Object
{
    public int[] m_argsMap; // 0x10
    public int m_originalSize; // 0x18
    public bool m_isParamArray; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8675550
}

public class BinderWrapper : Object
{
    public string CSharpAssemblyName;
    public string BinderTypeName;
    public string CSharpArgumentInfoTypeName;
    public string CSharpArgumentInfoFlagsTypeName;
    public string CSharpBinderFlagsTypeName;
    public object _getCSharpArgumentInfoArray;
    public object _setCSharpArgumentInfoArray; // 0x8
    public Newtonsoft.Json.Utilities.MethodCall`2<object,object> _getMemberCall; // 0x10
    public Newtonsoft.Json.Utilities.MethodCall`2<object,object> _setMemberCall; // 0x18
    public bool _init; // 0x20

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC8762E50
    public void CreateSharpArgumentInfoArray(){} // RVA: 0x7FFAC8763110
    public void CreateMemberCalls(){} // RVA: 0x7FFAC8763670
    public void GetMember(){} // RVA: 0x7FFAC8763E20
    public void SetMember(){} // RVA: 0x7FFAC87640E0
}

public class BindingJson : ValueType
{
    public string name; // 0x10
    public string id; // 0x18
    public string path; // 0x20
    public string interactions; // 0x28
    public string processors; // 0x30
    public string groups; // 0x38
    public string action; // 0x40
    public bool isComposite; // 0x48
    public bool isPartOfComposite; // 0x49

    // ── Methods ──
    public void ToBinding(){} // RVA: 0x7FFAC9527970
    public void FromBinding(){} // RVA: 0x7FFAC9527C70
}

public class BindingOverrideJson : ValueType
{
    public string action; // 0x10
    public string id; // 0x18
    public string path; // 0x20
    public string interactions; // 0x28
    public string processors; // 0x30

    // ── Methods ──
    public void FromBinding(){} // RVA: 0x7FFAC9527660 | overloaded x2
    public void ToBinding(){} // RVA: 0x7FFAC95276E0
}

public class BindingOverrideListJson : ValueType
{
    public System.Collections.Generic.List`1<BindingOverrideJson> bindings; // 0x10
}

public class BindingRestrictionsProxy : Object
{
}

public class BindingState : ValueType
{
    public byte controlStartIndex; // 0x10
    public byte controlCount; // 0x11
    public byte interactionStartIndex; // 0x12
    public byte interactionCount; // 0x13
    public byte processorStartIndex; // 0x14
    public byte processorCount; // 0x15
    public ushort actionIndex; // 0x16
    public ushort mapIndex; // 0x18
    public ushort compositeOrCompositeBindingIndex; // 0x1A
    public ushort triggerEventIdForComposite; // 0x1C
    public ushort pressTime; // 0x1E
    public double flags; // 0x20
    public int chainsWithNext; // 0x28
    public int isEndOfChain; // 0x2C

    // ── Methods ──
    public void get_controlStartIndex(){} // RVA: 0x7FFAC954C3C0
    public void set_controlStartIndex(){} // RVA: 0x7FFAC954C3D0
    public void get_controlCount(){} // RVA: 0x7FFAC495DDF0
    public void set_controlCount(){} // RVA: 0x7FFAC954C470
    public void get_interactionStartIndex(){} // RVA: 0x7FFAC954C510
    public void set_interactionStartIndex(){} // RVA: 0x7FFAC954C530
    public void get_interactionCount(){} // RVA: 0x7FFAC495DE10
    public void set_interactionCount(){} // RVA: 0x7FFAC954C5E0
    public void get_processorStartIndex(){} // RVA: 0x7FFAC954C680
    public void set_processorStartIndex(){} // RVA: 0x7FFAC954C6A0
    public void get_processorCount(){} // RVA: 0x7FFAC495DE20
    public void set_processorCount(){} // RVA: 0x7FFAC954C750
    public void get_actionIndex(){} // RVA: 0x7FFAC954C7F0
    public void set_actionIndex(){} // RVA: 0x7FFAC954C810
    public void get_mapIndex(){} // RVA: 0x7FFAC954C8C0
    public void set_mapIndex(){} // RVA: 0x7FFAC954C8D0
    public void get_compositeOrCompositeBindingIndex(){} // RVA: 0x7FFAC954C970
    public void set_compositeOrCompositeBindingIndex(){} // RVA: 0x7FFAC954C990
    public void get_triggerEventIdForComposite(){} // RVA: 0x7FFAC3157800
    public void set_triggerEventIdForComposite(){} // RVA: 0x7FFAC392CD10
    public void get_pressTime(){} // RVA: 0x7FFAC5873C20
    public void set_pressTime(){} // RVA: 0x7FFAC69C0110
    public void get_flags(){} // RVA: 0x7FFAC4A0B160
    public void set_flags(){} // RVA: 0x7FFAC3B9B960
    public void get_chainsWithNext(){} // RVA: 0x7FFAC954CA40
    public void set_chainsWithNext(){} // RVA: 0x7FFAC954CA50
    public void get_isEndOfChain(){} // RVA: 0x7FFAC954CA80
    public void set_isEndOfChain(){} // RVA: 0x7FFAC954CA90
    public void get_isPartOfChain(){} // RVA: 0x7FFAC954CAC0
    public void get_isComposite(){} // RVA: 0x7FFAC954CAE0
    public void set_isComposite(){} // RVA: 0x7FFAC954CAF0
    public void get_isPartOfComposite(){} // RVA: 0x7FFAC954CB20
    public void set_isPartOfComposite(){} // RVA: 0x7FFAC954CB30
    public void get_initialStateCheckPending(){} // RVA: 0x7FFAC954CB60
    public void set_initialStateCheckPending(){} // RVA: 0x7FFAC954CB70
    public void get_wantsInitialStateCheck(){} // RVA: 0x7FFAC954CBA0
    public void set_wantsInitialStateCheck(){} // RVA: 0x7FFAC954CBB0
    public void get_partIndex(){} // RVA: 0x7FFAC4A0B150
    public void set_partIndex(){} // RVA: 0x7FFAC954CBE0
}

public class BindingSyntax : ValueType
{
    public UnityEngine.InputSystem.InputActionMap valid; // 0x10
    public UnityEngine.InputSystem.InputAction bindingIndex; // 0x18
    public int binding; // 0x20

    // ── Methods ──
    public void get_valid(){} // RVA: 0x7FFAC953F330
    public void get_bindingIndex(){} // RVA: 0x7FFAC953F3A0
    public void get_binding(){} // RVA: 0x7FFAC953F420
    public void .ctor(){} // RVA: 0x7FFAC953F520
    public void WithName(){} // RVA: 0x7FFAC953F5E0
    public void WithPath(){} // RVA: 0x7FFAC953F740
    public void WithGroup(){} // RVA: 0x7FFAC953F8B0
    public void WithGroups(){} // RVA: 0x7FFAC953FAC0
    public void WithInteraction(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void WithInteractions(){} // RVA: 0x7FFAC953FF60
    public void WithProcessor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void WithProcessors(){} // RVA: 0x7FFAC9540400
    public void Triggering(){} // RVA: 0x7FFAC9540690
    public void To(){} // RVA: 0x7FFAC95408A0
    public void NextBinding(){} // RVA: 0x7FFAC9540A40
    public void PreviousBinding(){} // RVA: 0x7FFAC9540A80
    public void NextPartBinding(){} // RVA: 0x7FFAC9540AC0
    public void PreviousPartBinding(){} // RVA: 0x7FFAC9540B50
    public void NextCompositeBinding(){} // RVA: 0x7FFAC9540BE0
    public void PreviousCompositeBinding(){} // RVA: 0x7FFAC9540C20
    public void Iterate(){} // RVA: 0x7FFAC9540C60
    public void IterateCompositeBinding(){} // RVA: 0x7FFAC9540D60
    public void IteratePartBinding(){} // RVA: 0x7FFAC9541080
    public void Erase(){} // RVA: 0x7FFAC95412E0
    public void InsertPartBinding(){} // RVA: 0x7FFAC9541720
}

public class BioControlFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2F1E0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class BioReadFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976590
    public void Invoke(){} // RVA: 0x7FFAC383F780
}

public class BioWriteFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976160
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class BitArrayEnumeratorSimple : Object
{
    public System.Collections.BitArray Current; // 0x10
    public int index; // 0x18
    public int version; // 0x1C
    public bool currentElement; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC859BDD0
    public void Clone(){} // RVA: 0x7FFAC8512B10
    public void MoveNext(){} // RVA: 0x7FFAC859BE50
    public void get_Current(){} // RVA: 0x7FFAC859BF60
    public void Reset(){} // RVA: 0x7FFAC859C090
}

public class BitRegion : ValueType
{
    public uint isEmpty; // 0x10
    public uint sizeInBits; // 0x14

    // ── Methods ──
    public void get_isEmpty(){} // RVA: 0x7FFAC956A470
    public void .ctor(){} // RVA: 0x7FFAC956A480 | overloaded x2
    public void Overlap(){} // RVA: 0x7FFAC956A490
}

public class BitsBuffer : ValueType
{
    public uint[] _bits; // 0x10
    public int _length; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8FC2A80 | overloaded x2
    public void MultiplySelf(){} // RVA: 0x7FFAC8FC2BE0
    public void SquareSelf(){} // RVA: 0x7FFAC8FC2D60
    public void Reduce(){} // RVA: 0x7FFAC8FC2E80 | overloaded x2
    public void GetBits(){} // RVA: 0x7FFAC3AD9F60
    public void GetSize(){} // RVA: 0x7FFAC5E86060
    public void Apply(){} // RVA: 0x7FFAC8FC2FA0
}

public class BitwiseDoubleEqualityComparerImpl : EqualityComparer`1
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC82259A0
    public void GetHashCode(){} // RVA: 0x7FFAC82259C0
    public void .ctor(){} // RVA: 0x7FFAC82259D0
}

public class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer`1
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC8225A70
    public void GetHashCode(){} // RVA: 0x7FFAC8225B50
    public void .ctor(){} // RVA: 0x7FFAC8225C00
}

public class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer`1
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC8225C30
    public void GetHashCode(){} // RVA: 0x7FFAC8225D20
    public void .ctor(){} // RVA: 0x7FFAC8225DD0
}

public class BitwiseSingleEqualityComparerImpl : EqualityComparer`1
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC8225A00
    public void GetHashCode(){} // RVA: 0x7FFAC8225A20
    public void .ctor(){} // RVA: 0x7FFAC8225A40
}

public class BlendshapesConfig : Object
{
    public UnityEngine.SkinnedMeshRenderer skinnedMeshRenderer; // 0x10
    public int blendShapeCount; // 0x18
    public string[] blendshapeNames; // 0x20
    public float[] blendshapeWeights; // 0x28

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC450A230
    public void Equals(){} // RVA: 0x7FFAC450A430
    public void GetHashCode(){} // RVA: 0x7FFAC450A830
    public void op_Implicit(){} // RVA: 0x7FFAC450AA30
    public void CompareBaseObjects(){} // RVA: 0x7FFAC450AC40
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC450AE50
    public void GetCachedPtr(){} // RVA: 0x7FFAC450B060
    public void get_name(){} // RVA: 0x7FFAC450B460
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Initialize(){} // RVA: 0x7FFAC450B660
    public void Instantiate(){} // RVA: 0x7FFAC450B860
}

public class BlendshapesConfigForExport : Object
{
    public string skinnedMeshRendererPath; // 0x10
    public int blendShapeCount; // 0x18
    public string[] blendshapeNames; // 0x20
    public float[] blendshapeWeights; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class BlitInfo : ValueType
{
    public UnityEngine.Texture src; // 0x10
    public UnityEngine.RectInt srcRect; // 0x18
    public UnityEngine.Vector2Int dstPos; // 0x28
    public int border; // 0x30
    public UnityEngine.Color tint; // 0x34
}

public class Block : ValueType
{
    public Range Bytes; // 0x10
    public int AllocatedBytes; // 0x20
    public int Alignment; // 0x24
    public byte Log2Alignment; // 0x28
    public byte Padding0; // 0x29
    public ushort Padding1; // 0x2A
    public uint Padding2; // 0x2C

    // ── Methods ──
    public void get_Bytes(){} // RVA: 0x7FFAC950F3E0
    public void get_AllocatedBytes(){} // RVA: 0x7FFAC950F3F0
    public void get_Alignment(){} // RVA: 0x7FFAC950F400
    public void set_Alignment(){} // RVA: 0x7FFAC950F410
    public void Dispose(){} // RVA: 0x7FFAC950F460
    public void TryFree(){} // RVA: 0x7FFAC950F460
}

public class BlockExpressionProxy : Object
{
    public System.Linq.Expressions.BlockExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71110
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Expressions(){} // RVA: 0x7FFAC8D711F0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Result(){} // RVA: 0x7FFAC8D71220
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
    public void get_Variables(){} // RVA: 0x7FFAC8D71270
}

public class BlockPool : LinkedPool`1
{
    // ── Methods ──
    public void CreateBlock(){} // RVA: 0x7FFAC9AD7940
    public void ResetBlock(){} // RVA: 0x7FFAC2F21310
    public void .ctor(){} // RVA: 0x7FFAC9AD79A0
}

public class BlurShaderIds : Object
{
    public int _MainTex;
    public int _PingData; // 0x4
    public int _PongData; // 0x8
    public int _PingSizeTS; // 0xC
    public int _PongSize; // 0x10
    public int _PowerAmount; // 0x14
    public int _KernelSize; // 0x18
    public int _GaussianExponential; // 0x1C
    public int _GaussianNormalization; // 0x20
    public int _Axis; // 0x24
    public int _Slice; // 0x28

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC495D910
}

public class Body : Object
{
    public UnityEngine.Transform transform; // 0x10
    public UnityEngine.Transform relativeTo; // 0x18
    public EffectorLink[] effectorLinks; // 0x20
    public float verticalWeight; // 0x28
    public float horizontalWeight; // 0x2C
    public float speed; // 0x30
    public UnityEngine.Vector3 lastRelativePos; // 0x34
    public UnityEngine.Vector3 smoothDelta; // 0x40
    public bool firstUpdate; // 0x4C

    // ── Methods ──
    public void Update(){} // RVA: 0x7FFAC308DB70
    public void Multiply(){} // RVA: 0x7FFAC308E1C0
    public void .ctor(){} // RVA: 0x7FFAC308E200
}

public class BodyJointLocation : ValueType
{
    public 0x6B1A7C58 OrientationValid; // 0x10
    public Posef PositionValid; // 0x18

    // ── Methods ──
    public void get_OrientationValid(){} // RVA: 0x7FFAC8908690
    public void get_PositionValid(){} // RVA: 0x7FFAC89086A0
    public void get_OrientationTracked(){} // RVA: 0x7FFAC48E9270
    public void get_PositionTracked(){} // RVA: 0x7FFAC89086B0
}

public class BodyPart : Object
{
    public float sqrMag; // 0x10
    public float mag; // 0x14
    public VirtualBone[] bones; // 0x18
    public bool initiated; // 0x20
    public UnityEngine.Vector3 rootPosition; // 0x24
    public UnityEngine.Quaternion rootRotation; // 0x30
    public int index; // 0x40
    public int LOD; // 0x44

    // ── Methods ──
    public void OnRead(){}
    public void PreSolve(){} // RVA: 0x7FFAC2C70980
    public void Write(){} // RVA: 0x7FFAC2C79B30
    public void ApplyOffsets(){} // RVA: 0x7FFAC2C70980
    public void ResetOffsets(){} // RVA: 0x7FFAC2C70980
    public void get_sqrMag(){} // RVA: 0x7FFAC304B320
    public void set_sqrMag(){} // RVA: 0x7FFAC304B330
    public void get_mag(){} // RVA: 0x7FFAC304B340
    public void set_mag(){} // RVA: 0x7FFAC304B350
    public void SetLOD(){} // RVA: 0x7FFAC2FC20B0
    public void Read(){} // RVA: 0x7FFAC304B360
    public void MovePosition(){} // RVA: 0x7FFAC304B470
    public void MoveRotation(){} // RVA: 0x7FFAC304B540
    public void Translate(){} // RVA: 0x7FFAC304B600
    public void TranslateRoot(){} // RVA: 0x7FFAC304B6F0
    public void RotateTo(){} // RVA: 0x7FFAC304B850
    public void Visualize(){} // RVA: 0x7FFAC304BC20 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFAC304BE40
}

public class BodyState : ValueType
{
    public BodyJointLocation[] JointLocations; // 0x10
    public float Confidence; // 0x18
    public uint SkeletonChangedCount; // 0x1C
    public double Time; // 0x20
}

public class BodyStateInternal : ValueType
{
    public 0x6B1A5C08 IsActive; // 0x10
    public float Confidence; // 0x14
    public uint SkeletonChangedCount; // 0x18
    public double Time; // 0x20
    public BodyJointLocation JointLocation_0; // 0x28
    public BodyJointLocation JointLocation_1; // 0x50
    public BodyJointLocation JointLocation_2; // 0x78
    public BodyJointLocation JointLocation_3; // 0xA0
    public BodyJointLocation JointLocation_4; // 0xC8
    public BodyJointLocation JointLocation_5; // 0xF0
    public BodyJointLocation JointLocation_6; // 0x118
    public BodyJointLocation JointLocation_7; // 0x140
    public BodyJointLocation JointLocation_8; // 0x168
    public BodyJointLocation JointLocation_9; // 0x190
    public BodyJointLocation JointLocation_10; // 0x1B8
    public BodyJointLocation JointLocation_11; // 0x1E0
    public BodyJointLocation JointLocation_12; // 0x208
    public BodyJointLocation JointLocation_13; // 0x230
    public BodyJointLocation JointLocation_14; // 0x258
    public BodyJointLocation JointLocation_15; // 0x280
    public BodyJointLocation JointLocation_16; // 0x2A8
    public BodyJointLocation JointLocation_17; // 0x2D0
    public BodyJointLocation JointLocation_18; // 0x2F8
    public BodyJointLocation JointLocation_19; // 0x320
    public BodyJointLocation JointLocation_20; // 0x348
    public BodyJointLocation JointLocation_21; // 0x370
    public BodyJointLocation JointLocation_22; // 0x398
    public BodyJointLocation JointLocation_23; // 0x3C0
    public BodyJointLocation JointLocation_24; // 0x3E8
    public BodyJointLocation JointLocation_25; // 0x410
    public BodyJointLocation JointLocation_26; // 0x438
    public BodyJointLocation JointLocation_27; // 0x460
    public BodyJointLocation JointLocation_28; // 0x488
    public BodyJointLocation JointLocation_29; // 0x4B0
    public BodyJointLocation JointLocation_30; // 0x4D8
    public BodyJointLocation JointLocation_31; // 0x500
    public BodyJointLocation JointLocation_32; // 0x528
    public BodyJointLocation JointLocation_33; // 0x550
    public BodyJointLocation JointLocation_34; // 0x578
    public BodyJointLocation JointLocation_35; // 0x5A0
    public BodyJointLocation JointLocation_36; // 0x5C8
    public BodyJointLocation JointLocation_37; // 0x5F0
    public BodyJointLocation JointLocation_38; // 0x618
    public BodyJointLocation JointLocation_39; // 0x640
    public BodyJointLocation JointLocation_40; // 0x668
    public BodyJointLocation JointLocation_41; // 0x690
    public BodyJointLocation JointLocation_42; // 0x6B8
    public BodyJointLocation JointLocation_43; // 0x6E0
    public BodyJointLocation JointLocation_44; // 0x708
    public BodyJointLocation JointLocation_45; // 0x730
    public BodyJointLocation JointLocation_46; // 0x758
    public BodyJointLocation JointLocation_47; // 0x780
    public BodyJointLocation JointLocation_48; // 0x7A8
    public BodyJointLocation JointLocation_49; // 0x7D0
    public BodyJointLocation JointLocation_50; // 0x7F8
    public BodyJointLocation JointLocation_51; // 0x820
    public BodyJointLocation JointLocation_52; // 0x848
    public BodyJointLocation JointLocation_53; // 0x870
    public BodyJointLocation JointLocation_54; // 0x898
    public BodyJointLocation JointLocation_55; // 0x8C0
    public BodyJointLocation JointLocation_56; // 0x8E8
    public BodyJointLocation JointLocation_57; // 0x910
    public BodyJointLocation JointLocation_58; // 0x938
    public BodyJointLocation JointLocation_59; // 0x960
    public BodyJointLocation JointLocation_60; // 0x988
    public BodyJointLocation JointLocation_61; // 0x9B0
    public BodyJointLocation JointLocation_62; // 0x9D8
    public BodyJointLocation JointLocation_63; // 0xA00
    public BodyJointLocation JointLocation_64; // 0xA28
    public BodyJointLocation JointLocation_65; // 0xA50
    public BodyJointLocation JointLocation_66; // 0xA78
    public BodyJointLocation JointLocation_67; // 0xAA0
    public BodyJointLocation JointLocation_68; // 0xAC8
    public BodyJointLocation JointLocation_69; // 0xAF0
}

public class Bone : ValueType
{
    public int isSimulated; // 0x10
    public int parentIndex; // 0x14
    public bool isEndBone; // 0x18
    public 0x6B25FB30 simulatedType; // 0x1C
    public int boneChainIndex; // 0x20
    public Unity.Mathematics.quaternion localPoseRotation; // 0x24
    public Unity.Mathematics.float3 localBoneVector; // 0x34
    public Unity.Mathematics.float3 localPoseBoneVector; // 0x40
    public Unity.Mathematics.float3 originalLocalPosition; // 0x4C
    public Unity.Mathematics.quaternion originalLocalRotation; // 0x58
    public Unity.Mathematics.float3 originalLocalVector; // 0x68
    public float originalLocalBoneLength; // 0x74
    public float globalRestLength; // 0x78
    public Unity.Mathematics.float3 originalRootEndpoint; // 0x7C
    public Unity.Mathematics.float3 originalLocalGravityNormal; // 0x88
    public Unity.Mathematics.float3 beginPoint; // 0x94
    public Unity.Mathematics.float3 endPoint; // 0xA0
    public Unity.Mathematics.float3 prevVelocity; // 0xAC
    public Unity.Mathematics.float3 immobileEndpoint; // 0xB8
    public Unity.Mathematics.float3 prevEndPoint; // 0xC4
    public Unity.Mathematics.float3 prevVector; // 0xD0
    public Unity.Mathematics.quaternion prevLocalRotation; // 0xDC
    public float totalRestLength; // 0xEC
    public float totalLength; // 0xF0
    public float totalMinRestLength; // 0xF4
    public float totalMaxRestLength; // 0xF8
    public 0x6B25FB88 grabStatus; // 0xFC
    public float pull; // 0x100
    public float spring; // 0x104
    public float stiffness; // 0x108
    public float gravity; // 0x10C
    public float gravityFalloff; // 0x110
    public float immobile; // 0x114
    public float radiusBegin; // 0x118
    public float radiusEnd; // 0x11C
    public float globalRadiusBegin; // 0x120
    public float globalRadiusEnd; // 0x124
    public Unity.Mathematics.float2 maxAngle; // 0x128
    public Unity.Mathematics.float3 limitAxisX; // 0x130
    public Unity.Mathematics.float3 limitAxisY; // 0x13C
    public Unity.Mathematics.float3 limitRotation; // 0x148
    public float stretchMotion; // 0x154
    public float stretch; // 0x158
    public float squish; // 0x15C

    // ── Methods ──
    public void get_isSimulated(){} // RVA: 0x7FFAC9E42AC0
}

public class BoneCapsule : ValueType
{
    public short BoneIndex; // 0x10
    public Vector3f StartPoint; // 0x14
    public Vector3f EndPoint; // 0x20
    public float Radius; // 0x2C
}

public class BoneLink : Object
{
    public UnityEngine.Transform bone; // 0x10
    public float weight; // 0x18
    public UnityEngine.Quaternion lastValue; // 0x1C
    public UnityEngine.Quaternion current; // 0x2C

    // ── Methods ──
    public void Apply(){} // RVA: 0x7FFAC308FFC0
    public void CrossFadeStart(){} // RVA: 0x7FFAC3090320
    public void .ctor(){} // RVA: 0x7FFAC3090330
}

public class BoneMap : Object
{
    public UnityEngine.Transform swingDirection; // 0x10
    public int isNodeBone; // 0x18
    public int lastAnimatedTargetRotation; // 0x1C
    public UnityEngine.Vector3 defaultLocalPosition; // 0x20
    public UnityEngine.Quaternion defaultLocalRotation; // 0x2C
    public UnityEngine.Vector3 localSwingAxis; // 0x3C
    public UnityEngine.Vector3 localTwistAxis; // 0x48
    public UnityEngine.Vector3 planePosition; // 0x54
    public UnityEngine.Vector3 ikPosition; // 0x60
    public UnityEngine.Quaternion defaultLocalTargetRotation; // 0x6C
    public UnityEngine.Quaternion maintainRotation; // 0x7C
    public float length; // 0x8C
    public UnityEngine.Quaternion animatedRotation; // 0x90
    public UnityEngine.Transform planeBone1; // 0xA0
    public UnityEngine.Transform planeBone2; // 0xA8
    public UnityEngine.Transform planeBone3; // 0xB0
    public int plane1ChainIndex; // 0xB8
    public int plane1NodeIndex; // 0xBC
    public int plane2ChainIndex; // 0xC0
    public int plane2NodeIndex; // 0xC4
    public int plane3ChainIndex; // 0xC8
    public int plane3NodeIndex; // 0xCC

    // ── Methods ──
    public void Initiate(){} // RVA: 0x7FFAC3006AB0
    public void get_swingDirection(){} // RVA: 0x7FFAC3006B40
    public void StoreDefaultLocalState(){} // RVA: 0x7FFAC3006DA0
    public void FixTransform(){} // RVA: 0x7FFAC3006E90
    public void get_isNodeBone(){} // RVA: 0x7FFAC3006F80
    public void SetLength(){} // RVA: 0x7FFAC3006F90
    public void SetLocalSwingAxis(){} // RVA: 0x7FFAC3007150 | overloaded x2
    public void SetLocalTwistAxis(){} // RVA: 0x7FFAC3007510
    public void SetPlane(){} // RVA: 0x7FFAC3007830
    public void UpdatePlane(){} // RVA: 0x7FFAC3007A00
    public void SetIKPosition(){} // RVA: 0x7FFAC3007DE0
    public void MaintainRotation(){} // RVA: 0x7FFAC3007E70
    public void SetToIKPosition(){} // RVA: 0x7FFAC3007EF0
    public void FixToNode(){} // RVA: 0x7FFAC3007F70
    public void GetPlanePosition(){} // RVA: 0x7FFAC30081B0
    public void PositionToPlane(){} // RVA: 0x7FFAC3008460
    public void RotateToPlane(){} // RVA: 0x7FFAC30084F0
    public void Swing(){} // RVA: 0x7FFAC3008920 | overloaded x2
    public void Twist(){} // RVA: 0x7FFAC3008F10
    public void RotateToMaintain(){} // RVA: 0x7FFAC3009540
    public void RotateToEffector(){} // RVA: 0x7FFAC30096A0
    public void GetTargetRotation(){} // RVA: 0x7FFAC30099A0
    public void get_lastAnimatedTargetRotation(){} // RVA: 0x7FFAC3009C50
    public void .ctor(){} // RVA: 0x7FFAC300A020
}

public class BoneVisualization : Object
{
    public UnityEngine.GameObject BoneGO; // 0x10
    public UnityEngine.Transform BoneBegin; // 0x18
    public UnityEngine.Transform BoneEnd; // 0x20
    public UnityEngine.LineRenderer Line; // 0x28
    public UnityEngine.Material RenderMaterial; // 0x30
    public UnityEngine.Material SystemGestureMaterial; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC895CCF0
    public void Update(){} // RVA: 0x7FFAC895D430
}

public class BoolChildrenSection : ChildrenSection`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACB8D3280
}

public class BoolDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AE32D0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class BoolEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACB7637A0
}

public class BoolGenerator : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5CAAD40
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC3AE3450
}

public class BoolMonitor : Object
{
    public string m_name; // 0x10
    public BoolGenerator m_generator; // 0x18
    public bool m_prevValue; // 0x20
    public bool m_currentValue; // 0x21
    public bool m_currentValueRecentlyChanged; // 0x22
    public float m_displayTimeout; // 0x24
    public float m_displayTimer; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8932840
    public void Update(){} // RVA: 0x7FFAC89329A0
    public void AppendToStringBuilder(){} // RVA: 0x7FFAC8932A70
}

public class BorderParams : ValueType
{
    public UnityEngine.Rect rect; // 0x10
    public UnityEngine.Color playmodeTintColor; // 0x20
    public UnityEngine.Color leftColor; // 0x30
    public UnityEngine.Color topColor; // 0x40
    public UnityEngine.Color rightColor; // 0x50
    public UnityEngine.Color bottomColor; // 0x60
    public float leftWidth; // 0x70
    public float topWidth; // 0x74
    public float rightWidth; // 0x78
    public float bottomWidth; // 0x7C
    public UnityEngine.Vector2 topLeftRadius; // 0x80
    public UnityEngine.Vector2 topRightRadius; // 0x88
    public UnityEngine.Vector2 bottomRightRadius; // 0x90
    public UnityEngine.Vector2 bottomLeftRadius; // 0x98
    public UnityEngine.Material material; // 0xA0
    public UnityEngine.UIElements.ColorPage leftColorPage; // 0xA8
    public UnityEngine.UIElements.ColorPage topColorPage; // 0xB0
    public UnityEngine.UIElements.ColorPage rightColorPage; // 0xB8
    public UnityEngine.UIElements.ColorPage bottomColorPage; // 0xC0

    // ── Methods ──
    public void ToNativeParams(){} // RVA: 0x7FFAC9BCADF0
}

public class BoringBioHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC8E2D950
}

public class BoringKeyHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC8E33C80
}

public class BoringPkcs12Handle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC8E352A0
}

public class BoringSslCtxHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC93735A0
}

public class BoringSslHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC9370B80
}

public class BoringX509ChainHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC9375DA0
}

public class BoringX509Handle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC9375340
    public void StealHandle(){} // RVA: 0x7FFAC93753D0
}

public class BoringX509LookupHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC9376DB0
}

public class BoringX509LookupMonoHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC93779E0
}

public class BoringX509NameHandle : MonoBtlsHandle
{
    public bool dontFree; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9379120
    public void ReleaseHandle(){} // RVA: 0x7FFAC9379150
}

public class BoringX509StoreCtxHandle : MonoBtlsHandle
{
    public bool dontFree; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9379120
    public void ReleaseHandle(){} // RVA: 0x7FFAC937B6C0
}

public class BoringX509StoreHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC937A260
}

public class BoringX509VerifyParamHandle : MonoBtlsHandle
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E2D900
    public void ReleaseHandle(){} // RVA: 0x7FFAC937CE90
}

public class BoundaryGeometry : ValueType
{
    public 0x6B1A71B0 BoundaryType; // 0x10
    public Vector3f[] Points; // 0x18
    public int PointsCount; // 0x20
}

public class BoundaryTestResult : ValueType
{
    public bool IsTriggering; // 0x10
    public float ClosestDistance; // 0x14
    public UnityEngine.Vector3 ClosestPoint; // 0x18
    public UnityEngine.Vector3 ClosestPointNormal; // 0x24
}

public class BoundedChannelReader : ChannelReader`1
{
    public System.Threading.Channels.BoundedChannel`1<T> _parent;
    public System.Threading.Channels.AsyncOperation`1<T> _readerSingleton;
    public System.Threading.Channels.AsyncOperation`1<bool> _waiterSingleton;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void TryRead(){} // RVA: 0x7FFAC2C59F60
    public void WaitToReadAsync(){}
    public void DequeueItemAndPostProcess(){} // RVA: 0x7FFAC2E8DC40
}

public class BoundedChannelWriter : ChannelWriter`1
{
    public System.Threading.Channels.BoundedChannel`1<T> _parent;
    public System.Threading.Channels.VoidAsyncOperationWithData`1<T> _writerSingleton;
    public System.Threading.Channels.AsyncOperation`1<bool> _waiterSingleton;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void TryComplete(){} // RVA: 0x7FFAC2C59F60
    public void TryWrite(){} // RVA: 0x7FFAC2E8DC40
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7FFAC2E8DC40
}

public class BoundingBox : Object
{
    public Google.Protobuf.MessageParser`1<BoundingBox> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Xmin;
    public int HasXmin; // 0x8
    public int Ymin; // 0x1C
    public int HasYmin;
    public int Width; // 0xC
    public int HasWidth; // 0x20
    public int Height;
    public int HasHeight; // 0x10
    public int width_; // 0x24
    public int HeightFieldNumber;
    public int HeightDefaultValue; // 0x14
    public int height_; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC82B0260
    public void get_Descriptor(){} // RVA: 0x7FFAC82B02C0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82B0340
    public void .ctor(){} // RVA: 0x7FFAC8287420 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC82B03F0
    public void get_Xmin(){} // RVA: 0x7FFAC82B0520
    public void set_Xmin(){} // RVA: 0x7FFAC81F3760
    public void get_HasXmin(){} // RVA: 0x7FFAC81F3770
    public void ClearXmin(){} // RVA: 0x7FFAC81F3780
    public void get_Ymin(){} // RVA: 0x7FFAC82B0590
    public void set_Ymin(){} // RVA: 0x7FFAC81F3800
    public void get_HasYmin(){} // RVA: 0x7FFAC81F3810
    public void ClearYmin(){} // RVA: 0x7FFAC81F3820
    public void get_Width(){} // RVA: 0x7FFAC82B0600
    public void set_Width(){} // RVA: 0x7FFAC82834A0
    public void get_HasWidth(){} // RVA: 0x7FFAC81F6A10
    public void ClearWidth(){} // RVA: 0x7FFAC81F6A20
    public void get_Height(){} // RVA: 0x7FFAC82B0670
    public void set_Height(){} // RVA: 0x7FFAC8286700
    public void get_HasHeight(){} // RVA: 0x7FFAC81F6FD0
    public void ClearHeight(){} // RVA: 0x7FFAC81F6FE0
    public void Equals(){} // RVA: 0x7FFAC82B0810 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC82B0910
    public void ToString(){} // RVA: 0x7FFAC82B09B0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82B0A00
    public void CalculateSize(){} // RVA: 0x7FFAC82B0AE0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8287E90
    public void .cctor(){} // RVA: 0x7FFAC82B0D60
}

public class BoundsEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC94FD1D0
    public void GetHashCode(){} // RVA: 0x7FFAC94FD260
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class BoundsIntEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC94FD530
    public void GetHashCode(){} // RVA: 0x7FFAC94FD650
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Boundsf : ValueType
{
    public Vector3f Pos; // 0x10
    public Size3f Size; // 0x1C
}

public class BoxAvoidance : Object
{
    public System.Func`2<T,int> _wrapper;

    // ── Methods ──
    public void ToInt(){} // RVA: 0x7FFAC2E8DC40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class BoxBoundariesIndices : Object
{
    public Google.Protobuf.MessageParser`1<BoxBoundariesIndices> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Ymin; // 0x8
    public int HasYmin; // 0x1C
    public int Xmin; // 0xC
    public int HasXmin; // 0x20
    public int Ymax; // 0x10
    public int HasYmax; // 0x24
    public int Xmax; // 0x14
    public int HasXmax; // 0x28

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC8287290
    public void get_Descriptor(){} // RVA: 0x7FFAC82872F0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8287370
    public void .ctor(){} // RVA: 0x7FFAC8287420 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC8287520
    public void get_Ymin(){} // RVA: 0x7FFAC8287650
    public void set_Ymin(){} // RVA: 0x7FFAC81F3760
    public void get_HasYmin(){} // RVA: 0x7FFAC81F3770
    public void ClearYmin(){} // RVA: 0x7FFAC81F3780
    public void get_Xmin(){} // RVA: 0x7FFAC82876C0
    public void set_Xmin(){} // RVA: 0x7FFAC81F3800
    public void get_HasXmin(){} // RVA: 0x7FFAC81F3810
    public void ClearXmin(){} // RVA: 0x7FFAC81F3820
    public void get_Ymax(){} // RVA: 0x7FFAC8287730
    public void set_Ymax(){} // RVA: 0x7FFAC82834A0
    public void get_HasYmax(){} // RVA: 0x7FFAC81F6A10
    public void ClearYmax(){} // RVA: 0x7FFAC81F6A20
    public void get_Xmax(){} // RVA: 0x7FFAC82877A0
    public void set_Xmax(){} // RVA: 0x7FFAC8286700
    public void get_HasXmax(){} // RVA: 0x7FFAC81F6FD0
    public void ClearXmax(){} // RVA: 0x7FFAC81F6FE0
    public void Equals(){} // RVA: 0x7FFAC8287940 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC8287A40
    public void ToString(){} // RVA: 0x7FFAC8287AE0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8287B30
    public void CalculateSize(){} // RVA: 0x7FFAC8287C10
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8287E90
    public void .cctor(){} // RVA: 0x7FFAC8287F80
}

public class BrainEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC47F74A0
}

public class BrainFrame : Object
{
    public int Active; // 0x10
    public Cinemachine.CinemachineBlend blend; // 0x18
    public Cinemachine.CinemachineBlend workingBlend; // 0x20
    public Cinemachine.BlendSourceVirtualCamera workingBlendSource; // 0x28
    public float deltaTimeOverride; // 0x30
    public float blendStartPosition; // 0x34

    // ── Methods ──
    public void get_Active(){} // RVA: 0x7FFAC47F75C0
    public void .ctor(){} // RVA: 0x7FFAC47F75E0
}

public class BrainpoolP160r1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD67F90
    public void .cctor(){} // RVA: 0x7FFACBD681E0
}

public class BrainpoolP160t1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD68280
    public void .cctor(){} // RVA: 0x7FFACBD684D0
}

public class BrainpoolP192r1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD68570
    public void .cctor(){} // RVA: 0x7FFACBD687C0
}

public class BrainpoolP192t1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD68860
    public void .cctor(){} // RVA: 0x7FFACBD68AB0
}

public class BrainpoolP224r1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD68B50
    public void .cctor(){} // RVA: 0x7FFACBD68DA0
}

public class BrainpoolP224t1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD68E40
    public void .cctor(){} // RVA: 0x7FFACBD69090
}

public class BrainpoolP256r1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD69130
    public void .cctor(){} // RVA: 0x7FFACBD69380
}

public class BrainpoolP256t1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD69420
    public void .cctor(){} // RVA: 0x7FFACBD69670
}

public class BrainpoolP320r1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD69710
    public void .cctor(){} // RVA: 0x7FFACBD69960
}

public class BrainpoolP320t1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD69A00
    public void .cctor(){} // RVA: 0x7FFACBD69C50
}

public class BrainpoolP384r1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD69CF0
    public void .cctor(){} // RVA: 0x7FFACBD69F40
}

public class BrainpoolP384t1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD69FE0
    public void .cctor(){} // RVA: 0x7FFACBD6A230
}

public class BrainpoolP512r1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD6A2D0
    public void .cctor(){} // RVA: 0x7FFACBD6A520
}

public class BrainpoolP512t1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD6A5C0
    public void .cctor(){} // RVA: 0x7FFACBD6A810
}

public class Bucket : Object
{
    public int Id;
    public T[][] _buffers;
    public int _poolId;
    public System.Threading.SpinLock _lock;
    public int _index;

    // ── Methods ──
    public void .ctor(){}
    public void get_Id(){} // RVA: 0x7FFAC2C59960
    public void Rent(){} // RVA: 0x7FFAC2C58E90
    public void Return(){} // RVA: 0x7FFAC2C70A40
}

public class BucketInfo : Object
{
    public string bucket; // 0x10
    public MatchIdDelegate idMatch; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Buf12 : ValueType
{
    public uint Low64; // 0x10
    public uint High64; // 0x14
    public uint U2; // 0x18
    public ulong ulo64LE; // 0x10
    public ulong uhigh64LE; // 0x14

    // ── Methods ──
    public void get_Low64(){} // RVA: 0x7FFAC51D9A30
    public void set_Low64(){} // RVA: 0x7FFAC45BB120
    public void get_High64(){} // RVA: 0x7FFAC86B94A0
    public void set_High64(){} // RVA: 0x7FFAC86B94B0
}

public class Buf16 : ValueType
{
    public uint Low64; // 0x10
    public uint High64; // 0x14
    public uint U2; // 0x18
    public uint U3; // 0x1C
    public ulong ulo64LE; // 0x10
    public ulong uhigh64LE; // 0x18

    // ── Methods ──
    public void get_Low64(){} // RVA: 0x7FFAC51D9A30
    public void set_Low64(){} // RVA: 0x7FFAC45BB120
    public void get_High64(){} // RVA: 0x7FFAC86B4B80
    public void set_High64(){} // RVA: 0x7FFAC4A068C0
}

public class Buf24 : ValueType
{
    public uint Low64; // 0x10
    public uint Mid64; // 0x14
    public uint High64; // 0x18
    public uint U3; // 0x1C
    public uint U4; // 0x20
    public uint U5; // 0x24
    public ulong ulo64LE; // 0x10
    public ulong umid64LE; // 0x18
    public ulong uhigh64LE; // 0x20

    // ── Methods ──
    public void get_Low64(){} // RVA: 0x7FFAC51D9A30
    public void set_Low64(){} // RVA: 0x7FFAC45BB120
    public void set_Mid64(){} // RVA: 0x7FFAC4A068C0
    public void set_High64(){} // RVA: 0x7FFAC441EFB0
}

public class Buf28 : ValueType
{
    public Buf24 Buf24; // 0x10
    public uint U6; // 0x28
}
