// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 3
// Methods: 13

namespace ThirdParty.Sentry.Sentry
{
    public class ViewHierarchy : Object
    {
        public string _renderingSystem; // 0x10
        public System.Collections.Generic.List`1<Sentry.ViewHierarchyNode> _windows; // 0x18

        // ── Methods ──
        public void get_RenderingSystem(){} // RVA: 0x7FFE81116380
        public void set_RenderingSystem(){} // RVA: 0x7FFE810FCE30
        public void get_Windows(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE86F0CDF0
        public void WriteTo(){} // RVA: 0x7FFE86F0CF10
    }

    public class ViewHierarchyAttachment : SentryAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F0D150
    }

    public class ViewHierarchyNode : Object
    {
        public System.Collections.Generic.List`1<Sentry.ViewHierarchyNode> _children; // 0x10
        public string _type; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE810FE7C0
        public void set_Type(){} // RVA: 0x7FFE81161E80
        public void get_Children(){} // RVA: 0x7FFE86F0D1D0
        public void set_Children(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void WriteTo(){} // RVA: 0x7FFE86F0D290
        public void WriteAdditionalProperties(){} // RVA: 0x7FFE80E4F230
    }

}