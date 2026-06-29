// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Http
// Classes: 3
// Methods: 21

namespace ThirdParty.Sentry.Sentry.Http
{
    public class HttpTransportBase : Object
    {
        public object DefaultErrorMessage;
        public object _options;
        public object _clock;
        public object _getEnvironmentVariable;
        public object _lastDiscardedSessionInitId;
        public object _typeName;
        public object _categoryLimitResets;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EADB90
        public void get_CategoryLimitResets(){} // RVA: 0xD05CA0
        public void ProcessEnvelope(){} // RVA: 0x6EADF20
        public void ProcessEnvelopeItem(){} // RVA: 0x6EAE4C0
        public void CreateRequest(){} // RVA: 0x6EAF1D0
        public void HandleResponse(){} // RVA: 0x6EAF7A0
        public void HandleResponseAsync(){} // RVA: 0x6EAF920
        public void ReadStreamFromHttpContent(){} // RVA: 0x6EAF9B0
        public void ExtractRateLimits(){} // RVA: 0x6EAFA10
        public void HandleSuccess(){} // RVA: 0x6EB00C0
        public void HandleSuccessAsync(){} // RVA: 0x6EB01F0
        public void LogEnvelopeSent(){} // RVA: 0x6EB0470
        public void HandleFailure(){} // RVA: 0x6EB0810
        public void HandleFailureAsync(){} // RVA: 0x6EB10E0
        public void IncrementDiscardsForHttpFailure(){} // RVA: 0x6EB13B0
        public void LogFailure(){} // RVA: 0x6EB1A40
        public void HasJsonContent(){} // RVA: 0x6EB2120
    }

    public class ISentryHttpClientFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x87C540
    }

    public class SpotlightHttpTransport : HttpTransport
    {
        public object _inner;
        public object _options;
        public object _httpClient;
        public object _spotlightUrl;
        public object _clock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EB4000
        public void CreateRequest(){} // RVA: 0x6EB4200
        public void SendEnvelopeAsync(){} // RVA: 0x6EB4550
    }

}