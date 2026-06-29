// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Force.Crc32
// Classes: 2
// Methods: 13

namespace ThirdParty.Sentry.Sentry.Force.Crc32
{
    public class Crc32Algorithm : HashAlgorithm
    {
        public object _currentCrc;
        public object _isBigEndian;
        public object _proxy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EB57D0
        public void Append(){} // RVA: 0x6EB5920
        public void Compute(){} // RVA: 0x6EB5A50
        public void ComputeAndWriteToEnd(){} // RVA: 0x6EB5C80
        public void IsValidWithCrcAtEnd(){} // RVA: 0x6EB5EE0
        public void Initialize(){} // RVA: 0x6EB5FC0
        public void HashCore(){} // RVA: 0x6EB5FD0
        public void HashFinal(){} // RVA: 0x6EB6070
        public void AppendInternal(){} // RVA: 0x6EB6150
        public void .cctor(){} // RVA: 0x6EB6200
    }

    public class SafeProxy : Object
    {
        public object Poly;
        public object _table;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EB62C0
        public void Init(){} // RVA: 0x6EB6470
        public void Append(){} // RVA: 0x6EB65A0
    }

}