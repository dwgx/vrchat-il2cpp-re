// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger
// Classes: 31
// Methods: 152

namespace ThirdParty.Other.ZLogger
{
    public class AsyncStreamLineMessageWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5BA7A0 | overloaded x2
        public void Post(){} // RVA: 0x7FFAFC5BAD30
        public void PostSlow(){} // RVA: 0x7FFAFC5BAE70
        public void AppendLine(){} // RVA: 0x7FFAFC5BAF40
        public void WriteLoop(){} // RVA: 0x7FFAFC5BB060
        public void DisposeAsync(){} // RVA: 0x7FFAFC5BB220
    }

    public class CustomFormatParser
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFAFC5C1AC0
        public void .cctor(){} // RVA: 0x7FFAFC5C1E00
    }

    public class IAsyncLogProcessor
    {
        // ── Methods ──
        public void Post(){} // RVA: 0x7FFAF2AD4B10
    }

    public class INonReturnableZLoggerEntry
    {
        // ── Methods ──
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IReferenceCountable
    {
        // ── Methods ──
        public void Retain(){} // RVA: 0x7FFAF2AD4A50
        public void Release(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IZLoggerAdditionalInfo
    {
        // ── Methods ──
        public void GetAdditionalInfo(){}
    }

    public class IZLoggerEntry
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IZLoggerEntryCreatable
    {
        // ── Methods ──
        public void CreateEntry(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IZLoggerFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
    }

    public class IZLoggerFormatter
    {
        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0x7FFAF2ABDBE0
        public void FormatLogEntry(){} // RVA: 0x7FFAF2D33FA0
    }

    public class InterpolatedStringParameter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5C3990
    }

    public class LogCategory
    {
        // ── Methods ──
        public void get_Utf8Span(){} // RVA: 0x7FFAFC5BC580
        public void .ctor(){} // RVA: 0x7FFAFC5BC620
        public void ToString(){} // RVA: 0x7FFAF44189C0
    }

    public class LogInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5BC2A0
    }

    public class LogScopeState
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAFC5BC7F0
        public void Return(){} // RVA: 0x7FFAFC5BC9C0
        public void Clear(){} // RVA: 0x7FFAFC5BCAA0
        public void Snapshot(){} // RVA: 0x7FFAFC5BCB10
        public void .ctor(){} // RVA: 0x7FFAFC5BCDB0
        public void .cctor(){} // RVA: 0x7FFAFC5BCE70
    }

    public class MessageSequence
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7FFAFC5C2380
        public void .ctor(){} // RVA: 0x7FFAFC5C2920
        public void ToString(){} // RVA: 0x7FFAFC5C3200 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAFC5C32C0
    }

    public class MessageSequenceSegment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void get_IsLiteral(){} // RVA: 0x7FFAF3BB2770
        public void ToString(){} // RVA: 0x7FFAF4584690
    }

    public class MessageTemplate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void AppendLogLevel(){} // RVA: 0x7FFAFC5BE6F0
        public void AppendLogCategory(){} // RVA: 0x7FFAFC5BEAD0
        public void AppendTimestamp(){} // RVA: 0x7FFAFC5BEC50
        public void Format(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void AppendFormatted(){} // RVA: 0x7FFAF2ADA310
    }

    public class MessageTemplateChunk
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5BDE00
        public void get_Literal(){} // RVA: 0x7FFAF4584690
        public void get_Index(){} // RVA: 0x7FFAF4959890
        public void get_Alignment(){} // RVA: 0x7FFAF49598B0
        public void get_Format(){} // RVA: 0x7FFAF2DA8380
        public void get_NoAlignmentAndFormat(){} // RVA: 0x7FFAF2DA84E0
        public void ToString(){} // RVA: 0x7FFAFC5BDED0
        public void PrintMembers(){} // RVA: 0x7FFAFC5BE000
        public void GetHashCode(){} // RVA: 0x7FFAFC5BE2E0
        public void Equals(){} // RVA: 0x7FFAFC5BE530 | overloaded x2
    }

    public class MessageTemplateHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5BD190
        public void AppendLiteral(){} // RVA: 0x7FFAFC5BD260
        public void AppendFormatted(){} // RVA: 0x7FFAFC5BD3D0
        public void GetTemplate(){} // RVA: 0x7FFAFC5BD500
    }

    public class MessageTemplateHolder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC082530
        public void get_EqualityContract(){} // RVA: 0x7FFAFC5BD690
        public void get_LiteralLength(){} // RVA: 0x7FFAF2DDA5C0
        public void get_FormattedCount(){} // RVA: 0x7FFAF335BED0
        public void get_TemplateChunk(){} // RVA: 0x7FFAF2D907C0
        public void ToString(){} // RVA: 0x7FFAFC5BD740
        public void PrintMembers(){} // RVA: 0x7FFAFC5BD870
        public void op_Inequality(){} // RVA: 0x7FFAFC5BDA70
        public void op_Equality(){} // RVA: 0x7FFAFC5BDAA0
        public void GetHashCode(){} // RVA: 0x7FFAFC5BDAC0
        public void Equals(){} // RVA: 0x7FFAFC5BDC80 | overloaded x2
    }

    public class Timestamp
    {
        // ── Methods ──
        public void get_Utc(){} // RVA: 0x7FFAF320E7E0
        public void get_Local(){} // RVA: 0x7FFAFC5BED70
        public void ToString(){} // RVA: 0x7FFAFC5BEE70
        public void .ctor(){} // RVA: 0x7FFAFC5BEF00
        public void ToLocalTime(){} // RVA: 0x7FFAFC5BF0B0
        public void TryFormat(){} // RVA: 0x7FFAFC5BF300
        public void FormatDate(){} // RVA: 0x7FFAFC5BFCA0
        public void FormatTime(){} // RVA: 0x7FFAFC5C00F0
        public void FormatTimeMilliseconds(){} // RVA: 0x7FFAFC5C0390
        public void FormatDateAndTime(){} // RVA: 0x7FFAFC5C04C0
        public void FormatDateAndTimeAndMilliseconds(){} // RVA: 0x7FFAFC5C05C0
        public void AppendWithFillZero1(){} // RVA: 0x7FFAFC5C0800
        public void AppendWithFillZero2(){} // RVA: 0x7FFAFC5C08E0
        public void AppendWithFillZero3(){} // RVA: 0x7FFAFC5C09C0
        public void .cctor(){} // RVA: 0x7FFAFC5C0AA0
    }

    public class ZLoggerBuilderExtensions
    {
        // ── Methods ──
        public void AddZLoggerFile(){} // RVA: 0x7FFAFC5C0E40 | overloaded x2
    }

    public class ZLoggerDebugInterpolatedStringHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5C3B00
        public void AppendLiteral(){} // RVA: 0x7FFAFC5C3B70
        public void AppendFormatted(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
    }

    public class ZLoggerEntry`1
    {
        // ── Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2ADDC60
        public void Create(){} // RVA: 0x7FFAF2ABCEC0
        public void ToString(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void CreateEntry(){} // RVA: 0x7FFAF2ABCE10
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7FFAF2ADDC60
        public void Return(){} // RVA: 0x7FFAF2AD4A50
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ZLoggerEntry`1
    {
        // ── Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7FFAF68A6A30
        public void .ctor(){} // RVA: 0x7FFAF7852340
        public void Create(){} // RVA: 0x7FFAF7852460
        public void ToString(){} // RVA: 0x7FFAF7852890 | overloaded x2
        public void CreateEntry(){} // RVA: 0x7FFAF7852820
        public void get_LogInfo(){} // RVA: 0x7FFAF7850EB0
        public void FormatUtf8(){} // RVA: 0x7FFAF7850F00
        public void Return(){} // RVA: 0x7FFAF7852900
        public void .cctor(){} // RVA: 0x7FFAF7851210
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFAF7852820
    }

    public class ZLoggerErrorInterpolatedStringHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5C3BF0
        public void AppendLiteral(){} // RVA: 0x7FFAFC5C3B70
        public void AppendFormatted(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
    }

    public class ZLoggerExtensions
    {
        // ── Methods ──
        public void ZLog(){} // RVA: 0x7FFAFC5C1090
        public void ZLogDebug(){} // RVA: 0x7FFAFC5C1530
        public void ZLogWarning(){} // RVA: 0x7FFAFC5C1590
        public void ZLogError(){} // RVA: 0x7FFAFC5C1650 | overloaded x2
    }

    public class ZLoggerInterpolatedStringHandler
    {
        // ── Methods ──
        public void get_IsLoggerEnabled(){} // RVA: 0x7FFAF48F0360
        public void .ctor(){} // RVA: 0x7FFAFC5C1790
        public void AppendLiteral(){} // RVA: 0x7FFAFC5C1900
        public void AppendFormatted(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetState(){} // RVA: 0x7FFAFC5C19A0
    }

    public class ZLoggerLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5C3C60
        public void Log(){} // RVA: 0x7FFAF2D33FA0
        public void BeginScope(){} // RVA: 0x7FFAF2D33FA0
        public void IsEnabled(){} // RVA: 0x7FFAFC5C3E10
    }

    public class ZLoggerOptions
    {
        // ── Methods ──
        public void get_InternalErrorLogger(){} // RVA: 0x7FFAF2DA8380
        public void set_InternalErrorLogger(){} // RVA: 0x7FFAF2D8EE30
        public void get_IncludeScopes(){} // RVA: 0x7FFAF2DA84E0
        public void get_TimeProvider(){} // RVA: 0x7FFAF2DBB0C0
        public void get_FullMode(){} // RVA: 0x7FFAF3241DC0
        public void get_BackgroundBufferCapacity(){} // RVA: 0x7FFAF3CB9F00
        public void CreateFormatter(){} // RVA: 0x7FFAF8C9B2D0
        public void UseFormatter(){} // RVA: 0x7FFAF492D420
        public void UsePlainTextFormatter(){} // RVA: 0x7FFAFC5C3EC0
        public void DefaultFormatterFactory(){} // RVA: 0x7FFAFC5C4040
        public void .ctor(){} // RVA: 0x7FFAFC5C4090
    }

    public class ZLoggerWarningInterpolatedStringHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC5C3B80
        public void AppendLiteral(){} // RVA: 0x7FFAFC5C3B70
        public void AppendFormatted(){} // RVA: 0x7FFAF2D33FA0
    }

}