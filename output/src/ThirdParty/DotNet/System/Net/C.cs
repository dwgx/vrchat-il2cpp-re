// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 13
// Methods: 142

namespace ThirdParty.DotNet.System.Net
{
    public class CaseInsensitiveAscii : Object
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7AE916ED0
        public void Compare(){} // RVA: 0x7AE916FE0
        public void FastGetHashCode(){} // RVA: 0x7AE917190
        public void Equals(){} // RVA: 0x7AE917270
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE917400
    }

    public class ChunkedInputStream : RequestStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE937530
        public void Read(){} // RVA: 0x7AE937710
        public void BeginRead(){} // RVA: 0x7AE937760
        public void OnRead(){} // RVA: 0x7AE937BA0
        public void EndRead(){} // RVA: 0x7AE937EC0
        public void Close(){} // RVA: 0x7AE9380F0
    }

    public class CommandStream : NetworkStreamWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEABFD60
        public void Abort(){} // RVA: 0x7AEABFFC0
        public void Dispose(){} // RVA: 0x7AEAC0270
        public void InvokeRequestCallback(){} // RVA: 0x7AEAC0310
        public void get_RecoverableFailure(){} // RVA: 0x7A82A20A0
        public void MarkAsRecoverableFailure(){} // RVA: 0x7AEAC03B0
        public void SubmitRequest(){} // RVA: 0x7AEAC03C0
        public void ClearState(){} // RVA: 0x7AEAC0460
        public void BuildCommandsList(){} // RVA: 0x7A82D1450
        public void GenerateException(){} // RVA: 0x7AEAC0510
        public void InitCommandPipeline(){} // RVA: 0x7AEAC05C0
        public void CheckContinuePipeline(){} // RVA: 0x7AEAC0790
        public void ContinueCommandPipeline(){} // RVA: 0x7AEAC07D0
        public void PostSendCommandProcessing(){} // RVA: 0x7AEAC0B90
        public void PostReadCommandProcessing(){} // RVA: 0x7AEAC0D00
        public void PipelineCallback(){} // RVA: 0x7A82D1450
        public void ReadCallback(){} // RVA: 0x7AEAC0F50
        public void WriteCallback(){} // RVA: 0x7AEAC1160
        public void get_Encoding(){} // RVA: 0x7A82C2060
        public void set_Encoding(){} // RVA: 0x7AEAC12F0
        public void CheckValid(){} // RVA: 0x7A80D7320
        public void ReceiveCommandResponse(){} // RVA: 0x7AEAC13E0
        public void ReceiveCommandResponseCallback(){} // RVA: 0x7AEAC1680
        public void .cctor(){} // RVA: 0x7AEAC1DD0
    }

    public class Comparer : Object
    {
        // ── Methods ──
        public void System.Collections.IComparer.Compare(){} // RVA: 0x7AE927AB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ContentDecodeStream : WebReadStream
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AE9381D0
        public void get_OriginalInnerStream(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7AE936DA0
        public void ProcessReadAsync(){} // RVA: 0x7AE90CE00
        public void FinishReading(){} // RVA: 0x7AE938320
    }

    public class ContextAwareResult : LazyAsyncResult
    {
        // ── Methods ──
        public void SafeCaptureIdentity(){} // RVA: 0x7A80D7310
        public void CleanupInternal(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7AEAB8270
        public void StartPostingAsyncOp(){} // RVA: 0x7AEAB83E0
        public void FinishPostingAsyncOp(){} // RVA: 0x7AEAB8500
        public void Cleanup(){} // RVA: 0x7AEAB8540
        public void CaptureOrComplete(){} // RVA: 0x7AEAB85D0
        public void Complete(){} // RVA: 0x7AEAB8AE0
        public void CompleteCallback(){} // RVA: 0x7AEAB8E20
    }

    public class Cookie : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE921C20
        public void get_Comment(){} // RVA: 0x7A80F2570
        public void set_Comment(){} // RVA: 0x7AE921F70
        public void set_CommentUri(){} // RVA: 0x7A813E420
        public void set_HttpOnly(){} // RVA: 0x7AD89C550
        public void set_Discard(){} // RVA: 0x7A9727920
        public void get_Domain(){} // RVA: 0x7A8105330
        public void set_Domain(){} // RVA: 0x7AE922010
        public void get__Domain(){} // RVA: 0x7AE922140
        public void get_Expired(){} // RVA: 0x7AE922210
        public void set_Expires(){} // RVA: 0x7A82C26E0
        public void get_Name(){} // RVA: 0x7A8154D80
        public void set_Name(){} // RVA: 0x7AE922350
        public void InternalSetName(){} // RVA: 0x7AE9224B0
        public void get_Path(){} // RVA: 0x7A8152D80
        public void set_Path(){} // RVA: 0x7AE922610
        public void get__Path(){} // RVA: 0x7AE9226C0
        public void get_Plain(){} // RVA: 0x7ADF5D750
        public void IsDomainEqualToHost(){} // RVA: 0x7AE922750
        public void VerifySetDefaults(){} // RVA: 0x7AE922980
        public void DomainCharsTest(){} // RVA: 0x7AE923AA0
        public void get_Port(){} // RVA: 0x7A81A0050
        public void set_Port(){} // RVA: 0x7AE923B20
        public void get_PortList(){} // RVA: 0x7A8153390
        public void get__Port(){} // RVA: 0x7AE924070
        public void get_Secure(){} // RVA: 0x7A8153980
        public void set_Secure(){} // RVA: 0x7A8153990
        public void get_Value(){} // RVA: 0x7A825E100
        public void set_Value(){} // RVA: 0x7AE924140
        public void get_Variant(){} // RVA: 0x7A851DB90
        public void get_DomainKey(){} // RVA: 0x7AE924200
        public void get_Version(){} // RVA: 0x7A897F560
        public void set_Version(){} // RVA: 0x7AE924220
        public void get__Version(){} // RVA: 0x7AE9242A0
        public void GetComparer(){} // RVA: 0x7AE9243B0
        public void Equals(){} // RVA: 0x7AE924410
        public void GetHashCode(){} // RVA: 0x7AE924700
        public void ToString(){} // RVA: 0x7AE9248F0
        public void .cctor(){} // RVA: 0x7AE924E10
    }

    public class CookieCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE927D40
        public void get_Item(){} // RVA: 0x7AE927E20
        public void Add(){} // RVA: 0x7AE927FF0
        public void get_Count(){} // RVA: 0x7ADA52F20
        public void get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void get_SyncRoot(){} // RVA: 0x7A97F8BA0
        public void CopyTo(){} // RVA: 0x7AE9282D0
        public void TimeStamp(){} // RVA: 0x7AE928300
        public void get_IsOtherVersionSeen(){} // RVA: 0x7A84A5BD0
        public void InternalAdd(){} // RVA: 0x7AE928400
        public void IndexOf(){} // RVA: 0x7AE928720
        public void RemoveAt(){} // RVA: 0x7AE928960
        public void GetEnumerator(){} // RVA: 0x7AE928990
    }

    public class CookieContainer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE928CC0
        public void AddRemoveDomain(){} // RVA: 0x7AE928EA0
        public void Add(){} // RVA: 0x7AE929070
        public void AgeCookies(){} // RVA: 0x7AE929A00
        public void ExpireCollection(){} // RVA: 0x7AE92AB60
        public void IsLocalDomain(){} // RVA: 0x7AE92AD40
        public void CookieCutter(){} // RVA: 0x7AE92B010
        public void InternalGetCookies(){} // RVA: 0x7AE92B860
        public void BuildCookieCollectionFromDomainMatches(){} // RVA: 0x7AE92BD30
        public void MergeUpdateCollections(){} // RVA: 0x7AE92C550
        public void GetCookieHeader(){} // RVA: 0x7AE92C860
        public void .cctor(){} // RVA: 0x7AE92CC40
    }

    public class CookieException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97F7860
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7AE912010
        public void GetObjectData(){} // RVA: 0x7AE912010
    }

    public class CookieParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE926C00
        public void Get(){} // RVA: 0x7AE926D10
        public void CheckQuoted(){} // RVA: 0x7AE927A10
    }

    public class CookieTokenizer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9250F0
        public void get_EndOfCookie(){} // RVA: 0x7A81A2200
        public void set_EndOfCookie(){} // RVA: 0x7A81A2210
        public void get_Eof(){} // RVA: 0x7AE925160
        public void get_Name(){} // RVA: 0x7A81052C0
        public void set_Name(){} // RVA: 0x7A81052D0
        public void get_Quoted(){} // RVA: 0x7A84A5BD0
        public void set_Quoted(){} // RVA: 0x7A84A5CD0
        public void get_Token(){} // RVA: 0x7A8133100
        public void set_Token(){} // RVA: 0x7A8133110
        public void get_Value(){} // RVA: 0x7A8154D80
        public void set_Value(){} // RVA: 0x7A80FF440
        public void Extract(){} // RVA: 0x7AE925170
        public void FindNext(){} // RVA: 0x7AE925200
        public void Next(){} // RVA: 0x7AE925490
        public void Reset(){} // RVA: 0x7AE925880
        public void TokenFromName(){} // RVA: 0x7AE925990
        public void .cctor(){} // RVA: 0x7AE925B90
    }

    public class CredentialCache : Object
    {
        // ── Methods ──
        public void get_DefaultCredentials(){} // RVA: 0x7AE90D0D0
        public void get_DefaultNetworkCredentials(){} // RVA: 0x7AE90D130
    }

}