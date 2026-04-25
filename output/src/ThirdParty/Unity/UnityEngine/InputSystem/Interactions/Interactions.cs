// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Interactions
// Classes: 5
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.InputSystem.Interactions
{
    public class HoldInteraction : Object
    {
        public float durationOrDefault; // 0x10
        public float pressPointOrDefault; // 0x14
        public double m_TimePressed; // 0x18

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFAC955FCF0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFAC955FD70
        public void Process(){} // RVA: 0x7FFAC955FDD0
        public void Reset(){} // RVA: 0x7FFAC47E27C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MultiTapInteraction : Object
    {
        public float tapTimeOrDefault; // 0x10
        public float tapDelayOrDefault; // 0x14
        public int pressPointOrDefault; // 0x18
        public float releasePointOrDefault; // 0x1C
        public 0x6B150A70 m_CurrentTapPhase; // 0x20
        public int m_CurrentTapCount; // 0x24
        public double m_CurrentTapStartTime; // 0x28
        public double m_LastTapReleaseTime; // 0x30

        // ── Methods ──
        public void get_tapTimeOrDefault(){} // RVA: 0x7FFAC955FF60
        public void get_tapDelayOrDefault(){} // RVA: 0x7FFAC955FFE0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFAC9560060
        public void get_releasePointOrDefault(){} // RVA: 0x7FFAC95600C0
        public void Process(){} // RVA: 0x7FFAC9560140
        public void Reset(){} // RVA: 0x7FFAC9560400
        public void .ctor(){} // RVA: 0x7FFAC9560410
    }

    public class PressInteraction : Object
    {
        public float pressPointOrDefault; // 0x10
        public 0x6B150B78 releasePointOrDefault; // 0x14
        public bool m_WaitingForRelease; // 0x18

        // ── Methods ──
        public void get_pressPointOrDefault(){} // RVA: 0x7FFAC9560420
        public void get_releasePointOrDefault(){} // RVA: 0x7FFAC9560480
        public void Process(){} // RVA: 0x7FFAC9560500
        public void Reset(){} // RVA: 0x7FFAC383F000
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SlowTapInteraction : Object
    {
        public float durationOrDefault; // 0x10
        public float pressPointOrDefault; // 0x14
        public double m_SlowTapStartTime; // 0x18

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFAC9560760
        public void get_pressPointOrDefault(){} // RVA: 0x7FFAC95607E0
        public void Process(){} // RVA: 0x7FFAC9560840
        public void Reset(){} // RVA: 0x7FFAC47E27C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TapInteraction : Object
    {
        public float durationOrDefault; // 0x10
        public float pressPointOrDefault; // 0x14
        public double releasePointOrDefault; // 0x18

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFAC9560A10
        public void get_pressPointOrDefault(){} // RVA: 0x7FFAC9560A90
        public void get_releasePointOrDefault(){} // RVA: 0x7FFAC9560AF0
        public void Process(){} // RVA: 0x7FFAC9560B70
        public void Reset(){} // RVA: 0x7FFAC47E27C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}