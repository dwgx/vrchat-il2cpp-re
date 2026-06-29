// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 27

namespace ThirdParty.Sentry.Sentry
{
    public class GlobalSessionManager : Object
    {
        // ── Methods ──
        public void get_CurrentSession(){} // RVA: 0x7A83F69F0
        public void get_IsSessionActive(){} // RVA: 0x7AE08EA10
        public void .ctor(){} // RVA: 0x7AE08EA20
        public void PersistSession(){} // RVA: 0x7AE08EC60
        public void DeletePersistedSession(){} // RVA: 0x7AE08F6D0
        public void TryRecoverPersistedSession(){} // RVA: 0x7AE08FA90
        public void StartSession(){} // RVA: 0x7AE0900D0
        public void EndSession(){} // RVA: 0x7AE090870
        public void PauseSession(){} // RVA: 0x7AE0908F0
        public void ResumeSession(){} // RVA: 0x7AE090AB0
        public void ReportError(){} // RVA: 0x7AE090F40
        public void <.ctor>b__11_0(){} // RVA: 0x7AE091050
    }

    public class GraphQLContentExtractor : Object
    {
        // ── Methods ──
        public void ExtractRequestContentAsync(){} // RVA: 0x7AE0911A0
        public void ExtractResponseContentAsync(){} // RVA: 0x7AE091390
        public void TrySeek(){} // RVA: 0x7AE091580
        public void ExtractContentAsync(){} // RVA: 0x7AE0915D0
    }

    public class GraphQLHttpRequestException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE092F90
    }

    public class GraphQLRequestContent : Object
    {
        // ── Methods ──
        public void get_SerializerOptions(){} // RVA: 0x7AE093020
        public void get_Items(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7AE093150
        public void get_RequestContent(){} // RVA: 0x7A80DA7B0
        public void get_Query(){} // RVA: 0x7A81052C0
        public void get_OperationName(){} // RVA: 0x7A8105330
        public void get_OperationType(){} // RVA: 0x7A83F69F0
        public void OperationNameOrFallback(){} // RVA: 0x7AE093890
        public void OperationTypeOrFallback(){} // RVA: 0x7AE0938E0
        public void .cctor(){} // RVA: 0x7AE093930
    }

}