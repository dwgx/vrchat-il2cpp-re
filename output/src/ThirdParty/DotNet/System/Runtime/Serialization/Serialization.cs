// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Serialization
// Classes: 50
// Methods: 358

namespace ThirdParty.DotNet.System.Runtime.Serialization
{
    public class DataContractAttribute : Attribute
    {
        public object isReference;

        // ── Methods ──
        public void get_IsReference(){} // RVA: 0xC120A0
    }

    public class DataContractAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DataMemberAttribute : Attribute
    {
        public object name;
        public object order;
        public object isRequired;
        public object emitDefaultValue;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Order(){} // RVA: 0xE62D00
        public void get_IsRequired(){} // RVA: 0xB5DC00
        public void get_EmitDefaultValue(){} // RVA: 0x246F120
    }

    public class DeserializationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class EnumMemberAttribute : Attribute
    {
        public object value;
        public object isValueSetExplicitly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0x12306B0
    }

    public class EnumMemberAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FixupHolder : Object
    {
        public object m_id;
        public object m_fixupInfo;
        public object m_fixupType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6789DC0
    }

    public class FixupHolderList : Object
    {
        public object m_values;
        public object m_count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6789EC0
        public void Add(){} // RVA: 0x6789F60
        public void EnlargeArray(){} // RVA: 0x678A000
    }

    public class FixupHolder[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class FormatterConverter : Object
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x677FC10
        public void ToBoolean(){} // RVA: 0x677FCC0
        public void ToByte(){} // RVA: 0x677FD60
        public void ToInt16(){} // RVA: 0x677FE00
        public void ToInt32(){} // RVA: 0x677FEA0
        public void ToUInt32(){} // RVA: 0x677FF40
        public void ToInt64(){} // RVA: 0x677FFE0
        public void ToSingle(){} // RVA: 0x6780080
        public void ToString(){} // RVA: 0x6780120
        public void ThrowValueNullException(){} // RVA: 0x67801C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class FormatterServices : Object
    {
        public object m_MemberInfoTable;
        public object unsafeTypeForwardersIsEnabled;
        public object unsafeTypeForwardersIsEnabledInitialized;
        public object advancedTypes;
        public object s_binder;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6781760
        public void GetSerializableMembers(){} // RVA: 0x67827E0
        public void CheckSerializable(){} // RVA: 0x6781BC0
        public void InternalGetSerializableMembers(){} // RVA: 0x6781BF0
        public void GetParentTypes(){} // RVA: 0x6782370
        public void GetUninitializedObject(){} // RVA: 0x6782B80
        public void nativeGetUninitializedObject(){} // RVA: 0x6769210
        public void GetEnableUnsafeTypeForwarders(){} // RVA: 0xB43320
        public void UnsafeTypeForwardersIsEnabled(){} // RVA: 0x6782D80
        public void SerializationSetValue(){} // RVA: 0x6782E50
        public void PopulateObjectMembers(){} // RVA: 0x6783080
        public void GetObjectData(){} // RVA: 0x6783450
        public void GetTypeFromAssembly(){} // RVA: 0x6783860
        public void LoadAssemblyFromString(){} // RVA: 0x67838E0
        public void LoadAssemblyFromStringNoThrow(){} // RVA: 0x6783940
        public void GetClrAssemblyName(){} // RVA: 0x67839E0
        public void GetClrTypeFullName(){} // RVA: 0x6783BA0
        public void GetClrTypeFullNameForArray(){} // RVA: 0x6783C30
        public void GetClrTypeFullNameForNonArrayTypes(){} // RVA: 0x6783EB0
    }

    public class IDeserializationCallback
    {
        // ── Methods ──
        public void OnDeserialization(){} // RVA: 0x894320
    }

    public class IFormatter
    {
        // ── Methods ──
        public void Deserialize(){} // RVA: 0x87C540
        public void Serialize(){} // RVA: 0x8943B0
        public void set_SurrogateSelector(){} // RVA: 0x894320
    }

    public class IFormatterConverter
    {
        // ── Methods ──
        public void Convert(){} // RVA: 0x87C5F0
        public void ToBoolean(){} // RVA: 0x87D350
        public void ToByte(){} // RVA: 0x87D350
        public void ToInt16(){} // RVA: 0x87C460
        public void ToInt32(){} // RVA: 0x87D050
        public void ToUInt32(){} // RVA: 0x87D050
        public void ToInt64(){} // RVA: 0x87C540
        public void ToSingle(){} // RVA: 0x891020
        public void ToString(){} // RVA: 0x87C540
    }

    public class IObjectReference
    {
        // ── Methods ──
        public void GetRealObject(){} // RVA: 0x87C540
    }

    public class ISafeSerializationData
    {
        // ── Methods ──
        public void CompleteDeserialization(){} // RVA: 0x894320
    }

    public class ISerializable
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x8943B0
    }

    public class ISerializationSurrogate
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x8954D0
        public void SetObjectData(){} // RVA: 0x88D2C0
    }

    public class ISurrogateSelector
    {
        // ── Methods ──
        public void ChainSelector(){} // RVA: 0x894320
        public void GetSurrogate(){} // RVA: 0x882090
    }

    public class IgnoreDataMemberAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LongList : Object
    {
        public object m_values;
        public object m_count;
        public object m_totalItems;
        public object m_currentItem;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x678A290
        public void Add(){} // RVA: 0x678A330
        public void get_Count(){} // RVA: 0xE62D00
        public void StartEnumeration(){} // RVA: 0x3928BD0
        public void MoveNext(){} // RVA: 0x678A390
        public void get_Current(){} // RVA: 0x678A3E0
        public void RemoveElement(){} // RVA: 0x678A410
        public void EnlargeArray(){} // RVA: 0x678A490
    }

    public class MemberHolder : Object
    {
        public object _memberType;
        public object _context;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F36130
        public void GetHashCode(){} // RVA: 0x1269730
        public void Equals(){} // RVA: 0x6780210
    }

    public class ObjectHolder : Object
    {
        public object m_object;
        public object m_id;
        public object m_missingElementsRemaining;
        public object m_missingDecendents;
        public object m_serInfo;
        public object m_surrogate;
        public object m_missingElements;
        public object m_dependentObjects;
        public object m_next;
        public object m_flags;
        public object m_markForFixupWhenAvailable;
        public object m_valueFixup;
        public object m_typeLoad;
        public object m_reachable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6788F80
        public void IncrementDescendentFixups(){} // RVA: 0x6789230
        public void DecrementFixupsRemaining(){} // RVA: 0x6789240
        public void RemoveDependency(){} // RVA: 0x67892A0
        public void AddFixup(){} // RVA: 0x6789320
        public void UpdateDescendentDependencyChain(){} // RVA: 0x67894E0
        public void AddDependency(){} // RVA: 0x6789540
        public void UpdateData(){} // RVA: 0x67896E0
        public void MarkForCompletionWhenAvailable(){} // RVA: 0xD04690
        public void SetFlags(){} // RVA: 0x6789950
        public void get_IsIncompleteObjectReference(){} // RVA: 0x6741F40
        public void set_IsIncompleteObjectReference(){} // RVA: 0x67899F0
        public void get_RequiresDelayedFixup(){} // RVA: 0x6789A10
        public void get_RequiresValueTypeFixup(){} // RVA: 0x6789A20
        public void get_ValueTypeFixupPerformed(){} // RVA: 0x6789A30
        public void set_ValueTypeFixupPerformed(){} // RVA: 0x6789A60
        public void get_HasISerializable(){} // RVA: 0x6741F30
        public void get_HasSurrogate(){} // RVA: 0x6789A70
        public void get_CanSurrogatedObjectValueChange(){} // RVA: 0x6789A80
        public void get_CanObjectValueChange(){} // RVA: 0x6789B40
        public void get_DirectlyDependentObjects(){} // RVA: 0xFEAE90
        public void get_TotalDependentObjects(){} // RVA: 0x66BADF0
        public void get_Reachable(){} // RVA: 0xC10030
        public void set_Reachable(){} // RVA: 0xC10040
        public void get_TypeLoadExceptionReachable(){} // RVA: 0x25BF920
        public void get_TypeLoadException(){} // RVA: 0xBE2C60
        public void set_TypeLoadException(){} // RVA: 0xBE2C70
        public void get_ObjectValue(){} // RVA: 0xB5DBF0
        public void SetObjectValue(){} // RVA: 0x6789B60
        public void get_SerializationInfo(){} // RVA: 0xB70160
        public void set_SerializationInfo(){} // RVA: 0xB44DC0
        public void get_Surrogate(){} // RVA: 0xD33E60
        public void get_DependentObjects(){} // RVA: 0xBC1B30
        public void set_DependentObjects(){} // RVA: 0xB6A8C0
        public void get_RequiresSerInfoFixup(){} // RVA: 0x6789D40
        public void set_RequiresSerInfoFixup(){} // RVA: 0x6789D60
        public void get_ValueFixup(){} // RVA: 0xC0FFC0
        public void get_CompletelyFixed(){} // RVA: 0x6789D80
        public void get_ContainerID(){} // RVA: 0x6789DA0
    }

    public class ObjectHolderList : Object
    {
        public object m_values;
        public object m_count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x678A720
        public void Add(){} // RVA: 0x678A7C0
        public void GetFixupEnumerator(){} // RVA: 0x678A820
        public void EnlargeArray(){} // RVA: 0x678A8D0
        public void get_Version(){} // RVA: 0xE62D00
        public void get_Count(){} // RVA: 0xE62D00
    }

    public class ObjectHolderListEnumerator : Object
    {
        public object m_isFixupEnumerator;
        public object m_list;
        public object m_startingVersion;
        public object m_currPos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x678AAC0
        public void MoveNext(){} // RVA: 0x678AB40
        public void get_Current(){} // RVA: 0x678ABF0
    }

    public class ObjectHolder[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ObjectIDGenerator : Object
    {
        public object m_currentCount;
        public object m_currentSize;
        public object m_ids;
        public object m_objs;
        public object sizes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67843D0
        public void FindElement(){} // RVA: 0x6784550
        public void GetId(){} // RVA: 0x6784620
        public void HasId(){} // RVA: 0x67847B0
        public void Rehash(){} // RVA: 0x6784890
        public void .cctor(){} // RVA: 0x6784C30
    }

    public class ObjectManager : Object
    {
        public object m_onDeserializationHandler;
        public object m_onDeserializedHandler;
        public object m_objects;
        public object m_topObject;
        public object m_specialFixupObjects;
        public object m_fixupCount;
        public object m_selector;
        public object m_context;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6784D10
        public void CanCallGetType(){} // RVA: 0xC2E4C0
        public void set_TopObject(){} // RVA: 0xB44DC0
        public void get_TopObject(){} // RVA: 0xB70160
        public void get_SpecialFixupObjects(){} // RVA: 0x6784E70
        public void FindObjectHolder(){} // RVA: 0x6784FB0
        public void FindOrCreateObjectHolder(){} // RVA: 0x6785000
        public void AddObjectHolder(){} // RVA: 0x67850E0
        public void GetCompletionInfo(){} // RVA: 0x6785390
        public void FixupSpecialObject(){} // RVA: 0x67857C0
        public void ResolveObjectReference(){} // RVA: 0x6785B30
        public void DoValueTypeFixup(){} // RVA: 0x6785D70
        public void CompleteObject(){} // RVA: 0x67862B0
        public void DoNewlyRegisteredObjectFixups(){} // RVA: 0x6786D50
        public void GetObject(){} // RVA: 0x6786EE0
        public void RegisterString(){} // RVA: 0x6786FD0
        public void RegisterObject(){} // RVA: 0x67870E0
        public void CompleteISerializableObject(){} // RVA: 0x67876D0
        public void GetConstructor(){} // RVA: 0x6787930
        public void DoFixups(){} // RVA: 0x6787A50
        public void RegisterFixup(){} // RVA: 0x6787EF0
        public void RecordFixup(){} // RVA: 0x6788150
        public void RecordDelayedFixup(){} // RVA: 0x6788440
        public void RecordArrayElementFixup(){} // RVA: 0x67885C0
        public void RaiseDeserializationEvent(){} // RVA: 0x6788740
        public void AddOnDeserialization(){} // RVA: 0x67887A0
        public void AddOnDeserialized(){} // RVA: 0x6788890
        public void RaiseOnDeserializedEvent(){} // RVA: 0x6788980
        public void RaiseOnDeserializingEvent(){} // RVA: 0x6788A50
    }

    public class OnDeserializedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OnDeserializingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OnSerializedAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OnSerializingAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OptionalFieldAttribute : Attribute
    {
        public object versionAdded;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E2740
        public void set_VersionAdded(){} // RVA: 0x678C070
    }

    public class SafeSerializationEventArgs : EventArgs
    {
        public object m_streamingContext;
        public object m_serializedStates;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x678AC30
        public void get_SerializedStates(){} // RVA: 0xB700F0
    }

    public class SafeSerializationManager : Object
    {
        public object m_serializedStates;
        public object m_savedSerializationInfo;
        public object m_realObject;
        public object m_realType;
        public object SerializeObjectState;

        // ── Methods ──
        public void add_SerializeObjectState(){} // RVA: 0x678AD80
        public void remove_SerializeObjectState(){} // RVA: 0x678AE90
        public void .ctor(){} // RVA: 0x678AFA0
        public void get_IsActive(){} // RVA: 0x5BC22D0
        public void CompleteSerialization(){} // RVA: 0x678B2D0
        public void CompleteDeserialization(){} // RVA: 0x678B6E0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x678B9A0
        public void System.Runtime.Serialization.IObjectReference.GetRealObject(){} // RVA: 0x678BB10
        public void OnDeserialized(){} // RVA: 0x678BF50
    }

    public class SerializationBinder : Object
    {
        // ── Methods ──
        public void BindToName(){} // RVA: 0x6780290
        public void BindToType(){} // RVA: 0x87C5F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SerializationEntry : ValueType
    {
        public object _name;
        public object _value;
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79C50
        public void get_Value(){} // RVA: 0x77ED0
        public void get_Name(){} // RVA: 0x77900
        public void get_ObjectType(){} // RVA: 0x7E450
    }

    public class SerializationEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35A76F0
        public void Invoke(){} // RVA: 0x35A77C0
    }

    public class SerializationEvents : Object
    {
        public object _onSerializingMethods;
        public object _onSerializedMethods;
        public object _onDeserializingMethods;
        public object _onDeserializedMethods;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6780340
        public void GetMethodsWithAttribute(){} // RVA: 0x6780660
        public void get_HasOnSerializingEvents(){} // RVA: 0x6780870
        public void InvokeOnSerializing(){} // RVA: 0x6780890
        public void InvokeOnDeserializing(){} // RVA: 0x67808E0
        public void InvokeOnDeserialized(){} // RVA: 0x6780930
        public void AddOnSerialized(){} // RVA: 0x6780980
        public void AddOnDeserialized(){} // RVA: 0x67809A0
        public void InvokeOnDelegate(){} // RVA: 0x67809C0
        public void AddOnDelegate(){} // RVA: 0x6780A00
    }

    public class SerializationEventsCache : Object
    {
        public object s_cache;

        // ── Methods ──
        public void GetSerializationEventsForType(){} // RVA: 0x6780C70
        public void .cctor(){} // RVA: 0x6780E20
    }

    public class SerializationException : SystemException
    {
        public object s_nullMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
        public void .cctor(){} // RVA: 0x677F700
    }

    public class SerializationFieldInfo : FieldInfo
    {
        public object m_field;
        public object m_serializationName;

        // ── Methods ──
        public void get_Module(){} // RVA: 0x22368C0
        public void get_MetadataToken(){} // RVA: 0x10AD890
        public void .ctor(){} // RVA: 0x678C0F0
        public void get_Name(){} // RVA: 0xB465B0
        public void get_DeclaringType(){} // RVA: 0x678C220
        public void get_ReflectedType(){} // RVA: 0x678C250
        public void GetCustomAttributes(){} // RVA: 0x678C2B0
        public void IsDefined(){} // RVA: 0x10ACFF0
        public void get_FieldType(){} // RVA: 0x10AC4B0
        public void GetValue(){} // RVA: 0x6169360
        public void InternalGetValue(){} // RVA: 0x678C2E0
        public void SetValue(){} // RVA: 0x678C340
        public void InternalSetValue(){} // RVA: 0x678C380
        public void get_FieldInfo(){} // RVA: 0xB5DBF0
        public void get_FieldHandle(){} // RVA: 0x678C400
        public void get_Attributes(){} // RVA: 0x10ACFC0
    }

    public class SerializationFieldInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SerializationInfo : Object
    {
        public object m_members;
        public object m_data;
        public object m_types;
        public object m_nameToIndex;
        public object m_currMember;
        public object m_converter;
        public object m_fullTypeName;
        public object m_assemName;
        public object objectType;
        public object isFullTypeNameSetExplicit;
        public object isAssemblyNameSetExplicit;
        public object requireSameTokenInPartialTrust;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x678C450
        public void get_FullTypeName(){} // RVA: 0xBC1B30
        public void get_AssemblyName(){} // RVA: 0xBBF8F0
        public void SetType(){} // RVA: 0x678C8E0
        public void Compare(){} // RVA: 0x678CB60
        public void DemandForUnsafeAssemblyNameAssignments(){} // RVA: 0x678CBE0
        public void IsAssemblyNameAssignmentSafe(){} // RVA: 0x678CBF0
        public void get_MemberCount(){} // RVA: 0xB9E080
        public void get_ObjectType(){} // RVA: 0xBE58B0
        public void get_IsFullTypeNameSetExplicit(){} // RVA: 0xE3F480
        public void get_IsAssemblyNameSetExplicit(){} // RVA: 0x5C8BB10
        public void GetEnumerator(){} // RVA: 0x678CEC0
        public void ExpandArrays(){} // RVA: 0x678D040
        public void AddValue(){} // RVA: 0x678E6A0
        public void AddValueInternal(){} // RVA: 0x678E820
        public void UpdateValue(){} // RVA: 0x678EA20
        public void FindElement(){} // RVA: 0x678EB20
        public void GetElement(){} // RVA: 0x678EC20
        public void GetElementNoThrow(){} // RVA: 0x678ED80
        public void GetValue(){} // RVA: 0x678EEB0
        public void GetValueNoThrow(){} // RVA: 0x678F090
        public void GetBoolean(){} // RVA: 0x678F280
        public void GetByte(){} // RVA: 0x678F390
        public void GetInt16(){} // RVA: 0x678F4A0
        public void GetInt32(){} // RVA: 0x678F5B0
        public void GetUInt32(){} // RVA: 0x678F6C0
        public void GetInt64(){} // RVA: 0x678F7D0
        public void GetSingle(){} // RVA: 0x678F8E0
        public void GetString(){} // RVA: 0x678F9F0
    }

    public class SerializationInfoEnumerator : Object
    {
        public object _members;
        public object _data;
        public object _types;
        public object _numItems;
        public object _currItem;
        public object _current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x677F7B0
        public void MoveNext(){} // RVA: 0x677F8D0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x677F8F0
        public void get_Current(){} // RVA: 0x677F960
        public void Reset(){} // RVA: 0x677FA50
        public void get_Name(){} // RVA: 0x677FA60
        public void get_Value(){} // RVA: 0x677FAF0
        public void get_ObjectType(){} // RVA: 0x677FB80
    }

    public class SerializationObjectManager : Object
    {
        public object _objectSeenTable;
        public object _context;
        public object _onSerializedHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6781000
        public void RegisterObject(){} // RVA: 0x6781130
        public void RaiseOnSerializedEvent(){} // RVA: 0x6781340
        public void AddOnSerialized(){} // RVA: 0x6781380
    }

    public class StreamingContext : ValueType
    {
        public object m_additionalContext;
        public object m_state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AE600
        public void get_Context(){} // RVA: 0x77900
        public void Equals(){} // RVA: 0x8AE660
        public void GetHashCode(){} // RVA: 0x14790
        public void get_State(){} // RVA: 0x14790
    }

    public class SurrogateForCyclicalReference : Object
    {
        public object innerSurrogate;

        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x6784240
        public void SetObjectData(){} // RVA: 0x6784330
    }

    public class TypeLoadExceptionHolder : Object
    {
        public object m_typeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_TypeName(){} // RVA: 0xB5DBF0
    }

    public class ValueTypeFixupInfo : Object
    {
        public object _containerID;
        public object _parentField;
        public object _parentIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6781470
        public void get_ContainerID(){} // RVA: 0xB5DBF0
        public void get_ParentField(){} // RVA: 0xB465B0
        public void get_ParentIndex(){} // RVA: 0xB700F0
    }

}