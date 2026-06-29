// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Forms
// Classes: 5
// Methods: 39

namespace ThirdParty.BestHTTP.BestHTTP.Forms
{
    public class HTTPFieldData : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void get_FileName(){} // RVA: 0x7A80DA7B0
        public void set_FileName(){} // RVA: 0x7A813E420
        public void get_MimeType(){} // RVA: 0x7A81052C0
        public void set_MimeType(){} // RVA: 0x7A81052D0
        public void get_Encoding(){} // RVA: 0x7A8105330
        public void set_Encoding(){} // RVA: 0x7A80D8E80
        public void get_Text(){} // RVA: 0x7A83F69F0
        public void set_Text(){} // RVA: 0x7A8105A90
        public void get_Binary(){} // RVA: 0x7A8292C30
        public void set_Binary(){} // RVA: 0x7A8296DE0
        public void get_Payload(){} // RVA: 0x7B1646CB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HTTPFormBase : Object
    {
        // ── Methods ──
        public void get_Fields(){} // RVA: 0x7A80F2570
        public void set_Fields(){} // RVA: 0x7A80D8E20
        public void get_IsEmpty(){} // RVA: 0x7B1646D70
        public void get_IsChanged(){} // RVA: 0x7A80F26D0
        public void set_IsChanged(){} // RVA: 0x7A80F26E0
        public void get_HasBinary(){} // RVA: 0x7A8475E20
        public void set_HasBinary(){} // RVA: 0x7A8D0E640
        public void get_HasLongValue(){} // RVA: 0x7A9956320
        public void set_HasLongValue(){} // RVA: 0x7A99561F0
        public void AddBinaryData(){} // RVA: 0x7B1646E00
        public void AddField(){} // RVA: 0x7B16471E0
        public void CopyFrom(){} // RVA: 0x7B1647520
        public void PrepareRequest(){} // RVA: 0x7B1647620
        public void GetData(){} // RVA: 0x7B1647660
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HTTPMultiPartForm : HTTPFormBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16476A0
        public void PrepareRequest(){} // RVA: 0x7B1647820
        public void GetData(){} // RVA: 0x7B16478A0
    }

    public class HTTPUrlEncodedForm : HTTPFormBase
    {
        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x7B1647E10
        public void GetData(){} // RVA: 0x7B1647E80
        public void EscapeString(){} // RVA: 0x7B1648150
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RawJsonForm : HTTPFormBase
    {
        // ── Methods ──
        public void PrepareRequest(){} // RVA: 0x7B16482B0
        public void GetData(){} // RVA: 0x7B1648320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}