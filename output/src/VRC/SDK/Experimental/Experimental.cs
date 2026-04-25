// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK.Experimental
// Classes: 2
// Methods: 24

namespace VRC.SDK.Experimental
{
    public class VRCImageSaver : VRCCustomAction
    {
        public UnityEngine.RenderTexture[] textures; // 0x20
        public bool useAlpha; // 0x28
        public string ÏÎÍÌÎÍÏÎÌÍÎÌÍÎÌÌÏÍÌÎÎÏÍ; // 0x30
        public System.Text.RegularExpressions.Regex ÍÍÌÌÏÍÏÍÏÏÌÌÎÍÎÎÍÌÎÏÏÌÌ; // 0x38

        // ── Methods ──
        public void DispatchSaveNetworkEvent(){} // RVA: 0x7FFAC46B8BE0
        public void Execute_A59774D99987(){} // RVA: 0x7FFAC46B8DD0
        public void Execute(){} // RVA: 0x7FFAC46B91B0 | overloaded x2
        public void GetProgress(){} // RVA: 0x7FFAC46B9370
        public void op_Implicit(){} // RVA: 0x7FFAC46B9560
        public void CheckImageSaveConditions(){} // RVA: 0x7FFAC46B9750
        public void BuildImageSavePath(){} // RVA: 0x7FFAC46B9950
        public void .ctor(){} // RVA: 0x7FFAC46B9B40
        public void Initialize(){} // RVA: 0x7FFAC46B9CB0
        public void Execute_5D535DDD3922(){} // RVA: 0x7FFAC46B9EB0
        public void FinalizeImageSave(){} // RVA: 0x7FFAC46BA0A0
    }

    public class VRCUdonMovieCapture : VRCCustomAction
    {
        public UnityEngine.Camera[] Cameras; // 0x20

        // ── Methods ──
        public void CanStartMovieCapture(){} // RVA: 0x7FFAC46BF720
        public void ProcessComplexUpdateState(){} // RVA: 0x7FFAC46BF920
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC46BFB10
        public void PrepareMovieCapture(){} // RVA: 0x7FFAC46BFD10
        public void Initialize_17513321FB5C(){} // RVA: 0x7FFAC46BFF10
        public void Start_E33D41982A55(){} // RVA: 0x7FFAC46C0110
        public void FindRelativeTransformWithPath(){} // RVA: 0x7FFAC46C0140
        public void Awake(){} // RVA: 0x7FFAC46C0330
        public void Start(){} // RVA: 0x7FFAC46C0110
        public void Start_333D92A02BC6(){} // RVA: 0x7FFAC46C0110
        public void Execute(){} // RVA: 0x7FFAC46C0530
    }

}