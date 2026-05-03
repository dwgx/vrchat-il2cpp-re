// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Data
// Classes: 6
// Methods: 289

namespace VRC.SDK3.Data
{
    public class DataDictionary : Object
    {
        public System.Collections.Generic.Dictionary`2<VRC.SDK3.Data.DataToken,VRC.SDK3.Data.DataToken> _values; // 0x10
        public bool _isReadOnly; // 0x18
        public VRC.SDK3.Data.DataList keyCache; // 0x20

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE8A478330
        public void get_IsReadOnly(){} // RVA: 0x7FFE811164E0
        public void get_Item(){} // RVA: 0x7FFE8A478380
        public void set_Item(){} // RVA: 0x7FFE8A478430
        public void SetValue(){} // RVA: 0x7FFE8A478480
        public void TryGetValue(){} // RVA: 0x7FFE8A478880 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFE8A478930
        public void ShallowClone(){} // RVA: 0x7FFE8A478A60
        public void DeepClone(){} // RVA: 0x7FFE8A478CD0
        public void Clear(){} // RVA: 0x7FFE8A479220
        public void Remove(){} // RVA: 0x7FFE8A479D10 | overloaded x3
        public void ContainsKey(){} // RVA: 0x7FFE8A479470
        public void ContainsValue(){} // RVA: 0x7FFE8A479500
        public void ParseAll(){} // RVA: 0x7FFE810FB310
        public void GetKeys(){} // RVA: 0x7FFE8A479590
        public void GetValues(){} // RVA: 0x7FFE8A479690
        public void GetEnumerator(){} // RVA: 0x7FFE8A4797A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A4798E0
        public void Add(){} // RVA: 0x7FFE8A479A50 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE8A479B80
        public void CopyTo(){} // RVA: 0x7FFE8A479CD0
        public void Equals(){} // RVA: 0x7FFE8A479F20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86FE2840
        public void .ctor(){} // RVA: 0x7FFE8A47A080
    }

    public class DataList : Object
    {
        public System.Collections.Generic.List`1<VRC.SDK3.Data.DataToken> _values; // 0x10
        public bool _isReadOnly; // 0x18
        public object field_2; // 0xB7
        public object field_3; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A483730 | overloaded x4
        public void get_Count(){} // RVA: 0x7FFE8A483850
        public void get_Capacity(){} // RVA: 0x7FFE8A4838A0
        public void set_Capacity(){} // RVA: 0x7FFE8A4838F0
        public void TrimExcess(){} // RVA: 0x7FFE8A483950
        public void get_IsReadOnly(){} // RVA: 0x7FFE811164E0
        public void get_Item(){} // RVA: 0x7FFE8A4839E0
        public void set_Item(){} // RVA: 0x7FFE8A483A20
        public void SetValue(){} // RVA: 0x7FFE8A483A60
        public void TryGetValue(){} // RVA: 0x7FFE8A483CD0 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFE8A483D60
        public void Insert(){} // RVA: 0x7FFE8A483E70
        public void InsertRange(){} // RVA: 0x7FFE8A483EF0
        public void GetRange(){} // RVA: 0x7FFE8A483F60
        public void ShallowClone(){} // RVA: 0x7FFE8A484010
        public void DeepClone(){} // RVA: 0x7FFE8A484160
        public void ToArray(){} // RVA: 0x7FFE8A4844F0
        public void Add(){} // RVA: 0x7FFE8A484620
        public void AddRange(){} // RVA: 0x7FFE8A484720 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE8A484940
        public void IndexOf(){} // RVA: 0x7FFE8A484BA0 | overloaded x3
        public void LastIndexOf(){} // RVA: 0x7FFE8A484E10 | overloaded x3
        public void Remove(){} // RVA: 0x7FFE8A484EC0
        public void RemoveAll(){} // RVA: 0x7FFE8A484FA0
        public void Clear(){} // RVA: 0x7FFE8A485040
        public void RemoveAt(){} // RVA: 0x7FFE8A4850B0
        public void RemoveRange(){} // RVA: 0x7FFE8A485100
        public void Reverse(){} // RVA: 0x7FFE8A485200 | overloaded x2
        public void Sort(){} // RVA: 0x7FFE8A485300 | overloaded x2
        public void BinarySearch(){} // RVA: 0x7FFE8A485470 | overloaded x2
        public void ParseAll(){} // RVA: 0x7FFE8A485580
        public void ParseInRange(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFE8A485650
        public void GetEnumerator(){} // RVA: 0x7FFE8A4856D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8A4857F0
        public void Equals(){} // RVA: 0x7FFE8A485800 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86FE2840
    }

    public class DataToken : ValueType
    {
        public string _string; // 0x10
        public object _reference; // 0x10
        public bool _boolean; // 0x18
        public sbyte _sbyte; // 0x18
        public byte _byte; // 0x18
        public short _short; // 0x18
        public ushort _ushort; // 0x18
        public int _int; // 0x18
        public uint _uint; // 0x18
        public long _long; // 0x18
        public ulong _ulong; // 0x18
        public float _float; // 0x18
        public double _double; // 0x18
        public 0x6665CAF4 _error; // 0x18
        public 0x6665CB4C _tokenType; // 0x20
        public object field_15; // 0xBB
        public object field_16; // 0xBC
        public object field_17; // 0xBD
        public object field_18; // 0xBE
        public object field_19; // 0xBF
        public object field_20; // 0xC0

        // ── Methods ──
        public void get_TokenType(){} // RVA: 0x7FFE811C55E0
        public void get_IsEmpty(){} // RVA: 0x7FFE818F2DD0
        public void .ctor(){} // RVA: 0x7FFE8A48BE80 | overloaded x19
        public void get_Boolean(){} // RVA: 0x7FFE8A485CD0
        public void get_SByte(){} // RVA: 0x7FFE8A485DA0
        public void get_Byte(){} // RVA: 0x7FFE8A485E70
        public void get_Short(){} // RVA: 0x7FFE8A485F40
        public void get_UShort(){} // RVA: 0x7FFE8A486030
        public void get_Int(){} // RVA: 0x7FFE8A486110
        public void get_UInt(){} // RVA: 0x7FFE8A486220
        public void get_Long(){} // RVA: 0x7FFE8A486310
        public void get_ULong(){} // RVA: 0x7FFE8A486430
        public void get_Float(){} // RVA: 0x7FFE8A486530
        public void get_Double(){} // RVA: 0x7FFE8A4866F0
        public void get_Number(){} // RVA: 0x7FFE8A4868C0
        public void get_String(){} // RVA: 0x7FFE8A486A90
        public void get_DataList(){} // RVA: 0x7FFE8A486B60
        public void get_DataDictionary(){} // RVA: 0x7FFE8A486C90
        public void get_Reference(){} // RVA: 0x7FFE8A486DC0
        public void get_Error(){} // RVA: 0x7FFE8A486E90
        public void op_Explicit(){} // RVA: 0x7FFE8A486E90 | overloaded x15
        public void op_Implicit(){} // RVA: 0x7FFE8A487280 | overloaded x16
        public void get_IsNumber(){} // RVA: 0x7FFE8A4872A0
        public void get_IsNull(){} // RVA: 0x7FFE8A4872F0
        public void ToString(){} // RVA: 0x7FFE8A487400
        public void GetHashCode(){} // RVA: 0x7FFE8A487980
        public void CompareTo(){} // RVA: 0x7FFE8A487C40 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE8A48B1A0 | overloaded x31
        public void op_Inequality(){} // RVA: 0x7FFE8A48B220 | overloaded x31
        public void Equals(){} // RVA: 0x7FFE8A48B2A0 | overloaded x17
        public void Bitcast(){} // RVA: 0x7FFE8A48B300
        public void GetObjectData(){} // RVA: 0x7FFE8A48B4F0
    }

    public class JsonDictionary : DataDictionary
    {
        public string _source; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A48C8A0
        public void get_Count(){} // RVA: 0x7FFE8A48CA50
        public void SetValue(){} // RVA: 0x7FFE8A48CAC0
        public void GetValue(){} // RVA: 0x7FFE8A48CCB0
        public void Clear(){} // RVA: 0x7FFE8A48D020
        public void ContainsKey(){} // RVA: 0x7FFE8A48D0F0
        public void Remove(){} // RVA: 0x7FFE8A48D1F0
        public void ParseAll(){} // RVA: 0x7FFE8A48D2D0
        public void GetKeys(){} // RVA: 0x7FFE8A48D5F0
        public void Add(){} // RVA: 0x7FFE8A48D730
        public void AddLazyValue(){} // RVA: 0x7FFE8A48D970
    }

    public class JsonList : DataList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A48DA40
        public void GetValue(){} // RVA: 0x7FFE8A48DB10
        public void Insert(){} // RVA: 0x7FFE8A48DE30
        public void InsertRange(){} // RVA: 0x7FFE8A48DF70
        public void Add(){} // RVA: 0x7FFE8A48E070
        public void RemoveAt(){} // RVA: 0x7FFE8A48E1B0
        public void Clear(){} // RVA: 0x7FFE8A48E240
        public void RemoveRange(){} // RVA: 0x7FFE8A48E2F0
        public void Reverse(){} // RVA: 0x7FFE8A48E520 | overloaded x2
        public void ParseInRange(){} // RVA: 0x7FFE8A48E5C0
        public void AddLazyValue(){} // RVA: 0x7FFE8A48E820
        public void ClearLazyValue(){} // RVA: 0x7FFE8A48E950
    }

    public class VRCJson : Object
    {
        // ── Methods ──
        public void TryDeserializeFromJson(){} // RVA: 0x7FFE8A48EAD0
        public void TrySerializeToJson(){} // RVA: 0x7FFE8A48EFC0
        public void SerializeObject(){} // RVA: 0x7FFE8A48F5B0
        public void SerializeArray(){} // RVA: 0x7FFE8A490250
        public void AppendIndent(){} // RVA: 0x7FFE8A490CA0
        public void TryParseToken(){} // RVA: 0x7FFE8A490E00
        public void TryParseObject(){} // RVA: 0x7FFE8A490F80
        public void TryParseArray(){} // RVA: 0x7FFE8A4919A0
        public void TryParseString(){} // RVA: 0x7FFE8A4922A0
        public void TryParseNumber(){} // RVA: 0x7FFE8A4926C0
        public void TryParseBool(){} // RVA: 0x7FFE8A492FA0
        public void ScanObject(){} // RVA: 0x7FFE8A4933E0
        public void ScanArray(){} // RVA: 0x7FFE8A493600
        public void ScanString(){} // RVA: 0x7FFE8A4938D0
        public void ScanNumber(){} // RVA: 0x7FFE8A493B10
        public void ScanBool(){} // RVA: 0x7FFE8A493CD0
        public void ScanNull(){} // RVA: 0x7FFE8A493E80
        public void ScanUnknown(){} // RVA: 0x7FFE8A494010
        public void SkipWhitespace(){} // RVA: 0x7FFE8A494170
        public void IsComplexObject(){} // RVA: 0x7FFE8A494200
        public void GetStringEnd(){} // RVA: 0x7FFE8A494270
        public void IsComplexArray(){} // RVA: 0x7FFE8A4942E0
        public void SkipToCharacter(){} // RVA: 0x7FFE8A494350
        public void SkipToAnyCharacter(){} // RVA: 0x7FFE8A4943A0
        public void UnEscapeCharacter(){} // RVA: 0x7FFE8A4944C0
        public void EscapeString(){} // RVA: 0x7FFE8A4949A0
        public void TrimWhitespace(){} // RVA: 0x7FFE8A494AD0
        public void TryIdentifyType(){} // RVA: 0x7FFE8A494BF0
        public void .cctor(){} // RVA: 0x7FFE8A494E10
    }

}