// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Http
// Classes: 10
// Methods: 56

namespace ThirdParty.Sentry.Sentry.Internal.Http
{
    public class CachingTransport : Object
    {
        // ── Methods ──
        public void get_InnerTransport(){} // RVA: 0x7A80F2570
        public void Create(){} // RVA: 0x7AE20D640
        public void .ctor(){} // RVA: 0x7AE20D6F0
        public void Initialize(){} // RVA: 0x7AE20DD40
        public void CachedTransportBackgroundTaskAsync(){} // RVA: 0x7AE20E480
        public void MoveUnprocessedFilesBackToCache(){} // RVA: 0x7AE20E640
        public void EnsureFreeSpaceInCache(){} // RVA: 0x7AE20EA80
        public void GetCacheFilePaths(){} // RVA: 0x7AE20ECE0
        public void ProcessCacheAsync(){} // RVA: 0x7AE20EE30
        public void IsNetworkError(){} // RVA: 0x7AE20F040
        public void InnerProcessCacheAsync(){} // RVA: 0x7AE20F160
        public void LogFailureWithDiscard(){} // RVA: 0x7AE20F3F0
        public void TryPrepareNextCacheFileAsync(){} // RVA: 0x7AE20F5E0
        public void StoreToCacheAsync(){} // RVA: 0x7AE20F7D0
        public void GetCacheLength(){} // RVA: 0x7AE20FA60
        public void SendEnvelopeAsync(){} // RVA: 0x7AE20FAB0
        public void StopWorkerAsync(){} // RVA: 0x7AE20FD30
        public void FlushAsync(){} // RVA: 0x7AE20FEA0
        public void DisposeAsync(){} // RVA: 0x7AE20FF30
        public void Dispose(){} // RVA: 0x7AE2100C0
        public void <GetCacheFilePaths>b__24_0(){} // RVA: 0x7AE210340
    }

    public class DefaultSentryHttpClientFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE215110
        public void SupportsAutomaticDecompression(){} // RVA: 0x7AE215AA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EnvelopeHttpContent : SerializableHttpContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE215AD0
        public void SerializeToStreamAsync(){} // RVA: 0x7AE215BD0
        public void SerializeToStream(){} // RVA: 0x7AE215DE0
        public void TryComputeLength(){} // RVA: 0x7ADC500E0
    }

    public class GzipBufferedRequestBodyHandler : DelegatingHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE216210
        public void SendAsync(){} // RVA: 0x7AE216350
        public void <>n__0(){} // RVA: 0x7AE1916E0
    }

    public class GzipRequestBodyHandler : DelegatingHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE217430
        public void SendAsync(){} // RVA: 0x7AE217570
    }

    public class HttpTransport : HttpTransportBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE218310
        public void SendEnvelopeAsync(){} // RVA: 0x7AE218390
    }

    public class LazyHttpTransport : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2192E0
        public void SendEnvelopeAsync(){} // RVA: 0x7AE2194C0
    }

    public class RateLimit : Object
    {
        // ── Methods ──
        public void get_Categories(){} // RVA: 0x7A80F2570
        public void get_Namespaces(){} // RVA: 0x7A80DA7B0
        public void get_IsDefaultNamespace(){} // RVA: 0x7AE2195E0
        public void get_RetryAfter(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7AE219750
        public void Parse(){} // RVA: 0x7AE219800
        public void ParseMany(){} // RVA: 0x7AE219F10
    }

    public class RateLimitCategory : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_IsMatchAll(){} // RVA: 0x7AE21A230
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Matches(){} // RVA: 0x7AE21A240
        public void Equals(){} // RVA: 0x7AE21A520
        public void GetHashCode(){} // RVA: 0x7AE21A6B0
    }

    public class RetryAfterHandler : DelegatingHandler
    {
        // ── Methods ──
        public void get_RetryAfterUtcTicks(){} // RVA: 0x7A8105330
        public void .ctor(){} // RVA: 0x7AE21A920
        public void SendAsync(){} // RVA: 0x7AE21AA90
        public void GetRetryAfterTimestamp(){} // RVA: 0x7AE21ACE0
        public void .cctor(){} // RVA: 0x7AE21B120
        public void <>n__0(){} // RVA: 0x7AE1916E0
    }

}