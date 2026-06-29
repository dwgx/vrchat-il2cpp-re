// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 36

namespace ThirdParty.Sentry.Sentry
{
    public class DefaultSentryScopeStateProcessor : Object
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7AE08BDF0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE08C2F0
    }

    public class DisabledMetricAggregator : Object
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0x7A80D7310
        public void Gauge(){} // RVA: 0x7A80D7310
        public void Distribution(){} // RVA: 0x7A80D7310
        public void Set(){} // RVA: 0x7A80D7310
        public void Timing(){} // RVA: 0x7A80D7310
        public void StartTimer(){} // RVA: 0x7AE08C680
        public void FlushAsync(){} // RVA: 0x7AE08C730
        public void Dispose(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Dsn : Object
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7A80F2570
        public void get_ProjectId(){} // RVA: 0x7A80DA7B0
        public void get_Path(){} // RVA: 0x7A81052C0
        public void get_SecretKey(){} // RVA: 0x7A8105330
        public void get_PublicKey(){} // RVA: 0x7A83F69F0
        public void get_ApiBaseUri(){} // RVA: 0x7A8292C30
        public void .ctor(){} // RVA: 0x7AB2A24F0
        public void GetStoreEndpointUri(){} // RVA: 0x7AE08C950
        public void GetEnvelopeEndpointUri(){} // RVA: 0x7AE08CA70
        public void ToString(){} // RVA: 0x7A80F2570
        public void IsDisabled(){} // RVA: 0x7AE08CB90
        public void Parse(){} // RVA: 0x7AE08CC90
        public void TryParse(){} // RVA: 0x7AE08D180
    }

    public class DsnAttribute : Attribute
    {
        // ── Methods ──
        public void get_Dsn(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class DynamicSamplingContext : Object
    {
        // ── Methods ──
        public void get_Items(){} // RVA: 0x7A80F2570
        public void get_IsEmpty(){} // RVA: 0x7AE08D1B0
        public void .ctor(){} // RVA: 0x7AE08D210
        public void ToBaggageHeader(){} // RVA: 0x7AE08D8D0
        public void CreateFromBaggageHeader(){} // RVA: 0x7AE08D930
        public void CreateFromTransaction(){} // RVA: 0x7AE08DEA0
        public void CreateFromPropagationContext(){} // RVA: 0x7AE08E180
        public void .cctor(){} // RVA: 0x7AE08E2E0
    }

    public class DynamicSamplingContextExtensions : Object
    {
        // ── Methods ──
        public void CreateDynamicSamplingContext(){} // RVA: 0x7AE08E4F0
    }

}