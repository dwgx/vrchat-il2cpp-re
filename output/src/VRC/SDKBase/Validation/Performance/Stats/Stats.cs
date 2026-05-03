// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDKBase.Validation.Performance.Stats
// Classes: 3
// Methods: 26

namespace VRC.SDKBase.Validation.Performance.Stats
{
    public class AvatarPerformanceStats : Object
    {
        public float BYTES_TO_MEGABYTES_CONVERSION_FACTOR;
        public string avatarName; // 0x10
        public System.Nullable`1<int> polyCount; // 0x18
        public System.Nullable`1<UnityEngine.Bounds> aabb; // 0x20

        // ── Methods ──
        public void get_downloadSize(){} // RVA: 0x7FFE8A4ED520
        public void get_uncompressedSize(){} // RVA: 0x7FFE8A4ED5C0
        public void BuildAvatarStatAnalyticsList(){} // RVA: 0x7FFE8A4ED660
        public void GetAvatarAnalyticsStatValue(){} // RVA: 0x7FFE8A4EDBD0
        public void GetAvatarAnalyticsStatName(){} // RVA: 0x7FFE8A4EDC50
        public void get_AnalyticsStatsValid(){} // RVA: 0x7FFE86B33050
        public void get_AnalyticsStatNamesCount(){} // RVA: 0x7FFE8A4EDCF0
        public void Initialize(){} // RVA: 0x7FFE8A4EDD70
        public void GetAvatarPerformanceStatsLevelSet(){} // RVA: 0x7FFE8A4EDEF0
        public void .ctor(){} // RVA: 0x7FFE8A4EDF80
        public void Reset(){} // RVA: 0x7FFE8A4EE1A0
        public void CopyTo(){} // RVA: 0x7FFE8A4EE360
        public void GetSnapshot(){} // RVA: 0x7FFE8A4EE770
        public void GetPerformanceRatingForCategory(){} // RVA: 0x7FFE8A4EE7B0
        public void CalculateAllPerformanceRatings(){} // RVA: 0x7FFE8A4EE830
        public void LoadAllPerformanceRatings(){} // RVA: 0x7FFE8A4EEA70
        public void GetPerformanceCategoryDisplayName(){} // RVA: 0x7FFE8A4F0620
        public void GetPerformanceRatingDisplayName(){} // RVA: 0x7FFE8A4F06B0
        public void GetStatLevelForRating(){} // RVA: 0x7FFE8A4F0740
        public void CalculatePerformanceRatingForCategory(){} // RVA: 0x7FFE8A4F0820
        public void CalculatePerformanceRating(){} // RVA: 0x7FFE8A4F2050
        public void ApproxLessOrEqual(){} // RVA: 0x7FFE8A4F2180
        public void ToString(){} // RVA: 0x7FFE8A4F2230
        public void .cctor(){} // RVA: 0x7FFE8A4F3170
    }

    public class AvatarPerformanceStatsLevel : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class AvatarPerformanceStatsLevelSet : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

}