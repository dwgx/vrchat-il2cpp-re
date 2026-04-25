// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 5
// Methods: 19

public class QuaternionSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD5749ADE0
    public void SetObjectData(){} // RVA: 0x7FFD5749AF00
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class QueueSegment : Object
{
    public System.Threading.IThreadPoolWorkItem[] nodes; // 0x10
    public int indexes; // 0x18
    public QueueSegment Next; // 0x20

    // ── Methods ──
    public void GetIndexes(){} // RVA: 0x7FFD53AF0B70
    public void CompareExchangeIndexes(){} // RVA: 0x7FFD53AF0B90
    public void .ctor(){} // RVA: 0x7FFD53AF0BE0
    public void IsUsedUp(){} // RVA: 0x7FFD53AF0C70
    public void TryEnqueue(){} // RVA: 0x7FFD53AF0CC0
    public void TryDequeue(){} // RVA: 0x7FFD53AF0DB0
}

public class QueuedJob : ValueType
{
    public System.Action _job; // 0x10
    public 0x664174C0 _priority; // 0x18
    public ulong _id; // 0x20
    public ulong _nextId;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD57356480
    public void Invoke(){} // RVA: 0x7FFD57356530
    public void System.IComparable<VRC.Core.UpdateDelegator.QueuedJob>.CompareTo(){} // RVA: 0x7FFD57356560
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
    public void VisitParameter(){} // RVA: 0x7FFD541F6AF0
    public void VisitBlock(){} // RVA: 0x7FFD541F6BA0
    public void VisitCatchBlock(){} // RVA: 0x7FFD541F6CE0
    public void VisitLambda(){} // RVA: 0x7FFD4E078F40
    public void PushParameters(){} // RVA: 0x7FFD541F6E50
    public void PopParameters(){} // RVA: 0x7FFD541F7140
    public void .ctor(){} // RVA: 0x7FFD541F73D0
}
