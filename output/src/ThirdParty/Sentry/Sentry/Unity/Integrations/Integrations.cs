// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Integrations
// Classes: 9
// Methods: 50

namespace ThirdParty.Sentry.Sentry.Unity.Integrations
{
    public class ApplicationAdapter : Object
    {
        public eaMod.DNS.Model.SEC3PARAM ActiveSceneName;
        public e IsEditor; // 0x10
        public ÎÌÍÏÏÌÍÏ ProductName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53F3F9A0
        public void add_LogMessageReceived(){} // RVA: 0x7FFD53F3FBF0
        public void remove_LogMessageReceived(){} // RVA: 0x7FFD53F3FCE0
        public void add_Quitting(){} // RVA: 0x7FFD53F3FDD0
        public void remove_Quitting(){} // RVA: 0x7FFD53F3FEC0
        public void get_ActiveSceneName(){} // RVA: 0x7FFD53F3FFB0
        public void get_IsEditor(){} // RVA: 0x7FFD53F40040
        public void get_ProductName(){} // RVA: 0x7FFD53F40090
        public void get_Version(){} // RVA: 0x7FFD53F40110
        public void get_BuildGUID(){} // RVA: 0x7FFD53F40190
        public void get_UnityVersion(){} // RVA: 0x7FFD53F40210
        public void get_PersistentDataPath(){} // RVA: 0x7FFD53F40290
        public void get_Platform(){} // RVA: 0x7FFD53F40310
        public void OnLogMessageReceived(){} // RVA: 0x7FFD53F40390
        public void OnQuitting(){} // RVA: 0x7FFD4E6233B0
        public void .cctor(){} // RVA: 0x7FFD53F403B0
    }

    public class IApplication
    {
        public object ActiveSceneName;
        public object IsEditor;
        public object ProductName;
        public object Version;
        public object BuildGUID;
        public object UnityVersion;
        public object PersistentDataPath;
        public object Platform;

        // ── Methods ──
        public void add_LogMessageReceived(){} // RVA: 0x7FFD4E090A40
        public void remove_LogMessageReceived(){} // RVA: 0x7FFD4E090A40
        public void add_Quitting(){} // RVA: 0x7FFD4E090A40
        public void remove_Quitting(){} // RVA: 0x7FFD4E090A40
        public void get_ActiveSceneName(){} // RVA: 0x7FFD4E078E90
        public void get_IsEditor(){} // RVA: 0x7FFD4E079D00
        public void get_ProductName(){} // RVA: 0x7FFD4E078E90
        public void get_Version(){} // RVA: 0x7FFD4E078E90
        public void get_BuildGUID(){} // RVA: 0x7FFD4E078E90
        public void get_UnityVersion(){} // RVA: 0x7FFD4E078E90
        public void get_PersistentDataPath(){} // RVA: 0x7FFD4E078E90
        public void get_Platform(){} // RVA: 0x7FFD4E079960
    }

    public class SceneManagerIntegration : Object
    {
        public hXMultiplier.t_lifetime _sceneManager; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void Register(){} // RVA: 0x7FFD53F40510
    }

    public class SessionIntegration : Object
    {
        public hXMultiplier.Field _sentryMonoBehaviour; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void Register(){} // RVA: 0x7FFD53F40ED0
    }

    public class UnityBadGatewayExceptionFilter : Object
    {
        public string Message;

        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFD53F41240
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnityBeforeSceneLoadIntegration : Object
    {
        public eaMod.DNS.Model.? _application; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53F41370
        public void Register(){} // RVA: 0x7FFD53F41440
    }

    public class UnityLogHandlerIntegration : Object
    {
        public hXMultiplier.eEventArgs ErrorTimeDebounce; // 0x10
        public hXMultiplier.solveAsync>b__3 LogTimeDebounce; // 0x18
        public hXMultiplier.workInterfaces WarningTimeDebounce; // 0x20
        public eaMod.DNS.Model.? _application; // 0x28
        public RGBA_ETC2_SRGB.`2 _hub; // 0x30
        public hXMultiplier.ssageReceived _sentryOptions; // 0x38
        public ode _unityLogHandler; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53F415B0
        public void Register(){} // RVA: 0x7FFD53F41830
        public void LogException(){} // RVA: 0x7FFD53F41B20
        public void CaptureException(){} // RVA: 0x7FFD53F41C50
        public void LogFormat(){} // RVA: 0x7FFD53F42040
        public void CaptureLogFormat(){} // RVA: 0x7FFD53F421E0
        public void OnQuitting(){} // RVA: 0x7FFD53F42590
        public void ToEventTagType(){} // RVA: 0x7FFD53F42790
        public void ToBreadcrumbLevel(){} // RVA: 0x7FFD53F427C0
    }

    public class UnitySocketExceptionFilter : Object
    {
        public string Message;

        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFD53F427F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnityWebExceptionFilter : Object
    {
        public string Message;

        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFD53F42950
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}