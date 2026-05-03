// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Versioning
// Classes: 11
// Methods: 23

namespace ThirdParty.DotNet.System.Runtime.Versioning
{
    public class BinaryCompatibility : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE868471B0
    }

    public class NonVersionableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OSPlatformAttribute : Attribute
    {
        public string _platformName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_PlatformName(){} // RVA: 0x7FFE81116380
    }

    public class ObsoletedOSPlatformAttribute : OSPlatformAttribute
    {
        public string _message; // 0x18
        public string _url; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_Message(){} // RVA: 0x7FFE810FE7C0
        public void get_Url(){} // RVA: 0x7FFE811290C0
        public void set_Url(){} // RVA: 0x7FFE811290D0
    }

    public class RequiresPreviewFeaturesAttribute : Attribute
    {
        public string _message; // 0x10
        public string _url; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_Message(){} // RVA: 0x7FFE81116380
        public void get_Url(){} // RVA: 0x7FFE810FE7C0
        public void set_Url(){} // RVA: 0x7FFE81161E80
    }

    public class SupportedOSPlatformAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class SupportedOSPlatformGuardAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class TargetFrameworkAttribute : Attribute
    {
        public string _frameworkName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86847100
        public void set_FrameworkDisplayName(){} // RVA: 0x7FFE81161E80
    }

    public class TargetPlatformAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class UnsupportedOSPlatformAttribute : OSPlatformAttribute
    {
        public string _message; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void get_Message(){} // RVA: 0x7FFE810FE7C0
    }

    public class UnsupportedOSPlatformGuardAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

}