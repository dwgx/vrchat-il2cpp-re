// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Core
// Classes: 14
// Methods: 126

namespace ThirdParty.DOTween.DG.Tweening.Core
{
    public class ABSSequentiable : Object
    {
        public 0x6B26E498 tweenType; // 0x10
        public float sequencedPosition; // 0x14
        public float sequencedEndPosition; // 0x18
        public DG.Tweening.TweenCallback onStart; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DOGetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
        public void BeginInvoke(){} // RVA: 0x7FFAC2C6A6F0
        public void EndInvoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class DOSetter`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
        public void BeginInvoke(){} // RVA: 0x7FFAC2E8DC40
        public void EndInvoke(){} // RVA: 0x7FFAC2C70A40
    }

    public class DOTweenComponent : MonoBehaviour
    {
        public int inspectorUpdater; // 0x20
        public float _unscaledTime; // 0x24
        public float _unscaledDeltaTime; // 0x28
        public bool _paused; // 0x2C
        public float _pausedTime; // 0x30
        public bool _isQuitting; // 0x34
        public bool _duplicateToDestroy; // 0x35

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC49C4980
        public void Start(){} // RVA: 0x7FFAC49C4D70
        public void Update(){} // RVA: 0x7FFAC49C4F30
        public void LateUpdate(){} // RVA: 0x7FFAC49C53C0
        public void FixedUpdate(){} // RVA: 0x7FFAC49C5580
        public void OnDrawGizmos(){} // RVA: 0x7FFAC49C5790
        public void OnDestroy(){} // RVA: 0x7FFAC49C5920
        public void OnApplicationPause(){} // RVA: 0x7FFAC49C6120
        public void OnApplicationQuit(){} // RVA: 0x7FFAC49C61F0
        public void SetCapacity(){} // RVA: 0x7FFAC49C6200
        public void WaitForCompletion(){} // RVA: 0x7FFAC49C6270
        public void WaitForRewind(){} // RVA: 0x7FFAC49C6310
        public void WaitForKill(){} // RVA: 0x7FFAC49C63B0
        public void WaitForElapsedLoops(){} // RVA: 0x7FFAC49C6450
        public void WaitForPosition(){} // RVA: 0x7FFAC49C6500
        public void WaitForStart(){} // RVA: 0x7FFAC49C65C0
        public void Create(){} // RVA: 0x7FFAC49C6660
        public void DestroyInstance(){} // RVA: 0x7FFAC49C68B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class DOTweenExternalCommand : Object
    {
        public System.Action`4<DG.Tweening.Plugins.Options.PathOptions,DG.Tweening.Tween,UnityEngine.Quaternion,UnityEngine.Transform> SetOrientationOnPath;

        // ── Methods ──
        public void add_SetOrientationOnPath(){} // RVA: 0x7FFAC49C71B0
        public void remove_SetOrientationOnPath(){} // RVA: 0x7FFAC49C72E0
        public void Dispatch_SetOrientationOnPath(){} // RVA: 0x7FFAC49C7410
    }

    public class DOTweenSettings : ScriptableObject
    {
        public string AssetName;
        public string AssetFullFilename;
        public bool useSafeMode; // 0x18
        public SafeModeOptions safeModeOptions; // 0x20
        public float timeScale; // 0x28
        public bool useSmoothDeltaTime; // 0x2C
        public float maxSmoothUnscaledTime; // 0x30
        public 0x6B26FEB8 rewindCallbackMode; // 0x34
        public bool showUnityEditorReport; // 0x38
        public 0x6B26E390 logBehaviour; // 0x3C
        public bool drawGizmos; // 0x40
        public bool defaultRecyclable; // 0x41
        public 0x6B26C0D8 defaultAutoPlay; // 0x44
        public 0x6B26E4F0 defaultUpdateType; // 0x48
        public bool defaultTimeScaleIndependent; // 0x4C
        public 0x6B26C448 defaultEaseType; // 0x50
        public float defaultEaseOvershootOrAmplitude; // 0x54
        public float defaultEasePeriod; // 0x58
        public bool defaultAutoKill; // 0x5C
        public 0x6B26C7B8 defaultLoopType; // 0x60
        public bool debugMode; // 0x64
        public bool debugStoreTargetId; // 0x65
        public bool showPreviewPanel; // 0x66
        public 0x6B26F7D8 storeSettingsLocation; // 0x68
        public ModulesSetup modules; // 0x70
        public bool showPlayingTweens; // 0x78
        public bool showPausedTweens; // 0x79

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC49C7050
    }

    public class Debugger : Object
    {
        public int logPriority;
        public string _LogPrefix;

        // ── Methods ──
        public void get_logPriority(){} // RVA: 0x7FFAC49C3CB0
        public void Log(){} // RVA: 0x7FFAC49C3CF0
        public void LogWarning(){} // RVA: 0x7FFAC49C3E20
        public void LogError(){} // RVA: 0x7FFAC49C4180
        public void LogReport(){} // RVA: 0x7FFAC49C42B0
        public void LogSafeModeReport(){} // RVA: 0x7FFAC49C4410
        public void LogInvalidTween(){} // RVA: 0x7FFAC49C4570
        public void LogNestedTween(){} // RVA: 0x7FFAC49C45B0
        public void LogNullTween(){} // RVA: 0x7FFAC49C4600
        public void LogNonPathTween(){} // RVA: 0x7FFAC49C4640
        public void LogMissingMaterialProperty(){} // RVA: 0x7FFAC49C4720 | overloaded x2
        public void LogRemoveActiveTweenError(){} // RVA: 0x7FFAC49C47D0
        public void LogAddActiveTweenError(){} // RVA: 0x7FFAC49C4870
        public void SetLogPriority(){} // RVA: 0x7FFAC49C4910
    }

    public class Extensions : Object
    {
        // ── Methods ──
        public void SetSpecialStartupMode(){} // RVA: 0x7FFAC2E8DC40
        public void Blendable(){} // RVA: 0x7FFAC2C58F80
        public void NoFrom(){} // RVA: 0x7FFAC2C58F80
    }

    public class SafeModeReport : ValueType
    {
        public int totMissingTargetOrFieldErrors; // 0x10
        public int totCallbackErrors; // 0x14
        public int totStartupErrors; // 0x18
        public int totUnsetErrors; // 0x1C

        // ── Methods ──
        public void get_totMissingTargetOrFieldErrors(){} // RVA: 0x7FFAC4420210
        public void set_totMissingTargetOrFieldErrors(){} // RVA: 0x7FFAC336D8B0
        public void get_totCallbackErrors(){} // RVA: 0x7FFAC44202A0
        public void set_totCallbackErrors(){} // RVA: 0x7FFAC4420230
        public void get_totStartupErrors(){} // RVA: 0x7FFAC49C7500
        public void set_totStartupErrors(){} // RVA: 0x7FFAC49C7510
        public void get_totUnsetErrors(){} // RVA: 0x7FFAC49C7520
        public void set_totUnsetErrors(){} // RVA: 0x7FFAC49C7530
        public void Add(){} // RVA: 0x7FFAC49C7540
        public void GetTotErrors(){} // RVA: 0x7FFAC49C7560
    }

    public class SequenceCallback : ABSSequentiable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC49C7570
    }

    public class TweenLink : Object
    {
        public UnityEngine.GameObject target; // 0x10
        public 0x6B26C5A8 behaviour; // 0x18
        public bool lastSeenActive; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC49C75D0
    }

    public class TweenManager : Object
    {
        public int _DefaultMaxTweeners;
        public int _DefaultMaxSequences;
        public string _MaxTweensReached;
        public float _EpsilonVsTimeCheck;
        public bool isUnityEditor;
        public bool isDebugBuild; // 0x1
        public int maxActive; // 0x4
        public int maxTweeners; // 0x8
        public int maxSequences; // 0xC
        public bool hasActiveTweens; // 0x10
        public bool hasActiveDefaultTweens; // 0x11
        public bool hasActiveLateTweens; // 0x12
        public bool hasActiveFixedTweens; // 0x13
        public bool hasActiveManualTweens; // 0x14
        public int totActiveTweens; // 0x18
        public int totActiveDefaultTweens; // 0x1C
        public int totActiveLateTweens; // 0x20
        public int totActiveFixedTweens; // 0x24
        public int totActiveManualTweens; // 0x28
        public int totActiveTweeners; // 0x2C
        public int totActiveSequences; // 0x30
        public int totPooledTweeners; // 0x34
        public int totPooledSequences; // 0x38
        public int totTweeners; // 0x3C
        public int totSequences; // 0x40
        public bool isUpdateLoop; // 0x44
        public DG.Tweening.Tween[] _activeTweens; // 0x48
        public DG.Tweening.Tween[] _pooledTweeners; // 0x50
        public System.Collections.Generic.Stack`1<DG.Tweening.Tween> _PooledSequences; // 0x58
        public System.Collections.Generic.List`1<DG.Tweening.Tween> _KillList; // 0x60
        public System.Collections.Generic.Dictionary`2<DG.Tweening.Tween,DG.Tweening.Core.TweenLink> _TweenLinks; // 0x68
        public int _totTweenLinks; // 0x70
        public int _maxActiveLookupId; // 0x74
        public bool _requiresActiveReorganization; // 0x78
        public int _reorganizeFromId; // 0x7C
        public int _minPooledTweenerId; // 0x80
        public int _maxPooledTweenerId; // 0x84
        public bool _despawnAllCalledFromUpdateLoopCallback; // 0x88

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC49C7690
        public void GetTweener(){} // RVA: 0x7FFAC2C58A90
        public void GetSequence(){} // RVA: 0x7FFAC49C7BD0
        public void SetUpdateType(){} // RVA: 0x7FFAC49C8090
        public void AddActiveTweenToSequence(){} // RVA: 0x7FFAC49C8370
        public void DespawnAll(){} // RVA: 0x7FFAC49C83C0
        public void Despawn(){} // RVA: 0x7FFAC49C8710
        public void PurgeAll(){} // RVA: 0x7FFAC49C8D90
        public void PurgePools(){} // RVA: 0x7FFAC49C90A0
        public void AddTweenLink(){} // RVA: 0x7FFAC49C91D0
        public void RemoveTweenLink(){} // RVA: 0x7FFAC49C9450
        public void ResetCapacities(){} // RVA: 0x7FFAC49C9550
        public void SetCapacities(){} // RVA: 0x7FFAC49C95A0
        public void Validate(){} // RVA: 0x7FFAC49C96D0
        public void Update(){} // RVA: 0x7FFAC49C98A0
        public void FilteredOperation(){} // RVA: 0x7FFAC49C9DA0
        public void Complete(){} // RVA: 0x7FFAC49CAB50
        public void Flip(){} // RVA: 0x7FFAC49CAC70
        public void ForceInit(){} // RVA: 0x7FFAC49CAC90
        public void Goto(){} // RVA: 0x7FFAC49CAD60
        public void Pause(){} // RVA: 0x7FFAC49CAE90
        public void Play(){} // RVA: 0x7FFAC49CAEE0
        public void PlayBackwards(){} // RVA: 0x7FFAC49CAF70
        public void PlayForward(){} // RVA: 0x7FFAC49CB180
        public void Restart(){} // RVA: 0x7FFAC49CB300
        public void Rewind(){} // RVA: 0x7FFAC49CB3F0
        public void SmoothRewind(){} // RVA: 0x7FFAC49CB5B0
        public void TogglePause(){} // RVA: 0x7FFAC49CB730
        public void TotalPooledTweens(){} // RVA: 0x7FFAC49CB840
        public void TotalPlayingTweens(){} // RVA: 0x7FFAC49CB8A0
        public void GetActiveTweens(){} // RVA: 0x7FFAC49CB9D0
        public void GetTweensById(){} // RVA: 0x7FFAC49CBBC0
        public void GetTweensByTarget(){} // RVA: 0x7FFAC49CBF10
        public void MarkForKilling(){} // RVA: 0x7FFAC49CC100
        public void EvaluateTweenLink(){} // RVA: 0x7FFAC49CC190
        public void AddActiveTween(){} // RVA: 0x7FFAC49CC630
        public void ReorganizeActiveTweens(){} // RVA: 0x7FFAC49CCA50
        public void DespawnActiveTweens(){} // RVA: 0x7FFAC49CCD20
        public void RemoveActiveTween(){} // RVA: 0x7FFAC49CCDF0
        public void ClearTweenArray(){} // RVA: 0x7FFAC49CD480
        public void IncreaseCapacities(){} // RVA: 0x7FFAC49CD530
        public void ManageOnRewindCallbackWhenAlreadyRewinded(){} // RVA: 0x7FFAC49CD780
    }

    public class TweenerCore`3 : Tweener
    {
        public T startValue;
        public T endValue;
        public T changeValue;
        public T plugOptions;
        public DG.Tweening.Core.DOGetter`1<U> getter;
        public DG.Tweening.Core.DOSetter`1<U> setter;
        public DG.Tweening.Plugins.Core.ABSTweenPlugin`3<U,T,T> tweenPlugin;
        public string _TxtCantChangeSequencedValues;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void ChangeStartValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ChangeEndValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void ChangeValues(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SetFrom(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void Validate(){} // RVA: 0x7FFAC2C59D00
        public void UpdateDelay(){} // RVA: 0x7FFAC2C6E9F0
        public void Startup(){} // RVA: 0x7FFAC2C59D00
        public void ApplyTween(){}
    }

    public class Utils : Object
    {
        public System.Reflection.Assembly[] _loadedAssemblies;
        public string[] _defAssembliesToQuery; // 0x8

        // ── Methods ──
        public void Vector3FromAngle(){} // RVA: 0x7FFAC49CD850
        public void Angle2D(){} // RVA: 0x7FFAC49CD8B0
        public void RotateAroundPivot(){} // RVA: 0x7FFAC49CD9B0
        public void Vector3AreApproximatelyEqual(){} // RVA: 0x7FFAC49CDBC0
        public void GetLooseScriptType(){} // RVA: 0x7FFAC49CDC20
        public void .cctor(){} // RVA: 0x7FFAC49CDFC0
    }

}