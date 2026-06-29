// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection.PortableExecutable
// Classes: 12
// Methods: 72

namespace ThirdParty.DotNet.System.Reflection.PortableExecutable
{
    public class CodeViewDebugDirectoryData : ValueType
    {
        // ── Methods ──
        public void get_Guid(){} // RVA: 0x7A7662BE0
        public void get_Age(){} // RVA: 0x7A7677B20
        public void get_Path(){} // RVA: 0x7A767FF40
        public void .ctor(){} // RVA: 0x7A7E69C70
    }

    public class CoffHeader : Object
    {
        // ── Methods ──
        public void get_NumberOfSections(){} // RVA: 0x7AE0888F0
        public void get_TimeDateStamp(){} // RVA: 0x7A8668BC0
        public void .ctor(){} // RVA: 0x7AE0C0940
    }

    public class CorHeader : Object
    {
        // ── Methods ──
        public void get_MetadataDirectory(){} // RVA: 0x7A82FDB20
        public void .ctor(){} // RVA: 0x7AE0C09C0
    }

    public class DebugDirectoryEntry : ValueType
    {
        // ── Methods ──
        public void get_Stamp(){} // RVA: 0x7A765F070
        public void get_MinorVersion(){} // RVA: 0x7A7E69CD0
        public void get_Type(){} // RVA: 0x7A75FEFA0
        public void get_DataSize(){} // RVA: 0x7A767FBD0
        public void get_DataRelativeVirtualAddress(){} // RVA: 0x7A7677B20
        public void get_DataPointer(){} // RVA: 0x7A7699630
        public void get_IsPortableCodeView(){} // RVA: 0x7A7E69CE0
        public void .ctor(){} // RVA: 0x7A7E69CF0
    }

    public class DirectoryEntry : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E69D20
    }

    public class PEBinaryReader : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E69D80
        public void get_CurrentOffset(){} // RVA: 0x7A7E69D90
        public void Seek(){} // RVA: 0x7A7E69DE0
        public void ReadBytes(){} // RVA: 0x7A7E69DF0
        public void ReadByte(){} // RVA: 0x7A7E69E00
        public void ReadInt16(){} // RVA: 0x7A7E69E10
        public void ReadUInt16(){} // RVA: 0x7A7E69E20
        public void ReadInt32(){} // RVA: 0x7A7E69E30
        public void ReadUInt32(){} // RVA: 0x7A7E69E40
        public void ReadUInt64(){} // RVA: 0x7A7E69E50
        public void ReadNullPaddedUTF8(){} // RVA: 0x7A7E69E60
        public void CheckBounds(){} // RVA: 0x7A7E69E80
    }

    public class PEHeader : Object
    {
        // ── Methods ──
        public void get_SizeOfImage(){} // RVA: 0x7A9231EA0
        public void get_DebugTableDirectory(){} // RVA: 0x7ADDDCEB0
        public void get_CorHeaderTableDirectory(){} // RVA: 0x7AE0C1290
        public void .ctor(){} // RVA: 0x7AE0C12A0
    }

    public class PEHeaders : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE0C17E0
        public void get_MetadataStartOffset(){} // RVA: 0x7A82C2070
        public void get_MetadataSize(){} // RVA: 0x7A8D863F0
        public void get_CoffHeader(){} // RVA: 0x7A80F2570
        public void get_IsCoffOnly(){} // RVA: 0x7AACC9BD0
        public void get_PEHeader(){} // RVA: 0x7A80DA7B0
        public void get_SectionHeaders(){} // RVA: 0x7A81052C0
        public void TryCalculateCorHeaderOffset(){} // RVA: 0x7AE0C1EF0
        public void SkipDosHeader(){} // RVA: 0x7AE0C1FC0
        public void ReadSectionHeaders(){} // RVA: 0x7AE0C2110
        public void TryGetDirectoryOffset(){} // RVA: 0x7AE0C24A0
        public void GetContainingSectionIndex(){} // RVA: 0x7AE0C2780
        public void IndexOfSection(){} // RVA: 0x7AE0C28E0
        public void CalculateMetadataLocation(){} // RVA: 0x7AE0C2A50
    }

    public class PEReader : Object
    {
        // ── Methods ──
        public void get_IsLoadedImage(){} // RVA: 0x7A81A2200
        public void .ctor(){} // RVA: 0x7AE0C2E90
        public void Dispose(){} // RVA: 0x7AE0C33D0
        public void GetPEImage(){} // RVA: 0x7AE0C3640
        public void get_PEHeaders(){} // RVA: 0x7AE0C3670
        public void InitializePEHeaders(){} // RVA: 0x7AE0C36A0
        public void ReadPEHeadersNoLock(){} // RVA: 0x7AE0C3910
        public void ReadDebugDirectory(){} // RVA: 0x7AE0C39C0
        public void ReadDebugDirectoryEntries(){} // RVA: 0x7AE0C3DF0
        public void GetDebugDirectoryEntryDataBlock(){} // RVA: 0x7AE0C4160
        public void ReadCodeViewDebugDirectoryData(){} // RVA: 0x7AE0C4200
        public void DecodeCodeViewDebugDirectoryData(){} // RVA: 0x7AE0C4410
        public void ReadPdbChecksumDebugDirectoryData(){} // RVA: 0x7AE0C48A0
        public void DecodePdbChecksumDebugDirectoryData(){} // RVA: 0x7AE0C4AA0
    }

    public class PEStreamOptionsExtensions : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7AE0C4D80
    }

    public class PdbChecksumDebugDirectoryData : ValueType
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A765F710
        public void get_Checksum(){} // RVA: 0x7A765F080
        public void .ctor(){} // RVA: 0x7A7C66120
    }

    public class SectionHeader : ValueType
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A765F710
        public void get_VirtualSize(){} // RVA: 0x7A75FEFA0
        public void get_VirtualAddress(){} // RVA: 0x7A767FBD0
        public void get_SizeOfRawData(){} // RVA: 0x7A7677B20
        public void get_PointerToRawData(){} // RVA: 0x7A7699630
        public void .ctor(){} // RVA: 0x7A7E69FF0
    }

}