// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.LowLevel
// Classes: 2
// Methods: 1

namespace ThirdParty.Unity.UnityEngine.LowLevel
{
    public class PlayerLoopSystem : ValueType
    {
        public System.Type type; // 0x10
        public UnityEngine.LowLevel.PlayerLoopSystem[] subSystemList; // 0x18
        public UpdateFunction updateDelegate; // 0x20
        public UIntPtr updateFunction; // 0x28
        public UIntPtr loopConditionFunction; // 0x30

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD54D03600
    }

    public class PlayerLoopSystemInternal : ValueType
    {
        public System.Type type; // 0x10
        public UpdateFunction updateDelegate; // 0x18
        public UIntPtr updateFunction; // 0x20
        public UIntPtr loopConditionFunction; // 0x28
        public int numSubSystems; // 0x30
    }

}