// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 4
// Methods: 67

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class Detection : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _hasBits0;
        public object LabelFieldNumber;
        public object _repeated_label_codec;
        public object label_;
        public object LabelIdFieldNumber;
        public object _repeated_labelId_codec;
        public object labelId_;
        public object ScoreFieldNumber;
        public object _repeated_score_codec;
        public object score_;
        public object LocationDataFieldNumber;
        public object locationData_;
        public object FeatureTagFieldNumber;
        public object FeatureTagDefaultValue;
        public object featureTag_;
        public object TrackIdFieldNumber;
        public object TrackIdDefaultValue;
        public object trackId_;
        public object DetectionIdFieldNumber;
        public object DetectionIdDefaultValue;
        public object detectionId_;
        public object AssociatedDetectionsFieldNumber;
        public object _repeated_associatedDetections_codec;
        public object associatedDetections_;
        public object DisplayNameFieldNumber;
        public object _repeated_displayName_codec;
        public object displayName_;
        public object TimestampUsecFieldNumber;
        public object TimestampUsecDefaultValue;
        public object timestampUsec_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6584720
        public void get_Descriptor(){} // RVA: 0x6584780
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6584840
        public void .ctor(){} // RVA: 0x6584B90
        public void Clone(){} // RVA: 0x6585060
        public void get_Label(){} // RVA: 0xB700F0
        public void get_LabelId(){} // RVA: 0xB70160
        public void get_Score(){} // RVA: 0xD33E60
        public void get_LocationData(){} // RVA: 0xD05CA0
        public void set_LocationData(){} // RVA: 0xD09D70
        public void get_FeatureTag(){} // RVA: 0x65850C0
        public void set_FeatureTag(){} // RVA: 0x6585130
        public void get_HasFeatureTag(){} // RVA: 0x5BC22C0
        public void ClearFeatureTag(){} // RVA: 0x64D9B70
        public void get_TrackId(){} // RVA: 0x6585230
        public void set_TrackId(){} // RVA: 0x65852A0
        public void get_HasTrackId(){} // RVA: 0x64D9D40
        public void ClearTrackId(){} // RVA: 0x64D9D50
        public void get_DetectionId(){} // RVA: 0x65853A0
        public void set_DetectionId(){} // RVA: 0x6585410
        public void get_HasDetectionId(){} // RVA: 0x64D65D0
        public void ClearDetectionId(){} // RVA: 0x64D65E0
        public void get_AssociatedDetections(){} // RVA: 0xC0FFC0
        public void get_DisplayName(){} // RVA: 0xBE2C60
        public void get_TimestampUsec(){} // RVA: 0x6585420
        public void set_TimestampUsec(){} // RVA: 0x6585490
        public void get_HasTimestampUsec(){} // RVA: 0x64D6670
        public void ClearTimestampUsec(){} // RVA: 0x64D6680
        public void Equals(){} // RVA: 0x6585500
        public void GetHashCode(){} // RVA: 0x65857C0
        public void ToString(){} // RVA: 0x6585980
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x65859D0
        public void CalculateSize(){} // RVA: 0x6585C60
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6586300
        public void .cctor(){} // RVA: 0x65866C0
    }

    public class DetectionList : Object
    {
        public object _parser;
        public object _unknownFields;
        public object _repeated_detection_codec;
        public object detection_;

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x6587B10
        public void get_Descriptor(){} // RVA: 0x6587B70
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x6587C30
        public void .ctor(){} // RVA: 0x6587DE0
        public void Clone(){} // RVA: 0x6587F80
        public void get_Detection(){} // RVA: 0xB465B0
        public void Equals(){} // RVA: 0x6588250
        public void GetHashCode(){} // RVA: 0x64B8050
        public void ToString(){} // RVA: 0x6588300
        public void WriteTo(){} // RVA: 0x64B3910
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x6588350
        public void CalculateSize(){} // RVA: 0x6588410
        public void MergeFrom(){} // RVA: 0x64B3C50
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x6588600
        public void .cctor(){} // RVA: 0x6588700
    }

    public class DetectionReflection : Object
    {
        public object descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x6583C10
        public void .cctor(){} // RVA: 0x6583C70
    }

    public class DisposableObject : Object
    {
        public object _disposeSignaled;
        public object _isLocked;
        public object _isDisposed;
        public object _isOwner;

        // ── Methods ──
        public void get_isDisposed(){} // RVA: 0xE2F5E0
        public void set_isDisposed(){} // RVA: 0x2220220
        public void get_isOwner(){} // RVA: 0x2220250
        public void set_isOwner(){} // RVA: 0x2220260
        public void .ctor(){} // RVA: 0x654DB40
        public void Dispose(){} // RVA: 0x654DBC0
        public void Finalize(){} // RVA: 0x6527310
        public void DisposeManaged(){} // RVA: 0xB43310
        public void DisposeUnmanaged(){} // RVA: 0xB43310
        public void Lock(){} // RVA: 0x1AEDC60
        public void Unlock(){} // RVA: 0x1AEE0C0
        public void TransferOwnership(){} // RVA: 0x654DC70
        public void ThrowIfDisposed(){} // RVA: 0x654DC80
    }

}