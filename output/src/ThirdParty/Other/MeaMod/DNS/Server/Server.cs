// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.Server
// Classes: 5
// Methods: 50

namespace ThirdParty.Other.MeaMod.DNS.Server
{
    public class CachedNameServer
    {
        // ── Methods ──
        public void Prune(){} // RVA: 0x7FFAF8553070
        public void PruneContinuously(){} // RVA: 0x7FFAF85535D0
        public void Add(){} // RVA: 0x7FFAF85537D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Catalog
    {
        // ── Methods ──
        public void IncludeZone(){} // RVA: 0x7FFAF8554190
        public void RemoveZone(){} // RVA: 0x7FFAF8554A40
        public void Add(){} // RVA: 0x7FFAF8554DB0
        public void IncludeRootHints(){} // RVA: 0x7FFAF85550D0
        public void Include(){} // RVA: 0x7FFAF85553D0
        public void NodesInCanonicalOrder(){} // RVA: 0x7FFAF8555470
        public void IncludeReverseLookupRecords(){} // RVA: 0x7FFAF8555620
        public void .ctor(){} // RVA: 0x7FFAF8555C20
    }

    public class ConcurrentSet`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_IsEmpty(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2ABDBE0
        public void Contains(){} // RVA: 0x7FFAF2D33FA0
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void AddRange(){} // RVA: 0x7FFAF2AD4B10
        public void Remove(){} // RVA: 0x7FFAF2D33FA0
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void GetEnumerator(){} // RVA: 0x7FFAF2D33FA0
        public void GetEnumeratorImpl(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFAF2D33FA0
        public void CopyTo(){} // RVA: 0x7FFAF2ADBAA0
    }

    public class NameServer
    {
        // ── Methods ──
        public void get_Catalog(){} // RVA: 0x7FFAF2DA8380
        public void set_Catalog(){} // RVA: 0x7FFAF2D8EE30
        public void get_AnswerAllQuestions(){} // RVA: 0x7FFAF2DA84E0
        public void set_AnswerAllQuestions(){} // RVA: 0x7FFAF2DA84F0
        public void ResolveAsync(){} // RVA: 0x7FFAF8556520 | overloaded x2
        public void FindAnswerAsync(){} // RVA: 0x7FFAF85567E0
        public void FindAuthority(){} // RVA: 0x7FFAF8556D80
        public void AddAdditionalRecords(){} // RVA: 0x7FFAF8556F70
        public void FindAddresses(){} // RVA: 0x7FFAF85578B0
        public void AddSecurityExtensionsAsync(){} // RVA: 0x7FFAF8557A30
        public void AddSecurityResourcesAsync(){} // RVA: 0x7FFAF8557C70
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Node
    {
        public object Message;
        public object RemoteEndPoint;
        public object IsLegacyUnicast;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void ToString(){} // RVA: 0x7FFAF3AFC4B0
        public void get_Resources(){} // RVA: 0x7FFAF2D907C0
        public void set_Resources(){} // RVA: 0x7FFAF2DF3E80
        public void get_Authoritative(){} // RVA: 0x7FFAF2E7B9D0
        public void set_Authoritative(){} // RVA: 0x7FFAF2E7B9E0
        public void .ctor(){} // RVA: 0x7FFAF855ADD0
    }

}