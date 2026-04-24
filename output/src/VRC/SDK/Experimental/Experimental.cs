// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK.Experimental
// Classes: 2
// Methods: 24

namespace VRC.SDK.Experimental
{
    public class VRCImageSaver : VRCCustomAction
    {
        public Offset[] textures; // 0x20
        public bool useAlpha; // 0x28
        public string ÎÎÏÍÍÎÎÌÏÏÍÎÌÏÌÌÏÏÍÎÍÌÏ; // 0x30
        public tor.neStore ÎÎÏÏÏÏÏÎÏÎÏÌÍÏÏÎÏÍÏÎÏÎÌ; // 0x38

        // ── Methods ──
        public void DispatchSaveNetworkEvent(){} // RVA: 0x7FFD4FAD8BE0
        public void Execute_A59774D99987(){} // RVA: 0x7FFD4FAD8DD0
        public void Execute(){} // RVA: 0x7FFD4FAD91B0 | overloaded x2
        public void GetProgress(){} // RVA: 0x7FFD4FAD9370
        public void op_Implicit(){} // RVA: 0x7FFD4FAD9560
        public void CheckImageSaveConditions(){} // RVA: 0x7FFD4FAD9750
        public void BuildImageSavePath(){} // RVA: 0x7FFD4FAD9950
        public void .ctor(){} // RVA: 0x7FFD4FAD9B40
        public void Initialize(){} // RVA: 0x7FFD4FAD9CB0
        public void Execute_5D535DDD3922(){} // RVA: 0x7FFD4FAD9EB0
        public void FinalizeImageSave(){} // RVA: 0x7FFD4FADA0A0
    }

    public class VRCUdonMovieCapture : VRCCustomAction
    {
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ[] Cameras; // 0x20

        // ── Methods ──
        public void CanStartMovieCapture(){} // RVA: 0x7FFD4FADF720
        public void ProcessComplexUpdateState(){} // RVA: 0x7FFD4FADF920
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void Initialize(){} // RVA: 0x7FFD4FADFB10
        public void PrepareMovieCapture(){} // RVA: 0x7FFD4FADFD10
        public void Initialize_17513321FB5C(){} // RVA: 0x7FFD4FADFF10
        public void Start_E33D41982A55(){} // RVA: 0x7FFD4FAE0110
        public void FindRelativeTransformWithPath(){} // RVA: 0x7FFD4FAE0140
        public void Awake(){} // RVA: 0x7FFD4FAE0330
        public void Start(){} // RVA: 0x7FFD4FAE0110
        public void Start_333D92A02BC6(){} // RVA: 0x7FFD4FAE0110
        public void Execute(){} // RVA: 0x7FFD4FAE0530
    }

}