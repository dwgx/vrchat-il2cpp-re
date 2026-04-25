// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Server
// Classes: 5
// Methods: 50

namespace ThirdParty.Other.MeaMod.DNS.Server
{
    public class CachedNameServer : NameServer
    {
        // ── Methods ──
        public void Prune(){} // RVA: 0x7FFAC823A560
        public void PruneContinuously(){} // RVA: 0x7FFAC823AAC0
        public void Add(){} // RVA: 0x7FFAC823ACC0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Catalog : ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IncludeZone(){} // RVA: 0x7FFAC823B680
        public void RemoveZone(){} // RVA: 0x7FFAC823BF30
        public void Add(){} // RVA: 0x7FFAC823C2A0
        public void IncludeRootHints(){} // RVA: 0x7FFAC823C5C0
        public void Include(){} // RVA: 0x7FFAC823C8C0
        public void NodesInCanonicalOrder(){} // RVA: 0x7FFAC823C960
        public void IncludeReverseLookupRecords(){} // RVA: 0x7FFAC823CB10
        public void .ctor(){} // RVA: 0x7FFAC823D110
    }

    public class ConcurrentSet`1 : Object
    {
        public int Count;
        public int IsEmpty;
        public System.Collections.Concurrent.ConcurrentDictionary`2<T,byte> IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void AddRange(){} // RVA: 0x7FFAC2C70A40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumeratorImpl(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
    }

    public class NameServer : Object
    {
        public MeaMod.DNS.Server.Catalog Catalog; // 0x10
        public bool AnswerAllQuestions; // 0x18

        // ── Methods ──
        public void get_Catalog(){} // RVA: 0x7FFAC2F3C380
        public void set_Catalog(){} // RVA: 0x7FFAC2F22E30
        public void get_AnswerAllQuestions(){} // RVA: 0x7FFAC2F3C4E0
        public void set_AnswerAllQuestions(){} // RVA: 0x7FFAC2F3C4F0
        public void ResolveAsync(){} // RVA: 0x7FFAC823DA10 | overloaded x2
        public void FindAnswerAsync(){} // RVA: 0x7FFAC823DCD0
        public void FindAuthority(){} // RVA: 0x7FFAC823E270
        public void AddAdditionalRecords(){} // RVA: 0x7FFAC823E460
        public void FindAddresses(){} // RVA: 0x7FFAC823EDA0
        public void AddSecurityExtensionsAsync(){} // RVA: 0x7FFAC823EF20
        public void AddSecurityResourcesAsync(){} // RVA: 0x7FFAC823F160
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Node : Object
    {
        public MeaMod.DNS.Model.DomainName Name; // 0x10
        public MeaMod.DNS.Server.ConcurrentSet`1<MeaMod.DNS.Model.ResourceRecord> Resources; // 0x18
        public bool Authoritative; // 0x20

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void ToString(){} // RVA: 0x7FFAC3CE8330
        public void get_Resources(){} // RVA: 0x7FFAC2F247C0
        public void set_Resources(){} // RVA: 0x7FFAC2F87E80
        public void get_Authoritative(){} // RVA: 0x7FFAC300F9D0
        public void set_Authoritative(){} // RVA: 0x7FFAC300F9E0
        public void .ctor(){} // RVA: 0x7FFAC82422C0
    }

}