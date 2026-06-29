// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.UnityStandardAssets.Effects
// Classes: 10
// Methods: 29

namespace ThirdParty.Other.UnityStandardAssets.Effects
{
    public class AfterburnerPhysicsForce : MonoBehaviour
    {
        public object effectAngle;
        public object effectWidth;
        public object effectDistance;
        public object force;
        public object m_Cols;
        public object m_Sphere;

        // ── Methods ──
        public void OnEnable(){} // RVA: 0xB4E720
        public void FixedUpdate(){} // RVA: 0xB4E810
        public void OnDrawGizmosSelected(){} // RVA: 0xB4F250
        public void .ctor(){} // RVA: 0xB501C0
    }

    public class ExplosionFireAndDebris : MonoBehaviour
    {
        public object debrisPrefabs;
        public object firePrefab;
        public object numDebrisPieces;
        public object numFires;
        public object Instantiate;

        // ── Methods ──
        public void Start(){} // RVA: 0xB50220
        public void AddFire(){} // RVA: 0xB502C0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ExplosionPhysicsForce : MonoBehaviour
    {
        public object explosionForce;

        // ── Methods ──
        public void Start(){} // RVA: 0xB51560
        public void .ctor(){} // RVA: 0xB51600
    }

    public class Explosive : MonoBehaviour
    {
        public object explosionPrefab;
        public object detonationImpactVelocity;
        public object sizeMultiplier;
        public object reset;
        public object resetTimeDelay;
        public object m_Exploded;
        public object m_ObjectResetter;
        public object Instantiate;

        // ── Methods ──
        public void Start(){} // RVA: 0xB51DE0
        public void OnCollisionEnter(){} // RVA: 0xB51E70
        public void Reset(){} // RVA: 0xB51F70
        public void .ctor(){} // RVA: 0xB51F80
    }

    public class ExtinguishableParticleSystem : MonoBehaviour
    {
        public object multiplier;
        public object m_Systems;

        // ── Methods ──
        public void Start(){} // RVA: 0xB52570
        public void Extinguish(){} // RVA: 0xB52600
        public void .ctor(){} // RVA: 0xB4B830
    }

    public class FireLight : MonoBehaviour
    {
        public object m_Rnd;
        public object m_Burning;
        public object m_Light;

        // ── Methods ──
        public void Start(){} // RVA: 0xB52710
        public void Update(){} // RVA: 0xB527E0
        public void Extinguish(){} // RVA: 0xB52C90
        public void .ctor(){} // RVA: 0xB52CC0
    }

    public class Hose : MonoBehaviour
    {
        public object maxPower;
        public object minPower;
        public object changeSpeed;
        public object hoseWaterSystems;
        public object systemRenderer;
        public object m_Power;

        // ── Methods ──
        public void Update(){} // RVA: 0xB52D10
        public void .ctor(){} // RVA: 0xB530C0
    }

    public class ParticleSystemMultiplier : MonoBehaviour
    {
        public object multiplier;

        // ── Methods ──
        public void Start(){} // RVA: 0xB53120
        public void .ctor(){} // RVA: 0xB4B830
    }

    public class SmokeParticles : MonoBehaviour
    {
        public object extinguishSounds;

        // ── Methods ──
        public void Start(){} // RVA: 0xB53480
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class WaterHoseParticles : MonoBehaviour
    {
        public object lastSoundTime;
        public object force;
        public object m_CollisionEvents;
        public object m_ParticleSystem;

        // ── Methods ──
        public void Start(){} // RVA: 0xB53590
        public void OnParticleCollision(){} // RVA: 0xB53620
        public void .ctor(){} // RVA: 0xB53A00
    }

}