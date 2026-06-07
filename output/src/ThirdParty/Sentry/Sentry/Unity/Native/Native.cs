// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Native
// Classes: 4
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Unity.Native
{
    public class NativeContextWriter
    {
        // ── Methods ──
        public void WriteScope(){} // RVA: 0x638B9B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NativeScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x638BD90
        public void AddBreadcrumbImpl(){} // RVA: 0x638BE80
        public void SetExtraImpl(){} // RVA: 0x638C190
        public void SetTagImpl(){} // RVA: 0x638C300
        public void UnsetTagImpl(){} // RVA: 0x638C400
        public void SetUserImpl(){} // RVA: 0x638C4D0
        public void UnsetUserImpl(){} // RVA: 0x638C790
        public void GetTimestamp(){} // RVA: 0x638C830
    }

    public class SentryNative
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x638C8A0
        public void ReinstallBackend(){} // RVA: 0x638D410
        public void .cctor(){} // RVA: 0x638D5D0
    }

    public class SentryNativeBridge
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x638D830
        public void Close(){} // RVA: 0x638E490
        public void HandleCrashedLastRun(){} // RVA: 0x638E500
        public void GetCacheDirectory(){} // RVA: 0x638E5E0
        public void ReinstallBackend(){} // RVA: 0x638E6B0
        public void sentry_options_new(){} // RVA: 0x638E720
        public void sentry_options_set_dsn(){} // RVA: 0x638E790
        public void sentry_options_set_release(){} // RVA: 0x638E840
        public void sentry_options_set_debug(){} // RVA: 0x638E8F0
        public void sentry_options_set_environment(){} // RVA: 0x638E980
        public void sentry_options_set_sample_rate(){} // RVA: 0x638EA30
        public void sentry_options_set_database_path(){} // RVA: 0x638EAC0
        public void sentry_options_set_database_pathw(){} // RVA: 0x638EB70
        public void sentry_options_set_auto_session_tracking(){} // RVA: 0x638EC10
        public void sentry_options_set_logger(){} // RVA: 0x638ECA0
        public void nativeLog(){} // RVA: 0x638ED40
        public void nativeLogImpl(){} // RVA: 0x638ED60
        public void vsnprintf_windows(){} // RVA: 0x638F4A0
        public void vsnprintf_linux(){} // RVA: 0x638F550
        public void WithAllocatedPtr(){} // RVA: 0x638F600
        public void WithMarshalledStruct(){} // RVA: 0x283FA0
        public void sentry_init(){} // RVA: 0x638F730
        public void sentry_close(){} // RVA: 0x638E490
        public void sentry_get_crashed_last_run(){} // RVA: 0x638F7B0
        public void sentry_clear_crashed_last_run(){} // RVA: 0x638F820
        public void sentry_reinstall_backend(){} // RVA: 0x638E6B0
    }

}