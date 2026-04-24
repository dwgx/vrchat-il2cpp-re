// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 25
// Methods: 126

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class IAskIfCanFormatTypes
    {
        // ── Original Methods ──
        public void CanFormatType(){} // RVA: 0x7ffaa864a2a0
    }

    public class IDataReader
    {
        // ── Original Methods ──
        public void get_Binder(){} // RVA: 0x7ffaa86491d0
        public void set_Binder(){} // RVA: 0x7ffaa8660d80
        public void get_Stream(){} // RVA: 0x7ffaa86491d0
        public void set_Stream(){} // RVA: 0x7ffaa8660d80
        public void get_IsInArrayNode(){} // RVA: 0x7ffaa864a040
        public void get_CurrentNodeName(){} // RVA: 0x7ffaa86491d0
        public void get_CurrentNodeId(){} // RVA: 0x7ffaa8649ca0
        public void get_CurrentNodeDepth(){} // RVA: 0x7ffaa8649ca0
        public void get_Context(){} // RVA: 0x7ffaa86491d0
        public void set_Context(){} // RVA: 0x7ffaa8660d80
        public void EnterNode(){} // RVA: 0x7ffaa864a2a0
        public void ExitNode(){} // RVA: 0x7ffaa864a040
        public void EnterArray(){} // RVA: 0x7ffaa864a2a0
        public void ExitArray(){} // RVA: 0x7ffaa864a040
        public void ReadPrimitiveArray(){} // RVA: 0x7ffaa864a2a0
        public void PeekEntry(){} // RVA: 0x7ffaa864a2a0
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
        public void SkipEntry(){} // RVA: 0x7ffaa8660cc0
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetDataDump(){} // RVA: 0x7ffaa86491d0
    }

    public class IDataWriter
    {
        // ── Original Methods ──
        public void get_Binder(){} // RVA: 0x7ffaa86491d0
        public void set_Binder(){} // RVA: 0x7ffaa8660d80
        public void get_Stream(){} // RVA: 0x7ffaa86491d0
        public void set_Stream(){} // RVA: 0x7ffaa8660d80
        public void get_IsInArrayNode(){} // RVA: 0x7ffaa864a040
        public void get_Context(){} // RVA: 0x7ffaa86491d0
        public void set_Context(){} // RVA: 0x7ffaa8660d80
        public void FlushToStream(){} // RVA: 0x7ffaa8660cc0
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
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetDataDump(){} // RVA: 0x7ffaa86491d0
        public void BeginReferenceNode(){}
        public void BeginStructNode(){} // RVA: 0x7ffaa8669e70
        public void BeginArrayNode(){} // RVA: 0x7ffaa8660f30
    }

    public class IDictionaryKeyPathProvider
    {
        // ── Original Methods ──
        public void get_ProviderID(){} // RVA: 0x7ffaa86491d0
        public void Compare(){} // RVA: 0x7ffaa8653ae0
        // ── Binary Analysis Named ──
        public void GetPathStringFromKey(){} // RVA: 0x7ffaa8649280
        public void GetKeyFromPathString(){} // RVA: 0x7ffaa8649280
    }

    public class IDictionaryKeyPathProvider`1
    {
        // ── Original Methods ──
        public void Compare(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetPathStringFromKey(){} // RVA: 0x7ffaa887e5c0
        public void GetKeyFromPathString(){} // RVA: 0x7ffaa887e5c0
    }

    public class IExternalGuidReferenceResolver
    {
        // ── Original Methods ──
        public void get_NextResolver(){} // RVA: 0x7ffaa86491d0
        public void set_NextResolver(){} // RVA: 0x7ffaa8660d80
        public void TryResolveReference(){}
        public void CanReference(){} // RVA: 0x7ffaa864d540
    }

    public class IExternalIndexReferenceResolver
    {
        // ── Original Methods ──
        public void TryResolveReference(){} // RVA: 0x7ffaa864b5a0
        public void CanReference(){} // RVA: 0x7ffaa864d540
    }

    public class IExternalStringReferenceResolver
    {
        // ── Original Methods ──
        public void get_NextResolver(){} // RVA: 0x7ffaa86491d0
        public void set_NextResolver(){} // RVA: 0x7ffaa8660d80
        public void TryResolveReference(){} // RVA: 0x7ffaa864d540
        public void CanReference(){} // RVA: 0x7ffaa864d540
    }

    public class IFormatter
    {
        // ── Original Methods ──
        public void get_SerializedType(){} // RVA: 0x7ffaa86491d0
        public void Serialize(){} // RVA: 0x7ffaa8669e70
        public void Deserialize(){} // RVA: 0x7ffaa8649280
    }

    public class IFormatterLocator
    {
        // ── Original Methods ──
        public void TryGetFormatter(){}
    }

    public class IFormatter`1
    {
        // ── Original Methods ──
        public void Serialize(){} // RVA: 0x7ffaa887e5c0
        public void Deserialize(){} // RVA: 0x7ffaa887e5c0
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class IFormatter`1
    {
    }

    public class ILogger
    {
        // ── Original Methods ──
        public void LogWarning(){} // RVA: 0x7ffaa8660d80
        public void LogError(){} // RVA: 0x7ffaa8660d80
        public void LogException(){} // RVA: 0x7ffaa8660d80
    }

    public class IOverridesSerializationFormat
    {
        // ── Binary Analysis Named ──
        public void GetFormatToSerializeAs(){} // RVA: 0x7ffaa864fe90
    }

    public class IOverridesSerializationPolicy
    {
        // ── Original Methods ──
        public void get_SerializationPolicy(){} // RVA: 0x7ffaa86491d0
        public void get_OdinSerializesUnityFields(){} // RVA: 0x7ffaa864a040
    }

    public class ISelfFormatter
    {
        // ── Original Methods ──
        public void Serialize(){} // RVA: 0x7ffaa8660d80
        public void Deserialize(){} // RVA: 0x7ffaa8660d80
    }

    public class ISerializableFormatterLocator : Object
    {
        // ── Original Methods ──
        public void TryGetFormatter(){} // RVA: 0x7ffaafa09be0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ISerializationPolicy
    {
        // ── Original Methods ──
        public void get_ID(){} // RVA: 0x7ffaa86491d0
        public void get_AllowNonSerializableTypes(){} // RVA: 0x7ffaa864a040
        public void ShouldSerializeMember(){} // RVA: 0x7ffaa864a2a0
    }

    public class ISupportsPrefabSerialization
    {
        // ── Original Methods ──
        public void get_SerializationData(){}
        public void set_SerializationData(){} // RVA: 0x7ffaa887e5c0
    }

    public class Int16Serializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa27f00
        public void WriteValue(){} // RVA: 0x7ffaafa28bd0
        public void .ctor(){} // RVA: 0x7ffaafa28c40
    }

    public class Int32Serializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa28cb0
        public void WriteValue(){} // RVA: 0x7ffaafa29980
        public void .ctor(){} // RVA: 0x7ffaafa299f0
    }

    public class Int64Serializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa29a60
        public void WriteValue(){} // RVA: 0x7ffaafa2a720
        public void .ctor(){} // RVA: 0x7ffaafa2a790
    }

    public class IntPtrSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa2a800
        public void WriteValue(){} // RVA: 0x7ffaafa2b4c0
        public void .ctor(){} // RVA: 0x7ffaafa2b530
    }

}