// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Envelopes
// Classes: 6
// Methods: 72

namespace ThirdParty.Sentry.Sentry.Protocol.Envelopes
{
    public class AsyncJsonSerializable : Source
    {
        public System.Threading.Tasks.Task`1<Sentry.ISentryJsonSerializable> <Source>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x2F8380
        public void CreateFrom(){} // RVA: 0xCE50
        public void .ctor(){} // RVA: 0x2DEE30
        public void SerializeAsync(){} // RVA: 0x63E7B90
        public void Serialize(){} // RVA: 0x63E7E60
    }

    public class Envelope
    {
        public System.Nullable`1<Sentry.SentryId> _eventId; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> <Header>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Header(){} // RVA: 0x30B130
        public void get_Items(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x63E8A00 | overloaded x2
        public void TryGetEventId(){} // RVA: 0x63E8BB0 | overloaded x2
        public void SerializeHeaderAsync(){} // RVA: 0x63E8F40
        public void SerializeHeader(){} // RVA: 0x63E9260
        public void SerializeAsync(){} // RVA: 0x63E9530 | overloaded x2
        public void Serialize(){} // RVA: 0x63E98E0 | overloaded x2
        public void Dispose(){} // RVA: 0x63E9B80
        public void CreateHeader(){} // RVA: 0x63E9DD0 | overloaded x2
        public void FromEvent(){} // RVA: 0x63E9EE0
        public void FromUserFeedback(){} // RVA: 0x63EA4A0
        public void FromTransaction(){} // RVA: 0x63EA660
        public void FromCodeLocations(){} // RVA: 0x63EA980
        public void FromMetrics(){} // RVA: 0x63EAB00
        public void FromSession(){} // RVA: 0x63EAE20
        public void FromCheckIn(){} // RVA: 0x63EAF70
        public void FromClientReport(){} // RVA: 0x63EB0C0
        public void DeserializeHeaderAsync(){} // RVA: 0x63EB210
        public void DeserializeAsync(){} // RVA: 0x63EB400
        public void WithItem(){} // RVA: 0x63EB600
        public void .cctor(){} // RVA: 0x63EB760
    }

    public class EnvelopeItem
    {
        public string TypeKey;
        public string TypeValueEvent;
        public string TypeValueUserReport;

        // ── Methods ──
        public void get_Header(){} // RVA: 0x2F8380
        public void get_Payload(){} // RVA: 0x2E07C0
        public void get_DataCategory(){} // RVA: 0x63EE280
        public void .ctor(){} // RVA: 0xF19AE0
        public void TryGetType(){} // RVA: 0x63EE5F0
        public void TryGetLength(){} // RVA: 0x63EE6A0
        public void TryGetOrRecalculateLength(){} // RVA: 0x63EE7B0
        public void TryGetFileName(){} // RVA: 0x63EE8E0
        public void BufferPayloadAsync(){} // RVA: 0x63EE990
        public void BufferPayload(){} // RVA: 0x63EEBE0
        public void SerializeHeaderAsync(){} // RVA: 0x63EECA0
        public void SerializeHeader(){} // RVA: 0x63EEF70
        public void SerializeAsync(){} // RVA: 0x63EF0C0
        public void Serialize(){} // RVA: 0x63EF390
        public void Dispose(){} // RVA: 0x63EF690
        public void FromEvent(){} // RVA: 0x63EF6F0
        public void FromUserFeedback(){} // RVA: 0x63EF990
        public void FromTransaction(){} // RVA: 0x63EFC30
        public void FromCodeLocations(){} // RVA: 0x63EFED0
        public void FromMetric(){} // RVA: 0x63F0170
        public void FromProfileInfo(){} // RVA: 0x63F0380
        public void FromSession(){} // RVA: 0x63F0590
        public void FromCheckIn(){} // RVA: 0x63F0830
        public void FromAttachment(){} // RVA: 0x63F0B30 | overloaded x2
        public void FromClientReport(){} // RVA: 0x63F1010
        public void DeserializeHeaderAsync(){} // RVA: 0x63F12B0
        public void DeserializePayloadAsync(){} // RVA: 0x63F14A0
        public void DeserializeAsync(){} // RVA: 0x63F16F0
    }

    public class ISerializable
    {
        // ── Methods ──
        public void SerializeAsync(){}
        public void Serialize(){} // RVA: 0x2DC60
    }

    public class JsonSerializable
    {
        public Sentry.ISentryJsonSerializable <Source>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DEE30
        public void SerializeAsync(){} // RVA: 0x63F55A0
        public void Serialize(){} // RVA: 0x63F5870
    }

    public class StreamSerializable : get_Source
    {
        public System.IO.Stream <Source>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x2DEE30
        public void SerializeAsync(){} // RVA: 0x63F6180
        public void Serialize(){} // RVA: 0x63F6220
        public void Dispose(){} // RVA: 0x63F6270
    }

}