// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 13
// Methods: 4

namespace ThirdParty.Valve.Valve.VR
{
    public class HiddenAreaMesh_t : ValueType
    {
        public UIntPtr pVertexData; // 0x10
        public uint unTriangleCount; // 0x18
    }

    public class HmdColor_t : ValueType
    {
        public float r; // 0x10
        public float g; // 0x14
        public float b; // 0x18
        public float a; // 0x1C
    }

    public class HmdMatrix33_t : ValueType
    {
        public float m0; // 0x10
        public float m1; // 0x14
        public float m2; // 0x18
        public float m3; // 0x1C
        public float m4; // 0x20
        public float m5; // 0x24
        public float m6; // 0x28
        public float m7; // 0x2C
        public float m8; // 0x30
    }

    public class HmdMatrix34_t : ValueType
    {
        public float m0; // 0x10
        public float m1; // 0x14
        public float m2; // 0x18
        public float m3; // 0x1C
        public float m4; // 0x20
        public float m5; // 0x24
        public float m6; // 0x28
        public float m7; // 0x2C
        public float m8; // 0x30
        public float m9; // 0x34
        public float m10; // 0x38
        public float m11; // 0x3C

        // ── Methods ──
        public void GetPosition(){} // RVA: 0x7FFD54C1FEB0
        public void IsRotationValid(){} // RVA: 0x7FFD54C1FED0
        public void GetRotation(){} // RVA: 0x7FFD54C1FF30
        public void _copysign(){} // RVA: 0x7FFD54C201C0
    }

    public class HmdMatrix44_t : ValueType
    {
        public float m0; // 0x10
        public float m1; // 0x14
        public float m2; // 0x18
        public float m3; // 0x1C
        public float m4; // 0x20
        public float m5; // 0x24
        public float m6; // 0x28
        public float m7; // 0x2C
        public float m8; // 0x30
        public float m9; // 0x34
        public float m10; // 0x38
        public float m11; // 0x3C
        public float m12; // 0x40
        public float m13; // 0x44
        public float m14; // 0x48
        public float m15; // 0x4C
    }

    public class HmdQuad_t : ValueType
    {
        public VRChaperone vCorners0; // 0x10
        public VRChaperone vCorners1; // 0x1C
        public VRChaperone vCorners2; // 0x28
        public VRChaperone vCorners3; // 0x34
    }

    public class HmdQuaternion_t : ValueType
    {
        public double w; // 0x10
        public double x; // 0x18
        public double y; // 0x20
        public double z; // 0x28
    }

    public class HmdQuaternionf_t : ValueType
    {
        public float w; // 0x10
        public float x; // 0x14
        public float y; // 0x18
        public float z; // 0x1C
    }

    public class HmdRect2_t : ValueType
    {
        public tor vTopLeft; // 0x10
        public tor vBottomRight; // 0x18
    }

    public class HmdVector2_t : ValueType
    {
        public float v0; // 0x10
        public float v1; // 0x14
    }

    public class HmdVector3_t : ValueType
    {
        public float v0; // 0x10
        public float v1; // 0x14
        public float v2; // 0x18
    }

    public class HmdVector3d_t : ValueType
    {
        public double v0; // 0x10
        public double v1; // 0x18
        public double v2; // 0x20
    }

    public class HmdVector4_t : ValueType
    {
        public float v0; // 0x10
        public float v1; // 0x14
        public float v2; // 0x18
        public float v3; // 0x1C
    }

}