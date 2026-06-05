// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.PortableExecutable
// Classes: 12
// Methods: 78

namespace ThirdParty.DotNet.System.Reflection.PortableExecutable
{
    public class CodeViewDebugDirectoryData
    {
        public object Stamp;
        public object MinorVersion;
        public object Type;

        // ── Methods ──
        public void get_Guid(){} // RVA: 0x7FFAF320E7E0
        public void get_Age(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Path(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF8D84F00
    }

    public class CoffHeader
    {
        // ── Methods ──
        public void get_NumberOfSections(){} // RVA: 0x7FFAF8D4CA20
        public void get_TimeDateStamp(){} // RVA: 0x7FFAF335BED0
        public void .ctor(){} // RVA: 0x7FFAF8D84D20
    }

    public class CorHeader
    {
        public object Guid;

        // ── Methods ──
        public void get_MetadataDirectory(){} // RVA: 0x7FFAF2FF4FD0
        public void .ctor(){} // RVA: 0x7FFAF8D84DA0
    }

    public class DebugDirectoryEntry
    {
        // ── Methods ──
        public void get_Stamp(){} // RVA: 0x7FFAF44189B0
        public void get_MinorVersion(){} // RVA: 0x7FFAF8D84F60
        public void get_Type(){} // RVA: 0x7FFAF4959890
        public void get_DataSize(){} // RVA: 0x7FFAF49598B0
        public void get_DataRelativeVirtualAddress(){} // RVA: 0x7FFAF2DDA5C0
        public void get_DataPointer(){} // RVA: 0x7FFAF335BED0
        public void get_IsPortableCodeView(){} // RVA: 0x7FFAF8D84F70
        public void .ctor(){} // RVA: 0x7FFAF8D84F80
    }

    public class DirectoryEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D84FB0
    }

    public class PEBinaryReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D84FF0
        public void get_CurrentOffset(){} // RVA: 0x7FFAF8D850F0
        public void Seek(){} // RVA: 0x7FFAF8D85140
        public void ReadBytes(){} // RVA: 0x7FFAF8D851B0
        public void ReadByte(){} // RVA: 0x7FFAF8D85240
        public void ReadInt16(){} // RVA: 0x7FFAF8D852C0
        public void ReadUInt16(){} // RVA: 0x7FFAF8D85340
        public void ReadInt32(){} // RVA: 0x7FFAF8D853C0
        public void ReadUInt32(){} // RVA: 0x7FFAF8D85440
        public void ReadUInt64(){} // RVA: 0x7FFAF8D854C0
        public void ReadNullPaddedUTF8(){} // RVA: 0x7FFAF8D85540
        public void CheckBounds(){} // RVA: 0x7FFAF8D85640 | overloaded x2
    }

    public class PEHeader
    {
        public object MetadataStartOffset;
        public object MetadataSize;
        public object CoffHeader;

        // ── Methods ──
        public void get_SizeOfImage(){} // RVA: 0x7FFAF3F29960
        public void get_DebugTableDirectory(){} // RVA: 0x7FFAF8AA04C0
        public void get_CorHeaderTableDirectory(){} // RVA: 0x7FFAF8D85660
        public void .ctor(){} // RVA: 0x7FFAF8D85670
    }

    public class PEHeaders
    {
        public object IsLoadedImage;
        public object PEHeaders;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D85BB0 | overloaded x3
        public void get_MetadataStartOffset(){} // RVA: 0x7FFAF2F76670
        public void get_MetadataSize(){} // RVA: 0x7FFAF3A8C9F0
        public void get_CoffHeader(){} // RVA: 0x7FFAF2DA8380
        public void get_IsCoffOnly(){} // RVA: 0x7FFAF5982970
        public void get_PEHeader(){} // RVA: 0x7FFAF2D907C0
        public void get_SectionHeaders(){} // RVA: 0x7FFAF2DBB0C0
        public void TryCalculateCorHeaderOffset(){} // RVA: 0x7FFAF8D862C0
        public void SkipDosHeader(){} // RVA: 0x7FFAF8D86390
        public void ReadSectionHeaders(){} // RVA: 0x7FFAF8D864E0
        public void TryGetDirectoryOffset(){} // RVA: 0x7FFAF8D86860 | overloaded x2
        public void GetContainingSectionIndex(){} // RVA: 0x7FFAF8D86B60
        public void IndexOfSection(){} // RVA: 0x7FFAF8D86CB0
        public void CalculateMetadataLocation(){} // RVA: 0x7FFAF8D86E10
    }

    public class PEReader
    {
        // ── Methods ──
        public void get_IsLoadedImage(){} // RVA: 0x7FFAF2E575E0
        public void .ctor(){} // RVA: 0x7FFAF8D87250 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAF8D877B0
        public void GetPEImage(){} // RVA: 0x7FFAF8D87A10
        public void get_PEHeaders(){} // RVA: 0x7FFAF8D87A40
        public void InitializePEHeaders(){} // RVA: 0x7FFAF8D87A70
        public void ReadPEHeadersNoLock(){} // RVA: 0x7FFAF8D87D00
        public void ReadDebugDirectory(){} // RVA: 0x7FFAF8D87DB0
        public void ReadDebugDirectoryEntries(){} // RVA: 0x7FFAF8D881D0
        public void GetDebugDirectoryEntryDataBlock(){} // RVA: 0x7FFAF8D88540
        public void ReadCodeViewDebugDirectoryData(){} // RVA: 0x7FFAF8D885E0
        public void DecodeCodeViewDebugDirectoryData(){} // RVA: 0x7FFAF8D887E0
        public void ReadPdbChecksumDebugDirectoryData(){} // RVA: 0x7FFAF8D88C70
        public void DecodePdbChecksumDebugDirectoryData(){} // RVA: 0x7FFAF8D88E70
    }

    public class PEStreamOptionsExtensions
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAF8D89150
    }

    public class PdbChecksumDebugDirectoryData
    {
        public object NumberOfSections;
        public object TimeDateStamp;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF4584690
        public void get_Checksum(){} // RVA: 0x7FFAF44189C0
        public void .ctor(){} // RVA: 0x7FFAF6278AF0
    }

    public class SectionHeader
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF4584690
        public void get_VirtualSize(){} // RVA: 0x7FFAF4959890
        public void get_VirtualAddress(){} // RVA: 0x7FFAF49598B0
        public void get_SizeOfRawData(){} // RVA: 0x7FFAF2DDA5C0
        public void get_PointerToRawData(){} // RVA: 0x7FFAF335BED0
        public void .ctor(){} // RVA: 0x7FFAF8D89160
    }

}