// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 5
// Methods: 69

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Rasterization
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Rasterization> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int IntervalFieldNumber;
        public Google.Protobuf.FieldCodec`1<Interval> _repeated_interval_codec; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B03EC0
        public void get_Descriptor(){} // RVA: 0x5B03F20
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B03FE0
        public void .ctor(){} // RVA: 0x5B040F0 | overloaded x2
        public void Clone(){} // RVA: 0x5B04290
        public void get_Interval(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B04560 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B04610
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B04660
        public void CalculateSize(){} // RVA: 0x5B04720
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B04910
        public void .cctor(){} // RVA: 0x5B04A10
    }

    public class RasterizationReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B03760
        public void .cctor(){} // RVA: 0x5B037C0
    }

    public class Rect
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
        public void get_Parser(){} // RVA: 0x5B1F360
        public void get_Descriptor(){} // RVA: 0x5B1F3C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B1F480
        public void .ctor(){} // RVA: 0x5B1F570 | overloaded x2
        public void Clone(){} // RVA: 0x5B1F670
        public void get_XCenter(){} // RVA: 0x5B1F7A0
        public void set_XCenter(){} // RVA: 0x5A5C3A0
        public void get_HasXCenter(){} // RVA: 0x5A5C3B0
        public void ClearXCenter(){} // RVA: 0x5A5C3C0
        public void get_YCenter(){} // RVA: 0x5B1F810
        public void set_YCenter(){} // RVA: 0x5A5C440
        public void get_HasYCenter(){} // RVA: 0x5A5C450
        public void ClearYCenter(){} // RVA: 0x5A5C460
        public void get_Height(){} // RVA: 0x5B1F880
        public void set_Height(){} // RVA: 0x5AEBF90
        public void get_HasHeight(){} // RVA: 0x5A5F650
        public void ClearHeight(){} // RVA: 0x5A5F660
        public void get_Width(){} // RVA: 0x5B1F8F0
        public void set_Width(){} // RVA: 0x5AEF1F0
        public void get_HasWidth(){} // RVA: 0x5A5FC10
        public void ClearWidth(){} // RVA: 0x5A5FC20
        public void get_Rotation(){} // RVA: 0x5B1F960
        public void set_Rotation(){} // RVA: 0x5B10960
        public void get_HasRotation(){} // RVA: 0x5A5FE80
        public void ClearRotation(){} // RVA: 0x5A5FE90
        public void get_RectId(){} // RVA: 0x5B1F9D0
        public void set_RectId(){} // RVA: 0x5B1FA40
        public void get_HasRectId(){} // RVA: 0x5AEC3A0
        public void ClearRectId(){} // RVA: 0x5AEC3B0
        public void Equals(){} // RVA: 0x5B1FAB0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B1FC40
        public void ToString(){} // RVA: 0x5B1FD70
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B1FDC0
        public void CalculateSize(){} // RVA: 0x5B1FEF0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B20210
        public void .cctor(){} // RVA: 0x5B20340
    }

    public class RectReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B1EB10
        public void .cctor(){} // RVA: 0x5B1EB70
    }

    public class ResourceManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B32630
        public void PrepareAssetAsync(){}
        public void PathToResourceAsFile(){} // RVA: 0x5B32BC0
        public void GetResourceContents(){} // RVA: 0x5B32C80
        public void GetAssetNameFromPath(){} // RVA: 0x5B33050
        public void .cctor(){} // RVA: 0x5B33230
    }

}