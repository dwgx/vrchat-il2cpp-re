// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
// Classes: 9
// Methods: 25

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
{
    public class BsonArray : BsonToken
    {
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Bson.BsonToken> Type; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC9D1D4E0
        public void get_Type(){} // RVA: 0x7FFAC88154B0
    }

    public class BsonObject : BsonToken
    {
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Bson.BsonProperty> Type; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC9D1D260
        public void get_Type(){} // RVA: 0x7FFAC88151E0
    }

    public class BsonObjectId : Object
    {
        public byte[] Value; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9D1D120
    }

    public class BsonProperty : Object
    {
        public Valve.Newtonsoft.Json.Bson.BsonString Name; // 0x10
        public Valve.Newtonsoft.Json.Bson.BsonToken Value; // 0x18

        // ── Methods ──
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BsonRegex : BsonToken
    {
        public Valve.Newtonsoft.Json.Bson.BsonString Pattern; // 0x18
        public Valve.Newtonsoft.Json.Bson.BsonString Options; // 0x20

        // ── Methods ──
        public void set_Pattern(){} // RVA: 0x7FFAC2F87E80
        public void set_Options(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC9D1D6B0
        public void get_Type(){} // RVA: 0x7FFAC3197790
    }

    public class BsonString : BsonValue
    {
        public bool IncludeLength; // 0x28

        // ── Methods ──
        public void set_IncludeLength(){} // RVA: 0x7FFAC3C24F40
        public void .ctor(){} // RVA: 0x7FFAC9D1D640
    }

    public class BsonToken : Object
    {
        public Valve.Newtonsoft.Json.Bson.BsonToken Type; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2C59D00
        public void set_Parent(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BsonValue : BsonToken
    {
        public object Type; // 0x18
        public 0x6B2487F0 _type; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D1D5E0
        public void get_Type(){} // RVA: 0x7FFAC300F9D0
    }

    public class BsonWriter : JsonWriter
    {
        public Valve.Newtonsoft.Json.Bson.BsonToken _root; // 0x60
        public Valve.Newtonsoft.Json.Bson.BsonToken _parent; // 0x68
        public string _propertyName; // 0x70

        // ── Methods ──
        public void AddValue(){} // RVA: 0x7FFAC9D1D880
        public void AddToken(){} // RVA: 0x7FFAC9D1D940
        public void WriteObjectId(){} // RVA: 0x7FFAC9D1DD70
        public void WriteRegex(){} // RVA: 0x7FFAC9D1DEF0
    }

}