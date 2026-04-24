// VRChat IL2CPP Deobfuscated Source
// Namespace: VRCCore
// Classes: 3
// Methods: 13

namespace VRCCore
{
    public class ApiAdminFile : ApiModel
    {
        public string fileName; // 0x68
        public string url; // 0x70

        // ── Methods ──
        public void get_fileName(){} // RVA: 0x7FFD4E3BCD50
        public void set_fileName(){} // RVA: 0x7FFD4E3BCD60
        public void get_url(){} // RVA: 0x7FFD4E409590
        public void set_url(){} // RVA: 0x7FFD4E4095A0
        public void UploadAdminFile(){} // RVA: 0x7FFD56E50520
        public void DeleteAdminFile(){} // RVA: 0x7FFD56E508C0
        public void .ctor(){} // RVA: 0x7FFD56E50DA0
    }

    public class AssetBundleFooter : Object
    {
        public string AssetBundleFooterMagicValue;
        public byte[] AssetBundleFooterMagicValueBytes; // 0x8

        // ── Methods ──
        public void AppendToStream(){} // RVA: 0x7FFD56E50EA0
        public void GetFooterSections(){} // RVA: 0x7FFD56E51100 | overloaded x2
        public void ReadNullTerminatedString(){} // RVA: 0x7FFD56E51910
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD56E51A00
    }

    public class FooterSection : ValueType
    {
        public string sectionType; // 0x10
        public byte[] data; // 0x18
    }

}