// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 25
// Methods: 86

public class Buf24 : ValueType
{
    public uint U0; // 0x10
    public uint U1; // 0x14
    public uint U2; // 0x18

    // ── Methods ──
    public void get_Low64(){} // RVA: 0x7FFE8348B260
    public void set_Low64(){} // RVA: 0x7FFE82889220
    public void set_Mid64(){} // RVA: 0x7FFE82C72B10
    public void set_High64(){} // RVA: 0x7FFE826F2ED0
}

public class Buf28 : ValueType
{
}

public class Buffer : MemoryStream
{
    // ── Methods ──
    public void GenerateSignature(){} // RVA: 0x7FFE89FCC330
    public void VerifySignature(){} // RVA: 0x7FFE89FCC5A0
    public void Reset(){} // RVA: 0x7FFE89FCC870
    public void .ctor(){} // RVA: 0x7FFE89F83F50
}

public class BufferChunk : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE861ED650
}

public class BufferState : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE855D5D40
}

public class BufferedAsyncEnumerable : Object
{
    // ── Methods ──
    public void GetAsyncEnumerator(){}
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class BufferedAudioStream : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86BC1BE0
    public void Update(){} // RVA: 0x7FFE86BC1DD0
    public void Stop(){} // RVA: 0x7FFE86BC1FC0
    public void AddData(){} // RVA: 0x7FFE86BC2090
}

public class BufferedBerOctetStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A133610
    public void WriteByte(){} // RVA: 0x7FFE8A133800
    public void Write(){} // RVA: 0x7FFE8A1338E0
    public void Close(){} // RVA: 0x7FFE8A133A20
}

public class BufferedCipherWrapper : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBufferedCipher cipher; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void get_AlgorithmName(){} // RVA: 0x7FFE8A3DCA30
    public void Init(){} // RVA: 0x7FFE8A3DCA80
    public void Wrap(){} // RVA: 0x7FFE8A3DCB00
    public void Unwrap(){} // RVA: 0x7FFE8A3DCBD0
}

public class BufferedStreamContent : StreamContent
{
    public long _contentLength; // 0x58

    // ── Methods ──
    public void get_ContentLength(){} // RVA: 0x7FFE811C3500
    public void .ctor(){} // RVA: 0x7FFE86F69230
    public void TryComputeLength(){} // RVA: 0x7FFE86F695A0
}

public class BuildEvent : ValueType
{
}

public class BuildProperty : Property`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87D4FDB0
    public void get_Name(){} // RVA: 0x7FFE87D4FE60
}

public class Builder : Object
{
    public T[] _elements;
    public int _count;
    public object field_2; // 0x20
    public object field_3; // 0x21

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E46530
    public void get_Capacity(){} // RVA: 0x7FFE80E2EDB0
    public void get_Count(){} // RVA: 0x7FFE80E2EDB0
    public void set_Count(){} // RVA: 0x7FFE80E46530
    public void ThrowIndexOutOfRangeException(){} // RVA: 0x7FFE80E46010
    public void get_Item(){} // RVA: 0x7FFE810A1420
    public void set_Item(){} // RVA: 0x7FFE810A1420
    public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
    public void MoveToImmutable(){} // RVA: 0x7FFE810A1420
    public void Clear(){} // RVA: 0x7FFE80E45FE0
    public void Insert(){} // RVA: 0x7FFE810A1420
    public void Add(){} // RVA: 0x7FFE810A1420
    public void Remove(){} // RVA: 0x7FFE810A1420
    public void RemoveAt(){} // RVA: 0x7FFE80E46530
    public void Contains(){} // RVA: 0x7FFE810A1420
    public void CopyTo(){} // RVA: 0x7FFE80E4D070
    public void EnsureCapacity(){} // RVA: 0x7FFE80E46530
    public void IndexOf(){} // RVA: 0x7FFE810A1420 | overloaded x2
    public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
}

public class BuilderNamespaceManager : XmlNamespaceManager
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8753C070
    public void LookupNamespace(){} // RVA: 0x7FFE8753C120
}

public class BuiltInUriParser : UriParser
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87739C70
}

public class BunchesInformation : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE88194AA0
}

public class Burst : ValueType
{
    public float m_Time; // 0x10
    public MinMaxCurve m_Count; // 0x18
    public int m_RepeatCount; // 0x38
    public float m_RepeatInterval; // 0x3C
    public float m_InvProbability; // 0x40
    public 0x6668069C m_Mode; // 0x10
    public float m_CurveMultiplier; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87CF9270 | overloaded x5
    public void get_time(){} // RVA: 0x7FFE8111ED20
    public void set_time(){} // RVA: 0x7FFE82D03BB0
    public void get_count(){} // RVA: 0x7FFE87CF92F0
    public void set_count(){} // RVA: 0x7FFE87CF9310
    public void get_minCount(){} // RVA: 0x7FFE87CF9370
    public void set_minCount(){} // RVA: 0x7FFE87CF9380
    public void get_maxCount(){} // RVA: 0x7FFE87CF9390
    public void set_maxCount(){} // RVA: 0x7FFE87CF93A0
    public void get_cycleCount(){} // RVA: 0x7FFE87CF93B0
    public void set_cycleCount(){} // RVA: 0x7FFE87CF93C0
    public void get_repeatInterval(){} // RVA: 0x7FFE87CE83B0
    public void set_repeatInterval(){} // RVA: 0x7FFE87CF9470
    public void get_probability(){} // RVA: 0x7FFE87CF9520
    public void set_probability(){} // RVA: 0x7FFE87CF9530
}

public class BurstCompilerHelper : Object
{
    // ── Methods ──
    public void IsBurstEnabled(){} // RVA: 0x7FFE878AEB80
    public void DiscardedMethod(){} // RVA: 0x7FFE82C291A0
    public void IsCompiledByBurst(){} // RVA: 0x7FFE878AEBD0
    public void .cctor(){} // RVA: 0x7FFE878AECB0
    public void IsBurstEnabled$BurstManaged(){} // RVA: 0x7FFE878AEF30
}

public class Button : ValueType
{
}

public class ButtonClickStatus : Object
{
    // ── Methods ──
    public void Reset(){} // RVA: 0x7FFE87E2C2F0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class ButtonClickedEvent : UnityEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82ABC810
}

public class ButtonState : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE825CEED0
}

public class BySubjectFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D21140
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class ByteArrayUnion : ValueType
{
}

public class bucket : ValueType
{
}
