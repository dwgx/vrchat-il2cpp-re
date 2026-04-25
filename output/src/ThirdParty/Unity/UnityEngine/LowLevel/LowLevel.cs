// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.LowLevel
// Classes: 3
// Methods: 7

namespace ThirdParty.Unity.UnityEngine.LowLevel
{
    public class PlayerLoop : Object
    {
        // ── Methods ──
        public void GetCurrentPlayerLoop(){} // RVA: 0x7FFAC98E3630
        public void SetPlayerLoop(){} // RVA: 0x7FFAC98E36D0
        public void PlayerLoopSystemToInternal(){} // RVA: 0x7FFAC98E3890
        public void InternalToPlayerLoopSystem(){} // RVA: 0x7FFAC98E3BB0
        public void GetCurrentPlayerLoopInternal(){} // RVA: 0x7FFAC98E3FE0
        public void SetPlayerLoopInternal(){} // RVA: 0x7FFAC98E4030
    }

    public class PlayerLoopSystem : ValueType
    {
        public System.Type type; // 0x10
        public UnityEngine.LowLevel.PlayerLoopSystem[] subSystemList; // 0x18
        public UpdateFunction updateDelegate; // 0x20
        public UIntPtr updateFunction; // 0x28
        public UIntPtr loopConditionFunction; // 0x30

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC98E3600
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