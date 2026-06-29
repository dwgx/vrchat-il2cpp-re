// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 6
// Methods: 36

namespace ThirdParty.Sentry.Sentry
{
    public class DefaultSentryScopeStateProcessor : Object
    {
        public object TrimFilter;

        // ── Methods ──
        public void Apply(){} // RVA: 0x6D0CFE0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6D0D4C0
    }

    public class DisabledMetricAggregator : Object
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0xB43310
        public void Gauge(){} // RVA: 0xB43310
        public void Distribution(){} // RVA: 0xB43310
        public void Set(){} // RVA: 0xB43310
        public void Timing(){} // RVA: 0xB43310
        public void StartTimer(){} // RVA: 0x6D0D840
        public void FlushAsync(){} // RVA: 0x6D0D8F0
        public void Dispose(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Dsn : Object
    {
        public object _source;
        public object _projectId;
        public object _path;
        public object _secretKey;
        public object _publicKey;
        public object _apiBaseUri;

        // ── Methods ──
        public void get_Source(){} // RVA: 0xB5DBF0
        public void get_ProjectId(){} // RVA: 0xB465B0
        public void get_Path(){} // RVA: 0xB700F0
        public void get_SecretKey(){} // RVA: 0xB70160
        public void get_PublicKey(){} // RVA: 0xD33E60
        public void get_ApiBaseUri(){} // RVA: 0xD05CA0
        public void .ctor(){} // RVA: 0x3F29220
        public void GetStoreEndpointUri(){} // RVA: 0x6D0DB10
        public void GetEnvelopeEndpointUri(){} // RVA: 0x6D0DC30
        public void ToString(){} // RVA: 0xB5DBF0
        public void IsDisabled(){} // RVA: 0x6D0DD50
        public void Parse(){} // RVA: 0x6D0DE50
        public void TryParse(){} // RVA: 0x6D0E390
    }

    public class DsnAttribute : Attribute
    {
        public object _dsn;

        // ── Methods ──
        public void get_Dsn(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class DynamicSamplingContext : Object
    {
        public object _items;
        public object Empty;

        // ── Methods ──
        public void get_Items(){} // RVA: 0xB5DBF0
        public void get_IsEmpty(){} // RVA: 0x6D0E430
        public void .ctor(){} // RVA: 0x6D0E490
        public void ToBaggageHeader(){} // RVA: 0x6D0EBA0
        public void CreateFromBaggageHeader(){} // RVA: 0x6D0EC00
        public void CreateFromTransaction(){} // RVA: 0x6D0F120
        public void CreateFromPropagationContext(){} // RVA: 0x6D0F400
        public void .cctor(){} // RVA: 0x6D0F560
    }

    public class DynamicSamplingContextExtensions : Object
    {
        // ── Methods ──
        public void CreateDynamicSamplingContext(){} // RVA: 0x6D0F770
    }

}