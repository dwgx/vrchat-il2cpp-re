// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
// Classes: 7
// Methods: 63

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
{
    public class JPakeParticipant
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1389C0 | overloaded x3
        public void get_State(){} // RVA: 0x7FFAF36690C0
        public void CreateRound1PayloadToSend(){} // RVA: 0x7FFAFC139020
        public void ValidateRound1PayloadReceived(){} // RVA: 0x7FFAFC1394F0
        public void CreateRound2PayloadToSend(){} // RVA: 0x7FFAFC139A00
        public void ValidateRound2PayloadReceived(){} // RVA: 0x7FFAFC139D50
        public void CalculateKeyingMaterial(){} // RVA: 0x7FFAFC13A150
        public void CreateRound3PayloadToSend(){} // RVA: 0x7FFAFC13A5E0
        public void ValidateRound3PayloadReceived(){} // RVA: 0x7FFAFC13A8E0
        public void .cctor(){} // RVA: 0x7FFAFC13AD90
    }

    public class JPakePrimeOrderGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13AE90 | overloaded x2
        public void get_P(){} // RVA: 0x7FFAF2DA8380
        public void get_Q(){} // RVA: 0x7FFAF2D907C0
        public void get_G(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class JPakePrimeOrderGroups
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC13B450
    }

    public class JPakeRound1Payload
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13B890
        public void get_ParticipantId(){} // RVA: 0x7FFAF2DA8380
        public void get_Gx1(){} // RVA: 0x7FFAF2D907C0
        public void get_Gx2(){} // RVA: 0x7FFAF2DBB0C0
        public void get_KnowledgeProofForX1(){} // RVA: 0x7FFAFC13BE50
        public void get_KnowledgeProofForX2(){} // RVA: 0x7FFAFC13BF90
    }

    public class JPakeRound2Payload
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC13C0D0
        public void get_ParticipantId(){} // RVA: 0x7FFAF2DA8380
        public void get_A(){} // RVA: 0x7FFAF2D907C0
        public void get_KnowledgeProofForX2s(){} // RVA: 0x7FFAFC13C380
    }

    public class JPakeRound3Payload
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void get_ParticipantId(){} // RVA: 0x7FFAF2DA8380
        public void get_MacTag(){} // RVA: 0x7FFAF2D907C0
    }

    public class JPakeUtilities
    {
        // ── Methods ──
        public void GenerateX1(){} // RVA: 0x7FFAFC13C4C0
        public void GenerateX2(){} // RVA: 0x7FFAFC13C560
        public void CalculateS(){} // RVA: 0x7FFAFC13C600
        public void CalculateGx(){} // RVA: 0x7FFAFC0839C0
        public void CalculateGA(){} // RVA: 0x7FFAFC13C6A0
        public void CalculateX2s(){} // RVA: 0x7FFAFC13C770
        public void CalculateA(){} // RVA: 0x7FFAFC13C830
        public void CalculateZeroKnowledgeProof(){} // RVA: 0x7FFAFC13C860
        public void CalculateHashForZeroKnowledgeProof(){} // RVA: 0x7FFAFC13CAC0
        public void ValidateGx4(){} // RVA: 0x7FFAFC13CDE0
        public void ValidateGa(){} // RVA: 0x7FFAFC13CEB0
        public void ValidateZeroKnowledgeProof(){} // RVA: 0x7FFAFC13CF80
        public void CalculateKeyingMaterial(){} // RVA: 0x7FFAFC13D1C0
        public void ValidateParticipantIdsDiffer(){} // RVA: 0x7FFAFC13D300
        public void ValidateParticipantIdsEqual(){} // RVA: 0x7FFAFC13D3C0
        public void ValidateNotNull(){} // RVA: 0x7FFAFC13D520
        public void CalculateMacTag(){} // RVA: 0x7FFAFC13D580
        public void CalculateMacKey(){} // RVA: 0x7FFAFC13D860
        public void ValidateMacTag(){} // RVA: 0x7FFAFC13DB90
        public void UpdateDigest(){} // RVA: 0x7FFAFC13DEF0 | overloaded x3
        public void UpdateDigestIncludingSize(){} // RVA: 0x7FFAFC13E0C0 | overloaded x3
        public void UpdateMac(){} // RVA: 0x7FFAFC13E410 | overloaded x3
        public void IntToByteArray(){} // RVA: 0x7FFAFC13E4D0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC13E4E0
    }

}