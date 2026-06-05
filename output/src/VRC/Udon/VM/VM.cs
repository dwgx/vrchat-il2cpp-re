// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.VM
// Classes: 4
// Methods: 21

namespace VRC.Udon.VM
{
    public class IUdonVMTimeSource
    {
        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7FFAF2ABCD60
    }

    public class UdonVM
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA3634F0
        public void get_DebugLogging(){} // RVA: 0x7FFAF2E478E0
        public void set_DebugLogging(){} // RVA: 0x7FFAF2E478F0
        public void LoadProgram(){} // RVA: 0x7FFAFA3638A0
        public void ProcessByteCode(){} // RVA: 0x7FFAFA3639D0
        public void RetrieveProgram(){} // RVA: 0x7FFAF2D907C0
        public void Interpret(){} // RVA: 0x7FFAFA363C30
        public void CheckExecutionTimeLimit(){} // RVA: 0x7FFAFA3647F0
        public void CheckJumpTarget(){} // RVA: 0x7FFAFA364920
        public void UIntFromBytes(){} // RVA: 0x7FFAFA3649F0
        public void SetProgramCounter(){} // RVA: 0x7FFAFA364A70
        public void GetProgramCounter(){} // RVA: 0x7FFAF2DE8CD0
        public void InspectHeap(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class UdonVMException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA3629C0 | overloaded x4
        public void GenerateMessage(){} // RVA: 0x7FFAFA362A60
    }

    public class UdonVMFactory : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA3632D0
        public void ConstructUdonVM(){} // RVA: 0x7FFAFA363450
    }

}