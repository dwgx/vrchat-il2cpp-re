// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 4
// Methods: 26

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class VRIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void OpenSetupTutorial(){} // RVA: 0x7A80D7310
        public void AutoDetectReferences(){} // RVA: 0x7A81A7AE0
        public void GuessHandOrientations(){} // RVA: 0x7A81A7B40
        public void GetIKSolver(){} // RVA: 0x7A8152D80
        public void InternalInitiateSolver(){} // RVA: 0x7A81A7B70
        public void InitiateSolver(){} // RVA: 0x7A81A7C50
        public void VRCSetAvatarMainIK(){} // RVA: 0x7A8192410
        public void VRCInitiateSolver(){} // RVA: 0x7A81A7C60
        public void UpdateSolver(){} // RVA: 0x7A81A7C70
        public void .ctor(){} // RVA: 0x7A81A7F70
    }

    public class VRIKCalibrator : Object
    {
        // ── Methods ──
        public void RecalibrateScale(){} // RVA: 0x7A8251530
        public void Calibrate(){} // RVA: 0x7A8255490
        public void CalibrateLeg(){} // RVA: 0x7A82566A0
    }

    public class VRIKLODController : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A8256FE0
        public void Update(){} // RVA: 0x7A8257070
        public void GetLODLevel(){} // RVA: 0x7A82570B0
        public void .ctor(){} // RVA: 0x7A82573F0
    }

    public class VRIKRootController : MonoBehaviour
    {
        // ── Methods ──
        public void get_pelvisTargetRight(){} // RVA: 0x7A813E480
        public void set_pelvisTargetRight(){} // RVA: 0x7A813E4A0
        public void Awake(){} // RVA: 0x7A8257440
        public void Calibrate(){} // RVA: 0x7A8257AE0
        public void OnPreUpdate(){} // RVA: 0x7A8257EA0
        public void OnDestroy(){} // RVA: 0x7A8258A50
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

}