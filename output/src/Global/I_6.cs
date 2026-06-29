// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 29
// Methods: 163

public class ImmutableBox : InitializeLocalInstruction
{
    public object _defaultValue;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2574280
    public void Run(){} // RVA: 0x70B29B0
    public void get_InstructionName(){} // RVA: 0x70B2AD0
}

public class ImmutableRefBox : InitializeLocalInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB460A0
    public void Run(){} // RVA: 0x70B2B10
    public void get_InstructionName(){} // RVA: 0x70B2BD0
}

public class ImmutableValue : InitializeLocalInstruction
{
    public object _defaultValue;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2574280
    public void Run(){} // RVA: 0x70B2840
    public void BoxIfIndexMatches(){} // RVA: 0x70B28C0
    public void get_InstructionName(){} // RVA: 0x70B2970
}

public class IncrementDouble : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x708A6D0
    public void .ctor(){} // RVA: 0xB43310
}

public class IncrementInt16 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7089F60
    public void .ctor(){} // RVA: 0xB43310
}

public class IncrementInt32 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x708A070
    public void .ctor(){} // RVA: 0xB43310
}

public class IncrementInt64 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x708A170
    public void .ctor(){} // RVA: 0xB43310
}

public class IncrementSingle : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x708A5B0
    public void .ctor(){} // RVA: 0xB43310
}

public class IncrementUInt16 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x708A280
    public void .ctor(){} // RVA: 0xB43310
}

public class IncrementUInt32 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x708A390
    public void .ctor(){} // RVA: 0xB43310
}

public class IncrementUInt64 : IncrementInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x708A4A0
    public void .ctor(){} // RVA: 0xB43310
}

public class IndexExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70491D0
    public void get_Arguments(){} // RVA: 0x70492B0
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_Indexer(){} // RVA: 0x13F92B0
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Object(){} // RVA: 0x13F9400
    public void get_Type(){} // RVA: 0x10ACB60
}

public class InputState : ValueType
{
    public object _count;
    public object _startIndex;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x2B100
}

public class InstanceRestriction : BindingRestrictions
{
    public object _expression;
    public object _instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x70CBB60
    public void Equals(){} // RVA: 0x70CBC70
    public void GetHashCode(){} // RVA: 0x70CBD00
    public void GetExpression(){} // RVA: 0x70CBD50
}

public class InstructionView : ValueType
{
    public object _index;
    public object _stackDepth;
    public object _continuationsDepth;
    public object _name;
    public object _instruction;

    // ── Methods ──
    public void GetName(){} // RVA: 0x8FE690
    public void GetValue(){} // RVA: 0x7E450
    public void GetDisplayType(){} // RVA: 0x8FE790
    public void .ctor(){} // RVA: 0x8FE7A0
}

public class Int : Object
{
    // ── Methods ──
    public void TryParse(){} // RVA: 0x727F410
}

public class InvocationExpressionProxy : Object
{
    public object _node;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7049300
    public void get_Arguments(){} // RVA: 0x7048FE0
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_Expression(){} // RVA: 0x13F9400
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
}

public class IsCanceledSource : Object
{
    public object source;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class IsCanceledSource : Object
{
    public object source;

    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4092900
    public void get_Current(){} // RVA: 0xAD0950
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x4092AB0
    public void GetEnumerator(){} // RVA: 0x4092B90
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x4092D50
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4092E00
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4092900
    public void get_Current(){} // RVA: 0xAD0950
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x4092AB0
    public void GetEnumerator(){} // RVA: 0x4092B90
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x4092D50
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4092E00
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void Where(){} // RVA: 0x87C540
    public void .ctor(){} // RVA: 0x4092210
    public void get_Current(){} // RVA: 0xB465B0
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x40925D0
    public void GetEnumerator(){} // RVA: 0x40922B0
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xB465B0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x40923C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void Where(){} // RVA: 0x87C540
    public void .ctor(){} // RVA: 0x4092210
    public void get_Current(){} // RVA: 0xB465B0
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x40925D0
    public void GetEnumerator(){} // RVA: 0x40922B0
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xB465B0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x40923C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void Where(){} // RVA: 0x87C540
    public void .ctor(){} // RVA: 0x4092210
    public void get_Current(){} // RVA: 0xB465B0
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x40925D0
    public void GetEnumerator(){} // RVA: 0x40922B0
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xB465B0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x40923C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4092210
    public void get_Current(){} // RVA: 0x125EE60
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x4092490
    public void GetEnumerator(){} // RVA: 0x40922B0
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x40924A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x40923C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void Where(){} // RVA: 0x87C540
    public void .ctor(){} // RVA: 0x4092210
    public void get_Current(){} // RVA: 0xB465B0
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x40925D0
    public void GetEnumerator(){} // RVA: 0x40922B0
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xB465B0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x40923C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void Select(){} // RVA: 0x87C540
    public void .ctor(){} // RVA: 0x4092210
    public void get_Current(){} // RVA: 0xB465B0
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x40925D0
    public void GetEnumerator(){} // RVA: 0x40922B0
    public void MoveNext(){} // RVA: 0x87D280
    public void Where(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0xB465B0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x40923C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void Select(){} // RVA: 0x87C540
    public void .ctor(){} // RVA: 0x4092210
    public void get_Current(){} // RVA: 0x31D74A0
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x4092750
    public void GetEnumerator(){} // RVA: 0x40922B0
    public void MoveNext(){} // RVA: 0x87D280
    public void Where(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x4092760
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x40923C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}

public class Iterator`1 : Object
{
    public object threadId;
    public object state;
    public object current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x4092210
    public void get_Current(){} // RVA: 0x31D74A0
    public void Clone(){} // RVA: 0x87C0A0
    public void Dispose(){} // RVA: 0x4092750
    public void GetEnumerator(){} // RVA: 0x40922B0
    public void MoveNext(){} // RVA: 0x87D280
    public void Select(){} // RVA: 0x87C540
    public void Where(){} // RVA: 0x87C540
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x4092760
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x40923C0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x40066C0
}
