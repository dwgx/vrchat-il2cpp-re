// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 68
// Methods: 483

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class SByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF65DA80
        public void WriteValue(){} // RVA: 0x7AF65E780
        public void .ctor(){} // RVA: 0x7AF65E7F0
    }

    public class SelfFormatterFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class SelfFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x7AF63CA50
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void GetUninitializedObject(){} // RVA: 0x7A8051B10
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
        public void ReadSerializationInfo(){} // RVA: 0x7A7E00B20
        public void WriteSerializationInfo(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ABDF7170
        public void GetUninitializedObject(){} // RVA: 0x7A82D1450
        public void DeserializeImplementation(){} // RVA: 0x7ABDF7BE0
        public void SerializeImplementation(){} // RVA: 0x7ABDF8080
        public void ReadSerializationInfo(){} // RVA: 0x7ABDF83A0
        public void WriteSerializationInfo(){} // RVA: 0x7ABDF8AD0
        public void .ctor(){} // RVA: 0x7ABDE5DB0
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ABDF7170
        public void GetUninitializedObject(){} // RVA: 0x7A82D1450
        public void DeserializeImplementation(){} // RVA: 0x7ABDF7BE0
        public void SerializeImplementation(){} // RVA: 0x7ABDF8080
        public void ReadSerializationInfo(){} // RVA: 0x7ABDF83A0
        public void WriteSerializationInfo(){} // RVA: 0x7ABDF8AD0
        public void .ctor(){} // RVA: 0x7ABDE5DB0
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ABDF7170
        public void GetUninitializedObject(){} // RVA: 0x7A82D1450
        public void DeserializeImplementation(){} // RVA: 0x7ABDF7BE0
        public void SerializeImplementation(){} // RVA: 0x7ABDF8080
        public void ReadSerializationInfo(){} // RVA: 0x7ABDF83A0
        public void WriteSerializationInfo(){} // RVA: 0x7ABDF8AD0
        public void .ctor(){} // RVA: 0x7ABDE5DB0
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ABDF7170
        public void GetUninitializedObject(){} // RVA: 0x7A82D1450
        public void DeserializeImplementation(){} // RVA: 0x7ABDF7BE0
        public void SerializeImplementation(){} // RVA: 0x7ABDF8080
        public void ReadSerializationInfo(){} // RVA: 0x7ABDF83A0
        public void WriteSerializationInfo(){} // RVA: 0x7ABDF8AD0
        public void .ctor(){} // RVA: 0x7ABDE5DB0
    }

    public class SerializationAbortException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF64F760
    }

    public class SerializationConfig : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF64F7D0
        public void get_SerializationPolicy(){} // RVA: 0x7AF64F860
        public void set_SerializationPolicy(){} // RVA: 0x7AF64FA20
        public void get_DebugContext(){} // RVA: 0x7AF64FB80
        public void set_DebugContext(){} // RVA: 0x7AF64FDD0
        public void ResetToDefault(){} // RVA: 0x7AF64FF30
        public void LOCK(){} // RVA: 0x7B41ACED8
    }

    public class SerializationContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF650970
        public void get_Binder(){} // RVA: 0x7AF650C10
        public void set_Binder(){} // RVA: 0x7A8296DE0
        public void get_StreamingContext(){} // RVA: 0x7A9D01C90
        public void get_FormatterConverter(){} // RVA: 0x7A83F69F0
        public void get_IndexReferenceResolver(){} // RVA: 0x7A8154D80
        public void set_IndexReferenceResolver(){} // RVA: 0x7A80FF440
        public void get_StringReferenceResolver(){} // RVA: 0x7A8152D80
        public void set_StringReferenceResolver(){} // RVA: 0x7A8152D90
        public void get_GuidReferenceResolver(){} // RVA: 0x7A8178B90
        public void set_GuidReferenceResolver(){} // RVA: 0x7A8230620
        public void get_Config(){} // RVA: 0x7AF650CD0
        public void set_Config(){} // RVA: 0x7A80D8E20
        public void TryGetInternalReferenceId(){} // RVA: 0x7AF650D80
        public void TryRegisterInternalReference(){} // RVA: 0x7AF650DF0
        public void TryRegisterExternalReference(){} // RVA: 0x7AF6510C0
        public void ResetInternalReferences(){} // RVA: 0x7AF651290
        public void ResetToDefault(){} // RVA: 0x7AF6512E0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x7AF651490
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0x7A80D7310
    }

    public class SerializationData : ValueType
    {
        // ── Methods ──
        public void get_HasEditorData(){} // RVA: 0x7A7F32E10
        public void get_ContainsData(){} // RVA: 0x7A7F32FA0
        public void Reset(){} // RVA: 0x7A7F32FD0
    }

    public class SerializationNodeDataReader : BaseDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF62E720
        public void get_IndexIsValid(){} // RVA: 0x7AF62F4D0
        public void get_Nodes(){} // RVA: 0x7AF62F530
        public void set_Nodes(){} // RVA: 0x7AF62F5F0
        public void get_Stream(){} // RVA: 0x7AF62F690
        public void set_Stream(){} // RVA: 0x7AF62F6E0
        public void Dispose(){} // RVA: 0x7AF62F730
        public void PrepareNewSerializationSession(){} // RVA: 0x7AF62F7A0
        public void PeekEntry(){} // RVA: 0x7AF619700
        public void EnterArray(){} // RVA: 0x7AF62FB20
        public void EnterNode(){} // RVA: 0x7AF62FCC0
        public void ExitArray(){} // RVA: 0x7AF630290
        public void ExitNode(){} // RVA: 0x7AF630470
        public void ReadBoolean(){} // RVA: 0x7AF6306A0
        public void ReadByte(){} // RVA: 0x7AF630840
        public void ReadChar(){} // RVA: 0x7AF6308F0
        public void ReadDecimal(){} // RVA: 0x7AF630AB0
        public void ReadDouble(){} // RVA: 0x7AF630D40
        public void ReadExternalReference(){} // RVA: 0x7AF631420
        public void ReadGuid(){} // RVA: 0x7AF631620
        public void ReadInt16(){} // RVA: 0x7AF631950
        public void ReadInt32(){} // RVA: 0x7AF631A10
        public void ReadInt64(){} // RVA: 0x7AF631AD0
        public void ReadInternalReference(){} // RVA: 0x7AF631CD0
        public void ReadNull(){} // RVA: 0x7AF631ED0
        public void ReadPrimitiveArray(){} // RVA: 0x7A7E019D0
        public void ReadSByte(){} // RVA: 0x7AF631FC0
        public void ReadSingle(){} // RVA: 0x7AF632070
        public void ReadString(){} // RVA: 0x7AF6322D0
        public void ReadUInt16(){} // RVA: 0x7AF632420
        public void ReadUInt32(){} // RVA: 0x7AF6324E0
        public void ReadUInt64(){} // RVA: 0x7AF6325A0
        public void GetDataDump(){} // RVA: 0x7AF6327A0
        public void ConsumeCurrentEntry(){} // RVA: 0x7AF632A30
        public void ReadToNextEntry(){} // RVA: 0x7AF632AA0
        public void <.ctor>b__6_0(){} // RVA: 0x7AF626F40
        public void <.ctor>b__6_1(){} // RVA: 0x7AF626F70
        public void <.ctor>b__6_2(){} // RVA: 0x7AF626FA0
        public void <.ctor>b__6_3(){} // RVA: 0x7AF626FD0
        public void <.ctor>b__6_4(){} // RVA: 0x7AF627000
        public void <.ctor>b__6_5(){} // RVA: 0x7AF627030
        public void <.ctor>b__6_6(){} // RVA: 0x7AF627060
        public void <.ctor>b__6_7(){} // RVA: 0x7AF627090
        public void <.ctor>b__6_8(){} // RVA: 0x7AF6270C0
        public void <.ctor>b__6_9(){} // RVA: 0x7AF6270F0
        public void <.ctor>b__6_10(){} // RVA: 0x7AF627130
        public void <.ctor>b__6_11(){} // RVA: 0x7AF627160
        public void <.ctor>b__6_12(){} // RVA: 0x7AF627190
        public void <.ctor>b__6_13(){} // RVA: 0x7AF6271C0
    }

    public class SerializationNodeDataWriter : BaseDataWriter
    {
        // ── Methods ──
        public void get_Nodes(){} // RVA: 0x7AF632B30
        public void set_Nodes(){} // RVA: 0x7AF632BF0
        public void .ctor(){} // RVA: 0x7AF632C90
        public void get_Stream(){} // RVA: 0x7AF6339A0
        public void set_Stream(){} // RVA: 0x7AF6339F0
        public void BeginArrayNode(){} // RVA: 0x7AF633A40
        public void BeginReferenceNode(){} // RVA: 0x7AF633C40
        public void BeginStructNode(){} // RVA: 0x7AF633F20
        public void Dispose(){} // RVA: 0x7AD854C70
        public void EndArrayNode(){} // RVA: 0x7AF634170
        public void EndNode(){} // RVA: 0x7AF634300
        public void PrepareNewSerializationSession(){} // RVA: 0x7A8810990
        public void WriteBoolean(){} // RVA: 0x7AF6344D0
        public void WriteByte(){} // RVA: 0x7AF634660
        public void WriteChar(){} // RVA: 0x7AF6348F0
        public void WriteDecimal(){} // RVA: 0x7AF634B10
        public void WriteSingle(){} // RVA: 0x7AF634D50
        public void WriteDouble(){} // RVA: 0x7AF634FA0
        public void WriteExternalReference(){} // RVA: 0x7AF635540
        public void WriteGuid(){} // RVA: 0x7AF6357D0
        public void WriteInt16(){} // RVA: 0x7AF6359C0
        public void WriteInt32(){} // RVA: 0x7AF635BB0
        public void WriteInt64(){} // RVA: 0x7AF635E40
        public void WriteInternalReference(){} // RVA: 0x7AF6360D0
        public void WriteNull(){} // RVA: 0x7AF636360
        public void WritePrimitiveArray(){} // RVA: 0x7A7E18800
        public void WriteSByte(){} // RVA: 0x7AF6364E0
        public void WriteString(){} // RVA: 0x7AF6366D0
        public void WriteUInt16(){} // RVA: 0x7AF636830
        public void WriteUInt32(){} // RVA: 0x7AF636AC0
        public void WriteUInt64(){} // RVA: 0x7AF636D50
        public void FlushToStream(){} // RVA: 0x7A80D7310
        public void GetDataDump(){} // RVA: 0x7AF636FE0
    }

    public class SerializationNode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1330
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2C90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250480
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SerializationPolicies : Object
    {
        // ── Methods ──
        public void TryGetByID(){} // RVA: 0x7AF6514A0
        public void get_Everything(){} // RVA: 0x7AF651720
        public void get_Unity(){} // RVA: 0x7AF651AC0
        public void get_Strict(){} // RVA: 0x7AF651FA0
        public void .cctor(){} // RVA: 0x7AF652340
    }

    public class SerializationUtility : Object
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x7AF652C60
        public void CreateReader(){} // RVA: 0x7AF652E60
        public void GetCachedWriter(){} // RVA: 0x7AF653050
        public void GetCachedReader(){} // RVA: 0x7AF6533F0
        public void SerializeValueWeak(){} // RVA: 0x7AF654360
        public void SerializeValue(){} // RVA: 0x7AA587700
        public void DeserializeValueWeak(){} // RVA: 0x7AF654F80
        public void DeserializeValue(){} // RVA: 0x7AA585CA0
        public void CreateCopy(){} // RVA: 0x7AF6550C0
    }

    public class SerializedBehaviour : Behaviour
    {
        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7AB3FE2A0
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7AF671410
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AF671480
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AF6714F0
        public void OnAfterDeserialize(){} // RVA: 0x7A80D7310
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class SerializedComponent : Component
    {
        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7AB3FE2A0
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7AF671410
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AF671570
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AF6715E0
        public void OnAfterDeserialize(){} // RVA: 0x7A80D7310
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class SerializedMonoBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x7ACD34420
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x7AF671660
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AF6716D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AF671740
        public void OnAfterDeserialize(){} // RVA: 0x7A80D7310
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class SerializedScriptableObject : ScriptableObject
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AF6717C0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AF671830
        public void OnAfterDeserialize(){} // RVA: 0x7A80D7310
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class SerializedStateMachineBehaviour : StateMachineBehaviour
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AF6718B0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AF671920
        public void OnAfterDeserialize(){} // RVA: 0x7A80D7310
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class SerializedUnityObject : Object
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AF6719A0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AF671A10
        public void OnAfterDeserialize(){} // RVA: 0x7A80D7310
        public void OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7AF671A90
    }

    public class Serializer : Object
    {
        // ── Methods ──
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void GetForValue(){} // RVA: 0x7AF65E860
        public void Get(){} // RVA: 0x7AA589DA0
        public void ReadValueWeak(){} // RVA: 0x7A7E00B20
        public void WriteValueWeak(){} // RVA: 0x7A7E1DDC0
        public void Create(){} // RVA: 0x7AF65ECC0
        public void LogAOTError(){} // RVA: 0x7AF65F180
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AF65F320
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7A7E00B20
        public void WriteValueWeak(){} // RVA: 0x7A7E1DDC0
        public void ReadValue(){} // RVA: 0x7A8051B10
        public void WriteValue(){} // RVA: 0x7A8051B10
        public void FireOnSerializedType(){} // RVA: 0x7A7E187D0
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE028E0
        public void WriteValueWeak(){} // RVA: 0x7ABE02920
        public void ReadValue(){} // RVA: 0x7A7E019D0
        public void WriteValue(){} // RVA: 0x7A7E1E800
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE02A00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE028E0
        public void WriteValueWeak(){} // RVA: 0x7ABE02920
        public void ReadValue(){} // RVA: 0x7A7E019D0
        public void WriteValue(){} // RVA: 0x7A7E1E800
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE02AA0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE02AF0
        public void WriteValueWeak(){} // RVA: 0x7ABE02B30
        public void ReadValue(){} // RVA: 0x7A7E00A40
        public void WriteValue(){} // RVA: 0x7A7E1F700
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE02C10
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE05DE0
        public void WriteValueWeak(){} // RVA: 0x7ABE05E90
        public void ReadValue(){} // RVA: 0x7A80804D0
        public void WriteValue(){} // RVA: 0x7A8051B10
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE06150
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE02060
        public void WriteValueWeak(){} // RVA: 0x7ABE020B0
        public void ReadValue(){} // RVA: 0x7A7E00560
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE03890
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE03A90
        public void WriteValueWeak(){} // RVA: 0x7ABE03AE0
        public void ReadValue(){} // RVA: 0x7A7E06AF0
        public void WriteValue(){} // RVA: 0x7A7E1F330
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE03BC0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE05DE0
        public void WriteValueWeak(){} // RVA: 0x7ABE05E90
        public void ReadValue(){} // RVA: 0x7A80804D0
        public void WriteValue(){} // RVA: 0x7A8051B10
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE06150
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE02060
        public void WriteValueWeak(){} // RVA: 0x7ABE020B0
        public void ReadValue(){} // RVA: 0x7A7E00560
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE03F20
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE02AF0
        public void WriteValueWeak(){} // RVA: 0x7ABE02B30
        public void ReadValue(){} // RVA: 0x7A7E00A40
        public void WriteValue(){} // RVA: 0x7A7E1F700
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04560
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE02D00
        public void WriteValueWeak(){} // RVA: 0x7ABE02D40
        public void ReadValue(){} // RVA: 0x7A7E01630
        public void WriteValue(){} // RVA: 0x7A7E18AE0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE045B0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE023F0
        public void WriteValueWeak(){} // RVA: 0x7ABE02430
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1E190
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04600
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE023F0
        public void WriteValueWeak(){} // RVA: 0x7ABE02430
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1E190
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04650
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE028E0
        public void WriteValueWeak(){} // RVA: 0x7ABE02920
        public void ReadValue(){} // RVA: 0x7A7E019D0
        public void WriteValue(){} // RVA: 0x7A7E1E800
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE05360
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE053B0
        public void WriteValueWeak(){} // RVA: 0x7ABE05400
        public void ReadValue(){} // RVA: 0x7A7E15640
        public void WriteValue(){} // RVA: 0x7A7E25710
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE054B0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE02AF0
        public void WriteValueWeak(){} // RVA: 0x7ABE02B30
        public void ReadValue(){} // RVA: 0x7A7E00A40
        public void WriteValue(){} // RVA: 0x7A7E1F700
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE05AE0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE02D00
        public void WriteValueWeak(){} // RVA: 0x7ABE02D40
        public void ReadValue(){} // RVA: 0x7A7E01630
        public void WriteValue(){} // RVA: 0x7A7E18AE0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE05B30
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE023F0
        public void WriteValueWeak(){} // RVA: 0x7ABE02430
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1E190
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE05B80
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE023F0
        public void WriteValueWeak(){} // RVA: 0x7ABE02430
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1E190
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE05BD0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7A7E00560
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void ReadValueWeak(){} // RVA: 0x7ABE02240
        public void WriteValueWeak(){} // RVA: 0x7ABE022A0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE023A0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7ABE024E0
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7A7E00B20
        public void WriteValue(){} // RVA: 0x7A7E1DDC0
        public void ReadValueWeak(){} // RVA: 0x7ABE04E20
        public void WriteValueWeak(){} // RVA: 0x7ABE04E40
        public void FireOnSerializedType(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7ABE04F00
    }

    public class SingleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF660820
        public void WriteValue(){} // RVA: 0x7AF661510
        public void .ctor(){} // RVA: 0x7AF661580
    }

    public class StackFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void .ctor(){} // RVA: 0x7A7E18770
        public void GetUninitializedObject(){} // RVA: 0x7A8051B10
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
    }

    public class StringSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x7AF6615F0
        public void WriteValue(){} // RVA: 0x7AF662390
        public void .ctor(){} // RVA: 0x7AF662420
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void .ctor(){} // RVA: 0x7A7E18770
        public void GetUninitializedObject(){} // RVA: 0x7A7E00680
        public void DeserializeImplementation(){} // RVA: 0x7A7E18890
        public void SerializeImplementation(){} // RVA: 0x7A7E18890
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ABE93750
        public void .ctor(){} // RVA: 0x7AAC30FB0
        public void GetUninitializedObject(){} // RVA: 0x7ABE88A60
        public void DeserializeImplementation(){} // RVA: 0x7ABE938E0
        public void SerializeImplementation(){} // RVA: 0x7ABE939E0
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AAC30FB0
        public void .cctor(){} // RVA: 0x7ABE8F180
        public void GetUninitializedObject(){} // RVA: 0x7ABE88A60
        public void DeserializeImplementation(){} // RVA: 0x7ABE8AC50
        public void SerializeImplementation(){} // RVA: 0x7ABE8F310
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7ABE93750
        public void .ctor(){} // RVA: 0x7AAC30FB0
        public void GetUninitializedObject(){} // RVA: 0x7ABE88A60
        public void DeserializeImplementation(){} // RVA: 0x7ABE938E0
        public void SerializeImplementation(){} // RVA: 0x7ABE939E0
    }

}