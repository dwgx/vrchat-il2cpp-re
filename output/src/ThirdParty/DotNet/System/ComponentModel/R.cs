// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 12
// Methods: 142

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class ReadOnlyAttribute : Attribute
    {
        public System.ComponentModel.ReadOnlyAttribute Yes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_IsReadOnly(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE877909C0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE87790A80
        public void .cctor(){} // RVA: 0x7FFE87790AF0
    }

    public class RecommendedAsConfigurableAttribute : Attribute
    {
        public bool _recommendedAsConfigurable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_RecommendedAsConfigurable(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE877B8BD0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE818F2DD0
        public void .cctor(){} // RVA: 0x7FFE877B8C80
    }

    public class ReferenceConverter : TypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void CanConvertFrom(){} // RVA: 0x7FFE877B8E20
        public void ConvertFrom(){} // RVA: 0x7FFE877B8F20
        public void ConvertTo(){} // RVA: 0x7FFE877B91E0
        public void GetStandardValues(){} // RVA: 0x7FFE877B9510
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFE811E0850
        public void GetStandardValuesSupported(){} // RVA: 0x7FFE811E0850
        public void IsValueAllowed(){} // RVA: 0x7FFE811E0850
        public void .cctor(){} // RVA: 0x7FFE877B9AE0
    }

    public class ReflectEventDescriptor : EventDescriptor
    {
        public System.Type _type; // 0x60
        public System.Type _componentClass; // 0x68
        public System.Reflection.MethodInfo _addMethod; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877BA0F0 | overloaded x3
        public void get_ComponentType(){} // RVA: 0x7FFE81176D50
        public void get_EventType(){} // RVA: 0x7FFE877BA2F0
        public void get_IsMulticast(){} // RVA: 0x7FFE877BA310
        public void AddEventHandler(){} // RVA: 0x7FFE877BA420
        public void FillAttributes(){} // RVA: 0x7FFE877BA8B0
        public void FillEventInfoAttribute(){} // RVA: 0x7FFE877BA920
        public void FillMethods(){} // RVA: 0x7FFE877BAC50
        public void FillSingleMethodAttribute(){} // RVA: 0x7FFE877BB240
        public void RemoveEventHandler(){} // RVA: 0x7FFE877BB640
    }

    public class ReflectPropertyDescriptor : PropertyDescriptor
    {
        public System.Type[] argsNone;
        public object noValue; // 0x8
        public System.Diagnostics.TraceSwitch PropDescCreateSwitch; // 0x10
        public System.Diagnostics.TraceSwitch PropDescUsageSwitch; // 0x18
        public int BitDefaultValueQueried; // 0x20
        public int BitGetQueried; // 0x24
        public int BitSetQueried; // 0x28
        public int BitShouldSerializeQueried; // 0x2C
        public int BitResetQueried; // 0x30
        public int BitChangedQueried; // 0x34
        public int BitIPropChangedQueried; // 0x38
        public int BitReadOnlyChecked; // 0x3C
        public int BitAmbientValueQueried; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877CBD10 | overloaded x4
        public void get_AmbientValue(){} // RVA: 0x7FFE877CC2C0
        public void get_ChangedEventValue(){} // RVA: 0x7FFE877CC540
        public void get_IPropChangedEventValue(){} // RVA: 0x7FFE877CC770
        public void set_IPropChangedEventValue(){} // RVA: 0x7FFE877CC990
        public void get_ComponentType(){} // RVA: 0x7FFE8154EB60
        public void get_DefaultValue(){} // RVA: 0x7FFE877CCA50
        public void get_GetMethodValue(){} // RVA: 0x7FFE877CCE10
        public void get_IsExtender(){} // RVA: 0x7FFE877CD380
        public void get_IsReadOnly(){} // RVA: 0x7FFE877CD3E0
        public void get_PropertyType(){} // RVA: 0x7FFE817AE360
        public void get_ResetMethodValue(){} // RVA: 0x7FFE877CD4F0
        public void get_SetMethodValue(){} // RVA: 0x7FFE877CD770
        public void get_ShouldSerializeMethodValue(){} // RVA: 0x7FFE877CDED0
        public void AddValueChanged(){} // RVA: 0x7FFE877CE150
        public void ExtenderCanResetValue(){} // RVA: 0x7FFE877CE350
        public void ExtenderGetReceiverType(){} // RVA: 0x7FFE8117C970
        public void ExtenderGetType(){} // RVA: 0x7FFE867B03A0
        public void ExtenderGetValue(){} // RVA: 0x7FFE877CE5B0
        public void ExtenderResetValue(){} // RVA: 0x7FFE877CE730
        public void ExtenderSetValue(){} // RVA: 0x7FFE877CEB10
        public void ExtenderShouldSerializeValue(){} // RVA: 0x7FFE877CEE70
        public void CanResetValue(){} // RVA: 0x7FFE877CF2B0
        public void FillAttributes(){} // RVA: 0x7FFE877CF580
        public void GetValue(){} // RVA: 0x7FFE877D0090
        public void OnINotifyPropertyChanged(){} // RVA: 0x7FFE877D03A0
        public void OnValueChanged(){} // RVA: 0x7FFE877D0540
        public void RemoveValueChanged(){} // RVA: 0x7FFE877D0650
        public void ResetValue(){} // RVA: 0x7FFE877D0850
        public void SetValue(){} // RVA: 0x7FFE877D0B50
        public void ShouldSerializeValue(){} // RVA: 0x7FFE877D1040
        public void get_SupportsChangeEvents(){} // RVA: 0x7FFE877D1390
        public void .cctor(){} // RVA: 0x7FFE877D13D0
    }

    public class ReflectTypeDescriptionProvider : TypeDescriptionProvider
    {
        public System.Collections.Hashtable _typeData; // 0x20
        public System.Type[] _typeConstructor;

        // ── Methods ──
        public void get_ExtenderProviderKey(){} // RVA: 0x7FFE877D1830
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_IntrinsicTypeConverters(){} // RVA: 0x7FFE877D1890
        public void AddEditorTable(){} // RVA: 0x7FFE877D2390
        public void CreateInstance(){} // RVA: 0x7FFE877D29D0 | overloaded x2
        public void GetAttributes(){} // RVA: 0x7FFE877D2B90
        public void GetCache(){} // RVA: 0x7FFE877D2BC0
        public void GetClassName(){} // RVA: 0x7FFE877D2DF0
        public void GetComponentName(){} // RVA: 0x7FFE877D2E30
        public void GetConverter(){} // RVA: 0x7FFE877D2F10
        public void GetDefaultEvent(){} // RVA: 0x7FFE877D2F50
        public void GetDefaultProperty(){} // RVA: 0x7FFE877D2F90
        public void GetEditor(){} // RVA: 0x7FFE877D2FD0
        public void GetEditorTable(){} // RVA: 0x7FFE877D3020
        public void GetEvents(){} // RVA: 0x7FFE877D3710
        public void GetExtendedAttributes(){} // RVA: 0x7FFE877D3740
        public void GetExtendedClassName(){} // RVA: 0x7FFE877D37A0
        public void GetExtendedComponentName(){} // RVA: 0x7FFE877D3800
        public void GetExtendedConverter(){} // RVA: 0x7FFE877D3850
        public void GetExtendedDefaultEvent(){} // RVA: 0x7FFE813240E0
        public void GetExtendedDefaultProperty(){} // RVA: 0x7FFE813240E0
        public void GetExtendedEditor(){} // RVA: 0x7FFE877D38B0
        public void GetExtendedEvents(){} // RVA: 0x7FFE877D3920
        public void GetExtendedProperties(){} // RVA: 0x7FFE877D3980
        public void GetExtenderProviders(){} // RVA: 0x7FFE877D3E90
        public void GetExtenders(){} // RVA: 0x7FFE877D4180
        public void GetExtendedPropertyOwner(){} // RVA: 0x7FFE877D4A00
        public void GetExtendedTypeDescriptor(){} // RVA: 0x7FFE813240E0
        public void GetFullComponentName(){} // RVA: 0x7FFE877D4A80
        public void GetPopulatedTypes(){} // RVA: 0x7FFE877D4BE0
        public void GetProperties(){} // RVA: 0x7FFE877D50F0
        public void GetPropertyOwner(){} // RVA: 0x7FFE877D5120
        public void GetReflectionType(){} // RVA: 0x7FFE82153650
        public void GetTypeData(){} // RVA: 0x7FFE877D5180
        public void GetTypeDescriptor(){} // RVA: 0x7FFE813240E0
        public void GetTypeFromName(){} // RVA: 0x7FFE877D5570
        public void IsPopulated(){} // RVA: 0x7FFE877D5660
        public void ReflectGetAttributes(){} // RVA: 0x7FFE877D5D30 | overloaded x2
        public void ReflectGetEvents(){} // RVA: 0x7FFE877D63B0
        public void ReflectGetExtendedProperties(){} // RVA: 0x7FFE877D6CD0
        public void ReflectGetProperties(){} // RVA: 0x7FFE877D7C40
        public void Refresh(){} // RVA: 0x7FFE877D8480
        public void SearchIntrinsicTable(){} // RVA: 0x7FFE877D84B0
        public void .cctor(){} // RVA: 0x7FFE877D8D70
    }

    public class RefreshEventArgs : EventArgs
    {
        public object _componentChanged; // 0x10
        public System.Type _typeChanged; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877BBB30 | overloaded x2
        public void get_ComponentChanged(){} // RVA: 0x7FFE81116380
        public void get_TypeChanged(){} // RVA: 0x7FFE810FE7C0
    }

    public class RefreshEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8117B190
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE81156C70
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class RefreshPropertiesAttribute : Attribute
    {
        public System.ComponentModel.RefreshPropertiesAttribute All;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_RefreshProperties(){} // RVA: 0x7FFE811485C0
        public void Equals(){} // RVA: 0x7FFE877F19D0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877F1A60
        public void .cctor(){} // RVA: 0x7FFE877F1AD0
    }

    public class RunInstallerAttribute : Attribute
    {
        public bool _runInstaller; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_RunInstaller(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE877BBBD0
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877BBC80
        public void .cctor(){} // RVA: 0x7FFE877BBCF0
    }

    public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
    {
        public object result; // 0x28
        public object field_1; // 0x302

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877DBDB0
        public void get_Result(){} // RVA: 0x7FFE877DBF20
        public void get_UserState(){} // RVA: 0x7FFE811290C0
    }

    public class RunWorkerCompletedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

}