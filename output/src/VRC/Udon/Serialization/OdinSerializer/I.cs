// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 100
// Methods: 139

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class IAskIfCanFormatTypes
    {
        // ── Methods ──
        public void CanFormatType(){} // RVA: 0xDE40
    }

    public class IDataReader
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0xCD60
        public void set_Binder(){} // RVA: 0x24B10
        public void get_Stream(){} // RVA: 0xCD60
        public void set_Stream(){} // RVA: 0x24B10
        public void get_IsInArrayNode(){} // RVA: 0xDBE0
        public void get_CurrentNodeName(){} // RVA: 0xCD60
        public void get_CurrentNodeId(){} // RVA: 0xD840
        public void get_CurrentNodeDepth(){} // RVA: 0xD840
        public void get_Context(){} // RVA: 0xCD60
        public void set_Context(){} // RVA: 0x24B10
        public void GetDataDump(){} // RVA: 0xCD60
        public void EnterNode(){} // RVA: 0xDE40
        public void ExitNode(){} // RVA: 0xDBE0
        public void EnterArray(){} // RVA: 0xDE40
        public void ExitArray(){} // RVA: 0xDBE0
        public void ReadPrimitiveArray(){} // RVA: 0xDE40
        public void PeekEntry(){} // RVA: 0xDE40
        public void ReadInternalReference(){} // RVA: 0xDE40
        public void ReadExternalReference(){} // RVA: 0xDE40 | overloaded x3
        public void ReadChar(){} // RVA: 0xDE40
        public void ReadString(){} // RVA: 0xDE40
        public void ReadGuid(){} // RVA: 0xDE40
        public void ReadSByte(){} // RVA: 0xDE40
        public void ReadInt16(){} // RVA: 0xDE40
        public void ReadInt32(){} // RVA: 0xDE40
        public void ReadInt64(){} // RVA: 0xDE40
        public void ReadByte(){} // RVA: 0xDE40
        public void ReadUInt16(){} // RVA: 0xDE40
        public void ReadUInt32(){} // RVA: 0xDE40
        public void ReadUInt64(){} // RVA: 0xDE40
        public void ReadDecimal(){} // RVA: 0xDE40
        public void ReadSingle(){} // RVA: 0xDE40
        public void ReadDouble(){} // RVA: 0xDE40
        public void ReadBoolean(){} // RVA: 0xDE40
        public void ReadNull(){} // RVA: 0xDBE0
        public void SkipEntry(){} // RVA: 0x24A50
        public void PrepareNewSerializationSession(){} // RVA: 0x24A50
    }

    public class IDataWriter
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0xCD60
        public void set_Binder(){} // RVA: 0x24B10
        public void get_Stream(){} // RVA: 0xCD60
        public void set_Stream(){} // RVA: 0x24B10
        public void get_IsInArrayNode(){} // RVA: 0xDBE0
        public void get_Context(){} // RVA: 0xCD60
        public void set_Context(){} // RVA: 0x24B10
        public void GetDataDump(){} // RVA: 0xCD60
        public void FlushToStream(){} // RVA: 0x24A50
        public void BeginReferenceNode(){}
        public void BeginStructNode(){} // RVA: 0x2DC60
        public void EndNode(){} // RVA: 0x24B10
        public void BeginArrayNode(){} // RVA: 0x24CC0
        public void EndArrayNode(){} // RVA: 0x24A50
        public void WritePrimitiveArray(){} // RVA: 0x24B10
        public void WriteNull(){} // RVA: 0x24B10
        public void WriteInternalReference(){} // RVA: 0x2BAA0
        public void WriteExternalReference(){} // RVA: 0x2DC60 | overloaded x3
        public void WriteChar(){}
        public void WriteString(){} // RVA: 0x2DC60
        public void WriteGuid(){}
        public void WriteSByte(){}
        public void WriteInt16(){}
        public void WriteInt32(){} // RVA: 0x2BAA0
        public void WriteInt64(){} // RVA: 0x2A2D0
        public void WriteByte(){} // RVA: 0x2A620
        public void WriteUInt16(){}
        public void WriteUInt32(){}
        public void WriteUInt64(){}
        public void WriteDecimal(){}
        public void WriteSingle(){} // RVA: 0x318E0
        public void WriteDouble(){}
        public void WriteBoolean(){} // RVA: 0x2A620
        public void PrepareNewSerializationSession(){} // RVA: 0x24A50
    }

    public class IDictionaryKeyPathProvider
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0xCD60
        public void GetPathStringFromKey(){} // RVA: 0xCE10
        public void GetKeyFromPathString(){} // RVA: 0xCE10
        public void Compare(){} // RVA: 0x17680
    }

    public class IDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void GetPathStringFromKey(){} // RVA: 0x283FA0
        public void GetKeyFromPathString(){} // RVA: 0x283FA0
        public void Compare(){} // RVA: 0x283FA0
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
        public void get_NextResolver(){} // RVA: 0xCD60
        public void set_NextResolver(){} // RVA: 0x24B10
        public void TryResolveReference(){}
        public void CanReference(){} // RVA: 0x11120
    }

    public class IExternalIndexReferenceResolver
    {
        // ── Methods ──
        public void TryResolveReference(){} // RVA: 0xF140
        public void CanReference(){} // RVA: 0x11120
    }

    public class IExternalStringReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0xCD60
        public void set_NextResolver(){} // RVA: 0x24B10
        public void TryResolveReference(){} // RVA: 0x11120
        public void CanReference(){} // RVA: 0x11120
    }

    public class IFormatter
    {
        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0xCD60
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){}
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x283FA0
        public void Deserialize(){} // RVA: 0x283FA0
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
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
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
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
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
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
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
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
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
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x2DC60
        public void Deserialize(){} // RVA: 0xCE10
    }

    public class ILogger
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x24B10
        public void LogError(){} // RVA: 0x24B10
        public void LogException(){} // RVA: 0x24B10
    }

    public class IOverridesSerializationFormat
    {
        // ── Methods ──
        public void GetFormatToSerializeAs(){} // RVA: 0x13A30
    }

    public class IOverridesSerializationPolicy
    {
        // ── Methods ──
        public void get_SerializationPolicy(){} // RVA: 0xCD60
        public void get_OdinSerializesUnityFields(){} // RVA: 0xDBE0
    }

}