// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
// Classes: 14
// Methods: 134

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
{
    public class BsonArray
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Bson.BsonToken> _children; // 0x20

        // ── Methods ──
        public void Add(){} // RVA: 0x607DCD0
        public void get_Type(){} // RVA: 0x607DDD0
        public void GetEnumerator(){} // RVA: 0x607DDE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x607DED0
        public void .ctor(){} // RVA: 0x607DEE0
    }

    public class BsonBinary
    {
        public 0x658E8E00 <BinaryType>k__BackingField; // 0x30

        // ── Methods ──
        public void get_BinaryType(){} // RVA: 0x303450
        public void set_BinaryType(){} // RVA: 0x303460
        public void .ctor(){} // RVA: 0x607E3A0
    }

    public class BsonBinaryWriter
    {
        public System.Text.Encoding Value;

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x760030
        public void set_DateTimeKindHandling(){} // RVA: 0x99E0D0
        public void .ctor(){} // RVA: 0x6078730
        public void Flush(){} // RVA: 0x5D12EC0
        public void Close(){} // RVA: 0x7F02E0
        public void WriteToken(){} // RVA: 0x6078790
        public void WriteTokenInternal(){} // RVA: 0x60787C0
        public void WriteString(){} // RVA: 0x6079720
        public void WriteUtf8Bytes(){} // RVA: 0x6079950
        public void CalculateSize(){} // RVA: 0x6079B10 | overloaded x2
        public void CalculateSizeWithLength(){} // RVA: 0x6079B00
        public void .cctor(){} // RVA: 0x607A200
    }

    public class BsonBoolean
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x607E130
        public void .cctor(){} // RVA: 0x607E1D0
    }

    public class BsonEmpty
    {
        public Newtonsoft.Json.Bson.BsonToken Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3CB9E0
        public void get_Type(){} // RVA: 0x3CB9D0
        public void .cctor(){} // RVA: 0x607DFA0
    }

    public class BsonObject
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Bson.BsonProperty> _children; // 0x20

        // ── Methods ──
        public void Add(){} // RVA: 0x607D880
        public void get_Type(){} // RVA: 0x607DB00
        public void GetEnumerator(){} // RVA: 0x607DB10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x607DC00
        public void .ctor(){} // RVA: 0x607DC10
    }

    public class BsonObjectId
    {
        public byte[] <Value>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x607A2E0
    }

    public class BsonProperty
    {
        public Newtonsoft.Json.Bson.BsonString <Name>k__BackingField; // 0x10
        public Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BsonReader
    {
        public int MaxCharBytesSize;
        public byte[] SeqRange1;
        public byte[] SeqRange2; // 0x8

        // ── Methods ──
        public void get_JsonNet35BinaryCompatibility(){} // RVA: 0x1CA9AF0
        public void set_JsonNet35BinaryCompatibility(){} // RVA: 0x607A420
        public void get_ReadRootValueAsArray(){} // RVA: 0x5A6180
        public void set_ReadRootValueAsArray(){} // RVA: 0x59E530
        public void get_DateTimeKindHandling(){} // RVA: 0x3C49C20
        public void set_DateTimeKindHandling(){} // RVA: 0x3C49C30
        public void .ctor(){} // RVA: 0x607A6A0 | overloaded x4
        public void ReadElement(){} // RVA: 0x607A890
        public void Read(){} // RVA: 0x607A8E0
        public void Close(){} // RVA: 0x607AAB0
        public void ReadCodeWScope(){} // RVA: 0x607AB40
        public void ReadReference(){} // RVA: 0x607B090
        public void ReadNormal(){} // RVA: 0x607B6E0
        public void PopContext(){} // RVA: 0x607BA50
        public void PushContext(){} // RVA: 0x607BBF0
        public void ReadByte(){} // RVA: 0x607BCF0
        public void ReadType(){} // RVA: 0x607D510 | overloaded x2
        public void ReadBinary(){} // RVA: 0x607C870
        public void ReadString(){} // RVA: 0x607C970
        public void ReadLengthString(){} // RVA: 0x607CCB0
        public void GetString(){} // RVA: 0x607CD40
        public void GetLastFullCharStop(){} // RVA: 0x607D070
        public void BytesInSequence(){} // RVA: 0x607D0F0
        public void EnsureBuffers(){} // RVA: 0x607D2E0
        public void ReadDouble(){} // RVA: 0x607D450
        public void ReadInt32(){} // RVA: 0x607D490
        public void ReadInt64(){} // RVA: 0x607D4D0
        public void MovePosition(){} // RVA: 0x607D550
        public void ReadBytes(){} // RVA: 0x607D570
        public void .cctor(){} // RVA: 0x607D5B0
    }

    public class BsonRegex
    {
        public Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField; // 0x20
        public Newtonsoft.Json.Bson.BsonString <Options>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Pattern(){} // RVA: 0x30B0C0
        public void set_Pattern(){} // RVA: 0x30B0D0
        public void get_Options(){} // RVA: 0x30B130
        public void set_Options(){} // RVA: 0x2DEE90
        public void .ctor(){} // RVA: 0x607E410
        public void get_Type(){} // RVA: 0x5F88F0
    }

    public class BsonString
    {
        public int <ByteCount>k__BackingField; // 0x30
        public bool <IncludeLength>k__BackingField; // 0x34

        // ── Methods ──
        public void get_ByteCount(){} // RVA: 0x338CD0
        public void set_ByteCount(){} // RVA: 0x338CE0
        public void get_IncludeLength(){} // RVA: 0x313C20
        public void .ctor(){} // RVA: 0x607E330
    }

    public class BsonToken
    {
        public Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField; // 0x10
        public int <CalculatedSize>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0xDBE0
        public void get_Parent(){} // RVA: 0x2F8380
        public void set_Parent(){} // RVA: 0x2DEE30
        public void get_CalculatedSize(){} // RVA: 0x5BED50
        public void set_CalculatedSize(){} // RVA: 0x6374E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BsonValue
    {
        public object _value; // 0x20
        public 0x658E9380 _type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x607E0D0
        public void get_Value(){} // RVA: 0x30B0C0
        public void get_Type(){} // RVA: 0x6E8A80
    }

    public class BsonWriter
    {
        public Newtonsoft.Json.Bson.BsonBinaryWriter _writer; // 0x60

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x607E5E0
        public void set_DateTimeKindHandling(){} // RVA: 0x607E600
        public void .ctor(){} // RVA: 0x607E800 | overloaded x2
        public void Flush(){} // RVA: 0x607E9A0
        public void WriteEnd(){} // RVA: 0x607E9E0
        public void WriteComment(){} // RVA: 0x607EAD0
        public void WriteStartConstructor(){} // RVA: 0x607EB20
        public void WriteRaw(){} // RVA: 0x607EB70
        public void WriteRawValue(){} // RVA: 0x607EBC0
        public void WriteStartArray(){} // RVA: 0x607EC10
        public void WriteStartObject(){} // RVA: 0x607ED30
        public void WritePropertyName(){} // RVA: 0x607EE50
        public void Close(){} // RVA: 0x607EF30
        public void AddParent(){} // RVA: 0x607EF80
        public void RemoveParent(){} // RVA: 0x607EFF0
        public void AddValue(){} // RVA: 0x607F060
        public void AddToken(){} // RVA: 0x607F120
        public void WriteValue(){} // RVA: 0x6080630 | overloaded x21
        public void WriteNull(){} // RVA: 0x607F750
        public void WriteUndefined(){} // RVA: 0x607F7D0
        public void WriteObjectId(){} // RVA: 0x60807A0
        public void WriteRegex(){} // RVA: 0x60808C0
    }

}