// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Internal
// Classes: 3
// Methods: 21

namespace ThirdParty.DotNet.System.Diagnostics.Internal
{
    public class ILReader : Object
    {
        public object singleByteOpCode;
        public object doubleByteOpCode;
        public object _cil;
        public object ptr;
        public object _opCode;
        public object _metadataToken;
        public object _operand;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_OpCode(){} // RVA: 0x6EC7850
        public void set_OpCode(){} // RVA: 0x6EC7860
        public void get_MetadataToken(){} // RVA: 0x15AF000
        public void set_MetadataToken(){} // RVA: 0x1FAA840
        public void get_Operand(){} // RVA: 0xB70160
        public void set_Operand(){} // RVA: 0xB44DC0
        public void Read(){} // RVA: 0x6EC7870
        public void ReadOpCode(){} // RVA: 0x6EC7A10
        public void ReadOperand(){} // RVA: 0x6EC7B20
        public void ReadByte(){} // RVA: 0x6EC7E60
        public void ReadInt(){} // RVA: 0x6EC7EA0
        public void .cctor(){} // RVA: 0x6EC7F40
        public void GetOpCodeFields(){} // RVA: 0x6EC8250
    }

    public class PortablePdbReader : Object
    {
        public object _cache;

        // ── Methods ──
        public void PopulateStackFrame(){} // RVA: 0x6EC82F0
        public void GetMetadataReader(){} // RVA: 0x6EC8A80
        public void GetPdbPath(){} // RVA: 0x6EC8BD0
        public void IsPortable(){} // RVA: 0x6EC8F80
        public void Dispose(){} // RVA: 0x6EC90E0
        public void .ctor(){} // RVA: 0x6EC92A0
    }

    public class ReflectionHelper : Object
    {
        // ── Methods ──
        public void IsValueTuple(){} // RVA: 0x6EC93E0
    }

}