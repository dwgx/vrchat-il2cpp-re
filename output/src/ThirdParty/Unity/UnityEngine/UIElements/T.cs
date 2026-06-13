// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 82
// Methods: 852

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class TemplateAsset
    {
        public string m_TemplateAlias; // 0x70
        public System.Collections.Generic.List`1<AttributeOverride> m_AttributeOverrides; // 0x78

        // ── Methods ──
        public void get_attributeOverrides(){} // RVA: 0x748F530
        public void get_slotUsages(){} // RVA: 0x71882E0
    }

    public class TemplateContainer
    {
        public string <templateId>k__BackingField; // 0x3D8
        public UnityEngine.UIElements.VisualElement m_ContentContainer; // 0x3E0
        public UnityEngine.UIElements.VisualTreeAsset m_TemplateSource; // 0x3E8

        // ── Methods ──
        public void get_templateId(){} // RVA: 0xDA0010
        public void set_templateId(){} // RVA: 0xD9ACB0
        public void set_templateSource(){} // RVA: 0xD8AC30
        public void .ctor(){} // RVA: 0x7477150 | overloaded x2
        public void get_contentContainer(){} // RVA: 0x7477260
        public void SetContentContainer(){} // RVA: 0xD9D360
    }

    public class TextEditingManipulator
    {
        public UnityEngine.UIElements.TextElement isClicking; // 0x10

        // ── Methods ──
        public void get_touchScreenTextFieldChanged(){} // RVA: 0x74785B0
        public void .ctor(){} // RVA: 0x7478640
        public void InitTextEditorEventHandler(){} // RVA: 0x74788F0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7478BE0
        public void OnFocusInEvent(){} // RVA: 0x7478DE0
        public void OnFocusOutEvent(){} // RVA: 0x7478FB0
        public void <OnFocusInEvent>b__10_0(){} // RVA: 0x7479080
    }

    public class TextEditorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x2DD310
    }

    public class TextElement
    {
        public string ussClassName;
        public UnityEngine.UIElements.UITKTextHandle <uitkTextHandle>k__BackingField; // 0x3D8
        public string m_Text; // 0x3E0
        public bool m_EnableRichText; // 0x3E8
        public bool m_ParseEscapeSequences; // 0x3E9
        public bool m_DisplayTooltipWhenElided; // 0x3EA
        public bool <isElided>k__BackingField; // 0x3EB
        public string k_EllipsisText; // 0x8
        public string elidedText; // 0x3F0
        public bool m_WasElided; // 0x3F8
        public UnityEngine.UIElements.TextEditingManipulator editingManipulator; // 0x400
        public bool m_Multiline; // 0x408
        public UnityEngine.TouchScreenKeyboard m_TouchScreenKeyboard; // 0x410
        public 0x6589C430 m_KeyboardType; // 0x418
        public bool m_HideMobileInput; // 0x41C
        public bool m_IsReadOnly; // 0x41D
        public int m_MaxLength; // 0x420
        public bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; // 0x424
        public System.Func`2<char,bool> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; // 0x428
        public System.Action`1<bool> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; // 0x430
        public System.Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; // 0x438
        public System.Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; // 0x440
        public System.Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; // 0x448
        public string m_RenderedText; // 0x450
        public string m_OriginalText; // 0x458
        public char m_MaskChar; // 0x460
        public bool m_IsPassword; // 0x462
        public bool m_AutoCorrection; // 0x463
        public UnityEngine.UIElements.TextSelectingManipulator m_SelectingManipulator; // 0x468
        public bool m_IsSelectable; // 0x470
        public bool <UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord>k__BackingField; // 0x471
        public bool <UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine>k__BackingField; // 0x472
        public bool <UnityEngine.UIElements.ITextSelection.selectAllOnFocus>k__BackingField; // 0x473
        public bool <UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp>k__BackingField; // 0x474
        public UnityEngine.Color m_SelectionColor; // 0x478
        public UnityEngine.Color m_CursorColor; // 0x488
        public float m_CursorWidth; // 0x498

        // ── Methods ──
        public void .ctor(){} // RVA: 0x747EEE0
        public void get_uitkTextHandle(){} // RVA: 0xDA0010
        public void set_uitkTextHandle(){} // RVA: 0xD9ACB0
        public void OnGeometryChanged(){} // RVA: 0x747F290
        public void get_text(){} // RVA: 0x747F2A0
        public void set_text(){} // RVA: 0x747F2E0
        public void get_enableRichText(){} // RVA: 0x73192B0
        public void set_enableRichText(){} // RVA: 0x747F340
        public void get_parseEscapeSequences(){} // RVA: 0x747F390
        public void set_parseEscapeSequences(){} // RVA: 0x747F3A0
        public void get_displayTooltipWhenElided(){} // RVA: 0x747F3F0
        public void set_displayTooltipWhenElided(){} // RVA: 0x747F400
        public void get_isElided(){} // RVA: 0x747F450
        public void set_isElided(){} // RVA: 0x747F460
        public void OnGenerateVisualContent(){} // RVA: 0x747F470
        public void ElideText(){} // RVA: 0x747F790
        public void UpdateTooltip(){} // RVA: 0x747FC10
        public void UpdateVisibleText(){} // RVA: 0x747FC80
        public void ShouldElide(){} // RVA: 0x747FEB0
        public void get_hasFocus(){} // RVA: 0x747FF40
        public void MeasureTextSize(){} // RVA: 0x747FFC0
        public void DoMeasure(){} // RVA: 0x747FFF0
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value(){} // RVA: 0x7480060
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(){} // RVA: 0x74800B0
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(){} // RVA: 0x7480280
        public void get_edition(){} // RVA: 0x1A3F520
        public void UnityEngine.UIElements.ITextEdition.get_multiline(){} // RVA: 0x55BEC10
        public void UnityEngine.UIElements.ITextEdition.set_multiline(){} // RVA: 0x7480470
        public void UnityEngine.UIElements.ITextEdition.get_keyboardType(){} // RVA: 0x7480500
        public void UnityEngine.UIElements.ITextEdition.set_keyboardType(){} // RVA: 0x7480510
        public void UnityEngine.UIElements.ITextEdition.get_hideMobileInput(){} // RVA: 0x7480520
        public void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(){} // RVA: 0x74805C0
        public void UnityEngine.UIElements.ITextEdition.get_isReadOnly(){} // RVA: 0x7480680
        public void UnityEngine.UIElements.ITextEdition.set_isReadOnly(){} // RVA: 0x74806A0
        public void ProcessMenuCommand(){} // RVA: 0x7480780
        public void Cut(){} // RVA: 0x7480950
        public void Copy(){} // RVA: 0x74809A0
        public void Paste(){} // RVA: 0x74809F0
        public void BuildContextualMenu(){} // RVA: 0x7480A40
        public void CutActionStatus(){} // RVA: 0x7480DB0
        public void CopyActionStatus(){} // RVA: 0x7480E40
        public void PasteActionStatus(){} // RVA: 0x7480ED0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7480F30
        public void UnityEngine.UIElements.ITextEdition.get_maxLength(){} // RVA: 0x7481200
        public void UnityEngine.UIElements.ITextEdition.set_maxLength(){} // RVA: 0x7481210
        public void UnityEngine.UIElements.ITextEdition.get_isDelayed(){} // RVA: 0x74812A0
        public void UnityEngine.UIElements.ITextEdition.set_isDelayed(){} // RVA: 0x74812B0
        public void UnityEngine.UIElements.ITextEdition.SaveValueAndText(){} // RVA: 0x74812C0
        public void UnityEngine.UIElements.ITextEdition.RestoreValueAndText(){} // RVA: 0x7481340
        public void UnityEngine.UIElements.ITextEdition.get_AcceptCharacter(){} // RVA: 0xDA2770
        public void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(){} // RVA: 0xD9C990
        public void UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset(){} // RVA: 0xD96F70
        public void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(){} // RVA: 0xD8B1F0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText(){} // RVA: 0xD95A10
        public void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(){} // RVA: 0xD9E3B0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue(){} // RVA: 0xD8EF30
        public void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(){} // RVA: 0xD95C40
        public void UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot(){} // RVA: 0xD9A100
        public void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(){} // RVA: 0xDA31D0
        public void UnityEngine.UIElements.ITextEdition.UpdateText(){} // RVA: 0x7481360
        public void UnityEngine.UIElements.ITextEdition.CullString(){} // RVA: 0x7481710
        public void UnityEngine.UIElements.ITextEdition.set_maskChar(){} // RVA: 0x7481790
        public void get_effectiveMaskChar(){} // RVA: 0x7481820
        public void UnityEngine.UIElements.ITextEdition.get_isPassword(){} // RVA: 0x7481890
        public void UnityEngine.UIElements.ITextEdition.set_isPassword(){} // RVA: 0x74818A0
        public void UnityEngine.UIElements.ITextEdition.get_autoCorrection(){} // RVA: 0x74818F0
        public void UnityEngine.UIElements.ITextEdition.set_autoCorrection(){} // RVA: 0x7481900
        public void get_renderedText(){} // RVA: 0x7481910
        public void set_renderedText(){} // RVA: 0x7481A70
        public void get_originalText(){} // RVA: 0xDA8310
        public void get_selection(){} // RVA: 0x1A3F520
        public void UnityEngine.UIElements.ITextSelection.get_isSelectable(){} // RVA: 0x7481B10
        public void UnityEngine.UIElements.ITextSelection.set_isSelectable(){} // RVA: 0x7481B30
        public void UnityEngine.UIElements.ITextSelection.get_cursorIndex(){} // RVA: 0x7481B50
        public void UnityEngine.UIElements.ITextSelection.set_cursorIndex(){} // RVA: 0x7481BD0
        public void UnityEngine.UIElements.ITextSelection.get_selectIndex(){} // RVA: 0x7481C70
        public void UnityEngine.UIElements.ITextSelection.set_selectIndex(){} // RVA: 0x7481CF0
        public void UnityEngine.UIElements.ITextSelection.SelectAll(){} // RVA: 0x7481D90
        public void UnityEngine.UIElements.ITextSelection.SelectNone(){} // RVA: 0x7481E10
        public void UnityEngine.UIElements.ITextSelection.HasSelection(){} // RVA: 0x7481EB0
        public void UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord(){} // RVA: 0x7481F60
        public void UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine(){} // RVA: 0x7481F70
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus(){} // RVA: 0x7481F80
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(){} // RVA: 0x7481F90
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp(){} // RVA: 0x7481FA0
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(){} // RVA: 0x7481FB0
        public void UnityEngine.UIElements.ITextSelection.get_cursorPosition(){} // RVA: 0x7481FC0
        public void UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition(){} // RVA: 0x7482070
        public void UnityEngine.UIElements.ITextSelection.get_selectionColor(){} // RVA: 0x7482150
        public void UnityEngine.UIElements.ITextSelection.set_selectionColor(){} // RVA: 0x7482160
        public void UnityEngine.UIElements.ITextSelection.get_cursorColor(){} // RVA: 0x7482210
        public void UnityEngine.UIElements.ITextSelection.set_cursorColor(){} // RVA: 0x7482220
        public void UnityEngine.UIElements.ITextSelection.get_cursorWidth(){} // RVA: 0x74822D0
        public void get_selectingManipulator(){} // RVA: 0x74822E0
        public void DrawHighlighting(){} // RVA: 0x74823A0
        public void DrawCaret(){} // RVA: 0x7482C50
        public void GetLastCharacterAt(){} // RVA: 0x74830E0
        public void .cctor(){} // RVA: 0x7483340
    }

    public class TextField
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void get_textInput(){} // RVA: 0x73A31C0
        public void set_multiline(){} // RVA: 0x73A3250
        public void .ctor(){} // RVA: 0x73A32E0 | overloaded x3
        public void get_value(){} // RVA: 0x73A3580
        public void set_value(){} // RVA: 0x73A35D0
        public void SetValueWithoutNotify(){} // RVA: 0x73A3690
        public void UpdateTextFromValue(){} // RVA: 0x73A3750
        public void ExecuteDefaultAction(){} // RVA: 0x73A37A0
        public void OnViewDataReady(){} // RVA: 0x73A3980
        public void ValueToString(){} // RVA: 0x13DCE00
        public void StringToValue(){} // RVA: 0x13DCE00
        public void .cctor(){} // RVA: 0x73A3A30
    }

    public class TextInputBaseField`1
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
        public void get_textInputBase(){} // RVA: 0x43D9040
        public void get_text(){} // RVA: 0x43D9070
        public void set_text(){} // RVA: 0x43D90E0
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43D9140
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43D92B0
        public void get_isReadOnly(){} // RVA: 0x43D9420
        public void set_isReadOnly(){} // RVA: 0x43D94B0
        public void set_isPasswordField(){} // RVA: 0x43D9590
        public void set_autoCorrection(){} // RVA: 0x43D96C0
        public void set_hideMobileInput(){} // RVA: 0x43D9760
        public void set_keyboardType(){} // RVA: 0x43D9800
        public void get_textEdition(){} // RVA: 0x43D9890
        public void set_maxLength(){} // RVA: 0x43D9900
        public void get_isDelayed(){} // RVA: 0x43D9990
        public void set_isDelayed(){} // RVA: 0x43D9A20
        public void set_maskChar(){} // RVA: 0x43D9AC0
        public void ValueToString(){} // RVA: 0x283FA0
        public void StringToValue(){} // RVA: 0x263BC0
        public void .ctor(){} // RVA: 0x43D9B60
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43D9F70
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43D9FD0
        public void UpdateMixedValueContent(){} // RVA: 0x43DA620
        public void UpdateValueFromText(){} // RVA: 0x43DA980
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43DAA90
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty;
        public int m_VisualInputTabIndex;
        public TextInputBase<T> m_TextInputBase;
        public string ussClassName;
        public string labelUssClassName;
        public string inputUssClassName;
        public string multilineContainerClassName;
        public string singleLineInputUssClassName;
        public string multilineInputUssClassName;
        public string multilineInputWithScrollViewUssClassName;

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xCD60
        public void get_text(){} // RVA: 0xCD60
        public void set_text(){} // RVA: 0x24B10
        public void add_onIsReadOnlyChanged(){} // RVA: 0x24B10
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x24B10
        public void get_isReadOnly(){} // RVA: 0xDBE0
        public void set_isReadOnly(){} // RVA: 0x25130
        public void set_isPasswordField(){} // RVA: 0x25130
        public void set_autoCorrection(){} // RVA: 0x25130
        public void set_hideMobileInput(){} // RVA: 0x25130
        public void set_keyboardType(){} // RVA: 0x24FA0
        public void get_textEdition(){} // RVA: 0xCD60
        public void set_maxLength(){} // RVA: 0x24FA0
        public void get_isDelayed(){} // RVA: 0xDBE0
        public void set_isDelayed(){} // RVA: 0x25130
        public void set_maskChar(){} // RVA: 0x24C40
        public void ValueToString(){} // RVA: 0x283FA0
        public void StringToValue(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
        public void OnFieldCustomStyleResolved(){} // RVA: 0x24B10
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x24B10
        public void UpdateMixedValueContent(){} // RVA: 0x24A50
        public void UpdateValueFromText(){} // RVA: 0x24A50
        public void UpdateTextFromValue(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<double> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xD9A100
        public void get_text(){} // RVA: 0x43CB320
        public void set_text(){} // RVA: 0x43CB360
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43CB380
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43CB480
        public void get_isReadOnly(){} // RVA: 0x43CB580
        public void set_isReadOnly(){} // RVA: 0x43CB5E0
        public void set_isPasswordField(){} // RVA: 0x43CB670
        public void set_autoCorrection(){} // RVA: 0x43CB710
        public void set_hideMobileInput(){} // RVA: 0x43CB780
        public void set_keyboardType(){} // RVA: 0x43CB7F0
        public void get_textEdition(){} // RVA: 0x43CB860
        public void set_maxLength(){} // RVA: 0x43CB890
        public void get_isDelayed(){} // RVA: 0x43CB900
        public void set_isDelayed(){} // RVA: 0x43CB960
        public void set_maskChar(){} // RVA: 0x43CB9D0
        public void ValueToString(){}
        public void StringToValue(){} // RVA: 0x12DE0
        public void .ctor(){} // RVA: 0x43CBA40
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43CBDE0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43CBE20
        public void UpdateMixedValueContent(){} // RVA: 0x43CC1E0
        public void UpdateValueFromText(){} // RVA: 0x43CC480
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43CC500
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<float> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xD9A100
        public void get_text(){} // RVA: 0x43CB320
        public void set_text(){} // RVA: 0x43CB360
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43D3F40
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43D4040
        public void get_isReadOnly(){} // RVA: 0x43D4140
        public void set_isReadOnly(){} // RVA: 0x43D41A0
        public void set_isPasswordField(){} // RVA: 0x43CB670
        public void set_autoCorrection(){} // RVA: 0x43D4230
        public void set_hideMobileInput(){} // RVA: 0x43D42A0
        public void set_keyboardType(){} // RVA: 0x43D4310
        public void get_textEdition(){} // RVA: 0x43CB860
        public void set_maxLength(){} // RVA: 0x43D4380
        public void get_isDelayed(){} // RVA: 0x43D43F0
        public void set_isDelayed(){} // RVA: 0x43D4450
        public void set_maskChar(){} // RVA: 0x43D44C0
        public void ValueToString(){}
        public void StringToValue(){} // RVA: 0x21FA0
        public void .ctor(){} // RVA: 0x43D4530
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43D48D0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43D4910
        public void UpdateMixedValueContent(){} // RVA: 0x43D4CD0
        public void UpdateValueFromText(){} // RVA: 0x43CC480
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43D4F70
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x448
        public TextInputBase<UnityEngine.Hash128> m_TextInputBase; // 0x450
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xD961C0
        public void get_text(){} // RVA: 0x43CCFD0
        public void set_text(){} // RVA: 0x43CD010
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43CD0B0
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43CD1B0
        public void get_isReadOnly(){} // RVA: 0x43CD2B0
        public void set_isReadOnly(){} // RVA: 0x43CD310
        public void set_isPasswordField(){} // RVA: 0x43CD3A0
        public void set_autoCorrection(){} // RVA: 0x43CD440
        public void set_hideMobileInput(){} // RVA: 0x43CD4B0
        public void set_keyboardType(){} // RVA: 0x43CD520
        public void get_textEdition(){} // RVA: 0x43CD590
        public void set_maxLength(){} // RVA: 0x43CD5C0
        public void get_isDelayed(){} // RVA: 0x43CD630
        public void set_isDelayed(){} // RVA: 0x43CD690
        public void set_maskChar(){} // RVA: 0x43CD700
        public void ValueToString(){}
        public void StringToValue(){}
        public void .ctor(){} // RVA: 0x43CD770
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43CDB10
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43CDB50
        public void UpdateMixedValueContent(){} // RVA: 0x43CDF10
        public void UpdateValueFromText(){} // RVA: 0x43CE1B0
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43CE240
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<string> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xD9A100
        public void get_text(){} // RVA: 0x43CB320
        public void set_text(){} // RVA: 0x43D2410
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43D2440
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43D2540
        public void get_isReadOnly(){} // RVA: 0x43D2640
        public void set_isReadOnly(){} // RVA: 0x43D26A0
        public void set_isPasswordField(){} // RVA: 0x43CB670
        public void set_autoCorrection(){} // RVA: 0x43D2730
        public void set_hideMobileInput(){} // RVA: 0x43D27A0
        public void set_keyboardType(){} // RVA: 0x43D2810
        public void get_textEdition(){} // RVA: 0x43CB860
        public void set_maxLength(){} // RVA: 0x43D2880
        public void get_isDelayed(){} // RVA: 0x43D28F0
        public void set_isDelayed(){} // RVA: 0x43D2950
        public void set_maskChar(){} // RVA: 0x43D29C0
        public void ValueToString(){} // RVA: 0xCE10
        public void StringToValue(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x43D2A30
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43D2DD0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43D2E10
        public void UpdateMixedValueContent(){} // RVA: 0x43D31D0
        public void UpdateValueFromText(){} // RVA: 0x43D18C0
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43D3470
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<int> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xD9A100
        public void get_text(){} // RVA: 0x43CB320
        public void set_text(){} // RVA: 0x43CB360
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43CED10
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43CEE10
        public void get_isReadOnly(){} // RVA: 0x43CEF10
        public void set_isReadOnly(){} // RVA: 0x43CEF70
        public void set_isPasswordField(){} // RVA: 0x43CB670
        public void set_autoCorrection(){} // RVA: 0x43CF000
        public void set_hideMobileInput(){} // RVA: 0x43CF070
        public void set_keyboardType(){} // RVA: 0x43CF0E0
        public void get_textEdition(){} // RVA: 0x43CB860
        public void set_maxLength(){} // RVA: 0x43CF150
        public void get_isDelayed(){} // RVA: 0x43CF1C0
        public void set_isDelayed(){} // RVA: 0x43CF220
        public void set_maskChar(){} // RVA: 0x43CF290
        public void ValueToString(){} // RVA: 0x1BCC0
        public void StringToValue(){} // RVA: 0x12590
        public void .ctor(){} // RVA: 0x43CF300
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43CF6A0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43CF6E0
        public void UpdateMixedValueContent(){} // RVA: 0x43CFAA0
        public void UpdateValueFromText(){} // RVA: 0x43CFD40
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43CFDC0
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<long> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xD9A100
        public void get_text(){} // RVA: 0x43CB320
        public void set_text(){} // RVA: 0x43CB360
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43D0890
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43D0990
        public void get_isReadOnly(){} // RVA: 0x43D0A90
        public void set_isReadOnly(){} // RVA: 0x43D0AF0
        public void set_isPasswordField(){} // RVA: 0x43CB670
        public void set_autoCorrection(){} // RVA: 0x43D0B80
        public void set_hideMobileInput(){} // RVA: 0x43D0BF0
        public void set_keyboardType(){} // RVA: 0x43D0C60
        public void get_textEdition(){} // RVA: 0x43CB860
        public void set_maxLength(){} // RVA: 0x43D0CD0
        public void get_isDelayed(){} // RVA: 0x43D0D40
        public void set_isDelayed(){} // RVA: 0x43D0DA0
        public void set_maskChar(){} // RVA: 0x43D0E10
        public void ValueToString(){}
        public void StringToValue(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x43D0E80
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43D1220
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43D1260
        public void UpdateMixedValueContent(){} // RVA: 0x43D1620
        public void UpdateValueFromText(){} // RVA: 0x43D18C0
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43D1940
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<uint> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xD9A100
        public void get_text(){} // RVA: 0x43CB320
        public void set_text(){} // RVA: 0x43CB360
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43D5A40
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43D5B40
        public void get_isReadOnly(){} // RVA: 0x43D5C40
        public void set_isReadOnly(){} // RVA: 0x43D5CA0
        public void set_isPasswordField(){} // RVA: 0x43CB670
        public void set_autoCorrection(){} // RVA: 0x43D5D30
        public void set_hideMobileInput(){} // RVA: 0x43D5DA0
        public void set_keyboardType(){} // RVA: 0x43D5E10
        public void get_textEdition(){} // RVA: 0x43CB860
        public void set_maxLength(){} // RVA: 0x43D5E80
        public void get_isDelayed(){} // RVA: 0x43D5EF0
        public void set_isDelayed(){} // RVA: 0x43D5F50
        public void set_maskChar(){} // RVA: 0x43D5FC0
        public void ValueToString(){}
        public void StringToValue(){} // RVA: 0x12590
        public void .ctor(){} // RVA: 0x43D6030
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43D63D0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43D6410
        public void UpdateMixedValueContent(){} // RVA: 0x43D67D0
        public void UpdateValueFromText(){} // RVA: 0x43CFD40
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43D6A70
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<ulong> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0xD9A100
        public void get_text(){} // RVA: 0x43CB320
        public void set_text(){} // RVA: 0x43CB360
        public void add_onIsReadOnlyChanged(){} // RVA: 0x43D7540
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x43D7640
        public void get_isReadOnly(){} // RVA: 0x43D7740
        public void set_isReadOnly(){} // RVA: 0x43D77A0
        public void set_isPasswordField(){} // RVA: 0x43CB670
        public void set_autoCorrection(){} // RVA: 0x43D7830
        public void set_hideMobileInput(){} // RVA: 0x43D78A0
        public void set_keyboardType(){} // RVA: 0x43D7910
        public void get_textEdition(){} // RVA: 0x43CB860
        public void set_maxLength(){} // RVA: 0x43D7980
        public void get_isDelayed(){} // RVA: 0x43D79F0
        public void set_isDelayed(){} // RVA: 0x43D7A50
        public void set_maskChar(){} // RVA: 0x43D7AC0
        public void ValueToString(){}
        public void StringToValue(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x43D7B30
        public void OnFieldCustomStyleResolved(){} // RVA: 0x43D7ED0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x43D7F10
        public void UpdateMixedValueContent(){} // RVA: 0x43D82D0
        public void UpdateValueFromText(){} // RVA: 0x43D18C0
        public void UpdateTextFromValue(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x43D8570
    }

    public class TextInputBaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_SelectionColorProperty;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_CursorColorProperty; // 0x8
        public int m_VisualInputTabIndex; // 0x440
        public TextInputBase<ulong> m_TextInputBase; // 0x448
        public string ussClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20
        public string multilineContainerClassName; // 0x28
        public string singleLineInputUssClassName; // 0x30
        public string multilineInputUssClassName; // 0x38
        public string multilineInputWithScrollViewUssClassName; // 0x40
    }

    public class TextSelectingManipulator
    {
        public UnityEngine.TextSelectingUtilities MeasuredSizes; // 0x10
        public bool RoundedSizes; // 0x18
        public UnityEngine.UIElements.TextElement m_TextElement; // 0x20

        // ── Methods ──
        public void get_isClicking(){} // RVA: 0x303470
        public void set_isClicking(){} // RVA: 0x74790D0
        public void .ctor(){} // RVA: 0x74790E0
        public void get_cursorIndex(){} // RVA: 0x7479610
        public void set_cursorIndex(){} // RVA: 0x7199070
        public void get_selectIndex(){} // RVA: 0x7479630
        public void set_selectIndex(){} // RVA: 0x71990E0
        public void OnRevealCursor(){} // RVA: 0x7479650
        public void OnSelectIndexChange(){} // RVA: 0x74796A0
        public void OnCursorIndexChange(){} // RVA: 0x74797E0
        public void RevealCursor(){} // RVA: 0x7479920
        public void HasSelection(){} // RVA: 0x7479940
        public void HasFocus(){} // RVA: 0x7479990
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x74799B0
        public void OnFocusEvent(){} // RVA: 0x7479DE0
        public void OnBlurEvent(){} // RVA: 0x7479F90
        public void OnKeyDown(){} // RVA: 0x7479FF0
        public void OnPointerDownEvent(){} // RVA: 0x747A060
        public void OnPointerMoveEvent(){} // RVA: 0x747A430
        public void OnPointerUpEvent(){} // RVA: 0x747A5F0
        public void OnValidateCommandEvent(){} // RVA: 0x747A6E0
        public void OnExecuteCommandEvent(){} // RVA: 0x747A920
        public void MoveDistanceQualifiesForDrag(){} // RVA: 0x747AAD0
    }

    public class TextShadow
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x74840B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7484180
        public void op_Equality(){} // RVA: 0x7484200
        public void op_Inequality(){} // RVA: 0x7484230
        public void ToString(){} // RVA: 0x74842F0
        public void LerpUnclamped(){} // RVA: 0x7484430
    }

    public class TextUtilities
    {
        // ── Methods ──
        public void MeasureVisualElementTextSize(){} // RVA: 0x747DE90
        public void GetFontAsset(){} // RVA: 0x747E290
        public void IsFontAssigned(){} // RVA: 0x747E640
        public void GetTextSettingsFrom(){} // RVA: 0x747E7A0
        public void ConvertPixelUnitsToTextCoreRelativeUnits(){} // RVA: 0x747E870
        public void GetTextCoreSettingsForElement(){} // RVA: 0x747E930
    }

    public class TextValueFieldTraits`2
    {
        // ── Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x24A50
    }

    public class TextValueFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x43DF390
        public void .ctor(){} // RVA: 0x43DF5D0
    }

    public class TextValueFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x43E0610
        public void .ctor(){} // RVA: 0x43E0960
    }

    public class TextValueFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x43DF830
        public void .ctor(){} // RVA: 0x43DFA70
    }

    public class TextValueFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x43DFCD0
        public void .ctor(){} // RVA: 0x43DFF10
    }

    public class TextValueFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x43E0170
        public void .ctor(){} // RVA: 0x43E03B0
    }

    public class TextValueFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x43E0CC0
        public void .ctor(){} // RVA: 0x43E0F00
    }

    public class TextValueFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x43E1160
        public void .ctor(){} // RVA: 0x43E13A0
    }

    public class TextValueField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger;
        public bool m_UpdateTextFromValue;
        public bool m_ForceUpdateDisplay;

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0xCD60
        public void get_formatString(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2C800
        public void ApplyInputDeviceDelta(){} // RVA: 0x283FA0
        public void StartDragging(){} // RVA: 0x24A50
        public void StopDragging(){} // RVA: 0x24A50
        public void get_value(){} // RVA: 0x283FA0
        public void set_value(){} // RVA: 0x283FA0
        public void UpdateValueFromText(){} // RVA: 0x24A50
        public void UpdateTextFromValue(){} // RVA: 0x24A50
        public void OnIsReadOnlyChanged(){} // RVA: 0x25130
        public void CanTryParse(){} // RVA: 0xDE40
        public void AddLabelDragger(){} // RVA: 0x24A50
        public void EnableLabelDragger(){} // RVA: 0x25130
        public void SetValueWithoutNotify(){} // RVA: 0x283FA0
        public void ExecuteDefaultAction(){} // RVA: 0x24B10
        public void OnViewDataReady(){} // RVA: 0x24A50
        public void RegisterEditingCallbacks(){} // RVA: 0x24A50
        public void UnregisterEditingCallbacks(){} // RVA: 0x24A50
    }

    public class TextValueField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger; // 0x458
        public bool m_UpdateTextFromValue; // 0x460
        public bool m_ForceUpdateDisplay; // 0x461

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x43E1A00
        public void get_formatString(){} // RVA: 0x43E1A90
        public void .ctor(){} // RVA: 0x43E1B20
        public void ApplyInputDeviceDelta(){}
        public void StartDragging(){} // RVA: 0x43E1D60
        public void StopDragging(){} // RVA: 0x43E1E90
        public void get_value(){} // RVA: 0x43E2050
        public void set_value(){} // RVA: 0x43E2070
        public void UpdateValueFromText(){} // RVA: 0x43E20A0
        public void UpdateTextFromValue(){} // RVA: 0x43E2190
        public void OnIsReadOnlyChanged(){} // RVA: 0x43E21E0
        public void CanTryParse(){} // RVA: 0x2DD320
        public void AddLabelDragger(){} // RVA: 0x24A50
        public void EnableLabelDragger(){} // RVA: 0x43E2200
        public void SetValueWithoutNotify(){} // RVA: 0x43E2310
        public void ExecuteDefaultAction(){} // RVA: 0x43E24C0
        public void OnViewDataReady(){} // RVA: 0x43E26F0
        public void RegisterEditingCallbacks(){} // RVA: 0x43E2710
        public void UnregisterEditingCallbacks(){} // RVA: 0x43E2940
    }

    public class TextValueField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger; // 0x458
        public bool m_UpdateTextFromValue; // 0x460
        public bool m_ForceUpdateDisplay; // 0x461

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x43E1A00
        public void get_formatString(){} // RVA: 0x43E1A90
        public void .ctor(){} // RVA: 0x43E4970
        public void ApplyInputDeviceDelta(){}
        public void StartDragging(){} // RVA: 0x43E4BB0
        public void StopDragging(){} // RVA: 0x43E4CE0
        public void get_value(){} // RVA: 0x43E4EA0
        public void set_value(){} // RVA: 0x43E4EC0
        public void UpdateValueFromText(){} // RVA: 0x43E20A0
        public void UpdateTextFromValue(){} // RVA: 0x43E4EF0
        public void OnIsReadOnlyChanged(){} // RVA: 0x43E21E0
        public void CanTryParse(){} // RVA: 0x2DD320
        public void AddLabelDragger(){} // RVA: 0x24A50
        public void EnableLabelDragger(){} // RVA: 0x43E2200
        public void SetValueWithoutNotify(){} // RVA: 0x43E4F40
        public void ExecuteDefaultAction(){} // RVA: 0x43E5060
        public void OnViewDataReady(){} // RVA: 0x43E5290
        public void RegisterEditingCallbacks(){} // RVA: 0x43E52B0
        public void UnregisterEditingCallbacks(){} // RVA: 0x43E54E0
    }

    public class TextValueField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger; // 0x458
        public bool m_UpdateTextFromValue; // 0x460
        public bool m_ForceUpdateDisplay; // 0x461

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x43E1A00
        public void get_formatString(){} // RVA: 0x43E1A90
        public void .ctor(){} // RVA: 0x43E2BA0
        public void ApplyInputDeviceDelta(){}
        public void StartDragging(){} // RVA: 0x43E2DD0
        public void StopDragging(){} // RVA: 0x43E2F00
        public void get_value(){} // RVA: 0x43E30C0
        public void set_value(){} // RVA: 0x43E30E0
        public void UpdateValueFromText(){} // RVA: 0x43E3110
        public void UpdateTextFromValue(){} // RVA: 0x43E3200
        public void OnIsReadOnlyChanged(){} // RVA: 0x43E21E0
        public void CanTryParse(){} // RVA: 0x2DD320
        public void AddLabelDragger(){} // RVA: 0x24A50
        public void EnableLabelDragger(){} // RVA: 0x43E2200
        public void SetValueWithoutNotify(){} // RVA: 0x43E3250
        public void ExecuteDefaultAction(){} // RVA: 0x43E3370
        public void OnViewDataReady(){} // RVA: 0x43E35A0
        public void RegisterEditingCallbacks(){} // RVA: 0x43E35C0
        public void UnregisterEditingCallbacks(){} // RVA: 0x43E37F0
    }

    public class TextValueField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger; // 0x458
        public bool m_UpdateTextFromValue; // 0x460
        public bool m_ForceUpdateDisplay; // 0x461

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x43E1A00
        public void get_formatString(){} // RVA: 0x43E1A90
        public void .ctor(){} // RVA: 0x43E3A50
        public void ApplyInputDeviceDelta(){}
        public void StartDragging(){} // RVA: 0x43E3C80
        public void StopDragging(){} // RVA: 0x43E3DB0
        public void get_value(){} // RVA: 0x3E01490
        public void set_value(){} // RVA: 0x43E3F70
        public void UpdateValueFromText(){} // RVA: 0x43E3FA0
        public void UpdateTextFromValue(){} // RVA: 0x43E40A0
        public void OnIsReadOnlyChanged(){} // RVA: 0x43E21E0
        public void CanTryParse(){} // RVA: 0x2DD320
        public void AddLabelDragger(){} // RVA: 0x24A50
        public void EnableLabelDragger(){} // RVA: 0x43E2200
        public void SetValueWithoutNotify(){} // RVA: 0x43E40F0
        public void ExecuteDefaultAction(){} // RVA: 0x43E4290
        public void OnViewDataReady(){} // RVA: 0x43E44C0
        public void RegisterEditingCallbacks(){} // RVA: 0x43E44E0
        public void UnregisterEditingCallbacks(){} // RVA: 0x43E4710
    }

    public class TextValueField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger; // 0x458
        public bool m_UpdateTextFromValue; // 0x460
        public bool m_ForceUpdateDisplay; // 0x461

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x43E1A00
        public void get_formatString(){} // RVA: 0x43E1A90
        public void .ctor(){} // RVA: 0x43E5740
        public void ApplyInputDeviceDelta(){}
        public void StartDragging(){} // RVA: 0x43E5970
        public void StopDragging(){} // RVA: 0x43E5AA0
        public void get_value(){} // RVA: 0x43E30C0
        public void set_value(){} // RVA: 0x43E5C60
        public void UpdateValueFromText(){} // RVA: 0x43E3110
        public void UpdateTextFromValue(){} // RVA: 0x43E3200
        public void OnIsReadOnlyChanged(){} // RVA: 0x43E21E0
        public void CanTryParse(){} // RVA: 0x2DD320
        public void AddLabelDragger(){} // RVA: 0x24A50
        public void EnableLabelDragger(){} // RVA: 0x43E2200
        public void SetValueWithoutNotify(){} // RVA: 0x43E5C90
        public void ExecuteDefaultAction(){} // RVA: 0x43E5E30
        public void OnViewDataReady(){} // RVA: 0x43E6060
        public void RegisterEditingCallbacks(){} // RVA: 0x43E6080
        public void UnregisterEditingCallbacks(){} // RVA: 0x43E62B0
    }

    public class TextValueField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger; // 0x458
        public bool m_UpdateTextFromValue; // 0x460
        public bool m_ForceUpdateDisplay; // 0x461

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x43E1A00
        public void get_formatString(){} // RVA: 0x43E1A90
        public void .ctor(){} // RVA: 0x43E6510
        public void ApplyInputDeviceDelta(){}
        public void StartDragging(){} // RVA: 0x43E6740
        public void StopDragging(){} // RVA: 0x43E6870
        public void get_value(){} // RVA: 0x3E01490
        public void set_value(){} // RVA: 0x43E6A30
        public void UpdateValueFromText(){} // RVA: 0x43E3FA0
        public void UpdateTextFromValue(){} // RVA: 0x43E40A0
        public void OnIsReadOnlyChanged(){} // RVA: 0x43E21E0
        public void CanTryParse(){} // RVA: 0x2DD320
        public void AddLabelDragger(){} // RVA: 0x24A50
        public void EnableLabelDragger(){} // RVA: 0x43E2200
        public void SetValueWithoutNotify(){} // RVA: 0x43E6A60
        public void ExecuteDefaultAction(){} // RVA: 0x43E6C00
        public void OnViewDataReady(){} // RVA: 0x43E6E30
        public void RegisterEditingCallbacks(){} // RVA: 0x43E6E50
        public void UnregisterEditingCallbacks(){} // RVA: 0x43E7080
    }

    public class TextValueField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger m_Dragger; // 0x458
        public bool m_UpdateTextFromValue; // 0x460
        public bool m_ForceUpdateDisplay; // 0x461
    }

    public class TextureId
    {
        public int m_Index; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7438A60
        public void get_index(){} // RVA: 0x7438A70
        public void ConvertToGpu(){} // RVA: 0x7438A80
        public void Equals(){} // RVA: 0x7438AD0
        public void GetHashCode(){} // RVA: 0x67FD0D0
        public void op_Equality(){} // RVA: 0x711FA10
        public void op_Inequality(){} // RVA: 0x7438B70
        public void .cctor(){} // RVA: 0x7438BD0
    }

    public class TextureRegistry
    {
        public System.Collections.Generic.List`1<TextureInfo> m_Textures; // 0x10

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7438C10
        public void GetTexture(){} // RVA: 0x7438C70
        public void AllocAndAcquireDynamic(){} // RVA: 0x7438EB0
        public void UpdateDynamic(){} // RVA: 0x7438EC0
        public void AllocAndAcquire(){} // RVA: 0x7439200
        public void Acquire(){} // RVA: 0x7439610
        public void Release(){} // RVA: 0x74397E0
        public void .ctor(){} // RVA: 0x7439B80
        public void .cctor(){} // RVA: 0x7439F60
    }

    public class ThemeStyleSheet
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x74770C0
        public void .ctor(){} // RVA: 0x74770F0
    }

    public class TimeMsFunction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1B072F0
        public void Invoke(){} // RVA: 0x33BA50
    }

    public class TimeValue
    {
        public float m_Value; // 0x10
        public 0x6583D478 m_Unit; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x1D26670
        public void get_unit(){} // RVA: 0x19689E0
        public void .ctor(){} // RVA: 0x2B60610 | overloaded x2
        public void op_Implicit(){} // RVA: 0x743BEF0
        public void op_Equality(){} // RVA: 0x743BF10
        public void op_Inequality(){} // RVA: 0x74651E0
        public void Equals(){} // RVA: 0x7469460 | overloaded x2
        public void GetHashCode(){} // RVA: 0x743C020
        public void ToString(){} // RVA: 0x7469510
    }

    public class TimerEventScheduler : Schedule
    {
        // ── Methods ──
        public void Schedule(){} // RVA: 0x743AB20
        public void RemovedScheduledItemAt(){} // RVA: 0x743ACE0
        public void Unschedule(){} // RVA: 0x743AD60
        public void PrivateUnSchedule(){} // RVA: 0x743AFF0
        public void UpdateScheduledEvents(){} // RVA: 0x743B100
        public void .ctor(){} // RVA: 0x743BC20
    }

    public class TimerState
    {
        public long <start>k__BackingField; // 0x10
        public long <now>k__BackingField; // 0x18

        // ── Methods ──
        public void get_start(){} // RVA: 0x1AD4690
        public void set_start(){} // RVA: 0x1B12320
        public void get_now(){} // RVA: 0x19689C0
        public void set_now(){} // RVA: 0x1EE8D20
        public void get_deltaTime(){} // RVA: 0x743A610
        public void Equals(){} // RVA: 0x743A6C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x743A6F0
    }

    public class Toggle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73CB210 | overloaded x2
        public void InitLabel(){} // RVA: 0x73CB330
        public void UpdateMixedValueContent(){} // RVA: 0x73CB3B0
        public void .cctor(){} // RVA: 0x73CB560
    }

    public class TooltipEvent
    {
        public string <tooltip>k__BackingField; // 0x88
        public UnityEngine.Rect <rect>k__BackingField; // 0x90

        // ── Methods ──
        public void .cctor(){} // RVA: 0x73FA260
        public void set_tooltip(){} // RVA: 0x463060
        public void set_rect(){} // RVA: 0x20365D0
        public void Init(){} // RVA: 0x73FA350
        public void LocalInit(){} // RVA: 0x73FA410
        public void .ctor(){} // RVA: 0x73FA4C0
    }

    public class TouchScreenTextEditorEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73A4420
        public void PollTouchScreenKeyboard(){} // RVA: 0x73A4490
        public void DoPollTouchScreenKeyboard(){} // RVA: 0x73A4620
        public void UpdateStringPositionFromKeyboard(){} // RVA: 0x73A4BB0
        public void CloseTouchScreenKeyboard(){} // RVA: 0x73A4CF0
        public void OpenTouchScreenKeyboard(){} // RVA: 0x73A4E60
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x73A5170
        public void OnPointerDownEvent(){} // RVA: 0x73A5450
        public void OnPointerUpEvent(){} // RVA: 0x73A55B0
        public void OnFocusInEvent(){} // RVA: 0x73A55D0
        public void OnFocusOutEvent(){} // RVA: 0x73A57F0
    }

    public class TransformData
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7462170
        public void CopyFrom(){} // RVA: 0x74621A0
        public void op_Equality(){} // RVA: 0x74621D0
        public void Equals(){} // RVA: 0x7462690 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7462760
    }

    public class TransformOrigin
    {
        public UnityEngine.UIElements.Length m_X; // 0x10
        public UnityEngine.UIElements.Length m_Y; // 0x18
        public float m_Z; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74696A0
        public void Initial(){} // RVA: 0x74696B0
        public void get_x(){} // RVA: 0x1AD4690
        public void set_x(){} // RVA: 0x1B12320
        public void get_y(){} // RVA: 0x19689C0
        public void set_y(){} // RVA: 0x1EE8D20
        public void get_z(){} // RVA: 0x407320
        public void op_Equality(){} // RVA: 0x7469730
        public void op_Inequality(){} // RVA: 0x74697D0
        public void Equals(){} // RVA: 0x7469910 | overloaded x2
        public void GetHashCode(){} // RVA: 0x74699B0
        public void ToString(){} // RVA: 0x7469A30
    }

    public class TransitionCancelEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73FB0C0
        public void .ctor(){} // RVA: 0x73FB1B0
    }

    public class TransitionData
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x74628E0
        public void CopyFrom(){} // RVA: 0x7462BB0
        public void op_Equality(){} // RVA: 0x7462DA0
        public void Equals(){} // RVA: 0x7462E30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7462EE0
    }

    public class TransitionEndEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73FAE80
        public void .ctor(){} // RVA: 0x73FAF70
    }

    public class TransitionEventBase`1
    {
        public UnityEngine.UIElements.StylePropertyNameCollection <stylePropertyNames>k__BackingField;
        public double <elapsedTime>k__BackingField;

        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x283FA0
        public void set_elapsedTime(){} // RVA: 0x26100
        public void .ctor(){} // RVA: 0x24A50
        public void Init(){} // RVA: 0x24A50
        public void LocalInit(){} // RVA: 0x24A50
        public void GetPooled(){} // RVA: 0x283FA0
    }

    public class TransitionEventBase`1
    {
        public UnityEngine.UIElements.StylePropertyNameCollection <stylePropertyNames>k__BackingField; // 0x88
        public double <elapsedTime>k__BackingField; // 0x90

        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x31C010
        public void set_elapsedTime(){} // RVA: 0x4420B20
        public void .ctor(){} // RVA: 0x4420B30
        public void Init(){} // RVA: 0x4420D10
        public void LocalInit(){} // RVA: 0x4420E10
        public void GetPooled(){} // RVA: 0x4420EA0
    }

    public class TransitionEventBase`1
    {
        public UnityEngine.UIElements.StylePropertyNameCollection <stylePropertyNames>k__BackingField; // 0x88
        public double <elapsedTime>k__BackingField; // 0x90

        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x31C010
        public void set_elapsedTime(){} // RVA: 0x4420B20
        public void .ctor(){} // RVA: 0x4420B30
        public void Init(){} // RVA: 0x4420D10
        public void LocalInit(){} // RVA: 0x4420E10
        public void GetPooled(){} // RVA: 0x4420EA0
    }

    public class TransitionEventBase`1
    {
        public UnityEngine.UIElements.StylePropertyNameCollection <stylePropertyNames>k__BackingField; // 0x88
        public double <elapsedTime>k__BackingField; // 0x90

        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x31C010
        public void set_elapsedTime(){} // RVA: 0x4420B20
        public void .ctor(){} // RVA: 0x4420B30
        public void Init(){} // RVA: 0x4420D10
        public void LocalInit(){} // RVA: 0x4420E10
        public void GetPooled(){} // RVA: 0x4420EA0
    }

    public class TransitionEventBase`1
    {
        public UnityEngine.UIElements.StylePropertyNameCollection <stylePropertyNames>k__BackingField; // 0x88
        public double <elapsedTime>k__BackingField; // 0x90

        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x31C010
        public void set_elapsedTime(){} // RVA: 0x4420B20
        public void .ctor(){} // RVA: 0x4420B30
        public void Init(){} // RVA: 0x4420D10
        public void LocalInit(){} // RVA: 0x4420E10
        public void GetPooled(){} // RVA: 0x4420EA0
    }

    public class TransitionRunEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73FAA00
        public void .ctor(){} // RVA: 0x73FAAF0
    }

    public class TransitionStartEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73FAC40
        public void .ctor(){} // RVA: 0x73FAD30
    }

    public class Translate
    {
        public UnityEngine.UIElements.Length m_X; // 0x10
        public UnityEngine.UIElements.Length m_Y; // 0x18
        public float m_Z; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7469BC0
        public void None(){} // RVA: 0x7469BE0
        public void get_x(){} // RVA: 0x1AD4690
        public void set_x(){} // RVA: 0x1B12320
        public void get_y(){} // RVA: 0x19689C0
        public void set_y(){} // RVA: 0x1EE8D20
        public void get_z(){} // RVA: 0x407320
        public void op_Equality(){} // RVA: 0x7469C10
        public void op_Inequality(){} // RVA: 0x7469D20
        public void Equals(){} // RVA: 0x7469DC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x74699B0
        public void ToString(){} // RVA: 0x7469E80
    }

    public class TreeDataController`1
    {
        // ── Methods ──
        public void SetRootItems(){} // RVA: 0x24B10
        public void GetDataForId(){} // RVA: 0x283FA0
        public void GetParentId(){} // RVA: 0x13FB0
        public void HasChildren(){} // RVA: 0xE1F0
        public void GetItemIds(){} // RVA: 0xCE50
        public void GetChildrenIds(){} // RVA: 0x1BCC0
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x24A50
    }

    public class TreeData`1
    {
        public System.Collections.Generic.IList`1<int> id;

        // ── Methods ──
        public void get_rootItemIds(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24B10
        public void GetDataForId(){} // RVA: 0x283FA0
        public void GetParentId(){} // RVA: 0x13FB0
        public void Move(){}
        public void HasAncestor(){}
        public void AddItemToParent(){} // RVA: 0x283FA0
        public void RemoveFromParent(){} // RVA: 0x26EE0
        public void UpdateParentTree(){} // RVA: 0x283FA0
        public void RefreshTree(){} // RVA: 0x24B10
        public void BuildTree(){} // RVA: 0x2A620
    }

    public class TreeItem
    {
        public int <id>k__BackingField; // 0x10
        public int <parentId>k__BackingField; // 0x14
        public System.Collections.Generic.IEnumerable`1<int> <childrenIds>k__BackingField; // 0x18

        // ── Methods ──
        public void get_id(){} // RVA: 0x19689B0
        public void get_parentId(){} // RVA: 0x19689E0
        public void get_childrenIds(){} // RVA: 0x19689C0
        public void get_hasChildren(){} // RVA: 0x73CC120
        public void .ctor(){} // RVA: 0x49DB570
    }

    public class TreeView
    {
        public System.Func`1<UnityEngine.UIElements.VisualElement> m_MakeItem; // 0x4C0
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> m_BindItem; // 0x4C8
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> <unbindItem>k__BackingField; // 0x4D0
        public System.Action`1<UnityEngine.UIElements.VisualElement> <destroyItem>k__BackingField; // 0x4D8

        // ── Methods ──
        public void get_makeItem(){} // RVA: 0xD95090
        public void set_makeItem(){} // RVA: 0x73CBCA0
        public void get_bindItem(){} // RVA: 0xD95D00
        public void set_bindItem(){} // RVA: 0x73CBD50
        public void get_unbindItem(){} // RVA: 0xD99BE0
        public void get_destroyItem(){} // RVA: 0xD87580
        public void HasValidDataAndBindings(){} // RVA: 0x73CBE00
        public void CreateViewController(){} // RVA: 0x73CBE60
        public void .ctor(){} // RVA: 0x73CBF00 | overloaded x2
    }

    public class TreeViewController
    {
        // ── Methods ──
        public void get_treeView(){} // RVA: 0x72F3D00
        public void MakeItem(){} // RVA: 0x72F3D90
        public void BindItem(){} // RVA: 0x72F3ED0
        public void UnbindItem(){} // RVA: 0x72F40A0
        public void DestroyItem(){} // RVA: 0x72F40F0
        public void .ctor(){} // RVA: 0x2BC2970
    }

    public class TreeViewItemData`1
    {
        public int <id>k__BackingField;
        public T m_Data;
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.TreeViewItemData`1<T>> m_Children;

        // ── Methods ──
        public void get_id(){} // RVA: 0xD840
        public void get_data(){} // RVA: 0x283FA0
        public void get_children(){} // RVA: 0xCD60
        public void get_hasChildren(){} // RVA: 0xDBE0
        public void InsertChild(){} // RVA: 0x283FA0
        public void RemoveChild(){} // RVA: 0x24FA0
        public void GetChildIndex(){} // RVA: 0x13FB0
        public void ReplaceChild(){} // RVA: 0x283FA0
    }

    public class TreeViewItemWrapper
    {
        public UnityEngine.UIElements.TreeItem item; // 0x10
        public int depth; // 0x20

        // ── Methods ──
        public void get_id(){} // RVA: 0x19689B0
        public void get_childrenIds(){} // RVA: 0x19689C0
        public void get_hasChildren(){} // RVA: 0x73CC120
        public void .ctor(){} // RVA: 0x73CC170
    }

    public class TreeViewReorderableDragAndDropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73E0B20
        public void CompareId(){} // RVA: 0x73E0CD0
        public void SetupDragAndDrop(){} // RVA: 0x73E1390
        public void HandleDragAndDrop(){} // RVA: 0x73E1520
        public void OnDrop(){} // RVA: 0x73E15E0
        public void DragCleanup(){} // RVA: 0x73E1D10
        public void RestoreExpanded(){} // RVA: 0x73E1E60
        public void HandleAutoExpand(){} // RVA: 0x73E2100
        public void DelayExpandDropItem(){} // RVA: 0x73E2360
        public void ExpandDropItem(){} // RVA: 0x73E2460
    }

    public class TwoPaneSplitView
    {
        public string s_UssClassName;
        public string s_ContentContainerClassName; // 0x8
        public string s_HandleDragLineClassName; // 0x10
        public string s_HandleDragLineVerticalClassName; // 0x18
        public string s_HandleDragLineHorizontalClassName; // 0x20
        public string s_HandleDragLineAnchorClassName; // 0x28

        // ── Methods ──
        public void get_fixedPane(){} // RVA: 0xDA0010
        public void get_flexedPane(){} // RVA: 0xD98840
        public void get_fixedPaneIndex(){} // RVA: 0x73CC1D0
        public void get_orientation(){} // RVA: 0x73CC1E0
        public void get_fixedPaneDimension(){} // RVA: 0x73CC1F0
        public void set_fixedPaneDimension(){} // RVA: 0x73CC220
        public void .ctor(){} // RVA: 0x73CC240
        public void Init(){} // RVA: 0x73CC6E0
        public void OnPostDisplaySetup(){} // RVA: 0x73CCB40
        public void PostDisplaySetup(){} // RVA: 0x73CCC40
        public void OnSizeChange(){} // RVA: 0x73CDCC0
        public void UpdateLayout(){} // RVA: 0x73CDCD0
        public void get_contentContainer(){} // RVA: 0x73CE160
        public void OnViewDataReady(){} // RVA: 0x73CE170
        public void SetDragLineOffset(){} // RVA: 0x73CE1A0
        public void SetFixedPaneDimension(){} // RVA: 0x73CE370
        public void .cctor(){} // RVA: 0x73CE540
    }

    public class TwoPaneSplitViewResizer
    {
        public UnityEngine.Vector3 m_Start; // 0x38
        public bool m_Active; // 0x44
        public UnityEngine.UIElements.TwoPaneSplitView m_SplitView; // 0x48
        public int m_Direction; // 0x50

        // ── Methods ──
        public void get_orientation(){} // RVA: 0x73CF050
        public void get_fixedPane(){} // RVA: 0x73CF070
        public void get_flexedPane(){} // RVA: 0x73CF090
        public void get_fixedPaneMinDimension(){} // RVA: 0x73CF0B0
        public void get_fixedPaneMargins(){} // RVA: 0x73CF140
        public void get_flexedPaneMinDimension(){} // RVA: 0x73CF220
        public void get_flexedPaneMargin(){} // RVA: 0x73CF2B0
        public void .ctor(){} // RVA: 0x73CF390
        public void RegisterCallbacksOnTarget(){} // RVA: 0x73CF4F0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x73CF690
        public void ApplyDelta(){} // RVA: 0x73CF820
        public void OnPointerDown(){} // RVA: 0x73CFF30
        public void OnPointerMove(){} // RVA: 0x73CFFF0
        public void OnPointerUp(){} // RVA: 0x73D0110
    }

    public class TypedUxmlAttributeDescription`1
    {
        public T <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x263BC0
        public void get_defaultValue(){} // RVA: 0x263BC0
        public void set_defaultValue(){} // RVA: 0x36AEE20
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public T <defaultValue>k__BackingField;

        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x283FA0
        public void get_defaultValue(){} // RVA: 0x283FA0
        public void set_defaultValue(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class TypedUxmlAttributeDescription`1
    {
        public System.Type <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x35A740
        public void set_defaultValue(){} // RVA: 0x305200
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public string <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x35A740
        public void set_defaultValue(){} // RVA: 0x305200
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public float <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x7D0490
        public void set_defaultValue(){} // RVA: 0x7D04A0
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public double <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x1F65E70
        public void set_defaultValue(){} // RVA: 0x1F65E80
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public int <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x37E080
        public void set_defaultValue(){} // RVA: 0x37E090
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public uint <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x37E080
        public void set_defaultValue(){} // RVA: 0x37E090
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public ulong <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x35A740
        public void set_defaultValue(){} // RVA: 0x36B37A0
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public long <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x35A740
        public void set_defaultValue(){} // RVA: 0x36B37A0
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public bool <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x398C00
        public void set_defaultValue(){} // RVA: 0x398C10
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public UnityEngine.Hash128 <defaultValue>k__BackingField; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){}
        public void get_defaultValue(){} // RVA: 0x1FA6340
        public void set_defaultValue(){} // RVA: 0x4469B20
        public void .ctor(){} // RVA: 0x4469AC0
    }

    public class TypedUxmlAttributeDescription`1
    {
        public UnityEngine.Hash128 <defaultValue>k__BackingField; // 0x40
    }

}