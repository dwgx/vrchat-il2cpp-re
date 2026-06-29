// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 2
// Methods: 9

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class ICryptoTransform
    {
        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0x87C130
        public void get_OutputBlockSize(){} // RVA: 0x87C130
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x87D280
        public void get_CanReuseTransform(){} // RVA: 0x87D280
        public void TransformBlock(){} // RVA: 0x885B90
        public void TransformFinalBlock(){} // RVA: 0x87D1E0
    }

    public class ICspAsymmetricAlgorithm
    {
        // ── Methods ──
        public void get_CspKeyContainerInfo(){} // RVA: 0x87C0A0
        public void ExportCspBlob(){} // RVA: 0x881D20
        public void ImportCspBlob(){} // RVA: 0x894320
    }

}