// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets._2D
// Classes: 5
// Methods: 20

namespace ThirdParty.Other.UnityStandardAssets._2D
{
    public class Camera2DFollow : MonoBehaviour
    {
        public object target;
        public object damping;
        public object lookAheadFactor;
        public object lookAheadReturnSpeed;
        public object lookAheadMoveThreshold;
        public object m_OffsetZ;
        public object m_LastTargetPosition;
        public object m_CurrentVelocity;
        public object m_LookAheadPos;

        // ── Methods ──
        public void Start(){} // RVA: 0xB7E5E0
        public void Update(){} // RVA: 0xB7E820
        public void .ctor(){} // RVA: 0xB7EE60
    }

    public class CameraFollow : MonoBehaviour
    {
        public object xMargin;
        public object yMargin;
        public object xSmooth;
        public object ySmooth;
        public object maxXAndY;
        public object minXAndY;
        public object m_Player;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB7EEC0
        public void CheckXMargin(){} // RVA: 0xB7EF60
        public void CheckYMargin(){} // RVA: 0xB7F0E0
        public void Update(){} // RVA: 0xB7F260
        public void TrackPlayer(){} // RVA: 0xB7F270
        public void .ctor(){} // RVA: 0xB7FBB0
    }

    public class Platformer2DUserControl : MonoBehaviour
    {
        public object m_Character;
        public object m_Jump;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB7FC10
        public void Update(){} // RVA: 0xB7FCA0
        public void FixedUpdate(){} // RVA: 0xB7FD10
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class PlatformerCharacter2D : MonoBehaviour
    {
        public object m_MaxSpeed;
        public object m_JumpForce;
        public object m_CrouchSpeed;
        public object m_AirControl;
        public object m_WhatIsGround;
        public object m_GroundCheck;
        public object k_GroundedRadius;
        public object m_Grounded;
        public object m_CeilingCheck;
        public object k_CeilingRadius;
        public object m_Anim;
        public object m_Rigidbody2D;
        public object m_FacingRight;

        // ── Methods ──
        public void Awake(){} // RVA: 0xB7FE40
        public void FixedUpdate(){} // RVA: 0xB80110
        public void Move(){} // RVA: 0xB805D0
        public void Flip(){} // RVA: 0xB80900
        public void .ctor(){} // RVA: 0xB80AA0
    }

    public class Restarter : MonoBehaviour
    {
        // ── Methods ──
        public void OnTriggerEnter2D(){} // RVA: 0xB80B00
        public void .ctor(){} // RVA: 0xB43D60
    }

}