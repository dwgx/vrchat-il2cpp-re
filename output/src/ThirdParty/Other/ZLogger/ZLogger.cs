// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.ZLogger
// Classes: 35
// Methods: 197

namespace ThirdParty.Other.ZLogger
{
    public class AsyncStreamLineMessageWriter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B194C6A0
        public void Post(){} // RVA: 0x7B194CC30
        public void PostSlow(){} // RVA: 0x7B194CD70
        public void AppendLine(){} // RVA: 0x7B194CE40
        public void WriteLoop(){} // RVA: 0x7B194CF60
        public void DisposeAsync(){} // RVA: 0x7B194D120
    }

    public class CustomFormatParser : Object
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7B19539E0
        public void .cctor(){} // RVA: 0x7B1953D20
    }

    public class IAsyncLogProcessor
    {
        // ── Methods ──
        public void Post(){} // RVA: 0x7A7E18800
    }

    public class INonReturnableZLoggerEntry
    {
        // ── Methods ──
        public void get_LogInfo(){} // RVA: 0x7A7E00490
        public void FormatUtf8(){} // RVA: 0x7A7E18890
    }

    public class IReferenceCountable
    {
        // ── Methods ──
        public void Retain(){} // RVA: 0x7A7E18770
        public void Release(){} // RVA: 0x7A7E18770
    }

    public class IZLoggerAdditionalInfo
    {
        // ── Methods ──
        public void GetAdditionalInfo(){} // RVA: 0x7A7E00490
    }

    public class IZLoggerEntry
    {
        // ── Methods ──
        public void Return(){} // RVA: 0x7A7E18770
    }

    public class IZLoggerEntryCreatable
    {
        // ── Methods ──
        public void CreateEntry(){} // RVA: 0x7A7E00B20
    }

    public class IZLoggerEntry[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IZLoggerFormattable
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7A7E18800
    }

    public class IZLoggerFormatter
    {
        // ── Methods ──
        public void get_WithLineBreak(){} // RVA: 0x7A7E01900
        public void FormatLogEntry(){} // RVA: 0x7A7E18890
    }

    public class InterpolatedStringParameter : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7FCC720
    }

    public class InterpolatedStringParameter[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A2A10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E6C0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E3990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25C8E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E6C0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class LogCategory : ValueType
    {
        // ── Methods ──
        public void get_Utf8Span(){} // RVA: 0x7A7FCBFA0
        public void .ctor(){} // RVA: 0x7A7FCC040
        public void ToString(){} // RVA: 0x7A765F080
    }

    public class LogInfo : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7FCBAD0
    }

    public class LogScopeState : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7B194E6F0
        public void Return(){} // RVA: 0x7B194E8C0
        public void Clear(){} // RVA: 0x7B194E9A0
        public void Snapshot(){} // RVA: 0x7B194EA10
        public void .ctor(){} // RVA: 0x7B194ECB0
        public void .cctor(){} // RVA: 0x7B194ED70
    }

    public class MessageSequence : Object
    {
        // ── Methods ──
        public void GetOrCreate(){} // RVA: 0x7B19542A0
        public void .ctor(){} // RVA: 0x7B1954820
        public void ToString(){} // RVA: 0x7B1955140
        public void .cctor(){} // RVA: 0x7B1955210
    }

    public class MessageSequenceSegment : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void get_IsLiteral(){} // RVA: 0x7A763CB50
        public void ToString(){} // RVA: 0x7A765F710
    }

    public class MessageSequenceSegment[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class MessageTemplate : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void AppendLogLevel(){} // RVA: 0x7B1950600
        public void AppendLogCategory(){} // RVA: 0x7B19509E0
        public void AppendTimestamp(){} // RVA: 0x7B1950B60
        public void Format(){} // RVA: 0x7A77B36E0
        public void AppendFormatted(){} // RVA: 0x7AA53F2B0
    }

    public class MessageTemplateChunk : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7FCC2E0
        public void get_Literal(){} // RVA: 0x7A765F710
        public void get_Index(){} // RVA: 0x7A75FEFA0
        public void get_Alignment(){} // RVA: 0x7A767FBD0
        public void get_Format(){} // RVA: 0x7A7664CF0
        public void get_NoAlignmentAndFormat(){} // RVA: 0x7A7677A60
        public void ToString(){} // RVA: 0x7A7FCC300
        public void PrintMembers(){} // RVA: 0x7A7FCC430
        public void GetHashCode(){} // RVA: 0x7A7FCC440
        public void Equals(){} // RVA: 0x7A7FCC460
    }

    public class MessageTemplateChunk[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D5A60
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2F10
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA282F60
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class MessageTemplateHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7FCC070
        public void AppendLiteral(){} // RVA: 0x7A7FCC080
        public void AppendFormatted(){} // RVA: 0x7A7FCC090
        public void GetTemplate(){} // RVA: 0x7A7FCC0A0
    }

    public class MessageTemplateHolder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14098E0
        public void get_EqualityContract(){} // RVA: 0x7B194F5A0
        public void get_LiteralLength(){} // RVA: 0x7A8124910
        public void get_FormattedCount(){} // RVA: 0x7A8668BC0
        public void get_TemplateChunk(){} // RVA: 0x7A80DA7B0
        public void ToString(){} // RVA: 0x7B194F650
        public void PrintMembers(){} // RVA: 0x7B194F780
        public void op_Inequality(){} // RVA: 0x7B194F980
        public void op_Equality(){} // RVA: 0x7B194F9B0
        public void GetHashCode(){} // RVA: 0x7B194F9D0
        public void Equals(){} // RVA: 0x7B194FB90
    }

    public class Timestamp : ValueType
    {
        // ── Methods ──
        public void get_Utc(){} // RVA: 0x7A7662BE0
        public void get_Local(){} // RVA: 0x7A7FCC4D0
        public void ToString(){} // RVA: 0x7A7FCC500
        public void .ctor(){} // RVA: 0x7A7FCC510
        public void ToLocalTime(){} // RVA: 0x7B1950FC0
        public void TryFormat(){} // RVA: 0x7A7FCC520
        public void FormatDate(){} // RVA: 0x7B1951BB0
        public void FormatTime(){} // RVA: 0x7B1952000
        public void FormatTimeMilliseconds(){} // RVA: 0x7B19522A0
        public void FormatDateAndTime(){} // RVA: 0x7B19523D0
        public void FormatDateAndTimeAndMilliseconds(){} // RVA: 0x7B19524D0
        public void AppendWithFillZero1(){} // RVA: 0x7B1952710
        public void AppendWithFillZero2(){} // RVA: 0x7B19527F0
        public void AppendWithFillZero3(){} // RVA: 0x7B19528D0
        public void .cctor(){} // RVA: 0x7B19529B0
    }

    public class ZLoggerBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddZLoggerFile(){} // RVA: 0x7B1952D60
    }

    public class ZLoggerDebugInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1955A60
        public void AppendLiteral(){} // RVA: 0x7B1955AD0
        public void AppendFormatted(){} // RVA: 0x7A9FB74A0
    }

    public class ZLoggerEntry`1 : Object
    {
        // ── Methods ──
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18890
        public void Create(){} // RVA: 0x7A7E00C10
        public void ToString(){} // RVA: 0x7A7E18800
        public void CreateEntry(){} // RVA: 0x7A7E00B20
        public void get_LogInfo(){} // RVA: 0x7A7E00490
        public void FormatUtf8(){} // RVA: 0x7A7E18890
        public void Return(){} // RVA: 0x7A7E18770
        public void .cctor(){} // RVA: 0x7A7E187D0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7A7E00B20
    }

    public class ZLoggerEntry`1 : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7ACB96D20
        public void ZLogger.Internal.IObjectPoolNode<ZLogger.ZLoggerEntry<TState>>.get_NextNode(){} // RVA: 0x7ABBF1F90
        public void .ctor(){} // RVA: 0x7ACB96C00
        public void ToString(){} // RVA: 0x7ACB97160
        public void CreateEntry(){} // RVA: 0x7ACB970F0
        public void get_LogInfo(){} // RVA: 0x7ACB95760
        public void FormatUtf8(){} // RVA: 0x7ACB957B0
        public void Return(){} // RVA: 0x7ACB971D0
        public void .cctor(){} // RVA: 0x7ACB95AB0
        public void ZLogger.IZLoggerEntryCreatable.CreateEntry(){} // RVA: 0x7ACB970F0
    }

    public class ZLoggerErrorInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1955B50
        public void AppendLiteral(){} // RVA: 0x7B1955AD0
        public void AppendFormatted(){} // RVA: 0x7A9FB72B0
    }

    public class ZLoggerExtensions : Object
    {
        // ── Methods ──
        public void ZLog(){} // RVA: 0x7B1952FB0
        public void ZLogDebug(){} // RVA: 0x7B1953450
        public void ZLogWarning(){} // RVA: 0x7B19534B0
        public void ZLogError(){} // RVA: 0x7B1953570
    }

    public class ZLoggerInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void get_IsLoggerEnabled(){} // RVA: 0x7A9C44D10
        public void .ctor(){} // RVA: 0x7B19536B0
        public void AppendLiteral(){} // RVA: 0x7B1953820
        public void AppendFormatted(){} // RVA: 0x7A9FB93F0
        public void GetState(){} // RVA: 0x7B19538C0
    }

    public class ZLoggerLogger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1955BC0
        public void Log(){} // RVA: 0x7A9FBCBC0
        public void BeginScope(){} // RVA: 0x7A8051B10
        public void IsEnabled(){} // RVA: 0x7B1955D70
    }

    public class ZLoggerOptions : Object
    {
        // ── Methods ──
        public void get_InternalErrorLogger(){} // RVA: 0x7A80F2570
        public void set_InternalErrorLogger(){} // RVA: 0x7A80D8E20
        public void get_IncludeScopes(){} // RVA: 0x7A80F26D0
        public void get_TimeProvider(){} // RVA: 0x7A81052C0
        public void get_FullMode(){} // RVA: 0x7A854FDE0
        public void get_BackgroundBufferCapacity(){} // RVA: 0x7A8F9ACE0
        public void CreateFormatter(){} // RVA: 0x7ADFD8110
        public void UseFormatter(){} // RVA: 0x7A9C81DF0
        public void UsePlainTextFormatter(){} // RVA: 0x7B1955E20
        public void DefaultFormatterFactory(){} // RVA: 0x7B1955FA0
        public void .ctor(){} // RVA: 0x7B1955FF0
    }

    public class ZLoggerWarningInterpolatedStringHandler : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1955AE0
        public void AppendLiteral(){} // RVA: 0x7B1955AD0
        public void AppendFormatted(){} // RVA: 0x7A9FB7070
    }

}