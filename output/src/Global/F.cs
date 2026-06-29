// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 91
// Methods: 582

public class FILE_FULL_DIR_INFORMATION : ValueType
{
    // ── Methods ──
    public void get_FileName(){} // RVA: 0x7A7E2E5C0
    public void GetNextInfo(){} // RVA: 0x7AD9E1280
}

public class FILE_TIME : ValueType
{
    // ── Methods ──
    public void ToTicks(){} // RVA: 0x7A7E2E550
    public void ToDateTimeOffset(){} // RVA: 0x7A7E2E560
}

public class FaceExpressionStatusInternal : ValueType
{
    // ── Methods ──
    public void ToFaceExpressionStatus(){} // RVA: 0x7A7E4F740
}

public class FaceExpressionsEnumerator : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E4B1E0
    public void MoveNext(){} // RVA: 0x7A7E4B1F0
    public void get_Current(){} // RVA: 0x7A7E4B200
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7A7E4B230
    public void Reset(){} // RVA: 0x7A7830B40
    public void Dispose(){} // RVA: 0x7A75F4910
}

public class FacetsCompiler : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E975F0
    public void CompileLengthFacet(){} // RVA: 0x7A7E97600
    public void CompileMinLengthFacet(){} // RVA: 0x7A7E97610
    public void CompileMaxLengthFacet(){} // RVA: 0x7A7E97620
    public void CompilePatternFacet(){} // RVA: 0x7A7E97630
    public void CompileEnumerationFacet(){} // RVA: 0x7A7E97640
    public void CompileWhitespaceFacet(){} // RVA: 0x7A7E97650
    public void CompileMaxInclusiveFacet(){} // RVA: 0x7A7E97660
    public void CompileMaxExclusiveFacet(){} // RVA: 0x7A7E97670
    public void CompileMinInclusiveFacet(){} // RVA: 0x7A7E97680
    public void CompileMinExclusiveFacet(){} // RVA: 0x7A7E97690
    public void CompileTotalDigitsFacet(){} // RVA: 0x7A7E976A0
    public void CompileFractionDigitsFacet(){} // RVA: 0x7A7E976B0
    public void FinishFacetCompile(){} // RVA: 0x7A7E976C0
    public void CheckValue(){} // RVA: 0x7A7E976D0
    public void CompileFacetCombinations(){} // RVA: 0x7A7E976E0
    public void CopyFacetsFromBaseType(){} // RVA: 0x7A7E976F0
    public void ParseFacetValue(){} // RVA: 0x7A7E97700
    public void Preprocess(){} // RVA: 0x7AE8F57C0
    public void CheckProhibitedFlag(){} // RVA: 0x7A7E97710
    public void CheckDupFlag(){} // RVA: 0x7A7E97720
    public void SetFlag(){} // RVA: 0x7A7E97790
    public void .cctor(){} // RVA: 0x7AE8F5C90
}

public class FailInfo : DerBitString
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B15281A0
}

public class FakeDelegate : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
    public void get_Method(){} // RVA: 0x7A80F2570
}

public class Fallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DFE0
    public void Invoke(){} // RVA: 0x7A7E00B20
    public void BeginInvoke(){} // RVA: 0x7A7E06710
    public void EndInvoke(){} // RVA: 0x7A7E00B20
}

public class FallbackKeyComparer`1 : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7A8051B10
    public void .ctor(){} // RVA: 0x7A7E18770
}

public class FallbackMaterial : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class FallbackMaterial[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class FallbackWrapper`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E18800
    public void get_Count(){} // RVA: 0x7A7E00710
    public void get_Item(){} // RVA: 0x7A8051B10
    public void GetEnumerator(){} // RVA: 0x7A7E00680
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
}

public class Fallback`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DFE0
    public void Invoke(){} // RVA: 0x7A8051B10
}

public class FastReducer : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E8C7D0
    public void Reduce(){} // RVA: 0x7A7E8C7E0
    public void DivMul(){} // RVA: 0x7AE61B710
    public void SubMod(){} // RVA: 0x7AE61B8B0
}

public class FeatureFidelityGroup : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADF287C0
}

public class FeatureState : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7615330
    public void .cctor(){} // RVA: 0x7ADF5BAE0
}

public class FieldCollection : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
    public void InDeclarationOrder(){} // RVA: 0x7A88F3AF0
    public void InFieldNumberOrder(){} // RVA: 0x7A88F42F0
    public void get_Item(){} // RVA: 0x7AD875C40
}

public class FieldDescription : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DB70
}

public class FileDescriptor : ApiModel
{
    // ── Methods ──
    public void get_status(){} // RVA: 0x7A9A93870
    public void set_status(){} // RVA: 0x7A9A93880
    public void get_url(){} // RVA: 0x7A81A00E0
    public void set_url(){} // RVA: 0x7A81A00F0
    public void get_md5(){} // RVA: 0x7A82C2060
    public void set_md5(){} // RVA: 0x7A82C0530
    public void get_category(){} // RVA: 0x7A8D6DF30
    public void set_category(){} // RVA: 0x7A8D6DF20
    public void get_sizeInBytes(){} // RVA: 0x7A9A18C60
    public void set_sizeInBytes(){} // RVA: 0x7A9A18CB0
    public void get_fileName(){} // RVA: 0x7A81163D0
    public void set_fileName(){} // RVA: 0x7A825E460
    public void get_uploadId(){} // RVA: 0x7A8555100
    public void set_uploadId(){} // RVA: 0x7A8919DE0
    public void get_cdns(){} // RVA: 0x7A87D9C10
    public void set_cdns(){} // RVA: 0x7A8744720
    public void .ctor(){} // RVA: 0x7B16AD640
    public void Init(){} // RVA: 0x7B16AD770
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E189D0
    public void get_Count(){} // RVA: 0x7A7E00710
    public void set_Count(){} // RVA: 0x7A7E189D0
    public void get_IsReadOnly(){} // RVA: 0x7A7E01900
    public void CopyTo(){} // RVA: 0x7A7E1D590
    public void Add(){} // RVA: 0x7A8051B10
    public void Clear(){} // RVA: 0x7A7E18770
    public void Contains(){} // RVA: 0x7A8051B10
    public void GetEnumerator(){} // RVA: 0x7A7E00680
    public void Remove(){} // RVA: 0x7A8051B10
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132D90
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB132E20
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FillCollection`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB132D80
    public void set_Count(){} // RVA: 0x7A8669360
    public void get_Count(){} // RVA: 0x7A8668BC0
    public void get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void CopyTo(){} // RVA: 0x7A80D7310
    public void Add(){} // RVA: 0x7A80D7310
    public void Clear(){} // RVA: 0x7A80D7310
    public void Contains(){} // RVA: 0x7A81BD750
    public void GetEnumerator(){} // RVA: 0x7AB132FF0
    public void Remove(){} // RVA: 0x7A81BD750
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AB133080
}

public class FilterBlockCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8135E00
    public void Invoke(){} // RVA: 0x7A8135ED0
    public void BeginInvoke(){} // RVA: 0x7A8135EE0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class FilterCacheItem : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8CE4080
    public void IsValid(){} // RVA: 0x7ADE24600
}

public class FilterCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADE9EF40
    public void Invoke(){} // RVA: 0x7A89D0820
    public void BeginInvoke(){} // RVA: 0x7ADE9F030
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class FilterReadDelegate : MonoBehaviour
{
    // ── Methods ──
    public void Awake(){} // RVA: 0x7ADECBB40
    public void OnAudioFilterRead(){} // RVA: 0x7ADECBC60
    public void .ctor(){} // RVA: 0x7A80D7D60
}

public class FinalizationHelper : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1D550
    public void Finalize(){} // RVA: 0x7A7E18770
}

public class FinalizationHelper : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A986DB30
}

public class FindPredicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DFE0
    public void Invoke(){} // RVA: 0x7A7E019D0
}

public class FindPredicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB133A20
    public void Invoke(){} // RVA: 0x7A8133090
}

public class FindPredicate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB133A20
    public void Invoke(){} // RVA: 0x7A8133090
}

public class FindTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DFE0
    public void Invoke(){} // RVA: 0x7A8051B10
}

public class FindTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB133B10
    public void Invoke(){} // RVA: 0x7A8133090
}

public class FindTransform : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AB133B10
    public void Invoke(){} // RVA: 0x7A8133090
}

public class Finger : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A81C4230
}

public class Finger : Object
{
    // ── Methods ──
    public void ApplyForce(){} // RVA: 0x7AE37F8E0
    public void Init(){} // RVA: 0x7AE37F990
    public void UpdateFinger(){} // RVA: 0x7AE37FEC0
    public void ApplyTransforms(){} // RVA: 0x7AE380F20
    public void FixVector(){} // RVA: 0x7AE3810A0
    public void FixAngle(){} // RVA: 0x7AE3810F0
    public void PowVector(){} // RVA: 0x7AE381110
    public void .ctor(){} // RVA: 0x7AE381240
}

public class FingerAndTouchState : ValueType
{
    // ── Methods ──
    public void AddFingers(){} // RVA: 0x7A7EB7710
    public void RemoveFingers(){} // RVA: 0x7A7EB7720
    public void Destroy(){} // RVA: 0x7A7EB7730
    public void UpdateActiveFingers(){} // RVA: 0x7A7EB7740
    public void UpdateActiveTouches(){} // RVA: 0x7A7EB7750
}

public class FingerColliders : Object
{
    // ── Methods ──
    public void get_Item(){} // RVA: 0x7AE32E7B0
    public void set_Item(){} // RVA: 0x7AE32E7F0
    public void .ctor(){} // RVA: 0x7AE32E850
}

public class FingerData[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A18F0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E0E0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2F10
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2508F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E0E0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class Finger[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class Finger[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class FirstQueryMatcher : SingleQueryMatcher
{
    // ── Methods ──
    public void OnRuleMatchedElement(){} // RVA: 0x7AF26C810
    public void CreateNew(){} // RVA: 0x7AF26C870
    public void .ctor(){} // RVA: 0x7A80D7310
    public void .cctor(){} // RVA: 0x7AF26C8B0
}

public class FirstValueToUniTaskObserver`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1A0E0
    public void OnCanceled(){} // RVA: 0x7A7E18830
    public void OnNext(){} // RVA: 0x7A8051B10
    public void OnError(){} // RVA: 0x7A7E18800
    public void OnCompleted(){} // RVA: 0x7A7E18770
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class FixedMemoryStream : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE5F4040
    public void CheckOverflow(){} // RVA: 0x7AE5F4070
    public void WriteByte(){} // RVA: 0x7AE5F4130
    public void Write(){} // RVA: 0x7AE5F4260
}

public class FixedPointCallback : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D8E20
    public void Precompute(){} // RVA: 0x7B12A6A10
    public void CheckExisting(){} // RVA: 0x7B12A7040
    public void CheckTable(){} // RVA: 0x7B12A70D0
}

public class Fixup : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AE8A5760
    public void get_Callback(){} // RVA: 0x7A81052C0
    public void get_Ids(){} // RVA: 0x7A80DA7B0
    public void get_Source(){} // RVA: 0x7A80F2570
}

public class FixupCallbackInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7ADB17AA0
    public void FixupMembers(){} // RVA: 0x7AE8AC060
}

public class FloatInput : TextValueInput
{
    // ── Methods ──
    public void get_parentFloatField(){} // RVA: 0x7AF0F8DA0
    public void .ctor(){} // RVA: 0x7AF0F8E20
    public void get_allowedCharacters(){} // RVA: 0x7AF0F8FE0
    public void ApplyInputDeviceDelta(){} // RVA: 0x7AF0F9040
    public void ValueToString(){} // RVA: 0x7AF0F9230
    public void StringToValue(){} // RVA: 0x7AF0F92D0
}

public class FloatTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AED81460
}

public class FloatTweenCallback : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AF2BEC10
}

public class FocusBasedEventSequenceContext : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7F01C00
    public void Dispose(){} // RVA: 0x7A7F01C10
}

public class FocusRingRecord : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
}

public class FocusableHierarchyTraversal : ValueType
{
    // ── Methods ──
    public void ValidateHierarchyTraversal(){} // RVA: 0x7A7F02A40
    public void ValidateElement(){} // RVA: 0x7A7F02A50
    public void Order(){} // RVA: 0x7A7F02A60
    public void StrictOrder(){} // RVA: 0x7A7F02B90
    public void TieBreaker(){} // RVA: 0x7A7F02BC0
    public void GetBestOverall(){} // RVA: 0x7A7F02BF0
}

public class FoldoutList : Object
{
    // ── Methods ──
    public void set_Item(){} // RVA: 0x7A826FA80
    public void .ctor(){} // RVA: 0x7A826FB10
    public void get_Item(){} // RVA: 0x7A826FBD0
    public void op_Implicit(){} // RVA: 0x7A826FC50
    public void CompareBaseObjects(){} // RVA: 0x7A826FCE0
    public void IsNativeObjectAlive(){} // RVA: 0x7A826FE50
    public void set_Count(){} // RVA: 0x7A826FEA0
    public void get_Count(){} // RVA: 0x7A826FF70
    public void set_name(){} // RVA: 0x7A826FFC0
    public void Instantiate(){} // RVA: 0x7A8270050
    public void Destroy(){} // RVA: 0x7A82700E0
    public void DestroyImmediate(){} // RVA: 0x7A8270160
    public void FindObjectsOfType(){} // RVA: 0x7A8270200
    public void FindObjectsByType(){} // RVA: 0x7A82702B0
    public void foldouts(){} // RVA: 0x7B3FAD508
}

public class FontAssetRef : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7EFAD80
}

public class FontReferenceMap : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7661E00
}

public class FontTextureRebuildCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8135E00
    public void Invoke(){} // RVA: 0x7A8135ED0
}

public class Foot : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A75F5690
}

public class Foot[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1D50
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E250
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E31C0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250C50
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E250
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class Footstep : Object
{
    // ── Methods ──
    public void get_isStepping(){} // RVA: 0x7A8202DE0
    public void get_stepProgress(){} // RVA: 0x7A813FA00
    public void set_stepProgress(){} // RVA: 0x7A813FA10
    public void .ctor(){} // RVA: 0x7A8202DF0
    public void Reset(){} // RVA: 0x7A8203170
    public void StepTo(){} // RVA: 0x7A82031C0
    public void UpdateStepping(){} // RVA: 0x7A8203480
    public void UpdateStanding(){} // RVA: 0x7A8203930
    public void Update(){} // RVA: 0x7A8203BB0
}

public class Footstep[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class ForDevice : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AEBC2C50
    public void OnCompleted(){} // RVA: 0x7A80D7310
    public void OnError(){} // RVA: 0x7AEBC2D60
    public void OnNext(){} // RVA: 0x7AEBC2DB0
}

public class ForceDropDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A81577F0
    public void Invoke(){} // RVA: 0x7A8133090
    public void BeginInvoke(){} // RVA: 0x7A81330A0
    public void EndInvoke(){} // RVA: 0x7A80D8CA0
}

public class ForceOverLifetimeModule : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7637E60
    public void get_enabled(){} // RVA: 0x7A7EEE160
    public void set_enabled(){} // RVA: 0x7A7EEE1B0
    public void get_x(){} // RVA: 0x7A7EEE1C0
    public void set_x(){} // RVA: 0x7A7EEE250
    public void get_y(){} // RVA: 0x7A7EEE2C0
    public void set_y(){} // RVA: 0x7A7EEE350
    public void get_z(){} // RVA: 0x7A7EEE3C0
    public void set_z(){} // RVA: 0x7A7EEE450
    public void get_xMultiplier(){} // RVA: 0x7A7EEE4C0
    public void set_xMultiplier(){} // RVA: 0x7A7EEE510
    public void get_yMultiplier(){} // RVA: 0x7A7EEE520
    public void set_yMultiplier(){} // RVA: 0x7A7EEE570
    public void get_zMultiplier(){} // RVA: 0x7A7EEE580
    public void set_zMultiplier(){} // RVA: 0x7A7EEE5D0
    public void get_space(){} // RVA: 0x7A7EEE5E0
    public void set_space(){} // RVA: 0x7A7EEE630
    public void get_randomized(){} // RVA: 0x7A7EEE690
    public void set_randomized(){} // RVA: 0x7A7EEE6E0
    public void get_enabled_Injected(){} // RVA: 0x7AEF9CB00
    public void set_enabled_Injected(){} // RVA: 0x7AEF9CB50
    public void get_x_Injected(){} // RVA: 0x7AEF9D190
    public void set_x_Injected(){} // RVA: 0x7AEF9D1F0
    public void get_y_Injected(){} // RVA: 0x7AEF9D250
    public void set_y_Injected(){} // RVA: 0x7AEF9D2B0
    public void get_z_Injected(){} // RVA: 0x7AEF9D310
    public void set_z_Injected(){} // RVA: 0x7AEF9D370
    public void get_xMultiplier_Injected(){} // RVA: 0x7AEF9CE20
    public void set_xMultiplier_Injected(){} // RVA: 0x7AEF9CE70
    public void get_yMultiplier_Injected(){} // RVA: 0x7AEF9CED0
    public void set_yMultiplier_Injected(){} // RVA: 0x7AEF9CF20
    public void get_zMultiplier_Injected(){} // RVA: 0x7AEF9CF80
    public void set_zMultiplier_Injected(){} // RVA: 0x7AEF9CFD0
    public void get_space_Injected(){} // RVA: 0x7AEF9D030
    public void set_space_Injected(){} // RVA: 0x7AEF9D080
    public void get_randomized_Injected(){} // RVA: 0x7AEF9D0E0
    public void set_randomized_Injected(){} // RVA: 0x7AEF9D130
}

public class FormatLiterals : ValueType
{
    // ── Methods ──
    public void get_Start(){} // RVA: 0x7A7E35C70
    public void get_DayHourSep(){} // RVA: 0x7A7E35CA0
    public void get_HourMinuteSep(){} // RVA: 0x7A7E35CD0
    public void get_MinuteSecondSep(){} // RVA: 0x7A7E35D00
    public void get_SecondFractionSep(){} // RVA: 0x7A7E35D30
    public void get_End(){} // RVA: 0x7A7E35D60
    public void InitInvariant(){} // RVA: 0x7ADBAD0B0
    public void Init(){} // RVA: 0x7A7E35D90
}

public class FormatOptions : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7EA32A0
    public void get_Uppercase(){} // RVA: 0x7A7E931B0
    public void GetBase(){} // RVA: 0x7A7EA32C0
    public void ToString(){} // RVA: 0x7A7EA32E0
}

public class FormatParam : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A790A7A0
    public void op_Implicit(){} // RVA: 0x7AD996340
    public void get_Int32(){} // RVA: 0x7A765F070
    public void get_String(){} // RVA: 0x7A7E41D50
    public void get_Object(){} // RVA: 0x7A7E41DA0
}

public class FormatterInfo[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A18F0
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E0E0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2F10
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2508F0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E0E0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class FormatterLocatorInfo[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class FovCache : ValueType
{
    // ── Methods ──
    public void UpdateCache(){} // RVA: 0x7A7672100
    public void ScreenToFOV(){} // RVA: 0x7A7672180
}

public class Fovf[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2602D0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class Frame : Object
{
    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7A8DD9E60
    public void Equals(){} // RVA: 0x7A8DD9EF0
    public void GetHashCode(){} // RVA: 0x7A8DD9F40
    public void op_Implicit(){} // RVA: 0x7A8DD9EF0
    public void CompareBaseObjects(){} // RVA: 0x7A8DD9EF0
    public void .ctor(){} // RVA: 0x7A8DD9FD0
    public void Initialize(){} // RVA: 0x7A8DDA0A0
    public void get_name(){} // RVA: 0x7A8DD9EF0
    public void set_name(){} // RVA: 0x7A8DDA130
    public void Instantiate(){} // RVA: 0x7A8DDA1C0
    public void Destroy(){} // RVA: 0x7A8DDA220
}

public class FrameHeader : ValueType
{
    // ── Methods ──
    public void ToBytes(){} // RVA: 0x7A7E51990
    public void FromBytes(){} // RVA: 0x7ADF9E090
}

public class FrameReadyEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9C160C0
    public void Invoke(){} // RVA: 0x7A82344F0
}

public class Frame[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
}

public class FreeHGlobalDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A9C64DA0
    public void Invoke(){} // RVA: 0x7A8133090
}

public class FromAsyncTrimPromise`1 : Task`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A8051B10
    public void CompleteFromAsyncResult(){} // RVA: 0x7A7E18830
    public void Complete(){} // RVA: 0x7A8051B10
    public void .cctor(){} // RVA: 0x7A7E187D0
}

public class Frp256v1Holder : X9ECParametersHolder
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A80D7310
    public void CreateParameters(){} // RVA: 0x7B1635510
    public void .cctor(){} // RVA: 0x7B16357A0
}

public class FullReaderStream : FilterStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7B14EF610
    public void Read(){} // RVA: 0x7B14EF620
}

public class Func`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7A7E1DFE0
    public void Invoke(){} // RVA: 0x7A8051B10
}

public class ftLightmaps : Object
{
    // ── Methods ──
    public void SetDirectionalMode(){} // RVA: 0x7A9AC4400
    public void FindInScene(){} // RVA: 0x7A9AC44D0
    public void GetEmptyDirectionTex(){} // RVA: 0x7A9AC4700
    public void RefreshScene(){} // RVA: 0x7A9AC4720
    public void UnloadScene(){} // RVA: 0x7A9AC6A60
    public void RefreshScene2(){} // RVA: 0x7A9AC6D90
    public void .ctor(){} // RVA: 0x7A80D7310
    public void .cctor(){} // RVA: 0x7A9AC7150
    public void lightmapRefCount(){} // RVA: 0x7B41F1278
}

public class ftLightmapsStorage : MonoBehaviour
{
    // ── Methods ──
    public void Start(){} // RVA: 0x7A9AC7190
    public void OnDestroy(){} // RVA: 0x7A9AC7410
    public void .ctor(){} // RVA: 0x7A9AC7470
}
