// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Interactions
// Classes: 5
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.InputSystem.Interactions
{
    public class HoldInteraction : Object
    {
        public object m_TimePressed; // 0x335AA860
        public object durationOrDefault; // 0x170005D1

        // ── Original Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7ffaaef81cc0
        public void get_pressPointOrDefault(){} // RVA: 0x7ffaaef81d40
        public void Process(){} // RVA: 0x7ffaaef81da0
        public void Reset(){} // RVA: 0x7ffaaa1ea6b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class MultiTapInteraction : Object
    {
        public object tapCount; // 0x33AB4030
        public object m_CurrentTapCount; // 0x33AB4030

        // ── Original Methods ──
        public void get_tapTimeOrDefault(){} // RVA: 0x7ffaaef81f30
        public void get_tapDelayOrDefault(){} // RVA: 0x7ffaaef81fb0
        public void get_pressPointOrDefault(){} // RVA: 0x7ffaaef82030
        public void get_releasePointOrDefault(){} // RVA: 0x7ffaaef82090
        public void Process(){} // RVA: 0x7ffaaef82110
        public void Reset(){} // RVA: 0x7ffaaef823d0
        public void .ctor(){} // RVA: 0x7ffaaef823e0
    }

    public class PressInteraction : Object
    {
        public object m_WaitingForRelease; // 0x3389FBA0
        public object pressPointOrDefault; // 0x170005D7

        // ── Original Methods ──
        public void get_pressPointOrDefault(){} // RVA: 0x7ffaaef823f0
        public void get_releasePointOrDefault(){} // RVA: 0x7ffaaef82450
        public void Process(){} // RVA: 0x7ffaaef824d0
        public void Reset(){} // RVA: 0x7ffaaef82730
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SlowTapInteraction : Object
    {
        public object m_SlowTapStartTime; // 0x33619E70
        public object durationOrDefault; // 0x170005D9

        // ── Original Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7ffaaef82740
        public void get_pressPointOrDefault(){} // RVA: 0x7ffaaef827c0
        public void Process(){} // RVA: 0x7ffaaef82820
        public void Reset(){} // RVA: 0x7ffaaa1ea6b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class TapInteraction : Object
    {
        public object m_TapStartTime; // 0x33AEDA60
        public object durationOrDefault; // 0x170005DB

        // ── Original Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7ffaaef829f0
        public void get_pressPointOrDefault(){} // RVA: 0x7ffaaef82a70
        public void get_releasePointOrDefault(){} // RVA: 0x7ffaaef82ad0
        public void Process(){} // RVA: 0x7ffaaef82b50
        public void Reset(){} // RVA: 0x7ffaaa1ea6b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}