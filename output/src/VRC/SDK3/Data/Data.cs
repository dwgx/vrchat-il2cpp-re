// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Data
// Classes: 6
// Methods: 289

namespace VRC.SDK3.Data
{
    public class DataDictionary : Object
    {
        public System.Collections.Generic.Dictionary`2<VRC.SDK3.Data.DataToken,VRC.SDK3.Data.DataToken> Count; // 0x10
        public bool IsReadOnly; // 0x18
        public VRC.SDK3.Data.DataList Item; // 0x20
        public bool keysDirty; // 0x28
        public VRC.SDK3.Data.DataList valueCache; // 0x30
        public bool valuesDirty; // 0x38

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFACC012A80
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F3C4E0
        public void get_Item(){} // RVA: 0x7FFACC012AD0
        public void set_Item(){} // RVA: 0x7FFACC012B80
        public void SetValue(){} // RVA: 0x7FFACC012BD0
        public void TryGetValue(){} // RVA: 0x7FFACC012FD0 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFACC013080
        public void ShallowClone(){} // RVA: 0x7FFACC0131B0
        public void DeepClone(){} // RVA: 0x7FFACC013420
        public void Clear(){} // RVA: 0x7FFACC013970
        public void Remove(){} // RVA: 0x7FFACC014460 | overloaded x3
        public void ContainsKey(){} // RVA: 0x7FFACC013BC0
        public void ContainsValue(){} // RVA: 0x7FFACC013C50
        public void ParseAll(){} // RVA: 0x7FFAC2F21310
        public void GetKeys(){} // RVA: 0x7FFACC013CE0
        public void GetValues(){} // RVA: 0x7FFACC013DE0
        public void GetEnumerator(){} // RVA: 0x7FFACC013EF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACC014030
        public void Add(){} // RVA: 0x7FFACC0141A0 | overloaded x2
        public void Contains(){} // RVA: 0x7FFACC0142D0
        public void CopyTo(){} // RVA: 0x7FFACC014420
        public void Equals(){} // RVA: 0x7FFACC014670 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8C3A320
        public void .ctor(){} // RVA: 0x7FFACC0147D0
    }

    public class DataList : Object
    {
        public System.Collections.Generic.List`1<VRC.SDK3.Data.DataToken> Count; // 0x10
        public bool Capacity; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC01DC40 | overloaded x4
        public void get_Count(){} // RVA: 0x7FFACC01DD60
        public void get_Capacity(){} // RVA: 0x7FFACC01DDB0
        public void set_Capacity(){} // RVA: 0x7FFACC01DE00
        public void TrimExcess(){} // RVA: 0x7FFACC01DE60
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F3C4E0
        public void get_Item(){} // RVA: 0x7FFACC01DEF0
        public void set_Item(){} // RVA: 0x7FFACC01DF30
        public void SetValue(){} // RVA: 0x7FFACC01DF70
        public void TryGetValue(){} // RVA: 0x7FFACC01E1E0 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFACC01E270
        public void Insert(){} // RVA: 0x7FFACC01E380
        public void InsertRange(){} // RVA: 0x7FFACC01E400
        public void GetRange(){} // RVA: 0x7FFACC01E470
        public void ShallowClone(){} // RVA: 0x7FFACC01E520
        public void DeepClone(){} // RVA: 0x7FFACC01E670
        public void ToArray(){} // RVA: 0x7FFACC01EA00
        public void Add(){} // RVA: 0x7FFACC01EB30
        public void AddRange(){} // RVA: 0x7FFACC01EC30 | overloaded x2
        public void Contains(){} // RVA: 0x7FFACC01EE50
        public void IndexOf(){} // RVA: 0x7FFACC01F0B0 | overloaded x3
        public void LastIndexOf(){} // RVA: 0x7FFACC01F320 | overloaded x3
        public void Remove(){} // RVA: 0x7FFACC01F3D0
        public void RemoveAll(){} // RVA: 0x7FFACC01F4B0
        public void Clear(){} // RVA: 0x7FFACC01F550
        public void RemoveAt(){} // RVA: 0x7FFACC01F5C0
        public void RemoveRange(){} // RVA: 0x7FFACC01F610
        public void Reverse(){} // RVA: 0x7FFACC01F710 | overloaded x2
        public void Sort(){} // RVA: 0x7FFACC01F810 | overloaded x2
        public void BinarySearch(){} // RVA: 0x7FFACC01F980 | overloaded x2
        public void ParseAll(){} // RVA: 0x7FFACC01FA90
        public void ParseInRange(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFACC01FB60
        public void GetEnumerator(){} // RVA: 0x7FFACC01FBE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFACC01FD00
        public void Equals(){} // RVA: 0x7FFACC01FD10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8C3A320
    }

    public class DataToken : ValueType
    {
        public string TokenType; // 0x10
        public object IsEmpty; // 0x10
        public bool Boolean; // 0x18
        public sbyte SByte; // 0x18
        public byte Byte; // 0x18
        public short Short; // 0x18
        public ushort UShort; // 0x18
        public int Int; // 0x18
        public uint UInt; // 0x18
        public long Long; // 0x18
        public ulong ULong; // 0x18
        public float Float; // 0x18
        public double Double; // 0x18
        public 0x6B262F18 Number; // 0x18
        public 0x6B262F70 String; // 0x20

        // ── Methods ──
        public void get_TokenType(){} // RVA: 0x7FFAC2FEB5E0
        public void get_IsEmpty(){} // RVA: 0x7FFAC37C9990
        public void .ctor(){} // RVA: 0x7FFACC026390 | overloaded x19
        public void get_Boolean(){} // RVA: 0x7FFACC0201E0
        public void get_SByte(){} // RVA: 0x7FFACC0202B0
        public void get_Byte(){} // RVA: 0x7FFACC020380
        public void get_Short(){} // RVA: 0x7FFACC020450
        public void get_UShort(){} // RVA: 0x7FFACC020540
        public void get_Int(){} // RVA: 0x7FFACC020620
        public void get_UInt(){} // RVA: 0x7FFACC020730
        public void get_Long(){} // RVA: 0x7FFACC020820
        public void get_ULong(){} // RVA: 0x7FFACC020940
        public void get_Float(){} // RVA: 0x7FFACC020A40
        public void get_Double(){} // RVA: 0x7FFACC020C00
        public void get_Number(){} // RVA: 0x7FFACC020DD0
        public void get_String(){} // RVA: 0x7FFACC020FA0
        public void get_DataList(){} // RVA: 0x7FFACC021070
        public void get_DataDictionary(){} // RVA: 0x7FFACC0211A0
        public void get_Reference(){} // RVA: 0x7FFACC0212D0
        public void get_Error(){} // RVA: 0x7FFACC0213A0
        public void op_Explicit(){} // RVA: 0x7FFACC0213A0 | overloaded x15
        public void op_Implicit(){} // RVA: 0x7FFACC021790 | overloaded x16
        public void get_IsNumber(){} // RVA: 0x7FFACC0217B0
        public void get_IsNull(){} // RVA: 0x7FFACC021800
        public void ToString(){} // RVA: 0x7FFACC021910
        public void GetHashCode(){} // RVA: 0x7FFACC021E90
        public void CompareTo(){} // RVA: 0x7FFACC022150 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFACC0256B0 | overloaded x31
        public void op_Inequality(){} // RVA: 0x7FFACC025730 | overloaded x31
        public void Equals(){} // RVA: 0x7FFACC0257B0 | overloaded x17
        public void Bitcast(){} // RVA: 0x7FFACC025810
        public void GetObjectData(){} // RVA: 0x7FFACC025A00
    }

    public class JsonDictionary : DataDictionary
    {
        public string Count; // 0x40
        public System.Collections.Generic.Dictionary`2<VRC.SDK3.Data.DataToken,System.ValueTuple`2<0x6B2630D0,int>> _lazyValues; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC026DB0
        public void get_Count(){} // RVA: 0x7FFACC026F60
        public void SetValue(){} // RVA: 0x7FFACC026FD0
        public void GetValue(){} // RVA: 0x7FFACC0271C0
        public void Clear(){} // RVA: 0x7FFACC027530
        public void ContainsKey(){} // RVA: 0x7FFACC027600
        public void Remove(){} // RVA: 0x7FFACC027700
        public void ParseAll(){} // RVA: 0x7FFACC0277E0
        public void GetKeys(){} // RVA: 0x7FFACC027B00
        public void Add(){} // RVA: 0x7FFACC027C40
        public void AddLazyValue(){} // RVA: 0x7FFACC027E80
    }

    public class JsonList : DataList
    {
        public System.Collections.Generic.List`1<System.ValueTuple`2<0x6B2630D0,string>> _lazyValues; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC027F50
        public void GetValue(){} // RVA: 0x7FFACC028020
        public void Insert(){} // RVA: 0x7FFACC028340
        public void InsertRange(){} // RVA: 0x7FFACC028480
        public void Add(){} // RVA: 0x7FFACC028580
        public void RemoveAt(){} // RVA: 0x7FFACC0286C0
        public void Clear(){} // RVA: 0x7FFACC028750
        public void RemoveRange(){} // RVA: 0x7FFACC028800
        public void Reverse(){} // RVA: 0x7FFACC028A30 | overloaded x2
        public void ParseInRange(){} // RVA: 0x7FFACC028AD0
        public void AddLazyValue(){} // RVA: 0x7FFACC028D30
        public void ClearLazyValue(){} // RVA: 0x7FFACC028E60
    }

    public class VRCJson : Object
    {
        public char[] parseArrayChars;
        public char[] scanObjectChars; // 0x8
        public char[] scanArrayChars; // 0x10
        public char[] scanStringChars; // 0x18
        public char[] scanWordChars; // 0x20
        public char[] whitespaceChars; // 0x28
        public char[] numberChars; // 0x30
        public System.Collections.Generic.HashSet`1<VRC.SDK3.Data.DataToken> seenContainers; // 0x38

        // ── Methods ──
        public void TryDeserializeFromJson(){} // RVA: 0x7FFACC028FE0
        public void TrySerializeToJson(){} // RVA: 0x7FFACC0294E0
        public void SerializeObject(){} // RVA: 0x7FFACC029AD0
        public void SerializeArray(){} // RVA: 0x7FFACC02A770
        public void AppendIndent(){} // RVA: 0x7FFACC02B1C0
        public void TryParseToken(){} // RVA: 0x7FFACC02B320
        public void TryParseObject(){} // RVA: 0x7FFACC02B4A0
        public void TryParseArray(){} // RVA: 0x7FFACC02BEC0
        public void TryParseString(){} // RVA: 0x7FFACC02C7C0
        public void TryParseNumber(){} // RVA: 0x7FFACC02CBE0
        public void TryParseBool(){} // RVA: 0x7FFACC02D4C0
        public void ScanObject(){} // RVA: 0x7FFACC02D900
        public void ScanArray(){} // RVA: 0x7FFACC02DB20
        public void ScanString(){} // RVA: 0x7FFACC02DDF0
        public void ScanNumber(){} // RVA: 0x7FFACC02E030
        public void ScanBool(){} // RVA: 0x7FFACC02E1F0
        public void ScanNull(){} // RVA: 0x7FFACC02E3A0
        public void ScanUnknown(){} // RVA: 0x7FFACC02E530
        public void SkipWhitespace(){} // RVA: 0x7FFACC02E690
        public void IsComplexObject(){} // RVA: 0x7FFACC02E720
        public void GetStringEnd(){} // RVA: 0x7FFACC02E790
        public void IsComplexArray(){} // RVA: 0x7FFACC02E800
        public void SkipToCharacter(){} // RVA: 0x7FFACC02E870
        public void SkipToAnyCharacter(){} // RVA: 0x7FFACC02E8C0
        public void UnEscapeCharacter(){} // RVA: 0x7FFACC02E9E0
        public void EscapeString(){} // RVA: 0x7FFACC02EEC0
        public void TrimWhitespace(){} // RVA: 0x7FFACC02EFF0
        public void TryIdentifyType(){} // RVA: 0x7FFACC02F110
        public void .cctor(){} // RVA: 0x7FFACC02F330
    }

}