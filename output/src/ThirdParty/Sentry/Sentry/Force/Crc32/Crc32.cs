// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Force.Crc32
// Classes: 2
// Methods: 18

namespace ThirdParty.Sentry.Sentry.Force.Crc32
{
    public class Crc32Algorithm : HashAlgorithm
    {
        public uint _currentCrc; // 0x28
        public bool _isBigEndian; // 0x2C
        public Sentry.Force.Crc32.SafeProxy _proxy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BDC0F0 | overloaded x2
        public void Append(){} // RVA: 0x7FFAC8BDC240 | overloaded x2
        public void Compute(){} // RVA: 0x7FFAC8BDC370 | overloaded x2
        public void ComputeAndWriteToEnd(){} // RVA: 0x7FFAC8BDC5A0 | overloaded x2
        public void IsValidWithCrcAtEnd(){} // RVA: 0x7FFAC8BDC800 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC8BDC8E0
        public void HashCore(){} // RVA: 0x7FFAC8BDC8F0
        public void HashFinal(){} // RVA: 0x7FFAC8BDC990
        public void AppendInternal(){} // RVA: 0x7FFAC8BDCA70
        public void .cctor(){} // RVA: 0x7FFAC8BDCB20
    }

    public class SafeProxy : Object
    {
        public uint Poly;
        public uint[] _table; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BDCBE0
        public void Init(){} // RVA: 0x7FFAC8BDCD80
        public void Append(){} // RVA: 0x7FFAC8BDCEA0
    }

}