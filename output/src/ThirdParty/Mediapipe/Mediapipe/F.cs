// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 4
// Methods: 101

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class FaceDetectionOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.FaceDetectionOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public string ModelPath; // 0x8
        public string HasModelPath; // 0x20
        public 0x6B213898 GpuOrigin; // 0x10
        public 0x6B213898 HasGpuOrigin; // 0x28
        public int TensorWidth; // 0x14
        public int HasTensorWidth; // 0x2C
        public int TensorHeight; // 0x18
        public int HasTensorHeight; // 0x30
        public int NumLayers; // 0x1C
        public int HasNumLayers; // 0x34
        public Google.Protobuf.FieldCodec`1<int> Strides; // 0x20
        public Google.Protobuf.Collections.RepeatedField`1<int> InterpolatedScaleAspectRatio; // 0x38
        public float HasInterpolatedScaleAspectRatio; // 0x28
        public float NumBoxes; // 0x40
        public int HasNumBoxes; // 0x2C
        public int XScale; // 0x44
        public float HasXScale; // 0x30
        public float YScale; // 0x48
        public float HasYScale; // 0x34
        public float WScale; // 0x4C
        public float HasWScale; // 0x38
        public float HScale; // 0x50
        public float HasHScale; // 0x3C
        public float MinScoreThresh; // 0x54
        public float HasMinScoreThresh; // 0x40
        public float Delegate; // 0x58
        public Delegate delegate_; // 0x60

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82C73B0
        public void get_Descriptor(){} // RVA: 0x7FFAC82C7410
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82C74D0
        public void .ctor(){} // RVA: 0x7FFAC82C7680 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82C7950
        public void get_ModelPath(){} // RVA: 0x7FFAC82C79B0
        public void set_ModelPath(){} // RVA: 0x7FFAC82C7A20
        public void get_HasModelPath(){} // RVA: 0x7FFAC495C6A0
        public void ClearModelPath(){} // RVA: 0x7FFAC81EE480
        public void get_GpuOrigin(){} // RVA: 0x7FFAC82C7B20
        public void set_GpuOrigin(){} // RVA: 0x7FFAC81F6900
        public void get_HasGpuOrigin(){} // RVA: 0x7FFAC81F3770
        public void ClearGpuOrigin(){} // RVA: 0x7FFAC81F3780
        public void get_TensorWidth(){} // RVA: 0x7FFAC82C7B90
        public void set_TensorWidth(){} // RVA: 0x7FFAC81F6980
        public void get_HasTensorWidth(){} // RVA: 0x7FFAC81F3810
        public void ClearTensorWidth(){} // RVA: 0x7FFAC81F3820
        public void get_TensorHeight(){} // RVA: 0x7FFAC82C7C00
        public void set_TensorHeight(){} // RVA: 0x7FFAC81F6A00
        public void get_HasTensorHeight(){} // RVA: 0x7FFAC81F6A10
        public void ClearTensorHeight(){} // RVA: 0x7FFAC81F6A20
        public void get_NumLayers(){} // RVA: 0x7FFAC82C7C70
        public void set_NumLayers(){} // RVA: 0x7FFAC82C7CE0
        public void get_HasNumLayers(){} // RVA: 0x7FFAC81F6FD0
        public void ClearNumLayers(){} // RVA: 0x7FFAC81F6FE0
        public void get_Strides(){} // RVA: 0x7FFAC31D0140
        public void get_InterpolatedScaleAspectRatio(){} // RVA: 0x7FFAC82C7CF0
        public void set_InterpolatedScaleAspectRatio(){} // RVA: 0x7FFAC82C7D60
        public void get_HasInterpolatedScaleAspectRatio(){} // RVA: 0x7FFAC81F7240
        public void ClearInterpolatedScaleAspectRatio(){} // RVA: 0x7FFAC81F7250
        public void get_NumBoxes(){} // RVA: 0x7FFAC82C7D70
        public void set_NumBoxes(){} // RVA: 0x7FFAC82C7DE0
        public void get_HasNumBoxes(){} // RVA: 0x7FFAC82838B0
        public void ClearNumBoxes(){} // RVA: 0x7FFAC82838C0
        public void get_XScale(){} // RVA: 0x7FFAC82C7DF0
        public void set_XScale(){} // RVA: 0x7FFAC82C7E60
        public void get_HasXScale(){} // RVA: 0x7FFAC8283950
        public void ClearXScale(){} // RVA: 0x7FFAC8283960
        public void get_YScale(){} // RVA: 0x7FFAC82C7E70
        public void set_YScale(){} // RVA: 0x7FFAC82C7EE0
        public void get_HasYScale(){} // RVA: 0x7FFAC8283530
        public void ClearYScale(){} // RVA: 0x7FFAC8283540
        public void get_WScale(){} // RVA: 0x7FFAC82C7EF0
        public void set_WScale(){} // RVA: 0x7FFAC82C7F60
        public void get_HasWScale(){} // RVA: 0x7FFAC82835D0
        public void ClearWScale(){} // RVA: 0x7FFAC82835E0
        public void get_HScale(){} // RVA: 0x7FFAC82C7F70
        public void set_HScale(){} // RVA: 0x7FFAC82C7FE0
        public void get_HasHScale(){} // RVA: 0x7FFAC8283670
        public void ClearHScale(){} // RVA: 0x7FFAC8283680
        public void get_MinScoreThresh(){} // RVA: 0x7FFAC82C7FF0
        public void set_MinScoreThresh(){} // RVA: 0x7FFAC82C8060
        public void get_HasMinScoreThresh(){} // RVA: 0x7FFAC8283710
        public void ClearMinScoreThresh(){} // RVA: 0x7FFAC8283720
        public void get_Delegate(){} // RVA: 0x7FFAC2FBF370
        public void set_Delegate(){} // RVA: 0x7FFAC2FBF380
        public void Equals(){} // RVA: 0x7FFAC82C80D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82C8500
        public void ToString(){} // RVA: 0x7FFAC82C8830
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82C8880
        public void CalculateSize(){} // RVA: 0x7FFAC82C8B90
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82C9170
        public void .cctor(){} // RVA: 0x7FFAC82C94D0
    }

    public class FaceDetectionReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82C6830
        public void .cctor(){} // RVA: 0x7FFAC82C6890
    }

    public class FlowLimiterCalculatorOptions : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.FlowLimiterCalculatorOptions> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int MaxInFlight; // 0x8
        public int HasMaxInFlight; // 0x1C
        public int MaxInQueue; // 0xC
        public int HasMaxInQueue; // 0x20
        public long InFlightTimeout; // 0x10
        public long HasInFlightTimeout; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC8277FF0
        public void get_Descriptor(){} // RVA: 0x7FFAC8278050
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8278110
        public void .ctor(){} // RVA: 0x7FFAC8278200 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC8278300
        public void get_MaxInFlight(){} // RVA: 0x7FFAC8278430
        public void set_MaxInFlight(){} // RVA: 0x7FFAC81F3760
        public void get_HasMaxInFlight(){} // RVA: 0x7FFAC81F3770
        public void ClearMaxInFlight(){} // RVA: 0x7FFAC81F3780
        public void get_MaxInQueue(){} // RVA: 0x7FFAC82784A0
        public void set_MaxInQueue(){} // RVA: 0x7FFAC81F3800
        public void get_HasMaxInQueue(){} // RVA: 0x7FFAC81F3810
        public void ClearMaxInQueue(){} // RVA: 0x7FFAC81F3820
        public void get_InFlightTimeout(){} // RVA: 0x7FFAC8278510
        public void set_InFlightTimeout(){} // RVA: 0x7FFAC8278580
        public void get_HasInFlightTimeout(){} // RVA: 0x7FFAC81F6A10
        public void ClearInFlightTimeout(){} // RVA: 0x7FFAC81F6A20
        public void Equals(){} // RVA: 0x7FFAC82786B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8278790
        public void ToString(){} // RVA: 0x7FFAC8278820
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC8278870
        public void CalculateSize(){} // RVA: 0x7FFAC8278920
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8278B90
        public void .cctor(){} // RVA: 0x7FFAC8278C50
    }

    public class FlowLimiterCalculatorReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC8277820
        public void .cctor(){} // RVA: 0x7FFAC8277880
    }

}