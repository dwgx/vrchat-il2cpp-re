// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 4
// Methods: 24

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class LegIK : IK
    {
        public object solver;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKSolver(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xC17A70
    }

    public class LimbIK : IK
    {
        public object solver;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKSolver(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xC17B50
    }

    public class LookAtController : MonoBehaviour
    {
        public object ik;
        public object target;
        public object weight;
        public object offset;
        public object targetSwitchSmoothTime;
        public object weightSmoothTime;
        public object smoothTurnTowardsTarget;
        public object maxRadiansDelta;
        public object maxMagnitudeDelta;
        public object slerpSpeed;
        public object pivotOffsetFromRoot;
        public object minDistance;
        public object maxRootAngle;
        public object lastTarget;
        public object switchWeight;
        public object switchWeightV;
        public object weightV;
        public object lastPosition;
        public object dir;
        public object lastSmoothTowardsTarget;

        // ── Methods ──
        public void Start(){} // RVA: 0xCBE630
        public void LateUpdate(){} // RVA: 0xCBE6F0
        public void get_pivot(){} // RVA: 0xCBF2A0
        public void ApplyMinDistance(){} // RVA: 0xCBF620
        public void RootRotation(){} // RVA: 0xCBF7E0
        public void .ctor(){} // RVA: 0xCBFE40
    }

    public class LookAtIK : IK
    {
        public object solver;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKSolver(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xC17C30
    }

}