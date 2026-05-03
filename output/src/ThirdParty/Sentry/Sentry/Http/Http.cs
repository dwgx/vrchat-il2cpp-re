// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Http
// Classes: 3
// Methods: 22

namespace ThirdParty.Sentry.Sentry.Http
{
    public class HttpTransportBase : Object
    {
        public string DefaultErrorMessage;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F7DB10
        public void get_CategoryLimitResets(){} // RVA: 0x7FFE8143BA80
        public void ProcessEnvelope(){} // RVA: 0x7FFE86F7DEB0
        public void ProcessEnvelopeItem(){} // RVA: 0x7FFE86F7E440
        public void CreateRequest(){} // RVA: 0x7FFE86F7F130
        public void HandleResponse(){} // RVA: 0x7FFE86F7F6C0
        public void HandleResponseAsync(){} // RVA: 0x7FFE86F7F840
        public void ReadStreamFromHttpContent(){} // RVA: 0x7FFE86F7F8D0
        public void ExtractRateLimits(){} // RVA: 0x7FFE86F7F930
        public void HandleSuccess(){} // RVA: 0x7FFE86F80010
        public void HandleSuccessAsync(){} // RVA: 0x7FFE86F80140
        public void LogEnvelopeSent(){} // RVA: 0x7FFE86F803C0
        public void HandleFailure(){} // RVA: 0x7FFE86F80760
        public void HandleFailureAsync(){} // RVA: 0x7FFE86F81010
        public void IncrementDiscardsForHttpFailure(){} // RVA: 0x7FFE86F812F0
        public void LogFailure(){} // RVA: 0x7FFE86F81980 | overloaded x2
        public void HasJsonContent(){} // RVA: 0x7FFE86F82080
    }

    public class ISentryHttpClientFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E2E390
    }

    public class SpotlightHttpTransport : HttpTransport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F83F80
        public void CreateRequest(){} // RVA: 0x7FFE86F84180
        public void SendEnvelopeAsync(){} // RVA: 0x7FFE86F844D0
    }

}