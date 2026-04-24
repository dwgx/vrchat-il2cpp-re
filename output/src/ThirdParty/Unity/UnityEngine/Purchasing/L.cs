// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 17

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class LegacyAnalyticsAdapter : Object
    {
        public UnityEngine.Purchasing.ILegacyUnityAnalytics m_LegacyAnalytics; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void SendTransactionEvent(){} // RVA: 0x7FFD54DCA720
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFD54DCA870
    }

    public class LegacyAnalyticsWrapper : Object
    {
        public bool m_AnalyticsAdapter; // 0x10
        public UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAdapter; // 0x18
        public UnityEngine.Purchasing.IAnalyticsAdapter m_EmptyAdapter; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DCAB00
        public void SendTransactionEvent(){} // RVA: 0x7FFD54DCACE0
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFD54DCAD50
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7FFD54DCADD0
        public void get_m_AnalyticsAdapter(){} // RVA: 0x7FFD54DCAE80
    }

    public class LegacyUnityAnalytics : Object
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7FFD54DCAE90
        public void SendCustomEvent(){} // RVA: 0x7FFD54DCAEE0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class LifecycleNotifier : MonoBehaviour
    {
        public System.Action OnDestroyCallback; // 0x20

        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFD4E6232C0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class ListExtension : Object
    {
        // ── Methods ──
        public void ToJava(){} // RVA: 0x7FFD4E078F80
        public void ToJavaArray(){} // RVA: 0x7FFD4E078F80
    }

    public class LoggerExtensions : Object
    {
        // ── Methods ──
        public void LogIAPWarning(){} // RVA: 0x7FFD54DD1D70
        public void LogIAPError(){} // RVA: 0x7FFD54DD1DF0
    }

}