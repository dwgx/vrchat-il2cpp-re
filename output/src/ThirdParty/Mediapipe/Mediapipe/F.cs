// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 4
// Methods: 101

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class FaceDetectionOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.FaceDetectionOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public string ModelPathDefaultValue; // 0x8
        public string modelPath_; // 0x20
        public 0x6592FA50 GpuOriginDefaultValue; // 0x10
        public 0x6592FA50 gpuOrigin_; // 0x28
        public int TensorWidthDefaultValue; // 0x14
        public int tensorWidth_; // 0x2C
        public int TensorHeightDefaultValue; // 0x18
        public int tensorHeight_; // 0x30
        public int NumLayersDefaultValue; // 0x1C
        public int numLayers_; // 0x34
        public Google.Protobuf.FieldCodec`1<int> _repeated_strides_codec; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<int> strides_; // 0x38
        public float InterpolatedScaleAspectRatioDefaultValue; // 0x28
        public float interpolatedScaleAspectRatio_; // 0x40
        public int NumBoxesDefaultValue; // 0x2C
        public int numBoxes_; // 0x44
        public float XScaleDefaultValue; // 0x30
        public float xScale_; // 0x48
        public float YScaleDefaultValue; // 0x34
        public float yScale_; // 0x4C
        public float WScaleDefaultValue; // 0x38
        public float wScale_; // 0x50
        public float HScaleDefaultValue; // 0x3C
        public float hScale_; // 0x54
        public float MinScoreThreshDefaultValue; // 0x40
        public float minScoreThresh_; // 0x58

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B2FEA0
        public void get_Descriptor(){} // RVA: 0x5B2FF00
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B2FFC0
        public void .ctor(){} // RVA: 0x5B30170 | overloaded x2
        public void Clone(){} // RVA: 0x5B30440
        public void get_ModelPath(){} // RVA: 0x5B304A0
        public void set_ModelPath(){} // RVA: 0x5B30510
        public void get_HasModelPath(){} // RVA: 0x1E3EC10
        public void ClearModelPath(){} // RVA: 0x5A57060
        public void get_GpuOrigin(){} // RVA: 0x5B30610
        public void set_GpuOrigin(){} // RVA: 0x5A5F540
        public void get_HasGpuOrigin(){} // RVA: 0x5A5C3B0
        public void ClearGpuOrigin(){} // RVA: 0x5A5C3C0
        public void get_TensorWidth(){} // RVA: 0x5B30680
        public void set_TensorWidth(){} // RVA: 0x5A5F5C0
        public void get_HasTensorWidth(){} // RVA: 0x5A5C450
        public void ClearTensorWidth(){} // RVA: 0x5A5C460
        public void get_TensorHeight(){} // RVA: 0x5B306F0
        public void set_TensorHeight(){} // RVA: 0x5A5F640
        public void get_HasTensorHeight(){} // RVA: 0x5A5F650
        public void ClearTensorHeight(){} // RVA: 0x5A5F660
        public void get_NumLayers(){} // RVA: 0x5B30760
        public void set_NumLayers(){} // RVA: 0x5B307D0
        public void get_HasNumLayers(){} // RVA: 0x5A5FC10
        public void ClearNumLayers(){} // RVA: 0x5A5FC20
        public void get_Strides(){} // RVA: 0x4976A0
        public void get_InterpolatedScaleAspectRatio(){} // RVA: 0x5B307E0
        public void set_InterpolatedScaleAspectRatio(){} // RVA: 0x5B30850
        public void get_HasInterpolatedScaleAspectRatio(){} // RVA: 0x5A5FE80
        public void ClearInterpolatedScaleAspectRatio(){} // RVA: 0x5A5FE90
        public void get_NumBoxes(){} // RVA: 0x5B30860
        public void set_NumBoxes(){} // RVA: 0x5B308D0
        public void get_HasNumBoxes(){} // RVA: 0x5AEC3A0
        public void ClearNumBoxes(){} // RVA: 0x5AEC3B0
        public void get_XScale(){} // RVA: 0x5B308E0
        public void set_XScale(){} // RVA: 0x5B30950
        public void get_HasXScale(){} // RVA: 0x5AEC440
        public void ClearXScale(){} // RVA: 0x5AEC450
        public void get_YScale(){} // RVA: 0x5B30960
        public void set_YScale(){} // RVA: 0x5B309D0
        public void get_HasYScale(){} // RVA: 0x5AEC020
        public void ClearYScale(){} // RVA: 0x5AEC030
        public void get_WScale(){} // RVA: 0x5B309E0
        public void set_WScale(){} // RVA: 0x5B30A50
        public void get_HasWScale(){} // RVA: 0x5AEC0C0
        public void ClearWScale(){} // RVA: 0x5AEC0D0
        public void get_HScale(){} // RVA: 0x5B30A60
        public void set_HScale(){} // RVA: 0x5B30AD0
        public void get_HasHScale(){} // RVA: 0x5AEC160
        public void ClearHScale(){} // RVA: 0x5AEC170
        public void get_MinScoreThresh(){} // RVA: 0x5B30AE0
        public void set_MinScoreThresh(){} // RVA: 0x5B30B50
        public void get_HasMinScoreThresh(){} // RVA: 0x5AEC200
        public void ClearMinScoreThresh(){} // RVA: 0x5AEC210
        public void get_Delegate(){} // RVA: 0x37B370
        public void set_Delegate(){} // RVA: 0x37B380
        public void Equals(){} // RVA: 0x5B30BC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B30FF0
        public void ToString(){} // RVA: 0x5B31320
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B31370
        public void CalculateSize(){} // RVA: 0x5B31680
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B31C60
        public void .cctor(){} // RVA: 0x5B31FC0
    }

    public class FaceDetectionReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B2F320
        public void .cctor(){} // RVA: 0x5B2F380
    }

    public class FlowLimiterCalculatorOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.FlowLimiterCalculatorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int MaxInFlightDefaultValue; // 0x8
        public int maxInFlight_; // 0x1C
        public int MaxInQueueDefaultValue; // 0xC
        public int maxInQueue_; // 0x20
        public long InFlightTimeoutDefaultValue; // 0x10
        public long inFlightTimeout_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5AE0AE0
        public void get_Descriptor(){} // RVA: 0x5AE0B40
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AE0C00
        public void .ctor(){} // RVA: 0x5AE0CF0 | overloaded x2
        public void Clone(){} // RVA: 0x5AE0DF0
        public void get_MaxInFlight(){} // RVA: 0x5AE0F20
        public void set_MaxInFlight(){} // RVA: 0x5A5C3A0
        public void get_HasMaxInFlight(){} // RVA: 0x5A5C3B0
        public void ClearMaxInFlight(){} // RVA: 0x5A5C3C0
        public void get_MaxInQueue(){} // RVA: 0x5AE0F90
        public void set_MaxInQueue(){} // RVA: 0x5A5C440
        public void get_HasMaxInQueue(){} // RVA: 0x5A5C450
        public void ClearMaxInQueue(){} // RVA: 0x5A5C460
        public void get_InFlightTimeout(){} // RVA: 0x5AE1000
        public void set_InFlightTimeout(){} // RVA: 0x5AE1070
        public void get_HasInFlightTimeout(){} // RVA: 0x5A5F650
        public void ClearInFlightTimeout(){} // RVA: 0x5A5F660
        public void Equals(){} // RVA: 0x5AE11A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5AE1280
        public void ToString(){} // RVA: 0x5AE1310
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AE1360
        public void CalculateSize(){} // RVA: 0x5AE1410
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AE1680
        public void .cctor(){} // RVA: 0x5AE1740
    }

    public class FlowLimiterCalculatorReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5AE0310
        public void .cctor(){} // RVA: 0x5AE0370
    }

}