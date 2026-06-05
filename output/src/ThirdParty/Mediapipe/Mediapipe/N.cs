// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 17
// Methods: 133

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class NativeCategory
    {
        // ── Methods ──
        public void get_categoryName(){} // RVA: 0x7FFAF858BBC0
        public void get_displayName(){} // RVA: 0x7FFAF858BC30
    }

    public class NativeClassificationResult
    {
        // ── Methods ──
        public void get_classifications(){} // RVA: 0x7FFAF858BD70
        public void Dispose(){} // RVA: 0x7FFAF858BDD0
    }

    public class NativeClassifications
    {
        public object categories;
        public object keypoints;

        // ── Methods ──
        public void get_categories(){} // RVA: 0x7FFAF858BCA0
        public void get_headName(){} // RVA: 0x7FFAF858BD00
    }

    public class NativeDetection
    {
        public object name;

        // ── Methods ──
        public void get_categories(){} // RVA: 0x7FFAF858BEF0
        public void get_keypoints(){} // RVA: 0x7FFAF858BF50
    }

    public class NativeDetectionResult
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFAF858BFB0
        public void Dispose(){} // RVA: 0x7FFAF858C010
    }

    public class NativeLandmark
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF858C150
    }

    public class NativeLandmarks
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFAF858C230
    }

    public class NativeLandmarksArray
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAF858C2F0
        public void AsReadOnlySpan(){} // RVA: 0x7FFAF858C3C0
    }

    public class NativeNormalizedKeypoint
    {
        public object _label;

        // ── Methods ──
        public void get_label(){} // RVA: 0x7FFAF858C0E0
    }

    public class NativeNormalizedLandmark
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF858C1C0
    }

    public class NativeNormalizedLandmarks
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFAF858C290
    }

    public class NativeNormalizedLandmarksArray
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAF858C420
        public void AsReadOnlySpan(){} // RVA: 0x7FFAF858C4F0
    }

    public class NativeRect
    {
    }

    public class NormalizedLandmark
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85C3440
        public void get_Descriptor(){} // RVA: 0x7FFAF85C34A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85C3560
        public void .ctor(){} // RVA: 0x7FFAF85C04D0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85C3650
        public void get_X(){} // RVA: 0x7FFAF85C3780
        public void set_X(){} // RVA: 0x7FFAF85C0770
        public void get_HasX(){} // RVA: 0x7FFAF850C3B0
        public void ClearX(){} // RVA: 0x7FFAF850C3C0
        public void get_Y(){} // RVA: 0x7FFAF85C37F0
        public void set_Y(){} // RVA: 0x7FFAF85B6B70
        public void get_HasY(){} // RVA: 0x7FFAF850C450
        public void ClearY(){} // RVA: 0x7FFAF850C460
        public void get_Z(){} // RVA: 0x7FFAF85C3860
        public void set_Z(){} // RVA: 0x7FFAF85C0860
        public void get_HasZ(){} // RVA: 0x7FFAF850F650
        public void ClearZ(){} // RVA: 0x7FFAF850F660
        public void get_Visibility(){} // RVA: 0x7FFAF85C38D0
        public void set_Visibility(){} // RVA: 0x7FFAF85C08E0
        public void get_HasVisibility(){} // RVA: 0x7FFAF850FC10
        public void ClearVisibility(){} // RVA: 0x7FFAF850FC20
        public void get_Presence(){} // RVA: 0x7FFAF85C3940
        public void set_Presence(){} // RVA: 0x7FFAF85C0960
        public void get_HasPresence(){} // RVA: 0x7FFAF850FE80
        public void ClearPresence(){} // RVA: 0x7FFAF850FE90
        public void Equals(){} // RVA: 0x7FFAF85C3A10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF85C3C90
        public void ToString(){} // RVA: 0x7FFAF85C3EA0
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85C3EF0
        public void CalculateSize(){} // RVA: 0x7FFAF85C0FC0
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85C1190
        public void .cctor(){} // RVA: 0x7FFAF85C4160
    }

    public class NormalizedLandmarkList
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85C4410
        public void get_Descriptor(){} // RVA: 0x7FFAF85C4470
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85C4530
        public void .ctor(){} // RVA: 0x7FFAF85C46E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85C4880
        public void get_Landmark(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF85C4B50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84EDF40
        public void ToString(){} // RVA: 0x7FFAF85C4C00
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85C4C50
        public void CalculateSize(){} // RVA: 0x7FFAF85C4D10
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85C4F00
        public void .cctor(){} // RVA: 0x7FFAF85C5000
    }

    public class NormalizedLandmarkListCollection
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85C5380
        public void get_Descriptor(){} // RVA: 0x7FFAF85C53E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85C54A0
        public void .ctor(){} // RVA: 0x7FFAF85C5650 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85C57F0
        public void get_LandmarkList(){} // RVA: 0x7FFAF2D907C0
        public void Equals(){} // RVA: 0x7FFAF85C5AC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF84EDF40
        public void ToString(){} // RVA: 0x7FFAF85C5B70
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85C5BC0
        public void CalculateSize(){} // RVA: 0x7FFAF85C5C80
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85C5E70
        public void .cctor(){} // RVA: 0x7FFAF85C5F70
    }

    public class NormalizedRect
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAF85D0600
        public void get_Descriptor(){} // RVA: 0x7FFAF85D0660
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAF85D0720
        public void .ctor(){} // RVA: 0x7FFAF85CF570 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAF85D0810
        public void get_XCenter(){} // RVA: 0x7FFAF85D0940
        public void set_XCenter(){} // RVA: 0x7FFAF85C0770
        public void get_HasXCenter(){} // RVA: 0x7FFAF850C3B0
        public void ClearXCenter(){} // RVA: 0x7FFAF850C3C0
        public void get_YCenter(){} // RVA: 0x7FFAF85D09B0
        public void set_YCenter(){} // RVA: 0x7FFAF85B6B70
        public void get_HasYCenter(){} // RVA: 0x7FFAF850C450
        public void ClearYCenter(){} // RVA: 0x7FFAF850C460
        public void get_Height(){} // RVA: 0x7FFAF85D0A20
        public void set_Height(){} // RVA: 0x7FFAF85C0860
        public void get_HasHeight(){} // RVA: 0x7FFAF850F650
        public void ClearHeight(){} // RVA: 0x7FFAF850F660
        public void get_Width(){} // RVA: 0x7FFAF85D0A90
        public void set_Width(){} // RVA: 0x7FFAF85C08E0
        public void get_HasWidth(){} // RVA: 0x7FFAF850FC10
        public void ClearWidth(){} // RVA: 0x7FFAF850FC20
        public void get_Rotation(){} // RVA: 0x7FFAF85D0B00
        public void set_Rotation(){} // RVA: 0x7FFAF85C0960
        public void get_HasRotation(){} // RVA: 0x7FFAF850FE80
        public void ClearRotation(){} // RVA: 0x7FFAF850FE90
        public void get_RectId(){} // RVA: 0x7FFAF85D0B70
        public void set_RectId(){} // RVA: 0x7FFAF85CFA40
        public void get_HasRectId(){} // RVA: 0x7FFAF859C3A0
        public void ClearRectId(){} // RVA: 0x7FFAF859C3B0
        public void Equals(){} // RVA: 0x7FFAF85D0C40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF85D0EE0
        public void ToString(){} // RVA: 0x7FFAF85D1100
        public void WriteTo(){} // RVA: 0x7FFAF84E9740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAF85D1150
        public void CalculateSize(){} // RVA: 0x7FFAF85D1290
        public void MergeFrom(){} // RVA: 0x7FFAF84E9A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAF85D1510
        public void .cctor(){} // RVA: 0x7FFAF85D1650
    }

}