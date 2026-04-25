// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 12
// Methods: 44

public class QName : ValueType
{
    public string prefix; // 0x10
    public string localname; // 0x18
    public string namespaceUri; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC446FCC0
    public void Set(){} // RVA: 0x7FFAC446FCC0
    public void Clear(){} // RVA: 0x7FFAC9093320
    public void MatchNs(){} // RVA: 0x7FFAC9093460
    public void MatchPrefix(){} // RVA: 0x7FFAC9093500
    public void CheckPrefixNS(){} // RVA: 0x7FFAC90935A0
    public void GetHashCode(){} // RVA: 0x7FFAC90936F0
    public void GetNSHashCode(){} // RVA: 0x7FFAC9093750
    public void Equals(){} // RVA: 0x7FFAC90937B0
    public void ToString(){} // RVA: 0x7FFAC9093950
    public void op_Equality(){} // RVA: 0x7FFAC90939C0
}

public class QualityPreset : Object
{
    public int maximumIterationCount; // 0x10
    public float thickness; // 0x14
    public 0x6B271510 downsampling; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class QuaternionEqualityComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC94FCF40
    public void GetHashCode(){} // RVA: 0x7FFAC94FD000
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class QuaternionSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFACC07ADE0
    public void SetObjectData(){} // RVA: 0x7FFACC07AF00
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Quatf : ValueType
{
    public float x; // 0x10
    public float y; // 0x14
    public float z; // 0x18
    public float w; // 0x1C
    public Quatf identity;

    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC8907260
    public void .cctor(){} // RVA: 0x7FFAC8907520
}

public class Queue : Object
{
    public int Duration; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F240C0
    public void get_Duration(){} // RVA: 0x7FFAC2F6E5C0
    public void CreateTimer(){} // RVA: 0x7FFAC2C6A6F0
}

public class QueueDebugView : Object
{
}

public class QueueEnumerator : Object
{
    public System.Collections.Queue Current; // 0x10
    public int _index; // 0x18
    public int _version; // 0x1C
    public object _currentElement; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8594F50
    public void Clone(){} // RVA: 0x7FFAC8512B10
    public void MoveNext(){} // RVA: 0x7FFAC8595040
    public void get_Current(){} // RVA: 0x7FFAC85951D0
    public void Reset(){} // RVA: 0x7FFAC8595290
}

public class QueueSegment : Object
{
    public System.Threading.IThreadPoolWorkItem[] nodes; // 0x10
    public int indexes; // 0x18
    public QueueSegment Next; // 0x20

    // ── Methods ──
    public void GetIndexes(){} // RVA: 0x7FFAC86D0B70
    public void CompareExchangeIndexes(){} // RVA: 0x7FFAC86D0B90
    public void .ctor(){} // RVA: 0x7FFAC86D0BE0
    public void IsUsedUp(){} // RVA: 0x7FFAC86D0C70
    public void TryEnqueue(){} // RVA: 0x7FFAC86D0CC0
    public void TryDequeue(){} // RVA: 0x7FFAC86D0DB0
}

public class QueuedJob : ValueType
{
    public System.Action _job; // 0x10
    public 0x6B0B74C0 _priority; // 0x18
    public ulong _id; // 0x20
    public ulong _nextId;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBF36480
    public void Invoke(){} // RVA: 0x7FFACBF36530
    public void System.IComparable<VRC.Core.UpdateDelegator.QueuedJob>.CompareTo(){} // RVA: 0x7FFACBF36560
}

public class QuickButton : ValueType
{
    public UnityEngine.GameObject gameObject; // 0x10
    public UnityEngine.UI.Image icon; // 0x18
    public ÌÎÏÎÍÍÎÎÍÌÍÏÍÍÏÏÌÏÎÎÎÍÌ tooltip; // 0x20
    public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ button; // 0x28
}

public class QuoteVisitor : ExpressionVisitor
{
    public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,int> _definedParameters; // 0x10
    public System.Collections.Generic.HashSet`1<System.Linq.Expressions.ParameterExpression> _hoistedParameters; // 0x18

    // ── Methods ──
    public void VisitParameter(){} // RVA: 0x7FFAC8DD6AF0
    public void VisitBlock(){} // RVA: 0x7FFAC8DD6BA0
    public void VisitCatchBlock(){} // RVA: 0x7FFAC8DD6CE0
    public void VisitLambda(){} // RVA: 0x7FFAC2C58F40
    public void PushParameters(){} // RVA: 0x7FFAC8DD6E50
    public void PopParameters(){} // RVA: 0x7FFAC8DD7140
    public void .ctor(){} // RVA: 0x7FFAC8DD73D0
}
