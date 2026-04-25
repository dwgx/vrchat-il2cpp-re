// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Forms
// Classes: 5
// Methods: 42

namespace ThirdParty.BestHTTP.BestHTTP.Forms
{
    public class HTTPFieldData : Object
    {
        public string Name; // 0x10
        public string FileName; // 0x18
        public string MimeType; // 0x20
        public System.Text.Encoding Encoding; // 0x28
        public string Text; // 0x30
        public byte[] Binary; // 0x38

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_FileName(){} // RVA: 0x7FFAC2F247C0
        public void set_FileName(){} // RVA: 0x7FFAC2F87E80
        public void get_MimeType(){} // RVA: 0x7FFAC2F4F0C0
        public void set_MimeType(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Encoding(){} // RVA: 0x7FFAC2F4F130
        public void set_Encoding(){} // RVA: 0x7FFAC2F22E90
        public void get_Text(){} // RVA: 0x7FFAC31D95E0
        public void set_Text(){} // RVA: 0x7FFAC2F4F890
        public void get_Binary(){} // RVA: 0x7FFAC31D0140
        public void set_Binary(){} // RVA: 0x7FFAC31D0C20
        public void get_Payload(){} // RVA: 0x7FFACBE15760
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HTTPFormBase : Object
    {
        public int Fields;
        public System.Collections.Generic.List`1<BestHTTP.Forms.HTTPFieldData> IsEmpty; // 0x10
        public bool IsChanged; // 0x18
        public bool HasBinary; // 0x19
        public bool HasLongValue; // 0x1A

        // ── Methods ──
        public void get_Fields(){} // RVA: 0x7FFAC2F3C380
        public void set_Fields(){} // RVA: 0x7FFAC2F22E30
        public void get_IsEmpty(){} // RVA: 0x7FFACBE15820
        public void get_IsChanged(){} // RVA: 0x7FFAC2F3C4E0
        public void set_IsChanged(){} // RVA: 0x7FFAC2F3C4F0
        public void get_HasBinary(){} // RVA: 0x7FFAC3228D50
        public void set_HasBinary(){} // RVA: 0x7FFAC3515120
        public void get_HasLongValue(){} // RVA: 0x7FFAC45FA190
        public void set_HasLongValue(){} // RVA: 0x7FFAC45F9AE0
        public void AddBinaryData(){} // RVA: 0x7FFACBE158B0 | overloaded x3
        public void AddField(){} // RVA: 0x7FFACBE15C90 | overloaded x2
        public void CopyFrom(){} // RVA: 0x7FFACBE15FD0
        public void PrepareRequest(){} // RVA: 0x7FFACBE160D0
        public void GetData(){} // RVA: 0x7FFACBE16110
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HTTPMultiPartForm : HTTPFormBase
    {
        public string Boundary; // 0x20
        public byte[] CachedData; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE16150
        public void PrepareRequest(){} // RVA: 0x7FFACBE162D0
        public void GetData(){} // RVA: 0x7FFACBE16350
    }

    public class HTTPUrlEncodedForm : HTTPFormBase
    {
        public int EscapeTreshold;
        public byte[] CachedData; // 0x20

        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x7FFACBE168B0
        public void GetData(){} // RVA: 0x7FFACBE16920
        public void EscapeString(){} // RVA: 0x7FFACBE16BD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RawJsonForm : HTTPFormBase
    {
        public byte[] CachedData; // 0x20

        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x7FFACBE16D30
        public void GetData(){} // RVA: 0x7FFACBE16DA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}