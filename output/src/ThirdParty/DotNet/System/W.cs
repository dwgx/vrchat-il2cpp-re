// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 3
// Methods: 24

namespace ThirdParty.DotNet.System
{
    public class WeakReference : Object
    {
        public bool IsAlive; // 0x10
        public System.Runtime.InteropServices.GCHandle Target; // 0x18

        // ── Methods ──
        public void AllocateHandle(){} // RVA: 0x7FFAC86B0140
        public void .ctor(){} // RVA: 0x7FFAC86B01D0 | overloaded x4
        public void get_IsAlive(){} // RVA: 0x7FFAC86B0310
        public void get_Target(){} // RVA: 0x7FFAC86B0340
        public void set_Target(){} // RVA: 0x7FFAC86B0360
        public void get_TrackResurrection(){} // RVA: 0x7FFAC2FEB5E0
        public void Finalize(){} // RVA: 0x7FFAC86B0370
        public void GetObjectData(){} // RVA: 0x7FFAC86B03C0
    }

    public class WeakReference`1 : Object
    {
        public System.Runtime.InteropServices.GCHandle handle;
        public bool trackResurrection;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void GetObjectData(){}
        public void SetTarget(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetTarget(){} // RVA: 0x7FFAC2C59F60
        public void Finalize(){} // RVA: 0x7FFAC2C70980
    }

    public class WindowsConsoleDriver : Object
    {
        public UIntPtr inputHandle; // 0x10
        public UIntPtr outputHandle; // 0x18
        public short defaultAttribute; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86B04E0
        public void ReadKey(){} // RVA: 0x7FFAC86B05C0
        public void IsModifierKey(){} // RVA: 0x7FFAC86B0810
        public void GetStdHandle(){} // RVA: 0x7FFAC86B0840
        public void GetConsoleScreenBufferInfo(){} // RVA: 0x7FFAC86B08D0
        public void ReadConsoleInput(){} // RVA: 0x7FFAC86B0970
    }

}