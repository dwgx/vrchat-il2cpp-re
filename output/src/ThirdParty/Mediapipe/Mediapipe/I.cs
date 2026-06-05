// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 13
// Methods: 172

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Image
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8586230 | overloaded x5
        public void DeleteMpPtr(){} // RVA: 0x7FFAF85864F0
        public void Width(){} // RVA: 0x7FFAF85865B0
        public void Height(){} // RVA: 0x7FFAF8586670
        public void Step(){} // RVA: 0x7FFAF8586730
        public void ImageFormat(){} // RVA: 0x7FFAF85867F0
        public void .cctor(){} // RVA: 0x7FFAF85868B0
    }

    public class ImageArray
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFAF858BB60
    }

    public class ImageFormat
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85BEE30
        public void get_Descriptor(){} // RVA: 0x7FFAF85BEE90
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85BEF50
        public void .ctor(){} // RVA: 0x7FFAF84ECAF0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85BF040
        public void Equals(){} // RVA: 0x7FFAF84ECD80 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84ECDC0
        public void ToString(){} // RVA: 0x7FFAF85BF1F0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF84ECE50
        public void CalculateSize(){} // RVA: 0x7FFAF84ECE70
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF84ECF70
        public void .cctor(){} // RVA: 0x7FFAF85BF240
    }

    public class ImageFormatExtension
    {
        // ── Methods ──
        public void NumberOfChannels(){} // RVA: 0x7FFAF8583AD0
        public void ByteDepth(){} // RVA: 0x7FFAF8583B40
    }

    public class ImageFormatReflection
    {
        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAF85BE7C0
        public void .cctor(){} // RVA: 0x7FFAF85BE820
    }

    public class ImageFrame
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8586FA0 | overloaded x4
        public void DeleteMpPtr(){} // RVA: 0x7FFAF85871C0
        public void VoidDeleter(){} // RVA: 0x7FFAF2D8D310
        public void Format(){} // RVA: 0x7FFAF8587280
        public void Width(){} // RVA: 0x7FFAF8587300
        public void Height(){} // RVA: 0x7FFAF8587380
        public void ByteDepth(){} // RVA: 0x7FFAF8587400
        public void WidthStep(){} // RVA: 0x7FFAF8587420
        public void MutablePixelData(){} // RVA: 0x7FFAF85874A0
        public void PixelDataSize(){} // RVA: 0x7FFAF8587520
        public void .cctor(){} // RVA: 0x7FFAF8587550
    }

    public class InferenceCalculatorOptions
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF8593360
        public void get_Descriptor(){} // RVA: 0x7FFAF85933C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF8593480
        public void .ctor(){} // RVA: 0x7FFAF85934D0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85936D0
        public void get_ModelPath(){} // RVA: 0x7FFAF8593730
        public void set_ModelPath(){} // RVA: 0x7FFAF85937A0
        public void get_HasModelPath(){} // RVA: 0x7FFAF48EEC10
        public void ClearModelPath(){} // RVA: 0x7FFAF8507060
        public void get_UseGpu(){} // RVA: 0x7FFAF85938A0
        public void set_UseGpu(){} // RVA: 0x7FFAF8527FC0
        public void get_HasUseGpu(){} // RVA: 0x7FFAF850C3B0
        public void ClearUseGpu(){} // RVA: 0x7FFAF850C3C0
        public void get_UseNnapi(){} // RVA: 0x7FFAF8593910
        public void set_UseNnapi(){} // RVA: 0x7FFAF8593980
        public void get_HasUseNnapi(){} // RVA: 0x7FFAF850C450
        public void ClearUseNnapi(){} // RVA: 0x7FFAF850C460
        public void get_CpuNumThread(){} // RVA: 0x7FFAF8593990
        public void set_CpuNumThread(){} // RVA: 0x7FFAF8593A00
        public void get_HasCpuNumThread(){} // RVA: 0x7FFAF850F650
        public void ClearCpuNumThread(){} // RVA: 0x7FFAF850F660
        public void get_Delegate(){} // RVA: 0x7FFAF30E74D0
        public void set_Delegate(){} // RVA: 0x7FFAF2DBB890
        public void Equals(){} // RVA: 0x7FFAF8593A70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8593BE0
        public void ToString(){} // RVA: 0x7FFAF8593D10
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF8593D60
        public void CalculateSize(){} // RVA: 0x7FFAF8593E60
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF8594190
        public void .cctor(){} // RVA: 0x7FFAF8594300
    }

    public class InferenceCalculatorReflection
    {
        public object Description;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAF8591B90
        public void .cctor(){} // RVA: 0x7FFAF8591BF0
    }

    public class InputCollection
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85A5A50
        public void get_Descriptor(){} // RVA: 0x7FFAF85A5AB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85A5B70
        public void .ctor(){} // RVA: 0x7FFAF85A5E70 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85A6130
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void set_Name(){} // RVA: 0x7FFAF85A6190
        public void get_SidePacketName(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ExternalInputName(){} // RVA: 0x7FFAF2DBB130
        public void get_InputType(){} // RVA: 0x7FFAF2DE8CD0
        public void set_InputType(){} // RVA: 0x7FFAF2DE8CE0
        public void get_FileName(){} // RVA: 0x7FFAF2F476A0
        public void set_FileName(){} // RVA: 0x7FFAF85A6290
        public void Equals(){} // RVA: 0x7FFAF85A63F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF85A6560
        public void ToString(){} // RVA: 0x7FFAF85A6660
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85A66B0
        public void CalculateSize(){} // RVA: 0x7FFAF85A6840
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85A6BC0
        public void .cctor(){} // RVA: 0x7FFAF85A6DB0
    }

    public class InputCollectionSet
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85A7170
        public void get_Descriptor(){} // RVA: 0x7FFAF85A71D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85A7290
        public void .ctor(){} // RVA: 0x7FFAF85A7440 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85A75E0
        public void get_InputCollection(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF85A78B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84EDF40
        public void ToString(){} // RVA: 0x7FFAF85A7960
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85A79B0
        public void CalculateSize(){} // RVA: 0x7FFAF85A7A70
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85A7C60
        public void .cctor(){} // RVA: 0x7FFAF85A7D60
    }

    public class InputStreamHandlerConfig
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85DC0A0
        public void get_Descriptor(){} // RVA: 0x7FFAF85DC100
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85DC1C0
        public void .ctor(){} // RVA: 0x7FFAF85DC2B0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85DC480
        public void get_InputStreamHandler(){} // RVA: 0x7FFAF85DC4E0
        public void set_InputStreamHandler(){} // RVA: 0x7FFAF85DC550
        public void get_HasInputStreamHandler(){} // RVA: 0x7FFAF47EB060
        public void ClearInputStreamHandler(){} // RVA: 0x7FFAF515D280
        public void get_Options(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Options(){} // RVA: 0x7FFAF2DBB0D0
        public void Equals(){} // RVA: 0x7FFAF85DC7A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF85DC8B0
        public void ToString(){} // RVA: 0x7FFAF85DC950
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85DC9A0
        public void CalculateSize(){} // RVA: 0x7FFAF85DCA20
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85DCCB0
        public void .cctor(){} // RVA: 0x7FFAF85DCDB0
    }

    public class InputStreamInfo
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85A80E0
        public void get_Descriptor(){} // RVA: 0x7FFAF85A8140
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85A8200
        public void .ctor(){} // RVA: 0x7FFAF85A8380 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85A84F0
        public void get_TagIndex(){} // RVA: 0x7FFAF2D907C0
        public void set_TagIndex(){} // RVA: 0x7FFAF85A8690
        public void get_BackEdge(){} // RVA: 0x7FFAF2E7B9D0
        public void set_BackEdge(){} // RVA: 0x7FFAF2E7B9E0
        public void Equals(){} // RVA: 0x7FFAF85A8890 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF85A8940
        public void ToString(){} // RVA: 0x7FFAF85A89F0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85A8A40
        public void CalculateSize(){} // RVA: 0x7FFAF85A8AD0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85A8C80
        public void .cctor(){} // RVA: 0x7FFAF85A8D40
    }

    public class InternalException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85834B0
    }

}