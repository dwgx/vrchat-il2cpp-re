// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Core
// Classes: 14
// Methods: 126

namespace ThirdParty.DOTween.DG.Tweening.Core
{
    public class ABSSequentiable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DOGetter`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
        public void BeginInvoke(){} // RVA: 0x1E6A0
        public void EndInvoke(){} // RVA: 0x283FA0
    }

    public class DOSetter`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
        public void BeginInvoke(){} // RVA: 0x283FA0
        public void EndInvoke(){} // RVA: 0x24B10
    }

    public class DOTweenComponent
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x1EA6D20
        public void Start(){} // RVA: 0x1EA7110
        public void Update(){} // RVA: 0x1EA72D0
        public void LateUpdate(){} // RVA: 0x1EA7760
        public void FixedUpdate(){} // RVA: 0x1EA7920
        public void OnDrawGizmos(){} // RVA: 0x1EA7B30
        public void OnDestroy(){} // RVA: 0x1EA7CC0
        public void OnApplicationPause(){} // RVA: 0x1EA84C0
        public void OnApplicationQuit(){} // RVA: 0xEC8530
        public void SetCapacity(){} // RVA: 0x1EA8590
        public void WaitForCompletion(){} // RVA: 0x1EA8600
        public void WaitForRewind(){} // RVA: 0x1EA86A0
        public void WaitForKill(){} // RVA: 0x1EA8740
        public void WaitForElapsedLoops(){} // RVA: 0x1EA87E0
        public void WaitForPosition(){} // RVA: 0x1EA8890
        public void WaitForStart(){} // RVA: 0x1EA8950
        public void Create(){} // RVA: 0x1EA89F0
        public void DestroyInstance(){} // RVA: 0x1EA8C40
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class DOTweenExternalCommand
    {
        // ── Methods ──
        public void add_SetOrientationOnPath(){} // RVA: 0x1EA9540
        public void remove_SetOrientationOnPath(){} // RVA: 0x1EA9670
        public void Dispatch_SetOrientationOnPath(){} // RVA: 0x1EA97A0
    }

    public class DOTweenSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1EA93E0
    }

    public class Debugger
    {
        // ── Methods ──
        public void get_logPriority(){} // RVA: 0x1EA6050
        public void Log(){} // RVA: 0x1EA6090
        public void LogWarning(){} // RVA: 0x1EA61C0
        public void LogError(){} // RVA: 0x1EA6520
        public void LogReport(){} // RVA: 0x1EA6650
        public void LogSafeModeReport(){} // RVA: 0x1EA67B0
        public void LogInvalidTween(){} // RVA: 0x1EA6910
        public void LogNestedTween(){} // RVA: 0x1EA6950
        public void LogNullTween(){} // RVA: 0x1EA69A0
        public void LogNonPathTween(){} // RVA: 0x1EA69E0
        public void LogMissingMaterialProperty(){} // RVA: 0x1EA6AC0 | overloaded x2
        public void LogRemoveActiveTweenError(){} // RVA: 0x1EA6B70
        public void LogAddActiveTweenError(){} // RVA: 0x1EA6C10
        public void SetLogPriority(){} // RVA: 0x1EA6CB0
    }

    public class Extensions
    {
        // ── Methods ──
        public void SetSpecialStartupMode(){} // RVA: 0x283FA0
        public void Blendable(){} // RVA: 0xCE50
        public void NoFrom(){} // RVA: 0xCE50
    }

    public class SafeModeReport
    {
        // ── Methods ──
        public void get_totMissingTargetOrFieldErrors(){} // RVA: 0x19689B0
        public void set_totMissingTargetOrFieldErrors(){} // RVA: 0x833580
        public void get_totCallbackErrors(){} // RVA: 0x19689E0
        public void set_totCallbackErrors(){} // RVA: 0x19689D0
        public void get_totStartupErrors(){} // RVA: 0x1EA9890
        public void set_totStartupErrors(){} // RVA: 0x1EA98A0
        public void get_totUnsetErrors(){} // RVA: 0x1EA98B0
        public void set_totUnsetErrors(){} // RVA: 0x1EA98C0
        public void Add(){} // RVA: 0x1EA98D0
        public void GetTotErrors(){} // RVA: 0x1EA98F0
    }

    public class SequenceCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1EA9900
    }

    public class TweenLink
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1EA9960
    }

    public class TweenManager
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x1EA9A20
        public void GetTweener(){} // RVA: 0xC960
        public void GetSequence(){} // RVA: 0x1EA9F60
        public void SetUpdateType(){} // RVA: 0x1EAA420
        public void AddActiveTweenToSequence(){} // RVA: 0x1EAA700
        public void DespawnAll(){} // RVA: 0x1EAA750
        public void Despawn(){} // RVA: 0x1EAAAA0
        public void PurgeAll(){} // RVA: 0x1EAB120
        public void PurgePools(){} // RVA: 0x1EAB430
        public void AddTweenLink(){} // RVA: 0x1EAB560
        public void RemoveTweenLink(){} // RVA: 0x1EAB7E0
        public void ResetCapacities(){} // RVA: 0x1EAB8E0
        public void SetCapacities(){} // RVA: 0x1EAB930
        public void Validate(){} // RVA: 0x1EABA60
        public void Update(){} // RVA: 0x1EABC30
        public void FilteredOperation(){} // RVA: 0x1EAC130
        public void Complete(){} // RVA: 0x1EACEE0
        public void Flip(){} // RVA: 0x1EAD000
        public void ForceInit(){} // RVA: 0x1EAD020
        public void Goto(){} // RVA: 0x1EAD0F0
        public void Pause(){} // RVA: 0x1EAD220
        public void Play(){} // RVA: 0x1EAD270
        public void PlayBackwards(){} // RVA: 0x1EAD300
        public void PlayForward(){} // RVA: 0x1EAD510
        public void Restart(){} // RVA: 0x1EAD690
        public void Rewind(){} // RVA: 0x1EAD780
        public void SmoothRewind(){} // RVA: 0x1EAD940
        public void TogglePause(){} // RVA: 0x1EADAC0
        public void TotalPooledTweens(){} // RVA: 0x1EADBD0
        public void TotalPlayingTweens(){} // RVA: 0x1EADC30
        public void GetActiveTweens(){} // RVA: 0x1EADD60
        public void GetTweensById(){} // RVA: 0x1EADF50
        public void GetTweensByTarget(){} // RVA: 0x1EAE2A0
        public void MarkForKilling(){} // RVA: 0x1EAE490
        public void EvaluateTweenLink(){} // RVA: 0x1EAE520
        public void AddActiveTween(){} // RVA: 0x1EAE9D0
        public void ReorganizeActiveTweens(){} // RVA: 0x1EAEDF0
        public void DespawnActiveTweens(){} // RVA: 0x1EAF0C0
        public void RemoveActiveTween(){} // RVA: 0x1EAF190
        public void ClearTweenArray(){} // RVA: 0x1EAF820
        public void IncreaseCapacities(){} // RVA: 0x1EAF8D0
        public void ManageOnRewindCallbackWhenAlreadyRewinded(){} // RVA: 0x1EAFB20
    }

    public class TweenerCore`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void ChangeStartValue(){} // RVA: 0x283FA0 | overloaded x2
        public void ChangeEndValue(){} // RVA: 0x283FA0 | overloaded x4
        public void ChangeValues(){} // RVA: 0x283FA0 | overloaded x2
        public void SetFrom(){} // RVA: 0x283FA0 | overloaded x2
        public void Reset(){} // RVA: 0x24A50
        public void Validate(){} // RVA: 0xDBE0
        public void UpdateDelay(){} // RVA: 0x22A00
        public void Startup(){} // RVA: 0xDBE0
        public void ApplyTween(){}
    }

    public class Utils
    {
        // ── Methods ──
        public void Vector3FromAngle(){} // RVA: 0x1EAFBF0
        public void Angle2D(){} // RVA: 0x1EAFC50
        public void RotateAroundPivot(){} // RVA: 0x1EAFD50
        public void Vector3AreApproximatelyEqual(){} // RVA: 0x1EAFF60
        public void GetLooseScriptType(){} // RVA: 0x1EAFFC0
        public void .cctor(){} // RVA: 0x1EB0360
    }

}