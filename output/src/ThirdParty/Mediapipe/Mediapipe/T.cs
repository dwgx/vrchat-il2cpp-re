// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 6
// Methods: 135

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class TensorsToDetectionsCalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.TensorsToDetectionsCalculatorOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int NumClasses; // 0x8
        public int HasNumClasses; // 0x1C
        public int NumBoxes; // 0xC
        public int HasNumBoxes; // 0x20
        public int NumCoords; // 0x10
        public int HasNumCoords; // 0x24
        public int KeypointCoordOffset; // 0x14
        public int HasKeypointCoordOffset; // 0x28
        public int NumKeypoints; // 0x18
        public int HasNumKeypoints; // 0x2C
        public int NumValuesPerKeypoint; // 0x1C
        public int HasNumValuesPerKeypoint; // 0x30
        public int BoxCoordOffset; // 0x20
        public int HasBoxCoordOffset; // 0x34
        public float XScale; // 0x24
        public float HasXScale; // 0x38
        public float YScale; // 0x28
        public float HasYScale; // 0x3C
        public float WScale; // 0x2C
        public float HasWScale; // 0x40
        public float HScale; // 0x30
        public float HasHScale; // 0x44
        public bool ApplyExponentialOnBoxSize; // 0x34
        public bool HasApplyExponentialOnBoxSize; // 0x48
        public bool ReverseOutputOrder; // 0x35
        public bool HasReverseOutputOrder; // 0x49
        public Google.Protobuf.FieldCodec`1<int> IgnoreClasses; // 0x38
        public Google.Protobuf.Collections.RepeatedField`1<int> AllowClasses; // 0x50
        public Google.Protobuf.FieldCodec`1<int> SigmoidScore; // 0x40
        public Google.Protobuf.Collections.RepeatedField`1<int> HasSigmoidScore; // 0x58
        public bool ScoreClippingThresh; // 0x48
        public bool HasScoreClippingThresh; // 0x60
        public float FlipVertically; // 0x4C
        public float HasFlipVertically; // 0x64
        public bool MinScoreThresh; // 0x50
        public bool HasMinScoreThresh; // 0x68
        public float MaxResults; // 0x54
        public float HasMaxResults; // 0x6C
        public int TensorMapping; // 0x58
        public int BoxBoundariesIndices; // 0x70
        public TensorMapping BoxFormat; // 0x78
        public 0x6B210F58 HasBoxFormat; // 0x5C
        public 0x6B210F58 BoxIndicesCase; // 0x80
        public object boxIndices_; // 0x88
        public 0x6B210F00 boxIndicesCase_; // 0x90

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8282AD0
        public void get_Descriptor(){} // RVA: 0x7FFAC8282B30
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8282BF0
        public void .ctor(){} // RVA: 0x7FFAC8282D80 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82832F0
        public void get_NumClasses(){} // RVA: 0x7FFAC8283350
        public void set_NumClasses(){} // RVA: 0x7FFAC81F3760
        public void get_HasNumClasses(){} // RVA: 0x7FFAC81F3770
        public void ClearNumClasses(){} // RVA: 0x7FFAC81F3780
        public void get_NumBoxes(){} // RVA: 0x7FFAC82833C0
        public void set_NumBoxes(){} // RVA: 0x7FFAC81F3800
        public void get_HasNumBoxes(){} // RVA: 0x7FFAC81F3810
        public void ClearNumBoxes(){} // RVA: 0x7FFAC81F3820
        public void get_NumCoords(){} // RVA: 0x7FFAC8283430
        public void set_NumCoords(){} // RVA: 0x7FFAC82834A0
        public void get_HasNumCoords(){} // RVA: 0x7FFAC81F6A10
        public void ClearNumCoords(){} // RVA: 0x7FFAC81F6A20
        public void get_KeypointCoordOffset(){} // RVA: 0x7FFAC82834B0
        public void set_KeypointCoordOffset(){} // RVA: 0x7FFAC8283520
        public void get_HasKeypointCoordOffset(){} // RVA: 0x7FFAC8283530
        public void ClearKeypointCoordOffset(){} // RVA: 0x7FFAC8283540
        public void get_NumKeypoints(){} // RVA: 0x7FFAC8283550
        public void set_NumKeypoints(){} // RVA: 0x7FFAC82835C0
        public void get_HasNumKeypoints(){} // RVA: 0x7FFAC82835D0
        public void ClearNumKeypoints(){} // RVA: 0x7FFAC82835E0
        public void get_NumValuesPerKeypoint(){} // RVA: 0x7FFAC82835F0
        public void set_NumValuesPerKeypoint(){} // RVA: 0x7FFAC8283660
        public void get_HasNumValuesPerKeypoint(){} // RVA: 0x7FFAC8283670
        public void ClearNumValuesPerKeypoint(){} // RVA: 0x7FFAC8283680
        public void get_BoxCoordOffset(){} // RVA: 0x7FFAC8283690
        public void set_BoxCoordOffset(){} // RVA: 0x7FFAC8283700
        public void get_HasBoxCoordOffset(){} // RVA: 0x7FFAC8283710
        public void ClearBoxCoordOffset(){} // RVA: 0x7FFAC8283720
        public void get_XScale(){} // RVA: 0x7FFAC8283730
        public void set_XScale(){} // RVA: 0x7FFAC82837A0
        public void get_HasXScale(){} // RVA: 0x7FFAC81F6FD0
        public void ClearXScale(){} // RVA: 0x7FFAC81F6FE0
        public void get_YScale(){} // RVA: 0x7FFAC82837B0
        public void set_YScale(){} // RVA: 0x7FFAC8283820
        public void get_HasYScale(){} // RVA: 0x7FFAC81F7240
        public void ClearYScale(){} // RVA: 0x7FFAC81F7250
        public void get_WScale(){} // RVA: 0x7FFAC8283830
        public void set_WScale(){} // RVA: 0x7FFAC82838A0
        public void get_HasWScale(){} // RVA: 0x7FFAC82838B0
        public void ClearWScale(){} // RVA: 0x7FFAC82838C0
        public void get_HScale(){} // RVA: 0x7FFAC82838D0
        public void set_HScale(){} // RVA: 0x7FFAC8283940
        public void get_HasHScale(){} // RVA: 0x7FFAC8283950
        public void ClearHScale(){} // RVA: 0x7FFAC8283960
        public void get_ApplyExponentialOnBoxSize(){} // RVA: 0x7FFAC8283970
        public void set_ApplyExponentialOnBoxSize(){} // RVA: 0x7FFAC82839E0
        public void get_HasApplyExponentialOnBoxSize(){} // RVA: 0x7FFAC82839F0
        public void ClearApplyExponentialOnBoxSize(){} // RVA: 0x7FFAC8283A00
        public void get_ReverseOutputOrder(){} // RVA: 0x7FFAC8283A10
        public void set_ReverseOutputOrder(){} // RVA: 0x7FFAC8283A80
        public void get_HasReverseOutputOrder(){} // RVA: 0x7FFAC8283A90
        public void ClearReverseOutputOrder(){} // RVA: 0x7FFAC8283AA0
        public void get_IgnoreClasses(){} // RVA: 0x7FFAC2FC20E0
        public void get_AllowClasses(){} // RVA: 0x7FFAC2FE9500
        public void get_SigmoidScore(){} // RVA: 0x7FFAC8283AB0
        public void set_SigmoidScore(){} // RVA: 0x7FFAC8283B20
        public void get_HasSigmoidScore(){} // RVA: 0x7FFAC8283B30
        public void ClearSigmoidScore(){} // RVA: 0x7FFAC8283B40
        public void get_ScoreClippingThresh(){} // RVA: 0x7FFAC8283B50
        public void set_ScoreClippingThresh(){} // RVA: 0x7FFAC8283BC0
        public void get_HasScoreClippingThresh(){} // RVA: 0x7FFAC8283BD0
        public void ClearScoreClippingThresh(){} // RVA: 0x7FFAC8283BE0
        public void get_FlipVertically(){} // RVA: 0x7FFAC8283BF0
        public void set_FlipVertically(){} // RVA: 0x7FFAC8283C60
        public void get_HasFlipVertically(){} // RVA: 0x7FFAC8283C70
        public void ClearFlipVertically(){} // RVA: 0x7FFAC8283C80
        public void get_MinScoreThresh(){} // RVA: 0x7FFAC8283C90
        public void set_MinScoreThresh(){} // RVA: 0x7FFAC8283D00
        public void get_HasMinScoreThresh(){} // RVA: 0x7FFAC8283D10
        public void ClearMinScoreThresh(){} // RVA: 0x7FFAC8283D20
        public void get_MaxResults(){} // RVA: 0x7FFAC8283D30
        public void set_MaxResults(){} // RVA: 0x7FFAC8283DA0
        public void get_HasMaxResults(){} // RVA: 0x7FFAC8283DB0
        public void ClearMaxResults(){} // RVA: 0x7FFAC8283DC0
        public void get_TensorMapping(){} // RVA: 0x7FFAC30E5600
        public void set_TensorMapping(){} // RVA: 0x7FFAC30E06F0
        public void get_BoxBoundariesIndices(){} // RVA: 0x7FFAC8283DD0
        public void set_BoxBoundariesIndices(){} // RVA: 0x7FFAC8283E30
        public void get_BoxFormat(){} // RVA: 0x7FFAC8283EA0
        public void set_BoxFormat(){} // RVA: 0x7FFAC8283F10
        public void get_HasBoxFormat(){} // RVA: 0x7FFAC8283F20
        public void ClearBoxFormat(){} // RVA: 0x7FFAC8283F30
        public void get_BoxIndicesCase(){} // RVA: 0x7FFAC3220660
        public void ClearBoxIndices(){} // RVA: 0x7FFAC8283F40
        public void Equals(){} // RVA: 0x7FFAC8284010 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8284560
        public void ToString(){} // RVA: 0x7FFAC82849E0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8284A30
        public void CalculateSize(){} // RVA: 0x7FFAC8284EE0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8285860
        public void .cctor(){} // RVA: 0x7FFAC8285DA0
    }

    public class TensorsToDetectionsCalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8281790
        public void .cctor(){} // RVA: 0x7FFAC82817F0
    }

    public class TextureFormatExtension : Object
    {
        // ── Methods ──
        public void ToImageFormat(){} // RVA: 0x7FFAC82C9AD0
    }

    public class ThresholdingCalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.ThresholdingCalculatorOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public double Threshold; // 0x8
        public double HasThreshold; // 0x20

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8288BF0
        public void get_Descriptor(){} // RVA: 0x7FFAC8288C50
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8288D10
        public void .ctor(){} // RVA: 0x7FFAC8288E00 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8288EF0
        public void get_Threshold(){} // RVA: 0x7FFAC8289010
        public void set_Threshold(){} // RVA: 0x7FFAC8289080
        public void get_HasThreshold(){} // RVA: 0x7FFAC81F3770
        public void ClearThreshold(){} // RVA: 0x7FFAC81F3780
        public void Equals(){} // RVA: 0x7FFAC82891C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82892C0
        public void ToString(){} // RVA: 0x7FFAC8289380
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82893D0
        public void CalculateSize(){} // RVA: 0x7FFAC8289430
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8289570
        public void .cctor(){} // RVA: 0x7FFAC8289600
    }

    public class ThresholdingCalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82884E0
        public void .cctor(){} // RVA: 0x7FFAC8288540
    }

    public class Tool : Object
    {
        public string _TagAndNameRegex;
        public string _TagIndexNameRegex; // 0x8
        public string _TagIndexRegex; // 0x10

        // ── Methods ──
        public void GetUnusedSidePacketName(){} // RVA: 0x7FFAC8270560
        public void ParseNameFromStream(){} // RVA: 0x7FFAC8270980
        public void ValidateName(){} // RVA: 0x7FFAC8270A00
        public void ValidateNumber(){} // RVA: 0x7FFAC8270B40
        public void ValidateTag(){} // RVA: 0x7FFAC8270C80
        public void ParseTagAndName(){} // RVA: 0x7FFAC8270DC0
        public void ParseTagIndexName(){} // RVA: 0x7FFAC8271180
        public void .cctor(){} // RVA: 0x7FFAC8271770
    }

}