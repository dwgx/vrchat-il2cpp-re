// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 92
// Methods: 1413

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Tab : VisualElement
    {
        // ── Methods ──
        public void add_selected(){} // RVA: 0x8026300
        public void remove_selected(){} // RVA: 0x8026420
        public void add_closed(){} // RVA: 0x8026540
        public void remove_closed(){} // RVA: 0x8026660
        public void get_tabHeader(){} // RVA: 0x16594C0
        public void get_index(){} // RVA: 0x8026780
        public void set_index(){} // RVA: 0x8026790
        public void get_label(){} // RVA: 0x1653580
        public void set_label(){} // RVA: 0x80267A0
        public void get_iconImage(){} // RVA: 0x8026970
        public void set_iconImage(){} // RVA: 0x8026990
        public void get_closeable(){} // RVA: 0x78CA000
        public void set_closeable(){} // RVA: 0x8026D70
        public void get_contentContainer(){} // RVA: 0x165E400
        public void .ctor(){} // RVA: 0x8026F30
        public void UpdateTooltip(){} // RVA: 0x80280F0
        public void AddDragHandles(){} // RVA: 0x8028250
        public void RemoveDragHandles(){} // RVA: 0x8028280
        public void EnableTabDragHandles(){} // RVA: 0x80282F0
        public void AddCloseButton(){} // RVA: 0x8028370
        public void RemoveCloseButton(){} // RVA: 0x80283A0
        public void EnableTabCloseButton(){} // RVA: 0x8028410
        public void SetActive(){} // RVA: 0x8028490
        public void SetInactive(){} // RVA: 0x80284E0
        public void OnTabClicked(){} // RVA: 0x8028530
        public void OnCloseButtonClicked(){} // RVA: 0x8028550
        public void .cctor(){} // RVA: 0x80285C0
    }

    public class TabDragLocationPreview : VisualElement
    {
        // ── Methods ──
        public void get_preview(){} // RVA: 0x1667E80
        public void .ctor(){} // RVA: 0x8029C90
        public void .cctor(){} // RVA: 0x8029E90
    }

    public class TabDragPreview : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8029A70
        public void .cctor(){} // RVA: 0x8029BA0
    }

    public class TabDragger : PointerManipulator
    {
        // ── Methods ──
        public void get_tabLayout(){} // RVA: 0xCD3320
        public void set_tabLayout(){} // RVA: 0xCD4740
        public void get_active(){} // RVA: 0xE3F400
        public void set_active(){} // RVA: 0xE3CFC0
        public void get_isVertical(){} // RVA: 0xE3A050
        public void set_isVertical(){} // RVA: 0xE3F3F0
        public void get_moving(){} // RVA: 0xB68DF0
        public void set_moving(){} // RVA: 0x802A680
        public void .ctor(){} // RVA: 0x802A730
        public void RegisterCallbacksOnTarget(){} // RVA: 0x802A870
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x802AB80
        public void OnPointerDown(){} // RVA: 0x802B2C0
        public void OnPointerMove(){} // RVA: 0x802B380
        public void OnPointerUp(){} // RVA: 0x802B530
        public void OnPointerCancel(){} // RVA: 0x802B6A0
        public void OnPointerCaptureOut(){} // RVA: 0x802B740
        public void ProcessCancelEvent(){} // RVA: 0x802B7B0
        public void OnKeyDown(){} // RVA: 0x802B8A0
        public void ProcessDownEvent(){} // RVA: 0x802B970
        public void ProcessMoveEvent(){} // RVA: 0x802BD90
        public void ProcessUpEvent(){} // RVA: 0x802BF00
        public void BeginDragMove(){} // RVA: 0x802BFF0
        public void DragMove(){} // RVA: 0x802C780
        public void UpdatePreviewPosition(){} // RVA: 0x802C790
        public void UpdateMoveLocation(){} // RVA: 0x802CED0
        public void EndDragMove(){} // RVA: 0x802D1D0
    }

    public class TabLayout : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x802A170
        public void GetHeight(){} // RVA: 0x802A250
        public void GetWidth(){} // RVA: 0x802A290
        public void GetTabOffset(){} // RVA: 0x802A2D0
        public void InitOrderTabs(){} // RVA: 0x802A4D0
        public void ReorderDisplay(){} // RVA: 0x802A590
    }

    public class TabView : VisualElement
    {
        // ── Methods ──
        public void get_contentContainer(){} // RVA: 0x166C430
        public void get_header(){} // RVA: 0x1667E80
        public void get_tabs(){} // RVA: 0x16686F0
        public void get_tabHeaders(){} // RVA: 0x1653580
        public void get_activeTab(){} // RVA: 0x1667CC0
        public void set_activeTab(){} // RVA: 0x802D510
        public void get_reorderable(){} // RVA: 0x802D720
        public void set_reorderable(){} // RVA: 0x802D730
        public void .ctor(){} // RVA: 0x802D940
        public void OnViewDataReady(){} // RVA: 0x802DFB0
        public void SaveViewState(){} // RVA: 0x802E0D0
        public void UpdateIndexes(){} // RVA: 0x802E110
        public void OnElementAdded(){} // RVA: 0x802E1D0
        public void OnElementRemoved(){} // RVA: 0x802E5B0
        public void OnTabSelected(){} // RVA: 0x802E830
        public void OnTabClosed(){} // RVA: 0x802E840
        public void ReorderTab(){} // RVA: 0x802E880
        public void FindTabByKey(){} // RVA: 0x802EB30
        public void .cctor(){} // RVA: 0x802EC60
    }

    public class TempMeshAllocator : ValueType
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x80A98A0
        public void AllocateTempMesh(){} // RVA: 0x9A9E10
    }

    public class TemplateAsset : VisualElementAsset
    {
        // ── Methods ──
        public void get_attributeOverrides(){} // RVA: 0x106A7D0
        public void get_serializedDataOverrides(){} // RVA: 0x106A050
        public void Instantiate(){} // RVA: 0x7F17A30
        public void get_slotUsages(){} // RVA: 0x7C7E610
    }

    public class TemplateAsset[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TemplateContainer : BindableElement
    {
        // ── Methods ──
        public void get_templateId(){} // RVA: 0x16686F0
        public void set_templateId(){} // RVA: 0x166E540
        public void get_templateSource(){} // RVA: 0x1667CC0
        public void set_templateSource(){} // RVA: 0x1649C60
        public void .ctor(){} // RVA: 0x7EEC580
        public void get_contentContainer(){} // RVA: 0x7EEC700
        public void SetContentContainer(){} // RVA: 0x164F8E0
        public void .cctor(){} // RVA: 0x7EEC710
    }

    public class TextEditingManipulator : Object
    {
        // ── Methods ──
        public void get_editingEventHandler(){} // RVA: 0xB465B0
        public void set_editingEventHandler(){} // RVA: 0x7EF57C0
        public void get_touchScreenTextFieldChanged(){} // RVA: 0x7EF5870
        public void .ctor(){} // RVA: 0x7EF5900
        public void Reset(){} // RVA: 0x7EF5AD0
        public void InitTextEditorEventHandler(){} // RVA: 0x7EF5AE0
        public void HandleEventBubbleUp(){} // RVA: 0x7EF5D40
        public void OnFocusInEvent(){} // RVA: 0x7EF6010
        public void OnFocusOutEvent(){} // RVA: 0x7EF61E0
        public void <OnFocusInEvent>b__14_0(){} // RVA: 0x7EF6280
    }

    public class TextEditorEventHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void RegisterCallbacksOnTarget(){} // RVA: 0xB43310
        public void UnregisterCallbacksFromTarget(){} // RVA: 0xB43310
        public void HandleEventBubbleUp(){} // RVA: 0xB43310
    }

    public class TextElement : BindableElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7EFF880
        public void GetDefaultValueType(){} // RVA: 0x7EFFE20
        public void get_uitkTextHandle(){} // RVA: 0x16686F0
        public void set_uitkTextHandle(){} // RVA: 0x166E540
        public void HandleEventBubbleUp(){} // RVA: 0x7EFFE40
        public void OnGeometryChanged(){} // RVA: 0x7EFFF50
        public void OnDetachFromPanel(){} // RVA: 0x7EFFF60
        public void get_text(){} // RVA: 0x7EFFFA0
        public void set_text(){} // RVA: 0x7EFFFE0
        public void get_enableRichText(){} // RVA: 0x7F00040
        public void set_enableRichText(){} // RVA: 0x7F00050
        public void get_emojiFallbackSupport(){} // RVA: 0x7F00100
        public void set_emojiFallbackSupport(){} // RVA: 0x7F00110
        public void get_parseEscapeSequences(){} // RVA: 0x7F001C0
        public void set_parseEscapeSequences(){} // RVA: 0x7F001D0
        public void get_displayTooltipWhenElided(){} // RVA: 0x7F00280
        public void set_displayTooltipWhenElided(){} // RVA: 0x7F00290
        public void get_isElided(){} // RVA: 0x7F00340
        public void set_isElided(){} // RVA: 0x7F00350
        public void OnGenerateVisualContent(){} // RVA: 0x7F00360
        public void OnGenerateTextOver(){} // RVA: 0x7F00660
        public void OnGenerateTextOverNative(){} // RVA: 0x7F00890
        public void ElideText(){} // RVA: 0x7F009A0
        public void UpdateTooltip(){} // RVA: 0x7F00ED0
        public void UpdateVisibleText(){} // RVA: 0x7F00F50
        public void ShouldElide(){} // RVA: 0x7F011B0
        public void get_hasFocus(){} // RVA: 0x7F01240
        public void MeasureTextSize(){} // RVA: 0x7F012C0
        public void DoMeasure(){} // RVA: 0x7F01380
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value(){} // RVA: 0x7F01410
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(){} // RVA: 0x7F01430
        public void get_value(){} // RVA: 0x7F01670
        public void set_value(){} // RVA: 0x7F016B0
        public void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(){} // RVA: 0x7F01710
        public void get_edition(){} // RVA: 0x2303260
        public void get_editingManipulator(){} // RVA: 0x163D1E0
        public void set_editingManipulator(){} // RVA: 0x163F4D0
        public void UnityEngine.UIElements.ITextEdition.get_multiline(){} // RVA: 0x78CA020
        public void UnityEngine.UIElements.ITextEdition.set_multiline(){} // RVA: 0x7F019A0
        public void UnityEngine.UIElements.ITextEdition.get_touchScreenKeyboard(){} // RVA: 0x165E400
        public void UnityEngine.UIElements.ITextEdition.get_keyboardType(){} // RVA: 0x60E3E20
        public void UnityEngine.UIElements.ITextEdition.set_keyboardType(){} // RVA: 0x7F01A30
        public void get_keyboardType(){} // RVA: 0x7F01AC0
        public void set_keyboardType(){} // RVA: 0x7F01B10
        public void UnityEngine.UIElements.ITextEdition.get_hideMobileInput(){} // RVA: 0x7F01B70
        public void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(){} // RVA: 0x7F01BE0
        public void get_hideMobileInput(){} // RVA: 0x7F01CB0
        public void set_hideMobileInput(){} // RVA: 0x7F01D00
        public void UnityEngine.UIElements.ITextEdition.get_isReadOnly(){} // RVA: 0x7F01D60
        public void UnityEngine.UIElements.ITextEdition.set_isReadOnly(){} // RVA: 0x7F01D80
        public void get_isReadOnly(){} // RVA: 0x7F02090
        public void set_isReadOnly(){} // RVA: 0x7F020E0
        public void ProcessMenuCommand(){} // RVA: 0x7F02140
        public void Cut(){} // RVA: 0x7F02380
        public void Copy(){} // RVA: 0x7F023D0
        public void Paste(){} // RVA: 0x7F02420
        public void BuildContextualMenu(){} // RVA: 0x7F02470
        public void CutActionStatus(){} // RVA: 0x7F027E0
        public void CopyActionStatus(){} // RVA: 0x7F02870
        public void PasteActionStatus(){} // RVA: 0x7F02900
        public void EditionHandleEvent(){} // RVA: 0x7F02990
        public void UnityEngine.UIElements.ITextEdition.get_maxLength(){} // RVA: 0x7F02C50
        public void UnityEngine.UIElements.ITextEdition.set_maxLength(){} // RVA: 0x7F02C60
        public void get_maxLength(){} // RVA: 0x7F02D40
        public void set_maxLength(){} // RVA: 0x7F02D90
        public void UnityEngine.UIElements.ITextEdition.get_placeholder(){} // RVA: 0x164C740
        public void UnityEngine.UIElements.ITextEdition.set_placeholder(){} // RVA: 0x7F02DF0
        public void UnityEngine.UIElements.ITextEdition.get_isDelayed(){} // RVA: 0x7F03060
        public void UnityEngine.UIElements.ITextEdition.set_isDelayed(){} // RVA: 0x7F03070
        public void UnityEngine.UIElements.ITextEdition.SaveValueAndText(){} // RVA: 0x7F03080
        public void UnityEngine.UIElements.ITextEdition.RestoreValueAndText(){} // RVA: 0x7F03100
        public void UnityEngine.UIElements.ITextEdition.get_AcceptCharacter(){} // RVA: 0x163E5A0
        public void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(){} // RVA: 0x1639E40
        public void UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset(){} // RVA: 0x165D560
        public void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(){} // RVA: 0x164DA70
        public void UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText(){} // RVA: 0x164D680
        public void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(){} // RVA: 0x164D7B0
        public void UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue(){} // RVA: 0x166DF20
        public void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(){} // RVA: 0x1649450
        public void UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot(){} // RVA: 0x16495F0
        public void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(){} // RVA: 0x163CED0
        public void get_OnPlaceholderChanged(){} // RVA: 0x1667A50
        public void set_OnPlaceholderChanged(){} // RVA: 0x163E380
        public void UnityEngine.UIElements.ITextEdition.get_GetDefaultValueType(){} // RVA: 0x165B7D0
        public void UnityEngine.UIElements.ITextEdition.set_GetDefaultValueType(){} // RVA: 0x163A4F0
        public void UnityEngine.UIElements.ITextEdition.UpdateText(){} // RVA: 0x7F03120
        public void UnityEngine.UIElements.ITextEdition.CullString(){} // RVA: 0x7F03490
        public void UnityEngine.UIElements.ITextEdition.get_maskChar(){} // RVA: 0x7F03510
        public void UnityEngine.UIElements.ITextEdition.set_maskChar(){} // RVA: 0x7F03520
        public void get_maskChar(){} // RVA: 0x7F03600
        public void set_maskChar(){} // RVA: 0x7F03650
        public void get_effectiveMaskChar(){} // RVA: 0x7F036B0
        public void UnityEngine.UIElements.ITextEdition.get_isPassword(){} // RVA: 0x7F03720
        public void UnityEngine.UIElements.ITextEdition.set_isPassword(){} // RVA: 0x7F03730
        public void get_isPassword(){} // RVA: 0x7F037E0
        public void set_isPassword(){} // RVA: 0x7F03830
        public void UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus(){} // RVA: 0x7F03890
        public void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(){} // RVA: 0x7F038A0
        public void get_showPlaceholderText(){} // RVA: 0x7F038B0
        public void UnityEngine.UIElements.ITextEdition.get_autoCorrection(){} // RVA: 0x7F03990
        public void UnityEngine.UIElements.ITextEdition.set_autoCorrection(){} // RVA: 0x7F039A0
        public void get_autoCorrection(){} // RVA: 0x7F03A30
        public void set_autoCorrection(){} // RVA: 0x7F03A80
        public void get_renderedText(){} // RVA: 0x7F03AE0
        public void SetRenderedText(){} // RVA: 0x16528E0
        public void get_originalText(){} // RVA: 0x166CFA0
        public void get_selection(){} // RVA: 0x2303260
        public void UnityEngine.UIElements.ITextSelection.get_isSelectable(){} // RVA: 0x7F03DF0
        public void UnityEngine.UIElements.ITextSelection.set_isSelectable(){} // RVA: 0x7F03E30
        public void get_isSelectable(){} // RVA: 0x7F03F00
        public void set_isSelectable(){} // RVA: 0x7F03F50
        public void UnityEngine.UIElements.ITextSelection.get_cursorIndex(){} // RVA: 0x7F03FB0
        public void UnityEngine.UIElements.ITextSelection.set_cursorIndex(){} // RVA: 0x7F04030
        public void get_cursorIndex(){} // RVA: 0x7F04150
        public void set_cursorIndex(){} // RVA: 0x7F041A0
        public void UnityEngine.UIElements.ITextSelection.get_selectIndex(){} // RVA: 0x7F04200
        public void UnityEngine.UIElements.ITextSelection.set_selectIndex(){} // RVA: 0x7F04280
        public void get_selectIndex(){} // RVA: 0x7F043A0
        public void set_selectIndex(){} // RVA: 0x7F043F0
        public void UnityEngine.UIElements.ITextSelection.SelectAll(){} // RVA: 0x7F04450
        public void UnityEngine.UIElements.ITextSelection.SelectNone(){} // RVA: 0x7F044D0
        public void UnityEngine.UIElements.ITextSelection.HasSelection(){} // RVA: 0x7F04550
        public void UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord(){} // RVA: 0x7F045D0
        public void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(){} // RVA: 0x7F045E0
        public void get_doubleClickSelectsWord(){} // RVA: 0x7F04670
        public void set_doubleClickSelectsWord(){} // RVA: 0x7F046C0
        public void UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine(){} // RVA: 0x7F04720
        public void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(){} // RVA: 0x7F04730
        public void get_tripleClickSelectsLine(){} // RVA: 0x7F047C0
        public void set_tripleClickSelectsLine(){} // RVA: 0x7F04810
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus(){} // RVA: 0x7F04870
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(){} // RVA: 0x7F04880
        public void get_selectAllOnFocus(){} // RVA: 0x7F04910
        public void set_selectAllOnFocus(){} // RVA: 0x7F04960
        public void UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp(){} // RVA: 0x7F049C0
        public void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(){} // RVA: 0x7F049D0
        public void get_selectAllOnMouseUp(){} // RVA: 0x7F04A60
        public void set_selectAllOnMouseUp(){} // RVA: 0x7F04AB0
        public void UnityEngine.UIElements.ITextSelection.get_cursorPosition(){} // RVA: 0x7F04B10
        public void get_cursorPosition(){} // RVA: 0x7F04BF0
        public void UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition(){} // RVA: 0x7F04C40
        public void get_selectionColor(){} // RVA: 0x7F04DC0
        public void set_selectionColor(){} // RVA: 0x7F04DD0
        public void get_cursorColor(){} // RVA: 0x7F04E80
        public void set_cursorColor(){} // RVA: 0x7F04E90
        public void UnityEngine.UIElements.ITextSelection.get_cursorWidth(){} // RVA: 0x7F04F40
        public void get_selectingManipulator(){} // RVA: 0x7F04F50
        public void DrawHighlighting(){} // RVA: 0x7F05010
        public void DrawNativeHighlighting(){} // RVA: 0x7F05990
        public void DrawCaret(){} // RVA: 0x7F05F10
        public void GetLastCharacterAt(){} // RVA: 0x7F062C0
        public void .cctor(){} // RVA: 0x7F06600
    }

    public class TextEventHandler : Object
    {
        // ── Methods ──
        public void get_textInfo(){} // RVA: 0x7EF62D0
        public void .ctor(){} // RVA: 0x7EF6300
        public void OnDestroy(){} // RVA: 0x7EF6360
        public void HasAllocatedLinkCallbacks(){} // RVA: 0x7EED3F0
        public void AllocateLinkCallbacks(){} // RVA: 0x7EF6A70
        public void HasAllocatedATagCallbacks(){} // RVA: 0x7EED6B0
        public void AllocateATagCallbacks(){} // RVA: 0x7EF6D20
        public void ATagOnPointerUp(){} // RVA: 0x7EF6FD0
        public void ATagOnPointerOver(){} // RVA: 0x1D98510
        public void ATagOnPointerMove(){} // RVA: 0x7EF7270
        public void ATagOnPointerOut(){} // RVA: 0x1D98510
        public void LinkTagOnPointerDown(){} // RVA: 0x7EF7530
        public void LinkTagOnPointerUp(){} // RVA: 0x7EF78D0
        public void LinkTagOnPointerMove(){} // RVA: 0x7EF7C70
        public void LinkTagOnPointerOut(){} // RVA: 0x7EF82C0
        public void HandleLinkAndATagCallbacks(){} // RVA: 0x7EF8460
        public void HandleLinkTag(){} // RVA: 0x7EF8D50
        public void HandleATag(){} // RVA: 0x7EF8E80
    }

    public class TextField : TextInputBaseField`1
    {
        // ── Methods ──
        public void get_textInput(){} // RVA: 0x7FEF390
        public void get_multiline(){} // RVA: 0x7FEF420
        public void set_multiline(){} // RVA: 0x7FEF490
        public void .ctor(){} // RVA: 0x7FEF5B0
        public void get_value(){} // RVA: 0x7FEF840
        public void set_value(){} // RVA: 0x7FEF890
        public void SetValueWithoutNotify(){} // RVA: 0x7FEF950
        public void UpdateTextFromValue(){} // RVA: 0x7FEFA70
        public void HandleEventBubbleUp(){} // RVA: 0x7FEFAC0
        public void OnViewDataReady(){} // RVA: 0x7FEFD70
        public void ValueToString(){} // RVA: 0x1CB3B00
        public void StringToValue(){} // RVA: 0x1CB3B00
        public void .cctor(){} // RVA: 0x7FEFE30
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void set_password(){} // RVA: 0x894750
        public void set_readOnly(){} // RVA: 0x894750
        public void get_placeholderText(){} // RVA: 0x87C0A0
        public void set_placeholderText(){} // RVA: 0x894320
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x87D280
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x894750
        public void .ctor(){} // RVA: 0xA94080
        public void get_textInputBase(){} // RVA: 0x87C0A0
        public void get_textSelection(){} // RVA: 0x87C0A0
        public void get_textEdition(){} // RVA: 0x87C0A0
        public void get_onIsReadOnlyChanged(){} // RVA: 0x87C0A0
        public void set_onIsReadOnlyChanged(){} // RVA: 0x894320
        public void get_isReadOnly(){} // RVA: 0x87D280
        public void set_isReadOnly(){} // RVA: 0x894750
        public void get_isPasswordField(){} // RVA: 0x87D280
        public void set_isPasswordField(){} // RVA: 0x894750
        public void get_autoCorrection(){} // RVA: 0x87D280
        public void set_autoCorrection(){} // RVA: 0x894750
        public void get_hideMobileInput(){} // RVA: 0x87D280
        public void set_hideMobileInput(){} // RVA: 0x894750
        public void get_keyboardType(){} // RVA: 0x87C130
        public void set_keyboardType(){} // RVA: 0x8944F0
        public void get_maxLength(){} // RVA: 0x87C130
        public void set_maxLength(){} // RVA: 0x8944F0
        public void get_isDelayed(){} // RVA: 0x87D280
        public void set_isDelayed(){} // RVA: 0x894750
        public void get_maskChar(){} // RVA: 0x87C100
        public void set_maskChar(){} // RVA: 0x894470
        public void get_cursorIndex(){} // RVA: 0x87C130
        public void set_cursorIndex(){} // RVA: 0x8944F0
        public void get_cursorPosition(){} // RVA: 0x87C0A0
        public void get_selectIndex(){} // RVA: 0x87C130
        public void set_selectIndex(){} // RVA: 0x8944F0
        public void get_selectAllOnFocus(){} // RVA: 0x87D280
        public void set_selectAllOnFocus(){} // RVA: 0x894750
        public void get_selectAllOnMouseUp(){} // RVA: 0x87D280
        public void set_selectAllOnMouseUp(){} // RVA: 0x894750
        public void get_doubleClickSelectsWord(){} // RVA: 0x87D280
        public void set_doubleClickSelectsWord(){} // RVA: 0x894750
        public void get_tripleClickSelectsLine(){} // RVA: 0x87D280
        public void set_tripleClickSelectsLine(){} // RVA: 0x894750
        public void get_text(){} // RVA: 0x87C0A0
        public void set_text(){} // RVA: 0x894320
        public void get_emojiFallbackSupport(){} // RVA: 0x87D280
        public void set_emojiFallbackSupport(){} // RVA: 0x894750
        public void get_verticalScrollerVisibility(){} // RVA: 0x87C130
        public void set_verticalScrollerVisibility(){} // RVA: 0x8944F0
        public void HandleEventBubbleUp(){} // RVA: 0x894320
        public void ValueToString(){} // RVA: 0xA94080
        public void StringToValue(){} // RVA: 0xA94080
        public void get_canSwitchToMixedValue(){} // RVA: 0x87D280
        public void UpdateMixedValueContent(){} // RVA: 0x894290
        public void OnPlaceholderChanged(){} // RVA: 0x894290
        public void UpdatePlaceholderClassList(){} // RVA: 0x894320
        public void UpdateValueFromText(){} // RVA: 0x894290
        public void UpdateTextFromValue(){} // RVA: 0x894290
        public void OnFieldCustomStyleResolved(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void get_textEdition(){} // RVA: 0x4EA5910
        public void set_isReadOnly(){} // RVA: 0x4EA5A50
        public void set_isDelayed(){} // RVA: 0x4EA6440
        public void UpdateValueFromText(){} // RVA: 0x4EA7FA0
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void get_isDelayed(){} // RVA: 0x4EA63E0
        public void set_password(){} // RVA: 0x4EA5090
        public void set_readOnly(){} // RVA: 0x4EA5100
        public void get_placeholderText(){} // RVA: 0x4EA5120
        public void set_placeholderText(){} // RVA: 0x4EA5180
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4EA52E0
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4EA5340
        public void .ctor(){} // RVA: 0x4EA5470
        public void get_textInputBase(){} // RVA: 0x166DF20
        public void get_textSelection(){} // RVA: 0x4EA5910
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4EA5940
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4EA5970
        public void get_isReadOnly(){} // RVA: 0x4EA59F0
        public void get_isPasswordField(){} // RVA: 0x4EA5B80
        public void set_isPasswordField(){} // RVA: 0x4EA5BE0
        public void get_autoCorrection(){} // RVA: 0x4EA5D40
        public void set_autoCorrection(){} // RVA: 0x4EA5DA0
        public void get_hideMobileInput(){} // RVA: 0x4EA5ED0
        public void set_hideMobileInput(){} // RVA: 0x4EA5F30
        public void get_keyboardType(){} // RVA: 0x4EA6060
        public void set_keyboardType(){} // RVA: 0x4EA60C0
        public void get_maxLength(){} // RVA: 0x4EA61F0
        public void set_maxLength(){} // RVA: 0x4EA6250
        public void get_maskChar(){} // RVA: 0x4EA6570
        public void set_maskChar(){} // RVA: 0x4EA65D0
        public void get_cursorIndex(){} // RVA: 0x4EA6700
        public void set_cursorIndex(){} // RVA: 0x4EA6760
        public void get_cursorPosition(){} // RVA: 0x4EA6890
        public void get_selectIndex(){} // RVA: 0x4EA68F0
        public void set_selectIndex(){} // RVA: 0x4EA6950
        public void get_selectAllOnFocus(){} // RVA: 0x4EA6A80
        public void set_selectAllOnFocus(){} // RVA: 0x4EA6AE0
        public void get_selectAllOnMouseUp(){} // RVA: 0x4EA6C10
        public void set_selectAllOnMouseUp(){} // RVA: 0x4EA6C70
        public void get_doubleClickSelectsWord(){} // RVA: 0x4EA6DA0
        public void set_doubleClickSelectsWord(){} // RVA: 0x4EA6E00
        public void get_tripleClickSelectsLine(){} // RVA: 0x4EA6F30
        public void set_tripleClickSelectsLine(){} // RVA: 0x4EA6F90
        public void get_text(){} // RVA: 0x4EA70C0
        public void set_text(){} // RVA: 0x4EA7100
        public void get_emojiFallbackSupport(){} // RVA: 0x4EA7120
        public void set_emojiFallbackSupport(){} // RVA: 0x4EA7150
        public void get_verticalScrollerVisibility(){} // RVA: 0x4EA7260
        public void set_verticalScrollerVisibility(){} // RVA: 0x4EA7290
        public void HandleEventBubbleUp(){} // RVA: 0x4EA73F0
        public void ValueToString(){} // RVA: 0x881E30
        public void StringToValue(){} // RVA: 0x882470
        public void get_canSwitchToMixedValue(){} // RVA: 0x4EA7900
        public void UpdateMixedValueContent(){} // RVA: 0x4EA7930
        public void OnPlaceholderChanged(){} // RVA: 0x4EA7C20
        public void UpdatePlaceholderClassList(){} // RVA: 0x4EA7E70
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4EA8020
        public void .cctor(){} // RVA: 0x4EA8060
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void set_password(){} // RVA: 0x4ED30B0
        public void set_readOnly(){} // RVA: 0x4ED3140
        public void get_placeholderText(){} // RVA: 0x4ED3160
        public void set_placeholderText(){} // RVA: 0x4ED31E0
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4ED3350
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4ED33D0
        public void .ctor(){} // RVA: 0x4ED3510
        public void get_textInputBase(){} // RVA: 0x4ED3B80
        public void get_textSelection(){} // RVA: 0x4ED3BC0
        public void get_textEdition(){} // RVA: 0x4ED3BC0
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4ED3C30
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4ED3CA0
        public void get_isReadOnly(){} // RVA: 0x4ED3D60
        public void set_isReadOnly(){} // RVA: 0x4ED3DE0
        public void get_isPasswordField(){} // RVA: 0x4ED3F20
        public void set_isPasswordField(){} // RVA: 0x4ED3FA0
        public void get_autoCorrection(){} // RVA: 0x4ED4140
        public void set_autoCorrection(){} // RVA: 0x4ED41C0
        public void get_hideMobileInput(){} // RVA: 0x4ED4300
        public void set_hideMobileInput(){} // RVA: 0x4ED4380
        public void get_keyboardType(){} // RVA: 0x4ED44C0
        public void set_keyboardType(){} // RVA: 0x4ED4540
        public void get_maxLength(){} // RVA: 0x4ED4680
        public void set_maxLength(){} // RVA: 0x4ED4700
        public void get_isDelayed(){} // RVA: 0x4ED4930
        public void set_isDelayed(){} // RVA: 0x4ED49B0
        public void get_maskChar(){} // RVA: 0x4ED4AF0
        public void set_maskChar(){} // RVA: 0x4ED4B70
        public void get_cursorIndex(){} // RVA: 0x4ED4CB0
        public void set_cursorIndex(){} // RVA: 0x4ED4D30
        public void get_cursorPosition(){} // RVA: 0x4ED4E70
        public void get_selectIndex(){} // RVA: 0x4ED4EF0
        public void set_selectIndex(){} // RVA: 0x4ED4F70
        public void get_selectAllOnFocus(){} // RVA: 0x4ED50B0
        public void set_selectAllOnFocus(){} // RVA: 0x4ED5130
        public void get_selectAllOnMouseUp(){} // RVA: 0x4ED5280
        public void set_selectAllOnMouseUp(){} // RVA: 0x4ED5300
        public void get_doubleClickSelectsWord(){} // RVA: 0x4ED5450
        public void set_doubleClickSelectsWord(){} // RVA: 0x4ED54D0
        public void get_tripleClickSelectsLine(){} // RVA: 0x4ED5620
        public void set_tripleClickSelectsLine(){} // RVA: 0x4ED56A0
        public void get_text(){} // RVA: 0x4ED57F0
        public void set_text(){} // RVA: 0x4ED5860
        public void get_emojiFallbackSupport(){} // RVA: 0x4ED58D0
        public void set_emojiFallbackSupport(){} // RVA: 0x4ED5940
        public void get_verticalScrollerVisibility(){} // RVA: 0x4ED5AF0
        public void set_verticalScrollerVisibility(){} // RVA: 0x4ED5B30
        public void HandleEventBubbleUp(){} // RVA: 0x4ED5C40
        public void ValueToString(){} // RVA: 0xA94080
        public void StringToValue(){} // RVA: 0xA94080
        public void get_canSwitchToMixedValue(){} // RVA: 0x4ED61E0
        public void UpdateMixedValueContent(){} // RVA: 0x4ED6250
        public void OnPlaceholderChanged(){} // RVA: 0x4ED65E0
        public void UpdatePlaceholderClassList(){} // RVA: 0x4ED6780
        public void UpdateValueFromText(){} // RVA: 0x4ED6920
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4ED6A20
        public void .cctor(){} // RVA: 0x4ED6A90
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void get_textEdition(){} // RVA: 0x4EA5910
        public void set_isReadOnly(){} // RVA: 0x4EC2A40
        public void set_isDelayed(){} // RVA: 0x4EC3430
        public void UpdateValueFromText(){} // RVA: 0x4EA7FA0
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void get_isDelayed(){} // RVA: 0x4EC33D0
        public void set_password(){} // RVA: 0x4EC2160
        public void set_readOnly(){} // RVA: 0x4EC21D0
        public void get_placeholderText(){} // RVA: 0x4EC21F0
        public void set_placeholderText(){} // RVA: 0x4EC2250
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4EC23B0
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4EC2410
        public void .ctor(){} // RVA: 0x4EC2540
        public void get_textInputBase(){} // RVA: 0x166DF20
        public void get_textSelection(){} // RVA: 0x4EA5910
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4EA5940
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4EA5970
        public void get_isReadOnly(){} // RVA: 0x4EC29E0
        public void get_isPasswordField(){} // RVA: 0x4EC2B70
        public void set_isPasswordField(){} // RVA: 0x4EC2BD0
        public void get_autoCorrection(){} // RVA: 0x4EC2D30
        public void set_autoCorrection(){} // RVA: 0x4EC2D90
        public void get_hideMobileInput(){} // RVA: 0x4EC2EC0
        public void set_hideMobileInput(){} // RVA: 0x4EC2F20
        public void get_keyboardType(){} // RVA: 0x4EC3050
        public void set_keyboardType(){} // RVA: 0x4EC30B0
        public void get_maxLength(){} // RVA: 0x4EC31E0
        public void set_maxLength(){} // RVA: 0x4EC3240
        public void get_maskChar(){} // RVA: 0x4EC3560
        public void set_maskChar(){} // RVA: 0x4EC35C0
        public void get_cursorIndex(){} // RVA: 0x4EC36F0
        public void set_cursorIndex(){} // RVA: 0x4EC3750
        public void get_cursorPosition(){} // RVA: 0x4EC3880
        public void get_selectIndex(){} // RVA: 0x4EC38E0
        public void set_selectIndex(){} // RVA: 0x4EC3940
        public void get_selectAllOnFocus(){} // RVA: 0x4EC3A70
        public void set_selectAllOnFocus(){} // RVA: 0x4EC3AD0
        public void get_selectAllOnMouseUp(){} // RVA: 0x4EC3C00
        public void set_selectAllOnMouseUp(){} // RVA: 0x4EC3C60
        public void get_doubleClickSelectsWord(){} // RVA: 0x4EC3D90
        public void set_doubleClickSelectsWord(){} // RVA: 0x4EC3DF0
        public void get_tripleClickSelectsLine(){} // RVA: 0x4EC3F20
        public void set_tripleClickSelectsLine(){} // RVA: 0x4EC3F80
        public void get_text(){} // RVA: 0x4EA70C0
        public void set_text(){} // RVA: 0x4EA7100
        public void get_emojiFallbackSupport(){} // RVA: 0x4EA7120
        public void set_emojiFallbackSupport(){} // RVA: 0x4EA7150
        public void get_verticalScrollerVisibility(){} // RVA: 0x4EA7260
        public void set_verticalScrollerVisibility(){} // RVA: 0x4EC40B0
        public void HandleEventBubbleUp(){} // RVA: 0x4EC4210
        public void ValueToString(){} // RVA: 0x8908B0
        public void StringToValue(){} // RVA: 0x891020
        public void get_canSwitchToMixedValue(){} // RVA: 0x4EA7900
        public void UpdateMixedValueContent(){} // RVA: 0x4EC4660
        public void OnPlaceholderChanged(){} // RVA: 0x4EC4950
        public void UpdatePlaceholderClassList(){} // RVA: 0x4EA7E70
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4EC4BA0
        public void .cctor(){} // RVA: 0x4EC4BE0
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void get_textEdition(){} // RVA: 0x4EAB850
        public void set_isReadOnly(){} // RVA: 0x4EAB990
        public void set_isDelayed(){} // RVA: 0x4EAC390
        public void UpdateValueFromText(){} // RVA: 0x4EADF70
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void set_password(){} // RVA: 0x4EAAFD0
        public void set_readOnly(){} // RVA: 0x4EAB040
        public void get_placeholderText(){} // RVA: 0x4EAB060
        public void set_placeholderText(){} // RVA: 0x4EAB0C0
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4EAB220
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4EAB280
        public void .ctor(){} // RVA: 0x4EAB3B0
        public void get_textInputBase(){} // RVA: 0x16495F0
        public void get_textSelection(){} // RVA: 0x4EAB850
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4EAB880
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4EAB8B0
        public void get_isReadOnly(){} // RVA: 0x4EAB930
        public void get_isPasswordField(){} // RVA: 0x4EABAC0
        public void set_isPasswordField(){} // RVA: 0x4EABB20
        public void get_autoCorrection(){} // RVA: 0x4EABC80
        public void set_autoCorrection(){} // RVA: 0x4EABCE0
        public void get_hideMobileInput(){} // RVA: 0x4EABE10
        public void set_hideMobileInput(){} // RVA: 0x4EABE70
        public void get_keyboardType(){} // RVA: 0x4EABFA0
        public void set_keyboardType(){} // RVA: 0x4EAC000
        public void get_maxLength(){} // RVA: 0x4EAC130
        public void set_maxLength(){} // RVA: 0x4EAC190
        public void get_isDelayed(){} // RVA: 0x4EAC330
        public void get_maskChar(){} // RVA: 0x4EAC4C0
        public void set_maskChar(){} // RVA: 0x4EAC520
        public void get_cursorIndex(){} // RVA: 0x4EAC650
        public void set_cursorIndex(){} // RVA: 0x4EAC6B0
        public void get_cursorPosition(){} // RVA: 0x4EAC7E0
        public void get_selectIndex(){} // RVA: 0x4EAC840
        public void set_selectIndex(){} // RVA: 0x4EAC8A0
        public void get_selectAllOnFocus(){} // RVA: 0x4EAC9D0
        public void set_selectAllOnFocus(){} // RVA: 0x4EACA30
        public void get_selectAllOnMouseUp(){} // RVA: 0x4EACB60
        public void set_selectAllOnMouseUp(){} // RVA: 0x4EACBC0
        public void get_doubleClickSelectsWord(){} // RVA: 0x4EACCF0
        public void set_doubleClickSelectsWord(){} // RVA: 0x4EACD50
        public void get_tripleClickSelectsLine(){} // RVA: 0x4EACE80
        public void set_tripleClickSelectsLine(){} // RVA: 0x4EACEE0
        public void get_text(){} // RVA: 0x4EAD010
        public void set_text(){} // RVA: 0x4EAD050
        public void get_emojiFallbackSupport(){} // RVA: 0x4EAD0F0
        public void set_emojiFallbackSupport(){} // RVA: 0x4EAD120
        public void get_verticalScrollerVisibility(){} // RVA: 0x4EAD230
        public void set_verticalScrollerVisibility(){} // RVA: 0x4EAD260
        public void HandleEventBubbleUp(){} // RVA: 0x4EAD3C0
        public void ValueToString(){} // RVA: 0x87C540
        public void StringToValue(){} // RVA: 0x87BF80
        public void get_canSwitchToMixedValue(){} // RVA: 0x4EAD8D0
        public void UpdateMixedValueContent(){} // RVA: 0x4EAD900
        public void OnPlaceholderChanged(){} // RVA: 0x4EADBF0
        public void UpdatePlaceholderClassList(){} // RVA: 0x4EADE40
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4EAE000
        public void .cctor(){} // RVA: 0x4EAE040
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void set_maxLength(){} // RVA: 0x4EBD750
        public void set_password(){} // RVA: 0x4EBC550
        public void set_readOnly(){} // RVA: 0x4EBC5C0
        public void set_isDelayed(){} // RVA: 0x4EBD940
        public void get_textSelection(){} // RVA: 0x4EA5910
        public void set_doubleClickSelectsWord(){} // RVA: 0x4EBE300
        public void set_tripleClickSelectsLine(){} // RVA: 0x4EBE490
        public void set_emojiFallbackSupport(){} // RVA: 0x4EA7150
        public void set_verticalScrollerVisibility(){} // RVA: 0x4EBE600
        public void set_hideMobileInput(){} // RVA: 0x4EBD430
        public void set_keyboardType(){} // RVA: 0x4EBD5C0
        public void set_autoCorrection(){} // RVA: 0x4EBD2A0
        public void set_maskChar(){} // RVA: 0x4EBDAD0
        public void set_placeholderText(){} // RVA: 0x4EBC760
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4EBC920
        public void UpdateValueFromText(){} // RVA: 0x4EB9520
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void get_placeholderText(){} // RVA: 0x4EBC700
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4EBC8C0
        public void .ctor(){} // RVA: 0x4EBCA50
        public void get_textInputBase(){} // RVA: 0x166DF20
        public void get_textEdition(){} // RVA: 0x4EA5910
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4EA5940
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4EA5970
        public void get_isReadOnly(){} // RVA: 0x4EBCEF0
        public void set_isReadOnly(){} // RVA: 0x4EBCF50
        public void get_isPasswordField(){} // RVA: 0x4EBD080
        public void set_isPasswordField(){} // RVA: 0x4EBD0E0
        public void get_autoCorrection(){} // RVA: 0x4EBD240
        public void get_hideMobileInput(){} // RVA: 0x4EBD3D0
        public void get_keyboardType(){} // RVA: 0x4EBD560
        public void get_maxLength(){} // RVA: 0x4EBD6F0
        public void get_isDelayed(){} // RVA: 0x4EBD8E0
        public void get_maskChar(){} // RVA: 0x4EBDA70
        public void get_cursorIndex(){} // RVA: 0x4EBDC00
        public void set_cursorIndex(){} // RVA: 0x4EBDC60
        public void get_cursorPosition(){} // RVA: 0x4EBDD90
        public void get_selectIndex(){} // RVA: 0x4EBDDF0
        public void set_selectIndex(){} // RVA: 0x4EBDE50
        public void get_selectAllOnFocus(){} // RVA: 0x4EBDF80
        public void set_selectAllOnFocus(){} // RVA: 0x4EBDFE0
        public void get_selectAllOnMouseUp(){} // RVA: 0x4EBE110
        public void set_selectAllOnMouseUp(){} // RVA: 0x4EBE170
        public void get_doubleClickSelectsWord(){} // RVA: 0x4EBE2A0
        public void get_tripleClickSelectsLine(){} // RVA: 0x4EBE430
        public void get_text(){} // RVA: 0x4EA70C0
        public void set_text(){} // RVA: 0x4EBE5C0
        public void get_emojiFallbackSupport(){} // RVA: 0x4EA7120
        public void get_verticalScrollerVisibility(){} // RVA: 0x4EA7260
        public void HandleEventBubbleUp(){} // RVA: 0x4EBE760
        public void ValueToString(){} // RVA: 0x87C540
        public void StringToValue(){} // RVA: 0x87C540
        public void get_canSwitchToMixedValue(){} // RVA: 0x4EA7900
        public void UpdateMixedValueContent(){} // RVA: 0x4EBEC70
        public void OnPlaceholderChanged(){} // RVA: 0x4EBEF60
        public void UpdatePlaceholderClassList(){} // RVA: 0x4EA7E70
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4EBF1B0
        public void .cctor(){} // RVA: 0x4EBF1F0
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void get_textEdition(){} // RVA: 0x4EA5910
        public void set_isReadOnly(){} // RVA: 0x4EB1890
        public void set_isDelayed(){} // RVA: 0x4EB2280
        public void UpdateValueFromText(){} // RVA: 0x4EB39F0
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void get_isDelayed(){} // RVA: 0x4EB2220
        public void set_password(){} // RVA: 0x4EB0FB0
        public void set_readOnly(){} // RVA: 0x4EB1020
        public void get_placeholderText(){} // RVA: 0x4EB1040
        public void set_placeholderText(){} // RVA: 0x4EB10A0
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4EB1200
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4EB1260
        public void .ctor(){} // RVA: 0x4EB1390
        public void get_textInputBase(){} // RVA: 0x166DF20
        public void get_textSelection(){} // RVA: 0x4EA5910
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4EA5940
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4EA5970
        public void get_isReadOnly(){} // RVA: 0x4EB1830
        public void get_isPasswordField(){} // RVA: 0x4EB19C0
        public void set_isPasswordField(){} // RVA: 0x4EB1A20
        public void get_autoCorrection(){} // RVA: 0x4EB1B80
        public void set_autoCorrection(){} // RVA: 0x4EB1BE0
        public void get_hideMobileInput(){} // RVA: 0x4EB1D10
        public void set_hideMobileInput(){} // RVA: 0x4EB1D70
        public void get_keyboardType(){} // RVA: 0x4EB1EA0
        public void set_keyboardType(){} // RVA: 0x4EB1F00
        public void get_maxLength(){} // RVA: 0x4EB2030
        public void set_maxLength(){} // RVA: 0x4EB2090
        public void get_maskChar(){} // RVA: 0x4EB23B0
        public void set_maskChar(){} // RVA: 0x4EB2410
        public void get_cursorIndex(){} // RVA: 0x4EB2540
        public void set_cursorIndex(){} // RVA: 0x4EB25A0
        public void get_cursorPosition(){} // RVA: 0x4EB26D0
        public void get_selectIndex(){} // RVA: 0x4EB2730
        public void set_selectIndex(){} // RVA: 0x4EB2790
        public void get_selectAllOnFocus(){} // RVA: 0x4EB28C0
        public void set_selectAllOnFocus(){} // RVA: 0x4EB2920
        public void get_selectAllOnMouseUp(){} // RVA: 0x4EB2A50
        public void set_selectAllOnMouseUp(){} // RVA: 0x4EB2AB0
        public void get_doubleClickSelectsWord(){} // RVA: 0x4EB2BE0
        public void set_doubleClickSelectsWord(){} // RVA: 0x4EB2C40
        public void get_tripleClickSelectsLine(){} // RVA: 0x4EB2D70
        public void set_tripleClickSelectsLine(){} // RVA: 0x4EB2DD0
        public void get_text(){} // RVA: 0x4EA70C0
        public void set_text(){} // RVA: 0x4EA7100
        public void get_emojiFallbackSupport(){} // RVA: 0x4EA7120
        public void set_emojiFallbackSupport(){} // RVA: 0x4EA7150
        public void get_verticalScrollerVisibility(){} // RVA: 0x4EA7260
        public void set_verticalScrollerVisibility(){} // RVA: 0x4EB2F00
        public void HandleEventBubbleUp(){} // RVA: 0x4EB3060
        public void ValueToString(){} // RVA: 0x87C160
        public void StringToValue(){} // RVA: 0x87D050
        public void get_canSwitchToMixedValue(){} // RVA: 0x4EA7900
        public void UpdateMixedValueContent(){} // RVA: 0x4EB34B0
        public void OnPlaceholderChanged(){} // RVA: 0x4EB37A0
        public void UpdatePlaceholderClassList(){} // RVA: 0x4EA7E70
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4EB3A70
        public void .cctor(){} // RVA: 0x4EB3AB0
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void get_textEdition(){} // RVA: 0x4EA5910
        public void set_isReadOnly(){} // RVA: 0x4EB7300
        public void set_isDelayed(){} // RVA: 0x4EB7CF0
        public void UpdateValueFromText(){} // RVA: 0x4EB9520
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void get_isDelayed(){} // RVA: 0x4EB7C90
        public void set_password(){} // RVA: 0x4EB6A20
        public void set_readOnly(){} // RVA: 0x4EB6A90
        public void get_placeholderText(){} // RVA: 0x4EB6AB0
        public void set_placeholderText(){} // RVA: 0x4EB6B10
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4EB6C70
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4EB6CD0
        public void .ctor(){} // RVA: 0x4EB6E00
        public void get_textInputBase(){} // RVA: 0x166DF20
        public void get_textSelection(){} // RVA: 0x4EA5910
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4EA5940
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4EA5970
        public void get_isReadOnly(){} // RVA: 0x4EB72A0
        public void get_isPasswordField(){} // RVA: 0x4EB7430
        public void set_isPasswordField(){} // RVA: 0x4EB7490
        public void get_autoCorrection(){} // RVA: 0x4EB75F0
        public void set_autoCorrection(){} // RVA: 0x4EB7650
        public void get_hideMobileInput(){} // RVA: 0x4EB7780
        public void set_hideMobileInput(){} // RVA: 0x4EB77E0
        public void get_keyboardType(){} // RVA: 0x4EB7910
        public void set_keyboardType(){} // RVA: 0x4EB7970
        public void get_maxLength(){} // RVA: 0x4EB7AA0
        public void set_maxLength(){} // RVA: 0x4EB7B00
        public void get_maskChar(){} // RVA: 0x4EB7E20
        public void set_maskChar(){} // RVA: 0x4EB7E80
        public void get_cursorIndex(){} // RVA: 0x4EB7FB0
        public void set_cursorIndex(){} // RVA: 0x4EB8010
        public void get_cursorPosition(){} // RVA: 0x4EB8140
        public void get_selectIndex(){} // RVA: 0x4EB81A0
        public void set_selectIndex(){} // RVA: 0x4EB8200
        public void get_selectAllOnFocus(){} // RVA: 0x4EB8330
        public void set_selectAllOnFocus(){} // RVA: 0x4EB8390
        public void get_selectAllOnMouseUp(){} // RVA: 0x4EB84C0
        public void set_selectAllOnMouseUp(){} // RVA: 0x4EB8520
        public void get_doubleClickSelectsWord(){} // RVA: 0x4EB8650
        public void set_doubleClickSelectsWord(){} // RVA: 0x4EB86B0
        public void get_tripleClickSelectsLine(){} // RVA: 0x4EB87E0
        public void set_tripleClickSelectsLine(){} // RVA: 0x4EB8840
        public void get_text(){} // RVA: 0x4EA70C0
        public void set_text(){} // RVA: 0x4EA7100
        public void get_emojiFallbackSupport(){} // RVA: 0x4EA7120
        public void set_emojiFallbackSupport(){} // RVA: 0x4EA7150
        public void get_verticalScrollerVisibility(){} // RVA: 0x4EA7260
        public void set_verticalScrollerVisibility(){} // RVA: 0x4EB8970
        public void HandleEventBubbleUp(){} // RVA: 0x4EB8AD0
        public void ValueToString(){} // RVA: 0x881D60
        public void StringToValue(){} // RVA: 0x87C540
        public void get_canSwitchToMixedValue(){} // RVA: 0x4EA7900
        public void UpdateMixedValueContent(){} // RVA: 0x4EB8FE0
        public void OnPlaceholderChanged(){} // RVA: 0x4EB92D0
        public void UpdatePlaceholderClassList(){} // RVA: 0x4EA7E70
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4EB95A0
        public void .cctor(){} // RVA: 0x4EB95E0
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void get_textEdition(){} // RVA: 0x4EA5910
        public void set_isReadOnly(){} // RVA: 0x4EC8430
        public void set_isDelayed(){} // RVA: 0x4EC8E20
        public void UpdateValueFromText(){} // RVA: 0x4EB39F0
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void get_isDelayed(){} // RVA: 0x4EC8DC0
        public void set_password(){} // RVA: 0x4EC7B50
        public void set_readOnly(){} // RVA: 0x4EC7BC0
        public void get_placeholderText(){} // RVA: 0x4EC7BE0
        public void set_placeholderText(){} // RVA: 0x4EC7C40
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4EC7DA0
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4EC7E00
        public void .ctor(){} // RVA: 0x4EC7F30
        public void get_textInputBase(){} // RVA: 0x166DF20
        public void get_textSelection(){} // RVA: 0x4EA5910
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4EA5940
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4EA5970
        public void get_isReadOnly(){} // RVA: 0x4EC83D0
        public void get_isPasswordField(){} // RVA: 0x4EC8560
        public void set_isPasswordField(){} // RVA: 0x4EC85C0
        public void get_autoCorrection(){} // RVA: 0x4EC8720
        public void set_autoCorrection(){} // RVA: 0x4EC8780
        public void get_hideMobileInput(){} // RVA: 0x4EC88B0
        public void set_hideMobileInput(){} // RVA: 0x4EC8910
        public void get_keyboardType(){} // RVA: 0x4EC8A40
        public void set_keyboardType(){} // RVA: 0x4EC8AA0
        public void get_maxLength(){} // RVA: 0x4EC8BD0
        public void set_maxLength(){} // RVA: 0x4EC8C30
        public void get_maskChar(){} // RVA: 0x4EC8F50
        public void set_maskChar(){} // RVA: 0x4EC8FB0
        public void get_cursorIndex(){} // RVA: 0x4EC90E0
        public void set_cursorIndex(){} // RVA: 0x4EC9140
        public void get_cursorPosition(){} // RVA: 0x4EC9270
        public void get_selectIndex(){} // RVA: 0x4EC92D0
        public void set_selectIndex(){} // RVA: 0x4EC9330
        public void get_selectAllOnFocus(){} // RVA: 0x4EC9460
        public void set_selectAllOnFocus(){} // RVA: 0x4EC94C0
        public void get_selectAllOnMouseUp(){} // RVA: 0x4EC95F0
        public void set_selectAllOnMouseUp(){} // RVA: 0x4EC9650
        public void get_doubleClickSelectsWord(){} // RVA: 0x4EC9780
        public void set_doubleClickSelectsWord(){} // RVA: 0x4EC97E0
        public void get_tripleClickSelectsLine(){} // RVA: 0x4EC9910
        public void set_tripleClickSelectsLine(){} // RVA: 0x4EC9970
        public void get_text(){} // RVA: 0x4EA70C0
        public void set_text(){} // RVA: 0x4EA7100
        public void get_emojiFallbackSupport(){} // RVA: 0x4EA7120
        public void set_emojiFallbackSupport(){} // RVA: 0x4EA7150
        public void get_verticalScrollerVisibility(){} // RVA: 0x4EA7260
        public void set_verticalScrollerVisibility(){} // RVA: 0x4EC9AA0
        public void HandleEventBubbleUp(){} // RVA: 0x4EC9C00
        public void ValueToString(){} // RVA: 0x87C160
        public void StringToValue(){} // RVA: 0x87D050
        public void get_canSwitchToMixedValue(){} // RVA: 0x4EA7900
        public void UpdateMixedValueContent(){} // RVA: 0x4ECA110
        public void OnPlaceholderChanged(){} // RVA: 0x4ECA400
        public void UpdatePlaceholderClassList(){} // RVA: 0x4EA7E70
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4ECA650
        public void .cctor(){} // RVA: 0x4ECA690
    }

    public class TextInputBaseField`1 : BaseField`1
    {
        // ── Methods ──
        public void get_textEdition(){} // RVA: 0x4EA5910
        public void set_isReadOnly(){} // RVA: 0x4ECDEE0
        public void set_isDelayed(){} // RVA: 0x4ECE8D0
        public void UpdateValueFromText(){} // RVA: 0x4EB9520
        public void UpdateTextFromValue(){} // RVA: 0xB43310
        public void get_isDelayed(){} // RVA: 0x4ECE870
        public void set_password(){} // RVA: 0x4ECD600
        public void set_readOnly(){} // RVA: 0x4ECD670
        public void get_placeholderText(){} // RVA: 0x4ECD690
        public void set_placeholderText(){} // RVA: 0x4ECD6F0
        public void get_hidePlaceholderOnFocus(){} // RVA: 0x4ECD850
        public void set_hidePlaceholderOnFocus(){} // RVA: 0x4ECD8B0
        public void .ctor(){} // RVA: 0x4ECD9E0
        public void get_textInputBase(){} // RVA: 0x166DF20
        public void get_textSelection(){} // RVA: 0x4EA5910
        public void get_onIsReadOnlyChanged(){} // RVA: 0x4EA5940
        public void set_onIsReadOnlyChanged(){} // RVA: 0x4EA5970
        public void get_isReadOnly(){} // RVA: 0x4ECDE80
        public void get_isPasswordField(){} // RVA: 0x4ECE010
        public void set_isPasswordField(){} // RVA: 0x4ECE070
        public void get_autoCorrection(){} // RVA: 0x4ECE1D0
        public void set_autoCorrection(){} // RVA: 0x4ECE230
        public void get_hideMobileInput(){} // RVA: 0x4ECE360
        public void set_hideMobileInput(){} // RVA: 0x4ECE3C0
        public void get_keyboardType(){} // RVA: 0x4ECE4F0
        public void set_keyboardType(){} // RVA: 0x4ECE550
        public void get_maxLength(){} // RVA: 0x4ECE680
        public void set_maxLength(){} // RVA: 0x4ECE6E0
        public void get_maskChar(){} // RVA: 0x4ECEA00
        public void set_maskChar(){} // RVA: 0x4ECEA60
        public void get_cursorIndex(){} // RVA: 0x4ECEB90
        public void set_cursorIndex(){} // RVA: 0x4ECEBF0
        public void get_cursorPosition(){} // RVA: 0x4ECED20
        public void get_selectIndex(){} // RVA: 0x4ECED80
        public void set_selectIndex(){} // RVA: 0x4ECEDE0
        public void get_selectAllOnFocus(){} // RVA: 0x4ECEF10
        public void set_selectAllOnFocus(){} // RVA: 0x4ECEF70
        public void get_selectAllOnMouseUp(){} // RVA: 0x4ECF0A0
        public void set_selectAllOnMouseUp(){} // RVA: 0x4ECF100
        public void get_doubleClickSelectsWord(){} // RVA: 0x4ECF230
        public void set_doubleClickSelectsWord(){} // RVA: 0x4ECF290
        public void get_tripleClickSelectsLine(){} // RVA: 0x4ECF3C0
        public void set_tripleClickSelectsLine(){} // RVA: 0x4ECF420
        public void get_text(){} // RVA: 0x4EA70C0
        public void set_text(){} // RVA: 0x4EA7100
        public void get_emojiFallbackSupport(){} // RVA: 0x4EA7120
        public void set_emojiFallbackSupport(){} // RVA: 0x4EA7150
        public void get_verticalScrollerVisibility(){} // RVA: 0x4EA7260
        public void set_verticalScrollerVisibility(){} // RVA: 0x4ECF550
        public void HandleEventBubbleUp(){} // RVA: 0x4ECF6B0
        public void ValueToString(){} // RVA: 0x881D60
        public void StringToValue(){} // RVA: 0x87C540
        public void get_canSwitchToMixedValue(){} // RVA: 0x4EA7900
        public void UpdateMixedValueContent(){} // RVA: 0x4ECFBC0
        public void OnPlaceholderChanged(){} // RVA: 0x4ECFEB0
        public void UpdatePlaceholderClassList(){} // RVA: 0x4EA7E70
        public void OnFieldCustomStyleResolved(){} // RVA: 0x4ED0100
        public void .cctor(){} // RVA: 0x4ED0140
    }

    public class TextJobSystem : Object
    {
        // ── Methods ──
        public void GenerateText(){} // RVA: 0x7EF8FB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TextSelectingManipulator : Object
    {
        // ── Methods ──
        public void get_isClicking(){} // RVA: 0xB68E10
        public void set_isClicking(){} // RVA: 0x7EF9150
        public void .ctor(){} // RVA: 0x7EF9160
        public void get_cursorIndex(){} // RVA: 0x7EF9630
        public void set_cursorIndex(){} // RVA: 0x7C93D50
        public void get_selectIndex(){} // RVA: 0x7EF9650
        public void set_selectIndex(){} // RVA: 0x7C93D90
        public void OnRevealCursor(){} // RVA: 0x7EF9670
        public void OnSelectIndexChange(){} // RVA: 0x7EF96C0
        public void OnCursorIndexChange(){} // RVA: 0x7EF97D0
        public void RevealCursor(){} // RVA: 0x23ADB30
        public void HasSelection(){} // RVA: 0x7C93C50
        public void HasFocus(){} // RVA: 0x7EF98E0
        public void HandleEventBubbleUp(){} // RVA: 0x7EF9900
        public void OnFocusEvent(){} // RVA: 0x7EF9D80
        public void OnBlurEvent(){} // RVA: 0x7EF9F80
        public void OnKeyDown(){} // RVA: 0x7EF9FE0
        public void OnPointerDownEvent(){} // RVA: 0x7EFA050
        public void OnPointerMoveEvent(){} // RVA: 0x7EFA3B0
        public void OnPointerUpEvent(){} // RVA: 0x7EFA540
        public void OnValidateCommandEvent(){} // RVA: 0x7EFA5F0
        public void OnExecuteCommandEvent(){} // RVA: 0x7EFA840
        public void MoveDistanceQualifiesForDrag(){} // RVA: 0x7EFA9F0
    }

    public class TextShadow : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x99A760
        public void GetHashCode(){} // RVA: 0x99A7A0
        public void op_Equality(){} // RVA: 0x7F09520
        public void op_Inequality(){} // RVA: 0x7F09550
        public void ToString(){} // RVA: 0x99A7B0
        public void LerpUnclamped(){} // RVA: 0x7F09730
    }

    public class TextUtilities : Object
    {
        // ── Methods ──
        public void MeasureVisualElementTextSize(){} // RVA: 0x7EFAA30
        public void GetFontAsset(){} // RVA: 0x7EFADD0
        public void IsFontAssigned(){} // RVA: 0x7EFB220
        public void GetTextSettingsFrom(){} // RVA: 0x7EFB380
        public void IsAdvancedTextEnabledForElement(){} // RVA: 0x7EFB450
        public void GetTextCoreSettingsForElement(){} // RVA: 0x7EFB610
        public void toTextWrappingMode(){} // RVA: 0x7EFBB70
        public void toTextCore(){} // RVA: 0x7EFBC00
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x8954D0
        public void .ctor(){} // RVA: 0x894290
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x4EDC3C0
        public void .ctor(){} // RVA: 0x4EDC7C0
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x4EDE500
        public void .ctor(){} // RVA: 0x4EDE900
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x4EDCC10
        public void .ctor(){} // RVA: 0x4EDD010
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x4EDD460
        public void .ctor(){} // RVA: 0x4EDD860
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x4EDDCB0
        public void .ctor(){} // RVA: 0x4EDE0B0
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x4EDED50
        public void .ctor(){} // RVA: 0x4EDF150
    }

    public class TextValueFieldTraits`2 : BaseFieldTraits`2
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x4EDF5A0
        public void .ctor(){} // RVA: 0x4EDF9A0
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x87C0A0
        public void get_formatString(){} // RVA: 0x87C0A0
        public void set_formatString(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894600
        public void ApplyInputDeviceDelta(){} // RVA: 0xA94080
        public void StartDragging(){} // RVA: 0x894290
        public void StopDragging(){} // RVA: 0x894290
        public void UpdateValueFromText(){} // RVA: 0x894290
        public void UpdateTextFromValue(){} // RVA: 0x894290
        public void OnIsReadOnlyChanged(){} // RVA: 0x894750
        public void CanTryParse(){} // RVA: 0x87D350
        public void AddLabelDragger(){} // RVA: 0x894290
        public void EnableLabelDragger(){} // RVA: 0x894750
        public void SetValueWithoutNotify(){} // RVA: 0xA94080
        public void HandleEventBubbleUp(){} // RVA: 0x894320
        public void OnViewDataReady(){} // RVA: 0x894290
        public void RegisterEditingCallbacks(){} // RVA: 0x894290
        public void UnregisterEditingCallbacks(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x4EE0550
        public void get_formatString(){} // RVA: 0x4EE05E0
        public void set_formatString(){} // RVA: 0x4EE0670
        public void .ctor(){} // RVA: 0x4EE0910
        public void ApplyInputDeviceDelta(){} // RVA: 0x89B870
        public void StartDragging(){} // RVA: 0x4EE0B40
        public void StopDragging(){} // RVA: 0x4EE0C70
        public void UpdateValueFromText(){} // RVA: 0x4EE0E30
        public void UpdateTextFromValue(){} // RVA: 0x4EE0F50
        public void OnIsReadOnlyChanged(){} // RVA: 0x4EE0FB0
        public void CanTryParse(){} // RVA: 0xB43320
        public void AddLabelDragger(){} // RVA: 0x894290
        public void EnableLabelDragger(){} // RVA: 0x4EE0FD0
        public void SetValueWithoutNotify(){} // RVA: 0x4EE10E0
        public void HandleEventBubbleUp(){} // RVA: 0x4EE1290
        public void OnViewDataReady(){} // RVA: 0x4EE1590
        public void RegisterEditingCallbacks(){} // RVA: 0x4EE15B0
        public void UnregisterEditingCallbacks(){} // RVA: 0x4EE17E0
        public void .cctor(){} // RVA: 0x4EE1AB0
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x4EE0550
        public void get_formatString(){} // RVA: 0x4EE05E0
        public void set_formatString(){} // RVA: 0x4EE4620
        public void .ctor(){} // RVA: 0x4EE48C0
        public void ApplyInputDeviceDelta(){} // RVA: 0x89C820
        public void StartDragging(){} // RVA: 0x4EE4AF0
        public void StopDragging(){} // RVA: 0x4EE4C20
        public void UpdateValueFromText(){} // RVA: 0x4EE0E30
        public void UpdateTextFromValue(){} // RVA: 0x4EE4DE0
        public void OnIsReadOnlyChanged(){} // RVA: 0x4EE0FB0
        public void CanTryParse(){} // RVA: 0xB43320
        public void AddLabelDragger(){} // RVA: 0x894290
        public void EnableLabelDragger(){} // RVA: 0x4EE0FD0
        public void SetValueWithoutNotify(){} // RVA: 0x4EE4E40
        public void HandleEventBubbleUp(){} // RVA: 0x4EE4F60
        public void OnViewDataReady(){} // RVA: 0x4EE5260
        public void RegisterEditingCallbacks(){} // RVA: 0x4EE5280
        public void UnregisterEditingCallbacks(){} // RVA: 0x4EE54B0
        public void .cctor(){} // RVA: 0x4EE5780
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x4EE0550
        public void get_formatString(){} // RVA: 0x4EE05E0
        public void set_formatString(){} // RVA: 0x4EE1CB0
        public void .ctor(){} // RVA: 0x4EE1F50
        public void ApplyInputDeviceDelta(){} // RVA: 0x89B9B0
        public void StartDragging(){} // RVA: 0x4EE2180
        public void StopDragging(){} // RVA: 0x4EE22B0
        public void UpdateValueFromText(){} // RVA: 0x4EE2470
        public void UpdateTextFromValue(){} // RVA: 0x4EE2590
        public void OnIsReadOnlyChanged(){} // RVA: 0x4EE0FB0
        public void CanTryParse(){} // RVA: 0xB43320
        public void AddLabelDragger(){} // RVA: 0x894290
        public void EnableLabelDragger(){} // RVA: 0x4EE0FD0
        public void SetValueWithoutNotify(){} // RVA: 0x4EE25E0
        public void HandleEventBubbleUp(){} // RVA: 0x4EE2700
        public void OnViewDataReady(){} // RVA: 0x4EE2A00
        public void RegisterEditingCallbacks(){} // RVA: 0x4EE2A20
        public void UnregisterEditingCallbacks(){} // RVA: 0x4EE2C50
        public void .cctor(){} // RVA: 0x4EE2F20
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x4EE0550
        public void get_formatString(){} // RVA: 0x4EE05E0
        public void set_formatString(){} // RVA: 0x4EE3120
        public void .ctor(){} // RVA: 0x4EE33C0
        public void ApplyInputDeviceDelta(){} // RVA: 0x89B820
        public void StartDragging(){} // RVA: 0x4EE35F0
        public void StopDragging(){} // RVA: 0x4EE3720
        public void UpdateValueFromText(){} // RVA: 0x4EE38E0
        public void UpdateTextFromValue(){} // RVA: 0x4EE3A00
        public void OnIsReadOnlyChanged(){} // RVA: 0x4EE0FB0
        public void CanTryParse(){} // RVA: 0xB43320
        public void AddLabelDragger(){} // RVA: 0x894290
        public void EnableLabelDragger(){} // RVA: 0x4EE0FD0
        public void SetValueWithoutNotify(){} // RVA: 0x4EE3A60
        public void HandleEventBubbleUp(){} // RVA: 0x4EE3C00
        public void OnViewDataReady(){} // RVA: 0x4EE3F00
        public void RegisterEditingCallbacks(){} // RVA: 0x4EE3F20
        public void UnregisterEditingCallbacks(){} // RVA: 0x4EE4150
        public void .cctor(){} // RVA: 0x4EE4420
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x4EE0550
        public void get_formatString(){} // RVA: 0x4EE05E0
        public void set_formatString(){} // RVA: 0x4EE5980
        public void .ctor(){} // RVA: 0x4EE5C20
        public void ApplyInputDeviceDelta(){} // RVA: 0x89B9B0
        public void StartDragging(){} // RVA: 0x4EE5E50
        public void StopDragging(){} // RVA: 0x4EE5F80
        public void UpdateValueFromText(){} // RVA: 0x4EE2470
        public void UpdateTextFromValue(){} // RVA: 0x4EE2590
        public void OnIsReadOnlyChanged(){} // RVA: 0x4EE0FB0
        public void CanTryParse(){} // RVA: 0xB43320
        public void AddLabelDragger(){} // RVA: 0x894290
        public void EnableLabelDragger(){} // RVA: 0x4EE0FD0
        public void SetValueWithoutNotify(){} // RVA: 0x4EE6140
        public void HandleEventBubbleUp(){} // RVA: 0x4EE62E0
        public void OnViewDataReady(){} // RVA: 0x4EE65E0
        public void RegisterEditingCallbacks(){} // RVA: 0x4EE6600
        public void UnregisterEditingCallbacks(){} // RVA: 0x4EE6830
        public void .cctor(){} // RVA: 0x4EE6B00
    }

    public class TextValueField`1 : TextInputBaseField`1
    {
        // ── Methods ──
        public void get_textValueInput(){} // RVA: 0x4EE0550
        public void get_formatString(){} // RVA: 0x4EE05E0
        public void set_formatString(){} // RVA: 0x4EE6D00
        public void .ctor(){} // RVA: 0x4EE6FA0
        public void ApplyInputDeviceDelta(){} // RVA: 0x89B820
        public void StartDragging(){} // RVA: 0x4EE71D0
        public void StopDragging(){} // RVA: 0x4EE7300
        public void UpdateValueFromText(){} // RVA: 0x4EE38E0
        public void UpdateTextFromValue(){} // RVA: 0x4EE3A00
        public void OnIsReadOnlyChanged(){} // RVA: 0x4EE0FB0
        public void CanTryParse(){} // RVA: 0xB43320
        public void AddLabelDragger(){} // RVA: 0x894290
        public void EnableLabelDragger(){} // RVA: 0x4EE0FD0
        public void SetValueWithoutNotify(){} // RVA: 0x4EE74C0
        public void HandleEventBubbleUp(){} // RVA: 0x4EE7660
        public void OnViewDataReady(){} // RVA: 0x4EE7960
        public void RegisterEditingCallbacks(){} // RVA: 0x4EE7980
        public void UnregisterEditingCallbacks(){} // RVA: 0x4EE7BB0
        public void .cctor(){} // RVA: 0x4EE7E80
    }

    public class TextureId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A9E20
        public void get_index(){} // RVA: 0x9A9E30
        public void ConvertToGpu(){} // RVA: 0x9A9E40
        public void Equals(){} // RVA: 0x9A9EA0
        public void GetHashCode(){} // RVA: 0x454FE0
        public void op_Equality(){} // RVA: 0x7BF2630
        public void op_Inequality(){} // RVA: 0x80ADBB0
        public void .cctor(){} // RVA: 0x80ADC10
    }

    public class TextureRegistry : Object
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x80ADC50
        public void GetTexture(){} // RVA: 0x80ADCB0
        public void AllocAndAcquireDynamic(){} // RVA: 0x80ADEE0
        public void UpdateDynamic(){} // RVA: 0x80ADEF0
        public void AllocAndAcquire(){} // RVA: 0x80AE220
        public void Acquire(){} // RVA: 0x80AE630
        public void Release(){} // RVA: 0x80AE800
        public void .ctor(){} // RVA: 0x80AEB90
        public void .cctor(){} // RVA: 0x80AEF70
    }

    public class ThemeStyleSheet : StyleSheet
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7EEC4E0
        public void .ctor(){} // RVA: 0x7EEC510
    }

    public class TimeMsFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23F1BA0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class TimeValue : ValueType
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x88D10
        public void set_value(){} // RVA: 0xD1B20
        public void get_unit(){} // RVA: 0x77E50
        public void set_unit(){} // RVA: 0x77EE0
        public void .ctor(){} // RVA: 0x22C190
        public void op_Implicit(){} // RVA: 0x7ED9E70
        public void op_Equality(){} // RVA: 0x7ED69E0
        public void op_Inequality(){} // RVA: 0x7ED6A10
        public void Equals(){} // RVA: 0x999150
        public void GetHashCode(){} // RVA: 0x996F20
        public void ToString(){} // RVA: 0x999160
    }

    public class TimeValue[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EBC520
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3CA0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E74AE0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TimerEventScheduler : Object
    {
        // ── Methods ──
        public void Schedule(){} // RVA: 0x80B00E0
        public void RemovedScheduledItemAt(){} // RVA: 0x80B02A0
        public void Unschedule(){} // RVA: 0x80B0320
        public void PrivateUnSchedule(){} // RVA: 0x80B05B0
        public void get_FrameCount(){} // RVA: 0x7C7DF30
        public void set_FrameCount(){} // RVA: 0xE9F6B0
        public void UpdateScheduledEvents(){} // RVA: 0x80B06C0
        public void .ctor(){} // RVA: 0x80B1290
    }

    public class TimerState : ValueType
    {
        // ── Methods ──
        public void get_start(){} // RVA: 0x77900
        public void set_start(){} // RVA: 0x93050
        public void get_now(){} // RVA: 0x77ED0
        public void set_now(){} // RVA: 0x990A0
        public void get_deltaTime(){} // RVA: 0x9A9F70
        public void Equals(){} // RVA: 0x9AA020
        public void GetHashCode(){} // RVA: 0x9AA050
    }

    public class Toggle : BaseBoolField
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x802FB00
        public void InitLabel(){} // RVA: 0x802FC40
        public void UpdateMixedValueContent(){} // RVA: 0x802FCC0
        public void .cctor(){} // RVA: 0x802FE70
    }

    public class ToggleButtonGroup : BaseField`1
    {
        // ── Methods ──
        public void get_isMultipleSelection(){} // RVA: 0x80305E0
        public void set_isMultipleSelection(){} // RVA: 0x80305F0
        public void get_allowEmptySelection(){} // RVA: 0x80307F0
        public void set_allowEmptySelection(){} // RVA: 0x8030800
        public void .ctor(){} // RVA: 0x8030B10
        public void get_contentContainer(){} // RVA: 0x8012360
        public void OnViewDataReady(){} // RVA: 0x8030F00
        public void UpdateMixedValueContent(){} // RVA: 0x8030F80
        public void SetValueWithoutNotify(){} // RVA: 0x80311F0
        public void OnButtonGroupContainerElementAdded(){} // RVA: 0x80314A0
        public void OnButtonGroupContainerElementRemoved(){} // RVA: 0x80319E0
        public void UpdateButtonStates(){} // RVA: 0x8031E60
        public void OnOptionChange(){} // RVA: 0x8032080
        public void UpdateButtonsStyling(){} // RVA: 0x80323D0
        public void .cctor(){} // RVA: 0x8032610
    }

    public class ToggleButtonGroupState : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A40F0
        public void get_length(){} // RVA: 0x14790
        public void set_length(){} // RVA: 0x92DD0
        public void get_data(){} // RVA: 0x77900
        public void get_Item(){} // RVA: 0x9A4100
        public void set_Item(){} // RVA: 0x9A4110
        public void GetActiveOptions(){} // RVA: 0x9A4120
        public void ResetAllOptions(){} // RVA: 0x9A4160
        public void CompareTo(){} // RVA: 0x9A4170
        public void ResetOptions(){} // RVA: 0x9A41C0
        public void op_Equality(){} // RVA: 0x3F8D7B0
        public void op_Inequality(){} // RVA: 0x8033B40
        public void Equals(){} // RVA: 0x9A4210
        public void GetHashCode(){} // RVA: 0x9A42A0
        public void ToString(){} // RVA: 0x9A42B0
    }

    public class TooltipEvent : EventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x806AC30
        public void set_tooltip(){} // RVA: 0xBBFFA0
        public void set_rect(){} // RVA: 0x6A8AF10
        public void Init(){} // RVA: 0x806AD20
        public void LocalInit(){} // RVA: 0x806ADD0
        public void .ctor(){} // RVA: 0x806AE50
    }

    public class TouchScreenTextEditorEventHandler : TextEditorEventHandler
    {
        // ── Methods ──
        public void get_Frame(){} // RVA: 0x7FF0AF0
        public void set_Frame(){} // RVA: 0x7FF0B30
        public void set_activeTouchScreenKeyboard(){} // RVA: 0x7FF0B80
        public void .ctor(){} // RVA: 0x7FF0C20
        public void PollTouchScreenKeyboard(){} // RVA: 0x7FF0C90
        public void DoPollTouchScreenKeyboard(){} // RVA: 0x7FF0E00
        public void UpdateStringPositionFromKeyboard(){} // RVA: 0x7FF1420
        public void CloseTouchScreenKeyboard(){} // RVA: 0x7FF1560
        public void OpenTouchScreenKeyboard(){} // RVA: 0x7FF16E0
        public void HandleEventBubbleUp(){} // RVA: 0x7FF19C0
        public void OnPointerDownEvent(){} // RVA: 0x7FF1C70
        public void OnPointerUpEvent(){} // RVA: 0x7FF1D80
        public void OnFocusInEvent(){} // RVA: 0x7FF1DA0
        public void OnFocusOutEvent(){} // RVA: 0x7FF1FA0
    }

    public class TransformData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x9967E0
        public void CopyFrom(){} // RVA: 0x996820
        public void op_Equality(){} // RVA: 0x7ED30C0
        public void Equals(){} // RVA: 0x9968A0
        public void GetHashCode(){} // RVA: 0x996970
    }

    public class TransformOrigin : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9992F0
        public void Initial(){} // RVA: 0x7EDD4B0
        public void get_x(){} // RVA: 0x77900
        public void set_x(){} // RVA: 0x93050
        public void get_y(){} // RVA: 0x77ED0
        public void set_y(){} // RVA: 0x990A0
        public void get_z(){} // RVA: 0xFF750
        public void set_z(){} // RVA: 0xFF760
        public void op_Equality(){} // RVA: 0x7EDD530
        public void op_Inequality(){} // RVA: 0x7EDD5D0
        public void Equals(){} // RVA: 0x9993A0
        public void GetHashCode(){} // RVA: 0x9993B0
        public void ToString(){} // RVA: 0x9993C0
    }

    public class TransitionCancelEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x806BA10
        public void .ctor(){} // RVA: 0x806BB00
    }

    public class TransitionData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x996A40
        public void CopyFrom(){} // RVA: 0x996A70
        public void op_Equality(){} // RVA: 0x7ED3CA0
        public void Equals(){} // RVA: 0x996AC0
        public void GetHashCode(){} // RVA: 0x996B70
    }

    public class TransitionEndEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x806B7D0
        public void .ctor(){} // RVA: 0x806B8C0
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0xA94080
        public void set_elapsedTime(){} // RVA: 0x895980
        public void .ctor(){} // RVA: 0x894290
        public void Init(){} // RVA: 0x894290
        public void LocalInit(){} // RVA: 0x894290
        public void GetPooled(){} // RVA: 0xA94080
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0xBBFF90
        public void set_elapsedTime(){} // RVA: 0x4F23290
        public void .ctor(){} // RVA: 0x4F232A0
        public void Init(){} // RVA: 0x4F23470
        public void LocalInit(){} // RVA: 0x4F23560
        public void GetPooled(){} // RVA: 0x4F235E0
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0xBBFF90
        public void set_elapsedTime(){} // RVA: 0x4F23290
        public void .ctor(){} // RVA: 0x4F232A0
        public void Init(){} // RVA: 0x4F23470
        public void LocalInit(){} // RVA: 0x4F23560
        public void GetPooled(){} // RVA: 0x4F235E0
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0xBBFF90
        public void set_elapsedTime(){} // RVA: 0x4F23290
        public void .ctor(){} // RVA: 0x4F232A0
        public void Init(){} // RVA: 0x4F23470
        public void LocalInit(){} // RVA: 0x4F23560
        public void GetPooled(){} // RVA: 0x4F235E0
    }

    public class TransitionEventBase`1 : EventBase`1
    {
        // ── Methods ──
        public void get_stylePropertyNames(){} // RVA: 0xBBFF90
        public void set_elapsedTime(){} // RVA: 0x4F23290
        public void .ctor(){} // RVA: 0x4F232A0
        public void Init(){} // RVA: 0x4F23470
        public void LocalInit(){} // RVA: 0x4F23560
        public void GetPooled(){} // RVA: 0x4F235E0
    }

    public class TransitionRunEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x806B350
        public void .ctor(){} // RVA: 0x806B440
    }

    public class TransitionStartEvent : TransitionEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x806B590
        public void .ctor(){} // RVA: 0x806B680
    }

    public class Translate : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x999570
        public void None(){} // RVA: 0x7EDDFF0
        public void get_x(){} // RVA: 0x77900
        public void set_x(){} // RVA: 0x93050
        public void get_y(){} // RVA: 0x77ED0
        public void set_y(){} // RVA: 0x990A0
        public void get_z(){} // RVA: 0xFF750
        public void set_z(){} // RVA: 0xFF760
        public void op_Equality(){} // RVA: 0x7EDE020
        public void op_Inequality(){} // RVA: 0x7EDE130
        public void Equals(){} // RVA: 0x999650
        public void GetHashCode(){} // RVA: 0x9993B0
        public void ToString(){} // RVA: 0x999660
    }

    public class TreeDataController`1 : Object
    {
        // ── Methods ──
        public void GetDataForNode(){} // RVA: 0xA94080
        public void ConvertTreeViewItemDataToHierarchy(){} // RVA: 0x8954D0
        public void UpdateNodeToDataDictionary(){} // RVA: 0xA94080
        public void ClearNodeToDataDictionary(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class TreeView : BaseTreeView
    {
        // ── Methods ──
        public void get_makeItem(){} // RVA: 0x16535F0
        public void set_makeItem(){} // RVA: 0x8033E90
        public void get_itemTemplate(){} // RVA: 0x16633F0
        public void set_itemTemplate(){} // RVA: 0x8033FA0
        public void TemplateMakeItem(){} // RVA: 0x80341C0
        public void get_bindItem(){} // RVA: 0x164A220
        public void set_bindItem(){} // RVA: 0x8034320
        public void get_unbindItem(){} // RVA: 0x1650B10
        public void set_unbindItem(){} // RVA: 0x8034430
        public void get_destroyItem(){} // RVA: 0x163FB40
        public void set_destroyItem(){} // RVA: 0x8034540
        public void HasValidDataAndBindings(){} // RVA: 0x8034650
        public void CreateViewController(){} // RVA: 0x80346B0
        public void .ctor(){} // RVA: 0x8034750
        public void .cctor(){} // RVA: 0x8034970
    }

    public class TreeViewController : BaseTreeViewController
    {
        // ── Methods ──
        public void get_treeView(){} // RVA: 0x7E8CDB0
        public void MakeItem(){} // RVA: 0x7E8CE30
        public void BindItem(){} // RVA: 0x7E8CF40
        public void UnbindItem(){} // RVA: 0x7E8D110
        public void DestroyItem(){} // RVA: 0x7E8D160
        public void .ctor(){} // RVA: 0x35B0280
    }

    public class TreeViewExpansionChangedArgs : Object
    {
        // ── Methods ──
        public void set_id(){} // RVA: 0xB460A0
        public void set_isExpanded(){} // RVA: 0xC9C260
        public void set_isAppliedToAllChildren(){} // RVA: 0x2220220
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TreeViewItemData`1 : ValueType
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x87C130
        public void get_data(){} // RVA: 0xA94080
        public void get_children(){} // RVA: 0x87C0A0
    }

    public class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8050A60
        public void CompareId(){} // RVA: 0x8050C10
        public void SetupDragAndDrop(){} // RVA: 0x80513B0
        public void HandleDragAndDrop(){} // RVA: 0x80515C0
        public void CanDrop(){} // RVA: 0x295D5B0
        public void OnDrop(){} // RVA: 0x8051670
        public void DragCleanup(){} // RVA: 0x8051E40
        public void RestoreExpanded(){} // RVA: 0x8051F90
        public void HandleAutoExpand(){} // RVA: 0x8052230
        public void DelayExpandDropItem(){} // RVA: 0x8052490
        public void ExpandDropItem(){} // RVA: 0x8052590
    }

    public class TwoPaneSplitView : VisualElement
    {
        // ── Methods ──
        public void get_fixedPane(){} // RVA: 0x16686F0
        public void get_flexedPane(){} // RVA: 0x1653580
        public void get_dragLine(){} // RVA: 0x1662E30
        public void get_fixedPaneIndex(){} // RVA: 0x8035230
        public void set_fixedPaneIndex(){} // RVA: 0x8035240
        public void get_fixedPaneInitialDimension(){} // RVA: 0x80352F0
        public void set_fixedPaneInitialDimension(){} // RVA: 0x8035300
        public void get_orientation(){} // RVA: 0x60DFAF0
        public void set_orientation(){} // RVA: 0x80353B0
        public void get_fixedPaneDimension(){} // RVA: 0x8035460
        public void set_fixedPaneDimension(){} // RVA: 0x8035490
        public void .ctor(){} // RVA: 0x80354B0
        public void SetupSplitView(){} // RVA: 0x8035560
        public void CollapseChild(){} // RVA: 0x8035A00
        public void Init(){} // RVA: 0x8035D40
        public void OnPostDisplaySetup(){} // RVA: 0x80361C0
        public void ReplacePanesBasedOnAnchor(){} // RVA: 0x80363E0
        public void IdentifyLeftAndRightPane(){} // RVA: 0x80365E0
        public void PostDisplaySetup(){} // RVA: 0x8036870
        public void OnSizeChange(){} // RVA: 0x8037690
        public void UpdateLayout(){} // RVA: 0x80376A0
        public void get_contentContainer(){} // RVA: 0x8037EF0
        public void OnViewDataReady(){} // RVA: 0x8037F00
        public void SetDragLineOffset(){} // RVA: 0x8037F30
        public void SetFixedPaneDimension(){} // RVA: 0x80380F0
        public void .cctor(){} // RVA: 0x80382B0
    }

    public class TwoPaneSplitViewResizer : PointerManipulator
    {
        // ── Methods ──
        public void get_orientation(){} // RVA: 0x80391F0
        public void get_fixedPane(){} // RVA: 0x8039210
        public void get_flexedPane(){} // RVA: 0x8039230
        public void get_fixedPaneMinDimension(){} // RVA: 0x8039250
        public void get_fixedPaneMargins(){} // RVA: 0x8039300
        public void get_flexedPaneMinDimension(){} // RVA: 0x8039420
        public void get_flexedPaneMargin(){} // RVA: 0x80394D0
        public void .ctor(){} // RVA: 0x80395F0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x8039760
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x8039900
        public void ApplyDelta(){} // RVA: 0x8039CD0
        public void OnPointerDown(){} // RVA: 0x803A560
        public void OnPointerMove(){} // RVA: 0x803A620
        public void OnPointerUp(){} // RVA: 0x803A9D0
        public void InterruptPointerMove(){} // RVA: 0x803AA90
    }

    public class TypeConverterRegistry : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void Create(){} // RVA: 0x7E56540
        public void Register(){} // RVA: 0x990E90
        public void Apply(){} // RVA: 0x990EA0
        public void GetConverter(){} // RVA: 0x990EB0
        public void TryGetConverter(){} // RVA: 0x990EC0
        public void Equals(){} // RVA: 0x989C10
        public void GetHashCode(){} // RVA: 0x989C20
        public void .cctor(){} // RVA: 0x7E56D40
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0xA94080
        public void get_defaultValue(){} // RVA: 0xA94080
        public void set_defaultValue(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x882520
        public void get_defaultValue(){} // RVA: 0x27EAE50
        public void set_defaultValue(){} // RVA: 0x27EAE60
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x891760
        public void get_defaultValue(){} // RVA: 0xD344A0
        public void set_defaultValue(){} // RVA: 0xD34230
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x87C6B0
        public void get_defaultValue(){} // RVA: 0x16DCC90
        public void set_defaultValue(){} // RVA: 0x16DCEE0
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x87C5F0
        public void get_defaultValue(){} // RVA: 0xBC1B30
        public void set_defaultValue(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x881CA0
        public void get_defaultValue(){} // RVA: 0xBE5850
        public void set_defaultValue(){} // RVA: 0xBE5860
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x87C5F0
        public void get_defaultValue(){} // RVA: 0xBC1B30
        public void set_defaultValue(){} // RVA: 0xE9E8B0
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x87D3C0
        public void get_defaultValue(){} // RVA: 0xC02470
        public void set_defaultValue(){} // RVA: 0xC02480
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x881CA0
        public void get_defaultValue(){} // RVA: 0xBE5850
        public void set_defaultValue(){} // RVA: 0xBE5860
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x87C5F0
        public void get_defaultValue(){} // RVA: 0xBC1B30
        public void set_defaultValue(){} // RVA: 0xE9E8B0
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0xA94080
        public void get_defaultValue(){} // RVA: 0xAD0950
        public void set_defaultValue(){} // RVA: 0x412AD50
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0x87C5F0
        public void get_defaultValue(){} // RVA: 0xBC1B30
        public void set_defaultValue(){} // RVA: 0xB6A8C0
        public void .ctor(){} // RVA: 0x4FADD60
    }

    public class TypedUxmlAttributeDescription`1 : UxmlAttributeDescription
    {
        // ── Methods ──
        public void GetValueFromBag(){} // RVA: 0xA94080
        public void get_defaultValue(){} // RVA: 0xAD0950
        public void set_defaultValue(){} // RVA: 0x412AD50
        public void .ctor(){} // RVA: 0x4FADD60
    }

}