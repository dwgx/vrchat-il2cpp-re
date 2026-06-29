// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 6
// Methods: 40

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class AimController : MonoBehaviour
    {
        public object ik;
        public object weight;
        public object target;
        public object targetSwitchSmoothTime;
        public object weightSmoothTime;
        public object smoothTurnTowardsTarget;
        public object maxRadiansDelta;
        public object maxMagnitudeDelta;
        public object slerpSpeed;
        public object pivotOffsetFromRoot;
        public object minDistance;
        public object offset;
        public object maxRootAngle;
        public object turnToTarget;
        public object turnToTargetTime;
        public object useAnimatedAimDirection;
        public object animatedAimDirection;
        public object lastTarget;
        public object switchWeight;
        public object switchWeightV;
        public object weightV;
        public object lastPosition;
        public object dir;
        public object lastSmoothTowardsTarget;
        public object turningToTarget;
        public object turnToTargetMlp;
        public object turnToTargetMlpV;

        // ── Methods ──
        public void Start(){} // RVA: 0xCB7450
        public void LateUpdate(){} // RVA: 0xCB7580
        public void get_pivot(){} // RVA: 0xCB8320
        public void ApplyMinDistance(){} // RVA: 0xCB86A0
        public void RootRotation(){} // RVA: 0xCB8860
        public void TurnToTarget(){} // RVA: 0xCB8F10
        public void .ctor(){} // RVA: 0xCB8FB0
    }

    public class AimIK : IK
    {
        public object solver;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenSetupTutorial(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKSolver(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xC15C10
    }

    public class AimIK[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AimPoser : MonoBehaviour
    {
        public object angleBuffer;
        public object poses;

        // ── Methods ──
        public void GetPose(){} // RVA: 0xCB9220
        public void SetPoseActive(){} // RVA: 0xCB9310
        public void .ctor(){} // RVA: 0xCB9390
    }

    public class Amplifier : OffsetModifier
    {
        public object bodies;

        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0xCB97D0
        public void .ctor(){} // RVA: 0xB4B830
    }

    public class ArmIK : IK
    {
        public object solver;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKSolver(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xC15CF0
    }

}