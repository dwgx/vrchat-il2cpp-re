// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Interactions
// Classes: 5
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.InputSystem.Interactions
{
    public class HoldInteraction : Object
    {
        public float duration; // 0x10
        public float pressPoint; // 0x14

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFE87908430
        public void get_pressPointOrDefault(){} // RVA: 0x7FFE879084B0
        public void Process(){} // RVA: 0x7FFE87908510
        public void Reset(){} // RVA: 0x7FFE82A4AB60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MultiTapInteraction : Object
    {
        public float tapTime; // 0x10
        public float tapDelay; // 0x14
        public int tapCount; // 0x18
        public float pressPoint; // 0x1C

        // ── Methods ──
        public void get_tapTimeOrDefault(){} // RVA: 0x7FFE879086A0
        public void get_tapDelayOrDefault(){} // RVA: 0x7FFE87908720
        public void get_pressPointOrDefault(){} // RVA: 0x7FFE879087A0
        public void get_releasePointOrDefault(){} // RVA: 0x7FFE87908800
        public void Process(){} // RVA: 0x7FFE87908880
        public void Reset(){} // RVA: 0x7FFE87908B40
        public void .ctor(){} // RVA: 0x7FFE87908B50
    }

    public class PressInteraction : Object
    {
        public float pressPoint; // 0x10
        public 0x66549A9C behavior; // 0x14

        // ── Methods ──
        public void get_pressPointOrDefault(){} // RVA: 0x7FFE87908B60
        public void get_releasePointOrDefault(){} // RVA: 0x7FFE87908BC0
        public void Process(){} // RVA: 0x7FFE87908C40
        public void Reset(){} // RVA: 0x7FFE81998190
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SlowTapInteraction : Object
    {
        public float duration; // 0x10
        public float pressPoint; // 0x14

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFE87908EA0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFE87908F20
        public void Process(){} // RVA: 0x7FFE87908F80
        public void Reset(){} // RVA: 0x7FFE82A4AB60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TapInteraction : Object
    {
        public float duration; // 0x10
        public float pressPoint; // 0x14
        public double m_TapStartTime; // 0x18

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFE87909150
        public void get_pressPointOrDefault(){} // RVA: 0x7FFE879091D0
        public void get_releasePointOrDefault(){} // RVA: 0x7FFE87909230
        public void Process(){} // RVA: 0x7FFE879092B0
        public void Reset(){} // RVA: 0x7FFE82A4AB60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}