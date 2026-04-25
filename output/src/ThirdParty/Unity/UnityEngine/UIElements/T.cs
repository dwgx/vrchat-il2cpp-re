// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 18
// Methods: 240

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class TemplateAsset : VisualElementAsset
    {
        public string attributeOverrides; // 0x70
        public System.Collections.Generic.List`1<0x664850A0> slotUsages; // 0x78
        public System.Collections.Generic.List`1<0x66486178> m_SlotUsages; // 0x80

        // ── Methods ──
        public void get_attributeOverrides(){} // RVA: 0x7FFD55046E80
        public void get_slotUsages(){} // RVA: 0x7FFD54D3FBE0
    }

    public class TextEditorEventHandler : Object
    {
        public UnityEngine.UIElements.TextElement textElement; // 0x10
        public 0x665E0298 editingUtilities; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFD4E341310
    }

    public class TextElement : BindableElement
    {
        public string uitkTextHandle;
        public 0x66484288 text; // 0x3D8
        public string enableRichText; // 0x3E0
        public bool parseEscapeSequences; // 0x3E8
        public bool displayTooltipWhenElided; // 0x3E9
        public bool isElided; // 0x3EA
        public bool hasFocus; // 0x3EB
        public string UnityEngine.UIElements.INotifyValueChanged<System.String>.value; // 0x8
        public string edition; // 0x3F0
        public bool UnityEngine.UIElements.ITextEdition.multiline; // 0x3F8
        public 0x664841D8 UnityEngine.UIElements.ITextEdition.keyboardType; // 0x400
        public bool UnityEngine.UIElements.ITextEdition.hideMobileInput; // 0x408
        public 0x664E03D8 UnityEngine.UIElements.ITextEdition.isReadOnly; // 0x410
        public 0x664E0430 UnityEngine.UIElements.ITextEdition.maxLength; // 0x418
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
        public 0x66484230 UnityEngine.UIElements.ITextSelection.cursorIndex; // 0x468
        public bool UnityEngine.UIElements.ITextSelection.selectIndex; // 0x470
        public bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord; // 0x471
        public bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine; // 0x472
        public bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus; // 0x473
        public bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp; // 0x474
        public UnityEngine.Color UnityEngine.UIElements.ITextSelection.cursorPosition; // 0x478
        public UnityEngine.Color UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition; // 0x488
        public float UnityEngine.UIElements.ITextSelection.selectionColor; // 0x498

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55036830
        public void get_uitkTextHandle(){} // RVA: 0x7FFD4EDCD490
        public void set_uitkTextHandle(){} // RVA: 0x7FFD4EDD57F0
        public void OnGeometryChanged(){} // RVA: 0x7FFD55036BE0
        public void get_text(){} // RVA: 0x7FFD55036BF0
        public void set_text(){} // RVA: 0x7FFD55036C30
        public void get_enableRichText(){} // RVA: 0x7FFD54ED0B90
        public void set_enableRichText(){} // RVA: 0x7FFD55036C90
        public void get_parseEscapeSequences(){} // RVA: 0x7FFD55036CE0
        public void set_parseEscapeSequences(){} // RVA: 0x7FFD55036CF0
        public void get_displayTooltipWhenElided(){} // RVA: 0x7FFD55036D40
        public void set_displayTooltipWhenElided(){} // RVA: 0x7FFD55036D50
        public void get_isElided(){} // RVA: 0x7FFD55036DA0
        public void set_isElided(){} // RVA: 0x7FFD55036DB0
        public void OnGenerateVisualContent(){} // RVA: 0x7FFD55036DC0
        public void ElideText(){} // RVA: 0x7FFD550370E0
        public void UpdateTooltip(){} // RVA: 0x7FFD55037560
        public void UpdateVisibleText(){} // RVA: 0x7FFD550375D0
        public void ShouldElide(){} // RVA: 0x7FFD55037800
        public void get_hasFocus(){} // RVA: 0x7FFD55037890
        public void MeasureTextSize(){} // RVA: 0x7FFD55037910
        public void DoMeasure(){} // RVA: 0x7FFD55037940
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value(){} // RVA: 0x7FFD550379B0
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(){} // RVA: 0x7FFD55037A00
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(){} // RVA: 0x7FFD55037BD0
        public void get_edition(){} // RVA: 0x7FFD4F9181E0
        public void UnityEngine.UIElements.ITextEdition.get_multiline(){} // RVA: 0x7FFD5306CCD0
        public void UnityEngine.UIElements.ITextEdition.set_multiline(){} // RVA: 0x7FFD55037DC0
        public void UnityEngine.UIElements.ITextEdition.get_keyboardType(){} // RVA: 0x7FFD55037E50
        public void UnityEngine.UIElements.ITextEdition.set_keyboardType(){} // RVA: 0x7FFD55037E60
        public void UnityEngine.UIElements.ITextEdition.get_hideMobileInput(){} // RVA: 0x7FFD55037E70
        public void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(){} // RVA: 0x7FFD55037F10
        public void UnityEngine.UIElements.ITextEdition.get_isReadOnly(){} // RVA: 0x7FFD55037FD0
        public void UnityEngine.UIElements.ITextEdition.set_isReadOnly(){} // RVA: 0x7FFD55037FF0
        public void ProcessMenuCommand(){} // RVA: 0x7FFD550380D0
        public void Cut(){} // RVA: 0x7FFD550382A0
        public void Copy(){} // RVA: 0x7FFD550382F0
        public void Paste(){} // RVA: 0x7FFD55038340
        public void BuildContextualMenu(){} // RVA: 0x7FFD55038390
        public void CutActionStatus(){} // RVA: 0x7FFD55038700
        public void CopyActionStatus(){} // RVA: 0x7FFD55038790
        public void PasteActionStatus(){} // RVA: 0x7FFD55038820
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFD55038880
        public void UnityEngine.UIElements.ITextEdition.get_maxLength(){} // RVA: 0x7FFD55038B50
        public void UnityEngine.UIElements.ITextEdition.set_maxLength(){} // RVA: 0x7FFD55038B60
        public void UnityEngine.UIElements.ITextEdition.get_isDelayed(){} // RVA: 0x7FFD55038BF0
        public void UnityEngine.UIElements.ITextEdition.set_isDelayed(){} // RVA: 0x7FFD55038C00
        public void UnityEngine.UIElements.ITextEdition.SaveValueAndText(){} // RVA: 0x7FFD55038C10
        public void UnityEngine.UIElements.ITextEdition.RestoreValueAndText(){} // RVA: 0x7FFD55038C90
        public void UnityEngine.UIElements.ITextEdition.get_AcceptCharacter(){} // RVA: 0x7FFD4EDE8970
        public void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(){} // RVA: 0x7FFD4EDDD8D0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset(){} // RVA: 0x7FFD4EDE4820
        public void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(){} // RVA: 0x7FFD4EDD3700
        public void UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText(){} // RVA: 0x7FFD4EDD1510
        public void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(){} // RVA: 0x7FFD4EDD05F0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue(){} // RVA: 0x7FFD4EDE4300
        public void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(){} // RVA: 0x7FFD4EDDD310
        public void UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot(){} // RVA: 0x7FFD4EDDD8C0
        public void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(){} // RVA: 0x7FFD4EDE6BC0
        public void UnityEngine.UIElements.ITextEdition.UpdateText(){} // RVA: 0x7FFD55038CB0
        public void UnityEngine.UIElements.ITextEdition.CullString(){} // RVA: 0x7FFD55039060
        public void UnityEngine.UIElements.ITextEdition.set_maskChar(){} // RVA: 0x7FFD550390E0
        public void get_effectiveMaskChar(){} // RVA: 0x7FFD55039170
        public void UnityEngine.UIElements.ITextEdition.get_isPassword(){} // RVA: 0x7FFD550391E0
        public void UnityEngine.UIElements.ITextEdition.set_isPassword(){} // RVA: 0x7FFD550391F0
        public void UnityEngine.UIElements.ITextEdition.get_autoCorrection(){} // RVA: 0x7FFD55039240
        public void UnityEngine.UIElements.ITextEdition.set_autoCorrection(){} // RVA: 0x7FFD55039250
        public void get_renderedText(){} // RVA: 0x7FFD55039260
        public void set_renderedText(){} // RVA: 0x7FFD550393C0
        public void get_originalText(){} // RVA: 0x7FFD4EDE3E40
        public void get_selection(){} // RVA: 0x7FFD4F9181E0
        public void UnityEngine.UIElements.ITextSelection.get_isSelectable(){} // RVA: 0x7FFD55039460
        public void UnityEngine.UIElements.ITextSelection.set_isSelectable(){} // RVA: 0x7FFD55039480
        public void UnityEngine.UIElements.ITextSelection.get_cursorIndex(){} // RVA: 0x7FFD550394A0
        public void UnityEngine.UIElements.ITextSelection.set_cursorIndex(){} // RVA: 0x7FFD55039520
        public void UnityEngine.UIElements.ITextSelection.get_selectIndex(){} // RVA: 0x7FFD550395C0
        public void UnityEngine.UIElements.ITextSelection.set_selectIndex(){} // RVA: 0x7FFD55039640
        public void UnityEngine.UIElements.ITextSelection.SelectAll(){} // RVA: 0x7FFD550396E0
        public void UnityEngine.UIElements.ITextSelection.SelectNone(){} // RVA: 0x7FFD55039760
        public void UnityEngine.UIElements.ITextSelection.HasSelection(){} // RVA: 0x7FFD55039800
        public void UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord(){} // RVA: 0x7FFD550398B0
        public void UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine(){} // RVA: 0x7FFD550398C0
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus(){} // RVA: 0x7FFD550398D0
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(){} // RVA: 0x7FFD550398E0
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp(){} // RVA: 0x7FFD550398F0
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(){} // RVA: 0x7FFD55039900
        public void UnityEngine.UIElements.ITextSelection.get_cursorPosition(){} // RVA: 0x7FFD55039910
        public void UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition(){} // RVA: 0x7FFD550399C0
        public void UnityEngine.UIElements.ITextSelection.get_selectionColor(){} // RVA: 0x7FFD55039AA0
        public void UnityEngine.UIElements.ITextSelection.set_selectionColor(){} // RVA: 0x7FFD55039AB0
        public void UnityEngine.UIElements.ITextSelection.get_cursorColor(){} // RVA: 0x7FFD55039B60
        public void UnityEngine.UIElements.ITextSelection.set_cursorColor(){} // RVA: 0x7FFD55039B70
        public void UnityEngine.UIElements.ITextSelection.get_cursorWidth(){} // RVA: 0x7FFD55039C20
        public void get_selectingManipulator(){} // RVA: 0x7FFD55039C30
        public void DrawHighlighting(){} // RVA: 0x7FFD55039CF0
        public void DrawCaret(){} // RVA: 0x7FFD5503A5A0
        public void GetLastCharacterAt(){} // RVA: 0x7FFD5503AA30
        public void .cctor(){} // RVA: 0x7FFD5503AC90
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> textInputBase;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> text; // 0x8
        public int isReadOnly; // 0x440
        public TextInputBase<T> isPasswordField; // 0x448
        public string autoCorrection; // 0x10
        public string hideMobileInput; // 0x18
        public string keyboardType; // 0x20
        public string textEdition; // 0x28
        public string maxLength; // 0x30
        public string isDelayed; // 0x38
        public string maskChar; // 0x40
        public string textInputUssName; // 0x48
        public System.Action`1<bool> onIsReadOnlyChanged; // 0x450

        // ── Methods ──
        public void get_textInputBase(){} // RVA: 0x7FFD4E078E90
        public void get_text(){} // RVA: 0x7FFD4E078E90
        public void set_text(){} // RVA: 0x7FFD4E090A40
        public void add_onIsReadOnlyChanged(){} // RVA: 0x7FFD4E090A40
        public void remove_onIsReadOnlyChanged(){} // RVA: 0x7FFD4E090A40
        public void get_isReadOnly(){} // RVA: 0x7FFD4E079D00
        public void set_isReadOnly(){} // RVA: 0x7FFD4E091060
        public void set_isPasswordField(){} // RVA: 0x7FFD4E091060
        public void set_autoCorrection(){} // RVA: 0x7FFD4E091060
        public void set_hideMobileInput(){} // RVA: 0x7FFD4E091060
        public void set_keyboardType(){} // RVA: 0x7FFD4E090ED0
        public void get_textEdition(){} // RVA: 0x7FFD4E078E90
        public void set_maxLength(){} // RVA: 0x7FFD4E090ED0
        public void get_isDelayed(){} // RVA: 0x7FFD4E079D00
        public void set_isDelayed(){} // RVA: 0x7FFD4E091060
        public void set_maskChar(){} // RVA: 0x7FFD4E090B70
        public void ValueToString(){} // RVA: 0x7FFD4E2ADC40
        public void StringToValue(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void OnFieldCustomStyleResolved(){} // RVA: 0x7FFD4E090A40
        public void ExecuteDefaultActionAtTarget(){} // RVA: 0x7FFD4E090A40
        public void UpdateMixedValueContent(){} // RVA: 0x7FFD4E090980
        public void UpdateValueFromText(){} // RVA: 0x7FFD4E090980
        public void UpdateTextFromValue(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class TextShadow : ValueType
    {
        public UnityEngine.Vector2 offset; // 0x10
        public float blurRadius; // 0x18
        public UnityEngine.Color color; // 0x1C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD5503BA00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5503BAD0
        public void op_Equality(){} // RVA: 0x7FFD5503BB50
        public void op_Inequality(){} // RVA: 0x7FFD5503BB80
        public void ToString(){} // RVA: 0x7FFD5503BC40
        public void LerpUnclamped(){} // RVA: 0x7FFD5503BD80
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        public 0x66485780 m_IsReadOnly;
        public 0x66485780 m_IsDelayed;

        // ── Methods ──
        public void Init(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        public UnityEngine.UIElements.BaseFieldMouseDragger textValueInput;
        public bool formatString;
        public bool value;

        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x7FFD4E078E90
        public void get_formatString(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E0986D0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFD4E2ADC40
        public void StartDragging(){} // RVA: 0x7FFD4E090980
        public void StopDragging(){} // RVA: 0x7FFD4E090980
        public void get_value(){} // RVA: 0x7FFD4E2ADC40
        public void set_value(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateValueFromText(){} // RVA: 0x7FFD4E090980
        public void UpdateTextFromValue(){} // RVA: 0x7FFD4E090980
        public void OnIsReadOnlyChanged(){} // RVA: 0x7FFD4E091060
        public void CanTryParse(){} // RVA: 0x7FFD4E079F60
        public void AddLabelDragger(){} // RVA: 0x7FFD4E090980
        public void EnableLabelDragger(){} // RVA: 0x7FFD4E091060
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD4E2ADC40
        public void ExecuteDefaultAction(){} // RVA: 0x7FFD4E090A40
        public void OnViewDataReady(){} // RVA: 0x7FFD4E090980
        public void RegisterEditingCallbacks(){} // RVA: 0x7FFD4E090980
        public void UnregisterEditingCallbacks(){} // RVA: 0x7FFD4E090980
    }

    public class ThemeStyleSheet : StyleSheet
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD5502EA10
        public void .ctor(){} // RVA: 0x7FFD5502EA40
    }

    public class TransformData : ValueType
    {
        public UnityEngine.UIElements.Rotate rotate; // 0x10
        public UnityEngine.UIElements.Scale scale; // 0x28
        public UnityEngine.UIElements.TransformOrigin transformOrigin; // 0x38
        public UnityEngine.UIElements.Translate translate; // 0x4C

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFD55019AC0
        public void CopyFrom(){} // RVA: 0x7FFD55019AF0
        public void op_Equality(){} // RVA: 0x7FFD55019B20
        public void Equals(){} // RVA: 0x7FFD55019FE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5501A0B0
    }

    public class TransformOrigin : ValueType
    {
        public UnityEngine.UIElements.Length x; // 0x10
        public UnityEngine.UIElements.Length y; // 0x18
        public float z; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55020FF0
        public void Initial(){} // RVA: 0x7FFD55021000
        public void get_x(){} // RVA: 0x7FFD4EEF9F60
        public void set_x(){} // RVA: 0x7FFD4F9DB120
        public void get_y(){} // RVA: 0x7FFD4F840220
        public void set_y(){} // RVA: 0x7FFD4FE268C0
        public void get_z(){} // RVA: 0x7FFD4E46B320
        public void op_Equality(){} // RVA: 0x7FFD55021080
        public void op_Inequality(){} // RVA: 0x7FFD55021120
        public void Equals(){} // RVA: 0x7FFD55021260 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD55021300
        public void ToString(){} // RVA: 0x7FFD55021380
    }

    public class TransitionData : ValueType
    {
        public System.Collections.Generic.List`1<0x66482550> transitionDelay; // 0x10
        public System.Collections.Generic.List`1<0x66482550> transitionDuration; // 0x18
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StylePropertyName> transitionProperty; // 0x20
        public System.Collections.Generic.List`1<0x66481370> transitionTimingFunction; // 0x28

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFD5501A230
        public void CopyFrom(){} // RVA: 0x7FFD5501A500
        public void op_Equality(){} // RVA: 0x7FFD5501A6F0
        public void Equals(){} // RVA: 0x7FFD5501A780 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5501A830
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        public UnityEngine.UIElements.StylePropertyNameCollection stylePropertyNames;
        public double elapsedTime;

        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0x7FFD4E2ADC40
        public void set_elapsedTime(){} // RVA: 0x7FFD4E092080
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Translate : ValueType
    {
        public UnityEngine.UIElements.Length x; // 0x10
        public UnityEngine.UIElements.Length y; // 0x18
        public float z; // 0x20
        public bool m_isNone; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD55021510
        public void None(){} // RVA: 0x7FFD55021530
        public void get_x(){} // RVA: 0x7FFD4EEF9F60
        public void set_x(){} // RVA: 0x7FFD4F9DB120
        public void get_y(){} // RVA: 0x7FFD4F840220
        public void set_y(){} // RVA: 0x7FFD4FE268C0
        public void get_z(){} // RVA: 0x7FFD4E46B320
        public void op_Equality(){} // RVA: 0x7FFD55021560
        public void op_Inequality(){} // RVA: 0x7FFD55021670
        public void Equals(){} // RVA: 0x7FFD55021710 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD55021300
        public void ToString(){} // RVA: 0x7FFD550217D0
    }

    public class TreeDataController`1 : Object
    {
        public UnityEngine.UIElements.TreeData`1<T> m_TreeData;
        public System.Collections.Generic.Stack`1<System.Collections.Generic.IEnumerator`1<int>> m_IteratorStack;

        // ── Methods ──
        public void SetRootItems(){} // RVA: 0x7FFD4E090A40
        public void GetDataForId(){} // RVA: 0x7FFD4E2ADC40
        public void GetParentId(){} // RVA: 0x7FFD4E0800D0
        public void HasChildren(){} // RVA: 0x7FFD4E07A310
        public void GetItemIds(){} // RVA: 0x7FFD4E078F80
        public void GetChildrenIds(){} // RVA: 0x7FFD4E087DE0
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class TreeData`1 : ValueType
    {
        public System.Collections.Generic.IList`1<int> rootItemIds;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.UIElements.TreeViewItemData`1<T>> m_Tree;
        public System.Collections.Generic.Dictionary`2<int,int> m_ParentIds;
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<int>> m_ChildrenIds;

        // ── Methods ──
        public void get_rootItemIds(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void GetDataForId(){} // RVA: 0x7FFD4E2ADC40
        public void GetParentId(){} // RVA: 0x7FFD4E0800D0
        public void Move(){}
        public void HasAncestor(){}
        public void AddItemToParent(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveFromParent(){} // RVA: 0x7FFD4E092E60
        public void UpdateParentTree(){} // RVA: 0x7FFD4E2ADC40
        public void RefreshTree(){} // RVA: 0x7FFD4E090A40
        public void BuildTree(){} // RVA: 0x7FFD4E096500
    }

    public class TreeViewController : BaseTreeViewController
    {
        public object treeView;

        // ── Methods ──
        public void get_treeView(){} // RVA: 0x7FFD54EAB5E0
        public void MakeItem(){} // RVA: 0x7FFD54EAB670
        public void BindItem(){} // RVA: 0x7FFD54EAB7B0
        public void UnbindItem(){} // RVA: 0x7FFD54EAB980
        public void DestroyItem(){} // RVA: 0x7FFD54EAB9D0
        public void .ctor(){} // RVA: 0x7FFD509952E0
    }

    public class TreeViewItemData`1 : ValueType
    {
        public int id;
        public T data;
        public System.Collections.Generic.IList`1<UnityEngine.UIElements.TreeViewItemData`1<T>> children;

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFD4E079960
        public void get_data(){} // RVA: 0x7FFD4E2ADC40
        public void get_children(){} // RVA: 0x7FFD4E078E90
        public void get_hasChildren(){} // RVA: 0x7FFD4E079D00
        public void InsertChild(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveChild(){} // RVA: 0x7FFD4E090ED0
        public void GetChildIndex(){} // RVA: 0x7FFD4E0800D0
        public void ReplaceChild(){} // RVA: 0x7FFD4E2ADC40
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        public System.Type defaultValue; // 0x40

        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x7FFD4E27B230
        public void get_defaultValue(){} // RVA: 0x7FFD4E27B230
        public void set_defaultValue(){} // RVA: 0x7FFD513FBA30
        public void .ctor(){} // RVA: 0x7FFD5213E3D0
    }

}