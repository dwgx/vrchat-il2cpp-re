// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 1
// Methods: 14

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class FromBase64Transform : Object
    {
        public byte[] _inputBuffer; // 0x10
        public int _inputIndex; // 0x18
        public 0x664C4F44 _whitespaces; // 0x1C
        public object field_3; // 0x2EA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867B7F60 | overloaded x2
        public void get_InputBlockSize(){} // RVA: 0x7FFE811EDAF0
        public void get_OutputBlockSize(){} // RVA: 0x7FFE817BF630
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFE810FB320
        public void get_CanReuseTransform(){} // RVA: 0x7FFE811E0850
        public void TransformBlock(){} // RVA: 0x7FFE867B8010
        public void TransformFinalBlock(){} // RVA: 0x7FFE867B8590
        public void DiscardWhiteSpaces(){} // RVA: 0x7FFE867B8AB0
        public void Dispose(){} // RVA: 0x7FFE867B8CC0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE817E01F0
        public void Clear(){} // RVA: 0x7FFE867B8C50
        public void Finalize(){} // RVA: 0x7FFE867B7E80
    }

}