// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Native
// Classes: 2
// Methods: 29

namespace ThirdParty.Sentry.Sentry.Unity.Native
{
    public class SentryNative : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFD53F43C50
        public void ReinstallBackend(){} // RVA: 0x7FFD53F447C0
        public void .cctor(){} // RVA: 0x7FFD53F44980
    }

    public class SentryNativeBridge : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD53F44BE0
        public void Close(){} // RVA: 0x7FFD53F45840
        public void HandleCrashedLastRun(){} // RVA: 0x7FFD53F458B0
        public void GetCacheDirectory(){} // RVA: 0x7FFD53F45990
        public void ReinstallBackend(){} // RVA: 0x7FFD53F45A60
        public void sentry_options_new(){} // RVA: 0x7FFD53F45AD0
        public void sentry_options_set_dsn(){} // RVA: 0x7FFD53F45B40
        public void sentry_options_set_release(){} // RVA: 0x7FFD53F45BF0
        public void sentry_options_set_debug(){} // RVA: 0x7FFD53F45CA0
        public void sentry_options_set_environment(){} // RVA: 0x7FFD53F45D30
        public void sentry_options_set_sample_rate(){} // RVA: 0x7FFD53F45DE0
        public void sentry_options_set_database_path(){} // RVA: 0x7FFD53F45E70
        public void sentry_options_set_database_pathw(){} // RVA: 0x7FFD53F45F20
        public void sentry_options_set_auto_session_tracking(){} // RVA: 0x7FFD53F45FC0
        public void sentry_options_set_logger(){} // RVA: 0x7FFD53F46050
        public void nativeLog(){} // RVA: 0x7FFD53F460F0
        public void nativeLogImpl(){} // RVA: 0x7FFD53F46110
        public void vsnprintf_windows(){} // RVA: 0x7FFD53F46850
        public void vsnprintf_linux(){} // RVA: 0x7FFD53F46900
        public void WithAllocatedPtr(){} // RVA: 0x7FFD53F469B0
        public void WithMarshalledStruct(){} // RVA: 0x7FFD4E2ADC40
        public void sentry_init(){} // RVA: 0x7FFD53F46AE0
        public void sentry_close(){} // RVA: 0x7FFD53F45840
        public void sentry_get_crashed_last_run(){} // RVA: 0x7FFD53F46B60
        public void sentry_clear_crashed_last_run(){} // RVA: 0x7FFD53F46BD0
        public void sentry_reinstall_backend(){} // RVA: 0x7FFD53F45A60
    }

}