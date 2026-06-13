// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 31

namespace ThirdParty.Sentry.Sentry
{
    public class GlobalSessionManager
    {
        public string PersistedSessionFileName;
        public Sentry.Infrastructure.ISystemClock _clock; // 0x10

        // ── Methods ──
        public void get_CurrentSession(){} // RVA: 0x6374D0
        public void get_IsSessionActive(){} // RVA: 0x62A2B20
        public void .ctor(){} // RVA: 0x62A2B30
        public void PersistSession(){} // RVA: 0x62A2D70
        public void DeletePersistedSession(){} // RVA: 0x62A37C0
        public void TryRecoverPersistedSession(){} // RVA: 0x62A3B80
        public void StartSession(){} // RVA: 0x62A41D0
        public void EndSession(){} // RVA: 0x62A49C0 | overloaded x3
        public void PauseSession(){} // RVA: 0x62A4A40
        public void ResumeSession(){} // RVA: 0x62A4C00
        public void ReportError(){} // RVA: 0x62A50A0
        public void <.ctor>b__11_0(){} // RVA: 0x62A51B0
    }

    public class GraphQLContentExtractor
    {
        // ── Methods ──
        public void ExtractRequestContentAsync(){} // RVA: 0x62A5300
        public void ExtractResponseContentAsync(){} // RVA: 0x62A54F0
        public void TrySeek(){} // RVA: 0x62A56E0
        public void ExtractContentAsync(){} // RVA: 0x62A5730
    }

    public class GraphQLHttpRequestException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x62A70C0 | overloaded x3
    }

    public class GraphQLRequestContent
    {
        public System.Text.RegularExpressions.Regex Expression;
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> <Items>k__BackingField; // 0x10
        public string <RequestContent>k__BackingField; // 0x18
        public string <Query>k__BackingField; // 0x20
        public string <OperationName>k__BackingField; // 0x28
        public string <OperationType>k__BackingField; // 0x30

        // ── Methods ──
        public void get_SerializerOptions(){} // RVA: 0x62A7150
        public void get_Items(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x62A7280
        public void get_RequestContent(){} // RVA: 0x2E07C0
        public void get_Query(){} // RVA: 0x30B0C0
        public void get_OperationName(){} // RVA: 0x30B130
        public void get_OperationType(){} // RVA: 0x6374D0
        public void OperationNameOrFallback(){} // RVA: 0x62A79C0
        public void OperationTypeOrFallback(){} // RVA: 0x62A7A10
        public void .cctor(){} // RVA: 0x62A7A60
    }

}