// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Options
// Classes: 21
// Methods: 54

namespace ThirdParty.DotNet.Microsoft.Extensions.Options
{
    public class ConfigureNamedOptions`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DC60
        public void get_Name(){} // RVA: 0xCD60
        public void get_Action(){} // RVA: 0xCD60
        public void Configure(){} // RVA: 0x283FA0 | overloaded x2
    }

    public class ConfigureOptions`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_Action(){} // RVA: 0xCD60
        public void Configure(){} // RVA: 0x283FA0
    }

    public class IConfigureNamedOptions`1
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x283FA0
    }

    public class IConfigureOptions`1
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x283FA0
    }

    public class IOptionsChangeTokenSource`1
    {
        // ── Methods ──
        public void GetChangeToken(){} // RVA: 0xCD60
        public void get_Name(){} // RVA: 0xCD60
    }

    public class IOptionsFactory`1
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x283FA0
    }

    public class IOptionsMonitorCache`1
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x283FA0
        public void TryRemove(){} // RVA: 0xDE40
    }

    public class IOptionsMonitor`1
    {
        // ── Methods ──
        public void get_CurrentValue(){} // RVA: 0x283FA0
        public void OnChange(){} // RVA: 0xCE10
    }

    public class IOptionsSnapshot`1
    {
    }

    public class IOptions`1
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x283FA0
    }

    public class IPostConfigureOptions`1
    {
        // ── Methods ──
        public void PostConfigure(){} // RVA: 0x283FA0
    }

    public class IValidateOptions`1
    {
        // ── Methods ──
        public void Validate(){} // RVA: 0x283FA0
    }

    public class Options
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x5BB6410
    }

    public class OptionsCache`1
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x283FA0 | overloaded x2
        public void TryGetValue(){} // RVA: 0x11120
        public void TryRemove(){} // RVA: 0xDE40
        public void .ctor(){} // RVA: 0x24A50
    }

    public class OptionsFactory`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2F090 | overloaded x2
        public void Create(){} // RVA: 0x283FA0
        public void CreateInstance(){} // RVA: 0x283FA0
    }

    public class OptionsManager`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_Value(){} // RVA: 0x283FA0
        public void Get(){} // RVA: 0x283FA0
    }

    public class OptionsMonitorExtensions
    {
        // ── Methods ──
        public void OnChange(){} // RVA: 0xCEC0
    }

    public class OptionsMonitor`1
    {
        // ── Methods ──
        public void add__onChange(){} // RVA: 0x24B10
        public void remove__onChange(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x2F090
        public void InvokeChanged(){} // RVA: 0x24B10
        public void get_CurrentValue(){} // RVA: 0x283FA0
        public void Get(){} // RVA: 0x283FA0
        public void OnChange(){} // RVA: 0xCE10
        public void Dispose(){} // RVA: 0x24A50
        public void <.ctor>g__RegisterSource|6_0(){} // RVA: 0x24B10
    }

    public class OptionsValidationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BB64D0
        public void get_Failures(){} // RVA: 0xA085E0
        public void get_Message(){} // RVA: 0x5BB6700
    }

    public class UnnamedOptionsManager`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_Value(){} // RVA: 0x283FA0
    }

    public class ValidateOptionsResult
    {
        public object PW00;

        // ── Methods ──
        public void set_Succeeded(){} // RVA: 0x3A75F0
        public void set_Skipped(){} // RVA: 0x543470
        public void get_Failed(){} // RVA: 0x195A940
        public void get_Failures(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5BB6750
    }

}