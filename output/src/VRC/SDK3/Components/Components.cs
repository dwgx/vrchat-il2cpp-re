// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components
// Classes: 30
// Methods: 448

namespace VRC.SDK3.Components
{
    public class AbstractUdonBehaviour
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0xCE10
        public void GetProgramVariable(){} // RVA: 0xCE10 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x11120 | overloaded x2
        public void SetProgramVariable(){} // RVA: 0x2DC60 | overloaded x2
        public void SendCustomEvent(){} // RVA: 0x24B10
        public void SendCustomNetworkEvent(){} // RVA: 0x27F90 | overloaded x9
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_DisableInteractive(){} // RVA: 0xDBE0
        public void set_DisableInteractive(){} // RVA: 0x25130
        public void get_DisableEventProcessing(){} // RVA: 0xDBE0
        public void set_DisableEventProcessing(){} // RVA: 0x25130
        public void get_SyncMetadataTable(){} // RVA: 0xCD60
        public void InitializeUdonContent(){} // RVA: 0x24A50
        public void RunProgram(){} // RVA: 0x24B10
        public void RunInputEvent(){}
        public void get_IsNetworkingSupported(){} // RVA: 0xDBE0
        public void set_IsNetworkingSupported(){} // RVA: 0x25130
        public void RequestSerialization(){} // RVA: 0x24A50
        public void get_InteractionText(){} // RVA: 0xCD60
        public void set_InteractionText(){} // RVA: 0x24B10
        public void get_SyncMethod(){} // RVA: 0xD840
        public void set_SyncMethod(){} // RVA: 0x24FA0
        public void GetNetworkCallingMetadata(){} // RVA: 0xCE10 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x11120
        public void GetComponentIndexFixed(){} // RVA: 0xD840
        public void RunEvent(){} // RVA: 0x283FA0 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x283FA0 | overloaded x10
        public void .ctor(){} // RVA: 0x82DF40
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.get_enabled(){} // RVA: 0x343DE0
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.set_enabled(){} // RVA: 0x11D95B0
    }

    public class IVRCDestructible
    {
    }

    public class MultipleDisplayUtilities
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x9A3CAB0
        public void GetMousePositionRelativeToMainDisplayResolution(){} // RVA: 0x9A3CC10
    }

    public class SetPropertyUtility
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x6FEEE20
        public void SetStruct(){} // RVA: 0x283FA0
        public void SetClass(){} // RVA: 0x283FA0
    }

    public class VRCAvatarPedestal
    {
        // ── Methods ──
        public void SwitchAvatar(){} // RVA: 0x9A3AE20 | overloaded x2
        public void .ctor(){} // RVA: 0x99E8330
    }

    public class VRCCameraDollyAnimation
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x9A39DF0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCCameraDollyPath
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCCameraDollyPathPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A39E50
    }

    public class VRCEnablePersistence
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A39BA0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCInputFieldKeyboardOverride
    {
        public 0x6597E6D8 StartResolveURLCoroutine; // 0x20

        // ── Methods ──
        public void get_OverrideBehavior(){} // RVA: 0x760030
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCInteractable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x82DF40
    }

    public class VRCMirrorReflection
    {
        // ── Methods ──
        public void UpdateCameraClearing(){} // RVA: 0x9A3BE30
        public void .ctor(){} // RVA: 0x9A3C340
    }

    public class VRCObjectPool
    {
        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x9A39ED0
        public void Shuffle(){} // RVA: 0x9A3A490
        public void TryToSpawn(){} // RVA: 0x9A3A4A0
        public void Return(){} // RVA: 0x9A3A860
        public void .ctor(){} // RVA: 0x9A3AC70
    }

    public class VRCObjectSync
    {
        public bool AllowCollisionOwnershipTransfer; // 0x20
        public bool ForceKinematicOnRemote; // 0x21
        public System.Action`2<VRC.SDK3.Components.VRCObjectSync,bool> <SetKinematicHook>k__BackingField;

        // ── Methods ──
        public void get_SetKinematicHook(){} // RVA: 0x9A3AF90
        public void set_SetKinematicHook(){} // RVA: 0x9A3AFF0
        public void get_SetGravityHook(){} // RVA: 0x9A3B0A0
        public void set_SetGravityHook(){} // RVA: 0x9A3B100
        public void get_FlagDiscontinuityHook(){} // RVA: 0x9A3B1C0
        public void set_FlagDiscontinuityHook(){} // RVA: 0x9A3B220
        public void SetKinematic(){} // RVA: 0x9A3B2E0
        public void EditorSetKinematic(){} // RVA: 0x9A3B3A0
        public void SetGravity(){} // RVA: 0x9A3B4E0
        public void EditorSetGravity(){} // RVA: 0x9A3B5A0
        public void FlagDiscontinuity(){} // RVA: 0x9A3B6E0
        public void TeleportTo(){} // RVA: 0x9A3B790
        public void Respawn(){} // RVA: 0x9A3B900
        public void NetworkConfigure(){} // RVA: 0x9A3B980
        public void .ctor(){} // RVA: 0x337060
        public void .cctor(){} // RVA: 0x9A3BA20
    }

    public class VRCOpenMenu
    {
        // ── Methods ──
        public void OpenAvatarListing(){} // RVA: 0x9A3D1E0
    }

    public class VRCPickup
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x9A3BD00
        public void .ctor(){} // RVA: 0x99EA5E0
    }

    public class VRCPlayerObject
    {
        // ── Methods ──
        public void GetPlayer(){} // RVA: 0x9A39D90
        public void NetworkConfigure(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCPortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCSceneDescriptor
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x9A3C3A0
        public void .ctor(){} // RVA: 0x9A3C620
    }

    public class VRCSpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E6D70
    }

    public class VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A3C8A0
    }

    public class VRCTMPDropdownExtension
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x9A3D100 | overloaded x3
    }

    public class VRCTween
    {
        public VRC.SDK3.Components.VRCTweenRunner _runner;

        // ── Methods ──
        public void get_Runner(){} // RVA: 0x9A4C670
        public void TweenPosition(){} // RVA: 0x9A4CCE0 | overloaded x2
        public void TweenLocalPosition(){} // RVA: 0x9A4CE60 | overloaded x2
        public void TweenPath(){} // RVA: 0x9A4D460 | overloaded x2
        public void TweenLocalPath(){} // RVA: 0x9A4D600 | overloaded x2
        public void TweenRotation(){} // RVA: 0x9A4CFE0 | overloaded x2
        public void TweenLocalRotation(){} // RVA: 0x9A4D160 | overloaded x2
        public void TweenScale(){} // RVA: 0x9A4D2E0 | overloaded x2
        public void KillAllTweens(){} // RVA: 0x9A4EB60 | overloaded x2
        public void DelayedCall(){} // RVA: 0x9A4D8D0
        public void TweenFloat(){} // RVA: 0x9A4E0E0 | overloaded x2
        public void TweenColor(){} // RVA: 0x9A4E1D0 | overloaded x6
        public void TweenInt(){} // RVA: 0x9A4DA80
        public void TweenVector3(){} // RVA: 0x9A4DB10
        public void TweenVolume(){} // RVA: 0x9A4DBD0
        public void TweenFade(){} // RVA: 0x9A4DF50 | overloaded x3
        public void TweenValue(){} // RVA: 0x9A4DD90
        public void TweenAnchorPos(){} // RVA: 0x9A4DE00
        public void TweenSizeDelta(){} // RVA: 0x9A4DE70
        public void TweenIntensity(){} // RVA: 0x9A4E160
        public void Play(){} // RVA: 0x9A4E240
        public void Pause(){} // RVA: 0x9A4E300
        public void Kill(){} // RVA: 0x9A4E4C0
        public void Complete(){} // RVA: 0x9A4E5A0
        public void Restart(){} // RVA: 0x9A4E650
        public void Flip(){} // RVA: 0x9A4E680
        public void PlayBackwards(){} // RVA: 0x9A4E810
        public void PlayForwards(){} // RVA: 0x9A4E8C0
        public void Goto(){} // RVA: 0x9A4EA50
        public void KillAll(){} // RVA: 0x7AE2030
        public void OnComplete(){} // RVA: 0x9A4EB90
        public void OnRewind(){} // RVA: 0x9A4ECF0
        public void SetLoops(){} // RVA: 0x9A4ED50
        public void SetDelay(){} // RVA: 0x9A4EE80
        public void SetUpdate(){} // RVA: 0x9A4EF70
        public void SetFrom(){} // RVA: 0x9A4F040
        public void SetSpeedBased(){} // RVA: 0x9A4F180
        public void SetEase(){} // RVA: 0x9A4F310 | overloaded x2
        public void SetDuration(){} // RVA: 0x9A4F460
        public void ChangeEndValue(){} // RVA: 0x9A4F5C0
        public void IsPlaying(){} // RVA: 0x9A4F620
        public void IsActive(){} // RVA: 0x9A4F6D0
        public void GetElapsed(){} // RVA: 0x9A4F780
        public void GetDuration(){} // RVA: 0x9A4F840
        public void IsBackwards(){} // RVA: 0x9A4F900
    }

    public class VRCTweenHandle
    {
        public int Id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x833580
        public void get_IsValid(){} // RVA: 0x61D2420
        public void Equals(){} // RVA: 0x9A5A9F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x19689B0
        public void ToString(){} // RVA: 0x9A5AA80
        public void op_Equality(){} // RVA: 0x2110AC0
        public void op_Inequality(){} // RVA: 0x6DCBE00
        public void Play(){} // RVA: 0x9A5AB30
        public void Pause(){} // RVA: 0x9A5ABF0
        public void Kill(){} // RVA: 0x9A5ADF0
        public void Complete(){} // RVA: 0x9A5AED0
        public void Restart(){} // RVA: 0x9A5AF80
        public void Flip(){} // RVA: 0x9A5AFB0
        public void PlayBackwards(){} // RVA: 0x9A5B140
        public void PlayForwards(){} // RVA: 0x9A5B1F0
        public void Goto(){} // RVA: 0x9A5B380
        public void OnComplete(){} // RVA: 0x9A5B490
        public void OnRewind(){} // RVA: 0x9A5B600
        public void SetLoops(){} // RVA: 0x9A5B670
        public void SetDelay(){} // RVA: 0x9A5B7A0
        public void SetUpdate(){} // RVA: 0x9A5B8A0
        public void From(){} // RVA: 0x9A5B980
        public void SetSpeedBased(){} // RVA: 0x9A5BAE0
        public void SetEase(){} // RVA: 0x9A5BC90 | overloaded x2
        public void SetDuration(){} // RVA: 0x9A5BDE0
        public void ChangeEndValue(){} // RVA: 0x9A5C160 | overloaded x4
        public void get_IsPlaying(){} // RVA: 0x9A5C210
        public void get_IsActive(){} // RVA: 0x9A5C2C0
        public void get_Elapsed(){} // RVA: 0x9A5C370
        public void get_Duration(){} // RVA: 0x9A5C430
        public void get_IsBackwards(){} // RVA: 0x9A5C4F0
    }

    public class VRCTweenPostLateUpdater
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x9A5A5F0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class VRCTweenRunner
    {
        // ── Methods ──
        public void CreateDurationSetter(){} // RVA: 0x9A4F9B0
        public void Awake(){} // RVA: 0x9A4FD30
        public void OnDestroy(){} // RVA: 0x9A50060
        public void OnSceneUnloaded(){} // RVA: 0x9A50350
        public void CreatePositionTween(){} // RVA: 0x9A503E0
        public void CreateLocalPositionTween(){} // RVA: 0x9A50790
        public void CreatePathTween(){} // RVA: 0x9A50B40
        public void CreateLocalPathTween(){} // RVA: 0x9A50F50
        public void CreateRotationTween(){} // RVA: 0x9A51360
        public void CreateLocalRotationTween(){} // RVA: 0x9A51730
        public void CreateScaleTween(){} // RVA: 0x9A51B00
        public void CreateDelayedCallTween(){} // RVA: 0x9A51EB0
        public void CreateFloatTween(){} // RVA: 0x9A52330
        public void CreateColorTween(){} // RVA: 0x9A52650
        public void CreateIntTween(){} // RVA: 0x9A52B20
        public void CreateVector3Tween(){} // RVA: 0x9A52FE0
        public void CreateAudioSourceVolumeTween(){} // RVA: 0x9A53320
        public void CreateCanvasGroupFadeTween(){} // RVA: 0x9A536C0
        public void CreateGraphicColorTween(){} // RVA: 0x9A53A60
        public void CreateGraphicFadeTween(){} // RVA: 0x9A53E70
        public void CreateSliderValueTween(){} // RVA: 0x9A54210
        public void CreateAnchorPosTween(){} // RVA: 0x9A545C0
        public void CreateSizeDeltaTween(){} // RVA: 0x9A54980
        public void CreateSpriteRendererColorTween(){} // RVA: 0x9A54D40
        public void CreateSpriteRendererFadeTween(){} // RVA: 0x9A55150
        public void CreateRendererColorTween(){} // RVA: 0x9A55670
        public void CreateRendererFloatTween(){} // RVA: 0x9A55CD0
        public void CreateLightIntensityTween(){} // RVA: 0x9A56210
        public void CreateLightColorTween(){} // RVA: 0x9A56650
        public void PlayTween(){} // RVA: 0x9A56B70
        public void PauseTween(){} // RVA: 0x9A56C20
        public void KillTween(){} // RVA: 0x9A56DD0
        public void CompleteTween(){} // RVA: 0x9A56E90
        public void RestartTween(){} // RVA: 0x9A56F30
        public void FlipTween(){} // RVA: 0x9A57150
        public void PlayTweenBackwards(){} // RVA: 0x9A572D0
        public void PlayTweenForwards(){} // RVA: 0x9A57370
        public void GotoTween(){} // RVA: 0x9A574F0
        public void SetTweenOnComplete(){} // RVA: 0x9A575F0
        public void SetTweenOnRewind(){} // RVA: 0x9A57750
        public void SetTweenLoops(){} // RVA: 0x9A57A20
        public void SetTweenDelay(){} // RVA: 0x9A57B40
        public void SetTweenUpdate(){} // RVA: 0x9A57C10
        public void SetTweenFrom(){} // RVA: 0x9A57CD0
        public void SetTweenSpeedBased(){} // RVA: 0x9A57E00
        public void SetTweenEase(){} // RVA: 0x9A57F70 | overloaded x2
        public void SetTweenDuration(){} // RVA: 0x9A580B0
        public void ChangeTweenEndValue(){} // RVA: 0x9A58200
        public void IsTweenPlaying(){} // RVA: 0x9A58450
        public void IsTweenActive(){} // RVA: 0x9A584F0
        public void GetTweenElapsed(){} // RVA: 0x9A58590
        public void GetTweenDuration(){} // RVA: 0x9A58640
        public void IsTweenBackwards(){} // RVA: 0x9A586F0
        public void OnTweenComplete(){} // RVA: 0x9A58780
        public void OnTweenRewind(){} // RVA: 0x9A588B0
        public void KillAllTweens(){} // RVA: 0x9A58960
        public void KillAllTweensOnTarget(){} // RVA: 0x9A58BD0
        public void .ctor(){} // RVA: 0x9A592C0
        public void .cctor(){} // RVA: 0x9A593C0
    }

    public class VRCTweenSafety
    {
        // ── Methods ──
        public void IsSafeDuration(){} // RVA: 0x9A5A7C0
        public void IsSafeDelay(){} // RVA: 0x9A5A7E0
        public void IsFinite(){} // RVA: 0x9A5A830 | overloaded x3
        public void IsSafePosition(){} // RVA: 0x9A5A860
        public void AreSafePositions(){} // RVA: 0x9A5A980
    }

    public class VRCUiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x391710
    }

    public class VRCUrlInputField
    {
        public System.Action onSelected; // 0x100
        public UnityEngine.TouchScreenKeyboard m_Keyboard; // 0x108
        public char[] kSeparators;
        public bool s_AreDevicesEvaluated; // 0x8
        public bool s_IsQuestDevice; // 0x9
        public bool s_IsPicoDevice; // 0xA
        public UnityEngine.UI.Text m_TextComponent; // 0x110
        public UnityEngine.UI.Graphic m_Placeholder; // 0x118
        public 0x6597E890 m_ContentType; // 0x120
        public 0x6597E8E8 m_InputType; // 0x124
        public char m_AsteriskChar; // 0x128
        public 0x6589C430 m_KeyboardType; // 0x12C
        public 0x6597E998 m_LineType; // 0x130
        public bool m_HideMobileInput; // 0x134
        public 0x6597E940 m_CharacterValidation; // 0x138
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
        public void GetUrl(){} // RVA: 0x9A3D240
        public void SetUrl(){} // RVA: 0x9A3D580
        public void add_onSelected(){} // RVA: 0x9A3D5B0
        public void remove_onSelected(){} // RVA: 0x9A3D6A0
        public void Awake(){} // RVA: 0x9A3D790
        public void get_input(){} // RVA: 0x9A3DCC0
        public void get_compositionString(){} // RVA: 0x9A3DEB0
        public void .ctor(){} // RVA: 0x9A3E000
        public void get_mesh(){} // RVA: 0x9A3E3B0
        public void get_cachedInputTextGenerator(){} // RVA: 0x9A3E520
        public void set_shouldHideMobileInput(){} // RVA: 0x9A3E5E0
        public void get_shouldHideMobileInput(){} // RVA: 0x9A3E680
        public void set_shouldActivateOnSelect(){} // RVA: 0x9A3E720
        public void get_shouldActivateOnSelect(){} // RVA: 0x9A3E730
        public void get_text(){} // RVA: 0xDA5BB0
        public void set_text(){} // RVA: 0x9A3E7D0
        public void SetText(){} // RVA: 0x9A3E7E0
        public void get_isFocused(){} // RVA: 0x98C6DE0
        public void get_caretBlinkRate(){} // RVA: 0x9A3EF10
        public void set_caretBlinkRate(){} // RVA: 0x9A3EF20
        public void get_caretWidth(){} // RVA: 0x627D120
        public void set_caretWidth(){} // RVA: 0x9A3EFE0
        public void get_textComponent(){} // RVA: 0x507710
        public void set_textComponent(){} // RVA: 0x9A3F040
        public void get_placeholder(){} // RVA: 0x507D10
        public void set_placeholder(){} // RVA: 0x9A3F3D0
        public void get_caretColor(){} // RVA: 0x9A3F430
        public void set_caretColor(){} // RVA: 0x9A3F490
        public void get_customCaretColor(){} // RVA: 0x1579B10
        public void set_customCaretColor(){} // RVA: 0x9A3F500
        public void get_selectionColor(){} // RVA: 0x348730
        public void set_selectionColor(){} // RVA: 0x9A3F520
        public void get_onEndEdit(){} // RVA: 0x3485F0
        public void set_onEndEdit(){} // RVA: 0x9A3F590
        public void get_onValueChange(){} // RVA: 0x348660
        public void set_onValueChange(){} // RVA: 0x9A3F5F0
        public void get_onValueChanged(){} // RVA: 0x348660
        public void set_onValueChanged(){} // RVA: 0x9A3F5F0
        public void get_onValidateInput(){} // RVA: 0x9FE130
        public void set_onValidateInput(){} // RVA: 0x9A3F650
        public void get_characterLimit(){} // RVA: 0x612FB40
        public void set_characterLimit(){} // RVA: 0x9A3F6B0
        public void get_contentType(){} // RVA: 0xD19990
        public void set_contentType(){} // RVA: 0x9A3F760
        public void get_lineType(){} // RVA: 0x88E540
        public void set_lineType(){} // RVA: 0x9A3F910
        public void get_inputType(){} // RVA: 0x613D7A0
        public void set_inputType(){} // RVA: 0x9A3FA00
        public void get_touchScreenKeyboard(){} // RVA: 0xA902E0
        public void get_keyboardType(){} // RVA: 0x98C6CE0
        public void set_keyboardType(){} // RVA: 0x9A3FA70
        public void get_characterValidation(){} // RVA: 0x120A360
        public void set_characterValidation(){} // RVA: 0x9A3FAE0
        public void get_readOnly(){} // RVA: 0x64AA630
        public void set_readOnly(){} // RVA: 0x64AA640
        public void get_multiLine(){} // RVA: 0x9A3FB50
        public void get_asteriskChar(){} // RVA: 0x9A3FB70
        public void set_asteriskChar(){} // RVA: 0x9A3FB80
        public void get_wasCanceled(){} // RVA: 0x9A3FC30
        public void ClampPos(){} // RVA: 0x9A3FC40
        public void get_caretPositionInternal(){} // RVA: 0x9A3FC80
        public void set_caretPositionInternal(){} // RVA: 0x9A3FCB0
        public void get_caretSelectPositionInternal(){} // RVA: 0x9A3FD00
        public void set_caretSelectPositionInternal(){} // RVA: 0x9A3FD30
        public void get_hasSelection(){} // RVA: 0x9A3FD80
        public void get_caretPosition(){} // RVA: 0x9A3FD00
        public void set_caretPosition(){} // RVA: 0x9A3FDE0
        public void get_selectionAnchorPosition(){} // RVA: 0x9A3FC80
        public void set_selectionAnchorPosition(){} // RVA: 0x9A3FEA0
        public void get_selectionFocusPosition(){} // RVA: 0x9A3FD00
        public void set_selectionFocusPosition(){} // RVA: 0x9A3FF10
        public void OnEnable(){} // RVA: 0x9A3FF80
        public void OnDisable(){} // RVA: 0x9A40370
        public void CaretBlink(){} // RVA: 0x9A40810
        public void SetCaretVisible(){} // RVA: 0x9A408B0
        public void SetCaretActive(){} // RVA: 0x9A40930
        public void UpdateCaretMaterial(){} // RVA: 0x9A40A20
        public void OnFocus(){} // RVA: 0x9A40C50
        public void SelectAll(){} // RVA: 0x9A40C60
        public void MoveTextEnd(){} // RVA: 0x9A40CF0
        public void MoveTextStart(){} // RVA: 0x9A40E10
        public void get_clipboard(){} // RVA: 0x9A40F00
        public void set_clipboard(){} // RVA: 0x9A40F80
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x9A41010
        public void InPlaceEditing(){} // RVA: 0x9A41130
        public void InPlaceEditingChanged(){} // RVA: 0x9A411D0
        public void UpdateCaretFromKeyboard(){} // RVA: 0x9A41280
        public void LateUpdate(){} // RVA: 0x9A41430
        public void ScreenToLocal(){} // RVA: 0x9A41D00
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x9A424D0
        public void GetCharacterIndexFromPosition(){} // RVA: 0x9A427D0
        public void MayDrag(){} // RVA: 0x9A42AE0
        public void OnBeginDrag(){} // RVA: 0x9A42C40
        public void OnDrag(){} // RVA: 0x9A42C70
        public void MouseDragOutsideRect(){} // RVA: 0x9A42FA0
        public void OnEndDrag(){} // RVA: 0x9A430A0
        public void OnPointerDown(){} // RVA: 0x9A430D0
        public void KeyPressed(){} // RVA: 0x9A433B0
        public void IsValidChar(){} // RVA: 0x9A43B90
        public void ProcessEvent(){} // RVA: 0x9A43BF0
        public void OnUpdateSelected(){} // RVA: 0x9A43C00
        public void GetSelectedString(){} // RVA: 0x9A43E10
        public void FindtNextWordBegin(){} // RVA: 0x9A43F10
        public void MoveRight(){} // RVA: 0x9A44020
        public void FindtPrevWordBegin(){} // RVA: 0x9A442C0
        public void MoveLeft(){} // RVA: 0x9A443C0
        public void DetermineCharacterLine(){} // RVA: 0x9A44650
        public void LineUpCharacterPosition(){} // RVA: 0x9A447F0
        public void LineDownCharacterPosition(){} // RVA: 0x9A44A90
        public void MoveDown(){} // RVA: 0x9A44DC0 | overloaded x2
        public void MoveUp(){} // RVA: 0x9A44FF0 | overloaded x2
        public void Delete(){} // RVA: 0x9A451D0
        public void ForwardSpace(){} // RVA: 0x9A45490
        public void Backspace(){} // RVA: 0x9A455E0
        public void Insert(){} // RVA: 0x9A45760
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x9A45990
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x9A459E0
        public void SendOnValueChanged(){} // RVA: 0x9A45A00
        public void SendOnSubmit(){} // RVA: 0x9A45AC0
        public void Append(){} // RVA: 0x9A45C60 | overloaded x2
        public void UpdateLabel(){} // RVA: 0x9A45E00
        public void IsSelectionVisible(){} // RVA: 0x9A46580
        public void GetLineStartPosition(){} // RVA: 0x9A46650
        public void GetLineEndPosition(){} // RVA: 0x9A46780
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x9A46900
        public void ForceLabelUpdate(){} // RVA: 0x9A47320
        public void MarkGeometryAsDirty(){} // RVA: 0x9A47330
        public void Rebuild(){} // RVA: 0x9A473D0
        public void LayoutComplete(){} // RVA: 0x2DD310
        public void GraphicUpdateComplete(){} // RVA: 0x2DD310
        public void UpdateGeometry(){} // RVA: 0x9A473E0
        public void AssignPositioningIfNeeded(){} // RVA: 0x9A479C0
        public void OnFillVBO(){} // RVA: 0x9A484B0
        public void GenerateCaret(){} // RVA: 0x9A486C0
        public void CreateCursorVerts(){} // RVA: 0x9A49490
        public void GenerateHighlight(){} // RVA: 0x9A496A0
        public void Validate(){} // RVA: 0x9A49F40
        public void ActivateInputField(){} // RVA: 0x9A4A5B0
        public void ActivateInputFieldInternal(){} // RVA: 0x9A4A800
        public void OnSelect(){} // RVA: 0x9A4B030
        public void OnPointerClick(){} // RVA: 0x9A4B0E0
        public void DeactivateInputField(){} // RVA: 0x9A4B110
        public void OnDeselect(){} // RVA: 0x9A4B4C0
        public void OnSubmit(){} // RVA: 0x9A4B4F0
        public void EnforceContentType(){} // RVA: 0x9A4B540
        public void EnforceTextHOverflow(){} // RVA: 0x9A4B6B0
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x9A4B810
        public void SetToCustom(){} // RVA: 0x9A4B880
        public void DoStateTransition(){} // RVA: 0x9A4B8A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x2DD310
        public void CalculateLayoutInputVertical(){} // RVA: 0x2DD310
        public void get_minWidth(){} // RVA: 0xAFF380
        public void get_preferredWidth(){} // RVA: 0x9A4B8D0
        public void get_flexibleWidth(){} // RVA: 0x6DB6BF0
        public void get_minHeight(){} // RVA: 0xAFF380
        public void get_preferredHeight(){} // RVA: 0x9A4BB30
        public void get_flexibleHeight(){} // RVA: 0x6DB6BF0
        public void get_layoutPriority(){} // RVA: 0x3CFAF0
        public void .cctor(){} // RVA: 0x9A4BDD0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x891B00
    }

    public class VRCVisualDamage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x99E69E0
    }

}