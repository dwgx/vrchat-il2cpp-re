// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Http
// Classes: 10
// Methods: 59

namespace ThirdParty.Sentry.Sentry.Internal.Http
{
    public class CachingTransport : Object
    {
        public string InnerTransport;
        public string ProcessingFolder;
        public Sentry.Extensibility.ITransport _innerTransport; // 0x10
        public Sentry.SentryOptions _options; // 0x18
        public bool _failStorage; // 0x20
        public string _isolatedCacheDirectoryPath; // 0x28
        public int _keepCount; // 0x30
        public string _processingDirectoryPath; // 0x38
        public Sentry.Internal.Signal _workerSignal; // 0x40
        public Sentry.Internal.Signal _processingSignal; // 0x48
        public Sentry.Internal.Lock _cacheDirectoryLock; // 0x50
        public System.Threading.CancellationTokenSource _workerCts; // 0x58
        public System.Threading.Tasks.Task _worker; // 0x60
        public System.Threading.ManualResetEventSlim _initCacheResetEvent; // 0x68
        public System.Threading.ManualResetEventSlim _preInitCacheResetEvent; // 0x70
        public Sentry.Internal.IFileSystem _fileSystem; // 0x78

        // ── Methods ──
        public void get_InnerTransport(){} // RVA: 0x7FFAC2F3C380
        public void Create(){} // RVA: 0x7FFAC8BB6C30
        public void .ctor(){} // RVA: 0x7FFAC8BB6CE0
        public void Initialize(){} // RVA: 0x7FFAC8BB7310
        public void CachedTransportBackgroundTaskAsync(){} // RVA: 0x7FFAC8BB7A50
        public void MoveUnprocessedFilesBackToCache(){} // RVA: 0x7FFAC8BB7C10
        public void EnsureFreeSpaceInCache(){} // RVA: 0x7FFAC8BB8050
        public void GetCacheFilePaths(){} // RVA: 0x7FFAC8BB82B0
        public void ProcessCacheAsync(){} // RVA: 0x7FFAC8BB8400
        public void IsNetworkError(){} // RVA: 0x7FFAC8BB8610
        public void InnerProcessCacheAsync(){} // RVA: 0x7FFAC8BB8730
        public void LogFailureWithDiscard(){} // RVA: 0x7FFAC8BB89C0
        public void TryPrepareNextCacheFileAsync(){} // RVA: 0x7FFAC8BB8BB0
        public void StoreToCacheAsync(){} // RVA: 0x7FFAC8BB8DA0
        public void GetCacheLength(){} // RVA: 0x7FFAC8BB9030
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAC8BB9080
        public void StopWorkerAsync(){} // RVA: 0x7FFAC8BB9300
        public void FlushAsync(){} // RVA: 0x7FFAC8BB9470
        public void DisposeAsync(){} // RVA: 0x7FFAC8BB9500
        public void Dispose(){} // RVA: 0x7FFAC8BB9690
        public void <GetCacheFilePaths>b__24_0(){} // RVA: 0x7FFAC8BB9910
    }

    public class DefaultSentryHttpClientFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC8BBE700
        public void SupportsAutomaticDecompression(){} // RVA: 0x7FFAC8BBF0A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EnvelopeHttpContent : SerializableHttpContent
    {
        public Sentry.Protocol.Envelopes.Envelope _envelope; // 0x30
        public Sentry.Extensibility.IDiagnosticLogger _logger; // 0x38
        public Sentry.Infrastructure.ISystemClock _clock; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BBF0D0
        public void SerializeToStreamAsync(){} // RVA: 0x7FFAC8BBF1D0
        public void SerializeToStream(){} // RVA: 0x7FFAC8BBF3E0
        public void TryComputeLength(){} // RVA: 0x7FFAC85F8C90
    }

    public class GzipBufferedRequestBodyHandler : DelegatingHandler
    {
        public string Gzip;
        public 0x6B139788 _compressionLevel; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BBF810
        public void SendAsync(){} // RVA: 0x7FFAC8BBF950
        public void <>n__0(){} // RVA: 0x7FFAC8B3BEF0
    }

    public class GzipRequestBodyHandler : DelegatingHandler
    {
        public string Gzip;
        public 0x6B139788 _compressionLevel; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BC0A30
        public void SendAsync(){} // RVA: 0x7FFAC8BC0B70
    }

    public class HttpTransport : HttpTransportBase
    {
        public System.Net.Http.HttpClient _httpClient; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BC1910 | overloaded x2
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAC8BC1990
    }

    public class LazyHttpTransport : Object
    {
        public System.Lazy`1<Sentry.Internal.Http.HttpTransport> _httpTransport; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BC28D0
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAC8BC2AB0
    }

    public class RateLimit : Object
    {
        public System.Collections.Generic.IReadOnlyList`1<Sentry.Internal.Http.RateLimitCategory> Categories; // 0x10
        public System.Collections.Generic.IReadOnlyList`1<string> Namespaces; // 0x18
        public System.TimeSpan IsDefaultNamespace; // 0x20

        // ── Methods ──
        public void get_Categories(){} // RVA: 0x7FFAC2F3C380
        public void get_Namespaces(){} // RVA: 0x7FFAC2F247C0
        public void get_IsDefaultNamespace(){} // RVA: 0x7FFAC8BC2BD0
        public void get_RetryAfter(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC8BC2D40
        public void Parse(){} // RVA: 0x7FFAC8BC2DF0
        public void ParseMany(){} // RVA: 0x7FFAC8BC3500
    }

    public class RateLimitCategory : Object
    {
        public string Name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_IsMatchAll(){} // RVA: 0x7FFAC8BC3820
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Matches(){} // RVA: 0x7FFAC8BC3830
        public void Equals(){} // RVA: 0x7FFAC8BC3B80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8BC3D10
    }

    public class RetryAfterHandler : DelegatingHandler
    {
        public Sentry.Infrastructure.ISystemClock RetryAfterUtcTicks; // 0x20
        public 0x6B139DB8 TooManyRequests;
        public System.TimeSpan DefaultRetryAfterDelay;
        public long _retryAfterUtcTicks; // 0x28

        // ── Methods ──
        public void get_RetryAfterUtcTicks(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFAC8BC3F80 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFAC8BC40F0
        public void GetRetryAfterTimestamp(){} // RVA: 0x7FFAC8BC4340
        public void .cctor(){} // RVA: 0x7FFAC8BC4780
        public void <>n__0(){} // RVA: 0x7FFAC8B3BEF0
    }

}