// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Http
// Classes: 3
// Methods: 22

namespace ThirdParty.Sentry.Sentry.Http
{
    public class HttpTransportBase : Object
    {
        public string CategoryLimitResets;
        public Sentry.SentryOptions _options; // 0x10
        public Sentry.Infrastructure.ISystemClock _clock; // 0x18
        public System.Func`2<string,string> _getEnvironmentVariable; // 0x20
        public string _lastDiscardedSessionInitId; // 0x28
        public string _typeName; // 0x30
        public System.Collections.Concurrent.ConcurrentDictionary`2<Sentry.Internal.Http.RateLimitCategory,System.DateTimeOffset> <CategoryLimitResets>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BD44B0
        public void get_CategoryLimitResets(){} // RVA: 0x7FFAC31D0140
        public void ProcessEnvelope(){} // RVA: 0x7FFAC8BD4850
        public void ProcessEnvelopeItem(){} // RVA: 0x7FFAC8BD4DE0
        public void CreateRequest(){} // RVA: 0x7FFAC8BD5AD0
        public void HandleResponse(){} // RVA: 0x7FFAC8BD6060
        public void HandleResponseAsync(){} // RVA: 0x7FFAC8BD61E0
        public void ReadStreamFromHttpContent(){} // RVA: 0x7FFAC8BD6270
        public void ExtractRateLimits(){} // RVA: 0x7FFAC8BD62D0
        public void HandleSuccess(){} // RVA: 0x7FFAC8BD69B0
        public void HandleSuccessAsync(){} // RVA: 0x7FFAC8BD6AE0
        public void LogEnvelopeSent(){} // RVA: 0x7FFAC8BD6D60
        public void HandleFailure(){} // RVA: 0x7FFAC8BD7100
        public void HandleFailureAsync(){} // RVA: 0x7FFAC8BD79B0
        public void IncrementDiscardsForHttpFailure(){} // RVA: 0x7FFAC8BD7C90
        public void LogFailure(){} // RVA: 0x7FFAC8BD8320 | overloaded x2
        public void HasJsonContent(){} // RVA: 0x7FFAC8BD8A20
    }

    public class ISentryHttpClientFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C58F40
    }

    public class SpotlightHttpTransport : HttpTransport
    {
        public Sentry.Extensibility.ITransport _inner; // 0x48
        public Sentry.SentryOptions _options; // 0x50
        public System.Net.Http.HttpClient _httpClient; // 0x58
        public System.Uri _spotlightUrl; // 0x60
        public Sentry.Infrastructure.ISystemClock _clock; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BDA920
        public void CreateRequest(){} // RVA: 0x7FFAC8BDAB20
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAC8BDAE70
    }

}