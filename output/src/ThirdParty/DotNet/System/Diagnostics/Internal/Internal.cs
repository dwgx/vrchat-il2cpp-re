// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Internal
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.System.Diagnostics.Internal
{
    public class ILReader : Object
    {
        public System.Reflection.Emit.OpCode[] singleByteOpCode;
        public System.Reflection.Emit.OpCode[] doubleByteOpCode; // 0x8
        public byte[] _cil; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_OpCode(){} // RVA: 0x7FFE86F97A40
        public void set_OpCode(){} // RVA: 0x7FFE86F97A50
        public void get_MetadataToken(){} // RVA: 0x7FFE81A56130
        public void set_MetadataToken(){} // RVA: 0x7FFE82447980
        public void get_Operand(){} // RVA: 0x7FFE81129130
        public void set_Operand(){} // RVA: 0x7FFE810FCE90
        public void Read(){} // RVA: 0x7FFE86F97A60
        public void ReadOpCode(){} // RVA: 0x7FFE86F97C00
        public void ReadOperand(){} // RVA: 0x7FFE86F97D10
        public void ReadByte(){} // RVA: 0x7FFE86F98070
        public void ReadInt(){} // RVA: 0x7FFE86F980B0
        public void .cctor(){} // RVA: 0x7FFE86F98150
        public void GetOpCodeFields(){} // RVA: 0x7FFE86F98470
    }

    public class PortablePdbReader : Object
    {
        // ── Methods ──
        public void PopulateStackFrame(){} // RVA: 0x7FFE86F98540
        public void GetMetadataReader(){} // RVA: 0x7FFE86F98CC0
        public void GetPdbPath(){} // RVA: 0x7FFE86F98E10
        public void IsPortable(){} // RVA: 0x7FFE86F991B0
        public void Dispose(){} // RVA: 0x7FFE86F99300
        public void .ctor(){} // RVA: 0x7FFE86F994B0
    }

    public class ReflectionHelper : Object
    {
        // ── Methods ──
        public void IsValueTuple(){} // RVA: 0x7FFE86F995F0
    }

}