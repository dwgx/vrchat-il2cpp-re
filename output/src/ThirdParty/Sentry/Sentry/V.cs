// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 3
// Methods: 13

namespace ThirdParty.Sentry.Sentry
{
    public class ViewHierarchy : Object
    {
        public string RenderingSystem; // 0x10
        public System.Collections.Generic.List`1<Sentry.ViewHierarchyNode> Windows; // 0x18

        // ── Methods ──
        public void get_RenderingSystem(){} // RVA: 0x7FFAC2F3C380
        public void set_RenderingSystem(){} // RVA: 0x7FFAC2F22E30
        public void get_Windows(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC8B63780
        public void WriteTo(){} // RVA: 0x7FFAC8B638A0
    }

    public class ViewHierarchyAttachment : SentryAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B63AE0
    }

    public class ViewHierarchyNode : Object
    {
        public System.Collections.Generic.List`1<Sentry.ViewHierarchyNode> Type; // 0x10
        public string Children; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F247C0
        public void set_Type(){} // RVA: 0x7FFAC2F87E80
        public void get_Children(){} // RVA: 0x7FFAC8B63B60
        public void set_Children(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void WriteTo(){} // RVA: 0x7FFAC8B63C20
        public void WriteAdditionalProperties(){} // RVA: 0x7FFAC2C79B30
    }

}