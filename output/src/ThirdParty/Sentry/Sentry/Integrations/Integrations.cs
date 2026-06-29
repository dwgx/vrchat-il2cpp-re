// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Integrations
// Classes: 6
// Methods: 27

namespace ThirdParty.Sentry.Sentry.Integrations
{
    public class AppDomainProcessExitIntegration : Object
    {
        public object _appDomain;
        public object _hub;
        public object _options;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EAC5A0
        public void Register(){} // RVA: 0x6EAC660
        public void HandleProcessExit(){} // RVA: 0x6EAC7D0
    }

    public class AppDomainUnhandledExceptionIntegration : Object
    {
        public object _appDomain;
        public object _hub;
        public object _options;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EAC890
        public void Register(){} // RVA: 0x6EAC950
        public void Handle(){} // RVA: 0x6EACB20
    }

    public class AutoSessionTrackingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x6EACCA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ISdkIntegration
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x8943B0
    }

    public class ISdkIntegration[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class UnobservedTaskExceptionIntegration : Object
    {
        public object MechanismKey;
        public object _appDomain;
        public object _hub;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EACD10
        public void Register(){} // RVA: 0x6EACDD0
        public void Handle(){} // RVA: 0x6EACF30
    }

}