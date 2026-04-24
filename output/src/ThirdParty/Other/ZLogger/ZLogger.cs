// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger
// Classes: 28
// Methods: 126

namespace ThirdParty.Other.ZLogger
{
    public class AsyncStreamLineMessageWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57504040 | overloaded x2
        public void Post(){} // RVA: 0x7FFD575045D0
        public void PostSlow(){} // RVA: 0x7FFD57504710
        public void AppendLine(){} // RVA: 0x7FFD575047E0
        public void WriteLoop(){} // RVA: 0x7FFD57504900
        public void DisposeAsync(){} // RVA: 0x7FFD57504AC0
    }

    public class CustomFormatParser : Object
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFD5750B360
        public void .cctor(){} // RVA: 0x7FFD5750B6A0
    }

    public class IAsyncLogProcessor
    {
        // ── Methods ──
        public void Post(){} // RVA: 0x7FFD4E090A40
    }

    public class INonReturnableZLoggerEntry
    {
        public object LogInfo;

        // ── Methods ──
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7FFD4E099B30
    }

    public class IReferenceCountable
    {
        // ── Methods ──
        public void Retain(){} // RVA: 0x7FFD4E090980
        public void Release(){} // RVA: 0x7FFD4E090980
    }

    public class IZLoggerAdditionalInfo
    {
        // ── Methods ──
        public void GetAdditionalInfo(){}
    }

    public class IZLoggerEntry
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x7FFD4E090980
    }

    public class IZLoggerEntryCreatable
    {
        // ── Methods ──
        public void CreateEntry(){} // RVA: 0x7FFD4E078F40
    }

    public class IZLoggerFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD4E090A40 | overloaded x2
    }

    public class IZLoggerFormatter
    {
        public object WithLineBreak;

        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0x7FFD4E079D00
        public void FormatLogEntry(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InterpolatedStringParameter : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5750D230
    }

    public class LogCategory : ValueType
    {
        public object Utf8Span;

        // ── Methods ──
        public void get_Utf8Span(){} // RVA: 0x7FFD57505E20
        public void .ctor(){} // RVA: 0x7FFD57505EC0
        public void ToString(){} // RVA: 0x7FFD4F840220
    }

    public class LogInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57505B40
    }

    public class LogScopeState : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD57506090
        public void Return(){} // RVA: 0x7FFD57506260
        public void Clear(){} // RVA: 0x7FFD57506340
        public void Snapshot(){} // RVA: 0x7FFD575063B0
        public void .ctor(){} // RVA: 0x7FFD57506650
        public void .cctor(){} // RVA: 0x7FFD57506710
    }

    public class MessageSequence : Object
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7FFD5750BC20
        public void .ctor(){} // RVA: 0x7FFD5750C1C0
        public void ToString(){} // RVA: 0x7FFD5750CAA0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD5750CB60
    }

    public class MessageSequenceSegment : ValueType
    {
        public object IsLiteral;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F5CE4B0
        public void get_IsLiteral(){} // RVA: 0x7FFD4EFD0800
        public void ToString(){} // RVA: 0x7FFD4EEF9F60
    }

    public class MessageTemplate : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F5CE4B0
        public void AppendLogLevel(){} // RVA: 0x7FFD57507F90
        public void AppendLogCategory(){} // RVA: 0x7FFD57508370
        public void AppendTimestamp(){} // RVA: 0x7FFD575084F0
        public void Format(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void AppendFormatted(){} // RVA: 0x7FFD4E0961F0
    }

    public class MessageTemplateHolder : Object
    {
        public object EqualityContract;
        public object LiteralLength;
        public object FormattedCount;
        public object TemplateChunk;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD56FFB2F0
        public void get_EqualityContract(){} // RVA: 0x7FFD57506F30
        public void get_LiteralLength(){} // RVA: 0x7FFD4E38E5C0
        public void get_FormattedCount(){} // RVA: 0x7FFD4E7F5A20
        public void get_TemplateChunk(){} // RVA: 0x7FFD4E3447C0
        public void ToString(){} // RVA: 0x7FFD57506FE0
        public void PrintMembers(){} // RVA: 0x7FFD57507110
        public void op_Inequality(){} // RVA: 0x7FFD57507310
        public void op_Equality(){} // RVA: 0x7FFD57507340
        public void GetHashCode(){} // RVA: 0x7FFD57507360
        public void Equals(){} // RVA: 0x7FFD57507520 | overloaded x2
    }

    public class Timestamp : ValueType
    {
        public object Utc;
        public object Local;

        // ── Methods ──
        public void get_Utc(){} // RVA: 0x7FFD4E6E0590
        public void get_Local(){} // RVA: 0x7FFD57508610
        public void ToString(){} // RVA: 0x7FFD57508710
        public void .ctor(){} // RVA: 0x7FFD575087A0
        public void ToLocalTime(){} // RVA: 0x7FFD57508950
        public void TryFormat(){} // RVA: 0x7FFD57508BA0
        public void FormatDate(){} // RVA: 0x7FFD57509540
        public void FormatTime(){} // RVA: 0x7FFD57509990
        public void FormatTimeMilliseconds(){} // RVA: 0x7FFD57509C30
        public void FormatDateAndTime(){} // RVA: 0x7FFD57509D60
        public void FormatDateAndTimeAndMilliseconds(){} // RVA: 0x7FFD57509E60
        public void AppendWithFillZero1(){} // RVA: 0x7FFD5750A0A0
        public void AppendWithFillZero2(){} // RVA: 0x7FFD5750A180
        public void AppendWithFillZero3(){} // RVA: 0x7FFD5750A260
        public void .cctor(){} // RVA: 0x7FFD5750A340
    }

    public class ZLoggerBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerFile(){} // RVA: 0x7FFD5750A6E0 | overloaded x2
    }

    public class ZLoggerDebugInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5750D3A0
        public void AppendLiteral(){} // RVA: 0x7FFD5750D410
        public void AppendFormatted(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class ZLoggerEntry`1 : Object
    {
        public object ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.NextNode;
        public object LogInfo;

        // ── Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void Create(){} // RVA: 0x7FFD4E078FF0
        public void ToString(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void CreateEntry(){} // RVA: 0x7FFD4E078F40
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7FFD4E099B30
        public void Return(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFD4E078F40
    }

    public class ZLoggerErrorInterpolatedStringHandler : ValueType
    {
        public x ÌÎÌÎÎÍÏÌÌÌÏÏÍÍÏÌÎÏÎÎÎÍÏ;
        public URA.DateTime<gField.?,?> ÏÎÍÍÍÌÍÍÎÏÍÌÏÍÍÌÌÏÏÍÏÍÍ; // 0x8
        public URA.DateTime<string,object> ÌÎÏÏÎÎÎÍÍÎÍÍÎÏÎÏÎÍÍÌÍÎÏ; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5750D490
        public void AppendLiteral(){} // RVA: 0x7FFD5750D410
        public void AppendFormatted(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
    }

    public class ZLoggerExtensions : Object
    {
        // ── Methods ──
        public void ZLog(){} // RVA: 0x7FFD5750A930
        public void ZLogDebug(){} // RVA: 0x7FFD5750ADD0
        public void ZLogWarning(){} // RVA: 0x7FFD5750AE30
        public void ZLogError(){} // RVA: 0x7FFD5750AEF0 | overloaded x2
    }

    public class ZLoggerInterpolatedStringHandler : ValueType
    {
        public object IsLoggerEnabled;

        // ── Methods ──
        public void get_IsLoggerEnabled(){} // RVA: 0x7FFD4FD7DDF0
        public void .ctor(){} // RVA: 0x7FFD5750B030
        public void AppendLiteral(){} // RVA: 0x7FFD5750B1A0
        public void AppendFormatted(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetState(){} // RVA: 0x7FFD5750B240
    }

    public class ZLoggerLogger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5750D500
        public void Log(){} // RVA: 0x7FFD4E2ADC40
        public void BeginScope(){} // RVA: 0x7FFD4E2ADC40
        public void IsEnabled(){} // RVA: 0x7FFD5750D6B0
    }

    public class ZLoggerOptions : Object
    {
        public object InternalErrorLogger;
        public object IncludeScopes;
        public object TimeProvider;
        public object FullMode;
        public object BackgroundBufferCapacity;

        // ── Methods ──
        public void get_InternalErrorLogger(){} // RVA: 0x7FFD4E35C380
        public void set_InternalErrorLogger(){} // RVA: 0x7FFD4E342E30
        public void get_IncludeScopes(){} // RVA: 0x7FFD4E35C4E0
        public void get_TimeProvider(){} // RVA: 0x7FFD4E36F0C0
        public void get_FullMode(){} // RVA: 0x7FFD4E70C4C0
        public void get_BackgroundBufferCapacity(){} // RVA: 0x7FFD4F0A91D0
        public void CreateFormatter(){} // RVA: 0x7FFD53DA2AE0
        public void UseFormatter(){} // RVA: 0x7FFD4FDBB0A0
        public void UsePlainTextFormatter(){} // RVA: 0x7FFD5750D760
        public void DefaultFormatterFactory(){} // RVA: 0x7FFD5750D8E0
        public void .ctor(){} // RVA: 0x7FFD5750D930
    }

    public class ZLoggerWarningInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5750D420
        public void AppendLiteral(){} // RVA: 0x7FFD5750D410
        public void AppendFormatted(){} // RVA: 0x7FFD4E2ADC40
    }

}