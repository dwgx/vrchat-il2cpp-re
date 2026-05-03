// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core
// Classes: 7
// Methods: 21

namespace ThirdParty.Other.Unity.Services.Core
{
    public class ExternalUserIdProperty : Object
    {
        public System.Action`1<string> UserIdChanged; // 0x10

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFE810FE7C0
        public void set_UserId(){} // RVA: 0x7FFE87A98A70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IUnityServices
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFE80E2EDB0
    }

    public class InitializationOptions : Object
    {
        public System.Collections.Generic.IDictionary`2<string,object> _values; // 0x10

        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE87A98AE0 | overloaded x2
    }

    public class ServicesInitializationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A98C80 | overloaded x3
    }

    public class UnityProjectNotLinkedException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87A98C20
    }

    public class UnityServices : Object
    {
        public Unity.Services.Core.IUnityServices _instance;
        public System.Threading.Tasks.TaskCompletionSource`1<object> _instantiationCompletion; // 0x8
        public Unity.Services.Core.ExternalUserIdProperty ExternalUserIdProperty; // 0x10
        public object field_3; // 0x4

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE87A98CF0
        public void set_Instance(){} // RVA: 0x7FFE87A98D50
        public void get_InstantiationCompletion(){} // RVA: 0x7FFE87A98E00
        public void get_State(){} // RVA: 0x7FFE87A98E60
        public void get_ExternalUserId(){} // RVA: 0x7FFE87A99030
        public void set_ExternalUserId(){} // RVA: 0x7FFE87A990A0
        public void .cctor(){} // RVA: 0x7FFE87A99170
    }

    public class UnityThreadUtils : Object
    {
        public int s_UnityThreadId;
        public System.Threading.Tasks.TaskScheduler _unityThreadScheduler; // 0x8

        // ── Methods ──
        public void set_UnityThreadScheduler(){} // RVA: 0x7FFE87A99230
        public void CaptureUnityThreadInfo(){} // RVA: 0x7FFE87A992D0
        public void get_IsRunningOnUnityThread(){} // RVA: 0x7FFE87A99430
    }

}