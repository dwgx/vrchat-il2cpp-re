// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 22
// Methods: 122

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class IAskIfCanFormatTypes
    {
        // ── Methods ──
        public void CanFormatType(){} // RVA: 0x87D350
    }

    public class IDataReader
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x87C0A0
        public void set_Binder(){} // RVA: 0x894320
        public void get_Stream(){} // RVA: 0x87C0A0
        public void set_Stream(){} // RVA: 0x894320
        public void get_IsInArrayNode(){} // RVA: 0x87D280
        public void get_CurrentNodeName(){} // RVA: 0x87C0A0
        public void get_CurrentNodeId(){} // RVA: 0x87C130
        public void get_CurrentNodeDepth(){} // RVA: 0x87C130
        public void get_Context(){} // RVA: 0x87C0A0
        public void set_Context(){} // RVA: 0x894320
        public void GetDataDump(){} // RVA: 0x87C0A0
        public void EnterNode(){} // RVA: 0x87D350
        public void ExitNode(){} // RVA: 0x87D280
        public void EnterArray(){} // RVA: 0x87D350
        public void ExitArray(){} // RVA: 0x87D280
        public void ReadPrimitiveArray(){} // RVA: 0x87D350
        public void PeekEntry(){} // RVA: 0x87D350
        public void ReadInternalReference(){} // RVA: 0x87D350
        public void ReadExternalReference(){} // RVA: 0x87D350
        public void ReadChar(){} // RVA: 0x87D350
        public void ReadString(){} // RVA: 0x87D350
        public void ReadGuid(){} // RVA: 0x87D350
        public void ReadSByte(){} // RVA: 0x87D350
        public void ReadInt16(){} // RVA: 0x87D350
        public void ReadInt32(){} // RVA: 0x87D350
        public void ReadInt64(){} // RVA: 0x87D350
        public void ReadByte(){} // RVA: 0x87D350
        public void ReadUInt16(){} // RVA: 0x87D350
        public void ReadUInt32(){} // RVA: 0x87D350
        public void ReadUInt64(){} // RVA: 0x87D350
        public void ReadDecimal(){} // RVA: 0x87D350
        public void ReadSingle(){} // RVA: 0x87D350
        public void ReadDouble(){} // RVA: 0x87D350
        public void ReadBoolean(){} // RVA: 0x87D350
        public void ReadNull(){} // RVA: 0x87D280
        public void SkipEntry(){} // RVA: 0x894290
        public void PrepareNewSerializationSession(){} // RVA: 0x894290
    }

    public class IDataWriter
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x87C0A0
        public void set_Binder(){} // RVA: 0x894320
        public void get_Stream(){} // RVA: 0x87C0A0
        public void set_Stream(){} // RVA: 0x894320
        public void get_IsInArrayNode(){} // RVA: 0x87D280
        public void get_Context(){} // RVA: 0x87C0A0
        public void set_Context(){} // RVA: 0x894320
        public void GetDataDump(){} // RVA: 0x87C0A0
        public void FlushToStream(){} // RVA: 0x894290
        public void BeginReferenceNode(){} // RVA: 0x895FE0
        public void BeginStructNode(){} // RVA: 0x8943B0
        public void EndNode(){} // RVA: 0x894320
        public void BeginArrayNode(){} // RVA: 0x8943F0
        public void EndArrayNode(){} // RVA: 0x894290
        public void WritePrimitiveArray(){} // RVA: 0x894320
        public void WriteNull(){} // RVA: 0x894320
        public void WriteInternalReference(){} // RVA: 0x899290
        public void WriteExternalReference(){} // RVA: 0x8943B0
        public void WriteChar(){} // RVA: 0x899B50
        public void WriteString(){} // RVA: 0x8943B0
        public void WriteGuid(){} // RVA: 0x8943B0
        public void WriteSByte(){} // RVA: 0x899250
        public void WriteInt16(){} // RVA: 0x899B50
        public void WriteInt32(){} // RVA: 0x899290
        public void WriteInt64(){} // RVA: 0x899C90
        public void WriteByte(){} // RVA: 0x899250
        public void WriteUInt16(){} // RVA: 0x899B50
        public void WriteUInt32(){} // RVA: 0x899290
        public void WriteUInt64(){} // RVA: 0x899C90
        public void WriteDecimal(){} // RVA: 0x8943B0
        public void WriteSingle(){} // RVA: 0x899A40
        public void WriteDouble(){} // RVA: 0x89ACE0
        public void WriteBoolean(){} // RVA: 0x899250
        public void PrepareNewSerializationSession(){} // RVA: 0x894290
    }

    public class IDictionaryKeyPathProvider
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x87C0A0
        public void GetPathStringFromKey(){} // RVA: 0x87C540
        public void GetKeyFromPathString(){} // RVA: 0x87C540
        public void Compare(){} // RVA: 0x881CA0
    }

    public class IDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void GetPathStringFromKey(){} // RVA: 0xA94080
        public void GetKeyFromPathString(){} // RVA: 0xA94080
        public void Compare(){} // RVA: 0xA94080
    }

    public class IExternalGuidReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x87C0A0
        public void set_NextResolver(){} // RVA: 0x894320
        public void TryResolveReference(){} // RVA: 0x87D3C0
        public void CanReference(){} // RVA: 0x87D3C0
    }

    public class IExternalIndexReferenceResolver
    {
        // ── Methods ──
        public void TryResolveReference(){} // RVA: 0x87E350
        public void CanReference(){} // RVA: 0x87D3C0
    }

    public class IExternalStringReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x87C0A0
        public void set_NextResolver(){} // RVA: 0x894320
        public void TryResolveReference(){} // RVA: 0x87D3C0
        public void CanReference(){} // RVA: 0x87D3C0
    }

    public class IFormatter
    {
        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x87C0A0
        public void Serialize(){} // RVA: 0x8943B0
        public void Deserialize(){} // RVA: 0x87C540
    }

    public class IFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x880310
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0xA94080
        public void Deserialize(){} // RVA: 0xA94080
    }

    public class ILogger
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x894320
        public void LogError(){} // RVA: 0x894320
        public void LogException(){} // RVA: 0x894320
    }

    public class IOverridesSerializationFormat
    {
        // ── Methods ──
        public void GetFormatToSerializeAs(){} // RVA: 0x882F70
    }

    public class IOverridesSerializationPolicy
    {
        // ── Methods ──
        public void get_SerializationPolicy(){} // RVA: 0x87C0A0
        public void get_OdinSerializesUnityFields(){} // RVA: 0x87D280
    }

    public class ISelfFormatter
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x894320
        public void Deserialize(){} // RVA: 0x894320
    }

    public class ISerializableFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x849A290
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ISerializationPolicy
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x87C0A0
        public void get_AllowNonSerializableTypes(){} // RVA: 0x87D280
        public void ShouldSerializeMember(){} // RVA: 0x87D350
    }

    public class ISupportsPrefabSerialization
    {
        // ── Methods ──
        public void get_SerializationData(){} // RVA: 0x87BEB0
        public void set_SerializationData(){} // RVA: 0xA94080
    }

    public class Int16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B77C0
        public void WriteValue(){} // RVA: 0x84B8430
        public void .ctor(){} // RVA: 0x84B84A0
    }

    public class Int32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B8510
        public void WriteValue(){} // RVA: 0x84B9180
        public void .ctor(){} // RVA: 0x84B91F0
    }

    public class Int64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B9260
        public void WriteValue(){} // RVA: 0x84B9E70
        public void .ctor(){} // RVA: 0x84B9EE0
    }

    public class IntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B9F50
        public void WriteValue(){} // RVA: 0x84BAB60
        public void .ctor(){} // RVA: 0x84BABD0
    }

}