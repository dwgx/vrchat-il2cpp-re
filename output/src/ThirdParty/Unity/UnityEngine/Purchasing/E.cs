// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 3
// Methods: 8

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class EmptyAnalyticsAdapter : Object
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7FFAC2F21310
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EnumerableExtensions : Object
    {
        // ── Methods ──
        public void NonNull(){} // RVA: 0x7FFAC2C58F80
        public void IgnoreExceptions(){} // RVA: 0x7FFAC2C58FF0
    }

    public class ExponentialRetryPolicy : Object
    {
        public int m_BaseRetryDelay; // 0x10
        public int m_MaxRetryDelay; // 0x14
        public int m_ExponentialFactor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC48B1250
        public void Invoke(){} // RVA: 0x7FFAC99E2200
        public void AdjustDelay(){} // RVA: 0x7FFAC99E23D0
    }

}