// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Configuration
// Classes: 10
// Methods: 22

namespace ThirdParty.Other.Unity.Services.Core.Configuration
{
    public class CloudProjectId
    {
        // ── Methods ──
        public void GetCloudProjectId(){} // RVA: 0x6F56770
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ConfigurationCollectionHelper
    {
        // ── Methods ──
        public void FillWith(){} // RVA: 0x6F56880 | overloaded x2
        public void SetOrCreateEntry(){} // RVA: 0x6F56BE0
    }

    public class ConfigurationEntry
    {
        public string m_Value; // 0x10
        public bool m_IsReadOnly; // 0x18

        // ── Methods ──
        public void get_Value(){} // RVA: 0x2F8380
        public void get_IsReadOnly(){} // RVA: 0x2F84E0
        public void .ctor(){} // RVA: 0x1AB41A0 | overloaded x2
        public void TrySetValue(){} // RVA: 0x6F56EC0
        public void op_Implicit(){} // RVA: 0x6F56F20 | overloaded x2
    }

    public class ConfigurationUtils
    {
        public Unity.Services.Core.Configuration.IConfigurationLoader <ConfigurationLoader>k__BackingField;

        // ── Methods ──
        public void get_ConfigurationLoader(){} // RVA: 0x6F56FC0
        public void .cctor(){} // RVA: 0x6F57020
    }

    public class ExternalUserId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IConfigurationLoader
    {
        // ── Methods ──
        public void GetConfigAsync(){} // RVA: 0xCD60
    }

    public class ProjectConfiguration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void GetString(){} // RVA: 0x6F57160
    }

    public class SerializableProjectConfiguration
    {
        public string[] MetricType; // 0x10

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x6F57270
    }

    public class StreamingAssetsConfigurationLoader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetConfigAsync(){} // RVA: 0x6F57390
    }

    public class StreamingAssetsUtils
    {
        // ── Methods ──
        public void GetFileTextFromStreamingAssetsAsync(){} // RVA: 0x6F57940
    }

}