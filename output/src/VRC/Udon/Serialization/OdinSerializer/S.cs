// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 26
// Methods: 243

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class SByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883BB690
        public void WriteValue(){} // RVA: 0x7FFE883BC360
        public void .ctor(){} // RVA: 0x7FFE883BC3D0
    }

    public class SelfFormatterFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SelfFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFE88399F60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void GetUninitializedObject(){} // RVA: 0x7FFE810A1420
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void ReadSerializationInfo(){} // RVA: 0x7FFE80E2E390
        public void WriteSerializationInfo(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SerializationAbortException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883AD0C0 | overloaded x2
    }

    public class SerializationConfig : Object
    {
        public object LOCK; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy serializationPolicy; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883AD130
        public void get_SerializationPolicy(){} // RVA: 0x7FFE883AD1C0
        public void set_SerializationPolicy(){} // RVA: 0x7FFE883AD3B0
        public void get_DebugContext(){} // RVA: 0x7FFE883AD540
        public void set_DebugContext(){} // RVA: 0x7FFE883AD7C0
        public void ResetToDefault(){} // RVA: 0x7FFE883AD950
    }

    public class SerializationContext : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationConfig config; // 0x10
        public System.Collections.Generic.Dictionary`2<object,int> internalReferenceIdMap; // 0x18
        public System.Runtime.Serialization.StreamingContext streamingContext; // 0x20
        public System.Runtime.Serialization.IFormatterConverter formatterConverter; // 0x30
        public VRC.Udon.Serialization.OdinSerializer.TwoWaySerializationBinder binder; // 0x38
        public VRC.Udon.Serialization.OdinSerializer.IExternalIndexReferenceResolver _indexReferenceResolver; // 0x40
        public VRC.Udon.Serialization.OdinSerializer.IExternalStringReferenceResolver _stringReferenceResolver; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883AE430 | overloaded x4
        public void get_Binder(){} // RVA: 0x7FFE883AE6D0
        public void set_Binder(){} // RVA: 0x7FFE81437330
        public void get_StreamingContext(){} // RVA: 0x7FFE82C84C90
        public void get_FormatterConverter(){} // RVA: 0x7FFE8144E200
        public void get_IndexReferenceResolver(){} // RVA: 0x7FFE81178740
        public void set_IndexReferenceResolver(){} // RVA: 0x7FFE81123200
        public void get_StringReferenceResolver(){} // RVA: 0x7FFE81176730
        public void set_StringReferenceResolver(){} // RVA: 0x7FFE81176740
        public void get_GuidReferenceResolver(){} // RVA: 0x7FFE8119C0E0
        public void set_GuidReferenceResolver(){} // RVA: 0x7FFE812534D0
        public void get_Config(){} // RVA: 0x7FFE883AE790
        public void set_Config(){} // RVA: 0x7FFE810FCE30
        public void TryGetInternalReferenceId(){} // RVA: 0x7FFE883AE840
        public void TryRegisterInternalReference(){} // RVA: 0x7FFE883AE8B0
        public void TryRegisterExternalReference(){} // RVA: 0x7FFE883AEB80 | overloaded x3
        public void ResetInternalReferences(){} // RVA: 0x7FFE883AED50
        public void ResetToDefault(){} // RVA: 0x7FFE883AEDA0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFE883AEF50
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFE810FB310
    }

    public class SerializationData : ValueType
    {
        public string PrefabModificationsReferencedUnityObjectsFieldName;
        public string PrefabModificationsFieldName;

        // ── Methods ──
        public void get_HasEditorData(){} // RVA: 0x7FFE883CEB50
        public void get_ContainsData(){} // RVA: 0x7FFE883CED00
        public void Reset(){} // RVA: 0x7FFE883CED30
    }

    public class SerializationNode : ValueType
    {
    }

    public class SerializationNodeDataReader : BaseDataReader
    {
        public string peekedEntryName; // 0x30
        public System.Nullable`1<0x6661D69C> peekedEntryType; // 0x38
        public string peekedEntryData; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8838BDA0
        public void get_IndexIsValid(){} // RVA: 0x7FFE8838CB50
        public void get_Nodes(){} // RVA: 0x7FFE8838CBB0
        public void set_Nodes(){} // RVA: 0x7FFE8838CC70
        public void get_Stream(){} // RVA: 0x7FFE8838CD10
        public void set_Stream(){} // RVA: 0x7FFE8838CD60
        public void Dispose(){} // RVA: 0x7FFE8838CDB0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE8838CE20
        public void PeekEntry(){} // RVA: 0x7FFE88376EB0 | overloaded x2
        public void EnterArray(){} // RVA: 0x7FFE8838D1A0
        public void EnterNode(){} // RVA: 0x7FFE8838D340
        public void ExitArray(){} // RVA: 0x7FFE8838D920
        public void ExitNode(){} // RVA: 0x7FFE8838DAF0
        public void ReadBoolean(){} // RVA: 0x7FFE8838DD10
        public void ReadByte(){} // RVA: 0x7FFE8838DEB0
        public void ReadChar(){} // RVA: 0x7FFE8838DF60
        public void ReadDecimal(){} // RVA: 0x7FFE8838E120
        public void ReadDouble(){} // RVA: 0x7FFE8838E3B0
        public void ReadExternalReference(){} // RVA: 0x7FFE8838EA90 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7FFE8838EC90
        public void ReadInt16(){} // RVA: 0x7FFE8838EFC0
        public void ReadInt32(){} // RVA: 0x7FFE8838F080
        public void ReadInt64(){} // RVA: 0x7FFE8838F140
        public void ReadInternalReference(){} // RVA: 0x7FFE8838F340
        public void ReadNull(){} // RVA: 0x7FFE8838F540
        public void ReadPrimitiveArray(){} // RVA: 0x7FFE80E2F3B0
        public void ReadSByte(){} // RVA: 0x7FFE8838F630
        public void ReadSingle(){} // RVA: 0x7FFE8838F6E0
        public void ReadString(){} // RVA: 0x7FFE8838F940
        public void ReadUInt16(){} // RVA: 0x7FFE8838FA90
        public void ReadUInt32(){} // RVA: 0x7FFE8838FB50
        public void ReadUInt64(){} // RVA: 0x7FFE8838FC10
        public void GetDataDump(){} // RVA: 0x7FFE8838FE10
        public void ConsumeCurrentEntry(){} // RVA: 0x7FFE88390090
        public void ReadToNextEntry(){} // RVA: 0x7FFE88390100
        public void <.ctor>b__6_0(){} // RVA: 0x7FFE88384670
        public void <.ctor>b__6_1(){} // RVA: 0x7FFE883846A0
        public void <.ctor>b__6_2(){} // RVA: 0x7FFE883846D0
        public void <.ctor>b__6_3(){} // RVA: 0x7FFE88384700
        public void <.ctor>b__6_4(){} // RVA: 0x7FFE88384730
        public void <.ctor>b__6_5(){} // RVA: 0x7FFE88384760
        public void <.ctor>b__6_6(){} // RVA: 0x7FFE88384790
        public void <.ctor>b__6_7(){} // RVA: 0x7FFE883847C0
        public void <.ctor>b__6_8(){} // RVA: 0x7FFE883847F0
        public void <.ctor>b__6_9(){} // RVA: 0x7FFE88384820
        public void <.ctor>b__6_10(){} // RVA: 0x7FFE88384860
        public void <.ctor>b__6_11(){} // RVA: 0x7FFE88384890
        public void <.ctor>b__6_12(){} // RVA: 0x7FFE883848C0
        public void <.ctor>b__6_13(){} // RVA: 0x7FFE883848F0
    }

    public class SerializationNodeDataReaderWriterConfig : Object
    {
    }

    public class SerializationNodeDataWriter : BaseDataWriter
    {
        public System.Collections.Generic.List`1<VRC.Udon.Serialization.OdinSerializer.SerializationNode> nodes; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> primitiveTypeWriters; // 0x38

        // ── Methods ──
        public void get_Nodes(){} // RVA: 0x7FFE88390190
        public void set_Nodes(){} // RVA: 0x7FFE88390250
        public void .ctor(){} // RVA: 0x7FFE883902F0
        public void get_Stream(){} // RVA: 0x7FFE88391000
        public void set_Stream(){} // RVA: 0x7FFE88391050
        public void BeginArrayNode(){} // RVA: 0x7FFE883910A0
        public void BeginReferenceNode(){} // RVA: 0x7FFE88391290
        public void BeginStructNode(){} // RVA: 0x7FFE88391560
        public void Dispose(){} // RVA: 0x7FFE865A8E50
        public void EndArrayNode(){} // RVA: 0x7FFE883917A0
        public void EndNode(){} // RVA: 0x7FFE88391920
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFE817E01F0
        public void WriteBoolean(){} // RVA: 0x7FFE88391AE0
        public void WriteByte(){} // RVA: 0x7FFE88391C70
        public void WriteChar(){} // RVA: 0x7FFE88391EF0
        public void WriteDecimal(){} // RVA: 0x7FFE88392120
        public void WriteSingle(){} // RVA: 0x7FFE88392350
        public void WriteDouble(){} // RVA: 0x7FFE88392590
        public void WriteExternalReference(){} // RVA: 0x7FFE88392B20 | overloaded x3
        public void WriteGuid(){} // RVA: 0x7FFE88392DA0
        public void WriteInt16(){} // RVA: 0x7FFE88392F90
        public void WriteInt32(){} // RVA: 0x7FFE88393170
        public void WriteInt64(){} // RVA: 0x7FFE883933F0
        public void WriteInternalReference(){} // RVA: 0x7FFE88393670
        public void WriteNull(){} // RVA: 0x7FFE883938F0
        public void WritePrimitiveArray(){} // RVA: 0x7FFE80E460A0
        public void WriteSByte(){} // RVA: 0x7FFE88393A60
        public void WriteString(){} // RVA: 0x7FFE88393C40
        public void WriteUInt16(){} // RVA: 0x7FFE88393DA0
        public void WriteUInt32(){} // RVA: 0x7FFE88394020
        public void WriteUInt64(){} // RVA: 0x7FFE883942A0
        public void FlushToStream(){} // RVA: 0x7FFE810FB310
        public void GetDataDump(){} // RVA: 0x7FFE88394520
    }

    public class SerializationPolicies : Object
    {
        public object LOCK;
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy everythingPolicy; // 0x8
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy unityPolicy; // 0x10

        // ── Methods ──
        public void TryGetByID(){} // RVA: 0x7FFE883AEF60
        public void get_Everything(){} // RVA: 0x7FFE883AF1E0
        public void get_Unity(){} // RVA: 0x7FFE883AF5C0
        public void get_Strict(){} // RVA: 0x7FFE883AFAE0
        public void .cctor(){} // RVA: 0x7FFE883AFEC0
    }

    public class SerializationUtility : Object
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7FFE883B07C0
        public void CreateReader(){} // RVA: 0x7FFE883B09C0
        public void GetCachedWriter(){} // RVA: 0x7FFE883B0BB0
        public void GetCachedReader(){} // RVA: 0x7FFE883B0F50
        public void SerializeValueWeak(){} // RVA: 0x7FFE883B1EB0 | overloaded x6
        public void SerializeValue(){} // RVA: 0x7FFE810A1420 | overloaded x6
        public void DeserializeValueWeak(){} // RVA: 0x7FFE883B2AD0 | overloaded x6
        public void DeserializeValue(){} // RVA: 0x7FFE810A1420 | overloaded x6
        public void CreateCopy(){} // RVA: 0x7FFE883B2C00
    }

    public class SerializedBehaviour : Behaviour
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x18

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFE842910B0
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFE883CEFF0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE883CF060
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE883CF0E0
        public void OnAfterDeserialize(){} // RVA: 0x7FFE810FB310
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SerializedComponent : Component
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x18

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFE842910B0
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFE883CEFF0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE883CF160
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE883CF1E0
        public void OnAfterDeserialize(){} // RVA: 0x7FFE810FB310
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SerializedMonoBehaviour : MonoBehaviour
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x20

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFE883CF260
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFE883CF290
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE883CF300
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE883CF380
        public void OnAfterDeserialize(){} // RVA: 0x7FFE810FB310
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SerializedScriptableObject : ScriptableObject
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE883CF400
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE883CF480
        public void OnAfterDeserialize(){} // RVA: 0x7FFE810FB310
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SerializedStateMachineBehaviour : StateMachineBehaviour
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE883CF500
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE883CF580
        public void OnAfterDeserialize(){} // RVA: 0x7FFE810FB310
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SerializedUnityObject : Object
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE883CF600
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE883CF680
        public void OnAfterDeserialize(){} // RVA: 0x7FFE810FB310
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE883CF700
    }

    public class Serializer : Object
    {
        // ── Methods ──
        public void FireOnSerializedType(){} // RVA: 0x7FFE810FB310
        public void GetForValue(){} // RVA: 0x7FFE883BC440
        public void Get(){} // RVA: 0x7FFE883BC590 | overloaded x3
        public void ReadValueWeak(){} // RVA: 0x7FFE80E2E390
        public void WriteValueWeak(){} // RVA: 0x7FFE80E50660 | overloaded x2
        public void Create(){} // RVA: 0x7FFE883BC8D0
        public void LogAOTError(){} // RVA: 0x7FFE883BCD90
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE883BCF30
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7FFE84C7A660
        public void WriteValueWeak(){} // RVA: 0x7FFE84C7A710
        public void ReadValue(){} // RVA: 0x7FFE81081080
        public void WriteValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE84C7A9D0
    }

    public class SingleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883BE430
        public void WriteValue(){} // RVA: 0x7FFE883BF1E0
        public void .ctor(){} // RVA: 0x7FFE883BF250
    }

    public class StackFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetUninitializedObject(){} // RVA: 0x7FFE810A1420
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
    }

    public class StringSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFE883BF2C0
        public void WriteValue(){} // RVA: 0x7FFE883C0090
        public void .ctor(){} // RVA: 0x7FFE883C0120
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void GetUninitializedObject(){} // RVA: 0x7FFE80E2E2E0
        public void DeserializeImplementation(){} // RVA: 0x7FFE80E4F230
        public void SerializeImplementation(){} // RVA: 0x7FFE80E4F230
    }

}