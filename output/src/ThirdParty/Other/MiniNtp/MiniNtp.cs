// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MiniNtp
// Classes: 3
// Methods: 10

namespace ThirdParty.Other.MiniNtp
{
    public class ExtensionMethods : Object
    {
        // ── Methods ──
        public void ReverseBytes(){} // RVA: 0x7FFAC4BE8790
    }

    public class NtpTimestamp : ValueType
    {
        public uint Seconds; // 0x10
        public uint Fractions; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88180D0 | overloaded x2
        public void ToBigEndianBytes(){} // RVA: 0x7FFAC8818260
        public void ToString(){} // RVA: 0x7FFAC8818270
        public void Equals(){} // RVA: 0x7FFAC8818360 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC88183F0
        public void CompareTo(){} // RVA: 0x7FFAC8818400
    }

    public class TimeConstants : Object
    {
        public System.DateTime Epoch1900;
        public System.DateTime Epoch2036; // 0x8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8818430
    }

}