// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 2
// Methods: 7

namespace ThirdParty.DotNet.System.Data
{
    public class OperatorInfo : Object
    {
        public 0x6B1CF7F0 _type; // 0x10
        public int _op; // 0x14
        public int _priority; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC48B1250
    }

    public class Operators : Object
    {
        public int[] s_priority;
        public string[] s_looks; // 0x8

        // ── Methods ──
        public void IsArithmetical(){} // RVA: 0x7FFAC8EBAA20
        public void IsLogical(){} // RVA: 0x7FFAC8EBAA40
        public void IsRelational(){} // RVA: 0x7FFAC8EBAA60
        public void Priority(){} // RVA: 0x7FFAC8EBAA70
        public void ToString(){} // RVA: 0x7FFAC8EBAB20
        public void .cctor(){} // RVA: 0x7FFAC8EBABE0
    }

}