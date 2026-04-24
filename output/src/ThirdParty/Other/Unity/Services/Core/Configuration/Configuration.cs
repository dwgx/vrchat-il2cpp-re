// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Configuration
// Classes: 10
// Methods: 22

namespace ThirdParty.Other.Unity.Services.Core.Configuration
{
    public class CloudProjectId : Object
    {
        // ── Methods ──
        public void GetCloudProjectId(){} // RVA: 0x7FFD54B0F090
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ConfigurationCollectionHelper : Object
    {
        // ── Methods ──
        public void FillWith(){} // RVA: 0x7FFD54B0F1A0 | overloaded x2
        public void SetOrCreateEntry(){} // RVA: 0x7FFD54B0F500
    }

    public class ConfigurationEntry : Object
    {
        public object Value;
        public object IsReadOnly;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E35C380
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E35C4E0
        public void .ctor(){} // RVA: 0x7FFD4F9887E0 | overloaded x2
        public void TrySetValue(){} // RVA: 0x7FFD54B0F7E0
        public void op_Implicit(){} // RVA: 0x7FFD54B0F840 | overloaded x2
    }

    public class ConfigurationUtils : Object
    {
        public object ConfigurationLoader;

        // ── Methods ──
        public void get_ConfigurationLoader(){} // RVA: 0x7FFD54B0F8E0
        public void .cctor(){} // RVA: 0x7FFD54B0F940
    }

    public class ExternalUserId : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class IConfigurationLoader
    {
        // ── Methods ──
        public void GetConfigAsync(){} // RVA: 0x7FFD4E078E90
    }

    public class ProjectConfiguration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void GetString(){} // RVA: 0x7FFD54B0FA80
    }

    public class SerializableProjectConfiguration : ValueType
    {
        public object Empty;

        // ── Methods ──
        public void get_Empty(){} // RVA: 0x7FFD54B0FB90
    }

    public class StreamingAssetsConfigurationLoader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void GetConfigAsync(){} // RVA: 0x7FFD54B0FCB0
    }

    public class StreamingAssetsUtils : Object
    {
        // ── Methods ──
        public void GetFileTextFromStreamingAssetsAsync(){} // RVA: 0x7FFD54B10260
    }

}