// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 17
// Methods: 108

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class SecurityParameters : Object
    {
        public object entity;
        public object cipherSuite;
        public object compressionAlgorithm;
        public object prfAlgorithm;
        public object verifyDataLength;
        public object masterSecret;
        public object clientRandom;
        public object serverRandom;
        public object sessionHash;
        public object pskIdentity;
        public object srpIdentity;
        public object maxFragmentLength;
        public object truncatedHMac;
        public object encryptThenMac;
        public object extendedMasterSecret;

        // ── Methods ──
        public void Clear(){} // RVA: 0xA1D4CD0
        public void get_Entity(){} // RVA: 0xB8F8F0
        public void get_CipherSuite(){} // RVA: 0x116A650
        public void get_CompressionAlgorithm(){} // RVA: 0xB5DD50
        public void get_PrfAlgorithm(){} // RVA: 0x2244FB0
        public void get_VerifyDataLength(){} // RVA: 0xFEAE90
        public void get_MasterSecret(){} // RVA: 0xB70160
        public void get_ClientRandom(){} // RVA: 0xD33E60
        public void get_ServerRandom(){} // RVA: 0xD05CA0
        public void get_SessionHash(){} // RVA: 0xBC1B30
        public void get_PskIdentity(){} // RVA: 0xBBF8F0
        public void get_SrpIdentity(){} // RVA: 0xBE58B0
        public void get_IsExtendedMasterSecret(){} // RVA: 0xBE2B30
        public void .ctor(){} // RVA: 0xA1D4DB0
    }

    public class ServerName : Object
    {
        public object mNameType;
        public object mName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D4DD0
        public void get_NameType(){} // RVA: 0xC120A0
        public void get_Name(){} // RVA: 0xB465B0
        public void GetHostName(){} // RVA: 0xA1D4F20
        public void Encode(){} // RVA: 0xA1D4FC0
        public void Parse(){} // RVA: 0xA1D5150
        public void IsCorrectType(){} // RVA: 0xA1D5330
    }

    public class ServerNameList : Object
    {
        public object mServerNameList;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D53D0
        public void get_ServerNames(){} // RVA: 0xB5DBF0
        public void Encode(){} // RVA: 0xA1D5480
        public void Parse(){} // RVA: 0xA1D5830
        public void CheckNameType(){} // RVA: 0xA1D5BE0
    }

    public class ServerName[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ServerOnlyTlsAuthentication : Object
    {
        // ── Methods ──
        public void NotifyServerCertificate(){} // RVA: 0x894320
        public void GetClientCredentials(){} // RVA: 0xDAC980
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ServerSrpParams : Object
    {
        public object m_N;
        public object m_g;
        public object m_B;
        public object m_s;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D5CB0
        public void get_B(){} // RVA: 0xB700F0
        public void get_G(){} // RVA: 0xB465B0
        public void get_N(){} // RVA: 0xB5DBF0
        public void get_S(){} // RVA: 0xB70160
        public void Encode(){} // RVA: 0xA1D5ED0
        public void Parse(){} // RVA: 0xA1D60E0
    }

    public class SessionParameters : Object
    {
        public object mCipherSuite;
        public object mCompressionAlgorithm;
        public object mMasterSecret;
        public object mPeerCertificate;
        public object mPskIdentity;
        public object mSrpIdentity;
        public object mEncodedServerExtensions;
        public object mExtendedMasterSecret;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D61D0
        public void Clear(){} // RVA: 0xA1D6520
        public void Copy(){} // RVA: 0xA1D65A0
        public void get_CipherSuite(){} // RVA: 0xB8F8F0
        public void get_CompressionAlgorithm(){} // RVA: 0xC9C250
        public void get_IsExtendedMasterSecret(){} // RVA: 0xC02470
        public void get_MasterSecret(){} // RVA: 0xB465B0
        public void get_PeerCertificate(){} // RVA: 0xB700F0
        public void get_PskIdentity(){} // RVA: 0xB70160
        public void get_SrpIdentity(){} // RVA: 0xD33E60
        public void ReadServerExtensions(){} // RVA: 0xA1D6670
    }

    public class SignatureAlgorithm : Object
    {
        public object anonymous;
        public object rsa;
        public object dsa;
        public object ecdsa;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SignatureAndHashAlgorithm : Object
    {
        public object mHash;
        public object mSignature;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D6B00
        public void get_Hash(){} // RVA: 0xC120A0
        public void get_Signature(){} // RVA: 0xDD5C50
        public void Equals(){} // RVA: 0xA1D6BE0
        public void GetHashCode(){} // RVA: 0xA1D6D20
        public void Encode(){} // RVA: 0xA1D6D70
        public void Parse(){} // RVA: 0xA1D6E40
    }

    public class SignerInputBuffer : MemoryStream
    {
        // ── Methods ──
        public void UpdateSigner(){} // RVA: 0xA1D6F90
        public void .ctor(){} // RVA: 0xA1C37E0
    }

    public class SimulatedTlsSrpIdentityManager : Object
    {
        public object PREFIX_PASSWORD;
        public object PREFIX_SALT;
        public object mGroup;
        public object mVerifierGenerator;
        public object mMac;

        // ── Methods ──
        public void GetRfc5054Default(){} // RVA: 0xA1D7180
        public void .ctor(){} // RVA: 0xC27FD0
        public void GetLoginParameters(){} // RVA: 0xA1D73F0
        public void .cctor(){} // RVA: 0xA1D7790
    }

    public class SrpTlsClient : AbstractTlsClient
    {
        public object mGroupVerifier;
        public object mIdentity;
        public object mPassword;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D7A40
        public void get_RequireSrpServerExtension(){} // RVA: 0xB43320
        public void GetCipherSuites(){} // RVA: 0xA1D7CC0
        public void GetClientExtensions(){} // RVA: 0xA1D7D20
        public void ProcessServerExtensions(){} // RVA: 0xA1D7F30
        public void GetKeyExchange(){} // RVA: 0xA1D8150
        public void GetAuthentication(){} // RVA: 0xA1D8210
        public void CreateSrpKeyExchange(){} // RVA: 0xA1D8260
    }

    public class SrpTlsServer : AbstractTlsServer
    {
        public object mSrpIdentityManager;
        public object mSrpIdentity;
        public object mLoginParameters;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D2B90
        public void GetDsaSignerCredentials(){} // RVA: 0xA1D8400
        public void GetRsaSignerCredentials(){} // RVA: 0xA1D8450
        public void GetCipherSuites(){} // RVA: 0xA1D84A0
        public void ProcessClientExtensions(){} // RVA: 0xA1D8510
        public void GetSelectedCipherSuite(){} // RVA: 0xA1D86F0
        public void GetCredentials(){} // RVA: 0xA1D88A0
        public void GetKeyExchange(){} // RVA: 0xA1D8990
        public void CreateSrpKeyExchange(){} // RVA: 0xA1D8A50
    }

    public class SrtpProtectionProfile : Object
    {
        public object SRTP_AES128_CM_HMAC_SHA1_80;
        public object SRTP_AES128_CM_HMAC_SHA1_32;
        public object SRTP_NULL_HMAC_SHA1_80;
        public object SRTP_NULL_HMAC_SHA1_32;
        public object SRTP_AEAD_AES_128_GCM;
        public object SRTP_AEAD_AES_256_GCM;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Ssl3Mac : Object
    {
        public object IPAD_BYTE;
        public object OPAD_BYTE;
        public object IPAD;
        public object OPAD;
        public object digest;
        public object padLength;
        public object secret;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D8AF0
        public void get_AlgorithmName(){} // RVA: 0xA1D8BB0
        public void Init(){} // RVA: 0xA1D8C20
        public void GetMacSize(){} // RVA: 0xA1D8DB0
        public void Update(){} // RVA: 0xA1D8E00
        public void BlockUpdate(){} // RVA: 0xA1D8E60
        public void DoFinal(){} // RVA: 0xA1D8EF0
        public void Reset(){} // RVA: 0xA1D90D0
        public void GenPad(){} // RVA: 0xA1D91E0
        public void .cctor(){} // RVA: 0xA1D9290
    }

    public class SupplementalDataEntry : Object
    {
        public object mDataType;
        public object mData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
        public void get_DataType(){} // RVA: 0xB8F8F0
        public void get_Data(){} // RVA: 0xB465B0
    }

    public class SupplementalDataType : Object
    {
        public object user_mapping_data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

}