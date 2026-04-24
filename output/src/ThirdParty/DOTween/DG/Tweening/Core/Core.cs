// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DOTween.DG.Tweening.Core
// Classes: 13
// Methods: 125

namespace ThirdParty.DOTween.DG.Tweening.Core
{
    public class ABSSequentiable : Object
    {
        public 0x665CE498 tweenType; // 0x10
        public float sequencedPosition; // 0x14
        public float sequencedEndPosition; // 0x18
        public 0x665CC1E0 onStart; // 0x20

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
        public int inspectorUpdater; // 0x20
        public float _unscaledTime; // 0x24
        public float _unscaledDeltaTime; // 0x28
        public bool _paused; // 0x2C
        public float _pausedTime; // 0x30
        public bool _isQuitting; // 0x34
        public bool _duplicateToDestroy; // 0x35

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
        public System.Action`4<DG.Tweening.Plugins.Options.PathOptions,DG.Tweening.Tween,UnityEngine.Quaternion,UnityEngine.Transform> SetOrientationOnPath;

        // ── Methods ──
        public void add_SetOrientationOnPath(){} // RVA: 0x7FFD4FDE71B0
        public void remove_SetOrientationOnPath(){} // RVA: 0x7FFD4FDE72E0
        public void Dispatch_SetOrientationOnPath(){} // RVA: 0x7FFD4FDE7410
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
        public 0x665CFEB8 rewindCallbackMode; // 0x34
        public bool showUnityEditorReport; // 0x38
        public 0x665CE390 logBehaviour; // 0x3C
        public bool drawGizmos; // 0x40
        public bool defaultRecyclable; // 0x41
        public 0x665CC0D8 defaultAutoPlay; // 0x44
        public 0x665CE4F0 defaultUpdateType; // 0x48
        public bool defaultTimeScaleIndependent; // 0x4C
        public 0x665CC448 defaultEaseType; // 0x50
        public float defaultEaseOvershootOrAmplitude; // 0x54
        public float defaultEasePeriod; // 0x58
        public bool defaultAutoKill; // 0x5C
        public 0x665CC7B8 defaultLoopType; // 0x60
        public bool debugMode; // 0x64
        public bool debugStoreTargetId; // 0x65
        public bool showPreviewPanel; // 0x66
        public 0x665CF7D8 storeSettingsLocation; // 0x68
        public ModulesSetup modules; // 0x70
        public bool showPlayingTweens; // 0x78
        public bool showPausedTweens; // 0x79

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FDE7050
    }

    public class Debugger : Object
    {
        public int logPriority;
        public string _LogPrefix;

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
        public int totMissingTargetOrFieldErrors; // 0x10
        public int totCallbackErrors; // 0x14
        public int totStartupErrors; // 0x18
        public int totUnsetErrors; // 0x1C

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
        public UnityEngine.GameObject target; // 0x10
        public 0x665CC5A8 behaviour; // 0x18
        public bool lastSeenActive; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FDE75D0
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
        public UnityEngine.Vector3[] startValue; // 0x128
        public UnityEngine.Vector3[] endValue; // 0x130
        public UnityEngine.Vector3[] changeValue; // 0x138
        public DG.Tweening.Plugins.Options.Vector3ArrayOptions plugOptions; // 0x140
        public DG.Tweening.Core.DOGetter`1<UnityEngine.Vector3> getter; // 0x150
        public DG.Tweening.Core.DOSetter`1<UnityEngine.Vector3> setter; // 0x158
        public DG.Tweening.Plugins.Core.ABSTweenPlugin`3<UnityEngine.Vector3,UnityEngine.Vector3[],DG.Tweening.Plugins.Options.Vector3ArrayOptions> tweenPlugin; // 0x160
        public string _TxtCantChangeSequencedValues;

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
        public System.Reflection.Assembly[] _loadedAssemblies;
        public string[] _defAssembliesToQuery; // 0x8

        // ── Methods ──
        public void Vector3FromAngle(){} // RVA: 0x7FFD4FDED850
        public void Angle2D(){} // RVA: 0x7FFD4FDED8B0
        public void RotateAroundPivot(){} // RVA: 0x7FFD4FDED9B0
        public void Vector3AreApproximatelyEqual(){} // RVA: 0x7FFD4FDEDBC0
        public void GetLooseScriptType(){} // RVA: 0x7FFD4FDEDC20
        public void .cctor(){} // RVA: 0x7FFD4FDEDFC0
    }

}