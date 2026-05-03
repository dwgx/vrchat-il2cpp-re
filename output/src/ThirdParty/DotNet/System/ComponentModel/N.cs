// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 3
// Methods: 29

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class NestedContainer : Container
    {
        public System.ComponentModel.IComponent _owner; // 0x40
        public object field_1; // 0x27B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877B2570
        public void get_Owner(){} // RVA: 0x7FFE81178740
        public void get_OwnerName(){} // RVA: 0x7FFE877B2750
        public void CreateSite(){} // RVA: 0x7FFE877B2840
        public void Dispose(){} // RVA: 0x7FFE877B29F0
        public void GetService(){} // RVA: 0x7FFE877B2AC0
        public void OnOwnerDisposed(){} // RVA: 0x7FFE877B2C40
    }

    public class NotifyParentPropertyAttribute : Attribute
    {
        public System.ComponentModel.NotifyParentPropertyAttribute Yes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_NotifyParent(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE877F1570
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877F1610
        public void .cctor(){} // RVA: 0x7FFE877F1680
    }

    public class NullableConverter : TypeConverter
    {
        public System.Type _nullableType; // 0x10
        public System.Type _underlyingType; // 0x18
        public System.ComponentModel.TypeConverter _underlyingTypeConverter; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877B3240
        public void CanConvertFrom(){} // RVA: 0x7FFE877B3440
        public void ConvertFrom(){} // RVA: 0x7FFE877B3500
        public void CanConvertTo(){} // RVA: 0x7FFE877B3660
        public void ConvertTo(){} // RVA: 0x7FFE877B3720
        public void CreateInstance(){} // RVA: 0x7FFE877B38F0
        public void GetCreateInstanceSupported(){} // RVA: 0x7FFE877B3920
        public void GetProperties(){} // RVA: 0x7FFE877B3950
        public void GetPropertiesSupported(){} // RVA: 0x7FFE877B3980
        public void GetStandardValues(){} // RVA: 0x7FFE877B39B0
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFE877B3C30
        public void GetStandardValuesSupported(){} // RVA: 0x7FFE8725BE90
        public void IsValid(){} // RVA: 0x7FFE877B3C60
        public void get_NullableType(){} // RVA: 0x7FFE81116380
        public void get_UnderlyingType(){} // RVA: 0x7FFE810FE7C0
        public void get_UnderlyingTypeConverter(){} // RVA: 0x7FFE811290C0
    }

}