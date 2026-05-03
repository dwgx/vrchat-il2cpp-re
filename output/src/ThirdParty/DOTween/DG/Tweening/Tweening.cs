// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening
// Classes: 23
// Methods: 489

namespace ThirdParty.DOTween.DG.Tweening
{
    public class Color2 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BE9D90
        public void op_Addition(){} // RVA: 0x7FFE82BE9DA0
        public void op_Subtraction(){} // RVA: 0x7FFE82BE9EB0
        public void op_Multiply(){} // RVA: 0x7FFE82BE9FC0
    }

    public class DOTween : Object
    {
        public string Version;
        public bool useSafeMode; // 0x8

        // ── Methods ──
        public void get_logBehaviour(){} // RVA: 0x7FFE82BEA250
        public void set_logBehaviour(){} // RVA: 0x7FFE82BEA2B0
        public void get_debugStoreTargetId(){} // RVA: 0x7FFE82BEA370
        public void set_debugStoreTargetId(){} // RVA: 0x7FFE82BEA410
        public void Init(){} // RVA: 0x7FFE82BEA810 | overloaded x2
        public void AutoInit(){} // RVA: 0x7FFE82BEA680
        public void SetTweensCapacity(){} // RVA: 0x7FFE82BEB060
        public void Clear(){} // RVA: 0x7FFE82BEB120 | overloaded x2
        public void ClearCachedTweens(){} // RVA: 0x7FFE82BEB320
        public void Validate(){} // RVA: 0x7FFE82BEB370
        public void ManualUpdate(){} // RVA: 0x7FFE82BEB3C0
        public void To(){} // RVA: 0x7FFE82BEDB30 | overloaded x17
        public void ToAxis(){} // RVA: 0x7FFE82BEC790
        public void ToAlpha(){} // RVA: 0x7FFE82BEC850
        public void Punch(){} // RVA: 0x7FFE82BECAD0
        public void Shake(){} // RVA: 0x7FFE82BED030 | overloaded x3
        public void ToArray(){} // RVA: 0x7FFE82BED810
        public void Sequence(){} // RVA: 0x7FFE82BEDCB0
        public void CompleteAll(){} // RVA: 0x7FFE82BEDE50
        public void Complete(){} // RVA: 0x7FFE82BEDED0
        public void CompleteAndReturnKilledTot(){} // RVA: 0x7FFE82BEDFE0 | overloaded x2
        public void CompleteAndReturnKilledTotExceptFor(){} // RVA: 0x7FFE82BEE060
        public void FlipAll(){} // RVA: 0x7FFE82BEE0E0
        public void Flip(){} // RVA: 0x7FFE82BEE150
        public void GotoAll(){} // RVA: 0x7FFE82BEE1E0
        public void Goto(){} // RVA: 0x7FFE82BEE260
        public void KillAll(){} // RVA: 0x7FFE82BEE3A0 | overloaded x2
        public void Kill(){} // RVA: 0x7FFE82BEE520
        public void PauseAll(){} // RVA: 0x7FFE82BEE660
        public void Pause(){} // RVA: 0x7FFE82BEE6D0
        public void PlayAll(){} // RVA: 0x7FFE82BEE760
        public void Play(){} // RVA: 0x7FFE82BEE860 | overloaded x2
        public void PlayBackwardsAll(){} // RVA: 0x7FFE82BEE900
        public void PlayBackwards(){} // RVA: 0x7FFE82BEEA00 | overloaded x2
        public void PlayForwardAll(){} // RVA: 0x7FFE82BEEAA0
        public void PlayForward(){} // RVA: 0x7FFE82BEEBA0 | overloaded x2
        public void RestartAll(){} // RVA: 0x7FFE82BEEC40
        public void Restart(){} // RVA: 0x7FFE82BEED70 | overloaded x2
        public void RewindAll(){} // RVA: 0x7FFE82BEEE20
        public void Rewind(){} // RVA: 0x7FFE82BEEEA0
        public void SmoothRewindAll(){} // RVA: 0x7FFE82BEEF40
        public void SmoothRewind(){} // RVA: 0x7FFE82BEEFB0
        public void TogglePauseAll(){} // RVA: 0x7FFE82BEF040
        public void TogglePause(){} // RVA: 0x7FFE82BEF0B0
        public void IsTweening(){} // RVA: 0x7FFE82BEF140
        public void TotalPlayingTweens(){} // RVA: 0x7FFE82BEF1D0
        public void PlayingTweens(){} // RVA: 0x7FFE82BEF340
        public void PausedTweens(){} // RVA: 0x7FFE82BEF3D0
        public void TweensById(){} // RVA: 0x7FFE82BEF460
        public void TweensByTarget(){} // RVA: 0x7FFE82BEF520
        public void InitCheck(){} // RVA: 0x7FFE82BEF5D0
        public void ApplyTo(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE82BEF860
    }

    public class DOTweenCYInstruction : Object
    {
    }

    public class DOTweenModuleAudio : Object
    {
        // ── Methods ──
        public void DOFade(){} // RVA: 0x7FFE82C0B680
        public void DOPitch(){} // RVA: 0x7FFE82C0B850
        public void DOSetFloat(){} // RVA: 0x7FFE82C0BA10
        public void DOComplete(){} // RVA: 0x7FFE82C0BC30
        public void DOKill(){} // RVA: 0x7FFE82C0BD00
        public void DOFlip(){} // RVA: 0x7FFE82C0BD60
        public void DOGoto(){} // RVA: 0x7FFE82C0BE20
        public void DOPause(){} // RVA: 0x7FFE82C0BF00
        public void DOPlay(){} // RVA: 0x7FFE82C0BFC0
        public void DOPlayBackwards(){} // RVA: 0x7FFE82C0C080
        public void DOPlayForward(){} // RVA: 0x7FFE82C0C140
        public void DORestart(){} // RVA: 0x7FFE82C0C200
        public void DORewind(){} // RVA: 0x7FFE82C0C2C0
        public void DOSmoothRewind(){} // RVA: 0x7FFE82C0C380
        public void DOTogglePause(){} // RVA: 0x7FFE82C0C440
    }

    public class DOTweenModulePhysics : Object
    {
        // ── Methods ──
        public void DOMove(){} // RVA: 0x7FFE82C0C750
        public void DOMoveX(){} // RVA: 0x7FFE82C0C980
        public void DOMoveY(){} // RVA: 0x7FFE82C0CBE0
        public void DOMoveZ(){} // RVA: 0x7FFE82C0CE40
        public void DORotate(){} // RVA: 0x7FFE82C0D0A0
        public void DOLookAt(){} // RVA: 0x7FFE82C0D290
        public void DOJump(){} // RVA: 0x7FFE82C0D520
        public void DOPath(){} // RVA: 0x7FFE82C0E5C0 | overloaded x2
        public void DOLocalPath(){} // RVA: 0x7FFE82C0E7E0 | overloaded x2
    }

    public class DOTweenModulePhysics2D : Object
    {
        // ── Methods ──
        public void DOMove(){} // RVA: 0x7FFE82C0F2C0
        public void DOMoveX(){} // RVA: 0x7FFE82C0F4A0
        public void DOMoveY(){} // RVA: 0x7FFE82C0F6B0
        public void DORotate(){} // RVA: 0x7FFE82C0F8A0
        public void DOJump(){} // RVA: 0x7FFE82C0FA70
        public void DOPath(){} // RVA: 0x7FFE82C102A0
        public void DOLocalPath(){} // RVA: 0x7FFE82C105F0
    }

    public class DOTweenModuleSprite : Object
    {
        // ── Methods ──
        public void DOColor(){} // RVA: 0x7FFE82C110A0
        public void DOFade(){} // RVA: 0x7FFE82C112A0
        public void DOGradientColor(){} // RVA: 0x7FFE82C11460
        public void DOBlendableColor(){} // RVA: 0x7FFE82C11750
    }

    public class DOTweenModuleUI : Object
    {
        // ── Methods ──
        public void DOFade(){} // RVA: 0x7FFE82C17260 | overloaded x5
        public void DOColor(){} // RVA: 0x7FFE82C16B50 | overloaded x4
        public void DOFillAmount(){} // RVA: 0x7FFE82C126D0
        public void DOGradientColor(){} // RVA: 0x7FFE82C128D0
        public void DOFlexibleSize(){} // RVA: 0x7FFE82C12BA0
        public void DOMinSize(){} // RVA: 0x7FFE82C12DB0
        public void DOPreferredSize(){} // RVA: 0x7FFE82C12FC0
        public void DOScale(){} // RVA: 0x7FFE82C135F0
        public void DOAnchorPos(){} // RVA: 0x7FFE82C137E0
        public void DOAnchorPosX(){} // RVA: 0x7FFE82C139F0
        public void DOAnchorPosY(){} // RVA: 0x7FFE82C13C20
        public void DOAnchorPos3D(){} // RVA: 0x7FFE82C13E30
        public void DOAnchorPos3DX(){} // RVA: 0x7FFE82C14080
        public void DOAnchorPos3DY(){} // RVA: 0x7FFE82C14300
        public void DOAnchorPos3DZ(){} // RVA: 0x7FFE82C14580
        public void DOAnchorMax(){} // RVA: 0x7FFE82C14800
        public void DOAnchorMin(){} // RVA: 0x7FFE82C14A10
        public void DOPivot(){} // RVA: 0x7FFE82C14C20
        public void DOPivotX(){} // RVA: 0x7FFE82C14E10
        public void DOPivotY(){} // RVA: 0x7FFE82C15030
        public void DOSizeDelta(){} // RVA: 0x7FFE82C15240
        public void DOPunchAnchorPos(){} // RVA: 0x7FFE82C15450
        public void DOShakeAnchorPos(){} // RVA: 0x7FFE82C158D0 | overloaded x2
        public void DOJumpAnchorPos(){} // RVA: 0x7FFE82C15B40
        public void DONormalizedPos(){} // RVA: 0x7FFE82C16350
        public void DOHorizontalNormalizedPos(){} // RVA: 0x7FFE82C16550
        public void DOVerticalNormalizedPos(){} // RVA: 0x7FFE82C16750
        public void DOValue(){} // RVA: 0x7FFE82C16950
        public void DOCounter(){} // RVA: 0x7FFE82C16D80
        public void DOText(){} // RVA: 0x7FFE82C17450
        public void DOBlendableColor(){} // RVA: 0x7FFE82C17EC0 | overloaded x3
    }

    public class DOTweenModuleUnityVersion : Object
    {
        // ── Methods ──
        public void DOGradientColor(){} // RVA: 0x7FFE82C19990 | overloaded x2
        public void WaitForCompletion(){} // RVA: 0x7FFE82C19C60
        public void WaitForRewind(){} // RVA: 0x7FFE82C19D70
        public void WaitForKill(){} // RVA: 0x7FFE82C19E80
        public void WaitForElapsedLoops(){} // RVA: 0x7FFE82C19F90
        public void WaitForPosition(){} // RVA: 0x7FFE82C1A0C0
        public void WaitForStart(){} // RVA: 0x7FFE82C1A1F0
        public void DOOffset(){} // RVA: 0x7FFE82C1A300
        public void DOTiling(){} // RVA: 0x7FFE82C1A560
        public void AsyncWaitForCompletion(){} // RVA: 0x7FFE82C1A7C0
        public void AsyncWaitForRewind(){} // RVA: 0x7FFE82C1A970
        public void AsyncWaitForKill(){} // RVA: 0x7FFE82C1AB20
        public void AsyncWaitForElapsedLoops(){} // RVA: 0x7FFE82C1ACD0
        public void AsyncWaitForPosition(){} // RVA: 0x7FFE82C1AE90
        public void AsyncWaitForStart(){} // RVA: 0x7FFE82C1B050
    }

    public class DOTweenModuleUtils : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE82C1C500
        public void Preserver(){} // RVA: 0x7FFE82C1C770
    }

    public class DOVirtual : Object
    {
        // ── Methods ──
        public void Float(){} // RVA: 0x7FFE82BEFB60
        public void EasedValue(){} // RVA: 0x7FFE82BEFFE0 | overloaded x4
        public void DelayedCall(){} // RVA: 0x7FFE82BF0160
    }

    public class EaseFactory : Object
    {
        // ── Methods ──
        public void StopMotion(){} // RVA: 0x7FFE82BF04E0 | overloaded x3
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EaseFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BEA090
        public void Invoke(){} // RVA: 0x7FFE82BEA160
        public void BeginInvoke(){} // RVA: 0x7FFE82BEA180
        public void EndInvoke(){} // RVA: 0x7FFE82268F40
    }

    public class IDOTweenInit
    {
        // ── Methods ──
        public void SetCapacity(){}
    }

    public class Sequence : Tween
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BF36F0
        public void DoPrepend(){} // RVA: 0x7FFE82BF38A0
        public void DoInsert(){} // RVA: 0x7FFE82BF39D0
        public void DoAppendInterval(){} // RVA: 0x7FFE82BF3BB0
        public void DoPrependInterval(){} // RVA: 0x7FFE82BF3BF0
        public void DoInsertCallback(){} // RVA: 0x7FFE82BF3CE0
        public void UpdateDelay(){} // RVA: 0x7FFE82BF3DF0
        public void Reset(){} // RVA: 0x7FFE82BF3E20
        public void Validate(){} // RVA: 0x7FFE82BF3EE0
        public void Startup(){} // RVA: 0x7FFE82BF3FD0
        public void ApplyTween(){} // RVA: 0x7FFE82BF3FE0
        public void Setup(){} // RVA: 0x7FFE82BF4000
        public void DoStartup(){} // RVA: 0x7FFE82BF4140
        public void DoApplyTween(){} // RVA: 0x7FFE82BF4400
        public void ApplyInternalCycle(){} // RVA: 0x7FFE82BF4820
        public void StableSortSequencedObjs(){} // RVA: 0x7FFE82BF5080
        public void IsAnyCallbackSet(){} // RVA: 0x7FFE82BF51D0
    }

    public class ShortcutExtensions : Object
    {
        // ── Methods ──
        public void DOAspect(){} // RVA: 0x7FFE82BF5230
        public void DOColor(){} // RVA: 0x7FFE82BF7970 | overloaded x6
        public void DOFarClipPlane(){} // RVA: 0x7FFE82BF55F0
        public void DOFieldOfView(){} // RVA: 0x7FFE82BF57B0
        public void DONearClipPlane(){} // RVA: 0x7FFE82BF5970
        public void DOOrthoSize(){} // RVA: 0x7FFE82BF5B30
        public void DOPixelRect(){} // RVA: 0x7FFE82BF5CF0
        public void DORect(){} // RVA: 0x7FFE82BF5EB0
        public void DOShakePosition(){} // RVA: 0x7FFE82BFCA50 | overloaded x4
        public void DOShakeRotation(){} // RVA: 0x7FFE82BFCFB0 | overloaded x4
        public void DOIntensity(){} // RVA: 0x7FFE82BF6CF0
        public void DOShadowStrength(){} // RVA: 0x7FFE82BF6EB0
        public void DOFade(){} // RVA: 0x7FFE82BF8060 | overloaded x3
        public void DOFloat(){} // RVA: 0x7FFE82BF8540 | overloaded x2
        public void DOOffset(){} // RVA: 0x7FFE82BF8960 | overloaded x2
        public void DOTiling(){} // RVA: 0x7FFE82BF8DA0 | overloaded x2
        public void DOVector(){} // RVA: 0x7FFE82BF92B0 | overloaded x2
        public void DOResize(){} // RVA: 0x7FFE82BF9520
        public void DOTime(){} // RVA: 0x7FFE82BF96F0
        public void DOMove(){} // RVA: 0x7FFE82BF98B0
        public void DOMoveX(){} // RVA: 0x7FFE82BF9AD0
        public void DOMoveY(){} // RVA: 0x7FFE82BF9D30
        public void DOMoveZ(){} // RVA: 0x7FFE82BF9F90
        public void DOLocalMove(){} // RVA: 0x7FFE82BFA1F0
        public void DOLocalMoveX(){} // RVA: 0x7FFE82BFA410
        public void DOLocalMoveY(){} // RVA: 0x7FFE82BFA670
        public void DOLocalMoveZ(){} // RVA: 0x7FFE82BFA8D0
        public void DORotate(){} // RVA: 0x7FFE82BFAB30
        public void DORotateQuaternion(){} // RVA: 0x7FFE82BFAD10
        public void DOLocalRotate(){} // RVA: 0x7FFE82BFAEF0
        public void DOLocalRotateQuaternion(){} // RVA: 0x7FFE82BFB0D0
        public void DOScale(){} // RVA: 0x7FFE82BFB4C0 | overloaded x2
        public void DOScaleX(){} // RVA: 0x7FFE82BFB6D0
        public void DOScaleY(){} // RVA: 0x7FFE82BFB910
        public void DOScaleZ(){} // RVA: 0x7FFE82BFBB50
        public void DOLookAt(){} // RVA: 0x7FFE82BFBD90
        public void DOPunchPosition(){} // RVA: 0x7FFE82BFC010
        public void DOPunchScale(){} // RVA: 0x7FFE82BFC2A0
        public void DOPunchRotation(){} // RVA: 0x7FFE82BFC520
        public void DOShakeScale(){} // RVA: 0x7FFE82BFD570 | overloaded x2
        public void DOJump(){} // RVA: 0x7FFE82BFD810
        public void DOLocalJump(){} // RVA: 0x7FFE82BFE2A0
        public void DOPath(){} // RVA: 0x7FFE82BFF1D0 | overloaded x2
        public void DOLocalPath(){} // RVA: 0x7FFE82BFF3E0 | overloaded x2
        public void DOTimeScale(){} // RVA: 0x7FFE82BFF5F0
        public void DOBlendableColor(){} // RVA: 0x7FFE82C00090 | overloaded x4
        public void DOBlendableMoveBy(){} // RVA: 0x7FFE82C00410
        public void DOBlendableLocalMoveBy(){} // RVA: 0x7FFE82C00690
        public void DOBlendableRotateBy(){} // RVA: 0x7FFE82C00910
        public void DOBlendableLocalRotateBy(){} // RVA: 0x7FFE82C00B40
        public void DOBlendablePunchRotation(){} // RVA: 0x7FFE82C00D70
        public void DOBlendableScaleBy(){} // RVA: 0x7FFE82C01040
        public void DOComplete(){} // RVA: 0x7FFE82C01380 | overloaded x2
        public void DOKill(){} // RVA: 0x7FFE82C014B0 | overloaded x2
        public void DOFlip(){} // RVA: 0x7FFE82C015D0 | overloaded x2
        public void DOGoto(){} // RVA: 0x7FFE82C01770 | overloaded x2
        public void DOPause(){} // RVA: 0x7FFE82C01910 | overloaded x2
        public void DOPlay(){} // RVA: 0x7FFE82C01A90 | overloaded x2
        public void DOPlayBackwards(){} // RVA: 0x7FFE82C01C10 | overloaded x2
        public void DOPlayForward(){} // RVA: 0x7FFE82C01D90 | overloaded x2
        public void DORestart(){} // RVA: 0x7FFE82C01F20 | overloaded x2
        public void DORewind(){} // RVA: 0x7FFE82C020C0 | overloaded x2
        public void DOSmoothRewind(){} // RVA: 0x7FFE82C02250 | overloaded x2
        public void DOTogglePause(){} // RVA: 0x7FFE82C023D0 | overloaded x2
    }

    public class Tween : ABSSequentiable
    {
        public float timeScale; // 0x28
        public bool isBackwards; // 0x2C
        public object id; // 0x30
        public string stringId; // 0x38
        public int intId; // 0x40
        public object target; // 0x48

        // ── Methods ──
        public void get_isRelative(){} // RVA: 0x7FFE824A0700
        public void set_isRelative(){} // RVA: 0x7FFE824A0BA0
        public void get_active(){} // RVA: 0x7FFE822A56E0
        public void set_active(){} // RVA: 0x7FFE82C080B0
        public void get_fullPosition(){} // RVA: 0x7FFE82C080C0
        public void set_fullPosition(){} // RVA: 0x7FFE82C08180
        public void get_hasLoops(){} // RVA: 0x7FFE82C08190
        public void get_playedOnce(){} // RVA: 0x7FFE82904660
        public void set_playedOnce(){} // RVA: 0x7FFE82904710
        public void get_position(){} // RVA: 0x7FFE82C081B0
        public void set_position(){} // RVA: 0x7FFE82C081C0
        public void Reset(){} // RVA: 0x7FFE82C081D0
        public void Validate(){} // RVA: 0x7FFE80E2F150
        public void UpdateDelay(){} // RVA: 0x7FFE8186F320
        public void Startup(){} // RVA: 0x7FFE80E2F150
        public void ApplyTween(){}
        public void DoGoto(){} // RVA: 0x7FFE82C08710
        public void OnTweenCallback(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE82C08C70
    }

    public class TweenCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81159980
        public void Invoke(){} // RVA: 0x7FFE81159A50
        public void BeginInvoke(){} // RVA: 0x7FFE81159A60
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class TweenCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE810A1420
        public void EndInvoke(){} // RVA: 0x7FFE80E460A0
    }

    public class TweenExtensions : Object
    {
        // ── Methods ──
        public void Complete(){} // RVA: 0x7FFE82BF0820 | overloaded x2
        public void Flip(){} // RVA: 0x7FFE82BF09D0
        public void ForceInit(){} // RVA: 0x7FFE82BF0B40
        public void Goto(){} // RVA: 0x7FFE82BF0CB0
        public void Kill(){} // RVA: 0x7FFE82BF0E90
        public void Pause(){} // RVA: 0x7FFE810A1420
        public void Play(){} // RVA: 0x7FFE810A1420
        public void PlayBackwards(){} // RVA: 0x7FFE82BF1080
        public void PlayForward(){} // RVA: 0x7FFE82BF11F0
        public void Restart(){} // RVA: 0x7FFE82BF1360
        public void Rewind(){} // RVA: 0x7FFE82BF14F0
        public void SmoothRewind(){} // RVA: 0x7FFE82BF1660
        public void TogglePause(){} // RVA: 0x7FFE82BF17D0
        public void GotoWaypoint(){} // RVA: 0x7FFE82BF1940
        public void WaitForCompletion(){} // RVA: 0x7FFE82BF1CD0
        public void WaitForRewind(){} // RVA: 0x7FFE82BF1E70
        public void WaitForKill(){} // RVA: 0x7FFE82BF2010
        public void WaitForElapsedLoops(){} // RVA: 0x7FFE82BF21B0
        public void WaitForPosition(){} // RVA: 0x7FFE82BF2350
        public void WaitForStart(){} // RVA: 0x7FFE82BF2500
        public void CompletedLoops(){} // RVA: 0x7FFE82BF26A0
        public void Delay(){} // RVA: 0x7FFE82BF2740
        public void ElapsedDelay(){} // RVA: 0x7FFE82BF27E0
        public void Duration(){} // RVA: 0x7FFE82BF2880
        public void Elapsed(){} // RVA: 0x7FFE82BF2950
        public void ElapsedPercentage(){} // RVA: 0x7FFE82BF2A20
        public void ElapsedDirectionalPercentage(){} // RVA: 0x7FFE82BF2B30
        public void IsActive(){} // RVA: 0x7FFE82BF2C30
        public void IsBackwards(){} // RVA: 0x7FFE82BF2C40
        public void IsComplete(){} // RVA: 0x7FFE82BF2CD0
        public void IsInitialized(){} // RVA: 0x7FFE82BF2D70
        public void IsPlaying(){} // RVA: 0x7FFE82BF2E10
        public void Loops(){} // RVA: 0x7FFE82BF2EB0
        public void PathGetPoint(){} // RVA: 0x7FFE82BF2F50
        public void PathGetDrawPoints(){} // RVA: 0x7FFE82BF31F0
        public void PathLength(){} // RVA: 0x7FFE82BF3500
    }

    public class TweenParams : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82C061D0
        public void Clear(){} // RVA: 0x7FFE82C061E0
        public void SetAutoKill(){} // RVA: 0x7FFE82C06670
        public void SetId(){} // RVA: 0x7FFE82C06680
        public void SetTarget(){} // RVA: 0x7FFE829DE9A0
        public void SetLoops(){} // RVA: 0x7FFE82C066E0
        public void SetEase(){} // RVA: 0x7FFE82C06A40 | overloaded x3
        public void SetRecyclable(){} // RVA: 0x7FFE82C06AB0
        public void SetUpdate(){} // RVA: 0x7FFE82C06B30 | overloaded x2
        public void OnStart(){} // RVA: 0x7FFE82C06B40
        public void OnPlay(){} // RVA: 0x7FFE82C06BA0
        public void OnRewind(){} // RVA: 0x7FFE82C06C00
        public void OnUpdate(){} // RVA: 0x7FFE82C06C60
        public void OnStepComplete(){} // RVA: 0x7FFE82C06CC0
        public void OnComplete(){} // RVA: 0x7FFE82C06D20
        public void OnKill(){} // RVA: 0x7FFE82C06D80
        public void OnWaypointChange(){} // RVA: 0x7FFE82C06DE0
        public void SetDelay(){} // RVA: 0x7FFE82C06E40
        public void SetRelative(){} // RVA: 0x7FFE82C06E50
        public void SetSpeedBased(){} // RVA: 0x7FFE82C06E60
        public void .cctor(){} // RVA: 0x7FFE82C06E70
    }

    public class TweenSettingsExtensions : Object
    {
        // ── Methods ──
        public void SetAutoKill(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetId(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void SetLink(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetTarget(){} // RVA: 0x7FFE810A1420
        public void SetLoops(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetEase(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void SetRecyclable(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetUpdate(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void OnStart(){} // RVA: 0x7FFE810A1420
        public void OnPlay(){} // RVA: 0x7FFE810A1420
        public void OnPause(){} // RVA: 0x7FFE810A1420
        public void OnRewind(){} // RVA: 0x7FFE810A1420
        public void OnUpdate(){} // RVA: 0x7FFE810A1420
        public void OnStepComplete(){} // RVA: 0x7FFE810A1420
        public void OnComplete(){} // RVA: 0x7FFE810A1420
        public void OnKill(){} // RVA: 0x7FFE810A1420
        public void OnWaypointChange(){} // RVA: 0x7FFE810A1420
        public void SetAs(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Append(){} // RVA: 0x7FFE82C06F20
        public void Prepend(){} // RVA: 0x7FFE82C06F70
        public void Join(){} // RVA: 0x7FFE82C070D0
        public void Insert(){} // RVA: 0x7FFE82C07120
        public void AppendInterval(){} // RVA: 0x7FFE82C07170
        public void PrependInterval(){} // RVA: 0x7FFE82C071B0
        public void AppendCallback(){} // RVA: 0x7FFE82C072C0
        public void PrependCallback(){} // RVA: 0x7FFE82C07300
        public void InsertCallback(){} // RVA: 0x7FFE82C07340
        public void From(){} // RVA: 0x7FFE82C07480 | overloaded x5
        public void SetDelay(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetRelative(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetSpeedBased(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetOptions(){} // RVA: 0x7FFE82C077A0 | overloaded x15
        public void SetLookAt(){} // RVA: 0x7FFE82C07C10 | overloaded x7
        public void SetPathForwardDirection(){} // RVA: 0x7FFE82C07CD0
    }

    public class Tweener : Tween
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82C08CA0
        public void ChangeStartValue(){} // RVA: 0x7FFE80E421D0
        public void ChangeEndValue(){} // RVA: 0x7FFE80E3EBB0 | overloaded x2
        public void ChangeValues(){}
        public void SetFrom(){}
        public void Setup(){} // RVA: 0x7FFE810A1420
        public void DoUpdateDelay(){} // RVA: 0x7FFE80E43BB0
        public void DoStartup(){} // RVA: 0x7FFE80E2F230
        public void DoChangeStartValue(){} // RVA: 0x7FFE810A1420
        public void DoChangeEndValue(){} // RVA: 0x7FFE810A1420
        public void DoChangeValues(){} // RVA: 0x7FFE810A1420
        public void DOStartupSpecials(){} // RVA: 0x7FFE80E2F230
        public void DOStartupDurationBased(){} // RVA: 0x7FFE80E46070
    }

}