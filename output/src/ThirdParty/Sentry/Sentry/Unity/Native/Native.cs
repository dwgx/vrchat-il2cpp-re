// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Native
// Classes: 4
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Unity.Native
{
    public class NativeContextWriter : ContextWriter
    {
        // ── Methods ──
        public void WriteScope(){} // RVA: 0x7FFE86ECC3D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NativeScopeObserver : ScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86ECC7B0
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFE86ECC8A0
        public void SetExtraImpl(){} // RVA: 0x7FFE86ECCBB0
        public void SetTagImpl(){} // RVA: 0x7FFE86ECCD20
        public void UnsetTagImpl(){} // RVA: 0x7FFE86ECCE20
        public void SetUserImpl(){} // RVA: 0x7FFE86ECCEF0
        public void UnsetUserImpl(){} // RVA: 0x7FFE86ECD1B0
        public void GetTimestamp(){} // RVA: 0x7FFE86ECD250
    }

    public class SentryNative : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFE86ECD2C0
        public void ReinstallBackend(){} // RVA: 0x7FFE86ECDE30
        public void .cctor(){} // RVA: 0x7FFE86ECDFF0
    }

    public class SentryNativeBridge : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE86ECE250
        public void Close(){} // RVA: 0x7FFE86ECEEB0
        public void HandleCrashedLastRun(){} // RVA: 0x7FFE86ECEF20
        public void GetCacheDirectory(){} // RVA: 0x7FFE86ECF000
        public void ReinstallBackend(){} // RVA: 0x7FFE86ECF0D0
        public void sentry_options_new(){} // RVA: 0x7FFE86ECF140
        public void sentry_options_set_dsn(){} // RVA: 0x7FFE86ECF1B0
        public void sentry_options_set_release(){} // RVA: 0x7FFE86ECF260
        public void sentry_options_set_debug(){} // RVA: 0x7FFE86ECF310
        public void sentry_options_set_environment(){} // RVA: 0x7FFE86ECF3A0
        public void sentry_options_set_sample_rate(){} // RVA: 0x7FFE86ECF450
        public void sentry_options_set_database_path(){} // RVA: 0x7FFE86ECF4E0
        public void sentry_options_set_database_pathw(){} // RVA: 0x7FFE86ECF590
        public void sentry_options_set_auto_session_tracking(){} // RVA: 0x7FFE86ECF630
        public void sentry_options_set_logger(){} // RVA: 0x7FFE86ECF6C0
        public void nativeLog(){} // RVA: 0x7FFE86ECF760
        public void nativeLogImpl(){} // RVA: 0x7FFE86ECF780
        public void vsnprintf_windows(){} // RVA: 0x7FFE86ECFEC0
        public void vsnprintf_linux(){} // RVA: 0x7FFE86ECFF70
        public void WithAllocatedPtr(){} // RVA: 0x7FFE86ED0020
        public void WithMarshalledStruct(){} // RVA: 0x7FFE810A1420
        public void sentry_init(){} // RVA: 0x7FFE86ED0150
        public void sentry_close(){} // RVA: 0x7FFE86ECEEB0
        public void sentry_get_crashed_last_run(){} // RVA: 0x7FFE86ED01D0
        public void sentry_clear_crashed_last_run(){} // RVA: 0x7FFE86ED0240
        public void sentry_reinstall_backend(){} // RVA: 0x7FFE86ECF0D0
    }

}