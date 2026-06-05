// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Native
// Classes: 4
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Unity.Native
{
    public class NativeContextWriter
    {
        // ── Methods ──
        public void WriteScope(){} // RVA: 0x7FFAF8E3B9B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class NativeScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E3BD90
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFAF8E3BE80
        public void SetExtraImpl(){} // RVA: 0x7FFAF8E3C190
        public void SetTagImpl(){} // RVA: 0x7FFAF8E3C300
        public void UnsetTagImpl(){} // RVA: 0x7FFAF8E3C400
        public void SetUserImpl(){} // RVA: 0x7FFAF8E3C4D0
        public void UnsetUserImpl(){} // RVA: 0x7FFAF8E3C790
        public void GetTimestamp(){} // RVA: 0x7FFAF8E3C830
    }

    public class SentryNative
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAF8E3C8A0
        public void ReinstallBackend(){} // RVA: 0x7FFAF8E3D410
        public void .cctor(){} // RVA: 0x7FFAF8E3D5D0
    }

    public class SentryNativeBridge
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF8E3D830
        public void Close(){} // RVA: 0x7FFAF8E3E490
        public void HandleCrashedLastRun(){} // RVA: 0x7FFAF8E3E500
        public void GetCacheDirectory(){} // RVA: 0x7FFAF8E3E5E0
        public void ReinstallBackend(){} // RVA: 0x7FFAF8E3E6B0
        public void sentry_options_new(){} // RVA: 0x7FFAF8E3E720
        public void sentry_options_set_dsn(){} // RVA: 0x7FFAF8E3E790
        public void sentry_options_set_release(){} // RVA: 0x7FFAF8E3E840
        public void sentry_options_set_debug(){} // RVA: 0x7FFAF8E3E8F0
        public void sentry_options_set_environment(){} // RVA: 0x7FFAF8E3E980
        public void sentry_options_set_sample_rate(){} // RVA: 0x7FFAF8E3EA30
        public void sentry_options_set_database_path(){} // RVA: 0x7FFAF8E3EAC0
        public void sentry_options_set_database_pathw(){} // RVA: 0x7FFAF8E3EB70
        public void sentry_options_set_auto_session_tracking(){} // RVA: 0x7FFAF8E3EC10
        public void sentry_options_set_logger(){} // RVA: 0x7FFAF8E3ECA0
        public void nativeLog(){} // RVA: 0x7FFAF8E3ED40
        public void nativeLogImpl(){} // RVA: 0x7FFAF8E3ED60
        public void vsnprintf_windows(){} // RVA: 0x7FFAF8E3F4A0
        public void vsnprintf_linux(){} // RVA: 0x7FFAF8E3F550
        public void WithAllocatedPtr(){} // RVA: 0x7FFAF8E3F600
        public void WithMarshalledStruct(){} // RVA: 0x7FFAF2D33FA0
        public void sentry_init(){} // RVA: 0x7FFAF8E3F730
        public void sentry_close(){} // RVA: 0x7FFAF8E3E490
        public void sentry_get_crashed_last_run(){} // RVA: 0x7FFAF8E3F7B0
        public void sentry_clear_crashed_last_run(){} // RVA: 0x7FFAF8E3F820
        public void sentry_reinstall_backend(){} // RVA: 0x7FFAF8E3E6B0
    }

}