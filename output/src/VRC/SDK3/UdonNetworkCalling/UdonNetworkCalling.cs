// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.UdonNetworkCalling
// Classes: 1
// Methods: 25

namespace VRC.SDK3.UdonNetworkCalling
{
    public class NetworkCalling : Object
    {
        public bool InNetworkCall;
        public VRC.SDKBase.VRCPlayerApi CallingPlayer; // 0x8
        public SendNetworkEventDelegate SendCustomNetworkEventProxy; // 0x10
        public GetQueuedEventsDelegate GetQueuedEventsProxy; // 0x18
        public GetAllQueuedEventsDelegate GetAllQueuedEventsProxy; // 0x20
        public object[] _parameters; // 0x28

        // ── Methods ──
        public void get_InNetworkCall(){} // RVA: 0x7FFD57411FC0
        public void set_InNetworkCall(){} // RVA: 0x7FFD57412020
        public void get_CallingPlayer(){} // RVA: 0x7FFD57412080
        public void set_CallingPlayer(){} // RVA: 0x7FFD574120E0
        public void get_SendCustomNetworkEventProxy(){} // RVA: 0x7FFD574121A0
        public void set_SendCustomNetworkEventProxy(){} // RVA: 0x7FFD57412200
        public void get_GetQueuedEventsProxy(){} // RVA: 0x7FFD574122C0
        public void set_GetQueuedEventsProxy(){} // RVA: 0x7FFD57412320
        public void get_GetAllQueuedEventsProxy(){} // RVA: 0x7FFD574123E0
        public void set_GetAllQueuedEventsProxy(){} // RVA: 0x7FFD57412440
        public void CheckMainThread(){} // RVA: 0x7FFD57412500
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFD57413C20 | overloaded x9
        public void SendCustomNetworkEventInternal(){} // RVA: 0x7FFD574140C0
        public void WithNetworkCallingContext(){} // RVA: 0x7FFD57414220
        public void GetQueuedEvents(){} // RVA: 0x7FFD57414380
        public void GetAllQueuedEvents(){} // RVA: 0x7FFD574144A0
        public void .cctor(){} // RVA: 0x7FFD574145B0
    }

}