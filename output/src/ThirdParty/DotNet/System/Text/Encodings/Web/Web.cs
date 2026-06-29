// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Encodings.Web
// Classes: 20
// Methods: 105

namespace ThirdParty.DotNet.System.Text.Encodings.Web
{
    public class AllowedBmpCodePointsBitmap : ValueType
    {
        public object Bitmap;

        // ── Methods ──
        public void AllowChar(){} // RVA: 0x8ECD10
        public void ForbidChar(){} // RVA: 0x8ECD30
        public void ForbidHtmlCharacters(){} // RVA: 0x8ECD50
        public void ForbidUndefinedCharacters(){} // RVA: 0x90C670
        public void IsCharAllowed(){} // RVA: 0x8ECD90
        public void IsCodePointAllowed(){} // RVA: 0x8ECDB0
        public void _GetIndexAndOffset(){} // RVA: 0x6D5A190
    }

    public class AllowedBmpCodePointsBitmap : ValueType
    {
        public object Bitmap;

        // ── Methods ──
        public void AllowChar(){} // RVA: 0x8ECD10
        public void ForbidChar(){} // RVA: 0x8ECD30
        public void ForbidHtmlCharacters(){} // RVA: 0x8ECD50
        public void ForbidUndefinedCharacters(){} // RVA: 0x8ECD80
        public void IsCharAllowed(){} // RVA: 0x8ECD90
        public void IsCodePointAllowed(){} // RVA: 0x8ECDB0
        public void _GetIndexAndOffset(){} // RVA: 0x6D5A190
    }

    public class AsciiByteMap : ValueType
    {
        public object Buffer;

        // ── Methods ──
        public void InsertAsciiChar(){} // RVA: 0x8ECCD0
        public void TryLookup(){} // RVA: 0x8ECCF0
    }

    public class AsciiByteMap : ValueType
    {
        public object Buffer;

        // ── Methods ──
        public void InsertAsciiChar(){} // RVA: 0x8ECCD0
        public void TryLookup(){} // RVA: 0x8ECCF0
    }

    public class DefaultJavaScriptEncoder : JavaScriptEncoder
    {
        public object BasicLatinSingleton;
        public object UnsafeRelaxedEscapingSingleton;
        public object _innerEncoder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x729CCA0
        public void EncodeCore(){} // RVA: 0x729CED0
        public void EncodeUtf8Core(){} // RVA: 0x729CF30
        public void FindFirstCharacterToEncode(){} // RVA: 0x729CFC0
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x729D050
        public void TryEncodeUnicodeScalar(){} // RVA: 0x729D080
        public void WillEncode(){} // RVA: 0x729D1C0
        public void .cctor(){} // RVA: 0x729D220
    }

    public class DefaultJavaScriptEncoder : JavaScriptEncoder
    {
        public object BasicLatinSingleton;
        public object UnsafeRelaxedEscapingSingleton;
        public object _innerEncoder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D5B990
        public void EncodeCore(){} // RVA: 0x6D5BD40
        public void EncodeUtf8Core(){} // RVA: 0x6D5BDC0
        public void FindFirstCharacterToEncode(){} // RVA: 0x6D5BE80
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x6D5BF30
        public void TryEncodeUnicodeScalar(){} // RVA: 0x6D5C080
        public void WillEncode(){} // RVA: 0x6D5C230
        public void .cctor(){} // RVA: 0x6D5C290
    }

    public class JavaScriptEncoder : TextEncoder
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x729DFF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JavaScriptEncoder : TextEncoder
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x6D5D030
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OptimizedInboxTextEncoder : Object
    {
        public object _allowedAsciiCodePoints;
        public object _asciiPreescapedData;
        public object _allowedBmpCodePoints;
        public object _scalarEscaper;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x729B8B0
        public void FindFirstCharacterToEncode(){} // RVA: 0x729BAB0
        public void TryEncodeUnicodeScalar(){} // RVA: 0x729BB40
        public void Encode(){} // RVA: 0x729BC90
        public void EncodeUtf8(){} // RVA: 0x729C0A0
        public void GetIndexOfFirstByteToEncode(){} // RVA: 0x729C580
        public void GetIndexOfFirstCharToEncode(){} // RVA: 0x729C7C0
        public void IsScalarValueAllowed(){} // RVA: 0x6D5B540
        public void _AssertThisNotNull(){} // RVA: 0x729C9D0
    }

    public class OptimizedInboxTextEncoder : Object
    {
        public object _allowedAsciiCodePoints;
        public object _asciiPreescapedData;
        public object _allowedBmpCodePoints;
        public object _scalarEscaper;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D5A1A0
        public void FindFirstCharacterToEncode(){} // RVA: 0x6D5A3E0
        public void TryEncodeUnicodeScalar(){} // RVA: 0x6D5A480
        public void Encode(){} // RVA: 0x6D5A630
        public void EncodeUtf8(){} // RVA: 0x6D5ABF0
        public void GetIndexOfFirstByteToEncode(){} // RVA: 0x6D5B210
        public void GetIndexOfFirstCharToEncode(){} // RVA: 0x6D5B330
        public void IsScalarValueAllowed(){} // RVA: 0x6D5B540
        public void _AssertThisNotNull(){} // RVA: 0x6D5B570
    }

    public class ScalarEscaperBase : Object
    {
        // ── Methods ──
        public void EncodeUtf16(){} // RVA: 0x883740
        public void EncodeUtf8(){} // RVA: 0x883740
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ScalarEscaperBase : Object
    {
        // ── Methods ──
        public void EncodeUtf16(){} // RVA: 0x883740
        public void EncodeUtf8(){} // RVA: 0x883740
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SpanUtility : Object
    {
        // ── Methods ──
        public void IsValidIndex(){} // RVA: 0x29C1E00
        public void TryWriteUInt64LittleEndian(){} // RVA: 0x729DF60
        public void AreValidIndexAndLength(){} // RVA: 0x6D5D010
    }

    public class SpanUtility : Object
    {
        // ── Methods ──
        public void IsValidIndex(){} // RVA: 0xA94080
        public void TryWriteUInt64LittleEndian(){} // RVA: 0x6D5CF50
        public void AreValidIndexAndLength(){} // RVA: 0x6D5D010
    }

    public class TextEncoder : Object
    {
        // ── Methods ──
        public void TryEncodeUnicodeScalar(){} // RVA: 0x729E050
        public void TryEncodeUnicodeScalarUtf8(){} // RVA: 0x729E0E0
        public void FindFirstCharacterToEncode(){} // RVA: 0x729F270
        public void WillEncode(){} // RVA: 0x87DD20
        public void EncodeUtf8(){} // RVA: 0x729E450
        public void EncodeUtf8Core(){} // RVA: 0x729E760
        public void Encode(){} // RVA: 0x729EAB0
        public void EncodeCore(){} // RVA: 0x729EDD0
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x729F2E0
        public void ThrowArgumentException_MaxOutputCharsPerInputChar(){} // RVA: 0x729F520
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TextEncoder : Object
    {
        // ── Methods ──
        public void TryEncodeUnicodeScalar(){} // RVA: 0x6D5D090
        public void TryEncodeUnicodeScalarUtf8(){} // RVA: 0x6D5D160
        public void FindFirstCharacterToEncode(){} // RVA: 0x6D5E070
        public void WillEncode(){} // RVA: 0x87DD20
        public void EncodeUtf8(){} // RVA: 0x6D5D550
        public void EncodeUtf8Core(){} // RVA: 0x6D5D860
        public void Encode(){} // RVA: 0x6D5DB30
        public void EncodeCore(){} // RVA: 0x6D5DE40
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x6D5E120
        public void ThrowArgumentException_MaxOutputCharsPerInputChar(){} // RVA: 0x6D5E240
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TextEncoderSettings : Object
    {
        public object _allowedCodePointsBitmap;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x729F590
        public void AllowRange(){} // RVA: 0x729F5C0
        public void AllowRanges(){} // RVA: 0x729F620
        public void GetAllowedCodePoints(){} // RVA: 0x729F6A0
        public void GetAllowedCodePointsBitmap(){} // RVA: 0x729F750
    }

    public class TextEncoderSettings : Object
    {
        public object _allowedCodePointsBitmap;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D5E2B0
        public void AllowRange(){} // RVA: 0x6D5E330
        public void AllowRanges(){} // RVA: 0x6D5E3D0
        public void GetAllowedCodePoints(){} // RVA: 0x6D5E490
        public void GetAllowedCodePointsBitmap(){} // RVA: 0x6D5E540
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x6D5E9D0
        public void GetArgumentName(){} // RVA: 0x6D5EA30
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentNullException(){} // RVA: 0x729FB30
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x729FB90
        public void GetArgumentName(){} // RVA: 0x729FBF0
    }

}