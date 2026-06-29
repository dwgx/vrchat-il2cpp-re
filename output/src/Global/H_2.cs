// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 7
// Methods: 32

public class HasValue : NullableMethodCallInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x70C2D70
    public void .ctor(){} // RVA: 0xB43310
}

public class HashBucket : ValueType
{
    public object _firstValue;
    public object _additionalElements;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xA94080
    public void get_IsEmpty(){} // RVA: 0x87D280
    public void get_FirstValue(){} // RVA: 0xA94080
    public void get_AdditionalElements(){} // RVA: 0x87C0A0
    public void GetEnumerator(){} // RVA: 0xA94080
    public void System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator(){} // RVA: 0x87C0A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    public void Equals(){} // RVA: 0x87D350
    public void GetHashCode(){} // RVA: 0x87C130
    public void Add(){} // RVA: 0xA94080
    public void TryGetValue(){} // RVA: 0xA94080
    public void Freeze(){} // RVA: 0x894290
}

public class HashCode : ValueType
{
    public object _hashCode;

    // ── Methods ──
    public void Add(){} // RVA: 0xA94080
    public void ToHashCode(){} // RVA: 0x77E60
}

public class HeaderBucket : Object
{
    public object Parsed;
    public object values;
    public object CustomToString;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x6EC9750
    public void get_HasStringValues(){} // RVA: 0x7278BA0
    public void get_Values(){} // RVA: 0x7278BF0
    public void set_Values(){} // RVA: 0xBA9BA0
    public void ParsedToString(){} // RVA: 0x7278CB0
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    public object parser;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x895FE0
    public void AddToCollection(){} // RVA: 0x8943B0
    public void CreateCollection(){} // RVA: 0x87C5F0
    public void ToStringCollection(){} // RVA: 0x87C540
    public void TryParse(){} // RVA: 0x87D3C0
}

public class HeaderTypeInfo`2 : HeaderInfo
{
    public object parser;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x3F8B390
    public void AddToCollection(){} // RVA: 0x3F8B450
    public void CreateCollection(){} // RVA: 0x3F8B5E0
    public void ToStringCollection(){} // RVA: 0x3F8CEE0
    public void TryParse(){} // RVA: 0x3F8D2B0
}

public class Host : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x727F310
}
