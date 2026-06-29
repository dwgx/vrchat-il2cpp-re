// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Envelopes
// Classes: 6
// Methods: 66

namespace ThirdParty.Sentry.Sentry.Protocol.Envelopes
{
    public class AsyncJsonSerializable : Object
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7A80F2570
        public void CreateFrom(){} // RVA: 0x7A7E00BA0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SerializeAsync(){} // RVA: 0x7AE1D5650
        public void Serialize(){} // RVA: 0x7AE1D5930
    }

    public class Envelope : Object
    {
        // ── Methods ──
        public void get_Header(){} // RVA: 0x7A8105330
        public void get_Items(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AE1D64D0
        public void TryGetEventId(){} // RVA: 0x7AE1D6680
        public void SerializeHeaderAsync(){} // RVA: 0x7AE1D6A10
        public void SerializeHeader(){} // RVA: 0x7AE1D6D40
        public void SerializeAsync(){} // RVA: 0x7AE1D7020
        public void Serialize(){} // RVA: 0x7AE1D73D0
        public void Dispose(){} // RVA: 0x7AE1D7680
        public void CreateHeader(){} // RVA: 0x7AE1D78D0
        public void FromEvent(){} // RVA: 0x7AE1D79E0
        public void FromUserFeedback(){} // RVA: 0x7AE1D7FA0
        public void FromTransaction(){} // RVA: 0x7AE1D8160
        public void FromCodeLocations(){} // RVA: 0x7AE1D8480
        public void FromMetrics(){} // RVA: 0x7AE1D8600
        public void FromSession(){} // RVA: 0x7AE1D8910
        public void FromCheckIn(){} // RVA: 0x7AE1D8A60
        public void FromClientReport(){} // RVA: 0x7AE1D8BB0
        public void DeserializeHeaderAsync(){} // RVA: 0x7AE1D8D00
        public void DeserializeAsync(){} // RVA: 0x7AE1D8EF0
        public void WithItem(){} // RVA: 0x7AE1D90F0
        public void .cctor(){} // RVA: 0x7AE1D9250
    }

    public class EnvelopeItem : Object
    {
        // ── Methods ──
        public void get_Header(){} // RVA: 0x7A80F2570
        public void get_Payload(){} // RVA: 0x7A80DA7B0
        public void get_DataCategory(){} // RVA: 0x7AE1DBDB0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void TryGetType(){} // RVA: 0x7AE1DC120
        public void TryGetLength(){} // RVA: 0x7AE1DC1D0
        public void TryGetOrRecalculateLength(){} // RVA: 0x7AE1DC2E0
        public void TryGetFileName(){} // RVA: 0x7AE1DC410
        public void BufferPayloadAsync(){} // RVA: 0x7AE1DC4C0
        public void BufferPayload(){} // RVA: 0x7AE1DC710
        public void SerializeHeaderAsync(){} // RVA: 0x7AE1DC7D0
        public void SerializeHeader(){} // RVA: 0x7AE1DCAB0
        public void SerializeAsync(){} // RVA: 0x7AE1DCC10
        public void Serialize(){} // RVA: 0x7AE1DCEE0
        public void Dispose(){} // RVA: 0x7AE1DD1F0
        public void FromEvent(){} // RVA: 0x7AE1DD250
        public void FromUserFeedback(){} // RVA: 0x7AE1DD4F0
        public void FromTransaction(){} // RVA: 0x7AE1DD790
        public void FromCodeLocations(){} // RVA: 0x7AE1DDA30
        public void FromMetric(){} // RVA: 0x7AE1DDCD0
        public void FromProfileInfo(){} // RVA: 0x7AE1DDEE0
        public void FromSession(){} // RVA: 0x7AE1DE0F0
        public void FromCheckIn(){} // RVA: 0x7AE1DE390
        public void FromAttachment(){} // RVA: 0x7AE1DE690
        public void FromClientReport(){} // RVA: 0x7AE1DEB70
        public void DeserializeHeaderAsync(){} // RVA: 0x7AE1DEE10
        public void DeserializePayloadAsync(){} // RVA: 0x7AE1DF000
        public void DeserializeAsync(){} // RVA: 0x7AE1DF250
    }

    public class ISerializable
    {
        // ── Methods ──
        public void SerializeAsync(){} // RVA: 0x7A7E12430
        public void Serialize(){} // RVA: 0x7A7E18890
    }

    public class JsonSerializable : Object
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SerializeAsync(){} // RVA: 0x7AE1E3110
        public void Serialize(){} // RVA: 0x7AE1E33F0
    }

    public class StreamSerializable : Object
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SerializeAsync(){} // RVA: 0x7AE1E3D10
        public void Serialize(){} // RVA: 0x7AE1E3DB0
        public void Dispose(){} // RVA: 0x7AE1E3E00
    }

}