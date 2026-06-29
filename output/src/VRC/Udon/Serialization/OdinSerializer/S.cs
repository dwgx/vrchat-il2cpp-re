// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.Serialization.OdinSerializer
// Classes: 44
// Methods: 337

namespace VRC.Udon.Serialization.OdinSerializer
{
    public class SByteSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84BAC40
        public void WriteValue(){} // RVA: 0x84BB8B0
        public void .ctor(){} // RVA: 0x84BB920
    }

    public class SelfFormatterFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    public class SelfFormatterLocator : Object
    {
        // ── Methods ──
        public void TryGetFormatter(){} // RVA: 0x849A580
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SerializableFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
        public void ReadSerializationInfo(){} // RVA: 0x87C540
        public void WriteSerializationInfo(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0x894290
    }

    public class SerializationAbortException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x84ACE70
    }

    public class SerializationConfig : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x84ACEE0
        public void get_SerializationPolicy(){} // RVA: 0x84ACF70
        public void set_SerializationPolicy(){} // RVA: 0x84AD130
        public void get_DebugContext(){} // RVA: 0x84AD290
        public void set_DebugContext(){} // RVA: 0x84AD4E0
        public void ResetToDefault(){} // RVA: 0x84AD640
    }

    public class SerializationContext : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x84AE080
        public void get_Binder(){} // RVA: 0x84AE320
        public void set_Binder(){} // RVA: 0xD09D70
        public void get_StreamingContext(){} // RVA: 0x16CD810
        public void get_FormatterConverter(){} // RVA: 0xD33E60
        public void get_IndexReferenceResolver(){} // RVA: 0xBC1B30
        public void set_IndexReferenceResolver(){} // RVA: 0xB6A8C0
        public void get_StringReferenceResolver(){} // RVA: 0xBBF8F0
        public void set_StringReferenceResolver(){} // RVA: 0xBBF900
        public void get_GuidReferenceResolver(){} // RVA: 0xBE58B0
        public void set_GuidReferenceResolver(){} // RVA: 0xCA4DF0
        public void get_Config(){} // RVA: 0x84AE3E0
        public void set_Config(){} // RVA: 0xB44D60
        public void TryGetInternalReferenceId(){} // RVA: 0x84AE490
        public void TryRegisterInternalReference(){} // RVA: 0x84AE500
        public void TryRegisterExternalReference(){} // RVA: 0x84AE7D0
        public void ResetInternalReferences(){} // RVA: 0x84AE9A0
        public void ResetToDefault(){} // RVA: 0x84AE9F0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnFreed(){} // RVA: 0x84AEBA0
        public void VRC.Udon.Serialization.OdinSerializer.Utilities.ICacheNotificationReceiver.OnClaimed(){} // RVA: 0xB43310
    }

    public class SerializationData : ValueType
    {
        // ── Methods ──
        public void get_HasEditorData(){} // RVA: 0x9DC830
        public void get_ContainsData(){} // RVA: 0x9DC9A0
        public void Reset(){} // RVA: 0x9DC9D0
    }

    public class SerializationNodeDataReader : BaseDataReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x848C7E0
        public void get_IndexIsValid(){} // RVA: 0x848D300
        public void get_Nodes(){} // RVA: 0x848D360
        public void set_Nodes(){} // RVA: 0x848D420
        public void get_Stream(){} // RVA: 0x848D4C0
        public void set_Stream(){} // RVA: 0x848D510
        public void Dispose(){} // RVA: 0x848D560
        public void PrepareNewSerializationSession(){} // RVA: 0x848D5D0
        public void PeekEntry(){} // RVA: 0x8478530
        public void EnterArray(){} // RVA: 0x848D950
        public void EnterNode(){} // RVA: 0x848DAF0
        public void ExitArray(){} // RVA: 0x848E0C0
        public void ExitNode(){} // RVA: 0x848E2A0
        public void ReadBoolean(){} // RVA: 0x848E4D0
        public void ReadByte(){} // RVA: 0x848E670
        public void ReadChar(){} // RVA: 0x848E720
        public void ReadDecimal(){} // RVA: 0x848E8E0
        public void ReadDouble(){} // RVA: 0x848EB70
        public void ReadExternalReference(){} // RVA: 0x848F250
        public void ReadGuid(){} // RVA: 0x848F450
        public void ReadInt16(){} // RVA: 0x848F780
        public void ReadInt32(){} // RVA: 0x848F840
        public void ReadInt64(){} // RVA: 0x848F900
        public void ReadInternalReference(){} // RVA: 0x848FB00
        public void ReadNull(){} // RVA: 0x848FD00
        public void ReadPrimitiveArray(){} // RVA: 0x87D350
        public void ReadSByte(){} // RVA: 0x848FDF0
        public void ReadSingle(){} // RVA: 0x848FEA0
        public void ReadString(){} // RVA: 0x8490100
        public void ReadUInt16(){} // RVA: 0x8490250
        public void ReadUInt32(){} // RVA: 0x8490310
        public void ReadUInt64(){} // RVA: 0x84903D0
        public void GetDataDump(){} // RVA: 0x84905D0
        public void ConsumeCurrentEntry(){} // RVA: 0x8490860
        public void ReadToNextEntry(){} // RVA: 0x84908D0
        public void <.ctor>b__6_0(){} // RVA: 0x8485440
        public void <.ctor>b__6_1(){} // RVA: 0x8485470
        public void <.ctor>b__6_2(){} // RVA: 0x84854A0
        public void <.ctor>b__6_3(){} // RVA: 0x84854D0
        public void <.ctor>b__6_4(){} // RVA: 0x8485500
        public void <.ctor>b__6_5(){} // RVA: 0x8485530
        public void <.ctor>b__6_6(){} // RVA: 0x8485560
        public void <.ctor>b__6_7(){} // RVA: 0x8485590
        public void <.ctor>b__6_8(){} // RVA: 0x84855C0
        public void <.ctor>b__6_9(){} // RVA: 0x84855F0
        public void <.ctor>b__6_10(){} // RVA: 0x8485630
        public void <.ctor>b__6_11(){} // RVA: 0x8485660
        public void <.ctor>b__6_12(){} // RVA: 0x8485690
        public void <.ctor>b__6_13(){} // RVA: 0x84856C0
    }

    public class SerializationNodeDataWriter : BaseDataWriter
    {
        // ── Methods ──
        public void get_Nodes(){} // RVA: 0x8490960
        public void set_Nodes(){} // RVA: 0x8490A20
        public void .ctor(){} // RVA: 0x8490AC0
        public void get_Stream(){} // RVA: 0x8491540
        public void set_Stream(){} // RVA: 0x8491590
        public void BeginArrayNode(){} // RVA: 0x84915E0
        public void BeginReferenceNode(){} // RVA: 0x84917D0
        public void BeginStructNode(){} // RVA: 0x8491AA0
        public void Dispose(){} // RVA: 0x64E2420
        public void EndArrayNode(){} // RVA: 0x8491CE0
        public void EndNode(){} // RVA: 0x8491E60
        public void PrepareNewSerializationSession(){} // RVA: 0x1320080
        public void WriteBoolean(){} // RVA: 0x8492020
        public void WriteByte(){} // RVA: 0x84921B0
        public void WriteChar(){} // RVA: 0x8492440
        public void WriteDecimal(){} // RVA: 0x8492630
        public void WriteSingle(){} // RVA: 0x8492870
        public void WriteDouble(){} // RVA: 0x8492AC0
        public void WriteExternalReference(){} // RVA: 0x8493060
        public void WriteGuid(){} // RVA: 0x84932F0
        public void WriteInt16(){} // RVA: 0x84934E0
        public void WriteInt32(){} // RVA: 0x84936D0
        public void WriteInt64(){} // RVA: 0x8493960
        public void WriteInternalReference(){} // RVA: 0x8493BF0
        public void WriteNull(){} // RVA: 0x8493E80
        public void WritePrimitiveArray(){} // RVA: 0x894320
        public void WriteSByte(){} // RVA: 0x8493FE0
        public void WriteString(){} // RVA: 0x84941D0
        public void WriteUInt16(){} // RVA: 0x8494330
        public void WriteUInt32(){} // RVA: 0x84945C0
        public void WriteUInt64(){} // RVA: 0x8494850
        public void FlushToStream(){} // RVA: 0xB43310
        public void GetDataDump(){} // RVA: 0x8494AE0
    }

    public class SerializationNode[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SerializationPolicies : Object
    {
        // ── Methods ──
        public void TryGetByID(){} // RVA: 0x84AEBB0
        public void get_Everything(){} // RVA: 0x84AEE30
        public void get_Unity(){} // RVA: 0x84AF1D0
        public void get_Strict(){} // RVA: 0x84AF6C0
        public void .cctor(){} // RVA: 0x84AFA60
    }

    public class SerializationUtility : Object
    {
        // ── Methods ──
        public void CreateWriter(){} // RVA: 0x84B0360
        public void CreateReader(){} // RVA: 0x84B0560
        public void GetCachedWriter(){} // RVA: 0x84B0750
        public void GetCachedReader(){} // RVA: 0x84B0AF0
        public void SerializeValueWeak(){} // RVA: 0x84B1A80
        public void SerializeValue(){} // RVA: 0xA94080
        public void DeserializeValueWeak(){} // RVA: 0x84B2620
        public void DeserializeValue(){} // RVA: 0xA94080
        public void CreateCopy(){} // RVA: 0x84B2760
    }

    public class SerializedBehaviour : Behaviour
    {
        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x4092830
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x84CD520
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x84CD590
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x84CD600
        public void OnAfterDeserialize(){} // RVA: 0xB43310
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SerializedComponent : Component
    {
        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x4092830
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x84CD520
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x84CD680
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x84CD6F0
        public void OnAfterDeserialize(){} // RVA: 0xB43310
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SerializedMonoBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.get_SerializationData(){} // RVA: 0x5BE1D00
        public void VRC.Udon.Serialization.OdinSerializer.ISupportsPrefabSerialization.set_SerializationData(){} // RVA: 0x84CD770
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x84CD7E0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x84CD850
        public void OnAfterDeserialize(){} // RVA: 0xB43310
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class SerializedScriptableObject : ScriptableObject
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x84CD8D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x84CD940
        public void OnAfterDeserialize(){} // RVA: 0xB43310
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SerializedStateMachineBehaviour : StateMachineBehaviour
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x84CD9C0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x84CDA30
        public void OnAfterDeserialize(){} // RVA: 0xB43310
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SerializedUnityObject : Object
    {
        // ── Methods ──
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x84CDAB0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x84CDB20
        public void OnAfterDeserialize(){} // RVA: 0xB43310
        public void OnBeforeSerialize(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x84CDBA0
    }

    public class Serializer : Object
    {
        // ── Methods ──
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void GetForValue(){} // RVA: 0x84BB990
        public void Get(){} // RVA: 0x84BBAE0
        public void ReadValueWeak(){} // RVA: 0x87C540
        public void WriteValueWeak(){} // RVA: 0x8954D0
        public void Create(){} // RVA: 0x84BBDE0
        public void LogAOTError(){} // RVA: 0x84BC2E0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x84BC480
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x87C540
        public void WriteValueWeak(){} // RVA: 0x8954D0
        public void ReadValue(){} // RVA: 0xA94080
        public void WriteValue(){} // RVA: 0xA94080
        public void FireOnSerializedType(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4930
        public void WriteValueWeak(){} // RVA: 0x4AB4970
        public void ReadValue(){} // RVA: 0x87D350
        public void WriteValue(){} // RVA: 0x89A3D0
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB4A50
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4930
        public void WriteValueWeak(){} // RVA: 0x4AB4970
        public void ReadValue(){} // RVA: 0x87D350
        public void WriteValue(){} // RVA: 0x89A3D0
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB4AF0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4B40
        public void WriteValueWeak(){} // RVA: 0x4AB4B80
        public void ReadValue(){} // RVA: 0x87C460
        public void WriteValue(){} // RVA: 0x89B370
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB4C60
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB7250
        public void WriteValueWeak(){} // RVA: 0x4AB7300
        public void ReadValue(){} // RVA: 0xA94080
        public void WriteValue(){} // RVA: 0xA94080
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB75C0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB40B0
        public void WriteValueWeak(){} // RVA: 0x4AB4100
        public void ReadValue(){} // RVA: 0x87BF80
        public void WriteValue(){} // RVA: 0x8954D0
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB58C0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB5AC0
        public void WriteValueWeak(){} // RVA: 0x4AB5B10
        public void ReadValue(){} // RVA: 0x882470
        public void WriteValue(){} // RVA: 0x89AFA0
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB5BF0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB7250
        public void WriteValueWeak(){} // RVA: 0x4AB7300
        public void ReadValue(){} // RVA: 0xA94080
        public void WriteValue(){} // RVA: 0xA94080
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB75C0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB40B0
        public void WriteValueWeak(){} // RVA: 0x4AB4100
        public void ReadValue(){} // RVA: 0x87BF80
        public void WriteValue(){} // RVA: 0x8954D0
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB5F00
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4B40
        public void WriteValueWeak(){} // RVA: 0x4AB4B80
        public void ReadValue(){} // RVA: 0x87C460
        public void WriteValue(){} // RVA: 0x89B370
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB6270
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4D50
        public void WriteValueWeak(){} // RVA: 0x4AB4D90
        public void ReadValue(){} // RVA: 0x87D050
        public void WriteValue(){} // RVA: 0x894600
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB62C0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4440
        public void WriteValueWeak(){} // RVA: 0x4AB4480
        public void ReadValue(){} // RVA: 0x87C540
        public void WriteValue(){} // RVA: 0x899E40
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB6310
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4440
        public void WriteValueWeak(){} // RVA: 0x4AB4480
        public void ReadValue(){} // RVA: 0x87C540
        public void WriteValue(){} // RVA: 0x899E40
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB6360
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4930
        public void WriteValueWeak(){} // RVA: 0x4AB4970
        public void ReadValue(){} // RVA: 0x87D350
        public void WriteValue(){} // RVA: 0x89A3D0
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB6620
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB6670
        public void WriteValueWeak(){} // RVA: 0x4AB66C0
        public void ReadValue(){} // RVA: 0x891020
        public void WriteValue(){} // RVA: 0x8A1730
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB6770
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB63B0
        public void WriteValueWeak(){} // RVA: 0x4AB63D0
        public void ReadValue(){} // RVA: 0x87C540
        public void WriteValue(){} // RVA: 0x8954D0
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x329A8D0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4B40
        public void WriteValueWeak(){} // RVA: 0x4AB4B80
        public void ReadValue(){} // RVA: 0x87C460
        public void WriteValue(){} // RVA: 0x89B370
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB6F50
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4D50
        public void WriteValueWeak(){} // RVA: 0x4AB4D90
        public void ReadValue(){} // RVA: 0x87D050
        public void WriteValue(){} // RVA: 0x894600
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB6FA0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4440
        public void WriteValueWeak(){} // RVA: 0x4AB4480
        public void ReadValue(){} // RVA: 0x87C540
        public void WriteValue(){} // RVA: 0x899E40
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB6FF0
    }

    public class Serializer`1 : Serializer
    {
        // ── Methods ──
        public void ReadValueWeak(){} // RVA: 0x4AB4440
        public void WriteValueWeak(){} // RVA: 0x4AB4480
        public void ReadValue(){} // RVA: 0x87C540
        public void WriteValue(){} // RVA: 0x899E40
        public void FireOnSerializedType(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x4AB7040
    }

    public class SingleSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84BD3F0
        public void WriteValue(){} // RVA: 0x84BE070
        public void .ctor(){} // RVA: 0x84BE0E0
    }

    public class StackFormatter`2 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0xA94080
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

    public class StringSerializer : Serializer`1
    {
        // ── Methods ──
        public void ReadValue(){} // RVA: 0x84BE150
        public void WriteValue(){} // RVA: 0x84BEE70
        public void .ctor(){} // RVA: 0x84BEF00
    }

    public class StrongBoxFormatter`1 : BaseFormatter`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8942F0
        public void .ctor(){} // RVA: 0x894290
        public void GetUninitializedObject(){} // RVA: 0x87C0A0
        public void DeserializeImplementation(){} // RVA: 0x8943B0
        public void SerializeImplementation(){} // RVA: 0x8943B0
    }

}