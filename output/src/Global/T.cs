// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 353

public class T : Object
{
}

public class T0 : Object
{
}

public class T1 : Object
{
}

public class T2 : Object
{
}

public class T3 : Object
{
}

public class TCategoryName : Object
{
}

public class TCollection : Object
{
}

public class TDictionary : Object
{
}

public class TEdge : Object
{
    public IntPoint Bot; // 0x10
    public IntPoint Curr; // 0x20
    public IntPoint Top; // 0x30
    public IntPoint Delta; // 0x40
    public double Dx; // 0x50
    public 0x6B22C498 PolyTyp; // 0x58
    public 0x6B22C5F8 Side; // 0x5C
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
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class TElement : Object
{
}

public class TEventEqualityComparerType : Object
{
}

public class TEventType : Object
{
}

public class TIME_DYNAMIC_ZONE_INFORMATION : ValueType
{
    public int Bias; // 0x10
    public <StandardName>e__FixedBuffer StandardName; // 0x14
    public SYSTEMTIME StandardDate; // 0x54
    public int StandardBias; // 0x64
    public <DaylightName>e__FixedBuffer DaylightName; // 0x68
    public SYSTEMTIME DaylightDate; // 0xA8
    public int DaylightBias; // 0xB8
    public <TimeZoneKeyName>e__FixedBuffer TimeZoneKeyName; // 0xBC
    public byte DynamicDaylightTimeDisabled; // 0x1BC

    // ── Methods ──
    public void GetTimeZoneKeyName(){} // RVA: 0x7FFAC838A1E0
}

public class TIME_ZONE_INFORMATION : ValueType
{
    public int Bias; // 0x10
    public <StandardName>e__FixedBuffer StandardName; // 0x14
    public SYSTEMTIME StandardDate; // 0x54
    public int StandardBias; // 0x64
    public <DaylightName>e__FixedBuffer DaylightName; // 0x68
    public SYSTEMTIME DaylightDate; // 0xA8
    public int DaylightBias; // 0xB8

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC838A200
    public void GetStandardName(){} // RVA: 0x7FFAC838A320
    public void GetDaylightName(){} // RVA: 0x7FFAC838A330
}

public class TKey : Object
{
}

public class TOptions : Object
{
}

public class TOut : Object
{
}

public class TOutput : Object
{
}

public class TQueue : Object
{
}

public class TResult : Object
{
}

public class TSource : Object
{
}

public class TStack : Object
{
}

public class TState : Object
{
}

public class TTask : Object
{
}

public class TTraits : Object
{
}

public class TUnityEvent : Object
{
}

public class TValue : Object
{
}

public class TValueUxmlAttributeType : Object
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
    public void .ctor(){} // RVA: 0x7FFAC83917B0
}

public class TableSchemaInfo : Object
{
    public System.Data.DataTable TableSchema; // 0x10
    public XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8EF5440
}

public class Tables : Object
{
    public Node<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type>[] _buckets; // 0x10
    public object[] _locks; // 0x18
    public int[] _countPerLock; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC69D8200
}

public class TagInfo : ValueType
{
    public string name; // 0x10
    public string prefix; // 0x18
    public string defaultNs; // 0x20
    public 0x6B15AC58 defaultNsState; // 0x28
    public 0x6B15A5D0 xmlSpace; // 0x2C
    public string xmlLang; // 0x30
    public int prevNsTop; // 0x38
    public int prefixCount; // 0x3C
    public bool mixed; // 0x40

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC91C7180
}

public class TagsLinkedList : Object
{
    public System.Diagnostics.DiagNode`1<System.Collections.Generic.KeyValuePair`2<string,object>> _first; // 0x10

    // ── Methods ──
    public void GetEnumerator(){} // RVA: 0x7FFAC8F73530
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x7FFAC8F73590
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8F73620
}

public class Take : Object
{
    public System.IObserver`1<T> m_Observer;
    public int m_Remaining;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C79B30
    public void OnCompleted(){} // RVA: 0x7FFAC2C70980
    public void OnError(){} // RVA: 0x7FFAC2C70A40
    public void OnNext(){} // RVA: 0x7FFAC2E8DC40
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

public class TargetChild : Object
{
    public UnityEngine.Transform t; // 0x10
    public UnityEngine.Vector3 defaultLocalPosition; // 0x18
    public UnityEngine.Quaternion defaultLocalRotation; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F97CA0
    public void Map(){} // RVA: 0x7FFAC2F97E10
}

public class TaskNode : Task`1
{
    public TaskNode Prev; // 0x58
    public TaskNode Next; // 0x60

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86C47E0
    public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFAC86C4860
    public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFAC2F21310
}

public class TaskSocketAsyncEventArgs`1 : SocketAsyncEventArgs
{
    public System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<U> _builder;
    public bool _accessed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void GetCompletionResponsibility(){} // RVA: 0x7FFAC2E8DC40
}

public class TaskWrapperAsyncResult : Object
{
    public System.Threading.Tasks.Task System.IAsyncResult.AsyncState; // 0x10
    public object System.IAsyncResult.CompletedSynchronously; // 0x18
    public bool System.IAsyncResult.IsCompleted; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC84C0F70
    public void System.IAsyncResult.get_AsyncState(){} // RVA: 0x7FFAC2F247C0
    public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x7FFAC300F9D0
    public void System.IAsyncResult.get_IsCompleted(){} // RVA: 0x7FFAC4458C20
    public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7FFAC86D9A40
}

public class Tasks : Object
{
    public 0x6B0DCD48 Loop;
    public 0x6B0DCD48 Invoke;
    public 0x6B0DCD48 ForkJoin;
}

public class TeleportDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6191FF0
    public void Invoke(){} // RVA: 0x7FFAC6192170
    public void BeginInvoke(){} // RVA: 0x7FFACBFE53E0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class TempAssemblyComparer : Object
{
    public System.Collections.Generic.IEqualityComparer`1<System.Collections.Generic.KeyValuePair`2<System.Type,System.Xml.Serialization.XmlRootAttribute>> s_default;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Equals(){} // RVA: 0x7FFAC8F314D0
    public void GetHashCode(){} // RVA: 0x7FFAC8F316E0
    public void .cctor(){} // RVA: 0x7FFAC8F317C0
}

public class TensorMapping : Object
{
    public Google.Protobuf.MessageParser`1<TensorMapping> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int DetectionsTensorIndex; // 0x8
    public int HasDetectionsTensorIndex; // 0x1C
    public int ClassesTensorIndex; // 0xC
    public int HasClassesTensorIndex; // 0x20
    public int ScoresTensorIndex; // 0x10
    public int HasScoresTensorIndex; // 0x24
    public int NumDetectionsTensorIndex; // 0x14
    public int HasNumDetectionsTensorIndex; // 0x28
    public int AnchorsTensorIndex; // 0x18
    public int HasAnchorsTensorIndex; // 0x2C

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC8286180
    public void get_Descriptor(){} // RVA: 0x7FFAC82861E0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8286260
    public void .ctor(){} // RVA: 0x7FFAC8286310 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC8286410
    public void get_DetectionsTensorIndex(){} // RVA: 0x7FFAC8286540
    public void set_DetectionsTensorIndex(){} // RVA: 0x7FFAC81F3760
    public void get_HasDetectionsTensorIndex(){} // RVA: 0x7FFAC81F3770
    public void ClearDetectionsTensorIndex(){} // RVA: 0x7FFAC81F3780
    public void get_ClassesTensorIndex(){} // RVA: 0x7FFAC82865B0
    public void set_ClassesTensorIndex(){} // RVA: 0x7FFAC81F3800
    public void get_HasClassesTensorIndex(){} // RVA: 0x7FFAC81F3810
    public void ClearClassesTensorIndex(){} // RVA: 0x7FFAC81F3820
    public void get_ScoresTensorIndex(){} // RVA: 0x7FFAC8286620
    public void set_ScoresTensorIndex(){} // RVA: 0x7FFAC82834A0
    public void get_HasScoresTensorIndex(){} // RVA: 0x7FFAC81F6A10
    public void ClearScoresTensorIndex(){} // RVA: 0x7FFAC81F6A20
    public void get_NumDetectionsTensorIndex(){} // RVA: 0x7FFAC8286690
    public void set_NumDetectionsTensorIndex(){} // RVA: 0x7FFAC8286700
    public void get_HasNumDetectionsTensorIndex(){} // RVA: 0x7FFAC81F6FD0
    public void ClearNumDetectionsTensorIndex(){} // RVA: 0x7FFAC81F6FE0
    public void get_AnchorsTensorIndex(){} // RVA: 0x7FFAC8286710
    public void set_AnchorsTensorIndex(){} // RVA: 0x7FFAC8286780
    public void get_HasAnchorsTensorIndex(){} // RVA: 0x7FFAC81F7240
    public void ClearAnchorsTensorIndex(){} // RVA: 0x7FFAC81F7250
    public void Equals(){} // RVA: 0x7FFAC82868E0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC82869F0
    public void ToString(){} // RVA: 0x7FFAC8286AA0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8286AF0
    public void CalculateSize(){} // RVA: 0x7FFAC8286C00
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8286ED0
    public void .cctor(){} // RVA: 0x7FFAC8286FE0
}

public class TestBuilder : Object
{
    public System.Collections.Generic.HashSet`1<System.Dynamic.BindingRestrictions> _unique; // 0x10
    public System.Collections.Generic.Stack`1<AndNode> _tests; // 0x18

    // ── Methods ──
    public void Append(){} // RVA: 0x7FFAC8DF64A0
    public void ToExpression(){} // RVA: 0x7FFAC8DF6540
    public void Push(){} // RVA: 0x7FFAC8DF6740
    public void .ctor(){} // RVA: 0x7FFAC8DF6B30
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
    public void get_Capacity(){} // RVA: 0x7FFAC5E86060
    public void get_Count(){} // RVA: 0x7FFAC49C7500
    public void set_Count(){} // RVA: 0x7FFAC49C7510
    public void get_Item(){} // RVA: 0x7FFAC5DB90C0
    public void set_Item(){} // RVA: 0x7FFAC97A0240
    public void .ctor(){} // RVA: 0x7FFAC97A02A0
    public void Resize(){} // RVA: 0x7FFAC97A0350
}

public class TextEvent : ValueType
{
    public int TextEventType; // 0x10
    public byte Type; // 0x14
    public string Value; // 0x18

    // ── Methods ──
    public void get_TextEventType(){} // RVA: 0x7FFAC4A0B160
}

public class TextInput : TextInputBase
{
    public object multiline;
    public object isPasswordField;

    // ── Methods ──
    public void set_multiline(){} // RVA: 0x7FFAC9B3BA60
    public void set_isPasswordField(){} // RVA: 0x7FFAC9B3BBF0
    public void StringToValue(){} // RVA: 0x7FFAC3E92FB0
    public void .ctor(){} // RVA: 0x7FFAC9B3BC90
}

public class TextInputBase : VisualElement
{
    public UnityEngine.UIElements.TextElement textElement;
    public UnityEngine.UIElements.ScrollView textSelection;
    public UnityEngine.UIElements.VisualElement textEdition;
    public string originalText;
    public string isReadOnly;
    public string maxLength;
    public string maskChar;
    public string isPasswordField;
    public string isDragging;
    public string text;
    public string innerViewportUssClassName;
    public string innerContentContainerUssClassName;
    public bool <isDragging>k__BackingField;
    public UnityEngine.Vector2 scrollOffset;
    public bool m_ScrollViewWasClamped;
    public UnityEngine.Vector2 lastCursorPos;
    public 0x6B1192E0 m_VerticalScrollerVisibility;

    // ── Methods ──
    public void get_textElement(){} // RVA: 0x7FFAC2C58E90
    public void set_textElement(){} // RVA: 0x7FFAC2C70A40
    public void get_textSelection(){} // RVA: 0x7FFAC2C58E90
    public void get_textEdition(){} // RVA: 0x7FFAC2C58E90
    public void SelectAll(){} // RVA: 0x7FFAC2C70980
    public void SelectNone(){} // RVA: 0x7FFAC2C70980
    public void get_originalText(){} // RVA: 0x7FFAC2C58E90
    public void StringToValue(){} // RVA: 0x7FFAC2E8DC40
    public void UpdateValueFromText(){} // RVA: 0x7FFAC2C70980
    public void UpdateTextFromValue(){} // RVA: 0x7FFAC2C70980
    public void MoveFocusToCompositeRoot(){} // RVA: 0x7FFAC2C70980
    public void get_isReadOnly(){} // RVA: 0x7FFAC2C59D00
    public void set_maxLength(){} // RVA: 0x7FFAC2C70ED0
    public void set_maskChar(){} // RVA: 0x7FFAC2C70B70
    public void get_isPasswordField(){} // RVA: 0x7FFAC2C59D00
    public void set_isPasswordField(){} // RVA: 0x7FFAC2C71060
    public void set_isDragging(){} // RVA: 0x7FFAC2C71060
    public void get_text(){} // RVA: 0x7FFAC2C58E90
    public void set_text(){} // RVA: 0x7FFAC2C70A40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void MakeSureScrollViewDoesNotLeakEvents(){} // RVA: 0x7FFAC2C70A40
    public void SetSingleLine(){} // RVA: 0x7FFAC2C70980
    public void SetMultiline(){} // RVA: 0x7FFAC2C70980
    public void ScrollViewOnGeometryChangedEvent(){} // RVA: 0x7FFAC2C70A40
    public void TextElementOnGeometryChangedEvent(){} // RVA: 0x7FFAC2C70A40
    public void OnInputCustomStyleResolved(){} // RVA: 0x7FFAC2C70A40
    public void AcceptCharacter(){} // RVA: 0x7FFAC2C5AB80
    public void UpdateScrollOffset(){} // RVA: 0x7FFAC2C710F0 | overloaded x2
    public void GetScrollOffset(){} // RVA: 0x7FFAC2E8DC40
    public void SetScrollViewMode(){} // RVA: 0x7FFAC2C70980
    public void SetMultilineContainerStyle(){} // RVA: 0x7FFAC2C70980
    public void RemoveSingleLineComponents(){} // RVA: 0x7FFAC2C70980
    public void RemoveMultilineComponents(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class TextSelectionEvent : UnityEvent`3
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9787040
}

public class TextValueInput : TextInputBase
{
    public string textValueFieldParent;

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x7FFAC2C58E90
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void AcceptCharacter(){} // RVA: 0x7FFAC2C5AB80
    public void get_allowedCharacters(){} // RVA: 0x7FFAC2C58E90
    public void get_formatString(){} // RVA: 0x7FFAC2C58E90
    public void set_formatString(){} // RVA: 0x7FFAC2C70A40
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC2E8DC40
    public void StartDragging(){} // RVA: 0x7FFAC2C70980
    public void StopDragging(){} // RVA: 0x7FFAC2C70980
    public void ValueToString(){} // RVA: 0x7FFAC2E8DC40
    public void StringToValue(){} // RVA: 0x7FFAC2E8DC40
}

public class TextureChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC99F5B10
    public void Invoke(){} // RVA: 0x7FFAC99F5BF0
}

public class TextureInfo : LinkedPoolItem`1
{
    public UnityEngine.UIElements.DynamicAtlasPage page; // 0x18
    public int counter; // 0x20
    public Alloc2D alloc; // 0x28
    public UnityEngine.RectInt rect; // 0x58
    public UnityEngine.UIElements.UIR.LinkedPool`1<TextureInfo> pool;

    // ── Methods ──
    public void Create(){} // RVA: 0x7FFAC9A7CA80
    public void Reset(){} // RVA: 0x7FFAC9A7CAE0
    public void .ctor(){} // RVA: 0x7FFAC9A7CB70
    public void .cctor(){} // RVA: 0x7FFAC9A7CBA0
}

public class TextureRectMatrixf : ValueType
{
    public UnityEngine.Rect leftRect; // 0x10
    public UnityEngine.Rect rightRect; // 0x20
    public UnityEngine.Vector4 leftScaleBias; // 0x30
    public UnityEngine.Vector4 rightScaleBias; // 0x40
    public TextureRectMatrixf zero;

    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC89077B0
    public void .cctor(){} // RVA: 0x7FFAC8907A80
}

public class TextureSheetAnimationModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC994F360
    public void set_enabled(){} // RVA: 0x7FFAC994F3B0
    public void get_mode(){} // RVA: 0x7FFAC994F410
    public void set_mode(){} // RVA: 0x7FFAC994F460
    public void get_timeMode(){} // RVA: 0x7FFAC994F4C0
    public void set_timeMode(){} // RVA: 0x7FFAC994F510
    public void get_fps(){} // RVA: 0x7FFAC994F570
    public void set_fps(){} // RVA: 0x7FFAC994F5C0
    public void get_numTilesX(){} // RVA: 0x7FFAC994F620
    public void set_numTilesX(){} // RVA: 0x7FFAC994F670
    public void get_numTilesY(){} // RVA: 0x7FFAC994F6D0
    public void set_numTilesY(){} // RVA: 0x7FFAC994F720
    public void get_animation(){} // RVA: 0x7FFAC994F780
    public void set_animation(){} // RVA: 0x7FFAC994F7D0
    public void get_rowMode(){} // RVA: 0x7FFAC994F830
    public void set_rowMode(){} // RVA: 0x7FFAC994F880
    public void get_frameOverTime(){} // RVA: 0x7FFAC994F8E0
    public void set_frameOverTime(){} // RVA: 0x7FFAC994F950
    public void get_frameOverTimeMultiplier(){} // RVA: 0x7FFAC994F9B0
    public void set_frameOverTimeMultiplier(){} // RVA: 0x7FFAC994FA00
    public void get_startFrame(){} // RVA: 0x7FFAC994FA60
    public void set_startFrame(){} // RVA: 0x7FFAC994FAD0
    public void get_startFrameMultiplier(){} // RVA: 0x7FFAC994FB30
    public void set_startFrameMultiplier(){} // RVA: 0x7FFAC994FB80
    public void get_cycleCount(){} // RVA: 0x7FFAC994FBE0
    public void set_cycleCount(){} // RVA: 0x7FFAC994FC30
    public void get_rowIndex(){} // RVA: 0x7FFAC994FC90
    public void set_rowIndex(){} // RVA: 0x7FFAC994FCE0
    public void get_uvChannelMask(){} // RVA: 0x7FFAC994FD40
    public void set_uvChannelMask(){} // RVA: 0x7FFAC994FD90
    public void get_spriteCount(){} // RVA: 0x7FFAC994FDF0
    public void get_speedRange(){} // RVA: 0x7FFAC994FE40
    public void set_speedRange(){} // RVA: 0x7FFAC994FEA0
    public void AddSprite(){} // RVA: 0x7FFAC994FF00
    public void RemoveSprite(){} // RVA: 0x7FFAC994FF60
    public void SetSprite(){} // RVA: 0x7FFAC994FFC0
    public void GetSprite(){} // RVA: 0x7FFAC9950030
    public void get_enabled_Injected(){} // RVA: 0x7FFAC994F360
    public void set_enabled_Injected(){} // RVA: 0x7FFAC994F3B0
    public void get_mode_Injected(){} // RVA: 0x7FFAC994F410
    public void set_mode_Injected(){} // RVA: 0x7FFAC994F460
    public void get_timeMode_Injected(){} // RVA: 0x7FFAC994F4C0
    public void set_timeMode_Injected(){} // RVA: 0x7FFAC994F510
    public void get_fps_Injected(){} // RVA: 0x7FFAC994F570
    public void set_fps_Injected(){} // RVA: 0x7FFAC994F5C0
    public void get_numTilesX_Injected(){} // RVA: 0x7FFAC994F620
    public void set_numTilesX_Injected(){} // RVA: 0x7FFAC994F670
    public void get_numTilesY_Injected(){} // RVA: 0x7FFAC994F6D0
    public void set_numTilesY_Injected(){} // RVA: 0x7FFAC994F720
    public void get_animation_Injected(){} // RVA: 0x7FFAC994F780
    public void set_animation_Injected(){} // RVA: 0x7FFAC994F7D0
    public void get_rowMode_Injected(){} // RVA: 0x7FFAC994F830
    public void set_rowMode_Injected(){} // RVA: 0x7FFAC994F880
    public void get_frameOverTime_Injected(){} // RVA: 0x7FFAC9950090
    public void set_frameOverTime_Injected(){} // RVA: 0x7FFAC99500F0
    public void get_frameOverTimeMultiplier_Injected(){} // RVA: 0x7FFAC994F9B0
    public void set_frameOverTimeMultiplier_Injected(){} // RVA: 0x7FFAC994FA00
    public void get_startFrame_Injected(){} // RVA: 0x7FFAC9950150
    public void set_startFrame_Injected(){} // RVA: 0x7FFAC99501B0
    public void get_startFrameMultiplier_Injected(){} // RVA: 0x7FFAC994FB30
    public void set_startFrameMultiplier_Injected(){} // RVA: 0x7FFAC994FB80
    public void get_cycleCount_Injected(){} // RVA: 0x7FFAC994FBE0
    public void set_cycleCount_Injected(){} // RVA: 0x7FFAC994FC30
    public void get_rowIndex_Injected(){} // RVA: 0x7FFAC994FC90
    public void set_rowIndex_Injected(){} // RVA: 0x7FFAC994FCE0
    public void get_uvChannelMask_Injected(){} // RVA: 0x7FFAC994FD40
    public void set_uvChannelMask_Injected(){} // RVA: 0x7FFAC994FD90
    public void get_spriteCount_Injected(){} // RVA: 0x7FFAC994FDF0
    public void get_speedRange_Injected(){} // RVA: 0x7FFAC9950210
    public void set_speedRange_Injected(){} // RVA: 0x7FFAC9950270
    public void AddSprite_Injected(){} // RVA: 0x7FFAC994FF00
    public void RemoveSprite_Injected(){} // RVA: 0x7FFAC994FF60
    public void SetSprite_Injected(){} // RVA: 0x7FFAC994FFC0
    public void GetSprite_Injected(){} // RVA: 0x7FFAC9950030
}

public class TfLite : Object
{
    public Google.Protobuf.MessageParser`1<TfLite> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC827D4A0
    public void get_Descriptor(){} // RVA: 0x7FFAC827D500
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC827D580
    public void .ctor(){} // RVA: 0x7FFAC81D3F10 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC827D630
    public void Equals(){} // RVA: 0x7FFAC81D41A0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC81D41E0
    public void ToString(){} // RVA: 0x7FFAC827D7E0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D4270
    public void CalculateSize(){} // RVA: 0x7FFAC81D4290
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D4390
    public void .cctor(){} // RVA: 0x7FFAC827D830
}

public class ThreadContext : Object
{
    public int m_NestedIOCount; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ThreadLocalState : Object
{
    public System.Text.Json.PooledByteBufferWriter BufferWriter; // 0x10
    public System.Text.Json.Utf8JsonWriter Writer; // 0x18
    public int RentedWriters; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC90408C0
}

public class ThreadSafeRandom : Object
{
    public System.Random _r;

    // ── Methods ──
    public void Next(){} // RVA: 0x7FFAC89DD420
    public void .cctor(){} // RVA: 0x7FFAC89DD5F0
}

public class ThreadedLoadingDebug : ValueType
{
}

public class Threefish1024Cipher : ThreefishCipher
{
    public int ROTATION_0_0;
    public int ROTATION_0_1;
    public int ROTATION_0_2;
    public int ROTATION_0_3;
    public int ROTATION_0_4;
    public int ROTATION_0_5;
    public int ROTATION_0_6;
    public int ROTATION_0_7;
    public int ROTATION_1_0;
    public int ROTATION_1_1;
    public int ROTATION_1_2;
    public int ROTATION_1_3;
    public int ROTATION_1_4;
    public int ROTATION_1_5;
    public int ROTATION_1_6;
    public int ROTATION_1_7;
    public int ROTATION_2_0;
    public int ROTATION_2_1;
    public int ROTATION_2_2;
    public int ROTATION_2_3;
    public int ROTATION_2_4;
    public int ROTATION_2_5;
    public int ROTATION_2_6;
    public int ROTATION_2_7;
    public int ROTATION_3_0;
    public int ROTATION_3_1;
    public int ROTATION_3_2;
    public int ROTATION_3_3;
    public int ROTATION_3_4;
    public int ROTATION_3_5;
    public int ROTATION_3_6;
    public int ROTATION_3_7;
    public int ROTATION_4_0;
    public int ROTATION_4_1;
    public int ROTATION_4_2;
    public int ROTATION_4_3;
    public int ROTATION_4_4;
    public int ROTATION_4_5;
    public int ROTATION_4_6;
    public int ROTATION_4_7;
    public int ROTATION_5_0;
    public int ROTATION_5_1;
    public int ROTATION_5_2;
    public int ROTATION_5_3;
    public int ROTATION_5_4;
    public int ROTATION_5_5;
    public int ROTATION_5_6;
    public int ROTATION_5_7;
    public int ROTATION_6_0;
    public int ROTATION_6_1;
    public int ROTATION_6_2;
    public int ROTATION_6_3;
    public int ROTATION_6_4;
    public int ROTATION_6_5;
    public int ROTATION_6_6;
    public int ROTATION_6_7;
    public int ROTATION_7_0;
    public int ROTATION_7_1;
    public int ROTATION_7_2;
    public int ROTATION_7_3;
    public int ROTATION_7_4;
    public int ROTATION_7_5;
    public int ROTATION_7_6;
    public int ROTATION_7_7;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC3B8C0
    public void EncryptBlock(){} // RVA: 0x7FFACBC3D290
    public void DecryptBlock(){} // RVA: 0x7FFACBC3E270
}

public class Threefish256Cipher : ThreefishCipher
{
    public int ROTATION_0_0;
    public int ROTATION_0_1;
    public int ROTATION_1_0;
    public int ROTATION_1_1;
    public int ROTATION_2_0;
    public int ROTATION_2_1;
    public int ROTATION_3_0;
    public int ROTATION_3_1;
    public int ROTATION_4_0;
    public int ROTATION_4_1;
    public int ROTATION_5_0;
    public int ROTATION_5_1;
    public int ROTATION_6_0;
    public int ROTATION_6_1;
    public int ROTATION_7_0;
    public int ROTATION_7_1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC3B8C0
    public void EncryptBlock(){} // RVA: 0x7FFACBC3B8D0
    public void DecryptBlock(){} // RVA: 0x7FFACBC3BD90
}

public class Threefish512Cipher : ThreefishCipher
{
    public int ROTATION_0_0;
    public int ROTATION_0_1;
    public int ROTATION_0_2;
    public int ROTATION_0_3;
    public int ROTATION_1_0;
    public int ROTATION_1_1;
    public int ROTATION_1_2;
    public int ROTATION_1_3;
    public int ROTATION_2_0;
    public int ROTATION_2_1;
    public int ROTATION_2_2;
    public int ROTATION_2_3;
    public int ROTATION_3_0;
    public int ROTATION_3_1;
    public int ROTATION_3_2;
    public int ROTATION_3_3;
    public int ROTATION_4_0;
    public int ROTATION_4_1;
    public int ROTATION_4_2;
    public int ROTATION_4_3;
    public int ROTATION_5_0;
    public int ROTATION_5_1;
    public int ROTATION_5_2;
    public int ROTATION_5_3;
    public int ROTATION_6_0;
    public int ROTATION_6_1;
    public int ROTATION_6_2;
    public int ROTATION_6_3;
    public int ROTATION_7_0;
    public int ROTATION_7_1;
    public int ROTATION_7_2;
    public int ROTATION_7_3;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC3B8C0
    public void EncryptBlock(){} // RVA: 0x7FFACBC3C270
    public void DecryptBlock(){} // RVA: 0x7FFACBC3CA40
}

public class ThreefishCipher : Object
{
    public ulong[] t; // 0x10
    public ulong[] kw; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC84642F0
    public void EncryptBlock(){} // RVA: 0x7FFAC2C79B30
    public void DecryptBlock(){} // RVA: 0x7FFAC2C79B30
}

public class ThrowObservable`1 : Object
{
    public System.Exception value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Subscribe(){} // RVA: 0x7FFAC2C58F40
}

public class Thumb : Object
{
    public Retargetable metacarpal; // 0x10
    public Retargetable middle; // 0x18
    public Retargetable distal; // 0x20
    public UnityEngine.Transform aux; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F69A50
}

public class TickCallbackDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC980CDC0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class TimeEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC489EAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class TimeRange : ValueType
{
    public float IsEmpty; // 0x10
    public float Empty; // 0x14

    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7FFAC4851510
    public void Contains(){} // RVA: 0x7FFAC4539010
    public void get_Empty(){} // RVA: 0x7FFAC4851520
    public void Include(){} // RVA: 0x7FFAC4851540
}

public class TimeSpanRawInfo : ValueType
{
    public 0x6B0DB958 PositiveInvariant; // 0x10
    public int NegativeInvariant; // 0x14
    public int PositiveLocalized; // 0x18
    public int NegativeLocalized; // 0x1C
    public FormatLiterals _posLoc; // 0x20
    public FormatLiterals _negLoc; // 0x48
    public bool _posLocInit; // 0x70
    public bool _negLocInit; // 0x71
    public string _fullPosPattern; // 0x78
    public string _fullNegPattern; // 0x80
    public TimeSpanToken _numbers0; // 0x88
    public TimeSpanToken _numbers1; // 0xA8
    public TimeSpanToken _numbers2; // 0xC8
    public TimeSpanToken _numbers3; // 0xE8
    public TimeSpanToken _numbers4; // 0x108
    public System.ReadOnlySpan`1<char> _literals0; // 0x128
    public System.ReadOnlySpan`1<char> _literals1; // 0x138
    public System.ReadOnlySpan`1<char> _literals2; // 0x148
    public System.ReadOnlySpan`1<char> _literals3; // 0x158
    public System.ReadOnlySpan`1<char> _literals4; // 0x168
    public System.ReadOnlySpan`1<char> _literals5; // 0x178

    // ── Methods ──
    public void get_PositiveInvariant(){} // RVA: 0x7FFAC855D270
    public void get_NegativeInvariant(){} // RVA: 0x7FFAC855D2F0
    public void get_PositiveLocalized(){} // RVA: 0x7FFAC855D370
    public void get_NegativeLocalized(){} // RVA: 0x7FFAC855D440
    public void FullAppCompatMatch(){} // RVA: 0x7FFAC855D510
    public void PartialAppCompatMatch(){} // RVA: 0x7FFAC855D800
    public void FullMatch(){} // RVA: 0x7FFAC855DA70
    public void FullDMatch(){} // RVA: 0x7FFAC855DDE0
    public void FullHMMatch(){} // RVA: 0x7FFAC855DF60
    public void FullDHMMatch(){} // RVA: 0x7FFAC855E140
    public void FullHMSMatch(){} // RVA: 0x7FFAC855E3B0
    public void FullDHMSMatch(){} // RVA: 0x7FFAC855E620
    public void FullHMSFMatch(){} // RVA: 0x7FFAC855E910
    public void Init(){} // RVA: 0x7FFAC855EC00
    public void ProcessToken(){} // RVA: 0x7FFAC855EC60
    public void AddSep(){} // RVA: 0x7FFAC855EE70
    public void AddNum(){} // RVA: 0x7FFAC855EFC0
}

public class TimeSpanResult : ValueType
{
    public System.TimeSpan parsedTimeSpan; // 0x10
    public bool _throwOnFailure; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC855F430
    public void SetFailure(){} // RVA: 0x7FFAC855F440
}

public class TimeSpanSeconds : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFAC8FB12F0
}

public class TimeSpanSplitter : ValueType
{
    public uint V1; // 0x10
    public uint V2; // 0x14
    public uint V3; // 0x18
    public uint V4; // 0x1C
    public uint V5; // 0x20
    public bool IsNegative; // 0x24
    public uint Separators; // 0x28

    // ── Methods ──
    public void TrySplitTimeSpan(){} // RVA: 0x7FFAC8A68FD0
    public void ParseComponent(){} // RVA: 0x7FFAC8A69290
}

public class TimeSpanToken : ValueType
{
    public 0x6B0DB958 _ttt; // 0x10
    public int _num; // 0x14
    public int _zeroes; // 0x18
    public System.ReadOnlySpan`1<char> _sep; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC855CF00 | overloaded x4
    public void IsInvalidFraction(){} // RVA: 0x7FFAC855CF20
}

public class TimeSpanTokenizer : ValueType
{
    public System.ReadOnlySpan`1<char> EOL; // 0x10
    public int NextChar; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC60F1490 | overloaded x2
    public void GetNextToken(){} // RVA: 0x7FFAC855CF90
    public void get_EOL(){} // RVA: 0x7FFAC855D1D0
    public void BackOne(){} // RVA: 0x7FFAC855D210
    public void get_NextChar(){} // RVA: 0x7FFAC855D220
}

public class TimelineAssetUpgrade : Object
{
}

public class TimelineClipUpgrade : Object
{
    // ── Methods ──
    public void UpgradeClipInFromGlobalToLocal(){} // RVA: 0x7FFAC97B7FA0
}

public class TimelineInstance : Object
{
    public UnityEngine.Playables.PlayableDirector _director; // 0x10
    public 0x6B188888 _originalTimeUpdateMode; // 0x18
    public bool _isControlling; // 0x1C
    public bool _isCapturing; // 0x1D

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Is(){} // RVA: 0x7FFAC8A0A730
    public void StartCapture(){} // RVA: 0x7FFAC8A0A870
    public void StopCapture(){} // RVA: 0x7FFAC8A0AA20
}

public class TimeoutTracker : ValueType
{
    public int RemainingMilliseconds; // 0x10
    public int IsExpired; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8E17160
    public void get_RemainingMilliseconds(){} // RVA: 0x7FFAC8E171E0
    public void get_IsExpired(){} // RVA: 0x7FFAC8E17220
}

public class Timer : Object
{
    public int StartTime; // 0x10
    public int Expiration; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92C6BA0
    public void get_StartTime(){} // RVA: 0x7FFAC2F6E5C0
    public void get_Expiration(){} // RVA: 0x7FFAC92C6BC0
    public void Cancel(){} // RVA: 0x7FFAC2C59D00
    public void get_HasExpired(){} // RVA: 0x7FFAC2C59D00
    public void Dispose(){} // RVA: 0x7FFAC2FD5BE0
}

public class TimerComparer : ValueType
{
    // ── Methods ──
    public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFAC86D7DD0
    public void Compare(){} // RVA: 0x7FFAC86D7ED0
}

public class TimerNode : Timer
{
    public 0x6B13BBF8 HasExpired; // 0x18
    public Callback Next; // 0x20
    public object Prev; // 0x28
    public object m_QueueLock; // 0x30
    public TimerNode next; // 0x38
    public TimerNode prev; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92C76B0 | overloaded x2
    public void get_HasExpired(){} // RVA: 0x7FFAC92C76E0
    public void get_Next(){} // RVA: 0x7FFAC31D0140
    public void set_Next(){} // RVA: 0x7FFAC31D0C20
    public void get_Prev(){} // RVA: 0x7FFAC2F9E740
    public void set_Prev(){} // RVA: 0x7FFAC2F49200
    public void Cancel(){} // RVA: 0x7FFAC92C76F0
    public void Fire(){} // RVA: 0x7FFAC92C7970
}

public class TimerQueue : Queue
{
    public UIntPtr m_ThisHandle; // 0x18
    public TimerNode m_Timers; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92C6BD0
    public void CreateTimer(){} // RVA: 0x7FFAC92C6D50
    public void Fire(){} // RVA: 0x7FFAC92C7250
}

public class TimerStateScheduledItem : VisualElementScheduledItem`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9BF43B0
    public void PerformTimerUpdate(){} // RVA: 0x7FFAC9BF4410
}

public class TimestampedRenderTexture : Object
{
    public UnityEngine.RenderTexture texture; // 0x10
    public long timestamp; // 0x18
    public bool used; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class TimingData : ValueType
{
    public long startTimeMs;
    public int durationMs;
    public System.Func`2<float,float> easingCurve;
    public float easedProgress;
    public float reversingShorteningFactor;
    public bool isStarted;
    public int delayMs;
}

public class Title : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368E70
}

public class ToCoroutineEnumerator : Object
{
    public bool Current; // 0x10
    public Cysharp.Threading.Tasks.UniTask task; // 0x18
    public System.Action`1<System.Exception> exceptionHandler; // 0x28
    public bool isStarted; // 0x30
    public System.Runtime.ExceptionServices.ExceptionDispatchInfo exception; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC94A2460
    public void RunTask(){} // RVA: 0x7FFAC94A2520
    public void get_Current(){} // RVA: 0x7FFAC34F9180
    public void MoveNext(){} // RVA: 0x7FFAC94A26B0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2F21310
}

public class ToCoroutineEnumerator`1 : Object
{
    public bool Current;
    public System.Action`1<T> resultHandler;
    public System.Action`1<System.Exception> exceptionHandler;
    public bool isStarted;
    public Cysharp.Threading.Tasks.UniTask`1<T> task;
    public object current;
    public System.Runtime.ExceptionServices.ExceptionDispatchInfo exception;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void RunTask(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2C58E90
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
}

public class ToRemoveData : ValueType
{
    public VRC.Dynamics.VRCPhysBoneBase comp; // 0x10
    public VRC.Dynamics.ChainId chainId; // 0x18
    public int executionGroup; // 0x28
    public Shape shape; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E43B40
}

public class ToStringClass : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEE880
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ToUnderlying : NumericConvertInstruction
{
    public object InstructionName;

    // ── Methods ──
    public void get_InstructionName(){} // RVA: 0x7FFAC8DE8850
    public void .ctor(){} // RVA: 0x7FFAC8DE8890
    public void Convert(){} // RVA: 0x7FFAC8DE88A0
}

public class ToUniTaskObserver`1 : Object
{
    public System.Action`1<object> callback;
    public Cysharp.Threading.Tasks.UniTaskCompletionSource`1<T> promise;
    public Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration registration;
    public bool hasValue;
    public T latestValue;

    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFAC2C70A10
    public void OnNext(){} // RVA: 0x7FFAC2E8DC40
    public void OnError(){} // RVA: 0x7FFAC2C70A40
    public void OnCompleted(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class ToggleEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C6EF90
}
