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
        public void Flush(){} // RVA: 0x24A50
        public void Close(){} // RVA: 0x24A50
    }

    public class MonoBtlsBio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Handle(){} // RVA: 0x6696D40
        public void mono_btls_bio_free(){} // RVA: 0x6696DC0
    }

    public class MonoBtlsBioMemory
    {
        // ── Methods ──
        public void mono_btls_bio_mem_new(){} // RVA: 0x6696F30
        public void mono_btls_bio_mem_get_data(){} // RVA: 0x6696FA0
        public void .ctor(){} // RVA: 0x6697030
        public void GetData(){} // RVA: 0x6697170
    }

    public class MonoBtlsBioMono
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66973F0
        public void mono_btls_bio_mono_new(){} // RVA: 0x6697AB0
        public void mono_btls_bio_mono_initialize(){} // RVA: 0x6697B20
        public void Control(){} // RVA: 0x6698440 | overloaded x2
        public void OnRead(){} // RVA: 0x6697DF0 | overloaded x2
        public void OnWrite(){} // RVA: 0x66981E0 | overloaded x2
        public void Close(){} // RVA: 0x66985E0
    }

    public class MonoBtlsContext
    {
        public System.Security.Cryptography.X509Certificates.X509Certificate2 remoteCertificate; // 0x58
        public System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate; // 0x60
        public Mono.Btls.X509CertificateImplBtls nativeServerCertificate; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66987F0
        public void GetPrivateCertificate(){} // RVA: 0x6698870
        public void VerifyCallback(){} // RVA: 0x6698B10
        public void SelectCallback(){} // RVA: 0x6698D30
        public void ServerNameCallback(){} // RVA: 0x6698EA0
        public void StartHandshake(){} // RVA: 0x6698F60
        public void SetPrivateCertificate(){} // RVA: 0x6699300
        public void GetException(){} // RVA: 0x6699960
        public void ProcessHandshake(){} // RVA: 0x6699FC0
        public void DoProcessHandshake(){} // RVA: 0x669A100
        public void FinishHandshake(){} // RVA: 0x669A300
        public void InitializeConnection(){} // RVA: 0x669A320
        public void GetPeerCertificate(){} // RVA: 0x669ADF0
        public void InitializeSession(){} // RVA: 0x669B0A0
        public void GetProtocol(){} // RVA: 0x669B470
        public void Flush(){} // RVA: 0x669B4F0
        public void Read(){} // RVA: 0x669B530
        public void Write(){} // RVA: 0x669B8B0
        public void Renegotiate(){} // RVA: 0x669BBE0
        public void Shutdown(){} // RVA: 0x669BC20
        public void PendingRenegotiation(){} // RVA: 0x669BDD0
        public void Dispose(){} // RVA: 0x669BE80 | overloaded x2
        public void Mono.Btls.IMonoBtlsBioMono.Read(){} // RVA: 0x669C000
        public void Mono.Btls.IMonoBtlsBioMono.Write(){} // RVA: 0x669C030
        public void Mono.Btls.IMonoBtlsBioMono.Flush(){} // RVA: 0x2DD310
        public void Mono.Btls.IMonoBtlsBioMono.Close(){} // RVA: 0x2DD310
        public void get_IsAuthenticated(){} // RVA: 0x1D23080
        public void get_LocalClientCertificate(){} // RVA: 0x37B370
        public void get_RemoteCertificate(){} // RVA: 0x3A5500
    }

    public class MonoBtlsError
    {
        // ── Methods ──
        public void mono_btls_error_clear_error(){} // RVA: 0x669C060
        public void mono_btls_error_get_error_line(){} // RVA: 0x669C0D0
        public void mono_btls_error_get_error_string_n(){} // RVA: 0x669C160
        public void mono_btls_error_get_reason(){} // RVA: 0x669C200
        public void ClearError(){} // RVA: 0x669C060
        public void GetErrorString(){} // RVA: 0x669C280
        public void GetError(){} // RVA: 0x669C4B0
        public void GetErrorReason(){} // RVA: 0x669C200
    }

    public class MonoBtlsException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x669C7C0 | overloaded x4
    }

    public class MonoBtlsKey
    {
        // ── Methods ──
        public void mono_btls_key_new(){} // RVA: 0x669C8E0
        public void mono_btls_key_free(){} // RVA: 0x669C950
        public void mono_btls_key_up_ref(){} // RVA: 0x669C9D0
        public void mono_btls_key_get_bytes(){} // RVA: 0x669CA50
        public void mono_btls_key_assign_rsa_private_key(){} // RVA: 0x669CB00
        public void get_Handle(){} // RVA: 0x669CBB0
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetBytes(){} // RVA: 0x669CC30
        public void Copy(){} // RVA: 0x669CDD0
        public void CreateFromRSAPrivateKey(){} // RVA: 0x669CF70
    }

    public class MonoBtlsObject
    {
        public MonoBtlsHandle handle; // 0x10
        public System.Exception lastError; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Handle(){} // RVA: 0x669D240
        public void get_IsValid(){} // RVA: 0x669D260
        public void CheckThrow(){} // RVA: 0x669D2A0
        public void SetException(){} // RVA: 0x669D340
        public void CheckError(){} // RVA: 0x669D530 | overloaded x2
        public void CheckLastError(){} // RVA: 0x669D540
        public void mono_btls_free(){} // RVA: 0x669D740
        public void FreeDataPtr(){} // RVA: 0x669D7C0
        public void Close(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x669DAA0 | overloaded x2
        public void Finalize(){} // RVA: 0x669DB00
    }

    public class MonoBtlsPkcs12
    {
        public Mono.Btls.MonoBtlsKey privateKey; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x669DB60
        public void mono_btls_pkcs12_free(){} // RVA: 0x669DBE0
        public void mono_btls_pkcs12_new(){} // RVA: 0x669DC60
        public void mono_btls_pkcs12_get_count(){} // RVA: 0x669DCD0
        public void mono_btls_pkcs12_get_cert(){} // RVA: 0x669DD50
        public void mono_btls_pkcs12_import(){} // RVA: 0x669DDE0
        public void mono_btls_pkcs12_has_private_key(){} // RVA: 0x669DEE0
        public void mono_btls_pkcs12_get_private_key(){} // RVA: 0x669DF60
        public void .ctor(){} // RVA: 0x669DFE0
        public void get_Count(){} // RVA: 0x669E120
        public void GetCertificate(){} // RVA: 0x669E1C0
        public void Import(){} // RVA: 0x669E3B0
        public void get_HasPrivateKey(){} // RVA: 0x669E530
        public void GetPrivateKey(){} // RVA: 0x669E5D0
    }

    public class MonoBtlsProvider
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x669E860
        public void get_Name(){} // RVA: 0x669E8C0
        public void .ctor(){} // RVA: 0x669E900
        public void get_SupportsSslStream(){} // RVA: 0x3C2850
        public void get_SupportsMonoExtensions(){} // RVA: 0x3C2850
        public void get_SupportsConnectionInfo(){} // RVA: 0x3C2850
        public void get_SupportsCleanShutdown(){} // RVA: 0x3C2850
        public void get_SupportedProtocols(){} // RVA: 0x6686B80
        public void CreateSslStream(){} // RVA: 0x669E990
        public void GetNativeCertificate(){} // RVA: 0x669ED30 | overloaded x3
        public void GetVerifyParam(){} // RVA: 0x669EDB0
        public void ValidateCertificate(){} // RVA: 0x669F9A0 | overloaded x2
        public void CheckValidationResult(){} // RVA: 0x669FBA0
        public void MapVerifyErrorToChainStatus(){} // RVA: 0x669FF50
        public void SetupCertificateStore(){} // RVA: 0x66A01A0
        public void SetupDefaultCertificateStore(){} // RVA: 0x66A0690
        public void AddUserStore(){} // RVA: 0x66A07B0
        public void AddMachineStore(){} // RVA: 0x66A0850
        public void AddTrustedRoots(){} // RVA: 0x66A08F0
        public void CreateCertificate(){} // RVA: 0x66A0A20
        public void GetManagedChain(){} // RVA: 0x66A0B90
        public void GetBtlsCertificate(){} // RVA: 0x66A0C20
        public void GetNativeChain(){} // RVA: 0x66A0D30
    }

    public class MonoBtlsSelectCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61DB4E0
        public void Invoke(){} // RVA: 0x338C60
    }

    public class MonoBtlsServerNameCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2BB9710
        public void Invoke(){} // RVA: 0x33BA50
    }

    public class MonoBtlsSsl
    {
        public Mono.Btls.MonoBtlsBio bio; // 0x20

        // ── Methods ──
        public void mono_btls_ssl_destroy(){} // RVA: 0x6BD5AE0
        public void mono_btls_ssl_new(){} // RVA: 0x6BD5B60
        public void mono_btls_ssl_use_certificate(){} // RVA: 0x6BD5BE0
        public void mono_btls_ssl_use_private_key(){} // RVA: 0x6BD5C70
        public void mono_btls_ssl_add_chain_certificate(){} // RVA: 0x6BD5D00
        public void mono_btls_ssl_accept(){} // RVA: 0x6BD5D90
        public void mono_btls_ssl_connect(){} // RVA: 0x6BD5E10
        public void mono_btls_ssl_handshake(){} // RVA: 0x6BD5E90
        public void mono_btls_ssl_close(){} // RVA: 0x6BD5F10
        public void mono_btls_ssl_shutdown(){} // RVA: 0x6BD5F90
        public void mono_btls_ssl_set_quiet_shutdown(){} // RVA: 0x6BD6010
        public void mono_btls_ssl_set_bio(){} // RVA: 0x6BD60A0
        public void mono_btls_ssl_read(){} // RVA: 0x6BD6130
        public void mono_btls_ssl_write(){} // RVA: 0x6BD61D0
        public void mono_btls_ssl_get_error(){} // RVA: 0x6BD6270
        public void mono_btls_ssl_get_version(){} // RVA: 0x6BD6300
        public void mono_btls_ssl_get_cipher(){} // RVA: 0x6BD6380
        public void mono_btls_ssl_get_peer_certificate(){} // RVA: 0x6BD6400
        public void mono_btls_ssl_print_errors_cb(){} // RVA: 0x6BD6480
        public void mono_btls_ssl_set_server_name(){} // RVA: 0x6BD6510
        public void mono_btls_ssl_get_server_name(){} // RVA: 0x6BD65A0
        public void mono_btls_ssl_set_renegotiate_mode(){} // RVA: 0x6BD6620
        public void mono_btls_ssl_renegotiate_pending(){} // RVA: 0x6BD66B0
        public void Create_internal(){} // RVA: 0x6BD6730
        public void .ctor(){} // RVA: 0x6BD6880
        public void get_Handle(){} // RVA: 0x6BD6BE0
        public void SetBio(){} // RVA: 0x6BD6C60
        public void ThrowError(){} // RVA: 0x6BD6D80
        public void GetError(){} // RVA: 0x6BD6F30
        public void SetCertificate(){} // RVA: 0x6BD6FB0
        public void SetPrivateKey(){} // RVA: 0x6BD70B0
        public void AddIntermediateCertificate(){} // RVA: 0x6BD71B0
        public void Accept(){} // RVA: 0x6BD72B0
        public void Connect(){} // RVA: 0x6BD7370
        public void Handshake(){} // RVA: 0x6BD7430
        public void PrintErrorsCallback(){} // RVA: 0x6BD74F0
        public void GetErrors(){} // RVA: 0x6BD7630
        public void PrintErrors(){} // RVA: 0x6BD77B0
        public void Read(){} // RVA: 0x6BD7840
        public void Write(){} // RVA: 0x6BD7940
        public void GetVersion(){} // RVA: 0x6BD7A50
        public void GetCipher(){} // RVA: 0x6BD7AF0
        public void GetPeerCertificate(){} // RVA: 0x6BD7BE0
        public void SetServerName(){} // RVA: 0x6BD7D70
        public void GetServerName(){} // RVA: 0x6BD7F60
        public void Shutdown(){} // RVA: 0x6BD8070
        public void SetQuietShutdown(){} // RVA: 0x6BD8140
        public void Close(){} // RVA: 0x6BD81E0
        public void SetRenegotiateMode(){} // RVA: 0x6BD82B0
        public void RenegotiatePending(){} // RVA: 0x6BD8360
    }

    public class MonoBtlsSslCtx
    {
        public NativeVerifyFunc verifyFunc; // 0x20
        public NativeSelectFunc selectFunc; // 0x28

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BD8490
        public void mono_btls_ssl_ctx_new(){} // RVA: 0x6BD8510
        public void mono_btls_ssl_ctx_free(){} // RVA: 0x6BD8580
        public void mono_btls_ssl_ctx_initialize(){} // RVA: 0x6BD8600
        public void mono_btls_ssl_ctx_set_cert_verify_callback(){} // RVA: 0x6BD8690
        public void mono_btls_ssl_ctx_set_cert_select_callback(){} // RVA: 0x6BD8730
        public void mono_btls_ssl_ctx_set_min_version(){} // RVA: 0x6BD87C0
        public void mono_btls_ssl_ctx_set_max_version(){} // RVA: 0x6BD8850
        public void mono_btls_ssl_ctx_set_ciphers(){} // RVA: 0x6BD88E0
        public void mono_btls_ssl_ctx_set_verify_param(){} // RVA: 0x6BD8980
        public void mono_btls_ssl_ctx_set_client_ca_list(){} // RVA: 0x6BD8A10
        public void mono_btls_ssl_ctx_set_server_name_callback(){} // RVA: 0x6BD8AB0
        public void .ctor(){} // RVA: 0x6BD8C30 | overloaded x2
        public void get_CertificateStore(){} // RVA: 0x358D50
        public void VerifyCallback(){} // RVA: 0x6BD93C0
        public void NativeVerifyCallback(){} // RVA: 0x6BD93F0
        public void NativeSelectCallback(){} // RVA: 0x6BD97A0
        public void CopyIssuers(){} // RVA: 0x6BD9910
        public void SetVerifyCallback(){} // RVA: 0x6BD9CB0
        public void SetSelectCallback(){} // RVA: 0x6BD9DD0
        public void SetMinVersion(){} // RVA: 0x6BD9ED0
        public void SetMaxVersion(){} // RVA: 0x6BD9F80
        public void SetCiphers(){} // RVA: 0x6BDA030
        public void SetVerifyParam(){} // RVA: 0x6BDA320
        public void SetClientCertificateIssuers(){} // RVA: 0x6BDA430
        public void SetServerNameCallback(){} // RVA: 0x6BDAAC0
        public void NativeServerNameCallback(){} // RVA: 0x6BDABC0
        public void Close(){} // RVA: 0x6BDACF0
    }

    public class MonoBtlsStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BDAEA0
        public void CreateContext(){} // RVA: 0x6BDAF30
    }

    public class MonoBtlsUtils
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x6BDB010
        public void AppendEntry(){} // RVA: 0x6BDB090
        public void FormatName(){} // RVA: 0x6BDB760
        public void .cctor(){} // RVA: 0x6BDB8D0
    }

    public class MonoBtlsVerifyCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x33718A0
        public void Invoke(){} // RVA: 0x338C60
    }

    public class MonoBtlsX509
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BDB9B0
        public void .ctor(){} // RVA: 0x2DEE30
        public void mono_btls_x509_up_ref(){} // RVA: 0x6BDBA30
        public void mono_btls_x509_from_data(){} // RVA: 0x6BDBAB0
        public void mono_btls_x509_get_subject_name(){} // RVA: 0x6BDBB50
        public void mono_btls_x509_get_raw_data(){} // RVA: 0x6BDBBD0
        public void mono_btls_x509_cmp(){} // RVA: 0x6BDBC70
        public void mono_btls_x509_free(){} // RVA: 0x6BDBD00
        public void mono_btls_x509_add_explicit_trust(){} // RVA: 0x6BDBD80
        public void Copy(){} // RVA: 0x6BDBE10
        public void LoadFromData(){} // RVA: 0x6BDBFB0
        public void GetSubjectName(){} // RVA: 0x6BDC2C0
        public void GetSubjectNameHash(){} // RVA: 0x6BDC480
        public void GetRawData(){} // RVA: 0x6BDC710
        public void Compare(){} // RVA: 0x6BDCA00
        public void AddExplicitTrust(){} // RVA: 0x6BDCAD0
    }

    public class MonoBtlsX509Chain
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BDCC60
        public void mono_btls_x509_chain_new(){} // RVA: 0x6BDCCE0
        public void mono_btls_x509_chain_get_count(){} // RVA: 0x6BDCD50
        public void mono_btls_x509_chain_get_cert(){} // RVA: 0x6BDCDD0
        public void mono_btls_x509_chain_add_cert(){} // RVA: 0x6BDCE60
        public void mono_btls_x509_chain_up_ref(){} // RVA: 0x6BDCEF0
        public void mono_btls_x509_chain_free(){} // RVA: 0x6BDCF70
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_Count(){} // RVA: 0x6BDD130
        public void GetCertificate(){} // RVA: 0x6BDD1D0
        public void AddCertificate(){} // RVA: 0x6BDD3C0
        public void Copy(){} // RVA: 0x6BDD480
    }

    public class MonoBtlsX509Lookup
    {
        public Mono.Btls.MonoBtlsX509Store store; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BDD6A0
        public void mono_btls_x509_lookup_new(){} // RVA: 0x6BDD720
        public void mono_btls_x509_lookup_add_dir(){} // RVA: 0x6BDD7B0
        public void mono_btls_x509_lookup_add_mono(){} // RVA: 0x6BDD850
        public void mono_btls_x509_lookup_free(){} // RVA: 0x6BDD8E0
        public void mono_btls_x509_lookup_peek_lookup(){} // RVA: 0x6BDD960
        public void Create_internal(){} // RVA: 0x6BDD9E0
        public void .ctor(){} // RVA: 0x6BDDB40
        public void GetNativeLookup(){} // RVA: 0x6BDDD70
        public void AddDirectory(){} // RVA: 0x6BDDE10
        public void AddMono(){} // RVA: 0x6BDDFC0
        public void AddCertificate(){} // RVA: 0x6BDE2C0
        public void Close(){} // RVA: 0x6BDE3D0
    }

    public class MonoBtlsX509LookupMono
    {
        public System.Runtime.InteropServices.GCHandle gch; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BDE6B0
        public void mono_btls_x509_lookup_mono_new(){} // RVA: 0x6BDE730
        public void mono_btls_x509_lookup_mono_init(){} // RVA: 0x6BDE7A0
        public void mono_btls_x509_lookup_mono_free(){} // RVA: 0x6BDE840
        public void .ctor(){} // RVA: 0x6BDE8C0
        public void Install(){} // RVA: 0x6BDEC40
        public void AddCertificate(){} // RVA: 0x6BDECE0
        public void OnGetBySubject(){} // RVA: 0x6BDEE00 | overloaded x2
        public void Close(){} // RVA: 0x6BDF130
    }

    public class MonoBtlsX509LookupMonoCollection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BDF2E0
        public void Initialize(){} // RVA: 0x6BDF370
        public void OnGetBySubject(){} // RVA: 0x6BDF7B0
        public void Close(){} // RVA: 0x6BDF870
    }

    public class MonoBtlsX509Name
    {
        // ── Methods ──
        public void mono_btls_x509_name_hash(){} // RVA: 0x6BDFA50
        public void mono_btls_x509_name_get_entry_count(){} // RVA: 0x6BDFAD0
        public void mono_btls_x509_name_get_entry_type(){} // RVA: 0x6BDFB50
        public void mono_btls_x509_name_get_entry_oid(){} // RVA: 0x6BDFBE0
        public void mono_btls_x509_name_get_entry_oid_data(){} // RVA: 0x6BDFC80
        public void mono_btls_x509_name_get_entry_value(){} // RVA: 0x6BDFD20
        public void mono_btls_x509_name_from_data(){} // RVA: 0x6BDFDC0
        public void mono_btls_x509_name_free(){} // RVA: 0x6BDFE60
        public void get_Handle(){} // RVA: 0x6BDFEE0
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetHash(){} // RVA: 0x6BDFF60
        public void GetEntryCount(){} // RVA: 0x6BE0000
        public void GetEntryType(){} // RVA: 0x6BE00A0
        public void GetEntryOid(){} // RVA: 0x6BE0190
        public void GetEntryOidData(){} // RVA: 0x6BE0410
        public void GetEntryValue(){} // RVA: 0x6BE0580
        public void CreateFromData(){} // RVA: 0x6BE0790
    }

    public class MonoBtlsX509Store
    {
        public System.Collections.Generic.Dictionary`2<UIntPtr,Mono.Btls.MonoBtlsX509Lookup> lookupHash; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BE0A60
        public void mono_btls_x509_store_new(){} // RVA: 0x6BE0AE0
        public void mono_btls_x509_store_from_ssl_ctx(){} // RVA: 0x6BE0B50
        public void mono_btls_x509_store_add_cert(){} // RVA: 0x6BE0BD0
        public void mono_btls_x509_store_free(){} // RVA: 0x6BE0C60
        public void Create_internal(){} // RVA: 0x6BE0E00 | overloaded x2
        public void .ctor(){} // RVA: 0x6BE10B0 | overloaded x2
        public void AddCertificate(){} // RVA: 0x6BE1240
        public void AddLookup(){} // RVA: 0x6BE1350
        public void AddDirectoryLookup(){} // RVA: 0x6BE1660
        public void AddCollection(){} // RVA: 0x6BE16B0
        public void Close(){} // RVA: 0x6BE17C0
    }

    public class MonoBtlsX509StoreCtx
    {
        public System.Nullable`1<int> verifyResult; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BE1B60
        public void mono_btls_x509_store_ctx_new(){} // RVA: 0x6BE1BE0
        public void mono_btls_x509_store_ctx_from_ptr(){} // RVA: 0x6BE1C50
        public void mono_btls_x509_store_ctx_get_error(){} // RVA: 0x6BE1CD0
        public void mono_btls_x509_store_ctx_get_chain(){} // RVA: 0x6BE1D60
        public void mono_btls_x509_store_ctx_init(){} // RVA: 0x6BE1DE0
        public void mono_btls_x509_store_ctx_set_param(){} // RVA: 0x6BE1E80
        public void mono_btls_x509_store_ctx_verify_cert(){} // RVA: 0x6BE1F10
        public void mono_btls_x509_store_ctx_get_untrusted(){} // RVA: 0x6BE1F90
        public void mono_btls_x509_store_ctx_up_ref(){} // RVA: 0x6BE2010
        public void mono_btls_x509_store_ctx_free(){} // RVA: 0x6BE2090
        public void .ctor(){} // RVA: 0x6BE2550 | overloaded x3
        public void Create_internal(){} // RVA: 0x6BE2250
        public void GetError(){} // RVA: 0x6BE25B0
        public void GetChain(){} // RVA: 0x6BE2660
        public void GetUntrusted(){} // RVA: 0x6BE2800
        public void Initialize(){} // RVA: 0x6BE29A0
        public void SetVerifyParam(){} // RVA: 0x6BE2AE0
        public void get_VerifyResult(){} // RVA: 0x6BE2BF0
        public void Verify(){} // RVA: 0x6BE2C80
        public void Copy(){} // RVA: 0x6BE2D80
    }

    public class MonoBtlsX509StoreManager
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6BE2FD0
        public void DoInitialize(){} // RVA: 0x6BE30D0
        public void GetStorePath(){} // RVA: 0x6BE37D0
    }

    public class MonoBtlsX509VerifyParam
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x6BE3910
        public void mono_btls_x509_verify_param_copy(){} // RVA: 0x6BE3990
        public void mono_btls_x509_verify_param_lookup(){} // RVA: 0x6BE3A10
        public void mono_btls_x509_verify_param_can_modify(){} // RVA: 0x6BE3A90
        public void mono_btls_x509_verify_param_set_host(){} // RVA: 0x6BE3B10
        public void mono_btls_x509_verify_param_set_time(){} // RVA: 0x6BE3BB0
        public void mono_btls_x509_verify_param_free(){} // RVA: 0x6BE3C40
        public void .ctor(){} // RVA: 0x2DEE30
        public void Copy(){} // RVA: 0x6BE3CC0
        public void GetSslClient(){} // RVA: 0x6BE3E60
        public void GetSslServer(){} // RVA: 0x6BE3EA0
        public void Lookup(){} // RVA: 0x6BE3EE0
        public void get_CanModify(){} // RVA: 0x6BE41D0
        public void WantToModify(){} // RVA: 0x6BE4270
        public void SetHost(){} // RVA: 0x6BE4360
        public void SetTime(){} // RVA: 0x6BE4520
    }

    public class X509CertificateImplBtls
    {
        public Mono.Btls.MonoBtlsX509 x509; // 0xB0
        public Mono.Btls.MonoBtlsKey nativePrivateKey; // 0xB8
        public System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BE4BF0 | overloaded x4
        public void get_IsValid(){} // RVA: 0x6BE4D90
        public void get_X509(){} // RVA: 0x6BE4DE0
        public void get_NativePrivateKey(){} // RVA: 0x6BE4E30
        public void Clone(){} // RVA: 0x6BE4E80
        public void GetRawCertData(){} // RVA: 0x6BE4F20
        public void get_IntermediateCertificates(){} // RVA: 0x348120
        public void Dispose(){} // RVA: 0x6BE4FD0
        public void get_HasPrivateKey(){} // RVA: 0x6999EB0
        public void get_PrivateKey(){} // RVA: 0x6BE50B0
        public void set_PrivateKey(){} // RVA: 0x6BE50F0
        public void GetRSAPrivateKey(){} // RVA: 0x6BE50B0
        public void GetDSAPrivateKey(){} // RVA: 0x6BE5260
        public void Import(){} // RVA: 0x6BE52A0
        public void ImportPkcs12(){} // RVA: 0x6BE5360
        public void ImportAuthenticode(){} // RVA: 0x6BE5AD0
        public void Verify(){} // RVA: 0x6BE5B70
    }

    public class X509ChainImplBtls
    {
        public Mono.Btls.MonoBtlsX509StoreCtx storeCtx; // 0x10
        public Mono.Btls.MonoBtlsX509Chain chain; // 0x18
        public Mono.Btls.MonoBtlsX509Chain untrustedChain; // 0x20
        public System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BE60C0 | overloaded x2
        public void get_IsValid(){} // RVA: 0x6BE6A00
        public void get_StoreCtx(){} // RVA: 0x6BE6A40
        public void get_ChainElements(){} // RVA: 0x6BE6A90
        public void get_ChainPolicy(){} // RVA: 0x35A740
        public void AddStatus(){} // RVA: 0x6BE6E80
        public void Build(){} // RVA: 0x2DD320
        public void Reset(){} // RVA: 0x6BE7010
        public void Dispose(){} // RVA: 0x6BE7170
    }

    public class X509PalImplBtls
    {
        public Mono.Btls.MonoBtlsProvider <Provider>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BE7460
        public void get_Provider(){} // RVA: 0x2F8380
        public void Import(){} // RVA: 0x6BE75E0 | overloaded x3
    }

}