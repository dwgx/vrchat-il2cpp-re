// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ProgramSources
// Classes: 1
// Methods: 23

namespace VRC.Udon.ProgramSources
{
    public class SerializedUdonProgramAsset : AbstractSerializedUdonProgramAsset
    {
        public System.Lazy`1<string> _debugCategory;
        public 0x6661D434 DEFAULT_SERIALIZATION_DATA_FORMAT;
        public int MAXIMUM_CACHED_PROGRAM_SIZE;
        public byte[] serializedProgramCompressedBytes; // 0x18

        // ── Methods ──
        public void get_DebugCategoryName(){} // RVA: 0x7FFE88253360
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFE882533E0 | overloaded x2
        public void OnEnable(){} // RVA: 0x7FFE88253590
        public void StoreProgram(){} // RVA: 0x7FFE88253C00 | overloaded x2
        public void RetrieveProgram(){} // RVA: 0x7FFE88253C80
        public void ReadSerializedProgram(){} // RVA: 0x7FFE882544C0
        public void GetSerializedProgramSize(){} // RVA: 0x7FFE88254710
        public void InitializeLogging(){} // RVA: 0x7FFE88254740
        public void OnDisable(){} // RVA: 0x7FFE88254830
        public void VRC.Udon.Security.IUdonSignatureHolder.EnsureGZipFormat(){} // RVA: 0x7FFE88254940
        public void VRC.Udon.Security.IUdonSignatureHolder.get_Signature(){} // RVA: 0x7FFE81129130
        public void VRC.Udon.Security.IUdonSignatureHolder.set_Signature(){} // RVA: 0x7FFE810FCE90
        public void VRC.Udon.Security.IUdonSignatureHolder.get_SignedData(){} // RVA: 0x7FFE810FE7C0
        public void get_IsInternallyValidated(){} // RVA: 0x7FFE820BF400
        public void set_IsInternallyValidated(){} // RVA: 0x7FFE820BFEB0
        public void SetInternallyValidated(){} // RVA: 0x7FFE81126420
        public void PopulateEntrypointHashes(){} // RVA: 0x7FFE88254BC0
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFE88254F10
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFE88254F80
        public void .ctor(){} // RVA: 0x7FFE88254FF0
        public void .cctor(){} // RVA: 0x7FFE882552B0
    }

}