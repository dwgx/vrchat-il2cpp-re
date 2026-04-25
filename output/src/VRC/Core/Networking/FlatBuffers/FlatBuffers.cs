// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers
// Classes: 5
// Methods: 18

namespace VRC.Core.Networking.FlatBuffers
{
    public class SparseArray32 : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void Read(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SparseArray8 : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void Read(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SparseOffset32 : Object
    {
        public int Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D6E1D0
        public void op_Implicit(){} // RVA: 0x7FFAC9D6E250 | overloaded x2
    }

    public class SparseOffset8 : Object
    {
        public byte Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9D6E090
        public void op_Implicit(){} // RVA: 0x7FFAC9D6E150 | overloaded x4
    }

    public class SparseUtils : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,TypeHandler> TypeHandlers;

        // ── Methods ──
        public void CountSpaceNeeded(){} // RVA: 0x7FFAC9D6E330 | overloaded x2
        public void ComputeBitmap(){} // RVA: 0x7FFAC9D6E430
        public void QueryBitmap(){} // RVA: 0x7FFAC9D6E6A0
        public void SetBitmap(){} // RVA: 0x7FFAC9D6E6F0
        public void .cctor(){} // RVA: 0x7FFAC9D6E760
    }

}