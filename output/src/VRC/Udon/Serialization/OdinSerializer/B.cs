// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 254

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class BaseDataReader : BaseDataReaderWriter
    {
        public VRC.Udon.Serialization.OdinSerializer.DeserializationContext CurrentNodeId; // 0x20
        public System.IO.Stream CurrentNodeDepth; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FBE9A0
        public void get_CurrentNodeId(){} // RVA: 0x7FFAC9FBEA40
        public void get_CurrentNodeDepth(){} // RVA: 0x7FFAC3157800
        public void get_CurrentNodeName(){} // RVA: 0x7FFAC9FBEA60
        public void get_Stream(){} // RVA: 0x7FFAC2F4F130
        public void set_Stream(){} // RVA: 0x7FFAC9FBEA80
        public void get_Context(){} // RVA: 0x7FFAC9FBEBA0
        public void set_Context(){} // RVA: 0x7FFAC2F4F0D0
        public void EnterNode(){} // RVA: 0x7FFAC2C59F60
        public void ExitNode(){} // RVA: 0x7FFAC2C59D00
        public void EnterArray(){} // RVA: 0x7FFAC2C59F60
        public void ExitArray(){} // RVA: 0x7FFAC2C59D00
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAC2C59F60
        public void PeekEntry(){} // RVA: 0x7FFAC2C59D00 | overloaded x2
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
        public void SkipEntry(){} // RVA: 0x7FFAC9FBECA0
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC36970B0
        public void GetDataDump(){} // RVA: 0x7FFAC2C58E90
        public void ReadToNextEntry(){} // RVA: 0x7FFAC2C59D00
    }

    public class BaseDataReaderWriter : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.NodeInfo[] Binder; // 0x10
        public int IsInArrayNode; // 0x18

        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFAC9FBF2A0
        public void set_Binder(){} // RVA: 0x7FFAC9FBF3E0
        public void get_IsInArrayNode(){} // RVA: 0x7FFAC9FBF5A0
        public void get_NodeDepth(){} // RVA: 0x7FFAC3157800
        public void get_NodesArray(){} // RVA: 0x7FFAC2F3C380
        public void get_CurrentNode(){} // RVA: 0x7FFAC9FBF5F0
        public void PushNode(){} // RVA: 0x7FFAC9FBF770 | overloaded x2
        public void PushArray(){} // RVA: 0x7FFAC9FBF8A0
        public void ExpandNodes(){} // RVA: 0x7FFAC9FBFBC0
        public void PopNode(){} // RVA: 0x7FFAC9FBFD40
        public void PopArray(){} // RVA: 0x7FFAC9FBFDB0
        public void ClearNodes(){} // RVA: 0x7FFAC36970B0
        public void .ctor(){} // RVA: 0x7FFAC9FBFE90
    }

    public class BaseDataWriter : BaseDataReaderWriter
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationContext Stream; // 0x20
        public System.IO.Stream Context; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FBFF20
        public void get_Stream(){} // RVA: 0x7FFAC2F4F130
        public void set_Stream(){} // RVA: 0x7FFAC9FBFFC0
        public void get_Context(){} // RVA: 0x7FFAC9FC00E0
        public void set_Context(){} // RVA: 0x7FFAC2F4F0D0
        public void FlushToStream(){} // RVA: 0x7FFAC9FC01E0
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
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC36970B0
        public void GetDataDump(){} // RVA: 0x7FFAC2C58E90
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        public object ProviderID;

        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFAC2C58E90
        public void GetKeyFromPathString(){} // RVA: 0x7FFAC2E8DC40
        public void GetPathStringFromKey(){} // RVA: 0x7FFAC2E8DC40
        public void Compare(){} // RVA: 0x7FFAC2E8DC40
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7FFAC2C637A0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7FFAC2C58F40
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class BaseFormatter`1 : Object
    {
        public SerializationCallback<U>[] SerializedType;
        public SerializationCallback<U>[] OnSerializedCallbacks; // 0x8
        public SerializationCallback<U>[] OnDeserializingCallbacks; // 0x10
        public SerializationCallback<U>[] OnDeserializedCallbacks; // 0x18
        public bool IsValueType; // 0x20
        public bool ImplementsISerializationCallbackReceiver; // 0x21
        public bool ImplementsIDeserializationCallback; // 0x22
        public bool ImplementsIObjectReference; // 0x23

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC7D4FAD0
        public void GetCallbacks(){} // RVA: 0x7FFAC7D509E0
        public void CreateCallback(){} // RVA: 0x7FFAC7D50C40
        public void get_SerializedType(){} // RVA: 0x7FFAC7D510B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFAC7D51160
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFAC7D51330
        public void Deserialize(){} // RVA: 0x7FFAC2E5B230
        public void Serialize(){} // RVA: 0x7FFAC7D52030
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E5B230
        public void RegisterReferenceID(){} // RVA: 0x7FFAC7D52AE0
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFAC7D52D20 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BinaryDataReader : BaseDataReader
    {
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> PrimitiveFromByteMethods;
        public byte[] internalBufferBackup; // 0x30
        public byte[] buffer; // 0x38
        public int bufferIndex; // 0x40
        public int bufferEnd; // 0x44
        public System.Nullable`1<0x6B223DD8> peekedEntryType; // 0x48
        public 0x6B222258 peekedBinaryEntryType; // 0x4A
        public string peekedEntryName; // 0x50
        public System.Collections.Generic.Dictionary`2<int,System.Type> types; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FC04C0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void PeekEntry(){} // RVA: 0x7FFAC9FC43C0 | overloaded x2
        public void EnterArray(){} // RVA: 0x7FFAC9FC0D80
        public void EnterNode(){} // RVA: 0x7FFAC9FC0F20
        public void ExitArray(){} // RVA: 0x7FFAC9FC1170
        public void ExitNode(){} // RVA: 0x7FFAC9FC12B0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAC2C59F60
        public void ReadBoolean(){} // RVA: 0x7FFAC9FC1450
        public void ReadSByte(){} // RVA: 0x7FFAC9FC1560
        public void ReadByte(){} // RVA: 0x7FFAC9FC1610
        public void ReadInt16(){} // RVA: 0x7FFAC9FC16C0
        public void ReadUInt16(){} // RVA: 0x7FFAC9FC1780
        public void ReadInt32(){} // RVA: 0x7FFAC9FC1840
        public void ReadUInt32(){} // RVA: 0x7FFAC9FC1900
        public void ReadInt64(){} // RVA: 0x7FFAC9FC19C0
        public void ReadUInt64(){} // RVA: 0x7FFAC9FC1E90
        public void ReadChar(){} // RVA: 0x7FFAC9FC2320
        public void ReadSingle(){} // RVA: 0x7FFAC9FC2450
        public void ReadDouble(){} // RVA: 0x7FFAC9FC26B0
        public void ReadDecimal(){} // RVA: 0x7FFAC9FC2930
        public void ReadExternalReference(){} // RVA: 0x7FFAC9FC2F20 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7FFAC9FC2DA0
        public void ReadNull(){} // RVA: 0x7FFAC9FC3080
        public void ReadInternalReference(){} // RVA: 0x7FFAC9FC3110
        public void ReadString(){} // RVA: 0x7FFAC9FC31E0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC9FC3340
        public void GetDataDump(){} // RVA: 0x7FFAC9FC3460
        public void ReadStringValue(){} // RVA: 0x7FFAC9FC35D0
        public void SkipStringValue(){} // RVA: 0x7FFAC9FC38D0
        public void SkipPeekedEntryContent(){} // RVA: 0x7FFAC9FC39C0
        public void SkipBuffer(){} // RVA: 0x7FFAC9FC3EA0
        public void ReadTypeEntry(){} // RVA: 0x7FFAC9FC3EC0
        public void MarkEntryContentConsumed(){} // RVA: 0x7FFAC5088700
        public void ReadToNextEntry(){} // RVA: 0x7FFAC9FC43F0
        public void UNSAFE_Read_1_Byte(){} // RVA: 0x7FFAC9FC4430
        public void UNSAFE_Read_1_SByte(){} // RVA: 0x7FFAC9FC4430
        public void ReadValueTypeFromBuffer(){} // RVA: 0x7FFAC2C59F60
        public void UNSAFE_Read_2_Int16(){} // RVA: 0x7FFAC9FC44A0
        public void UNSAFE_Read_2_UInt16(){} // RVA: 0x7FFAC9FC44F0
        public void UNSAFE_Read_2_Char(){} // RVA: 0x7FFAC9FC4540
        public void UNSAFE_Read_4_Int32(){} // RVA: 0x7FFAC9FC4590
        public void UNSAFE_Read_4_UInt32(){} // RVA: 0x7FFAC9FC45E0
        public void UNSAFE_Read_4_Float32(){} // RVA: 0x7FFAC9FC4630
        public void UNSAFE_Read_8_Int64(){} // RVA: 0x7FFAC9FC4680
        public void UNSAFE_Read_8_UInt64(){} // RVA: 0x7FFAC9FC46D0
        public void UNSAFE_Read_8_Float64(){} // RVA: 0x7FFAC9FC4720
        public void UNSAFE_Read_16_Decimal(){} // RVA: 0x7FFAC9FC4770
        public void UNSAFE_Read_16_Guid(){} // RVA: 0x7FFAC9FC47C0
        public void HasBufferData(){} // RVA: 0x7FFAC5088760
        public void ReadEntireStreamToBuffer(){} // RVA: 0x7FFAC9FC4840
        public void OnFreed(){} // RVA: 0x7FFAC81EE480
        public void OnClaimed(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9FC4C60
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
        public void .ctor(){} // RVA: 0x7FFAC9FC5E90 | overloaded x2
        public void BeginArrayNode(){} // RVA: 0x7FFAC9FC6100
        public void BeginReferenceNode(){} // RVA: 0x7FFAC9FC6190
        public void BeginStructNode(){} // RVA: 0x7FFAC9FC62A0
        public void Dispose(){} // RVA: 0x7FFAC8654000
        public void EndArrayNode(){} // RVA: 0x7FFAC9FC6360
        public void EndNode(){} // RVA: 0x7FFAC9FC63B0
        public void WritePrimitiveArray_byte(){} // RVA: 0x7FFAC9FC6450
        public void WritePrimitiveArray_sbyte(){} // RVA: 0x7FFAC9FC65B0
        public void WritePrimitiveArray_bool(){} // RVA: 0x7FFAC9FC6910
        public void WritePrimitiveArray_char(){} // RVA: 0x7FFAC9FC6C70
        public void WritePrimitiveArray_short(){} // RVA: 0x7FFAC9FC6FE0
        public void WritePrimitiveArray_int(){} // RVA: 0x7FFAC9FC7350
        public void WritePrimitiveArray_long(){} // RVA: 0x7FFAC9FC76C0
        public void WritePrimitiveArray_ushort(){} // RVA: 0x7FFAC9FC7A30
        public void WritePrimitiveArray_uint(){} // RVA: 0x7FFAC9FC7DA0
        public void WritePrimitiveArray_ulong(){} // RVA: 0x7FFAC9FC8110
        public void WritePrimitiveArray_decimal(){} // RVA: 0x7FFAC9FC8480
        public void WritePrimitiveArray_float(){} // RVA: 0x7FFAC9FC87F0
        public void WritePrimitiveArray_double(){} // RVA: 0x7FFAC9FC8B60
        public void WritePrimitiveArray_Guid(){} // RVA: 0x7FFAC9FC8ED0
        public void WritePrimitiveArray(){} // RVA: 0x7FFAC2C70A40
        public void WriteBoolean(){} // RVA: 0x7FFAC9FC9240
        public void WriteByte(){} // RVA: 0x7FFAC9FC9310
        public void WriteChar(){} // RVA: 0x7FFAC9FC93E0
        public void WriteDecimal(){} // RVA: 0x7FFAC9FC94C0
        public void WriteDouble(){} // RVA: 0x7FFAC9FC95B0
        public void WriteGuid(){} // RVA: 0x7FFAC9FC9690
        public void WriteExternalReference(){} // RVA: 0x7FFAC9FC9950 | overloaded x3
        public void WriteInt32(){} // RVA: 0x7FFAC9FC9A40
        public void WriteInt64(){} // RVA: 0x7FFAC9FC9B20
        public void WriteNull(){} // RVA: 0x7FFAC9FC9C00
        public void WriteInternalReference(){} // RVA: 0x7FFAC9FC9C90
        public void WriteSByte(){} // RVA: 0x7FFAC9FC9D70
        public void WriteInt16(){} // RVA: 0x7FFAC9FC9E40
        public void WriteSingle(){} // RVA: 0x7FFAC9FC9F20
        public void WriteString(){} // RVA: 0x7FFAC9FCA000
        public void WriteUInt32(){} // RVA: 0x7FFAC9FCA0A0
        public void WriteUInt64(){} // RVA: 0x7FFAC9FCA180
        public void WriteUInt16(){} // RVA: 0x7FFAC9FCA260
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC9FCA340
        public void GetDataDump(){} // RVA: 0x7FFAC9FCA3A0
        public void WriteType(){} // RVA: 0x7FFAC9FCA640
        public void WriteStringFast(){} // RVA: 0x7FFAC9FCA910
        public void FlushToStream(){} // RVA: 0x7FFAC9FCB0A0
        public void WriteValueTypeToBuffer(){} // RVA: 0x7FFAC2E8DC40
        public void UNSAFE_WriteToBuffer_2_Char(){} // RVA: 0x7FFAC9FCB140
        public void UNSAFE_WriteToBuffer_2_Int16(){} // RVA: 0x7FFAC9FCB190
        public void UNSAFE_WriteToBuffer_2_UInt16(){} // RVA: 0x7FFAC9FCB1E0
        public void UNSAFE_WriteToBuffer_4_Int32(){} // RVA: 0x7FFAC9FCB230
        public void UNSAFE_WriteToBuffer_4_UInt32(){} // RVA: 0x7FFAC9FCB280
        public void UNSAFE_WriteToBuffer_4_Float32(){} // RVA: 0x7FFAC9FCB2D0
        public void UNSAFE_WriteToBuffer_8_Int64(){} // RVA: 0x7FFAC9FCB320
        public void UNSAFE_WriteToBuffer_8_UInt64(){} // RVA: 0x7FFAC9FCB370
        public void UNSAFE_WriteToBuffer_8_Float64(){} // RVA: 0x7FFAC9FCB3C0
        public void UNSAFE_WriteToBuffer_16_Decimal(){} // RVA: 0x7FFAC9FCB410
        public void UNSAFE_WriteToBuffer_16_Guid(){} // RVA: 0x7FFAC9FCB470
        public void EnsureBufferSpace(){} // RVA: 0x7FFAC9FCB4D0
        public void TryEnsureBufferSpace(){} // RVA: 0x7FFAC9FCB570
        public void .cctor(){} // RVA: 0x7FFAC9FCB5C0
    }

    public class BindTypeNameToTypeAttribute : Attribute
    {
        public System.Type NewType; // 0x10
        public string OldTypeName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84642F0
    }

    public class BooleanSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA000910
        public void WriteValue(){} // RVA: 0x7FFACA0015E0
        public void .ctor(){} // RVA: 0x7FFACA001650
    }

    public class BoundsFormatter : MinimalBaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<UnityEngine.Vector3> Vector3Serializer;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFACA017A50
        public void Write(){} // RVA: 0x7FFACA017B50
        public void .ctor(){} // RVA: 0x7FFACA017C80
        public void .cctor(){} // RVA: 0x7FFACA017CE0
    }

    public class Buffer`1 : Object
    {
        public object Count;
        public System.Collections.Generic.List`1<VRC.Udon.Serialization.OdinSerializer.Buffer`1<T>> Array;
        public int IsFree;
        public T[] array;
        public bool isFree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_Array(){} // RVA: 0x7FFAC2C58E90
        public void get_IsFree(){} // RVA: 0x7FFAC2C59D00
        public void Claim(){} // RVA: 0x7FFAC2C5E8C0
        public void Free(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void NextPowerOfTwo(){} // RVA: 0x7FFAC2C60110
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA0016C0
        public void WriteValue(){} // RVA: 0x7FFACA002390
        public void .ctor(){} // RVA: 0x7FFACA002400
    }

}