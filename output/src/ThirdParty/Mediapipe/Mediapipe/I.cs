// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 13
// Methods: 172

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Image : MpResourceHandle
    {
        public Deleter _VoidDeleter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826D740 | overloaded x5
        public void DeleteMpPtr(){} // RVA: 0x7FFAC826DA00
        public void Width(){} // RVA: 0x7FFAC826DAC0
        public void Height(){} // RVA: 0x7FFAC826DB80
        public void Step(){} // RVA: 0x7FFAC826DC40
        public void ImageFormat(){} // RVA: 0x7FFAC826DD00
        public void .cctor(){} // RVA: 0x7FFAC826DDC0
    }

    public class ImageArray : ValueType
    {
        public UIntPtr _data; // 0x10
        public int _size; // 0x18

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFAC8273070
    }

    public class ImageFormat : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ImageFormat> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82A6340
        public void get_Descriptor(){} // RVA: 0x7FFAC82A63A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82A6460
        public void .ctor(){} // RVA: 0x7FFAC81D3F10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82A6550
        public void Equals(){} // RVA: 0x7FFAC81D41A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D41E0
        public void ToString(){} // RVA: 0x7FFAC82A6700
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81D4270
        public void CalculateSize(){} // RVA: 0x7FFAC81D4290
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81D4390
        public void .cctor(){} // RVA: 0x7FFAC82A6750
    }

    public class ImageFormatExtension : Object
    {
        // ── Methods ──
        public void NumberOfChannels(){} // RVA: 0x7FFAC826AFE0
        public void ByteDepth(){} // RVA: 0x7FFAC826B050
    }

    public class ImageFormatReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82A5CD0
        public void .cctor(){} // RVA: 0x7FFAC82A5D30
    }

    public class ImageFrame : MpResourceHandle
    {
        public uint DefaultAlignmentBoundary;
        public uint GlDefaultAlignmentBoundary; // 0x4
        public Deleter _VoidDeleter; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826E4B0 | overloaded x4
        public void DeleteMpPtr(){} // RVA: 0x7FFAC826E6D0
        public void VoidDeleter(){} // RVA: 0x7FFAC2F21310
        public void Format(){} // RVA: 0x7FFAC826E790
        public void Width(){} // RVA: 0x7FFAC826E810
        public void Height(){} // RVA: 0x7FFAC826E890
        public void ByteDepth(){} // RVA: 0x7FFAC826E910
        public void WidthStep(){} // RVA: 0x7FFAC826E930
        public void MutablePixelData(){} // RVA: 0x7FFAC826E9B0
        public void PixelDataSize(){} // RVA: 0x7FFAC826EA30
        public void .cctor(){} // RVA: 0x7FFAC826EA60
    }

    public class InferenceCalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InferenceCalculatorOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public string ModelPath; // 0x8
        public string HasModelPath; // 0x20
        public bool UseGpu; // 0x10
        public bool HasUseGpu; // 0x28
        public bool UseNnapi; // 0x11
        public bool HasUseNnapi; // 0x29
        public int CpuNumThread; // 0x14
        public int HasCpuNumThread; // 0x2C
        public Delegate Delegate; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC827A870
        public void get_Descriptor(){} // RVA: 0x7FFAC827A8D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC827A990
        public void .ctor(){} // RVA: 0x7FFAC827A9E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC827ABE0
        public void get_ModelPath(){} // RVA: 0x7FFAC827AC40
        public void set_ModelPath(){} // RVA: 0x7FFAC827ACB0
        public void get_HasModelPath(){} // RVA: 0x7FFAC495C6A0
        public void ClearModelPath(){} // RVA: 0x7FFAC81EE480
        public void get_UseGpu(){} // RVA: 0x7FFAC827ADB0
        public void set_UseGpu(){} // RVA: 0x7FFAC820F3E0
        public void get_HasUseGpu(){} // RVA: 0x7FFAC81F3770
        public void ClearUseGpu(){} // RVA: 0x7FFAC81F3780
        public void get_UseNnapi(){} // RVA: 0x7FFAC827AE20
        public void set_UseNnapi(){} // RVA: 0x7FFAC827AE90
        public void get_HasUseNnapi(){} // RVA: 0x7FFAC81F3810
        public void ClearUseNnapi(){} // RVA: 0x7FFAC81F3820
        public void get_CpuNumThread(){} // RVA: 0x7FFAC827AEA0
        public void set_CpuNumThread(){} // RVA: 0x7FFAC827AF10
        public void get_HasCpuNumThread(){} // RVA: 0x7FFAC81F6A10
        public void ClearCpuNumThread(){} // RVA: 0x7FFAC81F6A20
        public void get_Delegate(){} // RVA: 0x7FFAC31D95E0
        public void set_Delegate(){} // RVA: 0x7FFAC2F4F890
        public void Equals(){} // RVA: 0x7FFAC827AF80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC827B0F0
        public void ToString(){} // RVA: 0x7FFAC827B220
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC827B270
        public void CalculateSize(){} // RVA: 0x7FFAC827B370
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC827B6A0
        public void .cctor(){} // RVA: 0x7FFAC827B810
    }

    public class InferenceCalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82790A0
        public void .cctor(){} // RVA: 0x7FFAC8279100
    }

    public class InputCollection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputCollection> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public Google.Protobuf.FieldCodec`1<string> Name; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<string> SidePacketName; // 0x20
        public Google.Protobuf.FieldCodec`1<string> ExternalInputName; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> InputType; // 0x28
        public 0x6B2114D8 FileName; // 0x30
        public string fileName_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC828CF60
        public void get_Descriptor(){} // RVA: 0x7FFAC828CFC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC828D080
        public void .ctor(){} // RVA: 0x7FFAC828D380 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC828D640
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC828D6A0
        public void get_SidePacketName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ExternalInputName(){} // RVA: 0x7FFAC2F4F130
        public void get_InputType(){} // RVA: 0x7FFAC2F7CCD0
        public void set_InputType(){} // RVA: 0x7FFAC2F7CCE0
        public void get_FileName(){} // RVA: 0x7FFAC31D0140
        public void set_FileName(){} // RVA: 0x7FFAC828D7A0
        public void Equals(){} // RVA: 0x7FFAC828D900 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC828DA70
        public void ToString(){} // RVA: 0x7FFAC828DB70
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC828DBC0
        public void CalculateSize(){} // RVA: 0x7FFAC828DD50
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC828E0D0
        public void .cctor(){} // RVA: 0x7FFAC828E2C0
    }

    public class InputCollectionSet : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputCollectionSet> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.InputCollection> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.InputCollection> InputCollection; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC828E680
        public void get_Descriptor(){} // RVA: 0x7FFAC828E6E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC828E7A0
        public void .ctor(){} // RVA: 0x7FFAC828E950 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC828EAF0
        public void get_InputCollection(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC828EDC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC828EE70
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC828EEC0
        public void CalculateSize(){} // RVA: 0x7FFAC828EF80
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC828F170
        public void .cctor(){} // RVA: 0x7FFAC828F270
    }

    public class InputStreamHandlerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputStreamHandlerConfig> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public string InputStreamHandler; // 0x18
        public Mediapipe.MediaPipeOptions HasInputStreamHandler; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82C35B0
        public void get_Descriptor(){} // RVA: 0x7FFAC82C3610
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82C36D0
        public void .ctor(){} // RVA: 0x7FFAC82C37C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82C3990
        public void get_InputStreamHandler(){} // RVA: 0x7FFAC82C39F0
        public void set_InputStreamHandler(){} // RVA: 0x7FFAC82C3A60
        public void get_HasInputStreamHandler(){} // RVA: 0x7FFAC4860B40
        public void ClearInputStreamHandler(){} // RVA: 0x7FFAC515CC20
        public void get_Options(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Options(){} // RVA: 0x7FFAC2F4F0D0
        public void Equals(){} // RVA: 0x7FFAC82C3CB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82C3DC0
        public void ToString(){} // RVA: 0x7FFAC82C3E60
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82C3EB0
        public void CalculateSize(){} // RVA: 0x7FFAC82C3F30
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82C41C0
        public void .cctor(){} // RVA: 0x7FFAC82C42C0
    }

    public class InputStreamInfo : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputStreamInfo> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public string pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public bool TagIndex; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC828F5F0
        public void get_Descriptor(){} // RVA: 0x7FFAC828F650
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC828F710
        public void .ctor(){} // RVA: 0x7FFAC828F890 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC828FA00
        public void get_TagIndex(){} // RVA: 0x7FFAC2F247C0
        public void set_TagIndex(){} // RVA: 0x7FFAC828FBA0
        public void get_BackEdge(){} // RVA: 0x7FFAC300F9D0
        public void set_BackEdge(){} // RVA: 0x7FFAC300F9E0
        public void Equals(){} // RVA: 0x7FFAC828FDA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC828FE50
        public void ToString(){} // RVA: 0x7FFAC828FF00
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC828FF50
        public void CalculateSize(){} // RVA: 0x7FFAC828FFE0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8290190
        public void .cctor(){} // RVA: 0x7FFAC8290250
    }

    public class InternalException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826A9C0
    }

}