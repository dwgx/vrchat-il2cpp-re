// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity.Integrations
// Classes: 10
// Methods: 53

namespace ThirdParty.Sentry.Sentry.Unity.Integrations
{
    public class ApplicationAdapter : Object
    {
        public Sentry.Unity.Integrations.ApplicationAdapter Instance;
        public LogCallback LogMessageReceived; // 0x10
        public System.Action Quitting; // 0x18
        public object LogMessageReceived; // 0xC
        public System.Action LogMessageReceived; // 0xEB50
        public object field_5; // 0xFB50
        public object field_6; // 0xFB50
        public object field_7; // 0xFB50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EC9010
        public void add_LogMessageReceived(){} // RVA: 0x7FFE86EC9260
        public void remove_LogMessageReceived(){} // RVA: 0x7FFE86EC9350
        public void add_Quitting(){} // RVA: 0x7FFE86EC9440
        public void remove_Quitting(){} // RVA: 0x7FFE86EC9530
        public void get_ActiveSceneName(){} // RVA: 0x7FFE86EC9620
        public void get_IsEditor(){} // RVA: 0x7FFE86EC96B0
        public void get_ProductName(){} // RVA: 0x7FFE86EC9700
        public void get_Version(){} // RVA: 0x7FFE86EC9780
        public void get_BuildGUID(){} // RVA: 0x7FFE86EC9800
        public void get_UnityVersion(){} // RVA: 0x7FFE86EC9880
        public void get_PersistentDataPath(){} // RVA: 0x7FFE86EC9900
        public void get_Platform(){} // RVA: 0x7FFE86EC9980
        public void OnLogMessageReceived(){} // RVA: 0x7FFE86EC9A00
        public void OnQuitting(){} // RVA: 0x7FFE8148FF70
        public void .cctor(){} // RVA: 0x7FFE86EC9A20
    }

    public class ApplicationNotRespondingException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EC8FA0 | overloaded x3
    }

    public class IApplication
    {
        // ── Methods ──
        public void add_LogMessageReceived(){} // RVA: 0x7FFE80E460A0
        public void remove_LogMessageReceived(){} // RVA: 0x7FFE80E460A0
        public void add_Quitting(){} // RVA: 0x7FFE80E460A0
        public void remove_Quitting(){} // RVA: 0x7FFE80E460A0
        public void get_ActiveSceneName(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsEditor(){} // RVA: 0x7FFE80E2F150
        public void get_ProductName(){} // RVA: 0x7FFE80E2E2E0
        public void get_Version(){} // RVA: 0x7FFE80E2E2E0
        public void get_BuildGUID(){} // RVA: 0x7FFE80E2E2E0
        public void get_UnityVersion(){} // RVA: 0x7FFE80E2E2E0
        public void get_PersistentDataPath(){} // RVA: 0x7FFE80E2E2E0
        public void get_Platform(){} // RVA: 0x7FFE80E2EDB0
    }

    public class SceneManagerIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void Register(){} // RVA: 0x7FFE86EC9B80
    }

    public class SessionIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Register(){} // RVA: 0x7FFE86ECA540
    }

    public class UnityBadGatewayExceptionFilter : Object
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFE86ECA8B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnityBeforeSceneLoadIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86ECA9E0
        public void Register(){} // RVA: 0x7FFE86ECAAB0
    }

    public class UnityLogHandlerIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86ECAC20
        public void Register(){} // RVA: 0x7FFE86ECAEA0
        public void LogException(){} // RVA: 0x7FFE86ECB190
        public void CaptureException(){} // RVA: 0x7FFE86ECB2C0
        public void LogFormat(){} // RVA: 0x7FFE86ECB6B0
        public void CaptureLogFormat(){} // RVA: 0x7FFE86ECB850
        public void OnQuitting(){} // RVA: 0x7FFE86ECBC00
        public void ToEventTagType(){} // RVA: 0x7FFE86ECBE00
        public void ToBreadcrumbLevel(){} // RVA: 0x7FFE86ECBE30
    }

    public class UnitySocketExceptionFilter : Object
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFE86ECBE60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnityWebExceptionFilter : Object
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFE86ECBFC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}