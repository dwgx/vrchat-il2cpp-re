// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Resources
// Classes: 15
// Methods: 126

namespace ThirdParty.DotNet.System.Resources
{
    public class FastResourceComparer : Object
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE8688BF80 | overloaded x2
        public void HashFunction(){} // RVA: 0x7FFE8688C020
        public void Compare(){} // RVA: 0x7FFE8688C180 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE8688C210 | overloaded x2
        public void CompareOrdinal(){} // RVA: 0x7FFE8688C4C0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8688C590
    }

    public class FileBasedResourceGroveler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GrovelForResourceSet(){} // RVA: 0x7FFE8688C630
        public void FindResourceFile(){} // RVA: 0x7FFE8688C980
        public void CreateResourceSet(){} // RVA: 0x7FFE8688CA40
    }

    public class IResourceGroveler
    {
        // ── Methods ──
        public void GrovelForResourceSet(){}
    }

    public class IResourceReader
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x7FFE80E45FE0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ManifestBasedResourceGroveler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GrovelForResourceSet(){} // RVA: 0x7FFE8688CCF0
        public void UltimateFallbackFixup(){} // RVA: 0x7FFE8688D290
        public void GetNeutralResourcesLanguage(){} // RVA: 0x7FFE8688D3F0
        public void CreateResourceSet(){} // RVA: 0x7FFE8688D770
        public void GetManifestResourceStream(){} // RVA: 0x7FFE8688E270
        public void CaseInsensitiveManifestResourceStreamLookup(){} // RVA: 0x7FFE8688E3E0
        public void GetSatelliteAssembly(){} // RVA: 0x7FFE8688E850
        public void CanUseDefaultResourceClasses(){} // RVA: 0x7FFE8688EA70
        public void GetSatelliteAssemblyName(){} // RVA: 0x7FFE8688EC00
        public void HandleSatelliteMissing(){} // RVA: 0x7FFE8688EC80
        public void HandleResourceStreamMissing(){} // RVA: 0x7FFE8688F030
        public void GetNeutralResourcesLanguageAttribute(){} // RVA: 0x7FFE8688F410
    }

    public class MissingManifestResourceException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class MissingSatelliteAssemblyException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class NeutralResourcesLanguageAttribute : Attribute
    {
        public string _cultureName; // 0x10
        public 0x664D0CAC _location; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86889D30
        public void get_CultureName(){} // RVA: 0x7FFE81116380
        public void get_Location(){} // RVA: 0x7FFE813DB630
    }

    public class ResourceFallbackManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86889DF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86889FB0
        public void GetEnumerator(){} // RVA: 0x7FFE86889FC0
    }

    public class ResourceLocator : ValueType
    {
        public object _value; // 0x10
        public int _dataPos; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86857E70
        public void get_DataPosition(){} // RVA: 0x7FFE82C33000
        public void get_Value(){} // RVA: 0x7FFE8284EF60
        public void set_Value(){} // RVA: 0x7FFE81D7E9E0
        public void CanCache(){} // RVA: 0x7FFE868934D0
    }

    public class ResourceManager : Object
    {
        public string BaseNameField; // 0x10
        public System.Collections.Hashtable ResourceSets; // 0x18
        public System.Collections.Generic.Dictionary`2<string,System.Resources.ResourceSet> _resourceSets; // 0x20

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8688F4D0
        public void .ctor(){} // RVA: 0x7FFE8688F7D0 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x7FFE8688FC50
        public void OnDeserialized(){} // RVA: 0x7FFE8688FD50
        public void OnSerializing(){} // RVA: 0x7FFE86890200
        public void CommonAssemblyInit(){} // RVA: 0x7FFE86890320
        public void get_BaseName(){} // RVA: 0x7FFE81116380
        public void get_IgnoreCase(){} // RVA: 0x7FFE813A1140
        public void get_FallbackLocation(){} // RVA: 0x7FFE813A7A20
        public void GetResourceFileName(){} // RVA: 0x7FFE86890670
        public void GetFirstResourceSet(){} // RVA: 0x7FFE86890810
        public void GetResourceSet(){} // RVA: 0x7FFE86890F00
        public void InternalGetResourceSet(){} // RVA: 0x7FFE86891410 | overloaded x2
        public void AddResourceSet(){} // RVA: 0x7FFE86891B10
        public void GetSatelliteContractVersion(){} // RVA: 0x7FFE86891DE0
        public void GetNeutralResourcesLanguage(){} // RVA: 0x7FFE86892480
        public void CompareNames(){} // RVA: 0x7FFE868924A0
        public void SetAppXConfiguration(){} // RVA: 0x7FFE810FB310
        public void GetString(){} // RVA: 0x7FFE868929A0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE86892DE0
    }

    public class ResourceReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868934E0
        public void Close(){} // RVA: 0x7FFE868936C0
        public void Dispose(){} // RVA: 0x7FFE868936D0 | overloaded x2
        public void ReadUnalignedI4(){} // RVA: 0x7FFE86893920
        public void SkipString(){} // RVA: 0x7FFE86893940
        public void GetNameHash(){} // RVA: 0x7FFE86893A10
        public void GetNamePosition(){} // RVA: 0x7FFE86893A80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86893BC0
        public void GetEnumerator(){} // RVA: 0x7FFE86893BC0
        public void GetEnumeratorInternal(){} // RVA: 0x7FFE86893C80
        public void FindPosForResource(){} // RVA: 0x7FFE86893D30
        public void CompareStringEqualsName(){} // RVA: 0x7FFE86894250
        public void AllocateStringForNameIndex(){} // RVA: 0x7FFE86894660
        public void GetValueForNameIndex(){} // RVA: 0x7FFE86894EA0
        public void LoadString(){} // RVA: 0x7FFE86895200
        public void LoadObject(){} // RVA: 0x7FFE86895550 | overloaded x2
        public void LoadObjectV1(){} // RVA: 0x7FFE86895600
        public void _LoadObjectV1(){} // RVA: 0x7FFE86895700
        public void LoadObjectV2(){} // RVA: 0x7FFE86895F90
        public void _LoadObjectV2(){} // RVA: 0x7FFE86896090
        public void DeserializeObject(){} // RVA: 0x7FFE86896DA0
        public void ReadResources(){} // RVA: 0x7FFE86896F80
        public void _ReadResources(){} // RVA: 0x7FFE86897190
        public void FindType(){} // RVA: 0x7FFE86897CD0
    }

    public class ResourceSet : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void CommonInit(){} // RVA: 0x7FFE86898AC0
        public void Dispose(){} // RVA: 0x7FFE865F29F0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE86898D40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86898D40
        public void GetEnumeratorHelper(){} // RVA: 0x7FFE86898D50
        public void GetString(){} // RVA: 0x7FFE86898FC0 | overloaded x2
        public void GetObject(){} // RVA: 0x7FFE86899370 | overloaded x2
        public void GetObjectInternal(){} // RVA: 0x7FFE86899290
        public void GetCaseInsensitiveObjectInternal(){} // RVA: 0x7FFE86899480
    }

    public class RuntimeResourceSet : ResourceSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8688A630 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE8688A810
        public void GetEnumerator(){} // RVA: 0x7FFE8688AB70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8688AB70
        public void GetEnumeratorHelper(){} // RVA: 0x7FFE8688AB80
        public void GetString(){} // RVA: 0x7FFE8688ACB0 | overloaded x2
        public void GetObject(){} // RVA: 0x7FFE8688AD90 | overloaded x3
        public void ResolveResourceLocator(){} // RVA: 0x7FFE8688BB50
    }

    public class SatelliteContractVersionAttribute : Attribute
    {
        public string _version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8688BE00
        public void get_Version(){} // RVA: 0x7FFE81116380
    }

}