// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Runtime.Versioning
// Classes: 16
// Methods: 25

namespace ThirdParty.DotNet.System.Runtime.Versioning
{
    public class BinaryCompatibility : Object
    {
        public object TargetsAtLeast_Desktop_V4_5;
        public object TargetsAtLeast_Desktop_V4_5_1;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x677F600
    }

    public class NonVersionableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NonVersionableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NonVersionableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NonVersionableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NonVersionableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NonVersionableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OSPlatformAttribute : Attribute
    {
        public object _platformName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_PlatformName(){} // RVA: 0xB5DBF0
    }

    public class ObsoletedOSPlatformAttribute : OSPlatformAttribute
    {
        public object _message;
        public object _url;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Message(){} // RVA: 0xB465B0
        public void get_Url(){} // RVA: 0xB700F0
        public void set_Url(){} // RVA: 0xB70100
    }

    public class RequiresPreviewFeaturesAttribute : Attribute
    {
        public object _message;
        public object _url;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Message(){} // RVA: 0xB5DBF0
        public void get_Url(){} // RVA: 0xB465B0
        public void set_Url(){} // RVA: 0xBA9BA0
    }

    public class SupportedOSPlatformAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class SupportedOSPlatformGuardAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class TargetFrameworkAttribute : Attribute
    {
        public object _frameworkName;
        public object _frameworkDisplayName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x677F550
        public void set_FrameworkDisplayName(){} // RVA: 0xBA9BA0
    }

    public class TargetPlatformAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class UnsupportedOSPlatformAttribute : OSPlatformAttribute
    {
        public object _message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Message(){} // RVA: 0xB465B0
    }

    public class UnsupportedOSPlatformGuardAttribute : OSPlatformAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

}