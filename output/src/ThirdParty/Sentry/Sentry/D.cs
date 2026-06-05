// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 40

namespace ThirdParty.Sentry.Sentry
{
    public class DefaultSentryScopeStateProcessor
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFAF8D4FEF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8D503F0
    }

    public class DisabledMetricAggregator
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0x7FFAF2D8D310
        public void Gauge(){} // RVA: 0x7FFAF2D8D310
        public void Distribution(){} // RVA: 0x7FFAF2D8D310
        public void Set(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void Timing(){} // RVA: 0x7FFAF2D8D310
        public void StartTimer(){} // RVA: 0x7FFAF8D50780
        public void FlushAsync(){} // RVA: 0x7FFAF8D50830
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Dsn
    {
        public object Dsn;

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAF2DA8380
        public void get_ProjectId(){} // RVA: 0x7FFAF2D907C0
        public void get_Path(){} // RVA: 0x7FFAF2DBB0C0
        public void get_SecretKey(){} // RVA: 0x7FFAF2DBB130
        public void get_PublicKey(){} // RVA: 0x7FFAF30E74D0
        public void get_ApiBaseUri(){} // RVA: 0x7FFAF2F476A0
        public void .ctor(){} // RVA: 0x7FFAF5F5D460
        public void GetStoreEndpointUri(){} // RVA: 0x7FFAF8D50A50
        public void GetEnvelopeEndpointUri(){} // RVA: 0x7FFAF8D50B70
        public void ToString(){} // RVA: 0x7FFAF2DA8380
        public void IsDisabled(){} // RVA: 0x7FFAF8D50C90
        public void Parse(){} // RVA: 0x7FFAF8D50D90
        public void TryParse(){} // RVA: 0x7FFAF8D51280
    }

    public class DsnAttribute
    {
        // ── Methods ──
        public void get_Dsn(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class DynamicSamplingContext
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAF2DA8380
        public void get_IsEmpty(){} // RVA: 0x7FFAF8D512B0
        public void .ctor(){} // RVA: 0x7FFAF8D51310 | overloaded x2
        public void ToBaggageHeader(){} // RVA: 0x7FFAF8D519D0
        public void CreateFromBaggageHeader(){} // RVA: 0x7FFAF8D51A30
        public void CreateFromTransaction(){} // RVA: 0x7FFAF8D51FB0
        public void CreateFromPropagationContext(){} // RVA: 0x7FFAF8D52290
        public void .cctor(){} // RVA: 0x7FFAF8D523F0
    }

    public class DynamicSamplingContextExtensions
    {
        // ── Methods ──
        public void CreateDynamicSamplingContext(){} // RVA: 0x7FFAF8D52600 | overloaded x3
    }

}