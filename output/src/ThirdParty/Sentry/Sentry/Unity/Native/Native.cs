// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Native
// Classes: 4
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Unity.Native
{
    public class NativeContextWriter : ContextWriter
    {
        // ── Methods ──
        public void WriteScope(){} // RVA: 0x6DF8E90
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NativeScopeObserver : ScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DF9270
        public void AddBreadcrumbImpl(){} // RVA: 0x6DF9360
        public void SetExtraImpl(){} // RVA: 0x6DF9670
        public void SetTagImpl(){} // RVA: 0x6DF97E0
        public void UnsetTagImpl(){} // RVA: 0x6DF98E0
        public void SetUserImpl(){} // RVA: 0x6DF99B0
        public void UnsetUserImpl(){} // RVA: 0x6DF9C70
        public void GetTimestamp(){} // RVA: 0x6DF9D10
    }

    public class SentryNative : Object
    {
        public object PerDirectoryCrashInfo;
        public object ShouldReinstallBackend;
        public object Logger;

        // ── Methods ──
        public void Configure(){} // RVA: 0x6DF9D80
        public void ReinstallBackend(){} // RVA: 0x6DFA890
        public void .cctor(){} // RVA: 0x6DFAA50
    }

    public class SentryNativeBridge : Object
    {
        public object _logger;
        public object _isLinux;

        // ── Methods ──
        public void Init(){} // RVA: 0x6DFACB0
        public void Close(){} // RVA: 0x6DFB910
        public void HandleCrashedLastRun(){} // RVA: 0x6DFB980
        public void GetCacheDirectory(){} // RVA: 0x6DFBA60
        public void ReinstallBackend(){} // RVA: 0x6DFBB30
        public void sentry_options_new(){} // RVA: 0x6DFBBA0
        public void sentry_options_set_dsn(){} // RVA: 0x6DFBC10
        public void sentry_options_set_release(){} // RVA: 0x6DFBCC0
        public void sentry_options_set_debug(){} // RVA: 0x6DFBD70
        public void sentry_options_set_environment(){} // RVA: 0x6DFBE00
        public void sentry_options_set_sample_rate(){} // RVA: 0x6DFBEB0
        public void sentry_options_set_database_path(){} // RVA: 0x6DFBF40
        public void sentry_options_set_database_pathw(){} // RVA: 0x6DFBFF0
        public void sentry_options_set_auto_session_tracking(){} // RVA: 0x6DFC090
        public void sentry_options_set_logger(){} // RVA: 0x6DFC120
        public void nativeLog(){} // RVA: 0x6DFC1C0
        public void nativeLogImpl(){} // RVA: 0x6DFC1E0
        public void vsnprintf_windows(){} // RVA: 0x6DFC8C0
        public void vsnprintf_linux(){} // RVA: 0x6DFC970
        public void WithAllocatedPtr(){} // RVA: 0x6DFCA20
        public void WithMarshalledStruct(){} // RVA: 0xA94080
        public void sentry_init(){} // RVA: 0x6DFCB50
        public void sentry_close(){} // RVA: 0x6DFB910
        public void sentry_get_crashed_last_run(){} // RVA: 0x6DFCBD0
        public void sentry_clear_crashed_last_run(){} // RVA: 0x6DFCC40
        public void sentry_reinstall_backend(){} // RVA: 0x6DFBB30
    }

}