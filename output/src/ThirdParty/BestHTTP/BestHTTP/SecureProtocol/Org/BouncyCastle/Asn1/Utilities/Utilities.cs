// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Utilities
// Classes: 2
// Methods: 24

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Utilities
{
    public class Asn1Dump : Object
    {
        public string NewLine;
        public string Tab;
        public int SampleSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void AsString(){} // RVA: 0x7FFACBD5EB40
        public void outputApplicationSpecific(){} // RVA: 0x7FFACBD60DC0
        public void DumpAsString(){} // RVA: 0x7FFACBD617C0 | overloaded x3
        public void dumpBinaryDataAsString(){} // RVA: 0x7FFACBD618C0
        public void calculateAscString(){} // RVA: 0x7FFACBD61B70
        public void .cctor(){} // RVA: 0x7FFACBD61C40
    }

    public class FilterStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBD61D10
        public void get_CanRead(){} // RVA: 0x7FFAC8BAC4C0
        public void get_CanSeek(){} // RVA: 0x7FFAC8BAC4F0
        public void get_CanWrite(){} // RVA: 0x7FFAC9220950
        public void get_Length(){} // RVA: 0x7FFAC8E25730
        public void get_Position(){} // RVA: 0x7FFAC8E25760
        public void set_Position(){} // RVA: 0x7FFAC91AAE10
        public void Close(){} // RVA: 0x7FFACBD61DB0
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
        public void Seek(){} // RVA: 0x7FFAC92208C0
        public void SetLength(){} // RVA: 0x7FFAC8E25610
        public void Read(){} // RVA: 0x7FFAC9220890
        public void ReadByte(){} // RVA: 0x7FFAC859F810
        public void Write(){} // RVA: 0x7FFAC92208F0
        public void WriteByte(){} // RVA: 0x7FFAC9220920
    }

}