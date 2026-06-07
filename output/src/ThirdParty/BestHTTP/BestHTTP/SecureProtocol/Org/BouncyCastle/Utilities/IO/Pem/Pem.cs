// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
// Classes: 7
// Methods: 28

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemGenerationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E1D20 | overloaded x3
    }

    public class PemHeader
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Value(){} // RVA: 0x2E07C0
        public void GetHashCode(){} // RVA: 0x96E1F30 | overloaded x2
        public void Equals(){} // RVA: 0x96E1E00
    }

    public class PemObject : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E2020 | overloaded x2
        public void get_Type(){} // RVA: 0x2F8380
        public void get_Headers(){} // RVA: 0x2E07C0
        public void get_Content(){} // RVA: 0x30B0C0
        public void Generate(){} // RVA: 0x1A3F520
    }

    public class PemObjectGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0xCD60
    }

    public class PemObjectParser
    {
        // ── Methods ──
        public void ParseObject(){} // RVA: 0xCE10
    }

    public class PemReader
    {
        public object Writer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E21C0
        public void get_Reader(){} // RVA: 0x2F8380
        public void ReadPemObject(){} // RVA: 0x96E2270
        public void LoadObject(){} // RVA: 0x96E23A0
    }

    public class PemWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E2870
        public void get_Writer(){} // RVA: 0x2F8380
        public void GetOutputSize(){} // RVA: 0x96E2A10
        public void WriteObject(){} // RVA: 0x96E2DA0
        public void WriteEncoded(){} // RVA: 0x96E3300
        public void WritePreEncapsulationBoundary(){} // RVA: 0x96E33E0
        public void WritePostEncapsulationBoundary(){} // RVA: 0x96E3470
    }

}