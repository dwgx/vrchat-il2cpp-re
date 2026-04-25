// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core
// Classes: 7
// Methods: 21

namespace ThirdParty.Other.Unity.Services.Core
{
    public class ExternalUserIdProperty : Object
    {
        public object UserId;

        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7FFD4E3447C0
        public void set_UserId(){} // RVA: 0x7FFD54B10500
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class IUnityServices
    {
        public object State;

        // ── Methods ──
        public void get_State(){} // RVA: 0x7FFD4E079960
    }

    public class InitializationOptions : Object
    {
        public object Values;

        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFD4E35C380
        public void .ctor(){} // RVA: 0x7FFD54B10570 | overloaded x2
    }

    public class ServicesInitializationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B10710 | overloaded x3
    }

    public class UnityProjectNotLinkedException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54B106B0
    }

    public class UnityServices : Object
    {
        public object Instance;
        public object InstantiationCompletion;
        public object State;
        public object ExternalUserId;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD54B10780
        public void set_Instance(){} // RVA: 0x7FFD54B107E0
        public void get_InstantiationCompletion(){} // RVA: 0x7FFD54B10890
        public void get_State(){} // RVA: 0x7FFD54B108F0
        public void get_ExternalUserId(){} // RVA: 0x7FFD54B10AC0
        public void set_ExternalUserId(){} // RVA: 0x7FFD54B10B30
        public void .cctor(){} // RVA: 0x7FFD54B10C00
    }

    public class UnityThreadUtils : Object
    {
        public object UnityThreadScheduler;
        public object IsRunningOnUnityThread;

        // ── Methods ──
        public void set_UnityThreadScheduler(){} // RVA: 0x7FFD54B10CC0
        public void CaptureUnityThreadInfo(){} // RVA: 0x7FFD54B10D60
        public void get_IsRunningOnUnityThread(){} // RVA: 0x7FFD54B10EC0
    }

}