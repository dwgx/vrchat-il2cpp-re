// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets._2D
// Classes: 5
// Methods: 20

namespace ThirdParty.Other.UnityStandardAssets._2D
{
    public class Camera2DFollow : MonoBehaviour
    {
        public UnityEngine.Transform target; // 0x20
        public float damping; // 0x28
        public float lookAheadFactor; // 0x2C
        public float lookAheadReturnSpeed; // 0x30
        public float lookAheadMoveThreshold; // 0x34
        public float m_OffsetZ; // 0x38
        public UnityEngine.Vector3 m_LastTargetPosition; // 0x3C
        public UnityEngine.Vector3 m_CurrentVelocity; // 0x48
        public UnityEngine.Vector3 m_LookAheadPos; // 0x54

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E37D250
        public void Update(){} // RVA: 0x7FFD4E37D450
        public void .ctor(){} // RVA: 0x7FFD4E37DA10
    }

    public class CameraFollow : MonoBehaviour
    {
        public float xMargin; // 0x20
        public float yMargin; // 0x24
        public float xSmooth; // 0x28
        public float ySmooth; // 0x2C
        public UnityEngine.Vector2 maxXAndY; // 0x30
        public UnityEngine.Vector2 minXAndY; // 0x38
        public UnityEngine.Transform m_Player; // 0x40

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E37DA70
        public void CheckXMargin(){} // RVA: 0x7FFD4E37DB90
        public void CheckYMargin(){} // RVA: 0x7FFD4E37DCD0
        public void Update(){} // RVA: 0x7FFD4E37DE10
        public void TrackPlayer(){} // RVA: 0x7FFD4E37DE20
        public void .ctor(){} // RVA: 0x7FFD4E37E690
    }

    public class Platformer2DUserControl : MonoBehaviour
    {
        public UnityStandardAssets._2D.PlatformerCharacter2D m_Character; // 0x20
        public bool m_Jump; // 0x28

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E37E6F0
        public void Update(){} // RVA: 0x7FFD4E37E780
        public void FixedUpdate(){} // RVA: 0x7FFD4E37E7F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class PlatformerCharacter2D : MonoBehaviour
    {
        public float m_MaxSpeed; // 0x20
        public float m_JumpForce; // 0x24
        public float m_CrouchSpeed; // 0x28
        public bool m_AirControl; // 0x2C
        public UnityEngine.LayerMask m_WhatIsGround; // 0x30
        public UnityEngine.Transform m_GroundCheck; // 0x38
        public float k_GroundedRadius;
        public bool m_Grounded; // 0x40
        public UnityEngine.Transform m_CeilingCheck; // 0x48
        public float k_CeilingRadius;
        public UnityEngine.Animator m_Anim; // 0x50
        public UnityEngine.Rigidbody2D m_Rigidbody2D; // 0x58
        public bool m_FacingRight; // 0x60

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E37E920
        public void FixedUpdate(){} // RVA: 0x7FFD4E37ED10
        public void Move(){} // RVA: 0x7FFD4E37F110
        public void Flip(){} // RVA: 0x7FFD4E37F530
        public void .ctor(){} // RVA: 0x7FFD4E37F6D0
    }

    public class Restarter : MonoBehaviour
    {
        // ── Methods ──
        public void OnTriggerEnter2D(){} // RVA: 0x7FFD4E37F730
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}