// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Data
// Classes: 6
// Methods: 146

namespace VRC.SDK3.Data
{
    public class DataDictionary : Object
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7B1864C40
        public void get_IsReadOnly(){} // RVA: 0x7A80F26D0
        public void .ctor(){} // RVA: 0x7B1864DD0
        public void get_Item(){} // RVA: 0x7B1864EC0
        public void set_Item(){} // RVA: 0x7B1864F70
        public void SetValue(){} // RVA: 0x7B1864FC0
        public void TryGetValue(){} // RVA: 0x7B18653C0
        public void GetValue(){} // RVA: 0x7B1865470
        public void ShallowClone(){} // RVA: 0x7B18655A0
        public void DeepClone(){} // RVA: 0x7B1865850
        public void Clear(){} // RVA: 0x7B1865DC0
        public void Remove(){} // RVA: 0x7B1866A10
        public void ContainsKey(){} // RVA: 0x7B1866010
        public void ContainsValue(){} // RVA: 0x7B18660A0
        public void EnsureCapacity(){} // RVA: 0x7B1866130
        public void ParseAll(){} // RVA: 0x7A80D7310
        public void GetKeys(){} // RVA: 0x7B1866250
        public void GetValues(){} // RVA: 0x7B1866370
        public void GetEnumerator(){} // RVA: 0x7B18664A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7B18665E0
        public void Add(){} // RVA: 0x7B1866750
        public void Contains(){} // RVA: 0x7B1866880
        public void CopyTo(){} // RVA: 0x7B18669D0
        public void Equals(){} // RVA: 0x7B1866C20
        public void GetHashCode(){} // RVA: 0x7AE290990
    }

    public class DataList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Count(){} // RVA: 0x7B1867370
        public void get_Capacity(){} // RVA: 0x7B18673C0
        public void set_Capacity(){} // RVA: 0x7B1867410
        public void TrimExcess(){} // RVA: 0x7B1867470
        public void get_IsReadOnly(){} // RVA: 0x7A80F26D0
        public void get_Item(){} // RVA: 0x7B1867500
        public void set_Item(){} // RVA: 0x7B1867540
        public void SetValue(){} // RVA: 0x7B1867580
        public void TryGetValue(){} // RVA: 0x7B1867800
        public void GetValue(){} // RVA: 0x7B1867890
        public void Insert(){} // RVA: 0x7B18679A0
        public void InsertRange(){} // RVA: 0x7B1867A20
        public void GetRange(){} // RVA: 0x7B1867A90
        public void ShallowClone(){} // RVA: 0x7B1867B80
        public void DeepClone(){} // RVA: 0x7B1867D10
        public void ToArray(){} // RVA: 0x7B1868090
        public void Add(){} // RVA: 0x7B18681C0
        public void AddRange(){} // RVA: 0x7B18682C0
        public void Contains(){} // RVA: 0x7B18684F0
        public void IndexOf(){} // RVA: 0x7B1868750
        public void LastIndexOf(){} // RVA: 0x7B18689C0
        public void Remove(){} // RVA: 0x7B1868A70
        public void RemoveAll(){} // RVA: 0x7B1868B50
        public void Clear(){} // RVA: 0x7B1868BF0
        public void RemoveAt(){} // RVA: 0x7B1868C60
        public void RemoveRange(){} // RVA: 0x7B1868CB0
        public void Reverse(){} // RVA: 0x7B1868DB0
        public void Sort(){} // RVA: 0x7B1868EB0
        public void BinarySearch(){} // RVA: 0x7B1868FF0
        public void ParseAll(){} // RVA: 0x7B18690B0
        public void ParseInRange(){} // RVA: 0x7A80D7310
        public void CopyTo(){} // RVA: 0x7B1869180
        public void GetEnumerator(){} // RVA: 0x7B1869200
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7B1869320
        public void Equals(){} // RVA: 0x7B1869330
        public void GetHashCode(){} // RVA: 0x7AE290990
    }

    public class DataToken : ValueType
    {
        // ── Methods ──
        public void get_TokenType(){} // RVA: 0x7A769A8A0
        public void get_IsEmpty(){} // RVA: 0x7A7FC3440
        public void .ctor(){} // RVA: 0x7A7FC8900
        public void get_Boolean(){} // RVA: 0x7A7FC84B0
        public void get_SByte(){} // RVA: 0x7A7FC84C0
        public void get_Byte(){} // RVA: 0x7A7FC84D0
        public void get_Short(){} // RVA: 0x7A7FC84E0
        public void get_UShort(){} // RVA: 0x7A7FC84F0
        public void get_Int(){} // RVA: 0x7A7FC8500
        public void get_UInt(){} // RVA: 0x7A7FC8510
        public void get_Long(){} // RVA: 0x7A7FC8520
        public void get_ULong(){} // RVA: 0x7A7FC8530
        public void get_Float(){} // RVA: 0x7A7FC8540
        public void get_Double(){} // RVA: 0x7A7FC8550
        public void get_Number(){} // RVA: 0x7A7FC8560
        public void get_String(){} // RVA: 0x7A7FC8570
        public void get_DataList(){} // RVA: 0x7A7FC8580
        public void get_DataDictionary(){} // RVA: 0x7A7FC8590
        public void get_Reference(){} // RVA: 0x7A7FC85A0
        public void get_Error(){} // RVA: 0x7A7FC85B0
        public void op_Explicit(){} // RVA: 0x7B186A9C0
        public void op_Implicit(){} // RVA: 0x7B186ADB0
        public void get_IsNumber(){} // RVA: 0x7A7FC85C0
        public void get_IsNull(){} // RVA: 0x7A7FC8610
        public void ToString(){} // RVA: 0x7A7FC8620
        public void GetHashCode(){} // RVA: 0x7A7FC8630
        public void CompareTo(){} // RVA: 0x7A7FC8650
        public void op_Equality(){} // RVA: 0x7B186EFD0
        public void op_Inequality(){} // RVA: 0x7B186F050
        public void Equals(){} // RVA: 0x7A7FC8850
        public void Bitcast(){} // RVA: 0x7A7FC88B0
        public void GetObjectData(){} // RVA: 0x7A7FC88E0
    }

    public class JsonDictionary : DataDictionary
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B18706E0
        public void get_Count(){} // RVA: 0x7B1870890
        public void SetValue(){} // RVA: 0x7B1870900
        public void GetValue(){} // RVA: 0x7B1870AF0
        public void Clear(){} // RVA: 0x7B1870E60
        public void ContainsKey(){} // RVA: 0x7B1870F30
        public void Remove(){} // RVA: 0x7B1871030
        public void ParseAll(){} // RVA: 0x7B1871110
        public void GetKeys(){} // RVA: 0x7B1871440
        public void Add(){} // RVA: 0x7B18715A0
        public void AddLazyValue(){} // RVA: 0x7B18717E0
    }

    public class JsonList : DataList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B18718B0
        public void GetValue(){} // RVA: 0x7B1871980
        public void Insert(){} // RVA: 0x7B1871CA0
        public void InsertRange(){} // RVA: 0x7B1871DE0
        public void Add(){} // RVA: 0x7B1871EE0
        public void RemoveAt(){} // RVA: 0x7B1872020
        public void Clear(){} // RVA: 0x7B18720B0
        public void RemoveRange(){} // RVA: 0x7B1872160
        public void Reverse(){} // RVA: 0x7B1872390
        public void ParseInRange(){} // RVA: 0x7B1872430
        public void AddLazyValue(){} // RVA: 0x7B18726A0
        public void ClearLazyValue(){} // RVA: 0x7B18727D0
    }

    public class VRCJson : Object
    {
        // ── Methods ──
        public void TryDeserializeFromJson(){} // RVA: 0x7B1872950
        public void TrySerializeToJson(){} // RVA: 0x7B1872E40
        public void SerializeObject(){} // RVA: 0x7B1873430
        public void SerializeArray(){} // RVA: 0x7B18740D0
        public void AppendIndent(){} // RVA: 0x7B1874B20
        public void TryParseToken(){} // RVA: 0x7B1874C80
        public void TryParseObject(){} // RVA: 0x7B1874E00
        public void TryParseArray(){} // RVA: 0x7B1875830
        public void TryParseString(){} // RVA: 0x7B18761E0
        public void TryParseNumber(){} // RVA: 0x7B18765F0
        public void TryParseBool(){} // RVA: 0x7B1876ED0
        public void ScanObject(){} // RVA: 0x7B1877320
        public void ScanArray(){} // RVA: 0x7B1877540
        public void ScanString(){} // RVA: 0x7B1877810
        public void ScanNumber(){} // RVA: 0x7B1877A50
        public void ScanBool(){} // RVA: 0x7B1877C10
        public void ScanNull(){} // RVA: 0x7B1877DC0
        public void ScanUnknown(){} // RVA: 0x7B1877F50
        public void SkipWhitespace(){} // RVA: 0x7B18780B0
        public void IsComplexObject(){} // RVA: 0x7B1878140
        public void GetStringEnd(){} // RVA: 0x7B18781B0
        public void IsComplexArray(){} // RVA: 0x7B1878220
        public void SkipToCharacter(){} // RVA: 0x7B1878290
        public void SkipToAnyCharacter(){} // RVA: 0x7B18782E0
        public void UnEscapeCharacter(){} // RVA: 0x7B1878400
        public void EscapeString(){} // RVA: 0x7B1878850
        public void TrimWhitespace(){} // RVA: 0x7B1878980
        public void TryIdentifyType(){} // RVA: 0x7B1878AA0
        public void .cctor(){} // RVA: 0x7B1878CD0
    }

}