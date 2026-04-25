// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 13
// Methods: 83

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class DateTimeFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD55408480
        public void Write(){} // RVA: 0x7FFD554088F0
        public void .ctor(){} // RVA: 0x7FFD55408980
    }

    public class DateTimeOffsetFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD554089E0
        public void Write(){} // RVA: 0x7FFD55408B90
        public void .ctor(){} // RVA: 0x7FFD55408CC0
    }

    public class DecimalSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD55423280
        public void WriteValue(){} // RVA: 0x7FFD554236A0
        public void .ctor(){} // RVA: 0x7FFD55423780
    }

    public class DefaultLoggers : Object
    {
        public object DefaultLogger;
        public VRC.Udon.Serialization.OdinSerializer.ILogger UnityLogger; // 0x8

        // ── Methods ──
        public void get_DefaultLogger(){} // RVA: 0x7FFD5540A9B0
        public void get_UnityLogger(){} // RVA: 0x7FFD5540AA00
        public void .cctor(){} // RVA: 0x7FFD5540AEB0
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
        public System.Collections.Generic.List`1<0x6641E420> assemblyLoadEventsQueuedForRegister; // 0x48

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5540AF60
        public void RegisterAllQueuedAssembliesRepeating(){} // RVA: 0x7FFD5540BC30
        public void RegisterQueuedAssemblies(){} // RVA: 0x7FFD5540BCB0
        public void RegisterQueuedAssemblyLoadEvents(){} // RVA: 0x7FFD5540BF90
        public void RegisterAssembly(){} // RVA: 0x7FFD5540C2A0
        public void BindToName(){} // RVA: 0x7FFD5540C820
        public void ContainsType(){} // RVA: 0x7FFD5540D140
        public void BindToType(){} // RVA: 0x7FFD5540D350
        public void ParseTypeName(){} // RVA: 0x7FFD5540D730
        public void ParseName(){} // RVA: 0x7FFD5540DF60
        public void ParseGenericAndOrArrayType(){} // RVA: 0x7FFD5540E290
        public void TryParseGenericAndOrArrayTypeName(){} // RVA: 0x7FFD5540E9C0
        public void Peek(){} // RVA: 0x7FFD5540EE90
        public void ReadGenericArg(){} // RVA: 0x7FFD5540EEE0
        public void .ctor(){} // RVA: 0x7FFD5540EFF0
    }

    public class DelegateFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFD55402420
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class DelegateFormatter`1 : BaseFormatter`1
    {
        public System.Type DelegateType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E2ADC40
    }

    public class DerivedDictionaryFormatter`3 : BaseFormatter`1
    {
        public bool KeyIsValueType;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Collections.Generic.IEqualityComparer`1<V>> EqualityComparerSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<V> KeyReaderWriter;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> ValueReaderWriter;
        public System.Reflection.ConstructorInfo ComparerConstructor;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E2ADC40
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
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
        public void .ctor(){} // RVA: 0x7FFD5540F410 | overloaded x4
        public void get_Binder(){} // RVA: 0x7FFD5540F690
        public void set_Binder(){} // RVA: 0x7FFD4E5F0C20
        public void get_StringReferenceResolver(){} // RVA: 0x7FFD4E3BE740
        public void set_StringReferenceResolver(){} // RVA: 0x7FFD4E369200
        public void get_GuidReferenceResolver(){} // RVA: 0x7FFD4E3BC730
        public void set_GuidReferenceResolver(){} // RVA: 0x7FFD4E3BC740
        public void get_IndexReferenceResolver(){} // RVA: 0x7FFD4E3E20E0
        public void set_IndexReferenceResolver(){} // RVA: 0x7FFD4E4994D0
        public void get_StreamingContext(){} // RVA: 0x7FFD4FE39630
        public void get_FormatterConverter(){} // RVA: 0x7FFD4E5F95E0
        public void get_Config(){} // RVA: 0x7FFD5540F750
        public void set_Config(){} // RVA: 0x7FFD4E342E30
        public void RegisterInternalReference(){} // RVA: 0x7FFD5540F800
        public void GetInternalReference(){} // RVA: 0x7FFD5540F890
        public void GetExternalObject(){} // RVA: 0x7FFD5540FD70 | overloaded x3
        public void Reset(){} // RVA: 0x7FFD5540FF70
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFD55410120
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFD4E341310
    }

    public class DictionaryFormatter`2 : BaseFormatter`1
    {
        public bool KeyIsValueType;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Collections.Generic.IEqualityComparer`1<U>> EqualityComparerSerializer;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<U> KeyReaderWriter;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> ValueReaderWriter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E078E90
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
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
        public void .cctor(){} // RVA: 0x7FFD55430D20
        public void LogInvalidKeyPathProvider(){} // RVA: 0x7FFD55432D50
        public void GetPersistentPathKeyTypes(){} // RVA: 0x7FFD55432F00
        public void KeyTypeSupportsPersistentPaths(){} // RVA: 0x7FFD55432F50
        public void PrivateIsSupportedDictionaryKeyType(){} // RVA: 0x7FFD554331B0
        public void GetDictionaryKeyString(){} // RVA: 0x7FFD554332D0
        public void GetDictionaryKeyValue(){} // RVA: 0x7FFD55434980
        public void FromTo(){} // RVA: 0x7FFD554356C0
    }

    public class DoubleLookupDictionaryFormatter`3 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<U> PrimaryReaderWriter;
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<System.Collections.Generic.Dictionary`2<V,T>> InnerReaderWriter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E078E90
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
    }

    public class DoubleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD554237F0
        public void WriteValue(){} // RVA: 0x7FFD554245C0
        public void .ctor(){} // RVA: 0x7FFD55424630
    }

}