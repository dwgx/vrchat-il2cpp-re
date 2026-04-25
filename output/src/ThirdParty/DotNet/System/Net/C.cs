// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 13
// Methods: 151

namespace ThirdParty.DotNet.System.Net
{
    public class CaseInsensitiveAscii : Object
    {
        public System.Net.CaseInsensitiveAscii StaticInstance;
        public byte[] AsciiToLower; // 0x8

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFAC92BCD70
        public void Compare(){} // RVA: 0x7FFAC92BCE80
        public void FastGetHashCode(){} // RVA: 0x7FFAC92BD040
        public void Equals(){} // RVA: 0x7FFAC92BD120
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC92BD2B0
    }

    public class ChunkedInputStream : RequestStream
    {
        public bool disposed; // 0x50
        public System.Net.MonoChunkParser decoder; // 0x58
        public System.Net.HttpListenerContext context; // 0x60
        public bool no_more_data; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92DDF70
        public void Read(){} // RVA: 0x7FFAC92DE140
        public void BeginRead(){} // RVA: 0x7FFAC92DE190
        public void OnRead(){} // RVA: 0x7FFAC92DE5D0
        public void EndRead(){} // RVA: 0x7FFAC92DE8F0
        public void Close(){} // RVA: 0x7FFAC92DEB20
    }

    public class CommandStream : NetworkStreamWrapper
    {
        public System.AsyncCallback RecoverableFailure;
        public System.AsyncCallback Encoding; // 0x8
        public bool _recoverableFailure; // 0x38
        public System.Net.WebRequest _request; // 0x40
        public bool _isAsync; // 0x48
        public bool _aborted; // 0x49
        public PipelineEntry[] _commands; // 0x50
        public int _index; // 0x58
        public bool _doRead; // 0x5C
        public bool _doSend; // 0x5D
        public System.Net.ResponseDescription _currentResponseDescription; // 0x60
        public string _abortReason; // 0x68
        public string _buffer; // 0x70
        public System.Text.Encoding _encoding; // 0x78
        public System.Text.Decoder _decoder; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC94692D0
        public void Abort(){} // RVA: 0x7FFAC9469530
        public void Dispose(){} // RVA: 0x7FFAC9469810
        public void InvokeRequestCallback(){} // RVA: 0x7FFAC94698B0
        public void get_RecoverableFailure(){} // RVA: 0x7FFAC31D95D0
        public void MarkAsRecoverableFailure(){} // RVA: 0x7FFAC9469950
        public void SubmitRequest(){} // RVA: 0x7FFAC9469960
        public void ClearState(){} // RVA: 0x7FFAC9469A00
        public void BuildCommandsList(){} // RVA: 0x7FFAC34F9180
        public void GenerateException(){} // RVA: 0x7FFAC9469AB0 | overloaded x2
        public void InitCommandPipeline(){} // RVA: 0x7FFAC9469B60
        public void CheckContinuePipeline(){} // RVA: 0x7FFAC9469D30
        public void ContinueCommandPipeline(){} // RVA: 0x7FFAC9469D70
        public void PostSendCommandProcessing(){} // RVA: 0x7FFAC946A160
        public void PostReadCommandProcessing(){} // RVA: 0x7FFAC946A2E0
        public void PipelineCallback(){} // RVA: 0x7FFAC34F9180
        public void ReadCallback(){} // RVA: 0x7FFAC946A530
        public void WriteCallback(){} // RVA: 0x7FFAC946A740
        public void get_Encoding(){} // RVA: 0x7FFAC30E5600
        public void set_Encoding(){} // RVA: 0x7FFAC946A8D0
        public void CheckValid(){} // RVA: 0x7FFAC2F21320
        public void ReceiveCommandResponse(){} // RVA: 0x7FFAC946A9C0
        public void ReceiveCommandResponseCallback(){} // RVA: 0x7FFAC946AC70
        public void .cctor(){} // RVA: 0x7FFAC946B3C0
    }

    public class Comparer : Object
    {
        // ── Methods ──
        public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFAC92CDB00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ContentDecodeStream : WebReadStream
    {
        public System.IO.Stream OriginalInnerStream; // 0x40

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC92DEC00
        public void get_OriginalInnerStream(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC92DD7E0
        public void ProcessReadAsync(){} // RVA: 0x7FFAC92B2F20
        public void FinishReading(){} // RVA: 0x7FFAC92DED50
    }

    public class ContextAwareResult : LazyAsyncResult
    {
        public System.Threading.ExecutionContext _context; // 0x40
        public object _lock; // 0x48
        public 0x6B139AA0 _flags; // 0x50

        // ── Methods ──
        public void SafeCaptureIdentity(){} // RVA: 0x7FFAC2F21310
        public void CleanupInternal(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC94618C0 | overloaded x3
        public void StartPostingAsyncOp(){} // RVA: 0x7FFAC9461A30 | overloaded x2
        public void FinishPostingAsyncOp(){} // RVA: 0x7FFAC9461B50
        public void Cleanup(){} // RVA: 0x7FFAC9461B90
        public void CaptureOrComplete(){} // RVA: 0x7FFAC9461C20
        public void Complete(){} // RVA: 0x7FFAC9462130
        public void CompleteCallback(){} // RVA: 0x7FFAC9462470
    }

    public class Cookie : Object
    {
        public char[] Comment;
        public char[] CommentUri; // 0x8
        public char[] HttpOnly; // 0x10
        public System.Net.Comparer Discard; // 0x18
        public string Domain; // 0x10
        public System.Uri _Domain; // 0x18
        public 0x6B13BD58 Expired; // 0x20
        public bool Expires; // 0x24
        public string Name; // 0x28
        public bool Path; // 0x30
        public System.DateTime _Path; // 0x38
        public string Plain; // 0x40
        public string Port; // 0x48
        public bool PortList; // 0x50
        public string _Port; // 0x58
        public bool Secure; // 0x60
        public int[] Value; // 0x68
        public bool Variant; // 0x70
        public bool DomainKey; // 0x71
        public System.DateTime Version; // 0x78
        public string _Version; // 0x80
        public int m_version; // 0x88
        public string m_domainKey; // 0x90
        public bool IsQuotedVersion; // 0x98
        public bool IsQuotedDomain; // 0x99

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92C7C90
        public void get_Comment(){} // RVA: 0x7FFAC2F3C380
        public void set_Comment(){} // RVA: 0x7FFAC92C7FE0
        public void set_CommentUri(){} // RVA: 0x7FFAC2F87E80
        public void set_HttpOnly(){} // RVA: 0x7FFAC82464D0
        public void set_Discard(){} // RVA: 0x7FFAC4422FB0
        public void get_Domain(){} // RVA: 0x7FFAC2F4F130
        public void set_Domain(){} // RVA: 0x7FFAC92C8080
        public void get__Domain(){} // RVA: 0x7FFAC92C81B0
        public void get_Expired(){} // RVA: 0x7FFAC92C8280
        public void set_Expires(){} // RVA: 0x7FFAC35233F0
        public void get_Name(){} // RVA: 0x7FFAC2F9E740
        public void set_Name(){} // RVA: 0x7FFAC92C83C0
        public void InternalSetName(){} // RVA: 0x7FFAC92C8520
        public void get_Path(){} // RVA: 0x7FFAC2F9C730
        public void set_Path(){} // RVA: 0x7FFAC92C8680
        public void get__Path(){} // RVA: 0x7FFAC92C8730
        public void get_Plain(){} // RVA: 0x7FFAC89086E0
        public void IsDomainEqualToHost(){} // RVA: 0x7FFAC92C87C0
        public void VerifySetDefaults(){} // RVA: 0x7FFAC92C89F0
        public void DomainCharsTest(){} // RVA: 0x7FFAC92C9B00
        public void get_Port(){} // RVA: 0x7FFAC2FE9500
        public void set_Port(){} // RVA: 0x7FFAC92C9B80
        public void get_PortList(){} // RVA: 0x7FFAC2F9CD50
        public void get__Port(){} // RVA: 0x7FFAC92CA0C0
        public void get_Secure(){} // RVA: 0x7FFAC2F9D320
        public void set_Secure(){} // RVA: 0x7FFAC2F9D330
        public void get_Value(){} // RVA: 0x7FFAC32EF410
        public void set_Value(){} // RVA: 0x7FFAC92CA190
        public void get_Variant(){} // RVA: 0x7FFAC30DBBE0
        public void get_DomainKey(){} // RVA: 0x7FFAC92CA250
        public void get_Version(){} // RVA: 0x7FFAC37EE8C0
        public void set_Version(){} // RVA: 0x7FFAC92CA270
        public void get__Version(){} // RVA: 0x7FFAC92CA2F0
        public void GetComparer(){} // RVA: 0x7FFAC92CA400
        public void Equals(){} // RVA: 0x7FFAC92CA460
        public void GetHashCode(){} // RVA: 0x7FFAC92CA750
        public void ToString(){} // RVA: 0x7FFAC92CA940
        public void .cctor(){} // RVA: 0x7FFAC92CAE60
    }

    public class CookieCollection : Object
    {
        public int Item; // 0x10
        public System.Collections.ArrayList Count; // 0x18
        public System.DateTime IsSynchronized; // 0x20
        public bool SyncRoot; // 0x28
        public bool IsOtherVersionSeen; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92CDD90
        public void get_Item(){} // RVA: 0x7FFAC92CDE70
        public void Add(){} // RVA: 0x7FFAC92CE040 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC83FC4F0
        public void get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void CopyTo(){} // RVA: 0x7FFAC92CE330
        public void TimeStamp(){} // RVA: 0x7FFAC92CE360
        public void get_IsOtherVersionSeen(){} // RVA: 0x7FFAC30F6BA0
        public void InternalAdd(){} // RVA: 0x7FFAC92CE460
        public void IndexOf(){} // RVA: 0x7FFAC92CE7A0
        public void RemoveAt(){} // RVA: 0x7FFAC92CEA10
        public void GetEnumerator(){} // RVA: 0x7FFAC92CEA40
    }

    public class CookieContainer : Object
    {
        public int DefaultCookieLimit;
        public int DefaultPerDomainCookieLimit;
        public int DefaultCookieLengthLimit;
        public System.Net.HeaderVariantInfo[] HeaderInfo;
        public System.Collections.Hashtable m_domainTable; // 0x10
        public int m_maxCookieSize; // 0x18
        public int m_maxCookies; // 0x1C
        public int m_maxCookiesPerDomain; // 0x20
        public int m_count; // 0x24
        public string m_fqdnMyDomain; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92CED70
        public void AddRemoveDomain(){} // RVA: 0x7FFAC92CEF50
        public void Add(){} // RVA: 0x7FFAC92CF150
        public void AgeCookies(){} // RVA: 0x7FFAC92CFB90
        public void ExpireCollection(){} // RVA: 0x7FFAC92D0E00
        public void IsLocalDomain(){} // RVA: 0x7FFAC92D1020
        public void CookieCutter(){} // RVA: 0x7FFAC92D1510
        public void InternalGetCookies(){} // RVA: 0x7FFAC92D1D80
        public void BuildCookieCollectionFromDomainMatches(){} // RVA: 0x7FFAC92D2250
        public void MergeUpdateCollections(){} // RVA: 0x7FFAC92D2AA0
        public void GetCookieHeader(){} // RVA: 0x7FFAC92D2DF0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC92D31C0
    }

    public class CookieException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC92B7EC0
        public void GetObjectData(){} // RVA: 0x7FFAC92B7EC0
    }

    public class CookieParser : Object
    {
        public System.Net.CookieTokenizer m_tokenizer; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92CCC50
        public void Get(){} // RVA: 0x7FFAC92CCD60
        public void CheckQuoted(){} // RVA: 0x7FFAC92CDA60
    }

    public class CookieTokenizer : Object
    {
        public bool EndOfCookie; // 0x10
        public int Eof; // 0x14
        public int Name; // 0x18
        public string Quoted; // 0x20
        public bool Token; // 0x28
        public int Value; // 0x2C
        public 0x6B13BE08 m_token; // 0x30
        public int m_tokenLength; // 0x34
        public string m_tokenStream; // 0x38
        public string m_value; // 0x40
        public RecognizedAttribute[] RecognizedAttributes;
        public RecognizedAttribute[] RecognizedServerAttributes; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92CB140
        public void get_EndOfCookie(){} // RVA: 0x7FFAC2FEB5E0
        public void set_EndOfCookie(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Eof(){} // RVA: 0x7FFAC92CB1B0
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Name(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Quoted(){} // RVA: 0x7FFAC30F6BA0
        public void set_Quoted(){} // RVA: 0x7FFAC3C24F40
        public void get_Token(){} // RVA: 0x7FFAC2F7CCD0
        public void set_Token(){} // RVA: 0x7FFAC2F7CCE0
        public void get_Value(){} // RVA: 0x7FFAC2F9E740
        public void set_Value(){} // RVA: 0x7FFAC2F49200
        public void Extract(){} // RVA: 0x7FFAC92CB1C0
        public void FindNext(){} // RVA: 0x7FFAC92CB250
        public void Next(){} // RVA: 0x7FFAC92CB4E0
        public void Reset(){} // RVA: 0x7FFAC92CB8D0
        public void TokenFromName(){} // RVA: 0x7FFAC92CB9E0
        public void .cctor(){} // RVA: 0x7FFAC92CBBE0
    }

    public class CredentialCache : Object
    {
        public object DefaultCredentials;
        public object DefaultNetworkCredentials;

        // ── Methods ──
        public void get_DefaultCredentials(){} // RVA: 0x7FFAC92B31F0
        public void get_DefaultNetworkCredentials(){} // RVA: 0x7FFAC92B3250
    }

}