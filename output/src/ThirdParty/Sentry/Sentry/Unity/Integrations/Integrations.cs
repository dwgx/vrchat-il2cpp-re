// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Integrations
// Classes: 10
// Methods: 50

namespace ThirdParty.Sentry.Sentry.Unity.Integrations
{
    public class ApplicationAdapter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE175010
        public void add_LogMessageReceived(){} // RVA: 0x7AE175260
        public void remove_LogMessageReceived(){} // RVA: 0x7AE175350
        public void add_Quitting(){} // RVA: 0x7AE175440
        public void remove_Quitting(){} // RVA: 0x7AE175530
        public void get_ActiveSceneName(){} // RVA: 0x7AE175620
        public void get_IsEditor(){} // RVA: 0x7AE1756B0
        public void get_ProductName(){} // RVA: 0x7AE175700
        public void get_Version(){} // RVA: 0x7AE175780
        public void get_BuildGUID(){} // RVA: 0x7AE175800
        public void get_UnityVersion(){} // RVA: 0x7AE175880
        public void get_PersistentDataPath(){} // RVA: 0x7AE175900
        public void get_Platform(){} // RVA: 0x7AE175980
        public void OnLogMessageReceived(){} // RVA: 0x7AE175A00
        public void OnQuitting(){} // RVA: 0x7A8447B80
        public void .cctor(){} // RVA: 0x7AE175A20
    }

    public class ApplicationNotRespondingException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE174FA0
    }

    public class IApplication
    {
        // ── Methods ──
        public void add_LogMessageReceived(){} // RVA: 0x7A7E18800
        public void remove_LogMessageReceived(){} // RVA: 0x7A7E18800
        public void add_Quitting(){} // RVA: 0x7A7E18800
        public void remove_Quitting(){} // RVA: 0x7A7E18800
        public void get_ActiveSceneName(){} // RVA: 0x7A7E00680
        public void get_IsEditor(){} // RVA: 0x7A7E01900
        public void get_ProductName(){} // RVA: 0x7A7E00680
        public void get_Version(){} // RVA: 0x7A7E00680
        public void get_BuildGUID(){} // RVA: 0x7A7E00680
        public void get_UnityVersion(){} // RVA: 0x7A7E00680
        public void get_PersistentDataPath(){} // RVA: 0x7A7E00680
        public void get_Platform(){} // RVA: 0x7A7E00710
    }

    public class SceneManagerIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Register(){} // RVA: 0x7AE175B80
    }

    public class SessionIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Register(){} // RVA: 0x7AE176520
    }

    public class UnityBadGatewayExceptionFilter : Object
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7AE176890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnityBeforeSceneLoadIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1769C0
        public void Register(){} // RVA: 0x7AE176A90
    }

    public class UnityLogHandlerIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE176C00
        public void Register(){} // RVA: 0x7AE176E80
        public void LogException(){} // RVA: 0x7AE177170
        public void CaptureException(){} // RVA: 0x7AE177280
        public void LogFormat(){} // RVA: 0x7AE177670
        public void CaptureLogFormat(){} // RVA: 0x7AE177810
        public void OnQuitting(){} // RVA: 0x7AE177BC0
        public void ToEventTagType(){} // RVA: 0x7AE177DC0
        public void ToBreadcrumbLevel(){} // RVA: 0x7AE177DF0
    }

    public class UnitySocketExceptionFilter : Object
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7AE177E20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnityWebExceptionFilter : Object
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7AE177F80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}