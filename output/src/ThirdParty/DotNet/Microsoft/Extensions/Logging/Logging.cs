// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging
// Classes: 41
// Methods: 223

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging
{
    public class ActivityExtensions
    {
        // ── Methods ──
        public void GetSpanId(){} // RVA: 0x5BB44D0
        public void GetTraceId(){} // RVA: 0x5BB4580
        public void GetParentId(){} // RVA: 0x5BB4630
    }

    public class DebuggerDisplayFormatting
    {
        // ── Methods ──
        public void DebuggerToString(){} // RVA: 0x5BADCD0
        public void CalculateEnabledLogLevel(){} // RVA: 0x5BADE10
    }

    public class DefaultLoggerLevelConfigureOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BAF230
    }

    public class EventId
    {
        public int <Id>k__BackingField; // 0x10
        public string <Name>k__BackingField; // 0x18

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x5BA8870
        public void op_Equality(){} // RVA: 0x5BA88D0
        public void op_Inequality(){} // RVA: 0x5BA88E0
        public void .ctor(){} // RVA: 0x37C6C70
        public void get_Id(){} // RVA: 0x19689B0
        public void get_Name(){} // RVA: 0x19689C0
        public void ToString(){} // RVA: 0x5BA88F0
        public void Equals(){} // RVA: 0x5BA89A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x19689B0
    }

    public class FilterLoggingBuilderExtensions
    {
        // ── Methods ──
        public void AddFilter(){} // RVA: 0x5BAF4C0 | overloaded x2
        public void ConfigureFilter(){} // RVA: 0x5BAF4F0
        public void AddRule(){} // RVA: 0x5BAF570
    }

    public class FormattedLogValues
    {
        public int MaxCachedFormatters;
        public string NullFormat;
        public int s_count;

        // ── Methods ──
        public void get_Formatter(){} // RVA: 0x1AD4690
        public void .ctor(){} // RVA: 0x5BA8A30
        public void get_Item(){} // RVA: 0x5BA8DC0
        public void get_Count(){} // RVA: 0x5BA9090
        public void GetEnumerator(){} // RVA: 0x5BA90F0
        public void ToString(){} // RVA: 0x5BA91A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5BA91C0
        public void .cctor(){} // RVA: 0x5BA9210
    }

    public class IExternalScopeProvider
    {
        // ── Methods ──
        public void ForEachScope(){} // RVA: 0x283FA0
        public void Push(){} // RVA: 0xCE10
    }

    public class ILogger
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x283FA0
        public void IsEnabled(){} // RVA: 0xE1F0
        public void BeginScope(){} // RVA: 0x283FA0
    }

    public class ILoggerFactory
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0xCE10
        public void AddProvider(){} // RVA: 0x24B10
    }

    public class ILoggerProvider
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0xCE10
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
        public void get_Services(){} // RVA: 0xCD60
    }

    public class ISupportExternalScope
    {
        // ── Methods ──
        public void SetScopeProvider(){} // RVA: 0x24B10
    }

    public class LogDefineOptions
    {
        public bool <SkipEnabledCheck>k__BackingField; // 0x10

        // ── Methods ──
        public void get_SkipEnabledCheck(){} // RVA: 0x3A75E0
        public void set_SkipEnabledCheck(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LogValuesFormatter
    {
        public string Loggers;
        public char[] MessageLoggers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BAC390
        public void get_OriginalFormat(){} // RVA: 0x30B0C0
        public void set_OriginalFormat(){} // RVA: 0x30B0D0
        public void get_ValueNames(){} // RVA: 0x2F8380
        public void FindBraceIndex(){} // RVA: 0x5BACA30
        public void FindIndexOfAny(){} // RVA: 0x5BACAE0
        public void Format(){} // RVA: 0x5BAD390 | overloaded x5
        public void FormatWithOverwrite(){} // RVA: 0x5BACE30
        public void GetValue(){} // RVA: 0x5BAD4C0
        public void GetValues(){} // RVA: 0x5BAD630
        public void FormatArgument(){} // RVA: 0x5BAD8C0
        public void TryFormatArgumentIfNullOrEnumerable(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x5BAD940
    }

    public class Logger
    {
        public string _categoryName; // 0x10
        public Microsoft.Extensions.Logging.LoggerInformation[] <Loggers>k__BackingField; // 0x18
        public Microsoft.Extensions.Logging.MessageLogger[] <MessageLoggers>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_Loggers(){} // RVA: 0x2E07C0
        public void set_Loggers(){} // RVA: 0x343E80
        public void get_MessageLoggers(){} // RVA: 0x30B0C0
        public void set_MessageLoggers(){} // RVA: 0x30B0D0
        public void get_ScopeLoggers(){} // RVA: 0x30B130
        public void set_ScopeLoggers(){} // RVA: 0x2DEE90
        public void Log(){} // RVA: 0x283FA0
        public void IsEnabled(){} // RVA: 0x5BAF7C0
        public void BeginScope(){} // RVA: 0x283FA0
        public void ThrowLoggingError(){} // RVA: 0x5BAF8A0
        public void <Log>g__LoggerLog|14_0(){} // RVA: 0x283FA0
        public void <IsEnabled>g__LoggerIsEnabled|15_0(){} // RVA: 0x5BAF900
    }

    public class LoggerExtensions
    {
        // ── Methods ──
        public void LogDebug(){} // RVA: 0x5BA9840 | overloaded x4
        public void LogTrace(){} // RVA: 0x5BA9AC0 | overloaded x4
        public void LogInformation(){} // RVA: 0x5BA9D60 | overloaded x4
        public void LogWarning(){} // RVA: 0x5BAA000 | overloaded x4
        public void LogError(){} // RVA: 0x5BAA2A0 | overloaded x4
        public void LogCritical(){} // RVA: 0x5BAA540 | overloaded x4
        public void Log(){} // RVA: 0x5BAA840 | overloaded x4
        public void BeginScope(){} // RVA: 0x5BAA980
        public void MessageFormatter(){} // RVA: 0x5BAAA40
        public void .cctor(){} // RVA: 0x5BAAAB0
    }

    public class LoggerExternalScopeProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BAAC50
        public void ForEachScope(){} // RVA: 0x283FA0
        public void Push(){} // RVA: 0x5BAACF0
        public void <ForEachScope>g__Report|2_0(){} // RVA: 0x24D50
    }

    public class LoggerFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BB0200 | overloaded x6
        public void Create(){} // RVA: 0x5BB0920
        public void RefreshFilters(){} // RVA: 0x5BB0D10
        public void CreateLogger(){} // RVA: 0x5BB1170
        public void AddProvider(){} // RVA: 0x5BB1620
        public void AddProviderRegistration(){} // RVA: 0x5BB1C50
        public void CreateLoggers(){} // RVA: 0x5BB1EA0
        public void ApplyFilters(){} // RVA: 0x5BB2060
        public void CheckDisposed(){} // RVA: 0x5BB2630
        public void Dispose(){} // RVA: 0x5BB2640
    }

    public class LoggerFactoryExtensions
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x5BAB030 | overloaded x2
    }

    public class LoggerFactoryOptions
    {
        public 0x659F3AB0 <ActivityTrackingOptions>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ActivityTrackingOptions(){} // RVA: 0x32A5C0
    }

    public class LoggerFactoryScopeProvider : 
00
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BB28F0
        public void ForEachScope(){} // RVA: 0x283FA0
        public void GetOrCreateActivityBaggageLogScopeWrapper(){} // RVA: 0x5BB29A0
        public void Push(){} // RVA: 0x5BB2AA0
        public void <ForEachScope>g__Report|3_0(){} // RVA: 0x24D50
    }

    public class LoggerFilterOptions
    {
        public bool <CaptureScopes>k__BackingField; // 0x10
        public 0x659DBCC8 <MinLevel>k__BackingField; // 0x14
        public System.Collections.Generic.List`1<Microsoft.Extensions.Logging.LoggerFilterRule> <RulesInternal>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BB46E0
        public void get_CaptureScopes(){} // RVA: 0x3A75E0
        public void get_MinLevel(){} // RVA: 0x8ABED0
        public void set_MinLevel(){} // RVA: 0x8AC660
        public void get_Rules(){} // RVA: 0x2E07C0
        public void get_RulesInternal(){} // RVA: 0x2E07C0
    }

    public class LoggerFilterRule
    {
        public string <ProviderName>k__BackingField; // 0x10
        public string <CategoryName>k__BackingField; // 0x18
        public System.Nullable`1<0x659DBCC8> <LogLevel>k__BackingField; // 0x20
        public System.Func`4<string,string,0x659DBCC8,bool> <Filter>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BB47A0
        public void get_ProviderName(){} // RVA: 0x2F8380
        public void get_CategoryName(){} // RVA: 0x2E07C0
        public void get_LogLevel(){} // RVA: 0x30B0C0
        public void get_Filter(){} // RVA: 0x30B130
        public void ToString(){} // RVA: 0x5BB48B0
    }

    public class LoggerInformation
    {
        public Microsoft.Extensions.Logging.ILogger <Logger>k__BackingField; // 0x10
        public string <Category>k__BackingField; // 0x18
        public System.Type <ProviderType>k__BackingField; // 0x20
        public bool <ExternalScope>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BB4E20
        public void get_Logger(){} // RVA: 0x1AD4690
        public void get_Category(){} // RVA: 0x19689C0
        public void get_ProviderType(){} // RVA: 0x2F8380
        public void get_ExternalScope(){} // RVA: 0x2F84E0
    }

    public class LoggerMessage
    {
        // ── Methods ──
        public void DefineScope(){} // RVA: 0xCE50 | overloaded x7
        public void Define(){} // RVA: 0x283FA0 | overloaded x14
        public void CreateLogValuesFormatter(){} // RVA: 0x5BAB470
    }

    public class LoggerMessageAttribute
    {
        public int <EventId>k__BackingField; // 0x10
        public string <EventName>k__BackingField; // 0x18
        public 0x659DBCC8 <Level>k__BackingField; // 0x20
        public string <Message>k__BackingField; // 0x28
        public bool <SkipEnabledCheck>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BAC290 | overloaded x5
        public void get_EventId(){} // RVA: 0x32A5C0
        public void set_EventId(){} // RVA: 0x2E00C0
        public void get_EventName(){} // RVA: 0x2E07C0
        public void set_EventName(){} // RVA: 0x343E80
        public void get_Level(){} // RVA: 0x760030
        public void set_Level(){} // RVA: 0x99E0D0
        public void get_Message(){} // RVA: 0x30B130
        public void set_Message(){} // RVA: 0x2DEE90
        public void get_SkipEnabledCheck(){} // RVA: 0x303450
        public void set_SkipEnabledCheck(){} // RVA: 0x303460
    }

    public class LoggerRuleSelector
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x5BB4FF0
        public void IsBetter(){} // RVA: 0x5BB5320
    }

    public class Logger`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void Microsoft.Extensions.Logging.ILogger.BeginScope(){} // RVA: 0x283FA0
        public void Microsoft.Extensions.Logging.ILogger.IsEnabled(){} // RVA: 0xE1F0
        public void Microsoft.Extensions.Logging.ILogger.Log(){} // RVA: 0x283FA0
        public void GetCategoryName(){} // RVA: 0xC960
        public void DebuggerToString(){} // RVA: 0xCD60
    }

    public class LoggingBuilder : `
    {
        public Microsoft.Extensions.DependencyInjection.IServiceCollection <Services>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Services(){} // RVA: 0x2F8380
    }

    public class MessageLogger
    {
        public Microsoft.Extensions.Logging.ILogger <Logger>k__BackingField; // 0x10
        public string <Category>k__BackingField; // 0x18
        public string <ProviderTypeFullName>k__BackingField; // 0x20
        public System.Nullable`1<0x659DBCC8> <MinLevel>k__BackingField; // 0x28
        public System.Func`4<string,string,0x659DBCC8,bool> <Filter>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BB4C10
        public void get_Logger(){} // RVA: 0x1AD4690
        public void get_Category(){} // RVA: 0x19689C0
        public void get_ProviderTypeFullName(){} // RVA: 0x2F8380
        public void get_MinLevel(){} // RVA: 0x2E07C0
        public void get_Filter(){} // RVA: 0x30B0C0
        public void IsEnabled(){} // RVA: 0x5BB4D70
    }

    public class NullExternalScopeProvider : Instance
    {
        public Microsoft.Extensions.Logging.IExternalScopeProvider <Instance>k__BackingField;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Instance(){} // RVA: 0x5BADA30
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.ForEachScope(){} // RVA: 0x283FA0
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.Push(){} // RVA: 0x5BADA90
        public void .cctor(){} // RVA: 0x5BADB30
    }

    public class NullScope
    {
        public Microsoft.Extensions.Logging.NullScope <Instance>k__BackingField;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x5BADBD0
        public void .ctor(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5BADC30
    }

    public class NullScope : 
00
    {
        public Microsoft.Extensions.Logging.NullScope <Instance>k__BackingField;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x5BB5A10
        public void .ctor(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5BB5A70
    }

    public class ProfilerMarkerDataType
    {
        public Microsoft.Extensions.Logging.LoggerFilterOptions <CurrentValue>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BB5750
        public void OnChange(){} // RVA: 0x519240
        public void get_CurrentValue(){} // RVA: 0x2F8380
    }

    public class ProviderAliasAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class ProviderAliasUtilities
    {
        // ── Methods ──
        public void GetAlias(){} // RVA: 0x5BB5810
    }

    public class ScopeLogger
    {
        public Microsoft.Extensions.Logging.ILogger ScopeStackContainer; // 0x10
        public Microsoft.Extensions.Logging.IExternalScopeProvider ScopeAndClientStack; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
        public void get_Logger(){} // RVA: 0x1AD4690
        public void get_ExternalScopeProvider(){} // RVA: 0x19689C0
        public void CreateScope(){} // RVA: 0x283FA0
    }

}