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
        public void Flush(){} // RVA: 0x7FFE80E45FE0
        public void Close(){} // RVA: 0x7FFE80E45FE0
    }

    public class MonoBtlsBio : MonoBtlsObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Handle(){} // RVA: 0x7FFE871D5C30
        public void mono_btls_bio_free(){} // RVA: 0x7FFE871D5CB0
    }

    public class MonoBtlsBioMemory : MonoBtlsBio
    {
        // ── Methods ──
        public void mono_btls_bio_mem_new(){} // RVA: 0x7FFE871D5E20
        public void mono_btls_bio_mem_get_data(){} // RVA: 0x7FFE871D5E90
        public void .ctor(){} // RVA: 0x7FFE871D5F20
        public void GetData(){} // RVA: 0x7FFE871D6060
    }

    public class MonoBtlsBioMono : MonoBtlsBio
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871D62E0
        public void mono_btls_bio_mono_new(){} // RVA: 0x7FFE871D69A0
        public void mono_btls_bio_mono_initialize(){} // RVA: 0x7FFE871D6A10
        public void Control(){} // RVA: 0x7FFE871D7330 | overloaded x2
        public void OnRead(){} // RVA: 0x7FFE871D6CE0 | overloaded x2
        public void OnWrite(){} // RVA: 0x7FFE871D70D0 | overloaded x2
        public void Close(){} // RVA: 0x7FFE871D74D0
    }

    public class MonoBtlsContext : MobileTlsContext
    {
        public System.Security.Cryptography.X509Certificates.X509Certificate2 remoteCertificate; // 0x58
        public System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate; // 0x60
        public Mono.Btls.X509CertificateImplBtls nativeServerCertificate; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871D76E0
        public void GetPrivateCertificate(){} // RVA: 0x7FFE871D7760
        public void VerifyCallback(){} // RVA: 0x7FFE871D7A00
        public void SelectCallback(){} // RVA: 0x7FFE871D7C20
        public void ServerNameCallback(){} // RVA: 0x7FFE871D7D90
        public void StartHandshake(){} // RVA: 0x7FFE871D7E50
        public void SetPrivateCertificate(){} // RVA: 0x7FFE871D81F0
        public void GetException(){} // RVA: 0x7FFE871D8850
        public void ProcessHandshake(){} // RVA: 0x7FFE871D8EB0
        public void DoProcessHandshake(){} // RVA: 0x7FFE871D8FF0
        public void FinishHandshake(){} // RVA: 0x7FFE871D91F0
        public void InitializeConnection(){} // RVA: 0x7FFE871D9210
        public void GetPeerCertificate(){} // RVA: 0x7FFE871D9CE0
        public void InitializeSession(){} // RVA: 0x7FFE871D9F90
        public void GetProtocol(){} // RVA: 0x7FFE871DA360
        public void Flush(){} // RVA: 0x7FFE871DA3E0
        public void Read(){} // RVA: 0x7FFE871DA420
        public void Write(){} // RVA: 0x7FFE871DA7A0
        public void Renegotiate(){} // RVA: 0x7FFE871DAAD0
        public void Shutdown(){} // RVA: 0x7FFE871DAB10
        public void PendingRenegotiation(){} // RVA: 0x7FFE871DACC0
        public void Dispose(){} // RVA: 0x7FFE871DAD70 | overloaded x2
        public void Mono.Btls.IMonoBtlsBioMono.Read(){} // RVA: 0x7FFE871DAEF0
        public void Mono.Btls.IMonoBtlsBioMono.Write(){} // RVA: 0x7FFE871DAF20
        public void Mono.Btls.IMonoBtlsBioMono.Flush(){} // RVA: 0x7FFE810FB310
        public void Mono.Btls.IMonoBtlsBioMono.Close(){} // RVA: 0x7FFE810FB310
        public void get_IsAuthenticated(){} // RVA: 0x7FFE82AB0F00
        public void get_LocalClientCertificate(){} // RVA: 0x7FFE81199370
        public void get_RemoteCertificate(){} // RVA: 0x7FFE811C3500
    }

    public class MonoBtlsError : Object
    {
        // ── Methods ──
        public void mono_btls_error_clear_error(){} // RVA: 0x7FFE871DAF50
        public void mono_btls_error_get_error_line(){} // RVA: 0x7FFE871DAFC0
        public void mono_btls_error_get_error_string_n(){} // RVA: 0x7FFE871DB050
        public void mono_btls_error_get_reason(){} // RVA: 0x7FFE871DB0F0
        public void ClearError(){} // RVA: 0x7FFE871DAF50
        public void GetErrorString(){} // RVA: 0x7FFE871DB170
        public void GetError(){} // RVA: 0x7FFE871DB3A0
        public void GetErrorReason(){} // RVA: 0x7FFE871DB0F0
    }

    public class MonoBtlsException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871DB6B0 | overloaded x4
    }

    public class MonoBtlsKey : MonoBtlsObject
    {
        // ── Methods ──
        public void mono_btls_key_new(){} // RVA: 0x7FFE871DB7D0
        public void mono_btls_key_free(){} // RVA: 0x7FFE871DB840
        public void mono_btls_key_up_ref(){} // RVA: 0x7FFE871DB8C0
        public void mono_btls_key_get_bytes(){} // RVA: 0x7FFE871DB940
        public void mono_btls_key_assign_rsa_private_key(){} // RVA: 0x7FFE871DB9F0
        public void get_Handle(){} // RVA: 0x7FFE871DBAA0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetBytes(){} // RVA: 0x7FFE871DBB20
        public void Copy(){} // RVA: 0x7FFE871DBCC0
        public void CreateFromRSAPrivateKey(){} // RVA: 0x7FFE871DBE60
    }

    public class MonoBtlsObject : Object
    {
        public MonoBtlsHandle handle; // 0x10
        public System.Exception lastError; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Handle(){} // RVA: 0x7FFE871DC130
        public void get_IsValid(){} // RVA: 0x7FFE871DC150
        public void CheckThrow(){} // RVA: 0x7FFE871DC190
        public void SetException(){} // RVA: 0x7FFE871DC230
        public void CheckError(){} // RVA: 0x7FFE871DC420 | overloaded x2
        public void CheckLastError(){} // RVA: 0x7FFE871DC430
        public void mono_btls_free(){} // RVA: 0x7FFE871DC630
        public void FreeDataPtr(){} // RVA: 0x7FFE871DC6B0
        public void Close(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE871DC990 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE871DC9F0
    }

    public class MonoBtlsPkcs12 : MonoBtlsObject
    {
        public Mono.Btls.MonoBtlsKey privateKey; // 0x20
        public object field_1; // 0x69
        public object field_2; // 0x6A

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE871DCA50
        public void mono_btls_pkcs12_free(){} // RVA: 0x7FFE871DCAD0
        public void mono_btls_pkcs12_new(){} // RVA: 0x7FFE871DCB50
        public void mono_btls_pkcs12_get_count(){} // RVA: 0x7FFE871DCBC0
        public void mono_btls_pkcs12_get_cert(){} // RVA: 0x7FFE871DCC40
        public void mono_btls_pkcs12_import(){} // RVA: 0x7FFE871DCCD0
        public void mono_btls_pkcs12_has_private_key(){} // RVA: 0x7FFE871DCDD0
        public void mono_btls_pkcs12_get_private_key(){} // RVA: 0x7FFE871DCE50
        public void .ctor(){} // RVA: 0x7FFE871DCED0
        public void get_Count(){} // RVA: 0x7FFE871DD010
        public void GetCertificate(){} // RVA: 0x7FFE871DD0B0
        public void Import(){} // RVA: 0x7FFE871DD2A0
        public void get_HasPrivateKey(){} // RVA: 0x7FFE871DD420
        public void GetPrivateKey(){} // RVA: 0x7FFE871DD4C0
    }

    public class MonoBtlsProvider : MobileTlsProvider
    {
        // ── Methods ──
        public void get_ID(){} // RVA: 0x7FFE871DD750
        public void get_Name(){} // RVA: 0x7FFE871DD7B0
        public void .ctor(){} // RVA: 0x7FFE871DD7F0
        public void get_SupportsSslStream(){} // RVA: 0x7FFE811E0850
        public void get_SupportsMonoExtensions(){} // RVA: 0x7FFE811E0850
        public void get_SupportsConnectionInfo(){} // RVA: 0x7FFE811E0850
        public void get_SupportsCleanShutdown(){} // RVA: 0x7FFE811E0850
        public void get_SupportedProtocols(){} // RVA: 0x7FFE871C5A70
        public void CreateSslStream(){} // RVA: 0x7FFE871DD880
        public void GetNativeCertificate(){} // RVA: 0x7FFE871DDC20 | overloaded x3
        public void GetVerifyParam(){} // RVA: 0x7FFE871DDCA0
        public void ValidateCertificate(){} // RVA: 0x7FFE871DE890 | overloaded x2
        public void CheckValidationResult(){} // RVA: 0x7FFE871DEA90
        public void MapVerifyErrorToChainStatus(){} // RVA: 0x7FFE871DEE40
        public void SetupCertificateStore(){} // RVA: 0x7FFE871DF090
        public void SetupDefaultCertificateStore(){} // RVA: 0x7FFE871DF580
        public void AddUserStore(){} // RVA: 0x7FFE871DF6A0
        public void AddMachineStore(){} // RVA: 0x7FFE871DF740
        public void AddTrustedRoots(){} // RVA: 0x7FFE871DF7E0
        public void CreateCertificate(){} // RVA: 0x7FFE871DF910
        public void GetManagedChain(){} // RVA: 0x7FFE871DFA80
        public void GetBtlsCertificate(){} // RVA: 0x7FFE871DFB10
        public void GetNativeChain(){} // RVA: 0x7FFE871DFC20
    }

    public class MonoBtlsSelectCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D1C380
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class MonoBtlsServerNameCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE83871300
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class MonoBtlsSsl : MonoBtlsObject
    {
        public Mono.Btls.MonoBtlsBio bio; // 0x20

        // ── Methods ──
        public void mono_btls_ssl_destroy(){} // RVA: 0x7FFE87716990
        public void mono_btls_ssl_new(){} // RVA: 0x7FFE87716A10
        public void mono_btls_ssl_use_certificate(){} // RVA: 0x7FFE87716A90
        public void mono_btls_ssl_use_private_key(){} // RVA: 0x7FFE87716B20
        public void mono_btls_ssl_add_chain_certificate(){} // RVA: 0x7FFE87716BB0
        public void mono_btls_ssl_accept(){} // RVA: 0x7FFE87716C40
        public void mono_btls_ssl_connect(){} // RVA: 0x7FFE87716CC0
        public void mono_btls_ssl_handshake(){} // RVA: 0x7FFE87716D40
        public void mono_btls_ssl_close(){} // RVA: 0x7FFE87716DC0
        public void mono_btls_ssl_shutdown(){} // RVA: 0x7FFE87716E40
        public void mono_btls_ssl_set_quiet_shutdown(){} // RVA: 0x7FFE87716EC0
        public void mono_btls_ssl_set_bio(){} // RVA: 0x7FFE87716F50
        public void mono_btls_ssl_read(){} // RVA: 0x7FFE87716FE0
        public void mono_btls_ssl_write(){} // RVA: 0x7FFE87717080
        public void mono_btls_ssl_get_error(){} // RVA: 0x7FFE87717120
        public void mono_btls_ssl_get_version(){} // RVA: 0x7FFE877171B0
        public void mono_btls_ssl_get_cipher(){} // RVA: 0x7FFE87717230
        public void mono_btls_ssl_get_peer_certificate(){} // RVA: 0x7FFE877172B0
        public void mono_btls_ssl_print_errors_cb(){} // RVA: 0x7FFE87717330
        public void mono_btls_ssl_set_server_name(){} // RVA: 0x7FFE877173C0
        public void mono_btls_ssl_get_server_name(){} // RVA: 0x7FFE87717450
        public void mono_btls_ssl_set_renegotiate_mode(){} // RVA: 0x7FFE877174D0
        public void mono_btls_ssl_renegotiate_pending(){} // RVA: 0x7FFE87717560
        public void Create_internal(){} // RVA: 0x7FFE877175E0
        public void .ctor(){} // RVA: 0x7FFE87717730
        public void get_Handle(){} // RVA: 0x7FFE87717A90
        public void SetBio(){} // RVA: 0x7FFE87717B10
        public void ThrowError(){} // RVA: 0x7FFE87717C30
        public void GetError(){} // RVA: 0x7FFE87717DE0
        public void SetCertificate(){} // RVA: 0x7FFE87717E60
        public void SetPrivateKey(){} // RVA: 0x7FFE87717F60
        public void AddIntermediateCertificate(){} // RVA: 0x7FFE87718060
        public void Accept(){} // RVA: 0x7FFE87718160
        public void Connect(){} // RVA: 0x7FFE87718220
        public void Handshake(){} // RVA: 0x7FFE877182E0
        public void PrintErrorsCallback(){} // RVA: 0x7FFE877183A0
        public void GetErrors(){} // RVA: 0x7FFE877184E0
        public void PrintErrors(){} // RVA: 0x7FFE87718660
        public void Read(){} // RVA: 0x7FFE877186F0
        public void Write(){} // RVA: 0x7FFE877187F0
        public void GetVersion(){} // RVA: 0x7FFE87718900
        public void GetCipher(){} // RVA: 0x7FFE877189A0
        public void GetPeerCertificate(){} // RVA: 0x7FFE87718A90
        public void SetServerName(){} // RVA: 0x7FFE87718C20
        public void GetServerName(){} // RVA: 0x7FFE87718E10
        public void Shutdown(){} // RVA: 0x7FFE87718F20
        public void SetQuietShutdown(){} // RVA: 0x7FFE87718FF0
        public void Close(){} // RVA: 0x7FFE87719090
        public void SetRenegotiateMode(){} // RVA: 0x7FFE87719160
        public void RenegotiatePending(){} // RVA: 0x7FFE87719210
    }

    public class MonoBtlsSslCtx : MonoBtlsObject
    {
        public NativeVerifyFunc verifyFunc; // 0x20
        public NativeSelectFunc selectFunc; // 0x28

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE87719340
        public void mono_btls_ssl_ctx_new(){} // RVA: 0x7FFE877193C0
        public void mono_btls_ssl_ctx_free(){} // RVA: 0x7FFE87719430
        public void mono_btls_ssl_ctx_initialize(){} // RVA: 0x7FFE877194B0
        public void mono_btls_ssl_ctx_set_cert_verify_callback(){} // RVA: 0x7FFE87719540
        public void mono_btls_ssl_ctx_set_cert_select_callback(){} // RVA: 0x7FFE877195E0
        public void mono_btls_ssl_ctx_set_min_version(){} // RVA: 0x7FFE87719670
        public void mono_btls_ssl_ctx_set_max_version(){} // RVA: 0x7FFE87719700
        public void mono_btls_ssl_ctx_set_ciphers(){} // RVA: 0x7FFE87719790
        public void mono_btls_ssl_ctx_set_verify_param(){} // RVA: 0x7FFE87719830
        public void mono_btls_ssl_ctx_set_client_ca_list(){} // RVA: 0x7FFE877198C0
        public void mono_btls_ssl_ctx_set_server_name_callback(){} // RVA: 0x7FFE87719960
        public void .ctor(){} // RVA: 0x7FFE87719AE0 | overloaded x2
        public void get_CertificateStore(){} // RVA: 0x7FFE81176D50
        public void VerifyCallback(){} // RVA: 0x7FFE8771A270
        public void NativeVerifyCallback(){} // RVA: 0x7FFE8771A2A0
        public void NativeSelectCallback(){} // RVA: 0x7FFE8771A650
        public void CopyIssuers(){} // RVA: 0x7FFE8771A7C0
        public void SetVerifyCallback(){} // RVA: 0x7FFE8771AB60
        public void SetSelectCallback(){} // RVA: 0x7FFE8771AC80
        public void SetMinVersion(){} // RVA: 0x7FFE8771AD80
        public void SetMaxVersion(){} // RVA: 0x7FFE8771AE30
        public void SetCiphers(){} // RVA: 0x7FFE8771AEE0
        public void SetVerifyParam(){} // RVA: 0x7FFE8771B1D0
        public void SetClientCertificateIssuers(){} // RVA: 0x7FFE8771B2E0
        public void SetServerNameCallback(){} // RVA: 0x7FFE8771B970
        public void NativeServerNameCallback(){} // RVA: 0x7FFE8771BA70
        public void Close(){} // RVA: 0x7FFE8771BBA0
    }

    public class MonoBtlsStream : MobileAuthenticatedStream
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8771BD50
        public void CreateContext(){} // RVA: 0x7FFE8771BDE0
    }

    public class MonoBtlsUtils : Object
    {
        // ── Methods ──
        public void Compare(){} // RVA: 0x7FFE8771BEC0
        public void AppendEntry(){} // RVA: 0x7FFE8771BF40
        public void FormatName(){} // RVA: 0x7FFE8771C610
        public void .cctor(){} // RVA: 0x7FFE8771C780
    }

    public class MonoBtlsVerifyCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84014310
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class MonoBtlsX509 : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE8771C860
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void mono_btls_x509_up_ref(){} // RVA: 0x7FFE8771C8E0
        public void mono_btls_x509_from_data(){} // RVA: 0x7FFE8771C960
        public void mono_btls_x509_get_subject_name(){} // RVA: 0x7FFE8771CA00
        public void mono_btls_x509_get_raw_data(){} // RVA: 0x7FFE8771CA80
        public void mono_btls_x509_cmp(){} // RVA: 0x7FFE8771CB20
        public void mono_btls_x509_free(){} // RVA: 0x7FFE8771CBB0
        public void mono_btls_x509_add_explicit_trust(){} // RVA: 0x7FFE8771CC30
        public void Copy(){} // RVA: 0x7FFE8771CCC0
        public void LoadFromData(){} // RVA: 0x7FFE8771CE60
        public void GetSubjectName(){} // RVA: 0x7FFE8771D170
        public void GetSubjectNameHash(){} // RVA: 0x7FFE8771D330
        public void GetRawData(){} // RVA: 0x7FFE8771D5C0
        public void Compare(){} // RVA: 0x7FFE8771D8B0
        public void AddExplicitTrust(){} // RVA: 0x7FFE8771D980
    }

    public class MonoBtlsX509Chain : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE8771DB10
        public void mono_btls_x509_chain_new(){} // RVA: 0x7FFE8771DB90
        public void mono_btls_x509_chain_get_count(){} // RVA: 0x7FFE8771DC00
        public void mono_btls_x509_chain_get_cert(){} // RVA: 0x7FFE8771DC80
        public void mono_btls_x509_chain_add_cert(){} // RVA: 0x7FFE8771DD10
        public void mono_btls_x509_chain_up_ref(){} // RVA: 0x7FFE8771DDA0
        public void mono_btls_x509_chain_free(){} // RVA: 0x7FFE8771DE20
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE8771DFE0
        public void GetCertificate(){} // RVA: 0x7FFE8771E080
        public void AddCertificate(){} // RVA: 0x7FFE8771E270
        public void Copy(){} // RVA: 0x7FFE8771E330
    }

    public class MonoBtlsX509Lookup : MonoBtlsObject
    {
        public Mono.Btls.MonoBtlsX509Store store; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE8771E550
        public void mono_btls_x509_lookup_new(){} // RVA: 0x7FFE8771E5D0
        public void mono_btls_x509_lookup_add_dir(){} // RVA: 0x7FFE8771E660
        public void mono_btls_x509_lookup_add_mono(){} // RVA: 0x7FFE8771E700
        public void mono_btls_x509_lookup_free(){} // RVA: 0x7FFE8771E790
        public void mono_btls_x509_lookup_peek_lookup(){} // RVA: 0x7FFE8771E810
        public void Create_internal(){} // RVA: 0x7FFE8771E890
        public void .ctor(){} // RVA: 0x7FFE8771E9F0
        public void GetNativeLookup(){} // RVA: 0x7FFE8771EC20
        public void AddDirectory(){} // RVA: 0x7FFE8771ECC0
        public void AddMono(){} // RVA: 0x7FFE8771EE70
        public void AddCertificate(){} // RVA: 0x7FFE8771F170
        public void Close(){} // RVA: 0x7FFE8771F280
    }

    public class MonoBtlsX509LookupMono : MonoBtlsObject
    {
        public System.Runtime.InteropServices.GCHandle gch; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE8771F560
        public void mono_btls_x509_lookup_mono_new(){} // RVA: 0x7FFE8771F5E0
        public void mono_btls_x509_lookup_mono_init(){} // RVA: 0x7FFE8771F650
        public void mono_btls_x509_lookup_mono_free(){} // RVA: 0x7FFE8771F6F0
        public void .ctor(){} // RVA: 0x7FFE8771F770
        public void Install(){} // RVA: 0x7FFE8771FAF0
        public void AddCertificate(){} // RVA: 0x7FFE8771FB90
        public void OnGetBySubject(){} // RVA: 0x7FFE8771FCB0 | overloaded x2
        public void Close(){} // RVA: 0x7FFE8771FFE0
    }

    public class MonoBtlsX509LookupMonoCollection : MonoBtlsX509LookupMono
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87720190
        public void Initialize(){} // RVA: 0x7FFE87720220
        public void OnGetBySubject(){} // RVA: 0x7FFE87720660
        public void Close(){} // RVA: 0x7FFE87720720
    }

    public class MonoBtlsX509Name : MonoBtlsObject
    {
        // ── Methods ──
        public void mono_btls_x509_name_hash(){} // RVA: 0x7FFE87720900
        public void mono_btls_x509_name_get_entry_count(){} // RVA: 0x7FFE87720980
        public void mono_btls_x509_name_get_entry_type(){} // RVA: 0x7FFE87720A00
        public void mono_btls_x509_name_get_entry_oid(){} // RVA: 0x7FFE87720A90
        public void mono_btls_x509_name_get_entry_oid_data(){} // RVA: 0x7FFE87720B30
        public void mono_btls_x509_name_get_entry_value(){} // RVA: 0x7FFE87720BD0
        public void mono_btls_x509_name_from_data(){} // RVA: 0x7FFE87720C70
        public void mono_btls_x509_name_free(){} // RVA: 0x7FFE87720D10
        public void get_Handle(){} // RVA: 0x7FFE87720D90
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetHash(){} // RVA: 0x7FFE87720E10
        public void GetEntryCount(){} // RVA: 0x7FFE87720EB0
        public void GetEntryType(){} // RVA: 0x7FFE87720F50
        public void GetEntryOid(){} // RVA: 0x7FFE87721040
        public void GetEntryOidData(){} // RVA: 0x7FFE877212C0
        public void GetEntryValue(){} // RVA: 0x7FFE87721430
        public void CreateFromData(){} // RVA: 0x7FFE87721640
    }

    public class MonoBtlsX509Store : MonoBtlsObject
    {
        public System.Collections.Generic.Dictionary`2<UIntPtr,Mono.Btls.MonoBtlsX509Lookup> lookupHash; // 0x20

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE87721910
        public void mono_btls_x509_store_new(){} // RVA: 0x7FFE87721990
        public void mono_btls_x509_store_from_ssl_ctx(){} // RVA: 0x7FFE87721A00
        public void mono_btls_x509_store_add_cert(){} // RVA: 0x7FFE87721A80
        public void mono_btls_x509_store_free(){} // RVA: 0x7FFE87721B10
        public void Create_internal(){} // RVA: 0x7FFE87721CB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87721F60 | overloaded x2
        public void AddCertificate(){} // RVA: 0x7FFE877220F0
        public void AddLookup(){} // RVA: 0x7FFE87722200
        public void AddDirectoryLookup(){} // RVA: 0x7FFE87722510
        public void AddCollection(){} // RVA: 0x7FFE87722560
        public void Close(){} // RVA: 0x7FFE87722670
    }

    public class MonoBtlsX509StoreCtx : MonoBtlsObject
    {
        public System.Nullable`1<int> verifyResult; // 0x20
        public object field_1; // 0x7D

        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE87722A10
        public void mono_btls_x509_store_ctx_new(){} // RVA: 0x7FFE87722A90
        public void mono_btls_x509_store_ctx_from_ptr(){} // RVA: 0x7FFE87722B00
        public void mono_btls_x509_store_ctx_get_error(){} // RVA: 0x7FFE87722B80
        public void mono_btls_x509_store_ctx_get_chain(){} // RVA: 0x7FFE87722C10
        public void mono_btls_x509_store_ctx_init(){} // RVA: 0x7FFE87722C90
        public void mono_btls_x509_store_ctx_set_param(){} // RVA: 0x7FFE87722D30
        public void mono_btls_x509_store_ctx_verify_cert(){} // RVA: 0x7FFE87722DC0
        public void mono_btls_x509_store_ctx_get_untrusted(){} // RVA: 0x7FFE87722E40
        public void mono_btls_x509_store_ctx_up_ref(){} // RVA: 0x7FFE87722EC0
        public void mono_btls_x509_store_ctx_free(){} // RVA: 0x7FFE87722F40
        public void .ctor(){} // RVA: 0x7FFE87723400 | overloaded x3
        public void Create_internal(){} // RVA: 0x7FFE87723100
        public void GetError(){} // RVA: 0x7FFE87723460
        public void GetChain(){} // RVA: 0x7FFE87723510
        public void GetUntrusted(){} // RVA: 0x7FFE877236B0
        public void Initialize(){} // RVA: 0x7FFE87723850
        public void SetVerifyParam(){} // RVA: 0x7FFE87723990
        public void get_VerifyResult(){} // RVA: 0x7FFE87723AA0
        public void Verify(){} // RVA: 0x7FFE87723B30
        public void Copy(){} // RVA: 0x7FFE87723C30
    }

    public class MonoBtlsX509StoreManager : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE87723E80
        public void DoInitialize(){} // RVA: 0x7FFE87723F80
        public void GetStorePath(){} // RVA: 0x7FFE87724680
    }

    public class MonoBtlsX509VerifyParam : MonoBtlsObject
    {
        // ── Methods ──
        public void get_Handle(){} // RVA: 0x7FFE877247C0
        public void mono_btls_x509_verify_param_copy(){} // RVA: 0x7FFE87724840
        public void mono_btls_x509_verify_param_lookup(){} // RVA: 0x7FFE877248C0
        public void mono_btls_x509_verify_param_can_modify(){} // RVA: 0x7FFE87724940
        public void mono_btls_x509_verify_param_set_host(){} // RVA: 0x7FFE877249C0
        public void mono_btls_x509_verify_param_set_time(){} // RVA: 0x7FFE87724A60
        public void mono_btls_x509_verify_param_free(){} // RVA: 0x7FFE87724AF0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Copy(){} // RVA: 0x7FFE87724B70
        public void GetSslClient(){} // RVA: 0x7FFE87724D10
        public void GetSslServer(){} // RVA: 0x7FFE87724D50
        public void Lookup(){} // RVA: 0x7FFE87724D90
        public void get_CanModify(){} // RVA: 0x7FFE87725080
        public void WantToModify(){} // RVA: 0x7FFE87725120
        public void SetHost(){} // RVA: 0x7FFE87725210
        public void SetTime(){} // RVA: 0x7FFE877253D0
    }

    public class X509CertificateImplBtls : X509Certificate2ImplUnix
    {
        public Mono.Btls.MonoBtlsX509 x509; // 0xB0
        public Mono.Btls.MonoBtlsKey nativePrivateKey; // 0xB8
        public System.Security.Cryptography.X509Certificates.X509CertificateImplCollection intermediateCerts; // 0xC0
        public object field_3; // 0x81
        public object field_4; // 0x82
        public object field_5; // 0x83

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87725AA0 | overloaded x4
        public void get_IsValid(){} // RVA: 0x7FFE87725C40
        public void get_X509(){} // RVA: 0x7FFE87725C90
        public void get_NativePrivateKey(){} // RVA: 0x7FFE87725CE0
        public void Clone(){} // RVA: 0x7FFE87725D30
        public void GetRawCertData(){} // RVA: 0x7FFE87725DD0
        public void get_IntermediateCertificates(){} // RVA: 0x7FFE81166120
        public void Dispose(){} // RVA: 0x7FFE87725E80
        public void get_HasPrivateKey(){} // RVA: 0x7FFE874D9180
        public void get_PrivateKey(){} // RVA: 0x7FFE87725F60
        public void set_PrivateKey(){} // RVA: 0x7FFE87725FA0
        public void GetRSAPrivateKey(){} // RVA: 0x7FFE87725F60
        public void GetDSAPrivateKey(){} // RVA: 0x7FFE87726110
        public void Import(){} // RVA: 0x7FFE87726150
        public void ImportPkcs12(){} // RVA: 0x7FFE87726210
        public void ImportAuthenticode(){} // RVA: 0x7FFE87726980
        public void Verify(){} // RVA: 0x7FFE87726A20
    }

    public class X509ChainImplBtls : X509ChainImpl
    {
        public Mono.Btls.MonoBtlsX509StoreCtx storeCtx; // 0x10
        public Mono.Btls.MonoBtlsX509Chain chain; // 0x18
        public Mono.Btls.MonoBtlsX509Chain untrustedChain; // 0x20
        public System.Security.Cryptography.X509Certificates.X509ChainElementCollection elements; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87726F70 | overloaded x2
        public void get_IsValid(){} // RVA: 0x7FFE877278B0
        public void get_StoreCtx(){} // RVA: 0x7FFE877278F0
        public void get_ChainElements(){} // RVA: 0x7FFE87727940
        public void get_ChainPolicy(){} // RVA: 0x7FFE81178740
        public void AddStatus(){} // RVA: 0x7FFE87727D30
        public void Build(){} // RVA: 0x7FFE810FB320
        public void Reset(){} // RVA: 0x7FFE87727EC0
        public void Dispose(){} // RVA: 0x7FFE87728020
    }

    public class X509PalImplBtls : X509PalImpl
    {
        public Mono.Btls.MonoBtlsProvider _provider; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87728310
        public void get_Provider(){} // RVA: 0x7FFE81116380
        public void Import(){} // RVA: 0x7FFE87728490 | overloaded x3
    }

}