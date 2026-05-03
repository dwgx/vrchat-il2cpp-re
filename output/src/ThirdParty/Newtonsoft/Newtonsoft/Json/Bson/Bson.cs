// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
// Classes: 14
// Methods: 134

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
{
    public class BsonArray : BsonToken
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Bson.BsonToken> _children; // 0x20

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE86BBEAA0
        public void get_Type(){} // RVA: 0x7FFE86BBEBA0
        public void GetEnumerator(){} // RVA: 0x7FFE86BBEBB0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86BBECA0
        public void .ctor(){} // RVA: 0x7FFE86BBECB0
    }

    public class BsonBinary : BsonValue
    {
        public 0x665C650C _binaryType; // 0x30

        // ── Methods ──
        public void get_BinaryType(){} // RVA: 0x7FFE81121450
        public void set_BinaryType(){} // RVA: 0x7FFE81121460
        public void .ctor(){} // RVA: 0x7FFE86BBF170
    }

    public class BsonBinaryWriter : Object
    {
        public System.Text.Encoding Encoding;

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFE8151D690
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFE8170B670
        public void .ctor(){} // RVA: 0x7FFE86BB9500
        public void Flush(){} // RVA: 0x7FFE86853DC0
        public void Close(){} // RVA: 0x7FFE81588760
        public void WriteToken(){} // RVA: 0x7FFE86BB9560
        public void WriteTokenInternal(){} // RVA: 0x7FFE86BB9590
        public void WriteString(){} // RVA: 0x7FFE86BBA4F0
        public void WriteUtf8Bytes(){} // RVA: 0x7FFE86BBA720
        public void CalculateSize(){} // RVA: 0x7FFE86BBA8E0 | overloaded x2
        public void CalculateSizeWithLength(){} // RVA: 0x7FFE86BBA8D0
        public void .cctor(){} // RVA: 0x7FFE86BBAFD0
    }

    public class BsonBoolean : BsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BBEF00
        public void .cctor(){} // RVA: 0x7FFE86BBEFA0
    }

    public class BsonEmpty : BsonToken
    {
        public Newtonsoft.Json.Bson.BsonToken Null;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811E99E0
        public void get_Type(){} // RVA: 0x7FFE811E99D0
        public void .cctor(){} // RVA: 0x7FFE86BBED70
    }

    public class BsonObject : BsonToken
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Bson.BsonProperty> _children; // 0x20

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE86BBE650
        public void get_Type(){} // RVA: 0x7FFE86BBE8D0
        public void GetEnumerator(){} // RVA: 0x7FFE86BBE8E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86BBE9D0
        public void .ctor(){} // RVA: 0x7FFE86BBE9E0
    }

    public class BsonObjectId : Object
    {
        public byte[] _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE86BBB0B0
    }

    public class BsonProperty : Object
    {
        public Newtonsoft.Json.Bson.BsonString _name; // 0x10
        public Newtonsoft.Json.Bson.BsonToken _value; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BsonReader : JsonReader
    {
        public int MaxCharBytesSize;
        public byte[] SeqRange1;
        public byte[] SeqRange2; // 0x8

        // ── Methods ──
        public void get_JsonNet35BinaryCompatibility(){} // RVA: 0x7FFE81F57AF0
        public void set_JsonNet35BinaryCompatibility(){} // RVA: 0x7FFE86BBB1F0
        public void get_ReadRootValueAsArray(){} // RVA: 0x7FFE813A1D80
        public void set_ReadRootValueAsArray(){} // RVA: 0x7FFE813AB660
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFE848BEEF0
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFE848BEF00
        public void .ctor(){} // RVA: 0x7FFE86BBB470 | overloaded x4
        public void ReadElement(){} // RVA: 0x7FFE86BBB660
        public void Read(){} // RVA: 0x7FFE86BBB6B0
        public void Close(){} // RVA: 0x7FFE86BBB880
        public void ReadCodeWScope(){} // RVA: 0x7FFE86BBB910
        public void ReadReference(){} // RVA: 0x7FFE86BBBE60
        public void ReadNormal(){} // RVA: 0x7FFE86BBC4B0
        public void PopContext(){} // RVA: 0x7FFE86BBC820
        public void PushContext(){} // RVA: 0x7FFE86BBC9C0
        public void ReadByte(){} // RVA: 0x7FFE86BBCAC0
        public void ReadType(){} // RVA: 0x7FFE86BBE2E0 | overloaded x2
        public void ReadBinary(){} // RVA: 0x7FFE86BBD640
        public void ReadString(){} // RVA: 0x7FFE86BBD740
        public void ReadLengthString(){} // RVA: 0x7FFE86BBDA80
        public void GetString(){} // RVA: 0x7FFE86BBDB10
        public void GetLastFullCharStop(){} // RVA: 0x7FFE86BBDE40
        public void BytesInSequence(){} // RVA: 0x7FFE86BBDEC0
        public void EnsureBuffers(){} // RVA: 0x7FFE86BBE0B0
        public void ReadDouble(){} // RVA: 0x7FFE86BBE220
        public void ReadInt32(){} // RVA: 0x7FFE86BBE260
        public void ReadInt64(){} // RVA: 0x7FFE86BBE2A0
        public void MovePosition(){} // RVA: 0x7FFE86BBE320
        public void ReadBytes(){} // RVA: 0x7FFE86BBE340
        public void .cctor(){} // RVA: 0x7FFE86BBE380
    }

    public class BsonRegex : BsonToken
    {
        public Newtonsoft.Json.Bson.BsonString _pattern; // 0x20
        public Newtonsoft.Json.Bson.BsonString _options; // 0x28
        public object field_2; // 0x2BC

        // ── Methods ──
        public void get_Pattern(){} // RVA: 0x7FFE811290C0
        public void set_Pattern(){} // RVA: 0x7FFE811290D0
        public void get_Options(){} // RVA: 0x7FFE81129130
        public void set_Options(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE86BBF1E0
        public void get_Type(){} // RVA: 0x7FFE813FE1F0
    }

    public class BsonString : BsonValue
    {
        public int _byteCount; // 0x30
        public bool _includeLength; // 0x34

        // ── Methods ──
        public void get_ByteCount(){} // RVA: 0x7FFE81156CD0
        public void set_ByteCount(){} // RVA: 0x7FFE81156CE0
        public void get_IncludeLength(){} // RVA: 0x7FFE81131C20
        public void .ctor(){} // RVA: 0x7FFE86BBF100
    }

    public class BsonToken : Object
    {
        public Newtonsoft.Json.Bson.BsonToken _parent; // 0x10
        public int _calculatedSize; // 0x18
        public object field_2; // 0x2B1

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE80E2F150
        public void get_Parent(){} // RVA: 0x7FFE81116380
        public void set_Parent(){} // RVA: 0x7FFE810FCE30
        public void get_CalculatedSize(){} // RVA: 0x7FFE813DB630
        public void set_CalculatedSize(){} // RVA: 0x7FFE8144DF00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BsonValue : BsonToken
    {
        public object _value; // 0x20
        public 0x665C6A8C _type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BBEEA0
        public void get_Value(){} // RVA: 0x7FFE811290C0
        public void get_Type(){} // RVA: 0x7FFE815F1380
    }

    public class BsonWriter : JsonWriter
    {
        public Newtonsoft.Json.Bson.BsonBinaryWriter _writer; // 0x60

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFE86BBF3B0
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFE86BBF3D0
        public void .ctor(){} // RVA: 0x7FFE86BBF5D0 | overloaded x2
        public void Flush(){} // RVA: 0x7FFE86BBF770
        public void WriteEnd(){} // RVA: 0x7FFE86BBF7B0
        public void WriteComment(){} // RVA: 0x7FFE86BBF8A0
        public void WriteStartConstructor(){} // RVA: 0x7FFE86BBF8F0
        public void WriteRaw(){} // RVA: 0x7FFE86BBF940
        public void WriteRawValue(){} // RVA: 0x7FFE86BBF990
        public void WriteStartArray(){} // RVA: 0x7FFE86BBF9E0
        public void WriteStartObject(){} // RVA: 0x7FFE86BBFB00
        public void WritePropertyName(){} // RVA: 0x7FFE86BBFC20
        public void Close(){} // RVA: 0x7FFE86BBFD00
        public void AddParent(){} // RVA: 0x7FFE86BBFD50
        public void RemoveParent(){} // RVA: 0x7FFE86BBFDC0
        public void AddValue(){} // RVA: 0x7FFE86BBFE30
        public void AddToken(){} // RVA: 0x7FFE86BBFEF0
        public void WriteValue(){} // RVA: 0x7FFE86BC1400 | overloaded x21
        public void WriteNull(){} // RVA: 0x7FFE86BC0520
        public void WriteUndefined(){} // RVA: 0x7FFE86BC05A0
        public void WriteObjectId(){} // RVA: 0x7FFE86BC1570
        public void WriteRegex(){} // RVA: 0x7FFE86BC1690
    }

}