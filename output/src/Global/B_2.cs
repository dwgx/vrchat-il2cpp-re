// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 23
// Methods: 82

public class Buffer : MemoryStream
{
    // ── Methods ──
    public void GenerateSignature(){} // RVA: 0x7FFACBB72D10
    public void VerifySignature(){} // RVA: 0x7FFACBB72F80
    public void Reset(){} // RVA: 0x7FFACBB73250
    public void .ctor(){} // RVA: 0x7FFACBB2A930
}

public class BufferChunk : Object
{
    public char[] buffer; // 0x10
    public int index; // 0x18
    public int count; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7DCAE30
}

public class BufferState : ValueType
{
    public int _pos; // 0x10
    public uint _bitBuf; // 0x14
    public int _bitCount; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC721A020
}

public class BufferedAsyncEnumerable : Object
{
    public System.Collections.Generic.List`1<T> _buffer;

    // ── Methods ──
    public void GetAsyncEnumerator(){}
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class BufferedAudioStream : Object
{
    public bool VerboseLogging;
    public UnityEngine.AudioSource audio; // 0x10
    public float[] audioBuffer; // 0x18
    public int writePos; // 0x20
    public float bufferLengthSeconds;
    public int sampleRate;
    public int bufferSize;
    public float playbackDelayTimeSeconds;
    public float playbackDelayRemaining; // 0x24
    public float remainingBufferTime; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC88184F0
    public void Update(){} // RVA: 0x7FFAC88186E0
    public void Stop(){} // RVA: 0x7FFAC88188D0
    public void AddData(){} // RVA: 0x7FFAC88189A0
}

public class BufferedBerOctetStream : BaseOutputStream
{
    public byte[] _buf; // 0x30
    public int _off; // 0x38
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.BerOctetStringGenerator _gen; // 0x40
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerOutputStream _derOut; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBCD9FF0
    public void WriteByte(){} // RVA: 0x7FFACBCDA1E0
    public void Write(){} // RVA: 0x7FFACBCDA2C0
    public void Close(){} // RVA: 0x7FFACBCDA400
}

public class BufferedCipherWrapper : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher AlgorithmName; // 0x10
    public bool forWrapping; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void get_AlgorithmName(){} // RVA: 0x7FFACBF7BEC0
    public void Init(){} // RVA: 0x7FFACBF7BF10
    public void Wrap(){} // RVA: 0x7FFACBF7BF90
    public void Unwrap(){} // RVA: 0x7FFACBF7C060
}

public class BufferedStreamContent : StreamContent
{
    public long ContentLength; // 0x58

    // ── Methods ──
    public void get_ContentLength(){} // RVA: 0x7FFAC2FE9500
    public void .ctor(){} // RVA: 0x7FFAC8BBFBB0
    public void TryComputeLength(){} // RVA: 0x7FFAC8BBFF20
}

public class BuildEvent : ValueType
{
    public string buildGuid; // 0x10
    public string buildTarget; // 0x18
    public string buildTargetGroup; // 0x20
    public string[] assigned_loaders; // 0x28
}

public class BuildProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC99A7510
    public void get_Name(){} // RVA: 0x7FFAC99A75C0
}

public class Builder : Object
{
    public T[] Capacity;
    public int Count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void get_Capacity(){} // RVA: 0x7FFAC2C59960
    public void get_Count(){} // RVA: 0x7FFAC2C59960
    public void set_Count(){} // RVA: 0x7FFAC2C70ED0
    public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFAC2C709B0
    public void get_Item(){} // RVA: 0x7FFAC2E8DC40
    public void set_Item(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
    public void MoveToImmutable(){} // RVA: 0x7FFAC2E8DC40
    public void Clear(){} // RVA: 0x7FFAC2C70980
    public void Insert(){} // RVA: 0x7FFAC2E8DC40
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void Remove(){} // RVA: 0x7FFAC2E8DC40
    public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
    public void Contains(){} // RVA: 0x7FFAC2E8DC40
    public void CopyTo(){} // RVA: 0x7FFAC2C77970
    public void EnsureCapacity(){} // RVA: 0x7FFAC2C70ED0
    public void IndexOf(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class BuilderNamespaceManager : XmlNamespaceManager
{
    public System.Xml.XmlNamespaceManager nsMgr; // 0x50
    public System.Xml.XmlReader reader; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC91938C0
    public void LookupNamespace(){} // RVA: 0x7FFAC9193970
}

public class BuiltInUriParser : UriParser
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9391540
}

public class BunchesInformation : Object
{
    public byte code; // 0x10
    public int sender; // 0x14
    public int currentBunchesTime; // 0x18
    public System.Collections.Generic.Dictionary`2<byte,byte[]> receivedBunches; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9DEFCF0
}

public class Burst : ValueType
{
    public float time; // 0x10
    public MinMaxCurve count; // 0x18
    public int minCount; // 0x38
    public float maxCount; // 0x3C
    public float cycleCount; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC99509D0 | overloaded x5
    public void get_time(){} // RVA: 0x7FFAC2F44D20
    public void set_time(){} // RVA: 0x7FFAC4A9B910
    public void get_count(){} // RVA: 0x7FFAC9950A50
    public void set_count(){} // RVA: 0x7FFAC9950A70
    public void get_minCount(){} // RVA: 0x7FFAC9950AD0
    public void set_minCount(){} // RVA: 0x7FFAC9950AE0
    public void get_maxCount(){} // RVA: 0x7FFAC9950AF0
    public void set_maxCount(){} // RVA: 0x7FFAC9950B00
    public void get_cycleCount(){} // RVA: 0x7FFAC9950B10
    public void set_cycleCount(){} // RVA: 0x7FFAC9950B20
    public void get_repeatInterval(){} // RVA: 0x7FFAC993FB10
    public void set_repeatInterval(){} // RVA: 0x7FFAC9950BD0
    public void get_probability(){} // RVA: 0x7FFAC9950C80
    public void set_probability(){} // RVA: 0x7FFAC9950C90
}

public class BurstCompilerHelper : Object
{
    public IsBurstEnabledDelegate IsBurstEnabledImpl;
    public bool IsBurstGenerated; // 0x8

    // ── Methods ──
    public void IsBurstEnabled(){} // RVA: 0x7FFAC9506440
    public void DiscardedMethod(){} // RVA: 0x7FFAC49BD6A0
    public void IsCompiledByBurst(){} // RVA: 0x7FFAC9506490
    public void .cctor(){} // RVA: 0x7FFAC9506570
    public void IsBurstEnabled$BurstManaged(){} // RVA: 0x7FFAC95067F0
}

public class Button : ValueType
{
    public UnityEngine.UI.RawImage icon; // 0x10
    public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ text; // 0x18
    public string previousText; // 0x20
}

public class ButtonClickStatus : Object
{
    public UnityEngine.UIElements.VisualElement m_Target; // 0x10
    public UnityEngine.Vector3 m_PointerDownPosition; // 0x18
    public long m_LastPointerDownTime; // 0x28
    public int m_ClickCount; // 0x30

    // ── Methods ──
    public void Reset(){} // RVA: 0x7FFAC9A83A50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class ButtonClickedEvent : UnityEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4854470
}

public class ButtonState : Object
{
    public float scale; // 0x10
    public UnityEngine.Vector2 size; // 0x14
    public UnityEngine.Vector3 offset; // 0x1C
    public float duration; // 0x28
    public 0x6B26C448 ease; // 0x2C
    public float overshoot; // 0x30
    public bool foldout; // 0x34

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC42D7180
}

public class BySubjectFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8977AB0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class ByteArrayUnion : ValueType
{
    public byte[] UnderlyingArray; // 0x10
    public System.Collections.Immutable.ImmutableArray`1<byte> ImmutableArray; // 0x10
}

public class bucket : ValueType
{
    public object key; // 0x10
    public object val; // 0x18
    public int hash_coll; // 0x20
}
