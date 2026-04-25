// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Integrations
// Classes: 5
// Methods: 12

namespace ThirdParty.Sentry.Sentry.Integrations
{
    public class AppDomainProcessExitIntegration : Object
    {
        public Sentry.Internal.IAppDomain _appDomain; // 0x10
        public Sentry.IHub _hub; // 0x18
        public Sentry.SentryOptions _options; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BD2EA0
        public void Register(){} // RVA: 0x7FFAC8BD2F60
        public void HandleProcessExit(){} // RVA: 0x7FFAC8BD30D0
    }

    public class AppDomainUnhandledExceptionIntegration : Object
    {
        public Sentry.Internal.IAppDomain _appDomain; // 0x10
        public Sentry.IHub _hub; // 0x18
        public Sentry.SentryOptions _options; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BD3190
        public void Register(){} // RVA: 0x7FFAC8BD3250
        public void Handle(){} // RVA: 0x7FFAC8BD3420
    }

    public class AutoSessionTrackingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFAC8BD35C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ISdkIntegration
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFAC2C79B30
    }

    public class UnobservedTaskExceptionIntegration : Object
    {
        public string MechanismKey;
        public Sentry.Internal.IAppDomain _appDomain; // 0x10
        public Sentry.IHub _hub; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BD3630
        public void Register(){} // RVA: 0x7FFAC8BD36F0
        public void Handle(){} // RVA: 0x7FFAC8BD3850
    }

}