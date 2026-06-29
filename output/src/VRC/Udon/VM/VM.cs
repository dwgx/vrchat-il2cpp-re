// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.VM
// Classes: 4
// Methods: 18

namespace VRC.Udon.VM
{
    public class IUdonVMTimeSource
    {
        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x87C0A0
    }

    public class UdonVM : Object
    {
        public object ALIGNMENT_BYTES;
        public object INITIAL_STACK_SIZE;
        public object INSTRUCTION_SET_IDENTIFIER;
        public object INSTRUCTION_SET_VERSION;
        public object RESULT_SUCCESS;
        public object RESULT_FAILURE;
        public object PARAMS_ARRAY_LENGTH;
        public object _processedByteCode;
        public object _program;
        public object _heap;
        public object _stack;
        public object _programCounter;
        public object MAX_VM_TIME_MS;
        public object _halted;
        public object _parametersArrayPool;
        public object _udonWrapper;
        public object _timeSource;
        public object _debugLogging;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x84ED9B0
        public void get_DebugLogging(){} // RVA: 0xC00EC0
        public void set_DebugLogging(){} // RVA: 0xC00ED0
        public void LoadProgram(){} // RVA: 0x84EDD60
        public void ProcessByteCode(){} // RVA: 0x84EDE90
        public void RetrieveProgram(){} // RVA: 0xB465B0
        public void Interpret(){} // RVA: 0x84EE0F0
        public void CheckExecutionTimeLimit(){} // RVA: 0x84EECB0
        public void CheckJumpTarget(){} // RVA: 0x84EEDD0
        public void UIntFromBytes(){} // RVA: 0x84EEE90
        public void SetProgramCounter(){} // RVA: 0x84EEF10
        public void GetProgramCounter(){} // RVA: 0xB9E080
        public void InspectHeap(){} // RVA: 0xB700F0
    }

    public class UdonVMException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x84ECE80
        public void GenerateMessage(){} // RVA: 0x84ECF20
    }

    public class UdonVMFactory : Object
    {
        public object _wrapperFactory;
        public object _udonVMTimeSource;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x84ED790
        public void ConstructUdonVM(){} // RVA: 0x84ED910
    }

}