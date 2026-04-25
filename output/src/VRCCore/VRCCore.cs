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
        public void get_fileName(){} // RVA: 0x7FFAC2F9CD50
        public void set_fileName(){} // RVA: 0x7FFAC2F9CD60
        public void get_url(){} // RVA: 0x7FFAC2FE9590
        public void set_url(){} // RVA: 0x7FFAC2FE95A0
        public void UploadAdminFile(){} // RVA: 0x7FFACBA30520
        public void DeleteAdminFile(){} // RVA: 0x7FFACBA308C0
        public void .ctor(){} // RVA: 0x7FFACBA30DA0
    }

    public class AssetBundleFooter : Object
    {
        public string AssetBundleFooterMagicValue;
        public byte[] AssetBundleFooterMagicValueBytes; // 0x8

        // ── Methods ──
        public void AppendToStream(){} // RVA: 0x7FFACBA30EA0
        public void GetFooterSections(){} // RVA: 0x7FFACBA31100 | overloaded x2
        public void ReadNullTerminatedString(){} // RVA: 0x7FFACBA31910
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA31A00
    }

    public class FooterSection : ValueType
    {
        public string sectionType; // 0x10
        public byte[] data; // 0x18
    }

}