// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 406

public class T : Object
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

public class TDictionary : Object
{
}

public class TEdge : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class TEventEqualityComparerType : Object
{
}

public class TEventType : Object
{
}

public class TIME_DYNAMIC_ZONE_INFORMATION : ValueType
{
    // ── Methods ──
    public void GetTimeZoneKeyName(){} // RVA: 0x7FFE86733AE0
}

public class TIME_ZONE_INFORMATION : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86733B00
    public void GetStandardName(){} // RVA: 0x7FFE86733C20
    public void GetDaylightName(){} // RVA: 0x7FFE86733C30
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
}

public class TabbedContent : ValueType
{
}

public class TableEntry : ValueType
{
}

public class TableRange : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8673B0B0
}

public class TableSchemaInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8729D890
}

public class Tables : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E50660
}

public class TagInfo : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE8756F8F0
}

public class TagsLinkedList : Object
{
    // ── Methods ──
    public void GetEnumerator(){} // RVA: 0x7FFE8731B980
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator(){} // RVA: 0x7FFE8731B9E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8731BA70
}

public class Take : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
    public void OnError(){} // RVA: 0x7FFE80E460A0
    public void OnNext(){} // RVA: 0x7FFE810A1420
}

public class TangoUpdate : ValueType
{
}

public class Target : ValueType
{
}

public class TargetChild : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81171CA0
    public void Map(){} // RVA: 0x7FFE81171E10
}

public class TaskNode : Task`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A6DF90
    public void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem(){} // RVA: 0x7FFE86A6E010
    public void System.Threading.IThreadPoolWorkItem.MarkAborted(){} // RVA: 0x7FFE810FB310
}

public class TaskSocketAsyncEventArgs`1 : SocketAsyncEventArgs
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void GetCompletionResponsibility(){} // RVA: 0x7FFE810A1420
}

public class TaskWrapperAsyncResult : Object
{
    public System.Threading.Tasks.Task Task; // 0x10
    public object _state; // 0x18
    public bool _completedSynchronously; // 0x20
    public object field_3; // 0x20E

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8686A7A0
    public void System.IAsyncResult.get_AsyncState(){} // RVA: 0x7FFE810FE7C0
    public void System.IAsyncResult.get_CompletedSynchronously(){} // RVA: 0x7FFE811E99D0
    public void System.IAsyncResult.get_IsCompleted(){} // RVA: 0x7FFE82749A10
    public void System.IAsyncResult.get_AsyncWaitHandle(){} // RVA: 0x7FFE86A831F0
}

public class Tasks : Object
{
}

public class TeleportDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84423410
    public void Invoke(){} // RVA: 0x7FFE84423590
    public void BeginInvoke(){} // RVA: 0x7FFE8A445F50
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class TempAssemblyComparer : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Equals(){} // RVA: 0x7FFE872D9920
    public void GetHashCode(){} // RVA: 0x7FFE872D9B30
    public void .cctor(){} // RVA: 0x7FFE872D9C10
}

public class TensorMapping : Object
{
    public Google.Protobuf.MessageParser`1<TensorMapping> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public int DetectionsTensorIndexDefaultValue; // 0x8
    public int detectionsTensorIndex_; // 0x1C
    public int ClassesTensorIndexDefaultValue; // 0xC
    public int classesTensorIndex_; // 0x20
    public int ScoresTensorIndexDefaultValue; // 0x10
    public int scoresTensorIndex_; // 0x24
    public int NumDetectionsTensorIndexDefaultValue; // 0x14
    public int numDetectionsTensorIndex_; // 0x28
    public int AnchorsTensorIndexDefaultValue; // 0x18
    public int anchorsTensorIndex_; // 0x2C

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE8662FAA0
    public void get_Descriptor(){} // RVA: 0x7FFE8662FB00
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8662FB80
    public void .ctor(){} // RVA: 0x7FFE8662FC30 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE8662FD30
    public void get_DetectionsTensorIndex(){} // RVA: 0x7FFE8662FE60
    public void set_DetectionsTensorIndex(){} // RVA: 0x7FFE8659D0A0
    public void get_HasDetectionsTensorIndex(){} // RVA: 0x7FFE8659D0B0
    public void ClearDetectionsTensorIndex(){} // RVA: 0x7FFE8659D0C0
    public void get_ClassesTensorIndex(){} // RVA: 0x7FFE8662FED0
    public void set_ClassesTensorIndex(){} // RVA: 0x7FFE8659D140
    public void get_HasClassesTensorIndex(){} // RVA: 0x7FFE8659D150
    public void ClearClassesTensorIndex(){} // RVA: 0x7FFE8659D160
    public void get_ScoresTensorIndex(){} // RVA: 0x7FFE8662FF40
    public void set_ScoresTensorIndex(){} // RVA: 0x7FFE8662CDC0
    public void get_HasScoresTensorIndex(){} // RVA: 0x7FFE865A0350
    public void ClearScoresTensorIndex(){} // RVA: 0x7FFE865A0360
    public void get_NumDetectionsTensorIndex(){} // RVA: 0x7FFE8662FFB0
    public void set_NumDetectionsTensorIndex(){} // RVA: 0x7FFE86630020
    public void get_HasNumDetectionsTensorIndex(){} // RVA: 0x7FFE865A0910
    public void ClearNumDetectionsTensorIndex(){} // RVA: 0x7FFE865A0920
    public void get_AnchorsTensorIndex(){} // RVA: 0x7FFE86630030
    public void set_AnchorsTensorIndex(){} // RVA: 0x7FFE866300A0
    public void get_HasAnchorsTensorIndex(){} // RVA: 0x7FFE865A0B80
    public void ClearAnchorsTensorIndex(){} // RVA: 0x7FFE865A0B90
    public void Equals(){} // RVA: 0x7FFE86630200 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE86630310
    public void ToString(){} // RVA: 0x7FFE866303C0
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86630410
    public void CalculateSize(){} // RVA: 0x7FFE86630520
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866307F0
    public void .cctor(){} // RVA: 0x7FFE86630900
}

public class TestBuilder : Object
{
    // ── Methods ──
    public void Append(){} // RVA: 0x7FFE8719E8D0
    public void ToExpression(){} // RVA: 0x7FFE8719E970
    public void Push(){} // RVA: 0x7FFE8719EB70
    public void .ctor(){} // RVA: 0x7FFE8719EF60
}

public class TestClass : ValueType
{
}

public class TextBackingContainer : ValueType
{
    public uint[] m_Array; // 0x10
    public int m_Count; // 0x18
    public object field_2; // 0xFF00

    // ── Methods ──
    public void get_Capacity(){} // RVA: 0x7FFE841BEA60
    public void get_Count(){} // RVA: 0x7FFE82C33000
    public void set_Count(){} // RVA: 0x7FFE82C33010
    public void get_Item(){} // RVA: 0x7FFE84121140
    public void set_Item(){} // RVA: 0x7FFE87B487C0
    public void .ctor(){} // RVA: 0x7FFE87B48820
    public void Resize(){} // RVA: 0x7FFE87B488D0
}

public class TextEvent : ValueType
{
    public int Time; // 0x10

    // ── Methods ──
    public void get_TextEventType(){} // RVA: 0x7FFE82C770F0
}

public class TextInput : TextInputBase
{
    // ── Methods ──
    public void set_multiline(){} // RVA: 0x7FFE87EE4300
    public void set_isPasswordField(){} // RVA: 0x7FFE87EE4490
    public void StringToValue(){} // RVA: 0x7FFE82153650
    public void .ctor(){} // RVA: 0x7FFE87EE4530
}

public class TextInputBase : VisualElement
{
    public UnityEngine.UIElements.TextElement _textElement; // 0x3C8
    public UnityEngine.UIElements.ScrollView scrollView; // 0x3D0
    public UnityEngine.UIElements.VisualElement multilineContainer; // 0x3D8
    public string innerComponentsModifierName;
    public string innerTextElementUssClassName; // 0x8
    public string innerTextElementWithScrollViewUssClassName; // 0x10
    public string horizontalVariantInnerTextElementUssClassName; // 0x18
    public string verticalVariantInnerTextElementUssClassName; // 0x20
    public string verticalHorizontalVariantInnerTextElementUssClassName; // 0x28
    public string innerScrollviewUssClassName; // 0x30

    // ── Methods ──
    public void get_textElement(){} // RVA: 0x7FFE81B2D3F0
    public void set_textElement(){} // RVA: 0x7FFE81B09B30
    public void get_textSelection(){} // RVA: 0x7FFE85001980
    public void get_textEdition(){} // RVA: 0x7FFE85001980
    public void SelectAll(){} // RVA: 0x7FFE850019C0
    public void SelectNone(){} // RVA: 0x7FFE85001A50
    public void get_originalText(){} // RVA: 0x7FFE85001AE0
    public void StringToValue(){} // RVA: 0x7FFE81081080
    public void UpdateValueFromText(){} // RVA: 0x7FFE84FE3D10
    public void UpdateTextFromValue(){} // RVA: 0x7FFE84FE3DA0
    public void MoveFocusToCompositeRoot(){} // RVA: 0x7FFE84FE3E30
    public void get_isReadOnly(){} // RVA: 0x7FFE85001B20
    public void set_maxLength(){} // RVA: 0x7FFE85001BB0
    public void set_maskChar(){} // RVA: 0x7FFE85001C40
    public void get_isPasswordField(){} // RVA: 0x7FFE85001CE0
    public void set_isPasswordField(){} // RVA: 0x7FFE85001D70
    public void set_isDragging(){} // RVA: 0x7FFE84FE40C0
    public void get_text(){} // RVA: 0x7FFE85001E10
    public void set_text(){} // RVA: 0x7FFE85001E60
    public void .ctor(){} // RVA: 0x7FFE85001F50
    public void MakeSureScrollViewDoesNotLeakEvents(){} // RVA: 0x7FFE84FE4970
    public void SetSingleLine(){} // RVA: 0x7FFE850028F0
    public void SetMultiline(){} // RVA: 0x7FFE85002BE0
    public void ScrollViewOnGeometryChangedEvent(){} // RVA: 0x7FFE85003560
    public void TextElementOnGeometryChangedEvent(){} // RVA: 0x7FFE850035E0
    public void OnInputCustomStyleResolved(){} // RVA: 0x7FFE850036F0
    public void AcceptCharacter(){} // RVA: 0x7FFE85003B30
    public void UpdateScrollOffset(){} // RVA: 0x7FFE85003BB0 | overloaded x2
    public void GetScrollOffset(){} // RVA: 0x7FFE85004050
    public void SetScrollViewMode(){} // RVA: 0x7FFE85004510
    public void SetMultilineContainerStyle(){} // RVA: 0x7FFE850049D0
    public void RemoveSingleLineComponents(){} // RVA: 0x7FFE85004AA0
    public void RemoveMultilineComponents(){} // RVA: 0x7FFE85004CF0
    public void .cctor(){} // RVA: 0x7FFE850053E0
}

public class TextSelectionEvent : UnityEvent`3
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87B2F5C0
}

public class TextValueInput : TextInputBase
{
    public string _formatString;
    public object field_1; // 0x173
    public object field_2; // 0x174

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x7FFE80E2E2E0
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void AcceptCharacter(){} // RVA: 0x7FFE80E2FFD0
    public void get_allowedCharacters(){} // RVA: 0x7FFE80E2E2E0
    public void get_formatString(){} // RVA: 0x7FFE80E2E2E0
    public void set_formatString(){} // RVA: 0x7FFE80E460A0
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE810A1420
    public void StartDragging(){} // RVA: 0x7FFE80E45FE0
    public void StopDragging(){} // RVA: 0x7FFE80E45FE0
    public void ValueToString(){} // RVA: 0x7FFE810A1420
    public void StringToValue(){} // RVA: 0x7FFE810A1420
}

public class TextureChangedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87D9E3B0
    public void Invoke(){} // RVA: 0x7FFE87D9E490
}

public class TextureInfo : LinkedPoolItem`1
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFE87E25320
    public void Reset(){} // RVA: 0x7FFE87E25380
    public void .ctor(){} // RVA: 0x7FFE87E25410
    public void .cctor(){} // RVA: 0x7FFE87E25440
}

public class TextureRectMatrixf : ValueType
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFE86CB0EA0
    public void .cctor(){} // RVA: 0x7FFE86CB1170
}

public class TextureSheetAnimationModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0xB7
    public object field_2; // 0xB8
    public object field_3; // 0xB9
    public object field_4; // 0xBA
    public object field_5; // 0xBB
    public object field_6; // 0xBC
    public object field_7; // 0xBD
    public object field_8; // 0xBE
    public object field_9; // 0xBF
    public object field_10; // 0xC0
    public object field_11; // 0xC1
    public object field_12; // 0xC2
    public object field_13; // 0xC3
    public object field_14; // 0xC4
    public object field_15; // 0xC5
    public object field_16; // 0xC6

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CF7C00
    public void set_enabled(){} // RVA: 0x7FFE87CF7C50
    public void get_mode(){} // RVA: 0x7FFE87CF7CB0
    public void set_mode(){} // RVA: 0x7FFE87CF7D00
    public void get_timeMode(){} // RVA: 0x7FFE87CF7D60
    public void set_timeMode(){} // RVA: 0x7FFE87CF7DB0
    public void get_fps(){} // RVA: 0x7FFE87CF7E10
    public void set_fps(){} // RVA: 0x7FFE87CF7E60
    public void get_numTilesX(){} // RVA: 0x7FFE87CF7EC0
    public void set_numTilesX(){} // RVA: 0x7FFE87CF7F10
    public void get_numTilesY(){} // RVA: 0x7FFE87CF7F70
    public void set_numTilesY(){} // RVA: 0x7FFE87CF7FC0
    public void get_animation(){} // RVA: 0x7FFE87CF8020
    public void set_animation(){} // RVA: 0x7FFE87CF8070
    public void get_rowMode(){} // RVA: 0x7FFE87CF80D0
    public void set_rowMode(){} // RVA: 0x7FFE87CF8120
    public void get_frameOverTime(){} // RVA: 0x7FFE87CF8180
    public void set_frameOverTime(){} // RVA: 0x7FFE87CF81F0
    public void get_frameOverTimeMultiplier(){} // RVA: 0x7FFE87CF8250
    public void set_frameOverTimeMultiplier(){} // RVA: 0x7FFE87CF82A0
    public void get_startFrame(){} // RVA: 0x7FFE87CF8300
    public void set_startFrame(){} // RVA: 0x7FFE87CF8370
    public void get_startFrameMultiplier(){} // RVA: 0x7FFE87CF83D0
    public void set_startFrameMultiplier(){} // RVA: 0x7FFE87CF8420
    public void get_cycleCount(){} // RVA: 0x7FFE87CF8480
    public void set_cycleCount(){} // RVA: 0x7FFE87CF84D0
    public void get_rowIndex(){} // RVA: 0x7FFE87CF8530
    public void set_rowIndex(){} // RVA: 0x7FFE87CF8580
    public void get_uvChannelMask(){} // RVA: 0x7FFE87CF85E0
    public void set_uvChannelMask(){} // RVA: 0x7FFE87CF8630
    public void get_spriteCount(){} // RVA: 0x7FFE87CF8690
    public void get_speedRange(){} // RVA: 0x7FFE87CF86E0
    public void set_speedRange(){} // RVA: 0x7FFE87CF8740
    public void AddSprite(){} // RVA: 0x7FFE87CF87A0
    public void RemoveSprite(){} // RVA: 0x7FFE87CF8800
    public void SetSprite(){} // RVA: 0x7FFE87CF8860
    public void GetSprite(){} // RVA: 0x7FFE87CF88D0
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CF7C00
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CF7C50
    public void get_mode_Injected(){} // RVA: 0x7FFE87CF7CB0
    public void set_mode_Injected(){} // RVA: 0x7FFE87CF7D00
    public void get_timeMode_Injected(){} // RVA: 0x7FFE87CF7D60
    public void set_timeMode_Injected(){} // RVA: 0x7FFE87CF7DB0
    public void get_fps_Injected(){} // RVA: 0x7FFE87CF7E10
    public void set_fps_Injected(){} // RVA: 0x7FFE87CF7E60
    public void get_numTilesX_Injected(){} // RVA: 0x7FFE87CF7EC0
    public void set_numTilesX_Injected(){} // RVA: 0x7FFE87CF7F10
    public void get_numTilesY_Injected(){} // RVA: 0x7FFE87CF7F70
    public void set_numTilesY_Injected(){} // RVA: 0x7FFE87CF7FC0
    public void get_animation_Injected(){} // RVA: 0x7FFE87CF8020
    public void set_animation_Injected(){} // RVA: 0x7FFE87CF8070
    public void get_rowMode_Injected(){} // RVA: 0x7FFE87CF80D0
    public void set_rowMode_Injected(){} // RVA: 0x7FFE87CF8120
    public void get_frameOverTime_Injected(){} // RVA: 0x7FFE87CF8930
    public void set_frameOverTime_Injected(){} // RVA: 0x7FFE87CF8990
    public void get_frameOverTimeMultiplier_Injected(){} // RVA: 0x7FFE87CF8250
    public void set_frameOverTimeMultiplier_Injected(){} // RVA: 0x7FFE87CF82A0
    public void get_startFrame_Injected(){} // RVA: 0x7FFE87CF89F0
    public void set_startFrame_Injected(){} // RVA: 0x7FFE87CF8A50
    public void get_startFrameMultiplier_Injected(){} // RVA: 0x7FFE87CF83D0
    public void set_startFrameMultiplier_Injected(){} // RVA: 0x7FFE87CF8420
    public void get_cycleCount_Injected(){} // RVA: 0x7FFE87CF8480
    public void set_cycleCount_Injected(){} // RVA: 0x7FFE87CF84D0
    public void get_rowIndex_Injected(){} // RVA: 0x7FFE87CF8530
    public void set_rowIndex_Injected(){} // RVA: 0x7FFE87CF8580
    public void get_uvChannelMask_Injected(){} // RVA: 0x7FFE87CF85E0
    public void set_uvChannelMask_Injected(){} // RVA: 0x7FFE87CF8630
    public void get_spriteCount_Injected(){} // RVA: 0x7FFE87CF8690
    public void get_speedRange_Injected(){} // RVA: 0x7FFE87CF8AB0
    public void set_speedRange_Injected(){} // RVA: 0x7FFE87CF8B10
    public void AddSprite_Injected(){} // RVA: 0x7FFE87CF87A0
    public void RemoveSprite_Injected(){} // RVA: 0x7FFE87CF8800
    public void SetSprite_Injected(){} // RVA: 0x7FFE87CF8860
    public void GetSprite_Injected(){} // RVA: 0x7FFE87CF88D0
}

public class TfLite : Object
{
    public Google.Protobuf.MessageParser`1<TfLite> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public object field_2; // 0x34

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE86626DC0
    public void get_Descriptor(){} // RVA: 0x7FFE86626E20
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86626EA0
    public void .ctor(){} // RVA: 0x7FFE8657D850 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE86626F50
    public void Equals(){} // RVA: 0x7FFE8657DAE0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE8657DB20
    public void ToString(){} // RVA: 0x7FFE86627100
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8657DBB0
    public void CalculateSize(){} // RVA: 0x7FFE8657DBD0
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8657DCD0
    public void .cctor(){} // RVA: 0x7FFE86627150
}

public class ThreadContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ThreadLocalState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE873E9070
}

public class ThreadSafeRandom : Object
{
    // ── Methods ──
    public void Next(){} // RVA: 0x7FFE86D86AA0
    public void .cctor(){} // RVA: 0x7FFE86D86C70
}

public class ThreadedLoadingDebug : ValueType
{
}

public class Threefish1024Cipher : ThreefishCipher
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A094EE0
    public void EncryptBlock(){} // RVA: 0x7FFE8A0968B0
    public void DecryptBlock(){} // RVA: 0x7FFE8A097890
}

public class Threefish256Cipher : ThreefishCipher
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A094EE0
    public void EncryptBlock(){} // RVA: 0x7FFE8A094EF0
    public void DecryptBlock(){} // RVA: 0x7FFE8A0953B0
}

public class Threefish512Cipher : ThreefishCipher
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A094EE0
    public void EncryptBlock(){} // RVA: 0x7FFE8A095890
    public void DecryptBlock(){} // RVA: 0x7FFE8A096060
}

public class ThreefishCipher : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8680DC00
    public void EncryptBlock(){} // RVA: 0x7FFE80E4F230
    public void DecryptBlock(){} // RVA: 0x7FFE80E4F230
}

public class ThrowObservable`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Subscribe(){} // RVA: 0x7FFE80E2E390
}

public class Thumb : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81143A50
}

public class TickCallbackDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811EC370
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE87BB5330
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class TimeEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B06FD0
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class TimeRange : ValueType
{
    public float Start; // 0x10
    public float End; // 0x14

    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7FFE82AB98B0
    public void Contains(){} // RVA: 0x7FFE82807E20
    public void get_Empty(){} // RVA: 0x7FFE82AB98C0
    public void Include(){} // RVA: 0x7FFE82AB98E0
}

public class TimeSpanRawInfo : ValueType
{
    public 0x664D487C _lastSeenTTT; // 0x10
    public int _tokenCount; // 0x14
    public int _sepCount; // 0x18
    public int _numCount; // 0x1C

    // ── Methods ──
    public void get_PositiveInvariant(){} // RVA: 0x7FFE86906AA0
    public void get_NegativeInvariant(){} // RVA: 0x7FFE86906B20
    public void get_PositiveLocalized(){} // RVA: 0x7FFE86906BA0
    public void get_NegativeLocalized(){} // RVA: 0x7FFE86906C70
    public void FullAppCompatMatch(){} // RVA: 0x7FFE86906D40
    public void PartialAppCompatMatch(){} // RVA: 0x7FFE86907030
    public void FullMatch(){} // RVA: 0x7FFE869072A0
    public void FullDMatch(){} // RVA: 0x7FFE86907610
    public void FullHMMatch(){} // RVA: 0x7FFE86907790
    public void FullDHMMatch(){} // RVA: 0x7FFE86907970
    public void FullHMSMatch(){} // RVA: 0x7FFE86907BE0
    public void FullDHMSMatch(){} // RVA: 0x7FFE86907E50
    public void FullHMSFMatch(){} // RVA: 0x7FFE86908140
    public void Init(){} // RVA: 0x7FFE86908430
    public void ProcessToken(){} // RVA: 0x7FFE86908490
    public void AddSep(){} // RVA: 0x7FFE869086A0
    public void AddNum(){} // RVA: 0x7FFE869087F0
}

public class TimeSpanResult : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86908C60
    public void SetFailure(){} // RVA: 0x7FFE86908C70
}

public class TimeSpanSeconds : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x7FFE87359710
}

public class TimeSpanSplitter : ValueType
{
    // ── Methods ──
    public void TrySplitTimeSpan(){} // RVA: 0x7FFE86E12660
    public void ParseComponent(){} // RVA: 0x7FFE86E12920
}

public class TimeSpanToken : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86906730 | overloaded x4
    public void IsInvalidFraction(){} // RVA: 0x7FFE86906750
}

public class TimeSpanTokenizer : ValueType
{
    public System.ReadOnlySpan`1<char> _value; // 0x10
    public int _pos; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84456680 | overloaded x2
    public void GetNextToken(){} // RVA: 0x7FFE869067C0
    public void get_EOL(){} // RVA: 0x7FFE86906A00
    public void BackOne(){} // RVA: 0x7FFE86906A40
    public void get_NextChar(){} // RVA: 0x7FFE86906A50
}

public class TimelineAssetUpgrade : Object
{
}

public class TimelineClipUpgrade : Object
{
    // ── Methods ──
    public void UpgradeClipInFromGlobalToLocal(){} // RVA: 0x7FFE87B60520
}

public class TimelineInstance : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void Is(){} // RVA: 0x7FFE86DB3DB0
    public void StartCapture(){} // RVA: 0x7FFE86DB3EF0
    public void StopCapture(){} // RVA: 0x7FFE86DB40A0
}

public class TimeoutTracker : ValueType
{
    public int m_total; // 0x10
    public int m_start; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE871BF590
    public void get_RemainingMilliseconds(){} // RVA: 0x7FFE871BF610
    public void get_IsExpired(){} // RVA: 0x7FFE871BF650
}

public class Timer : Object
{
    public int m_StartTimeMilliseconds; // 0x10
    public int m_DurationMilliseconds; // 0x14
    public object field_2; // 0x47B

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8766F2D0
    public void get_StartTime(){} // RVA: 0x7FFE811485C0
    public void get_Expiration(){} // RVA: 0x7FFE8766F2F0
    public void Cancel(){} // RVA: 0x7FFE80E2F150
    public void get_HasExpired(){} // RVA: 0x7FFE80E2F150
    public void Dispose(){} // RVA: 0x7FFE811AFBE0
}

public class TimerComparer : ValueType
{
    // ── Methods ──
    public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFE86A81580
    public void Compare(){} // RVA: 0x7FFE86A81680
}

public class TimerNode : Timer
{
    public 0x66534B1C m_TimerState; // 0x18
    public Callback m_Callback; // 0x20
    public object m_Context; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8766FDE0 | overloaded x2
    public void get_HasExpired(){} // RVA: 0x7FFE8766FE10
    public void get_Next(){} // RVA: 0x7FFE8143BA80
    public void set_Next(){} // RVA: 0x7FFE81437330
    public void get_Prev(){} // RVA: 0x7FFE81178740
    public void set_Prev(){} // RVA: 0x7FFE81123200
    public void Cancel(){} // RVA: 0x7FFE8766FE20
    public void Fire(){} // RVA: 0x7FFE876700A0
}

public class TimerQueue : Queue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8766F300
    public void CreateTimer(){} // RVA: 0x7FFE8766F480
    public void Fire(){} // RVA: 0x7FFE8766F980
}

public class TimerStateScheduledItem : VisualElementScheduledItem`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87F9CC00
    public void PerformTimerUpdate(){} // RVA: 0x7FFE87F9CC60
}

public class TimestampedRenderTexture : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class TimingData : ValueType
{
}

public class Title : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86712770
}

public class ToCoroutineEnumerator : Object
{
    public bool completed; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8784ABA0
    public void RunTask(){} // RVA: 0x7FFE8784AC60
    public void get_Current(){} // RVA: 0x7FFE813240E0
    public void MoveNext(){} // RVA: 0x7FFE8784ADF0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE810FB310
}

public class ToCoroutineEnumerator`1 : Object
{
    public bool completed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void RunTask(){} // RVA: 0x7FFE810A1420
    public void get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
}

public class ToRemoveData : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE881F4570
}

public class ToStringClass : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87196CB0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ToUnderlying : NumericConvertInstruction
{
    // ── Methods ──
    public void get_InstructionName(){} // RVA: 0x7FFE87190C80
    public void .ctor(){} // RVA: 0x7FFE87190CC0
    public void Convert(){} // RVA: 0x7FFE87190CD0
}

public class ToUniTaskObserver`1 : Object
{
    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFE80E46070
    public void OnNext(){} // RVA: 0x7FFE810A1420
    public void OnError(){} // RVA: 0x7FFE80E460A0
    public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class ToggleEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE880177E0
}

public class Token : ValueType
{
    public object BoxedTrue;
    public object BoxedFalse; // 0x8
    public System.Collections.ICollection m_ArrayOrObject; // 0x10
    public System.ReadOnlyMemory`1<char> m_StringMemory; // 0x10
    public string m_StringInstance; // 0x10
    public double m_Number; // 0x18
    public bool m_Boolean; // 0x18
    public 0x664A2104 m_Type; // 0x20
    public 0x664A215C m_Flags; // 0x21

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFE811C55E0
    public void get_IsNull(){} // RVA: 0x7FFE818F2DD0
    public void get_Boolean(){} // RVA: 0x7FFE8A26C870
    public void get_Number(){} // RVA: 0x7FFE8A26C940
    public void get_String(){} // RVA: 0x7FFE8A26CA10
    public void get_StringInstance(){} // RVA: 0x7FFE8A26CBA0
    public void get_Array(){} // RVA: 0x7FFE8A26CCA0
    public void get_Object(){} // RVA: 0x7FFE8A26CDB0
    public void get_Value(){} // RVA: 0x7FFE8A26CEC0
    public void .ctor(){} // RVA: 0x7FFE8A26D2B0 | overloaded x6
    public void op_Implicit(){} // RVA: 0x7FFE8A26D5A0 | overloaded x6
    public void op_Explicit(){} // RVA: 0x7FFE8A26D820 | overloaded x6
    public void TryGetBool(){} // RVA: 0x7FFE8A26D870
    public void TryGetNumber(){} // RVA: 0x7FFE8A26D8F0
    public void TryGetArray(){} // RVA: 0x7FFE8A26D9A0
    public void TryGetObject(){} // RVA: 0x7FFE8A26DA00
    public void TryGetString(){} // RVA: 0x7FFE8A26DA60
    public void TryGetStringInstance(){} // RVA: 0x7FFE8A26DB70
    public void TryFromObject(){} // RVA: 0x7FFE80E2F7A0
    public void FromObject(){} // RVA: 0x7FFE80E2DDD0
    public void ToString(){} // RVA: 0x7FFE8A26DBD0
    public void GetHashCode(){} // RVA: 0x7FFE8A26DD80
    public void ToLegacyObject(){} // RVA: 0x7FFE8A26DF60
    public void GetInnerType(){} // RVA: 0x7FFE8A26E1A0
    public void CompareTo(){} // RVA: 0x7FFE8A26E370
    public void Equals(){} // RVA: 0x7FFE8A26E9C0 | overloaded x2
    public void op_Equality(){} // RVA: 0x7FFE8A26EA90
    public void op_Inequality(){} // RVA: 0x7FFE8A26EB20
    public void .cctor(){} // RVA: 0x7FFE8A26EB90
}

public class TokenHashValue : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE861ED650
}

public class TokenInfo : Info
{
    public int _tokens; // 0x80
    public int _amount; // 0x84
    public string _imageUrl; // 0x88

    // ── Methods ──
    public void get_tokens(){} // RVA: 0x7FFE81D30560
    public void set_tokens(){} // RVA: 0x7FFE81D307B0
    public void get_amount(){} // RVA: 0x7FFE829DF2E0
    public void set_amount(){} // RVA: 0x7FFE829DF3B0
    public void get_imageUrl(){} // RVA: 0x7FFE8113A010
    public void set_imageUrl(){} // RVA: 0x7FFE81280F90
    public void .ctor(){} // RVA: 0x7FFE8A350390
}
