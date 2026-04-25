// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 77
// Methods: 283

public class FILE_BASIC_INFO : ValueType
{
    public long CreationTime; // 0x10
    public long LastAccessTime; // 0x18
    public long LastWriteTime; // 0x20
    public long ChangeTime; // 0x28
    public uint FileAttributes; // 0x30
}

public class FILE_FULL_DIR_INFORMATION : ValueType
{
    public uint FileName; // 0x10
    public uint FileIndex; // 0x14
    public LongFileTime CreationTime; // 0x18
    public LongFileTime LastAccessTime; // 0x20
    public LongFileTime LastWriteTime; // 0x28
    public LongFileTime ChangeTime; // 0x30
    public long EndOfFile; // 0x38
    public long AllocationSize; // 0x40
    public 0x6B0E2B78 FileAttributes; // 0x48
    public uint FileNameLength; // 0x4C
    public uint EaSize; // 0x50
    public char _fileName; // 0x54

    // ── Methods ──
    public void get_FileName(){} // RVA: 0x7FFAC838AAD0
    public void GetNextInfo(){} // RVA: 0x7FFAC838AB40
}

public class FILE_TIME : ValueType
{
    public uint dwLowDateTime; // 0x10
    public uint dwHighDateTime; // 0x14

    // ── Methods ──
    public void ToTicks(){} // RVA: 0x7FFAC838A340
    public void ToDateTimeOffset(){} // RVA: 0x7FFAC838A350
}

public class FaceExpressionStatus : ValueType
{
    public bool IsValid; // 0x10
    public bool IsEyeFollowingBlendshapesValid; // 0x11
}

public class FaceExpressionStatusInternal : ValueType
{
    public 0x6B1A5C08 IsValid; // 0x10
    public 0x6B1A5C08 IsEyeFollowingBlendshapesValid; // 0x14

    // ── Methods ──
    public void ToFaceExpressionStatus(){} // RVA: 0x7FFAC89086C0
}

public class FaceExpressionsEnumerator : ValueType
{
    public float[] Current; // 0x10
    public int System.Collections.IEnumerator.Current; // 0x18
    public int _count; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC88A7380
    public void MoveNext(){} // RVA: 0x7FFAC88A7400
    public void get_Current(){} // RVA: 0x7FFAC88A7410
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC88A7440
    public void Reset(){} // RVA: 0x7FFAC589EAA0
    public void Dispose(){} // RVA: 0x7FFAC2F21310
}

public class FaceState : ValueType
{
    public float[] ExpressionWeights; // 0x10
    public float[] ExpressionWeightConfidences; // 0x18
    public FaceExpressionStatus Status; // 0x20
    public double Time; // 0x28
}

public class FaceStateInternal : ValueType
{
    public float ExpressionWeights_0; // 0x10
    public float ExpressionWeights_1; // 0x14
    public float ExpressionWeights_2; // 0x18
    public float ExpressionWeights_3; // 0x1C
    public float ExpressionWeights_4; // 0x20
    public float ExpressionWeights_5; // 0x24
    public float ExpressionWeights_6; // 0x28
    public float ExpressionWeights_7; // 0x2C
    public float ExpressionWeights_8; // 0x30
    public float ExpressionWeights_9; // 0x34
    public float ExpressionWeights_10; // 0x38
    public float ExpressionWeights_11; // 0x3C
    public float ExpressionWeights_12; // 0x40
    public float ExpressionWeights_13; // 0x44
    public float ExpressionWeights_14; // 0x48
    public float ExpressionWeights_15; // 0x4C
    public float ExpressionWeights_16; // 0x50
    public float ExpressionWeights_17; // 0x54
    public float ExpressionWeights_18; // 0x58
    public float ExpressionWeights_19; // 0x5C
    public float ExpressionWeights_20; // 0x60
    public float ExpressionWeights_21; // 0x64
    public float ExpressionWeights_22; // 0x68
    public float ExpressionWeights_23; // 0x6C
    public float ExpressionWeights_24; // 0x70
    public float ExpressionWeights_25; // 0x74
    public float ExpressionWeights_26; // 0x78
    public float ExpressionWeights_27; // 0x7C
    public float ExpressionWeights_28; // 0x80
    public float ExpressionWeights_29; // 0x84
    public float ExpressionWeights_30; // 0x88
    public float ExpressionWeights_31; // 0x8C
    public float ExpressionWeights_32; // 0x90
    public float ExpressionWeights_33; // 0x94
    public float ExpressionWeights_34; // 0x98
    public float ExpressionWeights_35; // 0x9C
    public float ExpressionWeights_36; // 0xA0
    public float ExpressionWeights_37; // 0xA4
    public float ExpressionWeights_38; // 0xA8
    public float ExpressionWeights_39; // 0xAC
    public float ExpressionWeights_40; // 0xB0
    public float ExpressionWeights_41; // 0xB4
    public float ExpressionWeights_42; // 0xB8
    public float ExpressionWeights_43; // 0xBC
    public float ExpressionWeights_44; // 0xC0
    public float ExpressionWeights_45; // 0xC4
    public float ExpressionWeights_46; // 0xC8
    public float ExpressionWeights_47; // 0xCC
    public float ExpressionWeights_48; // 0xD0
    public float ExpressionWeights_49; // 0xD4
    public float ExpressionWeights_50; // 0xD8
    public float ExpressionWeights_51; // 0xDC
    public float ExpressionWeights_52; // 0xE0
    public float ExpressionWeights_53; // 0xE4
    public float ExpressionWeights_54; // 0xE8
    public float ExpressionWeights_55; // 0xEC
    public float ExpressionWeights_56; // 0xF0
    public float ExpressionWeights_57; // 0xF4
    public float ExpressionWeights_58; // 0xF8
    public float ExpressionWeights_59; // 0xFC
    public float ExpressionWeights_60; // 0x100
    public float ExpressionWeights_61; // 0x104
    public float ExpressionWeights_62; // 0x108
    public float ExpressionWeightConfidences_0; // 0x10C
    public float ExpressionWeightConfidences_1; // 0x110
    public FaceExpressionStatusInternal Status; // 0x114
    public double Time; // 0x120
}

public class FacetsCompiler : ValueType
{
    public System.Xml.Schema.DatatypeImplementation datatype; // 0x10
    public System.Xml.Schema.RestrictionFacets derivedRestriction; // 0x18
    public 0x6B160980 baseFlags; // 0x20
    public 0x6B160980 baseFixedFlags; // 0x24
    public 0x6B160980 validRestrictionFlags; // 0x28
    public System.Xml.Schema.XmlSchemaDatatype nonNegativeInt; // 0x30
    public System.Xml.Schema.XmlSchemaDatatype builtInType; // 0x38
    public 0x6B1655D0 builtInEnum; // 0x40
    public bool firstPattern; // 0x44
    public System.Text.StringBuilder regStr; // 0x48
    public System.Xml.Schema.XmlSchemaPatternFacet pattern_facet; // 0x50
    public Map[] c_map;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9297690
    public void CompileLengthFacet(){} // RVA: 0x7FFAC9297AB0
    public void CompileMinLengthFacet(){} // RVA: 0x7FFAC9297F40
    public void CompileMaxLengthFacet(){} // RVA: 0x7FFAC9298330
    public void CompilePatternFacet(){} // RVA: 0x7FFAC9298720
    public void CompileEnumerationFacet(){} // RVA: 0x7FFAC9298980
    public void CompileWhitespaceFacet(){} // RVA: 0x7FFAC9298B80
    public void CompileMaxInclusiveFacet(){} // RVA: 0x7FFAC9299060
    public void CompileMaxExclusiveFacet(){} // RVA: 0x7FFAC92992E0
    public void CompileMinInclusiveFacet(){} // RVA: 0x7FFAC9299560
    public void CompileMinExclusiveFacet(){} // RVA: 0x7FFAC92997F0
    public void CompileTotalDigitsFacet(){} // RVA: 0x7FFAC9299A80
    public void CompileFractionDigitsFacet(){} // RVA: 0x7FFAC9299E40
    public void FinishFacetCompile(){} // RVA: 0x7FFAC929A180
    public void CheckValue(){} // RVA: 0x7FFAC929A520
    public void CompileFacetCombinations(){} // RVA: 0x7FFAC929AC20
    public void CopyFacetsFromBaseType(){} // RVA: 0x7FFAC929B1E0
    public void ParseFacetValue(){} // RVA: 0x7FFAC929B9A0
    public void Preprocess(){} // RVA: 0x7FFAC929BB50
    public void CheckProhibitedFlag(){} // RVA: 0x7FFAC929BE10
    public void CheckDupFlag(){} // RVA: 0x7FFAC929BEB0
    public void SetFlag(){} // RVA: 0x7FFAC929BF90 | overloaded x2
    public void .cctor(){} // RVA: 0x7FFAC929BFC0
}

public class FailInfo : DerBitString
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBCF7490
}

public class FakeDelegate : Object
{
    public System.Reflection.MethodInfo Method; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void get_Method(){} // RVA: 0x7FFAC2F3C380
}

public class Fallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2C58F40
    public void BeginInvoke(){} // RVA: 0x7FFAC2C6AE80
    public void EndInvoke(){} // RVA: 0x7FFAC2C58F40
}

public class FallbackKeyComparer`1 : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class FallbackMaterial : Object
{
    public long fallbackID; // 0x10
    public UnityEngine.Material sourceMaterial; // 0x18
    public int sourceMaterialCRC; // 0x20
    public UnityEngine.Material fallbackMaterial; // 0x28
    public int count; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class FallbackWrapper`1 : Object
{
    public System.Collections.Generic.IEnumerable`1<T> Count;
    public System.Collections.Generic.IList`1<T> Item;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Count(){} // RVA: 0x7FFAC2C59960
    public void get_Item(){} // RVA: 0x7FFAC2E8DC40
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class Fallback`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class FastReducer : ValueType
{
    public uint[] _modulus; // 0x10
    public uint[] _mu; // 0x18
    public uint[] _q1; // 0x20
    public uint[] _q2; // 0x28
    public int _muLength; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8FC30F0
    public void Reduce(){} // RVA: 0x7FFAC8FC33A0
    public void DivMul(){} // RVA: 0x7FFAC8FC34A0
    public void SubMod(){} // RVA: 0x7FFAC8FC3630
}

public class FeatureFidelityGroup : Object
{
    public 0x6B1A4FA8 targetFeatureEnabled; // 0x10
    public 0x6B1A4F50 targetFeatureFidelity; // 0x14
    public 0x6B1A4FA8 currentFeatureEnabled; // 0x18
    public 0x6B1A4F50 currentFeatureFidelity; // 0x1C
    public System.Nullable`1<0x6B1A4FA8> lastSetTargetFeatureEnabled; // 0x20
    public System.Nullable`1<0x6B1A4F50> lastSetTargetFeatureFidelity; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC88D3B50
}

public class FeatureState : ValueType
{
    public 0x6B1A6708 enableState; // 0x10
    public 0x6B1A66B0 fidelity; // 0x14
    public FeatureState Default;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC33D6D50
    public void .cctor(){} // RVA: 0x7FFAC8906A60
}

public class FieldCollection : Object
{
    public Google.Protobuf.Reflection.MessageDescriptor Item; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void InDeclarationOrder(){} // RVA: 0x7FFAC3773190
    public void InFieldNumberOrder(){} // RVA: 0x7FFAC3510100
    public void get_Item(){} // RVA: 0x7FFAC82202D0
}

public class FieldDescription : ValueType
{
    public string name;
    public string ussName;
    public System.Func`2<V,T> read;
    public WriteDelegate<V,V,T> write;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C7B8C0
}

public class FileDescriptor : ApiModel
{
    public 0x6B0ADF38 status; // 0x68
    public string url; // 0x70
    public string md5; // 0x78
    public 0x6B0ADF90 category; // 0x80
    public int sizeInBytes; // 0x84
    public string fileName; // 0x88
    public string uploadId; // 0x90
    public System.Collections.Generic.List`1<string> cdns; // 0x98

    // ── Methods ──
    public void get_status(){} // RVA: 0x7FFAC47BAB50
    public void set_status(){} // RVA: 0x7FFAC47BAB60
    public void get_url(){} // RVA: 0x7FFAC2FE9590
    public void set_url(){} // RVA: 0x7FFAC2FE95A0
    public void get_md5(){} // RVA: 0x7FFAC30E5600
    public void set_md5(){} // RVA: 0x7FFAC30E06F0
    public void get_category(){} // RVA: 0x7FFAC35729C0
    public void set_category(){} // RVA: 0x7FFAC3572BF0
    public void get_sizeInBytes(){} // RVA: 0x7FFAC46D5110
    public void set_sizeInBytes(){} // RVA: 0x7FFAC46D5150
    public void get_fileName(){} // RVA: 0x7FFAC2F60010
    public void set_fileName(){} // RVA: 0x7FFAC354E300
    public void get_uploadId(){} // RVA: 0x7FFAC32EF640
    public void set_uploadId(){} // RVA: 0x7FFAC354E360
    public void get_cdns(){} // RVA: 0x7FFAC354DFB0
    public void set_cdns(){} // RVA: 0x7FFAC354E3C0
    public void .ctor(){} // RVA: 0x7FFACBE75D40
    public void Init(){} // RVA: 0x7FFACBE75E70
}

public class FillCollection`1 : Object
{
    public int Count;
    public FillCollection`1<T> IsReadOnly; // 0xFFFF
    public int <Count>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void get_Count(){} // RVA: 0x7FFAC2C59960
    public void set_Count(){} // RVA: 0x7FFAC2C70ED0
    public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
    public void CopyTo(){} // RVA: 0x7FFAC2C77970
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void Clear(){} // RVA: 0x7FFAC2C70980
    public void Contains(){} // RVA: 0x7FFAC2E8DC40
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void Remove(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class FilterBlockCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class FilterCacheItem : Object
{
    public System.ComponentModel.Design.ITypeDescriptorFilterService _filterService; // 0x10
    public System.Collections.ICollection FilteredMembers; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void IsValid(){} // RVA: 0x7FFAC87CF460
}

public class FilterCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC884A370
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC884A450
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class FilterReadDelegate : MonoBehaviour
{
    public Oculus.Platform.VoipAudioSourceHiLevel parent; // 0x20
    public float[] scratchBuffer; // 0x28

    // ── Methods ──
    public void Awake(){} // RVA: 0x7FFAC8876F30
    public void OnAudioFilterRead(){} // RVA: 0x7FFAC8877050
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class FinalizationHelper : Object
{
    public LinkedSlotVolatile<T>[] SlotArray;
    public bool m_trackAllValues;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C76500
    public void Finalize(){} // RVA: 0x7FFAC2C70980
}

public class FindPredicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2C59F60
}

public class FindTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}

public class Finger : Object
{
    public Retargetable metacarpal; // 0x10
    public Retargetable proximal; // 0x18
    public Retargetable middle; // 0x20
    public Retargetable distal; // 0x28
    public UnityEngine.Transform aux; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC300D340
}

public class FingerAndTouchState : ValueType
{
    public 0x6B14EA20 updateMask; // 0x10
    public UnityEngine.InputSystem.EnhancedTouch.Finger[] fingers; // 0x18
    public UnityEngine.InputSystem.EnhancedTouch.Finger[] activeFingers; // 0x20
    public UnityEngine.InputSystem.EnhancedTouch.Touch[] activeTouches; // 0x28
    public int activeFingerCount; // 0x30
    public int activeTouchCount; // 0x34
    public int totalFingerCount; // 0x38
    public uint lastId; // 0x3C
    public bool haveBuiltActiveTouches; // 0x40
    public bool haveActiveTouchesNeedingRefreshNextUpdate; // 0x41
    public UnityEngine.InputSystem.LowLevel.InputStateHistory`1<UnityEngine.InputSystem.LowLevel.TouchState> activeTouchState; // 0x48

    // ── Methods ──
    public void AddFingers(){} // RVA: 0x7FFAC966BDF0
    public void RemoveFingers(){} // RVA: 0x7FFAC966C020
    public void Destroy(){} // RVA: 0x7FFAC966C150
    public void UpdateActiveFingers(){} // RVA: 0x7FFAC966C220
    public void UpdateActiveTouches(){} // RVA: 0x7FFAC966C370
}

public class FingerColliders : Object
{
    public UnityEngine.Transform[] Item; // 0x10
    public UnityEngine.Transform[] indexColliders; // 0x18
    public UnityEngine.Transform[] middleColliders; // 0x20
    public UnityEngine.Transform[] ringColliders; // 0x28
    public UnityEngine.Transform[] pinkyColliders; // 0x30

    // ── Methods ──
    public void get_Item(){} // RVA: 0x7FFAC8CD7210
    public void set_Item(){} // RVA: 0x7FFAC8CD7250
    public void .ctor(){} // RVA: 0x7FFAC8CD72B0
}

public class FingerData : ValueType
{
    public 0x6B000878 Finger; // 0x10
    public JointData[] Joints; // 0x18
    public UnityEngine.Vector3 TipPosition; // 0x20
}

public class FinishFrameRendering : ValueType
{
}

public class FirstQueryMatcher : SingleQueryMatcher
{
    public FirstQueryMatcher Instance;

    // ── Methods ──
    public void OnRuleMatchedElement(){} // RVA: 0x7FFAC9C24650
    public void CreateNew(){} // RVA: 0x7FFAC9C246B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC9C246F0
}

public class FirstValueToUniTaskObserver`1 : Object
{
    public System.Action`1<object> callback;
    public Cysharp.Threading.Tasks.UniTaskCompletionSource`1<T> promise;
    public Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration registration;
    public bool hasValue;

    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFAC2C70A10
    public void OnNext(){} // RVA: 0x7FFAC2E8DC40
    public void OnError(){} // RVA: 0x7FFAC2C70A40
    public void OnCompleted(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class FixedMemoryStream : MemoryStream
{
    public long maxSize; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8F9C2C0
    public void CheckOverflow(){} // RVA: 0x7FFAC8F9C2F0
    public void WriteByte(){} // RVA: 0x7FFAC8F9C3B0
    public void Write(){} // RVA: 0x7FFAC8F9C4E0
}

public class FixedPointCallback : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint m_p; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Precompute(){} // RVA: 0x7FFACBA7B8F0
    public void CheckExisting(){} // RVA: 0x7FFACBA7BEB0
    public void CheckTable(){} // RVA: 0x7FFACBA7BF40
}

public class Fixup : Object
{
    public object Callback; // 0x10
    public string[] Ids; // 0x18
    public System.Xml.Serialization.XmlSerializationFixupCallback Source; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC924BBC0
    public void get_Callback(){} // RVA: 0x7FFAC2F4F0C0
    public void get_Ids(){} // RVA: 0x7FFAC2F247C0
    public void get_Source(){} // RVA: 0x7FFAC2F3C380
}

public class FixupCallbackInfo : Object
{
    public System.Xml.Serialization.XmlSerializationReaderInterpreter _sri; // 0x10
    public System.Xml.Serialization.ClassMap _map; // 0x18
    public bool _isValueList; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC84C0F70
    public void FixupMembers(){} // RVA: 0x7FFAC9252570
}

public class FloatInput : TextValueInput
{
    public object parentFloatField;
    public object allowedCharacters;

    // ── Methods ──
    public void get_parentFloatField(){} // RVA: 0x7FFAC9AB0480
    public void .ctor(){} // RVA: 0x7FFAC9AB0500
    public void get_allowedCharacters(){} // RVA: 0x7FFAC9AB06C0
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9AB0720
    public void ValueToString(){} // RVA: 0x7FFAC9AB0910
    public void StringToValue(){} // RVA: 0x7FFAC9AB09B0
}

public class FloatToBytes : ValueType
{
    public float Real; // 0x10
    public byte byte0; // 0x10
    public byte byte1; // 0x11
    public byte byte2; // 0x12
    public byte byte3; // 0x13
}

public class FloatToUInt32 : ValueType
{
    public float Real; // 0x10
    public uint Int; // 0x10
}

public class FloatTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C767C0
}

public class FocusBasedEventSequenceContext : ValueType
{
    public UnityEngine.UIElements.DefaultEventSystem es; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9B6DF80
    public void Dispose(){} // RVA: 0x7FFAC9B6E0E0
}

public class FocusRingRecord : Object
{
    public int m_AutoIndex; // 0x10
    public UnityEngine.UIElements.Focusable m_Focusable; // 0x18
    public bool m_IsSlot; // 0x20
    public System.Collections.Generic.List`1<FocusRingRecord> m_ScopeNavigationOrder; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class FocusableHierarchyTraversal : ValueType
{
    public UnityEngine.UIElements.VisualElement currentFocusable; // 0x10
    public UnityEngine.Rect validRect; // 0x18
    public bool firstPass; // 0x28
    public ChangeDirection direction; // 0x30

    // ── Methods ──
    public void ValidateHierarchyTraversal(){} // RVA: 0x7FFAC9B96CB0
    public void ValidateElement(){} // RVA: 0x7FFAC9B96DD0
    public void Order(){} // RVA: 0x7FFAC9B96EE0
    public void StrictOrder(){} // RVA: 0x7FFAC9B97010 | overloaded x2
    public void TieBreaker(){} // RVA: 0x7FFAC9B971F0
    public void GetBestOverall(){} // RVA: 0x7FFAC9B97310
}

public class FocusedElement : ValueType
{
    public UnityEngine.UIElements.VisualElement m_SubTreeRoot; // 0x10
    public UnityEngine.UIElements.Focusable m_FocusedElement; // 0x18
}

public class FoldoutList : Object
{
    public System.Collections.Generic.List`1<bool> Item; // 0x10
    public bool Count; // 0x18
    public UnityEngine.Vector2 scrollPos; // 0x1C

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC30B4BF0
    public void IndexOf(){} // RVA: 0x7FFAC30B4C80
    public void set_Count(){} // RVA: 0x7FFAC30B4D10
    public void op_Implicit(){} // RVA: 0x7FFAC30B4DC0
    public void CompareBaseObjects(){} // RVA: 0x7FFAC30B4F30
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC30B4FB0
    public void get_Count(){} // RVA: 0x7FFAC30B5000
    public void get_name(){} // RVA: 0x7FFAC30B5050
    public void set_name(){} // RVA: 0x7FFAC30B50E0
    public void set_Item(){} // RVA: 0x7FFAC30B5240
    public void Instantiate(){} // RVA: 0x7FFAC30B52D0
    public void .ctor(){} // RVA: 0x7FFAC30B5320
    public void Initialize(){} // RVA: 0x7FFAC30B53E0
    public void Equals(){} // RVA: 0x7FFAC30B54C0
    public void GetHashCode(){} // RVA: 0x7FFAC30B5560
    public void get_Item(){} // RVA: 0x7FFAC30B5600
}

public class FontAssetRef : ValueType
{
    public int nameHashCode; // 0x10
    public int familyNameHashCode; // 0x14
    public int styleNameHashCode; // 0x18
    public long familyNameAndStyleHashCode; // 0x20
    public UnityEngine.TextCore.Text.FontAsset fontAsset; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9A43CB0
}

public class FontReferenceMap : ValueType
{
    public UnityEngine.Font font; // 0x10
    public UnityEngine.TextCore.Text.FontAsset fontAsset; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC41AE4B0
}

public class FontTextureRebuildCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class Foot : ValueType
{
    public RootMotion.FinalIK.IKSolver solver; // 0x10
    public UnityEngine.Transform transform; // 0x18
    public UnityEngine.Quaternion rotation; // 0x20
    public Leg leg; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FE7AA0
}

public class Footstep : Object
{
    public float isStepping; // 0x10
    public UnityEngine.Vector3 stepProgress; // 0x14
    public UnityEngine.Vector3 position; // 0x20
    public UnityEngine.Quaternion rotation; // 0x2C
    public UnityEngine.Quaternion stepToRootRot; // 0x3C
    public bool isSupportLeg; // 0x4C
    public float <stepProgress>k__BackingField; // 0x50
    public UnityEngine.Vector3 stepFrom; // 0x54
    public UnityEngine.Vector3 stepTo; // 0x60
    public UnityEngine.Quaternion stepFromRot; // 0x6C
    public UnityEngine.Quaternion stepToRot; // 0x7C
    public UnityEngine.Quaternion footRelativeToRoot; // 0x8C
    public float supportLegW; // 0x9C
    public float supportLegWV; // 0xA0

    // ── Methods ──
    public void get_isStepping(){} // RVA: 0x7FFAC304BF10
    public void get_stepProgress(){} // RVA: 0x7FFAC2F89460
    public void set_stepProgress(){} // RVA: 0x7FFAC2F89470
    public void .ctor(){} // RVA: 0x7FFAC304BF20
    public void Reset(){} // RVA: 0x7FFAC304C2A0
    public void StepTo(){} // RVA: 0x7FFAC304C2F0
    public void UpdateStepping(){} // RVA: 0x7FFAC304C5B0
    public void UpdateStanding(){} // RVA: 0x7FFAC304CA80
    public void Update(){} // RVA: 0x7FFAC304CD00
}

public class ForDevice : Object
{
    public System.IObserver`1<UnityEngine.InputSystem.LowLevel.InputEventPtr> m_Observer; // 0x10
    public UnityEngine.InputSystem.InputDevice m_Device; // 0x18
    public System.Type m_DeviceType; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC956C840
    public void OnCompleted(){} // RVA: 0x7FFAC2F21310
    public void OnError(){} // RVA: 0x7FFAC956C950
    public void OnNext(){} // RVA: 0x7FFAC956C9A0
}

public class Force : ValueType
{
    public Seed4 m_Random; // 0x10
}

public class ForceDropDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ForceOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9954E70
    public void set_enabled(){} // RVA: 0x7FFAC9954EC0
    public void get_x(){} // RVA: 0x7FFAC9954F20
    public void set_x(){} // RVA: 0x7FFAC9954F90
    public void get_y(){} // RVA: 0x7FFAC9954FF0
    public void set_y(){} // RVA: 0x7FFAC9955060
    public void get_z(){} // RVA: 0x7FFAC99550C0
    public void set_z(){} // RVA: 0x7FFAC9955130
    public void get_xMultiplier(){} // RVA: 0x7FFAC9955190
    public void set_xMultiplier(){} // RVA: 0x7FFAC99551E0
    public void get_yMultiplier(){} // RVA: 0x7FFAC9955240
    public void set_yMultiplier(){} // RVA: 0x7FFAC9955290
    public void get_zMultiplier(){} // RVA: 0x7FFAC99552F0
    public void set_zMultiplier(){} // RVA: 0x7FFAC9955340
    public void get_space(){} // RVA: 0x7FFAC99553A0
    public void set_space(){} // RVA: 0x7FFAC99553F0
    public void get_randomized(){} // RVA: 0x7FFAC9955450
    public void set_randomized(){} // RVA: 0x7FFAC99554A0
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9954E70
    public void set_enabled_Injected(){} // RVA: 0x7FFAC9954EC0
    public void get_x_Injected(){} // RVA: 0x7FFAC9955500
    public void set_x_Injected(){} // RVA: 0x7FFAC9955560
    public void get_y_Injected(){} // RVA: 0x7FFAC99555C0
    public void set_y_Injected(){} // RVA: 0x7FFAC9955620
    public void get_z_Injected(){} // RVA: 0x7FFAC9955680
    public void set_z_Injected(){} // RVA: 0x7FFAC99556E0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFAC9955190
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFAC99551E0
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFAC9955240
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFAC9955290
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFAC99552F0
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFAC9955340
    public void get_space_Injected(){} // RVA: 0x7FFAC99553A0
    public void set_space_Injected(){} // RVA: 0x7FFAC99553F0
    public void get_randomized_Injected(){} // RVA: 0x7FFAC9955450
    public void set_randomized_Injected(){} // RVA: 0x7FFAC99554A0
}

public class FormatLiterals : ValueType
{
    public string Start; // 0x10
    public int DayHourSep; // 0x18
    public int HourMinuteSep; // 0x1C
    public int MinuteSecondSep; // 0x20
    public int SecondFractionSep; // 0x24
    public int End; // 0x28
    public string[] _literals; // 0x30

    // ── Methods ──
    public void get_Start(){} // RVA: 0x7FFAC8555FF0
    public void get_DayHourSep(){} // RVA: 0x7FFAC8556020
    public void get_HourMinuteSep(){} // RVA: 0x7FFAC8556050
    public void get_MinuteSecondSep(){} // RVA: 0x7FFAC8556080
    public void get_SecondFractionSep(){} // RVA: 0x7FFAC85560B0
    public void get_End(){} // RVA: 0x7FFAC85560E0
    public void InitInvariant(){} // RVA: 0x7FFAC8556110
    public void Init(){} // RVA: 0x7FFAC85563C0
}

public class FormatOptions : ValueType
{
    public 0x6B2C3AA8 Uppercase; // 0x10
    public sbyte AlignAndSize; // 0x11
    public byte Specifier; // 0x12
    public bool Lowercase; // 0x13

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3115270
    public void get_Uppercase(){} // RVA: 0x7FFAC90808F0
    public void GetBase(){} // RVA: 0x7FFAC950C6A0
    public void ToString(){} // RVA: 0x7FFAC950C6C0
}

public class FormatParam : ValueType
{
    public int Int32; // 0x10
    public string String; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC60F24C0 | overloaded x2
    public void op_Implicit(){} // RVA: 0x7FFAC833FDC0
    public void get_Int32(){} // RVA: 0x7FFAC4420210
    public void get_String(){} // RVA: 0x7FFAC86AB1E0
    public void get_Object(){} // RVA: 0x7FFAC86AB230
}

public class FormatterInfo : ValueType
{
    public System.Type FormatterType; // 0x10
    public System.Type TargetType; // 0x18
    public System.Type WeakFallbackType; // 0x20
    public bool AskIfCanFormatTypes; // 0x28
    public int Priority; // 0x2C
}

public class FormatterLocatorInfo : ValueType
{
    public VRC.Udon.Serialization.OdinSerializer.IFormatterLocator LocatorInstance; // 0x10
    public int Priority; // 0x18
}

public class FovCache : ValueType
{
    public UnityEngine.Rect mFovSoftGuideRect; // 0x10
    public UnityEngine.Rect mFovHardGuideRect; // 0x20
    public float mFovH; // 0x30
    public float mFov; // 0x34
    public float mOrthoSizeOverDistance; // 0x38
    public float mAspect; // 0x3C
    public UnityEngine.Rect mSoftGuideRect; // 0x40
    public UnityEngine.Rect mHardGuideRect; // 0x50

    // ── Methods ──
    public void UpdateCache(){} // RVA: 0x7FFAC4824D60
    public void ScreenToFOV(){} // RVA: 0x7FFAC4825120
}

public class Fovf : ValueType
{
    public float UpTan; // 0x10
    public float DownTan; // 0x14
    public float LeftTan; // 0x18
    public float RightTan; // 0x1C
}

public class Frame : Object
{
    public int frameNumber; // 0x10
    public int frameDelay; // 0x14
    public float[] Visemes; // 0x18
    public float laughterScore; // 0x20

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC3A73BF0
    public void Equals(){} // RVA: 0x7FFAC3A73C40
    public void GetHashCode(){} // RVA: 0x7FFAC3A73C40
    public void op_Implicit(){} // RVA: 0x7FFAC3A73CA0
    public void CompareBaseObjects(){} // RVA: 0x7FFAC3A73BF0
    public void .ctor(){} // RVA: 0x7FFAC3A73D30
    public void Initialize(){} // RVA: 0x7FFAC3A73E00
    public void get_name(){} // RVA: 0x7FFAC3A73E90
    public void set_name(){} // RVA: 0x7FFAC3A73BF0
}

public class FrameHeader : ValueType
{
    public uint protocolIdentifier; // 0x10
    public int payloadType; // 0x14
    public int payloadLength; // 0x18
    public int StructSize;

    // ── Methods ──
    public void ToBytes(){} // RVA: 0x7FFAC8948D50
    public void FromBytes(){} // RVA: 0x7FFAC8948F60
}

public class FrameReadyEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class FreeHGlobalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DFD0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class FromAsyncTrimPromise`1 : Task`1
{
    public System.AsyncCallback s_completeFromAsyncResult;
    public T m_thisRef;
    public System.Func`3<T,System.IAsyncResult,T> m_endMethod;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void CompleteFromAsyncResult(){} // RVA: 0x7FFAC2C70A10
    public void Complete(){} // RVA: 0x7FFAC2E8DC40
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class Frp256v1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBE04130
    public void .cctor(){} // RVA: 0x7FFACBE043C0
}

public class Frustum : ValueType
{
    public float nearZ; // 0x10
    public float farZ; // 0x14
    public UnityEngine.Vector2 fov; // 0x18
}

public class Frustumf : ValueType
{
    public float zNear; // 0x10
    public float zFar; // 0x14
    public float fovX; // 0x18
    public float fovY; // 0x1C
}

public class Frustumf2 : ValueType
{
    public float zNear; // 0x10
    public float zFar; // 0x14
    public Fovf Fov; // 0x18
}

public class FullReaderStream : FilterStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBCBF3D0
    public void Read(){} // RVA: 0x7FFACBCBF3E0
}

public class Func`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
}
