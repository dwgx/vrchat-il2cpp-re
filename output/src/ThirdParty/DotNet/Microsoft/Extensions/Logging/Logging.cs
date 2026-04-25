// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging
// Classes: 37
// Methods: 219

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging
{
    public class ActivityExtensions : Object
    {
        // ── Methods ──
        public void GetSpanId(){} // RVA: 0x7FFAC834BA20
        public void GetTraceId(){} // RVA: 0x7FFAC834BAD0
        public void GetParentId(){} // RVA: 0x7FFAC834BB80
    }

    public class DebuggerDisplayFormatting : Object
    {
        // ── Methods ──
        public void DebuggerToString(){} // RVA: 0x7FFAC8345220
        public void CalculateEnabledLogLevel(){} // RVA: 0x7FFAC8345360
    }

    public class DefaultLoggerLevelConfigureOptions : ConfigureOptions`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8346780
    }

    public class EventId : ValueType
    {
        public int Id; // 0x10
        public string Name; // 0x18

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFAC833FDC0
        public void op_Equality(){} // RVA: 0x7FFAC833FE20
        public void op_Inequality(){} // RVA: 0x7FFAC833FE30
        public void .ctor(){} // RVA: 0x7FFAC60F24C0
        public void get_Id(){} // RVA: 0x7FFAC4420210
        public void get_Name(){} // RVA: 0x7FFAC4420220
        public void ToString(){} // RVA: 0x7FFAC833FE40
        public void Equals(){} // RVA: 0x7FFAC833FEF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
    }

    public class FilterLoggingBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddFilter(){} // RVA: 0x7FFAC8346A10 | overloaded x2
        public void ConfigureFilter(){} // RVA: 0x7FFAC8346A40
        public void AddRule(){} // RVA: 0x7FFAC8346AC0
    }

    public class FormattedLogValues : ValueType
    {
        public int Formatter;
        public string Item;
        public int Count;
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,Microsoft.Extensions.Logging.LogValuesFormatter> s_formatters; // 0x8
        public Microsoft.Extensions.Logging.LogValuesFormatter _formatter; // 0x10
        public object[] _values; // 0x18
        public string _originalMessage; // 0x20

        // ── Methods ──
        public void get_Formatter(){} // RVA: 0x7FFAC3AD9F60
        public void .ctor(){} // RVA: 0x7FFAC833FF80
        public void get_Item(){} // RVA: 0x7FFAC8340310
        public void get_Count(){} // RVA: 0x7FFAC83405E0
        public void GetEnumerator(){} // RVA: 0x7FFAC8340640
        public void ToString(){} // RVA: 0x7FFAC83406F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8340710
        public void .cctor(){} // RVA: 0x7FFAC8340760
    }

    public class IExternalScopeProvider
    {
        // ── Methods ──
        public void ForEachScope(){} // RVA: 0x7FFAC2E8DC40
        public void Push(){} // RVA: 0x7FFAC2C58F40
    }

    public class ILogger
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFAC2E8DC40
        public void IsEnabled(){} // RVA: 0x7FFAC2C5A310
        public void BeginScope(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ILoggerFactory
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFAC2C58F40
        public void AddProvider(){} // RVA: 0x7FFAC2C70A40
    }

    public class ILoggerProvider
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFAC2C58F40
    }

    public class ILogger`1
    {
    }

    public class ILoggingBuilder
    {
        public object Services;

        // ── Methods ──
        public void get_Services(){} // RVA: 0x7FFAC2C58E90
    }

    public class ISupportExternalScope
    {
        // ── Methods ──
        public void SetScopeProvider(){} // RVA: 0x7FFAC2C70A40
    }

    public class LogDefineOptions : Object
    {
        public bool SkipEnabledCheck; // 0x10

        // ── Methods ──
        public void get_SkipEnabledCheck(){} // RVA: 0x7FFAC2FEB5E0
        public void set_SkipEnabledCheck(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LogValuesFormatter : Object
    {
        public string OriginalFormat;
        public char[] ValueNames;
        public System.Collections.Generic.List`1<string> _valueNames; // 0x10
        public string _format; // 0x18
        public string <OriginalFormat>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83438E0
        public void get_OriginalFormat(){} // RVA: 0x7FFAC2F4F0C0
        public void set_OriginalFormat(){} // RVA: 0x7FFAC2F4F0D0
        public void get_ValueNames(){} // RVA: 0x7FFAC2F3C380
        public void FindBraceIndex(){} // RVA: 0x7FFAC8343F80
        public void FindIndexOfAny(){} // RVA: 0x7FFAC8344030
        public void Format(){} // RVA: 0x7FFAC83448E0 | overloaded x5
        public void FormatWithOverwrite(){} // RVA: 0x7FFAC8344380
        public void GetValue(){} // RVA: 0x7FFAC8344A10
        public void GetValues(){} // RVA: 0x7FFAC8344B80
        public void FormatArgument(){} // RVA: 0x7FFAC8344E10
        public void TryFormatArgumentIfNullOrEnumerable(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC8344E90
    }

    public class Logger : Object
    {
        public string Loggers; // 0x10
        public Microsoft.Extensions.Logging.LoggerInformation[] MessageLoggers; // 0x18
        public Microsoft.Extensions.Logging.MessageLogger[] ScopeLoggers; // 0x20
        public Microsoft.Extensions.Logging.ScopeLogger[] <ScopeLoggers>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_Loggers(){} // RVA: 0x7FFAC2F247C0
        public void set_Loggers(){} // RVA: 0x7FFAC2F87E80
        public void get_MessageLoggers(){} // RVA: 0x7FFAC2F4F0C0
        public void set_MessageLoggers(){} // RVA: 0x7FFAC2F4F0D0
        public void get_ScopeLoggers(){} // RVA: 0x7FFAC2F4F130
        public void set_ScopeLoggers(){} // RVA: 0x7FFAC2F22E90
        public void Log(){} // RVA: 0x7FFAC2E8DC40
        public void IsEnabled(){} // RVA: 0x7FFAC8346D10
        public void BeginScope(){} // RVA: 0x7FFAC2E8DC40
        public void ThrowLoggingError(){} // RVA: 0x7FFAC8346DF0
        public void <Log>g__LoggerLog|14_0(){} // RVA: 0x7FFAC2E8DC40
        public void <IsEnabled>g__LoggerIsEnabled|15_0(){} // RVA: 0x7FFAC8346E50
    }

    public class LoggerExtensions : Object
    {
        public System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,string> _messageFormatter;

        // ── Methods ──
        public void LogDebug(){} // RVA: 0x7FFAC8340D90 | overloaded x4
        public void LogTrace(){} // RVA: 0x7FFAC8341010 | overloaded x4
        public void LogInformation(){} // RVA: 0x7FFAC83412B0 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFAC8341550 | overloaded x4
        public void LogError(){} // RVA: 0x7FFAC83417F0 | overloaded x4
        public void LogCritical(){} // RVA: 0x7FFAC8341A90 | overloaded x4
        public void Log(){} // RVA: 0x7FFAC8341D90 | overloaded x4
        public void BeginScope(){} // RVA: 0x7FFAC8341ED0
        public void MessageFormatter(){} // RVA: 0x7FFAC8341F90
        public void .cctor(){} // RVA: 0x7FFAC8342000
    }

    public class LoggerExternalScopeProvider : Object
    {
        public System.Threading.AsyncLocal`1<Scope> _currentScope; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83421A0
        public void ForEachScope(){} // RVA: 0x7FFAC2E8DC40
        public void Push(){} // RVA: 0x7FFAC8342240
        public void <ForEachScope>g__Report|2_0(){} // RVA: 0x7FFAC2C70C80
    }

    public class LoggerFactory : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,Microsoft.Extensions.Logging.Logger> _loggers; // 0x10
        public System.Collections.Generic.List`1<ProviderRegistration> _providerRegistrations; // 0x18
        public object _sync; // 0x20
        public bool _disposed; // 0x28
        public System.IDisposable _changeTokenRegistration; // 0x30
        public Microsoft.Extensions.Logging.LoggerFilterOptions _filterOptions; // 0x38
        public Microsoft.Extensions.Logging.IExternalScopeProvider _scopeProvider; // 0x40
        public Microsoft.Extensions.Logging.LoggerFactoryOptions _factoryOptions; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8347750 | overloaded x6
        public void Create(){} // RVA: 0x7FFAC8347E70
        public void RefreshFilters(){} // RVA: 0x7FFAC8348260
        public void CreateLogger(){} // RVA: 0x7FFAC83486C0
        public void AddProvider(){} // RVA: 0x7FFAC8348B70
        public void AddProviderRegistration(){} // RVA: 0x7FFAC83491A0
        public void CreateLoggers(){} // RVA: 0x7FFAC83493F0
        public void ApplyFilters(){} // RVA: 0x7FFAC83495B0
        public void CheckDisposed(){} // RVA: 0x7FFAC8349B80
        public void Dispose(){} // RVA: 0x7FFAC8349B90
    }

    public class LoggerFactoryExtensions : Object
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFAC8342580 | overloaded x2
    }

    public class LoggerFactoryOptions : Object
    {
        public 0x6B2D09F0 ActivityTrackingOptions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ActivityTrackingOptions(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class LoggerFactoryScopeProvider : Object
    {
        public System.Threading.AsyncLocal`1<Scope> _currentScope; // 0x10
        public 0x6B2D09F0 _activityTrackingOption; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8349E40
        public void ForEachScope(){} // RVA: 0x7FFAC2E8DC40
        public void GetOrCreateActivityBaggageLogScopeWrapper(){} // RVA: 0x7FFAC8349EF0
        public void Push(){} // RVA: 0x7FFAC8349FF0
        public void <ForEachScope>g__Report|3_0(){} // RVA: 0x7FFAC2C70C80
    }

    public class LoggerFilterOptions : Object
    {
        public bool CaptureScopes; // 0x10
        public 0x6B2B8CB8 MinLevel; // 0x14
        public System.Collections.Generic.List`1<Microsoft.Extensions.Logging.LoggerFilterRule> Rules; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC834BC30
        public void get_CaptureScopes(){} // RVA: 0x7FFAC2FEB5E0
        public void get_MinLevel(){} // RVA: 0x7FFAC33D5A20
        public void set_MinLevel(){} // RVA: 0x7FFAC33D4990
        public void get_Rules(){} // RVA: 0x7FFAC2F247C0
        public void get_RulesInternal(){} // RVA: 0x7FFAC2F247C0
    }

    public class LoggerFilterRule : Object
    {
        public string ProviderName; // 0x10
        public string CategoryName; // 0x18
        public System.Nullable`1<0x6B2B8CB8> LogLevel; // 0x20
        public System.Func`4<string,string,0x6B2B8CB8,bool> Filter; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC834BCF0
        public void get_ProviderName(){} // RVA: 0x7FFAC2F3C380
        public void get_CategoryName(){} // RVA: 0x7FFAC2F247C0
        public void get_LogLevel(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Filter(){} // RVA: 0x7FFAC2F4F130
        public void ToString(){} // RVA: 0x7FFAC834BE00
    }

    public class LoggerInformation : ValueType
    {
        public Microsoft.Extensions.Logging.ILogger Logger; // 0x10
        public string Category; // 0x18
        public System.Type ProviderType; // 0x20
        public bool ExternalScope; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC834C370
        public void get_Logger(){} // RVA: 0x7FFAC3AD9F60
        public void get_Category(){} // RVA: 0x7FFAC4420220
        public void get_ProviderType(){} // RVA: 0x7FFAC2F3C380
        public void get_ExternalScope(){} // RVA: 0x7FFAC2F3C4E0
    }

    public class LoggerMessage : Object
    {
        // ── Methods ──
        public void DefineScope(){} // RVA: 0x7FFAC2C58F80 | overloaded x7
        public void Define(){} // RVA: 0x7FFAC2E8DC40 | overloaded x14
        public void CreateLogValuesFormatter(){} // RVA: 0x7FFAC83429C0
    }

    public class LoggerMessageAttribute : Attribute
    {
        public int EventId; // 0x10
        public string EventName; // 0x18
        public 0x6B2B8CB8 Level; // 0x20
        public string Message; // 0x28
        public bool SkipEnabledCheck; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83437E0 | overloaded x5
        public void get_EventId(){} // RVA: 0x7FFAC2F6E5C0
        public void set_EventId(){} // RVA: 0x7FFAC2F240C0
        public void get_EventName(){} // RVA: 0x7FFAC2F247C0
        public void set_EventName(){} // RVA: 0x7FFAC2F87E80
        public void get_Level(){} // RVA: 0x7FFAC30DBBE0
        public void set_Level(){} // RVA: 0x7FFAC35DB7A0
        public void get_Message(){} // RVA: 0x7FFAC2F4F130
        public void set_Message(){} // RVA: 0x7FFAC2F22E90
        public void get_SkipEnabledCheck(){} // RVA: 0x7FFAC2F47450
        public void set_SkipEnabledCheck(){} // RVA: 0x7FFAC2F47460
    }

    public class LoggerRuleSelector : Object
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x7FFAC834C540
        public void IsBetter(){} // RVA: 0x7FFAC834C870
    }

    public class Logger`1 : Object
    {
        public Microsoft.Extensions.Logging.ILogger _logger;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Microsoft.Extensions.Logging.ILogger.BeginScope(){} // RVA: 0x7FFAC2E8DC40
        public void Microsoft.Extensions.Logging.ILogger.IsEnabled(){} // RVA: 0x7FFAC2C5A310
        public void Microsoft.Extensions.Logging.ILogger.Log(){} // RVA: 0x7FFAC2E8DC40
        public void GetCategoryName(){} // RVA: 0x7FFAC2C58A90
        public void DebuggerToString(){} // RVA: 0x7FFAC2C58E90
    }

    public class LoggingBuilder : Object
    {
        public Microsoft.Extensions.DependencyInjection.IServiceCollection Services; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Services(){} // RVA: 0x7FFAC2F3C380
    }

    public class MessageLogger : ValueType
    {
        public Microsoft.Extensions.Logging.ILogger Logger; // 0x10
        public string Category; // 0x18
        public string ProviderTypeFullName; // 0x20
        public System.Nullable`1<0x6B2B8CB8> MinLevel; // 0x28
        public System.Func`4<string,string,0x6B2B8CB8,bool> Filter; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC834C160
        public void get_Logger(){} // RVA: 0x7FFAC3AD9F60
        public void get_Category(){} // RVA: 0x7FFAC4420220
        public void get_ProviderTypeFullName(){} // RVA: 0x7FFAC2F3C380
        public void get_MinLevel(){} // RVA: 0x7FFAC2F247C0
        public void get_Filter(){} // RVA: 0x7FFAC2F4F0C0
        public void IsEnabled(){} // RVA: 0x7FFAC834C2C0
    }

    public class NullExternalScopeProvider : Object
    {
        public Microsoft.Extensions.Logging.IExternalScopeProvider Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Instance(){} // RVA: 0x7FFAC8344F80
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.ForEachScope(){} // RVA: 0x7FFAC2E8DC40
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.Push(){} // RVA: 0x7FFAC8344FE0
        public void .cctor(){} // RVA: 0x7FFAC8345080
    }

    public class NullScope : Object
    {
        public Microsoft.Extensions.Logging.NullScope Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8345120
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8345180
    }

    public class ProviderAliasAttribute : Attribute
    {
        public string <Alias>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class ProviderAliasUtilities : Object
    {
        // ── Methods ──
        public void GetAlias(){} // RVA: 0x7FFAC834CD60
    }

    public class ScopeLogger : ValueType
    {
        public Microsoft.Extensions.Logging.ILogger Logger; // 0x10
        public Microsoft.Extensions.Logging.IExternalScopeProvider ExternalScopeProvider; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void get_Logger(){} // RVA: 0x7FFAC3AD9F60
        public void get_ExternalScopeProvider(){} // RVA: 0x7FFAC4420220
        public void CreateScope(){} // RVA: 0x7FFAC2E8DC40
    }

    public class StaticFilterOptionsMonitor : Object
    {
        public Microsoft.Extensions.Logging.LoggerFilterOptions CurrentValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC834CCA0
        public void OnChange(){} // RVA: 0x7FFAC34F9180
        public void get_CurrentValue(){} // RVA: 0x7FFAC2F3C380
    }

}