// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Http
// Classes: 10
// Methods: 59

namespace ThirdParty.Sentry.Sentry.Internal.Http
{
    public class CachingTransport
    {
        // ── Methods ──
        public void get_InnerTransport(){} // RVA: 0x7FFAF2DA8380
        public void Create(){} // RVA: 0x7FFAF8ECF8B0
        public void .ctor(){} // RVA: 0x7FFAF8ECF960
        public void Initialize(){} // RVA: 0x7FFAF8ECFF90
        public void CachedTransportBackgroundTaskAsync(){} // RVA: 0x7FFAF8ED06D0
        public void MoveUnprocessedFilesBackToCache(){} // RVA: 0x7FFAF8ED0890
        public void EnsureFreeSpaceInCache(){} // RVA: 0x7FFAF8ED0CD0
        public void GetCacheFilePaths(){} // RVA: 0x7FFAF8ED0F30
        public void ProcessCacheAsync(){} // RVA: 0x7FFAF8ED1080
        public void IsNetworkError(){} // RVA: 0x7FFAF8ED1290
        public void InnerProcessCacheAsync(){} // RVA: 0x7FFAF8ED13B0
        public void LogFailureWithDiscard(){} // RVA: 0x7FFAF8ED1640
        public void TryPrepareNextCacheFileAsync(){} // RVA: 0x7FFAF8ED1830
        public void StoreToCacheAsync(){} // RVA: 0x7FFAF8ED1A20
        public void GetCacheLength(){} // RVA: 0x7FFAF8ED1CB0
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAF8ED1D00
        public void StopWorkerAsync(){} // RVA: 0x7FFAF8ED1F80
        public void FlushAsync(){} // RVA: 0x7FFAF8ED20F0
        public void DisposeAsync(){} // RVA: 0x7FFAF8ED2180
        public void Dispose(){} // RVA: 0x7FFAF8ED2310
        public void <GetCacheFilePaths>b__24_0(){} // RVA: 0x7FFAF8ED2590
    }

    public class DefaultSentryHttpClientFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF8ED7380
        public void SupportsAutomaticDecompression(){} // RVA: 0x7FFAF8ED7D20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EnvelopeHttpContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8ED7D50
        public void SerializeToStreamAsync(){} // RVA: 0x7FFAF8ED7E50
        public void SerializeToStream(){} // RVA: 0x7FFAF8ED8060
        public void TryComputeLength(){} // RVA: 0x7FFAF8911620
    }

    public class GzipBufferedRequestBodyHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8ED8490
        public void SendAsync(){} // RVA: 0x7FFAF8ED85D0
        public void <>n__0(){} // RVA: 0x7FFAF8E54B40
    }

    public class GzipRequestBodyHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8ED96B0
        public void SendAsync(){} // RVA: 0x7FFAF8ED97F0
    }

    public class HttpTransport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EDA590 | overloaded x2
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAF8EDA610
    }

    public class LazyHttpTransport : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EDB550
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAF8EDB730
    }

    public class RateLimit
    {
        // ── Methods ──
        public void get_Categories(){} // RVA: 0x7FFAF2DA8380
        public void get_Namespaces(){} // RVA: 0x7FFAF2D907C0
        public void get_IsDefaultNamespace(){} // RVA: 0x7FFAF8EDB850
        public void get_RetryAfter(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF8EDB9C0
        public void Parse(){} // RVA: 0x7FFAF8EDBA70
        public void ParseMany(){} // RVA: 0x7FFAF8EDC180
    }

    public class RateLimitCategory
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_IsMatchAll(){} // RVA: 0x7FFAF8EDC4A0
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Matches(){} // RVA: 0x7FFAF8EDC4B0
        public void Equals(){} // RVA: 0x7FFAF8EDC800 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8EDC990
    }

    public class RetryAfterHandler
    {
        // ── Methods ──
        public void get_RetryAfterUtcTicks(){} // RVA: 0x7FFAF2DBB130
        public void .ctor(){} // RVA: 0x7FFAF8EDCC00 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFAF8EDCD70
        public void GetRetryAfterTimestamp(){} // RVA: 0x7FFAF8EDCFC0
        public void .cctor(){} // RVA: 0x7FFAF8EDD400
        public void <>n__0(){} // RVA: 0x7FFAF8E54B40
    }

}