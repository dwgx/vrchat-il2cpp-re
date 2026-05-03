// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
// Classes: 9
// Methods: 25

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
{
    public class BsonArray : BsonToken
    {
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Bson.BsonToken> _children; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE880C5CF0
        public void get_Type(){} // RVA: 0x7FFE86BBEBA0
    }

    public class BsonObject : BsonToken
    {
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Bson.BsonProperty> _children; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE880C5A70
        public void get_Type(){} // RVA: 0x7FFE86BBE8D0
    }

    public class BsonObjectId : Object
    {
        public byte[] _value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE880C5930
    }

    public class BsonProperty : Object
    {
        public Valve.Newtonsoft.Json.Bson.BsonString _name; // 0x10
        public Valve.Newtonsoft.Json.Bson.BsonToken _value; // 0x18

        // ── Methods ──
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BsonRegex : BsonToken
    {
        public Valve.Newtonsoft.Json.Bson.BsonString _pattern; // 0x18
        public Valve.Newtonsoft.Json.Bson.BsonString _options; // 0x20
        public object field_2; // 0x147

        // ── Methods ──
        public void set_Pattern(){} // RVA: 0x7FFE81161E80
        public void set_Options(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE880C5EC0
        public void get_Type(){} // RVA: 0x7FFE813FE1F0
    }

    public class BsonString : BsonValue
    {
        public bool _includeLength; // 0x28

        // ── Methods ──
        public void set_IncludeLength(){} // RVA: 0x7FFE81C15740
        public void .ctor(){} // RVA: 0x7FFE880C5E50
    }

    public class BsonToken : Object
    {
        public Valve.Newtonsoft.Json.Bson.BsonToken _parent; // 0x10
        public object field_1; // 0x141

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE80E2F150
        public void set_Parent(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BsonValue : BsonToken
    {
        public object _value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880C5DF0
        public void get_Type(){} // RVA: 0x7FFE811E99D0
    }

    public class BsonWriter : JsonWriter
    {
        // ── Methods ──
        public void AddValue(){} // RVA: 0x7FFE880C6090
        public void AddToken(){} // RVA: 0x7FFE880C6150
        public void WriteObjectId(){} // RVA: 0x7FFE880C6580
        public void WriteRegex(){} // RVA: 0x7FFE880C6700
    }

}