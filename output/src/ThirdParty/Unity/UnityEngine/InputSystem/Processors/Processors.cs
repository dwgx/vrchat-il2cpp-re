// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Processors
// Classes: 14
// Methods: 51

namespace ThirdParty.Unity.UnityEngine.InputSystem.Processors
{
    public class AxisDeadzoneProcessor : InputProcessor`1
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void get_minOrDefault(){} // RVA: 0x7FFE87A2F580
        public void get_maxOrDefault(){} // RVA: 0x7FFE87A2F600
        public void Process(){} // RVA: 0x7FFE87A2F680
        public void ToString(){} // RVA: 0x7FFE87A2F750
        public void .ctor(){} // RVA: 0x7FFE87A2F840
    }

    public class ClampProcessor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A2F870
        public void ToString(){} // RVA: 0x7FFE87A2F890
        public void .ctor(){} // RVA: 0x7FFE87A2F970
    }

    public class CompensateDirectionProcessor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A2F9A0
        public void ToString(){} // RVA: 0x7FFE87A2FDE0
        public void get_cachingPolicy(){} // RVA: 0x7FFE811EDAF0
        public void .ctor(){} // RVA: 0x7FFE87A2FE20
    }

    public class CompensateRotationProcessor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A2FE50
        public void ToString(){} // RVA: 0x7FFE87A30110
        public void get_cachingPolicy(){} // RVA: 0x7FFE811EDAF0
        public void .ctor(){} // RVA: 0x7FFE87A30150
    }

    public class InvertProcessor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A30180
        public void ToString(){} // RVA: 0x7FFE87A30190
        public void .ctor(){} // RVA: 0x7FFE87A301D0
    }

    public class InvertVector2Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A30200
        public void ToString(){} // RVA: 0x7FFE87A30260
        public void .ctor(){} // RVA: 0x7FFE87A30330
    }

    public class InvertVector3Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A30380
        public void ToString(){} // RVA: 0x7FFE87A303E0
        public void .ctor(){} // RVA: 0x7FFE87A304F0
    }

    public class NormalizeProcessor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A30530
        public void Normalize(){} // RVA: 0x7FFE87A30560
        public void Denormalize(){} // RVA: 0x7FFE87A305F0
        public void ToString(){} // RVA: 0x7FFE87A30640
        public void .ctor(){} // RVA: 0x7FFE87A30760
    }

    public class NormalizeVector2Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A30790
        public void ToString(){} // RVA: 0x7FFE87A307B0
        public void .ctor(){} // RVA: 0x7FFE87A307F0
    }

    public class NormalizeVector3Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A30820
        public void ToString(){} // RVA: 0x7FFE87A30850
        public void .ctor(){} // RVA: 0x7FFE87A30890
    }

    public class ScaleProcessor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A308C0
        public void ToString(){} // RVA: 0x7FFE87A308D0
        public void .ctor(){} // RVA: 0x7FFE87A30980
    }

    public class ScaleVector2Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A309D0
        public void ToString(){} // RVA: 0x7FFE87A30A00
        public void .ctor(){} // RVA: 0x7FFE87A30AE0
    }

    public class ScaleVector3Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE87A30B40
        public void ToString(){} // RVA: 0x7FFE87A30B80
        public void .ctor(){} // RVA: 0x7FFE87A30CA0
    }

    public class StickDeadzoneProcessor : InputProcessor`1
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void get_minOrDefault(){} // RVA: 0x7FFE87A30CF0
        public void get_maxOrDefault(){} // RVA: 0x7FFE87A30D70
        public void Process(){} // RVA: 0x7FFE87A30DF0
        public void GetDeadZoneAdjustedValue(){} // RVA: 0x7FFE87A30F00
        public void ToString(){} // RVA: 0x7FFE87A30FD0
        public void .ctor(){} // RVA: 0x7FFE87A310C0
    }

}