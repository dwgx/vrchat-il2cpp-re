// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.ProgramSources
// Classes: 1
// Methods: 19

namespace VRC.Udon.ProgramSources
{
    public class SerializedUdonProgramAsset : AbstractSerializedUdonProgramAsset
    {
        public object _debugCategory;
        public object DEFAULT_SERIALIZATION_DATA_FORMAT;
        public object MAXIMUM_CACHED_PROGRAM_SIZE;
        public object serializedProgramCompressedBytes;
        public object serializedProgramBytesString;
        public object serializedSignature;
        public object programUnityEngineObjects;
        public object networkCallingEntrypointMetadata;
        public object _networkCallingEntrypointMetadataMap;
        public object serializationDataFormat;
        public object _serializationCache;
        public object _mainThreadId;
        public object _retrieveProgramProfilerMarker;
        public object _retrieveProgramCopyHeapProfilerMarker;
        public object _cloneProgramCopyByteCodeProfilerMarker;
        public object _entrypointHashesLoaded;
        public object _entrypointHashToName;
        public object _entrypointNameToHash;

        // ── Methods ──
        public void get_DebugCategoryName(){} // RVA: 0x83550D0
        public void GetNetworkCallingMetadata(){} // RVA: 0x8355150
        public void OnEnable(){} // RVA: 0x8355300
        public void StoreProgram(){} // RVA: 0x8355930
        public void RetrieveProgram(){} // RVA: 0x83559B0
        public void ReadSerializedProgram(){} // RVA: 0x83561F0
        public void GetSerializedProgramSize(){} // RVA: 0x8356440
        public void InitializeLogging(){} // RVA: 0x8356470
        public void OnDisable(){} // RVA: 0x8356560
        public void VRC.Udon.Security.IUdonSignatureHolder.EnsureGZipFormat(){} // RVA: 0x8356670
        public void VRC.Udon.Security.IUdonSignatureHolder.get_Signature(){} // RVA: 0xB70160
        public void VRC.Udon.Security.IUdonSignatureHolder.set_Signature(){} // RVA: 0xB44DC0
        public void VRC.Udon.Security.IUdonSignatureHolder.get_SignedData(){} // RVA: 0xB465B0
        public void get_IsInternallyValidated(){} // RVA: 0xB43320
        public void PopulateEntrypointHashes(){} // RVA: 0x83568F0
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x8356C50
        public void TryGetEntrypointHashFromName(){} // RVA: 0x8356CC0
        public void .ctor(){} // RVA: 0x8356D30
        public void .cctor(){} // RVA: 0x8356F40
    }

}