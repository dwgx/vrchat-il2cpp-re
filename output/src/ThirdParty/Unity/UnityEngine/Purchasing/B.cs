// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 1
// Methods: 5

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class BillingClientStateListener : AndroidJavaProxy
    {
        public System.Action m_OnConnected; // 0x20
        public System.Action`1<0x6B27F3D0> m_Disconnect; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99BC2A0
        public void RegisterOnConnected(){} // RVA: 0x7FFAC2F4F0D0
        public void RegisterOnDisconnected(){} // RVA: 0x7FFAC2F22E90
        public void onBillingSetupFinished(){} // RVA: 0x7FFAC99BC310
        public void onBillingServiceDisconnected(){} // RVA: 0x7FFAC99BC400
    }

}