// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 77
// Methods: 284

public class FILE_BASIC_INFO : ValueType
{
}

public class FILE_FULL_DIR_INFORMATION : ValueType
{
    public uint NextEntryOffset; // 0x10

    // ── Methods ──
    public void get_FileName(){} // RVA: 0x7FFE867343D0
    public void GetNextInfo(){} // RVA: 0x7FFE86734440
}

public class FILE_TIME : ValueType
{
    // ── Methods ──
    public void ToTicks(){} // RVA: 0x7FFE86733C40
    public void ToDateTimeOffset(){} // RVA: 0x7FFE86733C50
}

public class FaceExpressionStatus : ValueType
{
}

public class FaceExpressionStatusInternal : ValueType
{
    // ── Methods ──
    public void ToFaceExpressionStatus(){} // RVA: 0x7FFE86CB1DB0
}

public class FaceExpressionsEnumerator : ValueType
{
    public float[] _faceExpressions; // 0x10
    public int _index; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86C50A70
    public void MoveNext(){} // RVA: 0x7FFE86C50AF0
    public void get_Current(){} // RVA: 0x7FFE86C50B00
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE86C50B30
    public void Reset(){} // RVA: 0x7FFE83BBA060
    public void Dispose(){} // RVA: 0x7FFE810FB310
}

public class FaceState : ValueType
{
}

public class FaceStateInternal : ValueType
{
}

public class FacetsCompiler : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8763FDD0
    public void CompileLengthFacet(){} // RVA: 0x7FFE876401F0
    public void CompileMinLengthFacet(){} // RVA: 0x7FFE87640680
    public void CompileMaxLengthFacet(){} // RVA: 0x7FFE87640A70
    public void CompilePatternFacet(){} // RVA: 0x7FFE87640E60
    public void CompileEnumerationFacet(){} // RVA: 0x7FFE876410C0
    public void CompileWhitespaceFacet(){} // RVA: 0x7FFE876412C0
    public void CompileMaxInclusiveFacet(){} // RVA: 0x7FFE876417A0
    public void CompileMaxExclusiveFacet(){} // RVA: 0x7FFE87641A20
    public void CompileMinInclusiveFacet(){} // RVA: 0x7FFE87641CA0
    public void CompileMinExclusiveFacet(){} // RVA: 0x7FFE87641F30
    public void CompileTotalDigitsFacet(){} // RVA: 0x7FFE876421C0
    public void CompileFractionDigitsFacet(){} // RVA: 0x7FFE87642580
    public void FinishFacetCompile(){} // RVA: 0x7FFE876428C0
    public void CheckValue(){} // RVA: 0x7FFE87642C60
    public void CompileFacetCombinations(){} // RVA: 0x7FFE87643360
    public void CopyFacetsFromBaseType(){} // RVA: 0x7FFE87643920
    public void ParseFacetValue(){} // RVA: 0x7FFE876440E0
    public void Preprocess(){} // RVA: 0x7FFE87644290
    public void CheckProhibitedFlag(){} // RVA: 0x7FFE87644550
    public void CheckDupFlag(){} // RVA: 0x7FFE876445F0
    public void SetFlag(){} // RVA: 0x7FFE876446D0 | overloaded x2
    public void .cctor(){} // RVA: 0x7FFE87644700
}

public class FailInfo : DerBitString
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A150AB0
}

public class FakeDelegate : Object
{
    public System.Reflection.MethodInfo _method; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void get_Method(){} // RVA: 0x7FFE81116380
}

public class Fallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE80E2E390
    public void BeginInvoke(){} // RVA: 0x7FFE80E403A0
    public void EndInvoke(){} // RVA: 0x7FFE80E2E390
}

public class FallbackKeyComparer`1 : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class FallbackMaterial : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class FallbackWrapper`1 : Object
{
    public System.Collections.Generic.IEnumerable`1<T> _sequence;
    public System.Collections.Generic.IList`1<T> _collection;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Count(){} // RVA: 0x7FFE80E2EDB0
    public void get_Item(){} // RVA: 0x7FFE810A1420
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
}

public class Fallback`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class FastReducer : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8736B8B0
    public void Reduce(){} // RVA: 0x7FFE8736BB60
    public void DivMul(){} // RVA: 0x7FFE8736BC60
    public void SubMod(){} // RVA: 0x7FFE8736BDF0
}

public class FeatureFidelityGroup : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86C7D240
}

public class FeatureState : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8164E250
    public void .cctor(){} // RVA: 0x7FFE86CB0150
}

public class FieldCollection : Object
{
    public Google.Protobuf.Reflection.MessageDescriptor messageDescriptor; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void InDeclarationOrder(){} // RVA: 0x7FFE8189B9F0
    public void InFieldNumberOrder(){} // RVA: 0x7FFE8189BF90
    public void get_Item(){} // RVA: 0x7FFE865C9C10
}

public class FieldDescription : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E50FC0
}

public class FileDescriptor : ApiModel
{
    public 0x664A6D54 _status; // 0x68
    public string _url; // 0x70
    public string _md5; // 0x78
    public 0x664A6DAC _category; // 0x80
    public int _sizeInBytes; // 0x84
    public string _fileName; // 0x88
    public string _uploadId; // 0x90
    public System.Collections.Generic.List`1<string> _cdns; // 0x98

    // ── Methods ──
    public void get_status(){} // RVA: 0x7FFE82A22EF0
    public void set_status(){} // RVA: 0x7FFE82A22F00
    public void get_url(){} // RVA: 0x7FFE811C3590
    public void set_url(){} // RVA: 0x7FFE811C35A0
    public void get_md5(){} // RVA: 0x7FFE81463AE0
    public void set_md5(){} // RVA: 0x7FFE81464570
    public void get_category(){} // RVA: 0x7FFE81D30560
    public void set_category(){} // RVA: 0x7FFE81D307B0
    public void get_sizeInBytes(){} // RVA: 0x7FFE829DF2E0
    public void set_sizeInBytes(){} // RVA: 0x7FFE829DF3B0
    public void get_fileName(){} // RVA: 0x7FFE8113A010
    public void set_fileName(){} // RVA: 0x7FFE81280F90
    public void get_uploadId(){} // RVA: 0x7FFE8154EB60
    public void set_uploadId(){} // RVA: 0x7FFE818CE320
    public void get_cdns(){} // RVA: 0x7FFE817AE360
    public void set_cdns(){} // RVA: 0x7FFE8171B470
    public void .ctor(){} // RVA: 0x7FFE8A2D4DB0
    public void Init(){} // RVA: 0x7FFE8A2D4EE0
}

public class FillCollection`1 : Object
{
    public int <count>P;
    public FillCollection`1<T> Instance; // 0xFFFF

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E46530
    public void get_Count(){} // RVA: 0x7FFE80E2EDB0
    public void set_Count(){} // RVA: 0x7FFE80E46530
    public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
    public void CopyTo(){} // RVA: 0x7FFE80E4D070
    public void Add(){} // RVA: 0x7FFE810A1420
    public void Clear(){} // RVA: 0x7FFE80E45FE0
    public void Contains(){} // RVA: 0x7FFE810A1420
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void Remove(){} // RVA: 0x7FFE810A1420
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
}

public class FilterBlockCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
    public void BeginInvoke(){} // RVA: 0x7FFE81159A60
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class FilterCacheItem : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void IsValid(){} // RVA: 0x7FFE86B78B90
}

public class FilterCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86BF3A60
    public void Invoke(){} // RVA: 0x7FFE81998A70
    public void BeginInvoke(){} // RVA: 0x7FFE86BF3B40
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class FilterReadDelegate : MonoBehaviour
{
    // ── Methods ──
    public void Awake(){} // RVA: 0x7FFE86C20620
    public void OnAudioFilterRead(){} // RVA: 0x7FFE86C20740
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class FinalizationHelper : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4BC00
    public void Finalize(){} // RVA: 0x7FFE80E45FE0
}

public class FindPredicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE80E2F3B0
}

public class FindTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class Finger : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811E7340
}

public class FingerAndTouchState : ValueType
{
    // ── Methods ──
    public void AddFingers(){} // RVA: 0x7FFE87A14550
    public void RemoveFingers(){} // RVA: 0x7FFE87A14780
    public void Destroy(){} // RVA: 0x7FFE87A148B0
    public void UpdateActiveFingers(){} // RVA: 0x7FFE87A14980
    public void UpdateActiveTouches(){} // RVA: 0x7FFE87A14AD0
}

public class FingerColliders : Object
{
    public UnityEngine.Transform[] thumbColliders; // 0x10

    // ── Methods ──
    public void get_Item(){} // RVA: 0x7FFE8707F700
    public void set_Item(){} // RVA: 0x7FFE8707F740
    public void .ctor(){} // RVA: 0x7FFE8707F7A0
}

public class FingerData : ValueType
{
}

public class FinishFrameRendering : ValueType
{
}

public class FirstQueryMatcher : SingleQueryMatcher
{
    // ── Methods ──
    public void OnRuleMatchedElement(){} // RVA: 0x7FFE87FCCEA0
    public void CreateNew(){} // RVA: 0x7FFE87FCCF00
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE87FCCF40
}

public class FirstValueToUniTaskObserver`1 : Object
{
    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFE80E46070
    public void OnNext(){} // RVA: 0x7FFE810A1420
    public void OnError(){} // RVA: 0x7FFE80E460A0
    public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class FixedMemoryStream : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE873446E0
    public void CheckOverflow(){} // RVA: 0x7FFE87344710
    public void WriteByte(){} // RVA: 0x7FFE873447D0
    public void Write(){} // RVA: 0x7FFE87344900
}

public class FixedPointCallback : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Precompute(){} // RVA: 0x7FFE89ED4F10
    public void CheckExisting(){} // RVA: 0x7FFE89ED54D0
    public void CheckTable(){} // RVA: 0x7FFE89ED5560
}

public class Fixup : Object
{
    public object source; // 0x10
    public string[] ids; // 0x18
    public System.Xml.Serialization.XmlSerializationFixupCallback callback; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE875F4330
    public void get_Callback(){} // RVA: 0x7FFE811290C0
    public void get_Ids(){} // RVA: 0x7FFE810FE7C0
    public void get_Source(){} // RVA: 0x7FFE81116380
}

public class FixupCallbackInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8686A7A0
    public void FixupMembers(){} // RVA: 0x7FFE875FACE0
}

public class FloatInput : TextValueInput
{
    // ── Methods ──
    public void get_parentFloatField(){} // RVA: 0x7FFE87E58D20
    public void .ctor(){} // RVA: 0x7FFE87E58DA0
    public void get_allowedCharacters(){} // RVA: 0x7FFE87E58F60
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87E58FC0
    public void ValueToString(){} // RVA: 0x7FFE87E591B0
    public void StringToValue(){} // RVA: 0x7FFE87E59250
}

public class FloatToBytes : ValueType
{
}

public class FloatToUInt32 : ValueType
{
}

public class FloatTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8801F010
}

public class FocusBasedEventSequenceContext : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87F16820
    public void Dispose(){} // RVA: 0x7FFE87F16980
}

public class FocusRingRecord : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class FocusableHierarchyTraversal : ValueType
{
    // ── Methods ──
    public void ValidateHierarchyTraversal(){} // RVA: 0x7FFE87F3F560
    public void ValidateElement(){} // RVA: 0x7FFE87F3F680
    public void Order(){} // RVA: 0x7FFE87F3F790
    public void StrictOrder(){} // RVA: 0x7FFE87F3F8C0 | overloaded x2
    public void TieBreaker(){} // RVA: 0x7FFE87F3FAA0
    public void GetBestOverall(){} // RVA: 0x7FFE87F3FBC0
}

public class FocusedElement : ValueType
{
}

public class FoldoutList : Object
{
    public System.Collections.Generic.List`1<bool> foldouts; // 0x10
    public bool mainFoldout; // 0x18

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFE81293110
    public void .ctor(){} // RVA: 0x7FFE812931C0
    public void set_Item(){} // RVA: 0x7FFE81293280
    public void op_Implicit(){} // RVA: 0x7FFE81293310
    public void get_Item(){} // RVA: 0x7FFE812933A0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFE81293420
    public void GetCachedPtr(){} // RVA: 0x7FFE81293470
    public void get_name(){} // RVA: 0x7FFE812935E0
    public void set_Count(){} // RVA: 0x7FFE81293670
    public void get_Count(){} // RVA: 0x7FFE81293750
    public void Instantiate(){} // RVA: 0x7FFE812937A0
    public void IndexOf(){} // RVA: 0x7FFE81293830
    public void Equals(){} // RVA: 0x7FFE812938B0
    public void GetHashCode(){} // RVA: 0x7FFE81293930
    public void ToString(){} // RVA: 0x7FFE812939D0
    public void get_Item_9F7CECB4D5B4(){} // RVA: 0x7FFE81293A80
}

public class FontAssetRef : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87DEC550
}

public class FontReferenceMap : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8272BDB0
}

public class FontTextureRebuildCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class Foot : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811C1AA0
}

public class Footstep : Object
{
    public float stepSpeed; // 0x10
    public UnityEngine.Vector3 characterSpaceOffset; // 0x14

    // ── Methods ──
    public void get_isStepping(){} // RVA: 0x7FFE81225F10
    public void get_stepProgress(){} // RVA: 0x7FFE81163460
    public void set_stepProgress(){} // RVA: 0x7FFE81163470
    public void .ctor(){} // RVA: 0x7FFE81225F20
    public void Reset(){} // RVA: 0x7FFE812262A0
    public void StepTo(){} // RVA: 0x7FFE812262F0
    public void UpdateStepping(){} // RVA: 0x7FFE812265B0
    public void UpdateStanding(){} // RVA: 0x7FFE81226A80
    public void Update(){} // RVA: 0x7FFE81226D00
}

public class ForDevice : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87914F80
    public void OnCompleted(){} // RVA: 0x7FFE810FB310
    public void OnError(){} // RVA: 0x7FFE87915090
    public void OnNext(){} // RVA: 0x7FFE879150E0
}

public class Force : ValueType
{
}

public class ForceDropDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class ForceOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x129
    public object field_2; // 0x12A
    public object field_3; // 0x12B
    public object field_4; // 0x12C
    public object field_5; // 0x12D
    public object field_6; // 0x12E
    public object field_7; // 0x12F
    public object field_8; // 0x130

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CFD710
    public void set_enabled(){} // RVA: 0x7FFE87CFD760
    public void get_x(){} // RVA: 0x7FFE87CFD7C0
    public void set_x(){} // RVA: 0x7FFE87CFD830
    public void get_y(){} // RVA: 0x7FFE87CFD890
    public void set_y(){} // RVA: 0x7FFE87CFD900
    public void get_z(){} // RVA: 0x7FFE87CFD960
    public void set_z(){} // RVA: 0x7FFE87CFD9D0
    public void get_xMultiplier(){} // RVA: 0x7FFE87CFDA30
    public void set_xMultiplier(){} // RVA: 0x7FFE87CFDA80
    public void get_yMultiplier(){} // RVA: 0x7FFE87CFDAE0
    public void set_yMultiplier(){} // RVA: 0x7FFE87CFDB30
    public void get_zMultiplier(){} // RVA: 0x7FFE87CFDB90
    public void set_zMultiplier(){} // RVA: 0x7FFE87CFDBE0
    public void get_space(){} // RVA: 0x7FFE87CFDC40
    public void set_space(){} // RVA: 0x7FFE87CFDC90
    public void get_randomized(){} // RVA: 0x7FFE87CFDCF0
    public void set_randomized(){} // RVA: 0x7FFE87CFDD40
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CFD710
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CFD760
    public void get_x_Injected(){} // RVA: 0x7FFE87CFDDA0
    public void set_x_Injected(){} // RVA: 0x7FFE87CFDE00
    public void get_y_Injected(){} // RVA: 0x7FFE87CFDE60
    public void set_y_Injected(){} // RVA: 0x7FFE87CFDEC0
    public void get_z_Injected(){} // RVA: 0x7FFE87CFDF20
    public void set_z_Injected(){} // RVA: 0x7FFE87CFDF80
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFE87CFDA30
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFE87CFDA80
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFE87CFDAE0
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFE87CFDB30
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFE87CFDB90
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFE87CFDBE0
    public void get_space_Injected(){} // RVA: 0x7FFE87CFDC40
    public void set_space_Injected(){} // RVA: 0x7FFE87CFDC90
    public void get_randomized_Injected(){} // RVA: 0x7FFE87CFDCF0
    public void set_randomized_Injected(){} // RVA: 0x7FFE87CFDD40
}

public class FormatLiterals : ValueType
{
    public string AppCompatLiteral; // 0x10
    public int dd; // 0x18
    public int hh; // 0x1C
    public int mm; // 0x20
    public int ss; // 0x24
    public int ff; // 0x28

    // ── Methods ──
    public void get_Start(){} // RVA: 0x7FFE868FF820
    public void get_DayHourSep(){} // RVA: 0x7FFE868FF850
    public void get_HourMinuteSep(){} // RVA: 0x7FFE868FF880
    public void get_MinuteSecondSep(){} // RVA: 0x7FFE868FF8B0
    public void get_SecondFractionSep(){} // RVA: 0x7FFE868FF8E0
    public void get_End(){} // RVA: 0x7FFE868FF910
    public void InitInvariant(){} // RVA: 0x7FFE868FF940
    public void Init(){} // RVA: 0x7FFE868FFBF0
}

public class FormatOptions : ValueType
{
    public 0x666BE5FC Kind; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE813DB7A0
    public void get_Uppercase(){} // RVA: 0x7FFE874290A0
    public void GetBase(){} // RVA: 0x7FFE878B4DE0
    public void ToString(){} // RVA: 0x7FFE878B4E00
}

public class FormatParam : ValueType
{
    public int _int32; // 0x10
    public string _string; // 0x18
    public object field_2; // 0x1A5

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE844576B0 | overloaded x2
    public void op_Implicit(){} // RVA: 0x7FFE866E96C0
    public void get_Int32(){} // RVA: 0x7FFE826F4220
    public void get_String(){} // RVA: 0x7FFE86A54990
    public void get_Object(){} // RVA: 0x7FFE86A549E0
}

public class FormatterInfo : ValueType
{
}

public class FormatterLocatorInfo : ValueType
{
}

public class FovCache : ValueType
{
    // ── Methods ──
    public void UpdateCache(){} // RVA: 0x7FFE82A8D100
    public void ScreenToFOV(){} // RVA: 0x7FFE82A8D4C0
}

public class Fovf : ValueType
{
}

public class Frame : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D987C0
    public void Initialize(){} // RVA: 0x7FFE81D98890
    public void Equals(){} // RVA: 0x7FFE81D98920
    public void op_Implicit(){} // RVA: 0x7FFE81D98980
    public void CompareBaseObjects(){} // RVA: 0x7FFE81D98980
    public void IsNativeObjectAlive(){} // RVA: 0x7FFE81D989D0
    public void GetCachedPtr(){} // RVA: 0x7FFE81D98920
    public void get_name(){} // RVA: 0x7FFE81D98980
    public void set_name(){} // RVA: 0x7FFE81D98980
    public void Instantiate(){} // RVA: 0x7FFE81D98980
}

public class FrameHeader : ValueType
{
    // ── Methods ──
    public void ToBytes(){} // RVA: 0x7FFE86CF23E0
    public void FromBytes(){} // RVA: 0x7FFE86CF25F0
}

public class FrameReadyEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class FreeHGlobalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE9AD0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class FromAsyncTrimPromise`1 : Task`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void CompleteFromAsyncResult(){} // RVA: 0x7FFE80E46070
    public void Complete(){} // RVA: 0x7FFE810A1420
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class Frp256v1Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void CreateParameters(){} // RVA: 0x7FFE8A25D750
    public void .cctor(){} // RVA: 0x7FFE8A25D9E0
}

public class Frustum : ValueType
{
}

public class Frustumf : ValueType
{
}

public class Frustumf2 : ValueType
{
}

public class FullReaderStream : FilterStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A1189F0
    public void Read(){} // RVA: 0x7FFE8A118A00
}

public class Func`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}
