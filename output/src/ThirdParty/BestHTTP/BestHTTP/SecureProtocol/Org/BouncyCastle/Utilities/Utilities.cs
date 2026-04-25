// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities
// Classes: 9
// Methods: 115

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities
{
    public class Arrays : Object
    {
        public byte[] EmptyBytes;
        public int[] EmptyInts; // 0x8

        // ── Methods ──
        public void AreAllZeroes(){} // RVA: 0x7FFACBA6EA60
        public void AreEqual(){} // RVA: 0x7FFACBA6EEE0 | overloaded x5
        public void AreSame(){} // RVA: 0x7FFACBA6ECC0
        public void ConstantTimeAreEqual(){} // RVA: 0x7FFACBA6EDB0
        public void HaveSameContents(){} // RVA: 0x7FFACBA6F070 | overloaded x5
        public void ToString(){} // RVA: 0x7FFACBA6F0E0
        public void GetHashCode(){} // RVA: 0x7FFACBA6F490 | overloaded x8
        public void Clone(){} // RVA: 0x7FFACBA6F870 | overloaded x7
        public void Contains(){} // RVA: 0x7FFACBA6FA00 | overloaded x3
        public void Fill(){} // RVA: 0x7FFACBA6FAA0 | overloaded x2
        public void CopyOf(){} // RVA: 0x7FFACBA6FDA0 | overloaded x5
        public void CopyOfRange(){} // RVA: 0x7FFACBA70150 | overloaded x4
        public void GetLength(){} // RVA: 0x7FFACBA70250
        public void Append(){} // RVA: 0x7FFACBA704A0 | overloaded x3
        public void Concatenate(){} // RVA: 0x7FFACBA70880 | overloaded x2
        public void ConcatenateAll(){} // RVA: 0x7FFACBA70720
        public void Prepend(){} // RVA: 0x7FFACBA70C00 | overloaded x3
        public void Reverse(){} // RVA: 0x7FFACBA70D80 | overloaded x2
        public void IsNullOrContainsNull(){} // RVA: 0x7FFACBA70E30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA70E80
    }

    public class BigIntegers : Object
    {
        public int MaxIterations;

        // ── Methods ──
        public void AsUnsignedByteArray(){} // RVA: 0x7FFACBA70FF0 | overloaded x2
        public void CreateRandomBigInteger(){} // RVA: 0x7FFACBA710F0
        public void CreateRandomInRange(){} // RVA: 0x7FFACBA71160
        public void GetUnsignedByteLength(){} // RVA: 0x7FFACBA71380
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Enums : Object
    {
        // ── Methods ──
        public void GetEnumValue(){} // RVA: 0x7FFACBA713B0
        public void GetEnumValues(){} // RVA: 0x7FFACBA715C0
        public void GetArbitraryValue(){} // RVA: 0x7FFACBA716E0
        public void IsEnumType(){} // RVA: 0x7FFAC8777EE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IMemoable
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAC2C58E90
        public void Reset(){} // RVA: 0x7FFAC2C70A40
    }

    public class Integers : Object
    {
        // ── Methods ──
        public void NumberOfLeadingZeros(){} // RVA: 0x7FFACBA718C0
        public void RotateLeft(){} // RVA: 0x7FFACBA71950 | overloaded x2
        public void RotateRight(){} // RVA: 0x7FFACBA71970 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MemoableResetException : InvalidCastException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8632790
    }

    public class Platform : Object
    {
        public System.Globalization.CompareInfo InvariantCompareInfo;
        public string NewLine; // 0x8

        // ── Methods ──
        public void GetNewLine(){} // RVA: 0x7FFACBA71990
        public void EqualsIgnoreCase(){} // RVA: 0x7FFACBA719A0
        public void GetEnvironmentVariable(){} // RVA: 0x7FFACBA71A50
        public void CreateNotImplementedException(){} // RVA: 0x7FFACBA71A70
        public void CreateArrayList(){} // RVA: 0x7FFACBA71BE0 | overloaded x4
        public void CreateHashtable(){} // RVA: 0x7FFACBA71EC0 | overloaded x3
        public void ToLowerInvariant(){} // RVA: 0x7FFACBA71F30
        public void ToUpperInvariant(){} // RVA: 0x7FFACBA72050
        public void Dispose(){} // RVA: 0x7FFACBA72170 | overloaded x2
        public void IndexOf(){} // RVA: 0x7FFACBA721A0
        public void LastIndexOf(){} // RVA: 0x7FFACBA72240
        public void StartsWith(){} // RVA: 0x7FFACBA722E0
        public void EndsWith(){} // RVA: 0x7FFACBA72380
        public void GetTypeName(){} // RVA: 0x7FFACBA72420
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA72460
    }

    public class Strings : Object
    {
        // ── Methods ──
        public void ToUpperCase(){} // RVA: 0x7FFACBA72610
        public void IsOneOf(){} // RVA: 0x7FFACBA726A0
        public void FromByteArray(){} // RVA: 0x7FFACBA72740
        public void ToByteArray(){} // RVA: 0x7FFACBA72950 | overloaded x2
        public void FromAsciiByteArray(){} // RVA: 0x7FFACBA72A90
        public void ToAsciiByteArray(){} // RVA: 0x7FFACBA72B20 | overloaded x2
        public void FromUtf8ByteArray(){} // RVA: 0x7FFACBA72B60
        public void ToUtf8ByteArray(){} // RVA: 0x7FFACBA72BF0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Times : Object
    {
        public long NanosecondsPerTick;

        // ── Methods ──
        public void NanoTime(){} // RVA: 0x7FFACBA72C30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA72D00
    }

}