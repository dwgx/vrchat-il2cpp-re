// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 62
// Methods: 918

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class BaseDataReader : BaseDataReaderWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF613CD0
        public void get_CurrentNodeId(){} // RVA: 0x7AF613D70
        public void get_CurrentNodeDepth(){} // RVA: 0x7A83782A0
        public void get_CurrentNodeName(){} // RVA: 0x7AF613D90
        public void get_Stream(){} // RVA: 0x7A8105330
        public void set_Stream(){} // RVA: 0x7AF613DB0
        public void get_Context(){} // RVA: 0x7AF613ED0
        public void set_Context(){} // RVA: 0x7A81052D0
        public void EnterNode(){} // RVA: 0x7A7E019D0
        public void ExitNode(){} // RVA: 0x7A7E01900
        public void EnterArray(){} // RVA: 0x7A7E019D0
        public void ExitArray(){} // RVA: 0x7A7E01900
        public void ReadPrimitiveArray(){} // RVA: 0x7A7E019D0
        public void PeekEntry(){} // RVA: 0x7A7E01900
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
        public void SkipEntry(){} // RVA: 0x7AF613FD0
        public void Dispose(){} // RVA: 0x7A7E18770
        public void PrepareNewSerializationSession(){} // RVA: 0x7A8810990
        public void GetDataDump(){} // RVA: 0x7A7E00680
        public void ReadToNextEntry(){} // RVA: 0x7A7E01900
    }

    public class BaseDataReaderWriter : Object
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7AF6145D0
        public void set_Binder(){} // RVA: 0x7AF614710
        public void get_IsInArrayNode(){} // RVA: 0x7AF6148D0
        public void get_NodeDepth(){} // RVA: 0x7A83782A0
        public void get_NodesArray(){} // RVA: 0x7A80F2570
        public void get_CurrentNode(){} // RVA: 0x7AF614910
        public void PushNode(){} // RVA: 0x7AF614A90
        public void PushArray(){} // RVA: 0x7AF614BC0
        public void ExpandNodes(){} // RVA: 0x7AF614ED0
        public void PopNode(){} // RVA: 0x7AF615070
        public void PopArray(){} // RVA: 0x7AF6150E0
        public void ClearNodes(){} // RVA: 0x7A8810990
        public void .ctor(){} // RVA: 0x7AF6151C0
        public void nodes(){} // RVA: 0x7B3FB42B8
    }

    public class BaseDataWriter : BaseDataReaderWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF615250
        public void get_Stream(){} // RVA: 0x7A8105330
        public void set_Stream(){} // RVA: 0x7AF6152F0
        public void get_Context(){} // RVA: 0x7AF615410
        public void set_Context(){} // RVA: 0x7A81052D0
        public void FlushToStream(){} // RVA: 0x7AF615510
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
        public void Dispose(){} // RVA: 0x7A7E18770
        public void PrepareNewSerializationSession(){} // RVA: 0x7A8810990
        public void GetDataDump(){} // RVA: 0x7A7E00680
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7A7E00680
        public void GetKeyFromPathString(){} // RVA: 0x7A8051B10
        public void GetPathStringFromKey(){} // RVA: 0x7A8051B10
        public void Compare(){} // RVA: 0x7A8051B10
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7A7E06320
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7A7E00B20
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7A7E00680
        public void GetKeyFromPathString(){} // RVA: 0x7A7E00B20
        public void GetPathStringFromKey(){} // RVA: 0x7A7E150A0
        public void Compare(){} // RVA: 0x7A7E07C10
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7AD390000
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7AD390110
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7AD390150
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7A7E00680
        public void GetKeyFromPathString(){} // RVA: 0x7A7E00560
        public void GetPathStringFromKey(){} // RVA: 0x7A7E00B20
        public void Compare(){} // RVA: 0x7A7E06320
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7AD3901E0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7AD3902F0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7AD390350
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7A7E00680
        public void GetKeyFromPathString(){} // RVA: 0x7A7E00560
        public void GetPathStringFromKey(){} // RVA: 0x7A7E00B20
        public void Compare(){} // RVA: 0x7A7E06320
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7AD3903E0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7AD3904E0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7AD390530
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void GetCallbacks(){} // RVA: 0x7A7E112A0
        public void CreateCallback(){} // RVA: 0x7A7E00BA0
        public void get_SerializedType(){} // RVA: 0x7A7E00680
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7A7E18890
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7A7E00B20
        public void Deserialize(){} // RVA: 0x7A8051B10
        public void Serialize(){} // RVA: 0x7A8051B10
        public void GetUninitializedObject(){} // RVA: 0x7A8051B10
        public void RegisterReferenceID(){} // RVA: 0x7A8051B10
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7A7E18890
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7A80804D0
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7A80804D0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7A80804D0
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7A80804D0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7AD493930
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7AD4943A0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD3F61F0
        public void GetCallbacks(){} // RVA: 0x7AD3F7080
        public void CreateCallback(){} // RVA: 0x7AD3F7260
        public void get_SerializedType(){} // RVA: 0x7AD3F7630
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD3F76E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD3F7790
        public void Deserialize(){} // RVA: 0x7AD3F7800
        public void Serialize(){} // RVA: 0x7AD3F7ED0
        public void GetUninitializedObject(){} // RVA: 0x7AD3F8470
        public void RegisterReferenceID(){} // RVA: 0x7AD3F8600
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7A80804D0
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7A80804D0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7A80804D0
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7A80804D0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4913F0
        public void GetCallbacks(){} // RVA: 0x7AD492300
        public void CreateCallback(){} // RVA: 0x7AD492560
        public void get_SerializedType(){} // RVA: 0x7AD4929E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD492A90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD492C60
        public void Deserialize(){} // RVA: 0x7A80804D0
        public void Serialize(){} // RVA: 0x7A80804D0
        public void GetUninitializedObject(){} // RVA: 0x7A80804D0
        public void RegisterReferenceID(){} // RVA: 0x7A80804D0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD4945D0
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD3D4FF0
        public void GetCallbacks(){} // RVA: 0x7AD3D5E80
        public void CreateCallback(){} // RVA: 0x7AD3D6060
        public void get_SerializedType(){} // RVA: 0x7AD3D6430
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD3D64E0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD3D6590
        public void Deserialize(){} // RVA: 0x7AD3D6600
        public void Serialize(){} // RVA: 0x7AD3D6CD0
        public void GetUninitializedObject(){} // RVA: 0x7AD3D7270
        public void RegisterReferenceID(){} // RVA: 0x7AD3D7400
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD3D2A50
        public void GetCallbacks(){} // RVA: 0x7AD3D38E0
        public void CreateCallback(){} // RVA: 0x7AD3D3AC0
        public void get_SerializedType(){} // RVA: 0x7AD3D3E90
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD3D3F40
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD3D3FF0
        public void Deserialize(){} // RVA: 0x7AD3D4060
        public void Serialize(){} // RVA: 0x7AD3D4740
        public void GetUninitializedObject(){} // RVA: 0x7AD3D4CE0
        public void RegisterReferenceID(){} // RVA: 0x7AD3D4E70
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD4481E0
        public void GetCallbacks(){} // RVA: 0x7AD449070
        public void CreateCallback(){} // RVA: 0x7AD449250
        public void get_SerializedType(){} // RVA: 0x7AD449620
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7AD4496D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7AD449770
        public void Deserialize(){} // RVA: 0x7AD449790
        public void Serialize(){} // RVA: 0x7AD449FB0
        public void GetUninitializedObject(){} // RVA: 0x7AD44A590
        public void RegisterReferenceID(){} // RVA: 0x7AD44A6F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7AD3CFF00
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BinaryDataReader : BaseDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF6157F0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void PeekEntry(){} // RVA: 0x7AF619700
        public void EnterArray(){} // RVA: 0x7AF6160B0
        public void EnterNode(){} // RVA: 0x7AF616250
        public void ExitArray(){} // RVA: 0x7AF6164A0
        public void ExitNode(){} // RVA: 0x7AF6165E0
        public void ReadPrimitiveArray(){} // RVA: 0x7AA3F2D60
        public void ReadBoolean(){} // RVA: 0x7AF616780
        public void ReadSByte(){} // RVA: 0x7AF616890
        public void ReadByte(){} // RVA: 0x7AF616940
        public void ReadInt16(){} // RVA: 0x7AF6169F0
        public void ReadUInt16(){} // RVA: 0x7AF616AB0
        public void ReadInt32(){} // RVA: 0x7AF616B70
        public void ReadUInt32(){} // RVA: 0x7AF616C30
        public void ReadInt64(){} // RVA: 0x7AF616CF0
        public void ReadUInt64(){} // RVA: 0x7AF6171C0
        public void ReadChar(){} // RVA: 0x7AF617650
        public void ReadSingle(){} // RVA: 0x7AF617780
        public void ReadDouble(){} // RVA: 0x7AF6179E0
        public void ReadDecimal(){} // RVA: 0x7AF617C60
        public void ReadExternalReference(){} // RVA: 0x7AF618240
        public void ReadGuid(){} // RVA: 0x7AF6180C0
        public void ReadNull(){} // RVA: 0x7AF6183A0
        public void ReadInternalReference(){} // RVA: 0x7AF618430
        public void ReadString(){} // RVA: 0x7AF618500
        public void PrepareNewSerializationSession(){} // RVA: 0x7AF618660
        public void GetDataDump(){} // RVA: 0x7AF618780
        public void ReadStringValue(){} // RVA: 0x7AF6188F0
        public void SkipStringValue(){} // RVA: 0x7AF618C00
        public void SkipPeekedEntryContent(){} // RVA: 0x7AF618CF0
        public void SkipBuffer(){} // RVA: 0x7AF6191E0
        public void ReadTypeEntry(){} // RVA: 0x7AF619200
        public void MarkEntryContentConsumed(){} // RVA: 0x7AA3F5910
        public void ReadToNextEntry(){} // RVA: 0x7AF619730
        public void UNSAFE_Read_1_Byte(){} // RVA: 0x7AF619770
        public void UNSAFE_Read_1_SByte(){} // RVA: 0x7AF619770
        public void ReadValueTypeFromBuffer(){} // RVA: 0x7AA3F7B40
        public void UNSAFE_Read_2_Int16(){} // RVA: 0x7AF6197E0
        public void UNSAFE_Read_2_UInt16(){} // RVA: 0x7AF619830
        public void UNSAFE_Read_2_Char(){} // RVA: 0x7AF619880
        public void UNSAFE_Read_4_Int32(){} // RVA: 0x7AF6198D0
        public void UNSAFE_Read_4_UInt32(){} // RVA: 0x7AF619920
        public void UNSAFE_Read_4_Float32(){} // RVA: 0x7AF619970
        public void UNSAFE_Read_8_Int64(){} // RVA: 0x7AF6199C0
        public void UNSAFE_Read_8_UInt64(){} // RVA: 0x7AF619A10
        public void UNSAFE_Read_8_Float64(){} // RVA: 0x7AF619A60
        public void UNSAFE_Read_16_Decimal(){} // RVA: 0x7AF619AB0
        public void UNSAFE_Read_16_Guid(){} // RVA: 0x7AF619B00
        public void HasBufferData(){} // RVA: 0x7AA3F5970
        public void ReadEntireStreamToBuffer(){} // RVA: 0x7AF619B80
        public void OnFreed(){} // RVA: 0x7AD8439E0
        public void OnClaimed(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AF619FA0
    }

    public class BinaryDataWriter : BaseDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF61B200
        public void BeginArrayNode(){} // RVA: 0x7AF61B490
        public void BeginReferenceNode(){} // RVA: 0x7AF61B520
        public void BeginStructNode(){} // RVA: 0x7AF61B630
        public void Dispose(){} // RVA: 0x7ADCAB470
        public void EndArrayNode(){} // RVA: 0x7AF61B6F0
        public void EndNode(){} // RVA: 0x7AF61B740
        public void WritePrimitiveArray_byte(){} // RVA: 0x7AF61B7E0
        public void WritePrimitiveArray_sbyte(){} // RVA: 0x7AF61B940
        public void WritePrimitiveArray_bool(){} // RVA: 0x7AF61BC90
        public void WritePrimitiveArray_char(){} // RVA: 0x7AF61BFE0
        public void WritePrimitiveArray_short(){} // RVA: 0x7AF61C350
        public void WritePrimitiveArray_int(){} // RVA: 0x7AF61C6C0
        public void WritePrimitiveArray_long(){} // RVA: 0x7AF61CA30
        public void WritePrimitiveArray_ushort(){} // RVA: 0x7AF61CDA0
        public void WritePrimitiveArray_uint(){} // RVA: 0x7AF61D110
        public void WritePrimitiveArray_ulong(){} // RVA: 0x7AF61D480
        public void WritePrimitiveArray_decimal(){} // RVA: 0x7AF61D7F0
        public void WritePrimitiveArray_float(){} // RVA: 0x7AF61DB60
        public void WritePrimitiveArray_double(){} // RVA: 0x7AF61DED0
        public void WritePrimitiveArray_Guid(){} // RVA: 0x7AF61E240
        public void WritePrimitiveArray(){} // RVA: 0x7A7E18800
        public void WriteBoolean(){} // RVA: 0x7AF61E5B0
        public void WriteByte(){} // RVA: 0x7AF61E680
        public void WriteChar(){} // RVA: 0x7AF61E750
        public void WriteDecimal(){} // RVA: 0x7AF61E830
        public void WriteDouble(){} // RVA: 0x7AF61E920
        public void WriteGuid(){} // RVA: 0x7AF61EA00
        public void WriteExternalReference(){} // RVA: 0x7AF61ECC0
        public void WriteInt32(){} // RVA: 0x7AF61EDB0
        public void WriteInt64(){} // RVA: 0x7AF61EE90
        public void WriteNull(){} // RVA: 0x7AF61EF70
        public void WriteInternalReference(){} // RVA: 0x7AF61F000
        public void WriteSByte(){} // RVA: 0x7AF61F0E0
        public void WriteInt16(){} // RVA: 0x7AF61F1B0
        public void WriteSingle(){} // RVA: 0x7AF61F290
        public void WriteString(){} // RVA: 0x7AF61F370
        public void WriteUInt32(){} // RVA: 0x7AF61F410
        public void WriteUInt64(){} // RVA: 0x7AF61F4F0
        public void WriteUInt16(){} // RVA: 0x7AF61F5D0
        public void PrepareNewSerializationSession(){} // RVA: 0x7AF61F6B0
        public void GetDataDump(){} // RVA: 0x7AF61F710
        public void WriteType(){} // RVA: 0x7AF61F9B0
        public void WriteStringFast(){} // RVA: 0x7AF61FC80
        public void FlushToStream(){} // RVA: 0x7AF620420
        public void WriteValueTypeToBuffer(){} // RVA: 0x7AA3F87C0
        public void UNSAFE_WriteToBuffer_2_Char(){} // RVA: 0x7AF6204C0
        public void UNSAFE_WriteToBuffer_2_Int16(){} // RVA: 0x7AF620510
        public void UNSAFE_WriteToBuffer_2_UInt16(){} // RVA: 0x7AF620560
        public void UNSAFE_WriteToBuffer_4_Int32(){} // RVA: 0x7AF6205B0
        public void UNSAFE_WriteToBuffer_4_UInt32(){} // RVA: 0x7AF620600
        public void UNSAFE_WriteToBuffer_4_Float32(){} // RVA: 0x7AF620650
        public void UNSAFE_WriteToBuffer_8_Int64(){} // RVA: 0x7AF6206A0
        public void UNSAFE_WriteToBuffer_8_UInt64(){} // RVA: 0x7AF6206F0
        public void UNSAFE_WriteToBuffer_8_Float64(){} // RVA: 0x7AF620740
        public void UNSAFE_WriteToBuffer_16_Decimal(){} // RVA: 0x7AF620790
        public void UNSAFE_WriteToBuffer_16_Guid(){} // RVA: 0x7AF6207F0
        public void EnsureBufferSpace(){} // RVA: 0x7AF620850
        public void TryEnsureBufferSpace(){} // RVA: 0x7AF6208F0
        public void .cctor(){} // RVA: 0x7AF620940
    }

    public class BindTypeNameToTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABAF10
    }

    public class BindTypeNameToTypeAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BooleanSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF6558F0
        public void WriteValue(){} // RVA: 0x7AF6565F0
        public void .ctor(){} // RVA: 0x7AF656660
    }

    public class BoundsFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7AF66C970
        public void Write(){} // RVA: 0x7AF66CA70
        public void .ctor(){} // RVA: 0x7AF66CBA0
        public void .cctor(){} // RVA: 0x7AF66CC00
    }

    public class Buffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E189D0
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_Array(){} // RVA: 0x7A7E00680
        public void get_IsFree(){} // RVA: 0x7A7E01900
        public void Claim(){} // RVA: 0x7A7E064F0
        public void Free(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A7E18770
        public void NextPowerOfTwo(){} // RVA: 0x7A7E07D40
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class Buffer`1 : Object
    {
        // ── Methods ──
        public void Claim(){} // RVA: 0x7AD5140E0
        public void get_Array(){} // RVA: 0x7AD514060
        public void .ctor(){} // RVA: 0x7AD513F50
        public void get_Count(){} // RVA: 0x7AD513FF0
        public void get_IsFree(){} // RVA: 0x7AD5140D0
        public void Free(){} // RVA: 0x7AD514C50
        public void Dispose(){} // RVA: 0x7AD514C50
        public void NextPowerOfTwo(){} // RVA: 0x7AD514CC0
        public void .cctor(){} // RVA: 0x7AD514CF0
    }

    public class ByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF6566D0
        public void WriteValue(){} // RVA: 0x7AF6573D0
        public void .ctor(){} // RVA: 0x7AF657440
    }

}