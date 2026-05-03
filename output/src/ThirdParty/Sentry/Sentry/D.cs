// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 40

namespace ThirdParty.Sentry.Sentry
{
    public class DefaultSentryScopeStateProcessor : Object
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFE86DE0920
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86DE0E20
    }

    public class DisabledMetricAggregator : Object
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0x7FFE810FB310
        public void Gauge(){} // RVA: 0x7FFE810FB310
        public void Distribution(){} // RVA: 0x7FFE810FB310
        public void Set(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Timing(){} // RVA: 0x7FFE810FB310
        public void StartTimer(){} // RVA: 0x7FFE86DE11B0
        public void FlushAsync(){} // RVA: 0x7FFE86DE1260
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Dsn : Object
    {
        public string _source; // 0x10
        public string _projectId; // 0x18
        public string _path; // 0x20
        public string _secretKey; // 0x28
        public string _publicKey; // 0x30
        public System.Uri _apiBaseUri; // 0x38

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFE81116380
        public void get_ProjectId(){} // RVA: 0x7FFE810FE7C0
        public void get_Path(){} // RVA: 0x7FFE811290C0
        public void get_SecretKey(){} // RVA: 0x7FFE81129130
        public void get_PublicKey(){} // RVA: 0x7FFE8144E200
        public void get_ApiBaseUri(){} // RVA: 0x7FFE8143BA80
        public void .ctor(){} // RVA: 0x7FFE8411AA10
        public void GetStoreEndpointUri(){} // RVA: 0x7FFE86DE1480
        public void GetEnvelopeEndpointUri(){} // RVA: 0x7FFE86DE15A0
        public void ToString(){} // RVA: 0x7FFE81116380
        public void IsDisabled(){} // RVA: 0x7FFE86DE16C0
        public void Parse(){} // RVA: 0x7FFE86DE17C0
        public void TryParse(){} // RVA: 0x7FFE86DE1CB0
    }

    public class DsnAttribute : Attribute
    {
        public string _dsn; // 0x10

        // ── Methods ──
        public void get_Dsn(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class DynamicSamplingContext : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> _items; // 0x10
        public Sentry.DynamicSamplingContext Empty;

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFE81116380
        public void get_IsEmpty(){} // RVA: 0x7FFE86DE1CE0
        public void .ctor(){} // RVA: 0x7FFE86DE1D40 | overloaded x2
        public void ToBaggageHeader(){} // RVA: 0x7FFE86DE2400
        public void CreateFromBaggageHeader(){} // RVA: 0x7FFE86DE2460
        public void CreateFromTransaction(){} // RVA: 0x7FFE86DE29E0
        public void CreateFromPropagationContext(){} // RVA: 0x7FFE86DE2CC0
        public void .cctor(){} // RVA: 0x7FFE86DE2E20
    }

    public class DynamicSamplingContextExtensions : Object
    {
        // ── Methods ──
        public void CreateDynamicSamplingContext(){} // RVA: 0x7FFE86DE3030 | overloaded x3
    }

}