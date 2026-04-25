// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.SteamAudio
// Classes: 3
// Methods: 8

namespace ThirdParty.Other.SteamAudio
{
    public class ImpulseResponseSettings : ValueType
    {
        public float duration; // 0x10
        public int order; // 0x14
        public int samplingRate; // 0x18
    }

    public class InstancedMesh : Object
    {
        public UIntPtr mInstancedMesh; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C0C1D0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8C0C270
        public void Release(){} // RVA: 0x7FFAC8C0C2B0
        public void Get(){} // RVA: 0x7FFAC2F3C380
        public void AddToScene(){} // RVA: 0x7FFAC8C0C330
        public void RemoveFromScene(){} // RVA: 0x7FFAC8C0C3E0
        public void UpdateTransform(){} // RVA: 0x7FFAC8C0C490
    }

    public class InstancedMeshSettings : ValueType
    {
        public UIntPtr subScene; // 0x10
        public SteamAudio.Matrix4x4 transform; // 0x18
    }

}