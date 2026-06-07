// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 12
// Methods: 254

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class BaseDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x78347D0
        public void get_CurrentNodeId(){} // RVA: 0x7834870
        public void get_CurrentNodeDepth(){} // RVA: 0x5BED50
        public void get_CurrentNodeName(){} // RVA: 0x7834890
        public void get_Stream(){} // RVA: 0x30B130
        public void set_Stream(){} // RVA: 0x78348B0
        public void get_Context(){} // RVA: 0x78349D0
        public void set_Context(){} // RVA: 0x30B0D0
        public void EnterNode(){} // RVA: 0xDE40
        public void ExitNode(){} // RVA: 0xDBE0
        public void EnterArray(){} // RVA: 0xDE40
        public void ExitArray(){} // RVA: 0xDBE0
        public void ReadPrimitiveArray(){} // RVA: 0xDE40
        public void PeekEntry(){} // RVA: 0xDBE0 | overloaded x2
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
        public void SkipEntry(){} // RVA: 0x7834AD0
        public void Dispose(){} // RVA: 0x24A50
        public void PrepareNewSerializationSession(){} // RVA: 0xA52E70
        public void GetDataDump(){} // RVA: 0xCD60
        public void ReadToNextEntry(){} // RVA: 0xDBE0
    }

    public class BaseDataReaderWriter
    {
        // ── Methods ──
        public void get_Binder(){} // RVA: 0x78350D0
        public void set_Binder(){} // RVA: 0x7835210
        public void get_IsInArrayNode(){} // RVA: 0x78353D0
        public void get_NodeDepth(){} // RVA: 0x5BED50
        public void get_NodesArray(){} // RVA: 0x2F8380
        public void get_CurrentNode(){} // RVA: 0x7835420
        public void PushNode(){} // RVA: 0x78355A0 | overloaded x2
        public void PushArray(){} // RVA: 0x78356D0
        public void ExpandNodes(){} // RVA: 0x78359F0
        public void PopNode(){} // RVA: 0x7835B70
        public void PopArray(){} // RVA: 0x7835BE0
        public void ClearNodes(){} // RVA: 0xA52E70
        public void .ctor(){} // RVA: 0x7835CC0
    }

    public class BaseDataWriter : stream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7835D50
        public void get_Stream(){} // RVA: 0x30B130
        public void set_Stream(){} // RVA: 0x7835DF0
        public void get_Context(){} // RVA: 0x7835F10
        public void set_Context(){} // RVA: 0x30B0D0
        public void FlushToStream(){} // RVA: 0x7836010
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
        public void Dispose(){} // RVA: 0x24A50
        public void PrepareNewSerializationSession(){} // RVA: 0xA52E70
        public void GetDataDump(){} // RVA: 0xCD60
    }

    public class BaseDictionaryKeyPathProvider`1
    {
        // ── Methods ──
        public void get_ProviderID(){} // RVA: 0xCD60
        public void GetKeyFromPathString(){} // RVA: 0x283FA0
        public void GetPathStringFromKey(){} // RVA: 0x283FA0
        public void Compare(){} // RVA: 0x283FA0
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.Compare(){} // RVA: 0x17680
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetKeyFromPathString(){} // RVA: 0xCE10
        public void VRC.Udon.Serialization.OdinSerializer.IDictionaryKeyPathProvider.GetPathStringFromKey(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x56BBD20
        public void GetCallbacks(){} // RVA: 0x56BCC30
        public void CreateCallback(){} // RVA: 0x56BCE90
        public void get_SerializedType(){} // RVA: 0x56BD300
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Serialize(){} // RVA: 0x56BD3B0
        public void VRC.Udon.Serialization.OdinSerializer.IFormatter.Deserialize(){} // RVA: 0x56BD580
        public void Deserialize(){} // RVA: 0x263BC0
        public void Serialize(){} // RVA: 0x56BE280
        public void GetUninitializedObject(){} // RVA: 0x263BC0
        public void RegisterReferenceID(){} // RVA: 0x56BED30
        public void InvokeOnDeserializingCallbacks(){} // RVA: 0x56BEF70 | overloaded x2
        public void DeserializeImplementation(){} // RVA: 0x2DC60
        public void SerializeImplementation(){} // RVA: 0x2DC60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BinaryDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x78362F0 | overloaded x2
        public void Dispose(){} // RVA: 0x2DD310
        public void PeekEntry(){} // RVA: 0x783A1F0 | overloaded x2
        public void EnterArray(){} // RVA: 0x7836BB0
        public void EnterNode(){} // RVA: 0x7836D50
        public void ExitArray(){} // RVA: 0x7836FA0
        public void ExitNode(){} // RVA: 0x78370E0
        public void ReadPrimitiveArray(){} // RVA: 0xDE40
        public void ReadBoolean(){} // RVA: 0x7837280
        public void ReadSByte(){} // RVA: 0x7837390
        public void ReadByte(){} // RVA: 0x7837440
        public void ReadInt16(){} // RVA: 0x78374F0
        public void ReadUInt16(){} // RVA: 0x78375B0
        public void ReadInt32(){} // RVA: 0x7837670
        public void ReadUInt32(){} // RVA: 0x7837730
        public void ReadInt64(){} // RVA: 0x78377F0
        public void ReadUInt64(){} // RVA: 0x7837CC0
        public void ReadChar(){} // RVA: 0x7838150
        public void ReadSingle(){} // RVA: 0x7838280
        public void ReadDouble(){} // RVA: 0x78384E0
        public void ReadDecimal(){} // RVA: 0x7838760
        public void ReadExternalReference(){} // RVA: 0x7838D50 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7838BD0
        public void ReadNull(){} // RVA: 0x7838EB0
        public void ReadInternalReference(){} // RVA: 0x7838F40
        public void ReadString(){} // RVA: 0x7839010
        public void PrepareNewSerializationSession(){} // RVA: 0x7839170
        public void GetDataDump(){} // RVA: 0x7839290
        public void ReadStringValue(){} // RVA: 0x7839400
        public void SkipStringValue(){} // RVA: 0x7839700
        public void SkipPeekedEntryContent(){} // RVA: 0x78397F0
        public void SkipBuffer(){} // RVA: 0x7839CD0
        public void ReadTypeEntry(){} // RVA: 0x7839CF0
        public void MarkEntryContentConsumed(){} // RVA: 0x25E3F80
        public void ReadToNextEntry(){} // RVA: 0x783A220
        public void UNSAFE_Read_1_Byte(){} // RVA: 0x783A260
        public void UNSAFE_Read_1_SByte(){} // RVA: 0x783A260
        public void ReadValueTypeFromBuffer(){} // RVA: 0xDE40
        public void UNSAFE_Read_2_Int16(){} // RVA: 0x783A2D0
        public void UNSAFE_Read_2_UInt16(){} // RVA: 0x783A320
        public void UNSAFE_Read_2_Char(){} // RVA: 0x783A370
        public void UNSAFE_Read_4_Int32(){} // RVA: 0x783A3C0
        public void UNSAFE_Read_4_UInt32(){} // RVA: 0x783A410
        public void UNSAFE_Read_4_Float32(){} // RVA: 0x783A460
        public void UNSAFE_Read_8_Int64(){} // RVA: 0x783A4B0
        public void UNSAFE_Read_8_UInt64(){} // RVA: 0x783A500
        public void UNSAFE_Read_8_Float64(){} // RVA: 0x783A550
        public void UNSAFE_Read_16_Decimal(){} // RVA: 0x783A5A0
        public void UNSAFE_Read_16_Guid(){} // RVA: 0x783A5F0
        public void HasBufferData(){} // RVA: 0x25E3FE0
        public void ReadEntireStreamToBuffer(){} // RVA: 0x783A670
        public void OnFreed(){} // RVA: 0x5A57060
        public void OnClaimed(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x783AA90
    }

    public class BinaryDataWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x783BCC0 | overloaded x2
        public void BeginArrayNode(){} // RVA: 0x783BF30
        public void BeginReferenceNode(){} // RVA: 0x783BFC0
        public void BeginStructNode(){} // RVA: 0x783C0D0
        public void Dispose(){} // RVA: 0x5EBC950
        public void EndArrayNode(){} // RVA: 0x783C190
        public void EndNode(){} // RVA: 0x783C1E0
        public void WritePrimitiveArray_byte(){} // RVA: 0x783C280
        public void WritePrimitiveArray_sbyte(){} // RVA: 0x783C3E0
        public void WritePrimitiveArray_bool(){} // RVA: 0x783C740
        public void WritePrimitiveArray_char(){} // RVA: 0x783CAA0
        public void WritePrimitiveArray_short(){} // RVA: 0x783CE10
        public void WritePrimitiveArray_int(){} // RVA: 0x783D180
        public void WritePrimitiveArray_long(){} // RVA: 0x783D4F0
        public void WritePrimitiveArray_ushort(){} // RVA: 0x783D860
        public void WritePrimitiveArray_uint(){} // RVA: 0x783DBD0
        public void WritePrimitiveArray_ulong(){} // RVA: 0x783DF40
        public void WritePrimitiveArray_decimal(){} // RVA: 0x783E2B0
        public void WritePrimitiveArray_float(){} // RVA: 0x783E620
        public void WritePrimitiveArray_double(){} // RVA: 0x783E990
        public void WritePrimitiveArray_Guid(){} // RVA: 0x783ED00
        public void WritePrimitiveArray(){} // RVA: 0x24B10
        public void WriteBoolean(){} // RVA: 0x783F070
        public void WriteByte(){} // RVA: 0x783F140
        public void WriteChar(){} // RVA: 0x783F210
        public void WriteDecimal(){} // RVA: 0x783F2F0
        public void WriteDouble(){} // RVA: 0x783F3E0
        public void WriteGuid(){} // RVA: 0x783F4C0
        public void WriteExternalReference(){} // RVA: 0x783F780 | overloaded x3
        public void WriteInt32(){} // RVA: 0x783F870
        public void WriteInt64(){} // RVA: 0x783F950
        public void WriteNull(){} // RVA: 0x783FA30
        public void WriteInternalReference(){} // RVA: 0x783FAC0
        public void WriteSByte(){} // RVA: 0x783FBA0
        public void WriteInt16(){} // RVA: 0x783FC70
        public void WriteSingle(){} // RVA: 0x783FD50
        public void WriteString(){} // RVA: 0x783FE30
        public void WriteUInt32(){} // RVA: 0x783FED0
        public void WriteUInt64(){} // RVA: 0x783FFB0
        public void WriteUInt16(){} // RVA: 0x7840090
        public void PrepareNewSerializationSession(){} // RVA: 0x7840170
        public void GetDataDump(){} // RVA: 0x78401D0
        public void WriteType(){} // RVA: 0x7840470
        public void WriteStringFast(){} // RVA: 0x7840740
        public void FlushToStream(){} // RVA: 0x7840ED0
        public void WriteValueTypeToBuffer(){} // RVA: 0x283FA0
        public void UNSAFE_WriteToBuffer_2_Char(){} // RVA: 0x7840F70
        public void UNSAFE_WriteToBuffer_2_Int16(){} // RVA: 0x7840FC0
        public void UNSAFE_WriteToBuffer_2_UInt16(){} // RVA: 0x7841010
        public void UNSAFE_WriteToBuffer_4_Int32(){} // RVA: 0x7841060
        public void UNSAFE_WriteToBuffer_4_UInt32(){} // RVA: 0x78410B0
        public void UNSAFE_WriteToBuffer_4_Float32(){} // RVA: 0x7841100
        public void UNSAFE_WriteToBuffer_8_Int64(){} // RVA: 0x7841150
        public void UNSAFE_WriteToBuffer_8_UInt64(){} // RVA: 0x78411A0
        public void UNSAFE_WriteToBuffer_8_Float64(){} // RVA: 0x78411F0
        public void UNSAFE_WriteToBuffer_16_Decimal(){} // RVA: 0x7841240
        public void UNSAFE_WriteToBuffer_16_Guid(){} // RVA: 0x78412A0
        public void EnsureBufferSpace(){} // RVA: 0x7841300
        public void TryEnsureBufferSpace(){} // RVA: 0x78413A0
        public void .cctor(){} // RVA: 0x78413F0
    }

    public class BindTypeNameToTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCCD00
    }

    public class BooleanSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7876760
        public void WriteValue(){} // RVA: 0x7877430
        public void .ctor(){} // RVA: 0x78774A0
    }

    public class BoundsFormatter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x788D8A0
        public void Write(){} // RVA: 0x788D9A0
        public void .ctor(){} // RVA: 0x788DAD0
        public void .cctor(){} // RVA: 0x788DB30
    }

    public class Buffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void get_Count(){} // RVA: 0xD840
        public void get_Array(){} // RVA: 0xCD60
        public void get_IsFree(){} // RVA: 0xDBE0
        public void Claim(){} // RVA: 0x127A0
        public void Free(){} // RVA: 0x24A50 | overloaded x2
        public void Dispose(){} // RVA: 0x24A50
        public void NextPowerOfTwo(){} // RVA: 0x13FF0
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ByteSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7877510
        public void WriteValue(){} // RVA: 0x78781E0
        public void .ctor(){} // RVA: 0x7878250
    }

}