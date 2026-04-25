// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Options
// Classes: 19
// Methods: 45

namespace ThirdParty.DotNet.Microsoft.Extensions.Options
{
    public class ConfigureNamedOptions`1 : Object
    {
        public string Name; // 0x10
        public System.Action`1<Microsoft.Extensions.Logging.LoggerFilterOptions> Action; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E099B30
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void get_Action(){} // RVA: 0x7FFD4E078E90
        public void Configure(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class ConfigureOptions`1 : Object
    {
        public System.Action`1<Microsoft.Extensions.Logging.LoggerFilterOptions> Action; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Action(){} // RVA: 0x7FFD4E078E90
        public void Configure(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IConfigureNamedOptions`1
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IConfigureOptions`1
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IOptionsChangeTokenSource`1
    {
        public <>c<T> Name;

        // ── Methods ──
        public void GetChangeToken(){} // RVA: 0x7FFD4E078E90
        public void get_Name(){} // RVA: 0x7FFD4E078E90
    }

    public class IOptionsFactory`1
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IOptionsMonitorCache`1
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFD4E2ADC40
        public void TryRemove(){} // RVA: 0x7FFD4E079F60
    }

    public class IOptionsMonitor`1
    {
        public T CurrentValue;

        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x7FFD4E2ADC40
        public void OnChange(){} // RVA: 0x7FFD4E078F40
    }

    public class IOptionsSnapshot`1
    {
    }

    public class IOptions`1
    {
        public int Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IPostConfigureOptions`1
    {
        // ── Methods ──
        public void PostConfigure(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IValidateOptions`1
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Options : Object
    {
        public string DefaultName;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD5376D960
    }

    public class OptionsCache`1 : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,System.Lazy`1<Microsoft.Extensions.Logging.LoggerFilterOptions>> _cache; // 0x10

        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFD4E07D200
        public void TryRemove(){} // RVA: 0x7FFD4E079F60
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class OptionsFactory`1 : Object
    {
        public Microsoft.Extensions.Options.IConfigureOptions`1<Microsoft.Extensions.Logging.LoggerFactoryOptions>[] _setups; // 0x10
        public Microsoft.Extensions.Options.IPostConfigureOptions`1<Microsoft.Extensions.Logging.LoggerFactoryOptions>[] _postConfigures; // 0x18
        public Microsoft.Extensions.Options.IValidateOptions`1<Microsoft.Extensions.Logging.LoggerFactoryOptions>[] _validations; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E09AF60 | overloaded x2
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void CreateInstance(){} // RVA: 0x7FFD4E2ADC40
    }

    public class OptionsManager`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsFactory`1<T> Value;
        public Microsoft.Extensions.Options.OptionsCache`1<T> _cache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
        public void Get(){} // RVA: 0x7FFD4E2ADC40
    }

    public class OptionsMonitorExtensions : Object
    {
        // ── Methods ──
        public void OnChange(){} // RVA: 0x7FFD4E078FF0
    }

    public class OptionsMonitor`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsMonitorCache`1<Microsoft.Extensions.Logging.LoggerFilterOptions> CurrentValue; // 0x10
        public Microsoft.Extensions.Options.IOptionsFactory`1<Microsoft.Extensions.Logging.LoggerFilterOptions> _factory; // 0x18
        public System.Collections.Generic.List`1<System.IDisposable> _registrations; // 0x20
        public System.Action`2<Microsoft.Extensions.Logging.LoggerFilterOptions,string> _onChange; // 0x28

        // ── Methods ──
        public void add__onChange(){} // RVA: 0x7FFD4E090A40
        public void remove__onChange(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E09AF60
        public void InvokeChanged(){} // RVA: 0x7FFD4E090A40
        public void get_CurrentValue(){} // RVA: 0x7FFD4E2ADC40
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void OnChange(){} // RVA: 0x7FFD4E078F40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void <.ctor>g__RegisterSource|6_0(){} // RVA: 0x7FFD4E090A40
    }

    public class UnnamedOptionsManager`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsFactory`1<Microsoft.Extensions.Logging.LoggerFactoryOptions> Value; // 0x10
        public System.Runtime.CompilerServices.AsyncIteratorMethodBuilder _syncObj; // 0x18
        public Microsoft.Extensions.Logging.LoggerFactoryOptions _value; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Value(){} // RVA: 0x7FFD4E2ADC40
    }

}