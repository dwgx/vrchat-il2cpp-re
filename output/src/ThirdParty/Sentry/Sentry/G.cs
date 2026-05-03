// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 31

namespace ThirdParty.Sentry.Sentry
{
    public class GlobalSessionManager : Object
    {
        public string PersistedSessionFileName;
        public Sentry.Infrastructure.ISystemClock _clock; // 0x10

        // ── Methods ──
        public void get_CurrentSession(){} // RVA: 0x7FFE8144E200
        public void get_IsSessionActive(){} // RVA: 0x7FFE86DE3550
        public void .ctor(){} // RVA: 0x7FFE86DE3560
        public void PersistSession(){} // RVA: 0x7FFE86DE37A0
        public void DeletePersistedSession(){} // RVA: 0x7FFE86DE41F0
        public void TryRecoverPersistedSession(){} // RVA: 0x7FFE86DE45B0
        public void StartSession(){} // RVA: 0x7FFE86DE4C00
        public void EndSession(){} // RVA: 0x7FFE86DE53F0 | overloaded x3
        public void PauseSession(){} // RVA: 0x7FFE86DE5470
        public void ResumeSession(){} // RVA: 0x7FFE86DE5630
        public void ReportError(){} // RVA: 0x7FFE86DE5AD0
        public void <.ctor>b__11_0(){} // RVA: 0x7FFE86DE5BE0
    }

    public class GraphQLContentExtractor : Object
    {
        // ── Methods ──
        public void ExtractRequestContentAsync(){} // RVA: 0x7FFE86DE5D30
        public void ExtractResponseContentAsync(){} // RVA: 0x7FFE86DE5F20
        public void TrySeek(){} // RVA: 0x7FFE86DE6110
        public void ExtractContentAsync(){} // RVA: 0x7FFE86DE6160
    }

    public class GraphQLHttpRequestException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86DE7AF0 | overloaded x3
    }

    public class GraphQLRequestContent : Object
    {
        public System.Text.RegularExpressions.Regex Expression;
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> _items; // 0x10
        public string _requestContent; // 0x18
        public string _query; // 0x20
        public string _operationName; // 0x28
        public string _operationType; // 0x30

        // ── Methods ──
        public void get_SerializerOptions(){} // RVA: 0x7FFE86DE7B80
        public void get_Items(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE86DE7CB0
        public void get_RequestContent(){} // RVA: 0x7FFE810FE7C0
        public void get_Query(){} // RVA: 0x7FFE811290C0
        public void get_OperationName(){} // RVA: 0x7FFE81129130
        public void get_OperationType(){} // RVA: 0x7FFE8144E200
        public void OperationNameOrFallback(){} // RVA: 0x7FFE86DE83F0
        public void OperationTypeOrFallback(){} // RVA: 0x7FFE86DE8440
        public void .cctor(){} // RVA: 0x7FFE86DE8490
    }

}