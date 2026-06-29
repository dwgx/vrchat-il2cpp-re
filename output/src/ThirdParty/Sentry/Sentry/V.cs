// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 3
// Methods: 13

namespace ThirdParty.Sentry.Sentry
{
    public class ViewHierarchy : Object
    {
        public object _renderingSystem;
        public object _windows;

        // ── Methods ──
        public void get_RenderingSystem(){} // RVA: 0xB5DBF0
        public void set_RenderingSystem(){} // RVA: 0xB44D60
        public void get_Windows(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x6E3B450
        public void WriteTo(){} // RVA: 0x6E3B570
    }

    public class ViewHierarchyAttachment : SentryAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E3B870
    }

    public class ViewHierarchyNode : Object
    {
        public object _children;
        public object _type;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB465B0
        public void set_Type(){} // RVA: 0xBA9BA0
        public void get_Children(){} // RVA: 0x6E3B8F0
        public void set_Children(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xBA9BA0
        public void WriteTo(){} // RVA: 0x6E3B9B0
        public void WriteAdditionalProperties(){} // RVA: 0x8943B0
    }

}