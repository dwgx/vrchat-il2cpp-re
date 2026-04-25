// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 14
// Methods: 94

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class DateTimeFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC9FE8480
        public void Write(){} // RVA: 0x7FFAC9FE88F0
        public void .ctor(){} // RVA: 0x7FFAC9FE8980
    }

    public class DateTimeOffsetFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC9FE89E0
        public void Write(){} // RVA: 0x7FFAC9FE8B90
        public void .ctor(){} // RVA: 0x7FFAC9FE8CC0
    }

    public class DebugContext : Object
    {
        public object Logger; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.ILogger LoggingPolicy; // 0x18
        public 0x6B2242A8 ErrorHandlingPolicy; // 0x20
        public 0x6B223E30 errorHandlingPolicy; // 0x24

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFAC9FFAFF0
        public void set_Logger(){} // RVA: 0x7FFAC9FFA8A0
        public void get_LoggingPolicy(){} // RVA: 0x7FFAC9FFB1E0
        public void set_LoggingPolicy(){} // RVA: 0x7FFAC9FFB1F0
        public void get_ErrorHandlingPolicy(){} // RVA: 0x7FFAC86BCE40
        public void set_ErrorHandlingPolicy(){} // RVA: 0x7FFAC86BCE50
        public void LogWarning(){} // RVA: 0x7FFAC9FFB200
        public void LogError(){} // RVA: 0x7FFAC9FFB300
        public void LogException(){} // RVA: 0x7FFAC9FFB400
        public void ResetToDefault(){} // RVA: 0x7FFAC9FFB5E0
        public void .ctor(){} // RVA: 0x7FFAC9FFB780
    }

    public class DecimalSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA003280
        public void WriteValue(){} // RVA: 0x7FFACA0036A0
        public void .ctor(){} // RVA: 0x7FFACA003780
    }

    public class DefaultLoggers : Object
    {
        public object DefaultLogger;
        public VRC.Udon.Serialization.OdinSerializer.ILogger UnityLogger; // 0x8

        // ── Methods ──
        public void get_DefaultLogger(){} // RVA: 0x7FFAC9FEA9B0
        public void get_UnityLogger(){} // RVA: 0x7FFAC9FEAA00
        public void .cctor(){} // RVA: 0x7FFAC9FEAEB0
    }

    public class DefaultSerializationBinder : TwoWaySerializationBinder
    {
        public object ASSEMBLY_LOOKUP_LOCK;
        public System.Collections.Generic.Dictionary`2<string,System.Reflection.Assembly> assemblyNameLookUp; // 0x8
        public System.Collections.Generic.Dictionary`2<string,System.Type> customTypeNameToTypeBindings; // 0x10
        public object TYPETONAME_LOCK; // 0x18
        public System.Collections.Generic.Dictionary`2<System.Type,string> nameMap; // 0x20
        public object NAMETOTYPE_LOCK; // 0x28
        public System.Collections.Generic.Dictionary`2<string,System.Type> typeMap; // 0x30
        public object ASSEMBLY_REGISTER_QUEUE_LOCK; // 0x38
        public System.Collections.Generic.List`1<System.Reflection.Assembly> assembliesQueuedForRegister; // 0x40
        public System.Collections.Generic.List`1<System.AssemblyLoadEventArgs> assemblyLoadEventsQueuedForRegister; // 0x48

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9FEAF60
        public void RegisterAllQueuedAssembliesRepeating(){} // RVA: 0x7FFAC9FEBC30
        public void RegisterQueuedAssemblies(){} // RVA: 0x7FFAC9FEBCB0
        public void RegisterQueuedAssemblyLoadEvents(){} // RVA: 0x7FFAC9FEBF90
        public void RegisterAssembly(){} // RVA: 0x7FFAC9FEC2A0
        public void BindToName(){} // RVA: 0x7FFAC9FEC820
        public void ContainsType(){} // RVA: 0x7FFAC9FED140
        public void BindToType(){} // RVA: 0x7FFAC9FED350
        public void ParseTypeName(){} // RVA: 0x7FFAC9FED730
        public void ParseName(){} // RVA: 0x7FFAC9FEDF60
        public void ParseGenericAndOrArrayType(){} // RVA: 0x7FFAC9FEE290
        public void TryParseGenericAndOrArrayTypeName(){} // RVA: 0x7FFAC9FEE9C0
        public void Peek(){} // RVA: 0x7FFAC9FEEE90
        public void ReadGenericArg(){} // RVA: 0x7FFAC9FEEEE0
        public void .ctor(){} // RVA: 0x7FFAC9FEEFF0
    }

    public class DelegateFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFAC9FE2420
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DelegateFormatter`1 : BaseFormatter`1
    {
        public System.Type DelegateType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
    }

    public class DerivedDictionaryFormatter`3 : BaseFormatter`1
    {
        public bool KeyIsValueType;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Collections.Generic.IEqualityComparer`1<V>> EqualityComparerSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<V> KeyReaderWriter;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> ValueReaderWriter;
        public System.Reflection.ConstructorInfo ComparerConstructor;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

    public class DeserializationContext : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationConfig Binder; // 0x10
        public System.Collections.Generic.Dictionary`2<int,object> StringReferenceResolver; // 0x18
        public System.Runtime.Serialization.StreamingContext GuidReferenceResolver; // 0x20
        public System.Runtime.Serialization.IFormatterConverter IndexReferenceResolver; // 0x30
        public VRC.Udon.Serialization.OdinSerializer.TwoWaySerializationBinder StreamingContext; // 0x38
        public VRC.Udon.Serialization.OdinSerializer.IExternalStringReferenceResolver FormatterConverter; // 0x40
        public VRC.Udon.Serialization.OdinSerializer.IExternalGuidReferenceResolver Config; // 0x48
        public VRC.Udon.Serialization.OdinSerializer.IExternalIndexReferenceResolver <IndexReferenceResolver>k__BackingField; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FEF410 | overloaded x4
        public void get_Binder(){} // RVA: 0x7FFAC9FEF690
        public void set_Binder(){} // RVA: 0x7FFAC31D0C20
        public void get_StringReferenceResolver(){} // RVA: 0x7FFAC2F9E740
        public void set_StringReferenceResolver(){} // RVA: 0x7FFAC2F49200
        public void get_GuidReferenceResolver(){} // RVA: 0x7FFAC2F9C730
        public void set_GuidReferenceResolver(){} // RVA: 0x7FFAC2F9C740
        public void get_IndexReferenceResolver(){} // RVA: 0x7FFAC2FC20E0
        public void set_IndexReferenceResolver(){} // RVA: 0x7FFAC30794D0
        public void get_StreamingContext(){} // RVA: 0x7FFAC4A19630
        public void get_FormatterConverter(){} // RVA: 0x7FFAC31D95E0
        public void get_Config(){} // RVA: 0x7FFAC9FEF750
        public void set_Config(){} // RVA: 0x7FFAC2F22E30
        public void RegisterInternalReference(){} // RVA: 0x7FFAC9FEF800
        public void GetInternalReference(){} // RVA: 0x7FFAC9FEF890
        public void GetExternalObject(){} // RVA: 0x7FFAC9FEFD70 | overloaded x3
        public void Reset(){} // RVA: 0x7FFAC9FEFF70
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFAC9FF0120
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFAC2F21310
    }

    public class DictionaryFormatter`2 : BaseFormatter`1
    {
        public bool KeyIsValueType;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Collections.Generic.IEqualityComparer`1<U>> EqualityComparerSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<U> KeyReaderWriter;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> ValueReaderWriter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2C58E90
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

    public class DictionaryKeyUtility : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,bool> GetSupportedDictionaryKeyTypesResults;
        public System.Collections.Generic.HashSet`1<System.Type> BaseSupportedDictionaryKeyTypes; // 0x8
        public System.Collections.Generic.HashSet`1<char> AllowedSpecialKeyStrChars; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider> TypeToKeyPathProviders; // 0x18
        public System.Collections.Generic.Dictionary`2<string,VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider> IDToKeyPathProviders; // 0x20
        public System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider,string> ProviderToID; // 0x28
        public System.Collections.Generic.Dictionary`2<object,string> ObjectsToTempKeys; // 0x30
        public System.Collections.Generic.Dictionary`2<string,object> TempKeysToObjects; // 0x38
        public long tempKeyCounter; // 0x40

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACA010D20
        public void LogInvalidKeyPathProvider(){} // RVA: 0x7FFACA012D50
        public void GetPersistentPathKeyTypes(){} // RVA: 0x7FFACA012F00
        public void KeyTypeSupportsPersistentPaths(){} // RVA: 0x7FFACA012F50
        public void PrivateIsSupportedDictionaryKeyType(){} // RVA: 0x7FFACA0131B0
        public void GetDictionaryKeyString(){} // RVA: 0x7FFACA0132D0
        public void GetDictionaryKeyValue(){} // RVA: 0x7FFACA014980
        public void FromTo(){} // RVA: 0x7FFACA0156C0
    }

    public class DoubleLookupDictionaryFormatter`3 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<U> PrimaryReaderWriter;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Collections.Generic.Dictionary`2<V,T>> InnerReaderWriter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2C58E90
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

    public class DoubleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA0037F0
        public void WriteValue(){} // RVA: 0x7FFACA0045C0
        public void .ctor(){} // RVA: 0x7FFACA004630
    }

}