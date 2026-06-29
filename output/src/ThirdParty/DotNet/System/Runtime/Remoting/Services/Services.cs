// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Services
// Classes: 2
// Methods: 7

namespace ThirdParty.DotNet.System.Runtime.Remoting.Services
{
    public class ITrackingHandler
    {
        // ── Methods ──
        public void DisconnectedObject(){} // RVA: 0x894320
        public void MarshaledObject(){} // RVA: 0x8943B0
        public void UnmarshaledObject(){} // RVA: 0x8943B0
    }

    public class TrackingServices : Object
    {
        public object _handlers;

        // ── Methods ──
        public void NotifyMarshaledObject(){} // RVA: 0x6759280
        public void NotifyUnmarshaledObject(){} // RVA: 0x67596A0
        public void NotifyDisconnectedObject(){} // RVA: 0x6759AC0
        public void .cctor(){} // RVA: 0x6759EE0
    }

}