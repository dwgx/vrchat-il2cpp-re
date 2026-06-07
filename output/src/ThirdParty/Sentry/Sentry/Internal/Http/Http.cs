// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Http
// Classes: 10
// Methods: 59

namespace ThirdParty.Sentry.Sentry.Internal.Http
{
    public class CachingTransport
    {
        // ── Methods ──
        public void get_InnerTransport(){} // RVA: 0x2F8380
        public void Create(){} // RVA: 0x641F8B0
        public void .ctor(){} // RVA: 0x641F960
        public void Initialize(){} // RVA: 0x641FF90
        public void CachedTransportBackgroundTaskAsync(){} // RVA: 0x64206D0
        public void MoveUnprocessedFilesBackToCache(){} // RVA: 0x6420890
        public void EnsureFreeSpaceInCache(){} // RVA: 0x6420CD0
        public void GetCacheFilePaths(){} // RVA: 0x6420F30
        public void ProcessCacheAsync(){} // RVA: 0x6421080
        public void IsNetworkError(){} // RVA: 0x6421290
        public void InnerProcessCacheAsync(){} // RVA: 0x64213B0
        public void LogFailureWithDiscard(){} // RVA: 0x6421640
        public void TryPrepareNextCacheFileAsync(){} // RVA: 0x6421830
        public void StoreToCacheAsync(){} // RVA: 0x6421A20
        public void GetCacheLength(){} // RVA: 0x6421CB0
        public void SendEnvelopeAsync(){} // RVA: 0x6421D00
        public void StopWorkerAsync(){} // RVA: 0x6421F80
        public void FlushAsync(){} // RVA: 0x64220F0
        public void DisposeAsync(){} // RVA: 0x6422180
        public void Dispose(){} // RVA: 0x6422310
        public void <GetCacheFilePaths>b__24_0(){} // RVA: 0x6422590
    }

    public class DefaultSentryHttpClientFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6427380
        public void SupportsAutomaticDecompression(){} // RVA: 0x6427D20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EnvelopeHttpContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6427D50
        public void SerializeToStreamAsync(){} // RVA: 0x6427E50
        public void SerializeToStream(){} // RVA: 0x6428060
        public void TryComputeLength(){} // RVA: 0x5E61620
    }

    public class GzipBufferedRequestBodyHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6428490
        public void SendAsync(){} // RVA: 0x64285D0
        public void <>n__0(){} // RVA: 0x63A4B40
    }

    public class GzipRequestBodyHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64296B0
        public void SendAsync(){} // RVA: 0x64297F0
    }

    public class HttpTransport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x642A590 | overloaded x2
        public void SendEnvelopeAsync(){} // RVA: 0x642A610
    }

    public class LazyHttpTransport : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x642B550
        public void SendEnvelopeAsync(){} // RVA: 0x642B730
    }

    public class RateLimit
    {
        // ── Methods ──
        public void get_Categories(){} // RVA: 0x2F8380
        public void get_Namespaces(){} // RVA: 0x2E07C0
        public void get_IsDefaultNamespace(){} // RVA: 0x642B850
        public void get_RetryAfter(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x642B9C0
        public void Parse(){} // RVA: 0x642BA70
        public void ParseMany(){} // RVA: 0x642C180
    }

    public class RateLimitCategory
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void get_IsMatchAll(){} // RVA: 0x642C4A0
        public void .ctor(){} // RVA: 0x2DEE30
        public void Matches(){} // RVA: 0x642C4B0
        public void Equals(){} // RVA: 0x642C800 | overloaded x2
        public void GetHashCode(){} // RVA: 0x642C990
    }

    public class RetryAfterHandler
    {
        // ── Methods ──
        public void get_RetryAfterUtcTicks(){} // RVA: 0x30B130
        public void .ctor(){} // RVA: 0x642CC00 | overloaded x2
        public void SendAsync(){} // RVA: 0x642CD70
        public void GetRetryAfterTimestamp(){} // RVA: 0x642CFC0
        public void .cctor(){} // RVA: 0x642D400
        public void <>n__0(){} // RVA: 0x63A4B40
    }

}