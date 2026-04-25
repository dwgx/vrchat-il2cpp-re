// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Assets.OVR.Scripts
// Classes: 4
// Methods: 7

namespace ThirdParty.Other.Assets.OVR.Scripts
{
    public class FixMethodDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6058680
        public void Invoke(){} // RVA: 0x7FFAC307D4E0
        public void BeginInvoke(){} // RVA: 0x7FFAC89895C0
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class FixRecord : Record
    {
        public Assets.OVR.Scripts.FixMethodDelegate fixMethod; // 0x28
        public UnityEngine.Object targetObject; // 0x30
        public string[] buttonNames; // 0x38
        public bool editModeRequired; // 0x40
        public bool complete; // 0x41

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8989670
    }

    public class RangedRecord : Record
    {
        public float value; // 0x28
        public float min; // 0x2C
        public float max; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8989580
    }

    public class Record : Object
    {
        public int sortOrder; // 0x10
        public string category; // 0x18
        public string message; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5808D30
    }

}