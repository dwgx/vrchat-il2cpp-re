// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 2
// Methods: 12

namespace VRC.Core
{
    public class CaptchaArea : Object
    {
        // ── Methods ──
        public void GenerateCaptcha(){} // RVA: 0xA5B21A0
        public void SolveCaptcha(){} // RVA: 0xA5B2340
    }

    public class ConfigManager : Object
    {
        public object KEY_DISABLE_UPGRADE_ACCOUNT;
        public object _localConfig;
        public object _worldConfig;
        public object _remoteConfig;

        // ── Methods ──
        public void get_LocalConfig(){} // RVA: 0xA5D5100
        public void set_LocalConfig(){} // RVA: 0xA5D5140
        public void get_WorldConfig(){} // RVA: 0xA5D51E0
        public void set_WorldConfig(){} // RVA: 0xA5D5220
        public void get_RemoteConfig(){} // RVA: 0xA5D52C0
        public void set_RemoteConfig(){} // RVA: 0xA5D5300
        public void Initialize(){} // RVA: 0xA5D53A0
        public void WorldConfigIDChange(){} // RVA: 0xA5D5540
        public void AssignTestLocalConfig(){} // RVA: 0xA5D5640
        public void AssignTestRemoteConfig(){} // RVA: 0xA5D56D0
    }

}