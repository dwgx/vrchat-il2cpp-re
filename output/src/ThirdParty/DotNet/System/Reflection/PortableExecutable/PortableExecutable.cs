// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.PortableExecutable
// Classes: 12
// Methods: 72

namespace ThirdParty.DotNet.System.Reflection.PortableExecutable
{
    public class CodeViewDebugDirectoryData : ValueType
    {
        public object _guid;
        public object _age;
        public object _path;

        // ── Methods ──
        public void get_Guid(){} // RVA: 0x7BF80
        public void get_Age(){} // RVA: 0x8C7E0
        public void get_Path(){} // RVA: 0x931A0
        public void .ctor(){} // RVA: 0x8E8790
    }

    public class CoffHeader : Object
    {
        public object _machine;
        public object _numberOfSections;
        public object _timeDateStamp;
        public object _pointerToSymbolTable;
        public object _numberOfSymbols;
        public object _sizeOfOptionalHeader;
        public object _characteristics;

        // ── Methods ──
        public void get_NumberOfSections(){} // RVA: 0x6D099A0
        public void get_TimeDateStamp(){} // RVA: 0x116A650
        public void .ctor(){} // RVA: 0x6D419C0
    }

    public class CorHeader : Object
    {
        public object _majorRuntimeVersion;
        public object _minorRuntimeVersion;
        public object _metadataDirectory;
        public object _flags;
        public object _entryPointTokenOrRelativeVirtualAddress;
        public object _resourcesDirectory;
        public object _strongNameSignatureDirectory;
        public object _codeManagerTableDirectory;
        public object _vtableFixupsDirectory;
        public object _exportAddressTableJumpsDirectory;
        public object _managedNativeHeaderDirectory;

        // ── Methods ──
        public void get_MetadataDirectory(){} // RVA: 0xDD3BB0
        public void .ctor(){} // RVA: 0x6D41A40
    }

    public class DebugDirectoryEntry : ValueType
    {
        public object _stamp;
        public object _majorVersion;
        public object _minorVersion;
        public object _type;
        public object _dataSize;
        public object _dataRelativeVirtualAddress;
        public object _dataPointer;

        // ── Methods ──
        public void get_Stamp(){} // RVA: 0x77E60
        public void get_MinorVersion(){} // RVA: 0x8E87F0
        public void get_Type(){} // RVA: 0x14790
        public void get_DataSize(){} // RVA: 0x92DE0
        public void get_DataRelativeVirtualAddress(){} // RVA: 0x8C7E0
        public void get_DataPointer(){} // RVA: 0xAFF50
        public void get_IsPortableCodeView(){} // RVA: 0x8E8800
        public void .ctor(){} // RVA: 0x8E8810
    }

    public class DirectoryEntry : ValueType
    {
        public object RelativeVirtualAddress;
        public object Size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8E8840
    }

    public class PEBinaryReader : ValueType
    {
        public object _startOffset;
        public object _maxOffset;
        public object _reader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8E8940
        public void get_CurrentOffset(){} // RVA: 0x8E8950
        public void Seek(){} // RVA: 0x8E89A0
        public void ReadBytes(){} // RVA: 0x8E89B0
        public void ReadByte(){} // RVA: 0x8E89C0
        public void ReadInt16(){} // RVA: 0x8E89D0
        public void ReadUInt16(){} // RVA: 0x8E89E0
        public void ReadInt32(){} // RVA: 0x8E89F0
        public void ReadUInt32(){} // RVA: 0x8E8A00
        public void ReadUInt64(){} // RVA: 0x8E8A10
        public void ReadNullPaddedUTF8(){} // RVA: 0x8E8A20
        public void CheckBounds(){} // RVA: 0x8E8A40
    }

    public class PEHeader : Object
    {
        public object _magic;
        public object _majorLinkerVersion;
        public object _minorLinkerVersion;
        public object _sizeOfCode;
        public object _sizeOfInitializedData;
        public object _sizeOfUninitializedData;
        public object _addressOfEntryPoint;
        public object _baseOfCode;
        public object _baseOfData;
        public object _imageBase;
        public object _sectionAlignment;
        public object _fileAlignment;
        public object _majorOperatingSystemVersion;
        public object _minorOperatingSystemVersion;
        public object _majorImageVersion;
        public object _minorImageVersion;
        public object _majorSubsystemVersion;
        public object _minorSubsystemVersion;
        public object _sizeOfImage;
        public object _sizeOfHeaders;
        public object _checkSum;
        public object _subsystem;
        public object _dllCharacteristics;
        public object _sizeOfStackReserve;
        public object _sizeOfStackCommit;
        public object _sizeOfHeapReserve;
        public object _sizeOfHeapCommit;
        public object _numberOfRvaAndSizes;
        public object _exportTableDirectory;
        public object _importTableDirectory;
        public object _resourceTableDirectory;
        public object _exceptionTableDirectory;
        public object _certificateTableDirectory;
        public object _baseRelocationTableDirectory;
        public object _debugTableDirectory;
        public object _copyrightTableDirectory;
        public object _globalPointerTableDirectory;
        public object _threadLocalStorageTableDirectory;
        public object _loadConfigTableDirectory;
        public object _boundImportTableDirectory;
        public object _importAddressTableDirectory;
        public object _delayImportTableDirectory;
        public object _corHeaderTableDirectory;

        // ── Methods ──
        public void get_SizeOfImage(){} // RVA: 0x1D46130
        public void get_DebugTableDirectory(){} // RVA: 0x6A64A30
        public void get_CorHeaderTableDirectory(){} // RVA: 0x6D42310
        public void .ctor(){} // RVA: 0x6D42320
    }

    public class PEHeaders : Object
    {
        public object _coffHeader;
        public object _peHeader;
        public object _sectionHeaders;
        public object _corHeader;
        public object _isLoadedImage;
        public object _metadataStartOffset;
        public object _metadataSize;
        public object _coffHeaderStartOffset;
        public object _corHeaderStartOffset;
        public object _peHeaderStartOffset;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D42860
        public void get_MetadataStartOffset(){} // RVA: 0xE9CE60
        public void get_MetadataSize(){} // RVA: 0x18A0130
        public void get_CoffHeader(){} // RVA: 0xB5DBF0
        public void get_IsCoffOnly(){} // RVA: 0x3911580
        public void get_PEHeader(){} // RVA: 0xB465B0
        public void get_SectionHeaders(){} // RVA: 0xB700F0
        public void TryCalculateCorHeaderOffset(){} // RVA: 0x6D42F70
        public void SkipDosHeader(){} // RVA: 0x6D43040
        public void ReadSectionHeaders(){} // RVA: 0x6D43190
        public void TryGetDirectoryOffset(){} // RVA: 0x6D43520
        public void GetContainingSectionIndex(){} // RVA: 0x6D43800
        public void IndexOfSection(){} // RVA: 0x6D43960
        public void CalculateMetadataLocation(){} // RVA: 0x6D43AD0
    }

    public class PEReader : Object
    {
        public object _isLoadedImage;
        public object _peImage;
        public object _lazyPEHeaders;
        public object _lazyMetadataBlock;
        public object _lazyImageBlock;
        public object _lazyPESectionBlocks;

        // ── Methods ──
        public void get_IsLoadedImage(){} // RVA: 0xC120A0
        public void .ctor(){} // RVA: 0x6D43F10
        public void Dispose(){} // RVA: 0x6D44450
        public void GetPEImage(){} // RVA: 0x6D446C0
        public void get_PEHeaders(){} // RVA: 0x6D446F0
        public void InitializePEHeaders(){} // RVA: 0x6D44720
        public void ReadPEHeadersNoLock(){} // RVA: 0x6D44990
        public void ReadDebugDirectory(){} // RVA: 0x6D44A40
        public void ReadDebugDirectoryEntries(){} // RVA: 0x6D44E70
        public void GetDebugDirectoryEntryDataBlock(){} // RVA: 0x6D451E0
        public void ReadCodeViewDebugDirectoryData(){} // RVA: 0x6D45280
        public void DecodeCodeViewDebugDirectoryData(){} // RVA: 0x6D45490
        public void ReadPdbChecksumDebugDirectoryData(){} // RVA: 0x6D45920
        public void DecodePdbChecksumDebugDirectoryData(){} // RVA: 0x6D45B20
    }

    public class PEStreamOptionsExtensions : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x6D45E00
    }

    public class PdbChecksumDebugDirectoryData : ValueType
    {
        public object _algorithmName;
        public object _checksum;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x77900
        public void get_Checksum(){} // RVA: 0x77ED0
        public void .ctor(){} // RVA: 0x6D3E60
    }

    public class SectionHeader : ValueType
    {
        public object _name;
        public object _virtualSize;
        public object _virtualAddress;
        public object _sizeOfRawData;
        public object _pointerToRawData;
        public object _pointerToRelocations;
        public object _pointerToLineNumbers;
        public object _numberOfRelocations;
        public object _numberOfLineNumbers;
        public object _sectionCharacteristics;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x77900
        public void get_VirtualSize(){} // RVA: 0x14790
        public void get_VirtualAddress(){} // RVA: 0x92DE0
        public void get_SizeOfRawData(){} // RVA: 0x8C7E0
        public void get_PointerToRawData(){} // RVA: 0xAFF50
        public void .ctor(){} // RVA: 0x8E8BB0
    }

}