// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.VM
// Classes: 4
// Methods: 21

namespace VRC.Udon.VM
{
    public class IUdonVMTimeSource
    {
        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0xCD60
    }

    public class UdonVM
    {
        public int ALIGNMENT_BYTES;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x78B34F0
        public void get_DebugLogging(){} // RVA: 0x3978E0
        public void set_DebugLogging(){} // RVA: 0x3978F0
        public void LoadProgram(){} // RVA: 0x78B38A0
        public void ProcessByteCode(){} // RVA: 0x78B39D0
        public void RetrieveProgram(){} // RVA: 0x2E07C0
        public void Interpret(){} // RVA: 0x78B3C30
        public void CheckExecutionTimeLimit(){} // RVA: 0x78B47F0
        public void CheckJumpTarget(){} // RVA: 0x78B4920
        public void UIntFromBytes(){} // RVA: 0x78B49F0
        public void SetProgramCounter(){} // RVA: 0x78B4A70
        public void GetProgramCounter(){} // RVA: 0x338CD0
        public void InspectHeap(){} // RVA: 0x30B0C0
    }

    public class UdonVMException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x78B29C0 | overloaded x4
        public void GenerateMessage(){} // RVA: 0x78B2A60
    }

    public class UdonVMFactory : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x78B32D0
        public void ConstructUdonVM(){} // RVA: 0x78B3450
    }

}