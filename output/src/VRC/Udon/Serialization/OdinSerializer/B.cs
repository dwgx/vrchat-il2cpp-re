// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 254

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class BaseDataReader : BaseDataReaderWriter
    {
        public VRC.Udon.Serialization.OdinSerializer.DeserializationContext context; // 0x20
        public System.IO.Stream stream; // 0x28
        public object field_2; // 0xA
        public object field_3; // 0xB
        public object field_4; // 0xC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88371490
        public void get_CurrentNodeId(){} // RVA: 0x7FFE88371530
        public void get_CurrentNodeDepth(){} // RVA: 0x7FFE813DB630
        public void get_CurrentNodeName(){} // RVA: 0x7FFE88371550
        public void get_Stream(){} // RVA: 0x7FFE81129130
        public void set_Stream(){} // RVA: 0x7FFE88371570
        public void get_Context(){} // RVA: 0x7FFE88371690
        public void set_Context(){} // RVA: 0x7FFE811290D0
        public void EnterNode(){} // RVA: 0x7FFE80E2F3B0
        public void ExitNode(){} // RVA: 0x7FFE80E2F150
        public void EnterArray(){} // RVA: 0x7FFE80E2F3B0
        public void ExitArray(){} // RVA: 0x7FFE80E2F150
        public void ReadPrimitiveArray(){} // RVA: 0x7FFE80E2F3B0
        public void PeekEntry(){} // RVA: 0x7FFE80E2F150 | overloaded x2
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
        public void SkipEntry(){} // RVA: 0x7FFE88371790
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE817E01F0
        public void GetDataDump(){} // RVA: 0x7FFE80E2E2E0
        public void ReadToNextEntry(){} // RVA: 0x7FFE80E2F150
    }

    public class BaseDataReaderWriter : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.NodeInfo[] nodes; // 0x10
        public int nodesLength; // 0x18
        public object field_2; // 0xF
        public object field_3; // 0x10
        public object field_4; // 0x11

        // ── Methods ──
        public void get_Binder(){} // RVA: 0x7FFE88371D90
        public void set_Binder(){} // RVA: 0x7FFE88371ED0
        public void get_IsInArrayNode(){} // RVA: 0x7FFE88372090
        public void get_NodeDepth(){} // RVA: 0x7FFE813DB630
        public void get_NodesArray(){} // RVA: 0x7FFE81116380
        public void get_CurrentNode(){} // RVA: 0x7FFE883720E0
        public void PushNode(){} // RVA: 0x7FFE88372260 | overloaded x2
        public void PushArray(){} // RVA: 0x7FFE88372390
        public void ExpandNodes(){} // RVA: 0x7FFE883726B0
        public void PopNode(){} // RVA: 0x7FFE88372830
        public void PopArray(){} // RVA: 0x7FFE883728A0
        public void ClearNodes(){} // RVA: 0x7FFE817E01F0
        public void .ctor(){} // RVA: 0x7FFE88372980
    }

    public class BaseDataWriter : BaseDataReaderWriter
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationContext context; // 0x20
        public System.IO.Stream stream; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88372A10
        public void get_Stream(){} // RVA: 0x7FFE81129130
        public void set_Stream(){} // RVA: 0x7FFE88372AB0
        public void get_Context(){} // RVA: 0x7FFE88372BD0
        public void set_Context(){} // RVA: 0x7FFE811290D0
        public void FlushToStream(){} // RVA: 0x7FFE88372CD0
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
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE817E01F0
        public void GetDataDump(){} // RVA: 0x7FFE80E2E2E0
    }

    public class BaseDictionaryKeyPathProvider`1 : Object
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0x7FFE80E2E2E0
        public void GetKeyFromPathString(){} // RVA: 0x7FFE810A1420
        public void GetPathStringFromKey(){} // RVA: 0x7FFE810A1420
        public void Compare(){} // RVA: 0x7FFE810A1420
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x7FFE80E38BF0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0x7FFE80E2E390
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class BaseFormatter`1 : Object
    {
        public SerializationCallback<U>[] OnSerializingCallbacks;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86172210
        public void GetCallbacks(){} // RVA: 0x7FFE86173120
        public void CreateCallback(){} // RVA: 0x7FFE86173380
        public void get_SerializedType(){} // RVA: 0x7FFE861737F0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x7FFE861738A0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x7FFE86173A70
        public void Deserialize(){} // RVA: 0x7FFE81081080
        public void Serialize(){} // RVA: 0x7FFE86174880
        public void GetUninitializedObject(){} // RVA: 0x7FFE81081080
        public void RegisterReferenceID(){} // RVA: 0x7FFE86175330
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x7FFE86175570 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BinaryDataReader : BaseDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88372FB0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void PeekEntry(){} // RVA: 0x7FFE88376EB0 | overloaded x2
        public void EnterArray(){} // RVA: 0x7FFE88373870
        public void EnterNode(){} // RVA: 0x7FFE88373A10
        public void ExitArray(){} // RVA: 0x7FFE88373C60
        public void ExitNode(){} // RVA: 0x7FFE88373DA0
        public void ReadPrimitiveArray(){} // RVA: 0x7FFE80E2F3B0
        public void ReadBoolean(){} // RVA: 0x7FFE88373F40
        public void ReadSByte(){} // RVA: 0x7FFE88374050
        public void ReadByte(){} // RVA: 0x7FFE88374100
        public void ReadInt16(){} // RVA: 0x7FFE883741B0
        public void ReadUInt16(){} // RVA: 0x7FFE88374270
        public void ReadInt32(){} // RVA: 0x7FFE88374330
        public void ReadUInt32(){} // RVA: 0x7FFE883743F0
        public void ReadInt64(){} // RVA: 0x7FFE883744B0
        public void ReadUInt64(){} // RVA: 0x7FFE88374980
        public void ReadChar(){} // RVA: 0x7FFE88374E10
        public void ReadSingle(){} // RVA: 0x7FFE88374F40
        public void ReadDouble(){} // RVA: 0x7FFE883751A0
        public void ReadDecimal(){} // RVA: 0x7FFE88375420
        public void ReadExternalReference(){} // RVA: 0x7FFE88375A10 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7FFE88375890
        public void ReadNull(){} // RVA: 0x7FFE88375B70
        public void ReadInternalReference(){} // RVA: 0x7FFE88375C00
        public void ReadString(){} // RVA: 0x7FFE88375CD0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE88375E30
        public void GetDataDump(){} // RVA: 0x7FFE88375F50
        public void ReadStringValue(){} // RVA: 0x7FFE883760C0
        public void SkipStringValue(){} // RVA: 0x7FFE883763C0
        public void SkipPeekedEntryContent(){} // RVA: 0x7FFE883764B0
        public void SkipBuffer(){} // RVA: 0x7FFE88376990
        public void ReadTypeEntry(){} // RVA: 0x7FFE883769B0
        public void MarkEntryContentConsumed(){} // RVA: 0x7FFE83339780
        public void ReadToNextEntry(){} // RVA: 0x7FFE88376EE0
        public void UNSAFE_Read_1_Byte(){} // RVA: 0x7FFE88376F20
        public void UNSAFE_Read_1_SByte(){} // RVA: 0x7FFE88376F20
        public void ReadValueTypeFromBuffer(){} // RVA: 0x7FFE80E2F3B0
        public void UNSAFE_Read_2_Int16(){} // RVA: 0x7FFE88376F90
        public void UNSAFE_Read_2_UInt16(){} // RVA: 0x7FFE88376FE0
        public void UNSAFE_Read_2_Char(){} // RVA: 0x7FFE88377030
        public void UNSAFE_Read_4_Int32(){} // RVA: 0x7FFE88377080
        public void UNSAFE_Read_4_UInt32(){} // RVA: 0x7FFE883770D0
        public void UNSAFE_Read_4_Float32(){} // RVA: 0x7FFE88377120
        public void UNSAFE_Read_8_Int64(){} // RVA: 0x7FFE88377170
        public void UNSAFE_Read_8_UInt64(){} // RVA: 0x7FFE883771C0
        public void UNSAFE_Read_8_Float64(){} // RVA: 0x7FFE88377210
        public void UNSAFE_Read_16_Decimal(){} // RVA: 0x7FFE88377260
        public void UNSAFE_Read_16_Guid(){} // RVA: 0x7FFE883772B0
        public void HasBufferData(){} // RVA: 0x7FFE833397E0
        public void ReadEntireStreamToBuffer(){} // RVA: 0x7FFE88377330
        public void OnFreed(){} // RVA: 0x7FFE86597DC0
        public void OnClaimed(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE88377750
    }

    public class BinaryDataWriter : BaseDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88378980 | overloaded x2
        public void BeginArrayNode(){} // RVA: 0x7FFE88378BF0
        public void BeginReferenceNode(){} // RVA: 0x7FFE88378C80
        public void BeginStructNode(){} // RVA: 0x7FFE88378D90
        public void Dispose(){} // RVA: 0x7FFE869FD7F0
        public void EndArrayNode(){} // RVA: 0x7FFE88378E50
        public void EndNode(){} // RVA: 0x7FFE88378EA0
        public void WritePrimitiveArray_byte(){} // RVA: 0x7FFE88378F40
        public void WritePrimitiveArray_sbyte(){} // RVA: 0x7FFE883790A0
        public void WritePrimitiveArray_bool(){} // RVA: 0x7FFE88379400
        public void WritePrimitiveArray_char(){} // RVA: 0x7FFE88379760
        public void WritePrimitiveArray_short(){} // RVA: 0x7FFE88379AD0
        public void WritePrimitiveArray_int(){} // RVA: 0x7FFE88379E40
        public void WritePrimitiveArray_long(){} // RVA: 0x7FFE8837A1B0
        public void WritePrimitiveArray_ushort(){} // RVA: 0x7FFE8837A520
        public void WritePrimitiveArray_uint(){} // RVA: 0x7FFE8837A890
        public void WritePrimitiveArray_ulong(){} // RVA: 0x7FFE8837AC00
        public void WritePrimitiveArray_decimal(){} // RVA: 0x7FFE8837AF70
        public void WritePrimitiveArray_float(){} // RVA: 0x7FFE8837B2E0
        public void WritePrimitiveArray_double(){} // RVA: 0x7FFE8837B650
        public void WritePrimitiveArray_Guid(){} // RVA: 0x7FFE8837B9C0
        public void WritePrimitiveArray(){} // RVA: 0x7FFE80E460A0
        public void WriteBoolean(){} // RVA: 0x7FFE8837BD30
        public void WriteByte(){} // RVA: 0x7FFE8837BE00
        public void WriteChar(){} // RVA: 0x7FFE8837BED0
        public void WriteDecimal(){} // RVA: 0x7FFE8837BFB0
        public void WriteDouble(){} // RVA: 0x7FFE8837C0A0
        public void WriteGuid(){} // RVA: 0x7FFE8837C180
        public void WriteExternalReference(){} // RVA: 0x7FFE8837C440 | overloaded x3
        public void WriteInt32(){} // RVA: 0x7FFE8837C530
        public void WriteInt64(){} // RVA: 0x7FFE8837C610
        public void WriteNull(){} // RVA: 0x7FFE8837C6F0
        public void WriteInternalReference(){} // RVA: 0x7FFE8837C780
        public void WriteSByte(){} // RVA: 0x7FFE8837C860
        public void WriteInt16(){} // RVA: 0x7FFE8837C930
        public void WriteSingle(){} // RVA: 0x7FFE8837CA10
        public void WriteString(){} // RVA: 0x7FFE8837CAF0
        public void WriteUInt32(){} // RVA: 0x7FFE8837CB90
        public void WriteUInt64(){} // RVA: 0x7FFE8837CC70
        public void WriteUInt16(){} // RVA: 0x7FFE8837CD50
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE8837CE30
        public void GetDataDump(){} // RVA: 0x7FFE8837CE90
        public void WriteType(){} // RVA: 0x7FFE8837D130
        public void WriteStringFast(){} // RVA: 0x7FFE8837D400
        public void FlushToStream(){} // RVA: 0x7FFE8837DB90
        public void WriteValueTypeToBuffer(){} // RVA: 0x7FFE810A1420
        public void UNSAFE_WriteToBuffer_2_Char(){} // RVA: 0x7FFE8837DC30
        public void UNSAFE_WriteToBuffer_2_Int16(){} // RVA: 0x7FFE8837DC80
        public void UNSAFE_WriteToBuffer_2_UInt16(){} // RVA: 0x7FFE8837DCD0
        public void UNSAFE_WriteToBuffer_4_Int32(){} // RVA: 0x7FFE8837DD20
        public void UNSAFE_WriteToBuffer_4_UInt32(){} // RVA: 0x7FFE8837DD70
        public void UNSAFE_WriteToBuffer_4_Float32(){} // RVA: 0x7FFE8837DDC0
        public void UNSAFE_WriteToBuffer_8_Int64(){} // RVA: 0x7FFE8837DE10
        public void UNSAFE_WriteToBuffer_8_UInt64(){} // RVA: 0x7FFE8837DE60
        public void UNSAFE_WriteToBuffer_8_Float64(){} // RVA: 0x7FFE8837DEB0
        public void UNSAFE_WriteToBuffer_16_Decimal(){} // RVA: 0x7FFE8837DF00
        public void UNSAFE_WriteToBuffer_16_Guid(){} // RVA: 0x7FFE8837DF60
        public void EnsureBufferSpace(){} // RVA: 0x7FFE8837DFC0
        public void TryEnsureBufferSpace(){} // RVA: 0x7FFE8837E060
        public void .cctor(){} // RVA: 0x7FFE8837E0B0
    }

    public class BindTypeNameToTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680DC00
    }

    public class BooleanSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B3420
        public void WriteValue(){} // RVA: 0x7FFE883B40F0
        public void .ctor(){} // RVA: 0x7FFE883B4160
    }

    public class BoundsFormatter : MinimalBaseFormatter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFE883CA560
        public void Write(){} // RVA: 0x7FFE883CA660
        public void .ctor(){} // RVA: 0x7FFE883CA790
        public void .cctor(){} // RVA: 0x7FFE883CA7F0
    }

    public class Buffer`1 : Object
    {
        public object LOCK;
        public System.Collections.Generic.List`1<VRC.Udon.Serialization.OdinSerializer.Buffer`1<T>> FreeBuffers;
        public int count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Array(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsFree(){} // RVA: 0x7FFE80E2F150
        public void Claim(){} // RVA: 0x7FFE80E33D10
        public void Free(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void NextPowerOfTwo(){} // RVA: 0x7FFE80E35560
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883B41D0
        public void WriteValue(){} // RVA: 0x7FFE883B4EA0
        public void .ctor(){} // RVA: 0x7FFE883B4F10
    }

}