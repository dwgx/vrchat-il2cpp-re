// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core
// Classes: 8
// Methods: 21

namespace ThirdParty.Other.Unity.Services.Core
{
    public class ExternalUserIdProperty : Object
    {
        public object UserIdChanged;
        public object m_UserId;

        // ── Methods ──
        public void get_UserId(){} // RVA: 0xB465B0
        public void set_UserId(){} // RVA: 0x79A2520
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IUnityServices
    {
        // ── Methods ──
        public void get_State(){} // RVA: 0x87C130
    }

    public class InitializationOptions : Object
    {
        public object _values;

        // ── Methods ──
        public void get_Values(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x79A2590
    }

    public class ServicesInitializationException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79A2730
    }

    public class UnityProjectNotLinkedException : ServicesInitializationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x79A26D0
    }

    public class UnityServices : Object
    {
        public object _instance;
        public object _instantiationCompletion;
        public object ExternalUserIdProperty;
        public object _s_Services;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x79A27A0
        public void set_Instance(){} // RVA: 0x79A2800
        public void get_InstantiationCompletion(){} // RVA: 0x79A28B0
        public void get_s_Services(){} // RVA: 0x79A2910
        public void get_State(){} // RVA: 0x79A2970
        public void get_ExternalUserId(){} // RVA: 0x79A2B40
        public void set_ExternalUserId(){} // RVA: 0x79A2BB0
        public void ClearServices(){} // RVA: 0x79A2C80
        public void .cctor(){} // RVA: 0x79A2D30
    }

    public class UnityServicesBuilder : Object
    {
        public object _instanceCreationDelegate;

        // ── Methods ──
        public void set_InstanceCreationDelegate(){} // RVA: 0x79A2EB0
    }

    public class UnityThreadUtils : Object
    {
        public object s_UnityThreadId;
        public object _unityThreadScheduler;

        // ── Methods ──
        public void set_UnityThreadScheduler(){} // RVA: 0x79A2F50
        public void CaptureUnityThreadInfo(){} // RVA: 0x79A2FF0
        public void get_IsRunningOnUnityThread(){} // RVA: 0x79A3150
    }

}