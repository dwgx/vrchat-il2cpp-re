// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Threading.Tasks
// Classes: 1
// Methods: 11

namespace ThirdParty.DotNet.System.Threading.Tasks
{
    public class DebuggerSupport : Object
    {
        public object s_activeTasks;
        public object s_activeTasksLock;

        // ── Methods ──
        public void get_LoggingOn(){} // RVA: 0xB43320
        public void TraceOperationCreation(){} // RVA: 0xB43310
        public void TraceOperationCompletion(){} // RVA: 0xB43310
        public void TraceOperationRelation(){} // RVA: 0xB43310
        public void TraceSynchronousWorkStart(){} // RVA: 0xB43310
        public void TraceSynchronousWorkCompletion(){} // RVA: 0xB43310
        public void AddToActiveTasks(){} // RVA: 0x69BCBE0
        public void AddToActiveTasksNonInlined(){} // RVA: 0x69BCC80
        public void RemoveFromActiveTasks(){} // RVA: 0x69BCE50
        public void RemoveFromActiveTasksNonInlined(){} // RVA: 0x69BCEF0
        public void .cctor(){} // RVA: 0x69BD0B0
    }

}