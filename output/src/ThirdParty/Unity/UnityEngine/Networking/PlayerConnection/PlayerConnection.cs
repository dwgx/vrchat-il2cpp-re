// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
// Classes: 4
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
{
    public class IEditorPlayerConnection
    {
        // ── Methods ──
        public void Register(){}
        public void RegisterConnection(){} // RVA: 0x7FFAC2C70A40
        public void RegisterDisconnection(){} // RVA: 0x7FFAC2C70A40
        public void Send(){}
    }

    public class MessageEventArgs : Object
    {
        public int playerId; // 0x10
        public byte[] data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PlayerConnection : ScriptableObject
    {
        public UnityEngine.IPlayerEditorConnectionNative instance;
        public UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents isConnected; // 0x18
        public System.Collections.Generic.List`1<int> m_connectedPlayers; // 0x20
        public bool m_IsInitilized; // 0x28
        public UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance; // 0x8

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC98E4080
        public void get_isConnected(){} // RVA: 0x7FFAC98E4280
        public void CreateInstance(){} // RVA: 0x7FFAC98E4320
        public void OnEnable(){} // RVA: 0x7FFAC98E4450
        public void GetConnectionNativeApi(){} // RVA: 0x7FFAC98E4500
        public void Register(){} // RVA: 0x7FFAC98E4560
        public void Unregister(){} // RVA: 0x7FFAC98E47B0
        public void RegisterConnection(){} // RVA: 0x7FFAC98E4B20
        public void RegisterDisconnection(){} // RVA: 0x7FFAC98E4D50
        public void UnregisterConnection(){} // RVA: 0x7FFAC98E4DC0
        public void UnregisterDisconnection(){} // RVA: 0x7FFAC98E4E60
        public void Send(){} // RVA: 0x7FFAC98E4F00
        public void TrySend(){} // RVA: 0x7FFAC98E5100
        public void BlockUntilRecvMsg(){} // RVA: 0x7FFAC98E5300
        public void DisconnectAll(){} // RVA: 0x7FFAC98E5670
        public void MessageCallbackInternal(){} // RVA: 0x7FFAC98E5710
        public void ConnectedCallbackInternal(){} // RVA: 0x7FFAC98E5950
        public void DisconnectedCallback(){} // RVA: 0x7FFAC98E5A30
        public void .ctor(){} // RVA: 0x7FFAC98E5AD0
    }

    public class PlayerEditorConnectionEvents : Object
    {
        public System.Collections.Generic.List`1<MessageTypeSubscribers> messageTypeSubscribers; // 0x10
        public ConnectionChangeEvent connectionEvent; // 0x18
        public ConnectionChangeEvent disconnectionEvent; // 0x20

        // ── Methods ──
        public void InvokeMessageIdSubscribers(){} // RVA: 0x7FFAC98E5CB0
        public void AddAndCreate(){} // RVA: 0x7FFAC98E60A0
        public void UnregisterManagedCallback(){} // RVA: 0x7FFAC98E63D0
        public void .ctor(){} // RVA: 0x7FFAC98E6550
    }

}