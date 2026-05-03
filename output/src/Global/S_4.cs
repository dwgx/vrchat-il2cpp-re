// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 77
// Methods: 301

public class StateEventBuffer : ValueType
{
}

public class StateHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823D7070
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE86FE84A0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class StateOrProvinceName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86712340
}

public class StateSettings : ValueType
{
    public float killDuration; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811978C0
    public void get_Default(){} // RVA: 0x7FFE81197900
}

public class StateUpHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823D7070
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE86FE8410
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class StaticGetter`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class StaticTypeReinitAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
}

public class StationOccupantDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84010720
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class StationOccupiedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE828C6D10
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE828C6E90
}

public class StatusDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811EC370
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class SteamVR_Utils : Object
{
    // ── Methods ──
    public void IsValid(){} // RVA: 0x7FFE86FDC2D0 | overloaded x2
    public void Slerp(){} // RVA: 0x7FFE86FDC340
    public void Lerp(){} // RVA: 0x7FFE86FDC520 | overloaded x3
    public void InverseLerp(){} // RVA: 0x7FFE86FDC5C0 | overloaded x3
    public void Saturate(){} // RVA: 0x7FFE86FDC5F0 | overloaded x2
    public void Abs(){} // RVA: 0x7FFE86FDC650 | overloaded x2
    public void _copysign(){} // RVA: 0x7FFE86FDC690
    public void GetRotation(){} // RVA: 0x7FFE86FDC6D0
    public void GetPosition(){} // RVA: 0x7FFE86FDC8E0
    public void GetScale(){} // RVA: 0x7FFE86FDC910
    public void GetLossyScale(){} // RVA: 0x7FFE86FDCA90
    public void GetBadMD5Hash(){} // RVA: 0x7FFE86FDCB90 | overloaded x2
    public void GetBadMD5HashFromFile(){} // RVA: 0x7FFE86FDCE40
    public void SanitizePath(){} // RVA: 0x7FFE86FDCEB0
    public void FindType(){} // RVA: 0x7FFE86FDCFE0
    public void CallSystemFn(){} // RVA: 0x7FFE86FDD130
    public void TakeStereoScreenshot(){} // RVA: 0x7FFE86FDD2D0
}

public class StopSendingMsg : Object
{
    // ── Methods ──
    public void Process(){} // RVA: 0x7FFE879AA830
}

public class StoreInstance : Object
{
    public string _storeName; // 0x10
    public UnityEngine.Purchasing.Extension.IStore _instance; // 0x18

    // ── Methods ──
    public void get_storeName(){} // RVA: 0x7FFE81116380
    public void get_instance(){} // RVA: 0x7FFE810FE7C0
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
}

public class StreamTokenReader : Object
{
    public System.IO.StreamReader _in; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE827C3FF0
    public void Read(){} // RVA: 0x7FFE867ABAB0
    public void get_NumCharEncountered(){} // RVA: 0x7FFE813DB630
}

public class StringCache : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82D0A490
    public void Create(){} // RVA: 0x7FFE8A264870
    public void Dispose(){} // RVA: 0x7FFE8A264AE0
    public void Get(){} // RVA: 0x7FFE8A264B20
    public void .cctor(){} // RVA: 0x7FFE8A264CF0
}

public class StringMaker : Object
{
    // ── Methods ──
    public void HashString(){} // RVA: 0x7FFE867AB550
    public void HashCharArray(){} // RVA: 0x7FFE867AB5B0
    public void .ctor(){} // RVA: 0x7FFE867AB610
    public void CompareStringAndChars(){} // RVA: 0x7FFE867AB730
    public void MakeString(){} // RVA: 0x7FFE867AB7A0
}

public class StringOutFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8638D700
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class StringParser : ValueType
{
    // ── Methods ──
    public void NextChar(){} // RVA: 0x7FFE86908DC0
    public void NextNonDigit(){} // RVA: 0x7FFE86908E00
    public void TryParse(){} // RVA: 0x7FFE86908E60
    public void ParseInt(){} // RVA: 0x7FFE86909190
    public void ParseTime(){} // RVA: 0x7FFE86909280
    public void SkipBlanks(){} // RVA: 0x7FFE86909610
}

public class StringSerializer : ValueType
{
    // ── Methods ──
    public void GetSerializedString(){} // RVA: 0x7FFE868AE260
    public void GetDeserializedTimeZoneInfo(){} // RVA: 0x7FFE868AEE00
    public void .ctor(){} // RVA: 0x7FFE868AF020
    public void SerializeSubstitute(){} // RVA: 0x7FFE868AF0A0
    public void SerializeTransitionTime(){} // RVA: 0x7FFE868AF150
    public void VerifyIsEscapableCharacter(){} // RVA: 0x7FFE868AF5F0
    public void SkipVersionNextDataFields(){} // RVA: 0x7FFE868AF6A0
    public void GetNextStringValue(){} // RVA: 0x7FFE868AF8C0
    public void GetNextDateTimeValue(){} // RVA: 0x7FFE868AFCE0
    public void GetNextTimeSpanValue(){} // RVA: 0x7FFE868AFE00
    public void GetNextInt32Value(){} // RVA: 0x7FFE868AFED0
    public void GetNextAdjustmentRuleArrayValue(){} // RVA: 0x7FFE868AFFF0
    public void GetNextAdjustmentRuleValue(){} // RVA: 0x7FFE868B0260
    public void GetNextTransitionTimeValue(){} // RVA: 0x7FFE868B0710
}

public class String_CreateStringFromEncoding : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D1CC70
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class Struct256Bit : ValueType
{
}

public class StructGetter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
}

public class StructuredPerspectiveData : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BCB7A0
}

public class StudioLiteLookData : Object
{
    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFE88224FD0
}

public class StudioLiteMeshData : Object
{
    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFE88224E00
}

public class StudioLiteMeshSourceShaderIds : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE82BDE4F0
}

public class StudioLookData : Object
{
    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFE88224FA0
}

public class StudioMeshData : Object
{
    // ── Methods ──
    public void CopyTo(){} // RVA: 0x7FFE882248B0
}

public class StudioMeshSourceShaderIds : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE82BD9670
}

public class StyleData : ValueType
{
}

public class SubDouble : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871948A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubEmittersModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0xB5

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CF7650
    public void set_enabled(){} // RVA: 0x7FFE87CF76A0
    public void get_subEmittersCount(){} // RVA: 0x7FFE87CF7700
    public void AddSubEmitter(){} // RVA: 0x7FFE87CF77D0 | overloaded x2
    public void RemoveSubEmitter(){} // RVA: 0x7FFE87CF7860 | overloaded x2
    public void RemoveSubEmitterObject(){} // RVA: 0x7FFE87CF7860
    public void SetSubEmitterSystem(){} // RVA: 0x7FFE87CF78C0
    public void SetSubEmitterType(){} // RVA: 0x7FFE87CF7930
    public void SetSubEmitterProperties(){} // RVA: 0x7FFE87CF79A0
    public void SetSubEmitterEmitProbability(){} // RVA: 0x7FFE87CF7A10
    public void GetSubEmitterSystem(){} // RVA: 0x7FFE87CF7A80
    public void GetSubEmitterType(){} // RVA: 0x7FFE87CF7AE0
    public void GetSubEmitterProperties(){} // RVA: 0x7FFE87CF7B40
    public void GetSubEmitterEmitProbability(){} // RVA: 0x7FFE87CF7BA0
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CF7650
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CF76A0
    public void get_subEmittersCount_Injected(){} // RVA: 0x7FFE87CF7700
    public void AddSubEmitter_Injected(){} // RVA: 0x7FFE87CF7750
    public void RemoveSubEmitter_Injected(){} // RVA: 0x7FFE87CF7800
    public void RemoveSubEmitterObject_Injected(){} // RVA: 0x7FFE87CF7860
    public void SetSubEmitterSystem_Injected(){} // RVA: 0x7FFE87CF78C0
    public void SetSubEmitterType_Injected(){} // RVA: 0x7FFE87CF7930
    public void SetSubEmitterProperties_Injected(){} // RVA: 0x7FFE87CF79A0
    public void SetSubEmitterEmitProbability_Injected(){} // RVA: 0x7FFE87CF7A10
    public void GetSubEmitterSystem_Injected(){} // RVA: 0x7FFE87CF7A80
    public void GetSubEmitterType_Injected(){} // RVA: 0x7FFE87CF7AE0
    public void GetSubEmitterProperties_Injected(){} // RVA: 0x7FFE87CF7B40
    public void GetSubEmitterEmitProbability_Injected(){} // RVA: 0x7FFE87CF7BA0
}

public class SubInt16 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87193F70
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubInt32 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871940C0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubInt64 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87194200
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubOvfInt16 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87194E40
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubOvfInt32 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87195060
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubOvfInt64 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87195200
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubOvfUInt16 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871953F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubOvfUInt32 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87195610
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubOvfUInt64 : SubOvfInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871957E0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubSingle : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87194740
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubUInt16 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87194350
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubUInt32 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871944A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubUInt64 : SubInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871945F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SubmitEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87FEFFE0
}

public class Subscriber : Object
{
    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFE879AA760
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Subscription : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4F230
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class Surname : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86712950
}

public class SwitchCaseProxy : Object
{
    public System.Linq.Expressions.SwitchCase _node; // 0x10
    public object field_1; // 0x11B

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8711A890
    public void get_Body(){} // RVA: 0x7FFE8189C080
    public void get_TestValues(){} // RVA: 0x7FFE8189BB90
}

public class SwitchExpressionProxy : Object
{
    public System.Linq.Expressions.SwitchExpression _node; // 0x10
    public object field_1; // 0x11D
    public object field_2; // 0x11E
    public object field_3; // 0x11F
    public object field_4; // 0x120
    public object field_5; // 0x121
    public object field_6; // 0x122
    public object field_7; // 0x123

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8711A970
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_Cases(){} // RVA: 0x7FFE8189B810
    public void get_Comparison(){} // RVA: 0x7FFE8189BF90
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_DefaultBody(){} // RVA: 0x7FFE8189B9F0
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_SwitchValue(){} // RVA: 0x7FFE8189C080
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class SwitchFullInputReport : ValueType
{
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFE87A00750
}

public class SwitchHIDGenericInputReport : ValueType
{
    public byte reportId; // 0x10

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFE87A00A00
}

public class SwitchInputOnlyReport : ValueType
{
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFE87A00160
}

public class SwitchMagicOutputHIDBluetooth : ValueType
{
    public int kSize;
    public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFE87A00A10
    public void get_typeStatic(){} // RVA: 0x7FFE87A00A10
    public void Create(){} // RVA: 0x7FFE87A00A20
}

public class SwitchMagicOutputHIDUSB : ValueType
{
    public int kSize;
    public UnityEngine.InputSystem.LowLevel.InputDeviceCommand baseCommand; // 0x10

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFE87A00A10
    public void get_typeStatic(){} // RVA: 0x7FFE87A00A10
    public void Create(){} // RVA: 0x7FFE87A00A70
}

public class SwitchMagicOutputReport : ValueType
{
}

public class SwitchSimpleInputReport : ValueType
{
    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFE87A00440
}

public class SymbolTables : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE8743C940
}

public class SyncHashtable : Hashtable
{
    public System.Collections.Hashtable _table; // 0x50
    public object field_1; // 0x82F
    public object field_2; // 0x830
    public object field_3; // 0x831
    public object field_4; // 0x832
    public object field_5; // 0x833
    public object field_6; // 0x834
    public object field_7; // 0x835

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8694E100 | overloaded x2
    public void GetObjectData(){} // RVA: 0x7FFE8694E160
    public void get_Count(){} // RVA: 0x7FFE8694E1A0
    public void get_IsReadOnly(){} // RVA: 0x7FFE8694E1D0
    public void get_IsFixedSize(){} // RVA: 0x7FFE8694E200
    public void get_IsSynchronized(){} // RVA: 0x7FFE811E0850
    public void get_Item(){} // RVA: 0x7FFE8694E230
    public void set_Item(){} // RVA: 0x7FFE8694E260
    public void get_SyncRoot(){} // RVA: 0x7FFE8694E400
    public void Add(){} // RVA: 0x7FFE8694E430
    public void Clear(){} // RVA: 0x7FFE8694E5D0
    public void Contains(){} // RVA: 0x7FFE8694E740
    public void ContainsKey(){} // RVA: 0x7FFE8694E770
    public void CopyTo(){} // RVA: 0x7FFE8694E820
    public void Clone(){} // RVA: 0x7FFE8694E9C0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8694EBD0
    public void GetEnumerator(){} // RVA: 0x7FFE8694EBD0
    public void get_Keys(){} // RVA: 0x7FFE8694EC00
    public void get_Values(){} // RVA: 0x7FFE8694ED90
    public void Remove(){} // RVA: 0x7FFE8694EF20
    public void OnDeserialization(){} // RVA: 0x7FFE810FB310
}

public class SyncSortedList : SortedList
{
    public System.Collections.SortedList _list; // 0x48
    public object _root; // 0x50
    public object field_2; // 0x7EA
    public object field_3; // 0x7EB
    public object field_4; // 0x7EC
    public object field_5; // 0x7ED

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE869408B0
    public void get_Count(){} // RVA: 0x7FFE869409B0
    public void get_SyncRoot(){} // RVA: 0x7FFE8119C0E0
    public void get_IsReadOnly(){} // RVA: 0x7FFE86940B10
    public void get_IsFixedSize(){} // RVA: 0x7FFE86940B40
    public void get_IsSynchronized(){} // RVA: 0x7FFE811E0850
    public void get_Item(){} // RVA: 0x7FFE86940B70
    public void set_Item(){} // RVA: 0x7FFE86940CE0
    public void Add(){} // RVA: 0x7FFE86940E50
    public void Clear(){} // RVA: 0x7FFE86940FC0
    public void Clone(){} // RVA: 0x7FFE86941110
    public void Contains(){} // RVA: 0x7FFE86941270
    public void ContainsKey(){} // RVA: 0x7FFE869413F0
    public void ContainsValue(){} // RVA: 0x7FFE86941570
    public void CopyTo(){} // RVA: 0x7FFE869416F0
    public void GetByIndex(){} // RVA: 0x7FFE86941860
    public void GetEnumerator(){} // RVA: 0x7FFE869419D0
    public void GetKey(){} // RVA: 0x7FFE86941B30
    public void GetKeyList(){} // RVA: 0x7FFE86941CA0
    public void GetValueList(){} // RVA: 0x7FFE86941E00
    public void IndexOfKey(){} // RVA: 0x7FFE86941F60
    public void IndexOfValue(){} // RVA: 0x7FFE86942140
    public void RemoveAt(){} // RVA: 0x7FFE869422C0
    public void Remove(){} // RVA: 0x7FFE86942420
}

public class SyncTextReader : TextReader
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86979500
    public void Close(){} // RVA: 0x7FFE869795A0
    public void Dispose(){} // RVA: 0x7FFE869795D0
    public void Peek(){} // RVA: 0x7FFE86738540
    public void Read(){} // RVA: 0x7FFE86979630 | overloaded x2
    public void ReadLine(){} // RVA: 0x7FFE86979660
    public void ReadToEnd(){} // RVA: 0x7FFE86802DA0
    public void ReadToEndAsync(){} // RVA: 0x7FFE86979690
    public void ReadAsync(){} // RVA: 0x7FFE86979710
}

public class SyncTextWriter : TextWriter
{
    public System.IO.TextWriter _out; // 0x30
    public object field_1; // 0x92A
    public object field_2; // 0x92B

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8697C1A0
    public void get_Encoding(){} // RVA: 0x7FFE8697C280
    public void get_FormatProvider(){} // RVA: 0x7FFE8697C2B0
    public void get_NewLine(){} // RVA: 0x7FFE8697C2E0
    public void Close(){} // RVA: 0x7FFE86862880
    public void Dispose(){} // RVA: 0x7FFE8697C310
    public void Flush(){} // RVA: 0x7FFE8697C370
    public void Write(){} // RVA: 0x7FFE8697C400 | overloaded x8
    public void WriteLine(){} // RVA: 0x7FFE8697C490 | overloaded x5
    public void WriteAsync(){} // RVA: 0x7FFE8697C640 | overloaded x3
    public void WriteLineAsync(){} // RVA: 0x7FFE8697C730
    public void FlushAsync(){} // RVA: 0x7FFE8697C820
}

public class SyncTile : ValueType
{
}

public class SyncTileCallbackSettings : ValueType
{
}

public class SynchronizeInputs : ValueType
{
}

public class SynchronizeState : ValueType
{
}

public class SynchronousAsyncResult : Object
{
    public object _stateObject; // 0x10
    public bool _isWrite; // 0x18
    public System.Threading.ManualResetEvent _waitHandle; // 0x20
    public System.Runtime.ExceptionServices.ExceptionDispatchInfo _exceptionInfo; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86994460 | overloaded x3
    public void get_IsCompleted(){} // RVA: 0x7FFE811E0850
    public void get_AsyncWaitHandle(){} // RVA: 0x7FFE869945F0
    public void get_AsyncState(){} // RVA: 0x7FFE81116380
    public void get_CompletedSynchronously(){} // RVA: 0x7FFE811E0850
    public void ThrowIfError(){} // RVA: 0x7FFE86994750
    public void EndRead(){} // RVA: 0x7FFE86992990
    public void EndWrite(){} // RVA: 0x7FFE86992BF0
}

public class SystemController : ScriptableObject
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE82523B90
    public void CreateInstance(){} // RVA: 0x7FFE82523C20
    public void GetHashCode(){} // RVA: 0x7FFE82523CB0
    public void CreateScriptableObject(){} // RVA: 0x7FFE82523D40
    public void .ctor(){} // RVA: 0x7FFE81345B60
    public void Initialize(){} // RVA: 0x7FFE82523D40
    public void ToString(){} // RVA: 0x7FFE82523D50
    public void GetGameObject_C12(){} // RVA: 0x7FFE82523F90
    public void .ctor_187E6EB2BFFF(){} // RVA: 0x7FFE82523FE0
    public void Initialize_2B693AE9EDF1(){} // RVA: 0x7FFE81B0FF50
    public void GetGameObject_A97(){} // RVA: 0x7FFE82524010
    public void SetActive_448(){} // RVA: 0x7FFE825240A0
}

public class SystemFn : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE848AC410
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class SystemObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFE810FB310
    public void SetObjectData(){} // RVA: 0x7FFE8A4E1D60
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SystemThreadingTasks_TaskSchedulerDebugView : Object
{
}

public class SystemThreading_SpinLockDebugView : Object
{
}

public class SystemTimeProvider : TimeProvider
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE866C9A40
}

public class sentry_logger_function_t : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84423E50
    public void Invoke(){} // RVA: 0x7FFE81998A70
}

public class sentry_value_t : ValueType
{
}

public class sockaddr_in : ValueType
{
    // ── Methods ──
    public void Create(){} // RVA: 0x7FFE876D0EB0
}
