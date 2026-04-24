// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.StructWrapping
// Classes: 6
// Methods: 27

namespace ThirdParty.Photon.Photon.Client.StructWrapping
{
    public class StructWrapper : Object
    {
        public ÎÌÍÌÌÏÎ.ÌÍÎÏÍÏÎÌÍÌÌÏÎ wrappedType; // 0x10
        public object ttype; // 0x18

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
        public object tType;
        public ÎÌÍÌÌÏÎ.ÌÍÎÏÍÏÎÌÍÌÌÏÎ wType;
        public URA.leEastFrench<ÎÌÍÌÌÏÎ.ÍÎÌÌÌÏÍÍÌ<T1717720960>> pool;
        public bool isStaticPool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E091060
        public void Acquire(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Release(){} // RVA: 0x7FFD4E090A40
    }

    public class StructWrapperPools : Object
    {
        public ÎÌÍÌÌÏÎ.ÍÎÌÌÌÏÍÍÌ<byte>[] mappedByteWrappers;
        public ÎÌÍÌÌÏÎ.ÍÎÌÌÌÏÍÍÌ<bool>[] mappedBoolWrappers; // 0x8
        public URA.DateTime<?,ÎÌÍÌÌÏÎ.?> pools; // 0x10
        public URA.woDigitYearMax<Names> used; // 0x18

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
        public ÎÌÍÌÌÏÎ.?<T1717720944> ReturnPool;
        public ÎÌÍÌÌÏÎ.ÏÏÍÏÏÍÎÍÍÎÏÎÌÎÏÏ pooling;
        public T1717720944 value;
        public ÎÌÍÌÌÏÎ.?<T1717720944> staticPool;

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