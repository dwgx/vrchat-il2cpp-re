// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
// Classes: 7
// Methods: 24

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemGenerationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151B7B0
    }

    public class PemHeader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void GetHashCode(){} // RVA: 0x7B151B9C0
        public void Equals(){} // RVA: 0x7B151B890
    }

    public class PemObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151BAB0
        public void get_Type(){} // RVA: 0x7A80F2570
        public void get_Headers(){} // RVA: 0x7A80DA7B0
        public void get_Content(){} // RVA: 0x7A81052C0
        public void Generate(){} // RVA: 0x7A97F8BA0
    }

    public class PemObjectGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7A7E00680
    }

    public class PemObjectParser
    {
        // ── Methods ──
        public void ParseObject(){} // RVA: 0x7A7E00B20
    }

    public class PemReader : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151BC60
        public void get_Reader(){} // RVA: 0x7A80F2570
        public void ReadPemObject(){} // RVA: 0x7B151BD10
        public void LoadObject(){} // RVA: 0x7B151BE40
    }

    public class PemWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151C310
        public void get_Writer(){} // RVA: 0x7A80F2570
        public void GetOutputSize(){} // RVA: 0x7B151C4B0
        public void WriteObject(){} // RVA: 0x7B151C830
        public void WriteEncoded(){} // RVA: 0x7B151CD90
        public void WritePreEncapsulationBoundary(){} // RVA: 0x7B151CE70
        public void WritePostEncapsulationBoundary(){} // RVA: 0x7B151CF00
    }

}