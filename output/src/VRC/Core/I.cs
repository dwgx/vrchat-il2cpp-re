// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 4
// Methods: 21

namespace VRC.Core
{
    public class IBundleSignatureHolder
    {
        public object BundleSignature;

        // ── Methods ──
        public void get_BundleSignature(){} // RVA: 0x7FFAC2C58E90
    }

    public class ILoggerReceiver
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFAC2C7AF60
        public void LogWarning(){} // RVA: 0x7FFAC2C7AF60
        public void LogError(){} // RVA: 0x7FFAC2C7AF60
        public void LogException(){} // RVA: 0x7FFAC2C79B30
        public void LogFormat(){} // RVA: 0x7FFAC2C7B8C0
        public void LogWarningFormat(){} // RVA: 0x7FFAC2C7B8C0
        public void LogErrorFormat(){} // RVA: 0x7FFAC2C7B8C0
    }

    public class IVRCLogger
    {
        public object IsEnabled;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFAC2C59D00
        public void LogOnceEvery(){}
        public void LogOnceEveryFormat(){}
        public void Log(){} // RVA: 0x7FFAC2C70A40
        public void LogFormat(){} // RVA: 0x7FFAC2C79B30
        public void LogWarning(){} // RVA: 0x7FFAC2C70A40
        public void LogWarningFormat(){} // RVA: 0x7FFAC2C79B30
        public void LogError(){} // RVA: 0x7FFAC2C70A40
        public void LogErrorFormat(){} // RVA: 0x7FFAC2C79B30
    }

    public class InstanceAccessTypeExtensions : Object
    {
        public string PUBLIC_API_STRING;
        public string HIDDEN_API_STRING;
        public string FRIENDS_ONLY_API_STRING;
        public string INVITE_ONLY_API_STRING;
        public string INVITE_PLUS_API_STRING;
        public string GROUP_ONLY_API_STRING;
        public string PUBLIC_SHORT_STRING;
        public string HIDDEN_SHORT_STRING;
        public string FRIENDS_ONLY_SHORT_STRING;
        public string INVITE_ONLY_SHORT_STRING;
        public string INVITE_PLUS_SHORT_STRING;
        public string GROUP_ONLY_SHORT_STRING;
        public string PUBLIC_DISPLAY_STRING;
        public string HIDDEN_DISPLAY_STRING;
        public string FRIENDS_ONLY_DISPLAY_STRING;
        public string INVITE_ONLY_DISPLAY_STRING;
        public string INVITE_PLUS_DISPLAY_STRING;
        public string GROUP_ONLY_DISPLAY_STRING;

        // ── Methods ──
        public void ToInstanceAccessType(){} // RVA: 0x7FFACBF14D60
        public void ToApiString(){} // RVA: 0x7FFACBF14FC0
        public void ToShortString(){} // RVA: 0x7FFACBF15140
        public void ToDisplayString(){} // RVA: 0x7FFACBF152D0
    }

}