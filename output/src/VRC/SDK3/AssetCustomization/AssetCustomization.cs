// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.AssetCustomization
// Classes: 10
// Methods: 16

namespace VRC.SDK3.AssetCustomization
{
    public class AssetPart : MonoBehaviour
    {
        public string displayName; // 0x20
        public string assetId; // 0x28

        // ── Methods ──
        public void OnValidate(){} // RVA: 0x7FFE8A451B60
        public void get_AssetId(){} // RVA: 0x7FFE81129130
        public void set_AssetId(){} // RVA: 0x7FFE810FCE90
        public void get_References(){} // RVA: 0x7FFE8A451CF0
        public void .ctor(){} // RVA: 0x7FFE8A451DA0
    }

    public class BoolVariable : Variable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ColorVariable : Variable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4529E0
    }

    public class FloatVariable : Variable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4529D0
    }

    public class IAssetPart
    {
        // ── Methods ──
        public void set_AssetId(){} // RVA: 0x7FFE80E460A0
    }

    public class IAssetPartExtensions : Object
    {
        // ── Methods ──
        public void GenerateAssetId(){} // RVA: 0x7FFE8A4527D0
    }

    public class IReferenceObject
    {
    }

    public class Variable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class VariableLink : ValueType
    {
        public string assetId; // 0x10
        public string variableId; // 0x18
        public object field_2; // 0x6

        // ── Methods ──
        public void get_AssetId(){} // RVA: 0x7FFE8284EF60
        public void get_VariableId(){} // RVA: 0x7FFE826F4210
        public void get_IsValid(){} // RVA: 0x7FFE8A452960
        public void ToString(){} // RVA: 0x7FFE8A452980
    }

    public class VariableTypeFilterAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

}