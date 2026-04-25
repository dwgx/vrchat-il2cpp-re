// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 7
// Methods: 4

namespace ThirdParty.Other.OVR.OpenVR
{
    public class RenderModel_ComponentState_t : ValueType
    {
        public OVR.OpenVR.HmdMatrix34_t mTrackingToComponentRenderModel; // 0x10
        public OVR.OpenVR.HmdMatrix34_t mTrackingToComponentLocal; // 0x40
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
    }

    public class RenderModel_TextureMap_t_Packed : ValueType
    {
        public ushort unWidth; // 0x10
        public ushort unHeight; // 0x12
        public UIntPtr rubTextureMapData; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8985ED0
        public void Unpack(){} // RVA: 0x7FFAC8985EF0
    }

    public class RenderModel_Vertex_t : ValueType
    {
        public OVR.OpenVR.HmdVector3_t vPosition; // 0x10
        public OVR.OpenVR.HmdVector3_t vNormal; // 0x1C
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