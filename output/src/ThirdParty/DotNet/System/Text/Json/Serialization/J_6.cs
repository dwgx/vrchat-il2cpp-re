// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization
// Classes: 6
// Methods: 62

namespace ThirdParty.DotNet.System.Text.Json.Serialization
{
    public class JsonSerializerContext
    {
        public System.Nullable`1<bool> _canUseSerializationLogic; // 0x10
        public System.Text.Json.JsonSerializerOptions _options; // 0x18

        // ── Methods ──
        public void get_Options(){} // RVA: 0x63536C0
        public void get_CanUseSerializationLogic(){} // RVA: 0x63537E0
        public void get_GeneratedSerializerOptions(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x6353B30
        public void GetTypeInfo(){} // RVA: 0xCE10
    }

    public class JsonSerializerContext
    {
        public System.Text.Json.JsonSerializerOptions _options; // 0x10

        // ── Methods ──
        public void get_Options(){} // RVA: 0x68C5270
        public void AssociateWithOptions(){} // RVA: 0x68C5360
        public void System.Text.Json.Serialization.Metadata.IBuiltInJsonTypeInfoResolver.IsCompatibleWithOptions(){} // RVA: 0x68C5400
        public void get_GeneratedSerializerOptions(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x68C55E0
        public void GetTypeInfo(){} // RVA: 0xCE10
        public void System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver.GetTypeInfo(){} // RVA: 0x68C5660
    }

    public class JsonSourceGenerationOptionsAttribute
    {
        public bool <AllowTrailingCommas>k__BackingField; // 0x10
        public System.Type[] <Converters>k__BackingField; // 0x18
        public int <DefaultBufferSize>k__BackingField; // 0x20
        public 0x658F2FE8 <DefaultIgnoreCondition>k__BackingField; // 0x24
        public 0x658F3040 <DictionaryKeyPolicy>k__BackingField; // 0x28
        public bool <IgnoreReadOnlyFields>k__BackingField; // 0x2C
        public bool <IgnoreReadOnlyProperties>k__BackingField; // 0x2D
        public bool <IncludeFields>k__BackingField; // 0x2E
        public int <MaxDepth>k__BackingField; // 0x30
        public 0x658F3098 <NumberHandling>k__BackingField; // 0x34
        public 0x658F30F0 <PreferredObjectCreationHandling>k__BackingField; // 0x38
        public bool <PropertyNameCaseInsensitive>k__BackingField; // 0x3C
        public 0x658F3040 <PropertyNamingPolicy>k__BackingField; // 0x40
        public 0x658F0D30 <ReadCommentHandling>k__BackingField; // 0x44
        public 0x658F32A8 <UnknownTypeHandling>k__BackingField; // 0x48
        public 0x658F3148 <UnmappedMemberHandling>k__BackingField; // 0x4C
        public bool <WriteIndented>k__BackingField; // 0x50
        public 0x658F31F8 <GenerationMode>k__BackingField; // 0x54
        public bool <UseStringEnumConverter>k__BackingField; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68C4A40 | overloaded x2
        public void get_AllowTrailingCommas(){} // RVA: 0x3A75E0
        public void set_AllowTrailingCommas(){} // RVA: 0x3A75F0
        public void get_Converters(){} // RVA: 0x2E07C0
        public void set_Converters(){} // RVA: 0x343E80
        public void get_DefaultBufferSize(){} // RVA: 0x760030
        public void set_DefaultBufferSize(){} // RVA: 0x99E0D0
        public void get_DefaultIgnoreCondition(){} // RVA: 0xCEF5B0
        public void set_DefaultIgnoreCondition(){} // RVA: 0x16E1F00
        public void get_DictionaryKeyPolicy(){} // RVA: 0x791DC0
        public void set_DictionaryKeyPolicy(){} // RVA: 0xA53440
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x3BC230
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x3BC240
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x4FDE20
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x4FC950
        public void get_IncludeFields(){} // RVA: 0x4FB980
        public void set_IncludeFields(){} // RVA: 0x4FB0C0
        public void get_MaxDepth(){} // RVA: 0x338CD0
        public void set_MaxDepth(){} // RVA: 0x338CE0
        public void get_NumberHandling(){} // RVA: 0x4C6670
        public void set_NumberHandling(){} // RVA: 0x4C5F20
        public void get_PreferredObjectCreationHandling(){} // RVA: 0xFDC9F0
        public void set_PreferredObjectCreationHandling(){} // RVA: 0xFDD6E0
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x4424E0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x4424F0
        public void get_PropertyNamingPolicy(){} // RVA: 0x37E080
        public void set_PropertyNamingPolicy(){} // RVA: 0x37E090
        public void get_ReadCommentHandling(){} // RVA: 0x1AF8C70
        public void set_ReadCommentHandling(){} // RVA: 0x1AF8C60
        public void get_UnknownTypeHandling(){} // RVA: 0x37E0C0
        public void set_UnknownTypeHandling(){} // RVA: 0x37E0D0
        public void get_UnmappedMemberHandling(){} // RVA: 0x1479960
        public void set_UnmappedMemberHandling(){} // RVA: 0x1D75D90
        public void get_WriteIndented(){} // RVA: 0x3978E0
        public void set_WriteIndented(){} // RVA: 0x3978F0
        public void get_GenerationMode(){} // RVA: 0xC5BE80
        public void set_GenerationMode(){} // RVA: 0xC5BE70
        public void get_UseStringEnumConverter(){} // RVA: 0x59FF30
        public void set_UseStringEnumConverter(){} // RVA: 0xC5F680
    }

    public class JsonStringEnumConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x372F7C0 | overloaded x2
        public void CanConvert(){} // RVA: 0x2E76B90
        public void CreateConverter(){} // RVA: 0x68C7250
    }

    public class JsonStringEnumConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2A620 | overloaded x2
        public void CanConvert(){} // RVA: 0xDE40
        public void CreateConverter(){} // RVA: 0x1E6A0
    }

    public class JsonUnmappedMemberHandlingAttribute
    {
        public 0x658F3148 <UnmappedMemberHandling>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_UnmappedMemberHandling(){} // RVA: 0x32A5C0
    }

}