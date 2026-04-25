// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 40

namespace ThirdParty.Sentry.Sentry
{
    public class DefaultSentryScopeStateProcessor : Object
    {
        public char[] TrimFilter;

        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFAC8A37290
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8A37790
    }

    public class DisabledMetricAggregator : Object
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0x7FFAC2F21310
        public void Gauge(){} // RVA: 0x7FFAC2F21310
        public void Distribution(){} // RVA: 0x7FFAC2F21310
        public void Set(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Timing(){} // RVA: 0x7FFAC2F21310
        public void StartTimer(){} // RVA: 0x7FFAC8A37B20
        public void FlushAsync(){} // RVA: 0x7FFAC8A37BD0
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Dsn : Object
    {
        public string Source; // 0x10
        public string ProjectId; // 0x18
        public string Path; // 0x20
        public string SecretKey; // 0x28
        public string PublicKey; // 0x30
        public System.Uri ApiBaseUri; // 0x38

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAC2F3C380
        public void get_ProjectId(){} // RVA: 0x7FFAC2F247C0
        public void get_Path(){} // RVA: 0x7FFAC2F4F0C0
        public void get_SecretKey(){} // RVA: 0x7FFAC2F4F130
        public void get_PublicKey(){} // RVA: 0x7FFAC31D95E0
        public void get_ApiBaseUri(){} // RVA: 0x7FFAC31D0140
        public void .ctor(){} // RVA: 0x7FFAC5DB2970
        public void GetStoreEndpointUri(){} // RVA: 0x7FFAC8A37DF0
        public void GetEnvelopeEndpointUri(){} // RVA: 0x7FFAC8A37F10
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void IsDisabled(){} // RVA: 0x7FFAC8A38030
        public void Parse(){} // RVA: 0x7FFAC8A38130
        public void TryParse(){} // RVA: 0x7FFAC8A38620
    }

    public class DsnAttribute : Attribute
    {
        public string Dsn; // 0x10

        // ── Methods ──
        public void get_Dsn(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class DynamicSamplingContext : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> Items; // 0x10
        public Sentry.DynamicSamplingContext IsEmpty;

        // ── Methods ──
        public void get_Items(){} // RVA: 0x7FFAC2F3C380
        public void get_IsEmpty(){} // RVA: 0x7FFAC8A38650
        public void .ctor(){} // RVA: 0x7FFAC8A386B0 | overloaded x2
        public void ToBaggageHeader(){} // RVA: 0x7FFAC8A38D70
        public void CreateFromBaggageHeader(){} // RVA: 0x7FFAC8A38DD0
        public void CreateFromTransaction(){} // RVA: 0x7FFAC8A39350
        public void CreateFromPropagationContext(){} // RVA: 0x7FFAC8A39630
        public void .cctor(){} // RVA: 0x7FFAC8A39790
    }

    public class DynamicSamplingContextExtensions : Object
    {
        // ── Methods ──
        public void CreateDynamicSamplingContext(){} // RVA: 0x7FFAC8A399A0 | overloaded x3
    }

}