// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 4
// Methods: 0

namespace ThirdParty.Valve.Valve.VR
{
    public class PathRead_t : ValueType
    {
        public ulong ulPath; // 0x10
        public UIntPtr pvBuffer; // 0x18
        public uint unBufferSize; // 0x20
        public uint unTag; // 0x24
        public uint unRequiredBufferSize; // 0x28
        public tion eError; // 0x2C
        public UIntPtr pszPath; // 0x30
    }

    public class PathWrite_t : ValueType
    {
        public ulong ulPath; // 0x10
        public ÍÏÌÍÎÌÏÎÍÍÏÍÍ>k__BackingField writeType; // 0x18
        public tion eSetError; // 0x1C
        public UIntPtr pvBuffer; // 0x20
        public uint unBufferSize; // 0x28
        public uint unTag; // 0x2C
        public tion eError; // 0x30
        public UIntPtr pszPath; // 0x38
    }

    public class PropertyRead_t : ValueType
    {
        public lNextEvent prop; // 0x10
        public UIntPtr pvBuffer; // 0x18
        public uint unBufferSize; // 0x20
        public uint unTag; // 0x24
        public uint unRequiredBufferSize; // 0x28
        public tion eError; // 0x2C
    }

    public class PropertyWrite_t : ValueType
    {
        public lNextEvent prop; // 0x10
        public ÍÏÌÍÎÌÏÎÍÍÏÍÍ>k__BackingField writeType; // 0x14
        public tion eSetError; // 0x18
        public UIntPtr pvBuffer; // 0x20
        public uint unBufferSize; // 0x28
        public uint unTag; // 0x2C
        public tion eError; // 0x30
    }

}