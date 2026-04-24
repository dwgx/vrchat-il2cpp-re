// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFD4E099B30
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFD4E090A40
        public void SendDiagnostic(){} // RVA: 0x7FFD4E099B30
    }

    public class ITelemetryMetricEvent
    {
        // ── Methods ──
        public void StartMetric(){} // RVA: 0x7FFD4E090980
        public void StopAndSendMetric(){} // RVA: 0x7FFD4E090980
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void SetMetricsInstance(){} // RVA: 0x7FFD4E090A40
        public void SendMetric(){}
    }

    public class ITelemetryMetricsService
    {
        // ── Methods ──
        public void ExecuteTimedAction(){}
    }

    public class IapTelemetryException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD2BE0
    }

    public class TelemetryDiagnosticParams : ValueType
    {
        public string name; // 0x10
        public string exception; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F5CE4B0
    }

    public class TelemetryDiagnostics : Object
    {
        public ÌÍÏÏÏ.? m_TelemetryDiagnosticsInstanceWrapper; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void SendDiagnostic(){} // RVA: 0x7FFD54DD20D0
    }

    public class TelemetryDiagnosticsInstanceWrapper : Object
    {
        public odeState.Available m_Instance; // 0x10
        public Identifiers m_Logger; // 0x18
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ m_Util; // 0x20
        public ÌÍÏÏÏ.chorMin>b__0<ÌÍÏÏÏ.?> m_Queue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD21F0
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFD54DD24C0
        public void SendDiagnostic(){} // RVA: 0x7FFD54DD2640
        public void SendDiagnosticOnMainThread(){} // RVA: 0x7FFD54DD2920
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x7FFD54DD2AB0
    }

    public class TelemetryMetricDefinition : ValueType
    {
        public ÌÍÏÏÏ.OAnchorMax>b__1 MetricType; // 0x10
        public string MetricName; // 0x18

        // ── Methods ──
        public void get_MetricType(){} // RVA: 0x7FFD4F840210
        public void get_MetricName(){} // RVA: 0x7FFD4F840220
        public void .ctor(){} // RVA: 0x7FFD54DD2C40
        public void op_Implicit(){} // RVA: 0x7FFD54DD2CA0
    }

    public class TelemetryMetricDefinitions : Object
    {
        public ÌÍÏÏÏ.ch>b__0 confirmSubscriptionPriceChangeName;
        public ÌÍÏÏÏ.ch>b__0 continuePromotionalPurchasesName; // 0x10
        public ÌÍÏÏÏ.ch>b__0 dequeueQueryProductsTimeName; // 0x20
        public ÌÍÏÏÏ.ch>b__0 dequeueQueryPurchasesTimeName; // 0x30
        public ÌÍÏÏÏ.ch>b__0 fetchStorePromotionOrderName; // 0x40
        public ÌÍÏÏÏ.ch>b__0 fetchStorePromotionVisibilityName; // 0x50
        public ÌÍÏÏÏ.ch>b__0 initPurchaseName; // 0x60
        public ÌÍÏÏÏ.ch>b__0 packageInitTimeName; // 0x70
        public ÌÍÏÏÏ.ch>b__0 presentCodeRedemptionSheetName; // 0x80
        public ÌÍÏÏÏ.ch>b__0 refreshAppReceiptName; // 0x90
        public ÌÍÏÏÏ.ch>b__0 restoreTransactionName; // 0xA0
        public ÌÍÏÏÏ.ch>b__0 retrieveProductsName; // 0xB0
        public ÌÍÏÏÏ.ch>b__0 setStorePromotionOrderName; // 0xC0
        public ÌÍÏÏÏ.ch>b__0 setStorePromotionVisibilityName; // 0xD0
        public ÌÍÏÏÏ.ch>b__0 upgradeDowngradeSubscriptionName; // 0xE0

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54DD2D10
    }

    public class TelemetryMetricEvent : Object
    {
        public ÌÍÏÏÏ.49CD08E395F1704FA3F9B047CEA369CBF35299449D4DF081 m_TelemetryMetricsInstanceWrapper; // 0x10
        public ÌÍÏÏÏ.OAnchorMax>b__1 m_MetricType; // 0x18
        public string m_MetricName; // 0x20
        public ernal_index_icall.mUri m_Stopwatch; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD3B60
        public void StartMetric(){} // RVA: 0x7FFD54DD3CC0
        public void StopAndSendMetric(){} // RVA: 0x7FFD54DD3D90
    }

    public class TelemetryMetricParams : ValueType
    {
        public ÌÍÏÏÏ.OAnchorMax>b__1 type; // 0x10
        public string name; // 0x18
        public double timeSeconds; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD3FD0
    }

    public class TelemetryMetricsInstanceWrapper : Object
    {
        public odeState.cceleration m_Instance; // 0x10
        public Identifiers m_Logger; // 0x18
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ m_Util; // 0x20
        public ÌÍÏÏÏ.chorMin>b__0<ÌÍÏÏÏ.AnchorPosY>b__0> m_Queue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD4030
        public void SetMetricsInstance(){} // RVA: 0x7FFD54DD4300
        public void SendMetric(){} // RVA: 0x7FFD54DD44B0
        public void SendMetricOnMainThread(){} // RVA: 0x7FFD54DD4750
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x7FFD54DD48F0
        public void SendMetricByType(){} // RVA: 0x7FFD54DD4AB0
    }

    public class TelemetryMetricsService : Object
    {
        public ÌÍÏÏÏ.49CD08E395F1704FA3F9B047CEA369CBF35299449D4DF081 m_TelemetryMetricsInstanceWrapper; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void ExecuteTimedAction(){} // RVA: 0x7FFD54DD4BC0
        public void CreateAndStartMetricEvent(){} // RVA: 0x7FFD54DD4CE0
    }

    public class TelemetryQueue`1 : Object
    {
        public ileFullDirectoryInformation<T1717741456> m_SendTelemetryEvent;
        public JapaneseLangName.me<T1717741456> m_Queue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void QueueEvent(){} // RVA: 0x7FFD4E2ADC40
        public void SendQueuedEvents(){} // RVA: 0x7FFD4E090980
    }

}