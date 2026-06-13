// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Logger
// Classes: 2
// Methods: 36

namespace ThirdParty.BestHTTP.BestHTTP.Logger
{
    public class DefaultLogger
    {
        public 0x657C31E8 <Level>k__BackingField; // 0x10
        public string <FormatVerbose>k__BackingField; // 0x18
        public string <FormatInfo>k__BackingField; // 0x20
        public string <FormatWarn>k__BackingField; // 0x28
        public string <FormatErr>k__BackingField; // 0x30
        public string <FormatEx>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Level(){} // RVA: 0x3A75E0
        public void set_Level(){} // RVA: 0x3A75F0
        public void get_FormatVerbose(){} // RVA: 0x2E07C0
        public void set_FormatVerbose(){} // RVA: 0x343E80
        public void get_FormatInfo(){} // RVA: 0x30B0C0
        public void set_FormatInfo(){} // RVA: 0x30B0D0
        public void get_FormatWarn(){} // RVA: 0x30B130
        public void set_FormatWarn(){} // RVA: 0x2DEE90
        public void get_FormatErr(){} // RVA: 0x6374D0
        public void set_FormatErr(){} // RVA: 0x30B890
        public void get_FormatEx(){} // RVA: 0x4976A0
        public void set_FormatEx(){} // RVA: 0x49B830
        public void .ctor(){} // RVA: 0x97FE330
        public void Verbose(){} // RVA: 0x97FE5F0
        public void Information(){} // RVA: 0x97FE6E0
        public void Warning(){} // RVA: 0x97FE7D0
        public void Error(){} // RVA: 0x97FE8C0
        public void Exception(){} // RVA: 0x97FE9B0
        public void GetFormattedTime(){} // RVA: 0x97FEE00
    }

    public class ILogger
    {
        // ── Methods ──
        public void get_Level(){} // RVA: 0xDBE0
        public void set_Level(){} // RVA: 0x25130
        public void get_FormatVerbose(){} // RVA: 0xCD60
        public void set_FormatVerbose(){} // RVA: 0x24B10
        public void get_FormatInfo(){} // RVA: 0xCD60
        public void set_FormatInfo(){} // RVA: 0x24B10
        public void get_FormatWarn(){} // RVA: 0xCD60
        public void set_FormatWarn(){} // RVA: 0x24B10
        public void get_FormatErr(){} // RVA: 0xCD60
        public void set_FormatErr(){} // RVA: 0x24B10
        public void get_FormatEx(){} // RVA: 0xCD60
        public void set_FormatEx(){} // RVA: 0x24B10
        public void Verbose(){} // RVA: 0x2DC60
        public void Information(){} // RVA: 0x2DC60
        public void Warning(){} // RVA: 0x2DC60
        public void Error(){} // RVA: 0x2DC60
        public void Exception(){} // RVA: 0x2F090
    }

}