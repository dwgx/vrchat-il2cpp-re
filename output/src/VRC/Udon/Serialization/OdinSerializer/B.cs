// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 11
// Methods: 253

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class BaseDataReader : BaseDataReaderWriter
    {
        public VRC.Udon.Serialization.OdinSerializer.DeserializationContext CurrentNodeId; // 0x20
        public System.IO.Stream CurrentNodeDepth; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD553DE9A0
        public void get_CurrentNodeId(){} // RVA: 0x7FFD553DEA40
        public void get_CurrentNodeDepth(){} // RVA: 0x7FFD4E577800
        public void get_CurrentNodeName(){} // RVA: 0x7FFD553DEA60
        public void get_Stream(){} // RVA: 0x7FFD4E36F130
        public void set_Stream(){} // RVA: 0x7FFD553DEA80
        public void get_Context(){} // RVA: 0x7FFD553DEBA0
        public void set_Context(){} // RVA: 0x7FFD4E36F0D0
        public void EnterNode(){} // RVA: 0x7FFD4E079F60
        public void ExitNode(){} // RVA: 0x7FFD4E079D00
        public void EnterArray(){} // RVA: 0x7FFD4E079F60
        public void ExitArray(){} // RVA: 0x7FFD4E079D00
        public void ReadPrimitiveArray(){} // RVA: 0x7FFD4E079F60
        public void PeekEntry(){} // RVA: 0x7FFD4E079D00 | overloaded x2
        public void ReadInternalReference(){} // RVA: 0x7FFD4E079F60
        public void ReadExternalReference(){} // RVA: 0x7FFD4E079F60 | overloaded x3
        public void ReadChar(){} // RVA: 0x7FFD4E079F60
        public void ReadString(){} // RVA: 0x7FFD4E079F60
        public void ReadGuid(){} // RVA: 0x7FFD4E079F60
        public void ReadSByte(){} // RVA: 0x7FFD4E079F60
        public void ReadInt16(){} // RVA: 0x7FFD4E079F60
        public void ReadInt32(){} // RVA: 0x7FFD4E079F60
        public void ReadInt64(){} // RVA: 0x7FFD4E079F60
        public void ReadByte(){} // RVA: 0x7FFD4E079F60
        public void ReadUInt16(){} // RVA: 0x7FFD4E079F60
        public void ReadUInt32(){} // RVA: 0x7FFD4E079F60
        public void ReadUInt64(){} // RVA: 0x7FFD4E079F60
        public void ReadDecimal(){} // RVA: 0x7FFD4E079F60
        public void ReadSingle(){} // RVA: 0x7FFD4E079F60
        public void ReadDouble(){} // RVA: 0x7FFD4E079F60
        public void ReadBoolean(){} // RVA: 0x7FFD4E079F60
        public void ReadNull(){} // RVA: 0x7FFD4E079D00
        public void SkipEntry(){} // RVA: 0x7FFD553DECA0
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFD4EAB70B0
        public void GetDataDump(){} // RVA: 0x7FFD4E078E90
        public void ReadToNextEntry(){} // RVA: 0x7FFD4E079D00
    }

    public class BaseDataReaderWriter : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.NodeInfo[] Binder; // 0x10
        public int IsInArrayNode; // 0x18

        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFD553DF2A0
        public void set_Binder(){} // RVA: 0x7FFD553DF3E0
        public void get_IsInArrayNode(){} // RVA: 0x7FFD553DF5A0
        public void get_NodeDepth(){} // RVA: 0x7FFD4E577800
        public void get_NodesArray(){} // RVA: 0x7FFD4E35C380
        public void get_CurrentNode(){} // RVA: 0x7FFD553DF5F0
        public void PushNode(){} // RVA: 0x7FFD553DF770 | overloaded x2
        public void PushArray(){} // RVA: 0x7FFD553DF8A0
        public void ExpandNodes(){} // RVA: 0x7FFD553DFBC0
        public void PopNode(){} // RVA: 0x7FFD553DFD40
        public void PopArray(){} // RVA: 0x7FFD553DFDB0
        public void ClearNodes(){} // RVA: 0x7FFD4EAB70B0
        public void .ctor(){} // RVA: 0x7FFD553DFE90
    }

    public class BaseDataWriter : BaseDataReaderWriter
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationContext Stream; // 0x20
        public System.IO.Stream Context; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD553DFF20
        public void get_Stream(){} // RVA: 0x7FFD4E36F130
        public void set_Stream(){} // RVA: 0x7FFD553DFFC0
        public void get_Context(){} // RVA: 0x7FFD553E00E0
        public void set_Context(){} // RVA: 0x7FFD4E36F0D0
        public void FlushToStream(){} // RVA: 0x7FFD553E01E0
        public void BeginReferenceNode(){}
        public void BeginStructNode(){} // RVA: 0x7FFD4E099B30
        public void EndNode(){} // RVA: 0x7FFD4E090A40
        public void BeginArrayNode(){} // RVA: 0x7FFD4E090BF0
        public void EndArrayNode(){} // RVA: 0x7FFD4E090980
        public void WritePrimitiveArray(){} // RVA: 0x7FFD4E090A40
        public void WriteNull(){} // RVA: 0x7FFD4E090A40
        public void WriteInternalReference(){} // RVA: 0x7FFD4E097970
        public void WriteExternalReference(){} // RVA: 0x7FFD4E099B30 | overloaded x3
        public void WriteChar(){}
        public void WriteString(){} // RVA: 0x7FFD4E099B30
        public void WriteGuid(){}
        public void WriteSByte(){}
        public void WriteInt16(){}
        public void WriteInt32(){} // RVA: 0x7FFD4E097970
        public void WriteInt64(){} // RVA: 0x7FFD4E0961B0
        public void WriteByte(){} // RVA: 0x7FFD4E096500
        public void WriteUInt16(){}
        public void WriteUInt32(){}
        public void WriteUInt64(){}
        public void WriteDecimal(){}
        public void WriteSingle(){} // RVA: 0x7FFD4E09D7B0
        public void WriteDouble(){}
        public void WriteBoolean(){} // RVA: 0x7FFD4E096500
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFD4EAB70B0
        public void GetDataDump(){} // RVA: 0x7FFD4E078E90
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        public System.Collections.Immutable.SecureObjectPool`2<System.Collections.Generic.Stack`1<System.Collections.Immutable.RefAsValueType`1<Node<T>>>,Enumerator<T>> ProviderID;

        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFD4E078E90
        public void GetKeyFromPathString(){} // RVA: 0x7FFD4E2ADC40
        public void GetPathStringFromKey(){} // RVA: 0x7FFD4E2ADC40
        public void Compare(){} // RVA: 0x7FFD4E2ADC40
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7FFD4E0837A0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7FFD4E078F40
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class BaseFormatter`1 : Object
    {
        public SerializationCallback<VRC.SDKBase.VRCUrl>[] SerializedType;
        public SerializationCallback<VRC.SDKBase.VRCUrl>[] OnSerializedCallbacks; // 0x8
        public SerializationCallback<VRC.SDKBase.VRCUrl>[] OnDeserializingCallbacks; // 0x10
        public SerializationCallback<VRC.SDKBase.VRCUrl>[] OnDeserializedCallbacks; // 0x18
        public bool IsValueType; // 0x20
        public bool ImplementsISerializationCallbackReceiver; // 0x21
        public bool ImplementsIDeserializationCallback; // 0x22
        public bool ImplementsIObjectReference; // 0x23

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5316FAD0
        public void GetCallbacks(){} // RVA: 0x7FFD531709E0
        public void CreateCallback(){} // RVA: 0x7FFD53170C40
        public void get_SerializedType(){} // RVA: 0x7FFD531710B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFD53171160
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFD53171330
        public void Deserialize(){} // RVA: 0x7FFD4E27B230
        public void Serialize(){} // RVA: 0x7FFD53172030
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E27B230
        public void RegisterReferenceID(){} // RVA: 0x7FFD53172AE0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFD53172D20 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class BinaryDataReader : BaseDataReader
    {
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> PrimitiveFromByteMethods;
        public byte[] internalBufferBackup; // 0x30
        public byte[] buffer; // 0x38
        public int bufferIndex; // 0x40
        public int bufferEnd; // 0x44
        public System.Nullable`1<0x66583DD8> peekedEntryType; // 0x48
        public 0x66582258 peekedBinaryEntryType; // 0x4A
        public string peekedEntryName; // 0x50
        public System.Collections.Generic.Dictionary`2<int,System.Type> types; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD553E04C0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFD4E341310
        public void PeekEntry(){} // RVA: 0x7FFD553E43C0 | overloaded x2
        public void EnterArray(){} // RVA: 0x7FFD553E0D80
        public void EnterNode(){} // RVA: 0x7FFD553E0F20
        public void ExitArray(){} // RVA: 0x7FFD553E1170
        public void ExitNode(){} // RVA: 0x7FFD553E12B0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFD4E079F60
        public void ReadBoolean(){} // RVA: 0x7FFD553E1450
        public void ReadSByte(){} // RVA: 0x7FFD553E1560
        public void ReadByte(){} // RVA: 0x7FFD553E1610
        public void ReadInt16(){} // RVA: 0x7FFD553E16C0
        public void ReadUInt16(){} // RVA: 0x7FFD553E1780
        public void ReadInt32(){} // RVA: 0x7FFD553E1840
        public void ReadUInt32(){} // RVA: 0x7FFD553E1900
        public void ReadInt64(){} // RVA: 0x7FFD553E19C0
        public void ReadUInt64(){} // RVA: 0x7FFD553E1E90
        public void ReadChar(){} // RVA: 0x7FFD553E2320
        public void ReadSingle(){} // RVA: 0x7FFD553E2450
        public void ReadDouble(){} // RVA: 0x7FFD553E26B0
        public void ReadDecimal(){} // RVA: 0x7FFD553E2930
        public void ReadExternalReference(){} // RVA: 0x7FFD553E2F20 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7FFD553E2DA0
        public void ReadNull(){} // RVA: 0x7FFD553E3080
        public void ReadInternalReference(){} // RVA: 0x7FFD553E3110
        public void ReadString(){} // RVA: 0x7FFD553E31E0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFD553E3340
        public void GetDataDump(){} // RVA: 0x7FFD553E3460
        public void ReadStringValue(){} // RVA: 0x7FFD553E35D0
        public void SkipStringValue(){} // RVA: 0x7FFD553E38D0
        public void SkipPeekedEntryContent(){} // RVA: 0x7FFD553E39C0
        public void SkipBuffer(){} // RVA: 0x7FFD553E3EA0
        public void ReadTypeEntry(){} // RVA: 0x7FFD553E3EC0
        public void MarkEntryContentConsumed(){} // RVA: 0x7FFD504A8700
        public void ReadToNextEntry(){} // RVA: 0x7FFD553E43F0
        public void UNSAFE_Read_1_Byte(){} // RVA: 0x7FFD553E4430
        public void UNSAFE_Read_1_SByte(){} // RVA: 0x7FFD553E4430
        public void ReadValueTypeFromBuffer(){} // RVA: 0x7FFD4E079F60
        public void UNSAFE_Read_2_Int16(){} // RVA: 0x7FFD553E44A0
        public void UNSAFE_Read_2_UInt16(){} // RVA: 0x7FFD553E44F0
        public void UNSAFE_Read_2_Char(){} // RVA: 0x7FFD553E4540
        public void UNSAFE_Read_4_Int32(){} // RVA: 0x7FFD553E4590
        public void UNSAFE_Read_4_UInt32(){} // RVA: 0x7FFD553E45E0
        public void UNSAFE_Read_4_Float32(){} // RVA: 0x7FFD553E4630
        public void UNSAFE_Read_8_Int64(){} // RVA: 0x7FFD553E4680
        public void UNSAFE_Read_8_UInt64(){} // RVA: 0x7FFD553E46D0
        public void UNSAFE_Read_8_Float64(){} // RVA: 0x7FFD553E4720
        public void UNSAFE_Read_16_Decimal(){} // RVA: 0x7FFD553E4770
        public void UNSAFE_Read_16_Guid(){} // RVA: 0x7FFD553E47C0
        public void HasBufferData(){} // RVA: 0x7FFD504A8760
        public void ReadEntireStreamToBuffer(){} // RVA: 0x7FFD553E4840
        public void OnFreed(){} // RVA: 0x7FFD5360E480
        public void OnClaimed(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD553E4C60
    }

    public class BinaryDataWriter : BaseDataWriter
    {
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> PrimitiveGetBytesMethods;
        public System.Collections.Generic.Dictionary`2<System.Type,int> PrimitiveSizes; // 0x8
        public byte[] small_buffer; // 0x30
        public byte[] buffer; // 0x38
        public int bufferIndex; // 0x40
        public System.Collections.Generic.Dictionary`2<System.Type,int> types; // 0x48
        public bool CompressStringsTo8BitWhenPossible; // 0x50
        public System.Collections.Generic.Dictionary`2<System.Type,System.Action`2<VRC.Udon.Serialization.OdinSerializer.BinaryDataWriter,object>> PrimitiveArrayWriters; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD553E5E90 | overloaded x2
        public void BeginArrayNode(){} // RVA: 0x7FFD553E6100
        public void BeginReferenceNode(){} // RVA: 0x7FFD553E6190
        public void BeginStructNode(){} // RVA: 0x7FFD553E62A0
        public void Dispose(){} // RVA: 0x7FFD53A74000
        public void EndArrayNode(){} // RVA: 0x7FFD553E6360
        public void EndNode(){} // RVA: 0x7FFD553E63B0
        public void WritePrimitiveArray_byte(){} // RVA: 0x7FFD553E6450
        public void WritePrimitiveArray_sbyte(){} // RVA: 0x7FFD553E65B0
        public void WritePrimitiveArray_bool(){} // RVA: 0x7FFD553E6910
        public void WritePrimitiveArray_char(){} // RVA: 0x7FFD553E6C70
        public void WritePrimitiveArray_short(){} // RVA: 0x7FFD553E6FE0
        public void WritePrimitiveArray_int(){} // RVA: 0x7FFD553E7350
        public void WritePrimitiveArray_long(){} // RVA: 0x7FFD553E76C0
        public void WritePrimitiveArray_ushort(){} // RVA: 0x7FFD553E7A30
        public void WritePrimitiveArray_uint(){} // RVA: 0x7FFD553E7DA0
        public void WritePrimitiveArray_ulong(){} // RVA: 0x7FFD553E8110
        public void WritePrimitiveArray_decimal(){} // RVA: 0x7FFD553E8480
        public void WritePrimitiveArray_float(){} // RVA: 0x7FFD553E87F0
        public void WritePrimitiveArray_double(){} // RVA: 0x7FFD553E8B60
        public void WritePrimitiveArray_Guid(){} // RVA: 0x7FFD553E8ED0
        public void WritePrimitiveArray(){} // RVA: 0x7FFD4E090A40
        public void WriteBoolean(){} // RVA: 0x7FFD553E9240
        public void WriteByte(){} // RVA: 0x7FFD553E9310
        public void WriteChar(){} // RVA: 0x7FFD553E93E0
        public void WriteDecimal(){} // RVA: 0x7FFD553E94C0
        public void WriteDouble(){} // RVA: 0x7FFD553E95B0
        public void WriteGuid(){} // RVA: 0x7FFD553E9690
        public void WriteExternalReference(){} // RVA: 0x7FFD553E9950 | overloaded x3
        public void WriteInt32(){} // RVA: 0x7FFD553E9A40
        public void WriteInt64(){} // RVA: 0x7FFD553E9B20
        public void WriteNull(){} // RVA: 0x7FFD553E9C00
        public void WriteInternalReference(){} // RVA: 0x7FFD553E9C90
        public void WriteSByte(){} // RVA: 0x7FFD553E9D70
        public void WriteInt16(){} // RVA: 0x7FFD553E9E40
        public void WriteSingle(){} // RVA: 0x7FFD553E9F20
        public void WriteString(){} // RVA: 0x7FFD553EA000
        public void WriteUInt32(){} // RVA: 0x7FFD553EA0A0
        public void WriteUInt64(){} // RVA: 0x7FFD553EA180
        public void WriteUInt16(){} // RVA: 0x7FFD553EA260
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFD553EA340
        public void GetDataDump(){} // RVA: 0x7FFD553EA3A0
        public void WriteType(){} // RVA: 0x7FFD553EA640
        public void WriteStringFast(){} // RVA: 0x7FFD553EA910
        public void FlushToStream(){} // RVA: 0x7FFD553EB0A0
        public void WriteValueTypeToBuffer(){} // RVA: 0x7FFD4E2ADC40
        public void UNSAFE_WriteToBuffer_2_Char(){} // RVA: 0x7FFD553EB140
        public void UNSAFE_WriteToBuffer_2_Int16(){} // RVA: 0x7FFD553EB190
        public void UNSAFE_WriteToBuffer_2_UInt16(){} // RVA: 0x7FFD553EB1E0
        public void UNSAFE_WriteToBuffer_4_Int32(){} // RVA: 0x7FFD553EB230
        public void UNSAFE_WriteToBuffer_4_UInt32(){} // RVA: 0x7FFD553EB280
        public void UNSAFE_WriteToBuffer_4_Float32(){} // RVA: 0x7FFD553EB2D0
        public void UNSAFE_WriteToBuffer_8_Int64(){} // RVA: 0x7FFD553EB320
        public void UNSAFE_WriteToBuffer_8_UInt64(){} // RVA: 0x7FFD553EB370
        public void UNSAFE_WriteToBuffer_8_Float64(){} // RVA: 0x7FFD553EB3C0
        public void UNSAFE_WriteToBuffer_16_Decimal(){} // RVA: 0x7FFD553EB410
        public void UNSAFE_WriteToBuffer_16_Guid(){} // RVA: 0x7FFD553EB470
        public void EnsureBufferSpace(){} // RVA: 0x7FFD553EB4D0
        public void TryEnsureBufferSpace(){} // RVA: 0x7FFD553EB570
        public void .cctor(){} // RVA: 0x7FFD553EB5C0
    }

    public class BooleanSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD55420910
        public void WriteValue(){} // RVA: 0x7FFD554215E0
        public void .ctor(){} // RVA: 0x7FFD55421650
    }

    public class BoundsFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<UnityEngine.Vector3> Vector3Serializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD55437A50
        public void Write(){} // RVA: 0x7FFD55437B50
        public void .ctor(){} // RVA: 0x7FFD55437C80
        public void .cctor(){} // RVA: 0x7FFD55437CE0
    }

    public class Buffer`1 : Object
    {
        public object Count;
        public System.Collections.Generic.List`1<VRC.Udon.Serialization.OdinSerializer.Buffer`1<T>> Array;
        public int IsFree;
        public T[] array;
        public bool isFree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Array(){} // RVA: 0x7FFD4E078E90
        public void get_IsFree(){} // RVA: 0x7FFD4E079D00
        public void Claim(){} // RVA: 0x7FFD4E07E8C0
        public void Free(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void NextPowerOfTwo(){} // RVA: 0x7FFD4E080110
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD554216C0
        public void WriteValue(){} // RVA: 0x7FFD55422390
        public void .ctor(){} // RVA: 0x7FFD55422400
    }

}