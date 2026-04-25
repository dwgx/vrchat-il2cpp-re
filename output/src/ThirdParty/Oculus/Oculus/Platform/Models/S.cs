// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 6
// Methods: 6

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class SdkAccount : Object
    {
        public 0x6B258A18 AccountType; // 0x10
        public ulong UserId; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8889DA0
    }

    public class SdkAccountList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8889ED0
    }

    public class SendInvitesResult : Object
    {
        public Oculus.Platform.Models.ApplicationInviteList Invites; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888A290
    }

    public class ShareMediaResult : Object
    {
        public 0x6B258B20 Status; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888A3E0
    }

    public class SupplementaryMetric : Object
    {
        public ulong ID; // 0x10
        public long Metric; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888A4A0
    }

    public class SystemVoipState : Object
    {
        public 0x6B258F98 MicrophoneMuted; // 0x10
        public 0x6B258C80 Status; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC888A5D0
    }

}