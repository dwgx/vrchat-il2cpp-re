// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 40

namespace ThirdParty.Sentry.Sentry
{
    public class DefaultSentryScopeStateProcessor
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x629FEF0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x62A03F0
    }

    public class DisabledMetricAggregator
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0x2DD310
        public void Gauge(){} // RVA: 0x2DD310
        public void Distribution(){} // RVA: 0x2DD310
        public void Set(){} // RVA: 0x2DD310 | overloaded x2
        public void Timing(){} // RVA: 0x2DD310
        public void StartTimer(){} // RVA: 0x62A0780
        public void FlushAsync(){} // RVA: 0x62A0830
        public void Dispose(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Dsn
    {
        public string Dsn; // 0x10
        public string <ProjectId>k__BackingField; // 0x18
        public string <Path>k__BackingField; // 0x20
        public string <SecretKey>k__BackingField; // 0x28
        public string <PublicKey>k__BackingField; // 0x30
        public System.Uri <ApiBaseUri>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Source(){} // RVA: 0x2F8380
        public void get_ProjectId(){} // RVA: 0x2E07C0
        public void get_Path(){} // RVA: 0x30B0C0
        public void get_SecretKey(){} // RVA: 0x30B130
        public void get_PublicKey(){} // RVA: 0x6374D0
        public void get_ApiBaseUri(){} // RVA: 0x4976A0
        public void .ctor(){} // RVA: 0x34AD460
        public void GetStoreEndpointUri(){} // RVA: 0x62A0A50
        public void GetEnvelopeEndpointUri(){} // RVA: 0x62A0B70
        public void ToString(){} // RVA: 0x2F8380
        public void IsDisabled(){} // RVA: 0x62A0C90
        public void Parse(){} // RVA: 0x62A0D90
        public void TryParse(){} // RVA: 0x62A1280
    }

    public class DsnAttribute
    {
        public string <Dsn>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Dsn(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class DynamicSamplingContext
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> <Items>k__BackingField; // 0x10
        public Sentry.DynamicSamplingContext Empty;

        // ── Methods ──
        public void get_Items(){} // RVA: 0x2F8380
        public void get_IsEmpty(){} // RVA: 0x62A12B0
        public void .ctor(){} // RVA: 0x62A1310 | overloaded x2
        public void ToBaggageHeader(){} // RVA: 0x62A19D0
        public void CreateFromBaggageHeader(){} // RVA: 0x62A1A30
        public void CreateFromTransaction(){} // RVA: 0x62A1FB0
        public void CreateFromPropagationContext(){} // RVA: 0x62A2290
        public void .cctor(){} // RVA: 0x62A23F0
    }

    public class DynamicSamplingContextExtensions
    {
        // ── Methods ──
        public void CreateDynamicSamplingContext(){} // RVA: 0x62A2600 | overloaded x3
    }

}