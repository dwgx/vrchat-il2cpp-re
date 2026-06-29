// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 46
// Methods: 697

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class BaseDataReader : BaseDataReaderWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8472B40
        public void get_CurrentNodeId(){} // RVA: 0x8472BE0
        public void get_CurrentNodeDepth(){} // RVA: 0xE62D00
        public void get_CurrentNodeName(){} // RVA: 0x8472C00
        public void get_Stream(){} // RVA: 0xB70160
        public void set_Stream(){} // RVA: 0x8472C20
        public void get_Context(){} // RVA: 0x8472D40
        public void set_Context(){} // RVA: 0xB70100
        public void EnterNode(){} // RVA: 0x87D350
        public void ExitNode(){} // RVA: 0x87D280
        public void EnterArray(){} // RVA: 0x87D350
        public void ExitArray(){} // RVA: 0x87D280
        public void ReadPrimitiveArray(){} // RVA: 0x87D350
        public void PeekEntry(){} // RVA: 0x87D280
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
        public void SkipEntry(){} // RVA: 0x8472E40
        public void Dispose(){} // RVA: 0x894290
        public void PrepareNewSerializationSession(){} // RVA: 0x1320080
        public void GetDataDump(){} // RVA: 0x87C0A0
        public void ReadToNextEntry(){} // RVA: 0x87D280
    }

    public class BaseDataReaderWriter : Object
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x8473430
        public void set_Binder(){} // RVA: 0x8473570
        public void get_IsInArrayNode(){} // RVA: 0x8473730
        public void get_NodeDepth(){} // RVA: 0xE62D00
        public void get_NodesArray(){} // RVA: 0xB5DBF0
        public void get_CurrentNode(){} // RVA: 0x8473770
        public void PushNode(){} // RVA: 0x84738F0
        public void PushArray(){} // RVA: 0x8473A20
        public void ExpandNodes(){} // RVA: 0x8473D30
        public void PopNode(){} // RVA: 0x8473ED0
        public void PopArray(){} // RVA: 0x8473F40
        public void ClearNodes(){} // RVA: 0x1320080
        public void .ctor(){} // RVA: 0x8474020
    }

    public class BaseDataWriter : BaseDataReaderWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x84740B0
        public void get_Stream(){} // RVA: 0xB70160
        public void set_Stream(){} // RVA: 0x8474150
        public void get_Context(){} // RVA: 0x8474270
        public void set_Context(){} // RVA: 0xB70100
        public void FlushToStream(){} // RVA: 0x8474370
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
        public void Dispose(){} // RVA: 0x894290
        public void PrepareNewSerializationSession(){} // RVA: 0x1320080
        public void GetDataDump(){} // RVA: 0x87C0A0
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x87C0A0
        public void GetKeyFromPathString(){} // RVA: 0xA94080
        public void GetPathStringFromKey(){} // RVA: 0xA94080
        public void Compare(){} // RVA: 0xA94080
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x881CA0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x87C540
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0x894290
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x87C0A0
        public void GetKeyFromPathString(){} // RVA: 0x87C540
        public void GetPathStringFromKey(){} // RVA: 0x890A80
        public void Compare(){} // RVA: 0x8835D0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x60DBCE0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x60DBDF0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x60DBE30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x87C0A0
        public void GetKeyFromPathString(){} // RVA: 0x87BF80
        public void GetPathStringFromKey(){} // RVA: 0x87C540
        public void Compare(){} // RVA: 0x881CA0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x60DBEC0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x60DBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x60DC030
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x87C0A0
        public void GetKeyFromPathString(){} // RVA: 0x87BF80
        public void GetPathStringFromKey(){} // RVA: 0x87C540
        public void Compare(){} // RVA: 0x881CA0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x60DC0C0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x60DC1C0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x60DC210
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void GetCallbacks(){} // RVA: 0x88CCC0
        public void CreateCallback(){} // RVA: 0x87C5C0
        public void get_SerializedType(){} // RVA: 0x87C0A0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x8943B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x87C540
        public void Deserialize(){} // RVA: 0xA94080
        public void Serialize(){} // RVA: 0xA94080
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void RegisterReferenceID(){} // RVA: 0xA94080
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x8943B0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0xAD0950
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0xAD0950
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0xAD0950
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0xAD0950
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0x61ECE70
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0x61ED8F0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61521D0
        public void GetCallbacks(){} // RVA: 0x6152E80
        public void CreateCallback(){} // RVA: 0x6153060
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x6153450
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x6153500
        public void Deserialize(){} // RVA: 0x6153570
        public void Serialize(){} // RVA: 0x6153C40
        public void GetUninitializedObject(){} // RVA: 0x61541E0
        public void RegisterReferenceID(){} // RVA: 0x6154380
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61A6250
        public void GetCallbacks(){} // RVA: 0x61A6F00
        public void CreateCallback(){} // RVA: 0x61A70E0
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61A74D0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61A7570
        public void Deserialize(){} // RVA: 0x61A7590
        public void Serialize(){} // RVA: 0x61A7DB0
        public void GetUninitializedObject(){} // RVA: 0x61A8390
        public void RegisterReferenceID(){} // RVA: 0x61A8510
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x612E4D0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0xAD0950
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0xAD0950
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0xAD0950
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0xAD0950
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BaseFormatter`1 : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x61EAB80
        public void GetCallbacks(){} // RVA: 0x61EB8D0
        public void CreateCallback(){} // RVA: 0x61EBB30
        public void get_SerializedType(){} // RVA: 0x3DCE540
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x61EBFD0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x61EC1A0
        public void Deserialize(){} // RVA: 0xAD0950
        public void Serialize(){} // RVA: 0xAD0950
        public void GetUninitializedObject(){} // RVA: 0xAD0950
        public void RegisterReferenceID(){} // RVA: 0xAD0950
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x61EDB20
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BinaryDataReader : BaseDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8474650
        public void Dispose(){} // RVA: 0xB43310
        public void PeekEntry(){} // RVA: 0x8478530
        public void EnterArray(){} // RVA: 0x8474F10
        public void EnterNode(){} // RVA: 0x84750B0
        public void ExitArray(){} // RVA: 0x8475300
        public void ExitNode(){} // RVA: 0x8475440
        public void ReadPrimitiveArray(){} // RVA: 0x87D350
        public void ReadBoolean(){} // RVA: 0x84755E0
        public void ReadSByte(){} // RVA: 0x84756F0
        public void ReadByte(){} // RVA: 0x84757A0
        public void ReadInt16(){} // RVA: 0x8475850
        public void ReadUInt16(){} // RVA: 0x8475910
        public void ReadInt32(){} // RVA: 0x84759D0
        public void ReadUInt32(){} // RVA: 0x8475A90
        public void ReadInt64(){} // RVA: 0x8475B50
        public void ReadUInt64(){} // RVA: 0x8476020
        public void ReadChar(){} // RVA: 0x84764B0
        public void ReadSingle(){} // RVA: 0x84765E0
        public void ReadDouble(){} // RVA: 0x8476840
        public void ReadDecimal(){} // RVA: 0x8476AC0
        public void ReadExternalReference(){} // RVA: 0x84770A0
        public void ReadGuid(){} // RVA: 0x8476F20
        public void ReadNull(){} // RVA: 0x8477200
        public void ReadInternalReference(){} // RVA: 0x8477290
        public void ReadString(){} // RVA: 0x8477360
        public void PrepareNewSerializationSession(){} // RVA: 0x84774C0
        public void GetDataDump(){} // RVA: 0x84775E0
        public void ReadStringValue(){} // RVA: 0x8477750
        public void SkipStringValue(){} // RVA: 0x8477A30
        public void SkipPeekedEntryContent(){} // RVA: 0x8477B20
        public void SkipBuffer(){} // RVA: 0x8478010
        public void ReadTypeEntry(){} // RVA: 0x8478030
        public void MarkEntryContentConsumed(){} // RVA: 0x3014D10
        public void ReadToNextEntry(){} // RVA: 0x8478560
        public void UNSAFE_Read_1_Byte(){} // RVA: 0x84785A0
        public void UNSAFE_Read_1_SByte(){} // RVA: 0x84785A0
        public void ReadValueTypeFromBuffer(){} // RVA: 0x87D350
        public void UNSAFE_Read_2_Int16(){} // RVA: 0x8478610
        public void UNSAFE_Read_2_UInt16(){} // RVA: 0x8478660
        public void UNSAFE_Read_2_Char(){} // RVA: 0x84786B0
        public void UNSAFE_Read_4_Int32(){} // RVA: 0x8478700
        public void UNSAFE_Read_4_UInt32(){} // RVA: 0x8478750
        public void UNSAFE_Read_4_Float32(){} // RVA: 0x84787A0
        public void UNSAFE_Read_8_Int64(){} // RVA: 0x84787F0
        public void UNSAFE_Read_8_UInt64(){} // RVA: 0x8478840
        public void UNSAFE_Read_8_Float64(){} // RVA: 0x8478890
        public void UNSAFE_Read_16_Decimal(){} // RVA: 0x84788E0
        public void UNSAFE_Read_16_Guid(){} // RVA: 0x8478930
        public void HasBufferData(){} // RVA: 0x3014D70
        public void ReadEntireStreamToBuffer(){} // RVA: 0x84789B0
        public void OnFreed(){} // RVA: 0x64D1270
        public void OnClaimed(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x8478DD0
    }

    public class BinaryDataWriter : BaseDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8479DA0
        public void BeginArrayNode(){} // RVA: 0x847A030
        public void BeginReferenceNode(){} // RVA: 0x847A0C0
        public void BeginStructNode(){} // RVA: 0x847A1D0
        public void Dispose(){} // RVA: 0x6935620
        public void EndArrayNode(){} // RVA: 0x847A290
        public void EndNode(){} // RVA: 0x847A2E0
        public void WritePrimitiveArray_byte(){} // RVA: 0x847A380
        public void WritePrimitiveArray_sbyte(){} // RVA: 0x847A4E0
        public void WritePrimitiveArray_bool(){} // RVA: 0x847A830
        public void WritePrimitiveArray_char(){} // RVA: 0x847AB80
        public void WritePrimitiveArray_short(){} // RVA: 0x847AEF0
        public void WritePrimitiveArray_int(){} // RVA: 0x847B260
        public void WritePrimitiveArray_long(){} // RVA: 0x847B5D0
        public void WritePrimitiveArray_ushort(){} // RVA: 0x847B940
        public void WritePrimitiveArray_uint(){} // RVA: 0x847BCB0
        public void WritePrimitiveArray_ulong(){} // RVA: 0x847C020
        public void WritePrimitiveArray_decimal(){} // RVA: 0x847C390
        public void WritePrimitiveArray_float(){} // RVA: 0x847C700
        public void WritePrimitiveArray_double(){} // RVA: 0x847CA70
        public void WritePrimitiveArray_Guid(){} // RVA: 0x847CDE0
        public void WritePrimitiveArray(){} // RVA: 0x894320
        public void WriteBoolean(){} // RVA: 0x847D150
        public void WriteByte(){} // RVA: 0x847D220
        public void WriteChar(){} // RVA: 0x847D2F0
        public void WriteDecimal(){} // RVA: 0x847D3D0
        public void WriteDouble(){} // RVA: 0x847D4C0
        public void WriteGuid(){} // RVA: 0x847D5A0
        public void WriteExternalReference(){} // RVA: 0x847D860
        public void WriteInt32(){} // RVA: 0x847D950
        public void WriteInt64(){} // RVA: 0x847DA30
        public void WriteNull(){} // RVA: 0x847DB10
        public void WriteInternalReference(){} // RVA: 0x847DBA0
        public void WriteSByte(){} // RVA: 0x847DC80
        public void WriteInt16(){} // RVA: 0x847DD50
        public void WriteSingle(){} // RVA: 0x847DE30
        public void WriteString(){} // RVA: 0x847DF10
        public void WriteUInt32(){} // RVA: 0x847DFB0
        public void WriteUInt64(){} // RVA: 0x847E090
        public void WriteUInt16(){} // RVA: 0x847E170
        public void PrepareNewSerializationSession(){} // RVA: 0x847E250
        public void GetDataDump(){} // RVA: 0x847E2B0
        public void WriteType(){} // RVA: 0x847E550
        public void WriteStringFast(){} // RVA: 0x847E810
        public void FlushToStream(){} // RVA: 0x847EFB0
        public void WriteValueTypeToBuffer(){} // RVA: 0xA94080
        public void UNSAFE_WriteToBuffer_2_Char(){} // RVA: 0x847F050
        public void UNSAFE_WriteToBuffer_2_Int16(){} // RVA: 0x847F0A0
        public void UNSAFE_WriteToBuffer_2_UInt16(){} // RVA: 0x847F0F0
        public void UNSAFE_WriteToBuffer_4_Int32(){} // RVA: 0x847F140
        public void UNSAFE_WriteToBuffer_4_UInt32(){} // RVA: 0x847F190
        public void UNSAFE_WriteToBuffer_4_Float32(){} // RVA: 0x847F1E0
        public void UNSAFE_WriteToBuffer_8_Int64(){} // RVA: 0x847F230
        public void UNSAFE_WriteToBuffer_8_UInt64(){} // RVA: 0x847F280
        public void UNSAFE_WriteToBuffer_8_Float64(){} // RVA: 0x847F2D0
        public void UNSAFE_WriteToBuffer_16_Decimal(){} // RVA: 0x847F320
        public void UNSAFE_WriteToBuffer_16_Guid(){} // RVA: 0x847F380
        public void EnsureBufferSpace(){} // RVA: 0x847F3E0
        public void TryEnsureBufferSpace(){} // RVA: 0x847F480
        public void .cctor(){} // RVA: 0x847F4D0
    }

    public class BindTypeNameToTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67462E0
    }

    public class BooleanSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B2F70
        public void WriteValue(){} // RVA: 0x84B3BE0
        public void .ctor(){} // RVA: 0x84B3C50
    }

    public class BoundsFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x84C8C50
        public void Write(){} // RVA: 0x84C8D50
        public void .ctor(){} // RVA: 0x84C8E80
        public void .cctor(){} // RVA: 0x84C8EE0
    }

    public class Buffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
        public void get_Count(){} // RVA: 0x87C130
        public void get_Array(){} // RVA: 0x87C0A0
        public void get_IsFree(){} // RVA: 0x87D280
        public void Claim(){} // RVA: 0x881E70
        public void Free(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894290
        public void NextPowerOfTwo(){} // RVA: 0x883700
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84B3CC0
        public void WriteValue(){} // RVA: 0x84B4930
        public void .ctor(){} // RVA: 0x84B49A0
    }

}