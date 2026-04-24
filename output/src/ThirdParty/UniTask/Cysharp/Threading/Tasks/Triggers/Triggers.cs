// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Triggers
// Classes: 7
// Methods: 273

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Triggers
{
    public class AsyncAwakeTrigger : AsyncTriggerBase`1
    {
        // ── Methods ──
        public void AwakeAsync(){} // RVA: 0x7FFD54903F50
        public void .ctor(){} // RVA: 0x7FFD54904060
    }

    public class AsyncDestroyTrigger : MonoBehaviour
    {
        public object CancellationToken;

        // ── Methods ──
        public void get_CancellationToken(){} // RVA: 0x7FFD549040D0
        public void Awake(){} // RVA: 0x7FFD4F15BA70
        public void OnDestroy(){} // RVA: 0x7FFD54904270
        public void OnDestroyAsync(){} // RVA: 0x7FFD549042F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AsyncStartTrigger : AsyncTriggerBase`1
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54904840
        public void StartAsync(){} // RVA: 0x7FFD549048D0
        public void .ctor(){} // RVA: 0x7FFD549049E0
    }

    public class AsyncTriggerBase`1 : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E090980
        public void OnDestroy(){} // RVA: 0x7FFD4E090980
        public void AddHandler(){} // RVA: 0x7FFD4E090A40
        public void RemoveHandler(){} // RVA: 0x7FFD4E090A40
        public void RaiseEvent(){} // RVA: 0x7FFD4E2ADC40
        public void GetAsyncEnumerator(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class AsyncTriggerExtensions : Object
    {
        // ── Methods ──
        public void GetAsyncAwakeTrigger(){} // RVA: 0x7FFD548FBDE0 | overloaded x2
        public void GetAsyncDestroyTrigger(){} // RVA: 0x7FFD548FBF80 | overloaded x2
        public void GetAsyncStartTrigger(){} // RVA: 0x7FFD548FC120 | overloaded x2
        public void GetOrAddComponent(){} // RVA: 0x7FFD4E2ADC40
        public void OnDestroyAsync(){} // RVA: 0x7FFD548FC2F0 | overloaded x2
        public void StartAsync(){} // RVA: 0x7FFD548FC400 | overloaded x2
        public void AwakeAsync(){} // RVA: 0x7FFD548FC5F0 | overloaded x2
        public void GetAsyncFixedUpdateTrigger(){} // RVA: 0x7FFD548FC7B0 | overloaded x2
        public void GetAsyncLateUpdateTrigger(){} // RVA: 0x7FFD548FC950 | overloaded x2
        public void GetAsyncAnimatorIKTrigger(){} // RVA: 0x7FFD548FCAF0 | overloaded x2
        public void GetAsyncAnimatorMoveTrigger(){} // RVA: 0x7FFD548FCC90 | overloaded x2
        public void GetAsyncApplicationFocusTrigger(){} // RVA: 0x7FFD548FCE30 | overloaded x2
        public void GetAsyncApplicationPauseTrigger(){} // RVA: 0x7FFD548FCFD0 | overloaded x2
        public void GetAsyncApplicationQuitTrigger(){} // RVA: 0x7FFD548FD170 | overloaded x2
        public void GetAsyncAudioFilterReadTrigger(){} // RVA: 0x7FFD548FD310 | overloaded x2
        public void GetAsyncBecameInvisibleTrigger(){} // RVA: 0x7FFD548FD4B0 | overloaded x2
        public void GetAsyncBecameVisibleTrigger(){} // RVA: 0x7FFD548FD650 | overloaded x2
        public void GetAsyncBeforeTransformParentChangedTrigger(){} // RVA: 0x7FFD548FD7F0 | overloaded x2
        public void GetAsyncOnCanvasGroupChangedTrigger(){} // RVA: 0x7FFD548FD990 | overloaded x2
        public void GetAsyncCollisionEnterTrigger(){} // RVA: 0x7FFD548FDB30 | overloaded x2
        public void GetAsyncCollisionEnter2DTrigger(){} // RVA: 0x7FFD548FDCD0 | overloaded x2
        public void GetAsyncCollisionExitTrigger(){} // RVA: 0x7FFD548FDE70 | overloaded x2
        public void GetAsyncCollisionExit2DTrigger(){} // RVA: 0x7FFD548FE010 | overloaded x2
        public void GetAsyncCollisionStayTrigger(){} // RVA: 0x7FFD548FE1B0 | overloaded x2
        public void GetAsyncCollisionStay2DTrigger(){} // RVA: 0x7FFD548FE350 | overloaded x2
        public void GetAsyncControllerColliderHitTrigger(){} // RVA: 0x7FFD548FE4F0 | overloaded x2
        public void GetAsyncDisableTrigger(){} // RVA: 0x7FFD548FE690 | overloaded x2
        public void GetAsyncDrawGizmosTrigger(){} // RVA: 0x7FFD548FE830 | overloaded x2
        public void GetAsyncDrawGizmosSelectedTrigger(){} // RVA: 0x7FFD548FE9D0 | overloaded x2
        public void GetAsyncEnableTrigger(){} // RVA: 0x7FFD548FEB70 | overloaded x2
        public void GetAsyncGUITrigger(){} // RVA: 0x7FFD548FED10 | overloaded x2
        public void GetAsyncJointBreakTrigger(){} // RVA: 0x7FFD548FEEB0 | overloaded x2
        public void GetAsyncJointBreak2DTrigger(){} // RVA: 0x7FFD548FF050 | overloaded x2
        public void GetAsyncMouseDownTrigger(){} // RVA: 0x7FFD548FF1F0 | overloaded x2
        public void GetAsyncMouseDragTrigger(){} // RVA: 0x7FFD548FF390 | overloaded x2
        public void GetAsyncMouseEnterTrigger(){} // RVA: 0x7FFD548FF530 | overloaded x2
        public void GetAsyncMouseExitTrigger(){} // RVA: 0x7FFD548FF6D0 | overloaded x2
        public void GetAsyncMouseOverTrigger(){} // RVA: 0x7FFD548FF870 | overloaded x2
        public void GetAsyncMouseUpTrigger(){} // RVA: 0x7FFD548FFA10 | overloaded x2
        public void GetAsyncMouseUpAsButtonTrigger(){} // RVA: 0x7FFD548FFBB0 | overloaded x2
        public void GetAsyncParticleCollisionTrigger(){} // RVA: 0x7FFD548FFD50 | overloaded x2
        public void GetAsyncParticleSystemStoppedTrigger(){} // RVA: 0x7FFD548FFEF0 | overloaded x2
        public void GetAsyncParticleTriggerTrigger(){} // RVA: 0x7FFD54900090 | overloaded x2
        public void GetAsyncParticleUpdateJobScheduledTrigger(){} // RVA: 0x7FFD54900230 | overloaded x2
        public void GetAsyncPostRenderTrigger(){} // RVA: 0x7FFD549003D0 | overloaded x2
        public void GetAsyncPreCullTrigger(){} // RVA: 0x7FFD54900570 | overloaded x2
        public void GetAsyncPreRenderTrigger(){} // RVA: 0x7FFD54900710 | overloaded x2
        public void GetAsyncRectTransformDimensionsChangeTrigger(){} // RVA: 0x7FFD549008B0 | overloaded x2
        public void GetAsyncRectTransformRemovedTrigger(){} // RVA: 0x7FFD54900A50 | overloaded x2
        public void GetAsyncRenderImageTrigger(){} // RVA: 0x7FFD54900BF0 | overloaded x2
        public void GetAsyncRenderObjectTrigger(){} // RVA: 0x7FFD54900D90 | overloaded x2
        public void GetAsyncServerInitializedTrigger(){} // RVA: 0x7FFD54900F30 | overloaded x2
        public void GetAsyncTransformChildrenChangedTrigger(){} // RVA: 0x7FFD549010D0 | overloaded x2
        public void GetAsyncTransformParentChangedTrigger(){} // RVA: 0x7FFD54901270 | overloaded x2
        public void GetAsyncTriggerEnterTrigger(){} // RVA: 0x7FFD54901410 | overloaded x2
        public void GetAsyncTriggerEnter2DTrigger(){} // RVA: 0x7FFD549015B0 | overloaded x2
        public void GetAsyncTriggerExitTrigger(){} // RVA: 0x7FFD54901750 | overloaded x2
        public void GetAsyncTriggerExit2DTrigger(){} // RVA: 0x7FFD549018F0 | overloaded x2
        public void GetAsyncTriggerStayTrigger(){} // RVA: 0x7FFD54901A90 | overloaded x2
        public void GetAsyncTriggerStay2DTrigger(){} // RVA: 0x7FFD54901C30 | overloaded x2
        public void GetAsyncValidateTrigger(){} // RVA: 0x7FFD54901DD0 | overloaded x2
        public void GetAsyncWillRenderObjectTrigger(){} // RVA: 0x7FFD54901F70 | overloaded x2
        public void GetAsyncResetTrigger(){} // RVA: 0x7FFD54902110 | overloaded x2
        public void GetAsyncUpdateTrigger(){} // RVA: 0x7FFD549022B0 | overloaded x2
        public void GetAsyncBeginDragTrigger(){} // RVA: 0x7FFD54902450 | overloaded x2
        public void GetAsyncCancelTrigger(){} // RVA: 0x7FFD549025F0 | overloaded x2
        public void GetAsyncDeselectTrigger(){} // RVA: 0x7FFD54902790 | overloaded x2
        public void GetAsyncDragTrigger(){} // RVA: 0x7FFD54902930 | overloaded x2
        public void GetAsyncDropTrigger(){} // RVA: 0x7FFD54902AD0 | overloaded x2
        public void GetAsyncEndDragTrigger(){} // RVA: 0x7FFD54902C70 | overloaded x2
        public void GetAsyncInitializePotentialDragTrigger(){} // RVA: 0x7FFD54902E10 | overloaded x2
        public void GetAsyncMoveTrigger(){} // RVA: 0x7FFD54902FB0 | overloaded x2
        public void GetAsyncPointerClickTrigger(){} // RVA: 0x7FFD54903150 | overloaded x2
        public void GetAsyncPointerDownTrigger(){} // RVA: 0x7FFD549032F0 | overloaded x2
        public void GetAsyncPointerEnterTrigger(){} // RVA: 0x7FFD54903490 | overloaded x2
        public void GetAsyncPointerExitTrigger(){} // RVA: 0x7FFD54903630 | overloaded x2
        public void GetAsyncPointerUpTrigger(){} // RVA: 0x7FFD549037D0 | overloaded x2
        public void GetAsyncScrollTrigger(){} // RVA: 0x7FFD54903970 | overloaded x2
        public void GetAsyncSelectTrigger(){} // RVA: 0x7FFD54903B10 | overloaded x2
        public void GetAsyncSubmitTrigger(){} // RVA: 0x7FFD54903CB0 | overloaded x2
        public void GetAsyncUpdateSelectedTrigger(){} // RVA: 0x7FFD54903E50 | overloaded x2
    }

    public class AsyncTriggerHandler`1 : Object
    {
        public object CancellationToken;
        public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev;
        public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Next;

        // ── Methods ──
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger.OneShotAsync(){} // RVA: 0x7FFD4E0788A0
        public void get_CancellationToken(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7FFD4E078E90
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7FFD4E090A40
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7FFD4E078E90
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CancellationCallback(){} // RVA: 0x7FFD4E090A10
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnNext(){} // RVA: 0x7FFD4E2ADC40
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCanceled(){} // RVA: 0x7FFD4E090BF0
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCompleted(){} // RVA: 0x7FFD4E090980
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnError(){} // RVA: 0x7FFD4E090A40
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler.FixedUpdateAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler.LateUpdateAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler.OnAnimatorIKAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler.OnAnimatorMoveAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler.OnApplicationFocusAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler.OnApplicationPauseAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler.OnApplicationQuitAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler.OnAudioFilterReadAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler.OnBecameInvisibleAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler.OnBecameVisibleAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler.OnBeforeTransformParentChangedAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler.OnCanvasGroupChangedAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler.OnCollisionEnterAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler.OnCollisionExitAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler.OnCollisionExit2DAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler.OnCollisionStayAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler.OnCollisionStay2DAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler.OnControllerColliderHitAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler.OnDisableAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler.OnDrawGizmosAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler.OnDrawGizmosSelectedAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler.OnEnableAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler.OnGUIAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler.OnJointBreakAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler.OnJointBreak2DAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseDownHandler.OnMouseDownAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseDragHandler.OnMouseDragAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseEnterHandler.OnMouseEnterAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseExitHandler.OnMouseExitAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseOverHandler.OnMouseOverAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseUpHandler.OnMouseUpAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseUpAsButtonHandler.OnMouseUpAsButtonAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler.OnParticleCollisionAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler.OnParticleSystemStoppedAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler.OnParticleTriggerAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler.OnParticleUpdateJobScheduledAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler.OnPostRenderAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler.OnPreCullAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler.OnPreRenderAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler.OnRectTransformDimensionsChangeAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler.OnRectTransformRemovedAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler.OnRenderImageAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler.OnRenderObjectAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler.OnServerInitializedAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler.OnTransformChildrenChangedAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler.OnTransformParentChangedAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler.OnTriggerEnterAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler.OnTriggerEnter2DAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler.OnTriggerExitAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler.OnTriggerExit2DAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler.OnTriggerStayAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler.OnTriggerStay2DAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler.OnValidateAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler.OnWillRenderObjectAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler.ResetAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler.UpdateAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler.OnBeginDragAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler.OnCancelAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler.OnDeselectAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler.OnDragAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler.OnDropAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler.OnEndDragAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler.OnInitializePotentialDragAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler.OnMoveAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler.OnPointerClickAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler.OnPointerDownAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler.OnPointerEnterAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler.OnPointerExitAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler.OnPointerUpAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler.OnScrollAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler.OnSelectAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler.OnSubmitAsync(){} // RVA: 0x7FFD4E0788A0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler.OnUpdateSelectedAsync(){} // RVA: 0x7FFD4E0788A0
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class IAsyncFixedUpdateHandler
    {
        // ── Methods ──
        public void FixedUpdateAsync(){} // RVA: 0x7FFD4E0788A0
    }

}