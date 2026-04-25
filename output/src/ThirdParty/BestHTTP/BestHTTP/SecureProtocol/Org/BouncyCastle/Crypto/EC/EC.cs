// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.EC
// Classes: 1
// Methods: 14

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.EC
{
    public class CustomNamedCurves : Object
    {
        public System.Collections.IDictionary Names;
        public System.Collections.IDictionary nameToOid; // 0x8
        public System.Collections.IDictionary oidToCurve; // 0x10
        public System.Collections.IDictionary oidToName; // 0x18
        public System.Collections.IList names; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ConfigureBasepoint(){} // RVA: 0x7FFACBC4CDF0
        public void ConfigureCurve(){} // RVA: 0x7FFAC44F81E0
        public void ConfigureCurveGlv(){} // RVA: 0x7FFACBC4CEE0
        public void FromHex(){} // RVA: 0x7FFACBC4CFE0
        public void DefineCurve(){} // RVA: 0x7FFACBC4D090
        public void DefineCurveWithOid(){} // RVA: 0x7FFACBC4D1A0
        public void DefineCurveAlias(){} // RVA: 0x7FFACBC4D360
        public void .cctor(){} // RVA: 0x7FFACBC4D4F0
        public void GetByName(){} // RVA: 0x7FFACBC4EB30
        public void GetByOid(){} // RVA: 0x7FFACBC4EC60
        public void GetOid(){} // RVA: 0x7FFACBC4ED50
        public void GetName(){} // RVA: 0x7FFACBC4EE70
        public void get_Names(){} // RVA: 0x7FFACBC4EF30
    }

}