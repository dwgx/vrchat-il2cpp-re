// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 24
// Methods: 145

public class StringSerializer : ValueType
{
    public string _serializedText; // 0x10
    public int _currentTokenStartIndex; // 0x18
    public object _state; // 0x1C

    // ── Methods ──
    public void GetSerializedString(){} // RVA: 0x7FFD53924A60
    public void GetDeserializedTimeZoneInfo(){} // RVA: 0x7FFD53925600
    public void .ctor(){} // RVA: 0x7FFD53925820
    public void SerializeSubstitute(){} // RVA: 0x7FFD539258A0
    public void SerializeTransitionTime(){} // RVA: 0x7FFD53925950
    public void VerifyIsEscapableCharacter(){} // RVA: 0x7FFD53925DF0
    public void SkipVersionNextDataFields(){} // RVA: 0x7FFD53925EA0
    public void GetNextStringValue(){} // RVA: 0x7FFD539260C0
    public void GetNextDateTimeValue(){} // RVA: 0x7FFD539264E0
    public void GetNextTimeSpanValue(){} // RVA: 0x7FFD53926600
    public void GetNextInt32Value(){} // RVA: 0x7FFD539266D0
    public void GetNextAdjustmentRuleArrayValue(){} // RVA: 0x7FFD539267F0
    public void GetNextAdjustmentRuleValue(){} // RVA: 0x7FFD53926A60
    public void GetNextTransitionTimeValue(){} // RVA: 0x7FFD53926F10
}

public class StructGetter`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class SubEmittersModule : ValueType
{
    public InDuration enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D6EDB0
    public void set_enabled(){} // RVA: 0x7FFD54D6EE00
    public void get_subEmittersCount(){} // RVA: 0x7FFD54D6EE60
    public void AddSubEmitter(){} // RVA: 0x7FFD54D6EF30 | overloaded x2
    public void RemoveSubEmitter(){} // RVA: 0x7FFD54D6EFC0 | overloaded x2
    public void RemoveSubEmitterObject(){} // RVA: 0x7FFD54D6EFC0
    public void SetSubEmitterSystem(){} // RVA: 0x7FFD54D6F020
    public void SetSubEmitterType(){} // RVA: 0x7FFD54D6F090
    public void SetSubEmitterProperties(){} // RVA: 0x7FFD54D6F100
    public void SetSubEmitterEmitProbability(){} // RVA: 0x7FFD54D6F170
    public void GetSubEmitterSystem(){} // RVA: 0x7FFD54D6F1E0
    public void GetSubEmitterType(){} // RVA: 0x7FFD54D6F240
    public void GetSubEmitterProperties(){} // RVA: 0x7FFD54D6F2A0
    public void GetSubEmitterEmitProbability(){} // RVA: 0x7FFD54D6F300
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D6EDB0
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D6EE00
    public void get_subEmittersCount_Injected(){} // RVA: 0x7FFD54D6EE60
    public void AddSubEmitter_Injected(){} // RVA: 0x7FFD54D6EEB0
    public void RemoveSubEmitter_Injected(){} // RVA: 0x7FFD54D6EF60
    public void RemoveSubEmitterObject_Injected(){} // RVA: 0x7FFD54D6EFC0
    public void SetSubEmitterSystem_Injected(){} // RVA: 0x7FFD54D6F020
    public void SetSubEmitterType_Injected(){} // RVA: 0x7FFD54D6F090
    public void SetSubEmitterProperties_Injected(){} // RVA: 0x7FFD54D6F100
    public void SetSubEmitterEmitProbability_Injected(){} // RVA: 0x7FFD54D6F170
    public void GetSubEmitterSystem_Injected(){} // RVA: 0x7FFD54D6F1E0
    public void GetSubEmitterType_Injected(){} // RVA: 0x7FFD54D6F240
    public void GetSubEmitterProperties_Injected(){} // RVA: 0x7FFD54D6F2A0
    public void GetSubEmitterEmitProbability_Injected(){} // RVA: 0x7FFD54D6F300
}

public class SubmitEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55067790
}

public class Subscription : Object
{
    public object gate;
    public n.ngedAsync<T1717671888> parent;
    public yPermissionCheck<T1717671888> unsubscribeTarget;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class SwitchFullInputReport : ValueType
{
    public int kSize;
    public byte ExpectedReportId;
    public byte reportId; // 0x10
    public byte buttons0; // 0x13
    public byte buttons1; // 0x14
    public byte buttons2; // 0x15
    public byte left0; // 0x16
    public byte left1; // 0x17
    public byte left2; // 0x18
    public byte right0; // 0x19
    public byte right1; // 0x1A
    public byte right2; // 0x1B

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A77FF0
}

public class SwitchHIDGenericInputReport : ValueType
{
    public byte Format; // 0x10

    // ── Methods ──
    public void get_Format(){} // RVA: 0x7FFD54A782A0
}

public class SwitchInputOnlyReport : ValueType
{
    public int kSize;
    public byte buttons0; // 0x10
    public byte buttons1; // 0x11
    public byte hat; // 0x12
    public byte leftX; // 0x13
    public byte leftY; // 0x14
    public byte rightX; // 0x15
    public byte rightY; // 0x16

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A77A00
}

public class SwitchMagicOutputHIDBluetooth : ValueType
{
    public int Type;
    public Device.formUserAccount typeStatic; // 0x10
    public eenIndex report; // 0x18

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFD54A782B0
    public void get_typeStatic(){} // RVA: 0x7FFD54A782B0
    public void Create(){} // RVA: 0x7FFD54A782C0
}

public class SwitchMagicOutputHIDUSB : ValueType
{
    public int Type;
    public Device.formUserAccount typeStatic; // 0x10
    public eenIndex report; // 0x18

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFD54A782B0
    public void get_typeStatic(){} // RVA: 0x7FFD54A782B0
    public void Create(){} // RVA: 0x7FFD54A78310
}

public class SwitchMagicOutputReport : ValueType
{
    public int kSize;
    public byte ExpectedReplyInputReportId;
    public byte reportType; // 0x10
    public byte commandId; // 0x11
}

public class SwitchSimpleInputReport : ValueType
{
    public int kSize;
    public byte ExpectedReportId;
    public byte reportId; // 0x10
    public byte buttons0; // 0x11
    public byte buttons1; // 0x12
    public byte hat; // 0x13
    public ushort leftX; // 0x14
    public ushort leftY; // 0x16
    public ushort rightX; // 0x18
    public ushort rightY; // 0x1A

    // ── Methods ──
    public void ToHIDInputReport(){} // RVA: 0x7FFD54A77CE0
}

public class SyncHashtable : Hashtable
{
    public mePatterns.MES_SIZE Count; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539C4920 | overloaded x2
    public void GetObjectData(){} // RVA: 0x7FFD539C4980
    public void get_Count(){} // RVA: 0x7FFD539C49C0
    public void get_IsReadOnly(){} // RVA: 0x7FFD539C49F0
    public void get_IsFixedSize(){} // RVA: 0x7FFD539C4A20
    public void get_IsSynchronized(){} // RVA: 0x7FFD4E426850
    public void get_Item(){} // RVA: 0x7FFD539C4A50
    public void set_Item(){} // RVA: 0x7FFD539C4A80
    public void get_SyncRoot(){} // RVA: 0x7FFD539C4C20
    public void Add(){} // RVA: 0x7FFD539C4C50
    public void Clear(){} // RVA: 0x7FFD539C4DF0
    public void Contains(){} // RVA: 0x7FFD539C4F60
    public void ContainsKey(){} // RVA: 0x7FFD539C4F90
    public void CopyTo(){} // RVA: 0x7FFD539C5040
    public void Clone(){} // RVA: 0x7FFD539C51E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD539C53F0
    public void GetEnumerator(){} // RVA: 0x7FFD539C53F0
    public void get_Keys(){} // RVA: 0x7FFD539C5420
    public void get_Values(){} // RVA: 0x7FFD539C55B0
    public void Remove(){} // RVA: 0x7FFD539C5740
    public void OnDeserialization(){} // RVA: 0x7FFD4E341310
}

public class SyncTextReader : TextReader
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539EFD30
    public void Close(){} // RVA: 0x7FFD539EFDD0
    public void Dispose(){} // RVA: 0x7FFD539EFE00
    public void Peek(){} // RVA: 0x7FFD537AEC40
    public void Read(){} // RVA: 0x7FFD539EFE60 | overloaded x2
    public void ReadLine(){} // RVA: 0x7FFD539EFE90
    public void ReadToEnd(){} // RVA: 0x7FFD53879490
    public void ReadToEndAsync(){} // RVA: 0x7FFD539EFEC0
    public void ReadAsync(){} // RVA: 0x7FFD539EFF40
}

public class SyncTextWriter : TextWriter
{
    public Inherited.endency Encoding; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539F29D0
    public void get_Encoding(){} // RVA: 0x7FFD539F2AB0
    public void get_FormatProvider(){} // RVA: 0x7FFD539F2AE0
    public void get_NewLine(){} // RVA: 0x7FFD539F2B10
    public void Close(){} // RVA: 0x7FFD538D9050
    public void Dispose(){} // RVA: 0x7FFD539F2B40
    public void Flush(){} // RVA: 0x7FFD539F2BA0
    public void Write(){} // RVA: 0x7FFD539F2C30 | overloaded x8
    public void WriteLine(){} // RVA: 0x7FFD539F2CC0 | overloaded x5
    public void WriteAsync(){} // RVA: 0x7FFD539F2E70 | overloaded x3
    public void WriteLineAsync(){} // RVA: 0x7FFD539F2F60
    public void FlushAsync(){} // RVA: 0x7FFD539F3050
}

public class SyncTile : ValueType
{
    public lutionZ m_Position; // 0x10
    public ÏÍÍÎÏÏÌÏÍ.Í m_Tile; // 0x20
    public ÏÍÍÎÏÏÌÏÍ.acity m_TileData; // 0x28
}

public class SyncTileCallbackSettings : ValueType
{
    public bool hasSyncTileCallback; // 0x10
    public bool hasPositionsChangedCallback; // 0x11
    public bool isBufferSyncTile; // 0x12
}

public class SynchronizeInputs : ValueType
{
}

public class SynchronizeState : ValueType
{
}

public class SynchronousAsyncResult : Object
{
    public object IsCompleted; // 0x10
    public bool AsyncWaitHandle; // 0x18
    public sageKind.tion AsyncState; // 0x20
    public .Messaging.IInternalMessage.TargetIdentity.eDictionary CompletedSynchronously; // 0x28
    public bool _endXxxCalled; // 0x30
    public int _bytesRead; // 0x34

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53A0AC90 | overloaded x3
    public void get_IsCompleted(){} // RVA: 0x7FFD4E426850
    public void get_AsyncWaitHandle(){} // RVA: 0x7FFD53A0AE20
    public void get_AsyncState(){} // RVA: 0x7FFD4E35C380
    public void get_CompletedSynchronously(){} // RVA: 0x7FFD4E426850
    public void ThrowIfError(){} // RVA: 0x7FFD53A0AF80
    public void EndRead(){} // RVA: 0x7FFD53A091C0
    public void EndWrite(){} // RVA: 0x7FFD53A09420
}

public class SystemController : ScriptableObject
{
    public bool testSteamAccount; // 0x18

    // ── Methods ──
    public void BackPressed(){} // RVA: 0x7FFD4EDD4E30
    public void CreateInstance(){} // RVA: 0x7FFD4F68D6D0
    public void Equals(){} // RVA: 0x7FFD4F68D6D0
    public void CreateScriptableObject(){} // RVA: 0x7FFD4F68D700
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFD4F68D790
    public void GetHashCode(){} // RVA: 0x7FFD4F68D7E0
    public void ToString(){} // RVA: 0x7FFD4F68D870
    public void GetGameObject_E1B(){} // RVA: 0x7FFD4F68D900
    public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    public void Initialize(){} // RVA: 0x7FFD4F68D990
    public void GetGameObject_EAA(){} // RVA: 0x7FFD4F68DA10
    public void GetTouch(){} // RVA: 0x7FFD4F68DAA0
    public void CheckAndProcessSystemStatus(){} // RVA: 0x7FFD4F68DB20
    public void Initialize_F4380EE5B316(){} // RVA: 0x7FFD4F68DB20
    public void DoInternal_FromEulerRad_Injected_EF0(){} // RVA: 0x7FFD4F68DB30
}

public class SystemObjectSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD4E341310
    public void SetObjectData(){} // RVA: 0x7FFD5749BD90
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class SystemThreadingTasks_TaskSchedulerDebugView : Object
{
}

public class SystemThreading_SpinLockDebugView : Object
{
}
