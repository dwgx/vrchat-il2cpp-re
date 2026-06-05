// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 13
// Methods: 151

namespace ThirdParty.DotNet.System.Net
{
    public class CaseInsensitiveAscii
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAF95D61F0
        public void Compare(){} // RVA: 0x7FFAF95D6300
        public void FastGetHashCode(){} // RVA: 0x7FFAF95D64C0
        public void Equals(){} // RVA: 0x7FFAF95D65A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF95D6730
    }

    public class ChunkedInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95F73F0
        public void Read(){} // RVA: 0x7FFAF95F75C0
        public void BeginRead(){} // RVA: 0x7FFAF95F7610
        public void OnRead(){} // RVA: 0x7FFAF95F7A50
        public void EndRead(){} // RVA: 0x7FFAF95F7D70
        public void Close(){} // RVA: 0x7FFAF95F7FA0
    }

    public class CommandStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9780B70
        public void Abort(){} // RVA: 0x7FFAF9780DD0
        public void Dispose(){} // RVA: 0x7FFAF97810B0
        public void InvokeRequestCallback(){} // RVA: 0x7FFAF9781150
        public void get_RecoverableFailure(){} // RVA: 0x7FFAF2F56500
        public void MarkAsRecoverableFailure(){} // RVA: 0x7FFAF97811F0
        public void SubmitRequest(){} // RVA: 0x7FFAF9781200
        public void ClearState(){} // RVA: 0x7FFAF97812A0
        public void BuildCommandsList(){} // RVA: 0x7FFAF2FC9240
        public void GenerateException(){} // RVA: 0x7FFAF9781350 | overloaded x2
        public void InitCommandPipeline(){} // RVA: 0x7FFAF9781400
        public void CheckContinuePipeline(){} // RVA: 0x7FFAF97815D0
        public void ContinueCommandPipeline(){} // RVA: 0x7FFAF9781610
        public void PostSendCommandProcessing(){} // RVA: 0x7FFAF9781A00
        public void PostReadCommandProcessing(){} // RVA: 0x7FFAF9781B80
        public void PipelineCallback(){} // RVA: 0x7FFAF2FC9240
        public void ReadCallback(){} // RVA: 0x7FFAF9781DD0
        public void WriteCallback(){} // RVA: 0x7FFAF9781FE0
        public void get_Encoding(){} // RVA: 0x7FFAF2F77C50
        public void set_Encoding(){} // RVA: 0x7FFAF9782170
        public void CheckValid(){} // RVA: 0x7FFAF2D8D320
        public void ReceiveCommandResponse(){} // RVA: 0x7FFAF9782260
        public void ReceiveCommandResponseCallback(){} // RVA: 0x7FFAF9782510
        public void .cctor(){} // RVA: 0x7FFAF9782C60
    }

    public class Comparer
    {
        // ── Methods ──
        public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFAF95E6F80
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ContentDecodeStream
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF95F8080
        public void get_OriginalInnerStream(){} // RVA: 0x7FFAF2E0A740
        public void .ctor(){} // RVA: 0x7FFAF95F6C60
        public void ProcessReadAsync(){} // RVA: 0x7FFAF95CC3A0
        public void FinishReading(){} // RVA: 0x7FFAF95F81D0
    }

    public class ContextAwareResult
    {
        // ── Methods ──
        public void SafeCaptureIdentity(){} // RVA: 0x7FFAF2D8D310
        public void CleanupInternal(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF9779160 | overloaded x3
        public void StartPostingAsyncOp(){} // RVA: 0x7FFAF97792D0 | overloaded x2
        public void FinishPostingAsyncOp(){} // RVA: 0x7FFAF97793F0
        public void Cleanup(){} // RVA: 0x7FFAF9779430
        public void CaptureOrComplete(){} // RVA: 0x7FFAF97794C0
        public void Complete(){} // RVA: 0x7FFAF97799D0
        public void CompleteCallback(){} // RVA: 0x7FFAF9779D10
    }

    public class Cookie
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95E1110
        public void get_Comment(){} // RVA: 0x7FFAF2DA8380
        public void set_Comment(){} // RVA: 0x7FFAF95E1460
        public void set_CommentUri(){} // RVA: 0x7FFAF2DF3E80
        public void set_HttpOnly(){} // RVA: 0x7FFAF855EFE0
        public void set_Discard(){} // RVA: 0x7FFAF2F87670
        public void get_Domain(){} // RVA: 0x7FFAF2DBB130
        public void set_Domain(){} // RVA: 0x7FFAF95E1500
        public void get__Domain(){} // RVA: 0x7FFAF95E1630
        public void get_Expired(){} // RVA: 0x7FFAF95E1700
        public void set_Expires(){} // RVA: 0x7FFAF3A001D0
        public void get_Name(){} // RVA: 0x7FFAF2E0A740
        public void set_Name(){} // RVA: 0x7FFAF95E1840
        public void InternalSetName(){} // RVA: 0x7FFAF95E19A0
        public void get_Path(){} // RVA: 0x7FFAF2E08730
        public void set_Path(){} // RVA: 0x7FFAF95E1B00
        public void get__Path(){} // RVA: 0x7FFAF95E1BB0
        public void get_Plain(){} // RVA: 0x7FFAF8C20FE0
        public void IsDomainEqualToHost(){} // RVA: 0x7FFAF95E1C40
        public void VerifySetDefaults(){} // RVA: 0x7FFAF95E1E70
        public void DomainCharsTest(){} // RVA: 0x7FFAF95E2F80
        public void get_Port(){} // RVA: 0x7FFAF2E55500
        public void set_Port(){} // RVA: 0x7FFAF95E3000
        public void get_PortList(){} // RVA: 0x7FFAF2E08D50
        public void get__Port(){} // RVA: 0x7FFAF95E3540
        public void get_Secure(){} // RVA: 0x7FFAF2E09320
        public void set_Secure(){} // RVA: 0x7FFAF2E09330
        public void get_Value(){} // RVA: 0x7FFAF2F12D00
        public void set_Value(){} // RVA: 0x7FFAF95E3610
        public void get_Variant(){} // RVA: 0x7FFAF3210030
        public void get_DomainKey(){} // RVA: 0x7FFAF95E36D0
        public void get_Version(){} // RVA: 0x7FFAF36690C0
        public void set_Version(){} // RVA: 0x7FFAF95E36F0
        public void get__Version(){} // RVA: 0x7FFAF95E3770
        public void GetComparer(){} // RVA: 0x7FFAF95E3880
        public void Equals(){} // RVA: 0x7FFAF95E38E0
        public void GetHashCode(){} // RVA: 0x7FFAF95E3BD0
        public void ToString(){} // RVA: 0x7FFAF95E3DC0
        public void .cctor(){} // RVA: 0x7FFAF95E42E0
    }

    public class CookieCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95E7210
        public void get_Item(){} // RVA: 0x7FFAF95E72F0
        public void Add(){} // RVA: 0x7FFAF95E74C0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAF8714F90
        public void get_IsSynchronized(){} // RVA: 0x7FFAF2D8D320
        public void get_SyncRoot(){} // RVA: 0x7FFAF44EF520
        public void CopyTo(){} // RVA: 0x7FFAF95E77B0
        public void TimeStamp(){} // RVA: 0x7FFAF95E77E0
        public void get_IsOtherVersionSeen(){} // RVA: 0x7FFAF3198A80
        public void InternalAdd(){} // RVA: 0x7FFAF95E78E0
        public void IndexOf(){} // RVA: 0x7FFAF95E7C20
        public void RemoveAt(){} // RVA: 0x7FFAF95E7E90
        public void GetEnumerator(){} // RVA: 0x7FFAF95E7EC0
    }

    public class CookieContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95E81F0
        public void AddRemoveDomain(){} // RVA: 0x7FFAF95E83D0
        public void Add(){} // RVA: 0x7FFAF95E85D0
        public void AgeCookies(){} // RVA: 0x7FFAF95E9010
        public void ExpireCollection(){} // RVA: 0x7FFAF95EA280
        public void IsLocalDomain(){} // RVA: 0x7FFAF95EA4A0
        public void CookieCutter(){} // RVA: 0x7FFAF95EA990
        public void InternalGetCookies(){} // RVA: 0x7FFAF95EB200
        public void BuildCookieCollectionFromDomainMatches(){} // RVA: 0x7FFAF95EB6D0
        public void MergeUpdateCollections(){} // RVA: 0x7FFAF95EBF20
        public void GetCookieHeader(){} // RVA: 0x7FFAF95EC270 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF95EC640
    }

    public class CookieException : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF44EE1C0 | overloaded x4
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAF95D1340
        public void GetObjectData(){} // RVA: 0x7FFAF95D1340
    }

    public class CookieParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95E60D0
        public void Get(){} // RVA: 0x7FFAF95E61E0
        public void CheckQuoted(){} // RVA: 0x7FFAF95E6EE0
    }

    public class CookieTokenizer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF95E45C0
        public void get_EndOfCookie(){} // RVA: 0x7FFAF2E575E0
        public void set_EndOfCookie(){} // RVA: 0x7FFAF2E575F0
        public void get_Eof(){} // RVA: 0x7FFAF95E4630
        public void get_Name(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Name(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Quoted(){} // RVA: 0x7FFAF3198A80
        public void set_Quoted(){} // RVA: 0x7FFAF3198B80
        public void get_Token(){} // RVA: 0x7FFAF2DE8CD0
        public void set_Token(){} // RVA: 0x7FFAF2DE8CE0
        public void get_Value(){} // RVA: 0x7FFAF2E0A740
        public void set_Value(){} // RVA: 0x7FFAF2DB5200
        public void Extract(){} // RVA: 0x7FFAF95E4640
        public void FindNext(){} // RVA: 0x7FFAF95E46D0
        public void Next(){} // RVA: 0x7FFAF95E4960
        public void Reset(){} // RVA: 0x7FFAF95E4D50
        public void TokenFromName(){} // RVA: 0x7FFAF95E4E60
        public void .cctor(){} // RVA: 0x7FFAF95E5060
    }

    public class CredentialCache
    {
        // ── Methods ──
        public void get_DefaultCredentials(){} // RVA: 0x7FFAF95CC670
        public void get_DefaultNetworkCredentials(){} // RVA: 0x7FFAF95CC6D0
    }

}