// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 17
// Methods: 133

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class NativeCategory : ValueType
    {
        public int index; // 0x10
        public float score; // 0x14

        // ── Methods ──
        public void get_categoryName(){} // RVA: 0x7FFE8661C9F0
        public void get_displayName(){} // RVA: 0x7FFE8661CA60
    }

    public class NativeClassificationResult : ValueType
    {
        public UIntPtr _classifications; // 0x10

        // ── Methods ──
        public void get_classifications(){} // RVA: 0x7FFE8661CBA0
        public void Dispose(){} // RVA: 0x7FFE8661CC00
    }

    public class NativeClassifications : ValueType
    {
        public UIntPtr _categories; // 0x10
        public uint categoriesCount; // 0x18

        // ── Methods ──
        public void get_categories(){} // RVA: 0x7FFE8661CAD0
        public void get_headName(){} // RVA: 0x7FFE8661CB30
    }

    public class NativeDetection : ValueType
    {
        public UIntPtr _categories; // 0x10
        public uint categoriesCount; // 0x18

        // ── Methods ──
        public void get_categories(){} // RVA: 0x7FFE8661CD20
        public void get_keypoints(){} // RVA: 0x7FFE8661CD80
    }

    public class NativeDetectionResult : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFE8661CDE0
        public void Dispose(){} // RVA: 0x7FFE8661CE40
    }

    public class NativeLandmark : ValueType
    {
        public float x; // 0x10

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8661CF80
    }

    public class NativeLandmarks : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFE8661D060
    }

    public class NativeLandmarksArray : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE8661D120
        public void AsReadOnlySpan(){} // RVA: 0x7FFE8661D1F0
    }

    public class NativeNormalizedKeypoint : ValueType
    {
        public float x; // 0x10

        // ── Methods ──
        public void get_label(){} // RVA: 0x7FFE8661CF10
    }

    public class NativeNormalizedLandmark : ValueType
    {
        public float x; // 0x10

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8661CFF0
    }

    public class NativeNormalizedLandmarks : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFE8661D0C0
    }

    public class NativeNormalizedLandmarksArray : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFE8661D250
        public void AsReadOnlySpan(){} // RVA: 0x7FFE8661D320
    }

    public class NativeRect : ValueType
    {
    }

    public class NormalizedLandmark : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.NormalizedLandmark> _parser;
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
        public void get_Parser(){} // RVA: 0x7FFE86654270
        public void get_Descriptor(){} // RVA: 0x7FFE866542D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86654390
        public void .ctor(){} // RVA: 0x7FFE86651300 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86654480
        public void get_X(){} // RVA: 0x7FFE866545B0
        public void set_X(){} // RVA: 0x7FFE866515A0
        public void get_HasX(){} // RVA: 0x7FFE8659D0B0
        public void ClearX(){} // RVA: 0x7FFE8659D0C0
        public void get_Y(){} // RVA: 0x7FFE86654620
        public void set_Y(){} // RVA: 0x7FFE866479A0
        public void get_HasY(){} // RVA: 0x7FFE8659D150
        public void ClearY(){} // RVA: 0x7FFE8659D160
        public void get_Z(){} // RVA: 0x7FFE86654690
        public void set_Z(){} // RVA: 0x7FFE86651690
        public void get_HasZ(){} // RVA: 0x7FFE865A0350
        public void ClearZ(){} // RVA: 0x7FFE865A0360
        public void get_Visibility(){} // RVA: 0x7FFE86654700
        public void set_Visibility(){} // RVA: 0x7FFE86651710
        public void get_HasVisibility(){} // RVA: 0x7FFE865A0910
        public void ClearVisibility(){} // RVA: 0x7FFE865A0920
        public void get_Presence(){} // RVA: 0x7FFE86654770
        public void set_Presence(){} // RVA: 0x7FFE86651790
        public void get_HasPresence(){} // RVA: 0x7FFE865A0B80
        public void ClearPresence(){} // RVA: 0x7FFE865A0B90
        public void Equals(){} // RVA: 0x7FFE86654840 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86654AC0
        public void ToString(){} // RVA: 0x7FFE86654CD0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86654D20
        public void CalculateSize(){} // RVA: 0x7FFE86651DF0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86651FC0
        public void .cctor(){} // RVA: 0x7FFE86654F90
    }

    public class NormalizedLandmarkList : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.NormalizedLandmarkList> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int LandmarkFieldNumber;
        public Google.Protobuf.FieldCodec`1<Mediapipe.NormalizedLandmark> _repeated_landmark_codec; // 0x8

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86655240
        public void get_Descriptor(){} // RVA: 0x7FFE866552A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86655360
        public void .ctor(){} // RVA: 0x7FFE86655510 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE866556B0
        public void get_Landmark(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE86655980 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE86655A30
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86655A80
        public void CalculateSize(){} // RVA: 0x7FFE86655B40
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86655D30
        public void .cctor(){} // RVA: 0x7FFE86655E30
    }

    public class NormalizedLandmarkListCollection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.NormalizedLandmarkListCollection> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.NormalizedLandmarkList> _repeated_landmarkList_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.NormalizedLandmarkList> landmarkList_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE866561B0
        public void get_Descriptor(){} // RVA: 0x7FFE86656210
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE866562D0
        public void .ctor(){} // RVA: 0x7FFE86656480 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86656620
        public void get_LandmarkList(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE866568F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE866569A0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE866569F0
        public void CalculateSize(){} // RVA: 0x7FFE86656AB0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86656CA0
        public void .cctor(){} // RVA: 0x7FFE86656DA0
    }

    public class NormalizedRect : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.NormalizedRect> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int XCenterFieldNumber;
        public float XCenterDefaultValue; // 0x8
        public float xCenter_; // 0x1C
        public int YCenterFieldNumber;
        public float YCenterDefaultValue; // 0xC
        public float yCenter_; // 0x20
        public int HeightFieldNumber;
        public float HeightDefaultValue; // 0x10
        public float height_; // 0x24
        public int WidthFieldNumber;
        public float WidthDefaultValue; // 0x14
        public float width_; // 0x28

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE86661430
        public void get_Descriptor(){} // RVA: 0x7FFE86661490
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE86661550
        public void .ctor(){} // RVA: 0x7FFE866603A0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE86661640
        public void get_XCenter(){} // RVA: 0x7FFE86661770
        public void set_XCenter(){} // RVA: 0x7FFE866515A0
        public void get_HasXCenter(){} // RVA: 0x7FFE8659D0B0
        public void ClearXCenter(){} // RVA: 0x7FFE8659D0C0
        public void get_YCenter(){} // RVA: 0x7FFE866617E0
        public void set_YCenter(){} // RVA: 0x7FFE866479A0
        public void get_HasYCenter(){} // RVA: 0x7FFE8659D150
        public void ClearYCenter(){} // RVA: 0x7FFE8659D160
        public void get_Height(){} // RVA: 0x7FFE86661850
        public void set_Height(){} // RVA: 0x7FFE86651690
        public void get_HasHeight(){} // RVA: 0x7FFE865A0350
        public void ClearHeight(){} // RVA: 0x7FFE865A0360
        public void get_Width(){} // RVA: 0x7FFE866618C0
        public void set_Width(){} // RVA: 0x7FFE86651710
        public void get_HasWidth(){} // RVA: 0x7FFE865A0910
        public void ClearWidth(){} // RVA: 0x7FFE865A0920
        public void get_Rotation(){} // RVA: 0x7FFE86661930
        public void set_Rotation(){} // RVA: 0x7FFE86651790
        public void get_HasRotation(){} // RVA: 0x7FFE865A0B80
        public void ClearRotation(){} // RVA: 0x7FFE865A0B90
        public void get_RectId(){} // RVA: 0x7FFE866619A0
        public void set_RectId(){} // RVA: 0x7FFE86660870
        public void get_HasRectId(){} // RVA: 0x7FFE8662D1D0
        public void ClearRectId(){} // RVA: 0x7FFE8662D1E0
        public void Equals(){} // RVA: 0x7FFE86661A70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86661D10
        public void ToString(){} // RVA: 0x7FFE86661F30
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE86661F80
        public void CalculateSize(){} // RVA: 0x7FFE866620C0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE86662340
        public void .cctor(){} // RVA: 0x7FFE86662480
    }

}