// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Net
// Classes: 13
// Methods: 151

namespace ThirdParty.DotNet.System.Net
{
    public class CaseInsensitiveAscii
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x6B261F0
        public void Compare(){} // RVA: 0x6B26300
        public void FastGetHashCode(){} // RVA: 0x6B264C0
        public void Equals(){} // RVA: 0x6B265A0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6B26730
    }

    public class ChunkedInputStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B473F0
        public void Read(){} // RVA: 0x6B475C0
        public void BeginRead(){} // RVA: 0x6B47610
        public void OnRead(){} // RVA: 0x6B47A50
        public void EndRead(){} // RVA: 0x6B47D70
        public void Close(){} // RVA: 0x6B47FA0
    }

    public class CommandStream
    {
        public System.AsyncCallback s_writeCallbackDelegate;
        public System.AsyncCallback s_readCallbackDelegate; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CD0B70
        public void Abort(){} // RVA: 0x6CD0DD0
        public void Dispose(){} // RVA: 0x6CD10B0
        public void InvokeRequestCallback(){} // RVA: 0x6CD1150
        public void get_RecoverableFailure(){} // RVA: 0x4A6500
        public void MarkAsRecoverableFailure(){} // RVA: 0x6CD11F0
        public void SubmitRequest(){} // RVA: 0x6CD1200
        public void ClearState(){} // RVA: 0x6CD12A0
        public void BuildCommandsList(){} // RVA: 0x519240
        public void GenerateException(){} // RVA: 0x6CD1350 | overloaded x2
        public void InitCommandPipeline(){} // RVA: 0x6CD1400
        public void CheckContinuePipeline(){} // RVA: 0x6CD15D0
        public void ContinueCommandPipeline(){} // RVA: 0x6CD1610
        public void PostSendCommandProcessing(){} // RVA: 0x6CD1A00
        public void PostReadCommandProcessing(){} // RVA: 0x6CD1B80
        public void PipelineCallback(){} // RVA: 0x519240
        public void ReadCallback(){} // RVA: 0x6CD1DD0
        public void WriteCallback(){} // RVA: 0x6CD1FE0
        public void get_Encoding(){} // RVA: 0x4C7C50
        public void set_Encoding(){} // RVA: 0x6CD2170
        public void CheckValid(){} // RVA: 0x2DD320
        public void ReceiveCommandResponse(){} // RVA: 0x6CD2260
        public void ReceiveCommandResponseCallback(){} // RVA: 0x6CD2510
        public void .cctor(){} // RVA: 0x6CD2C60
    }

    public class Comparer
    {
        // ── Methods ──
        public void System.Collections.IComparer.Compare(){} // RVA: 0x6B36F80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ContentDecodeStream
    {
        public System.IO.Stream <OriginalInnerStream>k__BackingField; // 0x40

        // ── Methods ──
        public void Create(){} // RVA: 0x6B48080
        public void get_OriginalInnerStream(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x6B46C60
        public void ProcessReadAsync(){} // RVA: 0x6B1C3A0
        public void FinishReading(){} // RVA: 0x6B481D0
    }

    public class ContextAwareResult
    {
        // ── Methods ──
        public void SafeCaptureIdentity(){} // RVA: 0x2DD310
        public void CleanupInternal(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x6CC9160 | overloaded x3
        public void StartPostingAsyncOp(){} // RVA: 0x6CC92D0 | overloaded x2
        public void FinishPostingAsyncOp(){} // RVA: 0x6CC93F0
        public void Cleanup(){} // RVA: 0x6CC9430
        public void CaptureOrComplete(){} // RVA: 0x6CC94C0
        public void Complete(){} // RVA: 0x6CC99D0
        public void CompleteCallback(){} // RVA: 0x6CC9D10
    }

    public class Cookie
    {
        public char[] PortSplitDelimiters;
        public char[] Reserved2Name; // 0x8
        public char[] Reserved2Value; // 0x10
        public System.Net.Comparer staticComparer; // 0x18
        public string m_comment; // 0x10
        public System.Uri m_commentUri; // 0x18
        public 0x65856CD8 m_cookieVariant; // 0x20
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
        public void .ctor(){} // RVA: 0x6B31110
        public void get_Comment(){} // RVA: 0x2F8380
        public void set_Comment(){} // RVA: 0x6B31460
        public void set_CommentUri(){} // RVA: 0x343E80
        public void set_HttpOnly(){} // RVA: 0x5AAEFE0
        public void set_Discard(){} // RVA: 0x4D7670
        public void get_Domain(){} // RVA: 0x30B130
        public void set_Domain(){} // RVA: 0x6B31500
        public void get__Domain(){} // RVA: 0x6B31630
        public void get_Expired(){} // RVA: 0x6B31700
        public void set_Expires(){} // RVA: 0xF501D0
        public void get_Name(){} // RVA: 0x35A740
        public void set_Name(){} // RVA: 0x6B31840
        public void InternalSetName(){} // RVA: 0x6B319A0
        public void get_Path(){} // RVA: 0x358730
        public void set_Path(){} // RVA: 0x6B31B00
        public void get__Path(){} // RVA: 0x6B31BB0
        public void get_Plain(){} // RVA: 0x6170FE0
        public void IsDomainEqualToHost(){} // RVA: 0x6B31C40
        public void VerifySetDefaults(){} // RVA: 0x6B31E70
        public void DomainCharsTest(){} // RVA: 0x6B32F80
        public void get_Port(){} // RVA: 0x3A5500
        public void set_Port(){} // RVA: 0x6B33000
        public void get_PortList(){} // RVA: 0x358D50
        public void get__Port(){} // RVA: 0x6B33540
        public void get_Secure(){} // RVA: 0x359320
        public void set_Secure(){} // RVA: 0x359330
        public void get_Value(){} // RVA: 0x462D00
        public void set_Value(){} // RVA: 0x6B33610
        public void get_Variant(){} // RVA: 0x760030
        public void get_DomainKey(){} // RVA: 0x6B336D0
        public void get_Version(){} // RVA: 0xBB90C0
        public void set_Version(){} // RVA: 0x6B336F0
        public void get__Version(){} // RVA: 0x6B33770
        public void GetComparer(){} // RVA: 0x6B33880
        public void Equals(){} // RVA: 0x6B338E0
        public void GetHashCode(){} // RVA: 0x6B33BD0
        public void ToString(){} // RVA: 0x6B33DC0
        public void .cctor(){} // RVA: 0x6B342E0
    }

    public class CookieCollection
    {
        public int m_version; // 0x10
        public System.Collections.ArrayList m_list; // 0x18
        public System.DateTime m_TimeStamp; // 0x20
        public bool m_has_other_versions; // 0x28
        public bool m_IsReadOnly; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B37210
        public void get_Item(){} // RVA: 0x6B372F0
        public void Add(){} // RVA: 0x6B374C0 | overloaded x2
        public void get_Count(){} // RVA: 0x5C64F90
        public void get_IsSynchronized(){} // RVA: 0x2DD320
        public void get_SyncRoot(){} // RVA: 0x1A3F520
        public void CopyTo(){} // RVA: 0x6B377B0
        public void TimeStamp(){} // RVA: 0x6B377E0
        public void get_IsOtherVersionSeen(){} // RVA: 0x6E8A80
        public void InternalAdd(){} // RVA: 0x6B378E0
        public void IndexOf(){} // RVA: 0x6B37C20
        public void RemoveAt(){} // RVA: 0x6B37E90
        public void GetEnumerator(){} // RVA: 0x6B37EC0
    }

    public class CookieContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B381F0
        public void AddRemoveDomain(){} // RVA: 0x6B383D0
        public void Add(){} // RVA: 0x6B385D0
        public void AgeCookies(){} // RVA: 0x6B39010
        public void ExpireCollection(){} // RVA: 0x6B3A280
        public void IsLocalDomain(){} // RVA: 0x6B3A4A0
        public void CookieCutter(){} // RVA: 0x6B3A990
        public void InternalGetCookies(){} // RVA: 0x6B3B200
        public void BuildCookieCollectionFromDomainMatches(){} // RVA: 0x6B3B6D0
        public void MergeUpdateCollections(){} // RVA: 0x6B3BF20
        public void GetCookieHeader(){} // RVA: 0x6B3C270 | overloaded x2
        public void .cctor(){} // RVA: 0x6B3C640
    }

    public class CookieException : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A3E1C0 | overloaded x4
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6B21340
        public void GetObjectData(){} // RVA: 0x6B21340
    }

    public class CookieParser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B360D0
        public void Get(){} // RVA: 0x6B361E0
        public void CheckQuoted(){} // RVA: 0x6B36EE0
    }

    public class CookieTokenizer
    {
        public bool m_eofCookie; // 0x10
        public int m_index; // 0x14
        public int m_length; // 0x18
        public string m_name; // 0x20
        public bool m_quoted; // 0x28
        public int m_start; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B345C0
        public void get_EndOfCookie(){} // RVA: 0x3A75E0
        public void set_EndOfCookie(){} // RVA: 0x3A75F0
        public void get_Eof(){} // RVA: 0x6B34630
        public void get_Name(){} // RVA: 0x30B0C0
        public void set_Name(){} // RVA: 0x30B0D0
        public void get_Quoted(){} // RVA: 0x6E8A80
        public void set_Quoted(){} // RVA: 0x6E8B80
        public void get_Token(){} // RVA: 0x338CD0
        public void set_Token(){} // RVA: 0x338CE0
        public void get_Value(){} // RVA: 0x35A740
        public void set_Value(){} // RVA: 0x305200
        public void Extract(){} // RVA: 0x6B34640
        public void FindNext(){} // RVA: 0x6B346D0
        public void Next(){} // RVA: 0x6B34960
        public void Reset(){} // RVA: 0x6B34D50
        public void TokenFromName(){} // RVA: 0x6B34E60
        public void .cctor(){} // RVA: 0x6B35060
    }

    public class CredentialCache
    {
        // ── Methods ──
        public void get_DefaultCredentials(){} // RVA: 0x6B1C670
        public void get_DefaultNetworkCredentials(){} // RVA: 0x6B1C6D0
    }

}