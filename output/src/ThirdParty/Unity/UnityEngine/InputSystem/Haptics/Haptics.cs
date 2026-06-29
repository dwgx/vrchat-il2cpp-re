// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Haptics
// Classes: 3
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.InputSystem.Haptics
{
    public class DualMotorRumble : ValueType
    {
        public object _lowFrequencyMotorSpeed;
        public object _highFrequencyMotorSpeed;

        // ── Methods ──
        public void get_lowFrequencyMotorSpeed(){} // RVA: 0x88D10
        public void set_lowFrequencyMotorSpeed(){} // RVA: 0xD1B20
        public void get_highFrequencyMotorSpeed(){} // RVA: 0xD1B60
        public void set_highFrequencyMotorSpeed(){} // RVA: 0xD1B40
        public void get_isRumbling(){} // RVA: 0x93A1F0
        public void PauseHaptics(){} // RVA: 0x93A230
        public void ResumeHaptics(){} // RVA: 0x93A240
        public void ResetHaptics(){} // RVA: 0x93A2F0
        public void SetMotorSpeeds(){} // RVA: 0x93A3A0
    }

    public class IDualMotorRumble
    {
        // ── Methods ──
        public void SetMotorSpeeds(){} // RVA: 0x8A2920
    }

    public class IHaptics
    {
        // ── Methods ──
        public void PauseHaptics(){} // RVA: 0x894290
        public void ResumeHaptics(){} // RVA: 0x894290
        public void ResetHaptics(){} // RVA: 0x894290
    }

}