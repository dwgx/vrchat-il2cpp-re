// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 42
// Methods: 431

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class TemplateAsset : VisualElementAsset
    {
        public string attributeOverrides; // 0x70
        public System.Collections.Generic.List`1<AttributeOverride> slotUsages; // 0x78
        public System.Collections.Generic.List`1<SlotUsageEntry> m_SlotUsages; // 0x80

        // ── Methods ──
        public void get_attributeOverrides(){} // RVA: 0x7FFAC9C26E80
        public void get_slotUsages(){} // RVA: 0x7FFAC991FBE0
    }

    public class TemplateContainer : BindableElement
    {
        public string templateId; // 0x3D8
        public UnityEngine.UIElements.VisualElement templateSource; // 0x3E0
        public UnityEngine.UIElements.VisualTreeAsset contentContainer; // 0x3E8

        // ── Methods ──
        public void get_templateId(){} // RVA: 0x7FFAC39AD490
        public void set_templateId(){} // RVA: 0x7FFAC39B57F0
        public void set_templateSource(){} // RVA: 0x7FFAC39CD160
        public void .ctor(){} // RVA: 0x7FFAC9C0EAA0 | overloaded x2
        public void get_contentContainer(){} // RVA: 0x7FFAC9C0EBB0
        public void SetContentContainer(){} // RVA: 0x7FFAC39C52F0
    }

    public class TextEditingManipulator : Object
    {
        public UnityEngine.UIElements.TextElement touchScreenTextFieldChanged; // 0x10
        public UnityEngine.UIElements.TextEditorEventHandler editingEventHandler; // 0x18
        public UnityEngine.TextEditingUtilities editingUtilities; // 0x20
        public bool m_TouchScreenTextFieldInitialized; // 0x28
        public UnityEngine.UIElements.IVisualElementScheduledItem m_HardwareKeyboardPoller; // 0x30

        // ── Methods ──
        public void get_touchScreenTextFieldChanged(){} // RVA: 0x7FFAC9C0FF00
        public void .ctor(){} // RVA: 0x7FFAC9C0FF90
        public void InitTextEditorEventHandler(){} // RVA: 0x7FFAC9C10240
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFAC9C10530
        public void OnFocusInEvent(){} // RVA: 0x7FFAC9C10730
        public void OnFocusOutEvent(){} // RVA: 0x7FFAC9C10900
        public void <OnFocusInEvent>b__10_0(){} // RVA: 0x7FFAC9C109D0
    }

    public class TextEditorEventHandler : Object
    {
        public UnityEngine.UIElements.TextElement textElement; // 0x10
        public UnityEngine.TextEditingUtilities editingUtilities; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFAC2F21310
    }

    public class TextElement : BindableElement
    {
        public string uitkTextHandle;
        public UnityEngine.UIElements.UITKTextHandle text; // 0x3D8
        public string enableRichText; // 0x3E0
        public bool parseEscapeSequences; // 0x3E8
        public bool displayTooltipWhenElided; // 0x3E9
        public bool isElided; // 0x3EA
        public bool hasFocus; // 0x3EB
        public string UnityEngine.UIElements.INotifyValueChanged<System.String>.value; // 0x8
        public string edition; // 0x3F0
        public bool UnityEngine.UIElements.ITextEdition.multiline; // 0x3F8
        public UnityEngine.UIElements.TextEditingManipulator UnityEngine.UIElements.ITextEdition.keyboardType; // 0x400
        public bool UnityEngine.UIElements.ITextEdition.hideMobileInput; // 0x408
        public UnityEngine.TouchScreenKeyboard UnityEngine.UIElements.ITextEdition.isReadOnly; // 0x410
        public 0x6B180430 UnityEngine.UIElements.ITextEdition.maxLength; // 0x418
        public bool UnityEngine.UIElements.ITextEdition.isDelayed; // 0x41C
        public bool UnityEngine.UIElements.ITextEdition.AcceptCharacter; // 0x41D
        public int UnityEngine.UIElements.ITextEdition.UpdateScrollOffset; // 0x420
        public bool UnityEngine.UIElements.ITextEdition.UpdateValueFromText; // 0x424
        public System.Func`2<char,bool> UnityEngine.UIElements.ITextEdition.UpdateTextFromValue; // 0x428
        public System.Action`1<bool> UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot; // 0x430
        public System.Action UnityEngine.UIElements.ITextEdition.maskChar; // 0x438
        public System.Action effectiveMaskChar; // 0x440
        public System.Action UnityEngine.UIElements.ITextEdition.isPassword; // 0x448
        public string UnityEngine.UIElements.ITextEdition.autoCorrection; // 0x450
        public string renderedText; // 0x458
        public char originalText; // 0x460
        public bool selection; // 0x462
        public bool UnityEngine.UIElements.ITextSelection.isSelectable; // 0x463
        public UnityEngine.UIElements.TextSelectingManipulator UnityEngine.UIElements.ITextSelection.cursorIndex; // 0x468
        public bool UnityEngine.UIElements.ITextSelection.selectIndex; // 0x470
        public bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord; // 0x471
        public bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine; // 0x472
        public bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus; // 0x473
        public bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp; // 0x474
        public UnityEngine.Color UnityEngine.UIElements.ITextSelection.cursorPosition; // 0x478
        public UnityEngine.Color UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition; // 0x488
        public float UnityEngine.UIElements.ITextSelection.selectionColor; // 0x498

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C16830
        public void get_uitkTextHandle(){} // RVA: 0x7FFAC39AD490
        public void set_uitkTextHandle(){} // RVA: 0x7FFAC39B57F0
        public void OnGeometryChanged(){} // RVA: 0x7FFAC9C16BE0
        public void get_text(){} // RVA: 0x7FFAC9C16BF0
        public void set_text(){} // RVA: 0x7FFAC9C16C30
        public void get_enableRichText(){} // RVA: 0x7FFAC9AB0B90
        public void set_enableRichText(){} // RVA: 0x7FFAC9C16C90
        public void get_parseEscapeSequences(){} // RVA: 0x7FFAC9C16CE0
        public void set_parseEscapeSequences(){} // RVA: 0x7FFAC9C16CF0
        public void get_displayTooltipWhenElided(){} // RVA: 0x7FFAC9C16D40
        public void set_displayTooltipWhenElided(){} // RVA: 0x7FFAC9C16D50
        public void get_isElided(){} // RVA: 0x7FFAC9C16DA0
        public void set_isElided(){} // RVA: 0x7FFAC9C16DB0
        public void OnGenerateVisualContent(){} // RVA: 0x7FFAC9C16DC0
        public void ElideText(){} // RVA: 0x7FFAC9C170E0
        public void UpdateTooltip(){} // RVA: 0x7FFAC9C17560
        public void UpdateVisibleText(){} // RVA: 0x7FFAC9C175D0
        public void ShouldElide(){} // RVA: 0x7FFAC9C17800
        public void get_hasFocus(){} // RVA: 0x7FFAC9C17890
        public void MeasureTextSize(){} // RVA: 0x7FFAC9C17910
        public void DoMeasure(){} // RVA: 0x7FFAC9C17940
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value(){} // RVA: 0x7FFAC9C179B0
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(){} // RVA: 0x7FFAC9C17A00
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(){} // RVA: 0x7FFAC9C17BD0
        public void get_edition(){} // RVA: 0x7FFAC44F81E0
        public void UnityEngine.UIElements.ITextEdition.get_multiline(){} // RVA: 0x7FFAC7C4CCD0
        public void UnityEngine.UIElements.ITextEdition.set_multiline(){} // RVA: 0x7FFAC9C17DC0
        public void UnityEngine.UIElements.ITextEdition.get_keyboardType(){} // RVA: 0x7FFAC9C17E50
        public void UnityEngine.UIElements.ITextEdition.set_keyboardType(){} // RVA: 0x7FFAC9C17E60
        public void UnityEngine.UIElements.ITextEdition.get_hideMobileInput(){} // RVA: 0x7FFAC9C17E70
        public void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(){} // RVA: 0x7FFAC9C17F10
        public void UnityEngine.UIElements.ITextEdition.get_isReadOnly(){} // RVA: 0x7FFAC9C17FD0
        public void UnityEngine.UIElements.ITextEdition.set_isReadOnly(){} // RVA: 0x7FFAC9C17FF0
        public void ProcessMenuCommand(){} // RVA: 0x7FFAC9C180D0
        public void Cut(){} // RVA: 0x7FFAC9C182A0
        public void Copy(){} // RVA: 0x7FFAC9C182F0
        public void Paste(){} // RVA: 0x7FFAC9C18340
        public void BuildContextualMenu(){} // RVA: 0x7FFAC9C18390
        public void CutActionStatus(){} // RVA: 0x7FFAC9C18700
        public void CopyActionStatus(){} // RVA: 0x7FFAC9C18790
        public void PasteActionStatus(){} // RVA: 0x7FFAC9C18820
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFAC9C18880
        public void UnityEngine.UIElements.ITextEdition.get_maxLength(){} // RVA: 0x7FFAC9C18B50
        public void UnityEngine.UIElements.ITextEdition.set_maxLength(){} // RVA: 0x7FFAC9C18B60
        public void UnityEngine.UIElements.ITextEdition.get_isDelayed(){} // RVA: 0x7FFAC9C18BF0
        public void UnityEngine.UIElements.ITextEdition.set_isDelayed(){} // RVA: 0x7FFAC9C18C00
        public void UnityEngine.UIElements.ITextEdition.SaveValueAndText(){} // RVA: 0x7FFAC9C18C10
        public void UnityEngine.UIElements.ITextEdition.RestoreValueAndText(){} // RVA: 0x7FFAC9C18C90
        public void UnityEngine.UIElements.ITextEdition.get_AcceptCharacter(){} // RVA: 0x7FFAC39C8970
        public void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(){} // RVA: 0x7FFAC39BD8D0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset(){} // RVA: 0x7FFAC39C4820
        public void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(){} // RVA: 0x7FFAC39B3700
        public void UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText(){} // RVA: 0x7FFAC39B1510
        public void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(){} // RVA: 0x7FFAC39B05F0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue(){} // RVA: 0x7FFAC39C4300
        public void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(){} // RVA: 0x7FFAC39BD310
        public void UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot(){} // RVA: 0x7FFAC39BD8C0
        public void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(){} // RVA: 0x7FFAC39C6BC0
        public void UnityEngine.UIElements.ITextEdition.UpdateText(){} // RVA: 0x7FFAC9C18CB0
        public void UnityEngine.UIElements.ITextEdition.CullString(){} // RVA: 0x7FFAC9C19060
        public void UnityEngine.UIElements.ITextEdition.set_maskChar(){} // RVA: 0x7FFAC9C190E0
        public void get_effectiveMaskChar(){} // RVA: 0x7FFAC9C19170
        public void UnityEngine.UIElements.ITextEdition.get_isPassword(){} // RVA: 0x7FFAC9C191E0
        public void UnityEngine.UIElements.ITextEdition.set_isPassword(){} // RVA: 0x7FFAC9C191F0
        public void UnityEngine.UIElements.ITextEdition.get_autoCorrection(){} // RVA: 0x7FFAC9C19240
        public void UnityEngine.UIElements.ITextEdition.set_autoCorrection(){} // RVA: 0x7FFAC9C19250
        public void get_renderedText(){} // RVA: 0x7FFAC9C19260
        public void set_renderedText(){} // RVA: 0x7FFAC9C193C0
        public void get_originalText(){} // RVA: 0x7FFAC39C3E40
        public void get_selection(){} // RVA: 0x7FFAC44F81E0
        public void UnityEngine.UIElements.ITextSelection.get_isSelectable(){} // RVA: 0x7FFAC9C19460
        public void UnityEngine.UIElements.ITextSelection.set_isSelectable(){} // RVA: 0x7FFAC9C19480
        public void UnityEngine.UIElements.ITextSelection.get_cursorIndex(){} // RVA: 0x7FFAC9C194A0
        public void UnityEngine.UIElements.ITextSelection.set_cursorIndex(){} // RVA: 0x7FFAC9C19520
        public void UnityEngine.UIElements.ITextSelection.get_selectIndex(){} // RVA: 0x7FFAC9C195C0
        public void UnityEngine.UIElements.ITextSelection.set_selectIndex(){} // RVA: 0x7FFAC9C19640
        public void UnityEngine.UIElements.ITextSelection.SelectAll(){} // RVA: 0x7FFAC9C196E0
        public void UnityEngine.UIElements.ITextSelection.SelectNone(){} // RVA: 0x7FFAC9C19760
        public void UnityEngine.UIElements.ITextSelection.HasSelection(){} // RVA: 0x7FFAC9C19800
        public void UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord(){} // RVA: 0x7FFAC9C198B0
        public void UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine(){} // RVA: 0x7FFAC9C198C0
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus(){} // RVA: 0x7FFAC9C198D0
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(){} // RVA: 0x7FFAC9C198E0
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp(){} // RVA: 0x7FFAC9C198F0
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(){} // RVA: 0x7FFAC9C19900
        public void UnityEngine.UIElements.ITextSelection.get_cursorPosition(){} // RVA: 0x7FFAC9C19910
        public void UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition(){} // RVA: 0x7FFAC9C199C0
        public void UnityEngine.UIElements.ITextSelection.get_selectionColor(){} // RVA: 0x7FFAC9C19AA0
        public void UnityEngine.UIElements.ITextSelection.set_selectionColor(){} // RVA: 0x7FFAC9C19AB0
        public void UnityEngine.UIElements.ITextSelection.get_cursorColor(){} // RVA: 0x7FFAC9C19B60
        public void UnityEngine.UIElements.ITextSelection.set_cursorColor(){} // RVA: 0x7FFAC9C19B70
        public void UnityEngine.UIElements.ITextSelection.get_cursorWidth(){} // RVA: 0x7FFAC9C19C20
        public void get_selectingManipulator(){} // RVA: 0x7FFAC9C19C30
        public void DrawHighlighting(){} // RVA: 0x7FFAC9C19CF0
        public void DrawCaret(){} // RVA: 0x7FFAC9C1A5A0
        public void GetLastCharacterAt(){} // RVA: 0x7FFAC9C1AA30
        public void .cctor(){} // RVA: 0x7FFAC9C1AC90
    }

    public class TextField : TextInputBaseField`1
    {
        public string textInput;
        public string multiline; // 0x8
        public string value; // 0x10

        // ── Methods ──
        public void get_textInput(){} // RVA: 0x7FFAC9B3AAA0
        public void set_multiline(){} // RVA: 0x7FFAC9B3AB30
        public void .ctor(){} // RVA: 0x7FFAC9B3ABC0 | overloaded x3
        public void get_value(){} // RVA: 0x7FFAC9B3AE60
        public void set_value(){} // RVA: 0x7FFAC9B3AEB0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9B3AF70
        public void UpdateTextFromValue(){} // RVA: 0x7FFAC9B3B030
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC9B3B080
        public void OnViewDataReady(){} // RVA: 0x7FFAC9B3B260
        public void ValueToString(){} // RVA: 0x7FFAC3E92FB0
        public void StringToValue(){} // RVA: 0x7FFAC3E92FB0
        public void .cctor(){} // RVA: 0x7FFAC9B3B310
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> textInputBase;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> text;
        public int isReadOnly;
        public TextInputBase<T> isPasswordField;
        public string autoCorrection;
        public string hideMobileInput;
        public string keyboardType;
        public string textEdition;
        public string maxLength;
        public string isDelayed;
        public string maskChar;
        public string textInputUssName;
        public System.Action`1<bool> onIsReadOnlyChanged;

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0x7FFAC2C58E90
        public void get_text(){} // RVA: 0x7FFAC2C58E90
        public void set_text(){} // RVA: 0x7FFAC2C70A40
        public void add_onIsReadOnlyChanged(){} // RVA: 0x7FFAC2C70A40
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x7FFAC2C70A40
        public void get_isReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void set_isReadOnly(){} // RVA: 0x7FFAC2C71060
        public void set_isPasswordField(){} // RVA: 0x7FFAC2C71060
        public void set_autoCorrection(){} // RVA: 0x7FFAC2C71060
        public void set_hideMobileInput(){} // RVA: 0x7FFAC2C71060
        public void set_keyboardType(){} // RVA: 0x7FFAC2C70ED0
        public void get_textEdition(){} // RVA: 0x7FFAC2C58E90
        public void set_maxLength(){} // RVA: 0x7FFAC2C70ED0
        public void get_isDelayed(){} // RVA: 0x7FFAC2C59D00
        public void set_isDelayed(){} // RVA: 0x7FFAC2C71060
        public void set_maskChar(){} // RVA: 0x7FFAC2C70B70
        public void ValueToString(){} // RVA: 0x7FFAC2E8DC40
        public void StringToValue(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void OnFieldCustomStyleResolved(){} // RVA: 0x7FFAC2C70A40
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFAC2C70A40
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC2C70980
        public void UpdateValueFromText(){} // RVA: 0x7FFAC2C70980
        public void UpdateTextFromValue(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class TextSelectingManipulator : Object
    {
        public UnityEngine.TextSelectingUtilities isClicking; // 0x10
        public bool cursorIndex; // 0x18
        public UnityEngine.UIElements.TextElement selectIndex; // 0x20
        public UnityEngine.Vector2 m_ClickStartPosition; // 0x28
        public bool m_Dragged; // 0x30
        public bool m_IsClicking; // 0x31
        public int k_DragThresholdSqr;
        public int m_ConsecutiveMouseDownCount; // 0x34
        public long m_LastMouseDownTimeStamp; // 0x38
        public UnityEngine.Event m_ImguiEvent; // 0x40

        // ── Methods ──
        public void get_isClicking(){} // RVA: 0x7FFAC2F47470
        public void set_isClicking(){} // RVA: 0x7FFAC9C10A20
        public void .ctor(){} // RVA: 0x7FFAC9C10A30
        public void get_cursorIndex(){} // RVA: 0x7FFAC9C10F60
        public void set_cursorIndex(){} // RVA: 0x7FFAC9930970
        public void get_selectIndex(){} // RVA: 0x7FFAC9C10F80
        public void set_selectIndex(){} // RVA: 0x7FFAC99309E0
        public void OnRevealCursor(){} // RVA: 0x7FFAC9C10FA0
        public void OnSelectIndexChange(){} // RVA: 0x7FFAC9C10FF0
        public void OnCursorIndexChange(){} // RVA: 0x7FFAC9C11130
        public void RevealCursor(){} // RVA: 0x7FFAC9C11270
        public void HasSelection(){} // RVA: 0x7FFAC9C11290
        public void HasFocus(){} // RVA: 0x7FFAC9C112E0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFAC9C11300
        public void OnFocusEvent(){} // RVA: 0x7FFAC9C11730
        public void OnBlurEvent(){} // RVA: 0x7FFAC9C118E0
        public void OnKeyDown(){} // RVA: 0x7FFAC9C11940
        public void OnPointerDownEvent(){} // RVA: 0x7FFAC9C119B0
        public void OnPointerMoveEvent(){} // RVA: 0x7FFAC9C11D80
        public void OnPointerUpEvent(){} // RVA: 0x7FFAC9C11F40
        public void OnValidateCommandEvent(){} // RVA: 0x7FFAC9C12030
        public void OnExecuteCommandEvent(){} // RVA: 0x7FFAC9C12270
        public void MoveDistanceQualifiesForDrag(){} // RVA: 0x7FFAC9C12420
    }

    public class TextShadow : ValueType
    {
        public UnityEngine.Vector2 offset; // 0x10
        public float blurRadius; // 0x18
        public UnityEngine.Color color; // 0x1C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC9C1BA00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9C1BAD0
        public void op_Equality(){} // RVA: 0x7FFAC9C1BB50
        public void op_Inequality(){} // RVA: 0x7FFAC9C1BB80
        public void ToString(){} // RVA: 0x7FFAC9C1BC40
        public void LerpUnclamped(){} // RVA: 0x7FFAC9C1BD80
    }

    public class TextUtilities : Object
    {
        // ── Methods ──
        public void MeasureVisualElementTextSize(){} // RVA: 0x7FFAC9C157E0
        public void GetFontAsset(){} // RVA: 0x7FFAC9C15BE0
        public void IsFontAssigned(){} // RVA: 0x7FFAC9C15F90
        public void GetTextSettingsFrom(){} // RVA: 0x7FFAC9C160F0
        public void ConvertPixelUnitsToTextCoreRelativeUnits(){} // RVA: 0x7FFAC9C161C0
        public void GetTextCoreSettingsForElement(){} // RVA: 0x7FFAC9C16280
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        public UnityEngine.UIElements.UxmlBoolAttributeDescription m_IsReadOnly;
        public UnityEngine.UIElements.UxmlBoolAttributeDescription m_IsDelayed;

        // ── Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger textValueInput;
        public bool formatString;
        public bool value;

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x7FFAC2C58E90
        public void get_formatString(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C786D0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC2E8DC40
        public void StartDragging(){} // RVA: 0x7FFAC2C70980
        public void StopDragging(){} // RVA: 0x7FFAC2C70980
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void set_value(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateValueFromText(){} // RVA: 0x7FFAC2C70980
        public void UpdateTextFromValue(){} // RVA: 0x7FFAC2C70980
        public void OnIsReadOnlyChanged(){} // RVA: 0x7FFAC2C71060
        public void CanTryParse(){} // RVA: 0x7FFAC2C59F60
        public void AddLabelDragger(){} // RVA: 0x7FFAC2C70980
        public void EnableLabelDragger(){} // RVA: 0x7FFAC2C71060
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC2E8DC40
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC2C70A40
        public void OnViewDataReady(){} // RVA: 0x7FFAC2C70980
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFAC2C70980
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFAC2C70980
    }

    public class TextureId : ValueType
    {
        public int index; // 0x10
        public UnityEngine.UIElements.TextureId invalid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BD0350
        public void get_index(){} // RVA: 0x7FFAC9BD0360
        public void ConvertToGpu(){} // RVA: 0x7FFAC9BD0370
        public void Equals(){} // RVA: 0x7FFAC9BD03C0
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
        public void op_Equality(){} // RVA: 0x7FFAC98B7FA0
        public void op_Inequality(){} // RVA: 0x7FFAC9BD0460
        public void .cctor(){} // RVA: 0x7FFAC9BD04C0
    }

    public class TextureRegistry : Object
    {
        public System.Collections.Generic.List`1<TextureInfo> instance; // 0x10
        public System.Collections.Generic.Dictionary`2<UnityEngine.Texture,UnityEngine.UIElements.TextureId> m_TextureToId; // 0x18
        public System.Collections.Generic.Stack`1<UnityEngine.UIElements.TextureId> m_FreeIds; // 0x20
        public int maxTextures;
        public UnityEngine.UIElements.TextureRegistry <instance>k__BackingField;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAC9BD0500
        public void GetTexture(){} // RVA: 0x7FFAC9BD0560
        public void AllocAndAcquireDynamic(){} // RVA: 0x7FFAC9BD07A0
        public void UpdateDynamic(){} // RVA: 0x7FFAC9BD07B0
        public void AllocAndAcquire(){} // RVA: 0x7FFAC9BD0AF0
        public void Acquire(){} // RVA: 0x7FFAC9BD0F00
        public void Release(){} // RVA: 0x7FFAC9BD10D0
        public void .ctor(){} // RVA: 0x7FFAC9BD1470
        public void .cctor(){} // RVA: 0x7FFAC9BD1850
    }

    public class ThemeStyleSheet : StyleSheet
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAC9C0EA10
        public void .ctor(){} // RVA: 0x7FFAC9C0EA40
    }

    public class TimeMsFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AD07E0
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class TimeValue : ValueType
    {
        public float value; // 0x10
        public 0x6B1224F8 unit; // 0x14

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC484C150
        public void get_unit(){} // RVA: 0x7FFAC44202A0
        public void .ctor(){} // RVA: 0x7FFAC553F750 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC9BD37E0
        public void op_Equality(){} // RVA: 0x7FFAC9BD3800
        public void op_Inequality(){} // RVA: 0x7FFAC9BFCB30
        public void Equals(){} // RVA: 0x7FFAC9C00DB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BD3910
        public void ToString(){} // RVA: 0x7FFAC9C00E60
    }

    public class TimerEventScheduler : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.ScheduledItem> m_ScheduledItems; // 0x10
        public bool m_TransactionMode; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UIElements.ScheduledItem> m_ScheduleTransactions; // 0x20
        public System.Collections.Generic.HashSet`1<UnityEngine.UIElements.ScheduledItem> m_UnscheduleTransactions; // 0x28
        public bool disableThrottling; // 0x30
        public int m_LastUpdatedIndex; // 0x34

        // ── Methods ──
        public void Schedule(){} // RVA: 0x7FFAC9BD2410
        public void RemovedScheduledItemAt(){} // RVA: 0x7FFAC9BD25D0
        public void Unschedule(){} // RVA: 0x7FFAC9BD2650
        public void PrivateUnSchedule(){} // RVA: 0x7FFAC9BD28E0
        public void UpdateScheduledEvents(){} // RVA: 0x7FFAC9BD29F0
        public void .ctor(){} // RVA: 0x7FFAC9BD3510
    }

    public class TimerState : ValueType
    {
        public long start; // 0x10
        public long now; // 0x18

        // ── Methods ──
        public void get_start(){} // RVA: 0x7FFAC3AD9F60
        public void set_start(){} // RVA: 0x7FFAC45BB120
        public void get_now(){} // RVA: 0x7FFAC4420220
        public void set_now(){} // RVA: 0x7FFAC4A068C0
        public void get_deltaTime(){} // RVA: 0x7FFAC9BD1F00
        public void Equals(){} // RVA: 0x7FFAC9BD1FB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BD1FE0
    }

    public class Toggle : BaseBoolField
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string noTextVariantUssClassName; // 0x18
        public string checkmarkUssClassName; // 0x20
        public string textUssClassName; // 0x28
        public string mixedValuesUssClassName; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B62B10 | overloaded x2
        public void InitLabel(){} // RVA: 0x7FFAC9B62C30
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC9B62CB0
        public void .cctor(){} // RVA: 0x7FFAC9B62E60
    }

    public class TooltipEvent : EventBase`1
    {
        public string tooltip; // 0x88
        public UnityEngine.Rect rect; // 0x90

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B91B50
        public void set_tooltip(){} // RVA: 0x7FFAC354E300
        public void set_rect(){} // RVA: 0x7FFAC4B59740
        public void Init(){} // RVA: 0x7FFAC9B91C40
        public void LocalInit(){} // RVA: 0x7FFAC9B91D00
        public void .ctor(){} // RVA: 0x7FFAC9B91DB0
    }

    public class TouchScreenTextEditorEventHandler : TextEditorEventHandler
    {
        public UnityEngine.UIElements.IVisualElementScheduledItem m_TouchKeyboardPoller; // 0x20
        public bool m_TouchKeyboardAllowsInPlaceEditing; // 0x28
        public bool m_IsClicking; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B3BD00
        public void PollTouchScreenKeyboard(){} // RVA: 0x7FFAC9B3BD70
        public void DoPollTouchScreenKeyboard(){} // RVA: 0x7FFAC9B3BF00
        public void UpdateStringPositionFromKeyboard(){} // RVA: 0x7FFAC9B3C490
        public void CloseTouchScreenKeyboard(){} // RVA: 0x7FFAC9B3C5D0
        public void OpenTouchScreenKeyboard(){} // RVA: 0x7FFAC9B3C740
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFAC9B3CA50
        public void OnPointerDownEvent(){} // RVA: 0x7FFAC9B3CD30
        public void OnPointerUpEvent(){} // RVA: 0x7FFAC9B3CE90
        public void OnFocusInEvent(){} // RVA: 0x7FFAC9B3CEB0
        public void OnFocusOutEvent(){} // RVA: 0x7FFAC9B3D0D0
    }

    public class TransformData : ValueType
    {
        public UnityEngine.UIElements.Rotate rotate; // 0x10
        public UnityEngine.UIElements.Scale scale; // 0x28
        public UnityEngine.UIElements.TransformOrigin transformOrigin; // 0x38
        public UnityEngine.UIElements.Translate translate; // 0x4C

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAC9BF9AC0
        public void CopyFrom(){} // RVA: 0x7FFAC9BF9AF0
        public void op_Equality(){} // RVA: 0x7FFAC9BF9B20
        public void Equals(){} // RVA: 0x7FFAC9BF9FE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFA0B0
    }

    public class TransformOrigin : ValueType
    {
        public UnityEngine.UIElements.Length x; // 0x10
        public UnityEngine.UIElements.Length y; // 0x18
        public float z; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C00FF0
        public void Initial(){} // RVA: 0x7FFAC9C01000
        public void get_x(){} // RVA: 0x7FFAC3AD9F60
        public void set_x(){} // RVA: 0x7FFAC45BB120
        public void get_y(){} // RVA: 0x7FFAC4420220
        public void set_y(){} // RVA: 0x7FFAC4A068C0
        public void get_z(){} // RVA: 0x7FFAC304B320
        public void op_Equality(){} // RVA: 0x7FFAC9C01080
        public void op_Inequality(){} // RVA: 0x7FFAC9C01120
        public void Equals(){} // RVA: 0x7FFAC9C01260 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9C01300
        public void ToString(){} // RVA: 0x7FFAC9C01380
    }

    public class TransitionCancelEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B929B0
        public void .ctor(){} // RVA: 0x7FFAC9B92AA0
    }

    public class TransitionData : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue> transitionDelay; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.TimeValue> transitionDuration; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName> transitionProperty; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UIElements.EasingFunction> transitionTimingFunction; // 0x28

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAC9BFA230
        public void CopyFrom(){} // RVA: 0x7FFAC9BFA500
        public void op_Equality(){} // RVA: 0x7FFAC9BFA6F0
        public void Equals(){} // RVA: 0x7FFAC9BFA780 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFA830
    }

    public class TransitionEndEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B92770
        public void .ctor(){} // RVA: 0x7FFAC9B92860
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.StylePropertyNameCollection stylePropertyNames;
        public double elapsedTime;

        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x7FFAC2E8DC40
        public void set_elapsedTime(){} // RVA: 0x7FFAC2C72080
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TransitionRunEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B922F0
        public void .ctor(){} // RVA: 0x7FFAC9B923E0
    }

    public class TransitionStartEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B92530
        public void .ctor(){} // RVA: 0x7FFAC9B92620
    }

    public class Translate : ValueType
    {
        public UnityEngine.UIElements.Length x; // 0x10
        public UnityEngine.UIElements.Length y; // 0x18
        public float z; // 0x20
        public bool m_isNone; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C01510
        public void None(){} // RVA: 0x7FFAC9C01530
        public void get_x(){} // RVA: 0x7FFAC3AD9F60
        public void set_x(){} // RVA: 0x7FFAC45BB120
        public void get_y(){} // RVA: 0x7FFAC4420220
        public void set_y(){} // RVA: 0x7FFAC4A068C0
        public void get_z(){} // RVA: 0x7FFAC304B320
        public void op_Equality(){} // RVA: 0x7FFAC9C01560
        public void op_Inequality(){} // RVA: 0x7FFAC9C01670
        public void Equals(){} // RVA: 0x7FFAC9C01710 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9C01300
        public void ToString(){} // RVA: 0x7FFAC9C017D0
    }

    public class TreeDataController`1 : Object
    {
        public UnityEngine.UIElements.TreeData`1<T> m_TreeData;
        public System.Collections.Generic.Stack`1<System.Collections.Generic.IEnumerator`1<int>> m_IteratorStack;

        // ── Methods ──
        public void SetRootItems(){} // RVA: 0x7FFAC2C70A40
        public void GetDataForId(){} // RVA: 0x7FFAC2E8DC40
        public void GetParentId(){} // RVA: 0x7FFAC2C600D0
        public void HasChildren(){} // RVA: 0x7FFAC2C5A310
        public void GetItemIds(){} // RVA: 0x7FFAC2C58F80
        public void GetChildrenIds(){} // RVA: 0x7FFAC2C67DE0
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class TreeData`1 : ValueType
    {
        public System.Collections.Generic.IList`1<int> rootItemIds;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.UIElements.TreeViewItemData`1<T>> m_Tree;
        public System.Collections.Generic.Dictionary`2<int,int> m_ParentIds;
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<int>> m_ChildrenIds;

        // ── Methods ──
        public void get_rootItemIds(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void GetDataForId(){} // RVA: 0x7FFAC2E8DC40
        public void GetParentId(){} // RVA: 0x7FFAC2C600D0
        public void Move(){}
        public void HasAncestor(){}
        public void AddItemToParent(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveFromParent(){} // RVA: 0x7FFAC2C72E60
        public void UpdateParentTree(){} // RVA: 0x7FFAC2E8DC40
        public void RefreshTree(){} // RVA: 0x7FFAC2C70A40
        public void BuildTree(){} // RVA: 0x7FFAC2C76500
    }

    public class TreeItem : ValueType
    {
        public int id; // 0x10
        public int parentId; // 0x14
        public System.Collections.Generic.IEnumerable`1<int> childrenIds; // 0x18

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC4420210
        public void get_parentId(){} // RVA: 0x7FFAC44202A0
        public void get_childrenIds(){} // RVA: 0x7FFAC4420220
        public void get_hasChildren(){} // RVA: 0x7FFAC9B63A20
        public void .ctor(){} // RVA: 0x7FFAC721C1A0
    }

    public class TreeView : BaseTreeView
    {
        public System.Func`1<UnityEngine.UIElements.VisualElement> makeItem; // 0x4C0
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> bindItem; // 0x4C8
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> unbindItem; // 0x4D0
        public System.Action`1<UnityEngine.UIElements.VisualElement> destroyItem; // 0x4D8

        // ── Methods ──
        public void get_makeItem(){} // RVA: 0x7FFAC39CA190
        public void set_makeItem(){} // RVA: 0x7FFAC9B635A0
        public void get_bindItem(){} // RVA: 0x7FFAC39C3BB0
        public void set_bindItem(){} // RVA: 0x7FFAC9B63650
        public void get_unbindItem(){} // RVA: 0x7FFAC39BEF50
        public void get_destroyItem(){} // RVA: 0x7FFAC39BC630
        public void HasValidDataAndBindings(){} // RVA: 0x7FFAC9B63700
        public void CreateViewController(){} // RVA: 0x7FFAC9B63760
        public void .ctor(){} // RVA: 0x7FFAC9B63800 | overloaded x2
    }

    public class TreeViewController : BaseTreeViewController
    {
        public object treeView;

        // ── Methods ──
        public void get_treeView(){} // RVA: 0x7FFAC9A8B5E0
        public void MakeItem(){} // RVA: 0x7FFAC9A8B670
        public void BindItem(){} // RVA: 0x7FFAC9A8B7B0
        public void UnbindItem(){} // RVA: 0x7FFAC9A8B980
        public void DestroyItem(){} // RVA: 0x7FFAC9A8B9D0
        public void .ctor(){} // RVA: 0x7FFAC55752E0
    }

    public class TreeViewItemData`1 : ValueType
    {
        public int id;
        public T data;
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.TreeViewItemData`1<T>> children;

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC2C59960
        public void get_data(){} // RVA: 0x7FFAC2E8DC40
        public void get_children(){} // RVA: 0x7FFAC2C58E90
        public void get_hasChildren(){} // RVA: 0x7FFAC2C59D00
        public void InsertChild(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveChild(){} // RVA: 0x7FFAC2C70ED0
        public void GetChildIndex(){} // RVA: 0x7FFAC2C600D0
        public void ReplaceChild(){} // RVA: 0x7FFAC2E8DC40
    }

    public class TreeViewItemWrapper : ValueType
    {
        public UnityEngine.UIElements.TreeItem id; // 0x10
        public int childrenIds; // 0x20

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC4420210
        public void get_childrenIds(){} // RVA: 0x7FFAC4420220
        public void get_hasChildren(){} // RVA: 0x7FFAC9B63A20
        public void .ctor(){} // RVA: 0x7FFAC9B63A70
    }

    public class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        public DropData m_DropData; // 0x28
        public UnityEngine.UIElements.BaseTreeView m_TreeView; // 0x30
        public UnityEngine.UIElements.IVisualElementScheduledItem m_ExpandDropItemScheduledItem; // 0x38
        public System.Action m_ExpandDropItemCallback; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B78420
        public void CompareId(){} // RVA: 0x7FFAC9B785D0
        public void SetupDragAndDrop(){} // RVA: 0x7FFAC9B78C90
        public void HandleDragAndDrop(){} // RVA: 0x7FFAC9B78E20
        public void OnDrop(){} // RVA: 0x7FFAC9B78EE0
        public void DragCleanup(){} // RVA: 0x7FFAC9B79610
        public void RestoreExpanded(){} // RVA: 0x7FFAC9B79760
        public void HandleAutoExpand(){} // RVA: 0x7FFAC9B79A00
        public void DelayExpandDropItem(){} // RVA: 0x7FFAC9B79C60
        public void ExpandDropItem(){} // RVA: 0x7FFAC9B79D60
    }

    public class TwoPaneSplitView : VisualElement
    {
        public string fixedPane;
        public string flexedPane; // 0x8
        public string fixedPaneIndex; // 0x10
        public string orientation; // 0x18
        public string fixedPaneDimension; // 0x20
        public string contentContainer; // 0x28
        public string s_HandleDragLineAnchorVerticalClassName; // 0x30
        public string s_HandleDragLineAnchorHorizontalClassName; // 0x38
        public string s_VerticalClassName; // 0x40
        public string s_HorizontalClassName; // 0x48
        public UnityEngine.UIElements.VisualElement m_LeftPane; // 0x3C8
        public UnityEngine.UIElements.VisualElement m_RightPane; // 0x3D0
        public UnityEngine.UIElements.VisualElement m_FixedPane; // 0x3D8
        public UnityEngine.UIElements.VisualElement m_FlexedPane; // 0x3E0
        public float m_FixedPaneDimension; // 0x3E8
        public UnityEngine.UIElements.VisualElement m_DragLine; // 0x3F0
        public UnityEngine.UIElements.VisualElement m_DragLineAnchor; // 0x3F8
        public bool m_CollapseMode; // 0x400
        public UnityEngine.UIElements.VisualElement m_Content; // 0x408
        public 0x6B119D88 m_Orientation; // 0x410
        public int m_FixedPaneIndex; // 0x414
        public float m_FixedPaneInitialDimension; // 0x418
        public UnityEngine.UIElements.TwoPaneSplitViewResizer m_Resizer; // 0x420

        // ── Methods ──
        public void get_fixedPane(){} // RVA: 0x7FFAC39AD490
        public void get_flexedPane(){} // RVA: 0x7FFAC39BF4D0
        public void get_fixedPaneIndex(){} // RVA: 0x7FFAC9B63AD0
        public void get_orientation(){} // RVA: 0x7FFAC9B63AE0
        public void get_fixedPaneDimension(){} // RVA: 0x7FFAC9B63AF0
        public void set_fixedPaneDimension(){} // RVA: 0x7FFAC9B63B20
        public void .ctor(){} // RVA: 0x7FFAC9B63B40
        public void Init(){} // RVA: 0x7FFAC9B63FE0
        public void OnPostDisplaySetup(){} // RVA: 0x7FFAC9B64440
        public void PostDisplaySetup(){} // RVA: 0x7FFAC9B64540
        public void OnSizeChange(){} // RVA: 0x7FFAC9B655C0
        public void UpdateLayout(){} // RVA: 0x7FFAC9B655D0
        public void get_contentContainer(){} // RVA: 0x7FFAC9B65A60
        public void OnViewDataReady(){} // RVA: 0x7FFAC9B65A70
        public void SetDragLineOffset(){} // RVA: 0x7FFAC9B65AA0
        public void SetFixedPaneDimension(){} // RVA: 0x7FFAC9B65C70
        public void .cctor(){} // RVA: 0x7FFAC9B65E40
    }

    public class TwoPaneSplitViewResizer : PointerManipulator
    {
        public UnityEngine.Vector3 orientation; // 0x38
        public bool fixedPane; // 0x44
        public UnityEngine.UIElements.TwoPaneSplitView flexedPane; // 0x48
        public int fixedPaneMinDimension; // 0x50

        // ── Methods ──
        public void get_orientation(){} // RVA: 0x7FFAC9B66950
        public void get_fixedPane(){} // RVA: 0x7FFAC9B66970
        public void get_flexedPane(){} // RVA: 0x7FFAC9B66990
        public void get_fixedPaneMinDimension(){} // RVA: 0x7FFAC9B669B0
        public void get_fixedPaneMargins(){} // RVA: 0x7FFAC9B66A40
        public void get_flexedPaneMinDimension(){} // RVA: 0x7FFAC9B66B20
        public void get_flexedPaneMargin(){} // RVA: 0x7FFAC9B66BB0
        public void .ctor(){} // RVA: 0x7FFAC9B66C90
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAC9B66DF0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAC9B66F90
        public void ApplyDelta(){} // RVA: 0x7FFAC9B67120
        public void OnPointerDown(){} // RVA: 0x7FFAC9B67830
        public void OnPointerMove(){} // RVA: 0x7FFAC9B678F0
        public void OnPointerUp(){} // RVA: 0x7FFAC9B67A10
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        public T defaultValue; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x7FFAC2E5B230
        public void get_defaultValue(){} // RVA: 0x7FFAC2E5B230
        public void set_defaultValue(){} // RVA: 0x7FFAC5FDBA30
        public void .ctor(){} // RVA: 0x7FFAC6D1E3D0
    }

}