// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Internal
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.System.Diagnostics.Internal
{
    public class ILReader
    {
        public System.Reflection.Emit.OpCode[] singleByteOpCode;
        public System.Reflection.Emit.OpCode[] doubleByteOpCode; // 0x8
        public byte[] _cil; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_OpCode(){} // RVA: 0x6457060
        public void set_OpCode(){} // RVA: 0x6457070
        public void get_MetadataToken(){} // RVA: 0xCEF5B0
        public void set_MetadataToken(){} // RVA: 0x16E1F00
        public void get_Operand(){} // RVA: 0x30B130
        public void set_Operand(){} // RVA: 0x2DEE90
        public void Read(){} // RVA: 0x6457080
        public void ReadOpCode(){} // RVA: 0x6457220
        public void ReadOperand(){} // RVA: 0x6457330
        public void ReadByte(){} // RVA: 0x6457690
        public void ReadInt(){} // RVA: 0x64576D0
        public void .cctor(){} // RVA: 0x6457770
        public void GetOpCodeFields(){} // RVA: 0x6457A90
    }

    public class PortablePdbReader : PopulateStackFrame
    {
        // ── Methods ──
        public void PopulateStackFrame(){} // RVA: 0x6457B60
        public void GetMetadataReader(){} // RVA: 0x64582E0
        public void GetPdbPath(){} // RVA: 0x6458430
        public void IsPortable(){} // RVA: 0x64587D0
        public void Dispose(){} // RVA: 0x6458920
        public void .ctor(){} // RVA: 0x6458AD0
    }

    public class ReflectionHelper
    {
        // ── Methods ──
        public void IsValueTuple(){} // RVA: 0x6458C10
    }

}