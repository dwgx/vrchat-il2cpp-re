// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Depthkit.Depthkit.Core
// Classes: 3
// Methods: 1

namespace ThirdParty.Depthkit.Depthkit.Core
{
    public class IndexedTriangle : ValueType
    {
        public uint perspective; // 0x10
        public uint vertex0; // 0x14
        public uint vertex1; // 0x18
        public uint vertex2; // 0x1C
    }

    public class PackedTriangle : ValueType
    {
        public Depthkit.Core.Vertex vertex0; // 0x10
        public Depthkit.Core.Vertex vertex1; // 0x40
        public Depthkit.Core.Vertex vertex2; // 0x70
    }

    public class Vertex : ValueType
    {
        public UnityEngine.Vector4 uv; // 0x10
        public UnityEngine.Vector3 position; // 0x20
        public UnityEngine.Vector3 normal; // 0x2C
        public uint perspectiveIndex; // 0x38
        public uint valid; // 0x3C

        // ── Methods ──
        public void Print(){} // RVA: 0x7FFAC4965B10
    }

}