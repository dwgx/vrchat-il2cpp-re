// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Integrations
// Classes: 10
// Methods: 50

namespace ThirdParty.Sentry.Sentry.Unity.Integrations
{
    public class ApplicationAdapter : Object
    {
        public object Instance;
        public object LogMessageReceived;
        public object Quitting;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DF5C30
        public void add_LogMessageReceived(){} // RVA: 0x6DF5E80
        public void remove_LogMessageReceived(){} // RVA: 0x6DF5F70
        public void add_Quitting(){} // RVA: 0x6DF6060
        public void remove_Quitting(){} // RVA: 0x6DF6150
        public void get_ActiveSceneName(){} // RVA: 0x6DF6240
        public void get_IsEditor(){} // RVA: 0x6DF6290
        public void get_ProductName(){} // RVA: 0x6DF62E0
        public void get_Version(){} // RVA: 0x6DF6330
        public void get_BuildGUID(){} // RVA: 0x6DF6380
        public void get_UnityVersion(){} // RVA: 0x6DF63D0
        public void get_PersistentDataPath(){} // RVA: 0x6DF6420
        public void get_Platform(){} // RVA: 0x6DF6470
        public void OnLogMessageReceived(){} // RVA: 0x6DF64F0
        public void OnQuitting(){} // RVA: 0xF158E0
        public void .cctor(){} // RVA: 0x6DF6510
    }

    public class ApplicationNotRespondingException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DF5BC0
    }

    public class IApplication
    {
        // ── Methods ──
        public void add_LogMessageReceived(){} // RVA: 0x894320
        public void remove_LogMessageReceived(){} // RVA: 0x894320
        public void add_Quitting(){} // RVA: 0x894320
        public void remove_Quitting(){} // RVA: 0x894320
        public void get_ActiveSceneName(){} // RVA: 0x87C0A0
        public void get_IsEditor(){} // RVA: 0x87D280
        public void get_ProductName(){} // RVA: 0x87C0A0
        public void get_Version(){} // RVA: 0x87C0A0
        public void get_BuildGUID(){} // RVA: 0x87C0A0
        public void get_UnityVersion(){} // RVA: 0x87C0A0
        public void get_PersistentDataPath(){} // RVA: 0x87C0A0
        public void get_Platform(){} // RVA: 0x87C130
    }

    public class SceneManagerIntegration : Object
    {
        public object _sceneManager;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Register(){} // RVA: 0x6DF6670
    }

    public class SessionIntegration : Object
    {
        public object _sentryMonoBehaviour;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Register(){} // RVA: 0x6DF7010
    }

    public class UnityBadGatewayExceptionFilter : Object
    {
        public object Message;

        // ── Methods ──
        public void Filter(){} // RVA: 0x6DF7380
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnityBeforeSceneLoadIntegration : Object
    {
        public object _application;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DF7480
        public void Register(){} // RVA: 0x6DF7550
    }

    public class UnityLogHandlerIntegration : Object
    {
        public object ErrorTimeDebounce;
        public object LogTimeDebounce;
        public object WarningTimeDebounce;
        public object _application;
        public object _hub;
        public object _sentryOptions;
        public object _unityLogHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DF76C0
        public void Register(){} // RVA: 0x6DF7940
        public void LogException(){} // RVA: 0x6DF7C30
        public void CaptureException(){} // RVA: 0x6DF7D40
        public void LogFormat(){} // RVA: 0x6DF8120
        public void CaptureLogFormat(){} // RVA: 0x6DF82C0
        public void OnQuitting(){} // RVA: 0x6DF8670
        public void ToEventTagType(){} // RVA: 0x6DF8870
        public void ToBreadcrumbLevel(){} // RVA: 0x6DF88A0
    }

    public class UnitySocketExceptionFilter : Object
    {
        public object Message;

        // ── Methods ──
        public void Filter(){} // RVA: 0x6DF88D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnityWebExceptionFilter : Object
    {
        public object Message;

        // ── Methods ──
        public void Filter(){} // RVA: 0x6DF89F0
        public void .ctor(){} // RVA: 0xB43310
    }

}