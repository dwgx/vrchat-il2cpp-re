// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon.VM
// Classes: 4
// Methods: 18

namespace VRC.Udon.VM
{
    public class IUdonVMTimeSource
    {
        // ── Methods ──
        public void get_CurrentTime(){} // RVA: 0x7A7E00680
    }

    public class UdonVM : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF6922D0
        public void get_DebugLogging(){} // RVA: 0x7A8192400
        public void set_DebugLogging(){} // RVA: 0x7A8192410
        public void LoadProgram(){} // RVA: 0x7AF692680
        public void ProcessByteCode(){} // RVA: 0x7AF6927B0
        public void RetrieveProgram(){} // RVA: 0x7A80DA7B0
        public void Interpret(){} // RVA: 0x7AF692A10
        public void CheckExecutionTimeLimit(){} // RVA: 0x7AF6935D0
        public void CheckJumpTarget(){} // RVA: 0x7AF693700
        public void UIntFromBytes(){} // RVA: 0x7AF6937D0
        public void SetProgramCounter(){} // RVA: 0x7AF693850
        public void GetProgramCounter(){} // RVA: 0x7A8133100
        public void InspectHeap(){} // RVA: 0x7A81052C0
    }

    public class UdonVMException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF691790
        public void GenerateMessage(){} // RVA: 0x7AF691830
    }

    public class UdonVMFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF6920B0
        public void ConstructUdonVM(){} // RVA: 0x7AF692230
    }

}