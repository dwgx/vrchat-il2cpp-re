// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Envelopes
// Classes: 6
// Methods: 72

namespace ThirdParty.Sentry.Sentry.Protocol.Envelopes
{
    public class AsyncJsonSerializable : Source
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAF2DA8380
        public void CreateFrom(){} // RVA: 0x7FFAF2ABCE50
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void SerializeAsync(){} // RVA: 0x7FFAF8E97B90
        public void Serialize(){} // RVA: 0x7FFAF8E97E60
    }

    public class Envelope
    {
        // ── Methods ──
        public void get_Header(){} // RVA: 0x7FFAF2DBB130
        public void get_Items(){} // RVA: 0x7FFAF30E74D0
        public void .ctor(){} // RVA: 0x7FFAF8E98A00 | overloaded x2
        public void TryGetEventId(){} // RVA: 0x7FFAF8E98BB0 | overloaded x2
        public void SerializeHeaderAsync(){} // RVA: 0x7FFAF8E98F40
        public void SerializeHeader(){} // RVA: 0x7FFAF8E99260
        public void SerializeAsync(){} // RVA: 0x7FFAF8E99530 | overloaded x2
        public void Serialize(){} // RVA: 0x7FFAF8E998E0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF8E99B80
        public void CreateHeader(){} // RVA: 0x7FFAF8E99DD0 | overloaded x2
        public void FromEvent(){} // RVA: 0x7FFAF8E99EE0
        public void FromUserFeedback(){} // RVA: 0x7FFAF8E9A4A0
        public void FromTransaction(){} // RVA: 0x7FFAF8E9A660
        public void FromCodeLocations(){} // RVA: 0x7FFAF8E9A980
        public void FromMetrics(){} // RVA: 0x7FFAF8E9AB00
        public void FromSession(){} // RVA: 0x7FFAF8E9AE20
        public void FromCheckIn(){} // RVA: 0x7FFAF8E9AF70
        public void FromClientReport(){} // RVA: 0x7FFAF8E9B0C0
        public void DeserializeHeaderAsync(){} // RVA: 0x7FFAF8E9B210
        public void DeserializeAsync(){} // RVA: 0x7FFAF8E9B400
        public void WithItem(){} // RVA: 0x7FFAF8E9B600
        public void .cctor(){} // RVA: 0x7FFAF8E9B760
    }

    public class EnvelopeItem
    {
        // ── Methods ──
        public void get_Header(){} // RVA: 0x7FFAF2DA8380
        public void get_Payload(){} // RVA: 0x7FFAF2D907C0
        public void get_DataCategory(){} // RVA: 0x7FFAF8E9E280
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void TryGetType(){} // RVA: 0x7FFAF8E9E5F0
        public void TryGetLength(){} // RVA: 0x7FFAF8E9E6A0
        public void TryGetOrRecalculateLength(){} // RVA: 0x7FFAF8E9E7B0
        public void TryGetFileName(){} // RVA: 0x7FFAF8E9E8E0
        public void BufferPayloadAsync(){} // RVA: 0x7FFAF8E9E990
        public void BufferPayload(){} // RVA: 0x7FFAF8E9EBE0
        public void SerializeHeaderAsync(){} // RVA: 0x7FFAF8E9ECA0
        public void SerializeHeader(){} // RVA: 0x7FFAF8E9EF70
        public void SerializeAsync(){} // RVA: 0x7FFAF8E9F0C0
        public void Serialize(){} // RVA: 0x7FFAF8E9F390
        public void Dispose(){} // RVA: 0x7FFAF8E9F690
        public void FromEvent(){} // RVA: 0x7FFAF8E9F6F0
        public void FromUserFeedback(){} // RVA: 0x7FFAF8E9F990
        public void FromTransaction(){} // RVA: 0x7FFAF8E9FC30
        public void FromCodeLocations(){} // RVA: 0x7FFAF8E9FED0
        public void FromMetric(){} // RVA: 0x7FFAF8EA0170
        public void FromProfileInfo(){} // RVA: 0x7FFAF8EA0380
        public void FromSession(){} // RVA: 0x7FFAF8EA0590
        public void FromCheckIn(){} // RVA: 0x7FFAF8EA0830
        public void FromAttachment(){} // RVA: 0x7FFAF8EA0B30 | overloaded x2
        public void FromClientReport(){} // RVA: 0x7FFAF8EA1010
        public void DeserializeHeaderAsync(){} // RVA: 0x7FFAF8EA12B0
        public void DeserializePayloadAsync(){} // RVA: 0x7FFAF8EA14A0
        public void DeserializeAsync(){} // RVA: 0x7FFAF8EA16F0
    }

    public class ISerializable
    {
        // ── Methods ──
        public void SerializeAsync(){}
        public void Serialize(){} // RVA: 0x7FFAF2ADDC60
    }

    public class JsonSerializable
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void SerializeAsync(){} // RVA: 0x7FFAF8EA55A0
        public void Serialize(){} // RVA: 0x7FFAF8EA5870
    }

    public class StreamSerializable : get_Source
    {
        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void SerializeAsync(){} // RVA: 0x7FFAF8EA6180
        public void Serialize(){} // RVA: 0x7FFAF8EA6220
        public void Dispose(){} // RVA: 0x7FFAF8EA6270
    }

}