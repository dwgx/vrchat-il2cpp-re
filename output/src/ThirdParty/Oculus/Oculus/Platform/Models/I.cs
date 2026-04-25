// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 3
// Methods: 3

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class InstalledApplication : Object
    {
        public string ApplicationId; // 0x10
        public string PackageName; // 0x18
        public string Status; // 0x20
        public int VersionCode; // 0x28
        public string VersionName; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887FC40
    }

    public class InstalledApplicationList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88800C0
    }

    public class InvitePanelResultInfo : Object
    {
        public bool InvitesSent; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88803A0
    }

}