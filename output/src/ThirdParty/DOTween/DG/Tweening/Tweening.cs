// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening
// Classes: 23
// Methods: 489

namespace ThirdParty.DOTween.DG.Tweening
{
    public class Color2 : ValueType
    {
        public UnityEngine.Color ca; // 0x10
        public UnityEngine.Color cb; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC497E290
        public void op_Addition(){} // RVA: 0x7FFAC497E2A0
        public void op_Subtraction(){} // RVA: 0x7FFAC497E3B0
        public void op_Multiply(){} // RVA: 0x7FFAC497E4C0
    }

    public class DOTween : Object
    {
        public string logBehaviour;
        public bool debugStoreTargetId; // 0x8
        public 0x6B26FD00 nestedTweenFailureBehaviour; // 0xC
        public bool showUnityEditorReport; // 0x10
        public float timeScale; // 0x14
        public bool useSmoothDeltaTime; // 0x18
        public float maxSmoothUnscaledTime; // 0x1C
        public 0x6B26FEB8 rewindCallbackMode; // 0x20
        public 0x6B26E390 _logBehaviour; // 0x24
        public System.Func`3<0x6B179630,object,bool> onWillLog; // 0x28
        public bool drawGizmos; // 0x30
        public bool debugMode; // 0x31
        public bool _fooDebugStoreTargetId; // 0x32
        public 0x6B26E4F0 defaultUpdateType; // 0x34
        public bool defaultTimeScaleIndependent; // 0x38
        public 0x6B26C0D8 defaultAutoPlay; // 0x3C
        public bool defaultAutoKill; // 0x40
        public 0x6B26C7B8 defaultLoopType; // 0x44
        public bool defaultRecyclable; // 0x48
        public 0x6B26C448 defaultEaseType; // 0x4C
        public float defaultEaseOvershootOrAmplitude; // 0x50
        public float defaultEasePeriod; // 0x54
        public DG.Tweening.Core.DOTweenComponent instance; // 0x58
        public int maxActiveTweenersReached; // 0x60
        public int maxActiveSequencesReached; // 0x64
        public DG.Tweening.Core.SafeModeReport safeModeReport; // 0x68
        public System.Collections.Generic.List`1<DG.Tweening.TweenCallback> GizmosDelegates; // 0x78
        public bool initialized; // 0x80
        public bool isQuitting; // 0x81

        // ── Methods ──
        public void get_logBehaviour(){} // RVA: 0x7FFAC497E750
        public void set_logBehaviour(){} // RVA: 0x7FFAC497E7B0
        public void get_debugStoreTargetId(){} // RVA: 0x7FFAC497E870
        public void set_debugStoreTargetId(){} // RVA: 0x7FFAC497E910
        public void Init(){} // RVA: 0x7FFAC497ED10 | overloaded x2
        public void AutoInit(){} // RVA: 0x7FFAC497EB80
        public void SetTweensCapacity(){} // RVA: 0x7FFAC497F560
        public void Clear(){} // RVA: 0x7FFAC497F620 | overloaded x2
        public void ClearCachedTweens(){} // RVA: 0x7FFAC497F820
        public void Validate(){} // RVA: 0x7FFAC497F870
        public void ManualUpdate(){} // RVA: 0x7FFAC497F8C0
        public void To(){} // RVA: 0x7FFAC4982030 | overloaded x17
        public void ToAxis(){} // RVA: 0x7FFAC4980C90
        public void ToAlpha(){} // RVA: 0x7FFAC4980D50
        public void Punch(){} // RVA: 0x7FFAC4980FD0
        public void Shake(){} // RVA: 0x7FFAC4981530 | overloaded x3
        public void ToArray(){} // RVA: 0x7FFAC4981D10
        public void Sequence(){} // RVA: 0x7FFAC49821B0
        public void CompleteAll(){} // RVA: 0x7FFAC4982350
        public void Complete(){} // RVA: 0x7FFAC49823D0
        public void CompleteAndReturnKilledTot(){} // RVA: 0x7FFAC49824E0 | overloaded x2
        public void CompleteAndReturnKilledTotExceptFor(){} // RVA: 0x7FFAC4982560
        public void FlipAll(){} // RVA: 0x7FFAC49825E0
        public void Flip(){} // RVA: 0x7FFAC4982650
        public void GotoAll(){} // RVA: 0x7FFAC49826E0
        public void Goto(){} // RVA: 0x7FFAC4982760
        public void KillAll(){} // RVA: 0x7FFAC49828A0 | overloaded x2
        public void Kill(){} // RVA: 0x7FFAC4982A20
        public void PauseAll(){} // RVA: 0x7FFAC4982B60
        public void Pause(){} // RVA: 0x7FFAC4982BD0
        public void PlayAll(){} // RVA: 0x7FFAC4982C60
        public void Play(){} // RVA: 0x7FFAC4982D60 | overloaded x2
        public void PlayBackwardsAll(){} // RVA: 0x7FFAC4982E00
        public void PlayBackwards(){} // RVA: 0x7FFAC4982F00 | overloaded x2
        public void PlayForwardAll(){} // RVA: 0x7FFAC4982FA0
        public void PlayForward(){} // RVA: 0x7FFAC49830A0 | overloaded x2
        public void RestartAll(){} // RVA: 0x7FFAC4983140
        public void Restart(){} // RVA: 0x7FFAC4983270 | overloaded x2
        public void RewindAll(){} // RVA: 0x7FFAC4983320
        public void Rewind(){} // RVA: 0x7FFAC49833A0
        public void SmoothRewindAll(){} // RVA: 0x7FFAC4983440
        public void SmoothRewind(){} // RVA: 0x7FFAC49834B0
        public void TogglePauseAll(){} // RVA: 0x7FFAC4983540
        public void TogglePause(){} // RVA: 0x7FFAC49835B0
        public void IsTweening(){} // RVA: 0x7FFAC4983640
        public void TotalPlayingTweens(){} // RVA: 0x7FFAC49836D0
        public void PlayingTweens(){} // RVA: 0x7FFAC4983840
        public void PausedTweens(){} // RVA: 0x7FFAC49838D0
        public void TweensById(){} // RVA: 0x7FFAC4983960
        public void TweensByTarget(){} // RVA: 0x7FFAC4983A20
        public void InitCheck(){} // RVA: 0x7FFAC4983AD0
        public void ApplyTo(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC4983D60
    }

    public class DOTweenCYInstruction : Object
    {
    }

    public class DOTweenModuleAudio : Object
    {
        // ── Methods ──
        public void DOFade(){} // RVA: 0x7FFAC499FB80
        public void DOPitch(){} // RVA: 0x7FFAC499FD50
        public void DOSetFloat(){} // RVA: 0x7FFAC499FF10
        public void DOComplete(){} // RVA: 0x7FFAC49A0130
        public void DOKill(){} // RVA: 0x7FFAC49A0200
        public void DOFlip(){} // RVA: 0x7FFAC49A0260
        public void DOGoto(){} // RVA: 0x7FFAC49A0320
        public void DOPause(){} // RVA: 0x7FFAC49A0400
        public void DOPlay(){} // RVA: 0x7FFAC49A04C0
        public void DOPlayBackwards(){} // RVA: 0x7FFAC49A0580
        public void DOPlayForward(){} // RVA: 0x7FFAC49A0640
        public void DORestart(){} // RVA: 0x7FFAC49A0700
        public void DORewind(){} // RVA: 0x7FFAC49A07C0
        public void DOSmoothRewind(){} // RVA: 0x7FFAC49A0880
        public void DOTogglePause(){} // RVA: 0x7FFAC49A0940
    }

    public class DOTweenModulePhysics : Object
    {
        // ── Methods ──
        public void DOMove(){} // RVA: 0x7FFAC49A0C50
        public void DOMoveX(){} // RVA: 0x7FFAC49A0E80
        public void DOMoveY(){} // RVA: 0x7FFAC49A10E0
        public void DOMoveZ(){} // RVA: 0x7FFAC49A1340
        public void DORotate(){} // RVA: 0x7FFAC49A15A0
        public void DOLookAt(){} // RVA: 0x7FFAC49A1790
        public void DOJump(){} // RVA: 0x7FFAC49A1A20
        public void DOPath(){} // RVA: 0x7FFAC49A2AC0 | overloaded x2
        public void DOLocalPath(){} // RVA: 0x7FFAC49A2CE0 | overloaded x2
    }

    public class DOTweenModulePhysics2D : Object
    {
        // ── Methods ──
        public void DOMove(){} // RVA: 0x7FFAC49A37C0
        public void DOMoveX(){} // RVA: 0x7FFAC49A39A0
        public void DOMoveY(){} // RVA: 0x7FFAC49A3BB0
        public void DORotate(){} // RVA: 0x7FFAC49A3DA0
        public void DOJump(){} // RVA: 0x7FFAC49A3F70
        public void DOPath(){} // RVA: 0x7FFAC49A47A0
        public void DOLocalPath(){} // RVA: 0x7FFAC49A4AF0
    }

    public class DOTweenModuleSprite : Object
    {
        // ── Methods ──
        public void DOColor(){} // RVA: 0x7FFAC49A55A0
        public void DOFade(){} // RVA: 0x7FFAC49A57A0
        public void DOGradientColor(){} // RVA: 0x7FFAC49A5960
        public void DOBlendableColor(){} // RVA: 0x7FFAC49A5C50
    }

    public class DOTweenModuleUI : Object
    {
        // ── Methods ──
        public void DOFade(){} // RVA: 0x7FFAC49AB760 | overloaded x5
        public void DOColor(){} // RVA: 0x7FFAC49AB050 | overloaded x4
        public void DOFillAmount(){} // RVA: 0x7FFAC49A6BD0
        public void DOGradientColor(){} // RVA: 0x7FFAC49A6DD0
        public void DOFlexibleSize(){} // RVA: 0x7FFAC49A70A0
        public void DOMinSize(){} // RVA: 0x7FFAC49A72B0
        public void DOPreferredSize(){} // RVA: 0x7FFAC49A74C0
        public void DOScale(){} // RVA: 0x7FFAC49A7AF0
        public void DOAnchorPos(){} // RVA: 0x7FFAC49A7CE0
        public void DOAnchorPosX(){} // RVA: 0x7FFAC49A7EF0
        public void DOAnchorPosY(){} // RVA: 0x7FFAC49A8120
        public void DOAnchorPos3D(){} // RVA: 0x7FFAC49A8330
        public void DOAnchorPos3DX(){} // RVA: 0x7FFAC49A8580
        public void DOAnchorPos3DY(){} // RVA: 0x7FFAC49A8800
        public void DOAnchorPos3DZ(){} // RVA: 0x7FFAC49A8A80
        public void DOAnchorMax(){} // RVA: 0x7FFAC49A8D00
        public void DOAnchorMin(){} // RVA: 0x7FFAC49A8F10
        public void DOPivot(){} // RVA: 0x7FFAC49A9120
        public void DOPivotX(){} // RVA: 0x7FFAC49A9310
        public void DOPivotY(){} // RVA: 0x7FFAC49A9530
        public void DOSizeDelta(){} // RVA: 0x7FFAC49A9740
        public void DOPunchAnchorPos(){} // RVA: 0x7FFAC49A9950
        public void DOShakeAnchorPos(){} // RVA: 0x7FFAC49A9DD0 | overloaded x2
        public void DOJumpAnchorPos(){} // RVA: 0x7FFAC49AA040
        public void DONormalizedPos(){} // RVA: 0x7FFAC49AA850
        public void DOHorizontalNormalizedPos(){} // RVA: 0x7FFAC49AAA50
        public void DOVerticalNormalizedPos(){} // RVA: 0x7FFAC49AAC50
        public void DOValue(){} // RVA: 0x7FFAC49AAE50
        public void DOCounter(){} // RVA: 0x7FFAC49AB280
        public void DOText(){} // RVA: 0x7FFAC49AB950
        public void DOBlendableColor(){} // RVA: 0x7FFAC49AC3C0 | overloaded x3
    }

    public class DOTweenModuleUnityVersion : Object
    {
        // ── Methods ──
        public void DOGradientColor(){} // RVA: 0x7FFAC49ADE90 | overloaded x2
        public void WaitForCompletion(){} // RVA: 0x7FFAC49AE160
        public void WaitForRewind(){} // RVA: 0x7FFAC49AE270
        public void WaitForKill(){} // RVA: 0x7FFAC49AE380
        public void WaitForElapsedLoops(){} // RVA: 0x7FFAC49AE490
        public void WaitForPosition(){} // RVA: 0x7FFAC49AE5C0
        public void WaitForStart(){} // RVA: 0x7FFAC49AE6F0
        public void DOOffset(){} // RVA: 0x7FFAC49AE800
        public void DOTiling(){} // RVA: 0x7FFAC49AEA60
        public void AsyncWaitForCompletion(){} // RVA: 0x7FFAC49AECC0
        public void AsyncWaitForRewind(){} // RVA: 0x7FFAC49AEE70
        public void AsyncWaitForKill(){} // RVA: 0x7FFAC49AF020
        public void AsyncWaitForElapsedLoops(){} // RVA: 0x7FFAC49AF1D0
        public void AsyncWaitForPosition(){} // RVA: 0x7FFAC49AF390
        public void AsyncWaitForStart(){} // RVA: 0x7FFAC49AF550
    }

    public class DOTweenModuleUtils : Object
    {
        public bool _initialized;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC49B0A00
        public void Preserver(){} // RVA: 0x7FFAC49B0C70
    }

    public class DOVirtual : Object
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x7FFAC4984060
        public void EasedValue(){} // RVA: 0x7FFAC49844E0 | overloaded x4
        public void DelayedCall(){} // RVA: 0x7FFAC4984660
    }

    public class EaseFactory : Object
    {
        // ── Methods ──
        public void StopMotion(){} // RVA: 0x7FFAC49849E0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EaseFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC497E590
        public void Invoke(){} // RVA: 0x7FFAC497E660
        public void BeginInvoke(){} // RVA: 0x7FFAC497E680
        public void EndInvoke(){} // RVA: 0x7FFAC4034000
    }

    public class IDOTweenInit
    {
        // ── Methods ──
        public void SetCapacity(){}
    }

    public class Sequence : Tween
    {
        public System.Collections.Generic.List`1<DG.Tweening.Tween> sequencedTweens; // 0x120
        public System.Collections.Generic.List`1<DG.Tweening.Core.ABSSequentiable> _sequencedObjs; // 0x128
        public float lastTweenInsertTime; // 0x130

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4987BF0
        public void DoPrepend(){} // RVA: 0x7FFAC4987DA0
        public void DoInsert(){} // RVA: 0x7FFAC4987ED0
        public void DoAppendInterval(){} // RVA: 0x7FFAC49880B0
        public void DoPrependInterval(){} // RVA: 0x7FFAC49880F0
        public void DoInsertCallback(){} // RVA: 0x7FFAC49881E0
        public void UpdateDelay(){} // RVA: 0x7FFAC49882F0
        public void Reset(){} // RVA: 0x7FFAC4988320
        public void Validate(){} // RVA: 0x7FFAC49883E0
        public void Startup(){} // RVA: 0x7FFAC49884D0
        public void ApplyTween(){} // RVA: 0x7FFAC49884E0
        public void Setup(){} // RVA: 0x7FFAC4988500
        public void DoStartup(){} // RVA: 0x7FFAC4988640
        public void DoApplyTween(){} // RVA: 0x7FFAC4988900
        public void ApplyInternalCycle(){} // RVA: 0x7FFAC4988D20
        public void StableSortSequencedObjs(){} // RVA: 0x7FFAC4989580
        public void IsAnyCallbackSet(){} // RVA: 0x7FFAC49896D0
    }

    public class ShortcutExtensions : Object
    {
        // ── Methods ──
        public void DOAspect(){} // RVA: 0x7FFAC4989730
        public void DOColor(){} // RVA: 0x7FFAC498BE70 | overloaded x6
        public void DOFarClipPlane(){} // RVA: 0x7FFAC4989AF0
        public void DOFieldOfView(){} // RVA: 0x7FFAC4989CB0
        public void DONearClipPlane(){} // RVA: 0x7FFAC4989E70
        public void DOOrthoSize(){} // RVA: 0x7FFAC498A030
        public void DOPixelRect(){} // RVA: 0x7FFAC498A1F0
        public void DORect(){} // RVA: 0x7FFAC498A3B0
        public void DOShakePosition(){} // RVA: 0x7FFAC4990F50 | overloaded x4
        public void DOShakeRotation(){} // RVA: 0x7FFAC49914B0 | overloaded x4
        public void DOIntensity(){} // RVA: 0x7FFAC498B1F0
        public void DOShadowStrength(){} // RVA: 0x7FFAC498B3B0
        public void DOFade(){} // RVA: 0x7FFAC498C560 | overloaded x3
        public void DOFloat(){} // RVA: 0x7FFAC498CA40 | overloaded x2
        public void DOOffset(){} // RVA: 0x7FFAC498CE60 | overloaded x2
        public void DOTiling(){} // RVA: 0x7FFAC498D2A0 | overloaded x2
        public void DOVector(){} // RVA: 0x7FFAC498D7B0 | overloaded x2
        public void DOResize(){} // RVA: 0x7FFAC498DA20
        public void DOTime(){} // RVA: 0x7FFAC498DBF0
        public void DOMove(){} // RVA: 0x7FFAC498DDB0
        public void DOMoveX(){} // RVA: 0x7FFAC498DFD0
        public void DOMoveY(){} // RVA: 0x7FFAC498E230
        public void DOMoveZ(){} // RVA: 0x7FFAC498E490
        public void DOLocalMove(){} // RVA: 0x7FFAC498E6F0
        public void DOLocalMoveX(){} // RVA: 0x7FFAC498E910
        public void DOLocalMoveY(){} // RVA: 0x7FFAC498EB70
        public void DOLocalMoveZ(){} // RVA: 0x7FFAC498EDD0
        public void DORotate(){} // RVA: 0x7FFAC498F030
        public void DORotateQuaternion(){} // RVA: 0x7FFAC498F210
        public void DOLocalRotate(){} // RVA: 0x7FFAC498F3F0
        public void DOLocalRotateQuaternion(){} // RVA: 0x7FFAC498F5D0
        public void DOScale(){} // RVA: 0x7FFAC498F9C0 | overloaded x2
        public void DOScaleX(){} // RVA: 0x7FFAC498FBD0
        public void DOScaleY(){} // RVA: 0x7FFAC498FE10
        public void DOScaleZ(){} // RVA: 0x7FFAC4990050
        public void DOLookAt(){} // RVA: 0x7FFAC4990290
        public void DOPunchPosition(){} // RVA: 0x7FFAC4990510
        public void DOPunchScale(){} // RVA: 0x7FFAC49907A0
        public void DOPunchRotation(){} // RVA: 0x7FFAC4990A20
        public void DOShakeScale(){} // RVA: 0x7FFAC4991A70 | overloaded x2
        public void DOJump(){} // RVA: 0x7FFAC4991D10
        public void DOLocalJump(){} // RVA: 0x7FFAC49927A0
        public void DOPath(){} // RVA: 0x7FFAC49936D0 | overloaded x2
        public void DOLocalPath(){} // RVA: 0x7FFAC49938E0 | overloaded x2
        public void DOTimeScale(){} // RVA: 0x7FFAC4993AF0
        public void DOBlendableColor(){} // RVA: 0x7FFAC4994590 | overloaded x4
        public void DOBlendableMoveBy(){} // RVA: 0x7FFAC4994910
        public void DOBlendableLocalMoveBy(){} // RVA: 0x7FFAC4994B90
        public void DOBlendableRotateBy(){} // RVA: 0x7FFAC4994E10
        public void DOBlendableLocalRotateBy(){} // RVA: 0x7FFAC4995040
        public void DOBlendablePunchRotation(){} // RVA: 0x7FFAC4995270
        public void DOBlendableScaleBy(){} // RVA: 0x7FFAC4995540
        public void DOComplete(){} // RVA: 0x7FFAC4995880 | overloaded x2
        public void DOKill(){} // RVA: 0x7FFAC49959B0 | overloaded x2
        public void DOFlip(){} // RVA: 0x7FFAC4995AD0 | overloaded x2
        public void DOGoto(){} // RVA: 0x7FFAC4995C70 | overloaded x2
        public void DOPause(){} // RVA: 0x7FFAC4995E10 | overloaded x2
        public void DOPlay(){} // RVA: 0x7FFAC4995F90 | overloaded x2
        public void DOPlayBackwards(){} // RVA: 0x7FFAC4996110 | overloaded x2
        public void DOPlayForward(){} // RVA: 0x7FFAC4996290 | overloaded x2
        public void DORestart(){} // RVA: 0x7FFAC4996420 | overloaded x2
        public void DORewind(){} // RVA: 0x7FFAC49965C0 | overloaded x2
        public void DOSmoothRewind(){} // RVA: 0x7FFAC4996750 | overloaded x2
        public void DOTogglePause(){} // RVA: 0x7FFAC49968D0 | overloaded x2
    }

    public class Tween : ABSSequentiable
    {
        public float isRelative; // 0x28
        public bool active; // 0x2C
        public object fullPosition; // 0x30
        public string hasLoops; // 0x38
        public int playedOnce; // 0x40
        public object position; // 0x48
        public 0x6B26E4F0 updateType; // 0x50
        public bool isIndependentUpdate; // 0x54
        public DG.Tweening.TweenCallback onPlay; // 0x58
        public DG.Tweening.TweenCallback onPause; // 0x60
        public DG.Tweening.TweenCallback onRewind; // 0x68
        public DG.Tweening.TweenCallback onUpdate; // 0x70
        public DG.Tweening.TweenCallback onStepComplete; // 0x78
        public DG.Tweening.TweenCallback onComplete; // 0x80
        public DG.Tweening.TweenCallback onKill; // 0x88
        public DG.Tweening.TweenCallback`1<int> onWaypointChange; // 0x90
        public bool isFrom; // 0x98
        public bool isBlendable; // 0x99
        public bool isRecyclable; // 0x9A
        public bool isSpeedBased; // 0x9B
        public bool autoKill; // 0x9C
        public float duration; // 0xA0
        public int loops; // 0xA4
        public 0x6B26C7B8 loopType; // 0xA8
        public float delay; // 0xAC
        public bool <isRelative>k__BackingField; // 0xB0
        public 0x6B26C448 easeType; // 0xB4
        public DG.Tweening.EaseFunction customEase; // 0xB8
        public float easeOvershootOrAmplitude; // 0xC0
        public float easePeriod; // 0xC4
        public string debugTargetId; // 0xC8
        public System.Type typeofT1; // 0xD0
        public System.Type typeofT2; // 0xD8
        public System.Type typeofTPlugOptions; // 0xE0
        public bool <active>k__BackingField; // 0xE8
        public bool isSequenced; // 0xE9
        public DG.Tweening.Sequence sequenceParent; // 0xF0
        public int activeId; // 0xF8
        public 0x6B26FDB0 specialStartupMode; // 0xFC
        public bool creationLocked; // 0x100
        public bool startupDone; // 0x101
        public bool <playedOnce>k__BackingField; // 0x102
        public float <position>k__BackingField; // 0x104
        public float fullDuration; // 0x108
        public int completedLoops; // 0x10C
        public bool isPlaying; // 0x110
        public bool isComplete; // 0x111
        public float elapsedDelay; // 0x114
        public bool delayComplete; // 0x118
        public int miscInt; // 0x11C

        // ── Methods ──
        public void get_isRelative(){} // RVA: 0x7FFAC41E71E0
        public void set_isRelative(){} // RVA: 0x7FFAC41E6D30
        public void get_active(){} // RVA: 0x7FFAC3FD4640
        public void set_active(){} // RVA: 0x7FFAC499C5B0
        public void get_fullPosition(){} // RVA: 0x7FFAC499C5C0
        public void set_fullPosition(){} // RVA: 0x7FFAC499C680
        public void get_hasLoops(){} // RVA: 0x7FFAC499C690
        public void get_playedOnce(){} // RVA: 0x7FFAC45CA2B0
        public void set_playedOnce(){} // RVA: 0x7FFAC45C9FC0
        public void get_position(){} // RVA: 0x7FFAC499C6B0
        public void set_position(){} // RVA: 0x7FFAC499C6C0
        public void Reset(){} // RVA: 0x7FFAC499C6D0
        public void Validate(){} // RVA: 0x7FFAC2C59D00
        public void UpdateDelay(){} // RVA: 0x7FFAC37432E0
        public void Startup(){} // RVA: 0x7FFAC2C59D00
        public void ApplyTween(){}
        public void DoGoto(){} // RVA: 0x7FFAC499CC10
        public void OnTweenCallback(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC499D170
    }

    public class TweenCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F7F980
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
        public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class TweenCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
        public void BeginInvoke(){} // RVA: 0x7FFAC2E8DC40
        public void EndInvoke(){} // RVA: 0x7FFAC2C70A40
    }

    public class TweenExtensions : Object
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFAC4984D20 | overloaded x2
        public void Flip(){} // RVA: 0x7FFAC4984ED0
        public void ForceInit(){} // RVA: 0x7FFAC4985040
        public void Goto(){} // RVA: 0x7FFAC49851B0
        public void Kill(){} // RVA: 0x7FFAC4985390
        public void Pause(){} // RVA: 0x7FFAC2E8DC40
        public void Play(){} // RVA: 0x7FFAC2E8DC40
        public void PlayBackwards(){} // RVA: 0x7FFAC4985580
        public void PlayForward(){} // RVA: 0x7FFAC49856F0
        public void Restart(){} // RVA: 0x7FFAC4985860
        public void Rewind(){} // RVA: 0x7FFAC49859F0
        public void SmoothRewind(){} // RVA: 0x7FFAC4985B60
        public void TogglePause(){} // RVA: 0x7FFAC4985CD0
        public void GotoWaypoint(){} // RVA: 0x7FFAC4985E40
        public void WaitForCompletion(){} // RVA: 0x7FFAC49861D0
        public void WaitForRewind(){} // RVA: 0x7FFAC4986370
        public void WaitForKill(){} // RVA: 0x7FFAC4986510
        public void WaitForElapsedLoops(){} // RVA: 0x7FFAC49866B0
        public void WaitForPosition(){} // RVA: 0x7FFAC4986850
        public void WaitForStart(){} // RVA: 0x7FFAC4986A00
        public void CompletedLoops(){} // RVA: 0x7FFAC4986BA0
        public void Delay(){} // RVA: 0x7FFAC4986C40
        public void ElapsedDelay(){} // RVA: 0x7FFAC4986CE0
        public void Duration(){} // RVA: 0x7FFAC4986D80
        public void Elapsed(){} // RVA: 0x7FFAC4986E50
        public void ElapsedPercentage(){} // RVA: 0x7FFAC4986F20
        public void ElapsedDirectionalPercentage(){} // RVA: 0x7FFAC4987030
        public void IsActive(){} // RVA: 0x7FFAC4987130
        public void IsBackwards(){} // RVA: 0x7FFAC4987140
        public void IsComplete(){} // RVA: 0x7FFAC49871D0
        public void IsInitialized(){} // RVA: 0x7FFAC4987270
        public void IsPlaying(){} // RVA: 0x7FFAC4987310
        public void Loops(){} // RVA: 0x7FFAC49873B0
        public void PathGetPoint(){} // RVA: 0x7FFAC4987450
        public void PathGetDrawPoints(){} // RVA: 0x7FFAC49876F0
        public void PathLength(){} // RVA: 0x7FFAC4987A00
    }

    public class TweenParams : Object
    {
        public DG.Tweening.TweenParams Params;
        public object id; // 0x10
        public object target; // 0x18
        public 0x6B26E4F0 updateType; // 0x20
        public bool isIndependentUpdate; // 0x24
        public DG.Tweening.TweenCallback onStart; // 0x28
        public DG.Tweening.TweenCallback onPlay; // 0x30
        public DG.Tweening.TweenCallback onRewind; // 0x38
        public DG.Tweening.TweenCallback onUpdate; // 0x40
        public DG.Tweening.TweenCallback onStepComplete; // 0x48
        public DG.Tweening.TweenCallback onComplete; // 0x50
        public DG.Tweening.TweenCallback onKill; // 0x58
        public DG.Tweening.TweenCallback`1<int> onWaypointChange; // 0x60
        public bool isRecyclable; // 0x68
        public bool isSpeedBased; // 0x69
        public bool autoKill; // 0x6A
        public int loops; // 0x6C
        public 0x6B26C7B8 loopType; // 0x70
        public float delay; // 0x74
        public bool isRelative; // 0x78
        public 0x6B26C448 easeType; // 0x7C
        public DG.Tweening.EaseFunction customEase; // 0x80
        public float easeOvershootOrAmplitude; // 0x88
        public float easePeriod; // 0x8C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC499A6D0
        public void Clear(){} // RVA: 0x7FFAC499A6E0
        public void SetAutoKill(){} // RVA: 0x7FFAC499AB70
        public void SetId(){} // RVA: 0x7FFAC499AB80
        public void SetTarget(){} // RVA: 0x7FFAC46D4B40
        public void SetLoops(){} // RVA: 0x7FFAC499ABE0
        public void SetEase(){} // RVA: 0x7FFAC499AF40 | overloaded x3
        public void SetRecyclable(){} // RVA: 0x7FFAC499AFB0
        public void SetUpdate(){} // RVA: 0x7FFAC499B030 | overloaded x2
        public void OnStart(){} // RVA: 0x7FFAC499B040
        public void OnPlay(){} // RVA: 0x7FFAC499B0A0
        public void OnRewind(){} // RVA: 0x7FFAC499B100
        public void OnUpdate(){} // RVA: 0x7FFAC499B160
        public void OnStepComplete(){} // RVA: 0x7FFAC499B1C0
        public void OnComplete(){} // RVA: 0x7FFAC499B220
        public void OnKill(){} // RVA: 0x7FFAC499B280
        public void OnWaypointChange(){} // RVA: 0x7FFAC499B2E0
        public void SetDelay(){} // RVA: 0x7FFAC499B340
        public void SetRelative(){} // RVA: 0x7FFAC499B350
        public void SetSpeedBased(){} // RVA: 0x7FFAC499B360
        public void .cctor(){} // RVA: 0x7FFAC499B370
    }

    public class TweenSettingsExtensions : Object
    {
        // ── Methods ──
        public void SetAutoKill(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetId(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void SetLink(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetTarget(){} // RVA: 0x7FFAC2E8DC40
        public void SetLoops(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetEase(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void SetRecyclable(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetUpdate(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void OnStart(){} // RVA: 0x7FFAC2E8DC40
        public void OnPlay(){} // RVA: 0x7FFAC2E8DC40
        public void OnPause(){} // RVA: 0x7FFAC2E8DC40
        public void OnRewind(){} // RVA: 0x7FFAC2E8DC40
        public void OnUpdate(){} // RVA: 0x7FFAC2E8DC40
        public void OnStepComplete(){} // RVA: 0x7FFAC2E8DC40
        public void OnComplete(){} // RVA: 0x7FFAC2E8DC40
        public void OnKill(){} // RVA: 0x7FFAC2E8DC40
        public void OnWaypointChange(){} // RVA: 0x7FFAC2E8DC40
        public void SetAs(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Append(){} // RVA: 0x7FFAC499B420
        public void Prepend(){} // RVA: 0x7FFAC499B470
        public void Join(){} // RVA: 0x7FFAC499B5D0
        public void Insert(){} // RVA: 0x7FFAC499B620
        public void AppendInterval(){} // RVA: 0x7FFAC499B670
        public void PrependInterval(){} // RVA: 0x7FFAC499B6B0
        public void AppendCallback(){} // RVA: 0x7FFAC499B7C0
        public void PrependCallback(){} // RVA: 0x7FFAC499B800
        public void InsertCallback(){} // RVA: 0x7FFAC499B840
        public void From(){} // RVA: 0x7FFAC499B980 | overloaded x5
        public void SetDelay(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetRelative(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetSpeedBased(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetOptions(){} // RVA: 0x7FFAC499BCA0 | overloaded x15
        public void SetLookAt(){} // RVA: 0x7FFAC499C110 | overloaded x7
        public void SetPathForwardDirection(){} // RVA: 0x7FFAC499C1D0
    }

    public class Tweener : Tween
    {
        public bool hasManuallySetStartValue; // 0x120
        public bool isFromAllowed; // 0x121

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC499D1A0
        public void ChangeStartValue(){} // RVA: 0x7FFAC2C6CCB0
        public void ChangeEndValue(){} // RVA: 0x7FFAC2C696F0 | overloaded x2
        public void ChangeValues(){}
        public void SetFrom(){}
        public void Setup(){} // RVA: 0x7FFAC2E8DC40
        public void DoUpdateDelay(){} // RVA: 0x7FFAC2C6E620
        public void DoStartup(){} // RVA: 0x7FFAC2C59DE0
        public void DoChangeStartValue(){} // RVA: 0x7FFAC2E8DC40
        public void DoChangeEndValue(){} // RVA: 0x7FFAC2E8DC40
        public void DoChangeValues(){} // RVA: 0x7FFAC2E8DC40
        public void DOStartupSpecials(){} // RVA: 0x7FFAC2C59DE0
        public void DOStartupDurationBased(){} // RVA: 0x7FFAC2C70A10
    }

}