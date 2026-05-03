// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger
// Classes: 30
// Methods: 141

namespace ThirdParty.Other.ZLogger
{
    public class AsyncStreamLineMessageWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A54A010 | overloaded x2
        public void Post(){} // RVA: 0x7FFE8A54A5A0
        public void PostSlow(){} // RVA: 0x7FFE8A54A6E0
        public void AppendLine(){} // RVA: 0x7FFE8A54A7B0
        public void WriteLoop(){} // RVA: 0x7FFE8A54A8D0
        public void DisposeAsync(){} // RVA: 0x7FFE8A54AA90
    }

    public class CustomFormatParser : Object
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFE8A551330
        public void .cctor(){} // RVA: 0x7FFE8A551670
    }

    public class IAsyncLogProcessor
    {
        // ── Methods ──
        public void Post(){} // RVA: 0x7FFE80E460A0
    }

    public class INonReturnableZLoggerEntry
    {
        // ── Methods ──
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7FFE80E4F230
    }

    public class IReferenceCountable
    {
        // ── Methods ──
        public void Retain(){} // RVA: 0x7FFE80E45FE0
        public void Release(){} // RVA: 0x7FFE80E45FE0
    }

    public class IZLoggerAdditionalInfo
    {
        // ── Methods ──
        public void GetAdditionalInfo(){}
    }

    public class IZLoggerEntry
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x7FFE80E45FE0
    }

    public class IZLoggerEntryCreatable
    {
        // ── Methods ──
        public void CreateEntry(){} // RVA: 0x7FFE80E2E390
    }

    public class IZLoggerFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE80E460A0 | overloaded x2
    }

    public class IZLoggerFormatter
    {
        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0x7FFE80E2F150
        public void FormatLogEntry(){} // RVA: 0x7FFE810A1420
    }

    public class InterpolatedStringParameter : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A553200
    }

    public class LogCategory : ValueType
    {
        public byte[] utf8; // 0x10

        // ── Methods ──
        public void get_Utf8Span(){} // RVA: 0x7FFE8A54BDF0
        public void .ctor(){} // RVA: 0x7FFE8A54BE90
        public void ToString(){} // RVA: 0x7FFE826F4210
    }

    public class LogInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A54BB10
    }

    public class LogScopeState : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE8A54C060
        public void Return(){} // RVA: 0x7FFE8A54C230
        public void Clear(){} // RVA: 0x7FFE8A54C310
        public void Snapshot(){} // RVA: 0x7FFE8A54C380
        public void .ctor(){} // RVA: 0x7FFE8A54C620
        public void .cctor(){} // RVA: 0x7FFE8A54C6E0
    }

    public class MessageSequence : Object
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7FFE8A551BF0
        public void .ctor(){} // RVA: 0x7FFE8A552190
        public void ToString(){} // RVA: 0x7FFE8A552A70 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE8A552B30
    }

    public class MessageSequenceSegment : ValueType
    {
        public string Literal; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void get_IsLiteral(){} // RVA: 0x7FFE81E76100
        public void ToString(){} // RVA: 0x7FFE8284EF60
    }

    public class MessageTemplate : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void AppendLogLevel(){} // RVA: 0x7FFE8A54DF60
        public void AppendLogCategory(){} // RVA: 0x7FFE8A54E340
        public void AppendTimestamp(){} // RVA: 0x7FFE8A54E4C0
        public void Format(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void AppendFormatted(){} // RVA: 0x7FFE80E4B8F0
    }

    public class MessageTemplateChunk : ValueType
    {
        public byte[] _literal; // 0x10
        public int _index; // 0x18
        public int _alignment; // 0x1C
        public string _format; // 0x20
        public bool _noAlignmentAndFormat; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A54D670
        public void get_Literal(){} // RVA: 0x7FFE8284EF60
        public void get_Index(){} // RVA: 0x7FFE82C33000
        public void get_Alignment(){} // RVA: 0x7FFE82C33020
        public void get_Format(){} // RVA: 0x7FFE81116380
        public void get_NoAlignmentAndFormat(){} // RVA: 0x7FFE811164E0
        public void ToString(){} // RVA: 0x7FFE8A54D740
        public void PrintMembers(){} // RVA: 0x7FFE8A54D870
        public void GetHashCode(){} // RVA: 0x7FFE8A54DB50
        public void Equals(){} // RVA: 0x7FFE8A54DDA0 | overloaded x2
    }

    public class MessageTemplateHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A54CA00
        public void AppendLiteral(){} // RVA: 0x7FFE8A54CAD0
        public void AppendFormatted(){} // RVA: 0x7FFE8A54CC40
        public void GetTemplate(){} // RVA: 0x7FFE8A54CD70
    }

    public class MessageTemplateHolder : Object
    {
        public int _literalLength; // 0x10
        public int _formattedCount; // 0x14
        public ZLogger.MessageTemplateChunk[] _templateChunk; // 0x18
        public object field_3; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A034910
        public void get_EqualityContract(){} // RVA: 0x7FFE8A54CF00
        public void get_LiteralLength(){} // RVA: 0x7FFE811485C0
        public void get_FormattedCount(){} // RVA: 0x7FFE8164B230
        public void get_TemplateChunk(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE8A54CFB0
        public void PrintMembers(){} // RVA: 0x7FFE8A54D0E0
        public void op_Inequality(){} // RVA: 0x7FFE8A54D2E0
        public void op_Equality(){} // RVA: 0x7FFE8A54D310
        public void GetHashCode(){} // RVA: 0x7FFE8A54D330
        public void Equals(){} // RVA: 0x7FFE8A54D4F0 | overloaded x2
    }

    public class Timestamp : ValueType
    {
        public System.DateTimeOffset utcNow; // 0x10
        public System.TimeProvider timeProvider; // 0x20

        // ── Methods ──
        public void get_Utc(){} // RVA: 0x7FFE8151C410
        public void get_Local(){} // RVA: 0x7FFE8A54E5E0
        public void ToString(){} // RVA: 0x7FFE8A54E6E0
        public void .ctor(){} // RVA: 0x7FFE8A54E770
        public void ToLocalTime(){} // RVA: 0x7FFE8A54E920
        public void TryFormat(){} // RVA: 0x7FFE8A54EB70
        public void FormatDate(){} // RVA: 0x7FFE8A54F510
        public void FormatTime(){} // RVA: 0x7FFE8A54F960
        public void FormatTimeMilliseconds(){} // RVA: 0x7FFE8A54FC00
        public void FormatDateAndTime(){} // RVA: 0x7FFE8A54FD30
        public void FormatDateAndTimeAndMilliseconds(){} // RVA: 0x7FFE8A54FE30
        public void AppendWithFillZero1(){} // RVA: 0x7FFE8A550070
        public void AppendWithFillZero2(){} // RVA: 0x7FFE8A550150
        public void AppendWithFillZero3(){} // RVA: 0x7FFE8A550230
        public void .cctor(){} // RVA: 0x7FFE8A550310
    }

    public class ZLoggerBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerFile(){} // RVA: 0x7FFE8A5506B0 | overloaded x2
    }

    public class ZLoggerDebugInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A553370
        public void AppendLiteral(){} // RVA: 0x7FFE8A5533E0
        public void AppendFormatted(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class ZLoggerEntry`1 : Object
    {
        public ZLogger.Internal.ObjectPool`1<ZLogger.ZLoggerEntry`1<T>> cache;
        public ZLogger.ZLoggerEntry`1<T> next;

        // ── Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void Create(){} // RVA: 0x7FFE80E2E440
        public void ToString(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void CreateEntry(){} // RVA: 0x7FFE80E2E390
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7FFE80E4F230
        public void Return(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFE80E2E390
    }

    public class ZLoggerErrorInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A553460
        public void AppendLiteral(){} // RVA: 0x7FFE8A5533E0
        public void AppendFormatted(){} // RVA: 0x7FFE810A1420 | overloaded x3
    }

    public class ZLoggerExtensions : Object
    {
        // ── Methods ──
        public void ZLog(){} // RVA: 0x7FFE8A550900
        public void ZLogDebug(){} // RVA: 0x7FFE8A550DA0
        public void ZLogWarning(){} // RVA: 0x7FFE8A550E00
        public void ZLogError(){} // RVA: 0x7FFE8A550EC0 | overloaded x2
    }

    public class ZLoggerInterpolatedStringHandler : ValueType
    {
        public System.Collections.Generic.List`1<string> literalPool; // 0xFFFF

        // ── Methods ──
        public void get_IsLoggerEnabled(){} // RVA: 0x7FFE82BC9920
        public void .ctor(){} // RVA: 0x7FFE8A551000
        public void AppendLiteral(){} // RVA: 0x7FFE8A551170
        public void AppendFormatted(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetState(){} // RVA: 0x7FFE8A551210
    }

    public class ZLoggerLogger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A5534D0
        public void Log(){} // RVA: 0x7FFE810A1420
        public void BeginScope(){} // RVA: 0x7FFE810A1420
        public void IsEnabled(){} // RVA: 0x7FFE8A553680
    }

    public class ZLoggerOptions : Object
    {
        public System.Action`1<System.Exception> _internalErrorLogger; // 0x10
        public bool _includeScopes; // 0x18
        public System.TimeProvider _timeProvider; // 0x20
        public 0x666ACFE4 _fullMode; // 0x28
        public int _backgroundBufferCapacity; // 0x2C

        // ── Methods ──
        public void get_InternalErrorLogger(){} // RVA: 0x7FFE81116380
        public void set_InternalErrorLogger(){} // RVA: 0x7FFE810FCE30
        public void get_IncludeScopes(){} // RVA: 0x7FFE811164E0
        public void get_TimeProvider(){} // RVA: 0x7FFE811290C0
        public void get_FullMode(){} // RVA: 0x7FFE81549710
        public void get_BackgroundBufferCapacity(){} // RVA: 0x7FFE81F84A50
        public void CreateFormatter(){} // RVA: 0x7FFE86D2C170
        public void UseFormatter(){} // RVA: 0x7FFE82C06BA0
        public void UsePlainTextFormatter(){} // RVA: 0x7FFE8A553730
        public void DefaultFormatterFactory(){} // RVA: 0x7FFE8A5538B0
        public void .ctor(){} // RVA: 0x7FFE8A553900
    }

    public class ZLoggerWarningInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A5533F0
        public void AppendLiteral(){} // RVA: 0x7FFE8A5533E0
        public void AppendFormatted(){} // RVA: 0x7FFE810A1420
    }

}