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
        public void Flush(){} // RVA: 0x7FFAC2C70980
        public void Close(){} // RVA: 0x7FFAC2C70980
    }

    public class MonoBtlsBio : MonoBtlsObject
    {
        public object Handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Handle(){} // RVA: 0x7FFAC8E2D800
        public void mono_btls_bio_free(){} // RVA: 0x7FFAC8E2D880
    }

    public class MonoBtlsBioMemory : MonoBtlsBio
    {
        // ── Methods ──
        public void mono_btls_bio_mem_new(){} // RVA: 0x7FFAC8E2D9F0
        public void mono_btls_bio_mem_get_data(){} // RVA: 0x7FFAC8E2DA60
        public void .ctor(){} // RVA: 0x7FFAC8E2DAF0
        public void GetData(){} // RVA: 0x7FFAC8E2DC30
    }

    public class MonoBtlsBioMono : MonoBtlsBio
    {
        public System.Runtime.InteropServices.GCHandle handle; // 0x20
        public UIntPtr instance; // 0x28
        public BioReadFunc readFunc; // 0x30
        public BioWriteFunc writeFunc; // 0x38
        public BioControlFunc controlFunc; // 0x40
        public UIntPtr readFuncPtr; // 0x48
        public UIntPtr writeFuncPtr; // 0x50
        public UIntPtr controlFuncPtr; // 0x58
        public Mono.Btls.IMonoBtlsBioMono backend; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E2DEB0
        public void mono_btls_bio_mono_new(){} // RVA: 0x7FFAC8E2E570
        public void mono_btls_bio_mono_initialize(){} // RVA: 0x7FFAC8E2E5E0
        public void Control(){} // RVA: 0x7FFAC8E2EF00 | overloaded x2
        public void OnRead(){} // RVA: 0x7FFAC8E2E8B0 | overloaded x2
        public void OnWrite(){} // RVA: 0x7FFAC8E2ECA0 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC8E2F0A0
    }

    public class MonoBtlsContext : MobileTlsContext
    {
        public System.Security.Cryptography.X509Certificates.X509Certificate2 IsAuthenticated; // 0x58
        public System.Security.Cryptography.X509Certificates.X509Certificate LocalClientCertificate; // 0x60
        public Mono.Btls.X509CertificateImplBtls RemoteCertificate; // 0x68
        public Mono.Btls.X509CertificateImplBtls nativeClientCertificate; // 0x70
        public Mono.Btls.MonoBtlsSslCtx ctx; // 0x78
        public Mono.Btls.MonoBtlsSsl ssl; // 0x80
        public Mono.Btls.MonoBtlsBio bio; // 0x88
        public Mono.Btls.MonoBtlsBio errbio; // 0x90
        public Mono.Security.Interface.MonoTlsConnectionInfo connectionInfo; // 0x98
        public bool certificateValidated; // 0xA0
        public bool isAuthenticated; // 0xA1
        public bool connected; // 0xA2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E2F2B0
        public void GetPrivateCertificate(){} // RVA: 0x7FFAC8E2F330
        public void VerifyCallback(){} // RVA: 0x7FFAC8E2F5D0
        public void SelectCallback(){} // RVA: 0x7FFAC8E2F7F0
        public void ServerNameCallback(){} // RVA: 0x7FFAC8E2F960
        public void StartHandshake(){} // RVA: 0x7FFAC8E2FA20
        public void SetPrivateCertificate(){} // RVA: 0x7FFAC8E2FDC0
        public void GetException(){} // RVA: 0x7FFAC8E30420
        public void ProcessHandshake(){} // RVA: 0x7FFAC8E30A80
        public void DoProcessHandshake(){} // RVA: 0x7FFAC8E30BC0
        public void FinishHandshake(){} // RVA: 0x7FFAC8E30DC0
        public void InitializeConnection(){} // RVA: 0x7FFAC8E30DE0
        public void GetPeerCertificate(){} // RVA: 0x7FFAC8E318B0
        public void InitializeSession(){} // RVA: 0x7FFAC8E31B60
        public void GetProtocol(){} // RVA: 0x7FFAC8E31F30
        public void Flush(){} // RVA: 0x7FFAC8E31FB0
        public void Read(){} // RVA: 0x7FFAC8E31FF0
        public void Write(){} // RVA: 0x7FFAC8E32370
        public void Renegotiate(){} // RVA: 0x7FFAC8E326A0
        public void Shutdown(){} // RVA: 0x7FFAC8E326E0
        public void PendingRenegotiation(){} // RVA: 0x7FFAC8E32890
        public void Dispose(){} // RVA: 0x7FFAC8E32940 | overloaded x2
        public void Mono.Btls.IMonoBtlsBioMono.Read(){} // RVA: 0x7FFAC8E32AC0
        public void Mono.Btls.IMonoBtlsBioMono.Write(){} // RVA: 0x7FFAC8E32AF0
        public void Mono.Btls.IMonoBtlsBioMono.Flush(){} // RVA: 0x7FFAC2F21310
        public void Mono.Btls.IMonoBtlsBioMono.Close(){} // RVA: 0x7FFAC2F21310
        public void get_IsAuthenticated(){} // RVA: 0x7FFAC4848B60
        public void get_LocalClientCertificate(){} // RVA: 0x7FFAC2FBF370
        public void get_RemoteCertificate(){} // RVA: 0x7FFAC2FE9500
    }

    public class MonoBtlsError : Object
    {
        // ── Methods ──
        public void mono_btls_error_clear_error(){} // RVA: 0x7FFAC8E32B20
        public void mono_btls_error_get_error_line(){} // RVA: 0x7FFAC8E32B90
        public void mono_btls_error_get_error_string_n(){} // RVA: 0x7FFAC8E32C20
        public void mono_btls_error_get_reason(){} // RVA: 0x7FFAC8E32CC0
        public void ClearError(){} // RVA: 0x7FFAC8E32B20
        public void GetErrorString(){} // RVA: 0x7FFAC8E32D40
        public void GetError(){} // RVA: 0x7FFAC8E32F70
        public void GetErrorReason(){} // RVA: 0x7FFAC8E32CC0
    }

    public class MonoBtlsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8E33280 | overloaded x4
    }

    public class MonoBtlsKey : MonoBtlsObject
    {
        public object Handle;

        // ── Methods ──
        public void mono_btls_key_new(){} // RVA: 0x7FFAC8E333A0
        public void mono_btls_key_free(){} // RVA: 0x7FFAC8E33410
        public void mono_btls_key_up_ref(){} // RVA: 0x7FFAC8E33490
        public void mono_btls_key_get_bytes(){} // RVA: 0x7FFAC8E33510
        public void mono_btls_key_assign_rsa_private_key(){} // RVA: 0x7FFAC8E335C0
        public void get_Handle(){} // RVA: 0x7FFAC8E33670
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetBytes(){} // RVA: 0x7FFAC8E336F0
        public void Copy(){} // RVA: 0x7FFAC8E33890
        public void CreateFromRSAPrivateKey(){} // RVA: 0x7FFAC8E33A30
    }

    public class MonoBtlsObject : Object
    {
        public MonoBtlsHandle Handle; // 0x10
        public System.Exception IsValid; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Handle(){} // RVA: 0x7FFAC8E33D00
        public void get_IsValid(){} // RVA: 0x7FFAC8E33D20
        public void CheckThrow(){} // RVA: 0x7FFAC8E33D60
        public void SetException(){} // RVA: 0x7FFAC8E33E00
        public void CheckError(){} // RVA: 0x7FFAC8E33FF0 | overloaded x2
        public void CheckLastError(){} // RVA: 0x7FFAC8E34000
        public void mono_btls_free(){} // RVA: 0x7FFAC8E34200
        public void FreeDataPtr(){} // RVA: 0x7FFAC8E34280
        public void Close(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC8E34560 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8E345C0
    }

    public class MonoBtlsPkcs12 : MonoBtlsObject
    {
        public Mono.Btls.MonoBtlsKey Handle; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC8E34620
        public void mono_btls_pkcs12_free(){} // RVA: 0x7FFAC8E346A0
        public void mono_btls_pkcs12_new(){} // RVA: 0x7FFAC8E34720
        public void mono_btls_pkcs12_get_count(){} // RVA: 0x7FFAC8E34790
        public void mono_btls_pkcs12_get_cert(){} // RVA: 0x7FFAC8E34810
        public void mono_btls_pkcs12_import(){} // RVA: 0x7FFAC8E348A0
        public void mono_btls_pkcs12_has_private_key(){} // RVA: 0x7FFAC8E349A0
        public void mono_btls_pkcs12_get_private_key(){} // RVA: 0x7FFAC8E34A20
        public void .ctor(){} // RVA: 0x7FFAC8E34AA0
        public void get_Count(){} // RVA: 0x7FFAC8E34BE0
        public void GetCertificate(){} // RVA: 0x7FFAC8E34C80
        public void Import(){} // RVA: 0x7FFAC8E34E70
        public void get_HasPrivateKey(){} // RVA: 0x7FFAC8E34FF0
        public void GetPrivateKey(){} // RVA: 0x7FFAC8E35090
    }

    public class MonoBtlsProvider : MobileTlsProvider
    {
        public object ID;
        public object Name;
        public object SupportsSslStream;
        public object SupportsMonoExtensions;
        public object SupportsConnectionInfo;
        public object SupportsCleanShutdown;
        public object SupportedProtocols;

        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFAC8E35320
        public void get_Name(){} // RVA: 0x7FFAC8E35380
        public void .ctor(){} // RVA: 0x7FFAC8E353C0
        public void get_SupportsSslStream(){} // RVA: 0x7FFAC3006850
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFAC3006850
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFAC3006850
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFAC3006850
        public void get_SupportedProtocols(){} // RVA: 0x7FFAC8E1D640
        public void CreateSslStream(){} // RVA: 0x7FFAC8E35450
        public void GetNativeCertificate(){} // RVA: 0x7FFAC8E357F0 | overloaded x3
        public void GetVerifyParam(){} // RVA: 0x7FFAC8E35870
        public void ValidateCertificate(){} // RVA: 0x7FFAC8E36460 | overloaded x2
        public void CheckValidationResult(){} // RVA: 0x7FFAC8E36660
        public void MapVerifyErrorToChainStatus(){} // RVA: 0x7FFAC8E36A10
        public void SetupCertificateStore(){} // RVA: 0x7FFAC8E36C60
        public void SetupDefaultCertificateStore(){} // RVA: 0x7FFAC8E37150
        public void AddUserStore(){} // RVA: 0x7FFAC8E37270
        public void AddMachineStore(){} // RVA: 0x7FFAC8E37310
        public void AddTrustedRoots(){} // RVA: 0x7FFAC8E373B0
        public void CreateCertificate(){} // RVA: 0x7FFAC8E374E0
        public void GetManagedChain(){} // RVA: 0x7FFAC8E37650
        public void GetBtlsCertificate(){} // RVA: 0x7FFAC8E376E0
        public void GetNativeChain(){} // RVA: 0x7FFAC8E377F0
    }

    public class MonoBtlsSelectCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8972CF0
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class MonoBtlsServerNameCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC556C080
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class MonoBtlsSsl : MonoBtlsObject
    {
        public Mono.Btls.MonoBtlsBio Handle; // 0x20
        public PrintErrorsCallbackFunc printErrorsFunc; // 0x28
        public UIntPtr printErrorsFuncPtr; // 0x30

        // ── Methods ──
        public void mono_btls_ssl_destroy(){} // RVA: 0x7FFAC936E260
        public void mono_btls_ssl_new(){} // RVA: 0x7FFAC936E2E0
        public void mono_btls_ssl_use_certificate(){} // RVA: 0x7FFAC936E360
        public void mono_btls_ssl_use_private_key(){} // RVA: 0x7FFAC936E3F0
        public void mono_btls_ssl_add_chain_certificate(){} // RVA: 0x7FFAC936E480
        public void mono_btls_ssl_accept(){} // RVA: 0x7FFAC936E510
        public void mono_btls_ssl_connect(){} // RVA: 0x7FFAC936E590
        public void mono_btls_ssl_handshake(){} // RVA: 0x7FFAC936E610
        public void mono_btls_ssl_close(){} // RVA: 0x7FFAC936E690
        public void mono_btls_ssl_shutdown(){} // RVA: 0x7FFAC936E710
        public void mono_btls_ssl_set_quiet_shutdown(){} // RVA: 0x7FFAC936E790
        public void mono_btls_ssl_set_bio(){} // RVA: 0x7FFAC936E820
        public void mono_btls_ssl_read(){} // RVA: 0x7FFAC936E8B0
        public void mono_btls_ssl_write(){} // RVA: 0x7FFAC936E950
        public void mono_btls_ssl_get_error(){} // RVA: 0x7FFAC936E9F0
        public void mono_btls_ssl_get_version(){} // RVA: 0x7FFAC936EA80
        public void mono_btls_ssl_get_cipher(){} // RVA: 0x7FFAC936EB00
        public void mono_btls_ssl_get_peer_certificate(){} // RVA: 0x7FFAC936EB80
        public void mono_btls_ssl_print_errors_cb(){} // RVA: 0x7FFAC936EC00
        public void mono_btls_ssl_set_server_name(){} // RVA: 0x7FFAC936EC90
        public void mono_btls_ssl_get_server_name(){} // RVA: 0x7FFAC936ED20
        public void mono_btls_ssl_set_renegotiate_mode(){} // RVA: 0x7FFAC936EDA0
        public void mono_btls_ssl_renegotiate_pending(){} // RVA: 0x7FFAC936EE30
        public void Create_internal(){} // RVA: 0x7FFAC936EEB0
        public void .ctor(){} // RVA: 0x7FFAC936F000
        public void get_Handle(){} // RVA: 0x7FFAC936F360
        public void SetBio(){} // RVA: 0x7FFAC936F3E0
        public void ThrowError(){} // RVA: 0x7FFAC936F500
        public void GetError(){} // RVA: 0x7FFAC936F6B0
        public void SetCertificate(){} // RVA: 0x7FFAC936F730
        public void SetPrivateKey(){} // RVA: 0x7FFAC936F830
        public void AddIntermediateCertificate(){} // RVA: 0x7FFAC936F930
        public void Accept(){} // RVA: 0x7FFAC936FA30
        public void Connect(){} // RVA: 0x7FFAC936FAF0
        public void Handshake(){} // RVA: 0x7FFAC936FBB0
        public void PrintErrorsCallback(){} // RVA: 0x7FFAC936FC70
        public void GetErrors(){} // RVA: 0x7FFAC936FDB0
        public void PrintErrors(){} // RVA: 0x7FFAC936FF30
        public void Read(){} // RVA: 0x7FFAC936FFC0
        public void Write(){} // RVA: 0x7FFAC93700C0
        public void GetVersion(){} // RVA: 0x7FFAC93701D0
        public void GetCipher(){} // RVA: 0x7FFAC9370270
        public void GetPeerCertificate(){} // RVA: 0x7FFAC9370360
        public void SetServerName(){} // RVA: 0x7FFAC93704F0
        public void GetServerName(){} // RVA: 0x7FFAC93706E0
        public void Shutdown(){} // RVA: 0x7FFAC93707F0
        public void SetQuietShutdown(){} // RVA: 0x7FFAC93708C0
        public void Close(){} // RVA: 0x7FFAC9370960
        public void SetRenegotiateMode(){} // RVA: 0x7FFAC9370A30
        public void RenegotiatePending(){} // RVA: 0x7FFAC9370AE0
    }

    public class MonoBtlsSslCtx : MonoBtlsObject
    {
        public NativeVerifyFunc Handle; // 0x20
        public NativeSelectFunc CertificateStore; // 0x28
        public NativeServerNameFunc serverNameFunc; // 0x30
        public UIntPtr verifyFuncPtr; // 0x38
        public UIntPtr selectFuncPtr; // 0x40
        public UIntPtr serverNameFuncPtr; // 0x48
        public Mono.Btls.MonoBtlsVerifyCallback verifyCallback; // 0x50
        public Mono.Btls.MonoBtlsSelectCallback selectCallback; // 0x58
        public Mono.Btls.MonoBtlsServerNameCallback serverNameCallback; // 0x60
        public Mono.Btls.MonoBtlsX509Store store; // 0x68
        public System.Runtime.InteropServices.GCHandle instance; // 0x70
        public UIntPtr instancePtr; // 0x78

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC9370C10
        public void mono_btls_ssl_ctx_new(){} // RVA: 0x7FFAC9370C90
        public void mono_btls_ssl_ctx_free(){} // RVA: 0x7FFAC9370D00
        public void mono_btls_ssl_ctx_initialize(){} // RVA: 0x7FFAC9370D80
        public void mono_btls_ssl_ctx_set_cert_verify_callback(){} // RVA: 0x7FFAC9370E10
        public void mono_btls_ssl_ctx_set_cert_select_callback(){} // RVA: 0x7FFAC9370EB0
        public void mono_btls_ssl_ctx_set_min_version(){} // RVA: 0x7FFAC9370F40
        public void mono_btls_ssl_ctx_set_max_version(){} // RVA: 0x7FFAC9370FD0
        public void mono_btls_ssl_ctx_set_ciphers(){} // RVA: 0x7FFAC9371060
        public void mono_btls_ssl_ctx_set_verify_param(){} // RVA: 0x7FFAC9371100
        public void mono_btls_ssl_ctx_set_client_ca_list(){} // RVA: 0x7FFAC9371190
        public void mono_btls_ssl_ctx_set_server_name_callback(){} // RVA: 0x7FFAC9371230
        public void .ctor(){} // RVA: 0x7FFAC93713B0 | overloaded x2
        public void get_CertificateStore(){} // RVA: 0x7FFAC2F9CD50
        public void VerifyCallback(){} // RVA: 0x7FFAC9371B40
        public void NativeVerifyCallback(){} // RVA: 0x7FFAC9371B70
        public void NativeSelectCallback(){} // RVA: 0x7FFAC9371F20
        public void CopyIssuers(){} // RVA: 0x7FFAC9372090
        public void SetVerifyCallback(){} // RVA: 0x7FFAC9372430
        public void SetSelectCallback(){} // RVA: 0x7FFAC9372550
        public void SetMinVersion(){} // RVA: 0x7FFAC9372650
        public void SetMaxVersion(){} // RVA: 0x7FFAC9372700
        public void SetCiphers(){} // RVA: 0x7FFAC93727B0
        public void SetVerifyParam(){} // RVA: 0x7FFAC9372AA0
        public void SetClientCertificateIssuers(){} // RVA: 0x7FFAC9372BB0
        public void SetServerNameCallback(){} // RVA: 0x7FFAC9373240
        public void NativeServerNameCallback(){} // RVA: 0x7FFAC9373340
        public void Close(){} // RVA: 0x7FFAC9373470
    }

    public class MonoBtlsStream : MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9373620
        public void CreateContext(){} // RVA: 0x7FFAC93736B0
    }

    public class MonoBtlsUtils : Object
    {
        public byte[] emailOid;

        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFAC9373790
        public void AppendEntry(){} // RVA: 0x7FFAC9373810
        public void FormatName(){} // RVA: 0x7FFAC9373EE0
        public void .cctor(){} // RVA: 0x7FFAC9374050
    }

    public class MonoBtlsVerifyCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CB5ED0
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    }

    public class MonoBtlsX509 : MonoBtlsObject
    {
        public object Handle;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC9374130
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void mono_btls_x509_up_ref(){} // RVA: 0x7FFAC93741B0
        public void mono_btls_x509_from_data(){} // RVA: 0x7FFAC9374230
        public void mono_btls_x509_get_subject_name(){} // RVA: 0x7FFAC93742D0
        public void mono_btls_x509_get_raw_data(){} // RVA: 0x7FFAC9374350
        public void mono_btls_x509_cmp(){} // RVA: 0x7FFAC93743F0
        public void mono_btls_x509_free(){} // RVA: 0x7FFAC9374480
        public void mono_btls_x509_add_explicit_trust(){} // RVA: 0x7FFAC9374500
        public void Copy(){} // RVA: 0x7FFAC9374590
        public void LoadFromData(){} // RVA: 0x7FFAC9374730
        public void GetSubjectName(){} // RVA: 0x7FFAC9374A40
        public void GetSubjectNameHash(){} // RVA: 0x7FFAC9374C00
        public void GetRawData(){} // RVA: 0x7FFAC9374E90
        public void Compare(){} // RVA: 0x7FFAC9375180
        public void AddExplicitTrust(){} // RVA: 0x7FFAC9375250
    }

    public class MonoBtlsX509Chain : MonoBtlsObject
    {
        public object Handle;
        public object Count;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC93753E0
        public void mono_btls_x509_chain_new(){} // RVA: 0x7FFAC9375460
        public void mono_btls_x509_chain_get_count(){} // RVA: 0x7FFAC93754D0
        public void mono_btls_x509_chain_get_cert(){} // RVA: 0x7FFAC9375550
        public void mono_btls_x509_chain_add_cert(){} // RVA: 0x7FFAC93755E0
        public void mono_btls_x509_chain_up_ref(){} // RVA: 0x7FFAC9375670
        public void mono_btls_x509_chain_free(){} // RVA: 0x7FFAC93756F0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC93758B0
        public void GetCertificate(){} // RVA: 0x7FFAC9375950
        public void AddCertificate(){} // RVA: 0x7FFAC9375B40
        public void Copy(){} // RVA: 0x7FFAC9375C00
    }

    public class MonoBtlsX509Lookup : MonoBtlsObject
    {
        public Mono.Btls.MonoBtlsX509Store Handle; // 0x20
        public 0x6B12E310 type; // 0x28
        public System.Collections.Generic.List`1<Mono.Btls.MonoBtlsX509LookupMono> monoLookups; // 0x30

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC9375E20
        public void mono_btls_x509_lookup_new(){} // RVA: 0x7FFAC9375EA0
        public void mono_btls_x509_lookup_add_dir(){} // RVA: 0x7FFAC9375F30
        public void mono_btls_x509_lookup_add_mono(){} // RVA: 0x7FFAC9375FD0
        public void mono_btls_x509_lookup_free(){} // RVA: 0x7FFAC9376060
        public void mono_btls_x509_lookup_peek_lookup(){} // RVA: 0x7FFAC93760E0
        public void Create_internal(){} // RVA: 0x7FFAC9376160
        public void .ctor(){} // RVA: 0x7FFAC93762C0
        public void GetNativeLookup(){} // RVA: 0x7FFAC93764F0
        public void AddDirectory(){} // RVA: 0x7FFAC9376590
        public void AddMono(){} // RVA: 0x7FFAC9376740
        public void AddCertificate(){} // RVA: 0x7FFAC9376A40
        public void Close(){} // RVA: 0x7FFAC9376B50
    }

    public class MonoBtlsX509LookupMono : MonoBtlsObject
    {
        public System.Runtime.InteropServices.GCHandle Handle; // 0x20
        public UIntPtr instance; // 0x28
        public BySubjectFunc bySubjectFunc; // 0x30
        public UIntPtr bySubjectFuncPtr; // 0x38
        public Mono.Btls.MonoBtlsX509Lookup lookup; // 0x40

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC9376E30
        public void mono_btls_x509_lookup_mono_new(){} // RVA: 0x7FFAC9376EB0
        public void mono_btls_x509_lookup_mono_init(){} // RVA: 0x7FFAC9376F20
        public void mono_btls_x509_lookup_mono_free(){} // RVA: 0x7FFAC9376FC0
        public void .ctor(){} // RVA: 0x7FFAC9377040
        public void Install(){} // RVA: 0x7FFAC93773C0
        public void AddCertificate(){} // RVA: 0x7FFAC9377460
        public void OnGetBySubject(){} // RVA: 0x7FFAC9377580 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC93778B0
    }

    public class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
    {
        public long[] hashes; // 0x48
        public Mono.Btls.MonoBtlsX509[] certificates; // 0x50
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection collection; // 0x58
        public 0x6B12E680 trust; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9377A60
        public void Initialize(){} // RVA: 0x7FFAC9377AF0
        public void OnGetBySubject(){} // RVA: 0x7FFAC9377F30
        public void Close(){} // RVA: 0x7FFAC9377FF0
    }

    public class MonoBtlsX509Name : MonoBtlsObject
    {
        public object Handle;

        // ── Methods ──
        public void mono_btls_x509_name_hash(){} // RVA: 0x7FFAC93781D0
        public void mono_btls_x509_name_get_entry_count(){} // RVA: 0x7FFAC9378250
        public void mono_btls_x509_name_get_entry_type(){} // RVA: 0x7FFAC93782D0
        public void mono_btls_x509_name_get_entry_oid(){} // RVA: 0x7FFAC9378360
        public void mono_btls_x509_name_get_entry_oid_data(){} // RVA: 0x7FFAC9378400
        public void mono_btls_x509_name_get_entry_value(){} // RVA: 0x7FFAC93784A0
        public void mono_btls_x509_name_from_data(){} // RVA: 0x7FFAC9378540
        public void mono_btls_x509_name_free(){} // RVA: 0x7FFAC93785E0
        public void get_Handle(){} // RVA: 0x7FFAC9378660
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetHash(){} // RVA: 0x7FFAC93786E0
        public void GetEntryCount(){} // RVA: 0x7FFAC9378780
        public void GetEntryType(){} // RVA: 0x7FFAC9378820
        public void GetEntryOid(){} // RVA: 0x7FFAC9378910
        public void GetEntryOidData(){} // RVA: 0x7FFAC9378B90
        public void GetEntryValue(){} // RVA: 0x7FFAC9378D00
        public void CreateFromData(){} // RVA: 0x7FFAC9378F10
    }

    public class MonoBtlsX509Store : MonoBtlsObject
    {
        public System.Collections.Generic.Dictionary`2<UIntPtr,Mono.Btls.MonoBtlsX509Lookup> Handle; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC93791E0
        public void mono_btls_x509_store_new(){} // RVA: 0x7FFAC9379260
        public void mono_btls_x509_store_from_ssl_ctx(){} // RVA: 0x7FFAC93792D0
        public void mono_btls_x509_store_add_cert(){} // RVA: 0x7FFAC9379350
        public void mono_btls_x509_store_free(){} // RVA: 0x7FFAC93793E0
        public void Create_internal(){} // RVA: 0x7FFAC9379580 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9379830 | overloaded x2
        public void AddCertificate(){} // RVA: 0x7FFAC93799C0
        public void AddLookup(){} // RVA: 0x7FFAC9379AD0
        public void AddDirectoryLookup(){} // RVA: 0x7FFAC9379DE0
        public void AddCollection(){} // RVA: 0x7FFAC9379E30
        public void Close(){} // RVA: 0x7FFAC9379F40
    }

    public class MonoBtlsX509StoreCtx : MonoBtlsObject
    {
        public System.Nullable`1<int> Handle; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC937A2E0
        public void mono_btls_x509_store_ctx_new(){} // RVA: 0x7FFAC937A360
        public void mono_btls_x509_store_ctx_from_ptr(){} // RVA: 0x7FFAC937A3D0
        public void mono_btls_x509_store_ctx_get_error(){} // RVA: 0x7FFAC937A450
        public void mono_btls_x509_store_ctx_get_chain(){} // RVA: 0x7FFAC937A4E0
        public void mono_btls_x509_store_ctx_init(){} // RVA: 0x7FFAC937A560
        public void mono_btls_x509_store_ctx_set_param(){} // RVA: 0x7FFAC937A600
        public void mono_btls_x509_store_ctx_verify_cert(){} // RVA: 0x7FFAC937A690
        public void mono_btls_x509_store_ctx_get_untrusted(){} // RVA: 0x7FFAC937A710
        public void mono_btls_x509_store_ctx_up_ref(){} // RVA: 0x7FFAC937A790
        public void mono_btls_x509_store_ctx_free(){} // RVA: 0x7FFAC937A810
        public void .ctor(){} // RVA: 0x7FFAC937ACD0 | overloaded x3
        public void Create_internal(){} // RVA: 0x7FFAC937A9D0
        public void GetError(){} // RVA: 0x7FFAC937AD30
        public void GetChain(){} // RVA: 0x7FFAC937ADE0
        public void GetUntrusted(){} // RVA: 0x7FFAC937AF80
        public void Initialize(){} // RVA: 0x7FFAC937B120
        public void SetVerifyParam(){} // RVA: 0x7FFAC937B260
        public void get_VerifyResult(){} // RVA: 0x7FFAC937B370
        public void Verify(){} // RVA: 0x7FFAC937B400
        public void Copy(){} // RVA: 0x7FFAC937B500
    }

    public class MonoBtlsX509StoreManager : Object
    {
        public bool initialized;
        public string machineTrustedRootPath; // 0x8
        public string machineIntermediateCAPath; // 0x10
        public string machineUntrustedPath; // 0x18
        public string userTrustedRootPath; // 0x20
        public string userIntermediateCAPath; // 0x28
        public string userUntrustedPath; // 0x30

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC937B750
        public void DoInitialize(){} // RVA: 0x7FFAC937B850
        public void GetStorePath(){} // RVA: 0x7FFAC937BF50
    }

    public class MonoBtlsX509VerifyParam : MonoBtlsObject
    {
        public object Handle;
        public object CanModify;

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFAC937C090
        public void mono_btls_x509_verify_param_copy(){} // RVA: 0x7FFAC937C110
        public void mono_btls_x509_verify_param_lookup(){} // RVA: 0x7FFAC937C190
        public void mono_btls_x509_verify_param_can_modify(){} // RVA: 0x7FFAC937C210
        public void mono_btls_x509_verify_param_set_host(){} // RVA: 0x7FFAC937C290
        public void mono_btls_x509_verify_param_set_time(){} // RVA: 0x7FFAC937C330
        public void mono_btls_x509_verify_param_free(){} // RVA: 0x7FFAC937C3C0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Copy(){} // RVA: 0x7FFAC937C440
        public void GetSslClient(){} // RVA: 0x7FFAC937C5E0
        public void GetSslServer(){} // RVA: 0x7FFAC937C620
        public void Lookup(){} // RVA: 0x7FFAC937C660
        public void get_CanModify(){} // RVA: 0x7FFAC937C950
        public void WantToModify(){} // RVA: 0x7FFAC937C9F0
        public void SetHost(){} // RVA: 0x7FFAC937CAE0
        public void SetTime(){} // RVA: 0x7FFAC937CCA0
    }

    public class X509CertificateImplBtls : X509Certificate2ImplUnix
    {
        public Mono.Btls.MonoBtlsX509 IsValid; // 0xB0
        public Mono.Btls.MonoBtlsKey X509; // 0xB8
        public System.Security.Cryptography.X509Certificates.X509CertificateImplCollection NativePrivateKey; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC937D370 | overloaded x4
        public void get_IsValid(){} // RVA: 0x7FFAC937D510
        public void get_X509(){} // RVA: 0x7FFAC937D560
        public void get_NativePrivateKey(){} // RVA: 0x7FFAC937D5B0
        public void Clone(){} // RVA: 0x7FFAC937D600
        public void GetRawCertData(){} // RVA: 0x7FFAC937D6A0
        public void get_IntermediateCertificates(){} // RVA: 0x7FFAC2F8C120
        public void Dispose(){} // RVA: 0x7FFAC937D750
        public void get_HasPrivateKey(){} // RVA: 0x7FFAC91309D0
        public void get_PrivateKey(){} // RVA: 0x7FFAC937D830
        public void set_PrivateKey(){} // RVA: 0x7FFAC937D870
        public void GetRSAPrivateKey(){} // RVA: 0x7FFAC937D830
        public void GetDSAPrivateKey(){} // RVA: 0x7FFAC937D9E0
        public void Import(){} // RVA: 0x7FFAC937DA20
        public void ImportPkcs12(){} // RVA: 0x7FFAC937DAE0
        public void ImportAuthenticode(){} // RVA: 0x7FFAC937E250
        public void Verify(){} // RVA: 0x7FFAC937E2F0
    }

    public class X509ChainImplBtls : X509ChainImpl
    {
        public Mono.Btls.MonoBtlsX509StoreCtx IsValid; // 0x10
        public Mono.Btls.MonoBtlsX509Chain StoreCtx; // 0x18
        public Mono.Btls.MonoBtlsX509Chain ChainElements; // 0x20
        public System.Security.Cryptography.X509Certificates.X509ChainElementCollection ChainPolicy; // 0x28
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection untrusted; // 0x30
        public System.Security.Cryptography.X509Certificates.X509Certificate2[] certificates; // 0x38
        public System.Security.Cryptography.X509Certificates.X509ChainPolicy policy; // 0x40
        public System.Collections.Generic.List`1<System.Security.Cryptography.X509Certificates.X509ChainStatus> chainStatusList; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC937E840 | overloaded x2
        public void get_IsValid(){} // RVA: 0x7FFAC937F180
        public void get_StoreCtx(){} // RVA: 0x7FFAC937F1C0
        public void get_ChainElements(){} // RVA: 0x7FFAC937F210
        public void get_ChainPolicy(){} // RVA: 0x7FFAC2F9E740
        public void AddStatus(){} // RVA: 0x7FFAC937F600
        public void Build(){} // RVA: 0x7FFAC2F21320
        public void Reset(){} // RVA: 0x7FFAC937F790
        public void Dispose(){} // RVA: 0x7FFAC937F8F0
    }

    public class X509PalImplBtls : X509PalImpl
    {
        public Mono.Btls.MonoBtlsProvider Provider; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC937FBE0
        public void get_Provider(){} // RVA: 0x7FFAC2F3C380
        public void Import(){} // RVA: 0x7FFAC937FD60 | overloaded x3
    }

}