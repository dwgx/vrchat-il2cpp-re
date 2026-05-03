// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 4
// Methods: 74

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Detection : Object
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
        public void get_Parser(){} // RVA: 0x7FFE8664B290
        public void get_Descriptor(){} // RVA: 0x7FFE8664B2F0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8664B3B0
        public void .ctor(){} // RVA: 0x7FFE8664B700 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8664BBD0
        public void get_Label(){} // RVA: 0x7FFE811290C0
        public void get_LabelId(){} // RVA: 0x7FFE81129130
        public void get_Score(){} // RVA: 0x7FFE8144E200
        public void get_LocationData(){} // RVA: 0x7FFE8143BA80
        public void set_LocationData(){} // RVA: 0x7FFE81437330
        public void get_FeatureTag(){} // RVA: 0x7FFE8664BC30
        public void set_FeatureTag(){} // RVA: 0x7FFE8664BCA0
        public void get_HasFeatureTag(){} // RVA: 0x7FFE85C00F00
        public void ClearFeatureTag(){} // RVA: 0x7FFE865A0650
        public void get_TrackId(){} // RVA: 0x7FFE8664BDA0
        public void set_TrackId(){} // RVA: 0x7FFE8664BE10
        public void get_HasTrackId(){} // RVA: 0x7FFE865A0820
        public void ClearTrackId(){} // RVA: 0x7FFE865A0830
        public void get_DetectionId(){} // RVA: 0x7FFE8664BF10
        public void set_DetectionId(){} // RVA: 0x7FFE8664BF80
        public void get_HasDetectionId(){} // RVA: 0x7FFE8659D0B0
        public void ClearDetectionId(){} // RVA: 0x7FFE8659D0C0
        public void get_AssociatedDetections(){} // RVA: 0x7FFE811C3500
        public void get_DisplayName(){} // RVA: 0x7FFE81199370
        public void get_TimestampUsec(){} // RVA: 0x7FFE8664BF90
        public void set_TimestampUsec(){} // RVA: 0x7FFE8664C000
        public void get_HasTimestampUsec(){} // RVA: 0x7FFE8659D150
        public void ClearTimestampUsec(){} // RVA: 0x7FFE8659D160
        public void Equals(){} // RVA: 0x7FFE8664C070 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8664C330
        public void ToString(){} // RVA: 0x7FFE8664C4F0
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8664C540
        public void CalculateSize(){} // RVA: 0x7FFE8664C7D0
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8664CE70
        public void .cctor(){} // RVA: 0x7FFE8664D230
    }

    public class DetectionList : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.DetectionList> _parser;
        public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.Detection> _repeated_detection_codec; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.Detection> detection_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFE8664E680
        public void get_Descriptor(){} // RVA: 0x7FFE8664E6E0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8664E7A0
        public void .ctor(){} // RVA: 0x7FFE8664E950 | overloaded x2
        public void Clone(){} // RVA: 0x7FFE8664EAF0
        public void get_Detection(){} // RVA: 0x7FFE810FE7C0
        public void Equals(){} // RVA: 0x7FFE8664EDC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8657ECA0
        public void ToString(){} // RVA: 0x7FFE8664EE70
        public void WriteTo(){} // RVA: 0x7FFE8657A4A0
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8664EEC0
        public void CalculateSize(){} // RVA: 0x7FFE8664EF80
        public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8664F170
        public void .cctor(){} // RVA: 0x7FFE8664F270
    }

    public class DetectionReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFE8664A710
        public void .cctor(){} // RVA: 0x7FFE8664A770
    }

    public class DisposableObject : Object
    {
        public int _disposeSignaled; // 0x10
        public bool _isLocked; // 0x14

        // ── Methods ──
        public void get_isDisposed(){} // RVA: 0x7FFE8139AC40
        public void set_isDisposed(){} // RVA: 0x7FFE826E34C0
        public void get_isOwner(){} // RVA: 0x7FFE826E34B0
        public void set_isOwner(){} // RVA: 0x7FFE826E34D0
        public void .ctor(){} // RVA: 0x7FFE86614110
        public void Dispose(){} // RVA: 0x7FFE86614190 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void DisposeManaged(){} // RVA: 0x7FFE810FB310
        public void DisposeUnmanaged(){} // RVA: 0x7FFE810FB310
        public void Lock(){} // RVA: 0x7FFE81F886C0
        public void Unlock(){} // RVA: 0x7FFE81F886B0
        public void TransferOwnership(){} // RVA: 0x7FFE86614240
        public void ThrowIfDisposed(){} // RVA: 0x7FFE86614250
    }

}