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
        public void RegisterConnection(){} // RVA: 0x7FFAF2AD4B10
        public void RegisterDisconnection(){} // RVA: 0x7FFAF2AD4B10
        public void Send(){}
    }

    public class MessageEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class PlayerConnection
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAF9BFBB40
        public void get_isConnected(){} // RVA: 0x7FFAF9BFBD40
        public void CreateInstance(){} // RVA: 0x7FFAF9BFBDE0
        public void OnEnable(){} // RVA: 0x7FFAF9BFBF10
        public void GetConnectionNativeApi(){} // RVA: 0x7FFAF9BFBFC0
        public void Register(){} // RVA: 0x7FFAF9BFC020
        public void Unregister(){} // RVA: 0x7FFAF9BFC270
        public void RegisterConnection(){} // RVA: 0x7FFAF9BFC5E0
        public void RegisterDisconnection(){} // RVA: 0x7FFAF9BFC810
        public void UnregisterConnection(){} // RVA: 0x7FFAF9BFC880
        public void UnregisterDisconnection(){} // RVA: 0x7FFAF9BFC920
        public void Send(){} // RVA: 0x7FFAF9BFC9C0
        public void TrySend(){} // RVA: 0x7FFAF9BFCBC0
        public void BlockUntilRecvMsg(){} // RVA: 0x7FFAF9BFCDC0
        public void DisconnectAll(){} // RVA: 0x7FFAF9BFD130
        public void MessageCallbackInternal(){} // RVA: 0x7FFAF9BFD1D0
        public void ConnectedCallbackInternal(){} // RVA: 0x7FFAF9BFD410
        public void DisconnectedCallback(){} // RVA: 0x7FFAF9BFD4F0
        public void .ctor(){} // RVA: 0x7FFAF9BFD590
    }

    public class PlayerEditorConnectionEvents
    {
        // ── Methods ──
        public void InvokeMessageIdSubscribers(){} // RVA: 0x7FFAF9BFD770
        public void AddAndCreate(){} // RVA: 0x7FFAF9BFDB60
        public void UnregisterManagedCallback(){} // RVA: 0x7FFAF9BFDE90
        public void .ctor(){} // RVA: 0x7FFAF9BFE010
    }

}