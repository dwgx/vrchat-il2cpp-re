// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
// Classes: 7
// Methods: 28

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemGenerationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEAAE0 | overloaded x3
    }

    public class PemHeader : Object
    {
        public string Name; // 0x10
        public string Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void GetHashCode(){} // RVA: 0x7FFACBCEACF0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFACBCEABC0
    }

    public class PemObject : Object
    {
        public string Type; // 0x10
        public System.Collections.IList Headers; // 0x18
        public byte[] Content; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEADE0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_Headers(){} // RVA: 0x7FFAC2F247C0
        public void get_Content(){} // RVA: 0x7FFAC2F4F0C0
        public void Generate(){} // RVA: 0x7FFAC44F81E0
    }

    public class PemObjectGenerator
    {
        // ── Methods ──
        public void Generate(){} // RVA: 0x7FFAC2C58E90
    }

    public class PemObjectParser
    {
        // ── Methods ──
        public void ParseObject(){} // RVA: 0x7FFAC2C58F40
    }

    public class PemReader : Object
    {
        public string Reader;
        public string EndString;
        public System.IO.TextReader reader; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEAF80
        public void get_Reader(){} // RVA: 0x7FFAC2F3C380
        public void ReadPemObject(){} // RVA: 0x7FFACBCEB030
        public void LoadObject(){} // RVA: 0x7FFACBCEB160
    }

    public class PemWriter : Object
    {
        public int Writer;
        public System.IO.TextWriter writer; // 0x10
        public int nlLength; // 0x18
        public char[] buf; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEB630
        public void get_Writer(){} // RVA: 0x7FFAC2F3C380
        public void GetOutputSize(){} // RVA: 0x7FFACBCEB7D0
        public void WriteObject(){} // RVA: 0x7FFACBCEBB60
        public void WriteEncoded(){} // RVA: 0x7FFACBCEC0C0
        public void WritePreEncapsulationBoundary(){} // RVA: 0x7FFACBCEC1A0
        public void WritePostEncapsulationBoundary(){} // RVA: 0x7FFACBCEC230
    }

}