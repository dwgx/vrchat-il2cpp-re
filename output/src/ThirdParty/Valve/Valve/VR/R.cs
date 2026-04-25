// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 7
// Methods: 4

namespace ThirdParty.Valve.Valve.VR
{
    public class RenderModel_ComponentState_t : ValueType
    {
        public Valve.VR.HmdMatrix34_t mTrackingToComponentRenderModel; // 0x10
        public Valve.VR.HmdMatrix34_t mTrackingToComponentLocal; // 0x40
        public uint uProperties; // 0x70
    }

    public class RenderModel_ControllerMode_State_t : ValueType
    {
        public bool bScrollWheelVisible; // 0x10
    }

    public class RenderModel_TextureMap_t : ValueType
    {
        public ushort unWidth; // 0x10
        public ushort unHeight; // 0x12
        public UIntPtr rubTextureMapData; // 0x18
        public 0x6B241310 format; // 0x20
        public ushort unMipLevels; // 0x24
    }

    public class RenderModel_TextureMap_t_Packed : ValueType
    {
        public ushort unWidth; // 0x10
        public ushort unHeight; // 0x12
        public UIntPtr rubTextureMapData; // 0x14
        public 0x6B241310 format; // 0x1C
        public ushort unMipLevels; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9800360
        public void Unpack(){} // RVA: 0x7FFAC9800390
    }

    public class RenderModel_Vertex_t : ValueType
    {
        public Valve.VR.HmdVector3_t vPosition; // 0x10
        public Valve.VR.HmdVector3_t vNormal; // 0x1C
        public float rfTextureCoord0; // 0x28
        public float rfTextureCoord1; // 0x2C
    }

    public class RenderModel_t : ValueType
    {
        public UIntPtr rVertexData; // 0x10
        public uint unVertexCount; // 0x18
        public UIntPtr rIndexData; // 0x20
        public uint unTriangleCount; // 0x28
        public int diffuseTextureId; // 0x2C
    }

    public class RenderModel_t_Packed : ValueType
    {
        public UIntPtr rVertexData; // 0x10
        public uint unVertexCount; // 0x18
        public UIntPtr rIndexData; // 0x1C
        public uint unTriangleCount; // 0x24
        public int diffuseTextureId; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8985F10
        public void Unpack(){} // RVA: 0x7FFAC8985F40
    }

}