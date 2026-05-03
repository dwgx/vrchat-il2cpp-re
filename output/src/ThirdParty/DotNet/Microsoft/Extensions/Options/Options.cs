// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Options
// Classes: 21
// Methods: 54

namespace ThirdParty.DotNet.Microsoft.Extensions.Options
{
    public class ConfigureNamedOptions`1 : Object
    {
        public string _name;
        public System.Action`1<T> _action;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4F230
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_Action(){} // RVA: 0x7FFE80E2E2E0
        public void Configure(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class ConfigureOptions`1 : Object
    {
        public System.Action`1<T> _action;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Action(){} // RVA: 0x7FFE80E2E2E0
        public void Configure(){} // RVA: 0x7FFE810A1420
    }

    public class IConfigureNamedOptions`1
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFE810A1420
    }

    public class IConfigureOptions`1
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFE810A1420
    }

    public class IOptionsChangeTokenSource`1
    {
        // ── Methods ──
        public void GetChangeToken(){} // RVA: 0x7FFE80E2E2E0
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IOptionsFactory`1
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420
    }

    public class IOptionsMonitorCache`1
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFE810A1420
        public void TryRemove(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IOptionsMonitor`1
    {
        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x7FFE810A1420
        public void OnChange(){} // RVA: 0x7FFE80E2E390
    }

    public class IOptionsSnapshot`1
    {
    }

    public class IOptions`1
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE810A1420
    }

    public class IPostConfigureOptions`1
    {
        // ── Methods ──
        public void PostConfigure(){} // RVA: 0x7FFE810A1420
    }

    public class IValidateOptions`1
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x7FFE810A1420
    }

    public class Options : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE866F7260
    }

    public class OptionsCache`1 : Object
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryGetValue(){} // RVA: 0x7FFE80E32650
        public void TryRemove(){} // RVA: 0x7FFE80E2F3B0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class OptionsFactory`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E50660 | overloaded x2
        public void Create(){} // RVA: 0x7FFE810A1420
        public void CreateInstance(){} // RVA: 0x7FFE810A1420
    }

    public class OptionsManager`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsFactory`1<T> _factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Value(){} // RVA: 0x7FFE810A1420
        public void Get(){} // RVA: 0x7FFE810A1420
    }

    public class OptionsMonitorExtensions : Object
    {
        // ── Methods ──
        public void OnChange(){} // RVA: 0x7FFE80E2E440
    }

    public class OptionsMonitor`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsMonitorCache`1<T> _cache;

        // ── Methods ──
        public void add__onChange(){} // RVA: 0x7FFE80E460A0
        public void remove__onChange(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E50660
        public void InvokeChanged(){} // RVA: 0x7FFE80E460A0
        public void get_CurrentValue(){} // RVA: 0x7FFE810A1420
        public void Get(){} // RVA: 0x7FFE810A1420
        public void OnChange(){} // RVA: 0x7FFE80E2E390
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void <.ctor>g__RegisterSource|6_0(){} // RVA: 0x7FFE80E460A0
    }

    public class OptionsValidationException : Exception
    {
        public string _optionsName; // 0x90
        public System.Type _optionsType; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F7320
        public void get_Failures(){} // RVA: 0x7FFE8179C860
        public void get_Message(){} // RVA: 0x7FFE866F7550
    }

    public class UnnamedOptionsManager`1 : Object
    {
        public Microsoft.Extensions.Options.IOptionsFactory`1<T> _factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Value(){} // RVA: 0x7FFE810A1420
    }

    public class ValidateOptionsResult : Object
    {
        public Microsoft.Extensions.Options.ValidateOptionsResult Skip;
        public Microsoft.Extensions.Options.ValidateOptionsResult Success; // 0x8
        public bool _succeeded; // 0x10
        public bool _skipped; // 0x11

        // ── Methods ──
        public void set_Succeeded(){} // RVA: 0x7FFE811C55F0
        public void set_Skipped(){} // RVA: 0x7FFE813471A0
        public void get_Failed(){} // RVA: 0x7FFE826E3520
        public void get_Failures(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE866F75A0
    }

}