// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Stats
// Classes: 3
// Methods: 26

namespace VRC.SDKBase.Validation.Performance.Stats
{
    public class AvatarPerformanceStats : Object
    {
        public object BYTES_TO_MEGABYTES_CONVERSION_FACTOR;
        public object avatarName;
        public object polyCount;
        public object aabb;
        public object skinnedMeshCount;
        public object meshCount;
        public object materialCount;
        public object animatorCount;
        public object boneCount;
        public object lightCount;
        public object particleSystemCount;
        public object particleTotalCount;
        public object particleMaxMeshPolyCount;
        public object particleTrailsEnabled;
        public object particleCollisionEnabled;
        public object trailRendererCount;
        public object lineRendererCount;
        public object clothCount;
        public object clothMaxVertices;
        public object physicsColliderCount;
        public object physicsRigidbodyCount;
        public object audioSourceCount;
        public object downloadSizeBytes;
        public object uncompressedSizeBytes;
        public object textureMegabytes;
        public object physBone;
        public object contactCount;
        public object contactCompleteCount;
        public object constraintsCount;
        public object constraintDepth;
        public object raycastCount;
        public object _performanceRatingCache;
        public object _analyticsStatsValid;
        public object _analyticsStatValues;
        public object _analyticsStatNames;
        public object _performanceCategories;
        public object _performanceCategoryDisplayNames;
        public object _performanceRatingDisplayNames;
        public object _performanceStatsLevelSet_Windows;
        public object _performanceStatsLevelSet_Mobile;
        public object _performanceStatsLevelSet;

        // ── Methods ──
        public void get_downloadSize(){} // RVA: 0xA75A6F0
        public void get_uncompressedSize(){} // RVA: 0xA75A790
        public void BuildAvatarStatAnalyticsList(){} // RVA: 0xA75A830
        public void GetAvatarAnalyticsStatValue(){} // RVA: 0xA75ADA0
        public void GetAvatarAnalyticsStatName(){} // RVA: 0xA75AE20
        public void get_AnalyticsStatsValid(){} // RVA: 0x6A667F0
        public void get_AnalyticsStatNamesCount(){} // RVA: 0xA75AEC0
        public void Initialize(){} // RVA: 0xA75AF40
        public void GetAvatarPerformanceStatsLevelSet(){} // RVA: 0xA75B0C0
        public void .ctor(){} // RVA: 0xA75B150
        public void Reset(){} // RVA: 0xA75B370
        public void CopyTo(){} // RVA: 0xA75B530
        public void GetSnapshot(){} // RVA: 0xA75B940
        public void GetPerformanceRatingForCategory(){} // RVA: 0xA75B980
        public void CalculateAllPerformanceRatings(){} // RVA: 0xA75BA00
        public void LoadAllPerformanceRatings(){} // RVA: 0xA75BC40
        public void GetPerformanceCategoryDisplayName(){} // RVA: 0xA75D7F0
        public void GetPerformanceRatingDisplayName(){} // RVA: 0xA75D880
        public void GetStatLevelForRating(){} // RVA: 0xA75D910
        public void CalculatePerformanceRatingForCategory(){} // RVA: 0xA75D9F0
        public void CalculatePerformanceRating(){} // RVA: 0xA75F220
        public void ApproxLessOrEqual(){} // RVA: 0xA75F350
        public void ToString(){} // RVA: 0xA75F400
        public void .cctor(){} // RVA: 0xA760360
    }

    public class AvatarPerformanceStatsLevel : ScriptableObject
    {
        public object polyCount;
        public object aabb;
        public object skinnedMeshCount;
        public object meshCount;
        public object materialCount;
        public object animatorCount;
        public object boneCount;
        public object lightCount;
        public object particleSystemCount;
        public object particleTotalCount;
        public object particleMaxMeshPolyCount;
        public object particleTrailsEnabled;
        public object particleCollisionEnabled;
        public object trailRendererCount;
        public object lineRendererCount;
        public object clothCount;
        public object clothMaxVertices;
        public object physicsColliderCount;
        public object physicsRigidbodyCount;
        public object audioSourceCount;
        public object textureMegabytes;
        public object physBone;
        public object contactCount;
        public object constraintsCount;
        public object constraintDepth;
        public object raycastCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class AvatarPerformanceStatsLevelSet : ScriptableObject
    {
        public object excellent;
        public object good;
        public object medium;
        public object poor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xDD1AC0
    }

}