// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Integrations
// Classes: 6
// Methods: 27

namespace ThirdParty.Sentry.Sentry.Integrations
{
    public class AppDomainProcessExitIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE229AE0
        public void Register(){} // RVA: 0x7AE229BA0
        public void HandleProcessExit(){} // RVA: 0x7AE229D10
    }

    public class AppDomainUnhandledExceptionIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE229DD0
        public void Register(){} // RVA: 0x7AE229E90
        public void Handle(){} // RVA: 0x7AE22A060
    }

    public class AutoSessionTrackingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7AE22A1E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ISdkIntegration
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7A7E18890
    }

    public class ISdkIntegration[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class UnobservedTaskExceptionIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE22A250
        public void Register(){} // RVA: 0x7AE22A310
        public void Handle(){} // RVA: 0x7AE22A470
    }

}