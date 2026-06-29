// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Resources
// Classes: 15
// Methods: 104

namespace ThirdParty.DotNet.System.Resources
{
    public class FastResourceComparer : Object
    {
        public object Default;

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x67C38C0
        public void HashFunction(){} // RVA: 0x67C3960
        public void Compare(){} // RVA: 0x67C3A80
        public void Equals(){} // RVA: 0x67C3B10
        public void CompareOrdinal(){} // RVA: 0x67C3D90
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x67C3E60
    }

    public class FileBasedResourceGroveler : Object
    {
        public object _mediator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GrovelForResourceSet(){} // RVA: 0x67C3F00
        public void FindResourceFile(){} // RVA: 0x67C4250
        public void CreateResourceSet(){} // RVA: 0x67C4310
    }

    public class IResourceGroveler
    {
        // ── Methods ──
        public void GrovelForResourceSet(){} // RVA: 0x88E020
    }

    public class IResourceReader
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x894290
        public void GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class ManifestBasedResourceGroveler : Object
    {
        public object _mediator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GrovelForResourceSet(){} // RVA: 0x67C45B0
        public void UltimateFallbackFixup(){} // RVA: 0x67C4B30
        public void GetNeutralResourcesLanguage(){} // RVA: 0x67C4C90
        public void CreateResourceSet(){} // RVA: 0x67C5000
        public void GetManifestResourceStream(){} // RVA: 0x67C5AE0
        public void CaseInsensitiveManifestResourceStreamLookup(){} // RVA: 0x67C5C50
        public void GetSatelliteAssembly(){} // RVA: 0x67C6140
        public void CanUseDefaultResourceClasses(){} // RVA: 0x67C6360
        public void GetSatelliteAssemblyName(){} // RVA: 0x67C64E0
        public void HandleSatelliteMissing(){} // RVA: 0x67C6560
        public void HandleResourceStreamMissing(){} // RVA: 0x67C6910
        public void GetNeutralResourcesLanguageAttribute(){} // RVA: 0x67C6C80
    }

    public class MissingManifestResourceException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class MissingSatelliteAssemblyException : SystemException
    {
        public object _cultureName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class NeutralResourcesLanguageAttribute : Attribute
    {
        public object _cultureName;
        public object _location;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67C1840
        public void get_CultureName(){} // RVA: 0xB5DBF0
        public void get_Location(){} // RVA: 0xE62D00
    }

    public class ResourceFallbackManager : Object
    {
        public object m_startingCulture;
        public object m_neutralResourcesCulture;
        public object m_useParents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67C1900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x67C1AC0
        public void GetEnumerator(){} // RVA: 0x67C1AD0
    }

    public class ResourceLocator : ValueType
    {
        public object _value;
        public object _dataPos;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AE600
        public void get_DataPosition(){} // RVA: 0x14790
        public void get_Value(){} // RVA: 0x77900
        public void set_Value(){} // RVA: 0x47F10
        public void CanCache(){} // RVA: 0x67CAB50
    }

    public class ResourceManager : Object
    {
        public object BaseNameField;
        public object ResourceSets;
        public object _resourceSets;
        public object moduleDir;
        public object MainAssembly;
        public object _locationInfo;
        public object _userResourceSet;
        public object _neutralResourcesCulture;
        public object _lastUsedResourceCache;
        public object _ignoreCase;
        public object UseManifest;
        public object UseSatelliteAssem;
        public object _fallbackLoc;
        public object _satelliteContractVersion;
        public object _lookedForSatelliteContractVersion;
        public object _callingAssembly;
        public object m_callingAssembly;
        public object resourceGroveler;
        public object MagicNumber;
        public object HeaderVersionNumber;
        public object _minResourceSet;
        public object ResReaderTypeName;
        public object ResSetTypeName;
        public object MscorlibName;
        public object DEBUG;

        // ── Methods ──
        public void Init(){} // RVA: 0x67C6D40
        public void .ctor(){} // RVA: 0x67C7040
        public void OnDeserializing(){} // RVA: 0x67C74C0
        public void OnDeserialized(){} // RVA: 0x67C75C0
        public void OnSerializing(){} // RVA: 0x67C7A70
        public void CommonAssemblyInit(){} // RVA: 0x67C7B90
        public void get_BaseName(){} // RVA: 0xB5DBF0
        public void get_IgnoreCase(){} // RVA: 0xE3F480
        public void get_FallbackLocation(){} // RVA: 0xE36310
        public void GetResourceFileName(){} // RVA: 0x67C7EE0
        public void GetFirstResourceSet(){} // RVA: 0x67C8080
        public void GetResourceSet(){} // RVA: 0x67C8700
        public void InternalGetResourceSet(){} // RVA: 0x67C8BE0
        public void AddResourceSet(){} // RVA: 0x67C92B0
        public void GetSatelliteContractVersion(){} // RVA: 0x67C9530
        public void GetNeutralResourcesLanguage(){} // RVA: 0x67C9BA0
        public void CompareNames(){} // RVA: 0x67C9BC0
        public void SetAppXConfiguration(){} // RVA: 0xB43310
        public void GetString(){} // RVA: 0x67CA0B0
        public void .cctor(){} // RVA: 0x67CA4F0
    }

    public class ResourceReader : Object
    {
        public object _store;
        public object _resCache;
        public object _nameSectionOffset;
        public object _dataSectionOffset;
        public object _nameHashes;
        public object _nameHashesPtr;
        public object _namePositions;
        public object _namePositionsPtr;
        public object _typeTable;
        public object _typeNamePositions;
        public object _objFormatter;
        public object _numResources;
        public object _ums;
        public object _version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67CAB60
        public void Close(){} // RVA: 0x67CAD40
        public void Dispose(){} // RVA: 0x67CAD50
        public void ReadUnalignedI4(){} // RVA: 0x67CAFA0
        public void SkipString(){} // RVA: 0x67CAFC0
        public void GetNameHash(){} // RVA: 0x67CB090
        public void GetNamePosition(){} // RVA: 0x67CB100
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x67CB230
        public void GetEnumerator(){} // RVA: 0x67CB230
        public void GetEnumeratorInternal(){} // RVA: 0x67CB2F0
        public void FindPosForResource(){} // RVA: 0x67CB3A0
        public void CompareStringEqualsName(){} // RVA: 0x67CB850
        public void AllocateStringForNameIndex(){} // RVA: 0x67CBC60
        public void GetValueForNameIndex(){} // RVA: 0x67CC450
        public void LoadString(){} // RVA: 0x67CC770
        public void LoadObject(){} // RVA: 0x67CCAC0
        public void LoadObjectV1(){} // RVA: 0x67CCB20
        public void _LoadObjectV1(){} // RVA: 0x67CCC20
        public void LoadObjectV2(){} // RVA: 0x67CD390
        public void _LoadObjectV2(){} // RVA: 0x67CD490
        public void DeserializeObject(){} // RVA: 0x67CE0F0
        public void ReadResources(){} // RVA: 0x67CE2A0
        public void _ReadResources(){} // RVA: 0x67CE4A0
        public void FindType(){} // RVA: 0x67CF010
    }

    public class ResourceSet : Object
    {
        public object Reader;
        public object Table;
        public object _caseInsensitiveTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CommonInit(){} // RVA: 0x67CFD80
        public void Dispose(){} // RVA: 0x652C5D0
        public void GetEnumerator(){} // RVA: 0x67D0000
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x67D0000
        public void GetEnumeratorHelper(){} // RVA: 0x67D0010
        public void GetString(){} // RVA: 0x67D0250
        public void GetObject(){} // RVA: 0x67D05E0
        public void GetObjectInternal(){} // RVA: 0x67D0500
        public void GetCaseInsensitiveObjectInternal(){} // RVA: 0x67D06F0
    }

    public class RuntimeResourceSet : ResourceSet
    {
        public object Version;
        public object _resCache;
        public object _defaultReader;
        public object _caseInsensitiveTable;
        public object _haveReadFromReader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67C2140
        public void Dispose(){} // RVA: 0x67C2330
        public void GetEnumerator(){} // RVA: 0x67C2660
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x67C2660
        public void GetEnumeratorHelper(){} // RVA: 0x67C2670
        public void GetString(){} // RVA: 0x67C2760
        public void GetObject(){} // RVA: 0x67C27E0
        public void ResolveResourceLocator(){} // RVA: 0x67C3500
    }

    public class SatelliteContractVersionAttribute : Attribute
    {
        public object _version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67C3750
        public void get_Version(){} // RVA: 0xB5DBF0
    }

}