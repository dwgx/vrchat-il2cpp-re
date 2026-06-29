// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Resources
// Classes: 15
// Methods: 104

namespace ThirdParty.DotNet.System.Resources
{
    public class FastResourceComparer : Object
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7ADB391F0
        public void HashFunction(){} // RVA: 0x7ADB39290
        public void Compare(){} // RVA: 0x7ADB393F0
        public void Equals(){} // RVA: 0x7ADB39480
        public void CompareOrdinal(){} // RVA: 0x7ADB39730
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7ADB39800
    }

    public class FileBasedResourceGroveler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GrovelForResourceSet(){} // RVA: 0x7ADB398A0
        public void FindResourceFile(){} // RVA: 0x7ADB39BF0
        public void CreateResourceSet(){} // RVA: 0x7ADB39CB0
    }

    public class IResourceGroveler
    {
        // ── Methods ──
        public void GrovelForResourceSet(){} // RVA: 0x7A7E12590
    }

    public class IResourceReader
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x7A7E18770
        public void GetEnumerator(){} // RVA: 0x7A7E00680
    }

    public class ManifestBasedResourceGroveler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GrovelForResourceSet(){} // RVA: 0x7ADB39F60
        public void UltimateFallbackFixup(){} // RVA: 0x7ADB3A4E0
        public void GetNeutralResourcesLanguage(){} // RVA: 0x7ADB3A640
        public void CreateResourceSet(){} // RVA: 0x7ADB3A9D0
        public void GetManifestResourceStream(){} // RVA: 0x7ADB3B4D0
        public void CaseInsensitiveManifestResourceStreamLookup(){} // RVA: 0x7ADB3B640
        public void GetSatelliteAssembly(){} // RVA: 0x7ADB3BB50
        public void CanUseDefaultResourceClasses(){} // RVA: 0x7ADB3BD70
        public void GetSatelliteAssemblyName(){} // RVA: 0x7ADB3BF00
        public void HandleSatelliteMissing(){} // RVA: 0x7ADB3BF80
        public void HandleResourceStreamMissing(){} // RVA: 0x7ADB3C330
        public void GetNeutralResourcesLanguageAttribute(){} // RVA: 0x7ADB3C710
    }

    public class MissingManifestResourceException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class MissingSatelliteAssemblyException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
    }

    public class NeutralResourcesLanguageAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB370C0
        public void get_CultureName(){} // RVA: 0x7A80F2570
        public void get_Location(){} // RVA: 0x7A83782A0
    }

    public class ResourceFallbackManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB37180
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADB37340
        public void GetEnumerator(){} // RVA: 0x7ADB37350
    }

    public class ResourceLocator : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E31570
        public void get_DataPosition(){} // RVA: 0x7A75FEFA0
        public void get_Value(){} // RVA: 0x7A765F710
        public void set_Value(){} // RVA: 0x7A7637E60
        public void CanCache(){} // RVA: 0x7ADB406C0
    }

    public class ResourceManager : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7ADB3C7D0
        public void .ctor(){} // RVA: 0x7ADB3CAD0
        public void OnDeserializing(){} // RVA: 0x7ADB3CF50
        public void OnDeserialized(){} // RVA: 0x7ADB3D050
        public void OnSerializing(){} // RVA: 0x7ADB3D500
        public void CommonAssemblyInit(){} // RVA: 0x7ADB3D620
        public void get_BaseName(){} // RVA: 0x7A80F2570
        public void get_IgnoreCase(){} // RVA: 0x7A8359360
        public void get_FallbackLocation(){} // RVA: 0x7A835E820
        public void GetResourceFileName(){} // RVA: 0x7ADB3D970
        public void GetFirstResourceSet(){} // RVA: 0x7ADB3DB10
        public void GetResourceSet(){} // RVA: 0x7ADB3E190
        public void InternalGetResourceSet(){} // RVA: 0x7ADB3E670
        public void AddResourceSet(){} // RVA: 0x7ADB3ED40
        public void GetSatelliteContractVersion(){} // RVA: 0x7ADB3EFC0
        public void GetNeutralResourcesLanguage(){} // RVA: 0x7ADB3F670
        public void CompareNames(){} // RVA: 0x7ADB3F690
        public void SetAppXConfiguration(){} // RVA: 0x7A80D7310
        public void GetString(){} // RVA: 0x7ADB3FB90
        public void .cctor(){} // RVA: 0x7ADB3FFD0
    }

    public class ResourceReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB406D0
        public void Close(){} // RVA: 0x7ADB408B0
        public void Dispose(){} // RVA: 0x7ADB408C0
        public void ReadUnalignedI4(){} // RVA: 0x7ADB40B10
        public void SkipString(){} // RVA: 0x7ADB40B30
        public void GetNameHash(){} // RVA: 0x7ADB40C00
        public void GetNamePosition(){} // RVA: 0x7ADB40C70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADB40DB0
        public void GetEnumerator(){} // RVA: 0x7ADB40DB0
        public void GetEnumeratorInternal(){} // RVA: 0x7ADB40E70
        public void FindPosForResource(){} // RVA: 0x7ADB40F20
        public void CompareStringEqualsName(){} // RVA: 0x7ADB413E0
        public void AllocateStringForNameIndex(){} // RVA: 0x7ADB417F0
        public void GetValueForNameIndex(){} // RVA: 0x7ADB42000
        public void LoadString(){} // RVA: 0x7ADB42330
        public void LoadObject(){} // RVA: 0x7ADB42680
        public void LoadObjectV1(){} // RVA: 0x7ADB42730
        public void _LoadObjectV1(){} // RVA: 0x7ADB42830
        public void LoadObjectV2(){} // RVA: 0x7ADB430C0
        public void _LoadObjectV2(){} // RVA: 0x7ADB431C0
        public void DeserializeObject(){} // RVA: 0x7ADB43F10
        public void ReadResources(){} // RVA: 0x7ADB440F0
        public void _ReadResources(){} // RVA: 0x7ADB442F0
        public void FindType(){} // RVA: 0x7ADB44E70
    }

    public class ResourceSet : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void CommonInit(){} // RVA: 0x7ADB45BF0
        public void Dispose(){} // RVA: 0x7AD89F110
        public void GetEnumerator(){} // RVA: 0x7ADB45E70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADB45E70
        public void GetEnumeratorHelper(){} // RVA: 0x7ADB45E80
        public void GetString(){} // RVA: 0x7ADB460F0
        public void GetObject(){} // RVA: 0x7ADB464A0
        public void GetObjectInternal(){} // RVA: 0x7ADB463C0
        public void GetCaseInsensitiveObjectInternal(){} // RVA: 0x7ADB465B0
    }

    public class RuntimeResourceSet : ResourceSet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB379C0
        public void Dispose(){} // RVA: 0x7ADB37BB0
        public void GetEnumerator(){} // RVA: 0x7ADB37EE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ADB37EE0
        public void GetEnumeratorHelper(){} // RVA: 0x7ADB37EF0
        public void GetString(){} // RVA: 0x7ADB38020
        public void GetObject(){} // RVA: 0x7ADB38100
        public void ResolveResourceLocator(){} // RVA: 0x7ADB38DF0
    }

    public class SatelliteContractVersionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB39070
        public void get_Version(){} // RVA: 0x7A80F2570
    }

}