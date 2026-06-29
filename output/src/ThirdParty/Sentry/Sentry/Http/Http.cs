// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Http
// Classes: 3
// Methods: 21

namespace ThirdParty.Sentry.Sentry.Http
{
    public class HttpTransportBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE22B0D0
        public void get_CategoryLimitResets(){} // RVA: 0x7A8292C30
        public void ProcessEnvelope(){} // RVA: 0x7AE22B460
        public void ProcessEnvelopeItem(){} // RVA: 0x7AE22BA00
        public void CreateRequest(){} // RVA: 0x7AE22C690
        public void HandleResponse(){} // RVA: 0x7AE22CC20
        public void HandleResponseAsync(){} // RVA: 0x7AE22CDA0
        public void ReadStreamFromHttpContent(){} // RVA: 0x7AE22CE30
        public void ExtractRateLimits(){} // RVA: 0x7AE22CE90
        public void HandleSuccess(){} // RVA: 0x7AE22D540
        public void HandleSuccessAsync(){} // RVA: 0x7AE22D670
        public void LogEnvelopeSent(){} // RVA: 0x7AE22D8F0
        public void HandleFailure(){} // RVA: 0x7AE22DC90
        public void HandleFailureAsync(){} // RVA: 0x7AE22E560
        public void IncrementDiscardsForHttpFailure(){} // RVA: 0x7AE22E830
        public void LogFailure(){} // RVA: 0x7AE22EEC0
        public void HasJsonContent(){} // RVA: 0x7AE22F5C0
    }

    public class ISentryHttpClientFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A7E00B20
    }

    public class SpotlightHttpTransport : HttpTransport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2314A0
        public void CreateRequest(){} // RVA: 0x7AE2316A0
        public void SendEnvelopeAsync(){} // RVA: 0x7AE2319F0
    }

}