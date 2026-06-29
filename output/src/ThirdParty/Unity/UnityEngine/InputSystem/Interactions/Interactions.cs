// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Interactions
// Classes: 5
// Methods: 28

namespace ThirdParty.Unity.UnityEngine.InputSystem.Interactions
{
    public class HoldInteraction : Object
    {
        public object duration;
        public object pressPoint;
        public object m_TimePressed;

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x78258A0
        public void get_pressPointOrDefault(){} // RVA: 0x7825920
        public void Process(){} // RVA: 0x7825980
        public void Reset(){} // RVA: 0x2566C40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MultiTapInteraction : Object
    {
        public object tapTime;
        public object tapDelay;
        public object tapCount;
        public object pressPoint;
        public object m_CurrentTapPhase;
        public object m_CurrentTapCount;
        public object m_CurrentTapStartTime;
        public object m_LastTapReleaseTime;

        // ── Methods ──
        public void get_tapTimeOrDefault(){} // RVA: 0x7825B10
        public void get_tapDelayOrDefault(){} // RVA: 0x7825B90
        public void get_pressPointOrDefault(){} // RVA: 0x7825C10
        public void get_releasePointOrDefault(){} // RVA: 0x7825C70
        public void Process(){} // RVA: 0x7825CF0
        public void Reset(){} // RVA: 0x7825FB0
        public void .ctor(){} // RVA: 0x7825FC0
    }

    public class PressInteraction : Object
    {
        public object pressPoint;
        public object behavior;
        public object m_WaitingForRelease;

        // ── Methods ──
        public void get_pressPointOrDefault(){} // RVA: 0x7825FD0
        public void get_releasePointOrDefault(){} // RVA: 0x7826030
        public void Process(){} // RVA: 0x78260B0
        public void Reset(){} // RVA: 0x7826310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SlowTapInteraction : Object
    {
        public object duration;
        public object pressPoint;
        public object m_SlowTapStartTime;

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7826320
        public void get_pressPointOrDefault(){} // RVA: 0x78263A0
        public void Process(){} // RVA: 0x7826400
        public void Reset(){} // RVA: 0x2566C40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TapInteraction : Object
    {
        public object duration;
        public object pressPoint;
        public object m_TapStartTime;

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x78265D0
        public void get_pressPointOrDefault(){} // RVA: 0x7826650
        public void get_releasePointOrDefault(){} // RVA: 0x78266B0
        public void Process(){} // RVA: 0x7826730
        public void Reset(){} // RVA: 0x2566C40
        public void .ctor(){} // RVA: 0xB43310
    }

}