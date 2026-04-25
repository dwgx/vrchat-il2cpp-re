// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Versioning
// Classes: 11
// Methods: 23

namespace ThirdParty.DotNet.System.Runtime.Versioning
{
    public class BinaryCompatibility : Object
    {
        public bool TargetsAtLeast_Desktop_V4_5;
        public bool TargetsAtLeast_Desktop_V4_5_1; // 0x1

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC849D8B0
    }

    public class NonVersionableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OSPlatformAttribute : Attribute
    {
        public string PlatformName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_PlatformName(){} // RVA: 0x7FFAC2F3C380
    }

    public class ObsoletedOSPlatformAttribute : OSPlatformAttribute
    {
        public string Message; // 0x18
        public string Url; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_Message(){} // RVA: 0x7FFAC2F247C0
        public void get_Url(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Url(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class RequiresPreviewFeaturesAttribute : Attribute
    {
        public string Message; // 0x10
        public string Url; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_Message(){} // RVA: 0x7FFAC2F3C380
        public void get_Url(){} // RVA: 0x7FFAC2F247C0
        public void set_Url(){} // RVA: 0x7FFAC2F87E80
    }

    public class SupportedOSPlatformAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class SupportedOSPlatformGuardAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class TargetFrameworkAttribute : Attribute
    {
        public string FrameworkDisplayName; // 0x10
        public string _frameworkDisplayName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC849D800
        public void set_FrameworkDisplayName(){} // RVA: 0x7FFAC2F87E80
    }

    public class TargetPlatformAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class UnsupportedOSPlatformAttribute : OSPlatformAttribute
    {
        public string Message; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void get_Message(){} // RVA: 0x7FFAC2F247C0
    }

    public class UnsupportedOSPlatformGuardAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

}