// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.UdonNetworkCalling
// Classes: 5
// Methods: 44

namespace VRC.SDK3.UdonNetworkCalling
{
    public class NetworkCallableAttribute : Attribute
    {
        public object _maxEventsPerSecond;

        // ── Methods ──
        public void get_MaxEventsPerSecond(){} // RVA: 0xB8F8F0
        public void set_MaxEventsPerSecond(){} // RVA: 0xB460A0
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class NetworkCalling : Object
    {
        public object _inNetworkCall;
        public object _callingPlayer;
        public object _sendCustomNetworkEventProxy;
        public object _getQueuedEventsProxy;
        public object _getAllQueuedEventsProxy;
        public object _parameters;

        // ── Methods ──
        public void get_InNetworkCall(){} // RVA: 0xA6A5970
        public void set_InNetworkCall(){} // RVA: 0xA6A59D0
        public void get_CallingPlayer(){} // RVA: 0xA6A5A30
        public void set_CallingPlayer(){} // RVA: 0xA6A5A90
        public void get_SendCustomNetworkEventProxy(){} // RVA: 0xA6A5B50
        public void set_SendCustomNetworkEventProxy(){} // RVA: 0xA6A5BB0
        public void get_GetQueuedEventsProxy(){} // RVA: 0xA6A5C70
        public void set_GetQueuedEventsProxy(){} // RVA: 0xA6A5CD0
        public void get_GetAllQueuedEventsProxy(){} // RVA: 0xA6A5D90
        public void set_GetAllQueuedEventsProxy(){} // RVA: 0xA6A5DF0
        public void CheckMainThread(){} // RVA: 0xA6A5EB0
        public void SendCustomNetworkEvent(){} // RVA: 0xA6A7180
        public void SendCustomNetworkEventInternal(){} // RVA: 0xA6A7580
        public void WithNetworkCallingContext(){} // RVA: 0xA6A76E0
        public void GetQueuedEvents(){} // RVA: 0xA6A7840
        public void GetAllQueuedEvents(){} // RVA: 0xA6A7960
        public void .cctor(){} // RVA: 0xA6A7A70
    }

    public class NetworkCallingEntrypointMetadata : Object
    {
        public object RATE_LIMIT_MAX;
        public object _maxEventsPerSecond;
        public object _name;
        public object _parameters;
        public object _validated;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB465B0
        public void get_MaxEventsPerSecond(){} // RVA: 0xB8F8F0
        public void get_Parameters(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0xA6A7D60
        public void Validate(){} // RVA: 0xA6A7EA0
        public void ValidateOnce(){} // RVA: 0xA6A8460
    }

    public class NetworkCallingEntrypointMetadata[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NetworkCallingParameterMetadata : Object
    {
        public object _name;
        public object _type;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Type(){} // RVA: 0xB5DD50
        public void .ctor(){} // RVA: 0xA6A8480
    }

}