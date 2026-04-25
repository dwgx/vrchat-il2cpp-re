// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 12
// Methods: 142

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class ReadOnlyAttribute : Attribute
    {
        public System.ComponentModel.ReadOnlyAttribute IsReadOnly;
        public System.ComponentModel.ReadOnlyAttribute No; // 0x8
        public System.ComponentModel.ReadOnlyAttribute Default; // 0x10
        public bool <IsReadOnly>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC93E8290
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E8350
        public void .cctor(){} // RVA: 0x7FFAC93E83C0
    }

    public class RecommendedAsConfigurableAttribute : Attribute
    {
        public bool RecommendedAsConfigurable; // 0x10
        public System.ComponentModel.RecommendedAsConfigurableAttribute No;
        public System.ComponentModel.RecommendedAsConfigurableAttribute Yes; // 0x8
        public System.ComponentModel.RecommendedAsConfigurableAttribute Default; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_RecommendedAsConfigurable(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC94104A0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC37C9990
        public void .cctor(){} // RVA: 0x7FFAC9410550
    }

    public class ReferenceConverter : TypeConverter
    {
        public string s_none;
        public System.Type _type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void CanConvertFrom(){} // RVA: 0x7FFAC94106F0
        public void ConvertFrom(){} // RVA: 0x7FFAC94107F0
        public void ConvertTo(){} // RVA: 0x7FFAC9410AB0
        public void GetStandardValues(){} // RVA: 0x7FFAC9410DE0
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFAC3006850
        public void GetStandardValuesSupported(){} // RVA: 0x7FFAC3006850
        public void IsValueAllowed(){} // RVA: 0x7FFAC3006850
        public void .cctor(){} // RVA: 0x7FFAC94113B0
    }

    public class ReflectEventDescriptor : EventDescriptor
    {
        public System.Type ComponentType; // 0x60
        public System.Type EventType; // 0x68
        public System.Reflection.MethodInfo IsMulticast; // 0x70
        public System.Reflection.MethodInfo _removeMethod; // 0x78
        public System.Reflection.EventInfo _realEvent; // 0x80
        public bool _filledMethods; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94119C0 | overloaded x3
        public void get_ComponentType(){} // RVA: 0x7FFAC2F9CD50
        public void get_EventType(){} // RVA: 0x7FFAC9411BC0
        public void get_IsMulticast(){} // RVA: 0x7FFAC9411BE0
        public void AddEventHandler(){} // RVA: 0x7FFAC9411CF0
        public void FillAttributes(){} // RVA: 0x7FFAC9412180
        public void FillEventInfoAttribute(){} // RVA: 0x7FFAC94121F0
        public void FillMethods(){} // RVA: 0x7FFAC9412520
        public void FillSingleMethodAttribute(){} // RVA: 0x7FFAC9412B10
        public void RemoveEventHandler(){} // RVA: 0x7FFAC9412F10
    }

    public class ReflectPropertyDescriptor : PropertyDescriptor
    {
        public System.Type[] AmbientValue;
        public object ChangedEventValue; // 0x8
        public System.Diagnostics.TraceSwitch IPropChangedEventValue; // 0x10
        public System.Diagnostics.TraceSwitch ComponentType; // 0x18
        public int DefaultValue; // 0x20
        public int GetMethodValue; // 0x24
        public int IsExtender; // 0x28
        public int IsReadOnly; // 0x2C
        public int PropertyType; // 0x30
        public int ResetMethodValue; // 0x34
        public int SetMethodValue; // 0x38
        public int ShouldSerializeMethodValue; // 0x3C
        public int SupportsChangeEvents; // 0x40
        public int BitSetOnDemand; // 0x44
        public System.Collections.Specialized.BitVector32 state; // 0x88
        public System.Type componentClass; // 0x90
        public System.Type type; // 0x98
        public object defaultValue; // 0xA0
        public object ambientValue; // 0xA8
        public System.Reflection.PropertyInfo propInfo; // 0xB0
        public System.Reflection.MethodInfo getMethod; // 0xB8
        public System.Reflection.MethodInfo setMethod; // 0xC0
        public System.Reflection.MethodInfo shouldSerializeMethod; // 0xC8
        public System.Reflection.MethodInfo resetMethod; // 0xD0
        public System.ComponentModel.EventDescriptor realChangedEvent; // 0xD8
        public System.ComponentModel.EventDescriptor realIPropChangedEvent; // 0xE0
        public System.Type receiverType; // 0xE8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94235E0 | overloaded x4
        public void get_AmbientValue(){} // RVA: 0x7FFAC9423B90
        public void get_ChangedEventValue(){} // RVA: 0x7FFAC9423E10
        public void get_IPropChangedEventValue(){} // RVA: 0x7FFAC9424040
        public void set_IPropChangedEventValue(){} // RVA: 0x7FFAC9424260
        public void get_ComponentType(){} // RVA: 0x7FFAC32EF640
        public void get_DefaultValue(){} // RVA: 0x7FFAC9424320
        public void get_GetMethodValue(){} // RVA: 0x7FFAC94246E0
        public void get_IsExtender(){} // RVA: 0x7FFAC9424C50
        public void get_IsReadOnly(){} // RVA: 0x7FFAC9424CB0
        public void get_PropertyType(){} // RVA: 0x7FFAC354DFB0
        public void get_ResetMethodValue(){} // RVA: 0x7FFAC9424DC0
        public void get_SetMethodValue(){} // RVA: 0x7FFAC9425040
        public void get_ShouldSerializeMethodValue(){} // RVA: 0x7FFAC94257A0
        public void AddValueChanged(){} // RVA: 0x7FFAC9425A20
        public void ExtenderCanResetValue(){} // RVA: 0x7FFAC9425C20
        public void ExtenderGetReceiverType(){} // RVA: 0x7FFAC2FA2970
        public void ExtenderGetType(){} // RVA: 0x7FFAC8406A90
        public void ExtenderGetValue(){} // RVA: 0x7FFAC9425E80
        public void ExtenderResetValue(){} // RVA: 0x7FFAC9426000
        public void ExtenderSetValue(){} // RVA: 0x7FFAC94263E0
        public void ExtenderShouldSerializeValue(){} // RVA: 0x7FFAC9426740
        public void CanResetValue(){} // RVA: 0x7FFAC9426B80
        public void FillAttributes(){} // RVA: 0x7FFAC9426E50
        public void GetValue(){} // RVA: 0x7FFAC9427960
        public void OnINotifyPropertyChanged(){} // RVA: 0x7FFAC9427C70
        public void OnValueChanged(){} // RVA: 0x7FFAC9427E10
        public void RemoveValueChanged(){} // RVA: 0x7FFAC9427F20
        public void ResetValue(){} // RVA: 0x7FFAC9428120
        public void SetValue(){} // RVA: 0x7FFAC9428420
        public void ShouldSerializeValue(){} // RVA: 0x7FFAC9428910
        public void get_SupportsChangeEvents(){} // RVA: 0x7FFAC9428C60
        public void .cctor(){} // RVA: 0x7FFAC9428CA0
    }

    public class ReflectTypeDescriptionProvider : TypeDescriptionProvider
    {
        public System.Collections.Hashtable ExtenderProviderKey; // 0x20
        public System.Type[] IntrinsicTypeConverters;
        public System.Collections.Hashtable _editorTables; // 0x8
        public System.Collections.Hashtable _intrinsicTypeConverters; // 0x10
        public object _intrinsicReferenceKey; // 0x18
        public object _intrinsicNullableKey; // 0x20
        public object _dictionaryKey; // 0x28
        public System.Collections.Hashtable _propertyCache; // 0x30
        public System.Collections.Hashtable _eventCache; // 0x38
        public System.Collections.Hashtable _attributeCache; // 0x40
        public System.Collections.Hashtable _extendedPropertyCache; // 0x48
        public System.Guid _extenderProviderKey; // 0x50
        public System.Guid _extenderPropertiesKey; // 0x60
        public System.Guid _extenderProviderPropertiesKey; // 0x70
        public System.Type[] _skipInterfaceAttributeList; // 0x80
        public object _internalSyncObject; // 0x88

        // ── Methods ──
        public void get_ExtenderProviderKey(){} // RVA: 0x7FFAC9429100
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_IntrinsicTypeConverters(){} // RVA: 0x7FFAC9429160
        public void AddEditorTable(){} // RVA: 0x7FFAC9429C60
        public void CreateInstance(){} // RVA: 0x7FFAC942A2A0 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFAC942A460
        public void GetCache(){} // RVA: 0x7FFAC942A490
        public void GetClassName(){} // RVA: 0x7FFAC942A6C0
        public void GetComponentName(){} // RVA: 0x7FFAC942A700
        public void GetConverter(){} // RVA: 0x7FFAC942A7E0
        public void GetDefaultEvent(){} // RVA: 0x7FFAC942A820
        public void GetDefaultProperty(){} // RVA: 0x7FFAC942A860
        public void GetEditor(){} // RVA: 0x7FFAC942A8A0
        public void GetEditorTable(){} // RVA: 0x7FFAC942A8F0
        public void GetEvents(){} // RVA: 0x7FFAC942AFE0
        public void GetExtendedAttributes(){} // RVA: 0x7FFAC942B010
        public void GetExtendedClassName(){} // RVA: 0x7FFAC942B070
        public void GetExtendedComponentName(){} // RVA: 0x7FFAC942B0D0
        public void GetExtendedConverter(){} // RVA: 0x7FFAC942B120
        public void GetExtendedDefaultEvent(){} // RVA: 0x7FFAC34F9180
        public void GetExtendedDefaultProperty(){} // RVA: 0x7FFAC34F9180
        public void GetExtendedEditor(){} // RVA: 0x7FFAC942B180
        public void GetExtendedEvents(){} // RVA: 0x7FFAC942B1F0
        public void GetExtendedProperties(){} // RVA: 0x7FFAC942B250
        public void GetExtenderProviders(){} // RVA: 0x7FFAC942B760
        public void GetExtenders(){} // RVA: 0x7FFAC942BA50
        public void GetExtendedPropertyOwner(){} // RVA: 0x7FFAC942C2D0
        public void GetExtendedTypeDescriptor(){} // RVA: 0x7FFAC34F9180
        public void GetFullComponentName(){} // RVA: 0x7FFAC942C350
        public void GetPopulatedTypes(){} // RVA: 0x7FFAC942C4B0
        public void GetProperties(){} // RVA: 0x7FFAC942C9C0
        public void GetPropertyOwner(){} // RVA: 0x7FFAC942C9F0
        public void GetReflectionType(){} // RVA: 0x7FFAC3E92FB0
        public void GetTypeData(){} // RVA: 0x7FFAC942CA50
        public void GetTypeDescriptor(){} // RVA: 0x7FFAC34F9180
        public void GetTypeFromName(){} // RVA: 0x7FFAC942CE40
        public void IsPopulated(){} // RVA: 0x7FFAC942CF30
        public void ReflectGetAttributes(){} // RVA: 0x7FFAC942D600 | overloaded x2
        public void ReflectGetEvents(){} // RVA: 0x7FFAC942DC80
        public void ReflectGetExtendedProperties(){} // RVA: 0x7FFAC942E5A0
        public void ReflectGetProperties(){} // RVA: 0x7FFAC942F510
        public void Refresh(){} // RVA: 0x7FFAC942FD50
        public void SearchIntrinsicTable(){} // RVA: 0x7FFAC942FD80
        public void .cctor(){} // RVA: 0x7FFAC9430640
    }

    public class RefreshEventArgs : EventArgs
    {
        public object ComponentChanged; // 0x10
        public System.Type TypeChanged; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9413400 | overloaded x2
        public void get_ComponentChanged(){} // RVA: 0x7FFAC2F3C380
        public void get_TypeChanged(){} // RVA: 0x7FFAC2F247C0
    }

    public class RefreshEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FA1190
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class RefreshPropertiesAttribute : Attribute
    {
        public System.ComponentModel.RefreshPropertiesAttribute RefreshProperties;
        public System.ComponentModel.RefreshPropertiesAttribute Repaint; // 0x8
        public System.ComponentModel.RefreshPropertiesAttribute Default; // 0x10
        public 0x6B136F50 refresh; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_RefreshProperties(){} // RVA: 0x7FFAC2F6E5C0
        public void Equals(){} // RVA: 0x7FFAC9449280
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC9449310
        public void .cctor(){} // RVA: 0x7FFAC9449380
    }

    public class RunInstallerAttribute : Attribute
    {
        public bool RunInstaller; // 0x10
        public System.ComponentModel.RunInstallerAttribute Yes;
        public System.ComponentModel.RunInstallerAttribute No; // 0x8
        public System.ComponentModel.RunInstallerAttribute Default; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_RunInstaller(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC94134A0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC9413550
        public void .cctor(){} // RVA: 0x7FFAC94135C0
    }

    public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
    {
        public object Result; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9433680
        public void get_Result(){} // RVA: 0x7FFAC94337F0
        public void get_UserState(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class RunWorkerCompletedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

}