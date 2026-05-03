// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 3
// Methods: 24

namespace ThirdParty.DotNet.System
{
    public class WeakReference : Object
    {
        public bool isLongReference; // 0x10
        public System.Runtime.InteropServices.GCHandle gcHandle; // 0x18
        public object field_2; // 0x1B0

        // ── Methods ──
        public void AllocateHandle(){} // RVA: 0x7FFE86A598F0
        public void .ctor(){} // RVA: 0x7FFE86A59980 | overloaded x4
        public void get_IsAlive(){} // RVA: 0x7FFE86A59AC0
        public void get_Target(){} // RVA: 0x7FFE86A59AF0
        public void set_Target(){} // RVA: 0x7FFE86A59B10
        public void get_TrackResurrection(){} // RVA: 0x7FFE811C55E0
        public void Finalize(){} // RVA: 0x7FFE86A59B20
        public void GetObjectData(){} // RVA: 0x7FFE86A59B70
    }

    public class WeakReference`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void GetObjectData(){}
        public void SetTarget(){} // RVA: 0x7FFE810A1420
        public void TryGetTarget(){} // RVA: 0x7FFE80E2F3B0
        public void Finalize(){} // RVA: 0x7FFE80E45FE0
    }

    public class WindowsConsoleDriver : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A59C90
        public void ReadKey(){} // RVA: 0x7FFE86A59D70
        public void IsModifierKey(){} // RVA: 0x7FFE86A59FC0
        public void GetStdHandle(){} // RVA: 0x7FFE86A59FF0
        public void GetConsoleScreenBufferInfo(){} // RVA: 0x7FFE86A5A080
        public void ReadConsoleInput(){} // RVA: 0x7FFE86A5A120
    }

}