// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 5
// Methods: 69

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Rasterization : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Rasterization> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int IntervalFieldNumber;
        public Google.Protobuf.FieldCodec`1<Interval> _repeated_interval_codec; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86644CF0
        public void get_Descriptor(){} // RVA: 0x7FFE86644D50
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86644E10
        public void .ctor(){} // RVA: 0x7FFE86644F20 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866450C0
        public void get_Interval(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86645390 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86645440
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86645490
        public void CalculateSize(){} // RVA: 0x7FFE86645550
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86645740
        public void .cctor(){} // RVA: 0x7FFE86645840
    }

    public class RasterizationReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE86644590
        public void .cctor(){} // RVA: 0x7FFE866445F0
    }

    public class Rect : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Rect> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int XCenterDefaultValue; // 0x8
        public int xCenter_; // 0x1C
        public int YCenterDefaultValue; // 0xC
        public int yCenter_; // 0x20
        public int HeightDefaultValue; // 0x10
        public int height_; // 0x24
        public int WidthDefaultValue; // 0x14
        public int width_; // 0x28
        public float RotationDefaultValue; // 0x18
        public float rotation_; // 0x2C
        public long RectIdDefaultValue; // 0x20
        public long rectId_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86660190
        public void get_Descriptor(){} // RVA: 0x7FFE866601F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866602B0
        public void .ctor(){} // RVA: 0x7FFE866603A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866604A0
        public void get_XCenter(){} // RVA: 0x7FFE866605D0
        public void set_XCenter(){} // RVA: 0x7FFE8659D0A0
        public void get_HasXCenter(){} // RVA: 0x7FFE8659D0B0
        public void ClearXCenter(){} // RVA: 0x7FFE8659D0C0
        public void get_YCenter(){} // RVA: 0x7FFE86660640
        public void set_YCenter(){} // RVA: 0x7FFE8659D140
        public void get_HasYCenter(){} // RVA: 0x7FFE8659D150
        public void ClearYCenter(){} // RVA: 0x7FFE8659D160
        public void get_Height(){} // RVA: 0x7FFE866606B0
        public void set_Height(){} // RVA: 0x7FFE8662CDC0
        public void get_HasHeight(){} // RVA: 0x7FFE865A0350
        public void ClearHeight(){} // RVA: 0x7FFE865A0360
        public void get_Width(){} // RVA: 0x7FFE86660720
        public void set_Width(){} // RVA: 0x7FFE86630020
        public void get_HasWidth(){} // RVA: 0x7FFE865A0910
        public void ClearWidth(){} // RVA: 0x7FFE865A0920
        public void get_Rotation(){} // RVA: 0x7FFE86660790
        public void set_Rotation(){} // RVA: 0x7FFE86651790
        public void get_HasRotation(){} // RVA: 0x7FFE865A0B80
        public void ClearRotation(){} // RVA: 0x7FFE865A0B90
        public void get_RectId(){} // RVA: 0x7FFE86660800
        public void set_RectId(){} // RVA: 0x7FFE86660870
        public void get_HasRectId(){} // RVA: 0x7FFE8662D1D0
        public void ClearRectId(){} // RVA: 0x7FFE8662D1E0
        public void Equals(){} // RVA: 0x7FFE866608E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86660A70
        public void ToString(){} // RVA: 0x7FFE86660BA0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86660BF0
        public void CalculateSize(){} // RVA: 0x7FFE86660D20
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86661040
        public void .cctor(){} // RVA: 0x7FFE86661170
    }

    public class RectReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8665F940
        public void .cctor(){} // RVA: 0x7FFE8665F9A0
    }

    public class ResourceManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86673460
        public void PrepareAssetAsync(){}
        public void PathToResourceAsFile(){} // RVA: 0x7FFE866739F0
        public void GetResourceContents(){} // RVA: 0x7FFE86673AB0
        public void GetAssetNameFromPath(){} // RVA: 0x7FFE86673E80
        public void .cctor(){} // RVA: 0x7FFE86674060
    }

}