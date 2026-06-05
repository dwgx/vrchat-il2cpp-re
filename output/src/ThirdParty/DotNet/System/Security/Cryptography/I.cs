// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 2
// Methods: 9

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class ICryptoTransform : get_InputBlockSize
    {
        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void get_OutputBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAF2ABDBE0
        public void get_CanReuseTransform(){} // RVA: 0x7FFAF2ABDBE0
        public void TransformBlock(){}
        public void TransformFinalBlock(){}
    }

    public class ICspAsymmetricAlgorithm
    {
        // ── Methods ──
        public void get_CspKeyContainerInfo(){} // RVA: 0x7FFAF2ABCD60
        public void ExportCspBlob(){}
        public void ImportCspBlob(){} // RVA: 0x7FFAF2AD4B10
    }

}