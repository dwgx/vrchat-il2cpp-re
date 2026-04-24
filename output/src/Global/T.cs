// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 76
// Methods: 445

public class T : Object
{
}

public class T0 : Object
{
}

public class T1 : Object
{
}

public class TCategoryName : Object
{
}

public class TEdge : Object
{
    public IntPoint Bot; // 0x10
    public IntPoint Curr; // 0x20
    public IntPoint Top; // 0x30
    public IntPoint Delta; // 0x40
    public double Dx; // 0x50
    public 0x6658C498 PolyTyp; // 0x58
    public 0x6658C5F8 Side; // 0x5C
    public int WindDelta; // 0x60
    public int WindCnt; // 0x64
    public int WindCnt2; // 0x68
    public int OutIdx; // 0x6C
    public TEdge Next; // 0x70
    public TEdge Prev; // 0x78
    public TEdge NextInLML; // 0x80
    public TEdge NextInAEL; // 0x88
    public TEdge PrevInAEL; // 0x90
    public TEdge NextInSEL; // 0x98
    public TEdge PrevInSEL; // 0xA0

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class TKey : Object
{
}

public class TOptions : Object
{
}

public class TResult : Object
{
}

public class TSource : Object
{
}

public class TState : Object
{
}

public class TValue : Object
{
}

public class TYPE : Object
{
}

public class TYPE2 : Object
{
}

public class TabbedCanvasContent : ValueType
{
    public ÎÌÏÎÌÏÍÎÎÏÌÎÏÏÍÏÏÏÏÎÍÎÌ button; // 0x10
    public UnityEngine.Canvas canvas; // 0x18
    public UnityEngine.UI.LayoutElement layout; // 0x20
}

public class TabbedContent : ValueType
{
    public ÎÌÏÎÌÏÍÎÎÏÌÎÏÏÍÏÏÏÏÎÍÎÌ button; // 0x10
    public UnityEngine.GameObject content; // 0x18
}

public class TableEntry : ValueType
{
    public UIntPtr function; // 0x10
    public UIntPtr state; // 0x18
}

public class TableRange : ValueType
{
    public int Start; // 0x10
    public int End; // 0x14
    public int Count; // 0x18
    public int IndexStart; // 0x1C
    public int IndexEnd; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD537B17B0
}

public class Tables : Object
{
    public Node<System.Type,{>[] _buckets; // 0x10
    public object[] _locks; // 0x18
    public int[] _countPerLock; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD51DF8200
}

public class Take : Object
{
    public System.IObserver`1<T> m_Observer;
    public int m_Remaining;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void OnCompleted(){} // RVA: 0x7FFD4E090980
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
}

public class TangoUpdate : ValueType
{
}

public class Target : ValueType
{
    public UnityEngine.Transform target; // 0x10
    public float weight; // 0x18
    public float radius; // 0x1C
}

public class TaskNode : Task`1
{
    public TaskNode Prev; // 0x58
    public TaskNode Next; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53AE47E0
    public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFD53AE4860
    public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFD4E341310
}

public class TaskSocketAsyncEventArgs`1 : SocketAsyncEventArgs
{
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<U> _builder;
    public bool _accessed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void GetCompletionResponsibility(){} // RVA: 0x7FFD4E2ADC40
}

public class Tasks : Object
{
    public 0x6643CD48 Loop;
    public 0x6643CD48 Invoke;
    public 0x6643CD48 ForkJoin;
}

public class TeleportDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD515B1FF0
    public void Invoke(){} // RVA: 0x7FFD515B2170
    public void BeginInvoke(){} // RVA: 0x7FFD574053E0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class TestClass : ValueType
{
    public int value; // 0x10
}

public class TextBackingContainer : ValueType
{
    public uint[] Capacity; // 0x10
    public int Count; // 0x18

    // ── Methods ──
    public void get_Capacity(){} // RVA: 0x7FFD512A6060
    public void get_Count(){} // RVA: 0x7FFD4FDE7500
    public void set_Count(){} // RVA: 0x7FFD4FDE7510
    public void get_Item(){} // RVA: 0x7FFD511D90C0
    public void set_Item(){} // RVA: 0x7FFD54BC0240
    public void .ctor(){} // RVA: 0x7FFD54BC02A0
    public void Resize(){} // RVA: 0x7FFD54BC0350
}

public class TextInputBase : VisualElement
{
    public UnityEngine.UIElements.TextElement textElement; // 0x3C8
    public 0x664794F0 textSelection; // 0x3D0
    public UnityEngine.UIElements.VisualElement textEdition; // 0x3D8
    public string originalText;
    public string isReadOnly; // 0x8
    public string maxLength; // 0x10
    public string maskChar; // 0x18
    public string isPasswordField; // 0x20
    public string isDragging; // 0x28
    public string text; // 0x30
    public string innerViewportUssClassName; // 0x38
    public string innerContentContainerUssClassName; // 0x40
    public bool <isDragging>k__BackingField; // 0x3E0
    public UnityEngine.Vector2 scrollOffset; // 0x3E4
    public bool m_ScrollViewWasClamped; // 0x3EC
    public UnityEngine.Vector2 lastCursorPos; // 0x3F0
    public 0x664792E0 m_VerticalScrollerVisibility; // 0x3F8

    // ── Methods ──
    public void get_textElement(){} // RVA: 0x7FFD4E078E90
    public void set_textElement(){} // RVA: 0x7FFD4E090A40
    public void get_textSelection(){} // RVA: 0x7FFD4E078E90
    public void get_textEdition(){} // RVA: 0x7FFD4E078E90
    public void SelectAll(){} // RVA: 0x7FFD4E090980
    public void SelectNone(){} // RVA: 0x7FFD4E090980
    public void get_originalText(){} // RVA: 0x7FFD4E078E90
    public void StringToValue(){} // RVA: 0x7FFD4E2ADC40
    public void UpdateValueFromText(){} // RVA: 0x7FFD4E090980
    public void UpdateTextFromValue(){} // RVA: 0x7FFD4E090980
    public void MoveFocusToCompositeRoot(){} // RVA: 0x7FFD4E090980
    public void get_isReadOnly(){} // RVA: 0x7FFD4E079D00
    public void set_maxLength(){} // RVA: 0x7FFD4E090ED0
    public void set_maskChar(){} // RVA: 0x7FFD4E090B70
    public void get_isPasswordField(){} // RVA: 0x7FFD4E079D00
    public void set_isPasswordField(){} // RVA: 0x7FFD4E091060
    public void set_isDragging(){} // RVA: 0x7FFD4E091060
    public void get_text(){} // RVA: 0x7FFD4E078E90
    public void set_text(){} // RVA: 0x7FFD4E090A40
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void MakeSureScrollViewDoesNotLeakEvents(){} // RVA: 0x7FFD4E090A40
    public void SetSingleLine(){} // RVA: 0x7FFD4E090980
    public void SetMultiline(){} // RVA: 0x7FFD4E090980
    public void ScrollViewOnGeometryChangedEvent(){} // RVA: 0x7FFD4E090A40
    public void TextElementOnGeometryChangedEvent(){} // RVA: 0x7FFD4E090A40
    public void OnInputCustomStyleResolved(){} // RVA: 0x7FFD4E090A40
    public void AcceptCharacter(){} // RVA: 0x7FFD4E07AB80
    public void UpdateScrollOffset(){} // RVA: 0x7FFD4E0910F0 | overloaded x2
    public void GetScrollOffset(){} // RVA: 0x7FFD4E2ADC40
    public void SetScrollViewMode(){} // RVA: 0x7FFD4E090980
    public void SetMultilineContainerStyle(){} // RVA: 0x7FFD4E090980
    public void RemoveSingleLineComponents(){} // RVA: 0x7FFD4E090980
    public void RemoveMultilineComponents(){} // RVA: 0x7FFD4E090980
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class TextSelectionEvent : UnityEvent`3
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54BA7040
}

public class TextValueInput : TextInputBase
{
    public string textValueFieldParent;

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x7FFD4E078E90
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void AcceptCharacter(){} // RVA: 0x7FFD4E07AB80
    public void get_allowedCharacters(){} // RVA: 0x7FFD4E078E90
    public void get_formatString(){} // RVA: 0x7FFD4E078E90
    public void set_formatString(){} // RVA: 0x7FFD4E090A40
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFD4E2ADC40
    public void StartDragging(){} // RVA: 0x7FFD4E090980
    public void StopDragging(){} // RVA: 0x7FFD4E090980
    public void ValueToString(){} // RVA: 0x7FFD4E2ADC40
    public void StringToValue(){} // RVA: 0x7FFD4E2ADC40
}

public class TextureChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54E15B10
    public void Invoke(){} // RVA: 0x7FFD54E15BF0
}

public class TextureSheetAnimationModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D6F360
    public void set_enabled(){} // RVA: 0x7FFD54D6F3B0
    public void get_mode(){} // RVA: 0x7FFD54D6F410
    public void set_mode(){} // RVA: 0x7FFD54D6F460
    public void get_timeMode(){} // RVA: 0x7FFD54D6F4C0
    public void set_timeMode(){} // RVA: 0x7FFD54D6F510
    public void get_fps(){} // RVA: 0x7FFD54D6F570
    public void set_fps(){} // RVA: 0x7FFD54D6F5C0
    public void get_numTilesX(){} // RVA: 0x7FFD54D6F620
    public void set_numTilesX(){} // RVA: 0x7FFD54D6F670
    public void get_numTilesY(){} // RVA: 0x7FFD54D6F6D0
    public void set_numTilesY(){} // RVA: 0x7FFD54D6F720
    public void get_animation(){} // RVA: 0x7FFD54D6F780
    public void set_animation(){} // RVA: 0x7FFD54D6F7D0
    public void get_rowMode(){} // RVA: 0x7FFD54D6F830
    public void set_rowMode(){} // RVA: 0x7FFD54D6F880
    public void get_frameOverTime(){} // RVA: 0x7FFD54D6F8E0
    public void set_frameOverTime(){} // RVA: 0x7FFD54D6F950
    public void get_frameOverTimeMultiplier(){} // RVA: 0x7FFD54D6F9B0
    public void set_frameOverTimeMultiplier(){} // RVA: 0x7FFD54D6FA00
    public void get_startFrame(){} // RVA: 0x7FFD54D6FA60
    public void set_startFrame(){} // RVA: 0x7FFD54D6FAD0
    public void get_startFrameMultiplier(){} // RVA: 0x7FFD54D6FB30
    public void set_startFrameMultiplier(){} // RVA: 0x7FFD54D6FB80
    public void get_cycleCount(){} // RVA: 0x7FFD54D6FBE0
    public void set_cycleCount(){} // RVA: 0x7FFD54D6FC30
    public void get_rowIndex(){} // RVA: 0x7FFD54D6FC90
    public void set_rowIndex(){} // RVA: 0x7FFD54D6FCE0
    public void get_uvChannelMask(){} // RVA: 0x7FFD54D6FD40
    public void set_uvChannelMask(){} // RVA: 0x7FFD54D6FD90
    public void get_spriteCount(){} // RVA: 0x7FFD54D6FDF0
    public void get_speedRange(){} // RVA: 0x7FFD54D6FE40
    public void set_speedRange(){} // RVA: 0x7FFD54D6FEA0
    public void AddSprite(){} // RVA: 0x7FFD54D6FF00
    public void RemoveSprite(){} // RVA: 0x7FFD54D6FF60
    public void SetSprite(){} // RVA: 0x7FFD54D6FFC0
    public void GetSprite(){} // RVA: 0x7FFD54D70030
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D6F360
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D6F3B0
    public void get_mode_Injected(){} // RVA: 0x7FFD54D6F410
    public void set_mode_Injected(){} // RVA: 0x7FFD54D6F460
    public void get_timeMode_Injected(){} // RVA: 0x7FFD54D6F4C0
    public void set_timeMode_Injected(){} // RVA: 0x7FFD54D6F510
    public void get_fps_Injected(){} // RVA: 0x7FFD54D6F570
    public void set_fps_Injected(){} // RVA: 0x7FFD54D6F5C0
    public void get_numTilesX_Injected(){} // RVA: 0x7FFD54D6F620
    public void set_numTilesX_Injected(){} // RVA: 0x7FFD54D6F670
    public void get_numTilesY_Injected(){} // RVA: 0x7FFD54D6F6D0
    public void set_numTilesY_Injected(){} // RVA: 0x7FFD54D6F720
    public void get_animation_Injected(){} // RVA: 0x7FFD54D6F780
    public void set_animation_Injected(){} // RVA: 0x7FFD54D6F7D0
    public void get_rowMode_Injected(){} // RVA: 0x7FFD54D6F830
    public void set_rowMode_Injected(){} // RVA: 0x7FFD54D6F880
    public void get_frameOverTime_Injected(){} // RVA: 0x7FFD54D70090
    public void set_frameOverTime_Injected(){} // RVA: 0x7FFD54D700F0
    public void get_frameOverTimeMultiplier_Injected(){} // RVA: 0x7FFD54D6F9B0
    public void set_frameOverTimeMultiplier_Injected(){} // RVA: 0x7FFD54D6FA00
    public void get_startFrame_Injected(){} // RVA: 0x7FFD54D70150
    public void set_startFrame_Injected(){} // RVA: 0x7FFD54D701B0
    public void get_startFrameMultiplier_Injected(){} // RVA: 0x7FFD54D6FB30
    public void set_startFrameMultiplier_Injected(){} // RVA: 0x7FFD54D6FB80
    public void get_cycleCount_Injected(){} // RVA: 0x7FFD54D6FBE0
    public void set_cycleCount_Injected(){} // RVA: 0x7FFD54D6FC30
    public void get_rowIndex_Injected(){} // RVA: 0x7FFD54D6FC90
    public void set_rowIndex_Injected(){} // RVA: 0x7FFD54D6FCE0
    public void get_uvChannelMask_Injected(){} // RVA: 0x7FFD54D6FD40
    public void set_uvChannelMask_Injected(){} // RVA: 0x7FFD54D6FD90
    public void get_spriteCount_Injected(){} // RVA: 0x7FFD54D6FDF0
    public void get_speedRange_Injected(){} // RVA: 0x7FFD54D70210
    public void set_speedRange_Injected(){} // RVA: 0x7FFD54D70270
    public void AddSprite_Injected(){} // RVA: 0x7FFD54D6FF00
    public void RemoveSprite_Injected(){} // RVA: 0x7FFD54D6FF60
    public void SetSprite_Injected(){} // RVA: 0x7FFD54D6FFC0
    public void GetSprite_Injected(){} // RVA: 0x7FFD54D70030
}

public class ThreadedLoadingDebug : ValueType
{
}

public class ThrowObservable`1 : Object
{
    public System.Exception value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Subscribe(){} // RVA: 0x7FFD4E078F40
}

public class TickCallbackDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E432370
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD54C2CDC0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class TimeEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FCBEAB0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class TimeRange : ValueType
{
    public float IsEmpty; // 0x10
    public float Empty; // 0x14

    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7FFD4FC71510
    public void Contains(){} // RVA: 0x7FFD4F959010
    public void get_Empty(){} // RVA: 0x7FFD4FC71520
    public void Include(){} // RVA: 0x7FFD4FC71540
}

public class TimerComparer : ValueType
{
    // ── Methods ──
    public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFD53AF7DD0
    public void Compare(){} // RVA: 0x7FFD53AF7ED0
}

public class TimerStateScheduledItem : VisualElementScheduledItem`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD550143B0
    public void PerformTimerUpdate(){} // RVA: 0x7FFD55014410
}

public class ToCoroutineEnumerator`1 : Object
{
    public bool Current;
    public System.Action`1<T> resultHandler;
    public System.Action`1<System.Exception> exceptionHandler;
    public bool isStarted;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public object current;
    public 0x66435CE0 exception;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void RunTask(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E078E90
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
}

public class ToRemoveData : ValueType
{
    public VRC.Dynamics.VRCPhysBoneBase comp; // 0x10
    public VRC.Dynamics.ChainId chainId; // 0x18
    public int executionGroup; // 0x28
    public Shape shape; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55263B40
}

public class ToUniTaskObserver`1 : Object
{
    public System.Action`1<object> callback;
    public Cysharp.Threading.Tasks.UniTaskCompletionSource`1<T> promise;
    public 0x665483F0 disposable;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration registration;
    public bool hasValue;
    public T latestValue;

    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFD4E090A10
    public void OnNext(){} // RVA: 0x7FFD4E2ADC40
    public void OnError(){} // RVA: 0x7FFD4E090A40
    public void OnCompleted(){} // RVA: 0x7FFD4E090980
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class ToggleEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5508EF90
}

public class Token : ValueType
{
    public object Type;
    public object IsNull; // 0x8
    public System.Collections.ICollection Boolean; // 0x10
    public System.ReadOnlyMemory`1<char> Number; // 0x10
    public string String; // 0x10
    public double StringInstance; // 0x18
    public bool Array; // 0x18
    public 0x66409970 Object; // 0x20
    public 0x664099C8 Value; // 0x21

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFD4E40B5E0
    public void get_IsNull(){} // RVA: 0x7FFD4EBE9990
    public void get_Boolean(){} // RVA: 0x7FFD57233250
    public void get_Number(){} // RVA: 0x7FFD57233320
    public void get_String(){} // RVA: 0x7FFD572333F0
    public void get_StringInstance(){} // RVA: 0x7FFD57233580
    public void get_Array(){} // RVA: 0x7FFD57233680
    public void get_Object(){} // RVA: 0x7FFD57233790
    public void get_Value(){} // RVA: 0x7FFD572338A0
    public void .ctor(){} // RVA: 0x7FFD57233C90 | overloaded x6
    public void op_Implicit(){} // RVA: 0x7FFD57233F80 | overloaded x6
    public void op_Explicit(){} // RVA: 0x7FFD57234200 | overloaded x6
    public void TryGetBool(){} // RVA: 0x7FFD57234250
    public void TryGetNumber(){} // RVA: 0x7FFD572342D0
    public void TryGetArray(){} // RVA: 0x7FFD57234380
    public void TryGetObject(){} // RVA: 0x7FFD572343E0
    public void TryGetString(){} // RVA: 0x7FFD57234440
    public void TryGetStringInstance(){} // RVA: 0x7FFD57234550
    public void TryFromObject(){} // RVA: 0x7FFD4E07A350
    public void FromObject(){} // RVA: 0x7FFD4E078980
    public void ToString(){} // RVA: 0x7FFD572345B0
    public void GetHashCode(){} // RVA: 0x7FFD57234760
    public void ToLegacyObject(){} // RVA: 0x7FFD57234940
    public void GetInnerType(){} // RVA: 0x7FFD57234B80
    public void CompareTo(){} // RVA: 0x7FFD57234D50
    public void Equals(){} // RVA: 0x7FFD572353A0 | overloaded x2
    public void op_Equality(){} // RVA: 0x7FFD57235470
    public void op_Inequality(){} // RVA: 0x7FFD57235500
    public void .cctor(){} // RVA: 0x7FFD57235570
}

public class TokenHashValue : Object
{
    public string tokenString; // 0x10
    public 0x6641F550 tokenType; // 0x18
    public int tokenValue; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD531EAE30
}

public class TouchScreenKeyboardEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54BA70D0
}

public class TrackAssetUpgrade : Object
{
}

public class TrackedPose : ValueType
{
    public UnityEngine.Vector3 Position; // 0x10
    public UnityEngine.Quaternion Rotation; // 0x1C
}

public class TrackingData : ValueType
{
    public UnityEngine.Vector3 position; // 0x10
    public UnityEngine.Quaternion rotation; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD52626E60
}

public class TrailModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D7B690
    public void set_enabled(){} // RVA: 0x7FFD54D7B6E0
    public void get_mode(){} // RVA: 0x7FFD54D7B740
    public void set_mode(){} // RVA: 0x7FFD54D7B790
    public void get_ratio(){} // RVA: 0x7FFD54D7B7F0
    public void set_ratio(){} // RVA: 0x7FFD54D7B840
    public void get_lifetime(){} // RVA: 0x7FFD54D7B8A0
    public void set_lifetime(){} // RVA: 0x7FFD54D7B910
    public void get_lifetimeMultiplier(){} // RVA: 0x7FFD54D7B970
    public void set_lifetimeMultiplier(){} // RVA: 0x7FFD54D7B9C0
    public void get_minVertexDistance(){} // RVA: 0x7FFD54D7BA20
    public void set_minVertexDistance(){} // RVA: 0x7FFD54D7BA70
    public void get_textureMode(){} // RVA: 0x7FFD54D7BAD0
    public void set_textureMode(){} // RVA: 0x7FFD54D7BB20
    public void get_textureScale(){} // RVA: 0x7FFD54D7BB80
    public void set_textureScale(){} // RVA: 0x7FFD54D7BBE0
    public void get_worldSpace(){} // RVA: 0x7FFD54D7BC40
    public void set_worldSpace(){} // RVA: 0x7FFD54D7BC90
    public void get_dieWithParticles(){} // RVA: 0x7FFD54D7BCF0
    public void set_dieWithParticles(){} // RVA: 0x7FFD54D7BD40
    public void get_sizeAffectsWidth(){} // RVA: 0x7FFD54D7BDA0
    public void set_sizeAffectsWidth(){} // RVA: 0x7FFD54D7BDF0
    public void get_sizeAffectsLifetime(){} // RVA: 0x7FFD54D7BE50
    public void set_sizeAffectsLifetime(){} // RVA: 0x7FFD54D7BEA0
    public void get_inheritParticleColor(){} // RVA: 0x7FFD54D7BF00
    public void set_inheritParticleColor(){} // RVA: 0x7FFD54D7BF50
    public void get_colorOverLifetime(){} // RVA: 0x7FFD54D7BFB0
    public void set_colorOverLifetime(){} // RVA: 0x7FFD54D7C030
    public void get_widthOverTrail(){} // RVA: 0x7FFD54D7C090
    public void set_widthOverTrail(){} // RVA: 0x7FFD54D7C100
    public void get_widthOverTrailMultiplier(){} // RVA: 0x7FFD54D7C160
    public void set_widthOverTrailMultiplier(){} // RVA: 0x7FFD54D7C1B0
    public void get_colorOverTrail(){} // RVA: 0x7FFD54D7C210
    public void set_colorOverTrail(){} // RVA: 0x7FFD54D7C290
    public void get_generateLightingData(){} // RVA: 0x7FFD54D7C2F0
    public void set_generateLightingData(){} // RVA: 0x7FFD54D7C340
    public void get_ribbonCount(){} // RVA: 0x7FFD54D7C3A0
    public void set_ribbonCount(){} // RVA: 0x7FFD54D7C3F0
    public void get_shadowBias(){} // RVA: 0x7FFD54D7C450
    public void set_shadowBias(){} // RVA: 0x7FFD54D7C4A0
    public void get_splitSubEmitterRibbons(){} // RVA: 0x7FFD54D7C500
    public void set_splitSubEmitterRibbons(){} // RVA: 0x7FFD54D7C550
    public void get_attachRibbonsToTransform(){} // RVA: 0x7FFD54D7C5B0
    public void set_attachRibbonsToTransform(){} // RVA: 0x7FFD54D7C600
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D7B690
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D7B6E0
    public void get_mode_Injected(){} // RVA: 0x7FFD54D7B740
    public void set_mode_Injected(){} // RVA: 0x7FFD54D7B790
    public void get_ratio_Injected(){} // RVA: 0x7FFD54D7B7F0
    public void set_ratio_Injected(){} // RVA: 0x7FFD54D7B840
    public void get_lifetime_Injected(){} // RVA: 0x7FFD54D7C660
    public void set_lifetime_Injected(){} // RVA: 0x7FFD54D7C6C0
    public void get_lifetimeMultiplier_Injected(){} // RVA: 0x7FFD54D7B970
    public void set_lifetimeMultiplier_Injected(){} // RVA: 0x7FFD54D7B9C0
    public void get_minVertexDistance_Injected(){} // RVA: 0x7FFD54D7BA20
    public void set_minVertexDistance_Injected(){} // RVA: 0x7FFD54D7BA70
    public void get_textureMode_Injected(){} // RVA: 0x7FFD54D7BAD0
    public void set_textureMode_Injected(){} // RVA: 0x7FFD54D7BB20
    public void get_textureScale_Injected(){} // RVA: 0x7FFD54D7C720
    public void set_textureScale_Injected(){} // RVA: 0x7FFD54D7C780
    public void get_worldSpace_Injected(){} // RVA: 0x7FFD54D7BC40
    public void set_worldSpace_Injected(){} // RVA: 0x7FFD54D7BC90
    public void get_dieWithParticles_Injected(){} // RVA: 0x7FFD54D7BCF0
    public void set_dieWithParticles_Injected(){} // RVA: 0x7FFD54D7BD40
    public void get_sizeAffectsWidth_Injected(){} // RVA: 0x7FFD54D7BDA0
    public void set_sizeAffectsWidth_Injected(){} // RVA: 0x7FFD54D7BDF0
    public void get_sizeAffectsLifetime_Injected(){} // RVA: 0x7FFD54D7BE50
    public void set_sizeAffectsLifetime_Injected(){} // RVA: 0x7FFD54D7BEA0
    public void get_inheritParticleColor_Injected(){} // RVA: 0x7FFD54D7BF00
    public void set_inheritParticleColor_Injected(){} // RVA: 0x7FFD54D7BF50
    public void get_colorOverLifetime_Injected(){} // RVA: 0x7FFD54D7C7E0
    public void set_colorOverLifetime_Injected(){} // RVA: 0x7FFD54D7C840
    public void get_widthOverTrail_Injected(){} // RVA: 0x7FFD54D7C8A0
    public void set_widthOverTrail_Injected(){} // RVA: 0x7FFD54D7C900
    public void get_widthOverTrailMultiplier_Injected(){} // RVA: 0x7FFD54D7C160
    public void set_widthOverTrailMultiplier_Injected(){} // RVA: 0x7FFD54D7C1B0
    public void get_colorOverTrail_Injected(){} // RVA: 0x7FFD54D7C960
    public void set_colorOverTrail_Injected(){} // RVA: 0x7FFD54D7C9C0
    public void get_generateLightingData_Injected(){} // RVA: 0x7FFD54D7C2F0
    public void set_generateLightingData_Injected(){} // RVA: 0x7FFD54D7C340
    public void get_ribbonCount_Injected(){} // RVA: 0x7FFD54D7C3A0
    public void set_ribbonCount_Injected(){} // RVA: 0x7FFD54D7C3F0
    public void get_shadowBias_Injected(){} // RVA: 0x7FFD54D7C450
    public void set_shadowBias_Injected(){} // RVA: 0x7FFD54D7C4A0
    public void get_splitSubEmitterRibbons_Injected(){} // RVA: 0x7FFD54D7C500
    public void set_splitSubEmitterRibbons_Injected(){} // RVA: 0x7FFD54D7C550
    public void get_attachRibbonsToTransform_Injected(){} // RVA: 0x7FFD54D7C5B0
    public void set_attachRibbonsToTransform_Injected(){} // RVA: 0x7FFD54D7C600
}

public class Trails : ValueType
{
    public System.Collections.Generic.List`1<UnityEngine.Vector4> positions; // 0x10
    public System.Collections.Generic.List`1<int> frontPositions; // 0x18
    public System.Collections.Generic.List`1<int> backPositions; // 0x20
    public System.Collections.Generic.List`1<int> positionCounts; // 0x28
    public System.Collections.Generic.List`1<float> textureOffsets; // 0x30
    public int maxTrailCount; // 0x38
    public int maxPositionsPerTrailCount; // 0x3C

    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFD54D71E70
}

public class TransformData : ValueType
{
    public Unity.Mathematics.float3 lossyScale;
    public Unity.Mathematics.float4x4 localToWorld; // 0x10
    public Unity.Mathematics.float3 position; // 0x50
    public Unity.Mathematics.quaternion rotation; // 0x5C
    public Unity.Mathematics.float3 localPosition; // 0x6C
    public Unity.Mathematics.quaternion localRotation; // 0x78
    public Unity.Mathematics.float3 localScale; // 0x88
    public Unity.Mathematics.float3 prevLocalPosition; // 0x94
    public Unity.Mathematics.quaternion prevLocalRotation; // 0xA0

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55262E00
    public void UpdateFromUnityTransform(){} // RVA: 0x7FFD552632C0
    public void UpdateGlobalTransform(){} // RVA: 0x7FFD55263820
    public void UpdateUnityTransform(){} // RVA: 0x7FFD55263970
    public void get_lossyScale(){} // RVA: 0x7FFD55263A30
    public void .cctor(){} // RVA: 0x7FFD55263AF0
}

public class TransformJobData : ValueType
{
    public UIntPtr TransformAccessArray; // 0x10
    public int IsReadOnly; // 0x18
}

public class TransformNoiseParams : ValueType
{
    public NoiseParams X; // 0x10
    public NoiseParams Y; // 0x1C
    public NoiseParams Z; // 0x28

    // ── Methods ──
    public void GetValueAt(){} // RVA: 0x7FFD4FC6D530
}

public class TransformParallelForLoopStruct`1 : ValueType
{
    public SharedStatic`1<UIntPtr> jobReflectionData;

    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFD4E0909B0
    public void Execute(){} // RVA: 0x7FFD4E099720
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class TransformState : ValueType
{
    public TransformState identity;
    public Unity.Mathematics.float3 position; // 0x10
    public Unity.Mathematics.quaternion rotation; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD52626E60
    public void ToMatrix(){} // RVA: 0x7FFD55262BD0
    public void Lerp(){} // RVA: 0x7FFD55262C60
    public void .cctor(){} // RVA: 0x7FFD55262D40
}

public class TransformSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD5749B060
    public void SetObjectData(){} // RVA: 0x7FFD5749B2D0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class TransientBuildData : ValueType
{
    public System.Collections.Generic.List`1<UnityEngine.Timeline.TrackAsset> trackList; // 0x10
    public System.Collections.Generic.List`1<UnityEngine.Timeline.TimelineClip> clipList; // 0x18
    public System.Collections.Generic.List`1<UnityEngine.Timeline.IMarker> markerList; // 0x20

    // ── Methods ──
    public void Create(){} // RVA: 0x7FFD54BE5D10
    public void Clear(){} // RVA: 0x7FFD54BE6060
}

public class TransitionEventsFrameState : Object
{
    public UnityEngine.Pool.ObjectPool`1<System.Collections.Generic.Queue`1<UnityEngine.UIElements.EventBase>> k_EventQueuePool;
    public System.Collections.Generic.Dictionary`2<ElementPropertyPair,0x66482D38> elementPropertyStateDelta;
    public System.Collections.Generic.Dictionary`2<ElementPropertyPair,System.Collections.Generic.Queue`1<UnityEngine.UIElements.EventBase>> elementPropertyQueuedEvents;
    public UnityEngine.UIElements.IPanel panel;
    public int m_ChangesCount;

    // ── Methods ──
    public void GetPooledQueue(){} // RVA: 0x7FFD4E078A90
    public void RegisterChange(){} // RVA: 0x7FFD4E090980
    public void UnregisterChange(){} // RVA: 0x7FFD4E090980
    public void StateChanged(){} // RVA: 0x7FFD4E079D00
    public void Clear(){} // RVA: 0x7FFD4E090980
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class TransitionParams : ValueType
{
    public 0x6658AE40 m_BlendHint; // 0x10
    public bool m_InheritPosition; // 0x14
    public VcamActivatedEvent m_OnCameraLive; // 0x18
}

public class TransitionTime : ValueType
{
    public System.DateTime TimeOfDay; // 0x10
    public byte Month; // 0x18
    public byte Week; // 0x19
    public byte Day; // 0x1A
    public 0x6641EB00 DayOfWeek; // 0x1C
    public bool IsFixedDateRule; // 0x20

    // ── Methods ──
    public void get_TimeOfDay(){} // RVA: 0x7FFD4EEF9F60
    public void get_Month(){} // RVA: 0x7FFD4EEF0210
    public void get_Week(){} // RVA: 0x7FFD4EEF01E0
    public void get_Day(){} // RVA: 0x7FFD53927500
    public void get_DayOfWeek(){} // RVA: 0x7FFD4FDE7520
    public void get_IsFixedDateRule(){} // RVA: 0x7FFD4E40B5E0
    public void Equals(){} // RVA: 0x7FFD539275E0 | overloaded x2
    public void op_Inequality(){} // RVA: 0x7FFD539275B0
    public void GetHashCode(){} // RVA: 0x7FFD539276E0
    public void .ctor(){} // RVA: 0x7FFD53927EC0 | overloaded x2
    public void CreateFixedDateRule(){} // RVA: 0x7FFD53927780
    public void CreateFloatingDateRule(){} // RVA: 0x7FFD53927800
    public void ValidateTransitionTime(){} // RVA: 0x7FFD53927890
    public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD53927C80
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD53927D20
}

public class TreePage : Object
{
    public 0x66530138<T>[] InUseCount;
    public int[] PageId;
    public int _inUseCount;
    public int _pageId;
    public int _nextFreeSlotLine;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090ED0
    public void AllocSlot(){} // RVA: 0x7FFD4E07E6B0
    public void get_InUseCount(){} // RVA: 0x7FFD4E079960
    public void set_InUseCount(){} // RVA: 0x7FFD4E090ED0
    public void get_PageId(){} // RVA: 0x7FFD4E079960
    public void set_PageId(){} // RVA: 0x7FFD4E090ED0
}

public class TriggerEndOfFrameCallbacks : ValueType
{
}

public class TriggerEvent : UnityEvent
{
    public 0x665B0880 TriggerType; // 0x10
    public 0x665B17F8 BroadcastType; // 0x14
    public System.Collections.Generic.List`1<0x665B1900> Events; // 0x18
    public string Name; // 0x20
    public System.Collections.Generic.List`1<VRC.SDKBase.VRC_Trigger> Others; // 0x28
    public 0x664DD1A8 Key; // 0x30
    public bool TriggerIndividuals; // 0x34
    public UnityEngine.LayerMask Layers; // 0x38
    public bool Repeat; // 0x3C
    public float LowPeriodTime; // 0x40
    public float HighPeriodTime; // 0x44
    public bool ResetOnEnable; // 0x48
    public bool EventFired; // 0x49
    public float Duration; // 0x4C
    public float Timer; // 0x50
    public int DataElementIdx; // 0x54
    public System.Collections.Generic.List`1<DataStorageShadow> DataStorageShadowValues; // 0x58
    public float AfterSeconds; // 0x60
    public bool[] ProbabilityLock; // 0x68
    public float[] Probabilities; // 0x70
    public int MidiChannel; // 0x78
    public int MidiNote; // 0x7C
    public string OscAddr; // 0x80

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC74470
}

public class TriggerModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D6E6A0
    public void set_enabled(){} // RVA: 0x7FFD54D6E6F0
    public void get_inside(){} // RVA: 0x7FFD54D6E750
    public void set_inside(){} // RVA: 0x7FFD54D6E7A0
    public void get_outside(){} // RVA: 0x7FFD54D6E800
    public void set_outside(){} // RVA: 0x7FFD54D6E850
    public void get_enter(){} // RVA: 0x7FFD54D6E8B0
    public void set_enter(){} // RVA: 0x7FFD54D6E900
    public void get_exit(){} // RVA: 0x7FFD54D6E960
    public void set_exit(){} // RVA: 0x7FFD54D6E9B0
    public void get_colliderQueryMode(){} // RVA: 0x7FFD54D6EA10
    public void set_colliderQueryMode(){} // RVA: 0x7FFD54D6EA60
    public void get_radiusScale(){} // RVA: 0x7FFD54D6EAC0
    public void set_radiusScale(){} // RVA: 0x7FFD54D6EB10
    public void AddCollider(){} // RVA: 0x7FFD54D6EB70
    public void RemoveCollider(){} // RVA: 0x7FFD54D6EC30 | overloaded x2
    public void RemoveColliderObject(){} // RVA: 0x7FFD54D6EC30
    public void SetCollider(){} // RVA: 0x7FFD54D6EC90
    public void GetCollider(){} // RVA: 0x7FFD54D6ED00
    public void get_colliderCount(){} // RVA: 0x7FFD54D6ED60
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D6E6A0
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D6E6F0
    public void get_inside_Injected(){} // RVA: 0x7FFD54D6E750
    public void set_inside_Injected(){} // RVA: 0x7FFD54D6E7A0
    public void get_outside_Injected(){} // RVA: 0x7FFD54D6E800
    public void set_outside_Injected(){} // RVA: 0x7FFD54D6E850
    public void get_enter_Injected(){} // RVA: 0x7FFD54D6E8B0
    public void set_enter_Injected(){} // RVA: 0x7FFD54D6E900
    public void get_exit_Injected(){} // RVA: 0x7FFD54D6E960
    public void set_exit_Injected(){} // RVA: 0x7FFD54D6E9B0
    public void get_colliderQueryMode_Injected(){} // RVA: 0x7FFD54D6EA10
    public void set_colliderQueryMode_Injected(){} // RVA: 0x7FFD54D6EA60
    public void get_radiusScale_Injected(){} // RVA: 0x7FFD54D6EAC0
    public void set_radiusScale_Injected(){} // RVA: 0x7FFD54D6EB10
    public void AddCollider_Injected(){} // RVA: 0x7FFD54D6EB70
    public void RemoveCollider_Injected(){} // RVA: 0x7FFD54D6EBD0
    public void RemoveColliderObject_Injected(){} // RVA: 0x7FFD54D6EC30
    public void SetCollider_Injected(){} // RVA: 0x7FFD54D6EC90
    public void GetCollider_Injected(){} // RVA: 0x7FFD54D6ED00
    public void get_colliderCount_Injected(){} // RVA: 0x7FFD54D6ED60
}

public class TryFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5337FAB0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class Try_000000AB$BurstDirectCall : Object
{
    public UIntPtr Pointer;
    public UIntPtr DeferredCompilation; // 0x8

    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD5492F5E0
    public void GetFunctionPointer(){} // RVA: 0x7FFD5492F720
    public void Constructor(){} // RVA: 0x7FFD5492F890
    public void Initialize(){} // RVA: 0x7FFD4E341310
    public void .cctor(){} // RVA: 0x7FFD5492F890
    public void Invoke(){} // RVA: 0x7FFD5492F950
}

public class Try_000000AB$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5337FAB0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class Try_000000B9$BurstDirectCall : Object
{
    public UIntPtr Pointer;
    public UIntPtr DeferredCompilation; // 0x8

    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD5492FE00
    public void GetFunctionPointer(){} // RVA: 0x7FFD5492FF40
    public void Constructor(){} // RVA: 0x7FFD549300B0
    public void Initialize(){} // RVA: 0x7FFD4E341310
    public void .cctor(){} // RVA: 0x7FFD549300B0
    public void Invoke(){} // RVA: 0x7FFD54930170
}

public class Try_000000B9$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5337FAB0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class TypeCollections : Object
{
    public 0x665B0880[] KeyTypes;
    public 0x665B0880[] TimerTypes; // 0x8
    public 0x665B0880[] InteractiveTypes; // 0x10
    public 0x665B0880[] ColliderTypes; // 0x18
    public 0x665B0880[] TriggerTypes; // 0x20
    public 0x665B0880[] PickupTypes; // 0x28
    public 0x665B0880[] DataStorageTypes; // 0x30

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD5748B280
}

public class TypeConstructorVisitor : Object
{
    public ÏÍÌÍÌÎÎÍ TypeConstructor; // 0x10

    // ── Methods ──
    public void Visit(){} // RVA: 0x7FFD4E090980
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class TypeConstructor`1 : Object
{
    public System.Func`1<T> Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated;
    public System.Func`1<T> m_ImplicitConstructor;
    public Unity.Properties.IConstructor`1<T> m_OverrideConstructor;

    // ── Methods ──
    public void Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated(){} // RVA: 0x7FFD4E079D00
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void SetImplicitConstructor(){} // RVA: 0x7FFD4E090980
    public void CreateValueTypeInstance(){} // RVA: 0x7FFD4E2ADC40
    public void CreateScriptableObjectInstance(){} // RVA: 0x7FFD4E2ADC40
    public void CreateClassInstance(){} // RVA: 0x7FFD4E2ADC40
    public void SetExplicitConstructor(){} // RVA: 0x7FFD4E090A40
    public void Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate(){} // RVA: 0x7FFD4E2ADC40
    public void Unity.Properties.TypeUtility.ITypeConstructor.Instantiate(){} // RVA: 0x7FFD4E078E90
}

public class TypeData : Object
{
    public System.Type type; // 0x10
    public string fullTypeName; // 0x18
    public string typeName; // 0x20
    public string typeNamespace; // 0x28

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFD4E35C380
    public void .ctor(){} // RVA: 0x7FFD55015280
    public void get_fullTypeName(){} // RVA: 0x7FFD55015440
    public void get_typeName(){} // RVA: 0x7FFD550154E0
    public void get_typeNamespace(){} // RVA: 0x7FFD550155F0
}

public class TypedRestore : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E090A40
    public void BeginInvoke(){} // RVA: 0x7FFD4E08AE80
    public void EndInvoke(){} // RVA: 0x7FFD4E099B30
}

public class Types : Object
{
}
