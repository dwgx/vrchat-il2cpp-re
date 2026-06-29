// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 7
// Methods: 40

namespace ThirdParty.DotNet.System
{
    public class HashCode : ValueType
    {
        public object s_seed;
        public object _v1;
        public object _v2;
        public object _v3;
        public object _v4;
        public object _queue1;
        public object _queue2;
        public object _queue3;
        public object _length;

        // ── Methods ──
        public void Combine(){} // RVA: 0xA94080
        public void GenerateGlobalSeed(){} // RVA: 0x69104A0
        public void Rol(){} // RVA: 0x69104D0
        public void Initialize(){} // RVA: 0x69104F0
        public void Round(){} // RVA: 0x69105C0
        public void QueueRound(){} // RVA: 0x6910630
        public void MixState(){} // RVA: 0x69106A0
        public void MixEmptyState(){} // RVA: 0x6910740
        public void MixFinal(){} // RVA: 0x69107A0
        public void Add(){} // RVA: 0x8B9350
        public void ToHashCode(){} // RVA: 0x8B9360
        public void GetHashCode(){} // RVA: 0x8B9370
        public void Equals(){} // RVA: 0x8B9380
        public void .cctor(){} // RVA: 0x6910B10
    }

    public class HashCode : Object
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0xA94080
    }

    public class HexConverter : Object
    {
        // ── Methods ──
        public void ToCharUpper(){} // RVA: 0x6D5EE80
        public void FromChar(){} // RVA: 0x6D5EEA0
        public void IsHexChar(){} // RVA: 0x6D5EFF0
        public void get_CharToHexLookup(){} // RVA: 0x6D5F010
    }

    public class HexConverter : Object
    {
        // ── Methods ──
        public void ToBytesBuffer(){} // RVA: 0x6D588C0
        public void ToCharsBuffer(){} // RVA: 0x6D589B0
    }

    public class HexConverter : Object
    {
        // ── Methods ──
        public void ToBytesBuffer(){} // RVA: 0x6889D60
        public void ToCharsBuffer(){} // RVA: 0x723E940
        public void EncodeToUtf16(){} // RVA: 0x729FE40
        public void ToString(){} // RVA: 0x729FF50
        public void ToCharUpper(){} // RVA: 0x6D5EE80
        public void ToCharLower(){} // RVA: 0x72A0160
        public void TryDecodeFromUtf16(){} // RVA: 0x72A02B0
        public void FromChar(){} // RVA: 0x72A03C0
        public void FromUpperChar(){} // RVA: 0x72A0480
        public void FromLowerChar(){} // RVA: 0x723E9C0
        public void IsHexChar(){} // RVA: 0x72A04F0
        public void IsHexUpperChar(){} // RVA: 0x72A0520
        public void IsHexLowerChar(){} // RVA: 0x723E9E0
        public void get_CharToHexLookup(){} // RVA: 0x72A0540
    }

    public class HexConverter : Object
    {
        // ── Methods ──
        public void ToBytesBuffer(){} // RVA: 0x6889D60
        public void ToCharsBuffer(){} // RVA: 0x723E940
    }

    public class HexConverter : Object
    {
        // ── Methods ──
        public void ToCharsBuffer(){} // RVA: 0x723E940
        public void FromLowerChar(){} // RVA: 0x723E9C0
        public void IsHexLowerChar(){} // RVA: 0x723E9E0
    }

}