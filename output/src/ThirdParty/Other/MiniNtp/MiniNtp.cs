// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MiniNtp
// Classes: 3
// Methods: 8

namespace ThirdParty.Other.MiniNtp
{
    public class ExtensionMethods : Object
    {
        // ── Methods ──
        public void ReverseBytes(){} // RVA: 0x29501D0
    }

    public class NtpTimestamp : ValueType
    {
        public object Seconds;
        public object Fractions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8C87F0
        public void ToBigEndianBytes(){} // RVA: 0x8C8800
        public void ToString(){} // RVA: 0x8C8810
        public void Equals(){} // RVA: 0x8C88F0
        public void GetHashCode(){} // RVA: 0x8C8980
        public void CompareTo(){} // RVA: 0x8C8990
    }

    public class TimeConstants : Object
    {
        public object Epoch1900;
        public object Epoch2036;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6AF42E0
    }

}