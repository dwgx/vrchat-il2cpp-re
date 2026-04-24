// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Integrations
// Classes: 9
// Methods: 50

namespace ThirdParty.Sentry.Sentry.Unity.Integrations
{
    public class ApplicationAdapter : Object
    {
        public object Quitting; // 0x34DAAAC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae540ba0
        public void add_LogMessageReceived(){} // RVA: 0x7ffaae540df0
        public void remove_LogMessageReceived(){} // RVA: 0x7ffaae540ee0
        public void add_Quitting(){} // RVA: 0x7ffaae540fd0
        public void remove_Quitting(){} // RVA: 0x7ffaae5410c0
        public void get_ActiveSceneName(){} // RVA: 0x7ffaae5411b0
        public void get_IsEditor(){} // RVA: 0x7ffaae541240
        public void get_ProductName(){} // RVA: 0x7ffaae541290
        public void get_Version(){} // RVA: 0x7ffaae541310
        public void get_BuildGUID(){} // RVA: 0x7ffaae541390
        public void get_UnityVersion(){} // RVA: 0x7ffaae541410
        public void get_PersistentDataPath(){} // RVA: 0x7ffaae541490
        public void get_Platform(){} // RVA: 0x7ffaae541510
        public void OnLogMessageReceived(){} // RVA: 0x7ffaae541590
        public void OnQuitting(){} // RVA: 0x7ffaa8b02670
        public void .cctor(){} // RVA: 0x7ffaae5415b0
    }

    public class IApplication
    {
        // ── Original Methods ──
        public void add_LogMessageReceived(){} // RVA: 0x7ffaa8660d80
        public void remove_LogMessageReceived(){} // RVA: 0x7ffaa8660d80
        public void add_Quitting(){} // RVA: 0x7ffaa8660d80
        public void remove_Quitting(){} // RVA: 0x7ffaa8660d80
        public void get_ActiveSceneName(){} // RVA: 0x7ffaa86491d0
        public void get_IsEditor(){} // RVA: 0x7ffaa864a040
        public void get_ProductName(){} // RVA: 0x7ffaa86491d0
        public void get_Version(){} // RVA: 0x7ffaa86491d0
        public void get_BuildGUID(){} // RVA: 0x7ffaa86491d0
        public void get_UnityVersion(){} // RVA: 0x7ffaa86491d0
        public void get_PersistentDataPath(){} // RVA: 0x7ffaa86491d0
        public void get_Platform(){} // RVA: 0x7ffaa8649ca0
    }

    public class SceneManagerIntegration : Object
    {
        public object  	00; // 0x34B9FE70

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Register(){} // RVA: 0x7ffaae541710
    }

    public class SessionIntegration : Object
    {
        public object  	00; // 0x34DCB868

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Register(){} // RVA: 0x7ffaae5420d0
    }

    public class UnityBadGatewayExceptionFilter : Object
    {
        // ── Original Methods ──
        public void Filter(){} // RVA: 0x7ffaae542440
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UnityBeforeSceneLoadIntegration : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae542570
        public void Register(){} // RVA: 0x7ffaae542640
    }

    public class UnityLogHandlerIntegration : Object
    {
        public object WarningTimeDebounce; // 0x34DD2F70
        public object _sentryOptions; // 0x34DD2F70
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae5427b0
        public void Register(){} // RVA: 0x7ffaae542a30
        public void LogException(){} // RVA: 0x7ffaae542d20
        public void CaptureException(){} // RVA: 0x7ffaae542e50
        public void LogFormat(){} // RVA: 0x7ffaae543240
        public void CaptureLogFormat(){} // RVA: 0x7ffaae5433e0
        public void OnQuitting(){} // RVA: 0x7ffaae543790
        public void ToEventTagType(){} // RVA: 0x7ffaae543990
        public void ToBreadcrumbLevel(){} // RVA: 0x7ffaae5439c0
    }

    public class UnitySocketExceptionFilter : Object
    {
        // ── Original Methods ──
        public void Filter(){} // RVA: 0x7ffaae5439f0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UnityWebExceptionFilter : Object
    {
        // ── Original Methods ──
        public void Filter(){} // RVA: 0x7ffaae543b50
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

}