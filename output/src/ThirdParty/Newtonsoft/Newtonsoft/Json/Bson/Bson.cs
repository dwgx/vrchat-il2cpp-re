// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
// Classes: 14
// Methods: 134

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
{
    public class BsonArray
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAF8B2DCD0
        public void get_Type(){} // RVA: 0x7FFAF8B2DDD0
        public void GetEnumerator(){} // RVA: 0x7FFAF8B2DDE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8B2DED0
        public void .ctor(){} // RVA: 0x7FFAF8B2DEE0
    }

    public class BsonBinary
    {
        // ── Methods ──
        public void get_BinaryType(){} // RVA: 0x7FFAF2DB3450
        public void set_BinaryType(){} // RVA: 0x7FFAF2DB3460
        public void .ctor(){} // RVA: 0x7FFAF8B2E3A0
    }

    public class BsonBinaryWriter
    {
        public object Value;

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFAF3210030
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFAF344E0D0
        public void .ctor(){} // RVA: 0x7FFAF8B28730
        public void Flush(){} // RVA: 0x7FFAF87C2EC0
        public void Close(){} // RVA: 0x7FFAF32A02E0
        public void WriteToken(){} // RVA: 0x7FFAF8B28790
        public void WriteTokenInternal(){} // RVA: 0x7FFAF8B287C0
        public void WriteString(){} // RVA: 0x7FFAF8B29720
        public void WriteUtf8Bytes(){} // RVA: 0x7FFAF8B29950
        public void CalculateSize(){} // RVA: 0x7FFAF8B29B10 | overloaded x2
        public void CalculateSizeWithLength(){} // RVA: 0x7FFAF8B29B00
        public void .cctor(){} // RVA: 0x7FFAF8B2A200
    }

    public class BsonBoolean
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B2E130
        public void .cctor(){} // RVA: 0x7FFAF8B2E1D0
    }

    public class BsonEmpty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E7B9E0
        public void get_Type(){} // RVA: 0x7FFAF2E7B9D0
        public void .cctor(){} // RVA: 0x7FFAF8B2DFA0
    }

    public class BsonObject
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAF8B2D880
        public void get_Type(){} // RVA: 0x7FFAF8B2DB00
        public void GetEnumerator(){} // RVA: 0x7FFAF8B2DB10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8B2DC00
        public void .ctor(){} // RVA: 0x7FFAF8B2DC10
    }

    public class BsonObjectId
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF8B2A2E0
    }

    public class BsonProperty
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BsonReader
    {
        // ── Methods ──
        public void get_JsonNet35BinaryCompatibility(){} // RVA: 0x7FFAF4759AF0
        public void set_JsonNet35BinaryCompatibility(){} // RVA: 0x7FFAF8B2A420
        public void get_ReadRootValueAsArray(){} // RVA: 0x7FFAF3056180
        public void set_ReadRootValueAsArray(){} // RVA: 0x7FFAF304E530
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFAF66F9C20
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFAF66F9C30
        public void .ctor(){} // RVA: 0x7FFAF8B2A6A0 | overloaded x4
        public void ReadElement(){} // RVA: 0x7FFAF8B2A890
        public void Read(){} // RVA: 0x7FFAF8B2A8E0
        public void Close(){} // RVA: 0x7FFAF8B2AAB0
        public void ReadCodeWScope(){} // RVA: 0x7FFAF8B2AB40
        public void ReadReference(){} // RVA: 0x7FFAF8B2B090
        public void ReadNormal(){} // RVA: 0x7FFAF8B2B6E0
        public void PopContext(){} // RVA: 0x7FFAF8B2BA50
        public void PushContext(){} // RVA: 0x7FFAF8B2BBF0
        public void ReadByte(){} // RVA: 0x7FFAF8B2BCF0
        public void ReadType(){} // RVA: 0x7FFAF8B2D510 | overloaded x2
        public void ReadBinary(){} // RVA: 0x7FFAF8B2C870
        public void ReadString(){} // RVA: 0x7FFAF8B2C970
        public void ReadLengthString(){} // RVA: 0x7FFAF8B2CCB0
        public void GetString(){} // RVA: 0x7FFAF8B2CD40
        public void GetLastFullCharStop(){} // RVA: 0x7FFAF8B2D070
        public void BytesInSequence(){} // RVA: 0x7FFAF8B2D0F0
        public void EnsureBuffers(){} // RVA: 0x7FFAF8B2D2E0
        public void ReadDouble(){} // RVA: 0x7FFAF8B2D450
        public void ReadInt32(){} // RVA: 0x7FFAF8B2D490
        public void ReadInt64(){} // RVA: 0x7FFAF8B2D4D0
        public void MovePosition(){} // RVA: 0x7FFAF8B2D550
        public void ReadBytes(){} // RVA: 0x7FFAF8B2D570
        public void .cctor(){} // RVA: 0x7FFAF8B2D5B0
    }

    public class BsonRegex
    {
        // ── Methods ──
        public void get_Pattern(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Pattern(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Options(){} // RVA: 0x7FFAF2DBB130
        public void set_Options(){} // RVA: 0x7FFAF2D8EE90
        public void .ctor(){} // RVA: 0x7FFAF8B2E410
        public void get_Type(){} // RVA: 0x7FFAF30A88F0
    }

    public class BsonString
    {
        // ── Methods ──
        public void get_ByteCount(){} // RVA: 0x7FFAF2DE8CD0
        public void set_ByteCount(){} // RVA: 0x7FFAF2DE8CE0
        public void get_IncludeLength(){} // RVA: 0x7FFAF2DC3C20
        public void .ctor(){} // RVA: 0x7FFAF8B2E330
    }

    public class BsonToken
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Parent(){} // RVA: 0x7FFAF2DA8380
        public void set_Parent(){} // RVA: 0x7FFAF2D8EE30
        public void get_CalculatedSize(){} // RVA: 0x7FFAF306ED50
        public void set_CalculatedSize(){} // RVA: 0x7FFAF30E74E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B2E0D0
        public void get_Value(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Type(){} // RVA: 0x7FFAF3198A80
    }

    public class BsonWriter
    {
        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFAF8B2E5E0
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFAF8B2E600
        public void .ctor(){} // RVA: 0x7FFAF8B2E800 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAF8B2E9A0
        public void WriteEnd(){} // RVA: 0x7FFAF8B2E9E0
        public void WriteComment(){} // RVA: 0x7FFAF8B2EAD0
        public void WriteStartConstructor(){} // RVA: 0x7FFAF8B2EB20
        public void WriteRaw(){} // RVA: 0x7FFAF8B2EB70
        public void WriteRawValue(){} // RVA: 0x7FFAF8B2EBC0
        public void WriteStartArray(){} // RVA: 0x7FFAF8B2EC10
        public void WriteStartObject(){} // RVA: 0x7FFAF8B2ED30
        public void WritePropertyName(){} // RVA: 0x7FFAF8B2EE50
        public void Close(){} // RVA: 0x7FFAF8B2EF30
        public void AddParent(){} // RVA: 0x7FFAF8B2EF80
        public void RemoveParent(){} // RVA: 0x7FFAF8B2EFF0
        public void AddValue(){} // RVA: 0x7FFAF8B2F060
        public void AddToken(){} // RVA: 0x7FFAF8B2F120
        public void WriteValue(){} // RVA: 0x7FFAF8B30630 | overloaded x21
        public void WriteNull(){} // RVA: 0x7FFAF8B2F750
        public void WriteUndefined(){} // RVA: 0x7FFAF8B2F7D0
        public void WriteObjectId(){} // RVA: 0x7FFAF8B307A0
        public void WriteRegex(){} // RVA: 0x7FFAF8B308C0
    }

}