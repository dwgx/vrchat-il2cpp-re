// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger
// Classes: 31
// Methods: 151

namespace ThirdParty.Other.ZLogger
{
    public class AsyncStreamLineMessageWriter : Object
    {
        public object newLine1; // 0x35066BB0
        public object channel; // 0x35066BB0
        public object levelFilter; // 0x35066BB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1afff50
        public void .ctor(){} // RVA: 0x7ffab1afff50
        public void Post(){} // RVA: 0x7ffab1b004e0
        public void PostSlow(){} // RVA: 0x7ffab1b00620
        public void AppendLine(){} // RVA: 0x7ffab1b006f0
        public void WriteLoop(){} // RVA: 0x7ffab1b00810
        public void DisposeAsync(){} // RVA: 0x7ffab1b009d0
    }

    public class CustomFormatParser : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffab1b075b0
        // ── Binary Analysis Named ──
        public void GetOrAdd(){} // RVA: 0x7ffab1b07270
    }

    public class IAsyncLogProcessor
    {
        // ── Original Methods ──
        public void Post(){} // RVA: 0x7ffaa8660d80
    }

    public class INonReturnableZLoggerEntry
    {
        // ── Original Methods ──
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7ffaa8669e70
    }

    public class IReferenceCountable
    {
        // ── Original Methods ──
        public void Retain(){} // RVA: 0x7ffaa8660cc0
        public void Release(){} // RVA: 0x7ffaa8660cc0
    }

    public class IZLoggerAdditionalInfo
    {
        // ── Binary Analysis Named ──
        public void GetAdditionalInfo(){}
    }

    public class IZLoggerEntry
    {
        // ── Original Methods ──
        public void Return(){} // RVA: 0x7ffaa8660cc0
    }

    public class IZLoggerEntryCreatable
    {
        // ── Original Methods ──
        public void CreateEntry(){} // RVA: 0x7ffaa8649280
    }

    public class IZLoggerFormattable
    {
        // ── Original Methods ──
        public void ToString(){} // RVA: 0x7ffaa8660d80
        public void ToString(){} // RVA: 0x7ffaa8660d80
    }

    public class IZLoggerFormatter
    {
        // ── Original Methods ──
        public void get_WithLineBreak(){} // RVA: 0x7ffaa864a040
        public void FormatLogEntry(){} // RVA: 0x7ffaa887e5c0
    }

    public class InterpolatedStringParameter : ValueType
    {
        public object Alignment; // 0x35E5A320
        public object BoxedValue; // 0x35E5A320
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b09140
    }

    public class LogCategory : ValueType
    {
        public object JsonEncoded; // 0x35DF2C30

        // ── Original Methods ──
        public void get_Utf8Span(){} // RVA: 0x7ffab1b01d30
        public void .ctor(){} // RVA: 0x7ffab1b01dd0
        public void ToString(){} // RVA: 0x7ffaa9e47540
    }

    public class LogInfo : ValueType
    {
        public object LogLevel; // 0x31531BE0
        public object ScopeState; // 0x31531BE0
        public object FilePath; // 0x31531BE0
        public object timeProvider; // 0x35E90930
        public object _id; // 0x312288B0, was: <Id>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b01a50
    }

    public class LogScopeState : Object
    {
        public object version; // 0x35E90630

        // ── Original Methods ──
        public void Create(){} // RVA: 0x7ffab1b01fa0
        public void Return(){} // RVA: 0x7ffab1b02170
        public void Clear(){} // RVA: 0x7ffab1b02250
        public void Snapshot(){} // RVA: 0x7ffab1b022c0
        public void .ctor(){} // RVA: 0x7ffab1b02560
        public void .cctor(){} // RVA: 0x7ffab1b02620
    }

    public class MessageSequence : Object
    {
        public object parametersLength; // 0x35E5AFD0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b080d0
        public void ToString(){} // RVA: 0x7ffab1b089b0
        public void ToString(){} // RVA: 0x7ffab1b089b0
        public void ToString(){} // RVA: 0x7ffab1b089b0
        public void .cctor(){} // RVA: 0x7ffab1b08a70
        // ── Binary Analysis Named ──
        public void GetOrCreate(){} // RVA: 0x7ffab1b07b30
    }

    public class MessageSequenceSegment : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9bb9250
        public void get_IsLiteral(){} // RVA: 0x7ffaa95e1360
        public void ToString(){} // RVA: 0x7ffaa950bda0
    }

    public class MessageTemplate : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9bb9250
        public void AppendLogLevel(){} // RVA: 0x7ffab1b03ea0
        public void AppendLogCategory(){} // RVA: 0x7ffab1b04280
        public void AppendTimestamp(){} // RVA: 0x7ffab1b04400
        public void Format(){} // RVA: 0x7ffaa887e5c0
        public void Format(){} // RVA: 0x7ffaa887e5c0
        public void AppendFormatted(){} // RVA: 0x7ffaa8666530
    }

    public class MessageTemplateChunk : ValueType
    {
        public object _alignment; // 0x34F3B280, was: <Alignment>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b035b0
        public void get_Literal(){} // RVA: 0x7ffaa950bda0
        public void get_Index(){} // RVA: 0x7ffaaa3cef80
        public void get_Alignment(){} // RVA: 0x7ffaaa3cefa0
        public void get_Format(){} // RVA: 0x7ffaa894d380
        public void get_NoAlignmentAndFormat(){} // RVA: 0x7ffaa894d4e0
        public void ToString(){} // RVA: 0x7ffab1b03680
        public void PrintMembers(){} // RVA: 0x7ffab1b037b0
        public void Equals(){} // RVA: 0x7ffab1b03ce0
        public void Equals(){} // RVA: 0x7ffab1b03ce0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffab1b03a90
    }

    public class MessageTemplateHandler : ValueType
    {
        public object templateChunk; // 0x34F3AA90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b02940
        public void AppendLiteral(){} // RVA: 0x7ffab1b02a10
        public void AppendFormatted(){} // RVA: 0x7ffab1b02b80
        // ── Binary Analysis Named ──
        public void GetTemplate(){} // RVA: 0x7ffab1b02cb0
    }

    public class MessageTemplateHolder : Object
    {
        public object _templateChunk; // 0x350668A0, was: <TemplateChunk>k__BackingField
        public object EqualityContract; // 0x17000004

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab15f6fd0
        public void get_EqualityContract(){} // RVA: 0x7ffab1b02e40
        public void get_LiteralLength(){} // RVA: 0x7ffaa897f5c0
        public void get_FormattedCount(){} // RVA: 0x7ffaa8e046c0
        public void get_TemplateChunk(){} // RVA: 0x7ffaa89357c0
        public void ToString(){} // RVA: 0x7ffab1b02ef0
        public void PrintMembers(){} // RVA: 0x7ffab1b03020
        public void op_Inequality(){} // RVA: 0x7ffab1b03220
        public void op_Equality(){} // RVA: 0x7ffab1b03250
        public void Equals(){} // RVA: 0x7ffab1b03430
        public void Equals(){} // RVA: 0x7ffab1b03430
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffab1b03270
    }

    public class Timestamp : ValueType
    {
        public object MinTicks; // 0x35E90930
        public object _name; // 0x312288B0, was: <Name>k__BackingField

        // ── Original Methods ──
        public void get_Utc(){} // RVA: 0x7ffaa8ce3e60
        public void get_Local(){} // RVA: 0x7ffab1b04520
        public void ToString(){} // RVA: 0x7ffab1b04620
        public void .ctor(){} // RVA: 0x7ffab1b046b0
        public void ToLocalTime(){} // RVA: 0x7ffab1b04860
        public void TryFormat(){} // RVA: 0x7ffab1b04ab0
        public void FormatDate(){} // RVA: 0x7ffab1b05450
        public void FormatTime(){} // RVA: 0x7ffab1b058a0
        public void FormatTimeMilliseconds(){} // RVA: 0x7ffab1b05b40
        public void FormatDateAndTime(){} // RVA: 0x7ffab1b05c70
        public void FormatDateAndTimeAndMilliseconds(){} // RVA: 0x7ffab1b05d70
        public void AppendWithFillZero1(){} // RVA: 0x7ffab1b05fb0
        public void AppendWithFillZero2(){} // RVA: 0x7ffab1b06090
        public void AppendWithFillZero3(){} // RVA: 0x7ffab1b06170
        public void .cctor(){} // RVA: 0x7ffab1b06250
    }

    public class ZLoggerBuilderExtensions : Object
    {
        // ── Original Methods ──
        public void AddZLoggerFile(){} // RVA: 0x7ffab1b065f0
        public void AddZLoggerFile(){} // RVA: 0x7ffab1b065f0
    }

    public class ZLoggerDebugInterpolatedStringHandler : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b092b0
        public void AppendLiteral(){} // RVA: 0x7ffab1b09320
        public void AppendFormatted(){} // RVA: 0x7ffaa887e5c0
    }

    public class ZLoggerEntry`1 : Object
    {
        public object logInfo; // 0x315319F0

        // ── Original Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8669e70
        public void Create(){} // RVA: 0x7ffaa8649330
        public void ToString(){} // RVA: 0x7ffaa8660d80
        public void CreateEntry(){} // RVA: 0x7ffaa8649280
        public void ToString(){} // RVA: 0x7ffaa8660d80
        public void get_LogInfo(){}
        public void FormatUtf8(){} // RVA: 0x7ffaa8669e70
        public void Return(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7ffaa8649280
    }

    public class ZLoggerEntry`1 : Object
    {
        public object logInfo; // 0x35E848A0
        public object zp; // 0x120001

        // ── Original Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7ffaac125af0
        public void .ctor(){} // RVA: 0x7ffaacfb4a60
        public void Create(){} // RVA: 0x7ffaacfb4b80
        public void ToString(){} // RVA: 0x7ffaacfb4fb0
        public void CreateEntry(){} // RVA: 0x7ffaacfb4f40
        public void ToString(){} // RVA: 0x7ffaacfb4fb0
        public void get_LogInfo(){} // RVA: 0x7ffaacfb35d0
        public void FormatUtf8(){} // RVA: 0x7ffaacfb3620
        public void Return(){} // RVA: 0x7ffaacfb5020
        public void .cctor(){} // RVA: 0x7ffaacfb3930
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7ffaacfb4f40
    }

    public class ZLoggerErrorInterpolatedStringHandler : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b093a0
        public void AppendLiteral(){} // RVA: 0x7ffab1b09320
        public void AppendFormatted(){} // RVA: 0x7ffaa887e5c0
        public void AppendFormatted(){} // RVA: 0x7ffaa887e5c0
        public void AppendFormatted(){} // RVA: 0x7ffaa887e5c0
    }

    public class ZLoggerExtensions : Object
    {
        // ── Original Methods ──
        public void ZLog(){} // RVA: 0x7ffab1b06840
        public void ZLogDebug(){} // RVA: 0x7ffab1b06ce0
        public void ZLogWarning(){} // RVA: 0x7ffab1b06d40
        public void ZLogError(){} // RVA: 0x7ffab1b06e00
        public void ZLogError(){} // RVA: 0x7ffab1b06e00
    }

    public class ZLoggerInterpolatedStringHandler : ValueType
    {
        public object literalLength; // 0x319897F0
        public object state; // 0x319897F0

        // ── Original Methods ──
        public void get_IsLoggerEnabled(){} // RVA: 0x7ffaaa365870
        public void .ctor(){} // RVA: 0x7ffab1b06f40
        public void AppendLiteral(){} // RVA: 0x7ffab1b070b0
        public void AppendFormatted(){} // RVA: 0x7ffaa887e5c0
        public void AppendFormatted(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetState(){} // RVA: 0x7ffab1b07150
    }

    public class ZLoggerLogger : Object
    {
        public object timeProvider; // 0x31989970
        public object Name; // 0x35DF2C30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b09410
        public void Log(){} // RVA: 0x7ffaa887e5c0
        public void IsEnabled(){} // RVA: 0x7ffab1b095c0
        // ── Binary Analysis Named ──
        public void BeginScope(){} // RVA: 0x7ffaa887e5c0
    }

    public class ZLoggerOptions : Object
    {
        public object _timeProvider; // 0x350656F0, was: <TimeProvider>k__BackingField
        public object formatterFactory; // 0x350656F0
        public object InternalErrorLogger; // 0x17000014
        public object IncludeScopes; // 0x17000015

        // ── Original Methods ──
        public void get_InternalErrorLogger(){} // RVA: 0x7ffaa894d380
        public void set_InternalErrorLogger(){} // RVA: 0x7ffaa8933e30
        public void get_IncludeScopes(){} // RVA: 0x7ffaa894d4e0
        public void get_TimeProvider(){} // RVA: 0x7ffaa89600c0
        public void get_FullMode(){} // RVA: 0x7ffaa8d14570
        public void get_BackgroundBufferCapacity(){} // RVA: 0x7ffaa96cc980
        public void CreateFormatter(){} // RVA: 0x7ffaae3a3cf0
        public void UseFormatter(){} // RVA: 0x7ffaaa3a2b20
        public void UsePlainTextFormatter(){} // RVA: 0x7ffab1b09670
        public void DefaultFormatterFactory(){} // RVA: 0x7ffab1b097f0
        public void .ctor(){} // RVA: 0x7ffab1b09840
    }

    public class ZLoggerWarningInterpolatedStringHandler : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1b09330
        public void AppendLiteral(){} // RVA: 0x7ffab1b09320
        public void AppendFormatted(){} // RVA: 0x7ffaa887e5c0
    }

}