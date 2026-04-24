// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Encodings.Web
// Classes: 9
// Methods: 55

namespace ThirdParty.DotNet.System.Text.Encodings.Web
{
    public class AllowedBmpCodePointsBitmap : ValueType
    {
        // ── Methods ──
        public void AllowChar(){} // RVA: 0x7FFD53EA44E0
        public void ForbidChar(){} // RVA: 0x7FFD53EA4500
        public void ForbidHtmlCharacters(){} // RVA: 0x7FFD53EA4520
        public void ForbidUndefinedCharacters(){} // RVA: 0x7FFD543EC600
        public void IsCharAllowed(){} // RVA: 0x7FFD53EA4800
        public void IsCodePointAllowed(){} // RVA: 0x7FFD53EA4820
        public void _GetIndexAndOffset(){} // RVA: 0x7FFD53EA4840
    }

    public class AsciiByteMap : ValueType
    {
        // ── Methods ──
        public void InsertAsciiChar(){} // RVA: 0x7FFD53EA44A0
        public void TryLookup(){} // RVA: 0x7FFD53EA44C0
    }

    public class DefaultJavaScriptEncoder : JavaScriptEncoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD543EDBA0 | overloaded x2
        public void EncodeCore(){} // RVA: 0x7FFD543EDDD0
        public void EncodeUtf8Core(){} // RVA: 0x7FFD543EDE30
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFD543EDEC0 | overloaded x2
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x7FFD543EDF50
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFD543EDF80
        public void WillEncode(){} // RVA: 0x7FFD543EE0C0
        public void .cctor(){} // RVA: 0x7FFD543EE120
    }

    public class JavaScriptEncoder : TextEncoder
    {
        public object Default;

        // ── Methods ──
        public void get_Default(){} // RVA: 0x7FFD543EEEF0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class OptimizedInboxTextEncoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD543EC770
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFD543EC980
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFD543ECA10
        public void Encode(){} // RVA: 0x7FFD543ECB60
        public void EncodeUtf8(){} // RVA: 0x7FFD543ECF70
        public void GetIndexOfFirstByteToEncode(){} // RVA: 0x7FFD543ED450
        public void GetIndexOfFirstCharToEncode(){} // RVA: 0x7FFD543ED680
        public void IsScalarValueAllowed(){} // RVA: 0x7FFD53EA5C50
        public void _AssertThisNotNull(){} // RVA: 0x7FFD543ED8A0
    }

    public class ScalarEscaperBase : Object
    {
        // ── Methods ──
        public void EncodeUtf16(){}
        public void EncodeUtf8(){}
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SpanUtility : Object
    {
        // ── Methods ──
        public void IsValidIndex(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryWriteUInt64LittleEndian(){} // RVA: 0x7FFD53EA76B0
        public void AreValidIndexAndLength(){} // RVA: 0x7FFD53EA7770
    }

    public class TextEncoder : Object
    {
        // ── Methods ──
        public void TryEncodeUnicodeScalar(){} // RVA: 0x7FFD543EEF50 | overloaded x2
        public void TryEncodeUnicodeScalarUtf8(){} // RVA: 0x7FFD543EEFE0
        public void FindFirstCharacterToEncode(){} // RVA: 0x7FFD543F0180 | overloaded x2
        public void WillEncode(){} // RVA: 0x7FFD4E07A310
        public void EncodeUtf8(){} // RVA: 0x7FFD543EF350
        public void EncodeUtf8Core(){} // RVA: 0x7FFD543EF660
        public void Encode(){} // RVA: 0x7FFD543EF9B0
        public void EncodeCore(){} // RVA: 0x7FFD543EFCC0
        public void FindFirstCharacterToEncodeUtf8(){} // RVA: 0x7FFD543F01F0
        public void ThrowArgumentException_MaxOutputCharsPerInputChar(){} // RVA: 0x7FFD543F0430
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TextEncoderSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD543F04A0
        public void AllowRange(){} // RVA: 0x7FFD543F04D0
        public void AllowRanges(){} // RVA: 0x7FFD543F0530
        public void GetAllowedCodePoints(){} // RVA: 0x7FFD543F05A0
        public void GetAllowedCodePointsBitmap(){} // RVA: 0x7FFD543F0650
    }

}