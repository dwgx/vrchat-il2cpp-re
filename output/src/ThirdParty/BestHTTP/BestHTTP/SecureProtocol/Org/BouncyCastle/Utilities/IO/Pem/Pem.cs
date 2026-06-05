// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
// Classes: 7
// Methods: 28

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemGenerationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC191D20 | overloaded x3
    }

    public class PemHeader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void GetHashCode(){} // RVA: 0x7FFAFC191F30 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAFC191E00
    }

    public class PemObject : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC192020 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF2DA8380
        public void get_Headers(){} // RVA: 0x7FFAF2D907C0
        public void get_Content(){} // RVA: 0x7FFAF2DBB0C0
        public void Generate(){} // RVA: 0x7FFAF44EF520
    }

    public class PemObjectGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFAF2ABCD60
    }

    public class PemObjectParser
    {
        // ── Methods ──
        public void ParseObject(){} // RVA: 0x7FFAF2ABCE10
    }

    public class PemReader
    {
        public object Writer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1921C0
        public void get_Reader(){} // RVA: 0x7FFAF2DA8380
        public void ReadPemObject(){} // RVA: 0x7FFAFC192270
        public void LoadObject(){} // RVA: 0x7FFAFC1923A0
    }

    public class PemWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC192870
        public void get_Writer(){} // RVA: 0x7FFAF2DA8380
        public void GetOutputSize(){} // RVA: 0x7FFAFC192A10
        public void WriteObject(){} // RVA: 0x7FFAFC192DA0
        public void WriteEncoded(){} // RVA: 0x7FFAFC193300
        public void WritePreEncapsulationBoundary(){} // RVA: 0x7FFAFC1933E0
        public void WritePostEncapsulationBoundary(){} // RVA: 0x7FFAFC193470
    }

}