// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.VM
// Classes: 4
// Methods: 21

namespace VRC.Udon.VM
{
    public class IUdonVMTimeSource
    {
        public object CurrentTime;

        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7FFAC2C58E90
    }

    public class UdonVM : Object
    {
        public int DebugLogging;
        public int INITIAL_STACK_SIZE;
        public string INSTRUCTION_SET_IDENTIFIER;
        public int INSTRUCTION_SET_VERSION;
        public uint RESULT_SUCCESS;
        public uint RESULT_FAILURE;
        public int PARAMS_ARRAY_LENGTH;
        public uint[] _processedByteCode; // 0x10
        public VRC.Udon.Common.Interfaces.IUdonProgram _program; // 0x18
        public VRC.Udon.Common.Interfaces.IUdonHeap _heap; // 0x20
        public VRC.Udon.VM.Common.LightweightStack`1<uint> _stack; // 0x28
        public uint _programCounter; // 0x30
        public long MAX_VM_TIME_MS;
        public bool _halted; // 0x34
        public System.Buffers.ArrayPool`1<uint> _parametersArrayPool; // 0x38
        public VRC.Udon.Common.Interfaces.IUdonWrapper _udonWrapper; // 0x40
        public VRC.Udon.VM.IUdonVMTimeSource _timeSource; // 0x48
        public bool <DebugLogging>k__BackingField; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACA03D720
        public void get_DebugLogging(){} // RVA: 0x7FFAC2FDB8E0
        public void set_DebugLogging(){} // RVA: 0x7FFAC2FDB8F0
        public void LoadProgram(){} // RVA: 0x7FFACA03DAD0
        public void ProcessByteCode(){} // RVA: 0x7FFACA03DC00
        public void RetrieveProgram(){} // RVA: 0x7FFAC2F247C0
        public void Interpret(){} // RVA: 0x7FFACA03DE60
        public void CheckExecutionTimeLimit(){} // RVA: 0x7FFACA03EA20
        public void CheckJumpTarget(){} // RVA: 0x7FFACA03EB50
        public void UIntFromBytes(){} // RVA: 0x7FFACA03EC20
        public void SetProgramCounter(){} // RVA: 0x7FFACA03ECA0
        public void GetProgramCounter(){} // RVA: 0x7FFAC2F7CCD0
        public void InspectHeap(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class UdonVMException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACA03CBF0 | overloaded x4
        public void GenerateMessage(){} // RVA: 0x7FFACA03CC90
    }

    public class UdonVMFactory : Object
    {
        public VRC.Udon.Common.Interfaces.IUdonWrapperFactory _wrapperFactory; // 0x10
        public VRC.Udon.VM.IUdonVMTimeSource _udonVMTimeSource; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACA03D500
        public void ConstructUdonVM(){} // RVA: 0x7FFACA03D680
    }

}