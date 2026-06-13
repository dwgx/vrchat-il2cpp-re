// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Integrations
// Classes: 10
// Methods: 53

namespace ThirdParty.Sentry.Sentry.Unity.Integrations
{
    public class ApplicationAdapter
    {
        public Sentry.Unity.Integrations.ApplicationAdapter Instance;
        public LogCallback LogMessageReceived; // 0x10
        public System.Action Quitting; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x63885F0
        public void add_LogMessageReceived(){} // RVA: 0x6388840
        public void remove_LogMessageReceived(){} // RVA: 0x6388930
        public void add_Quitting(){} // RVA: 0x6388A20
        public void remove_Quitting(){} // RVA: 0x6388B10
        public void get_ActiveSceneName(){} // RVA: 0x6388C00
        public void get_IsEditor(){} // RVA: 0x6388C90
        public void get_ProductName(){} // RVA: 0x6388CE0
        public void get_Version(){} // RVA: 0x6388D60
        public void get_BuildGUID(){} // RVA: 0x6388DE0
        public void get_UnityVersion(){} // RVA: 0x6388E60
        public void get_PersistentDataPath(){} // RVA: 0x6388EE0
        public void get_Platform(){} // RVA: 0x6388F60
        public void OnLogMessageReceived(){} // RVA: 0x6388FE0
        public void OnQuitting(){} // RVA: 0x68B350
        public void .cctor(){} // RVA: 0x6389000
    }

    public class ApplicationNotRespondingException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6388580 | overloaded x3
    }

    public class IApplication
    {
        // ── Methods ──
        public void add_LogMessageReceived(){} // RVA: 0x24B10
        public void remove_LogMessageReceived(){} // RVA: 0x24B10
        public void add_Quitting(){} // RVA: 0x24B10
        public void remove_Quitting(){} // RVA: 0x24B10
        public void get_ActiveSceneName(){} // RVA: 0xCD60
        public void get_IsEditor(){} // RVA: 0xDBE0
        public void get_ProductName(){} // RVA: 0xCD60
        public void get_Version(){} // RVA: 0xCD60
        public void get_BuildGUID(){} // RVA: 0xCD60
        public void get_UnityVersion(){} // RVA: 0xCD60
        public void get_PersistentDataPath(){} // RVA: 0xCD60
        public void get_Platform(){} // RVA: 0xD840
    }

    public class SceneManagerIntegration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void Register(){} // RVA: 0x6389160
    }

    public class SessionIntegration : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Register(){} // RVA: 0x6389B20
    }

    public class UnityBadGatewayExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x6389E90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnityBeforeSceneLoadIntegration : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6389FC0
        public void Register(){} // RVA: 0x638A090
    }

    public class UnityLogHandlerIntegration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x638A200
        public void Register(){} // RVA: 0x638A480
        public void LogException(){} // RVA: 0x638A770
        public void CaptureException(){} // RVA: 0x638A8A0
        public void LogFormat(){} // RVA: 0x638AC90
        public void CaptureLogFormat(){} // RVA: 0x638AE30
        public void OnQuitting(){} // RVA: 0x638B1E0
        public void ToEventTagType(){} // RVA: 0x638B3E0
        public void ToBreadcrumbLevel(){} // RVA: 0x638B410
    }

    public class UnitySocketExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x638B440
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnityWebExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x638B5A0
        public void .ctor(){} // RVA: 0x2DD310
    }

}