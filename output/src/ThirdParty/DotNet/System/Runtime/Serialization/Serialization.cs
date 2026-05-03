// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization
// Classes: 45
// Methods: 294

namespace ThirdParty.DotNet.System.Runtime.Serialization
{
    public class DataContractAttribute : Attribute
    {
        public bool isReference; // 0x10

        // ── Methods ──
        public void get_IsReference(){} // RVA: 0x7FFE811C55E0
    }

    public class DataMemberAttribute : Attribute
    {
        public string name; // 0x10
        public int order; // 0x18
        public bool isRequired; // 0x1C
        public bool emitDefaultValue; // 0x1D

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Order(){} // RVA: 0x7FFE813DB630
        public void get_IsRequired(){} // RVA: 0x7FFE81116390
        public void get_EmitDefaultValue(){} // RVA: 0x7FFE82930100
    }

    public class DeserializationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class EnumMemberAttribute : Attribute
    {
        public string value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE867E60D0
    }

    public class FixupHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86851920
    }

    public class FixupHolderList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86851A20 | overloaded x2
        public void Add(){} // RVA: 0x7FFE86851AC0
        public void EnlargeArray(){} // RVA: 0x7FFE86851B60
    }

    public class FormatterConverter : Object
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFE868477C0
        public void ToBoolean(){} // RVA: 0x7FFE86847870
        public void ToByte(){} // RVA: 0x7FFE86847910
        public void ToInt16(){} // RVA: 0x7FFE868479B0
        public void ToInt32(){} // RVA: 0x7FFE86847A50
        public void ToUInt32(){} // RVA: 0x7FFE86847AF0
        public void ToInt64(){} // RVA: 0x7FFE86847B90
        public void ToSingle(){} // RVA: 0x7FFE86847C30
        public void ToString(){} // RVA: 0x7FFE86847CD0
        public void ThrowValueNullException(){} // RVA: 0x7FFE86847D70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FormatterServices : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE868493D0
        public void GetSerializableMembers(){} // RVA: 0x7FFE8684A480 | overloaded x2
        public void CheckSerializable(){} // RVA: 0x7FFE86849860
        public void InternalGetSerializableMembers(){} // RVA: 0x7FFE86849890
        public void GetParentTypes(){} // RVA: 0x7FFE8684A000
        public void GetUninitializedObject(){} // RVA: 0x7FFE8684A800
        public void nativeGetUninitializedObject(){} // RVA: 0x7FFE868317C0
        public void GetEnableUnsafeTypeForwarders(){} // RVA: 0x7FFE810FB320
        public void UnsafeTypeForwardersIsEnabled(){} // RVA: 0x7FFE8684AA00
        public void SerializationSetValue(){} // RVA: 0x7FFE8684AAD0
        public void PopulateObjectMembers(){} // RVA: 0x7FFE8684AD20
        public void GetObjectData(){} // RVA: 0x7FFE8684B0F0
        public void GetTypeFromAssembly(){} // RVA: 0x7FFE8684B500
        public void LoadAssemblyFromString(){} // RVA: 0x7FFE8684B580
        public void LoadAssemblyFromStringNoThrow(){} // RVA: 0x7FFE8684B5E0
        public void GetClrAssemblyName(){} // RVA: 0x7FFE8684B680
        public void GetClrTypeFullName(){} // RVA: 0x7FFE8684B830
        public void GetClrTypeFullNameForArray(){} // RVA: 0x7FFE8684B8C0
        public void GetClrTypeFullNameForNonArrayTypes(){} // RVA: 0x7FFE8684BB40
    }

    public class IDeserializationCallback
    {
        // ── Methods ──
        public void OnDeserialization(){} // RVA: 0x7FFE80E460A0
    }

    public class IFormatter
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7FFE80E2E390
        public void Serialize(){} // RVA: 0x7FFE80E4F230
        public void set_SurrogateSelector(){} // RVA: 0x7FFE80E460A0
    }

    public class IFormatterConverter
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFE80E3FC10
        public void ToBoolean(){} // RVA: 0x7FFE80E2F3B0
        public void ToByte(){} // RVA: 0x7FFE80E2F3B0
        public void ToInt16(){} // RVA: 0x7FFE80E34A20
        public void ToInt32(){} // RVA: 0x7FFE80E33B00
        public void ToUInt32(){} // RVA: 0x7FFE80E33B00
        public void ToInt64(){} // RVA: 0x7FFE80E2E390
        public void ToSingle(){} // RVA: 0x7FFE80E43520
        public void ToString(){} // RVA: 0x7FFE80E2E390
    }

    public class IObjectReference
    {
        // ── Methods ──
        public void GetRealObject(){} // RVA: 0x7FFE80E2E390
    }

    public class ISafeSerializationData
    {
        // ── Methods ──
        public void CompleteDeserialization(){} // RVA: 0x7FFE80E460A0
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
        public void ChainSelector(){} // RVA: 0x7FFE80E460A0
        public void GetSurrogate(){}
    }

    public class IgnoreDataMemberAttribute : Attribute
    {
    }

    public class LongList : Object
    {
        public long[] m_values; // 0x10
        public int m_count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86851DF0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE86851E90
        public void get_Count(){} // RVA: 0x7FFE813DB630
        public void StartEnumeration(){} // RVA: 0x7FFE83BB2D90
        public void MoveNext(){} // RVA: 0x7FFE86851EF0
        public void get_Current(){} // RVA: 0x7FFE86851F40
        public void RemoveElement(){} // RVA: 0x7FFE86851F70
        public void EnlargeArray(){} // RVA: 0x7FFE86851FF0
    }

    public class MemberHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE850732C0
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
        public void Equals(){} // RVA: 0x7FFE86847DC0
    }

    public class ObjectHolder : Object
    {
        public object m_object; // 0x10
        public long m_id; // 0x18
        public int m_missingElementsRemaining; // 0x20
        public int m_missingDecendents; // 0x24
        public System.Runtime.Serialization.SerializationInfo m_serInfo; // 0x28
        public System.Runtime.Serialization.ISerializationSurrogate m_surrogate; // 0x30
        public System.Runtime.Serialization.FixupHolderList m_missingElements; // 0x38
        public System.Runtime.Serialization.LongList m_dependentObjects; // 0x40
        public System.Runtime.Serialization.ObjectHolder m_next; // 0x48
        public int m_flags; // 0x50
        public bool m_markForFixupWhenAvailable; // 0x54
        public System.Runtime.Serialization.ValueTypeFixupInfo m_valueFixup; // 0x58
        public System.Runtime.Serialization.TypeLoadExceptionHolder m_typeLoad; // 0x60
        public bool m_reachable; // 0x68
        public object field_14; // 0x4D3
        public object field_15; // 0x4D4
        public object field_16; // 0x4D5
        public object field_17; // 0x4D6
        public object field_18; // 0x4D7
        public object field_19; // 0x4D8
        public object field_20; // 0x4D9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86850B10 | overloaded x3
        public void IncrementDescendentFixups(){} // RVA: 0x7FFE86850DC0
        public void DecrementFixupsRemaining(){} // RVA: 0x7FFE86850DD0
        public void RemoveDependency(){} // RVA: 0x7FFE86850E30
        public void AddFixup(){} // RVA: 0x7FFE86850EA0
        public void UpdateDescendentDependencyChain(){} // RVA: 0x7FFE86851060
        public void AddDependency(){} // RVA: 0x7FFE868510C0
        public void UpdateData(){} // RVA: 0x7FFE86851260
        public void MarkForCompletionWhenAvailable(){} // RVA: 0x7FFE812B4E50
        public void SetFlags(){} // RVA: 0x7FFE868514D0
        public void get_IsIncompleteObjectReference(){} // RVA: 0x7FFE86809860
        public void set_IsIncompleteObjectReference(){} // RVA: 0x7FFE86851570
        public void get_RequiresDelayedFixup(){} // RVA: 0x7FFE86851590
        public void get_RequiresValueTypeFixup(){} // RVA: 0x7FFE868515A0
        public void get_ValueTypeFixupPerformed(){} // RVA: 0x7FFE868515B0
        public void set_ValueTypeFixupPerformed(){} // RVA: 0x7FFE868515E0
        public void get_HasISerializable(){} // RVA: 0x7FFE86809830
        public void get_HasSurrogate(){} // RVA: 0x7FFE868515F0
        public void get_CanSurrogatedObjectValueChange(){} // RVA: 0x7FFE86851600
        public void get_CanObjectValueChange(){} // RVA: 0x7FFE868516A0
        public void get_DirectlyDependentObjects(){} // RVA: 0x7FFE8151D690
        public void get_TotalDependentObjects(){} // RVA: 0x7FFE86783970
        public void get_Reachable(){} // RVA: 0x7FFE811C3570
        public void set_Reachable(){} // RVA: 0x7FFE811C3580
        public void get_TypeLoadExceptionReachable(){} // RVA: 0x7FFE82A9EF30
        public void get_TypeLoadException(){} // RVA: 0x7FFE81199370
        public void set_TypeLoadException(){} // RVA: 0x7FFE81199380
        public void get_ObjectValue(){} // RVA: 0x7FFE81116380
        public void SetObjectValue(){} // RVA: 0x7FFE868516C0
        public void get_SerializationInfo(){} // RVA: 0x7FFE81129130
        public void set_SerializationInfo(){} // RVA: 0x7FFE810FCE90
        public void get_Surrogate(){} // RVA: 0x7FFE8144E200
        public void get_DependentObjects(){} // RVA: 0x7FFE81178740
        public void set_DependentObjects(){} // RVA: 0x7FFE81123200
        public void get_RequiresSerInfoFixup(){} // RVA: 0x7FFE868518A0
        public void set_RequiresSerInfoFixup(){} // RVA: 0x7FFE868518C0
        public void get_ValueFixup(){} // RVA: 0x7FFE811C3500
        public void get_CompletelyFixed(){} // RVA: 0x7FFE868518E0
        public void get_ContainerID(){} // RVA: 0x7FFE86851900
    }

    public class ObjectHolderList : Object
    {
        public System.Runtime.Serialization.ObjectHolder[] m_values; // 0x10
        public int m_count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86852280 | overloaded x2
        public void Add(){} // RVA: 0x7FFE86852320
        public void GetFixupEnumerator(){} // RVA: 0x7FFE86852380
        public void EnlargeArray(){} // RVA: 0x7FFE86852430
        public void get_Version(){} // RVA: 0x7FFE813DB630
        public void get_Count(){} // RVA: 0x7FFE813DB630
    }

    public class ObjectHolderListEnumerator : Object
    {
        public bool m_isFixupEnumerator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86852620
        public void MoveNext(){} // RVA: 0x7FFE868526A0
        public void get_Current(){} // RVA: 0x7FFE86852750
    }

    public class ObjectIDGenerator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8684C050
        public void FindElement(){} // RVA: 0x7FFE8684C1D0
        public void GetId(){} // RVA: 0x7FFE8684C290
        public void HasId(){} // RVA: 0x7FFE8684C420
        public void Rehash(){} // RVA: 0x7FFE8684C500
        public void .cctor(){} // RVA: 0x7FFE8684C880
    }

    public class ObjectManager : Object
    {
        public System.Runtime.Serialization.DeserializationEventHandler m_onDeserializationHandler; // 0x10
        public System.Runtime.Serialization.SerializationEventHandler m_onDeserializedHandler; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8684C960
        public void CanCallGetType(){} // RVA: 0x7FFE811E0850
        public void set_TopObject(){} // RVA: 0x7FFE810FCE90
        public void get_TopObject(){} // RVA: 0x7FFE81129130
        public void get_SpecialFixupObjects(){} // RVA: 0x7FFE8684CAC0
        public void FindObjectHolder(){} // RVA: 0x7FFE8684CC00
        public void FindOrCreateObjectHolder(){} // RVA: 0x7FFE8684CC50
        public void AddObjectHolder(){} // RVA: 0x7FFE8684CD30
        public void GetCompletionInfo(){} // RVA: 0x7FFE8684CFE0
        public void FixupSpecialObject(){} // RVA: 0x7FFE8684D450
        public void ResolveObjectReference(){} // RVA: 0x7FFE8684D7B0
        public void DoValueTypeFixup(){} // RVA: 0x7FFE8684D9F0
        public void CompleteObject(){} // RVA: 0x7FFE8684DF20
        public void DoNewlyRegisteredObjectFixups(){} // RVA: 0x7FFE8684E9F0
        public void GetObject(){} // RVA: 0x7FFE8684EB80
        public void RegisterString(){} // RVA: 0x7FFE8684EC70
        public void RegisterObject(){} // RVA: 0x7FFE8684ED80
        public void CompleteISerializableObject(){} // RVA: 0x7FFE8684F390
        public void GetConstructor(){} // RVA: 0x7FFE8684F5F0
        public void DoFixups(){} // RVA: 0x7FFE8684F710
        public void RegisterFixup(){} // RVA: 0x7FFE8684FBC0
        public void RecordFixup(){} // RVA: 0x7FFE8684FCC0
        public void RecordDelayedFixup(){} // RVA: 0x7FFE8684FFD0
        public void RecordArrayElementFixup(){} // RVA: 0x7FFE86850150
        public void RaiseDeserializationEvent(){} // RVA: 0x7FFE868502D0
        public void AddOnDeserialization(){} // RVA: 0x7FFE86850330
        public void AddOnDeserialized(){} // RVA: 0x7FFE86850420
        public void RaiseOnDeserializedEvent(){} // RVA: 0x7FFE86850510
        public void RaiseOnDeserializingEvent(){} // RVA: 0x7FFE868505E0
    }

    public class OnDeserializedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OnDeserializingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OnSerializedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OnSerializingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OptionalFieldAttribute : Attribute
    {
        public int versionAdded; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82880410
        public void set_VersionAdded(){} // RVA: 0x7FFE86853C10
    }

    public class SafeSerializationEventArgs : EventArgs
    {
        public System.Runtime.Serialization.StreamingContext m_streamingContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86852790
        public void get_SerializedStates(){} // RVA: 0x7FFE811290C0
    }

    public class SafeSerializationManager : Object
    {
        public System.Collections.Generic.IList`1<object> m_serializedStates; // 0x10

        // ── Methods ──
        public void add_SerializeObjectState(){} // RVA: 0x7FFE868528E0
        public void remove_SerializeObjectState(){} // RVA: 0x7FFE868529E0
        public void .ctor(){} // RVA: 0x7FFE86852AE0 | overloaded x2
        public void get_IsActive(){} // RVA: 0x7FFE85C00B10
        public void CompleteSerialization(){} // RVA: 0x7FFE86852E20
        public void CompleteDeserialization(){} // RVA: 0x7FFE86853210
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE868534D0
        public void System.Runtime.Serialization.IObjectReference.GetRealObject(){} // RVA: 0x7FFE86853670
        public void OnDeserialized(){} // RVA: 0x7FFE86853AF0
    }

    public class SerializationBinder : Object
    {
        // ── Methods ──
        public void BindToName(){} // RVA: 0x7FFE86847E40
        public void BindToType(){} // RVA: 0x7FFE80E3FC10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SerializationEntry : ValueType
    {
        public string _name; // 0x10
        public object _value; // 0x18
        public System.Type _type; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82760A10
        public void get_Value(){} // RVA: 0x7FFE826F4210
        public void get_Name(){} // RVA: 0x7FFE8284EF60
        public void get_ObjectType(){} // RVA: 0x7FFE81116380
    }

    public class SerializationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83871610
        public void Invoke(){} // RVA: 0x7FFE838716E0
    }

    public class SerializationEvents : Object
    {
        public System.Collections.Generic.List`1<System.Reflection.MethodInfo> _onSerializingMethods; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86847EF0
        public void GetMethodsWithAttribute(){} // RVA: 0x7FFE86848290
        public void get_HasOnSerializingEvents(){} // RVA: 0x7FFE868484C0
        public void InvokeOnSerializing(){} // RVA: 0x7FFE868484E0
        public void InvokeOnDeserializing(){} // RVA: 0x7FFE86848530
        public void InvokeOnDeserialized(){} // RVA: 0x7FFE86848580
        public void AddOnSerialized(){} // RVA: 0x7FFE868485D0
        public void AddOnDeserialized(){} // RVA: 0x7FFE868485F0
        public void InvokeOnDelegate(){} // RVA: 0x7FFE86848610
        public void AddOnDelegate(){} // RVA: 0x7FFE86848650
    }

    public class SerializationEventsCache : Object
    {
        // ── Methods ──
        public void GetSerializationEventsForType(){} // RVA: 0x7FFE868488E0
        public void .cctor(){} // RVA: 0x7FFE86848A90
    }

    public class SerializationException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFE868472B0
    }

    public class SerializationFieldInfo : FieldInfo
    {
        public System.Reflection.RuntimeFieldInfo m_field; // 0x10
        public string m_serializationName; // 0x18
        public object field_2; // 0x4F1
        public object field_3; // 0x4F2
        public object field_4; // 0x4F3
        public object field_5; // 0x4F4
        public object field_6; // 0x4F5
        public object field_7; // 0x4F6
        public object field_8; // 0x4F7

        // ── Methods ──
        public void get_Module(){} // RVA: 0x7FFE826F8E90
        public void get_MetadataToken(){} // RVA: 0x7FFE81588730
        public void .ctor(){} // RVA: 0x7FFE86853C90
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void get_DeclaringType(){} // RVA: 0x7FFE86853DC0
        public void get_ReflectedType(){} // RVA: 0x7FFE86853DF0
        public void GetCustomAttributes(){} // RVA: 0x7FFE86853E50 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE81588B20
        public void get_FieldType(){} // RVA: 0x7FFE81588910
        public void GetValue(){} // RVA: 0x7FFE8605AD30
        public void InternalGetValue(){} // RVA: 0x7FFE86853E80
        public void SetValue(){} // RVA: 0x7FFE86853EE0
        public void InternalSetValue(){} // RVA: 0x7FFE86853F20
        public void get_FieldInfo(){} // RVA: 0x7FFE81116380
        public void get_FieldHandle(){} // RVA: 0x7FFE86853FA0
        public void get_Attributes(){} // RVA: 0x7FFE815889C0
    }

    public class SerializationInfo : Object
    {
        public int defaultSize;
        public string s_mscorlibAssemblySimpleName;
        public string s_mscorlibFileName;
        public string[] m_members; // 0x10
        public object[] m_data; // 0x18
        public System.Type[] m_types; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86853FF0 | overloaded x2
        public void get_FullTypeName(){} // RVA: 0x7FFE81178740
        public void get_AssemblyName(){} // RVA: 0x7FFE81176730
        public void SetType(){} // RVA: 0x7FFE86854470
        public void Compare(){} // RVA: 0x7FFE868546F0
        public void DemandForUnsafeAssemblyNameAssignments(){} // RVA: 0x7FFE86854770
        public void IsAssemblyNameAssignmentSafe(){} // RVA: 0x7FFE86854780
        public void get_MemberCount(){} // RVA: 0x7FFE81156CD0
        public void get_ObjectType(){} // RVA: 0x7FFE8119C0E0
        public void get_IsFullTypeNameSetExplicit(){} // RVA: 0x7FFE813A1140
        public void get_IsAssemblyNameSetExplicit(){} // RVA: 0x7FFE85BA8C00
        public void GetEnumerator(){} // RVA: 0x7FFE86854A50
        public void ExpandArrays(){} // RVA: 0x7FFE86854BD0
        public void AddValue(){} // RVA: 0x7FFE86856700 | overloaded x14
        public void AddValueInternal(){} // RVA: 0x7FFE868568C0
        public void UpdateValue(){} // RVA: 0x7FFE86856AC0
        public void FindElement(){} // RVA: 0x7FFE86856BC0
        public void GetElement(){} // RVA: 0x7FFE86856CC0
        public void GetElementNoThrow(){} // RVA: 0x7FFE86856E20
        public void GetValue(){} // RVA: 0x7FFE86856F50
        public void GetValueNoThrow(){} // RVA: 0x7FFE86857130
        public void GetBoolean(){} // RVA: 0x7FFE86857310
        public void GetByte(){} // RVA: 0x7FFE86857470
        public void GetInt16(){} // RVA: 0x7FFE868575D0
        public void GetInt32(){} // RVA: 0x7FFE86857730
        public void GetUInt32(){} // RVA: 0x7FFE86857890
        public void GetInt64(){} // RVA: 0x7FFE868579F0
        public void GetSingle(){} // RVA: 0x7FFE86857B50
        public void GetString(){} // RVA: 0x7FFE86857CB0
    }

    public class SerializationInfoEnumerator : Object
    {
        public string[] _members; // 0x10
        public object[] _data; // 0x18
        public System.Type[] _types; // 0x20
        public int _numItems; // 0x28
        public int _currItem; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86847360
        public void MoveNext(){} // RVA: 0x7FFE86847480
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE868474A0
        public void get_Current(){} // RVA: 0x7FFE86847510
        public void Reset(){} // RVA: 0x7FFE86847600
        public void get_Name(){} // RVA: 0x7FFE86847610
        public void get_Value(){} // RVA: 0x7FFE868476A0
        public void get_ObjectType(){} // RVA: 0x7FFE86847730
    }

    public class SerializationObjectManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86848C70
        public void RegisterObject(){} // RVA: 0x7FFE86848DA0
        public void RaiseOnSerializedEvent(){} // RVA: 0x7FFE86848FC0
        public void AddOnSerialized(){} // RVA: 0x7FFE86849000
    }

    public class StreamingContext : ValueType
    {
        public object m_additionalContext; // 0x10
        public 0x664CC424 m_state; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86857E70 | overloaded x2
        public void get_Context(){} // RVA: 0x7FFE8284EF60
        public void Equals(){} // RVA: 0x7FFE86857ED0
        public void GetHashCode(){} // RVA: 0x7FFE82C33000
        public void get_State(){} // RVA: 0x7FFE82C33000
    }

    public class SurrogateForCyclicalReference : Object
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFE8684BEC0
        public void SetObjectData(){} // RVA: 0x7FFE8684BFB0
    }

    public class TypeLoadExceptionHolder : Object
    {
        public string m_typeName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_TypeName(){} // RVA: 0x7FFE81116380
    }

    public class ValueTypeFixupInfo : Object
    {
        public long _containerID; // 0x10
        public System.Reflection.FieldInfo _parentField; // 0x18
        public int[] _parentIndex; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868490F0
        public void get_ContainerID(){} // RVA: 0x7FFE81116380
        public void get_ParentField(){} // RVA: 0x7FFE810FE7C0
        public void get_ParentIndex(){} // RVA: 0x7FFE811290C0
    }

}