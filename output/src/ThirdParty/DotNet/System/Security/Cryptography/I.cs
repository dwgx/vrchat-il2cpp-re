// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 2
// Methods: 9

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class ICryptoTransform
    {
        public object InputBlockSize;
        public object OutputBlockSize;
        public object CanTransformMultipleBlocks;
        public object CanReuseTransform;

        // ── Methods ──
        public void get_InputBlockSize(){} // RVA: 0x7FFAC2C59960
        public void get_OutputBlockSize(){} // RVA: 0x7FFAC2C59960
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAC2C59D00
        public void get_CanReuseTransform(){} // RVA: 0x7FFAC2C59D00
        public void TransformBlock(){}
        public void TransformFinalBlock(){}
    }

    public class ICspAsymmetricAlgorithm
    {
        public object CspKeyContainerInfo;

        // ── Methods ──
        public void get_CspKeyContainerInfo(){} // RVA: 0x7FFAC2C58E90
        public void ExportCspBlob(){}
        public void ImportCspBlob(){} // RVA: 0x7FFAC2C70A40
    }

}