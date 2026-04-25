// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Resources
// Classes: 15
// Methods: 126

namespace ThirdParty.DotNet.System.Resources
{
    public class FastResourceComparer : Object
    {
        public System.Resources.FastResourceComparer Default;

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC84E2750 | overloaded x2
        public void HashFunction(){} // RVA: 0x7FFAC84E27F0
        public void Compare(){} // RVA: 0x7FFAC84E2950 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC84E29E0 | overloaded x2
        public void CompareOrdinal(){} // RVA: 0x7FFAC84E2C90 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC84E2D60
    }

    public class FileBasedResourceGroveler : Object
    {
        public ResourceManagerMediator _mediator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GrovelForResourceSet(){} // RVA: 0x7FFAC84E2E00
        public void FindResourceFile(){} // RVA: 0x7FFAC84E3150
        public void CreateResourceSet(){} // RVA: 0x7FFAC84E3210
    }

    public class IResourceGroveler
    {
        // ── Methods ──
        public void GrovelForResourceSet(){}
    }

    public class IResourceReader
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x7FFAC2C70980
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class ManifestBasedResourceGroveler : Object
    {
        public ResourceManagerMediator _mediator; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GrovelForResourceSet(){} // RVA: 0x7FFAC84E34C0
        public void UltimateFallbackFixup(){} // RVA: 0x7FFAC84E3A60
        public void GetNeutralResourcesLanguage(){} // RVA: 0x7FFAC84E3BC0
        public void CreateResourceSet(){} // RVA: 0x7FFAC84E3F40
        public void GetManifestResourceStream(){} // RVA: 0x7FFAC84E4A40
        public void CaseInsensitiveManifestResourceStreamLookup(){} // RVA: 0x7FFAC84E4BB0
        public void GetSatelliteAssembly(){} // RVA: 0x7FFAC84E5020
        public void CanUseDefaultResourceClasses(){} // RVA: 0x7FFAC84E5240
        public void GetSatelliteAssemblyName(){} // RVA: 0x7FFAC84E53D0
        public void HandleSatelliteMissing(){} // RVA: 0x7FFAC84E5450
        public void HandleResourceStreamMissing(){} // RVA: 0x7FFAC84E5800
        public void GetNeutralResourcesLanguageAttribute(){} // RVA: 0x7FFAC84E5BE0
    }

    public class MissingManifestResourceException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class MissingSatelliteAssemblyException : SystemException
    {
        public string _cultureName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class NeutralResourcesLanguageAttribute : Attribute
    {
        public string CultureName; // 0x10
        public 0x6B0D7D88 Location; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84E0500
        public void get_CultureName(){} // RVA: 0x7FFAC2F3C380
        public void get_Location(){} // RVA: 0x7FFAC3157800
    }

    public class ResourceFallbackManager : Object
    {
        public System.Globalization.CultureInfo m_startingCulture; // 0x10
        public System.Globalization.CultureInfo m_neutralResourcesCulture; // 0x18
        public bool m_useParents; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84E05C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC84E0780
        public void GetEnumerator(){} // RVA: 0x7FFAC84E0790
    }

    public class ResourceLocator : ValueType
    {
        public object DataPosition; // 0x10
        public int Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84AE640
        public void get_DataPosition(){} // RVA: 0x7FFAC49C7500
        public void get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void set_Value(){} // RVA: 0x7FFAC38DFE40
        public void CanCache(){} // RVA: 0x7FFAC84E9CD0
    }

    public class ResourceManager : Object
    {
        public string BaseName; // 0x10
        public System.Collections.Hashtable IgnoreCase; // 0x18
        public System.Collections.Generic.Dictionary`2<string,System.Resources.ResourceSet> FallbackLocation; // 0x20
        public string moduleDir; // 0x28
        public System.Reflection.Assembly MainAssembly; // 0x30
        public System.Type _locationInfo; // 0x38
        public System.Type _userResourceSet; // 0x40
        public System.Globalization.CultureInfo _neutralResourcesCulture; // 0x48
        public CultureNameResourceSetPair _lastUsedResourceCache; // 0x50
        public bool _ignoreCase; // 0x58
        public bool UseManifest; // 0x59
        public bool UseSatelliteAssem; // 0x5A
        public 0x6B0D7D88 _fallbackLoc; // 0x5C
        public System.Version _satelliteContractVersion; // 0x60
        public bool _lookedForSatelliteContractVersion; // 0x68
        public System.Reflection.Assembly _callingAssembly; // 0x70
        public System.Reflection.RuntimeAssembly m_callingAssembly; // 0x78
        public System.Resources.IResourceGroveler resourceGroveler; // 0x80
        public int MagicNumber;
        public int HeaderVersionNumber; // 0x4
        public System.Type _minResourceSet; // 0x8
        public string ResReaderTypeName; // 0x10
        public string ResSetTypeName; // 0x18
        public string MscorlibName; // 0x20
        public int DEBUG; // 0x28

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC84E5CA0
        public void .ctor(){} // RVA: 0x7FFAC84E5FA0 | overloaded x2
        public void OnDeserializing(){} // RVA: 0x7FFAC84E6420
        public void OnDeserialized(){} // RVA: 0x7FFAC84E6520
        public void OnSerializing(){} // RVA: 0x7FFAC84E69D0
        public void CommonAssemblyInit(){} // RVA: 0x7FFAC84E6AF0
        public void get_BaseName(){} // RVA: 0x7FFAC2F3C380
        public void get_IgnoreCase(){} // RVA: 0x7FFAC313F600
        public void get_FallbackLocation(){} // RVA: 0x7FFAC313CBA0
        public void GetResourceFileName(){} // RVA: 0x7FFAC84E6E40
        public void GetFirstResourceSet(){} // RVA: 0x7FFAC84E6FE0
        public void GetResourceSet(){} // RVA: 0x7FFAC84E76D0
        public void InternalGetResourceSet(){} // RVA: 0x7FFAC84E7BE0 | overloaded x2
        public void AddResourceSet(){} // RVA: 0x7FFAC84E82E0
        public void GetSatelliteContractVersion(){} // RVA: 0x7FFAC84E85B0
        public void GetNeutralResourcesLanguage(){} // RVA: 0x7FFAC84E8C50
        public void CompareNames(){} // RVA: 0x7FFAC84E8C70
        public void SetAppXConfiguration(){} // RVA: 0x7FFAC2F21310
        public void GetString(){} // RVA: 0x7FFAC84E9170 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC84E95B0
    }

    public class ResourceReader : Object
    {
        public System.IO.BinaryReader _store; // 0x10
        public System.Collections.Generic.Dictionary`2<string,System.Resources.ResourceLocator> _resCache; // 0x18
        public long _nameSectionOffset; // 0x20
        public long _dataSectionOffset; // 0x28
        public int[] _nameHashes; // 0x30
        public int* _nameHashesPtr; // 0x38
        public int[] _namePositions; // 0x40
        public int* _namePositionsPtr; // 0x48
        public System.RuntimeType[] _typeTable; // 0x50
        public int[] _typeNamePositions; // 0x58
        public System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _objFormatter; // 0x60
        public int _numResources; // 0x68
        public System.IO.UnmanagedMemoryStream _ums; // 0x70
        public int _version; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84E9CE0
        public void Close(){} // RVA: 0x7FFAC84E9EC0
        public void Dispose(){} // RVA: 0x7FFAC84E9ED0 | overloaded x2
        public void ReadUnalignedI4(){} // RVA: 0x7FFAC84EA120
        public void SkipString(){} // RVA: 0x7FFAC84EA140
        public void GetNameHash(){} // RVA: 0x7FFAC84EA210
        public void GetNamePosition(){} // RVA: 0x7FFAC84EA280
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC84EA3C0
        public void GetEnumerator(){} // RVA: 0x7FFAC84EA3C0
        public void GetEnumeratorInternal(){} // RVA: 0x7FFAC84EA480
        public void FindPosForResource(){} // RVA: 0x7FFAC84EA530
        public void CompareStringEqualsName(){} // RVA: 0x7FFAC84EAA50
        public void AllocateStringForNameIndex(){} // RVA: 0x7FFAC84EAE60
        public void GetValueForNameIndex(){} // RVA: 0x7FFAC84EB6A0
        public void LoadString(){} // RVA: 0x7FFAC84EBA00
        public void LoadObject(){} // RVA: 0x7FFAC84EBD50 | overloaded x2
        public void LoadObjectV1(){} // RVA: 0x7FFAC84EBE00
        public void _LoadObjectV1(){} // RVA: 0x7FFAC84EBF00
        public void LoadObjectV2(){} // RVA: 0x7FFAC84EC790
        public void _LoadObjectV2(){} // RVA: 0x7FFAC84EC890
        public void DeserializeObject(){} // RVA: 0x7FFAC84ED5A0
        public void ReadResources(){} // RVA: 0x7FFAC84ED780
        public void _ReadResources(){} // RVA: 0x7FFAC84ED990
        public void FindType(){} // RVA: 0x7FFAC84EE4D0
    }

    public class ResourceSet : Object
    {
        public System.Resources.IResourceReader Reader; // 0x10
        public System.Collections.Hashtable Table; // 0x18
        public System.Collections.Hashtable _caseInsensitiveTable; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void CommonInit(){} // RVA: 0x7FFAC84EF2C0
        public void Dispose(){} // RVA: 0x7FFAC82490B0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC84EF540
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC84EF540
        public void GetEnumeratorHelper(){} // RVA: 0x7FFAC84EF550
        public void GetString(){} // RVA: 0x7FFAC84EF7C0 | overloaded x2
        public void GetObject(){} // RVA: 0x7FFAC84EFB70 | overloaded x2
        public void GetObjectInternal(){} // RVA: 0x7FFAC84EFA90
        public void GetCaseInsensitiveObjectInternal(){} // RVA: 0x7FFAC84EFC80
    }

    public class RuntimeResourceSet : ResourceSet
    {
        public int Version;
        public System.Collections.Generic.Dictionary`2<string,System.Resources.ResourceLocator> _resCache; // 0x28
        public System.Resources.ResourceReader _defaultReader; // 0x30
        public System.Collections.Generic.Dictionary`2<string,System.Resources.ResourceLocator> _caseInsensitiveTable; // 0x38
        public bool _haveReadFromReader; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84E0E00 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC84E0FE0
        public void GetEnumerator(){} // RVA: 0x7FFAC84E1340
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC84E1340
        public void GetEnumeratorHelper(){} // RVA: 0x7FFAC84E1350
        public void GetString(){} // RVA: 0x7FFAC84E1480 | overloaded x2
        public void GetObject(){} // RVA: 0x7FFAC84E1560 | overloaded x3
        public void ResolveResourceLocator(){} // RVA: 0x7FFAC84E2320
    }

    public class SatelliteContractVersionAttribute : Attribute
    {
        public string Version; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84E25D0
        public void get_Version(){} // RVA: 0x7FFAC2F3C380
    }

}