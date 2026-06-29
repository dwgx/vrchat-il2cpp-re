// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 39
// Methods: 156

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class IAskIfCanFormatTypes
    {
        // ── Methods ──
        public void CanFormatType(){} // RVA: 0x7A7E019D0
    }

    public class IDataReader
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7A7E00680
        public void set_Binder(){} // RVA: 0x7A7E18800
        public void get_Stream(){} // RVA: 0x7A7E00680
        public void set_Stream(){} // RVA: 0x7A7E18800
        public void get_IsInArrayNode(){} // RVA: 0x7A7E01900
        public void get_CurrentNodeName(){} // RVA: 0x7A7E00680
        public void get_CurrentNodeId(){} // RVA: 0x7A7E00710
        public void get_CurrentNodeDepth(){} // RVA: 0x7A7E00710
        public void get_Context(){} // RVA: 0x7A7E00680
        public void set_Context(){} // RVA: 0x7A7E18800
        public void GetDataDump(){} // RVA: 0x7A7E00680
        public void EnterNode(){} // RVA: 0x7A7E019D0
        public void ExitNode(){} // RVA: 0x7A7E01900
        public void EnterArray(){} // RVA: 0x7A7E019D0
        public void ExitArray(){} // RVA: 0x7A7E01900
        public void ReadPrimitiveArray(){} // RVA: 0x7A7E019D0
        public void PeekEntry(){} // RVA: 0x7A7E019D0
        public void ReadInternalReference(){} // RVA: 0x7A7E019D0
        public void ReadExternalReference(){} // RVA: 0x7A7E019D0
        public void ReadChar(){} // RVA: 0x7A7E019D0
        public void ReadString(){} // RVA: 0x7A7E019D0
        public void ReadGuid(){} // RVA: 0x7A7E019D0
        public void ReadSByte(){} // RVA: 0x7A7E019D0
        public void ReadInt16(){} // RVA: 0x7A7E019D0
        public void ReadInt32(){} // RVA: 0x7A7E019D0
        public void ReadInt64(){} // RVA: 0x7A7E019D0
        public void ReadByte(){} // RVA: 0x7A7E019D0
        public void ReadUInt16(){} // RVA: 0x7A7E019D0
        public void ReadUInt32(){} // RVA: 0x7A7E019D0
        public void ReadUInt64(){} // RVA: 0x7A7E019D0
        public void ReadDecimal(){} // RVA: 0x7A7E019D0
        public void ReadSingle(){} // RVA: 0x7A7E019D0
        public void ReadDouble(){} // RVA: 0x7A7E019D0
        public void ReadBoolean(){} // RVA: 0x7A7E019D0
        public void ReadNull(){} // RVA: 0x7A7E01900
        public void SkipEntry(){} // RVA: 0x7A7E18770
        public void PrepareNewSerializationSession(){} // RVA: 0x7A7E18770
    }

    public class IDataWriter
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7A7E00680
        public void set_Binder(){} // RVA: 0x7A7E18800
        public void get_Stream(){} // RVA: 0x7A7E00680
        public void set_Stream(){} // RVA: 0x7A7E18800
        public void get_IsInArrayNode(){} // RVA: 0x7A7E01900
        public void get_Context(){} // RVA: 0x7A7E00680
        public void set_Context(){} // RVA: 0x7A7E18800
        public void GetDataDump(){} // RVA: 0x7A7E00680
        public void FlushToStream(){} // RVA: 0x7A7E18770
        public void BeginReferenceNode(){} // RVA: 0x7A7E1A470
        public void BeginStructNode(){} // RVA: 0x7A7E18890
        public void EndNode(){} // RVA: 0x7A7E18800
        public void BeginArrayNode(){} // RVA: 0x7A7E188D0
        public void EndArrayNode(){} // RVA: 0x7A7E18770
        public void WritePrimitiveArray(){} // RVA: 0x7A7E18800
        public void WriteNull(){} // RVA: 0x7A7E18800
        public void WriteInternalReference(){} // RVA: 0x7A7E1D590
        public void WriteExternalReference(){} // RVA: 0x7A7E18890
        public void WriteChar(){} // RVA: 0x7A7E1DEA0
        public void WriteString(){} // RVA: 0x7A7E18890
        public void WriteGuid(){} // RVA: 0x7A7E18890
        public void WriteSByte(){} // RVA: 0x7A7E1D550
        public void WriteInt16(){} // RVA: 0x7A7E1DEA0
        public void WriteInt32(){} // RVA: 0x7A7E1D590
        public void WriteInt64(){} // RVA: 0x7A7E1DFE0
        public void WriteByte(){} // RVA: 0x7A7E1D550
        public void WriteUInt16(){} // RVA: 0x7A7E1DEA0
        public void WriteUInt32(){} // RVA: 0x7A7E1D590
        public void WriteUInt64(){} // RVA: 0x7A7E1DFE0
        public void WriteDecimal(){} // RVA: 0x7A7E18890
        public void WriteSingle(){} // RVA: 0x7A7E1DD40
        public void WriteDouble(){} // RVA: 0x7A7E1F070
        public void WriteBoolean(){} // RVA: 0x7A7E1D550
        public void PrepareNewSerializationSession(){} // RVA: 0x7A7E18770
    }

    public class IDictionaryKeyPathProvider
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7A7E00680
        public void GetPathStringFromKey(){} // RVA: 0x7A7E00B20
        public void GetKeyFromPathString(){} // RVA: 0x7A7E00B20
        public void Compare(){} // RVA: 0x7A7E06320
    }

    public class IDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void GetPathStringFromKey(){} // RVA: 0x7A8051B10
        public void GetKeyFromPathString(){} // RVA: 0x7A8051B10
        public void Compare(){} // RVA: 0x7A8051B10
    }

    public class IExternalGuidReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x7A7E00680
        public void set_NextResolver(){} // RVA: 0x7A7E18800
        public void TryResolveReference(){} // RVA: 0x7A7E01A40
        public void CanReference(){} // RVA: 0x7A7E01A40
    }

    public class IExternalIndexReferenceResolver
    {
        // ── Methods ──
        public void TryResolveReference(){} // RVA: 0x7A7E029D0
        public void CanReference(){} // RVA: 0x7A7E01A40
    }

    public class IExternalStringReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x7A7E00680
        public void set_NextResolver(){} // RVA: 0x7A7E18800
        public void TryResolveReference(){} // RVA: 0x7A7E01A40
        public void CanReference(){} // RVA: 0x7A7E01A40
    }

    public class IFormatter
    {
        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7A7E00680
        public void Serialize(){} // RVA: 0x7A7E18890
        public void Deserialize(){} // RVA: 0x7A7E00B20
    }

    public class IFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7A7E03A70
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7A8051B10
        public void Deserialize(){} // RVA: 0x7A8051B10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00560
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7A7E00B20
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class ILogger
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x7A7E18800
        public void LogError(){} // RVA: 0x7A7E18800
        public void LogException(){} // RVA: 0x7A7E18800
    }

    public class IOverridesSerializationFormat
    {
        // ── Methods ──
        public void GetFormatToSerializeAs(){} // RVA: 0x7A7E075B0
    }

    public class IOverridesSerializationPolicy
    {
        // ── Methods ──
        public void get_SerializationPolicy(){} // RVA: 0x7A7E00680
        public void get_OdinSerializesUnityFields(){} // RVA: 0x7A7E01900
    }

    public class ISelfFormatter
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7A7E18800
        public void Deserialize(){} // RVA: 0x7A7E18800
    }

    public class ISerializableFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7AF63C7A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ISerializationPolicy
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7A7E00680
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7A7E01900
        public void ShouldSerializeMember(){} // RVA: 0x7A7E019D0
    }

    public class ISupportsPrefabSerialization
    {
        // ── Methods ──
        public void get_SerializationData(){} // RVA: 0x7A7E00490
        public void set_SerializationData(){} // RVA: 0x7A8051B10
    }

    public class Int16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF65A3E0
        public void WriteValue(){} // RVA: 0x7AF65B0E0
        public void .ctor(){} // RVA: 0x7AF65B150
    }

    public class Int32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF65B1C0
        public void WriteValue(){} // RVA: 0x7AF65BEC0
        public void .ctor(){} // RVA: 0x7AF65BF30
    }

    public class Int64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF65BFA0
        public void WriteValue(){} // RVA: 0x7AF65CC30
        public void .ctor(){} // RVA: 0x7AF65CCA0
    }

    public class IntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF65CD10
        public void WriteValue(){} // RVA: 0x7AF65D9A0
        public void .ctor(){} // RVA: 0x7AF65DA10
    }

}