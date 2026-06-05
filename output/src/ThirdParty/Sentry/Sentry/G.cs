// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 31

namespace ThirdParty.Sentry.Sentry
{
    public class GlobalSessionManager
    {
        // ── Methods ──
        public void get_CurrentSession(){} // RVA: 0x7FFAF30E74D0
        public void get_IsSessionActive(){} // RVA: 0x7FFAF8D52B20
        public void .ctor(){} // RVA: 0x7FFAF8D52B30
        public void PersistSession(){} // RVA: 0x7FFAF8D52D70
        public void DeletePersistedSession(){} // RVA: 0x7FFAF8D537C0
        public void TryRecoverPersistedSession(){} // RVA: 0x7FFAF8D53B80
        public void StartSession(){} // RVA: 0x7FFAF8D541D0
        public void EndSession(){} // RVA: 0x7FFAF8D549C0 | overloaded x3
        public void PauseSession(){} // RVA: 0x7FFAF8D54A40
        public void ResumeSession(){} // RVA: 0x7FFAF8D54C00
        public void ReportError(){} // RVA: 0x7FFAF8D550A0
        public void <.ctor>b__11_0(){} // RVA: 0x7FFAF8D551B0
    }

    public class GraphQLContentExtractor
    {
        // ── Methods ──
        public void ExtractRequestContentAsync(){} // RVA: 0x7FFAF8D55300
        public void ExtractResponseContentAsync(){} // RVA: 0x7FFAF8D554F0
        public void TrySeek(){} // RVA: 0x7FFAF8D556E0
        public void ExtractContentAsync(){} // RVA: 0x7FFAF8D55730
    }

    public class GraphQLHttpRequestException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D570C0 | overloaded x3
    }

    public class GraphQLRequestContent
    {
        // ── Methods ──
        public void get_SerializerOptions(){} // RVA: 0x7FFAF8D57150
        public void get_Items(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF8D57280
        public void get_RequestContent(){} // RVA: 0x7FFAF2D907C0
        public void get_Query(){} // RVA: 0x7FFAF2DBB0C0
        public void get_OperationName(){} // RVA: 0x7FFAF2DBB130
        public void get_OperationType(){} // RVA: 0x7FFAF30E74D0
        public void OperationNameOrFallback(){} // RVA: 0x7FFAF8D579C0
        public void OperationTypeOrFallback(){} // RVA: 0x7FFAF8D57A10
        public void .cctor(){} // RVA: 0x7FFAF8D57A60
    }

}