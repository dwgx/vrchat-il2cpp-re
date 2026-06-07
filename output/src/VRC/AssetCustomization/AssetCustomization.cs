// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.AssetCustomization
// Classes: 6
// Methods: 37

namespace VRC.AssetCustomization
{
    public class IPartOptionBinder
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x24B10
        public void Detach(){} // RVA: 0x24A50
    }

    public class IPartOptionBinderContext
    {
        // ── Methods ──
        public void TryGetVariable(){}
        public void SubscribeToVariable(){}
    }

    public class VRCAnimationPartOption
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x99F6FC0
        public void Detach(){} // RVA: 0x99F73A0
        public void OnDestroy(){} // RVA: 0x99F74A0
        public void ApplyFloatValue(){} // RVA: 0x99F74B0
        public void ApplyBoolValue(){} // RVA: 0x99F7800
        public void ApplyNormalized(){} // RVA: 0x99F7B70
        public void .ctor(){} // RVA: 0x99F7C90
    }

    public class VRCBlendshapePartOption
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x99F7E10
        public void Detach(){} // RVA: 0x99F82D0
        public void OnDestroy(){} // RVA: 0x99F83D0
        public void ApplyFloatValue(){} // RVA: 0x99F83E0
        public void ApplyBoolValue(){} // RVA: 0x99F85A0
        public void OnBeforeSerialize(){} // RVA: 0x99F8740
        public void OnAfterDeserialize(){} // RVA: 0x2DD310
        public void SyncBlendshapeIndices(){} // RVA: 0x99F8750
        public void FindBlendshapeIndex(){} // RVA: 0x99F8AB0
        public void .ctor(){} // RVA: 0x99F8C80
    }

    public class VRCGameObjectPartOption
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x99F8DE0
        public void Detach(){} // RVA: 0x99F9100
        public void OnDestroy(){} // RVA: 0x99F9200
        public void ApplyValue(){} // RVA: 0x99F9210
        public void .ctor(){} // RVA: 0x99F9280
    }

    public class VRCMaterialPartOption
    {
        // ── Methods ──
        public void get_Material(){} // RVA: 0x30B0C0
        public void set_Material(){} // RVA: 0x30B0D0
        public void OnBeforeSerialize(){} // RVA: 0x99F9400
        public void OnAfterDeserialize(){} // RVA: 0x2DD310
        public void RefreshSlots(){} // RVA: 0x99F9410
        public void UpdateProperties(){} // RVA: 0x99F9C30
        public void Attach(){} // RVA: 0x99F9DA0
        public void Detach(){} // RVA: 0x99FA1B0
        public void OnDestroy(){} // RVA: 0x99FA2B0
        public void .ctor(){} // RVA: 0x99FA2C0
        public void .cctor(){} // RVA: 0x99FA450
    }

}