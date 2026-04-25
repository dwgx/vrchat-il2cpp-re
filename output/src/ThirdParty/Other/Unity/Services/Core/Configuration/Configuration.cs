// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Configuration
// Classes: 10
// Methods: 22

namespace ThirdParty.Other.Unity.Services.Core.Configuration
{
    public class CloudProjectId : Object
    {
        // ── Methods ──
        public void GetCloudProjectId(){} // RVA: 0x7FFAC96EF090
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ConfigurationCollectionHelper : Object
    {
        // ── Methods ──
        public void FillWith(){} // RVA: 0x7FFAC96EF1A0 | overloaded x2
        public void SetOrCreateEntry(){} // RVA: 0x7FFAC96EF500
    }

    public class ConfigurationEntry : Object
    {
        public string Value; // 0x10
        public bool IsReadOnly; // 0x18

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F3C4E0
        public void .ctor(){} // RVA: 0x7FFAC45687E0 | overloaded x2
        public void TrySetValue(){} // RVA: 0x7FFAC96EF7E0
        public void op_Implicit(){} // RVA: 0x7FFAC96EF840 | overloaded x2
    }

    public class ConfigurationUtils : Object
    {
        public Unity.Services.Core.Configuration.IConfigurationLoader ConfigurationLoader;

        // ── Methods ──
        public void get_ConfigurationLoader(){} // RVA: 0x7FFAC96EF8E0
        public void .cctor(){} // RVA: 0x7FFAC96EF940
    }

    public class ExternalUserId : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IConfigurationLoader
    {
        // ── Methods ──
        public void GetConfigAsync(){} // RVA: 0x7FFAC2C58E90
    }

    public class ProjectConfiguration : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,Unity.Services.Core.Configuration.ConfigurationEntry> m_ConfigValues; // 0x10
        public Unity.Services.Core.Internal.Serialization.IJsonSerializer <Serializer>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void GetString(){} // RVA: 0x7FFAC96EFA80
    }

    public class SerializableProjectConfiguration : ValueType
    {
        public string[] Empty; // 0x10
        public Unity.Services.Core.Configuration.ConfigurationEntry[] Values; // 0x18

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFAC96EFB90
    }

    public class StreamingAssetsConfigurationLoader : Object
    {
        public Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetConfigAsync(){} // RVA: 0x7FFAC96EFCB0
    }

    public class StreamingAssetsUtils : Object
    {
        // ── Methods ──
        public void GetFileTextFromStreamingAssetsAsync(){} // RVA: 0x7FFAC96F0260
    }

}