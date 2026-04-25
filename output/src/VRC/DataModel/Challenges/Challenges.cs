// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.DataModel.Challenges
// Classes: 3
// Methods: 20

namespace VRC.DataModel.Challenges
{
    public class ChallengeCompleteEvent : ChallengeEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ChallengeEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ChallengeUpdateEvent : ChallengeEvent
    {
        public string Icon; // 0x10
        public string ID; // 0x18
        public ÎÎÏÌÍÍÏÎÍÎÌÍÏÏÎÏÍÏÌÏÌÌÍ Progress; // 0x20
        public 0x6B1746C8 Status; // 0x28
        public ÎÎÏÍÏÍÍÌÏÏÏÏÎÌÍÎÍÏÍÌÌÏÎ Title; // 0x30
        public string ProgressCriteria; // 0x38

        // ── Methods ──
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void GetTitle(){} // RVA: 0x7FFAC2F4F0C0
        public void GetPlatform_DBF5832295CE(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void SetCurrentSocket(){} // RVA: 0x7FFAC2F4F0D0
        public void GetTextureTransparency(){} // RVA: 0x7FFAC32EC4C0
        public void AddUnitNode(){} // RVA: 0x7FFAC2F4F890
        public void Textto(){} // RVA: 0x7FFAC369A6E0
        public void GetStatus(){} // RVA: 0x7FFAC2F3C380
        public void GetExceptionThrowImageBase(){} // RVA: 0x7FFAC31D95E0
        public void set_element(){} // RVA: 0x7FFAC31D0C20
        public void Initialize(){} // RVA: 0x7FFAC2F22E30
        public void ReadTransformState(){} // RVA: 0x7FFAC2F247C0
        public void SetMessage(){} // RVA: 0x7FFAC2F4F0C0
        public void GetProgress(){} // RVA: 0x7FFAC2F3C380
        public void Init(){} // RVA: 0x7FFAC2F87E80
        public void ReadTransformState_0101C6BFB675(){} // RVA: 0x7FFAC2F247C0
    }

}