// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 26
// Methods: 243

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class SByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD55428B80
        public void WriteValue(){} // RVA: 0x7FFD55429850
        public void .ctor(){} // RVA: 0x7FFD554298C0
    }

    public class SelfFormatterFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SelfFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFD55407470
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E2ADC40
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void ReadSerializationInfo(){} // RVA: 0x7FFD4E078F40
        public void WriteSerializationInfo(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SerializationAbortException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5541A5B0 | overloaded x2
    }

    public class SerializationConfig : Object
    {
        public object SerializationPolicy;
        public object DebugContext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5541A620
        public void get_SerializationPolicy(){} // RVA: 0x7FFD5541A6B0
        public void set_SerializationPolicy(){} // RVA: 0x7FFD5541A8A0
        public void get_DebugContext(){} // RVA: 0x7FFD5541AA30
        public void set_DebugContext(){} // RVA: 0x7FFD5541ACB0
        public void ResetToDefault(){} // RVA: 0x7FFD5541AE40
    }

    public class SerializationContext : Object
    {
        public object Binder;
        public object StreamingContext;
        public object FormatterConverter;
        public object IndexReferenceResolver;
        public object StringReferenceResolver;
        public object GuidReferenceResolver;
        public object Config;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5541B920 | overloaded x4
        public void get_Binder(){} // RVA: 0x7FFD5541BBC0
        public void set_Binder(){} // RVA: 0x7FFD4E5F0C20
        public void get_StreamingContext(){} // RVA: 0x7FFD4FE39630
        public void get_FormatterConverter(){} // RVA: 0x7FFD4E5F95E0
        public void get_IndexReferenceResolver(){} // RVA: 0x7FFD4E3BE740
        public void set_IndexReferenceResolver(){} // RVA: 0x7FFD4E369200
        public void get_StringReferenceResolver(){} // RVA: 0x7FFD4E3BC730
        public void set_StringReferenceResolver(){} // RVA: 0x7FFD4E3BC740
        public void get_GuidReferenceResolver(){} // RVA: 0x7FFD4E3E20E0
        public void set_GuidReferenceResolver(){} // RVA: 0x7FFD4E4994D0
        public void get_Config(){} // RVA: 0x7FFD5541BC80
        public void set_Config(){} // RVA: 0x7FFD4E342E30
        public void TryGetInternalReferenceId(){} // RVA: 0x7FFD5541BD30
        public void TryRegisterInternalReference(){} // RVA: 0x7FFD5541BDA0
        public void TryRegisterExternalReference(){} // RVA: 0x7FFD5541C070 | overloaded x3
        public void ResetInternalReferences(){} // RVA: 0x7FFD5541C240
        public void ResetToDefault(){} // RVA: 0x7FFD5541C290
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFD5541C440
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFD4E341310
    }

    public class SerializationData : ValueType
    {
        public object HasEditorData;
        public object ContainsData;

        // ── Methods ──
        public void get_HasEditorData(){} // RVA: 0x7FFD5543C040
        public void get_ContainsData(){} // RVA: 0x7FFD5543C1F0
        public void Reset(){} // RVA: 0x7FFD5543C220
    }

    public class SerializationNode : ValueType
    {
    }

    public class SerializationNodeDataReader : BaseDataReader
    {
        public object IndexIsValid;
        public object Nodes;
        public object Stream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD553F92B0
        public void get_IndexIsValid(){} // RVA: 0x7FFD553FA060
        public void get_Nodes(){} // RVA: 0x7FFD553FA0C0
        public void set_Nodes(){} // RVA: 0x7FFD553FA180
        public void get_Stream(){} // RVA: 0x7FFD553FA220
        public void set_Stream(){} // RVA: 0x7FFD553FA270
        public void Dispose(){} // RVA: 0x7FFD553FA2C0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFD553FA330
        public void PeekEntry(){} // RVA: 0x7FFD553E43C0 | overloaded x2
        public void EnterArray(){} // RVA: 0x7FFD553FA6B0
        public void EnterNode(){} // RVA: 0x7FFD553FA850
        public void ExitArray(){} // RVA: 0x7FFD553FAE30
        public void ExitNode(){} // RVA: 0x7FFD553FB000
        public void ReadBoolean(){} // RVA: 0x7FFD553FB220
        public void ReadByte(){} // RVA: 0x7FFD553FB3C0
        public void ReadChar(){} // RVA: 0x7FFD553FB470
        public void ReadDecimal(){} // RVA: 0x7FFD553FB630
        public void ReadDouble(){} // RVA: 0x7FFD553FB8C0
        public void ReadExternalReference(){} // RVA: 0x7FFD553FBFA0 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7FFD553FC1A0
        public void ReadInt16(){} // RVA: 0x7FFD553FC4D0
        public void ReadInt32(){} // RVA: 0x7FFD553FC590
        public void ReadInt64(){} // RVA: 0x7FFD553FC650
        public void ReadInternalReference(){} // RVA: 0x7FFD553FC850
        public void ReadNull(){} // RVA: 0x7FFD553FCA50
        public void ReadPrimitiveArray(){} // RVA: 0x7FFD4E079F60
        public void ReadSByte(){} // RVA: 0x7FFD553FCB40
        public void ReadSingle(){} // RVA: 0x7FFD553FCBF0
        public void ReadString(){} // RVA: 0x7FFD553FCE50
        public void ReadUInt16(){} // RVA: 0x7FFD553FCFA0
        public void ReadUInt32(){} // RVA: 0x7FFD553FD060
        public void ReadUInt64(){} // RVA: 0x7FFD553FD120
        public void GetDataDump(){} // RVA: 0x7FFD553FD320
        public void ConsumeCurrentEntry(){} // RVA: 0x7FFD553FD5A0
        public void ReadToNextEntry(){} // RVA: 0x7FFD553FD610
        public void <.ctor>b__6_0(){} // RVA: 0x7FFD553F1B80
        public void <.ctor>b__6_1(){} // RVA: 0x7FFD553F1BB0
        public void <.ctor>b__6_2(){} // RVA: 0x7FFD553F1BE0
        public void <.ctor>b__6_3(){} // RVA: 0x7FFD553F1C10
        public void <.ctor>b__6_4(){} // RVA: 0x7FFD553F1C40
        public void <.ctor>b__6_5(){} // RVA: 0x7FFD553F1C70
        public void <.ctor>b__6_6(){} // RVA: 0x7FFD553F1CA0
        public void <.ctor>b__6_7(){} // RVA: 0x7FFD553F1CD0
        public void <.ctor>b__6_8(){} // RVA: 0x7FFD553F1D00
        public void <.ctor>b__6_9(){} // RVA: 0x7FFD553F1D30
        public void <.ctor>b__6_10(){} // RVA: 0x7FFD553F1D70
        public void <.ctor>b__6_11(){} // RVA: 0x7FFD553F1DA0
        public void <.ctor>b__6_12(){} // RVA: 0x7FFD553F1DD0
        public void <.ctor>b__6_13(){} // RVA: 0x7FFD553F1E00
    }

    public class SerializationNodeDataReaderWriterConfig : Object
    {
    }

    public class SerializationNodeDataWriter : BaseDataWriter
    {
        public object Nodes;
        public object Stream;

        // ── Methods ──
        public void get_Nodes(){} // RVA: 0x7FFD553FD6A0
        public void set_Nodes(){} // RVA: 0x7FFD553FD760
        public void .ctor(){} // RVA: 0x7FFD553FD800
        public void get_Stream(){} // RVA: 0x7FFD553FE510
        public void set_Stream(){} // RVA: 0x7FFD553FE560
        public void BeginArrayNode(){} // RVA: 0x7FFD553FE5B0
        public void BeginReferenceNode(){} // RVA: 0x7FFD553FE7A0
        public void BeginStructNode(){} // RVA: 0x7FFD553FEA70
        public void Dispose(){} // RVA: 0x7FFD5361F510
        public void EndArrayNode(){} // RVA: 0x7FFD553FECB0
        public void EndNode(){} // RVA: 0x7FFD553FEE30
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFD4EAB70B0
        public void WriteBoolean(){} // RVA: 0x7FFD553FEFF0
        public void WriteByte(){} // RVA: 0x7FFD553FF180
        public void WriteChar(){} // RVA: 0x7FFD553FF400
        public void WriteDecimal(){} // RVA: 0x7FFD553FF630
        public void WriteSingle(){} // RVA: 0x7FFD553FF860
        public void WriteDouble(){} // RVA: 0x7FFD553FFAA0
        public void WriteExternalReference(){} // RVA: 0x7FFD55400030 | overloaded x3
        public void WriteGuid(){} // RVA: 0x7FFD554002B0
        public void WriteInt16(){} // RVA: 0x7FFD554004A0
        public void WriteInt32(){} // RVA: 0x7FFD55400680
        public void WriteInt64(){} // RVA: 0x7FFD55400900
        public void WriteInternalReference(){} // RVA: 0x7FFD55400B80
        public void WriteNull(){} // RVA: 0x7FFD55400E00
        public void WritePrimitiveArray(){} // RVA: 0x7FFD4E090A40
        public void WriteSByte(){} // RVA: 0x7FFD55400F70
        public void WriteString(){} // RVA: 0x7FFD55401150
        public void WriteUInt16(){} // RVA: 0x7FFD554012B0
        public void WriteUInt32(){} // RVA: 0x7FFD55401530
        public void WriteUInt64(){} // RVA: 0x7FFD554017B0
        public void FlushToStream(){} // RVA: 0x7FFD4E341310
        public void GetDataDump(){} // RVA: 0x7FFD55401A30
    }

    public class SerializationPolicies : Object
    {
        public object Everything;
        public object Unity;
        public object Strict;

        // ── Methods ──
        public void TryGetByID(){} // RVA: 0x7FFD5541C450
        public void get_Everything(){} // RVA: 0x7FFD5541C6D0
        public void get_Unity(){} // RVA: 0x7FFD5541CAB0
        public void get_Strict(){} // RVA: 0x7FFD5541CFD0
        public void .cctor(){} // RVA: 0x7FFD5541D3B0
    }

    public class SerializationUtility : Object
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7FFD5541DCB0
        public void CreateReader(){} // RVA: 0x7FFD5541DEB0
        public void GetCachedWriter(){} // RVA: 0x7FFD5541E0A0
        public void GetCachedReader(){} // RVA: 0x7FFD5541E440
        public void SerializeValueWeak(){} // RVA: 0x7FFD5541F3A0 | overloaded x6
        public void SerializeValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
        public void DeserializeValueWeak(){} // RVA: 0x7FFD5541FFC0 | overloaded x6
        public void DeserializeValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
        public void CreateCopy(){} // RVA: 0x7FFD554200F0
    }

    public class SerializedBehaviour : Behaviour
    {
        public object VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.SerializationData;

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFD51359E10
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFD5543C4E0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5543C550
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD5543C5D0
        public void OnAfterDeserialize(){} // RVA: 0x7FFD4E341310
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SerializedComponent : Component
    {
        public object VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.SerializationData;

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFD51359E10
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFD5543C4E0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5543C650
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD5543C6D0
        public void OnAfterDeserialize(){} // RVA: 0x7FFD4E341310
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SerializedMonoBehaviour : MonoBehaviour
    {
        public object VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.SerializationData;

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFD5543C750
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFD5543C780
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5543C7F0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD5543C870
        public void OnAfterDeserialize(){} // RVA: 0x7FFD4E341310
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SerializedScriptableObject : ScriptableObject
    {
        public URA.woDigitYearMax<?> m_Delegates; // 0x20

        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5543C8F0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD5543C970
        public void OnAfterDeserialize(){} // RVA: 0x7FFD4E341310
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SerializedStateMachineBehaviour : StateMachineBehaviour
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5543C9F0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD5543CA70
        public void OnAfterDeserialize(){} // RVA: 0x7FFD4E341310
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SerializedUnityObject : Object
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5543CAF0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD5543CB70
        public void OnAfterDeserialize(){} // RVA: 0x7FFD4E341310
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD5543CBF0
    }

    public class Serializer : Object
    {
        // ── Methods ──
        public void FireOnSerializedType(){} // RVA: 0x7FFD4E341310
        public void GetForValue(){} // RVA: 0x7FFD55429930
        public void Get(){} // RVA: 0x7FFD55429A80 | overloaded x3
        public void ReadValueWeak(){} // RVA: 0x7FFD4E078F40
        public void WriteValueWeak(){} // RVA: 0x7FFD4E09AF60 | overloaded x2
        public void Create(){} // RVA: 0x7FFD55429DC0
        public void LogAOTError(){} // RVA: 0x7FFD5542A280
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5542A420
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7FFD51D37DE0
        public void WriteValueWeak(){} // RVA: 0x7FFD51D37E90
        public void ReadValue(){} // RVA: 0x7FFD4E27B230
        public void WriteValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD51D38150
    }

    public class SingleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD5542B920
        public void WriteValue(){} // RVA: 0x7FFD5542C6D0
        public void .ctor(){} // RVA: 0x7FFD5542C740
    }

    public class StackFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E2ADC40
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
    }

    public class StringSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFD5542C7B0
        public void WriteValue(){} // RVA: 0x7FFD5542D580
        public void .ctor(){} // RVA: 0x7FFD5542D610
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void GetUninitializedObject(){} // RVA: 0x7FFD4E078E90
        public void DeserializeImplementation(){} // RVA: 0x7FFD4E099B30
        public void SerializeImplementation(){} // RVA: 0x7FFD4E099B30
    }

}