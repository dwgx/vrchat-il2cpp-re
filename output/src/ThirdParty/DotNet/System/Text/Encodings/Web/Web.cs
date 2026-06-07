// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Encodings.Web
// Classes: 10
// Methods: 57

namespace ThirdParty.DotNet.System.Text.Encodings.Web
{
    public class AllowedBmpCodePointsBitmap
    {
        // ── Methods ──
        public void AllowChar(){} // RVA: 0x62ED140
        public void ForbidChar(){} // RVA: 0x62ED160
        public void ForbidHtmlCharacters(){} // RVA: 0x62ED180
        public void ForbidUndefinedCharacters(){} // RVA: 0x6835AE0
        public void IsCharAllowed(){} // RVA: 0x62ED460
        public void IsCodePointAllowed(){} // RVA: 0x62ED480
        public void _GetIndexAndOffset(){} // RVA: 0x62ED4A0
    }

    public class AsciiByteMap
    {
        // ── Methods ──
        public void InsertAsciiChar(){} // RVA: 0x62ED100
        public void TryLookup(){} // RVA: 0x62ED120
    }

    public class DefaultJavaScriptEncoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6837080 | overloaded x2
        public void EncodeCore(){} // RVA: 0x68372B0
        public void EncodeUtf8Core(){} // RVA: 0x6837310
        public void FindFirstCharacterToEncode(){} // RVA: 0x68373A0 | overloaded x2
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x6837430
        public void TryEncodeUnicodeScalar(){} // RVA: 0x6837460
        public void WillEncode(){} // RVA: 0x68375A0
        public void .cctor(){} // RVA: 0x6837600
    }

    public class JavaScriptEncoder
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x68383D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OptimizedInboxTextEncoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6835C50
        public void FindFirstCharacterToEncode(){} // RVA: 0x6835E60
        public void TryEncodeUnicodeScalar(){} // RVA: 0x6835EF0
        public void Encode(){} // RVA: 0x6836040
        public void EncodeUtf8(){} // RVA: 0x6836450
        public void GetIndexOfFirstByteToEncode(){} // RVA: 0x6836930
        public void GetIndexOfFirstCharToEncode(){} // RVA: 0x6836B60
        public void IsScalarValueAllowed(){} // RVA: 0x62EE8B0
        public void _AssertThisNotNull(){} // RVA: 0x6836D80
    }

    public class ScalarEscaperBase
    {
        // ── Methods ──
        public void EncodeUtf16(){}
        public void EncodeUtf8(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SpanUtility
    {
        // ── Methods ──
        public void IsValidIndex(){} // RVA: 0x283FA0 | overloaded x2
        public void TryWriteUInt64LittleEndian(){} // RVA: 0x62F0310
        public void AreValidIndexAndLength(){} // RVA: 0x62F03D0
    }

    public class TextEncoder
    {
        // ── Methods ──
        public void TryEncodeUnicodeScalar(){} // RVA: 0x6838430 | overloaded x2
        public void TryEncodeUnicodeScalarUtf8(){} // RVA: 0x68384C0
        public void FindFirstCharacterToEncode(){} // RVA: 0x6839660 | overloaded x2
        public void WillEncode(){} // RVA: 0xE1F0
        public void EncodeUtf8(){} // RVA: 0x6838830
        public void EncodeUtf8Core(){} // RVA: 0x6838B40
        public void Encode(){} // RVA: 0x6838E90
        public void EncodeCore(){} // RVA: 0x68391A0
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x68396D0
        public void ThrowArgumentException_MaxOutputCharsPerInputChar(){} // RVA: 0x6839910
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TextEncoderSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6839980
        public void AllowRange(){} // RVA: 0x68399B0
        public void AllowRanges(){} // RVA: 0x6839A10
        public void GetAllowedCodePoints(){} // RVA: 0x6839A80
        public void GetAllowedCodePointsBitmap(){} // RVA: 0x6839B30
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x62F1DD0
        public void GetArgumentName(){} // RVA: 0x62F1E30
    }

}