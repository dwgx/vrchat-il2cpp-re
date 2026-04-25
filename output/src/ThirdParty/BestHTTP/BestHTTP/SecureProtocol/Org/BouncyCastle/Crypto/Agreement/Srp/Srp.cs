// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
// Classes: 5
// Methods: 40

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Srp
{
    public class Srp6Client : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger N; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger privA; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger pubA; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger B; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger u; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger S; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger M1; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger M2; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Key; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBC8DA80 | overloaded x2
        public void GenerateClientCredentials(){} // RVA: 0x7FFACBC8DAC0
        public void CalculateSecret(){} // RVA: 0x7FFACBC8DC30
        public void SelectPrivateValue(){} // RVA: 0x7FFACBC8DD80
        public void CalculateS(){} // RVA: 0x7FFACBC8DDB0
        public void CalculateClientEvidenceMessage(){} // RVA: 0x7FFACBC8DFB0
        public void VerifyServerEvidenceMessage(){} // RVA: 0x7FFACBC8E060
        public void CalculateSessionKey(){} // RVA: 0x7FFACBC8E150
    }

    public class Srp6Server : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger N; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger v; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger A; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger privB; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger pubB; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger u; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger S; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger M1; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger M2; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Key; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBC8E3A0 | overloaded x2
        public void GenerateServerCredentials(){} // RVA: 0x7FFACBC8E3F0
        public void CalculateSecret(){} // RVA: 0x7FFACBC8E690
        public void SelectPrivateValue(){} // RVA: 0x7FFACBC8E8C0
        public void CalculateS(){} // RVA: 0x7FFACBC8E8F0
        public void VerifyClientEvidenceMessage(){} // RVA: 0x7FFACBC8E9F0
        public void CalculateServerEvidenceMessage(){} // RVA: 0x7FFACBC8EAE0
        public void CalculateSessionKey(){} // RVA: 0x7FFACBC8EB90
    }

    public class Srp6StandardGroups : Object
    {
        public string rfc5054_1024_N;
        public string rfc5054_1024_g;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters rfc5054_1024;
        public string rfc5054_1536_N;
        public string rfc5054_1536_g;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters rfc5054_1536; // 0x8
        public string rfc5054_2048_N;
        public string rfc5054_2048_g;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters rfc5054_2048; // 0x10
        public string rfc5054_3072_N;
        public string rfc5054_3072_g;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters rfc5054_3072; // 0x18
        public string rfc5054_4096_N;
        public string rfc5054_4096_g;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters rfc5054_4096; // 0x20
        public string rfc5054_6144_N;
        public string rfc5054_6144_g;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters rfc5054_6144; // 0x28
        public string rfc5054_8192_N;
        public string rfc5054_8192_g;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters rfc5054_8192; // 0x30

        // ── Methods ──
        public void FromHex(){} // RVA: 0x7FFACBC8EC30
        public void FromNG(){} // RVA: 0x7FFACBC8ECE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC8ED90
    }

    public class Srp6Utilities : Object
    {
        // ── Methods ──
        public void CalculateK(){} // RVA: 0x7FFACBC8F1F0
        public void CalculateU(){} // RVA: 0x7FFACBC8F210
        public void CalculateX(){} // RVA: 0x7FFACBC8F220
        public void GeneratePrivateValue(){} // RVA: 0x7FFACBC8F410
        public void ValidatePublicValue(){} // RVA: 0x7FFACBC8F520
        public void CalculateM1(){} // RVA: 0x7FFACBC8F690
        public void CalculateM2(){} // RVA: 0x7FFACBC8F690
        public void CalculateKey(){} // RVA: 0x7FFACBC8F6A0
        public void HashPaddedTriplet(){} // RVA: 0x7FFACBC8F7F0
        public void HashPaddedPair(){} // RVA: 0x7FFACBC8F9E0
        public void GetPadded(){} // RVA: 0x7FFACBC8FB80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Srp6VerifierGenerator : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger N; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBC8FC30 | overloaded x2
        public void GenerateVerifier(){} // RVA: 0x7FFACBC8FC70
    }

}