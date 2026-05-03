// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 13
// Methods: 172

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Image : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86617060 | overloaded x5
        public void DeleteMpPtr(){} // RVA: 0x7FFE86617320
        public void Width(){} // RVA: 0x7FFE866173E0
        public void Height(){} // RVA: 0x7FFE866174A0
        public void Step(){} // RVA: 0x7FFE86617560
        public void ImageFormat(){} // RVA: 0x7FFE86617620
        public void .cctor(){} // RVA: 0x7FFE866176E0
    }

    public class ImageArray : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFE8661C990
    }

    public class ImageFormat : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ImageFormat> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public object field_2; // 0x144

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8664FC60
        public void get_Descriptor(){} // RVA: 0x7FFE8664FCC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8664FD80
        public void .ctor(){} // RVA: 0x7FFE8657D850 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8664FE70
        public void Equals(){} // RVA: 0x7FFE8657DAE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657DB20
        public void ToString(){} // RVA: 0x7FFE86650020
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8657DBB0
        public void CalculateSize(){} // RVA: 0x7FFE8657DBD0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8657DCD0
        public void .cctor(){} // RVA: 0x7FFE86650070
    }

    public class ImageFormatExtension : Object
    {
        // ── Methods ──
        public void NumberOfChannels(){} // RVA: 0x7FFE86614900
        public void ByteDepth(){} // RVA: 0x7FFE86614970
    }

    public class ImageFormatReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8664F5F0
        public void .cctor(){} // RVA: 0x7FFE8664F650
    }

    public class ImageFrame : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86617DD0 | overloaded x4
        public void DeleteMpPtr(){} // RVA: 0x7FFE86617FF0
        public void VoidDeleter(){} // RVA: 0x7FFE810FB310
        public void Format(){} // RVA: 0x7FFE866180B0
        public void Width(){} // RVA: 0x7FFE86618130
        public void Height(){} // RVA: 0x7FFE866181B0
        public void ByteDepth(){} // RVA: 0x7FFE86618230
        public void WidthStep(){} // RVA: 0x7FFE86618250
        public void MutablePixelData(){} // RVA: 0x7FFE866182D0
        public void PixelDataSize(){} // RVA: 0x7FFE86618350
        public void .cctor(){} // RVA: 0x7FFE86618380
    }

    public class InferenceCalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InferenceCalculatorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public string ModelPathDefaultValue; // 0x8
        public string modelPath_; // 0x20
        public bool UseGpuDefaultValue; // 0x10
        public bool useGpu_; // 0x28
        public bool UseNnapiDefaultValue; // 0x11
        public bool useNnapi_; // 0x29
        public int CpuNumThreadDefaultValue; // 0x14
        public int cpuNumThread_; // 0x2C
        public Delegate delegate_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86624190
        public void get_Descriptor(){} // RVA: 0x7FFE866241F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866242B0
        public void .ctor(){} // RVA: 0x7FFE86624300 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86624500
        public void get_ModelPath(){} // RVA: 0x7FFE86624560
        public void set_ModelPath(){} // RVA: 0x7FFE866245D0
        public void get_HasModelPath(){} // RVA: 0x7FFE82BC81D0
        public void ClearModelPath(){} // RVA: 0x7FFE86597DC0
        public void get_UseGpu(){} // RVA: 0x7FFE866246D0
        public void set_UseGpu(){} // RVA: 0x7FFE865B8D20
        public void get_HasUseGpu(){} // RVA: 0x7FFE8659D0B0
        public void ClearUseGpu(){} // RVA: 0x7FFE8659D0C0
        public void get_UseNnapi(){} // RVA: 0x7FFE86624740
        public void set_UseNnapi(){} // RVA: 0x7FFE866247B0
        public void get_HasUseNnapi(){} // RVA: 0x7FFE8659D150
        public void ClearUseNnapi(){} // RVA: 0x7FFE8659D160
        public void get_CpuNumThread(){} // RVA: 0x7FFE866247C0
        public void set_CpuNumThread(){} // RVA: 0x7FFE86624830
        public void get_HasCpuNumThread(){} // RVA: 0x7FFE865A0350
        public void ClearCpuNumThread(){} // RVA: 0x7FFE865A0360
        public void get_Delegate(){} // RVA: 0x7FFE8144E200
        public void set_Delegate(){} // RVA: 0x7FFE81129890
        public void Equals(){} // RVA: 0x7FFE866248A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86624A10
        public void ToString(){} // RVA: 0x7FFE86624B40
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86624B90
        public void CalculateSize(){} // RVA: 0x7FFE86624C90
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86624FC0
        public void .cctor(){} // RVA: 0x7FFE86625130
    }

    public class InferenceCalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866229C0
        public void .cctor(){} // RVA: 0x7FFE86622A20
    }

    public class InputCollection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputCollection> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string name_; // 0x18
        public Google.Protobuf.FieldCodec`1<string> _repeated_sidePacketName_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<string> sidePacketName_; // 0x20
        public Google.Protobuf.FieldCodec`1<string> _repeated_externalInputName_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> externalInputName_; // 0x28
        public 0x6660AD9C inputType_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86636880
        public void get_Descriptor(){} // RVA: 0x7FFE866368E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866369A0
        public void .ctor(){} // RVA: 0x7FFE86636CA0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86636F60
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE86636FC0
        public void get_SidePacketName(){} // RVA: 0x7FFE811290C0
        public void get_ExternalInputName(){} // RVA: 0x7FFE81129130
        public void get_InputType(){} // RVA: 0x7FFE81156CD0
        public void set_InputType(){} // RVA: 0x7FFE81156CE0
        public void get_FileName(){} // RVA: 0x7FFE8143BA80
        public void set_FileName(){} // RVA: 0x7FFE866370C0
        public void Equals(){} // RVA: 0x7FFE86637220 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86637390
        public void ToString(){} // RVA: 0x7FFE86637490
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866374E0
        public void CalculateSize(){} // RVA: 0x7FFE86637670
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866379F0
        public void .cctor(){} // RVA: 0x7FFE86637BE0
    }

    public class InputCollectionSet : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputCollectionSet> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.InputCollection> _repeated_inputCollection_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.InputCollection> inputCollection_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86637FA0
        public void get_Descriptor(){} // RVA: 0x7FFE86638000
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866380C0
        public void .ctor(){} // RVA: 0x7FFE86638270 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86638410
        public void get_InputCollection(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE866386E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86638790
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866387E0
        public void CalculateSize(){} // RVA: 0x7FFE866388A0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86638A90
        public void .cctor(){} // RVA: 0x7FFE86638B90
    }

    public class InputStreamHandlerConfig : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputStreamHandlerConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string InputStreamHandlerDefaultValue; // 0x8
        public string inputStreamHandler_; // 0x18
        public Mediapipe.MediaPipeOptions options_; // 0x20
        public object field_5; // 0x202

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8666CED0
        public void get_Descriptor(){} // RVA: 0x7FFE8666CF30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8666CFF0
        public void .ctor(){} // RVA: 0x7FFE8666D0E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8666D2B0
        public void get_InputStreamHandler(){} // RVA: 0x7FFE8666D310
        public void set_InputStreamHandler(){} // RVA: 0x7FFE8666D380
        public void get_HasInputStreamHandler(){} // RVA: 0x7FFE82AC8EE0
        public void ClearInputStreamHandler(){} // RVA: 0x7FFE8340D8D0
        public void get_Options(){} // RVA: 0x7FFE811290C0
        public void set_Options(){} // RVA: 0x7FFE811290D0
        public void Equals(){} // RVA: 0x7FFE8666D5D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8666D6E0
        public void ToString(){} // RVA: 0x7FFE8666D780
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8666D7D0
        public void CalculateSize(){} // RVA: 0x7FFE8666D850
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8666DAE0
        public void .cctor(){} // RVA: 0x7FFE8666DBE0
    }

    public class InputStreamInfo : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputStreamInfo> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string tagIndex_; // 0x18
        public bool backEdge_; // 0x20
        public object field_4; // 0xB8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86638F10
        public void get_Descriptor(){} // RVA: 0x7FFE86638F70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86639030
        public void .ctor(){} // RVA: 0x7FFE866391B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86639320
        public void get_TagIndex(){} // RVA: 0x7FFE810FE7C0
        public void set_TagIndex(){} // RVA: 0x7FFE866394C0
        public void get_BackEdge(){} // RVA: 0x7FFE811E99D0
        public void set_BackEdge(){} // RVA: 0x7FFE811E99E0
        public void Equals(){} // RVA: 0x7FFE866396C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86639770
        public void ToString(){} // RVA: 0x7FFE86639820
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86639870
        public void CalculateSize(){} // RVA: 0x7FFE86639900
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86639AB0
        public void .cctor(){} // RVA: 0x7FFE86639B70
    }

    public class InternalException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866142E0
    }

}