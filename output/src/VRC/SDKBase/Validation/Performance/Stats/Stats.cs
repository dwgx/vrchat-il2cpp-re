// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Stats
// Classes: 3
// Methods: 26

namespace VRC.SDKBase.Validation.Performance.Stats
{
    public class AvatarPerformanceStats : Object
    {
        public float downloadSize;
        public string uncompressedSize; // 0x10
        public System.Nullable`1<int> AnalyticsStatsValid; // 0x18
        public System.Nullable`1<UnityEngine.Bounds> AnalyticsStatNamesCount; // 0x20
        public System.Nullable`1<int> skinnedMeshCount; // 0x3C
        public System.Nullable`1<int> meshCount; // 0x44
        public System.Nullable`1<int> materialCount; // 0x4C
        public System.Nullable`1<int> animatorCount; // 0x54
        public System.Nullable`1<int> boneCount; // 0x5C
        public System.Nullable`1<int> lightCount; // 0x64
        public System.Nullable`1<int> particleSystemCount; // 0x6C
        public System.Nullable`1<int> particleTotalCount; // 0x74
        public System.Nullable`1<int> particleMaxMeshPolyCount; // 0x7C
        public System.Nullable`1<bool> particleTrailsEnabled; // 0x84
        public System.Nullable`1<bool> particleCollisionEnabled; // 0x86
        public System.Nullable`1<int> trailRendererCount; // 0x88
        public System.Nullable`1<int> lineRendererCount; // 0x90
        public System.Nullable`1<int> clothCount; // 0x98
        public System.Nullable`1<int> clothMaxVertices; // 0xA0
        public System.Nullable`1<int> physicsColliderCount; // 0xA8
        public System.Nullable`1<int> physicsRigidbodyCount; // 0xB0
        public System.Nullable`1<int> audioSourceCount; // 0xB8
        public System.Nullable`1<int> downloadSizeBytes; // 0xC0
        public System.Nullable`1<int> uncompressedSizeBytes; // 0xC8
        public System.Nullable`1<float> textureMegabytes; // 0xD0
        public System.Nullable`1<PhysBoneStats> physBone; // 0xD8
        public System.Nullable`1<int> contactCount; // 0xEC
        public System.Nullable`1<int> contactCompleteCount; // 0xF4
        public System.Nullable`1<int> constraintsCount; // 0xFC
        public System.Nullable`1<int> constraintDepth; // 0x104
        public System.Nullable`1<int> raycastCount; // 0x10C
        public 0x6B252B90[] _performanceRatingCache; // 0x118
        public bool _analyticsStatsValid; // 0x120
        public System.Collections.Generic.List`1<int> _analyticsStatValues; // 0x128
        public System.Collections.Generic.List`1<string> _analyticsStatNames;
        public System.Collections.Immutable.ImmutableArray`1<0x6B2528D0> _performanceCategories; // 0x8
        public System.Collections.Generic.Dictionary`2<0x6B2528D0,string> _performanceCategoryDisplayNames; // 0x10
        public System.Collections.Generic.Dictionary`2<0x6B252B90,string> _performanceRatingDisplayNames; // 0x18
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevelSet _performanceStatsLevelSet_Windows; // 0x20
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevelSet _performanceStatsLevelSet_Mobile; // 0x28
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevelSet _performanceStatsLevelSet; // 0x130

        // ── Methods ──
        public void get_downloadSize(){} // RVA: 0x7FFACC087550
        public void get_uncompressedSize(){} // RVA: 0x7FFACC0875F0
        public void BuildAvatarStatAnalyticsList(){} // RVA: 0x7FFACC087690
        public void GetAvatarAnalyticsStatValue(){} // RVA: 0x7FFACC087C00
        public void GetAvatarAnalyticsStatName(){} // RVA: 0x7FFACC087C80
        public void get_AnalyticsStatsValid(){} // RVA: 0x7FFAC87898E0
        public void get_AnalyticsStatNamesCount(){} // RVA: 0x7FFACC087D20
        public void Initialize(){} // RVA: 0x7FFACC087DA0
        public void GetAvatarPerformanceStatsLevelSet(){} // RVA: 0x7FFACC087F20
        public void .ctor(){} // RVA: 0x7FFACC087FB0
        public void Reset(){} // RVA: 0x7FFACC0881D0
        public void CopyTo(){} // RVA: 0x7FFACC088390
        public void GetSnapshot(){} // RVA: 0x7FFACC0887A0
        public void GetPerformanceRatingForCategory(){} // RVA: 0x7FFACC0887E0
        public void CalculateAllPerformanceRatings(){} // RVA: 0x7FFACC088860
        public void LoadAllPerformanceRatings(){} // RVA: 0x7FFACC088AA0
        public void GetPerformanceCategoryDisplayName(){} // RVA: 0x7FFACC08A650
        public void GetPerformanceRatingDisplayName(){} // RVA: 0x7FFACC08A6E0
        public void GetStatLevelForRating(){} // RVA: 0x7FFACC08A770
        public void CalculatePerformanceRatingForCategory(){} // RVA: 0x7FFACC08A850
        public void CalculatePerformanceRating(){} // RVA: 0x7FFACC08C080
        public void ApproxLessOrEqual(){} // RVA: 0x7FFACC08C1B0
        public void ToString(){} // RVA: 0x7FFACC08C260
        public void .cctor(){} // RVA: 0x7FFACC08D1A0
    }

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
        public PhysBoneStats physBone; // 0x7C
        public int contactCount; // 0x8C
        public int constraintsCount; // 0x90
        public int constraintDepth; // 0x94
        public int raycastCount; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class AvatarPerformanceStatsLevelSet : ScriptableObject
    {
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevel excellent; // 0x18
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevel good; // 0x20
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevel medium; // 0x28
        public VRC.SDKBase.Validation.Performance.Stats.AvatarPerformanceStatsLevel poor; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

}