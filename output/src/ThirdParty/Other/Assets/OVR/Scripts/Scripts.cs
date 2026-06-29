// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Assets.OVR.Scripts
// Classes: 4
// Methods: 7

namespace ThirdParty.Other.Assets.OVR.Scripts
{
    public class FixMethodDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x40E2200
        public void Invoke(){} // RVA: 0xCA8D60
        public void BeginInvoke(){} // RVA: 0x6C60AB0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class FixRecord : Record
    {
        public object fixMethod;
        public object targetObject;
        public object buttonNames;
        public object editModeRequired;
        public object complete;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C60B20
    }

    public class RangedRecord : Record
    {
        public object value;
        public object min;
        public object max;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C60A70
    }

    public class Record : Object
    {
        public object sortOrder;
        public object category;
        public object message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x38BA2E0
    }

}