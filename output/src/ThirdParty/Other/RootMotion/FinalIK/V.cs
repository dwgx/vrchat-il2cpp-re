// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 4
// Methods: 26

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class VRIK : IK
    {
        public object references;
        public object solver;
        public object _isVRCAvatarMainIK;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenSetupTutorial(){} // RVA: 0xB43310
        public void AutoDetectReferences(){} // RVA: 0xC17DF0
        public void GuessHandOrientations(){} // RVA: 0xC17E20
        public void GetIKSolver(){} // RVA: 0xBBF8F0
        public void InternalInitiateSolver(){} // RVA: 0xC17E50
        public void InitiateSolver(){} // RVA: 0xC17F00
        public void VRCSetAvatarMainIK(){} // RVA: 0xC00ED0
        public void VRCInitiateSolver(){} // RVA: 0xC17F10
        public void UpdateSolver(){} // RVA: 0xC17F20
        public void .ctor(){} // RVA: 0xC18220
    }

    public class VRIKCalibrator : Object
    {
        // ── Methods ──
        public void RecalibrateScale(){} // RVA: 0xCC6200
        public void Calibrate(){} // RVA: 0xCCA430
        public void CalibrateLeg(){} // RVA: 0xCCB610
    }

    public class VRIKLODController : MonoBehaviour
    {
        public object LODRenderer;
        public object LODDistance;
        public object allowCulled;
        public object ik;

        // ── Methods ──
        public void Start(){} // RVA: 0xCCC020
        public void Update(){} // RVA: 0xCCC0B0
        public void GetLODLevel(){} // RVA: 0xCCC0F0
        public void .ctor(){} // RVA: 0xCCC3C0
    }

    public class VRIKRootController : MonoBehaviour
    {
        public object _pelvisTargetRight;
        public object pelvisTarget;
        public object leftFootTarget;
        public object rightFootTarget;
        public object ik;

        // ── Methods ──
        public void get_pelvisTargetRight(){} // RVA: 0xBA9C00
        public void set_pelvisTargetRight(){} // RVA: 0xBA9C20
        public void Awake(){} // RVA: 0xCCC410
        public void Calibrate(){} // RVA: 0xCCCAD0
        public void OnPreUpdate(){} // RVA: 0xCCCE50
        public void OnDestroy(){} // RVA: 0xCCDCC0
        public void .ctor(){} // RVA: 0xB43D60
    }

}