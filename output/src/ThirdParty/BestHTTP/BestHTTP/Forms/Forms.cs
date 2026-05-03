// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Forms
// Classes: 5
// Methods: 42

namespace ThirdParty.BestHTTP.BestHTTP.Forms
{
    public class HTTPFieldData : Object
    {
        public string _name; // 0x10
        public string _fileName; // 0x18
        public string _mimeType; // 0x20
        public System.Text.Encoding _encoding; // 0x28
        public string _text; // 0x30
        public byte[] _binary; // 0x38
        public object field_6; // 0x99F

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_FileName(){} // RVA: 0x7FFE810FE7C0
        public void set_FileName(){} // RVA: 0x7FFE81161E80
        public void get_MimeType(){} // RVA: 0x7FFE811290C0
        public void set_MimeType(){} // RVA: 0x7FFE811290D0
        public void get_Encoding(){} // RVA: 0x7FFE81129130
        public void set_Encoding(){} // RVA: 0x7FFE810FCE90
        public void get_Text(){} // RVA: 0x7FFE8144E200
        public void set_Text(){} // RVA: 0x7FFE81129890
        public void get_Binary(){} // RVA: 0x7FFE8143BA80
        public void set_Binary(){} // RVA: 0x7FFE81437330
        public void get_Payload(){} // RVA: 0x7FFE8A26ED80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HTTPFormBase : Object
    {
        public int LongLength;
        public System.Collections.Generic.List`1<BestHTTP.Forms.HTTPFieldData> _fields; // 0x10
        public bool _isChanged; // 0x18
        public bool _hasBinary; // 0x19
        public bool _hasLongValue; // 0x1A

        // ── Methods ──
        public void get_Fields(){} // RVA: 0x7FFE81116380
        public void set_Fields(){} // RVA: 0x7FFE810FCE30
        public void get_IsEmpty(){} // RVA: 0x7FFE8A26EE40
        public void get_IsChanged(){} // RVA: 0x7FFE811164E0
        public void set_IsChanged(){} // RVA: 0x7FFE811164F0
        public void get_HasBinary(){} // RVA: 0x7FFE814B3730
        public void set_HasBinary(){} // RVA: 0x7FFE81CD0510
        public void get_HasLongValue(){} // RVA: 0x7FFE82930110
        public void set_HasLongValue(){} // RVA: 0x7FFE8292DD10
        public void AddBinaryData(){} // RVA: 0x7FFE8A26EED0 | overloaded x3
        public void AddField(){} // RVA: 0x7FFE8A26F2B0 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFE8A26F5F0
        public void PrepareRequest(){} // RVA: 0x7FFE8A26F6F0
        public void GetData(){} // RVA: 0x7FFE8A26F730
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HTTPMultiPartForm : HTTPFormBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A26F770
        public void PrepareRequest(){} // RVA: 0x7FFE8A26F8F0
        public void GetData(){} // RVA: 0x7FFE8A26F970
    }

    public class HTTPUrlEncodedForm : HTTPFormBase
    {
        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x7FFE8A26FED0
        public void GetData(){} // RVA: 0x7FFE8A26FF40
        public void EscapeString(){} // RVA: 0x7FFE8A2701F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RawJsonForm : HTTPFormBase
    {
        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x7FFE8A270350
        public void GetData(){} // RVA: 0x7FFE8A2703C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}