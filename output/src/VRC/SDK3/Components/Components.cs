// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components
// Classes: 25
// Methods: 281

namespace VRC.SDK3.Components
{
    public class AbstractUdonBehaviour : VRCInteractable
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x7FFE80E2E390
        public void GetProgramVariable(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFE80E32650 | overloaded x2
        public void SetProgramVariable(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void SendCustomEvent(){} // RVA: 0x7FFE80E460A0
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFE80E49570 | overloaded x9
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_DisableInteractive(){} // RVA: 0x7FFE80E2F150
        public void set_DisableInteractive(){} // RVA: 0x7FFE80E466C0
        public void get_DisableEventProcessing(){} // RVA: 0x7FFE80E2F150
        public void set_DisableEventProcessing(){} // RVA: 0x7FFE80E466C0
        public void get_SyncMetadataTable(){} // RVA: 0x7FFE80E2E2E0
        public void InitializeUdonContent(){} // RVA: 0x7FFE80E45FE0
        public void RunProgram(){} // RVA: 0x7FFE80E460A0
        public void RunInputEvent(){}
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFE80E2F150
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFE80E466C0
        public void RequestSerialization(){} // RVA: 0x7FFE80E45FE0
        public void get_InteractionText(){} // RVA: 0x7FFE80E2E2E0
        public void set_InteractionText(){} // RVA: 0x7FFE80E460A0
        public void get_SyncMethod(){} // RVA: 0x7FFE80E2EDB0
        public void set_SyncMethod(){} // RVA: 0x7FFE80E46530
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFE80E32650
        public void GetComponentIndexFixed(){} // RVA: 0x7FFE80E2EDB0
        public void RunEvent(){} // RVA: 0x7FFE810A1420 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x7FFE810A1420 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFE815BA3A0
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.get_enabled(){} // RVA: 0x7FFE81161DE0
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.set_enabled(){} // RVA: 0x7FFE81F63B50
    }

    public class IVRCDestructible
    {
    }

    public class MultipleDisplayUtilities : Object
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x7FFE8A498210
        public void GetMousePositionRelativeToMainDisplayResolution(){} // RVA: 0x7FFE8A498370
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFE87B2FCF0
        public void SetStruct(){} // RVA: 0x7FFE810A1420
        public void SetClass(){} // RVA: 0x7FFE810A1420
    }

    public class VRCAvatarPedestal : VRC_AvatarPedestal
    {
        // ── Methods ──
        public void SwitchAvatar(){} // RVA: 0x7FFE8A4966A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A443D60
    }

    public class VRCCameraDollyAnimation : MonoBehaviour
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFE8A495670
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCCameraDollyPath : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCCameraDollyPathPoint : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4956D0
    }

    public class VRCEnablePersistence : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A495420
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCInputFieldKeyboardOverride : MonoBehaviour
    {
        public 0x6665D804 _overrideBehavior; // 0x20

        // ── Methods ──
        public void get_OverrideBehavior(){} // RVA: 0x7FFE8151D690
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCInteractable : VRC_Interactable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE815BA3A0
    }

    public class VRCMirrorReflection : VRC_MirrorReflection
    {
        // ── Methods ──
        public void UpdateCameraClearing(){} // RVA: 0x7FFE8A497590
        public void .ctor(){} // RVA: 0x7FFE8A497AA0
    }

    public class VRCObjectPool : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x7FFE8A495750
        public void Shuffle(){} // RVA: 0x7FFE8A495D10
        public void TryToSpawn(){} // RVA: 0x7FFE8A495D20
        public void Return(){} // RVA: 0x7FFE8A4960E0
        public void .ctor(){} // RVA: 0x7FFE8A4964F0
    }

    public class VRCObjectSync : VRCNetworkBehaviour
    {
        public bool AllowCollisionOwnershipTransfer; // 0x20
        public bool ForceKinematicOnRemote; // 0x21
        public System.Action`2<VRC.SDK3.Components.VRCObjectSync,bool> _setKinematicHook;

        // ── Methods ──
        public void get_SetKinematicHook(){} // RVA: 0x7FFE8A496810
        public void set_SetKinematicHook(){} // RVA: 0x7FFE8A496870
        public void get_SetGravityHook(){} // RVA: 0x7FFE8A496920
        public void set_SetGravityHook(){} // RVA: 0x7FFE8A496980
        public void get_FlagDiscontinuityHook(){} // RVA: 0x7FFE8A496A40
        public void set_FlagDiscontinuityHook(){} // RVA: 0x7FFE8A496AA0
        public void SetKinematic(){} // RVA: 0x7FFE8A496B60
        public void EditorSetKinematic(){} // RVA: 0x7FFE8A496C20
        public void SetGravity(){} // RVA: 0x7FFE8A496D60
        public void EditorSetGravity(){} // RVA: 0x7FFE8A496E20
        public void FlagDiscontinuity(){} // RVA: 0x7FFE8A496F60
        public void TeleportTo(){} // RVA: 0x7FFE8A497010
        public void Respawn(){} // RVA: 0x7FFE8A497180
        public void NetworkConfigure(){} // RVA: 0x7FFE8A497200
        public void .ctor(){} // RVA: 0x7FFE81155060
        public void .cctor(){} // RVA: 0x7FFE8A4972A0
    }

    public class VRCOpenMenu : Object
    {
        // ── Methods ──
        public void OpenAvatarListing(){} // RVA: 0x7FFE8A498940
    }

    public class VRCPickup : VRC_Pickup
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE8A497580
        public void .ctor(){} // RVA: 0x7FFE8A446010
    }

    public class VRCPlayerObject : VRCNetworkBehaviour
    {
        // ── Methods ──
        public void GetPlayer(){} // RVA: 0x7FFE8A495610
        public void NetworkConfigure(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCPortalMarker : VRC_PortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class VRCSceneDescriptor : VRC_SceneDescriptor
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE8A497B00
        public void .ctor(){} // RVA: 0x7FFE8A497D80
    }

    public class VRCSpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A4427A0
    }

    public class VRCStation : VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A498000
    }

    public class VRCTMPDropdownExtension : Object
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x7FFE8A498860 | overloaded x3
    }

    public class VRCUiShape : VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811AF710
    }

    public class VRCUrlInputField : Selectable
    {
        public System.Action onSelected; // 0x100
        public UnityEngine.TouchScreenKeyboard m_Keyboard; // 0x108
        public char[] kSeparators;
        public bool s_AreDevicesEvaluated; // 0x8
        public bool s_IsQuestDevice; // 0x9
        public bool s_IsPicoDevice; // 0xA
        public UnityEngine.UI.Text m_TextComponent; // 0x110
        public UnityEngine.UI.Graphic m_Placeholder; // 0x118
        public 0x6665D9BC m_ContentType; // 0x120
        public 0x6665DA14 m_InputType; // 0x124
        public char m_AsteriskChar; // 0x128
        public 0x66579C9C m_KeyboardType; // 0x12C
        public 0x6665DAC4 m_LineType; // 0x130
        public bool m_HideMobileInput; // 0x134
        public 0x6665DA6C m_CharacterValidation; // 0x138
        public int m_CharacterLimit; // 0x13C
        public SubmitEvent m_OnEndEdit; // 0x140
        public OnChangeEvent m_OnValueChanged; // 0x148
        public OnValidateInput m_OnValidateInput; // 0x150
        public UnityEngine.Color m_CaretColor; // 0x158
        public bool m_CustomCaretColor; // 0x168
        public UnityEngine.Color m_SelectionColor; // 0x16C
        public string m_Text; // 0x180
        public float m_CaretBlinkRate; // 0x188
        public int m_CaretWidth; // 0x18C
        public bool m_ReadOnly; // 0x190
        public bool m_ShouldActivateOnSelect; // 0x191
        public int m_CaretPosition; // 0x194
        public int m_CaretSelectPosition; // 0x198
        public UnityEngine.RectTransform caretRectTrans; // 0x1A0
        public UnityEngine.UIVertex[] m_CursorVerts; // 0x1A8
        public UnityEngine.TextGenerator m_InputTextCache; // 0x1B0
        public UnityEngine.CanvasRenderer m_CachedInputRenderer; // 0x1B8
        public bool m_PreventFontCallback; // 0x1C0
        public UnityEngine.Mesh m_Mesh; // 0x1C8
        public bool m_AllowInput; // 0x1D0
        public bool m_ShouldActivateNextUpdate; // 0x1D1
        public bool m_UpdateDrag; // 0x1D2
        public bool m_DragPositionOutOfBounds; // 0x1D3
        public float kHScrollSpeed;
        public float kVScrollSpeed;
        public bool m_CaretVisible; // 0x1D4
        public UnityEngine.Coroutine m_BlinkCoroutine; // 0x1D8
        public float m_BlinkStartTime; // 0x1E0

        // ── Methods ──
        public void GetUrl(){} // RVA: 0x7FFE8A4989A0
        public void SetUrl(){} // RVA: 0x7FFE8A498CE0
        public void add_onSelected(){} // RVA: 0x7FFE8A498D10
        public void remove_onSelected(){} // RVA: 0x7FFE8A498E00
        public void Awake(){} // RVA: 0x7FFE8A498EF0
        public void get_input(){} // RVA: 0x7FFE8A499420
        public void get_compositionString(){} // RVA: 0x7FFE8A499610
        public void .ctor(){} // RVA: 0x7FFE8A499760
        public void get_mesh(){} // RVA: 0x7FFE8A499B10
        public void get_cachedInputTextGenerator(){} // RVA: 0x7FFE8A499C80
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFE8A499D40
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFE8A499DE0
        public void set_shouldActivateOnSelect(){} // RVA: 0x7FFE8A499E80
        public void get_shouldActivateOnSelect(){} // RVA: 0x7FFE8A499E90
        public void get_text(){} // RVA: 0x7FFE81B38340
        public void set_text(){} // RVA: 0x7FFE8A499F30
        public void SetText(){} // RVA: 0x7FFE8A499F40
        public void get_isFocused(){} // RVA: 0x7FFE89764140
        public void get_caretBlinkRate(){} // RVA: 0x7FFE8A49A670
        public void set_caretBlinkRate(){} // RVA: 0x7FFE8A49A680
        public void get_caretWidth(){} // RVA: 0x7FFE86DBDB50
        public void set_caretWidth(){} // RVA: 0x7FFE8A49A740
        public void get_textComponent(){} // RVA: 0x7FFE81317980
        public void set_textComponent(){} // RVA: 0x7FFE8A49A7A0
        public void get_placeholder(){} // RVA: 0x7FFE81318010
        public void set_placeholder(){} // RVA: 0x7FFE8A49AB30
        public void get_caretColor(){} // RVA: 0x7FFE8A49AB90
        public void set_caretColor(){} // RVA: 0x7FFE8A49ABF0
        public void get_customCaretColor(){} // RVA: 0x7FFE822E7DC0
        public void set_customCaretColor(){} // RVA: 0x7FFE8A49AC60
        public void get_selectionColor(){} // RVA: 0x7FFE81166730
        public void set_selectionColor(){} // RVA: 0x7FFE8A49AC80
        public void get_onEndEdit(){} // RVA: 0x7FFE811665F0
        public void set_onEndEdit(){} // RVA: 0x7FFE8A49ACF0
        public void get_onValueChange(){} // RVA: 0x7FFE81166660
        public void set_onValueChange(){} // RVA: 0x7FFE8A49AD50
        public void get_onValueChanged(){} // RVA: 0x7FFE81166660
        public void set_onValueChanged(){} // RVA: 0x7FFE8A49AD50
        public void get_onValidateInput(){} // RVA: 0x7FFE81790740
        public void set_onValidateInput(){} // RVA: 0x7FFE8A49ADB0
        public void get_characterLimit(){} // RVA: 0x7FFE86C70920
        public void set_characterLimit(){} // RVA: 0x7FFE8A49AE10
        public void get_contentType(){} // RVA: 0x7FFE86DBACC0
        public void set_contentType(){} // RVA: 0x7FFE8A49AEC0
        public void get_lineType(){} // RVA: 0x7FFE8162C320
        public void set_lineType(){} // RVA: 0x7FFE8A49B070
        public void get_inputType(){} // RVA: 0x7FFE86C7E580
        public void set_inputType(){} // RVA: 0x7FFE8A49B160
        public void get_touchScreenKeyboard(){} // RVA: 0x7FFE8181E3D0
        public void get_keyboardType(){} // RVA: 0x7FFE8A3269D0
        public void set_keyboardType(){} // RVA: 0x7FFE8A49B1D0
        public void get_characterValidation(){} // RVA: 0x7FFE81F60BB0
        public void set_characterValidation(){} // RVA: 0x7FFE8A49B240
        public void get_readOnly(){} // RVA: 0x7FFE86FE96E0
        public void set_readOnly(){} // RVA: 0x7FFE86FE96F0
        public void get_multiLine(){} // RVA: 0x7FFE8A49B2B0
        public void get_asteriskChar(){} // RVA: 0x7FFE8A49B2D0
        public void set_asteriskChar(){} // RVA: 0x7FFE8A49B2E0
        public void get_wasCanceled(){} // RVA: 0x7FFE8A49B390
        public void ClampPos(){} // RVA: 0x7FFE8A49B3A0
        public void get_caretPositionInternal(){} // RVA: 0x7FFE8A49B3E0
        public void set_caretPositionInternal(){} // RVA: 0x7FFE8A49B410
        public void get_caretSelectPositionInternal(){} // RVA: 0x7FFE8A49B460
        public void set_caretSelectPositionInternal(){} // RVA: 0x7FFE8A49B490
        public void get_hasSelection(){} // RVA: 0x7FFE8A49B4E0
        public void get_caretPosition(){} // RVA: 0x7FFE8A49B460
        public void set_caretPosition(){} // RVA: 0x7FFE8A49B540
        public void get_selectionAnchorPosition(){} // RVA: 0x7FFE8A49B3E0
        public void set_selectionAnchorPosition(){} // RVA: 0x7FFE8A49B600
        public void get_selectionFocusPosition(){} // RVA: 0x7FFE8A49B460
        public void set_selectionFocusPosition(){} // RVA: 0x7FFE8A49B670
        public void OnEnable(){} // RVA: 0x7FFE8A49B6E0
        public void OnDisable(){} // RVA: 0x7FFE8A49BAD0
        public void CaretBlink(){} // RVA: 0x7FFE8A49BF70
        public void SetCaretVisible(){} // RVA: 0x7FFE8A49C010
        public void SetCaretActive(){} // RVA: 0x7FFE8A49C090
        public void UpdateCaretMaterial(){} // RVA: 0x7FFE8A49C180
        public void OnFocus(){} // RVA: 0x7FFE8A49C3B0
        public void SelectAll(){} // RVA: 0x7FFE8A49C3C0
        public void MoveTextEnd(){} // RVA: 0x7FFE8A49C450
        public void MoveTextStart(){} // RVA: 0x7FFE8A49C570
        public void get_clipboard(){} // RVA: 0x7FFE8A49C660
        public void set_clipboard(){} // RVA: 0x7FFE8A49C6E0
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x7FFE8A49C770
        public void InPlaceEditing(){} // RVA: 0x7FFE8A49C890
        public void InPlaceEditingChanged(){} // RVA: 0x7FFE8A49C930
        public void UpdateCaretFromKeyboard(){} // RVA: 0x7FFE8A49C9E0
        public void LateUpdate(){} // RVA: 0x7FFE8A49CB90
        public void ScreenToLocal(){} // RVA: 0x7FFE8A49D460
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x7FFE8A49DC30
        public void GetCharacterIndexFromPosition(){} // RVA: 0x7FFE8A49DF30
        public void MayDrag(){} // RVA: 0x7FFE8A49E240
        public void OnBeginDrag(){} // RVA: 0x7FFE8A49E3A0
        public void OnDrag(){} // RVA: 0x7FFE8A49E3D0
        public void MouseDragOutsideRect(){} // RVA: 0x7FFE8A49E700
        public void OnEndDrag(){} // RVA: 0x7FFE8A49E800
        public void OnPointerDown(){} // RVA: 0x7FFE8A49E830
        public void KeyPressed(){} // RVA: 0x7FFE8A49EB10
        public void IsValidChar(){} // RVA: 0x7FFE8A49F2F0
        public void ProcessEvent(){} // RVA: 0x7FFE8A49F350
        public void OnUpdateSelected(){} // RVA: 0x7FFE8A49F360
        public void GetSelectedString(){} // RVA: 0x7FFE8A49F570
        public void FindtNextWordBegin(){} // RVA: 0x7FFE8A49F670
        public void MoveRight(){} // RVA: 0x7FFE8A49F780
        public void FindtPrevWordBegin(){} // RVA: 0x7FFE8A49FA20
        public void MoveLeft(){} // RVA: 0x7FFE8A49FB20
        public void DetermineCharacterLine(){} // RVA: 0x7FFE8A49FDB0
        public void LineUpCharacterPosition(){} // RVA: 0x7FFE8A49FF50
        public void LineDownCharacterPosition(){} // RVA: 0x7FFE8A4A01F0
        public void MoveDown(){} // RVA: 0x7FFE8A4A0520 | overloaded x2
        public void MoveUp(){} // RVA: 0x7FFE8A4A0750 | overloaded x2
        public void Delete(){} // RVA: 0x7FFE8A4A0930
        public void ForwardSpace(){} // RVA: 0x7FFE8A4A0BF0
        public void Backspace(){} // RVA: 0x7FFE8A4A0D40
        public void Insert(){} // RVA: 0x7FFE8A4A0EC0
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7FFE8A4A10F0
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7FFE8A4A1140
        public void SendOnValueChanged(){} // RVA: 0x7FFE8A4A1160
        public void SendOnSubmit(){} // RVA: 0x7FFE8A4A1220
        public void Append(){} // RVA: 0x7FFE8A4A13C0 | overloaded x2
        public void UpdateLabel(){} // RVA: 0x7FFE8A4A1560
        public void IsSelectionVisible(){} // RVA: 0x7FFE8A4A1CE0
        public void GetLineStartPosition(){} // RVA: 0x7FFE8A4A1DB0
        public void GetLineEndPosition(){} // RVA: 0x7FFE8A4A1EE0
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x7FFE8A4A2060
        public void ForceLabelUpdate(){} // RVA: 0x7FFE8A4A2A80
        public void MarkGeometryAsDirty(){} // RVA: 0x7FFE8A4A2A90
        public void Rebuild(){} // RVA: 0x7FFE8A4A2B30
        public void LayoutComplete(){} // RVA: 0x7FFE810FB310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE810FB310
        public void UpdateGeometry(){} // RVA: 0x7FFE8A4A2B40
        public void AssignPositioningIfNeeded(){} // RVA: 0x7FFE8A4A3120
        public void OnFillVBO(){} // RVA: 0x7FFE8A4A3C10
        public void GenerateCaret(){} // RVA: 0x7FFE8A4A3E20
        public void CreateCursorVerts(){} // RVA: 0x7FFE8A4A4BF0
        public void GenerateHighlight(){} // RVA: 0x7FFE8A4A4E00
        public void Validate(){} // RVA: 0x7FFE8A4A56A0
        public void ActivateInputField(){} // RVA: 0x7FFE8A4A5D10
        public void ActivateInputFieldInternal(){} // RVA: 0x7FFE8A4A5F60
        public void OnSelect(){} // RVA: 0x7FFE8A4A6790
        public void OnPointerClick(){} // RVA: 0x7FFE8A4A6840
        public void DeactivateInputField(){} // RVA: 0x7FFE8A4A6870
        public void OnDeselect(){} // RVA: 0x7FFE8A4A6C20
        public void OnSubmit(){} // RVA: 0x7FFE8A4A6C50
        public void EnforceContentType(){} // RVA: 0x7FFE8A4A6CA0
        public void EnforceTextHOverflow(){} // RVA: 0x7FFE8A4A6E10
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7FFE8A4A6F70
        public void SetToCustom(){} // RVA: 0x7FFE8A4A6FE0
        public void DoStateTransition(){} // RVA: 0x7FFE8A4A7000
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE810FB310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE810FB310
        public void get_minWidth(){} // RVA: 0x7FFE8186F320
        public void get_preferredWidth(){} // RVA: 0x7FFE8A4A7030
        public void get_flexibleWidth(){} // RVA: 0x7FFE878F7A90
        public void get_minHeight(){} // RVA: 0x7FFE8186F320
        public void get_preferredHeight(){} // RVA: 0x7FFE8A4A7290
        public void get_flexibleHeight(){} // RVA: 0x7FFE878F7A90
        public void get_layoutPriority(){} // RVA: 0x7FFE811EDAF0
        public void .cctor(){} // RVA: 0x7FFE8A4A7530
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFE816315C0
    }

    public class VRCVisualDamage : VRC_VisualDamage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A442410
    }

}