// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.UniTask.Cysharp.Threading.Tasks.Triggers
// Classes: 8
// Methods: 280

namespace ThirdParty.UniTask.Cysharp.Threading.Tasks.Triggers
{
    public class AsyncAwakeTrigger : AsyncTriggerBase`1
    {
        // ── Original Methods ──
        public void AwakeAsync(){} // RVA: 0x7ffaaef05f20
        public void .ctor(){} // RVA: 0x7ffaaef06030
    }

    public class AsyncDestroyTrigger : MonoBehaviour
    {
        public object cancellationTokenSource; // 0x33CA8C10
        public object CancellationToken; // 0x17000070

        // ── Original Methods ──
        public void get_CancellationToken(){} // RVA: 0x7ffaaef060a0
        public void Awake(){} // RVA: 0x7ffaa976fab0
        public void OnDestroy(){} // RVA: 0x7ffaaef06240
        public void OnDestroyAsync(){} // RVA: 0x7ffaaef062c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class AsyncStartTrigger : AsyncTriggerBase`1
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaaef06810
        public void StartAsync(){} // RVA: 0x7ffaaef068a0
        public void .ctor(){} // RVA: 0x7ffaaef069b0
    }

    public class AsyncTriggerBase`1 : MonoBehaviour
    {
        public object calledDestroy; // 0x30D412C0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa8660cc0
        public void OnDestroy(){} // RVA: 0x7ffaa8660cc0
        public void AddHandler(){} // RVA: 0x7ffaa8660d80
        public void RemoveHandler(){} // RVA: 0x7ffaa8660d80
        public void RaiseEvent(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetAsyncEnumerator(){}
    }

    public class AsyncTriggerBase`1 : MonoBehaviour
    {
        public object calledDestroy; // 0x33A59BB0

        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa967fb00
        public void OnDestroy(){} // RVA: 0x7ffaad425790
        public void AddHandler(){} // RVA: 0x7ffaad4257c0
        public void RemoveHandler(){} // RVA: 0x7ffaad4258e0
        public void RaiseEvent(){} // RVA: 0x7ffaad425a00
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetAsyncEnumerator(){} // RVA: 0x7ffaad4253f0
    }

    public class AsyncTriggerExtensions : Object
    {
        // ── Original Methods ──
        public void OnDestroyAsync(){} // RVA: 0x7ffaaeefe2c0
        public void OnDestroyAsync(){} // RVA: 0x7ffaaeefe2c0
        public void StartAsync(){} // RVA: 0x7ffaaeefe3d0
        public void StartAsync(){} // RVA: 0x7ffaaeefe3d0
        public void AwakeAsync(){} // RVA: 0x7ffaaeefe5c0
        public void AwakeAsync(){} // RVA: 0x7ffaaeefe5c0
        // ── Binary Analysis Named ──
        public void GetAsyncAwakeTrigger(){} // RVA: 0x7ffaaeefddb0
        public void GetAsyncAwakeTrigger(){} // RVA: 0x7ffaaeefddb0
        public void GetAsyncDestroyTrigger(){} // RVA: 0x7ffaaeefdf50
        public void GetAsyncDestroyTrigger(){} // RVA: 0x7ffaaeefdf50
        public void GetAsyncStartTrigger(){} // RVA: 0x7ffaaeefe0f0
        public void GetAsyncStartTrigger(){} // RVA: 0x7ffaaeefe0f0
        public void GetOrAddComponent(){} // RVA: 0x7ffaa887e5c0
        public void GetAsyncFixedUpdateTrigger(){} // RVA: 0x7ffaaeefe780
        public void GetAsyncFixedUpdateTrigger(){} // RVA: 0x7ffaaeefe780
        public void GetAsyncLateUpdateTrigger(){} // RVA: 0x7ffaaeefe920
        public void GetAsyncLateUpdateTrigger(){} // RVA: 0x7ffaaeefe920
        public void GetAsyncAnimatorIKTrigger(){} // RVA: 0x7ffaaeefeac0
        public void GetAsyncAnimatorIKTrigger(){} // RVA: 0x7ffaaeefeac0
        public void GetAsyncAnimatorMoveTrigger(){} // RVA: 0x7ffaaeefec60
        public void GetAsyncAnimatorMoveTrigger(){} // RVA: 0x7ffaaeefec60
        public void GetAsyncApplicationFocusTrigger(){} // RVA: 0x7ffaaeefee00
        public void GetAsyncApplicationFocusTrigger(){} // RVA: 0x7ffaaeefee00
        public void GetAsyncApplicationPauseTrigger(){} // RVA: 0x7ffaaeefefa0
        public void GetAsyncApplicationPauseTrigger(){} // RVA: 0x7ffaaeefefa0
        public void GetAsyncApplicationQuitTrigger(){} // RVA: 0x7ffaaeeff140
        public void GetAsyncApplicationQuitTrigger(){} // RVA: 0x7ffaaeeff140
        public void GetAsyncAudioFilterReadTrigger(){} // RVA: 0x7ffaaeeff2e0
        public void GetAsyncAudioFilterReadTrigger(){} // RVA: 0x7ffaaeeff2e0
        public void GetAsyncBecameInvisibleTrigger(){} // RVA: 0x7ffaaeeff480
        public void GetAsyncBecameInvisibleTrigger(){} // RVA: 0x7ffaaeeff480
        public void GetAsyncBecameVisibleTrigger(){} // RVA: 0x7ffaaeeff620
        public void GetAsyncBecameVisibleTrigger(){} // RVA: 0x7ffaaeeff620
        public void GetAsyncBeforeTransformParentChangedTrigger(){} // RVA: 0x7ffaaeeff7c0
        public void GetAsyncBeforeTransformParentChangedTrigger(){} // RVA: 0x7ffaaeeff7c0
        public void GetAsyncOnCanvasGroupChangedTrigger(){} // RVA: 0x7ffaaeeff960
        public void GetAsyncOnCanvasGroupChangedTrigger(){} // RVA: 0x7ffaaeeff960
        public void GetAsyncCollisionEnterTrigger(){} // RVA: 0x7ffaaeeffb00
        public void GetAsyncCollisionEnterTrigger(){} // RVA: 0x7ffaaeeffb00
        public void GetAsyncCollisionEnter2DTrigger(){} // RVA: 0x7ffaaeeffca0
        public void GetAsyncCollisionEnter2DTrigger(){} // RVA: 0x7ffaaeeffca0
        public void GetAsyncCollisionExitTrigger(){} // RVA: 0x7ffaaeeffe40
        public void GetAsyncCollisionExitTrigger(){} // RVA: 0x7ffaaeeffe40
        public void GetAsyncCollisionExit2DTrigger(){} // RVA: 0x7ffaaeefffe0
        public void GetAsyncCollisionExit2DTrigger(){} // RVA: 0x7ffaaeefffe0
        public void GetAsyncCollisionStayTrigger(){} // RVA: 0x7ffaaef00180
        public void GetAsyncCollisionStayTrigger(){} // RVA: 0x7ffaaef00180
        public void GetAsyncCollisionStay2DTrigger(){} // RVA: 0x7ffaaef00320
        public void GetAsyncCollisionStay2DTrigger(){} // RVA: 0x7ffaaef00320
        public void GetAsyncControllerColliderHitTrigger(){} // RVA: 0x7ffaaef004c0
        public void GetAsyncControllerColliderHitTrigger(){} // RVA: 0x7ffaaef004c0
        public void GetAsyncDisableTrigger(){} // RVA: 0x7ffaaef00660
        public void GetAsyncDisableTrigger(){} // RVA: 0x7ffaaef00660
        public void GetAsyncDrawGizmosTrigger(){} // RVA: 0x7ffaaef00800
        public void GetAsyncDrawGizmosTrigger(){} // RVA: 0x7ffaaef00800
        public void GetAsyncDrawGizmosSelectedTrigger(){} // RVA: 0x7ffaaef009a0
        public void GetAsyncDrawGizmosSelectedTrigger(){} // RVA: 0x7ffaaef009a0
        public void GetAsyncEnableTrigger(){} // RVA: 0x7ffaaef00b40
        public void GetAsyncEnableTrigger(){} // RVA: 0x7ffaaef00b40
        public void GetAsyncGUITrigger(){} // RVA: 0x7ffaaef00ce0
        public void GetAsyncGUITrigger(){} // RVA: 0x7ffaaef00ce0
        public void GetAsyncJointBreakTrigger(){} // RVA: 0x7ffaaef00e80
        public void GetAsyncJointBreakTrigger(){} // RVA: 0x7ffaaef00e80
        public void GetAsyncJointBreak2DTrigger(){} // RVA: 0x7ffaaef01020
        public void GetAsyncJointBreak2DTrigger(){} // RVA: 0x7ffaaef01020
        public void GetAsyncMouseDownTrigger(){} // RVA: 0x7ffaaef011c0
        public void GetAsyncMouseDownTrigger(){} // RVA: 0x7ffaaef011c0
        public void GetAsyncMouseDragTrigger(){} // RVA: 0x7ffaaef01360
        public void GetAsyncMouseDragTrigger(){} // RVA: 0x7ffaaef01360
        public void GetAsyncMouseEnterTrigger(){} // RVA: 0x7ffaaef01500
        public void GetAsyncMouseEnterTrigger(){} // RVA: 0x7ffaaef01500
        public void GetAsyncMouseExitTrigger(){} // RVA: 0x7ffaaef016a0
        public void GetAsyncMouseExitTrigger(){} // RVA: 0x7ffaaef016a0
        public void GetAsyncMouseOverTrigger(){} // RVA: 0x7ffaaef01840
        public void GetAsyncMouseOverTrigger(){} // RVA: 0x7ffaaef01840
        public void GetAsyncMouseUpTrigger(){} // RVA: 0x7ffaaef019e0
        public void GetAsyncMouseUpTrigger(){} // RVA: 0x7ffaaef019e0
        public void GetAsyncMouseUpAsButtonTrigger(){} // RVA: 0x7ffaaef01b80
        public void GetAsyncMouseUpAsButtonTrigger(){} // RVA: 0x7ffaaef01b80
        public void GetAsyncParticleCollisionTrigger(){} // RVA: 0x7ffaaef01d20
        public void GetAsyncParticleCollisionTrigger(){} // RVA: 0x7ffaaef01d20
        public void GetAsyncParticleSystemStoppedTrigger(){} // RVA: 0x7ffaaef01ec0
        public void GetAsyncParticleSystemStoppedTrigger(){} // RVA: 0x7ffaaef01ec0
        public void GetAsyncParticleTriggerTrigger(){} // RVA: 0x7ffaaef02060
        public void GetAsyncParticleTriggerTrigger(){} // RVA: 0x7ffaaef02060
        public void GetAsyncParticleUpdateJobScheduledTrigger(){} // RVA: 0x7ffaaef02200
        public void GetAsyncParticleUpdateJobScheduledTrigger(){} // RVA: 0x7ffaaef02200
        public void GetAsyncPostRenderTrigger(){} // RVA: 0x7ffaaef023a0
        public void GetAsyncPostRenderTrigger(){} // RVA: 0x7ffaaef023a0
        public void GetAsyncPreCullTrigger(){} // RVA: 0x7ffaaef02540
        public void GetAsyncPreCullTrigger(){} // RVA: 0x7ffaaef02540
        public void GetAsyncPreRenderTrigger(){} // RVA: 0x7ffaaef026e0
        public void GetAsyncPreRenderTrigger(){} // RVA: 0x7ffaaef026e0
        public void GetAsyncRectTransformDimensionsChangeTrigger(){} // RVA: 0x7ffaaef02880
        public void GetAsyncRectTransformDimensionsChangeTrigger(){} // RVA: 0x7ffaaef02880
        public void GetAsyncRectTransformRemovedTrigger(){} // RVA: 0x7ffaaef02a20
        public void GetAsyncRectTransformRemovedTrigger(){} // RVA: 0x7ffaaef02a20
        public void GetAsyncRenderImageTrigger(){} // RVA: 0x7ffaaef02bc0
        public void GetAsyncRenderImageTrigger(){} // RVA: 0x7ffaaef02bc0
        public void GetAsyncRenderObjectTrigger(){} // RVA: 0x7ffaaef02d60
        public void GetAsyncRenderObjectTrigger(){} // RVA: 0x7ffaaef02d60
        public void GetAsyncServerInitializedTrigger(){} // RVA: 0x7ffaaef02f00
        public void GetAsyncServerInitializedTrigger(){} // RVA: 0x7ffaaef02f00
        public void GetAsyncTransformChildrenChangedTrigger(){} // RVA: 0x7ffaaef030a0
        public void GetAsyncTransformChildrenChangedTrigger(){} // RVA: 0x7ffaaef030a0
        public void GetAsyncTransformParentChangedTrigger(){} // RVA: 0x7ffaaef03240
        public void GetAsyncTransformParentChangedTrigger(){} // RVA: 0x7ffaaef03240
        public void GetAsyncTriggerEnterTrigger(){} // RVA: 0x7ffaaef033e0
        public void GetAsyncTriggerEnterTrigger(){} // RVA: 0x7ffaaef033e0
        public void GetAsyncTriggerEnter2DTrigger(){} // RVA: 0x7ffaaef03580
        public void GetAsyncTriggerEnter2DTrigger(){} // RVA: 0x7ffaaef03580
        public void GetAsyncTriggerExitTrigger(){} // RVA: 0x7ffaaef03720
        public void GetAsyncTriggerExitTrigger(){} // RVA: 0x7ffaaef03720
        public void GetAsyncTriggerExit2DTrigger(){} // RVA: 0x7ffaaef038c0
        public void GetAsyncTriggerExit2DTrigger(){} // RVA: 0x7ffaaef038c0
        public void GetAsyncTriggerStayTrigger(){} // RVA: 0x7ffaaef03a60
        public void GetAsyncTriggerStayTrigger(){} // RVA: 0x7ffaaef03a60
        public void GetAsyncTriggerStay2DTrigger(){} // RVA: 0x7ffaaef03c00
        public void GetAsyncTriggerStay2DTrigger(){} // RVA: 0x7ffaaef03c00
        public void GetAsyncValidateTrigger(){} // RVA: 0x7ffaaef03da0
        public void GetAsyncValidateTrigger(){} // RVA: 0x7ffaaef03da0
        public void GetAsyncWillRenderObjectTrigger(){} // RVA: 0x7ffaaef03f40
        public void GetAsyncWillRenderObjectTrigger(){} // RVA: 0x7ffaaef03f40
        public void GetAsyncResetTrigger(){} // RVA: 0x7ffaaef040e0
        public void GetAsyncResetTrigger(){} // RVA: 0x7ffaaef040e0
        public void GetAsyncUpdateTrigger(){} // RVA: 0x7ffaaef04280
        public void GetAsyncUpdateTrigger(){} // RVA: 0x7ffaaef04280
        public void GetAsyncBeginDragTrigger(){} // RVA: 0x7ffaaef04420
        public void GetAsyncBeginDragTrigger(){} // RVA: 0x7ffaaef04420
        public void GetAsyncCancelTrigger(){} // RVA: 0x7ffaaef045c0
        public void GetAsyncCancelTrigger(){} // RVA: 0x7ffaaef045c0
        public void GetAsyncDeselectTrigger(){} // RVA: 0x7ffaaef04760
        public void GetAsyncDeselectTrigger(){} // RVA: 0x7ffaaef04760
        public void GetAsyncDragTrigger(){} // RVA: 0x7ffaaef04900
        public void GetAsyncDragTrigger(){} // RVA: 0x7ffaaef04900
        public void GetAsyncDropTrigger(){} // RVA: 0x7ffaaef04aa0
        public void GetAsyncDropTrigger(){} // RVA: 0x7ffaaef04aa0
        public void GetAsyncEndDragTrigger(){} // RVA: 0x7ffaaef04c40
        public void GetAsyncEndDragTrigger(){} // RVA: 0x7ffaaef04c40
        public void GetAsyncInitializePotentialDragTrigger(){} // RVA: 0x7ffaaef04de0
        public void GetAsyncInitializePotentialDragTrigger(){} // RVA: 0x7ffaaef04de0
        public void GetAsyncMoveTrigger(){} // RVA: 0x7ffaaef04f80
        public void GetAsyncMoveTrigger(){} // RVA: 0x7ffaaef04f80
        public void GetAsyncPointerClickTrigger(){} // RVA: 0x7ffaaef05120
        public void GetAsyncPointerClickTrigger(){} // RVA: 0x7ffaaef05120
        public void GetAsyncPointerDownTrigger(){} // RVA: 0x7ffaaef052c0
        public void GetAsyncPointerDownTrigger(){} // RVA: 0x7ffaaef052c0
        public void GetAsyncPointerEnterTrigger(){} // RVA: 0x7ffaaef05460
        public void GetAsyncPointerEnterTrigger(){} // RVA: 0x7ffaaef05460
        public void GetAsyncPointerExitTrigger(){} // RVA: 0x7ffaaef05600
        public void GetAsyncPointerExitTrigger(){} // RVA: 0x7ffaaef05600
        public void GetAsyncPointerUpTrigger(){} // RVA: 0x7ffaaef057a0
        public void GetAsyncPointerUpTrigger(){} // RVA: 0x7ffaaef057a0
        public void GetAsyncScrollTrigger(){} // RVA: 0x7ffaaef05940
        public void GetAsyncScrollTrigger(){} // RVA: 0x7ffaaef05940
        public void GetAsyncSelectTrigger(){} // RVA: 0x7ffaaef05ae0
        public void GetAsyncSelectTrigger(){} // RVA: 0x7ffaaef05ae0
        public void GetAsyncSubmitTrigger(){} // RVA: 0x7ffaaef05c80
        public void GetAsyncSubmitTrigger(){} // RVA: 0x7ffaaef05c80
        public void GetAsyncUpdateSelectedTrigger(){} // RVA: 0x7ffaaef05e20
        public void GetAsyncUpdateSelectedTrigger(){} // RVA: 0x7ffaaef05e20
    }

    public class AsyncTriggerHandler`1 : Object
    {
        public object cancellationToken; // 0x30D417B0
        public object callOnce; // 0x30D417B0
        public object _next; // 0x30D417B0, was: <Cysharp.Threading.Tasks.ITrig
        public object CancellationToken; // 0x17000074
        public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev; // 0x17000075
        public object Cysharp.Threading.Tasks.ITriggerHandler<T>.Next; // 0x17000076

        // ── Original Methods ──
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger.OneShotAsync(){} // RVA: 0x7ffaa8648be0
        public void get_CancellationToken(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7ffaa86491d0
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7ffaa8660d80
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7ffaa86491d0
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void CancellationCallback(){} // RVA: 0x7ffaa8660d50
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnNext(){} // RVA: 0x7ffaa887e5c0
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCanceled(){} // RVA: 0x7ffaa8660f30
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCompleted(){} // RVA: 0x7ffaa8660cc0
        public void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnError(){} // RVA: 0x7ffaa8660d80
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7ffaa8660eb0
        public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
        public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7ffaa8649ca0
        public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler.FixedUpdateAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler.LateUpdateAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler.OnAnimatorIKAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler.OnAnimatorMoveAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler.OnApplicationFocusAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler.OnApplicationPauseAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler.OnApplicationQuitAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler.OnAudioFilterReadAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler.OnBecameInvisibleAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler.OnBecameVisibleAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler.OnBeforeTransformParentChangedAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler.OnCanvasGroupChangedAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler.OnCollisionEnterAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler.OnCollisionExitAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler.OnCollisionExit2DAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler.OnCollisionStayAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler.OnCollisionStay2DAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler.OnControllerColliderHitAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler.OnDisableAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler.OnDrawGizmosAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler.OnDrawGizmosSelectedAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler.OnEnableAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler.OnGUIAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler.OnJointBreakAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler.OnJointBreak2DAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseDownHandler.OnMouseDownAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseDragHandler.OnMouseDragAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseEnterHandler.OnMouseEnterAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseExitHandler.OnMouseExitAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseOverHandler.OnMouseOverAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseUpHandler.OnMouseUpAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseUpAsButtonHandler.OnMouseUpAsButtonAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler.OnParticleCollisionAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler.OnParticleSystemStoppedAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler.OnParticleTriggerAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler.OnParticleUpdateJobScheduledAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler.OnPostRenderAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler.OnPreCullAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler.OnPreRenderAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler.OnRectTransformDimensionsChangeAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler.OnRectTransformRemovedAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler.OnRenderImageAsync(){}
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler.OnRenderObjectAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler.OnServerInitializedAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler.OnTransformChildrenChangedAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler.OnTransformParentChangedAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler.OnTriggerEnterAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler.OnTriggerEnter2DAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler.OnTriggerExitAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler.OnTriggerExit2DAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler.OnTriggerStayAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler.OnTriggerStay2DAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler.OnValidateAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler.OnWillRenderObjectAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler.ResetAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler.UpdateAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler.OnBeginDragAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler.OnCancelAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler.OnDeselectAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler.OnDragAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler.OnDropAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler.OnEndDragAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler.OnInitializePotentialDragAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler.OnMoveAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler.OnPointerClickAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler.OnPointerDownAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler.OnPointerEnterAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler.OnPointerExitAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler.OnPointerUpAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler.OnScrollAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler.OnSelectAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler.OnSubmitAsync(){} // RVA: 0x7ffaa8648be0
        public void Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler.OnUpdateSelectedAsync(){} // RVA: 0x7ffaa8648be0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

    public class IAsyncFixedUpdateHandler
    {
        // ── Original Methods ──
        public void FixedUpdateAsync(){} // RVA: 0x7ffaa8648be0
    }

}