// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
// Classes: 7
// Methods: 63

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
{
    public class JPakeParticipant : Object
    {
        public int STATE_INITIALIZED;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0EADA0 | overloaded x3
        public void get_State(){} // RVA: 0x7FFE8194AD00
        public void CreateRound1PayloadToSend(){} // RVA: 0x7FFE8A0EB400
        public void ValidateRound1PayloadReceived(){} // RVA: 0x7FFE8A0EB8D0
        public void CreateRound2PayloadToSend(){} // RVA: 0x7FFE8A0EBDE0
        public void ValidateRound2PayloadReceived(){} // RVA: 0x7FFE8A0EC130
        public void CalculateKeyingMaterial(){} // RVA: 0x7FFE8A0EC530
        public void CreateRound3PayloadToSend(){} // RVA: 0x7FFE8A0EC9C0
        public void ValidateRound3PayloadReceived(){} // RVA: 0x7FFE8A0ECCC0
        public void .cctor(){} // RVA: 0x7FFE8A0ED170
    }

    public class JPakePrimeOrderGroup : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger p; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger g; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0ED270 | overloaded x2
        public void get_P(){} // RVA: 0x7FFE81116380
        public void get_Q(){} // RVA: 0x7FFE810FE7C0
        public void get_G(){} // RVA: 0x7FFE811290C0
    }

    public class JPakePrimeOrderGroups : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A0ED830
    }

    public class JPakeRound1Payload : Object
    {
        public string participantId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger gx1; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger gx2; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX1; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX2; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0EDC70
        public void get_ParticipantId(){} // RVA: 0x7FFE81116380
        public void get_Gx1(){} // RVA: 0x7FFE810FE7C0
        public void get_Gx2(){} // RVA: 0x7FFE811290C0
        public void get_KnowledgeProofForX1(){} // RVA: 0x7FFE8A0EE230
        public void get_KnowledgeProofForX2(){} // RVA: 0x7FFE8A0EE370
    }

    public class JPakeRound2Payload : Object
    {
        public string participantId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger a; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] knowledgeProofForX2s; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0EE4B0
        public void get_ParticipantId(){} // RVA: 0x7FFE81116380
        public void get_A(){} // RVA: 0x7FFE810FE7C0
        public void get_KnowledgeProofForX2s(){} // RVA: 0x7FFE8A0EE760
    }

    public class JPakeRound3Payload : Object
    {
        public string participantId; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger macTag; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_ParticipantId(){} // RVA: 0x7FFE81116380
        public void get_MacTag(){} // RVA: 0x7FFE810FE7C0
    }

    public class JPakeUtilities : Object
    {
        // ── Methods ──
        public void GenerateX1(){} // RVA: 0x7FFE8A0EE8A0
        public void GenerateX2(){} // RVA: 0x7FFE8A0EE940
        public void CalculateS(){} // RVA: 0x7FFE8A0EE9E0
        public void CalculateGx(){} // RVA: 0x7FFE8A035DA0
        public void CalculateGA(){} // RVA: 0x7FFE8A0EEA80
        public void CalculateX2s(){} // RVA: 0x7FFE8A0EEB50
        public void CalculateA(){} // RVA: 0x7FFE8A0EEC10
        public void CalculateZeroKnowledgeProof(){} // RVA: 0x7FFE8A0EEC40
        public void CalculateHashForZeroKnowledgeProof(){} // RVA: 0x7FFE8A0EEEA0
        public void ValidateGx4(){} // RVA: 0x7FFE8A0EF1C0
        public void ValidateGa(){} // RVA: 0x7FFE8A0EF290
        public void ValidateZeroKnowledgeProof(){} // RVA: 0x7FFE8A0EF360
        public void CalculateKeyingMaterial(){} // RVA: 0x7FFE8A0EF5A0
        public void ValidateParticipantIdsDiffer(){} // RVA: 0x7FFE8A0EF6E0
        public void ValidateParticipantIdsEqual(){} // RVA: 0x7FFE8A0EF7A0
        public void ValidateNotNull(){} // RVA: 0x7FFE8A0EF900
        public void CalculateMacTag(){} // RVA: 0x7FFE8A0EF960
        public void CalculateMacKey(){} // RVA: 0x7FFE8A0EFC40
        public void ValidateMacTag(){} // RVA: 0x7FFE8A0EFF70
        public void UpdateDigest(){} // RVA: 0x7FFE8A0F02D0 | overloaded x3
        public void UpdateDigestIncludingSize(){} // RVA: 0x7FFE8A0F04A0 | overloaded x3
        public void UpdateMac(){} // RVA: 0x7FFE8A0F07F0 | overloaded x3
        public void IntToByteArray(){} // RVA: 0x7FFE8A0F08B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A0F08C0
    }

}