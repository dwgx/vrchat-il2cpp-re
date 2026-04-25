// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.PlayerDrone
// Classes: 2
// Methods: 19

namespace VRC.PlayerDrone
{
    public class PIDController : ValueType
    {
        public float pFactor; // 0x10
        public float iFactor; // 0x14
        public float dFactor; // 0x18
        public float integral; // 0x1C
        public float lastValue; // 0x20
        public float finalValue; // 0x24
        public float limit; // 0x28
        public bool derivativeInitialized; // 0x2C
        public float kReferenceDeltaTime;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EA988F0
        public void InternalEquals(){} // RVA: 0x7FFD4EA989B0
        public void DefaultEquals(){} // RVA: 0x7FFD4EA98A70
        public void GetHashCode(){} // RVA: 0x7FFD4EA98B30
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EA98B50
        public void ToString(){} // RVA: 0x7FFD4EA98B60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EA98B80
        public void ToString_B4312609E349(){} // RVA: 0x7FFD4EA98BA0
        public void EnsureStaticProfilerInitialization(){} // RVA: 0x7FFD4EA98BC0
    }

    public class PIDControllerQuaternion : ValueType
    {
        public float pFactor; // 0x10
        public float iFactor; // 0x14
        public float dFactor; // 0x18
        public UnityEngine.Vector3 integral; // 0x1C
        public UnityEngine.Vector3 lastError; // 0x28
        public float kReferenceDeltaTime;

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4EA98BE0
        public void InternalEquals(){} // RVA: 0x7FFD4EA99000
        public void DefaultEquals(){} // RVA: 0x7FFD4EA99090
        public void GetHashCode(){} // RVA: 0x7FFD4EA99000
        public void InternalGetHashCode(){} // RVA: 0x7FFD4EA994B0
        public void ToString(){} // RVA: 0x7FFD4EA99000
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4EA99000
        public void ComputeQuaternionControlOutput(){} // RVA: 0x7FFD4EA998D0
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFD4EA99CF0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFD4EA9A110
    }

}