// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 45
// Methods: 376

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class SByteSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa2b5a0
        public void WriteValue(){} // RVA: 0x7ffaafa2c270
        public void .ctor(){} // RVA: 0x7ffaafa2c2e0
    }

    public class SelfFormatterFormatter`1 : BaseFormatter`1
    {
        // ── Original Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class SelfFormatterLocator : Object
    {
        // ── Original Methods ──
        public void TryGetFormatter(){} // RVA: 0x7ffaafa09e90
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void ReadSerializationInfo(){} // RVA: 0x7ffaa8649280
        public void WriteSerializationInfo(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaa887e5c0
    }

    public class SerializationAbortException : Exception
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaafa1cfd0
        public void .ctor(){} // RVA: 0x7ffaafa1cfd0
    }

    public class SerializationConfig : Object
    {
        public object debugContext; // 0x33C64170

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaafa1d040
        public void get_SerializationPolicy(){} // RVA: 0x7ffaafa1d0d0
        public void set_SerializationPolicy(){} // RVA: 0x7ffaafa1d2c0
        public void get_DebugContext(){} // RVA: 0x7ffaafa1d450
        public void set_DebugContext(){} // RVA: 0x7ffaafa1d6d0
        public void ResetToDefault(){} // RVA: 0x7ffaafa1d860
    }

    public class SerializationContext : Object
    {
        public object streamingContext; // 0x334C7110
        public object _indexReferenceResolver; // 0x334C7110, was: <IndexReferenceResolver>k__Bac

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaafa1e340
        public void .ctor(){} // RVA: 0x7ffaafa1e340
        public void .ctor(){} // RVA: 0x7ffaafa1e340
        public void .ctor(){} // RVA: 0x7ffaafa1e340
        public void get_Binder(){} // RVA: 0x7ffaafa1e5e0
        public void set_Binder(){} // RVA: 0x7ffaa8bf45c0
        public void get_StreamingContext(){} // RVA: 0x7ffaaa4204b0
        public void get_FormatterConverter(){} // RVA: 0x7ffaa8bfcc80
        public void get_IndexReferenceResolver(){} // RVA: 0x7ffaa89af740
        public void set_IndexReferenceResolver(){} // RVA: 0x7ffaa895a200
        public void get_StringReferenceResolver(){} // RVA: 0x7ffaa89ad730
        public void set_StringReferenceResolver(){} // RVA: 0x7ffaa89ad740
        public void get_GuidReferenceResolver(){} // RVA: 0x7ffaa89d30e0
        public void set_GuidReferenceResolver(){} // RVA: 0x7ffaa8a8a4d0
        public void get_Config(){} // RVA: 0x7ffaafa1e6a0
        public void set_Config(){} // RVA: 0x7ffaa8933e30
        public void TryGetInternalReferenceId(){} // RVA: 0x7ffaafa1e750
        public void TryRegisterInternalReference(){} // RVA: 0x7ffaafa1e7c0
        public void TryRegisterExternalReference(){} // RVA: 0x7ffaafa1ea90
        public void TryRegisterExternalReference(){} // RVA: 0x7ffaafa1ea90
        public void TryRegisterExternalReference(){} // RVA: 0x7ffaafa1ea90
        public void ResetInternalReferences(){} // RVA: 0x7ffaafa1ec60
        public void ResetToDefault(){} // RVA: 0x7ffaafa1ecb0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7ffaafa1ee60
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7ffaa8932310
    }

    public class SerializationData : ValueType
    {
        public object PrefabFieldName; // 0x33C4D820
        public object ReferencedUnityObjects; // 0x33C4D820
        public object PrefabModificationsReferencedUnityObjects; // 0x33C4D820

        // ── Original Methods ──
        public void get_HasEditorData(){} // RVA: 0x7ffaafa3ea60
        public void get_ContainsData(){} // RVA: 0x7ffaafa3ec10
        public void Reset(){} // RVA: 0x7ffaafa3ec40
    }

    public class SerializationNode : ValueType
    {
        public object Data; // 0x335A2720
    }

    public class SerializationNodeDataReader : BaseDataReader
    {
        public object peekedEntryData; // 0x31872690
        public object primitiveTypeReaders; // 0x31872690
        public object IndexIsValid; // 0x17000023
        public object Nodes; // 0x17000024

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf9fbcd0
        public void get_IndexIsValid(){} // RVA: 0x7ffaaf9fca80
        public void get_Nodes(){} // RVA: 0x7ffaaf9fcae0
        public void set_Nodes(){} // RVA: 0x7ffaaf9fcba0
        public void get_Stream(){} // RVA: 0x7ffaaf9fcc40
        public void set_Stream(){} // RVA: 0x7ffaaf9fcc90
        public void Dispose(){} // RVA: 0x7ffaaf9fcce0
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaaf9fcd50
        public void PeekEntry(){} // RVA: 0x7ffaaf9e6de0
        public void EnterArray(){} // RVA: 0x7ffaaf9fd0d0
        public void EnterNode(){} // RVA: 0x7ffaaf9fd270
        public void ExitArray(){} // RVA: 0x7ffaaf9fd850
        public void ExitNode(){} // RVA: 0x7ffaaf9fda20
        public void ReadBoolean(){} // RVA: 0x7ffaaf9fdc40
        public void ReadByte(){} // RVA: 0x7ffaaf9fdde0
        public void ReadChar(){} // RVA: 0x7ffaaf9fde90
        public void ReadDecimal(){} // RVA: 0x7ffaaf9fe050
        public void ReadDouble(){} // RVA: 0x7ffaaf9fe2e0
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9fe9c0
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9fe9c0
        public void ReadExternalReference(){} // RVA: 0x7ffaaf9fe9c0
        public void ReadGuid(){} // RVA: 0x7ffaaf9febc0
        public void ReadInt16(){} // RVA: 0x7ffaaf9feef0
        public void ReadInt32(){} // RVA: 0x7ffaaf9fefb0
        public void ReadInt64(){} // RVA: 0x7ffaaf9ff070
        public void ReadInternalReference(){} // RVA: 0x7ffaaf9ff270
        public void ReadNull(){} // RVA: 0x7ffaaf9ff470
        public void ReadPrimitiveArray(){} // RVA: 0x7ffaa864a2a0
        public void ReadSByte(){} // RVA: 0x7ffaaf9ff560
        public void ReadSingle(){} // RVA: 0x7ffaaf9ff610
        public void ReadString(){} // RVA: 0x7ffaaf9ff870
        public void ReadUInt16(){} // RVA: 0x7ffaaf9ff9c0
        public void ReadUInt32(){} // RVA: 0x7ffaaf9ffa80
        public void ReadUInt64(){} // RVA: 0x7ffaaf9ffb40
        public void ConsumeCurrentEntry(){} // RVA: 0x7ffaaf9fffc0
        public void PeekEntry(){} // RVA: 0x7ffaaf9e6de0
        public void ReadToNextEntry(){} // RVA: 0x7ffaafa00030
        public void <.ctor>b__6_0(){} // RVA: 0x7ffaaf9f45a0
        public void <.ctor>b__6_1(){} // RVA: 0x7ffaaf9f45d0
        public void <.ctor>b__6_2(){} // RVA: 0x7ffaaf9f4600
        public void <.ctor>b__6_3(){} // RVA: 0x7ffaaf9f4630
        public void <.ctor>b__6_4(){} // RVA: 0x7ffaaf9f4660
        public void <.ctor>b__6_5(){} // RVA: 0x7ffaaf9f4690
        public void <.ctor>b__6_6(){} // RVA: 0x7ffaaf9f46c0
        public void <.ctor>b__6_7(){} // RVA: 0x7ffaaf9f46f0
        public void <.ctor>b__6_8(){} // RVA: 0x7ffaaf9f4720
        public void <.ctor>b__6_9(){} // RVA: 0x7ffaaf9f4750
        public void <.ctor>b__6_10(){} // RVA: 0x7ffaaf9f4790
        public void <.ctor>b__6_11(){} // RVA: 0x7ffaaf9f47c0
        public void <.ctor>b__6_12(){} // RVA: 0x7ffaaf9f47f0
        public void <.ctor>b__6_13(){} // RVA: 0x7ffaaf9f4820
        // ── Binary Analysis Named ──
        public void GetDataDump(){} // RVA: 0x7ffaaf9ffd40
    }

    public class SerializationNodeDataReaderWriterConfig : Object
    {
    }

    public class SerializationNodeDataWriter : BaseDataWriter
    {
        // ── Original Methods ──
        public void get_Nodes(){} // RVA: 0x7ffaafa000c0
        public void set_Nodes(){} // RVA: 0x7ffaafa00180
        public void .ctor(){} // RVA: 0x7ffaafa00220
        public void get_Stream(){} // RVA: 0x7ffaafa00f30
        public void set_Stream(){} // RVA: 0x7ffaafa00f80
        public void Dispose(){} // RVA: 0x7ffaadc206c0
        public void EndArrayNode(){} // RVA: 0x7ffaafa016d0
        public void EndNode(){} // RVA: 0x7ffaafa01850
        public void PrepareNewSerializationSession(){} // RVA: 0x7ffaa90bf2b0
        public void WriteBoolean(){} // RVA: 0x7ffaafa01a10
        public void WriteByte(){} // RVA: 0x7ffaafa01ba0
        public void WriteChar(){} // RVA: 0x7ffaafa01e20
        public void WriteDecimal(){} // RVA: 0x7ffaafa02050
        public void WriteSingle(){} // RVA: 0x7ffaafa02280
        public void WriteDouble(){} // RVA: 0x7ffaafa024c0
        public void WriteExternalReference(){} // RVA: 0x7ffaafa02a50
        public void WriteExternalReference(){} // RVA: 0x7ffaafa02a50
        public void WriteExternalReference(){} // RVA: 0x7ffaafa02a50
        public void WriteGuid(){} // RVA: 0x7ffaafa02cd0
        public void WriteInt16(){} // RVA: 0x7ffaafa02ec0
        public void WriteInt32(){} // RVA: 0x7ffaafa030a0
        public void WriteInt64(){} // RVA: 0x7ffaafa03320
        public void WriteInternalReference(){} // RVA: 0x7ffaafa035a0
        public void WriteNull(){} // RVA: 0x7ffaafa03820
        public void WritePrimitiveArray(){} // RVA: 0x7ffaa8660d80
        public void WriteSByte(){} // RVA: 0x7ffaafa03990
        public void WriteString(){} // RVA: 0x7ffaafa03b70
        public void WriteUInt16(){} // RVA: 0x7ffaafa03cd0
        public void WriteUInt32(){} // RVA: 0x7ffaafa03f50
        public void WriteUInt64(){} // RVA: 0x7ffaafa041d0
        public void FlushToStream(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void BeginArrayNode(){} // RVA: 0x7ffaafa00fd0
        public void BeginReferenceNode(){} // RVA: 0x7ffaafa011c0
        public void BeginStructNode(){} // RVA: 0x7ffaafa01490
        public void GetDataDump(){} // RVA: 0x7ffaafa04450
    }

    public class SerializationPolicies : Object
    {
        public object unityPolicy; // 0x3358A350

        // ── Original Methods ──
        public void TryGetByID(){} // RVA: 0x7ffaafa1ee70
        public void get_Everything(){} // RVA: 0x7ffaafa1f0f0
        public void get_Unity(){} // RVA: 0x7ffaafa1f4d0
        public void get_Strict(){} // RVA: 0x7ffaafa1f9f0
        public void .cctor(){} // RVA: 0x7ffaafa1fdd0
    }

    public class SerializationUtility : Object
    {
        // ── Original Methods ──
        public void CreateWriter(){} // RVA: 0x7ffaafa206d0
        public void CreateReader(){} // RVA: 0x7ffaafa208d0
        public void SerializeValueWeak(){} // RVA: 0x7ffaafa21dc0
        public void SerializeValueWeak(){} // RVA: 0x7ffaafa21dc0
        public void SerializeValue(){} // RVA: 0x7ffaa887e5c0
        public void SerializeValue(){} // RVA: 0x7ffaa887e5c0
        public void SerializeValueWeak(){} // RVA: 0x7ffaafa21dc0
        public void SerializeValueWeak(){} // RVA: 0x7ffaafa21dc0
        public void SerializeValue(){} // RVA: 0x7ffaa887e5c0
        public void SerializeValue(){} // RVA: 0x7ffaa887e5c0
        public void SerializeValueWeak(){} // RVA: 0x7ffaafa21dc0
        public void SerializeValueWeak(){} // RVA: 0x7ffaafa21dc0
        public void SerializeValue(){} // RVA: 0x7ffaa887e5c0
        public void SerializeValue(){} // RVA: 0x7ffaa887e5c0
        public void DeserializeValueWeak(){} // RVA: 0x7ffaafa229e0
        public void DeserializeValueWeak(){} // RVA: 0x7ffaafa229e0
        public void DeserializeValue(){} // RVA: 0x7ffaa887e5c0
        public void DeserializeValue(){} // RVA: 0x7ffaa887e5c0
        public void DeserializeValueWeak(){} // RVA: 0x7ffaafa229e0
        public void DeserializeValueWeak(){} // RVA: 0x7ffaafa229e0
        public void DeserializeValue(){} // RVA: 0x7ffaa887e5c0
        public void DeserializeValue(){} // RVA: 0x7ffaa887e5c0
        public void DeserializeValueWeak(){} // RVA: 0x7ffaafa229e0
        public void DeserializeValueWeak(){} // RVA: 0x7ffaafa229e0
        public void DeserializeValue(){} // RVA: 0x7ffaa887e5c0
        public void DeserializeValue(){} // RVA: 0x7ffaa887e5c0
        public void CreateCopy(){} // RVA: 0x7ffaafa22b10
        // ── Binary Analysis Named ──
        public void GetCachedWriter(){} // RVA: 0x7ffaafa20ac0
        public void GetCachedReader(){} // RVA: 0x7ffaafa20e60
    }

    public class SerializedBehaviour : Behaviour
    {
        // ── Original Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7ffaab94b190
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7ffaafa3ef00
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaafa3ef70
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaafa3eff0
        public void OnAfterDeserialize(){} // RVA: 0x7ffaa8932310
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SerializedComponent : Component
    {
        // ── Original Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7ffaab94b190
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7ffaafa3ef00
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaafa3f070
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaafa3f0f0
        public void OnAfterDeserialize(){} // RVA: 0x7ffaa8932310
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SerializedMonoBehaviour : MonoBehaviour
    {
        // ── Original Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7ffaafa3f170
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7ffaafa3f1a0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaafa3f210
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaafa3f290
        public void OnAfterDeserialize(){} // RVA: 0x7ffaa8932310
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SerializedScriptableObject : ScriptableObject
    {
        // ── Original Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaafa3f310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaafa3f390
        public void OnAfterDeserialize(){} // RVA: 0x7ffaa8932310
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SerializedStateMachineBehaviour : StateMachineBehaviour
    {
        // ── Original Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaafa3f410
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaafa3f490
        public void OnAfterDeserialize(){} // RVA: 0x7ffaa8932310
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SerializedUnityObject : Object
    {
        // ── Original Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaafa3f510
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaafa3f590
        public void OnAfterDeserialize(){} // RVA: 0x7ffaa8932310
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaafa3f610
    }

    public class Serializer : Object
    {
        public object Weak_ReaderWriterCache; // 0x30E1C550

        // ── Original Methods ──
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void ReadValueWeak(){} // RVA: 0x7ffaa8649280
        public void WriteValueWeak(){} // RVA: 0x7ffaa866b2a0
        public void WriteValueWeak(){} // RVA: 0x7ffaa866b2a0
        public void Create(){} // RVA: 0x7ffaafa2c7e0
        public void LogAOTError(){} // RVA: 0x7ffaafa2cca0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaafa2ce40
        // ── Binary Analysis Named ──
        public void GetForValue(){} // RVA: 0x7ffaafa2c350
        public void Get(){} // RVA: 0x7ffaafa2c4a0
        public void Get(){} // RVA: 0x7ffaafa2c4a0
        public void Get(){} // RVA: 0x7ffaafa2c4a0
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac329890
        public void WriteValueWeak(){} // RVA: 0x7ffaac329940
        public void ReadValue(){} // RVA: 0x7ffaa884bb60
        public void WriteValue(){} // RVA: 0x7ffaa887e5c0
        public void WriteValue(){} // RVA: 0x7ffaa887e5c0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac329c00
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaa8649280
        public void WriteValueWeak(){} // RVA: 0x7ffaa866b2a0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void WriteValue(){} // RVA: 0x7ffaa887e5c0
        public void WriteValue(){} // RVA: 0x7ffaa887e5c0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac329890
        public void WriteValueWeak(){} // RVA: 0x7ffaac329940
        public void ReadValue(){} // RVA: 0x7ffaa884bb60
        public void WriteValue(){} // RVA: 0x7ffaa887e5c0
        public void WriteValue(){} // RVA: 0x7ffaa887e5c0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac329c00
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac325cb0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325cf0
        public void ReadValue(){} // RVA: 0x7ffaa864a2a0
        public void WriteValue(){} // RVA: 0x7ffaa8666f10
        public void WriteValue(){} // RVA: 0x7ffaa8666f10
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac325dd0
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac3257c0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325800
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x7ffaac3258b0
        public void WriteValue(){} // RVA: 0x7ffaac3258b0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac329400
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac325430
        public void WriteValueWeak(){} // RVA: 0x7ffaac325480
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x7ffaac325530
        public void WriteValue(){} // RVA: 0x7ffaac325530
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac3272f0
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac325ec0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325f00
        public void ReadValue(){} // RVA: 0x7ffaa864f910
        public void WriteValue(){} // RVA: 0x7ffaac325fb0
        public void WriteValue(){} // RVA: 0x7ffaac325fb0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac329310
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac325430
        public void WriteValueWeak(){} // RVA: 0x7ffaac325480
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x7ffaac325530
        public void WriteValue(){} // RVA: 0x7ffaac325530
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac326c60
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac325ec0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325f00
        public void ReadValue(){} // RVA: 0x7ffaa864f910
        public void WriteValue(){} // RVA: 0x7ffaac325fb0
        public void WriteValue(){} // RVA: 0x7ffaac325fb0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac327930
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac325ec0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325f00
        public void ReadValue(){} // RVA: 0x7ffaa864f910
        public void WriteValue(){} // RVA: 0x7ffaac325fb0
        public void WriteValue(){} // RVA: 0x7ffaac325fb0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac325fe0
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac3257c0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325800
        public void ReadValue(){}
        public void WriteValue(){} // RVA: 0x7ffaa8669ba0
        public void WriteValue(){} // RVA: 0x7ffaa8669ba0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac327a20
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac328910
        public void WriteValueWeak(){} // RVA: 0x7ffaac328960
        public void ReadValue(){} // RVA: 0x7ffaa865e2d0
        public void WriteValue(){} // RVA: 0x7ffaa866dc20
        public void WriteValue(){} // RVA: 0x7ffaa866dc20
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac328a10
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac3281f0
        public void WriteValueWeak(){} // RVA: 0x7ffaac328210
        public void ReadValue(){} // RVA: 0x7ffaa8649280
        public void WriteValue(){} // RVA: 0x7ffaa866b2a0
        public void WriteValue(){} // RVA: 0x7ffaa866b2a0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac3282d0
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac325cb0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325cf0
        public void ReadValue(){} // RVA: 0x7ffaa864a2a0
        public void WriteValue(){} // RVA: 0x7ffaac325da0
        public void WriteValue(){} // RVA: 0x7ffaac325da0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac328870
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac325cb0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325cf0
        public void ReadValue(){} // RVA: 0x7ffaa864a2a0
        public void WriteValue(){} // RVA: 0x7ffaa8666f10
        public void WriteValue(){} // RVA: 0x7ffaa8666f10
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac325e70
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac326e60
        public void WriteValueWeak(){} // RVA: 0x7ffaac326eb0
        public void ReadValue(){} // RVA: 0x7ffaa864f240
        public void WriteValue(){} // RVA: 0x7ffaac326f60
        public void WriteValue(){} // RVA: 0x7ffaac326f60
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac326f90
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac3257c0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325800
        public void ReadValue(){} // RVA: 0x7ffaa8649280
        public void WriteValue(){} // RVA: 0x7ffaac3258b0
        public void WriteValue(){} // RVA: 0x7ffaac3258b0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac3279d0
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac3260d0
        public void WriteValueWeak(){} // RVA: 0x7ffaac326110
        public void ReadValue(){} // RVA: 0x7ffaa864e9f0
        public void WriteValue(){} // RVA: 0x7ffaa8668a10
        public void WriteValue(){} // RVA: 0x7ffaa8668a10
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac327980
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac3260d0
        public void WriteValueWeak(){} // RVA: 0x7ffaac326110
        public void ReadValue(){} // RVA: 0x7ffaa864e9f0
        public void WriteValue(){} // RVA: 0x7ffaac3261c0
        public void WriteValue(){} // RVA: 0x7ffaac3261c0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac329360
    }

    public class Serializer`1 : Serializer
    {
        // ── Original Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ffaac3257c0
        public void WriteValueWeak(){} // RVA: 0x7ffaac325800
        public void ReadValue(){} // RVA: 0x7ffaa8649280
        public void WriteValue(){} // RVA: 0x7ffaac3258b0
        public void WriteValue(){} // RVA: 0x7ffaac3258b0
        public void FireOnSerializedType(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaac3293b0
    }

    public class SingleSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa2e340
        public void WriteValue(){} // RVA: 0x7ffaafa2f0f0
        public void .ctor(){} // RVA: 0x7ffaafa2f160
    }

    public class StackFormatter`2 : BaseFormatter`1
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaa887e5c0
    }

    public class StringSerializer : Serializer`1
    {
        // ── Original Methods ──
        public void ReadValue(){} // RVA: 0x7ffaafa2f1d0
        public void WriteValue(){} // RVA: 0x7ffaafa2ffa0
        public void .ctor(){} // RVA: 0x7ffaafa30030
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void DeserializeImplementation(){} // RVA: 0x7ffaa8669e70
        public void SerializeImplementation(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetUninitializedObject(){} // RVA: 0x7ffaa86491d0
    }

}