// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging
// Classes: 42
// Methods: 242

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging
{
    public class ActivityExtensions : Object
    {
        // ── Methods ──
        public void GetSpanId(){} // RVA: 0x662D100
        public void GetTraceId(){} // RVA: 0x662D190
        public void GetParentId(){} // RVA: 0x662D270
    }

    public class DebuggerDisplayFormatting : Object
    {
        // ── Methods ──
        public void DebuggerToString(){} // RVA: 0x6626A50
        public void CalculateEnabledLogLevel(){} // RVA: 0x6626B90
    }

    public class DefaultLoggerLevelConfigureOptions : ConfigureOptions`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6627F60
    }

    public class EventId : ValueType
    {
        public object _id;
        public object _name;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x6621400
        public void op_Equality(){} // RVA: 0x6621460
        public void op_Inequality(){} // RVA: 0x6621470
        public void .ctor(){} // RVA: 0x3616C0
        public void get_Id(){} // RVA: 0x77E60
        public void get_Name(){} // RVA: 0x77ED0
        public void ToString(){} // RVA: 0x8AA040
        public void Equals(){} // RVA: 0x8AA100
        public void GetHashCode(){} // RVA: 0x77E60
    }

    public class FilterLoggingBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddFilter(){} // RVA: 0x66281F0
        public void ConfigureFilter(){} // RVA: 0x6628220
        public void AddRule(){} // RVA: 0x66282A0
    }

    public class FormattedLogValues : ValueType
    {
        public object MaxCachedFormatters;
        public object NullFormat;
        public object s_count;
        public object s_formatters;
        public object _formatter;
        public object _values;
        public object _originalMessage;

        // ── Methods ──
        public void get_Formatter(){} // RVA: 0x77900
        public void .ctor(){} // RVA: 0x8AA250
        public void get_Item(){} // RVA: 0x8AA260
        public void get_Count(){} // RVA: 0x8AA290
        public void GetEnumerator(){} // RVA: 0x8AA2F0
        public void ToString(){} // RVA: 0x8AA300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x8AA320
        public void .cctor(){} // RVA: 0x6621DA0
    }

    public class IExternalScopeProvider
    {
        // ── Methods ──
        public void ForEachScope(){} // RVA: 0xA94080
        public void Push(){} // RVA: 0x87C540
    }

    public class ILogger
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x896630
        public void IsEnabled(){} // RVA: 0x87DD20
        public void BeginScope(){} // RVA: 0xA94080
    }

    public class ILoggerFactory
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x87C540
        public void AddProvider(){} // RVA: 0x894320
    }

    public class ILoggerProvider
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x87C540
    }

    public class ILoggerProvider[] : Array
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

    public class ILoggingBuilder
    {
        // ── Methods ──
        public void get_Services(){} // RVA: 0x87C0A0
    }

    public class ISupportExternalScope
    {
        // ── Methods ──
        public void SetScopeProvider(){} // RVA: 0x894320
    }

    public class LogDefineOptions : Object
    {
        public object _skipEnabledCheck;

        // ── Methods ──
        public void get_SkipEnabledCheck(){} // RVA: 0xC120A0
        public void set_SkipEnabledCheck(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class LogValuesFormatter : Object
    {
        public object NullValue;
        public object FormatDelimiters;
        public object _valueNames;
        public object _format;
        public object _originalFormat;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6625090
        public void get_OriginalFormat(){} // RVA: 0xB700F0
        public void set_OriginalFormat(){} // RVA: 0xB70100
        public void get_ValueNames(){} // RVA: 0xB5DBF0
        public void FindBraceIndex(){} // RVA: 0x6625740
        public void FindIndexOfAny(){} // RVA: 0x66257F0
        public void Format(){} // RVA: 0x66260E0
        public void FormatWithOverwrite(){} // RVA: 0x6625B60
        public void GetValue(){} // RVA: 0x6626210
        public void GetValues(){} // RVA: 0x6626380
        public void FormatArgument(){} // RVA: 0x6626640
        public void TryFormatArgumentIfNullOrEnumerable(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x66266C0
    }

    public class Logger : Object
    {
        public object _categoryName;
        public object _loggers;
        public object _messageLoggers;
        public object _scopeLoggers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Loggers(){} // RVA: 0xB465B0
        public void set_Loggers(){} // RVA: 0xBA9BA0
        public void get_MessageLoggers(){} // RVA: 0xB700F0
        public void set_MessageLoggers(){} // RVA: 0xB70100
        public void get_ScopeLoggers(){} // RVA: 0xB70160
        public void set_ScopeLoggers(){} // RVA: 0xB44DC0
        public void Log(){} // RVA: 0x314E300
        public void IsEnabled(){} // RVA: 0x66284F0
        public void BeginScope(){} // RVA: 0xA94080
        public void ThrowLoggingError(){} // RVA: 0x66285C0
        public void <Log>g__LoggerLog|14_0(){} // RVA: 0x314D630
        public void <IsEnabled>g__LoggerIsEnabled|15_0(){} // RVA: 0x6628620
    }

    public class LoggerExtensions : Object
    {
        public object _messageFormatter;

        // ── Methods ──
        public void LogDebug(){} // RVA: 0x66223D0
        public void LogTrace(){} // RVA: 0x6622650
        public void LogInformation(){} // RVA: 0x66228F0
        public void LogWarning(){} // RVA: 0x6622B90
        public void LogError(){} // RVA: 0x6622E30
        public void LogCritical(){} // RVA: 0x66230D0
        public void Log(){} // RVA: 0x6623400
        public void BeginScope(){} // RVA: 0x6623540
        public void MessageFormatter(){} // RVA: 0x6623600
        public void .cctor(){} // RVA: 0x6623670
    }

    public class LoggerExternalScopeProvider : Object
    {
        public object _currentScope;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6623800
        public void ForEachScope(){} // RVA: 0xA94080
        public void Push(){} // RVA: 0x66238A0
        public void <ForEachScope>g__Report|2_0(){} // RVA: 0x8945C0
    }

    public class LoggerFactory : Object
    {
        public object _loggers;
        public object _providerRegistrations;
        public object _sync;
        public object _disposed;
        public object _changeTokenRegistration;
        public object _filterOptions;
        public object _scopeProvider;
        public object _factoryOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6628F40
        public void Create(){} // RVA: 0x6629670
        public void RefreshFilters(){} // RVA: 0x6629A30
        public void CreateLogger(){} // RVA: 0x6629E50
        public void AddProvider(){} // RVA: 0x662A2E0
        public void AddProviderRegistration(){} // RVA: 0x662A8E0
        public void CreateLoggers(){} // RVA: 0x662AB30
        public void ApplyFilters(){} // RVA: 0x662AD00
        public void CheckDisposed(){} // RVA: 0x662B2C0
        public void Dispose(){} // RVA: 0x662B2D0
    }

    public class LoggerFactoryExtensions : Object
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x6623BE0
    }

    public class LoggerFactoryOptions : Object
    {
        public object _activityTrackingOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ActivityTrackingOptions(){} // RVA: 0xB8F8F0
    }

    public class LoggerFactoryScopeProvider : Object
    {
        public object _currentScope;
        public object _activityTrackingOption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x662B590
        public void ForEachScope(){} // RVA: 0xA94080
        public void GetOrCreateActivityBaggageLogScopeWrapper(){} // RVA: 0x662B640
        public void Push(){} // RVA: 0x662B740
        public void <ForEachScope>g__Report|3_0(){} // RVA: 0x8945C0
    }

    public class LoggerFilterOptions : Object
    {
        public object _captureScopes;
        public object _minLevel;
        public object _rulesInternal;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x662D300
        public void get_CaptureScopes(){} // RVA: 0xC120A0
        public void get_MinLevel(){} // RVA: 0x116A650
        public void set_MinLevel(){} // RVA: 0x116BB10
        public void get_Rules(){} // RVA: 0xB465B0
        public void get_RulesInternal(){} // RVA: 0xB465B0
    }

    public class LoggerFilterRule : Object
    {
        public object _providerName;
        public object _categoryName;
        public object _logLevel;
        public object _filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x662D3C0
        public void get_ProviderName(){} // RVA: 0xB5DBF0
        public void get_CategoryName(){} // RVA: 0xB465B0
        public void get_LogLevel(){} // RVA: 0xB700F0
        public void get_Filter(){} // RVA: 0xB70160
        public void ToString(){} // RVA: 0x662D4D0
    }

    public class LoggerFilterRule[] : Array
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

    public class LoggerInformation : ValueType
    {
        public object _logger;
        public object _category;
        public object _providerType;
        public object _externalScope;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AAA20
        public void get_Logger(){} // RVA: 0x77900
        public void get_Category(){} // RVA: 0x77ED0
        public void get_ProviderType(){} // RVA: 0x7E450
        public void get_ExternalScope(){} // RVA: 0x8C6E0
    }

    public class LoggerInformation[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LoggerMessage : Object
    {
        // ── Methods ──
        public void DefineScope(){} // RVA: 0x87C5C0
        public void Define(){} // RVA: 0xA94080
        public void CreateLogValuesFormatter(){} // RVA: 0x6624180
    }

    public class LoggerMessageAttribute : Attribute
    {
        public object _eventId;
        public object _eventName;
        public object _level;
        public object _message;
        public object _skipEnabledCheck;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6624F90
        public void get_EventId(){} // RVA: 0xB8F8F0
        public void set_EventId(){} // RVA: 0xB460A0
        public void get_EventName(){} // RVA: 0xB465B0
        public void set_EventName(){} // RVA: 0xBA9BA0
        public void get_Level(){} // RVA: 0xFEAE90
        public void set_Level(){} // RVA: 0x1269760
        public void get_Message(){} // RVA: 0xB70160
        public void set_Message(){} // RVA: 0xB44DC0
        public void get_SkipEnabledCheck(){} // RVA: 0xB68DF0
        public void set_SkipEnabledCheck(){} // RVA: 0xB68E00
    }

    public class LoggerRuleSelector : Object
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x662DC10
        public void IsBetter(){} // RVA: 0x662DF50
    }

    public class Logger`1 : Object
    {
        public object _logger;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void Microsoft.Extensions.Logging.ILogger.BeginScope(){} // RVA: 0xA94080
        public void Microsoft.Extensions.Logging.ILogger.IsEnabled(){} // RVA: 0x87DD20
        public void Microsoft.Extensions.Logging.ILogger.Log(){} // RVA: 0xA94080
        public void GetCategoryName(){} // RVA: 0x87C0D0
        public void DebuggerToString(){} // RVA: 0x87C0A0
    }

    public class LoggingBuilder : Object
    {
        public object _services;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Services(){} // RVA: 0xB5DBF0
    }

    public class MessageLogger : ValueType
    {
        public object _logger;
        public object _category;
        public object _providerTypeFullName;
        public object _minLevel;
        public object _filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AA880
        public void get_Logger(){} // RVA: 0x77900
        public void get_Category(){} // RVA: 0x77ED0
        public void get_ProviderTypeFullName(){} // RVA: 0x7E450
        public void get_MinLevel(){} // RVA: 0x931A0
        public void get_Filter(){} // RVA: 0x8C630
        public void IsEnabled(){} // RVA: 0x8AA890
    }

    public class MessageLogger[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7EC40
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4700
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34D20
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7ABD0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class NullExternalScopeProvider : Object
    {
        public object _instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Instance(){} // RVA: 0x66267B0
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.ForEachScope(){} // RVA: 0xA94080
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.Push(){} // RVA: 0x6626810
        public void .cctor(){} // RVA: 0x66268B0
    }

    public class NullScope : Object
    {
        public object _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6626950
        public void .ctor(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x66269B0
    }

    public class NullScope : Object
    {
        public object _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x662E650
        public void .ctor(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x662E6B0
    }

    public class ProfilerMarkerDataType : Object
    {
        public object _currentValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x662E390
        public void OnChange(){} // RVA: 0xDAC980
        public void get_CurrentValue(){} // RVA: 0xB5DBF0
    }

    public class ProviderAliasAttribute : Attribute
    {
        public object _alias;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class ProviderAliasUtilities : Object
    {
        // ── Methods ──
        public void GetAlias(){} // RVA: 0x662E450
    }

    public class ScopeLogger : ValueType
    {
        public object _logger;
        public object _externalScopeProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void get_Logger(){} // RVA: 0x77900
        public void get_ExternalScopeProvider(){} // RVA: 0x77ED0
        public void CreateScope(){} // RVA: 0xA94080
    }

    public class ScopeLogger[] : Array
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

}