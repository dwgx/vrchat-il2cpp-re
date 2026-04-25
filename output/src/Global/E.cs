// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 420

public class EarlyInitFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class Easing : Object
{
    public 0x6B274168 preset; // 0x10

    // ── Methods ──
    public void GetFunction(){} // RVA: 0x7FFAC47C8200
    public void PowerEaseIn(){} // RVA: 0x7FFAC47C8700
    public void PowerEaseOut(){} // RVA: 0x7FFAC47C8710
    public void PowerEaseInOut(){} // RVA: 0x7FFAC47C8750
    public void Step(){} // RVA: 0x7FFAC47C87D0
    public void Linear(){} // RVA: 0x7FFAC2F21310
    public void InQuad(){} // RVA: 0x7FFAC47C87F0
    public void OutQuad(){} // RVA: 0x7FFAC47C8800
    public void InOutQuad(){} // RVA: 0x7FFAC47C8840
    public void InCubic(){} // RVA: 0x7FFAC47C8850
    public void OutCubic(){} // RVA: 0x7FFAC47C8860
    public void InOutCubic(){} // RVA: 0x7FFAC47C88A0
    public void InQuart(){} // RVA: 0x7FFAC47C88B0
    public void OutQuart(){} // RVA: 0x7FFAC47C88C0
    public void InOutQuart(){} // RVA: 0x7FFAC47C8900
    public void InQuint(){} // RVA: 0x7FFAC47C8910
    public void OutQuint(){} // RVA: 0x7FFAC47C8920
    public void InOutQuint(){} // RVA: 0x7FFAC47C8960
    public void InExpo(){} // RVA: 0x7FFAC47C8970
    public void OutExpo(){} // RVA: 0x7FFAC47C89B0
    public void InOutExpo(){} // RVA: 0x7FFAC47C8A00
    public void .ctor(){} // RVA: 0x7FFAC45B41D0
}

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

public class EditorSettings : Object
{
    public double fps;
    public double frameRate; // 0x8
    public double scenePreview; // 0x10
    public double m_Framerate; // 0x10
    public bool m_ScenePreview; // 0x18

    // ── Methods ──
    public void get_fps(){} // RVA: 0x7FFAC97BC1D0
    public void set_fps(){} // RVA: 0x7FFAC97BC1E0
    public void get_frameRate(){} // RVA: 0x7FFAC5873C20
    public void set_frameRate(){} // RVA: 0x7FFAC97BC290
    public void SetStandardFrameRate(){} // RVA: 0x7FFAC97BC2B0
    public void get_scenePreview(){} // RVA: 0x7FFAC2F3C4E0
    public void set_scenePreview(){} // RVA: 0x7FFAC2F3C4F0
    public void .ctor(){} // RVA: 0x7FFAC97BC5F0
    public void .cctor(){} // RVA: 0x7FFAC97BC660
}

public class EffectorLink : Object
{
    public 0x6B1C0330 effector; // 0x10
    public float weight; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ElemInfo : ValueType
{
    public QName name; // 0x10
    public string xmlLang; // 0x28
    public 0x6B15A5D0 xmlSpace; // 0x30
    public bool xmlspacePreserve; // 0x34
    public NamespaceDecl nsdecls; // 0x38

    // ── Methods ──
    public void Set(){} // RVA: 0x7FFAC9093AE0
    public void Clear(){} // RVA: 0x7FFAC9093BB0
}

public class Element : ValueType
{
    public T Value;
}

public class ElementContent : Object
{
    public System.Xml.Schema.SchemaElementDecl _ElementDecl; // 0x10
    public int _ContentAttr; // 0x18
    public int _OrderAttr; // 0x1C
    public bool _MasterGroupRequired; // 0x20
    public bool _ExistTerminal; // 0x21
    public bool _AllowDataType; // 0x22
    public bool _HasDataType; // 0x23
    public bool _HasType; // 0x24
    public bool _EnumerationRequired; // 0x25
    public uint _MinVal; // 0x28
    public uint _MaxVal; // 0x2C
    public uint _MaxLength; // 0x30
    public uint _MinLength; // 0x34
    public System.Collections.Hashtable _AttDefList; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ElementCount : ValueType
{
    public int uniqueCount;
    public int unfoundCount;
}

public class ElementPropertyPair : ValueType
{
    public System.Collections.Generic.IEqualityComparer`1<ElementPropertyPair> Comparer;
    public UnityEngine.UIElements.VisualElement element; // 0x10
    public 0x6B129770 property; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC335C3C0
    public void .cctor(){} // RVA: 0x7FFAC9C03FA0
}

public class ElementScope : ValueType
{
    public int prevNSTop; // 0x10
    public string prefix; // 0x18
    public string localName; // 0x20
    public string namespaceUri; // 0x28
    public 0x6B15A5D0 xmlSpace; // 0x30
    public string xmlLang; // 0x38

    // ── Methods ──
    public void Set(){} // RVA: 0x7FFAC91D64C0
    public void WriteEndElement(){} // RVA: 0x7FFAC91D6640
    public void WriteFullEndElement(){} // RVA: 0x7FFAC91D6680
}

public class EmailAddress : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8368C20
}

public class Emission : ValueType
{
    public float m_ParticleSpacing; // 0x10
    public float m_ToEmitAccumulator; // 0x14
    public Seed m_Random; // 0x18
}

public class EmissionModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC994A220
    public void set_enabled(){} // RVA: 0x7FFAC994A270
    public void get_rateOverTime(){} // RVA: 0x7FFAC994A2D0
    public void set_rateOverTime(){} // RVA: 0x7FFAC994A340
    public void get_rateOverTimeMultiplier(){} // RVA: 0x7FFAC994A3A0
    public void set_rateOverTimeMultiplier(){} // RVA: 0x7FFAC994A3F0
    public void get_rateOverDistance(){} // RVA: 0x7FFAC994A450
    public void set_rateOverDistance(){} // RVA: 0x7FFAC994A4C0
    public void get_rateOverDistanceMultiplier(){} // RVA: 0x7FFAC994A520
    public void set_rateOverDistanceMultiplier(){} // RVA: 0x7FFAC994A570
    public void SetBursts(){} // RVA: 0x7FFAC994A5F0 | overloaded x2
    public void GetBursts(){} // RVA: 0x7FFAC994A710
    public void SetBurst(){} // RVA: 0x7FFAC994A8B0
    public void GetBurst(){} // RVA: 0x7FFAC994A920
    public void get_burstCount(){} // RVA: 0x7FFAC994A9B0
    public void set_burstCount(){} // RVA: 0x7FFAC994AA00
    public void get_enabled_Injected(){} // RVA: 0x7FFAC994A220
    public void set_enabled_Injected(){} // RVA: 0x7FFAC994A270
    public void get_rateOverTime_Injected(){} // RVA: 0x7FFAC994AA60
    public void set_rateOverTime_Injected(){} // RVA: 0x7FFAC994AAC0
    public void get_rateOverTimeMultiplier_Injected(){} // RVA: 0x7FFAC994A3A0
    public void set_rateOverTimeMultiplier_Injected(){} // RVA: 0x7FFAC994A3F0
    public void get_rateOverDistance_Injected(){} // RVA: 0x7FFAC994AB20
    public void set_rateOverDistance_Injected(){} // RVA: 0x7FFAC994AB80
    public void get_rateOverDistanceMultiplier_Injected(){} // RVA: 0x7FFAC994A520
    public void set_rateOverDistanceMultiplier_Injected(){} // RVA: 0x7FFAC994A570
    public void SetBurst_Injected(){} // RVA: 0x7FFAC994ABE0
    public void GetBurst_Injected(){} // RVA: 0x7FFAC994AC50
    public void get_burstCount_Injected(){} // RVA: 0x7FFAC994A9B0
    public void set_burstCount_Injected(){} // RVA: 0x7FFAC994AA00
}

public class EmitParams : ValueType
{
    public Particle particle; // 0x10
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
    public void get_particle(){} // RVA: 0x7FFAC9951AA0
    public void set_particle(){} // RVA: 0x7FFAC9951AF0
    public void get_position(){} // RVA: 0x7FFAC9951B60
    public void set_position(){} // RVA: 0x7FFAC9951B80
    public void get_applyShapeToPosition(){} // RVA: 0x7FFAC9951BA0
    public void set_applyShapeToPosition(){} // RVA: 0x7FFAC3E068E0
    public void get_velocity(){} // RVA: 0x7FFAC9951BB0
    public void set_velocity(){} // RVA: 0x7FFAC9951BD0
    public void get_startLifetime(){} // RVA: 0x7FFAC9950320
    public void set_startLifetime(){} // RVA: 0x7FFAC9951BF0
    public void get_startSize(){} // RVA: 0x7FFAC9950370
    public void set_startSize(){} // RVA: 0x7FFAC9951C00
    public void get_startSize3D(){} // RVA: 0x7FFAC9951C20
    public void set_startSize3D(){} // RVA: 0x7FFAC9951C40
    public void get_axisOfRotation(){} // RVA: 0x7FFAC9951C60
    public void set_axisOfRotation(){} // RVA: 0x7FFAC9951C80
    public void get_rotation(){} // RVA: 0x7FFAC99503E0
    public void set_rotation(){} // RVA: 0x7FFAC9951CA0
    public void get_rotation3D(){} // RVA: 0x7FFAC9950410
    public void set_rotation3D(){} // RVA: 0x7FFAC9951CD0
    public void get_angularVelocity(){} // RVA: 0x7FFAC9950490
    public void set_angularVelocity(){} // RVA: 0x7FFAC9951D20
    public void get_angularVelocity3D(){} // RVA: 0x7FFAC99504C0
    public void set_angularVelocity3D(){} // RVA: 0x7FFAC9951D50
    public void get_startColor(){} // RVA: 0x7FFAC9950330
    public void set_startColor(){} // RVA: 0x7FFAC9951DA0
    public void get_randomSeed(){} // RVA: 0x7FFAC9950340
    public void set_randomSeed(){} // RVA: 0x7FFAC9951DB0
    public void set_meshIndex(){} // RVA: 0x7FFAC9951DC0
    public void ResetPosition(){} // RVA: 0x7FFAC44D7E60
    public void ResetVelocity(){} // RVA: 0x7FFAC9951DE0
    public void ResetAxisOfRotation(){} // RVA: 0x7FFAC9951DF0
    public void ResetRotation(){} // RVA: 0x7FFAC9951E00
    public void ResetAngularVelocity(){} // RVA: 0x7FFAC9951E10
    public void ResetStartSize(){} // RVA: 0x7FFAC9951E20
    public void ResetStartColor(){} // RVA: 0x7FFAC9951E30
    public void ResetRandomSeed(){} // RVA: 0x7FFAC9951E40
    public void ResetStartLifetime(){} // RVA: 0x7FFAC9951E50
    public void ResetMeshIndex(){} // RVA: 0x7FFAC9951E60
}

public class EmojiMap : MonoBehaviour
{
    public UnityEngine.Animator Animator; // 0x20
    public float Duration; // 0x28
    public UnityEngine.Vector3 PreviewCameraOffset; // 0x2C
    public float PreviewSpeed; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E5DBE0
}

public class EmojiParticleSystem : Object
{
    public VRC.Localization.LocalizableString Key; // 0x10
    public string DisplayName; // 0x38

    // ── Methods ──
    public void GetSessionId(){} // RVA: 0x7FFAC31D0140
    public void get_Key(){} // RVA: 0x7FFAC43BAEF0
    public void get_PrefabName(){} // RVA: 0x7FFAC31D0140
    public void set_PrefabName(){} // RVA: 0x7FFAC31D0140
    public void CompareBaseObjects(){} // RVA: 0x7FFAC3813C20
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC43BAF80
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void get_DisplayName(){} // RVA: 0x7FFAC3813C20
    public void set_DisplayName(){} // RVA: 0x7FFAC3813C20
    public void Instantiate(){} // RVA: 0x7FFAC31D0140
    public void Equals(){} // RVA: 0x7FFAC3813C20
    public void GetHashCode(){} // RVA: 0x7FFAC43BB010
}

public class EmptyAOTEmittedFormatter`1 : AOTEmittedFormatter`1
{
    // ── Methods ──
    public void ReadDataEntry(){}
    public void WriteDataEntries(){} // RVA: 0x7FFAC2C79B30
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class EmptyArrayContainer`1 : Object
{
    public T[] Empty;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class EmptyCustomTypeDescriptor : CustomTypeDescriptor
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EmptyData : ValueType
{
    public EmptyData<T> Default;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class EmptyInternalEnumerator`1 : Object
{
    public EmptyInternalEnumerator`1<T> Current;

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class EmptyParticle : XmlSchemaParticle
{
    public object IsEmpty;

    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0x7FFAC3006850
    public void .ctor(){} // RVA: 0x7FFAC9145020
}

public class EmptyStream : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92B29C0
}

public class Encoder : EncoderNLS
{
    public int HasState; // 0x38
    public int bitCount; // 0x3C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83E6D00
    public void Reset(){} // RVA: 0x7FFAC83E6D10
    public void get_HasState(){} // RVA: 0x7FFAC83E6D40
}

public class EncodingByteBuffer : Object
{
    public byte* MoreData; // 0x10
    public byte* CharsUsed; // 0x18
    public byte* Count; // 0x20
    public char* chars; // 0x28
    public char* charStart; // 0x30
    public char* charEnd; // 0x38
    public int byteCountResult; // 0x40
    public System.Text.Encoding enc; // 0x48
    public System.Text.EncoderNLS encoder; // 0x50
    public System.Text.EncoderFallbackBuffer fallbackBuffer; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83F6310
    public void AddByte(){} // RVA: 0x7FFAC83F6860 | overloaded x4
    public void MovePrevious(){} // RVA: 0x7FFAC83F68C0
    public void get_MoreData(){} // RVA: 0x7FFAC83F69B0
    public void GetNextChar(){} // RVA: 0x7FFAC83F6A00
    public void get_CharsUsed(){} // RVA: 0x7FFAC83F6A80
    public void get_Count(){} // RVA: 0x7FFAC2FC2080
}

public class EncodingCharBuffer : Object
{
    public char* MoreData; // 0x10
    public char* BytesUsed; // 0x18
    public char* Count; // 0x20
    public int charCountResult; // 0x28
    public System.Text.Encoding enc; // 0x30
    public System.Text.DecoderNLS decoder; // 0x38
    public byte* byteStart; // 0x40
    public byte* byteEnd; // 0x48
    public byte* bytes; // 0x50
    public System.Text.DecoderFallbackBuffer fallbackBuffer; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83F5D10
    public void AddChar(){} // RVA: 0x7FFAC83F5FF0 | overloaded x2
    public void AdjustBytes(){} // RVA: 0x7FFAC83F60D0
    public void get_MoreData(){} // RVA: 0x7FFAC83F60E0
    public void GetNextByte(){} // RVA: 0x7FFAC83F60F0
    public void get_BytesUsed(){} // RVA: 0x7FFAC83F6110
    public void Fallback(){} // RVA: 0x7FFAC83F61A0 | overloaded x2
    public void get_Count(){} // RVA: 0x7FFAC32EC4C0
}

public class EncodingUtility : Object
{
    public System.Collections.Generic.KeyValuePair`2<byte[],System.Text.Encoding>[] encodingLookup;
    public System.Text.Encoding targetEncoding; // 0x8

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC98C5020
}

public class Encoding_GetString : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8A802F0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class EncryptedData : Object
{
    public byte EncryptionAlgorithm; // 0x10
    public ContentInfo EncryptedContent; // 0x18
    public ContentInfo _encryptionAlgorithm; // 0x20
    public byte[] _encrypted; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83510D0 | overloaded x2
    public void get_EncryptionAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
    public void get_EncryptedContent(){} // RVA: 0x7FFAC83514D0
}

public class EncryptedPrivateKeyInfo : Object
{
    public string Algorithm; // 0x10
    public byte[] EncryptedData; // 0x18
    public int Salt; // 0x20
    public byte[] IterationCount; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83792C0 | overloaded x2
    public void get_Algorithm(){} // RVA: 0x7FFAC2F3C380
    public void set_Algorithm(){} // RVA: 0x7FFAC2F22E30
    public void get_EncryptedData(){} // RVA: 0x7FFAC83792D0
    public void set_EncryptedData(){} // RVA: 0x7FFAC8379350
    public void get_Salt(){} // RVA: 0x7FFAC8379430
    public void get_IterationCount(){} // RVA: 0x7FFAC30DBBE0
    public void set_IterationCount(){} // RVA: 0x7FFAC8379540
    public void Decode(){} // RVA: 0x7FFAC83795C0
    public void GetBytes(){} // RVA: 0x7FFAC8379980
}

public class EndEditEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C477D0
}

public class EndGraphicsJobsAfterScriptLateUpdate : ValueType
{
}

public class EndGraphicsJobsAfterScriptUpdate : ValueType
{
}

public class EndpointAccessEntry : Object
{
    public float time; // 0x10
    public int count; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EnlightenRuntimeUpdate : ValueType
{
}

public class EnterStateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5C4D540
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class Entries : Object
{
    public Entry[] entries; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Entry : Object
{
    public string Value; // 0x10
    public int HashCode; // 0x18
    public Entry Next; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86E9F50
}

public class EnumFlagAttribute : PropertyAttribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EnumMapMember : Object
{
    public string XmlName; // 0x10
    public string EnumName; // 0x18
    public long Value; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC92653B0
    public void get_XmlName(){} // RVA: 0x7FFAC2F3C380
    public void get_EnumName(){} // RVA: 0x7FFAC2F247C0
    public void get_Value(){} // RVA: 0x7FFAC2F4F0C0
}

public class EnumReservedRange : Object
{
    public Google.Protobuf.MessageParser`1<EnumReservedRange> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Start; // 0x8
    public int HasStart; // 0x1C
    public int End; // 0xC
    public int HasEnd; // 0x20

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC81FB290
    public void get_Descriptor(){} // RVA: 0x7FFAC81FB2F0
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81FB370
    public void .ctor(){} // RVA: 0x7FFAC81F4540 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC81FB420
    public void get_Start(){} // RVA: 0x7FFAC81FB540
    public void set_Start(){} // RVA: 0x7FFAC81F3760
    public void get_HasStart(){} // RVA: 0x7FFAC81F3770
    public void ClearStart(){} // RVA: 0x7FFAC81F3780
    public void get_End(){} // RVA: 0x7FFAC81FB5B0
    public void set_End(){} // RVA: 0x7FFAC81F3800
    public void get_HasEnd(){} // RVA: 0x7FFAC81F3810
    public void ClearEnd(){} // RVA: 0x7FFAC81F3820
    public void Equals(){} // RVA: 0x7FFAC81FB710 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC81FB7D0
    public void ToString(){} // RVA: 0x7FFAC81FB840
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81FB890
    public void CalculateSize(){} // RVA: 0x7FFAC81FB920
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81F4D10
    public void .cctor(){} // RVA: 0x7FFAC81FBB00
}

public class EnumResult : ValueType
{
    public object parsedEnum; // 0x10
    public bool canThrow; // 0x18
    public 0x6B0C2F68 m_failure; // 0x1C
    public string m_failureMessageID; // 0x20
    public string m_failureParameter; // 0x28
    public object m_failureMessageFormatArgument; // 0x30
    public System.Exception m_innerException; // 0x38

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC867C1D0
    public void SetFailure(){} // RVA: 0x7FFAC867C400 | overloaded x3
    public void GetEnumParseException(){} // RVA: 0x7FFAC867C500
}

public class EnumerableDictionaryWrapper`2 : Object
{
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<U,T>> _e;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class EnumerableDropIndices : Object
{
    public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<long,T>> _source;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class Enumerator : ValueType
{
    public ZLogger.LogStates.InterpolatedStringLogState System.Collections.IEnumerator.Current; // 0x10
    public int Current; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC58704C0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFACC0EF6C0
    public void MoveNext(){} // RVA: 0x7FFAC5870560
    public void Reset(){} // RVA: 0x7FFAC589EAA0
    public void get_Current(){} // RVA: 0x7FFACC0EF720
    public void Dispose(){} // RVA: 0x7FFAC2F21310
}

public class EnumeratorDropIndices : Object
{
    public System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<long,T>> Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void Reset(){} // RVA: 0x7FFAC2C70980
}

public class EnumeratorObject : Object
{
    public System.Collections.Generic.IEnumerator`1<T> Current;
    public T[] System.Collections.IEnumerator.Current;
    public int _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void Create(){} // RVA: 0x7FFAC2C58F80
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class EnumeratorPromise : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<EnumeratorPromise> NextNode;
    public EnumeratorPromise nextNode; // 0x10
    public System.Collections.IEnumerator innerEnumerator; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x20
    public int initialFrame; // 0x28
    public bool loopRunning; // 0x2C
    public bool calledGetResult; // 0x2D
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<object> core; // 0x30
    public System.Reflection.FieldInfo waitForSeconds_Seconds; // 0x10

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC947E130
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC947E3D0
    public void GetResult(){} // RVA: 0x7FFAC947E690
    public void GetStatus(){} // RVA: 0x7FFAC947E730
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC947E780
    public void OnCompleted(){} // RVA: 0x7FFAC947E7C0
    public void MoveNext(){} // RVA: 0x7FFAC947E840
    public void TryReturn(){} // RVA: 0x7FFAC947EA10
    public void ConsumeEnumerator(){} // RVA: 0x7FFAC947EB00
    public void UnwrapWaitForSeconds(){} // RVA: 0x7FFAC947EBA0
    public void UnwrapWaitAsyncOperation(){} // RVA: 0x7FFAC947EC40
}

public class EnvelopeDefinition : ValueType
{
    public UnityEngine.AnimationCurve Duration; // 0x10
    public UnityEngine.AnimationCurve m_DecayShape; // 0x18
    public float m_AttackTime; // 0x20
    public float m_SustainTime; // 0x24
    public float m_DecayTime; // 0x28
    public bool m_ScaleWithImpact; // 0x2C
    public bool m_HoldForever; // 0x2D

    // ── Methods ──
    public void Default(){} // RVA: 0x7FFAC4859A30
    public void get_Duration(){} // RVA: 0x7FFAC4859A50
    public void GetValueAt(){} // RVA: 0x7FFAC4859A70
    public void ChangeStopTime(){} // RVA: 0x7FFAC4859BC0
    public void Clear(){} // RVA: 0x7FFAC4859BF0
    public void Validate(){} // RVA: 0x7FFAC4859CB0
}

public class EqualBoolean : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DACC40
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualBooleanLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD810
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualByte : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD1E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualByteLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DADE70
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualChar : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DACF10
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualCharLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DADB40
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualDouble : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD6A0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualDoubleLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAE3E0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualInt16 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DACE20
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualInt16LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DADA30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualInt32 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD000
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualInt32LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DADC50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualInt64 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD0F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualInt64LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DADD60
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualReference : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD7A0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualSByte : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DACD30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualSByteLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD920
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualSingle : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD5A0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualSingleLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAE2B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualUInt16 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD2D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualUInt16LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DADF80
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualUInt32 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD3C0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualUInt32LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAE090
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualUInt64 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAD4B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualUInt64LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DAE1A0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC90450B0
    public void GetHashCode(){} // RVA: 0x7FFAC9045340
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void <Equals>g__CompareLists|0_0(){} // RVA: 0x7FFAC2C5A350
    public void <GetHashCode>g__AddListHashCode|1_0(){} // RVA: 0x7FFAC2C70C80
    public void <GetHashCode>g__AddHashCode|1_1(){} // RVA: 0x7FFAC2E8DC40
}

public class EqualityWeakReference : WeakReference
{
    public int _hashCode; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9449D80
    public void Equals(){} // RVA: 0x7FFAC9449DE0
    public void GetHashCode(){} // RVA: 0x7FFAC30DBBE0
}

public class EqualsClass : NullableMethodCallInstruction
{
    public object ConsumedStack;

    // ── Methods ──
    public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
    public void Run(){} // RVA: 0x7FFAC8DEE710
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Error : ValueType
{
    public 0x6B0AC938 Code; // 0x10
    public string Message; // 0x18
}

public class ErrorDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3012370
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class ErrorEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class ErrorHandlerDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4978020
    public void Invoke(){} // RVA: 0x7FFAC383F780
    public void BeginInvoke(){} // RVA: 0x7FFAC8A105B0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
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
    public EscaperImplementation Singleton;
    public EscaperImplementation SingletonMinimallyEscaped; // 0x8
    public System.Text.Encodings.Web.AsciiByteMap _preescapedMap; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8A86D30
    public void EncodeUtf8(){} // RVA: 0x7FFAC8FCE480
    public void EncodeUtf16(){} // RVA: 0x7FFAC8FCE580
    public void .cctor(){} // RVA: 0x7FFAC8FCE680
    public void <EncodeUtf8>g__TryEncodeScalarAsHex|4_0(){} // RVA: 0x7FFAC8FCE7D0
    public void <EncodeUtf16>g__TryEncodeScalarAsHex|5_0(){} // RVA: 0x7FFAC8FCEAF0
}

public class EvaluationState : ValueType
{
    public UnityEngine.MaterialPropertyBlock stateMatProps; // 0x10
    public UnityEngine.Material defaultMat; // 0x18
    public UnityEngine.UIElements.UIR.State curState; // 0x20
    public UnityEngine.UIElements.UIR.Page curPage; // 0x38
    public bool mustApplyMaterial; // 0x40
    public bool mustApplyCommonBlock; // 0x41
    public bool mustApplyStateBlock; // 0x42
    public bool mustApplyStencil; // 0x43
}

public class Event : Object
{
    public System.Collections.Hashtable listeners;

    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFAC8C37310
    public void Remove(){} // RVA: 0x7FFAC8C374C0
    public void Send(){} // RVA: 0x7FFAC8C37620
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC8C376F0
}

public class EventData : ValueType
{
    public UIntPtr DataPointer; // 0x10
    public int Size; // 0x18
    public int Reserved; // 0x1C

    // ── Methods ──
    public void set_DataPointer(){} // RVA: 0x7FFAC45BB120
    public void set_Size(){} // RVA: 0x7FFAC49C7510
    public void set_Reserved(){} // RVA: 0x7FFAC49C7530
}

public class EventDataBuffer : ValueType
{
    public 0x6B1A83E8 EventType; // 0x10
    public byte[] EventData; // 0x18
}

public class EventFunction`1 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    public void BeginInvoke(){} // RVA: 0x7FFAC2E8DC40
    public void EndInvoke(){} // RVA: 0x7FFAC2C70A40
}

public class EventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class EventInfo : Object
{
    public VrcEvent evt; // 0x10
    public 0x6B2517F8 broadcast; // 0x18
    public UnityEngine.GameObject instagator; // 0x20
    public float fastForward; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class EventKeyValue : Object
{
    public System.Collections.Generic.List`1<UnityEngine.Timeline.SignalAsset> signals; // 0x10
    public System.Collections.Generic.List`1<UnityEngine.Events.UnityEvent> events; // 0x18

    // ── Methods ──
    public void TryGetValue(){} // RVA: 0x7FFAC97D1B50
    public void Append(){} // RVA: 0x7FFAC97D1CE0
    public void Remove(){} // RVA: 0x7FFAC97D1E90 | overloaded x2
    public void get_signals(){} // RVA: 0x7FFAC2F3C380
    public void get_events(){} // RVA: 0x7FFAC2F247C0
    public void .ctor(){} // RVA: 0x7FFAC97D1F70
}

public class EventRecord : ValueType
{
    public UnityEngine.UIElements.EventBase m_Event; // 0x10
    public UnityEngine.UIElements.IPanel m_Panel; // 0x18
}

public class EventReplicator`2 : MonoBehaviour
{
    public ÍÎÎÍÏÌÎÌÌÎÏÏÌÍÌÎÍÏÍÍÌÍÎ<T,T> _destroyCancellationToken;
    public int _useGUILayout;
    public int f_AAB;
    public int f_9F8;
    public int ÌÌÎÏÏÌÍÌÏÍÎÍÍÍÎÍÍÌÏÍÎÌÍ;
    public System.Collections.Generic.List`1<System.Action> ÎÌÍÍÏÍÍÎÎÏÏÍÏÍÏÍÎÏÍÎÍÍÍ;
    public ÎÏÍÏÍÍÎÍÎÌÍÏÎÎÌÏÌÍÎÏÍÎÍ<T,T> ÏÍÎÌÍÏÌÌÎÎÎÌÌÌÌÌÍÏÌÎÌÌÍ;
    public System.Collections.Generic.HashSet`1<T> ÎÍÏÍÌÍÍÎÎÎÏÎÎÎÏÏÍÎÎÍÏÌÌ;
    public System.Collections.Generic.List`1<T> ÏÏÍÍÏÏÏÍÎÌÌÎÌÏÌÌÏÎÍÍÏÏÍ;
    public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.List`1<T>> ÍÏÎÌÏÎÎÏÏÏÏÌÏÍÎÍÍÌÍÍÎÎÍ;
    public bool ÎÎÎÍÏÎÌÏÏÍÎÎÏÍÌÍÏÏÍÌÎÎÎ;
    public T ÍÎÏÌÏÎÏÍÌÌÌÎÍÎÍÎÍÌÌÍÍÍÎ;
    public System.Collections.Generic.List`1<int> ÏÍÎÍÍÍÎÍÏÍÍÎÏÌÍÎÍÍÍÎÌÍÍ;
    public System.Collections.Generic.List`1<ÏÏÏÍÌÌÍÎÎÍÏÎÍÏÍÎÌÌÌÎÎÌÎ> ÍÎÎÎÏÎÏÌÎÍÍÎÌÍÍÎÍÍÏÌÌÎÏ;
    public System.Collections.Generic.List`1<byte[]> ÌÌÏÌÍÌÎÎÍÌÌÌÏÏÍÎÍÌÌÌÏÌÍ;

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFAC2C70980
    public void RaiseCancellation(){} // RVA: 0x7FFAC2C59D00
    public void IsInvoking(){} // RVA: 0x7FFAC2E8DC40
    public void CancelInvoke(){} // RVA: 0x7FFAC2C70A40
    public void Invoke(){} // RVA: 0x7FFAC2C59D00
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Initialize(){} // RVA: 0x7FFAC2C59D00
    public void WriteValue(){} // RVA: 0x7FFAC2C79B30
    public void StartCoroutine(){} // RVA: 0x7FFAC2C70980
    public void StartCoroutine_Auto(){} // RVA: 0x7FFAC2C59960
    public void ContainsChild(){} // RVA: 0x7FFAC2C70A40
    public void StartCoroutine_Auto_89FFABA90D39(){} // RVA: 0x7FFAC2C59960
    public void StopCoroutine(){} // RVA: 0x7FFAC2C70A40
    public void StopCoroutine_C7ED6DFD8918(){} // RVA: 0x7FFAC2C70980
    public void OnEnable(){} // RVA: 0x7FFAC2C70A40
    public void StopAllCoroutines(){} // RVA: 0x7FFAC2C70A40
    public void Awake(){} // RVA: 0x7FFAC2C70980
    public void Update(){} // RVA: 0x7FFAC2C70980
    public void print(){} // RVA: 0x7FFAC2C59D00
    public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC2E8DC40
    public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC2C5E6B0
    public void GetSessionId(){} // RVA: 0x7FFAC2C58E90
    public void OnDisable(){} // RVA: 0x7FFAC2C58E90
    public void OnBecameVisible(){} // RVA: 0x7FFAC2C70A40
    public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC2E8DC40
    public void Start(){} // RVA: 0x7FFAC2C58E90
    public void OnDestroy(){} // RVA: 0x7FFAC2C70980
    public void StopCoroutineManaged(){} // RVA: 0x7FFAC2C59D00
    public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC2C70980
}

public class EventSystemChecker : MonoBehaviour
{
    // ── Methods ──
    public void Awake(){} // RVA: 0x7FFAC2F21DA0
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class Event`1 : UnityEvent`1
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFAC2C70A40
    public void Remove(){} // RVA: 0x7FFAC2C70A40
    public void Send(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class Event`2 : UnityEvent`2
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFAC2C70A40
    public void Remove(){} // RVA: 0x7FFAC2C70A40
    public void Send(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class Event`3 : UnityEvent`3
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x7FFAC2C70A40
    public void Remove(){} // RVA: 0x7FFAC2C70A40
    public void Send(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class EvidenceEnumerator : Object
{
    public System.Collections.IEnumerator Current; // 0x10
    public System.Collections.IEnumerator hostEnum; // 0x18
    public System.Collections.IEnumerator assemblyEnum; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8402E60
    public void MoveNext(){} // RVA: 0x7FFAC8402F60
    public void Reset(){} // RVA: 0x7FFAC8403000
    public void get_Current(){} // RVA: 0x7FFAC8403140
}

public class ExceptionFromErrorCode : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC845F630
    public void Invoke(){} // RVA: 0x7FFAC383F780
}
