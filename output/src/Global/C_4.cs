// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 34
// Methods: 168

public class CacheEntry : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7312D20
    public void GetResult(){} // RVA: 0x7312D80
}

public class CachingContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7312180
    public void get_Options(){} // RVA: 0xB700F0
    public void get_HashCode(){} // RVA: 0x1065D50
    public void get_Count(){} // RVA: 0x7312350
    public void GetOrAddTypeInfo(){} // RVA: 0x73123A0
    public void TryGetTypeInfo(){} // RVA: 0x73124A0
    public void Clear(){} // RVA: 0x7312630
    public void GetOrAddCacheEntry(){} // RVA: 0x7312680
    public void CreateCacheEntry(){} // RVA: 0x73126E0
    public void FallBackToNearestAncestor(){} // RVA: 0x7312890
    public void DetermineNearestAncestor(){} // RVA: 0x7312900
    public void <.ctor>b__2_0(){} // RVA: 0x7312CA0
}

public class Callback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x40E2DB0
    public void Invoke(){} // RVA: 0xCA8D60
}

public class CallbackContext : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x75A8840
}

public class CallbackInfo : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x17C92C0
    public void WriteObject(){} // RVA: 0x7529330
    public void WriteEnum(){} // RVA: 0x7529390
}

public class CastInstructionNoT : CastInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Create(){} // RVA: 0x70C3DB0
    public void Run(){} // RVA: 0x70C3F30
    public void ConvertNull(){} // RVA: 0x894320
}

public class CastInstructionT`1 : CastInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x87D050
    public void .ctor(){} // RVA: 0x894290
}

public class CatchBlockProxy : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7048C60
    public void get_Body(){} // RVA: 0x13F92B0
    public void get_Filter(){} // RVA: 0x13F92F0
    public void get_Test(){} // RVA: 0x13F9400
    public void get_Variable(){} // RVA: 0x13F9340
}

public class Checked : NumericConvertInstruction
{
    // ── Methods ──
    public void get_InstructionName(){} // RVA: 0x70BC4C0
    public void .ctor(){} // RVA: 0x70BB510
    public void Convert(){} // RVA: 0x70BC500
    public void ConvertInt32(){} // RVA: 0x70BC870
    public void ConvertInt64(){} // RVA: 0x70BCB40
    public void ConvertUInt64(){} // RVA: 0x70BCE50
    public void ConvertDouble(){} // RVA: 0x70BD1B0
}

public class Chunk : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0xB44D60
    public void Read(){} // RVA: 0x75CED20
}

public class CollectionFixup : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x75196D0
    public void get_Callback(){} // RVA: 0xB5DBF0
    public void get_Collection(){} // RVA: 0xB465B0
    public void get_Id(){} // RVA: 0xB70160
    public void get_CollectionItems(){} // RVA: 0xB700F0
    public void set_CollectionItems(){} // RVA: 0xB70100
}

public class CollectionHeaderTypeInfo`2 : HeaderTypeInfo`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x89E120
    public void get_Separator(){} // RVA: 0x87C0A0
    public void TryParse(){} // RVA: 0x87D3C0
}

public class CollectionItemFixup : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x69C9EA0
    public void get_Collection(){} // RVA: 0xB5DBF0
    public void get_Index(){} // RVA: 0xE62D00
    public void get_Id(){} // RVA: 0xB700F0
}

public class Comparers : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x8943B0
    public void get_KeyComparer(){} // RVA: 0x87C0A0
    public void get_KeyOnlyComparer(){} // RVA: 0x87C0A0
    public void get_ValueComparer(){} // RVA: 0x87C0A0
    public void get_HashBucketEqualityComparer(){} // RVA: 0x87C0A0
    public void Equals(){} // RVA: 0xA94080
    public void GetHashCode(){} // RVA: 0xA94080
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0xA94080
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0xA94080
    public void Get(){} // RVA: 0x87C630
    public void WithValueComparer(){} // RVA: 0x87C540
    public void .cctor(){} // RVA: 0x8942F0
}

public class ConditionalExpressionProxy : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7048D40
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_IfFalse(){} // RVA: 0x678C250
    public void get_IfTrue(){} // RVA: 0x13F9400
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Test(){} // RVA: 0x13F9340
    public void get_Type(){} // RVA: 0x10ACB60
}

public class ConfigurationListDebugView : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x894320
    public void get_Items(){} // RVA: 0x87C0A0
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x2133A0
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x213290
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
}

public class ConfiguredTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x3A130
    public void get_IsCompleted(){} // RVA: 0x214480
    public void OnCompleted(){} // RVA: 0x212FB0
    public void UnsafeOnCompleted(){} // RVA: 0x213070
    public void GetResult(){} // RVA: 0x216780
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x11E4F0
    public void get_IsCompleted(){} // RVA: 0x219990
    public void GetResult(){} // RVA: 0x2199D0
    public void OnCompleted(){} // RVA: 0x22B630
    public void UnsafeOnCompleted(){} // RVA: 0x22B640
}

public class ConnectionGroup : Object
{
    // ── Methods ──
    public void get_Scheduler(){} // RVA: 0xB5DBF0
    public void .ctor(){} // RVA: 0x75D6D00
    public void IsEmpty(){} // RVA: 0x75D6F10
    public void RemoveConnection(){} // RVA: 0x75D6F80
    public void Cleanup(){} // RVA: 0x75D7020
    public void Close(){} // RVA: 0x75D7130
    public void EnqueueOperation(){} // RVA: 0x75D7600
    public void GetNextOperation(){} // RVA: 0x75D7660
    public void FindIdleConnection(){} // RVA: 0x75D77B0
    public void CreateOrReuseConnection(){} // RVA: 0x75D7C10
}

public class ConstantExpressionProxy : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7048E20
    public void get_CanReduce(){} // RVA: 0x10AD460
    public void get_DebugView(){} // RVA: 0x7048AD0
    public void get_NodeType(){} // RVA: 0x10AD380
    public void get_Type(){} // RVA: 0x10ACB60
    public void get_Value(){} // RVA: 0x13F9340
}

public class ContentBlock[] : Array
{
    // ── Methods ──
    public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
    public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
    public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
    public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
    public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
    public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
    public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
    public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
    public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
    public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
    public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
    public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
}

public class ContentReader : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x736BD40
    public void ReadContentFrom(){} // RVA: 0x736C830
}

public class ConverterList : ConfigurationList`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7313C90
    public void get_IsReadOnly(){} // RVA: 0x7313E30
    public void OnCollectionModifying(){} // RVA: 0x7313E60
}

public class CookieCollectionEnumerator : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x759BDE0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x759BE80
    public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x759BF80
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x759C030
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x23F1A30
    public void Invoke(){} // RVA: 0xB9E010
}

public class CustomRestriction : BindingRestrictions
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x70CB760
    public void Equals(){} // RVA: 0x70CB800
    public void GetHashCode(){} // RVA: 0x70CB870
    public void GetExpression(){} // RVA: 0xB5DBF0
}
