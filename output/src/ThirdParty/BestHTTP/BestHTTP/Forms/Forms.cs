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
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void get_FileName(){} // RVA: 0x7FFAF2D907C0
        public void set_FileName(){} // RVA: 0x7FFAF2DF3E80
        public void get_MimeType(){} // RVA: 0x7FFAF2DBB0C0
        public void set_MimeType(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Encoding(){} // RVA: 0x7FFAF2DBB130
        public void set_Encoding(){} // RVA: 0x7FFAF2D8EE90
        public void get_Text(){} // RVA: 0x7FFAF30E74D0
        public void set_Text(){} // RVA: 0x7FFAF2DBB890
        public void get_Binary(){} // RVA: 0x7FFAF2F476A0
        public void set_Binary(){} // RVA: 0x7FFAF2F4B830
        public void get_Payload(){} // RVA: 0x7FFAFC2BCA40
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HTTPFormBase
    {
        // ── Methods ──
        public void get_Fields(){} // RVA: 0x7FFAF2DA8380
        public void set_Fields(){} // RVA: 0x7FFAF2D8EE30
        public void get_IsEmpty(){} // RVA: 0x7FFAFC2BCB00
        public void get_IsChanged(){} // RVA: 0x7FFAF2DA84E0
        public void set_IsChanged(){} // RVA: 0x7FFAF2DA84F0
        public void get_HasBinary(){} // RVA: 0x7FFAF31693D0
        public void set_HasBinary(){} // RVA: 0x7FFAF39F3D70
        public void get_HasLongValue(){} // RVA: 0x7FFAF4648340
        public void set_HasLongValue(){} // RVA: 0x7FFAF4648210
        public void AddBinaryData(){} // RVA: 0x7FFAFC2BCB90 | overloaded x3
        public void AddField(){} // RVA: 0x7FFAFC2BCF70 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFAFC2BD2B0
        public void PrepareRequest(){} // RVA: 0x7FFAFC2BD3B0
        public void GetData(){} // RVA: 0x7FFAFC2BD3F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HTTPMultiPartForm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2BD430
        public void PrepareRequest(){} // RVA: 0x7FFAFC2BD5B0
        public void GetData(){} // RVA: 0x7FFAFC2BD630
    }

    public class HTTPUrlEncodedForm
    {
        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x7FFAFC2BDB90
        public void GetData(){} // RVA: 0x7FFAFC2BDC00
        public void EscapeString(){} // RVA: 0x7FFAFC2BDEB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RawJsonForm
    {
        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x7FFAFC2BE010
        public void GetData(){} // RVA: 0x7FFAFC2BE080
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}