// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Native
// Classes: 2
// Methods: 29

namespace ThirdParty.Sentry.Sentry.Unity.Native
{
    public class SentryNative : Object
    {
        public object Logger; // 0x34DA9220

        // ── Original Methods ──
        public void Configure(){} // RVA: 0x7ffaae544e50
        public void ReinstallBackend(){} // RVA: 0x7ffaae5459c0
        public void .cctor(){} // RVA: 0x7ffaae545b80
    }

    public class SentryNativeBridge : Object
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaae545de0
        public void Close(){} // RVA: 0x7ffaae546a40
        public void HandleCrashedLastRun(){} // RVA: 0x7ffaae546ab0
        public void ReinstallBackend(){} // RVA: 0x7ffaae546c60
        public void sentry_options_new(){} // RVA: 0x7ffaae546cd0
        public void sentry_options_set_dsn(){} // RVA: 0x7ffaae546d40
        public void sentry_options_set_release(){} // RVA: 0x7ffaae546df0
        public void sentry_options_set_debug(){} // RVA: 0x7ffaae546ea0
        public void sentry_options_set_environment(){} // RVA: 0x7ffaae546f30
        public void sentry_options_set_sample_rate(){} // RVA: 0x7ffaae546fe0
        public void sentry_options_set_database_path(){} // RVA: 0x7ffaae547070
        public void sentry_options_set_database_pathw(){} // RVA: 0x7ffaae547120
        public void sentry_options_set_auto_session_tracking(){} // RVA: 0x7ffaae5471c0
        public void sentry_options_set_logger(){} // RVA: 0x7ffaae547250
        public void nativeLog(){} // RVA: 0x7ffaae5472f0
        public void nativeLogImpl(){} // RVA: 0x7ffaae547310
        public void vsnprintf_windows(){} // RVA: 0x7ffaae547a50
        public void vsnprintf_linux(){} // RVA: 0x7ffaae547b00
        public void WithAllocatedPtr(){} // RVA: 0x7ffaae547bb0
        public void WithMarshalledStruct(){} // RVA: 0x7ffaa887e5c0
        public void sentry_init(){} // RVA: 0x7ffaae547ce0
        public void sentry_close(){} // RVA: 0x7ffaae546a40
        public void sentry_get_crashed_last_run(){} // RVA: 0x7ffaae547d60
        public void sentry_clear_crashed_last_run(){} // RVA: 0x7ffaae547dd0
        public void sentry_reinstall_backend(){} // RVA: 0x7ffaae546c60
        // ── Binary Analysis Named ──
        public void GetCacheDirectory(){} // RVA: 0x7ffaae546b90
    }

}