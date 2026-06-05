// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.AssetCustomization
// Classes: 6
// Methods: 37

namespace VRC.AssetCustomization
{
    public class IPartOptionBinder
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7FFAF2AD4B10
        public void Detach(){} // RVA: 0x7FFAF2AD4A50
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
        public void Attach(){} // RVA: 0x7FFAFC4A6FC0
        public void Detach(){} // RVA: 0x7FFAFC4A73A0
        public void OnDestroy(){} // RVA: 0x7FFAFC4A74A0
        public void ApplyFloatValue(){} // RVA: 0x7FFAFC4A74B0
        public void ApplyBoolValue(){} // RVA: 0x7FFAFC4A7800
        public void ApplyNormalized(){} // RVA: 0x7FFAFC4A7B70
        public void .ctor(){} // RVA: 0x7FFAFC4A7C90
    }

    public class VRCBlendshapePartOption
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7FFAFC4A7E10
        public void Detach(){} // RVA: 0x7FFAFC4A82D0
        public void OnDestroy(){} // RVA: 0x7FFAFC4A83D0
        public void ApplyFloatValue(){} // RVA: 0x7FFAFC4A83E0
        public void ApplyBoolValue(){} // RVA: 0x7FFAFC4A85A0
        public void OnBeforeSerialize(){} // RVA: 0x7FFAFC4A8740
        public void OnAfterDeserialize(){} // RVA: 0x7FFAF2D8D310
        public void SyncBlendshapeIndices(){} // RVA: 0x7FFAFC4A8750
        public void FindBlendshapeIndex(){} // RVA: 0x7FFAFC4A8AB0
        public void .ctor(){} // RVA: 0x7FFAFC4A8C80
    }

    public class VRCGameObjectPartOption
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7FFAFC4A8DE0
        public void Detach(){} // RVA: 0x7FFAFC4A9100
        public void OnDestroy(){} // RVA: 0x7FFAFC4A9200
        public void ApplyValue(){} // RVA: 0x7FFAFC4A9210
        public void .ctor(){} // RVA: 0x7FFAFC4A9280
    }

    public class VRCMaterialPartOption
    {
        // ── Methods ──
        public void get_Material(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Material(){} // RVA: 0x7FFAF2DBB0D0
        public void OnBeforeSerialize(){} // RVA: 0x7FFAFC4A9400
        public void OnAfterDeserialize(){} // RVA: 0x7FFAF2D8D310
        public void RefreshSlots(){} // RVA: 0x7FFAFC4A9410
        public void UpdateProperties(){} // RVA: 0x7FFAFC4A9C30
        public void Attach(){} // RVA: 0x7FFAFC4A9DA0
        public void Detach(){} // RVA: 0x7FFAFC4AA1B0
        public void OnDestroy(){} // RVA: 0x7FFAFC4AA2B0
        public void .ctor(){} // RVA: 0x7FFAFC4AA2C0
        public void .cctor(){} // RVA: 0x7FFAFC4AA450
    }

}