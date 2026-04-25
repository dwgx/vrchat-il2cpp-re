// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 26
// Methods: 243

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class SByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA008B80
        public void WriteValue(){} // RVA: 0x7FFACA009850
        public void .ctor(){} // RVA: 0x7FFACA0098C0
    }

    public class SelfFormatterFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SelfFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7FFAC9FE7470
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        public System.Func`3<System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext,U> ISerializableConstructor;
        public VRC.Udon.Serialization.OdinSerializer.ReflectionFormatter`1<U> ReflectionFormatter;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void ReadSerializationInfo(){} // RVA: 0x7FFAC2C58F40
        public void WriteSerializationInfo(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SerializationAbortException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FFA5B0 | overloaded x2
    }

    public class SerializationConfig : Object
    {
        public object SerializationPolicy; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy DebugContext; // 0x18
        public VRC.Udon.Serialization.OdinSerializer.DebugContext debugContext; // 0x20
        public bool AllowDeserializeInvalidData; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FFA620
        public void get_SerializationPolicy(){} // RVA: 0x7FFAC9FFA6B0
        public void set_SerializationPolicy(){} // RVA: 0x7FFAC9FFA8A0
        public void get_DebugContext(){} // RVA: 0x7FFAC9FFAA30
        public void set_DebugContext(){} // RVA: 0x7FFAC9FFACB0
        public void ResetToDefault(){} // RVA: 0x7FFAC9FFAE40
    }

    public class SerializationContext : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationConfig Binder; // 0x10
        public System.Collections.Generic.Dictionary`2<object,int> StreamingContext; // 0x18
        public System.Runtime.Serialization.StreamingContext FormatterConverter; // 0x20
        public System.Runtime.Serialization.IFormatterConverter IndexReferenceResolver; // 0x30
        public VRC.Udon.Serialization.OdinSerializer.TwoWaySerializationBinder StringReferenceResolver; // 0x38
        public VRC.Udon.Serialization.OdinSerializer.IExternalIndexReferenceResolver GuidReferenceResolver; // 0x40
        public VRC.Udon.Serialization.OdinSerializer.IExternalStringReferenceResolver Config; // 0x48
        public VRC.Udon.Serialization.OdinSerializer.IExternalGuidReferenceResolver <GuidReferenceResolver>k__BackingField; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FFB920 | overloaded x4
        public void get_Binder(){} // RVA: 0x7FFAC9FFBBC0
        public void set_Binder(){} // RVA: 0x7FFAC31D0C20
        public void get_StreamingContext(){} // RVA: 0x7FFAC4A19630
        public void get_FormatterConverter(){} // RVA: 0x7FFAC31D95E0
        public void get_IndexReferenceResolver(){} // RVA: 0x7FFAC2F9E740
        public void set_IndexReferenceResolver(){} // RVA: 0x7FFAC2F49200
        public void get_StringReferenceResolver(){} // RVA: 0x7FFAC2F9C730
        public void set_StringReferenceResolver(){} // RVA: 0x7FFAC2F9C740
        public void get_GuidReferenceResolver(){} // RVA: 0x7FFAC2FC20E0
        public void set_GuidReferenceResolver(){} // RVA: 0x7FFAC30794D0
        public void get_Config(){} // RVA: 0x7FFAC9FFBC80
        public void set_Config(){} // RVA: 0x7FFAC2F22E30
        public void TryGetInternalReferenceId(){} // RVA: 0x7FFAC9FFBD30
        public void TryRegisterInternalReference(){} // RVA: 0x7FFAC9FFBDA0
        public void TryRegisterExternalReference(){} // RVA: 0x7FFAC9FFC070 | overloaded x3
        public void ResetInternalReferences(){} // RVA: 0x7FFAC9FFC240
        public void ResetToDefault(){} // RVA: 0x7FFAC9FFC290
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7FFAC9FFC440
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7FFAC2F21310
    }

    public class SerializationData : ValueType
    {
        public string HasEditorData;
        public string ContainsData;
        public string PrefabFieldName;
        public 0x6B223B70 SerializedFormat; // 0x10
        public byte[] SerializedBytes; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.Object> ReferencedUnityObjects; // 0x20
        public string SerializedBytesString; // 0x28
        public UnityEngine.Object Prefab; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.Object> PrefabModificationsReferencedUnityObjects; // 0x38
        public System.Collections.Generic.List`1<string> PrefabModifications; // 0x40
        public System.Collections.Generic.List`1<VRC.Udon.Serialization.OdinSerializer.SerializationNode> SerializationNodes; // 0x48

        // ── Methods ──
        public void get_HasEditorData(){} // RVA: 0x7FFACA01C040
        public void get_ContainsData(){} // RVA: 0x7FFACA01C1F0
        public void Reset(){} // RVA: 0x7FFACA01C220
    }

    public class SerializationNode : ValueType
    {
        public string Name; // 0x10
        public 0x6B223DD8 Entry; // 0x18
        public string Data; // 0x20
    }

    public class SerializationNodeDataReader : BaseDataReader
    {
        public string IndexIsValid; // 0x30
        public System.Nullable`1<0x6B223DD8> Nodes; // 0x38
        public string Stream; // 0x40
        public int currentIndex; // 0x48
        public System.Collections.Generic.List`1<VRC.Udon.Serialization.OdinSerializer.SerializationNode> nodes; // 0x50
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> primitiveTypeReaders; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9FD92B0
        public void get_IndexIsValid(){} // RVA: 0x7FFAC9FDA060
        public void get_Nodes(){} // RVA: 0x7FFAC9FDA0C0
        public void set_Nodes(){} // RVA: 0x7FFAC9FDA180
        public void get_Stream(){} // RVA: 0x7FFAC9FDA220
        public void set_Stream(){} // RVA: 0x7FFAC9FDA270
        public void Dispose(){} // RVA: 0x7FFAC9FDA2C0
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC9FDA330
        public void PeekEntry(){} // RVA: 0x7FFAC9FC43C0 | overloaded x2
        public void EnterArray(){} // RVA: 0x7FFAC9FDA6B0
        public void EnterNode(){} // RVA: 0x7FFAC9FDA850
        public void ExitArray(){} // RVA: 0x7FFAC9FDAE30
        public void ExitNode(){} // RVA: 0x7FFAC9FDB000
        public void ReadBoolean(){} // RVA: 0x7FFAC9FDB220
        public void ReadByte(){} // RVA: 0x7FFAC9FDB3C0
        public void ReadChar(){} // RVA: 0x7FFAC9FDB470
        public void ReadDecimal(){} // RVA: 0x7FFAC9FDB630
        public void ReadDouble(){} // RVA: 0x7FFAC9FDB8C0
        public void ReadExternalReference(){} // RVA: 0x7FFAC9FDBFA0 | overloaded x3
        public void ReadGuid(){} // RVA: 0x7FFAC9FDC1A0
        public void ReadInt16(){} // RVA: 0x7FFAC9FDC4D0
        public void ReadInt32(){} // RVA: 0x7FFAC9FDC590
        public void ReadInt64(){} // RVA: 0x7FFAC9FDC650
        public void ReadInternalReference(){} // RVA: 0x7FFAC9FDC850
        public void ReadNull(){} // RVA: 0x7FFAC9FDCA50
        public void ReadPrimitiveArray(){} // RVA: 0x7FFAC2C59F60
        public void ReadSByte(){} // RVA: 0x7FFAC9FDCB40
        public void ReadSingle(){} // RVA: 0x7FFAC9FDCBF0
        public void ReadString(){} // RVA: 0x7FFAC9FDCE50
        public void ReadUInt16(){} // RVA: 0x7FFAC9FDCFA0
        public void ReadUInt32(){} // RVA: 0x7FFAC9FDD060
        public void ReadUInt64(){} // RVA: 0x7FFAC9FDD120
        public void GetDataDump(){} // RVA: 0x7FFAC9FDD320
        public void ConsumeCurrentEntry(){} // RVA: 0x7FFAC9FDD5A0
        public void ReadToNextEntry(){} // RVA: 0x7FFAC9FDD610
        public void <.ctor>b__6_0(){} // RVA: 0x7FFAC9FD1B80
        public void <.ctor>b__6_1(){} // RVA: 0x7FFAC9FD1BB0
        public void <.ctor>b__6_2(){} // RVA: 0x7FFAC9FD1BE0
        public void <.ctor>b__6_3(){} // RVA: 0x7FFAC9FD1C10
        public void <.ctor>b__6_4(){} // RVA: 0x7FFAC9FD1C40
        public void <.ctor>b__6_5(){} // RVA: 0x7FFAC9FD1C70
        public void <.ctor>b__6_6(){} // RVA: 0x7FFAC9FD1CA0
        public void <.ctor>b__6_7(){} // RVA: 0x7FFAC9FD1CD0
        public void <.ctor>b__6_8(){} // RVA: 0x7FFAC9FD1D00
        public void <.ctor>b__6_9(){} // RVA: 0x7FFAC9FD1D30
        public void <.ctor>b__6_10(){} // RVA: 0x7FFAC9FD1D70
        public void <.ctor>b__6_11(){} // RVA: 0x7FFAC9FD1DA0
        public void <.ctor>b__6_12(){} // RVA: 0x7FFAC9FD1DD0
        public void <.ctor>b__6_13(){} // RVA: 0x7FFAC9FD1E00
    }

    public class SerializationNodeDataReaderWriterConfig : Object
    {
        public string NodeIdSeparator;
    }

    public class SerializationNodeDataWriter : BaseDataWriter
    {
        public System.Collections.Generic.List`1<VRC.Udon.Serialization.OdinSerializer.SerializationNode> Nodes; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> Stream; // 0x38

        // ── Methods ──
        public void get_Nodes(){} // RVA: 0x7FFAC9FDD6A0
        public void set_Nodes(){} // RVA: 0x7FFAC9FDD760
        public void .ctor(){} // RVA: 0x7FFAC9FDD800
        public void get_Stream(){} // RVA: 0x7FFAC9FDE510
        public void set_Stream(){} // RVA: 0x7FFAC9FDE560
        public void BeginArrayNode(){} // RVA: 0x7FFAC9FDE5B0
        public void BeginReferenceNode(){} // RVA: 0x7FFAC9FDE7A0
        public void BeginStructNode(){} // RVA: 0x7FFAC9FDEA70
        public void Dispose(){} // RVA: 0x7FFAC81FF510
        public void EndArrayNode(){} // RVA: 0x7FFAC9FDECB0
        public void EndNode(){} // RVA: 0x7FFAC9FDEE30
        public void PrepareNewSerializationSession(){} // RVA: 0x7FFAC36970B0
        public void WriteBoolean(){} // RVA: 0x7FFAC9FDEFF0
        public void WriteByte(){} // RVA: 0x7FFAC9FDF180
        public void WriteChar(){} // RVA: 0x7FFAC9FDF400
        public void WriteDecimal(){} // RVA: 0x7FFAC9FDF630
        public void WriteSingle(){} // RVA: 0x7FFAC9FDF860
        public void WriteDouble(){} // RVA: 0x7FFAC9FDFAA0
        public void WriteExternalReference(){} // RVA: 0x7FFAC9FE0030 | overloaded x3
        public void WriteGuid(){} // RVA: 0x7FFAC9FE02B0
        public void WriteInt16(){} // RVA: 0x7FFAC9FE04A0
        public void WriteInt32(){} // RVA: 0x7FFAC9FE0680
        public void WriteInt64(){} // RVA: 0x7FFAC9FE0900
        public void WriteInternalReference(){} // RVA: 0x7FFAC9FE0B80
        public void WriteNull(){} // RVA: 0x7FFAC9FE0E00
        public void WritePrimitiveArray(){} // RVA: 0x7FFAC2C70A40
        public void WriteSByte(){} // RVA: 0x7FFAC9FE0F70
        public void WriteString(){} // RVA: 0x7FFAC9FE1150
        public void WriteUInt16(){} // RVA: 0x7FFAC9FE12B0
        public void WriteUInt32(){} // RVA: 0x7FFAC9FE1530
        public void WriteUInt64(){} // RVA: 0x7FFAC9FE17B0
        public void FlushToStream(){} // RVA: 0x7FFAC2F21310
        public void GetDataDump(){} // RVA: 0x7FFAC9FE1A30
    }

    public class SerializationPolicies : Object
    {
        public object Everything;
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy Unity; // 0x8
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy Strict; // 0x10
        public VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy strictPolicy; // 0x18

        // ── Methods ──
        public void TryGetByID(){} // RVA: 0x7FFAC9FFC450
        public void get_Everything(){} // RVA: 0x7FFAC9FFC6D0
        public void get_Unity(){} // RVA: 0x7FFAC9FFCAB0
        public void get_Strict(){} // RVA: 0x7FFAC9FFCFD0
        public void .cctor(){} // RVA: 0x7FFAC9FFD3B0
    }

    public class SerializationUtility : Object
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7FFAC9FFDCB0
        public void CreateReader(){} // RVA: 0x7FFAC9FFDEB0
        public void GetCachedWriter(){} // RVA: 0x7FFAC9FFE0A0
        public void GetCachedReader(){} // RVA: 0x7FFAC9FFE440
        public void SerializeValueWeak(){} // RVA: 0x7FFAC9FFF3A0 | overloaded x6
        public void SerializeValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x6
        public void DeserializeValueWeak(){} // RVA: 0x7FFAC9FFFFC0 | overloaded x6
        public void DeserializeValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x6
        public void CreateCopy(){} // RVA: 0x7FFACA0000F0
    }

    public class SerializedBehaviour : Behaviour
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.SerializationData; // 0x18

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFAC5F39E10
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFACA01C4E0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFACA01C550
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFACA01C5D0
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SerializedComponent : Component
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.SerializationData; // 0x18

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFAC5F39E10
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFACA01C4E0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFACA01C650
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFACA01C6D0
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SerializedMonoBehaviour : MonoBehaviour
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.SerializationData; // 0x20

        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7FFACA01C750
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7FFACA01C780
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFACA01C7F0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFACA01C870
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SerializedScriptableObject : ScriptableObject
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x18

        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFACA01C8F0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFACA01C970
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SerializedStateMachineBehaviour : StateMachineBehaviour
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x18

        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFACA01C9F0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFACA01CA70
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SerializedUnityObject : Object
    {
        public VRC.Udon.Serialization.OdinSerializer.SerializationData serializationData; // 0x18

        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFACA01CAF0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFACA01CB70
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFACA01CBF0
    }

    public class Serializer : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,System.Type> PrimitiveReaderWriterTypes;
        public object LOCK; // 0x8
        public System.Collections.Generic.Dictionary`2<System.Type,VRC.Udon.Serialization.OdinSerializer.Serializer> Weak_ReaderWriterCache; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,VRC.Udon.Serialization.OdinSerializer.Serializer> Strong_ReaderWriterCache; // 0x18

        // ── Methods ──
        public void FireOnSerializedType(){} // RVA: 0x7FFAC2F21310
        public void GetForValue(){} // RVA: 0x7FFACA009930
        public void Get(){} // RVA: 0x7FFACA009A80 | overloaded x3
        public void ReadValueWeak(){} // RVA: 0x7FFAC2C58F40
        public void WriteValueWeak(){} // RVA: 0x7FFAC2C7AF60 | overloaded x2
        public void Create(){} // RVA: 0x7FFACA009DC0
        public void LogAOTError(){} // RVA: 0x7FFACA00A280
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACA00A420
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7FFAC6917DE0
        public void WriteValueWeak(){} // RVA: 0x7FFAC6917E90
        public void ReadValue(){} // RVA: 0x7FFAC2E5B230
        public void WriteValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void FireOnSerializedType(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC6918150
    }

    public class SingleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA00B920
        public void WriteValue(){} // RVA: 0x7FFACA00C6D0
        public void .ctor(){} // RVA: 0x7FFACA00C740
    }

    public class StackFormatter`2 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> TSerializer;
        public bool IsPlainStack;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

    public class StringSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7FFACA00C7B0
        public void WriteValue(){} // RVA: 0x7FFACA00D580
        public void .ctor(){} // RVA: 0x7FFACA00D610
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        public VRC.Udon.Serialization.OdinSerializer.Serializer`1<T> TSerializer;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void GetUninitializedObject(){} // RVA: 0x7FFAC2C58E90
        public void DeserializeImplementation(){} // RVA: 0x7FFAC2C79B30
        public void SerializeImplementation(){} // RVA: 0x7FFAC2C79B30
    }

}