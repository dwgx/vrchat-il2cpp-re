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
        public void Equals(){} // RVA: 0x7FFAC36788F0
        public void InternalEquals(){} // RVA: 0x7FFAC36789B0
        public void DefaultEquals(){} // RVA: 0x7FFAC3678A70
        public void GetHashCode(){} // RVA: 0x7FFAC3678B30
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3678B50
        public void ToString(){} // RVA: 0x7FFAC3678B60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3678B80
        public void ToString_B4312609E349(){} // RVA: 0x7FFAC3678BA0
        public void EnsureStaticProfilerInitialization(){} // RVA: 0x7FFAC3678BC0
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
        public void Equals(){} // RVA: 0x7FFAC3678BE0
        public void InternalEquals(){} // RVA: 0x7FFAC3679000
        public void DefaultEquals(){} // RVA: 0x7FFAC3679090
        public void GetHashCode(){} // RVA: 0x7FFAC3679000
        public void InternalGetHashCode(){} // RVA: 0x7FFAC36794B0
        public void ToString(){} // RVA: 0x7FFAC3679000
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3679000
        public void ComputeQuaternionControlOutput(){} // RVA: 0x7FFAC36798D0
        public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC3679CF0
        public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC367A110
    }

}