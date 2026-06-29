// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Data
// Classes: 6
// Methods: 146

namespace VRC.SDK3.Data
{
    public class DataDictionary : Object
    {
        public object _values;
        public object _isReadOnly;
        public object keyCache;
        public object keysDirty;
        public object valueCache;
        public object valuesDirty;

        // ── Methods ──
        public void get_Count(){} // RVA: 0xA6D1A70
        public void get_IsReadOnly(){} // RVA: 0xB5DD50
        public void .ctor(){} // RVA: 0xA6D1C00
        public void get_Item(){} // RVA: 0xA6D1CF0
        public void set_Item(){} // RVA: 0xA6D1DA0
        public void SetValue(){} // RVA: 0xA6D1DF0
        public void TryGetValue(){} // RVA: 0xA6D21F0
        public void GetValue(){} // RVA: 0xA6D22A0
        public void ShallowClone(){} // RVA: 0xA6D23D0
        public void DeepClone(){} // RVA: 0xA6D2680
        public void Clear(){} // RVA: 0xA6D2BF0
        public void Remove(){} // RVA: 0xA6D3840
        public void ContainsKey(){} // RVA: 0xA6D2E40
        public void ContainsValue(){} // RVA: 0xA6D2ED0
        public void EnsureCapacity(){} // RVA: 0xA6D2F60
        public void ParseAll(){} // RVA: 0xB43310
        public void GetKeys(){} // RVA: 0xA6D3080
        public void GetValues(){} // RVA: 0xA6D31A0
        public void GetEnumerator(){} // RVA: 0xA6D32D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xA6D3410
        public void Add(){} // RVA: 0xA6D3580
        public void Contains(){} // RVA: 0xA6D36B0
        public void CopyTo(){} // RVA: 0xA6D3800
        public void Equals(){} // RVA: 0xA6D3A50
        public void GetHashCode(){} // RVA: 0x6F0FA20
    }

    public class DataList : Object
    {
        public object _values;
        public object _isReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Count(){} // RVA: 0xA6D4190
        public void get_Capacity(){} // RVA: 0xA6D41E0
        public void set_Capacity(){} // RVA: 0xA6D4230
        public void TrimExcess(){} // RVA: 0xA6D4290
        public void get_IsReadOnly(){} // RVA: 0xB5DD50
        public void get_Item(){} // RVA: 0xA6D4320
        public void set_Item(){} // RVA: 0xA6D4360
        public void SetValue(){} // RVA: 0xA6D43A0
        public void TryGetValue(){} // RVA: 0xA6D4620
        public void GetValue(){} // RVA: 0xA6D46B0
        public void Insert(){} // RVA: 0xA6D47C0
        public void InsertRange(){} // RVA: 0xA6D4840
        public void GetRange(){} // RVA: 0xA6D48B0
        public void ShallowClone(){} // RVA: 0xA6D49A0
        public void DeepClone(){} // RVA: 0xA6D4B30
        public void ToArray(){} // RVA: 0xA6D4EB0
        public void Add(){} // RVA: 0xA6D4FE0
        public void AddRange(){} // RVA: 0xA6D50E0
        public void Contains(){} // RVA: 0xA6D5310
        public void IndexOf(){} // RVA: 0xA6D5570
        public void LastIndexOf(){} // RVA: 0xA6D57E0
        public void Remove(){} // RVA: 0xA6D5890
        public void RemoveAll(){} // RVA: 0xA6D5970
        public void Clear(){} // RVA: 0xA6D5A10
        public void RemoveAt(){} // RVA: 0xA6D5A80
        public void RemoveRange(){} // RVA: 0xA6D5AD0
        public void Reverse(){} // RVA: 0xA6D5BD0
        public void Sort(){} // RVA: 0xA6D5CD0
        public void BinarySearch(){} // RVA: 0xA6D5E10
        public void ParseAll(){} // RVA: 0xA6D5ED0
        public void ParseInRange(){} // RVA: 0xB43310
        public void CopyTo(){} // RVA: 0xA6D5FA0
        public void GetEnumerator(){} // RVA: 0xA6D6020
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xA6D6140
        public void Equals(){} // RVA: 0xA6D6150
        public void GetHashCode(){} // RVA: 0x6F0FA20
    }

    public class DataToken : ValueType
    {
        public object _string;
        public object _reference;
        public object _boolean;
        public object _sbyte;
        public object _byte;
        public object _short;
        public object _ushort;
        public object _int;
        public object _uint;
        public object _long;
        public object _ulong;
        public object _float;
        public object _double;
        public object _error;
        public object _tokenType;

        // ── Methods ──
        public void get_TokenType(){} // RVA: 0xB1800
        public void get_IsEmpty(){} // RVA: 0xA71E10
        public void .ctor(){} // RVA: 0xA77170
        public void get_Boolean(){} // RVA: 0xA76D20
        public void get_SByte(){} // RVA: 0xA76D30
        public void get_Byte(){} // RVA: 0xA76D40
        public void get_Short(){} // RVA: 0xA76D50
        public void get_UShort(){} // RVA: 0xA76D60
        public void get_Int(){} // RVA: 0xA76D70
        public void get_UInt(){} // RVA: 0xA76D80
        public void get_Long(){} // RVA: 0xA76D90
        public void get_ULong(){} // RVA: 0xA76DA0
        public void get_Float(){} // RVA: 0xA76DB0
        public void get_Double(){} // RVA: 0xA76DC0
        public void get_Number(){} // RVA: 0xA76DD0
        public void get_String(){} // RVA: 0xA76DE0
        public void get_DataList(){} // RVA: 0xA76DF0
        public void get_DataDictionary(){} // RVA: 0xA76E00
        public void get_Reference(){} // RVA: 0xA76E10
        public void get_Error(){} // RVA: 0xA76E20
        public void op_Explicit(){} // RVA: 0xA6D77D0
        public void op_Implicit(){} // RVA: 0xA6D7BC0
        public void get_IsNumber(){} // RVA: 0xA76E30
        public void get_IsNull(){} // RVA: 0xA76E80
        public void ToString(){} // RVA: 0xA76E90
        public void GetHashCode(){} // RVA: 0xA76EA0
        public void CompareTo(){} // RVA: 0xA76EC0
        public void op_Equality(){} // RVA: 0xA6DBD80
        public void op_Inequality(){} // RVA: 0xA6DBE00
        public void Equals(){} // RVA: 0xA770C0
        public void Bitcast(){} // RVA: 0xA77120
        public void GetObjectData(){} // RVA: 0xA77150
    }

    public class JsonDictionary : DataDictionary
    {
        public object _source;
        public object _lazyValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6DDA20
        public void get_Count(){} // RVA: 0xA6DDBD0
        public void SetValue(){} // RVA: 0xA6DDC40
        public void GetValue(){} // RVA: 0xA6DDE30
        public void Clear(){} // RVA: 0xA6DE1A0
        public void ContainsKey(){} // RVA: 0xA6DE270
        public void Remove(){} // RVA: 0xA6DE370
        public void ParseAll(){} // RVA: 0xA6DE450
        public void GetKeys(){} // RVA: 0xA6DE780
        public void Add(){} // RVA: 0xA6DE8E0
        public void AddLazyValue(){} // RVA: 0xA6DEB20
    }

    public class JsonList : DataList
    {
        public object _lazyValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6DEBF0
        public void GetValue(){} // RVA: 0xA6DECC0
        public void Insert(){} // RVA: 0xA6DEFE0
        public void InsertRange(){} // RVA: 0xA6DF110
        public void Add(){} // RVA: 0xA6DF210
        public void RemoveAt(){} // RVA: 0xA6DF340
        public void Clear(){} // RVA: 0xA6DF3D0
        public void RemoveRange(){} // RVA: 0xA6DF480
        public void Reverse(){} // RVA: 0xA6DF6B0
        public void ParseInRange(){} // RVA: 0xA6DF750
        public void AddLazyValue(){} // RVA: 0xA6DF9C0
        public void ClearLazyValue(){} // RVA: 0xA6DFAF0
    }

    public class VRCJson : Object
    {
        public object parseArrayChars;
        public object scanObjectChars;
        public object scanArrayChars;
        public object scanStringChars;
        public object scanWordChars;
        public object whitespaceChars;
        public object numberChars;
        public object seenContainers;

        // ── Methods ──
        public void TryDeserializeFromJson(){} // RVA: 0xA6DFC70
        public void TrySerializeToJson(){} // RVA: 0xA6E0160
        public void SerializeObject(){} // RVA: 0xA6E0750
        public void SerializeArray(){} // RVA: 0xA6E13F0
        public void AppendIndent(){} // RVA: 0xA6E1E30
        public void TryParseToken(){} // RVA: 0xA6E1F90
        public void TryParseObject(){} // RVA: 0xA6E2110
        public void TryParseArray(){} // RVA: 0xA6E2AF0
        public void TryParseString(){} // RVA: 0xA6E3550
        public void TryParseNumber(){} // RVA: 0xA6E3960
        public void TryParseBool(){} // RVA: 0xA6E4230
        public void ScanObject(){} // RVA: 0xA6E4680
        public void ScanArray(){} // RVA: 0xA6E48A0
        public void ScanString(){} // RVA: 0xA6E4B70
        public void ScanNumber(){} // RVA: 0xA6E4DB0
        public void ScanBool(){} // RVA: 0xA6E4F60
        public void ScanNull(){} // RVA: 0xA6E5110
        public void ScanUnknown(){} // RVA: 0xA6E52A0
        public void SkipWhitespace(){} // RVA: 0xA6E5400
        public void IsComplexObject(){} // RVA: 0xA6E5470
        public void GetStringEnd(){} // RVA: 0xA6E54E0
        public void IsComplexArray(){} // RVA: 0xA6E5550
        public void SkipToCharacter(){} // RVA: 0xA6E55C0
        public void SkipToAnyCharacter(){} // RVA: 0xA6E5610
        public void UnEscapeCharacter(){} // RVA: 0xA6E5730
        public void EscapeString(){} // RVA: 0xA6E5BF0
        public void TrimWhitespace(){} // RVA: 0xA6E5D20
        public void TryIdentifyType(){} // RVA: 0xA6E5E40
        public void .cctor(){} // RVA: 0xA6E6040
    }

}