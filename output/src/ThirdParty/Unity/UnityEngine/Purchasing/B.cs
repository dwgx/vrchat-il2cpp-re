// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 1
// Methods: 5

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class BillingClientStateListener : AndroidJavaProxy
    {
        public System.Action m_OnConnected; // 0x20
        public System.Action`1<0x665DF3D0> m_Disconnect; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DDC2A0
        public void RegisterOnConnected(){} // RVA: 0x7FFD4E36F0D0
        public void RegisterOnDisconnected(){} // RVA: 0x7FFD4E342E90
        public void onBillingSetupFinished(){} // RVA: 0x7FFD54DDC310
        public void onBillingServiceDisconnected(){} // RVA: 0x7FFD54DDC400
    }

}