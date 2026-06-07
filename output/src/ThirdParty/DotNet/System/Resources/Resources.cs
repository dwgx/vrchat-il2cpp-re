// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Resources
// Classes: 15
// Methods: 126

namespace ThirdParty.DotNet.System.Resources
{
    public class FastResourceComparer
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x5D4B080 | overloaded x2
        public void HashFunction(){} // RVA: 0x5D4B120
        public void Compare(){} // RVA: 0x5D4B280 | overloaded x2
        public void Equals(){} // RVA: 0x5D4B310 | overloaded x2
        public void CompareOrdinal(){} // RVA: 0x5D4B5C0 | overloaded x3
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5D4B690
    }

    public class FileBasedResourceGroveler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GrovelForResourceSet(){} // RVA: 0x5D4B730
        public void FindResourceFile(){} // RVA: 0x5D4BA80
        public void CreateResourceSet(){} // RVA: 0x5D4BB40
    }

    public class IResourceGroveler
    {
        // ── Methods ──
        public void GrovelForResourceSet(){}
    }

    public class IResourceReader
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x24A50
        public void GetEnumerator(){} // RVA: 0xCD60
    }

    public class ManifestBasedResourceGroveler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GrovelForResourceSet(){} // RVA: 0x5D4BDF0
        public void UltimateFallbackFixup(){} // RVA: 0x5D4C390
        public void GetNeutralResourcesLanguage(){} // RVA: 0x5D4C4F0
        public void CreateResourceSet(){} // RVA: 0x5D4C870
        public void GetManifestResourceStream(){} // RVA: 0x5D4D370
        public void CaseInsensitiveManifestResourceStreamLookup(){} // RVA: 0x5D4D4E0
        public void GetSatelliteAssembly(){} // RVA: 0x5D4D950
        public void CanUseDefaultResourceClasses(){} // RVA: 0x5D4DB70
        public void GetSatelliteAssemblyName(){} // RVA: 0x5D4DD00
        public void HandleSatelliteMissing(){} // RVA: 0x5D4DD80
        public void HandleResourceStreamMissing(){} // RVA: 0x5D4E130
        public void GetNeutralResourcesLanguageAttribute(){} // RVA: 0x5D4E510
    }

    public class MissingManifestResourceException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class MissingSatelliteAssemblyException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x3
    }

    public class NeutralResourcesLanguageAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D48E30
        public void get_CultureName(){} // RVA: 0x2F8380
        public void get_Location(){} // RVA: 0x5BED50
    }

    public class ResourceFallbackManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D48EF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5D490B0
        public void GetEnumerator(){} // RVA: 0x5D490C0
    }

    public class ResourceLocator
    {
        public object Key;
        public object Current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D16F70
        public void get_DataPosition(){} // RVA: 0x1EA9890
        public void get_Value(){} // RVA: 0x1AD4690
        public void set_Value(){} // RVA: 0x100A2F0
        public void CanCache(){} // RVA: 0x5D525D0
    }

    public class ResourceManager
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x5D4E5D0
        public void .ctor(){} // RVA: 0x5D4E8D0 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x5D4ED50
        public void OnDeserialized(){} // RVA: 0x5D4EE50
        public void OnSerializing(){} // RVA: 0x5D4F300
        public void CommonAssemblyInit(){} // RVA: 0x5D4F420
        public void get_BaseName(){} // RVA: 0x2F8380
        public void get_IgnoreCase(){} // RVA: 0x59FF30
        public void get_FallbackLocation(){} // RVA: 0x5A54D0
        public void GetResourceFileName(){} // RVA: 0x5D4F770
        public void GetFirstResourceSet(){} // RVA: 0x5D4F910
        public void GetResourceSet(){} // RVA: 0x5D50000
        public void InternalGetResourceSet(){} // RVA: 0x5D50510 | overloaded x2
        public void AddResourceSet(){} // RVA: 0x5D50C10
        public void GetSatelliteContractVersion(){} // RVA: 0x5D50EE0
        public void GetNeutralResourcesLanguage(){} // RVA: 0x5D51580
        public void CompareNames(){} // RVA: 0x5D515A0
        public void SetAppXConfiguration(){} // RVA: 0x2DD310
        public void GetString(){} // RVA: 0x5D51AA0 | overloaded x2
        public void .cctor(){} // RVA: 0x5D51EE0
    }

    public class ResourceReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D525E0
        public void Close(){} // RVA: 0x5D527C0
        public void Dispose(){} // RVA: 0x5D527D0 | overloaded x2
        public void ReadUnalignedI4(){} // RVA: 0x5D52A20
        public void SkipString(){} // RVA: 0x5D52A40
        public void GetNameHash(){} // RVA: 0x5D52B10
        public void GetNamePosition(){} // RVA: 0x5D52B80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5D52CC0
        public void GetEnumerator(){} // RVA: 0x5D52CC0
        public void GetEnumeratorInternal(){} // RVA: 0x5D52D80
        public void FindPosForResource(){} // RVA: 0x5D52E30
        public void CompareStringEqualsName(){} // RVA: 0x5D53350
        public void AllocateStringForNameIndex(){} // RVA: 0x5D53760
        public void GetValueForNameIndex(){} // RVA: 0x5D53FA0
        public void LoadString(){} // RVA: 0x5D54300
        public void LoadObject(){} // RVA: 0x5D54650 | overloaded x2
        public void LoadObjectV1(){} // RVA: 0x5D54700
        public void _LoadObjectV1(){} // RVA: 0x5D54800
        public void LoadObjectV2(){} // RVA: 0x5D55090
        public void _LoadObjectV2(){} // RVA: 0x5D55190
        public void DeserializeObject(){} // RVA: 0x5D55EE0
        public void ReadResources(){} // RVA: 0x5D560C0
        public void _ReadResources(){} // RVA: 0x5D562D0
        public void FindType(){} // RVA: 0x5D56E10
    }

    public class ResourceSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x2
        public void CommonInit(){} // RVA: 0x5D57C00
        public void Dispose(){} // RVA: 0x5AB1BC0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x5D57E80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5D57E80
        public void GetEnumeratorHelper(){} // RVA: 0x5D57E90
        public void GetString(){} // RVA: 0x5D58100 | overloaded x2
        public void GetObject(){} // RVA: 0x5D584B0 | overloaded x2
        public void GetObjectInternal(){} // RVA: 0x5D583D0
        public void GetCaseInsensitiveObjectInternal(){} // RVA: 0x5D585C0
    }

    public class RuntimeResourceSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D49730 | overloaded x2
        public void Dispose(){} // RVA: 0x5D49910
        public void GetEnumerator(){} // RVA: 0x5D49C70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5D49C70
        public void GetEnumeratorHelper(){} // RVA: 0x5D49C80
        public void GetString(){} // RVA: 0x5D49DB0 | overloaded x2
        public void GetObject(){} // RVA: 0x5D49E90 | overloaded x3
        public void ResolveResourceLocator(){} // RVA: 0x5D4AC50
    }

    public class SatelliteContractVersionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D4AF00
        public void get_Version(){} // RVA: 0x2F8380
    }

}