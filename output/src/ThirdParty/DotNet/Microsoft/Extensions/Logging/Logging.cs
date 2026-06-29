// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging
// Classes: 42
// Methods: 242

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging
{
    public class ActivityExtensions : Object
    {
        // ── Methods ──
        public void GetSpanId(){} // RVA: 0x7AD9A2120
        public void GetTraceId(){} // RVA: 0x7AD9A21D0
        public void GetParentId(){} // RVA: 0x7AD9A2280
    }

    public class DebuggerDisplayFormatting : Object
    {
        // ── Methods ──
        public void DebuggerToString(){} // RVA: 0x7AD99B9A0
        public void CalculateEnabledLogLevel(){} // RVA: 0x7AD99BAE0
    }

    public class DefaultLoggerLevelConfigureOptions : ConfigureOptions`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD99CF20
    }

    public class EventId : ValueType
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7AD996340
        public void op_Equality(){} // RVA: 0x7AD9963A0
        public void op_Inequality(){} // RVA: 0x7AD9963B0
        public void .ctor(){} // RVA: 0x7A790A7A0
        public void get_Id(){} // RVA: 0x7A765F070
        public void get_Name(){} // RVA: 0x7A765F080
        public void ToString(){} // RVA: 0x7A7E2D840
        public void Equals(){} // RVA: 0x7A7E2D900
        public void GetHashCode(){} // RVA: 0x7A765F070
    }

    public class FilterLoggingBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddFilter(){} // RVA: 0x7AD99D1B0
        public void ConfigureFilter(){} // RVA: 0x7AD99D1E0
        public void AddRule(){} // RVA: 0x7AD99D260
    }

    public class FormattedLogValues : ValueType
    {
        // ── Methods ──
        public void get_Formatter(){} // RVA: 0x7A765F710
        public void .ctor(){} // RVA: 0x7A7E2D9B0
        public void get_Item(){} // RVA: 0x7A7E2D9C0
        public void get_Count(){} // RVA: 0x7A7E2D9F0
        public void GetEnumerator(){} // RVA: 0x7A7E2DA50
        public void ToString(){} // RVA: 0x7A7E2DA60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E2DA80
        public void .cctor(){} // RVA: 0x7AD996CE0
    }

    public class IExternalScopeProvider
    {
        // ── Methods ──
        public void ForEachScope(){} // RVA: 0x7A8051B10
        public void Push(){} // RVA: 0x7A7E00B20
    }

    public class ILogger
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7A7E1AA70
        public void IsEnabled(){} // RVA: 0x7A7E01F00
        public void BeginScope(){} // RVA: 0x7A8051B10
    }

    public class ILoggerFactory
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7A7E00B20
        public void AddProvider(){} // RVA: 0x7A7E18800
    }

    public class ILoggerProvider
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7A7E00B20
    }

    public class ILoggerProvider[] : Array
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

    public class ILoggingBuilder
    {
        // ── Methods ──
        public void get_Services(){} // RVA: 0x7A7E00680
    }

    public class ISupportExternalScope
    {
        // ── Methods ──
        public void SetScopeProvider(){} // RVA: 0x7A7E18800
    }

    public class LogDefineOptions : Object
    {
        // ── Methods ──
        public void get_SkipEnabledCheck(){} // RVA: 0x7A81A2200
        public void set_SkipEnabledCheck(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class LogValuesFormatter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD999FE0
        public void get_OriginalFormat(){} // RVA: 0x7A81052C0
        public void set_OriginalFormat(){} // RVA: 0x7A81052D0
        public void get_ValueNames(){} // RVA: 0x7A80F2570
        public void FindBraceIndex(){} // RVA: 0x7AD99A690
        public void FindIndexOfAny(){} // RVA: 0x7AD99A740
        public void Format(){} // RVA: 0x7AD99B030
        public void FormatWithOverwrite(){} // RVA: 0x7AD99AAB0
        public void GetValue(){} // RVA: 0x7AD99B160
        public void GetValues(){} // RVA: 0x7AD99B2D0
        public void FormatArgument(){} // RVA: 0x7AD99B590
        public void TryFormatArgumentIfNullOrEnumerable(){} // RVA: 0x7A8051B10
        public void .cctor(){} // RVA: 0x7AD99B610
    }

    public class Logger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_Loggers(){} // RVA: 0x7A80DA7B0
        public void set_Loggers(){} // RVA: 0x7A813E420
        public void get_MessageLoggers(){} // RVA: 0x7A81052C0
        public void set_MessageLoggers(){} // RVA: 0x7A81052D0
        public void get_ScopeLoggers(){} // RVA: 0x7A8105330
        public void set_ScopeLoggers(){} // RVA: 0x7A80D8E80
        public void Log(){} // RVA: 0x7AA523430
        public void IsEnabled(){} // RVA: 0x7AD99D4B0
        public void BeginScope(){} // RVA: 0x7A8051B10
        public void ThrowLoggingError(){} // RVA: 0x7AD99D580
        public void <Log>g__LoggerLog|14_0(){} // RVA: 0x7AA522760
        public void <IsEnabled>g__LoggerIsEnabled|15_0(){} // RVA: 0x7AD99D5E0
    }

    public class LoggerExtensions : Object
    {
        // ── Methods ──
        public void LogDebug(){} // RVA: 0x7AD997310
        public void LogTrace(){} // RVA: 0x7AD997590
        public void LogInformation(){} // RVA: 0x7AD997830
        public void LogWarning(){} // RVA: 0x7AD997AD0
        public void LogError(){} // RVA: 0x7AD997D70
        public void LogCritical(){} // RVA: 0x7AD998010
        public void Log(){} // RVA: 0x7AD998340
        public void BeginScope(){} // RVA: 0x7AD998480
        public void MessageFormatter(){} // RVA: 0x7AD998540
        public void .cctor(){} // RVA: 0x7AD9985B0
    }

    public class LoggerExternalScopeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD998740
        public void ForEachScope(){} // RVA: 0x7A8051B10
        public void Push(){} // RVA: 0x7AD9987E0
        public void <ForEachScope>g__Report|2_0(){} // RVA: 0x7A7E18AA0
    }

    public class LoggerFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD99DF00
        public void Create(){} // RVA: 0x7AD99E630
        public void RefreshFilters(){} // RVA: 0x7AD99EA20
        public void CreateLogger(){} // RVA: 0x7AD99EE40
        public void AddProvider(){} // RVA: 0x7AD99F2D0
        public void AddProviderRegistration(){} // RVA: 0x7AD99F8D0
        public void CreateLoggers(){} // RVA: 0x7AD99FB20
        public void ApplyFilters(){} // RVA: 0x7AD99FCF0
        public void CheckDisposed(){} // RVA: 0x7AD9A02B0
        public void Dispose(){} // RVA: 0x7AD9A02C0
    }

    public class LoggerFactoryExtensions : Object
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7AD998B20
    }

    public class LoggerFactoryOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_ActivityTrackingOptions(){} // RVA: 0x7A8124910
    }

    public class LoggerFactoryScopeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9A0580
        public void ForEachScope(){} // RVA: 0x7A8051B10
        public void GetOrCreateActivityBaggageLogScopeWrapper(){} // RVA: 0x7AD9A0630
        public void Push(){} // RVA: 0x7AD9A0730
        public void <ForEachScope>g__Report|3_0(){} // RVA: 0x7A7E18AA0
    }

    public class LoggerFilterOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9A2330
        public void get_CaptureScopes(){} // RVA: 0x7A81A2200
        public void get_MinLevel(){} // RVA: 0x7A8668BC0
        public void set_MinLevel(){} // RVA: 0x7A8669360
        public void get_Rules(){} // RVA: 0x7A80DA7B0
        public void get_RulesInternal(){} // RVA: 0x7A80DA7B0
    }

    public class LoggerFilterRule : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9A23F0
        public void get_ProviderName(){} // RVA: 0x7A80F2570
        public void get_CategoryName(){} // RVA: 0x7A80DA7B0
        public void get_LogLevel(){} // RVA: 0x7A81052C0
        public void get_Filter(){} // RVA: 0x7A8105330
        public void ToString(){} // RVA: 0x7AD9A2500
    }

    public class LoggerFilterRule[] : Array
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

    public class LoggerInformation : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E2DDC0
        public void get_Logger(){} // RVA: 0x7A765F710
        public void get_Category(){} // RVA: 0x7A765F080
        public void get_ProviderType(){} // RVA: 0x7A7664CF0
        public void get_ExternalScope(){} // RVA: 0x7A7677A60
    }

    public class LoggerInformation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A18F0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2F10
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2508F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E0E0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class LoggerMessage : Object
    {
        // ── Methods ──
        public void DefineScope(){} // RVA: 0x7A7E00BA0
        public void Define(){} // RVA: 0x7A8051B10
        public void CreateLogValuesFormatter(){} // RVA: 0x7AD9990C0
    }

    public class LoggerMessageAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD999EE0
        public void get_EventId(){} // RVA: 0x7A8124910
        public void set_EventId(){} // RVA: 0x7A80DA0C0
        public void get_EventName(){} // RVA: 0x7A80DA7B0
        public void set_EventName(){} // RVA: 0x7A813E420
        public void get_Level(){} // RVA: 0x7A851DB90
        public void set_Level(){} // RVA: 0x7A8738180
        public void get_Message(){} // RVA: 0x7A8105330
        public void set_Message(){} // RVA: 0x7A80D8E80
        public void get_SkipEnabledCheck(){} // RVA: 0x7A80FD690
        public void set_SkipEnabledCheck(){} // RVA: 0x7A80FD6A0
    }

    public class LoggerRuleSelector : Object
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x7AD9A2C40
        public void IsBetter(){} // RVA: 0x7AD9A2F80
    }

    public class Logger`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Microsoft.Extensions.Logging.ILogger.BeginScope(){} // RVA: 0x7A8051B10
        public void Microsoft.Extensions.Logging.ILogger.IsEnabled(){} // RVA: 0x7A7E01F00
        public void Microsoft.Extensions.Logging.ILogger.Log(){} // RVA: 0x7A8051B10
        public void GetCategoryName(){} // RVA: 0x7A7E006B0
        public void DebuggerToString(){} // RVA: 0x7A7E00680
    }

    public class LoggingBuilder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Services(){} // RVA: 0x7A80F2570
    }

    public class MessageLogger : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E2DD60
        public void get_Logger(){} // RVA: 0x7A765F710
        public void get_Category(){} // RVA: 0x7A765F080
        public void get_ProviderTypeFullName(){} // RVA: 0x7A7664CF0
        public void get_MinLevel(){} // RVA: 0x7A767FF40
        public void get_Filter(){} // RVA: 0x7A7677A70
        public void IsEnabled(){} // RVA: 0x7A7E2DD70
    }

    public class MessageLogger[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1D50
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E250
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E31C0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250C50
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E250
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class NullExternalScopeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Instance(){} // RVA: 0x7AD99B700
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.ForEachScope(){} // RVA: 0x7A8051B10
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.Push(){} // RVA: 0x7AD99B760
        public void .cctor(){} // RVA: 0x7AD99B800
    }

    public class NullScope : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AD99B8A0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AD99B900
    }

    public class NullScope : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AD9A3680
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AD9A36E0
    }

    public class ProfilerMarkerDataType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9A33C0
        public void OnChange(){} // RVA: 0x7A82D1450
        public void get_CurrentValue(){} // RVA: 0x7A80F2570
    }

    public class ProviderAliasAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class ProviderAliasUtilities : Object
    {
        // ── Methods ──
        public void GetAlias(){} // RVA: 0x7AD9A3480
    }

    public class ScopeLogger : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void get_Logger(){} // RVA: 0x7A765F710
        public void get_ExternalScopeProvider(){} // RVA: 0x7A765F080
        public void CreateScope(){} // RVA: 0x7A8051B10
    }

    public class ScopeLogger[] : Array
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

}