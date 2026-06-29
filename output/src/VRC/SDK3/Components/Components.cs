// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Components
// Classes: 34
// Methods: 466

namespace VRC.SDK3.Components
{
    public class AbstractUdonBehaviour : VRCInteractable
    {
        // ── Methods ──
        public void GetProgramVariableType(){} // RVA: 0x87C540
        public void GetProgramVariable(){} // RVA: 0x87C540
        public void TryGetProgramVariable(){} // RVA: 0x87D3C0
        public void SetProgramVariable(){} // RVA: 0x8943B0
        public void SendCustomEvent(){} // RVA: 0x894320
        public void SendCustomNetworkEvent(){} // RVA: 0x897D20
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x8A14B0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x89B9B0
        public void get_DisableInteractive(){} // RVA: 0x87D280
        public void set_DisableInteractive(){} // RVA: 0x894750
        public void get_DisableEventProcessing(){} // RVA: 0x87D280
        public void set_DisableEventProcessing(){} // RVA: 0x894750
        public void get_SyncMetadataTable(){} // RVA: 0x87C0A0
        public void InitializeUdonContent(){} // RVA: 0x894290
        public void RunProgram(){} // RVA: 0x894320
        public void RunInputEvent(){} // RVA: 0x8943B0
        public void get_IsNetworkingSupported(){} // RVA: 0x87D280
        public void set_IsNetworkingSupported(){} // RVA: 0x894750
        public void RequestSerialization(){} // RVA: 0x894290
        public void get_InteractionText(){} // RVA: 0x87C0A0
        public void set_InteractionText(){} // RVA: 0x894320
        public void get_SyncMethod(){} // RVA: 0x87C130
        public void set_SyncMethod(){} // RVA: 0x8944F0
        public void GetNetworkCallingMetadata(){} // RVA: 0x87C540
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x87E350
        public void TryGetEntrypointHashFromName(){} // RVA: 0x87D3C0
        public void GetComponentIndexFixed(){} // RVA: 0x87C130
        public void RunEvent(){} // RVA: 0x87D710
        public void RunEventAdvanced(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x1011E10
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.get_enabled(){} // RVA: 0xBA9AB0
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.set_enabled(){} // RVA: 0x1A7C2D0
    }

    public class AbstractUdonBehaviour[] : Array
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

    public class MultipleDisplayUtilities : Object
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0xA6E96E0
        public void GetMousePositionRelativeToMainDisplayResolution(){} // RVA: 0xA6E9840
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7A55700
        public void SetStruct(){} // RVA: 0xA94080
        public void SetClass(){} // RVA: 0xA94080
    }

    public class VRCAvatarPedestal : VRC_AvatarPedestal
    {
        // ── Methods ──
        public void SwitchAvatar(){} // RVA: 0xA6E79D0
        public void .ctor(){} // RVA: 0xA692A60
    }

    public class VRCCameraDollyAnimation : MonoBehaviour
    {
        public object RESOLUTION;
        public object ImportCameraDollyAnimation;
        public object IsRelativeToPlayer;
        public object IsSpeedBased;
        public object IsUsingLookAtMe;
        public object IsUsingGreenscreen;
        public object IsUsingMultiStream;
        public object PathType;
        public object LoopType;
        public object CaptureType;
        public object FocusMode;
        public object AnchorMode;
        public object Paths;

        // ── Methods ──
        public void Import(){} // RVA: 0xA6E6830
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCCameraDollyPath : MonoBehaviour
    {
        public object Points;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCCameraDollyPathPoint : MonoBehaviour
    {
        public object Zoom;
        public object Exposure;
        public object Duration;
        public object Speed;
        public object FocalDistance;
        public object Aperture;
        public object Hue;
        public object Saturation;
        public object Lightness;
        public object LookAtMeXOffset;
        public object LookAtMeYOffset;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6E6890
    }

    public class VRCCameraDollyPathPoint[] : Array
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

    public class VRCCameraDollyPath[] : Array
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

    public class VRCEnablePersistence : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0xA6E6650
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCInputFieldKeyboardOverride : MonoBehaviour
    {
        public object _overrideBehavior;

        // ── Methods ──
        public void get_OverrideBehavior(){} // RVA: 0xFEAE90
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCInteractable : VRC_Interactable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1011E10
    }

    public class VRCMirrorReflection : VRC_MirrorReflection
    {
        public object cameraClearFlags;
        public object customSkybox;
        public object customClearColor;

        // ── Methods ──
        public void UpdateCameraClearing(){} // RVA: 0xA6E8950
        public void .ctor(){} // RVA: 0xA6E8F50
    }

    public class VRCObjectPool : VRCNetworkBehaviour
    {
        public object Pool;
        public object OnInit;
        public object OnSpawn;
        public object OnReturn;
        public object _indices;
        public object _lastSpawnIndex;
        public object _spawnOrder;
        public object didInit;
        public object StartPositions;
        public object StartRotations;

        // ── Methods ──
        public void NetworkConfigure(){} // RVA: 0xA6E6910
        public void Shuffle(){} // RVA: 0xA6E7080
        public void TryToSpawn(){} // RVA: 0xA6E7090
        public void Return(){} // RVA: 0xA6E7410
        public void .ctor(){} // RVA: 0xA6E7820
    }

    public class VRCObjectSync : VRCNetworkBehaviour
    {
        public object AllowCollisionOwnershipTransfer;
        public object ForceKinematicOnRemote;
        public object _setKinematicHook;
        public object _setGravityHook;
        public object _flagDiscontinuityHook;
        public object TeleportHandler;
        public object RespawnHandler;
        public object OnAwake;
        public object didInit;

        // ── Methods ──
        public void get_SetKinematicHook(){} // RVA: 0xA6E7B40
        public void set_SetKinematicHook(){} // RVA: 0xA6E7BA0
        public void get_SetGravityHook(){} // RVA: 0xA6E7C50
        public void set_SetGravityHook(){} // RVA: 0xA6E7CB0
        public void get_FlagDiscontinuityHook(){} // RVA: 0xA6E7D70
        public void set_FlagDiscontinuityHook(){} // RVA: 0xA6E7DD0
        public void SetKinematic(){} // RVA: 0xA6E7E90
        public void EditorSetKinematic(){} // RVA: 0xA6E7F50
        public void SetGravity(){} // RVA: 0xA6E8060
        public void EditorSetGravity(){} // RVA: 0xA6E8120
        public void FlagDiscontinuity(){} // RVA: 0xA6E8230
        public void TeleportTo(){} // RVA: 0xA6E82E0
        public void Respawn(){} // RVA: 0xA6E84D0
        public void NetworkConfigure(){} // RVA: 0xA6E8550
        public void .ctor(){} // RVA: 0xB9C2F0
        public void .cctor(){} // RVA: 0xA6E85F0
    }

    public class VRCOpenMenu : Object
    {
        public object _OpenAvatarListingDelegate;

        // ── Methods ──
        public void OpenAvatarListing(){} // RVA: 0xA6E9E10
    }

    public class VRCPickup : VRC_Pickup
    {
        public object version;

        // ── Methods ──
        public void Reset(){} // RVA: 0xA6E88D0
        public void .ctor(){} // RVA: 0xA6948D0
    }

    public class VRCPlayerObject : VRCNetworkBehaviour
    {
        public object _GetPlayer;

        // ── Methods ──
        public void GetPlayer(){} // RVA: 0xA6E67D0
        public void NetworkConfigure(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCPlayerObject[] : Array
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

    public class VRCPortalMarker : VRC_PortalMarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCSceneDescriptor : VRC_SceneDescriptor
    {
        public object PlayerPersistence;
        public object NavigationAreas;

        // ── Methods ──
        public void Awake(){} // RVA: 0xA6E8FB0
        public void .ctor(){} // RVA: 0xA6E9250
    }

    public class VRCSpatialAudioSource : VRC_SpatialAudioSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA691450
    }

    public class VRCStation : VRCStation
    {
        public object OnRemotePlayerEnterStation;
        public object OnLocalPlayerEnterStation;
        public object OnRemotePlayerExitStation;
        public object OnLocalPlayerExitStation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA6E94D0
    }

    public class VRCTMPDropdownExtension : Object
    {
        // ── Methods ──
        public void AddOptions(){} // RVA: 0xA6E9D30
    }

    public class VRCTween : Object
    {
        public object _runner;

        // ── Methods ──
        public void get_Runner(){} // RVA: 0xA6F9050
        public void TweenPosition(){} // RVA: 0xA6F96A0
        public void TweenLocalPosition(){} // RVA: 0xA6F97F0
        public void TweenPath(){} // RVA: 0xA6F9D30
        public void TweenLocalPath(){} // RVA: 0xA6F9E90
        public void TweenRotation(){} // RVA: 0xA6F9940
        public void TweenLocalRotation(){} // RVA: 0xA6F9A90
        public void TweenScale(){} // RVA: 0xA6F9BE0
        public void KillAllTweens(){} // RVA: 0xA6FB4F0
        public void DelayedCall(){} // RVA: 0xA6FA0F0
        public void DelayedSetActive(){} // RVA: 0xA6FA150
        public void TweenFloat(){} // RVA: 0xA6FA9D0
        public void TweenColor(){} // RVA: 0xA6FAAC0
        public void TweenInt(){} // RVA: 0xA6FA300
        public void TweenVector3(){} // RVA: 0xA6FA390
        public void TweenVolume(){} // RVA: 0xA6FA450
        public void TweenPitch(){} // RVA: 0xA6FA4C0
        public void TweenFade(){} // RVA: 0xA6FA840
        public void TweenValue(){} // RVA: 0xA6FA680
        public void TweenAnchorPos(){} // RVA: 0xA6FA6F0
        public void TweenSizeDelta(){} // RVA: 0xA6FA760
        public void TweenIntensity(){} // RVA: 0xA6FAA50
        public void Play(){} // RVA: 0xA6FAB30
        public void Pause(){} // RVA: 0xA6FABF0
        public void Kill(){} // RVA: 0xA6FADB0
        public void Complete(){} // RVA: 0xA6FAE90
        public void Restart(){} // RVA: 0xA6FAF40
        public void Flip(){} // RVA: 0xA6FB010
        public void PlayBackwards(){} // RVA: 0xA6FB1A0
        public void PlayForwards(){} // RVA: 0xA6FB250
        public void Goto(){} // RVA: 0xA6FB3E0
        public void KillAll(){} // RVA: 0x87325E0
        public void OnComplete(){} // RVA: 0xA6FB520
        public void OnRewind(){} // RVA: 0xA6FB690
        public void SetLoops(){} // RVA: 0xA6FB6F0
        public void SetDelay(){} // RVA: 0xA6FB820
        public void SetUpdate(){} // RVA: 0xA6FB910
        public void SetFrom(){} // RVA: 0xA6FB9E0
        public void SetSpeedBased(){} // RVA: 0xA6FBB10
        public void SetEase(){} // RVA: 0xA6FBCA0
        public void SetDuration(){} // RVA: 0xA6FBDF0
        public void ChangeEndValue(){} // RVA: 0xA6FBF50
        public void IsPlaying(){} // RVA: 0xA6FBFB0
        public void IsActive(){} // RVA: 0xA6FC060
        public void GetElapsed(){} // RVA: 0xA6FC110
        public void GetDuration(){} // RVA: 0xA6FC1D0
        public void IsBackwards(){} // RVA: 0xA6FC290
    }

    public class VRCTweenHandle : ValueType
    {
        public object Id;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x29580
        public void get_IsValid(){} // RVA: 0x368020
        public void Equals(){} // RVA: 0xA771C0
        public void GetHashCode(){} // RVA: 0x77E60
        public void ToString(){} // RVA: 0xA77250
        public void op_Equality(){} // RVA: 0x2AFE580
        public void op_Inequality(){} // RVA: 0x782A060
        public void Play(){} // RVA: 0xA77260
        public void Pause(){} // RVA: 0xA77270
        public void Kill(){} // RVA: 0xA77280
        public void Complete(){} // RVA: 0xA77290
        public void Restart(){} // RVA: 0xA772A0
        public void Flip(){} // RVA: 0xA772B0
        public void PlayBackwards(){} // RVA: 0xA772C0
        public void PlayForwards(){} // RVA: 0xA772D0
        public void Goto(){} // RVA: 0xA772E0
        public void OnComplete(){} // RVA: 0xA772F0
        public void OnRewind(){} // RVA: 0xA77300
        public void SetLoops(){} // RVA: 0xA77370
        public void SetDelay(){} // RVA: 0xA77380
        public void SetUpdate(){} // RVA: 0xA77390
        public void From(){} // RVA: 0xA773A0
        public void SetSpeedBased(){} // RVA: 0xA773B0
        public void SetEase(){} // RVA: 0xA773D0
        public void SetDuration(){} // RVA: 0xA773E0
        public void ChangeEndValue(){} // RVA: 0xA774E0
        public void get_IsPlaying(){} // RVA: 0xA774F0
        public void get_IsActive(){} // RVA: 0xA77500
        public void get_Elapsed(){} // RVA: 0xA77510
        public void get_Duration(){} // RVA: 0xA77520
        public void get_IsBackwards(){} // RVA: 0xA77530
    }

    public class VRCTweenPostLateUpdater : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0xA707730
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class VRCTweenRunner : MonoBehaviour
    {
        public object SetDurationDirect;
        public object MaxPathResolution;
        public object _activeTweens;
        public object _nextTweenId;

        // ── Methods ──
        public void CreateDurationSetter(){} // RVA: 0xA6FC340
        public void Awake(){} // RVA: 0xA6FC6D0
        public void OnDestroy(){} // RVA: 0xA6FC9D0
        public void OnSceneUnloaded(){} // RVA: 0xA6FCCE0
        public void CreatePositionTween(){} // RVA: 0xA6FCD70
        public void CreateLocalPositionTween(){} // RVA: 0xA6FD120
        public void CreatePathTween(){} // RVA: 0xA6FD4D0
        public void CreateLocalPathTween(){} // RVA: 0xA6FD8E0
        public void CreateRotationTween(){} // RVA: 0xA6FDCF0
        public void CreateLocalRotationTween(){} // RVA: 0xA6FE0C0
        public void CreateScaleTween(){} // RVA: 0xA6FE490
        public void CreateDelayedCallTween(){} // RVA: 0xA6FE840
        public void CreateDelayedSetActiveTween(){} // RVA: 0xA6FEB60
        public void CreateFloatTween(){} // RVA: 0xA6FEF20
        public void CreateColorTween(){} // RVA: 0xA6FF230
        public void CreateIntTween(){} // RVA: 0xA6FF710
        public void CreateVector3Tween(){} // RVA: 0xA6FFBD0
        public void CreateAudioSourceVolumeTween(){} // RVA: 0xA6FFF20
        public void CreateAudioSourcePitchTween(){} // RVA: 0xA7002A0
        public void CreateCanvasGroupFadeTween(){} // RVA: 0xA7007A0
        public void CreateGraphicColorTween(){} // RVA: 0xA700B20
        public void CreateGraphicFadeTween(){} // RVA: 0xA700F30
        public void CreateSliderValueTween(){} // RVA: 0xA7012B0
        public void CreateAnchorPosTween(){} // RVA: 0xA701640
        public void CreateSizeDeltaTween(){} // RVA: 0xA701A00
        public void CreateSpriteRendererColorTween(){} // RVA: 0xA701DC0
        public void CreateSpriteRendererFadeTween(){} // RVA: 0xA7021D0
        public void CreateRendererColorTween(){} // RVA: 0xA7026D0
        public void CreateRendererFloatTween(){} // RVA: 0xA702D90
        public void CreateLightIntensityTween(){} // RVA: 0xA7032F0
        public void CreateLightColorTween(){} // RVA: 0xA703740
        public void PlayTween(){} // RVA: 0xA703CA0
        public void PauseTween(){} // RVA: 0xA703D50
        public void KillTween(){} // RVA: 0xA703F00
        public void CompleteTween(){} // RVA: 0xA703FC0
        public void RestartTween(){} // RVA: 0xA704060
        public void FlipTween(){} // RVA: 0xA704110
        public void PlayTweenBackwards(){} // RVA: 0xA704290
        public void PlayTweenForwards(){} // RVA: 0xA704330
        public void GotoTween(){} // RVA: 0xA7044B0
        public void SetTweenOnComplete(){} // RVA: 0xA7045B0
        public void SetTweenOnRewind(){} // RVA: 0xA704710
        public void SetTweenLoops(){} // RVA: 0xA7049E0
        public void SetTweenDelay(){} // RVA: 0xA704B00
        public void SetTweenUpdate(){} // RVA: 0xA704BD0
        public void SetTweenFrom(){} // RVA: 0xA704C90
        public void SetTweenSpeedBased(){} // RVA: 0xA704DA0
        public void SetTweenEase(){} // RVA: 0xA704F10
        public void SetTweenDuration(){} // RVA: 0xA705050
        public void ChangeTweenEndValue(){} // RVA: 0xA7051A0
        public void IsTweenPlaying(){} // RVA: 0xA7053D0
        public void IsTweenActive(){} // RVA: 0xA705470
        public void GetTweenElapsed(){} // RVA: 0xA705510
        public void GetTweenDuration(){} // RVA: 0xA7055C0
        public void IsTweenBackwards(){} // RVA: 0xA705670
        public void OnTweenComplete(){} // RVA: 0xA705700
        public void OnTweenRewind(){} // RVA: 0xA705830
        public void KillAllTweens(){} // RVA: 0xA7058E0
        public void KillAllTweensOnTarget(){} // RVA: 0xA705B60
        public void .ctor(){} // RVA: 0xA706260
        public void .cctor(){} // RVA: 0xA706360
    }

    public class VRCTweenSafety : Object
    {
        public object SafePrecisionBudgetMeters;
        public object TwoToMantissa;
        public object SafePositionLimit;

        // ── Methods ──
        public void IsSafeDuration(){} // RVA: 0xA707900
        public void IsSafeDelay(){} // RVA: 0xA707900
        public void IsFinite(){} // RVA: 0xA707950
        public void IsSafePosition(){} // RVA: 0xA707980
        public void AreSafePositions(){} // RVA: 0xA707AA0
    }

    public class VRCUiShape : VRC_UiShape
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBF9D60
    }

    public class VRCUrlInputField : Selectable
    {
        public object onSelected;
        public object m_Keyboard;
        public object kSeparators;
        public object s_AreDevicesEvaluated;
        public object s_IsQuestDevice;
        public object s_IsPicoDevice;
        public object m_TextComponent;
        public object m_Placeholder;
        public object m_ContentType;
        public object m_InputType;
        public object m_AsteriskChar;
        public object m_KeyboardType;
        public object m_LineType;
        public object m_HideMobileInput;
        public object m_CharacterValidation;
        public object m_CharacterLimit;
        public object m_OnEndEdit;
        public object m_OnValueChanged;
        public object m_OnValidateInput;
        public object m_CaretColor;
        public object m_CustomCaretColor;
        public object m_SelectionColor;
        public object m_Text;
        public object m_CaretBlinkRate;
        public object m_CaretWidth;
        public object m_ReadOnly;
        public object m_ShouldActivateOnSelect;
        public object m_CaretPosition;
        public object m_CaretSelectPosition;
        public object caretRectTrans;
        public object m_CursorVerts;
        public object m_InputTextCache;
        public object m_CachedInputRenderer;
        public object m_PreventFontCallback;
        public object m_Mesh;
        public object m_AllowInput;
        public object m_ShouldActivateNextUpdate;
        public object m_UpdateDrag;
        public object m_DragPositionOutOfBounds;
        public object kHScrollSpeed;
        public object kVScrollSpeed;
        public object m_CaretVisible;
        public object m_BlinkCoroutine;
        public object m_BlinkStartTime;
        public object m_DrawStart;
        public object m_DrawEnd;
        public object m_DragCoroutine;
        public object m_OriginalText;
        public object m_WasCanceled;
        public object m_HasDoneFocusTransition;
        public object m_WaitForSecondsRealtime;
        public object m_TouchKeyboardAllowsInPlaceEditing;
        public object kEmailSpecialCharacters;
        public object kOculusQuestDeviceModel;
        public object kPicoDeviceModel;
        public object AllowSendingOnEndEdit;
        public object m_ProcessingEvent;
        public object k_MaxTextLength;

        // ── Methods ──
        public void GetUrl(){} // RVA: 0xA6E9E70
        public void SetUrl(){} // RVA: 0xA6EA070
        public void add_onSelected(){} // RVA: 0xA6EA0A0
        public void remove_onSelected(){} // RVA: 0xA6EA1A0
        public void Awake(){} // RVA: 0xA6EA2A0
        public void get_input(){} // RVA: 0xA6EA760
        public void get_compositionString(){} // RVA: 0xA6EA950
        public void .ctor(){} // RVA: 0xA6EAA60
        public void get_mesh(){} // RVA: 0xA6EAE00
        public void get_cachedInputTextGenerator(){} // RVA: 0xA6EAF70
        public void set_shouldHideMobileInput(){} // RVA: 0xA6EB030
        public void get_shouldHideMobileInput(){} // RVA: 0xA6EB0D0
        public void set_shouldActivateOnSelect(){} // RVA: 0xA6EB170
        public void get_shouldActivateOnSelect(){} // RVA: 0xA6EB180
        public void get_text(){} // RVA: 0x165EBC0
        public void set_text(){} // RVA: 0xA6EB220
        public void SetText(){} // RVA: 0xA6EB230
        public void get_isFocused(){} // RVA: 0xA56E3E0
        public void get_caretBlinkRate(){} // RVA: 0xA6EB820
        public void set_caretBlinkRate(){} // RVA: 0xA6EB830
        public void get_caretWidth(){} // RVA: 0x6CEA7F0
        public void set_caretWidth(){} // RVA: 0xA6EB8F0
        public void get_textComponent(){} // RVA: 0xD9E3D0
        public void set_textComponent(){} // RVA: 0xA6EB950
        public void get_placeholder(){} // RVA: 0xDA0520
        public void set_placeholder(){} // RVA: 0xA6EBCE0
        public void get_caretColor(){} // RVA: 0xA6EBD40
        public void set_caretColor(){} // RVA: 0xA6EBDA0
        public void get_customCaretColor(){} // RVA: 0x1E55000
        public void set_customCaretColor(){} // RVA: 0xA6EBE10
        public void get_selectionColor(){} // RVA: 0xBAEA30
        public void set_selectionColor(){} // RVA: 0xA6EBE30
        public void get_onEndEdit(){} // RVA: 0xBAE8F0
        public void set_onEndEdit(){} // RVA: 0xA6EBEA0
        public void get_onValueChange(){} // RVA: 0xBAE960
        public void set_onValueChange(){} // RVA: 0xA6EBF00
        public void get_onValueChanged(){} // RVA: 0xBAE960
        public void set_onValueChanged(){} // RVA: 0xA6EBF00
        public void get_onValidateInput(){} // RVA: 0x12CDBF0
        public void set_onValidateInput(){} // RVA: 0xA6EBF60
        public void get_characterLimit(){} // RVA: 0x100D890
        public void set_characterLimit(){} // RVA: 0xA6EBFC0
        public void get_contentType(){} // RVA: 0x15D7C60
        public void set_contentType(){} // RVA: 0xA6EC0B0
        public void get_lineType(){} // RVA: 0x114AC30
        public void set_lineType(){} // RVA: 0xA6EC260
        public void get_inputType(){} // RVA: 0x6BB0770
        public void set_inputType(){} // RVA: 0xA6EC350
        public void get_touchScreenKeyboard(){} // RVA: 0x10B9D50
        public void get_keyboardType(){} // RVA: 0xA56E330
        public void set_keyboardType(){} // RVA: 0xA6EC3C0
        public void get_characterValidation(){} // RVA: 0x6BA2C40
        public void set_characterValidation(){} // RVA: 0xA6EC430
        public void get_readOnly(){} // RVA: 0x6F16A30
        public void set_readOnly(){} // RVA: 0x6F16A40
        public void get_multiLine(){} // RVA: 0xA6EC4A0
        public void get_asteriskChar(){} // RVA: 0xA6EC4C0
        public void set_asteriskChar(){} // RVA: 0xA6EC4D0
        public void get_wasCanceled(){} // RVA: 0xA6EC580
        public void ClampPos(){} // RVA: 0xA6EC590
        public void get_caretPositionInternal(){} // RVA: 0xA6EC5D0
        public void set_caretPositionInternal(){} // RVA: 0xA6EC600
        public void get_caretSelectPositionInternal(){} // RVA: 0xA6EC650
        public void set_caretSelectPositionInternal(){} // RVA: 0xA6EC680
        public void get_hasSelection(){} // RVA: 0xA6EC6D0
        public void get_caretPosition(){} // RVA: 0xA6EC650
        public void set_caretPosition(){} // RVA: 0xA6EC730
        public void get_selectionAnchorPosition(){} // RVA: 0xA6EC5D0
        public void set_selectionAnchorPosition(){} // RVA: 0xA6EC7F0
        public void get_selectionFocusPosition(){} // RVA: 0xA6EC650
        public void set_selectionFocusPosition(){} // RVA: 0xA6EC860
        public void OnEnable(){} // RVA: 0xA6EC8D0
        public void OnDisable(){} // RVA: 0xA6ECC80
        public void CaretBlink(){} // RVA: 0xA6ED120
        public void SetCaretVisible(){} // RVA: 0xA6ED1C0
        public void SetCaretActive(){} // RVA: 0xA6ED240
        public void UpdateCaretMaterial(){} // RVA: 0xA6ED330
        public void OnFocus(){} // RVA: 0xA6ED520
        public void SelectAll(){} // RVA: 0xA6ED530
        public void MoveTextEnd(){} // RVA: 0xA6ED5C0
        public void MoveTextStart(){} // RVA: 0xA6ED6E0
        public void get_clipboard(){} // RVA: 0xA6ED7D0
        public void set_clipboard(){} // RVA: 0xA6ED820
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0xA6ED870
        public void InPlaceEditing(){} // RVA: 0xA6ED970
        public void InPlaceEditingChanged(){} // RVA: 0xA6EDA10
        public void UpdateCaretFromKeyboard(){} // RVA: 0xA6EDAB0
        public void LateUpdate(){} // RVA: 0xA6EDC60
        public void ScreenToLocal(){} // RVA: 0xA6EE520
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0xA6EEC70
        public void GetCharacterIndexFromPosition(){} // RVA: 0xA6EEF90
        public void MayDrag(){} // RVA: 0xA6EF310
        public void OnBeginDrag(){} // RVA: 0xA6EF470
        public void OnDrag(){} // RVA: 0xA6EF4A0
        public void MouseDragOutsideRect(){} // RVA: 0xA6EF7D0
        public void OnEndDrag(){} // RVA: 0xA6EF8D0
        public void OnPointerDown(){} // RVA: 0xA6EF900
        public void KeyPressed(){} // RVA: 0xA6EFC00
        public void IsValidChar(){} // RVA: 0xA6F0390
        public void ProcessEvent(){} // RVA: 0xA6F03F0
        public void OnUpdateSelected(){} // RVA: 0xA6F0400
        public void GetSelectedString(){} // RVA: 0xA6F05E0
        public void FindtNextWordBegin(){} // RVA: 0xA6F06E0
        public void MoveRight(){} // RVA: 0xA6F07F0
        public void FindtPrevWordBegin(){} // RVA: 0xA6F0A90
        public void MoveLeft(){} // RVA: 0xA6F0B90
        public void DetermineCharacterLine(){} // RVA: 0xA6F0E20
        public void LineUpCharacterPosition(){} // RVA: 0xA6F0FF0
        public void LineDownCharacterPosition(){} // RVA: 0xA6F1290
        public void MoveDown(){} // RVA: 0xA6F15F0
        public void MoveUp(){} // RVA: 0xA6F1820
        public void Delete(){} // RVA: 0xA6F1A00
        public void ForwardSpace(){} // RVA: 0xA6F1CC0
        public void Backspace(){} // RVA: 0xA6F1E10
        public void Insert(){} // RVA: 0xA6F1F90
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0xA6F2170
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0xA6F21C0
        public void SendOnValueChanged(){} // RVA: 0xA6F21E0
        public void SendOnSubmit(){} // RVA: 0xA6F2260
        public void Append(){} // RVA: 0xA6F23D0
        public void UpdateLabel(){} // RVA: 0xA6F2560
        public void IsSelectionVisible(){} // RVA: 0xA6F2CA0
        public void GetLineStartPosition(){} // RVA: 0xA6F2D70
        public void GetLineEndPosition(){} // RVA: 0xA6F2EA0
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0xA6F3030
        public void ForceLabelUpdate(){} // RVA: 0xA6F3B10
        public void MarkGeometryAsDirty(){} // RVA: 0xA6F3B20
        public void Rebuild(){} // RVA: 0xA6F3BC0
        public void LayoutComplete(){} // RVA: 0xB43310
        public void GraphicUpdateComplete(){} // RVA: 0xB43310
        public void UpdateGeometry(){} // RVA: 0xA6F3BD0
        public void AssignPositioningIfNeeded(){} // RVA: 0xA6F41A0
        public void OnFillVBO(){} // RVA: 0xA6F4EA0
        public void GenerateCaret(){} // RVA: 0xA6F50B0
        public void CreateCursorVerts(){} // RVA: 0xA6F6070
        public void GenerateHighlight(){} // RVA: 0xA6F6270
        public void Validate(){} // RVA: 0xA6F6A80
        public void ActivateInputField(){} // RVA: 0xA6F70A0
        public void ActivateInputFieldInternal(){} // RVA: 0xA6F72F0
        public void OnSelect(){} // RVA: 0xA6F7A80
        public void OnPointerClick(){} // RVA: 0xA6F7B30
        public void DeactivateInputField(){} // RVA: 0xA6F7B60
        public void OnDeselect(){} // RVA: 0xA6F7ED0
        public void OnSubmit(){} // RVA: 0xA6F7F00
        public void EnforceContentType(){} // RVA: 0xA6F7F50
        public void EnforceTextHOverflow(){} // RVA: 0xA6F80C0
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0xA6F8220
        public void SetToCustom(){} // RVA: 0xA6F8290
        public void DoStateTransition(){} // RVA: 0xA6F82B0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0xB43310
        public void CalculateLayoutInputVertical(){} // RVA: 0xB43310
        public void get_minWidth(){} // RVA: 0x13CD2E0
        public void get_preferredWidth(){} // RVA: 0xA6F82E0
        public void get_flexibleWidth(){} // RVA: 0x7815340
        public void get_minHeight(){} // RVA: 0x13CD2E0
        public void get_preferredHeight(){} // RVA: 0xA6F8540
        public void get_flexibleHeight(){} // RVA: 0x7815340
        public void get_layoutPriority(){} // RVA: 0xC3CCE0
        public void .cctor(){} // RVA: 0xA6F8830
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x114DE50
    }

    public class VRCUrlInputField[] : Array
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

    public class VRCVisualDamage : VRC_VisualDamage
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA691130
    }

}