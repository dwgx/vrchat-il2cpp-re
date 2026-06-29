// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Native
// Classes: 4
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Unity.Native
{
    public class NativeContextWriter : ContextWriter
    {
        // ── Methods ──
        public void WriteScope(){} // RVA: 0x7AE178460
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NativeScopeObserver : ScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE178840
        public void AddBreadcrumbImpl(){} // RVA: 0x7AE178930
        public void SetExtraImpl(){} // RVA: 0x7AE178C40
        public void SetTagImpl(){} // RVA: 0x7AE178DB0
        public void UnsetTagImpl(){} // RVA: 0x7AE178EB0
        public void SetUserImpl(){} // RVA: 0x7AE178F80
        public void UnsetUserImpl(){} // RVA: 0x7AE179240
        public void GetTimestamp(){} // RVA: 0x7AE1792E0
    }

    public class SentryNative : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7AE179350
        public void ReinstallBackend(){} // RVA: 0x7AE179E90
        public void .cctor(){} // RVA: 0x7AE17A050
    }

    public class SentryNativeBridge : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7AE17A2B0
        public void Close(){} // RVA: 0x7AE17AF10
        public void HandleCrashedLastRun(){} // RVA: 0x7AE17AF80
        public void GetCacheDirectory(){} // RVA: 0x7AE17B060
        public void ReinstallBackend(){} // RVA: 0x7AE17B130
        public void sentry_options_new(){} // RVA: 0x7AE17B1A0
        public void sentry_options_set_dsn(){} // RVA: 0x7AE17B210
        public void sentry_options_set_release(){} // RVA: 0x7AE17B2C0
        public void sentry_options_set_debug(){} // RVA: 0x7AE17B370
        public void sentry_options_set_environment(){} // RVA: 0x7AE17B400
        public void sentry_options_set_sample_rate(){} // RVA: 0x7AE17B4B0
        public void sentry_options_set_database_path(){} // RVA: 0x7AE17B540
        public void sentry_options_set_database_pathw(){} // RVA: 0x7AE17B5F0
        public void sentry_options_set_auto_session_tracking(){} // RVA: 0x7AE17B690
        public void sentry_options_set_logger(){} // RVA: 0x7AE17B720
        public void nativeLog(){} // RVA: 0x7AE17B7C0
        public void nativeLogImpl(){} // RVA: 0x7AE17B7E0
        public void vsnprintf_windows(){} // RVA: 0x7AE17BF10
        public void vsnprintf_linux(){} // RVA: 0x7AE17BFC0
        public void WithAllocatedPtr(){} // RVA: 0x7AE17C070
        public void WithMarshalledStruct(){} // RVA: 0x7A8051B10
        public void sentry_init(){} // RVA: 0x7AE17C1A0
        public void sentry_close(){} // RVA: 0x7AE17AF10
        public void sentry_get_crashed_last_run(){} // RVA: 0x7AE17C220
        public void sentry_clear_crashed_last_run(){} // RVA: 0x7AE17C290
        public void sentry_reinstall_backend(){} // RVA: 0x7AE17B130
    }

}