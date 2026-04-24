// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Stats
// Classes: 2
// Methods: 2

namespace VRC.SDKBase.Validation.Performance.Stats
{
    public class AvatarPerformanceStatsLevel : ScriptableObject
    {
        public int polyCount; // 0x18
        public UnityEngine.Bounds aabb; // 0x1C
        public int skinnedMeshCount; // 0x34
        public int meshCount; // 0x38
        public int materialCount; // 0x3C
        public int animatorCount; // 0x40
        public int boneCount; // 0x44
        public int lightCount; // 0x48
        public int particleSystemCount; // 0x4C
        public int particleTotalCount; // 0x50
        public int particleMaxMeshPolyCount; // 0x54
        public bool particleTrailsEnabled; // 0x58
        public bool particleCollisionEnabled; // 0x59
        public int trailRendererCount; // 0x5C
        public int lineRendererCount; // 0x60
        public int clothCount; // 0x64
        public int clothMaxVertices; // 0x68
        public int physicsColliderCount; // 0x6C
        public int physicsRigidbodyCount; // 0x70
        public int audioSourceCount; // 0x74
        public float textureMegabytes; // 0x78
        public 0x665B2D48 physBone; // 0x7C
        public int contactCount; // 0x8C
        public int constraintsCount; // 0x90
        public int constraintDepth; // 0x94
        public int raycastCount; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class AvatarPerformanceStatsLevelSet : ScriptableObject
    {
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevel excellent; // 0x18
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevel good; // 0x20
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevel medium; // 0x28
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevel poor; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

}