// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 32
// Methods: 88

public class X509CertificateEnumerator : Object
{
    public System.Collections.IEnumerator Current; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC93D69D0
    public void get_Current(){} // RVA: 0x7FFAC93D6A80
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC93D6B20
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAC93D6B70
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC93D6BC0
    public void MoveNext(){} // RVA: 0x7FFAC93D6C10
}

public class X509CrlEntry : Object
{
    public byte[] SerialNumber; // 0x10
    public System.DateTime RevocationDate; // 0x18
    public Mono.Security.X509.X509ExtensionCollection Extensions; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83614C0
    public void get_SerialNumber(){} // RVA: 0x7FFAC83616C0
    public void get_RevocationDate(){} // RVA: 0x7FFAC2F247C0
    public void get_Extensions(){} // RVA: 0x7FFAC2F4F0C0
}

public class XHashtableState : Object
{
    public int[] _buckets;
    public Entry<T>[] _entries;
    public int _numEntries;
    public ExtractKeyDelegate<T> _extractKey;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C77970
    public void Resize(){} // RVA: 0x7FFAC2C58E90
    public void TryGetValue(){}
    public void TryAdd(){} // RVA: 0x7FFAC2E8DC40
    public void FindEntry(){} // RVA: 0x7FFAC2E8DC40
    public void ComputeHashCode(){} // RVA: 0x7FFAC2C62120
}

public class XProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFAC99A6150
    public void .ctor(){} // RVA: 0x7FFAC99A6190
}

public class XRBlitParams : ValueType
{
    public UnityEngine.RenderTexture srcTex; // 0x10
    public int srcTexArraySlice; // 0x18
    public UnityEngine.Rect srcRect; // 0x1C
    public UnityEngine.Rect destRect; // 0x2C
    public UIntPtr foveatedRenderingInfo; // 0x40
    public bool srcHdrEncoded; // 0x48
    public 0x6B17BEC0 srcHdrColorGamut; // 0x4C
    public int srcHdrMaxLuminance; // 0x50
}

public class XREarlyUpdate : ValueType
{
}

public class XRFixedUpdate : ValueType
{
}

public class XRMirrorViewBlitDesc : ValueType
{
    public UIntPtr displaySubsystemInstance; // 0x10
    public bool nativeBlitAvailable; // 0x18
    public bool nativeBlitInvalidStates; // 0x19
    public int blitParamsCount; // 0x1C
}

public class XRPostLateUpdate : ValueType
{
}

public class XRPostPresent : ValueType
{
}

public class XRPreEndFrame : ValueType
{
}

public class XRRenderPass : ValueType
{
    public UIntPtr displaySubsystemInstance; // 0x10
    public int renderPassIndex; // 0x18
    public UnityEngine.Rendering.RenderTargetIdentifier renderTarget; // 0x20
    public UnityEngine.RenderTextureDescriptor renderTargetDesc; // 0x48
    public bool hasMotionVectorPass; // 0x7C
    public UnityEngine.Rendering.RenderTargetIdentifier motionVectorRenderTarget; // 0x80
    public UnityEngine.RenderTextureDescriptor motionVectorRenderTargetDesc; // 0xA8
    public bool shouldFillOutDepth; // 0xDC
    public int cullingPassIndex; // 0xE0
    public UIntPtr foveatedRenderingInfo; // 0xE8
}

public class XRUpdate : ValueType
{
}

public class XSODictionaryEnumerator : XSOEnumerator
{
    public object Entry;
    public object Key;
    public object Value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9143380
    public void get_Entry(){} // RVA: 0x7FFAC9143910
    public void get_Key(){} // RVA: 0x7FFAC9143AB0
    public void get_Value(){} // RVA: 0x7FFAC9143C40
}

public class XSOEnumerator : Object
{
    public System.Collections.Generic.List`1<XmlSchemaObjectEntry> Current; // 0x10
    public 0x6B164AD0 enumType; // 0x18
    public int currentIndex; // 0x1C
    public int size; // 0x20
    public System.Xml.XmlQualifiedName currentKey; // 0x28
    public System.Xml.Schema.XmlSchemaObject currentValue; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9143380
    public void get_Current(){} // RVA: 0x7FFAC91433F0
    public void MoveNext(){} // RVA: 0x7FFAC9143610
    public void Reset(){} // RVA: 0x7FFAC9143850
}

public class XdrAttributeEntry : Object
{
    public 0x6B162D98 _Attribute; // 0x10
    public int _SchemaFlags; // 0x14
    public System.Xml.Schema.XmlSchemaDatatype _Datatype; // 0x18
    public XdrBuildFunction _BuildFunc; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC912F920 | overloaded x2
}

public class XdrBeginChildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class XdrBuildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3C20CE0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class XdrEndChildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class XdrEntry : Object
{
    public 0x6B162D98 _Name; // 0x10
    public int[] _NextStates; // 0x18
    public XdrAttributeEntry[] _Attributes; // 0x20
    public XdrInitFunction _InitFunc; // 0x28
    public XdrBeginChildFunction _BeginChildFunc; // 0x30
    public XdrEndChildFunction _EndChildFunc; // 0x38
    public bool _AllowText; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC912FA10
}

public class XdrInitFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class XmlContext : Object
{
    public 0x6B15A5D0 xmlSpace; // 0x10
    public string xmlLang; // 0x18
    public string defaultNamespace; // 0x20
    public XmlContext previousContext; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC91BE8D0 | overloaded x2
}

public class XmlEvent : ValueType
{
    public 0x6B15A368 EventType; // 0x10
    public string String1; // 0x18
    public string String2; // 0x20
    public string String3; // 0x28
    public object Object; // 0x30

    // ── Methods ──
    public void InitEvent(){} // RVA: 0x7FFAC91B75B0 | overloaded x6
    public void get_EventType(){} // RVA: 0x7FFAC4420210
    public void get_String1(){} // RVA: 0x7FFAC4420220
    public void get_String2(){} // RVA: 0x7FFAC2F3C380
    public void get_String3(){} // RVA: 0x7FFAC2F247C0
    public void get_Object(){} // RVA: 0x7FFAC2F4F0C0
}

public class XmlNodeIdHashtable : Hashtable
{
    public XmlNodeIdentety Item; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8EF4E10
    public void get_Item(){} // RVA: 0x7FFAC8EF5300 | overloaded x4
}

public class XmlNodeIdentety : Object
{
    public string LocalName; // 0x10
    public string NamespaceURI; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    public void Equals(){} // RVA: 0x7FFAC8EF4C30
}

public class XmlSchemaObjectEntry : ValueType
{
    public System.Xml.XmlQualifiedName qname; // 0x10
    public System.Xml.Schema.XmlSchemaObject xso; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC41AE4B0
}

public class Xnnpack : Object
{
    public Google.Protobuf.MessageParser`1<Xnnpack> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int NumThreads; // 0x8
    public int HasNumThreads; // 0x1C

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC82808F0
    public void get_Descriptor(){} // RVA: 0x7FFAC8280950
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82809D0
    public void .ctor(){} // RVA: 0x7FFAC8280A80 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC8280B70
    public void get_NumThreads(){} // RVA: 0x7FFAC8280C90
    public void set_NumThreads(){} // RVA: 0x7FFAC81F3760
    public void get_HasNumThreads(){} // RVA: 0x7FFAC81F3770
    public void ClearNumThreads(){} // RVA: 0x7FFAC81F3780
    public void Equals(){} // RVA: 0x7FFAC8280DE0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC8280E70
    public void ToString(){} // RVA: 0x7FFAC8280ED0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8280F20
    public void CalculateSize(){} // RVA: 0x7FFAC8280F80
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8281110
    public void .cctor(){} // RVA: 0x7FFAC82811A0
}

public class XsdAttributeEntry : Object
{
    public 0x6B162D98 Attribute; // 0x10
    public XsdBuildFunction BuildFunc; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC47EB5F0
}

public class XsdBuildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class XsdEndChildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class XsdEntry : Object
{
    public 0x6B162D98 Name; // 0x10
    public 0x6B165AA0 CurrentState; // 0x14
    public 0x6B165AA0[] NextStates; // 0x18
    public XsdAttributeEntry[] Attributes; // 0x20
    public XsdInitFunction InitFunc; // 0x28
    public XsdEndChildFunction EndChildFunc; // 0x30
    public bool ParseContent; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9193740
}

public class XsdInitFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4935D20
    public void Invoke(){} // RVA: 0x7FFAC307D370
}
