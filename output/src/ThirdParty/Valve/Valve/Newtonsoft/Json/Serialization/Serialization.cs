// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Serialization
// Classes: 41
// Methods: 485

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Serialization
{
    public class CachedAttributeGetter`1 : Object
    {
        public Valve.Newtonsoft.Json.Utilities.ThreadSafeStore`2<object,T> TypeAttributeCache;

        // ── Methods ──
        public void GetAttribute(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class DefaultContractResolver : Object
    {
        public Valve.Newtonsoft.Json.Serialization.IContractResolver Instance;
        public Valve.Newtonsoft.Json.JsonConverter[] DefaultMembersSearchFlags; // 0x8
        public object SerializeCompilerGeneratedMembers; // 0x10
        public Valve.Newtonsoft.Json.Serialization.DefaultContractResolverState IgnoreSerializableInterface; // 0x18
        public Valve.Newtonsoft.Json.Serialization.DefaultContractResolverState IgnoreSerializableAttribute; // 0x10
        public bool NamingStrategy; // 0x18
        public 0x6B0D8780 <DefaultMembersSearchFlags>k__BackingField; // 0x1C
        public bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x20
        public bool <IgnoreSerializableInterface>k__BackingField; // 0x21
        public bool <IgnoreSerializableAttribute>k__BackingField; // 0x22
        public Valve.Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC9CD9110
        public void get_DefaultMembersSearchFlags(){} // RVA: 0x7FFAC44357F0
        public void set_DefaultMembersSearchFlags(){} // RVA: 0x7FFAC44474D0
        public void get_SerializeCompilerGeneratedMembers(){} // RVA: 0x7FFAC300F9D0
        public void get_IgnoreSerializableInterface(){} // RVA: 0x7FFAC322AD20
        public void get_IgnoreSerializableAttribute(){} // RVA: 0x7FFAC45F8AA0
        public void set_IgnoreSerializableAttribute(){} // RVA: 0x7FFAC3F5A420
        public void get_NamingStrategy(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFAC9CD9220 | overloaded x2
        public void GetState(){} // RVA: 0x7FFAC9CD92E0
        public void ResolveContract(){} // RVA: 0x7FFAC9CD9350
        public void GetSerializableMembers(){} // RVA: 0x7FFAC9CD97E0
        public void ShouldSerializeEntityMember(){} // RVA: 0x7FFAC9CDA250
        public void CreateObjectContract(){} // RVA: 0x7FFAC9CDA3D0
        public void GetExtensionDataMemberForType(){} // RVA: 0x7FFAC9CDAA40
        public void SetExtensionDataDelegates(){} // RVA: 0x7FFAC9CDAD10
        public void GetAttributeConstructor(){} // RVA: 0x7FFAC9CDB9B0
        public void GetParameterizedConstructor(){} // RVA: 0x7FFAC9CDBEA0
        public void CreateConstructorParameters(){} // RVA: 0x7FFAC9CDBFE0
        public void CreatePropertyFromConstructorParameter(){} // RVA: 0x7FFAC9CDC1C0
        public void ResolveContractConverter(){} // RVA: 0x7FFAC9CDC640
        public void GetDefaultCreator(){} // RVA: 0x7FFAC9CDC690
        public void InitializeContract(){} // RVA: 0x7FFAC9CDC710
        public void ResolveCallbackMethods(){} // RVA: 0x7FFAC9CDCA90
        public void GetCallbackMethodsForType(){} // RVA: 0x7FFAC9CDCE30
        public void ShouldSkipDeserialized(){} // RVA: 0x7FFAC2F21320
        public void ShouldSkipSerializing(){} // RVA: 0x7FFAC2F21320
        public void GetClassHierarchyForType(){} // RVA: 0x7FFAC9CDD740
        public void CreateDictionaryContract(){} // RVA: 0x7FFAC9CDD910
        public void CreateArrayContract(){} // RVA: 0x7FFAC9CDDFD0
        public void CreatePrimitiveContract(){} // RVA: 0x7FFAC9CDE370
        public void CreateLinqContract(){} // RVA: 0x7FFAC9CDE3F0
        public void CreateISerializableContract(){} // RVA: 0x7FFAC9CDE470
        public void CreateStringContract(){} // RVA: 0x7FFAC9CDE780
        public void CreateContract(){} // RVA: 0x7FFAC9CDE840
        public void IsJsonPrimitiveType(){} // RVA: 0x7FFAC9CDED70
        public void IsIConvertible(){} // RVA: 0x7FFAC9CDEE10
        public void CanConvertToString(){} // RVA: 0x7FFAC9CDEFF0
        public void IsValidCallback(){} // RVA: 0x7FFAC9CDF280
        public void GetClrTypeFullName(){} // RVA: 0x7FFAC9CDFA50
        public void CreateProperties(){} // RVA: 0x7FFAC9CDFC60
        public void CreateMemberValueProvider(){} // RVA: 0x7FFAC9CE01C0
        public void CreateProperty(){} // RVA: 0x7FFAC9CE02E0
        public void SetPropertySettingsFromAttributes(){} // RVA: 0x7FFAC9CE06A0
        public void CreateShouldSerializeTest(){} // RVA: 0x7FFAC9CE0E70
        public void SetIsSpecifiedActions(){} // RVA: 0x7FFAC9CE1120
        public void ResolvePropertyName(){} // RVA: 0x7FFAC9CE15A0
        public void ResolveDictionaryKey(){} // RVA: 0x7FFAC9CE15D0
        public void GetResolvedPropertyName(){} // RVA: 0x7FFAC9CE1620
        public void .cctor(){} // RVA: 0x7FFAC9CE1640
    }

    public class DefaultContractResolverState : Object
    {
        public System.Collections.Generic.Dictionary`2<Valve.Newtonsoft.Json.Serialization.ResolverContractKey,Valve.Newtonsoft.Json.Serialization.JsonContract> ContractCache; // 0x10
        public Valve.Newtonsoft.Json.Utilities.PropertyNameTable NameTable; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CD8FE0
    }

    public class DefaultReferenceResolver : Object
    {
        public int _referenceCount; // 0x10

        // ── Methods ──
        public void GetMappings(){} // RVA: 0x7FFAC9CE27D0
        public void ResolveReference(){} // RVA: 0x7FFAC9CE2AA0
        public void GetReference(){} // RVA: 0x7FFAC9CE2B60
        public void AddReference(){} // RVA: 0x7FFAC9CE2CA0
        public void IsReferenced(){} // RVA: 0x7FFAC9CE2D30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultSerializationBinder : SerializationBinder
    {
        public Valve.Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;
        public Valve.Newtonsoft.Json.Utilities.ThreadSafeStore`2<TypeNameKey,System.Type> _typeCache; // 0x10

        // ── Methods ──
        public void GetTypeFromTypeNameKey(){} // RVA: 0x7FFAC9CE2DF0
        public void BindToType(){} // RVA: 0x7FFAC9CE30C0
        public void .ctor(){} // RVA: 0x7FFAC9CE3300
        public void .cctor(){} // RVA: 0x7FFAC9CE34E0
    }

    public class ErrorContext : Object
    {
        public bool Traced; // 0x10
        public System.Exception Error; // 0x18
        public object OriginalObject; // 0x20
        public object Member; // 0x28
        public string Path; // 0x30
        public bool Handled; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8785160
        public void get_Traced(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Traced(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Error(){} // RVA: 0x7FFAC2F247C0
        public void set_Error(){} // RVA: 0x7FFAC2F87E80
        public void set_OriginalObject(){} // RVA: 0x7FFAC2F4F0D0
        public void set_Member(){} // RVA: 0x7FFAC2F22E90
        public void set_Path(){} // RVA: 0x7FFAC2F4F890
        public void get_Handled(){} // RVA: 0x7FFAC31D95D0
    }

    public class ErrorEventArgs : EventArgs
    {
        public object CurrentObject; // 0x10
        public Valve.Newtonsoft.Json.Serialization.ErrorContext ErrorContext; // 0x18

        // ── Methods ──
        public void set_CurrentObject(){} // RVA: 0x7FFAC2F22E30
        public void set_ErrorContext(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9CE3750
    }

    public class ExtensionDataGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AD0660
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class ExtensionDataSetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8788130
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
    }

    public class IAttributeProvider
    {
    }

    public class IContractResolver
    {
        // ── Methods ──
        public void ResolveContract(){} // RVA: 0x7FFAC2C58F40
    }

    public class IReferenceResolver
    {
        // ── Methods ──
        public void ResolveReference(){} // RVA: 0x7FFAC2C6A6F0
        public void GetReference(){} // RVA: 0x7FFAC2C6A6F0
        public void IsReferenced(){} // RVA: 0x7FFAC2C5D200
        public void AddReference(){} // RVA: 0x7FFAC2C7AF60
    }

    public class ITraceWriter
    {
        public object LevelFilter;

        // ── Methods ──
        public void get_LevelFilter(){} // RVA: 0x7FFAC2C59960
        public void Trace(){} // RVA: 0x7FFAC2C73960
    }

    public class IValueProvider
    {
        // ── Methods ──
        public void SetValue(){} // RVA: 0x7FFAC2C79B30
        public void GetValue(){} // RVA: 0x7FFAC2C58F40
    }

    public class JsonArrayContract : JsonContainerContract
    {
        public System.Type CollectionItemType; // 0xC0
        public bool IsMultidimensionalArray; // 0xC8
        public System.Type IsArray; // 0xD0
        public System.Type ShouldCreateWrapper; // 0xD8
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> CanDeserialize; // 0xE0
        public System.Func`1<object> ParameterizedCreator; // 0xE8
        public bool OverrideCreator; // 0xF0
        public bool HasParameterizedCreator; // 0xF1
        public bool HasParameterizedCreatorInternal; // 0xF2
        public System.Reflection.ConstructorInfo _parameterizedConstructor; // 0xF8
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _parameterizedCreator; // 0x100
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _overrideCreator; // 0x108
        public bool <HasParameterizedCreator>k__BackingField; // 0x110

        // ── Methods ──
        public void get_CollectionItemType(){} // RVA: 0x7FFAC2F8C120
        public void set_CollectionItemType(){} // RVA: 0x7FFAC2F8C130
        public void get_IsMultidimensionalArray(){} // RVA: 0x7FFAC3D2B010
        public void set_IsMultidimensionalArray(){} // RVA: 0x7FFAC3D23EE0
        public void get_IsArray(){} // RVA: 0x7FFAC2FA2AD0
        public void set_IsArray(){} // RVA: 0x7FFAC2FA2AE0
        public void get_ShouldCreateWrapper(){} // RVA: 0x7FFAC3E66790
        public void set_ShouldCreateWrapper(){} // RVA: 0x7FFAC3E62B70
        public void get_CanDeserialize(){} // RVA: 0x7FFAC3E634D0
        public void set_CanDeserialize(){} // RVA: 0x7FFAC3E62830
        public void get_ParameterizedCreator(){} // RVA: 0x7FFAC9CE3860
        public void get_OverrideCreator(){} // RVA: 0x7FFAC36D1F40
        public void set_OverrideCreator(){} // RVA: 0x7FFAC8785520
        public void get_HasParameterizedCreator(){} // RVA: 0x7FFAC31E7D90
        public void set_HasParameterizedCreator(){} // RVA: 0x7FFAC31E5C40
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x7FFAC9CE3950
        public void .ctor(){} // RVA: 0x7FFAC9CE3980
        public void CreateWrapper(){} // RVA: 0x7FFAC9CE4510
        public void CreateTemporaryCollection(){} // RVA: 0x7FFAC9CE4A60
    }

    public class JsonContainerContract : JsonContract
    {
        public Valve.Newtonsoft.Json.Serialization.JsonContract ItemContract; // 0x90
        public Valve.Newtonsoft.Json.Serialization.JsonContract FinalItemContract; // 0x98
        public Valve.Newtonsoft.Json.JsonConverter ItemConverter; // 0xA0
        public System.Nullable`1<bool> ItemIsReference; // 0xA8
        public System.Nullable`1<0x6B2453B0> ItemReferenceLoopHandling; // 0xAC
        public System.Nullable`1<0x6B2454B8> ItemTypeNameHandling; // 0xB4

        // ── Methods ──
        public void get_ItemContract(){} // RVA: 0x7FFAC32EF640
        public void set_ItemContract(){} // RVA: 0x7FFAC8787970
        public void get_FinalItemContract(){} // RVA: 0x7FFAC354DFB0
        public void get_ItemConverter(){} // RVA: 0x7FFAC3543900
        public void set_ItemConverter(){} // RVA: 0x7FFAC354E420
        public void get_ItemIsReference(){} // RVA: 0x7FFAC8787AF0
        public void set_ItemIsReference(){} // RVA: 0x7FFAC8787B00
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC8787B10
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC8787B20
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFAC8787B30
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFAC8787B40
        public void .ctor(){} // RVA: 0x7FFAC9CE4CF0
    }

    public class JsonContract : Object
    {
        public bool UnderlyingType; // 0x10
        public bool CreatedType; // 0x11
        public bool IsReference; // 0x12
        public System.Type Converter; // 0x18
        public 0x6B244F38 InternalConverter; // 0x20
        public 0x6B247090 OnDeserializedCallbacks; // 0x24
        public bool OnDeserializingCallbacks; // 0x28
        public bool OnSerializedCallbacks; // 0x29
        public bool OnSerializingCallbacks; // 0x2A
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Serialization.SerializationCallback> OnErrorCallbacks; // 0x30
        public System.Collections.Generic.IList`1<Valve.Newtonsoft.Json.Serialization.SerializationCallback> DefaultCreator; // 0x38
        public System.Collections.Generic.IList`1<Valve.Newtonsoft.Json.Serialization.SerializationCallback> DefaultCreatorNonPublic; // 0x40
        public System.Collections.Generic.IList`1<Valve.Newtonsoft.Json.Serialization.SerializationCallback> _onSerializingCallbacks; // 0x48
        public System.Collections.Generic.IList`1<Valve.Newtonsoft.Json.Serialization.SerializationErrorCallback> _onErrorCallbacks; // 0x50
        public System.Type _createdType; // 0x58
        public System.Type <UnderlyingType>k__BackingField; // 0x60
        public System.Nullable`1<bool> <IsReference>k__BackingField; // 0x68
        public Valve.Newtonsoft.Json.JsonConverter <Converter>k__BackingField; // 0x70
        public Valve.Newtonsoft.Json.JsonConverter <InternalConverter>k__BackingField; // 0x78
        public System.Func`1<object> <DefaultCreator>k__BackingField; // 0x80
        public bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

        // ── Methods ──
        public void get_UnderlyingType(){} // RVA: 0x7FFAC2FBF370
        public void set_UnderlyingType(){} // RVA: 0x7FFAC2FBF380
        public void get_CreatedType(){} // RVA: 0x7FFAC2FE9500
        public void set_CreatedType(){} // RVA: 0x7FFAC9CE4E40
        public void get_IsReference(){} // RVA: 0x7FFAC5FD9440
        public void set_IsReference(){} // RVA: 0x7FFAC5FD9450
        public void get_Converter(){} // RVA: 0x7FFAC2FE9590
        public void set_Converter(){} // RVA: 0x7FFAC2FE95A0
        public void get_InternalConverter(){} // RVA: 0x7FFAC30E5600
        public void set_InternalConverter(){} // RVA: 0x7FFAC30E06F0
        public void get_OnDeserializedCallbacks(){} // RVA: 0x7FFAC9CE4F10
        public void get_OnDeserializingCallbacks(){} // RVA: 0x7FFAC9CE4FD0
        public void get_OnSerializedCallbacks(){} // RVA: 0x7FFAC9CE5090
        public void get_OnSerializingCallbacks(){} // RVA: 0x7FFAC9CE5150
        public void get_OnErrorCallbacks(){} // RVA: 0x7FFAC9CE5210
        public void get_DefaultCreator(){} // RVA: 0x7FFAC32EF410
        public void set_DefaultCreator(){} // RVA: 0x7FFAC34D4AA0
        public void get_DefaultCreatorNonPublic(){} // RVA: 0x7FFAC3E003A0
        public void set_DefaultCreatorNonPublic(){} // RVA: 0x7FFAC3E0C170
        public void .ctor(){} // RVA: 0x7FFAC9CE52D0
        public void InvokeOnSerializing(){} // RVA: 0x7FFAC9CE5550
        public void InvokeOnSerialized(){} // RVA: 0x7FFAC9CE5750
        public void InvokeOnDeserializing(){} // RVA: 0x7FFAC9CE5950
        public void InvokeOnDeserialized(){} // RVA: 0x7FFAC9CE5B50
        public void InvokeOnError(){} // RVA: 0x7FFAC9CE5CD0
        public void CreateSerializationCallback(){} // RVA: 0x7FFAC9CE5EE0
        public void CreateSerializationErrorCallback(){} // RVA: 0x7FFAC9CE5FD0
    }

    public class JsonDictionaryContract : JsonContainerContract
    {
        public System.Func`2<string,string> DictionaryKeyResolver; // 0xC0
        public System.Type DictionaryKeyType; // 0xC8
        public System.Type DictionaryValueType; // 0xD0
        public Valve.Newtonsoft.Json.Serialization.JsonContract KeyContract; // 0xD8
        public System.Type ShouldCreateWrapper; // 0xE0
        public System.Type ParameterizedCreator; // 0xE8
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> OverrideCreator; // 0xF0
        public System.Func`1<object> HasParameterizedCreator; // 0xF8
        public bool HasParameterizedCreatorInternal; // 0x100
        public System.Reflection.ConstructorInfo _parameterizedConstructor; // 0x108
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _overrideCreator; // 0x110
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _parameterizedCreator; // 0x118
        public bool <HasParameterizedCreator>k__BackingField; // 0x120

        // ── Methods ──
        public void get_DictionaryKeyResolver(){} // RVA: 0x7FFAC2F8C120
        public void set_DictionaryKeyResolver(){} // RVA: 0x7FFAC2F8C130
        public void get_DictionaryKeyType(){} // RVA: 0x7FFAC3079460
        public void set_DictionaryKeyType(){} // RVA: 0x7FFAC3079470
        public void get_DictionaryValueType(){} // RVA: 0x7FFAC303E100
        public void set_DictionaryValueType(){} // RVA: 0x7FFAC303E110
        public void get_KeyContract(){} // RVA: 0x7FFAC3540F70
        public void set_KeyContract(){} // RVA: 0x7FFAC2FA28A0
        public void get_ShouldCreateWrapper(){} // RVA: 0x7FFAC3C8B9C0
        public void set_ShouldCreateWrapper(){} // RVA: 0x7FFAC3C8DFF0
        public void get_ParameterizedCreator(){} // RVA: 0x7FFAC9CE6350
        public void get_OverrideCreator(){} // RVA: 0x7FFAC354B170
        public void set_OverrideCreator(){} // RVA: 0x7FFAC39B3E10
        public void get_HasParameterizedCreator(){} // RVA: 0x7FFAC87898E0
        public void set_HasParameterizedCreator(){} // RVA: 0x7FFAC87898F0
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x7FFAC9CE6440
        public void .ctor(){} // RVA: 0x7FFAC9CE6470
        public void CreateWrapper(){} // RVA: 0x7FFAC9CE6CE0
        public void CreateTemporaryDictionary(){} // RVA: 0x7FFAC9CE70E0
    }

    public class JsonFormatterConverter : Object
    {
        public Valve.Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader; // 0x10
        public Valve.Newtonsoft.Json.Serialization.JsonISerializableContract _contract; // 0x18
        public Valve.Newtonsoft.Json.Serialization.JsonProperty _member; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CE73D0
        public void GetTokenValue(){} // RVA: 0x7FFAC2E8DC40
        public void Convert(){} // RVA: 0x7FFAC9CE75D0
        public void ToBoolean(){} // RVA: 0x7FFAC9CE7740
        public void ToByte(){} // RVA: 0x7FFAC9CE7790
        public void ToInt16(){} // RVA: 0x7FFAC9CE77E0
        public void ToInt32(){} // RVA: 0x7FFAC9CE7830
        public void ToInt64(){} // RVA: 0x7FFAC9CE7880
        public void ToSingle(){} // RVA: 0x7FFAC9CE78D0
        public void ToString(){} // RVA: 0x7FFAC9CE7920
        public void ToUInt32(){} // RVA: 0x7FFAC9CE7970
    }

    public class JsonISerializableContract : JsonContainerContract
    {
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> ISerializableCreator; // 0xC0

        // ── Methods ──
        public void get_ISerializableCreator(){} // RVA: 0x7FFAC2F8C120
        public void set_ISerializableCreator(){} // RVA: 0x7FFAC2F8C130
        public void .ctor(){} // RVA: 0x7FFAC9CE79C0
    }

    public class JsonLinqContract : JsonContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CE79E0
    }

    public class JsonObjectContract : JsonContainerContract
    {
        public 0x6B2451A0 MemberSerialization; // 0xC0
        public System.Nullable`1<0x6B245408> ItemRequired; // 0xC4
        public Valve.Newtonsoft.Json.Serialization.JsonPropertyCollection Properties; // 0xD0
        public Valve.Newtonsoft.Json.Serialization.ExtensionDataSetter CreatorParameters; // 0xD8
        public Valve.Newtonsoft.Json.Serialization.ExtensionDataGetter OverrideConstructor; // 0xE0
        public bool ParametrizedConstructor; // 0xE8
        public System.Nullable`1<bool> OverrideCreator; // 0xE9
        public System.Reflection.ConstructorInfo ParameterizedCreator; // 0xF0
        public System.Reflection.ConstructorInfo ExtensionDataSetter; // 0xF8
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> ExtensionDataGetter; // 0x100
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> ExtensionDataValueType; // 0x108
        public Valve.Newtonsoft.Json.Serialization.JsonPropertyCollection HasRequiredOrDefaultValueProperties; // 0x110
        public System.Type _extensionDataValueType; // 0x118

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFAC313B720
        public void set_MemberSerialization(){} // RVA: 0x7FFAC31434F0
        public void get_ItemRequired(){} // RVA: 0x7FFAC878C450
        public void set_ItemRequired(){} // RVA: 0x7FFAC878C460
        public void get_Properties(){} // RVA: 0x7FFAC303E100
        public void set_Properties(){} // RVA: 0x7FFAC303E110
        public void get_CreatorParameters(){} // RVA: 0x7FFAC9CE7A00
        public void set_OverrideConstructor(){} // RVA: 0x7FFAC9CE7AD0
        public void set_ParametrizedConstructor(){} // RVA: 0x7FFAC9CE7C20
        public void get_OverrideCreator(){} // RVA: 0x7FFAC34F6C80
        public void get_ParameterizedCreator(){} // RVA: 0x7FFAC36D1F40
        public void get_ExtensionDataSetter(){} // RVA: 0x7FFAC3540F70
        public void set_ExtensionDataSetter(){} // RVA: 0x7FFAC2FA28A0
        public void get_ExtensionDataGetter(){} // RVA: 0x7FFAC2FA2900
        public void set_ExtensionDataGetter(){} // RVA: 0x7FFAC2FA2910
        public void set_ExtensionDataValueType(){} // RVA: 0x7FFAC9CE7D70
        public void get_HasRequiredOrDefaultValueProperties(){} // RVA: 0x7FFAC9CE7E80
        public void .ctor(){} // RVA: 0x7FFAC9CE8150
        public void GetUninitializedObject(){} // RVA: 0x7FFAC9CE8230
    }

    public class JsonPrimitiveContract : JsonContract
    {
        public 0x6B245720 TypeCode; // 0x90
        public System.Collections.Generic.Dictionary`2<System.Type,0x6B244F38> ReadTypeMap;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC3220660
        public void set_TypeCode(){} // RVA: 0x7FFAC34D2750
        public void .ctor(){} // RVA: 0x7FFAC9CE8340
        public void .cctor(){} // RVA: 0x7FFAC9CE84A0
    }

    public class JsonProperty : Object
    {
        public System.Nullable`1<0x6B245408> PropertyContract; // 0x10
        public bool PropertyName; // 0x18
        public object DeclaringType; // 0x20
        public bool Order; // 0x28
        public string UnderlyingName; // 0x30
        public bool ValueProvider; // 0x38
        public System.Type AttributeProvider; // 0x40
        public Valve.Newtonsoft.Json.Serialization.JsonContract PropertyType; // 0x48
        public System.Type Converter; // 0x50
        public System.Nullable`1<int> MemberConverter; // 0x58
        public string Ignored; // 0x60
        public Valve.Newtonsoft.Json.Serialization.IValueProvider Readable; // 0x68
        public Valve.Newtonsoft.Json.Serialization.IAttributeProvider Writable; // 0x70
        public Valve.Newtonsoft.Json.JsonConverter HasMemberAttribute; // 0x78
        public Valve.Newtonsoft.Json.JsonConverter DefaultValue; // 0x80
        public bool Required; // 0x88
        public bool IsReference; // 0x89
        public bool NullValueHandling; // 0x8A
        public bool DefaultValueHandling; // 0x8B
        public System.Nullable`1<bool> ReferenceLoopHandling; // 0x8C
        public System.Nullable`1<0x6B2452A8> ObjectCreationHandling; // 0x90
        public System.Nullable`1<0x6B244598> TypeNameHandling; // 0x98
        public System.Nullable`1<0x6B2453B0> ShouldSerialize; // 0xA0
        public System.Nullable`1<0x6B245300> ShouldDeserialize; // 0xA8
        public System.Nullable`1<0x6B2454B8> GetIsSpecified; // 0xB0
        public System.Predicate`1<object> SetIsSpecified; // 0xB8
        public System.Predicate`1<object> ItemConverter; // 0xC0
        public System.Predicate`1<object> ItemIsReference; // 0xC8
        public System.Action`2<object,object> ItemTypeNameHandling; // 0xD0
        public Valve.Newtonsoft.Json.JsonConverter ItemReferenceLoopHandling; // 0xD8
        public System.Nullable`1<bool> <ItemIsReference>k__BackingField; // 0xE0
        public System.Nullable`1<0x6B2454B8> <ItemTypeNameHandling>k__BackingField; // 0xE4
        public System.Nullable`1<0x6B2453B0> <ItemReferenceLoopHandling>k__BackingField; // 0xEC

        // ── Methods ──
        public void get_PropertyContract(){} // RVA: 0x7FFAC2F9C730
        public void set_PropertyContract(){} // RVA: 0x7FFAC2F9C740
        public void get_PropertyName(){} // RVA: 0x7FFAC31D95E0
        public void set_PropertyName(){} // RVA: 0x7FFAC9CE8C80
        public void get_DeclaringType(){} // RVA: 0x7FFAC2FC20E0
        public void set_DeclaringType(){} // RVA: 0x7FFAC30794D0
        public void get_Order(){} // RVA: 0x7FFAC2FE9500
        public void set_Order(){} // RVA: 0x7FFAC4249140
        public void get_UnderlyingName(){} // RVA: 0x7FFAC2FBF370
        public void set_UnderlyingName(){} // RVA: 0x7FFAC2FBF380
        public void get_ValueProvider(){} // RVA: 0x7FFAC2F9CD50
        public void set_ValueProvider(){} // RVA: 0x7FFAC2F9CD60
        public void set_AttributeProvider(){} // RVA: 0x7FFAC2FE95A0
        public void get_PropertyType(){} // RVA: 0x7FFAC2F9E740
        public void set_PropertyType(){} // RVA: 0x7FFAC9CE8DB0
        public void get_Converter(){} // RVA: 0x7FFAC30E5600
        public void set_Converter(){} // RVA: 0x7FFAC30E06F0
        public void get_MemberConverter(){} // RVA: 0x7FFAC32EF410
        public void set_MemberConverter(){} // RVA: 0x7FFAC34D4AA0
        public void get_Ignored(){} // RVA: 0x7FFAC3E003A0
        public void set_Ignored(){} // RVA: 0x7FFAC3E0C170
        public void get_Readable(){} // RVA: 0x7FFAC3E04950
        public void set_Readable(){} // RVA: 0x7FFAC3E09570
        public void get_Writable(){} // RVA: 0x7FFAC8AC35F0
        public void set_Writable(){} // RVA: 0x7FFAC9688990
        public void get_HasMemberAttribute(){} // RVA: 0x7FFAC8AC3600
        public void set_HasMemberAttribute(){} // RVA: 0x7FFAC3E0BD50
        public void get_DefaultValue(){} // RVA: 0x7FFAC878D720
        public void set_DefaultValue(){} // RVA: 0x7FFAC878D730
        public void GetResolvedDefaultValue(){} // RVA: 0x7FFAC9CE8E10
        public void get_Required(){} // RVA: 0x7FFAC9CE8EA0
        public void get_IsReference(){} // RVA: 0x7FFAC60F8F70
        public void set_IsReference(){} // RVA: 0x7FFAC60F8F80
        public void get_NullValueHandling(){} // RVA: 0x7FFAC32EF640
        public void set_NullValueHandling(){} // RVA: 0x7FFAC3705AA0
        public void get_DefaultValueHandling(){} // RVA: 0x7FFAC354DFB0
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAC7E01AA0
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFAC3543900
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAC878D950
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFAC354B1A0
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAC45C9F60
        public void get_TypeNameHandling(){} // RVA: 0x7FFAC2F8C040
        public void set_TypeNameHandling(){} // RVA: 0x7FFAC45CA6B0
        public void get_ShouldSerialize(){} // RVA: 0x7FFAC2F8C0B0
        public void set_ShouldSerialize(){} // RVA: 0x7FFAC2F8C0C0
        public void get_ShouldDeserialize(){} // RVA: 0x7FFAC2F8C120
        public void get_GetIsSpecified(){} // RVA: 0x7FFAC3079460
        public void set_GetIsSpecified(){} // RVA: 0x7FFAC3079470
        public void get_SetIsSpecified(){} // RVA: 0x7FFAC303E100
        public void set_SetIsSpecified(){} // RVA: 0x7FFAC303E110
        public void ToString(){} // RVA: 0x7FFAC31D95E0
        public void get_ItemConverter(){} // RVA: 0x7FFAC3540F70
        public void set_ItemConverter(){} // RVA: 0x7FFAC2FA28A0
        public void get_ItemIsReference(){} // RVA: 0x7FFAC89B0460
        public void set_ItemIsReference(){} // RVA: 0x7FFAC89B0470
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFAC878D9F0
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFAC878DA00
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC9CE8F00
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC9CE8F10
        public void WritePropertyName(){} // RVA: 0x7FFAC9CE8F20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonPropertyCollection : KeyedCollection`2
    {
        public System.Type _type; // 0x30
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Serialization.JsonProperty> _list; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CE8F80
        public void GetKeyForItem(){} // RVA: 0x7FFAC8330240
        public void AddProperty(){} // RVA: 0x7FFAC9CE9220
        public void GetClosestMatchProperty(){} // RVA: 0x7FFAC9CE94A0
        public void TryGetValue(){} // RVA: 0x7FFAC9CE94F0
        public void GetProperty(){} // RVA: 0x7FFAC9CE9640
    }

    public class JsonSerializerInternalBase : Object
    {
        public Valve.Newtonsoft.Json.Serialization.ErrorContext DefaultReferenceMappings; // 0x10
        public Valve.Newtonsoft.Json.Utilities.BidirectionalDictionary`2<string,object> _mappings; // 0x18
        public Valve.Newtonsoft.Json.JsonSerializer Serializer; // 0x20
        public Valve.Newtonsoft.Json.Serialization.ITraceWriter TraceWriter; // 0x28
        public Valve.Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CE9880
        public void get_DefaultReferenceMappings(){} // RVA: 0x7FFAC9CE99D0
        public void GetErrorContext(){} // RVA: 0x7FFAC9CE9B30
        public void ClearErrorContext(){} // RVA: 0x7FFAC9CE9DA0
        public void IsErrorHandled(){} // RVA: 0x7FFAC9CE9E50
    }

    public class JsonSerializerInternalReader : JsonSerializerInternalBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CEA280
        public void GetContractSafe(){} // RVA: 0x7FFAC9CEA290
        public void Deserialize(){} // RVA: 0x7FFAC9CEA300
        public void GetInternalSerializer(){} // RVA: 0x7FFAC9CEA830
        public void CreateJToken(){} // RVA: 0x7FFAC9CEA9D0
        public void CreateJObject(){} // RVA: 0x7FFAC9CEACE0
        public void CreateValueInternal(){} // RVA: 0x7FFAC9CEB0C0
        public void CoerceEmptyStringToNull(){} // RVA: 0x7FFAC9CEB6A0
        public void GetExpectedDescription(){} // RVA: 0x7FFAC9CEB790
        public void GetConverter(){} // RVA: 0x7FFAC9CEB8A0
        public void CreateObject(){} // RVA: 0x7FFAC9CEB980
        public void ReadMetadataPropertiesToken(){} // RVA: 0x7FFAC9CEC6D0
        public void ReadMetadataProperties(){} // RVA: 0x7FFAC9CED230
        public void ResolveTypeName(){} // RVA: 0x7FFAC9CEDD30
        public void EnsureArrayContract(){} // RVA: 0x7FFAC9CEE2A0
        public void CreateList(){} // RVA: 0x7FFAC9CEE460
        public void HasNoDefinedType(){} // RVA: 0x7FFAC9CEED50
        public void EnsureType(){} // RVA: 0x7FFAC9CEEDF0
        public void SetPropertyValue(){} // RVA: 0x7FFAC9CEF140
        public void CalculatePropertyDetails(){} // RVA: 0x7FFAC9CEF530
        public void AddReference(){} // RVA: 0x7FFAC9CEFA60
        public void HasFlag(){} // RVA: 0x7FFAC84CAD10
        public void ShouldSetPropertyValue(){} // RVA: 0x7FFAC9CEFCF0
        public void CreateNewList(){} // RVA: 0x7FFAC9CEFE00
        public void CreateNewDictionary(){} // RVA: 0x7FFAC9CF0170
        public void OnDeserializing(){} // RVA: 0x7FFAC9CF0430
        public void OnDeserialized(){} // RVA: 0x7FFAC9CF0600
        public void PopulateDictionary(){} // RVA: 0x7FFAC9CF07D0
        public void PopulateMultidimensionalArray(){} // RVA: 0x7FFAC9CF15A0
        public void ThrowUnexpectedEndException(){} // RVA: 0x7FFAC9CF20B0
        public void PopulateList(){} // RVA: 0x7FFAC9CF21C0
        public void CreateISerializable(){} // RVA: 0x7FFAC9CF2A00
        public void CreateISerializableItem(){} // RVA: 0x7FFAC9CF32D0
        public void CreateObjectUsingCreatorWithParameters(){} // RVA: 0x7FFAC9CF3510
        public void DeserializeConvertable(){} // RVA: 0x7FFAC9CF4E40
        public void ResolvePropertyAndCreatorValues(){} // RVA: 0x7FFAC9CF52A0
        public void ReadForType(){} // RVA: 0x7FFAC9CF5F20
        public void CreateNewObject(){} // RVA: 0x7FFAC9CF6130
        public void PopulateObject(){} // RVA: 0x7FFAC9CF6410
        public void ShouldDeserialize(){} // RVA: 0x7FFAC9CF73B0
        public void CheckPropertyName(){} // RVA: 0x7FFAC9CF7590
        public void SetExtensionData(){} // RVA: 0x7FFAC9CF7750
        public void ReadExtensionDataValue(){} // RVA: 0x7FFAC9CF7880
        public void EndProcessProperty(){} // RVA: 0x7FFAC9CF7980
        public void SetPropertyPresence(){} // RVA: 0x7FFAC9CF7E20
        public void HandleError(){} // RVA: 0x7FFAC9CF7F60
    }

    public class JsonSerializerInternalWriter : JsonSerializerInternalBase
    {
        public System.Type _rootType; // 0x38
        public int _rootLevel; // 0x40
        public System.Collections.Generic.List`1<object> _serializeStack; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CF8090
        public void Serialize(){} // RVA: 0x7FFAC9CF8160
        public void GetInternalSerializer(){} // RVA: 0x7FFAC9CF8540
        public void GetContractSafe(){} // RVA: 0x7FFAC9CF86E0
        public void SerializePrimitive(){} // RVA: 0x7FFAC9CF8760
        public void SerializeValue(){} // RVA: 0x7FFAC9CF8A00
        public void ResolveIsReference(){} // RVA: 0x7FFAC9CF9190
        public void ShouldWriteReference(){} // RVA: 0x7FFAC9CF9220
        public void ShouldWriteProperty(){} // RVA: 0x7FFAC9CF93A0
        public void CheckForCircularReference(){} // RVA: 0x7FFAC9CF9480
        public void WriteReference(){} // RVA: 0x7FFAC9CF9980
        public void GetReference(){} // RVA: 0x7FFAC9CF9B90
        public void TryConvertToString(){} // RVA: 0x7FFAC9CF9CE0
        public void SerializeString(){} // RVA: 0x7FFAC9CF9FB0
        public void OnSerializing(){} // RVA: 0x7FFAC9CFA060
        public void OnSerialized(){} // RVA: 0x7FFAC9CFA1F0
        public void SerializeObject(){} // RVA: 0x7FFAC9CFA380
        public void CalculatePropertyValues(){} // RVA: 0x7FFAC9CFAF70
        public void WriteObjectStart(){} // RVA: 0x7FFAC9CFB830
        public void WriteReferenceIdProperty(){} // RVA: 0x7FFAC9CFBB20
        public void WriteTypeProperty(){} // RVA: 0x7FFAC9CFBCF0
        public void HasFlag(){} // RVA: 0x7FFAC84CAD10 | overloaded x3
        public void SerializeConvertable(){} // RVA: 0x7FFAC9CFBEF0
        public void SerializeList(){} // RVA: 0x7FFAC9CFC530
        public void SerializeMultidimensionalArray(){} // RVA: 0x7FFAC9CFCCC0 | overloaded x2
        public void WriteStartArray(){} // RVA: 0x7FFAC9CFD110
        public void SerializeISerializable(){} // RVA: 0x7FFAC9CFD540
        public void ShouldWriteType(){} // RVA: 0x7FFAC9CFDE20
        public void SerializeDictionary(){} // RVA: 0x7FFAC9CFDFB0
        public void GetPropertyName(){} // RVA: 0x7FFAC9CFE960
        public void HandleError(){} // RVA: 0x7FFAC9CFED40
        public void ShouldSerialize(){} // RVA: 0x7FFAC9CFEE90
        public void IsSpecified(){} // RVA: 0x7FFAC9CFF060
    }

    public class JsonSerializerProxy : JsonSerializer
    {
        public Valve.Newtonsoft.Json.Serialization.JsonSerializerInternalReader ReferenceResolver; // 0xE0
        public Valve.Newtonsoft.Json.Serialization.JsonSerializerInternalWriter TraceWriter; // 0xE8
        public Valve.Newtonsoft.Json.JsonSerializer EqualityComparer; // 0xF0

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFAC87A5F10
        public void remove_Error(){} // RVA: 0x7FFAC87A5F40
        public void set_ReferenceResolver(){} // RVA: 0x7FFAC9CFF230
        public void get_TraceWriter(){} // RVA: 0x7FFAC87A6540
        public void set_TraceWriter(){} // RVA: 0x7FFAC87A6570
        public void set_EqualityComparer(){} // RVA: 0x7FFAC9CFF260
        public void get_Converters(){} // RVA: 0x7FFAC87A6300
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAC87A6390
        public void get_ContractResolver(){} // RVA: 0x7FFAC9CFF290
        public void set_ContractResolver(){} // RVA: 0x7FFAC9CFF2C0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFAC87A6060
        public void set_NullValueHandling(){} // RVA: 0x7FFAC9CFF2F0
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAC9CFF320
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAC9CFF350
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFAC87A6000
        public void set_TypeNameHandling(){} // RVA: 0x7FFAC87A65D0
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFAC87A6480
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFAC87A64B0
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC9CFF380
        public void set_ConstructorHandling(){} // RVA: 0x7FFAC87A6450
        public void set_Binder(){} // RVA: 0x7FFAC87A5FA0
        public void get_Context(){} // RVA: 0x7FFAC9CFF3B0
        public void set_Context(){} // RVA: 0x7FFAC9CFF400
        public void get_Formatting(){} // RVA: 0x7FFAC9CFF440
        public void set_Formatting(){} // RVA: 0x7FFAC9CFF470
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFAC9CFF4A0
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFAC9CFF4D0
        public void GetInternalSerializer(){} // RVA: 0x7FFAC87A6AB0
        public void .ctor(){} // RVA: 0x7FFAC9CFF660 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7FFAC9CFF7C0
        public void SerializeInternal(){} // RVA: 0x7FFAC9CFF820
    }

    public class JsonStringContract : JsonPrimitiveContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CFF880
    }

    public class JsonTypeReflector : Object
    {
        public System.Nullable`1<bool> FullyTrusted;
        public Valve.Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,System.Func`2<object[],object>> ReflectionDelegateFactory; // 0x8
        public Valve.Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,System.Type> AssociatedMetadataTypesCache; // 0x10
        public Valve.Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

        // ── Methods ──
        public void GetCachedAttribute(){} // RVA: 0x7FFAC2E8DC40
        public void GetDataContractAttribute(){} // RVA: 0x7FFAC9CFF8F0
        public void GetDataMemberAttribute(){} // RVA: 0x7FFAC9CFF990
        public void GetObjectMemberSerialization(){} // RVA: 0x7FFAC9CFFC00
        public void GetJsonConverter(){} // RVA: 0x7FFAC9CFFD10
        public void CreateJsonConverterInstance(){} // RVA: 0x7FFAC9CFFE40
        public void CreateNamingStrategyInstance(){} // RVA: 0x7FFAC9CFFF40
        public void GetContainerNamingStrategy(){} // RVA: 0x7FFAC9D00040
        public void GetCreator(){} // RVA: 0x7FFAC9D00130
        public void GetTypeConverter(){} // RVA: 0x7FFAC9D00320
        public void GetAssociatedMetadataType(){} // RVA: 0x7FFAC9D00370
        public void GetAssociateMetadataTypeFromAttribute(){} // RVA: 0x7FFAC9D00400
        public void GetAttribute(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void get_FullyTrusted(){} // RVA: 0x7FFAC9D00700
        public void get_ReflectionDelegateFactory(){} // RVA: 0x7FFAC9D00890
        public void .cctor(){} // RVA: 0x7FFAC9D00930
    }

    public class NamingStrategy : Object
    {
        public bool ProcessDictionaryKeys; // 0x10
        public bool OverrideSpecifiedNames; // 0x11

        // ── Methods ──
        public void get_ProcessDictionaryKeys(){} // RVA: 0x7FFAC2FEB5E0
        public void get_OverrideSpecifiedNames(){} // RVA: 0x7FFAC3771DA0
        public void GetPropertyName(){} // RVA: 0x7FFAC9D010A0
        public void GetDictionaryKey(){} // RVA: 0x7FFAC9D010D0
        public void ResolvePropertyName(){} // RVA: 0x7FFAC2C58F40
    }

    public class ObjectConstructor`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2C58F40
    }

    public class OnErrorAttribute : Attribute
    {
    }

    public class ReflectionAttributeProvider : Object
    {
        public object _attributeProvider; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D010F0
    }

    public class ReflectionValueProvider : Object
    {
        public System.Reflection.MemberInfo _memberInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D011D0
        public void SetValue(){} // RVA: 0x7FFAC9D012B0
        public void GetValue(){} // RVA: 0x7FFAC9D01410
    }

    public class ResolverContractKey : ValueType
    {
        public System.Type _resolverType; // 0x10
        public System.Type _contractType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void GetHashCode(){} // RVA: 0x7FFAC90936F0
        public void Equals(){} // RVA: 0x7FFAC485CA30 | overloaded x2
    }

    public class SerializationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8787CD0
        public void Invoke(){} // RVA: 0x7FFAC5C4DBE0
    }

    public class SerializationErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8787EE0
        public void Invoke(){} // RVA: 0x7FFAC8788060
    }

    public class TraceJsonReader : JsonReader
    {
        public Valve.Newtonsoft.Json.JsonReader Depth; // 0x78
        public Valve.Newtonsoft.Json.JsonTextWriter Path; // 0x80
        public System.IO.StringWriter TokenType; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D01560
        public void GetDeserializedJsonMessage(){} // RVA: 0x7FFAC87AA280
        public void Read(){} // RVA: 0x7FFAC9D01820
        public void ReadAsInt32(){} // RVA: 0x7FFAC9D018A0
        public void ReadAsString(){} // RVA: 0x7FFAC9D01920
        public void ReadAsBytes(){} // RVA: 0x7FFAC9D019A0
        public void ReadAsDecimal(){} // RVA: 0x7FFAC9D01A20
        public void ReadAsDouble(){} // RVA: 0x7FFAC9D01AB0
        public void ReadAsBoolean(){} // RVA: 0x7FFAC9D01B30
        public void ReadAsDateTime(){} // RVA: 0x7FFAC9D01BB0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAC9D01C30
        public void get_Depth(){} // RVA: 0x7FFAC9D01CC0
        public void get_Path(){} // RVA: 0x7FFAC9D01CF0
        public void get_TokenType(){} // RVA: 0x7FFAC9D01D20
        public void get_Value(){} // RVA: 0x7FFAC9D01D50
        public void get_ValueType(){} // RVA: 0x7FFAC9D01D80
        public void Close(){} // RVA: 0x7FFAC873BD40
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFAC9D01DB0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFAC9D01E10
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFAC9D01E70
    }

    public class TraceJsonWriter : JsonWriter
    {
        public Valve.Newtonsoft.Json.JsonWriter _innerWriter; // 0x60
        public Valve.Newtonsoft.Json.JsonTextWriter _textWriter; // 0x68
        public System.IO.StringWriter _sw; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D01ED0
        public void GetSerializedJsonMessage(){} // RVA: 0x7FFAC87AAE00
        public void WriteValue(){} // RVA: 0x7FFAC9D02FA0 | overloaded x21
        public void WriteUndefined(){} // RVA: 0x7FFAC9D028D0
        public void WriteNull(){} // RVA: 0x7FFAC9D02940
        public void WriteComment(){} // RVA: 0x7FFAC9D03020
        public void WriteStartArray(){} // RVA: 0x7FFAC9D03090
        public void WriteEndArray(){} // RVA: 0x7FFAC9D030F0
        public void WriteStartConstructor(){} // RVA: 0x7FFAC9D03150
        public void WriteEndConstructor(){} // RVA: 0x7FFAC9D031C0
        public void WritePropertyName(){} // RVA: 0x7FFAC9D032F0 | overloaded x2
        public void WriteStartObject(){} // RVA: 0x7FFAC9D033D0
        public void WriteEndObject(){} // RVA: 0x7FFAC9D03430
        public void WriteRawValue(){} // RVA: 0x7FFAC9D03490
        public void WriteRaw(){} // RVA: 0x7FFAC9D03510
        public void Close(){} // RVA: 0x7FFAC9D03570
    }

}