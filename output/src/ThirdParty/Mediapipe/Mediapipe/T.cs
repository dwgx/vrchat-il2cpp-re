// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 6
// Methods: 135

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class TensorsToDetectionsCalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.TensorsToDetectionsCalculatorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int NumClassesDefaultValue; // 0x8
        public int numClasses_; // 0x1C
        public int NumBoxesDefaultValue; // 0xC
        public int numBoxes_; // 0x20
        public int NumCoordsDefaultValue; // 0x10
        public int numCoords_; // 0x24
        public int KeypointCoordOffsetDefaultValue; // 0x14
        public int keypointCoordOffset_; // 0x28
        public int NumKeypointsDefaultValue; // 0x18
        public int numKeypoints_; // 0x2C
        public int NumValuesPerKeypointDefaultValue; // 0x1C
        public int numValuesPerKeypoint_; // 0x30
        public int BoxCoordOffsetDefaultValue; // 0x20
        public int boxCoordOffset_; // 0x34
        public float XScaleDefaultValue; // 0x24
        public float xScale_; // 0x38
        public float YScaleDefaultValue; // 0x28
        public float yScale_; // 0x3C
        public float WScaleDefaultValue; // 0x2C
        public float wScale_; // 0x40
        public float HScaleDefaultValue; // 0x30
        public float hScale_; // 0x44
        public bool ApplyExponentialOnBoxSizeDefaultValue; // 0x34
        public bool applyExponentialOnBoxSize_; // 0x48
        public bool ReverseOutputOrderDefaultValue; // 0x35
        public bool reverseOutputOrder_; // 0x49
        public Google.Protobuf.FieldCodec`1<int> _repeated_ignoreClasses_codec; // 0x38
        public Google.Protobuf.Collections.RepeatedField`1<int> ignoreClasses_; // 0x50
        public Google.Protobuf.FieldCodec`1<int> _repeated_allowClasses_codec; // 0x40
        public Google.Protobuf.Collections.RepeatedField`1<int> allowClasses_; // 0x58
        public bool SigmoidScoreDefaultValue; // 0x48
        public bool sigmoidScore_; // 0x60
        public float ScoreClippingThreshDefaultValue; // 0x4C
        public float scoreClippingThresh_; // 0x64
        public bool FlipVerticallyDefaultValue; // 0x50
        public bool flipVertically_; // 0x68
        public float MinScoreThreshDefaultValue; // 0x54
        public float minScoreThresh_; // 0x6C
        public int MaxResultsDefaultValue; // 0x58
        public int maxResults_; // 0x70
        public TensorMapping tensorMapping_; // 0x78
        public 0x6660A81C BoxFormatDefaultValue; // 0x5C
        public 0x6660A81C boxFormat_; // 0x80

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8662C3F0
        public void get_Descriptor(){} // RVA: 0x7FFE8662C450
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8662C510
        public void .ctor(){} // RVA: 0x7FFE8662C6A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8662CC10
        public void get_NumClasses(){} // RVA: 0x7FFE8662CC70
        public void set_NumClasses(){} // RVA: 0x7FFE8659D0A0
        public void get_HasNumClasses(){} // RVA: 0x7FFE8659D0B0
        public void ClearNumClasses(){} // RVA: 0x7FFE8659D0C0
        public void get_NumBoxes(){} // RVA: 0x7FFE8662CCE0
        public void set_NumBoxes(){} // RVA: 0x7FFE8659D140
        public void get_HasNumBoxes(){} // RVA: 0x7FFE8659D150
        public void ClearNumBoxes(){} // RVA: 0x7FFE8659D160
        public void get_NumCoords(){} // RVA: 0x7FFE8662CD50
        public void set_NumCoords(){} // RVA: 0x7FFE8662CDC0
        public void get_HasNumCoords(){} // RVA: 0x7FFE865A0350
        public void ClearNumCoords(){} // RVA: 0x7FFE865A0360
        public void get_KeypointCoordOffset(){} // RVA: 0x7FFE8662CDD0
        public void set_KeypointCoordOffset(){} // RVA: 0x7FFE8662CE40
        public void get_HasKeypointCoordOffset(){} // RVA: 0x7FFE8662CE50
        public void ClearKeypointCoordOffset(){} // RVA: 0x7FFE8662CE60
        public void get_NumKeypoints(){} // RVA: 0x7FFE8662CE70
        public void set_NumKeypoints(){} // RVA: 0x7FFE8662CEE0
        public void get_HasNumKeypoints(){} // RVA: 0x7FFE8662CEF0
        public void ClearNumKeypoints(){} // RVA: 0x7FFE8662CF00
        public void get_NumValuesPerKeypoint(){} // RVA: 0x7FFE8662CF10
        public void set_NumValuesPerKeypoint(){} // RVA: 0x7FFE8662CF80
        public void get_HasNumValuesPerKeypoint(){} // RVA: 0x7FFE8662CF90
        public void ClearNumValuesPerKeypoint(){} // RVA: 0x7FFE8662CFA0
        public void get_BoxCoordOffset(){} // RVA: 0x7FFE8662CFB0
        public void set_BoxCoordOffset(){} // RVA: 0x7FFE8662D020
        public void get_HasBoxCoordOffset(){} // RVA: 0x7FFE8662D030
        public void ClearBoxCoordOffset(){} // RVA: 0x7FFE8662D040
        public void get_XScale(){} // RVA: 0x7FFE8662D050
        public void set_XScale(){} // RVA: 0x7FFE8662D0C0
        public void get_HasXScale(){} // RVA: 0x7FFE865A0910
        public void ClearXScale(){} // RVA: 0x7FFE865A0920
        public void get_YScale(){} // RVA: 0x7FFE8662D0D0
        public void set_YScale(){} // RVA: 0x7FFE8662D140
        public void get_HasYScale(){} // RVA: 0x7FFE865A0B80
        public void ClearYScale(){} // RVA: 0x7FFE865A0B90
        public void get_WScale(){} // RVA: 0x7FFE8662D150
        public void set_WScale(){} // RVA: 0x7FFE8662D1C0
        public void get_HasWScale(){} // RVA: 0x7FFE8662D1D0
        public void ClearWScale(){} // RVA: 0x7FFE8662D1E0
        public void get_HScale(){} // RVA: 0x7FFE8662D1F0
        public void set_HScale(){} // RVA: 0x7FFE8662D260
        public void get_HasHScale(){} // RVA: 0x7FFE8662D270
        public void ClearHScale(){} // RVA: 0x7FFE8662D280
        public void get_ApplyExponentialOnBoxSize(){} // RVA: 0x7FFE8662D290
        public void set_ApplyExponentialOnBoxSize(){} // RVA: 0x7FFE8662D300
        public void get_HasApplyExponentialOnBoxSize(){} // RVA: 0x7FFE8662D310
        public void ClearApplyExponentialOnBoxSize(){} // RVA: 0x7FFE8662D320
        public void get_ReverseOutputOrder(){} // RVA: 0x7FFE8662D330
        public void set_ReverseOutputOrder(){} // RVA: 0x7FFE8662D3A0
        public void get_HasReverseOutputOrder(){} // RVA: 0x7FFE8662D3B0
        public void ClearReverseOutputOrder(){} // RVA: 0x7FFE8662D3C0
        public void get_IgnoreClasses(){} // RVA: 0x7FFE8119C0E0
        public void get_AllowClasses(){} // RVA: 0x7FFE811C3500
        public void get_SigmoidScore(){} // RVA: 0x7FFE8662D3D0
        public void set_SigmoidScore(){} // RVA: 0x7FFE8662D440
        public void get_HasSigmoidScore(){} // RVA: 0x7FFE8662D450
        public void ClearSigmoidScore(){} // RVA: 0x7FFE8662D460
        public void get_ScoreClippingThresh(){} // RVA: 0x7FFE8662D470
        public void set_ScoreClippingThresh(){} // RVA: 0x7FFE8662D4E0
        public void get_HasScoreClippingThresh(){} // RVA: 0x7FFE8662D4F0
        public void ClearScoreClippingThresh(){} // RVA: 0x7FFE8662D500
        public void get_FlipVertically(){} // RVA: 0x7FFE8662D510
        public void set_FlipVertically(){} // RVA: 0x7FFE8662D580
        public void get_HasFlipVertically(){} // RVA: 0x7FFE8662D590
        public void ClearFlipVertically(){} // RVA: 0x7FFE8662D5A0
        public void get_MinScoreThresh(){} // RVA: 0x7FFE8662D5B0
        public void set_MinScoreThresh(){} // RVA: 0x7FFE8662D620
        public void get_HasMinScoreThresh(){} // RVA: 0x7FFE8662D630
        public void ClearMinScoreThresh(){} // RVA: 0x7FFE8662D640
        public void get_MaxResults(){} // RVA: 0x7FFE8662D650
        public void set_MaxResults(){} // RVA: 0x7FFE8662D6C0
        public void get_HasMaxResults(){} // RVA: 0x7FFE8662D6D0
        public void ClearMaxResults(){} // RVA: 0x7FFE8662D6E0
        public void get_TensorMapping(){} // RVA: 0x7FFE81463AE0
        public void set_TensorMapping(){} // RVA: 0x7FFE81464570
        public void get_BoxBoundariesIndices(){} // RVA: 0x7FFE8662D6F0
        public void set_BoxBoundariesIndices(){} // RVA: 0x7FFE8662D750
        public void get_BoxFormat(){} // RVA: 0x7FFE8662D7C0
        public void set_BoxFormat(){} // RVA: 0x7FFE8662D830
        public void get_HasBoxFormat(){} // RVA: 0x7FFE8662D840
        public void ClearBoxFormat(){} // RVA: 0x7FFE8662D850
        public void get_BoxIndicesCase(){} // RVA: 0x7FFE814AA220
        public void ClearBoxIndices(){} // RVA: 0x7FFE8662D860
        public void Equals(){} // RVA: 0x7FFE8662D930 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8662DE80
        public void ToString(){} // RVA: 0x7FFE8662E300
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8662E350
        public void CalculateSize(){} // RVA: 0x7FFE8662E800
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8662F180
        public void .cctor(){} // RVA: 0x7FFE8662F6C0
    }

    public class TensorsToDetectionsCalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8662B0B0
        public void .cctor(){} // RVA: 0x7FFE8662B110
    }

    public class TextureFormatExtension : Object
    {
        // ── Methods ──
        public void ToImageFormat(){} // RVA: 0x7FFE866733F0
    }

    public class ThresholdingCalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ThresholdingCalculatorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public double ThresholdDefaultValue; // 0x8
        public double threshold_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86632510
        public void get_Descriptor(){} // RVA: 0x7FFE86632570
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86632630
        public void .ctor(){} // RVA: 0x7FFE86632720 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86632810
        public void get_Threshold(){} // RVA: 0x7FFE86632930
        public void set_Threshold(){} // RVA: 0x7FFE866329A0
        public void get_HasThreshold(){} // RVA: 0x7FFE8659D0B0
        public void ClearThreshold(){} // RVA: 0x7FFE8659D0C0
        public void Equals(){} // RVA: 0x7FFE86632AE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86632BE0
        public void ToString(){} // RVA: 0x7FFE86632CA0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86632CF0
        public void CalculateSize(){} // RVA: 0x7FFE86632D50
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86632E90
        public void .cctor(){} // RVA: 0x7FFE86632F20
    }

    public class ThresholdingCalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86631E00
        public void .cctor(){} // RVA: 0x7FFE86631E60
    }

    public class Tool : Object
    {
        // ── Methods ──
        public void GetUnusedSidePacketName(){} // RVA: 0x7FFE86619E80
        public void ParseNameFromStream(){} // RVA: 0x7FFE8661A2A0
        public void ValidateName(){} // RVA: 0x7FFE8661A320
        public void ValidateNumber(){} // RVA: 0x7FFE8661A460
        public void ValidateTag(){} // RVA: 0x7FFE8661A5A0
        public void ParseTagAndName(){} // RVA: 0x7FFE8661A6E0
        public void ParseTagIndexName(){} // RVA: 0x7FFE8661AAA0
        public void .cctor(){} // RVA: 0x7FFE8661B090
    }

}