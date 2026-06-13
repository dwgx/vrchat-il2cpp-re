// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
// Classes: 9
// Methods: 25

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
{
    public class BsonArray
    {
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Bson.BsonToken> _children; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x7585B60
        public void get_Type(){} // RVA: 0x607DDD0
    }

    public class BsonObject
    {
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Bson.BsonProperty> _children; // 0x18

        // ── Methods ──
        public void Add(){} // RVA: 0x75858E0
        public void get_Type(){} // RVA: 0x607DB00
    }

    public class BsonObjectId
    {
        public byte[] Type; // 0x10

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x75857A0
    }

    public class BsonProperty
    {
        public Valve.Newtonsoft.Json.Bson.BsonString <Name>k__BackingField; // 0x10
        public Valve.Newtonsoft.Json.Bson.BsonToken <Value>k__BackingField; // 0x18

        // ── Methods ──
        public void set_Name(){} // RVA: 0x2DEE30
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BsonRegex
    {
        public Valve.Newtonsoft.Json.Bson.BsonString <Pattern>k__BackingField; // 0x18
        public Valve.Newtonsoft.Json.Bson.BsonString <Options>k__BackingField; // 0x20

        // ── Methods ──
        public void set_Pattern(){} // RVA: 0x343E80
        public void set_Options(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x7585D30
        public void get_Type(){} // RVA: 0x5F88F0
    }

    public class BsonString
    {
        public bool <IncludeLength>k__BackingField; // 0x28

        // ── Methods ──
        public void set_IncludeLength(){} // RVA: 0x6E8B80
        public void .ctor(){} // RVA: 0x7585CC0
    }

    public class BsonToken
    {
        public Valve.Newtonsoft.Json.Bson.BsonToken <Parent>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Type(){} // RVA: 0xDBE0
        public void set_Parent(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BsonValue
    {
        public object _value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7585C60
        public void get_Type(){} // RVA: 0x3CB9D0
    }

    public class BsonWriter
    {
        // ── Methods ──
        public void AddValue(){} // RVA: 0x7585F00
        public void AddToken(){} // RVA: 0x7585FC0
        public void WriteObjectId(){} // RVA: 0x75863F0
        public void WriteRegex(){} // RVA: 0x7586570
    }

}