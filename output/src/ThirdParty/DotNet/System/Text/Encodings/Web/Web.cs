// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Encodings.Web
// Classes: 10
// Methods: 57

namespace ThirdParty.DotNet.System.Text.Encodings.Web
{
    public class AllowedBmpCodePointsBitmap : ValueType
    {
        // ── Methods ──
        public void AllowChar(){} // RVA: 0x7FFE86E2DB70
        public void ForbidChar(){} // RVA: 0x7FFE86E2DB90
        public void ForbidHtmlCharacters(){} // RVA: 0x7FFE86E2DBB0
        public void ForbidUndefinedCharacters(){} // RVA: 0x7FFE87374DC0
        public void IsCharAllowed(){} // RVA: 0x7FFE86E2DE90
        public void IsCodePointAllowed(){} // RVA: 0x7FFE86E2DEB0
        public void _GetIndexAndOffset(){} // RVA: 0x7FFE86E2DED0
    }

    public class AsciiByteMap : ValueType
    {
        // ── Methods ──
        public void InsertAsciiChar(){} // RVA: 0x7FFE86E2DB30
        public void TryLookup(){} // RVA: 0x7FFE86E2DB50
    }

    public class DefaultJavaScriptEncoder : JavaScriptEncoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87376360 | overloaded x2
        public void EncodeCore(){} // RVA: 0x7FFE87376590
        public void EncodeUtf8Core(){} // RVA: 0x7FFE873765F0
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFE87376680 | overloaded x2
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x7FFE87376710
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFE87376740
        public void WillEncode(){} // RVA: 0x7FFE87376880
        public void .cctor(){} // RVA: 0x7FFE873768E0
    }

    public class JavaScriptEncoder : TextEncoder
    {
        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFE873776B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OptimizedInboxTextEncoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87374F30
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFE87375140
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFE873751D0
        public void Encode(){} // RVA: 0x7FFE87375320
        public void EncodeUtf8(){} // RVA: 0x7FFE87375730
        public void GetIndexOfFirstByteToEncode(){} // RVA: 0x7FFE87375C10
        public void GetIndexOfFirstCharToEncode(){} // RVA: 0x7FFE87375E40
        public void IsScalarValueAllowed(){} // RVA: 0x7FFE86E2F2E0
        public void _AssertThisNotNull(){} // RVA: 0x7FFE87376060
    }

    public class ScalarEscaperBase : Object
    {
        // ── Methods ──
        public void EncodeUtf16(){}
        public void EncodeUtf8(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SpanUtility : Object
    {
        // ── Methods ──
        public void IsValidIndex(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryWriteUInt64LittleEndian(){} // RVA: 0x7FFE86E30D40
        public void AreValidIndexAndLength(){} // RVA: 0x7FFE86E30E00
    }

    public class TextEncoder : Object
    {
        // ── Methods ──
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFE87377710 | overloaded x2
        public void TryEncodeUnicodeScalarUtf8(){} // RVA: 0x7FFE873777A0
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFE87378940 | overloaded x2
        public void WillEncode(){} // RVA: 0x7FFE80E2F760
        public void EncodeUtf8(){} // RVA: 0x7FFE87377B10
        public void EncodeUtf8Core(){} // RVA: 0x7FFE87377E20
        public void Encode(){} // RVA: 0x7FFE87378170
        public void EncodeCore(){} // RVA: 0x7FFE87378480
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x7FFE873789B0
        public void ThrowArgumentException_MaxOutputCharsPerInputChar(){} // RVA: 0x7FFE87378BF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TextEncoderSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87378C60
        public void AllowRange(){} // RVA: 0x7FFE87378C90
        public void AllowRanges(){} // RVA: 0x7FFE87378CF0
        public void GetAllowedCodePoints(){} // RVA: 0x7FFE87378D60
        public void GetAllowedCodePointsBitmap(){} // RVA: 0x7FFE87378E10
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFE86E32800
        public void GetArgumentName(){} // RVA: 0x7FFE86E32860
    }

}