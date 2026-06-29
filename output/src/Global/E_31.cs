// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 382

public class EarlyInitFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xBA0FE0
    public void Invoke(){} // RVA: 0xBA10B0
}

public class ElementContent : Object
{
    public object _ElementDecl;
    public object _ContentAttr;
    public object _OrderAttr;
    public object _MasterGroupRequired;
    public object _ExistTerminal;
    public object _AllowDataType;
    public object _HasDataType;
    public object _HasType;
    public object _EnumerationRequired;
    public object _MinVal;
    public object _MaxVal;
    public object _MaxLength;
    public object _MinLength;
    public object _AttDefList;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ElementScope : ValueType
{
    public object prevNSTop;
    public object prefix;
    public object localName;
    public object namespaceUri;
    public object xmlSpace;
    public object xmlLang;

    // ── Methods ──
    public void Set(){} // RVA: 0x9160F0
    public void WriteEndElement(){} // RVA: 0x916100
    public void WriteFullEndElement(){} // RVA: 0x916140
}

public class EmailAddress : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x727F240
}

public class EmptyCustomTypeDescriptor : CustomTypeDescriptor
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class EmptyParticle : XmlSchemaParticle
{
    // ── Methods ──
    public void get_IsEmpty(){} // RVA: 0xC2E4C0
    public void .ctor(){} // RVA: 0x7414150
}

public class EmptyStream : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7580140
}

public class EncodingByteBuffer : Object
{
    public object bytes;
    public object byteStart;
    public object byteEnd;
    public object chars;
    public object charStart;
    public object charEnd;
    public object byteCountResult;
    public object enc;
    public object encoder;
    public object fallbackBuffer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66D7640
    public void AddByte(){} // RVA: 0x66D7B90
    public void MovePrevious(){} // RVA: 0x66D7BF0
    public void get_MoreData(){} // RVA: 0x66D7CE0
    public void GetNextChar(){} // RVA: 0x66D7D30
    public void get_CharsUsed(){} // RVA: 0x66D7DB0
    public void get_Count(){} // RVA: 0xBE5850
}

public class EncodingCharBuffer : Object
{
    public object chars;
    public object charStart;
    public object charEnd;
    public object charCountResult;
    public object enc;
    public object decoder;
    public object byteStart;
    public object byteEnd;
    public object bytes;
    public object fallbackBuffer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66D7040
    public void AddChar(){} // RVA: 0x66D7320
    public void AdjustBytes(){} // RVA: 0x66D7400
    public void get_MoreData(){} // RVA: 0x66D7410
    public void GetNextByte(){} // RVA: 0x66D7420
    public void get_BytesUsed(){} // RVA: 0x66D7440
    public void Fallback(){} // RVA: 0x66D74D0
    public void get_Count(){} // RVA: 0x1065D50
}

public class Entry : Object
{
    public object _hash;
    public object _key;
    public object _value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
}

public class Entry[] : Array
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

public class Entry[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E320
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4160
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E345E0
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A900
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class Entry[] : Array
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

public class EnumMapMember : Object
{
    public object _xmlName;
    public object _enumName;
    public object _value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7532C90
    public void get_XmlName(){} // RVA: 0xB5DBF0
    public void get_EnumName(){} // RVA: 0xB465B0
    public void get_Value(){} // RVA: 0xB700F0
}

public class EnumResult : ValueType
{
    public object parsedEnum;
    public object canThrow;
    public object m_failure;
    public object m_failureMessageID;
    public object m_failureParameter;
    public object m_failureMessageFormatArgument;
    public object m_innerException;

    // ── Methods ──
    public void Init(){} // RVA: 0x8BEA10
    public void SetFailure(){} // RVA: 0x8BEA90
    public void GetEnumParseException(){} // RVA: 0x8BEAA0
}

public class Enumerator : ValueType
{
    public object _builder;
    public object _mapEnumerator;
    public object _bucketEnumerator;
    public object _enumeratingBuilderVersion;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943B0
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
    public void Dispose(){} // RVA: 0x894290
    public void ThrowIfChanged(){} // RVA: 0x894290
}

public class Enumerator : ValueType
{
    public object _bucket;
    public object _currentPosition;
    public object _additionalEnumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void get_Current(){} // RVA: 0xA94080
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
    public void Dispose(){} // RVA: 0x894290
}

public class Enumerator : ValueType
{
    public object s_EnumeratingStacks;
    public object _builder;
    public object _poolUserId;
    public object _startIndex;
    public object _count;
    public object _remainingCount;
    public object _reversed;
    public object _root;
    public object _stack;
    public object _current;
    public object _enumeratingBuilderVersion;

    // ── Methods ──
    public void System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId(){} // RVA: 0x87C130
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x894290
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
    public void ResetStack(){} // RVA: 0x894290
    public void NextBranch(){} // RVA: 0x87C540
    public void PreviousBranch(){} // RVA: 0x87C540
    public void ThrowIfDisposed(){} // RVA: 0x894290
    public void ThrowIfChanged(){} // RVA: 0x894290
    public void PushNext(){} // RVA: 0x894320
    public void .cctor(){} // RVA: 0x8942F0
}

public class Enumerator : ValueType
{
    public object s_enumeratingStacks;
    public object _builder;
    public object _poolUserId;
    public object _root;
    public object _stack;
    public object _current;
    public object _enumeratingBuilderVersion;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943B0
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId(){} // RVA: 0x87C130
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x894290
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
    public void ThrowIfDisposed(){} // RVA: 0x894290
    public void ThrowIfChanged(){} // RVA: 0x894290
    public void PushLeft(){} // RVA: 0x894320
    public void .cctor(){} // RVA: 0x8942F0
}

public class Enumerator : ValueType
{
    public object s_enumeratingStacks;
    public object _poolUserId;
    public object _root;
    public object _stack;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.Immutable.ISecurePooledObjectUser.get_PoolUserId(){} // RVA: 0x87C130
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x894290
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
    public void ThrowIfDisposed(){} // RVA: 0x894290
    public void PushLeft(){} // RVA: 0x894320
    public void .cctor(){} // RVA: 0x8942F0
}

public class Enumerator : ValueType
{
    public object _list;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x261000
}

public class Enumerator : ValueType
{
    public object m_Handlers;
    public object m_Count;
    public object m_Index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x96E910
    public void Dispose(){} // RVA: 0x96E920
    public void get_Current(){} // RVA: 0x96E970
    public void MoveNext(){} // RVA: 0x96E980
}

public class Enumerator : ValueType
{
    public object m_HierarchyFlattened;
    public object m_Predicate;
    public object m_Flags;
    public object m_NodesPtr;
    public object m_NodesCount;
    public object m_Version;
    public object m_Index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x96ECD0
    public void get_Current(){} // RVA: 0x96ED00
    public void MoveNext(){} // RVA: 0x96ED30
    public void ThrowIfVersionChanged(){} // RVA: 0x96ED90
}

public class Enumerator : ValueType
{
    public object _list;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x261000
}

public class Enumerator : ValueType
{
    public object _list;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void System.IDisposable.Dispose(){} // RVA: 0x894290
    public void MoveNext(){} // RVA: 0x87D280
    public void MoveNextRare(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x894290
}

public class Enumerator : ValueType
{
    public object _set;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void System.IDisposable.Dispose(){} // RVA: 0x894290
    public void MoveNext(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x894290
}

public class Enumerator : ValueType
{
    public object _array;
    public object _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x268A40
}

public class Enumerator : ValueType
{
    public object _list;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x261000
    public void Dispose(){} // RVA: 0x3FC0
    public void MoveNext(){} // RVA: 0x2738B0
    public void MoveNextRare(){} // RVA: 0x261120
    public void get_Current(){} // RVA: 0x7E450
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x2738C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x2611F0
}

public class Enumerator : ValueType
{
    public object _list;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x261000
    public void Dispose(){} // RVA: 0x3FC0
    public void MoveNext(){} // RVA: 0x2738B0
    public void MoveNextRare(){} // RVA: 0x261120
    public void get_Current(){} // RVA: 0x7E450
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x2738C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x2611F0
}

public class Enumerator : ValueType
{
    public object _list;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x261000
}

public class Enumerator : ValueType
{
    public object _stack;
    public object _version;
    public object _index;
    public object _currentElement;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x263EA0
}

public class Enumerator : ValueType
{
    public object _dictionary;
    public object _version;
    public object _index;
    public object _current;
    public object _getEnumeratorRetType;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2895F0
}

public class Enumerator : Object
{
    public object _collection;
    public object _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67F4370
    public void MoveNext(){} // RVA: 0x765E630
    public void get_Current(){} // RVA: 0x765E670
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x765E670
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x2576860
    public void System.IDisposable.Dispose(){} // RVA: 0xB43310
}

public class Enumerator : Object
{
    public object _collection;
    public object _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67F4370
    public void MoveNext(){} // RVA: 0x765FF40
    public void get_Current(){} // RVA: 0x765FF90
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x765FF90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x2576860
    public void System.IDisposable.Dispose(){} // RVA: 0xB43310
}

public class Enumerator : Object
{
    public object _collection;
    public object _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x67F4370
    public void MoveNext(){} // RVA: 0x7662290
    public void get_Current(){} // RVA: 0x76622E0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x76622E0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x2576860
    public void System.IDisposable.Dispose(){} // RVA: 0xB43310
}

public class Enumerator : ValueType
{
    public object _dictionary;
    public object _version;
    public object _index;
    public object _current;
    public object _getEnumeratorRetType;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2895F0
}

public class Enumerator : ValueType
{
    public object _dictionary;
    public object _version;
    public object _index;
    public object _current;
    public object _getEnumeratorRetType;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2867A0
}

public class Enumerator : Object
{
    public object _array;
    public object _current;
    public object _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void MoveNext(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void Reset(){} // RVA: 0x894290
    public void Dispose(){} // RVA: 0x894290
}

public class Enumerator : ValueType
{
    public object _list;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x261000
}

public class Enumerator : ValueType
{
    public object _dictionary;
    public object _version;
    public object _index;
    public object _current;
    public object _getEnumeratorRetType;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2895F0
}

public class Enumerator : ValueType
{
    public object _list;
    public object _index;
    public object _version;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x261000
    public void Dispose(){} // RVA: 0x3FC0
    public void MoveNext(){} // RVA: 0x2738B0
    public void MoveNextRare(){} // RVA: 0x261120
    public void get_Current(){} // RVA: 0x7E450
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x2738C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x2611F0
}

public class Enumerator : Object
{
    public object _builder;
    public object _version;
    public object _index;
    public object _current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Current(){} // RVA: 0xA94080
    public void Dispose(){} // RVA: 0x894290
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x894290
}

public class Enumerator : ValueType
{
    public object _dictionary;
    public object _version;
    public object _index;
    public object _current;
    public object _getEnumeratorRetType;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2895F0
    public void MoveNext(){} // RVA: 0x297820
    public void get_Current(){} // RVA: 0xD1A70
    public void Dispose(){} // RVA: 0x3FC0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x297830
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x289690
    public void System.Collections.IDictionaryEnumerator.get_Entry(){} // RVA: 0x297840
    public void System.Collections.IDictionaryEnumerator.get_Key(){} // RVA: 0x294590
    public void System.Collections.IDictionaryEnumerator.get_Value(){} // RVA: 0x2897C0
}

public class Enumerator : ValueType
{
    public object _builder;
    public object _mapEnumerator;
    public object _bucketEnumerator;
    public object _enumeratingBuilderVersion;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943B0
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
    public void Dispose(){} // RVA: 0x894290
    public void ThrowIfChanged(){} // RVA: 0x894290
}

public class Enumerator : ValueType
{
    public object _bucket;
    public object _currentPosition;
    public object _additionalEnumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void get_Current(){} // RVA: 0xA94080
    public void MoveNext(){} // RVA: 0x87D280
    public void Reset(){} // RVA: 0x894290
    public void Dispose(){} // RVA: 0x894290
}

public class EnumeratorDropIndices : Object
{
    public object _source;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void MoveNext(){} // RVA: 0x87D280
    public void get_Current(){} // RVA: 0xA94080
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x894290
    public void Reset(){} // RVA: 0x894290
}

public class EnumeratorObject : Object
{
    public object s_EmptyEnumerator;
    public object _array;
    public object _index;

    // ── Methods ──
    public void Create(){} // RVA: 0x39EC990
}

public class EqualBoolean : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083870
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualBooleanLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70842C0
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualByte : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083D50
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualByteLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084860
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualChar : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083AE0
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualCharLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084590
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualDouble : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084170
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualDoubleLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084D30
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualInt16 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083A10
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualInt16LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70844A0
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualInt32 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083BB0
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualInt32LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084680
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualInt64 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083C80
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualInt64LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084770
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualReference : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084250
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualSByte : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083940
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualSByteLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70843B0
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualSingle : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084090
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualSingleLiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084C20
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualUInt16 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083E20
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualUInt16LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084950
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualUInt32 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083EF0
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualUInt32LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084A40
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualUInt64 : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7083FC0
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualUInt64LiftedToNull : EqualInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7084B30
    public void .ctor(){} // RVA: 0xB43310
}

public class EqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x73134C0
    public void GetHashCode(){} // RVA: 0x7313750
    public void .ctor(){} // RVA: 0xB43310
    public void <Equals>g__CompareLists|0_0(){} // RVA: 0x87D880
    public void <GetHashCode>g__AddListHashCode|1_0(){} // RVA: 0x8945C0
    public void <GetHashCode>g__AddHashCode|1_1(){} // RVA: 0xA94080
}

public class EqualityWeakReference : WeakReference
{
    public object _hashCode;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7710130
    public void Equals(){} // RVA: 0x7710190
    public void GetHashCode(){} // RVA: 0xFEAE90
}

public class EqualsClass : NullableMethodCallInstruction
{
    // ── Methods ──
    public void get_ConsumedStack(){} // RVA: 0xC50A80
    public void Run(){} // RVA: 0x70C3070
    public void .ctor(){} // RVA: 0xB43310
}

public class EscaperImplementation : ScalarEscaperBase
{
    public object Singleton;
    public object SingletonMinimallyEscaped;
    public object _preescapedMap;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6D5C5F0
    public void EncodeUtf8(){} // RVA: 0x6D5C610
    public void EncodeUtf16(){} // RVA: 0x6D5C760
    public void .cctor(){} // RVA: 0x6D5C8B0
    public void <EncodeUtf8>g__TryEncodeScalarAsHex|4_0(){} // RVA: 0x6D5CA00
    public void <EncodeUtf16>g__TryEncodeScalarAsHex|5_0(){} // RVA: 0x6D5CC90
}

public class EventData : ValueType
{
    public object _dataPointer;
    public object _size;
    public object _reserved;

    // ── Methods ──
    public void set_DataPointer(){} // RVA: 0x93050
    public void set_Size(){} // RVA: 0x92DD0
    public void set_Reserved(){} // RVA: 0x92DF0
}

public class Event`1 : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25DCF60
    public void Listen(){} // RVA: 0x3DC4A20
    public void Remove(){} // RVA: 0x3DC4990
    public void Send(){} // RVA: 0x3DC4A50
}

public class Event`1 : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25DCF60
    public void Listen(){} // RVA: 0x3DC4960
    public void Remove(){} // RVA: 0x3DC4990
    public void Send(){} // RVA: 0x3DC4A80
}

public class Event`1 : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25DCF60
    public void Listen(){} // RVA: 0x3DC4960
    public void Remove(){} // RVA: 0x3DC4990
    public void Send(){} // RVA: 0x3DC49F0
}

public class Event`1 : UnityEvent`1
{
    // ── Methods ──
    public void Listen(){} // RVA: 0x3DC4960
    public void Remove(){} // RVA: 0x3DC4990
    public void .ctor(){} // RVA: 0x25DCF60
    public void Send(){} // RVA: 0x3DC4AB0
}

public class Event`2 : UnityEvent`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25DCF60
    public void Listen(){} // RVA: 0x3DC4C40
    public void Remove(){} // RVA: 0x3DC4990
    public void Send(){} // RVA: 0x3DC4CD0
}

public class Event`2 : UnityEvent`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25DCF60
    public void Listen(){} // RVA: 0x3DC4C40
    public void Remove(){} // RVA: 0x3DC4990
    public void Send(){} // RVA: 0x3DC4D00
}

public class Event`3 : UnityEvent`3
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x25DCF60
    public void Listen(){} // RVA: 0x3DC4EC0
    public void Remove(){} // RVA: 0x3DC4990
    public void Send(){} // RVA: 0x3DC4F50
}

public class EvidenceEnumerator : Object
{
    public object currentEnum;
    public object hostEnum;
    public object assemblyEnum;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x66E3F70
    public void MoveNext(){} // RVA: 0x66E4070
    public void Reset(){} // RVA: 0x66E4110
    public void get_Current(){} // RVA: 0x66E4250
}

public class ExceptionFromErrorCode : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x6741640
    public void Invoke(){} // RVA: 0x14CC9D0
}

public class ExclusiveLock : Object
{
    public object m_Disposed;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7AD8200
    public void Finalize(){} // RVA: 0x7AD8280
    public void InternalDispose(){} // RVA: 0x7AD82C0
    public void Dispose(){} // RVA: 0x7AD8350
}

public class ExclusiveOrBoolean : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7085D00
    public void .ctor(){} // RVA: 0xB43310
}

public class ExclusiveOrByte : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7085840
    public void .ctor(){} // RVA: 0xB43310
}

public class ExclusiveOrInt16 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70854F0
    public void .ctor(){} // RVA: 0xB43310
}

public class ExclusiveOrInt32 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70855E0
    public void .ctor(){} // RVA: 0xB43310
}

public class ExclusiveOrInt64 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70856D0
    public void .ctor(){} // RVA: 0xB43310
}

public class ExclusiveOrSByte : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7085400
    public void .ctor(){} // RVA: 0xB43310
}

public class ExclusiveOrUInt16 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7085930
    public void .ctor(){} // RVA: 0xB43310
}

public class ExclusiveOrUInt32 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7085A20
    public void .ctor(){} // RVA: 0xB43310
}

public class ExclusiveOrUInt64 : ExclusiveOrInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7085B90
    public void .ctor(){} // RVA: 0xB43310
}

public class ExecutionContextCallbackArgs : Object
{
    public object _errorCode;
    public object _bytesWritten;
    public object _overlapped;
    public object _data;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB43310
}

public class ExpandoData : Object
{
    public object Empty;
    public object Class;
    public object _dataArray;
    public object _version;

    // ── Methods ──
    public void get_Item(){} // RVA: 0x677E590
    public void set_Item(){} // RVA: 0x70D8340
    public void get_Version(){} // RVA: 0xFEAE90
    public void get_Length(){} // RVA: 0x3E42680
    public void .ctor(){} // RVA: 0x31D5D40
    public void UpdateClass(){} // RVA: 0x70D84E0
    public void GetAlignedSize(){} // RVA: 0x70D8760
    public void .cctor(){} // RVA: 0x70D8770
}

public class ExpressionQuoter : ExpressionVisitor
{
    public object _variables;
    public object _frame;
    public object _shadowedVars;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70C4AC0
    public void VisitLambda(){} // RVA: 0x87C540
    public void VisitBlock(){} // RVA: 0x70C4C40
    public void VisitCatchBlock(){} // RVA: 0x70C4EA0
    public void VisitRuntimeVariables(){} // RVA: 0x70C5070
    public void MergeRuntimeVariables(){} // RVA: 0x70C5660
    public void VisitParameter(){} // RVA: 0x70C57B0
    public void GetBox(){} // RVA: 0x70C58D0
}

public class ExtensionInfo : Object
{
    public object NodeType;
    public object Type;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2574280
}
