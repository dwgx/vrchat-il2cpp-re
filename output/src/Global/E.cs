// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 415

public class EarlyInitFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class Easing : Object
{
    // ── Methods ──
    public void GetFunction(){} // RVA: 0x7FFE82A305A0
    public void PowerEaseIn(){} // RVA: 0x7FFE82A30AA0
    public void PowerEaseOut(){} // RVA: 0x7FFE82A30AB0
    public void PowerEaseInOut(){} // RVA: 0x7FFE82A30AF0
    public void Step(){} // RVA: 0x7FFE82A30B70
    public void Linear(){} // RVA: 0x7FFE810FB310
    public void InQuad(){} // RVA: 0x7FFE82A30B90
    public void OutQuad(){} // RVA: 0x7FFE82A30BA0
    public void InOutQuad(){} // RVA: 0x7FFE82A30BE0
    public void InCubic(){} // RVA: 0x7FFE82A30BF0
    public void OutCubic(){} // RVA: 0x7FFE82A30C00
    public void InOutCubic(){} // RVA: 0x7FFE82A30C40
    public void InQuart(){} // RVA: 0x7FFE82A30C50
    public void OutQuart(){} // RVA: 0x7FFE82A30C60
    public void InOutQuart(){} // RVA: 0x7FFE82A30CA0
    public void InQuint(){} // RVA: 0x7FFE82A30CB0
    public void OutQuint(){} // RVA: 0x7FFE82A30CC0
    public void InOutQuint(){} // RVA: 0x7FFE82A30D00
    public void InExpo(){} // RVA: 0x7FFE82A30D10
    public void OutExpo(){} // RVA: 0x7FFE82A30D50
    public void InOutExpo(){} // RVA: 0x7FFE82A30DA0
    public void .ctor(){} // RVA: 0x7FFE82880410
}

public class EditorDebugInfo : ValueType
{
}

public class EditorSettings : Object
{
    public double kMinFrameRate;
    public double kMaxFrameRate; // 0x8
    public double kDefaultFrameRate; // 0x10

    // ── Methods ──
    public void get_fps(){} // RVA: 0x7FFE87B64750
    public void set_fps(){} // RVA: 0x7FFE87B64760
    public void get_frameRate(){} // RVA: 0x7FFE83BB0D80
    public void set_frameRate(){} // RVA: 0x7FFE87B64810
    public void SetStandardFrameRate(){} // RVA: 0x7FFE87B64830
    public void get_scenePreview(){} // RVA: 0x7FFE811164E0
    public void set_scenePreview(){} // RVA: 0x7FFE811164F0
    public void .ctor(){} // RVA: 0x7FFE87B64B70
    public void .cctor(){} // RVA: 0x7FFE87B64BE0
}

public class EffectorLink : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ElemInfo : ValueType
{
    // ── Methods ──
    public void Set(){} // RVA: 0x7FFE8743C290
    public void Clear(){} // RVA: 0x7FFE8743C360
}

public class Element : ValueType
{
}

public class ElementContent : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ElementCount : ValueType
{
}

public class ElementPropertyPair : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE815AE520
    public void .cctor(){} // RVA: 0x7FFE87FAC7F0
}

public class ElementScope : ValueType
{
    // ── Methods ──
    public void Set(){} // RVA: 0x7FFE8757EC30
    public void WriteEndElement(){} // RVA: 0x7FFE8757EDB0
    public void WriteFullEndElement(){} // RVA: 0x7FFE8757EDF0
}

public class EmailAddress : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86712520
}

public class Emission : ValueType
{
}

public class EmissionModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x63
    public object field_2; // 0x64
    public object field_3; // 0x65
    public object field_4; // 0x66
    public object field_5; // 0x67

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CF2AC0
    public void set_enabled(){} // RVA: 0x7FFE87CF2B10
    public void get_rateOverTime(){} // RVA: 0x7FFE87CF2B70
    public void set_rateOverTime(){} // RVA: 0x7FFE87CF2BE0
    public void get_rateOverTimeMultiplier(){} // RVA: 0x7FFE87CF2C40
    public void set_rateOverTimeMultiplier(){} // RVA: 0x7FFE87CF2C90
    public void get_rateOverDistance(){} // RVA: 0x7FFE87CF2CF0
    public void set_rateOverDistance(){} // RVA: 0x7FFE87CF2D60
    public void get_rateOverDistanceMultiplier(){} // RVA: 0x7FFE87CF2DC0
    public void set_rateOverDistanceMultiplier(){} // RVA: 0x7FFE87CF2E10
    public void SetBursts(){} // RVA: 0x7FFE87CF2E90 | overloaded x2
    public void GetBursts(){} // RVA: 0x7FFE87CF2FB0
    public void SetBurst(){} // RVA: 0x7FFE87CF3150
    public void GetBurst(){} // RVA: 0x7FFE87CF31C0
    public void get_burstCount(){} // RVA: 0x7FFE87CF3250
    public void set_burstCount(){} // RVA: 0x7FFE87CF32A0
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CF2AC0
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CF2B10
    public void get_rateOverTime_Injected(){} // RVA: 0x7FFE87CF3300
    public void set_rateOverTime_Injected(){} // RVA: 0x7FFE87CF3360
    public void get_rateOverTimeMultiplier_Injected(){} // RVA: 0x7FFE87CF2C40
    public void set_rateOverTimeMultiplier_Injected(){} // RVA: 0x7FFE87CF2C90
    public void get_rateOverDistance_Injected(){} // RVA: 0x7FFE87CF33C0
    public void set_rateOverDistance_Injected(){} // RVA: 0x7FFE87CF3420
    public void get_rateOverDistanceMultiplier_Injected(){} // RVA: 0x7FFE87CF2DC0
    public void set_rateOverDistanceMultiplier_Injected(){} // RVA: 0x7FFE87CF2E10
    public void SetBurst_Injected(){} // RVA: 0x7FFE87CF3480
    public void GetBurst_Injected(){} // RVA: 0x7FFE87CF34F0
    public void get_burstCount_Injected(){} // RVA: 0x7FFE87CF3250
    public void set_burstCount_Injected(){} // RVA: 0x7FFE87CF32A0
}

public class EmitParams : ValueType
{
    public Particle m_Particle; // 0x10
    public bool m_PositionSet; // 0x94
    public bool m_VelocitySet; // 0x95
    public bool m_AxisOfRotationSet; // 0x96
    public bool m_RotationSet; // 0x97
    public bool m_AngularVelocitySet; // 0x98
    public bool m_StartSizeSet; // 0x99
    public bool m_StartColorSet; // 0x9A
    public bool m_RandomSeedSet; // 0x9B
    public bool m_StartLifetimeSet; // 0x9C
    public bool m_MeshIndexSet; // 0x9D
    public bool m_ApplyShapeToPosition; // 0x9E
    public object field_12; // 0xEE
    public object field_13; // 0xEF
    public object field_14; // 0xF0

    // ── Methods ──
    public void get_particle(){} // RVA: 0x7FFE87CFA340
    public void set_particle(){} // RVA: 0x7FFE87CFA390
    public void get_position(){} // RVA: 0x7FFE87CFA400
    public void set_position(){} // RVA: 0x7FFE87CFA420
    public void get_applyShapeToPosition(){} // RVA: 0x7FFE87CFA440
    public void set_applyShapeToPosition(){} // RVA: 0x7FFE820BD5D0
    public void get_velocity(){} // RVA: 0x7FFE87CFA450
    public void set_velocity(){} // RVA: 0x7FFE87CFA470
    public void get_startLifetime(){} // RVA: 0x7FFE87CF8BC0
    public void set_startLifetime(){} // RVA: 0x7FFE87CFA490
    public void get_startSize(){} // RVA: 0x7FFE87CF8C10
    public void set_startSize(){} // RVA: 0x7FFE87CFA4A0
    public void get_startSize3D(){} // RVA: 0x7FFE87CFA4C0
    public void set_startSize3D(){} // RVA: 0x7FFE87CFA4E0
    public void get_axisOfRotation(){} // RVA: 0x7FFE87CFA500
    public void set_axisOfRotation(){} // RVA: 0x7FFE87CFA520
    public void get_rotation(){} // RVA: 0x7FFE87CF8C80
    public void set_rotation(){} // RVA: 0x7FFE87CFA540
    public void get_rotation3D(){} // RVA: 0x7FFE87CF8CB0
    public void set_rotation3D(){} // RVA: 0x7FFE87CFA570
    public void get_angularVelocity(){} // RVA: 0x7FFE87CF8D30
    public void set_angularVelocity(){} // RVA: 0x7FFE87CFA5C0
    public void get_angularVelocity3D(){} // RVA: 0x7FFE87CF8D60
    public void set_angularVelocity3D(){} // RVA: 0x7FFE87CFA5F0
    public void get_startColor(){} // RVA: 0x7FFE87CF8BD0
    public void set_startColor(){} // RVA: 0x7FFE87CFA640
    public void get_randomSeed(){} // RVA: 0x7FFE87CF8BE0
    public void set_randomSeed(){} // RVA: 0x7FFE87CFA650
    public void set_meshIndex(){} // RVA: 0x7FFE87CFA660
    public void ResetPosition(){} // RVA: 0x7FFE812DC7B0
    public void ResetVelocity(){} // RVA: 0x7FFE87CFA680
    public void ResetAxisOfRotation(){} // RVA: 0x7FFE87CFA690
    public void ResetRotation(){} // RVA: 0x7FFE87CFA6A0
    public void ResetAngularVelocity(){} // RVA: 0x7FFE87CFA6B0
    public void ResetStartSize(){} // RVA: 0x7FFE87CFA6C0
    public void ResetStartColor(){} // RVA: 0x7FFE87CFA6D0
    public void ResetRandomSeed(){} // RVA: 0x7FFE87CFA6E0
    public void ResetStartLifetime(){} // RVA: 0x7FFE87CFA6F0
    public void ResetMeshIndex(){} // RVA: 0x7FFE87CFA700
}

public class EmojiMap : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE88210550
}

public class EmojiParticleSystem : Object
{
    public VRC.Localization.LocalizableString _name; // 0x10
    public string _prefabName; // 0x38
    public object field_2; // 0x6F2

    // ── Methods ──
    public void get_DisplayName(){} // RVA: 0x7FFE8196FB10
    public void get_PrefabName(){} // RVA: 0x7FFE8143BA80
    public void set_PrefabName(){} // RVA: 0x7FFE8196FB10
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Initialize(){} // RVA: 0x7FFE82693970
    public void set_Key(){} // RVA: 0x7FFE8143BA80
    public void get_Key(){} // RVA: 0x7FFE82693A00
    public void get_name(){} // RVA: 0x7FFE82693A90
    public void set_name(){} // RVA: 0x7FFE8143BA80
    public void Instantiate(){} // RVA: 0x7FFE8196FB10
    public void Equals(){} // RVA: 0x7FFE8143BA80
    public void GetHashCode(){} // RVA: 0x7FFE82693B20
}

public class EmptyAOTEmittedFormatter`1 : AOTEmittedFormatter`1
{
    // ── Methods ──
    public void ReadDataEntry(){}
    public void WriteDataEntries(){} // RVA: 0x7FFE80E4F230
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class EmptyArrayContainer`1 : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class EmptyCustomTypeDescriptor : CustomTypeDescriptor
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EmptyData : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class EmptyInternalEnumerator`1 : Object
{
    public EmptyInternalEnumerator`1<UnityEngine.InputSystem.InputDevice> Value;
    public object field_1; // 0x78D0
}

public class EmptyParticle : XmlSchemaParticle
{
    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7FFE811E0850
    public void .ctor(){} // RVA: 0x7FFE874ED7D0
}

public class EmptyStream : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8765B100
}

public class Encoder : EncoderNLS
{
    public int bits; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86790600
    public void Reset(){} // RVA: 0x7FFE86790610
    public void get_HasState(){} // RVA: 0x7FFE86790640
}

public class EncodingByteBuffer : Object
{
    public byte* bytes; // 0x10
    public byte* byteStart; // 0x18
    public byte* byteEnd; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8679FC10
    public void AddByte(){} // RVA: 0x7FFE867A0160 | overloaded x4
    public void MovePrevious(){} // RVA: 0x7FFE867A01C0
    public void get_MoreData(){} // RVA: 0x7FFE867A02B0
    public void GetNextChar(){} // RVA: 0x7FFE867A0300
    public void get_CharsUsed(){} // RVA: 0x7FFE867A0380
    public void get_Count(){} // RVA: 0x7FFE8119C080
}

public class EncodingCharBuffer : Object
{
    public char* chars; // 0x10
    public char* charStart; // 0x18
    public char* charEnd; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8679F610
    public void AddChar(){} // RVA: 0x7FFE8679F8F0 | overloaded x2
    public void AdjustBytes(){} // RVA: 0x7FFE8679F9D0
    public void get_MoreData(){} // RVA: 0x7FFE8679F9E0
    public void GetNextByte(){} // RVA: 0x7FFE8679F9F0
    public void get_BytesUsed(){} // RVA: 0x7FFE8679FA10
    public void Fallback(){} // RVA: 0x7FFE8679FAA0 | overloaded x2
    public void get_Count(){} // RVA: 0x7FFE81549710
}

public class EncodingUtility : Object
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE87C6D750
}

public class Encoding_GetString : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86E29980
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class EncryptedData : Object
{
    public byte _version; // 0x10
    public ContentInfo _content; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE866FA9D0 | overloaded x2
    public void get_EncryptionAlgorithm(){} // RVA: 0x7FFE811290C0
    public void get_EncryptedContent(){} // RVA: 0x7FFE866FADD0
}

public class EncryptedPrivateKeyInfo : Object
{
    public string _algorithm; // 0x10
    public byte[] _salt; // 0x18
    public int _iterations; // 0x20
    public byte[] _data; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86722BC0 | overloaded x2
    public void get_Algorithm(){} // RVA: 0x7FFE81116380
    public void set_Algorithm(){} // RVA: 0x7FFE810FCE30
    public void get_EncryptedData(){} // RVA: 0x7FFE86722BD0
    public void set_EncryptedData(){} // RVA: 0x7FFE86722C50
    public void get_Salt(){} // RVA: 0x7FFE86722D30
    public void get_IterationCount(){} // RVA: 0x7FFE8151D690
    public void set_IterationCount(){} // RVA: 0x7FFE86722E40
    public void Decode(){} // RVA: 0x7FFE86722EC0
    public void GetBytes(){} // RVA: 0x7FFE86723280
}

public class EndEditEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87FF0020
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
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EnlightenRuntimeUpdate : ValueType
{
}

public class EnterStateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83F84C40
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE82886970
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Entries : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Entry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class EnumFlagAttribute : PropertyAttribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EnumMapMember : Object
{
    public string _xmlName; // 0x10
    public string _enumName; // 0x18
    public long _value; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8760DB20
    public void get_XmlName(){} // RVA: 0x7FFE81116380
    public void get_EnumName(){} // RVA: 0x7FFE810FE7C0
    public void get_Value(){} // RVA: 0x7FFE811290C0
}

public class EnumReservedRange : Object
{
    public Google.Protobuf.MessageParser`1<EnumReservedRange> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public int StartDefaultValue; // 0x8
    public int start_; // 0x1C
    public int EndDefaultValue; // 0xC
    public int end_; // 0x20

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE865A4BD0
    public void get_Descriptor(){} // RVA: 0x7FFE865A4C30
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE865A4CB0
    public void .ctor(){} // RVA: 0x7FFE8659DE80 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE865A4D60
    public void get_Start(){} // RVA: 0x7FFE865A4E80
    public void set_Start(){} // RVA: 0x7FFE8659D0A0
    public void get_HasStart(){} // RVA: 0x7FFE8659D0B0
    public void ClearStart(){} // RVA: 0x7FFE8659D0C0
    public void get_End(){} // RVA: 0x7FFE865A4EF0
    public void set_End(){} // RVA: 0x7FFE8659D140
    public void get_HasEnd(){} // RVA: 0x7FFE8659D150
    public void ClearEnd(){} // RVA: 0x7FFE8659D160
    public void Equals(){} // RVA: 0x7FFE865A5050 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE865A5110
    public void ToString(){} // RVA: 0x7FFE865A5180
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE865A51D0
    public void CalculateSize(){} // RVA: 0x7FFE865A5260
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8659E650
    public void .cctor(){} // RVA: 0x7FFE865A5440
}

public class EnumResult : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE86A259C0
    public void SetFailure(){} // RVA: 0x7FFE86A25BF0 | overloaded x3
    public void GetEnumParseException(){} // RVA: 0x7FFE86A25CF0
}

public class EnumerableDictionaryWrapper`2 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
}

public class EnumerableDropIndices : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
}

public class Enumerator : ValueType
{
    public System.Collections.Generic.List`1<UnityEngine.InputSystem.Controls.ButtonControl> _list; // 0x10
    public int _index; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83BA0E50
    public void Dispose(){} // RVA: 0x7FFE810FB310
    public void MoveNext(){} // RVA: 0x7FFE83BB3070
    public void MoveNextRare(){} // RVA: 0x7FFE83BA0F70
    public void get_Current(){} // RVA: 0x7FFE81116380
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE83BB8550
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE83BA1040
}

public class EnumeratorDropIndices : Object
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<long,T>> _source;
    public object field_1; // 0x861

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void Reset(){} // RVA: 0x7FFE80E45FE0
}

public class EnumeratorObject : Object
{
    public System.Collections.Generic.IEnumerator`1<T> s_EmptyEnumerator;
    public T[] _array;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void Create(){} // RVA: 0x7FFE80E2E3D0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class EnumeratorPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<EnumeratorPromise> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE87826870
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE87826B10
    public void GetResult(){} // RVA: 0x7FFE87826DD0
    public void GetStatus(){} // RVA: 0x7FFE87826E70
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87826EC0
    public void OnCompleted(){} // RVA: 0x7FFE87826F00
    public void MoveNext(){} // RVA: 0x7FFE87826F80
    public void TryReturn(){} // RVA: 0x7FFE87827150
    public void ConsumeEnumerator(){} // RVA: 0x7FFE87827240
    public void UnwrapWaitForSeconds(){} // RVA: 0x7FFE878272E0
    public void UnwrapWaitAsyncOperation(){} // RVA: 0x7FFE87827380
}

public class EnvelopeDefinition : ValueType
{
    public UnityEngine.AnimationCurve m_AttackShape; // 0x10

    // ── Methods ──
    public void Default(){} // RVA: 0x7FFE82AC1DD0
    public void get_Duration(){} // RVA: 0x7FFE82AC1DF0
    public void GetValueAt(){} // RVA: 0x7FFE82AC1E10
    public void ChangeStopTime(){} // RVA: 0x7FFE82AC1F60
    public void Clear(){} // RVA: 0x7FFE82AC1F90
    public void Validate(){} // RVA: 0x7FFE82AC2050
}

public class EqualBoolean : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155070
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualBooleanLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155C40
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualByte : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155610
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualByteLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871562A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualChar : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155340
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualCharLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155F70
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualDouble : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155AD0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualDoubleLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87156810
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualInt16 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155250
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualInt16LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155E60
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualInt32 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155430
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualInt32LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87156080
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualInt64 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155520
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualInt64LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87156190
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualReference : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155BD0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualSByte : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155160
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualSByteLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155D50
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualSingle : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871559D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualSingleLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871566E0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualUInt16 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87155700
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualUInt16LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871563B0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualUInt32 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871557F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualUInt32LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871564C0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualUInt64 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871558E0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualUInt64LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871565D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE873ED860
    public void GetHashCode(){} // RVA: 0x7FFE873EDAF0
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void <Equals>g__CompareLists|0_0(){} // RVA: 0x7FFE80E2F7A0
    public void <GetHashCode>g__AddListHashCode|1_0(){} // RVA: 0x7FFE80E462E0
    public void <GetHashCode>g__AddHashCode|1_1(){} // RVA: 0x7FFE810A1420
}

public class EqualityWeakReference : WeakReference
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE877F24D0
    public void Equals(){} // RVA: 0x7FFE877F2530
    public void GetHashCode(){} // RVA: 0x7FFE8151D690
}

public class EqualsClass : NullableMethodCallInstruction
{
    // ── Methods ──
    public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
    public void Run(){} // RVA: 0x7FFE87196B40
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Error : ValueType
{
}

public class ErrorDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811EC370
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class ErrorEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class ErrorHandlerDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE3B20
    public void Invoke(){} // RVA: 0x7FFE81998A70
    public void BeginInvoke(){} // RVA: 0x7FFE86DB9C30
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class Escape : ValueType
{
}

public class EscaperImplementation : ScalarEscaperBase
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86E303C0
    public void EncodeUtf8(){} // RVA: 0x7FFE87376C40
    public void EncodeUtf16(){} // RVA: 0x7FFE87376D40
    public void .cctor(){} // RVA: 0x7FFE87376E40
    public void <EncodeUtf8>g__TryEncodeScalarAsHex|4_0(){} // RVA: 0x7FFE87376F90
    public void <EncodeUtf16>g__TryEncodeScalarAsHex|5_0(){} // RVA: 0x7FFE873772B0
}

public class EvaluationState : ValueType
{
}

public class Event : Object
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFE86FDF830
    public void Remove(){} // RVA: 0x7FFE86FDF9E0
    public void Send(){} // RVA: 0x7FFE86FDFB40
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE86FDFC10
}

public class EventData : ValueType
{
    public UIntPtr _dataPointer; // 0x10
    public int _size; // 0x18
    public int _reserved; // 0x1C

    // ── Methods ──
    public void set_DataPointer(){} // RVA: 0x7FFE82889220
    public void set_Size(){} // RVA: 0x7FFE82C33010
    public void set_Reserved(){} // RVA: 0x7FFE82C33030
}

public class EventDataBuffer : ValueType
{
}

public class EventFunction`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
    public void BeginInvoke(){} // RVA: 0x7FFE810A1420
    public void EndInvoke(){} // RVA: 0x7FFE80E460A0
}

public class EventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class EventInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class EventKeyValue : Object
{
    public System.Collections.Generic.List`1<UnityEngine.Timeline.SignalAsset> m_Signals; // 0x10
    public System.Collections.Generic.List`1<UnityEngine.Events.UnityEvent> m_Events; // 0x18

    // ── Methods ──
    public void TryGetValue(){} // RVA: 0x7FFE87B7A0D0
    public void Append(){} // RVA: 0x7FFE87B7A260
    public void Remove(){} // RVA: 0x7FFE87B7A410 | overloaded x2
    public void get_signals(){} // RVA: 0x7FFE81116380
    public void get_events(){} // RVA: 0x7FFE810FE7C0
    public void .ctor(){} // RVA: 0x7FFE87B7A4F0
}

public class EventRecord : ValueType
{
}

public class EventReplicator`2 : MonoBehaviour
{
    public ÏÎÏÎÏÍÎÏÌÏÎÏÍÎÎÎÌÏÍÌÌÏÎ<T,T> _m_CancellationTokenSource;
    public int f_472;
    public int f_22C;
    public int f_1DC;

    // ── Methods ──
    public void OnDestroy(){} // RVA: 0x7FFE80E45FE0
    public void RaiseCancellation(){} // RVA: 0x7FFE80E2F150
    public void IsInvoking(){} // RVA: 0x7FFE80E460A0
    public void CancelInvoke(){} // RVA: 0x7FFE80E460A0
    public void Invoke(){} // RVA: 0x7FFE810A1420
    public void InvokeRepeating(){} // RVA: 0x7FFE80E45FE0
    public void Update(){} // RVA: 0x7FFE80E45FE0
    public void LateUpdate(){} // RVA: 0x7FFE810A1420
    public void StartCoroutine(){} // RVA: 0x7FFE80E2E2E0
    public void OnTriggerStay(){} // RVA: 0x7FFE80E460A0
    public void OnTriggerExit(){} // RVA: 0x7FFE80E2EDB0
    public void StartCoroutine_Auto(){} // RVA: 0x7FFE80E45FE0
    public void StopCoroutine(){} // RVA: 0x7FFE810A1420
    public void OnBecameInvisible(){} // RVA: 0x7FFE80E460A0
    public void OnCollisionEnter(){} // RVA: 0x7FFE80E2F150
    public void StopAllCoroutines(){} // RVA: 0x7FFE80E460A0
    public void get_useGUILayout(){} // RVA: 0x7FFE80E45FE0
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Initialize(){} // RVA: 0x7FFE80E460A0
    public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE80E460A0
    public void Internal_IsInvokingAll(){} // RVA: 0x7FFE80E45FE0
    public void Awake(){} // RVA: 0x7FFE80E45FE0
    public void OnEnable(){} // RVA: 0x7FFE80E2EDB0
    public void Start(){} // RVA: 0x7FFE80E2E2E0
    public void IsObjectMonoBehaviour(){} // RVA: 0x7FFE80E2F150
    public void StartCoroutineManaged(){} // RVA: 0x7FFE80E33B00
    public void StartCoroutineManaged2(){} // RVA: 0x7FFE80E4F230
    public void StopCoroutineManaged(){} // RVA: 0x7FFE80E2F150
    public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFE80E45FE0
    public void GetScriptClassName(){} // RVA: 0x7FFE80E45FE0
}

public class EventSystemChecker : MonoBehaviour
{
    // ── Methods ──
    public void Awake(){} // RVA: 0x7FFE810FBDA0
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class Event`1 : UnityEvent`1
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFE80E460A0
    public void Remove(){} // RVA: 0x7FFE80E460A0
    public void Send(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class Event`2 : UnityEvent`2
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFE80E460A0
    public void Remove(){} // RVA: 0x7FFE80E460A0
    public void Send(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class Event`3 : UnityEvent`3
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFE80E460A0
    public void Remove(){} // RVA: 0x7FFE80E460A0
    public void Send(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class EvidenceEnumerator : Object
{
    public System.Collections.IEnumerator currentEnum; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE867AC770
    public void MoveNext(){} // RVA: 0x7FFE867AC870
    public void Reset(){} // RVA: 0x7FFE867AC910
    public void get_Current(){} // RVA: 0x7FFE867ACA50
}

public class ExceptionFromErrorCode : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86808F40
    public void Invoke(){} // RVA: 0x7FFE81998A70
}
