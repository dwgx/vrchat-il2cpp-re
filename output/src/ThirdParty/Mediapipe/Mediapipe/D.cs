// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 4
// Methods: 74

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Detection
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Detection> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public int _hasBits0; // 0x18
        public int LabelFieldNumber;
        public Google.Protobuf.FieldCodec`1<string> _repeated_label_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<string> label_; // 0x20
        public int LabelIdFieldNumber;
        public Google.Protobuf.FieldCodec`1<int> _repeated_labelId_codec; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<int> labelId_; // 0x28
        public int ScoreFieldNumber;
        public Google.Protobuf.FieldCodec`1<float> _repeated_score_codec; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<float> score_; // 0x30
        public int LocationDataFieldNumber;
        public Mediapipe.LocationData locationData_; // 0x38
        public int FeatureTagFieldNumber;
        public string FeatureTagDefaultValue; // 0x20
        public string featureTag_; // 0x40

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B0A460
        public void get_Descriptor(){} // RVA: 0x5B0A4C0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B0A580
        public void .ctor(){} // RVA: 0x5B0A8D0 | overloaded x2
        public void Clone(){} // RVA: 0x5B0ADA0
        public void get_Label(){} // RVA: 0x30B0C0
        public void get_LabelId(){} // RVA: 0x30B130
        public void get_Score(){} // RVA: 0x6374D0
        public void get_LocationData(){} // RVA: 0x4976A0
        public void set_LocationData(){} // RVA: 0x49B830
        public void get_FeatureTag(){} // RVA: 0x5B0AE00
        public void set_FeatureTag(){} // RVA: 0x5B0AE70
        public void get_HasFeatureTag(){} // RVA: 0x51555F0
        public void ClearFeatureTag(){} // RVA: 0x5A5F950
        public void get_TrackId(){} // RVA: 0x5B0AF70
        public void set_TrackId(){} // RVA: 0x5B0AFE0
        public void get_HasTrackId(){} // RVA: 0x5A5FB20
        public void ClearTrackId(){} // RVA: 0x5A5FB30
        public void get_DetectionId(){} // RVA: 0x5B0B0E0
        public void set_DetectionId(){} // RVA: 0x5B0B150
        public void get_HasDetectionId(){} // RVA: 0x5A5C3B0
        public void ClearDetectionId(){} // RVA: 0x5A5C3C0
        public void get_AssociatedDetections(){} // RVA: 0x3A5500
        public void get_DisplayName(){} // RVA: 0x37B370
        public void get_TimestampUsec(){} // RVA: 0x5B0B160
        public void set_TimestampUsec(){} // RVA: 0x5B0B1D0
        public void get_HasTimestampUsec(){} // RVA: 0x5A5C450
        public void ClearTimestampUsec(){} // RVA: 0x5A5C460
        public void Equals(){} // RVA: 0x5B0B240 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5B0B500
        public void ToString(){} // RVA: 0x5B0B6C0
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B0B710
        public void CalculateSize(){} // RVA: 0x5B0B9A0
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B0C040
        public void .cctor(){} // RVA: 0x5B0C400
    }

    public class DetectionList
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.DetectionList> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.Detection> _repeated_detection_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.Detection> detection_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x5B0D850
        public void get_Descriptor(){} // RVA: 0x5B0D8B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x5B0D970
        public void .ctor(){} // RVA: 0x5B0DB20 | overloaded x2
        public void Clone(){} // RVA: 0x5B0DCC0
        public void get_Detection(){} // RVA: 0x2E07C0
        public void Equals(){} // RVA: 0x5B0DF90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5A3DF40
        public void ToString(){} // RVA: 0x5B0E040
        public void WriteTo(){} // RVA: 0x5A39740
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x5B0E090
        public void CalculateSize(){} // RVA: 0x5B0E150
        public void MergeFrom(){} // RVA: 0x5A39A80 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x5B0E340
        public void .cctor(){} // RVA: 0x5B0E440
    }

    public class DetectionReflection
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x5B098E0
        public void .cctor(){} // RVA: 0x5B09940
    }

    public class DisposableObject
    {
        public int _disposeSignaled; // 0x10
        public bool _isLocked; // 0x14

        // ── Methods ──
        public void get_isDisposed(){} // RVA: 0x5992B0
        public void set_isDisposed(){} // RVA: 0x195A9C0
        public void get_isOwner(){} // RVA: 0x195A990
        public void set_isOwner(){} // RVA: 0x195A9D0
        public void .ctor(){} // RVA: 0x5AD32E0
        public void Dispose(){} // RVA: 0x5AD3360 | overloaded x2
        public void Finalize(){} // RVA: 0x5AAC950
        public void DisposeManaged(){} // RVA: 0x2DD310
        public void DisposeUnmanaged(){} // RVA: 0x2DD310
        public void Lock(){} // RVA: 0x12141D0
        public void Unlock(){} // RVA: 0x1214040
        public void TransferOwnership(){} // RVA: 0x5AD3410
        public void ThrowIfDisposed(){} // RVA: 0x5AD3420
    }

}