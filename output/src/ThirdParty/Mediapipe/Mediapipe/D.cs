// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 4
// Methods: 74

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Detection : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.Detection> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Label;
        public Google.Protobuf.FieldCodec`1<string> LabelId; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<string> Score; // 0x20
        public int LocationData;
        public Google.Protobuf.FieldCodec`1<int> FeatureTag; // 0x10
        public Google.Protobuf.Collections.RepeatedField`1<int> HasFeatureTag; // 0x28
        public int TrackId;
        public Google.Protobuf.FieldCodec`1<float> HasTrackId; // 0x18
        public Google.Protobuf.Collections.RepeatedField`1<float> DetectionId; // 0x30
        public int HasDetectionId;
        public Mediapipe.LocationData AssociatedDetections; // 0x38
        public int DisplayName;
        public string TimestampUsec; // 0x20
        public string HasTimestampUsec; // 0x40
        public int TrackIdFieldNumber;
        public string TrackIdDefaultValue; // 0x28
        public string trackId_; // 0x48
        public int DetectionIdFieldNumber;
        public long DetectionIdDefaultValue; // 0x30
        public long detectionId_; // 0x50
        public int AssociatedDetectionsFieldNumber;
        public Google.Protobuf.FieldCodec`1<AssociatedDetection> _repeated_associatedDetections_codec; // 0x38
        public Google.Protobuf.Collections.RepeatedField`1<AssociatedDetection> associatedDetections_; // 0x58
        public int DisplayNameFieldNumber;
        public Google.Protobuf.FieldCodec`1<string> _repeated_displayName_codec; // 0x40
        public Google.Protobuf.Collections.RepeatedField`1<string> displayName_; // 0x60
        public int TimestampUsecFieldNumber;
        public long TimestampUsecDefaultValue; // 0x48
        public long timestampUsec_; // 0x68

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82A1970
        public void get_Descriptor(){} // RVA: 0x7FFAC82A19D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82A1A90
        public void .ctor(){} // RVA: 0x7FFAC82A1DE0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82A22B0
        public void get_Label(){} // RVA: 0x7FFAC2F4F0C0
        public void get_LabelId(){} // RVA: 0x7FFAC2F4F130
        public void get_Score(){} // RVA: 0x7FFAC31D95E0
        public void get_LocationData(){} // RVA: 0x7FFAC31D0140
        public void set_LocationData(){} // RVA: 0x7FFAC31D0C20
        public void get_FeatureTag(){} // RVA: 0x7FFAC82A2310
        public void set_FeatureTag(){} // RVA: 0x7FFAC82A2380
        public void get_HasFeatureTag(){} // RVA: 0x7FFAC781E0B0
        public void ClearFeatureTag(){} // RVA: 0x7FFAC81F6D10
        public void get_TrackId(){} // RVA: 0x7FFAC82A2480
        public void set_TrackId(){} // RVA: 0x7FFAC82A24F0
        public void get_HasTrackId(){} // RVA: 0x7FFAC81F6EE0
        public void ClearTrackId(){} // RVA: 0x7FFAC81F6EF0
        public void get_DetectionId(){} // RVA: 0x7FFAC82A25F0
        public void set_DetectionId(){} // RVA: 0x7FFAC82A2660
        public void get_HasDetectionId(){} // RVA: 0x7FFAC81F3770
        public void ClearDetectionId(){} // RVA: 0x7FFAC81F3780
        public void get_AssociatedDetections(){} // RVA: 0x7FFAC2FE9500
        public void get_DisplayName(){} // RVA: 0x7FFAC2FBF370
        public void get_TimestampUsec(){} // RVA: 0x7FFAC82A2670
        public void set_TimestampUsec(){} // RVA: 0x7FFAC82A26E0
        public void get_HasTimestampUsec(){} // RVA: 0x7FFAC81F3810
        public void ClearTimestampUsec(){} // RVA: 0x7FFAC81F3820
        public void Equals(){} // RVA: 0x7FFAC82A2750 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC82A2A10
        public void ToString(){} // RVA: 0x7FFAC82A2BD0
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82A2C20
        public void CalculateSize(){} // RVA: 0x7FFAC82A2EB0
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82A3550
        public void .cctor(){} // RVA: 0x7FFAC82A3910
    }

    public class DetectionList : Object
    {
        public Google.Protobuf.MessageParser`1<Mediapipe.DetectionList> Parser;
        public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
        public Google.Protobuf.FieldCodec`1<Mediapipe.Detection> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
        public Google.Protobuf.Collections.RepeatedField`1<Mediapipe.Detection> Detection; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFAC82A4D60
        public void get_Descriptor(){} // RVA: 0x7FFAC82A4DC0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82A4E80
        public void .ctor(){} // RVA: 0x7FFAC82A5030 | overloaded x2
        public void Clone(){} // RVA: 0x7FFAC82A51D0
        public void get_Detection(){} // RVA: 0x7FFAC2F247C0
        public void Equals(){} // RVA: 0x7FFAC82A54A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC81D5360
        public void ToString(){} // RVA: 0x7FFAC82A5550
        public void WriteTo(){} // RVA: 0x7FFAC81D0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82A55A0
        public void CalculateSize(){} // RVA: 0x7FFAC82A5660
        public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82A5850
        public void .cctor(){} // RVA: 0x7FFAC82A5950
    }

    public class DetectionReflection : Object
    {
        public Google.Protobuf.Reflection.FileDescriptor Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFAC82A0DF0
        public void .cctor(){} // RVA: 0x7FFAC82A0E50
    }

    public class DisposableObject : Object
    {
        public int isDisposed; // 0x10
        public bool isOwner; // 0x14
        public bool <isDisposed>k__BackingField; // 0x15
        public bool <isOwner>k__BackingField; // 0x16

        // ── Methods ──
        public void get_isDisposed(){} // RVA: 0x7FFAC3135090
        public void set_isDisposed(){} // RVA: 0x7FFAC4411DF0
        public void get_isOwner(){} // RVA: 0x7FFAC4411E30
        public void set_isOwner(){} // RVA: 0x7FFAC4411E20
        public void .ctor(){} // RVA: 0x7FFAC826A7F0
        public void Dispose(){} // RVA: 0x7FFAC826A870 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void DisposeManaged(){} // RVA: 0x7FFAC2F21310
        public void DisposeUnmanaged(){} // RVA: 0x7FFAC2F21310
        public void Lock(){} // RVA: 0x7FFAC3C92220
        public void Unlock(){} // RVA: 0x7FFAC3C92210
        public void TransferOwnership(){} // RVA: 0x7FFAC826A920
        public void ThrowIfDisposed(){} // RVA: 0x7FFAC826A930
    }

}