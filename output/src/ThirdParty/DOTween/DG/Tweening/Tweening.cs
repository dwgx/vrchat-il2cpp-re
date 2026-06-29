// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening
// Classes: 25
// Methods: 397

namespace ThirdParty.DOTween.DG.Tweening
{
    public class Color2 : ValueType
    {
        public object ca;
        public object cb;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x92320
        public void op_Addition(){} // RVA: 0x26E17D0
        public void op_Subtraction(){} // RVA: 0x26E18E0
        public void op_Multiply(){} // RVA: 0x26E19F0
    }

    public class DOTween : Object
    {
        public object Version;
        public object useSafeMode;
        public object nestedTweenFailureBehaviour;
        public object showUnityEditorReport;
        public object timeScale;
        public object useSmoothDeltaTime;
        public object maxSmoothUnscaledTime;
        public object rewindCallbackMode;
        public object _logBehaviour;
        public object onWillLog;
        public object drawGizmos;
        public object debugMode;
        public object _fooDebugStoreTargetId;
        public object defaultUpdateType;
        public object defaultTimeScaleIndependent;
        public object defaultAutoPlay;
        public object defaultAutoKill;
        public object defaultLoopType;
        public object defaultRecyclable;
        public object defaultEaseType;
        public object defaultEaseOvershootOrAmplitude;
        public object defaultEasePeriod;
        public object instance;
        public object maxActiveTweenersReached;
        public object maxActiveSequencesReached;
        public object safeModeReport;
        public object GizmosDelegates;
        public object initialized;
        public object isQuitting;

        // ── Methods ──
        public void get_logBehaviour(){} // RVA: 0x26E1C60
        public void set_logBehaviour(){} // RVA: 0x26E1CC0
        public void get_debugStoreTargetId(){} // RVA: 0x26E1D80
        public void set_debugStoreTargetId(){} // RVA: 0x26E1E20
        public void Init(){} // RVA: 0x26E2220
        public void AutoInit(){} // RVA: 0x26E2090
        public void SetTweensCapacity(){} // RVA: 0x26E2A60
        public void Clear(){} // RVA: 0x26E2B20
        public void ClearCachedTweens(){} // RVA: 0x26E2D20
        public void Validate(){} // RVA: 0x26E2D70
        public void ManualUpdate(){} // RVA: 0x26E2DC0
        public void To(){} // RVA: 0x26E5570
        public void ToAxis(){} // RVA: 0x26E4190
        public void ToAlpha(){} // RVA: 0x26E4250
        public void Punch(){} // RVA: 0x26E44D0
        public void Shake(){} // RVA: 0x26E4A50
        public void ToArray(){} // RVA: 0x26E5240
        public void Sequence(){} // RVA: 0x26E56F0
        public void CompleteAll(){} // RVA: 0x26E5890
        public void Complete(){} // RVA: 0x26E5910
        public void CompleteAndReturnKilledTot(){} // RVA: 0x26E5A20
        public void CompleteAndReturnKilledTotExceptFor(){} // RVA: 0x26E5AA0
        public void FlipAll(){} // RVA: 0x26E5B20
        public void Flip(){} // RVA: 0x26E5B90
        public void GotoAll(){} // RVA: 0x26E5C20
        public void Goto(){} // RVA: 0x26E5CA0
        public void KillAll(){} // RVA: 0x26E5DE0
        public void Kill(){} // RVA: 0x26E5F60
        public void PauseAll(){} // RVA: 0x26E60A0
        public void Pause(){} // RVA: 0x26E6110
        public void PlayAll(){} // RVA: 0x26E61A0
        public void Play(){} // RVA: 0x26E62A0
        public void PlayBackwardsAll(){} // RVA: 0x26E6340
        public void PlayBackwards(){} // RVA: 0x26E6440
        public void PlayForwardAll(){} // RVA: 0x26E64E0
        public void PlayForward(){} // RVA: 0x26E65E0
        public void RestartAll(){} // RVA: 0x26E6680
        public void Restart(){} // RVA: 0x26E67B0
        public void RewindAll(){} // RVA: 0x26E6860
        public void Rewind(){} // RVA: 0x26E68E0
        public void SmoothRewindAll(){} // RVA: 0x26E6980
        public void SmoothRewind(){} // RVA: 0x26E69F0
        public void TogglePauseAll(){} // RVA: 0x26E6A80
        public void TogglePause(){} // RVA: 0x26E6AF0
        public void IsTweening(){} // RVA: 0x26E6B80
        public void TotalPlayingTweens(){} // RVA: 0x26E6C10
        public void PlayingTweens(){} // RVA: 0x26E6D90
        public void PausedTweens(){} // RVA: 0x26E6E20
        public void TweensById(){} // RVA: 0x26E6EB0
        public void TweensByTarget(){} // RVA: 0x26E6F70
        public void InitCheck(){} // RVA: 0x26E7020
        public void ApplyTo(){} // RVA: 0x303C680
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x26E72B0
    }

    public class DOTweenModuleAudio : Object
    {
        // ── Methods ──
        public void DOFade(){} // RVA: 0x27037D0
        public void DOPitch(){} // RVA: 0x27039A0
        public void DOSetFloat(){} // RVA: 0x2703B60
        public void DOComplete(){} // RVA: 0x2703D80
        public void DOKill(){} // RVA: 0x2703E50
        public void DOFlip(){} // RVA: 0x2703EB0
        public void DOGoto(){} // RVA: 0x2703F70
        public void DOPause(){} // RVA: 0x2704050
        public void DOPlay(){} // RVA: 0x2704110
        public void DOPlayBackwards(){} // RVA: 0x27041D0
        public void DOPlayForward(){} // RVA: 0x2704290
        public void DORestart(){} // RVA: 0x2704350
        public void DORewind(){} // RVA: 0x2704410
        public void DOSmoothRewind(){} // RVA: 0x27044D0
        public void DOTogglePause(){} // RVA: 0x2704590
    }

    public class DOTweenModulePhysics : Object
    {
        // ── Methods ──
        public void DOMove(){} // RVA: 0x27047C0
        public void DOMoveX(){} // RVA: 0x27049F0
        public void DOMoveY(){} // RVA: 0x2704C50
        public void DOMoveZ(){} // RVA: 0x2704EB0
        public void DORotate(){} // RVA: 0x2705110
        public void DOLookAt(){} // RVA: 0x2705300
        public void DOJump(){} // RVA: 0x2705590
        public void DOPath(){} // RVA: 0x2706600
        public void DOLocalPath(){} // RVA: 0x2706820
    }

    public class DOTweenModulePhysics2D : Object
    {
        // ── Methods ──
        public void DOMove(){} // RVA: 0x2707410
        public void DOMoveX(){} // RVA: 0x2707600
        public void DOMoveY(){} // RVA: 0x2707810
        public void DORotate(){} // RVA: 0x2707A10
        public void DOJump(){} // RVA: 0x2707BE0
        public void DOPath(){} // RVA: 0x2708410
        public void DOLocalPath(){} // RVA: 0x2708770
    }

    public class DOTweenModuleSprite : Object
    {
        // ── Methods ──
        public void DOColor(){} // RVA: 0x2709050
        public void DOFade(){} // RVA: 0x2709250
        public void DOGradientColor(){} // RVA: 0x2709410
        public void DOBlendableColor(){} // RVA: 0x2709720
    }

    public class DOTweenModuleUI : Object
    {
        // ── Methods ──
        public void DOFade(){} // RVA: 0x270F340
        public void DOColor(){} // RVA: 0x270EC50
        public void DOFillAmount(){} // RVA: 0x270A7E0
        public void DOGradientColor(){} // RVA: 0x270A9E0
        public void DOFlexibleSize(){} // RVA: 0x270AC90
        public void DOMinSize(){} // RVA: 0x270AEA0
        public void DOPreferredSize(){} // RVA: 0x270B0B0
        public void DOScale(){} // RVA: 0x270B6E0
        public void DOAnchorPos(){} // RVA: 0x270B8D0
        public void DOAnchorPosX(){} // RVA: 0x270BAE0
        public void DOAnchorPosY(){} // RVA: 0x270BD10
        public void DOAnchorPos3D(){} // RVA: 0x270BF20
        public void DOAnchorPos3DX(){} // RVA: 0x270C170
        public void DOAnchorPos3DY(){} // RVA: 0x270C3F0
        public void DOAnchorPos3DZ(){} // RVA: 0x270C670
        public void DOAnchorMax(){} // RVA: 0x270C8F0
        public void DOAnchorMin(){} // RVA: 0x270CB00
        public void DOPivot(){} // RVA: 0x270CD10
        public void DOPivotX(){} // RVA: 0x270CF00
        public void DOPivotY(){} // RVA: 0x270D120
        public void DOSizeDelta(){} // RVA: 0x270D330
        public void DOPunchAnchorPos(){} // RVA: 0x270D540
        public void DOShakeAnchorPos(){} // RVA: 0x270D9D0
        public void DOJumpAnchorPos(){} // RVA: 0x270DC40
        public void DONormalizedPos(){} // RVA: 0x270E450
        public void DOHorizontalNormalizedPos(){} // RVA: 0x270E650
        public void DOVerticalNormalizedPos(){} // RVA: 0x270E850
        public void DOValue(){} // RVA: 0x270EA50
        public void DOCounter(){} // RVA: 0x270EE80
        public void DOText(){} // RVA: 0x270F530
        public void DOBlendableColor(){} // RVA: 0x270FFA0
    }

    public class DOTweenModuleUnityVersion : Object
    {
        // ── Methods ──
        public void DOGradientColor(){} // RVA: 0x2711780
        public void WaitForCompletion(){} // RVA: 0x2711A10
        public void WaitForRewind(){} // RVA: 0x2711B20
        public void WaitForKill(){} // RVA: 0x2711C30
        public void WaitForElapsedLoops(){} // RVA: 0x2711D40
        public void WaitForPosition(){} // RVA: 0x2711E70
        public void WaitForStart(){} // RVA: 0x2711FA0
        public void DOOffset(){} // RVA: 0x27120B0
        public void DOTiling(){} // RVA: 0x27122E0
        public void AsyncWaitForCompletion(){} // RVA: 0x2712510
        public void AsyncWaitForRewind(){} // RVA: 0x27126C0
        public void AsyncWaitForKill(){} // RVA: 0x2712870
        public void AsyncWaitForElapsedLoops(){} // RVA: 0x2712A20
        public void AsyncWaitForPosition(){} // RVA: 0x2712BE0
        public void AsyncWaitForStart(){} // RVA: 0x2712DA0
    }

    public class DOTweenModuleUtils : Object
    {
        public object _initialized;

        // ── Methods ──
        public void Init(){} // RVA: 0x27141F0
        public void Preserver(){} // RVA: 0x2714460
    }

    public class DOVirtual : Object
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x26E75B0
        public void EasedValue(){} // RVA: 0x26E7A30
        public void DelayedCall(){} // RVA: 0x26E7BB0
    }

    public class EaseFactory : Object
    {
        // ── Methods ──
        public void StopMotion(){} // RVA: 0x26E7F30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EaseFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26E1AC0
        public void Invoke(){} // RVA: 0x26E1B90
        public void BeginInvoke(){} // RVA: 0x26E1BB0
        public void EndInvoke(){} // RVA: 0x25B7E60
    }

    public class IDOTweenInit
    {
        // ── Methods ──
        public void SetCapacity(){} // RVA: 0x88C530
    }

    public class Sequence : Tween
    {
        public object sequencedTweens;
        public object _sequencedObjs;
        public object lastTweenInsertTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26EAFC0
        public void DoPrepend(){} // RVA: 0x26EB170
        public void DoInsert(){} // RVA: 0x26EB2B0
        public void DoAppendInterval(){} // RVA: 0x26EB490
        public void DoPrependInterval(){} // RVA: 0x26EB4D0
        public void DoInsertCallback(){} // RVA: 0x26EB5E0
        public void UpdateDelay(){} // RVA: 0x26EB6F0
        public void Reset(){} // RVA: 0x26EB720
        public void Validate(){} // RVA: 0x26EB7E0
        public void Startup(){} // RVA: 0x26EB8E0
        public void ApplyTween(){} // RVA: 0x26EB8F0
        public void Setup(){} // RVA: 0x26EB910
        public void DoStartup(){} // RVA: 0x26EBA50
        public void DoApplyTween(){} // RVA: 0x26EBD40
        public void ApplyInternalCycle(){} // RVA: 0x26EC170
        public void StableSortSequencedObjs(){} // RVA: 0x26EC9B0
        public void IsAnyCallbackSet(){} // RVA: 0x26ECB20
    }

    public class ShortcutExtensions : Object
    {
        // ── Methods ──
        public void DOAspect(){} // RVA: 0x26ECB80
        public void DOColor(){} // RVA: 0x26EF2D0
        public void DOFarClipPlane(){} // RVA: 0x26ECF40
        public void DOFieldOfView(){} // RVA: 0x26ED100
        public void DONearClipPlane(){} // RVA: 0x26ED2C0
        public void DOOrthoSize(){} // RVA: 0x26ED480
        public void DOPixelRect(){} // RVA: 0x26ED640
        public void DORect(){} // RVA: 0x26ED800
        public void DOShakePosition(){} // RVA: 0x26F4380
        public void DOShakeRotation(){} // RVA: 0x26F48E0
        public void DOIntensity(){} // RVA: 0x26EE660
        public void DOShadowStrength(){} // RVA: 0x26EE820
        public void DOFade(){} // RVA: 0x26EF990
        public void DOFloat(){} // RVA: 0x26EFE50
        public void DOOffset(){} // RVA: 0x26F0240
        public void DOTiling(){} // RVA: 0x26F0690
        public void DOVector(){} // RVA: 0x26F0BB0
        public void DOResize(){} // RVA: 0x26F0DE0
        public void DOTime(){} // RVA: 0x26F0FB0
        public void DOMove(){} // RVA: 0x26F1170
        public void DOMoveX(){} // RVA: 0x26F13A0
        public void DOMoveY(){} // RVA: 0x26F1600
        public void DOMoveZ(){} // RVA: 0x26F1860
        public void DOLocalMove(){} // RVA: 0x26F1AC0
        public void DOLocalMoveX(){} // RVA: 0x26F1CF0
        public void DOLocalMoveY(){} // RVA: 0x26F1F50
        public void DOLocalMoveZ(){} // RVA: 0x26F21B0
        public void DORotate(){} // RVA: 0x26F2410
        public void DORotateQuaternion(){} // RVA: 0x26F2600
        public void DOLocalRotate(){} // RVA: 0x26F27F0
        public void DOLocalRotateQuaternion(){} // RVA: 0x26F29E0
        public void DOScale(){} // RVA: 0x26F2DE0
        public void DOScaleX(){} // RVA: 0x26F2FF0
        public void DOScaleY(){} // RVA: 0x26F3230
        public void DOScaleZ(){} // RVA: 0x26F3470
        public void DOLookAt(){} // RVA: 0x26F36B0
        public void DOPunchPosition(){} // RVA: 0x26F3940
        public void DOPunchScale(){} // RVA: 0x26F3BD0
        public void DOPunchRotation(){} // RVA: 0x26F3E50
        public void DOShakeScale(){} // RVA: 0x26F4EA0
        public void DOJump(){} // RVA: 0x26F5150
        public void DOLocalJump(){} // RVA: 0x26F5BE0
        public void DOPath(){} // RVA: 0x26F6B50
        public void DOLocalPath(){} // RVA: 0x26F6D60
        public void DOTimeScale(){} // RVA: 0x26F6F70
        public void DOBlendableColor(){} // RVA: 0x26F7AC0
        public void DOBlendableMoveBy(){} // RVA: 0x26F7DD0
        public void DOBlendableLocalMoveBy(){} // RVA: 0x26F8050
        public void DOBlendableRotateBy(){} // RVA: 0x26F82D0
        public void DOBlendableLocalRotateBy(){} // RVA: 0x26F8500
        public void DOBlendablePunchRotation(){} // RVA: 0x26F8730
        public void DOBlendableScaleBy(){} // RVA: 0x26F8A00
        public void DOComplete(){} // RVA: 0x26F8D40
        public void DOKill(){} // RVA: 0x26F8E70
        public void DOFlip(){} // RVA: 0x26F8F90
        public void DOGoto(){} // RVA: 0x26F9130
        public void DOPause(){} // RVA: 0x26F92D0
        public void DOPlay(){} // RVA: 0x26F9450
        public void DOPlayBackwards(){} // RVA: 0x26F95D0
        public void DOPlayForward(){} // RVA: 0x26F9750
        public void DORestart(){} // RVA: 0x26F98E0
        public void DORewind(){} // RVA: 0x26F9A80
        public void DOSmoothRewind(){} // RVA: 0x26F9C10
        public void DOTogglePause(){} // RVA: 0x26F9D90
    }

    public class Tween : ABSSequentiable
    {
        public object timeScale;
        public object isBackwards;
        public object id;
        public object stringId;
        public object intId;
        public object target;
        public object updateType;
        public object isIndependentUpdate;
        public object onPlay;
        public object onPause;
        public object onRewind;
        public object onUpdate;
        public object onStepComplete;
        public object onComplete;
        public object onKill;
        public object onWaypointChange;
        public object isFrom;
        public object isBlendable;
        public object isRecyclable;
        public object isSpeedBased;
        public object autoKill;
        public object duration;
        public object loops;
        public object loopType;
        public object delay;
        public object _isRelative;
        public object easeType;
        public object customEase;
        public object easeOvershootOrAmplitude;
        public object easePeriod;
        public object debugTargetId;
        public object typeofT1;
        public object typeofT2;
        public object typeofTPlugOptions;
        public object _active;
        public object isSequenced;
        public object sequenceParent;
        public object activeId;
        public object specialStartupMode;
        public object creationLocked;
        public object startupDone;
        public object _playedOnce;
        public object _position;
        public object fullDuration;
        public object completedLoops;
        public object isPlaying;
        public object isComplete;
        public object elapsedDelay;
        public object delayComplete;
        public object miscInt;

        // ── Methods ──
        public void get_isRelative(){} // RVA: 0x2009180
        public void set_isRelative(){} // RVA: 0x20097F0
        public void get_active(){} // RVA: 0x1DFD090
        public void set_active(){} // RVA: 0x216A2B0
        public void get_fullPosition(){} // RVA: 0x2700320
        public void set_fullPosition(){} // RVA: 0x27003E0
        public void get_hasLoops(){} // RVA: 0x27003F0
        public void get_playedOnce(){} // RVA: 0x2444580
        public void set_playedOnce(){} // RVA: 0x2444590
        public void get_position(){} // RVA: 0x255BED0
        public void set_position(){} // RVA: 0x2700410
        public void Reset(){} // RVA: 0x2700420
        public void Validate(){} // RVA: 0x87D280
        public void UpdateDelay(){} // RVA: 0x13CD2E0
        public void Startup(){} // RVA: 0x87D280
        public void ApplyTween(){} // RVA: 0x8815E0
        public void DoGoto(){} // RVA: 0x2700960
        public void OnTweenCallback(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x2700EC0
    }

    public class TweenCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA0FE0
        public void Invoke(){} // RVA: 0xBA10B0
        public void BeginInvoke(){} // RVA: 0xBA10C0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class TweenCallback[] : Array
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

    public class TweenCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
        public void BeginInvoke(){} // RVA: 0xA94080
        public void EndInvoke(){} // RVA: 0x894320
    }

    public class TweenCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC3B2D0
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0xC3B3A0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class TweenExtensions : Object
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x26E80D0
        public void Flip(){} // RVA: 0x26E8280
        public void ForceInit(){} // RVA: 0x26E83F0
        public void Goto(){} // RVA: 0x26E8560
        public void Kill(){} // RVA: 0x26E8740
        public void Pause(){} // RVA: 0xA94080
        public void Play(){} // RVA: 0x2A3DDF0
        public void PlayBackwards(){} // RVA: 0x26E8930
        public void PlayForward(){} // RVA: 0x26E8AA0
        public void Restart(){} // RVA: 0x26E8C10
        public void Rewind(){} // RVA: 0x26E8DA0
        public void SmoothRewind(){} // RVA: 0x26E8F10
        public void TogglePause(){} // RVA: 0x26E9080
        public void GotoWaypoint(){} // RVA: 0x26E91F0
        public void WaitForCompletion(){} // RVA: 0x26E9590
        public void WaitForRewind(){} // RVA: 0x26E9730
        public void WaitForKill(){} // RVA: 0x26E98D0
        public void WaitForElapsedLoops(){} // RVA: 0x26E9A70
        public void WaitForPosition(){} // RVA: 0x26E9C10
        public void WaitForStart(){} // RVA: 0x26E9DC0
        public void CompletedLoops(){} // RVA: 0x26E9F60
        public void Delay(){} // RVA: 0x26EA000
        public void ElapsedDelay(){} // RVA: 0x26EA0A0
        public void Duration(){} // RVA: 0x26EA140
        public void Elapsed(){} // RVA: 0x26EA210
        public void ElapsedPercentage(){} // RVA: 0x26EA2E0
        public void ElapsedDirectionalPercentage(){} // RVA: 0x26EA3F0
        public void IsActive(){} // RVA: 0x26EA4F0
        public void IsBackwards(){} // RVA: 0x26EA500
        public void IsComplete(){} // RVA: 0x26EA590
        public void IsInitialized(){} // RVA: 0x26EA630
        public void IsPlaying(){} // RVA: 0x26EA6D0
        public void Loops(){} // RVA: 0x26EA770
        public void PathGetPoint(){} // RVA: 0x26EA810
        public void PathGetDrawPoints(){} // RVA: 0x26EAAB0
        public void PathLength(){} // RVA: 0x26EADD0
    }

    public class TweenParams : Object
    {
        public object Params;
        public object id;
        public object target;
        public object updateType;
        public object isIndependentUpdate;
        public object onStart;
        public object onPlay;
        public object onRewind;
        public object onUpdate;
        public object onStepComplete;
        public object onComplete;
        public object onKill;
        public object onWaypointChange;
        public object isRecyclable;
        public object isSpeedBased;
        public object autoKill;
        public object loops;
        public object loopType;
        public object delay;
        public object isRelative;
        public object easeType;
        public object customEase;
        public object easeOvershootOrAmplitude;
        public object easePeriod;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26FE420
        public void Clear(){} // RVA: 0x26FE430
        public void SetAutoKill(){} // RVA: 0x26FE8C0
        public void SetId(){} // RVA: 0x26FE8D0
        public void SetTarget(){} // RVA: 0xD33F30
        public void SetLoops(){} // RVA: 0x26FE930
        public void SetEase(){} // RVA: 0x26FEC90
        public void SetRecyclable(){} // RVA: 0x26FED00
        public void SetUpdate(){} // RVA: 0x26FED80
        public void OnStart(){} // RVA: 0x26FED90
        public void OnPlay(){} // RVA: 0x26FEDF0
        public void OnRewind(){} // RVA: 0x26FEE50
        public void OnUpdate(){} // RVA: 0x26FEEB0
        public void OnStepComplete(){} // RVA: 0x26FEF10
        public void OnComplete(){} // RVA: 0x26FEF70
        public void OnKill(){} // RVA: 0x26FEFD0
        public void OnWaypointChange(){} // RVA: 0x26FF030
        public void SetDelay(){} // RVA: 0x26FF090
        public void SetRelative(){} // RVA: 0x26FF0A0
        public void SetSpeedBased(){} // RVA: 0x26FF0B0
        public void .cctor(){} // RVA: 0x26FF0C0
    }

    public class TweenSettingsExtensions : Object
    {
        // ── Methods ──
        public void SetAutoKill(){} // RVA: 0xA94080
        public void SetId(){} // RVA: 0xA94080
        public void SetLink(){} // RVA: 0xA94080
        public void SetTarget(){} // RVA: 0x2A416F0
        public void SetLoops(){} // RVA: 0x2A41560
        public void SetEase(){} // RVA: 0x2A40ED0
        public void SetRecyclable(){} // RVA: 0x2A415F0
        public void SetUpdate(){} // RVA: 0xA94080
        public void OnStart(){} // RVA: 0xA94080
        public void OnPlay(){} // RVA: 0xA94080
        public void OnPause(){} // RVA: 0xA94080
        public void OnRewind(){} // RVA: 0xA94080
        public void OnUpdate(){} // RVA: 0x2A40630
        public void OnStepComplete(){} // RVA: 0xA94080
        public void OnComplete(){} // RVA: 0x2A40320
        public void OnKill(){} // RVA: 0x2A40390
        public void OnWaypointChange(){} // RVA: 0xA94080
        public void SetAs(){} // RVA: 0xA94080
        public void Append(){} // RVA: 0x26FF170
        public void Prepend(){} // RVA: 0x26FF1C0
        public void Join(){} // RVA: 0x26FF340
        public void Insert(){} // RVA: 0x26FF390
        public void AppendInterval(){} // RVA: 0x26FF3E0
        public void PrependInterval(){} // RVA: 0x26FF420
        public void AppendCallback(){} // RVA: 0x26FF540
        public void PrependCallback(){} // RVA: 0x26FF580
        public void InsertCallback(){} // RVA: 0x26FF5C0
        public void From(){} // RVA: 0x26FF700
        public void SetDelay(){} // RVA: 0x2A40C50
        public void SetRelative(){} // RVA: 0x2A41610
        public void SetSpeedBased(){} // RVA: 0xA94080
        public void SetOptions(){} // RVA: 0x26FFA20
        public void SetLookAt(){} // RVA: 0x26FFE90
        public void SetPathForwardDirection(){} // RVA: 0x26FFF50
    }

    public class Tween[] : Array
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

    public class Tweener : Tween
    {
        public object hasManuallySetStartValue;
        public object isFromAllowed;

        // ── Methods ──
        public void Setup(){} // RVA: 0x2A518E0
        public void DOStartupSpecials(){} // RVA: 0x2A42780
        public void DOStartupDurationBased(){} // RVA: 0x2A41B90
        public void DoChangeStartValue(){} // RVA: 0x2A49E40
        public void DoChangeEndValue(){} // RVA: 0x2A47970
        public void DoChangeValues(){} // RVA: 0x2A4B670
        public void DoUpdateDelay(){} // RVA: 0x2A4F990
        public void DoStartup(){} // RVA: 0x2A4E500
        public void .ctor(){} // RVA: 0x2700EF0
        public void ChangeStartValue(){} // RVA: 0x890390
        public void ChangeEndValue(){} // RVA: 0x87D1A0
        public void ChangeValues(){} // RVA: 0x890210
        public void SetFrom(){} // RVA: 0x881D20
    }

}