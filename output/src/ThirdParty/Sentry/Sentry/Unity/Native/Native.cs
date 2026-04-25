// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Native
// Classes: 4
// Methods: 39

namespace ThirdParty.Sentry.Sentry.Unity.Native
{
    public class NativeContextWriter : ContextWriter
    {
        // ── Methods ──
        public void WriteScope(){} // RVA: 0x7FFAC8B22D60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NativeScopeObserver : ScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B23140
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFAC8B23230
        public void SetExtraImpl(){} // RVA: 0x7FFAC8B23540
        public void SetTagImpl(){} // RVA: 0x7FFAC8B236B0
        public void UnsetTagImpl(){} // RVA: 0x7FFAC8B237B0
        public void SetUserImpl(){} // RVA: 0x7FFAC8B23880
        public void UnsetUserImpl(){} // RVA: 0x7FFAC8B23B40
        public void GetTimestamp(){} // RVA: 0x7FFAC8B23BE0
    }

    public class SentryNative : Object
    {
        public System.Collections.Generic.Dictionary`2<string,bool> PerDirectoryCrashInfo;
        public bool ShouldReinstallBackend; // 0x8
        public Sentry.Extensibility.IDiagnosticLogger Logger; // 0x10

        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAC8B23C50
        public void ReinstallBackend(){} // RVA: 0x7FFAC8B247C0
        public void .cctor(){} // RVA: 0x7FFAC8B24980
    }

    public class SentryNativeBridge : Object
    {
        public Sentry.Extensibility.IDiagnosticLogger _logger;
        public bool _isLinux; // 0x8

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC8B24BE0
        public void Close(){} // RVA: 0x7FFAC8B25840
        public void HandleCrashedLastRun(){} // RVA: 0x7FFAC8B258B0
        public void GetCacheDirectory(){} // RVA: 0x7FFAC8B25990
        public void ReinstallBackend(){} // RVA: 0x7FFAC8B25A60
        public void sentry_options_new(){} // RVA: 0x7FFAC8B25AD0
        public void sentry_options_set_dsn(){} // RVA: 0x7FFAC8B25B40
        public void sentry_options_set_release(){} // RVA: 0x7FFAC8B25BF0
        public void sentry_options_set_debug(){} // RVA: 0x7FFAC8B25CA0
        public void sentry_options_set_environment(){} // RVA: 0x7FFAC8B25D30
        public void sentry_options_set_sample_rate(){} // RVA: 0x7FFAC8B25DE0
        public void sentry_options_set_database_path(){} // RVA: 0x7FFAC8B25E70
        public void sentry_options_set_database_pathw(){} // RVA: 0x7FFAC8B25F20
        public void sentry_options_set_auto_session_tracking(){} // RVA: 0x7FFAC8B25FC0
        public void sentry_options_set_logger(){} // RVA: 0x7FFAC8B26050
        public void nativeLog(){} // RVA: 0x7FFAC8B260F0
        public void nativeLogImpl(){} // RVA: 0x7FFAC8B26110
        public void vsnprintf_windows(){} // RVA: 0x7FFAC8B26850
        public void vsnprintf_linux(){} // RVA: 0x7FFAC8B26900
        public void WithAllocatedPtr(){} // RVA: 0x7FFAC8B269B0
        public void WithMarshalledStruct(){} // RVA: 0x7FFAC2E8DC40
        public void sentry_init(){} // RVA: 0x7FFAC8B26AE0
        public void sentry_close(){} // RVA: 0x7FFAC8B25840
        public void sentry_get_crashed_last_run(){} // RVA: 0x7FFAC8B26B60
        public void sentry_clear_crashed_last_run(){} // RVA: 0x7FFAC8B26BD0
        public void sentry_reinstall_backend(){} // RVA: 0x7FFAC8B25A60
    }

}