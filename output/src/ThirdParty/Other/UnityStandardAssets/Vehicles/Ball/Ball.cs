// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Vehicles.Ball
// Classes: 2
// Methods: 7

namespace ThirdParty.Other.UnityStandardAssets.Vehicles.Ball
{
    public class Ball : MonoBehaviour
    {
        public float m_MovePower; // 0x20
        public bool m_UseTorque; // 0x24
        public float m_MaxAngularVelocity; // 0x28
        public float m_JumpPower; // 0x2C
        public float k_GroundRayLength;
        public Touched m_Rigidbody; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E36E210
        public void Move(){} // RVA: 0x7FFD4E36E310
        public void .ctor(){} // RVA: 0x7FFD4E36E730
    }

    public class BallUserControl : MonoBehaviour
    {
        public andle.iverHandle ball; // 0x20
        public amut move; // 0x28
        public object cam; // 0x38
        public amut camForward; // 0x40
        public bool jump; // 0x4C

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E36E790
        public void Update(){} // RVA: 0x7FFD4E36EB20
        public void FixedUpdate(){} // RVA: 0x7FFD4E36F070
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}