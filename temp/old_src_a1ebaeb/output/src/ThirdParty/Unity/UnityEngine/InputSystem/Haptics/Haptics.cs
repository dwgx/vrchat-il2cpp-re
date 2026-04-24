// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Haptics
// Classes: 3
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.InputSystem.Haptics
{
    public class DualMotorRumble : ValueType
    {
        // ── Original Methods ──
        public void get_lowFrequencyMotorSpeed(){} // RVA: 0x7ffaaa254060
        public void set_lowFrequencyMotorSpeed(){} // RVA: 0x7ffaaa49daf0
        public void get_highFrequencyMotorSpeed(){} // RVA: 0x7ffaaa49daa0
        public void set_highFrequencyMotorSpeed(){} // RVA: 0x7ffaaa49db00
        public void get_isRumbling(){} // RVA: 0x7ffaaf094d40
        public void PauseHaptics(){} // RVA: 0x7ffaaf094d80
        public void ResumeHaptics(){} // RVA: 0x7ffaaf094e80
        public void ResetHaptics(){} // RVA: 0x7ffaaf094f30
        // ── Binary Analysis Named ──
        public void SetMotorSpeeds(){} // RVA: 0x7ffaaf094fe0
    }

    public class IDualMotorRumble
    {
        // ── Binary Analysis Named ──
        public void SetMotorSpeeds(){}
    }

    public class IHaptics
    {
        // ── Original Methods ──
        public void PauseHaptics(){} // RVA: 0x7ffaa8660cc0
        public void ResumeHaptics(){} // RVA: 0x7ffaa8660cc0
        public void ResetHaptics(){} // RVA: 0x7ffaa8660cc0
    }

}