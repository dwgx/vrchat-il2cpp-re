// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.StructWrapping
// Classes: 6
// Methods: 27

namespace ThirdParty.Photon.Photon.Client.StructWrapping
{
    public class StructWrapper : Object
    {
        public 0x665CBA50 wrappedType; // 0x10
        public System.Type ttype; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53E00B90
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void ToString(){}
    }

    public class StructWrapperPool : Object
    {
        // ── Methods ──
        public void GetWrappedType(){} // RVA: 0x7FFD53E00BF0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class StructWrapperPool`1 : StructWrapperPool
    {
        public int GROWBY;
        public System.Type tType; // 0x10
        public 0x665CBA50 wType; // 0x18
        public System.Collections.Generic.Stack`1<Photon.Client.StructWrapping.StructWrapper`1<byte[]>> pool; // 0x20
        public bool isStaticPool; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E091060
        public void Acquire(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E090A40
    }

    public class StructWrapperPools : Object
    {
        public Photon.Client.StructWrapping.StructWrapper`1<byte>[] mappedByteWrappers;
        public Photon.Client.StructWrapping.StructWrapper`1<bool>[] mappedBoolWrappers; // 0x8
        public System.Collections.Generic.Dictionary`2<System.Type,Photon.Client.StructWrapping.StructWrapperPool> pools; // 0x10
        public System.Collections.Generic.List`1<System.IDisposable> used; // 0x18

        // ── Methods ──
        public void GetPoolForType(){} // RVA: 0x7FFD4E078E90
        public void Acquire(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void Clear(){} // RVA: 0x7FFD53E00FC0
        public void .ctor(){} // RVA: 0x7FFD53E011E0
        public void .cctor(){} // RVA: 0x7FFD53E01340
    }

    public class StructWrapperUtility : Object
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x7FFD4E2ADC40
        public void Get(){} // RVA: 0x7FFD4E2ADC40
    }

    public class StructWrapper`1 : StructWrapper
    {
        public Photon.Client.StructWrapping.StructWrapperPool`1<byte[]> ReturnPool; // 0x20
        public 0x665CBAA8 pooling; // 0x28
        public byte[] value; // 0x30
        public Photon.Client.StructWrapping.StructWrapperPool`1<byte[]> staticPool;

        // ── Methods ──
        public void get_ReturnPool(){} // RVA: 0x7FFD4E078E90
        public void set_ReturnPool(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Unwrap(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void ToString(){} // RVA: 0x7FFD4E078E90 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

}