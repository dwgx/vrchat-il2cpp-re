// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core
// Classes: 7
// Methods: 19

namespace ThirdParty.Other.Unity.Services.Core
{
    public class ExternalUserIdProperty : Object
    {
        // ── Methods ──
        public void get_UserId(){} // RVA: 0x7A80DA7B0
        public void set_UserId(){} // RVA: 0x7AED36030
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IUnityServices
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x7A7E00710
    }

    public class InitializationOptions : Object
    {
        // ── Methods ──
        public void get_Values(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7AED360A0
        public void <Values>k__BackingField(){} // RVA: 0x7B2DE4F80
    }

    public class ServicesInitializationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED36240
    }

    public class UnityProjectNotLinkedException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AED361E0
    }

    public class UnityServices : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AED362B0
        public void set_Instance(){} // RVA: 0x7AED36310
        public void get_InstantiationCompletion(){} // RVA: 0x7AED363C0
        public void get_State(){} // RVA: 0x7AED36420
        public void get_ExternalUserId(){} // RVA: 0x7AED365F0
        public void set_ExternalUserId(){} // RVA: 0x7AED36660
        public void .cctor(){} // RVA: 0x7AED36730
    }

    public class UnityThreadUtils : Object
    {
        // ── Methods ──
        public void set_UnityThreadScheduler(){} // RVA: 0x7AED367F0
        public void CaptureUnityThreadInfo(){} // RVA: 0x7AED36890
        public void get_IsRunningOnUnityThread(){} // RVA: 0x7AED369F0
    }

}