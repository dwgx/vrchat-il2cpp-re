// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging
// Classes: 27
// Methods: 147

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging
{
    public class DefaultLoggerLevelConfigureOptions : ConfigureOptions`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53766780
    }

    public class EventId : ValueType
    {
        public object Id;
        public object Name;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x7FFD5375FDC0
        public void op_Equality(){} // RVA: 0x7FFD5375FE20
        public void op_Inequality(){} // RVA: 0x7FFD5375FE30
        public void .ctor(){} // RVA: 0x7FFD515124C0
        public void get_Id(){} // RVA: 0x7FFD4F840210
        public void get_Name(){} // RVA: 0x7FFD4F840220
        public void ToString(){} // RVA: 0x7FFD5375FE40
        public void Equals(){} // RVA: 0x7FFD5375FEF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
    }

    public class FilterLoggingBuilderExtensions : Object
    {
        // ── Methods ──
        public void AddFilter(){} // RVA: 0x7FFD53766A10 | overloaded x2
        public void ConfigureFilter(){} // RVA: 0x7FFD53766A40
        public void AddRule(){} // RVA: 0x7FFD53766AC0
    }

    public class IExternalScopeProvider
    {
        // ── Methods ──
        public void ForEachScope(){} // RVA: 0x7FFD4E2ADC40
        public void Push(){} // RVA: 0x7FFD4E078F40
    }

    public class ILogger
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFD4E2ADC40
        public void IsEnabled(){} // RVA: 0x7FFD4E07A310
        public void BeginScope(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ILoggerFactory
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFD4E078F40
        public void AddProvider(){} // RVA: 0x7FFD4E090A40
    }

    public class ILoggerProvider
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFD4E078F40
    }

    public class ILogger`1
    {
    }

    public class ILoggingBuilder
    {
        public object Services;

        // ── Methods ──
        public void get_Services(){} // RVA: 0x7FFD4E078E90
    }

    public class ISupportExternalScope
    {
        // ── Methods ──
        public void SetScopeProvider(){} // RVA: 0x7FFD4E090A40
    }

    public class LogValuesFormatter : Object
    {
        public object OriginalFormat;
        public object ValueNames;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537638E0
        public void get_OriginalFormat(){} // RVA: 0x7FFD4E36F0C0
        public void set_OriginalFormat(){} // RVA: 0x7FFD4E36F0D0
        public void get_ValueNames(){} // RVA: 0x7FFD4E35C380
        public void FindBraceIndex(){} // RVA: 0x7FFD53763F80
        public void FindIndexOfAny(){} // RVA: 0x7FFD53764030
        public void Format(){} // RVA: 0x7FFD537648E0 | overloaded x5
        public void FormatWithOverwrite(){} // RVA: 0x7FFD53764380
        public void GetValue(){} // RVA: 0x7FFD53764A10
        public void GetValues(){} // RVA: 0x7FFD53764B80
        public void FormatArgument(){} // RVA: 0x7FFD53764E10
        public void TryFormatArgumentIfNullOrEnumerable(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD53764E90
    }

    public class Logger : Object
    {
        public object Loggers;
        public object MessageLoggers;
        public object ScopeLoggers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void get_Loggers(){} // RVA: 0x7FFD4E3447C0
        public void set_Loggers(){} // RVA: 0x7FFD4E3A7E80
        public void get_MessageLoggers(){} // RVA: 0x7FFD4E36F0C0
        public void set_MessageLoggers(){} // RVA: 0x7FFD4E36F0D0
        public void get_ScopeLoggers(){} // RVA: 0x7FFD4E36F130
        public void set_ScopeLoggers(){} // RVA: 0x7FFD4E342E90
        public void Log(){} // RVA: 0x7FFD4E2ADC40
        public void IsEnabled(){} // RVA: 0x7FFD53766D10
        public void BeginScope(){} // RVA: 0x7FFD4E2ADC40
        public void ThrowLoggingError(){} // RVA: 0x7FFD53766DF0
        public void <Log>g__LoggerLog|14_0(){} // RVA: 0x7FFD4E2ADC40
        public void <IsEnabled>g__LoggerIsEnabled|15_0(){} // RVA: 0x7FFD53766E50
    }

    public class LoggerExternalScopeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537621A0
        public void ForEachScope(){} // RVA: 0x7FFD4E2ADC40
        public void Push(){} // RVA: 0x7FFD53762240
        public void <ForEachScope>g__Report|2_0(){} // RVA: 0x7FFD4E090C80
    }

    public class LoggerFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53767750 | overloaded x6
        public void Create(){} // RVA: 0x7FFD53767E70
        public void RefreshFilters(){} // RVA: 0x7FFD53768260
        public void CreateLogger(){} // RVA: 0x7FFD537686C0
        public void AddProvider(){} // RVA: 0x7FFD53768B70
        public void AddProviderRegistration(){} // RVA: 0x7FFD537691A0
        public void CreateLoggers(){} // RVA: 0x7FFD537693F0
        public void ApplyFilters(){} // RVA: 0x7FFD537695B0
        public void CheckDisposed(){} // RVA: 0x7FFD53769B80
        public void Dispose(){} // RVA: 0x7FFD53769B90
    }

    public class LoggerFactoryExtensions : Object
    {
        // ── Methods ──
        public void CreateLogger(){} // RVA: 0x7FFD53762580 | overloaded x2
    }

    public class LoggerFactoryOptions : Object
    {
        public object ActivityTrackingOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_ActivityTrackingOptions(){} // RVA: 0x7FFD4E38E5C0
    }

    public class LoggerFactoryScopeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53769E40
        public void ForEachScope(){} // RVA: 0x7FFD4E2ADC40
        public void GetOrCreateActivityBaggageLogScopeWrapper(){} // RVA: 0x7FFD53769EF0
        public void Push(){} // RVA: 0x7FFD53769FF0
        public void <ForEachScope>g__Report|3_0(){} // RVA: 0x7FFD4E090C80
    }

    public class LoggerFilterOptions : Object
    {
        public object CaptureScopes;
        public object MinLevel;
        public object Rules;
        public object RulesInternal;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5376BC30
        public void get_CaptureScopes(){} // RVA: 0x7FFD4E40B5E0
        public void get_MinLevel(){} // RVA: 0x7FFD4E7F5A20
        public void set_MinLevel(){} // RVA: 0x7FFD4E7F4990
        public void get_Rules(){} // RVA: 0x7FFD4E3447C0
        public void get_RulesInternal(){} // RVA: 0x7FFD4E3447C0
    }

    public class LoggerFilterRule : Object
    {
        public object ProviderName;
        public object CategoryName;
        public object LogLevel;
        public object Filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5376BCF0
        public void get_ProviderName(){} // RVA: 0x7FFD4E35C380
        public void get_CategoryName(){} // RVA: 0x7FFD4E3447C0
        public void get_LogLevel(){} // RVA: 0x7FFD4E36F0C0
        public void get_Filter(){} // RVA: 0x7FFD4E36F130
        public void ToString(){} // RVA: 0x7FFD5376BE00
    }

    public class LoggerInformation : ValueType
    {
        public object Logger;
        public object Category;
        public object ProviderType;
        public object ExternalScope;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5376C370
        public void get_Logger(){} // RVA: 0x7FFD4EEF9F60
        public void get_Category(){} // RVA: 0x7FFD4F840220
        public void get_ProviderType(){} // RVA: 0x7FFD4E35C380
        public void get_ExternalScope(){} // RVA: 0x7FFD4E35C4E0
    }

    public class LoggerMessage : Object
    {
        // ── Methods ──
        public void DefineScope(){} // RVA: 0x7FFD4E078F80 | overloaded x7
        public void Define(){} // RVA: 0x7FFD4E2ADC40 | overloaded x14
        public void CreateLogValuesFormatter(){} // RVA: 0x7FFD537629C0
    }

    public class Logger`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Microsoft.Extensions.Logging.ILogger.BeginScope(){} // RVA: 0x7FFD4E2ADC40
        public void Microsoft.Extensions.Logging.ILogger.IsEnabled(){} // RVA: 0x7FFD4E07A310
        public void Microsoft.Extensions.Logging.ILogger.Log(){} // RVA: 0x7FFD4E2ADC40
        public void GetCategoryName(){} // RVA: 0x7FFD4E078A90
        public void DebuggerToString(){} // RVA: 0x7FFD4E078E90
    }

    public class LoggingBuilder : Object
    {
        public object Services;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void get_Services(){} // RVA: 0x7FFD4E35C380
    }

    public class MessageLogger : ValueType
    {
        public object Logger;
        public object Category;
        public object ProviderTypeFullName;
        public object MinLevel;
        public object Filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5376C160
        public void get_Logger(){} // RVA: 0x7FFD4EEF9F60
        public void get_Category(){} // RVA: 0x7FFD4F840220
        public void get_ProviderTypeFullName(){} // RVA: 0x7FFD4E35C380
        public void get_MinLevel(){} // RVA: 0x7FFD4E3447C0
        public void get_Filter(){} // RVA: 0x7FFD4E36F0C0
        public void IsEnabled(){} // RVA: 0x7FFD5376C2C0
    }

    public class NullExternalScopeProvider : Object
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_Instance(){} // RVA: 0x7FFD53764F80
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.ForEachScope(){} // RVA: 0x7FFD4E2ADC40
        public void Microsoft.Extensions.Logging.IExternalScopeProvider.Push(){} // RVA: 0x7FFD53764FE0
        public void .cctor(){} // RVA: 0x7FFD53765080
    }

    public class ProviderAliasAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class ScopeLogger : ValueType
    {
        public object Logger;
        public object ExternalScopeProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F5CE4B0
        public void get_Logger(){} // RVA: 0x7FFD4EEF9F60
        public void get_ExternalScopeProvider(){} // RVA: 0x7FFD4F840220
        public void CreateScope(){} // RVA: 0x7FFD4E2ADC40
    }

}