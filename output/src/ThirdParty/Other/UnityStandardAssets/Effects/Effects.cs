// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Effects
// Classes: 10
// Methods: 29

namespace ThirdParty.Other.UnityStandardAssets.Effects
{
    public class AfterburnerPhysicsForce : MonoBehaviour
    {
        public float effectAngle; // 0x20
        public float effectWidth; // 0x24
        public float effectDistance; // 0x28
        public float force; // 0x2C
        public UnityEngine.Collider[] m_Cols; // 0x30
        public UnityEngine.SphereCollider m_Sphere; // 0x38

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD4E34C440
        public void FixedUpdate(){} // RVA: 0x7FFD4E34C520
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E34CF20
        public void .ctor(){} // RVA: 0x7FFD4E34DC60
    }

    public class ExplosionFireAndDebris : MonoBehaviour
    {
        public UnityEngine.Transform[] debrisPrefabs; // 0x20
        public UnityEngine.Transform firePrefab; // 0x28
        public int numDebrisPieces; // 0x30
        public int numFires; // 0x34
        public InstantiationDelegate Instantiate;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E34DCC0
        public void AddFire(){} // RVA: 0x7FFD4E34DD60
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ExplosionPhysicsForce : MonoBehaviour
    {
        public float explosionForce; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E34EE40
        public void .ctor(){} // RVA: 0x7FFD4E34EEE0
    }

    public class Explosive : MonoBehaviour
    {
        public UnityEngine.Transform explosionPrefab; // 0x20
        public float detonationImpactVelocity; // 0x28
        public float sizeMultiplier; // 0x2C
        public bool reset; // 0x30
        public float resetTimeDelay; // 0x34
        public bool m_Exploded; // 0x38
        public UnityStandardAssets.Utility.ObjectResetter m_ObjectResetter; // 0x40
        public InstantiationDelegate Instantiate;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E34F630
        public void OnCollisionEnter(){} // RVA: 0x7FFD4E34F6C0
        public void Reset(){} // RVA: 0x7FFD4E34F7C0
        public void .ctor(){} // RVA: 0x7FFD4E34F7D0
    }

    public class ExtinguishableParticleSystem : MonoBehaviour
    {
        public float multiplier; // 0x20
        public UnityEngine.ParticleSystem[] m_Systems; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E34FE10
        public void Extinguish(){} // RVA: 0x7FFD4E34FEC0
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class FireLight : MonoBehaviour
    {
        public float m_Rnd; // 0x20
        public bool m_Burning; // 0x24
        public UnityEngine.Light m_Light; // 0x28

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E34FFC0
        public void Update(){} // RVA: 0x7FFD4E350090
        public void Extinguish(){} // RVA: 0x7FFD4E350540
        public void .ctor(){} // RVA: 0x7FFD4E3505B0
    }

    public class Hose : MonoBehaviour
    {
        public float maxPower; // 0x20
        public float minPower; // 0x24
        public float changeSpeed; // 0x28
        public UnityEngine.ParticleSystem[] hoseWaterSystems; // 0x30
        public UnityEngine.Renderer systemRenderer; // 0x38
        public float m_Power; // 0x40

        // ── Methods ──
        public void Update(){} // RVA: 0x7FFD4E350600
        public void .ctor(){} // RVA: 0x7FFD4E350A30
    }

    public class ParticleSystemMultiplier : MonoBehaviour
    {
        public float multiplier; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E350A90
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class SmokeParticles : MonoBehaviour
    {
        public UnityEngine.AudioClip[] extinguishSounds; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E350E70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class WaterHoseParticles : MonoBehaviour
    {
        public float lastSoundTime;
        public float force; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.ParticleCollisionEvent> m_CollisionEvents; // 0x28
        public UnityEngine.ParticleSystem m_ParticleSystem; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E351000
        public void OnParticleCollision(){} // RVA: 0x7FFD4E351090
        public void .ctor(){} // RVA: 0x7FFD4E351420
    }

}