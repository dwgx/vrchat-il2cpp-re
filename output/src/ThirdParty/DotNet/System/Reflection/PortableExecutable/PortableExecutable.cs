// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.PortableExecutable
// Classes: 12
// Methods: 78

namespace ThirdParty.DotNet.System.Reflection.PortableExecutable
{
    public class CodeViewDebugDirectoryData : ValueType
    {
        public System.Guid Guid; // 0x10
        public int Age; // 0x20
        public string Path; // 0x28

        // ── Methods ──
        public void get_Guid(){} // RVA: 0x7FFAC32C0590
        public void get_Age(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Path(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC8A6C2A0
    }

    public class CoffHeader : Object
    {
        public 0x6B294A30 NumberOfSections; // 0x10
        public short TimeDateStamp; // 0x12
        public int <TimeDateStamp>k__BackingField; // 0x14
        public int <PointerToSymbolTable>k__BackingField; // 0x18
        public int <NumberOfSymbols>k__BackingField; // 0x1C
        public short <SizeOfOptionalHeader>k__BackingField; // 0x20
        public 0x6B294AE0 <Characteristics>k__BackingField; // 0x22

        // ── Methods ──
        public void get_NumberOfSections(){} // RVA: 0x7FFAC8A33DD0
        public void get_TimeDateStamp(){} // RVA: 0x7FFAC33D5A20
        public void .ctor(){} // RVA: 0x7FFAC8A6C0C0
    }

    public class CorHeader : Object
    {
        public ushort MetadataDirectory; // 0x10
        public ushort <MinorRuntimeVersion>k__BackingField; // 0x12
        public System.Reflection.PortableExecutable.DirectoryEntry <MetadataDirectory>k__BackingField; // 0x14
        public 0x6B294820 <Flags>k__BackingField; // 0x1C
        public int <EntryPointTokenOrRelativeVirtualAddress>k__BackingField; // 0x20
        public System.Reflection.PortableExecutable.DirectoryEntry <ResourcesDirectory>k__BackingField; // 0x24
        public System.Reflection.PortableExecutable.DirectoryEntry <StrongNameSignatureDirectory>k__BackingField; // 0x2C
        public System.Reflection.PortableExecutable.DirectoryEntry <CodeManagerTableDirectory>k__BackingField; // 0x34
        public System.Reflection.PortableExecutable.DirectoryEntry <VtableFixupsDirectory>k__BackingField; // 0x3C
        public System.Reflection.PortableExecutable.DirectoryEntry <ExportAddressTableJumpsDirectory>k__BackingField; // 0x44
        public System.Reflection.PortableExecutable.DirectoryEntry <ManagedNativeHeaderDirectory>k__BackingField; // 0x4C

        // ── Methods ──
        public void get_MetadataDirectory(){} // RVA: 0x7FFAC47794F0
        public void .ctor(){} // RVA: 0x7FFAC8A6C140
    }

    public class DebugDirectoryEntry : ValueType
    {
        public uint Stamp; // 0x10
        public ushort MinorVersion; // 0x14
        public ushort Type; // 0x16
        public 0x6B294980 DataSize; // 0x18
        public int DataRelativeVirtualAddress; // 0x1C
        public int DataPointer; // 0x20
        public int IsPortableCodeView; // 0x24

        // ── Methods ──
        public void get_Stamp(){} // RVA: 0x7FFAC4420210
        public void get_MinorVersion(){} // RVA: 0x7FFAC8A6C300
        public void get_Type(){} // RVA: 0x7FFAC49C7500
        public void get_DataSize(){} // RVA: 0x7FFAC49C7520
        public void get_DataRelativeVirtualAddress(){} // RVA: 0x7FFAC2F6E5C0
        public void get_DataPointer(){} // RVA: 0x7FFAC33D5A20
        public void get_IsPortableCodeView(){} // RVA: 0x7FFAC8A6C310
        public void .ctor(){} // RVA: 0x7FFAC8A6C320
    }

    public class DirectoryEntry : ValueType
    {
        public int RelativeVirtualAddress; // 0x10
        public int Size; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A6C350
    }

    public class PEBinaryReader : ValueType
    {
        public long CurrentOffset; // 0x10
        public long _maxOffset; // 0x18
        public System.IO.BinaryReader _reader; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A6C390
        public void get_CurrentOffset(){} // RVA: 0x7FFAC8A6C490
        public void Seek(){} // RVA: 0x7FFAC8A6C4E0
        public void ReadBytes(){} // RVA: 0x7FFAC8A6C550
        public void ReadByte(){} // RVA: 0x7FFAC8A6C5E0
        public void ReadInt16(){} // RVA: 0x7FFAC8A6C660
        public void ReadUInt16(){} // RVA: 0x7FFAC8A6C6E0
        public void ReadInt32(){} // RVA: 0x7FFAC8A6C760
        public void ReadUInt32(){} // RVA: 0x7FFAC8A6C7E0
        public void ReadUInt64(){} // RVA: 0x7FFAC8A6C860
        public void ReadNullPaddedUTF8(){} // RVA: 0x7FFAC8A6C8E0
        public void CheckBounds(){} // RVA: 0x7FFAC8A6C9E0 | overloaded x2
    }

    public class PEHeader : Object
    {
        public 0x6B294B38 SizeOfImage; // 0x10
        public byte DebugTableDirectory; // 0x12
        public byte CorHeaderTableDirectory; // 0x13
        public int <SizeOfCode>k__BackingField; // 0x14
        public int <SizeOfInitializedData>k__BackingField; // 0x18
        public int <SizeOfUninitializedData>k__BackingField; // 0x1C
        public int <AddressOfEntryPoint>k__BackingField; // 0x20
        public int <BaseOfCode>k__BackingField; // 0x24
        public int <BaseOfData>k__BackingField; // 0x28
        public ulong <ImageBase>k__BackingField; // 0x30
        public int <SectionAlignment>k__BackingField; // 0x38
        public int <FileAlignment>k__BackingField; // 0x3C
        public ushort <MajorOperatingSystemVersion>k__BackingField; // 0x40
        public ushort <MinorOperatingSystemVersion>k__BackingField; // 0x42
        public ushort <MajorImageVersion>k__BackingField; // 0x44
        public ushort <MinorImageVersion>k__BackingField; // 0x46
        public ushort <MajorSubsystemVersion>k__BackingField; // 0x48
        public ushort <MinorSubsystemVersion>k__BackingField; // 0x4A
        public int <SizeOfImage>k__BackingField; // 0x4C
        public int <SizeOfHeaders>k__BackingField; // 0x50
        public uint <CheckSum>k__BackingField; // 0x54
        public 0x6B294B90 <Subsystem>k__BackingField; // 0x58
        public 0x6B294BE8 <DllCharacteristics>k__BackingField; // 0x5A
        public ulong <SizeOfStackReserve>k__BackingField; // 0x60
        public ulong <SizeOfStackCommit>k__BackingField; // 0x68
        public ulong <SizeOfHeapReserve>k__BackingField; // 0x70
        public ulong <SizeOfHeapCommit>k__BackingField; // 0x78
        public int <NumberOfRvaAndSizes>k__BackingField; // 0x80
        public System.Reflection.PortableExecutable.DirectoryEntry <ExportTableDirectory>k__BackingField; // 0x84
        public System.Reflection.PortableExecutable.DirectoryEntry <ImportTableDirectory>k__BackingField; // 0x8C
        public System.Reflection.PortableExecutable.DirectoryEntry <ResourceTableDirectory>k__BackingField; // 0x94
        public System.Reflection.PortableExecutable.DirectoryEntry <ExceptionTableDirectory>k__BackingField; // 0x9C
        public System.Reflection.PortableExecutable.DirectoryEntry <CertificateTableDirectory>k__BackingField; // 0xA4
        public System.Reflection.PortableExecutable.DirectoryEntry <BaseRelocationTableDirectory>k__BackingField; // 0xAC
        public System.Reflection.PortableExecutable.DirectoryEntry <DebugTableDirectory>k__BackingField; // 0xB4
        public System.Reflection.PortableExecutable.DirectoryEntry <CopyrightTableDirectory>k__BackingField; // 0xBC
        public System.Reflection.PortableExecutable.DirectoryEntry <GlobalPointerTableDirectory>k__BackingField; // 0xC4
        public System.Reflection.PortableExecutable.DirectoryEntry <ThreadLocalStorageTableDirectory>k__BackingField; // 0xCC
        public System.Reflection.PortableExecutable.DirectoryEntry <LoadConfigTableDirectory>k__BackingField; // 0xD4
        public System.Reflection.PortableExecutable.DirectoryEntry <BoundImportTableDirectory>k__BackingField; // 0xDC
        public System.Reflection.PortableExecutable.DirectoryEntry <ImportAddressTableDirectory>k__BackingField; // 0xE4
        public System.Reflection.PortableExecutable.DirectoryEntry <DelayImportTableDirectory>k__BackingField; // 0xEC
        public System.Reflection.PortableExecutable.DirectoryEntry <CorHeaderTableDirectory>k__BackingField; // 0xF4

        // ── Methods ──
        public void get_SizeOfImage(){} // RVA: 0x7FFAC3F2D3C0
        public void get_DebugTableDirectory(){} // RVA: 0x7FFAC8787B30
        public void get_CorHeaderTableDirectory(){} // RVA: 0x7FFAC8A6CA00
        public void .ctor(){} // RVA: 0x7FFAC8A6CA10
    }

    public class PEHeaders : Object
    {
        public System.Reflection.PortableExecutable.CoffHeader MetadataStartOffset; // 0x10
        public System.Reflection.PortableExecutable.PEHeader MetadataSize; // 0x18
        public System.Collections.Immutable.ImmutableArray`1<System.Reflection.PortableExecutable.SectionHeader> CoffHeader; // 0x20
        public System.Reflection.PortableExecutable.CorHeader IsCoffOnly; // 0x28
        public bool PEHeader; // 0x30
        public int SectionHeaders; // 0x34
        public int _metadataSize; // 0x38
        public int _coffHeaderStartOffset; // 0x3C
        public int _corHeaderStartOffset; // 0x40
        public int _peHeaderStartOffset; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A6CF50 | overloaded x3
        public void get_MetadataStartOffset(){} // RVA: 0x7FFAC3ADEDC0
        public void get_MetadataSize(){} // RVA: 0x7FFAC358A870
        public void get_CoffHeader(){} // RVA: 0x7FFAC2F3C380
        public void get_IsCoffOnly(){} // RVA: 0x7FFAC58650E0
        public void get_PEHeader(){} // RVA: 0x7FFAC2F247C0
        public void get_SectionHeaders(){} // RVA: 0x7FFAC2F4F0C0
        public void TryCalculateCorHeaderOffset(){} // RVA: 0x7FFAC8A6D660
        public void SkipDosHeader(){} // RVA: 0x7FFAC8A6D730
        public void ReadSectionHeaders(){} // RVA: 0x7FFAC8A6D880
        public void TryGetDirectoryOffset(){} // RVA: 0x7FFAC8A6DC00 | overloaded x2
        public void GetContainingSectionIndex(){} // RVA: 0x7FFAC8A6DF00
        public void IndexOfSection(){} // RVA: 0x7FFAC8A6E050
        public void CalculateMetadataLocation(){} // RVA: 0x7FFAC8A6E1B0
    }

    public class PEReader : Object
    {
        public bool IsLoadedImage; // 0x10
        public System.Reflection.Internal.MemoryBlockProvider PEHeaders; // 0x18
        public System.Reflection.PortableExecutable.PEHeaders _lazyPEHeaders; // 0x20
        public System.Reflection.Internal.AbstractMemoryBlock _lazyMetadataBlock; // 0x28
        public System.Reflection.Internal.AbstractMemoryBlock _lazyImageBlock; // 0x30
        public System.Reflection.Internal.AbstractMemoryBlock[] _lazyPESectionBlocks; // 0x38

        // ── Methods ──
        public void get_IsLoadedImage(){} // RVA: 0x7FFAC2FEB5E0
        public void .ctor(){} // RVA: 0x7FFAC8A6E5F0 | overloaded x3
        public void Dispose(){} // RVA: 0x7FFAC8A6EB50
        public void GetPEImage(){} // RVA: 0x7FFAC8A6EDB0
        public void get_PEHeaders(){} // RVA: 0x7FFAC8A6EDE0
        public void InitializePEHeaders(){} // RVA: 0x7FFAC8A6EE10
        public void ReadPEHeadersNoLock(){} // RVA: 0x7FFAC8A6F0A0
        public void ReadDebugDirectory(){} // RVA: 0x7FFAC8A6F150
        public void ReadDebugDirectoryEntries(){} // RVA: 0x7FFAC8A6F570
        public void GetDebugDirectoryEntryDataBlock(){} // RVA: 0x7FFAC8A6F8E0
        public void ReadCodeViewDebugDirectoryData(){} // RVA: 0x7FFAC8A6F980
        public void DecodeCodeViewDebugDirectoryData(){} // RVA: 0x7FFAC8A6FB80
        public void ReadPdbChecksumDebugDirectoryData(){} // RVA: 0x7FFAC8A70010
        public void DecodePdbChecksumDebugDirectoryData(){} // RVA: 0x7FFAC8A70210
    }

    public class PEStreamOptionsExtensions : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC8A704F0
    }

    public class PdbChecksumDebugDirectoryData : ValueType
    {
        public string AlgorithmName; // 0x10
        public System.Collections.Immutable.ImmutableArray`1<byte> Checksum; // 0x18

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC3AD9F60
        public void get_Checksum(){} // RVA: 0x7FFAC4420220
        public void .ctor(){} // RVA: 0x7FFAC60F4340
    }

    public class SectionHeader : ValueType
    {
        public string Name; // 0x10
        public int VirtualSize; // 0x18
        public int VirtualAddress; // 0x1C
        public int SizeOfRawData; // 0x20
        public int PointerToRawData; // 0x24
        public int <PointerToRelocations>k__BackingField; // 0x28
        public int <PointerToLineNumbers>k__BackingField; // 0x2C
        public ushort <NumberOfRelocations>k__BackingField; // 0x30
        public ushort <NumberOfLineNumbers>k__BackingField; // 0x32
        public 0x6B294C40 <SectionCharacteristics>k__BackingField; // 0x34

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC3AD9F60
        public void get_VirtualSize(){} // RVA: 0x7FFAC49C7500
        public void get_VirtualAddress(){} // RVA: 0x7FFAC49C7520
        public void get_SizeOfRawData(){} // RVA: 0x7FFAC2F6E5C0
        public void get_PointerToRawData(){} // RVA: 0x7FFAC33D5A20
        public void .ctor(){} // RVA: 0x7FFAC8A70500
    }

}