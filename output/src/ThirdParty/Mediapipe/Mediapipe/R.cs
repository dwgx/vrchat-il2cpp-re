// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 5
// Methods: 69

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Rasterization : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Rasterization> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor;
        public Google.Protobuf.FieldCodec`1<Interval> Interval; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Interval> interval_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC829B3D0
        public void get_Descriptor(){} // RVA: 0x7FFAC829B430
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC829B4F0
        public void .ctor(){} // RVA: 0x7FFAC829B600 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC829B7A0
        public void get_Interval(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC829BA70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC829BB20
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC829BB70
        public void CalculateSize(){} // RVA: 0x7FFAC829BC30
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC829BE20
        public void .cctor(){} // RVA: 0x7FFAC829BF20
    }

    public class RasterizationReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC829AC70
        public void .cctor(){} // RVA: 0x7FFAC829ACD0
    }

    public class Rect : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Rect> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int XCenter; // 0x8
        public int HasXCenter; // 0x1C
        public int YCenter; // 0xC
        public int HasYCenter; // 0x20
        public int Height; // 0x10
        public int HasHeight; // 0x24
        public int Width; // 0x14
        public int HasWidth; // 0x28
        public float Rotation; // 0x18
        public float HasRotation; // 0x2C
        public long RectId; // 0x20
        public long HasRectId; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82B6870
        public void get_Descriptor(){} // RVA: 0x7FFAC82B68D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82B6990
        public void .ctor(){} // RVA: 0x7FFAC82B6A80 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82B6B80
        public void get_XCenter(){} // RVA: 0x7FFAC82B6CB0
        public void set_XCenter(){} // RVA: 0x7FFAC81F3760
        public void get_HasXCenter(){} // RVA: 0x7FFAC81F3770
        public void ClearXCenter(){} // RVA: 0x7FFAC81F3780
        public void get_YCenter(){} // RVA: 0x7FFAC82B6D20
        public void set_YCenter(){} // RVA: 0x7FFAC81F3800
        public void get_HasYCenter(){} // RVA: 0x7FFAC81F3810
        public void ClearYCenter(){} // RVA: 0x7FFAC81F3820
        public void get_Height(){} // RVA: 0x7FFAC82B6D90
        public void set_Height(){} // RVA: 0x7FFAC82834A0
        public void get_HasHeight(){} // RVA: 0x7FFAC81F6A10
        public void ClearHeight(){} // RVA: 0x7FFAC81F6A20
        public void get_Width(){} // RVA: 0x7FFAC82B6E00
        public void set_Width(){} // RVA: 0x7FFAC8286700
        public void get_HasWidth(){} // RVA: 0x7FFAC81F6FD0
        public void ClearWidth(){} // RVA: 0x7FFAC81F6FE0
        public void get_Rotation(){} // RVA: 0x7FFAC82B6E70
        public void set_Rotation(){} // RVA: 0x7FFAC82A7E70
        public void get_HasRotation(){} // RVA: 0x7FFAC81F7240
        public void ClearRotation(){} // RVA: 0x7FFAC81F7250
        public void get_RectId(){} // RVA: 0x7FFAC82B6EE0
        public void set_RectId(){} // RVA: 0x7FFAC82B6F50
        public void get_HasRectId(){} // RVA: 0x7FFAC82838B0
        public void ClearRectId(){} // RVA: 0x7FFAC82838C0
        public void Equals(){} // RVA: 0x7FFAC82B6FC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82B7150
        public void ToString(){} // RVA: 0x7FFAC82B7280
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82B72D0
        public void CalculateSize(){} // RVA: 0x7FFAC82B7400
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82B7720
        public void .cctor(){} // RVA: 0x7FFAC82B7850
    }

    public class RectReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82B6020
        public void .cctor(){} // RVA: 0x7FFAC82B6080
    }

    public class ResourceManager : Object
    {
        public object _InitLock;
        public Mediapipe.ResourceManager _Instance; // 0x8
        public PathResolver _pathResolver; // 0x10
        public ResourceProvider _resourceProvider; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82C9B40
        public void PrepareAssetAsync(){}
        public void PathToResourceAsFile(){} // RVA: 0x7FFAC82CA0D0
        public void GetResourceContents(){} // RVA: 0x7FFAC82CA190
        public void GetAssetNameFromPath(){} // RVA: 0x7FFAC82CA560
        public void .cctor(){} // RVA: 0x7FFAC82CA740
    }

}