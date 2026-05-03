// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 2
// Methods: 27

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class OutputStreamHandlerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.OutputStreamHandlerConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string OutputStreamHandlerDefaultValue; // 0x8
        public string outputStreamHandler_; // 0x18
        public Google.Protobuf.FieldCodec`1<string> _repeated_inputSidePacket_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> inputSidePacket_; // 0x20
        public Mediapipe.MediaPipeOptions options_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8666DFF0
        public void get_Descriptor(){} // RVA: 0x7FFE8666E050
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8666E110
        public void .ctor(){} // RVA: 0x7FFE8666E2C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8666E520
        public void get_OutputStreamHandler(){} // RVA: 0x7FFE8666E580
        public void set_OutputStreamHandler(){} // RVA: 0x7FFE8666E5F0
        public void get_HasOutputStreamHandler(){} // RVA: 0x7FFE82AC8EE0
        public void ClearOutputStreamHandler(){} // RVA: 0x7FFE8340D8D0
        public void get_InputSidePacket(){} // RVA: 0x7FFE811290C0
        public void get_Options(){} // RVA: 0x7FFE81129130
        public void set_Options(){} // RVA: 0x7FFE810FCE90
        public void Equals(){} // RVA: 0x7FFE8666E880 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8666E9E0
        public void ToString(){} // RVA: 0x7FFE8666EAA0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8666EAF0
        public void CalculateSize(){} // RVA: 0x7FFE8666EC00
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8666EF30
        public void .cctor(){} // RVA: 0x7FFE8666F0B0
    }

    public class OutputStreamPoller`1 : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46250
        public void DeleteMpPtr(){} // RVA: 0x7FFE80E45FE0
        public void Next(){} // RVA: 0x7FFE80E2F3B0
    }

}