// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 21
// Methods: 273

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class TemplateAsset : VisualElementAsset
    {
        public object m_SlotUsages; // 0x331C0030
        public object Capacity; // 0x170008CD

        // ── Original Methods ──
        public void get_attributeOverrides(){} // RVA: 0x7ffaaf648df0
        public void get_slotUsages(){} // RVA: 0x7ffaaf341b40
    }

    public class TextEditorEventHandler : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7ffaa8932310
    }

    public class TextElement : BindableElement
    {
        public object m_Text; // 0x312D1FB0
        public object m_DisplayTooltipWhenElided; // 0x312D1FB0
        public object elidedText; // 0x312D1FB0
        public object m_Multiline; // 0x312D1FB0
        public object m_HideMobileInput; // 0x312D1FB0
        public object _isDelayed; // 0x312D1FB0, was: <UnityEngine.UIElements.ITextE
        public object _updateValueFromText; // 0x312D1FB0, was: <UnityEngine.UIElements.ITextE
        public object m_RenderedText; // 0x312D1FB0
        public object m_IsPassword; // 0x312D1FB0
        public object m_IsSelectable; // 0x312D1FB0
        public object _selectAllOnFocus; // 0x312D1FB0, was: <UnityEngine.UIElements.ITextS
        public object m_CursorColor; // 0x312D1FB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf6387a0
        public void get_uitkTextHandle(){} // RVA: 0x7ffaa93d36d0
        public void set_uitkTextHandle(){} // RVA: 0x7ffaa93d2fe0
        public void OnGeometryChanged(){} // RVA: 0x7ffaaf638b50
        public void get_text(){} // RVA: 0x7ffaaf638b60
        public void set_text(){} // RVA: 0x7ffaaf638ba0
        public void get_enableRichText(){} // RVA: 0x7ffaaf4d2af0
        public void set_enableRichText(){} // RVA: 0x7ffaaf638c00
        public void get_parseEscapeSequences(){} // RVA: 0x7ffaaf638c50
        public void set_parseEscapeSequences(){} // RVA: 0x7ffaaf638c60
        public void get_displayTooltipWhenElided(){} // RVA: 0x7ffaaf638cb0
        public void set_displayTooltipWhenElided(){} // RVA: 0x7ffaaf638cc0
        public void get_isElided(){} // RVA: 0x7ffaaf638d10
        public void set_isElided(){} // RVA: 0x7ffaaf638d20
        public void OnGenerateVisualContent(){} // RVA: 0x7ffaaf638d30
        public void ElideText(){} // RVA: 0x7ffaaf639050
        public void UpdateTooltip(){} // RVA: 0x7ffaaf6394d0
        public void UpdateVisibleText(){} // RVA: 0x7ffaaf639540
        public void ShouldElide(){} // RVA: 0x7ffaaf639770
        public void get_hasFocus(){} // RVA: 0x7ffaaf639800
        public void MeasureTextSize(){} // RVA: 0x7ffaaf639880
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value(){} // RVA: 0x7ffaaf639920
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(){} // RVA: 0x7ffaaf639970
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(){} // RVA: 0x7ffaaf639b40
        public void get_edition(){} // RVA: 0x7ffaa9f19100
        public void UnityEngine.UIElements.ITextEdition.get_multiline(){} // RVA: 0x7ffaad676e30
        public void UnityEngine.UIElements.ITextEdition.set_multiline(){} // RVA: 0x7ffaaf639d30
        public void UnityEngine.UIElements.ITextEdition.get_keyboardType(){} // RVA: 0x7ffaaf639dc0
        public void UnityEngine.UIElements.ITextEdition.set_keyboardType(){} // RVA: 0x7ffaaf639dd0
        public void UnityEngine.UIElements.ITextEdition.get_hideMobileInput(){} // RVA: 0x7ffaaf639de0
        public void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(){} // RVA: 0x7ffaaf639e80
        public void UnityEngine.UIElements.ITextEdition.get_isReadOnly(){} // RVA: 0x7ffaaf639f40
        public void UnityEngine.UIElements.ITextEdition.set_isReadOnly(){} // RVA: 0x7ffaaf639f60
        public void ProcessMenuCommand(){} // RVA: 0x7ffaaf63a040
        public void Cut(){} // RVA: 0x7ffaaf63a210
        public void Copy(){} // RVA: 0x7ffaaf63a260
        public void Paste(){} // RVA: 0x7ffaaf63a2b0
        public void BuildContextualMenu(){} // RVA: 0x7ffaaf63a300
        public void CutActionStatus(){} // RVA: 0x7ffaaf63a670
        public void CopyActionStatus(){} // RVA: 0x7ffaaf63a700
        public void PasteActionStatus(){} // RVA: 0x7ffaaf63a790
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7ffaaf63a7f0
        public void UnityEngine.UIElements.ITextEdition.get_maxLength(){} // RVA: 0x7ffaaf63aac0
        public void UnityEngine.UIElements.ITextEdition.set_maxLength(){} // RVA: 0x7ffaaf63aad0
        public void UnityEngine.UIElements.ITextEdition.get_isDelayed(){} // RVA: 0x7ffaaf63ab60
        public void UnityEngine.UIElements.ITextEdition.set_isDelayed(){} // RVA: 0x7ffaaf63ab70
        public void UnityEngine.UIElements.ITextEdition.SaveValueAndText(){} // RVA: 0x7ffaaf63ab80
        public void UnityEngine.UIElements.ITextEdition.RestoreValueAndText(){} // RVA: 0x7ffaaf63ac00
        public void UnityEngine.UIElements.ITextEdition.get_AcceptCharacter(){} // RVA: 0x7ffaa93d6ae0
        public void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(){} // RVA: 0x7ffaa94006f0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset(){} // RVA: 0x7ffaa9401000
        public void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(){} // RVA: 0x7ffaa93d7650
        public void UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText(){} // RVA: 0x7ffaa93f0ba0
        public void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(){} // RVA: 0x7ffaa93d3670
        public void UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue(){} // RVA: 0x7ffaa93ff1f0
        public void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(){} // RVA: 0x7ffaa93ee270
        public void UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot(){} // RVA: 0x7ffaa93faee0
        public void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(){} // RVA: 0x7ffaa93f1230
        public void UnityEngine.UIElements.ITextEdition.UpdateText(){} // RVA: 0x7ffaaf63ac20
        public void UnityEngine.UIElements.ITextEdition.CullString(){} // RVA: 0x7ffaaf63afd0
        public void UnityEngine.UIElements.ITextEdition.set_maskChar(){} // RVA: 0x7ffaaf63b050
        public void get_effectiveMaskChar(){} // RVA: 0x7ffaaf63b0e0
        public void UnityEngine.UIElements.ITextEdition.get_isPassword(){} // RVA: 0x7ffaaf63b150
        public void UnityEngine.UIElements.ITextEdition.set_isPassword(){} // RVA: 0x7ffaaf63b160
        public void UnityEngine.UIElements.ITextEdition.get_autoCorrection(){} // RVA: 0x7ffaaf63b1b0
        public void UnityEngine.UIElements.ITextEdition.set_autoCorrection(){} // RVA: 0x7ffaaf63b1c0
        public void get_renderedText(){} // RVA: 0x7ffaaf63b1d0
        public void set_renderedText(){} // RVA: 0x7ffaaf63b330
        public void get_originalText(){} // RVA: 0x7ffaa93fcb50
        public void get_selection(){} // RVA: 0x7ffaa9f19100
        public void UnityEngine.UIElements.ITextSelection.get_isSelectable(){} // RVA: 0x7ffaaf63b3d0
        public void UnityEngine.UIElements.ITextSelection.set_isSelectable(){} // RVA: 0x7ffaaf63b3f0
        public void UnityEngine.UIElements.ITextSelection.get_cursorIndex(){} // RVA: 0x7ffaaf63b410
        public void UnityEngine.UIElements.ITextSelection.set_cursorIndex(){} // RVA: 0x7ffaaf63b490
        public void UnityEngine.UIElements.ITextSelection.get_selectIndex(){} // RVA: 0x7ffaaf63b530
        public void UnityEngine.UIElements.ITextSelection.set_selectIndex(){} // RVA: 0x7ffaaf63b5b0
        public void UnityEngine.UIElements.ITextSelection.SelectAll(){} // RVA: 0x7ffaaf63b650
        public void UnityEngine.UIElements.ITextSelection.SelectNone(){} // RVA: 0x7ffaaf63b6d0
        public void UnityEngine.UIElements.ITextSelection.HasSelection(){} // RVA: 0x7ffaaf63b770
        public void UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord(){} // RVA: 0x7ffaaf63b820
        public void UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine(){} // RVA: 0x7ffaaf63b830
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus(){} // RVA: 0x7ffaaf63b840
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(){} // RVA: 0x7ffaaf63b850
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp(){} // RVA: 0x7ffaaf63b860
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(){} // RVA: 0x7ffaaf63b870
        public void UnityEngine.UIElements.ITextSelection.get_cursorPosition(){} // RVA: 0x7ffaaf63b880
        public void UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition(){} // RVA: 0x7ffaaf63b930
        public void UnityEngine.UIElements.ITextSelection.get_selectionColor(){} // RVA: 0x7ffaaf63ba10
        public void UnityEngine.UIElements.ITextSelection.set_selectionColor(){} // RVA: 0x7ffaaf63ba20
        public void UnityEngine.UIElements.ITextSelection.get_cursorColor(){} // RVA: 0x7ffaaf63bad0
        public void UnityEngine.UIElements.ITextSelection.set_cursorColor(){} // RVA: 0x7ffaaf63bae0
        public void UnityEngine.UIElements.ITextSelection.get_cursorWidth(){} // RVA: 0x7ffaaf63bb90
        public void get_selectingManipulator(){} // RVA: 0x7ffaaf63bba0
        public void DrawHighlighting(){} // RVA: 0x7ffaaf63bc60
        public void DrawCaret(){} // RVA: 0x7ffaaf63c510
        public void .cctor(){} // RVA: 0x7ffaaf63cc00
        // ── Binary Analysis Named ──
        public void DoMeasure(){} // RVA: 0x7ffaaf6398b0
        public void GetLastCharacterAt(){} // RVA: 0x7ffaaf63c9a0
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        public object m_VisualInputTabIndex; // 0x313DACB8
        public object labelUssClassName; // 0x313DACB8
        public object singleLineInputUssClassName; // 0x313DACB8
        public object textInputUssName; // 0x313DACB8
        public object m_ForceUpdateDisplay; // 0x31440030
        public object m_ForceUpdateDisplay; // 0x839ED230

        // ── Original Methods ──
        public void get_textInputBase(){} // RVA: 0x7ffaac69e580
        public void get_text(){} // RVA: 0x7ffaac69e5b0
        public void set_text(){} // RVA: 0x7ffaac69e620
        public void add_onIsReadOnlyChanged(){} // RVA: 0x7ffaac69e680
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x7ffaac69e7f0
        public void get_isReadOnly(){} // RVA: 0x7ffaac69e960
        public void set_isReadOnly(){} // RVA: 0x7ffaac69e9f0
        public void set_isPasswordField(){} // RVA: 0x7ffaac69ead0
        public void set_autoCorrection(){} // RVA: 0x7ffaac69ec00
        public void set_hideMobileInput(){} // RVA: 0x7ffaac69eca0
        public void set_keyboardType(){} // RVA: 0x7ffaac69ed40
        public void get_textEdition(){} // RVA: 0x7ffaac69edd0
        public void set_maxLength(){} // RVA: 0x7ffaac69ee40
        public void get_isDelayed(){} // RVA: 0x7ffaac69eed0
        public void set_isDelayed(){} // RVA: 0x7ffaac69ef60
        public void set_maskChar(){} // RVA: 0x7ffaac69f000
        public void ValueToString(){} // RVA: 0x7ffaa887e5c0
        public void StringToValue(){} // RVA: 0x7ffaa884bb60
        public void .ctor(){} // RVA: 0x7ffaac69f0a0
        public void OnFieldCustomStyleResolved(){} // RVA: 0x7ffaac69f4b0
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7ffaac69f510
        public void UpdateMixedValueContent(){} // RVA: 0x7ffaac69fb60
        public void UpdateValueFromText(){} // RVA: 0x7ffaac69fec0
        public void UpdateTextFromValue(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaac69ffd0
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        public object m_VisualInputTabIndex; // 0x313EAE40
        public object labelUssClassName; // 0x313EAE40
        public object singleLineInputUssClassName; // 0x313EAE40
        public object textInputUssName; // 0x313EAE40
        public object s_CursorColorProperty; // 0x839EDB78
        public object ussClassName; // 0x839EDB78

        // ── Original Methods ──
        public void get_textInputBase(){} // RVA: 0x7ffaa86491d0
        public void get_text(){} // RVA: 0x7ffaa86491d0
        public void set_text(){} // RVA: 0x7ffaa8660d80
        public void add_onIsReadOnlyChanged(){} // RVA: 0x7ffaa8660d80
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x7ffaa8660d80
        public void get_isReadOnly(){} // RVA: 0x7ffaa864a040
        public void set_isReadOnly(){} // RVA: 0x7ffaa86613a0
        public void set_isPasswordField(){} // RVA: 0x7ffaa86613a0
        public void set_autoCorrection(){} // RVA: 0x7ffaa86613a0
        public void set_hideMobileInput(){} // RVA: 0x7ffaa86613a0
        public void set_keyboardType(){} // RVA: 0x7ffaa8661210
        public void get_textEdition(){} // RVA: 0x7ffaa86491d0
        public void set_maxLength(){} // RVA: 0x7ffaa8661210
        public void get_isDelayed(){} // RVA: 0x7ffaa864a040
        public void set_isDelayed(){} // RVA: 0x7ffaa86613a0
        public void set_maskChar(){} // RVA: 0x7ffaa8660eb0
        public void ValueToString(){} // RVA: 0x7ffaa887e5c0
        public void StringToValue(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void OnFieldCustomStyleResolved(){} // RVA: 0x7ffaa8660d80
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7ffaa8660d80
        public void UpdateMixedValueContent(){} // RVA: 0x7ffaa8660cc0
        public void UpdateValueFromText(){} // RVA: 0x7ffaa8660cc0
        public void UpdateTextFromValue(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class TextShadow : ValueType
    {
        public object color; // 0x35BD8C80

        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaaf63d970
        public void Equals(){} // RVA: 0x7ffaaf63d970
        public void op_Equality(){} // RVA: 0x7ffaaf63dac0
        public void op_Inequality(){} // RVA: 0x7ffaaf63daf0
        public void ToString(){} // RVA: 0x7ffaaf63dbb0
        public void LerpUnclamped(){} // RVA: 0x7ffaaf63dcf0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf63da40
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        public object m_IsReadOnly; // 0x839D1350

        // ── Original Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        public object m_ForceUpdateDisplay; // 0x31440030

        // ── Original Methods ──
        public void get_textValueInput(){} // RVA: 0x7ffaa86491d0
        public void get_formatString(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8668a10
        public void ApplyInputDeviceDelta(){} // RVA: 0x7ffaa887e5c0
        public void StartDragging(){} // RVA: 0x7ffaa8660cc0
        public void StopDragging(){} // RVA: 0x7ffaa8660cc0
        public void get_value(){} // RVA: 0x7ffaa887e5c0
        public void set_value(){} // RVA: 0x7ffaa887e5c0
        public void UpdateValueFromText(){} // RVA: 0x7ffaa8660cc0
        public void UpdateTextFromValue(){} // RVA: 0x7ffaa8660cc0
        public void OnIsReadOnlyChanged(){} // RVA: 0x7ffaa86613a0
        public void CanTryParse(){} // RVA: 0x7ffaa864a2a0
        public void AddLabelDragger(){} // RVA: 0x7ffaa8660cc0
        public void EnableLabelDragger(){} // RVA: 0x7ffaa86613a0
        public void ExecuteDefaultAction(){} // RVA: 0x7ffaa8660d80
        public void OnViewDataReady(){} // RVA: 0x7ffaa8660cc0
        public void RegisterEditingCallbacks(){} // RVA: 0x7ffaa8660cc0
        public void UnregisterEditingCallbacks(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetValueWithoutNotify(){} // RVA: 0x7ffaa887e5c0
    }

    public class ThemeStyleSheet : StyleSheet
    {
        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaaf630980
        public void .ctor(){} // RVA: 0x7ffaaf6309b0
    }

    public class TransformData : ValueType
    {
        public object transformOrigin; // 0x35BDB220
        public object m_Axis; // 0x35BDB3D0

        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaaf61ba30
        public void CopyFrom(){} // RVA: 0x7ffaaf61ba60
        public void op_Equality(){} // RVA: 0x7ffaaf61ba90
        public void Equals(){} // RVA: 0x7ffaaf61bf50
        public void Equals(){} // RVA: 0x7ffaaf61bf50
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf61c020
    }

    public class TransformOrigin : ValueType
    {
        public object m_Z; // 0x35BDBB30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf622f60
        public void Initial(){} // RVA: 0x7ffaaf622f70
        public void get_x(){} // RVA: 0x7ffaa950bda0
        public void set_x(){} // RVA: 0x7ffaa9fe08a0
        public void get_y(){} // RVA: 0x7ffaa9e47540
        public void set_y(){} // RVA: 0x7ffaaa40d8d0
        public void get_z(){} // RVA: 0x7ffaa8a5c320
        public void op_Equality(){} // RVA: 0x7ffaaf622ff0
        public void op_Inequality(){} // RVA: 0x7ffaaf623090
        public void Equals(){} // RVA: 0x7ffaaf6231d0
        public void Equals(){} // RVA: 0x7ffaaf6231d0
        public void ToString(){} // RVA: 0x7ffaaf6232f0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf623270
    }

    public class TransitionData : ValueType
    {
        public object transitionProperty; // 0x35C00030

        // ── Original Methods ──
        public void Copy(){} // RVA: 0x7ffaaf61c1a0
        public void CopyFrom(){} // RVA: 0x7ffaaf61c470
        public void op_Equality(){} // RVA: 0x7ffaaf61c660
        public void Equals(){} // RVA: 0x7ffaaf61c6f0
        public void Equals(){} // RVA: 0x7ffaaf61c6f0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf61c7a0
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        // ── Original Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x7ffaa887e5c0
        public void set_elapsedTime(){} // RVA: 0x7ffaa86623c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class Translate : ValueType
    {
        public object m_Z; // 0x35BDBCC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf623480
        public void None(){} // RVA: 0x7ffaaf6234a0
        public void get_x(){} // RVA: 0x7ffaa950bda0
        public void set_x(){} // RVA: 0x7ffaa9fe08a0
        public void get_y(){} // RVA: 0x7ffaa9e47540
        public void set_y(){} // RVA: 0x7ffaaa40d8d0
        public void get_z(){} // RVA: 0x7ffaa8a5c320
        public void op_Equality(){} // RVA: 0x7ffaaf6234d0
        public void op_Inequality(){} // RVA: 0x7ffaaf6235e0
        public void Equals(){} // RVA: 0x7ffaaf623680
        public void Equals(){} // RVA: 0x7ffaaf623680
        public void ToString(){} // RVA: 0x7ffaaf623740
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaf623270
    }

    public class TreeDataController`1 : Object
    {
        // ── Original Methods ──
        public void HasChildren(){} // RVA: 0x7ffaa864a650
        public void Move(){}
        public void IsChildOf(){}
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetRootItems(){} // RVA: 0x7ffaa8660d80
        public void GetDataForId(){} // RVA: 0x7ffaa887e5c0
        public void GetParentId(){} // RVA: 0x7ffaa8650410
        public void GetItemIds(){} // RVA: 0x7ffaa86492c0
        public void GetChildrenIds(){} // RVA: 0x7ffaa8658120
        public void GetAllItemIds(){} // RVA: 0x7ffaa8649280
    }

    public class TreeData`1 : ValueType
    {
        public object m_ParentIds; // 0x31442630

        // ── Original Methods ──
        public void get_rootItemIds(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Move(){}
        public void HasAncestor(){}
        public void AddItemToParent(){} // RVA: 0x7ffaa887e5c0
        public void RemoveFromParent(){} // RVA: 0x7ffaa86631a0
        public void UpdateParentTree(){} // RVA: 0x7ffaa887e5c0
        public void RefreshTree(){} // RVA: 0x7ffaa8660d80
        public void BuildTree(){} // RVA: 0x7ffaa8666840
        // ── Binary Analysis Named ──
        public void GetDataForId(){} // RVA: 0x7ffaa887e5c0
        public void GetParentId(){} // RVA: 0x7ffaa8650410
    }

    public class TreeViewController : BaseTreeViewController
    {
        // ── Original Methods ──
        public void get_treeView(){} // RVA: 0x7ffaaf4ad540
        public void MakeItem(){} // RVA: 0x7ffaaf4ad5d0
        public void BindItem(){} // RVA: 0x7ffaaf4ad710
        public void UnbindItem(){} // RVA: 0x7ffaaf4ad8e0
        public void DestroyItem(){} // RVA: 0x7ffaaf4ad930
        public void .ctor(){} // RVA: 0x7ffaaaf7b6b0
    }

    public class TreeViewItemData`1 : ValueType
    {
        public object m_Children; // 0x314427B0
        public object id; // 0x17000182

        // ── Original Methods ──
        public void get_id(){} // RVA: 0x7ffaa8649ca0
        public void get_data(){} // RVA: 0x7ffaa887e5c0
        public void get_children(){} // RVA: 0x7ffaa86491d0
        public void get_hasChildren(){} // RVA: 0x7ffaa864a040
        public void InsertChild(){} // RVA: 0x7ffaa887e5c0
        public void RemoveChild(){} // RVA: 0x7ffaa8661210
        public void ReplaceChild(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetChildIndex(){} // RVA: 0x7ffaa8650410
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Original Methods ──
        public void get_defaultValue(){} // RVA: 0x7ffaa884bb60
        public void set_defaultValue(){} // RVA: 0x7ffaab9ed1a0
        public void .ctor(){} // RVA: 0x7ffaac72f370
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){} // RVA: 0x7ffaa884bb60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Original Methods ──
        public void get_defaultValue(){} // RVA: 0x7ffaa887e5c0
        public void set_defaultValue(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){} // RVA: 0x7ffaa887e5c0
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Original Methods ──
        public void get_defaultValue(){} // RVA: 0x7ffaa89af740
        public void set_defaultValue(){} // RVA: 0x7ffaa895a200
        public void .ctor(){} // RVA: 0x7ffaac72f370
        // ── Binary Analysis Named ──
        public void GetValueFromBag(){}
    }

}