// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Options
// Classes: 21
// Methods: 54

namespace ThirdParty.DotNet.Microsoft.Extensions.Options
{
    public class ConfigureNamedOptions`1 : Object
    {
        public string Name;
        public System.Action`1<T> Action;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C79B30
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_Action(){} // RVA: 0x7FFAC2C58E90
        public void Configure(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class ConfigureOptions`1 : Object
    {
        public System.Action`1<T> Action;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_Action(){} // RVA: 0x7FFAC2C58E90
        public void Configure(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IConfigureNamedOptions`1
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IConfigureOptions`1
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IOptionsChangeTokenSource`1
    {
        public object Name;

        // ── Methods ──
        public void GetChangeToken(){} // RVA: 0x7FFAC2C58E90
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
    }

    public class IOptionsFactory`1
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IOptionsMonitorCache`1
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFAC2E8DC40
        public void TryRemove(){} // RVA: 0x7FFAC2C59F60
    }

    public class IOptionsMonitor`1
    {
        public object CurrentValue;

        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x7FFAC2E8DC40
        public void OnChange(){} // RVA: 0x7FFAC2C58F40
    }

    public class IOptionsSnapshot`1
    {
    }

    public class IOptions`1
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPostConfigureOptions`1
    {
        // ── Methods ──
        public void PostConfigure(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IValidateOptions`1
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Options : Object
    {
        public string DefaultName;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC834D960
    }

    public class OptionsCache`1 : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,System.Lazy`1<T>> _cache;

        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFAC2C5D200
        public void TryRemove(){} // RVA: 0x7FFAC2C59F60
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class OptionsFactory`1 : Object
    {
        public Microsoft.Extensions.Options.IConfigureOptions`1<T>[] _setups;
        public Microsoft.Extensions.Options.IPostConfigureOptions`1<T>[] _postConfigures;
        public Microsoft.Extensions.Options.IValidateOptions`1<T>[] _validations;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60 | overloaded x2
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void CreateInstance(){} // RVA: 0x7FFAC2E8DC40
    }

    public class OptionsManager`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsFactory`1<T> Value;
        public Microsoft.Extensions.Options.OptionsCache`1<T> _cache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
        public void Get(){} // RVA: 0x7FFAC2E8DC40
    }

    public class OptionsMonitorExtensions : Object
    {
        // ── Methods ──
        public void OnChange(){} // RVA: 0x7FFAC2C58FF0
    }

    public class OptionsMonitor`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsMonitorCache`1<T> CurrentValue;
        public Microsoft.Extensions.Options.IOptionsFactory`1<T> _factory;
        public System.Collections.Generic.List`1<System.IDisposable> _registrations;
        public System.Action`2<T,string> _onChange;

        // ── Methods ──
        public void add__onChange(){} // RVA: 0x7FFAC2C70A40
        public void remove__onChange(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void InvokeChanged(){} // RVA: 0x7FFAC2C70A40
        public void get_CurrentValue(){} // RVA: 0x7FFAC2E8DC40
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void OnChange(){} // RVA: 0x7FFAC2C58F40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void <.ctor>g__RegisterSource|6_0(){} // RVA: 0x7FFAC2C70A40
    }

    public class OptionsValidationException : Exception
    {
        public string Failures; // 0x90
        public System.Type Message; // 0x98
        public System.Collections.Generic.IEnumerable`1<string> <Failures>k__BackingField; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC834DA20
        public void get_Failures(){} // RVA: 0x7FFAC3543900
        public void get_Message(){} // RVA: 0x7FFAC834DC50
    }

    public class UnnamedOptionsManager`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsFactory`1<T> Value;
        public object _syncObj;
        public T _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_Value(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ValidateOptionsResult : Object
    {
        public Microsoft.Extensions.Options.ValidateOptionsResult Succeeded;
        public Microsoft.Extensions.Options.ValidateOptionsResult Skipped; // 0x8
        public bool Failed; // 0x10
        public bool Failures; // 0x11
        public bool <Failed>k__BackingField; // 0x12
        public System.Collections.Generic.IEnumerable`1<string> <Failures>k__BackingField; // 0x18

        // ── Methods ──
        public void set_Succeeded(){} // RVA: 0x7FFAC2FEB5F0
        public void set_Skipped(){} // RVA: 0x7FFAC3771D90
        public void get_Failed(){} // RVA: 0x7FFAC3AE1A90
        public void get_Failures(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC834DCA0
    }

}