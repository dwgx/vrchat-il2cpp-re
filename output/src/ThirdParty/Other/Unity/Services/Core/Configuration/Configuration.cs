// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Configuration
// Classes: 10
// Methods: 22

namespace ThirdParty.Other.Unity.Services.Core.Configuration
{
    public class CloudProjectId : Object
    {
        // ── Methods ──
        public void GetCloudProjectId(){} // RVA: 0x7FFE87A97600
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ConfigurationCollectionHelper : Object
    {
        // ── Methods ──
        public void FillWith(){} // RVA: 0x7FFE87A97710 | overloaded x2
        public void SetOrCreateEntry(){} // RVA: 0x7FFE87A97A70
    }

    public class ConfigurationEntry : Object
    {
        public string m_Value; // 0x10
        public bool m_IsReadOnly; // 0x18

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void get_IsReadOnly(){} // RVA: 0x7FFE811164E0
        public void .ctor(){} // RVA: 0x7FFE828378F0 | overloaded x2
        public void TrySetValue(){} // RVA: 0x7FFE87A97D50
        public void op_Implicit(){} // RVA: 0x7FFE87A97DB0 | overloaded x2
    }

    public class ConfigurationUtils : Object
    {
        public Unity.Services.Core.Configuration.IConfigurationLoader _configurationLoader;

        // ── Methods ──
        public void get_ConfigurationLoader(){} // RVA: 0x7FFE87A97E50
        public void .cctor(){} // RVA: 0x7FFE87A97EB0
    }

    public class ExternalUserId : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IConfigurationLoader
    {
        // ── Methods ──
        public void GetConfigAsync(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ProjectConfiguration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void GetString(){} // RVA: 0x7FFE87A97FF0
    }

    public class SerializableProjectConfiguration : ValueType
    {
        public string[] Keys; // 0x10

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFE87A98100
    }

    public class StreamingAssetsConfigurationLoader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetConfigAsync(){} // RVA: 0x7FFE87A98220
    }

    public class StreamingAssetsUtils : Object
    {
        // ── Methods ──
        public void GetFileTextFromStreamingAssetsAsync(){} // RVA: 0x7FFE87A987D0
    }

}