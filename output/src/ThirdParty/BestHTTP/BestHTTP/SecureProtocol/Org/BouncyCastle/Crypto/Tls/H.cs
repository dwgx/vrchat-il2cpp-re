// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 6
// Methods: 17

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class HandshakeType : Object
    {
        public byte hello_request;
        public byte client_hello;
        public byte server_hello;
        public byte certificate;
        public byte server_key_exchange;
        public byte certificate_request;
        public byte server_hello_done;
        public byte certificate_verify;
        public byte client_key_exchange;
        public byte finished;
        public byte certificate_url;
        public byte certificate_status;
        public byte hello_verify_request;
        public byte supplemental_data;
        public byte session_ticket;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HashAlgorithm : Object
    {
        public byte none;
        public byte md5;
        public byte sha1;
        public byte sha224;
        public byte sha256;
        public byte sha384;
        public byte sha512;

        // ── Methods ──
        public void GetName(){} // RVA: 0x7FFACBB36D10
        public void GetText(){} // RVA: 0x7FFACBB36E60
        public void IsPrivate(){} // RVA: 0x7FFACBB36FF0
        public void IsRecognized(){} // RVA: 0x7FFACBB37000
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HeartbeatExtension : Object
    {
        public byte Mode; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB37010
        public void get_Mode(){} // RVA: 0x7FFAC2FEB5E0
        public void Encode(){} // RVA: 0x7FFACBB370A0
        public void Parse(){} // RVA: 0x7FFACBB37120
    }

    public class HeartbeatMessage : Object
    {
        public byte mType; // 0x10
        public byte[] mPayload; // 0x18
        public int mPaddingLength; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBB37230
        public void Encode(){} // RVA: 0x7FFACBB373A0
        public void Parse(){} // RVA: 0x7FFACBB37570
    }

    public class HeartbeatMessageType : Object
    {
        public byte heartbeat_request;
        public byte heartbeat_response;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFACBB36BE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HeartbeatMode : Object
    {
        public byte peer_allowed_to_send;
        public byte peer_not_allowed_to_send;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFACBB36BE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}