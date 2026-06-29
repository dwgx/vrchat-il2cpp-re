// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Btls
// Classes: 31
// Methods: 357

namespace ThirdParty.DotNet.Mono.Btls
{
    public class IMonoBtlsBioMono
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x885B30
        public void Write(){} // RVA: 0x87FFF0
        public void Flush(){} // RVA: 0x894290
        public void Close(){} // RVA: 0x894290
    }

    public class MonoBtlsBio : MonoBtlsObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Handle(){} // RVA: 0x7101230
        public void mono_btls_bio_free(){} // RVA: 0x71012B0
    }

    public class MonoBtlsBioMemory : MonoBtlsBio
    {
        // ── Methods ──
        public void mono_btls_bio_mem_new(){} // RVA: 0x7101420
        public void mono_btls_bio_mem_get_data(){} // RVA: 0x7101490
        public void .ctor(){} // RVA: 0x7101520
        public void GetData(){} // RVA: 0x7101660
    }

    public class MonoBtlsBioMono : MonoBtlsBio
    {
        public object handle;
        public object instance;
        public object readFunc;
        public object writeFunc;
        public object controlFunc;
        public object readFuncPtr;
        public object writeFuncPtr;
        public object controlFuncPtr;
        public object backend;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x71018D0
        public void mono_btls_bio_mono_new(){} // RVA: 0x7101F90
        public void mono_btls_bio_mono_initialize(){} // RVA: 0x7102000
        public void Control(){} // RVA: 0x7102940
        public void OnRead(){} // RVA: 0x71022D0
        public void OnWrite(){} // RVA: 0x71026D0
        public void Close(){} // RVA: 0x7102AF0
    }

    public class MonoBtlsContext : MobileTlsContext
    {
        public object remoteCertificate;
        public object clientCertificate;
        public object nativeServerCertificate;
        public object nativeClientCertificate;
        public object ctx;
        public object ssl;
        public object bio;
        public object errbio;
        public object connectionInfo;
        public object certificateValidated;
        public object isAuthenticated;
        public object connected;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7102D00
        public void GetPrivateCertificate(){} // RVA: 0x7102D80
        public void VerifyCallback(){} // RVA: 0x7103010
        public void SelectCallback(){} // RVA: 0x7103230
        public void ServerNameCallback(){} // RVA: 0x71033A0
        public void StartHandshake(){} // RVA: 0x7103460
        public void SetPrivateCertificate(){} // RVA: 0x7103800
        public void GetException(){} // RVA: 0x7103E60
        public void ProcessHandshake(){} // RVA: 0x71044B0
        public void DoProcessHandshake(){} // RVA: 0x71045F0
        public void FinishHandshake(){} // RVA: 0x71047F0
        public void InitializeConnection(){} // RVA: 0x7104810
        public void GetPeerCertificate(){} // RVA: 0x71052D0
        public void InitializeSession(){} // RVA: 0x7105590
        public void GetProtocol(){} // RVA: 0x7105960
        public void Flush(){} // RVA: 0x71059E0
        public void Read(){} // RVA: 0x7105A20
        public void Write(){} // RVA: 0x7105DB0
        public void Renegotiate(){} // RVA: 0x71060F0
        public void Shutdown(){} // RVA: 0x7106130
        public void PendingRenegotiation(){} // RVA: 0x71062E0
        public void Dispose(){} // RVA: 0x7106390
        public void Mono.Btls.IMonoBtlsBioMono.Read(){} // RVA: 0x7106510
        public void Mono.Btls.IMonoBtlsBioMono.Write(){} // RVA: 0x7106540
        public void Mono.Btls.IMonoBtlsBioMono.Flush(){} // RVA: 0xB43310
        public void Mono.Btls.IMonoBtlsBioMono.Close(){} // RVA: 0xB43310
        public void get_IsAuthenticated(){} // RVA: 0x25D1680
        public void get_LocalClientCertificate(){} // RVA: 0xBE2C60
        public void get_RemoteCertificate(){} // RVA: 0xC0FFC0
    }

    public class MonoBtlsError : Object
    {
        // ── Methods ──
        public void mono_btls_error_clear_error(){} // RVA: 0x7106570
        public void mono_btls_error_get_error_line(){} // RVA: 0x71065E0
        public void mono_btls_error_get_error_string_n(){} // RVA: 0x7106670
        public void mono_btls_error_get_reason(){} // RVA: 0x7106710
        public void ClearError(){} // RVA: 0x7106570
        public void GetErrorString(){} // RVA: 0x7106790
        public void GetError(){} // RVA: 0x71069C0
        public void GetErrorReason(){} // RVA: 0x7106710
    }

    public class MonoBtlsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7106CC0
    }

    public class MonoBtlsKey : MonoBtlsObject
    {
        // ── Methods ──
        public void mono_btls_key_new(){} // RVA: 0x7106DE0
        public void mono_btls_key_free(){} // RVA: 0x7106E50
        public void mono_btls_key_up_ref(){} // RVA: 0x7106ED0
        public void mono_btls_key_get_bytes(){} // RVA: 0x7106F50
        public void mono_btls_key_assign_rsa_private_key(){} // RVA: 0x7107000
        public void get_Handle(){} // RVA: 0x71070B0
        public void .ctor(){} // RVA: 0xB44D60
        public void GetBytes(){} // RVA: 0x7107130
        public void Copy(){} // RVA: 0x71072D0
        public void CreateFromRSAPrivateKey(){} // RVA: 0x7107470
    }

    public class MonoBtlsObject : Object
    {
        public object handle;
        public object lastError;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Handle(){} // RVA: 0x7107750
        public void get_IsValid(){} // RVA: 0x7107770
        public void CheckThrow(){} // RVA: 0x71077B0
        public void SetException(){} // RVA: 0x7107850
        public void CheckError(){} // RVA: 0x7107A40
        public void CheckLastError(){} // RVA: 0x7107A50
        public void mono_btls_free(){} // RVA: 0x7107C50
        public void FreeDataPtr(){} // RVA: 0x7107CD0
        public void Close(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0x7107FA0
        public void Finalize(){} // RVA: 0x7108000
    }

    public class MonoBtlsPkcs12 : MonoBtlsObject
    {
        public object privateKey;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7108060
        public void mono_btls_pkcs12_free(){} // RVA: 0x71080E0
        public void mono_btls_pkcs12_new(){} // RVA: 0x7108160
        public void mono_btls_pkcs12_get_count(){} // RVA: 0x71081D0
        public void mono_btls_pkcs12_get_cert(){} // RVA: 0x7108250
        public void mono_btls_pkcs12_import(){} // RVA: 0x71082E0
        public void mono_btls_pkcs12_has_private_key(){} // RVA: 0x71083E0
        public void mono_btls_pkcs12_get_private_key(){} // RVA: 0x7108460
        public void .ctor(){} // RVA: 0x71084E0
        public void get_Count(){} // RVA: 0x7108620
        public void GetCertificate(){} // RVA: 0x71086C0
        public void Import(){} // RVA: 0x71088B0
        public void get_HasPrivateKey(){} // RVA: 0x7108A30
        public void GetPrivateKey(){} // RVA: 0x7108AD0
    }

    public class MonoBtlsProvider : MobileTlsProvider
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7108D60
        public void get_Name(){} // RVA: 0x7108DC0
        public void .ctor(){} // RVA: 0x7108E00
        public void get_SupportsSslStream(){} // RVA: 0xC2E4C0
        public void get_SupportsMonoExtensions(){} // RVA: 0xC2E4C0
        public void get_SupportsConnectionInfo(){} // RVA: 0xC2E4C0
        public void get_SupportsCleanShutdown(){} // RVA: 0xC2E4C0
        public void get_SupportedProtocols(){} // RVA: 0x70F1460
        public void CreateSslStream(){} // RVA: 0x7108E90
        public void GetNativeCertificate(){} // RVA: 0x7109230
        public void GetVerifyParam(){} // RVA: 0x71092B0
        public void ValidateCertificate(){} // RVA: 0x7109E90
        public void CheckValidationResult(){} // RVA: 0x710A090
        public void MapVerifyErrorToChainStatus(){} // RVA: 0x710A440
        public void SetupCertificateStore(){} // RVA: 0x710A690
        public void SetupDefaultCertificateStore(){} // RVA: 0x710AB40
        public void AddUserStore(){} // RVA: 0x710AC00
        public void AddMachineStore(){} // RVA: 0x710AC70
        public void AddTrustedRoots(){} // RVA: 0x710ACE0
        public void CreateCertificate(){} // RVA: 0x710AE10
        public void GetManagedChain(){} // RVA: 0x710AF80
        public void GetBtlsCertificate(){} // RVA: 0x710B010
        public void GetNativeChain(){} // RVA: 0x710B110
    }

    public class MonoBtlsSelectCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F6EBF0
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class MonoBtlsServerNameCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x35A73E0
        public void Invoke(){} // RVA: 0xBA10B0
    }

    public class MonoBtlsSsl : MonoBtlsObject
    {
        public object bio;
        public object printErrorsFunc;
        public object printErrorsFuncPtr;

        // ── Methods ──
        public void mono_btls_ssl_destroy(){} // RVA: 0x7636AE0
        public void mono_btls_ssl_new(){} // RVA: 0x7636B60
        public void mono_btls_ssl_use_certificate(){} // RVA: 0x7636BE0
        public void mono_btls_ssl_use_private_key(){} // RVA: 0x7636C70
        public void mono_btls_ssl_add_chain_certificate(){} // RVA: 0x7636D00
        public void mono_btls_ssl_accept(){} // RVA: 0x7636D90
        public void mono_btls_ssl_connect(){} // RVA: 0x7636E10
        public void mono_btls_ssl_handshake(){} // RVA: 0x7636E90
        public void mono_btls_ssl_close(){} // RVA: 0x7636F10
        public void mono_btls_ssl_shutdown(){} // RVA: 0x7636F90
        public void mono_btls_ssl_set_quiet_shutdown(){} // RVA: 0x7637010
        public void mono_btls_ssl_set_bio(){} // RVA: 0x76370A0
        public void mono_btls_ssl_read(){} // RVA: 0x7637130
        public void mono_btls_ssl_write(){} // RVA: 0x76371D0
        public void mono_btls_ssl_get_error(){} // RVA: 0x7637270
        public void mono_btls_ssl_get_version(){} // RVA: 0x7637300
        public void mono_btls_ssl_get_cipher(){} // RVA: 0x7637380
        public void mono_btls_ssl_get_peer_certificate(){} // RVA: 0x7637400
        public void mono_btls_ssl_print_errors_cb(){} // RVA: 0x7637480
        public void mono_btls_ssl_set_server_name(){} // RVA: 0x7637510
        public void mono_btls_ssl_get_server_name(){} // RVA: 0x76375A0
        public void mono_btls_ssl_set_renegotiate_mode(){} // RVA: 0x7637620
        public void mono_btls_ssl_renegotiate_pending(){} // RVA: 0x76376B0
        public void Create_internal(){} // RVA: 0x7637730
        public void .ctor(){} // RVA: 0x7637880
        public void get_Handle(){} // RVA: 0x7637BE0
        public void SetBio(){} // RVA: 0x7637C60
        public void ThrowError(){} // RVA: 0x7637D80
        public void GetError(){} // RVA: 0x7637F30
        public void SetCertificate(){} // RVA: 0x7637FB0
        public void SetPrivateKey(){} // RVA: 0x76380B0
        public void AddIntermediateCertificate(){} // RVA: 0x76381B0
        public void Accept(){} // RVA: 0x76382B0
        public void Connect(){} // RVA: 0x7638370
        public void Handshake(){} // RVA: 0x7638430
        public void PrintErrorsCallback(){} // RVA: 0x76384F0
        public void GetErrors(){} // RVA: 0x7638640
        public void PrintErrors(){} // RVA: 0x76387C0
        public void Read(){} // RVA: 0x7638850
        public void Write(){} // RVA: 0x7638950
        public void GetVersion(){} // RVA: 0x7638A60
        public void GetCipher(){} // RVA: 0x7638B00
        public void GetPeerCertificate(){} // RVA: 0x7638BF0
        public void SetServerName(){} // RVA: 0x7638D80
        public void GetServerName(){} // RVA: 0x7638F80
        public void Shutdown(){} // RVA: 0x7639090
        public void SetQuietShutdown(){} // RVA: 0x7639160
        public void Close(){} // RVA: 0x7639200
        public void SetRenegotiateMode(){} // RVA: 0x76392D0
        public void RenegotiatePending(){} // RVA: 0x7639380
    }

    public class MonoBtlsSslCtx : MonoBtlsObject
    {
        public object verifyFunc;
        public object selectFunc;
        public object serverNameFunc;
        public object verifyFuncPtr;
        public object selectFuncPtr;
        public object serverNameFuncPtr;
        public object verifyCallback;
        public object selectCallback;
        public object serverNameCallback;
        public object store;
        public object instance;
        public object instancePtr;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x76394B0
        public void mono_btls_ssl_ctx_new(){} // RVA: 0x7639530
        public void mono_btls_ssl_ctx_free(){} // RVA: 0x76395A0
        public void mono_btls_ssl_ctx_initialize(){} // RVA: 0x7639620
        public void mono_btls_ssl_ctx_set_cert_verify_callback(){} // RVA: 0x76396B0
        public void mono_btls_ssl_ctx_set_cert_select_callback(){} // RVA: 0x7639750
        public void mono_btls_ssl_ctx_set_min_version(){} // RVA: 0x76397E0
        public void mono_btls_ssl_ctx_set_max_version(){} // RVA: 0x7639870
        public void mono_btls_ssl_ctx_set_ciphers(){} // RVA: 0x7639900
        public void mono_btls_ssl_ctx_set_verify_param(){} // RVA: 0x76399A0
        public void mono_btls_ssl_ctx_set_client_ca_list(){} // RVA: 0x7639A30
        public void mono_btls_ssl_ctx_set_server_name_callback(){} // RVA: 0x7639AD0
        public void .ctor(){} // RVA: 0x7639C50
        public void get_CertificateStore(){} // RVA: 0xBBFF90
        public void VerifyCallback(){} // RVA: 0x763A3E0
        public void NativeVerifyCallback(){} // RVA: 0x763A410
        public void NativeSelectCallback(){} // RVA: 0x763A7D0
        public void CopyIssuers(){} // RVA: 0x763A940
        public void SetVerifyCallback(){} // RVA: 0x763ACE0
        public void SetSelectCallback(){} // RVA: 0x763AE00
        public void SetMinVersion(){} // RVA: 0x763AF00
        public void SetMaxVersion(){} // RVA: 0x763AFB0
        public void SetCiphers(){} // RVA: 0x763B060
        public void SetVerifyParam(){} // RVA: 0x763B350
        public void SetClientCertificateIssuers(){} // RVA: 0x763B460
        public void SetServerNameCallback(){} // RVA: 0x763BB00
        public void NativeServerNameCallback(){} // RVA: 0x763BC00
        public void Close(){} // RVA: 0x763BD40
    }

    public class MonoBtlsStream : MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x763BEF0
        public void CreateContext(){} // RVA: 0x763BF80
    }

    public class MonoBtlsUtils : Object
    {
        public object emailOid;

        // ── Methods ──
        public void Compare(){} // RVA: 0x763C060
        public void AppendEntry(){} // RVA: 0x763C0E0
        public void FormatName(){} // RVA: 0x763C7B0
        public void .cctor(){} // RVA: 0x763C920
    }

    public class MonoBtlsVerifyCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E33B10
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class MonoBtlsX509 : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x763CA00
        public void .ctor(){} // RVA: 0xB44D60
        public void mono_btls_x509_up_ref(){} // RVA: 0x763CA80
        public void mono_btls_x509_from_data(){} // RVA: 0x763CB00
        public void mono_btls_x509_get_subject_name(){} // RVA: 0x763CBA0
        public void mono_btls_x509_get_raw_data(){} // RVA: 0x763CC20
        public void mono_btls_x509_cmp(){} // RVA: 0x763CCC0
        public void mono_btls_x509_free(){} // RVA: 0x763CD50
        public void mono_btls_x509_add_explicit_trust(){} // RVA: 0x763CDD0
        public void Copy(){} // RVA: 0x763CE60
        public void LoadFromData(){} // RVA: 0x763D000
        public void GetSubjectName(){} // RVA: 0x763D320
        public void GetSubjectNameHash(){} // RVA: 0x763D4E0
        public void GetRawData(){} // RVA: 0x763D770
        public void Compare(){} // RVA: 0x763DA70
        public void AddExplicitTrust(){} // RVA: 0x763DB40
    }

    public class MonoBtlsX509Chain : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x763DCD0
        public void mono_btls_x509_chain_new(){} // RVA: 0x763DD50
        public void mono_btls_x509_chain_get_count(){} // RVA: 0x763DDC0
        public void mono_btls_x509_chain_get_cert(){} // RVA: 0x763DE40
        public void mono_btls_x509_chain_add_cert(){} // RVA: 0x763DED0
        public void mono_btls_x509_chain_up_ref(){} // RVA: 0x763DF60
        public void mono_btls_x509_chain_free(){} // RVA: 0x763DFE0
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Count(){} // RVA: 0x763E1A0
        public void GetCertificate(){} // RVA: 0x763E240
        public void AddCertificate(){} // RVA: 0x763E430
        public void Copy(){} // RVA: 0x763E4F0
    }

    public class MonoBtlsX509Lookup : MonoBtlsObject
    {
        public object store;
        public object type;
        public object monoLookups;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x763E710
        public void mono_btls_x509_lookup_new(){} // RVA: 0x763E790
        public void mono_btls_x509_lookup_add_dir(){} // RVA: 0x763E820
        public void mono_btls_x509_lookup_add_mono(){} // RVA: 0x763E8C0
        public void mono_btls_x509_lookup_free(){} // RVA: 0x763E950
        public void mono_btls_x509_lookup_peek_lookup(){} // RVA: 0x763E9D0
        public void Create_internal(){} // RVA: 0x763EA50
        public void .ctor(){} // RVA: 0x763EBB0
        public void GetNativeLookup(){} // RVA: 0x763EDE0
        public void AddDirectory(){} // RVA: 0x763EE80
        public void AddMono(){} // RVA: 0x763F030
        public void AddCertificate(){} // RVA: 0x763F330
        public void Close(){} // RVA: 0x763F440
    }

    public class MonoBtlsX509LookupMono : MonoBtlsObject
    {
        public object gch;
        public object instance;
        public object bySubjectFunc;
        public object bySubjectFuncPtr;
        public object lookup;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x763F720
        public void mono_btls_x509_lookup_mono_new(){} // RVA: 0x763F7A0
        public void mono_btls_x509_lookup_mono_init(){} // RVA: 0x763F810
        public void mono_btls_x509_lookup_mono_free(){} // RVA: 0x763F8B0
        public void .ctor(){} // RVA: 0x763F930
        public void Install(){} // RVA: 0x763FCB0
        public void AddCertificate(){} // RVA: 0x763FD50
        public void OnGetBySubject(){} // RVA: 0x763FE70
        public void Close(){} // RVA: 0x76401B0
    }

    public class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
    {
        public object hashes;
        public object certificates;
        public object collection;
        public object trust;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7640360
        public void Initialize(){} // RVA: 0x76403F0
        public void OnGetBySubject(){} // RVA: 0x7640840
        public void Close(){} // RVA: 0x7640910
    }

    public class MonoBtlsX509Name : MonoBtlsObject
    {
        // ── Methods ──
        public void mono_btls_x509_name_hash(){} // RVA: 0x7640AF0
        public void mono_btls_x509_name_get_entry_count(){} // RVA: 0x7640B70
        public void mono_btls_x509_name_get_entry_type(){} // RVA: 0x7640BF0
        public void mono_btls_x509_name_get_entry_oid(){} // RVA: 0x7640C80
        public void mono_btls_x509_name_get_entry_oid_data(){} // RVA: 0x7640D20
        public void mono_btls_x509_name_get_entry_value(){} // RVA: 0x7640DC0
        public void mono_btls_x509_name_from_data(){} // RVA: 0x7640E60
        public void mono_btls_x509_name_free(){} // RVA: 0x7640F00
        public void get_Handle(){} // RVA: 0x7640F80
        public void .ctor(){} // RVA: 0xB44D60
        public void GetHash(){} // RVA: 0x7641000
        public void GetEntryCount(){} // RVA: 0x76410A0
        public void GetEntryType(){} // RVA: 0x7641140
        public void GetEntryOid(){} // RVA: 0x7641230
        public void GetEntryOidData(){} // RVA: 0x76414C0
        public void GetEntryValue(){} // RVA: 0x7641630
        public void CreateFromData(){} // RVA: 0x7641850
    }

    public class MonoBtlsX509Store : MonoBtlsObject
    {
        public object lookupHash;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7641B20
        public void mono_btls_x509_store_new(){} // RVA: 0x7641BA0
        public void mono_btls_x509_store_from_ssl_ctx(){} // RVA: 0x7641C10
        public void mono_btls_x509_store_add_cert(){} // RVA: 0x7641C90
        public void mono_btls_x509_store_free(){} // RVA: 0x7641D20
        public void Create_internal(){} // RVA: 0x7641EC0
        public void .ctor(){} // RVA: 0x7642170
        public void AddCertificate(){} // RVA: 0x7642300
        public void AddLookup(){} // RVA: 0x7642410
        public void AddDirectoryLookup(){} // RVA: 0x7642720
        public void AddCollection(){} // RVA: 0x7642770
        public void Close(){} // RVA: 0x7642880
    }

    public class MonoBtlsX509StoreCtx : MonoBtlsObject
    {
        public object verifyResult;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7642C30
        public void mono_btls_x509_store_ctx_new(){} // RVA: 0x7642CB0
        public void mono_btls_x509_store_ctx_from_ptr(){} // RVA: 0x7642D20
        public void mono_btls_x509_store_ctx_get_error(){} // RVA: 0x7642DA0
        public void mono_btls_x509_store_ctx_get_chain(){} // RVA: 0x7642E30
        public void mono_btls_x509_store_ctx_init(){} // RVA: 0x7642EB0
        public void mono_btls_x509_store_ctx_set_param(){} // RVA: 0x7642F50
        public void mono_btls_x509_store_ctx_verify_cert(){} // RVA: 0x7642FE0
        public void mono_btls_x509_store_ctx_get_untrusted(){} // RVA: 0x7643060
        public void mono_btls_x509_store_ctx_up_ref(){} // RVA: 0x76430E0
        public void mono_btls_x509_store_ctx_free(){} // RVA: 0x7643160
        public void .ctor(){} // RVA: 0x7643620
        public void Create_internal(){} // RVA: 0x7643320
        public void GetError(){} // RVA: 0x7643680
        public void GetChain(){} // RVA: 0x7643730
        public void GetUntrusted(){} // RVA: 0x76438D0
        public void Initialize(){} // RVA: 0x7643A70
        public void SetVerifyParam(){} // RVA: 0x7643BB0
        public void get_VerifyResult(){} // RVA: 0x7643CC0
        public void Verify(){} // RVA: 0x7643D50
        public void Copy(){} // RVA: 0x7643E50
    }

    public class MonoBtlsX509StoreManager : Object
    {
        public object initialized;
        public object machineTrustedRootPath;
        public object machineIntermediateCAPath;
        public object machineUntrustedPath;
        public object userTrustedRootPath;
        public object userIntermediateCAPath;
        public object userUntrustedPath;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x76440A0
        public void DoInitialize(){} // RVA: 0x76441A0
        public void GetStorePath(){} // RVA: 0x76448A0
    }

    public class MonoBtlsX509VerifyParam : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x76449E0
        public void mono_btls_x509_verify_param_copy(){} // RVA: 0x7644A60
        public void mono_btls_x509_verify_param_lookup(){} // RVA: 0x7644AE0
        public void mono_btls_x509_verify_param_can_modify(){} // RVA: 0x7644B60
        public void mono_btls_x509_verify_param_set_host(){} // RVA: 0x7644BE0
        public void mono_btls_x509_verify_param_set_time(){} // RVA: 0x7644C80
        public void mono_btls_x509_verify_param_free(){} // RVA: 0x7644D10
        public void .ctor(){} // RVA: 0xB44D60
        public void Copy(){} // RVA: 0x7644D90
        public void GetSslClient(){} // RVA: 0x7644F30
        public void GetSslServer(){} // RVA: 0x7644F70
        public void Lookup(){} // RVA: 0x7644FB0
        public void get_CanModify(){} // RVA: 0x76452A0
        public void WantToModify(){} // RVA: 0x7645340
        public void SetHost(){} // RVA: 0x7645430
        public void SetTime(){} // RVA: 0x76455F0
    }

    public class X509CertificateImplBtls : X509Certificate2ImplUnix
    {
        public object x509;
        public object nativePrivateKey;
        public object intermediateCerts;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7645CC0
        public void get_IsValid(){} // RVA: 0x7645E60
        public void get_X509(){} // RVA: 0x7645EB0
        public void get_NativePrivateKey(){} // RVA: 0x7645F00
        public void Clone(){} // RVA: 0x7645F50
        public void GetRawCertData(){} // RVA: 0x7645FF0
        public void get_IntermediateCertificates(){} // RVA: 0xBAE420
        public void Dispose(){} // RVA: 0x76460A0
        public void get_HasPrivateKey(){} // RVA: 0x73FF900
        public void get_PrivateKey(){} // RVA: 0x7646180
        public void set_PrivateKey(){} // RVA: 0x76461C0
        public void GetRSAPrivateKey(){} // RVA: 0x7646180
        public void GetDSAPrivateKey(){} // RVA: 0x7646330
        public void Import(){} // RVA: 0x7646370
        public void ImportPkcs12(){} // RVA: 0x7646430
        public void ImportAuthenticode(){} // RVA: 0x7646BB0
        public void Verify(){} // RVA: 0x7646C50
    }

    public class X509ChainImplBtls : X509ChainImpl
    {
        public object storeCtx;
        public object chain;
        public object untrustedChain;
        public object elements;
        public object untrusted;
        public object certificates;
        public object policy;
        public object chainStatusList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76471A0
        public void get_IsValid(){} // RVA: 0x7647AE0
        public void get_StoreCtx(){} // RVA: 0x7647B20
        public void get_ChainElements(){} // RVA: 0x7647B70
        public void get_ChainPolicy(){} // RVA: 0xBC1B30
        public void AddStatus(){} // RVA: 0x7647F60
        public void Build(){} // RVA: 0xB43320
        public void Reset(){} // RVA: 0x76480F0
        public void Dispose(){} // RVA: 0x7648260
    }

    public class X509PalImplBtls : X509PalImpl
    {
        public object _provider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7648570
        public void get_Provider(){} // RVA: 0xB5DBF0
        public void Import(){} // RVA: 0x76486F0
    }

}