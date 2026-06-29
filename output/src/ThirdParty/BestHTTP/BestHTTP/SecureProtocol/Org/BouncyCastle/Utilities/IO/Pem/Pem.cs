// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
// Classes: 7
// Methods: 24

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemGenerationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA386B20
    }

    public class PemHeader : Object
    {
        public object name;
        public object val;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Value(){} // RVA: 0xB465B0
        public void GetHashCode(){} // RVA: 0xA386D30
        public void Equals(){} // RVA: 0xA386C00
    }

    public class PemObject : Object
    {
        public object type;
        public object headers;
        public object content;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA386E20
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_Headers(){} // RVA: 0xB465B0
        public void get_Content(){} // RVA: 0xB700F0
        public void Generate(){} // RVA: 0x2303260
    }

    public class PemObjectGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x87C0A0
    }

    public class PemObjectParser
    {
        // ── Methods ──
        public void ParseObject(){} // RVA: 0x87C540
    }

    public class PemReader : Object
    {
        public object BeginString;
        public object EndString;
        public object reader;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA386FD0
        public void get_Reader(){} // RVA: 0xB5DBF0
        public void ReadPemObject(){} // RVA: 0xA387080
        public void LoadObject(){} // RVA: 0xA3871B0
    }

    public class PemWriter : Object
    {
        public object LineLength;
        public object writer;
        public object nlLength;
        public object buf;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA387680
        public void get_Writer(){} // RVA: 0xB5DBF0
        public void GetOutputSize(){} // RVA: 0xA387820
        public void WriteObject(){} // RVA: 0xA387BA0
        public void WriteEncoded(){} // RVA: 0xA388100
        public void WritePreEncapsulationBoundary(){} // RVA: 0xA3881E0
        public void WritePostEncapsulationBoundary(){} // RVA: 0xA388270
    }

}