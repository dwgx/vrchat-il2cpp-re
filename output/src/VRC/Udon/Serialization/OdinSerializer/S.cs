// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 69
// Methods: 538

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class SByteSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x787E9D0
        public void WriteValue(){} // RVA: 0x787F6A0
        public void .ctor(){} // RVA: 0x787F710
    }

    public class SelfFormatterFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x2DC60
        public void SerializeImplementation(){} // RVA: 0x2DC60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SelfFormatterLocator
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x785D2A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SerializableFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void GetUninitializedObject(){} // RVA: 0x283FA0
        public void DeserializeImplementation(){} // RVA: 0x2DC60
        public void SerializeImplementation(){} // RVA: 0x2DC60
        public void ReadSerializationInfo(){} // RVA: 0xCE10
        public void WriteSerializationInfo(){} // RVA: 0x2DC60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SerializableFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x4000B60
        public void GetUninitializedObject(){} // RVA: 0x519240
        public void DeserializeImplementation(){} // RVA: 0x40015D0
        public void SerializeImplementation(){} // RVA: 0x4001A70
        public void ReadSerializationInfo(){} // RVA: 0x4001D80
        public void WriteSerializationInfo(){} // RVA: 0x4002530
        public void .ctor(){} // RVA: 0x3FFED20
    }

    public class SerializableFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x4000B60
        public void GetUninitializedObject(){} // RVA: 0x519240
        public void DeserializeImplementation(){} // RVA: 0x40015D0
        public void SerializeImplementation(){} // RVA: 0x4001A70
        public void ReadSerializationInfo(){} // RVA: 0x4001D80
        public void WriteSerializationInfo(){} // RVA: 0x4002530
        public void .ctor(){} // RVA: 0x3FFED20
    }

    public class SerializableFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x4000B60
        public void GetUninitializedObject(){} // RVA: 0x519240
        public void DeserializeImplementation(){} // RVA: 0x40015D0
        public void SerializeImplementation(){} // RVA: 0x4001A70
        public void ReadSerializationInfo(){} // RVA: 0x4001D80
        public void WriteSerializationInfo(){} // RVA: 0x4002530
        public void .ctor(){} // RVA: 0x3FFED20
    }

    public class SerializableFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x4000B60
        public void GetUninitializedObject(){} // RVA: 0x519240
        public void DeserializeImplementation(){} // RVA: 0x40015D0
        public void SerializeImplementation(){} // RVA: 0x4001A70
        public void ReadSerializationInfo(){} // RVA: 0x4001D80
        public void WriteSerializationInfo(){} // RVA: 0x4002530
        public void .ctor(){} // RVA: 0x3FFED20
    }

    public class SerializationAbortException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7870400 | overloaded x2
    }

    public class SerializationConfig
    {
        public object boneLengthCanBeZero; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy serializationPolicy; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7870470
        public void get_SerializationPolicy(){} // RVA: 0x7870500
        public void set_SerializationPolicy(){} // RVA: 0x78706F0
        public void get_DebugContext(){} // RVA: 0x7870880
        public void set_DebugContext(){} // RVA: 0x7870B00
        public void ResetToDefault(){} // RVA: 0x7870C90
    }

    public class SerializationContext
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationConfig config; // 0x10
        public System.Collections.Generic.Dictionary`2<object,int> internalReferenceIdMap; // 0x18
        public System.Runtime.Serialization.StreamingContext streamingContext; // 0x20
        public System.Runtime.Serialization.IFormatterConverter formatterConverter; // 0x30
        public VRC.Udon.Serialization.OdinSerializer.TwoWaySerializationBinder binder; // 0x38
        public VRC.Udon.Serialization.OdinSerializer.IExternalIndexReferenceResolver <IndexReferenceResolver>k__BackingField; // 0x40
        public VRC.Udon.Serialization.OdinSerializer.IExternalStringReferenceResolver <StringReferenceResolver>k__BackingField; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7871770 | overloaded x4
        public void get_Binder(){} // RVA: 0x7871A10
        public void set_Binder(){} // RVA: 0x49B830
        public void get_StreamingContext(){} // RVA: 0x1EFB630
        public void get_FormatterConverter(){} // RVA: 0x6374D0
        public void get_IndexReferenceResolver(){} // RVA: 0x35A740
        public void set_IndexReferenceResolver(){} // RVA: 0x305200
        public void get_StringReferenceResolver(){} // RVA: 0x358730
        public void set_StringReferenceResolver(){} // RVA: 0x358740
        public void get_GuidReferenceResolver(){} // RVA: 0x37E0E0
        public void set_GuidReferenceResolver(){} // RVA: 0x4354D0
        public void get_Config(){} // RVA: 0x7871AD0
        public void set_Config(){} // RVA: 0x2DEE30
        public void TryGetInternalReferenceId(){} // RVA: 0x7871B80
        public void TryRegisterInternalReference(){} // RVA: 0x7871BF0
        public void TryRegisterExternalReference(){} // RVA: 0x7871EC0 | overloaded x3
        public void ResetInternalReferences(){} // RVA: 0x7872090
        public void ResetToDefault(){} // RVA: 0x78720E0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7872290
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x2DD310
    }

    public class SerializationData
    {
        public string usingMaterial;
        public string initialized;

        // ── Methods ──
        public void get_HasEditorData(){} // RVA: 0x7891EA0
        public void get_ContainsData(){} // RVA: 0x7892050
        public void Reset(){} // RVA: 0x7892080
    }

    public class SerializationNode
    {
    }

    public class SerializationNodeDataReader
    {
        public string peekedEntryName; // 0x30
        public System.Nullable`1<0x6593FF90> peekedEntryType; // 0x38
        public string peekedEntryData; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x784F0E0
        public void get_IndexIsValid(){} // RVA: 0x784FE90
        public void get_Nodes(){} // RVA: 0x784FEF0
        public void set_Nodes(){} // RVA: 0x784FFB0
        public void get_Stream(){} // RVA: 0x7850050
        public void set_Stream(){} // RVA: 0x78500A0
        public void Dispose(){} // RVA: 0x78500F0
        public void PrepareNewSerializationSession(){} // RVA: 0x7850160
        public void PeekEntry(){} // RVA: 0x783A1F0 | overloaded x2
        public void EnterArray(){} // RVA: 0x78504E0
        public void EnterNode(){} // RVA: 0x7850680
        public void ExitArray(){} // RVA: 0x7850C60
        public void ExitNode(){} // RVA: 0x7850E30
        public void ReadBoolean(){} // RVA: 0x7851050
        public void ReadByte(){} // RVA: 0x78511F0
        public void ReadChar(){} // RVA: 0x78512A0
        public void ReadDecimal(){} // RVA: 0x7851460
        public void ReadDouble(){} // RVA: 0x78516F0
        public void ReadExternalReference(){} // RVA: 0x7851DD0 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7851FD0
        public void ReadInt16(){} // RVA: 0x7852300
        public void ReadInt32(){} // RVA: 0x78523C0
        public void ReadInt64(){} // RVA: 0x7852480
        public void ReadInternalReference(){} // RVA: 0x7852680
        public void ReadNull(){} // RVA: 0x7852880
        public void ReadPrimitiveArray(){} // RVA: 0xDE40
        public void ReadSByte(){} // RVA: 0x7852970
        public void ReadSingle(){} // RVA: 0x7852A20
        public void ReadString(){} // RVA: 0x7852C80
        public void ReadUInt16(){} // RVA: 0x7852DD0
        public void ReadUInt32(){} // RVA: 0x7852E90
        public void ReadUInt64(){} // RVA: 0x7852F50
        public void GetDataDump(){} // RVA: 0x7853150
        public void ConsumeCurrentEntry(){} // RVA: 0x78533D0
        public void ReadToNextEntry(){} // RVA: 0x7853440
        public void <.ctor>b__6_0(){} // RVA: 0x78479B0
        public void <.ctor>b__6_1(){} // RVA: 0x78479E0
        public void <.ctor>b__6_2(){} // RVA: 0x7847A10
        public void <.ctor>b__6_3(){} // RVA: 0x7847A40
        public void <.ctor>b__6_4(){} // RVA: 0x7847A70
        public void <.ctor>b__6_5(){} // RVA: 0x7847AA0
        public void <.ctor>b__6_6(){} // RVA: 0x7847AD0
        public void <.ctor>b__6_7(){} // RVA: 0x7847B00
        public void <.ctor>b__6_8(){} // RVA: 0x7847B30
        public void <.ctor>b__6_9(){} // RVA: 0x7847B60
        public void <.ctor>b__6_10(){} // RVA: 0x7847BA0
        public void <.ctor>b__6_11(){} // RVA: 0x7847BD0
        public void <.ctor>b__6_12(){} // RVA: 0x7847C00
        public void <.ctor>b__6_13(){} // RVA: 0x7847C30
    }

    public class SerializationNodeDataReaderWriterConfig
    {
    }

    public class SerializationNodeDataWriter
    {
        public System.Collections.Generic.List`1<VRC.Udon.Serialization.OdinSerializer.SerializationNode> nodes; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> primitiveTypeWriters; // 0x38

        // ── Methods ──
        public void get_Nodes(){} // RVA: 0x78534D0
        public void set_Nodes(){} // RVA: 0x7853590
        public void .ctor(){} // RVA: 0x7853630
        public void get_Stream(){} // RVA: 0x7854340
        public void set_Stream(){} // RVA: 0x7854390
        public void BeginArrayNode(){} // RVA: 0x78543E0
        public void BeginReferenceNode(){} // RVA: 0x78545D0
        public void BeginStructNode(){} // RVA: 0x78548A0
        public void Dispose(){} // RVA: 0x5A68150
        public void EndArrayNode(){} // RVA: 0x7854AE0
        public void EndNode(){} // RVA: 0x7854C60
        public void PrepareNewSerializationSession(){} // RVA: 0xA52E70
        public void WriteBoolean(){} // RVA: 0x7854E20
        public void WriteByte(){} // RVA: 0x7854FB0
        public void WriteChar(){} // RVA: 0x7855230
        public void WriteDecimal(){} // RVA: 0x7855460
        public void WriteSingle(){} // RVA: 0x7855690
        public void WriteDouble(){} // RVA: 0x78558D0
        public void WriteExternalReference(){} // RVA: 0x7855E60 | overloaded x3
        public void WriteGuid(){} // RVA: 0x78560E0
        public void WriteInt16(){} // RVA: 0x78562D0
        public void WriteInt32(){} // RVA: 0x78564B0
        public void WriteInt64(){} // RVA: 0x7856730
        public void WriteInternalReference(){} // RVA: 0x78569B0
        public void WriteNull(){} // RVA: 0x7856C30
        public void WritePrimitiveArray(){} // RVA: 0x24B10
        public void WriteSByte(){} // RVA: 0x7856DA0
        public void WriteString(){} // RVA: 0x7856F80
        public void WriteUInt16(){} // RVA: 0x78570E0
        public void WriteUInt32(){} // RVA: 0x7857360
        public void WriteUInt64(){} // RVA: 0x78575E0
        public void FlushToStream(){} // RVA: 0x2DD310
        public void GetDataDump(){} // RVA: 0x7857860
    }

    public class SerializationPolicies
    {
        public object CacheDir;
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy FreeDiskSpaceBytes; // 0x8
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy unityPolicy; // 0x10

        // ── Methods ──
        public void TryGetByID(){} // RVA: 0x78722A0
        public void get_Everything(){} // RVA: 0x7872520
        public void get_Unity(){} // RVA: 0x7872900
        public void get_Strict(){} // RVA: 0x7872E20
        public void .cctor(){} // RVA: 0x7873200
    }

    public class SerializationUtility
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7873B00
        public void CreateReader(){} // RVA: 0x7873D00
        public void GetCachedWriter(){} // RVA: 0x7873EF0
        public void GetCachedReader(){} // RVA: 0x7874290
        public void SerializeValueWeak(){} // RVA: 0x78751F0 | overloaded x6
        public void SerializeValue(){} // RVA: 0x283FA0 | overloaded x6
        public void DeserializeValueWeak(){} // RVA: 0x7875E10 | overloaded x6
        public void DeserializeValue(){} // RVA: 0x283FA0 | overloaded x6
        public void CreateCopy(){} // RVA: 0x7875F40
    }

    public class SerializedBehaviour
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x18

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x3617550
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7892340
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x78923B0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7892430
        public void OnAfterDeserialize(){} // RVA: 0x2DD310
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SerializedComponent
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x18

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x3617550
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7892340
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x78924B0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7892530
        public void OnAfterDeserialize(){} // RVA: 0x2DD310
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SerializedMonoBehaviour
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x20

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x50CE740
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x78925B0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7892620
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x78926A0
        public void OnAfterDeserialize(){} // RVA: 0x2DD310
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SerializedScriptableObject
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7892720
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x78927A0
        public void OnAfterDeserialize(){} // RVA: 0x2DD310
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SerializedStateMachineBehaviour
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7892820
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x78928A0
        public void OnAfterDeserialize(){} // RVA: 0x2DD310
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SerializedUnityObject
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7892920
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x78929A0
        public void OnAfterDeserialize(){} // RVA: 0x2DD310
        public void OnBeforeSerialize(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x7892A20
    }

    public class Serializer
    {
        // ── Methods ──
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void GetForValue(){} // RVA: 0x787F780
        public void Get(){} // RVA: 0x787F8D0 | overloaded x3
        public void ReadValueWeak(){} // RVA: 0xCE10
        public void WriteValueWeak(){} // RVA: 0x2F090 | overloaded x2
        public void Create(){} // RVA: 0x787FC10
        public void LogAOTError(){} // RVA: 0x78800D0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x7880270
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400F890
        public void WriteValueWeak(){} // RVA: 0x400F940
        public void ReadValue(){} // RVA: 0x263BC0
        public void WriteValue(){} // RVA: 0x283FA0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400FC00
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0xCE10
        public void WriteValueWeak(){} // RVA: 0x2F090
        public void ReadValue(){} // RVA: 0x283FA0
        public void WriteValue(){} // RVA: 0x283FA0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x24A80
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400F890
        public void WriteValueWeak(){} // RVA: 0x400F940
        public void ReadValue(){} // RVA: 0x263BC0
        public void WriteValue(){} // RVA: 0x283FA0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400FC00
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400C4D0
        public void WriteValueWeak(){} // RVA: 0x400C510
        public void ReadValue(){} // RVA: 0xDE40
        public void WriteValue(){} // RVA: 0x2AD00 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400C5F0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400BFE0
        public void WriteValueWeak(){} // RVA: 0x400C020
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x400C0D0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400F680
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400BC50
        public void WriteValueWeak(){} // RVA: 0x400BCA0
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x400BD50 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400DB10
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400C6E0
        public void WriteValueWeak(){} // RVA: 0x400C720
        public void ReadValue(){} // RVA: 0x134B0
        public void WriteValue(){} // RVA: 0x400C7D0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400F590
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400BC50
        public void WriteValueWeak(){} // RVA: 0x400BCA0
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x400BD50 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400D480
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400C6E0
        public void WriteValueWeak(){} // RVA: 0x400C720
        public void ReadValue(){} // RVA: 0x134B0
        public void WriteValue(){} // RVA: 0x400C7D0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400E150
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400BFE0
        public void WriteValueWeak(){} // RVA: 0x400C020
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x2D990 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400E240
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EE60
        public void WriteValueWeak(){} // RVA: 0x400EEB0
        public void ReadValue(){} // RVA: 0x21FA0
        public void WriteValue(){} // RVA: 0x31A10 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EF60
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400C4D0
        public void WriteValueWeak(){} // RVA: 0x400C510
        public void ReadValue(){} // RVA: 0xDE40
        public void WriteValue(){} // RVA: 0x400C5C0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EE10
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400C4D0
        public void WriteValueWeak(){} // RVA: 0x400C510
        public void ReadValue(){} // RVA: 0xDE40
        public void WriteValue(){} // RVA: 0x2AD00 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400C690
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400D680
        public void WriteValueWeak(){} // RVA: 0x400D6D0
        public void ReadValue(){} // RVA: 0x12DE0
        public void WriteValue(){} // RVA: 0x400D780 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400D7B0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400BFE0
        public void WriteValueWeak(){} // RVA: 0x400C020
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x400C0D0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400E1F0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400C6E0
        public void WriteValueWeak(){} // RVA: 0x400C720
        public void ReadValue(){} // RVA: 0x134B0
        public void WriteValue(){} // RVA: 0x400C7D0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400C800
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400C8F0
        public void WriteValueWeak(){} // RVA: 0x400C930
        public void ReadValue(){} // RVA: 0x12590
        public void WriteValue(){} // RVA: 0x2C800 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400E1A0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400C8F0
        public void WriteValueWeak(){} // RVA: 0x400C930
        public void ReadValue(){} // RVA: 0x12590
        public void WriteValue(){} // RVA: 0x400C9E0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400F5E0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400BFE0
        public void WriteValueWeak(){} // RVA: 0x400C020
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x400C0D0 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400F630
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400BE30
        public void WriteValueWeak(){} // RVA: 0x400BE90
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x400BF50 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400BF90
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class Serializer`1
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x400EA10
        public void WriteValueWeak(){} // RVA: 0x400EA30
        public void ReadValue(){} // RVA: 0xCE10
        public void WriteValue(){} // RVA: 0x2F090 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x400EAF0
    }

    public class SingleSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7881770
        public void WriteValue(){} // RVA: 0x7882520
        public void .ctor(){} // RVA: 0x7882590
    }

    public class StackFormatter`2
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void .ctor(){} // RVA: 0x24A50
        public void GetUninitializedObject(){} // RVA: 0x283FA0
        public void DeserializeImplementation(){} // RVA: 0x2DC60
        public void SerializeImplementation(){} // RVA: 0x2DC60
    }

    public class StringSerializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7882600
        public void WriteValue(){} // RVA: 0x78833D0
        public void .ctor(){} // RVA: 0x7883460
    }

    public class StrongBoxFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x24A80
        public void .ctor(){} // RVA: 0x24A50
        public void GetUninitializedObject(){} // RVA: 0xCD60
        public void DeserializeImplementation(){} // RVA: 0x2DC60
        public void SerializeImplementation(){} // RVA: 0x2DC60
    }

    public class StrongBoxFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x409E3F0
        public void .ctor(){} // RVA: 0x2E5ED40
        public void GetUninitializedObject(){} // RVA: 0x4093700
        public void DeserializeImplementation(){} // RVA: 0x409E580
        public void SerializeImplementation(){} // RVA: 0x409E680
    }

    public class StrongBoxFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x4099E20
        public void .ctor(){} // RVA: 0x2E5ED40
        public void GetUninitializedObject(){} // RVA: 0x4093700
        public void DeserializeImplementation(){} // RVA: 0x40958F0
        public void SerializeImplementation(){} // RVA: 0x4099FB0
    }

    public class StrongBoxFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x409E3F0
        public void .ctor(){} // RVA: 0x2E5ED40
        public void GetUninitializedObject(){} // RVA: 0x4093700
        public void DeserializeImplementation(){} // RVA: 0x409E580
        public void SerializeImplementation(){} // RVA: 0x409E680
    }

}