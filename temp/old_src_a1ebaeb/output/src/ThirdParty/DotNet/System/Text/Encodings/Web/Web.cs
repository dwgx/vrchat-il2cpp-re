// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Encodings.Web
// Classes: 10
// Methods: 59

namespace ThirdParty.DotNet.System.Text.Encodings.Web
{
    public class AllowedBmpCodePointsBitmap : ValueType
    {
        // ── Original Methods ──
        public void AllowChar(){} // RVA: 0x7ffaae4a5700
        public void ForbidChar(){} // RVA: 0x7ffaae4a5720
        public void ForbidHtmlCharacters(){} // RVA: 0x7ffaae4a5740
        public void ForbidUndefinedCharacters(){} // RVA: 0x7ffaae9ee5d0
        public void IsCharAllowed(){} // RVA: 0x7ffaae4a5a20
        public void IsCodePointAllowed(){} // RVA: 0x7ffaae4a5a40
        public void _GetIndexAndOffset(){} // RVA: 0x7ffaae4a5a60
    }

    public class AsciiByteMap : ValueType
    {
        // ── Original Methods ──
        public void InsertAsciiChar(){} // RVA: 0x7ffaae4a56c0
        public void TryLookup(){} // RVA: 0x7ffaae4a56e0
    }

    public class DefaultJavaScriptEncoder : JavaScriptEncoder
    {
        public object _innerEncoder; // 0x35DF30C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae9efb70
        public void .ctor(){} // RVA: 0x7ffaae9efb70
        public void EncodeCore(){} // RVA: 0x7ffaae9efda0
        public void EncodeUtf8Core(){} // RVA: 0x7ffaae9efe00
        public void FindFirstCharacterToEncode(){} // RVA: 0x7ffaae9efe90
        public void FindFirstCharacterToEncode(){} // RVA: 0x7ffaae9efe90
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x7ffaae9eff20
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7ffaae9eff50
        public void WillEncode(){} // RVA: 0x7ffaae9f0090
        public void .cctor(){} // RVA: 0x7ffaae9f00f0
    }

    public class JavaScriptEncoder : TextEncoder
    {
        // ── Original Methods ──
        public void get_Default(){} // RVA: 0x7ffaae9f0ec0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class OptimizedInboxTextEncoder : Object
    {
        public object _allowedBmpCodePoints; // 0x35E589B0
        public object FixedElementField; // 0x35E58CB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae9ee740
        public void FindFirstCharacterToEncode(){} // RVA: 0x7ffaae9ee950
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7ffaae9ee9e0
        public void Encode(){} // RVA: 0x7ffaae9eeb30
        public void EncodeUtf8(){} // RVA: 0x7ffaae9eef40
        public void IsScalarValueAllowed(){} // RVA: 0x7ffaae4a6e70
        public void _AssertThisNotNull(){} // RVA: 0x7ffaae9ef870
        // ── Binary Analysis Named ──
        public void GetIndexOfFirstByteToEncode(){} // RVA: 0x7ffaae9ef420
        public void GetIndexOfFirstCharToEncode(){} // RVA: 0x7ffaae9ef650
    }

    public class ScalarEscaperBase : Object
    {
        // ── Original Methods ──
        public void EncodeUtf16(){}
        public void EncodeUtf8(){}
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SpanUtility : Object
    {
        // ── Original Methods ──
        public void IsValidIndex(){} // RVA: 0x7ffaa887e5c0
        public void IsValidIndex(){} // RVA: 0x7ffaa887e5c0
        public void TryWriteUInt64LittleEndian(){} // RVA: 0x7ffaae4a88d0
        public void AreValidIndexAndLength(){} // RVA: 0x7ffaae4a8990
    }

    public class SpanUtility : Object
    {
        // ── Original Methods ──
        public void IsValidIndex(){} // RVA: 0x7ffaa887e5c0
        public void IsValidIndex(){} // RVA: 0x7ffaa887e5c0
        public void TryWriteUInt64LittleEndian(){} // RVA: 0x7ffaae9f0e30
        public void AreValidIndexAndLength(){} // RVA: 0x7ffaae4a8990
    }

    public class TextEncoder : Object
    {
        // ── Original Methods ──
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7ffaae9f0f20
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7ffaae9f0f20
        public void TryEncodeUnicodeScalarUtf8(){} // RVA: 0x7ffaae9f0fb0
        public void FindFirstCharacterToEncode(){} // RVA: 0x7ffaae9f2150
        public void WillEncode(){} // RVA: 0x7ffaa864a650
        public void EncodeUtf8(){} // RVA: 0x7ffaae9f1320
        public void EncodeUtf8Core(){} // RVA: 0x7ffaae9f1630
        public void Encode(){} // RVA: 0x7ffaae9f1980
        public void EncodeCore(){} // RVA: 0x7ffaae9f1c90
        public void FindFirstCharacterToEncode(){} // RVA: 0x7ffaae9f2150
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x7ffaae9f21c0
        public void ThrowArgumentException_MaxOutputCharsPerInputChar(){} // RVA: 0x7ffaae9f2400
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class TextEncoderSettings : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae9f2470
        public void AllowRange(){} // RVA: 0x7ffaae9f24a0
        public void AllowRanges(){} // RVA: 0x7ffaae9f2500
        // ── Binary Analysis Named ──
        public void GetAllowedCodePoints(){} // RVA: 0x7ffaae9f2570
        public void GetAllowedCodePointsBitmap(){} // RVA: 0x7ffaae9f2620
    }

}