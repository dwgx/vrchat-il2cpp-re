// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 2
// Methods: 6

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class TimeSpanUnits : Object
    {
        public double days; // 0x10
        public int months; // 0x18
        public int years; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99DE6D0
    }

    public class TransactionLog : Object
    {
        public UnityEngine.ILogger logger; // 0x10
        public string persistentDataPath; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99B0A00
        public void HasRecordOf(){} // RVA: 0x7FFAC99B0B70
        public void Record(){} // RVA: 0x7FFAC99B0BB0
        public void GetRecordPath(){} // RVA: 0x7FFAC99B0C30
        public void ComputeHash(){} // RVA: 0x7FFAC99B0CA0
    }

}