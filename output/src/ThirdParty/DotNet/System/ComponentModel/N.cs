// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 3
// Methods: 29

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class NestedContainer : Container
    {
        public object _owner;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76D1700
        public void get_Owner(){} // RVA: 0xBC1B30
        public void get_OwnerName(){} // RVA: 0x76D18E0
        public void CreateSite(){} // RVA: 0x76D19D0
        public void Dispose(){} // RVA: 0x76D1B80
        public void GetService(){} // RVA: 0x76D1C50
        public void OnOwnerDisposed(){} // RVA: 0x76D1D70
    }

    public class NotifyParentPropertyAttribute : Attribute
    {
        public object Yes;
        public object No;
        public object Default;
        public object notifyParent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_NotifyParent(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x770F1F0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x770F290
        public void .cctor(){} // RVA: 0x770F300
    }

    public class NullableConverter : TypeConverter
    {
        public object _nullableType;
        public object _underlyingType;
        public object _underlyingTypeConverter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76D2340
        public void CanConvertFrom(){} // RVA: 0x76D2530
        public void ConvertFrom(){} // RVA: 0x76D25D0
        public void CanConvertTo(){} // RVA: 0x76D2700
        public void ConvertTo(){} // RVA: 0x76D27A0
        public void CreateInstance(){} // RVA: 0x76D2960
        public void GetCreateInstanceSupported(){} // RVA: 0x76D2990
        public void GetProperties(){} // RVA: 0x76D29C0
        public void GetPropertiesSupported(){} // RVA: 0x76D29F0
        public void GetStandardValues(){} // RVA: 0x76D2A20
        public void GetStandardValuesExclusive(){} // RVA: 0x76D2C80
        public void GetStandardValuesSupported(){} // RVA: 0x7184D90
        public void IsValid(){} // RVA: 0x76D2CB0
        public void get_NullableType(){} // RVA: 0xB5DBF0
        public void get_UnderlyingType(){} // RVA: 0xB465B0
        public void get_UnderlyingTypeConverter(){} // RVA: 0xB700F0
    }

}