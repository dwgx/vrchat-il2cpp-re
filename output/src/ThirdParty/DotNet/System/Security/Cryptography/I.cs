// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 2
// Methods: 9

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class ICryptoTransform : get_InputBlockSize
    {
        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0xD840
        public void get_OutputBlockSize(){} // RVA: 0xD840
        public void get_CanTransformMultipleBlocks(){} // RVA: 0xDBE0
        public void get_CanReuseTransform(){} // RVA: 0xDBE0
        public void TransformBlock(){}
        public void TransformFinalBlock(){}
    }

    public class ICspAsymmetricAlgorithm
    {
        // ── Methods ──
        public void get_CspKeyContainerInfo(){} // RVA: 0xCD60
        public void ExportCspBlob(){}
        public void ImportCspBlob(){} // RVA: 0x24B10
    }

}