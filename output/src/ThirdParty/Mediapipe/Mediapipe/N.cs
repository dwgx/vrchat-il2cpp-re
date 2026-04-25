// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 17
// Methods: 133

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class NativeCategory : ValueType
    {
        public int categoryName; // 0x10
        public float displayName; // 0x14
        public UIntPtr _categoryName; // 0x18
        public UIntPtr _displayName; // 0x20

        // ── Methods ──
        public void get_categoryName(){} // RVA: 0x7FFAC82730D0
        public void get_displayName(){} // RVA: 0x7FFAC8273140
    }

    public class NativeClassificationResult : ValueType
    {
        public UIntPtr classifications; // 0x10
        public uint classificationsCount; // 0x18
        public long timestampMs; // 0x20
        public bool hasTimestampMs; // 0x28

        // ── Methods ──
        public void get_classifications(){} // RVA: 0x7FFAC8273280
        public void Dispose(){} // RVA: 0x7FFAC82732E0
    }

    public class NativeClassifications : ValueType
    {
        public UIntPtr categories; // 0x10
        public uint headName; // 0x18
        public int headIndex; // 0x1C
        public UIntPtr _headName; // 0x20

        // ── Methods ──
        public void get_categories(){} // RVA: 0x7FFAC82731B0
        public void get_headName(){} // RVA: 0x7FFAC8273210
    }

    public class NativeDetection : ValueType
    {
        public UIntPtr categories; // 0x10
        public uint keypoints; // 0x18
        public Mediapipe.NativeRect boundingBox; // 0x1C
        public UIntPtr _keypoints; // 0x30
        public uint keypointsCount; // 0x38

        // ── Methods ──
        public void get_categories(){} // RVA: 0x7FFAC8273400
        public void get_keypoints(){} // RVA: 0x7FFAC8273460
    }

    public class NativeDetectionResult : ValueType
    {
        public UIntPtr _detections; // 0x10
        public uint detectionsCount; // 0x18

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFAC82734C0
        public void Dispose(){} // RVA: 0x7FFAC8273520
    }

    public class NativeLandmark : ValueType
    {
        public float name; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public bool hasVisibility; // 0x1C
        public float visibility; // 0x20
        public bool hasPresence; // 0x24
        public float presence; // 0x28
        public UIntPtr _name; // 0x30

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC8273660
    }

    public class NativeLandmarks : ValueType
    {
        public UIntPtr _landmarks; // 0x10
        public uint landmarksCount; // 0x18

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFAC8273740
    }

    public class NativeLandmarksArray : ValueType
    {
        public UIntPtr _data; // 0x10
        public int size; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC8273800
        public void AsReadOnlySpan(){} // RVA: 0x7FFAC82738D0
    }

    public class NativeNormalizedKeypoint : ValueType
    {
        public float label; // 0x10
        public float y; // 0x14
        public UIntPtr _label; // 0x18
        public float score; // 0x20
        public bool hasScore; // 0x24

        // ── Methods ──
        public void get_label(){} // RVA: 0x7FFAC82735F0
    }

    public class NativeNormalizedLandmark : ValueType
    {
        public float name; // 0x10
        public float y; // 0x14
        public float z; // 0x18
        public bool hasVisibility; // 0x1C
        public float visibility; // 0x20
        public bool hasPresence; // 0x24
        public float presence; // 0x28
        public UIntPtr _name; // 0x30

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC82736D0
    }

    public class NativeNormalizedLandmarks : ValueType
    {
        public UIntPtr _landmarks; // 0x10
        public uint landmarksCount; // 0x18

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFAC82737A0
    }

    public class NativeNormalizedLandmarksArray : ValueType
    {
        public UIntPtr _data; // 0x10
        public int size; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFAC8273930
        public void AsReadOnlySpan(){} // RVA: 0x7FFAC8273A00
    }

    public class NativeRect : ValueType
    {
        public int left; // 0x10
        public int top; // 0x14
        public int bottom; // 0x18
        public int right; // 0x1C
    }

    public class NormalizedLandmark : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.NormalizedLandmark> Parser;
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
        public void get_Parser(){} // RVA: 0x7FFAC82AA950
        public void get_Descriptor(){} // RVA: 0x7FFAC82AA9B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82AAA70
        public void .ctor(){} // RVA: 0x7FFAC82A79E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82AAB60
        public void get_X(){} // RVA: 0x7FFAC82AAC90
        public void set_X(){} // RVA: 0x7FFAC82A7C80
        public void get_HasX(){} // RVA: 0x7FFAC81F3770
        public void ClearX(){} // RVA: 0x7FFAC81F3780
        public void get_Y(){} // RVA: 0x7FFAC82AAD00
        public void set_Y(){} // RVA: 0x7FFAC829E080
        public void get_HasY(){} // RVA: 0x7FFAC81F3810
        public void ClearY(){} // RVA: 0x7FFAC81F3820
        public void get_Z(){} // RVA: 0x7FFAC82AAD70
        public void set_Z(){} // RVA: 0x7FFAC82A7D70
        public void get_HasZ(){} // RVA: 0x7FFAC81F6A10
        public void ClearZ(){} // RVA: 0x7FFAC81F6A20
        public void get_Visibility(){} // RVA: 0x7FFAC82AADE0
        public void set_Visibility(){} // RVA: 0x7FFAC82A7DF0
        public void get_HasVisibility(){} // RVA: 0x7FFAC81F6FD0
        public void ClearVisibility(){} // RVA: 0x7FFAC81F6FE0
        public void get_Presence(){} // RVA: 0x7FFAC82AAE50
        public void set_Presence(){} // RVA: 0x7FFAC82A7E70
        public void get_HasPresence(){} // RVA: 0x7FFAC81F7240
        public void ClearPresence(){} // RVA: 0x7FFAC81F7250
        public void Equals(){} // RVA: 0x7FFAC82AAF20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82AB1A0
        public void ToString(){} // RVA: 0x7FFAC82AB3B0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82AB400
        public void CalculateSize(){} // RVA: 0x7FFAC82A84D0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82A86A0
        public void .cctor(){} // RVA: 0x7FFAC82AB670
    }

    public class NormalizedLandmarkList : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.NormalizedLandmarkList> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor;
        public Google.Protobuf.FieldCodec`1<Mediapipe.NormalizedLandmark> Landmark; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.NormalizedLandmark> landmark_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82AB920
        public void get_Descriptor(){} // RVA: 0x7FFAC82AB980
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82ABA40
        public void .ctor(){} // RVA: 0x7FFAC82ABBF0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82ABD90
        public void get_Landmark(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC82AC060 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC82AC110
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82AC160
        public void CalculateSize(){} // RVA: 0x7FFAC82AC220
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82AC410
        public void .cctor(){} // RVA: 0x7FFAC82AC510
    }

    public class NormalizedLandmarkListCollection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.NormalizedLandmarkListCollection> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.NormalizedLandmarkList> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.NormalizedLandmarkList> LandmarkList; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82AC890
        public void get_Descriptor(){} // RVA: 0x7FFAC82AC8F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82AC9B0
        public void .ctor(){} // RVA: 0x7FFAC82ACB60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82ACD00
        public void get_LandmarkList(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC82ACFD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC82AD080
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82AD0D0
        public void CalculateSize(){} // RVA: 0x7FFAC82AD190
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82AD380
        public void .cctor(){} // RVA: 0x7FFAC82AD480
    }

    public class NormalizedRect : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.NormalizedRect> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int XCenter;
        public float HasXCenter; // 0x8
        public float YCenter; // 0x1C
        public int HasYCenter;
        public float Height; // 0xC
        public float HasHeight; // 0x20
        public int Width;
        public float HasWidth; // 0x10
        public float Rotation; // 0x24
        public int HasRotation;
        public float RectId; // 0x14
        public float HasRectId; // 0x28
        public int RotationFieldNumber;
        public float RotationDefaultValue; // 0x18
        public float rotation_; // 0x2C
        public int RectIdFieldNumber;
        public long RectIdDefaultValue; // 0x20
        public long rectId_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82B7B10
        public void get_Descriptor(){} // RVA: 0x7FFAC82B7B70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82B7C30
        public void .ctor(){} // RVA: 0x7FFAC82B6A80 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82B7D20
        public void get_XCenter(){} // RVA: 0x7FFAC82B7E50
        public void set_XCenter(){} // RVA: 0x7FFAC82A7C80
        public void get_HasXCenter(){} // RVA: 0x7FFAC81F3770
        public void ClearXCenter(){} // RVA: 0x7FFAC81F3780
        public void get_YCenter(){} // RVA: 0x7FFAC82B7EC0
        public void set_YCenter(){} // RVA: 0x7FFAC829E080
        public void get_HasYCenter(){} // RVA: 0x7FFAC81F3810
        public void ClearYCenter(){} // RVA: 0x7FFAC81F3820
        public void get_Height(){} // RVA: 0x7FFAC82B7F30
        public void set_Height(){} // RVA: 0x7FFAC82A7D70
        public void get_HasHeight(){} // RVA: 0x7FFAC81F6A10
        public void ClearHeight(){} // RVA: 0x7FFAC81F6A20
        public void get_Width(){} // RVA: 0x7FFAC82B7FA0
        public void set_Width(){} // RVA: 0x7FFAC82A7DF0
        public void get_HasWidth(){} // RVA: 0x7FFAC81F6FD0
        public void ClearWidth(){} // RVA: 0x7FFAC81F6FE0
        public void get_Rotation(){} // RVA: 0x7FFAC82B8010
        public void set_Rotation(){} // RVA: 0x7FFAC82A7E70
        public void get_HasRotation(){} // RVA: 0x7FFAC81F7240
        public void ClearRotation(){} // RVA: 0x7FFAC81F7250
        public void get_RectId(){} // RVA: 0x7FFAC82B8080
        public void set_RectId(){} // RVA: 0x7FFAC82B6F50
        public void get_HasRectId(){} // RVA: 0x7FFAC82838B0
        public void ClearRectId(){} // RVA: 0x7FFAC82838C0
        public void Equals(){} // RVA: 0x7FFAC82B8150 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82B83F0
        public void ToString(){} // RVA: 0x7FFAC82B8610
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82B8660
        public void CalculateSize(){} // RVA: 0x7FFAC82B87A0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82B8A20
        public void .cctor(){} // RVA: 0x7FFAC82B8B60
    }

}