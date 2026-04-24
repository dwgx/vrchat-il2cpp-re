// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Processors
// Classes: 14
// Methods: 51

namespace ThirdParty.Unity.UnityEngine.InputSystem.Processors
{
    public class AxisDeadzoneProcessor : InputProcessor`1
    {
        // ── Original Methods ──
        public void get_minOrDefault(){} // RVA: 0x7ffaaf0a8e00
        public void get_maxOrDefault(){} // RVA: 0x7ffaaf0a8e80
        public void Process(){} // RVA: 0x7ffaaf0a8f00
        public void ToString(){} // RVA: 0x7ffaaf0a8fd0
        public void .ctor(){} // RVA: 0x7ffaaf0a90c0
    }

    public class ClampProcessor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0a90f0
        public void ToString(){} // RVA: 0x7ffaaf0a9110
        public void .ctor(){} // RVA: 0x7ffaaf0a91f0
    }

    public class CompensateDirectionProcessor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0a9220
        public void ToString(){} // RVA: 0x7ffaaf0a9660
        public void get_cachingPolicy(){} // RVA: 0x7ffaa8a24af0
        public void .ctor(){} // RVA: 0x7ffaaf0a96a0
    }

    public class CompensateRotationProcessor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0a96d0
        public void ToString(){} // RVA: 0x7ffaaf0a9990
        public void get_cachingPolicy(){} // RVA: 0x7ffaa8a24af0
        public void .ctor(){} // RVA: 0x7ffaaf0a99d0
    }

    public class InvertProcessor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0a9a00
        public void ToString(){} // RVA: 0x7ffaaf0a9a10
        public void .ctor(){} // RVA: 0x7ffaaf0a9a50
    }

    public class InvertVector2Processor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0a9a80
        public void ToString(){} // RVA: 0x7ffaaf0a9ae0
        public void .ctor(){} // RVA: 0x7ffaaf0a9bb0
    }

    public class InvertVector3Processor : InputProcessor`1
    {
        public object invertZ; // 0x338758E0

        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0a9c00
        public void ToString(){} // RVA: 0x7ffaaf0a9c60
        public void .ctor(){} // RVA: 0x7ffaaf0a9d70
    }

    public class NormalizeProcessor : InputProcessor`1
    {
        public object zero; // 0x3395F050

        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0a9db0
        public void Normalize(){} // RVA: 0x7ffaaf0a9de0
        public void Denormalize(){} // RVA: 0x7ffaaf0a9e70
        public void ToString(){} // RVA: 0x7ffaaf0a9ec0
        public void .ctor(){} // RVA: 0x7ffaaf0a9fe0
    }

    public class NormalizeVector2Processor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0aa010
        public void ToString(){} // RVA: 0x7ffaaf0aa030
        public void .ctor(){} // RVA: 0x7ffaaf0aa070
    }

    public class NormalizeVector3Processor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0aa0a0
        public void ToString(){} // RVA: 0x7ffaaf0aa0d0
        public void .ctor(){} // RVA: 0x7ffaaf0aa110
    }

    public class ScaleProcessor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0aa140
        public void ToString(){} // RVA: 0x7ffaaf0aa150
        public void .ctor(){} // RVA: 0x7ffaaf0aa200
    }

    public class ScaleVector2Processor : InputProcessor`1
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0aa250
        public void ToString(){} // RVA: 0x7ffaaf0aa280
        public void .ctor(){} // RVA: 0x7ffaaf0aa360
    }

    public class ScaleVector3Processor : InputProcessor`1
    {
        public object z; // 0x3358B110

        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaaf0aa3c0
        public void ToString(){} // RVA: 0x7ffaaf0aa400
        public void .ctor(){} // RVA: 0x7ffaaf0aa520
    }

    public class StickDeadzoneProcessor : InputProcessor`1
    {
        // ── Original Methods ──
        public void get_minOrDefault(){} // RVA: 0x7ffaaf0aa570
        public void get_maxOrDefault(){} // RVA: 0x7ffaaf0aa5f0
        public void Process(){} // RVA: 0x7ffaaf0aa670
        public void ToString(){} // RVA: 0x7ffaaf0aa850
        public void .ctor(){} // RVA: 0x7ffaaf0aa940
        // ── Binary Analysis Named ──
        public void GetDeadZoneAdjustedValue(){} // RVA: 0x7ffaaf0aa780
    }

}