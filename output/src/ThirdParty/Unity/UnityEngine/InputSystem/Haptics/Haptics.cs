// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Haptics
// Classes: 3
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.InputSystem.Haptics
{
    public class DualMotorRumble : ValueType
    {
        public float _lowFrequencyMotorSpeed; // 0x10
        public float _highFrequencyMotorSpeed; // 0x14
        public object field_2; // 0x1AA

        // ── Methods ──
        public void get_lowFrequencyMotorSpeed(){} // RVA: 0x7FFE82AB44F0
        public void set_lowFrequencyMotorSpeed(){} // RVA: 0x7FFE82D03BB0
        public void get_highFrequencyMotorSpeed(){} // RVA: 0x7FFE82D03B70
        public void set_highFrequencyMotorSpeed(){} // RVA: 0x7FFE82D03BD0
        public void get_isRumbling(){} // RVA: 0x7FFE87A1B4C0
        public void PauseHaptics(){} // RVA: 0x7FFE87A1B500
        public void ResumeHaptics(){} // RVA: 0x7FFE87A1B600
        public void ResetHaptics(){} // RVA: 0x7FFE87A1B6B0
        public void SetMotorSpeeds(){} // RVA: 0x7FFE87A1B760
    }

    public class IDualMotorRumble
    {
        // ── Methods ──
        public void SetMotorSpeeds(){}
    }

    public class IHaptics
    {
        // ── Methods ──
        public void PauseHaptics(){} // RVA: 0x7FFE80E45FE0
        public void ResumeHaptics(){} // RVA: 0x7FFE80E45FE0
        public void ResetHaptics(){} // RVA: 0x7FFE80E45FE0
    }

}