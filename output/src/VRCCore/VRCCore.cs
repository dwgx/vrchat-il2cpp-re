// VRChat IL2CPP Deobfuscated Source
// Namespace: VRCCore
// Classes: 2
// Methods: 12

namespace VRCCore
{
    public class ApiAdminFile : ApiModel
    {
        public object _fileName;
        public object _url;

        // ── Methods ──
        public void get_fileName(){} // RVA: 0xBBFF90
        public void set_fileName(){} // RVA: 0xBBFFA0
        public void get_url(){} // RVA: 0xC10050
        public void set_url(){} // RVA: 0xC10060
        public void UploadAdminFile(){} // RVA: 0xA0C6F20
        public void DeleteAdminFile(){} // RVA: 0xA0C72C0
        public void .ctor(){} // RVA: 0xA0C77A0
    }

    public class AssetBundleFooter : Object
    {
        public object AssetBundleFooterMagicValue;
        public object AssetBundleFooterMagicValueBytes;

        // ── Methods ──
        public void AppendToStream(){} // RVA: 0xA0C78A0
        public void GetFooterSections(){} // RVA: 0xA0C7B00
        public void ReadNullTerminatedString(){} // RVA: 0xA0C8310
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA0C8400
    }

}