// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Envelopes
// Classes: 6
// Methods: 72

namespace ThirdParty.Sentry.Sentry.Protocol.Envelopes
{
    public class AsyncJsonSerializable : Object
    {
        public System.Threading.Tasks.Task`1<Sentry.ISentryJsonSerializable> _source; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFE81116380
        public void CreateFrom(){} // RVA: 0x7FFE80E2E3D0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SerializeAsync(){} // RVA: 0x7FFE86F28590
        public void Serialize(){} // RVA: 0x7FFE86F28860
    }

    public class Envelope : Object
    {
        public System.Nullable`1<Sentry.SentryId> _eventId; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> _header; // 0x28

        // ── Methods ──
        public void get_Header(){} // RVA: 0x7FFE81129130
        public void get_Items(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE86F29400 | overloaded x2
        public void TryGetEventId(){} // RVA: 0x7FFE86F295B0 | overloaded x2
        public void SerializeHeaderAsync(){} // RVA: 0x7FFE86F29940
        public void SerializeHeader(){} // RVA: 0x7FFE86F29C60
        public void SerializeAsync(){} // RVA: 0x7FFE86F29F30 | overloaded x2
        public void Serialize(){} // RVA: 0x7FFE86F2A2E0 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE86F2A580
        public void CreateHeader(){} // RVA: 0x7FFE86F2A7D0 | overloaded x2
        public void FromEvent(){} // RVA: 0x7FFE86F2A8E0
        public void FromUserFeedback(){} // RVA: 0x7FFE86F2AEA0
        public void FromTransaction(){} // RVA: 0x7FFE86F2B060
        public void FromCodeLocations(){} // RVA: 0x7FFE86F2B380
        public void FromMetrics(){} // RVA: 0x7FFE86F2B500
        public void FromSession(){} // RVA: 0x7FFE86F2B820
        public void FromCheckIn(){} // RVA: 0x7FFE86F2B970
        public void FromClientReport(){} // RVA: 0x7FFE86F2BAC0
        public void DeserializeHeaderAsync(){} // RVA: 0x7FFE86F2BC10
        public void DeserializeAsync(){} // RVA: 0x7FFE86F2BE00
        public void WithItem(){} // RVA: 0x7FFE86F2C000
        public void .cctor(){} // RVA: 0x7FFE86F2C160
    }

    public class EnvelopeItem : Object
    {
        public string TypeKey;
        public string TypeValueEvent;
        public string TypeValueUserReport;

        // ── Methods ──
        public void get_Header(){} // RVA: 0x7FFE81116380
        public void get_Payload(){} // RVA: 0x7FFE810FE7C0
        public void get_DataCategory(){} // RVA: 0x7FFE86F2EC80
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void TryGetType(){} // RVA: 0x7FFE86F2EFF0
        public void TryGetLength(){} // RVA: 0x7FFE86F2F0A0
        public void TryGetOrRecalculateLength(){} // RVA: 0x7FFE86F2F1B0
        public void TryGetFileName(){} // RVA: 0x7FFE86F2F2E0
        public void BufferPayloadAsync(){} // RVA: 0x7FFE86F2F390
        public void BufferPayload(){} // RVA: 0x7FFE86F2F5E0
        public void SerializeHeaderAsync(){} // RVA: 0x7FFE86F2F6A0
        public void SerializeHeader(){} // RVA: 0x7FFE86F2F970
        public void SerializeAsync(){} // RVA: 0x7FFE86F2FAC0
        public void Serialize(){} // RVA: 0x7FFE86F2FD90
        public void Dispose(){} // RVA: 0x7FFE86F30090
        public void FromEvent(){} // RVA: 0x7FFE86F300F0
        public void FromUserFeedback(){} // RVA: 0x7FFE86F30390
        public void FromTransaction(){} // RVA: 0x7FFE86F30630
        public void FromCodeLocations(){} // RVA: 0x7FFE86F308D0
        public void FromMetric(){} // RVA: 0x7FFE86F30B70
        public void FromProfileInfo(){} // RVA: 0x7FFE86F30D80
        public void FromSession(){} // RVA: 0x7FFE86F30F90
        public void FromCheckIn(){} // RVA: 0x7FFE86F31230
        public void FromAttachment(){} // RVA: 0x7FFE86F31530 | overloaded x2
        public void FromClientReport(){} // RVA: 0x7FFE86F31A10
        public void DeserializeHeaderAsync(){} // RVA: 0x7FFE86F31CB0
        public void DeserializePayloadAsync(){} // RVA: 0x7FFE86F31EA0
        public void DeserializeAsync(){} // RVA: 0x7FFE86F320F0
    }

    public class ISerializable
    {
        // ── Methods ──
        public void SerializeAsync(){}
        public void Serialize(){} // RVA: 0x7FFE80E4F230
    }

    public class JsonSerializable : Object
    {
        public Sentry.ISentryJsonSerializable _source; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SerializeAsync(){} // RVA: 0x7FFE86F35FA0
        public void Serialize(){} // RVA: 0x7FFE86F36270
    }

    public class StreamSerializable : Object
    {
        public System.IO.Stream _source; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SerializeAsync(){} // RVA: 0x7FFE86F36B80
        public void Serialize(){} // RVA: 0x7FFE86F36C20
        public void Dispose(){} // RVA: 0x7FFE86F36C70
    }

}