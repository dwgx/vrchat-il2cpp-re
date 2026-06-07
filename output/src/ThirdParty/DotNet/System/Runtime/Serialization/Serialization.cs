// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization
// Classes: 45
// Methods: 294

namespace ThirdParty.DotNet.System.Runtime.Serialization
{
    public class DataContractAttribute
    {
        // ── Methods ──
        public void get_IsReference(){} // RVA: 0x3A75E0
    }

    public class DataMemberAttribute
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Order(){} // RVA: 0x5BED50
        public void get_IsRequired(){} // RVA: 0x2F8390
        public void get_EmitDefaultValue(){} // RVA: 0x1B98300
    }

    public class DeserializationEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35D190
        public void Invoke(){} // RVA: 0x338C60
    }

    public class EnumMemberAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x965E90
    }

    public class FixupHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D10A20
    }

    public class FixupHolderList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D10B20 | overloaded x2
        public void Add(){} // RVA: 0x5D10BC0
        public void EnlargeArray(){} // RVA: 0x5D10C60
    }

    public class FormatterConverter
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x5D068C0
        public void ToBoolean(){} // RVA: 0x5D06970
        public void ToByte(){} // RVA: 0x5D06A10
        public void ToInt16(){} // RVA: 0x5D06AB0
        public void ToInt32(){} // RVA: 0x5D06B50
        public void ToUInt32(){} // RVA: 0x5D06BF0
        public void ToInt64(){} // RVA: 0x5D06C90
        public void ToSingle(){} // RVA: 0x5D06D30
        public void ToString(){} // RVA: 0x5D06DD0
        public void ThrowValueNullException(){} // RVA: 0x5D06E70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class FormatterServices
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5D084D0
        public void GetSerializableMembers(){} // RVA: 0x5D09580 | overloaded x2
        public void CheckSerializable(){} // RVA: 0x5D08960
        public void InternalGetSerializableMembers(){} // RVA: 0x5D08990
        public void GetParentTypes(){} // RVA: 0x5D09100
        public void GetUninitializedObject(){} // RVA: 0x5D09900
        public void nativeGetUninitializedObject(){} // RVA: 0x5CF08C0
        public void GetEnableUnsafeTypeForwarders(){} // RVA: 0x2DD320
        public void UnsafeTypeForwardersIsEnabled(){} // RVA: 0x5D09B00
        public void SerializationSetValue(){} // RVA: 0x5D09BD0
        public void PopulateObjectMembers(){} // RVA: 0x5D09E20
        public void GetObjectData(){} // RVA: 0x5D0A1F0
        public void GetTypeFromAssembly(){} // RVA: 0x5D0A600
        public void LoadAssemblyFromString(){} // RVA: 0x5D0A680
        public void LoadAssemblyFromStringNoThrow(){} // RVA: 0x5D0A6E0
        public void GetClrAssemblyName(){} // RVA: 0x5D0A780
        public void GetClrTypeFullName(){} // RVA: 0x5D0A930
        public void GetClrTypeFullNameForArray(){} // RVA: 0x5D0A9C0
        public void GetClrTypeFullNameForNonArrayTypes(){} // RVA: 0x5D0AC40
    }

    public class IDeserializationCallback
    {
        // ── Methods ──
        public void OnDeserialization(){} // RVA: 0x24B10
    }

    public class IFormatter
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0xCE10
        public void Serialize(){} // RVA: 0x2DC60
        public void set_SurrogateSelector(){} // RVA: 0x24B10
    }

    public class IFormatterConverter
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x1E6A0
        public void ToBoolean(){} // RVA: 0xDE40
        public void ToByte(){} // RVA: 0xDE40
        public void ToInt16(){} // RVA: 0x134B0
        public void ToInt32(){} // RVA: 0x12590
        public void ToUInt32(){} // RVA: 0x12590
        public void ToInt64(){} // RVA: 0xCE10
        public void ToSingle(){} // RVA: 0x21FA0
        public void ToString(){} // RVA: 0xCE10
    }

    public class IObjectReference
    {
        // ── Methods ──
        public void GetRealObject(){} // RVA: 0xCE10
    }

    public class ISafeSerializationData
    {
        // ── Methods ──
        public void CompleteDeserialization(){} // RVA: 0x24B10
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
        public void ChainSelector(){} // RVA: 0x24B10
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
        public void .ctor(){} // RVA: 0x5D10EF0 | overloaded x2
        public void Add(){} // RVA: 0x5D10F90
        public void get_Count(){} // RVA: 0x5BED50
        public void StartEnumeration(){} // RVA: 0x2EE3B40
        public void MoveNext(){} // RVA: 0x5D10FF0
        public void get_Current(){} // RVA: 0x5D11040
        public void RemoveElement(){} // RVA: 0x5D11070
        public void EnlargeArray(){} // RVA: 0x5D110F0
    }

    public class MemberHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4438840
        public void GetHashCode(){} // RVA: 0x99E0E0
        public void Equals(){} // RVA: 0x5D06EC0
    }

    public class ObjectHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D0FC10 | overloaded x3
        public void IncrementDescendentFixups(){} // RVA: 0x5D0FEC0
        public void DecrementFixupsRemaining(){} // RVA: 0x5D0FED0
        public void RemoveDependency(){} // RVA: 0x5D0FF30
        public void AddFixup(){} // RVA: 0x5D0FFA0
        public void UpdateDescendentDependencyChain(){} // RVA: 0x5D10160
        public void AddDependency(){} // RVA: 0x5D101C0
        public void UpdateData(){} // RVA: 0x5D10360
        public void MarkForCompletionWhenAvailable(){} // RVA: 0x4960C0
        public void SetFlags(){} // RVA: 0x5D105D0
        public void get_IsIncompleteObjectReference(){} // RVA: 0x5CC8960
        public void set_IsIncompleteObjectReference(){} // RVA: 0x5D10670
        public void get_RequiresDelayedFixup(){} // RVA: 0x5D10690
        public void get_RequiresValueTypeFixup(){} // RVA: 0x5D106A0
        public void get_ValueTypeFixupPerformed(){} // RVA: 0x5D106B0
        public void set_ValueTypeFixupPerformed(){} // RVA: 0x5D106E0
        public void get_HasISerializable(){} // RVA: 0x5CC8930
        public void get_HasSurrogate(){} // RVA: 0x5D106F0
        public void get_CanSurrogatedObjectValueChange(){} // RVA: 0x5D10700
        public void get_CanObjectValueChange(){} // RVA: 0x5D107A0
        public void get_DirectlyDependentObjects(){} // RVA: 0x760030
        public void get_TotalDependentObjects(){} // RVA: 0x5C42B20
        public void get_Reachable(){} // RVA: 0x3A5570
        public void set_Reachable(){} // RVA: 0x3A5580
        public void get_TypeLoadExceptionReachable(){} // RVA: 0x1D110B0
        public void get_TypeLoadException(){} // RVA: 0x37B370
        public void set_TypeLoadException(){} // RVA: 0x37B380
        public void get_ObjectValue(){} // RVA: 0x2F8380
        public void SetObjectValue(){} // RVA: 0x5D107C0
        public void get_SerializationInfo(){} // RVA: 0x30B130
        public void set_SerializationInfo(){} // RVA: 0x2DEE90
        public void get_Surrogate(){} // RVA: 0x6374D0
        public void get_DependentObjects(){} // RVA: 0x35A740
        public void set_DependentObjects(){} // RVA: 0x305200
        public void get_RequiresSerInfoFixup(){} // RVA: 0x5D109A0
        public void set_RequiresSerInfoFixup(){} // RVA: 0x5D109C0
        public void get_ValueFixup(){} // RVA: 0x3A5500
        public void get_CompletelyFixed(){} // RVA: 0x5D109E0
        public void get_ContainerID(){} // RVA: 0x5D10A00
    }

    public class ObjectHolderList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D11380 | overloaded x2
        public void Add(){} // RVA: 0x5D11420
        public void GetFixupEnumerator(){} // RVA: 0x5D11480
        public void EnlargeArray(){} // RVA: 0x5D11530
        public void get_Version(){} // RVA: 0x5BED50
        public void get_Count(){} // RVA: 0x5BED50
    }

    public class ObjectHolderListEnumerator
    {
        public object TypeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D11720
        public void MoveNext(){} // RVA: 0x5D117A0
        public void get_Current(){} // RVA: 0x5D11850
    }

    public class ObjectIDGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D0B150
        public void FindElement(){} // RVA: 0x5D0B2D0
        public void GetId(){} // RVA: 0x5D0B390
        public void HasId(){} // RVA: 0x5D0B520
        public void Rehash(){} // RVA: 0x5D0B600
        public void .cctor(){} // RVA: 0x5D0B980
    }

    public class ObjectManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D0BA60
        public void CanCallGetType(){} // RVA: 0x3C2850
        public void set_TopObject(){} // RVA: 0x2DEE90
        public void get_TopObject(){} // RVA: 0x30B130
        public void get_SpecialFixupObjects(){} // RVA: 0x5D0BBC0
        public void FindObjectHolder(){} // RVA: 0x5D0BD00
        public void FindOrCreateObjectHolder(){} // RVA: 0x5D0BD50
        public void AddObjectHolder(){} // RVA: 0x5D0BE30
        public void GetCompletionInfo(){} // RVA: 0x5D0C0E0
        public void FixupSpecialObject(){} // RVA: 0x5D0C550
        public void ResolveObjectReference(){} // RVA: 0x5D0C8B0
        public void DoValueTypeFixup(){} // RVA: 0x5D0CAF0
        public void CompleteObject(){} // RVA: 0x5D0D020
        public void DoNewlyRegisteredObjectFixups(){} // RVA: 0x5D0DAF0
        public void GetObject(){} // RVA: 0x5D0DC80
        public void RegisterString(){} // RVA: 0x5D0DD70
        public void RegisterObject(){} // RVA: 0x5D0DE80
        public void CompleteISerializableObject(){} // RVA: 0x5D0E490
        public void GetConstructor(){} // RVA: 0x5D0E6F0
        public void DoFixups(){} // RVA: 0x5D0E810
        public void RegisterFixup(){} // RVA: 0x5D0ECC0
        public void RecordFixup(){} // RVA: 0x5D0EDC0
        public void RecordDelayedFixup(){} // RVA: 0x5D0F0D0
        public void RecordArrayElementFixup(){} // RVA: 0x5D0F250
        public void RaiseDeserializationEvent(){} // RVA: 0x5D0F3D0
        public void AddOnDeserialization(){} // RVA: 0x5D0F430
        public void AddOnDeserialized(){} // RVA: 0x5D0F520
        public void RaiseOnDeserializedEvent(){} // RVA: 0x5D0F610
        public void RaiseOnDeserializingEvent(){} // RVA: 0x5D0F6E0
    }

    public class OnDeserializedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OnDeserializingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OnSerializedAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OnSerializingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OptionalFieldAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AF9470
        public void set_VersionAdded(){} // RVA: 0x5D12D10
    }

    public class SafeSerializationEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D11890
        public void get_SerializedStates(){} // RVA: 0x30B0C0
    }

    public class SafeSerializationManager
    {
        // ── Methods ──
        public void add_SerializeObjectState(){} // RVA: 0x5D119E0
        public void remove_SerializeObjectState(){} // RVA: 0x5D11AE0
        public void .ctor(){} // RVA: 0x5D11BE0 | overloaded x2
        public void get_IsActive(){} // RVA: 0x51555E0
        public void CompleteSerialization(){} // RVA: 0x5D11F20
        public void CompleteDeserialization(){} // RVA: 0x5D12310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x5D125D0
        public void System.Runtime.Serialization.IObjectReference.GetRealObject(){} // RVA: 0x5D12770
        public void OnDeserialized(){} // RVA: 0x5D12BF0
    }

    public class SerializationBinder
    {
        // ── Methods ──
        public void BindToName(){} // RVA: 0x5D06F40
        public void BindToType(){} // RVA: 0x1E6A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SerializationEntry
    {
        public object System.Collections.IEnumerator.Current;
        public object Current;
        public object Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x19D8110
        public void get_Value(){} // RVA: 0x19689C0
        public void get_Name(){} // RVA: 0x1AD4690
        public void get_ObjectType(){} // RVA: 0x2F8380
    }

    public class SerializationEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BB9A20
        public void Invoke(){} // RVA: 0x2BB9AF0
    }

    public class SerializationEvents
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D06FF0
        public void GetMethodsWithAttribute(){} // RVA: 0x5D07390
        public void get_HasOnSerializingEvents(){} // RVA: 0x5D075C0
        public void InvokeOnSerializing(){} // RVA: 0x5D075E0
        public void InvokeOnDeserializing(){} // RVA: 0x5D07630
        public void InvokeOnDeserialized(){} // RVA: 0x5D07680
        public void AddOnSerialized(){} // RVA: 0x5D076D0
        public void AddOnDeserialized(){} // RVA: 0x5D076F0
        public void InvokeOnDelegate(){} // RVA: 0x5D07710
        public void AddOnDelegate(){} // RVA: 0x5D07750
    }

    public class SerializationEventsCache
    {
        // ── Methods ──
        public void GetSerializationEventsForType(){} // RVA: 0x5D079E0
        public void .cctor(){} // RVA: 0x5D07B90
    }

    public class SerializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x4
        public void .cctor(){} // RVA: 0x5D063B0
    }

    public class SerializationFieldInfo
    {
        // ── Methods ──
        public void get_Module(){} // RVA: 0x196F280
        public void get_MetadataToken(){} // RVA: 0x7F02B0
        public void .ctor(){} // RVA: 0x5D12D90
        public void get_Name(){} // RVA: 0x2E07C0
        public void get_DeclaringType(){} // RVA: 0x5D12EC0
        public void get_ReflectedType(){} // RVA: 0x5D12EF0
        public void GetCustomAttributes(){} // RVA: 0x5D12F50 | overloaded x2
        public void IsDefined(){} // RVA: 0x7F0510
        public void get_FieldType(){} // RVA: 0x7F0370
        public void GetValue(){} // RVA: 0x56EFBB0
        public void InternalGetValue(){} // RVA: 0x5D12F80
        public void SetValue(){} // RVA: 0x5D12FE0
        public void InternalSetValue(){} // RVA: 0x5D13020
        public void get_FieldInfo(){} // RVA: 0x2F8380
        public void get_FieldHandle(){} // RVA: 0x5D130A0
        public void get_Attributes(){} // RVA: 0x7F0150
    }

    public class SerializationInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D130F0 | overloaded x2
        public void get_FullTypeName(){} // RVA: 0x35A740
        public void get_AssemblyName(){} // RVA: 0x358730
        public void SetType(){} // RVA: 0x5D13570
        public void Compare(){} // RVA: 0x5D137F0
        public void DemandForUnsafeAssemblyNameAssignments(){} // RVA: 0x5D13870
        public void IsAssemblyNameAssignmentSafe(){} // RVA: 0x5D13880
        public void get_MemberCount(){} // RVA: 0x338CD0
        public void get_ObjectType(){} // RVA: 0x37E0E0
        public void get_IsFullTypeNameSetExplicit(){} // RVA: 0x59FF30
        public void get_IsAssemblyNameSetExplicit(){} // RVA: 0x4FE4B90
        public void GetEnumerator(){} // RVA: 0x5D13B50
        public void ExpandArrays(){} // RVA: 0x5D13CD0
        public void AddValue(){} // RVA: 0x5D15800 | overloaded x14
        public void AddValueInternal(){} // RVA: 0x5D159C0
        public void UpdateValue(){} // RVA: 0x5D15BC0
        public void FindElement(){} // RVA: 0x5D15CC0
        public void GetElement(){} // RVA: 0x5D15DC0
        public void GetElementNoThrow(){} // RVA: 0x5D15F20
        public void GetValue(){} // RVA: 0x5D16050
        public void GetValueNoThrow(){} // RVA: 0x5D16230
        public void GetBoolean(){} // RVA: 0x5D16410
        public void GetByte(){} // RVA: 0x5D16570
        public void GetInt16(){} // RVA: 0x5D166D0
        public void GetInt32(){} // RVA: 0x5D16830
        public void GetUInt32(){} // RVA: 0x5D16990
        public void GetInt64(){} // RVA: 0x5D16AF0
        public void GetSingle(){} // RVA: 0x5D16C50
        public void GetString(){} // RVA: 0x5D16DB0
    }

    public class SerializationInfoEnumerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D06460
        public void MoveNext(){} // RVA: 0x5D06580
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x5D065A0
        public void get_Current(){} // RVA: 0x5D06610
        public void Reset(){} // RVA: 0x5D06700
        public void get_Name(){} // RVA: 0x5D06710
        public void get_Value(){} // RVA: 0x5D067A0
        public void get_ObjectType(){} // RVA: 0x5D06830
    }

    public class SerializationObjectManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D07D70
        public void RegisterObject(){} // RVA: 0x5D07EA0
        public void RaiseOnSerializedEvent(){} // RVA: 0x5D080C0
        public void AddOnSerialized(){} // RVA: 0x5D08100
    }

    public class StreamingContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D16F70 | overloaded x2
        public void get_Context(){} // RVA: 0x1AD4690
        public void Equals(){} // RVA: 0x5D16FD0
        public void GetHashCode(){} // RVA: 0x1EA9890
        public void get_State(){} // RVA: 0x1EA9890
    }

    public class SurrogateForCyclicalReference
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x5D0AFC0
        public void SetObjectData(){} // RVA: 0x5D0B0B0
    }

    public class TypeLoadExceptionHolder
    {
        public object SerializedStates;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_TypeName(){} // RVA: 0x2F8380
    }

    public class ValueTypeFixupInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D081F0
        public void get_ContainerID(){} // RVA: 0x2F8380
        public void get_ParentField(){} // RVA: 0x2E07C0
        public void get_ParentIndex(){} // RVA: 0x30B0C0
    }

}