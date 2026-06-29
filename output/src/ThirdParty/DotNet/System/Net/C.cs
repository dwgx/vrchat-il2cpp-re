// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 13
// Methods: 142

namespace ThirdParty.DotNet.System.Net
{
    public class CaseInsensitiveAscii : Object
    {
        public object StaticInstance;
        public object AsciiToLower;

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x758A6A0
        public void Compare(){} // RVA: 0x758A7A0
        public void FastGetHashCode(){} // RVA: 0x758A940
        public void Equals(){} // RVA: 0x758AA20
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x758ABA0
    }

    public class ChunkedInputStream : RequestStream
    {
        public object disposed;
        public object decoder;
        public object context;
        public object no_more_data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x75AA610
        public void Read(){} // RVA: 0x75AA7F0
        public void BeginRead(){} // RVA: 0x75AA840
        public void OnRead(){} // RVA: 0x75AAC80
        public void EndRead(){} // RVA: 0x75AAFA0
        public void Close(){} // RVA: 0x75AB1D0
    }

    public class CommandStream : NetworkStreamWrapper
    {
        public object s_writeCallbackDelegate;
        public object s_readCallbackDelegate;
        public object _recoverableFailure;
        public object _request;
        public object _isAsync;
        public object _aborted;
        public object _commands;
        public object _index;
        public object _doRead;
        public object _doSend;
        public object _currentResponseDescription;
        public object _abortReason;
        public object _buffer;
        public object _encoding;
        public object _decoder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x772F500
        public void Abort(){} // RVA: 0x772F740
        public void Dispose(){} // RVA: 0x772F9F0
        public void InvokeRequestCallback(){} // RVA: 0x772FA90
        public void get_RecoverableFailure(){} // RVA: 0xD16660
        public void MarkAsRecoverableFailure(){} // RVA: 0x772FB30
        public void SubmitRequest(){} // RVA: 0x772FB40
        public void ClearState(){} // RVA: 0x772FBE0
        public void BuildCommandsList(){} // RVA: 0xDAC980
        public void GenerateException(){} // RVA: 0x772FC90
        public void InitCommandPipeline(){} // RVA: 0x772FD40
        public void CheckContinuePipeline(){} // RVA: 0x772FEE0
        public void ContinueCommandPipeline(){} // RVA: 0x772FF20
        public void PostSendCommandProcessing(){} // RVA: 0x77302E0
        public void PostReadCommandProcessing(){} // RVA: 0x7730450
        public void PipelineCallback(){} // RVA: 0xDAC980
        public void ReadCallback(){} // RVA: 0x7730690
        public void WriteCallback(){} // RVA: 0x77308A0
        public void get_Encoding(){} // RVA: 0xCD3320
        public void set_Encoding(){} // RVA: 0x7730A30
        public void CheckValid(){} // RVA: 0xB43320
        public void ReceiveCommandResponse(){} // RVA: 0x7730B20
        public void ReceiveCommandResponseCallback(){} // RVA: 0x7730DC0
        public void .cctor(){} // RVA: 0x7731500
    }

    public class Comparer : Object
    {
        // ── Methods ──
        public void System.Collections.IComparer.Compare(){} // RVA: 0x759AE30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ContentDecodeStream : WebReadStream
    {
        public object _originalInnerStream;

        // ── Methods ──
        public void Create(){} // RVA: 0x75AB2B0
        public void get_OriginalInnerStream(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0x75A9E80
        public void ProcessReadAsync(){} // RVA: 0x7580690
        public void FinishReading(){} // RVA: 0x75AB400
    }

    public class ContextAwareResult : LazyAsyncResult
    {
        public object _context;
        public object _lock;
        public object _flags;

        // ── Methods ──
        public void SafeCaptureIdentity(){} // RVA: 0xB43310
        public void CleanupInternal(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x7727A60
        public void StartPostingAsyncOp(){} // RVA: 0x7727BD0
        public void FinishPostingAsyncOp(){} // RVA: 0x7727CF0
        public void Cleanup(){} // RVA: 0x7727D30
        public void CaptureOrComplete(){} // RVA: 0x7727DC0
        public void Complete(){} // RVA: 0x77282D0
        public void CompleteCallback(){} // RVA: 0x77285F0
    }

    public class Cookie : Object
    {
        public object PortSplitDelimiters;
        public object Reserved2Name;
        public object Reserved2Value;
        public object staticComparer;
        public object m_comment;
        public object m_commentUri;
        public object m_cookieVariant;
        public object m_discard;
        public object m_domain;
        public object m_domain_implicit;
        public object m_expires;
        public object m_name;
        public object m_path;
        public object m_path_implicit;
        public object m_port;
        public object m_port_implicit;
        public object m_port_list;
        public object m_secure;
        public object m_httpOnly;
        public object m_timeStamp;
        public object m_value;
        public object m_version;
        public object m_domainKey;
        public object IsQuotedVersion;
        public object IsQuotedDomain;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7595330
        public void get_Comment(){} // RVA: 0xB5DBF0
        public void set_Comment(){} // RVA: 0x715F420
        public void set_CommentUri(){} // RVA: 0xBA9BA0
        public void set_HttpOnly(){} // RVA: 0x6529A20
        public void set_Discard(){} // RVA: 0xD72F80
        public void get_Domain(){} // RVA: 0xB70160
        public void set_Domain(){} // RVA: 0x7595670
        public void get__Domain(){} // RVA: 0x7595770
        public void get_Expired(){} // RVA: 0x7595830
        public void set_Expires(){} // RVA: 0xE9F6B0
        public void get_Name(){} // RVA: 0xBC1B30
        public void set_Name(){} // RVA: 0x7595970
        public void InternalSetName(){} // RVA: 0x7595AD0
        public void get_Path(){} // RVA: 0xBBF8F0
        public void set_Path(){} // RVA: 0x7595C20
        public void get__Path(){} // RVA: 0x7595CB0
        public void get_Plain(){} // RVA: 0x6BE40F0
        public void IsDomainEqualToHost(){} // RVA: 0x7595D30
        public void VerifySetDefaults(){} // RVA: 0x7595F60
        public void DomainCharsTest(){} // RVA: 0x7597080
        public void get_Port(){} // RVA: 0xC0FFC0
        public void set_Port(){} // RVA: 0x7597100
        public void get_PortList(){} // RVA: 0xBBFF90
        public void get__Port(){} // RVA: 0x7597640
        public void get_Secure(){} // RVA: 0xBC03E0
        public void set_Secure(){} // RVA: 0xBC03F0
        public void get_Value(){} // RVA: 0xCD48B0
        public void set_Value(){} // RVA: 0x7597700
        public void get_Variant(){} // RVA: 0xFEAE90
        public void get_DomainKey(){} // RVA: 0x7597780
        public void get_Version(){} // RVA: 0x14780B0
        public void set_Version(){} // RVA: 0x75977A0
        public void get__Version(){} // RVA: 0x7597820
        public void GetComparer(){} // RVA: 0x7597920
        public void Equals(){} // RVA: 0x7597980
        public void GetHashCode(){} // RVA: 0x7597C70
        public void ToString(){} // RVA: 0x7597E60
        public void .cctor(){} // RVA: 0x7598330
    }

    public class CookieCollection : Object
    {
        public object m_version;
        public object m_list;
        public object m_TimeStamp;
        public object m_has_other_versions;
        public object m_IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x759B0C0
        public void get_Item(){} // RVA: 0x759B1A0
        public void Add(){} // RVA: 0x759B370
        public void get_Count(){} // RVA: 0x66DD600
        public void get_IsSynchronized(){} // RVA: 0xB43320
        public void get_SyncRoot(){} // RVA: 0x2303260
        public void CopyTo(){} // RVA: 0x759B650
        public void TimeStamp(){} // RVA: 0x759B680
        public void get_IsOtherVersionSeen(){} // RVA: 0xF73960
        public void InternalAdd(){} // RVA: 0x759B780
        public void IndexOf(){} // RVA: 0x759BAA0
        public void RemoveAt(){} // RVA: 0x759BCE0
        public void GetEnumerator(){} // RVA: 0x759BD10
    }

    public class CookieContainer : Object
    {
        public object DefaultCookieLimit;
        public object DefaultPerDomainCookieLimit;
        public object DefaultCookieLengthLimit;
        public object HeaderInfo;
        public object m_domainTable;
        public object m_maxCookieSize;
        public object m_maxCookies;
        public object m_maxCookiesPerDomain;
        public object m_count;
        public object m_fqdnMyDomain;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x759C040
        public void AddRemoveDomain(){} // RVA: 0x759C210
        public void Add(){} // RVA: 0x759C3E0
        public void AgeCookies(){} // RVA: 0x759CD70
        public void ExpireCollection(){} // RVA: 0x759DEB0
        public void IsLocalDomain(){} // RVA: 0x759E090
        public void CookieCutter(){} // RVA: 0x759E360
        public void InternalGetCookies(){} // RVA: 0x759EBB0
        public void BuildCookieCollectionFromDomainMatches(){} // RVA: 0x759F080
        public void MergeUpdateCollections(){} // RVA: 0x759F890
        public void GetCookieHeader(){} // RVA: 0x759FBA0
        public void .cctor(){} // RVA: 0x759FF60
    }

    public class CookieException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7585810
        public void GetObjectData(){} // RVA: 0x7585810
    }

    public class CookieParser : Object
    {
        public object m_tokenizer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x759A0C0
        public void Get(){} // RVA: 0x759A1D0
        public void CheckQuoted(){} // RVA: 0x759ADC0
    }

    public class CookieTokenizer : Object
    {
        public object m_eofCookie;
        public object m_index;
        public object m_length;
        public object m_name;
        public object m_quoted;
        public object m_start;
        public object m_token;
        public object m_tokenLength;
        public object m_tokenStream;
        public object m_value;
        public object RecognizedAttributes;
        public object RecognizedServerAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7598610
        public void get_EndOfCookie(){} // RVA: 0xC120A0
        public void set_EndOfCookie(){} // RVA: 0xC120B0
        public void get_Eof(){} // RVA: 0x7598680
        public void get_Name(){} // RVA: 0xB700F0
        public void set_Name(){} // RVA: 0xB70100
        public void get_Quoted(){} // RVA: 0xF73960
        public void set_Quoted(){} // RVA: 0xF73A60
        public void get_Token(){} // RVA: 0xB9E080
        public void set_Token(){} // RVA: 0xB9E090
        public void get_Value(){} // RVA: 0xBC1B30
        public void set_Value(){} // RVA: 0xB6A8C0
        public void Extract(){} // RVA: 0x7598690
        public void FindNext(){} // RVA: 0x7598700
        public void Next(){} // RVA: 0x75989F0
        public void Reset(){} // RVA: 0x7598D70
        public void TokenFromName(){} // RVA: 0x7598E50
        public void .cctor(){} // RVA: 0x7599050
    }

    public class CredentialCache : Object
    {
        // ── Methods ──
        public void get_DefaultCredentials(){} // RVA: 0x7580960
        public void get_DefaultNetworkCredentials(){} // RVA: 0x75809C0
    }

}