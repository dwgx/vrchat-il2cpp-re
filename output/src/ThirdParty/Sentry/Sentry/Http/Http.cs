// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Http
// Classes: 3
// Methods: 22

namespace ThirdParty.Sentry.Sentry.Http
{
    public class HttpTransportBase
    {
        public string DefaultErrorMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x643D130
        public void get_CategoryLimitResets(){} // RVA: 0x4976A0
        public void ProcessEnvelope(){} // RVA: 0x643D4D0
        public void ProcessEnvelopeItem(){} // RVA: 0x643DA60
        public void CreateRequest(){} // RVA: 0x643E750
        public void HandleResponse(){} // RVA: 0x643ECE0
        public void HandleResponseAsync(){} // RVA: 0x643EE60
        public void ReadStreamFromHttpContent(){} // RVA: 0x643EEF0
        public void ExtractRateLimits(){} // RVA: 0x643EF50
        public void HandleSuccess(){} // RVA: 0x643F630
        public void HandleSuccessAsync(){} // RVA: 0x643F760
        public void LogEnvelopeSent(){} // RVA: 0x643F9E0
        public void HandleFailure(){} // RVA: 0x643FD80
        public void HandleFailureAsync(){} // RVA: 0x6440630
        public void IncrementDiscardsForHttpFailure(){} // RVA: 0x6440910
        public void LogFailure(){} // RVA: 0x6440FA0 | overloaded x2
        public void HasJsonContent(){} // RVA: 0x64416A0
    }

    public class ISentryHttpClientFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xCE10
    }

    public class SpotlightHttpTransport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64435A0
        public void CreateRequest(){} // RVA: 0x64437A0
        public void SendEnvelopeAsync(){} // RVA: 0x6443AF0
    }

}