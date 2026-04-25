// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 3
// Methods: 29

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class NestedContainer : Container
    {
        public System.ComponentModel.IComponent Owner; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9409E40
        public void get_Owner(){} // RVA: 0x7FFAC2F9E740
        public void get_OwnerName(){} // RVA: 0x7FFAC940A020
        public void CreateSite(){} // RVA: 0x7FFAC940A110
        public void Dispose(){} // RVA: 0x7FFAC940A2C0
        public void GetService(){} // RVA: 0x7FFAC940A390
        public void OnOwnerDisposed(){} // RVA: 0x7FFAC940A510
    }

    public class NotifyParentPropertyAttribute : Attribute
    {
        public System.ComponentModel.NotifyParentPropertyAttribute NotifyParent;
        public System.ComponentModel.NotifyParentPropertyAttribute No; // 0x8
        public System.ComponentModel.NotifyParentPropertyAttribute Default; // 0x10
        public bool notifyParent; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_NotifyParent(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC9448E20
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC9448EC0
        public void .cctor(){} // RVA: 0x7FFAC9448F30
    }

    public class NullableConverter : TypeConverter
    {
        public System.Type NullableType; // 0x10
        public System.Type UnderlyingType; // 0x18
        public System.ComponentModel.TypeConverter UnderlyingTypeConverter; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC940AB10
        public void CanConvertFrom(){} // RVA: 0x7FFAC940AD10
        public void ConvertFrom(){} // RVA: 0x7FFAC940ADD0
        public void CanConvertTo(){} // RVA: 0x7FFAC940AF30
        public void ConvertTo(){} // RVA: 0x7FFAC940AFF0
        public void CreateInstance(){} // RVA: 0x7FFAC940B1C0
        public void GetCreateInstanceSupported(){} // RVA: 0x7FFAC940B1F0
        public void GetProperties(){} // RVA: 0x7FFAC940B220
        public void GetPropertiesSupported(){} // RVA: 0x7FFAC940B250
        public void GetStandardValues(){} // RVA: 0x7FFAC940B280
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFAC940B500
        public void GetStandardValuesSupported(){} // RVA: 0x7FFAC8EB3A40
        public void IsValid(){} // RVA: 0x7FFAC940B530
        public void get_NullableType(){} // RVA: 0x7FFAC2F3C380
        public void get_UnderlyingType(){} // RVA: 0x7FFAC2F247C0
        public void get_UnderlyingTypeConverter(){} // RVA: 0x7FFAC2F4F0C0
    }

}