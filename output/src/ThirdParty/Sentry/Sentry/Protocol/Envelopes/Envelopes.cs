// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Envelopes
// Classes: 6
// Methods: 72

namespace ThirdParty.Sentry.Sentry.Protocol.Envelopes
{
    public class AsyncJsonSerializable : Object
    {
        public System.Threading.Tasks.Task`1<Sentry.ISentryJsonSerializable> Source; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAC2F3C380
        public void CreateFrom(){} // RVA: 0x7FFAC2C58F80
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SerializeAsync(){} // RVA: 0x7FFAC8B7EF10
        public void Serialize(){} // RVA: 0x7FFAC8B7F1E0
    }

    public class Envelope : Object
    {
        public System.Nullable`1<Sentry.SentryId> Header; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> Items; // 0x28
        public System.Collections.Generic.IReadOnlyList`1<Sentry.Protocol.Envelopes.EnvelopeItem> <Items>k__BackingField; // 0x30
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> SdkHeader;
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> DefaultHeader; // 0x8

        // ── Methods ──
        public void get_Header(){} // RVA: 0x7FFAC2F4F130
        public void get_Items(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC8B7FD80 | overloaded x2
        public void TryGetEventId(){} // RVA: 0x7FFAC8B7FF30 | overloaded x2
        public void SerializeHeaderAsync(){} // RVA: 0x7FFAC8B802C0
        public void SerializeHeader(){} // RVA: 0x7FFAC8B805E0
        public void SerializeAsync(){} // RVA: 0x7FFAC8B808B0 | overloaded x2
        public void Serialize(){} // RVA: 0x7FFAC8B80C60 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC8B80F00
        public void CreateHeader(){} // RVA: 0x7FFAC8B81150 | overloaded x2
        public void FromEvent(){} // RVA: 0x7FFAC8B81260
        public void FromUserFeedback(){} // RVA: 0x7FFAC8B81820
        public void FromTransaction(){} // RVA: 0x7FFAC8B819E0
        public void FromCodeLocations(){} // RVA: 0x7FFAC8B81D00
        public void FromMetrics(){} // RVA: 0x7FFAC8B81E80
        public void FromSession(){} // RVA: 0x7FFAC8B821A0
        public void FromCheckIn(){} // RVA: 0x7FFAC8B822F0
        public void FromClientReport(){} // RVA: 0x7FFAC8B82440
        public void DeserializeHeaderAsync(){} // RVA: 0x7FFAC8B82590
        public void DeserializeAsync(){} // RVA: 0x7FFAC8B82780
        public void WithItem(){} // RVA: 0x7FFAC8B82980
        public void .cctor(){} // RVA: 0x7FFAC8B82AE0
    }

    public class EnvelopeItem : Object
    {
        public string Header;
        public string Payload;
        public string DataCategory;
        public string TypeValueTransaction;
        public string TypeValueSpan;
        public string TypeValueSession;
        public string TypeValueCheckIn;
        public string TypeValueAttachment;
        public string TypeValueClientReport;
        public string TypeValueProfile;
        public string TypeValueMetric;
        public string TypeValueCodeLocations;
        public string LengthKey;
        public string FileNameKey;
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> <Header>k__BackingField; // 0x10
        public Sentry.Protocol.Envelopes.ISerializable <Payload>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Header(){} // RVA: 0x7FFAC2F3C380
        public void get_Payload(){} // RVA: 0x7FFAC2F247C0
        public void get_DataCategory(){} // RVA: 0x7FFAC8B85600
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void TryGetType(){} // RVA: 0x7FFAC8B85970
        public void TryGetLength(){} // RVA: 0x7FFAC8B85A20
        public void TryGetOrRecalculateLength(){} // RVA: 0x7FFAC8B85B30
        public void TryGetFileName(){} // RVA: 0x7FFAC8B85C60
        public void BufferPayloadAsync(){} // RVA: 0x7FFAC8B85D10
        public void BufferPayload(){} // RVA: 0x7FFAC8B85F60
        public void SerializeHeaderAsync(){} // RVA: 0x7FFAC8B86020
        public void SerializeHeader(){} // RVA: 0x7FFAC8B862F0
        public void SerializeAsync(){} // RVA: 0x7FFAC8B86440
        public void Serialize(){} // RVA: 0x7FFAC8B86710
        public void Dispose(){} // RVA: 0x7FFAC8B86A10
        public void FromEvent(){} // RVA: 0x7FFAC8B86A70
        public void FromUserFeedback(){} // RVA: 0x7FFAC8B86D10
        public void FromTransaction(){} // RVA: 0x7FFAC8B86FB0
        public void FromCodeLocations(){} // RVA: 0x7FFAC8B87250
        public void FromMetric(){} // RVA: 0x7FFAC8B874F0
        public void FromProfileInfo(){} // RVA: 0x7FFAC8B87700
        public void FromSession(){} // RVA: 0x7FFAC8B87910
        public void FromCheckIn(){} // RVA: 0x7FFAC8B87BB0
        public void FromAttachment(){} // RVA: 0x7FFAC8B87EB0 | overloaded x2
        public void FromClientReport(){} // RVA: 0x7FFAC8B88390
        public void DeserializeHeaderAsync(){} // RVA: 0x7FFAC8B88630
        public void DeserializePayloadAsync(){} // RVA: 0x7FFAC8B88820
        public void DeserializeAsync(){} // RVA: 0x7FFAC8B88A70
    }

    public class ISerializable
    {
        // ── Methods ──
        public void SerializeAsync(){}
        public void Serialize(){} // RVA: 0x7FFAC2C79B30
    }

    public class JsonSerializable : Object
    {
        public Sentry.ISentryJsonSerializable Source; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SerializeAsync(){} // RVA: 0x7FFAC8B8C920
        public void Serialize(){} // RVA: 0x7FFAC8B8CBF0
    }

    public class StreamSerializable : Object
    {
        public System.IO.Stream Source; // 0x10

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SerializeAsync(){} // RVA: 0x7FFAC8B8D500
        public void Serialize(){} // RVA: 0x7FFAC8B8D5A0
        public void Dispose(){} // RVA: 0x7FFAC8B8D5F0
    }

}