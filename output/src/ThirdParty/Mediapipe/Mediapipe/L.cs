// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 7
// Methods: 106

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Landmark : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Landmark> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int X;
        public float HasX; // 0x8
        public float Y; // 0x1C
        public int HasY;
        public float Z; // 0xC
        public float HasZ; // 0x20
        public int Visibility;
        public float HasVisibility; // 0x10
        public float Presence; // 0x24
        public int HasPresence;
        public float VisibilityDefaultValue; // 0x14
        public float visibility_; // 0x28
        public int PresenceFieldNumber;
        public float PresenceDefaultValue; // 0x18
        public float presence_; // 0x2C

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82A77D0
        public void get_Descriptor(){} // RVA: 0x7FFAC82A7830
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82A78F0
        public void .ctor(){} // RVA: 0x7FFAC82A79E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82A7AE0
        public void get_X(){} // RVA: 0x7FFAC82A7C10
        public void set_X(){} // RVA: 0x7FFAC82A7C80
        public void get_HasX(){} // RVA: 0x7FFAC81F3770
        public void ClearX(){} // RVA: 0x7FFAC81F3780
        public void get_Y(){} // RVA: 0x7FFAC82A7C90
        public void set_Y(){} // RVA: 0x7FFAC829E080
        public void get_HasY(){} // RVA: 0x7FFAC81F3810
        public void ClearY(){} // RVA: 0x7FFAC81F3820
        public void get_Z(){} // RVA: 0x7FFAC82A7D00
        public void set_Z(){} // RVA: 0x7FFAC82A7D70
        public void get_HasZ(){} // RVA: 0x7FFAC81F6A10
        public void ClearZ(){} // RVA: 0x7FFAC81F6A20
        public void get_Visibility(){} // RVA: 0x7FFAC82A7D80
        public void set_Visibility(){} // RVA: 0x7FFAC82A7DF0
        public void get_HasVisibility(){} // RVA: 0x7FFAC81F6FD0
        public void ClearVisibility(){} // RVA: 0x7FFAC81F6FE0
        public void get_Presence(){} // RVA: 0x7FFAC82A7E00
        public void set_Presence(){} // RVA: 0x7FFAC82A7E70
        public void get_HasPresence(){} // RVA: 0x7FFAC81F7240
        public void ClearPresence(){} // RVA: 0x7FFAC81F7250
        public void Equals(){} // RVA: 0x7FFAC82A7EE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82A8160
        public void ToString(){} // RVA: 0x7FFAC82A8370
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82A83C0
        public void CalculateSize(){} // RVA: 0x7FFAC82A84D0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82A86A0
        public void .cctor(){} // RVA: 0x7FFAC82A87C0
    }

    public class LandmarkList : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LandmarkList> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor;
        public Google.Protobuf.FieldCodec`1<Mediapipe.Landmark> Landmark; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.Landmark> landmark_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82A8A70
        public void get_Descriptor(){} // RVA: 0x7FFAC82A8AD0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82A8B90
        public void .ctor(){} // RVA: 0x7FFAC82A8D40 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82A8EE0
        public void get_Landmark(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC82A91B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC82A9260
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82A92B0
        public void CalculateSize(){} // RVA: 0x7FFAC82A9370
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82A9560
        public void .cctor(){} // RVA: 0x7FFAC82A9660
    }

    public class LandmarkListCollection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LandmarkListCollection> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.LandmarkList> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.LandmarkList> LandmarkList; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82A99E0
        public void get_Descriptor(){} // RVA: 0x7FFAC82A9A40
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82A9B00
        public void .ctor(){} // RVA: 0x7FFAC82A9CB0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82A9E50
        public void get_LandmarkList(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC82AA120 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC82AA1D0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82AA220
        public void CalculateSize(){} // RVA: 0x7FFAC82AA2E0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82AA4D0
        public void .cctor(){} // RVA: 0x7FFAC82AA5D0
    }

    public class LandmarkReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82A69A0
        public void .cctor(){} // RVA: 0x7FFAC82A6A00
    }

    public class ListExtension : Object
    {
        // ── Methods ──
        public void ResizeTo(){} // RVA: 0x7FFAC2C76370
    }

    public class LocationData : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.LocationData> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Format;
        public 0x6B2128C8 HasFormat; // 0x8
        public 0x6B2128C8 BoundingBox; // 0x1C
        public int RelativeBoundingBox;
        public BoundingBox Mask; // 0x20
        public int RelativeKeypoints;
        public RelativeBoundingBox relativeBoundingBox_; // 0x28
        public int MaskFieldNumber;
        public BinaryMask mask_; // 0x30
        public int RelativeKeypointsFieldNumber;
        public Google.Protobuf.FieldCodec`1<RelativeKeypoint> _repeated_relativeKeypoints_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<RelativeKeypoint> relativeKeypoints_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82AE8C0
        public void get_Descriptor(){} // RVA: 0x7FFAC82AE920
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82AE9E0
        public void .ctor(){} // RVA: 0x7FFAC82AEAF0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82AF120
        public void get_Format(){} // RVA: 0x7FFAC82AF180
        public void set_Format(){} // RVA: 0x7FFAC81F3760
        public void get_HasFormat(){} // RVA: 0x7FFAC81F3770
        public void ClearFormat(){} // RVA: 0x7FFAC81F3780
        public void get_BoundingBox(){} // RVA: 0x7FFAC2F4F0C0
        public void set_BoundingBox(){} // RVA: 0x7FFAC2F4F0D0
        public void get_RelativeBoundingBox(){} // RVA: 0x7FFAC2F4F130
        public void set_RelativeBoundingBox(){} // RVA: 0x7FFAC2F22E90
        public void get_Mask(){} // RVA: 0x7FFAC31D95E0
        public void set_Mask(){} // RVA: 0x7FFAC2F4F890
        public void get_RelativeKeypoints(){} // RVA: 0x7FFAC31D0140
        public void Equals(){} // RVA: 0x7FFAC82AF250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82AF3D0
        public void ToString(){} // RVA: 0x7FFAC82AF4B0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82AF500
        public void CalculateSize(){} // RVA: 0x7FFAC82AF650
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82AFDC0
        public void .cctor(){} // RVA: 0x7FFAC82AFFC0
    }

    public class LocationDataReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82AD800
        public void .cctor(){} // RVA: 0x7FFAC82AD860
    }

}