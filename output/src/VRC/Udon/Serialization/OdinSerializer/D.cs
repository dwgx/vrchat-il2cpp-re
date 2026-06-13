// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 14
// Methods: 94

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class DateTimeFormatter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x785E2B0
        public void Write(){} // RVA: 0x785E720
        public void .ctor(){} // RVA: 0x785E7B0
    }

    public class DateTimeOffsetFormatter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x785E810
        public void Write(){} // RVA: 0x785E9C0
        public void .ctor(){} // RVA: 0x785EAF0
    }

    public class DebugContext
    {
        public object LOCK; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.ILogger logger; // 0x18
        public 0x65940460 loggingPolicy; // 0x20

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7870E40
        public void set_Logger(){} // RVA: 0x78706F0
        public void get_LoggingPolicy(){} // RVA: 0x7871030
        public void set_LoggingPolicy(){} // RVA: 0x7871040
        public void get_ErrorHandlingPolicy(){} // RVA: 0x5F257D0
        public void set_ErrorHandlingPolicy(){} // RVA: 0x5F257E0
        public void LogWarning(){} // RVA: 0x7871050
        public void LogError(){} // RVA: 0x7871150
        public void LogException(){} // RVA: 0x7871250
        public void ResetToDefault(){} // RVA: 0x7871430
        public void .ctor(){} // RVA: 0x78715D0
    }

    public class DecimalSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x78790D0
        public void WriteValue(){} // RVA: 0x78794F0
        public void .ctor(){} // RVA: 0x78795D0
    }

    public class DefaultLoggers
    {
        public object LOCK;
        public VRC.Udon.Serialization.OdinSerializer.ILogger unityLogger; // 0x8

        // ── Methods ──
        public void get_DefaultLogger(){} // RVA: 0x7860800
        public void get_UnityLogger(){} // RVA: 0x7860850
        public void .cctor(){} // RVA: 0x7860D00
    }

    public class DefaultSerializationBinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7860DB0
        public void RegisterAllQueuedAssembliesRepeating(){} // RVA: 0x7861A80
        public void RegisterQueuedAssemblies(){} // RVA: 0x7861B00
        public void RegisterQueuedAssemblyLoadEvents(){} // RVA: 0x7861DE0
        public void RegisterAssembly(){} // RVA: 0x78620F0
        public void BindToName(){} // RVA: 0x7862670
        public void ContainsType(){} // RVA: 0x7862F90
        public void BindToType(){} // RVA: 0x78631A0
        public void ParseTypeName(){} // RVA: 0x7863580
        public void ParseName(){} // RVA: 0x7863DB0
        public void ParseGenericAndOrArrayType(){} // RVA: 0x78640E0
        public void TryParseGenericAndOrArrayTypeName(){} // RVA: 0x7864810
        public void Peek(){} // RVA: 0x7864CE0
        public void ReadGenericArg(){} // RVA: 0x7864D30
        public void .ctor(){} // RVA: 0x7864E40
    }

    public class DelegateFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7858250
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DelegateFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void DeserializeImplementation(){} // RVA: 0x2DC60
        public void SerializeImplementation(){} // RVA: 0x2DC60
        public void GetUninitializedObject(){} // RVA: 0x283FA0
    }

    public class DerivedDictionaryFormatter`3
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void .ctor(){} // RVA: 0x24A50
        public void GetUninitializedObject(){} // RVA: 0x283FA0
        public void DeserializeImplementation(){} // RVA: 0x2DC60
        public void SerializeImplementation(){} // RVA: 0x2DC60
    }

    public class DeserializationContext
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationConfig config; // 0x10
        public System.Collections.Generic.Dictionary`2<int,object> internalIdReferenceMap; // 0x18
        public System.Runtime.Serialization.StreamingContext streamingContext; // 0x20
        public System.Runtime.Serialization.IFormatterConverter formatterConverter; // 0x30
        public VRC.Udon.Serialization.OdinSerializer.TwoWaySerializationBinder binder; // 0x38
        public VRC.Udon.Serialization.OdinSerializer.IExternalStringReferenceResolver <StringReferenceResolver>k__BackingField; // 0x40
        public VRC.Udon.Serialization.OdinSerializer.IExternalGuidReferenceResolver <GuidReferenceResolver>k__BackingField; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7865260 | overloaded x4
        public void get_Binder(){} // RVA: 0x78654E0
        public void set_Binder(){} // RVA: 0x49B830
        public void get_StringReferenceResolver(){} // RVA: 0x35A740
        public void set_StringReferenceResolver(){} // RVA: 0x305200
        public void get_GuidReferenceResolver(){} // RVA: 0x358730
        public void set_GuidReferenceResolver(){} // RVA: 0x358740
        public void get_IndexReferenceResolver(){} // RVA: 0x37E0E0
        public void set_IndexReferenceResolver(){} // RVA: 0x4354D0
        public void get_StreamingContext(){} // RVA: 0x1EFB630
        public void get_FormatterConverter(){} // RVA: 0x6374D0
        public void get_Config(){} // RVA: 0x78655A0
        public void set_Config(){} // RVA: 0x2DEE30
        public void RegisterInternalReference(){} // RVA: 0x7865650
        public void GetInternalReference(){} // RVA: 0x78656E0
        public void GetExternalObject(){} // RVA: 0x7865BC0 | overloaded x3
        public void Reset(){} // RVA: 0x7865DC0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7865F70
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x2DD310
    }

    public class DictionaryFormatter`2
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void .ctor(){} // RVA: 0x24A50
        public void GetUninitializedObject(){} // RVA: 0xCD60
        public void DeserializeImplementation(){} // RVA: 0x2DC60
        public void SerializeImplementation(){} // RVA: 0x2DC60
    }

    public class DictionaryKeyUtility
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7886B70
        public void LogInvalidKeyPathProvider(){} // RVA: 0x7888BA0
        public void GetPersistentPathKeyTypes(){} // RVA: 0x7888D50
        public void KeyTypeSupportsPersistentPaths(){} // RVA: 0x7888DA0
        public void PrivateIsSupportedDictionaryKeyType(){} // RVA: 0x7889000
        public void GetDictionaryKeyString(){} // RVA: 0x7889120
        public void GetDictionaryKeyValue(){} // RVA: 0x788A7D0
        public void FromTo(){} // RVA: 0x788B510
    }

    public class DoubleLookupDictionaryFormatter`3
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void .ctor(){} // RVA: 0x24A50
        public void GetUninitializedObject(){} // RVA: 0xCD60
        public void SerializeImplementation(){} // RVA: 0x2DC60
        public void DeserializeImplementation(){} // RVA: 0x2DC60
    }

    public class DoubleSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7879640
        public void WriteValue(){} // RVA: 0x787A410
        public void .ctor(){} // RVA: 0x787A480
    }

}