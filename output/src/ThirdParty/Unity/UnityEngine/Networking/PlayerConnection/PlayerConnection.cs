// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
// Classes: 5
// Methods: 45

namespace ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
{
    public class IEditorPlayerConnection
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x8943B0
        public void RegisterConnection(){} // RVA: 0x894320
        public void RegisterDisconnection(){} // RVA: 0x894320
        public void Send(){} // RVA: 0x8943B0
    }

    public class MessageEventArgs : Object
    {
        public object playerId;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PlayerConnection : ScriptableObject
    {
        public object connectionNative;
        public object m_PlayerEditorConnectionEvents;
        public object m_connectedPlayers;
        public object m_IsInitilized;
        public object s_Instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7C2B640
        public void get_isConnected(){} // RVA: 0x7C2B810
        public void CreateInstance(){} // RVA: 0x7C2B8B0
        public void OnEnable(){} // RVA: 0x7C2B9B0
        public void GetConnectionNativeApi(){} // RVA: 0x7C2BA60
        public void Register(){} // RVA: 0x7C2BAC0
        public void Unregister(){} // RVA: 0x7C2BD90
        public void RegisterConnection(){} // RVA: 0x7C2BFB0
        public void RegisterDisconnection(){} // RVA: 0x7C2C1F0
        public void UnregisterConnection(){} // RVA: 0x7C2C260
        public void UnregisterDisconnection(){} // RVA: 0x7C2C300
        public void Send(){} // RVA: 0x7C2C3A0
        public void TrySend(){} // RVA: 0x7C2C5A0
        public void BlockUntilRecvMsg(){} // RVA: 0x7C2C7A0
        public void DisconnectAll(){} // RVA: 0x7C2CB10
        public void MessageCallbackInternal(){} // RVA: 0x7C2CBB0
        public void ConnectedCallbackInternal(){} // RVA: 0x7C2CDF0
        public void DisconnectedCallback(){} // RVA: 0x7C2CED0
        public void .ctor(){} // RVA: 0x7C2CF70
    }

    public class PlayerConnection[] : Array
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

    public class PlayerEditorConnectionEvents : Object
    {
        public object m_MessageTypeSubscribers;
        public object m_SubscriberLookup;
        public object connectionEvent;
        public object disconnectionEvent;

        // ── Methods ──
        public void get_messageTypeSubscribers(){} // RVA: 0xB5DBF0
        public void BuildLookup(){} // RVA: 0x7C2D150
        public void InvokeMessageIdSubscribers(){} // RVA: 0x7C2D450
        public void AddAndCreate(){} // RVA: 0x7C2D6D0
        public void UnregisterManagedCallback(){} // RVA: 0x7C2DAD0
        public void .ctor(){} // RVA: 0x7C2DCD0
    }

}