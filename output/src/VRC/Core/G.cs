// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 5
// Methods: 45

namespace VRC.Core
{
    public class GC
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF3825BA0
        public void Equals(){} // RVA: 0x7FFAF3825C60
        public void GetHashCode(){} // RVA: 0x7FFAF38260A0
        public void op_Implicit(){} // RVA: 0x7FFAF3826400
        public void CompareBaseObjects(){} // RVA: 0x7FFAF38268C0
        public void .cctor(){} // RVA: 0x7FFAF3826B20
    }

    public class GPUTextureCompressor
    {
        public object DestructionQueueCount;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAFC511950
        public void CalculatePadding(){} // RVA: 0x7FFAFC511A40
        public void CalculateTotalBlocks(){} // RVA: 0x7FFAFC511AB0
        public void CalculateMipBlockOffset(){} // RVA: 0x7FFAFC511B70
        public void get_ComputeShaderReady(){} // RVA: 0x7FFAFC511C30
        public void get_BC7Supported(){} // RVA: 0x7FFAFC511D40
        public void get_PreferredFormat(){} // RVA: 0x7FFAFC511EF0
        public void .ctor(){} // RVA: 0x7FFAFC511F40
        public void CompressSync(){} // RVA: 0x7FFAFC5123E0 | overloaded x2
        public void CompressAsync(){} // RVA: 0x7FFAFC5126C0 | overloaded x2
        public void GetASTCHeader(){} // RVA: 0x7FFAFC512780
        public void GetKernelForFormat(){} // RVA: 0x7FFAFC5128B0
        public void GetExtendEdgesKernelForFormat(){} // RVA: 0x7FFAFC5128C0
        public void GetTextureFormatForCompression(){} // RVA: 0x7FFAFC5128D0
        public void CopyTextureProperties(){} // RVA: 0x7FFAFC5128F0
        public void ValidateFormat(){} // RVA: 0x7FFAFC512AF0
        public void EnsureKernelsLoaded(){} // RVA: 0x7FFAFC512CE0
        public void ExecuteCompression(){} // RVA: 0x7FFAFC512FF0
        public void ExecuteCompressionCPUPath(){} // RVA: 0x7FFAFC514490
        public void ExecuteCompressionAsync(){} // RVA: 0x7FFAFC5152C0
        public void CreateTextureFromReadbackData(){} // RVA: 0x7FFAFC5164F0
        public void .cctor(){} // RVA: 0x7FFAFC5167A0
    }

    public class GoogleDeviceCodeResponse
    {
        // ── Methods ──
        public void get_device_code(){} // RVA: 0x7FFAF2E08D50
        public void set_device_code(){} // RVA: 0x7FFAF2E08D60
        public void get_user_code(){} // RVA: 0x7FFAF2E55590
        public void set_user_code(){} // RVA: 0x7FFAF2E555A0
        public void get_verification_url(){} // RVA: 0x7FFAF2F77C50
        public void set_verification_url(){} // RVA: 0x7FFAF2F734F0
        public void get_expires_in(){} // RVA: 0x7FFAF3A74570
        public void set_expires_in(){} // RVA: 0x7FFAF3A74560
        public void get_interval(){} // RVA: 0x7FFAF470A600
        public void set_interval(){} // RVA: 0x7FFAF470A650
        public void .ctor(){} // RVA: 0x7FFAFC324150
    }

    public class GoogleLoginResponse
    {
        // ── Methods ──
        public void get_user(){} // RVA: 0x7FFAF2E08D50
        public void set_user(){} // RVA: 0x7FFAF2E08D60
        public void .ctor(){} // RVA: 0x7FFAFC3241A0
    }

    public class GroupInstanceAccessType
    {
        // ── Methods ──
        public void GetInstanceWithAccessType(){} // RVA: 0x7FFAFC3C8890
    }

}