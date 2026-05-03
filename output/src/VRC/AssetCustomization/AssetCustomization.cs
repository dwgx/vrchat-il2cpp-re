// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.AssetCustomization
// Classes: 6
// Methods: 37

namespace VRC.AssetCustomization
{
    public class IPartOptionBinder
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7FFE80E460A0
        public void Detach(){} // RVA: 0x7FFE80E45FE0
    }

    public class IPartOptionBinderContext
    {
        // ── Methods ──
        public void TryGetVariable(){}
        public void SubscribeToVariable(){}
    }

    public class VRCAnimationPartOption : MonoBehaviour
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7FFE8A4529F0
        public void Detach(){} // RVA: 0x7FFE8A452DD0
        public void OnDestroy(){} // RVA: 0x7FFE8A452ED0
        public void ApplyFloatValue(){} // RVA: 0x7FFE8A452EE0
        public void ApplyBoolValue(){} // RVA: 0x7FFE8A453230
        public void ApplyNormalized(){} // RVA: 0x7FFE8A4535A0
        public void .ctor(){} // RVA: 0x7FFE8A4536C0
    }

    public class VRCBlendshapePartOption : MonoBehaviour
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7FFE8A453840
        public void Detach(){} // RVA: 0x7FFE8A453D00
        public void OnDestroy(){} // RVA: 0x7FFE8A453E00
        public void ApplyFloatValue(){} // RVA: 0x7FFE8A453E10
        public void ApplyBoolValue(){} // RVA: 0x7FFE8A453FD0
        public void OnBeforeSerialize(){} // RVA: 0x7FFE8A454170
        public void OnAfterDeserialize(){} // RVA: 0x7FFE810FB310
        public void SyncBlendshapeIndices(){} // RVA: 0x7FFE8A454180
        public void FindBlendshapeIndex(){} // RVA: 0x7FFE8A4544E0
        public void .ctor(){} // RVA: 0x7FFE8A4546B0
    }

    public class VRCGameObjectPartOption : MonoBehaviour
    {
        // ── Methods ──
        public void Attach(){} // RVA: 0x7FFE8A454810
        public void Detach(){} // RVA: 0x7FFE8A454B30
        public void OnDestroy(){} // RVA: 0x7FFE8A454C30
        public void ApplyValue(){} // RVA: 0x7FFE8A454C40
        public void .ctor(){} // RVA: 0x7FFE8A454CB0
    }

    public class VRCMaterialPartOption : MonoBehaviour
    {
        public UnityEngine.Material _material; // 0x20

        // ── Methods ──
        public void get_Material(){} // RVA: 0x7FFE811290C0
        public void set_Material(){} // RVA: 0x7FFE811290D0
        public void OnBeforeSerialize(){} // RVA: 0x7FFE8A454E30
        public void OnAfterDeserialize(){} // RVA: 0x7FFE810FB310
        public void RefreshSlots(){} // RVA: 0x7FFE8A454E40
        public void UpdateProperties(){} // RVA: 0x7FFE8A455660
        public void Attach(){} // RVA: 0x7FFE8A4557D0
        public void Detach(){} // RVA: 0x7FFE8A455BE0
        public void OnDestroy(){} // RVA: 0x7FFE8A455CE0
        public void .ctor(){} // RVA: 0x7FFE8A455CF0
        public void .cctor(){} // RVA: 0x7FFE8A455E80
    }

}