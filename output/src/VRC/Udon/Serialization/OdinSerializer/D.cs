// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 14
// Methods: 90

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class DateTimeFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7AF63D9F0
        public void Write(){} // RVA: 0x7AF63DDE0
        public void .ctor(){} // RVA: 0x7AF63DE70
    }

    public class DateTimeOffsetFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7AF63DED0
        public void Write(){} // RVA: 0x7AF63E000
        public void .ctor(){} // RVA: 0x7AF63E130
    }

    public class DebugContext : Object
    {
        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7AF6500B0
        public void set_Logger(){} // RVA: 0x7AF64FA20
        public void get_LoggingPolicy(){} // RVA: 0x7AF650270
        public void set_LoggingPolicy(){} // RVA: 0x7AF650280
        public void get_ErrorHandlingPolicy(){} // RVA: 0x7ADD144F0
        public void set_ErrorHandlingPolicy(){} // RVA: 0x7ADD14500
        public void LogWarning(){} // RVA: 0x7AF650290
        public void LogError(){} // RVA: 0x7AF650390
        public void LogException(){} // RVA: 0x7AF650490
        public void ResetToDefault(){} // RVA: 0x7AF650670
        public void .ctor(){} // RVA: 0x7AF6507D0
    }

    public class DecimalSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF6582F0
        public void WriteValue(){} // RVA: 0x7AF658710
        public void .ctor(){} // RVA: 0x7AF6587F0
    }

    public class DefaultLoggers : Object
    {
        // ── Methods ──
        public void get_DefaultLogger(){} // RVA: 0x7AF63FD50
        public void get_UnityLogger(){} // RVA: 0x7AF63FDA0
        public void .cctor(){} // RVA: 0x7AF640210
    }

    public class DefaultSerializationBinder : TwoWaySerializationBinder
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF6402C0
        public void RegisterAllQueuedAssembliesRepeating(){} // RVA: 0x7AF640F60
        public void RegisterQueuedAssemblies(){} // RVA: 0x7AF640FE0
        public void RegisterQueuedAssemblyLoadEvents(){} // RVA: 0x7AF6412A0
        public void RegisterAssembly(){} // RVA: 0x7AF641590
        public void BindToName(){} // RVA: 0x7AF641AE0
        public void ContainsType(){} // RVA: 0x7AF6423D0
        public void BindToType(){} // RVA: 0x7AF6425A0
        public void ParseTypeName(){} // RVA: 0x7AF642950
        public void ParseName(){} // RVA: 0x7AF643100
        public void ParseGenericAndOrArrayType(){} // RVA: 0x7AF643440
        public void TryParseGenericAndOrArrayTypeName(){} // RVA: 0x7AF643B70
        public void Peek(){} // RVA: 0x7AF644040
        public void ReadGenericArg(){} // RVA: 0x7AF644090
        public void .ctor(){} // RVA: 0x7AF6441A0
        public void ASSEMBLY_LOOKUP_LOCK(){} // RVA: 0x7B3F8A398
    }

    public class DelegateFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7AF637A00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DelegateFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void GetUninitializedObject(){} // RVA: 0x7A8051B10
    }

    public class DerivedDictionaryFormatter`3 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void .ctor(){} // RVA: 0x7A7E18770
        public void GetUninitializedObject(){} // RVA: 0x7A8051B10
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
    }

    public class DeserializationContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF644590
        public void get_Binder(){} // RVA: 0x7AF644810
        public void set_Binder(){} // RVA: 0x7A8296DE0
        public void get_StringReferenceResolver(){} // RVA: 0x7A8154D80
        public void set_StringReferenceResolver(){} // RVA: 0x7A80FF440
        public void get_GuidReferenceResolver(){} // RVA: 0x7A8152D80
        public void set_GuidReferenceResolver(){} // RVA: 0x7A8152D90
        public void get_IndexReferenceResolver(){} // RVA: 0x7A8178B90
        public void set_IndexReferenceResolver(){} // RVA: 0x7A8230620
        public void get_StreamingContext(){} // RVA: 0x7A9D01C90
        public void get_FormatterConverter(){} // RVA: 0x7A83F69F0
        public void get_Config(){} // RVA: 0x7AF6448D0
        public void set_Config(){} // RVA: 0x7A80D8E20
        public void RegisterInternalReference(){} // RVA: 0x7AF644980
        public void GetInternalReference(){} // RVA: 0x7AF644A10
        public void GetExternalObject(){} // RVA: 0x7AF644EF0
        public void Reset(){} // RVA: 0x7AF6450F0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7AF6452A0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7A80D7310
    }

    public class DictionaryFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void .ctor(){} // RVA: 0x7A7E18770
        public void GetUninitializedObject(){} // RVA: 0x7A7E00680
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
    }

    public class DictionaryKeyUtility : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF665BF0
        public void LogInvalidKeyPathProvider(){} // RVA: 0x7AF667C40
        public void GetPersistentPathKeyTypes(){} // RVA: 0x7AF667DF0
        public void KeyTypeSupportsPersistentPaths(){} // RVA: 0x7AF667E40
        public void PrivateIsSupportedDictionaryKeyType(){} // RVA: 0x7AF6680A0
        public void GetDictionaryKeyString(){} // RVA: 0x7AF6681C0
        public void GetDictionaryKeyValue(){} // RVA: 0x7AF669860
        public void FromTo(){} // RVA: 0x7AF66A5A0
    }

    public class DoubleLookupDictionaryFormatter`3 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void .ctor(){} // RVA: 0x7A7E18770
        public void GetUninitializedObject(){} // RVA: 0x7A7E00680
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
    }

    public class DoubleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF658860
        public void WriteValue(){} // RVA: 0x7AF659560
        public void .ctor(){} // RVA: 0x7AF6595D0
    }

}