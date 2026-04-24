// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Core
// Classes: 13
// Methods: 125

namespace ThirdParty.DOTween.DG.Tweening.Core
{
    public class ABSSequentiable : Object
    {
        public object sequencedEndPosition; // 0x30CC0C40
        public object isBackwards; // 0x30CABDE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class DOGetter`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
        public void EndInvoke(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaa865aa30
    }

    public class DOSetter`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
        public void EndInvoke(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaa887e5c0
    }

    public class DOTweenComponent : MonoBehaviour
    {
        public object _unscaledDeltaTime; // 0x33201E00
        public object _isQuitting; // 0x33201E00
        public object 00; // 0x4
        public object 00; // 0x37463870

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaaa3cc400
        public void Start(){} // RVA: 0x7ffaaa3cc7f0
        public void Update(){} // RVA: 0x7ffaaa3cc9b0
        public void LateUpdate(){} // RVA: 0x7ffaaa3cce40
        public void FixedUpdate(){} // RVA: 0x7ffaaa3cd000
        public void OnDrawGizmos(){} // RVA: 0x7ffaaa3cd210
        public void OnDestroy(){} // RVA: 0x7ffaaa3cd3a0
        public void OnApplicationPause(){} // RVA: 0x7ffaaa3cdba0
        public void OnApplicationQuit(){} // RVA: 0x7ffaaa3cdc70
        public void WaitForCompletion(){} // RVA: 0x7ffaaa3cdcf0
        public void WaitForRewind(){} // RVA: 0x7ffaaa3cdd90
        public void WaitForKill(){} // RVA: 0x7ffaaa3cde30
        public void WaitForElapsedLoops(){} // RVA: 0x7ffaaa3cded0
        public void WaitForPosition(){} // RVA: 0x7ffaaa3cdf80
        public void WaitForStart(){} // RVA: 0x7ffaaa3ce040
        public void Create(){} // RVA: 0x7ffaaa3ce0e0
        public void DestroyInstance(){} // RVA: 0x7ffaaa3ce330
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void SetCapacity(){} // RVA: 0x7ffaaa3cdc80
    }

    public class DOTweenExternalCommand : Object
    {
        // ── Original Methods ──
        public void add_SetOrientationOnPath(){} // RVA: 0x7ffaaa3cec30
        public void remove_SetOrientationOnPath(){} // RVA: 0x7ffaaa3ced60
        public void Dispatch_SetOrientationOnPath(){} // RVA: 0x7ffaaa3cee90
    }

    public class DOTweenSettings : ScriptableObject
    {
        public object useSafeMode; // 0x33D05AB0
        public object useSmoothDeltaTime; // 0x33D05AB0
        public object showUnityEditorReport; // 0x33D05AB0
        public object defaultRecyclable; // 0x33D05AB0
        public object defaultTimeScaleIndependent; // 0x33D05AB0
        public object defaultEasePeriod; // 0x33D05AB0
        public object debugMode; // 0x33D05AB0
        public object storeSettingsLocation; // 0x33D05AB0
        public object showPausedTweens; // 0x33D05AB0
        public object 00; // 0x40001EA
        public object 00; // 0x40001ED
        public object 00; // 0x40001F0
        public object 00; // 0x40001F3

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa3cead0
    }

    public class Debugger : Object
    {
        // ── Original Methods ──
        public void get_logPriority(){} // RVA: 0x7ffaaa3cb730
        public void Log(){} // RVA: 0x7ffaaa3cb770
        public void LogWarning(){} // RVA: 0x7ffaaa3cb8a0
        public void LogError(){} // RVA: 0x7ffaaa3cbc00
        public void LogReport(){} // RVA: 0x7ffaaa3cbd30
        public void LogSafeModeReport(){} // RVA: 0x7ffaaa3cbe90
        public void LogInvalidTween(){} // RVA: 0x7ffaaa3cbff0
        public void LogNestedTween(){} // RVA: 0x7ffaaa3cc030
        public void LogNullTween(){} // RVA: 0x7ffaaa3cc080
        public void LogNonPathTween(){} // RVA: 0x7ffaaa3cc0c0
        public void LogMissingMaterialProperty(){} // RVA: 0x7ffaaa3cc1a0
        public void LogMissingMaterialProperty(){} // RVA: 0x7ffaaa3cc1a0
        public void LogRemoveActiveTweenError(){} // RVA: 0x7ffaaa3cc250
        public void LogAddActiveTweenError(){} // RVA: 0x7ffaaa3cc2f0
        // ── Binary Analysis Named ──
        public void SetLogPriority(){} // RVA: 0x7ffaaa3cc390
    }

    public class Extensions : Object
    {
        // ── Original Methods ──
        public void Blendable(){} // RVA: 0x7ffaa86492c0
        public void NoFrom(){} // RVA: 0x7ffaa86492c0
        // ── Binary Analysis Named ──
        public void SetSpecialStartupMode(){} // RVA: 0x7ffaa887e5c0
    }

    public class SafeModeReport : ValueType
    {
        public object _totStartupErrors; // 0x37461A00, was: <totStartupErrors>k__BackingFi

        // ── Original Methods ──
        public void get_totMissingTargetOrFieldErrors(){} // RVA: 0x7ffaa9e47550
        public void set_totMissingTargetOrFieldErrors(){} // RVA: 0x7ffaa8d92880
        public void get_totCallbackErrors(){} // RVA: 0x7ffaa9e47530
        public void set_totCallbackErrors(){} // RVA: 0x7ffaa9e475c0
        public void get_totStartupErrors(){} // RVA: 0x7ffaaa3cef80
        public void set_totStartupErrors(){} // RVA: 0x7ffaaa3cef90
        public void get_totUnsetErrors(){} // RVA: 0x7ffaaa3cefa0
        public void set_totUnsetErrors(){} // RVA: 0x7ffaaa3cefb0
        public void Add(){} // RVA: 0x7ffaaa3cefc0
        // ── Binary Analysis Named ──
        public void GetTotErrors(){} // RVA: 0x7ffaaa3cefe0
    }

    public class TweenLink : Object
    {
        public object lastSeenActive; // 0x374D8330

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa3cf050
    }

    public class TweenManager : Object
    {
        public object _MaxTweensReached; // 0x319104B0
        public object isDebugBuild; // 0x319104B0
        public object maxSequences; // 0x319104B0
        public object hasActiveLateTweens; // 0x319104B0
        public object totActiveTweens; // 0x319104B0
        public object totActiveFixedTweens; // 0x319104B0
        public object totActiveSequences; // 0x319104B0
        public object totTweeners; // 0x319104B0
        public object _activeTweens; // 0x319104B0
        public object _KillList; // 0x319104B0
        public object _maxActiveLookupId; // 0x319104B0
        public object _minPooledTweenerId; // 0x319104B0
        public object 00; // 0x822C7AB8

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaa3cf110
        public void AddActiveTweenToSequence(){} // RVA: 0x7ffaaa3cfdf0
        public void DespawnAll(){} // RVA: 0x7ffaaa3cfe40
        public void Despawn(){} // RVA: 0x7ffaaa3d0190
        public void PurgeAll(){} // RVA: 0x7ffaaa3d0810
        public void PurgePools(){} // RVA: 0x7ffaaa3d0b20
        public void AddTweenLink(){} // RVA: 0x7ffaaa3d0c50
        public void RemoveTweenLink(){} // RVA: 0x7ffaaa3d0ed0
        public void ResetCapacities(){} // RVA: 0x7ffaaa3d0fd0
        public void Validate(){} // RVA: 0x7ffaaa3d1150
        public void Update(){} // RVA: 0x7ffaaa3d1320
        public void FilteredOperation(){} // RVA: 0x7ffaaa3d1820
        public void Complete(){} // RVA: 0x7ffaaa3d25d0
        public void Flip(){} // RVA: 0x7ffaaa3d26f0
        public void ForceInit(){} // RVA: 0x7ffaaa3d2710
        public void Goto(){} // RVA: 0x7ffaaa3d27e0
        public void Pause(){} // RVA: 0x7ffaaa3d2910
        public void Play(){} // RVA: 0x7ffaaa3d2960
        public void PlayBackwards(){} // RVA: 0x7ffaaa3d29f0
        public void PlayForward(){} // RVA: 0x7ffaaa3d2c00
        public void Restart(){} // RVA: 0x7ffaaa3d2d80
        public void Rewind(){} // RVA: 0x7ffaaa3d2e70
        public void SmoothRewind(){} // RVA: 0x7ffaaa3d3030
        public void TogglePause(){} // RVA: 0x7ffaaa3d31b0
        public void TotalPooledTweens(){} // RVA: 0x7ffaaa3d32c0
        public void TotalPlayingTweens(){} // RVA: 0x7ffaaa3d3320
        public void MarkForKilling(){} // RVA: 0x7ffaaa3d3b80
        public void EvaluateTweenLink(){} // RVA: 0x7ffaaa3d3c10
        public void AddActiveTween(){} // RVA: 0x7ffaaa3d40b0
        public void ReorganizeActiveTweens(){} // RVA: 0x7ffaaa3d44d0
        public void DespawnActiveTweens(){} // RVA: 0x7ffaaa3d47a0
        public void RemoveActiveTween(){} // RVA: 0x7ffaaa3d4870
        public void ClearTweenArray(){} // RVA: 0x7ffaaa3d4f00
        public void IncreaseCapacities(){} // RVA: 0x7ffaaa3d4fb0
        public void ManageOnRewindCallbackWhenAlreadyRewinded(){} // RVA: 0x7ffaaa3d5200
        // ── Binary Analysis Named ──
        public void GetTweener(){} // RVA: 0x7ffaa8648dd0
        public void GetSequence(){} // RVA: 0x7ffaaa3cf650
        public void SetUpdateType(){} // RVA: 0x7ffaaa3cfb10
        public void SetCapacities(){} // RVA: 0x7ffaaa3d1020
        public void GetActiveTweens(){} // RVA: 0x7ffaaa3d3450
        public void GetTweensById(){} // RVA: 0x7ffaaa3d3640
        public void GetTweensByTarget(){} // RVA: 0x7ffaaa3d3990
    }

    public class TweenerCore`3 : Tweener
    {
        public object changeValue; // 0x30CC0800
        public object setter; // 0x30CC0800

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void ChangeStartValue(){} // RVA: 0x7ffaa887e5c0
        public void ChangeEndValue(){} // RVA: 0x7ffaa887e5c0
        public void ChangeEndValue(){} // RVA: 0x7ffaa887e5c0
        public void ChangeValues(){} // RVA: 0x7ffaa887e5c0
        public void ChangeStartValue(){} // RVA: 0x7ffaa887e5c0
        public void ChangeEndValue(){} // RVA: 0x7ffaa887e5c0
        public void ChangeEndValue(){} // RVA: 0x7ffaa887e5c0
        public void ChangeValues(){} // RVA: 0x7ffaa887e5c0
        public void Reset(){} // RVA: 0x7ffaa8660cc0
        public void Validate(){} // RVA: 0x7ffaa864a040
        public void UpdateDelay(){} // RVA: 0x7ffaa865ed30
        public void Startup(){} // RVA: 0x7ffaa864a040
        public void ApplyTween(){}
        // ── Binary Analysis Named ──
        public void SetFrom(){} // RVA: 0x7ffaa887e5c0
        public void SetFrom(){} // RVA: 0x7ffaa887e5c0
    }

    public class Utils : Object
    {
        // ── Original Methods ──
        public void Vector3FromAngle(){} // RVA: 0x7ffaaa3d52d0
        public void Angle2D(){} // RVA: 0x7ffaaa3d5330
        public void RotateAroundPivot(){} // RVA: 0x7ffaaa3d5430
        public void Vector3AreApproximatelyEqual(){} // RVA: 0x7ffaaa3d5640
        public void .cctor(){} // RVA: 0x7ffaaa3d5a40
        // ── Binary Analysis Named ──
        public void GetLooseScriptType(){} // RVA: 0x7ffaaa3d56a0
    }

}