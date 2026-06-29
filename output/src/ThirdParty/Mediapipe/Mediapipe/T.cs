// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 6
// Methods: 129

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class TensorsToDetectionsCalculatorOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object NumClassesDefaultValue;
        public object numClasses_;
        public object NumBoxesDefaultValue;
        public object numBoxes_;
        public object NumCoordsDefaultValue;
        public object numCoords_;
        public object KeypointCoordOffsetDefaultValue;
        public object keypointCoordOffset_;
        public object NumKeypointsDefaultValue;
        public object numKeypoints_;
        public object NumValuesPerKeypointDefaultValue;
        public object numValuesPerKeypoint_;
        public object BoxCoordOffsetDefaultValue;
        public object boxCoordOffset_;
        public object XScaleDefaultValue;
        public object xScale_;
        public object YScaleDefaultValue;
        public object yScale_;
        public object WScaleDefaultValue;
        public object wScale_;
        public object HScaleDefaultValue;
        public object hScale_;
        public object ApplyExponentialOnBoxSizeDefaultValue;
        public object applyExponentialOnBoxSize_;
        public object ReverseOutputOrderDefaultValue;
        public object reverseOutputOrder_;
        public object _repeated_ignoreClasses_codec;
        public object ignoreClasses_;
        public object _repeated_allowClasses_codec;
        public object allowClasses_;
        public object SigmoidScoreDefaultValue;
        public object sigmoidScore_;
        public object ScoreClippingThreshDefaultValue;
        public object scoreClippingThresh_;
        public object FlipVerticallyDefaultValue;
        public object flipVertically_;
        public object MinScoreThreshDefaultValue;
        public object minScoreThresh_;
        public object MaxResultsDefaultValue;
        public object maxResults_;
        public object tensorMapping_;
        public object BoxFormatDefaultValue;
        public object boxFormat_;
        public object boxIndices_;
        public object boxIndicesCase_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6565D70
        public void get_Descriptor(){} // RVA: 0x6565DD0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6565E90
        public void .ctor(){} // RVA: 0x6566020
        public void Clone(){} // RVA: 0x6566590
        public void get_NumClasses(){} // RVA: 0x65665F0
        public void set_NumClasses(){} // RVA: 0x64D65C0
        public void get_HasNumClasses(){} // RVA: 0x64D65D0
        public void ClearNumClasses(){} // RVA: 0x64D65E0
        public void get_NumBoxes(){} // RVA: 0x6566660
        public void set_NumBoxes(){} // RVA: 0x64D6660
        public void get_HasNumBoxes(){} // RVA: 0x64D6670
        public void ClearNumBoxes(){} // RVA: 0x64D6680
        public void get_NumCoords(){} // RVA: 0x65666D0
        public void set_NumCoords(){} // RVA: 0x6566740
        public void get_HasNumCoords(){} // RVA: 0x64D9870
        public void ClearNumCoords(){} // RVA: 0x64D9880
        public void get_KeypointCoordOffset(){} // RVA: 0x6566750
        public void set_KeypointCoordOffset(){} // RVA: 0x65667C0
        public void get_HasKeypointCoordOffset(){} // RVA: 0x65667D0
        public void ClearKeypointCoordOffset(){} // RVA: 0x65667E0
        public void get_NumKeypoints(){} // RVA: 0x65667F0
        public void set_NumKeypoints(){} // RVA: 0x6566860
        public void get_HasNumKeypoints(){} // RVA: 0x6566870
        public void ClearNumKeypoints(){} // RVA: 0x6566880
        public void get_NumValuesPerKeypoint(){} // RVA: 0x6566890
        public void set_NumValuesPerKeypoint(){} // RVA: 0x6566900
        public void get_HasNumValuesPerKeypoint(){} // RVA: 0x6566910
        public void ClearNumValuesPerKeypoint(){} // RVA: 0x6566920
        public void get_BoxCoordOffset(){} // RVA: 0x6566930
        public void set_BoxCoordOffset(){} // RVA: 0x65669A0
        public void get_HasBoxCoordOffset(){} // RVA: 0x65669B0
        public void ClearBoxCoordOffset(){} // RVA: 0x65669C0
        public void get_XScale(){} // RVA: 0x65669D0
        public void set_XScale(){} // RVA: 0x6566A40
        public void get_HasXScale(){} // RVA: 0x64D9E30
        public void ClearXScale(){} // RVA: 0x64D9E40
        public void get_YScale(){} // RVA: 0x6566A50
        public void set_YScale(){} // RVA: 0x6566AC0
        public void get_HasYScale(){} // RVA: 0x64DA0A0
        public void ClearYScale(){} // RVA: 0x64DA0B0
        public void get_WScale(){} // RVA: 0x6566AD0
        public void set_WScale(){} // RVA: 0x6566B40
        public void get_HasWScale(){} // RVA: 0x6566B50
        public void ClearWScale(){} // RVA: 0x6566B60
        public void get_HScale(){} // RVA: 0x6566B70
        public void set_HScale(){} // RVA: 0x6566BE0
        public void get_HasHScale(){} // RVA: 0x6566BF0
        public void ClearHScale(){} // RVA: 0x6566C00
        public void get_ApplyExponentialOnBoxSize(){} // RVA: 0x6566C10
        public void set_ApplyExponentialOnBoxSize(){} // RVA: 0x6566C80
        public void get_HasApplyExponentialOnBoxSize(){} // RVA: 0x6566C90
        public void ClearApplyExponentialOnBoxSize(){} // RVA: 0x6566CA0
        public void get_ReverseOutputOrder(){} // RVA: 0x6566CB0
        public void set_ReverseOutputOrder(){} // RVA: 0x6566D20
        public void get_HasReverseOutputOrder(){} // RVA: 0x6566D30
        public void ClearReverseOutputOrder(){} // RVA: 0x6566D40
        public void get_IgnoreClasses(){} // RVA: 0xBE58B0
        public void get_AllowClasses(){} // RVA: 0xC0FFC0
        public void get_SigmoidScore(){} // RVA: 0x6566D50
        public void set_SigmoidScore(){} // RVA: 0x6566DC0
        public void get_HasSigmoidScore(){} // RVA: 0x6566DD0
        public void ClearSigmoidScore(){} // RVA: 0x6566DE0
        public void get_ScoreClippingThresh(){} // RVA: 0x6566DF0
        public void set_ScoreClippingThresh(){} // RVA: 0x6566E60
        public void get_HasScoreClippingThresh(){} // RVA: 0x6566E70
        public void ClearScoreClippingThresh(){} // RVA: 0x6566E80
        public void get_FlipVertically(){} // RVA: 0x6566E90
        public void set_FlipVertically(){} // RVA: 0x6566F00
        public void get_HasFlipVertically(){} // RVA: 0x6566F10
        public void ClearFlipVertically(){} // RVA: 0x6566F20
        public void get_MinScoreThresh(){} // RVA: 0x6566F30
        public void set_MinScoreThresh(){} // RVA: 0x6566FA0
        public void get_HasMinScoreThresh(){} // RVA: 0x6566FB0
        public void ClearMinScoreThresh(){} // RVA: 0x6566FC0
        public void get_MaxResults(){} // RVA: 0x6566FD0
        public void set_MaxResults(){} // RVA: 0x6567040
        public void get_HasMaxResults(){} // RVA: 0x6567050
        public void ClearMaxResults(){} // RVA: 0x6567060
        public void get_TensorMapping(){} // RVA: 0xCD3320
        public void set_TensorMapping(){} // RVA: 0xCD4740
        public void get_BoxBoundariesIndices(){} // RVA: 0x6567070
        public void set_BoxBoundariesIndices(){} // RVA: 0x65670D0
        public void get_BoxFormat(){} // RVA: 0x6567140
        public void set_BoxFormat(){} // RVA: 0x65671B0
        public void get_HasBoxFormat(){} // RVA: 0x65671C0
        public void ClearBoxFormat(){} // RVA: 0x65671D0
        public void get_BoxIndicesCase(){} // RVA: 0xF3A950
        public void ClearBoxIndices(){} // RVA: 0x65671E0
        public void Equals(){} // RVA: 0x65672B0
        public void GetHashCode(){} // RVA: 0x6567800
        public void ToString(){} // RVA: 0x6567C70
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x6567CC0
        public void CalculateSize(){} // RVA: 0x6568170
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6568AF0
        public void .cctor(){} // RVA: 0x6569030
    }

    public class TensorsToDetectionsCalculatorReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x6564AB0
        public void .cctor(){} // RVA: 0x6564B10
    }

    public class TextureFormatExtension : Object
    {
        // ── Methods ──
        public void ToImageFormat(){} // RVA: 0x65AC490
    }

    public class ThresholdingCalculatorOptions : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object ThresholdDefaultValue;
        public object threshold_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x656BE50
        public void get_Descriptor(){} // RVA: 0x656BEB0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x656BF70
        public void .ctor(){} // RVA: 0x656C060
        public void Clone(){} // RVA: 0x656C150
        public void get_Threshold(){} // RVA: 0x656C270
        public void set_Threshold(){} // RVA: 0x656C2E0
        public void get_HasThreshold(){} // RVA: 0x64D65D0
        public void ClearThreshold(){} // RVA: 0x64D65E0
        public void Equals(){} // RVA: 0x656C420
        public void GetHashCode(){} // RVA: 0x656C520
        public void ToString(){} // RVA: 0x656C5E0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x656C630
        public void CalculateSize(){} // RVA: 0x656C690
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x656C7D0
        public void .cctor(){} // RVA: 0x656C860
    }

    public class ThresholdingCalculatorReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x656B770
        public void .cctor(){} // RVA: 0x656B7D0
    }

    public class Tool : Object
    {
        public object _TagAndNameRegex;
        public object _TagIndexNameRegex;
        public object _TagIndexRegex;

        // ── Methods ──
        public void GetUnusedSidePacketName(){} // RVA: 0x65539D0
        public void ParseNameFromStream(){} // RVA: 0x6553DE0
        public void ValidateName(){} // RVA: 0x6553E60
        public void ValidateNumber(){} // RVA: 0x6553FA0
        public void ValidateTag(){} // RVA: 0x65540E0
        public void ParseTagAndName(){} // RVA: 0x6554220
        public void ParseTagIndexName(){} // RVA: 0x65545E0
        public void .cctor(){} // RVA: 0x6554BD0
    }

}