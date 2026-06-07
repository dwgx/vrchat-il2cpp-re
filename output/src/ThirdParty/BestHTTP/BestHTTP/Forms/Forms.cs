// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Forms
// Classes: 5
// Methods: 42

namespace ThirdParty.BestHTTP.BestHTTP.Forms
{
    public class HTTPFieldData
    {
        public object Fields;
        public object IsEmpty;
        public object IsChanged;
        public object HasBinary;
        public object HasLongValue;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void get_FileName(){} // RVA: 0x2E07C0
        public void set_FileName(){} // RVA: 0x343E80
        public void get_MimeType(){} // RVA: 0x30B0C0
        public void set_MimeType(){} // RVA: 0x30B0D0
        public void get_Encoding(){} // RVA: 0x30B130
        public void set_Encoding(){} // RVA: 0x2DEE90
        public void get_Text(){} // RVA: 0x6374D0
        public void set_Text(){} // RVA: 0x30B890
        public void get_Binary(){} // RVA: 0x4976A0
        public void set_Binary(){} // RVA: 0x49B830
        public void get_Payload(){} // RVA: 0x980CA40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HTTPFormBase
    {
        // ── Methods ──
        public void get_Fields(){} // RVA: 0x2F8380
        public void set_Fields(){} // RVA: 0x2DEE30
        public void get_IsEmpty(){} // RVA: 0x980CB00
        public void get_IsChanged(){} // RVA: 0x2F84E0
        public void set_IsChanged(){} // RVA: 0x2F84F0
        public void get_HasBinary(){} // RVA: 0x6B93D0
        public void set_HasBinary(){} // RVA: 0xF43D70
        public void get_HasLongValue(){} // RVA: 0x1B98340
        public void set_HasLongValue(){} // RVA: 0x1B98210
        public void AddBinaryData(){} // RVA: 0x980CB90 | overloaded x3
        public void AddField(){} // RVA: 0x980CF70 | overloaded x2
        public void CopyFrom(){} // RVA: 0x980D2B0
        public void PrepareRequest(){} // RVA: 0x980D3B0
        public void GetData(){} // RVA: 0x980D3F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HTTPMultiPartForm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x980D430
        public void PrepareRequest(){} // RVA: 0x980D5B0
        public void GetData(){} // RVA: 0x980D630
    }

    public class HTTPUrlEncodedForm
    {
        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x980DB90
        public void GetData(){} // RVA: 0x980DC00
        public void EscapeString(){} // RVA: 0x980DEB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RawJsonForm
    {
        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x980E010
        public void GetData(){} // RVA: 0x980E080
        public void .ctor(){} // RVA: 0x2DD310
    }

}