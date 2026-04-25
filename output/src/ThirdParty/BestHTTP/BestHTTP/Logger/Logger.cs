// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.Logger
// Classes: 2
// Methods: 36

namespace ThirdParty.BestHTTP.BestHTTP.Logger
{
    public class DefaultLogger : Object
    {
        public 0x6B0A9448 Level; // 0x10
        public string FormatVerbose; // 0x18
        public string FormatInfo; // 0x20
        public string FormatWarn; // 0x28
        public string FormatErr; // 0x30
        public string FormatEx; // 0x38

        // ── Methods ──
        public void get_Level(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Level(){} // RVA: 0x7FFAC2FEB5F0
        public void get_FormatVerbose(){} // RVA: 0x7FFAC2F247C0
        public void set_FormatVerbose(){} // RVA: 0x7FFAC2F87E80
        public void get_FormatInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void set_FormatInfo(){} // RVA: 0x7FFAC2F4F0D0
        public void get_FormatWarn(){} // RVA: 0x7FFAC2F4F130
        public void set_FormatWarn(){} // RVA: 0x7FFAC2F22E90
        public void get_FormatErr(){} // RVA: 0x7FFAC31D95E0
        public void set_FormatErr(){} // RVA: 0x7FFAC2F4F890
        public void get_FormatEx(){} // RVA: 0x7FFAC31D0140
        public void set_FormatEx(){} // RVA: 0x7FFAC31D0C20
        public void .ctor(){} // RVA: 0x7FFACBE07110
        public void Verbose(){} // RVA: 0x7FFACBE073D0
        public void Information(){} // RVA: 0x7FFACBE074C0
        public void Warning(){} // RVA: 0x7FFACBE075B0
        public void Error(){} // RVA: 0x7FFACBE076A0
        public void Exception(){} // RVA: 0x7FFACBE07790
        public void GetFormattedTime(){} // RVA: 0x7FFACBE07BE0
    }

    public class ILogger
    {
        public object Level;
        public object FormatVerbose;
        public object FormatInfo;
        public object FormatWarn;
        public object FormatErr;
        public object FormatEx;

        // ── Methods ──
        public void get_Level(){} // RVA: 0x7FFAC2C59D00
        public void set_Level(){} // RVA: 0x7FFAC2C71060
        public void get_FormatVerbose(){} // RVA: 0x7FFAC2C58E90
        public void set_FormatVerbose(){} // RVA: 0x7FFAC2C70A40
        public void get_FormatInfo(){} // RVA: 0x7FFAC2C58E90
        public void set_FormatInfo(){} // RVA: 0x7FFAC2C70A40
        public void get_FormatWarn(){} // RVA: 0x7FFAC2C58E90
        public void set_FormatWarn(){} // RVA: 0x7FFAC2C70A40
        public void get_FormatErr(){} // RVA: 0x7FFAC2C58E90
        public void set_FormatErr(){} // RVA: 0x7FFAC2C70A40
        public void get_FormatEx(){} // RVA: 0x7FFAC2C58E90
        public void set_FormatEx(){} // RVA: 0x7FFAC2C70A40
        public void Verbose(){} // RVA: 0x7FFAC2C79B30
        public void Information(){} // RVA: 0x7FFAC2C79B30
        public void Warning(){} // RVA: 0x7FFAC2C79B30
        public void Error(){} // RVA: 0x7FFAC2C79B30
        public void Exception(){} // RVA: 0x7FFAC2C7AF60
    }

}