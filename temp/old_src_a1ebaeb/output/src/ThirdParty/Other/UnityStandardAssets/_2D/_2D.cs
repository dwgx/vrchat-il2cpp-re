// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets._2D
// Classes: 5
// Methods: 20

namespace ThirdParty.Other.UnityStandardAssets._2D
{
    public class Camera2DFollow : MonoBehaviour
    {
        public object lookAheadFactor; // 0x3374D3C0
        public object m_OffsetZ; // 0x3374D3C0
        public object m_LookAheadPos; // 0x3374D3C0
        public object xSmooth; // 0x33A14820

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa896e250
        public void Update(){} // RVA: 0x7ffaa896e450
        public void .ctor(){} // RVA: 0x7ffaa896ea10
    }

    public class CameraFollow : MonoBehaviour
    {
        public object xSmooth; // 0x33A14820
        public object minXAndY; // 0x33A14820
        public object m_Jump; // 0x33AB6CB0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa896ea70
        public void Update(){} // RVA: 0x7ffaa896ee10
        public void TrackPlayer(){} // RVA: 0x7ffaa896ee20
        public void .ctor(){} // RVA: 0x7ffaa896f690
        // ── Binary Analysis Named ──
        public void CheckXMargin(){} // RVA: 0x7ffaa896eb90
        public void CheckYMargin(){} // RVA: 0x7ffaa896ecd0
    }

    public class Platformer2DUserControl : MonoBehaviour
    {
        public object m_MaxSpeed; // 0x337A71D0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa896f6f0
        public void Update(){} // RVA: 0x7ffaa896f780
        public void FixedUpdate(){} // RVA: 0x7ffaa896f7f0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class PlatformerCharacter2D : MonoBehaviour
    {
        public object m_CrouchSpeed; // 0x337A71D0
        public object m_GroundCheck; // 0x337A71D0
        public object m_CeilingCheck; // 0x337A71D0
        public object m_Rigidbody2D; // 0x337A71D0
        public object value__; // 0x84421B30
        public object PlayableDirector; // 0x84421B30

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa896f920
        public void FixedUpdate(){} // RVA: 0x7ffaa896fd10
        public void Move(){} // RVA: 0x7ffaa8970110
        public void Flip(){} // RVA: 0x7ffaa8970530
        public void .ctor(){} // RVA: 0x7ffaa89706d0
    }

    public class Restarter : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnTriggerEnter2D(){} // RVA: 0x7ffaa8970730
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}