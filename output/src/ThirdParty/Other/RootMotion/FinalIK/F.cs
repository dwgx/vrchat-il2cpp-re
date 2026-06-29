// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 12
// Methods: 145

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class FABRIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void GetIKSolver(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7A81A5CD0
    }

    public class FABRIKChain : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A81AA790
        public void Initiate(){} // RVA: 0x7A81AA920
        public void Stage1(){} // RVA: 0x7A81AA980
        public void Stage2(){} // RVA: 0x7A81AABE0
        public void GetCentroid(){} // RVA: 0x7A81AAE50
        public void .ctor(){} // RVA: 0x7A81AB120
    }

    public class FABRIKChain[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class FABRIKRoot : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void GetIKSolver(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7A81A5DB0
    }

    public class FBBIKArmBending : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7A81AB1C0
        public void OnPostFBBIK(){} // RVA: 0x7A81ABCD0
        public void OnDestroy(){} // RVA: 0x7A81AC1B0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class FBBIKHeadEffector : MonoBehaviour
    {
        // ── Methods ──
        public void VRCInitialize(){} // RVA: 0x7A81AC3B0
        public void VRCSetAvatarMainIK(){} // RVA: 0x7A81AC3C0
        public void Start(){} // RVA: 0x7A81AC3D0
        public void Initialize(){} // RVA: 0x7A81AC3F0
        public void OnStoreDefaultLocalState(){} // RVA: 0x7A81ACC90
        public void OnFixTransforms(){} // RVA: 0x7A81AD720
        public void OnPreRead(){} // RVA: 0x7A81AE050
        public void SpineBend(){} // RVA: 0x7A81AEF40
        public void CCDPass(){} // RVA: 0x7A81AF840
        public void Iterate(){} // RVA: 0x7A81B00C0
        public void OnPostUpdate(){} // RVA: 0x7A81B10A0
        public void ChestDirection(){} // RVA: 0x7A81B1690
        public void PostStretching(){} // RVA: 0x7A81B1BE0
        public void LerpSolverPosition(){} // RVA: 0x7A81B2210
        public void Solve(){} // RVA: 0x7A81B2380
        public void OnDestroy(){} // RVA: 0x7A81B24E0
        public void .ctor(){} // RVA: 0x7A81B2B30
    }

    public class FBIKChain : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B3440
        public void SetNodes(){} // RVA: 0x7A81B3730
        public void GetNodeIndex(){} // RVA: 0x7A81B3990
        public void IsValid(){} // RVA: 0x7A81B3B30
        public void Initiate(){} // RVA: 0x7A81B3D00
        public void ReadPose(){} // RVA: 0x7A81B3F90
        public void CalculateBoneLengths(){} // RVA: 0x7A81B4650
        public void Reach(){} // RVA: 0x7A81B4D40
        public void Push(){} // RVA: 0x7A81B50B0
        public void SolveTrigonometric(){} // RVA: 0x7A81B54B0
        public void Stage1(){} // RVA: 0x7A81B5810
        public void Stage2(){} // RVA: 0x7A81B5CF0
        public void SolveConstraintSystems(){} // RVA: 0x7A81B5E70
        public void SolveFABRIKJoint(){} // RVA: 0x7A81B6120
        public void GetDirToBendPoint(){} // RVA: 0x7A81B6260
        public void SolveChildConstraints(){} // RVA: 0x7A81B6650
        public void SolveLinearConstraint(){} // RVA: 0x7A81B69C0
        public void ForwardReach(){} // RVA: 0x7A81B6B70
        public void BackwardReach(){} // RVA: 0x7A81B6DB0
    }

    public class FBIKChain[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Finger : Object
    {
        // ── Methods ──
        public void get_initiated(){} // RVA: 0x7A818F850
        public void set_initiated(){} // RVA: 0x7A818F860
        public void get_IKPosition(){} // RVA: 0x7A818F870
        public void set_IKPosition(){} // RVA: 0x7A818F8A0
        public void get_IKRotation(){} // RVA: 0x7A818F8D0
        public void set_IKRotation(){} // RVA: 0x7A818F900
        public void IsValid(){} // RVA: 0x7A818F920
        public void Initiate(){} // RVA: 0x7A818FBA0
        public void FixTransforms(){} // RVA: 0x7A8190D60
        public void StoreDefaultLocalState(){} // RVA: 0x7A8190F40
        public void Update(){} // RVA: 0x7A8191120
        public void .ctor(){} // RVA: 0x7A81923F0
    }

    public class FingerRig : SolverManager
    {
        // ── Methods ──
        public void get_initiated(){} // RVA: 0x7A8192400
        public void set_initiated(){} // RVA: 0x7A8192410
        public void IsValid(){} // RVA: 0x7A8192420
        public void AutoDetect(){} // RVA: 0x7A81924A0
        public void AddFinger(){} // RVA: 0x7A8192990
        public void RemoveFinger(){} // RVA: 0x7A8192CD0
        public void AddChildrenRecursive(){} // RVA: 0x7A8192F00
        public void InitiateSolver(){} // RVA: 0x7A8193070
        public void UpdateFingerSolvers(){} // RVA: 0x7A8193180
        public void FixFingerTransforms(){} // RVA: 0x7A8193200
        public void StoreDefaultLocalState(){} // RVA: 0x7A8193460
        public void UpdateSolver(){} // RVA: 0x7A8193180
        public void FixTransforms(){} // RVA: 0x7A81936A0
        public void .ctor(){} // RVA: 0x7A81936C0
    }

    public class Finger[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class FullBodyBipedIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void OpenSetupTutorial(){} // RVA: 0x7A80D7310
        public void OpenInspectorTutorial(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void SetReferences(){} // RVA: 0x7A81A5F20
        public void GetIKSolver(){} // RVA: 0x7A8178B90
        public void ReferencesError(){} // RVA: 0x7A81A5F90
        public void ReferencesWarning(){} // RVA: 0x7A81A63F0
        public void Reinitiate(){} // RVA: 0x7A81A6B90
        public void AutoDetectReferences(){} // RVA: 0x7A81A6BC0
        public void VRCSetAvatarMainIK(){} // RVA: 0x7A81937A0
        public void VRCInitiateSolver(){} // RVA: 0x7A81A6D70
        public void InitiateSolver(){} // RVA: 0x7A81A6D80
        public void .ctor(){} // RVA: 0x7A81A6D90
    }

}