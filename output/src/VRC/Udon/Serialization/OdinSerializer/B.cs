// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 61
// Methods: 963

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class BaseDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA2E47D0
        public void get_CurrentNodeId(){} // RVA: 0x7FFAFA2E4870
        public void get_CurrentNodeDepth(){} // RVA: 0x7FFAF306ED50
        public void get_CurrentNodeName(){} // RVA: 0x7FFAFA2E4890
        public void get_Stream(){} // RVA: 0x7FFAF2DBB130
        public void set_Stream(){} // RVA: 0x7FFAFA2E48B0
        public void get_Context(){} // RVA: 0x7FFAFA2E49D0
        public void set_Context(){} // RVA: 0x7FFAF2DBB0D0
        public void EnterNode(){} // RVA: 0x7FFAF2ABDE40
        public void ExitNode(){} // RVA: 0x7FFAF2ABDBE0
        public void EnterArray(){} // RVA: 0x7FFAF2ABDE40
        public void ExitArray(){} // RVA: 0x7FFAF2ABDBE0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAF2ABDE40
        public void PeekEntry(){} // RVA: 0x7FFAF2ABDBE0 | overloaded x2
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
        public void SkipEntry(){} // RVA: 0x7FFAFA2E4AD0
        public void Dispose(){} // RVA: 0x7FFAF2AD4A50
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAF3502E70
        public void GetDataDump(){} // RVA: 0x7FFAF2ABCD60
        public void ReadToNextEntry(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class BaseDataReaderWriter
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFAFA2E50D0
        public void set_Binder(){} // RVA: 0x7FFAFA2E5210
        public void get_IsInArrayNode(){} // RVA: 0x7FFAFA2E53D0
        public void get_NodeDepth(){} // RVA: 0x7FFAF306ED50
        public void get_NodesArray(){} // RVA: 0x7FFAF2DA8380
        public void get_CurrentNode(){} // RVA: 0x7FFAFA2E5420
        public void PushNode(){} // RVA: 0x7FFAFA2E55A0 | overloaded x2
        public void PushArray(){} // RVA: 0x7FFAFA2E56D0
        public void ExpandNodes(){} // RVA: 0x7FFAFA2E59F0
        public void PopNode(){} // RVA: 0x7FFAFA2E5B70
        public void PopArray(){} // RVA: 0x7FFAFA2E5BE0
        public void ClearNodes(){} // RVA: 0x7FFAF3502E70
        public void .ctor(){} // RVA: 0x7FFAFA2E5CC0
    }

    public class BaseDataWriter : stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA2E5D50
        public void get_Stream(){} // RVA: 0x7FFAF2DBB130
        public void set_Stream(){} // RVA: 0x7FFAFA2E5DF0
        public void get_Context(){} // RVA: 0x7FFAFA2E5F10
        public void set_Context(){} // RVA: 0x7FFAF2DBB0D0
        public void FlushToStream(){} // RVA: 0x7FFAFA2E6010
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
        public void Dispose(){} // RVA: 0x7FFAF2AD4A50
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAF3502E70
        public void GetDataDump(){} // RVA: 0x7FFAF2ABCD60
    }

    public class BaseDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFAF2ABCD60
        public void GetKeyFromPathString(){} // RVA: 0x7FFAF2D33FA0
        public void GetPathStringFromKey(){} // RVA: 0x7FFAF2D33FA0
        public void Compare(){} // RVA: 0x7FFAF2D33FA0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7FFAF2AC7680
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7FFAF2ABCE10
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7FFAF2ABCE10
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class BaseDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFAF2ABCD60
        public void GetKeyFromPathString(){} // RVA: 0x7FFAF2ABCE10
        public void GetPathStringFromKey(){}
        public void Compare(){}
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7FFAF806ABB0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7FFAF806ACC0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7FFAF806AD00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFAF2ABCD60
        public void GetKeyFromPathString(){} // RVA: 0x7FFAF2ABCF00
        public void GetPathStringFromKey(){}
        public void Compare(){}
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7FFAF806AD90
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7FFAF806AEA0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7FFAF806AF00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFAF2ABCD60
        public void GetKeyFromPathString(){} // RVA: 0x7FFAF2ABCF00
        public void GetPathStringFromKey(){}
        public void Compare(){}
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7FFAF806AF90
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7FFAF806B090
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7FFAF806B0E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
        public void GetCallbacks(){} // RVA: 0x7FFAF2ACD550
        public void CreateCallback(){} // RVA: 0x7FFAF2ABCE50
        public void get_SerializedType(){} // RVA: 0x7FFAF2ABCD60
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF2ABCE10
        public void Deserialize(){} // RVA: 0x7FFAF2D33FA0
        public void Serialize(){} // RVA: 0x7FFAF2D33FA0
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF2D33FA0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF2ADDC60 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF2D13BC0
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF2D13BC0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF2D13BC0
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF2D13BC0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF816E280
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF816ED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF2D13BC0
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF2D13BC0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF2D13BC0
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF2D13BC0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF816BD20
        public void GetCallbacks(){} // RVA: 0x7FFAF816CC30
        public void CreateCallback(){} // RVA: 0x7FFAF816CE90
        public void get_SerializedType(){} // RVA: 0x7FFAF816D300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF816D3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF816D580
        public void Deserialize(){} // RVA: 0x7FFAF2D13BC0
        public void Serialize(){} // RVA: 0x7FFAF2D13BC0
        public void GetUninitializedObject(){} // RVA: 0x7FFAF2D13BC0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF2D13BC0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF816EF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF80D1070
        public void GetCallbacks(){} // RVA: 0x7FFAF80D1F00
        public void CreateCallback(){} // RVA: 0x7FFAF80D20D0
        public void get_SerializedType(){} // RVA: 0x7FFAF80D24A0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF80D2550
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF80D2600
        public void Deserialize(){} // RVA: 0x7FFAF80D2670
        public void Serialize(){} // RVA: 0x7FFAF80D2D40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF80D32E0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF80D3470
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF80AFF70
        public void GetCallbacks(){} // RVA: 0x7FFAF80B0E00
        public void CreateCallback(){} // RVA: 0x7FFAF80B0FD0
        public void get_SerializedType(){} // RVA: 0x7FFAF80B13A0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF80B1450
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF80B1500
        public void Deserialize(){} // RVA: 0x7FFAF80B1570
        public void Serialize(){} // RVA: 0x7FFAF80B1C40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF80B21E0
        public void RegisterReferenceID(){} // RVA: 0x7FFAF80B2370
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF80AD9E0
        public void GetCallbacks(){} // RVA: 0x7FFAF80AE870
        public void CreateCallback(){} // RVA: 0x7FFAF80AEA40
        public void get_SerializedType(){} // RVA: 0x7FFAF80AEE10
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF80AEEC0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF80AEF70
        public void Deserialize(){} // RVA: 0x7FFAF80AEFE0
        public void Serialize(){} // RVA: 0x7FFAF80AF6C0
        public void GetUninitializedObject(){} // RVA: 0x7FFAF80AFC60
        public void RegisterReferenceID(){} // RVA: 0x7FFAF80AFDF0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8122D80
        public void GetCallbacks(){} // RVA: 0x7FFAF8123C10
        public void CreateCallback(){} // RVA: 0x7FFAF8123DE0
        public void get_SerializedType(){} // RVA: 0x7FFAF81241B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAF8124260
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAF8124300
        public void Deserialize(){} // RVA: 0x7FFAF8124320
        public void Serialize(){} // RVA: 0x7FFAF8124B40
        public void GetUninitializedObject(){} // RVA: 0x7FFAF8125120
        public void RegisterReferenceID(){} // RVA: 0x7FFAF8125280
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAF80AAE90 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void SerializeImplementation(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BinaryDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA2E62F0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void PeekEntry(){} // RVA: 0x7FFAFA2EA1F0 | overloaded x2
        public void EnterArray(){} // RVA: 0x7FFAFA2E6BB0
        public void EnterNode(){} // RVA: 0x7FFAFA2E6D50
        public void ExitArray(){} // RVA: 0x7FFAFA2E6FA0
        public void ExitNode(){} // RVA: 0x7FFAFA2E70E0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAF2ABDE40
        public void ReadBoolean(){} // RVA: 0x7FFAFA2E7280
        public void ReadSByte(){} // RVA: 0x7FFAFA2E7390
        public void ReadByte(){} // RVA: 0x7FFAFA2E7440
        public void ReadInt16(){} // RVA: 0x7FFAFA2E74F0
        public void ReadUInt16(){} // RVA: 0x7FFAFA2E75B0
        public void ReadInt32(){} // RVA: 0x7FFAFA2E7670
        public void ReadUInt32(){} // RVA: 0x7FFAFA2E7730
        public void ReadInt64(){} // RVA: 0x7FFAFA2E77F0
        public void ReadUInt64(){} // RVA: 0x7FFAFA2E7CC0
        public void ReadChar(){} // RVA: 0x7FFAFA2E8150
        public void ReadSingle(){} // RVA: 0x7FFAFA2E8280
        public void ReadDouble(){} // RVA: 0x7FFAFA2E84E0
        public void ReadDecimal(){} // RVA: 0x7FFAFA2E8760
        public void ReadExternalReference(){} // RVA: 0x7FFAFA2E8D50 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7FFAFA2E8BD0
        public void ReadNull(){} // RVA: 0x7FFAFA2E8EB0
        public void ReadInternalReference(){} // RVA: 0x7FFAFA2E8F40
        public void ReadString(){} // RVA: 0x7FFAFA2E9010
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAFA2E9170
        public void GetDataDump(){} // RVA: 0x7FFAFA2E9290
        public void ReadStringValue(){} // RVA: 0x7FFAFA2E9400
        public void SkipStringValue(){} // RVA: 0x7FFAFA2E9700
        public void SkipPeekedEntryContent(){} // RVA: 0x7FFAFA2E97F0
        public void SkipBuffer(){} // RVA: 0x7FFAFA2E9CD0
        public void ReadTypeEntry(){} // RVA: 0x7FFAFA2E9CF0
        public void MarkEntryContentConsumed(){} // RVA: 0x7FFAF5093F80
        public void ReadToNextEntry(){} // RVA: 0x7FFAFA2EA220
        public void UNSAFE_Read_1_Byte(){} // RVA: 0x7FFAFA2EA260
        public void UNSAFE_Read_1_SByte(){} // RVA: 0x7FFAFA2EA260
        public void ReadValueTypeFromBuffer(){} // RVA: 0x7FFAF2ABDE40
        public void UNSAFE_Read_2_Int16(){} // RVA: 0x7FFAFA2EA2D0
        public void UNSAFE_Read_2_UInt16(){} // RVA: 0x7FFAFA2EA320
        public void UNSAFE_Read_2_Char(){} // RVA: 0x7FFAFA2EA370
        public void UNSAFE_Read_4_Int32(){} // RVA: 0x7FFAFA2EA3C0
        public void UNSAFE_Read_4_UInt32(){} // RVA: 0x7FFAFA2EA410
        public void UNSAFE_Read_4_Float32(){} // RVA: 0x7FFAFA2EA460
        public void UNSAFE_Read_8_Int64(){} // RVA: 0x7FFAFA2EA4B0
        public void UNSAFE_Read_8_UInt64(){} // RVA: 0x7FFAFA2EA500
        public void UNSAFE_Read_8_Float64(){} // RVA: 0x7FFAFA2EA550
        public void UNSAFE_Read_16_Decimal(){} // RVA: 0x7FFAFA2EA5A0
        public void UNSAFE_Read_16_Guid(){} // RVA: 0x7FFAFA2EA5F0
        public void HasBufferData(){} // RVA: 0x7FFAF5093FE0
        public void ReadEntireStreamToBuffer(){} // RVA: 0x7FFAFA2EA670
        public void OnFreed(){} // RVA: 0x7FFAF8507060
        public void OnClaimed(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFA2EAA90
    }

    public class BinaryDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA2EBCC0 | overloaded x2
        public void BeginArrayNode(){} // RVA: 0x7FFAFA2EBF30
        public void BeginReferenceNode(){} // RVA: 0x7FFAFA2EBFC0
        public void BeginStructNode(){} // RVA: 0x7FFAFA2EC0D0
        public void Dispose(){} // RVA: 0x7FFAF896C950
        public void EndArrayNode(){} // RVA: 0x7FFAFA2EC190
        public void EndNode(){} // RVA: 0x7FFAFA2EC1E0
        public void WritePrimitiveArray_byte(){} // RVA: 0x7FFAFA2EC280
        public void WritePrimitiveArray_sbyte(){} // RVA: 0x7FFAFA2EC3E0
        public void WritePrimitiveArray_bool(){} // RVA: 0x7FFAFA2EC740
        public void WritePrimitiveArray_char(){} // RVA: 0x7FFAFA2ECAA0
        public void WritePrimitiveArray_short(){} // RVA: 0x7FFAFA2ECE10
        public void WritePrimitiveArray_int(){} // RVA: 0x7FFAFA2ED180
        public void WritePrimitiveArray_long(){} // RVA: 0x7FFAFA2ED4F0
        public void WritePrimitiveArray_ushort(){} // RVA: 0x7FFAFA2ED860
        public void WritePrimitiveArray_uint(){} // RVA: 0x7FFAFA2EDBD0
        public void WritePrimitiveArray_ulong(){} // RVA: 0x7FFAFA2EDF40
        public void WritePrimitiveArray_decimal(){} // RVA: 0x7FFAFA2EE2B0
        public void WritePrimitiveArray_float(){} // RVA: 0x7FFAFA2EE620
        public void WritePrimitiveArray_double(){} // RVA: 0x7FFAFA2EE990
        public void WritePrimitiveArray_Guid(){} // RVA: 0x7FFAFA2EED00
        public void WritePrimitiveArray(){} // RVA: 0x7FFAF2AD4B10
        public void WriteBoolean(){} // RVA: 0x7FFAFA2EF070
        public void WriteByte(){} // RVA: 0x7FFAFA2EF140
        public void WriteChar(){} // RVA: 0x7FFAFA2EF210
        public void WriteDecimal(){} // RVA: 0x7FFAFA2EF2F0
        public void WriteDouble(){} // RVA: 0x7FFAFA2EF3E0
        public void WriteGuid(){} // RVA: 0x7FFAFA2EF4C0
        public void WriteExternalReference(){} // RVA: 0x7FFAFA2EF780 | overloaded x3
        public void WriteInt32(){} // RVA: 0x7FFAFA2EF870
        public void WriteInt64(){} // RVA: 0x7FFAFA2EF950
        public void WriteNull(){} // RVA: 0x7FFAFA2EFA30
        public void WriteInternalReference(){} // RVA: 0x7FFAFA2EFAC0
        public void WriteSByte(){} // RVA: 0x7FFAFA2EFBA0
        public void WriteInt16(){} // RVA: 0x7FFAFA2EFC70
        public void WriteSingle(){} // RVA: 0x7FFAFA2EFD50
        public void WriteString(){} // RVA: 0x7FFAFA2EFE30
        public void WriteUInt32(){} // RVA: 0x7FFAFA2EFED0
        public void WriteUInt64(){} // RVA: 0x7FFAFA2EFFB0
        public void WriteUInt16(){} // RVA: 0x7FFAFA2F0090
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAFA2F0170
        public void GetDataDump(){} // RVA: 0x7FFAFA2F01D0
        public void WriteType(){} // RVA: 0x7FFAFA2F0470
        public void WriteStringFast(){} // RVA: 0x7FFAFA2F0740
        public void FlushToStream(){} // RVA: 0x7FFAFA2F0ED0
        public void WriteValueTypeToBuffer(){} // RVA: 0x7FFAF2D33FA0
        public void UNSAFE_WriteToBuffer_2_Char(){} // RVA: 0x7FFAFA2F0F70
        public void UNSAFE_WriteToBuffer_2_Int16(){} // RVA: 0x7FFAFA2F0FC0
        public void UNSAFE_WriteToBuffer_2_UInt16(){} // RVA: 0x7FFAFA2F1010
        public void UNSAFE_WriteToBuffer_4_Int32(){} // RVA: 0x7FFAFA2F1060
        public void UNSAFE_WriteToBuffer_4_UInt32(){} // RVA: 0x7FFAFA2F10B0
        public void UNSAFE_WriteToBuffer_4_Float32(){} // RVA: 0x7FFAFA2F1100
        public void UNSAFE_WriteToBuffer_8_Int64(){} // RVA: 0x7FFAFA2F1150
        public void UNSAFE_WriteToBuffer_8_UInt64(){} // RVA: 0x7FFAFA2F11A0
        public void UNSAFE_WriteToBuffer_8_Float64(){} // RVA: 0x7FFAFA2F11F0
        public void UNSAFE_WriteToBuffer_16_Decimal(){} // RVA: 0x7FFAFA2F1240
        public void UNSAFE_WriteToBuffer_16_Guid(){} // RVA: 0x7FFAFA2F12A0
        public void EnsureBufferSpace(){} // RVA: 0x7FFAFA2F1300
        public void TryEnsureBufferSpace(){} // RVA: 0x7FFAFA2F13A0
        public void .cctor(){} // RVA: 0x7FFAFA2F13F0
    }

    public class BindTypeNameToTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877CD00
    }

    public class BooleanSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA326760
        public void WriteValue(){} // RVA: 0x7FFAFA327430
        public void .ctor(){} // RVA: 0x7FFAFA3274A0
    }

    public class BoundsFormatter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAFA33D8A0
        public void Write(){} // RVA: 0x7FFAFA33D9A0
        public void .ctor(){} // RVA: 0x7FFAFA33DAD0
        public void .cctor(){} // RVA: 0x7FFAFA33DB30
    }

    public class Buffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_Array(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsFree(){} // RVA: 0x7FFAF2ABDBE0
        public void Claim(){} // RVA: 0x7FFAF2AC27A0
        public void Free(){} // RVA: 0x7FFAF2AD4A50 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF2AD4A50
        public void NextPowerOfTwo(){} // RVA: 0x7FFAF2AC3FF0
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class Buffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF81F4B60
        public void get_Count(){} // RVA: 0x7FFAF81F4C00
        public void get_Array(){} // RVA: 0x7FFAF81F4C70
        public void get_IsFree(){} // RVA: 0x7FFAF81F4CE0
        public void Claim(){} // RVA: 0x7FFAF81F4CF0
        public void Free(){} // RVA: 0x7FFAF81F58D0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF81F58D0
        public void NextPowerOfTwo(){} // RVA: 0x7FFAF81F5940
        public void .cctor(){} // RVA: 0x7FFAF81F5970
    }

    public class ByteSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFAFA327510
        public void WriteValue(){} // RVA: 0x7FFAFA3281E0
        public void .ctor(){} // RVA: 0x7FFAFA328250
    }

}