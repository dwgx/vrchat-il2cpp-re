// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Server
// Classes: 5
// Methods: 50

namespace ThirdParty.Other.MeaMod.DNS.Server
{
    public class CachedNameServer
    {
        // ── Methods ──
        public void Prune(){} // RVA: 0x5AA3070
        public void PruneContinuously(){} // RVA: 0x5AA35D0
        public void Add(){} // RVA: 0x5AA37D0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Catalog
    {
        // ── Methods ──
        public void IncludeZone(){} // RVA: 0x5AA4190
        public void RemoveZone(){} // RVA: 0x5AA4A40
        public void Add(){} // RVA: 0x5AA4DB0
        public void IncludeRootHints(){} // RVA: 0x5AA50D0
        public void Include(){} // RVA: 0x5AA53D0
        public void NodesInCanonicalOrder(){} // RVA: 0x5AA5470
        public void IncludeReverseLookupRecords(){} // RVA: 0x5AA5620
        public void .ctor(){} // RVA: 0x5AA5C20
    }

    public class ConcurrentSet`1
    {
        public int DefaultConcurrencyLevel;
        public int DefaultCapacity;
        public System.Collections.Concurrent.ConcurrentDictionary`2<T,byte> _dictionary;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x3
        public void get_Count(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void Contains(){} // RVA: 0x283FA0
        public void Add(){} // RVA: 0x283FA0
        public void AddRange(){} // RVA: 0x24B10
        public void Remove(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void GetEnumeratorImpl(){} // RVA: 0xCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
    }

    public class NameServer
    {
        public MeaMod.DNS.Server.Catalog <Catalog>k__BackingField; // 0x10
        public bool <AnswerAllQuestions>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Catalog(){} // RVA: 0x2F8380
        public void set_Catalog(){} // RVA: 0x2DEE30
        public void get_AnswerAllQuestions(){} // RVA: 0x2F84E0
        public void set_AnswerAllQuestions(){} // RVA: 0x2F84F0
        public void ResolveAsync(){} // RVA: 0x5AA6520 | overloaded x2
        public void FindAnswerAsync(){} // RVA: 0x5AA67E0
        public void FindAuthority(){} // RVA: 0x5AA6D80
        public void AddAdditionalRecords(){} // RVA: 0x5AA6F70
        public void FindAddresses(){} // RVA: 0x5AA78B0
        public void AddSecurityExtensionsAsync(){} // RVA: 0x5AA7A30
        public void AddSecurityResourcesAsync(){} // RVA: 0x5AA7C70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Node
    {
        public MeaMod.DNS.Model.DomainName Message; // 0x10
        public MeaMod.DNS.Server.ConcurrentSet`1<MeaMod.DNS.Model.ResourceRecord> RemoteEndPoint; // 0x18
        public bool IsLegacyUnicast; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void set_Name(){} // RVA: 0x2DEE30
        public void ToString(){} // RVA: 0x104C4B0
        public void get_Resources(){} // RVA: 0x2E07C0
        public void set_Resources(){} // RVA: 0x343E80
        public void get_Authoritative(){} // RVA: 0x3CB9D0
        public void set_Authoritative(){} // RVA: 0x3CB9E0
        public void .ctor(){} // RVA: 0x5AAADD0
    }

}