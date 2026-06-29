// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 426

public class UISoundCollection : ScriptableObject
{
    public object MoveOver;
    public object MoveOff;
    public object Click;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xDD1AC0
}

public class URPMaterialSwitcher : MonoBehaviour
{
    public object children;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43D60
}

public class UTF32Decoder : DecoderNLS
{
    public object iChar;
    public object readByteCount;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66C5480
    public void Reset(){} // RVA: 0x66C5490
    public void get_HasState(){} // RVA: 0x48D4050
}

public class UTF8Decoder : DecoderNLS
{
    public object bits;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66C5480
    public void Reset(){} // RVA: 0x66CBBC0
    public void get_HasState(){} // RVA: 0x66CBBF0
}

public class UTF8Encoder : EncoderNLS
{
    public object surrogateChar;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66C7940
    public void Reset(){} // RVA: 0x66CBB90
    public void get_HasState(){} // RVA: 0x16755B0
}

public class UTF8EncodingSealed : UTF8Encoding
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x66CBA10
    public void get_Preamble(){} // RVA: 0x66CBA90
}

public class UdonProgramScanner : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x1D57C00
    public void Equals(){} // RVA: 0x1D57DE0
}

public class UdonTimeSource : Object
{
    public object _currentTime;
    public object _currentFrame;

    // ── Methods ──
    public void get_CurrentTime(){} // RVA: 0x2566C50
    public void set_CurrentTime(){} // RVA: 0x4B6F180
    public void get_CurrentFrame(){} // RVA: 0xB465B0
    public void set_CurrentFrame(){} // RVA: 0x15428E0
    public void get_MinimumDelay(){} // RVA: 0x8353DC0
    public void UpdateTime(){} // RVA: 0x8353DD0
    public void .ctor(){} // RVA: 0xB43310
}

public class UiInputField : MonoBehaviour
{
    public object _titleText;
    public object placeholder;
    public object _placeholderText;
    public object textField;
    public object inputType;
    public object isDate;
    public object useNumericKeypad;
    public object nextInputField;
    public object onEndEdit;
    public object f_511;
    public object f_6A2;
    public object f_839;
    public object f_A6D;
    public object f_8F4;
    public object f_874;
    public object f_2B0;
    public object f_61F;

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x2129000
    public void PressEdit(){} // RVA: 0x2129790
    public void IsInvoking(){} // RVA: 0x2129F10
    public void CancelInvoke(){} // RVA: 0x212A160
    public void OnEnable(){} // RVA: 0x212A3F0
    public void OnDisable(){} // RVA: 0xBAE3B0
    public void StartCoroutine(){} // RVA: 0x212A420
    public void StartCoroutine_Auto(){} // RVA: 0x212A430
    public void StopCoroutine(){} // RVA: 0x212ABC0
    public void Awake(){} // RVA: 0x212AE10
    public void OnDestroy(){} // RVA: 0xBAE3B0
    public void set_useGUILayout(){} // RVA: 0x212B770
    public void get_didStart(){} // RVA: 0x2096F20
    public void .ctor(){} // RVA: 0x212BA90
    public void Initialize(){} // RVA: 0x15035D0
    public void Internal_CancelInvokeAll(){} // RVA: 0x212A420
    public void Internal_IsInvokingAll(){} // RVA: 0x212BC10
    public void InvokeDelayed(){} // RVA: 0x212BD40
    public void IsObjectMonoBehaviour(){} // RVA: 0x212BFF0
}

public class UnboundAnchor : ValueType
{
    public object _space;
    public object _uuid;

    // ── Methods ──
    public void get_Uuid(){} // RVA: 0xCB720
    public void get_Localized(){} // RVA: 0x8CFCB0
    public void get_Localizing(){} // RVA: 0x8CFD30
    public void get_Pose(){} // RVA: 0x8CFDC0
    public void Localize(){} // RVA: 0x8CFF10
    public void BindTo(){} // RVA: 0x8CFF20
    public void .ctor(){} // RVA: 0x366980
}

public class UnboundAnchor[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7DD60
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A7A0
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3EE0
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34170
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A7A0
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class UnboundedChannelReader : ChannelReader`1
{
    public object _parent;
    public object _readerSingleton;
    public object _waiterSingleton;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void TryRead(){} // RVA: 0x87D350
    public void WaitToReadAsync(){} // RVA: 0x87C240
}

public class UnboundedChannelReader : ChannelReader`1
{
    public object _parent;
    public object _readerSingleton;
    public object _waiterSingleton;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4FE8840
    public void TryRead(){} // RVA: 0x4FE8A30
    public void WaitToReadAsync(){} // RVA: 0x4FE8B20
}

public class UnboundedChannelWriter : ChannelWriter`1
{
    public object _parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void TryComplete(){} // RVA: 0x87D350
    public void TryWrite(){} // RVA: 0xA94080
    public void WaitToWriteAsync(){} // RVA: 0x87C240
    public void WriteAsync(){} // RVA: 0xA94080
}

public class UnboundedChannelWriter : ChannelWriter`1
{
    public object _parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void TryComplete(){} // RVA: 0x4FEB240
    public void TryWrite(){} // RVA: 0x4FEB600
    public void WaitToWriteAsync(){} // RVA: 0x4FEBAD0
    public void WriteAsync(){} // RVA: 0x4FEBDD0
}

public class UnitProperty : Property`2
{
    public object _name;
    public object _isReadOnly;

    // ── Methods ──
    public void get_Name(){} // RVA: 0xB465B0
    public void get_IsReadOnly(){} // RVA: 0xC38360
    public void GetValue(){} // RVA: 0x7E51890
    public void SetValue(){} // RVA: 0x426C1C0
    public void .ctor(){} // RVA: 0x7ED71A0
}

public class UnitProperty : Property`2
{
    public object _name;
    public object _isReadOnly;

    // ── Methods ──
    public void get_Name(){} // RVA: 0xB465B0
    public void get_IsReadOnly(){} // RVA: 0xC38360
    public void GetValue(){} // RVA: 0x7E51890
    public void SetValue(){} // RVA: 0x426C1C0
    public void .ctor(){} // RVA: 0x7EDD390
}

public class UnitProperty : Property`2
{
    public object _name;
    public object _isReadOnly;

    // ── Methods ──
    public void get_Name(){} // RVA: 0xB465B0
    public void get_IsReadOnly(){} // RVA: 0xC38360
    public void GetValue(){} // RVA: 0x7E51890
    public void SetValue(){} // RVA: 0x426C1C0
    public void .ctor(){} // RVA: 0x80B1C60
}

public class UnityBackgroundImageTintColorProperty : InlineStyleColorProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA3650
    public void get_ussName(){} // RVA: 0x7EA3690
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA36D0
    public void SetValue(){} // RVA: 0x7EA3740
    public void .ctor(){} // RVA: 0x7E9D9F0
}

public class UnityBackgroundImageTintColorProperty : ResolvedColorProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECD3A0
    public void get_ussName(){} // RVA: 0x7ECD3E0
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECD420
    public void SetValue(){} // RVA: 0x7ECD490
    public void .ctor(){} // RVA: 0x7EC9370
}

public class UnityEditorTextRenderingModeProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA37B0
    public void get_ussName(){} // RVA: 0x7EA37F0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA3830
    public void SetValue(){} // RVA: 0x7EA3900
    public void .ctor(){} // RVA: 0x7EA39D0
}

public class UnityEditorTextRenderingModeProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECD4D0
    public void get_ussName(){} // RVA: 0x7ECD510
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECD550
    public void SetValue(){} // RVA: 0x7ECD5A0
    public void .ctor(){} // RVA: 0x7ECD5E0
}

public class UnityFontDefinitionProperty : InlineStyleFontDefinitionProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA3C30
    public void get_ussName(){} // RVA: 0x7EA3C70
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA3CB0
    public void SetValue(){} // RVA: 0x7EA3D30
    public void .ctor(){} // RVA: 0x7EA3DA0
}

public class UnityFontDefinitionProperty : ResolvedFontDefinitionProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECD750
    public void get_ussName(){} // RVA: 0x7ECD790
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECD7D0
    public void SetValue(){} // RVA: 0x7ECD840
    public void .ctor(){} // RVA: 0x7ECD880
}

public class UnityFontProperty : InlineStyleFontProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA3A20
    public void get_ussName(){} // RVA: 0x7EA3A60
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA3AA0
    public void SetValue(){} // RVA: 0x7EA3B10
    public void .ctor(){} // RVA: 0x7EA3BF0
}

public class UnityFontProperty : ResolvedFontProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECD610
    public void get_ussName(){} // RVA: 0x7ECD650
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECD690
    public void SetValue(){} // RVA: 0x7ECD6E0
    public void .ctor(){} // RVA: 0x7ECD720
}

public class UnityFontStyleAndWeightProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA3DB0
    public void get_ussName(){} // RVA: 0x7EA3DF0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA3E30
    public void SetValue(){} // RVA: 0x7EA3F00
    public void .ctor(){} // RVA: 0x7EA3FD0
}

public class UnityFontStyleAndWeightProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECD8B0
    public void get_ussName(){} // RVA: 0x7ECD8F0
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECD930
    public void SetValue(){} // RVA: 0x7ECD980
    public void .ctor(){} // RVA: 0x7ECD9C0
}

public class UnityOverflowClipBoxProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA4020
    public void get_ussName(){} // RVA: 0x7EA4060
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA40A0
    public void SetValue(){} // RVA: 0x7EA4170
    public void .ctor(){} // RVA: 0x7EA4240
}

public class UnityParagraphSpacingProperty : InlineStyleLengthProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA4290
    public void get_ussName(){} // RVA: 0x7EA42D0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA4310
    public void SetValue(){} // RVA: 0x7EA4390
    public void .ctor(){} // RVA: 0x7E9E610
}

public class UnityParagraphSpacingProperty : ResolvedFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECD9F0
    public void get_ussName(){} // RVA: 0x7ECDA30
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECDA70
    public void SetValue(){} // RVA: 0x7ECDAC0
    public void .ctor(){} // RVA: 0x7EC9CA0
}

public class UnitySliceBottomProperty : InlineStyleIntProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA4400
    public void get_ussName(){} // RVA: 0x7EA4440
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA4480
    public void SetValue(){} // RVA: 0x7EA44D0
    public void .ctor(){} // RVA: 0x7EA4530
}

public class UnitySliceBottomProperty : ResolvedIntProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECDB00
    public void get_ussName(){} // RVA: 0x7ECDB40
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECDB80
    public void SetValue(){} // RVA: 0x7ECDBD0
    public void .ctor(){} // RVA: 0x7ECDC10
}

public class UnitySliceLeftProperty : InlineStyleIntProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA4570
    public void get_ussName(){} // RVA: 0x7EA45B0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA45F0
    public void SetValue(){} // RVA: 0x7EA4640
    public void .ctor(){} // RVA: 0x7EA4530
}

public class UnitySliceLeftProperty : ResolvedIntProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECDC40
    public void get_ussName(){} // RVA: 0x7ECDC80
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECDCC0
    public void SetValue(){} // RVA: 0x7ECDD10
    public void .ctor(){} // RVA: 0x7ECDC10
}

public class UnitySliceRightProperty : InlineStyleIntProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA46A0
    public void get_ussName(){} // RVA: 0x7EA46E0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA4720
    public void SetValue(){} // RVA: 0x7EA4770
    public void .ctor(){} // RVA: 0x7EA4530
}

public class UnitySliceRightProperty : ResolvedIntProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECDD50
    public void get_ussName(){} // RVA: 0x7ECDD90
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECDDD0
    public void SetValue(){} // RVA: 0x7ECDE20
    public void .ctor(){} // RVA: 0x7ECDC10
}

public class UnitySliceScaleProperty : InlineStyleFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA47D0
    public void get_ussName(){} // RVA: 0x7EA4810
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA4850
    public void SetValue(){} // RVA: 0x7EA48A0
    public void .ctor(){} // RVA: 0x7E9E8C0
}

public class UnitySliceScaleProperty : ResolvedFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECDE60
    public void get_ussName(){} // RVA: 0x7ECDEA0
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECDEE0
    public void SetValue(){} // RVA: 0x7ECDF30
    public void .ctor(){} // RVA: 0x7EC9CA0
}

public class UnitySliceTopProperty : InlineStyleIntProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA4900
    public void get_ussName(){} // RVA: 0x7EA4940
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA4980
    public void SetValue(){} // RVA: 0x7EA49D0
    public void .ctor(){} // RVA: 0x7EA4530
}

public class UnitySliceTopProperty : ResolvedIntProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECDF70
    public void get_ussName(){} // RVA: 0x7ECDFB0
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECDFF0
    public void SetValue(){} // RVA: 0x7ECE040
    public void .ctor(){} // RVA: 0x7ECDC10
}

public class UnitySliceTypeProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA4A30
    public void get_ussName(){} // RVA: 0x7EA4A70
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA4AB0
    public void SetValue(){} // RVA: 0x7EA4B80
    public void .ctor(){} // RVA: 0x7EA4C50
}

public class UnitySliceTypeProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECE080
    public void get_ussName(){} // RVA: 0x7ECE0C0
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECE100
    public void SetValue(){} // RVA: 0x7ECE150
    public void .ctor(){} // RVA: 0x7ECE190
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x2577020
    public void .ctor(){} // RVA: 0xB43310
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x7AB6110
    public void .ctor(){} // RVA: 0xB43310
}

public class UnityTextAlignProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA4CA0
    public void get_ussName(){} // RVA: 0x7EA4CE0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA4D20
    public void SetValue(){} // RVA: 0x7EA4DF0
    public void .ctor(){} // RVA: 0x7EA4EC0
}

public class UnityTextAlignProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECE1C0
    public void get_ussName(){} // RVA: 0x7ECE200
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECE240
    public void SetValue(){} // RVA: 0x7ECE290
    public void .ctor(){} // RVA: 0x7ECE2D0
}

public class UnityTextGeneratorProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA4F10
    public void get_ussName(){} // RVA: 0x7EA4F50
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA4F90
    public void SetValue(){} // RVA: 0x7EA5060
    public void .ctor(){} // RVA: 0x7EA5130
}

public class UnityTextGeneratorProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECE300
    public void get_ussName(){} // RVA: 0x7ECE340
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECE380
    public void SetValue(){} // RVA: 0x7ECE3D0
    public void .ctor(){} // RVA: 0x7ECE410
}

public class UnityTextOutlineColorProperty : InlineStyleColorProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA5180
    public void get_ussName(){} // RVA: 0x7EA51C0
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA5200
    public void SetValue(){} // RVA: 0x7EA5270
    public void .ctor(){} // RVA: 0x7E9D9F0
}

public class UnityTextOutlineColorProperty : ResolvedColorProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECE440
    public void get_ussName(){} // RVA: 0x7ECE480
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECE4C0
    public void SetValue(){} // RVA: 0x7ECE530
    public void .ctor(){} // RVA: 0x7EC9370
}

public class UnityTextOutlineWidthProperty : InlineStyleFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA52E0
    public void get_ussName(){} // RVA: 0x7EA5320
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA5360
    public void SetValue(){} // RVA: 0x7EA53B0
    public void .ctor(){} // RVA: 0x7E9E8C0
}

public class UnityTextOutlineWidthProperty : ResolvedFloatProperty
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECE570
    public void get_ussName(){} // RVA: 0x7ECE5B0
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECE5F0
    public void SetValue(){} // RVA: 0x7ECE640
    public void .ctor(){} // RVA: 0x7EC9CA0
}

public class UnityTextOverflowPositionProperty : InlineStyleEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7EA5410
    public void get_ussName(){} // RVA: 0x7EA5450
    public void get_IsReadOnly(){} // RVA: 0xB43320
    public void GetValue(){} // RVA: 0x7EA5490
    public void SetValue(){} // RVA: 0x7EA5560
    public void .ctor(){} // RVA: 0x7EA5630
}

public class UnityTextOverflowPositionProperty : ResolvedEnumProperty`1
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7ECE680
    public void get_ussName(){} // RVA: 0x7ECE6C0
    public void get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void GetValue(){} // RVA: 0x7ECE700
    public void SetValue(){} // RVA: 0x7ECE750
    public void .ctor(){} // RVA: 0x7ECE790
}

public class UnityWebRequestAsyncOperationAwaiter : ValueType
{
    public object asyncOperation;
    public object continuationAction;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x54A90
    public void get_IsCompleted(){} // RVA: 0x9232C0
    public void GetResult(){} // RVA: 0x9236C0
    public void OnCompleted(){} // RVA: 0x9236D0
    public void UnsafeOnCompleted(){} // RVA: 0x9236E0
}

public class Unmanaged : ValueType
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x77D2640
    public void Free(){} // RVA: 0x2C8CD80
}

public class UnmanagedMemory : ValueType
{
    public object basePtr;
    public object mapCount;
    public object actionCount;
    public object interactionCount;
    public object bindingCount;
    public object controlCount;
    public object compositeCount;
    public object actionStates;
    public object bindingStates;
    public object interactionStates;
    public object controlMagnitudes;
    public object compositeMagnitudes;
    public object enabledControls;
    public object actionBindingIndicesAndCounts;
    public object actionBindingIndices;
    public object controlIndexToBindingIndex;
    public object controlGroupingAndComplexity;
    public object controlGroupingInitialized;
    public object mapIndices;

    // ── Methods ──
    public void get_isAllocated(){} // RVA: 0x311760
    public void get_sizeInBytes(){} // RVA: 0x92B4C0
    public void Allocate(){} // RVA: 0x92B500
    public void Dispose(){} // RVA: 0x92B510
    public void CopyDataFrom(){} // RVA: 0x92B520
    public void Clone(){} // RVA: 0x92B580
}

public class UpdateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class UpdateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBC4530
    public void Invoke(){} // RVA: 0xB9E010
    public void BeginInvoke(){} // RVA: 0xB9E020
    public void EndInvoke(){} // RVA: 0xB44BE0
}

public class UpdateFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class UpdateGridCellsJob : ValueType
{
    public object gridCells;
    public object shapeData;
    public object collisionPairs;

    // ── Methods ──
    public void Execute(){} // RVA: 0x9C60F0
    public void UpdateRecords(){} // RVA: 0x9C6100
    public void InsertionSort(){} // RVA: 0x9C6150
    public void FindPairs(){} // RVA: 0x9C61A0
}

public class UpdateHeadingDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25B7C10
    public void Invoke(){} // RVA: 0x25B7D80
    public void BeginInvoke(){} // RVA: 0x25B7DC0
    public void EndInvoke(){} // RVA: 0x25B7E60
}

public class UpdateReceivers : ValueType
{
    public object activeReceivers;
    public object receivers;
    public object shapes;
    public object deltaTime;

    // ── Methods ──
    public void Execute(){} // RVA: 0x9C8670
}

public class UpdateRootsJob : ValueType
{
    public object MAX_EXECUTIONS;
    public object realTime;
    public object fixedTime;
    public object roots;
    public object FIXED_TIME_COUNTER_MAX;

    // ── Methods ──
    public void Execute(){} // RVA: 0x9CA580
    public void CalculateShouldUseFixedTime(){} // RVA: 0x9CA5A0
}

public class UpdateShapePositionsJob : ValueType
{
    public object SHAPE_BATCH_COUNT;
    public object activeShapes;
    public object shapeData;
    public object transformData;
    public object transformLookup;

    // ── Methods ──
    public void Execute(){} // RVA: 0x9C6760
    public void GetTransform(){} // RVA: 0x9C6770
    public void .cctor(){} // RVA: 0x82A3E70
}

public class UpdateShapesJob : ValueType
{
    public object shapesToUpdate;
    public object shapeData;
    public object shapeMap;

    // ── Methods ──
    public void Execute(){} // RVA: 0x9C5AF0
    public void RemoveShape(){} // RVA: 0x9C5BA0
    public void AddShape(){} // RVA: 0x9C5C70
}

public class UpdateShapesJob : ValueType
{
    public object shapesToUpdate;
    public object shapeData;
    public object gridMap;
    public object gridCells;
    public object cellCache;

    // ── Methods ──
    public void Execute(){} // RVA: 0x9C5F40
    public void RemoveShape(){} // RVA: 0x9C5FF0
    public void AddShape(){} // RVA: 0x9C60C0
}

public class UpdateStatus : Object
{
    public object lastUpdateFrame;
    public object lastUpdateFixedFrame;
    public object lastUpdateMode;
    public object lastUpdateDeltaTime;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class UpdateStatus : Object
{
    public object kWindowSize;
    public object windowStart;
    public object numWindowLateUpdateMoves;
    public object numWindowFixedUpdateMoves;
    public object numWindows;
    public object lastFrameUpdated;
    public object lastPos;
    public object _preferredUpdate;

    // ── Methods ──
    public void get_PreferredUpdate(){} // RVA: 0xD34720
    public void set_PreferredUpdate(){} // RVA: 0xD346A0
    public void .ctor(){} // RVA: 0x25DAA70
    public void OnUpdate(){} // RVA: 0x25DAB00
}

public class UserController : ScriptableObject
{
    public object testSteamAccount;

    // ── Methods ──
    public void Equals(){} // RVA: 0x2088E00
    public void CreateInstance(){} // RVA: 0x2088E90
    public void .ctor(){} // RVA: 0xDD1AC0
    public void Initialize(){} // RVA: 0x2088F20
    public void CreateScriptableObjectInstanceFromType_Injected(){} // RVA: 0x2088FB0
    public void GetHashCode(){} // RVA: 0x2089040
    public void ToString(){} // RVA: 0x20890E0
    // ── Unresolved (hash) ──
    public void m_301(){} // RVA: 0x164E2F0
    public void m_1D7(){} // RVA: 0x2089220
    public void m_3BD(){} // RVA: 0x2089360
    public void m_4B4(){} // RVA: 0x2088D10
    public void m_988(){} // RVA: 0x164E2F0
}

public class UserUpdatedCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1500
    public void Invoke(){} // RVA: 0xB9E010
}

public class unitytls_errorstate_create_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x35A7060
    public void Invoke(){} // RVA: 0x35A7130
}

public class unitytls_errorstate_raise_error_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x26E1340
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class unitytls_key_free_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
}

public class unitytls_key_get_ref_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C53850
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class unitytls_key_parse_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDB10
    public void Invoke(){} // RVA: 0x3DCCA70
}

public class unitytls_key_parse_pem_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDB10
    public void Invoke(){} // RVA: 0x3DCCA70
}

public class unitytls_tlsctx_certificate_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70ED930
    public void Invoke(){} // RVA: 0x3E3F960
}

public class unitytls_tlsctx_create_client_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EE030
    public void Invoke(){} // RVA: 0x70EE100
}

public class unitytls_tlsctx_create_server_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EE030
    public void Invoke(){} // RVA: 0x70EE100
}

public class unitytls_tlsctx_read_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6651F70
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDDA0
    public void Invoke(){} // RVA: 0xCA8D60
}

public class unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C547E0
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C547E0
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_tlsctx_set_trace_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C547E0
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C547E0
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_tlsctx_trace_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C547E0
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_tlsctx_write_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6651F70
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_tlsctx_x509verify_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDA20
    public void Invoke(){} // RVA: 0xCA8D60
}

public class unitytls_x509_export_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDC00
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_x509list_append_der_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C547E0
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_x509list_append_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDDA0
    public void Invoke(){} // RVA: 0xCA8D60
}

public class unitytls_x509list_create_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x4F6ECE0
    public void Invoke(){} // RVA: 0xB9E010
}

public class unitytls_x509list_free_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB9DF20
    public void Invoke(){} // RVA: 0xB9E010
}

public class unitytls_x509list_get_ref_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6C53850
    public void Invoke(){} // RVA: 0xCA8BF0
}

public class unitytls_x509list_get_x509_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDCD0
    public void Invoke(){} // RVA: 0xCA8D60
}

public class unitytls_x509verify_callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70ED840
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class unitytls_x509verify_default_ca_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDE90
    public void Invoke(){} // RVA: 0x3E3F4B0
}

public class unitytls_x509verify_explicit_ca_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70EDF60
    public void Invoke(){} // RVA: 0x3E3F640
}
