// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
// Classes: 14
// Methods: 134

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
{
    public class BsonArray : BsonToken
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Bson.BsonToken> Type; // 0x20

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC88153B0
        public void get_Type(){} // RVA: 0x7FFAC88154B0
        public void GetEnumerator(){} // RVA: 0x7FFAC88154C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC88155B0
        public void .ctor(){} // RVA: 0x7FFAC88155C0
    }

    public class BsonBinary : BsonValue
    {
        public 0x6B1CCC48 BinaryType; // 0x30

        // ── Methods ──
        public void get_BinaryType(){} // RVA: 0x7FFAC2F47450
        public void set_BinaryType(){} // RVA: 0x7FFAC2F47460
        public void .ctor(){} // RVA: 0x7FFAC8815A80
    }

    public class BsonBinaryWriter : Object
    {
        public System.Text.Encoding DateTimeKindHandling;
        public System.IO.BinaryWriter _writer; // 0x10
        public byte[] _largeByteBuffer; // 0x18
        public 0x6B0BEA50 <DateTimeKindHandling>k__BackingField; // 0x20

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFAC30DBBE0
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFAC35DB7A0
        public void .ctor(){} // RVA: 0x7FFAC880FDE0
        public void Flush(){} // RVA: 0x7FFAC84AA500
        public void Close(){} // RVA: 0x7FFAC880FE40
        public void WriteToken(){} // RVA: 0x7FFAC880FE70
        public void WriteTokenInternal(){} // RVA: 0x7FFAC880FEA0
        public void WriteString(){} // RVA: 0x7FFAC8810E00
        public void WriteUtf8Bytes(){} // RVA: 0x7FFAC8811030
        public void CalculateSize(){} // RVA: 0x7FFAC88111F0 | overloaded x2
        public void CalculateSizeWithLength(){} // RVA: 0x7FFAC88111E0
        public void .cctor(){} // RVA: 0x7FFAC88118E0
    }

    public class BsonBoolean : BsonValue
    {
        public Newtonsoft.Json.Bson.BsonBoolean False;
        public Newtonsoft.Json.Bson.BsonBoolean True; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8815810
        public void .cctor(){} // RVA: 0x7FFAC88158B0
    }

    public class BsonEmpty : BsonToken
    {
        public Newtonsoft.Json.Bson.BsonToken Type;
        public Newtonsoft.Json.Bson.BsonToken Undefined; // 0x8
        public 0x6B1CD1C8 <Type>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC300F9E0
        public void get_Type(){} // RVA: 0x7FFAC300F9D0
        public void .cctor(){} // RVA: 0x7FFAC8815680
    }

    public class BsonObject : BsonToken
    {
        public System.Collections.Generic.List`1<Newtonsoft.Json.Bson.BsonProperty> Type; // 0x20

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC8814F60
        public void get_Type(){} // RVA: 0x7FFAC88151E0
        public void GetEnumerator(){} // RVA: 0x7FFAC88151F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC88152E0
        public void .ctor(){} // RVA: 0x7FFAC88152F0
    }

    public class BsonObjectId : Object
    {
        public byte[] Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC88119C0
    }

    public class BsonProperty : Object
    {
        public Newtonsoft.Json.Bson.BsonString Name; // 0x10
        public Newtonsoft.Json.Bson.BsonToken Value; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BsonReader : JsonReader
    {
        public int JsonNet35BinaryCompatibility;
        public byte[] ReadRootValueAsArray;
        public byte[] DateTimeKindHandling; // 0x8
        public byte[] SeqRange3; // 0x10
        public byte[] SeqRange4; // 0x18
        public System.IO.BinaryReader _reader; // 0x78
        public System.Collections.Generic.List`1<ContainerContext> _stack; // 0x80
        public byte[] _byteBuffer; // 0x88
        public char[] _charBuffer; // 0x90
        public 0x6B1CD1C8 _currentElementType; // 0x98
        public 0x6B1CCD50 _bsonReaderState; // 0x9C
        public ContainerContext _currentContext; // 0xA0
        public bool _readRootValueAsArray; // 0xA8
        public bool _jsonNet35BinaryCompatibility; // 0xA9
        public 0x6B0BEA50 _dateTimeKindHandling; // 0xAC

        // ── Methods ──
        public void get_JsonNet35BinaryCompatibility(){} // RVA: 0x7FFAC3CEFA00
        public void set_JsonNet35BinaryCompatibility(){} // RVA: 0x7FFAC8811B00
        public void get_ReadRootValueAsArray(){} // RVA: 0x7FFAC3141F10
        public void set_ReadRootValueAsArray(){} // RVA: 0x7FFAC313FE60
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFAC6539490
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFAC65394A0
        public void .ctor(){} // RVA: 0x7FFAC8811D80 | overloaded x4
        public void ReadElement(){} // RVA: 0x7FFAC8811F70
        public void Read(){} // RVA: 0x7FFAC8811FC0
        public void Close(){} // RVA: 0x7FFAC8812190
        public void ReadCodeWScope(){} // RVA: 0x7FFAC8812220
        public void ReadReference(){} // RVA: 0x7FFAC8812770
        public void ReadNormal(){} // RVA: 0x7FFAC8812DC0
        public void PopContext(){} // RVA: 0x7FFAC8813130
        public void PushContext(){} // RVA: 0x7FFAC88132D0
        public void ReadByte(){} // RVA: 0x7FFAC88133D0
        public void ReadType(){} // RVA: 0x7FFAC8814BF0 | overloaded x2
        public void ReadBinary(){} // RVA: 0x7FFAC8813F50
        public void ReadString(){} // RVA: 0x7FFAC8814050
        public void ReadLengthString(){} // RVA: 0x7FFAC8814390
        public void GetString(){} // RVA: 0x7FFAC8814420
        public void GetLastFullCharStop(){} // RVA: 0x7FFAC8814750
        public void BytesInSequence(){} // RVA: 0x7FFAC88147D0
        public void EnsureBuffers(){} // RVA: 0x7FFAC88149C0
        public void ReadDouble(){} // RVA: 0x7FFAC8814B30
        public void ReadInt32(){} // RVA: 0x7FFAC8814B70
        public void ReadInt64(){} // RVA: 0x7FFAC8814BB0
        public void MovePosition(){} // RVA: 0x7FFAC8814C30
        public void ReadBytes(){} // RVA: 0x7FFAC8814C50
        public void .cctor(){} // RVA: 0x7FFAC8814C90
    }

    public class BsonRegex : BsonToken
    {
        public Newtonsoft.Json.Bson.BsonString Pattern; // 0x20
        public Newtonsoft.Json.Bson.BsonString Options; // 0x28

        // ── Methods ──
        public void get_Pattern(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Pattern(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Options(){} // RVA: 0x7FFAC2F4F130
        public void set_Options(){} // RVA: 0x7FFAC2F22E90
        public void .ctor(){} // RVA: 0x7FFAC8815AF0
        public void get_Type(){} // RVA: 0x7FFAC3197790
    }

    public class BsonString : BsonValue
    {
        public int ByteCount; // 0x30
        public bool IncludeLength; // 0x34

        // ── Methods ──
        public void get_ByteCount(){} // RVA: 0x7FFAC2F7CCD0
        public void set_ByteCount(){} // RVA: 0x7FFAC2F7CCE0
        public void get_IncludeLength(){} // RVA: 0x7FFAC2F57C20
        public void .ctor(){} // RVA: 0x7FFAC8815A10
    }

    public class BsonToken : Object
    {
        public Newtonsoft.Json.Bson.BsonToken Type; // 0x10
        public int Parent; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2C59D00
        public void get_Parent(){} // RVA: 0x7FFAC2F3C380
        public void set_Parent(){} // RVA: 0x7FFAC2F22E30
        public void get_CalculatedSize(){} // RVA: 0x7FFAC3157800
        public void set_CalculatedSize(){} // RVA: 0x7FFAC392CD10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BsonValue : BsonToken
    {
        public object Value; // 0x20
        public 0x6B1CD1C8 Type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88157B0
        public void get_Value(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Type(){} // RVA: 0x7FFAC30F6BA0
    }

    public class BsonWriter : JsonWriter
    {
        public Newtonsoft.Json.Bson.BsonBinaryWriter DateTimeKindHandling; // 0x60
        public Newtonsoft.Json.Bson.BsonToken _root; // 0x68
        public Newtonsoft.Json.Bson.BsonToken _parent; // 0x70
        public string _propertyName; // 0x78

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x7FFAC8815CC0
        public void set_DateTimeKindHandling(){} // RVA: 0x7FFAC8815CE0
        public void .ctor(){} // RVA: 0x7FFAC8815EE0 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAC8816080
        public void WriteEnd(){} // RVA: 0x7FFAC88160C0
        public void WriteComment(){} // RVA: 0x7FFAC88161B0
        public void WriteStartConstructor(){} // RVA: 0x7FFAC8816200
        public void WriteRaw(){} // RVA: 0x7FFAC8816250
        public void WriteRawValue(){} // RVA: 0x7FFAC88162A0
        public void WriteStartArray(){} // RVA: 0x7FFAC88162F0
        public void WriteStartObject(){} // RVA: 0x7FFAC8816410
        public void WritePropertyName(){} // RVA: 0x7FFAC8816530
        public void Close(){} // RVA: 0x7FFAC8816610
        public void AddParent(){} // RVA: 0x7FFAC8816660
        public void RemoveParent(){} // RVA: 0x7FFAC88166D0
        public void AddValue(){} // RVA: 0x7FFAC8816740
        public void AddToken(){} // RVA: 0x7FFAC8816800
        public void WriteValue(){} // RVA: 0x7FFAC8817D10 | overloaded x21
        public void WriteNull(){} // RVA: 0x7FFAC8816E30
        public void WriteUndefined(){} // RVA: 0x7FFAC8816EB0
        public void WriteObjectId(){} // RVA: 0x7FFAC8817E80
        public void WriteRegex(){} // RVA: 0x7FFAC8817FA0
    }

}