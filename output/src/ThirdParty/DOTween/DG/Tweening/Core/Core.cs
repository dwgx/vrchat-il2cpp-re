// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Core
// Classes: 13
// Methods: 125

namespace ThirdParty.DOTween.DG.Tweening.Core
{
    public class ABSSequentiable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class DOGetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E08A6F0
        public void EndInvoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class DOSetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
        public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
        public void EndInvoke(){} // RVA: 0x7FFD4E090A40
    }

    public class DOTweenComponent : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4FDE4980
        public void Start(){} // RVA: 0x7FFD4FDE4D70
        public void Update(){} // RVA: 0x7FFD4FDE4F30
        public void LateUpdate(){} // RVA: 0x7FFD4FDE53C0
        public void FixedUpdate(){} // RVA: 0x7FFD4FDE5580
        public void OnDrawGizmos(){} // RVA: 0x7FFD4FDE5790
        public void OnDestroy(){} // RVA: 0x7FFD4FDE5920
        public void OnApplicationPause(){} // RVA: 0x7FFD4FDE6120
        public void OnApplicationQuit(){} // RVA: 0x7FFD4FDE61F0
        public void SetCapacity(){} // RVA: 0x7FFD4FDE6200
        public void WaitForCompletion(){} // RVA: 0x7FFD4FDE6270
        public void WaitForRewind(){} // RVA: 0x7FFD4FDE6310
        public void WaitForKill(){} // RVA: 0x7FFD4FDE63B0
        public void WaitForElapsedLoops(){} // RVA: 0x7FFD4FDE6450
        public void WaitForPosition(){} // RVA: 0x7FFD4FDE6500
        public void WaitForStart(){} // RVA: 0x7FFD4FDE65C0
        public void Create(){} // RVA: 0x7FFD4FDE6660
        public void DestroyInstance(){} // RVA: 0x7FFD4FDE68B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class DOTweenExternalCommand : Object
    {
        // ── Methods ──
        public void add_SetOrientationOnPath(){} // RVA: 0x7FFD4FDE71B0
        public void remove_SetOrientationOnPath(){} // RVA: 0x7FFD4FDE72E0
        public void Dispatch_SetOrientationOnPath(){} // RVA: 0x7FFD4FDE7410
    }

    public class DOTweenSettings : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FDE7050
    }

    public class Debugger : Object
    {
        public object logPriority;

        // ── Methods ──
        public void get_logPriority(){} // RVA: 0x7FFD4FDE3CB0
        public void Log(){} // RVA: 0x7FFD4FDE3CF0
        public void LogWarning(){} // RVA: 0x7FFD4FDE3E20
        public void LogError(){} // RVA: 0x7FFD4FDE4180
        public void LogReport(){} // RVA: 0x7FFD4FDE42B0
        public void LogSafeModeReport(){} // RVA: 0x7FFD4FDE4410
        public void LogInvalidTween(){} // RVA: 0x7FFD4FDE4570
        public void LogNestedTween(){} // RVA: 0x7FFD4FDE45B0
        public void LogNullTween(){} // RVA: 0x7FFD4FDE4600
        public void LogNonPathTween(){} // RVA: 0x7FFD4FDE4640
        public void LogMissingMaterialProperty(){} // RVA: 0x7FFD4FDE4720 | overloaded x2
        public void LogRemoveActiveTweenError(){} // RVA: 0x7FFD4FDE47D0
        public void LogAddActiveTweenError(){} // RVA: 0x7FFD4FDE4870
        public void SetLogPriority(){} // RVA: 0x7FFD4FDE4910
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void SetSpecialStartupMode(){} // RVA: 0x7FFD4E2ADC40
        public void Blendable(){} // RVA: 0x7FFD4E078F80
        public void NoFrom(){} // RVA: 0x7FFD4E078F80
    }

    public class SafeModeReport : ValueType
    {
        public object totMissingTargetOrFieldErrors;
        public object totCallbackErrors;
        public object totStartupErrors;
        public object totUnsetErrors;

        // ── Methods ──
        public void get_totMissingTargetOrFieldErrors(){} // RVA: 0x7FFD4F840210
        public void set_totMissingTargetOrFieldErrors(){} // RVA: 0x7FFD4E78D8B0
        public void get_totCallbackErrors(){} // RVA: 0x7FFD4F8402A0
        public void set_totCallbackErrors(){} // RVA: 0x7FFD4F840230
        public void get_totStartupErrors(){} // RVA: 0x7FFD4FDE7500
        public void set_totStartupErrors(){} // RVA: 0x7FFD4FDE7510
        public void get_totUnsetErrors(){} // RVA: 0x7FFD4FDE7520
        public void set_totUnsetErrors(){} // RVA: 0x7FFD4FDE7530
        public void Add(){} // RVA: 0x7FFD4FDE7540
        public void GetTotErrors(){} // RVA: 0x7FFD4FDE7560
    }

    public class TweenLink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FDE75D0
    }

    public class TweenManager : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD4FDE7690
        public void GetTweener(){} // RVA: 0x7FFD4E078A90
        public void GetSequence(){} // RVA: 0x7FFD4FDE7BD0
        public void SetUpdateType(){} // RVA: 0x7FFD4FDE8090
        public void AddActiveTweenToSequence(){} // RVA: 0x7FFD4FDE8370
        public void DespawnAll(){} // RVA: 0x7FFD4FDE83C0
        public void Despawn(){} // RVA: 0x7FFD4FDE8710
        public void PurgeAll(){} // RVA: 0x7FFD4FDE8D90
        public void PurgePools(){} // RVA: 0x7FFD4FDE90A0
        public void AddTweenLink(){} // RVA: 0x7FFD4FDE91D0
        public void RemoveTweenLink(){} // RVA: 0x7FFD4FDE9450
        public void ResetCapacities(){} // RVA: 0x7FFD4FDE9550
        public void SetCapacities(){} // RVA: 0x7FFD4FDE95A0
        public void Validate(){} // RVA: 0x7FFD4FDE96D0
        public void Update(){} // RVA: 0x7FFD4FDE98A0
        public void FilteredOperation(){} // RVA: 0x7FFD4FDE9DA0
        public void Complete(){} // RVA: 0x7FFD4FDEAB50
        public void Flip(){} // RVA: 0x7FFD4FDEAC70
        public void ForceInit(){} // RVA: 0x7FFD4FDEAC90
        public void Goto(){} // RVA: 0x7FFD4FDEAD60
        public void Pause(){} // RVA: 0x7FFD4FDEAE90
        public void Play(){} // RVA: 0x7FFD4FDEAEE0
        public void PlayBackwards(){} // RVA: 0x7FFD4FDEAF70
        public void PlayForward(){} // RVA: 0x7FFD4FDEB180
        public void Restart(){} // RVA: 0x7FFD4FDEB300
        public void Rewind(){} // RVA: 0x7FFD4FDEB3F0
        public void SmoothRewind(){} // RVA: 0x7FFD4FDEB5B0
        public void TogglePause(){} // RVA: 0x7FFD4FDEB730
        public void TotalPooledTweens(){} // RVA: 0x7FFD4FDEB840
        public void TotalPlayingTweens(){} // RVA: 0x7FFD4FDEB8A0
        public void GetActiveTweens(){} // RVA: 0x7FFD4FDEB9D0
        public void GetTweensById(){} // RVA: 0x7FFD4FDEBBC0
        public void GetTweensByTarget(){} // RVA: 0x7FFD4FDEBF10
        public void MarkForKilling(){} // RVA: 0x7FFD4FDEC100
        public void EvaluateTweenLink(){} // RVA: 0x7FFD4FDEC190
        public void AddActiveTween(){} // RVA: 0x7FFD4FDEC630
        public void ReorganizeActiveTweens(){} // RVA: 0x7FFD4FDECA50
        public void DespawnActiveTweens(){} // RVA: 0x7FFD4FDECD20
        public void RemoveActiveTween(){} // RVA: 0x7FFD4FDECDF0
        public void ClearTweenArray(){} // RVA: 0x7FFD4FDED480
        public void IncreaseCapacities(){} // RVA: 0x7FFD4FDED530
        public void ManageOnRewindCallbackWhenAlreadyRewinded(){} // RVA: 0x7FFD4FDED780
    }

    public class TweenerCore`3 : Tweener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void ChangeStartValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ChangeEndValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void ChangeValues(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SetFrom(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Reset(){} // RVA: 0x7FFD4E090980
        public void Validate(){} // RVA: 0x7FFD4E079D00
        public void UpdateDelay(){} // RVA: 0x7FFD4E08E9F0
        public void Startup(){} // RVA: 0x7FFD4E079D00
        public void ApplyTween(){}
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void Vector3FromAngle(){} // RVA: 0x7FFD4FDED850
        public void Angle2D(){} // RVA: 0x7FFD4FDED8B0
        public void RotateAroundPivot(){} // RVA: 0x7FFD4FDED9B0
        public void Vector3AreApproximatelyEqual(){} // RVA: 0x7FFD4FDEDBC0
        public void GetLooseScriptType(){} // RVA: 0x7FFD4FDEDC20
        public void .cctor(){} // RVA: 0x7FFD4FDEDFC0
    }

}