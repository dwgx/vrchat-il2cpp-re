// VRChat IL2CPP Deobfuscated Source
// Namespace: VRCCore
// Classes: 3
// Methods: 13

namespace VRCCore
{
    public class ApiAdminFile : ApiModel
    {
        public string _fileName; // 0x68
        public string _url; // 0x70

        // ── Methods ──
        public void get_fileName(){} // RVA: 0x7FFE81176D50
        public void set_fileName(){} // RVA: 0x7FFE81176D60
        public void get_url(){} // RVA: 0x7FFE811C3590
        public void set_url(){} // RVA: 0x7FFE811C35A0
        public void UploadAdminFile(){} // RVA: 0x7FFE89E89B40
        public void DeleteAdminFile(){} // RVA: 0x7FFE89E89EE0
        public void .ctor(){} // RVA: 0x7FFE89E8A3C0
    }

    public class AssetBundleFooter : Object
    {
        // ── Methods ──
        public void AppendToStream(){} // RVA: 0x7FFE89E8A4C0
        public void GetFooterSections(){} // RVA: 0x7FFE89E8A720 | overloaded x2
        public void ReadNullTerminatedString(){} // RVA: 0x7FFE89E8AF30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89E8B020
    }

    public class FooterSection : ValueType
    {
    }

}