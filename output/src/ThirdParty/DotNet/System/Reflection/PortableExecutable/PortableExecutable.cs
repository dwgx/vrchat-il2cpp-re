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
        public void get_Guid(){} // RVA: 0x75E7E0
        public void get_Age(){} // RVA: 0x32A5C0
        public void get_Path(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x62D4F00
    }

    public class CoffHeader
    {
        // ── Methods ──
        public void get_NumberOfSections(){} // RVA: 0x629CA20
        public void get_TimeDateStamp(){} // RVA: 0x8ABED0
        public void .ctor(){} // RVA: 0x62D4D20
    }

    public class CorHeader
    {
        public object Guid;

        // ── Methods ──
        public void get_MetadataDirectory(){} // RVA: 0x544FD0
        public void .ctor(){} // RVA: 0x62D4DA0
    }

    public class DebugDirectoryEntry
    {
        // ── Methods ──
        public void get_Stamp(){} // RVA: 0x19689B0
        public void get_MinorVersion(){} // RVA: 0x62D4F60
        public void get_Type(){} // RVA: 0x1EA9890
        public void get_DataSize(){} // RVA: 0x1EA98B0
        public void get_DataRelativeVirtualAddress(){} // RVA: 0x32A5C0
        public void get_DataPointer(){} // RVA: 0x8ABED0
        public void get_IsPortableCodeView(){} // RVA: 0x62D4F70
        public void .ctor(){} // RVA: 0x62D4F80
    }

    public class DirectoryEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62D4FB0
    }

    public class PEBinaryReader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62D4FF0
        public void get_CurrentOffset(){} // RVA: 0x62D50F0
        public void Seek(){} // RVA: 0x62D5140
        public void ReadBytes(){} // RVA: 0x62D51B0
        public void ReadByte(){} // RVA: 0x62D5240
        public void ReadInt16(){} // RVA: 0x62D52C0
        public void ReadUInt16(){} // RVA: 0x62D5340
        public void ReadInt32(){} // RVA: 0x62D53C0
        public void ReadUInt32(){} // RVA: 0x62D5440
        public void ReadUInt64(){} // RVA: 0x62D54C0
        public void ReadNullPaddedUTF8(){} // RVA: 0x62D5540
        public void CheckBounds(){} // RVA: 0x62D5640 | overloaded x2
    }

    public class PEHeader
    {
        public object MetadataStartOffset;
        public object MetadataSize;
        public object CoffHeader;

        // ── Methods ──
        public void get_SizeOfImage(){} // RVA: 0x1479960
        public void get_DebugTableDirectory(){} // RVA: 0x5FF04C0
        public void get_CorHeaderTableDirectory(){} // RVA: 0x62D5660
        public void .ctor(){} // RVA: 0x62D5670
    }

    public class PEHeaders
    {
        public object IsLoadedImage;
        public object PEHeaders;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x62D5BB0 | overloaded x3
        public void get_MetadataStartOffset(){} // RVA: 0x4C6670
        public void get_MetadataSize(){} // RVA: 0xFDC9F0
        public void get_CoffHeader(){} // RVA: 0x2F8380
        public void get_IsCoffOnly(){} // RVA: 0x2ED2970
        public void get_PEHeader(){} // RVA: 0x2E07C0
        public void get_SectionHeaders(){} // RVA: 0x30B0C0
        public void TryCalculateCorHeaderOffset(){} // RVA: 0x62D62C0
        public void SkipDosHeader(){} // RVA: 0x62D6390
        public void ReadSectionHeaders(){} // RVA: 0x62D64E0
        public void TryGetDirectoryOffset(){} // RVA: 0x62D6860 | overloaded x2
        public void GetContainingSectionIndex(){} // RVA: 0x62D6B60
        public void IndexOfSection(){} // RVA: 0x62D6CB0
        public void CalculateMetadataLocation(){} // RVA: 0x62D6E10
    }

    public class PEReader
    {
        // ── Methods ──
        public void get_IsLoadedImage(){} // RVA: 0x3A75E0
        public void .ctor(){} // RVA: 0x62D7250 | overloaded x3
        public void Dispose(){} // RVA: 0x62D77B0
        public void GetPEImage(){} // RVA: 0x62D7A10
        public void get_PEHeaders(){} // RVA: 0x62D7A40
        public void InitializePEHeaders(){} // RVA: 0x62D7A70
        public void ReadPEHeadersNoLock(){} // RVA: 0x62D7D00
        public void ReadDebugDirectory(){} // RVA: 0x62D7DB0
        public void ReadDebugDirectoryEntries(){} // RVA: 0x62D81D0
        public void GetDebugDirectoryEntryDataBlock(){} // RVA: 0x62D8540
        public void ReadCodeViewDebugDirectoryData(){} // RVA: 0x62D85E0
        public void DecodeCodeViewDebugDirectoryData(){} // RVA: 0x62D87E0
        public void ReadPdbChecksumDebugDirectoryData(){} // RVA: 0x62D8C70
        public void DecodePdbChecksumDebugDirectoryData(){} // RVA: 0x62D8E70
    }

    public class PEStreamOptionsExtensions
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x62D9150
    }

    public class PdbChecksumDebugDirectoryData
    {
        public object NumberOfSections;
        public object TimeDateStamp;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x1AD4690
        public void get_Checksum(){} // RVA: 0x19689C0
        public void .ctor(){} // RVA: 0x37C8AF0
    }

    public class SectionHeader
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x1AD4690
        public void get_VirtualSize(){} // RVA: 0x1EA9890
        public void get_VirtualAddress(){} // RVA: 0x1EA98B0
        public void get_SizeOfRawData(){} // RVA: 0x32A5C0
        public void get_PointerToRawData(){} // RVA: 0x8ABED0
        public void .ctor(){} // RVA: 0x62D9160
    }

}