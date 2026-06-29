// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities
// Classes: 9
// Methods: 66

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities
{
    public class Arrays : Object
    {
        public object EmptyBytes;
        public object EmptyInts;

        // ── Methods ──
        public void AreAllZeroes(){} // RVA: 0xA105280
        public void AreEqual(){} // RVA: 0xA105700
        public void AreSame(){} // RVA: 0xA1054E0
        public void ConstantTimeAreEqual(){} // RVA: 0xA1055C0
        public void HaveSameContents(){} // RVA: 0xA1058B0
        public void ToString(){} // RVA: 0xA105930
        public void GetHashCode(){} // RVA: 0xA105D30
        public void Clone(){} // RVA: 0xA106120
        public void Contains(){} // RVA: 0xA1062B0
        public void Fill(){} // RVA: 0xA106350
        public void CopyOf(){} // RVA: 0xA106650
        public void CopyOfRange(){} // RVA: 0xA106A00
        public void GetLength(){} // RVA: 0xA106B00
        public void Append(){} // RVA: 0xA106D50
        public void Concatenate(){} // RVA: 0xA107140
        public void ConcatenateAll(){} // RVA: 0xA106FD0
        public void Prepend(){} // RVA: 0xA1074C0
        public void Reverse(){} // RVA: 0xA107650
        public void IsNullOrContainsNull(){} // RVA: 0xA107710
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA107760
    }

    public class BigIntegers : Object
    {
        public object MaxIterations;

        // ── Methods ──
        public void AsUnsignedByteArray(){} // RVA: 0xA1078D0
        public void CreateRandomBigInteger(){} // RVA: 0xA1079D0
        public void CreateRandomInRange(){} // RVA: 0xA107A40
        public void GetUnsignedByteLength(){} // RVA: 0xA107C60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Enums : Object
    {
        // ── Methods ──
        public void GetEnumValue(){} // RVA: 0xA107C90
        public void GetEnumValues(){} // RVA: 0xA107E70
        public void GetArbitraryValue(){} // RVA: 0xA107F50
        public void IsEnumType(){} // RVA: 0x6A54A30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IMemoable
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x87C0A0
        public void Reset(){} // RVA: 0x894320
    }

    public class Integers : Object
    {
        // ── Methods ──
        public void NumberOfLeadingZeros(){} // RVA: 0xA1080E0
        public void RotateLeft(){} // RVA: 0xA108170
        public void RotateRight(){} // RVA: 0xA108190
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MemoableResetException : InvalidCastException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6914650
    }

    public class Platform : Object
    {
        public object InvariantCompareInfo;
        public object NewLine;

        // ── Methods ──
        public void GetNewLine(){} // RVA: 0xA1081B0
        public void EqualsIgnoreCase(){} // RVA: 0xA1081C0
        public void GetEnvironmentVariable(){} // RVA: 0xA108270
        public void CreateNotImplementedException(){} // RVA: 0xA108290
        public void CreateArrayList(){} // RVA: 0xA108400
        public void CreateHashtable(){} // RVA: 0xA1086D0
        public void ToLowerInvariant(){} // RVA: 0xA108740
        public void ToUpperInvariant(){} // RVA: 0xA108860
        public void Dispose(){} // RVA: 0xA108980
        public void IndexOf(){} // RVA: 0xA1089B0
        public void LastIndexOf(){} // RVA: 0xA108A50
        public void StartsWith(){} // RVA: 0xA108AF0
        public void EndsWith(){} // RVA: 0xA108B90
        public void GetTypeName(){} // RVA: 0xA108C30
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA108C70
    }

    public class Strings : Object
    {
        // ── Methods ──
        public void ToUpperCase(){} // RVA: 0xA108E20
        public void IsOneOf(){} // RVA: 0xA108F40
        public void FromByteArray(){} // RVA: 0xA108FF0
        public void ToByteArray(){} // RVA: 0xA1092A0
        public void FromAsciiByteArray(){} // RVA: 0xA1093F0
        public void ToAsciiByteArray(){} // RVA: 0xA109480
        public void FromUtf8ByteArray(){} // RVA: 0xA1094C0
        public void ToUtf8ByteArray(){} // RVA: 0xA109550
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Times : Object
    {
        public object NanosecondsPerTick;

        // ── Methods ──
        public void NanoTime(){} // RVA: 0xA109590
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA109660
    }

}