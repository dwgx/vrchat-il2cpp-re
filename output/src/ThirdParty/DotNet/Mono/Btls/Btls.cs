// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Btls
// Classes: 31
// Methods: 357

namespace ThirdParty.DotNet.Mono.Btls
{
    public class IMonoBtlsBioMono
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7A7E0A170
        public void Write(){} // RVA: 0x7A7E046D0
        public void Flush(){} // RVA: 0x7A7E18770
        public void Close(){} // RVA: 0x7A7E18770
    }

    public class MonoBtlsBio : MonoBtlsObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Handle(){} // RVA: 0x7AE485190
        public void mono_btls_bio_free(){} // RVA: 0x7AE485210
    }

    public class MonoBtlsBioMemory : MonoBtlsBio
    {
        // ── Methods ──
        public void mono_btls_bio_mem_new(){} // RVA: 0x7AE485380
        public void mono_btls_bio_mem_get_data(){} // RVA: 0x7AE4853F0
        public void .ctor(){} // RVA: 0x7AE485480
        public void GetData(){} // RVA: 0x7AE4855C0
    }

    public class MonoBtlsBioMono : MonoBtlsBio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE485830
        public void mono_btls_bio_mono_new(){} // RVA: 0x7AE485EF0
        public void mono_btls_bio_mono_initialize(){} // RVA: 0x7AE485F60
        public void Control(){} // RVA: 0x7AE486880
        public void OnRead(){} // RVA: 0x7AE486230
        public void OnWrite(){} // RVA: 0x7AE486620
        public void Close(){} // RVA: 0x7AE486A20
    }

    public class MonoBtlsContext : MobileTlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE486C30
        public void GetPrivateCertificate(){} // RVA: 0x7AE486CB0
        public void VerifyCallback(){} // RVA: 0x7AE486F40
        public void SelectCallback(){} // RVA: 0x7AE487160
        public void ServerNameCallback(){} // RVA: 0x7AE4872D0
        public void StartHandshake(){} // RVA: 0x7AE487390
        public void SetPrivateCertificate(){} // RVA: 0x7AE487730
        public void GetException(){} // RVA: 0x7AE487D90
        public void ProcessHandshake(){} // RVA: 0x7AE4883F0
        public void DoProcessHandshake(){} // RVA: 0x7AE488530
        public void FinishHandshake(){} // RVA: 0x7AE488730
        public void InitializeConnection(){} // RVA: 0x7AE488750
        public void GetPeerCertificate(){} // RVA: 0x7AE489210
        public void InitializeSession(){} // RVA: 0x7AE4894D0
        public void GetProtocol(){} // RVA: 0x7AE4898A0
        public void Flush(){} // RVA: 0x7AE489920
        public void Read(){} // RVA: 0x7AE489960
        public void Write(){} // RVA: 0x7AE489CF0
        public void Renegotiate(){} // RVA: 0x7AE48A030
        public void Shutdown(){} // RVA: 0x7AE48A070
        public void PendingRenegotiation(){} // RVA: 0x7AE48A220
        public void Dispose(){} // RVA: 0x7AE48A2D0
        public void Mono.Btls.IMonoBtlsBioMono.Read(){} // RVA: 0x7AE48A450
        public void Mono.Btls.IMonoBtlsBioMono.Write(){} // RVA: 0x7AE48A480
        public void Mono.Btls.IMonoBtlsBioMono.Flush(){} // RVA: 0x7A80D7310
        public void Mono.Btls.IMonoBtlsBioMono.Close(){} // RVA: 0x7A80D7310
        public void get_IsAuthenticated(){} // RVA: 0x7A9B256A0
        public void get_LocalClientCertificate(){} // RVA: 0x7A8175DF0
        public void get_RemoteCertificate(){} // RVA: 0x7A81A0050
    }

    public class MonoBtlsError : Object
    {
        // ── Methods ──
        public void mono_btls_error_clear_error(){} // RVA: 0x7AE48A4B0
        public void mono_btls_error_get_error_line(){} // RVA: 0x7AE48A520
        public void mono_btls_error_get_error_string_n(){} // RVA: 0x7AE48A5B0
        public void mono_btls_error_get_reason(){} // RVA: 0x7AE48A650
        public void ClearError(){} // RVA: 0x7AE48A4B0
        public void GetErrorString(){} // RVA: 0x7AE48A6D0
        public void GetError(){} // RVA: 0x7AE48A900
        public void GetErrorReason(){} // RVA: 0x7AE48A650
    }

    public class MonoBtlsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE48AC00
    }

    public class MonoBtlsKey : MonoBtlsObject
    {
        // ── Methods ──
        public void mono_btls_key_new(){} // RVA: 0x7AE48AD20
        public void mono_btls_key_free(){} // RVA: 0x7AE48AD90
        public void mono_btls_key_up_ref(){} // RVA: 0x7AE48AE10
        public void mono_btls_key_get_bytes(){} // RVA: 0x7AE48AE90
        public void mono_btls_key_assign_rsa_private_key(){} // RVA: 0x7AE48AF40
        public void get_Handle(){} // RVA: 0x7AE48AFF0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetBytes(){} // RVA: 0x7AE48B070
        public void Copy(){} // RVA: 0x7AE48B210
        public void CreateFromRSAPrivateKey(){} // RVA: 0x7AE48B3B0
    }

    public class MonoBtlsObject : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Handle(){} // RVA: 0x7AE48B690
        public void get_IsValid(){} // RVA: 0x7AE48B6B0
        public void CheckThrow(){} // RVA: 0x7AE48B6F0
        public void SetException(){} // RVA: 0x7AE48B790
        public void CheckError(){} // RVA: 0x7AE48B980
        public void CheckLastError(){} // RVA: 0x7AE48B990
        public void mono_btls_free(){} // RVA: 0x7AE48BB90
        public void FreeDataPtr(){} // RVA: 0x7AE48BC10
        public void Close(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7AE48BEE0
        public void Finalize(){} // RVA: 0x7AE48BF40
    }

    public class MonoBtlsPkcs12 : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE48BFA0
        public void mono_btls_pkcs12_free(){} // RVA: 0x7AE48C020
        public void mono_btls_pkcs12_new(){} // RVA: 0x7AE48C0A0
        public void mono_btls_pkcs12_get_count(){} // RVA: 0x7AE48C110
        public void mono_btls_pkcs12_get_cert(){} // RVA: 0x7AE48C190
        public void mono_btls_pkcs12_import(){} // RVA: 0x7AE48C220
        public void mono_btls_pkcs12_has_private_key(){} // RVA: 0x7AE48C320
        public void mono_btls_pkcs12_get_private_key(){} // RVA: 0x7AE48C3A0
        public void .ctor(){} // RVA: 0x7AE48C420
        public void get_Count(){} // RVA: 0x7AE48C560
        public void GetCertificate(){} // RVA: 0x7AE48C600
        public void Import(){} // RVA: 0x7AE48C7F0
        public void get_HasPrivateKey(){} // RVA: 0x7AE48C970
        public void GetPrivateKey(){} // RVA: 0x7AE48CA10
    }

    public class MonoBtlsProvider : MobileTlsProvider
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7AE48CCA0
        public void get_Name(){} // RVA: 0x7AE48CD00
        public void .ctor(){} // RVA: 0x7AE48CD40
        public void get_SupportsSslStream(){} // RVA: 0x7A81BD750
        public void get_SupportsMonoExtensions(){} // RVA: 0x7A81BD750
        public void get_SupportsConnectionInfo(){} // RVA: 0x7A81BD750
        public void get_SupportsCleanShutdown(){} // RVA: 0x7A81BD750
        public void get_SupportedProtocols(){} // RVA: 0x7AE475360
        public void CreateSslStream(){} // RVA: 0x7AE48CDD0
        public void GetNativeCertificate(){} // RVA: 0x7AE48D170
        public void GetVerifyParam(){} // RVA: 0x7AE48D1F0
        public void ValidateCertificate(){} // RVA: 0x7AE48DE10
        public void CheckValidationResult(){} // RVA: 0x7AE48E010
        public void MapVerifyErrorToChainStatus(){} // RVA: 0x7AE48E3C0
        public void SetupCertificateStore(){} // RVA: 0x7AE48E610
        public void SetupDefaultCertificateStore(){} // RVA: 0x7AE48EAC0
        public void AddUserStore(){} // RVA: 0x7AE48EB80
        public void AddMachineStore(){} // RVA: 0x7AE48EBF0
        public void AddTrustedRoots(){} // RVA: 0x7AE48EC60
        public void CreateCertificate(){} // RVA: 0x7AE48ED90
        public void GetManagedChain(){} // RVA: 0x7AE48EF00
        public void GetBtlsCertificate(){} // RVA: 0x7AE48EF90
        public void GetNativeChain(){} // RVA: 0x7AE48F090
    }

    public class MonoBtlsSelectCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFC8120
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class MonoBtlsServerNameCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA987EB0
        public void Invoke(){} // RVA: 0x7A8135ED0
    }

    public class MonoBtlsSsl : MonoBtlsObject
    {
        // ── Methods ──
        public void mono_btls_ssl_destroy(){} // RVA: 0x7AE9C49E0
        public void mono_btls_ssl_new(){} // RVA: 0x7AE9C4A60
        public void mono_btls_ssl_use_certificate(){} // RVA: 0x7AE9C4AE0
        public void mono_btls_ssl_use_private_key(){} // RVA: 0x7AE9C4B70
        public void mono_btls_ssl_add_chain_certificate(){} // RVA: 0x7AE9C4C00
        public void mono_btls_ssl_accept(){} // RVA: 0x7AE9C4C90
        public void mono_btls_ssl_connect(){} // RVA: 0x7AE9C4D10
        public void mono_btls_ssl_handshake(){} // RVA: 0x7AE9C4D90
        public void mono_btls_ssl_close(){} // RVA: 0x7AE9C4E10
        public void mono_btls_ssl_shutdown(){} // RVA: 0x7AE9C4E90
        public void mono_btls_ssl_set_quiet_shutdown(){} // RVA: 0x7AE9C4F10
        public void mono_btls_ssl_set_bio(){} // RVA: 0x7AE9C4FA0
        public void mono_btls_ssl_read(){} // RVA: 0x7AE9C5030
        public void mono_btls_ssl_write(){} // RVA: 0x7AE9C50D0
        public void mono_btls_ssl_get_error(){} // RVA: 0x7AE9C5170
        public void mono_btls_ssl_get_version(){} // RVA: 0x7AE9C5200
        public void mono_btls_ssl_get_cipher(){} // RVA: 0x7AE9C5280
        public void mono_btls_ssl_get_peer_certificate(){} // RVA: 0x7AE9C5300
        public void mono_btls_ssl_print_errors_cb(){} // RVA: 0x7AE9C5380
        public void mono_btls_ssl_set_server_name(){} // RVA: 0x7AE9C5410
        public void mono_btls_ssl_get_server_name(){} // RVA: 0x7AE9C54A0
        public void mono_btls_ssl_set_renegotiate_mode(){} // RVA: 0x7AE9C5520
        public void mono_btls_ssl_renegotiate_pending(){} // RVA: 0x7AE9C55B0
        public void Create_internal(){} // RVA: 0x7AE9C5630
        public void .ctor(){} // RVA: 0x7AE9C5780
        public void get_Handle(){} // RVA: 0x7AE9C5AE0
        public void SetBio(){} // RVA: 0x7AE9C5B60
        public void ThrowError(){} // RVA: 0x7AE9C5C80
        public void GetError(){} // RVA: 0x7AE9C5E30
        public void SetCertificate(){} // RVA: 0x7AE9C5EB0
        public void SetPrivateKey(){} // RVA: 0x7AE9C5FB0
        public void AddIntermediateCertificate(){} // RVA: 0x7AE9C60B0
        public void Accept(){} // RVA: 0x7AE9C61B0
        public void Connect(){} // RVA: 0x7AE9C6270
        public void Handshake(){} // RVA: 0x7AE9C6330
        public void PrintErrorsCallback(){} // RVA: 0x7AE9C63F0
        public void GetErrors(){} // RVA: 0x7AE9C6530
        public void PrintErrors(){} // RVA: 0x7AE9C66B0
        public void Read(){} // RVA: 0x7AE9C6740
        public void Write(){} // RVA: 0x7AE9C6840
        public void GetVersion(){} // RVA: 0x7AE9C6950
        public void GetCipher(){} // RVA: 0x7AE9C69F0
        public void GetPeerCertificate(){} // RVA: 0x7AE9C6AE0
        public void SetServerName(){} // RVA: 0x7AE9C6C70
        public void GetServerName(){} // RVA: 0x7AE9C6E70
        public void Shutdown(){} // RVA: 0x7AE9C6F80
        public void SetQuietShutdown(){} // RVA: 0x7AE9C7050
        public void Close(){} // RVA: 0x7AE9C70F0
        public void SetRenegotiateMode(){} // RVA: 0x7AE9C71C0
        public void RenegotiatePending(){} // RVA: 0x7AE9C7270
    }

    public class MonoBtlsSslCtx : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9C73A0
        public void mono_btls_ssl_ctx_new(){} // RVA: 0x7AE9C7420
        public void mono_btls_ssl_ctx_free(){} // RVA: 0x7AE9C7490
        public void mono_btls_ssl_ctx_initialize(){} // RVA: 0x7AE9C7510
        public void mono_btls_ssl_ctx_set_cert_verify_callback(){} // RVA: 0x7AE9C75A0
        public void mono_btls_ssl_ctx_set_cert_select_callback(){} // RVA: 0x7AE9C7640
        public void mono_btls_ssl_ctx_set_min_version(){} // RVA: 0x7AE9C76D0
        public void mono_btls_ssl_ctx_set_max_version(){} // RVA: 0x7AE9C7760
        public void mono_btls_ssl_ctx_set_ciphers(){} // RVA: 0x7AE9C77F0
        public void mono_btls_ssl_ctx_set_verify_param(){} // RVA: 0x7AE9C7890
        public void mono_btls_ssl_ctx_set_client_ca_list(){} // RVA: 0x7AE9C7920
        public void mono_btls_ssl_ctx_set_server_name_callback(){} // RVA: 0x7AE9C79C0
        public void .ctor(){} // RVA: 0x7AE9C7B40
        public void get_CertificateStore(){} // RVA: 0x7A8153390
        public void VerifyCallback(){} // RVA: 0x7AE9C82D0
        public void NativeVerifyCallback(){} // RVA: 0x7AE9C8300
        public void NativeSelectCallback(){} // RVA: 0x7AE9C86B0
        public void CopyIssuers(){} // RVA: 0x7AE9C8820
        public void SetVerifyCallback(){} // RVA: 0x7AE9C8BC0
        public void SetSelectCallback(){} // RVA: 0x7AE9C8CE0
        public void SetMinVersion(){} // RVA: 0x7AE9C8DE0
        public void SetMaxVersion(){} // RVA: 0x7AE9C8E90
        public void SetCiphers(){} // RVA: 0x7AE9C8F40
        public void SetVerifyParam(){} // RVA: 0x7AE9C9230
        public void SetClientCertificateIssuers(){} // RVA: 0x7AE9C9340
        public void SetServerNameCallback(){} // RVA: 0x7AE9C99E0
        public void NativeServerNameCallback(){} // RVA: 0x7AE9C9AE0
        public void Close(){} // RVA: 0x7AE9C9C10
    }

    public class MonoBtlsStream : MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9C9DC0
        public void CreateContext(){} // RVA: 0x7AE9C9E50
    }

    public class MonoBtlsUtils : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7AE9C9F30
        public void AppendEntry(){} // RVA: 0x7AE9C9FB0
        public void FormatName(){} // RVA: 0x7AE9CA680
        public void .cctor(){} // RVA: 0x7AE9CA7F0
    }

    public class MonoBtlsVerifyCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB168630
        public void Invoke(){} // RVA: 0x7A8133090
    }

    public class MonoBtlsX509 : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9CA8D0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void mono_btls_x509_up_ref(){} // RVA: 0x7AE9CA950
        public void mono_btls_x509_from_data(){} // RVA: 0x7AE9CA9D0
        public void mono_btls_x509_get_subject_name(){} // RVA: 0x7AE9CAA70
        public void mono_btls_x509_get_raw_data(){} // RVA: 0x7AE9CAAF0
        public void mono_btls_x509_cmp(){} // RVA: 0x7AE9CAB90
        public void mono_btls_x509_free(){} // RVA: 0x7AE9CAC20
        public void mono_btls_x509_add_explicit_trust(){} // RVA: 0x7AE9CACA0
        public void Copy(){} // RVA: 0x7AE9CAD30
        public void LoadFromData(){} // RVA: 0x7AE9CAED0
        public void GetSubjectName(){} // RVA: 0x7AE9CB1F0
        public void GetSubjectNameHash(){} // RVA: 0x7AE9CB3B0
        public void GetRawData(){} // RVA: 0x7AE9CB640
        public void Compare(){} // RVA: 0x7AE9CB940
        public void AddExplicitTrust(){} // RVA: 0x7AE9CBA10
    }

    public class MonoBtlsX509Chain : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9CBBA0
        public void mono_btls_x509_chain_new(){} // RVA: 0x7AE9CBC20
        public void mono_btls_x509_chain_get_count(){} // RVA: 0x7AE9CBC90
        public void mono_btls_x509_chain_get_cert(){} // RVA: 0x7AE9CBD10
        public void mono_btls_x509_chain_add_cert(){} // RVA: 0x7AE9CBDA0
        public void mono_btls_x509_chain_up_ref(){} // RVA: 0x7AE9CBE30
        public void mono_btls_x509_chain_free(){} // RVA: 0x7AE9CBEB0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Count(){} // RVA: 0x7AE9CC070
        public void GetCertificate(){} // RVA: 0x7AE9CC110
        public void AddCertificate(){} // RVA: 0x7AE9CC300
        public void Copy(){} // RVA: 0x7AE9CC3C0
    }

    public class MonoBtlsX509Lookup : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9CC5E0
        public void mono_btls_x509_lookup_new(){} // RVA: 0x7AE9CC660
        public void mono_btls_x509_lookup_add_dir(){} // RVA: 0x7AE9CC6F0
        public void mono_btls_x509_lookup_add_mono(){} // RVA: 0x7AE9CC790
        public void mono_btls_x509_lookup_free(){} // RVA: 0x7AE9CC820
        public void mono_btls_x509_lookup_peek_lookup(){} // RVA: 0x7AE9CC8A0
        public void Create_internal(){} // RVA: 0x7AE9CC920
        public void .ctor(){} // RVA: 0x7AE9CCA80
        public void GetNativeLookup(){} // RVA: 0x7AE9CCCB0
        public void AddDirectory(){} // RVA: 0x7AE9CCD50
        public void AddMono(){} // RVA: 0x7AE9CCF00
        public void AddCertificate(){} // RVA: 0x7AE9CD200
        public void Close(){} // RVA: 0x7AE9CD310
    }

    public class MonoBtlsX509LookupMono : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9CD5F0
        public void mono_btls_x509_lookup_mono_new(){} // RVA: 0x7AE9CD670
        public void mono_btls_x509_lookup_mono_init(){} // RVA: 0x7AE9CD6E0
        public void mono_btls_x509_lookup_mono_free(){} // RVA: 0x7AE9CD780
        public void .ctor(){} // RVA: 0x7AE9CD800
        public void Install(){} // RVA: 0x7AE9CDB80
        public void AddCertificate(){} // RVA: 0x7AE9CDC20
        public void OnGetBySubject(){} // RVA: 0x7AE9CDD40
        public void Close(){} // RVA: 0x7AE9CE070
    }

    public class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9CE220
        public void Initialize(){} // RVA: 0x7AE9CE2B0
        public void OnGetBySubject(){} // RVA: 0x7AE9CE700
        public void Close(){} // RVA: 0x7AE9CE7D0
    }

    public class MonoBtlsX509Name : MonoBtlsObject
    {
        // ── Methods ──
        public void mono_btls_x509_name_hash(){} // RVA: 0x7AE9CE9B0
        public void mono_btls_x509_name_get_entry_count(){} // RVA: 0x7AE9CEA30
        public void mono_btls_x509_name_get_entry_type(){} // RVA: 0x7AE9CEAB0
        public void mono_btls_x509_name_get_entry_oid(){} // RVA: 0x7AE9CEB40
        public void mono_btls_x509_name_get_entry_oid_data(){} // RVA: 0x7AE9CEBE0
        public void mono_btls_x509_name_get_entry_value(){} // RVA: 0x7AE9CEC80
        public void mono_btls_x509_name_from_data(){} // RVA: 0x7AE9CED20
        public void mono_btls_x509_name_free(){} // RVA: 0x7AE9CEDC0
        public void get_Handle(){} // RVA: 0x7AE9CEE40
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetHash(){} // RVA: 0x7AE9CEEC0
        public void GetEntryCount(){} // RVA: 0x7AE9CEF60
        public void GetEntryType(){} // RVA: 0x7AE9CF000
        public void GetEntryOid(){} // RVA: 0x7AE9CF0F0
        public void GetEntryOidData(){} // RVA: 0x7AE9CF380
        public void GetEntryValue(){} // RVA: 0x7AE9CF4F0
        public void CreateFromData(){} // RVA: 0x7AE9CF710
    }

    public class MonoBtlsX509Store : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9CF9E0
        public void mono_btls_x509_store_new(){} // RVA: 0x7AE9CFA60
        public void mono_btls_x509_store_from_ssl_ctx(){} // RVA: 0x7AE9CFAD0
        public void mono_btls_x509_store_add_cert(){} // RVA: 0x7AE9CFB50
        public void mono_btls_x509_store_free(){} // RVA: 0x7AE9CFBE0
        public void Create_internal(){} // RVA: 0x7AE9CFD80
        public void .ctor(){} // RVA: 0x7AE9D0030
        public void AddCertificate(){} // RVA: 0x7AE9D01C0
        public void AddLookup(){} // RVA: 0x7AE9D02D0
        public void AddDirectoryLookup(){} // RVA: 0x7AE9D05E0
        public void AddCollection(){} // RVA: 0x7AE9D0630
        public void Close(){} // RVA: 0x7AE9D0740
    }

    public class MonoBtlsX509StoreCtx : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9D0AF0
        public void mono_btls_x509_store_ctx_new(){} // RVA: 0x7AE9D0B70
        public void mono_btls_x509_store_ctx_from_ptr(){} // RVA: 0x7AE9D0BE0
        public void mono_btls_x509_store_ctx_get_error(){} // RVA: 0x7AE9D0C60
        public void mono_btls_x509_store_ctx_get_chain(){} // RVA: 0x7AE9D0CF0
        public void mono_btls_x509_store_ctx_init(){} // RVA: 0x7AE9D0D70
        public void mono_btls_x509_store_ctx_set_param(){} // RVA: 0x7AE9D0E10
        public void mono_btls_x509_store_ctx_verify_cert(){} // RVA: 0x7AE9D0EA0
        public void mono_btls_x509_store_ctx_get_untrusted(){} // RVA: 0x7AE9D0F20
        public void mono_btls_x509_store_ctx_up_ref(){} // RVA: 0x7AE9D0FA0
        public void mono_btls_x509_store_ctx_free(){} // RVA: 0x7AE9D1020
        public void .ctor(){} // RVA: 0x7AE9D14E0
        public void Create_internal(){} // RVA: 0x7AE9D11E0
        public void GetError(){} // RVA: 0x7AE9D1540
        public void GetChain(){} // RVA: 0x7AE9D15F0
        public void GetUntrusted(){} // RVA: 0x7AE9D1790
        public void Initialize(){} // RVA: 0x7AE9D1930
        public void SetVerifyParam(){} // RVA: 0x7AE9D1A70
        public void get_VerifyResult(){} // RVA: 0x7AE9D1B80
        public void Verify(){} // RVA: 0x7AE9D1C10
        public void Copy(){} // RVA: 0x7AE9D1D10
    }

    public class MonoBtlsX509StoreManager : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AE9D1F60
        public void DoInitialize(){} // RVA: 0x7AE9D2060
        public void GetStorePath(){} // RVA: 0x7AE9D2760
    }

    public class MonoBtlsX509VerifyParam : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7AE9D28A0
        public void mono_btls_x509_verify_param_copy(){} // RVA: 0x7AE9D2920
        public void mono_btls_x509_verify_param_lookup(){} // RVA: 0x7AE9D29A0
        public void mono_btls_x509_verify_param_can_modify(){} // RVA: 0x7AE9D2A20
        public void mono_btls_x509_verify_param_set_host(){} // RVA: 0x7AE9D2AA0
        public void mono_btls_x509_verify_param_set_time(){} // RVA: 0x7AE9D2B40
        public void mono_btls_x509_verify_param_free(){} // RVA: 0x7AE9D2BD0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Copy(){} // RVA: 0x7AE9D2C50
        public void GetSslClient(){} // RVA: 0x7AE9D2DF0
        public void GetSslServer(){} // RVA: 0x7AE9D2E30
        public void Lookup(){} // RVA: 0x7AE9D2E70
        public void get_CanModify(){} // RVA: 0x7AE9D3160
        public void WantToModify(){} // RVA: 0x7AE9D3200
        public void SetHost(){} // RVA: 0x7AE9D32F0
        public void SetTime(){} // RVA: 0x7AE9D34B0
    }

    public class X509CertificateImplBtls : X509Certificate2ImplUnix
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9D3B80
        public void get_IsValid(){} // RVA: 0x7AE9D3D20
        public void get_X509(){} // RVA: 0x7AE9D3D70
        public void get_NativePrivateKey(){} // RVA: 0x7AE9D3DC0
        public void Clone(){} // RVA: 0x7AE9D3E10
        public void GetRawCertData(){} // RVA: 0x7AE9D3EB0
        public void get_IntermediateCertificates(){} // RVA: 0x7A81426F0
        public void Dispose(){} // RVA: 0x7AE9D3F60
        public void get_HasPrivateKey(){} // RVA: 0x7AE7888D0
        public void get_PrivateKey(){} // RVA: 0x7AE9D4040
        public void set_PrivateKey(){} // RVA: 0x7AE9D4080
        public void GetRSAPrivateKey(){} // RVA: 0x7AE9D4040
        public void GetDSAPrivateKey(){} // RVA: 0x7AE9D41F0
        public void Import(){} // RVA: 0x7AE9D4230
        public void ImportPkcs12(){} // RVA: 0x7AE9D42F0
        public void ImportAuthenticode(){} // RVA: 0x7AE9D4A70
        public void Verify(){} // RVA: 0x7AE9D4B10
    }

    public class X509ChainImplBtls : X509ChainImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9D5060
        public void get_IsValid(){} // RVA: 0x7AE9D59A0
        public void get_StoreCtx(){} // RVA: 0x7AE9D59E0
        public void get_ChainElements(){} // RVA: 0x7AE9D5A30
        public void get_ChainPolicy(){} // RVA: 0x7A8154D80
        public void AddStatus(){} // RVA: 0x7AE9D5E20
        public void Build(){} // RVA: 0x7A80D7320
        public void Reset(){} // RVA: 0x7AE9D5FB0
        public void Dispose(){} // RVA: 0x7AE9D6120
    }

    public class X509PalImplBtls : X509PalImpl
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE9D6430
        public void get_Provider(){} // RVA: 0x7A80F2570
        public void Import(){} // RVA: 0x7AE9D65B0
    }

}