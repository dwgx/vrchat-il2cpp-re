// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging
// Classes: 41
// Methods: 223

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging
{
    public class ActivityExtensions
    {
        // ── Methods ──
        public void GetSpanId(){} // RVA: 0x7FFAF86644D0
        public void GetTraceId(){} // RVA: 0x7FFAF8664580
        public void GetParentId(){} // RVA: 0x7FFAF8664630
    }

    public class DebuggerDisplayFormatting
    {
        // ── Methods ──
        public void DebuggerToString(){} // RVA: 0x7FFAF865DCD0
        public void CalculateEnabledLogLevel(){} // RVA: 0x7FFAF865DE10
    }

    public class DefaultLoggerLevelConfigureOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF865F230
    }

    public class EventId
    {
        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAF8658870
        public void op_Equality(){} // RVA: 0x7FFAF86588D0
        public void op_Inequality(){} // RVA: 0x7FFAF86588E0
        public void .ctor(){} // RVA: 0x7FFAF6276C70
        public void get_Id(){} // RVA: 0x7FFAF44189B0
        public void get_Name(){} // RVA: 0x7FFAF44189C0
        public void ToString(){} // RVA: 0x7FFAF86588F0
        public void Equals(){} // RVA: 0x7FFAF86589A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
    }

    public class FilterLoggingBuilderExtensions
    {
        // ── Methods ──
        public void AddFilter(){} // RVA: 0x7FFAF865F4C0 | overloaded x2
        public void ConfigureFilter(){} // RVA: 0x7FFAF865F4F0
        public void AddRule(){} // RVA: 0x7FFAF865F570
    }

    public class FormattedLogValues
    {
        // ── Methods ──
        public void get_Formatter(){} // RVA: 0x7FFAF4584690
        public void .ctor(){} // RVA: 0x7FFAF8658A30
        public void get_Item(){} // RVA: 0x7FFAF8658DC0
        public void get_Count(){} // RVA: 0x7FFAF8659090
        public void GetEnumerator(){} // RVA: 0x7FFAF86590F0
        public void ToString(){} // RVA: 0x7FFAF86591A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF86591C0
        public void .cctor(){} // RVA: 0x7FFAF8659210
    }

    public class IExternalScopeProvider
    {
        // ── Methods ──
        public void ForEachScope(){} // RVA: 0x7FFAF2D33FA0
        public void Push(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ILogger
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFAF2D33FA0
        public void IsEnabled(){} // RVA: 0x7FFAF2ABE1F0
        public void BeginScope(){} // RVA: 0x7FFAF2D33FA0
    }

    public class ILoggerFactory
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFAF2ABCE10
        public void AddProvider(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ILoggerProvider
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ILogger`1
    {
    }

    public class ILogger`1
    {
    }

    public class ILogger`1
    {
    }

    public class ILogger`1
    {
    }

    public class ILoggingBuilder
    {
        // ── Methods ──
        public void get_Services(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ISupportExternalScope
    {
        // ── Methods ──
        public void SetScopeProvider(){} // RVA: 0x7FFAF2AD4B10
    }

    public class LogDefineOptions
    {
        // ── Methods ──
        public void get_SkipEnabledCheck(){} // RVA: 0x7FFAF2E575E0
        public void set_SkipEnabledCheck(){} // RVA: 0x7FFAF2E575F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class LogValuesFormatter
    {
        public object Loggers;
        public object MessageLoggers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF865C390
        public void get_OriginalFormat(){} // RVA: 0x7FFAF2DBB0C0
        public void set_OriginalFormat(){} // RVA: 0x7FFAF2DBB0D0
        public void get_ValueNames(){} // RVA: 0x7FFAF2DA8380
        public void FindBraceIndex(){} // RVA: 0x7FFAF865CA30
        public void FindIndexOfAny(){} // RVA: 0x7FFAF865CAE0
        public void Format(){} // RVA: 0x7FFAF865D390 | overloaded x5
        public void FormatWithOverwrite(){} // RVA: 0x7FFAF865CE30
        public void GetValue(){} // RVA: 0x7FFAF865D4C0
        public void GetValues(){} // RVA: 0x7FFAF865D630
        public void FormatArgument(){} // RVA: 0x7FFAF865D8C0
        public void TryFormatArgumentIfNullOrEnumerable(){} // RVA: 0x7FFAF2D33FA0
        public void .cctor(){} // RVA: 0x7FFAF865D940
    }

    public class Logger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_Loggers(){} // RVA: 0x7FFAF2D907C0
        public void set_Loggers(){} // RVA: 0x7FFAF2DF3E80
        public void get_MessageLoggers(){} // RVA: 0x7FFAF2DBB0C0
        public void set_MessageLoggers(){} // RVA: 0x7FFAF2DBB0D0
        public void get_ScopeLoggers(){} // RVA: 0x7FFAF2DBB130
        public void set_ScopeLoggers(){} // RVA: 0x7FFAF2D8EE90
        public void Log(){} // RVA: 0x7FFAF2D33FA0
        public void IsEnabled(){} // RVA: 0x7FFAF865F7C0
        public void BeginScope(){} // RVA: 0x7FFAF2D33FA0
        public void ThrowLoggingError(){} // RVA: 0x7FFAF865F8A0
        public void <Log>g__LoggerLog|14_0(){} // RVA: 0x7FFAF2D33FA0
        public void <IsEnabled>g__LoggerIsEnabled|15_0(){} // RVA: 0x7FFAF865F900
    }

    public class LoggerExtensions
    {
        // ── Methods ──
        public void LogDebug(){} // RVA: 0x7FFAF8659840 | overloaded x4
        public void LogTrace(){} // RVA: 0x7FFAF8659AC0 | overloaded x4
        public void LogInformation(){} // RVA: 0x7FFAF8659D60 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFAF865A000 | overloaded x4
        public void LogError(){} // RVA: 0x7FFAF865A2A0 | overloaded x4
        public void LogCritical(){} // RVA: 0x7FFAF865A540 | overloaded x4
        public void Log(){} // RVA: 0x7FFAF865A840 | overloaded x4
        public void BeginScope(){} // RVA: 0x7FFAF865A980
        public void MessageFormatter(){} // RVA: 0x7FFAF865AA40
        public void .cctor(){} // RVA: 0x7FFAF865AAB0
    }

    public class LoggerExternalScopeProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF865AC50
        public void ForEachScope(){} // RVA: 0x7FFAF2D33FA0
        public void Push(){} // RVA: 0x7FFAF865ACF0
        public void <ForEachScope>g__Report|2_0(){} // RVA: 0x7FFAF2AD4D50
    }

    public class LoggerFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8660200 | overloaded x6
        public void Create(){} // RVA: 0x7FFAF8660920
        public void RefreshFilters(){} // RVA: 0x7FFAF8660D10
        public void CreateLogger(){} // RVA: 0x7FFAF8661170
        public void AddProvider(){} // RVA: 0x7FFAF8661620
        public void AddProviderRegistration(){} // RVA: 0x7FFAF8661C50
        public void CreateLoggers(){} // RVA: 0x7FFAF8661EA0
        public void ApplyFilters(){} // RVA: 0x7FFAF8662060
        public void CheckDisposed(){} // RVA: 0x7FFAF8662630
        public void Dispose(){} // RVA: 0x7FFAF8662640
    }

    public class LoggerFactoryExtensions
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFAF865B030 | overloaded x2
    }

    public class LoggerFactoryOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_ActivityTrackingOptions(){} // RVA: 0x7FFAF2DDA5C0
    }

    public class LoggerFactoryScopeProvider : 
00
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86628F0
        public void ForEachScope(){} // RVA: 0x7FFAF2D33FA0
        public void GetOrCreateActivityBaggageLogScopeWrapper(){} // RVA: 0x7FFAF86629A0
        public void Push(){} // RVA: 0x7FFAF8662AA0
        public void <ForEachScope>g__Report|3_0(){} // RVA: 0x7FFAF2AD4D50
    }

    public class LoggerFilterOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86646E0
        public void get_CaptureScopes(){} // RVA: 0x7FFAF2E575E0
        public void get_MinLevel(){} // RVA: 0x7FFAF335BED0
        public void set_MinLevel(){} // RVA: 0x7FFAF335C660
        public void get_Rules(){} // RVA: 0x7FFAF2D907C0
        public void get_RulesInternal(){} // RVA: 0x7FFAF2D907C0
    }

    public class LoggerFilterRule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86647A0
        public void get_ProviderName(){} // RVA: 0x7FFAF2DA8380
        public void get_CategoryName(){} // RVA: 0x7FFAF2D907C0
        public void get_LogLevel(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Filter(){} // RVA: 0x7FFAF2DBB130
        public void ToString(){} // RVA: 0x7FFAF86648B0
    }

    public class LoggerInformation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8664E20
        public void get_Logger(){} // RVA: 0x7FFAF4584690
        public void get_Category(){} // RVA: 0x7FFAF44189C0
        public void get_ProviderType(){} // RVA: 0x7FFAF2DA8380
        public void get_ExternalScope(){} // RVA: 0x7FFAF2DA84E0
    }

    public class LoggerMessage
    {
        // ── Methods ──
        public void DefineScope(){} // RVA: 0x7FFAF2ABCE50 | overloaded x7
        public void Define(){} // RVA: 0x7FFAF2D33FA0 | overloaded x14
        public void CreateLogValuesFormatter(){} // RVA: 0x7FFAF865B470
    }

    public class LoggerMessageAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF865C290 | overloaded x5
        public void get_EventId(){} // RVA: 0x7FFAF2DDA5C0
        public void set_EventId(){} // RVA: 0x7FFAF2D900C0
        public void get_EventName(){} // RVA: 0x7FFAF2D907C0
        public void set_EventName(){} // RVA: 0x7FFAF2DF3E80
        public void get_Level(){} // RVA: 0x7FFAF3210030
        public void set_Level(){} // RVA: 0x7FFAF344E0D0
        public void get_Message(){} // RVA: 0x7FFAF2DBB130
        public void set_Message(){} // RVA: 0x7FFAF2D8EE90
        public void get_SkipEnabledCheck(){} // RVA: 0x7FFAF2DB3450
        public void set_SkipEnabledCheck(){} // RVA: 0x7FFAF2DB3460
    }

    public class LoggerRuleSelector
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x7FFAF8664FF0
        public void IsBetter(){} // RVA: 0x7FFAF8665320
    }

    public class Logger`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void Microsoft.Extensions.Logging.ILogger.BeginScope(){} // RVA: 0x7FFAF2D33FA0
        public void Microsoft.Extensions.Logging.ILogger.IsEnabled(){} // RVA: 0x7FFAF2ABE1F0
        public void Microsoft.Extensions.Logging.ILogger.Log(){} // RVA: 0x7FFAF2D33FA0
        public void GetCategoryName(){} // RVA: 0x7FFAF2ABC960
        public void DebuggerToString(){} // RVA: 0x7FFAF2ABCD60
    }

    public class LoggingBuilder : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Services(){} // RVA: 0x7FFAF2DA8380
    }

    public class MessageLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8664C10
        public void get_Logger(){} // RVA: 0x7FFAF4584690
        public void get_Category(){} // RVA: 0x7FFAF44189C0
        public void get_ProviderTypeFullName(){} // RVA: 0x7FFAF2DA8380
        public void get_MinLevel(){} // RVA: 0x7FFAF2D907C0
        public void get_Filter(){} // RVA: 0x7FFAF2DBB0C0
        public void IsEnabled(){} // RVA: 0x7FFAF8664D70
    }

    public class NullExternalScopeProvider : Instance
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_Instance(){} // RVA: 0x7FFAF865DA30
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.ForEachScope(){} // RVA: 0x7FFAF2D33FA0
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.Push(){} // RVA: 0x7FFAF865DA90
        public void .cctor(){} // RVA: 0x7FFAF865DB30
    }

    public class NullScope
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF865DBD0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF865DC30
    }

    public class NullScope : 
00
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF8665A10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8665A70
    }

    public class ProfilerMarkerDataType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8665750
        public void OnChange(){} // RVA: 0x7FFAF2FC9240
        public void get_CurrentValue(){} // RVA: 0x7FFAF2DA8380
    }

    public class ProviderAliasAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class ProviderAliasUtilities
    {
        // ── Methods ──
        public void GetAlias(){} // RVA: 0x7FFAF8665810
    }

    public class ScopeLogger
    {
        public object ScopeStackContainer;
        public object ScopeAndClientStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
        public void get_Logger(){} // RVA: 0x7FFAF4584690
        public void get_ExternalScopeProvider(){} // RVA: 0x7FFAF44189C0
        public void CreateScope(){} // RVA: 0x7FFAF2D33FA0
    }

}