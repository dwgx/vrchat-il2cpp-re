// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
// Classes: 3
// Methods: 43

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Encodings
{
    public class ISO9796d1Encoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_AlgorithmName(){} // RVA: 0x9640970
        public void GetUnderlyingCipher(){} // RVA: 0x2F8380
        public void Init(){} // RVA: 0x96409E0
        public void GetInputBlockSize(){} // RVA: 0x9640BE0
        public void GetOutputBlockSize(){} // RVA: 0x9640C40
        public void SetPadBits(){} // RVA: 0x9640CA0
        public void GetPadBits(){} // RVA: 0x760030
        public void ProcessBlock(){} // RVA: 0x9640D10
        public void EncodeBlock(){} // RVA: 0x9640D40
        public void DecodeBlock(){} // RVA: 0x9641040
        public void .cctor(){} // RVA: 0x9641640
    }

    public class OaepEncoding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96419B0 | overloaded x4
        public void GetUnderlyingCipher(){} // RVA: 0x30B0C0
        public void get_AlgorithmName(){} // RVA: 0x9641BA0
        public void Init(){} // RVA: 0x9641C10
        public void GetInputBlockSize(){} // RVA: 0x9641DF0
        public void GetOutputBlockSize(){} // RVA: 0x9641E60
        public void ProcessBlock(){} // RVA: 0x9641ED0
        public void EncodeBlock(){} // RVA: 0x9641F00
        public void DecodeBlock(){} // RVA: 0x9642340
        public void ItoOSP(){} // RVA: 0x95717E0
        public void maskGeneratorFunction1(){} // RVA: 0x9642710
    }

    public class Pkcs1Encoding
    {
        // ── Methods ──
        public void get_StrictLengthEnabled(){} // RVA: 0x9642BC0
        public void set_StrictLengthEnabled(){} // RVA: 0x9642C40
        public void .cctor(){} // RVA: 0x9642CC0
        public void .ctor(){} // RVA: 0x9642FB0 | overloaded x3
        public void GetUnderlyingCipher(){} // RVA: 0x2E07C0
        public void get_AlgorithmName(){} // RVA: 0x96430E0
        public void Init(){} // RVA: 0x9643150
        public void GetInputBlockSize(){} // RVA: 0x96434F0
        public void GetOutputBlockSize(){} // RVA: 0x9643550
        public void ProcessBlock(){} // RVA: 0x96435B0
        public void EncodeBlock(){} // RVA: 0x96435E0
        public void CheckPkcs1Encoding(){} // RVA: 0x9643880
        public void DecodeBlockOrRandom(){} // RVA: 0x9643940
        public void DecodeBlock(){} // RVA: 0x9643C60
        public void FindStart(){} // RVA: 0x9643F90
    }

}