// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 7
// Methods: 21

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class LegacyAnalyticsAdapter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SendTransactionEvent(){} // RVA: 0x7FFE87D52FC0
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFE87D53110
    }

    public class LegacyAnalyticsWrapper : Object
    {
        public bool m_Enabled; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D533A0
        public void SendTransactionEvent(){} // RVA: 0x7FFE87D53580
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFE87D535F0
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7FFE87D53670
        public void get_m_AnalyticsAdapter(){} // RVA: 0x7FFE87D53720
    }

    public class LegacyUnityAnalytics : Object
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7FFE87D53730
        public void SendCustomEvent(){} // RVA: 0x7FFE87D53780
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LifecycleNotifier : MonoBehaviour
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFE8148FC70
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ListExtension : Object
    {
        // ── Methods ──
        public void ToJava(){} // RVA: 0x7FFE80E2E3D0
        public void ToJavaArray(){} // RVA: 0x7FFE80E2E3D0
    }

    public class LocalizedProductDescription : Object
    {
        public 0x66677484 googleLocale; // 0x10
        public string title; // 0x18

        // ── Methods ──
        public void get_Title(){} // RVA: 0x7FFE87D82B10
        public void get_Description(){} // RVA: 0x7FFE87D82B20
        public void DecodeNonLatinCharacters(){} // RVA: 0x7FFE87D82B30
        public void .ctor(){} // RVA: 0x7FFE87D82CE0
    }

    public class LoggerExtensions : Object
    {
        // ── Methods ──
        public void LogIAPWarning(){} // RVA: 0x7FFE87D5A610
        public void LogIAPError(){} // RVA: 0x7FFE87D5A690
    }

}