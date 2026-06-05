// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 100
// Methods: 139

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class IAskIfCanFormatTypes
    {
        // ── Methods ──
        public void CanFormatType(){} // RVA: 0x7FFAF2ABDE40
    }

    public class IDataReader
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFAF2ABCD60
        public void set_Binder(){} // RVA: 0x7FFAF2AD4B10
        public void get_Stream(){} // RVA: 0x7FFAF2ABCD60
        public void set_Stream(){} // RVA: 0x7FFAF2AD4B10
        public void get_IsInArrayNode(){} // RVA: 0x7FFAF2ABDBE0
        public void get_CurrentNodeName(){} // RVA: 0x7FFAF2ABCD60
        public void get_CurrentNodeId(){} // RVA: 0x7FFAF2ABD840
        public void get_CurrentNodeDepth(){} // RVA: 0x7FFAF2ABD840
        public void get_Context(){} // RVA: 0x7FFAF2ABCD60
        public void set_Context(){} // RVA: 0x7FFAF2AD4B10
        public void GetDataDump(){} // RVA: 0x7FFAF2ABCD60
        public void EnterNode(){} // RVA: 0x7FFAF2ABDE40
        public void ExitNode(){} // RVA: 0x7FFAF2ABDBE0
        public void EnterArray(){} // RVA: 0x7FFAF2ABDE40
        public void ExitArray(){} // RVA: 0x7FFAF2ABDBE0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAF2ABDE40
        public void PeekEntry(){} // RVA: 0x7FFAF2ABDE40
        public void ReadInternalReference(){} // RVA: 0x7FFAF2ABDE40
        public void ReadExternalReference(){} // RVA: 0x7FFAF2ABDE40 | overloaded x3
        public void ReadChar(){} // RVA: 0x7FFAF2ABDE40
        public void ReadString(){} // RVA: 0x7FFAF2ABDE40
        public void ReadGuid(){} // RVA: 0x7FFAF2ABDE40
        public void ReadSByte(){} // RVA: 0x7FFAF2ABDE40
        public void ReadInt16(){} // RVA: 0x7FFAF2ABDE40
        public void ReadInt32(){} // RVA: 0x7FFAF2ABDE40
        public void ReadInt64(){} // RVA: 0x7FFAF2ABDE40
        public void ReadByte(){} // RVA: 0x7FFAF2ABDE40
        public void ReadUInt16(){} // RVA: 0x7FFAF2ABDE40
        public void ReadUInt32(){} // RVA: 0x7FFAF2ABDE40
        public void ReadUInt64(){} // RVA: 0x7FFAF2ABDE40
        public void ReadDecimal(){} // RVA: 0x7FFAF2ABDE40
        public void ReadSingle(){} // RVA: 0x7FFAF2ABDE40
        public void ReadDouble(){} // RVA: 0x7FFAF2ABDE40
        public void ReadBoolean(){} // RVA: 0x7FFAF2ABDE40
        public void ReadNull(){} // RVA: 0x7FFAF2ABDBE0
        public void SkipEntry(){} // RVA: 0x7FFAF2AD4A50
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IDataWriter
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFAF2ABCD60
        public void set_Binder(){} // RVA: 0x7FFAF2AD4B10
        public void get_Stream(){} // RVA: 0x7FFAF2ABCD60
        public void set_Stream(){} // RVA: 0x7FFAF2AD4B10
        public void get_IsInArrayNode(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Context(){} // RVA: 0x7FFAF2ABCD60
        public void set_Context(){} // RVA: 0x7FFAF2AD4B10
        public void GetDataDump(){} // RVA: 0x7FFAF2ABCD60
        public void FlushToStream(){} // RVA: 0x7FFAF2AD4A50
        public void BeginReferenceNode(){}
        public void BeginStructNode(){} // RVA: 0x7FFAF2ADDC60
        public void EndNode(){} // RVA: 0x7FFAF2AD4B10
        public void BeginArrayNode(){} // RVA: 0x7FFAF2AD4CC0
        public void EndArrayNode(){} // RVA: 0x7FFAF2AD4A50
        public void WritePrimitiveArray(){} // RVA: 0x7FFAF2AD4B10
        public void WriteNull(){} // RVA: 0x7FFAF2AD4B10
        public void WriteInternalReference(){} // RVA: 0x7FFAF2ADBAA0
        public void WriteExternalReference(){} // RVA: 0x7FFAF2ADDC60 | overloaded x3
        public void WriteChar(){}
        public void WriteString(){} // RVA: 0x7FFAF2ADDC60
        public void WriteGuid(){}
        public void WriteSByte(){}
        public void WriteInt16(){}
        public void WriteInt32(){} // RVA: 0x7FFAF2ADBAA0
        public void WriteInt64(){} // RVA: 0x7FFAF2ADA2D0
        public void WriteByte(){} // RVA: 0x7FFAF2ADA620
        public void WriteUInt16(){}
        public void WriteUInt32(){}
        public void WriteUInt64(){}
        public void WriteDecimal(){}
        public void WriteSingle(){} // RVA: 0x7FFAF2AE18E0
        public void WriteDouble(){}
        public void WriteBoolean(){} // RVA: 0x7FFAF2ADA620
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IDictionaryKeyPathProvider
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFAF2ABCD60
        public void GetPathStringFromKey(){} // RVA: 0x7FFAF2ABCE10
        public void GetKeyFromPathString(){} // RVA: 0x7FFAF2ABCE10
        public void Compare(){} // RVA: 0x7FFAF2AC7680
    }

    public class IDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void GetPathStringFromKey(){} // RVA: 0x7FFAF2D33FA0
        public void GetKeyFromPathString(){} // RVA: 0x7FFAF2D33FA0
        public void Compare(){} // RVA: 0x7FFAF2D33FA0
    }

    public class IDictionaryKeyPathProvider`1
    {
    }

    public class IDictionaryKeyPathProvider`1
    {
    }

    public class IDictionaryKeyPathProvider`1
    {
    }

    public class IDictionaryKeyPathProvider`1
    {
    }

    public class IExternalGuidReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x7FFAF2ABCD60
        public void set_NextResolver(){} // RVA: 0x7FFAF2AD4B10
        public void TryResolveReference(){}
        public void CanReference(){} // RVA: 0x7FFAF2AC1120
    }

    public class IExternalIndexReferenceResolver
    {
        // ── Methods ──
        public void TryResolveReference(){} // RVA: 0x7FFAF2ABF140
        public void CanReference(){} // RVA: 0x7FFAF2AC1120
    }

    public class IExternalStringReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x7FFAF2ABCD60
        public void set_NextResolver(){} // RVA: 0x7FFAF2AD4B10
        public void TryResolveReference(){} // RVA: 0x7FFAF2AC1120
        public void CanReference(){} // RVA: 0x7FFAF2AC1120
    }

    public class IFormatter
    {
        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7FFAF2ABCD60
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){}
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2D33FA0
        public void Deserialize(){} // RVA: 0x7FFAF2D33FA0
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){}
        public void Deserialize(){}
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ILogger
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x7FFAF2AD4B10
        public void LogError(){} // RVA: 0x7FFAF2AD4B10
        public void LogException(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IOverridesSerializationFormat
    {
        // ── Methods ──
        public void GetFormatToSerializeAs(){} // RVA: 0x7FFAF2AC3A30
    }

    public class IOverridesSerializationPolicy
    {
        // ── Methods ──
        public void get_SerializationPolicy(){} // RVA: 0x7FFAF2ABCD60
        public void get_OdinSerializesUnityFields(){} // RVA: 0x7FFAF2ABDBE0
    }

}