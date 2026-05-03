// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.Http
// Classes: 10
// Methods: 59

namespace ThirdParty.Sentry.Sentry.Internal.Http
{
    public class CachingTransport : Object
    {
        public string EnvelopeFileExt;

        // ── Methods ──
        public void get_InnerTransport(){} // RVA: 0x7FFE81116380
        public void Create(){} // RVA: 0x7FFE86F602B0
        public void .ctor(){} // RVA: 0x7FFE86F60360
        public void Initialize(){} // RVA: 0x7FFE86F60990
        public void CachedTransportBackgroundTaskAsync(){} // RVA: 0x7FFE86F610D0
        public void MoveUnprocessedFilesBackToCache(){} // RVA: 0x7FFE86F61290
        public void EnsureFreeSpaceInCache(){} // RVA: 0x7FFE86F616D0
        public void GetCacheFilePaths(){} // RVA: 0x7FFE86F61930
        public void ProcessCacheAsync(){} // RVA: 0x7FFE86F61A80
        public void IsNetworkError(){} // RVA: 0x7FFE86F61C90
        public void InnerProcessCacheAsync(){} // RVA: 0x7FFE86F61DB0
        public void LogFailureWithDiscard(){} // RVA: 0x7FFE86F62040
        public void TryPrepareNextCacheFileAsync(){} // RVA: 0x7FFE86F62230
        public void StoreToCacheAsync(){} // RVA: 0x7FFE86F62420
        public void GetCacheLength(){} // RVA: 0x7FFE86F626B0
        public void SendEnvelopeAsync(){} // RVA: 0x7FFE86F62700
        public void StopWorkerAsync(){} // RVA: 0x7FFE86F62980
        public void FlushAsync(){} // RVA: 0x7FFE86F62AF0
        public void DisposeAsync(){} // RVA: 0x7FFE86F62B80
        public void Dispose(){} // RVA: 0x7FFE86F62D10
        public void <GetCacheFilePaths>b__24_0(){} // RVA: 0x7FFE86F62F90
    }

    public class DefaultSentryHttpClientFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE86F67D80
        public void SupportsAutomaticDecompression(){} // RVA: 0x7FFE86F68720
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EnvelopeHttpContent : SerializableHttpContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F68750
        public void SerializeToStreamAsync(){} // RVA: 0x7FFE86F68850
        public void SerializeToStream(){} // RVA: 0x7FFE86F68A60
        public void TryComputeLength(){} // RVA: 0x7FFE869A2460
    }

    public class GzipBufferedRequestBodyHandler : DelegatingHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F68E90
        public void SendAsync(){} // RVA: 0x7FFE86F68FD0
        public void <>n__0(){} // RVA: 0x7FFE86EE5560
    }

    public class GzipRequestBodyHandler : DelegatingHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F6A0B0
        public void SendAsync(){} // RVA: 0x7FFE86F6A1F0
    }

    public class HttpTransport : HttpTransportBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F6AF90 | overloaded x2
        public void SendEnvelopeAsync(){} // RVA: 0x7FFE86F6B010
    }

    public class LazyHttpTransport : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F6BF50
        public void SendEnvelopeAsync(){} // RVA: 0x7FFE86F6C130
    }

    public class RateLimit : Object
    {
        public System.Collections.Generic.IReadOnlyList`1<Sentry.Internal.Http.RateLimitCategory> _categories; // 0x10
        public System.Collections.Generic.IReadOnlyList`1<string> _namespaces; // 0x18
        public System.TimeSpan _retryAfter; // 0x20
        public object field_3; // 0x34A

        // ── Methods ──
        public void get_Categories(){} // RVA: 0x7FFE81116380
        public void get_Namespaces(){} // RVA: 0x7FFE810FE7C0
        public void get_IsDefaultNamespace(){} // RVA: 0x7FFE86F6C250
        public void get_RetryAfter(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE86F6C3C0
        public void Parse(){} // RVA: 0x7FFE86F6C470
        public void ParseMany(){} // RVA: 0x7FFE86F6CB80
    }

    public class RateLimitCategory : Object
    {
        public string _name; // 0x10
        public object field_1; // 0x34E

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_IsMatchAll(){} // RVA: 0x7FFE86F6CEA0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Matches(){} // RVA: 0x7FFE86F6CEB0
        public void Equals(){} // RVA: 0x7FFE86F6D200 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86F6D390
    }

    public class RetryAfterHandler : DelegatingHandler
    {
        public Sentry.Infrastructure.ISystemClock _clock; // 0x20

        // ── Methods ──
        public void get_RetryAfterUtcTicks(){} // RVA: 0x7FFE81129130
        public void .ctor(){} // RVA: 0x7FFE86F6D600 | overloaded x2
        public void SendAsync(){} // RVA: 0x7FFE86F6D770
        public void GetRetryAfterTimestamp(){} // RVA: 0x7FFE86F6D9C0
        public void .cctor(){} // RVA: 0x7FFE86F6DE00
        public void <>n__0(){} // RVA: 0x7FFE86EE5560
    }

}