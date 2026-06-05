// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization
// Classes: 45
// Methods: 294

namespace ThirdParty.DotNet.System.Runtime.Serialization
{
    public class DataContractAttribute
    {
        // ── Methods ──
        public void get_IsReference(){} // RVA: 0x7FFAF2E575E0
    }

    public class DataMemberAttribute
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Order(){} // RVA: 0x7FFAF306ED50
        public void get_IsRequired(){} // RVA: 0x7FFAF2DA8390
        public void get_EmitDefaultValue(){} // RVA: 0x7FFAF4648300
    }

    public class DeserializationEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E0D190
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class EnumMemberAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Value(){} // RVA: 0x7FFAF2DA8380
        public void set_Value(){} // RVA: 0x7FFAF3415E90
    }

    public class FixupHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C0A20
    }

    public class FixupHolderList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C0B20 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF87C0BC0
        public void EnlargeArray(){} // RVA: 0x7FFAF87C0C60
    }

    public class FormatterConverter
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFAF87B68C0
        public void ToBoolean(){} // RVA: 0x7FFAF87B6970
        public void ToByte(){} // RVA: 0x7FFAF87B6A10
        public void ToInt16(){} // RVA: 0x7FFAF87B6AB0
        public void ToInt32(){} // RVA: 0x7FFAF87B6B50
        public void ToUInt32(){} // RVA: 0x7FFAF87B6BF0
        public void ToInt64(){} // RVA: 0x7FFAF87B6C90
        public void ToSingle(){} // RVA: 0x7FFAF87B6D30
        public void ToString(){} // RVA: 0x7FFAF87B6DD0
        public void ThrowValueNullException(){} // RVA: 0x7FFAF87B6E70
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class FormatterServices
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF87B84D0
        public void GetSerializableMembers(){} // RVA: 0x7FFAF87B9580 | overloaded x2
        public void CheckSerializable(){} // RVA: 0x7FFAF87B8960
        public void InternalGetSerializableMembers(){} // RVA: 0x7FFAF87B8990
        public void GetParentTypes(){} // RVA: 0x7FFAF87B9100
        public void GetUninitializedObject(){} // RVA: 0x7FFAF87B9900
        public void nativeGetUninitializedObject(){} // RVA: 0x7FFAF87A08C0
        public void GetEnableUnsafeTypeForwarders(){} // RVA: 0x7FFAF2D8D320
        public void UnsafeTypeForwardersIsEnabled(){} // RVA: 0x7FFAF87B9B00
        public void SerializationSetValue(){} // RVA: 0x7FFAF87B9BD0
        public void PopulateObjectMembers(){} // RVA: 0x7FFAF87B9E20
        public void GetObjectData(){} // RVA: 0x7FFAF87BA1F0
        public void GetTypeFromAssembly(){} // RVA: 0x7FFAF87BA600
        public void LoadAssemblyFromString(){} // RVA: 0x7FFAF87BA680
        public void LoadAssemblyFromStringNoThrow(){} // RVA: 0x7FFAF87BA6E0
        public void GetClrAssemblyName(){} // RVA: 0x7FFAF87BA780
        public void GetClrTypeFullName(){} // RVA: 0x7FFAF87BA930
        public void GetClrTypeFullNameForArray(){} // RVA: 0x7FFAF87BA9C0
        public void GetClrTypeFullNameForNonArrayTypes(){} // RVA: 0x7FFAF87BAC40
    }

    public class IDeserializationCallback
    {
        // ── Methods ──
        public void OnDeserialization(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IFormatter
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x7FFAF2ABCE10
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
        public void set_SurrogateSelector(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IFormatterConverter
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x7FFAF2ACE6A0
        public void ToBoolean(){} // RVA: 0x7FFAF2ABDE40
        public void ToByte(){} // RVA: 0x7FFAF2ABDE40
        public void ToInt16(){} // RVA: 0x7FFAF2AC34B0
        public void ToInt32(){} // RVA: 0x7FFAF2AC2590
        public void ToUInt32(){} // RVA: 0x7FFAF2AC2590
        public void ToInt64(){} // RVA: 0x7FFAF2ABCE10
        public void ToSingle(){} // RVA: 0x7FFAF2AD1FA0
        public void ToString(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IObjectReference
    {
        // ── Methods ──
        public void GetRealObject(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ISafeSerializationData
    {
        // ── Methods ──
        public void CompleteDeserialization(){} // RVA: 0x7FFAF2AD4B10
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
        public void ChainSelector(){} // RVA: 0x7FFAF2AD4B10
        public void GetSurrogate(){}
    }

    public class IgnoreDataMemberAttribute
    {
    }

    public class LongList
    {
        public object Version;
        public object Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C0EF0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF87C0F90
        public void get_Count(){} // RVA: 0x7FFAF306ED50
        public void StartEnumeration(){} // RVA: 0x7FFAF5993B40
        public void MoveNext(){} // RVA: 0x7FFAF87C0FF0
        public void get_Current(){} // RVA: 0x7FFAF87C1040
        public void RemoveElement(){} // RVA: 0x7FFAF87C1070
        public void EnlargeArray(){} // RVA: 0x7FFAF87C10F0
    }

    public class MemberHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6EE8840
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
        public void Equals(){} // RVA: 0x7FFAF87B6EC0
    }

    public class ObjectHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87BFC10 | overloaded x3
        public void IncrementDescendentFixups(){} // RVA: 0x7FFAF87BFEC0
        public void DecrementFixupsRemaining(){} // RVA: 0x7FFAF87BFED0
        public void RemoveDependency(){} // RVA: 0x7FFAF87BFF30
        public void AddFixup(){} // RVA: 0x7FFAF87BFFA0
        public void UpdateDescendentDependencyChain(){} // RVA: 0x7FFAF87C0160
        public void AddDependency(){} // RVA: 0x7FFAF87C01C0
        public void UpdateData(){} // RVA: 0x7FFAF87C0360
        public void MarkForCompletionWhenAvailable(){} // RVA: 0x7FFAF2F460C0
        public void SetFlags(){} // RVA: 0x7FFAF87C05D0
        public void get_IsIncompleteObjectReference(){} // RVA: 0x7FFAF8778960
        public void set_IsIncompleteObjectReference(){} // RVA: 0x7FFAF87C0670
        public void get_RequiresDelayedFixup(){} // RVA: 0x7FFAF87C0690
        public void get_RequiresValueTypeFixup(){} // RVA: 0x7FFAF87C06A0
        public void get_ValueTypeFixupPerformed(){} // RVA: 0x7FFAF87C06B0
        public void set_ValueTypeFixupPerformed(){} // RVA: 0x7FFAF87C06E0
        public void get_HasISerializable(){} // RVA: 0x7FFAF8778930
        public void get_HasSurrogate(){} // RVA: 0x7FFAF87C06F0
        public void get_CanSurrogatedObjectValueChange(){} // RVA: 0x7FFAF87C0700
        public void get_CanObjectValueChange(){} // RVA: 0x7FFAF87C07A0
        public void get_DirectlyDependentObjects(){} // RVA: 0x7FFAF3210030
        public void get_TotalDependentObjects(){} // RVA: 0x7FFAF86F2B20
        public void get_Reachable(){} // RVA: 0x7FFAF2E55570
        public void set_Reachable(){} // RVA: 0x7FFAF2E55580
        public void get_TypeLoadExceptionReachable(){} // RVA: 0x7FFAF47C10B0
        public void get_TypeLoadException(){} // RVA: 0x7FFAF2E2B370
        public void set_TypeLoadException(){} // RVA: 0x7FFAF2E2B380
        public void get_ObjectValue(){} // RVA: 0x7FFAF2DA8380
        public void SetObjectValue(){} // RVA: 0x7FFAF87C07C0
        public void get_SerializationInfo(){} // RVA: 0x7FFAF2DBB130
        public void set_SerializationInfo(){} // RVA: 0x7FFAF2D8EE90
        public void get_Surrogate(){} // RVA: 0x7FFAF30E74D0
        public void get_DependentObjects(){} // RVA: 0x7FFAF2E0A740
        public void set_DependentObjects(){} // RVA: 0x7FFAF2DB5200
        public void get_RequiresSerInfoFixup(){} // RVA: 0x7FFAF87C09A0
        public void set_RequiresSerInfoFixup(){} // RVA: 0x7FFAF87C09C0
        public void get_ValueFixup(){} // RVA: 0x7FFAF2E55500
        public void get_CompletelyFixed(){} // RVA: 0x7FFAF87C09E0
        public void get_ContainerID(){} // RVA: 0x7FFAF87C0A00
    }

    public class ObjectHolderList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C1380 | overloaded x2
        public void Add(){} // RVA: 0x7FFAF87C1420
        public void GetFixupEnumerator(){} // RVA: 0x7FFAF87C1480
        public void EnlargeArray(){} // RVA: 0x7FFAF87C1530
        public void get_Version(){} // RVA: 0x7FFAF306ED50
        public void get_Count(){} // RVA: 0x7FFAF306ED50
    }

    public class ObjectHolderListEnumerator
    {
        public object TypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C1720
        public void MoveNext(){} // RVA: 0x7FFAF87C17A0
        public void get_Current(){} // RVA: 0x7FFAF87C1850
    }

    public class ObjectIDGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87BB150
        public void FindElement(){} // RVA: 0x7FFAF87BB2D0
        public void GetId(){} // RVA: 0x7FFAF87BB390
        public void HasId(){} // RVA: 0x7FFAF87BB520
        public void Rehash(){} // RVA: 0x7FFAF87BB600
        public void .cctor(){} // RVA: 0x7FFAF87BB980
    }

    public class ObjectManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87BBA60
        public void CanCallGetType(){} // RVA: 0x7FFAF2E72850
        public void set_TopObject(){} // RVA: 0x7FFAF2D8EE90
        public void get_TopObject(){} // RVA: 0x7FFAF2DBB130
        public void get_SpecialFixupObjects(){} // RVA: 0x7FFAF87BBBC0
        public void FindObjectHolder(){} // RVA: 0x7FFAF87BBD00
        public void FindOrCreateObjectHolder(){} // RVA: 0x7FFAF87BBD50
        public void AddObjectHolder(){} // RVA: 0x7FFAF87BBE30
        public void GetCompletionInfo(){} // RVA: 0x7FFAF87BC0E0
        public void FixupSpecialObject(){} // RVA: 0x7FFAF87BC550
        public void ResolveObjectReference(){} // RVA: 0x7FFAF87BC8B0
        public void DoValueTypeFixup(){} // RVA: 0x7FFAF87BCAF0
        public void CompleteObject(){} // RVA: 0x7FFAF87BD020
        public void DoNewlyRegisteredObjectFixups(){} // RVA: 0x7FFAF87BDAF0
        public void GetObject(){} // RVA: 0x7FFAF87BDC80
        public void RegisterString(){} // RVA: 0x7FFAF87BDD70
        public void RegisterObject(){} // RVA: 0x7FFAF87BDE80
        public void CompleteISerializableObject(){} // RVA: 0x7FFAF87BE490
        public void GetConstructor(){} // RVA: 0x7FFAF87BE6F0
        public void DoFixups(){} // RVA: 0x7FFAF87BE810
        public void RegisterFixup(){} // RVA: 0x7FFAF87BECC0
        public void RecordFixup(){} // RVA: 0x7FFAF87BEDC0
        public void RecordDelayedFixup(){} // RVA: 0x7FFAF87BF0D0
        public void RecordArrayElementFixup(){} // RVA: 0x7FFAF87BF250
        public void RaiseDeserializationEvent(){} // RVA: 0x7FFAF87BF3D0
        public void AddOnDeserialization(){} // RVA: 0x7FFAF87BF430
        public void AddOnDeserialized(){} // RVA: 0x7FFAF87BF520
        public void RaiseOnDeserializedEvent(){} // RVA: 0x7FFAF87BF610
        public void RaiseOnDeserializingEvent(){} // RVA: 0x7FFAF87BF6E0
    }

    public class OnDeserializedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OnDeserializingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OnSerializedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OnSerializingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class OptionalFieldAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45A9470
        public void set_VersionAdded(){} // RVA: 0x7FFAF87C2D10
    }

    public class SafeSerializationEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C1890
        public void get_SerializedStates(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class SafeSerializationManager
    {
        // ── Methods ──
        public void add_SerializeObjectState(){} // RVA: 0x7FFAF87C19E0
        public void remove_SerializeObjectState(){} // RVA: 0x7FFAF87C1AE0
        public void .ctor(){} // RVA: 0x7FFAF87C1BE0 | overloaded x2
        public void get_IsActive(){} // RVA: 0x7FFAF7C055E0
        public void CompleteSerialization(){} // RVA: 0x7FFAF87C1F20
        public void CompleteDeserialization(){} // RVA: 0x7FFAF87C2310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF87C25D0
        public void System.Runtime.Serialization.IObjectReference.GetRealObject(){} // RVA: 0x7FFAF87C2770
        public void OnDeserialized(){} // RVA: 0x7FFAF87C2BF0
    }

    public class SerializationBinder
    {
        // ── Methods ──
        public void BindToName(){} // RVA: 0x7FFAF87B6F40
        public void BindToType(){} // RVA: 0x7FFAF2ACE6A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SerializationEntry
    {
        public object System.Collections.IEnumerator.Current;
        public object Current;
        public object Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4488110
        public void get_Value(){} // RVA: 0x7FFAF44189C0
        public void get_Name(){} // RVA: 0x7FFAF4584690
        public void get_ObjectType(){} // RVA: 0x7FFAF2DA8380
    }

    public class SerializationEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5669A20
        public void Invoke(){} // RVA: 0x7FFAF5669AF0
    }

    public class SerializationEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87B6FF0
        public void GetMethodsWithAttribute(){} // RVA: 0x7FFAF87B7390
        public void get_HasOnSerializingEvents(){} // RVA: 0x7FFAF87B75C0
        public void InvokeOnSerializing(){} // RVA: 0x7FFAF87B75E0
        public void InvokeOnDeserializing(){} // RVA: 0x7FFAF87B7630
        public void InvokeOnDeserialized(){} // RVA: 0x7FFAF87B7680
        public void AddOnSerialized(){} // RVA: 0x7FFAF87B76D0
        public void AddOnDeserialized(){} // RVA: 0x7FFAF87B76F0
        public void InvokeOnDelegate(){} // RVA: 0x7FFAF87B7710
        public void AddOnDelegate(){} // RVA: 0x7FFAF87B7750
    }

    public class SerializationEventsCache
    {
        // ── Methods ──
        public void GetSerializationEventsForType(){} // RVA: 0x7FFAF87B79E0
        public void .cctor(){} // RVA: 0x7FFAF87B7B90
    }

    public class SerializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x4
        public void .cctor(){} // RVA: 0x7FFAF87B63B0
    }

    public class SerializationFieldInfo
    {
        // ── Methods ──
        public void get_Module(){} // RVA: 0x7FFAF441F280
        public void get_MetadataToken(){} // RVA: 0x7FFAF32A02B0
        public void .ctor(){} // RVA: 0x7FFAF87C2D90
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void get_DeclaringType(){} // RVA: 0x7FFAF87C2EC0
        public void get_ReflectedType(){} // RVA: 0x7FFAF87C2EF0
        public void GetCustomAttributes(){} // RVA: 0x7FFAF87C2F50 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFAF32A0510
        public void get_FieldType(){} // RVA: 0x7FFAF32A0370
        public void GetValue(){} // RVA: 0x7FFAF819FBB0
        public void InternalGetValue(){} // RVA: 0x7FFAF87C2F80
        public void SetValue(){} // RVA: 0x7FFAF87C2FE0
        public void InternalSetValue(){} // RVA: 0x7FFAF87C3020
        public void get_FieldInfo(){} // RVA: 0x7FFAF2DA8380
        public void get_FieldHandle(){} // RVA: 0x7FFAF87C30A0
        public void get_Attributes(){} // RVA: 0x7FFAF32A0150
    }

    public class SerializationInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C30F0 | overloaded x2
        public void get_FullTypeName(){} // RVA: 0x7FFAF2E0A740
        public void get_AssemblyName(){} // RVA: 0x7FFAF2E08730
        public void SetType(){} // RVA: 0x7FFAF87C3570
        public void Compare(){} // RVA: 0x7FFAF87C37F0
        public void DemandForUnsafeAssemblyNameAssignments(){} // RVA: 0x7FFAF87C3870
        public void IsAssemblyNameAssignmentSafe(){} // RVA: 0x7FFAF87C3880
        public void get_MemberCount(){} // RVA: 0x7FFAF2DE8CD0
        public void get_ObjectType(){} // RVA: 0x7FFAF2E2E0E0
        public void get_IsFullTypeNameSetExplicit(){} // RVA: 0x7FFAF304FF30
        public void get_IsAssemblyNameSetExplicit(){} // RVA: 0x7FFAF7A94B90
        public void GetEnumerator(){} // RVA: 0x7FFAF87C3B50
        public void ExpandArrays(){} // RVA: 0x7FFAF87C3CD0
        public void AddValue(){} // RVA: 0x7FFAF87C5800 | overloaded x14
        public void AddValueInternal(){} // RVA: 0x7FFAF87C59C0
        public void UpdateValue(){} // RVA: 0x7FFAF87C5BC0
        public void FindElement(){} // RVA: 0x7FFAF87C5CC0
        public void GetElement(){} // RVA: 0x7FFAF87C5DC0
        public void GetElementNoThrow(){} // RVA: 0x7FFAF87C5F20
        public void GetValue(){} // RVA: 0x7FFAF87C6050
        public void GetValueNoThrow(){} // RVA: 0x7FFAF87C6230
        public void GetBoolean(){} // RVA: 0x7FFAF87C6410
        public void GetByte(){} // RVA: 0x7FFAF87C6570
        public void GetInt16(){} // RVA: 0x7FFAF87C66D0
        public void GetInt32(){} // RVA: 0x7FFAF87C6830
        public void GetUInt32(){} // RVA: 0x7FFAF87C6990
        public void GetInt64(){} // RVA: 0x7FFAF87C6AF0
        public void GetSingle(){} // RVA: 0x7FFAF87C6C50
        public void GetString(){} // RVA: 0x7FFAF87C6DB0
    }

    public class SerializationInfoEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87B6460
        public void MoveNext(){} // RVA: 0x7FFAF87B6580
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF87B65A0
        public void get_Current(){} // RVA: 0x7FFAF87B6610
        public void Reset(){} // RVA: 0x7FFAF87B6700
        public void get_Name(){} // RVA: 0x7FFAF87B6710
        public void get_Value(){} // RVA: 0x7FFAF87B67A0
        public void get_ObjectType(){} // RVA: 0x7FFAF87B6830
    }

    public class SerializationObjectManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87B7D70
        public void RegisterObject(){} // RVA: 0x7FFAF87B7EA0
        public void RaiseOnSerializedEvent(){} // RVA: 0x7FFAF87B80C0
        public void AddOnSerialized(){} // RVA: 0x7FFAF87B8100
    }

    public class StreamingContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C6F70 | overloaded x2
        public void get_Context(){} // RVA: 0x7FFAF4584690
        public void Equals(){} // RVA: 0x7FFAF87C6FD0
        public void GetHashCode(){} // RVA: 0x7FFAF4959890
        public void get_State(){} // RVA: 0x7FFAF4959890
    }

    public class SurrogateForCyclicalReference
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFAF87BAFC0
        public void SetObjectData(){} // RVA: 0x7FFAF87BB0B0
    }

    public class TypeLoadExceptionHolder
    {
        public object SerializedStates;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_TypeName(){} // RVA: 0x7FFAF2DA8380
    }

    public class ValueTypeFixupInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87B81F0
        public void get_ContainerID(){} // RVA: 0x7FFAF2DA8380
        public void get_ParentField(){} // RVA: 0x7FFAF2D907C0
        public void get_ParentIndex(){} // RVA: 0x7FFAF2DBB0C0
    }

}