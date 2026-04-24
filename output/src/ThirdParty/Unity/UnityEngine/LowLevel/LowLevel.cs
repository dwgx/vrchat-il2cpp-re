// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.LowLevel
// Classes: 2
// Methods: 1

namespace ThirdParty.Unity.UnityEngine.LowLevel
{
    public class PlayerLoopSystem : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD54D03600
    }

    public class PlayerLoopSystemInternal : ValueType
    {
        public object type; // 0x10
        public ncellationToken updateDelegate; // 0x18
        public UIntPtr updateFunction; // 0x20
        public UIntPtr loopConditionFunction; // 0x28
        public int numSubSystems; // 0x30
    }

}