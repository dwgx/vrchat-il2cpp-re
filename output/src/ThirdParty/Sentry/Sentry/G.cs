// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 31

namespace ThirdParty.Sentry.Sentry
{
    public class GlobalSessionManager : Object
    {
        public string CurrentSession;
        public Sentry.Infrastructure.ISystemClock IsSessionActive; // 0x10
        public System.Func`2<string,Sentry.PersistedSessionUpdate> _persistedSessionProvider; // 0x18
        public Sentry.SentryOptions _options; // 0x20
        public string _persistenceDirectoryPath; // 0x28
        public Sentry.SentrySession _currentSession; // 0x30
        public System.Nullable`1<System.DateTimeOffset> _lastPauseTimestamp; // 0x38

        // ── Methods ──
        public void get_CurrentSession(){} // RVA: 0x7FFAC31D95E0
        public void get_IsSessionActive(){} // RVA: 0x7FFAC8A39EC0
        public void .ctor(){} // RVA: 0x7FFAC8A39ED0
        public void PersistSession(){} // RVA: 0x7FFAC8A3A110
        public void DeletePersistedSession(){} // RVA: 0x7FFAC8A3AB60
        public void TryRecoverPersistedSession(){} // RVA: 0x7FFAC8A3AF20
        public void StartSession(){} // RVA: 0x7FFAC8A3B570
        public void EndSession(){} // RVA: 0x7FFAC8A3BD60 | overloaded x3
        public void PauseSession(){} // RVA: 0x7FFAC8A3BDE0
        public void ResumeSession(){} // RVA: 0x7FFAC8A3BFA0
        public void ReportError(){} // RVA: 0x7FFAC8A3C440
        public void <.ctor>b__11_0(){} // RVA: 0x7FFAC8A3C550
    }

    public class GraphQLContentExtractor : Object
    {
        // ── Methods ──
        public void ExtractRequestContentAsync(){} // RVA: 0x7FFAC8A3C6A0
        public void ExtractResponseContentAsync(){} // RVA: 0x7FFAC8A3C890
        public void TrySeek(){} // RVA: 0x7FFAC8A3CA80
        public void ExtractContentAsync(){} // RVA: 0x7FFAC8A3CAD0
    }

    public class GraphQLHttpRequestException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8A3E460 | overloaded x3
    }

    public class GraphQLRequestContent : Object
    {
        public System.Text.RegularExpressions.Regex SerializerOptions;
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> Items; // 0x10
        public string RequestContent; // 0x18
        public string Query; // 0x20
        public string OperationName; // 0x28
        public string OperationType; // 0x30

        // ── Methods ──
        public void get_SerializerOptions(){} // RVA: 0x7FFAC8A3E4F0
        public void get_Items(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC8A3E620
        public void get_RequestContent(){} // RVA: 0x7FFAC2F247C0
        public void get_Query(){} // RVA: 0x7FFAC2F4F0C0
        public void get_OperationName(){} // RVA: 0x7FFAC2F4F130
        public void get_OperationType(){} // RVA: 0x7FFAC31D95E0
        public void OperationNameOrFallback(){} // RVA: 0x7FFAC8A3ED60
        public void OperationTypeOrFallback(){} // RVA: 0x7FFAC8A3EDB0
        public void .cctor(){} // RVA: 0x7FFAC8A3EE00
    }

}