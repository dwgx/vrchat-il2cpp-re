// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Server
// Classes: 5
// Methods: 50

namespace ThirdParty.Other.MeaMod.DNS.Server
{
    public class CachedNameServer : NameServer
    {
        // ── Methods ──
        public void Prune(){} // RVA: 0x7FFE865E3EA0
        public void PruneContinuously(){} // RVA: 0x7FFE865E4400
        public void Add(){} // RVA: 0x7FFE865E4600
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Catalog : ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IncludeZone(){} // RVA: 0x7FFE865E4FC0
        public void RemoveZone(){} // RVA: 0x7FFE865E5870
        public void Add(){} // RVA: 0x7FFE865E5BE0
        public void IncludeRootHints(){} // RVA: 0x7FFE865E5F00
        public void Include(){} // RVA: 0x7FFE865E6200
        public void NodesInCanonicalOrder(){} // RVA: 0x7FFE865E62A0
        public void IncludeReverseLookupRecords(){} // RVA: 0x7FFE865E6450
        public void .ctor(){} // RVA: 0x7FFE865E6A50
    }

    public class ConcurrentSet`1 : Object
    {
        public int DefaultConcurrencyLevel;
        public int DefaultCapacity;
        public System.Collections.Concurrent.ConcurrentDictionary`2<T,byte> _dictionary;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void Add(){} // RVA: 0x7FFE810A1420
        public void AddRange(){} // RVA: 0x7FFE80E460A0
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void GetEnumeratorImpl(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
    }

    public class NameServer : Object
    {
        public MeaMod.DNS.Server.Catalog _catalog; // 0x10
        public bool _answerAllQuestions; // 0x18

        // ── Methods ──
        public void get_Catalog(){} // RVA: 0x7FFE81116380
        public void set_Catalog(){} // RVA: 0x7FFE810FCE30
        public void get_AnswerAllQuestions(){} // RVA: 0x7FFE811164E0
        public void set_AnswerAllQuestions(){} // RVA: 0x7FFE811164F0
        public void ResolveAsync(){} // RVA: 0x7FFE865E7350 | overloaded x2
        public void FindAnswerAsync(){} // RVA: 0x7FFE865E7610
        public void FindAuthority(){} // RVA: 0x7FFE865E7BB0
        public void AddAdditionalRecords(){} // RVA: 0x7FFE865E7DA0
        public void FindAddresses(){} // RVA: 0x7FFE865E86E0
        public void AddSecurityExtensionsAsync(){} // RVA: 0x7FFE865E8860
        public void AddSecurityResourcesAsync(){} // RVA: 0x7FFE865E8AA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Node : Object
    {
        public MeaMod.DNS.Model.DomainName _name; // 0x10
        public MeaMod.DNS.Server.ConcurrentSet`1<MeaMod.DNS.Model.ResourceRecord> _resources; // 0x18
        public bool _authoritative; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void ToString(){} // RVA: 0x7FFE81DE31E0
        public void get_Resources(){} // RVA: 0x7FFE810FE7C0
        public void set_Resources(){} // RVA: 0x7FFE81161E80
        public void get_Authoritative(){} // RVA: 0x7FFE811E99D0
        public void set_Authoritative(){} // RVA: 0x7FFE811E99E0
        public void .ctor(){} // RVA: 0x7FFE865EBC00
    }

}