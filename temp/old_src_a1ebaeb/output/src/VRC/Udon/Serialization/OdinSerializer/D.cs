// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 13
// Methods: 83

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class DateTimeFormatter : MinimalBaseFormatter`1
    {
        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaafa0aea0
        public void Write(){} // RVA: 0x7ffaafa0b310
        public void .ctor(){} // RVA: 0x7ffaafa0b3a0
    }

    public class DateTimeOffsetFormatter : MinimalBaseFormatter`1
    {
        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaafa0b400
        public void Write(){} // RVA: 0x7ffaafa0b5b0
        public void .ctor(){} // RVA: 0x7ffaafa0b6e0
    }

    public class DecimalSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa25ca0
        public void WriteValue(){} // RVA: 0x7ffaafa260c0
        public void .ctor(){} // RVA: 0x7ffaafa261a0
    }

    public class DefaultLoggers : Object
    {
        // ── Original Methods ──
        public void get_DefaultLogger(){} // RVA: 0x7ffaafa0d3d0
        public void get_UnityLogger(){} // RVA: 0x7ffaafa0d420
        public void .cctor(){} // RVA: 0x7ffaafa0d8d0
    }

    public class DefaultSerializationBinder : TwoWaySerializationBinder
    {
        public object customTypeNameToTypeBindings; // 0x339951A0
        public object NAMETOTYPE_LOCK; // 0x339951A0
        public object assembliesQueuedForRegister; // 0x339951A0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaafa0d980
        public void RegisterAllQueuedAssembliesRepeating(){} // RVA: 0x7ffaafa0e650
        public void RegisterQueuedAssemblies(){} // RVA: 0x7ffaafa0e6d0
        public void RegisterQueuedAssemblyLoadEvents(){} // RVA: 0x7ffaafa0e9b0
        public void RegisterAssembly(){} // RVA: 0x7ffaafa0ecc0
        public void BindToName(){} // RVA: 0x7ffaafa0f240
        public void ContainsType(){} // RVA: 0x7ffaafa0fb60
        public void BindToType(){} // RVA: 0x7ffaafa0fd70
        public void ParseTypeName(){} // RVA: 0x7ffaafa10150
        public void ParseName(){} // RVA: 0x7ffaafa10980
        public void ParseGenericAndOrArrayType(){} // RVA: 0x7ffaafa10cb0
        public void TryParseGenericAndOrArrayTypeName(){} // RVA: 0x7ffaafa113e0
        public void Peek(){} // RVA: 0x7ffaafa118b0
        public void ReadGenericArg(){} // RVA: 0x7ffaafa11900
        public void .ctor(){} // RVA: 0x7ffaafa11a10
    }

    public class DelegateFormatterLocator : Object
    {
        // ── Original Methods ──
        public void TryGetFormatter(){} // RVA: 0x7ffaafa04e40
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class DelegateFormatter`1 : BaseFormatter`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaa887e5c0
    }

    public class DerivedDictionaryFormatter`3 : BaseFormatter`1
    {
        public object KeyReaderWriter; // 0x30E6E470

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaa887e5c0
    }

    public class DeserializationContext : Object
    {
        public object streamingContext; // 0x33AE5540
        public object _stringReferenceResolver; // 0x33AE5540, was: <StringReferenceResolver>k__Ba

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaafa11e30
        public void .ctor(){} // RVA: 0x7ffaafa11e30
        public void .ctor(){} // RVA: 0x7ffaafa11e30
        public void .ctor(){} // RVA: 0x7ffaafa11e30
        public void get_Binder(){} // RVA: 0x7ffaafa120b0
        public void set_Binder(){} // RVA: 0x7ffaa8bf45c0
        public void get_StringReferenceResolver(){} // RVA: 0x7ffaa89af740
        public void set_StringReferenceResolver(){} // RVA: 0x7ffaa895a200
        public void get_GuidReferenceResolver(){} // RVA: 0x7ffaa89ad730
        public void set_GuidReferenceResolver(){} // RVA: 0x7ffaa89ad740
        public void get_IndexReferenceResolver(){} // RVA: 0x7ffaa89d30e0
        public void set_IndexReferenceResolver(){} // RVA: 0x7ffaa8a8a4d0
        public void get_StreamingContext(){} // RVA: 0x7ffaaa4204b0
        public void get_FormatterConverter(){} // RVA: 0x7ffaa8bfcc80
        public void get_Config(){} // RVA: 0x7ffaafa12170
        public void set_Config(){} // RVA: 0x7ffaa8933e30
        public void RegisterInternalReference(){} // RVA: 0x7ffaafa12220
        public void Reset(){} // RVA: 0x7ffaafa12990
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7ffaafa12b40
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetInternalReference(){} // RVA: 0x7ffaafa122b0
        public void GetExternalObject(){} // RVA: 0x7ffaafa12790
        public void GetExternalObject(){} // RVA: 0x7ffaafa12790
        public void GetExternalObject(){} // RVA: 0x7ffaafa12790
    }

    public class DictionaryFormatter`2 : BaseFormatter`1
    {
        public object KeyReaderWriter; // 0x30E84990

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaa86491d0
    }

    public class DictionaryKeyUtility : Object
    {
        public object AllowedSpecialKeyStrChars; // 0x30FB6B60
        public object ProviderToID; // 0x30FB6B60
        public object tempKeyCounter; // 0x30FB6B60

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaafa33740
        public void LogInvalidKeyPathProvider(){} // RVA: 0x7ffaafa35770
        public void KeyTypeSupportsPersistentPaths(){} // RVA: 0x7ffaafa35970
        public void PrivateIsSupportedDictionaryKeyType(){} // RVA: 0x7ffaafa35bd0
        public void FromTo(){} // RVA: 0x7ffaafa380e0
        // ── Binary Analysis Named ──
        public void GetPersistentPathKeyTypes(){} // RVA: 0x7ffaafa35920
        public void GetDictionaryKeyString(){} // RVA: 0x7ffaafa35cf0
        public void GetDictionaryKeyValue(){} // RVA: 0x7ffaafa373a0
    }

    public class DoubleLookupDictionaryFormatter`3 : BaseFormatter`1
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaa86491d0
    }

    public class DoubleSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa26210
        public void WriteValue(){} // RVA: 0x7ffaafa26fe0
        public void .ctor(){} // RVA: 0x7ffaafa27050
    }

}