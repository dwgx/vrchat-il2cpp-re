// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
// Classes: 7
// Methods: 28

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemGenerationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A144100 | overloaded x3
    }

    public class PemHeader : Object
    {
        public string name; // 0x10
        public string val; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE8A144310 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE8A1441E0
    }

    public class PemObject : Object
    {
        public string type; // 0x10
        public System.Collections.IList headers; // 0x18
        public byte[] content; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A144400 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_Headers(){} // RVA: 0x7FFE810FE7C0
        public void get_Content(){} // RVA: 0x7FFE811290C0
        public void Generate(){} // RVA: 0x7FFE827C4A80
    }

    public class PemObjectGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFE80E2E2E0
    }

    public class PemObjectParser
    {
        // ── Methods ──
        public void ParseObject(){} // RVA: 0x7FFE80E2E390
    }

    public class PemReader : Object
    {
        public string BeginString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1445A0
        public void get_Reader(){} // RVA: 0x7FFE81116380
        public void ReadPemObject(){} // RVA: 0x7FFE8A144650
        public void LoadObject(){} // RVA: 0x7FFE8A144780
    }

    public class PemWriter : Object
    {
        public int LineLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A144C50
        public void get_Writer(){} // RVA: 0x7FFE81116380
        public void GetOutputSize(){} // RVA: 0x7FFE8A144DF0
        public void WriteObject(){} // RVA: 0x7FFE8A145180
        public void WriteEncoded(){} // RVA: 0x7FFE8A1456E0
        public void WritePreEncapsulationBoundary(){} // RVA: 0x7FFE8A1457C0
        public void WritePostEncapsulationBoundary(){} // RVA: 0x7FFE8A145850
    }

}