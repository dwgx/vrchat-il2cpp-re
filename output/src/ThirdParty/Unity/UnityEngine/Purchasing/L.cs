// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 7
// Methods: 21

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class LegacyAnalyticsAdapter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void SendTransactionEvent(){} // RVA: 0x7212E20
        public void SendTransactionFailedEvent(){} // RVA: 0x7212F70
    }

    public class LegacyAnalyticsWrapper
    {
        public bool m_Enabled; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7213200
        public void SendTransactionEvent(){} // RVA: 0x72133E0
        public void SendTransactionFailedEvent(){} // RVA: 0x7213450
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x72134D0
        public void get_m_AnalyticsAdapter(){} // RVA: 0x7213580
    }

    public class LegacyUnityAnalytics
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7213590
        public void SendCustomEvent(){} // RVA: 0x72135E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class LifecycleNotifier
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x68B300
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class ListExtension
    {
        // ── Methods ──
        public void ToJava(){} // RVA: 0xCE50
        public void ToJavaArray(){} // RVA: 0xCE50
    }

    public class LocalizedProductDescription
    {
        public 0x6599EFF8 googleLocale; // 0x10
        public string title; // 0x18

        // ── Methods ──
        public void get_Title(){} // RVA: 0x7242970
        public void get_Description(){} // RVA: 0x7242980
        public void DecodeNonLatinCharacters(){} // RVA: 0x7242990
        public void .ctor(){} // RVA: 0x7242B40
    }

    public class LoggerExtensions
    {
        // ── Methods ──
        public void LogIAPWarning(){} // RVA: 0x721A470
        public void LogIAPError(){} // RVA: 0x721A4F0
    }

}