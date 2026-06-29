// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger
// Classes: 35
// Methods: 198

namespace ThirdParty.Other.ZLogger
{
    public class AsyncStreamLineMessageWriter : Object
    {
        public object newLine;
        public object crlf;
        public object newLine1;
        public object newLine2;
        public object stream;
        public object channel;
        public object writeLoop;
        public object options;
        public object levelFilter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7B8AA0
        public void Post(){} // RVA: 0xA7B9030
        public void PostSlow(){} // RVA: 0xA7B9170
        public void AppendLine(){} // RVA: 0xA7B9240
        public void WriteLoop(){} // RVA: 0xA7B9360
        public void DisposeAsync(){} // RVA: 0xA7B9520
    }

    public class CustomFormatParser : Object
    {
        public object alternateNameCache;

        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0xA7BFD80
        public void .cctor(){} // RVA: 0xA7C00C0
    }

    public class IAsyncLogProcessor
    {
        // ── Methods ──
        public void Post(){} // RVA: 0x894320
    }

    public class INonReturnableZLoggerEntry
    {
        // ── Methods ──
        public void get_LogInfo(){} // RVA: 0x87BEB0
        public void FormatUtf8(){} // RVA: 0x8943B0
    }

    public class IReferenceCountable
    {
        // ── Methods ──
        public void Retain(){} // RVA: 0x894290
        public void Release(){} // RVA: 0x894290
    }

    public class IZLoggerAdditionalInfo
    {
        // ── Methods ──
        public void GetAdditionalInfo(){} // RVA: 0x87BEB0
    }

    public class IZLoggerEntry
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x894290
    }

    public class IZLoggerEntryCreatable
    {
        // ── Methods ──
        public void CreateEntry(){} // RVA: 0x87C540
    }

    public class IZLoggerEntry[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IZLoggerFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x894320
    }

    public class IZLoggerFormatter
    {
        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0x87D280
        public void FormatLogEntry(){} // RVA: 0x8943B0
    }

    public class InterpolatedStringParameter : ValueType
    {
        public object Type;
        public object Name;
        public object Alignment;
        public object Format;
        public object BoxOffset;
        public object BoxedValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7B430
    }

    public class InterpolatedStringParameter[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F710
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AF90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4D90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E355B0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AF90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LogCategory : ValueType
    {
        public object utf8;
        public object Name;
        public object JsonEncoded;

        // ── Methods ──
        public void get_Utf8Span(){} // RVA: 0xA7AA80
        public void .ctor(){} // RVA: 0xA7AB20
        public void ToString(){} // RVA: 0x77ED0
    }

    public class LogInfo : ValueType
    {
        public object Category;
        public object Timestamp;
        public object LogLevel;
        public object EventId;
        public object Exception;
        public object ScopeState;
        public object Context;
        public object MemberName;
        public object FilePath;
        public object LineNumber;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7A5F0
    }

    public class LogScopeState : Object
    {
        public object cache;
        public object properties;
        public object version;
        public object snapshotVersion;

        // ── Methods ──
        public void Create(){} // RVA: 0xA7BAAF0
        public void Return(){} // RVA: 0xA7BACC0
        public void Clear(){} // RVA: 0xA7BADA0
        public void Snapshot(){} // RVA: 0xA7BAE10
        public void .ctor(){} // RVA: 0xA7BB0B0
        public void .cctor(){} // RVA: 0xA7BB170
    }

    public class MessageSequence : Object
    {
        public object cache;
        public object literalLength;
        public object parametersLength;
        public object segments;

        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0xA7C0640
        public void .ctor(){} // RVA: 0xA7C0BF0
        public void ToString(){} // RVA: 0xA7C14E0
        public void .cctor(){} // RVA: 0xA7C15B0
    }

    public class MessageSequenceSegment : ValueType
    {
        public object Literal;
        public object Utf8Bytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void get_IsLiteral(){} // RVA: 0x54A60
        public void ToString(){} // RVA: 0x77900
    }

    public class MessageSequenceSegment[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DF60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E342F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MessageTemplate : ValueType
    {
        public object template;
        public object writer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void AppendLogLevel(){} // RVA: 0xA7BC9A0
        public void AppendLogCategory(){} // RVA: 0xA7BCD80
        public void AppendTimestamp(){} // RVA: 0xA7BCF00
        public void Format(){} // RVA: 0x1FE100
        public void AppendFormatted(){} // RVA: 0x31680E0
    }

    public class MessageTemplateChunk : ValueType
    {
        public object _literal;
        public object _index;
        public object _alignment;
        public object _format;
        public object _noAlignmentAndFormat;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7AE40
        public void get_Literal(){} // RVA: 0x77900
        public void get_Index(){} // RVA: 0x14790
        public void get_Alignment(){} // RVA: 0x92DE0
        public void get_Format(){} // RVA: 0x7E450
        public void get_NoAlignmentAndFormat(){} // RVA: 0x8C6E0
        public void ToString(){} // RVA: 0xA7AE60
        public void PrintMembers(){} // RVA: 0xA7AF90
        public void GetHashCode(){} // RVA: 0xA7AFA0
        public void Equals(){} // RVA: 0xA7AFC0
    }

    public class MessageTemplateChunk[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB4390
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6EBF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MessageTemplateHandler : ValueType
    {
        public object <literalLength>P;
        public object <formattedCount>P;
        public object templateChunk;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7ABF0
        public void AppendLiteral(){} // RVA: 0xA7AC00
        public void AppendFormatted(){} // RVA: 0xA7AC10
        public void GetTemplate(){} // RVA: 0xA7AC20
    }

    public class MessageTemplateHolder : Object
    {
        public object _literalLength;
        public object _formattedCount;
        public object _templateChunk;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA274EC0
        public void get_EqualityContract(){} // RVA: 0xA7BB9A0
        public void get_LiteralLength(){} // RVA: 0xB8F8F0
        public void get_FormattedCount(){} // RVA: 0x116A650
        public void get_TemplateChunk(){} // RVA: 0xB465B0
        public void ToString(){} // RVA: 0xA7BBA20
        public void PrintMembers(){} // RVA: 0xA7BBB50
        public void op_Inequality(){} // RVA: 0xA7BBD50
        public void op_Equality(){} // RVA: 0xA7BBD80
        public void GetHashCode(){} // RVA: 0xA7BBDA0
        public void Equals(){} // RVA: 0xA7BBF60
    }

    public class Timestamp : ValueType
    {
        public object utcNow;
        public object timeProvider;
        public object MinTicks;
        public object MaxTicks;

        // ── Methods ──
        public void get_Utc(){} // RVA: 0x7BF80
        public void get_Local(){} // RVA: 0xA7B170
        public void ToString(){} // RVA: 0xA7B1A0
        public void .ctor(){} // RVA: 0xA7B1B0
        public void ToLocalTime(){} // RVA: 0xA7BD360
        public void TryFormat(){} // RVA: 0xA7B1C0
        public void FormatDate(){} // RVA: 0xA7BDF50
        public void FormatTime(){} // RVA: 0xA7BE3A0
        public void FormatTimeMilliseconds(){} // RVA: 0xA7BE640
        public void FormatDateAndTime(){} // RVA: 0xA7BE770
        public void FormatDateAndTimeAndMilliseconds(){} // RVA: 0xA7BE870
        public void AppendWithFillZero1(){} // RVA: 0xA7BEAB0
        public void AppendWithFillZero2(){} // RVA: 0xA7BEB90
        public void AppendWithFillZero3(){} // RVA: 0xA7BEC70
        public void .cctor(){} // RVA: 0xA7BED50
    }

    public class ZLoggerBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerFile(){} // RVA: 0xA7BF100
    }

    public class ZLoggerDebugInterpolatedStringHandler : ValueType
    {
        public object InnerHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7C1EE0
        public void AppendLiteral(){} // RVA: 0xA7C1F50
        public void AppendFormatted(){} // RVA: 0x2B8ABB0
    }

    public class ZLoggerEntry`1 : Object
    {
        public object cache;
        public object next;
        public object logInfo;
        public object state;

        // ── Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x8943B0
        public void Create(){} // RVA: 0x87C630
        public void ToString(){} // RVA: 0x894320
        public void CreateEntry(){} // RVA: 0x87C540
        public void get_LogInfo(){} // RVA: 0x87BEB0
        public void FormatUtf8(){} // RVA: 0x8943B0
        public void Return(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x87C540
    }

    public class ZLoggerEntry`1 : Object
    {
        public object cache;
        public object next;
        public object logInfo;
        public object state;

        // ── Methods ──
        public void V(){} // RVA: 0xCF190B8
        public void Create(){} // RVA: 0x586BAA0
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x4865E00
        public void .ctor(){} // RVA: 0x586B980
        public void ToString(){} // RVA: 0x586BEE0
        public void CreateEntry(){} // RVA: 0x586BE70
        public void get_LogInfo(){} // RVA: 0x586A4E0
        public void FormatUtf8(){} // RVA: 0x586A530
        public void Return(){} // RVA: 0x586BF50
        public void .cctor(){} // RVA: 0x586A830
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x586BE70
    }

    public class ZLoggerErrorInterpolatedStringHandler : ValueType
    {
        public object InnerHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7C1FD0
        public void AppendLiteral(){} // RVA: 0xA7C1F50
        public void AppendFormatted(){} // RVA: 0x2B8ABB0
    }

    public class ZLoggerExtensions : Object
    {
        // ── Methods ──
        public void ZLog(){} // RVA: 0xA7BF350
        public void ZLogDebug(){} // RVA: 0xA7BF7F0
        public void ZLogWarning(){} // RVA: 0xA7BF850
        public void ZLogError(){} // RVA: 0xA7BF910
    }

    public class ZLoggerInterpolatedStringHandler : ValueType
    {
        public object literalPool;
        public object _isLoggerEnabled;
        public object literalLength;
        public object parametersLength;
        public object literals;
        public object state;
        public object parameterWritten;

        // ── Methods ──
        public void get_IsLoggerEnabled(){} // RVA: 0x26C2580
        public void .ctor(){} // RVA: 0xA7BFA50
        public void AppendLiteral(){} // RVA: 0xA7BFBC0
        public void AppendFormatted(){} // RVA: 0x2B8CE20
        public void GetState(){} // RVA: 0xA7BFC60
    }

    public class ZLoggerLogger : Object
    {
        public object category;
        public object logProcessor;
        public object timeProvider;
        public object scopeProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7C2040
        public void Log(){} // RVA: 0x2B90090
        public void BeginScope(){} // RVA: 0xA94080
        public void IsEnabled(){} // RVA: 0xA7C21F0
    }

    public class ZLoggerOptions : Object
    {
        public object _internalErrorLogger;
        public object _includeScopes;
        public object _timeProvider;
        public object _fullMode;
        public object _backgroundBufferCapacity;
        public object formatterFactory;

        // ── Methods ──
        public void get_InternalErrorLogger(){} // RVA: 0xB5DBF0
        public void set_InternalErrorLogger(){} // RVA: 0xB44D60
        public void get_IncludeScopes(){} // RVA: 0xB5DD50
        public void get_TimeProvider(){} // RVA: 0xB700F0
        public void get_FullMode(){} // RVA: 0x1065D50
        public void get_BackgroundBufferCapacity(){} // RVA: 0x1AE5AC0
        public void CreateFormatter(){} // RVA: 0x6C5A400
        public void UseFormatter(){} // RVA: 0x26FEDF0
        public void UsePlainTextFormatter(){} // RVA: 0xA7C22A0
        public void DefaultFormatterFactory(){} // RVA: 0xA7C2420
        public void .ctor(){} // RVA: 0xA7C2470
    }

    public class ZLoggerWarningInterpolatedStringHandler : ValueType
    {
        public object InnerHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA7C1F60
        public void AppendLiteral(){} // RVA: 0xA7C1F50
        public void AppendFormatted(){} // RVA: 0x2B8ABB0
    }

}