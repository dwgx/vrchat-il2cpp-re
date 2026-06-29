// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Envelopes
// Classes: 6
// Methods: 66

namespace ThirdParty.Sentry.Sentry.Protocol.Envelopes
{
    public class AsyncJsonSerializable : Object
    {
        public object _source;

        // ── Methods ──
        public void get_Source(){} // RVA: 0xB5DBF0
        public void CreateFrom(){} // RVA: 0x87C5C0
        public void .ctor(){} // RVA: 0xB44D60
        public void SerializeAsync(){} // RVA: 0x6E58220
        public void Serialize(){} // RVA: 0x6E58500
    }

    public class Envelope : Object
    {
        public object _eventId;
        public object _header;
        public object _items;
        public object SdkHeader;
        public object DefaultHeader;

        // ── Methods ──
        public void get_Header(){} // RVA: 0xB70160
        public void get_Items(){} // RVA: 0xD33E60
        public void .ctor(){} // RVA: 0x6E590A0
        public void TryGetEventId(){} // RVA: 0x6E59250
        public void SerializeHeaderAsync(){} // RVA: 0x6E595D0
        public void SerializeHeader(){} // RVA: 0x6E59900
        public void SerializeAsync(){} // RVA: 0x6E59BE0
        public void Serialize(){} // RVA: 0x6E59F90
        public void Dispose(){} // RVA: 0x6E5A240
        public void CreateHeader(){} // RVA: 0x6E5A490
        public void FromEvent(){} // RVA: 0x6E5A5A0
        public void FromUserFeedback(){} // RVA: 0x6E5AB60
        public void FromTransaction(){} // RVA: 0x6E5AD20
        public void FromCodeLocations(){} // RVA: 0x6E5B040
        public void FromMetrics(){} // RVA: 0x6E5B1C0
        public void FromSession(){} // RVA: 0x6E5B4D0
        public void FromCheckIn(){} // RVA: 0x6E5B620
        public void FromClientReport(){} // RVA: 0x6E5B770
        public void DeserializeHeaderAsync(){} // RVA: 0x6E5B8C0
        public void DeserializeAsync(){} // RVA: 0x6E5BAB0
        public void WithItem(){} // RVA: 0x6E5BCB0
        public void .cctor(){} // RVA: 0x6E5BE10
    }

    public class EnvelopeItem : Object
    {
        public object TypeKey;
        public object TypeValueEvent;
        public object TypeValueUserReport;
        public object TypeValueTransaction;
        public object TypeValueSpan;
        public object TypeValueSession;
        public object TypeValueCheckIn;
        public object TypeValueAttachment;
        public object TypeValueClientReport;
        public object TypeValueProfile;
        public object TypeValueMetric;
        public object TypeValueCodeLocations;
        public object LengthKey;
        public object FileNameKey;
        public object _header;
        public object _payload;

        // ── Methods ──
        public void get_Header(){} // RVA: 0xB5DBF0
        public void get_Payload(){} // RVA: 0xB465B0
        public void get_DataCategory(){} // RVA: 0x6E5E970
        public void .ctor(){} // RVA: 0x17C92C0
        public void TryGetType(){} // RVA: 0x6E5ECE0
        public void TryGetLength(){} // RVA: 0x6E5ED80
        public void TryGetOrRecalculateLength(){} // RVA: 0x6E5EE90
        public void TryGetFileName(){} // RVA: 0x6E5EFC0
        public void BufferPayloadAsync(){} // RVA: 0x6E5F060
        public void BufferPayload(){} // RVA: 0x6E5F2B0
        public void SerializeHeaderAsync(){} // RVA: 0x6E5F370
        public void SerializeHeader(){} // RVA: 0x6E5F650
        public void SerializeAsync(){} // RVA: 0x6E5F7B0
        public void Serialize(){} // RVA: 0x6E5FA80
        public void Dispose(){} // RVA: 0x6E5FD80
        public void FromEvent(){} // RVA: 0x6E5FDE0
        public void FromUserFeedback(){} // RVA: 0x6E60080
        public void FromTransaction(){} // RVA: 0x6E60320
        public void FromCodeLocations(){} // RVA: 0x6E605C0
        public void FromMetric(){} // RVA: 0x6E60860
        public void FromProfileInfo(){} // RVA: 0x6E60A70
        public void FromSession(){} // RVA: 0x6E60C80
        public void FromCheckIn(){} // RVA: 0x6E60F20
        public void FromAttachment(){} // RVA: 0x6E61220
        public void FromClientReport(){} // RVA: 0x6E61700
        public void DeserializeHeaderAsync(){} // RVA: 0x6E619A0
        public void DeserializePayloadAsync(){} // RVA: 0x6E61B90
        public void DeserializeAsync(){} // RVA: 0x6E61DE0
    }

    public class ISerializable
    {
        // ── Methods ──
        public void SerializeAsync(){} // RVA: 0x88DEC0
        public void Serialize(){} // RVA: 0x8943B0
    }

    public class JsonSerializable : Object
    {
        public object _source;

        // ── Methods ──
        public void get_Source(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB44D60
        public void SerializeAsync(){} // RVA: 0x6E65CD0
        public void Serialize(){} // RVA: 0x6E65FB0
    }

    public class StreamSerializable : Object
    {
        public object _source;

        // ── Methods ──
        public void get_Source(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB44D60
        public void SerializeAsync(){} // RVA: 0x6E668D0
        public void Serialize(){} // RVA: 0x6E66970
        public void Dispose(){} // RVA: 0x6E669C0
    }

}