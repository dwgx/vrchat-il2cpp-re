// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 13
// Methods: 172

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Image
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD6230 | overloaded x5
        public void DeleteMpPtr(){} // RVA: 0x5AD64F0
        public void Width(){} // RVA: 0x5AD65B0
        public void Height(){} // RVA: 0x5AD6670
        public void Step(){} // RVA: 0x5AD6730
        public void ImageFormat(){} // RVA: 0x5AD67F0
        public void .cctor(){} // RVA: 0x5AD68B0
    }

    public class ImageArray
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x5ADBB60
    }

    public class ImageFormat
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ImageFormat> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B0EE30
        public void get_Descriptor(){} // RVA: 0x5B0EE90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B0EF50
        public void .ctor(){} // RVA: 0x5A3CAF0 | overloaded x2
        public void Clone(){} // RVA: 0x5B0F040
        public void Equals(){} // RVA: 0x5A3CD80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3CDC0
        public void ToString(){} // RVA: 0x5B0F1F0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5A3CE50
        public void CalculateSize(){} // RVA: 0x5A3CE70
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5A3CF70
        public void .cctor(){} // RVA: 0x5B0F240
    }

    public class ImageFormatExtension
    {
        // ── Methods ──
        public void NumberOfChannels(){} // RVA: 0x5AD3AD0
        public void ByteDepth(){} // RVA: 0x5AD3B40
    }

    public class ImageFormatReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B0E7C0
        public void .cctor(){} // RVA: 0x5B0E820
    }

    public class ImageFrame
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD6FA0 | overloaded x4
        public void DeleteMpPtr(){} // RVA: 0x5AD71C0
        public void VoidDeleter(){} // RVA: 0x2DD310
        public void Format(){} // RVA: 0x5AD7280
        public void Width(){} // RVA: 0x5AD7300
        public void Height(){} // RVA: 0x5AD7380
        public void ByteDepth(){} // RVA: 0x5AD7400
        public void WidthStep(){} // RVA: 0x5AD7420
        public void MutablePixelData(){} // RVA: 0x5AD74A0
        public void PixelDataSize(){} // RVA: 0x5AD7520
        public void .cctor(){} // RVA: 0x5AD7550
    }

    public class InferenceCalculatorOptions
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
        public void get_Parser(){} // RVA: 0x5AE3360
        public void get_Descriptor(){} // RVA: 0x5AE33C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AE3480
        public void .ctor(){} // RVA: 0x5AE34D0 | overloaded x2
        public void Clone(){} // RVA: 0x5AE36D0
        public void get_ModelPath(){} // RVA: 0x5AE3730
        public void set_ModelPath(){} // RVA: 0x5AE37A0
        public void get_HasModelPath(){} // RVA: 0x1E3EC10
        public void ClearModelPath(){} // RVA: 0x5A57060
        public void get_UseGpu(){} // RVA: 0x5AE38A0
        public void set_UseGpu(){} // RVA: 0x5A77FC0
        public void get_HasUseGpu(){} // RVA: 0x5A5C3B0
        public void ClearUseGpu(){} // RVA: 0x5A5C3C0
        public void get_UseNnapi(){} // RVA: 0x5AE3910
        public void set_UseNnapi(){} // RVA: 0x5AE3980
        public void get_HasUseNnapi(){} // RVA: 0x5A5C450
        public void ClearUseNnapi(){} // RVA: 0x5A5C460
        public void get_CpuNumThread(){} // RVA: 0x5AE3990
        public void set_CpuNumThread(){} // RVA: 0x5AE3A00
        public void get_HasCpuNumThread(){} // RVA: 0x5A5F650
        public void ClearCpuNumThread(){} // RVA: 0x5A5F660
        public void get_Delegate(){} // RVA: 0x6374D0
        public void set_Delegate(){} // RVA: 0x30B890
        public void Equals(){} // RVA: 0x5AE3A70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5AE3BE0
        public void ToString(){} // RVA: 0x5AE3D10
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AE3D60
        public void CalculateSize(){} // RVA: 0x5AE3E60
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AE4190
        public void .cctor(){} // RVA: 0x5AE4300
    }

    public class InferenceCalculatorReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor Description;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5AE1B90
        public void .cctor(){} // RVA: 0x5AE1BF0
    }

    public class InputCollection
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputCollection> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string name_; // 0x18
        public Google.Protobuf.FieldCodec`1<string> _repeated_sidePacketName_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<string> sidePacketName_; // 0x20
        public Google.Protobuf.FieldCodec`1<string> _repeated_externalInputName_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<string> externalInputName_; // 0x28
        public 0x6592D690 inputType_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5AF5A50
        public void get_Descriptor(){} // RVA: 0x5AF5AB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AF5B70
        public void .ctor(){} // RVA: 0x5AF5E70 | overloaded x2
        public void Clone(){} // RVA: 0x5AF6130
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x5AF6190
        public void get_SidePacketName(){} // RVA: 0x30B0C0
        public void get_ExternalInputName(){} // RVA: 0x30B130
        public void get_InputType(){} // RVA: 0x338CD0
        public void set_InputType(){} // RVA: 0x338CE0
        public void get_FileName(){} // RVA: 0x4976A0
        public void set_FileName(){} // RVA: 0x5AF6290
        public void Equals(){} // RVA: 0x5AF63F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5AF6560
        public void ToString(){} // RVA: 0x5AF6660
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AF66B0
        public void CalculateSize(){} // RVA: 0x5AF6840
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AF6BC0
        public void .cctor(){} // RVA: 0x5AF6DB0
    }

    public class InputCollectionSet
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputCollectionSet> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.InputCollection> _repeated_inputCollection_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.InputCollection> inputCollection_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5AF7170
        public void get_Descriptor(){} // RVA: 0x5AF71D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AF7290
        public void .ctor(){} // RVA: 0x5AF7440 | overloaded x2
        public void Clone(){} // RVA: 0x5AF75E0
        public void get_InputCollection(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5AF78B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5AF7960
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AF79B0
        public void CalculateSize(){} // RVA: 0x5AF7A70
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AF7C60
        public void .cctor(){} // RVA: 0x5AF7D60
    }

    public class InputStreamHandlerConfig
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputStreamHandlerConfig> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string InputStreamHandlerDefaultValue; // 0x8
        public string inputStreamHandler_; // 0x18
        public Mediapipe.MediaPipeOptions options_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B2C0A0
        public void get_Descriptor(){} // RVA: 0x5B2C100
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B2C1C0
        public void .ctor(){} // RVA: 0x5B2C2B0 | overloaded x2
        public void Clone(){} // RVA: 0x5B2C480
        public void get_InputStreamHandler(){} // RVA: 0x5B2C4E0
        public void set_InputStreamHandler(){} // RVA: 0x5B2C550
        public void get_HasInputStreamHandler(){} // RVA: 0x1D3B060
        public void ClearInputStreamHandler(){} // RVA: 0x26AD280
        public void get_Options(){} // RVA: 0x30B0C0
        public void set_Options(){} // RVA: 0x30B0D0
        public void Equals(){} // RVA: 0x5B2C7A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B2C8B0
        public void ToString(){} // RVA: 0x5B2C950
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B2C9A0
        public void CalculateSize(){} // RVA: 0x5B2CA20
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B2CCB0
        public void .cctor(){} // RVA: 0x5B2CDB0
    }

    public class InputStreamInfo
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.InputStreamInfo> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public string tagIndex_; // 0x18
        public bool backEdge_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5AF80E0
        public void get_Descriptor(){} // RVA: 0x5AF8140
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AF8200
        public void .ctor(){} // RVA: 0x5AF8380 | overloaded x2
        public void Clone(){} // RVA: 0x5AF84F0
        public void get_TagIndex(){} // RVA: 0x2E07C0
        public void set_TagIndex(){} // RVA: 0x5AF8690
        public void get_BackEdge(){} // RVA: 0x3CB9D0
        public void set_BackEdge(){} // RVA: 0x3CB9E0
        public void Equals(){} // RVA: 0x5AF8890 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5AF8940
        public void ToString(){} // RVA: 0x5AF89F0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AF8A40
        public void CalculateSize(){} // RVA: 0x5AF8AD0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AF8C80
        public void .cctor(){} // RVA: 0x5AF8D40
    }

    public class InternalException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5AD34B0
    }

}