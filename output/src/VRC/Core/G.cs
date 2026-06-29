// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 5
// Methods: 43

namespace VRC.Core
{
    public class GC : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A8B387E0
        public void Equals(){} // RVA: 0x7A8B388A0
        public void GetHashCode(){} // RVA: 0x7A8B38CC0
        public void op_Implicit(){} // RVA: 0x7A8B39010
        public void CompareBaseObjects(){} // RVA: 0x7A8B394E0
        public void .cctor(){} // RVA: 0x7A8B39750
    }

    public class GPUTextureCompressor : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7B18A1A40
        public void CalculatePadding(){} // RVA: 0x7B18A1B30
        public void CalculateTotalBlocks(){} // RVA: 0x7B18A1BA0
        public void CalculateMipBlockOffset(){} // RVA: 0x7B18A1C60
        public void get_ComputeShaderReady(){} // RVA: 0x7B18A1D20
        public void get_BC7Supported(){} // RVA: 0x7B18A1E30
        public void get_PreferredFormat(){} // RVA: 0x7B18A1FE0
        public void .ctor(){} // RVA: 0x7B18A2030
        public void CompressSync(){} // RVA: 0x7B18A24D0
        public void CompressAsync(){} // RVA: 0x7B18A27B0
        public void GetASTCHeader(){} // RVA: 0x7B18A2870
        public void GetKernelForFormat(){} // RVA: 0x7B18A29A0
        public void GetExtendEdgesKernelForFormat(){} // RVA: 0x7B18A29B0
        public void GetTextureFormatForCompression(){} // RVA: 0x7B18A29C0
        public void CopyTextureProperties(){} // RVA: 0x7B18A29E0
        public void ValidateFormat(){} // RVA: 0x7B18A2BE0
        public void EnsureKernelsLoaded(){} // RVA: 0x7B18A2DD0
        public void ExecuteCompression(){} // RVA: 0x7B18A30E0
        public void ExecuteCompressionCPUPath(){} // RVA: 0x7B18A4440
        public void ExecuteCompressionAsync(){} // RVA: 0x7B18A5280
        public void CreateTextureFromReadbackData(){} // RVA: 0x7B18A6B70
        public void .cctor(){} // RVA: 0x7B18A6E20
    }

    public class GoogleDeviceCodeResponse : ApiModel
    {
        // ── Methods ──
        public void get_device_code(){} // RVA: 0x7A8153390
        public void set_device_code(){} // RVA: 0x7A81533A0
        public void get_user_code(){} // RVA: 0x7A81A00E0
        public void set_user_code(){} // RVA: 0x7A81A00F0
        public void get_verification_url(){} // RVA: 0x7A82C2060
        public void set_verification_url(){} // RVA: 0x7A82C0530
        public void get_expires_in(){} // RVA: 0x7A8D6DF30
        public void set_expires_in(){} // RVA: 0x7A8D6DF20
        public void get_interval(){} // RVA: 0x7A9A18C60
        public void set_interval(){} // RVA: 0x7A9A18CB0
        public void .ctor(){} // RVA: 0x7B16AEF10
    }

    public class GoogleLoginResponse : ApiModel
    {
        // ── Methods ──
        public void get_user(){} // RVA: 0x7A8153390
        public void set_user(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7B16AEF60
    }

    public class GroupInstanceAccessType : Object
    {
        // ── Methods ──
        public void GetInstanceWithAccessType(){} // RVA: 0x7B1754240
    }

}