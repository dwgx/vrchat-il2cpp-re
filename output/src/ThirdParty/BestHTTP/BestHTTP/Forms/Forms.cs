// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Forms
// Classes: 5
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Forms
{
    public class HTTPFieldData : Object
    {
        public object _name;
        public object _fileName;
        public object _mimeType;
        public object _encoding;
        public object _text;
        public object _binary;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_FileName(){} // RVA: 0xB465B0
        public void set_FileName(){} // RVA: 0xBA9BA0
        public void get_MimeType(){} // RVA: 0xB700F0
        public void set_MimeType(){} // RVA: 0xB70100
        public void get_Encoding(){} // RVA: 0xB70160
        public void set_Encoding(){} // RVA: 0xB44DC0
        public void get_Text(){} // RVA: 0xD33E60
        public void set_Text(){} // RVA: 0xB708C0
        public void get_Binary(){} // RVA: 0xD05CA0
        public void set_Binary(){} // RVA: 0xD09D70
        public void get_Payload(){} // RVA: 0xA4B2100
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HTTPFormBase : Object
    {
        public object LongLength;
        public object _fields;
        public object _isChanged;
        public object _hasBinary;
        public object _hasLongValue;

        // ── Methods ──
        public void get_Fields(){} // RVA: 0xB5DBF0
        public void set_Fields(){} // RVA: 0xB44D60
        public void get_IsEmpty(){} // RVA: 0xA4B21C0
        public void get_IsChanged(){} // RVA: 0xB5DD50
        public void set_IsChanged(){} // RVA: 0xB5DD60
        public void get_HasBinary(){} // RVA: 0xF43F30
        public void set_HasBinary(){} // RVA: 0x17F4D80
        public void get_HasLongValue(){} // RVA: 0x246FA20
        public void set_HasLongValue(){} // RVA: 0x246E8E0
        public void AddBinaryData(){} // RVA: 0xA4B2250
        public void AddField(){} // RVA: 0xA4B2630
        public void CopyFrom(){} // RVA: 0xA4B2970
        public void PrepareRequest(){} // RVA: 0xA4B2A70
        public void GetData(){} // RVA: 0xA4B2AB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HTTPMultiPartForm : HTTPFormBase
    {
        public object Boundary;
        public object CachedData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4B2AF0
        public void PrepareRequest(){} // RVA: 0xA4B2C70
        public void GetData(){} // RVA: 0xA4B2CF0
    }

    public class HTTPUrlEncodedForm : HTTPFormBase
    {
        public object EscapeTreshold;
        public object CachedData;

        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0xA4B3250
        public void GetData(){} // RVA: 0xA4B32C0
        public void EscapeString(){} // RVA: 0xA4B3590
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RawJsonForm : HTTPFormBase
    {
        public object CachedData;

        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0xA4B36F0
        public void GetData(){} // RVA: 0xA4B3760
        public void .ctor(){} // RVA: 0xB43310
    }

}