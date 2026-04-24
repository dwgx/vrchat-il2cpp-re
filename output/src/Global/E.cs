// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 61
// Methods: 334

public class EditorDebugInfo : ValueType
{
    public int rootCount; // 0x10
    public int rootCapacity; // 0x14
    public int chainCount; // 0x18
    public int chainCapacity; // 0x1C
    public int boneCount; // 0x20
    public int boneCapacity; // 0x24
    public int shapeCount; // 0x28
    public int shapeCapacity; // 0x2C
    public long bytesUsed; // 0x30
}

public class ElementCount : ValueType
{
    public int uniqueCount; // 0x10
    public int unfoundCount; // 0x14
}

public class ElementPropertyPair : ValueType
{
    public URA.hEraNames<Left> Comparer;
    public ÎÏÌÎÎÎÌÌÌ.omLeftRadius element; // 0x10
    public tor.exSort property; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E77C3C0
    public void .cctor(){} // RVA: 0x7FFD55023FA0
}

public class EmissionModule : ValueType
{
    public InDuration enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D6A220
    public void set_enabled(){} // RVA: 0x7FFD54D6A270
    public void get_rateOverTime(){} // RVA: 0x7FFD54D6A2D0
    public void set_rateOverTime(){} // RVA: 0x7FFD54D6A340
    public void get_rateOverTimeMultiplier(){} // RVA: 0x7FFD54D6A3A0
    public void set_rateOverTimeMultiplier(){} // RVA: 0x7FFD54D6A3F0
    public void get_rateOverDistance(){} // RVA: 0x7FFD54D6A450
    public void set_rateOverDistance(){} // RVA: 0x7FFD54D6A4C0
    public void get_rateOverDistanceMultiplier(){} // RVA: 0x7FFD54D6A520
    public void set_rateOverDistanceMultiplier(){} // RVA: 0x7FFD54D6A570
    public void SetBursts(){} // RVA: 0x7FFD54D6A5F0 | overloaded x2
    public void GetBursts(){} // RVA: 0x7FFD54D6A710
    public void SetBurst(){} // RVA: 0x7FFD54D6A8B0
    public void GetBurst(){} // RVA: 0x7FFD54D6A920
    public void get_burstCount(){} // RVA: 0x7FFD54D6A9B0
    public void set_burstCount(){} // RVA: 0x7FFD54D6AA00
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D6A220
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D6A270
    public void get_rateOverTime_Injected(){} // RVA: 0x7FFD54D6AA60
    public void set_rateOverTime_Injected(){} // RVA: 0x7FFD54D6AAC0
    public void get_rateOverTimeMultiplier_Injected(){} // RVA: 0x7FFD54D6A3A0
    public void set_rateOverTimeMultiplier_Injected(){} // RVA: 0x7FFD54D6A3F0
    public void get_rateOverDistance_Injected(){} // RVA: 0x7FFD54D6AB20
    public void set_rateOverDistance_Injected(){} // RVA: 0x7FFD54D6AB80
    public void get_rateOverDistanceMultiplier_Injected(){} // RVA: 0x7FFD54D6A520
    public void set_rateOverDistanceMultiplier_Injected(){} // RVA: 0x7FFD54D6A570
    public void SetBurst_Injected(){} // RVA: 0x7FFD54D6ABE0
    public void GetBurst_Injected(){} // RVA: 0x7FFD54D6AC50
    public void get_burstCount_Injected(){} // RVA: 0x7FFD54D6A9B0
    public void set_burstCount_Injected(){} // RVA: 0x7FFD54D6AA00
}

public class EmitParams : ValueType
{
    public object particle; // 0x10
    public bool position; // 0x94
    public bool applyShapeToPosition; // 0x95
    public bool velocity; // 0x96
    public bool startLifetime; // 0x97
    public bool startSize; // 0x98
    public bool startSize3D; // 0x99
    public bool axisOfRotation; // 0x9A
    public bool rotation; // 0x9B
    public bool rotation3D; // 0x9C
    public bool angularVelocity; // 0x9D
    public bool angularVelocity3D; // 0x9E

    // ── Methods ──
    public void get_particle(){} // RVA: 0x7FFD54D71AA0
    public void set_particle(){} // RVA: 0x7FFD54D71AF0
    public void get_position(){} // RVA: 0x7FFD54D71B60
    public void set_position(){} // RVA: 0x7FFD54D71B80
    public void get_applyShapeToPosition(){} // RVA: 0x7FFD54D71BA0
    public void set_applyShapeToPosition(){} // RVA: 0x7FFD4F2268E0
    public void get_velocity(){} // RVA: 0x7FFD54D71BB0
    public void set_velocity(){} // RVA: 0x7FFD54D71BD0
    public void get_startLifetime(){} // RVA: 0x7FFD54D70320
    public void set_startLifetime(){} // RVA: 0x7FFD54D71BF0
    public void get_startSize(){} // RVA: 0x7FFD54D70370
    public void set_startSize(){} // RVA: 0x7FFD54D71C00
    public void get_startSize3D(){} // RVA: 0x7FFD54D71C20
    public void set_startSize3D(){} // RVA: 0x7FFD54D71C40
    public void get_axisOfRotation(){} // RVA: 0x7FFD54D71C60
    public void set_axisOfRotation(){} // RVA: 0x7FFD54D71C80
    public void get_rotation(){} // RVA: 0x7FFD54D703E0
    public void set_rotation(){} // RVA: 0x7FFD54D71CA0
    public void get_rotation3D(){} // RVA: 0x7FFD54D70410
    public void set_rotation3D(){} // RVA: 0x7FFD54D71CD0
    public void get_angularVelocity(){} // RVA: 0x7FFD54D70490
    public void set_angularVelocity(){} // RVA: 0x7FFD54D71D20
    public void get_angularVelocity3D(){} // RVA: 0x7FFD54D704C0
    public void set_angularVelocity3D(){} // RVA: 0x7FFD54D71D50
    public void get_startColor(){} // RVA: 0x7FFD54D70330
    public void set_startColor(){} // RVA: 0x7FFD54D71DA0
    public void get_randomSeed(){} // RVA: 0x7FFD54D70340
    public void set_randomSeed(){} // RVA: 0x7FFD54D71DB0
    public void set_meshIndex(){} // RVA: 0x7FFD54D71DC0
    public void ResetPosition(){} // RVA: 0x7FFD4F8F7E60
    public void ResetVelocity(){} // RVA: 0x7FFD54D71DE0
    public void ResetAxisOfRotation(){} // RVA: 0x7FFD54D71DF0
    public void ResetRotation(){} // RVA: 0x7FFD54D71E00
    public void ResetAngularVelocity(){} // RVA: 0x7FFD54D71E10
    public void ResetStartSize(){} // RVA: 0x7FFD54D71E20
    public void ResetStartColor(){} // RVA: 0x7FFD54D71E30
    public void ResetRandomSeed(){} // RVA: 0x7FFD54D71E40
    public void ResetStartLifetime(){} // RVA: 0x7FFD54D71E50
    public void ResetMeshIndex(){} // RVA: 0x7FFD54D71E60
}

public class EmojiMap : MonoBehaviour
{
    public stfix Animator; // 0x20
    public float Duration; // 0x28
    public amut PreviewCameraOffset; // 0x2C
    public float PreviewSpeed; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5527DBE0
}

public class EmojiParticleSystem : Object
{
    public itTypeSize=876 Key; // 0x10
    public string DisplayName; // 0x38

    // ── Methods ──
    public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
    public void get_Key(){} // RVA: 0x7FFD4F7DAEF0
    public void get_PrefabName(){} // RVA: 0x7FFD4E5F0140
    public void set_PrefabName(){} // RVA: 0x7FFD4E5F0140
    public void CompareBaseObjects(){} // RVA: 0x7FFD4EC33C20
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F7DAF80
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void get_DisplayName(){} // RVA: 0x7FFD4EC33C20
    public void set_DisplayName(){} // RVA: 0x7FFD4EC33C20
    public void Instantiate(){} // RVA: 0x7FFD4E5F0140
    public void Equals(){} // RVA: 0x7FFD4EC33C20
    public void GetHashCode(){} // RVA: 0x7FFD4F7DB010
}

public class EmptyAOTEmittedFormatter`1 : AOTEmittedFormatter`1
{
    // ── Methods ──
    public void ReadDataEntry(){}
    public void WriteDataEntries(){} // RVA: 0x7FFD4E099B30
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class EmptyArrayContainer`1 : Object
{
    public T1717645088[] Empty;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class EmptyData : ValueType
{
    public IStyle.set_translate<T1717596528> Default;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class EmptyInternalEnumerator`1 : Object
{
    public nePostProcessing<T1717586448> Current;

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class EncodingByteBuffer : Object
{
    public IntPtr MoreData; // 0x10
    public IntPtr CharsUsed; // 0x18
    public IntPtr Count; // 0x20
    public IntPtr chars; // 0x28
    public IntPtr charStart; // 0x30
    public IntPtr charEnd; // 0x38
    public int byteCountResult; // 0x40
    public em.MarkAborted.ION_4_7 enc; // 0x48
    public em.MarkAborted.illogicalCallContext encoder; // 0x50
    public em.MarkAborted.y fallbackBuffer; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53816310
    public void AddByte(){} // RVA: 0x7FFD53816860 | overloaded x4
    public void MovePrevious(){} // RVA: 0x7FFD538168C0
    public void get_MoreData(){} // RVA: 0x7FFD538169B0
    public void GetNextChar(){} // RVA: 0x7FFD53816A00
    public void get_CharsUsed(){} // RVA: 0x7FFD53816A80
    public void get_Count(){} // RVA: 0x7FFD4E3E2080
}

public class EncodingCharBuffer : Object
{
    public IntPtr MoreData; // 0x10
    public IntPtr BytesUsed; // 0x18
    public IntPtr Count; // 0x20
    public int charCountResult; // 0x28
    public em.MarkAborted.ION_4_7 enc; // 0x30
    public em.MarkAborted.ssed decoder; // 0x38
    public IntPtr byteStart; // 0x40
    public IntPtr byteEnd; // 0x48
    public IntPtr bytes; // 0x50
    public em.MarkAborted.FlowControl fallbackBuffer; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53815D10
    public void AddChar(){} // RVA: 0x7FFD53815FF0 | overloaded x2
    public void AdjustBytes(){} // RVA: 0x7FFD538160D0
    public void get_MoreData(){} // RVA: 0x7FFD538160E0
    public void GetNextByte(){} // RVA: 0x7FFD538160F0
    public void get_BytesUsed(){} // RVA: 0x7FFD53816110
    public void Fallback(){} // RVA: 0x7FFD538161A0 | overloaded x2
    public void get_Count(){} // RVA: 0x7FFD4E70C4C0
}

public class EncodingUtility : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD54CE5020
}

public class EndEditEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD550677D0
}

public class EndGraphicsJobsAfterScriptLateUpdate : ValueType
{
}

public class EndGraphicsJobsAfterScriptUpdate : ValueType
{
}

public class EndpointAccessEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class EnlightenRuntimeUpdate : ValueType
{
}

public class EnterStateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5106D540
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class Entry : ValueType
{
    public int _key; // 0x10
    public utes.Line _value; // 0x18
    public ?<int,utes.Line> _next; // 0x20
}

public class EnumResult : ValueType
{
    public object parsedEnum; // 0x10
    public bool canThrow; // 0x18
    public ed m_failure; // 0x1C
    public string m_failureMessageID; // 0x20
    public string m_failureParameter; // 0x28
    public object m_failureMessageFormatArgument; // 0x30
    public ÏÏÍÍÎÎ m_innerException; // 0x38

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFD53A9C1D0
    public void SetFailure(){} // RVA: 0x7FFD53A9C400 | overloaded x3
    public void GetEnumParseException(){} // RVA: 0x7FFD53A9C500
}

public class EnumerableDictionaryWrapper`2 : Object
{
    public URA.bbrevEraNames<URA.mes<T1717703360,T1717703376>> _e;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
}

public class EnumerableDropIndices : Object
{
    public URA.bbrevEraNames<URA.mes<long,T1717590688>> _source;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class Enumerator : ValueType
{
    public URA.DateTime<string,object> _dictionary; // 0x10
    public int _version; // 0x18
    public int _index; // 0x1C
    public URA.mes<string,object> _current; // 0x20
    public int _getEnumeratorRetType; // 0x30
}

public class EnumeratorDropIndices : Object
{
    public URA.saAbbrevEnglishEraNames<URA.mes<long,T1717590704>> Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void Reset(){} // RVA: 0x7FFD4E090980
}

public class EnumeratorObject : Object
{
    public URA.saAbbrevEnglishEraNames<T1717733984> Current;
    public T1717733984[] System.Collections.IEnumerator.Current;
    public int _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFD4E078E90
    public void MoveNext(){} // RVA: 0x7FFD4E079D00
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFD4E090980
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void Create(){} // RVA: 0x7FFD4E078F80
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class EnvelopeDefinition : ValueType
{
    public ÍÎÌÍÍÌÌÎÏÏ Duration; // 0x10
    public ÍÎÌÍÍÌÌÎÏÏ m_DecayShape; // 0x18
    public float m_AttackTime; // 0x20
    public float m_SustainTime; // 0x24
    public float m_DecayTime; // 0x28
    public bool m_ScaleWithImpact; // 0x2C
    public bool m_HoldForever; // 0x2D

    // ── Methods ──
    public void Default(){} // RVA: 0x7FFD4FC79A30
    public void get_Duration(){} // RVA: 0x7FFD4FC79A50
    public void GetValueAt(){} // RVA: 0x7FFD4FC79A70
    public void ChangeStopTime(){} // RVA: 0x7FFD4FC79BC0
    public void Clear(){} // RVA: 0x7FFD4FC79BF0
    public void Validate(){} // RVA: 0x7FFD4FC79CB0
}

public class EqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFD544650B0
    public void GetHashCode(){} // RVA: 0x7FFD54465340
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void <Equals>g__CompareLists|0_0(){} // RVA: 0x7FFD4E07A350
    public void <GetHashCode>g__AddListHashCode|1_0(){} // RVA: 0x7FFD4E090C80
    public void <GetHashCode>g__AddHashCode|1_1(){} // RVA: 0x7FFD4E2ADC40
}

public class ErrorDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E432370
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class ErrorEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FD55D20
    public void Invoke(){} // RVA: 0x7FFD4E49D370
}

public class Escape : ValueType
{
    public string Source; // 0x10
    public int Index; // 0x18
    public int Start; // 0x1C
    public int End; // 0x20
    public int Optional; // 0x24
}

public class EscaperImplementation : ScalarEscaperBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53EA6D30
    public void EncodeUtf8(){} // RVA: 0x7FFD543EE480
    public void EncodeUtf16(){} // RVA: 0x7FFD543EE580
    public void .cctor(){} // RVA: 0x7FFD543EE680
    public void <EncodeUtf8>g__TryEncodeScalarAsHex|4_0(){} // RVA: 0x7FFD543EE7D0
    public void <EncodeUtf16>g__TryEncodeScalarAsHex|5_0(){} // RVA: 0x7FFD543EEAF0
}

public class EventData : ValueType
{
    public UIntPtr DataPointer; // 0x10
    public int Size; // 0x18
    public int Reserved; // 0x1C

    // ── Methods ──
    public void set_DataPointer(){} // RVA: 0x7FFD4F9DB120
    public void set_Size(){} // RVA: 0x7FFD4FDE7510
    public void set_Reserved(){} // RVA: 0x7FFD4FDE7530
}

public class EventDataBuffer : ValueType
{
    public rnalGetValues EventType; // 0x10
    public byte[] EventData; // 0x18
}

public class EventFunction`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    public void BeginInvoke(){} // RVA: 0x7FFD4E2ADC40
    public void EndInvoke(){} // RVA: 0x7FFD4E090A40
}

public class EventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class EventReplicator`2 : MonoBehaviour
{
    public ÎÏÎÏÌÍÍÎ<?,?> _destroyCancellationToken; // 0x20
    public int _useGUILayout;
    public int f_AAB;
    public int f_9F8;
    public int ÎÌÌÍÎÏÎÌÌÎÏÎÍÎÎÏÏÎÎÍÌÎÍ;
    public URA.woDigitYearMax<ÎÌÍÏÏÌÍÏ> ÏÎÏÎÎÍÌÌÎÎÏÍÍÏÏÌÏÌÏÍÍÏÌ; // 0x28
    public ?<?,?> ÍÍÌÌÌÍÎÎÎÏÌÌÍÏÏÍÍÍÎÎÍÎÏ; // 0x30
    public URA.onsDepth<?> ÏÏÌÎÍÏÌÎÌÎÌÏÎÌÍÌÏÎÍÌÌÍÎ; // 0x38
    public URA.woDigitYearMax<?> ÌÌÏÎÍÏÍÌÍÎÌÏÌÍÌÏÏÍÎÍÎÌÏ; // 0x40
    public URA.DateTime<int,URA.woDigitYearMax<?>> ÍÍÎÎÍÍÍÎÏÌÏÍÎÍÍÏÌÎÍÏÏÏÍ; // 0x48
    public bool ÎÌÍÎÌÌÌÍÎÌÍÌÍÎÍÏÌÍÍÎÍÌÎ; // 0x50
    public object ÍÌÌÏÍÍÏÏÌÍÍÏÏÏÍÏÎÎÍÏÏÌÍ; // 0x58
    public URA.woDigitYearMax<int> ÍÎÌÍÌÏÎÎÎÎÍÌÏÌÍÍÎÎÌÏÍÎÎ; // 0x60
    public URA.woDigitYearMax<?> ÏÍÍÍÌÌÏÍÍÎÎÎÎÍÌÎÌÍÎÏÎÌÌ; // 0x68
    public URA.woDigitYearMax<byte[]> ÍÌÎÌÎÌÏÏÌÍÎÌÍÌÍÌÍÎÎÏÎÌÌ; // 0x70

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFD4E090980
    public void RaiseCancellation(){} // RVA: 0x7FFD4E079D00
    public void IsInvoking(){} // RVA: 0x7FFD4E2ADC40
    public void CancelInvoke(){} // RVA: 0x7FFD4E090A40
    public void Invoke(){} // RVA: 0x7FFD4E079D00
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Initialize(){} // RVA: 0x7FFD4E079D00
    public void WriteValue(){} // RVA: 0x7FFD4E099B30
    public void StartCoroutine(){} // RVA: 0x7FFD4E090980
    public void StartCoroutine_Auto(){} // RVA: 0x7FFD4E079960
    public void ContainsChild(){} // RVA: 0x7FFD4E090A40
    public void StartCoroutine_Auto_89FFABA90D39(){} // RVA: 0x7FFD4E079960
    public void StopCoroutine(){} // RVA: 0x7FFD4E090A40
    public void StopCoroutine_C7ED6DFD8918(){} // RVA: 0x7FFD4E090980
    public void OnEnable(){} // RVA: 0x7FFD4E090A40
    public void StopAllCoroutines(){} // RVA: 0x7FFD4E090A40
    public void Awake(){} // RVA: 0x7FFD4E090980
    public void Update(){} // RVA: 0x7FFD4E090980
    public void print(){} // RVA: 0x7FFD4E079D00
    public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4E2ADC40
    public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4E07E6B0
    public void GetSessionId(){} // RVA: 0x7FFD4E078E90
    public void OnDisable(){} // RVA: 0x7FFD4E078E90
    public void OnBecameVisible(){} // RVA: 0x7FFD4E090A40
    public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4E2ADC40
    public void Start(){} // RVA: 0x7FFD4E078E90
    public void OnDestroy(){} // RVA: 0x7FFD4E090980
    public void StopCoroutineManaged(){} // RVA: 0x7FFD4E079D00
    public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4E090980
}

public class EventSystemChecker : MonoBehaviour
{
    // ── Methods ──
    public void Awake(){} // RVA: 0x7FFD4E341DA0
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class Event`1 : UnityEvent`1
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFD4E090A40
    public void Remove(){} // RVA: 0x7FFD4E090A40
    public void Send(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class Event`2 : UnityEvent`2
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFD4E090A40
    public void Remove(){} // RVA: 0x7FFD4E090A40
    public void Send(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class Event`3 : UnityEvent`3
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFD4E090A40
    public void Remove(){} // RVA: 0x7FFD4E090A40
    public void Send(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class ExceptionFromErrorCode : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5387F630
    public void Invoke(){} // RVA: 0x7FFD4EC5F780
}

public class ExceptionResultSource : Object
{
    public .Messaging.IInternalMessage.TargetIdentity.eDictionary exception; // 0x10
    public bool calledGet; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5107C7A0
    public void GetResult(){} // RVA: 0x7FFD548B1310
    public void GetStatus(){} // RVA: 0x7FFD4E446CB0
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E446CB0
    public void OnCompleted(){} // RVA: 0x7FFD5107C990
    public void Finalize(){} // RVA: 0x7FFD548B1370
}

public class ExceptionResultSource`1 : Object
{
    public .Messaging.IInternalMessage.TargetIdentity.eDictionary exception;
    public bool calledGet;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
    public void Finalize(){} // RVA: 0x7FFD4E090980
}

public class ExecuteGameCenterCallbacks : ValueType
{
}

public class ExecuteJobFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){}
}

public class ExecuteMainThreadJobs : ValueType
{
}

public class ExitStateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5106D540
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class ExperimentSegment : Object
{
    public object Key;
    public object Payload;
    public object RawPayload;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E420E00
    public void get_Key(){} // RVA: 0x7FFD4E35C380
    public void set_Key(){} // RVA: 0x7FFD4E342E30
    public void get_Payload(){} // RVA: 0x7FFD4E3447C0
    public void set_Payload(){} // RVA: 0x7FFD4E3A7E80
    public void get_RawPayload(){} // RVA: 0x7FFD4E36F0C0
    public void set_RawPayload(){} // RVA: 0x7FFD4E36F0D0
}

public class ExperimentsManager : Object
{
    public ?<bool> _name; // 0x10
    public ÏÏÎÍÏÏÌÌÎÌÏÏÏÍÏÍ _hideFlags; // 0x18
    public ÏÏÎÍÏÏÌÌÎÌÏÏÏÍÏÍ f_F9A; // 0x20

    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFD4E342E30
    public void Equals(){} // RVA: 0x7FFD4E36F0C0
    public void GetHashCode(){} // RVA: 0x7FFD4E35C380
    public void op_Implicit(){} // RVA: 0x7FFD4E36F0C0
    public void CompareBaseObjects(){} // RVA: 0x7FFD4E342E30
    public void StaticInitialize(){} // RVA: 0x7FFD4F0A1730
    public void GetCachedPtr(){} // RVA: 0x7FFD4E3447C0
    public void get_name(){} // RVA: 0x7FFD4F0A1810
    public void set_name(){} // RVA: 0x7FFD4E342E30
    public void .ctor(){} // RVA: 0x7FFD4F0A18F0
    public void Instantiate(){} // RVA: 0x7FFD4E3447C0
}

public class Expression : Object
{
    public string[] rpnTokens; // 0x10
    public bool hasVariables; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C83B40
    public void Evaluate(){}
}

public class ExpressionIcons : ValueType
{
    public ector typeToggleOn; // 0x10
    public ector typeToggleOff; // 0x18
    public ector typeFolder; // 0x20
    public ector typeAxis; // 0x28
    public ector typeRadial; // 0x30
    public ector typePlayOn; // 0x38
    public ector typePlayOff; // 0x40
}

public class ExpressionQuoter : ExpressionVisitor
{
    public URA.DateTime<iggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync.eneric.IEnumerator<TElement>.Current,rmat_String_ObjectArray.er> _variables; // 0x10
    public rmat_String_ObjectArray.derExtensions _frame; // 0x18
    public URA.leEastFrench<URA.onsDepth<iggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync.eneric.IEnumerator<TElement>.Current>> _shadowedVars; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD542101A0
    public void VisitLambda(){} // RVA: 0x7FFD4E078F40
    public void VisitBlock(){} // RVA: 0x7FFD54210320
    public void VisitCatchBlock(){} // RVA: 0x7FFD54210580
    public void VisitRuntimeVariables(){} // RVA: 0x7FFD54210750
    public void MergeRuntimeVariables(){} // RVA: 0x7FFD54210D50
    public void VisitParameter(){} // RVA: 0x7FFD54210EA0
    public void GetBox(){} // RVA: 0x7FFD54210FC0
}

public class ExtensionReflectionHelper`2 : Object
{
    public gBox.GetMonthNamesCore extension;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void GetExtension(){} // RVA: 0x7FFD4E078F40
    public void HasExtension(){} // RVA: 0x7FFD4E079F60
    public void SetExtension(){} // RVA: 0x7FFD4E099B30
    public void ClearExtension(){} // RVA: 0x7FFD4E090A40
}

public class ExternalForcesModule : ValueType
{
    public InDuration enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D78560
    public void set_enabled(){} // RVA: 0x7FFD54D785B0
    public void get_multiplier(){} // RVA: 0x7FFD54D78610
    public void set_multiplier(){} // RVA: 0x7FFD54D78660
    public void get_multiplierCurve(){} // RVA: 0x7FFD54D786C0
    public void set_multiplierCurve(){} // RVA: 0x7FFD54D78730
    public void get_influenceFilter(){} // RVA: 0x7FFD54D78790
    public void set_influenceFilter(){} // RVA: 0x7FFD54D787E0
    public void get_influenceMask(){} // RVA: 0x7FFD54D78840
    public void set_influenceMask(){} // RVA: 0x7FFD54D788A0
    public void get_influenceCount(){} // RVA: 0x7FFD54D78900
    public void IsAffectedBy(){} // RVA: 0x7FFD54D78950
    public void AddInfluence(){} // RVA: 0x7FFD54D789B0
    public void RemoveInfluenceAtIndex(){} // RVA: 0x7FFD54D78A10
    public void RemoveInfluence(){} // RVA: 0x7FFD54D78A70 | overloaded x2
    public void RemoveAllInfluences(){} // RVA: 0x7FFD54D78AD0
    public void SetInfluence(){} // RVA: 0x7FFD54D78B20
    public void GetInfluence(){} // RVA: 0x7FFD54D78B90
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D78560
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D785B0
    public void get_multiplier_Injected(){} // RVA: 0x7FFD54D78610
    public void set_multiplier_Injected(){} // RVA: 0x7FFD54D78660
    public void get_multiplierCurve_Injected(){} // RVA: 0x7FFD54D78BF0
    public void set_multiplierCurve_Injected(){} // RVA: 0x7FFD54D78C50
    public void get_influenceFilter_Injected(){} // RVA: 0x7FFD54D78790
    public void set_influenceFilter_Injected(){} // RVA: 0x7FFD54D787E0
    public void get_influenceMask_Injected(){} // RVA: 0x7FFD54D78CB0
    public void set_influenceMask_Injected(){} // RVA: 0x7FFD54D78D10
    public void get_influenceCount_Injected(){} // RVA: 0x7FFD54D78900
    public void IsAffectedBy_Injected(){} // RVA: 0x7FFD54D78950
    public void AddInfluence_Injected(){} // RVA: 0x7FFD54D789B0
    public void RemoveInfluenceAtIndex_Injected(){} // RVA: 0x7FFD54D78A10
    public void RemoveInfluence_Injected(){} // RVA: 0x7FFD54D78A70
    public void RemoveAllInfluences_Injected(){} // RVA: 0x7FFD54D78AD0
    public void SetInfluence_Injected(){} // RVA: 0x7FFD54D78B20
    public void GetInfluence_Injected(){} // RVA: 0x7FFD54D78B90
}

public class ExtractKeyDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class EyeRotationLimiterForExport : Object
{
    public string transformPath; // 0x10
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÌÍÎÍÌÌÌÎÎÍÎÌ defaultQ; // 0x18
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÌÍÎÍÌÌÌÎÎÍÎÌ lookUpQ; // 0x28
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÌÍÎÍÌÌÌÎÎÍÎÌ lookDownQ; // 0x38
    public bool isLookUpSet; // 0x48
    public bool isLookDownSet; // 0x49

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class EyelidPositionBlendshape : Object
{
    public ure skinnedMeshRenderer; // 0x10
    public float defaultWeight; // 0x18
    public float positionWeight; // 0x1C
    public int index; // 0x20
    public string name; // 0x28
    public bool isUsedInEalierConfig; // 0x30

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4F928030
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Initialize(){} // RVA: 0x7FFD4F9284A0
    public void op_Implicit(){} // RVA: 0x7FFD4F928670
    public void CompareBaseObjects(){} // RVA: 0x7FFD4F928840
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F928BD0
    public void GetCachedPtr(){} // RVA: 0x7FFD4F928DA0
    public void get_name(){} // RVA: 0x7FFD4F928F70
    public void set_name(){} // RVA: 0x7FFD4F9293E0
    public void Instantiate(){} // RVA: 0x7FFD4F929770
    public void Equals(){} // RVA: 0x7FFD4F929BF0
    public void GetHashCode(){} // RVA: 0x7FFD4F92A060
}

public class EyelidPositionBlendshapeForExport : Object
{
    public string skinnedMeshRendererPath; // 0x10
    public float defaultWeight; // 0x18
    public float positionWeight; // 0x1C
    public int index; // 0x20
    public string name; // 0x28
    public bool isUsedInEalierConfig; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class EyelidRotationLimiterForExport : Object
{
    public string transformPath; // 0x10
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÌÍÎÍÌÌÌÎÎÍÎÌ defaultQ; // 0x18
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÌÍÎÍÌÌÌÎÎÍÎÌ closedQ; // 0x28
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÌÍÎÍÌÌÌÎÎÍÎÌ lookUpQ; // 0x38
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÌÍÎÍÌÌÌÎÎÍÎÌ lookDownQ; // 0x48
    public float eyeMaxDownAngle; // 0x58
    public float eyeMaxUpAngle; // 0x5C
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÍÍÎÎÎÌÏÌÌÎÌÏÎÌÏÎ defaultPos; // 0x60
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÍÍÎÎÎÌÏÌÌÎÌÏÎÌÏÎ closedPos; // 0x6C
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÍÍÎÎÎÌÏÌÌÎÌÏÎÌÏÎ lookUpPos; // 0x78
    public ÍÎÏÎÌÍÌÎÌÌÌÎÎÌÌÌÍÌÎÌ.ÍÍÎÎÎÌÏÌÌÎÌÏÎÌÏÎ lookDownPos; // 0x84
    public bool isLookUpSet; // 0x90
    public bool isLookDownSet; // 0x91
    public bool isDefaultPosSet; // 0x92
    public bool isClosedPosSet; // 0x93
    public bool isLookUpPosSet; // 0x94
    public bool isLookDownPosSet; // 0x95

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}
