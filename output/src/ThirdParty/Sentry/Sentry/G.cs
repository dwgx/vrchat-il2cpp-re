// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 27

namespace ThirdParty.Sentry.Sentry
{
    public class GlobalSessionManager : Object
    {
        public object PersistedSessionFileName;
        public object _clock;
        public object _persistedSessionProvider;
        public object _options;
        public object _persistenceDirectoryPath;
        public object _currentSession;
        public object _lastPauseTimestamp;

        // ── Methods ──
        public void get_CurrentSession(){} // RVA: 0xD33E60
        public void get_IsSessionActive(){} // RVA: 0x6D0FC90
        public void .ctor(){} // RVA: 0x6D0FCA0
        public void PersistSession(){} // RVA: 0x6D0FEE0
        public void DeletePersistedSession(){} // RVA: 0x6D109A0
        public void TryRecoverPersistedSession(){} // RVA: 0x6D10DE0
        public void StartSession(){} // RVA: 0x6D11380
        public void EndSession(){} // RVA: 0x6D11B70
        public void PauseSession(){} // RVA: 0x6D11BF0
        public void ResumeSession(){} // RVA: 0x6D11DB0
        public void ReportError(){} // RVA: 0x6D12240
        public void <.ctor>b__11_0(){} // RVA: 0x6D12350
    }

    public class GraphQLContentExtractor : Object
    {
        // ── Methods ──
        public void ExtractRequestContentAsync(){} // RVA: 0x6D124A0
        public void ExtractResponseContentAsync(){} // RVA: 0x6D12690
        public void TrySeek(){} // RVA: 0x6D12880
        public void ExtractContentAsync(){} // RVA: 0x6D128D0
    }

    public class GraphQLHttpRequestException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D14290
    }

    public class GraphQLRequestContent : Object
    {
        public object Expression;
        public object _items;
        public object _requestContent;
        public object _query;
        public object _operationName;
        public object _operationType;

        // ── Methods ──
        public void get_SerializerOptions(){} // RVA: 0x6D14320
        public void get_Items(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x6D14450
        public void get_RequestContent(){} // RVA: 0xB465B0
        public void get_Query(){} // RVA: 0xB700F0
        public void get_OperationName(){} // RVA: 0xB70160
        public void get_OperationType(){} // RVA: 0xD33E60
        public void OperationNameOrFallback(){} // RVA: 0x6D14B90
        public void OperationTypeOrFallback(){} // RVA: 0x6D14BE0
        public void .cctor(){} // RVA: 0x6D14C30
    }

}