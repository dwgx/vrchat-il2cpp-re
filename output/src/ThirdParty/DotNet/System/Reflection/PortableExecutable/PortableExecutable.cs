// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.PortableExecutable
// Classes: 12
// Methods: 78

namespace ThirdParty.DotNet.System.Reflection.PortableExecutable
{
    public class CodeViewDebugDirectoryData : ValueType
    {
        public System.Guid _guid; // 0x10
        public int _age; // 0x20
        public string _path; // 0x28

        // ── Methods ──
        public void get_Guid(){} // RVA: 0x7FFE8151C410
        public void get_Age(){} // RVA: 0x7FFE811485C0
        public void get_Path(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE86E15930
    }

    public class CoffHeader : Object
    {
        public 0x6668E81C _machine; // 0x10
        public short _numberOfSections; // 0x12

        // ── Methods ──
        public void get_NumberOfSections(){} // RVA: 0x7FFE86DDD450
        public void get_TimeDateStamp(){} // RVA: 0x7FFE8164B230
        public void .ctor(){} // RVA: 0x7FFE86E15750
    }

    public class CorHeader : Object
    {
        public ushort _majorRuntimeVersion; // 0x10

        // ── Methods ──
        public void get_MetadataDirectory(){} // RVA: 0x7FFE8134BAC0
        public void .ctor(){} // RVA: 0x7FFE86E157D0
    }

    public class DebugDirectoryEntry : ValueType
    {
        public uint _stamp; // 0x10
        public ushort _majorVersion; // 0x14
        public ushort _minorVersion; // 0x16
        public 0x6668E76C _type; // 0x18
        public int _dataSize; // 0x1C
        public int _dataRelativeVirtualAddress; // 0x20
        public int _dataPointer; // 0x24

        // ── Methods ──
        public void get_Stamp(){} // RVA: 0x7FFE826F4220
        public void get_MinorVersion(){} // RVA: 0x7FFE86E15990
        public void get_Type(){} // RVA: 0x7FFE82C33000
        public void get_DataSize(){} // RVA: 0x7FFE82C33020
        public void get_DataRelativeVirtualAddress(){} // RVA: 0x7FFE811485C0
        public void get_DataPointer(){} // RVA: 0x7FFE8164B230
        public void get_IsPortableCodeView(){} // RVA: 0x7FFE86E159A0
        public void .ctor(){} // RVA: 0x7FFE86E159B0
    }

    public class DirectoryEntry : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E159E0
    }

    public class PEBinaryReader : ValueType
    {
        public long _startOffset; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E15A20
        public void get_CurrentOffset(){} // RVA: 0x7FFE86E15B20
        public void Seek(){} // RVA: 0x7FFE86E15B70
        public void ReadBytes(){} // RVA: 0x7FFE86E15BE0
        public void ReadByte(){} // RVA: 0x7FFE86E15C70
        public void ReadInt16(){} // RVA: 0x7FFE86E15CF0
        public void ReadUInt16(){} // RVA: 0x7FFE86E15D70
        public void ReadInt32(){} // RVA: 0x7FFE86E15DF0
        public void ReadUInt32(){} // RVA: 0x7FFE86E15E70
        public void ReadUInt64(){} // RVA: 0x7FFE86E15EF0
        public void ReadNullPaddedUTF8(){} // RVA: 0x7FFE86E15F70
        public void CheckBounds(){} // RVA: 0x7FFE86E16070 | overloaded x2
    }

    public class PEHeader : Object
    {
        public 0x6668E924 _magic; // 0x10
        public byte _majorLinkerVersion; // 0x12
        public byte _minorLinkerVersion; // 0x13

        // ── Methods ──
        public void get_SizeOfImage(){} // RVA: 0x7FFE821E0A40
        public void get_DebugTableDirectory(){} // RVA: 0x7FFE86B312A0
        public void get_CorHeaderTableDirectory(){} // RVA: 0x7FFE86E16090
        public void .ctor(){} // RVA: 0x7FFE86E160A0
    }

    public class PEHeaders : Object
    {
        public System.Reflection.PortableExecutable.CoffHeader _coffHeader; // 0x10
        public System.Reflection.PortableExecutable.PEHeader _peHeader; // 0x18
        public System.Collections.Immutable.ImmutableArray`1<System.Reflection.PortableExecutable.SectionHeader> _sectionHeaders; // 0x20
        public System.Reflection.PortableExecutable.CorHeader _corHeader; // 0x28
        public bool _isLoadedImage; // 0x30
        public int _metadataStartOffset; // 0x34

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E165E0 | overloaded x3
        public void get_MetadataStartOffset(){} // RVA: 0x7FFE82447220
        public void get_MetadataSize(){} // RVA: 0x7FFE81D46090
        public void get_CoffHeader(){} // RVA: 0x7FFE81116380
        public void get_IsCoffOnly(){} // RVA: 0x7FFE83BA1AA0
        public void get_PEHeader(){} // RVA: 0x7FFE810FE7C0
        public void get_SectionHeaders(){} // RVA: 0x7FFE811290C0
        public void TryCalculateCorHeaderOffset(){} // RVA: 0x7FFE86E16CF0
        public void SkipDosHeader(){} // RVA: 0x7FFE86E16DC0
        public void ReadSectionHeaders(){} // RVA: 0x7FFE86E16F10
        public void TryGetDirectoryOffset(){} // RVA: 0x7FFE86E17290 | overloaded x2
        public void GetContainingSectionIndex(){} // RVA: 0x7FFE86E17590
        public void IndexOfSection(){} // RVA: 0x7FFE86E176E0
        public void CalculateMetadataLocation(){} // RVA: 0x7FFE86E17840
    }

    public class PEReader : Object
    {
        public bool _isLoadedImage; // 0x10
        public System.Reflection.Internal.MemoryBlockProvider _peImage; // 0x18

        // ── Methods ──
        public void get_IsLoadedImage(){} // RVA: 0x7FFE811C55E0
        public void .ctor(){} // RVA: 0x7FFE86E17C80 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFE86E181E0
        public void GetPEImage(){} // RVA: 0x7FFE86E18440
        public void get_PEHeaders(){} // RVA: 0x7FFE86E18470
        public void InitializePEHeaders(){} // RVA: 0x7FFE86E184A0
        public void ReadPEHeadersNoLock(){} // RVA: 0x7FFE86E18730
        public void ReadDebugDirectory(){} // RVA: 0x7FFE86E187E0
        public void ReadDebugDirectoryEntries(){} // RVA: 0x7FFE86E18C00
        public void GetDebugDirectoryEntryDataBlock(){} // RVA: 0x7FFE86E18F70
        public void ReadCodeViewDebugDirectoryData(){} // RVA: 0x7FFE86E19010
        public void DecodeCodeViewDebugDirectoryData(){} // RVA: 0x7FFE86E19210
        public void ReadPdbChecksumDebugDirectoryData(){} // RVA: 0x7FFE86E196A0
        public void DecodePdbChecksumDebugDirectoryData(){} // RVA: 0x7FFE86E198A0
    }

    public class PEStreamOptionsExtensions : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE86E19B80
    }

    public class PdbChecksumDebugDirectoryData : ValueType
    {
        public string _algorithmName; // 0x10
        public System.Collections.Immutable.ImmutableArray`1<byte> _checksum; // 0x18

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8284EF60
        public void get_Checksum(){} // RVA: 0x7FFE826F4210
        public void .ctor(){} // RVA: 0x7FFE84459530
    }

    public class SectionHeader : ValueType
    {
        public string _name; // 0x10
        public int _virtualSize; // 0x18
        public int _virtualAddress; // 0x1C
        public int _sizeOfRawData; // 0x20
        public int _pointerToRawData; // 0x24

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE8284EF60
        public void get_VirtualSize(){} // RVA: 0x7FFE82C33000
        public void get_VirtualAddress(){} // RVA: 0x7FFE82C33020
        public void get_SizeOfRawData(){} // RVA: 0x7FFE811485C0
        public void get_PointerToRawData(){} // RVA: 0x7FFE8164B230
        public void .ctor(){} // RVA: 0x7FFE86E19B90
    }

}