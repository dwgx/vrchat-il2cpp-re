// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 12
// Methods: 145

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class FABRIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKSolver(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xC15EB0
    }

    public class FABRIKChain : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0xC1AA00
        public void Initiate(){} // RVA: 0xC1AB90
        public void Stage1(){} // RVA: 0xC1ABC0
        public void Stage2(){} // RVA: 0xC1AE20
        public void GetCentroid(){} // RVA: 0xC1B0E0
        public void .ctor(){} // RVA: 0xC1B3B0
    }

    public class FABRIKChain[] : Array
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

    public class FABRIKRoot : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKSolver(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xC15F90
    }

    public class FBBIKArmBending : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0xC1B450
        public void OnPostFBBIK(){} // RVA: 0xC1BFC0
        public void OnDestroy(){} // RVA: 0xC1C590
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class FBBIKHeadEffector : MonoBehaviour
    {
        // ── Methods ──
        public void VRCInitialize(){} // RVA: 0xC1C790
        public void VRCSetAvatarMainIK(){} // RVA: 0xC1C7A0
        public void Start(){} // RVA: 0xC1C7B0
        public void Initialize(){} // RVA: 0xC1C7D0
        public void OnStoreDefaultLocalState(){} // RVA: 0xC1D0E0
        public void OnFixTransforms(){} // RVA: 0xC1DA80
        public void OnPreRead(){} // RVA: 0xC1E4E0
        public void SpineBend(){} // RVA: 0xC1EEA0
        public void CCDPass(){} // RVA: 0xC1F7D0
        public void Iterate(){} // RVA: 0xC20240
        public void OnPostUpdate(){} // RVA: 0xC21060
        public void ChestDirection(){} // RVA: 0xC21550
        public void PostStretching(){} // RVA: 0xC21B50
        public void LerpSolverPosition(){} // RVA: 0xC22290
        public void Solve(){} // RVA: 0xC22400
        public void OnDestroy(){} // RVA: 0xC22560
        public void .ctor(){} // RVA: 0xC22BB0
    }

    public class FBIKChain : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC23540
        public void SetNodes(){} // RVA: 0xC23830
        public void GetNodeIndex(){} // RVA: 0xC23A90
        public void IsValid(){} // RVA: 0xC23C30
        public void Initiate(){} // RVA: 0xC23E00
        public void ReadPose(){} // RVA: 0xC240E0
        public void CalculateBoneLengths(){} // RVA: 0xC24860
        public void Reach(){} // RVA: 0xC25040
        public void Push(){} // RVA: 0xC253B0
        public void SolveTrigonometric(){} // RVA: 0xC257B0
        public void Stage1(){} // RVA: 0xC25B10
        public void Stage2(){} // RVA: 0xC25FF0
        public void SolveConstraintSystems(){} // RVA: 0xC26170
        public void SolveFABRIKJoint(){} // RVA: 0xC26420
        public void GetDirToBendPoint(){} // RVA: 0xC26560
        public void SolveChildConstraints(){} // RVA: 0xC26950
        public void SolveLinearConstraint(){} // RVA: 0xC26CC0
        public void ForwardReach(){} // RVA: 0xC26E70
        public void BackwardReach(){} // RVA: 0xC270B0
    }

    public class FBIKChain[] : Array
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

    public class Finger : Object
    {
        // ── Methods ──
        public void get_initiated(){} // RVA: 0xBFDA40
        public void set_initiated(){} // RVA: 0xBFDA50
        public void get_IKPosition(){} // RVA: 0xBFDA60
        public void set_IKPosition(){} // RVA: 0xBFDA90
        public void get_IKRotation(){} // RVA: 0xBFDAC0
        public void set_IKRotation(){} // RVA: 0xBFDAF0
        public void IsValid(){} // RVA: 0xBFDB10
        public void Initiate(){} // RVA: 0xBFDD90
        public void FixTransforms(){} // RVA: 0xBFF360
        public void StoreDefaultLocalState(){} // RVA: 0xBFF5C0
        public void Update(){} // RVA: 0xBFF810
        public void .ctor(){} // RVA: 0xC00EB0
    }

    public class FingerRig : SolverManager
    {
        // ── Methods ──
        public void get_initiated(){} // RVA: 0xC00EC0
        public void set_initiated(){} // RVA: 0xC00ED0
        public void IsValid(){} // RVA: 0xC00EE0
        public void AutoDetect(){} // RVA: 0xC00F60
        public void AddFinger(){} // RVA: 0xC01590
        public void RemoveFinger(){} // RVA: 0xC018A0
        public void AddChildrenRecursive(){} // RVA: 0xC01A90
        public void InitiateSolver(){} // RVA: 0xC01C00
        public void UpdateFingerSolvers(){} // RVA: 0xC01D70
        public void FixFingerTransforms(){} // RVA: 0xC01DF0
        public void StoreDefaultLocalState(){} // RVA: 0xC020D0
        public void UpdateSolver(){} // RVA: 0xC01D70
        public void FixTransforms(){} // RVA: 0xC02380
        public void .ctor(){} // RVA: 0xC023A0
    }

    public class Finger[] : Array
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

    public class FullBodyBipedIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void OpenSetupTutorial(){} // RVA: 0xB43310
        public void OpenInspectorTutorial(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void SetReferences(){} // RVA: 0xC16100
        public void GetIKSolver(){} // RVA: 0xBE58B0
        public void ReferencesError(){} // RVA: 0xC16170
        public void ReferencesWarning(){} // RVA: 0xC165D0
        public void Reinitiate(){} // RVA: 0xC16F40
        public void AutoDetectReferences(){} // RVA: 0xC16F70
        public void VRCSetAvatarMainIK(){} // RVA: 0xC02480
        public void VRCInitiateSolver(){} // RVA: 0xC170E0
        public void InitiateSolver(){} // RVA: 0xC170F0
        public void .ctor(){} // RVA: 0xC17100
    }

}