// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 6
// Methods: 135

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class TensorsToDetectionsCalculatorOptions
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
        public 0x6592D110 BoxFormatDefaultValue; // 0x5C
        public 0x6592D110 boxFormat_; // 0x80

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5AEB5C0
        public void get_Descriptor(){} // RVA: 0x5AEB620
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AEB6E0
        public void .ctor(){} // RVA: 0x5AEB870 | overloaded x2
        public void Clone(){} // RVA: 0x5AEBDE0
        public void get_NumClasses(){} // RVA: 0x5AEBE40
        public void set_NumClasses(){} // RVA: 0x5A5C3A0
        public void get_HasNumClasses(){} // RVA: 0x5A5C3B0
        public void ClearNumClasses(){} // RVA: 0x5A5C3C0
        public void get_NumBoxes(){} // RVA: 0x5AEBEB0
        public void set_NumBoxes(){} // RVA: 0x5A5C440
        public void get_HasNumBoxes(){} // RVA: 0x5A5C450
        public void ClearNumBoxes(){} // RVA: 0x5A5C460
        public void get_NumCoords(){} // RVA: 0x5AEBF20
        public void set_NumCoords(){} // RVA: 0x5AEBF90
        public void get_HasNumCoords(){} // RVA: 0x5A5F650
        public void ClearNumCoords(){} // RVA: 0x5A5F660
        public void get_KeypointCoordOffset(){} // RVA: 0x5AEBFA0
        public void set_KeypointCoordOffset(){} // RVA: 0x5AEC010
        public void get_HasKeypointCoordOffset(){} // RVA: 0x5AEC020
        public void ClearKeypointCoordOffset(){} // RVA: 0x5AEC030
        public void get_NumKeypoints(){} // RVA: 0x5AEC040
        public void set_NumKeypoints(){} // RVA: 0x5AEC0B0
        public void get_HasNumKeypoints(){} // RVA: 0x5AEC0C0
        public void ClearNumKeypoints(){} // RVA: 0x5AEC0D0
        public void get_NumValuesPerKeypoint(){} // RVA: 0x5AEC0E0
        public void set_NumValuesPerKeypoint(){} // RVA: 0x5AEC150
        public void get_HasNumValuesPerKeypoint(){} // RVA: 0x5AEC160
        public void ClearNumValuesPerKeypoint(){} // RVA: 0x5AEC170
        public void get_BoxCoordOffset(){} // RVA: 0x5AEC180
        public void set_BoxCoordOffset(){} // RVA: 0x5AEC1F0
        public void get_HasBoxCoordOffset(){} // RVA: 0x5AEC200
        public void ClearBoxCoordOffset(){} // RVA: 0x5AEC210
        public void get_XScale(){} // RVA: 0x5AEC220
        public void set_XScale(){} // RVA: 0x5AEC290
        public void get_HasXScale(){} // RVA: 0x5A5FC10
        public void ClearXScale(){} // RVA: 0x5A5FC20
        public void get_YScale(){} // RVA: 0x5AEC2A0
        public void set_YScale(){} // RVA: 0x5AEC310
        public void get_HasYScale(){} // RVA: 0x5A5FE80
        public void ClearYScale(){} // RVA: 0x5A5FE90
        public void get_WScale(){} // RVA: 0x5AEC320
        public void set_WScale(){} // RVA: 0x5AEC390
        public void get_HasWScale(){} // RVA: 0x5AEC3A0
        public void ClearWScale(){} // RVA: 0x5AEC3B0
        public void get_HScale(){} // RVA: 0x5AEC3C0
        public void set_HScale(){} // RVA: 0x5AEC430
        public void get_HasHScale(){} // RVA: 0x5AEC440
        public void ClearHScale(){} // RVA: 0x5AEC450
        public void get_ApplyExponentialOnBoxSize(){} // RVA: 0x5AEC460
        public void set_ApplyExponentialOnBoxSize(){} // RVA: 0x5AEC4D0
        public void get_HasApplyExponentialOnBoxSize(){} // RVA: 0x5AEC4E0
        public void ClearApplyExponentialOnBoxSize(){} // RVA: 0x5AEC4F0
        public void get_ReverseOutputOrder(){} // RVA: 0x5AEC500
        public void set_ReverseOutputOrder(){} // RVA: 0x5AEC570
        public void get_HasReverseOutputOrder(){} // RVA: 0x5AEC580
        public void ClearReverseOutputOrder(){} // RVA: 0x5AEC590
        public void get_IgnoreClasses(){} // RVA: 0x37E0E0
        public void get_AllowClasses(){} // RVA: 0x3A5500
        public void get_SigmoidScore(){} // RVA: 0x5AEC5A0
        public void set_SigmoidScore(){} // RVA: 0x5AEC610
        public void get_HasSigmoidScore(){} // RVA: 0x5AEC620
        public void ClearSigmoidScore(){} // RVA: 0x5AEC630
        public void get_ScoreClippingThresh(){} // RVA: 0x5AEC640
        public void set_ScoreClippingThresh(){} // RVA: 0x5AEC6B0
        public void get_HasScoreClippingThresh(){} // RVA: 0x5AEC6C0
        public void ClearScoreClippingThresh(){} // RVA: 0x5AEC6D0
        public void get_FlipVertically(){} // RVA: 0x5AEC6E0
        public void set_FlipVertically(){} // RVA: 0x5AEC750
        public void get_HasFlipVertically(){} // RVA: 0x5AEC760
        public void ClearFlipVertically(){} // RVA: 0x5AEC770
        public void get_MinScoreThresh(){} // RVA: 0x5AEC780
        public void set_MinScoreThresh(){} // RVA: 0x5AEC7F0
        public void get_HasMinScoreThresh(){} // RVA: 0x5AEC800
        public void ClearMinScoreThresh(){} // RVA: 0x5AEC810
        public void get_MaxResults(){} // RVA: 0x5AEC820
        public void set_MaxResults(){} // RVA: 0x5AEC890
        public void get_HasMaxResults(){} // RVA: 0x5AEC8A0
        public void ClearMaxResults(){} // RVA: 0x5AEC8B0
        public void get_TensorMapping(){} // RVA: 0x4C7C50
        public void set_TensorMapping(){} // RVA: 0x4C34F0
        public void get_BoxBoundariesIndices(){} // RVA: 0x5AEC8C0
        public void set_BoxBoundariesIndices(){} // RVA: 0x5AEC920
        public void get_BoxFormat(){} // RVA: 0x5AEC990
        public void set_BoxFormat(){} // RVA: 0x5AECA00
        public void get_HasBoxFormat(){} // RVA: 0x5AECA10
        public void ClearBoxFormat(){} // RVA: 0x5AECA20
        public void get_BoxIndicesCase(){} // RVA: 0x6AFD40
        public void ClearBoxIndices(){} // RVA: 0x5AECA30
        public void Equals(){} // RVA: 0x5AECB00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5AED050
        public void ToString(){} // RVA: 0x5AED4D0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AED520
        public void CalculateSize(){} // RVA: 0x5AED9D0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AEE350
        public void .cctor(){} // RVA: 0x5AEE890
    }

    public class TensorsToDetectionsCalculatorReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5AEA280
        public void .cctor(){} // RVA: 0x5AEA2E0
    }

    public class TextureFormatExtension
    {
        // ── Methods ──
        public void ToImageFormat(){} // RVA: 0x5B325C0
    }

    public class ThresholdingCalculatorOptions
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ThresholdingCalculatorOptions> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public double ThresholdDefaultValue; // 0x8
        public double threshold_; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5AF16E0
        public void get_Descriptor(){} // RVA: 0x5AF1740
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5AF1800
        public void .ctor(){} // RVA: 0x5AF18F0 | overloaded x2
        public void Clone(){} // RVA: 0x5AF19E0
        public void get_Threshold(){} // RVA: 0x5AF1B00
        public void set_Threshold(){} // RVA: 0x5AF1B70
        public void get_HasThreshold(){} // RVA: 0x5A5C3B0
        public void ClearThreshold(){} // RVA: 0x5A5C3C0
        public void Equals(){} // RVA: 0x5AF1CB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5AF1DB0
        public void ToString(){} // RVA: 0x5AF1E70
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5AF1EC0
        public void CalculateSize(){} // RVA: 0x5AF1F20
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5AF2060
        public void .cctor(){} // RVA: 0x5AF20F0
    }

    public class ThresholdingCalculatorReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor _descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5AF0FD0
        public void .cctor(){} // RVA: 0x5AF1030
    }

    public class Tool
    {
        // ── Methods ──
        public void GetUnusedSidePacketName(){} // RVA: 0x5AD9050
        public void ParseNameFromStream(){} // RVA: 0x5AD9470
        public void ValidateName(){} // RVA: 0x5AD94F0
        public void ValidateNumber(){} // RVA: 0x5AD9630
        public void ValidateTag(){} // RVA: 0x5AD9770
        public void ParseTagAndName(){} // RVA: 0x5AD98B0
        public void ParseTagIndexName(){} // RVA: 0x5AD9C70
        public void .cctor(){} // RVA: 0x5ADA260
    }

}