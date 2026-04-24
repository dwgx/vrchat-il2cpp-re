// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MiniNtp
// Classes: 3
// Methods: 10

namespace ThirdParty.Other.MiniNtp
{
    public class ExtensionMethods : Object
    {
        // ── Methods ──
        public void ReverseBytes(){} // RVA: 0x7FFD50008790
    }

    public class NtpTimestamp : ValueType
    {
        public uint Seconds; // 0x10
        public uint Fractions; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C380D0 | overloaded x2
        public void ToBigEndianBytes(){} // RVA: 0x7FFD53C38260
        public void ToString(){} // RVA: 0x7FFD53C38270
        public void Equals(){} // RVA: 0x7FFD53C38360 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53C383F0
        public void CompareTo(){} // RVA: 0x7FFD53C38400
    }

    public class TimeConstants : Object
    {
        public DependencyInjector Epoch1900;
        public DependencyInjector Epoch2036; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD53C38430
    }

}