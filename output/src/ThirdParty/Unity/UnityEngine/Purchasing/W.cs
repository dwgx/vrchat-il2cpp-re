// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 1
// Methods: 7

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class WinRTStore : AbstractStore
    {
        public UnityEngine.Purchasing.Default.IWindowsIAP win8; // 0x10
        public UnityEngine.Purchasing.Extension.IStoreCallback callback; // 0x18
        public Uniject.IUtil util; // 0x20
        public UnityEngine.ILogger logger; // 0x28
        public bool m_CanReceivePurchases; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99E4080
        public void Initialize(){} // RVA: 0x7FFAC2F87E80
        public void RetrieveProducts(){} // RVA: 0x7FFAC99E4180
        public void FinishTransaction(){} // RVA: 0x7FFAC99E45D0
        public void init(){} // RVA: 0x7FFAC99E4630
        public void Purchase(){} // RVA: 0x7FFAC99E46A0
        public void restoreTransactions(){} // RVA: 0x7FFAC99E4710
    }

}