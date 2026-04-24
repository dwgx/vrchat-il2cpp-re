// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging
// Classes: 29
// Methods: 147

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging
{
    public class DefaultLoggerLevelConfigureOptions : ConfigureOptions`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd67930
    }

    public class EventId : ValueType
    {
        // ── Original Methods ──
        public void op_Implicit(){} // RVA: 0x7ffaadd60f70
        public void op_Equality(){} // RVA: 0x7ffaadd60fd0
        public void op_Inequality(){} // RVA: 0x7ffaadd60fe0
        public void .ctor(){} // RVA: 0x7ffaabb03a70
        public void get_Id(){} // RVA: 0x7ffaa9e47550
        public void get_Name(){} // RVA: 0x7ffaa9e47540
        public void ToString(){} // RVA: 0x7ffaadd60ff0
        public void Equals(){} // RVA: 0x7ffaadd610a0
        public void Equals(){} // RVA: 0x7ffaadd610a0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa9e47550
    }

    public class FilterLoggingBuilderExtensions : Object
    {
        // ── Original Methods ──
        public void AddFilter(){} // RVA: 0x7ffaadd67bc0
        public void AddFilter(){} // RVA: 0x7ffaadd67bc0
        public void ConfigureFilter(){} // RVA: 0x7ffaadd67bf0
        public void AddRule(){} // RVA: 0x7ffaadd67c70
    }

    public class IExternalScopeProvider
    {
        // ── Original Methods ──
        public void ForEachScope(){} // RVA: 0x7ffaa887e5c0
        public void Push(){} // RVA: 0x7ffaa8649280
    }

    public class ILogger
    {
        // ── Original Methods ──
        public void Log(){} // RVA: 0x7ffaa887e5c0
        public void IsEnabled(){} // RVA: 0x7ffaa864a650
        // ── Binary Analysis Named ──
        public void BeginScope(){} // RVA: 0x7ffaa887e5c0
    }

    public class ILoggerFactory
    {
        // ── Original Methods ──
        public void CreateLogger(){} // RVA: 0x7ffaa8649280
        public void AddProvider(){} // RVA: 0x7ffaa8660d80
    }

    public class ILoggerProvider
    {
        // ── Original Methods ──
        public void CreateLogger(){} // RVA: 0x7ffaa8649280
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
        // ── Original Methods ──
        public void get_Services(){} // RVA: 0x7ffaa86491d0
    }

    public class ISupportExternalScope
    {
        // ── Binary Analysis Named ──
        public void SetScopeProvider(){} // RVA: 0x7ffaa8660d80
    }

    public class LogValuesFormatter : Object
    {
        public object _valueNames; // 0x3180AB60

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd64a90
        public void get_OriginalFormat(){} // RVA: 0x7ffaa89600c0
        public void set_OriginalFormat(){} // RVA: 0x7ffaa89600d0
        public void get_ValueNames(){} // RVA: 0x7ffaa894d380
        public void FindBraceIndex(){} // RVA: 0x7ffaadd65130
        public void FindIndexOfAny(){} // RVA: 0x7ffaadd651e0
        public void Format(){} // RVA: 0x7ffaadd65a90
        public void FormatWithOverwrite(){} // RVA: 0x7ffaadd65530
        public void Format(){} // RVA: 0x7ffaadd65a90
        public void Format(){} // RVA: 0x7ffaadd65a90
        public void Format(){} // RVA: 0x7ffaadd65a90
        public void Format(){} // RVA: 0x7ffaadd65a90
        public void FormatArgument(){} // RVA: 0x7ffaadd65fc0
        public void TryFormatArgumentIfNullOrEnumerable(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaadd66040
        // ── Binary Analysis Named ──
        public void GetValue(){} // RVA: 0x7ffaadd65bc0
        public void GetValues(){} // RVA: 0x7ffaadd65d30
    }

    public class Logger : Object
    {
        public object _messageLoggers; // 0x3180ACE0, was: <MessageLoggers>k__BackingFiel
        public object _buckets; // 0x8059BF58

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void get_Loggers(){} // RVA: 0x7ffaa89357c0
        public void set_Loggers(){} // RVA: 0x7ffaa8998e80
        public void get_MessageLoggers(){} // RVA: 0x7ffaa89600c0
        public void set_MessageLoggers(){} // RVA: 0x7ffaa89600d0
        public void get_ScopeLoggers(){} // RVA: 0x7ffaa8960130
        public void set_ScopeLoggers(){} // RVA: 0x7ffaa8933e90
        public void Log(){} // RVA: 0x7ffaa887e5c0
        public void IsEnabled(){} // RVA: 0x7ffaadd67ec0
        public void ThrowLoggingError(){} // RVA: 0x7ffaadd67fa0
        public void <Log>g__LoggerLog|14_0(){} // RVA: 0x7ffaa887e5c0
        public void <IsEnabled>g__LoggerIsEnabled|15_0(){} // RVA: 0x7ffaadd68000
        // ── Binary Analysis Named ──
        public void BeginScope(){} // RVA: 0x7ffaa887e5c0
    }

    public class LoggerExternalScopeProvider : Object
    {
        public object p00; // 0x85373C80

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd63350
        public void ForEachScope(){} // RVA: 0x7ffaa887e5c0
        public void Push(){} // RVA: 0x7ffaadd633f0
        public void <ForEachScope>g__Report|2_0(){} // RVA: 0x7ffaa8660fc0
    }

    public class LoggerFactory : Object
    {
        public object _sync; // 0x35004360
        public object _filterOptions; // 0x35004360
        public object Microsoft.Extensions.Logging; // 0xB40CA0B0
        public object p00;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd68900
        public void .ctor(){} // RVA: 0x7ffaadd68900
        public void .ctor(){} // RVA: 0x7ffaadd68900
        public void .ctor(){} // RVA: 0x7ffaadd68900
        public void .ctor(){} // RVA: 0x7ffaadd68900
        public void .ctor(){} // RVA: 0x7ffaadd68900
        public void Create(){} // RVA: 0x7ffaadd69020
        public void RefreshFilters(){} // RVA: 0x7ffaadd69410
        public void CreateLogger(){} // RVA: 0x7ffaadd69870
        public void AddProvider(){} // RVA: 0x7ffaadd69d20
        public void AddProviderRegistration(){} // RVA: 0x7ffaadd6a350
        public void CreateLoggers(){} // RVA: 0x7ffaadd6a5a0
        public void ApplyFilters(){} // RVA: 0x7ffaadd6a760
        public void Dispose(){} // RVA: 0x7ffaadd6ad40
        // ── Binary Analysis Named ──
        public void CheckDisposed(){} // RVA: 0x7ffaadd6ad30
    }

    public class LoggerFactoryExtensions : Object
    {
        // ── Original Methods ──
        public void CreateLogger(){} // RVA: 0x7ffaadd63730
        public void CreateLogger(){} // RVA: 0x7ffaadd63730
    }

    public class LoggerFactoryOptions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_ActivityTrackingOptions(){} // RVA: 0x7ffaa897f5c0
    }

    public class LoggerFactoryScopeProvider : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd6aff0
        public void ForEachScope(){} // RVA: 0x7ffaa887e5c0
        public void Push(){} // RVA: 0x7ffaadd6b1a0
        public void <ForEachScope>g__Report|3_0(){} // RVA: 0x7ffaa8660fc0
        // ── Binary Analysis Named ──
        public void GetOrCreateActivityBaggageLogScopeWrapper(){} // RVA: 0x7ffaadd6b0a0
    }

    public class LoggerFilterOptions : Object
    {
        public object _rulesInternal; // 0x35004D20, was: <RulesInternal>k__BackingField
        public object Invoke; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd6cde0
        public void get_CaptureScopes(){} // RVA: 0x7ffaa89fc5e0
        public void get_MinLevel(){} // RVA: 0x7ffaa8e046c0
        public void set_MinLevel(){} // RVA: 0x7ffaa8e03640
        public void get_Rules(){} // RVA: 0x7ffaa89357c0
        public void get_RulesInternal(){} // RVA: 0x7ffaa89357c0
    }

    public class LoggerFilterRule : Object
    {
        public object _logLevel; // 0x3509F7D0, was: <LogLevel>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd6cea0
        public void get_ProviderName(){} // RVA: 0x7ffaa894d380
        public void get_CategoryName(){} // RVA: 0x7ffaa89357c0
        public void get_LogLevel(){} // RVA: 0x7ffaa89600c0
        public void get_Filter(){} // RVA: 0x7ffaa8960130
        public void ToString(){} // RVA: 0x7ffaadd6cfb0
    }

    public class LoggerInformation : ValueType
    {
        public object _providerType; // 0x35DF2A90, was: <ProviderType>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd6d520
        public void get_Logger(){} // RVA: 0x7ffaa950bda0
        public void get_Category(){} // RVA: 0x7ffaa9e47540
        public void get_ProviderType(){} // RVA: 0x7ffaa894d380
        public void get_ExternalScope(){} // RVA: 0x7ffaa894d4e0
    }

    public class LoggerMessage : Object
    {
        // ── Original Methods ──
        public void DefineScope(){} // RVA: 0x7ffaa86492c0
        public void DefineScope(){} // RVA: 0x7ffaa86492c0
        public void DefineScope(){} // RVA: 0x7ffaa86492c0
        public void DefineScope(){} // RVA: 0x7ffaa86492c0
        public void DefineScope(){} // RVA: 0x7ffaa86492c0
        public void DefineScope(){} // RVA: 0x7ffaa86492c0
        public void DefineScope(){} // RVA: 0x7ffaa86492c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void Define(){} // RVA: 0x7ffaa887e5c0
        public void CreateLogValuesFormatter(){} // RVA: 0x7ffaadd63b70
    }

    public class Logger`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Microsoft.Extensions.Logging.ILogger.BeginScope(){} // RVA: 0x7ffaa887e5c0
        public void Microsoft.Extensions.Logging.ILogger.IsEnabled(){} // RVA: 0x7ffaa864a650
        public void Microsoft.Extensions.Logging.ILogger.Log(){} // RVA: 0x7ffaa887e5c0
        public void DebuggerToString(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetCategoryName(){} // RVA: 0x7ffaa8648dd0
    }

    public class LoggingBuilder : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_Services(){} // RVA: 0x7ffaa894d380
    }

    public class MessageLogger : ValueType
    {
        public object _providerTypeFullName; // 0x35E596F0, was: <ProviderTypeFullName>k__Backi

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd6d310
        public void get_Logger(){} // RVA: 0x7ffaa950bda0
        public void get_Category(){} // RVA: 0x7ffaa9e47540
        public void get_ProviderTypeFullName(){} // RVA: 0x7ffaa894d380
        public void get_MinLevel(){} // RVA: 0x7ffaa89357c0
        public void get_Filter(){} // RVA: 0x7ffaa89600c0
        public void IsEnabled(){} // RVA: 0x7ffaadd6d470
    }

    public class NullExternalScopeProvider : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_Instance(){} // RVA: 0x7ffaadd66130
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.ForEachScope(){} // RVA: 0x7ffaa887e5c0
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.Push(){} // RVA: 0x7ffaadd66190
        public void .cctor(){} // RVA: 0x7ffaadd66230
    }

    public class ProviderAliasAttribute : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class ScopeLogger : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9bb9250
        public void get_Logger(){} // RVA: 0x7ffaa950bda0
        public void get_ExternalScopeProvider(){} // RVA: 0x7ffaa9e47540
        public void CreateScope(){} // RVA: 0x7ffaa887e5c0
    }

}