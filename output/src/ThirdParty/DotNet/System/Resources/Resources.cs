// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Resources
// Classes: 15
// Methods: 126

namespace ThirdParty.DotNet.System.Resources
{
    public class FastResourceComparer
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAF87FB080 | overloaded x2
        public void HashFunction(){} // RVA: 0x7FFAF87FB120
        public void Compare(){} // RVA: 0x7FFAF87FB280 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF87FB310 | overloaded x2
        public void CompareOrdinal(){} // RVA: 0x7FFAF87FB5C0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF87FB690
    }

    public class FileBasedResourceGroveler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GrovelForResourceSet(){} // RVA: 0x7FFAF87FB730
        public void FindResourceFile(){} // RVA: 0x7FFAF87FBA80
        public void CreateResourceSet(){} // RVA: 0x7FFAF87FBB40
    }

    public class IResourceGroveler
    {
        // ── Methods ──
        public void GrovelForResourceSet(){}
    }

    public class IResourceReader
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x7FFAF2AD4A50
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ManifestBasedResourceGroveler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GrovelForResourceSet(){} // RVA: 0x7FFAF87FBDF0
        public void UltimateFallbackFixup(){} // RVA: 0x7FFAF87FC390
        public void GetNeutralResourcesLanguage(){} // RVA: 0x7FFAF87FC4F0
        public void CreateResourceSet(){} // RVA: 0x7FFAF87FC870
        public void GetManifestResourceStream(){} // RVA: 0x7FFAF87FD370
        public void CaseInsensitiveManifestResourceStreamLookup(){} // RVA: 0x7FFAF87FD4E0
        public void GetSatelliteAssembly(){} // RVA: 0x7FFAF87FD950
        public void CanUseDefaultResourceClasses(){} // RVA: 0x7FFAF87FDB70
        public void GetSatelliteAssemblyName(){} // RVA: 0x7FFAF87FDD00
        public void HandleSatelliteMissing(){} // RVA: 0x7FFAF87FDD80
        public void HandleResourceStreamMissing(){} // RVA: 0x7FFAF87FE130
        public void GetNeutralResourcesLanguageAttribute(){} // RVA: 0x7FFAF87FE510
    }

    public class MissingManifestResourceException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class MissingSatelliteAssemblyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x3
    }

    public class NeutralResourcesLanguageAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87F8E30
        public void get_CultureName(){} // RVA: 0x7FFAF2DA8380
        public void get_Location(){} // RVA: 0x7FFAF306ED50
    }

    public class ResourceFallbackManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87F8EF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF87F90B0
        public void GetEnumerator(){} // RVA: 0x7FFAF87F90C0
    }

    public class ResourceLocator
    {
        public object Key;
        public object Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87C6F70
        public void get_DataPosition(){} // RVA: 0x7FFAF4959890
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void set_Value(){} // RVA: 0x7FFAF3ABA2F0
        public void CanCache(){} // RVA: 0x7FFAF88025D0
    }

    public class ResourceManager
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF87FE5D0
        public void .ctor(){} // RVA: 0x7FFAF87FE8D0 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x7FFAF87FED50
        public void OnDeserialized(){} // RVA: 0x7FFAF87FEE50
        public void OnSerializing(){} // RVA: 0x7FFAF87FF300
        public void CommonAssemblyInit(){} // RVA: 0x7FFAF87FF420
        public void get_BaseName(){} // RVA: 0x7FFAF2DA8380
        public void get_IgnoreCase(){} // RVA: 0x7FFAF304FF30
        public void get_FallbackLocation(){} // RVA: 0x7FFAF30554D0
        public void GetResourceFileName(){} // RVA: 0x7FFAF87FF770
        public void GetFirstResourceSet(){} // RVA: 0x7FFAF87FF910
        public void GetResourceSet(){} // RVA: 0x7FFAF8800000
        public void InternalGetResourceSet(){} // RVA: 0x7FFAF8800510 | overloaded x2
        public void AddResourceSet(){} // RVA: 0x7FFAF8800C10
        public void GetSatelliteContractVersion(){} // RVA: 0x7FFAF8800EE0
        public void GetNeutralResourcesLanguage(){} // RVA: 0x7FFAF8801580
        public void CompareNames(){} // RVA: 0x7FFAF88015A0
        public void SetAppXConfiguration(){} // RVA: 0x7FFAF2D8D310
        public void GetString(){} // RVA: 0x7FFAF8801AA0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF8801EE0
    }

    public class ResourceReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88025E0
        public void Close(){} // RVA: 0x7FFAF88027C0
        public void Dispose(){} // RVA: 0x7FFAF88027D0 | overloaded x2
        public void ReadUnalignedI4(){} // RVA: 0x7FFAF8802A20
        public void SkipString(){} // RVA: 0x7FFAF8802A40
        public void GetNameHash(){} // RVA: 0x7FFAF8802B10
        public void GetNamePosition(){} // RVA: 0x7FFAF8802B80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8802CC0
        public void GetEnumerator(){} // RVA: 0x7FFAF8802CC0
        public void GetEnumeratorInternal(){} // RVA: 0x7FFAF8802D80
        public void FindPosForResource(){} // RVA: 0x7FFAF8802E30
        public void CompareStringEqualsName(){} // RVA: 0x7FFAF8803350
        public void AllocateStringForNameIndex(){} // RVA: 0x7FFAF8803760
        public void GetValueForNameIndex(){} // RVA: 0x7FFAF8803FA0
        public void LoadString(){} // RVA: 0x7FFAF8804300
        public void LoadObject(){} // RVA: 0x7FFAF8804650 | overloaded x2
        public void LoadObjectV1(){} // RVA: 0x7FFAF8804700
        public void _LoadObjectV1(){} // RVA: 0x7FFAF8804800
        public void LoadObjectV2(){} // RVA: 0x7FFAF8805090
        public void _LoadObjectV2(){} // RVA: 0x7FFAF8805190
        public void DeserializeObject(){} // RVA: 0x7FFAF8805EE0
        public void ReadResources(){} // RVA: 0x7FFAF88060C0
        public void _ReadResources(){} // RVA: 0x7FFAF88062D0
        public void FindType(){} // RVA: 0x7FFAF8806E10
    }

    public class ResourceSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void CommonInit(){} // RVA: 0x7FFAF8807C00
        public void Dispose(){} // RVA: 0x7FFAF8561BC0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAF8807E80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8807E80
        public void GetEnumeratorHelper(){} // RVA: 0x7FFAF8807E90
        public void GetString(){} // RVA: 0x7FFAF8808100 | overloaded x2
        public void GetObject(){} // RVA: 0x7FFAF88084B0 | overloaded x2
        public void GetObjectInternal(){} // RVA: 0x7FFAF88083D0
        public void GetCaseInsensitiveObjectInternal(){} // RVA: 0x7FFAF88085C0
    }

    public class RuntimeResourceSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87F9730 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF87F9910
        public void GetEnumerator(){} // RVA: 0x7FFAF87F9C70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF87F9C70
        public void GetEnumeratorHelper(){} // RVA: 0x7FFAF87F9C80
        public void GetString(){} // RVA: 0x7FFAF87F9DB0 | overloaded x2
        public void GetObject(){} // RVA: 0x7FFAF87F9E90 | overloaded x3
        public void ResolveResourceLocator(){} // RVA: 0x7FFAF87FAC50
    }

    public class SatelliteContractVersionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF87FAF00
        public void get_Version(){} // RVA: 0x7FFAF2DA8380
    }

}