// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 6
// Methods: 23

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class SByteConverter : BaseNumberConverter
    {
        public object TargetType;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAC9413760
        public void FromString(){} // RVA: 0x7FFAC94138A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9413970
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SRCategoryAttribute : CategoryAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC416C160
    }

    public class SettingsBindableAttribute : Attribute
    {
        public System.ComponentModel.SettingsBindableAttribute Bindable;
        public System.ComponentModel.SettingsBindableAttribute No; // 0x8
        public bool <Bindable>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Bindable(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC9413A10
        public void GetHashCode(){} // RVA: 0x7FFAC9413AB0
        public void .cctor(){} // RVA: 0x7FFAC9413B00
    }

    public class SingleConverter : BaseNumberConverter
    {
        public object AllowHex;
        public object TargetType;

        // ── Methods ──
        public void get_AllowHex(){} // RVA: 0x7FFAC2F21320
        public void get_TargetType(){} // RVA: 0x7FFAC9413C30
        public void FromString(){} // RVA: 0x7FFAC9413DE0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9413E50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class StringConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAC9413F40
        public void ConvertFrom(){} // RVA: 0x7FFAC9414030
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SyntaxCheck : Object
    {
        // ── Methods ──
        public void CheckMachineName(){} // RVA: 0x7FFAC9414130
        public void CheckPath(){} // RVA: 0x7FFAC94141F0
        public void CheckRootedPath(){} // RVA: 0x7FFAC94142B0
    }

}