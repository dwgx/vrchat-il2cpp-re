// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 32
// Methods: 88

public class X509CertificateEnumerator : Object
{
    public System.Collections.IEnumerator enumerator; // 0x10
    public object field_1; // 0x17F

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8777F100
    public void get_Current(){} // RVA: 0x7FFE8777F1B0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE8777F250
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFE8777F2A0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE8777F2F0
    public void MoveNext(){} // RVA: 0x7FFE8777F340
}

public class X509CrlEntry : Object
{
    public byte[] sn; // 0x10
    public System.DateTime revocationDate; // 0x18
    public Mono.Security.X509.X509ExtensionCollection extensions; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8670ADC0
    public void get_SerialNumber(){} // RVA: 0x7FFE8670AFC0
    public void get_RevocationDate(){} // RVA: 0x7FFE810FE7C0
    public void get_Extensions(){} // RVA: 0x7FFE811290C0
}

public class XHashtableState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E4D070
    public void Resize(){} // RVA: 0x7FFE80E2E2E0
    public void TryGetValue(){}
    public void TryAdd(){} // RVA: 0x7FFE810A1420
    public void FindEntry(){} // RVA: 0x7FFE810A1420
    public void ComputeHashCode(){} // RVA: 0x7FFE80E37570
}

public class XProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFE87D4E9F0
    public void .ctor(){} // RVA: 0x7FFE87D4EA30
}

public class XRBlitParams : ValueType
{
}

public class XREarlyUpdate : ValueType
{
}

public class XRFixedUpdate : ValueType
{
}

public class XRMirrorViewBlitDesc : ValueType
{
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
}

public class XRUpdate : ValueType
{
}

public class XSODictionaryEnumerator : XSOEnumerator
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE874EBB30
    public void get_Entry(){} // RVA: 0x7FFE874EC0C0
    public void get_Key(){} // RVA: 0x7FFE874EC260
    public void get_Value(){} // RVA: 0x7FFE874EC3F0
}

public class XSOEnumerator : Object
{
    public System.Collections.Generic.List`1<XmlSchemaObjectEntry> entries; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE874EBB30
    public void get_Current(){} // RVA: 0x7FFE874EBBA0
    public void MoveNext(){} // RVA: 0x7FFE874EBDC0
    public void Reset(){} // RVA: 0x7FFE874EC000
}

public class XdrAttributeEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE874D80D0 | overloaded x2
}

public class XdrBeginChildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class XdrBuildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81EE8AB0
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class XdrEndChildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class XdrEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE874D81C0
}

public class XdrInitFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class XmlContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87567060 | overloaded x2
}

public class XmlEvent : ValueType
{
    public 0x665533EC eventType; // 0x10
    public string s1; // 0x18
    public string s2; // 0x20
    public string s3; // 0x28
    public object o; // 0x30

    // ── Methods ──
    public void InitEvent(){} // RVA: 0x7FFE8755FD60 | overloaded x6
    public void get_EventType(){} // RVA: 0x7FFE826F4220
    public void get_String1(){} // RVA: 0x7FFE826F4210
    public void get_String2(){} // RVA: 0x7FFE81116380
    public void get_String3(){} // RVA: 0x7FFE810FE7C0
    public void get_Object(){} // RVA: 0x7FFE811290C0
}

public class XmlNodeIdHashtable : Hashtable
{
    public XmlNodeIdentety _id; // 0x50
    public object field_1; // 0x14D
    public object field_2; // 0x14E
    public object field_3; // 0x14F

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8729D260
    public void get_Item(){} // RVA: 0x7FFE8729D750 | overloaded x4
}

public class XmlNodeIdentety : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void GetHashCode(){} // RVA: 0x7FFE8170B620
    public void Equals(){} // RVA: 0x7FFE8729D080
}

public class XmlSchemaObjectEntry : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8272BDB0
}

public class Xnnpack : Object
{
    public Google.Protobuf.MessageParser`1<Xnnpack> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public int NumThreadsDefaultValue; // 0x8
    public int numThreads_; // 0x1C

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE8662A210
    public void get_Descriptor(){} // RVA: 0x7FFE8662A270
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8662A2F0
    public void .ctor(){} // RVA: 0x7FFE8662A3A0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE8662A490
    public void get_NumThreads(){} // RVA: 0x7FFE8662A5B0
    public void set_NumThreads(){} // RVA: 0x7FFE8659D0A0
    public void get_HasNumThreads(){} // RVA: 0x7FFE8659D0B0
    public void ClearNumThreads(){} // RVA: 0x7FFE8659D0C0
    public void Equals(){} // RVA: 0x7FFE8662A700 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE8662A790
    public void ToString(){} // RVA: 0x7FFE8662A7F0
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8662A840
    public void CalculateSize(){} // RVA: 0x7FFE8662A8A0
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8662AA30
    public void .cctor(){} // RVA: 0x7FFE8662AAC0
}

public class XsdAttributeEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A53990
}

public class XsdBuildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
}

public class XsdEndChildFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81156B80
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class XsdEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8753BEF0
}

public class XsdInitFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82B9EE00
    public void Invoke(){} // RVA: 0x7FFE81257370
}
