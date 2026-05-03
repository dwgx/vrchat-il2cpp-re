// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 42
// Methods: 431

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class TemplateAsset : VisualElementAsset
    {
        public string m_TemplateAlias; // 0x70
        public System.Collections.Generic.List`1<AttributeOverride> m_AttributeOverrides; // 0x78

        // ── Methods ──
        public void get_attributeOverrides(){} // RVA: 0x7FFE87FCF6D0
        public void get_slotUsages(){} // RVA: 0x7FFE87CC8480
    }

    public class TemplateContainer : BindableElement
    {
        public string _templateId; // 0x3D8
        public UnityEngine.UIElements.VisualElement m_ContentContainer; // 0x3E0
        public UnityEngine.UIElements.VisualTreeAsset m_TemplateSource; // 0x3E8

        // ── Methods ──
        public void get_templateId(){} // RVA: 0x7FFE81B0E4A0
        public void set_templateId(){} // RVA: 0x7FFE81B2FC80
        public void set_templateSource(){} // RVA: 0x7FFE81B26900
        public void .ctor(){} // RVA: 0x7FFE87FB72F0 | overloaded x2
        public void get_contentContainer(){} // RVA: 0x7FFE87FB7400
        public void SetContentContainer(){} // RVA: 0x7FFE81B30C40
    }

    public class TextEditingManipulator : Object
    {
        public UnityEngine.UIElements.TextElement m_TextElement; // 0x10

        // ── Methods ──
        public void get_touchScreenTextFieldChanged(){} // RVA: 0x7FFE87FB8750
        public void .ctor(){} // RVA: 0x7FFE87FB87E0
        public void InitTextEditorEventHandler(){} // RVA: 0x7FFE87FB8A90
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFE87FB8D80
        public void OnFocusInEvent(){} // RVA: 0x7FFE87FB8F80
        public void OnFocusOutEvent(){} // RVA: 0x7FFE87FB9150
        public void <OnFocusInEvent>b__10_0(){} // RVA: 0x7FFE87FB9220
    }

    public class TextEditorEventHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFE810FB310
    }

    public class TextElement : BindableElement
    {
        public string ussClassName;
        public UnityEngine.UIElements.UITKTextHandle _uitkTextHandle; // 0x3D8
        public string m_Text; // 0x3E0
        public bool m_EnableRichText; // 0x3E8
        public bool m_ParseEscapeSequences; // 0x3E9
        public bool m_DisplayTooltipWhenElided; // 0x3EA
        public bool _isElided; // 0x3EB
        public string k_EllipsisText; // 0x8
        public string elidedText; // 0x3F0
        public bool m_WasElided; // 0x3F8
        public UnityEngine.UIElements.TextEditingManipulator editingManipulator; // 0x400
        public bool m_Multiline; // 0x408
        public UnityEngine.TouchScreenKeyboard m_TouchScreenKeyboard; // 0x410
        public 0x66579C9C m_KeyboardType; // 0x418
        public bool m_HideMobileInput; // 0x41C
        public bool m_IsReadOnly; // 0x41D
        public int m_MaxLength; // 0x420
        public bool _isDelayed; // 0x424
        public System.Func`2<char,bool> _acceptCharacter; // 0x428
        public System.Action`1<bool> _updateScrollOffset; // 0x430
        public System.Action _updateValueFromText; // 0x438
        public System.Action _updateTextFromValue; // 0x440
        public System.Action _moveFocusToCompositeRoot; // 0x448
        public string m_RenderedText; // 0x450
        public string m_OriginalText; // 0x458
        public char m_MaskChar; // 0x460
        public bool m_IsPassword; // 0x462
        public bool m_AutoCorrection; // 0x463
        public UnityEngine.UIElements.TextSelectingManipulator m_SelectingManipulator; // 0x468
        public bool m_IsSelectable; // 0x470
        public bool _doubleClickSelectsWord; // 0x471
        public bool _tripleClickSelectsLine; // 0x472
        public bool _selectAllOnFocus; // 0x473
        public bool _selectAllOnMouseUp; // 0x474
        public UnityEngine.Color m_SelectionColor; // 0x478
        public UnityEngine.Color m_CursorColor; // 0x488
        public float m_CursorWidth; // 0x498
        public object field_37; // 0x517
        public object field_38; // 0x518
        public object field_39; // 0x519

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FBF080
        public void get_uitkTextHandle(){} // RVA: 0x7FFE81B0E4A0
        public void set_uitkTextHandle(){} // RVA: 0x7FFE81B2FC80
        public void OnGeometryChanged(){} // RVA: 0x7FFE87FBF430
        public void get_text(){} // RVA: 0x7FFE87FBF440
        public void set_text(){} // RVA: 0x7FFE87FBF480
        public void get_enableRichText(){} // RVA: 0x7FFE87E59430
        public void set_enableRichText(){} // RVA: 0x7FFE87FBF4E0
        public void get_parseEscapeSequences(){} // RVA: 0x7FFE87FBF530
        public void set_parseEscapeSequences(){} // RVA: 0x7FFE87FBF540
        public void get_displayTooltipWhenElided(){} // RVA: 0x7FFE87FBF590
        public void set_displayTooltipWhenElided(){} // RVA: 0x7FFE87FBF5A0
        public void get_isElided(){} // RVA: 0x7FFE87FBF5F0
        public void set_isElided(){} // RVA: 0x7FFE87FBF600
        public void OnGenerateVisualContent(){} // RVA: 0x7FFE87FBF610
        public void ElideText(){} // RVA: 0x7FFE87FBF930
        public void UpdateTooltip(){} // RVA: 0x7FFE87FBFDB0
        public void UpdateVisibleText(){} // RVA: 0x7FFE87FBFE20
        public void ShouldElide(){} // RVA: 0x7FFE87FC0050
        public void get_hasFocus(){} // RVA: 0x7FFE87FC00E0
        public void MeasureTextSize(){} // RVA: 0x7FFE87FC0160
        public void DoMeasure(){} // RVA: 0x7FFE87FC0190
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value(){} // RVA: 0x7FFE87FC0200
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(){} // RVA: 0x7FFE87FC0250
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(){} // RVA: 0x7FFE87FC0420
        public void get_edition(){} // RVA: 0x7FFE827C4A80
        public void UnityEngine.UIElements.ITextEdition.get_multiline(){} // RVA: 0x7FFE860751D0
        public void UnityEngine.UIElements.ITextEdition.set_multiline(){} // RVA: 0x7FFE87FC0610
        public void UnityEngine.UIElements.ITextEdition.get_keyboardType(){} // RVA: 0x7FFE87FC06A0
        public void UnityEngine.UIElements.ITextEdition.set_keyboardType(){} // RVA: 0x7FFE87FC06B0
        public void UnityEngine.UIElements.ITextEdition.get_hideMobileInput(){} // RVA: 0x7FFE87FC06C0
        public void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(){} // RVA: 0x7FFE87FC0760
        public void UnityEngine.UIElements.ITextEdition.get_isReadOnly(){} // RVA: 0x7FFE87FC0820
        public void UnityEngine.UIElements.ITextEdition.set_isReadOnly(){} // RVA: 0x7FFE87FC0840
        public void ProcessMenuCommand(){} // RVA: 0x7FFE87FC0920
        public void Cut(){} // RVA: 0x7FFE87FC0AF0
        public void Copy(){} // RVA: 0x7FFE87FC0B40
        public void Paste(){} // RVA: 0x7FFE87FC0B90
        public void BuildContextualMenu(){} // RVA: 0x7FFE87FC0BE0
        public void CutActionStatus(){} // RVA: 0x7FFE87FC0F50
        public void CopyActionStatus(){} // RVA: 0x7FFE87FC0FE0
        public void PasteActionStatus(){} // RVA: 0x7FFE87FC1070
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFE87FC10D0
        public void UnityEngine.UIElements.ITextEdition.get_maxLength(){} // RVA: 0x7FFE87FC13A0
        public void UnityEngine.UIElements.ITextEdition.set_maxLength(){} // RVA: 0x7FFE87FC13B0
        public void UnityEngine.UIElements.ITextEdition.get_isDelayed(){} // RVA: 0x7FFE87FC1440
        public void UnityEngine.UIElements.ITextEdition.set_isDelayed(){} // RVA: 0x7FFE87FC1450
        public void UnityEngine.UIElements.ITextEdition.SaveValueAndText(){} // RVA: 0x7FFE87FC1460
        public void UnityEngine.UIElements.ITextEdition.RestoreValueAndText(){} // RVA: 0x7FFE87FC14E0
        public void UnityEngine.UIElements.ITextEdition.get_AcceptCharacter(){} // RVA: 0x7FFE81B2E4C0
        public void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(){} // RVA: 0x7FFE81B150C0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset(){} // RVA: 0x7FFE81B373B0
        public void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(){} // RVA: 0x7FFE81B327A0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText(){} // RVA: 0x7FFE81B2BE60
        public void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(){} // RVA: 0x7FFE81B085E0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue(){} // RVA: 0x7FFE81B373C0
        public void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(){} // RVA: 0x7FFE81B2F130
        public void UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot(){} // RVA: 0x7FFE81B10FA0
        public void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(){} // RVA: 0x7FFE81B23CA0
        public void UnityEngine.UIElements.ITextEdition.UpdateText(){} // RVA: 0x7FFE87FC1500
        public void UnityEngine.UIElements.ITextEdition.CullString(){} // RVA: 0x7FFE87FC18B0
        public void UnityEngine.UIElements.ITextEdition.set_maskChar(){} // RVA: 0x7FFE87FC1930
        public void get_effectiveMaskChar(){} // RVA: 0x7FFE87FC19C0
        public void UnityEngine.UIElements.ITextEdition.get_isPassword(){} // RVA: 0x7FFE87FC1A30
        public void UnityEngine.UIElements.ITextEdition.set_isPassword(){} // RVA: 0x7FFE87FC1A40
        public void UnityEngine.UIElements.ITextEdition.get_autoCorrection(){} // RVA: 0x7FFE87FC1A90
        public void UnityEngine.UIElements.ITextEdition.set_autoCorrection(){} // RVA: 0x7FFE87FC1AA0
        public void get_renderedText(){} // RVA: 0x7FFE87FC1AB0
        public void set_renderedText(){} // RVA: 0x7FFE87FC1C10
        public void get_originalText(){} // RVA: 0x7FFE81B339E0
        public void get_selection(){} // RVA: 0x7FFE827C4A80
        public void UnityEngine.UIElements.ITextSelection.get_isSelectable(){} // RVA: 0x7FFE87FC1CB0
        public void UnityEngine.UIElements.ITextSelection.set_isSelectable(){} // RVA: 0x7FFE87FC1CD0
        public void UnityEngine.UIElements.ITextSelection.get_cursorIndex(){} // RVA: 0x7FFE87FC1CF0
        public void UnityEngine.UIElements.ITextSelection.set_cursorIndex(){} // RVA: 0x7FFE87FC1D70
        public void UnityEngine.UIElements.ITextSelection.get_selectIndex(){} // RVA: 0x7FFE87FC1E10
        public void UnityEngine.UIElements.ITextSelection.set_selectIndex(){} // RVA: 0x7FFE87FC1E90
        public void UnityEngine.UIElements.ITextSelection.SelectAll(){} // RVA: 0x7FFE87FC1F30
        public void UnityEngine.UIElements.ITextSelection.SelectNone(){} // RVA: 0x7FFE87FC1FB0
        public void UnityEngine.UIElements.ITextSelection.HasSelection(){} // RVA: 0x7FFE87FC2050
        public void UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord(){} // RVA: 0x7FFE87FC2100
        public void UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine(){} // RVA: 0x7FFE87FC2110
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus(){} // RVA: 0x7FFE87FC2120
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(){} // RVA: 0x7FFE87FC2130
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp(){} // RVA: 0x7FFE87FC2140
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(){} // RVA: 0x7FFE87FC2150
        public void UnityEngine.UIElements.ITextSelection.get_cursorPosition(){} // RVA: 0x7FFE87FC2160
        public void UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition(){} // RVA: 0x7FFE87FC2210
        public void UnityEngine.UIElements.ITextSelection.get_selectionColor(){} // RVA: 0x7FFE87FC22F0
        public void UnityEngine.UIElements.ITextSelection.set_selectionColor(){} // RVA: 0x7FFE87FC2300
        public void UnityEngine.UIElements.ITextSelection.get_cursorColor(){} // RVA: 0x7FFE87FC23B0
        public void UnityEngine.UIElements.ITextSelection.set_cursorColor(){} // RVA: 0x7FFE87FC23C0
        public void UnityEngine.UIElements.ITextSelection.get_cursorWidth(){} // RVA: 0x7FFE87FC2470
        public void get_selectingManipulator(){} // RVA: 0x7FFE87FC2480
        public void DrawHighlighting(){} // RVA: 0x7FFE87FC2540
        public void DrawCaret(){} // RVA: 0x7FFE87FC2DF0
        public void GetLastCharacterAt(){} // RVA: 0x7FFE87FC3280
        public void .cctor(){} // RVA: 0x7FFE87FC34E0
    }

    public class TextField : TextInputBaseField`1
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void get_textInput(){} // RVA: 0x7FFE87EE3340
        public void set_multiline(){} // RVA: 0x7FFE87EE33D0
        public void .ctor(){} // RVA: 0x7FFE87EE3460 | overloaded x3
        public void get_value(){} // RVA: 0x7FFE87EE3700
        public void set_value(){} // RVA: 0x7FFE87EE3750
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87EE3810
        public void UpdateTextFromValue(){} // RVA: 0x7FFE87EE38D0
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE87EE3920
        public void OnViewDataReady(){} // RVA: 0x7FFE87EE3B00
        public void ValueToString(){} // RVA: 0x7FFE82153650
        public void StringToValue(){} // RVA: 0x7FFE82153650
        public void .cctor(){} // RVA: 0x7FFE87EE3BB0
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<T> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0x7FFE85013C00
        public void get_text(){} // RVA: 0x7FFE85013C40
        public void set_text(){} // RVA: 0x7FFE85013CB0
        public void add_onIsReadOnlyChanged(){} // RVA: 0x7FFE85013D10
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x7FFE85013E80
        public void get_isReadOnly(){} // RVA: 0x7FFE85013FF0
        public void set_isReadOnly(){} // RVA: 0x7FFE85014080
        public void set_isPasswordField(){} // RVA: 0x7FFE85014160
        public void set_autoCorrection(){} // RVA: 0x7FFE850142A0
        public void set_hideMobileInput(){} // RVA: 0x7FFE85014340
        public void set_keyboardType(){} // RVA: 0x7FFE850143E0
        public void get_textEdition(){} // RVA: 0x7FFE85014470
        public void set_maxLength(){} // RVA: 0x7FFE850144F0
        public void get_isDelayed(){} // RVA: 0x7FFE85014580
        public void set_isDelayed(){} // RVA: 0x7FFE85014610
        public void set_maskChar(){} // RVA: 0x7FFE850146B0
        public void ValueToString(){} // RVA: 0x7FFE810A1420
        public void StringToValue(){} // RVA: 0x7FFE81081080
        public void .ctor(){} // RVA: 0x7FFE85014750
        public void OnFieldCustomStyleResolved(){} // RVA: 0x7FFE85014B70
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFE85014BE0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE85015220
        public void UpdateValueFromText(){} // RVA: 0x7FFE85015580
        public void UpdateTextFromValue(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE85015690
    }

    public class TextSelectingManipulator : Object
    {
        public UnityEngine.TextSelectingUtilities m_SelectingUtilities; // 0x10
        public bool selectAllOnMouseUp; // 0x18
        public UnityEngine.UIElements.TextElement m_TextElement; // 0x20

        // ── Methods ──
        public void get_isClicking(){} // RVA: 0x7FFE81121470
        public void set_isClicking(){} // RVA: 0x7FFE87FB9270
        public void .ctor(){} // RVA: 0x7FFE87FB9280
        public void get_cursorIndex(){} // RVA: 0x7FFE87FB97B0
        public void set_cursorIndex(){} // RVA: 0x7FFE87CD9210
        public void get_selectIndex(){} // RVA: 0x7FFE87FB97D0
        public void set_selectIndex(){} // RVA: 0x7FFE87CD9280
        public void OnRevealCursor(){} // RVA: 0x7FFE87FB97F0
        public void OnSelectIndexChange(){} // RVA: 0x7FFE87FB9840
        public void OnCursorIndexChange(){} // RVA: 0x7FFE87FB9980
        public void RevealCursor(){} // RVA: 0x7FFE87FB9AC0
        public void HasSelection(){} // RVA: 0x7FFE87FB9AE0
        public void HasFocus(){} // RVA: 0x7FFE87FB9B30
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFE87FB9B50
        public void OnFocusEvent(){} // RVA: 0x7FFE87FB9F80
        public void OnBlurEvent(){} // RVA: 0x7FFE87FBA130
        public void OnKeyDown(){} // RVA: 0x7FFE87FBA190
        public void OnPointerDownEvent(){} // RVA: 0x7FFE87FBA200
        public void OnPointerMoveEvent(){} // RVA: 0x7FFE87FBA5D0
        public void OnPointerUpEvent(){} // RVA: 0x7FFE87FBA790
        public void OnValidateCommandEvent(){} // RVA: 0x7FFE87FBA880
        public void OnExecuteCommandEvent(){} // RVA: 0x7FFE87FBAAC0
        public void MoveDistanceQualifiesForDrag(){} // RVA: 0x7FFE87FBAC70
    }

    public class TextShadow : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87FC4250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FC4320
        public void op_Equality(){} // RVA: 0x7FFE87FC43A0
        public void op_Inequality(){} // RVA: 0x7FFE87FC43D0
        public void ToString(){} // RVA: 0x7FFE87FC4490
        public void LerpUnclamped(){} // RVA: 0x7FFE87FC45D0
    }

    public class TextUtilities : Object
    {
        // ── Methods ──
        public void MeasureVisualElementTextSize(){} // RVA: 0x7FFE87FBE030
        public void GetFontAsset(){} // RVA: 0x7FFE87FBE430
        public void IsFontAssigned(){} // RVA: 0x7FFE87FBE7E0
        public void GetTextSettingsFrom(){} // RVA: 0x7FFE87FBE940
        public void ConvertPixelUnitsToTextCoreRelativeUnits(){} // RVA: 0x7FFE87FBEA10
        public void GetTextCoreSettingsForElement(){} // RVA: 0x7FFE87FBEAD0
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger;
        public bool m_UpdateTextFromValue;
        public bool m_ForceUpdateDisplay;

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x7FFE80E2E2E0
        public void get_formatString(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E4DDD0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE810A1420
        public void StartDragging(){} // RVA: 0x7FFE80E45FE0
        public void StopDragging(){} // RVA: 0x7FFE80E45FE0
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void set_value(){} // RVA: 0x7FFE810A1420
        public void UpdateValueFromText(){} // RVA: 0x7FFE80E45FE0
        public void UpdateTextFromValue(){} // RVA: 0x7FFE80E45FE0
        public void OnIsReadOnlyChanged(){} // RVA: 0x7FFE80E466C0
        public void CanTryParse(){} // RVA: 0x7FFE80E2F3B0
        public void AddLabelDragger(){} // RVA: 0x7FFE80E45FE0
        public void EnableLabelDragger(){} // RVA: 0x7FFE80E466C0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE810A1420
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE80E460A0
        public void OnViewDataReady(){} // RVA: 0x7FFE80E45FE0
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFE80E45FE0
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFE80E45FE0
    }

    public class TextureId : ValueType
    {
        public int m_Index; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F78C00
        public void get_index(){} // RVA: 0x7FFE87F78C10
        public void ConvertToGpu(){} // RVA: 0x7FFE87F78C20
        public void Equals(){} // RVA: 0x7FFE87F78C70
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
        public void op_Equality(){} // RVA: 0x7FFE87C606D0
        public void op_Inequality(){} // RVA: 0x7FFE87F78D10
        public void .cctor(){} // RVA: 0x7FFE87F78D70
    }

    public class TextureRegistry : Object
    {
        public System.Collections.Generic.List`1<TextureInfo> m_Textures; // 0x10

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE87F78DB0
        public void GetTexture(){} // RVA: 0x7FFE87F78E10
        public void AllocAndAcquireDynamic(){} // RVA: 0x7FFE87F79050
        public void UpdateDynamic(){} // RVA: 0x7FFE87F79060
        public void AllocAndAcquire(){} // RVA: 0x7FFE87F793A0
        public void Acquire(){} // RVA: 0x7FFE87F797B0
        public void Release(){} // RVA: 0x7FFE87F79980
        public void .ctor(){} // RVA: 0x7FFE87F79D20
        public void .cctor(){} // RVA: 0x7FFE87F7A100
    }

    public class ThemeStyleSheet : StyleSheet
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFE87FB7260
        public void .ctor(){} // RVA: 0x7FFE87FB7290
    }

    public class TimeMsFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828B3700
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class TimeValue : ValueType
    {
        public float m_Value; // 0x10
        public 0x6651B41C m_Unit; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE82AB44F0
        public void get_unit(){} // RVA: 0x7FFE826F42A0
        public void .ctor(){} // RVA: 0x7FFE838423C0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE87F7C090
        public void op_Equality(){} // RVA: 0x7FFE87F7C0B0
        public void op_Inequality(){} // RVA: 0x7FFE87FA5380
        public void Equals(){} // RVA: 0x7FFE87FA9600 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F7C1C0
        public void ToString(){} // RVA: 0x7FFE87FA96B0
    }

    public class TimerEventScheduler : Object
    {
        // ── Methods ──
        public void Schedule(){} // RVA: 0x7FFE87F7ACC0
        public void RemovedScheduledItemAt(){} // RVA: 0x7FFE87F7AE80
        public void Unschedule(){} // RVA: 0x7FFE87F7AF00
        public void PrivateUnSchedule(){} // RVA: 0x7FFE87F7B190
        public void UpdateScheduledEvents(){} // RVA: 0x7FFE87F7B2A0
        public void .ctor(){} // RVA: 0x7FFE87F7BDC0
    }

    public class TimerState : ValueType
    {
        public long _start; // 0x10
        public long _now; // 0x18
        public object field_2; // 0x32E

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFE8284EF60
        public void set_start(){} // RVA: 0x7FFE82889220
        public void get_now(){} // RVA: 0x7FFE826F4210
        public void set_now(){} // RVA: 0x7FFE82C72B10
        public void get_deltaTime(){} // RVA: 0x7FFE87F7A7B0
        public void Equals(){} // RVA: 0x7FFE87F7A860 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F7A890
    }

    public class Toggle : BaseBoolField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F0B3B0 | overloaded x2
        public void InitLabel(){} // RVA: 0x7FFE87F0B4D0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE87F0B550
        public void .cctor(){} // RVA: 0x7FFE87F0B700
    }

    public class TooltipEvent : EventBase`1
    {
        public string _tooltip; // 0x88
        public UnityEngine.Rect _rect; // 0x90

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F3A400
        public void set_tooltip(){} // RVA: 0x7FFE81280F90
        public void set_rect(){} // RVA: 0x7FFE82DC3680
        public void Init(){} // RVA: 0x7FFE87F3A4F0
        public void LocalInit(){} // RVA: 0x7FFE87F3A5B0
        public void .ctor(){} // RVA: 0x7FFE87F3A660
    }

    public class TouchScreenTextEditorEventHandler : TextEditorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EE45A0
        public void PollTouchScreenKeyboard(){} // RVA: 0x7FFE87EE4610
        public void DoPollTouchScreenKeyboard(){} // RVA: 0x7FFE87EE47A0
        public void UpdateStringPositionFromKeyboard(){} // RVA: 0x7FFE87EE4D30
        public void CloseTouchScreenKeyboard(){} // RVA: 0x7FFE87EE4E70
        public void OpenTouchScreenKeyboard(){} // RVA: 0x7FFE87EE4FE0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFE87EE52F0
        public void OnPointerDownEvent(){} // RVA: 0x7FFE87EE55D0
        public void OnPointerUpEvent(){} // RVA: 0x7FFE87EE5730
        public void OnFocusInEvent(){} // RVA: 0x7FFE87EE5750
        public void OnFocusOutEvent(){} // RVA: 0x7FFE87EE5970
    }

    public class TransformData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE87FA2310
        public void CopyFrom(){} // RVA: 0x7FFE87FA2340
        public void op_Equality(){} // RVA: 0x7FFE87FA2370
        public void Equals(){} // RVA: 0x7FFE87FA2830 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA2900
    }

    public class TransformOrigin : ValueType
    {
        public UnityEngine.UIElements.Length m_X; // 0x10
        public UnityEngine.UIElements.Length m_Y; // 0x18
        public float m_Z; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FA9840
        public void Initial(){} // RVA: 0x7FFE87FA9850
        public void get_x(){} // RVA: 0x7FFE8284EF60
        public void set_x(){} // RVA: 0x7FFE82889220
        public void get_y(){} // RVA: 0x7FFE826F4210
        public void set_y(){} // RVA: 0x7FFE82C72B10
        public void get_z(){} // RVA: 0x7FFE81225320
        public void op_Equality(){} // RVA: 0x7FFE87FA98D0
        public void op_Inequality(){} // RVA: 0x7FFE87FA9970
        public void Equals(){} // RVA: 0x7FFE87FA9AB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA9B50
        public void ToString(){} // RVA: 0x7FFE87FA9BD0
    }

    public class TransitionCancelEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F3B260
        public void .ctor(){} // RVA: 0x7FFE87F3B350
    }

    public class TransitionData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE87FA2A80
        public void CopyFrom(){} // RVA: 0x7FFE87FA2D50
        public void op_Equality(){} // RVA: 0x7FFE87FA2F40
        public void Equals(){} // RVA: 0x7FFE87FA2FD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA3080
    }

    public class TransitionEndEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F3B020
        public void .ctor(){} // RVA: 0x7FFE87F3B110
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.StylePropertyNameCollection _stylePropertyNames;
        public double _elapsedTime;

        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x7FFE810A1420
        public void set_elapsedTime(){} // RVA: 0x7FFE80E476E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void GetPooled(){} // RVA: 0x7FFE810A1420
    }

    public class TransitionRunEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F3ABA0
        public void .ctor(){} // RVA: 0x7FFE87F3AC90
    }

    public class TransitionStartEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F3ADE0
        public void .ctor(){} // RVA: 0x7FFE87F3AED0
    }

    public class Translate : ValueType
    {
        public UnityEngine.UIElements.Length m_X; // 0x10
        public UnityEngine.UIElements.Length m_Y; // 0x18
        public float m_Z; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FA9D60
        public void None(){} // RVA: 0x7FFE87FA9D80
        public void get_x(){} // RVA: 0x7FFE8284EF60
        public void set_x(){} // RVA: 0x7FFE82889220
        public void get_y(){} // RVA: 0x7FFE826F4210
        public void set_y(){} // RVA: 0x7FFE82C72B10
        public void get_z(){} // RVA: 0x7FFE81225320
        public void op_Equality(){} // RVA: 0x7FFE87FA9DB0
        public void op_Inequality(){} // RVA: 0x7FFE87FA9EC0
        public void Equals(){} // RVA: 0x7FFE87FA9F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA9B50
        public void ToString(){} // RVA: 0x7FFE87FAA020
    }

    public class TreeDataController`1 : Object
    {
        // ── Methods ──
        public void SetRootItems(){} // RVA: 0x7FFE80E460A0
        public void GetDataForId(){} // RVA: 0x7FFE810A1420
        public void GetParentId(){} // RVA: 0x7FFE80E35520
        public void HasChildren(){} // RVA: 0x7FFE80E2F760
        public void GetItemIds(){} // RVA: 0x7FFE80E2E3D0
        public void GetChildrenIds(){} // RVA: 0x7FFE80E3D230
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class TreeData`1 : ValueType
    {
        public System.Collections.Generic.IList`1<int> m_RootItemIds;

        // ── Methods ──
        public void get_rootItemIds(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void GetDataForId(){} // RVA: 0x7FFE810A1420
        public void GetParentId(){} // RVA: 0x7FFE80E35520
        public void Move(){}
        public void HasAncestor(){}
        public void AddItemToParent(){} // RVA: 0x7FFE810A1420
        public void RemoveFromParent(){} // RVA: 0x7FFE80E484C0
        public void UpdateParentTree(){} // RVA: 0x7FFE810A1420
        public void RefreshTree(){} // RVA: 0x7FFE80E460A0
        public void BuildTree(){} // RVA: 0x7FFE80E4BC00
    }

    public class TreeItem : ValueType
    {
        public int _id; // 0x10
        public int _parentId; // 0x14
        public System.Collections.Generic.IEnumerable`1<int> _childrenIds; // 0x18
        public object field_3; // 0x17B

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE826F4220
        public void get_parentId(){} // RVA: 0x7FFE826F42A0
        public void get_childrenIds(){} // RVA: 0x7FFE826F4210
        public void get_hasChildren(){} // RVA: 0x7FFE87F0C2C0
        public void .ctor(){} // RVA: 0x7FFE855D7EC0
    }

    public class TreeView : BaseTreeView
    {
        public System.Func`1<UnityEngine.UIElements.VisualElement> m_MakeItem; // 0x4C0
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> m_BindItem; // 0x4C8
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> _unbindItem; // 0x4D0
        public System.Action`1<UnityEngine.UIElements.VisualElement> _destroyItem; // 0x4D8

        // ── Methods ──
        public void get_makeItem(){} // RVA: 0x7FFE81B0DED0
        public void set_makeItem(){} // RVA: 0x7FFE87F0BE40
        public void get_bindItem(){} // RVA: 0x7FFE81B33CE0
        public void set_bindItem(){} // RVA: 0x7FFE87F0BEF0
        public void get_unbindItem(){} // RVA: 0x7FFE81B10190
        public void get_destroyItem(){} // RVA: 0x7FFE81B350A0
        public void HasValidDataAndBindings(){} // RVA: 0x7FFE87F0BFA0
        public void CreateViewController(){} // RVA: 0x7FFE87F0C000
        public void .ctor(){} // RVA: 0x7FFE87F0C0A0 | overloaded x2
    }

    public class TreeViewController : BaseTreeViewController
    {
        // ── Methods ──
        public void get_treeView(){} // RVA: 0x7FFE87E33E80
        public void MakeItem(){} // RVA: 0x7FFE87E33F10
        public void BindItem(){} // RVA: 0x7FFE87E34050
        public void UnbindItem(){} // RVA: 0x7FFE87E34220
        public void DestroyItem(){} // RVA: 0x7FFE87E34270
        public void .ctor(){} // RVA: 0x7FFE8387A520
    }

    public class TreeViewItemData`1 : ValueType
    {
        public int _id;
        public T m_Data;
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.TreeViewItemData`1<T>> m_Children;
        public object field_3; // 0x182

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE80E2EDB0
        public void get_data(){} // RVA: 0x7FFE810A1420
        public void get_children(){} // RVA: 0x7FFE80E2E2E0
        public void get_hasChildren(){} // RVA: 0x7FFE80E2F150
        public void InsertChild(){} // RVA: 0x7FFE810A1420
        public void RemoveChild(){} // RVA: 0x7FFE80E46530
        public void GetChildIndex(){} // RVA: 0x7FFE80E35520
        public void ReplaceChild(){} // RVA: 0x7FFE810A1420
    }

    public class TreeViewItemWrapper : ValueType
    {
        public UnityEngine.UIElements.TreeItem item; // 0x10
        public int depth; // 0x20
        public object field_2; // 0x17F

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE826F4220
        public void get_childrenIds(){} // RVA: 0x7FFE826F4210
        public void get_hasChildren(){} // RVA: 0x7FFE87F0C2C0
        public void .ctor(){} // RVA: 0x7FFE87F0C310
    }

    public class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F20CC0
        public void CompareId(){} // RVA: 0x7FFE87F20E70
        public void SetupDragAndDrop(){} // RVA: 0x7FFE87F21530
        public void HandleDragAndDrop(){} // RVA: 0x7FFE87F216C0
        public void OnDrop(){} // RVA: 0x7FFE87F21780
        public void DragCleanup(){} // RVA: 0x7FFE87F21EB0
        public void RestoreExpanded(){} // RVA: 0x7FFE87F22000
        public void HandleAutoExpand(){} // RVA: 0x7FFE87F222A0
        public void DelayExpandDropItem(){} // RVA: 0x7FFE87F22500
        public void ExpandDropItem(){} // RVA: 0x7FFE87F22600
    }

    public class TwoPaneSplitView : VisualElement
    {
        public string s_UssClassName;
        public string s_ContentContainerClassName; // 0x8
        public string s_HandleDragLineClassName; // 0x10
        public string s_HandleDragLineVerticalClassName; // 0x18
        public string s_HandleDragLineHorizontalClassName; // 0x20
        public string s_HandleDragLineAnchorClassName; // 0x28

        // ── Methods ──
        public void get_fixedPane(){} // RVA: 0x7FFE81B0E4A0
        public void get_flexedPane(){} // RVA: 0x7FFE81B2A270
        public void get_fixedPaneIndex(){} // RVA: 0x7FFE87F0C370
        public void get_orientation(){} // RVA: 0x7FFE87F0C380
        public void get_fixedPaneDimension(){} // RVA: 0x7FFE87F0C390
        public void set_fixedPaneDimension(){} // RVA: 0x7FFE87F0C3C0
        public void .ctor(){} // RVA: 0x7FFE87F0C3E0
        public void Init(){} // RVA: 0x7FFE87F0C880
        public void OnPostDisplaySetup(){} // RVA: 0x7FFE87F0CCE0
        public void PostDisplaySetup(){} // RVA: 0x7FFE87F0CDE0
        public void OnSizeChange(){} // RVA: 0x7FFE87F0DE60
        public void UpdateLayout(){} // RVA: 0x7FFE87F0DE70
        public void get_contentContainer(){} // RVA: 0x7FFE87F0E300
        public void OnViewDataReady(){} // RVA: 0x7FFE87F0E310
        public void SetDragLineOffset(){} // RVA: 0x7FFE87F0E340
        public void SetFixedPaneDimension(){} // RVA: 0x7FFE87F0E510
        public void .cctor(){} // RVA: 0x7FFE87F0E6E0
    }

    public class TwoPaneSplitViewResizer : PointerManipulator
    {
        public UnityEngine.Vector3 m_Start; // 0x38
        public bool m_Active; // 0x44
        public UnityEngine.UIElements.TwoPaneSplitView m_SplitView; // 0x48
        public int m_Direction; // 0x50
        public object field_4; // 0x18C
        public object field_5; // 0x18D
        public object field_6; // 0x18E

        // ── Methods ──
        public void get_orientation(){} // RVA: 0x7FFE87F0F1F0
        public void get_fixedPane(){} // RVA: 0x7FFE87F0F210
        public void get_flexedPane(){} // RVA: 0x7FFE87F0F230
        public void get_fixedPaneMinDimension(){} // RVA: 0x7FFE87F0F250
        public void get_fixedPaneMargins(){} // RVA: 0x7FFE87F0F2E0
        public void get_flexedPaneMinDimension(){} // RVA: 0x7FFE87F0F3C0
        public void get_flexedPaneMargin(){} // RVA: 0x7FFE87F0F450
        public void .ctor(){} // RVA: 0x7FFE87F0F530
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFE87F0F690
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFE87F0F830
        public void ApplyDelta(){} // RVA: 0x7FFE87F0F9C0
        public void OnPointerDown(){} // RVA: 0x7FFE87F100D0
        public void OnPointerMove(){} // RVA: 0x7FFE87F10190
        public void OnPointerUp(){} // RVA: 0x7FFE87F102B0
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        public T _defaultValue; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x7FFE81081080
        public void get_defaultValue(){} // RVA: 0x7FFE81081080
        public void set_defaultValue(){} // RVA: 0x7FFE84332F90
        public void .ctor(){} // RVA: 0x7FFE850A4920
    }

}