// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.PlayerDrone
// Classes: 2
// Methods: 19

namespace VRC.PlayerDrone
{
    public class PIDController : ValueType
    {
        public object dFactor; // 0x3399D340
        public object finalValue; // 0x3399D340
        public object kReferenceDeltaTime; // 0x3399D340
        public object f_61C; // 0x170010D2, was: ÎÏÏÌÌÍÏÌÎÏÍÎÏÎÌÌÍÎÍÎÏÍÍ
        public object f_149; // 0x170010D3, was: ÏÎÍÌÏÎÎÎÎÏÌÏÌÏÌÏÌÌÌÏÍÎÌ
        public object f_A6F; // 0x170010D4, was: ÏÏÎÍÏÏÍÍÏÌÏÌÌÍÎÏÏÌÎÎÍÎÏ

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa909ef70
        public void InternalEquals(){} // RVA: 0x7ffaa909ef80
        public void DefaultEquals(){} // RVA: 0x7ffaa909f040
        public void InternalGetHashCode(){} // RVA: 0x7ffaa909f1c0
        public void ToString(){} // RVA: 0x7ffaa909f280
        public void ComputeControlOutput(){} // RVA: 0x7ffaa909f360
        public void ResetState(){} // RVA: 0x7ffaa909f420
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa909f100
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa909f2a0
    }

    public class PIDControllerQuaternion : ValueType
    {
        public object dFactor; // 0x340DF230
        public object kReferenceDeltaTime; // 0x340DF230
        public object dFactor; // 0x3399D340

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa909f440
        public void InternalEquals(){} // RVA: 0x7ffaa909f440
        public void InternalGetHashCode(){} // RVA: 0x7ffaa909f440
        public void ToString(){} // RVA: 0x7ffaa909f440
        public void UpdateTransform(){} // RVA: 0x7ffaa909fd10
        // ── Binary Analysis Named ──
        public void DoInternal_ToAxis(){} // RVA: 0x7ffaa909f4d0
        public void DoInverse_Injected(){} // RVA: 0x7ffaa909f8f0
        public void GetHashCode(){} // RVA: 0x7ffaa909f440
        public void GetHashCodeOfPtr(){} // RVA: 0x7ffaa909f440
        // ── Obfuscated Methods ──
        public void m_0B7(){} // RVA: 0x7ffaa90a0130
    }

}