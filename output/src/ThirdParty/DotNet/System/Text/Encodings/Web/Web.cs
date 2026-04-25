// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Encodings.Web
// Classes: 10
// Methods: 57

namespace ThirdParty.DotNet.System.Text.Encodings.Web
{
    public class AllowedBmpCodePointsBitmap : ValueType
    {
        public <Bitmap>e__FixedBuffer Bitmap; // 0x10

        // ── Methods ──
        public void AllowChar(){} // RVA: 0x7FFAC8A844E0
        public void ForbidChar(){} // RVA: 0x7FFAC8A84500
        public void ForbidHtmlCharacters(){} // RVA: 0x7FFAC8A84520
        public void ForbidUndefinedCharacters(){} // RVA: 0x7FFAC8FCC600
        public void IsCharAllowed(){} // RVA: 0x7FFAC8A84800
        public void IsCodePointAllowed(){} // RVA: 0x7FFAC8A84820
        public void _GetIndexAndOffset(){} // RVA: 0x7FFAC8A84840
    }

    public class AsciiByteMap : ValueType
    {
        public <Buffer>e__FixedBuffer Buffer; // 0x10

        // ── Methods ──
        public void InsertAsciiChar(){} // RVA: 0x7FFAC8A844A0
        public void TryLookup(){} // RVA: 0x7FFAC8A844C0
    }

    public class DefaultJavaScriptEncoder : JavaScriptEncoder
    {
        public System.Text.Encodings.Web.DefaultJavaScriptEncoder BasicLatinSingleton;
        public System.Text.Encodings.Web.DefaultJavaScriptEncoder UnsafeRelaxedEscapingSingleton; // 0x8
        public System.Text.Encodings.Web.OptimizedInboxTextEncoder _innerEncoder; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FCDBA0 | overloaded x2
        public void EncodeCore(){} // RVA: 0x7FFAC8FCDDD0
        public void EncodeUtf8Core(){} // RVA: 0x7FFAC8FCDE30
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFAC8FCDEC0 | overloaded x2
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x7FFAC8FCDF50
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFAC8FCDF80
        public void WillEncode(){} // RVA: 0x7FFAC8FCE0C0
        public void .cctor(){} // RVA: 0x7FFAC8FCE120
    }

    public class JavaScriptEncoder : TextEncoder
    {
        public object Default;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFAC8FCEEF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OptimizedInboxTextEncoder : Object
    {
        public AllowedAsciiCodePoints _allowedAsciiCodePoints; // 0x10
        public AsciiPreescapedData _asciiPreescapedData; // 0x20
        public System.Text.Encodings.Web.AllowedBmpCodePointsBitmap _allowedBmpCodePoints; // 0x420
        public System.Text.Encodings.Web.ScalarEscaperBase _scalarEscaper; // 0x2420

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FCC770
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFAC8FCC980
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFAC8FCCA10
        public void Encode(){} // RVA: 0x7FFAC8FCCB60
        public void EncodeUtf8(){} // RVA: 0x7FFAC8FCCF70
        public void GetIndexOfFirstByteToEncode(){} // RVA: 0x7FFAC8FCD450
        public void GetIndexOfFirstCharToEncode(){} // RVA: 0x7FFAC8FCD680
        public void IsScalarValueAllowed(){} // RVA: 0x7FFAC8A85C50
        public void _AssertThisNotNull(){} // RVA: 0x7FFAC8FCD8A0
    }

    public class ScalarEscaperBase : Object
    {
        // ── Methods ──
        public void EncodeUtf16(){}
        public void EncodeUtf8(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SpanUtility : Object
    {
        // ── Methods ──
        public void IsValidIndex(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryWriteUInt64LittleEndian(){} // RVA: 0x7FFAC8A876B0
        public void AreValidIndexAndLength(){} // RVA: 0x7FFAC8A87770
    }

    public class TextEncoder : Object
    {
        // ── Methods ──
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFAC8FCEF50 | overloaded x2
        public void TryEncodeUnicodeScalarUtf8(){} // RVA: 0x7FFAC8FCEFE0
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFAC8FD0180 | overloaded x2
        public void WillEncode(){} // RVA: 0x7FFAC2C5A310
        public void EncodeUtf8(){} // RVA: 0x7FFAC8FCF350
        public void EncodeUtf8Core(){} // RVA: 0x7FFAC8FCF660
        public void Encode(){} // RVA: 0x7FFAC8FCF9B0
        public void EncodeCore(){} // RVA: 0x7FFAC8FCFCC0
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x7FFAC8FD01F0
        public void ThrowArgumentException_MaxOutputCharsPerInputChar(){} // RVA: 0x7FFAC8FD0430
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TextEncoderSettings : Object
    {
        public System.Text.Encodings.Web.AllowedBmpCodePointsBitmap _allowedCodePointsBitmap; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8FD04A0
        public void AllowRange(){} // RVA: 0x7FFAC8FD04D0
        public void AllowRanges(){} // RVA: 0x7FFAC8FD0530
        public void GetAllowedCodePoints(){} // RVA: 0x7FFAC8FD05A0
        public void GetAllowedCodePointsBitmap(){} // RVA: 0x7FFAC8FD0650
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFAC8A89170
        public void GetArgumentName(){} // RVA: 0x7FFAC8A891D0
    }

}