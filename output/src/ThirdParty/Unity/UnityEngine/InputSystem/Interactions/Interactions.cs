// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Interactions
// Classes: 5
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.InputSystem.Interactions
{
    public class HoldInteraction
    {
        public float duration; // 0x10
        public float pressPoint; // 0x14

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x6DC7590
        public void get_pressPointOrDefault(){} // RVA: 0x6DC7610
        public void Process(){} // RVA: 0x6DC7670
        public void Reset(){} // RVA: 0x1CB90E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class MultiTapInteraction
    {
        public float tapTime; // 0x10
        public float tapDelay; // 0x14
        public int tapCount; // 0x18
        public float pressPoint; // 0x1C

        // ── Methods ──
        public void get_tapTimeOrDefault(){} // RVA: 0x6DC7800
        public void get_tapDelayOrDefault(){} // RVA: 0x6DC7880
        public void get_pressPointOrDefault(){} // RVA: 0x6DC7900
        public void get_releasePointOrDefault(){} // RVA: 0x6DC7960
        public void Process(){} // RVA: 0x6DC79E0
        public void Reset(){} // RVA: 0x6DC7CA0
        public void .ctor(){} // RVA: 0x6DC7CB0
    }

    public class PressInteraction
    {
        public float pressPoint; // 0x10
        public 0x65871BE8 behavior; // 0x14

        // ── Methods ──
        public void get_pressPointOrDefault(){} // RVA: 0x6DC7CC0
        public void get_releasePointOrDefault(){} // RVA: 0x6DC7D20
        public void Process(){} // RVA: 0x6DC7DA0
        public void Reset(){} // RVA: 0x6DC8000
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SlowTapInteraction
    {
        public float duration; // 0x10
        public float pressPoint; // 0x14

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x6DC8010
        public void get_pressPointOrDefault(){} // RVA: 0x6DC8090
        public void Process(){} // RVA: 0x6DC80F0
        public void Reset(){} // RVA: 0x1CB90E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TapInteraction
    {
        public float duration; // 0x10
        public float pressPoint; // 0x14
        public double m_TapStartTime; // 0x18

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x6DC82C0
        public void get_pressPointOrDefault(){} // RVA: 0x6DC8340
        public void get_releasePointOrDefault(){} // RVA: 0x6DC83A0
        public void Process(){} // RVA: 0x6DC8420
        public void Reset(){} // RVA: 0x1CB90E0
        public void .ctor(){} // RVA: 0x2DD310
    }

}