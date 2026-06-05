// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Integrations
// Classes: 10
// Methods: 53

namespace ThirdParty.Sentry.Sentry.Unity.Integrations
{
    public class ApplicationAdapter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E385F0
        public void add_LogMessageReceived(){} // RVA: 0x7FFAF8E38840
        public void remove_LogMessageReceived(){} // RVA: 0x7FFAF8E38930
        public void add_Quitting(){} // RVA: 0x7FFAF8E38A20
        public void remove_Quitting(){} // RVA: 0x7FFAF8E38B10
        public void get_ActiveSceneName(){} // RVA: 0x7FFAF8E38C00
        public void get_IsEditor(){} // RVA: 0x7FFAF8E38C90
        public void get_ProductName(){} // RVA: 0x7FFAF8E38CE0
        public void get_Version(){} // RVA: 0x7FFAF8E38D60
        public void get_BuildGUID(){} // RVA: 0x7FFAF8E38DE0
        public void get_UnityVersion(){} // RVA: 0x7FFAF8E38E60
        public void get_PersistentDataPath(){} // RVA: 0x7FFAF8E38EE0
        public void get_Platform(){} // RVA: 0x7FFAF8E38F60
        public void OnLogMessageReceived(){} // RVA: 0x7FFAF8E38FE0
        public void OnQuitting(){} // RVA: 0x7FFAF313B350
        public void .cctor(){} // RVA: 0x7FFAF8E39000
    }

    public class ApplicationNotRespondingException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E38580 | overloaded x3
    }

    public class IApplication
    {
        // ── Methods ──
        public void add_LogMessageReceived(){} // RVA: 0x7FFAF2AD4B10
        public void remove_LogMessageReceived(){} // RVA: 0x7FFAF2AD4B10
        public void add_Quitting(){} // RVA: 0x7FFAF2AD4B10
        public void remove_Quitting(){} // RVA: 0x7FFAF2AD4B10
        public void get_ActiveSceneName(){} // RVA: 0x7FFAF2ABCD60
        public void get_IsEditor(){} // RVA: 0x7FFAF2ABDBE0
        public void get_ProductName(){} // RVA: 0x7FFAF2ABCD60
        public void get_Version(){} // RVA: 0x7FFAF2ABCD60
        public void get_BuildGUID(){} // RVA: 0x7FFAF2ABCD60
        public void get_UnityVersion(){} // RVA: 0x7FFAF2ABCD60
        public void get_PersistentDataPath(){} // RVA: 0x7FFAF2ABCD60
        public void get_Platform(){} // RVA: 0x7FFAF2ABD840
    }

    public class SceneManagerIntegration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void Register(){} // RVA: 0x7FFAF8E39160
    }

    public class SessionIntegration : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Register(){} // RVA: 0x7FFAF8E39B20
    }

    public class UnityBadGatewayExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAF8E39E90
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnityBeforeSceneLoadIntegration : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E39FC0
        public void Register(){} // RVA: 0x7FFAF8E3A090
    }

    public class UnityLogHandlerIntegration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E3A200
        public void Register(){} // RVA: 0x7FFAF8E3A480
        public void LogException(){} // RVA: 0x7FFAF8E3A770
        public void CaptureException(){} // RVA: 0x7FFAF8E3A8A0
        public void LogFormat(){} // RVA: 0x7FFAF8E3AC90
        public void CaptureLogFormat(){} // RVA: 0x7FFAF8E3AE30
        public void OnQuitting(){} // RVA: 0x7FFAF8E3B1E0
        public void ToEventTagType(){} // RVA: 0x7FFAF8E3B3E0
        public void ToBreadcrumbLevel(){} // RVA: 0x7FFAF8E3B410
    }

    public class UnitySocketExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAF8E3B440
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnityWebExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAF8E3B5A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}