// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 22
// Methods: 126

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class IAskIfCanFormatTypes
    {
        // ── Methods ──
        public void CanFormatType(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IDataReader
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFE80E2E2E0
        public void set_Binder(){} // RVA: 0x7FFE80E460A0
        public void get_Stream(){} // RVA: 0x7FFE80E2E2E0
        public void set_Stream(){} // RVA: 0x7FFE80E460A0
        public void get_IsInArrayNode(){} // RVA: 0x7FFE80E2F150
        public void get_CurrentNodeName(){} // RVA: 0x7FFE80E2E2E0
        public void get_CurrentNodeId(){} // RVA: 0x7FFE80E2EDB0
        public void get_CurrentNodeDepth(){} // RVA: 0x7FFE80E2EDB0
        public void get_Context(){} // RVA: 0x7FFE80E2E2E0
        public void set_Context(){} // RVA: 0x7FFE80E460A0
        public void GetDataDump(){} // RVA: 0x7FFE80E2E2E0
        public void EnterNode(){} // RVA: 0x7FFE80E2F3B0
        public void ExitNode(){} // RVA: 0x7FFE80E2F150
        public void EnterArray(){} // RVA: 0x7FFE80E2F3B0
        public void ExitArray(){} // RVA: 0x7FFE80E2F150
        public void ReadPrimitiveArray(){} // RVA: 0x7FFE80E2F3B0
        public void PeekEntry(){} // RVA: 0x7FFE80E2F3B0
        public void ReadInternalReference(){} // RVA: 0x7FFE80E2F3B0
        public void ReadExternalReference(){} // RVA: 0x7FFE80E2F3B0 | overloaded x3
        public void ReadChar(){} // RVA: 0x7FFE80E2F3B0
        public void ReadString(){} // RVA: 0x7FFE80E2F3B0
        public void ReadGuid(){} // RVA: 0x7FFE80E2F3B0
        public void ReadSByte(){} // RVA: 0x7FFE80E2F3B0
        public void ReadInt16(){} // RVA: 0x7FFE80E2F3B0
        public void ReadInt32(){} // RVA: 0x7FFE80E2F3B0
        public void ReadInt64(){} // RVA: 0x7FFE80E2F3B0
        public void ReadByte(){} // RVA: 0x7FFE80E2F3B0
        public void ReadUInt16(){} // RVA: 0x7FFE80E2F3B0
        public void ReadUInt32(){} // RVA: 0x7FFE80E2F3B0
        public void ReadUInt64(){} // RVA: 0x7FFE80E2F3B0
        public void ReadDecimal(){} // RVA: 0x7FFE80E2F3B0
        public void ReadSingle(){} // RVA: 0x7FFE80E2F3B0
        public void ReadDouble(){} // RVA: 0x7FFE80E2F3B0
        public void ReadBoolean(){} // RVA: 0x7FFE80E2F3B0
        public void ReadNull(){} // RVA: 0x7FFE80E2F150
        public void SkipEntry(){} // RVA: 0x7FFE80E45FE0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE80E45FE0
    }

    public class IDataWriter
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFE80E2E2E0
        public void set_Binder(){} // RVA: 0x7FFE80E460A0
        public void get_Stream(){} // RVA: 0x7FFE80E2E2E0
        public void set_Stream(){} // RVA: 0x7FFE80E460A0
        public void get_IsInArrayNode(){} // RVA: 0x7FFE80E2F150
        public void get_Context(){} // RVA: 0x7FFE80E2E2E0
        public void set_Context(){} // RVA: 0x7FFE80E460A0
        public void GetDataDump(){} // RVA: 0x7FFE80E2E2E0
        public void FlushToStream(){} // RVA: 0x7FFE80E45FE0
        public void BeginReferenceNode(){}
        public void BeginStructNode(){} // RVA: 0x7FFE80E4F230
        public void EndNode(){} // RVA: 0x7FFE80E460A0
        public void BeginArrayNode(){} // RVA: 0x7FFE80E46250
        public void EndArrayNode(){} // RVA: 0x7FFE80E45FE0
        public void WritePrimitiveArray(){} // RVA: 0x7FFE80E460A0
        public void WriteNull(){} // RVA: 0x7FFE80E460A0
        public void WriteInternalReference(){} // RVA: 0x7FFE80E4D070
        public void WriteExternalReference(){} // RVA: 0x7FFE80E4F230 | overloaded x3
        public void WriteChar(){}
        public void WriteString(){} // RVA: 0x7FFE80E4F230
        public void WriteGuid(){}
        public void WriteSByte(){}
        public void WriteInt16(){}
        public void WriteInt32(){} // RVA: 0x7FFE80E4D070
        public void WriteInt64(){} // RVA: 0x7FFE80E4B8B0
        public void WriteByte(){} // RVA: 0x7FFE80E4BC00
        public void WriteUInt16(){}
        public void WriteUInt32(){}
        public void WriteUInt64(){}
        public void WriteDecimal(){}
        public void WriteSingle(){} // RVA: 0x7FFE80E52EB0
        public void WriteDouble(){}
        public void WriteBoolean(){} // RVA: 0x7FFE80E4BC00
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE80E45FE0
    }

    public class IDictionaryKeyPathProvider
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFE80E2E2E0
        public void GetPathStringFromKey(){} // RVA: 0x7FFE80E2E390
        public void GetKeyFromPathString(){} // RVA: 0x7FFE80E2E390
        public void Compare(){} // RVA: 0x7FFE80E38BF0
    }

    public class IDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void GetPathStringFromKey(){} // RVA: 0x7FFE810A1420
        public void GetKeyFromPathString(){} // RVA: 0x7FFE810A1420
        public void Compare(){} // RVA: 0x7FFE810A1420
    }

    public class IExternalGuidReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x7FFE80E2E2E0
        public void set_NextResolver(){} // RVA: 0x7FFE80E460A0
        public void TryResolveReference(){}
        public void CanReference(){} // RVA: 0x7FFE80E32650
    }

    public class IExternalIndexReferenceResolver
    {
        // ── Methods ──
        public void TryResolveReference(){} // RVA: 0x7FFE80E306B0
        public void CanReference(){} // RVA: 0x7FFE80E32650
    }

    public class IExternalStringReferenceResolver
    {
        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x7FFE80E2E2E0
        public void set_NextResolver(){} // RVA: 0x7FFE80E460A0
        public void TryResolveReference(){} // RVA: 0x7FFE80E32650
        public void CanReference(){} // RVA: 0x7FFE80E32650
    }

    public class IFormatter
    {
        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7FFE80E2E2E0
        public void Serialize(){} // RVA: 0x7FFE80E4F230
        public void Deserialize(){} // RVA: 0x7FFE80E2E390
    }

    public class IFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){}
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFE810A1420
        public void Deserialize(){} // RVA: 0x7FFE810A1420
    }

    public class ILogger
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x7FFE80E460A0
        public void LogError(){} // RVA: 0x7FFE80E460A0
        public void LogException(){} // RVA: 0x7FFE80E460A0
    }

    public class IOverridesSerializationFormat
    {
        // ── Methods ──
        public void GetFormatToSerializeAs(){} // RVA: 0x7FFE80E34FA0
    }

    public class IOverridesSerializationPolicy
    {
        // ── Methods ──
        public void get_SerializationPolicy(){} // RVA: 0x7FFE80E2E2E0
        public void get_OdinSerializesUnityFields(){} // RVA: 0x7FFE80E2F150
    }

    public class ISelfFormatter
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFE80E460A0
        public void Deserialize(){} // RVA: 0x7FFE80E460A0
    }

    public class ISerializableFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFE88399CB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ISerializationPolicy
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFE80E2E2E0
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7FFE80E2F150
        public void ShouldSerializeMember(){} // RVA: 0x7FFE80E2F3B0
    }

    public class ISupportsPrefabSerialization
    {
        // ── Methods ──
        public void get_SerializationData(){}
        public void set_SerializationData(){} // RVA: 0x7FFE810A1420
    }

    public class Int16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B7FF0
        public void WriteValue(){} // RVA: 0x7FFE883B8CC0
        public void .ctor(){} // RVA: 0x7FFE883B8D30
    }

    public class Int32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B8DA0
        public void WriteValue(){} // RVA: 0x7FFE883B9A70
        public void .ctor(){} // RVA: 0x7FFE883B9AE0
    }

    public class Int64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B9B50
        public void WriteValue(){} // RVA: 0x7FFE883BA810
        public void .ctor(){} // RVA: 0x7FFE883BA880
    }

    public class IntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883BA8F0
        public void WriteValue(){} // RVA: 0x7FFE883BB5B0
        public void .ctor(){} // RVA: 0x7FFE883BB620
    }

}