// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Processors
// Classes: 14
// Methods: 51

namespace ThirdParty.Unity.UnityEngine.InputSystem.Processors
{
    public class AxisDeadzoneProcessor : InputProcessor`1
    {
        public float minOrDefault; // 0x10
        public float maxOrDefault; // 0x14

        // ── Methods ──
        public void get_minOrDefault(){} // RVA: 0x7FFD54AA6E20
        public void get_maxOrDefault(){} // RVA: 0x7FFD54AA6EA0
        public void Process(){} // RVA: 0x7FFD54AA6F20
        public void ToString(){} // RVA: 0x7FFD54AA6FF0
        public void .ctor(){} // RVA: 0x7FFD54AA70E0
    }

    public class ClampProcessor : InputProcessor`1
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA7110
        public void ToString(){} // RVA: 0x7FFD54AA7130
        public void .ctor(){} // RVA: 0x7FFD54AA7210
    }

    public class CompensateDirectionProcessor : InputProcessor`1
    {
        public object cachingPolicy;

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA7240
        public void ToString(){} // RVA: 0x7FFD54AA7680
        public void get_cachingPolicy(){} // RVA: 0x7FFD4E433AF0
        public void .ctor(){} // RVA: 0x7FFD54AA76C0
    }

    public class CompensateRotationProcessor : InputProcessor`1
    {
        public object cachingPolicy;

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA76F0
        public void ToString(){} // RVA: 0x7FFD54AA79B0
        public void get_cachingPolicy(){} // RVA: 0x7FFD4E433AF0
        public void .ctor(){} // RVA: 0x7FFD54AA79F0
    }

    public class InvertProcessor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA7A20
        public void ToString(){} // RVA: 0x7FFD54AA7A30
        public void .ctor(){} // RVA: 0x7FFD54AA7A70
    }

    public class InvertVector2Processor : InputProcessor`1
    {
        public bool invertX; // 0x10
        public bool invertY; // 0x11

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA7AA0
        public void ToString(){} // RVA: 0x7FFD54AA7B00
        public void .ctor(){} // RVA: 0x7FFD54AA7BD0
    }

    public class InvertVector3Processor : InputProcessor`1
    {
        public bool invertX; // 0x10
        public bool invertY; // 0x11
        public bool invertZ; // 0x12

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA7C20
        public void ToString(){} // RVA: 0x7FFD54AA7C80
        public void .ctor(){} // RVA: 0x7FFD54AA7D90
    }

    public class NormalizeProcessor : InputProcessor`1
    {
        public float min; // 0x10
        public float max; // 0x14
        public float zero; // 0x18

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA7DD0
        public void Normalize(){} // RVA: 0x7FFD54AA7E00
        public void Denormalize(){} // RVA: 0x7FFD54AA7E90
        public void ToString(){} // RVA: 0x7FFD54AA7EE0
        public void .ctor(){} // RVA: 0x7FFD54AA8000
    }

    public class NormalizeVector2Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA8030
        public void ToString(){} // RVA: 0x7FFD54AA8050
        public void .ctor(){} // RVA: 0x7FFD54AA8090
    }

    public class NormalizeVector3Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA80C0
        public void ToString(){} // RVA: 0x7FFD54AA80F0
        public void .ctor(){} // RVA: 0x7FFD54AA8130
    }

    public class ScaleProcessor : InputProcessor`1
    {
        public float factor; // 0x10

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA8160
        public void ToString(){} // RVA: 0x7FFD54AA8170
        public void .ctor(){} // RVA: 0x7FFD54AA8220
    }

    public class ScaleVector2Processor : InputProcessor`1
    {
        public float x; // 0x10
        public float y; // 0x14

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA8270
        public void ToString(){} // RVA: 0x7FFD54AA82A0
        public void .ctor(){} // RVA: 0x7FFD54AA8380
    }

    public class ScaleVector3Processor : InputProcessor`1
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD54AA83E0
        public void ToString(){} // RVA: 0x7FFD54AA8420
        public void .ctor(){} // RVA: 0x7FFD54AA8540
    }

    public class StickDeadzoneProcessor : InputProcessor`1
    {
        public float minOrDefault; // 0x10
        public float maxOrDefault; // 0x14

        // ── Methods ──
        public void get_minOrDefault(){} // RVA: 0x7FFD54AA8590
        public void get_maxOrDefault(){} // RVA: 0x7FFD54AA8610
        public void Process(){} // RVA: 0x7FFD54AA8690
        public void GetDeadZoneAdjustedValue(){} // RVA: 0x7FFD54AA87A0
        public void ToString(){} // RVA: 0x7FFD54AA8870
        public void .ctor(){} // RVA: 0x7FFD54AA8960
    }

}