// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Core
// Classes: 14
// Methods: 126

namespace ThirdParty.DOTween.DG.Tweening.Core
{
    public class ABSSequentiable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DOGetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE80E3FC10
        public void EndInvoke(){} // RVA: 0x7FFE810A1420
    }

    public class DOSetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
        public void BeginInvoke(){} // RVA: 0x7FFE810A1420
        public void EndInvoke(){} // RVA: 0x7FFE80E460A0
    }

    public class DOTweenComponent : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE82C30480
        public void Start(){} // RVA: 0x7FFE82C30870
        public void Update(){} // RVA: 0x7FFE82C30A30
        public void LateUpdate(){} // RVA: 0x7FFE82C30EC0
        public void FixedUpdate(){} // RVA: 0x7FFE82C31080
        public void OnDrawGizmos(){} // RVA: 0x7FFE82C31290
        public void OnDestroy(){} // RVA: 0x7FFE82C31420
        public void OnApplicationPause(){} // RVA: 0x7FFE82C31C20
        public void OnApplicationQuit(){} // RVA: 0x7FFE82C31CF0
        public void SetCapacity(){} // RVA: 0x7FFE82C31D00
        public void WaitForCompletion(){} // RVA: 0x7FFE82C31D70
        public void WaitForRewind(){} // RVA: 0x7FFE82C31E10
        public void WaitForKill(){} // RVA: 0x7FFE82C31EB0
        public void WaitForElapsedLoops(){} // RVA: 0x7FFE82C31F50
        public void WaitForPosition(){} // RVA: 0x7FFE82C32000
        public void WaitForStart(){} // RVA: 0x7FFE82C320C0
        public void Create(){} // RVA: 0x7FFE82C32160
        public void DestroyInstance(){} // RVA: 0x7FFE82C323B0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class DOTweenExternalCommand : Object
    {
        // ── Methods ──
        public void add_SetOrientationOnPath(){} // RVA: 0x7FFE82C32CB0
        public void remove_SetOrientationOnPath(){} // RVA: 0x7FFE82C32DE0
        public void Dispatch_SetOrientationOnPath(){} // RVA: 0x7FFE82C32F10
    }

    public class DOTweenSettings : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82C32B50
    }

    public class Debugger : Object
    {
        public int _logPriority;

        // ── Methods ──
        public void get_logPriority(){} // RVA: 0x7FFE82C2F7B0
        public void Log(){} // RVA: 0x7FFE82C2F7F0
        public void LogWarning(){} // RVA: 0x7FFE82C2F920
        public void LogError(){} // RVA: 0x7FFE82C2FC80
        public void LogReport(){} // RVA: 0x7FFE82C2FDB0
        public void LogSafeModeReport(){} // RVA: 0x7FFE82C2FF10
        public void LogInvalidTween(){} // RVA: 0x7FFE82C30070
        public void LogNestedTween(){} // RVA: 0x7FFE82C300B0
        public void LogNullTween(){} // RVA: 0x7FFE82C30100
        public void LogNonPathTween(){} // RVA: 0x7FFE82C30140
        public void LogMissingMaterialProperty(){} // RVA: 0x7FFE82C30220 | overloaded x2
        public void LogRemoveActiveTweenError(){} // RVA: 0x7FFE82C302D0
        public void LogAddActiveTweenError(){} // RVA: 0x7FFE82C30370
        public void SetLogPriority(){} // RVA: 0x7FFE82C30410
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void SetSpecialStartupMode(){} // RVA: 0x7FFE810A1420
        public void Blendable(){} // RVA: 0x7FFE80E2E3D0
        public void NoFrom(){} // RVA: 0x7FFE80E2E3D0
    }

    public class SafeModeReport : ValueType
    {
        public int _totMissingTargetOrFieldErrors; // 0x10
        public int _totCallbackErrors; // 0x14
        public int _totStartupErrors; // 0x18
        public int _totUnsetErrors; // 0x1C

        // ── Methods ──
        public void get_totMissingTargetOrFieldErrors(){} // RVA: 0x7FFE826F4220
        public void set_totMissingTargetOrFieldErrors(){} // RVA: 0x7FFE815BF990
        public void get_totCallbackErrors(){} // RVA: 0x7FFE826F42A0
        public void set_totCallbackErrors(){} // RVA: 0x7FFE826F4290
        public void get_totStartupErrors(){} // RVA: 0x7FFE82C33000
        public void set_totStartupErrors(){} // RVA: 0x7FFE82C33010
        public void get_totUnsetErrors(){} // RVA: 0x7FFE82C33020
        public void set_totUnsetErrors(){} // RVA: 0x7FFE82C33030
        public void Add(){} // RVA: 0x7FFE82C33040
        public void GetTotErrors(){} // RVA: 0x7FFE82C33060
    }

    public class SequenceCallback : ABSSequentiable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82C33070
    }

    public class TweenLink : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82C330D0
    }

    public class TweenManager : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE82C33190
        public void GetTweener(){} // RVA: 0x7FFE80E2DEE0
        public void GetSequence(){} // RVA: 0x7FFE82C336D0
        public void SetUpdateType(){} // RVA: 0x7FFE82C33B90
        public void AddActiveTweenToSequence(){} // RVA: 0x7FFE82C33E70
        public void DespawnAll(){} // RVA: 0x7FFE82C33EC0
        public void Despawn(){} // RVA: 0x7FFE82C34210
        public void PurgeAll(){} // RVA: 0x7FFE82C34890
        public void PurgePools(){} // RVA: 0x7FFE82C34BA0
        public void AddTweenLink(){} // RVA: 0x7FFE82C34CD0
        public void RemoveTweenLink(){} // RVA: 0x7FFE82C34F50
        public void ResetCapacities(){} // RVA: 0x7FFE82C35050
        public void SetCapacities(){} // RVA: 0x7FFE82C350A0
        public void Validate(){} // RVA: 0x7FFE82C351D0
        public void Update(){} // RVA: 0x7FFE82C353A0
        public void FilteredOperation(){} // RVA: 0x7FFE82C358A0
        public void Complete(){} // RVA: 0x7FFE82C36650
        public void Flip(){} // RVA: 0x7FFE82C36770
        public void ForceInit(){} // RVA: 0x7FFE82C36790
        public void Goto(){} // RVA: 0x7FFE82C36860
        public void Pause(){} // RVA: 0x7FFE82C36990
        public void Play(){} // RVA: 0x7FFE82C369E0
        public void PlayBackwards(){} // RVA: 0x7FFE82C36A70
        public void PlayForward(){} // RVA: 0x7FFE82C36C80
        public void Restart(){} // RVA: 0x7FFE82C36E00
        public void Rewind(){} // RVA: 0x7FFE82C36EF0
        public void SmoothRewind(){} // RVA: 0x7FFE82C370B0
        public void TogglePause(){} // RVA: 0x7FFE82C37230
        public void TotalPooledTweens(){} // RVA: 0x7FFE82C37340
        public void TotalPlayingTweens(){} // RVA: 0x7FFE82C373A0
        public void GetActiveTweens(){} // RVA: 0x7FFE82C374D0
        public void GetTweensById(){} // RVA: 0x7FFE82C376C0
        public void GetTweensByTarget(){} // RVA: 0x7FFE82C37A10
        public void MarkForKilling(){} // RVA: 0x7FFE82C37C00
        public void EvaluateTweenLink(){} // RVA: 0x7FFE82C37C90
        public void AddActiveTween(){} // RVA: 0x7FFE82C38130
        public void ReorganizeActiveTweens(){} // RVA: 0x7FFE82C38550
        public void DespawnActiveTweens(){} // RVA: 0x7FFE82C38820
        public void RemoveActiveTween(){} // RVA: 0x7FFE82C388F0
        public void ClearTweenArray(){} // RVA: 0x7FFE82C38F80
        public void IncreaseCapacities(){} // RVA: 0x7FFE82C39030
        public void ManageOnRewindCallbackWhenAlreadyRewinded(){} // RVA: 0x7FFE82C39280
    }

    public class TweenerCore`3 : Tweener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void ChangeStartValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ChangeEndValue(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void ChangeValues(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SetFrom(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void Validate(){} // RVA: 0x7FFE80E2F150
        public void UpdateDelay(){} // RVA: 0x7FFE80E43F80
        public void Startup(){} // RVA: 0x7FFE80E2F150
        public void ApplyTween(){}
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void Vector3FromAngle(){} // RVA: 0x7FFE82C39350
        public void Angle2D(){} // RVA: 0x7FFE82C393B0
        public void RotateAroundPivot(){} // RVA: 0x7FFE82C394B0
        public void Vector3AreApproximatelyEqual(){} // RVA: 0x7FFE82C396C0
        public void GetLooseScriptType(){} // RVA: 0x7FFE82C39720
        public void .cctor(){} // RVA: 0x7FFE82C39AC0
    }

}