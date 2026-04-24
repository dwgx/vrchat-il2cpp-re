// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Serialization
// Classes: 5
// Methods: 84

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Serialization
{
    public class CachedAttributeGetter`1 : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetAttribute(){} // RVA: 0x7ffaa887e5c0
    }

    public class DefaultContractResolver : Object
    {
        public object TypeContractCacheLock; // 0x30C62E10
        public object _sharedCache; // 0x30C62E10
        public object _ignoreSerializableInterface; // 0x30C62E10, was: <IgnoreSerializableInterface>k

        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaaf6fb080
        public void get_DefaultMembersSearchFlags(){} // RVA: 0x7ffaa9e5ac10
        public void set_DefaultMembersSearchFlags(){} // RVA: 0x7ffaa9e6a2e0
        public void get_SerializeCompilerGeneratedMembers(){} // RVA: 0x7ffaa8a209d0
        public void get_IgnoreSerializableInterface(){} // RVA: 0x7ffaa8c56a20
        public void get_IgnoreSerializableAttribute(){} // RVA: 0x7ffaaa01a500
        public void set_IgnoreSerializableAttribute(){} // RVA: 0x7ffaa9986930
        public void get_NamingStrategy(){} // RVA: 0x7ffaa8960130
        public void .ctor(){} // RVA: 0x7ffaaf6fb190
        public void .ctor(){} // RVA: 0x7ffaaf6fb190
        public void ResolveContract(){} // RVA: 0x7ffaaf6fb2c0
        public void ShouldSerializeEntityMember(){} // RVA: 0x7ffaaf6fc1c0
        public void CreateObjectContract(){} // RVA: 0x7ffaaf6fc340
        public void CreateConstructorParameters(){} // RVA: 0x7ffaaf6fdf50
        public void CreatePropertyFromConstructorParameter(){} // RVA: 0x7ffaaf6fe130
        public void ResolveContractConverter(){} // RVA: 0x7ffaaf6fe5b0
        public void InitializeContract(){} // RVA: 0x7ffaaf6fe680
        public void ResolveCallbackMethods(){} // RVA: 0x7ffaaf6fea00
        public void ShouldSkipDeserialized(){} // RVA: 0x7ffaa8932320
        public void ShouldSkipSerializing(){} // RVA: 0x7ffaa8932320
        public void CreateDictionaryContract(){} // RVA: 0x7ffaaf6ff880
        public void CreateArrayContract(){} // RVA: 0x7ffaaf6fff40
        public void CreatePrimitiveContract(){} // RVA: 0x7ffaaf7002e0
        public void CreateLinqContract(){} // RVA: 0x7ffaaf700360
        public void CreateISerializableContract(){} // RVA: 0x7ffaaf7003e0
        public void CreateStringContract(){} // RVA: 0x7ffaaf7006f0
        public void CreateContract(){} // RVA: 0x7ffaaf7007b0
        public void IsJsonPrimitiveType(){} // RVA: 0x7ffaaf700ce0
        public void IsIConvertible(){} // RVA: 0x7ffaaf700d80
        public void CanConvertToString(){} // RVA: 0x7ffaaf700f60
        public void IsValidCallback(){} // RVA: 0x7ffaaf7011f0
        public void CreateProperties(){} // RVA: 0x7ffaaf701bd0
        public void CreateMemberValueProvider(){} // RVA: 0x7ffaaf702130
        public void CreateProperty(){} // RVA: 0x7ffaaf702250
        public void CreateShouldSerializeTest(){} // RVA: 0x7ffaaf702de0
        public void ResolvePropertyName(){} // RVA: 0x7ffaaf703510
        public void ResolveDictionaryKey(){} // RVA: 0x7ffaaf703540
        public void .cctor(){} // RVA: 0x7ffaaf7035b0
        // ── Binary Analysis Named ──
        public void GetState(){} // RVA: 0x7ffaaf6fb250
        public void GetSerializableMembers(){} // RVA: 0x7ffaaf6fb750
        public void GetExtensionDataMemberForType(){} // RVA: 0x7ffaaf6fc9b0
        public void SetExtensionDataDelegates(){} // RVA: 0x7ffaaf6fcc80
        public void GetAttributeConstructor(){} // RVA: 0x7ffaaf6fd920
        public void GetParameterizedConstructor(){} // RVA: 0x7ffaaf6fde10
        public void GetDefaultCreator(){} // RVA: 0x7ffaaf6fe600
        public void GetCallbackMethodsForType(){} // RVA: 0x7ffaaf6feda0
        public void GetClassHierarchyForType(){} // RVA: 0x7ffaaf6ff6b0
        public void GetClrTypeFullName(){} // RVA: 0x7ffaaf7019c0
        public void SetPropertySettingsFromAttributes(){} // RVA: 0x7ffaaf702610
        public void SetIsSpecifiedActions(){} // RVA: 0x7ffaaf703090
        public void GetResolvedPropertyName(){} // RVA: 0x7ffaaf703590
    }

    public class JsonFormatterConverter : Object
    {
        public object _member; // 0x317E3BC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf709340
        public void Convert(){} // RVA: 0x7ffaaf709540
        public void ToBoolean(){} // RVA: 0x7ffaaf7096b0
        public void ToByte(){} // RVA: 0x7ffaaf709700
        public void ToInt16(){} // RVA: 0x7ffaaf709750
        public void ToInt32(){} // RVA: 0x7ffaaf7097a0
        public void ToInt64(){} // RVA: 0x7ffaaf7097f0
        public void ToSingle(){} // RVA: 0x7ffaaf709840
        public void ToString(){} // RVA: 0x7ffaaf709890
        public void ToUInt32(){} // RVA: 0x7ffaaf7098e0
        // ── Binary Analysis Named ──
        public void GetTokenValue(){} // RVA: 0x7ffaa887e5c0
    }

    public class JsonTypeReflector : Object
    {
        public object AssociatedMetadataTypesCache; // 0x31809200

        // ── Original Methods ──
        public void CreateJsonConverterInstance(){} // RVA: 0x7ffaaf721db0
        public void CreateNamingStrategyInstance(){} // RVA: 0x7ffaaf721eb0
        public void get_FullyTrusted(){} // RVA: 0x7ffaaf722670
        public void get_ReflectionDelegateFactory(){} // RVA: 0x7ffaaf722800
        public void .cctor(){} // RVA: 0x7ffaaf7228a0
        // ── Binary Analysis Named ──
        public void GetCachedAttribute(){} // RVA: 0x7ffaa887e5c0
        public void GetDataContractAttribute(){} // RVA: 0x7ffaaf721860
        public void GetDataMemberAttribute(){} // RVA: 0x7ffaaf721900
        public void GetObjectMemberSerialization(){} // RVA: 0x7ffaaf721b70
        public void GetJsonConverter(){} // RVA: 0x7ffaaf721c80
        public void GetContainerNamingStrategy(){} // RVA: 0x7ffaaf721fb0
        public void GetCreator(){} // RVA: 0x7ffaaf7220a0
        public void GetTypeConverter(){} // RVA: 0x7ffaaf722290
        public void GetAssociatedMetadataType(){} // RVA: 0x7ffaaf7222e0
        public void GetAssociateMetadataTypeFromAttribute(){} // RVA: 0x7ffaaf722370
        public void GetAttribute(){} // RVA: 0x7ffaa887e5c0
        public void GetAttribute(){} // RVA: 0x7ffaa887e5c0
        public void GetAttribute(){} // RVA: 0x7ffaa887e5c0
    }

    public class ObjectConstructor`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa8649280
    }

}