// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Haptics
// Classes: 3
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.InputSystem.Haptics
{
    public class DualMotorRumble : ValueType
    {
        public float lowFrequencyMotorSpeed; // 0x10
        public float highFrequencyMotorSpeed; // 0x14

        // ── Methods ──
        public void get_lowFrequencyMotorSpeed(){} // RVA: 0x7FFAC484C150
        public void set_lowFrequencyMotorSpeed(){} // RVA: 0x7FFAC4A9B910
        public void get_highFrequencyMotorSpeed(){} // RVA: 0x7FFAC4A9B900
        public void set_highFrequencyMotorSpeed(){} // RVA: 0x7FFAC4A9B8F0
        public void get_isRumbling(){} // RVA: 0x7FFAC9672D60
        public void PauseHaptics(){} // RVA: 0x7FFAC9672DA0
        public void ResumeHaptics(){} // RVA: 0x7FFAC9672EA0
        public void ResetHaptics(){} // RVA: 0x7FFAC9672F50
        public void SetMotorSpeeds(){} // RVA: 0x7FFAC9673000
    }

    public class IDualMotorRumble
    {
        // ── Methods ──
        public void SetMotorSpeeds(){}
    }

    public class IHaptics
    {
        // ── Methods ──
        public void PauseHaptics(){} // RVA: 0x7FFAC2C70980
        public void ResumeHaptics(){} // RVA: 0x7FFAC2C70980
        public void ResetHaptics(){} // RVA: 0x7FFAC2C70980
    }

}