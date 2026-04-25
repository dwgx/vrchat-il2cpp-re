// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 2
// Methods: 27

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class OutputStreamHandlerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.OutputStreamHandlerConfig> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string OutputStreamHandler; // 0x18
        public Google.Protobuf.FieldCodec`1<string> HasOutputStreamHandler; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> InputSidePacket; // 0x20
        public Mediapipe.MediaPipeOptions Options; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82C46D0
        public void get_Descriptor(){} // RVA: 0x7FFAC82C4730
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82C47F0
        public void .ctor(){} // RVA: 0x7FFAC82C49A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82C4C00
        public void get_OutputStreamHandler(){} // RVA: 0x7FFAC82C4C60
        public void set_OutputStreamHandler(){} // RVA: 0x7FFAC82C4CD0
        public void get_HasOutputStreamHandler(){} // RVA: 0x7FFAC4860B40
        public void ClearOutputStreamHandler(){} // RVA: 0x7FFAC515CC20
        public void get_InputSidePacket(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Options(){} // RVA: 0x7FFAC2F4F130
        public void set_Options(){} // RVA: 0x7FFAC2F22E90
        public void Equals(){} // RVA: 0x7FFAC82C4F60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82C50C0
        public void ToString(){} // RVA: 0x7FFAC82C5180
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82C51D0
        public void CalculateSize(){} // RVA: 0x7FFAC82C52E0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82C5610
        public void .cctor(){} // RVA: 0x7FFAC82C5790
    }

    public class OutputStreamPoller`1 : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70BF0
        public void DeleteMpPtr(){} // RVA: 0x7FFAC2C70980
        public void Next(){} // RVA: 0x7FFAC2C59F60
    }

}