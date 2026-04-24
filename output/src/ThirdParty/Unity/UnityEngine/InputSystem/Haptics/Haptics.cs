// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Haptics
// Classes: 3
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.InputSystem.Haptics
{
    public class DualMotorRumble : ValueType
    {
        public object lowFrequencyMotorSpeed;
        public object highFrequencyMotorSpeed;
        public object isRumbling;

        // ── Methods ──
        public void get_lowFrequencyMotorSpeed(){} // RVA: 0x7FFD4FC6C150
        public void set_lowFrequencyMotorSpeed(){} // RVA: 0x7FFD4FEBB910
        public void get_highFrequencyMotorSpeed(){} // RVA: 0x7FFD4FEBB900
        public void set_highFrequencyMotorSpeed(){} // RVA: 0x7FFD4FEBB8F0
        public void get_isRumbling(){} // RVA: 0x7FFD54A92D60
        public void PauseHaptics(){} // RVA: 0x7FFD54A92DA0
        public void ResumeHaptics(){} // RVA: 0x7FFD54A92EA0
        public void ResetHaptics(){} // RVA: 0x7FFD54A92F50
        public void SetMotorSpeeds(){} // RVA: 0x7FFD54A93000
    }

    public class IDualMotorRumble
    {
        // ── Methods ──
        public void SetMotorSpeeds(){}
    }

    public class IHaptics
    {
        // ── Methods ──
        public void PauseHaptics(){} // RVA: 0x7FFD4E090980
        public void ResumeHaptics(){} // RVA: 0x7FFD4E090980
        public void ResetHaptics(){} // RVA: 0x7FFD4E090980
    }

}