// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst.Intrinsics
// Classes: 10
// Methods: 25

namespace ThirdParty.Other.Unity.Burst.Intrinsics
{
    public class Common : Object
    {
        // ── Methods ──
        public void umul128(){} // RVA: 0x7FFD5492CBF0
    }

    public class DoGetCSRTrampoline_0000012A$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD5492DD70
        public void GetFunctionPointer(){} // RVA: 0x7FFD5492DEB0
        public void Constructor(){} // RVA: 0x7FFD5492E020
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5492E020
        public void Invoke(){} // RVA: 0x7FFD5492E0E0
    }

    public class DoGetCSRTrampoline_0000012A$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5098C080
        public void Invoke(){} // RVA: 0x7FFD4E39FA50
    }

    public class DoSetCSRTrampoline_00000129$BurstDirectCall : Object
    {
        public UIntPtr Pointer;
        public UIntPtr DeferredCompilation; // 0x8

        // ── Methods ──
        public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD5492D810
        public void GetFunctionPointer(){} // RVA: 0x7FFD5492D950
        public void Constructor(){} // RVA: 0x7FFD5492DAC0
        public void Initialize(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5492DAC0
        public void Invoke(){} // RVA: 0x7FFD5492DB80
    }

    public class DoSetCSRTrampoline_00000129$PostfixBurstDelegate : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E432370
        public void Invoke(){} // RVA: 0x7FFD4E39CC60
    }

    public class V64DebugView : Object
    {
    }

    public class X86 : Object
    {
        // ── Methods ──
        public void BurstIntrinsicSetCSRFromManaged(){} // RVA: 0x7FFD4E341310
        public void BurstIntrinsicGetCSRFromManaged(){} // RVA: 0x7FFD4E919180
        public void DoSetCSRTrampoline(){} // RVA: 0x7FFD5492CC80
        public void DoGetCSRTrampoline(){} // RVA: 0x7FFD5492CEA0
        public void DoSetCSRTrampoline$BurstManaged(){} // RVA: 0x7FFD4E9F2DD0
        public void DoGetCSRTrampoline$BurstManaged(){} // RVA: 0x7FFD51B532B0
    }

    public class v128 : ValueType
    {
        public byte Byte0; // 0x10
        public byte Byte1; // 0x11
        public byte Byte2; // 0x12
        public byte Byte3; // 0x13
        public byte Byte4; // 0x14
        public byte Byte5; // 0x15
        public byte Byte6; // 0x16
        public byte Byte7; // 0x17
        public byte Byte8; // 0x18
        public byte Byte9; // 0x19
        public byte Byte10; // 0x1A
        public byte Byte11; // 0x1B
        public byte Byte12; // 0x1C
        public byte Byte13; // 0x1D
        public byte Byte14; // 0x1E
        public byte Byte15; // 0x1F
        public sbyte SByte0; // 0x10
        public sbyte SByte1; // 0x11
        public sbyte SByte2; // 0x12
        public sbyte SByte3; // 0x13
        public sbyte SByte4; // 0x14
        public sbyte SByte5; // 0x15
        public sbyte SByte6; // 0x16
        public sbyte SByte7; // 0x17
        public sbyte SByte8; // 0x18
        public sbyte SByte9; // 0x19
        public sbyte SByte10; // 0x1A
        public sbyte SByte11; // 0x1B
        public sbyte SByte12; // 0x1C
        public sbyte SByte13; // 0x1D
        public sbyte SByte14; // 0x1E
        public sbyte SByte15; // 0x1F
        public ushort UShort0; // 0x10
        public ushort UShort1; // 0x12
        public ushort UShort2; // 0x14
        public ushort UShort3; // 0x16
        public ushort UShort4; // 0x18
        public ushort UShort5; // 0x1A
        public ushort UShort6; // 0x1C
        public ushort UShort7; // 0x1E
        public short SShort0; // 0x10
        public short SShort1; // 0x12
        public short SShort2; // 0x14
        public short SShort3; // 0x16
        public short SShort4; // 0x18
        public short SShort5; // 0x1A
        public short SShort6; // 0x1C
        public short SShort7; // 0x1E
        public uint UInt0; // 0x10
        public uint UInt1; // 0x14
        public uint UInt2; // 0x18
        public uint UInt3; // 0x1C
        public int SInt0; // 0x10
        public int SInt1; // 0x14
        public int SInt2; // 0x18
        public int SInt3; // 0x1C
        public ulong ULong0; // 0x10
        public ulong ULong1; // 0x18
        public long SLong0; // 0x10
        public long SLong1; // 0x18
        public float Float0; // 0x10
        public float Float1; // 0x14
        public float Float2; // 0x18
        public float Float3; // 0x1C
        public double Double0; // 0x10
        public double Double1; // 0x18
        public ions.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current.onBehaviourUpdate Lo64; // 0x10
        public ions.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current.onBehaviourUpdate Hi64; // 0x18
    }

    public class v256 : ValueType
    {
        public byte Byte0; // 0x10
        public byte Byte1; // 0x11
        public byte Byte2; // 0x12
        public byte Byte3; // 0x13
        public byte Byte4; // 0x14
        public byte Byte5; // 0x15
        public byte Byte6; // 0x16
        public byte Byte7; // 0x17
        public byte Byte8; // 0x18
        public byte Byte9; // 0x19
        public byte Byte10; // 0x1A
        public byte Byte11; // 0x1B
        public byte Byte12; // 0x1C
        public byte Byte13; // 0x1D
        public byte Byte14; // 0x1E
        public byte Byte15; // 0x1F
        public byte Byte16; // 0x20
        public byte Byte17; // 0x21
        public byte Byte18; // 0x22
        public byte Byte19; // 0x23
        public byte Byte20; // 0x24
        public byte Byte21; // 0x25
        public byte Byte22; // 0x26
        public byte Byte23; // 0x27
        public byte Byte24; // 0x28
        public byte Byte25; // 0x29
        public byte Byte26; // 0x2A
        public byte Byte27; // 0x2B
        public byte Byte28; // 0x2C
        public byte Byte29; // 0x2D
        public byte Byte30; // 0x2E
        public byte Byte31; // 0x2F
        public sbyte SByte0; // 0x10
        public sbyte SByte1; // 0x11
        public sbyte SByte2; // 0x12
        public sbyte SByte3; // 0x13
        public sbyte SByte4; // 0x14
        public sbyte SByte5; // 0x15
        public sbyte SByte6; // 0x16
        public sbyte SByte7; // 0x17
        public sbyte SByte8; // 0x18
        public sbyte SByte9; // 0x19
        public sbyte SByte10; // 0x1A
        public sbyte SByte11; // 0x1B
        public sbyte SByte12; // 0x1C
        public sbyte SByte13; // 0x1D
        public sbyte SByte14; // 0x1E
        public sbyte SByte15; // 0x1F
        public sbyte SByte16; // 0x20
        public sbyte SByte17; // 0x21
        public sbyte SByte18; // 0x22
        public sbyte SByte19; // 0x23
        public sbyte SByte20; // 0x24
        public sbyte SByte21; // 0x25
        public sbyte SByte22; // 0x26
        public sbyte SByte23; // 0x27
        public sbyte SByte24; // 0x28
        public sbyte SByte25; // 0x29
        public sbyte SByte26; // 0x2A
        public sbyte SByte27; // 0x2B
        public sbyte SByte28; // 0x2C
        public sbyte SByte29; // 0x2D
        public sbyte SByte30; // 0x2E
        public sbyte SByte31; // 0x2F
        public ushort UShort0; // 0x10
        public ushort UShort1; // 0x12
        public ushort UShort2; // 0x14
        public ushort UShort3; // 0x16
        public ushort UShort4; // 0x18
        public ushort UShort5; // 0x1A
        public ushort UShort6; // 0x1C
        public ushort UShort7; // 0x1E
        public ushort UShort8; // 0x20
        public ushort UShort9; // 0x22
        public ushort UShort10; // 0x24
        public ushort UShort11; // 0x26
        public ushort UShort12; // 0x28
        public ushort UShort13; // 0x2A
        public ushort UShort14; // 0x2C
        public ushort UShort15; // 0x2E
        public short SShort0; // 0x10
        public short SShort1; // 0x12
        public short SShort2; // 0x14
        public short SShort3; // 0x16
        public short SShort4; // 0x18
        public short SShort5; // 0x1A
        public short SShort6; // 0x1C
        public short SShort7; // 0x1E
        public short SShort8; // 0x20
        public short SShort9; // 0x22
        public short SShort10; // 0x24
        public short SShort11; // 0x26
        public short SShort12; // 0x28
        public short SShort13; // 0x2A
        public short SShort14; // 0x2C
        public short SShort15; // 0x2E
        public uint UInt0; // 0x10
        public uint UInt1; // 0x14
        public uint UInt2; // 0x18
        public uint UInt3; // 0x1C
        public uint UInt4; // 0x20
        public uint UInt5; // 0x24
        public uint UInt6; // 0x28
        public uint UInt7; // 0x2C
        public int SInt0; // 0x10
        public int SInt1; // 0x14
        public int SInt2; // 0x18
        public int SInt3; // 0x1C
        public int SInt4; // 0x20
        public int SInt5; // 0x24
        public int SInt6; // 0x28
        public int SInt7; // 0x2C
        public ulong ULong0; // 0x10
        public ulong ULong1; // 0x18
        public ulong ULong2; // 0x20
        public ulong ULong3; // 0x28
        public long SLong0; // 0x10
        public long SLong1; // 0x18
        public long SLong2; // 0x20
        public long SLong3; // 0x28
        public float Float0; // 0x10
        public float Float1; // 0x14
        public float Float2; // 0x18
        public float Float3; // 0x1C
        public float Float4; // 0x20
        public float Float5; // 0x24
        public float Float6; // 0x28
        public float Float7; // 0x2C
        public double Double0; // 0x10
        public double Double1; // 0x18
        public double Double2; // 0x20
        public double Double3; // 0x28
        public ions.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current.elegate Lo128; // 0x10
        public ions.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current.elegate Hi128; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FD9E290 | overloaded x2
    }

    public class v64 : ValueType
    {
        public byte Byte0; // 0x10
        public byte Byte1; // 0x11
        public byte Byte2; // 0x12
        public byte Byte3; // 0x13
        public byte Byte4; // 0x14
        public byte Byte5; // 0x15
        public byte Byte6; // 0x16
        public byte Byte7; // 0x17
        public sbyte SByte0; // 0x10
        public sbyte SByte1; // 0x11
        public sbyte SByte2; // 0x12
        public sbyte SByte3; // 0x13
        public sbyte SByte4; // 0x14
        public sbyte SByte5; // 0x15
        public sbyte SByte6; // 0x16
        public sbyte SByte7; // 0x17
        public ushort UShort0; // 0x10
        public ushort UShort1; // 0x12
        public ushort UShort2; // 0x14
        public ushort UShort3; // 0x16
        public short SShort0; // 0x10
        public short SShort1; // 0x12
        public short SShort2; // 0x14
        public short SShort3; // 0x16
        public uint UInt0; // 0x10
        public uint UInt1; // 0x14
        public int SInt0; // 0x10
        public int SInt1; // 0x14
        public ulong ULong0; // 0x10
        public long SLong0; // 0x10
        public float Float0; // 0x10
        public float Float1; // 0x14
        public double Double0; // 0x10
    }

}