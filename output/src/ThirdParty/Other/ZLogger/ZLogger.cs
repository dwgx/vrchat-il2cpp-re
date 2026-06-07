// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger
// Classes: 30
// Methods: 141

namespace ThirdParty.Other.ZLogger
{
    public class AsyncStreamLineMessageWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B0A7A0 | overloaded x2
        public void Post(){} // RVA: 0x9B0AD30
        public void PostSlow(){} // RVA: 0x9B0AE70
        public void AppendLine(){} // RVA: 0x9B0AF40
        public void WriteLoop(){} // RVA: 0x9B0B060
        public void DisposeAsync(){} // RVA: 0x9B0B220
    }

    public class CustomFormatParser
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x9B11AC0
        public void .cctor(){} // RVA: 0x9B11E00
    }

    public class IAsyncLogProcessor
    {
        // ── Methods ──
        public void Post(){} // RVA: 0x24B10
    }

    public class INonReturnableZLoggerEntry
    {
        // ── Methods ──
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x2DC60
    }

    public class IReferenceCountable
    {
        // ── Methods ──
        public void Retain(){} // RVA: 0x24A50
        public void Release(){} // RVA: 0x24A50
    }

    public class IZLoggerAdditionalInfo
    {
        // ── Methods ──
        public void GetAdditionalInfo(){}
    }

    public class IZLoggerEntry
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x24A50
    }

    public class IZLoggerEntryCreatable
    {
        // ── Methods ──
        public void CreateEntry(){} // RVA: 0xCE10
    }

    public class IZLoggerFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x24B10 | overloaded x2
    }

    public class IZLoggerFormatter
    {
        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0xDBE0
        public void FormatLogEntry(){} // RVA: 0x283FA0
    }

    public class InterpolatedStringParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B13990
    }

    public class LogCategory
    {
        // ── Methods ──
        public void get_Utf8Span(){} // RVA: 0x9B0C580
        public void .ctor(){} // RVA: 0x9B0C620
        public void ToString(){} // RVA: 0x19689C0
    }

    public class LogInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B0C2A0
    }

    public class LogScopeState
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x9B0C7F0
        public void Return(){} // RVA: 0x9B0C9C0
        public void Clear(){} // RVA: 0x9B0CAA0
        public void Snapshot(){} // RVA: 0x9B0CB10
        public void .ctor(){} // RVA: 0x9B0CDB0
        public void .cctor(){} // RVA: 0x9B0CE70
    }

    public class MessageSequence
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x9B12380
        public void .ctor(){} // RVA: 0x9B12920
        public void ToString(){} // RVA: 0x9B13200 | overloaded x3
        public void .cctor(){} // RVA: 0x9B132C0
    }

    public class MessageSequenceSegment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void get_IsLiteral(){} // RVA: 0x1102770
        public void ToString(){} // RVA: 0x1AD4690
    }

    public class MessageTemplate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void AppendLogLevel(){} // RVA: 0x9B0E6F0
        public void AppendLogCategory(){} // RVA: 0x9B0EAD0
        public void AppendTimestamp(){} // RVA: 0x9B0EC50
        public void Format(){} // RVA: 0x283FA0 | overloaded x2
        public void AppendFormatted(){} // RVA: 0x2A310
    }

    public class MessageTemplateChunk
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B0DE00
        public void get_Literal(){} // RVA: 0x1AD4690
        public void get_Index(){} // RVA: 0x1EA9890
        public void get_Alignment(){} // RVA: 0x1EA98B0
        public void get_Format(){} // RVA: 0x2F8380
        public void get_NoAlignmentAndFormat(){} // RVA: 0x2F84E0
        public void ToString(){} // RVA: 0x9B0DED0
        public void PrintMembers(){} // RVA: 0x9B0E000
        public void GetHashCode(){} // RVA: 0x9B0E2E0
        public void Equals(){} // RVA: 0x9B0E530 | overloaded x2
    }

    public class MessageTemplateHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B0D190
        public void AppendLiteral(){} // RVA: 0x9B0D260
        public void AppendFormatted(){} // RVA: 0x9B0D3D0
        public void GetTemplate(){} // RVA: 0x9B0D500
    }

    public class MessageTemplateHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95D2530
        public void get_EqualityContract(){} // RVA: 0x9B0D690
        public void get_LiteralLength(){} // RVA: 0x32A5C0
        public void get_FormattedCount(){} // RVA: 0x8ABED0
        public void get_TemplateChunk(){} // RVA: 0x2E07C0
        public void ToString(){} // RVA: 0x9B0D740
        public void PrintMembers(){} // RVA: 0x9B0D870
        public void op_Inequality(){} // RVA: 0x9B0DA70
        public void op_Equality(){} // RVA: 0x9B0DAA0
        public void GetHashCode(){} // RVA: 0x9B0DAC0
        public void Equals(){} // RVA: 0x9B0DC80 | overloaded x2
    }

    public class Timestamp
    {
        // ── Methods ──
        public void get_Utc(){} // RVA: 0x75E7E0
        public void get_Local(){} // RVA: 0x9B0ED70
        public void ToString(){} // RVA: 0x9B0EE70
        public void .ctor(){} // RVA: 0x9B0EF00
        public void ToLocalTime(){} // RVA: 0x9B0F0B0
        public void TryFormat(){} // RVA: 0x9B0F300
        public void FormatDate(){} // RVA: 0x9B0FCA0
        public void FormatTime(){} // RVA: 0x9B100F0
        public void FormatTimeMilliseconds(){} // RVA: 0x9B10390
        public void FormatDateAndTime(){} // RVA: 0x9B104C0
        public void FormatDateAndTimeAndMilliseconds(){} // RVA: 0x9B105C0
        public void AppendWithFillZero1(){} // RVA: 0x9B10800
        public void AppendWithFillZero2(){} // RVA: 0x9B108E0
        public void AppendWithFillZero3(){} // RVA: 0x9B109C0
        public void .cctor(){} // RVA: 0x9B10AA0
    }

    public class ZLoggerBuilderExtensions
    {
        // ── Methods ──
        public void AddZLoggerFile(){} // RVA: 0x9B10E40 | overloaded x2
    }

    public class ZLoggerDebugInterpolatedStringHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B13B00
        public void AppendLiteral(){} // RVA: 0x9B13B70
        public void AppendFormatted(){} // RVA: 0x283FA0 | overloaded x2
    }

    public class ZLoggerEntry`1
    {
        // ── Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DC60
        public void Create(){} // RVA: 0xCEC0
        public void ToString(){} // RVA: 0x24B10 | overloaded x2
        public void CreateEntry(){} // RVA: 0xCE10
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x2DC60
        public void Return(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0xCE10
    }

    public class ZLoggerErrorInterpolatedStringHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B13BF0
        public void AppendLiteral(){} // RVA: 0x9B13B70
        public void AppendFormatted(){} // RVA: 0x283FA0 | overloaded x3
    }

    public class ZLoggerExtensions
    {
        // ── Methods ──
        public void ZLog(){} // RVA: 0x9B11090
        public void ZLogDebug(){} // RVA: 0x9B11530
        public void ZLogWarning(){} // RVA: 0x9B11590
        public void ZLogError(){} // RVA: 0x9B11650 | overloaded x2
    }

    public class ZLoggerInterpolatedStringHandler
    {
        // ── Methods ──
        public void get_IsLoggerEnabled(){} // RVA: 0x1E40360
        public void .ctor(){} // RVA: 0x9B11790
        public void AppendLiteral(){} // RVA: 0x9B11900
        public void AppendFormatted(){} // RVA: 0x283FA0 | overloaded x2
        public void GetState(){} // RVA: 0x9B119A0
    }

    public class ZLoggerLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B13C60
        public void Log(){} // RVA: 0x283FA0
        public void BeginScope(){} // RVA: 0x283FA0
        public void IsEnabled(){} // RVA: 0x9B13E10
    }

    public class ZLoggerOptions
    {
        // ── Methods ──
        public void get_InternalErrorLogger(){} // RVA: 0x2F8380
        public void set_InternalErrorLogger(){} // RVA: 0x2DEE30
        public void get_IncludeScopes(){} // RVA: 0x2F84E0
        public void get_TimeProvider(){} // RVA: 0x30B0C0
        public void get_FullMode(){} // RVA: 0x791DC0
        public void get_BackgroundBufferCapacity(){} // RVA: 0x1209F00
        public void CreateFormatter(){} // RVA: 0x61EB2D0
        public void UseFormatter(){} // RVA: 0x1E7D420
        public void UsePlainTextFormatter(){} // RVA: 0x9B13EC0
        public void DefaultFormatterFactory(){} // RVA: 0x9B14040
        public void .ctor(){} // RVA: 0x9B14090
    }

    public class ZLoggerWarningInterpolatedStringHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9B13B80
        public void AppendLiteral(){} // RVA: 0x9B13B70
        public void AppendFormatted(){} // RVA: 0x283FA0
    }

}