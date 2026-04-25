// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 2
// Methods: 2

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class GroupPresenceJoinIntent : Object
    {
        public string DeeplinkMessage; // 0x10
        public string DestinationApiName; // 0x18
        public string LobbySessionId; // 0x20
        public string MatchSessionId; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887F270
    }

    public class GroupPresenceLeaveIntent : Object
    {
        public string DestinationApiName; // 0x10
        public string LobbySessionId; // 0x18
        public string MatchSessionId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887F6A0
    }

}