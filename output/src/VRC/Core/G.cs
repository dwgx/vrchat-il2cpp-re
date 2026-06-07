// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 5
// Methods: 45

namespace VRC.Core
{
    public class GC
    {
        // ── Methods ──
        public void Init(){} // RVA: 0xD75BA0
        public void Equals(){} // RVA: 0xD75C60
        public void GetHashCode(){} // RVA: 0xD760A0
        public void op_Implicit(){} // RVA: 0xD76400
        public void CompareBaseObjects(){} // RVA: 0xD768C0
        public void .cctor(){} // RVA: 0xD76B20
    }

    public class GPUTextureCompressor
    {
        public object DestructionQueueCount;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x9A61950
        public void CalculatePadding(){} // RVA: 0x9A61A40
        public void CalculateTotalBlocks(){} // RVA: 0x9A61AB0
        public void CalculateMipBlockOffset(){} // RVA: 0x9A61B70
        public void get_ComputeShaderReady(){} // RVA: 0x9A61C30
        public void get_BC7Supported(){} // RVA: 0x9A61D40
        public void get_PreferredFormat(){} // RVA: 0x9A61EF0
        public void .ctor(){} // RVA: 0x9A61F40
        public void CompressSync(){} // RVA: 0x9A623E0 | overloaded x2
        public void CompressAsync(){} // RVA: 0x9A626C0 | overloaded x2
        public void GetASTCHeader(){} // RVA: 0x9A62780
        public void GetKernelForFormat(){} // RVA: 0x9A628B0
        public void GetExtendEdgesKernelForFormat(){} // RVA: 0x9A628C0
        public void GetTextureFormatForCompression(){} // RVA: 0x9A628D0
        public void CopyTextureProperties(){} // RVA: 0x9A628F0
        public void ValidateFormat(){} // RVA: 0x9A62AF0
        public void EnsureKernelsLoaded(){} // RVA: 0x9A62CE0
        public void ExecuteCompression(){} // RVA: 0x9A62FF0
        public void ExecuteCompressionCPUPath(){} // RVA: 0x9A64490
        public void ExecuteCompressionAsync(){} // RVA: 0x9A652C0
        public void CreateTextureFromReadbackData(){} // RVA: 0x9A664F0
        public void .cctor(){} // RVA: 0x9A667A0
    }

    public class GoogleDeviceCodeResponse
    {
        // ── Methods ──
        public void get_device_code(){} // RVA: 0x358D50
        public void set_device_code(){} // RVA: 0x358D60
        public void get_user_code(){} // RVA: 0x3A5590
        public void set_user_code(){} // RVA: 0x3A55A0
        public void get_verification_url(){} // RVA: 0x4C7C50
        public void set_verification_url(){} // RVA: 0x4C34F0
        public void get_expires_in(){} // RVA: 0xFC4570
        public void set_expires_in(){} // RVA: 0xFC4560
        public void get_interval(){} // RVA: 0x1C5A600
        public void set_interval(){} // RVA: 0x1C5A650
        public void .ctor(){} // RVA: 0x9874150
    }

    public class GoogleLoginResponse
    {
        // ── Methods ──
        public void get_user(){} // RVA: 0x358D50
        public void set_user(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x98741A0
    }

    public class GroupInstanceAccessType
    {
        // ── Methods ──
        public void GetInstanceWithAccessType(){} // RVA: 0x9918890
    }

}