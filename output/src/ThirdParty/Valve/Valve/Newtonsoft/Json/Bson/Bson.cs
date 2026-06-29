// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
// Classes: 9
// Methods: 25

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Bson
{
    public class BsonArray : BsonToken
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AF364250
        public void get_Type(){} // RVA: 0x7ADE69DC0
    }

    public class BsonObject : BsonToken
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7AF363FC0
        public void get_Type(){} // RVA: 0x7ADE69AF0
    }

    public class BsonObjectId : Object
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A80F2570
        public void set_Value(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AF363E80
    }

    public class BsonProperty : Object
    {
        // ── Methods ──
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BsonRegex : BsonToken
    {
        // ── Methods ──
        public void set_Pattern(){} // RVA: 0x7A813E420
        public void set_Options(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AF364420
        public void get_Type(){} // RVA: 0x7A83B2180
    }

    public class BsonString : BsonValue
    {
        // ── Methods ──
        public void set_IncludeLength(){} // RVA: 0x7A84A5CD0
        public void .ctor(){} // RVA: 0x7AF3643B0
    }

    public class BsonToken : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A7E01900
        public void set_Parent(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BsonValue : BsonToken
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF364350
        public void get_Type(){} // RVA: 0x7A81C68D0
    }

    public class BsonWriter : JsonWriter
    {
        // ── Methods ──
        public void AddValue(){} // RVA: 0x7AF3645F0
        public void AddToken(){} // RVA: 0x7AF3646B0
        public void WriteObjectId(){} // RVA: 0x7AF364AD0
        public void WriteRegex(){} // RVA: 0x7AF364C50
    }

}