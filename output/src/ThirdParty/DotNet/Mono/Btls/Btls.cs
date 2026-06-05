// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Btls
// Classes: 31
// Methods: 382

namespace ThirdParty.DotNet.Mono.Btls
{
    public class IMonoBtlsBioMono
    {
        // ── Methods ──
        public void Read(){}
        public void Write(){}
        public void Flush(){} // RVA: 0x7FFAF2AD4A50
        public void Close(){} // RVA: 0x7FFAF2AD4A50
    }

    public class MonoBtlsBio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Handle(){} // RVA: 0x7FFAF9146D40
        public void mono_btls_bio_free(){} // RVA: 0x7FFAF9146DC0
    }

    public class MonoBtlsBioMemory
    {
        // ── Methods ──
        public void mono_btls_bio_mem_new(){} // RVA: 0x7FFAF9146F30
        public void mono_btls_bio_mem_get_data(){} // RVA: 0x7FFAF9146FA0
        public void .ctor(){} // RVA: 0x7FFAF9147030
        public void GetData(){} // RVA: 0x7FFAF9147170
    }

    public class MonoBtlsBioMono
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91473F0
        public void mono_btls_bio_mono_new(){} // RVA: 0x7FFAF9147AB0
        public void mono_btls_bio_mono_initialize(){} // RVA: 0x7FFAF9147B20
        public void Control(){} // RVA: 0x7FFAF9148440 | overloaded x2
        public void OnRead(){} // RVA: 0x7FFAF9147DF0 | overloaded x2
        public void OnWrite(){} // RVA: 0x7FFAF91481E0 | overloaded x2
        public void Close(){} // RVA: 0x7FFAF91485E0
    }

    public class MonoBtlsContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91487F0
        public void GetPrivateCertificate(){} // RVA: 0x7FFAF9148870
        public void VerifyCallback(){} // RVA: 0x7FFAF9148B10
        public void SelectCallback(){} // RVA: 0x7FFAF9148D30
        public void ServerNameCallback(){} // RVA: 0x7FFAF9148EA0
        public void StartHandshake(){} // RVA: 0x7FFAF9148F60
        public void SetPrivateCertificate(){} // RVA: 0x7FFAF9149300
        public void GetException(){} // RVA: 0x7FFAF9149960
        public void ProcessHandshake(){} // RVA: 0x7FFAF9149FC0
        public void DoProcessHandshake(){} // RVA: 0x7FFAF914A100
        public void FinishHandshake(){} // RVA: 0x7FFAF914A300
        public void InitializeConnection(){} // RVA: 0x7FFAF914A320
        public void GetPeerCertificate(){} // RVA: 0x7FFAF914ADF0
        public void InitializeSession(){} // RVA: 0x7FFAF914B0A0
        public void GetProtocol(){} // RVA: 0x7FFAF914B470
        public void Flush(){} // RVA: 0x7FFAF914B4F0
        public void Read(){} // RVA: 0x7FFAF914B530
        public void Write(){} // RVA: 0x7FFAF914B8B0
        public void Renegotiate(){} // RVA: 0x7FFAF914BBE0
        public void Shutdown(){} // RVA: 0x7FFAF914BC20
        public void PendingRenegotiation(){} // RVA: 0x7FFAF914BDD0
        public void Dispose(){} // RVA: 0x7FFAF914BE80 | overloaded x2
        public void Mono.Btls.IMonoBtlsBioMono.Read(){} // RVA: 0x7FFAF914C000
        public void Mono.Btls.IMonoBtlsBioMono.Write(){} // RVA: 0x7FFAF914C030
        public void Mono.Btls.IMonoBtlsBioMono.Flush(){} // RVA: 0x7FFAF2D8D310
        public void Mono.Btls.IMonoBtlsBioMono.Close(){} // RVA: 0x7FFAF2D8D310
        public void get_IsAuthenticated(){} // RVA: 0x7FFAF47D3080
        public void get_LocalClientCertificate(){} // RVA: 0x7FFAF2E2B370
        public void get_RemoteCertificate(){} // RVA: 0x7FFAF2E55500
    }

    public class MonoBtlsError
    {
        // ── Methods ──
        public void mono_btls_error_clear_error(){} // RVA: 0x7FFAF914C060
        public void mono_btls_error_get_error_line(){} // RVA: 0x7FFAF914C0D0
        public void mono_btls_error_get_error_string_n(){} // RVA: 0x7FFAF914C160
        public void mono_btls_error_get_reason(){} // RVA: 0x7FFAF914C200
        public void ClearError(){} // RVA: 0x7FFAF914C060
        public void GetErrorString(){} // RVA: 0x7FFAF914C280
        public void GetError(){} // RVA: 0x7FFAF914C4B0
        public void GetErrorReason(){} // RVA: 0x7FFAF914C200
    }

    public class MonoBtlsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF914C7C0 | overloaded x4
    }

    public class MonoBtlsKey
    {
        // ── Methods ──
        public void mono_btls_key_new(){} // RVA: 0x7FFAF914C8E0
        public void mono_btls_key_free(){} // RVA: 0x7FFAF914C950
        public void mono_btls_key_up_ref(){} // RVA: 0x7FFAF914C9D0
        public void mono_btls_key_get_bytes(){} // RVA: 0x7FFAF914CA50
        public void mono_btls_key_assign_rsa_private_key(){} // RVA: 0x7FFAF914CB00
        public void get_Handle(){} // RVA: 0x7FFAF914CBB0
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetBytes(){} // RVA: 0x7FFAF914CC30
        public void Copy(){} // RVA: 0x7FFAF914CDD0
        public void CreateFromRSAPrivateKey(){} // RVA: 0x7FFAF914CF70
    }

    public class MonoBtlsObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Handle(){} // RVA: 0x7FFAF914D240
        public void get_IsValid(){} // RVA: 0x7FFAF914D260
        public void CheckThrow(){} // RVA: 0x7FFAF914D2A0
        public void SetException(){} // RVA: 0x7FFAF914D340
        public void CheckError(){} // RVA: 0x7FFAF914D530 | overloaded x2
        public void CheckLastError(){} // RVA: 0x7FFAF914D540
        public void mono_btls_free(){} // RVA: 0x7FFAF914D740
        public void FreeDataPtr(){} // RVA: 0x7FFAF914D7C0
        public void Close(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF914DAA0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF914DB00
    }

    public class MonoBtlsPkcs12
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF914DB60
        public void mono_btls_pkcs12_free(){} // RVA: 0x7FFAF914DBE0
        public void mono_btls_pkcs12_new(){} // RVA: 0x7FFAF914DC60
        public void mono_btls_pkcs12_get_count(){} // RVA: 0x7FFAF914DCD0
        public void mono_btls_pkcs12_get_cert(){} // RVA: 0x7FFAF914DD50
        public void mono_btls_pkcs12_import(){} // RVA: 0x7FFAF914DDE0
        public void mono_btls_pkcs12_has_private_key(){} // RVA: 0x7FFAF914DEE0
        public void mono_btls_pkcs12_get_private_key(){} // RVA: 0x7FFAF914DF60
        public void .ctor(){} // RVA: 0x7FFAF914DFE0
        public void get_Count(){} // RVA: 0x7FFAF914E120
        public void GetCertificate(){} // RVA: 0x7FFAF914E1C0
        public void Import(){} // RVA: 0x7FFAF914E3B0
        public void get_HasPrivateKey(){} // RVA: 0x7FFAF914E530
        public void GetPrivateKey(){} // RVA: 0x7FFAF914E5D0
    }

    public class MonoBtlsProvider
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFAF914E860
        public void get_Name(){} // RVA: 0x7FFAF914E8C0
        public void .ctor(){} // RVA: 0x7FFAF914E900
        public void get_SupportsSslStream(){} // RVA: 0x7FFAF2E72850
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFAF2E72850
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFAF2E72850
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFAF2E72850
        public void get_SupportedProtocols(){} // RVA: 0x7FFAF9136B80
        public void CreateSslStream(){} // RVA: 0x7FFAF914E990
        public void GetNativeCertificate(){} // RVA: 0x7FFAF914ED30 | overloaded x3
        public void GetVerifyParam(){} // RVA: 0x7FFAF914EDB0
        public void ValidateCertificate(){} // RVA: 0x7FFAF914F9A0 | overloaded x2
        public void CheckValidationResult(){} // RVA: 0x7FFAF914FBA0
        public void MapVerifyErrorToChainStatus(){} // RVA: 0x7FFAF914FF50
        public void SetupCertificateStore(){} // RVA: 0x7FFAF91501A0
        public void SetupDefaultCertificateStore(){} // RVA: 0x7FFAF9150690
        public void AddUserStore(){} // RVA: 0x7FFAF91507B0
        public void AddMachineStore(){} // RVA: 0x7FFAF9150850
        public void AddTrustedRoots(){} // RVA: 0x7FFAF91508F0
        public void CreateCertificate(){} // RVA: 0x7FFAF9150A20
        public void GetManagedChain(){} // RVA: 0x7FFAF9150B90
        public void GetBtlsCertificate(){} // RVA: 0x7FFAF9150C20
        public void GetNativeChain(){} // RVA: 0x7FFAF9150D30
    }

    public class MonoBtlsSelectCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8C8B4E0
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class MonoBtlsServerNameCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5669710
        public void Invoke(){} // RVA: 0x7FFAF2DEBA50
    }

    public class MonoBtlsSsl
    {
        // ── Methods ──
        public void mono_btls_ssl_destroy(){} // RVA: 0x7FFAF9685AE0
        public void mono_btls_ssl_new(){} // RVA: 0x7FFAF9685B60
        public void mono_btls_ssl_use_certificate(){} // RVA: 0x7FFAF9685BE0
        public void mono_btls_ssl_use_private_key(){} // RVA: 0x7FFAF9685C70
        public void mono_btls_ssl_add_chain_certificate(){} // RVA: 0x7FFAF9685D00
        public void mono_btls_ssl_accept(){} // RVA: 0x7FFAF9685D90
        public void mono_btls_ssl_connect(){} // RVA: 0x7FFAF9685E10
        public void mono_btls_ssl_handshake(){} // RVA: 0x7FFAF9685E90
        public void mono_btls_ssl_close(){} // RVA: 0x7FFAF9685F10
        public void mono_btls_ssl_shutdown(){} // RVA: 0x7FFAF9685F90
        public void mono_btls_ssl_set_quiet_shutdown(){} // RVA: 0x7FFAF9686010
        public void mono_btls_ssl_set_bio(){} // RVA: 0x7FFAF96860A0
        public void mono_btls_ssl_read(){} // RVA: 0x7FFAF9686130
        public void mono_btls_ssl_write(){} // RVA: 0x7FFAF96861D0
        public void mono_btls_ssl_get_error(){} // RVA: 0x7FFAF9686270
        public void mono_btls_ssl_get_version(){} // RVA: 0x7FFAF9686300
        public void mono_btls_ssl_get_cipher(){} // RVA: 0x7FFAF9686380
        public void mono_btls_ssl_get_peer_certificate(){} // RVA: 0x7FFAF9686400
        public void mono_btls_ssl_print_errors_cb(){} // RVA: 0x7FFAF9686480
        public void mono_btls_ssl_set_server_name(){} // RVA: 0x7FFAF9686510
        public void mono_btls_ssl_get_server_name(){} // RVA: 0x7FFAF96865A0
        public void mono_btls_ssl_set_renegotiate_mode(){} // RVA: 0x7FFAF9686620
        public void mono_btls_ssl_renegotiate_pending(){} // RVA: 0x7FFAF96866B0
        public void Create_internal(){} // RVA: 0x7FFAF9686730
        public void .ctor(){} // RVA: 0x7FFAF9686880
        public void get_Handle(){} // RVA: 0x7FFAF9686BE0
        public void SetBio(){} // RVA: 0x7FFAF9686C60
        public void ThrowError(){} // RVA: 0x7FFAF9686D80
        public void GetError(){} // RVA: 0x7FFAF9686F30
        public void SetCertificate(){} // RVA: 0x7FFAF9686FB0
        public void SetPrivateKey(){} // RVA: 0x7FFAF96870B0
        public void AddIntermediateCertificate(){} // RVA: 0x7FFAF96871B0
        public void Accept(){} // RVA: 0x7FFAF96872B0
        public void Connect(){} // RVA: 0x7FFAF9687370
        public void Handshake(){} // RVA: 0x7FFAF9687430
        public void PrintErrorsCallback(){} // RVA: 0x7FFAF96874F0
        public void GetErrors(){} // RVA: 0x7FFAF9687630
        public void PrintErrors(){} // RVA: 0x7FFAF96877B0
        public void Read(){} // RVA: 0x7FFAF9687840
        public void Write(){} // RVA: 0x7FFAF9687940
        public void GetVersion(){} // RVA: 0x7FFAF9687A50
        public void GetCipher(){} // RVA: 0x7FFAF9687AF0
        public void GetPeerCertificate(){} // RVA: 0x7FFAF9687BE0
        public void SetServerName(){} // RVA: 0x7FFAF9687D70
        public void GetServerName(){} // RVA: 0x7FFAF9687F60
        public void Shutdown(){} // RVA: 0x7FFAF9688070
        public void SetQuietShutdown(){} // RVA: 0x7FFAF9688140
        public void Close(){} // RVA: 0x7FFAF96881E0
        public void SetRenegotiateMode(){} // RVA: 0x7FFAF96882B0
        public void RenegotiatePending(){} // RVA: 0x7FFAF9688360
    }

    public class MonoBtlsSslCtx
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF9688490
        public void mono_btls_ssl_ctx_new(){} // RVA: 0x7FFAF9688510
        public void mono_btls_ssl_ctx_free(){} // RVA: 0x7FFAF9688580
        public void mono_btls_ssl_ctx_initialize(){} // RVA: 0x7FFAF9688600
        public void mono_btls_ssl_ctx_set_cert_verify_callback(){} // RVA: 0x7FFAF9688690
        public void mono_btls_ssl_ctx_set_cert_select_callback(){} // RVA: 0x7FFAF9688730
        public void mono_btls_ssl_ctx_set_min_version(){} // RVA: 0x7FFAF96887C0
        public void mono_btls_ssl_ctx_set_max_version(){} // RVA: 0x7FFAF9688850
        public void mono_btls_ssl_ctx_set_ciphers(){} // RVA: 0x7FFAF96888E0
        public void mono_btls_ssl_ctx_set_verify_param(){} // RVA: 0x7FFAF9688980
        public void mono_btls_ssl_ctx_set_client_ca_list(){} // RVA: 0x7FFAF9688A10
        public void mono_btls_ssl_ctx_set_server_name_callback(){} // RVA: 0x7FFAF9688AB0
        public void .ctor(){} // RVA: 0x7FFAF9688C30 | overloaded x2
        public void get_CertificateStore(){} // RVA: 0x7FFAF2E08D50
        public void VerifyCallback(){} // RVA: 0x7FFAF96893C0
        public void NativeVerifyCallback(){} // RVA: 0x7FFAF96893F0
        public void NativeSelectCallback(){} // RVA: 0x7FFAF96897A0
        public void CopyIssuers(){} // RVA: 0x7FFAF9689910
        public void SetVerifyCallback(){} // RVA: 0x7FFAF9689CB0
        public void SetSelectCallback(){} // RVA: 0x7FFAF9689DD0
        public void SetMinVersion(){} // RVA: 0x7FFAF9689ED0
        public void SetMaxVersion(){} // RVA: 0x7FFAF9689F80
        public void SetCiphers(){} // RVA: 0x7FFAF968A030
        public void SetVerifyParam(){} // RVA: 0x7FFAF968A320
        public void SetClientCertificateIssuers(){} // RVA: 0x7FFAF968A430
        public void SetServerNameCallback(){} // RVA: 0x7FFAF968AAC0
        public void NativeServerNameCallback(){} // RVA: 0x7FFAF968ABC0
        public void Close(){} // RVA: 0x7FFAF968ACF0
    }

    public class MonoBtlsStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF968AEA0
        public void CreateContext(){} // RVA: 0x7FFAF968AF30
    }

    public class MonoBtlsUtils
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAF968B010
        public void AppendEntry(){} // RVA: 0x7FFAF968B090
        public void FormatName(){} // RVA: 0x7FFAF968B760
        public void .cctor(){} // RVA: 0x7FFAF968B8D0
    }

    public class MonoBtlsVerifyCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5E218A0
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
    }

    public class MonoBtlsX509
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF968B9B0
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void mono_btls_x509_up_ref(){} // RVA: 0x7FFAF968BA30
        public void mono_btls_x509_from_data(){} // RVA: 0x7FFAF968BAB0
        public void mono_btls_x509_get_subject_name(){} // RVA: 0x7FFAF968BB50
        public void mono_btls_x509_get_raw_data(){} // RVA: 0x7FFAF968BBD0
        public void mono_btls_x509_cmp(){} // RVA: 0x7FFAF968BC70
        public void mono_btls_x509_free(){} // RVA: 0x7FFAF968BD00
        public void mono_btls_x509_add_explicit_trust(){} // RVA: 0x7FFAF968BD80
        public void Copy(){} // RVA: 0x7FFAF968BE10
        public void LoadFromData(){} // RVA: 0x7FFAF968BFB0
        public void GetSubjectName(){} // RVA: 0x7FFAF968C2C0
        public void GetSubjectNameHash(){} // RVA: 0x7FFAF968C480
        public void GetRawData(){} // RVA: 0x7FFAF968C710
        public void Compare(){} // RVA: 0x7FFAF968CA00
        public void AddExplicitTrust(){} // RVA: 0x7FFAF968CAD0
    }

    public class MonoBtlsX509Chain
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF968CC60
        public void mono_btls_x509_chain_new(){} // RVA: 0x7FFAF968CCE0
        public void mono_btls_x509_chain_get_count(){} // RVA: 0x7FFAF968CD50
        public void mono_btls_x509_chain_get_cert(){} // RVA: 0x7FFAF968CDD0
        public void mono_btls_x509_chain_add_cert(){} // RVA: 0x7FFAF968CE60
        public void mono_btls_x509_chain_up_ref(){} // RVA: 0x7FFAF968CEF0
        public void mono_btls_x509_chain_free(){} // RVA: 0x7FFAF968CF70
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAF968D130
        public void GetCertificate(){} // RVA: 0x7FFAF968D1D0
        public void AddCertificate(){} // RVA: 0x7FFAF968D3C0
        public void Copy(){} // RVA: 0x7FFAF968D480
    }

    public class MonoBtlsX509Lookup
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF968D6A0
        public void mono_btls_x509_lookup_new(){} // RVA: 0x7FFAF968D720
        public void mono_btls_x509_lookup_add_dir(){} // RVA: 0x7FFAF968D7B0
        public void mono_btls_x509_lookup_add_mono(){} // RVA: 0x7FFAF968D850
        public void mono_btls_x509_lookup_free(){} // RVA: 0x7FFAF968D8E0
        public void mono_btls_x509_lookup_peek_lookup(){} // RVA: 0x7FFAF968D960
        public void Create_internal(){} // RVA: 0x7FFAF968D9E0
        public void .ctor(){} // RVA: 0x7FFAF968DB40
        public void GetNativeLookup(){} // RVA: 0x7FFAF968DD70
        public void AddDirectory(){} // RVA: 0x7FFAF968DE10
        public void AddMono(){} // RVA: 0x7FFAF968DFC0
        public void AddCertificate(){} // RVA: 0x7FFAF968E2C0
        public void Close(){} // RVA: 0x7FFAF968E3D0
    }

    public class MonoBtlsX509LookupMono
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF968E6B0
        public void mono_btls_x509_lookup_mono_new(){} // RVA: 0x7FFAF968E730
        public void mono_btls_x509_lookup_mono_init(){} // RVA: 0x7FFAF968E7A0
        public void mono_btls_x509_lookup_mono_free(){} // RVA: 0x7FFAF968E840
        public void .ctor(){} // RVA: 0x7FFAF968E8C0
        public void Install(){} // RVA: 0x7FFAF968EC40
        public void AddCertificate(){} // RVA: 0x7FFAF968ECE0
        public void OnGetBySubject(){} // RVA: 0x7FFAF968EE00 | overloaded x2
        public void Close(){} // RVA: 0x7FFAF968F130
    }

    public class MonoBtlsX509LookupMonoCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF968F2E0
        public void Initialize(){} // RVA: 0x7FFAF968F370
        public void OnGetBySubject(){} // RVA: 0x7FFAF968F7B0
        public void Close(){} // RVA: 0x7FFAF968F870
    }

    public class MonoBtlsX509Name
    {
        // ── Methods ──
        public void mono_btls_x509_name_hash(){} // RVA: 0x7FFAF968FA50
        public void mono_btls_x509_name_get_entry_count(){} // RVA: 0x7FFAF968FAD0
        public void mono_btls_x509_name_get_entry_type(){} // RVA: 0x7FFAF968FB50
        public void mono_btls_x509_name_get_entry_oid(){} // RVA: 0x7FFAF968FBE0
        public void mono_btls_x509_name_get_entry_oid_data(){} // RVA: 0x7FFAF968FC80
        public void mono_btls_x509_name_get_entry_value(){} // RVA: 0x7FFAF968FD20
        public void mono_btls_x509_name_from_data(){} // RVA: 0x7FFAF968FDC0
        public void mono_btls_x509_name_free(){} // RVA: 0x7FFAF968FE60
        public void get_Handle(){} // RVA: 0x7FFAF968FEE0
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetHash(){} // RVA: 0x7FFAF968FF60
        public void GetEntryCount(){} // RVA: 0x7FFAF9690000
        public void GetEntryType(){} // RVA: 0x7FFAF96900A0
        public void GetEntryOid(){} // RVA: 0x7FFAF9690190
        public void GetEntryOidData(){} // RVA: 0x7FFAF9690410
        public void GetEntryValue(){} // RVA: 0x7FFAF9690580
        public void CreateFromData(){} // RVA: 0x7FFAF9690790
    }

    public class MonoBtlsX509Store
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF9690A60
        public void mono_btls_x509_store_new(){} // RVA: 0x7FFAF9690AE0
        public void mono_btls_x509_store_from_ssl_ctx(){} // RVA: 0x7FFAF9690B50
        public void mono_btls_x509_store_add_cert(){} // RVA: 0x7FFAF9690BD0
        public void mono_btls_x509_store_free(){} // RVA: 0x7FFAF9690C60
        public void Create_internal(){} // RVA: 0x7FFAF9690E00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF96910B0 | overloaded x2
        public void AddCertificate(){} // RVA: 0x7FFAF9691240
        public void AddLookup(){} // RVA: 0x7FFAF9691350
        public void AddDirectoryLookup(){} // RVA: 0x7FFAF9691660
        public void AddCollection(){} // RVA: 0x7FFAF96916B0
        public void Close(){} // RVA: 0x7FFAF96917C0
    }

    public class MonoBtlsX509StoreCtx
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF9691B60
        public void mono_btls_x509_store_ctx_new(){} // RVA: 0x7FFAF9691BE0
        public void mono_btls_x509_store_ctx_from_ptr(){} // RVA: 0x7FFAF9691C50
        public void mono_btls_x509_store_ctx_get_error(){} // RVA: 0x7FFAF9691CD0
        public void mono_btls_x509_store_ctx_get_chain(){} // RVA: 0x7FFAF9691D60
        public void mono_btls_x509_store_ctx_init(){} // RVA: 0x7FFAF9691DE0
        public void mono_btls_x509_store_ctx_set_param(){} // RVA: 0x7FFAF9691E80
        public void mono_btls_x509_store_ctx_verify_cert(){} // RVA: 0x7FFAF9691F10
        public void mono_btls_x509_store_ctx_get_untrusted(){} // RVA: 0x7FFAF9691F90
        public void mono_btls_x509_store_ctx_up_ref(){} // RVA: 0x7FFAF9692010
        public void mono_btls_x509_store_ctx_free(){} // RVA: 0x7FFAF9692090
        public void .ctor(){} // RVA: 0x7FFAF9692550 | overloaded x3
        public void Create_internal(){} // RVA: 0x7FFAF9692250
        public void GetError(){} // RVA: 0x7FFAF96925B0
        public void GetChain(){} // RVA: 0x7FFAF9692660
        public void GetUntrusted(){} // RVA: 0x7FFAF9692800
        public void Initialize(){} // RVA: 0x7FFAF96929A0
        public void SetVerifyParam(){} // RVA: 0x7FFAF9692AE0
        public void get_VerifyResult(){} // RVA: 0x7FFAF9692BF0
        public void Verify(){} // RVA: 0x7FFAF9692C80
        public void Copy(){} // RVA: 0x7FFAF9692D80
    }

    public class MonoBtlsX509StoreManager
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF9692FD0
        public void DoInitialize(){} // RVA: 0x7FFAF96930D0
        public void GetStorePath(){} // RVA: 0x7FFAF96937D0
    }

    public class MonoBtlsX509VerifyParam
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAF9693910
        public void mono_btls_x509_verify_param_copy(){} // RVA: 0x7FFAF9693990
        public void mono_btls_x509_verify_param_lookup(){} // RVA: 0x7FFAF9693A10
        public void mono_btls_x509_verify_param_can_modify(){} // RVA: 0x7FFAF9693A90
        public void mono_btls_x509_verify_param_set_host(){} // RVA: 0x7FFAF9693B10
        public void mono_btls_x509_verify_param_set_time(){} // RVA: 0x7FFAF9693BB0
        public void mono_btls_x509_verify_param_free(){} // RVA: 0x7FFAF9693C40
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Copy(){} // RVA: 0x7FFAF9693CC0
        public void GetSslClient(){} // RVA: 0x7FFAF9693E60
        public void GetSslServer(){} // RVA: 0x7FFAF9693EA0
        public void Lookup(){} // RVA: 0x7FFAF9693EE0
        public void get_CanModify(){} // RVA: 0x7FFAF96941D0
        public void WantToModify(){} // RVA: 0x7FFAF9694270
        public void SetHost(){} // RVA: 0x7FFAF9694360
        public void SetTime(){} // RVA: 0x7FFAF9694520
    }

    public class X509CertificateImplBtls
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9694BF0 | overloaded x4
        public void get_IsValid(){} // RVA: 0x7FFAF9694D90
        public void get_X509(){} // RVA: 0x7FFAF9694DE0
        public void get_NativePrivateKey(){} // RVA: 0x7FFAF9694E30
        public void Clone(){} // RVA: 0x7FFAF9694E80
        public void GetRawCertData(){} // RVA: 0x7FFAF9694F20
        public void get_IntermediateCertificates(){} // RVA: 0x7FFAF2DF8120
        public void Dispose(){} // RVA: 0x7FFAF9694FD0
        public void get_HasPrivateKey(){} // RVA: 0x7FFAF9449EB0
        public void get_PrivateKey(){} // RVA: 0x7FFAF96950B0
        public void set_PrivateKey(){} // RVA: 0x7FFAF96950F0
        public void GetRSAPrivateKey(){} // RVA: 0x7FFAF96950B0
        public void GetDSAPrivateKey(){} // RVA: 0x7FFAF9695260
        public void Import(){} // RVA: 0x7FFAF96952A0
        public void ImportPkcs12(){} // RVA: 0x7FFAF9695360
        public void ImportAuthenticode(){} // RVA: 0x7FFAF9695AD0
        public void Verify(){} // RVA: 0x7FFAF9695B70
    }

    public class X509ChainImplBtls
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96960C0 | overloaded x2
        public void get_IsValid(){} // RVA: 0x7FFAF9696A00
        public void get_StoreCtx(){} // RVA: 0x7FFAF9696A40
        public void get_ChainElements(){} // RVA: 0x7FFAF9696A90
        public void get_ChainPolicy(){} // RVA: 0x7FFAF2E0A740
        public void AddStatus(){} // RVA: 0x7FFAF9696E80
        public void Build(){} // RVA: 0x7FFAF2D8D320
        public void Reset(){} // RVA: 0x7FFAF9697010
        public void Dispose(){} // RVA: 0x7FFAF9697170
    }

    public class X509PalImplBtls
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9697460
        public void get_Provider(){} // RVA: 0x7FFAF2DA8380
        public void Import(){} // RVA: 0x7FFAF96975E0 | overloaded x3
    }

}