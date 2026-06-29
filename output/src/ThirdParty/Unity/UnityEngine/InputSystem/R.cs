// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 1
// Methods: 17

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class RemoteInputPlayerConnection : ScriptableObject
    {
        public object kNewDeviceMsg;
        public object kNewLayoutMsg;
        public object kNewEventsMsg;
        public object kRemoveDeviceMsg;
        public object kChangeUsagesMsg;
        public object kStartSendingMsg;
        public object kStopSendingMsg;
        public object m_Connection;
        public object m_Subscribers;
        public object m_ConnectedIds;

        // ── Methods ──
        public void Bind(){} // RVA: 0x78B93B0
        public void Subscribe(){} // RVA: 0x78B98D0
        public void OnConnected(){} // RVA: 0x78B9B70
        public void OnDisconnected(){} // RVA: 0x78B9C20
        public void OnNewDevice(){} // RVA: 0x78B9DD0
        public void OnNewLayout(){} // RVA: 0x78B9DE0
        public void OnNewEvents(){} // RVA: 0x78B9DF0
        public void OnRemoveDevice(){} // RVA: 0x78B9E00
        public void OnChangeUsages(){} // RVA: 0x78B9E10
        public void OnStartSending(){} // RVA: 0x78B9E20
        public void OnStopSending(){} // RVA: 0x78B9E30
        public void SendToSubscribers(){} // RVA: 0x78B9E40
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x78BA050
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0xB43310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xDD1AC0
        public void .cctor(){} // RVA: 0x78BA210
    }

}