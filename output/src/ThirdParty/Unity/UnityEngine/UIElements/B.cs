// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 100
// Methods: 1652

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Background
    {
        public UnityEngine.Texture2D m_Texture; // 0x10
        public UnityEngine.Sprite m_Sprite; // 0x18
        public UnityEngine.RenderTexture m_RenderTexture; // 0x20
        public UnityEngine.UIElements.VectorImage m_VectorImage; // 0x28

        // ── Methods ──
        public void get_texture(){} // RVA: 0x2738C50
        public void set_texture(){} // RVA: 0x743C250
        public void get_sprite(){} // RVA: 0x5F1D510
        public void set_sprite(){} // RVA: 0x743C4C0
        public void get_renderTexture(){} // RVA: 0x33B6D40
        public void set_renderTexture(){} // RVA: 0x743C730
        public void get_vectorImage(){} // RVA: 0x2F0F420
        public void set_vectorImage(){} // RVA: 0x743C9A0
        public void FromTexture2D(){} // RVA: 0x743CC10
        public void FromRenderTexture(){} // RVA: 0x743CC60
        public void FromSprite(){} // RVA: 0x743CCB0
        public void FromVectorImage(){} // RVA: 0x743CD00
        public void FromObject(){} // RVA: 0x743CD50
        public void op_Equality(){} // RVA: 0x743D180
        public void op_Inequality(){} // RVA: 0x743D550
        public void Equals(){} // RVA: 0x743D5D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x743D680
        public void ToString(){} // RVA: 0x743D750
    }

    public class BackgroundPosition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x37C5E60 | overloaded x2
        public void Initial(){} // RVA: 0x72E5460
        public void Equals(){} // RVA: 0x72E5560 | overloaded x2
        public void GetHashCode(){} // RVA: 0x72E55A0
        public void op_Equality(){} // RVA: 0x72E55D0
        public void op_Inequality(){} // RVA: 0x72E5630
        public void ToString(){} // RVA: 0x72E56B0
    }

    public class BackgroundPropertyHelper
    {
        // ── Methods ──
        public void ConvertScaleModeToBackgroundPosition(){} // RVA: 0x72E5790
        public void ConvertScaleModeToBackgroundRepeat(){} // RVA: 0x72E57C0
        public void ConvertScaleModeToBackgroundSize(){} // RVA: 0x72E57D0
        public void ResolveUnityBackgroundScaleMode(){} // RVA: 0x72E58B0
    }

    public class BackgroundRepeat
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8AE010
        public void Initial(){} // RVA: 0x72E5D70
        public void Equals(){} // RVA: 0x72E5E20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x72E5E40
        public void op_Equality(){} // RVA: 0x72E5E60
        public void op_Inequality(){} // RVA: 0x72E5E80
        public void ToString(){} // RVA: 0x72E5EA0
    }

    public class BackgroundSize
    {
        public 0x6583DB58 m_SizeType; // 0x10
        public UnityEngine.UIElements.Length m_X; // 0x14
        public UnityEngine.UIElements.Length m_Y; // 0x1C

        // ── Methods ──
        public void get_sizeType(){} // RVA: 0x67FD0D0
        public void set_sizeType(){} // RVA: 0x72E5F70
        public void get_x(){} // RVA: 0x5F21E30
        public void set_x(){} // RVA: 0x72E5FA0
        public void get_y(){} // RVA: 0x72E5FB0
        public void set_y(){} // RVA: 0x72E5FC0
        public void .ctor(){} // RVA: 0x72E5F70 | overloaded x2
        public void Initial(){} // RVA: 0x72E5FE0
        public void Equals(){} // RVA: 0x72E6150 | overloaded x2
        public void GetHashCode(){} // RVA: 0x72E61C0
        public void op_Equality(){} // RVA: 0x72E6220
        public void op_Inequality(){} // RVA: 0x72E62A0
        public void ToString(){} // RVA: 0x72E6330
    }

    public class BaseBoolField
    {
        public UnityEngine.UIElements.Label m_Label; // 0x440

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72F7E40
        public void OnNavigationSubmit(){} // RVA: 0x72F8360
        public void get_text(){} // RVA: 0x72F83A0
        public void set_text(){} // RVA: 0x72F83D0
        public void InitLabel(){} // RVA: 0x72F84C0
        public void SetValueWithoutNotify(){} // RVA: 0x72F85D0
        public void OnClickEvent(){} // RVA: 0x72F8720
        public void ToggleValue(){} // RVA: 0x72F8930
        public void UpdateMixedValueContent(){} // RVA: 0x72F8970
        public void RegisterEditingCallbacks(){} // RVA: 0x72F8B60
        public void UnregisterEditingCallbacks(){} // RVA: 0x72F8C60
    }

    public class BaseCompositeField`3
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0xCD60
        public void DescribeFields(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2BAA0
        public void UpdateDisplay(){} // RVA: 0x24A50
        public void SetValueWithoutNotify(){} // RVA: 0x283FA0
        public void OnViewDataReady(){} // RVA: 0x24A50
        public void UpdateMixedValueContent(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class BaseCompositeField`3
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x55ADC10
        public void DescribeFields(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x55ADCF0
        public void UpdateDisplay(){} // RVA: 0x55AE820
        public void SetValueWithoutNotify(){} // RVA: 0x55AE950
        public void OnViewDataReady(){} // RVA: 0x55AEAB0
        public void UpdateMixedValueContent(){} // RVA: 0x55AEAD0
        public void .cctor(){} // RVA: 0x55AEC10
    }

    public class BaseCompositeField`3
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x55AF630
        public void DescribeFields(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x55AF710
        public void UpdateDisplay(){} // RVA: 0x55B0240
        public void SetValueWithoutNotify(){} // RVA: 0x55B0370
        public void OnViewDataReady(){} // RVA: 0x55B04D0
        public void UpdateMixedValueContent(){} // RVA: 0x55AEAD0
        public void .cctor(){} // RVA: 0x55B04F0
    }

    public class BaseCompositeField`3
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x55B0F10
        public void DescribeFields(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x55B0FF0
        public void UpdateDisplay(){} // RVA: 0x55B1B20
        public void SetValueWithoutNotify(){} // RVA: 0x55B1C50
        public void OnViewDataReady(){} // RVA: 0x55B1D20
        public void UpdateMixedValueContent(){} // RVA: 0x55B1D40
        public void .cctor(){} // RVA: 0x55B1E80
    }

    public class BaseCompositeField`3
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x55B4140
        public void DescribeFields(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x55B4220
        public void UpdateDisplay(){} // RVA: 0x55B4D50
        public void SetValueWithoutNotify(){} // RVA: 0x55B4E80
        public void OnViewDataReady(){} // RVA: 0x55B5010
        public void UpdateMixedValueContent(){} // RVA: 0x55AEAD0
        public void .cctor(){} // RVA: 0x55B5030
    }

    public class BaseCompositeField`3
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x55B7360
        public void DescribeFields(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x55B7440
        public void UpdateDisplay(){} // RVA: 0x55AE820
        public void SetValueWithoutNotify(){} // RVA: 0x55B7F70
        public void OnViewDataReady(){} // RVA: 0x55B80D0
        public void UpdateMixedValueContent(){} // RVA: 0x55AEAD0
        public void .cctor(){} // RVA: 0x55B80F0
    }

    public class BaseCompositeField`3
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x55B28A0
        public void DescribeFields(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x55B2980
        public void UpdateDisplay(){} // RVA: 0x55B34B0
        public void SetValueWithoutNotify(){} // RVA: 0x55B35C0
        public void OnViewDataReady(){} // RVA: 0x55B3700
        public void UpdateMixedValueContent(){} // RVA: 0x55B1D40
        public void .cctor(){} // RVA: 0x55B3720
    }

    public class BaseCompositeField`3
    {
        // ── Methods ──
        public void GetSpacer(){} // RVA: 0x55B5A50
        public void DescribeFields(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x55B5B30
        public void UpdateDisplay(){} // RVA: 0x55B6660
        public void SetValueWithoutNotify(){} // RVA: 0x55B6790
        public void OnViewDataReady(){} // RVA: 0x55B6920
        public void UpdateMixedValueContent(){} // RVA: 0x55AEAD0
        public void .cctor(){} // RVA: 0x55B6940
    }

    public class BaseFieldMouseDragger
    {
        // ── Methods ──
        public void SetDragZone(){} // RVA: 0x73FB6F0 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x24A50
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BDB40
        public void .ctor(){} // RVA: 0x55BDD40
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BCE40
        public void .ctor(){} // RVA: 0x55BCFD0
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BBBC0
        public void .ctor(){} // RVA: 0x55BBE60
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BD100
        public void .ctor(){} // RVA: 0x55BD290
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BC0D0
        public void .ctor(){} // RVA: 0x55BC400
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BC670
        public void .ctor(){} // RVA: 0x55BC800
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BC930
        public void .ctor(){} // RVA: 0x55BCBD0
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BB6B0
        public void .ctor(){} // RVA: 0x55BB950
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BD3C0
        public void .ctor(){} // RVA: 0x55BD660
    }

    public class BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x55BC930
        public void .ctor(){} // RVA: 0x55BD8D0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55F4460
        public void set_visualInput(){} // RVA: 0x55F44A0
        public void get_rawValue(){} // RVA: 0x263BC0
        public void set_rawValue(){} // RVA: 0x55F48F0
        public void add_onValidateValue(){} // RVA: 0x55F49C0
        public void remove_onValidateValue(){} // RVA: 0x55F4B30
        public void get_value(){} // RVA: 0x263BC0
        public void set_value(){} // RVA: 0x55F4CA0
        public void get_labelElement(){} // RVA: 0x55F51A0
        public void set_labelElement(){} // RVA: 0x55F51E0
        public void get_label(){} // RVA: 0x55F5260
        public void set_label(){} // RVA: 0x55F52B0
        public void get_showMixedValue(){} // RVA: 0x55F55C0
        public void set_showMixedValue(){} // RVA: 0x55F5600
        public void get_mixedValueLabel(){} // RVA: 0x55F5690
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x55F58F0
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x55F5930
        public void .ctor(){} // RVA: 0x55F5D60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55F5DC0
        public void OnDetachFromPanel(){} // RVA: 0x55F6150
        public void RegisterEditingCallbacks(){} // RVA: 0x55F6200
        public void UnregisterEditingCallbacks(){} // RVA: 0x55F6310
        public void StartEditing(){} // RVA: 0x55F6470
        public void EndEditing(){} // RVA: 0x55F64E0
        public void OnCustomStyleResolved(){} // RVA: 0x55F6550
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55F6A80
        public void AlignLabel(){} // RVA: 0x55F6AA0
        public void ValidatedValue(){} // RVA: 0x263BC0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55F72B0
        public void OnViewDataReady(){} // RVA: 0x55F74D0
        public void GetTooltipRect(){} // RVA: 0x55F7950
        public void .cctor(){} // RVA: 0x55F7A10
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55F4460
        public void set_visualInput(){} // RVA: 0x55F44A0
        public void get_rawValue(){} // RVA: 0x263BC0
        public void set_rawValue(){} // RVA: 0x55F48F0
        public void add_onValidateValue(){} // RVA: 0x55F49C0
        public void remove_onValidateValue(){} // RVA: 0x55F4B30
        public void get_value(){} // RVA: 0x263BC0
        public void set_value(){} // RVA: 0x55F4CA0
        public void get_labelElement(){} // RVA: 0x55F51A0
        public void set_labelElement(){} // RVA: 0x55F51E0
        public void get_label(){} // RVA: 0x55F5260
        public void set_label(){} // RVA: 0x55F52B0
        public void get_showMixedValue(){} // RVA: 0x55F55C0
        public void set_showMixedValue(){} // RVA: 0x55F5600
        public void get_mixedValueLabel(){} // RVA: 0x55F5690
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x55F58F0
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x55F5930
        public void .ctor(){} // RVA: 0x55F5D60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55F5DC0
        public void OnDetachFromPanel(){} // RVA: 0x55F6150
        public void RegisterEditingCallbacks(){} // RVA: 0x55F6200
        public void UnregisterEditingCallbacks(){} // RVA: 0x55F6310
        public void StartEditing(){} // RVA: 0x55F6470
        public void EndEditing(){} // RVA: 0x55F64E0
        public void OnCustomStyleResolved(){} // RVA: 0x55F6550
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55F6A80
        public void AlignLabel(){} // RVA: 0x55F6AA0
        public void ValidatedValue(){} // RVA: 0x263BC0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55F72B0
        public void OnViewDataReady(){} // RVA: 0x55F74D0
        public void GetTooltipRect(){} // RVA: 0x55F7950
        public void .cctor(){} // RVA: 0x55F7A10
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55F4460
        public void set_visualInput(){} // RVA: 0x55F44A0
        public void get_rawValue(){} // RVA: 0x263BC0
        public void set_rawValue(){} // RVA: 0x55F48F0
        public void add_onValidateValue(){} // RVA: 0x55F49C0
        public void remove_onValidateValue(){} // RVA: 0x55F4B30
        public void get_value(){} // RVA: 0x263BC0
        public void set_value(){} // RVA: 0x55F4CA0
        public void get_labelElement(){} // RVA: 0x55F51A0
        public void set_labelElement(){} // RVA: 0x55F51E0
        public void get_label(){} // RVA: 0x55F5260
        public void set_label(){} // RVA: 0x55F52B0
        public void get_showMixedValue(){} // RVA: 0x55F55C0
        public void set_showMixedValue(){} // RVA: 0x55F5600
        public void get_mixedValueLabel(){} // RVA: 0x55F5690
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x55F58F0
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x55F5930
        public void .ctor(){} // RVA: 0x55F5D60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55F5DC0
        public void OnDetachFromPanel(){} // RVA: 0x55F6150
        public void RegisterEditingCallbacks(){} // RVA: 0x55F6200
        public void UnregisterEditingCallbacks(){} // RVA: 0x55F6310
        public void StartEditing(){} // RVA: 0x55F6470
        public void EndEditing(){} // RVA: 0x55F64E0
        public void OnCustomStyleResolved(){} // RVA: 0x55F6550
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55F6A80
        public void AlignLabel(){} // RVA: 0x55F6AA0
        public void ValidatedValue(){} // RVA: 0x263BC0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55F72B0
        public void OnViewDataReady(){} // RVA: 0x55F74D0
        public void GetTooltipRect(){} // RVA: 0x55F7950
        public void .cctor(){} // RVA: 0x55F7A10
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName;
        public string inputUssClassName;
        public string noLabelVariantUssClassName;
        public string labelDraggerVariantUssClassName;
        public string mixedValueLabelUssClassName;
        public string alignedFieldUssClassName;
        public string inspectorFieldUssClassName;
        public string mixedValueString;

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0xCD60
        public void set_visualInput(){} // RVA: 0x24B10
        public void get_rawValue(){} // RVA: 0x283FA0
        public void set_rawValue(){} // RVA: 0x283FA0
        public void add_onValidateValue(){} // RVA: 0x24B10
        public void remove_onValidateValue(){} // RVA: 0x24B10
        public void get_value(){} // RVA: 0x283FA0
        public void set_value(){} // RVA: 0x283FA0
        public void get_labelElement(){} // RVA: 0xCD60
        public void set_labelElement(){} // RVA: 0x24B10
        public void get_label(){} // RVA: 0xCD60
        public void set_label(){} // RVA: 0x24B10
        public void get_showMixedValue(){} // RVA: 0xDBE0
        public void set_showMixedValue(){} // RVA: 0x25130
        public void get_mixedValueLabel(){} // RVA: 0xCD60
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xCD60
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DC60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x24B10
        public void OnDetachFromPanel(){} // RVA: 0x24B10
        public void RegisterEditingCallbacks(){} // RVA: 0x24A50
        public void UnregisterEditingCallbacks(){} // RVA: 0x24A50
        public void StartEditing(){} // RVA: 0x24B10
        public void EndEditing(){} // RVA: 0x24B10
        public void OnCustomStyleResolved(){} // RVA: 0x24B10
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x24B10
        public void AlignLabel(){} // RVA: 0x24A50
        public void ValidatedValue(){} // RVA: 0x283FA0
        public void UpdateMixedValueContent(){} // RVA: 0x24A50
        public void SetValueWithoutNotify(){} // RVA: 0x283FA0
        public void OnViewDataReady(){} // RVA: 0x24A50
        public void GetTooltipRect(){}
        public void .cctor(){} // RVA: 0x24A80
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55F4460
        public void set_visualInput(){} // RVA: 0x55F44A0
        public void get_rawValue(){} // RVA: 0x263BC0
        public void set_rawValue(){} // RVA: 0x55F48F0
        public void add_onValidateValue(){} // RVA: 0x55F49C0
        public void remove_onValidateValue(){} // RVA: 0x55F4B30
        public void get_value(){} // RVA: 0x263BC0
        public void set_value(){} // RVA: 0x55F4CA0
        public void get_labelElement(){} // RVA: 0x55F51A0
        public void set_labelElement(){} // RVA: 0x55F51E0
        public void get_label(){} // RVA: 0x55F5260
        public void set_label(){} // RVA: 0x55F52B0
        public void get_showMixedValue(){} // RVA: 0x55F55C0
        public void set_showMixedValue(){} // RVA: 0x55F5600
        public void get_mixedValueLabel(){} // RVA: 0x55F5690
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x55F58F0
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x55F5930
        public void .ctor(){} // RVA: 0x55F5D60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55F5DC0
        public void OnDetachFromPanel(){} // RVA: 0x55F6150
        public void RegisterEditingCallbacks(){} // RVA: 0x55F6200
        public void UnregisterEditingCallbacks(){} // RVA: 0x55F6310
        public void StartEditing(){} // RVA: 0x55F6470
        public void EndEditing(){} // RVA: 0x55F64E0
        public void OnCustomStyleResolved(){} // RVA: 0x55F6550
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55F6A80
        public void AlignLabel(){} // RVA: 0x55F6AA0
        public void ValidatedValue(){} // RVA: 0x263BC0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55F72B0
        public void OnViewDataReady(){} // RVA: 0x55F74D0
        public void GetTooltipRect(){} // RVA: 0x55F7950
        public void .cctor(){} // RVA: 0x55F7A10
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55F4460
        public void set_visualInput(){} // RVA: 0x55F44A0
        public void get_rawValue(){} // RVA: 0x263BC0
        public void set_rawValue(){} // RVA: 0x55F48F0
        public void add_onValidateValue(){} // RVA: 0x55F49C0
        public void remove_onValidateValue(){} // RVA: 0x55F4B30
        public void get_value(){} // RVA: 0x263BC0
        public void set_value(){} // RVA: 0x55F4CA0
        public void get_labelElement(){} // RVA: 0x55F51A0
        public void set_labelElement(){} // RVA: 0x55F51E0
        public void get_label(){} // RVA: 0x55F5260
        public void set_label(){} // RVA: 0x55F52B0
        public void get_showMixedValue(){} // RVA: 0x55F55C0
        public void set_showMixedValue(){} // RVA: 0x55F5600
        public void get_mixedValueLabel(){} // RVA: 0x55F5690
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x55F58F0
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x55F5930
        public void .ctor(){} // RVA: 0x55F5D60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55F5DC0
        public void OnDetachFromPanel(){} // RVA: 0x55F6150
        public void RegisterEditingCallbacks(){} // RVA: 0x55F6200
        public void UnregisterEditingCallbacks(){} // RVA: 0x55F6310
        public void StartEditing(){} // RVA: 0x55F6470
        public void EndEditing(){} // RVA: 0x55F64E0
        public void OnCustomStyleResolved(){} // RVA: 0x55F6550
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55F6A80
        public void AlignLabel(){} // RVA: 0x55F6AA0
        public void ValidatedValue(){} // RVA: 0x263BC0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55F72B0
        public void OnViewDataReady(){} // RVA: 0x55F74D0
        public void GetTooltipRect(){} // RVA: 0x55F7950
        public void .cctor(){} // RVA: 0x55F7A10
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55F4460
        public void set_visualInput(){} // RVA: 0x55F44A0
        public void get_rawValue(){} // RVA: 0x263BC0
        public void set_rawValue(){} // RVA: 0x55F48F0
        public void add_onValidateValue(){} // RVA: 0x55F49C0
        public void remove_onValidateValue(){} // RVA: 0x55F4B30
        public void get_value(){} // RVA: 0x263BC0
        public void set_value(){} // RVA: 0x55F4CA0
        public void get_labelElement(){} // RVA: 0x55F51A0
        public void set_labelElement(){} // RVA: 0x55F51E0
        public void get_label(){} // RVA: 0x55F5260
        public void set_label(){} // RVA: 0x55F52B0
        public void get_showMixedValue(){} // RVA: 0x55F55C0
        public void set_showMixedValue(){} // RVA: 0x55F5600
        public void get_mixedValueLabel(){} // RVA: 0x55F5690
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0x55F58F0
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0x55F5930
        public void .ctor(){} // RVA: 0x55F5D60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55F5DC0
        public void OnDetachFromPanel(){} // RVA: 0x55F6150
        public void RegisterEditingCallbacks(){} // RVA: 0x55F6200
        public void UnregisterEditingCallbacks(){} // RVA: 0x55F6310
        public void StartEditing(){} // RVA: 0x55F6470
        public void EndEditing(){} // RVA: 0x55F64E0
        public void OnCustomStyleResolved(){} // RVA: 0x55F6550
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55F6A80
        public void AlignLabel(){} // RVA: 0x55F6AA0
        public void ValidatedValue(){} // RVA: 0x263BC0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55F72B0
        public void OnViewDataReady(){} // RVA: 0x55F74D0
        public void GetTooltipRect(){} // RVA: 0x55F7950
        public void .cctor(){} // RVA: 0x55F7A10
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55D40F0
        public void get_rawValue(){} // RVA: 0x55D18E0
        public void set_rawValue(){} // RVA: 0xDA3230
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55D18E0
        public void set_value(){} // RVA: 0x55D47E0
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55D49A0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55D4F60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55D4FC0
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55D5270
        public void UnregisterEditingCallbacks(){} // RVA: 0x55D5380
        public void StartEditing(){} // RVA: 0x55D54E0
        public void EndEditing(){} // RVA: 0x55D5550
        public void OnCustomStyleResolved(){} // RVA: 0x55D55C0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55D5A70
        public void AlignLabel(){} // RVA: 0x55D5A90
        public void ValidatedValue(){} // RVA: 0x55D2FB0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55D5E90
        public void OnViewDataReady(){} // RVA: 0x55D6000
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55D61E0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55BDE90
        public void get_rawValue(){} // RVA: 0x55BE580
        public void set_rawValue(){} // RVA: 0x55BE590
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55BE580
        public void set_value(){} // RVA: 0x55BE7E0
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55BEC50
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55BF210 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55BF270
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55BF5A0
        public void UnregisterEditingCallbacks(){} // RVA: 0x55BF6B0
        public void StartEditing(){} // RVA: 0x55BF810
        public void EndEditing(){} // RVA: 0x55BF880
        public void OnCustomStyleResolved(){} // RVA: 0x55BF8F0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55BFDA0
        public void AlignLabel(){} // RVA: 0x55BFDC0
        public void ValidatedValue(){} // RVA: 0x55C01C0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55C01F0
        public void OnViewDataReady(){} // RVA: 0x55C02A0
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55C0500
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55C1380
        public void get_rawValue(){} // RVA: 0x55C1A70
        public void set_rawValue(){} // RVA: 0x55C1A90
        public void add_onValidateValue(){} // RVA: 0x55C1AB0
        public void remove_onValidateValue(){} // RVA: 0x55C1BD0
        public void get_value(){} // RVA: 0x55C1A70
        public void set_value(){} // RVA: 0x55C1CF0
        public void get_labelElement(){} // RVA: 0xDB45F0
        public void set_labelElement(){} // RVA: 0xD9A060
        public void get_label(){} // RVA: 0x55C1F60
        public void set_label(){} // RVA: 0x55C1F90
        public void get_showMixedValue(){} // RVA: 0x55C21D0
        public void set_showMixedValue(){} // RVA: 0x55C21E0
        public void get_mixedValueLabel(){} // RVA: 0x55C2210
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD8EF30
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD9A100
        public void .ctor(){} // RVA: 0x55C27D0 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55C2830
        public void OnDetachFromPanel(){} // RVA: 0x55C2AE0
        public void RegisterEditingCallbacks(){} // RVA: 0x55C2B60
        public void UnregisterEditingCallbacks(){} // RVA: 0x55C2C70
        public void StartEditing(){} // RVA: 0x55C2DD0
        public void EndEditing(){} // RVA: 0x55C2E40
        public void OnCustomStyleResolved(){} // RVA: 0x55C2EB0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55C3360
        public void AlignLabel(){} // RVA: 0x55C3380
        public void ValidatedValue(){} // RVA: 0x55C3780
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55C3820
        public void OnViewDataReady(){} // RVA: 0x55C3930
        public void GetTooltipRect(){} // RVA: 0x55C3BC0
        public void .cctor(){} // RVA: 0x55C3C40
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55C4AC0
        public void get_rawValue(){} // RVA: 0x55C1A70
        public void set_rawValue(){} // RVA: 0x55C1A90
        public void add_onValidateValue(){} // RVA: 0x55C1AB0
        public void remove_onValidateValue(){} // RVA: 0x55C1BD0
        public void get_value(){} // RVA: 0x55C1A70
        public void set_value(){} // RVA: 0x55C51B0
        public void get_labelElement(){} // RVA: 0xDB45F0
        public void set_labelElement(){} // RVA: 0xD9A060
        public void get_label(){} // RVA: 0x55C1F60
        public void set_label(){} // RVA: 0x55C1F90
        public void get_showMixedValue(){} // RVA: 0x55C21D0
        public void set_showMixedValue(){} // RVA: 0x55C21E0
        public void get_mixedValueLabel(){} // RVA: 0x55C5420
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD8EF30
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD9A100
        public void .ctor(){} // RVA: 0x55C59E0 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55C5A40
        public void OnDetachFromPanel(){} // RVA: 0x55C2AE0
        public void RegisterEditingCallbacks(){} // RVA: 0x55C5CF0
        public void UnregisterEditingCallbacks(){} // RVA: 0x55C5E00
        public void StartEditing(){} // RVA: 0x55C5F60
        public void EndEditing(){} // RVA: 0x55C5FD0
        public void OnCustomStyleResolved(){} // RVA: 0x55C6040
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55C64F0
        public void AlignLabel(){} // RVA: 0x55C6510
        public void ValidatedValue(){} // RVA: 0x55C3780
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55C3820
        public void OnViewDataReady(){} // RVA: 0x55C6910
        public void GetTooltipRect(){} // RVA: 0x55C3BC0
        public void .cctor(){} // RVA: 0x55C6BA0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55CDF00
        public void get_rawValue(){} // RVA: 0x55CE5F0
        public void set_rawValue(){} // RVA: 0x55CE600
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55CE5F0
        public void set_value(){} // RVA: 0x55CE610
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55CE7C0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55CED80 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55CEDE0
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55CF090
        public void UnregisterEditingCallbacks(){} // RVA: 0x55CF1A0
        public void StartEditing(){} // RVA: 0x55CF300
        public void EndEditing(){} // RVA: 0x55CF370
        public void OnCustomStyleResolved(){} // RVA: 0x55CF3E0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55CF890
        public void AlignLabel(){} // RVA: 0x55CF8B0
        public void ValidatedValue(){} // RVA: 0x55CFCB0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55CFCE0
        public void OnViewDataReady(){} // RVA: 0x55CFD90
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55CFF70
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55D7060
        public void get_rawValue(){} // RVA: 0x55CB010
        public void set_rawValue(){} // RVA: 0x55CB020
        public void add_onValidateValue(){} // RVA: 0x55CB030
        public void remove_onValidateValue(){} // RVA: 0x55CB150
        public void get_value(){} // RVA: 0x55CB010
        public void set_value(){} // RVA: 0x55D7750
        public void get_labelElement(){} // RVA: 0xDB4C80
        public void set_labelElement(){} // RVA: 0xD88A20
        public void get_label(){} // RVA: 0x55CB470
        public void set_label(){} // RVA: 0x55CB4A0
        public void get_showMixedValue(){} // RVA: 0x55CB6E0
        public void set_showMixedValue(){} // RVA: 0x55CB6F0
        public void get_mixedValueLabel(){} // RVA: 0x55D7950
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD95A10
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD8EF30
        public void .ctor(){} // RVA: 0x55D7F10 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55D7F70
        public void OnDetachFromPanel(){} // RVA: 0x55CBFF0
        public void RegisterEditingCallbacks(){} // RVA: 0x55D8220
        public void UnregisterEditingCallbacks(){} // RVA: 0x55D8330
        public void StartEditing(){} // RVA: 0x55D8490
        public void EndEditing(){} // RVA: 0x55D8500
        public void OnCustomStyleResolved(){} // RVA: 0x55D8570
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55D8A20
        public void AlignLabel(){} // RVA: 0x55D8A40
        public void ValidatedValue(){} // RVA: 0x55CCC90
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55CCD00
        public void OnViewDataReady(){} // RVA: 0x55D8E40
        public void GetTooltipRect(){} // RVA: 0x55CD000
        public void .cctor(){} // RVA: 0x55D9060
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55D9EE0
        public void get_rawValue(){} // RVA: 0x55CB010
        public void set_rawValue(){} // RVA: 0x55CB020
        public void add_onValidateValue(){} // RVA: 0x55CB030
        public void remove_onValidateValue(){} // RVA: 0x55CB150
        public void get_value(){} // RVA: 0x55CB010
        public void set_value(){} // RVA: 0x55DA5D0
        public void get_labelElement(){} // RVA: 0xDB4C80
        public void set_labelElement(){} // RVA: 0xD88A20
        public void get_label(){} // RVA: 0x55CB470
        public void set_label(){} // RVA: 0x55CB4A0
        public void get_showMixedValue(){} // RVA: 0x55CB6E0
        public void set_showMixedValue(){} // RVA: 0x55CB6F0
        public void get_mixedValueLabel(){} // RVA: 0x55DA7D0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD95A10
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD8EF30
        public void .ctor(){} // RVA: 0x55DAD90 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55DADF0
        public void OnDetachFromPanel(){} // RVA: 0x55CBFF0
        public void RegisterEditingCallbacks(){} // RVA: 0x55DB0A0
        public void UnregisterEditingCallbacks(){} // RVA: 0x55DB1B0
        public void StartEditing(){} // RVA: 0x55DB310
        public void EndEditing(){} // RVA: 0x55DB380
        public void OnCustomStyleResolved(){} // RVA: 0x55DB3F0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55DB8A0
        public void AlignLabel(){} // RVA: 0x55DB8C0
        public void ValidatedValue(){} // RVA: 0x55CCC90
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55CCD00
        public void OnViewDataReady(){} // RVA: 0x55DBCC0
        public void GetTooltipRect(){} // RVA: 0x55CD000
        public void .cctor(){} // RVA: 0x55DBEE0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55E5820
        public void get_rawValue(){} // RVA: 0x55E5F10
        public void set_rawValue(){} // RVA: 0x55D18F0
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55E5F10
        public void set_value(){} // RVA: 0x55E5F30
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55E6160
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55E6720 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55E6780
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55E6A30
        public void UnregisterEditingCallbacks(){} // RVA: 0x55E6B40
        public void StartEditing(){} // RVA: 0x55E6CA0
        public void EndEditing(){} // RVA: 0x55E6D10
        public void OnCustomStyleResolved(){} // RVA: 0x55E6D80
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55E7230
        public void AlignLabel(){} // RVA: 0x55E7250
        public void ValidatedValue(){} // RVA: 0x55D2FB0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55E7650
        public void OnViewDataReady(){} // RVA: 0x55E7730
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55E7970
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55EB5F0
        public void get_rawValue(){} // RVA: 0x55EBCE0
        public void set_rawValue(){} // RVA: 0x55EBD00
        public void add_onValidateValue(){} // RVA: 0x55CB030
        public void remove_onValidateValue(){} // RVA: 0x55CB150
        public void get_value(){} // RVA: 0x55EBCE0
        public void set_value(){} // RVA: 0x55EBD20
        public void get_labelElement(){} // RVA: 0xDB4C80
        public void set_labelElement(){} // RVA: 0xD88A20
        public void get_label(){} // RVA: 0x55CB470
        public void set_label(){} // RVA: 0x55CB4A0
        public void get_showMixedValue(){} // RVA: 0x55CB6E0
        public void set_showMixedValue(){} // RVA: 0x55CB6F0
        public void get_mixedValueLabel(){} // RVA: 0x55EBF70
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD95A10
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD8EF30
        public void .ctor(){} // RVA: 0x55EC530 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55EC590
        public void OnDetachFromPanel(){} // RVA: 0x55CBFF0
        public void RegisterEditingCallbacks(){} // RVA: 0x55EC840
        public void UnregisterEditingCallbacks(){} // RVA: 0x55EC950
        public void StartEditing(){} // RVA: 0x55ECAB0
        public void EndEditing(){} // RVA: 0x55ECB20
        public void OnCustomStyleResolved(){} // RVA: 0x55ECB90
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55ED040
        public void AlignLabel(){} // RVA: 0x55ED060
        public void ValidatedValue(){} // RVA: 0x55ED460
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55ED4F0
        public void OnViewDataReady(){} // RVA: 0x55ED5F0
        public void GetTooltipRect(){} // RVA: 0x55CD000
        public void .cctor(){} // RVA: 0x55ED850
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55F15E0
        public void get_rawValue(){} // RVA: 0x55CB010
        public void set_rawValue(){} // RVA: 0x55CB020
        public void add_onValidateValue(){} // RVA: 0x55CB030
        public void remove_onValidateValue(){} // RVA: 0x55CB150
        public void get_value(){} // RVA: 0x55CB010
        public void set_value(){} // RVA: 0x55F1CD0
        public void get_labelElement(){} // RVA: 0xDB4C80
        public void set_labelElement(){} // RVA: 0xD88A20
        public void get_label(){} // RVA: 0x55CB470
        public void set_label(){} // RVA: 0x55CB4A0
        public void get_showMixedValue(){} // RVA: 0x55CB6E0
        public void set_showMixedValue(){} // RVA: 0x55CB6F0
        public void get_mixedValueLabel(){} // RVA: 0x55F1ED0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD95A10
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD8EF30
        public void .ctor(){} // RVA: 0x55F2490 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55F24F0
        public void OnDetachFromPanel(){} // RVA: 0x55CBFF0
        public void RegisterEditingCallbacks(){} // RVA: 0x55F27A0
        public void UnregisterEditingCallbacks(){} // RVA: 0x55F28B0
        public void StartEditing(){} // RVA: 0x55F2A10
        public void EndEditing(){} // RVA: 0x55F2A80
        public void OnCustomStyleResolved(){} // RVA: 0x55F2AF0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55F2FA0
        public void AlignLabel(){} // RVA: 0x55F2FC0
        public void ValidatedValue(){} // RVA: 0x55CCC90
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55CCD00
        public void OnViewDataReady(){} // RVA: 0x55F33C0
        public void GetTooltipRect(){} // RVA: 0x55CD000
        public void .cctor(){} // RVA: 0x55F35E0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55E87F0
        public void get_rawValue(){} // RVA: 0x55D18E0
        public void set_rawValue(){} // RVA: 0x55D18F0
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55D18E0
        public void set_value(){} // RVA: 0x55E8EE0
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55E90A0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55E9660 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55E96C0
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55E9970
        public void UnregisterEditingCallbacks(){} // RVA: 0x55E9A80
        public void StartEditing(){} // RVA: 0x55E9BE0
        public void EndEditing(){} // RVA: 0x55E9C50
        public void OnCustomStyleResolved(){} // RVA: 0x55E9CC0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55EA170
        public void AlignLabel(){} // RVA: 0x55EA190
        public void ValidatedValue(){} // RVA: 0x55D2FB0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55D2FE0
        public void OnViewDataReady(){} // RVA: 0x55EA590
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55EA770
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55EE6D0
        public void get_rawValue(){} // RVA: 0x55EBCE0
        public void set_rawValue(){} // RVA: 0x55EBD00
        public void add_onValidateValue(){} // RVA: 0x55CB030
        public void remove_onValidateValue(){} // RVA: 0x55CB150
        public void get_value(){} // RVA: 0x55EBCE0
        public void set_value(){} // RVA: 0x55EEDC0
        public void get_labelElement(){} // RVA: 0xDB4C80
        public void set_labelElement(){} // RVA: 0xD88A20
        public void get_label(){} // RVA: 0x55CB470
        public void set_label(){} // RVA: 0x55CB4A0
        public void get_showMixedValue(){} // RVA: 0x55CB6E0
        public void set_showMixedValue(){} // RVA: 0x55CB6F0
        public void get_mixedValueLabel(){} // RVA: 0x55EF010
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD95A10
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD8EF30
        public void .ctor(){} // RVA: 0x55EF5D0 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55EF630
        public void OnDetachFromPanel(){} // RVA: 0x55CBFF0
        public void RegisterEditingCallbacks(){} // RVA: 0x55EF8E0
        public void UnregisterEditingCallbacks(){} // RVA: 0x55EF9F0
        public void StartEditing(){} // RVA: 0x55EFB50
        public void EndEditing(){} // RVA: 0x55EFBC0
        public void OnCustomStyleResolved(){} // RVA: 0x55EFC30
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55F00E0
        public void AlignLabel(){} // RVA: 0x55F0100
        public void ValidatedValue(){} // RVA: 0x55ED460
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55ED4F0
        public void OnViewDataReady(){} // RVA: 0x55F0500
        public void GetTooltipRect(){} // RVA: 0x55CD000
        public void .cctor(){} // RVA: 0x55F0760
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55C7A20
        public void get_rawValue(){} // RVA: 0x55C8110
        public void set_rawValue(){} // RVA: 0x55C8120
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55C8110
        public void set_value(){} // RVA: 0x55C8130
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55C82F0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55C88B0 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55C8910
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55C8BC0
        public void UnregisterEditingCallbacks(){} // RVA: 0x55C8CD0
        public void StartEditing(){} // RVA: 0x55C8E30
        public void EndEditing(){} // RVA: 0x55C8EA0
        public void OnCustomStyleResolved(){} // RVA: 0x55C8F10
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55C93C0
        public void AlignLabel(){} // RVA: 0x55C93E0
        public void ValidatedValue(){} // RVA: 0x55C97E0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55C9810
        public void OnViewDataReady(){} // RVA: 0x55C98C0
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55C9AA0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55D40F0
        public void get_rawValue(){} // RVA: 0x55D18E0
        public void set_rawValue(){} // RVA: 0xDA3230
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55D18E0
        public void set_value(){} // RVA: 0x55D47E0
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55D49A0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55D4F60 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55D4FC0
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55D5270
        public void UnregisterEditingCallbacks(){} // RVA: 0x55D5380
        public void StartEditing(){} // RVA: 0x55D54E0
        public void EndEditing(){} // RVA: 0x55D5550
        public void OnCustomStyleResolved(){} // RVA: 0x55D55C0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55D5A70
        public void AlignLabel(){} // RVA: 0x55D5A90
        public void ValidatedValue(){} // RVA: 0x55D2FB0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55D5E90
        public void OnViewDataReady(){} // RVA: 0x55D6000
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55D61E0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55DCD60
        public void get_rawValue(){} // RVA: 0x55DD450
        public void set_rawValue(){} // RVA: 0x55DD460
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55DD450
        public void set_value(){} // RVA: 0x55DD470
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55DD630
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55DDBF0 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55DDC50
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55DDF00
        public void UnregisterEditingCallbacks(){} // RVA: 0x55DE010
        public void StartEditing(){} // RVA: 0x55DE170
        public void EndEditing(){} // RVA: 0x55DE1E0
        public void OnCustomStyleResolved(){} // RVA: 0x55DE250
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55DE700
        public void AlignLabel(){} // RVA: 0x55DE720
        public void ValidatedValue(){} // RVA: 0x55C97E0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55DEB20
        public void OnViewDataReady(){} // RVA: 0x55DEBD0
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55DEDB0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55CA920
        public void get_rawValue(){} // RVA: 0x55CB010
        public void set_rawValue(){} // RVA: 0x55CB020
        public void add_onValidateValue(){} // RVA: 0x55CB030
        public void remove_onValidateValue(){} // RVA: 0x55CB150
        public void get_value(){} // RVA: 0x55CB010
        public void set_value(){} // RVA: 0x55CB270
        public void get_labelElement(){} // RVA: 0xDB4C80
        public void set_labelElement(){} // RVA: 0xD88A20
        public void get_label(){} // RVA: 0x55CB470
        public void set_label(){} // RVA: 0x55CB4A0
        public void get_showMixedValue(){} // RVA: 0x55CB6E0
        public void set_showMixedValue(){} // RVA: 0x55CB6F0
        public void get_mixedValueLabel(){} // RVA: 0x55CB720
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD95A10
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD8EF30
        public void .ctor(){} // RVA: 0x55CBCE0 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55CBD40
        public void OnDetachFromPanel(){} // RVA: 0x55CBFF0
        public void RegisterEditingCallbacks(){} // RVA: 0x55CC070
        public void UnregisterEditingCallbacks(){} // RVA: 0x55CC180
        public void StartEditing(){} // RVA: 0x55CC2E0
        public void EndEditing(){} // RVA: 0x55CC350
        public void OnCustomStyleResolved(){} // RVA: 0x55CC3C0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55CC870
        public void AlignLabel(){} // RVA: 0x55CC890
        public void ValidatedValue(){} // RVA: 0x55CCC90
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55CCD00
        public void OnViewDataReady(){} // RVA: 0x55CCDE0
        public void GetTooltipRect(){} // RVA: 0x55CD000
        public void .cctor(){} // RVA: 0x55CD080
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55D11F0
        public void get_rawValue(){} // RVA: 0x55D18E0
        public void set_rawValue(){} // RVA: 0x55D18F0
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55D18E0
        public void set_value(){} // RVA: 0x55D1900
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55D1AC0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55D2080 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55D20E0
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55D2390
        public void UnregisterEditingCallbacks(){} // RVA: 0x55D24A0
        public void StartEditing(){} // RVA: 0x55D2600
        public void EndEditing(){} // RVA: 0x55D2670
        public void OnCustomStyleResolved(){} // RVA: 0x55D26E0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55D2B90
        public void AlignLabel(){} // RVA: 0x55D2BB0
        public void ValidatedValue(){} // RVA: 0x55D2FB0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55D2FE0
        public void OnViewDataReady(){} // RVA: 0x55D3090
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55D3270
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55DFC30
        public void get_rawValue(){} // RVA: 0x55CE5F0
        public void set_rawValue(){} // RVA: 0x55CE600
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55CE5F0
        public void set_value(){} // RVA: 0x55E0320
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55E04D0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55E0A90 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55E0AF0
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55E0DA0
        public void UnregisterEditingCallbacks(){} // RVA: 0x55E0EB0
        public void StartEditing(){} // RVA: 0x55E1010
        public void EndEditing(){} // RVA: 0x55E1080
        public void OnCustomStyleResolved(){} // RVA: 0x55E10F0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55E15A0
        public void AlignLabel(){} // RVA: 0x55E15C0
        public void ValidatedValue(){} // RVA: 0x55CFCB0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55CFCE0
        public void OnViewDataReady(){} // RVA: 0x55E19C0
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55E1BA0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40

        // ── Methods ──
        public void get_visualInput(){} // RVA: 0x55BDE80
        public void set_visualInput(){} // RVA: 0x55E2A20
        public void get_rawValue(){} // RVA: 0x55D18E0
        public void set_rawValue(){} // RVA: 0x55D18F0
        public void add_onValidateValue(){} // RVA: 0x55BE5A0
        public void remove_onValidateValue(){} // RVA: 0x55BE6C0
        public void get_value(){} // RVA: 0x55D18E0
        public void set_value(){} // RVA: 0x55E3110
        public void get_labelElement(){} // RVA: 0xD8BD40
        public void set_labelElement(){} // RVA: 0xD93E40
        public void get_label(){} // RVA: 0x55BE9A0
        public void set_label(){} // RVA: 0x55BE9D0
        public void get_showMixedValue(){} // RVA: 0x55BEC10
        public void set_showMixedValue(){} // RVA: 0x55BEC20
        public void get_mixedValueLabel(){} // RVA: 0x55E32D0
        public void UnityEngine.UIElements.IEditableElement.get_editingStarted(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.IEditableElement.get_editingEnded(){} // RVA: 0xD95A10
        public void .ctor(){} // RVA: 0x55E3890 | overloaded x2
        public void OnAttachToPanel(){} // RVA: 0x55E38F0
        public void OnDetachFromPanel(){} // RVA: 0x55BF520
        public void RegisterEditingCallbacks(){} // RVA: 0x55E3BA0
        public void UnregisterEditingCallbacks(){} // RVA: 0x55E3CB0
        public void StartEditing(){} // RVA: 0x55E3E10
        public void EndEditing(){} // RVA: 0x55E3E80
        public void OnCustomStyleResolved(){} // RVA: 0x55E3EF0
        public void OnInspectorFieldGeometryChanged(){} // RVA: 0x55E43A0
        public void AlignLabel(){} // RVA: 0x55E43C0
        public void ValidatedValue(){} // RVA: 0x55D2FB0
        public void UpdateMixedValueContent(){} // RVA: 0x3340040
        public void SetValueWithoutNotify(){} // RVA: 0x55D2FE0
        public void OnViewDataReady(){} // RVA: 0x55E47C0
        public void GetTooltipRect(){} // RVA: 0x55C0480
        public void .cctor(){} // RVA: 0x55E49A0
    }

    public class BaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noLabelVariantUssClassName; // 0x18
        public string labelDraggerVariantUssClassName; // 0x20
        public string mixedValueLabelUssClassName; // 0x28
        public string alignedFieldUssClassName; // 0x30
        public string inspectorFieldUssClassName; // 0x38
        public string mixedValueString; // 0x40
    }

    public class BaseListView
    {
        public string k_SizeFieldLabel;
        public bool m_ShowBoundCollectionSize; // 0x4B0
        public bool m_ShowFoldoutHeader; // 0x4B1
        public string m_HeaderTitle; // 0x4B8
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> itemsAdded; // 0x4C0
        public System.Action`1<System.Collections.Generic.IEnumerable`1<int>> itemsRemoved; // 0x4C8
        public System.Action itemsSourceSizeChanged; // 0x4D0

        // ── Methods ──
        public void get_showBoundCollectionSize(){} // RVA: 0x72F8D90
        public void set_showBoundCollectionSize(){} // RVA: 0x72F8DA0
        public void get_showFoldoutHeader(){} // RVA: 0x72F8DC0
        public void set_showFoldoutHeader(){} // RVA: 0x72F8DD0
        public void SetupArraySizeField(){} // RVA: 0x72F9200
        public void set_headerTitle(){} // RVA: 0x72F9680
        public void get_showAddRemoveFooter(){} // RVA: 0x72F9700
        public void set_showAddRemoveFooter(){} // RVA: 0x72F9710
        public void EnableFooter(){} // RVA: 0x72F9720
        public void AddItems(){} // RVA: 0x72F9E10
        public void OnArraySizeFieldChanged(){} // RVA: 0x72F9E50
        public void UpdateArraySizeField(){} // RVA: 0x72FA170
        public void UpdateListViewLabel(){} // RVA: 0x72FA270
        public void OnAddClicked(){} // RVA: 0x72FA530
        public void OnRemoveClicked(){} // RVA: 0x72FA710
        public void get_footer(){} // RVA: 0xD8A800
        public void get_viewController(){} // RVA: 0x72FA980
        public void CreateVirtualizationController(){} // RVA: 0x72FAA10
        public void SetViewController(){} // RVA: 0x72FAA50
        public void OnItemAdded(){} // RVA: 0x72FB280
        public void OnItemsRemoved(){} // RVA: 0x72FB2A0
        public void OnItemsSourceSizeChanged(){} // RVA: 0x72FB2C0
        public void add_reorderModeChanged(){} // RVA: 0x72FB390
        public void remove_reorderModeChanged(){} // RVA: 0x72FB480
        public void get_reorderMode(){} // RVA: 0x72FB570
        public void set_reorderMode(){} // RVA: 0x72FB580
        public void CreateDragger(){} // RVA: 0x72FB5E0
        public void CreateDragAndDropController(){} // RVA: 0x72FB660
        public void .ctor(){} // RVA: 0x72FB700
        public void PostRefresh(){} // RVA: 0x72FB7E0
        public void HandleItemNavigation(){} // RVA: 0x72FB8C0
        public void .cctor(){} // RVA: 0x72FBC20
        public void <OnAddClicked>b__36_0(){} // RVA: 0x72FC920
    }

    public class BaseListViewController
    {
        public System.Action itemsSourceSizeChanged; // 0x30

        // ── Methods ──
        public void add_itemsSourceSizeChanged(){} // RVA: 0x72EC210
        public void remove_itemsSourceSizeChanged(){} // RVA: 0x72EC300
        public void add_itemsAdded(){} // RVA: 0x72EC3F0
        public void remove_itemsAdded(){} // RVA: 0x72EC4F0
        public void add_itemsRemoved(){} // RVA: 0x72EC5F0
        public void remove_itemsRemoved(){} // RVA: 0x72EC6F0
        public void get_baseListView(){} // RVA: 0x72EC7F0
        public void InvokeMakeItem(){} // RVA: 0x72EC880
        public void PostInitRegistration(){} // RVA: 0x72ECA80
        public void InvokeBindItem(){} // RVA: 0x72ECDA0
        public void NeedsDragHandle(){} // RVA: 0x20D68C0
        public void AddItems(){} // RVA: 0x72ED050
        public void Move(){} // RVA: 0x72ED680
        public void RemoveItem(){} // RVA: 0x72ED8D0
        public void RemoveItems(){} // RVA: 0x72EDD50 | overloaded x2
        public void ClearItems(){} // RVA: 0x72EDF20
        public void RaiseOnSizeChanged(){} // RVA: 0x72EE040
        public void RaiseItemsAdded(){} // RVA: 0x72EE060
        public void RaiseItemsRemoved(){} // RVA: 0x4EEA9A0
        public void AddToArray(){} // RVA: 0x72EE080
        public void RemoveFromArray(){} // RVA: 0x72EE260
        public void Swap(){} // RVA: 0x72EE410
        public void EnsureItemSourceCanBeResized(){} // RVA: 0x72EE550
        public void .ctor(){} // RVA: 0x2DD310
        public void <AddItems>g__IsGenericList|15_0(){} // RVA: 0x72EE690
    }

    public class BasePopupField`2
    {
        public System.Collections.Generic.List`1<T> m_Choices; // 0x440
        public UnityEngine.UIElements.TextElement m_TextElement; // 0x448

        // ── Methods ──
        public void get_textElement(){} // RVA: 0x570E380
        public void GetValueToDisplay(){} // RVA: 0xCD60
        public void GetListItemToDisplay(){} // RVA: 0x283FA0
        public void AddMenuItems(){} // RVA: 0x24B10
        public void set_choices(){} // RVA: 0x570E3B0
        public void SetValueWithoutNotify(){} // RVA: 0x570E500
        public void .ctor(){} // RVA: 0x570E670
        public void OnPointerDownEvent(){} // RVA: 0x570EF70
        public void OnPointerMoveEvent(){} // RVA: 0x570EF90
        public void ContainsPointer(){} // RVA: 0x570F030
        public void ProcessPointerDown(){} // RVA: 0x24B10
        public void OnNavigationSubmit(){} // RVA: 0x570F0D0
        public void ShowMenu(){} // RVA: 0x570F110
        public void UpdateMixedValueContent(){} // RVA: 0x570F2C0
        public void .cctor(){} // RVA: 0x570F590
    }

    public class BasePopupField`2
    {
        public System.Collections.Generic.List`1<T> m_Choices;
        public UnityEngine.UIElements.TextElement m_TextElement;

        // ── Methods ──
        public void get_textElement(){} // RVA: 0xCD60
        public void GetValueToDisplay(){} // RVA: 0xCD60
        public void GetListItemToDisplay(){} // RVA: 0x283FA0
        public void AddMenuItems(){} // RVA: 0x24B10
        public void set_choices(){} // RVA: 0x24B10
        public void SetValueWithoutNotify(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24B10
        public void OnPointerDownEvent(){} // RVA: 0x24B10
        public void OnPointerMoveEvent(){} // RVA: 0x24B10
        public void ContainsPointer(){} // RVA: 0xE1F0
        public void ProcessPointerDown(){} // RVA: 0x24B10
        public void OnNavigationSubmit(){} // RVA: 0x24B10
        public void ShowMenu(){} // RVA: 0x24A50
        public void UpdateMixedValueContent(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class BasePopupField`2
    {
        public System.Collections.Generic.List`1<string> m_Choices; // 0x440
        public UnityEngine.UIElements.TextElement m_TextElement; // 0x448

        // ── Methods ──
        public void get_textElement(){} // RVA: 0x570CFC0
        public void GetValueToDisplay(){} // RVA: 0xCD60
        public void GetListItemToDisplay(){} // RVA: 0xCE10
        public void AddMenuItems(){} // RVA: 0x24B10
        public void set_choices(){} // RVA: 0x570CFD0
        public void SetValueWithoutNotify(){} // RVA: 0x570D0A0
        public void .ctor(){} // RVA: 0x570D150
        public void OnPointerDownEvent(){} // RVA: 0x570D920
        public void OnPointerMoveEvent(){} // RVA: 0x570D9D0
        public void ContainsPointer(){} // RVA: 0x570DAD0
        public void ProcessPointerDown(){} // RVA: 0x24B10
        public void OnNavigationSubmit(){} // RVA: 0x570DB30
        public void ShowMenu(){} // RVA: 0x570DB60
        public void UpdateMixedValueContent(){} // RVA: 0x570DC80
        public void .cctor(){} // RVA: 0x570DDF0
    }

    public class BaseReorderableDragAndDropController
    {
        public UnityEngine.UIElements.BaseVerticalCollectionView m_View; // 0x10

        // ── Methods ──
        public void GetSortedSelectedIds(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x73D78C0
        public void get_enableReordering(){} // RVA: 0x3CB9D0
        public void set_enableReordering(){} // RVA: 0x3CB9E0
        public void CanStartDrag(){} // RVA: 0x5DF5D50
        public void SetupDragAndDrop(){} // RVA: 0x73D79E0
        public void CompareId(){} // RVA: 0x3440FB0
        public void HandleDragAndDrop(){} // RVA: 0x12590
        public void OnDrop(){} // RVA: 0x24B10
        public void DragCleanup(){} // RVA: 0x2DD310
        public void HandleAutoExpand(){} // RVA: 0x2DD310
    }

    public class BaseRuntimePanel
    {
        public UnityEngine.GameObject m_SelectableGameObject; // 0x160
        public int s_CurrentRuntimePanelCounter;
        public int m_RuntimePanelCreationIndex; // 0x168
        public float m_SortingPriority; // 0x16C
        public int resolvedSortingIndex; // 0x170
        public System.Action destroyed; // 0x178
        public UnityEngine.Shader m_StandardWorldSpaceShader; // 0x180
        public bool m_DrawToCameras; // 0x188

        // ── Methods ──
        public void get_selectableGameObject(){} // RVA: 0x881BC0
        public void set_selectableGameObject(){} // RVA: 0x74130D0
        public void get_sortingPriority(){} // RVA: 0x7413270
        public void set_sortingPriority(){} // RVA: 0x7413280
        public void add_destroyed(){} // RVA: 0x7413350
        public void remove_destroyed(){} // RVA: 0x7413440
        public void .ctor(){} // RVA: 0x7413530
        public void Dispose(){} // RVA: 0x7413730
        public void get_standardWorldSpaceShader(){} // RVA: 0x7266450
        public void get_drawToCameras(){} // RVA: 0x74138D0
        public void set_drawToCameras(){} // RVA: 0x74138E0
        public void get_targetDisplay(){} // RVA: 0x74139A0
        public void set_targetDisplay(){} // RVA: 0x74139B0
        public void get_screenRenderingWidth(){} // RVA: 0x74139C0
        public void get_screenRenderingHeight(){} // RVA: 0x7413A20
        public void getScreenRenderingHeight(){} // RVA: 0x7413A80
        public void getScreenRenderingWidth(){} // RVA: 0x7413B70
        public void Repaint(){} // RVA: 0x7413C60
        public void get_screenToPanelSpace(){} // RVA: 0x8CBA20
        public void set_screenToPanelSpace(){} // RVA: 0x7414260
        public void ScreenToPanel(){} // RVA: 0x7414390 | overloaded x2
        public void AssignPanelToComponents(){} // RVA: 0x7414630
        public void PointerLeavesPanel(){} // RVA: 0x7414A10
        public void PointerEntersPanel(){} // RVA: 0x7414AE0
        public void .cctor(){} // RVA: 0x7414B80
    }

    public class BaseSlider`1
    {
        public UnityEngine.UIElements.VisualElement <dragContainer>k__BackingField;
        public UnityEngine.UIElements.VisualElement <dragElement>k__BackingField;
        public UnityEngine.UIElements.VisualElement <trackElement>k__BackingField;
        public UnityEngine.UIElements.VisualElement <dragBorderElement>k__BackingField;
        public UnityEngine.UIElements.TextField <inputTextField>k__BackingField;
        public bool m_IsEditingTextField;
        public T m_LowValue;
        public T m_HighValue;
        public float m_PageSize;
        public bool m_ShowInputField;
        public bool <clamped>k__BackingField;
        public UnityEngine.UIElements.ClampedDragger`1<T> <clampedDragger>k__BackingField;
        public UnityEngine.Rect m_DragElementStartPos;
        public 0x65830378 m_Direction;

        // ── Methods ──
        public void get_dragContainer(){} // RVA: 0xCD60
        public void set_dragContainer(){} // RVA: 0x24B10
        public void get_dragElement(){} // RVA: 0xCD60
        public void set_dragElement(){} // RVA: 0x24B10
        public void get_trackElement(){} // RVA: 0xCD60
        public void set_trackElement(){} // RVA: 0x24B10
        public void get_dragBorderElement(){} // RVA: 0xCD60
        public void set_dragBorderElement(){} // RVA: 0x24B10
        public void get_inputTextField(){} // RVA: 0xCD60
        public void set_inputTextField(){} // RVA: 0x24B10
        public void get_lowValue(){} // RVA: 0x283FA0
        public void set_lowValue(){} // RVA: 0x283FA0
        public void get_highValue(){} // RVA: 0x283FA0
        public void set_highValue(){} // RVA: 0x283FA0
        public void SetHighValueWithoutNotify(){} // RVA: 0x283FA0
        public void get_pageSize(){} // RVA: 0x21890
        public void set_pageSize(){} // RVA: 0x325B0
        public void get_showInputField(){} // RVA: 0xDBE0
        public void set_showInputField(){} // RVA: 0x25130
        public void get_clamped(){} // RVA: 0xDBE0
        public void set_clamped(){} // RVA: 0x25130
        public void get_clampedDragger(){} // RVA: 0xCD60
        public void set_clampedDragger(){} // RVA: 0x24B10
        public void Clamp(){} // RVA: 0x283FA0
        public void GetClampedValue(){} // RVA: 0x283FA0
        public void get_value(){} // RVA: 0x283FA0
        public void set_value(){} // RVA: 0x283FA0
        public void ApplyInputDeviceDelta(){} // RVA: 0x283FA0
        public void UnityEngine.UIElements.IValueField<TValueType>.StartDragging(){} // RVA: 0x24A50
        public void UnityEngine.UIElements.IValueField<TValueType>.StopDragging(){} // RVA: 0x24A50
        public void SetValueWithoutNotify(){} // RVA: 0x283FA0
        public void get_direction(){} // RVA: 0xD840
        public void set_direction(){} // RVA: 0x24FA0
        public void get_inverted(){} // RVA: 0xDBE0
        public void set_inverted(){} // RVA: 0x25130
        public void .ctor(){} // RVA: 0x283FA0
        public void GetClosestPowerOfTen(){} // RVA: 0x22A40
        public void RoundToMultipleOf(){}
        public void ClampValue(){} // RVA: 0x24A50
        public void SliderLerpUnclamped(){} // RVA: 0x283FA0
        public void SliderNormalizeValue(){} // RVA: 0x283FA0
        public void ParseStringToValue(){} // RVA: 0x283FA0
        public void ComputeValueFromKey(){} // RVA: 0x283FA0
        public void SliderLerpDirectionalUnclamped(){} // RVA: 0x283FA0
        public void SetSliderValueFromDrag(){} // RVA: 0x24A50
        public void ComputeValueAndDirectionFromDrag(){} // RVA: 0x32C70
        public void SetSliderValueFromClick(){} // RVA: 0x24A50
        public void OnKeyDown(){} // RVA: 0x24B10
        public void OnNavigationMove(){} // RVA: 0x24B10
        public void ComputeValueAndDirectionFromClick(){}
        public void AdjustDragElement(){} // RVA: 0x325B0
        public void UpdateDragElementPosition(){} // RVA: 0x24A50 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x24A50
        public void SameValues(){} // RVA: 0x283FA0
        public void ExecuteDefaultAction(){} // RVA: 0x24B10
        public void UpdateTextFieldVisibility(){} // RVA: 0x24A50
        public void UpdateTextFieldValue(){} // RVA: 0x24A50
        public void OnTextFieldFocusIn(){} // RVA: 0x24B10
        public void OnTextFieldFocusOut(){} // RVA: 0x24B10
        public void OnInputNavigationMoveEvent(){} // RVA: 0x24B10
        public void OnTextFieldValueChange(){} // RVA: 0x24B10
        public void UpdateMixedValueContent(){} // RVA: 0x24A50
        public void RegisterEditingCallbacks(){} // RVA: 0x24A50
        public void UnregisterEditingCallbacks(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class BaseSlider`1
    {
        public UnityEngine.UIElements.VisualElement <dragContainer>k__BackingField; // 0x440
        public UnityEngine.UIElements.VisualElement <dragElement>k__BackingField; // 0x448
        public UnityEngine.UIElements.VisualElement <trackElement>k__BackingField; // 0x450
        public UnityEngine.UIElements.VisualElement <dragBorderElement>k__BackingField; // 0x458
        public UnityEngine.UIElements.TextField <inputTextField>k__BackingField; // 0x460
        public bool m_IsEditingTextField; // 0x468
        public float m_LowValue; // 0x46C
        public float m_HighValue; // 0x470
        public float m_PageSize; // 0x474
        public bool m_ShowInputField; // 0x478
        public bool <clamped>k__BackingField; // 0x479
        public UnityEngine.UIElements.ClampedDragger`1<float> <clampedDragger>k__BackingField; // 0x480
        public UnityEngine.Rect m_DragElementStartPos; // 0x488
        public 0x65830378 m_Direction; // 0x498

        // ── Methods ──
        public void get_dragContainer(){} // RVA: 0xD8EF30
        public void set_dragContainer(){} // RVA: 0xD95C40
        public void get_dragElement(){} // RVA: 0xD9A100
        public void set_dragElement(){} // RVA: 0xDA31D0
        public void get_trackElement(){} // RVA: 0xD961C0
        public void set_trackElement(){} // RVA: 0xD8C530
        public void get_dragBorderElement(){} // RVA: 0xDA8310
        public void set_dragBorderElement(){} // RVA: 0xD973F0
        public void get_inputTextField(){} // RVA: 0xD9D690
        public void set_inputTextField(){} // RVA: 0xD9FCF0
        public void get_lowValue(){} // RVA: 0x5713AA0
        public void set_lowValue(){} // RVA: 0x5713AB0
        public void get_highValue(){} // RVA: 0x5713B70
        public void set_highValue(){} // RVA: 0x5713B80
        public void SetHighValueWithoutNotify(){} // RVA: 0x5713C40
        public void get_pageSize(){} // RVA: 0x570FD60
        public void set_pageSize(){} // RVA: 0x570FD70
        public void get_showInputField(){} // RVA: 0x570FD80
        public void set_showInputField(){} // RVA: 0x5713CD0
        public void get_clamped(){} // RVA: 0x570FDC0
        public void set_clamped(){} // RVA: 0x570FDD0
        public void get_clampedDragger(){} // RVA: 0xDA1590
        public void set_clampedDragger(){} // RVA: 0xDA58C0
        public void Clamp(){} // RVA: 0x5713D00
        public void GetClampedValue(){} // RVA: 0x5713D60
        public void get_value(){} // RVA: 0x43E4EA0
        public void set_value(){} // RVA: 0x5713E00
        public void ApplyInputDeviceDelta(){} // RVA: 0x2DD310
        public void UnityEngine.UIElements.IValueField<TValueType>.StartDragging(){} // RVA: 0x2DD310
        public void UnityEngine.UIElements.IValueField<TValueType>.StopDragging(){} // RVA: 0x2DD310
        public void SetValueWithoutNotify(){} // RVA: 0x5713E40
        public void get_direction(){} // RVA: 0x570FF50
        public void set_direction(){} // RVA: 0x570FF60
        public void get_inverted(){} // RVA: 0x57100C0
        public void set_inverted(){} // RVA: 0x5713EB0
        public void .ctor(){} // RVA: 0x5713EE0
        public void GetClosestPowerOfTen(){} // RVA: 0x5710D80
        public void RoundToMultipleOf(){} // RVA: 0x5710DC0
        public void ClampValue(){} // RVA: 0x5714A50
        public void SliderLerpUnclamped(){}
        public void SliderNormalizeValue(){}
        public void ParseStringToValue(){} // RVA: 0x22300
        public void ComputeValueFromKey(){} // RVA: 0x283FA0
        public void SliderLerpDirectionalUnclamped(){} // RVA: 0x5714A80
        public void SetSliderValueFromDrag(){} // RVA: 0x5714AD0
        public void ComputeValueAndDirectionFromDrag(){} // RVA: 0x5714C10
        public void SetSliderValueFromClick(){} // RVA: 0x5714CE0
        public void OnKeyDown(){} // RVA: 0x5715260
        public void OnNavigationMove(){} // RVA: 0x57153D0
        public void ComputeValueAndDirectionFromClick(){} // RVA: 0x5715490
        public void AdjustDragElement(){} // RVA: 0x5715660
        public void UpdateDragElementPosition(){} // RVA: 0x5715B00 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x5715AA0
        public void SameValues(){} // RVA: 0x5711EA0
        public void ExecuteDefaultAction(){} // RVA: 0x5715E80
        public void UpdateTextFieldVisibility(){} // RVA: 0x5716010
        public void UpdateTextFieldValue(){} // RVA: 0x5716510
        public void OnTextFieldFocusIn(){} // RVA: 0x5712A20
        public void OnTextFieldFocusOut(){} // RVA: 0x5716660
        public void OnInputNavigationMoveEvent(){} // RVA: 0x43A9DB0
        public void OnTextFieldValueChange(){} // RVA: 0x5716680
        public void UpdateMixedValueContent(){} // RVA: 0x5712BC0
        public void RegisterEditingCallbacks(){} // RVA: 0x57167C0
        public void UnregisterEditingCallbacks(){} // RVA: 0x5716950
        public void .cctor(){} // RVA: 0x5716AD0
    }

    public class BaseSlider`1
    {
        public UnityEngine.UIElements.VisualElement <dragContainer>k__BackingField; // 0x440
        public UnityEngine.UIElements.VisualElement <dragElement>k__BackingField; // 0x448
        public UnityEngine.UIElements.VisualElement <trackElement>k__BackingField; // 0x450
        public UnityEngine.UIElements.VisualElement <dragBorderElement>k__BackingField; // 0x458
        public UnityEngine.UIElements.TextField <inputTextField>k__BackingField; // 0x460
        public bool m_IsEditingTextField; // 0x468
        public int m_LowValue; // 0x46C
        public int m_HighValue; // 0x470
        public float m_PageSize; // 0x474
        public bool m_ShowInputField; // 0x478
        public bool <clamped>k__BackingField; // 0x479
        public UnityEngine.UIElements.ClampedDragger`1<int> <clampedDragger>k__BackingField; // 0x480
        public UnityEngine.Rect m_DragElementStartPos; // 0x488
        public 0x65830378 m_Direction; // 0x498

        // ── Methods ──
        public void get_dragContainer(){} // RVA: 0xD8EF30
        public void set_dragContainer(){} // RVA: 0xD95C40
        public void get_dragElement(){} // RVA: 0xD9A100
        public void set_dragElement(){} // RVA: 0xDA31D0
        public void get_trackElement(){} // RVA: 0xD961C0
        public void set_trackElement(){} // RVA: 0xD8C530
        public void get_dragBorderElement(){} // RVA: 0xDA8310
        public void set_dragBorderElement(){} // RVA: 0xD973F0
        public void get_inputTextField(){} // RVA: 0xD9D690
        public void set_inputTextField(){} // RVA: 0xD9FCF0
        public void get_lowValue(){} // RVA: 0x570FB20
        public void set_lowValue(){} // RVA: 0x570FB30
        public void get_highValue(){} // RVA: 0x570FBE0
        public void set_highValue(){} // RVA: 0x570FBF0
        public void SetHighValueWithoutNotify(){} // RVA: 0x570FCA0
        public void get_pageSize(){} // RVA: 0x570FD60
        public void set_pageSize(){} // RVA: 0x570FD70
        public void get_showInputField(){} // RVA: 0x570FD80
        public void set_showInputField(){} // RVA: 0x570FD90
        public void get_clamped(){} // RVA: 0x570FDC0
        public void set_clamped(){} // RVA: 0x570FDD0
        public void get_clampedDragger(){} // RVA: 0xDA1590
        public void set_clampedDragger(){} // RVA: 0xDA58C0
        public void Clamp(){} // RVA: 0x570FDE0
        public void GetClampedValue(){} // RVA: 0x570FE00
        public void get_value(){} // RVA: 0x43E30C0
        public void set_value(){} // RVA: 0x570FE40
        public void ApplyInputDeviceDelta(){} // RVA: 0x2DD310
        public void UnityEngine.UIElements.IValueField<TValueType>.StartDragging(){} // RVA: 0x2DD310
        public void UnityEngine.UIElements.IValueField<TValueType>.StopDragging(){} // RVA: 0x2DD310
        public void SetValueWithoutNotify(){} // RVA: 0x570FEB0
        public void get_direction(){} // RVA: 0x570FF50
        public void set_direction(){} // RVA: 0x570FF60
        public void get_inverted(){} // RVA: 0x57100C0
        public void set_inverted(){} // RVA: 0x57100D0
        public void .ctor(){} // RVA: 0x5710100
        public void GetClosestPowerOfTen(){} // RVA: 0x5710D80
        public void RoundToMultipleOf(){} // RVA: 0x5710DC0
        public void ClampValue(){} // RVA: 0x5710DF0
        public void SliderLerpUnclamped(){}
        public void SliderNormalizeValue(){}
        public void ParseStringToValue(){} // RVA: 0x17680
        public void ComputeValueFromKey(){} // RVA: 0x283FA0
        public void SliderLerpDirectionalUnclamped(){} // RVA: 0x5710E20
        public void SetSliderValueFromDrag(){} // RVA: 0x5710E70
        public void ComputeValueAndDirectionFromDrag(){} // RVA: 0x5710FB0
        public void SetSliderValueFromClick(){} // RVA: 0x5711070
        public void OnKeyDown(){} // RVA: 0x57115F0
        public void OnNavigationMove(){} // RVA: 0x5711760
        public void ComputeValueAndDirectionFromClick(){} // RVA: 0x5711820
        public void AdjustDragElement(){} // RVA: 0x5711A00
        public void UpdateDragElementPosition(){} // RVA: 0x5711EC0 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x5711E40
        public void SameValues(){} // RVA: 0x5711EA0
        public void ExecuteDefaultAction(){} // RVA: 0x5712240
        public void UpdateTextFieldVisibility(){} // RVA: 0x57123D0
        public void UpdateTextFieldValue(){} // RVA: 0x57128D0
        public void OnTextFieldFocusIn(){} // RVA: 0x5712A20
        public void OnTextFieldFocusOut(){} // RVA: 0x5712A30
        public void OnInputNavigationMoveEvent(){} // RVA: 0x43A9DB0
        public void OnTextFieldValueChange(){} // RVA: 0x5712A50
        public void UpdateMixedValueContent(){} // RVA: 0x5712BC0
        public void RegisterEditingCallbacks(){} // RVA: 0x5712C20
        public void UnregisterEditingCallbacks(){} // RVA: 0x5712DB0
        public void .cctor(){} // RVA: 0x5712F30
    }

    public class BaseTreeView
    {
        public string ussClassName;
        public string itemUssClassName; // 0x8
        public string itemToggleUssClassName; // 0x10
        public string itemIndentsContainerUssClassName; // 0x18

        // ── Methods ──
        public void get_itemsSource(){} // RVA: 0x72FD360
        public void get_viewController(){} // RVA: 0x72FD3A0
        public void CreateVirtualizationController(){} // RVA: 0x72FD430
        public void SetViewController(){} // RVA: 0x72FD470
        public void OnItemIndexChanged(){} // RVA: 0x72FD590
        public void CreateDragAndDropController(){} // RVA: 0x72FD5A0
        public void get_autoExpand(){} // RVA: 0x72F8D90
        public void set_autoExpand(){} // RVA: 0x72FD770
        public void get_expandedItemIds(){} // RVA: 0xD89FB0
        public void set_expandedItemIds(){} // RVA: 0xD8D4D0
        public void .ctor(){} // RVA: 0x72FD7C0 | overloaded x2
        public void OnViewDataReady(){} // RVA: 0x72FD9E0
        public void HandleItemNavigation(){} // RVA: 0x72FDA60
        public void SetSelectionById(){} // RVA: 0x72FE1E0 | overloaded x2
        public void SetSelectionInternalById(){} // RVA: 0x72FE330
        public void GetItemIndex(){} // RVA: 0x72FE490
        public void IsExpanded(){} // RVA: 0x72FE670
        public void CollapseItem(){} // RVA: 0x72FE6A0
        public void ExpandItem(){} // RVA: 0x72FE700
        public void OnTreeViewPointerUp(){} // RVA: 0x72FE750
        public void IsExpandedByIndex(){} // RVA: 0x72FE7A0
        public void CollapseItemByIndex(){} // RVA: 0x72FE7D0
        public void ExpandItemByIndex(){} // RVA: 0x72FE850
        public void .cctor(){} // RVA: 0x72FE8E0
        public void <SetSelectionInternalById>b__47_0(){} // RVA: 0x72FECC0
    }

    public class BaseTreeViewController
    {
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.UIElements.TreeItem> m_TreeItems; // 0x30
        public System.Collections.Generic.List`1<int> m_RootIndices; // 0x38

        // ── Methods ──
        public void get_baseTreeView(){} // RVA: 0x72EE760
        public void get_itemsSource(){} // RVA: 0x2E07C0
        public void set_itemsSource(){} // RVA: 0x72EE7F0
        public void RebuildTree(){} // RVA: 0x72EE840
        public void GetRootItemIds(){} // RVA: 0x7187DC0
        public void GetAllItemIds(){} // RVA: 0xCE10
        public void GetParentId(){} // RVA: 0x13FB0
        public void GetChildrenIds(){} // RVA: 0x1BCC0
        public void Move(){}
        public void InvokeMakeItem(){} // RVA: 0x72EEBE0
        public void InvokeBindItem(){} // RVA: 0x72EECB0
        public void InvokeDestroyItem(){} // RVA: 0x72EEDD0
        public void PostInitRegistration(){} // RVA: 0x72EF100
        public void OnItemPointerUp(){} // RVA: 0x72EF580
        public void OnToggleValueChanged(){} // RVA: 0x72EFBD0
        public void GetIndexForId(){} // RVA: 0x72EFDB0
        public void GetIdForIndex(){} // RVA: 0x72EFE90
        public void HasChildren(){} // RVA: 0x72EFF40
        public void Exists(){} // RVA: 0x72EFFF0
        public void HasChildrenByIndex(){} // RVA: 0x72F0060
        public void GetChildrenIdsByIndex(){} // RVA: 0x72F0160
        public void GetChildIndexForId(){} // RVA: 0x72F0210
        public void GetIndentationDepth(){} // RVA: 0x72F03E0
        public void GetIndentationDepthByIndex(){} // RVA: 0x72F0440
        public void CanChangeExpandedState(){} // RVA: 0x20D68C0
        public void IsExpanded(){} // RVA: 0x72F04B0
        public void IsExpandedByIndex(){} // RVA: 0x72F0570
        public void ExpandItemByIndex(){} // RVA: 0x72F0630
        public void ExpandItem(){} // RVA: 0x72F0EA0
        public void CollapseItemByIndex(){} // RVA: 0x72F1080
        public void CollapseItem(){} // RVA: 0x72F1590
        public void RegenerateWrappers(){} // RVA: 0x72F1720
        public void CreateWrappers(){} // RVA: 0x72F1870
        public void IsIndexValid(){} // RVA: 0x72F1DB0
        public void RaiseItemParentChanged(){} // RVA: 0x72F1E20
        public void .ctor(){} // RVA: 0x72F1E40
        public void .cctor(){} // RVA: 0x72F21B0
    }

    public class BaseUxmlFactory`2
    {
        public T m_Traits;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void get_uxmlName(){} // RVA: 0xCD60
        public void get_uxmlNamespace(){} // RVA: 0xCD60
        public void get_uxmlQualifiedName(){} // RVA: 0xCD60
        public void get_uxmlType(){} // RVA: 0xCD60
        public void AcceptsAttributeBag(){}
    }

    public class BaseUxmlFactory`2
    {
        public T m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571F150
        public void get_uxmlNamespace(){} // RVA: 0x571F220
        public void get_uxmlQualifiedName(){} // RVA: 0x571F310
        public void get_uxmlType(){} // RVA: 0x571F3E0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571F150
        public void get_uxmlNamespace(){} // RVA: 0x571F220
        public void get_uxmlQualifiedName(){} // RVA: 0x571F310
        public void get_uxmlType(){} // RVA: 0x571F3E0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public T m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571F150
        public void get_uxmlNamespace(){} // RVA: 0x571F220
        public void get_uxmlQualifiedName(){} // RVA: 0x571F310
        public void get_uxmlType(){} // RVA: 0x571F3E0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlObjectTraits`1<T> m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571F150
        public void get_uxmlNamespace(){} // RVA: 0x571F220
        public void get_uxmlQualifiedName(){} // RVA: 0x571F310
        public void get_uxmlType(){} // RVA: 0x571F3E0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlObjectTraits`1<T> m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571F150
        public void get_uxmlNamespace(){} // RVA: 0x571F220
        public void get_uxmlQualifiedName(){} // RVA: 0x571F310
        public void get_uxmlType(){} // RVA: 0x571F3E0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlObjectTraits`1<T> m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571F150
        public void get_uxmlNamespace(){} // RVA: 0x571F220
        public void get_uxmlQualifiedName(){} // RVA: 0x571F310
        public void get_uxmlType(){} // RVA: 0x571F3E0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlObjectTraits`1<T> m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571F150
        public void get_uxmlNamespace(){} // RVA: 0x571F220
        public void get_uxmlQualifiedName(){} // RVA: 0x571F310
        public void get_uxmlType(){} // RVA: 0x571F3E0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

    public class BaseUxmlFactory`2
    {
        public UxmlTraits m_Traits; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x571EDA0
        public void get_uxmlName(){} // RVA: 0x571EE10
        public void get_uxmlNamespace(){} // RVA: 0x571EEE0
        public void get_uxmlQualifiedName(){} // RVA: 0x571EFD0
        public void get_uxmlType(){} // RVA: 0x571F0A0
        public void AcceptsAttributeBag(){} // RVA: 0x20D68C0
    }

}