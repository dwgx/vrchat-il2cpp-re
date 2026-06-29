// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 16
// Methods: 121

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class NativeCategory : ValueType
    {
        // ── Methods ──
        public void get_categoryName(){} // RVA: 0x7A7E2A1E0
        public void get_displayName(){} // RVA: 0x7A7E2A1F0
    }

    public class NativeClassificationResult : ValueType
    {
        // ── Methods ──
        public void get_classifications(){} // RVA: 0x7A7E2A2C0
        public void Dispose(){} // RVA: 0x7A7E2A330
    }

    public class NativeClassifications : ValueType
    {
        // ── Methods ──
        public void get_categories(){} // RVA: 0x7A7E2A200
        public void get_headName(){} // RVA: 0x7A7E2A270
    }

    public class NativeDetection : ValueType
    {
        // ── Methods ──
        public void get_categories(){} // RVA: 0x7A7E2A340
        public void get_keypoints(){} // RVA: 0x7A7E2A3B0
    }

    public class NativeDetectionResult : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7A7E2A420
        public void Dispose(){} // RVA: 0x7A7E2A490
    }

    public class NativeLandmark : ValueType
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A7E2A500
    }

    public class NativeLandmarks : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7A7E2A520
    }

    public class NativeLandmarksArray : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7A7E2A600
        public void AsReadOnlySpan(){} // RVA: 0x7A7E2A610
    }

    public class NativeNormalizedKeypoint : ValueType
    {
        // ── Methods ──
        public void get_label(){} // RVA: 0x7A7E2A4F0
    }

    public class NativeNormalizedLandmark : ValueType
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A7E2A510
    }

    public class NativeNormalizedLandmarks : ValueType
    {
        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7A7E2A590
    }

    public class NativeNormalizedLandmarksArray : ValueType
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7A7E2A680
        public void AsReadOnlySpan(){} // RVA: 0x7A7E2A690
    }

    public class NormalizedLandmark : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD900950
        public void get_Descriptor(){} // RVA: 0x7AD9009B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD900A70
        public void .ctor(){} // RVA: 0x7AD8FD9E0
        public void Clone(){} // RVA: 0x7AD900B60
        public void get_X(){} // RVA: 0x7AD900C90
        public void set_X(){} // RVA: 0x7AD8FDC80
        public void get_HasX(){} // RVA: 0x7AD848D40
        public void ClearX(){} // RVA: 0x7AD848D50
        public void get_Y(){} // RVA: 0x7AD900D00
        public void set_Y(){} // RVA: 0x7AD8F4080
        public void get_HasY(){} // RVA: 0x7AD848DE0
        public void ClearY(){} // RVA: 0x7AD848DF0
        public void get_Z(){} // RVA: 0x7AD900D70
        public void set_Z(){} // RVA: 0x7AD8FDD70
        public void get_HasZ(){} // RVA: 0x7AD84BFE0
        public void ClearZ(){} // RVA: 0x7AD84BFF0
        public void get_Visibility(){} // RVA: 0x7AD900DE0
        public void set_Visibility(){} // RVA: 0x7AD8FDDF0
        public void get_HasVisibility(){} // RVA: 0x7AD84C5A0
        public void ClearVisibility(){} // RVA: 0x7AD84C5B0
        public void get_Presence(){} // RVA: 0x7AD900E50
        public void set_Presence(){} // RVA: 0x7AD8FDE70
        public void get_HasPresence(){} // RVA: 0x7AD84C810
        public void ClearPresence(){} // RVA: 0x7AD84C820
        public void Equals(){} // RVA: 0x7AD900F20
        public void GetHashCode(){} // RVA: 0x7AD9011A0
        public void ToString(){} // RVA: 0x7AD9013B0
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD901400
        public void CalculateSize(){} // RVA: 0x7AD8FE4D0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD8FE6A0
        public void .cctor(){} // RVA: 0x7AD901670
    }

    public class NormalizedLandmarkList : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD901920
        public void get_Descriptor(){} // RVA: 0x7AD901980
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD901A40
        public void .ctor(){} // RVA: 0x7AD901BF0
        public void Clone(){} // RVA: 0x7AD901D90
        public void get_Landmark(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7AD902060
        public void GetHashCode(){} // RVA: 0x7AD82A430
        public void ToString(){} // RVA: 0x7AD902110
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD902160
        public void CalculateSize(){} // RVA: 0x7AD902220
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD902410
        public void .cctor(){} // RVA: 0x7AD902510
    }

    public class NormalizedLandmarkListCollection : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD902890
        public void get_Descriptor(){} // RVA: 0x7AD9028F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD9029B0
        public void .ctor(){} // RVA: 0x7AD902B60
        public void Clone(){} // RVA: 0x7AD902D00
        public void get_LandmarkList(){} // RVA: 0x7A80DA7B0
        public void Equals(){} // RVA: 0x7AD902FD0
        public void GetHashCode(){} // RVA: 0x7AD82A430
        public void ToString(){} // RVA: 0x7AD903080
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD9030D0
        public void CalculateSize(){} // RVA: 0x7AD903190
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD903380
        public void .cctor(){} // RVA: 0x7AD903480
    }

    public class NormalizedRect : Object
    {
        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7AD90DA10
        public void get_Descriptor(){} // RVA: 0x7AD90DA70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7AD90DB30
        public void .ctor(){} // RVA: 0x7AD90C980
        public void Clone(){} // RVA: 0x7AD90DC20
        public void get_XCenter(){} // RVA: 0x7AD90DD50
        public void set_XCenter(){} // RVA: 0x7AD8FDC80
        public void get_HasXCenter(){} // RVA: 0x7AD848D40
        public void ClearXCenter(){} // RVA: 0x7AD848D50
        public void get_YCenter(){} // RVA: 0x7AD90DDC0
        public void set_YCenter(){} // RVA: 0x7AD8F4080
        public void get_HasYCenter(){} // RVA: 0x7AD848DE0
        public void ClearYCenter(){} // RVA: 0x7AD848DF0
        public void get_Height(){} // RVA: 0x7AD90DE30
        public void set_Height(){} // RVA: 0x7AD8FDD70
        public void get_HasHeight(){} // RVA: 0x7AD84BFE0
        public void ClearHeight(){} // RVA: 0x7AD84BFF0
        public void get_Width(){} // RVA: 0x7AD90DEA0
        public void set_Width(){} // RVA: 0x7AD8FDDF0
        public void get_HasWidth(){} // RVA: 0x7AD84C5A0
        public void ClearWidth(){} // RVA: 0x7AD84C5B0
        public void get_Rotation(){} // RVA: 0x7AD90DF10
        public void set_Rotation(){} // RVA: 0x7AD8FDE70
        public void get_HasRotation(){} // RVA: 0x7AD84C810
        public void ClearRotation(){} // RVA: 0x7AD84C820
        public void get_RectId(){} // RVA: 0x7AD90DF80
        public void set_RectId(){} // RVA: 0x7AD90CE50
        public void get_HasRectId(){} // RVA: 0x7AD8D9A30
        public void ClearRectId(){} // RVA: 0x7AD8D9A40
        public void Equals(){} // RVA: 0x7AD90E050
        public void GetHashCode(){} // RVA: 0x7AD90E2F0
        public void ToString(){} // RVA: 0x7AD90E510
        public void WriteTo(){} // RVA: 0x7AD825C30
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7AD90E560
        public void CalculateSize(){} // RVA: 0x7AD90E6A0
        public void MergeFrom(){} // RVA: 0x7AD825F70
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7AD90E920
        public void .cctor(){} // RVA: 0x7AD90EA60
    }

}