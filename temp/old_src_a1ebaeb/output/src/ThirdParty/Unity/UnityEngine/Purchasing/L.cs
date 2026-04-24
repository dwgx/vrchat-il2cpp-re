// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 17

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class LegacyAnalyticsAdapter : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void SendTransactionEvent(){} // RVA: 0x7ffaaf3cc680
        public void SendTransactionFailedEvent(){} // RVA: 0x7ffaaf3cc7d0
    }

    public class LegacyAnalyticsWrapper : Object
    {
        public object m_EmptyAdapter; // 0x3389ECF0
        public object m_AnalyticsAdapter; // 0x17000001

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3cca60
        public void SendTransactionEvent(){} // RVA: 0x7ffaaf3ccc40
        public void SendTransactionFailedEvent(){} // RVA: 0x7ffaaf3cccb0
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7ffaaf3ccd30
        public void get_m_AnalyticsAdapter(){} // RVA: 0x7ffaaf3ccde0
    }

    public class LegacyUnityAnalytics : Object
    {
        // ── Original Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7ffaaf3ccdf0
        public void SendCustomEvent(){} // RVA: 0x7ffaaf3cce40
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class LifecycleNotifier : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnDestroy(){} // RVA: 0x7ffaa8c26ca0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class ListExtension : Object
    {
        // ── Original Methods ──
        public void ToJava(){} // RVA: 0x7ffaa86492c0
        public void ToJavaArray(){} // RVA: 0x7ffaa86492c0
    }

    public class LoggerExtensions : Object
    {
        // ── Original Methods ──
        public void LogIAPWarning(){} // RVA: 0x7ffaaf3d3cd0
        public void LogIAPError(){} // RVA: 0x7ffaaf3d3d50
    }

}