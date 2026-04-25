// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger
// Classes: 30
// Methods: 141

namespace ThirdParty.Other.ZLogger
{
    public class AsyncStreamLineMessageWriter : Object
    {
        public byte[] newLine; // 0x10
        public bool crlf; // 0x18
        public byte newLine1; // 0x19
        public byte newLine2; // 0x1A
        public System.IO.Stream stream; // 0x20
        public System.Threading.Channels.Channel`1<ZLogger.IZLoggerEntry> channel; // 0x28
        public System.Threading.Tasks.Task writeLoop; // 0x30
        public ZLogger.ZLoggerOptions options; // 0x38
        public System.Func`2<0x6B2B8CB8,bool> levelFilter; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0E4040 | overloaded x2
        public void Post(){} // RVA: 0x7FFACC0E45D0
        public void PostSlow(){} // RVA: 0x7FFACC0E4710
        public void AppendLine(){} // RVA: 0x7FFACC0E47E0
        public void WriteLoop(){} // RVA: 0x7FFACC0E4900
        public void DisposeAsync(){} // RVA: 0x7FFACC0E4AC0
    }

    public class CustomFormatParser : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,System.ValueTuple`2<string,string>> alternateNameCache;

        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFACC0EB360
        public void .cctor(){} // RVA: 0x7FFACC0EB6A0
    }

    public class IAsyncLogProcessor
    {
        // ── Methods ──
        public void Post(){} // RVA: 0x7FFAC2C70A40
    }

    public class INonReturnableZLoggerEntry
    {
        public object LogInfo;

        // ── Methods ──
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7FFAC2C79B30
    }

    public class IReferenceCountable
    {
        // ── Methods ──
        public void Retain(){} // RVA: 0x7FFAC2C70980
        public void Release(){} // RVA: 0x7FFAC2C70980
    }

    public class IZLoggerAdditionalInfo
    {
        // ── Methods ──
        public void GetAdditionalInfo(){}
    }

    public class IZLoggerEntry
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x7FFAC2C70980
    }

    public class IZLoggerEntryCreatable
    {
        // ── Methods ──
        public void CreateEntry(){} // RVA: 0x7FFAC2C58F40
    }

    public class IZLoggerFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
    }

    public class IZLoggerFormatter
    {
        public object WithLineBreak;

        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0x7FFAC2C59D00
        public void FormatLogEntry(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InterpolatedStringParameter : ValueType
    {
        public System.Type Type; // 0x10
        public string Name; // 0x18
        public int Alignment; // 0x20
        public string Format; // 0x28
        public int BoxOffset; // 0x30
        public object BoxedValue; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0ED230
    }

    public class LogCategory : ValueType
    {
        public byte[] Utf8Span; // 0x10
        public string Name; // 0x18
        public System.Text.Json.JsonEncodedText JsonEncoded; // 0x20

        // ── Methods ──
        public void get_Utf8Span(){} // RVA: 0x7FFACC0E5E20
        public void .ctor(){} // RVA: 0x7FFACC0E5EC0
        public void ToString(){} // RVA: 0x7FFAC4420220
    }

    public class LogInfo : ValueType
    {
        public ZLogger.LogCategory Category; // 0x10
        public ZLogger.Timestamp Timestamp; // 0x30
        public 0x6B2B8CB8 LogLevel; // 0x48
        public Microsoft.Extensions.Logging.EventId EventId; // 0x50
        public System.Exception Exception; // 0x60
        public ZLogger.LogScopeState ScopeState; // 0x68
        public object Context; // 0x70
        public string MemberName; // 0x78
        public string FilePath; // 0x80
        public int LineNumber; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0E5B40
    }

    public class LogScopeState : Object
    {
        public System.Collections.Concurrent.ConcurrentQueue`1<ZLogger.LogScopeState> cache;
        public System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<string,object>> properties; // 0x10
        public short version; // 0x18
        public short snapshotVersion; // 0x1A

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFACC0E6090
        public void Return(){} // RVA: 0x7FFACC0E6260
        public void Clear(){} // RVA: 0x7FFACC0E6340
        public void Snapshot(){} // RVA: 0x7FFACC0E63B0
        public void .ctor(){} // RVA: 0x7FFACC0E6650
        public void .cctor(){} // RVA: 0x7FFACC0E6710
    }

    public class MessageSequence : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<LiteralList,ZLogger.MessageSequence> cache;
        public int literalLength; // 0x10
        public int parametersLength; // 0x14
        public ZLogger.MessageSequenceSegment[] segments; // 0x18

        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7FFACC0EBC20
        public void .ctor(){} // RVA: 0x7FFACC0EC1C0
        public void ToString(){} // RVA: 0x7FFACC0ECAA0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFACC0ECB60
    }

    public class MessageSequenceSegment : ValueType
    {
        public string IsLiteral; // 0x10
        public byte[] Utf8Bytes; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void get_IsLiteral(){} // RVA: 0x7FFAC3BB0800
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
    }

    public class MessageTemplate : ValueType
    {
        public ZLogger.MessageTemplateHolder template; // 0x10
        public System.Buffers.IBufferWriter`1<byte> writer; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void AppendLogLevel(){} // RVA: 0x7FFACC0E7F90
        public void AppendLogCategory(){} // RVA: 0x7FFACC0E8370
        public void AppendTimestamp(){} // RVA: 0x7FFACC0E84F0
        public void Format(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void AppendFormatted(){} // RVA: 0x7FFAC2C761F0
    }

    public class MessageTemplateChunk : ValueType
    {
        public byte[] Literal; // 0x10
        public int Index; // 0x18
        public int Alignment; // 0x1C
        public string Format; // 0x20
        public bool NoAlignmentAndFormat; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0E76A0
        public void get_Literal(){} // RVA: 0x7FFAC3AD9F60
        public void get_Index(){} // RVA: 0x7FFAC49C7500
        public void get_Alignment(){} // RVA: 0x7FFAC49C7520
        public void get_Format(){} // RVA: 0x7FFAC2F3C380
        public void get_NoAlignmentAndFormat(){} // RVA: 0x7FFAC2F3C4E0
        public void ToString(){} // RVA: 0x7FFACC0E7770
        public void PrintMembers(){} // RVA: 0x7FFACC0E78A0
        public void GetHashCode(){} // RVA: 0x7FFACC0E7B80
        public void Equals(){} // RVA: 0x7FFACC0E7DD0 | overloaded x2
    }

    public class MessageTemplateHandler : ValueType
    {
        public int <literalLength>P; // 0x10
        public int <formattedCount>P; // 0x14
        public System.Collections.Generic.List`1<ZLogger.MessageTemplateChunk> templateChunk; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0E6A30
        public void AppendLiteral(){} // RVA: 0x7FFACC0E6B00
        public void AppendFormatted(){} // RVA: 0x7FFACC0E6C70
        public void GetTemplate(){} // RVA: 0x7FFACC0E6DA0
    }

    public class MessageTemplateHolder : Object
    {
        public int EqualityContract; // 0x10
        public int LiteralLength; // 0x14
        public ZLogger.MessageTemplateChunk[] FormattedCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBDB2F0
        public void get_EqualityContract(){} // RVA: 0x7FFACC0E6F30
        public void get_LiteralLength(){} // RVA: 0x7FFAC2F6E5C0
        public void get_FormattedCount(){} // RVA: 0x7FFAC33D5A20
        public void get_TemplateChunk(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFACC0E6FE0
        public void PrintMembers(){} // RVA: 0x7FFACC0E7110
        public void op_Inequality(){} // RVA: 0x7FFACC0E7310
        public void op_Equality(){} // RVA: 0x7FFACC0E7340
        public void GetHashCode(){} // RVA: 0x7FFACC0E7360
        public void Equals(){} // RVA: 0x7FFACC0E7520 | overloaded x2
    }

    public class Timestamp : ValueType
    {
        public System.DateTimeOffset Utc; // 0x10
        public System.TimeProvider Local; // 0x20
        public long MinTicks;
        public long MaxTicks; // 0x8

        // ── Methods ──
        public void get_Utc(){} // RVA: 0x7FFAC32C0590
        public void get_Local(){} // RVA: 0x7FFACC0E8610
        public void ToString(){} // RVA: 0x7FFACC0E8710
        public void .ctor(){} // RVA: 0x7FFACC0E87A0
        public void ToLocalTime(){} // RVA: 0x7FFACC0E8950
        public void TryFormat(){} // RVA: 0x7FFACC0E8BA0
        public void FormatDate(){} // RVA: 0x7FFACC0E9540
        public void FormatTime(){} // RVA: 0x7FFACC0E9990
        public void FormatTimeMilliseconds(){} // RVA: 0x7FFACC0E9C30
        public void FormatDateAndTime(){} // RVA: 0x7FFACC0E9D60
        public void FormatDateAndTimeAndMilliseconds(){} // RVA: 0x7FFACC0E9E60
        public void AppendWithFillZero1(){} // RVA: 0x7FFACC0EA0A0
        public void AppendWithFillZero2(){} // RVA: 0x7FFACC0EA180
        public void AppendWithFillZero3(){} // RVA: 0x7FFACC0EA260
        public void .cctor(){} // RVA: 0x7FFACC0EA340
    }

    public class ZLoggerBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerFile(){} // RVA: 0x7FFACC0EA6E0 | overloaded x2
    }

    public class ZLoggerDebugInterpolatedStringHandler : ValueType
    {
        public ZLogger.ZLoggerInterpolatedStringHandler InnerHandler; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0ED3A0
        public void AppendLiteral(){} // RVA: 0x7FFACC0ED410
        public void AppendFormatted(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class ZLoggerEntry`1 : Object
    {
        public ZLogger.Internal.ObjectPool`1<ZLogger.ZLoggerEntry`1<T>> ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.NextNode;
        public ZLogger.ZLoggerEntry`1<T> LogInfo;
        public ZLogger.LogInfo logInfo;
        public T state;

        // ── Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void Create(){} // RVA: 0x7FFAC2C58FF0
        public void ToString(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void CreateEntry(){} // RVA: 0x7FFAC2C58F40
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7FFAC2C79B30
        public void Return(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7FFAC2C58F40
    }

    public class ZLoggerErrorInterpolatedStringHandler : ValueType
    {
        public ZLogger.ZLoggerInterpolatedStringHandler InnerHandler; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0ED490
        public void AppendLiteral(){} // RVA: 0x7FFACC0ED410
        public void AppendFormatted(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
    }

    public class ZLoggerExtensions : Object
    {
        // ── Methods ──
        public void ZLog(){} // RVA: 0x7FFACC0EA930
        public void ZLogDebug(){} // RVA: 0x7FFACC0EADD0
        public void ZLogWarning(){} // RVA: 0x7FFACC0EAE30
        public void ZLogError(){} // RVA: 0x7FFACC0EAEF0 | overloaded x2
    }

    public class ZLoggerInterpolatedStringHandler : ValueType
    {
        public System.Collections.Generic.List`1<string> IsLoggerEnabled; // 0xFFFF
        public bool <IsLoggerEnabled>k__BackingField; // 0x10
        public int literalLength; // 0x14
        public int parametersLength; // 0x18
        public System.Collections.Generic.List`1<string> literals; // 0x20
        public ZLogger.LogStates.InterpolatedStringLogState state; // 0x28
        public int parameterWritten; // 0x30

        // ── Methods ──
        public void get_IsLoggerEnabled(){} // RVA: 0x7FFAC495DDF0
        public void .ctor(){} // RVA: 0x7FFACC0EB030
        public void AppendLiteral(){} // RVA: 0x7FFACC0EB1A0
        public void AppendFormatted(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetState(){} // RVA: 0x7FFACC0EB240
    }

    public class ZLoggerLogger : Object
    {
        public ZLogger.LogCategory category; // 0x10
        public ZLogger.IAsyncLogProcessor logProcessor; // 0x30
        public System.TimeProvider timeProvider; // 0x38
        public Microsoft.Extensions.Logging.IExternalScopeProvider scopeProvider; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0ED500
        public void Log(){} // RVA: 0x7FFAC2E8DC40
        public void BeginScope(){} // RVA: 0x7FFAC2E8DC40
        public void IsEnabled(){} // RVA: 0x7FFACC0ED6B0
    }

    public class ZLoggerOptions : Object
    {
        public System.Action`1<System.Exception> InternalErrorLogger; // 0x10
        public bool IncludeScopes; // 0x18
        public System.TimeProvider TimeProvider; // 0x20
        public 0x6B2B3148 FullMode; // 0x28
        public int BackgroundBufferCapacity; // 0x2C
        public System.Func`1<ZLogger.IZLoggerFormatter> formatterFactory; // 0x30

        // ── Methods ──
        public void get_InternalErrorLogger(){} // RVA: 0x7FFAC2F3C380
        public void set_InternalErrorLogger(){} // RVA: 0x7FFAC2F22E30
        public void get_IncludeScopes(){} // RVA: 0x7FFAC2F3C4E0
        public void get_TimeProvider(){} // RVA: 0x7FFAC2F4F0C0
        public void get_FullMode(){} // RVA: 0x7FFAC32EC4C0
        public void get_BackgroundBufferCapacity(){} // RVA: 0x7FFAC3C891D0
        public void CreateFormatter(){} // RVA: 0x7FFAC8982AE0
        public void UseFormatter(){} // RVA: 0x7FFAC499B0A0
        public void UsePlainTextFormatter(){} // RVA: 0x7FFACC0ED760
        public void DefaultFormatterFactory(){} // RVA: 0x7FFACC0ED8E0
        public void .ctor(){} // RVA: 0x7FFACC0ED930
    }

    public class ZLoggerWarningInterpolatedStringHandler : ValueType
    {
        public ZLogger.ZLoggerInterpolatedStringHandler InnerHandler; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0ED420
        public void AppendLiteral(){} // RVA: 0x7FFACC0ED410
        public void AppendFormatted(){} // RVA: 0x7FFAC2E8DC40
    }

}