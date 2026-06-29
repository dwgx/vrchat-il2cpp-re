// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
// Classes: 7
// Methods: 54

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.JPake
{
    public class JPakeParticipant : Object
    {
        public object STATE_INITIALIZED;
        public object STATE_ROUND_1_CREATED;
        public object STATE_ROUND_1_VALIDATED;
        public object STATE_ROUND_2_CREATED;
        public object STATE_ROUND_2_VALIDATED;
        public object STATE_KEY_CALCULATED;
        public object STATE_ROUND_3_CREATED;
        public object STATE_ROUND_3_VALIDATED;
        public object participantId;
        public object password;
        public object digest;
        public object random;
        public object p;
        public object q;
        public object g;
        public object partnerParticipantId;
        public object x1;
        public object x2;
        public object gx1;
        public object gx2;
        public object gx3;
        public object gx4;
        public object b;
        public object state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA32D130
        public void get_State(){} // RVA: 0x14780B0
        public void CreateRound1PayloadToSend(){} // RVA: 0xA32D7A0
        public void ValidateRound1PayloadReceived(){} // RVA: 0xA32DC50
        public void CreateRound2PayloadToSend(){} // RVA: 0xA32E150
        public void ValidateRound2PayloadReceived(){} // RVA: 0xA32E4A0
        public void CalculateKeyingMaterial(){} // RVA: 0xA32E890
        public void CreateRound3PayloadToSend(){} // RVA: 0xA32ED20
        public void ValidateRound3PayloadReceived(){} // RVA: 0xA32F040
        public void .cctor(){} // RVA: 0xA32F4F0
    }

    public class JPakePrimeOrderGroup : Object
    {
        public object p;
        public object q;
        public object g;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA32F5F0
        public void get_P(){} // RVA: 0xB5DBF0
        public void get_Q(){} // RVA: 0xB465B0
        public void get_G(){} // RVA: 0xB700F0
    }

    public class JPakePrimeOrderGroups : Object
    {
        public object SUN_JCE_1024;
        public object NIST_2048;
        public object NIST_3072;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA32FBB0
    }

    public class JPakeRound1Payload : Object
    {
        public object participantId;
        public object gx1;
        public object gx2;
        public object knowledgeProofForX1;
        public object knowledgeProofForX2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA330000
        public void get_ParticipantId(){} // RVA: 0xB5DBF0
        public void get_Gx1(){} // RVA: 0xB465B0
        public void get_Gx2(){} // RVA: 0xB700F0
        public void get_KnowledgeProofForX1(){} // RVA: 0xA3305C0
        public void get_KnowledgeProofForX2(){} // RVA: 0xA330700
    }

    public class JPakeRound2Payload : Object
    {
        public object participantId;
        public object a;
        public object knowledgeProofForX2s;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA330840
        public void get_ParticipantId(){} // RVA: 0xB5DBF0
        public void get_A(){} // RVA: 0xB465B0
        public void get_KnowledgeProofForX2s(){} // RVA: 0xA330B00
    }

    public class JPakeRound3Payload : Object
    {
        public object participantId;
        public object macTag;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_ParticipantId(){} // RVA: 0xB5DBF0
        public void get_MacTag(){} // RVA: 0xB465B0
    }

    public class JPakeUtilities : Object
    {
        public object Zero;
        public object One;

        // ── Methods ──
        public void GenerateX1(){} // RVA: 0xA330C40
        public void GenerateX2(){} // RVA: 0xA330CE0
        public void CalculateS(){} // RVA: 0xA330D80
        public void CalculateGx(){} // RVA: 0xA2763B0
        public void CalculateGA(){} // RVA: 0xA330E20
        public void CalculateX2s(){} // RVA: 0xA330EF0
        public void CalculateA(){} // RVA: 0xA330FB0
        public void CalculateZeroKnowledgeProof(){} // RVA: 0xA330FE0
        public void CalculateHashForZeroKnowledgeProof(){} // RVA: 0xA331240
        public void ValidateGx4(){} // RVA: 0xA331560
        public void ValidateGa(){} // RVA: 0xA331630
        public void ValidateZeroKnowledgeProof(){} // RVA: 0xA331700
        public void CalculateKeyingMaterial(){} // RVA: 0xA331940
        public void ValidateParticipantIdsDiffer(){} // RVA: 0xA331A80
        public void ValidateParticipantIdsEqual(){} // RVA: 0xA331B40
        public void ValidateNotNull(){} // RVA: 0xA331CA0
        public void CalculateMacTag(){} // RVA: 0xA331D00
        public void CalculateMacKey(){} // RVA: 0xA331FE0
        public void ValidateMacTag(){} // RVA: 0xA332320
        public void UpdateDigest(){} // RVA: 0xA332680
        public void UpdateDigestIncludingSize(){} // RVA: 0xA332850
        public void UpdateMac(){} // RVA: 0xA332BA0
        public void IntToByteArray(){} // RVA: 0xA332C60
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA332C70
    }

}