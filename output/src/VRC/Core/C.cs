// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 2
// Methods: 12

namespace VRC.Core
{
    public class CaptchaArea : Object
    {
        // ── Methods ──
        public void GenerateCaptcha(){} // RVA: 0x7FFE8A366D60
        public void SolveCaptcha(){} // RVA: 0x7FFE8A366F00
    }

    public class ConfigManager : Object
    {
        public string KEY_DISABLE_UPGRADE_ACCOUNT;
        public VRC.Core.Config.Interfaces.IReadWriteConfig _localConfig;
        public VRC.Core.Config.Interfaces.IReadWriteConfig _worldConfig; // 0x8

        // ── Methods ──
        public void get_LocalConfig(){} // RVA: 0x7FFE8A3894B0
        public void set_LocalConfig(){} // RVA: 0x7FFE8A3894F0
        public void get_WorldConfig(){} // RVA: 0x7FFE8A389590
        public void set_WorldConfig(){} // RVA: 0x7FFE8A3895D0
        public void get_RemoteConfig(){} // RVA: 0x7FFE8A389670
        public void set_RemoteConfig(){} // RVA: 0x7FFE8A3896B0
        public void Initialize(){} // RVA: 0x7FFE8A389750
        public void WorldConfigIDChange(){} // RVA: 0x7FFE8A389970
        public void AssignTestLocalConfig(){} // RVA: 0x7FFE8A389AA0
        public void AssignTestRemoteConfig(){} // RVA: 0x7FFE8A389B30
    }

}