// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Serialization
// Classes: 49
// Methods: 641

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Serialization
{
    public class CachedAttributeGetter`1 : Object
    {
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<object,T> TypeAttributeCache;

        // ── Methods ──
        public void GetAttribute(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class CamelCaseNamingStrategy : NamingStrategy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void ResolvePropertyName(){} // RVA: 0x7FFAC87785C0
    }

    public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
    {
        public object TypeContractCacheLock;
        public Newtonsoft.Json.DefaultJsonNameTable NameTable; // 0x8
        public System.Collections.Generic.Dictionary`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,System.Type>,Newtonsoft.Json.Serialization.JsonContract> _contractCache; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87785D0
        public void ResolveContract(){} // RVA: 0x7FFAC87786A0
        public void GetNameTable(){} // RVA: 0x7FFAC8778C60
        public void .cctor(){} // RVA: 0x7FFAC8778CC0
    }

    public class DefaultContractResolver : Object
    {
        public Newtonsoft.Json.Serialization.IContractResolver Instance;
        public string[] DynamicCodeGeneration; // 0x8
        public Newtonsoft.Json.JsonConverter[] DefaultMembersSearchFlags; // 0x10
        public Newtonsoft.Json.DefaultJsonNameTable SerializeCompilerGeneratedMembers; // 0x10
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,Newtonsoft.Json.Serialization.JsonContract> IgnoreSerializableInterface; // 0x18
        public 0x6B0D8780 IgnoreSerializableAttribute; // 0x20
        public bool IgnoreIsSpecifiedMembers; // 0x24
        public bool IgnoreShouldSerializeMembers; // 0x25
        public bool NamingStrategy; // 0x26
        public bool <IgnoreIsSpecifiedMembers>k__BackingField; // 0x27
        public bool <IgnoreShouldSerializeMembers>k__BackingField; // 0x28
        public Newtonsoft.Json.Serialization.NamingStrategy <NamingStrategy>k__BackingField; // 0x30

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8778E20
        public void get_DynamicCodeGeneration(){} // RVA: 0x7FFAC8778E80
        public void get_DefaultMembersSearchFlags(){} // RVA: 0x7FFAC30DBBE0
        public void set_DefaultMembersSearchFlags(){} // RVA: 0x7FFAC35DB7A0
        public void get_SerializeCompilerGeneratedMembers(){} // RVA: 0x7FFAC2F3C7C0
        public void set_SerializeCompilerGeneratedMembers(){} // RVA: 0x7FFAC4422FB0
        public void get_IgnoreSerializableInterface(){} // RVA: 0x7FFAC3FA0EA0
        public void set_IgnoreSerializableInterface(){} // RVA: 0x7FFAC470CC50
        public void get_IgnoreSerializableAttribute(){} // RVA: 0x7FFAC3FA0EB0
        public void set_IgnoreSerializableAttribute(){} // RVA: 0x7FFAC3FA0EC0
        public void get_IgnoreIsSpecifiedMembers(){} // RVA: 0x7FFAC4422FC0
        public void set_IgnoreIsSpecifiedMembers(){} // RVA: 0x7FFAC8778FB0
        public void get_IgnoreShouldSerializeMembers(){} // RVA: 0x7FFAC30F6BA0
        public void set_IgnoreShouldSerializeMembers(){} // RVA: 0x7FFAC3C24F40
        public void get_NamingStrategy(){} // RVA: 0x7FFAC31D95E0
        public void set_NamingStrategy(){} // RVA: 0x7FFAC2F4F890
        public void .ctor(){} // RVA: 0x7FFAC8778FC0
        public void ResolveContract(){} // RVA: 0x7FFAC8779170
        public void FilterMembers(){} // RVA: 0x7FFAC8779250
        public void GetSerializableMembers(){} // RVA: 0x7FFAC8779400
        public void ShouldSerializeEntityMember(){} // RVA: 0x7FFAC877A160
        public void CreateObjectContract(){} // RVA: 0x7FFAC877A2E0
        public void ThrowUnableToSerializeError(){} // RVA: 0x7FFAC877AB50
        public void GetExtensionDataMemberForType(){} // RVA: 0x7FFAC877ABF0
        public void SetExtensionDataDelegates(){} // RVA: 0x7FFAC877AEC0
        public void GetAttributeConstructor(){} // RVA: 0x7FFAC877BC80
        public void GetImmutableConstructor(){} // RVA: 0x7FFAC877C130
        public void GetParameterizedConstructor(){} // RVA: 0x7FFAC877C380
        public void CreateConstructorParameters(){} // RVA: 0x7FFAC877C3D0
        public void MatchProperty(){} // RVA: 0x7FFAC877C5B0
        public void CreatePropertyFromConstructorParameter(){} // RVA: 0x7FFAC877C670
        public void ResolveContractConverter(){} // RVA: 0x7FFAC877CA30
        public void GetDefaultCreator(){} // RVA: 0x7FFAC877CA80
        public void InitializeContract(){} // RVA: 0x7FFAC877CB00
        public void ResolveCallbackMethods(){} // RVA: 0x7FFAC877CEA0
        public void GetCallbackMethodsForType(){} // RVA: 0x7FFAC877D240
        public void IsConcurrentOrObservableCollection(){} // RVA: 0x7FFAC877DDC0
        public void ShouldSkipDeserialized(){} // RVA: 0x7FFAC877DFE0
        public void ShouldSkipSerializing(){} // RVA: 0x7FFAC877E120
        public void GetClassHierarchyForType(){} // RVA: 0x7FFAC877E260
        public void CreateDictionaryContract(){} // RVA: 0x7FFAC877E440
        public void CreateArrayContract(){} // RVA: 0x7FFAC877EBA0
        public void CreatePrimitiveContract(){} // RVA: 0x7FFAC877EFB0
        public void CreateLinqContract(){} // RVA: 0x7FFAC877F030
        public void CreateISerializableContract(){} // RVA: 0x7FFAC877F0B0
        public void CreateDynamicContract(){} // RVA: 0x7FFAC877F390
        public void CreateStringContract(){} // RVA: 0x7FFAC877F6F0
        public void CreateContract(){} // RVA: 0x7FFAC877F7B0
        public void IsJsonPrimitiveType(){} // RVA: 0x7FFAC877FE60
        public void IsIConvertible(){} // RVA: 0x7FFAC877FF00
        public void CanConvertToString(){} // RVA: 0x7FFAC87800E0
        public void IsValidCallback(){} // RVA: 0x7FFAC8780200
        public void GetClrTypeFullName(){} // RVA: 0x7FFAC87809F0
        public void CreateProperties(){} // RVA: 0x7FFAC8780B20
        public void GetNameTable(){} // RVA: 0x7FFAC2F3C380
        public void CreateMemberValueProvider(){} // RVA: 0x7FFAC87810B0
        public void CreateProperty(){} // RVA: 0x7FFAC87811D0
        public void SetPropertySettingsFromAttributes(){} // RVA: 0x7FFAC8781550
        public void CreateShouldSerializeTest(){} // RVA: 0x7FFAC8781DC0
        public void SetIsSpecifiedActions(){} // RVA: 0x7FFAC8782070
        public void ResolvePropertyName(){} // RVA: 0x7FFAC8782490
        public void ResolveExtensionDataName(){} // RVA: 0x7FFAC87824C0
        public void ResolveDictionaryKey(){} // RVA: 0x7FFAC87824F0
        public void GetResolvedPropertyName(){} // RVA: 0x7FFAC8782540
        public void .cctor(){} // RVA: 0x7FFAC8782560
    }

    public class DefaultNamingStrategy : NamingStrategy
    {
        // ── Methods ──
        public void ResolvePropertyName(){} // RVA: 0x7FFAC3E92FB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultReferenceResolver : Object
    {
        public int _referenceCount; // 0x10

        // ── Methods ──
        public void GetMappings(){} // RVA: 0x7FFAC8783970
        public void ResolveReference(){} // RVA: 0x7FFAC8783BF0
        public void GetReference(){} // RVA: 0x7FFAC8783CB0
        public void AddReference(){} // RVA: 0x7FFAC8783E00
        public void IsReferenced(){} // RVA: 0x7FFAC8783E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultSerializationBinder : SerializationBinder
    {
        public Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type> _typeCache; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8783F50
        public void GetTypeFromTypeNameKey(){} // RVA: 0x7FFAC8784060
        public void GetGenericTypeFromTypeName(){} // RVA: 0x7FFAC87844C0
        public void GetTypeByName(){} // RVA: 0x7FFAC8784750
        public void BindToType(){} // RVA: 0x7FFAC87847D0
        public void BindToName(){} // RVA: 0x7FFAC87848B0
        public void .cctor(){} // RVA: 0x7FFAC87849F0
    }

    public class DiagnosticsTraceWriter : Object
    {
        public 0x6B130A40 LevelFilter; // 0x10

        // ── Methods ──
        public void get_LevelFilter(){} // RVA: 0x7FFAC2F6E5C0
        public void set_LevelFilter(){} // RVA: 0x7FFAC2F240C0
        public void GetTraceEventType(){} // RVA: 0x7FFAC8784BA0
        public void Trace(){} // RVA: 0x7FFAC8784C40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void get_OriginalObject(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Member(){} // RVA: 0x7FFAC2F4F130
        public void get_Path(){} // RVA: 0x7FFAC31D95E0
        public void get_Handled(){} // RVA: 0x7FFAC31D95D0
        public void set_Handled(){} // RVA: 0x7FFAC31D95C0
    }

    public class ErrorEventArgs : EventArgs
    {
        public object CurrentObject; // 0x10
        public Newtonsoft.Json.Serialization.ErrorContext ErrorContext; // 0x18

        // ── Methods ──
        public void get_CurrentObject(){} // RVA: 0x7FFAC2F3C380
        public void get_ErrorContext(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC87852B0
    }

    public class ExtensionDataGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AD0660
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class ExtensionDataSetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8788130
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC3C20DC0
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class IAttributeProvider
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFAC2C696F0 | overloaded x2
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

    public class ISerializationBinder
    {
        // ── Methods ──
        public void BindToType(){} // RVA: 0x7FFAC2C6A6F0
        public void BindToName(){} // RVA: 0x7FFAC2C7AF60
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
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> CanDeserialize; // 0xE0
        public System.Func`1<object> ParameterizedCreator; // 0xE8
        public bool OverrideCreator; // 0xF0
        public bool HasParameterizedCreator; // 0xF1
        public bool HasParameterizedCreatorInternal; // 0xF2
        public System.Reflection.ConstructorInfo _parameterizedConstructor; // 0xF8
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _parameterizedCreator; // 0x100
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _overrideCreator; // 0x108
        public bool <HasParameterizedCreator>k__BackingField; // 0x110

        // ── Methods ──
        public void get_CollectionItemType(){} // RVA: 0x7FFAC2F8C120
        public void get_IsMultidimensionalArray(){} // RVA: 0x7FFAC3D2B010
        public void get_IsArray(){} // RVA: 0x7FFAC2FA2AD0
        public void get_ShouldCreateWrapper(){} // RVA: 0x7FFAC3E66790
        public void get_CanDeserialize(){} // RVA: 0x7FFAC3E634D0
        public void set_CanDeserialize(){} // RVA: 0x7FFAC3E62830
        public void get_ParameterizedCreator(){} // RVA: 0x7FFAC87853C0
        public void get_OverrideCreator(){} // RVA: 0x7FFAC36D1F40
        public void set_OverrideCreator(){} // RVA: 0x7FFAC8785520
        public void get_HasParameterizedCreator(){} // RVA: 0x7FFAC31E7D90
        public void set_HasParameterizedCreator(){} // RVA: 0x7FFAC31E5C40
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x7FFAC8785590
        public void .ctor(){} // RVA: 0x7FFAC8785640
        public void CreateWrapper(){} // RVA: 0x7FFAC8786F00
        public void CreateTemporaryCollection(){} // RVA: 0x7FFAC8787450
        public void StoreFSharpListCreatorIfNecessary(){} // RVA: 0x7FFAC87876F0
    }

    public class JsonContainerContract : JsonContract
    {
        public Newtonsoft.Json.Serialization.JsonContract ItemContract; // 0x90
        public Newtonsoft.Json.Serialization.JsonContract FinalItemContract; // 0x98
        public Newtonsoft.Json.JsonConverter ItemConverter; // 0xA0
        public System.Nullable`1<bool> ItemIsReference; // 0xA8
        public System.Nullable`1<0x6B1C5A80> ItemReferenceLoopHandling; // 0xAC
        public System.Nullable`1<0x6B1C5BE0> ItemTypeNameHandling; // 0xB4

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
        public void .ctor(){} // RVA: 0x7FFAC8787B50
    }

    public class JsonContract : Object
    {
        public bool UnderlyingType; // 0x10
        public bool CreatedType; // 0x11
        public bool IsReference; // 0x12
        public System.Type Converter; // 0x18
        public 0x6B1C4B08 InternalConverter; // 0x20
        public 0x6B1C8A48 OnDeserializedCallbacks; // 0x24
        public bool OnDeserializingCallbacks; // 0x28
        public bool OnSerializedCallbacks; // 0x29
        public bool OnSerializingCallbacks; // 0x2A
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.SerializationCallback> OnErrorCallbacks; // 0x30
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.SerializationCallback> DefaultCreator; // 0x38
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.SerializationCallback> DefaultCreatorNonPublic; // 0x40
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializingCallbacks; // 0x48
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.SerializationErrorCallback> _onErrorCallbacks; // 0x50
        public System.Type _createdType; // 0x58
        public System.Type <UnderlyingType>k__BackingField; // 0x60
        public System.Nullable`1<bool> <IsReference>k__BackingField; // 0x68
        public Newtonsoft.Json.JsonConverter <Converter>k__BackingField; // 0x70
        public Newtonsoft.Json.JsonConverter <InternalConverter>k__BackingField; // 0x78
        public System.Func`1<object> <DefaultCreator>k__BackingField; // 0x80
        public bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

        // ── Methods ──
        public void get_UnderlyingType(){} // RVA: 0x7FFAC2FBF370
        public void get_CreatedType(){} // RVA: 0x7FFAC2FE9500
        public void set_CreatedType(){} // RVA: 0x7FFAC87882B0
        public void get_IsReference(){} // RVA: 0x7FFAC5FD9440
        public void set_IsReference(){} // RVA: 0x7FFAC5FD9450
        public void get_Converter(){} // RVA: 0x7FFAC2FE9590
        public void set_Converter(){} // RVA: 0x7FFAC2FE95A0
        public void get_InternalConverter(){} // RVA: 0x7FFAC30E5600
        public void set_InternalConverter(){} // RVA: 0x7FFAC30E06F0
        public void get_OnDeserializedCallbacks(){} // RVA: 0x7FFAC8788420
        public void get_OnDeserializingCallbacks(){} // RVA: 0x7FFAC87884E0
        public void get_OnSerializedCallbacks(){} // RVA: 0x7FFAC87885A0
        public void get_OnSerializingCallbacks(){} // RVA: 0x7FFAC8788660
        public void get_OnErrorCallbacks(){} // RVA: 0x7FFAC8788720
        public void get_DefaultCreator(){} // RVA: 0x7FFAC32EF410
        public void set_DefaultCreator(){} // RVA: 0x7FFAC34D4AA0
        public void get_DefaultCreatorNonPublic(){} // RVA: 0x7FFAC3E003A0
        public void set_DefaultCreatorNonPublic(){} // RVA: 0x7FFAC3E0C170
        public void .ctor(){} // RVA: 0x7FFAC87887E0
        public void InvokeOnSerializing(){} // RVA: 0x7FFAC8788B70
        public void InvokeOnSerialized(){} // RVA: 0x7FFAC8788CF0
        public void InvokeOnDeserializing(){} // RVA: 0x7FFAC8788E70
        public void InvokeOnDeserialized(){} // RVA: 0x7FFAC8788FF0
        public void InvokeOnError(){} // RVA: 0x7FFAC8789170
        public void CreateSerializationCallback(){} // RVA: 0x7FFAC8789310
        public void CreateSerializationErrorCallback(){} // RVA: 0x7FFAC8789400
    }

    public class JsonDictionaryContract : JsonContainerContract
    {
        public System.Func`2<string,string> DictionaryKeyResolver; // 0xC0
        public System.Type DictionaryKeyType; // 0xC8
        public System.Type DictionaryValueType; // 0xD0
        public Newtonsoft.Json.Serialization.JsonContract KeyContract; // 0xD8
        public System.Type ShouldCreateWrapper; // 0xE0
        public System.Type ParameterizedCreator; // 0xE8
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> OverrideCreator; // 0xF0
        public System.Func`1<object> HasParameterizedCreator; // 0xF8
        public bool HasParameterizedCreatorInternal; // 0x100
        public System.Reflection.ConstructorInfo _parameterizedConstructor; // 0x108
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _overrideCreator; // 0x110
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _parameterizedCreator; // 0x118
        public bool <HasParameterizedCreator>k__BackingField; // 0x120

        // ── Methods ──
        public void get_DictionaryKeyResolver(){} // RVA: 0x7FFAC2F8C120
        public void set_DictionaryKeyResolver(){} // RVA: 0x7FFAC2F8C130
        public void get_DictionaryKeyType(){} // RVA: 0x7FFAC3079460
        public void get_DictionaryValueType(){} // RVA: 0x7FFAC303E100
        public void get_KeyContract(){} // RVA: 0x7FFAC3540F70
        public void set_KeyContract(){} // RVA: 0x7FFAC2FA28A0
        public void get_ShouldCreateWrapper(){} // RVA: 0x7FFAC3C8B9C0
        public void get_ParameterizedCreator(){} // RVA: 0x7FFAC8789780
        public void get_OverrideCreator(){} // RVA: 0x7FFAC354B170
        public void set_OverrideCreator(){} // RVA: 0x7FFAC39B3E10
        public void get_HasParameterizedCreator(){} // RVA: 0x7FFAC87898E0
        public void set_HasParameterizedCreator(){} // RVA: 0x7FFAC87898F0
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x7FFAC8789900
        public void .ctor(){} // RVA: 0x7FFAC87899B0
        public void CreateWrapper(){} // RVA: 0x7FFAC878A890
        public void CreateTemporaryDictionary(){} // RVA: 0x7FFAC878AC90
    }

    public class JsonDynamicContract : JsonContainerContract
    {
        public Newtonsoft.Json.Serialization.JsonPropertyCollection Properties; // 0xC0
        public System.Func`2<string,string> PropertyNameResolver; // 0xC8
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<string,System.Runtime.CompilerServices.CallSite`1<System.Func`3<System.Runtime.CompilerServices.CallSite,object,object>>> _callSiteGetters; // 0xD0
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<string,System.Runtime.CompilerServices.CallSite`1<System.Func`4<System.Runtime.CompilerServices.CallSite,object,object,object>>> _callSiteSetters; // 0xD8

        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7FFAC2F8C120
        public void get_PropertyNameResolver(){} // RVA: 0x7FFAC3079460
        public void set_PropertyNameResolver(){} // RVA: 0x7FFAC3079470
        public void CreateCallSiteGetter(){} // RVA: 0x7FFAC878AF80
        public void CreateCallSiteSetter(){} // RVA: 0x7FFAC878B150
        public void .ctor(){} // RVA: 0x7FFAC878B420
        public void TryGetMember(){} // RVA: 0x7FFAC878B6D0
        public void TrySetMember(){} // RVA: 0x7FFAC878B8D0
    }

    public class JsonFormatterConverter : Object
    {
        public Newtonsoft.Json.Serialization.JsonSerializerInternalReader _reader; // 0x10
        public Newtonsoft.Json.Serialization.JsonISerializableContract _contract; // 0x18
        public Newtonsoft.Json.Serialization.JsonProperty _member; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC878BA50
        public void GetTokenValue(){} // RVA: 0x7FFAC2E8DC40
        public void Convert(){} // RVA: 0x7FFAC878BDC0 | overloaded x2
        public void ToBoolean(){} // RVA: 0x7FFAC878BF40
        public void ToByte(){} // RVA: 0x7FFAC878BF90
        public void ToChar(){} // RVA: 0x7FFAC878BFE0
        public void ToDateTime(){} // RVA: 0x7FFAC878C030
        public void ToDecimal(){} // RVA: 0x7FFAC878C080
        public void ToDouble(){} // RVA: 0x7FFAC878C0F0
        public void ToInt16(){} // RVA: 0x7FFAC878C140
        public void ToInt32(){} // RVA: 0x7FFAC878C190
        public void ToInt64(){} // RVA: 0x7FFAC878C1E0
        public void ToSByte(){} // RVA: 0x7FFAC878C230
        public void ToSingle(){} // RVA: 0x7FFAC878C280
        public void ToString(){} // RVA: 0x7FFAC878C2D0
        public void ToUInt16(){} // RVA: 0x7FFAC878C320
        public void ToUInt32(){} // RVA: 0x7FFAC878C370
        public void ToUInt64(){} // RVA: 0x7FFAC878C3C0
    }

    public class JsonISerializableContract : JsonContainerContract
    {
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> ISerializableCreator; // 0xC0

        // ── Methods ──
        public void get_ISerializableCreator(){} // RVA: 0x7FFAC2F8C120
        public void set_ISerializableCreator(){} // RVA: 0x7FFAC2F8C130
        public void .ctor(){} // RVA: 0x7FFAC878C410
    }

    public class JsonLinqContract : JsonContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC878C430
    }

    public class JsonObjectContract : JsonContainerContract
    {
        public 0x6B1C5870 MemberSerialization; // 0xC0
        public System.Nullable`1<0x6B1C5920> MissingMemberHandling; // 0xC4
        public System.Nullable`1<0x6B1C5AD8> ItemRequired; // 0xCC
        public System.Nullable`1<0x6B1C5978> ItemNullValueHandling; // 0xD4
        public Newtonsoft.Json.Serialization.JsonPropertyCollection Properties; // 0xE0
        public Newtonsoft.Json.Serialization.ExtensionDataSetter CreatorParameters; // 0xE8
        public Newtonsoft.Json.Serialization.ExtensionDataGetter OverrideCreator; // 0xF0
        public System.Func`2<string,string> ParameterizedCreator; // 0xF8
        public bool ExtensionDataSetter; // 0x100
        public System.Nullable`1<bool> ExtensionDataGetter; // 0x101
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> ExtensionDataValueType; // 0x108
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> ExtensionDataNameResolver; // 0x110
        public Newtonsoft.Json.Serialization.JsonPropertyCollection HasRequiredOrDefaultValueProperties; // 0x118
        public System.Type _extensionDataValueType; // 0x120

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFAC313B720
        public void set_MemberSerialization(){} // RVA: 0x7FFAC31434F0
        public void get_MissingMemberHandling(){} // RVA: 0x7FFAC878C450
        public void set_MissingMemberHandling(){} // RVA: 0x7FFAC878C460
        public void get_ItemRequired(){} // RVA: 0x7FFAC878C470
        public void set_ItemRequired(){} // RVA: 0x7FFAC878C480
        public void get_ItemNullValueHandling(){} // RVA: 0x7FFAC878C490
        public void set_ItemNullValueHandling(){} // RVA: 0x7FFAC878C4A0
        public void get_Properties(){} // RVA: 0x7FFAC2FA2900
        public void get_CreatorParameters(){} // RVA: 0x7FFAC878C4B0
        public void get_OverrideCreator(){} // RVA: 0x7FFAC36D1F40
        public void set_OverrideCreator(){} // RVA: 0x7FFAC3929BF0
        public void get_ParameterizedCreator(){} // RVA: 0x7FFAC354B170
        public void set_ParameterizedCreator(){} // RVA: 0x7FFAC39B3E10
        public void get_ExtensionDataSetter(){} // RVA: 0x7FFAC2FA2970
        public void set_ExtensionDataSetter(){} // RVA: 0x7FFAC2FA2980
        public void get_ExtensionDataGetter(){} // RVA: 0x7FFAC2F8C2A0
        public void set_ExtensionDataGetter(){} // RVA: 0x7FFAC2F8C2B0
        public void get_ExtensionDataValueType(){} // RVA: 0x7FFAC313CBB0
        public void set_ExtensionDataValueType(){} // RVA: 0x7FFAC878C580
        public void get_ExtensionDataNameResolver(){} // RVA: 0x7FFAC3331F50
        public void set_ExtensionDataNameResolver(){} // RVA: 0x7FFAC34A4860
        public void get_HasRequiredOrDefaultValueProperties(){} // RVA: 0x7FFAC878C6A0
        public void .ctor(){} // RVA: 0x7FFAC878C950
        public void GetUninitializedObject(){} // RVA: 0x7FFAC878CA30
    }

    public class JsonPrimitiveContract : JsonContract
    {
        public 0x6B1C61B8 TypeCode; // 0x90
        public System.Collections.Generic.Dictionary`2<System.Type,0x6B1C4B08> ReadTypeMap;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFAC3220660
        public void set_TypeCode(){} // RVA: 0x7FFAC34D2750
        public void .ctor(){} // RVA: 0x7FFAC878CB40
        public void .cctor(){} // RVA: 0x7FFAC878CCA0
    }

    public class JsonProperty : Object
    {
        public System.Nullable`1<0x6B1C5AD8> PropertyContract; // 0x10
        public bool PropertyName; // 0x18
        public object DeclaringType; // 0x20
        public bool Order; // 0x28
        public string UnderlyingName; // 0x30
        public bool ValueProvider; // 0x38
        public System.Type AttributeProvider; // 0x40
        public Newtonsoft.Json.Serialization.JsonContract PropertyType; // 0x48
        public System.Type Converter; // 0x50
        public System.Nullable`1<int> MemberConverter; // 0x58
        public string Ignored; // 0x60
        public Newtonsoft.Json.Serialization.IValueProvider Readable; // 0x68
        public Newtonsoft.Json.Serialization.IAttributeProvider Writable; // 0x70
        public Newtonsoft.Json.JsonConverter HasMemberAttribute; // 0x78
        public bool DefaultValue; // 0x80
        public bool Required; // 0x81
        public bool IsRequiredSpecified; // 0x82
        public bool IsReference; // 0x83
        public System.Nullable`1<bool> NullValueHandling; // 0x84
        public System.Nullable`1<0x6B1C5978> DefaultValueHandling; // 0x88
        public System.Nullable`1<0x6B1C3140> ReferenceLoopHandling; // 0x90
        public System.Nullable`1<0x6B1C5A80> ObjectCreationHandling; // 0x98
        public System.Nullable`1<0x6B1C59D0> TypeNameHandling; // 0xA0
        public System.Nullable`1<0x6B1C5BE0> ShouldSerialize; // 0xA8
        public System.Predicate`1<object> ShouldDeserialize; // 0xB0
        public System.Predicate`1<object> GetIsSpecified; // 0xB8
        public System.Predicate`1<object> SetIsSpecified; // 0xC0
        public System.Action`2<object,object> ItemConverter; // 0xC8
        public Newtonsoft.Json.JsonConverter ItemIsReference; // 0xD0
        public System.Nullable`1<bool> ItemTypeNameHandling; // 0xD8
        public System.Nullable`1<0x6B1C5BE0> ItemReferenceLoopHandling; // 0xDC
        public System.Nullable`1<0x6B1C5A80> <ItemReferenceLoopHandling>k__BackingField; // 0xE4

        // ── Methods ──
        public void get_PropertyContract(){} // RVA: 0x7FFAC2F9C730
        public void set_PropertyContract(){} // RVA: 0x7FFAC2F9C740
        public void get_PropertyName(){} // RVA: 0x7FFAC31D95E0
        public void set_PropertyName(){} // RVA: 0x7FFAC878D520
        public void get_DeclaringType(){} // RVA: 0x7FFAC2FC20E0
        public void set_DeclaringType(){} // RVA: 0x7FFAC30794D0
        public void get_Order(){} // RVA: 0x7FFAC2FE9500
        public void set_Order(){} // RVA: 0x7FFAC4249140
        public void get_UnderlyingName(){} // RVA: 0x7FFAC2FBF370
        public void set_UnderlyingName(){} // RVA: 0x7FFAC2FBF380
        public void get_ValueProvider(){} // RVA: 0x7FFAC2F9CD50
        public void set_ValueProvider(){} // RVA: 0x7FFAC2F9CD60
        public void get_AttributeProvider(){} // RVA: 0x7FFAC2FE9590
        public void set_AttributeProvider(){} // RVA: 0x7FFAC2FE95A0
        public void get_PropertyType(){} // RVA: 0x7FFAC2F9E740
        public void set_PropertyType(){} // RVA: 0x7FFAC878D650
        public void get_Converter(){} // RVA: 0x7FFAC30E5600
        public void set_Converter(){} // RVA: 0x7FFAC30E06F0
        public void get_MemberConverter(){} // RVA: 0x7FFAC30E5600
        public void set_MemberConverter(){} // RVA: 0x7FFAC30E06F0
        public void get_Ignored(){} // RVA: 0x7FFAC313E620
        public void set_Ignored(){} // RVA: 0x7FFAC313D3B0
        public void get_Readable(){} // RVA: 0x7FFAC313DE70
        public void set_Readable(){} // RVA: 0x7FFAC3143D90
        public void get_Writable(){} // RVA: 0x7FFAC3BDEE90
        public void set_Writable(){} // RVA: 0x7FFAC8730670
        public void get_HasMemberAttribute(){} // RVA: 0x7FFAC3FA38F0
        public void set_HasMemberAttribute(){} // RVA: 0x7FFAC878D710
        public void get_DefaultValue(){} // RVA: 0x7FFAC878D720
        public void set_DefaultValue(){} // RVA: 0x7FFAC878D730
        public void GetResolvedDefaultValue(){} // RVA: 0x7FFAC878D790
        public void get_Required(){} // RVA: 0x7FFAC878D850
        public void set_Required(){} // RVA: 0x7FFAC878D890
        public void get_IsRequiredSpecified(){} // RVA: 0x7FFAC878D8F0
        public void get_IsReference(){} // RVA: 0x7FFAC878D930
        public void set_IsReference(){} // RVA: 0x7FFAC878D940
        public void get_NullValueHandling(){} // RVA: 0x7FFAC2F60010
        public void set_NullValueHandling(){} // RVA: 0x7FFAC4A2BA70
        public void get_DefaultValueHandling(){} // RVA: 0x7FFAC32EF640
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAC3705AA0
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFAC354DFB0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAC7E01AA0
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFAC3543900
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAC878D950
        public void get_TypeNameHandling(){} // RVA: 0x7FFAC354B1A0
        public void set_TypeNameHandling(){} // RVA: 0x7FFAC45C9F60
        public void get_ShouldSerialize(){} // RVA: 0x7FFAC2F8C040
        public void set_ShouldSerialize(){} // RVA: 0x7FFAC2F8C050
        public void get_ShouldDeserialize(){} // RVA: 0x7FFAC2F8C0B0
        public void set_ShouldDeserialize(){} // RVA: 0x7FFAC2F8C0C0
        public void get_GetIsSpecified(){} // RVA: 0x7FFAC2F8C120
        public void set_GetIsSpecified(){} // RVA: 0x7FFAC2F8C130
        public void get_SetIsSpecified(){} // RVA: 0x7FFAC3079460
        public void set_SetIsSpecified(){} // RVA: 0x7FFAC3079470
        public void ToString(){} // RVA: 0x7FFAC878D960
        public void get_ItemConverter(){} // RVA: 0x7FFAC303E100
        public void set_ItemConverter(){} // RVA: 0x7FFAC303E110
        public void get_ItemIsReference(){} // RVA: 0x7FFAC878D9B0
        public void set_ItemIsReference(){} // RVA: 0x7FFAC878D9C0
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFAC878D9D0
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFAC878D9E0
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC878D9F0
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFAC878DA00
        public void WritePropertyName(){} // RVA: 0x7FFAC878DA10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonPropertyCollection : KeyedCollection`2
    {
        public System.Type _type; // 0x30
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.JsonProperty> _list; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC878DA70
        public void GetKeyForItem(){} // RVA: 0x7FFAC8330240
        public void AddProperty(){} // RVA: 0x7FFAC878DD10
        public void GetClosestMatchProperty(){} // RVA: 0x7FFAC878E010
        public void TryGetProperty(){} // RVA: 0x7FFAC878E060
        public void GetProperty(){} // RVA: 0x7FFAC878E1B0
    }

    public class JsonSerializerInternalBase : Object
    {
        public Newtonsoft.Json.Serialization.ErrorContext DefaultReferenceMappings; // 0x10
        public Newtonsoft.Json.Utilities.BidirectionalDictionary`2<string,object> _mappings; // 0x18
        public Newtonsoft.Json.JsonSerializer Serializer; // 0x20
        public Newtonsoft.Json.Serialization.ITraceWriter TraceWriter; // 0x28
        public Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC878E3F0
        public void get_DefaultReferenceMappings(){} // RVA: 0x7FFAC878E540
        public void ResolvedNullValueHandling(){} // RVA: 0x7FFAC878E6A0
        public void GetErrorContext(){} // RVA: 0x7FFAC878E750
        public void ClearErrorContext(){} // RVA: 0x7FFAC878E9C0
        public void IsErrorHandled(){} // RVA: 0x7FFAC878EA70
    }

    public class JsonSerializerInternalReader : JsonSerializerInternalBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC878EED0
        public void Populate(){} // RVA: 0x7FFAC878EEE0
        public void GetContractSafe(){} // RVA: 0x7FFAC878F5A0
        public void GetContract(){} // RVA: 0x7FFAC878F650
        public void Deserialize(){} // RVA: 0x7FFAC878F6B0
        public void GetInternalSerializer(){} // RVA: 0x7FFAC878FA00
        public void CreateJToken(){} // RVA: 0x7FFAC878FBA0
        public void CreateJObject(){} // RVA: 0x7FFAC878FFD0
        public void CreateValueInternal(){} // RVA: 0x7FFAC87903B0
        public void CoerceEmptyStringToNull(){} // RVA: 0x7FFAC8790990
        public void GetExpectedDescription(){} // RVA: 0x7FFAC8790AA0
        public void GetConverter(){} // RVA: 0x7FFAC8790BB0
        public void CreateObject(){} // RVA: 0x7FFAC8790C90
        public void ReadMetadataPropertiesToken(){} // RVA: 0x7FFAC8791A80
        public void ReadMetadataProperties(){} // RVA: 0x7FFAC87924E0
        public void ResolveTypeName(){} // RVA: 0x7FFAC8792FA0
        public void EnsureArrayContract(){} // RVA: 0x7FFAC87935F0
        public void CreateList(){} // RVA: 0x7FFAC87937B0
        public void HasNoDefinedType(){} // RVA: 0x7FFAC8794090
        public void EnsureType(){} // RVA: 0x7FFAC8794170
        public void SetPropertyValue(){} // RVA: 0x7FFAC87946D0
        public void CalculatePropertyDetails(){} // RVA: 0x7FFAC8794AE0
        public void AddReference(){} // RVA: 0x7FFAC87951E0
        public void HasFlag(){} // RVA: 0x7FFAC84CAD10
        public void ShouldSetPropertyValue(){} // RVA: 0x7FFAC8795470
        public void CreateNewList(){} // RVA: 0x7FFAC87955D0
        public void CreateNewDictionary(){} // RVA: 0x7FFAC8795950
        public void OnDeserializing(){} // RVA: 0x7FFAC8795C00
        public void OnDeserialized(){} // RVA: 0x7FFAC8795DD0
        public void PopulateDictionary(){} // RVA: 0x7FFAC8795FA0
        public void PopulateMultidimensionalArray(){} // RVA: 0x7FFAC8796C00
        public void ThrowUnexpectedEndException(){} // RVA: 0x7FFAC8797510
        public void PopulateList(){} // RVA: 0x7FFAC8797620
        public void CreateISerializable(){} // RVA: 0x7FFAC8797C30
        public void CreateISerializableItem(){} // RVA: 0x7FFAC87985A0
        public void CreateDynamic(){} // RVA: 0x7FFAC87987B0
        public void CreateObjectUsingCreatorWithParameters(){} // RVA: 0x7FFAC8799170
        public void DeserializeConvertable(){} // RVA: 0x7FFAC879AA90
        public void ResolvePropertyAndCreatorValues(){} // RVA: 0x7FFAC879AEF0
        public void CreateNewObject(){} // RVA: 0x7FFAC879BA70
        public void PopulateObject(){} // RVA: 0x7FFAC879BD40
        public void ShouldDeserialize(){} // RVA: 0x7FFAC879CB10
        public void CheckPropertyName(){} // RVA: 0x7FFAC879CCF0
        public void SetExtensionData(){} // RVA: 0x7FFAC879CEB0
        public void ReadExtensionDataValue(){} // RVA: 0x7FFAC879CFE0
        public void EndProcessProperty(){} // RVA: 0x7FFAC879D0E0
        public void SetPropertyPresence(){} // RVA: 0x7FFAC879D580
        public void HandleError(){} // RVA: 0x7FFAC879D6C0
    }

    public class JsonSerializerInternalWriter : JsonSerializerInternalBase
    {
        public System.Type _rootType; // 0x38
        public int _rootLevel; // 0x40
        public System.Collections.Generic.List`1<object> _serializeStack; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC879D860
        public void Serialize(){} // RVA: 0x7FFAC879D930
        public void GetInternalSerializer(){} // RVA: 0x7FFAC879DD80
        public void GetContractSafe(){} // RVA: 0x7FFAC879DF20
        public void GetContract(){} // RVA: 0x7FFAC879DFA0
        public void SerializePrimitive(){} // RVA: 0x7FFAC879E010
        public void SerializeValue(){} // RVA: 0x7FFAC879E330
        public void ResolveIsReference(){} // RVA: 0x7FFAC879EB40
        public void ShouldWriteReference(){} // RVA: 0x7FFAC879EBD0
        public void ShouldWriteProperty(){} // RVA: 0x7FFAC879ED50
        public void CheckForCircularReference(){} // RVA: 0x7FFAC879EE70
        public void WriteReference(){} // RVA: 0x7FFAC879F370
        public void GetReference(){} // RVA: 0x7FFAC879F580
        public void TryConvertToString(){} // RVA: 0x7FFAC879F6D0
        public void SerializeString(){} // RVA: 0x7FFAC879F8F0
        public void OnSerializing(){} // RVA: 0x7FFAC879F9A0
        public void OnSerialized(){} // RVA: 0x7FFAC879FB30
        public void SerializeObject(){} // RVA: 0x7FFAC879FCC0
        public void CalculatePropertyValues(){} // RVA: 0x7FFAC87A08C0
        public void WriteObjectStart(){} // RVA: 0x7FFAC87A1200
        public void HasCreatorParameter(){} // RVA: 0x7FFAC87A1580
        public void WriteReferenceIdProperty(){} // RVA: 0x7FFAC87A1650
        public void WriteTypeProperty(){} // RVA: 0x7FFAC87A1820
        public void HasFlag(){} // RVA: 0x7FFAC84CAD10 | overloaded x3
        public void SerializeConvertable(){} // RVA: 0x7FFAC87A1AC0
        public void SerializeList(){} // RVA: 0x7FFAC87A2100
        public void SerializeMultidimensionalArray(){} // RVA: 0x7FFAC87A2890 | overloaded x2
        public void WriteStartArray(){} // RVA: 0x7FFAC87A2CE0
        public void SerializeISerializable(){} // RVA: 0x7FFAC87A3170
        public void SerializeDynamic(){} // RVA: 0x7FFAC87A3B00
        public void ShouldWriteDynamicProperty(){} // RVA: 0x7FFAC87A4770
        public void ShouldWriteType(){} // RVA: 0x7FFAC87A4820
        public void SerializeDictionary(){} // RVA: 0x7FFAC87A4A40
        public void GetPropertyName(){} // RVA: 0x7FFAC87A54A0
        public void HandleError(){} // RVA: 0x7FFAC87A5A20
        public void ShouldSerialize(){} // RVA: 0x7FFAC87A5B70
        public void IsSpecified(){} // RVA: 0x7FFAC87A5D40
    }

    public class JsonSerializerProxy : JsonSerializer
    {
        public Newtonsoft.Json.Serialization.JsonSerializerInternalReader ReferenceResolver; // 0xE0
        public Newtonsoft.Json.Serialization.JsonSerializerInternalWriter TraceWriter; // 0xE8
        public Newtonsoft.Json.JsonSerializer EqualityComparer; // 0xF0

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFAC87A5F10
        public void remove_Error(){} // RVA: 0x7FFAC87A5F40
        public void get_ReferenceResolver(){} // RVA: 0x7FFAC87A5F70
        public void set_ReferenceResolver(){} // RVA: 0x7FFAC87A5FA0
        public void get_TraceWriter(){} // RVA: 0x7FFAC87A5FD0
        public void set_TraceWriter(){} // RVA: 0x7FFAC87A6000
        public void get_EqualityComparer(){} // RVA: 0x7FFAC87A6030
        public void set_EqualityComparer(){} // RVA: 0x7FFAC87A6060
        public void get_Converters(){} // RVA: 0x7FFAC87A6090
        public void get_DefaultValueHandling(){} // RVA: 0x7FFAC87A60C0
        public void set_DefaultValueHandling(){} // RVA: 0x7FFAC87A60F0
        public void get_ContractResolver(){} // RVA: 0x7FFAC87A6120
        public void set_ContractResolver(){} // RVA: 0x7FFAC87A6150
        public void get_MissingMemberHandling(){} // RVA: 0x7FFAC87A6180
        public void set_MissingMemberHandling(){} // RVA: 0x7FFAC87A61B0
        public void get_NullValueHandling(){} // RVA: 0x7FFAC87A61E0
        public void set_NullValueHandling(){} // RVA: 0x7FFAC87A6210
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFAC87A6240
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFAC87A6270
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFAC87A62A0
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFAC87A62D0
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFAC87A6300
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFAC87A6330
        public void get_TypeNameHandling(){} // RVA: 0x7FFAC87A6360
        public void set_TypeNameHandling(){} // RVA: 0x7FFAC87A6390
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFAC87A63C0
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFAC87A63F0
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC87A6420
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFAC87A6450
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFAC87A6480
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFAC87A64B0
        public void get_ConstructorHandling(){} // RVA: 0x7FFAC87A64E0
        public void set_ConstructorHandling(){} // RVA: 0x7FFAC87A6510
        public void get_Binder(){} // RVA: 0x7FFAC87A6540
        public void set_Binder(){} // RVA: 0x7FFAC87A6570
        public void get_SerializationBinder(){} // RVA: 0x7FFAC87A65A0
        public void set_SerializationBinder(){} // RVA: 0x7FFAC87A65D0
        public void get_Context(){} // RVA: 0x7FFAC87A6600
        public void set_Context(){} // RVA: 0x7FFAC87A6650
        public void get_Formatting(){} // RVA: 0x7FFAC87A6690
        public void set_Formatting(){} // RVA: 0x7FFAC87A66C0
        public void get_DateFormatHandling(){} // RVA: 0x7FFAC87A66F0
        public void set_DateFormatHandling(){} // RVA: 0x7FFAC87A6720
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFAC87A6750
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFAC87A6780
        public void get_DateParseHandling(){} // RVA: 0x7FFAC87A67B0
        public void set_DateParseHandling(){} // RVA: 0x7FFAC87A67E0
        public void get_FloatFormatHandling(){} // RVA: 0x7FFAC87A6810
        public void set_FloatFormatHandling(){} // RVA: 0x7FFAC87A6840
        public void get_FloatParseHandling(){} // RVA: 0x7FFAC87A6870
        public void set_FloatParseHandling(){} // RVA: 0x7FFAC87A68A0
        public void get_StringEscapeHandling(){} // RVA: 0x7FFAC87A68D0
        public void set_StringEscapeHandling(){} // RVA: 0x7FFAC87A6900
        public void get_DateFormatString(){} // RVA: 0x7FFAC87A6930
        public void set_DateFormatString(){} // RVA: 0x7FFAC87A6960
        public void get_Culture(){} // RVA: 0x7FFAC87A6990
        public void set_Culture(){} // RVA: 0x7FFAC87A69C0
        public void get_MaxDepth(){} // RVA: 0x7FFAC87A69F0
        public void set_MaxDepth(){} // RVA: 0x7FFAC87A6A20
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFAC87A6A50
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFAC87A6A80
        public void GetInternalSerializer(){} // RVA: 0x7FFAC87A6AB0
        public void .ctor(){} // RVA: 0x7FFAC87A6C30 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7FFAC87A6D90
        public void PopulateInternal(){} // RVA: 0x7FFAC87A6DF0
        public void SerializeInternal(){} // RVA: 0x7FFAC87A6E40
    }

    public class JsonStringContract : JsonPrimitiveContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87A6EA0
    }

    public class JsonTypeReflector : Object
    {
        public System.Nullable`1<bool> DynamicCodeGeneration;
        public System.Nullable`1<bool> FullyTrusted; // 0x2
        public string ReflectionDelegateFactory;
        public string RefPropertyName;
        public string TypePropertyName;
        public string ValuePropertyName;
        public string ArrayValuesPropertyName;
        public string ShouldSerializePrefix;
        public string SpecifiedPostfix;
        public string ConcurrentDictionaryTypeName;
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,System.Func`2<object[],object>> CreatorCache; // 0x8
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,System.Type> AssociatedMetadataTypesCache; // 0x10
        public Newtonsoft.Json.Utilities.ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

        // ── Methods ──
        public void GetCachedAttribute(){} // RVA: 0x7FFAC2E8DC40
        public void CanTypeDescriptorConvertString(){} // RVA: 0x7FFAC87A6F10
        public void GetDataContractAttribute(){} // RVA: 0x7FFAC87A7280
        public void GetDataMemberAttribute(){} // RVA: 0x7FFAC87A7340
        public void GetObjectMemberSerialization(){} // RVA: 0x7FFAC87A75E0
        public void GetJsonConverter(){} // RVA: 0x7FFAC87A76D0
        public void CreateJsonConverterInstance(){} // RVA: 0x7FFAC87A7830
        public void CreateNamingStrategyInstance(){} // RVA: 0x7FFAC87A7950
        public void GetContainerNamingStrategy(){} // RVA: 0x7FFAC87A7A70
        public void GetCreator(){} // RVA: 0x7FFAC87A7B40
        public void GetAssociatedMetadataType(){} // RVA: 0x7FFAC87A7D30
        public void GetAssociateMetadataTypeFromAttribute(){} // RVA: 0x7FFAC87A7DD0
        public void GetAttribute(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void IsNonSerializable(){} // RVA: 0x7FFAC87A80D0
        public void IsSerializable(){} // RVA: 0x7FFAC87A8140
        public void get_DynamicCodeGeneration(){} // RVA: 0x7FFAC87A81B0
        public void get_FullyTrusted(){} // RVA: 0x7FFAC87A82A0
        public void get_ReflectionDelegateFactory(){} // RVA: 0x7FFAC87A83C0
        public void .cctor(){} // RVA: 0x7FFAC87A8460
    }

    public class KebabCaseNamingStrategy : NamingStrategy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void ResolvePropertyName(){} // RVA: 0x7FFAC87A8CA0
    }

    public class MemoryTraceWriter : Object
    {
        public System.Collections.Generic.Queue`1<string> LevelFilter; // 0x10
        public object _lock; // 0x18
        public 0x6B130A40 <LevelFilter>k__BackingField; // 0x20

        // ── Methods ──
        public void get_LevelFilter(){} // RVA: 0x7FFAC30DBBE0
        public void set_LevelFilter(){} // RVA: 0x7FFAC35DB7A0
        public void .ctor(){} // RVA: 0x7FFAC87A8CB0
        public void Trace(){} // RVA: 0x7FFAC87A8DF0
        public void GetTraceMessages(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFAC87A91F0
    }

    public class NamingStrategy : Object
    {
        public bool ProcessDictionaryKeys; // 0x10
        public bool ProcessExtensionDataNames; // 0x11
        public bool OverrideSpecifiedNames; // 0x12

        // ── Methods ──
        public void get_ProcessDictionaryKeys(){} // RVA: 0x7FFAC2FEB5E0
        public void set_ProcessDictionaryKeys(){} // RVA: 0x7FFAC2FEB5F0
        public void get_ProcessExtensionDataNames(){} // RVA: 0x7FFAC3771DA0
        public void set_ProcessExtensionDataNames(){} // RVA: 0x7FFAC3771D90
        public void get_OverrideSpecifiedNames(){} // RVA: 0x7FFAC3AE1A90
        public void set_OverrideSpecifiedNames(){} // RVA: 0x7FFAC4411DE0
        public void GetPropertyName(){} // RVA: 0x7FFAC87A9590
        public void GetExtensionDataName(){} // RVA: 0x7FFAC87A95C0
        public void GetDictionaryKey(){} // RVA: 0x7FFAC87A95E0
        public void ResolvePropertyName(){} // RVA: 0x7FFAC2C58F40
        public void GetHashCode(){} // RVA: 0x7FFAC87A9600
        public void Equals(){} // RVA: 0x7FFAC87A97E0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ObjectConstructor`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2C58F40
        public void BeginInvoke(){} // RVA: 0x7FFAC2C6AE80
        public void EndInvoke(){} // RVA: 0x7FFAC2C58F40
    }

    public class OnErrorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReflectionAttributeProvider : Object
    {
        public object _attributeProvider; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87A98A0
        public void GetAttributes(){} // RVA: 0x7FFAC87A99F0 | overloaded x2
    }

    public class ReflectionValueProvider : Object
    {
        public System.Reflection.MemberInfo _memberInfo; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87A9A70
        public void SetValue(){} // RVA: 0x7FFAC87A9B50
        public void GetValue(){} // RVA: 0x7FFAC87A9CB0
    }

    public class SerializationBinderAdapter : Object
    {
        public System.Runtime.Serialization.SerializationBinder SerializationBinder; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void BindToType(){} // RVA: 0x7FFAC87A9F20
        public void BindToName(){} // RVA: 0x7FFAC87A9F50
    }

    public class SerializationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8787CD0
        public void Invoke(){} // RVA: 0x7FFAC5C4DBE0
        public void BeginInvoke(){} // RVA: 0x7FFAC8787E50
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class SerializationErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8787EE0
        public void Invoke(){} // RVA: 0x7FFAC8788060
        public void BeginInvoke(){} // RVA: 0x7FFAC8788090
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class SnakeCaseNamingStrategy : NamingStrategy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void ResolvePropertyName(){} // RVA: 0x7FFAC87A9F80
    }

    public class TraceJsonReader : JsonReader
    {
        public Newtonsoft.Json.JsonReader Depth; // 0x78
        public Newtonsoft.Json.JsonTextWriter Path; // 0x80
        public System.IO.StringWriter QuoteChar; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87A9F90
        public void GetDeserializedJsonMessage(){} // RVA: 0x7FFAC87AA280
        public void Read(){} // RVA: 0x7FFAC87AA2B0
        public void ReadAsInt32(){} // RVA: 0x7FFAC87AA330
        public void ReadAsString(){} // RVA: 0x7FFAC87AA3B0
        public void ReadAsBytes(){} // RVA: 0x7FFAC87AA430
        public void ReadAsDecimal(){} // RVA: 0x7FFAC87AA4B0
        public void ReadAsDouble(){} // RVA: 0x7FFAC87AA540
        public void ReadAsBoolean(){} // RVA: 0x7FFAC87AA5C0
        public void ReadAsDateTime(){} // RVA: 0x7FFAC87AA640
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFAC87AA6C0
        public void WriteCurrentToken(){} // RVA: 0x7FFAC87AA750
        public void get_Depth(){} // RVA: 0x7FFAC873BD10
        public void get_Path(){} // RVA: 0x7FFAC873BD40
        public void get_QuoteChar(){} // RVA: 0x7FFAC873BD70
        public void set_QuoteChar(){} // RVA: 0x7FFAC87AA7A0
        public void get_TokenType(){} // RVA: 0x7FFAC873BDA0
        public void get_Value(){} // RVA: 0x7FFAC873BCE0
        public void get_ValueType(){} // RVA: 0x7FFAC873BDD0
        public void Close(){} // RVA: 0x7FFAC87AA7D0
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFAC87AA800
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFAC87AA860
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFAC87AA8C0
    }

    public class TraceJsonWriter : JsonWriter
    {
        public Newtonsoft.Json.JsonWriter _innerWriter; // 0x60
        public Newtonsoft.Json.JsonTextWriter _textWriter; // 0x68
        public System.IO.StringWriter _sw; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC87AA920
        public void GetSerializedJsonMessage(){} // RVA: 0x7FFAC87AAE00
        public void WriteValue(){} // RVA: 0x7FFAC87AC980 | overloaded x38
        public void WriteUndefined(){} // RVA: 0x7FFAC87AB8C0
        public void WriteNull(){} // RVA: 0x7FFAC87AB930
        public void WriteWhitespace(){} // RVA: 0x7FFAC87ACA50
        public void WriteComment(){} // RVA: 0x7FFAC87ACAC0
        public void WriteStartArray(){} // RVA: 0x7FFAC87ACB30
        public void WriteEndArray(){} // RVA: 0x7FFAC87ACBB0
        public void WriteStartConstructor(){} // RVA: 0x7FFAC87ACC10
        public void WriteEndConstructor(){} // RVA: 0x7FFAC87ACCA0
        public void WritePropertyName(){} // RVA: 0x7FFAC87ACDD0 | overloaded x2
        public void WriteStartObject(){} // RVA: 0x7FFAC87ACEB0
        public void WriteEndObject(){} // RVA: 0x7FFAC87ACF30
        public void WriteRawValue(){} // RVA: 0x7FFAC87ACF90
        public void WriteRaw(){} // RVA: 0x7FFAC87AD010
        public void Close(){} // RVA: 0x7FFAC87AD070
        public void Flush(){} // RVA: 0x7FFAC87AD0D0
    }

}