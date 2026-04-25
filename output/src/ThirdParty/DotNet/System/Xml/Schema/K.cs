// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class KSStruct : Object
    {
        public int depth; // 0x10
        public System.Xml.Schema.KeySequence ks; // 0x18
        public System.Xml.Schema.LocatedActiveAxis[] fields; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC926E1F0
    }

    public class KeySequence : Object
    {
        public System.Xml.Schema.TypedObject[] PosLine; // 0x10
        public int PosCol; // 0x18
        public int Item; // 0x1C
        public int posline; // 0x20
        public int poscol; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC926EFA0
        public void get_PosLine(){} // RVA: 0x7FFAC30DBBE0
        public void get_PosCol(){} // RVA: 0x7FFAC3921980
        public void get_Item(){} // RVA: 0x7FFAC926F060
        public void set_Item(){} // RVA: 0x7FFAC926F090
        public void IsQualified(){} // RVA: 0x7FFAC926F1F0
        public void GetHashCode(){} // RVA: 0x7FFAC926F260
        public void Equals(){} // RVA: 0x7FFAC926F6A0
        public void ToString(){} // RVA: 0x7FFAC926F7C0
    }

}