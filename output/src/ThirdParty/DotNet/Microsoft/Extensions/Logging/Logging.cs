// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging
// Classes: 37
// Methods: 219

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging
{
    public class ActivityExtensions : Object
    {
        // ── Methods ──
        public void GetSpanId(){} // RVA: 0x7FFE866F5320
        public void GetTraceId(){} // RVA: 0x7FFE866F53D0
        public void GetParentId(){} // RVA: 0x7FFE866F5480
    }

    public class DebuggerDisplayFormatting : Object
    {
        // ── Methods ──
        public void DebuggerToString(){} // RVA: 0x7FFE866EEB20
        public void CalculateEnabledLogLevel(){} // RVA: 0x7FFE866EEC60
    }

    public class DefaultLoggerLevelConfigureOptions : ConfigureOptions`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F0080
    }

    public class EventId : ValueType
    {
        public int _id; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFE866E96C0
        public void op_Equality(){} // RVA: 0x7FFE866E9720
        public void op_Inequality(){} // RVA: 0x7FFE866E9730
        public void .ctor(){} // RVA: 0x7FFE844576B0
        public void get_Id(){} // RVA: 0x7FFE826F4220
        public void get_Name(){} // RVA: 0x7FFE826F4210
        public void ToString(){} // RVA: 0x7FFE866E9740
        public void Equals(){} // RVA: 0x7FFE866E97F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
    }

    public class FilterLoggingBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddFilter(){} // RVA: 0x7FFE866F0310 | overloaded x2
        public void ConfigureFilter(){} // RVA: 0x7FFE866F0340
        public void AddRule(){} // RVA: 0x7FFE866F03C0
    }

    public class FormattedLogValues : ValueType
    {
        public int MaxCachedFormatters;
        public string NullFormat;
        public int s_count;

        // ── Methods ──
        public void get_Formatter(){} // RVA: 0x7FFE8284EF60
        public void .ctor(){} // RVA: 0x7FFE866E9880
        public void get_Item(){} // RVA: 0x7FFE866E9C10
        public void get_Count(){} // RVA: 0x7FFE866E9EE0
        public void GetEnumerator(){} // RVA: 0x7FFE866E9F40
        public void ToString(){} // RVA: 0x7FFE866E9FF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE866EA010
        public void .cctor(){} // RVA: 0x7FFE866EA060
    }

    public class IExternalScopeProvider
    {
        // ── Methods ──
        public void ForEachScope(){} // RVA: 0x7FFE810A1420
        public void Push(){} // RVA: 0x7FFE80E2E390
    }

    public class ILogger
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFE810A1420
        public void IsEnabled(){} // RVA: 0x7FFE80E2F760
        public void BeginScope(){} // RVA: 0x7FFE810A1420
    }

    public class ILoggerFactory
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFE80E2E390
        public void AddProvider(){} // RVA: 0x7FFE80E460A0
    }

    public class ILoggerProvider
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFE80E2E390
    }

    public class ILogger`1
    {
    }

    public class ILoggingBuilder
    {
        // ── Methods ──
        public void get_Services(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISupportExternalScope
    {
        // ── Methods ──
        public void SetScopeProvider(){} // RVA: 0x7FFE80E460A0
    }

    public class LogDefineOptions : Object
    {
        public bool _skipEnabledCheck; // 0x10

        // ── Methods ──
        public void get_SkipEnabledCheck(){} // RVA: 0x7FFE811C55E0
        public void set_SkipEnabledCheck(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LogValuesFormatter : Object
    {
        public string NullValue;
        public char[] FormatDelimiters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866ED1E0
        public void get_OriginalFormat(){} // RVA: 0x7FFE811290C0
        public void set_OriginalFormat(){} // RVA: 0x7FFE811290D0
        public void get_ValueNames(){} // RVA: 0x7FFE81116380
        public void FindBraceIndex(){} // RVA: 0x7FFE866ED880
        public void FindIndexOfAny(){} // RVA: 0x7FFE866ED930
        public void Format(){} // RVA: 0x7FFE866EE1E0 | overloaded x5
        public void FormatWithOverwrite(){} // RVA: 0x7FFE866EDC80
        public void GetValue(){} // RVA: 0x7FFE866EE310
        public void GetValues(){} // RVA: 0x7FFE866EE480
        public void FormatArgument(){} // RVA: 0x7FFE866EE710
        public void TryFormatArgumentIfNullOrEnumerable(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE866EE790
    }

    public class Logger : Object
    {
        public string _categoryName; // 0x10
        public Microsoft.Extensions.Logging.LoggerInformation[] _loggers; // 0x18
        public Microsoft.Extensions.Logging.MessageLogger[] _messageLoggers; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_Loggers(){} // RVA: 0x7FFE810FE7C0
        public void set_Loggers(){} // RVA: 0x7FFE81161E80
        public void get_MessageLoggers(){} // RVA: 0x7FFE811290C0
        public void set_MessageLoggers(){} // RVA: 0x7FFE811290D0
        public void get_ScopeLoggers(){} // RVA: 0x7FFE81129130
        public void set_ScopeLoggers(){} // RVA: 0x7FFE810FCE90
        public void Log(){} // RVA: 0x7FFE810A1420
        public void IsEnabled(){} // RVA: 0x7FFE866F0610
        public void BeginScope(){} // RVA: 0x7FFE810A1420
        public void ThrowLoggingError(){} // RVA: 0x7FFE866F06F0
        public void <Log>g__LoggerLog|14_0(){} // RVA: 0x7FFE810A1420
        public void <IsEnabled>g__LoggerIsEnabled|15_0(){} // RVA: 0x7FFE866F0750
    }

    public class LoggerExtensions : Object
    {
        // ── Methods ──
        public void LogDebug(){} // RVA: 0x7FFE866EA690 | overloaded x4
        public void LogTrace(){} // RVA: 0x7FFE866EA910 | overloaded x4
        public void LogInformation(){} // RVA: 0x7FFE866EABB0 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFE866EAE50 | overloaded x4
        public void LogError(){} // RVA: 0x7FFE866EB0F0 | overloaded x4
        public void LogCritical(){} // RVA: 0x7FFE866EB390 | overloaded x4
        public void Log(){} // RVA: 0x7FFE866EB690 | overloaded x4
        public void BeginScope(){} // RVA: 0x7FFE866EB7D0
        public void MessageFormatter(){} // RVA: 0x7FFE866EB890
        public void .cctor(){} // RVA: 0x7FFE866EB900
    }

    public class LoggerExternalScopeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866EBAA0
        public void ForEachScope(){} // RVA: 0x7FFE810A1420
        public void Push(){} // RVA: 0x7FFE866EBB40
        public void <ForEachScope>g__Report|2_0(){} // RVA: 0x7FFE80E462E0
    }

    public class LoggerFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F1050 | overloaded x6
        public void Create(){} // RVA: 0x7FFE866F1770
        public void RefreshFilters(){} // RVA: 0x7FFE866F1B60
        public void CreateLogger(){} // RVA: 0x7FFE866F1FC0
        public void AddProvider(){} // RVA: 0x7FFE866F2470
        public void AddProviderRegistration(){} // RVA: 0x7FFE866F2AA0
        public void CreateLoggers(){} // RVA: 0x7FFE866F2CF0
        public void ApplyFilters(){} // RVA: 0x7FFE866F2EB0
        public void CheckDisposed(){} // RVA: 0x7FFE866F3480
        public void Dispose(){} // RVA: 0x7FFE866F3490
    }

    public class LoggerFactoryExtensions : Object
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFE866EBE80 | overloaded x2
    }

    public class LoggerFactoryOptions : Object
    {
        public 0x666CB544 _activityTrackingOptions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ActivityTrackingOptions(){} // RVA: 0x7FFE811485C0
    }

    public class LoggerFactoryScopeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F3740
        public void ForEachScope(){} // RVA: 0x7FFE810A1420
        public void GetOrCreateActivityBaggageLogScopeWrapper(){} // RVA: 0x7FFE866F37F0
        public void Push(){} // RVA: 0x7FFE866F38F0
        public void <ForEachScope>g__Report|3_0(){} // RVA: 0x7FFE80E462E0
    }

    public class LoggerFilterOptions : Object
    {
        public bool _captureScopes; // 0x10
        public 0x666B1D94 _minLevel; // 0x14
        public System.Collections.Generic.List`1<Microsoft.Extensions.Logging.LoggerFilterRule> _rulesInternal; // 0x18
        public object field_3; // 0xEDEE

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F5530
        public void get_CaptureScopes(){} // RVA: 0x7FFE811C55E0
        public void get_MinLevel(){} // RVA: 0x7FFE8164B230
        public void set_MinLevel(){} // RVA: 0x7FFE8164E0F0
        public void get_Rules(){} // RVA: 0x7FFE810FE7C0
        public void get_RulesInternal(){} // RVA: 0x7FFE810FE7C0
    }

    public class LoggerFilterRule : Object
    {
        public string _providerName; // 0x10
        public string _categoryName; // 0x18
        public System.Nullable`1<0x666B1D94> _logLevel; // 0x20
        public System.Func`4<string,string,0x666B1D94,bool> _filter; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F55F0
        public void get_ProviderName(){} // RVA: 0x7FFE81116380
        public void get_CategoryName(){} // RVA: 0x7FFE810FE7C0
        public void get_LogLevel(){} // RVA: 0x7FFE811290C0
        public void get_Filter(){} // RVA: 0x7FFE81129130
        public void ToString(){} // RVA: 0x7FFE866F5700
    }

    public class LoggerInformation : ValueType
    {
        public Microsoft.Extensions.Logging.ILogger _logger; // 0x10
        public string _category; // 0x18
        public System.Type _providerType; // 0x20
        public bool _externalScope; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F5C70
        public void get_Logger(){} // RVA: 0x7FFE8284EF60
        public void get_Category(){} // RVA: 0x7FFE826F4210
        public void get_ProviderType(){} // RVA: 0x7FFE81116380
        public void get_ExternalScope(){} // RVA: 0x7FFE811164E0
    }

    public class LoggerMessage : Object
    {
        // ── Methods ──
        public void DefineScope(){} // RVA: 0x7FFE80E2E3D0 | overloaded x7
        public void Define(){} // RVA: 0x7FFE810A1420 | overloaded x14
        public void CreateLogValuesFormatter(){} // RVA: 0x7FFE866EC2C0
    }

    public class LoggerMessageAttribute : Attribute
    {
        public int _eventId; // 0x10
        public string _eventName; // 0x18
        public 0x666B1D94 _level; // 0x20
        public string _message; // 0x28
        public bool _skipEnabledCheck; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866ED0E0 | overloaded x5
        public void get_EventId(){} // RVA: 0x7FFE811485C0
        public void set_EventId(){} // RVA: 0x7FFE810FE0C0
        public void get_EventName(){} // RVA: 0x7FFE810FE7C0
        public void set_EventName(){} // RVA: 0x7FFE81161E80
        public void get_Level(){} // RVA: 0x7FFE8151D690
        public void set_Level(){} // RVA: 0x7FFE8170B670
        public void get_Message(){} // RVA: 0x7FFE81129130
        public void set_Message(){} // RVA: 0x7FFE810FCE90
        public void get_SkipEnabledCheck(){} // RVA: 0x7FFE81121450
        public void set_SkipEnabledCheck(){} // RVA: 0x7FFE81121460
    }

    public class LoggerRuleSelector : Object
    {
        // ── Methods ──
        public void Select(){} // RVA: 0x7FFE866F5E40
        public void IsBetter(){} // RVA: 0x7FFE866F6170
    }

    public class Logger`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Microsoft.Extensions.Logging.ILogger.BeginScope(){} // RVA: 0x7FFE810A1420
        public void Microsoft.Extensions.Logging.ILogger.IsEnabled(){} // RVA: 0x7FFE80E2F760
        public void Microsoft.Extensions.Logging.ILogger.Log(){} // RVA: 0x7FFE810A1420
        public void GetCategoryName(){} // RVA: 0x7FFE80E2DEE0
        public void DebuggerToString(){} // RVA: 0x7FFE80E2E2E0
    }

    public class LoggingBuilder : Object
    {
        public Microsoft.Extensions.DependencyInjection.IServiceCollection _services; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Services(){} // RVA: 0x7FFE81116380
    }

    public class MessageLogger : ValueType
    {
        public Microsoft.Extensions.Logging.ILogger _logger; // 0x10
        public string _category; // 0x18
        public string _providerTypeFullName; // 0x20
        public System.Nullable`1<0x666B1D94> _minLevel; // 0x28
        public System.Func`4<string,string,0x666B1D94,bool> _filter; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F5A60
        public void get_Logger(){} // RVA: 0x7FFE8284EF60
        public void get_Category(){} // RVA: 0x7FFE826F4210
        public void get_ProviderTypeFullName(){} // RVA: 0x7FFE81116380
        public void get_MinLevel(){} // RVA: 0x7FFE810FE7C0
        public void get_Filter(){} // RVA: 0x7FFE811290C0
        public void IsEnabled(){} // RVA: 0x7FFE866F5BC0
    }

    public class NullExternalScopeProvider : Object
    {
        public Microsoft.Extensions.Logging.IExternalScopeProvider _instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Instance(){} // RVA: 0x7FFE866EE880
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.ForEachScope(){} // RVA: 0x7FFE810A1420
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.Push(){} // RVA: 0x7FFE866EE8E0
        public void .cctor(){} // RVA: 0x7FFE866EE980
    }

    public class NullScope : Object
    {
        public Microsoft.Extensions.Logging.NullScope _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE866EEA20
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE866EEA80
    }

    public class ProfilerMarkerDataType : Object
    {
        public Microsoft.Extensions.Logging.LoggerFilterOptions _currentValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F65A0
        public void OnChange(){} // RVA: 0x7FFE813240E0
        public void get_CurrentValue(){} // RVA: 0x7FFE81116380
    }

    public class ProviderAliasAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class ProviderAliasUtilities : Object
    {
        // ── Methods ──
        public void GetAlias(){} // RVA: 0x7FFE866F6660
    }

    public class ScopeLogger : ValueType
    {
        public Microsoft.Extensions.Logging.ILogger _logger; // 0x10
        public Microsoft.Extensions.Logging.IExternalScopeProvider _externalScopeProvider; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void get_Logger(){} // RVA: 0x7FFE8284EF60
        public void get_ExternalScopeProvider(){} // RVA: 0x7FFE826F4210
        public void CreateScope(){} // RVA: 0x7FFE810A1420
    }

}