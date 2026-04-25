// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 2
// Methods: 12

namespace VRC.Core
{
    public class CaptchaArea : Object
    {
        // ── Methods ──
        public void GenerateCaptcha(){} // RVA: 0x7FFACBF06660
        public void SolveCaptcha(){} // RVA: 0x7FFACBF06800
    }

    public class ConfigManager : Object
    {
        public string LocalConfig;
        public VRC.Core.Config.Interfaces.IReadWriteConfig WorldConfig;
        public VRC.Core.Config.Interfaces.IReadWriteConfig RemoteConfig; // 0x8
        public VRC.Core.Config.Interfaces.IReadOnlyConfig <RemoteConfig>k__BackingField; // 0x10

        // ── Methods ──
        public void get_LocalConfig(){} // RVA: 0x7FFACBF28D40
        public void set_LocalConfig(){} // RVA: 0x7FFACBF28D80
        public void get_WorldConfig(){} // RVA: 0x7FFACBF28E20
        public void set_WorldConfig(){} // RVA: 0x7FFACBF28E60
        public void get_RemoteConfig(){} // RVA: 0x7FFACBF28F00
        public void set_RemoteConfig(){} // RVA: 0x7FFACBF28F40
        public void Initialize(){} // RVA: 0x7FFACBF28FE0
        public void WorldConfigIDChange(){} // RVA: 0x7FFACBF29200
        public void AssignTestLocalConfig(){} // RVA: 0x7FFACBF29330
        public void AssignTestRemoteConfig(){} // RVA: 0x7FFACBF293C0
    }

}