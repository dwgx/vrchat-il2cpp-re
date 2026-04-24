// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
// Classes: 2
// Methods: 23

namespace ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
{
    public class IEditorPlayerConnection
    {
        // ── Methods ──
        public void Register(){}
        public void RegisterConnection(){} // RVA: 0x7FFD4E090A40
        public void RegisterDisconnection(){} // RVA: 0x7FFD4E090A40
        public void Send(){}
    }

    public class PlayerConnection : ScriptableObject
    {
        public object instance;
        public object isConnected;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD54D04080
        public void get_isConnected(){} // RVA: 0x7FFD54D04280
        public void CreateInstance(){} // RVA: 0x7FFD54D04320
        public void OnEnable(){} // RVA: 0x7FFD54D04450
        public void GetConnectionNativeApi(){} // RVA: 0x7FFD54D04500
        public void Register(){} // RVA: 0x7FFD54D04560
        public void Unregister(){} // RVA: 0x7FFD54D047B0
        public void RegisterConnection(){} // RVA: 0x7FFD54D04B20
        public void RegisterDisconnection(){} // RVA: 0x7FFD54D04D50
        public void UnregisterConnection(){} // RVA: 0x7FFD54D04DC0
        public void UnregisterDisconnection(){} // RVA: 0x7FFD54D04E60
        public void Send(){} // RVA: 0x7FFD54D04F00
        public void TrySend(){} // RVA: 0x7FFD54D05100
        public void BlockUntilRecvMsg(){} // RVA: 0x7FFD54D05300
        public void DisconnectAll(){} // RVA: 0x7FFD54D05670
        public void MessageCallbackInternal(){} // RVA: 0x7FFD54D05710
        public void ConnectedCallbackInternal(){} // RVA: 0x7FFD54D05950
        public void DisconnectedCallback(){} // RVA: 0x7FFD54D05A30
        public void .ctor(){} // RVA: 0x7FFD54D05AD0
    }

}