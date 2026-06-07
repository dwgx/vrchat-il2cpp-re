// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Data
// Classes: 6
// Methods: 292

namespace VRC.SDK3.Data
{
    public class DataDictionary
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x9A1C8C0
        public void get_IsReadOnly(){} // RVA: 0x2F84E0
        public void .ctor(){} // RVA: 0x9A1CA50 | overloaded x2
        public void get_Item(){} // RVA: 0x9A1CB40
        public void set_Item(){} // RVA: 0x9A1CBF0
        public void SetValue(){} // RVA: 0x9A1CC40
        public void TryGetValue(){} // RVA: 0x9A1D040 | overloaded x2
        public void GetValue(){} // RVA: 0x9A1D0F0
        public void ShallowClone(){} // RVA: 0x9A1D220
        public void DeepClone(){} // RVA: 0x9A1D4D0
        public void Clear(){} // RVA: 0x9A1DA40
        public void Remove(){} // RVA: 0x9A1E690 | overloaded x3
        public void ContainsKey(){} // RVA: 0x9A1DC90
        public void ContainsValue(){} // RVA: 0x9A1DD20
        public void EnsureCapacity(){} // RVA: 0x9A1DDB0
        public void ParseAll(){} // RVA: 0x2DD310
        public void GetKeys(){} // RVA: 0x9A1DED0
        public void GetValues(){} // RVA: 0x9A1DFF0
        public void GetEnumerator(){} // RVA: 0x9A1E120
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x9A1E260
        public void Add(){} // RVA: 0x9A1E3D0 | overloaded x2
        public void Contains(){} // RVA: 0x9A1E500
        public void CopyTo(){} // RVA: 0x9A1E650
        public void Equals(){} // RVA: 0x9A1E8A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x64A3790
    }

    public class DataList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x5
        public void get_Count(){} // RVA: 0x9A27F20
        public void get_Capacity(){} // RVA: 0x9A27F70
        public void set_Capacity(){} // RVA: 0x9A27FC0
        public void TrimExcess(){} // RVA: 0x9A28020
        public void get_IsReadOnly(){} // RVA: 0x2F84E0
        public void get_Item(){} // RVA: 0x9A280B0
        public void set_Item(){} // RVA: 0x9A280F0
        public void SetValue(){} // RVA: 0x9A28130
        public void TryGetValue(){} // RVA: 0x9A283A0 | overloaded x2
        public void GetValue(){} // RVA: 0x9A28430
        public void Insert(){} // RVA: 0x9A28540
        public void InsertRange(){} // RVA: 0x9A285C0
        public void GetRange(){} // RVA: 0x9A28630
        public void ShallowClone(){} // RVA: 0x9A28720
        public void DeepClone(){} // RVA: 0x9A288B0
        public void ToArray(){} // RVA: 0x9A28C40
        public void Add(){} // RVA: 0x9A28D70
        public void AddRange(){} // RVA: 0x9A28E70 | overloaded x2
        public void Contains(){} // RVA: 0x9A29090
        public void IndexOf(){} // RVA: 0x9A292F0 | overloaded x3
        public void LastIndexOf(){} // RVA: 0x9A29560 | overloaded x3
        public void Remove(){} // RVA: 0x9A29610
        public void RemoveAll(){} // RVA: 0x9A296F0
        public void Clear(){} // RVA: 0x9A29790
        public void RemoveAt(){} // RVA: 0x9A29800
        public void RemoveRange(){} // RVA: 0x9A29850
        public void Reverse(){} // RVA: 0x9A29950 | overloaded x2
        public void Sort(){} // RVA: 0x9A29A50 | overloaded x2
        public void BinarySearch(){} // RVA: 0x9A29BC0 | overloaded x2
        public void ParseAll(){} // RVA: 0x9A29CD0
        public void ParseInRange(){} // RVA: 0x2DD310 | overloaded x2
        public void CopyTo(){} // RVA: 0x9A29DA0
        public void GetEnumerator(){} // RVA: 0x9A29E20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x9A29F40
        public void Equals(){} // RVA: 0x9A29F50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x64A3790
    }

    public class DataToken
    {
        // ── Methods ──
        public void get_TokenType(){} // RVA: 0x3A75E0
        public void get_IsEmpty(){} // RVA: 0xB84FF0
        public void .ctor(){} // RVA: 0x9A305D0 | overloaded x19
        public void get_Boolean(){} // RVA: 0x9A2A420
        public void get_SByte(){} // RVA: 0x9A2A4F0
        public void get_Byte(){} // RVA: 0x9A2A5C0
        public void get_Short(){} // RVA: 0x9A2A690
        public void get_UShort(){} // RVA: 0x9A2A780
        public void get_Int(){} // RVA: 0x9A2A860
        public void get_UInt(){} // RVA: 0x9A2A970
        public void get_Long(){} // RVA: 0x9A2AA60
        public void get_ULong(){} // RVA: 0x9A2AB80
        public void get_Float(){} // RVA: 0x9A2AC80
        public void get_Double(){} // RVA: 0x9A2AE40
        public void get_Number(){} // RVA: 0x9A2B010
        public void get_String(){} // RVA: 0x9A2B1E0
        public void get_DataList(){} // RVA: 0x9A2B2B0
        public void get_DataDictionary(){} // RVA: 0x9A2B3E0
        public void get_Reference(){} // RVA: 0x9A2B510
        public void get_Error(){} // RVA: 0x9A2B5E0
        public void op_Explicit(){} // RVA: 0x9A2B5E0 | overloaded x15
        public void op_Implicit(){} // RVA: 0x9A2B9D0 | overloaded x16
        public void get_IsNumber(){} // RVA: 0x9A2B9F0
        public void get_IsNull(){} // RVA: 0x9A2BA40
        public void ToString(){} // RVA: 0x9A2BB50
        public void GetHashCode(){} // RVA: 0x9A2C0D0
        public void CompareTo(){} // RVA: 0x9A2C390 | overloaded x2
        public void op_Equality(){} // RVA: 0x9A2F8F0 | overloaded x31
        public void op_Inequality(){} // RVA: 0x9A2F970 | overloaded x31
        public void Equals(){} // RVA: 0x9A2F9F0 | overloaded x17
        public void Bitcast(){} // RVA: 0x9A2FA50
        public void GetObjectData(){} // RVA: 0x9A2FC40
    }

    public class JsonDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A30FF0
        public void get_Count(){} // RVA: 0x9A311A0
        public void SetValue(){} // RVA: 0x9A31210
        public void GetValue(){} // RVA: 0x9A31400
        public void Clear(){} // RVA: 0x9A31770
        public void ContainsKey(){} // RVA: 0x9A31840
        public void Remove(){} // RVA: 0x9A31940
        public void ParseAll(){} // RVA: 0x9A31A20
        public void GetKeys(){} // RVA: 0x9A31D40
        public void Add(){} // RVA: 0x9A31EA0
        public void AddLazyValue(){} // RVA: 0x9A320E0
    }

    public class JsonList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A321B0
        public void GetValue(){} // RVA: 0x9A32280
        public void Insert(){} // RVA: 0x9A325A0
        public void InsertRange(){} // RVA: 0x9A326E0
        public void Add(){} // RVA: 0x9A327E0
        public void RemoveAt(){} // RVA: 0x9A32920
        public void Clear(){} // RVA: 0x9A329B0
        public void RemoveRange(){} // RVA: 0x9A32A60
        public void Reverse(){} // RVA: 0x9A32C90 | overloaded x2
        public void ParseInRange(){} // RVA: 0x9A32D30
        public void AddLazyValue(){} // RVA: 0x9A32F90
        public void ClearLazyValue(){} // RVA: 0x9A330C0
    }

    public class VRCJson
    {
        // ── Methods ──
        public void TryDeserializeFromJson(){} // RVA: 0x9A33240
        public void TrySerializeToJson(){} // RVA: 0x9A33740
        public void SerializeObject(){} // RVA: 0x9A33D30
        public void SerializeArray(){} // RVA: 0x9A349D0
        public void AppendIndent(){} // RVA: 0x9A35420
        public void TryParseToken(){} // RVA: 0x9A35580
        public void TryParseObject(){} // RVA: 0x9A35700
        public void TryParseArray(){} // RVA: 0x9A36120
        public void TryParseString(){} // RVA: 0x9A36A20
        public void TryParseNumber(){} // RVA: 0x9A36E40
        public void TryParseBool(){} // RVA: 0x9A37720
        public void ScanObject(){} // RVA: 0x9A37B60
        public void ScanArray(){} // RVA: 0x9A37D80
        public void ScanString(){} // RVA: 0x9A38050
        public void ScanNumber(){} // RVA: 0x9A38290
        public void ScanBool(){} // RVA: 0x9A38450
        public void ScanNull(){} // RVA: 0x9A38600
        public void ScanUnknown(){} // RVA: 0x9A38790
        public void SkipWhitespace(){} // RVA: 0x9A388F0
        public void IsComplexObject(){} // RVA: 0x9A38980
        public void GetStringEnd(){} // RVA: 0x9A389F0
        public void IsComplexArray(){} // RVA: 0x9A38A60
        public void SkipToCharacter(){} // RVA: 0x9A38AD0
        public void SkipToAnyCharacter(){} // RVA: 0x9A38B20
        public void UnEscapeCharacter(){} // RVA: 0x9A38C40
        public void EscapeString(){} // RVA: 0x9A39120
        public void TrimWhitespace(){} // RVA: 0x9A39250
        public void TryIdentifyType(){} // RVA: 0x9A39370
        public void .cctor(){} // RVA: 0x9A39590
    }

}