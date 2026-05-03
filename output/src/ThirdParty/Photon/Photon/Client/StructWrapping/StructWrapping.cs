// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.StructWrapping
// Classes: 6
// Methods: 27

namespace ThirdParty.Photon.Photon.Client.StructWrapping
{
    public class StructWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D8A210
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void ToString(){}
    }

    public class StructWrapperPool : Object
    {
        // ── Methods ──
        public void GetWrappedType(){} // RVA: 0x7FFE86D8A270
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class StructWrapperPool`1 : StructWrapperPool
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E466C0
        public void Acquire(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Release(){} // RVA: 0x7FFE80E460A0
    }

    public class StructWrapperPools : Object
    {
        // ── Methods ──
        public void GetPoolForType(){} // RVA: 0x7FFE80E2E2E0
        public void Acquire(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void Clear(){} // RVA: 0x7FFE86D8A640
        public void .ctor(){} // RVA: 0x7FFE86D8A860
        public void .cctor(){} // RVA: 0x7FFE86D8A9C0
    }

    public class StructWrapperUtility : Object
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x7FFE810A1420
        public void Get(){} // RVA: 0x7FFE810A1420
    }

    public class StructWrapper`1 : StructWrapper
    {
        public Photon.Client.StructWrapping.StructWrapperPool`1<T> _returnPool;

        // ── Methods ──
        public void get_ReturnPool(){} // RVA: 0x7FFE80E2E2E0
        public void set_ReturnPool(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Unwrap(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

}