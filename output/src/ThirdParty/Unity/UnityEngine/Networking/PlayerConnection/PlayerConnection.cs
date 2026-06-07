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
        public void RegisterConnection(){} // RVA: 0x24B10
        public void RegisterDisconnection(){} // RVA: 0x24B10
        public void Send(){}
    }

    public class MessageEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class PlayerConnection
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x714BB40
        public void get_isConnected(){} // RVA: 0x714BD40
        public void CreateInstance(){} // RVA: 0x714BDE0
        public void OnEnable(){} // RVA: 0x714BF10
        public void GetConnectionNativeApi(){} // RVA: 0x714BFC0
        public void Register(){} // RVA: 0x714C020
        public void Unregister(){} // RVA: 0x714C270
        public void RegisterConnection(){} // RVA: 0x714C5E0
        public void RegisterDisconnection(){} // RVA: 0x714C810
        public void UnregisterConnection(){} // RVA: 0x714C880
        public void UnregisterDisconnection(){} // RVA: 0x714C920
        public void Send(){} // RVA: 0x714C9C0
        public void TrySend(){} // RVA: 0x714CBC0
        public void BlockUntilRecvMsg(){} // RVA: 0x714CDC0
        public void DisconnectAll(){} // RVA: 0x714D130
        public void MessageCallbackInternal(){} // RVA: 0x714D1D0
        public void ConnectedCallbackInternal(){} // RVA: 0x714D410
        public void DisconnectedCallback(){} // RVA: 0x714D4F0
        public void .ctor(){} // RVA: 0x714D590
    }

    public class PlayerEditorConnectionEvents
    {
        // ── Methods ──
        public void InvokeMessageIdSubscribers(){} // RVA: 0x714D770
        public void AddAndCreate(){} // RVA: 0x714DB60
        public void UnregisterManagedCallback(){} // RVA: 0x714DE90
        public void .ctor(){} // RVA: 0x714E010
    }

}