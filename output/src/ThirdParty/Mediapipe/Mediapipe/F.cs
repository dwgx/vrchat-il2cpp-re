// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 4
// Methods: 101

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class FaceDetectionOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.FaceDetectionOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public string ModelPathDefaultValue; // 0x8
        public string modelPath_; // 0x20
        public 0x6660D15C GpuOriginDefaultValue; // 0x10
        public 0x6660D15C gpuOrigin_; // 0x28
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
        public void get_Parser(){} // RVA: 0x7FFE86670CD0
        public void get_Descriptor(){} // RVA: 0x7FFE86670D30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86670DF0
        public void .ctor(){} // RVA: 0x7FFE86670FA0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86671270
        public void get_ModelPath(){} // RVA: 0x7FFE866712D0
        public void set_ModelPath(){} // RVA: 0x7FFE86671340
        public void get_HasModelPath(){} // RVA: 0x7FFE82BC81D0
        public void ClearModelPath(){} // RVA: 0x7FFE86597DC0
        public void get_GpuOrigin(){} // RVA: 0x7FFE86671440
        public void set_GpuOrigin(){} // RVA: 0x7FFE865A0240
        public void get_HasGpuOrigin(){} // RVA: 0x7FFE8659D0B0
        public void ClearGpuOrigin(){} // RVA: 0x7FFE8659D0C0
        public void get_TensorWidth(){} // RVA: 0x7FFE866714B0
        public void set_TensorWidth(){} // RVA: 0x7FFE865A02C0
        public void get_HasTensorWidth(){} // RVA: 0x7FFE8659D150
        public void ClearTensorWidth(){} // RVA: 0x7FFE8659D160
        public void get_TensorHeight(){} // RVA: 0x7FFE86671520
        public void set_TensorHeight(){} // RVA: 0x7FFE865A0340
        public void get_HasTensorHeight(){} // RVA: 0x7FFE865A0350
        public void ClearTensorHeight(){} // RVA: 0x7FFE865A0360
        public void get_NumLayers(){} // RVA: 0x7FFE86671590
        public void set_NumLayers(){} // RVA: 0x7FFE86671600
        public void get_HasNumLayers(){} // RVA: 0x7FFE865A0910
        public void ClearNumLayers(){} // RVA: 0x7FFE865A0920
        public void get_Strides(){} // RVA: 0x7FFE8143BA80
        public void get_InterpolatedScaleAspectRatio(){} // RVA: 0x7FFE86671610
        public void set_InterpolatedScaleAspectRatio(){} // RVA: 0x7FFE86671680
        public void get_HasInterpolatedScaleAspectRatio(){} // RVA: 0x7FFE865A0B80
        public void ClearInterpolatedScaleAspectRatio(){} // RVA: 0x7FFE865A0B90
        public void get_NumBoxes(){} // RVA: 0x7FFE86671690
        public void set_NumBoxes(){} // RVA: 0x7FFE86671700
        public void get_HasNumBoxes(){} // RVA: 0x7FFE8662D1D0
        public void ClearNumBoxes(){} // RVA: 0x7FFE8662D1E0
        public void get_XScale(){} // RVA: 0x7FFE86671710
        public void set_XScale(){} // RVA: 0x7FFE86671780
        public void get_HasXScale(){} // RVA: 0x7FFE8662D270
        public void ClearXScale(){} // RVA: 0x7FFE8662D280
        public void get_YScale(){} // RVA: 0x7FFE86671790
        public void set_YScale(){} // RVA: 0x7FFE86671800
        public void get_HasYScale(){} // RVA: 0x7FFE8662CE50
        public void ClearYScale(){} // RVA: 0x7FFE8662CE60
        public void get_WScale(){} // RVA: 0x7FFE86671810
        public void set_WScale(){} // RVA: 0x7FFE86671880
        public void get_HasWScale(){} // RVA: 0x7FFE8662CEF0
        public void ClearWScale(){} // RVA: 0x7FFE8662CF00
        public void get_HScale(){} // RVA: 0x7FFE86671890
        public void set_HScale(){} // RVA: 0x7FFE86671900
        public void get_HasHScale(){} // RVA: 0x7FFE8662CF90
        public void ClearHScale(){} // RVA: 0x7FFE8662CFA0
        public void get_MinScoreThresh(){} // RVA: 0x7FFE86671910
        public void set_MinScoreThresh(){} // RVA: 0x7FFE86671980
        public void get_HasMinScoreThresh(){} // RVA: 0x7FFE8662D030
        public void ClearMinScoreThresh(){} // RVA: 0x7FFE8662D040
        public void get_Delegate(){} // RVA: 0x7FFE81199370
        public void set_Delegate(){} // RVA: 0x7FFE81199380
        public void Equals(){} // RVA: 0x7FFE866719F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86671E20
        public void ToString(){} // RVA: 0x7FFE86672150
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866721A0
        public void CalculateSize(){} // RVA: 0x7FFE866724B0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86672A90
        public void .cctor(){} // RVA: 0x7FFE86672DF0
    }

    public class FaceDetectionReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86670150
        public void .cctor(){} // RVA: 0x7FFE866701B0
    }

    public class FlowLimiterCalculatorOptions : Object
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
        public void get_Parser(){} // RVA: 0x7FFE86621910
        public void get_Descriptor(){} // RVA: 0x7FFE86621970
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86621A30
        public void .ctor(){} // RVA: 0x7FFE86621B20 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86621C20
        public void get_MaxInFlight(){} // RVA: 0x7FFE86621D50
        public void set_MaxInFlight(){} // RVA: 0x7FFE8659D0A0
        public void get_HasMaxInFlight(){} // RVA: 0x7FFE8659D0B0
        public void ClearMaxInFlight(){} // RVA: 0x7FFE8659D0C0
        public void get_MaxInQueue(){} // RVA: 0x7FFE86621DC0
        public void set_MaxInQueue(){} // RVA: 0x7FFE8659D140
        public void get_HasMaxInQueue(){} // RVA: 0x7FFE8659D150
        public void ClearMaxInQueue(){} // RVA: 0x7FFE8659D160
        public void get_InFlightTimeout(){} // RVA: 0x7FFE86621E30
        public void set_InFlightTimeout(){} // RVA: 0x7FFE86621EA0
        public void get_HasInFlightTimeout(){} // RVA: 0x7FFE865A0350
        public void ClearInFlightTimeout(){} // RVA: 0x7FFE865A0360
        public void Equals(){} // RVA: 0x7FFE86621FD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE866220B0
        public void ToString(){} // RVA: 0x7FFE86622140
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86622190
        public void CalculateSize(){} // RVA: 0x7FFE86622240
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866224B0
        public void .cctor(){} // RVA: 0x7FFE86622570
    }

    public class FlowLimiterCalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86621140
        public void .cctor(){} // RVA: 0x7FFE866211A0
    }

}