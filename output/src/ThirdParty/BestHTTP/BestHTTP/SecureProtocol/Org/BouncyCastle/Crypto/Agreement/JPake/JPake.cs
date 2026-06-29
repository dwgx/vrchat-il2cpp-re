// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
// Classes: 7
// Methods: 54

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
{
    public class JPakeParticipant : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C1CB0
        public void get_State(){} // RVA: 0x7A897F560
        public void CreateRound1PayloadToSend(){} // RVA: 0x7B14C2320
        public void ValidateRound1PayloadReceived(){} // RVA: 0x7B14C27D0
        public void CreateRound2PayloadToSend(){} // RVA: 0x7B14C2CD0
        public void ValidateRound2PayloadReceived(){} // RVA: 0x7B14C3020
        public void CalculateKeyingMaterial(){} // RVA: 0x7B14C3410
        public void CreateRound3PayloadToSend(){} // RVA: 0x7B14C38A0
        public void ValidateRound3PayloadReceived(){} // RVA: 0x7B14C3BC0
        public void .cctor(){} // RVA: 0x7B14C4070
    }

    public class JPakePrimeOrderGroup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C4170
        public void get_P(){} // RVA: 0x7A80F2570
        public void get_Q(){} // RVA: 0x7A80DA7B0
        public void get_G(){} // RVA: 0x7A81052C0
    }

    public class JPakePrimeOrderGroups : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B14C4730
    }

    public class JPakeRound1Payload : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C4B80
        public void get_ParticipantId(){} // RVA: 0x7A80F2570
        public void get_Gx1(){} // RVA: 0x7A80DA7B0
        public void get_Gx2(){} // RVA: 0x7A81052C0
        public void get_KnowledgeProofForX1(){} // RVA: 0x7B14C5140
        public void get_KnowledgeProofForX2(){} // RVA: 0x7B14C5280
    }

    public class JPakeRound2Payload : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14C53C0
        public void get_ParticipantId(){} // RVA: 0x7A80F2570
        public void get_A(){} // RVA: 0x7A80DA7B0
        public void get_KnowledgeProofForX2s(){} // RVA: 0x7B14C5680
    }

    public class JPakeRound3Payload : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void get_ParticipantId(){} // RVA: 0x7A80F2570
        public void get_MacTag(){} // RVA: 0x7A80DA7B0
    }

    public class JPakeUtilities : Object
    {
        // ── Methods ──
        public void GenerateX1(){} // RVA: 0x7B14C57C0
        public void GenerateX2(){} // RVA: 0x7B14C5860
        public void CalculateS(){} // RVA: 0x7B14C5900
        public void CalculateGx(){} // RVA: 0x7B140ADD0
        public void CalculateGA(){} // RVA: 0x7B14C59A0
        public void CalculateX2s(){} // RVA: 0x7B14C5A70
        public void CalculateA(){} // RVA: 0x7B14C5B30
        public void CalculateZeroKnowledgeProof(){} // RVA: 0x7B14C5B60
        public void CalculateHashForZeroKnowledgeProof(){} // RVA: 0x7B14C5DC0
        public void ValidateGx4(){} // RVA: 0x7B14C60E0
        public void ValidateGa(){} // RVA: 0x7B14C61B0
        public void ValidateZeroKnowledgeProof(){} // RVA: 0x7B14C6280
        public void CalculateKeyingMaterial(){} // RVA: 0x7B14C64C0
        public void ValidateParticipantIdsDiffer(){} // RVA: 0x7B14C6600
        public void ValidateParticipantIdsEqual(){} // RVA: 0x7B14C66C0
        public void ValidateNotNull(){} // RVA: 0x7B14C6820
        public void CalculateMacTag(){} // RVA: 0x7B14C6880
        public void CalculateMacKey(){} // RVA: 0x7B14C6B60
        public void ValidateMacTag(){} // RVA: 0x7B14C6EA0
        public void UpdateDigest(){} // RVA: 0x7B14C7200
        public void UpdateDigestIncludingSize(){} // RVA: 0x7B14C73D0
        public void UpdateMac(){} // RVA: 0x7B14C7720
        public void IntToByteArray(){} // RVA: 0x7B14C77E0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B14C77F0
    }

}