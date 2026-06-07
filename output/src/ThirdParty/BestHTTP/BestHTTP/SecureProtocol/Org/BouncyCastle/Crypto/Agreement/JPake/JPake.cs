// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
// Classes: 7
// Methods: 63

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
{
    public class JPakeParticipant
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96889C0 | overloaded x3
        public void get_State(){} // RVA: 0xBB90C0
        public void CreateRound1PayloadToSend(){} // RVA: 0x9689020
        public void ValidateRound1PayloadReceived(){} // RVA: 0x96894F0
        public void CreateRound2PayloadToSend(){} // RVA: 0x9689A00
        public void ValidateRound2PayloadReceived(){} // RVA: 0x9689D50
        public void CalculateKeyingMaterial(){} // RVA: 0x968A150
        public void CreateRound3PayloadToSend(){} // RVA: 0x968A5E0
        public void ValidateRound3PayloadReceived(){} // RVA: 0x968A8E0
        public void .cctor(){} // RVA: 0x968AD90
    }

    public class JPakePrimeOrderGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968AE90 | overloaded x2
        public void get_P(){} // RVA: 0x2F8380
        public void get_Q(){} // RVA: 0x2E07C0
        public void get_G(){} // RVA: 0x30B0C0
    }

    public class JPakePrimeOrderGroups
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x968B450
    }

    public class JPakeRound1Payload
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968B890
        public void get_ParticipantId(){} // RVA: 0x2F8380
        public void get_Gx1(){} // RVA: 0x2E07C0
        public void get_Gx2(){} // RVA: 0x30B0C0
        public void get_KnowledgeProofForX1(){} // RVA: 0x968BE50
        public void get_KnowledgeProofForX2(){} // RVA: 0x968BF90
    }

    public class JPakeRound2Payload
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x968C0D0
        public void get_ParticipantId(){} // RVA: 0x2F8380
        public void get_A(){} // RVA: 0x2E07C0
        public void get_KnowledgeProofForX2s(){} // RVA: 0x968C380
    }

    public class JPakeRound3Payload
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_ParticipantId(){} // RVA: 0x2F8380
        public void get_MacTag(){} // RVA: 0x2E07C0
    }

    public class JPakeUtilities
    {
        // ── Methods ──
        public void GenerateX1(){} // RVA: 0x968C4C0
        public void GenerateX2(){} // RVA: 0x968C560
        public void CalculateS(){} // RVA: 0x968C600
        public void CalculateGx(){} // RVA: 0x95D39C0
        public void CalculateGA(){} // RVA: 0x968C6A0
        public void CalculateX2s(){} // RVA: 0x968C770
        public void CalculateA(){} // RVA: 0x968C830
        public void CalculateZeroKnowledgeProof(){} // RVA: 0x968C860
        public void CalculateHashForZeroKnowledgeProof(){} // RVA: 0x968CAC0
        public void ValidateGx4(){} // RVA: 0x968CDE0
        public void ValidateGa(){} // RVA: 0x968CEB0
        public void ValidateZeroKnowledgeProof(){} // RVA: 0x968CF80
        public void CalculateKeyingMaterial(){} // RVA: 0x968D1C0
        public void ValidateParticipantIdsDiffer(){} // RVA: 0x968D300
        public void ValidateParticipantIdsEqual(){} // RVA: 0x968D3C0
        public void ValidateNotNull(){} // RVA: 0x968D520
        public void CalculateMacTag(){} // RVA: 0x968D580
        public void CalculateMacKey(){} // RVA: 0x968D860
        public void ValidateMacTag(){} // RVA: 0x968DB90
        public void UpdateDigest(){} // RVA: 0x968DEF0 | overloaded x3
        public void UpdateDigestIncludingSize(){} // RVA: 0x968E0C0 | overloaded x3
        public void UpdateMac(){} // RVA: 0x968E410 | overloaded x3
        public void IntToByteArray(){} // RVA: 0x968E4D0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x968E4E0
    }

}