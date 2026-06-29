// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 12
// Methods: 134

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class ReadOnlyAttribute : Attribute
    {
        public object Yes;
        public object No;
        public object Default;
        public object _isReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_IsReadOnly(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76B0570
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76B0630
        public void .cctor(){} // RVA: 0x76B06A0
    }

    public class RecommendedAsConfigurableAttribute : Attribute
    {
        public object _recommendedAsConfigurable;
        public object No;
        public object Yes;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_RecommendedAsConfigurable(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76D7A70
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x14510C0
        public void .cctor(){} // RVA: 0x76D7B10
    }

    public class ReferenceConverter : TypeConverter
    {
        public object s_none;
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void CanConvertFrom(){} // RVA: 0x76D7CB0
        public void ConvertFrom(){} // RVA: 0x76D7DB0
        public void ConvertTo(){} // RVA: 0x76D8040
        public void GetStandardValues(){} // RVA: 0x76D8370
        public void GetStandardValuesExclusive(){} // RVA: 0xC2E4C0
        public void GetStandardValuesSupported(){} // RVA: 0xC2E4C0
        public void IsValueAllowed(){} // RVA: 0xC2E4C0
        public void .cctor(){} // RVA: 0x76D8960
    }

    public class ReflectEventDescriptor : EventDescriptor
    {
        public object _type;
        public object _componentClass;
        public object _addMethod;
        public object _removeMethod;
        public object _realEvent;
        public object _filledMethods;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76D8F70
        public void get_ComponentType(){} // RVA: 0xBBFF90
        public void get_EventType(){} // RVA: 0x76D9170
        public void get_IsMulticast(){} // RVA: 0x76D9190
        public void AddEventHandler(){} // RVA: 0x76D9270
        public void FillAttributes(){} // RVA: 0x76D9710
        public void FillEventInfoAttribute(){} // RVA: 0x76D9780
        public void FillMethods(){} // RVA: 0x76D9AE0
        public void FillSingleMethodAttribute(){} // RVA: 0x76DA080
        public void RemoveEventHandler(){} // RVA: 0x76DA490
    }

    public class ReflectPropertyDescriptor : PropertyDescriptor
    {
        public object argsNone;
        public object noValue;
        public object PropDescCreateSwitch;
        public object PropDescUsageSwitch;
        public object BitDefaultValueQueried;
        public object BitGetQueried;
        public object BitSetQueried;
        public object BitShouldSerializeQueried;
        public object BitResetQueried;
        public object BitChangedQueried;
        public object BitIPropChangedQueried;
        public object BitReadOnlyChecked;
        public object BitAmbientValueQueried;
        public object BitSetOnDemand;
        public object state;
        public object componentClass;
        public object type;
        public object defaultValue;
        public object ambientValue;
        public object propInfo;
        public object getMethod;
        public object setMethod;
        public object shouldSerializeMethod;
        public object resetMethod;
        public object realChangedEvent;
        public object realIPropChangedEvent;
        public object receiverType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76EA1C0
        public void get_AmbientValue(){} // RVA: 0x76EA740
        public void get_ChangedEventValue(){} // RVA: 0x76EA9C0
        public void get_IPropChangedEventValue(){} // RVA: 0x76EABE0
        public void set_IPropChangedEventValue(){} // RVA: 0x76EAE50
        public void get_ComponentType(){} // RVA: 0x1069350
        public void get_DefaultValue(){} // RVA: 0x76EAF10
        public void get_GetMethodValue(){} // RVA: 0x76EB2E0
        public void get_IsExtender(){} // RVA: 0x76EB840
        public void get_IsReadOnly(){} // RVA: 0x76EB870
        public void get_PropertyType(){} // RVA: 0x106A7D0
        public void get_ResetMethodValue(){} // RVA: 0x76EB9A0
        public void get_SetMethodValue(){} // RVA: 0x76EBC30
        public void get_ShouldSerializeMethodValue(){} // RVA: 0x76EC370
        public void AddValueChanged(){} // RVA: 0x76EC600
        public void ExtenderCanResetValue(){} // RVA: 0x76EC800
        public void ExtenderGetReceiverType(){} // RVA: 0xBC5BA0
        public void ExtenderGetType(){} // RVA: 0x66E7B30
        public void ExtenderGetValue(){} // RVA: 0x76ECA50
        public void ExtenderResetValue(){} // RVA: 0x76ECBD0
        public void ExtenderSetValue(){} // RVA: 0x76ECFA0
        public void ExtenderShouldSerializeValue(){} // RVA: 0x76ED320
        public void CanResetValue(){} // RVA: 0x76ED750
        public void FillAttributes(){} // RVA: 0x76ED9E0
        public void GetValue(){} // RVA: 0x76EE4B0
        public void OnINotifyPropertyChanged(){} // RVA: 0x76EE7A0
        public void OnValueChanged(){} // RVA: 0x76EE940
        public void RemoveValueChanged(){} // RVA: 0x76EEA50
        public void ResetValue(){} // RVA: 0x76EEC50
        public void SetValue(){} // RVA: 0x76EEF40
        public void ShouldSerializeValue(){} // RVA: 0x76EF420
        public void get_SupportsChangeEvents(){} // RVA: 0x76EF760
        public void .cctor(){} // RVA: 0x76EF7A0
    }

    public class ReflectTypeDescriptionProvider : TypeDescriptionProvider
    {
        public object _typeData;
        public object _typeConstructor;
        public object _editorTables;
        public object _intrinsicTypeConverters;
        public object _intrinsicReferenceKey;
        public object _intrinsicNullableKey;
        public object _dictionaryKey;
        public object _propertyCache;
        public object _eventCache;
        public object _attributeCache;
        public object _extendedPropertyCache;
        public object _extenderProviderKey;
        public object _extenderPropertiesKey;
        public object _extenderProviderPropertiesKey;
        public object _skipInterfaceAttributeList;
        public object _internalSyncObject;

        // ── Methods ──
        public void get_ExtenderProviderKey(){} // RVA: 0x76EFC00
        public void .ctor(){} // RVA: 0xB43310
        public void get_IntrinsicTypeConverters(){} // RVA: 0x76EFC60
        public void AddEditorTable(){} // RVA: 0x76F0E70
        public void CreateInstance(){} // RVA: 0x76F1440
        public void GetAttributes(){} // RVA: 0x76F15E0
        public void GetCache(){} // RVA: 0x76F1610
        public void GetClassName(){} // RVA: 0x76F1850
        public void GetComponentName(){} // RVA: 0x76F1890
        public void GetConverter(){} // RVA: 0x76F1970
        public void GetDefaultEvent(){} // RVA: 0x76F19B0
        public void GetDefaultProperty(){} // RVA: 0x76F19F0
        public void GetEditor(){} // RVA: 0x76F1A30
        public void GetEditorTable(){} // RVA: 0x76F1A80
        public void GetEvents(){} // RVA: 0x76F20D0
        public void GetExtendedAttributes(){} // RVA: 0x76F2100
        public void GetExtendedClassName(){} // RVA: 0x76F2160
        public void GetExtendedComponentName(){} // RVA: 0x76F21C0
        public void GetExtendedConverter(){} // RVA: 0x76F2210
        public void GetExtendedDefaultEvent(){} // RVA: 0xDAC980
        public void GetExtendedDefaultProperty(){} // RVA: 0xDAC980
        public void GetExtendedEditor(){} // RVA: 0x76F2270
        public void GetExtendedEvents(){} // RVA: 0x76F22E0
        public void GetExtendedProperties(){} // RVA: 0x76F2340
        public void GetExtenderProviders(){} // RVA: 0x76F2850
        public void GetExtenders(){} // RVA: 0x76F2B30
        public void GetExtendedPropertyOwner(){} // RVA: 0x76F33E0
        public void GetExtendedTypeDescriptor(){} // RVA: 0xDAC980
        public void GetFullComponentName(){} // RVA: 0x76F3460
        public void GetPopulatedTypes(){} // RVA: 0x76F35C0
        public void GetProperties(){} // RVA: 0x76F3A80
        public void GetPropertyOwner(){} // RVA: 0x76F3AB0
        public void GetReflectionType(){} // RVA: 0x1CB3B00
        public void GetTypeData(){} // RVA: 0x76F3B10
        public void GetTypeDescriptor(){} // RVA: 0xDAC980
        public void GetTypeFromName(){} // RVA: 0x76F3ED0
        public void IsPopulated(){} // RVA: 0x76F3FB0
        public void ReflectGetAttributes(){} // RVA: 0x76F4630
        public void ReflectGetEvents(){} // RVA: 0x76F4C60
        public void ReflectGetExtendedProperties(){} // RVA: 0x76F5500
        public void ReflectGetProperties(){} // RVA: 0x76F63D0
        public void Refresh(){} // RVA: 0x76F6B90
        public void SearchIntrinsicTable(){} // RVA: 0x76F6BC0
        public void .cctor(){} // RVA: 0x76F7480
    }

    public class RefreshEventArgs : EventArgs
    {
        public object _componentChanged;
        public object _typeChanged;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76DA990
        public void get_ComponentChanged(){} // RVA: 0xB5DBF0
        public void get_TypeChanged(){} // RVA: 0xB465B0
    }

    public class RefreshEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0xB9E020
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class RefreshPropertiesAttribute : Attribute
    {
        public object All;
        public object Repaint;
        public object Default;
        public object refresh;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_RefreshProperties(){} // RVA: 0xB8F8F0
        public void Equals(){} // RVA: 0x770F650
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x770F6E0
        public void .cctor(){} // RVA: 0x770F750
    }

    public class RunInstallerAttribute : Attribute
    {
        public object _runInstaller;
        public object Yes;
        public object No;
        public object Default;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_RunInstaller(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76DAA30
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76DAAD0
        public void .cctor(){} // RVA: 0x76DAB40
    }

    public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
    {
        public object result;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76FA3A0
        public void get_Result(){} // RVA: 0x76FA510
        public void get_UserState(){} // RVA: 0xB700F0
    }

    public class RunWorkerCompletedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

}