// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.AssetCustomization
// Classes: 13
// Methods: 34

namespace VRC.SDK3.AssetCustomization
{
    public class AssetPart : MonoBehaviour
    {
        public object displayName;
        public object assetId;
        public object categories;
        public object variables;
        public object positionBone;
        public object positionType;
        public object positionRatio;
        public object positionRaycastToSurface;
        public object positionRaycastNormal;
        public object rotationType;
        public object scaleType;
        public object scaleInnerRadius;

        // ── Methods ──
        public void OnValidate(){} // RVA: 0xA69FC50
        public void get_AssetId(){} // RVA: 0xB70160
        public void set_AssetId(){} // RVA: 0xB44DC0
        public void get_References(){} // RVA: 0xA69FDF0
        public void .ctor(){} // RVA: 0xA69FEA0
    }

    public class BoolVariable : Variable
    {
        public object defaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ColorVariable : Variable
    {
        public object allowAlpha;
        public object defaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6A0AE0
    }

    public class FloatVariable : Variable
    {
        public object defaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6A0AD0
    }

    public class IAssetPart
    {
        // ── Methods ──
        public void set_AssetId(){} // RVA: 0x894320
    }

    public class IAssetPartExtensions : Object
    {
        // ── Methods ──
        public void GenerateAssetId(){} // RVA: 0xA6A08D0
    }

    public class PerPlatformOverrideIgnoreAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PerPlatformOverrideIgnoreIfFieldDiffersAttribute : Attribute
    {
        public object _fieldName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class PerPlatformOverrideWarningAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Variable : Object
    {
        public object id;
        public object name;
        public object categoryId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class VariableLink : ValueType
    {
        public object assetId;
        public object variableId;

        // ── Methods ──
        public void get_AssetId(){} // RVA: 0x77900
        public void get_VariableId(){} // RVA: 0x77ED0
        public void get_IsValid(){} // RVA: 0xA74CD0
        public void ToString(){} // RVA: 0xA74CF0
    }

    public class VariableTypeFilterAttribute : PropertyAttribute
    {
        public object _variableTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x18F33E0
    }

    public class Variable[] : Array
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

}