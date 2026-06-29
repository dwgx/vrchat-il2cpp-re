// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 16
// Methods: 121

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class NativeCategory : ValueType
    {
        public object index;
        public object score;
        public object _categoryName;
        public object _displayName;

        // ── Methods ──
        public void get_categoryName(){} // RVA: 0x8A5C20
        public void get_displayName(){} // RVA: 0x8A5C30
    }

    public class NativeClassificationResult : ValueType
    {
        public object _classifications;
        public object classificationsCount;
        public object timestampMs;
        public object hasTimestampMs;

        // ── Methods ──
        public void get_classifications(){} // RVA: 0x8A5D00
        public void Dispose(){} // RVA: 0x8A5D70
    }

    public class NativeClassifications : ValueType
    {
        public object _categories;
        public object categoriesCount;
        public object headIndex;
        public object _headName;

        // ── Methods ──
        public void get_categories(){} // RVA: 0x8A5C40
        public void get_headName(){} // RVA: 0x8A5CB0
    }

    public class NativeDetection : ValueType
    {
        public object _categories;
        public object categoriesCount;
        public object boundingBox;
        public object _keypoints;
        public object keypointsCount;

        // ── Methods ──
        public void get_categories(){} // RVA: 0x8A5D80
        public void get_keypoints(){} // RVA: 0x8A5DF0
    }

    public class NativeDetectionResult : ValueType
    {
        public object _detections;
        public object detectionsCount;

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x8A5E60
        public void Dispose(){} // RVA: 0x8A5ED0
    }

    public class NativeLandmark : ValueType
    {
        public object x;
        public object y;
        public object z;
        public object hasVisibility;
        public object visibility;
        public object hasPresence;
        public object presence;
        public object _name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x8A5F40
    }

    public class NativeLandmarks : ValueType
    {
        public object _landmarks;
        public object landmarksCount;

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x8A5F60
    }

    public class NativeLandmarksArray : ValueType
    {
        public object _data;
        public object size;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x8A6040
        public void AsReadOnlySpan(){} // RVA: 0x8A6050
    }

    public class NativeNormalizedKeypoint : ValueType
    {
        public object x;
        public object y;
        public object _label;
        public object score;
        public object hasScore;

        // ── Methods ──
        public void get_label(){} // RVA: 0x8A5F30
    }

    public class NativeNormalizedLandmark : ValueType
    {
        public object x;
        public object y;
        public object z;
        public object hasVisibility;
        public object visibility;
        public object hasPresence;
        public object presence;
        public object _name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x8A5F50
    }

    public class NativeNormalizedLandmarks : ValueType
    {
        public object _landmarks;
        public object landmarksCount;

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x8A5FD0
    }

    public class NativeNormalizedLandmarksArray : ValueType
    {
        public object _data;
        public object size;

        // ── Methods ──
        public void Dispose(){} // RVA: 0x8A60C0
        public void AsReadOnlySpan(){} // RVA: 0x8A60D0
    }

    public class NormalizedLandmark : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object XFieldNumber;
        public object XDefaultValue;
        public object x_;
        public object YFieldNumber;
        public object YDefaultValue;
        public object y_;
        public object ZFieldNumber;
        public object ZDefaultValue;
        public object z_;
        public object VisibilityFieldNumber;
        public object VisibilityDefaultValue;
        public object visibility_;
        public object PresenceFieldNumber;
        public object PresenceDefaultValue;
        public object presence_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x658D5E0
        public void get_Descriptor(){} // RVA: 0x658D640
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x658D700
        public void .ctor(){} // RVA: 0x658A670
        public void Clone(){} // RVA: 0x658D7F0
        public void get_X(){} // RVA: 0x658D920
        public void set_X(){} // RVA: 0x658A910
        public void get_HasX(){} // RVA: 0x64D65D0
        public void ClearX(){} // RVA: 0x64D65E0
        public void get_Y(){} // RVA: 0x658D990
        public void set_Y(){} // RVA: 0x6580EA0
        public void get_HasY(){} // RVA: 0x64D6670
        public void ClearY(){} // RVA: 0x64D6680
        public void get_Z(){} // RVA: 0x658DA00
        public void set_Z(){} // RVA: 0x658AA00
        public void get_HasZ(){} // RVA: 0x64D9870
        public void ClearZ(){} // RVA: 0x64D9880
        public void get_Visibility(){} // RVA: 0x658DA70
        public void set_Visibility(){} // RVA: 0x658AA80
        public void get_HasVisibility(){} // RVA: 0x64D9E30
        public void ClearVisibility(){} // RVA: 0x64D9E40
        public void get_Presence(){} // RVA: 0x658DAE0
        public void set_Presence(){} // RVA: 0x658AB00
        public void get_HasPresence(){} // RVA: 0x64DA0A0
        public void ClearPresence(){} // RVA: 0x64DA0B0
        public void Equals(){} // RVA: 0x658DBB0
        public void GetHashCode(){} // RVA: 0x658DE30
        public void ToString(){} // RVA: 0x658E040
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x658E090
        public void CalculateSize(){} // RVA: 0x658B160
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x658B330
        public void .cctor(){} // RVA: 0x658E300
    }

    public class NormalizedLandmarkList : Object
    {
        public object _parser;
        public object _unknownFields;
        public object LandmarkFieldNumber;
        public object _repeated_landmark_codec;
        public object landmark_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x658E5B0
        public void get_Descriptor(){} // RVA: 0x658E610
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x658E6D0
        public void .ctor(){} // RVA: 0x658E880
        public void Clone(){} // RVA: 0x658EA20
        public void get_Landmark(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x658ECF0
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x658EDA0
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x658EDF0
        public void CalculateSize(){} // RVA: 0x658EEB0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x658F0A0
        public void .cctor(){} // RVA: 0x658F1A0
    }

    public class NormalizedLandmarkListCollection : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _repeated_landmarkList_codec;
        public object landmarkList_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x658F520
        public void get_Descriptor(){} // RVA: 0x658F580
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x658F640
        public void .ctor(){} // RVA: 0x658F7F0
        public void Clone(){} // RVA: 0x658F990
        public void get_LandmarkList(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x658FC60
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x658FD10
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x658FD60
        public void CalculateSize(){} // RVA: 0x658FE20
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6590010
        public void .cctor(){} // RVA: 0x6590110
    }

    public class NormalizedRect : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object XCenterFieldNumber;
        public object XCenterDefaultValue;
        public object xCenter_;
        public object YCenterFieldNumber;
        public object YCenterDefaultValue;
        public object yCenter_;
        public object HeightFieldNumber;
        public object HeightDefaultValue;
        public object height_;
        public object WidthFieldNumber;
        public object WidthDefaultValue;
        public object width_;
        public object RotationFieldNumber;
        public object RotationDefaultValue;
        public object rotation_;
        public object RectIdFieldNumber;
        public object RectIdDefaultValue;
        public object rectId_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x659A520
        public void get_Descriptor(){} // RVA: 0x659A580
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x659A640
        public void .ctor(){} // RVA: 0x6599490
        public void Clone(){} // RVA: 0x659A730
        public void get_XCenter(){} // RVA: 0x659A860
        public void set_XCenter(){} // RVA: 0x658A910
        public void get_HasXCenter(){} // RVA: 0x64D65D0
        public void ClearXCenter(){} // RVA: 0x64D65E0
        public void get_YCenter(){} // RVA: 0x659A8D0
        public void set_YCenter(){} // RVA: 0x6580EA0
        public void get_HasYCenter(){} // RVA: 0x64D6670
        public void ClearYCenter(){} // RVA: 0x64D6680
        public void get_Height(){} // RVA: 0x659A940
        public void set_Height(){} // RVA: 0x658AA00
        public void get_HasHeight(){} // RVA: 0x64D9870
        public void ClearHeight(){} // RVA: 0x64D9880
        public void get_Width(){} // RVA: 0x659A9B0
        public void set_Width(){} // RVA: 0x658AA80
        public void get_HasWidth(){} // RVA: 0x64D9E30
        public void ClearWidth(){} // RVA: 0x64D9E40
        public void get_Rotation(){} // RVA: 0x659AA20
        public void set_Rotation(){} // RVA: 0x658AB00
        public void get_HasRotation(){} // RVA: 0x64DA0A0
        public void ClearRotation(){} // RVA: 0x64DA0B0
        public void get_RectId(){} // RVA: 0x659AA90
        public void set_RectId(){} // RVA: 0x6599960
        public void get_HasRectId(){} // RVA: 0x6566B50
        public void ClearRectId(){} // RVA: 0x6566B60
        public void Equals(){} // RVA: 0x659AB60
        public void GetHashCode(){} // RVA: 0x659AE00
        public void ToString(){} // RVA: 0x659B020
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x659B070
        public void CalculateSize(){} // RVA: 0x659B1B0
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x659B430
        public void .cctor(){} // RVA: 0x659B570
    }

}