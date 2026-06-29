// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 5
// Methods: 44

namespace VRC.Core
{
    public class GC : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x162FAC0
        public void Equals(){} // RVA: 0x162FB80
        public void GetHashCode(){} // RVA: 0x162FF60
        public void op_Implicit(){} // RVA: 0x16302B0
        public void CompareBaseObjects(){} // RVA: 0x1630780
        public void .cctor(){} // RVA: 0x16309F0
    }

    public class GPUTextureCompressor : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0xA70ED60
        public void CalculatePadding(){} // RVA: 0xA70EE50
        public void CalculateTotalBlocks(){} // RVA: 0xA70EEC0
        public void CalculateMipBlockOffset(){} // RVA: 0xA70EF80
        public void CalculateFullMipCount(){} // RVA: 0xA70F040
        public void get_ComputeShaderReady(){} // RVA: 0xA70F0B0
        public void get_BC7Supported(){} // RVA: 0xA70F1C0
        public void get_PreferredFormat(){} // RVA: 0xA70F370
        public void .ctor(){} // RVA: 0xA70F3C0
        public void CompressSync(){} // RVA: 0xA70F860
        public void CompressAsync(){} // RVA: 0xA70FAC0
        public void GetASTCHeader(){} // RVA: 0xA70FCB0
        public void GetKernelForFormat(){} // RVA: 0xA70FDE0
        public void GetExtendEdgesKernelForFormat(){} // RVA: 0xA70FDF0
        public void GetTextureFormatForCompression(){} // RVA: 0xA70FE00
        public void CopyTextureProperties(){} // RVA: 0xA70FE20
        public void ValidateFormat(){} // RVA: 0xA70FEB0
        public void EnsureKernelsLoaded(){} // RVA: 0xA7100A0
        public void ExecuteCompression(){} // RVA: 0xA7103B0
        public void ExecuteCompressionCPUPath(){} // RVA: 0xA711550
        public void ExecuteCompressionAsync(){} // RVA: 0xA712DB0
        public void CreateTextureFromReadbackData(){} // RVA: 0xA7146D0
        public void .cctor(){} // RVA: 0xA714980
    }

    public class GoogleDeviceCodeResponse : ApiModel
    {
        // ── Methods ──
        public void get_device_code(){} // RVA: 0xBBFF90
        public void set_device_code(){} // RVA: 0xBBFFA0
        public void get_user_code(){} // RVA: 0xC10050
        public void set_user_code(){} // RVA: 0xC10060
        public void get_verification_url(){} // RVA: 0xCD3320
        public void set_verification_url(){} // RVA: 0xCD4740
        public void get_expires_in(){} // RVA: 0xD34760
        public void set_expires_in(){} // RVA: 0xD34750
        public void get_interval(){} // RVA: 0xD34730
        public void set_interval(){} // RVA: 0xD34790
        public void .ctor(){} // RVA: 0xA51A250
    }

    public class GoogleLoginResponse : ApiModel
    {
        // ── Methods ──
        public void get_user(){} // RVA: 0xBBFF90
        public void set_user(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0xA51A2A0
    }

    public class GroupInstanceAccessType : Object
    {
        // ── Methods ──
        public void GetInstanceWithAccessType(){} // RVA: 0xA5C05C0
    }

}