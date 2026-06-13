// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core
// Classes: 7
// Methods: 21

namespace ThirdParty.Other.Unity.Services.Core
{
    public class ExternalUserIdProperty
    {
        public System.Action`1<string> UserIdChanged; // 0x10

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x2E07C0
        public void set_UserId(){} // RVA: 0x6F57BE0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IUnityServices
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0xD840
    }

    public class InitializationOptions
    {
        public System.Collections.Generic.IDictionary`2<string,object> <Values>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Values(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x6F57C50 | overloaded x2
    }

    public class ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F57DF0 | overloaded x3
    }

    public class UnityProjectNotLinkedException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F57D90
    }

    public class UnityServices
    {
        public Unity.Services.Core.IUnityServices <Instance>k__BackingField;
        public System.Threading.Tasks.TaskCompletionSource`1<object> <InstantiationCompletion>k__BackingField; // 0x8
        public Unity.Services.Core.ExternalUserIdProperty ExternalUserIdProperty; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6F57E60
        public void set_Instance(){} // RVA: 0x6F57EC0
        public void get_InstantiationCompletion(){} // RVA: 0x6F57F70
        public void get_State(){} // RVA: 0x6F57FD0
        public void get_ExternalUserId(){} // RVA: 0x6F581A0
        public void set_ExternalUserId(){} // RVA: 0x6F58210
        public void .cctor(){} // RVA: 0x6F582E0
    }

    public class UnityThreadUtils
    {
        public int name;
        public System.Threading.Tasks.TaskScheduler asset; // 0x8

        // ── Methods ──
        public void set_UnityThreadScheduler(){} // RVA: 0x6F583A0
        public void CaptureUnityThreadInfo(){} // RVA: 0x6F58440
        public void get_IsRunningOnUnityThread(){} // RVA: 0x6F585A0
    }

}