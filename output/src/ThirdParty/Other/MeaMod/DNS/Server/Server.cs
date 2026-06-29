// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Server
// Classes: 5
// Methods: 47

namespace ThirdParty.Other.MeaMod.DNS.Server
{
    public class CachedNameServer : NameServer
    {
        // ── Methods ──
        public void Prune(){} // RVA: 0x7AD8904C0
        public void PruneContinuously(){} // RVA: 0x7AD890A20
        public void Add(){} // RVA: 0x7AD890C20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Catalog : ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IncludeZone(){} // RVA: 0x7AD8915F0
        public void RemoveZone(){} // RVA: 0x7AD891EA0
        public void Add(){} // RVA: 0x7AD892210
        public void IncludeRootHints(){} // RVA: 0x7AD892530
        public void Include(){} // RVA: 0x7AD892840
        public void NodesInCanonicalOrder(){} // RVA: 0x7AD8928E0
        public void IncludeReverseLookupRecords(){} // RVA: 0x7AD892A90
        public void .ctor(){} // RVA: 0x7AD8930B0
    }

    public class ConcurrentSet`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_IsEmpty(){} // RVA: 0x7A7E01900
        public void get_IsReadOnly(){} // RVA: 0x7A7E01900
        public void Contains(){} // RVA: 0x7A8051B10
        public void Add(){} // RVA: 0x7A8051B10
        public void AddRange(){} // RVA: 0x7A7E18800
        public void Remove(){} // RVA: 0x7A8051B10
        public void Clear(){} // RVA: 0x7A7E18770
        public void GetEnumerator(){} // RVA: 0x7A8051B10
        public void GetEnumeratorImpl(){} // RVA: 0x7A7E00680
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7A8051B10
        public void CopyTo(){} // RVA: 0x7A7E1D590
    }

    public class NameServer : Object
    {
        // ── Methods ──
        public void get_Catalog(){} // RVA: 0x7A80F2570
        public void set_Catalog(){} // RVA: 0x7A80D8E20
        public void get_AnswerAllQuestions(){} // RVA: 0x7A80F26D0
        public void set_AnswerAllQuestions(){} // RVA: 0x7A80F26E0
        public void ResolveAsync(){} // RVA: 0x7AD8939C0
        public void FindAnswerAsync(){} // RVA: 0x7AD893C80
        public void FindAuthority(){} // RVA: 0x7AD894220
        public void AddAdditionalRecords(){} // RVA: 0x7AD894410
        public void FindAddresses(){} // RVA: 0x7AD894D50
        public void AddSecurityExtensionsAsync(){} // RVA: 0x7AD894ED0
        public void AddSecurityResourcesAsync(){} // RVA: 0x7AD895110
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Node : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void ToString(){} // RVA: 0x7A8E1FCB0
        public void get_Resources(){} // RVA: 0x7A80DA7B0
        public void set_Resources(){} // RVA: 0x7A813E420
        public void get_Authoritative(){} // RVA: 0x7A81C68D0
        public void set_Authoritative(){} // RVA: 0x7A81C68E0
        public void .ctor(){} // RVA: 0x7AD898280
    }

}