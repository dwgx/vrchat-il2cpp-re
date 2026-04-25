// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.StructWrapping
// Classes: 6
// Methods: 27

namespace ThirdParty.Photon.Photon.Client.StructWrapping
{
    public class StructWrapper : Object
    {
        public 0x6B26BA50 wrappedType; // 0x10
        public System.Type ttype; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89E0B90
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void ToString(){}
    }

    public class StructWrapperPool : Object
    {
        // ── Methods ──
        public void GetWrappedType(){} // RVA: 0x7FFAC89E0BF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StructWrapperPool`1 : StructWrapperPool
    {
        public int GROWBY;
        public System.Type tType;
        public 0x6B26BA50 wType;
        public System.Collections.Generic.Stack`1<Photon.Client.StructWrapping.StructWrapper`1<T>> pool;
        public bool isStaticPool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C71060
        public void Acquire(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFAC2C70A40
    }

    public class StructWrapperPools : Object
    {
        public Photon.Client.StructWrapping.StructWrapper`1<byte>[] mappedByteWrappers;
        public Photon.Client.StructWrapping.StructWrapper`1<bool>[] mappedBoolWrappers; // 0x8
        public System.Collections.Generic.Dictionary`2<System.Type,Photon.Client.StructWrapping.StructWrapperPool> pools; // 0x10
        public System.Collections.Generic.List`1<System.IDisposable> used; // 0x18

        // ── Methods ──
        public void GetPoolForType(){} // RVA: 0x7FFAC2C58E90
        public void Acquire(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void Clear(){} // RVA: 0x7FFAC89E0FC0
        public void .ctor(){} // RVA: 0x7FFAC89E11E0
        public void .cctor(){} // RVA: 0x7FFAC89E1340
    }

    public class StructWrapperUtility : Object
    {
        // ── Methods ──
        public void Unwrap(){} // RVA: 0x7FFAC2E8DC40
        public void Get(){} // RVA: 0x7FFAC2E8DC40
    }

    public class StructWrapper`1 : StructWrapper
    {
        public Photon.Client.StructWrapping.StructWrapperPool`1<T> ReturnPool;
        public 0x6B26BAA8 pooling;
        public T value;
        public Photon.Client.StructWrapping.StructWrapperPool`1<T> staticPool;

        // ── Methods ──
        public void get_ReturnPool(){} // RVA: 0x7FFAC2C58E90
        public void set_ReturnPool(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Unwrap(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void ToString(){} // RVA: 0x7FFAC2C58E90 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

}