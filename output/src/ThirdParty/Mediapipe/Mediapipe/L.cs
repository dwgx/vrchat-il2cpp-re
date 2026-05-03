// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 7
// Methods: 106

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Landmark : Object
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
        public void get_Parser(){} // RVA: 0x7FFE866510F0
        public void get_Descriptor(){} // RVA: 0x7FFE86651150
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86651210
        public void .ctor(){} // RVA: 0x7FFE86651300 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86651400
        public void get_X(){} // RVA: 0x7FFE86651530
        public void set_X(){} // RVA: 0x7FFE866515A0
        public void get_HasX(){} // RVA: 0x7FFE8659D0B0
        public void ClearX(){} // RVA: 0x7FFE8659D0C0
        public void get_Y(){} // RVA: 0x7FFE866515B0
        public void set_Y(){} // RVA: 0x7FFE866479A0
        public void get_HasY(){} // RVA: 0x7FFE8659D150
        public void ClearY(){} // RVA: 0x7FFE8659D160
        public void get_Z(){} // RVA: 0x7FFE86651620
        public void set_Z(){} // RVA: 0x7FFE86651690
        public void get_HasZ(){} // RVA: 0x7FFE865A0350
        public void ClearZ(){} // RVA: 0x7FFE865A0360
        public void get_Visibility(){} // RVA: 0x7FFE866516A0
        public void set_Visibility(){} // RVA: 0x7FFE86651710
        public void get_HasVisibility(){} // RVA: 0x7FFE865A0910
        public void ClearVisibility(){} // RVA: 0x7FFE865A0920
        public void get_Presence(){} // RVA: 0x7FFE86651720
        public void set_Presence(){} // RVA: 0x7FFE86651790
        public void get_HasPresence(){} // RVA: 0x7FFE865A0B80
        public void ClearPresence(){} // RVA: 0x7FFE865A0B90
        public void Equals(){} // RVA: 0x7FFE86651800 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86651A80
        public void ToString(){} // RVA: 0x7FFE86651C90
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86651CE0
        public void CalculateSize(){} // RVA: 0x7FFE86651DF0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86651FC0
        public void .cctor(){} // RVA: 0x7FFE866520E0
    }

    public class LandmarkList : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LandmarkList> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int LandmarkFieldNumber;
        public Google.Protobuf.FieldCodec`1<Mediapipe.Landmark> _repeated_landmark_codec; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86652390
        public void get_Descriptor(){} // RVA: 0x7FFE866523F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866524B0
        public void .ctor(){} // RVA: 0x7FFE86652660 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86652800
        public void get_Landmark(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86652AD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86652B80
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86652BD0
        public void CalculateSize(){} // RVA: 0x7FFE86652C90
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86652E80
        public void .cctor(){} // RVA: 0x7FFE86652F80
    }

    public class LandmarkListCollection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LandmarkListCollection> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.LandmarkList> _repeated_landmarkList_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.LandmarkList> landmarkList_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86653300
        public void get_Descriptor(){} // RVA: 0x7FFE86653360
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86653420
        public void .ctor(){} // RVA: 0x7FFE866535D0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86653770
        public void get_LandmarkList(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86653A40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86653AF0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86653B40
        public void CalculateSize(){} // RVA: 0x7FFE86653C00
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86653DF0
        public void .cctor(){} // RVA: 0x7FFE86653EF0
    }

    public class LandmarkReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE866502C0
        public void .cctor(){} // RVA: 0x7FFE86650320
    }

    public class ListExtension : Object
    {
        // ── Methods ──
        public void ResizeTo(){} // RVA: 0x7FFE80E4BA70
    }

    public class LocationData : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LocationData> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int FormatFieldNumber;
        public 0x6660C18C FormatDefaultValue; // 0x8
        public 0x6660C18C format_; // 0x1C
        public int BoundingBoxFieldNumber;
        public BoundingBox boundingBox_; // 0x20
        public int RelativeBoundingBoxFieldNumber;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866581E0
        public void get_Descriptor(){} // RVA: 0x7FFE86658240
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86658300
        public void .ctor(){} // RVA: 0x7FFE86658410 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86658A40
        public void get_Format(){} // RVA: 0x7FFE86658AA0
        public void set_Format(){} // RVA: 0x7FFE8659D0A0
        public void get_HasFormat(){} // RVA: 0x7FFE8659D0B0
        public void ClearFormat(){} // RVA: 0x7FFE8659D0C0
        public void get_BoundingBox(){} // RVA: 0x7FFE811290C0
        public void set_BoundingBox(){} // RVA: 0x7FFE811290D0
        public void get_RelativeBoundingBox(){} // RVA: 0x7FFE81129130
        public void set_RelativeBoundingBox(){} // RVA: 0x7FFE810FCE90
        public void get_Mask(){} // RVA: 0x7FFE8144E200
        public void set_Mask(){} // RVA: 0x7FFE81129890
        public void get_RelativeKeypoints(){} // RVA: 0x7FFE8143BA80
        public void Equals(){} // RVA: 0x7FFE86658B70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86658CF0
        public void ToString(){} // RVA: 0x7FFE86658DD0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86658E20
        public void CalculateSize(){} // RVA: 0x7FFE86658F70
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE866596E0
        public void .cctor(){} // RVA: 0x7FFE866598E0
    }

    public class LocationDataReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86657120
        public void .cctor(){} // RVA: 0x7FFE86657180
    }

}