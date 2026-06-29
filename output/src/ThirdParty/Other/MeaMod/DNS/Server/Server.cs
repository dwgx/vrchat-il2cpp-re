// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Server
// Classes: 7
// Methods: 77

namespace ThirdParty.Other.MeaMod.DNS.Server
{
    public class CachedNameServer : NameServer
    {
        // ── Methods ──
        public void Prune(){} // RVA: 0x651DAC0
        public void PruneContinuously(){} // RVA: 0x651E020
        public void Add(){} // RVA: 0x651E220
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Catalog : ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IncludeZone(){} // RVA: 0x651EBF0
        public void RemoveZone(){} // RVA: 0x651F4A0
        public void Add(){} // RVA: 0x651F810
        public void IncludeRootHints(){} // RVA: 0x651FB30
        public void Include(){} // RVA: 0x651FE10
        public void NodesInCanonicalOrder(){} // RVA: 0x651FEB0
        public void IncludeReverseLookupRecords(){} // RVA: 0x6520060
        public void .ctor(){} // RVA: 0x6520680
    }

    public class ConcurrentSet`1 : Object
    {
        public object DefaultConcurrencyLevel;
        public object DefaultCapacity;
        public object _dictionary;

        // ── Methods ──
        public void Add(){} // RVA: 0x34A7390
        public void Remove(){} // RVA: 0x34A75D0
        public void .ctor(){} // RVA: 0x34A72A0
        public void get_Count(){} // RVA: 0x34A7300
        public void get_IsEmpty(){} // RVA: 0x34A7330
        public void get_IsReadOnly(){} // RVA: 0xB43320
        public void Contains(){} // RVA: 0x34A7360
        public void AddRange(){} // RVA: 0x34A73C0
        public void Clear(){} // RVA: 0x34A7680
        public void GetEnumerator(){} // RVA: 0x34A76B0
        public void GetEnumeratorImpl(){} // RVA: 0x34A7790
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x34A7830
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34A7830
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x34A7850
        public void CopyTo(){} // RVA: 0x34A7890
    }

    public class ConcurrentSet`1 : Object
    {
        public object DefaultConcurrencyLevel;
        public object DefaultCapacity;
        public object _dictionary;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void Contains(){} // RVA: 0xA94080
        public void Add(){} // RVA: 0xA94080
        public void AddRange(){} // RVA: 0x894320
        public void Remove(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void GetEnumerator(){} // RVA: 0xA94080
        public void GetEnumeratorImpl(){} // RVA: 0x87C0A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
    }

    public class NameServer : Object
    {
        public object _catalog;
        public object _answerAllQuestions;

        // ── Methods ──
        public void get_Catalog(){} // RVA: 0xB5DBF0
        public void set_Catalog(){} // RVA: 0xB44D60
        public void get_AnswerAllQuestions(){} // RVA: 0xB5DD50
        public void set_AnswerAllQuestions(){} // RVA: 0xB5DD60
        public void ResolveAsync(){} // RVA: 0x6520F90
        public void FindAnswerAsync(){} // RVA: 0x6521250
        public void FindAuthority(){} // RVA: 0x65217F0
        public void AddAdditionalRecords(){} // RVA: 0x65219E0
        public void FindAddresses(){} // RVA: 0x6522320
        public void AddSecurityExtensionsAsync(){} // RVA: 0x65224A0
        public void AddSecurityResourcesAsync(){} // RVA: 0x65226E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Node : Object
    {
        public object _name;
        public object _resources;
        public object _authoritative;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void ToString(){} // RVA: 0x1910690
        public void get_Resources(){} // RVA: 0xB465B0
        public void set_Resources(){} // RVA: 0xBA9BA0
        public void get_Authoritative(){} // RVA: 0xC38360
        public void set_Authoritative(){} // RVA: 0xC38370
        public void .ctor(){} // RVA: 0x6525820
    }

    public class Node[] : Array
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

}