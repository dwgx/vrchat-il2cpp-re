// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 2
// Methods: 2

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class GroupPresenceJoinIntent : Object
    {
        public object DeeplinkMessage;
        public object DestinationApiName;
        public object LobbySessionId;
        public object MatchSessionId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5ADD0
    }

    public class GroupPresenceLeaveIntent : Object
    {
        public object DestinationApiName;
        public object LobbySessionId;
        public object MatchSessionId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5B210
    }

}