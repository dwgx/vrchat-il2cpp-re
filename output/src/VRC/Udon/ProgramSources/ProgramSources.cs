// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ProgramSources
// Classes: 1
// Methods: 23

namespace VRC.Udon.ProgramSources
{
    public class SerializedUdonProgramAsset : AbstractSerializedUdonProgramAsset
    {
        public System.Lazy`1<string> DebugCategoryName;
        public 0x66583B70 VRC.Udon.Security.IUdonSignatureHolder.Signature;
        public int VRC.Udon.Security.IUdonSignatureHolder.SignedData;
        public byte[] IsInternallyValidated; // 0x18
        public string serializedProgramBytesString; // 0x20
        public byte[] serializedSignature; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.Object> programUnityEngineObjects; // 0x30
        public 0x665C1448[] networkCallingEntrypointMetadata; // 0x38
        public System.Collections.Generic.Dictionary`2<string,0x665C1448> _networkCallingEntrypointMetadataMap; // 0x40
        public 0x66583B70 serializationDataFormat; // 0x48
        public System.Nullable`1<System.ValueTuple`3<0x6662FCE0,byte[],System.Collections.Generic.List`1<UnityEngine.Object>>> _serializationCache; // 0x50
        public int _mainThreadId; // 0x70
        public Unity.Profiling.ProfilerMarker _retrieveProgramProfilerMarker; // 0x78
        public Unity.Profiling.ProfilerMarker _retrieveProgramCopyHeapProfilerMarker; // 0x80
        public Unity.Profiling.ProfilerMarker _cloneProgramCopyByteCodeProfilerMarker; // 0x88
        public bool <IsInternallyValidated>k__BackingField; // 0x90
        public int _entrypointHashesLoaded; // 0x94
        public System.Collections.Generic.Dictionary`2<uint,string> _entrypointHashToName; // 0x98
        public System.Collections.Generic.Dictionary`2<string,uint> _entrypointNameToHash; // 0xA0

        // ── Methods ──
        public void get_DebugCategoryName(){} // RVA: 0x7FFD552C08A0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD552C0920 | overloaded x2
        public void OnEnable(){} // RVA: 0x7FFD552C0AD0
        public void StoreProgram(){} // RVA: 0x7FFD552C1140 | overloaded x2
        public void RetrieveProgram(){} // RVA: 0x7FFD552C11C0
        public void ReadSerializedProgram(){} // RVA: 0x7FFD552C1A00
        public void GetSerializedProgramSize(){} // RVA: 0x7FFD552C1C50
        public void InitializeLogging(){} // RVA: 0x7FFD552C1C80
        public void OnDisable(){} // RVA: 0x7FFD552C1D70
        public void VRC.Udon.Security.IUdonSignatureHolder.EnsureGZipFormat(){} // RVA: 0x7FFD552C1E80
        public void VRC.Udon.Security.IUdonSignatureHolder.get_Signature(){} // RVA: 0x7FFD4E36F130
        public void VRC.Udon.Security.IUdonSignatureHolder.set_Signature(){} // RVA: 0x7FFD4E342E90
        public void VRC.Udon.Security.IUdonSignatureHolder.get_SignedData(){} // RVA: 0x7FFD4E3447C0
        public void get_IsInternallyValidated(){} // RVA: 0x7FFD4F22D160
        public void set_IsInternallyValidated(){} // RVA: 0x7FFD4F2289B0
        public void SetInternallyValidated(){} // RVA: 0x7FFD4E36C420
        public void PopulateEntrypointHashes(){} // RVA: 0x7FFD552C2100
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFD552C2450
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFD552C24C0
        public void .ctor(){} // RVA: 0x7FFD552C2530
        public void .cctor(){} // RVA: 0x7FFD552C27F0
    }

}