// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Http
// Classes: 10
// Methods: 56

namespace ThirdParty.Sentry.Sentry.Internal.Http
{
    public class CachingTransport : Object
    {
        public object EnvelopeFileExt;
        public object ProcessingFolder;
        public object _innerTransport;
        public object _options;
        public object _failStorage;
        public object _isolatedCacheDirectoryPath;
        public object _keepCount;
        public object _processingDirectoryPath;
        public object _workerSignal;
        public object _processingSignal;
        public object _cacheDirectoryLock;
        public object _workerCts;
        public object _worker;
        public object _initCacheResetEvent;
        public object _preInitCacheResetEvent;
        public object _fileSystem;

        // ── Methods ──
        public void get_InnerTransport(){} // RVA: 0xB5DBF0
        public void Create(){} // RVA: 0x6E901A0
        public void .ctor(){} // RVA: 0x6E90250
        public void Initialize(){} // RVA: 0x6E908A0
        public void CachedTransportBackgroundTaskAsync(){} // RVA: 0x6E90FE0
        public void MoveUnprocessedFilesBackToCache(){} // RVA: 0x6E911A0
        public void EnsureFreeSpaceInCache(){} // RVA: 0x6E915E0
        public void GetCacheFilePaths(){} // RVA: 0x6E91840
        public void ProcessCacheAsync(){} // RVA: 0x6E91990
        public void IsNetworkError(){} // RVA: 0x6E91BA0
        public void InnerProcessCacheAsync(){} // RVA: 0x6E91CC0
        public void LogFailureWithDiscard(){} // RVA: 0x6E91F50
        public void TryPrepareNextCacheFileAsync(){} // RVA: 0x6E92140
        public void StoreToCacheAsync(){} // RVA: 0x6E92330
        public void GetCacheLength(){} // RVA: 0x6E925C0
        public void SendEnvelopeAsync(){} // RVA: 0x6E92610
        public void StopWorkerAsync(){} // RVA: 0x6E92890
        public void FlushAsync(){} // RVA: 0x6E92A00
        public void DisposeAsync(){} // RVA: 0x6E92A90
        public void Dispose(){} // RVA: 0x6E92C20
        public void <GetCacheFilePaths>b__24_0(){} // RVA: 0x6E92EA0
    }

    public class DefaultSentryHttpClientFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x6E97A40
        public void SupportsAutomaticDecompression(){} // RVA: 0x6E983D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EnvelopeHttpContent : SerializableHttpContent
    {
        public object _envelope;
        public object _logger;
        public object _clock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E98400
        public void SerializeToStreamAsync(){} // RVA: 0x6E98500
        public void SerializeToStream(){} // RVA: 0x6E98710
        public void TryComputeLength(){} // RVA: 0x68DAA30
    }

    public class GzipBufferedRequestBodyHandler : DelegatingHandler
    {
        public object Gzip;
        public object _compressionLevel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E98B40
        public void SendAsync(){} // RVA: 0x6E98C80
        public void <>n__0(){} // RVA: 0x6E125F0
    }

    public class GzipRequestBodyHandler : DelegatingHandler
    {
        public object Gzip;
        public object _compressionLevel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E99D60
        public void SendAsync(){} // RVA: 0x6E99EA0
    }

    public class HttpTransport : HttpTransportBase
    {
        public object _httpClient;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E9AC40
        public void SendEnvelopeAsync(){} // RVA: 0x6E9ACC0
    }

    public class LazyHttpTransport : Object
    {
        public object _httpTransport;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E9BC10
        public void SendEnvelopeAsync(){} // RVA: 0x6E9BDF0
    }

    public class RateLimit : Object
    {
        public object _categories;
        public object _namespaces;
        public object _retryAfter;

        // ── Methods ──
        public void get_Categories(){} // RVA: 0xB5DBF0
        public void get_Namespaces(){} // RVA: 0xB465B0
        public void get_IsDefaultNamespace(){} // RVA: 0x6E9BF10
        public void get_RetryAfter(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x6E9C080
        public void Parse(){} // RVA: 0x6E9C130
        public void ParseMany(){} // RVA: 0x6E9C840
    }

    public class RateLimitCategory : Object
    {
        public object _name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_IsMatchAll(){} // RVA: 0x6E9CB60
        public void .ctor(){} // RVA: 0xB44D60
        public void Matches(){} // RVA: 0x6E9CBF0
        public void Equals(){} // RVA: 0x6E9CF70
        public void GetHashCode(){} // RVA: 0x6E9D0F0
    }

    public class RetryAfterHandler : DelegatingHandler
    {
        public object _clock;
        public object TooManyRequests;
        public object DefaultRetryAfterDelay;
        public object _retryAfterUtcTicks;

        // ── Methods ──
        public void get_RetryAfterUtcTicks(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0x6E9D360
        public void SendAsync(){} // RVA: 0x6E9D4D0
        public void GetRetryAfterTimestamp(){} // RVA: 0x6E9D720
        public void .cctor(){} // RVA: 0x6E9DB60
        public void <>n__0(){} // RVA: 0x6E125F0
    }

}