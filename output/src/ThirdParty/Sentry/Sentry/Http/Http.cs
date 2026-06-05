// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Http
// Classes: 3
// Methods: 22

namespace ThirdParty.Sentry.Sentry.Http
{
    public class HttpTransportBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EED130
        public void get_CategoryLimitResets(){} // RVA: 0x7FFAF2F476A0
        public void ProcessEnvelope(){} // RVA: 0x7FFAF8EED4D0
        public void ProcessEnvelopeItem(){} // RVA: 0x7FFAF8EEDA60
        public void CreateRequest(){} // RVA: 0x7FFAF8EEE750
        public void HandleResponse(){} // RVA: 0x7FFAF8EEECE0
        public void HandleResponseAsync(){} // RVA: 0x7FFAF8EEEE60
        public void ReadStreamFromHttpContent(){} // RVA: 0x7FFAF8EEEEF0
        public void ExtractRateLimits(){} // RVA: 0x7FFAF8EEEF50
        public void HandleSuccess(){} // RVA: 0x7FFAF8EEF630
        public void HandleSuccessAsync(){} // RVA: 0x7FFAF8EEF760
        public void LogEnvelopeSent(){} // RVA: 0x7FFAF8EEF9E0
        public void HandleFailure(){} // RVA: 0x7FFAF8EEFD80
        public void HandleFailureAsync(){} // RVA: 0x7FFAF8EF0630
        public void IncrementDiscardsForHttpFailure(){} // RVA: 0x7FFAF8EF0910
        public void LogFailure(){} // RVA: 0x7FFAF8EF0FA0 | overloaded x2
        public void HasJsonContent(){} // RVA: 0x7FFAF8EF16A0
    }

    public class ISentryHttpClientFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF2ABCE10
    }

    public class SpotlightHttpTransport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EF35A0
        public void CreateRequest(){} // RVA: 0x7FFAF8EF37A0
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAF8EF3AF0
    }

}