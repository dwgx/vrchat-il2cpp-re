// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 18

namespace VRC.Core
{
    public class NativeTextureSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7648FF0
        public void ReleaseHandle(){} // RVA: 0xA7160C0
    }

    public class NetworkRegionExtensions : Object
    {
        public object US_WEST_API_STRING;
        public object US_EAST_API_STRING;
        public object JAPAN_API_STRING;
        public object EUROPE_API_STRING;
        public object US_WEST_NETWORK_STRING;
        public object US_EAST_NETWORK_STRING;
        public object JAPAN_NETWORK_STRING;
        public object EUROPE_NETWORK_STRING;
        public object US_WEST_SHORT_DISPLAY_STRING;
        public object US_EAST_SHORT_DISPLAY_STRING;
        public object JAPAN_SHORT_DISPLAY_STRING;
        public object EUROPE_SHORT_DISPLAY_STRING;
        public object US_WEST_DISPLAY_STRING;
        public object US_EAST_DISPLAY_STRING;
        public object JAPAN_DISPLAY_STRING;
        public object EUROPE_DISPLAY_STRING;
        public object US_WEST_ICON_STRING;
        public object US_EAST_ICON_STRING;
        public object JAPAN_ICON_STRING;
        public object EUROPE_ICON_STRING;

        // ── Methods ──
        public void ToNetworkRegion(){} // RVA: 0xA5C0DD0
        public void ToApiString(){} // RVA: 0xA5C0F60
        public void ToNetworkString(){} // RVA: 0xA5C1010
        public void ToShortString(){} // RVA: 0xA5C10C0
        public void ToDisplayString(){} // RVA: 0xA5C1170
        public void ToIconString(){} // RVA: 0xA5C1220
    }

    public class NullLogger : Object
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0xB43320
        public void LogOnceEvery(){} // RVA: 0xB43310
        public void LogOnceEveryFormat(){} // RVA: 0xB43310
        public void Log(){} // RVA: 0xB43310
        public void LogFormat(){} // RVA: 0xB43310
        public void LogWarning(){} // RVA: 0xB43310
        public void LogWarningFormat(){} // RVA: 0xB43310
        public void LogError(){} // RVA: 0xB43310
        public void LogErrorFormat(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

}