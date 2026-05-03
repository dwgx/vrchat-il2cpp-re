// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.VM
// Classes: 4
// Methods: 21

namespace VRC.Udon.VM
{
    public class IUdonVMTimeSource
    {
        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7FFE80E2E2E0
    }

    public class UdonVM : Object
    {
        public int ALIGNMENT_BYTES;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883F01D0
        public void get_DebugLogging(){} // RVA: 0x7FFE811B58E0
        public void set_DebugLogging(){} // RVA: 0x7FFE811B58F0
        public void LoadProgram(){} // RVA: 0x7FFE883F0580
        public void ProcessByteCode(){} // RVA: 0x7FFE883F06B0
        public void RetrieveProgram(){} // RVA: 0x7FFE810FE7C0
        public void Interpret(){} // RVA: 0x7FFE883F0910
        public void CheckExecutionTimeLimit(){} // RVA: 0x7FFE883F14D0
        public void CheckJumpTarget(){} // RVA: 0x7FFE883F1600
        public void UIntFromBytes(){} // RVA: 0x7FFE883F16D0
        public void SetProgramCounter(){} // RVA: 0x7FFE883F1750
        public void GetProgramCounter(){} // RVA: 0x7FFE81156CD0
        public void InspectHeap(){} // RVA: 0x7FFE811290C0
    }

    public class UdonVMException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883EF6A0 | overloaded x4
        public void GenerateMessage(){} // RVA: 0x7FFE883EF740
    }

    public class UdonVMFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE883EFFB0
        public void ConstructUdonVM(){} // RVA: 0x7FFE883F0130
    }

}