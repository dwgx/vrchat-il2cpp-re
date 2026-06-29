// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
// Classes: 9
// Methods: 25

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
{
    public class BsonArray : BsonToken
    {
        public object _children;

        // ── Methods ──
        public void Add(){} // RVA: 0x81BD330
        public void get_Type(){} // RVA: 0x6AF1440
    }

    public class BsonObject : BsonToken
    {
        public object _children;

        // ── Methods ──
        public void Add(){} // RVA: 0x81BD0A0
        public void get_Type(){} // RVA: 0x6AF1170
    }

    public class BsonObjectId : Object
    {
        public object _value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x81BCF60
    }

    public class BsonProperty : Object
    {
        public object _name;
        public object _value;

        // ── Methods ──
        public void set_Name(){} // RVA: 0xB44D60
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BsonRegex : BsonToken
    {
        public object _pattern;
        public object _options;

        // ── Methods ──
        public void set_Pattern(){} // RVA: 0xBA9BA0
        public void set_Options(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x81BD500
        public void get_Type(){} // RVA: 0xE85960
    }

    public class BsonString : BsonValue
    {
        public object _includeLength;

        // ── Methods ──
        public void set_IncludeLength(){} // RVA: 0xF73A60
        public void .ctor(){} // RVA: 0x81BD490
    }

    public class BsonToken : Object
    {
        public object _parent;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x87D280
        public void set_Parent(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BsonValue : BsonToken
    {
        public object _value;
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81BD430
        public void get_Type(){} // RVA: 0xC38360
    }

    public class BsonWriter : JsonWriter
    {
        public object _root;
        public object _parent;
        public object _propertyName;

        // ── Methods ──
        public void AddValue(){} // RVA: 0x81BD6D0
        public void AddToken(){} // RVA: 0x81BD790
        public void WriteObjectId(){} // RVA: 0x81BDBB0
        public void WriteRegex(){} // RVA: 0x81BDD30
    }

}