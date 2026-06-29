// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Burst
// Classes: 2
// Methods: 27

namespace VRC.Core.Burst
{
    public class DisposableJobHandle : ValueType
    {
        public object _jobHandle;
        public object _knownDisposableJobHandles;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA77790
        public void GetIncompleteDisposableJobs(){} // RVA: 0xA719E50
        public void CullCompleteJobs(){} // RVA: 0xA719EB0
        public void get_IsCompleted(){} // RVA: 0x95E880
        public void Complete(){} // RVA: 0x95E820
        public void Dispose(){} // RVA: 0xA777B0
        public void Equals(){} // RVA: 0xA777C0
        public void op_Equality(){} // RVA: 0xA71A200
        public void op_Inequality(){} // RVA: 0xA71A260
        public void op_Implicit(){} // RVA: 0xFE9840
        public void GetHashCode(){} // RVA: 0xA777D0
        public void .cctor(){} // RVA: 0xA71A3D0
    }

    public class DisposableJobHandle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAEB40
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E59340
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}