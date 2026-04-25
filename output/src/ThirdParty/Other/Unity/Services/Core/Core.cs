// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core
// Classes: 7
// Methods: 21

namespace ThirdParty.Other.Unity.Services.Core
{
    public class ExternalUserIdProperty : Object
    {
        public System.Action`1<string> UserId; // 0x10
        public string m_UserId; // 0x18

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFAC2F247C0
        public void set_UserId(){} // RVA: 0x7FFAC96F0500
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IUnityServices
    {
        public object State;

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFAC2C59960
    }

    public class InitializationOptions : Object
    {
        public System.Collections.Generic.IDictionary`2<string,object> Values; // 0x10

        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC96F0570 | overloaded x2
    }

    public class ServicesInitializationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F0710 | overloaded x3
    }

    public class UnityProjectNotLinkedException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC96F06B0
    }

    public class UnityServices : Object
    {
        public Unity.Services.Core.IUnityServices Instance;
        public System.Threading.Tasks.TaskCompletionSource`1<object> InstantiationCompletion; // 0x8
        public Unity.Services.Core.ExternalUserIdProperty State; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC96F0780
        public void set_Instance(){} // RVA: 0x7FFAC96F07E0
        public void get_InstantiationCompletion(){} // RVA: 0x7FFAC96F0890
        public void get_State(){} // RVA: 0x7FFAC96F08F0
        public void get_ExternalUserId(){} // RVA: 0x7FFAC96F0AC0
        public void set_ExternalUserId(){} // RVA: 0x7FFAC96F0B30
        public void .cctor(){} // RVA: 0x7FFAC96F0C00
    }

    public class UnityThreadUtils : Object
    {
        public int UnityThreadScheduler;
        public System.Threading.Tasks.TaskScheduler IsRunningOnUnityThread; // 0x8

        // ── Methods ──
        public void set_UnityThreadScheduler(){} // RVA: 0x7FFAC96F0CC0
        public void CaptureUnityThreadInfo(){} // RVA: 0x7FFAC96F0D60
        public void get_IsRunningOnUnityThread(){} // RVA: 0x7FFAC96F0EC0
    }

}