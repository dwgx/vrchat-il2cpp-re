// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 22
// Methods: 126

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class IAskIfCanFormatTypes
    {
        // ── Methods ──
        public void CanFormatType(){} // RVA: 0x7FFAC2C59F60
    }

    public class IDataReader
    {
        public object Binder;
        public object Stream;
        public object IsInArrayNode;
        public object CurrentNodeName;
        public object CurrentNodeId;
        public object CurrentNodeDepth;
        public object Context;

        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFAC2C58E90
        public void set_Binder(){} // RVA: 0x7FFAC2C70A40
        public void get_Stream(){} // RVA: 0x7FFAC2C58E90
        public void set_Stream(){} // RVA: 0x7FFAC2C70A40
        public void get_IsInArrayNode(){} // RVA: 0x7FFAC2C59D00
        public void get_CurrentNodeName(){} // RVA: 0x7FFAC2C58E90
        public void get_CurrentNodeId(){} // RVA: 0x7FFAC2C59960
        public void get_CurrentNodeDepth(){} // RVA: 0x7FFAC2C59960
        public void get_Context(){} // RVA: 0x7FFAC2C58E90
        public void set_Context(){} // RVA: 0x7FFAC2C70A40
        public void GetDataDump(){} // RVA: 0x7FFAC2C58E90
        public void EnterNode(){} // RVA: 0x7FFAC2C59F60
        public void ExitNode(){} // RVA: 0x7FFAC2C59D00
        public void EnterArray(){} // RVA: 0x7FFAC2C59F60
        public void ExitArray(){} // RVA: 0x7FFAC2C59D00
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAC2C59F60
        public void PeekEntry(){} // RVA: 0x7FFAC2C59F60
        public void ReadInternalReference(){} // RVA: 0x7FFAC2C59F60
        public void ReadExternalReference(){} // RVA: 0x7FFAC2C59F60 | overloaded x3
        public void ReadChar(){} // RVA: 0x7FFAC2C59F60
        public void ReadString(){} // RVA: 0x7FFAC2C59F60
        public void ReadGuid(){} // RVA: 0x7FFAC2C59F60
        public void ReadSByte(){} // RVA: 0x7FFAC2C59F60
        public void ReadInt16(){} // RVA: 0x7FFAC2C59F60
        public void ReadInt32(){} // RVA: 0x7FFAC2C59F60
        public void ReadInt64(){} // RVA: 0x7FFAC2C59F60
        public void ReadByte(){} // RVA: 0x7FFAC2C59F60
        public void ReadUInt16(){} // RVA: 0x7FFAC2C59F60
        public void ReadUInt32(){} // RVA: 0x7FFAC2C59F60
        public void ReadUInt64(){} // RVA: 0x7FFAC2C59F60
        public void ReadDecimal(){} // RVA: 0x7FFAC2C59F60
        public void ReadSingle(){} // RVA: 0x7FFAC2C59F60
        public void ReadDouble(){} // RVA: 0x7FFAC2C59F60
        public void ReadBoolean(){} // RVA: 0x7FFAC2C59F60
        public void ReadNull(){} // RVA: 0x7FFAC2C59D00
        public void SkipEntry(){} // RVA: 0x7FFAC2C70980
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC2C70980
    }

    public class IDataWriter
    {
        public object Binder;
        public object Stream;
        public object IsInArrayNode;
        public object Context;

        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFAC2C58E90
        public void set_Binder(){} // RVA: 0x7FFAC2C70A40
        public void get_Stream(){} // RVA: 0x7FFAC2C58E90
        public void set_Stream(){} // RVA: 0x7FFAC2C70A40
        public void get_IsInArrayNode(){} // RVA: 0x7FFAC2C59D00
        public void get_Context(){} // RVA: 0x7FFAC2C58E90
        public void set_Context(){} // RVA: 0x7FFAC2C70A40
        public void GetDataDump(){} // RVA: 0x7FFAC2C58E90
        public void FlushToStream(){} // RVA: 0x7FFAC2C70980
        public void BeginReferenceNode(){}
        public void BeginStructNode(){} // RVA: 0x7FFAC2C79B30
        public void EndNode(){} // RVA: 0x7FFAC2C70A40
        public void BeginArrayNode(){} // RVA: 0x7FFAC2C70BF0
        public void EndArrayNode(){} // RVA: 0x7FFAC2C70980
        public void WritePrimitiveArray(){} // RVA: 0x7FFAC2C70A40
        public void WriteNull(){} // RVA: 0x7FFAC2C70A40
        public void WriteInternalReference(){} // RVA: 0x7FFAC2C77970
        public void WriteExternalReference(){} // RVA: 0x7FFAC2C79B30 | overloaded x3
        public void WriteChar(){}
        public void WriteString(){} // RVA: 0x7FFAC2C79B30
        public void WriteGuid(){}
        public void WriteSByte(){}
        public void WriteInt16(){}
        public void WriteInt32(){} // RVA: 0x7FFAC2C77970
        public void WriteInt64(){} // RVA: 0x7FFAC2C761B0
        public void WriteByte(){} // RVA: 0x7FFAC2C76500
        public void WriteUInt16(){}
        public void WriteUInt32(){}
        public void WriteUInt64(){}
        public void WriteDecimal(){}
        public void WriteSingle(){} // RVA: 0x7FFAC2C7D7B0
        public void WriteDouble(){}
        public void WriteBoolean(){} // RVA: 0x7FFAC2C76500
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC2C70980
    }

    public class IDictionaryKeyPathProvider
    {
        public object ProviderID;

        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFAC2C58E90
        public void GetPathStringFromKey(){} // RVA: 0x7FFAC2C58F40
        public void GetKeyFromPathString(){} // RVA: 0x7FFAC2C58F40
        public void Compare(){} // RVA: 0x7FFAC2C637A0
    }

    public class IDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void GetPathStringFromKey(){} // RVA: 0x7FFAC2E8DC40
        public void GetKeyFromPathString(){} // RVA: 0x7FFAC2E8DC40
        public void Compare(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IExternalGuidReferenceResolver
    {
        public object NextResolver;

        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x7FFAC2C58E90
        public void set_NextResolver(){} // RVA: 0x7FFAC2C70A40
        public void TryResolveReference(){}
        public void CanReference(){} // RVA: 0x7FFAC2C5D200
    }

    public class IExternalIndexReferenceResolver
    {
        // ── Methods ──
        public void TryResolveReference(){} // RVA: 0x7FFAC2C5B260
        public void CanReference(){} // RVA: 0x7FFAC2C5D200
    }

    public class IExternalStringReferenceResolver
    {
        public object NextResolver;

        // ── Methods ──
        public void get_NextResolver(){} // RVA: 0x7FFAC2C58E90
        public void set_NextResolver(){} // RVA: 0x7FFAC2C70A40
        public void TryResolveReference(){} // RVA: 0x7FFAC2C5D200
        public void CanReference(){} // RVA: 0x7FFAC2C5D200
    }

    public class IFormatter
    {
        public object SerializedType;

        // ── Methods ──
        public void get_SerializedType(){} // RVA: 0x7FFAC2C58E90
        public void Serialize(){} // RVA: 0x7FFAC2C79B30
        public void Deserialize(){} // RVA: 0x7FFAC2C58F40
    }

    public class IFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){}
    }

    public class IFormatter`1
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAC2E8DC40
        public void Deserialize(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ILogger
    {
        // ── Methods ──
        public void LogWarning(){} // RVA: 0x7FFAC2C70A40
        public void LogError(){} // RVA: 0x7FFAC2C70A40
        public void LogException(){} // RVA: 0x7FFAC2C70A40
    }

    public class IOverridesSerializationFormat
    {
        // ── Methods ──
        public void GetFormatToSerializeAs(){} // RVA: 0x7FFAC2C5FB50
    }

    public class IOverridesSerializationPolicy
    {
        public object SerializationPolicy;
        public object OdinSerializesUnityFields;

        // ── Methods ──
        public void get_SerializationPolicy(){} // RVA: 0x7FFAC2C58E90
        public void get_OdinSerializesUnityFields(){} // RVA: 0x7FFAC2C59D00
    }

    public class ISelfFormatter
    {
        // ── Methods ──
        public void Serialize(){} // RVA: 0x7FFAC2C70A40
        public void Deserialize(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISerializableFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFAC9FE71C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ISerializationPolicy
    {
        public object ID;
        public object AllowNonSerializableTypes;

        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFAC2C58E90
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7FFAC2C59D00
        public void ShouldSerializeMember(){} // RVA: 0x7FFAC2C59F60
    }

    public class ISupportsPrefabSerialization
    {
        public object SerializationData;

        // ── Methods ──
        public void get_SerializationData(){}
        public void set_SerializationData(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Int16Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA0054E0
        public void WriteValue(){} // RVA: 0x7FFACA0061B0
        public void .ctor(){} // RVA: 0x7FFACA006220
    }

    public class Int32Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA006290
        public void WriteValue(){} // RVA: 0x7FFACA006F60
        public void .ctor(){} // RVA: 0x7FFACA006FD0
    }

    public class Int64Serializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA007040
        public void WriteValue(){} // RVA: 0x7FFACA007D00
        public void .ctor(){} // RVA: 0x7FFACA007D70
    }

    public class IntPtrSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA007DE0
        public void WriteValue(){} // RVA: 0x7FFACA008AA0
        public void .ctor(){} // RVA: 0x7FFACA008B10
    }

}