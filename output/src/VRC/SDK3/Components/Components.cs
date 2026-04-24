// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components
// Classes: 22
// Methods: 276

namespace VRC.SDK3.Components
{
    public class AbstractUdonBehaviour : VRCInteractable
    {
        public object DisableInteractive;
        public object DisableEventProcessing;
        public object SyncMetadataTable;
        public object IsNetworkingSupported;
        public object InteractionText;
        public object SyncMethod;

        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x7FFD4E078F40
        public void GetProgramVariable(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFD4E07D200 | overloaded x2
        public void SetProgramVariable(){} // RVA: 0x7FFD4E099B30 | overloaded x2
        public void SendCustomEvent(){} // RVA: 0x7FFD4E090A40
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFD4E093F00 | overloaded x9
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_DisableInteractive(){} // RVA: 0x7FFD4E079D00
        public void set_DisableInteractive(){} // RVA: 0x7FFD4E091060
        public void get_DisableEventProcessing(){} // RVA: 0x7FFD4E079D00
        public void set_DisableEventProcessing(){} // RVA: 0x7FFD4E091060
        public void get_SyncMetadataTable(){} // RVA: 0x7FFD4E078E90
        public void InitializeUdonContent(){} // RVA: 0x7FFD4E090980
        public void RunProgram(){} // RVA: 0x7FFD4E090A40
        public void RunInputEvent(){}
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFD4E079D00
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFD4E091060
        public void RequestSerialization(){} // RVA: 0x7FFD4E090980
        public void get_InteractionText(){} // RVA: 0x7FFD4E078E90
        public void set_InteractionText(){} // RVA: 0x7FFD4E090A40
        public void get_SyncMethod(){} // RVA: 0x7FFD4E079960
        public void set_SyncMethod(){} // RVA: 0x7FFD4E090ED0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFD4E07D200
        public void GetComponentIndexFixed(){} // RVA: 0x7FFD4E079960
        public void RunEvent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFD4E788510
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.get_enabled(){} // RVA: 0x7FFD4E3A7DE0
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.set_enabled(){} // RVA: 0x7FFD4F117970
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFD54BA7770
        public void SetStruct(){} // RVA: 0x7FFD4E2ADC40
        public void SetClass(){} // RVA: 0x7FFD4E2ADC40
    }

    public class VRCAvatarPedestal : VRC_AvatarPedestal
    {
        // ── Methods ──
        public void SwitchAvatar(){} // RVA: 0x7FFD57450BC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD574031F0
    }

    public class VRCCameraDollyAnimation : MonoBehaviour
    {
        public int RESOLUTION;
        public System.Action`1<VRC.SDK3.Components.VRCCameraDollyAnimation> ImportCameraDollyAnimation;
        public bool IsRelativeToPlayer; // 0x20
        public bool IsSpeedBased; // 0x21
        public bool IsUsingLookAtMe; // 0x22
        public bool IsUsingGreenscreen; // 0x23
        public bool IsUsingMultiStream; // 0x24
        public 0x665C33E8 PathType; // 0x28
        public 0x665C3440 LoopType; // 0x2C
        public 0x665C3498 CaptureType; // 0x30
        public 0x665C34F0 FocusMode; // 0x34
        public 0x665C3548 AnchorMode; // 0x38
        public VRC.SDK3.Components.VRCCameraDollyPath[] Paths; // 0x40

        // ── Methods ──
        public void Import(){} // RVA: 0x7FFD5744FB90
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCCameraDollyPath : MonoBehaviour
    {
        public VRC.SDK3.Components.VRCCameraDollyPathPoint[] Points; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCCameraDollyPathPoint : MonoBehaviour
    {
        public float Zoom; // 0x20
        public float Exposure; // 0x24
        public float Duration; // 0x28
        public float Speed; // 0x2C
        public float FocalDistance; // 0x30
        public float Aperture; // 0x34
        public float Hue; // 0x38
        public float Saturation; // 0x3C
        public float Lightness; // 0x40
        public float LookAtMeXOffset; // 0x44
        public float LookAtMeYOffset; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5744FBF0
    }

    public class VRCEnablePersistence : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD5744F940
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCInputFieldKeyboardOverride : MonoBehaviour
    {
        public 0x665C3C28 OverrideBehavior; // 0x20

        // ── Methods ──
        public void get_OverrideBehavior(){} // RVA: 0x7FFD4E4FBBE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCInteractable : VRC_Interactable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E788510
    }

    public class VRCMirrorReflection : VRC_MirrorReflection
    {
        public 0x665C3A18 cameraClearFlags; // 0xC0
        public UnityEngine.Material customSkybox; // 0xC8
        public UnityEngine.Color customClearColor; // 0xD0

        // ── Methods ──
        public void UpdateCameraClearing(){} // RVA: 0x7FFD57451AB0
        public void .ctor(){} // RVA: 0x7FFD57451FC0
    }

    public class VRCObjectPool : VRCNetworkBehaviour
    {
        public UnityEngine.GameObject[] Pool; // 0x20
        public System.Action`1<VRC.SDK3.Components.VRCObjectPool> OnInit;
        public System.Action`2<VRC.SDK3.Components.VRCObjectPool,int> OnSpawn; // 0x8
        public System.Action`2<VRC.SDK3.Components.VRCObjectPool,int> OnReturn; // 0x10
        public System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,int> _indices; // 0x28
        public int _lastSpawnIndex; // 0x30
        public int[] _spawnOrder; // 0x38
        public bool didInit; // 0x40
        public UnityEngine.Vector3[] StartPositions; // 0x48
        public UnityEngine.Quaternion[] StartRotations; // 0x50

        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x7FFD5744FC70
        public void Shuffle(){} // RVA: 0x7FFD57450230
        public void TryToSpawn(){} // RVA: 0x7FFD57450240
        public void Return(){} // RVA: 0x7FFD57450600
        public void .ctor(){} // RVA: 0x7FFD57450A10
    }

    public class VRCObjectSync : VRCNetworkBehaviour
    {
        public bool SetKinematicHook; // 0x20
        public bool SetGravityHook; // 0x21
        public System.Action`2<VRC.SDK3.Components.VRCObjectSync,bool> FlagDiscontinuityHook;
        public System.Action`2<VRC.SDK3.Components.VRCObjectSync,bool> <SetGravityHook>k__BackingField; // 0x8
        public System.Action`1<VRC.SDK3.Components.VRCObjectSync> <FlagDiscontinuityHook>k__BackingField; // 0x10
        public System.Action`3<VRC.SDK3.Components.VRCObjectSync,UnityEngine.Vector3,UnityEngine.Quaternion> TeleportHandler; // 0x18
        public System.Action`1<VRC.SDK3.Components.VRCObjectSync> RespawnHandler; // 0x20
        public AwakeDelegate OnAwake; // 0x28
        public bool didInit; // 0x22

        // ── Methods ──
        public void get_SetKinematicHook(){} // RVA: 0x7FFD57450D30
        public void set_SetKinematicHook(){} // RVA: 0x7FFD57450D90
        public void get_SetGravityHook(){} // RVA: 0x7FFD57450E40
        public void set_SetGravityHook(){} // RVA: 0x7FFD57450EA0
        public void get_FlagDiscontinuityHook(){} // RVA: 0x7FFD57450F60
        public void set_FlagDiscontinuityHook(){} // RVA: 0x7FFD57450FC0
        public void SetKinematic(){} // RVA: 0x7FFD57451080
        public void EditorSetKinematic(){} // RVA: 0x7FFD57451140
        public void SetGravity(){} // RVA: 0x7FFD57451280
        public void EditorSetGravity(){} // RVA: 0x7FFD57451340
        public void FlagDiscontinuity(){} // RVA: 0x7FFD57451480
        public void TeleportTo(){} // RVA: 0x7FFD57451530
        public void Respawn(){} // RVA: 0x7FFD574516A0
        public void NetworkConfigure(){} // RVA: 0x7FFD57451720
        public void .ctor(){} // RVA: 0x7FFD4E39B060
        public void .cctor(){} // RVA: 0x7FFD574517C0
    }

    public class VRCOpenMenu : Object
    {
        public System.Action`1<string> _OpenAvatarListingDelegate;

        // ── Methods ──
        public void OpenAvatarListing(){} // RVA: 0x7FFD57452E60
    }

    public class VRCPickup : VRC_Pickup
    {
        public 0x665C38B8 version; // 0xA8

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD57451AA0
        public void .ctor(){} // RVA: 0x7FFD574054A0
    }

    public class VRCPlayerObject : VRCNetworkBehaviour
    {
        public System.Func`2<VRC.SDK3.Components.VRCPlayerObject,VRC.SDKBase.VRCPlayerApi> _GetPlayer;

        // ── Methods ──
        public void GetPlayer(){} // RVA: 0x7FFD5744FB30
        public void NetworkConfigure(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCPortalMarker : VRC_PortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class VRCSceneDescriptor : VRC_SceneDescriptor
    {
        public VRC.SDK3.Components.VRCPlayerObject[] PlayerPersistence; // 0x218
        public float[] NavigationAreas; // 0x220

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD57452020
        public void .ctor(){} // RVA: 0x7FFD574522A0
    }

    public class VRCSpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57401C30
    }

    public class VRCStation : VRCStation
    {
        public string OnRemotePlayerEnterStation; // 0x50
        public string OnLocalPlayerEnterStation; // 0x58
        public string OnRemotePlayerExitStation; // 0x60
        public string OnLocalPlayerExitStation; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57452520
    }

    public class VRCUiShape : VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3F5710
    }

    public class VRCUrlInputField : Selectable
    {
        public System.Action input; // 0x100
        public 0x664E03D8 compositionString; // 0x108
        public char[] mesh;
        public bool cachedInputTextGenerator; // 0x8
        public bool shouldHideMobileInput; // 0x9
        public bool shouldActivateOnSelect; // 0xA
        public UnityEngine.UI.Text text; // 0x110
        public UnityEngine.UI.Graphic isFocused; // 0x118
        public 0x665C3DE0 caretBlinkRate; // 0x120
        public 0x665C3E38 caretWidth; // 0x124
        public char textComponent; // 0x128
        public 0x664E0430 placeholder; // 0x12C
        public 0x665C3EE8 caretColor; // 0x130
        public bool customCaretColor; // 0x134
        public 0x665C3E90 selectionColor; // 0x138
        public int onEndEdit; // 0x13C
        public 0x665C3F98 onValueChange; // 0x140
        public 0x665C3FF0 onValueChanged; // 0x148
        public 0x665C3F40 onValidateInput; // 0x150
        public UnityEngine.Color characterLimit; // 0x158
        public bool contentType; // 0x168
        public UnityEngine.Color lineType; // 0x16C
        public string inputType; // 0x180
        public float touchScreenKeyboard; // 0x188
        public int keyboardType; // 0x18C
        public bool characterValidation; // 0x190
        public bool readOnly; // 0x191
        public int multiLine; // 0x194
        public int asteriskChar; // 0x198
        public UnityEngine.RectTransform wasCanceled; // 0x1A0
        public UnityEngine.UIVertex[] caretPositionInternal; // 0x1A8
        public UnityEngine.TextGenerator caretSelectPositionInternal; // 0x1B0
        public UnityEngine.CanvasRenderer hasSelection; // 0x1B8
        public bool caretPosition; // 0x1C0
        public UnityEngine.Mesh selectionAnchorPosition; // 0x1C8
        public bool selectionFocusPosition; // 0x1D0
        public bool clipboard; // 0x1D1
        public bool minWidth; // 0x1D2
        public bool preferredWidth; // 0x1D3
        public float flexibleWidth;
        public float minHeight;
        public bool preferredHeight; // 0x1D4
        public UnityEngine.Coroutine flexibleHeight; // 0x1D8
        public float layoutPriority; // 0x1E0
        public int m_DrawStart; // 0x1E4
        public int m_DrawEnd; // 0x1E8
        public UnityEngine.Coroutine m_DragCoroutine; // 0x1F0
        public string m_OriginalText; // 0x1F8
        public bool m_WasCanceled; // 0x200
        public bool m_HasDoneFocusTransition; // 0x201
        public 0x664DFC48 m_WaitForSecondsRealtime; // 0x208
        public bool m_TouchKeyboardAllowsInPlaceEditing; // 0x210
        public string kEmailSpecialCharacters;
        public string kOculusQuestDeviceModel;
        public string kPicoDeviceModel;
        public bool AllowSendingOnEndEdit; // 0x211
        public UnityEngine.Event m_ProcessingEvent; // 0x218
        public int k_MaxTextLength;

        // ── Methods ──
        public void GetUrl(){} // RVA: 0x7FFD57452EC0
        public void SetUrl(){} // RVA: 0x7FFD57453200
        public void add_onSelected(){} // RVA: 0x7FFD57453230
        public void remove_onSelected(){} // RVA: 0x7FFD57453320
        public void Awake(){} // RVA: 0x7FFD57453410
        public void get_input(){} // RVA: 0x7FFD57453940
        public void get_compositionString(){} // RVA: 0x7FFD57453B30
        public void .ctor(){} // RVA: 0x7FFD57453C80
        public void get_mesh(){} // RVA: 0x7FFD57454030
        public void get_cachedInputTextGenerator(){} // RVA: 0x7FFD574541A0
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFD57454260
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFD57454300
        public void set_shouldActivateOnSelect(){} // RVA: 0x7FFD574543A0
        public void get_shouldActivateOnSelect(){} // RVA: 0x7FFD574543B0
        public void get_text(){} // RVA: 0x7FFD4E96B1B0
        public void set_text(){} // RVA: 0x7FFD57454450
        public void SetText(){} // RVA: 0x7FFD57454460
        public void get_isFocused(){} // RVA: 0x7FFD567C45C0
        public void get_caretBlinkRate(){} // RVA: 0x7FFD57454B90
        public void set_caretBlinkRate(){} // RVA: 0x7FFD57454BA0
        public void get_caretWidth(){} // RVA: 0x7FFD53E344D0
        public void set_caretWidth(){} // RVA: 0x7FFD57454C60
        public void get_textComponent(){} // RVA: 0x7FFD4E96B170
        public void set_textComponent(){} // RVA: 0x7FFD57454CC0
        public void get_placeholder(){} // RVA: 0x7FFD4E7DC6D0
        public void set_placeholder(){} // RVA: 0x7FFD57455050
        public void get_caretColor(){} // RVA: 0x7FFD574550B0
        public void set_caretColor(){} // RVA: 0x7FFD57455110
        public void get_customCaretColor(){} // RVA: 0x7FFD4F42F720
        public void set_customCaretColor(){} // RVA: 0x7FFD57455180
        public void get_selectionColor(){} // RVA: 0x7FFD4E3AC730
        public void set_selectionColor(){} // RVA: 0x7FFD574551A0
        public void get_onEndEdit(){} // RVA: 0x7FFD4E3AC5F0
        public void set_onEndEdit(){} // RVA: 0x7FFD57455210
        public void get_onValueChange(){} // RVA: 0x7FFD4E3AC660
        public void set_onValueChange(){} // RVA: 0x7FFD57455270
        public void get_onValueChanged(){} // RVA: 0x7FFD4E3AC660
        public void set_onValueChanged(){} // RVA: 0x7FFD57455270
        public void get_onValidateInput(){} // RVA: 0x7FFD4E96DFA0
        public void set_onValidateInput(){} // RVA: 0x7FFD574552D0
        public void get_characterLimit(){} // RVA: 0x7FFD53CE7230
        public void set_characterLimit(){} // RVA: 0x7FFD57455330
        public void get_contentType(){} // RVA: 0x7FFD53E31640
        public void set_contentType(){} // RVA: 0x7FFD574553E0
        public void get_lineType(){} // RVA: 0x7FFD4E7DC1B0
        public void set_lineType(){} // RVA: 0x7FFD57455590
        public void get_inputType(){} // RVA: 0x7FFD53CF4E90
        public void set_inputType(){} // RVA: 0x7FFD57455680
        public void get_touchScreenKeyboard(){} // RVA: 0x7FFD4EAF1F40
        public void get_keyboardType(){} // RVA: 0x7FFD572E7A50
        public void set_keyboardType(){} // RVA: 0x7FFD574556F0
        public void get_characterValidation(){} // RVA: 0x7FFD4F0AEC30
        public void set_characterValidation(){} // RVA: 0x7FFD57455760
        public void get_readOnly(){} // RVA: 0x7FFD540611C0
        public void set_readOnly(){} // RVA: 0x7FFD540611D0
        public void get_multiLine(){} // RVA: 0x7FFD574557D0
        public void get_asteriskChar(){} // RVA: 0x7FFD574557F0
        public void set_asteriskChar(){} // RVA: 0x7FFD57455800
        public void get_wasCanceled(){} // RVA: 0x7FFD574558B0
        public void ClampPos(){} // RVA: 0x7FFD574558C0
        public void get_caretPositionInternal(){} // RVA: 0x7FFD57455900
        public void set_caretPositionInternal(){} // RVA: 0x7FFD57455930
        public void get_caretSelectPositionInternal(){} // RVA: 0x7FFD57455980
        public void set_caretSelectPositionInternal(){} // RVA: 0x7FFD574559B0
        public void get_hasSelection(){} // RVA: 0x7FFD57455A00
        public void get_caretPosition(){} // RVA: 0x7FFD57455980
        public void set_caretPosition(){} // RVA: 0x7FFD57455A60
        public void get_selectionAnchorPosition(){} // RVA: 0x7FFD57455900
        public void set_selectionAnchorPosition(){} // RVA: 0x7FFD57455B20
        public void get_selectionFocusPosition(){} // RVA: 0x7FFD57455980
        public void set_selectionFocusPosition(){} // RVA: 0x7FFD57455B90
        public void OnEnable(){} // RVA: 0x7FFD57455C00
        public void OnDisable(){} // RVA: 0x7FFD57455FF0
        public void CaretBlink(){} // RVA: 0x7FFD57456490
        public void SetCaretVisible(){} // RVA: 0x7FFD57456530
        public void SetCaretActive(){} // RVA: 0x7FFD574565B0
        public void UpdateCaretMaterial(){} // RVA: 0x7FFD574566A0
        public void OnFocus(){} // RVA: 0x7FFD574568D0
        public void SelectAll(){} // RVA: 0x7FFD574568E0
        public void MoveTextEnd(){} // RVA: 0x7FFD57456970
        public void MoveTextStart(){} // RVA: 0x7FFD57456A90
        public void get_clipboard(){} // RVA: 0x7FFD57456B80
        public void set_clipboard(){} // RVA: 0x7FFD57456C00
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x7FFD57456C90
        public void InPlaceEditing(){} // RVA: 0x7FFD57456DB0
        public void InPlaceEditingChanged(){} // RVA: 0x7FFD57456E50
        public void UpdateCaretFromKeyboard(){} // RVA: 0x7FFD57456F00
        public void LateUpdate(){} // RVA: 0x7FFD574570B0
        public void ScreenToLocal(){} // RVA: 0x7FFD57457980
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x7FFD57458150
        public void GetCharacterIndexFromPosition(){} // RVA: 0x7FFD57458450
        public void MayDrag(){} // RVA: 0x7FFD57458760
        public void OnBeginDrag(){} // RVA: 0x7FFD574588C0
        public void OnDrag(){} // RVA: 0x7FFD574588F0
        public void MouseDragOutsideRect(){} // RVA: 0x7FFD57458C20
        public void OnEndDrag(){} // RVA: 0x7FFD57458D20
        public void OnPointerDown(){} // RVA: 0x7FFD57458D50
        public void KeyPressed(){} // RVA: 0x7FFD57459030
        public void IsValidChar(){} // RVA: 0x7FFD57459810
        public void ProcessEvent(){} // RVA: 0x7FFD57459870
        public void OnUpdateSelected(){} // RVA: 0x7FFD57459880
        public void GetSelectedString(){} // RVA: 0x7FFD57459A90
        public void FindtNextWordBegin(){} // RVA: 0x7FFD57459B90
        public void MoveRight(){} // RVA: 0x7FFD57459CA0
        public void FindtPrevWordBegin(){} // RVA: 0x7FFD57459F40
        public void MoveLeft(){} // RVA: 0x7FFD5745A040
        public void DetermineCharacterLine(){} // RVA: 0x7FFD5745A2D0
        public void LineUpCharacterPosition(){} // RVA: 0x7FFD5745A470
        public void LineDownCharacterPosition(){} // RVA: 0x7FFD5745A710
        public void MoveDown(){} // RVA: 0x7FFD5745AA40 | overloaded x2
        public void MoveUp(){} // RVA: 0x7FFD5745AC70 | overloaded x2
        public void Delete(){} // RVA: 0x7FFD5745AE50
        public void ForwardSpace(){} // RVA: 0x7FFD5745B110
        public void Backspace(){} // RVA: 0x7FFD5745B260
        public void Insert(){} // RVA: 0x7FFD5745B3E0
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7FFD5745B610
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7FFD5745B660
        public void SendOnValueChanged(){} // RVA: 0x7FFD5745B680
        public void SendOnSubmit(){} // RVA: 0x7FFD5745B740
        public void Append(){} // RVA: 0x7FFD5745B8E0 | overloaded x2
        public void UpdateLabel(){} // RVA: 0x7FFD5745BA80
        public void IsSelectionVisible(){} // RVA: 0x7FFD5745C200
        public void GetLineStartPosition(){} // RVA: 0x7FFD5745C2D0
        public void GetLineEndPosition(){} // RVA: 0x7FFD5745C400
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x7FFD5745C580
        public void ForceLabelUpdate(){} // RVA: 0x7FFD5745CFA0
        public void MarkGeometryAsDirty(){} // RVA: 0x7FFD5745CFB0
        public void Rebuild(){} // RVA: 0x7FFD5745D050
        public void LayoutComplete(){} // RVA: 0x7FFD4E341310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFD4E341310
        public void UpdateGeometry(){} // RVA: 0x7FFD5745D060
        public void AssignPositioningIfNeeded(){} // RVA: 0x7FFD5745D640
        public void OnFillVBO(){} // RVA: 0x7FFD5745E130
        public void GenerateCaret(){} // RVA: 0x7FFD5745E340
        public void CreateCursorVerts(){} // RVA: 0x7FFD5745F110
        public void GenerateHighlight(){} // RVA: 0x7FFD5745F320
        public void Validate(){} // RVA: 0x7FFD5745FBC0
        public void ActivateInputField(){} // RVA: 0x7FFD57460230
        public void ActivateInputFieldInternal(){} // RVA: 0x7FFD57460480
        public void OnSelect(){} // RVA: 0x7FFD57460CB0
        public void OnPointerClick(){} // RVA: 0x7FFD57460D60
        public void DeactivateInputField(){} // RVA: 0x7FFD57460D90
        public void OnDeselect(){} // RVA: 0x7FFD57461140
        public void OnSubmit(){} // RVA: 0x7FFD57461170
        public void EnforceContentType(){} // RVA: 0x7FFD574611C0
        public void EnforceTextHOverflow(){} // RVA: 0x7FFD57461330
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7FFD57461490
        public void SetToCustom(){} // RVA: 0x7FFD57461500
        public void DoStateTransition(){} // RVA: 0x7FFD57461520
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFD4E341310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFD4E341310
        public void get_minWidth(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredWidth(){} // RVA: 0x7FFD57461550
        public void get_flexibleWidth(){} // RVA: 0x7FFD5496F350
        public void get_minHeight(){} // RVA: 0x7FFD4EB632E0
        public void get_preferredHeight(){} // RVA: 0x7FFD574617B0
        public void get_flexibleHeight(){} // RVA: 0x7FFD5496F350
        public void get_layoutPriority(){} // RVA: 0x7FFD4E433AF0
        public void .cctor(){} // RVA: 0x7FFD57461A50
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFD4E7DCDF0
    }

    public class VRCVisualDamage : VRC_VisualDamage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574018A0
    }

}