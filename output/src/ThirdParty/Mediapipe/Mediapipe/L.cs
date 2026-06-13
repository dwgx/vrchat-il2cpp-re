// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 7
// Methods: 106

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Landmark
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Landmark> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int XFieldNumber;
        public float XDefaultValue; // 0x8
        public float x_; // 0x1C
        public int YFieldNumber;
        public float YDefaultValue; // 0xC
        public float y_; // 0x20
        public int ZFieldNumber;
        public float ZDefaultValue; // 0x10
        public float z_; // 0x24
        public int VisibilityFieldNumber;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B102C0
        public void get_Descriptor(){} // RVA: 0x5B10320
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B103E0
        public void .ctor(){} // RVA: 0x5B104D0 | overloaded x2
        public void Clone(){} // RVA: 0x5B105D0
        public void get_X(){} // RVA: 0x5B10700
        public void set_X(){} // RVA: 0x5B10770
        public void get_HasX(){} // RVA: 0x5A5C3B0
        public void ClearX(){} // RVA: 0x5A5C3C0
        public void get_Y(){} // RVA: 0x5B10780
        public void set_Y(){} // RVA: 0x5B06B70
        public void get_HasY(){} // RVA: 0x5A5C450
        public void ClearY(){} // RVA: 0x5A5C460
        public void get_Z(){} // RVA: 0x5B107F0
        public void set_Z(){} // RVA: 0x5B10860
        public void get_HasZ(){} // RVA: 0x5A5F650
        public void ClearZ(){} // RVA: 0x5A5F660
        public void get_Visibility(){} // RVA: 0x5B10870
        public void set_Visibility(){} // RVA: 0x5B108E0
        public void get_HasVisibility(){} // RVA: 0x5A5FC10
        public void ClearVisibility(){} // RVA: 0x5A5FC20
        public void get_Presence(){} // RVA: 0x5B108F0
        public void set_Presence(){} // RVA: 0x5B10960
        public void get_HasPresence(){} // RVA: 0x5A5FE80
        public void ClearPresence(){} // RVA: 0x5A5FE90
        public void Equals(){} // RVA: 0x5B109D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B10C50
        public void ToString(){} // RVA: 0x5B10E60
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B10EB0
        public void CalculateSize(){} // RVA: 0x5B10FC0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B11190
        public void .cctor(){} // RVA: 0x5B112B0
    }

    public class LandmarkList
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LandmarkList> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int LandmarkFieldNumber;
        public Google.Protobuf.FieldCodec`1<Mediapipe.Landmark> _repeated_landmark_codec; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B11560
        public void get_Descriptor(){} // RVA: 0x5B115C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B11680
        public void .ctor(){} // RVA: 0x5B11830 | overloaded x2
        public void Clone(){} // RVA: 0x5B119D0
        public void get_Landmark(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B11CA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B11D50
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B11DA0
        public void CalculateSize(){} // RVA: 0x5B11E60
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B12050
        public void .cctor(){} // RVA: 0x5B12150
    }

    public class LandmarkListCollection
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LandmarkListCollection> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.LandmarkList> _repeated_landmarkList_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.LandmarkList> landmarkList_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B124D0
        public void get_Descriptor(){} // RVA: 0x5B12530
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B125F0
        public void .ctor(){} // RVA: 0x5B127A0 | overloaded x2
        public void Clone(){} // RVA: 0x5B12940
        public void get_LandmarkList(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B12C10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B12CC0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B12D10
        public void CalculateSize(){} // RVA: 0x5B12DD0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B12FC0
        public void .cctor(){} // RVA: 0x5B130C0
    }

    public class LandmarkReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B0F490
        public void .cctor(){} // RVA: 0x5B0F4F0
    }

    public class ListExtension
    {
        // ── Methods ──
        public void ResizeTo(){} // RVA: 0x2A490
    }

    public class LocationData
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LocationData> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int FormatFieldNumber;
        public 0x6592EA80 FormatDefaultValue; // 0x8
        public 0x6592EA80 format_; // 0x1C
        public int BoundingBoxFieldNumber;
        public BoundingBox boundingBox_; // 0x20
        public int RelativeBoundingBoxFieldNumber;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B173B0
        public void get_Descriptor(){} // RVA: 0x5B17410
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B174D0
        public void .ctor(){} // RVA: 0x5B175E0 | overloaded x2
        public void Clone(){} // RVA: 0x5B17C10
        public void get_Format(){} // RVA: 0x5B17C70
        public void set_Format(){} // RVA: 0x5A5C3A0
        public void get_HasFormat(){} // RVA: 0x5A5C3B0
        public void ClearFormat(){} // RVA: 0x5A5C3C0
        public void get_BoundingBox(){} // RVA: 0x30B0C0
        public void set_BoundingBox(){} // RVA: 0x30B0D0
        public void get_RelativeBoundingBox(){} // RVA: 0x30B130
        public void set_RelativeBoundingBox(){} // RVA: 0x2DEE90
        public void get_Mask(){} // RVA: 0x6374D0
        public void set_Mask(){} // RVA: 0x30B890
        public void get_RelativeKeypoints(){} // RVA: 0x4976A0
        public void Equals(){} // RVA: 0x5B17D40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B17EC0
        public void ToString(){} // RVA: 0x5B17FA0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B17FF0
        public void CalculateSize(){} // RVA: 0x5B18140
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B188B0
        public void .cctor(){} // RVA: 0x5B18AB0
    }

    public class LocationDataReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B162F0
        public void .cctor(){} // RVA: 0x5B16350
    }

}