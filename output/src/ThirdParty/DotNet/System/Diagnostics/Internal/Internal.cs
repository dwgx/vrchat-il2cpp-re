// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Internal
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.System.Diagnostics.Internal
{
    public class ILReader : Object
    {
        public System.Reflection.Emit.OpCode[] OpCode;
        public System.Reflection.Emit.OpCode[] MetadataToken; // 0x8
        public byte[] Operand; // 0x10
        public int ptr; // 0x18
        public System.Reflection.Emit.OpCode <OpCode>k__BackingField; // 0x1C
        public int <MetadataToken>k__BackingField; // 0x24
        public System.Reflection.MemberInfo <Operand>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_OpCode(){} // RVA: 0x7FFAC8BEE3E0
        public void set_OpCode(){} // RVA: 0x7FFAC8BEE3F0
        public void get_MetadataToken(){} // RVA: 0x7FFAC3921980
        public void set_MetadataToken(){} // RVA: 0x7FFAC41674D0
        public void get_Operand(){} // RVA: 0x7FFAC2F4F130
        public void set_Operand(){} // RVA: 0x7FFAC2F22E90
        public void Read(){} // RVA: 0x7FFAC8BEE400
        public void ReadOpCode(){} // RVA: 0x7FFAC8BEE5A0
        public void ReadOperand(){} // RVA: 0x7FFAC8BEE6B0
        public void ReadByte(){} // RVA: 0x7FFAC8BEEA10
        public void ReadInt(){} // RVA: 0x7FFAC8BEEA50
        public void .cctor(){} // RVA: 0x7FFAC8BEEAF0
        public void GetOpCodeFields(){} // RVA: 0x7FFAC8BEEE10
    }

    public class PortablePdbReader : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Reflection.Metadata.MetadataReaderProvider> _cache; // 0x10

        // ── Methods ──
        public void PopulateStackFrame(){} // RVA: 0x7FFAC8BEEEE0
        public void GetMetadataReader(){} // RVA: 0x7FFAC8BEF660
        public void GetPdbPath(){} // RVA: 0x7FFAC8BEF7B0
        public void IsPortable(){} // RVA: 0x7FFAC8BEFB50
        public void Dispose(){} // RVA: 0x7FFAC8BEFCA0
        public void .ctor(){} // RVA: 0x7FFAC8BEFE50
    }

    public class ReflectionHelper : Object
    {
        // ── Methods ──
        public void IsValueTuple(){} // RVA: 0x7FFAC8BEFF90
    }

}