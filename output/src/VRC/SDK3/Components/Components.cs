// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components
// Classes: 30
// Methods: 448

namespace VRC.SDK3.Components
{
    public class AbstractUdonBehaviour
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x7FFAF2ABCE10
        public void GetProgramVariable(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFAF2AC1120 | overloaded x2
        public void SetProgramVariable(){} // RVA: 0x7FFAF2ADDC60 | overloaded x2
        public void SendCustomEvent(){} // RVA: 0x7FFAF2AD4B10
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFAF2AD7F90 | overloaded x9
        public void SendCustomEventDelayedSeconds(){}
        public void SendCustomEventDelayedFrames(){}
        public void get_DisableInteractive(){} // RVA: 0x7FFAF2ABDBE0
        public void set_DisableInteractive(){} // RVA: 0x7FFAF2AD5130
        public void get_DisableEventProcessing(){} // RVA: 0x7FFAF2ABDBE0
        public void set_DisableEventProcessing(){} // RVA: 0x7FFAF2AD5130
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAF2ABCD60
        public void InitializeUdonContent(){} // RVA: 0x7FFAF2AD4A50
        public void RunProgram(){} // RVA: 0x7FFAF2AD4B10
        public void RunInputEvent(){}
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFAF2ABDBE0
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFAF2AD5130
        public void RequestSerialization(){} // RVA: 0x7FFAF2AD4A50
        public void get_InteractionText(){} // RVA: 0x7FFAF2ABCD60
        public void set_InteractionText(){} // RVA: 0x7FFAF2AD4B10
        public void get_SyncMethod(){} // RVA: 0x7FFAF2ABD840
        public void set_SyncMethod(){} // RVA: 0x7FFAF2AD4FA0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFAF2AC1120
        public void GetComponentIndexFixed(){} // RVA: 0x7FFAF2ABD840
        public void RunEvent(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFAF32DDF40
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.get_enabled(){} // RVA: 0x7FFAF2DF3DE0
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.set_enabled(){} // RVA: 0x7FFAF3C895B0
    }

    public class IVRCDestructible
    {
    }

    public class MultipleDisplayUtilities
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x7FFAFC4ECAB0
        public void GetMousePositionRelativeToMainDisplayResolution(){} // RVA: 0x7FFAFC4ECC10
    }

    public class SetPropertyUtility
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFAF9A9EE20
        public void SetStruct(){} // RVA: 0x7FFAF2D33FA0
        public void SetClass(){} // RVA: 0x7FFAF2D33FA0
    }

    public class VRCAvatarPedestal
    {
        // ── Methods ──
        public void SwitchAvatar(){} // RVA: 0x7FFAFC4EAE20 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC498330
    }

    public class VRCCameraDollyAnimation
    {
        // ── Methods ──
        public void Import(){} // RVA: 0x7FFAFC4E9DF0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCCameraDollyPath
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCCameraDollyPathPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC4E9E50
    }

    public class VRCEnablePersistence
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC4E9BA0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCInputFieldKeyboardOverride
    {
        public object StartResolveURLCoroutine;

        // ── Methods ──
        public void get_OverrideBehavior(){} // RVA: 0x7FFAF3210030
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCInteractable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32DDF40
    }

    public class VRCMirrorReflection
    {
        // ── Methods ──
        public void UpdateCameraClearing(){} // RVA: 0x7FFAFC4EBE30
        public void .ctor(){} // RVA: 0x7FFAFC4EC340
    }

    public class VRCObjectPool
    {
        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0x7FFAFC4E9ED0
        public void Shuffle(){} // RVA: 0x7FFAFC4EA490
        public void TryToSpawn(){} // RVA: 0x7FFAFC4EA4A0
        public void Return(){} // RVA: 0x7FFAFC4EA860
        public void .ctor(){} // RVA: 0x7FFAFC4EAC70
    }

    public class VRCObjectSync
    {
        // ── Methods ──
        public void get_SetKinematicHook(){} // RVA: 0x7FFAFC4EAF90
        public void set_SetKinematicHook(){} // RVA: 0x7FFAFC4EAFF0
        public void get_SetGravityHook(){} // RVA: 0x7FFAFC4EB0A0
        public void set_SetGravityHook(){} // RVA: 0x7FFAFC4EB100
        public void get_FlagDiscontinuityHook(){} // RVA: 0x7FFAFC4EB1C0
        public void set_FlagDiscontinuityHook(){} // RVA: 0x7FFAFC4EB220
        public void SetKinematic(){} // RVA: 0x7FFAFC4EB2E0
        public void EditorSetKinematic(){} // RVA: 0x7FFAFC4EB3A0
        public void SetGravity(){} // RVA: 0x7FFAFC4EB4E0
        public void EditorSetGravity(){} // RVA: 0x7FFAFC4EB5A0
        public void FlagDiscontinuity(){} // RVA: 0x7FFAFC4EB6E0
        public void TeleportTo(){} // RVA: 0x7FFAFC4EB790
        public void Respawn(){} // RVA: 0x7FFAFC4EB900
        public void NetworkConfigure(){} // RVA: 0x7FFAFC4EB980
        public void .ctor(){} // RVA: 0x7FFAF2DE7060
        public void .cctor(){} // RVA: 0x7FFAFC4EBA20
    }

    public class VRCOpenMenu
    {
        // ── Methods ──
        public void OpenAvatarListing(){} // RVA: 0x7FFAFC4ED1E0
    }

    public class VRCPickup
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAFC4EBD00
        public void .ctor(){} // RVA: 0x7FFAFC49A5E0
    }

    public class VRCPlayerObject
    {
        // ── Methods ──
        public void GetPlayer(){} // RVA: 0x7FFAFC4E9D90
        public void NetworkConfigure(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCPortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCSceneDescriptor
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAFC4EC3A0
        public void .ctor(){} // RVA: 0x7FFAFC4EC620
    }

    public class VRCSpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC496D70
    }

    public class VRCStation
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC4EC8A0
    }

    public class VRCTMPDropdownExtension
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0x7FFAFC4ED100 | overloaded x3
    }

    public class VRCTween
    {
        // ── Methods ──
        public void get_Runner(){} // RVA: 0x7FFAFC4FC670
        public void TweenPosition(){} // RVA: 0x7FFAFC4FCCE0 | overloaded x2
        public void TweenLocalPosition(){} // RVA: 0x7FFAFC4FCE60 | overloaded x2
        public void TweenPath(){} // RVA: 0x7FFAFC4FD460 | overloaded x2
        public void TweenLocalPath(){} // RVA: 0x7FFAFC4FD600 | overloaded x2
        public void TweenRotation(){} // RVA: 0x7FFAFC4FCFE0 | overloaded x2
        public void TweenLocalRotation(){} // RVA: 0x7FFAFC4FD160 | overloaded x2
        public void TweenScale(){} // RVA: 0x7FFAFC4FD2E0 | overloaded x2
        public void KillAllTweens(){} // RVA: 0x7FFAFC4FEB60 | overloaded x2
        public void DelayedCall(){} // RVA: 0x7FFAFC4FD8D0
        public void TweenFloat(){} // RVA: 0x7FFAFC4FE0E0 | overloaded x2
        public void TweenColor(){} // RVA: 0x7FFAFC4FE1D0 | overloaded x6
        public void TweenInt(){} // RVA: 0x7FFAFC4FDA80
        public void TweenVector3(){} // RVA: 0x7FFAFC4FDB10
        public void TweenVolume(){} // RVA: 0x7FFAFC4FDBD0
        public void TweenFade(){} // RVA: 0x7FFAFC4FDF50 | overloaded x3
        public void TweenValue(){} // RVA: 0x7FFAFC4FDD90
        public void TweenAnchorPos(){} // RVA: 0x7FFAFC4FDE00
        public void TweenSizeDelta(){} // RVA: 0x7FFAFC4FDE70
        public void TweenIntensity(){} // RVA: 0x7FFAFC4FE160
        public void Play(){} // RVA: 0x7FFAFC4FE240
        public void Pause(){} // RVA: 0x7FFAFC4FE300
        public void Kill(){} // RVA: 0x7FFAFC4FE4C0
        public void Complete(){} // RVA: 0x7FFAFC4FE5A0
        public void Restart(){} // RVA: 0x7FFAFC4FE650
        public void Flip(){} // RVA: 0x7FFAFC4FE680
        public void PlayBackwards(){} // RVA: 0x7FFAFC4FE810
        public void PlayForwards(){} // RVA: 0x7FFAFC4FE8C0
        public void Goto(){} // RVA: 0x7FFAFC4FEA50
        public void KillAll(){} // RVA: 0x7FFAFA592030
        public void OnComplete(){} // RVA: 0x7FFAFC4FEB90
        public void OnRewind(){} // RVA: 0x7FFAFC4FECF0
        public void SetLoops(){} // RVA: 0x7FFAFC4FED50
        public void SetDelay(){} // RVA: 0x7FFAFC4FEE80
        public void SetUpdate(){} // RVA: 0x7FFAFC4FEF70
        public void SetFrom(){} // RVA: 0x7FFAFC4FF040
        public void SetSpeedBased(){} // RVA: 0x7FFAFC4FF180
        public void SetEase(){} // RVA: 0x7FFAFC4FF310 | overloaded x2
        public void SetDuration(){} // RVA: 0x7FFAFC4FF460
        public void ChangeEndValue(){} // RVA: 0x7FFAFC4FF5C0
        public void IsPlaying(){} // RVA: 0x7FFAFC4FF620
        public void IsActive(){} // RVA: 0x7FFAFC4FF6D0
        public void GetElapsed(){} // RVA: 0x7FFAFC4FF780
        public void GetDuration(){} // RVA: 0x7FFAFC4FF840
        public void IsBackwards(){} // RVA: 0x7FFAFC4FF900
    }

    public class VRCTweenHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF32E3580
        public void get_IsValid(){} // RVA: 0x7FFAF8C82420
        public void Equals(){} // RVA: 0x7FFAFC50A9F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF44189B0
        public void ToString(){} // RVA: 0x7FFAFC50AA80
        public void op_Equality(){} // RVA: 0x7FFAF4BC0AC0
        public void op_Inequality(){} // RVA: 0x7FFAF987BE00
        public void Play(){} // RVA: 0x7FFAFC50AB30
        public void Pause(){} // RVA: 0x7FFAFC50ABF0
        public void Kill(){} // RVA: 0x7FFAFC50ADF0
        public void Complete(){} // RVA: 0x7FFAFC50AED0
        public void Restart(){} // RVA: 0x7FFAFC50AF80
        public void Flip(){} // RVA: 0x7FFAFC50AFB0
        public void PlayBackwards(){} // RVA: 0x7FFAFC50B140
        public void PlayForwards(){} // RVA: 0x7FFAFC50B1F0
        public void Goto(){} // RVA: 0x7FFAFC50B380
        public void OnComplete(){} // RVA: 0x7FFAFC50B490
        public void OnRewind(){} // RVA: 0x7FFAFC50B600
        public void SetLoops(){} // RVA: 0x7FFAFC50B670
        public void SetDelay(){} // RVA: 0x7FFAFC50B7A0
        public void SetUpdate(){} // RVA: 0x7FFAFC50B8A0
        public void From(){} // RVA: 0x7FFAFC50B980
        public void SetSpeedBased(){} // RVA: 0x7FFAFC50BAE0
        public void SetEase(){} // RVA: 0x7FFAFC50BC90 | overloaded x2
        public void SetDuration(){} // RVA: 0x7FFAFC50BDE0
        public void ChangeEndValue(){} // RVA: 0x7FFAFC50C160 | overloaded x4
        public void get_IsPlaying(){} // RVA: 0x7FFAFC50C210
        public void get_IsActive(){} // RVA: 0x7FFAFC50C2C0
        public void get_Elapsed(){} // RVA: 0x7FFAFC50C370
        public void get_Duration(){} // RVA: 0x7FFAFC50C430
        public void get_IsBackwards(){} // RVA: 0x7FFAFC50C4F0
    }

    public class VRCTweenPostLateUpdater
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFAFC50A5F0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class VRCTweenRunner
    {
        // ── Methods ──
        public void CreateDurationSetter(){} // RVA: 0x7FFAFC4FF9B0
        public void Awake(){} // RVA: 0x7FFAFC4FFD30
        public void OnDestroy(){} // RVA: 0x7FFAFC500060
        public void OnSceneUnloaded(){} // RVA: 0x7FFAFC500350
        public void CreatePositionTween(){} // RVA: 0x7FFAFC5003E0
        public void CreateLocalPositionTween(){} // RVA: 0x7FFAFC500790
        public void CreatePathTween(){} // RVA: 0x7FFAFC500B40
        public void CreateLocalPathTween(){} // RVA: 0x7FFAFC500F50
        public void CreateRotationTween(){} // RVA: 0x7FFAFC501360
        public void CreateLocalRotationTween(){} // RVA: 0x7FFAFC501730
        public void CreateScaleTween(){} // RVA: 0x7FFAFC501B00
        public void CreateDelayedCallTween(){} // RVA: 0x7FFAFC501EB0
        public void CreateFloatTween(){} // RVA: 0x7FFAFC502330
        public void CreateColorTween(){} // RVA: 0x7FFAFC502650
        public void CreateIntTween(){} // RVA: 0x7FFAFC502B20
        public void CreateVector3Tween(){} // RVA: 0x7FFAFC502FE0
        public void CreateAudioSourceVolumeTween(){} // RVA: 0x7FFAFC503320
        public void CreateCanvasGroupFadeTween(){} // RVA: 0x7FFAFC5036C0
        public void CreateGraphicColorTween(){} // RVA: 0x7FFAFC503A60
        public void CreateGraphicFadeTween(){} // RVA: 0x7FFAFC503E70
        public void CreateSliderValueTween(){} // RVA: 0x7FFAFC504210
        public void CreateAnchorPosTween(){} // RVA: 0x7FFAFC5045C0
        public void CreateSizeDeltaTween(){} // RVA: 0x7FFAFC504980
        public void CreateSpriteRendererColorTween(){} // RVA: 0x7FFAFC504D40
        public void CreateSpriteRendererFadeTween(){} // RVA: 0x7FFAFC505150
        public void CreateRendererColorTween(){} // RVA: 0x7FFAFC505670
        public void CreateRendererFloatTween(){} // RVA: 0x7FFAFC505CD0
        public void CreateLightIntensityTween(){} // RVA: 0x7FFAFC506210
        public void CreateLightColorTween(){} // RVA: 0x7FFAFC506650
        public void PlayTween(){} // RVA: 0x7FFAFC506B70
        public void PauseTween(){} // RVA: 0x7FFAFC506C20
        public void KillTween(){} // RVA: 0x7FFAFC506DD0
        public void CompleteTween(){} // RVA: 0x7FFAFC506E90
        public void RestartTween(){} // RVA: 0x7FFAFC506F30
        public void FlipTween(){} // RVA: 0x7FFAFC507150
        public void PlayTweenBackwards(){} // RVA: 0x7FFAFC5072D0
        public void PlayTweenForwards(){} // RVA: 0x7FFAFC507370
        public void GotoTween(){} // RVA: 0x7FFAFC5074F0
        public void SetTweenOnComplete(){} // RVA: 0x7FFAFC5075F0
        public void SetTweenOnRewind(){} // RVA: 0x7FFAFC507750
        public void SetTweenLoops(){} // RVA: 0x7FFAFC507A20
        public void SetTweenDelay(){} // RVA: 0x7FFAFC507B40
        public void SetTweenUpdate(){} // RVA: 0x7FFAFC507C10
        public void SetTweenFrom(){} // RVA: 0x7FFAFC507CD0
        public void SetTweenSpeedBased(){} // RVA: 0x7FFAFC507E00
        public void SetTweenEase(){} // RVA: 0x7FFAFC507F70 | overloaded x2
        public void SetTweenDuration(){} // RVA: 0x7FFAFC5080B0
        public void ChangeTweenEndValue(){} // RVA: 0x7FFAFC508200
        public void IsTweenPlaying(){} // RVA: 0x7FFAFC508450
        public void IsTweenActive(){} // RVA: 0x7FFAFC5084F0
        public void GetTweenElapsed(){} // RVA: 0x7FFAFC508590
        public void GetTweenDuration(){} // RVA: 0x7FFAFC508640
        public void IsTweenBackwards(){} // RVA: 0x7FFAFC5086F0
        public void OnTweenComplete(){} // RVA: 0x7FFAFC508780
        public void OnTweenRewind(){} // RVA: 0x7FFAFC5088B0
        public void KillAllTweens(){} // RVA: 0x7FFAFC508960
        public void KillAllTweensOnTarget(){} // RVA: 0x7FFAFC508BD0
        public void .ctor(){} // RVA: 0x7FFAFC5092C0
        public void .cctor(){} // RVA: 0x7FFAFC5093C0
    }

    public class VRCTweenSafety
    {
        // ── Methods ──
        public void IsSafeDuration(){} // RVA: 0x7FFAFC50A7C0
        public void IsSafeDelay(){} // RVA: 0x7FFAFC50A7E0
        public void IsFinite(){} // RVA: 0x7FFAFC50A830 | overloaded x3
        public void IsSafePosition(){} // RVA: 0x7FFAFC50A860
        public void AreSafePositions(){} // RVA: 0x7FFAFC50A980
    }

    public class VRCUiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E41710
    }

    public class VRCUrlInputField
    {
        // ── Methods ──
        public void GetUrl(){} // RVA: 0x7FFAFC4ED240
        public void SetUrl(){} // RVA: 0x7FFAFC4ED580
        public void add_onSelected(){} // RVA: 0x7FFAFC4ED5B0
        public void remove_onSelected(){} // RVA: 0x7FFAFC4ED6A0
        public void Awake(){} // RVA: 0x7FFAFC4ED790
        public void get_input(){} // RVA: 0x7FFAFC4EDCC0
        public void get_compositionString(){} // RVA: 0x7FFAFC4EDEB0
        public void .ctor(){} // RVA: 0x7FFAFC4EE000
        public void get_mesh(){} // RVA: 0x7FFAFC4EE3B0
        public void get_cachedInputTextGenerator(){} // RVA: 0x7FFAFC4EE520
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFAFC4EE5E0
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFAFC4EE680
        public void set_shouldActivateOnSelect(){} // RVA: 0x7FFAFC4EE720
        public void get_shouldActivateOnSelect(){} // RVA: 0x7FFAFC4EE730
        public void get_text(){} // RVA: 0x7FFAF3855BB0
        public void set_text(){} // RVA: 0x7FFAFC4EE7D0
        public void SetText(){} // RVA: 0x7FFAFC4EE7E0
        public void get_isFocused(){} // RVA: 0x7FFAFC376DE0
        public void get_caretBlinkRate(){} // RVA: 0x7FFAFC4EEF10
        public void set_caretBlinkRate(){} // RVA: 0x7FFAFC4EEF20
        public void get_caretWidth(){} // RVA: 0x7FFAF8D2D120
        public void set_caretWidth(){} // RVA: 0x7FFAFC4EEFE0
        public void get_textComponent(){} // RVA: 0x7FFAF2FB7710
        public void set_textComponent(){} // RVA: 0x7FFAFC4EF040
        public void get_placeholder(){} // RVA: 0x7FFAF2FB7D10
        public void set_placeholder(){} // RVA: 0x7FFAFC4EF3D0
        public void get_caretColor(){} // RVA: 0x7FFAFC4EF430
        public void set_caretColor(){} // RVA: 0x7FFAFC4EF490
        public void get_customCaretColor(){} // RVA: 0x7FFAF4029B10
        public void set_customCaretColor(){} // RVA: 0x7FFAFC4EF500
        public void get_selectionColor(){} // RVA: 0x7FFAF2DF8730
        public void set_selectionColor(){} // RVA: 0x7FFAFC4EF520
        public void get_onEndEdit(){} // RVA: 0x7FFAF2DF85F0
        public void set_onEndEdit(){} // RVA: 0x7FFAFC4EF590
        public void get_onValueChange(){} // RVA: 0x7FFAF2DF8660
        public void set_onValueChange(){} // RVA: 0x7FFAFC4EF5F0
        public void get_onValueChanged(){} // RVA: 0x7FFAF2DF8660
        public void set_onValueChanged(){} // RVA: 0x7FFAFC4EF5F0
        public void get_onValidateInput(){} // RVA: 0x7FFAF34AE130
        public void set_onValidateInput(){} // RVA: 0x7FFAFC4EF650
        public void get_characterLimit(){} // RVA: 0x7FFAF8BDFB40
        public void set_characterLimit(){} // RVA: 0x7FFAFC4EF6B0
        public void get_contentType(){} // RVA: 0x7FFAF37C9990
        public void set_contentType(){} // RVA: 0x7FFAFC4EF760
        public void get_lineType(){} // RVA: 0x7FFAF333E540
        public void set_lineType(){} // RVA: 0x7FFAFC4EF910
        public void get_inputType(){} // RVA: 0x7FFAF8BED7A0
        public void set_inputType(){} // RVA: 0x7FFAFC4EFA00
        public void get_touchScreenKeyboard(){} // RVA: 0x7FFAF35402E0
        public void get_keyboardType(){} // RVA: 0x7FFAFC376CE0
        public void set_keyboardType(){} // RVA: 0x7FFAFC4EFA70
        public void get_characterValidation(){} // RVA: 0x7FFAF3CBA360
        public void set_characterValidation(){} // RVA: 0x7FFAFC4EFAE0
        public void get_readOnly(){} // RVA: 0x7FFAF8F5A630
        public void set_readOnly(){} // RVA: 0x7FFAF8F5A640
        public void get_multiLine(){} // RVA: 0x7FFAFC4EFB50
        public void get_asteriskChar(){} // RVA: 0x7FFAFC4EFB70
        public void set_asteriskChar(){} // RVA: 0x7FFAFC4EFB80
        public void get_wasCanceled(){} // RVA: 0x7FFAFC4EFC30
        public void ClampPos(){} // RVA: 0x7FFAFC4EFC40
        public void get_caretPositionInternal(){} // RVA: 0x7FFAFC4EFC80
        public void set_caretPositionInternal(){} // RVA: 0x7FFAFC4EFCB0
        public void get_caretSelectPositionInternal(){} // RVA: 0x7FFAFC4EFD00
        public void set_caretSelectPositionInternal(){} // RVA: 0x7FFAFC4EFD30
        public void get_hasSelection(){} // RVA: 0x7FFAFC4EFD80
        public void get_caretPosition(){} // RVA: 0x7FFAFC4EFD00
        public void set_caretPosition(){} // RVA: 0x7FFAFC4EFDE0
        public void get_selectionAnchorPosition(){} // RVA: 0x7FFAFC4EFC80
        public void set_selectionAnchorPosition(){} // RVA: 0x7FFAFC4EFEA0
        public void get_selectionFocusPosition(){} // RVA: 0x7FFAFC4EFD00
        public void set_selectionFocusPosition(){} // RVA: 0x7FFAFC4EFF10
        public void OnEnable(){} // RVA: 0x7FFAFC4EFF80
        public void OnDisable(){} // RVA: 0x7FFAFC4F0370
        public void CaretBlink(){} // RVA: 0x7FFAFC4F0810
        public void SetCaretVisible(){} // RVA: 0x7FFAFC4F08B0
        public void SetCaretActive(){} // RVA: 0x7FFAFC4F0930
        public void UpdateCaretMaterial(){} // RVA: 0x7FFAFC4F0A20
        public void OnFocus(){} // RVA: 0x7FFAFC4F0C50
        public void SelectAll(){} // RVA: 0x7FFAFC4F0C60
        public void MoveTextEnd(){} // RVA: 0x7FFAFC4F0CF0
        public void MoveTextStart(){} // RVA: 0x7FFAFC4F0E10
        public void get_clipboard(){} // RVA: 0x7FFAFC4F0F00
        public void set_clipboard(){} // RVA: 0x7FFAFC4F0F80
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x7FFAFC4F1010
        public void InPlaceEditing(){} // RVA: 0x7FFAFC4F1130
        public void InPlaceEditingChanged(){} // RVA: 0x7FFAFC4F11D0
        public void UpdateCaretFromKeyboard(){} // RVA: 0x7FFAFC4F1280
        public void LateUpdate(){} // RVA: 0x7FFAFC4F1430
        public void ScreenToLocal(){} // RVA: 0x7FFAFC4F1D00
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x7FFAFC4F24D0
        public void GetCharacterIndexFromPosition(){} // RVA: 0x7FFAFC4F27D0
        public void MayDrag(){} // RVA: 0x7FFAFC4F2AE0
        public void OnBeginDrag(){} // RVA: 0x7FFAFC4F2C40
        public void OnDrag(){} // RVA: 0x7FFAFC4F2C70
        public void MouseDragOutsideRect(){} // RVA: 0x7FFAFC4F2FA0
        public void OnEndDrag(){} // RVA: 0x7FFAFC4F30A0
        public void OnPointerDown(){} // RVA: 0x7FFAFC4F30D0
        public void KeyPressed(){} // RVA: 0x7FFAFC4F33B0
        public void IsValidChar(){} // RVA: 0x7FFAFC4F3B90
        public void ProcessEvent(){} // RVA: 0x7FFAFC4F3BF0
        public void OnUpdateSelected(){} // RVA: 0x7FFAFC4F3C00
        public void GetSelectedString(){} // RVA: 0x7FFAFC4F3E10
        public void FindtNextWordBegin(){} // RVA: 0x7FFAFC4F3F10
        public void MoveRight(){} // RVA: 0x7FFAFC4F4020
        public void FindtPrevWordBegin(){} // RVA: 0x7FFAFC4F42C0
        public void MoveLeft(){} // RVA: 0x7FFAFC4F43C0
        public void DetermineCharacterLine(){} // RVA: 0x7FFAFC4F4650
        public void LineUpCharacterPosition(){} // RVA: 0x7FFAFC4F47F0
        public void LineDownCharacterPosition(){} // RVA: 0x7FFAFC4F4A90
        public void MoveDown(){} // RVA: 0x7FFAFC4F4DC0 | overloaded x2
        public void MoveUp(){} // RVA: 0x7FFAFC4F4FF0 | overloaded x2
        public void Delete(){} // RVA: 0x7FFAFC4F51D0
        public void ForwardSpace(){} // RVA: 0x7FFAFC4F5490
        public void Backspace(){} // RVA: 0x7FFAFC4F55E0
        public void Insert(){} // RVA: 0x7FFAFC4F5760
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7FFAFC4F5990
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7FFAFC4F59E0
        public void SendOnValueChanged(){} // RVA: 0x7FFAFC4F5A00
        public void SendOnSubmit(){} // RVA: 0x7FFAFC4F5AC0
        public void Append(){} // RVA: 0x7FFAFC4F5C60 | overloaded x2
        public void UpdateLabel(){} // RVA: 0x7FFAFC4F5E00
        public void IsSelectionVisible(){} // RVA: 0x7FFAFC4F6580
        public void GetLineStartPosition(){} // RVA: 0x7FFAFC4F6650
        public void GetLineEndPosition(){} // RVA: 0x7FFAFC4F6780
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x7FFAFC4F6900
        public void ForceLabelUpdate(){} // RVA: 0x7FFAFC4F7320
        public void MarkGeometryAsDirty(){} // RVA: 0x7FFAFC4F7330
        public void Rebuild(){} // RVA: 0x7FFAFC4F73D0
        public void LayoutComplete(){} // RVA: 0x7FFAF2D8D310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFAF2D8D310
        public void UpdateGeometry(){} // RVA: 0x7FFAFC4F73E0
        public void AssignPositioningIfNeeded(){} // RVA: 0x7FFAFC4F79C0
        public void OnFillVBO(){} // RVA: 0x7FFAFC4F84B0
        public void GenerateCaret(){} // RVA: 0x7FFAFC4F86C0
        public void CreateCursorVerts(){} // RVA: 0x7FFAFC4F9490
        public void GenerateHighlight(){} // RVA: 0x7FFAFC4F96A0
        public void Validate(){} // RVA: 0x7FFAFC4F9F40
        public void ActivateInputField(){} // RVA: 0x7FFAFC4FA5B0
        public void ActivateInputFieldInternal(){} // RVA: 0x7FFAFC4FA800
        public void OnSelect(){} // RVA: 0x7FFAFC4FB030
        public void OnPointerClick(){} // RVA: 0x7FFAFC4FB0E0
        public void DeactivateInputField(){} // RVA: 0x7FFAFC4FB110
        public void OnDeselect(){} // RVA: 0x7FFAFC4FB4C0
        public void OnSubmit(){} // RVA: 0x7FFAFC4FB4F0
        public void EnforceContentType(){} // RVA: 0x7FFAFC4FB540
        public void EnforceTextHOverflow(){} // RVA: 0x7FFAFC4FB6B0
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7FFAFC4FB810
        public void SetToCustom(){} // RVA: 0x7FFAFC4FB880
        public void DoStateTransition(){} // RVA: 0x7FFAFC4FB8A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFAF2D8D310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFAF2D8D310
        public void get_minWidth(){} // RVA: 0x7FFAF35AF380
        public void get_preferredWidth(){} // RVA: 0x7FFAFC4FB8D0
        public void get_flexibleWidth(){} // RVA: 0x7FFAF9866BF0
        public void get_minHeight(){} // RVA: 0x7FFAF35AF380
        public void get_preferredHeight(){} // RVA: 0x7FFAFC4FBB30
        public void get_flexibleHeight(){} // RVA: 0x7FFAF9866BF0
        public void get_layoutPriority(){} // RVA: 0x7FFAF2E7FAF0
        public void .cctor(){} // RVA: 0x7FFAFC4FBDD0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFAF3341B00
    }

    public class VRCVisualDamage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC4969E0
    }

}