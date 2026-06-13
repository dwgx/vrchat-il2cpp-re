// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 260

public class Deleter
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E604F0
    public void Invoke(){} // RVA: 0x338C60
}

public class DeletionCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4392A0
    public void Invoke(){} // RVA: 0x439370
}

public class DeliverIosPlatformEvents
{
}

public class DeltaStateEventBuffer
{
}

public class DepthOrderedDirtyTracking
{
    // ── Methods ──
    public void EnsureFits(){} // RVA: 0x734E090
    public void RegisterDirty(){} // RVA: 0x734E1B0
    public void ClearDirty(){} // RVA: 0x734E4B0
    public void Reset(){} // RVA: 0x734E850
}

public class DerComparer
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x96CD830
    public void .ctor(){} // RVA: 0x2DD310
}

public class DeriveBytes
{
    public byte[] Password;
    public byte[] IterationCount; // 0x8
    public byte[] Keys; // 0x10
    public string Certificates; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
    public void set_HashName(){} // RVA: 0x2DEE30
    public void set_IterationCount(){} // RVA: 0x6374E0
    public void set_Password(){} // RVA: 0x5BC4570
    public void set_Salt(){} // RVA: 0x5BC46F0
    public void Adjust(){} // RVA: 0x5BC4850
    public void Derive(){} // RVA: 0x5BC4920
    public void DeriveKey(){} // RVA: 0x5BC4DD0
    public void DeriveIV(){} // RVA: 0x5BC4E50
    public void DeriveMAC(){} // RVA: 0x5BC4ED0
    public void .cctor(){} // RVA: 0x5BC4F50
}

public class DerivedJsonTypeInfo
{
    public System.Text.Json.Serialization.Metadata.JsonTypeInfo BaseType; // 0x10
    public System.Type UnknownDerivedTypeHandling; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6408E20
    public void get_DerivedType(){} // RVA: 0x2E07C0
    public void get_TypeDiscriminator(){} // RVA: 0x30B0C0
    public void GetJsonTypeInfo(){} // RVA: 0x68DDDB0
}

public class DerivedTypeList
{
    public System.Text.Json.Serialization.Metadata.JsonPolymorphismOptions _parent; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x68CE5F0
    public void get_IsReadOnly(){} // RVA: 0x68CE750
    public void OnCollectionModifying(){} // RVA: 0x68CE780
}

public class DeserializationDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x33B0570
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x75D9960
    public void EndInvoke(){} // RVA: 0x61D7A00
}

public class Deserialize32QuaternionDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E11FC0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x75D9960
    public void EndInvoke(){} // RVA: 0x1EDD9F0
}

public class Deserialize32Vector3Delegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E11FC0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x75D9960
    public void EndInvoke(){} // RVA: 0x1EDD9F0
}

public class DeserializeFloatDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E11FC0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x75D9A30
    public void EndInvoke(){} // RVA: 0x1EDD9F0
}

public class DeserializeFloatsDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E11FC0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x75D9960
    public void EndInvoke(){} // RVA: 0x1EDD9F0
}

public class DeserializeQuaternionDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E11FC0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x75D9960
    public void EndInvoke(){} // RVA: 0x1EDD9F0
}

public class DeserializeVector3Delegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E11FC0
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x75D9960
    public void EndInvoke(){} // RVA: 0x1EDD9F0
}

public class DesignerOptionCollection
{
    public System.ComponentModel.Design.DesignerOptionService _service; // 0x10
    public string _name; // 0x18
    public object _value; // 0x20
    public System.Collections.ArrayList _children; // 0x28
    public System.ComponentModel.PropertyDescriptorCollection _properties; // 0x30

    // ── Methods ──
    public void get_Count(){} // RVA: 0x6CB25A0
    public void get_Name(){} // RVA: 0x2E07C0
    public void get_Properties(){} // RVA: 0x6CB25E0
    public void CopyTo(){} // RVA: 0x6CB2E10
    public void EnsurePopulated(){} // RVA: 0x6CB2E70
    public void GetEnumerator(){} // RVA: 0x6CB2F50
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x1A3F520
}

public class DesignerOptionConverter
{
    // ── Methods ──
    public void GetPropertiesSupported(){} // RVA: 0x3C2850
    public void GetProperties(){} // RVA: 0x6CB32B0
    public void ConvertTo(){} // RVA: 0x6CB3860
    public void .ctor(){} // RVA: 0x2DD310
}

public class DesignerWebRequestCreate
{
    // ── Methods ──
    public void Create(){} // RVA: 0x6B286E0
    public void .ctor(){} // RVA: 0x2DD310
}

public class DestroyPipelineDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x338B80
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class DestroyRigDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x338B80
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x338C70
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class Development
{
    // ── Methods ──
    public void Log(){} // RVA: 0x6194F60
    public void LogWarning(){} // RVA: 0x6194FE0
    public void LogError(){} // RVA: 0x6195060
    public void LogRequest(){} // RVA: 0x2DD310
    public void LogRequestResult(){} // RVA: 0x2DD310
}

public class Development
{
    // ── Methods ──
    public void Log(){} // RVA: 0x618CB90
    public void LogWarning(){} // RVA: 0x618CC40
    public void LogError(){} // RVA: 0x618CCF0
}

public class DeviceArray
{
    // ── Methods ──
    public void IndexOf(){} // RVA: 0x6D8E730
    public void Remove(){} // RVA: 0x6D8E7D0
    public void Get(){} // RVA: 0x6D8E890
    public void Set(){} // RVA: 0x6D8EA00
}

public class DeviceBuilder
{
    public UnityEngine.InputSystem.InputDevice System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputControl>.Current; // 0x10

    // ── Methods ──
    public void get_device(){} // RVA: 0x1AD4690
    public void set_device(){} // RVA: 0x100A2F0
    public void WithName(){} // RVA: 0x6DF0F60
    public void WithDisplayName(){} // RVA: 0x6DF1000
    public void WithShortDisplayName(){} // RVA: 0x6DF10E0
    public void WithLayout(){} // RVA: 0x6DF11C0
    public void WithChildren(){} // RVA: 0x6DF1290
    public void WithStateBlock(){} // RVA: 0x6DF12C0
    public void IsNoisy(){} // RVA: 0x6DF1370
    public void WithControlUsage(){} // RVA: 0x6DF14A0
    public void WithControlAlias(){} // RVA: 0x6DF15D0
    public void WithStateOffsetToControlIndexMap(){} // RVA: 0x6DF1670
    public void WithControlTree(){} // RVA: 0x6DF16E0
    public void Finish(){} // RVA: 0x6DF18D0
}

public class DeviceConnectedChangeHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F47C0
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x64E2980
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class DeviceConnectedChangeHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F2520
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x64B6540
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class DeviceConnectedChangeHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F47C0
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x64ACFA0
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class DeviceConnectedChangeHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F47C0
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x64DB950
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class DeviceDescriptionJson
{
}

public class DeviceIndexChangedHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F4F70
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x64DBA00
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class DeviceInfo
{
    public int m_DeviceId; // 0x10
    public string m_Layout; // 0x18
    public UnityEngine.InputSystem.Utilities.FourCC m_StateFormat; // 0x20
    public int m_StateSizeInBytes; // 0x24

    // ── Methods ──
    public void get_deviceId(){} // RVA: 0x19689B0
    public void set_deviceId(){} // RVA: 0x833580
    public void get_layout(){} // RVA: 0x19689C0
    public void set_layout(){} // RVA: 0x1968950
    public void get_stateFormat(){} // RVA: 0x32A5C0
    public void set_stateFormat(){} // RVA: 0x2E00C0
    public void get_stateSizeInBytes(){} // RVA: 0x8ABED0
    public void set_stateSizeInBytes(){} // RVA: 0x8AC660
}

public class DeviceJson
{
    // ── Methods ──
    public void ToDeviceEntry(){} // RVA: 0x6DE2670
    public void From(){} // RVA: 0x6DE2700
}

public class DeviceLostEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6E96DD0
}

public class DeviceRegainedEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6E96E10
}

public class DeviceRequirement
{
    public string m_ControlPath; // 0x10
    public 0x65867CC0 m_Flags; // 0x18

    // ── Methods ──
    public void get_controlPath(){} // RVA: 0x1AD4690
    public void set_controlPath(){} // RVA: 0x100A2F0
    public void get_isOptional(){} // RVA: 0x6DE19B0
    public void set_isOptional(){} // RVA: 0x6DE19C0
    public void get_isAND(){} // RVA: 0x6DE19E0
    public void set_isAND(){} // RVA: 0x6DE19F0
    public void get_isOR(){} // RVA: 0x6DE1A10
    public void set_isOR(){} // RVA: 0x6DE1A20
    public void ToString(){} // RVA: 0x6DE1A40
    public void Equals(){} // RVA: 0x6DE1BE0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x6DE1C80
    public void op_Equality(){} // RVA: 0x6DE1D50
    public void op_Inequality(){} // RVA: 0x6DE1D70
}

public class DeviceToFree
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x733EDA0
}

public class DictationCompletedDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3CE370
    public void Invoke(){} // RVA: 0x338C60
}

public class DictationErrorHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E60340
    public void Invoke(){} // RVA: 0x439370
}

public class DictationHypothesisDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x338B80
    public void Invoke(){} // RVA: 0x338C60
}

public class DictationResultDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1E60340
    public void Invoke(){} // RVA: 0x439370
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<U,T>> _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24B10
    public void get_Entry(){} // RVA: 0xC770
    public void get_Key(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0xCD60
    public void get_Current(){} // RVA: 0xCD60
    public void MoveNext(){} // RVA: 0xDBE0
    public void Reset(){} // RVA: 0x24A50
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IDictionary`2<U,T> _dictionary;
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<U,T>> _enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24B10
    public void get_Entry(){} // RVA: 0xC770
    public void get_Key(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0xCD60
    public void get_Current(){} // RVA: 0xCD60
    public void MoveNext(){} // RVA: 0xDBE0
    public void Reset(){} // RVA: 0x24A50
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<U,T>> enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24B10
    public void MoveNext(){} // RVA: 0xDBE0
    public void Reset(){} // RVA: 0x24A50
    public void get_Current(){} // RVA: 0xCD60
    public void get_Entry(){} // RVA: 0xC770
    public void get_Key(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0xCD60
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,Microsoft.Extensions.Logging.ILogger>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,object>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,Microsoft.Extensions.Logging.Logger>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<SPKey,System.Net.ServicePoint>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,Newtonsoft.Json.Serialization.JsonContract>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,Union>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,System.Type>,System.Func`2<object,object>>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,System.Func`2<object[],object>>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<object,Newtonsoft.Json.JsonContainerAttribute>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<object,System.Runtime.Serialization.DataContractAttribute>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<object,Newtonsoft.Json.JsonConverterAttribute>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<object,Newtonsoft.Json.JsonObjectAttribute>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,System.Type>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,Newtonsoft.Json.Utilities.ReflectionObject>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<LiteralList,ZLogger.MessageSequence>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<int,ÍÌÏÎÌÏÌÏÌÏÌÌÌÌÌÏÏÏÎÍÎÏÍ>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,ÏÏÌÌÌÏÌÎÌÏÌÌÎÌÏÌÎÏÍÎÎÌÎ>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<uint,int>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<byte,int>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,VRC.Udon.Common.Interfaces.IUdonComponentGetterModule>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,VRC.Udon.Common.Interfaces.IUdonWrapperModule>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,Handlers>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<UIntPtr,SteamAudio.SteamAudioSource>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,object>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.Type,System.Runtime.Serialization.SerializationEvents>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,System.Lazy`1<Microsoft.Extensions.Logging.LoggerFilterOptions>>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<VRC.Udon.Security.IUdonSignatureHolder,byte>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<ÏÍÏÎÌÏÎÎÌÌÏÎÍÌÏÍÎÏÎÏÍÌÎ,ÎÎÎÏÎÏÏÎÎÏÎÍÍÏÌÏÍÏÍÏÎÎÌ>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<int,ÏÍÎÎÏÎÌÍÍÌÍÎÏÎÎÌÌÏÏÏÍÌÍ>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,Transmtn.IAcceptMessages>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<VRC.Udon.Security.IUdonSignatureHolder,bool>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<MeaMod.DNS.Model.DomainName,MeaMod.DNS.Server.Node>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Runtime.Remoting.Messaging.MessageDictionary _methodDictionary; // 0x10
    public System.Collections.IDictionaryEnumerator _hashtableEnum; // 0x18
    public int _posMethod; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x5D00560
    public void get_Current(){} // RVA: 0x5D00690
    public void MoveNext(){} // RVA: 0x5D006F0
    public void Reset(){} // RVA: 0x5D00890
    public void get_Entry(){} // RVA: 0x5D008F0
    public void get_Key(){} // RVA: 0x5D00A40
    public void get_Value(){} // RVA: 0x5D00A60
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<string,string>> _enumerator; // 0x10
}

public class DictionaryEnumerator
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo>> _enumerator; // 0x10
}

public class DictionaryEnumerator`2
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<W,T>> _e;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24B10
    public void get_Entry(){} // RVA: 0xC770
    public void get_Key(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0xCD60
    public void get_Current(){} // RVA: 0xCD60
    public void MoveNext(){} // RVA: 0xDBE0
    public void Reset(){} // RVA: 0x24A50
}

public class DictionaryEnumerator`2
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<W,T>> _e;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24B10
    public void get_Entry(){} // RVA: 0xC770
    public void get_Key(){} // RVA: 0xCD60
    public void get_Value(){} // RVA: 0xCD60
    public void get_Current(){} // RVA: 0xCD60
    public void MoveNext(){} // RVA: 0xDBE0
    public void Reset(){} // RVA: 0x24A50
}

public class DictionaryIterator`2 : enumerator
{
    public System.Collections.Generic.Dictionary`2<U,T> dictionary;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x24B10
    public void GetEnumerator(){} // RVA: 0x283FA0
    public void get_Current(){} // RVA: 0x283FA0
    public void MoveNext(){} // RVA: 0xDBE0
    public void Dispose(){} // RVA: 0x24A50
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MemberInfo[]>> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MemberInfo[]> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,System.Collections.Generic.Dictionary`2<System.Type,...<...,...>>> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<System.Type,...<...,...>> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.Dictionary`2<System.Type,System.Delegate>> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<System.Type,System.Delegate> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.Dictionary`2<System.Type,System.Func`2<object,object>>> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<System.Type,System.Func`2<object,object>> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter>> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryIterator`2
{
    public System.Collections.Generic.Dictionary`2<VRC.Udon.Serialization.OdinSerializer.ISerializationPolicy,VRC.Udon.Serialization.OdinSerializer.IFormatter> dictionary; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2BDEED0
    public void GetEnumerator(){} // RVA: 0x2BDF0E0
    public void get_Current(){} // RVA: 0x2BDF110
    public void MoveNext(){} // RVA: 0x2BDF1C0
    public void Dispose(){} // RVA: 0x2BDF1A0
}

public class DictionaryNode
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class DictionaryNode
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class DictionaryPoolImpl`2
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x24A80
}

public class DictionaryPoolImpl`2
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x2BE21A0
}
