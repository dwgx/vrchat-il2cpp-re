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
        public void get_minOrDefault(){} // RVA: 0x7FFAC9686E20
        public void get_maxOrDefault(){} // RVA: 0x7FFAC9686EA0
        public void Process(){} // RVA: 0x7FFAC9686F20
        public void ToString(){} // RVA: 0x7FFAC9686FF0
        public void .ctor(){} // RVA: 0x7FFAC96870E0
    }

    public class ClampProcessor : InputProcessor`1
    {
        public float min; // 0x10
        public float max; // 0x14

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9687110
        public void ToString(){} // RVA: 0x7FFAC9687130
        public void .ctor(){} // RVA: 0x7FFAC9687210
    }

    public class CompensateDirectionProcessor : InputProcessor`1
    {
        public object cachingPolicy;

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9687240
        public void ToString(){} // RVA: 0x7FFAC9687680
        public void get_cachingPolicy(){} // RVA: 0x7FFAC3013AF0
        public void .ctor(){} // RVA: 0x7FFAC96876C0
    }

    public class CompensateRotationProcessor : InputProcessor`1
    {
        public object cachingPolicy;

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC96876F0
        public void ToString(){} // RVA: 0x7FFAC96879B0
        public void get_cachingPolicy(){} // RVA: 0x7FFAC3013AF0
        public void .ctor(){} // RVA: 0x7FFAC96879F0
    }

    public class InvertProcessor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9687A20
        public void ToString(){} // RVA: 0x7FFAC9687A30
        public void .ctor(){} // RVA: 0x7FFAC9687A70
    }

    public class InvertVector2Processor : InputProcessor`1
    {
        public bool invertX; // 0x10
        public bool invertY; // 0x11

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9687AA0
        public void ToString(){} // RVA: 0x7FFAC9687B00
        public void .ctor(){} // RVA: 0x7FFAC9687BD0
    }

    public class InvertVector3Processor : InputProcessor`1
    {
        public bool invertX; // 0x10
        public bool invertY; // 0x11
        public bool invertZ; // 0x12

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9687C20
        public void ToString(){} // RVA: 0x7FFAC9687C80
        public void .ctor(){} // RVA: 0x7FFAC9687D90
    }

    public class NormalizeProcessor : InputProcessor`1
    {
        public float min; // 0x10
        public float max; // 0x14
        public float zero; // 0x18

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9687DD0
        public void Normalize(){} // RVA: 0x7FFAC9687E00
        public void Denormalize(){} // RVA: 0x7FFAC9687E90
        public void ToString(){} // RVA: 0x7FFAC9687EE0
        public void .ctor(){} // RVA: 0x7FFAC9688000
    }

    public class NormalizeVector2Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9688030
        public void ToString(){} // RVA: 0x7FFAC9688050
        public void .ctor(){} // RVA: 0x7FFAC9688090
    }

    public class NormalizeVector3Processor : InputProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC96880C0
        public void ToString(){} // RVA: 0x7FFAC96880F0
        public void .ctor(){} // RVA: 0x7FFAC9688130
    }

    public class ScaleProcessor : InputProcessor`1
    {
        public float factor; // 0x10

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9688160
        public void ToString(){} // RVA: 0x7FFAC9688170
        public void .ctor(){} // RVA: 0x7FFAC9688220
    }

    public class ScaleVector2Processor : InputProcessor`1
    {
        public float x; // 0x10
        public float y; // 0x14

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC9688270
        public void ToString(){} // RVA: 0x7FFAC96882A0
        public void .ctor(){} // RVA: 0x7FFAC9688380
    }

    public class ScaleVector3Processor : InputProcessor`1
    {
        public float x; // 0x10
        public float y; // 0x14
        public float z; // 0x18

        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC96883E0
        public void ToString(){} // RVA: 0x7FFAC9688420
        public void .ctor(){} // RVA: 0x7FFAC9688540
    }

    public class StickDeadzoneProcessor : InputProcessor`1
    {
        public float minOrDefault; // 0x10
        public float maxOrDefault; // 0x14

        // ── Methods ──
        public void get_minOrDefault(){} // RVA: 0x7FFAC9688590
        public void get_maxOrDefault(){} // RVA: 0x7FFAC9688610
        public void Process(){} // RVA: 0x7FFAC9688690
        public void GetDeadZoneAdjustedValue(){} // RVA: 0x7FFAC96887A0
        public void ToString(){} // RVA: 0x7FFAC9688870
        public void .ctor(){} // RVA: 0x7FFAC9688960
    }

}