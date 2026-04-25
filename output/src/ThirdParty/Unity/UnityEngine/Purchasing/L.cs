// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 7
// Methods: 21

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class LegacyAnalyticsAdapter : Object
    {
        public UnityEngine.Purchasing.ILegacyUnityAnalytics m_LegacyAnalytics; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SendTransactionEvent(){} // RVA: 0x7FFAC99AA720
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFAC99AA870
    }

    public class LegacyAnalyticsWrapper : Object
    {
        public bool m_AnalyticsAdapter; // 0x10
        public UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAdapter; // 0x18
        public UnityEngine.Purchasing.IAnalyticsAdapter m_EmptyAdapter; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99AAB00
        public void SendTransactionEvent(){} // RVA: 0x7FFAC99AACE0
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFAC99AAD50
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7FFAC99AADD0
        public void get_m_AnalyticsAdapter(){} // RVA: 0x7FFAC99AAE80
    }

    public class LegacyUnityAnalytics : Object
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7FFAC99AAE90
        public void SendCustomEvent(){} // RVA: 0x7FFAC99AAEE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class LifecycleNotifier : MonoBehaviour
    {
        public System.Action OnDestroyCallback; // 0x20

        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFAC32032C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ListExtension : Object
    {
        // ── Methods ──
        public void ToJava(){} // RVA: 0x7FFAC2C58F80
        public void ToJavaArray(){} // RVA: 0x7FFAC2C58F80
    }

    public class LocalizedProductDescription : Object
    {
        public 0x6B27D698 Title; // 0x10
        public string Description; // 0x18
        public string description; // 0x20

        // ── Methods ──
        public void get_Title(){} // RVA: 0x7FFAC99DA270
        public void get_Description(){} // RVA: 0x7FFAC99DA280
        public void DecodeNonLatinCharacters(){} // RVA: 0x7FFAC99DA290
        public void .ctor(){} // RVA: 0x7FFAC99DA440
    }

    public class LoggerExtensions : Object
    {
        // ── Methods ──
        public void LogIAPWarning(){} // RVA: 0x7FFAC99B1D70
        public void LogIAPError(){} // RVA: 0x7FFAC99B1DF0
    }

}