// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
// Classes: 7
// Methods: 63

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
{
    public class JPakeParticipant : Object
    {
        public int State;
        public int STATE_ROUND_1_CREATED; // 0x4
        public int STATE_ROUND_1_VALIDATED; // 0x8
        public int STATE_ROUND_2_CREATED; // 0xC
        public int STATE_ROUND_2_VALIDATED; // 0x10
        public int STATE_KEY_CALCULATED; // 0x14
        public int STATE_ROUND_3_CREATED; // 0x18
        public int STATE_ROUND_3_VALIDATED; // 0x1C
        public string participantId; // 0x10
        public char[] password; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest digest; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x40
        public string partnerParticipantId; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x1; // 0x50
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger x2; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger gx1; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger gx2; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger gx3; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger gx4; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger b; // 0x80
        public int state; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC91780 | overloaded x3
        public void get_State(){} // RVA: 0x7FFAC37EE8C0
        public void CreateRound1PayloadToSend(){} // RVA: 0x7FFACBC91DE0
        public void ValidateRound1PayloadReceived(){} // RVA: 0x7FFACBC922B0
        public void CreateRound2PayloadToSend(){} // RVA: 0x7FFACBC927C0
        public void ValidateRound2PayloadReceived(){} // RVA: 0x7FFACBC92B10
        public void CalculateKeyingMaterial(){} // RVA: 0x7FFACBC92F10
        public void CreateRound3PayloadToSend(){} // RVA: 0x7FFACBC933A0
        public void ValidateRound3PayloadReceived(){} // RVA: 0x7FFACBC936A0
        public void .cctor(){} // RVA: 0x7FFACBC93B50
    }

    public class JPakePrimeOrderGroup : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger P; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger G; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC93C50 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAC2F3C380
        public void get_Q(){} // RVA: 0x7FFAC2F247C0
        public void get_G(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class JPakePrimeOrderGroups : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake.JPakePrimeOrderGroup SUN_JCE_1024;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake.JPakePrimeOrderGroup NIST_2048; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake.JPakePrimeOrderGroup NIST_3072; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC94210
    }

    public class JPakeRound1Payload : Object
    {
        public string ParticipantId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Gx1; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Gx2; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] KnowledgeProofForX1; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] KnowledgeProofForX2; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC94650
        public void get_ParticipantId(){} // RVA: 0x7FFAC2F3C380
        public void get_Gx1(){} // RVA: 0x7FFAC2F247C0
        public void get_Gx2(){} // RVA: 0x7FFAC2F4F0C0
        public void get_KnowledgeProofForX1(){} // RVA: 0x7FFACBC94C10
        public void get_KnowledgeProofForX2(){} // RVA: 0x7FFACBC94D50
    }

    public class JPakeRound2Payload : Object
    {
        public string ParticipantId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger A; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] KnowledgeProofForX2s; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC94E90
        public void get_ParticipantId(){} // RVA: 0x7FFAC2F3C380
        public void get_A(){} // RVA: 0x7FFAC2F247C0
        public void get_KnowledgeProofForX2s(){} // RVA: 0x7FFACBC95140
    }

    public class JPakeRound3Payload : Object
    {
        public string ParticipantId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger MacTag; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_ParticipantId(){} // RVA: 0x7FFAC2F3C380
        public void get_MacTag(){} // RVA: 0x7FFAC2F247C0
    }

    public class JPakeUtilities : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Zero;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger One; // 0x8

        // ── Methods ──
        public void GenerateX1(){} // RVA: 0x7FFACBC95280
        public void GenerateX2(){} // RVA: 0x7FFACBC95320
        public void CalculateS(){} // RVA: 0x7FFACBC953C0
        public void CalculateGx(){} // RVA: 0x7FFACBBDC780
        public void CalculateGA(){} // RVA: 0x7FFACBC95460
        public void CalculateX2s(){} // RVA: 0x7FFACBC95530
        public void CalculateA(){} // RVA: 0x7FFACBC955F0
        public void CalculateZeroKnowledgeProof(){} // RVA: 0x7FFACBC95620
        public void CalculateHashForZeroKnowledgeProof(){} // RVA: 0x7FFACBC95880
        public void ValidateGx4(){} // RVA: 0x7FFACBC95BA0
        public void ValidateGa(){} // RVA: 0x7FFACBC95C70
        public void ValidateZeroKnowledgeProof(){} // RVA: 0x7FFACBC95D40
        public void CalculateKeyingMaterial(){} // RVA: 0x7FFACBC95F80
        public void ValidateParticipantIdsDiffer(){} // RVA: 0x7FFACBC960C0
        public void ValidateParticipantIdsEqual(){} // RVA: 0x7FFACBC96180
        public void ValidateNotNull(){} // RVA: 0x7FFACBC962E0
        public void CalculateMacTag(){} // RVA: 0x7FFACBC96340
        public void CalculateMacKey(){} // RVA: 0x7FFACBC96620
        public void ValidateMacTag(){} // RVA: 0x7FFACBC96950
        public void UpdateDigest(){} // RVA: 0x7FFACBC96CB0 | overloaded x3
        public void UpdateDigestIncludingSize(){} // RVA: 0x7FFACBC96E80 | overloaded x3
        public void UpdateMac(){} // RVA: 0x7FFACBC971D0 | overloaded x3
        public void IntToByteArray(){} // RVA: 0x7FFACBC97290
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC972A0
    }

}