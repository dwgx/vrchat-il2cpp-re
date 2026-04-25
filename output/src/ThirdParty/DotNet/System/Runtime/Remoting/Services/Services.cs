// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Remoting.Services
// Classes: 2
// Methods: 7

namespace ThirdParty.DotNet.System.Runtime.Remoting.Services
{
    public class ITrackingHandler
    {
        // ── Methods ──
        public void DisconnectedObject(){} // RVA: 0x7FFAC2C70A40
        public void MarshaledObject(){} // RVA: 0x7FFAC2C79B30
        public void UnmarshaledObject(){} // RVA: 0x7FFAC2C79B30
    }

    public class TrackingServices : Object
    {
        public System.Collections.ArrayList _handlers;

        // ── Methods ──
        public void NotifyMarshaledObject(){} // RVA: 0x7FFAC84778C0
        public void NotifyUnmarshaledObject(){} // RVA: 0x7FFAC8477D00
        public void NotifyDisconnectedObject(){} // RVA: 0x7FFAC8478140
        public void .cctor(){} // RVA: 0x7FFAC8478560
    }

}