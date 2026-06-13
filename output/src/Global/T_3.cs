// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 585

public class TextInputBase
{
    public UnityEngine.UIElements.TextElement <textElement>k__BackingField; // 0x3C8
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
    public void get_textElement(){} // RVA: 0xD96B00
    public void set_textElement(){} // RVA: 0xD88960
    public void get_textSelection(){} // RVA: 0x43A9040
    public void get_textEdition(){} // RVA: 0x43A9040
    public void SelectAll(){} // RVA: 0x43B4530
    public void SelectNone(){} // RVA: 0x43B4590
    public void get_originalText(){} // RVA: 0x43A9120
    public void StringToValue(){} // RVA: 0x34B0F90
    public void UpdateValueFromText(){} // RVA: 0x43A9150
    public void UpdateTextFromValue(){} // RVA: 0x43A91E0
    public void MoveFocusToCompositeRoot(){} // RVA: 0x43A9270
    public void get_isReadOnly(){} // RVA: 0x43B45F0
    public void set_maxLength(){} // RVA: 0x43B4650
    public void set_maskChar(){} // RVA: 0x43B46B0
    public void get_isPasswordField(){} // RVA: 0x43B4720
    public void set_isPasswordField(){} // RVA: 0x43B4780
    public void set_isDragging(){} // RVA: 0x43A9500
    public void get_text(){} // RVA: 0x43A9510
    public void set_text(){} // RVA: 0x43A9540
    public void .ctor(){} // RVA: 0x43B47F0
    public void MakeSureScrollViewDoesNotLeakEvents(){} // RVA: 0x43A9DB0
    public void SetSingleLine(){} // RVA: 0x43B4FC0
    public void SetMultiline(){} // RVA: 0x43B5260
    public void ScrollViewOnGeometryChangedEvent(){} // RVA: 0x43B5AF0
    public void TextElementOnGeometryChangedEvent(){} // RVA: 0x43B5B80
    public void OnInputCustomStyleResolved(){} // RVA: 0x43B5C90
    public void AcceptCharacter(){} // RVA: 0x43B6070
    public void UpdateScrollOffset(){} // RVA: 0x43B6100 | overloaded x2
    public void GetScrollOffset(){} // RVA: 0x43B64F0
    public void SetScrollViewMode(){} // RVA: 0x43B68E0
    public void SetMultilineContainerStyle(){} // RVA: 0x43B6CB0
    public void RemoveSingleLineComponents(){} // RVA: 0x43B6D80
    public void RemoveMultilineComponents(){} // RVA: 0x43B6F60
    public void .cctor(){} // RVA: 0x43B7580
}

public class TextInputBase
{
    public UnityEngine.UIElements.TextElement <textElement>k__BackingField; // 0x3C8
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
    public void get_textElement(){} // RVA: 0xD96B00
    public void set_textElement(){} // RVA: 0xD88960
    public void get_textSelection(){} // RVA: 0x43A9040
    public void get_textEdition(){} // RVA: 0x43A9040
    public void SelectAll(){} // RVA: 0x43BF720
    public void SelectNone(){} // RVA: 0x43BF780
    public void get_originalText(){} // RVA: 0x43A9120
    public void StringToValue(){} // RVA: 0x34B0F90
    public void UpdateValueFromText(){} // RVA: 0x43A9150
    public void UpdateTextFromValue(){} // RVA: 0x43A91E0
    public void MoveFocusToCompositeRoot(){} // RVA: 0x43A9270
    public void get_isReadOnly(){} // RVA: 0x43BF7E0
    public void set_maxLength(){} // RVA: 0x43BF840
    public void set_maskChar(){} // RVA: 0x43BF8A0
    public void get_isPasswordField(){} // RVA: 0x43BF910
    public void set_isPasswordField(){} // RVA: 0x43BF970
    public void set_isDragging(){} // RVA: 0x43A9500
    public void get_text(){} // RVA: 0x43A9510
    public void set_text(){} // RVA: 0x43A9540
    public void .ctor(){} // RVA: 0x43BF9E0
    public void MakeSureScrollViewDoesNotLeakEvents(){} // RVA: 0x43A9DB0
    public void SetSingleLine(){} // RVA: 0x43C01B0
    public void SetMultiline(){} // RVA: 0x43C0450
    public void ScrollViewOnGeometryChangedEvent(){} // RVA: 0x43C0CE0
    public void TextElementOnGeometryChangedEvent(){} // RVA: 0x43C0D70
    public void OnInputCustomStyleResolved(){} // RVA: 0x43C0E80
    public void AcceptCharacter(){} // RVA: 0x43C1260
    public void UpdateScrollOffset(){} // RVA: 0x43C12F0 | overloaded x2
    public void GetScrollOffset(){} // RVA: 0x43C16E0
    public void SetScrollViewMode(){} // RVA: 0x43C1AD0
    public void SetMultilineContainerStyle(){} // RVA: 0x43C1EA0
    public void RemoveSingleLineComponents(){} // RVA: 0x43C1F70
    public void RemoveMultilineComponents(){} // RVA: 0x43C2150
    public void .cctor(){} // RVA: 0x43C2770
}

public class TextInputBase
{
    public UnityEngine.UIElements.TextElement <textElement>k__BackingField; // 0x3C8
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
    public void get_textElement(){} // RVA: 0xD96B00
    public void set_textElement(){} // RVA: 0xD88960
    public void get_textSelection(){} // RVA: 0x43A9040
    public void get_textEdition(){} // RVA: 0x43A9040
    public void SelectAll(){} // RVA: 0x43C3270
    public void SelectNone(){} // RVA: 0x43C32D0
    public void get_originalText(){} // RVA: 0x43A9120
    public void StringToValue(){} // RVA: 0x34B0F90
    public void UpdateValueFromText(){} // RVA: 0x43A9150
    public void UpdateTextFromValue(){} // RVA: 0x43A91E0
    public void MoveFocusToCompositeRoot(){} // RVA: 0x43A9270
    public void get_isReadOnly(){} // RVA: 0x43C3330
    public void set_maxLength(){} // RVA: 0x43C3390
    public void set_maskChar(){} // RVA: 0x43C33F0
    public void get_isPasswordField(){} // RVA: 0x43C3460
    public void set_isPasswordField(){} // RVA: 0x43C34C0
    public void set_isDragging(){} // RVA: 0x43A9500
    public void get_text(){} // RVA: 0x43A9510
    public void set_text(){} // RVA: 0x43A9540
    public void .ctor(){} // RVA: 0x43C3530
    public void MakeSureScrollViewDoesNotLeakEvents(){} // RVA: 0x43A9DB0
    public void SetSingleLine(){} // RVA: 0x43C3D00
    public void SetMultiline(){} // RVA: 0x43C3FA0
    public void ScrollViewOnGeometryChangedEvent(){} // RVA: 0x43C4830
    public void TextElementOnGeometryChangedEvent(){} // RVA: 0x43C48C0
    public void OnInputCustomStyleResolved(){} // RVA: 0x43C49D0
    public void AcceptCharacter(){} // RVA: 0x43C4DB0
    public void UpdateScrollOffset(){} // RVA: 0x43C4E40 | overloaded x2
    public void GetScrollOffset(){} // RVA: 0x43C5230
    public void SetScrollViewMode(){} // RVA: 0x43C5620
    public void SetMultilineContainerStyle(){} // RVA: 0x43C59F0
    public void RemoveSingleLineComponents(){} // RVA: 0x43C5AC0
    public void RemoveMultilineComponents(){} // RVA: 0x43C5CA0
    public void .cctor(){} // RVA: 0x43C62C0
}

public class TextInputBase
{
    public UnityEngine.UIElements.TextElement <textElement>k__BackingField; // 0x3C8
    public UnityEngine.UIElements.ScrollView scrollView; // 0x3D0
    public UnityEngine.UIElements.VisualElement multilineContainer; // 0x3D8
    public string innerComponentsModifierName;
    public string innerTextElementUssClassName; // 0x8
    public string innerTextElementWithScrollViewUssClassName; // 0x10
    public string horizontalVariantInnerTextElementUssClassName; // 0x18
    public string verticalVariantInnerTextElementUssClassName; // 0x20
    public string verticalHorizontalVariantInnerTextElementUssClassName; // 0x28
    public string innerScrollviewUssClassName; // 0x30
}

public class TextSelectionEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6FEE6F0
}

public class TextValueInput
{
    public string <formatString>k__BackingField;

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0xCD60
    public void .ctor(){} // RVA: 0x24A50
    public void AcceptCharacter(){} // RVA: 0xEA60
    public void get_allowedCharacters(){} // RVA: 0xCD60
    public void get_formatString(){} // RVA: 0xCD60
    public void set_formatString(){} // RVA: 0x24B10
    public void ApplyInputDeviceDelta(){} // RVA: 0x283FA0
    public void StartDragging(){} // RVA: 0x24A50
    public void StopDragging(){} // RVA: 0x24A50
    public void ValueToString(){} // RVA: 0x283FA0
    public void StringToValue(){} // RVA: 0x283FA0
}

public class TextValueInput
{
    public string <formatString>k__BackingField; // 0x400

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x43E8A90
    public void .ctor(){} // RVA: 0x43E8B20
    public void AcceptCharacter(){} // RVA: 0x43E8C10
    public void get_allowedCharacters(){} // RVA: 0xCD60
    public void get_formatString(){} // RVA: 0xD8BD40
    public void set_formatString(){} // RVA: 0xD93E40
    public void ApplyInputDeviceDelta(){}
    public void StartDragging(){} // RVA: 0x43E8CE0
    public void StopDragging(){} // RVA: 0x43E8D70
    public void ValueToString(){}
    public void StringToValue(){} // RVA: 0x43E8EB0
}

public class TextValueInput
{
    public string <formatString>k__BackingField; // 0x400

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x43E8A90
    public void .ctor(){} // RVA: 0x43E9620
    public void AcceptCharacter(){} // RVA: 0x43E9710
    public void get_allowedCharacters(){} // RVA: 0xCD60
    public void get_formatString(){} // RVA: 0xD8BD40
    public void set_formatString(){} // RVA: 0xD93E40
    public void ApplyInputDeviceDelta(){}
    public void StartDragging(){} // RVA: 0x43E97E0
    public void StopDragging(){} // RVA: 0x43E9870
    public void ValueToString(){}
    public void StringToValue(){} // RVA: 0x43E8EB0
}

public class TextValueInput
{
    public string <formatString>k__BackingField; // 0x400

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x43E8A90
    public void .ctor(){} // RVA: 0x43E8F00
    public void AcceptCharacter(){} // RVA: 0x43E8FF0
    public void get_allowedCharacters(){} // RVA: 0xCD60
    public void get_formatString(){} // RVA: 0xD8BD40
    public void set_formatString(){} // RVA: 0xD93E40
    public void ApplyInputDeviceDelta(){}
    public void StartDragging(){} // RVA: 0x43E90C0
    public void StopDragging(){} // RVA: 0x43E9150
    public void ValueToString(){} // RVA: 0x1BCC0
    public void StringToValue(){} // RVA: 0x43E8EB0
}

public class TextValueInput
{
    public string <formatString>k__BackingField; // 0x400

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x43E8A90
    public void .ctor(){} // RVA: 0x43E9290
    public void AcceptCharacter(){} // RVA: 0x43E9380
    public void get_allowedCharacters(){} // RVA: 0xCD60
    public void get_formatString(){} // RVA: 0xD8BD40
    public void set_formatString(){} // RVA: 0xD93E40
    public void ApplyInputDeviceDelta(){}
    public void StartDragging(){} // RVA: 0x43E9450
    public void StopDragging(){} // RVA: 0x43E94E0
    public void ValueToString(){}
    public void StringToValue(){} // RVA: 0x43E8EB0
}

public class TextValueInput
{
    public string <formatString>k__BackingField; // 0x400

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x43E8A90
    public void .ctor(){} // RVA: 0x43E99B0
    public void AcceptCharacter(){} // RVA: 0x43E9AA0
    public void get_allowedCharacters(){} // RVA: 0xCD60
    public void get_formatString(){} // RVA: 0xD8BD40
    public void set_formatString(){} // RVA: 0xD93E40
    public void ApplyInputDeviceDelta(){}
    public void StartDragging(){} // RVA: 0x43E9B70
    public void StopDragging(){} // RVA: 0x43E9C00
    public void ValueToString(){}
    public void StringToValue(){} // RVA: 0x43E8EB0
}

public class TextValueInput
{
    public string <formatString>k__BackingField; // 0x400

    // ── Methods ──
    public void get_textValueFieldParent(){} // RVA: 0x43E8A90
    public void .ctor(){} // RVA: 0x43E9D40
    public void AcceptCharacter(){} // RVA: 0x43E9E30
    public void get_allowedCharacters(){} // RVA: 0xCD60
    public void get_formatString(){} // RVA: 0xD8BD40
    public void set_formatString(){} // RVA: 0xD93E40
    public void ApplyInputDeviceDelta(){}
    public void StartDragging(){} // RVA: 0x43E9F00
    public void StopDragging(){} // RVA: 0x43E9F90
    public void ValueToString(){}
    public void StringToValue(){} // RVA: 0x43E8EB0
}

public class TextureChangedCallback
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x725E210
    public void Invoke(){} // RVA: 0x725E2F0
}

public class TextureInfo
{
    // ── Methods ──
    public void Create(){} // RVA: 0x72E51A0
    public void Reset(){} // RVA: 0x72E5200
    public void .ctor(){} // RVA: 0x72E5290
    public void .cctor(){} // RVA: 0x72E52C0
}

public class TextureInfo
{
}

public class TextureRectMatrixf
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x61700C0
    public void .cctor(){} // RVA: 0x6170390
}

public class TextureSheetAnimationModule
{
    public UnityEngine.ParticleSystem lifetime; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x100A2F0
    public void get_enabled(){} // RVA: 0x71B7A60
    public void set_enabled(){} // RVA: 0x71B7AB0
    public void get_mode(){} // RVA: 0x71B7B10
    public void set_mode(){} // RVA: 0x71B7B60
    public void get_timeMode(){} // RVA: 0x71B7BC0
    public void set_timeMode(){} // RVA: 0x71B7C10
    public void get_fps(){} // RVA: 0x71B7C70
    public void set_fps(){} // RVA: 0x71B7CC0
    public void get_numTilesX(){} // RVA: 0x71B7D20
    public void set_numTilesX(){} // RVA: 0x71B7D70
    public void get_numTilesY(){} // RVA: 0x71B7DD0
    public void set_numTilesY(){} // RVA: 0x71B7E20
    public void get_animation(){} // RVA: 0x71B7E80
    public void set_animation(){} // RVA: 0x71B7ED0
    public void get_rowMode(){} // RVA: 0x71B7F30
    public void set_rowMode(){} // RVA: 0x71B7F80
    public void get_frameOverTime(){} // RVA: 0x71B7FE0
    public void set_frameOverTime(){} // RVA: 0x71B8050
    public void get_frameOverTimeMultiplier(){} // RVA: 0x71B80B0
    public void set_frameOverTimeMultiplier(){} // RVA: 0x71B8100
    public void get_startFrame(){} // RVA: 0x71B8160
    public void set_startFrame(){} // RVA: 0x71B81D0
    public void get_startFrameMultiplier(){} // RVA: 0x71B8230
    public void set_startFrameMultiplier(){} // RVA: 0x71B8280
    public void get_cycleCount(){} // RVA: 0x71B82E0
    public void set_cycleCount(){} // RVA: 0x71B8330
    public void get_rowIndex(){} // RVA: 0x71B8390
    public void set_rowIndex(){} // RVA: 0x71B83E0
    public void get_uvChannelMask(){} // RVA: 0x71B8440
    public void set_uvChannelMask(){} // RVA: 0x71B8490
    public void get_spriteCount(){} // RVA: 0x71B84F0
    public void get_speedRange(){} // RVA: 0x71B8540
    public void set_speedRange(){} // RVA: 0x71B85A0
    public void AddSprite(){} // RVA: 0x71B8600
    public void RemoveSprite(){} // RVA: 0x71B8660
    public void SetSprite(){} // RVA: 0x71B86C0
    public void GetSprite(){} // RVA: 0x71B8730
    public void get_enabled_Injected(){} // RVA: 0x71B7A60
    public void set_enabled_Injected(){} // RVA: 0x71B7AB0
    public void get_mode_Injected(){} // RVA: 0x71B7B10
    public void set_mode_Injected(){} // RVA: 0x71B7B60
    public void get_timeMode_Injected(){} // RVA: 0x71B7BC0
    public void set_timeMode_Injected(){} // RVA: 0x71B7C10
    public void get_fps_Injected(){} // RVA: 0x71B7C70
    public void set_fps_Injected(){} // RVA: 0x71B7CC0
    public void get_numTilesX_Injected(){} // RVA: 0x71B7D20
    public void set_numTilesX_Injected(){} // RVA: 0x71B7D70
    public void get_numTilesY_Injected(){} // RVA: 0x71B7DD0
    public void set_numTilesY_Injected(){} // RVA: 0x71B7E20
    public void get_animation_Injected(){} // RVA: 0x71B7E80
    public void set_animation_Injected(){} // RVA: 0x71B7ED0
    public void get_rowMode_Injected(){} // RVA: 0x71B7F30
    public void set_rowMode_Injected(){} // RVA: 0x71B7F80
    public void get_frameOverTime_Injected(){} // RVA: 0x71B8790
    public void set_frameOverTime_Injected(){} // RVA: 0x71B87F0
    public void get_frameOverTimeMultiplier_Injected(){} // RVA: 0x71B80B0
    public void set_frameOverTimeMultiplier_Injected(){} // RVA: 0x71B8100
    public void get_startFrame_Injected(){} // RVA: 0x71B8850
    public void set_startFrame_Injected(){} // RVA: 0x71B88B0
    public void get_startFrameMultiplier_Injected(){} // RVA: 0x71B8230
    public void set_startFrameMultiplier_Injected(){} // RVA: 0x71B8280
    public void get_cycleCount_Injected(){} // RVA: 0x71B82E0
    public void set_cycleCount_Injected(){} // RVA: 0x71B8330
    public void get_rowIndex_Injected(){} // RVA: 0x71B8390
    public void set_rowIndex_Injected(){} // RVA: 0x71B83E0
    public void get_uvChannelMask_Injected(){} // RVA: 0x71B8440
    public void set_uvChannelMask_Injected(){} // RVA: 0x71B8490
    public void get_spriteCount_Injected(){} // RVA: 0x71B84F0
    public void get_speedRange_Injected(){} // RVA: 0x71B8910
    public void set_speedRange_Injected(){} // RVA: 0x71B8970
    public void AddSprite_Injected(){} // RVA: 0x71B8600
    public void RemoveSprite_Injected(){} // RVA: 0x71B8660
    public void SetSprite_Injected(){} // RVA: 0x71B86C0
    public void GetSprite_Injected(){} // RVA: 0x71B8730
}

public class TfLite
{
    public Google.Protobuf.MessageParser`1<TfLite> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x5AE5F90
    public void get_Descriptor(){} // RVA: 0x5AE5FF0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AE6070
    public void .ctor(){} // RVA: 0x5A3CAF0 | overloaded x2
    public void Clone(){} // RVA: 0x5AE6120
    public void Equals(){} // RVA: 0x5A3CD80 | overloaded x2
    public void GetHashCode(){} // RVA: 0x5A3CDC0
    public void ToString(){} // RVA: 0x5AE62D0
    public void WriteTo(){} // RVA: 0x5A39740
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A3CE50
    public void CalculateSize(){} // RVA: 0x5A3CE70
    public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A3CF70
    public void .cctor(){} // RVA: 0x5AE6320
}

public class ThreadContext
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class ThreadLocalState
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x68A9DA0
}

public class ThreadSafeRandom
{
    // ── Methods ──
    public void Next(){} // RVA: 0x6245FC0
    public void .cctor(){} // RVA: 0x6246190
}

public class ThreadedLoadingDebug
{
}

public class Threefish1024Cipher
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x9632B00
    public void EncryptBlock(){} // RVA: 0x96344D0
    public void DecryptBlock(){} // RVA: 0x96354B0
}

public class Threefish256Cipher
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x9632B00
    public void EncryptBlock(){} // RVA: 0x9632B10
    public void DecryptBlock(){} // RVA: 0x9632FD0
}

public class Threefish512Cipher
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x9632B00
    public void EncryptBlock(){} // RVA: 0x96334B0
    public void DecryptBlock(){} // RVA: 0x9633C80
}

public class ThreefishCipher
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5CCCD00
    public void EncryptBlock(){} // RVA: 0x2DC60
    public void DecryptBlock(){} // RVA: 0x2DC60
}

public class ThrowObservable`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x24B10
    public void Subscribe(){} // RVA: 0xCE10
}

public class Thumb
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x325A50
}

public class TickCallbackDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3CE370
    public void Invoke(){} // RVA: 0x338C60
    public void BeginInvoke(){} // RVA: 0x7074470
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class TimeEventHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x1D76630
    public void Invoke(){} // RVA: 0x439370
}

public class TimeRange
{
    public float Start; // 0x10
    public float End; // 0x14

    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x1D2BA30
    public void Contains(){} // RVA: 0x1A817E0
    public void get_Empty(){} // RVA: 0x1D2BA40
    public void Include(){} // RVA: 0x1D2BA60
}

public class TimeSpanRawInfo
{
    public 0x657F68D8 _lastSeenTTT; // 0x10
    public int _tokenCount; // 0x14
    public int _sepCount; // 0x18
    public int _numCount; // 0x1C

    // ── Methods ──
    public void get_PositiveInvariant(){} // RVA: 0x5DC5C10
    public void get_NegativeInvariant(){} // RVA: 0x5DC5C90
    public void get_PositiveLocalized(){} // RVA: 0x5DC5D10
    public void get_NegativeLocalized(){} // RVA: 0x5DC5DE0
    public void FullAppCompatMatch(){} // RVA: 0x5DC5EB0
    public void PartialAppCompatMatch(){} // RVA: 0x5DC61A0
    public void FullMatch(){} // RVA: 0x5DC6410
    public void FullDMatch(){} // RVA: 0x5DC6780
    public void FullHMMatch(){} // RVA: 0x5DC6900
    public void FullDHMMatch(){} // RVA: 0x5DC6AE0
    public void FullHMSMatch(){} // RVA: 0x5DC6D50
    public void FullDHMSMatch(){} // RVA: 0x5DC6FC0
    public void FullHMSFMatch(){} // RVA: 0x5DC72B0
    public void Init(){} // RVA: 0x5DC75A0
    public void ProcessToken(){} // RVA: 0x5DC7600
    public void AddSep(){} // RVA: 0x5DC7810
    public void AddNum(){} // RVA: 0x5DC7960
}

public class TimeSpanResult
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5DC7DD0
    public void SetFailure(){} // RVA: 0x5DC7DE0
}

public class TimeSpanSeconds
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x681A430
}

public class TimeSpanSplitter
{
    // ── Methods ──
    public void TrySplitTimeSpan(){} // RVA: 0x62D1C30
    public void ParseComponent(){} // RVA: 0x62D1EF0
}

public class TimeSpanSplitter
{
    // ── Methods ──
    public void TrySplitTimeSpan(){} // RVA: 0x5E1E1E0
    public void ParseComponent(){} // RVA: 0x5E1E460
}

public class TimeSpanToken
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5DC58A0 | overloaded x4
    public void IsInvalidFraction(){} // RVA: 0x5DC58C0
}

public class TimeSpanTokenizer
{
    public System.ReadOnlySpan`1<char> PositiveInvariant; // 0x10
    public int NegativeInvariant; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x37C5C40 | overloaded x2
    public void GetNextToken(){} // RVA: 0x5DC5930
    public void get_EOL(){} // RVA: 0x5DC5B70
    public void BackOne(){} // RVA: 0x5DC5BB0
    public void get_NextChar(){} // RVA: 0x5DC5BC0
}

public class TimelineAssetUpgrade
{
}

public class TimelineClipUpgrade
{
    // ── Methods ──
    public void UpgradeClipInFromGlobalToLocal(){} // RVA: 0x701F650
}

public class TimelineInstance
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DEE30
    public void Is(){} // RVA: 0x6273390
    public void StartCapture(){} // RVA: 0x62734D0
    public void StopCapture(){} // RVA: 0x6273680
}

public class TimeoutTracker
{
    public int m_total; // 0x10
    public int m_start; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66806A0
    public void get_RemainingMilliseconds(){} // RVA: 0x6680720
    public void get_IsExpired(){} // RVA: 0x6680760
}

public class Timer
{
    public int m_StartTimeMilliseconds; // 0x10
    public int m_DurationMilliseconds; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B30020
    public void get_StartTime(){} // RVA: 0x32A5C0
    public void get_Expiration(){} // RVA: 0x6B30040
    public void Cancel(){} // RVA: 0xDBE0
    public void get_HasExpired(){} // RVA: 0xDBE0
    public void Dispose(){} // RVA: 0x391BE0
}

public class TimerComparer
{
    // ── Methods ──
    public void System.Collections.IComparer.Compare(){} // RVA: 0x5F40760
    public void Compare(){} // RVA: 0x5F40860
}

public class TimerNode
{
    public 0x65856B78 m_TimerState; // 0x18
    public Callback m_Callback; // 0x20
    public object m_Context; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B30B30 | overloaded x2
    public void get_HasExpired(){} // RVA: 0x6B30B60
    public void get_Next(){} // RVA: 0x4976A0
    public void set_Next(){} // RVA: 0x49B830
    public void get_Prev(){} // RVA: 0x35A740
    public void set_Prev(){} // RVA: 0x305200
    public void Cancel(){} // RVA: 0x6B30B70
    public void Fire(){} // RVA: 0x6B30DF0
}

public class TimerQueue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6B30050
    public void CreateTimer(){} // RVA: 0x6B301D0
    public void Fire(){} // RVA: 0x6B306D0
}

public class TimerStateScheduledItem
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x745CA60
    public void PerformTimerUpdate(){} // RVA: 0x745CAC0
}

public class TimestampedRenderTexture
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class TimingData
{
}

public class Title
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x5BD1920
}

public class ToCoroutineEnumerator
{
    public bool completed; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6D09D00
    public void RunTask(){} // RVA: 0x6D09DC0
    public void get_Current(){} // RVA: 0x519240
    public void MoveNext(){} // RVA: 0x6D09F50
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x2DD310
}

public class ToCoroutineEnumerator`1
{
    public bool completed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x283FA0
    public void RunTask(){} // RVA: 0x283FA0
    public void get_Current(){} // RVA: 0xCD60
    public void MoveNext(){} // RVA: 0xDBE0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x24A50
}

public class ToRemoveData
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x76B7410
}

public class ToStringClass
{
    // ── Methods ──
    public void Run(){} // RVA: 0x6657DC0
    public void .ctor(){} // RVA: 0x2DD310
}

public class ToUnderlying
{
    // ── Methods ──
    public void get_InstructionName(){} // RVA: 0x6651D90
    public void .ctor(){} // RVA: 0x6651DD0
    public void Convert(){} // RVA: 0x6651DE0
}

public class ToUniTaskObserver`1
{
    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x24AE0
    public void OnNext(){} // RVA: 0x283FA0
    public void OnError(){} // RVA: 0x24B10
    public void OnCompleted(){} // RVA: 0x24A50
    public void .cctor(){} // RVA: 0x24A80
}

public class ToggleEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x74D7620
}

public class Token
{
    public object BoxedTrue;
    public object BoxedFalse; // 0x8
    public System.Collections.ICollection m_ArrayOrObject; // 0x10
    public System.ReadOnlyMemory`1<char> m_StringMemory; // 0x10
    public string m_StringInstance; // 0x10
    public double m_Number; // 0x18
    public bool m_Boolean; // 0x18
    public 0x657C3710 m_Type; // 0x20
    public 0x657C3768 m_Flags; // 0x21

    // ── Methods ──
    public void get_Type(){} // RVA: 0x3A75E0
    public void get_IsNull(){} // RVA: 0xB84FF0
    public void get_Boolean(){} // RVA: 0x980A530
    public void get_Number(){} // RVA: 0x980A600
    public void get_String(){} // RVA: 0x980A6D0
    public void get_StringInstance(){} // RVA: 0x980A860
    public void get_Array(){} // RVA: 0x980A960
    public void get_Object(){} // RVA: 0x980AA70
    public void get_Value(){} // RVA: 0x980AB80
    public void .ctor(){} // RVA: 0x980AF70 | overloaded x6
    public void op_Implicit(){} // RVA: 0x980B260 | overloaded x6
    public void op_Explicit(){} // RVA: 0x980B4E0 | overloaded x6
    public void TryGetBool(){} // RVA: 0x980B530
    public void TryGetNumber(){} // RVA: 0x980B5B0
    public void TryGetArray(){} // RVA: 0x980B660
    public void TryGetObject(){} // RVA: 0x980B6C0
    public void TryGetString(){} // RVA: 0x980B720
    public void TryGetStringInstance(){} // RVA: 0x980B830
    public void TryFromObject(){} // RVA: 0xE230
    public void FromObject(){} // RVA: 0xC850
    public void ToString(){} // RVA: 0x980B890
    public void GetHashCode(){} // RVA: 0x980BA40
    public void ToLegacyObject(){} // RVA: 0x980BC20
    public void GetInnerType(){} // RVA: 0x980BE60
    public void CompareTo(){} // RVA: 0x980C030
    public void Equals(){} // RVA: 0x980C680 | overloaded x2
    public void op_Equality(){} // RVA: 0x980C750
    public void op_Inequality(){} // RVA: 0x980C7E0
    public void .cctor(){} // RVA: 0x980C850
}

public class Token
{
    public object BoxedTrue;
    public object BoxedFalse; // 0x8
    public System.Collections.ICollection m_ArrayOrObject; // 0x10
    public System.ReadOnlyMemory`1<char> m_StringMemory; // 0x10
    public string m_StringInstance; // 0x10
    public double m_Number; // 0x18
    public bool m_Boolean; // 0x18
    public 0x657C3710 m_Type; // 0x20
    public 0x657C3768 m_Flags; // 0x21

    // ── Methods ──
    public void Check(){} // RVA: 0x6819790
    public void TryCheck(){} // RVA: 0x68198B0
}

public class TokenHashValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x573CD50
}

public class TokenInfo
{
    public int <tokens>k__BackingField; // 0x80
    public int <amount>k__BackingField; // 0x84
    public string <imageUrl>k__BackingField; // 0x88

    // ── Methods ──
    public void get_tokens(){} // RVA: 0xFC4570
    public void set_tokens(){} // RVA: 0xFC4560
    public void get_amount(){} // RVA: 0x1C5A600
    public void set_amount(){} // RVA: 0x1C5A650
    public void get_imageUrl(){} // RVA: 0x31C010
    public void set_imageUrl(){} // RVA: 0x463060
    public void .ctor(){} // RVA: 0x98F33B0
}

public class TopLevelAssemblyTypeResolver
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DEE30
    public void ResolveType(){} // RVA: 0x5D2F1F0
}

public class TouchScreenKeyboardEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6FEE780
}

public class TrackAssetUpgrade
{
}

public class TrackCacheManager
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7043CC0
    public void Dispose(){} // RVA: 0x7043D20
    public void GetTrackAssetsFromRuntimeElements(){} // RVA: 0x7043DB0
}

public class TrackProgress
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x9A05730
}

public class TrackedCachingContexts
{
    // ── Methods ──
    public void GetOrCreate(){} // RVA: 0x68ADE60
    public void TryGetContext(){} // RVA: 0x68AE250
    public void .cctor(){} // RVA: 0x68AE440
}

public class TrackedOptionsInstances
{
    public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Text.Json.JsonSerializerOptions,object> Converters;

    // ── Methods ──
    public void get_All(){} // RVA: 0x632CC30
    public void .cctor(){} // RVA: 0x632CC90
}

public class TrackedOptionsInstances
{
    public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Text.Json.JsonSerializerOptions,object> IsReadOnly;

    // ── Methods ──
    public void get_All(){} // RVA: 0x68AEC30
    public void .cctor(){} // RVA: 0x68AEC90
}

public class TrackedPose
{
}

public class TrackingChangeHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F4F70
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x64E2820
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class TrackingChangeHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x166C910
    public void Invoke(){} // RVA: 0x439370
    public void BeginInvoke(){} // RVA: 0x64B6420
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class TrackingChangeHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F4F70
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x64ACE40
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class TrackingChangeHandler
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x37F4F70
    public void Invoke(){} // RVA: 0x4394E0
    public void BeginInvoke(){} // RVA: 0x64DB7F0
    public void EndInvoke(){} // RVA: 0x2DECB0
}

public class TrackingData
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x49C5490
}

public class TrackingReferenceObject
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x2DD310
}

public class Trail
{
}

public class TrailModule
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x100A2F0
    public void get_enabled(){} // RVA: 0x71C3D90
    public void set_enabled(){} // RVA: 0x71C3DE0
    public void get_mode(){} // RVA: 0x71C3E40
    public void set_mode(){} // RVA: 0x71C3E90
    public void get_ratio(){} // RVA: 0x71C3EF0
    public void set_ratio(){} // RVA: 0x71C3F40
    public void get_lifetime(){} // RVA: 0x71C3FA0
    public void set_lifetime(){} // RVA: 0x71C4010
    public void get_lifetimeMultiplier(){} // RVA: 0x71C4070
    public void set_lifetimeMultiplier(){} // RVA: 0x71C40C0
    public void get_minVertexDistance(){} // RVA: 0x71C4120
    public void set_minVertexDistance(){} // RVA: 0x71C4170
    public void get_textureMode(){} // RVA: 0x71C41D0
    public void set_textureMode(){} // RVA: 0x71C4220
    public void get_textureScale(){} // RVA: 0x71C4280
    public void set_textureScale(){} // RVA: 0x71C42E0
    public void get_worldSpace(){} // RVA: 0x71C4340
    public void set_worldSpace(){} // RVA: 0x71C4390
    public void get_dieWithParticles(){} // RVA: 0x71C43F0
    public void set_dieWithParticles(){} // RVA: 0x71C4440
    public void get_sizeAffectsWidth(){} // RVA: 0x71C44A0
    public void set_sizeAffectsWidth(){} // RVA: 0x71C44F0
    public void get_sizeAffectsLifetime(){} // RVA: 0x71C4550
    public void set_sizeAffectsLifetime(){} // RVA: 0x71C45A0
    public void get_inheritParticleColor(){} // RVA: 0x71C4600
    public void set_inheritParticleColor(){} // RVA: 0x71C4650
    public void get_colorOverLifetime(){} // RVA: 0x71C46B0
    public void set_colorOverLifetime(){} // RVA: 0x71C4730
    public void get_widthOverTrail(){} // RVA: 0x71C4790
    public void set_widthOverTrail(){} // RVA: 0x71C4800
    public void get_widthOverTrailMultiplier(){} // RVA: 0x71C4860
    public void set_widthOverTrailMultiplier(){} // RVA: 0x71C48B0
    public void get_colorOverTrail(){} // RVA: 0x71C4910
    public void set_colorOverTrail(){} // RVA: 0x71C4990
    public void get_generateLightingData(){} // RVA: 0x71C49F0
    public void set_generateLightingData(){} // RVA: 0x71C4A40
    public void get_ribbonCount(){} // RVA: 0x71C4AA0
    public void set_ribbonCount(){} // RVA: 0x71C4AF0
    public void get_shadowBias(){} // RVA: 0x71C4B50
    public void set_shadowBias(){} // RVA: 0x71C4BA0
    public void get_splitSubEmitterRibbons(){} // RVA: 0x71C4C00
    public void set_splitSubEmitterRibbons(){} // RVA: 0x71C4C50
    public void get_attachRibbonsToTransform(){} // RVA: 0x71C4CB0
    public void set_attachRibbonsToTransform(){} // RVA: 0x71C4D00
    public void get_enabled_Injected(){} // RVA: 0x71C3D90
    public void set_enabled_Injected(){} // RVA: 0x71C3DE0
    public void get_mode_Injected(){} // RVA: 0x71C3E40
    public void set_mode_Injected(){} // RVA: 0x71C3E90
    public void get_ratio_Injected(){} // RVA: 0x71C3EF0
    public void set_ratio_Injected(){} // RVA: 0x71C3F40
    public void get_lifetime_Injected(){} // RVA: 0x71C4D60
    public void set_lifetime_Injected(){} // RVA: 0x71C4DC0
    public void get_lifetimeMultiplier_Injected(){} // RVA: 0x71C4070
    public void set_lifetimeMultiplier_Injected(){} // RVA: 0x71C40C0
    public void get_minVertexDistance_Injected(){} // RVA: 0x71C4120
    public void set_minVertexDistance_Injected(){} // RVA: 0x71C4170
    public void get_textureMode_Injected(){} // RVA: 0x71C41D0
    public void set_textureMode_Injected(){} // RVA: 0x71C4220
    public void get_textureScale_Injected(){} // RVA: 0x71C4E20
    public void set_textureScale_Injected(){} // RVA: 0x71C4E80
    public void get_worldSpace_Injected(){} // RVA: 0x71C4340
    public void set_worldSpace_Injected(){} // RVA: 0x71C4390
    public void get_dieWithParticles_Injected(){} // RVA: 0x71C43F0
    public void set_dieWithParticles_Injected(){} // RVA: 0x71C4440
    public void get_sizeAffectsWidth_Injected(){} // RVA: 0x71C44A0
    public void set_sizeAffectsWidth_Injected(){} // RVA: 0x71C44F0
    public void get_sizeAffectsLifetime_Injected(){} // RVA: 0x71C4550
    public void set_sizeAffectsLifetime_Injected(){} // RVA: 0x71C45A0
    public void get_inheritParticleColor_Injected(){} // RVA: 0x71C4600
    public void set_inheritParticleColor_Injected(){} // RVA: 0x71C4650
    public void get_colorOverLifetime_Injected(){} // RVA: 0x71C4EE0
    public void set_colorOverLifetime_Injected(){} // RVA: 0x71C4F40
    public void get_widthOverTrail_Injected(){} // RVA: 0x71C4FA0
    public void set_widthOverTrail_Injected(){} // RVA: 0x71C5000
    public void get_widthOverTrailMultiplier_Injected(){} // RVA: 0x71C4860
    public void set_widthOverTrailMultiplier_Injected(){} // RVA: 0x71C48B0
    public void get_colorOverTrail_Injected(){} // RVA: 0x71C5060
    public void set_colorOverTrail_Injected(){} // RVA: 0x71C50C0
    public void get_generateLightingData_Injected(){} // RVA: 0x71C49F0
    public void set_generateLightingData_Injected(){} // RVA: 0x71C4A40
    public void get_ribbonCount_Injected(){} // RVA: 0x71C4AA0
    public void set_ribbonCount_Injected(){} // RVA: 0x71C4AF0
    public void get_shadowBias_Injected(){} // RVA: 0x71C4B50
    public void set_shadowBias_Injected(){} // RVA: 0x71C4BA0
    public void get_splitSubEmitterRibbons_Injected(){} // RVA: 0x71C4C00
    public void set_splitSubEmitterRibbons_Injected(){} // RVA: 0x71C4C50
    public void get_attachRibbonsToTransform_Injected(){} // RVA: 0x71C4CB0
    public void set_attachRibbonsToTransform_Injected(){} // RVA: 0x71C4D00
}

public class Trails
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x71BA570
}

public class TransformData
{
    public Unity.Mathematics.float3 Float3One;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x76B66D0
    public void UpdateFromUnityTransform(){} // RVA: 0x76B6B90
    public void UpdateGlobalTransform(){} // RVA: 0x76B70F0
    public void UpdateUnityTransform(){} // RVA: 0x76B7240
    public void get_lossyScale(){} // RVA: 0x76B7300
    public void .cctor(){} // RVA: 0x76B73C0
}

public class TransformJobData
{
}

public class TransformJobData
{
}

public class TransformJobData
{
}

public class TransformJobData
{
}
