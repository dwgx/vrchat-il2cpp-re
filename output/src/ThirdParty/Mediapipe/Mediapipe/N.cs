// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 17
// Methods: 133

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class NativeCategory
    {
        // ── Methods ──
        public void get_categoryName(){} // RVA: 0x5ADBBC0
        public void get_displayName(){} // RVA: 0x5ADBC30
    }

    public class NativeClassificationResult
    {
        // ── Methods ──
        public void get_classifications(){} // RVA: 0x5ADBD70
        public void Dispose(){} // RVA: 0x5ADBDD0
    }

    public class NativeClassifications
    {
        public object categories;
        public object keypoints;

        // ── Methods ──
        public void get_categories(){} // RVA: 0x5ADBCA0
        public void get_headName(){} // RVA: 0x5ADBD00
    }

    public class NativeDetection
    {
        public object name;

        // ── Methods ──
        public void get_categories(){} // RVA: 0x5ADBEF0
        public void get_keypoints(){} // RVA: 0x5ADBF50
    }

    public class NativeDetectionResult
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x5ADBFB0
        public void Dispose(){} // RVA: 0x5ADC010
    }

    public class NativeLandmark
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x5ADC150
    }

    public class NativeLandmarks
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x5ADC230
    }

    public class NativeLandmarksArray
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x5ADC2F0
        public void AsReadOnlySpan(){} // RVA: 0x5ADC3C0
    }

    public class NativeNormalizedKeypoint
    {
        public object _label;

        // ── Methods ──
        public void get_label(){} // RVA: 0x5ADC0E0
    }

    public class NativeNormalizedLandmark
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x5ADC1C0
    }

    public class NativeNormalizedLandmarks
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x5ADC290
    }

    public class NativeNormalizedLandmarksArray
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x5ADC420
        public void AsReadOnlySpan(){} // RVA: 0x5ADC4F0
    }

    public class NativeRect
    {
    }

    public class NormalizedLandmark
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B13440
        public void get_Descriptor(){} // RVA: 0x5B134A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B13560
        public void .ctor(){} // RVA: 0x5B104D0 | overloaded x2
        public void Clone(){} // RVA: 0x5B13650
        public void get_X(){} // RVA: 0x5B13780
        public void set_X(){} // RVA: 0x5B10770
        public void get_HasX(){} // RVA: 0x5A5C3B0
        public void ClearX(){} // RVA: 0x5A5C3C0
        public void get_Y(){} // RVA: 0x5B137F0
        public void set_Y(){} // RVA: 0x5B06B70
        public void get_HasY(){} // RVA: 0x5A5C450
        public void ClearY(){} // RVA: 0x5A5C460
        public void get_Z(){} // RVA: 0x5B13860
        public void set_Z(){} // RVA: 0x5B10860
        public void get_HasZ(){} // RVA: 0x5A5F650
        public void ClearZ(){} // RVA: 0x5A5F660
        public void get_Visibility(){} // RVA: 0x5B138D0
        public void set_Visibility(){} // RVA: 0x5B108E0
        public void get_HasVisibility(){} // RVA: 0x5A5FC10
        public void ClearVisibility(){} // RVA: 0x5A5FC20
        public void get_Presence(){} // RVA: 0x5B13940
        public void set_Presence(){} // RVA: 0x5B10960
        public void get_HasPresence(){} // RVA: 0x5A5FE80
        public void ClearPresence(){} // RVA: 0x5A5FE90
        public void Equals(){} // RVA: 0x5B13A10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B13C90
        public void ToString(){} // RVA: 0x5B13EA0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B13EF0
        public void CalculateSize(){} // RVA: 0x5B10FC0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B11190
        public void .cctor(){} // RVA: 0x5B14160
    }

    public class NormalizedLandmarkList
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B14410
        public void get_Descriptor(){} // RVA: 0x5B14470
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B14530
        public void .ctor(){} // RVA: 0x5B146E0 | overloaded x2
        public void Clone(){} // RVA: 0x5B14880
        public void get_Landmark(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B14B50 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B14C00
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B14C50
        public void CalculateSize(){} // RVA: 0x5B14D10
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B14F00
        public void .cctor(){} // RVA: 0x5B15000
    }

    public class NormalizedLandmarkListCollection
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B15380
        public void get_Descriptor(){} // RVA: 0x5B153E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B154A0
        public void .ctor(){} // RVA: 0x5B15650 | overloaded x2
        public void Clone(){} // RVA: 0x5B157F0
        public void get_LandmarkList(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B15AC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B15B70
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B15BC0
        public void CalculateSize(){} // RVA: 0x5B15C80
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B15E70
        public void .cctor(){} // RVA: 0x5B15F70
    }

    public class NormalizedRect
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B20600
        public void get_Descriptor(){} // RVA: 0x5B20660
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B20720
        public void .ctor(){} // RVA: 0x5B1F570 | overloaded x2
        public void Clone(){} // RVA: 0x5B20810
        public void get_XCenter(){} // RVA: 0x5B20940
        public void set_XCenter(){} // RVA: 0x5B10770
        public void get_HasXCenter(){} // RVA: 0x5A5C3B0
        public void ClearXCenter(){} // RVA: 0x5A5C3C0
        public void get_YCenter(){} // RVA: 0x5B209B0
        public void set_YCenter(){} // RVA: 0x5B06B70
        public void get_HasYCenter(){} // RVA: 0x5A5C450
        public void ClearYCenter(){} // RVA: 0x5A5C460
        public void get_Height(){} // RVA: 0x5B20A20
        public void set_Height(){} // RVA: 0x5B10860
        public void get_HasHeight(){} // RVA: 0x5A5F650
        public void ClearHeight(){} // RVA: 0x5A5F660
        public void get_Width(){} // RVA: 0x5B20A90
        public void set_Width(){} // RVA: 0x5B108E0
        public void get_HasWidth(){} // RVA: 0x5A5FC10
        public void ClearWidth(){} // RVA: 0x5A5FC20
        public void get_Rotation(){} // RVA: 0x5B20B00
        public void set_Rotation(){} // RVA: 0x5B10960
        public void get_HasRotation(){} // RVA: 0x5A5FE80
        public void ClearRotation(){} // RVA: 0x5A5FE90
        public void get_RectId(){} // RVA: 0x5B20B70
        public void set_RectId(){} // RVA: 0x5B1FA40
        public void get_HasRectId(){} // RVA: 0x5AEC3A0
        public void ClearRectId(){} // RVA: 0x5AEC3B0
        public void Equals(){} // RVA: 0x5B20C40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B20EE0
        public void ToString(){} // RVA: 0x5B21100
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B21150
        public void CalculateSize(){} // RVA: 0x5B21290
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B21510
        public void .cctor(){} // RVA: 0x5B21650
    }

}