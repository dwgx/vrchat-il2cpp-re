// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
// Classes: 2
// Methods: 23

namespace ThirdParty.Unity.UnityEngine.Networking.PlayerConnection
{
    public class IEditorPlayerConnection
    {
        // ── Original Methods ──
        public void Register(){}
        public void RegisterConnection(){} // RVA: 0x7ffaa8660d80
        public void RegisterDisconnection(){} // RVA: 0x7ffaa8660d80
        public void Send(){}
    }

    public class PlayerConnection : ScriptableObject
    {
        public object m_connectedPlayers; // 0x32CBB1D0

        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaaf305fe0
        public void get_isConnected(){} // RVA: 0x7ffaaf3061e0
        public void CreateInstance(){} // RVA: 0x7ffaaf306280
        public void OnEnable(){} // RVA: 0x7ffaaf3063b0
        public void Register(){} // RVA: 0x7ffaaf3064c0
        public void Unregister(){} // RVA: 0x7ffaaf306710
        public void RegisterConnection(){} // RVA: 0x7ffaaf306a80
        public void RegisterDisconnection(){} // RVA: 0x7ffaaf306cb0
        public void UnregisterConnection(){} // RVA: 0x7ffaaf306d20
        public void UnregisterDisconnection(){} // RVA: 0x7ffaaf306dc0
        public void Send(){} // RVA: 0x7ffaaf306e60
        public void TrySend(){} // RVA: 0x7ffaaf307060
        public void BlockUntilRecvMsg(){} // RVA: 0x7ffaaf307260
        public void DisconnectAll(){} // RVA: 0x7ffaaf3075d0
        public void MessageCallbackInternal(){} // RVA: 0x7ffaaf307670
        public void ConnectedCallbackInternal(){} // RVA: 0x7ffaaf3078b0
        public void DisconnectedCallback(){} // RVA: 0x7ffaaf307990
        public void .ctor(){} // RVA: 0x7ffaaf307a30
        // ── Binary Analysis Named ──
        public void GetConnectionNativeApi(){} // RVA: 0x7ffaaf306460
    }

}