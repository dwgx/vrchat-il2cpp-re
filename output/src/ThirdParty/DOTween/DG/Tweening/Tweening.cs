// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening
// Classes: 16
// Methods: 430

namespace ThirdParty.DOTween.DG.Tweening
{
    public class Color2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FD9E290
        public void op_Addition(){} // RVA: 0x7FFD4FD9E2A0
        public void op_Subtraction(){} // RVA: 0x7FFD4FD9E3B0
        public void op_Multiply(){} // RVA: 0x7FFD4FD9E4C0
    }

    public class DOTween : Object
    {
        public string logBehaviour;
        public bool debugStoreTargetId; // 0x8
        public rializeShort.? nestedTweenFailureBehaviour; // 0xC
        public bool showUnityEditorReport; // 0x10
        public float timeScale; // 0x14
        public bool useSmoothDeltaTime; // 0x18
        public float maxSmoothUnscaledTime; // 0x1C
        public rializeShort.rray rewindCallbackMode; // 0x20
        public bie _logBehaviour; // 0x24
        public nalInformation<?,object,bool> onWillLog; // 0x28
        public bool drawGizmos; // 0x30
        public bool debugMode; // 0x31
        public bool _fooDebugStoreTargetId; // 0x32
        public object defaultUpdateType; // 0x34
        public bool defaultTimeScaleIndependent; // 0x38
        public ntB defaultAutoPlay; // 0x3C
        public bool defaultAutoKill; // 0x40
        public veChains defaultLoopType; // 0x44
        public bool defaultRecyclable; // 0x48
        public usCount defaultEaseType; // 0x4C
        public float defaultEaseOvershootOrAmplitude; // 0x50
        public float defaultEasePeriod; // 0x54
        public nnectTimeout.h instance; // 0x58
        public int maxActiveTweenersReached; // 0x60
        public int maxActiveSequencesReached; // 0x64
        public nnectTimeout.ndowSize safeModeReport; // 0x68
        public URA.woDigitYearMax<ÎÌÎÏÏÏÎÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ> GizmosDelegates; // 0x78
        public bool initialized; // 0x80
        public bool isQuitting; // 0x81

        // ── Methods ──
        public void get_logBehaviour(){} // RVA: 0x7FFD4FD9E750
        public void set_logBehaviour(){} // RVA: 0x7FFD4FD9E7B0
        public void get_debugStoreTargetId(){} // RVA: 0x7FFD4FD9E870
        public void set_debugStoreTargetId(){} // RVA: 0x7FFD4FD9E910
        public void Init(){} // RVA: 0x7FFD4FD9ED10 | overloaded x2
        public void AutoInit(){} // RVA: 0x7FFD4FD9EB80
        public void SetTweensCapacity(){} // RVA: 0x7FFD4FD9F560
        public void Clear(){} // RVA: 0x7FFD4FD9F620 | overloaded x2
        public void ClearCachedTweens(){} // RVA: 0x7FFD4FD9F820
        public void Validate(){} // RVA: 0x7FFD4FD9F870
        public void ManualUpdate(){} // RVA: 0x7FFD4FD9F8C0
        public void To(){} // RVA: 0x7FFD4FDA2030 | overloaded x17
        public void ToAxis(){} // RVA: 0x7FFD4FDA0C90
        public void ToAlpha(){} // RVA: 0x7FFD4FDA0D50
        public void Punch(){} // RVA: 0x7FFD4FDA0FD0
        public void Shake(){} // RVA: 0x7FFD4FDA1530 | overloaded x3
        public void ToArray(){} // RVA: 0x7FFD4FDA1D10
        public void Sequence(){} // RVA: 0x7FFD4FDA21B0
        public void CompleteAll(){} // RVA: 0x7FFD4FDA2350
        public void Complete(){} // RVA: 0x7FFD4FDA23D0
        public void CompleteAndReturnKilledTot(){} // RVA: 0x7FFD4FDA24E0 | overloaded x2
        public void CompleteAndReturnKilledTotExceptFor(){} // RVA: 0x7FFD4FDA2560
        public void FlipAll(){} // RVA: 0x7FFD4FDA25E0
        public void Flip(){} // RVA: 0x7FFD4FDA2650
        public void GotoAll(){} // RVA: 0x7FFD4FDA26E0
        public void Goto(){} // RVA: 0x7FFD4FDA2760
        public void KillAll(){} // RVA: 0x7FFD4FDA28A0 | overloaded x2
        public void Kill(){} // RVA: 0x7FFD4FDA2A20
        public void PauseAll(){} // RVA: 0x7FFD4FDA2B60
        public void Pause(){} // RVA: 0x7FFD4FDA2BD0
        public void PlayAll(){} // RVA: 0x7FFD4FDA2C60
        public void Play(){} // RVA: 0x7FFD4FDA2D60 | overloaded x2
        public void PlayBackwardsAll(){} // RVA: 0x7FFD4FDA2E00
        public void PlayBackwards(){} // RVA: 0x7FFD4FDA2F00 | overloaded x2
        public void PlayForwardAll(){} // RVA: 0x7FFD4FDA2FA0
        public void PlayForward(){} // RVA: 0x7FFD4FDA30A0 | overloaded x2
        public void RestartAll(){} // RVA: 0x7FFD4FDA3140
        public void Restart(){} // RVA: 0x7FFD4FDA3270 | overloaded x2
        public void RewindAll(){} // RVA: 0x7FFD4FDA3320
        public void Rewind(){} // RVA: 0x7FFD4FDA33A0
        public void SmoothRewindAll(){} // RVA: 0x7FFD4FDA3440
        public void SmoothRewind(){} // RVA: 0x7FFD4FDA34B0
        public void TogglePauseAll(){} // RVA: 0x7FFD4FDA3540
        public void TogglePause(){} // RVA: 0x7FFD4FDA35B0
        public void IsTweening(){} // RVA: 0x7FFD4FDA3640
        public void TotalPlayingTweens(){} // RVA: 0x7FFD4FDA36D0
        public void PlayingTweens(){} // RVA: 0x7FFD4FDA3840
        public void PausedTweens(){} // RVA: 0x7FFD4FDA38D0
        public void TweensById(){} // RVA: 0x7FFD4FDA3960
        public void TweensByTarget(){} // RVA: 0x7FFD4FDA3A20
        public void InitCheck(){} // RVA: 0x7FFD4FDA3AD0
        public void ApplyTo(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD4FDA3D60
    }

    public class DOTweenModuleAudio : Object
    {
        // ── Methods ──
        public void DOFade(){} // RVA: 0x7FFD4FDBFB80
        public void DOPitch(){} // RVA: 0x7FFD4FDBFD50
        public void DOSetFloat(){} // RVA: 0x7FFD4FDBFF10
        public void DOComplete(){} // RVA: 0x7FFD4FDC0130
        public void DOKill(){} // RVA: 0x7FFD4FDC0200
        public void DOFlip(){} // RVA: 0x7FFD4FDC0260
        public void DOGoto(){} // RVA: 0x7FFD4FDC0320
        public void DOPause(){} // RVA: 0x7FFD4FDC0400
        public void DOPlay(){} // RVA: 0x7FFD4FDC04C0
        public void DOPlayBackwards(){} // RVA: 0x7FFD4FDC0580
        public void DOPlayForward(){} // RVA: 0x7FFD4FDC0640
        public void DORestart(){} // RVA: 0x7FFD4FDC0700
        public void DORewind(){} // RVA: 0x7FFD4FDC07C0
        public void DOSmoothRewind(){} // RVA: 0x7FFD4FDC0880
        public void DOTogglePause(){} // RVA: 0x7FFD4FDC0940
    }

    public class DOTweenModulePhysics : Object
    {
        // ── Methods ──
        public void DOMove(){} // RVA: 0x7FFD4FDC0C50
        public void DOMoveX(){} // RVA: 0x7FFD4FDC0E80
        public void DOMoveY(){} // RVA: 0x7FFD4FDC10E0
        public void DOMoveZ(){} // RVA: 0x7FFD4FDC1340
        public void DORotate(){} // RVA: 0x7FFD4FDC15A0
        public void DOLookAt(){} // RVA: 0x7FFD4FDC1790
        public void DOJump(){} // RVA: 0x7FFD4FDC1A20
        public void DOPath(){} // RVA: 0x7FFD4FDC2AC0 | overloaded x2
        public void DOLocalPath(){} // RVA: 0x7FFD4FDC2CE0 | overloaded x2
    }

    public class DOTweenModulePhysics2D : Object
    {
        // ── Methods ──
        public void DOMove(){} // RVA: 0x7FFD4FDC37C0
        public void DOMoveX(){} // RVA: 0x7FFD4FDC39A0
        public void DOMoveY(){} // RVA: 0x7FFD4FDC3BB0
        public void DORotate(){} // RVA: 0x7FFD4FDC3DA0
        public void DOJump(){} // RVA: 0x7FFD4FDC3F70
        public void DOPath(){} // RVA: 0x7FFD4FDC47A0
        public void DOLocalPath(){} // RVA: 0x7FFD4FDC4AF0
    }

    public class DOTweenModuleSprite : Object
    {
        // ── Methods ──
        public void DOColor(){} // RVA: 0x7FFD4FDC55A0
        public void DOFade(){} // RVA: 0x7FFD4FDC57A0
        public void DOGradientColor(){} // RVA: 0x7FFD4FDC5960
        public void DOBlendableColor(){} // RVA: 0x7FFD4FDC5C50
    }

    public class DOTweenModuleUI : Object
    {
        // ── Methods ──
        public void DOFade(){} // RVA: 0x7FFD4FDCB760 | overloaded x5
        public void DOColor(){} // RVA: 0x7FFD4FDCB050 | overloaded x4
        public void DOFillAmount(){} // RVA: 0x7FFD4FDC6BD0
        public void DOGradientColor(){} // RVA: 0x7FFD4FDC6DD0
        public void DOFlexibleSize(){} // RVA: 0x7FFD4FDC70A0
        public void DOMinSize(){} // RVA: 0x7FFD4FDC72B0
        public void DOPreferredSize(){} // RVA: 0x7FFD4FDC74C0
        public void DOScale(){} // RVA: 0x7FFD4FDC7AF0
        public void DOAnchorPos(){} // RVA: 0x7FFD4FDC7CE0
        public void DOAnchorPosX(){} // RVA: 0x7FFD4FDC7EF0
        public void DOAnchorPosY(){} // RVA: 0x7FFD4FDC8120
        public void DOAnchorPos3D(){} // RVA: 0x7FFD4FDC8330
        public void DOAnchorPos3DX(){} // RVA: 0x7FFD4FDC8580
        public void DOAnchorPos3DY(){} // RVA: 0x7FFD4FDC8800
        public void DOAnchorPos3DZ(){} // RVA: 0x7FFD4FDC8A80
        public void DOAnchorMax(){} // RVA: 0x7FFD4FDC8D00
        public void DOAnchorMin(){} // RVA: 0x7FFD4FDC8F10
        public void DOPivot(){} // RVA: 0x7FFD4FDC9120
        public void DOPivotX(){} // RVA: 0x7FFD4FDC9310
        public void DOPivotY(){} // RVA: 0x7FFD4FDC9530
        public void DOSizeDelta(){} // RVA: 0x7FFD4FDC9740
        public void DOPunchAnchorPos(){} // RVA: 0x7FFD4FDC9950
        public void DOShakeAnchorPos(){} // RVA: 0x7FFD4FDC9DD0 | overloaded x2
        public void DOJumpAnchorPos(){} // RVA: 0x7FFD4FDCA040
        public void DONormalizedPos(){} // RVA: 0x7FFD4FDCA850
        public void DOHorizontalNormalizedPos(){} // RVA: 0x7FFD4FDCAA50
        public void DOVerticalNormalizedPos(){} // RVA: 0x7FFD4FDCAC50
        public void DOValue(){} // RVA: 0x7FFD4FDCAE50
        public void DOCounter(){} // RVA: 0x7FFD4FDCB280
        public void DOText(){} // RVA: 0x7FFD4FDCB950
        public void DOBlendableColor(){} // RVA: 0x7FFD4FDCC3C0 | overloaded x3
    }

    public class DOTweenModuleUnityVersion : Object
    {
        // ── Methods ──
        public void DOGradientColor(){} // RVA: 0x7FFD4FDCDE90 | overloaded x2
        public void WaitForCompletion(){} // RVA: 0x7FFD4FDCE160
        public void WaitForRewind(){} // RVA: 0x7FFD4FDCE270
        public void WaitForKill(){} // RVA: 0x7FFD4FDCE380
        public void WaitForElapsedLoops(){} // RVA: 0x7FFD4FDCE490
        public void WaitForPosition(){} // RVA: 0x7FFD4FDCE5C0
        public void WaitForStart(){} // RVA: 0x7FFD4FDCE6F0
        public void DOOffset(){} // RVA: 0x7FFD4FDCE800
        public void DOTiling(){} // RVA: 0x7FFD4FDCEA60
        public void AsyncWaitForCompletion(){} // RVA: 0x7FFD4FDCECC0
        public void AsyncWaitForRewind(){} // RVA: 0x7FFD4FDCEE70
        public void AsyncWaitForKill(){} // RVA: 0x7FFD4FDCF020
        public void AsyncWaitForElapsedLoops(){} // RVA: 0x7FFD4FDCF1D0
        public void AsyncWaitForPosition(){} // RVA: 0x7FFD4FDCF390
        public void AsyncWaitForStart(){} // RVA: 0x7FFD4FDCF550
    }

    public class DOTweenModuleUtils : Object
    {
        public bool _initialized;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4FDD0A00
        public void Preserver(){} // RVA: 0x7FFD4FDD0C70
    }

    public class IDOTweenInit
    {
        // ── Methods ──
        public void SetCapacity(){}
    }

    public class ShortcutExtensions : Object
    {
        // ── Methods ──
        public void DOAspect(){} // RVA: 0x7FFD4FDA9730
        public void DOColor(){} // RVA: 0x7FFD4FDABE70 | overloaded x6
        public void DOFarClipPlane(){} // RVA: 0x7FFD4FDA9AF0
        public void DOFieldOfView(){} // RVA: 0x7FFD4FDA9CB0
        public void DONearClipPlane(){} // RVA: 0x7FFD4FDA9E70
        public void DOOrthoSize(){} // RVA: 0x7FFD4FDAA030
        public void DOPixelRect(){} // RVA: 0x7FFD4FDAA1F0
        public void DORect(){} // RVA: 0x7FFD4FDAA3B0
        public void DOShakePosition(){} // RVA: 0x7FFD4FDB0F50 | overloaded x4
        public void DOShakeRotation(){} // RVA: 0x7FFD4FDB14B0 | overloaded x4
        public void DOIntensity(){} // RVA: 0x7FFD4FDAB1F0
        public void DOShadowStrength(){} // RVA: 0x7FFD4FDAB3B0
        public void DOFade(){} // RVA: 0x7FFD4FDAC560 | overloaded x3
        public void DOFloat(){} // RVA: 0x7FFD4FDACA40 | overloaded x2
        public void DOOffset(){} // RVA: 0x7FFD4FDACE60 | overloaded x2
        public void DOTiling(){} // RVA: 0x7FFD4FDAD2A0 | overloaded x2
        public void DOVector(){} // RVA: 0x7FFD4FDAD7B0 | overloaded x2
        public void DOResize(){} // RVA: 0x7FFD4FDADA20
        public void DOTime(){} // RVA: 0x7FFD4FDADBF0
        public void DOMove(){} // RVA: 0x7FFD4FDADDB0
        public void DOMoveX(){} // RVA: 0x7FFD4FDADFD0
        public void DOMoveY(){} // RVA: 0x7FFD4FDAE230
        public void DOMoveZ(){} // RVA: 0x7FFD4FDAE490
        public void DOLocalMove(){} // RVA: 0x7FFD4FDAE6F0
        public void DOLocalMoveX(){} // RVA: 0x7FFD4FDAE910
        public void DOLocalMoveY(){} // RVA: 0x7FFD4FDAEB70
        public void DOLocalMoveZ(){} // RVA: 0x7FFD4FDAEDD0
        public void DORotate(){} // RVA: 0x7FFD4FDAF030
        public void DORotateQuaternion(){} // RVA: 0x7FFD4FDAF210
        public void DOLocalRotate(){} // RVA: 0x7FFD4FDAF3F0
        public void DOLocalRotateQuaternion(){} // RVA: 0x7FFD4FDAF5D0
        public void DOScale(){} // RVA: 0x7FFD4FDAF9C0 | overloaded x2
        public void DOScaleX(){} // RVA: 0x7FFD4FDAFBD0
        public void DOScaleY(){} // RVA: 0x7FFD4FDAFE10
        public void DOScaleZ(){} // RVA: 0x7FFD4FDB0050
        public void DOLookAt(){} // RVA: 0x7FFD4FDB0290
        public void DOPunchPosition(){} // RVA: 0x7FFD4FDB0510
        public void DOPunchScale(){} // RVA: 0x7FFD4FDB07A0
        public void DOPunchRotation(){} // RVA: 0x7FFD4FDB0A20
        public void DOShakeScale(){} // RVA: 0x7FFD4FDB1A70 | overloaded x2
        public void DOJump(){} // RVA: 0x7FFD4FDB1D10
        public void DOLocalJump(){} // RVA: 0x7FFD4FDB27A0
        public void DOPath(){} // RVA: 0x7FFD4FDB36D0 | overloaded x2
        public void DOLocalPath(){} // RVA: 0x7FFD4FDB38E0 | overloaded x2
        public void DOTimeScale(){} // RVA: 0x7FFD4FDB3AF0
        public void DOBlendableColor(){} // RVA: 0x7FFD4FDB4590 | overloaded x4
        public void DOBlendableMoveBy(){} // RVA: 0x7FFD4FDB4910
        public void DOBlendableLocalMoveBy(){} // RVA: 0x7FFD4FDB4B90
        public void DOBlendableRotateBy(){} // RVA: 0x7FFD4FDB4E10
        public void DOBlendableLocalRotateBy(){} // RVA: 0x7FFD4FDB5040
        public void DOBlendablePunchRotation(){} // RVA: 0x7FFD4FDB5270
        public void DOBlendableScaleBy(){} // RVA: 0x7FFD4FDB5540
        public void DOComplete(){} // RVA: 0x7FFD4FDB5880 | overloaded x2
        public void DOKill(){} // RVA: 0x7FFD4FDB59B0 | overloaded x2
        public void DOFlip(){} // RVA: 0x7FFD4FDB5AD0 | overloaded x2
        public void DOGoto(){} // RVA: 0x7FFD4FDB5C70 | overloaded x2
        public void DOPause(){} // RVA: 0x7FFD4FDB5E10 | overloaded x2
        public void DOPlay(){} // RVA: 0x7FFD4FDB5F90 | overloaded x2
        public void DOPlayBackwards(){} // RVA: 0x7FFD4FDB6110 | overloaded x2
        public void DOPlayForward(){} // RVA: 0x7FFD4FDB6290 | overloaded x2
        public void DORestart(){} // RVA: 0x7FFD4FDB6420 | overloaded x2
        public void DORewind(){} // RVA: 0x7FFD4FDB65C0 | overloaded x2
        public void DOSmoothRewind(){} // RVA: 0x7FFD4FDB6750 | overloaded x2
        public void DOTogglePause(){} // RVA: 0x7FFD4FDB68D0 | overloaded x2
    }

    public class Tween : ABSSequentiable
    {
        public float isRelative; // 0x28
        public bool active; // 0x2C
        public object fullPosition; // 0x30
        public string hasLoops; // 0x38
        public int playedOnce; // 0x40
        public object position; // 0x48
        public object updateType; // 0x50
        public bool isIndependentUpdate; // 0x54
        public ÎÌÎÏÏÏÎÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ onPlay; // 0x58
        public ÎÌÎÏÏÏÎÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ onPause; // 0x60
        public ÎÌÎÏÏÏÎÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ onRewind; // 0x68
        public ÎÌÎÏÏÏÎÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ onUpdate; // 0x70
        public ÎÌÎÏÏÏÎÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ onStepComplete; // 0x78
        public ÎÌÎÏÏÏÎÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ onComplete; // 0x80
        public ÎÌÎÏÏÏÎÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ onKill; // 0x88
        public ÍÌÍÎÎÎÎÎÍÏÍÎÍÏÍ<int> onWaypointChange; // 0x90
        public bool isFrom; // 0x98
        public bool isBlendable; // 0x99
        public bool isRecyclable; // 0x9A
        public bool isSpeedBased; // 0x9B
        public bool autoKill; // 0x9C
        public float duration; // 0xA0
        public int loops; // 0xA4
        public veChains loopType; // 0xA8
        public float delay; // 0xAC
        public bool <isRelative>k__BackingField; // 0xB0
        public usCount easeType; // 0xB4
        public ÍÏÍÎÍÏÍ customEase; // 0xB8
        public float easeOvershootOrAmplitude; // 0xC0
        public float easePeriod; // 0xC4
        public string debugTargetId; // 0xC8
        public object typeofT1; // 0xD0
        public object typeofT2; // 0xD8
        public object typeofTPlugOptions; // 0xE0
        public bool <active>k__BackingField; // 0xE8
        public bool isSequenced; // 0xE9
        public sa20Engine sequenceParent; // 0xF0
        public int activeId; // 0xF8
        public rializeShort.erType specialStartupMode; // 0xFC
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
        public void get_isRelative(){} // RVA: 0x7FFD4F6071E0
        public void set_isRelative(){} // RVA: 0x7FFD4F606D30
        public void get_active(){} // RVA: 0x7FFD4F3F4640
        public void set_active(){} // RVA: 0x7FFD4FDBC5B0
        public void get_fullPosition(){} // RVA: 0x7FFD4FDBC5C0
        public void set_fullPosition(){} // RVA: 0x7FFD4FDBC680
        public void get_hasLoops(){} // RVA: 0x7FFD4FDBC690
        public void get_playedOnce(){} // RVA: 0x7FFD4F9EA2B0
        public void set_playedOnce(){} // RVA: 0x7FFD4F9E9FC0
        public void get_position(){} // RVA: 0x7FFD4FDBC6B0
        public void set_position(){} // RVA: 0x7FFD4FDBC6C0
        public void Reset(){} // RVA: 0x7FFD4FDBC6D0
        public void Validate(){} // RVA: 0x7FFD4E079D00
        public void UpdateDelay(){} // RVA: 0x7FFD4EB632E0
        public void Startup(){} // RVA: 0x7FFD4E079D00
        public void ApplyTween(){}
        public void DoGoto(){} // RVA: 0x7FFD4FDBCC10
        public void OnTweenCallback(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4FDBD170
    }

    public class TweenCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
        public void EndInvoke(){} // RVA: 0x7FFD4E090A40
    }

    public class TweenExtensions : Object
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFD4FDA4D20 | overloaded x2
        public void Flip(){} // RVA: 0x7FFD4FDA4ED0
        public void ForceInit(){} // RVA: 0x7FFD4FDA5040
        public void Goto(){} // RVA: 0x7FFD4FDA51B0
        public void Kill(){} // RVA: 0x7FFD4FDA5390
        public void Pause(){} // RVA: 0x7FFD4E2ADC40
        public void Play(){} // RVA: 0x7FFD4E2ADC40
        public void PlayBackwards(){} // RVA: 0x7FFD4FDA5580
        public void PlayForward(){} // RVA: 0x7FFD4FDA56F0
        public void Restart(){} // RVA: 0x7FFD4FDA5860
        public void Rewind(){} // RVA: 0x7FFD4FDA59F0
        public void SmoothRewind(){} // RVA: 0x7FFD4FDA5B60
        public void TogglePause(){} // RVA: 0x7FFD4FDA5CD0
        public void GotoWaypoint(){} // RVA: 0x7FFD4FDA5E40
        public void WaitForCompletion(){} // RVA: 0x7FFD4FDA61D0
        public void WaitForRewind(){} // RVA: 0x7FFD4FDA6370
        public void WaitForKill(){} // RVA: 0x7FFD4FDA6510
        public void WaitForElapsedLoops(){} // RVA: 0x7FFD4FDA66B0
        public void WaitForPosition(){} // RVA: 0x7FFD4FDA6850
        public void WaitForStart(){} // RVA: 0x7FFD4FDA6A00
        public void CompletedLoops(){} // RVA: 0x7FFD4FDA6BA0
        public void Delay(){} // RVA: 0x7FFD4FDA6C40
        public void ElapsedDelay(){} // RVA: 0x7FFD4FDA6CE0
        public void Duration(){} // RVA: 0x7FFD4FDA6D80
        public void Elapsed(){} // RVA: 0x7FFD4FDA6E50
        public void ElapsedPercentage(){} // RVA: 0x7FFD4FDA6F20
        public void ElapsedDirectionalPercentage(){} // RVA: 0x7FFD4FDA7030
        public void IsActive(){} // RVA: 0x7FFD4FDA7130
        public void IsBackwards(){} // RVA: 0x7FFD4FDA7140
        public void IsComplete(){} // RVA: 0x7FFD4FDA71D0
        public void IsInitialized(){} // RVA: 0x7FFD4FDA7270
        public void IsPlaying(){} // RVA: 0x7FFD4FDA7310
        public void Loops(){} // RVA: 0x7FFD4FDA73B0
        public void PathGetPoint(){} // RVA: 0x7FFD4FDA7450
        public void PathGetDrawPoints(){} // RVA: 0x7FFD4FDA76F0
        public void PathLength(){} // RVA: 0x7FFD4FDA7A00
    }

    public class TweenSettingsExtensions : Object
    {
        // ── Methods ──
        public void SetAutoKill(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetId(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void SetLink(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetTarget(){} // RVA: 0x7FFD4E2ADC40
        public void SetLoops(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetEase(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void SetRecyclable(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetUpdate(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void OnStart(){} // RVA: 0x7FFD4E2ADC40
        public void OnPlay(){} // RVA: 0x7FFD4E2ADC40
        public void OnPause(){} // RVA: 0x7FFD4E2ADC40
        public void OnRewind(){} // RVA: 0x7FFD4E2ADC40
        public void OnUpdate(){} // RVA: 0x7FFD4E2ADC40
        public void OnStepComplete(){} // RVA: 0x7FFD4E2ADC40
        public void OnComplete(){} // RVA: 0x7FFD4E2ADC40
        public void OnKill(){} // RVA: 0x7FFD4E2ADC40
        public void OnWaypointChange(){} // RVA: 0x7FFD4E2ADC40
        public void SetAs(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Append(){} // RVA: 0x7FFD4FDBB420
        public void Prepend(){} // RVA: 0x7FFD4FDBB470
        public void Join(){} // RVA: 0x7FFD4FDBB5D0
        public void Insert(){} // RVA: 0x7FFD4FDBB620
        public void AppendInterval(){} // RVA: 0x7FFD4FDBB670
        public void PrependInterval(){} // RVA: 0x7FFD4FDBB6B0
        public void AppendCallback(){} // RVA: 0x7FFD4FDBB7C0
        public void PrependCallback(){} // RVA: 0x7FFD4FDBB800
        public void InsertCallback(){} // RVA: 0x7FFD4FDBB840
        public void From(){} // RVA: 0x7FFD4FDBB980 | overloaded x5
        public void SetDelay(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetRelative(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetSpeedBased(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetOptions(){} // RVA: 0x7FFD4FDBBCA0 | overloaded x15
        public void SetLookAt(){} // RVA: 0x7FFD4FDBC110 | overloaded x7
        public void SetPathForwardDirection(){} // RVA: 0x7FFD4FDBC1D0
    }

    public class Tweener : Tween
    {
        public bool hasManuallySetStartValue; // 0x120
        public bool isFromAllowed; // 0x121

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FDBD1A0
        public void ChangeStartValue(){} // RVA: 0x7FFD4E08CCB0
        public void ChangeEndValue(){} // RVA: 0x7FFD4E0896F0 | overloaded x2
        public void ChangeValues(){}
        public void SetFrom(){}
        public void Setup(){} // RVA: 0x7FFD4E2ADC40
        public void DoUpdateDelay(){} // RVA: 0x7FFD4E08E620
        public void DoStartup(){} // RVA: 0x7FFD4E079DE0
        public void DoChangeStartValue(){} // RVA: 0x7FFD4E2ADC40
        public void DoChangeEndValue(){} // RVA: 0x7FFD4E2ADC40
        public void DoChangeValues(){} // RVA: 0x7FFD4E2ADC40
        public void DOStartupSpecials(){} // RVA: 0x7FFD4E079DE0
        public void DOStartupDurationBased(){} // RVA: 0x7FFD4E090A10
    }

}