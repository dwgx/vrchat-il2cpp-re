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
        public void get_durationOrDefault(){} // RVA: 0x7FFD5497FCF0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD5497FD70
        public void Process(){} // RVA: 0x7FFD5497FDD0
        public void Reset(){} // RVA: 0x7FFD4FC027C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MultiTapInteraction : Object
    {
        public float tapTimeOrDefault; // 0x10
        public float tapDelayOrDefault; // 0x14
        public int pressPointOrDefault; // 0x18
        public float releasePointOrDefault; // 0x1C
        public equencyMotorSpeed m_CurrentTapPhase; // 0x20
        public int m_CurrentTapCount; // 0x24
        public double m_CurrentTapStartTime; // 0x28
        public double m_LastTapReleaseTime; // 0x30

        // ── Methods ──
        public void get_tapTimeOrDefault(){} // RVA: 0x7FFD5497FF60
        public void get_tapDelayOrDefault(){} // RVA: 0x7FFD5497FFE0
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD54980060
        public void get_releasePointOrDefault(){} // RVA: 0x7FFD549800C0
        public void Process(){} // RVA: 0x7FFD54980140
        public void Reset(){} // RVA: 0x7FFD54980400
        public void .ctor(){} // RVA: 0x7FFD54980410
    }

    public class PressInteraction : Object
    {
        public float pressPointOrDefault; // 0x10
        public nputReport.BluetoothOutputReport releasePointOrDefault; // 0x14
        public bool m_WaitingForRelease; // 0x18

        // ── Methods ──
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD54980420
        public void get_releasePointOrDefault(){} // RVA: 0x7FFD54980480
        public void Process(){} // RVA: 0x7FFD54980500
        public void Reset(){} // RVA: 0x7FFD4EC5F000
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SlowTapInteraction : Object
    {
        public float durationOrDefault; // 0x10
        public float pressPointOrDefault; // 0x14
        public double m_SlowTapStartTime; // 0x18

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFD54980760
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD549807E0
        public void Process(){} // RVA: 0x7FFD54980840
        public void Reset(){} // RVA: 0x7FFD4FC027C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TapInteraction : Object
    {
        public float durationOrDefault; // 0x10
        public float pressPointOrDefault; // 0x14
        public double releasePointOrDefault; // 0x18

        // ── Methods ──
        public void get_durationOrDefault(){} // RVA: 0x7FFD54980A10
        public void get_pressPointOrDefault(){} // RVA: 0x7FFD54980A90
        public void get_releasePointOrDefault(){} // RVA: 0x7FFD54980AF0
        public void Process(){} // RVA: 0x7FFD54980B70
        public void Reset(){} // RVA: 0x7FFD4FC027C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}