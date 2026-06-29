// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
// Classes: 14
// Methods: 108

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
{
    public class BsonArray : BsonToken
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7ADE69CC0
        public void get_Type(){} // RVA: 0x7ADE69DC0
        public void GetEnumerator(){} // RVA: 0x7ADE69DD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADE69EC0
        public void .ctor(){} // RVA: 0x7ADE69ED0
    }

    public class BsonBinary : BsonValue
    {
        // ── Methods ──
        public void get_BinaryType(){} // RVA: 0x7A80FD690
        public void set_BinaryType(){} // RVA: 0x7A80FD6A0
        public void .ctor(){} // RVA: 0x7ADE6A390
    }

    public class BsonBinaryWriter : Object
    {
        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x7A851DB90
        public void set_DateTimeKindHandling(){} // RVA: 0x7A8738180
        public void .ctor(){} // RVA: 0x7ADE64EB0
        public void Flush(){} // RVA: 0x7ADB00ED0
        public void Close(){} // RVA: 0x7A858ABB0
        public void WriteToken(){} // RVA: 0x7ADE64F10
        public void WriteTokenInternal(){} // RVA: 0x7ADE64F40
        public void WriteString(){} // RVA: 0x7ADE65EA0
        public void WriteUtf8Bytes(){} // RVA: 0x7ADE660D0
        public void CalculateSize(){} // RVA: 0x7ADE66290
        public void CalculateSizeWithLength(){} // RVA: 0x7ADE66280
        public void .cctor(){} // RVA: 0x7ADE66990
    }

    public class BsonBoolean : BsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE6A120
        public void .cctor(){} // RVA: 0x7ADE6A1C0
    }

    public class BsonEmpty : BsonToken
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81C68E0
        public void get_Type(){} // RVA: 0x7A81C68D0
        public void .cctor(){} // RVA: 0x7ADE69F90
    }

    public class BsonObject : BsonToken
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7ADE69860
        public void get_Type(){} // RVA: 0x7ADE69AF0
        public void GetEnumerator(){} // RVA: 0x7ADE69B00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADE69BF0
        public void .ctor(){} // RVA: 0x7ADE69C00
    }

    public class BsonObjectId : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7ADE66A70
    }

    public class BsonProperty : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BsonReader : JsonReader
    {
        // ── Methods ──
        public void get_JsonNet35BinaryCompatibility(){} // RVA: 0x7A9AAC140
        public void set_JsonNet35BinaryCompatibility(){} // RVA: 0x7ADE66BB0
        public void get_ReadRootValueAsArray(){} // RVA: 0x7A835F4E0
        public void set_ReadRootValueAsArray(){} // RVA: 0x7A8357960
        public void get_DateTimeKindHandling(){} // RVA: 0x7ABA39100
        public void set_DateTimeKindHandling(){} // RVA: 0x7ABA39110
        public void .ctor(){} // RVA: 0x7ADE67000
        public void ReadElement(){} // RVA: 0x7ADE671F0
        public void Read(){} // RVA: 0x7ADE67240
        public void Close(){} // RVA: 0x7ADE673A0
        public void ReadCodeWScope(){} // RVA: 0x7ADE67430
        public void ReadReference(){} // RVA: 0x7ADE676A0
        public void ReadNormal(){} // RVA: 0x7ADE679C0
        public void PopContext(){} // RVA: 0x7ADE67DC0
        public void PushContext(){} // RVA: 0x7ADE67F60
        public void ReadByte(){} // RVA: 0x7ADE68060
        public void ReadType(){} // RVA: 0x7ADE694F0
        public void ReadBinary(){} // RVA: 0x7ADE68880
        public void ReadString(){} // RVA: 0x7ADE68980
        public void ReadLengthString(){} // RVA: 0x7ADE68C70
        public void GetString(){} // RVA: 0x7ADE68D00
        public void GetLastFullCharStop(){} // RVA: 0x7ADE69030
        public void BytesInSequence(){} // RVA: 0x7ADE690D0
        public void EnsureBuffers(){} // RVA: 0x7ADE692C0
        public void ReadDouble(){} // RVA: 0x7ADE69430
        public void ReadInt32(){} // RVA: 0x7ADE69470
        public void ReadInt64(){} // RVA: 0x7ADE694B0
        public void MovePosition(){} // RVA: 0x7ADE69530
        public void ReadBytes(){} // RVA: 0x7ADE69550
        public void .cctor(){} // RVA: 0x7ADE69590
    }

    public class BsonRegex : BsonToken
    {
        // ── Methods ──
        public void get_Pattern(){} // RVA: 0x7A81052C0
        public void set_Pattern(){} // RVA: 0x7A81052D0
        public void get_Options(){} // RVA: 0x7A8105330
        public void set_Options(){} // RVA: 0x7A80D8E80
        public void .ctor(){} // RVA: 0x7ADE6A400
        public void get_Type(){} // RVA: 0x7A83B2180
    }

    public class BsonString : BsonValue
    {
        // ── Methods ──
        public void get_ByteCount(){} // RVA: 0x7A8133100
        public void set_ByteCount(){} // RVA: 0x7A8133110
        public void get_IncludeLength(){} // RVA: 0x7A810DDD0
        public void .ctor(){} // RVA: 0x7ADE6A320
    }

    public class BsonToken : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A7E01900
        public void get_Parent(){} // RVA: 0x7A80F2570
        public void set_Parent(){} // RVA: 0x7A80D8E20
        public void get_CalculatedSize(){} // RVA: 0x7A83782A0
        public void set_CalculatedSize(){} // RVA: 0x7A84385B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BsonValue : BsonToken
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADE6A0C0
        public void get_Value(){} // RVA: 0x7A81052C0
        public void get_Type(){} // RVA: 0x7A84A5BD0
    }

    public class BsonWriter : JsonWriter
    {
        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x7ADE6A5D0
        public void set_DateTimeKindHandling(){} // RVA: 0x7ADE6A5F0
        public void .ctor(){} // RVA: 0x7ADE6A7F0
        public void Flush(){} // RVA: 0x7ADE6A990
        public void WriteEnd(){} // RVA: 0x7ADE6A9D0
        public void WriteComment(){} // RVA: 0x7ADE6AAC0
        public void WriteStartConstructor(){} // RVA: 0x7ADE6AB10
        public void WriteRaw(){} // RVA: 0x7ADE6AB60
        public void WriteRawValue(){} // RVA: 0x7ADE6ABB0
        public void WriteStartArray(){} // RVA: 0x7ADE6AC00
        public void WriteStartObject(){} // RVA: 0x7ADE6AD20
        public void WritePropertyName(){} // RVA: 0x7ADE6AE40
        public void Close(){} // RVA: 0x7ADE6AF20
        public void AddParent(){} // RVA: 0x7ADE6AF70
        public void RemoveParent(){} // RVA: 0x7ADE6AFE0
        public void AddValue(){} // RVA: 0x7ADE6B050
        public void AddToken(){} // RVA: 0x7ADE6B110
        public void WriteValue(){} // RVA: 0x7ADE6C5C0
        public void WriteNull(){} // RVA: 0x7ADE6B6F0
        public void WriteUndefined(){} // RVA: 0x7ADE6B770
        public void WriteObjectId(){} // RVA: 0x7ADE6C730
        public void WriteRegex(){} // RVA: 0x7ADE6C820
    }

}