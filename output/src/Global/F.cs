// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 616

public class FILE_FULL_DIR_INFORMATION : ValueType
{
    public object NextEntryOffset;
    public object FileIndex;
    public object CreationTime;
    public object LastAccessTime;
    public object LastWriteTime;
    public object ChangeTime;
    public object EndOfFile;
    public object AllocationSize;
    public object FileAttributes;
    public object FileNameLength;
    public object EaSize;
    public object _fileName;

    // ── Methods ──
    public void get_FileName(){} // RVA: 0x8AB220
    public void GetNextInfo(){} // RVA: 0x666BFB0
}

public class FILE_TIME : ValueType
{
    public object dwLowDateTime;
    public object dwHighDateTime;

    // ── Methods ──
    public void ToTicks(){} // RVA: 0x8AB1B0
    public void ToDateTimeOffset(){} // RVA: 0x8AB1C0
}

public class FaceExpressionStatusInternal : ValueType
{
    public object IsValid;
    public object IsEyeFollowingBlendshapesValid;

    // ── Methods ──
    public void ToFaceExpressionStatus(){} // RVA: 0x8CE0D0
}

public class FaceExpressionsEnumerator : ValueType
{
    public object _faceExpressions;
    public object _index;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8C9780
    public void MoveNext(){} // RVA: 0x8C9790
    public void get_Current(){} // RVA: 0x8C97A0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x8C97D0
    public void Reset(){} // RVA: 0x2750F0
    public void Dispose(){} // RVA: 0x3FC0
}

public class FacetsCompiler : ValueType
{
    public object datatype;
    public object derivedRestriction;
    public object baseFlags;
    public object baseFixedFlags;
    public object validRestrictionFlags;
    public object nonNegativeInt;
    public object builtInType;
    public object builtInEnum;
    public object firstPattern;
    public object regStr;
    public object pattern_facet;
    public object c_map;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x917970
    public void CompileLengthFacet(){} // RVA: 0x917980
    public void CompileMinLengthFacet(){} // RVA: 0x917990
    public void CompileMaxLengthFacet(){} // RVA: 0x9179A0
    public void CompilePatternFacet(){} // RVA: 0x9179B0
    public void CompileEnumerationFacet(){} // RVA: 0x9179C0
    public void CompileWhitespaceFacet(){} // RVA: 0x9179D0
    public void CompileMaxInclusiveFacet(){} // RVA: 0x9179E0
    public void CompileMaxExclusiveFacet(){} // RVA: 0x9179F0
    public void CompileMinInclusiveFacet(){} // RVA: 0x917A00
    public void CompileMinExclusiveFacet(){} // RVA: 0x917A10
    public void CompileTotalDigitsFacet(){} // RVA: 0x917A20
    public void CompileFractionDigitsFacet(){} // RVA: 0x917A30
    public void FinishFacetCompile(){} // RVA: 0x917A40
    public void CheckValue(){} // RVA: 0x917A50
    public void CompileFacetCombinations(){} // RVA: 0x917A60
    public void CopyFacetsFromBaseType(){} // RVA: 0x917A70
    public void ParseFacetValue(){} // RVA: 0x917A80
    public void Preprocess(){} // RVA: 0x7568930
    public void CheckProhibitedFlag(){} // RVA: 0x917A90
    public void CheckDupFlag(){} // RVA: 0x917AA0
    public void SetFlag(){} // RVA: 0x917B10
    public void .cctor(){} // RVA: 0x7568E00
}

public class FailInfo : DerBitString
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA3934C0
}

public class FakeDelegate : Object
{
    public object _method;

    // ── Methods ──
    public void get_Method(){} // RVA: 0xB5DBF0
}

public class Fallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0x87C540
    public void BeginInvoke(){} // RVA: 0x882090
    public void EndInvoke(){} // RVA: 0x87C540
}

public class FallbackKeyComparer`1 : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0xA94080
    public void .ctor(){} // RVA: 0x894290
}

public class FallbackMaterial : Object
{
    public object fallbackID;
    public object sourceMaterial;
    public object sourceMaterialCRC;
    public object fallbackMaterial;
    public object count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class FallbackMaterial[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class FallbackWrapper`1 : Object
{
    public object _sequence;
    public object _collection;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Count(){} // RVA: 0x87C130
    public void get_Item(){} // RVA: 0xA94080
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
}

public class FeatureFidelityGroup : Object
{
    public object targetFeatureEnabled;
    public object targetFeatureFidelity;
    public object currentFeatureEnabled;
    public object currentFeatureFidelity;
    public object lastSetTargetFeatureEnabled;
    public object lastSetTargetFeatureFidelity;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6BAF440
}

public class FeatureState : ValueType
{
    public object enableState;
    public object fidelity;
    public object Default;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2B100
    public void .cctor(){} // RVA: 0x6BE24B0
}

public class FieldCollection : Object
{
    public object messageDescriptor;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void InDeclarationOrder(){} // RVA: 0x13F92F0
    public void InFieldNumberOrder(){} // RVA: 0x13F9420
    public void get_Item(){} // RVA: 0x6503290
}

public class FieldDescription : ValueType
{
    public object name;
    public object ussName;
    public object read;
    public object write;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x899870
}

public class FileDescriptor : ApiModel
{
    public object _status;
    public object _url;
    public object _md5;
    public object _category;
    public object _sizeInBytes;
    public object _fileName;
    public object _uploadId;
    public object _cdns;

    // ── Methods ──
    public void get_status(){} // RVA: 0x2536460
    public void set_status(){} // RVA: 0x25406E0
    public void get_url(){} // RVA: 0xC10050
    public void set_url(){} // RVA: 0xC10060
    public void get_md5(){} // RVA: 0xCD3320
    public void set_md5(){} // RVA: 0xCD4740
    public void get_category(){} // RVA: 0xD34760
    public void set_category(){} // RVA: 0xD34750
    public void get_sizeInBytes(){} // RVA: 0xD34730
    public void set_sizeInBytes(){} // RVA: 0xD34790
    public void get_fileName(){} // RVA: 0xB813B0
    public void set_fileName(){} // RVA: 0xD5CBB0
    public void get_uploadId(){} // RVA: 0x1069350
    public void set_uploadId(){} // RVA: 0xD5CC10
    public void get_cdns(){} // RVA: 0x106A7D0
    public void set_cdns(){} // RVA: 0xD5CC70
    public void .ctor(){} // RVA: 0xA518990
    public void Init(){} // RVA: 0xA518AC0
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEE0D0
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEE160
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEDE60
    public void set_Count(){} // RVA: 0x116BB10
    public void get_Count(){} // RVA: 0x116A650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void CopyTo(){} // RVA: 0xB43310
    public void Add(){} // RVA: 0xB43310
    public void Clear(){} // RVA: 0xB43310
    public void Contains(){} // RVA: 0xC2E4C0
    public void GetEnumerator(){} // RVA: 0x3DEDE70
    public void Remove(){} // RVA: 0xC2E4C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DEDF00
}

public class FillCollection`1 : Object
{
    public object <count>P;
    public object Instance;
    public object _count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8944F0
    public void get_Count(){} // RVA: 0x87C130
    public void set_Count(){} // RVA: 0x8944F0
    public void get_IsReadOnly(){} // RVA: 0x87D280
    public void CopyTo(){} // RVA: 0x899290
    public void Add(){} // RVA: 0xA94080
    public void Clear(){} // RVA: 0x894290
    public void Contains(){} // RVA: 0xA94080
    public void GetEnumerator(){} // RVA: 0x87C0A0
    public void Remove(){} // RVA: 0xA94080
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
}

public class FilterBlockCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
    public void BeginInvoke(){} // RVA: 0xBA10C0
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class FilterCacheItem : Object
{
    public object _filterService;
    public object FilteredMembers;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void IsValid(){} // RVA: 0x6AAC4B0
}

public class FilterCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B26170
    public void Invoke(){} // RVA: 0x14CC9D0
    public void BeginInvoke(){} // RVA: 0x6B26260
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class FilterReadDelegate : MonoBehaviour
{
    public object parent;
    public object scratchBuffer;

    // ── Methods ──
    public void Awake(){} // RVA: 0x6B52B60
    public void OnAudioFilterRead(){} // RVA: 0x6B52C80
    public void .ctor(){} // RVA: 0xB43D60
}

public class FinalizationHelper : Object
{
    public object SlotArray;
    public object m_trackAllValues;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x899250
    public void Finalize(){} // RVA: 0x894290
}

public class FinalizationHelper : Object
{
    public object SlotArray;
    public object m_trackAllValues;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x237A5A0
    public void Finalize(){} // RVA: 0x3DEE420
}

public class FinalizationHelper : Object
{
    public object SlotArray;
    public object m_trackAllValues;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x237A5A0
}

public class FindPredicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0x87D350
}

public class FindPredicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEEB00
    public void Invoke(){} // RVA: 0xB9E010
}

public class FindTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x899C90
    public void Invoke(){} // RVA: 0xA94080
}

public class FindTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3DEEBF0
    public void Invoke(){} // RVA: 0xB9E010
}

public class Finger : Object
{
    public object metacarpal;
    public object proximal;
    public object middle;
    public object distal;
    public object aux;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xC35B30
}

public class Finger : Object
{
    public object mass;
    public object pos;
    public object forwardAxis;
    public object renderer;
    public object squeezyAction;
    public object inputSource;
    public object bones;
    public object referenceBone;
    public object referenceAngles;
    public object referenceAxis;
    public object flexAngle;
    public object rotation;
    public object velocity;
    public object boneTips;
    public object oldTipPosition;
    public object oldTipDelta;
    public object inertiaSmoothing;
    public object squeezySmooth;
    public object inertiaSteps;
    public object k;
    public object damping;
    public object startRot;

    // ── Methods ──
    public void ApplyForce(){} // RVA: 0x6FFF5E0
    public void Init(){} // RVA: 0x6FFF690
    public void UpdateFinger(){} // RVA: 0x6FFFC00
    public void ApplyTransforms(){} // RVA: 0x7000B90
    public void FixVector(){} // RVA: 0x7000D60
    public void FixAngle(){} // RVA: 0x7000DB0
    public void PowVector(){} // RVA: 0x7000DD0
    public void .ctor(){} // RVA: 0x7000F00
}

public class FingerAndTouchState : ValueType
{
    public object updateMask;
    public object fingers;
    public object activeFingers;
    public object activeTouches;
    public object activeFingerCount;
    public object activeTouchCount;
    public object totalFingerCount;
    public object lastId;
    public object haveBuiltActiveTouches;
    public object haveActiveTouchesNeedingRefreshNextUpdate;
    public object activeTouchState;

    // ── Methods ──
    public void AddFingers(){} // RVA: 0x939C50
    public void RemoveFingers(){} // RVA: 0x939C60
    public void Destroy(){} // RVA: 0x939C70
    public void UpdateActiveFingers(){} // RVA: 0x939C80
    public void UpdateActiveTouches(){} // RVA: 0x939C90
}

public class FingerColliders : Object
{
    public object thumbColliders;
    public object indexColliders;
    public object middleColliders;
    public object ringColliders;
    public object pinkyColliders;

    // ── Methods ──
    public void get_Item(){} // RVA: 0x6FADDD0
    public void set_Item(){} // RVA: 0x6FADE10
    public void .ctor(){} // RVA: 0x6FADE70
}

public class FingerData[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Finger[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Finger[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class FirstQueryMatcher : SingleQueryMatcher
{
    public object Instance;

    // ── Methods ──
    public void OnRuleMatchedElement(){} // RVA: 0x7F15140
    public void CreateNew(){} // RVA: 0x7F151A0
    public void .ctor(){} // RVA: 0xB43310
    public void .cctor(){} // RVA: 0x7F151E0
}

public class FirstValueToUniTaskObserver`1 : Object
{
    public object callback;
    public object promise;
    public object disposable;
    public object cancellationToken;
    public object registration;
    public object hasValue;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x895C50
    public void OnCanceled(){} // RVA: 0x894350
    public void OnNext(){} // RVA: 0xA94080
    public void OnError(){} // RVA: 0x894320
    public void OnCompleted(){} // RVA: 0x894290
    public void .cctor(){} // RVA: 0x8942F0
}

public class FixedPointCallback : Object
{
    public object m_p;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Precompute(){} // RVA: 0xA112380
    public void CheckExisting(){} // RVA: 0xA1129B0
    public void CheckTable(){} // RVA: 0xA112A40
}

public class Fixup : Object
{
    public object source;
    public object ids;
    public object callback;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x75197E0
    public void get_Callback(){} // RVA: 0xB700F0
    public void get_Ids(){} // RVA: 0xB465B0
    public void get_Source(){} // RVA: 0xB5DBF0
}

public class FixupCallbackInfo : Object
{
    public object _sri;
    public object _map;
    public object _isValueList;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67A2500
    public void FixupMembers(){} // RVA: 0x7520250
}

public class FlexBasisProperty : InlineStyleLengthProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7E9F9D0
    public void get_ussName(){} // RVA: 0x7E9FA10
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7E9FA50
    public void SetValue(){} // RVA: 0x7E9FAD0
    public void .ctor(){} // RVA: 0x7E9E610
}

public class FlexBasisProperty : ResolvedStyleFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECAB50
    public void get_ussName(){} // RVA: 0x7ECAB90
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECABD0
    public void SetValue(){} // RVA: 0x7ECAC20
    public void .ctor(){} // RVA: 0x7ECAC60
}

public class FlexDirectionProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7E9FB40
    public void get_ussName(){} // RVA: 0x7E9FB80
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7E9FBC0
    public void SetValue(){} // RVA: 0x7E9FC90
    public void .ctor(){} // RVA: 0x7E9FCF0
}

public class FlexDirectionProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECAC90
    public void get_ussName(){} // RVA: 0x7ECACD0
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECAD10
    public void SetValue(){} // RVA: 0x7ECAD60
    public void .ctor(){} // RVA: 0x7ECADA0
}

public class FlexGrowProperty : InlineStyleFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7E9FD40
    public void get_ussName(){} // RVA: 0x7E9FD80
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7E9FDC0
    public void SetValue(){} // RVA: 0x7E9FE10
    public void .ctor(){} // RVA: 0x7E9E8C0
}

public class FlexGrowProperty : ResolvedFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECADD0
    public void get_ussName(){} // RVA: 0x7ECAE10
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECAE50
    public void SetValue(){} // RVA: 0x7ECAEA0
    public void .ctor(){} // RVA: 0x7EC9CA0
}

public class FlexShrinkProperty : InlineStyleFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7E9FE70
    public void get_ussName(){} // RVA: 0x7E9FEB0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7E9FEF0
    public void SetValue(){} // RVA: 0x7E9FF40
    public void .ctor(){} // RVA: 0x7E9E8C0
}

public class FlexShrinkProperty : ResolvedFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECAEE0
    public void get_ussName(){} // RVA: 0x7ECAF20
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECAF60
    public void SetValue(){} // RVA: 0x7ECAFB0
    public void .ctor(){} // RVA: 0x7EC9CA0
}

public class FlexWrapProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7E9FFA0
    public void get_ussName(){} // RVA: 0x7E9FFE0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA0020
    public void SetValue(){} // RVA: 0x7EA00F0
    public void .ctor(){} // RVA: 0x7EA01C0
}

public class FlexWrapProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECAFF0
    public void get_ussName(){} // RVA: 0x7ECB030
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECB070
    public void SetValue(){} // RVA: 0x7ECB0C0
    public void .ctor(){} // RVA: 0x7ECB100
}

public class FloatInput : TextValueInput
{
    // ── Methods ──
    public void get_parentFloatField(){} // RVA: 0x7FDFC20
    public void .ctor(){} // RVA: 0x7FDFCA0
    public void get_allowedCharacters(){} // RVA: 0x7FDFE60
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FDFEC0
    public void ValueToString(){} // RVA: 0x7FE00B0
    public void StringToValue(){} // RVA: 0x7FE0150
}

public class FloatTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x79EEAF0
}

public class FloatTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x810BB40
}

public class FocusBasedEventSequenceContext : ValueType
{
    public object es;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x9A46D0
    public void Dispose(){} // RVA: 0x9A46E0
}

public class FocusRingRecord : Object
{
    public object m_AutoIndex;
    public object m_Focusable;
    public object m_IsSlot;
    public object m_ScopeNavigationOrder;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class FocusableHierarchyTraversal : ValueType
{
    public object currentFocusable;
    public object validRect;
    public object firstPass;
    public object direction;

    // ── Methods ──
    public void ValidateHierarchyTraversal(){} // RVA: 0x9A5D20
    public void ValidateElement(){} // RVA: 0x9A5D30
    public void Order(){} // RVA: 0x9A5D40
    public void StrictOrder(){} // RVA: 0x9A5E70
    public void TieBreaker(){} // RVA: 0x9A5EA0
    public void GetBestOverall(){} // RVA: 0x9A5ED0
}

public class FoldoutList : Object
{
    public object foldouts;
    public object mainFoldout;
    public object scrollPos;

    // ── Methods ──
    public void set_Item(){} // RVA: 0xCE49C0
    public void .ctor(){} // RVA: 0xCE4A50
    public void get_Item(){} // RVA: 0xCE4B10
    public void op_Implicit(){} // RVA: 0xCE4B90
    public void CompareBaseObjects(){} // RVA: 0xCE4C20
    public void IsNativeObjectAlive(){} // RVA: 0xCE4D90
    public void set_Count(){} // RVA: 0xCE4DE0
    public void get_Count(){} // RVA: 0xCE4EB0
    public void set_name(){} // RVA: 0xCE4F00
    public void Instantiate(){} // RVA: 0xCE4F90
    public void Destroy(){} // RVA: 0xCE5020
    public void DestroyImmediate(){} // RVA: 0xCE50A0
    public void FindObjectsOfType(){} // RVA: 0xCE5140
    public void FindObjectsByType(){} // RVA: 0xCE51F0
}

public class FontAssetProperty : Property`2
{
    public object _name;
    public object _isReadOnly;

    // ── Methods ──
    public void get_Name(){} // RVA: 0xB465B0
    public void get_IsReadOnly(){} // RVA: 0xC38360
    public void GetValue(){} // RVA: 0x80B3BE0
    public void SetValue(){} // RVA: 0x80B8560
    public void .ctor(){} // RVA: 0x80B8580
}

public class FontAssetRef : ValueType
{
    public object nameHashCode;
    public object familyNameHashCode;
    public object styleNameHashCode;
    public object familyNameAndStyleHashCode;
    public object fontAsset;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x944980
}

public class FontAssetRef : ValueType
{
    public object nameHashCode;
    public object familyNameHashCode;
    public object styleNameHashCode;
    public object familyNameAndStyleHashCode;
    public object fontAsset;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x944980
}

public class FontProperty : Property`2
{
    public object _name;
    public object _isReadOnly;

    // ── Methods ──
    public void get_Name(){} // RVA: 0xB465B0
    public void get_IsReadOnly(){} // RVA: 0xC38360
    public void GetValue(){} // RVA: 0x223E600
    public void SetValue(){} // RVA: 0x80B84A0
    public void .ctor(){} // RVA: 0x80B84C0
}

public class FontReference : ValueType
{
    public object familyName;
    public object styleName;
    public object faceIndex;
    public object filePath;
    public object hashCode;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x9434F0
}

public class FontReferenceMap : ValueType
{
    public object font;
    public object fontAsset;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x76310
}

public class FontReferenceMap[] : Array
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

public class FontSizeProperty : InlineStyleLengthProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA0210
    public void get_ussName(){} // RVA: 0x7EA0250
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA0290
    public void SetValue(){} // RVA: 0x7EA0310
    public void .ctor(){} // RVA: 0x7E9E610
}

public class FontSizeProperty : ResolvedFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECB130
    public void get_ussName(){} // RVA: 0x7ECB170
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECB1B0
    public void SetValue(){} // RVA: 0x7ECB200
    public void .ctor(){} // RVA: 0x7EC9CA0
}

public class FontTextureRebuildCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class Foot : ValueType
{
    public object solver;
    public object transform;
    public object rotation;
    public object leg;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x50C0
}

public class Foot[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7EC40
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7ABD0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4700
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34D20
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7ABD0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Footstep : Object
{
    public object stepSpeed;
    public object characterSpaceOffset;
    public object position;
    public object rotation;
    public object stepToRootRot;
    public object isSupportLeg;
    public object _stepProgress;
    public object stepFrom;
    public object stepTo;
    public object stepFromRot;
    public object stepToRot;
    public object footRelativeToRoot;
    public object supportLegW;
    public object supportLegWV;

    // ── Methods ──
    public void get_isStepping(){} // RVA: 0xC76E00
    public void get_stepProgress(){} // RVA: 0xBAB430
    public void set_stepProgress(){} // RVA: 0xBAB440
    public void .ctor(){} // RVA: 0xC76E10
    public void Reset(){} // RVA: 0xC77190
    public void StepTo(){} // RVA: 0xC771E0
    public void UpdateStepping(){} // RVA: 0xC774A0
    public void UpdateStanding(){} // RVA: 0xC77950
    public void Update(){} // RVA: 0xC77BD0
}

public class Footstep[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class ForDevice : Object
{
    public object m_Observer;
    public object m_Device;
    public object m_DeviceType;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x78324E0
    public void OnCompleted(){} // RVA: 0xB43310
    public void OnError(){} // RVA: 0x78325F0
    public void OnNext(){} // RVA: 0x7832640
}

public class ForceDropDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class ForceOverLifetimeModule : ValueType
{
    public object m_ParticleSystem;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x47F10
    public void get_enabled(){} // RVA: 0x97C180
    public void set_enabled(){} // RVA: 0x97C1D0
    public void get_x(){} // RVA: 0x97C1E0
    public void set_x(){} // RVA: 0x97C210
    public void get_xBlittable(){} // RVA: 0x97C240
    public void set_xBlittable(){} // RVA: 0x97C2D0
    public void get_y(){} // RVA: 0x97C340
    public void set_y(){} // RVA: 0x97C370
    public void get_yBlittable(){} // RVA: 0x97C3A0
    public void set_yBlittable(){} // RVA: 0x97C430
    public void get_z(){} // RVA: 0x97C4A0
    public void set_z(){} // RVA: 0x97C4D0
    public void get_zBlittable(){} // RVA: 0x97C500
    public void set_zBlittable(){} // RVA: 0x97C590
    public void get_xMultiplier(){} // RVA: 0x97C600
    public void set_xMultiplier(){} // RVA: 0x97C650
    public void get_yMultiplier(){} // RVA: 0x97C660
    public void set_yMultiplier(){} // RVA: 0x97C6B0
    public void get_zMultiplier(){} // RVA: 0x97C6C0
    public void set_zMultiplier(){} // RVA: 0x97C710
    public void get_space(){} // RVA: 0x97C720
    public void set_space(){} // RVA: 0x97C770
    public void get_randomized(){} // RVA: 0x97C7D0
    public void set_randomized(){} // RVA: 0x97C820
    public void get_xBlittable_Injected(){} // RVA: 0x7CC91D0
    public void set_xBlittable_Injected(){} // RVA: 0x7CC9230
    public void get_yBlittable_Injected(){} // RVA: 0x7CC9290
    public void set_yBlittable_Injected(){} // RVA: 0x7CC92F0
    public void get_zBlittable_Injected(){} // RVA: 0x7CC9350
    public void set_zBlittable_Injected(){} // RVA: 0x7CC93B0
}

public class FormatLiterals : ValueType
{
    public object AppCompatLiteral;
    public object dd;
    public object hh;
    public object mm;
    public object ss;
    public object ff;
    public object _literals;

    // ── Methods ──
    public void get_Start(){} // RVA: 0x8B36D0
    public void get_DayHourSep(){} // RVA: 0x8B3700
    public void get_HourMinuteSep(){} // RVA: 0x8B3730
    public void get_MinuteSecondSep(){} // RVA: 0x8B3760
    public void get_SecondFractionSep(){} // RVA: 0x8B3790
    public void get_End(){} // RVA: 0x8B37C0
    public void InitInvariant(){} // RVA: 0x6837FD0
    public void Init(){} // RVA: 0x8B37F0
}

public class FormatOptions : ValueType
{
    public object Kind;
    public object AlignAndSize;
    public object Specifier;
    public object Lowercase;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x923EC0
    public void get_Uppercase(){} // RVA: 0x912F40
    public void GetBase(){} // RVA: 0x923EE0
    public void ToString(){} // RVA: 0x923F00
}

public class FormatParam : ValueType
{
    public object _int32;
    public object _string;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3616C0
    public void op_Implicit(){} // RVA: 0x6621400
    public void get_Int32(){} // RVA: 0x77E60
    public void get_String(){} // RVA: 0x8BFE10
    public void get_Object(){} // RVA: 0x8BFE30
}

public class FovCache : ValueType
{
    public object mFovSoftGuideRect;
    public object mFovHardGuideRect;
    public object mFovH;
    public object mFov;
    public object mOrthoSizeOverDistance;
    public object mAspect;
    public object mSoftGuideRect;
    public object mHardGuideRect;

    // ── Methods ──
    public void UpdateCache(){} // RVA: 0x86EF0
    public void ScreenToFOV(){} // RVA: 0x86F70
}

public class Fovf[] : Array
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
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E395D0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Frame : Object
{
    public object frameNumber;
    public object frameDelay;
    public object Visemes;
    public object laughterScore;

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x18F6470
    public void Equals(){} // RVA: 0x18F64D0
    public void GetHashCode(){} // RVA: 0x18F6560
    public void op_Implicit(){} // RVA: 0x18F65B0
    public void CompareBaseObjects(){} // RVA: 0x18F6470
    public void IsNativeObjectAlive(){} // RVA: 0x18F6640
    public void .ctor(){} // RVA: 0x18F66D0
    public void Initialize(){} // RVA: 0x18F67A0
    public void set_name(){} // RVA: 0x18F6830
    public void Instantiate(){} // RVA: 0x18F68C0
}

public class FrameHeader : ValueType
{
    public object protocolIdentifier;
    public object payloadType;
    public object payloadLength;
    public object StructSize;

    // ── Methods ──
    public void ToBytes(){} // RVA: 0x8D04F0
    public void FromBytes(){} // RVA: 0x6C24360
}

public class FrameReadyEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2697880
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class Frame[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class FreeHGlobalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1500
    public void Invoke(){} // RVA: 0xB9E010
}

public class FromAsyncTrimPromise`1 : Task`1
{
    public object s_completeFromAsyncResult;
    public object m_thisRef;
    public object m_endMethod;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void CompleteFromAsyncResult(){} // RVA: 0x894350
    public void Complete(){} // RVA: 0xA94080
    public void .cctor(){} // RVA: 0x8942F0
}

public class Frp256v1Holder : X9ECParametersHolder
{
    public object Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
    public void CreateParameters(){} // RVA: 0xA4A0B90
    public void .cctor(){} // RVA: 0xA4A0E20
}

public class FullReaderStream : FilterStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xA35AA10
    public void Read(){} // RVA: 0xA35AA20
}

public class ftLightmaps : Object
{
    public object lightmapRefCount;
    public object globalMapsAdditional;
    public object directionalMode;

    // ── Methods ──
    public void SetDirectionalMode(){} // RVA: 0x25706C0
    public void FindInScene(){} // RVA: 0x2570790
    public void GetEmptyDirectionTex(){} // RVA: 0x25709C0
    public void RefreshScene(){} // RVA: 0x25709E0
    public void UnloadScene(){} // RVA: 0x2572DD0
    public void RefreshScene2(){} // RVA: 0x2573100
    public void .ctor(){} // RVA: 0xB43310
    public void .cctor(){} // RVA: 0x2573440
}

public class ftLightmapsStorage : MonoBehaviour
{
    public object externalStorage;
    public object bakedRenderers;
    public object nonBakedRenderers;
    public object bakedLights;
    public object bakedRenderersTerrain;
    public object maps;
    public object masks;
    public object dirMaps;
    public object rnmMaps0;
    public object rnmMaps1;
    public object rnmMaps2;
    public object mapsMode;
    public object bakedIDs;
    public object bakedScaleOffset;
    public object bakedVertexColorMesh;
    public object bakedLightChannels;
    public object bakedIDsTerrain;
    public object bakedScaleOffsetTerrain;
    public object assetList;
    public object uvOverlapAssetList;
    public object idremap;
    public object usesRealtimeGI;
    public object emptyDirectionTex;
    public object anyVolumes;
    public object compressedVolumes;
    public object started;

    // ── Methods ──
    public void Start(){} // RVA: 0x2573480
    public void OnDestroy(){} // RVA: 0x2573570
    public void .ctor(){} // RVA: 0x25735D0
}
