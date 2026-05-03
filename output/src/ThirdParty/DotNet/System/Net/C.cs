// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 13
// Methods: 151

namespace ThirdParty.DotNet.System.Net
{
    public class CaseInsensitiveAscii : Object
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFE876654B0
        public void Compare(){} // RVA: 0x7FFE876655C0
        public void FastGetHashCode(){} // RVA: 0x7FFE87665780
        public void Equals(){} // RVA: 0x7FFE87665860
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE876659F0
    }

    public class ChunkedInputStream : RequestStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876866A0
        public void Read(){} // RVA: 0x7FFE87686870
        public void BeginRead(){} // RVA: 0x7FFE876868C0
        public void OnRead(){} // RVA: 0x7FFE87686D00
        public void EndRead(){} // RVA: 0x7FFE87687020
        public void Close(){} // RVA: 0x7FFE87687250
    }

    public class CommandStream : NetworkStreamWrapper
    {
        public System.AsyncCallback s_writeCallbackDelegate;
        public System.AsyncCallback s_readCallbackDelegate; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87811A10
        public void Abort(){} // RVA: 0x7FFE87811C70
        public void Dispose(){} // RVA: 0x7FFE87811F50
        public void InvokeRequestCallback(){} // RVA: 0x7FFE87811FF0
        public void get_RecoverableFailure(){} // RVA: 0x7FFE812CF770
        public void MarkAsRecoverableFailure(){} // RVA: 0x7FFE87812090
        public void SubmitRequest(){} // RVA: 0x7FFE878120A0
        public void ClearState(){} // RVA: 0x7FFE87812140
        public void BuildCommandsList(){} // RVA: 0x7FFE813240E0
        public void GenerateException(){} // RVA: 0x7FFE878121F0 | overloaded x2
        public void InitCommandPipeline(){} // RVA: 0x7FFE878122A0
        public void CheckContinuePipeline(){} // RVA: 0x7FFE87812470
        public void ContinueCommandPipeline(){} // RVA: 0x7FFE878124B0
        public void PostSendCommandProcessing(){} // RVA: 0x7FFE878128A0
        public void PostReadCommandProcessing(){} // RVA: 0x7FFE87812A20
        public void PipelineCallback(){} // RVA: 0x7FFE813240E0
        public void ReadCallback(){} // RVA: 0x7FFE87812C70
        public void WriteCallback(){} // RVA: 0x7FFE87812E80
        public void get_Encoding(){} // RVA: 0x7FFE81463AE0
        public void set_Encoding(){} // RVA: 0x7FFE87813010
        public void CheckValid(){} // RVA: 0x7FFE810FB320
        public void ReceiveCommandResponse(){} // RVA: 0x7FFE87813100
        public void ReceiveCommandResponseCallback(){} // RVA: 0x7FFE878133B0
        public void .cctor(){} // RVA: 0x7FFE87813B00
    }

    public class Comparer : Object
    {
        // ── Methods ──
        public void System.Collections.IComparer.Compare(){} // RVA: 0x7FFE87676230
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ContentDecodeStream : WebReadStream
    {
        public System.IO.Stream _originalInnerStream; // 0x40

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87687330
        public void get_OriginalInnerStream(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE87685F10
        public void ProcessReadAsync(){} // RVA: 0x7FFE8765B660
        public void FinishReading(){} // RVA: 0x7FFE87687480
    }

    public class ContextAwareResult : LazyAsyncResult
    {
        // ── Methods ──
        public void SafeCaptureIdentity(){} // RVA: 0x7FFE810FB310
        public void CleanupInternal(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE8780A000 | overloaded x3
        public void StartPostingAsyncOp(){} // RVA: 0x7FFE8780A170 | overloaded x2
        public void FinishPostingAsyncOp(){} // RVA: 0x7FFE8780A290
        public void Cleanup(){} // RVA: 0x7FFE8780A2D0
        public void CaptureOrComplete(){} // RVA: 0x7FFE8780A360
        public void Complete(){} // RVA: 0x7FFE8780A870
        public void CompleteCallback(){} // RVA: 0x7FFE8780ABB0
    }

    public class Cookie : Object
    {
        public char[] PortSplitDelimiters;
        public char[] Reserved2Name; // 0x8
        public char[] Reserved2Value; // 0x10
        public System.Net.Comparer staticComparer; // 0x18
        public string m_comment; // 0x10
        public System.Uri m_commentUri; // 0x18
        public 0x66534C7C m_cookieVariant; // 0x20
        public bool m_discard; // 0x24
        public string m_domain; // 0x28
        public bool m_domain_implicit; // 0x30
        public System.DateTime m_expires; // 0x38
        public string m_name; // 0x40
        public string m_path; // 0x48
        public bool m_path_implicit; // 0x50
        public string m_port; // 0x58
        public bool m_port_implicit; // 0x60
        public int[] m_port_list; // 0x68
        public bool m_secure; // 0x70
        public bool m_httpOnly; // 0x71
        public System.DateTime m_timeStamp; // 0x78
        public string m_value; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876703C0
        public void get_Comment(){} // RVA: 0x7FFE81116380
        public void set_Comment(){} // RVA: 0x7FFE87670710
        public void set_CommentUri(){} // RVA: 0x7FFE81161E80
        public void set_HttpOnly(){} // RVA: 0x7FFE865EFE10
        public void set_Discard(){} // RVA: 0x7FFE812EB1B0
        public void get_Domain(){} // RVA: 0x7FFE81129130
        public void set_Domain(){} // RVA: 0x7FFE876707B0
        public void get__Domain(){} // RVA: 0x7FFE876708E0
        public void get_Expired(){} // RVA: 0x7FFE876709B0
        public void set_Expires(){} // RVA: 0x7FFE81CDDAA0
        public void get_Name(){} // RVA: 0x7FFE81178740
        public void set_Name(){} // RVA: 0x7FFE87670AF0
        public void InternalSetName(){} // RVA: 0x7FFE87670C50
        public void get_Path(){} // RVA: 0x7FFE81176730
        public void set_Path(){} // RVA: 0x7FFE87670DB0
        public void get__Path(){} // RVA: 0x7FFE87670E60
        public void get_Plain(){} // RVA: 0x7FFE86CB1DD0
        public void IsDomainEqualToHost(){} // RVA: 0x7FFE87670EF0
        public void VerifySetDefaults(){} // RVA: 0x7FFE87671120
        public void DomainCharsTest(){} // RVA: 0x7FFE87672230
        public void get_Port(){} // RVA: 0x7FFE811C3500
        public void set_Port(){} // RVA: 0x7FFE876722B0
        public void get_PortList(){} // RVA: 0x7FFE81176D50
        public void get__Port(){} // RVA: 0x7FFE876727F0
        public void get_Secure(){} // RVA: 0x7FFE81177320
        public void set_Secure(){} // RVA: 0x7FFE81177330
        public void get_Value(){} // RVA: 0x7FFE81280C30
        public void set_Value(){} // RVA: 0x7FFE876728C0
        public void get_Variant(){} // RVA: 0x7FFE8151D690
        public void get_DomainKey(){} // RVA: 0x7FFE87672980
        public void get_Version(){} // RVA: 0x7FFE8194AD00
        public void set_Version(){} // RVA: 0x7FFE876729A0
        public void get__Version(){} // RVA: 0x7FFE87672A20
        public void GetComparer(){} // RVA: 0x7FFE87672B30
        public void Equals(){} // RVA: 0x7FFE87672B90
        public void GetHashCode(){} // RVA: 0x7FFE87672E80
        public void ToString(){} // RVA: 0x7FFE87673070
        public void .cctor(){} // RVA: 0x7FFE87673590
    }

    public class CookieCollection : Object
    {
        public int m_version; // 0x10
        public System.Collections.ArrayList m_list; // 0x18
        public System.DateTime m_TimeStamp; // 0x20
        public bool m_has_other_versions; // 0x28
        public bool m_IsReadOnly; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876764C0
        public void get_Item(){} // RVA: 0x7FFE876765A0
        public void Add(){} // RVA: 0x7FFE87676770 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE85B0C750
        public void get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void CopyTo(){} // RVA: 0x7FFE87676A60
        public void TimeStamp(){} // RVA: 0x7FFE87676A90
        public void get_IsOtherVersionSeen(){} // RVA: 0x7FFE815F1380
        public void InternalAdd(){} // RVA: 0x7FFE87676B90
        public void IndexOf(){} // RVA: 0x7FFE87676ED0
        public void RemoveAt(){} // RVA: 0x7FFE87677140
        public void GetEnumerator(){} // RVA: 0x7FFE87677170
    }

    public class CookieContainer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876774A0
        public void AddRemoveDomain(){} // RVA: 0x7FFE87677680
        public void Add(){} // RVA: 0x7FFE87677880
        public void AgeCookies(){} // RVA: 0x7FFE876782C0
        public void ExpireCollection(){} // RVA: 0x7FFE87679530
        public void IsLocalDomain(){} // RVA: 0x7FFE87679750
        public void CookieCutter(){} // RVA: 0x7FFE87679C40
        public void InternalGetCookies(){} // RVA: 0x7FFE8767A4B0
        public void BuildCookieCollectionFromDomainMatches(){} // RVA: 0x7FFE8767A980
        public void MergeUpdateCollections(){} // RVA: 0x7FFE8767B1D0
        public void GetCookieHeader(){} // RVA: 0x7FFE8767B520 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8767B8F0
    }

    public class CookieException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE87660600
        public void GetObjectData(){} // RVA: 0x7FFE87660600
    }

    public class CookieParser : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87675380
        public void Get(){} // RVA: 0x7FFE87675490
        public void CheckQuoted(){} // RVA: 0x7FFE87676190
    }

    public class CookieTokenizer : Object
    {
        public bool m_eofCookie; // 0x10
        public int m_index; // 0x14
        public int m_length; // 0x18
        public string m_name; // 0x20
        public bool m_quoted; // 0x28
        public int m_start; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87673870
        public void get_EndOfCookie(){} // RVA: 0x7FFE811C55E0
        public void set_EndOfCookie(){} // RVA: 0x7FFE811C55F0
        public void get_Eof(){} // RVA: 0x7FFE876738E0
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void set_Name(){} // RVA: 0x7FFE811290D0
        public void get_Quoted(){} // RVA: 0x7FFE815F1380
        public void set_Quoted(){} // RVA: 0x7FFE81C15740
        public void get_Token(){} // RVA: 0x7FFE81156CD0
        public void set_Token(){} // RVA: 0x7FFE81156CE0
        public void get_Value(){} // RVA: 0x7FFE81178740
        public void set_Value(){} // RVA: 0x7FFE81123200
        public void Extract(){} // RVA: 0x7FFE876738F0
        public void FindNext(){} // RVA: 0x7FFE87673980
        public void Next(){} // RVA: 0x7FFE87673C10
        public void Reset(){} // RVA: 0x7FFE87674000
        public void TokenFromName(){} // RVA: 0x7FFE87674110
        public void .cctor(){} // RVA: 0x7FFE87674310
    }

    public class CredentialCache : Object
    {
        // ── Methods ──
        public void get_DefaultCredentials(){} // RVA: 0x7FFE8765B930
        public void get_DefaultNetworkCredentials(){} // RVA: 0x7FFE8765B990
    }

}