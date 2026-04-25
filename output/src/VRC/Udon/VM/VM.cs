// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.VM
// Classes: 2
// Methods: 3

namespace VRC.Udon.VM
{
    public class IUdonVMTimeSource
    {
        public <>c<T> CurrentTime;

        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7FFD4E078E90
    }

    public class UdonVMFactory : Object
    {
        public VRC.Udon.Common.Interfaces.IUdonWrapperFactory _wrapperFactory; // 0x10
        public VRC.Udon.VM.IUdonVMTimeSource _udonVMTimeSource; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5545D500
        public void ConstructUdonVM(){} // RVA: 0x7FFD5545D680
    }

}