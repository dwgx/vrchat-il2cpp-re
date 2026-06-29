// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 6
// Methods: 17

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class HandshakeType : Object
    {
        public object hello_request;
        public object client_hello;
        public object server_hello;
        public object certificate;
        public object server_key_exchange;
        public object certificate_request;
        public object server_hello_done;
        public object certificate_verify;
        public object client_key_exchange;
        public object finished;
        public object certificate_url;
        public object certificate_status;
        public object hello_verify_request;
        public object supplemental_data;
        public object session_ticket;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HashAlgorithm : Object
    {
        public object none;
        public object md5;
        public object sha1;
        public object sha224;
        public object sha256;
        public object sha384;
        public object sha512;

        // ── Methods ──
        public void GetName(){} // RVA: 0xA1CFB70
        public void GetText(){} // RVA: 0xA1CFCC0
        public void IsPrivate(){} // RVA: 0xA1CFE50
        public void IsRecognized(){} // RVA: 0xA1CFE60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HeartbeatExtension : Object
    {
        public object mMode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1CFE70
        public void get_Mode(){} // RVA: 0xC120A0
        public void Encode(){} // RVA: 0xA1CFF00
        public void Parse(){} // RVA: 0xA1CFF80
    }

    public class HeartbeatMessage : Object
    {
        public object mType;
        public object mPayload;
        public object mPaddingLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1D0090
        public void Encode(){} // RVA: 0xA1D0200
        public void Parse(){} // RVA: 0xA1D03D0
    }

    public class HeartbeatMessageType : Object
    {
        public object heartbeat_request;
        public object heartbeat_response;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xA1CFA40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HeartbeatMode : Object
    {
        public object peer_allowed_to_send;
        public object peer_not_allowed_to_send;

        // ── Methods ──
        public void IsValid(){} // RVA: 0xA1CFA40
        public void .ctor(){} // RVA: 0xB43310
    }

}