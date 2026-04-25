// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization
// Classes: 45
// Methods: 294

namespace ThirdParty.DotNet.System.Runtime.Serialization
{
    public class DataContractAttribute : Attribute
    {
        public bool IsReference; // 0x10

        // ── Methods ──
        public void get_IsReference(){} // RVA: 0x7FFAC2FEB5E0
    }

    public class DataMemberAttribute : Attribute
    {
        public string Name; // 0x10
        public int Order; // 0x18
        public bool IsRequired; // 0x1C
        public bool EmitDefaultValue; // 0x1D

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Order(){} // RVA: 0x7FFAC3157800
        public void get_IsRequired(){} // RVA: 0x7FFAC2F3C390
        public void get_EmitDefaultValue(){} // RVA: 0x7FFAC45FA990
    }

    public class DeserializationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class EnumMemberAttribute : Attribute
    {
        public string Value; // 0x10
        public bool isValueSetExplicitly; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC843C7C0
    }

    public class FixupHolder : Object
    {
        public long m_id; // 0x10
        public object m_fixupInfo; // 0x18
        public int m_fixupType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A8030
    }

    public class FixupHolderList : Object
    {
        public System.Runtime.Serialization.FixupHolder[] m_values; // 0x10
        public int m_count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A8130 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC84A81D0
        public void EnlargeArray(){} // RVA: 0x7FFAC84A8270
    }

    public class FormatterConverter : Object
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFAC849DEC0
        public void ToBoolean(){} // RVA: 0x7FFAC849DF70
        public void ToByte(){} // RVA: 0x7FFAC849E010
        public void ToInt16(){} // RVA: 0x7FFAC849E0B0
        public void ToInt32(){} // RVA: 0x7FFAC849E150
        public void ToUInt32(){} // RVA: 0x7FFAC849E1F0
        public void ToInt64(){} // RVA: 0x7FFAC849E290
        public void ToSingle(){} // RVA: 0x7FFAC849E330
        public void ToString(){} // RVA: 0x7FFAC849E3D0
        public void ThrowValueNullException(){} // RVA: 0x7FFAC849E470
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class FormatterServices : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]> m_MemberInfoTable;
        public bool unsafeTypeForwardersIsEnabled; // 0x8
        public bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
        public System.Type[] advancedTypes; // 0x10
        public System.Reflection.Binder s_binder; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC849FAD0
        public void GetSerializableMembers(){} // RVA: 0x7FFAC84A0B80 | overloaded x2
        public void CheckSerializable(){} // RVA: 0x7FFAC849FF60
        public void InternalGetSerializableMembers(){} // RVA: 0x7FFAC849FF90
        public void GetParentTypes(){} // RVA: 0x7FFAC84A0700
        public void GetUninitializedObject(){} // RVA: 0x7FFAC84A0F00
        public void nativeGetUninitializedObject(){} // RVA: 0x7FFAC8487EB0
        public void GetEnableUnsafeTypeForwarders(){} // RVA: 0x7FFAC2F21320
        public void UnsafeTypeForwardersIsEnabled(){} // RVA: 0x7FFAC84A1100
        public void SerializationSetValue(){} // RVA: 0x7FFAC84A11D0
        public void PopulateObjectMembers(){} // RVA: 0x7FFAC84A1420
        public void GetObjectData(){} // RVA: 0x7FFAC84A17F0
        public void GetTypeFromAssembly(){} // RVA: 0x7FFAC84A1C00
        public void LoadAssemblyFromString(){} // RVA: 0x7FFAC84A1C80
        public void LoadAssemblyFromStringNoThrow(){} // RVA: 0x7FFAC84A1CE0
        public void GetClrAssemblyName(){} // RVA: 0x7FFAC84A1D80
        public void GetClrTypeFullName(){} // RVA: 0x7FFAC84A1F30
        public void GetClrTypeFullNameForArray(){} // RVA: 0x7FFAC84A1FC0
        public void GetClrTypeFullNameForNonArrayTypes(){} // RVA: 0x7FFAC84A2240
    }

    public class IDeserializationCallback
    {
        // ── Methods ──
        public void OnDeserialization(){} // RVA: 0x7FFAC2C70A40
    }

    public class IFormatter
    {
        public object SurrogateSelector;

        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7FFAC2C58F40
        public void Serialize(){} // RVA: 0x7FFAC2C79B30
        public void set_SurrogateSelector(){} // RVA: 0x7FFAC2C70A40
    }

    public class IFormatterConverter
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFAC2C6A6F0
        public void ToBoolean(){} // RVA: 0x7FFAC2C59F60
        public void ToByte(){} // RVA: 0x7FFAC2C59F60
        public void ToInt16(){} // RVA: 0x7FFAC2C5F5D0
        public void ToInt32(){} // RVA: 0x7FFAC2C5E6B0
        public void ToUInt32(){} // RVA: 0x7FFAC2C5E6B0
        public void ToInt64(){} // RVA: 0x7FFAC2C58F40
        public void ToSingle(){} // RVA: 0x7FFAC2C6DF90
        public void ToString(){} // RVA: 0x7FFAC2C58F40
    }

    public class IObjectReference
    {
        // ── Methods ──
        public void GetRealObject(){} // RVA: 0x7FFAC2C58F40
    }

    public class ISafeSerializationData
    {
        // ── Methods ──
        public void CompleteDeserialization(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISerializable
    {
        // ── Methods ──
        public void GetObjectData(){}
    }

    public class ISerializationSurrogate
    {
        // ── Methods ──
        public void GetObjectData(){}
        public void SetObjectData(){}
    }

    public class ISurrogateSelector
    {
        // ── Methods ──
        public void ChainSelector(){} // RVA: 0x7FFAC2C70A40
        public void GetSurrogate(){}
    }

    public class IgnoreDataMemberAttribute : Attribute
    {
    }

    public class LongList : Object
    {
        public long[] Count; // 0x10
        public int Current; // 0x18
        public int m_totalItems; // 0x1C
        public int m_currentItem; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A8500 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC84A85A0
        public void get_Count(){} // RVA: 0x7FFAC3157800
        public void StartEnumeration(){} // RVA: 0x7FFAC5875C30
        public void MoveNext(){} // RVA: 0x7FFAC84A8600
        public void get_Current(){} // RVA: 0x7FFAC84A8650
        public void RemoveElement(){} // RVA: 0x7FFAC84A8680
        public void EnlargeArray(){} // RVA: 0x7FFAC84A8700
    }

    public class MemberHolder : Object
    {
        public System.Type _memberType; // 0x10
        public System.Runtime.Serialization.StreamingContext _context; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CECDE0
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void Equals(){} // RVA: 0x7FFAC849E4C0
    }

    public class ObjectHolder : Object
    {
        public object IsIncompleteObjectReference; // 0x10
        public long RequiresDelayedFixup; // 0x18
        public int RequiresValueTypeFixup; // 0x20
        public int ValueTypeFixupPerformed; // 0x24
        public System.Runtime.Serialization.SerializationInfo HasISerializable; // 0x28
        public System.Runtime.Serialization.ISerializationSurrogate HasSurrogate; // 0x30
        public System.Runtime.Serialization.FixupHolderList CanSurrogatedObjectValueChange; // 0x38
        public System.Runtime.Serialization.LongList CanObjectValueChange; // 0x40
        public System.Runtime.Serialization.ObjectHolder DirectlyDependentObjects; // 0x48
        public int TotalDependentObjects; // 0x50
        public bool Reachable; // 0x54
        public System.Runtime.Serialization.ValueTypeFixupInfo TypeLoadExceptionReachable; // 0x58
        public System.Runtime.Serialization.TypeLoadExceptionHolder TypeLoadException; // 0x60
        public bool ObjectValue; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A7210 | overloaded x3
        public void IncrementDescendentFixups(){} // RVA: 0x7FFAC84A74C0
        public void DecrementFixupsRemaining(){} // RVA: 0x7FFAC84A74D0
        public void RemoveDependency(){} // RVA: 0x7FFAC84A7530
        public void AddFixup(){} // RVA: 0x7FFAC84A75A0
        public void UpdateDescendentDependencyChain(){} // RVA: 0x7FFAC84A7760
        public void AddDependency(){} // RVA: 0x7FFAC84A77C0
        public void UpdateData(){} // RVA: 0x7FFAC84A7960
        public void MarkForCompletionWhenAvailable(){} // RVA: 0x7FFAC84A7BD0
        public void SetFlags(){} // RVA: 0x7FFAC84A7BE0
        public void get_IsIncompleteObjectReference(){} // RVA: 0x7FFAC845FF50
        public void set_IsIncompleteObjectReference(){} // RVA: 0x7FFAC84A7C80
        public void get_RequiresDelayedFixup(){} // RVA: 0x7FFAC84A7CA0
        public void get_RequiresValueTypeFixup(){} // RVA: 0x7FFAC84A7CB0
        public void get_ValueTypeFixupPerformed(){} // RVA: 0x7FFAC84A7CC0
        public void set_ValueTypeFixupPerformed(){} // RVA: 0x7FFAC84A7CF0
        public void get_HasISerializable(){} // RVA: 0x7FFAC845FF20
        public void get_HasSurrogate(){} // RVA: 0x7FFAC84A7D00
        public void get_CanSurrogatedObjectValueChange(){} // RVA: 0x7FFAC84A7D10
        public void get_CanObjectValueChange(){} // RVA: 0x7FFAC84A7DB0
        public void get_DirectlyDependentObjects(){} // RVA: 0x7FFAC30DBBE0
        public void get_TotalDependentObjects(){} // RVA: 0x7FFAC83DA070
        public void get_Reachable(){} // RVA: 0x7FFAC2FE9570
        public void set_Reachable(){} // RVA: 0x7FFAC2FE9580
        public void get_TypeLoadExceptionReachable(){} // RVA: 0x7FFAC4836B90
        public void get_TypeLoadException(){} // RVA: 0x7FFAC2FBF370
        public void set_TypeLoadException(){} // RVA: 0x7FFAC2FBF380
        public void get_ObjectValue(){} // RVA: 0x7FFAC2F3C380
        public void SetObjectValue(){} // RVA: 0x7FFAC84A7DD0
        public void get_SerializationInfo(){} // RVA: 0x7FFAC2F4F130
        public void set_SerializationInfo(){} // RVA: 0x7FFAC2F22E90
        public void get_Surrogate(){} // RVA: 0x7FFAC31D95E0
        public void get_DependentObjects(){} // RVA: 0x7FFAC2F9E740
        public void set_DependentObjects(){} // RVA: 0x7FFAC2F49200
        public void get_RequiresSerInfoFixup(){} // RVA: 0x7FFAC84A7FB0
        public void set_RequiresSerInfoFixup(){} // RVA: 0x7FFAC84A7FD0
        public void get_ValueFixup(){} // RVA: 0x7FFAC2FE9500
        public void get_CompletelyFixed(){} // RVA: 0x7FFAC84A7FF0
        public void get_ContainerID(){} // RVA: 0x7FFAC84A8010
    }

    public class ObjectHolderList : Object
    {
        public System.Runtime.Serialization.ObjectHolder[] Version; // 0x10
        public int Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A8990 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC84A8A30
        public void GetFixupEnumerator(){} // RVA: 0x7FFAC84A8A90
        public void EnlargeArray(){} // RVA: 0x7FFAC84A8B40
        public void get_Version(){} // RVA: 0x7FFAC3157800
        public void get_Count(){} // RVA: 0x7FFAC3157800
    }

    public class ObjectHolderListEnumerator : Object
    {
        public bool Current; // 0x10
        public System.Runtime.Serialization.ObjectHolderList m_list; // 0x18
        public int m_startingVersion; // 0x20
        public int m_currPos; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A8D30
        public void MoveNext(){} // RVA: 0x7FFAC84A8DB0
        public void get_Current(){} // RVA: 0x7FFAC84A8E60
    }

    public class ObjectIDGenerator : Object
    {
        public int m_currentCount; // 0x10
        public int m_currentSize; // 0x14
        public long[] m_ids; // 0x18
        public object[] m_objs; // 0x20
        public int[] sizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A2750
        public void FindElement(){} // RVA: 0x7FFAC84A28D0
        public void GetId(){} // RVA: 0x7FFAC84A2990
        public void HasId(){} // RVA: 0x7FFAC84A2B20
        public void Rehash(){} // RVA: 0x7FFAC84A2C00
        public void .cctor(){} // RVA: 0x7FFAC84A2F80
    }

    public class ObjectManager : Object
    {
        public System.Runtime.Serialization.DeserializationEventHandler TopObject; // 0x10
        public System.Runtime.Serialization.SerializationEventHandler SpecialFixupObjects; // 0x18
        public System.Runtime.Serialization.ObjectHolder[] m_objects; // 0x20
        public object m_topObject; // 0x28
        public System.Runtime.Serialization.ObjectHolderList m_specialFixupObjects; // 0x30
        public long m_fixupCount; // 0x38
        public System.Runtime.Serialization.ISurrogateSelector m_selector; // 0x40
        public System.Runtime.Serialization.StreamingContext m_context; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A3060
        public void CanCallGetType(){} // RVA: 0x7FFAC3006850
        public void set_TopObject(){} // RVA: 0x7FFAC2F22E90
        public void get_TopObject(){} // RVA: 0x7FFAC2F4F130
        public void get_SpecialFixupObjects(){} // RVA: 0x7FFAC84A31C0
        public void FindObjectHolder(){} // RVA: 0x7FFAC84A3300
        public void FindOrCreateObjectHolder(){} // RVA: 0x7FFAC84A3350
        public void AddObjectHolder(){} // RVA: 0x7FFAC84A3430
        public void GetCompletionInfo(){} // RVA: 0x7FFAC84A36E0
        public void FixupSpecialObject(){} // RVA: 0x7FFAC84A3B50
        public void ResolveObjectReference(){} // RVA: 0x7FFAC84A3EB0
        public void DoValueTypeFixup(){} // RVA: 0x7FFAC84A40F0
        public void CompleteObject(){} // RVA: 0x7FFAC84A4620
        public void DoNewlyRegisteredObjectFixups(){} // RVA: 0x7FFAC84A50F0
        public void GetObject(){} // RVA: 0x7FFAC84A5280
        public void RegisterString(){} // RVA: 0x7FFAC84A5370
        public void RegisterObject(){} // RVA: 0x7FFAC84A5480
        public void CompleteISerializableObject(){} // RVA: 0x7FFAC84A5A90
        public void GetConstructor(){} // RVA: 0x7FFAC84A5CF0
        public void DoFixups(){} // RVA: 0x7FFAC84A5E10
        public void RegisterFixup(){} // RVA: 0x7FFAC84A62C0
        public void RecordFixup(){} // RVA: 0x7FFAC84A63C0
        public void RecordDelayedFixup(){} // RVA: 0x7FFAC84A66D0
        public void RecordArrayElementFixup(){} // RVA: 0x7FFAC84A6850
        public void RaiseDeserializationEvent(){} // RVA: 0x7FFAC84A69D0
        public void AddOnDeserialization(){} // RVA: 0x7FFAC84A6A30
        public void AddOnDeserialized(){} // RVA: 0x7FFAC84A6B20
        public void RaiseOnDeserializedEvent(){} // RVA: 0x7FFAC84A6C10
        public void RaiseOnDeserializingEvent(){} // RVA: 0x7FFAC84A6CE0
    }

    public class OnDeserializedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OnDeserializingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OnSerializedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OnSerializingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OptionalFieldAttribute : Attribute
    {
        public int VersionAdded; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B41D0
        public void set_VersionAdded(){} // RVA: 0x7FFAC84AA320
    }

    public class SafeSerializationEventArgs : EventArgs
    {
        public System.Runtime.Serialization.StreamingContext SerializedStates; // 0x10
        public System.Collections.Generic.List`1<object> m_serializedStates; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84A8EA0
        public void get_SerializedStates(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class SafeSerializationManager : Object
    {
        public System.Collections.Generic.IList`1<object> IsActive; // 0x10
        public System.Runtime.Serialization.SerializationInfo m_savedSerializationInfo; // 0x18
        public object m_realObject; // 0x20
        public System.RuntimeType m_realType; // 0x28
        public System.EventHandler`1<System.Runtime.Serialization.SafeSerializationEventArgs> SerializeObjectState; // 0x30
        public string RealTypeSerializationName;

        // ── Methods ──
        public void add_SerializeObjectState(){} // RVA: 0x7FFAC84A8FF0
        public void remove_SerializeObjectState(){} // RVA: 0x7FFAC84A90F0
        public void .ctor(){} // RVA: 0x7FFAC84A91F0 | overloaded x2
        public void get_IsActive(){} // RVA: 0x7FFAC781E0A0
        public void CompleteSerialization(){} // RVA: 0x7FFAC84A9530
        public void CompleteDeserialization(){} // RVA: 0x7FFAC84A9920
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC84A9BE0
        public void System.Runtime.Serialization.IObjectReference.GetRealObject(){} // RVA: 0x7FFAC84A9D80
        public void OnDeserialized(){} // RVA: 0x7FFAC84AA200
    }

    public class SerializationBinder : Object
    {
        // ── Methods ──
        public void BindToName(){} // RVA: 0x7FFAC849E540
        public void BindToType(){} // RVA: 0x7FFAC2C6A6F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SerializationEntry : ValueType
    {
        public string Value; // 0x10
        public object Name; // 0x18
        public System.Type ObjectType; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC446FCC0
        public void get_Value(){} // RVA: 0x7FFAC4420220
        public void get_Name(){} // RVA: 0x7FFAC3AD9F60
        public void get_ObjectType(){} // RVA: 0x7FFAC2F3C380
    }

    public class SerializationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC556C390
        public void Invoke(){} // RVA: 0x7FFAC556C460
    }

    public class SerializationEvents : Object
    {
        public System.Collections.Generic.List`1<System.Reflection.MethodInfo> HasOnSerializingEvents; // 0x10
        public System.Collections.Generic.List`1<System.Reflection.MethodInfo> _onSerializedMethods; // 0x18
        public System.Collections.Generic.List`1<System.Reflection.MethodInfo> _onDeserializingMethods; // 0x20
        public System.Collections.Generic.List`1<System.Reflection.MethodInfo> _onDeserializedMethods; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC849E5F0
        public void GetMethodsWithAttribute(){} // RVA: 0x7FFAC849E990
        public void get_HasOnSerializingEvents(){} // RVA: 0x7FFAC849EBC0
        public void InvokeOnSerializing(){} // RVA: 0x7FFAC849EBE0
        public void InvokeOnDeserializing(){} // RVA: 0x7FFAC849EC30
        public void InvokeOnDeserialized(){} // RVA: 0x7FFAC849EC80
        public void AddOnSerialized(){} // RVA: 0x7FFAC849ECD0
        public void AddOnDeserialized(){} // RVA: 0x7FFAC849ECF0
        public void InvokeOnDelegate(){} // RVA: 0x7FFAC849ED10
        public void AddOnDelegate(){} // RVA: 0x7FFAC849ED50
    }

    public class SerializationEventsCache : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<System.Type,System.Runtime.Serialization.SerializationEvents> s_cache;

        // ── Methods ──
        public void GetSerializationEventsForType(){} // RVA: 0x7FFAC849EFE0
        public void .cctor(){} // RVA: 0x7FFAC849F190
    }

    public class SerializationException : SystemException
    {
        public string s_nullMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFAC849D9B0
    }

    public class SerializationFieldInfo : FieldInfo
    {
        public System.Reflection.RuntimeFieldInfo Module; // 0x10
        public string MetadataToken; // 0x18

        // ── Methods ──
        public void get_Module(){} // RVA: 0x7FFAC4426B30
        public void get_MetadataToken(){} // RVA: 0x7FFAC84AA3A0
        public void .ctor(){} // RVA: 0x7FFAC84AA3D0
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void get_DeclaringType(){} // RVA: 0x7FFAC84AA500
        public void get_ReflectedType(){} // RVA: 0x7FFAC84AA530
        public void GetCustomAttributes(){} // RVA: 0x7FFAC84AA590 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFAC84AA5C0
        public void get_FieldType(){} // RVA: 0x7FFAC84AA5F0
        public void GetValue(){} // RVA: 0x7FFAC7C8D060
        public void InternalGetValue(){} // RVA: 0x7FFAC84AA620
        public void SetValue(){} // RVA: 0x7FFAC84AA680
        public void InternalSetValue(){} // RVA: 0x7FFAC84AA6C0
        public void get_FieldInfo(){} // RVA: 0x7FFAC2F3C380
        public void get_FieldHandle(){} // RVA: 0x7FFAC84AA740
        public void get_Attributes(){} // RVA: 0x7FFAC84AA770
    }

    public class SerializationInfo : Object
    {
        public int FullTypeName;
        public string AssemblyName;
        public string MemberCount;
        public string[] ObjectType; // 0x10
        public object[] IsFullTypeNameSetExplicit; // 0x18
        public System.Type[] IsAssemblyNameSetExplicit; // 0x20
        public System.Collections.Generic.Dictionary`2<string,int> m_nameToIndex; // 0x28
        public int m_currMember; // 0x30
        public System.Runtime.Serialization.IFormatterConverter m_converter; // 0x38
        public string m_fullTypeName; // 0x40
        public string m_assemName; // 0x48
        public System.Type objectType; // 0x50
        public bool isFullTypeNameSetExplicit; // 0x58
        public bool isAssemblyNameSetExplicit; // 0x59
        public bool requireSameTokenInPartialTrust; // 0x5A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84AA7C0 | overloaded x2
        public void get_FullTypeName(){} // RVA: 0x7FFAC2F9E740
        public void get_AssemblyName(){} // RVA: 0x7FFAC2F9C730
        public void SetType(){} // RVA: 0x7FFAC84AAC40
        public void Compare(){} // RVA: 0x7FFAC84AAEC0
        public void DemandForUnsafeAssemblyNameAssignments(){} // RVA: 0x7FFAC84AAF40
        public void IsAssemblyNameAssignmentSafe(){} // RVA: 0x7FFAC84AAF50
        public void get_MemberCount(){} // RVA: 0x7FFAC2F7CCD0
        public void get_ObjectType(){} // RVA: 0x7FFAC2FC20E0
        public void get_IsFullTypeNameSetExplicit(){} // RVA: 0x7FFAC313F600
        public void get_IsAssemblyNameSetExplicit(){} // RVA: 0x7FFAC778CF40
        public void GetEnumerator(){} // RVA: 0x7FFAC84AB220
        public void ExpandArrays(){} // RVA: 0x7FFAC84AB3A0
        public void AddValue(){} // RVA: 0x7FFAC84ACED0 | overloaded x14
        public void AddValueInternal(){} // RVA: 0x7FFAC84AD090
        public void UpdateValue(){} // RVA: 0x7FFAC84AD290
        public void FindElement(){} // RVA: 0x7FFAC84AD390
        public void GetElement(){} // RVA: 0x7FFAC84AD490
        public void GetElementNoThrow(){} // RVA: 0x7FFAC84AD5F0
        public void GetValue(){} // RVA: 0x7FFAC84AD720
        public void GetValueNoThrow(){} // RVA: 0x7FFAC84AD900
        public void GetBoolean(){} // RVA: 0x7FFAC84ADAE0
        public void GetByte(){} // RVA: 0x7FFAC84ADC40
        public void GetInt16(){} // RVA: 0x7FFAC84ADDA0
        public void GetInt32(){} // RVA: 0x7FFAC84ADF00
        public void GetUInt32(){} // RVA: 0x7FFAC84AE060
        public void GetInt64(){} // RVA: 0x7FFAC84AE1C0
        public void GetSingle(){} // RVA: 0x7FFAC84AE320
        public void GetString(){} // RVA: 0x7FFAC84AE480
    }

    public class SerializationInfoEnumerator : Object
    {
        public string[] System.Collections.IEnumerator.Current; // 0x10
        public object[] Current; // 0x18
        public System.Type[] Name; // 0x20
        public int Value; // 0x28
        public int ObjectType; // 0x2C
        public bool _current; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC849DA60
        public void MoveNext(){} // RVA: 0x7FFAC849DB80
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC849DBA0
        public void get_Current(){} // RVA: 0x7FFAC849DC10
        public void Reset(){} // RVA: 0x7FFAC849DD00
        public void get_Name(){} // RVA: 0x7FFAC849DD10
        public void get_Value(){} // RVA: 0x7FFAC849DDA0
        public void get_ObjectType(){} // RVA: 0x7FFAC849DE30
    }

    public class SerializationObjectManager : Object
    {
        public System.Collections.Generic.Dictionary`2<object,object> _objectSeenTable; // 0x10
        public System.Runtime.Serialization.StreamingContext _context; // 0x18
        public System.Runtime.Serialization.SerializationEventHandler _onSerializedHandler; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC849F370
        public void RegisterObject(){} // RVA: 0x7FFAC849F4A0
        public void RaiseOnSerializedEvent(){} // RVA: 0x7FFAC849F6C0
        public void AddOnSerialized(){} // RVA: 0x7FFAC849F700
    }

    public class StreamingContext : ValueType
    {
        public object Context; // 0x10
        public 0x6B0D3500 State; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84AE640 | overloaded x2
        public void get_Context(){} // RVA: 0x7FFAC3AD9F60
        public void Equals(){} // RVA: 0x7FFAC84AE6A0
        public void GetHashCode(){} // RVA: 0x7FFAC49C7500
        public void get_State(){} // RVA: 0x7FFAC49C7500
    }

    public class SurrogateForCyclicalReference : Object
    {
        public System.Runtime.Serialization.ISerializationSurrogate innerSurrogate; // 0x10

        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFAC84A25C0
        public void SetObjectData(){} // RVA: 0x7FFAC84A26B0
    }

    public class TypeLoadExceptionHolder : Object
    {
        public string TypeName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_TypeName(){} // RVA: 0x7FFAC2F3C380
    }

    public class ValueTypeFixupInfo : Object
    {
        public long ContainerID; // 0x10
        public System.Reflection.FieldInfo ParentField; // 0x18
        public int[] ParentIndex; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC849F7F0
        public void get_ContainerID(){} // RVA: 0x7FFAC2F3C380
        public void get_ParentField(){} // RVA: 0x7FFAC2F247C0
        public void get_ParentIndex(){} // RVA: 0x7FFAC2F4F0C0
    }

}