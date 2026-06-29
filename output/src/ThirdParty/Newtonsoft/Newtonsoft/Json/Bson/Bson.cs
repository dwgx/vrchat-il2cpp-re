// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
// Classes: 14
// Methods: 108

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Bson
{
    public class BsonArray : BsonToken
    {
        public object _children;

        // ── Methods ──
        public void Add(){} // RVA: 0x6AF1340
        public void get_Type(){} // RVA: 0x6AF1440
        public void GetEnumerator(){} // RVA: 0x6AF1450
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6AF1540
        public void .ctor(){} // RVA: 0x6AF1550
    }

    public class BsonBinary : BsonValue
    {
        public object _binaryType;

        // ── Methods ──
        public void get_BinaryType(){} // RVA: 0xB68DF0
        public void set_BinaryType(){} // RVA: 0xB68E00
        public void .ctor(){} // RVA: 0x6AF19F0
    }

    public class BsonBinaryWriter : Object
    {
        public object Encoding;
        public object _writer;
        public object _largeByteBuffer;
        public object _dateTimeKindHandling;

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0xFEAE90
        public void set_DateTimeKindHandling(){} // RVA: 0x1269760
        public void .ctor(){} // RVA: 0x6AEC570
        public void Flush(){} // RVA: 0x678C220
        public void Close(){} // RVA: 0x10AD460
        public void WriteToken(){} // RVA: 0x6AEC5D0
        public void WriteTokenInternal(){} // RVA: 0x6AEC600
        public void WriteString(){} // RVA: 0x6AED550
        public void WriteUtf8Bytes(){} // RVA: 0x6AED780
        public void CalculateSize(){} // RVA: 0x6AED940
        public void CalculateSizeWithLength(){} // RVA: 0x6AED930
        public void .cctor(){} // RVA: 0x6AEE030
    }

    public class BsonBoolean : BsonValue
    {
        public object False;
        public object True;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AF17A0
        public void .cctor(){} // RVA: 0x6AF1820
    }

    public class BsonEmpty : BsonToken
    {
        public object Null;
        public object Undefined;
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC38370
        public void get_Type(){} // RVA: 0xC38360
        public void .cctor(){} // RVA: 0x6AF1610
    }

    public class BsonObject : BsonToken
    {
        public object _children;

        // ── Methods ──
        public void Add(){} // RVA: 0x6AF0EE0
        public void get_Type(){} // RVA: 0x6AF1170
        public void GetEnumerator(){} // RVA: 0x6AF1180
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6AF1270
        public void .ctor(){} // RVA: 0x6AF1280
    }

    public class BsonObjectId : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x6AEE110
    }

    public class BsonProperty : Object
    {
        public object _name;
        public object _value;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BsonReader : JsonReader
    {
        public object MaxCharBytesSize;
        public object SeqRange1;
        public object SeqRange2;
        public object SeqRange3;
        public object SeqRange4;
        public object _reader;
        public object _stack;
        public object _byteBuffer;
        public object _charBuffer;
        public object _currentElementType;
        public object _bsonReaderState;
        public object _currentContext;
        public object _readRootValueAsArray;
        public object _jsonNet35BinaryCompatibility;
        public object _dateTimeKindHandling;

        // ── Methods ──
        public void get_JsonNet35BinaryCompatibility(){} // RVA: 0x6AEE250
        public void set_JsonNet35BinaryCompatibility(){} // RVA: 0x6AEE260
        public void get_ReadRootValueAsArray(){} // RVA: 0xE3F3E0
        public void set_ReadRootValueAsArray(){} // RVA: 0xE3EB10
        public void get_DateTimeKindHandling(){} // RVA: 0x68504E0
        public void set_DateTimeKindHandling(){} // RVA: 0x6AEE270
        public void .ctor(){} // RVA: 0x6AEE6C0
        public void ReadElement(){} // RVA: 0x6AEE8B0
        public void Read(){} // RVA: 0x6AEE900
        public void Close(){} // RVA: 0x6AEEA60
        public void ReadCodeWScope(){} // RVA: 0x6AEEAF0
        public void ReadReference(){} // RVA: 0x6AEED60
        public void ReadNormal(){} // RVA: 0x6AEF080
        public void PopContext(){} // RVA: 0x6AEF480
        public void PushContext(){} // RVA: 0x6AEF620
        public void ReadByte(){} // RVA: 0x6AEF720
        public void ReadType(){} // RVA: 0x6AF0B70
        public void ReadBinary(){} // RVA: 0x6AEFF10
        public void ReadString(){} // RVA: 0x6AF0010
        public void ReadLengthString(){} // RVA: 0x6AF0300
        public void GetString(){} // RVA: 0x6AF0390
        public void GetLastFullCharStop(){} // RVA: 0x6AF06B0
        public void BytesInSequence(){} // RVA: 0x6AF0750
        public void EnsureBuffers(){} // RVA: 0x6AF0940
        public void ReadDouble(){} // RVA: 0x6AF0AB0
        public void ReadInt32(){} // RVA: 0x6AF0AF0
        public void ReadInt64(){} // RVA: 0x6AF0B30
        public void MovePosition(){} // RVA: 0x6AF0BB0
        public void ReadBytes(){} // RVA: 0x6AF0BD0
        public void .cctor(){} // RVA: 0x6AF0C10
    }

    public class BsonRegex : BsonToken
    {
        public object _pattern;
        public object _options;

        // ── Methods ──
        public void get_Pattern(){} // RVA: 0xB700F0
        public void set_Pattern(){} // RVA: 0xB70100
        public void get_Options(){} // RVA: 0xB70160
        public void set_Options(){} // RVA: 0xB44DC0
        public void .ctor(){} // RVA: 0x6AF1A60
        public void get_Type(){} // RVA: 0xE85960
    }

    public class BsonString : BsonValue
    {
        public object _byteCount;
        public object _includeLength;

        // ── Methods ──
        public void get_ByteCount(){} // RVA: 0xB9E080
        public void set_ByteCount(){} // RVA: 0xB9E090
        public void get_IncludeLength(){} // RVA: 0xB78D60
        public void .ctor(){} // RVA: 0x6AF1980
    }

    public class BsonToken : Object
    {
        public object _parent;
        public object _calculatedSize;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x87D280
        public void get_Parent(){} // RVA: 0xB5DBF0
        public void set_Parent(){} // RVA: 0xB44D60
        public void get_CalculatedSize(){} // RVA: 0xE62D00
        public void set_CalculatedSize(){} // RVA: 0x1033F40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BsonValue : BsonToken
    {
        public object _value;
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AF1740
        public void get_Value(){} // RVA: 0xB700F0
        public void get_Type(){} // RVA: 0xF73960
    }

    public class BsonWriter : JsonWriter
    {
        public object _writer;
        public object _root;
        public object _parent;
        public object _propertyName;

        // ── Methods ──
        public void get_DateTimeKindHandling(){} // RVA: 0x6AF1C30
        public void set_DateTimeKindHandling(){} // RVA: 0x6AF1C50
        public void .ctor(){} // RVA: 0x6AF1E50
        public void Flush(){} // RVA: 0x6AF1FF0
        public void WriteEnd(){} // RVA: 0x6AF2030
        public void WriteComment(){} // RVA: 0x6AF2120
        public void WriteStartConstructor(){} // RVA: 0x6AF2170
        public void WriteRaw(){} // RVA: 0x6AF21C0
        public void WriteRawValue(){} // RVA: 0x6AF2210
        public void WriteStartArray(){} // RVA: 0x6AF2260
        public void WriteStartObject(){} // RVA: 0x6AF2380
        public void WritePropertyName(){} // RVA: 0x6AF24A0
        public void Close(){} // RVA: 0x6AF2580
        public void AddParent(){} // RVA: 0x6AF25D0
        public void RemoveParent(){} // RVA: 0x6AF2640
        public void AddValue(){} // RVA: 0x6AF26B0
        public void AddToken(){} // RVA: 0x6AF2770
        public void WriteValue(){} // RVA: 0x6AF3AA0
        public void WriteNull(){} // RVA: 0x6AF2D50
        public void WriteUndefined(){} // RVA: 0x6AF2DD0
        public void WriteObjectId(){} // RVA: 0x6AF3C10
        public void WriteRegex(){} // RVA: 0x6AF3D00
    }

}