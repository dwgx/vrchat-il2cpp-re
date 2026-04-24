// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 45
// Methods: 742

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class BaseDataReader : BaseDataReaderWriter
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf9e13c0
        public void get_CurrentNodeId(){} // RVA: 0x7ffaaf9e1460
        public void get_CurrentNodeDepth(){} // RVA: 0x7ffaa8b945a0
        public void get_CurrentNodeName(){} // RVA: 0x7ffaaf9e1480
        public void get_Stream(){} // RVA: 0x7ffaa8960130
        public void set_Stream(){} // RVA: 0x7ffaaf9e14a0
        public void get_Context(){} // RVA: 0x7ffaaf9e15c0
        public void set_Context(){} // RVA: 0x7ffaa89600d0
        public void EnterNode(){} // RVA: 0x7ffaa864a2a0
        public void ExitNode(){} // RVA: 0x7ffaa864a040
        public void EnterArray(){} // RVA: 0x7ffaa864a2a0
        public void ExitArray(){} // RVA: 0x7ffaa864a040
        public void ReadPrimitiveArray(){} // RVA: 0x7ffaa864a2a0
        public void PeekEntry(){} // RVA: 0x7ffaa864a040
        public void ReadInternalReference(){} // RVA: 0x7ffaa864a2a0
        public void ReadExternalReference(){} // RVA: 0x7ffaa864a2a0
        public void ReadExternalReference(){} // RVA: 0x7ffaa864a2a0
        public void ReadExternalReference(){} // RVA: 0x7ffaa864a2a0
        public void ReadChar(){} // RVA: 0x7ffaa864a2a0
        public void ReadString(){} // RVA: 0x7ffaa864a2a0
        public void ReadGuid(){} // RVA: 0x7ffaa864a2a0
        public void ReadSByte(){} // RVA: 0x7ffaa864a2a0
        public void ReadInt16(){} // RVA: 0x7ffaa864a2a0
        public void ReadInt32(){} // RVA: 0x7ffaa864a2a0
        public void ReadInt64(){} // RVA: 0x7ffaa864a2a0
        public void ReadByte(){} // RVA: 0x7ffaa864a2a0
        public void ReadUInt16(){} // RVA: 0x7ffaa864a2a0
        public void ReadUInt32(){} // RVA: 0x7ffaa864a2a0
        public void ReadUInt64(){} // RVA: 0x7ffaa864a2a0
        public void ReadDecimal(){} // RVA: 0x7ffaa864a2a0
        public void ReadSingle(){} // RVA: 0x7ffaa864a2a0
        public void ReadDouble(){} // RVA: 0x7ffaa864a2a0
        public void ReadBoolean(){} // RVA: 0x7ffaa864a2a0
        public void ReadNull(){} // RVA: 0x7ffaa864a040
        public void SkipEntry(){} // RVA: 0x7ffaaf9e16c0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaa90bf2b0
        public void PeekEntry(){} // RVA: 0x7ffaa864a040
        public void ReadToNextEntry(){} // RVA: 0x7ffaa864a040
        // ── Binary Analysis Named ──
        public void GetDataDump(){} // RVA: 0x7ffaa86491d0
    }

    public class BaseDataReaderWriter : Object
    {
        // ── Original Methods ──
        public void get_Binder(){} // RVA: 0x7ffaaf9e1cc0
        public void set_Binder(){} // RVA: 0x7ffaaf9e1e00
        public void get_IsInArrayNode(){} // RVA: 0x7ffaaf9e1fc0
        public void get_NodeDepth(){} // RVA: 0x7ffaa8b945a0
        public void get_NodesArray(){} // RVA: 0x7ffaa894d380
        public void get_CurrentNode(){} // RVA: 0x7ffaaf9e2010
        public void PushNode(){} // RVA: 0x7ffaaf9e2190
        public void PushNode(){} // RVA: 0x7ffaaf9e2190
        public void PushArray(){} // RVA: 0x7ffaaf9e22c0
        public void ExpandNodes(){} // RVA: 0x7ffaaf9e25e0
        public void PopNode(){} // RVA: 0x7ffaaf9e2760
        public void PopArray(){} // RVA: 0x7ffaaf9e27d0
        public void ClearNodes(){} // RVA: 0x7ffaa90bf2b0
        public void .ctor(){} // RVA: 0x7ffaaf9e28b0
    }

    public class BaseDataWriter : BaseDataReaderWriter
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf9e2940
        public void get_Stream(){} // RVA: 0x7ffaa8960130
        public void set_Stream(){} // RVA: 0x7ffaaf9e29e0
        public void get_Context(){} // RVA: 0x7ffaaf9e2b00
        public void set_Context(){} // RVA: 0x7ffaa89600d0
        public void FlushToStream(){} // RVA: 0x7ffaaf9e2c00
        public void EndNode(){} // RVA: 0x7ffaa8660d80
        public void EndArrayNode(){} // RVA: 0x7ffaa8660cc0
        public void WritePrimitiveArray(){} // RVA: 0x7ffaa8660d80
        public void WriteNull(){} // RVA: 0x7ffaa8660d80
        public void WriteInternalReference(){} // RVA: 0x7ffaa8667cb0
        public void WriteExternalReference(){} // RVA: 0x7ffaa8669e70
        public void WriteExternalReference(){} // RVA: 0x7ffaa8669e70
        public void WriteExternalReference(){} // RVA: 0x7ffaa8669e70
        public void WriteChar(){}
        public void WriteString(){} // RVA: 0x7ffaa8669e70
        public void WriteGuid(){}
        public void WriteSByte(){}
        public void WriteInt16(){}
        public void WriteInt32(){} // RVA: 0x7ffaa8667cb0
        public void WriteInt64(){} // RVA: 0x7ffaa86664f0
        public void WriteByte(){} // RVA: 0x7ffaa8666840
        public void WriteUInt16(){}
        public void WriteUInt32(){}
        public void WriteUInt64(){}
        public void WriteDecimal(){}
        public void WriteSingle(){} // RVA: 0x7ffaa866daf0
        public void WriteDouble(){}
        public void WriteBoolean(){} // RVA: 0x7ffaa8666840
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaa90bf2b0
        // ── Binary Analysis Named ──
        public void BeginReferenceNode(){}
        public void BeginStructNode(){} // RVA: 0x7ffaa8669e70
        public void BeginArrayNode(){} // RVA: 0x7ffaa8660f30
        public void GetDataDump(){} // RVA: 0x7ffaa86491d0
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Original Methods ──
        public void get_ProviderID(){} // RVA: 0x7ffaa86491d0
        public void Compare(){} // RVA: 0x7ffaa887e5c0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7ffaa8653ae0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7ffaa8649280
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7ffaa8649280
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetKeyFromPathString(){} // RVA: 0x7ffaa887e5c0
        public void GetPathStringFromKey(){} // RVA: 0x7ffaa887e5c0
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Original Methods ──
        public void get_ProviderID(){} // RVA: 0x7ffaa86491d0
        public void Compare(){}
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7ffaad672dd0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7ffaad672ee0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7ffaad672f20
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetKeyFromPathString(){} // RVA: 0x7ffaa8649280
        public void GetPathStringFromKey(){}
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Original Methods ──
        public void get_ProviderID(){} // RVA: 0x7ffaa86491d0
        public void Compare(){}
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7ffaad672fb0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7ffaad6730c0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7ffaad673120
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetKeyFromPathString(){} // RVA: 0x7ffaa8649370
        public void GetPathStringFromKey(){}
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Original Methods ──
        public void get_ProviderID(){} // RVA: 0x7ffaa86491d0
        public void Compare(){}
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7ffaad6731b0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7ffaad6732b0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7ffaad673300
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetKeyFromPathString(){} // RVA: 0x7ffaa8649370
        public void GetPathStringFromKey(){}
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x302D6A48
        public object ImplementsISerializationCallbackReceiver; // 0x302D6A48

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30BB8030
        public object ImplementsISerializationCallbackReceiver; // 0x30BB8030

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void CreateCallback(){} // RVA: 0x7ffaa86492c0
        public void get_SerializedType(){} // RVA: 0x7ffaa86491d0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaa8669e70
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaa8649280
        public void Deserialize(){} // RVA: 0x7ffaa887e5c0
        public void Serialize(){} // RVA: 0x7ffaa887e5c0
        public void RegisterReferenceID(){} // RVA: 0x7ffaa887e5c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaa8669e70
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaa8669e70
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaa8659940
        public void GetUninitializedObject(){} // RVA: 0x7ffaa887e5c0
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30BEC288
        public object ImplementsISerializationCallbackReceiver; // 0x30BEC288

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30CAEF60
        public object ImplementsISerializationCallbackReceiver; // 0x30CAEF60

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30CAF380
        public object ImplementsISerializationCallbackReceiver; // 0x30CAF380

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30CB8AD8
        public object ImplementsISerializationCallbackReceiver; // 0x30CB8AD8

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30E2E088
        public object ImplementsISerializationCallbackReceiver; // 0x30E2E088

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30E2E970
        public object ImplementsISerializationCallbackReceiver; // 0x30E2E970

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30E72D70
        public object ImplementsISerializationCallbackReceiver; // 0x30E72D70

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30E7AAB0
        public object ImplementsISerializationCallbackReceiver; // 0x30E7AAB0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30E7EB40
        public object ImplementsISerializationCallbackReceiver; // 0x30E7EB40

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30E7F780
        public object ImplementsISerializationCallbackReceiver; // 0x30E7F780

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30FD6350
        public object ImplementsISerializationCallbackReceiver; // 0x30FD6350

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x30FDC888
        public object ImplementsISerializationCallbackReceiver; // 0x30FDC888

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x3113CAC0
        public object ImplementsISerializationCallbackReceiver; // 0x3113CAC0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaa884bb60
        public void RegisterReferenceID(){} // RVA: 0x7ffaa884bb60
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x311528F8
        public object ImplementsISerializationCallbackReceiver; // 0x311528F8

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x3123EB48
        public object ImplementsISerializationCallbackReceiver; // 0x3123EB48

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x3124B998
        public object ImplementsISerializationCallbackReceiver; // 0x3124B998

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaa884bb60
        public void RegisterReferenceID(){} // RVA: 0x7ffaa884bb60
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x312A4FC0
        public object ImplementsISerializationCallbackReceiver; // 0x312A4FC0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x312F9DB0
        public object ImplementsISerializationCallbackReceiver; // 0x312F9DB0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x312FA688
        public object ImplementsISerializationCallbackReceiver; // 0x312FA688

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x3137AC50
        public object ImplementsISerializationCallbackReceiver; // 0x3137AC50

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x313A7038
        public object ImplementsISerializationCallbackReceiver; // 0x313A7038

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaad7869b0
        public void RegisterReferenceID(){} // RVA: 0x7ffaad787460
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x313B2170
        public object ImplementsISerializationCallbackReceiver; // 0x313B2170

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x31497FF0
        public object ImplementsISerializationCallbackReceiver; // 0x31497FF0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaa884bb60
        public void RegisterReferenceID(){} // RVA: 0x7ffaa884bb60
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x314983E8
        public object ImplementsISerializationCallbackReceiver; // 0x314983E8

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaa884bb60
        public void RegisterReferenceID(){} // RVA: 0x7ffaa884bb60
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x314987E0
        public object ImplementsISerializationCallbackReceiver; // 0x314987E0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad784450
        public void CreateCallback(){} // RVA: 0x7ffaad7855c0
        public void get_SerializedType(){} // RVA: 0x7ffaad785a30
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad785ae0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad785cb0
        public void Deserialize(){} // RVA: 0x7ffaa884bb60
        public void Serialize(){} // RVA: 0x7ffaa884bb60
        public void RegisterReferenceID(){} // RVA: 0x7ffaa884bb60
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad7876a0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad785360
        public void GetUninitializedObject(){} // RVA: 0x7ffaa884bb60
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x33629970
        public object ImplementsISerializationCallbackReceiver; // 0x33629970

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x33A41AC0
        public object ImplementsISerializationCallbackReceiver; // 0x33A41AC0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x33C13028
        public object ImplementsISerializationCallbackReceiver; // 0x33C13028

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad6e97a0
        public void CreateCallback(){} // RVA: 0x7ffaad6ea800
        public void get_SerializedType(){} // RVA: 0x7ffaad6eabd0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad6eac80
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad6ead30
        public void Deserialize(){} // RVA: 0x7ffaad6eada0
        public void Serialize(){} // RVA: 0x7ffaad6eb470
        public void RegisterReferenceID(){} // RVA: 0x7ffaad6ebba0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad6ea630
        public void GetUninitializedObject(){} // RVA: 0x7ffaad6eba10
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x33C8F390
        public object ImplementsISerializationCallbackReceiver; // 0x33C8F390

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BaseFormatter`1 : Object
    {
        public object OnDeserializingCallbacks; // 0x33E42210
        public object ImplementsISerializationCallbackReceiver; // 0x33E42210
        public object  v\4; // 0x1D0034
        public object  v\4; // 0x1D0034

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaad73b4b0
        public void CreateCallback(){} // RVA: 0x7ffaad73c510
        public void get_SerializedType(){} // RVA: 0x7ffaad73c8e0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7ffaad73c990
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7ffaad73ca30
        public void Deserialize(){} // RVA: 0x7ffaad73ca50
        public void Serialize(){} // RVA: 0x7ffaad73d270
        public void RegisterReferenceID(){} // RVA: 0x7ffaad73d9b0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7ffaad6c35c0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetCallbacks(){} // RVA: 0x7ffaad73c340
        public void GetUninitializedObject(){} // RVA: 0x7ffaad73d850
    }

    public class BinaryDataReader : BaseDataReader
    {
        public object buffer; // 0x316F61D0
        public object peekedEntryType; // 0x316F61D0
        public object types; // 0x316F61D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf9e2ee0
        public void .ctor(){} // RVA: 0x7ffaaf9e2ee0
        public void Dispose(){} // RVA: 0x7ffaa8932310
        public void PeekEntry(){} // RVA: 0x7ffaaf9e6de0
        public void EnterArray(){} // RVA: 0x7ffaaf9e37a0
        public void EnterNode(){} // RVA: 0x7ffaaf9e3940
        public void ExitArray(){} // RVA: 0x7ffaaf9e3b90
        public void ExitNode(){} // RVA: 0x7ffaaf9e3cd0
        public void ReadPrimitiveArray(){} // RVA: 0x7ffaa864a2a0
        public void ReadBoolean(){} // RVA: 0x7ffaaf9e3e70
        public void ReadSByte(){} // RVA: 0x7ffaaf9e3f80
        public void ReadByte(){} // RVA: 0x7ffaaf9e4030
        public void ReadInt16(){} // RVA: 0x7ffaaf9e40e0
        public void ReadUInt16(){} // RVA: 0x7ffaaf9e41a0
        public void ReadInt32(){} // RVA: 0x7ffaaf9e4260
        public void ReadUInt32(){} // RVA: 0x7ffaaf9e4320
        public void ReadInt64(){} // RVA: 0x7ffaaf9e43e0
        public void ReadUInt64(){} // RVA: 0x7ffaaf9e48b0
        public void ReadChar(){} // RVA: 0x7ffaaf9e4d40
        public void ReadSingle(){} // RVA: 0x7ffaaf9e4e70
        public void ReadDouble(){} // RVA: 0x7ffaaf9e50d0
        public void ReadDecimal(){} // RVA: 0x7ffaaf9e5350
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9e5940
        public void ReadGuid(){} // RVA: 0x7ffaaf9e57c0
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9e5940
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9e5940
        public void ReadNull(){} // RVA: 0x7ffaaf9e5aa0
        public void ReadInternalReference(){} // RVA: 0x7ffaaf9e5b30
        public void ReadString(){} // RVA: 0x7ffaaf9e5c00
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaaf9e5d60
        public void ReadStringValue(){} // RVA: 0x7ffaaf9e5ff0
        public void SkipStringValue(){} // RVA: 0x7ffaaf9e62f0
        public void SkipPeekedEntryContent(){} // RVA: 0x7ffaaf9e63e0
        public void SkipBuffer(){} // RVA: 0x7ffaaf9e68c0
        public void ReadTypeEntry(){} // RVA: 0x7ffaaf9e68e0
        public void MarkEntryContentConsumed(){} // RVA: 0x7ffaaaa8a660
        public void PeekEntry(){} // RVA: 0x7ffaaf9e6de0
        public void ReadToNextEntry(){} // RVA: 0x7ffaaf9e6e10
        public void UNSAFE_Read_1_Byte(){} // RVA: 0x7ffaaf9e6e50
        public void UNSAFE_Read_1_SByte(){} // RVA: 0x7ffaaf9e6e50
        public void ReadValueTypeFromBuffer(){} // RVA: 0x7ffaa864a2a0
        public void UNSAFE_Read_2_Int16(){} // RVA: 0x7ffaaf9e6ec0
        public void UNSAFE_Read_2_UInt16(){} // RVA: 0x7ffaaf9e6f10
        public void UNSAFE_Read_2_Char(){} // RVA: 0x7ffaaf9e6f60
        public void UNSAFE_Read_4_Int32(){} // RVA: 0x7ffaaf9e6fb0
        public void UNSAFE_Read_4_UInt32(){} // RVA: 0x7ffaaf9e7000
        public void UNSAFE_Read_4_Float32(){} // RVA: 0x7ffaaf9e7050
        public void UNSAFE_Read_8_Int64(){} // RVA: 0x7ffaaf9e70a0
        public void UNSAFE_Read_8_UInt64(){} // RVA: 0x7ffaaf9e70f0
        public void UNSAFE_Read_8_Float64(){} // RVA: 0x7ffaaf9e7140
        public void UNSAFE_Read_16_Decimal(){} // RVA: 0x7ffaaf9e7190
        public void UNSAFE_Read_16_Guid(){} // RVA: 0x7ffaaf9e71e0
        public void HasBufferData(){} // RVA: 0x7ffaaaa8a6c0
        public void ReadEntireStreamToBuffer(){} // RVA: 0x7ffaaf9e7260
        public void OnFreed(){} // RVA: 0x7ffaadc0f630
        public void OnClaimed(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf9e7680
        // ── Binary Analysis Named ──
        public void GetDataDump(){} // RVA: 0x7ffaaf9e5e80
    }

    public class BinaryDataWriter : BaseDataWriter
    {
        public object small_buffer; // 0x316F6840
        public object types; // 0x316F6840
        public object value__; // 0x84A14330

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf9e88b0
        public void .ctor(){} // RVA: 0x7ffaaf9e88b0
        public void Dispose(){} // RVA: 0x7ffaae075210
        public void EndArrayNode(){} // RVA: 0x7ffaaf9e8d80
        public void EndNode(){} // RVA: 0x7ffaaf9e8dd0
        public void WritePrimitiveArray_byte(){} // RVA: 0x7ffaaf9e8e70
        public void WritePrimitiveArray_sbyte(){} // RVA: 0x7ffaaf9e8fd0
        public void WritePrimitiveArray_bool(){} // RVA: 0x7ffaaf9e9330
        public void WritePrimitiveArray_char(){} // RVA: 0x7ffaaf9e9690
        public void WritePrimitiveArray_short(){} // RVA: 0x7ffaaf9e9a00
        public void WritePrimitiveArray_int(){} // RVA: 0x7ffaaf9e9d70
        public void WritePrimitiveArray_long(){} // RVA: 0x7ffaaf9ea0e0
        public void WritePrimitiveArray_ushort(){} // RVA: 0x7ffaaf9ea450
        public void WritePrimitiveArray_uint(){} // RVA: 0x7ffaaf9ea7c0
        public void WritePrimitiveArray_ulong(){} // RVA: 0x7ffaaf9eab30
        public void WritePrimitiveArray_decimal(){} // RVA: 0x7ffaaf9eaea0
        public void WritePrimitiveArray_float(){} // RVA: 0x7ffaaf9eb210
        public void WritePrimitiveArray_double(){} // RVA: 0x7ffaaf9eb580
        public void WritePrimitiveArray_Guid(){} // RVA: 0x7ffaaf9eb8f0
        public void WritePrimitiveArray(){} // RVA: 0x7ffaa8660d80
        public void WriteBoolean(){} // RVA: 0x7ffaaf9ebc60
        public void WriteByte(){} // RVA: 0x7ffaaf9ebd30
        public void WriteChar(){} // RVA: 0x7ffaaf9ebe00
        public void WriteDecimal(){} // RVA: 0x7ffaaf9ebee0
        public void WriteDouble(){} // RVA: 0x7ffaaf9ebfd0
        public void WriteGuid(){} // RVA: 0x7ffaaf9ec0b0
        public void WriteExternalReference(){} // RVA: 0x7ffaaf9ec370
        public void WriteExternalReference(){} // RVA: 0x7ffaaf9ec370
        public void WriteExternalReference(){} // RVA: 0x7ffaaf9ec370
        public void WriteInt32(){} // RVA: 0x7ffaaf9ec460
        public void WriteInt64(){} // RVA: 0x7ffaaf9ec540
        public void WriteNull(){} // RVA: 0x7ffaaf9ec620
        public void WriteInternalReference(){} // RVA: 0x7ffaaf9ec6b0
        public void WriteSByte(){} // RVA: 0x7ffaaf9ec790
        public void WriteInt16(){} // RVA: 0x7ffaaf9ec860
        public void WriteSingle(){} // RVA: 0x7ffaaf9ec940
        public void WriteString(){} // RVA: 0x7ffaaf9eca20
        public void WriteUInt32(){} // RVA: 0x7ffaaf9ecac0
        public void WriteUInt64(){} // RVA: 0x7ffaaf9ecba0
        public void WriteUInt16(){} // RVA: 0x7ffaaf9ecc80
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaaf9ecd60
        public void WriteType(){} // RVA: 0x7ffaaf9ed060
        public void WriteStringFast(){} // RVA: 0x7ffaaf9ed330
        public void FlushToStream(){} // RVA: 0x7ffaaf9edac0
        public void WriteValueTypeToBuffer(){} // RVA: 0x7ffaa887e5c0
        public void UNSAFE_WriteToBuffer_2_Char(){} // RVA: 0x7ffaaf9edb60
        public void UNSAFE_WriteToBuffer_2_Int16(){} // RVA: 0x7ffaaf9edbb0
        public void UNSAFE_WriteToBuffer_2_UInt16(){} // RVA: 0x7ffaaf9edc00
        public void UNSAFE_WriteToBuffer_4_Int32(){} // RVA: 0x7ffaaf9edc50
        public void UNSAFE_WriteToBuffer_4_UInt32(){} // RVA: 0x7ffaaf9edca0
        public void UNSAFE_WriteToBuffer_4_Float32(){} // RVA: 0x7ffaaf9edcf0
        public void UNSAFE_WriteToBuffer_8_Int64(){} // RVA: 0x7ffaaf9edd40
        public void UNSAFE_WriteToBuffer_8_UInt64(){} // RVA: 0x7ffaaf9edd90
        public void UNSAFE_WriteToBuffer_8_Float64(){} // RVA: 0x7ffaaf9edde0
        public void UNSAFE_WriteToBuffer_16_Decimal(){} // RVA: 0x7ffaaf9ede30
        public void UNSAFE_WriteToBuffer_16_Guid(){} // RVA: 0x7ffaaf9ede90
        public void EnsureBufferSpace(){} // RVA: 0x7ffaaf9edef0
        public void TryEnsureBufferSpace(){} // RVA: 0x7ffaaf9edf90
        public void .cctor(){} // RVA: 0x7ffaaf9edfe0
        // ── Binary Analysis Named ──
        public void BeginArrayNode(){} // RVA: 0x7ffaaf9e8b20
        public void BeginReferenceNode(){} // RVA: 0x7ffaaf9e8bb0
        public void BeginStructNode(){} // RVA: 0x7ffaaf9e8cc0
        public void GetDataDump(){} // RVA: 0x7ffaaf9ecdc0
    }

    public class BooleanSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa23330
        public void WriteValue(){} // RVA: 0x7ffaafa24000
        public void .ctor(){} // RVA: 0x7ffaafa24070
    }

    public class BoundsFormatter : MinimalBaseFormatter`1
    {
        // ── Original Methods ──
        public void Read(){} // RVA: 0x7ffaafa3a470
        public void Write(){} // RVA: 0x7ffaafa3a570
        public void .ctor(){} // RVA: 0x7ffaafa3a6a0
        public void .cctor(){} // RVA: 0x7ffaafa3a700
    }

    public class Buffer`1 : Object
    {
        public object count; // 0x30DE5BE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_Array(){} // RVA: 0x7ffaa86491d0
        public void get_IsFree(){} // RVA: 0x7ffaa864a040
        public void Claim(){} // RVA: 0x7ffaa864ec00
        public void Free(){} // RVA: 0x7ffaa8660cc0
        public void Free(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void NextPowerOfTwo(){} // RVA: 0x7ffaa8650450
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class ByteSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa240e0
        public void WriteValue(){} // RVA: 0x7ffaafa24db0
        public void .ctor(){} // RVA: 0x7ffaafa24e20
    }

}