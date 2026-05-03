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
        public void RegisterConnection(){} // RVA: 0x7FFE80E460A0
        public void RegisterDisconnection(){} // RVA: 0x7FFE80E460A0
        public void Send(){}
    }

    public class MessageEventArgs : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PlayerConnection : ScriptableObject
    {
        public UnityEngine.IPlayerEditorConnectionNative connectionNative;
        public UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE87C8C7B0
        public void get_isConnected(){} // RVA: 0x7FFE87C8C9B0
        public void CreateInstance(){} // RVA: 0x7FFE87C8CA50
        public void OnEnable(){} // RVA: 0x7FFE87C8CB80
        public void GetConnectionNativeApi(){} // RVA: 0x7FFE87C8CC30
        public void Register(){} // RVA: 0x7FFE87C8CC90
        public void Unregister(){} // RVA: 0x7FFE87C8CEE0
        public void RegisterConnection(){} // RVA: 0x7FFE87C8D250
        public void RegisterDisconnection(){} // RVA: 0x7FFE87C8D480
        public void UnregisterConnection(){} // RVA: 0x7FFE87C8D4F0
        public void UnregisterDisconnection(){} // RVA: 0x7FFE87C8D590
        public void Send(){} // RVA: 0x7FFE87C8D630
        public void TrySend(){} // RVA: 0x7FFE87C8D830
        public void BlockUntilRecvMsg(){} // RVA: 0x7FFE87C8DA30
        public void DisconnectAll(){} // RVA: 0x7FFE87C8DDA0
        public void MessageCallbackInternal(){} // RVA: 0x7FFE87C8DE40
        public void ConnectedCallbackInternal(){} // RVA: 0x7FFE87C8E080
        public void DisconnectedCallback(){} // RVA: 0x7FFE87C8E160
        public void .ctor(){} // RVA: 0x7FFE87C8E200
    }

    public class PlayerEditorConnectionEvents : Object
    {
        // ── Methods ──
        public void InvokeMessageIdSubscribers(){} // RVA: 0x7FFE87C8E3E0
        public void AddAndCreate(){} // RVA: 0x7FFE87C8E7D0
        public void UnregisterManagedCallback(){} // RVA: 0x7FFE87C8EB00
        public void .ctor(){} // RVA: 0x7FFE87C8EC80
    }

}