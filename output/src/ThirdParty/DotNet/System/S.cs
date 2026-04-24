// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 9
// Methods: 387

namespace ThirdParty.DotNet.System
{
    public class SByte : ValueType
    {
        public sbyte m_value; // 0x10
        public sbyte MaxValue;
        public sbyte MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFD53A68900 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD5392CD20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53A689A0
        public void ToString(){} // RVA: 0x7FFD53A68B10 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53A68C90
        public void Parse(){} // RVA: 0x7FFD53A68FB0 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFD53A69300 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFD4E6048B0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53A693D0
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53A69420
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD4FD7DDF0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53A694B0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD53A69540
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53A69590
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD53A69620
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53A69630
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD53A696C0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53A69710
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD53A697A0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD53A697F0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53A69840
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53A69900
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53A69990
    }

    public class SequencePosition : ValueType
    {
        public object _object; // 0x10
        public int _integer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E77C3C0
        public void GetObject(){} // RVA: 0x7FFD4EEF9F60
        public void GetInteger(){} // RVA: 0x7FFD4FDE7500
        public void Equals(){} // RVA: 0x7FFD53E74D00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53E74DC0
    }

    public class SerializableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Single : ValueType
    {
        public float m_value; // 0x10
        public float MinValue;
        public float Epsilon;
        public float MaxValue;
        public float PositiveInfinity;
        public float NegativeInfinity;
        public float NaN;
        public float NegativeZero;

        // ── Methods ──
        public void IsFinite(){} // RVA: 0x7FFD53A69A30
        public void IsInfinity(){} // RVA: 0x7FFD53A69A50
        public void IsNaN(){} // RVA: 0x7FFD53A69A70
        public void IsNegativeInfinity(){} // RVA: 0x7FFD53A69A90
        public void IsPositiveInfinity(){} // RVA: 0x7FFD53A69AB0
        public void CompareTo(){} // RVA: 0x7FFD53A69BF0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD53A69CE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53A69D10
        public void ToString(){} // RVA: 0x7FFD53A69EA0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD53A69F30
        public void Parse(){} // RVA: 0x7FFD53A6A260 | overloaded x4
        public void TryParse(){} // RVA: 0x7FFD53A6A4A0 | overloaded x3
        public void GetTypeCode(){} // RVA: 0x7FFD4F035CE0
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD53A6A800
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD53A6A870
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD53A6A900
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD53A6A9A0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD53A6AA40
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD53A6AAE0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD53A6AB80
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD53A6AC20
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD53A6ACC0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD53A6AD60
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD4FC6C150
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD53A6AE00
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD53A6AE60
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD53A6AEE0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD53A6AF70
    }

    public class SpanHelpers : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void IndexOfAny(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SequenceEqual(){} // RVA: 0x7FFD4E07D420 | overloaded x2
        public void LocateFirstFoundByte(){} // RVA: 0x7FFD53E784F0 | overloaded x2
        public void GetVector(){} // RVA: 0x7FFD53E78510
        public void LocateFirstFoundChar(){} // RVA: 0x7FFD53A6BDC0 | overloaded x2
        public void CopyTo(){}
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void IsReferenceOrContainsReferences(){} // RVA: 0x7FFD4E079D30
        public void IsReferenceOrContainsReferencesCore(){} // RVA: 0x7FFD53E78890
        public void ClearLessThanPointerSized(){} // RVA: 0x7FFD53E78BC0 | overloaded x2
        public void ClearPointerSizedWithoutReferences(){} // RVA: 0x7FFD53E78C60
        public void ClearPointerSizedWithReferences(){} // RVA: 0x7FFD53E78CE0
        public void LessThanEqual(){} // RVA: 0x7FFD53E78D80
    }

    public class Span`1 : ValueType
    {
        public System.ByReference`1<System.Collections.Generic.KeyValuePair`2<string,int>> Item; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FC0B650 | overloaded x4
        public void get_Item(){} // RVA: 0x7FFD51C6C3E0
        public void GetPinnableReference(){} // RVA: 0x7FFD51C5E680
        public void Clear(){} // RVA: 0x7FFD51D95660
        public void Fill(){} // RVA: 0x7FFD51D95680
        public void CopyTo(){} // RVA: 0x7FFD51C6C400
        public void TryCopyTo(){} // RVA: 0x7FFD51C6C4B0
        public void op_Equality(){} // RVA: 0x7FFD51C5E7B0
        public void op_Implicit(){} // RVA: 0x7FFD51D95AB0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFD51D95730
        public void Slice(){} // RVA: 0x7FFD51C6C830 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFD51D95990
        public void get_Length(){} // RVA: 0x7FFD4FDE7500
        public void get_IsEmpty(){} // RVA: 0x7FFD511D8A30
        public void Equals(){} // RVA: 0x7FFD51C5EC10
        public void GetHashCode(){} // RVA: 0x7FFD51C5EC60
    }

    public class String : Object
    {
        public int Length;
        public int Chars;
        public int PROBABILISTICMAP_BLOCK_INDEX_SHIFT;
        public int PROBABILISTICMAP_SIZE;
        public int _stringLength; // 0x10
        public char _firstChar; // 0x14
        public string Empty;

        // ── Methods ──
        public void EqualsHelper(){} // RVA: 0x7FFD537DB200
        public void CompareOrdinalHelper(){} // RVA: 0x7FFD537DB280 | overloaded x2
        public void Compare(){} // RVA: 0x7FFD537DBD10 | overloaded x10
        public void CompareOrdinal(){} // RVA: 0x7FFD537DC290 | overloaded x3
        public void CompareTo(){} // RVA: 0x7FFD537DB3C0 | overloaded x2
        public void EndsWith(){} // RVA: 0x7FFD537DCB40 | overloaded x4
        public void Equals(){} // RVA: 0x7FFD537DCFA0 | overloaded x5
        public void op_Equality(){} // RVA: 0x7FFD537DCF60
        public void op_Inequality(){} // RVA: 0x7FFD537DD2B0
        public void GetHashCode(){} // RVA: 0x7FFD537DD350 | overloaded x2
        public void GetLegacyNonRandomizedHashCode(){} // RVA: 0x7FFD537DD300
        public void StartsWith(){} // RVA: 0x7FFD537DDAF0 | overloaded x4
        public void CheckStringComparison(){} // RVA: 0x7FFD537DDB10
        public void FillStringChecked(){} // RVA: 0x7FFD537DDB40
        public void Concat(){} // RVA: 0x7FFD537DEA90 | overloaded x10
        public void Format(){} // RVA: 0x7FFD537ABFC0 | overloaded x8
        public void FormatHelper(){} // RVA: 0x7FFD537DEFF0
        public void Insert(){} // RVA: 0x7FFD537DF140
        public void Join(){} // RVA: 0x7FFD537DF970 | overloaded x9
        public void JoinCore(){} // RVA: 0x7FFD537DFBE0 | overloaded x3
        public void PadLeft(){} // RVA: 0x7FFD537E0110 | overloaded x2
        public void PadRight(){} // RVA: 0x7FFD537E0240 | overloaded x2
        public void Remove(){} // RVA: 0x7FFD537E05E0 | overloaded x2
        public void Replace(){} // RVA: 0x7FFD537E0D90 | overloaded x4
        public void ReplaceCore(){} // RVA: 0x7FFD537E08C0
        public void ReplaceHelper(){} // RVA: 0x7FFD537E10F0
        public void Split(){} // RVA: 0x7FFD537E1DF0 | overloaded x10
        public void SplitInternal(){} // RVA: 0x7FFD537E2360 | overloaded x3
        public void SplitKeepEmptyEntries(){} // RVA: 0x7FFD537E27D0
        public void SplitOmitEmptyEntries(){} // RVA: 0x7FFD537E2A10
        public void MakeSeparatorList(){} // RVA: 0x7FFD537E3200 | overloaded x3
        public void Substring(){} // RVA: 0x7FFD537E3440 | overloaded x2
        public void InternalSubString(){} // RVA: 0x7FFD537E3670
        public void ToLower(){} // RVA: 0x7FFD537E37D0 | overloaded x2
        public void ToLowerInvariant(){} // RVA: 0x7FFD537E3870
        public void ToUpper(){} // RVA: 0x7FFD537E3A10 | overloaded x2
        public void ToUpperInvariant(){} // RVA: 0x7FFD537E3AB0
        public void Trim(){} // RVA: 0x7FFD537E3BC0 | overloaded x3
        public void TrimStart(){} // RVA: 0x7FFD537E3C60 | overloaded x3
        public void TrimEnd(){} // RVA: 0x7FFD537E3CF0 | overloaded x3
        public void TrimWhiteSpaceHelper(){} // RVA: 0x7FFD537E3D50
        public void TrimHelper(){} // RVA: 0x7FFD537E3EE0
        public void CreateTrimmedString(){} // RVA: 0x7FFD537E4040
        public void Contains(){} // RVA: 0x7FFD537E4310 | overloaded x4
        public void IndexOf(){} // RVA: 0x7FFD537E5090 | overloaded x10
        public void IndexOfAny(){} // RVA: 0x7FFD537E4BE0 | overloaded x5
        public void IndexOfCharArray(){} // RVA: 0x7FFD537E4C30
        public void InitializeProbabilisticMap(){} // RVA: 0x7FFD537E4D90
        public void ArrayContains(){} // RVA: 0x7FFD537E4E60
        public void IsCharBitSet(){} // RVA: 0x7FFD537E4EB0
        public void SetCharBit(){} // RVA: 0x7FFD537E4ED0
        public void LastIndexOf(){} // RVA: 0x7FFD537E5B70 | overloaded x9
        public void LastIndexOfAny(){} // RVA: 0x7FFD537E5630 | overloaded x3
        public void LastIndexOfCharArray(){} // RVA: 0x7FFD537E58D0
        public void .ctor(){} // RVA: 0x7FFD537E6DE0 | overloaded x8
        public void Ctor(){} // RVA: 0x7FFD537E6E00 | overloaded x8
        public void CreateStringForSByteConstructor(){} // RVA: 0x7FFD537E6910
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void op_Implicit(){} // RVA: 0x7FFD537E6EE0
        public void Clone(){} // RVA: 0x7FFD4F9181E0
        public void Copy(){} // RVA: 0x7FFD537E6F60
        public void CopyTo(){} // RVA: 0x7FFD537E7030
        public void ToCharArray(){} // RVA: 0x7FFD537E7390 | overloaded x2
        public void IsNullOrEmpty(){} // RVA: 0x7FFD537E7570
        public void IsNullOrWhiteSpace(){} // RVA: 0x7FFD537E7580
        public void GetRawStringData(){} // RVA: 0x7FFD537E7630
        public void CreateStringFromEncoding(){} // RVA: 0x7FFD537E7640
        public void CreateFromChar(){} // RVA: 0x7FFD537E7730
        public void wstrcpy(){} // RVA: 0x7FFD504A86C0
        public void ToString(){} // RVA: 0x7FFD4F9181E0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFD537E7760
        public void System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator(){} // RVA: 0x7FFD537E7800
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD537E78A0
        public void wcslen(){} // RVA: 0x7FFD537E7940
        public void GetTypeCode(){} // RVA: 0x7FFD4F55E570
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD537E7A30
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD537E7AD0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD537E7BC0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD537E7C90
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD537E7D60
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD537E7E30
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD537E7F00
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD537E7F80
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD537E8000
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD537E8080
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD537E8100
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD537E8180
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD537E8200
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD537E82F0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD537E83A0
        public void IsNormalized(){} // RVA: 0x7FFD537E8420 | overloaded x2
        public void Normalize(){} // RVA: 0x7FFD537E8530 | overloaded x2
        public void get_Length(){} // RVA: 0x7FFD4E38E5C0
        public void IndexOfUnchecked(){} // RVA: 0x7FFD537E8630
        public void IndexOfUncheckedIgnoreCase(){} // RVA: 0x7FFD537E8720
        public void LastIndexOfUnchecked(){} // RVA: 0x7FFD537E8930
        public void LastIndexOfUncheckedIgnoreCase(){} // RVA: 0x7FFD537E8A00
        public void StartsWithOrdinalUnchecked(){} // RVA: 0x7FFD537E8BC0
        public void FastAllocateString(){} // RVA: 0x7FFD537E8C10
        public void InternalIsInterned(){} // RVA: 0x7FFD537E8C20
        public void InternalIntern(){} // RVA: 0x7FFD537E8C30
        public void memset(){} // RVA: 0x7FFD537E8C40
        public void memcpy(){} // RVA: 0x7FFD537E8D30
        public void bzero(){} // RVA: 0x7FFD537E8D40
        public void bzero_aligned_1(){} // RVA: 0x7FFD4FDDD6A0
        public void bzero_aligned_2(){} // RVA: 0x7FFD537E8E30
        public void bzero_aligned_4(){} // RVA: 0x7FFD4FE1C580
        public void bzero_aligned_8(){} // RVA: 0x7FFD537E8E40
        public void memcpy_aligned_1(){} // RVA: 0x7FFD537E8E50
        public void memcpy_aligned_2(){} // RVA: 0x7FFD537E8E60
        public void memcpy_aligned_4(){} // RVA: 0x7FFD537E8E70
        public void memcpy_aligned_8(){} // RVA: 0x7FFD537E8E80
        public void CreateString(){} // RVA: 0x7FFD537E9210 | overloaded x8
        public void get_Chars(){} // RVA: 0x7FFD537E9320
        public void Intern(){} // RVA: 0x7FFD537E9350
        public void IsInterned(){} // RVA: 0x7FFD537E93C0
    }

    public class StringComparer : Object
    {
        public System.CultureAwareComparer InvariantCulture;
        public System.CultureAwareComparer InvariantCultureIgnoreCase; // 0x8
        public System.OrdinalCaseSensitiveComparer CurrentCulture; // 0x10
        public System.OrdinalIgnoreCaseComparer CurrentCultureIgnoreCase; // 0x18

        // ── Methods ──
        public void get_InvariantCulture(){} // RVA: 0x7FFD53A6CA80
        public void get_InvariantCultureIgnoreCase(){} // RVA: 0x7FFD53A6CAE0
        public void get_CurrentCulture(){} // RVA: 0x7FFD53A6CB40
        public void get_CurrentCultureIgnoreCase(){} // RVA: 0x7FFD53A6CC10
        public void get_Ordinal(){} // RVA: 0x7FFD53A6CCE0
        public void get_OrdinalIgnoreCase(){} // RVA: 0x7FFD53A6CD40
        public void FromComparison(){} // RVA: 0x7FFD53A6CDA0
        public void Create(){} // RVA: 0x7FFD53A6CF20
        public void Compare(){} // RVA: 0x7FFD4E0837A0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD4E07D200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E07E6B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53A6D320
    }

    public class SystemException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F917540 | overloaded x4
    }

}