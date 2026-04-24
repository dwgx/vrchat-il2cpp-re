// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe
// Classes: 71
// Methods: 693

namespace ThirdParty.Mediapipe.Mediapipe
{
    public class BadStatusException : Exception
    {
        public etBestGrabbingType.ÎÏÏÍÎÎÏÌÎÌÏÏÍÍÌÌÌÏÏÌÏ statusCode; // 0x90

        // ── Methods ──
        public void set_statusCode(){} // RVA: 0x7FFD4E8F2750
        public void .ctor(){} // RVA: 0x7FFD5368A770
    }

    public class CalculatorGraph : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5368C5B0
        public void DeleteMpPtr(){} // RVA: 0x7FFD5368C6F0
        public void Initialize(){} // RVA: 0x7FFD5368C7B0
        public void ObserveOutputStream(){} // RVA: 0x7FFD5368C8F0
        public void AddOutputStreamPoller(){} // RVA: 0x7FFD4E0896F0
        public void StartRun(){} // RVA: 0x7FFD5368CA70
        public void WaitUntilDone(){} // RVA: 0x7FFD5368CBA0
        public void AddPacketToInputStream(){} // RVA: 0x7FFD4E099B30
        public void CloseAllPacketSources(){} // RVA: 0x7FFD5368CCB0
        public void SetGpuResources(){} // RVA: 0x7FFD5368CDC0
    }

    public class CalculatorGraphConfigExtension : Object
    {
        // ── Methods ──
        public void ParseFromTextFormat(){} // RVA: 0x7FFD5368CFD0
    }

    public class CalculatorOptions : Object
    {
        public gBox.itionBlend<etBestGrabbingType.?> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<etBestGrabbingType.?> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool MergeFields; // 0x8
        public bool HasMergeFields; // 0x24

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD536B9E20
        public void get_Descriptor(){} // RVA: 0x7FFD536B9E80
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536B9F40
        public void .ctor(){} // RVA: 0x7FFD536BA030 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536BA1C0
        public void get_MergeFields(){} // RVA: 0x7FFD536BA380
        public void set_MergeFields(){} // RVA: 0x7FFD53624E30
        public void get_HasMergeFields(){} // RVA: 0x7FFD53621340
        public void ClearMergeFields(){} // RVA: 0x7FFD53621350
        public void Equals(){} // RVA: 0x7FFD536BA500 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536BA5D0
        public void ToString(){} // RVA: 0x7FFD536BA690
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536BA6E0
        public void CalculateSize(){} // RVA: 0x7FFD536BA780
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536BA930
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD536BAA00
    }

    public class CalculatorReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536A9A30
        public void .cctor(){} // RVA: 0x7FFD536A9A90
    }

    public class Classification : Object
    {
        public gBox.itionBlend<etBestGrabbingType.nes_35> Parser;
        public gBox.ra Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Index;
        public int HasIndex; // 0x8
        public int Score; // 0x1C
        public int HasScore;
        public float Label; // 0xC
        public float HasLabel; // 0x20
        public int DisplayName;
        public string HasDisplayName; // 0x10
        public string label_; // 0x28
        public int DisplayNameFieldNumber;
        public string DisplayNameDefaultValue; // 0x18
        public string displayName_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD536BDA00
        public void get_Descriptor(){} // RVA: 0x7FFD536BDA60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536BDB20
        public void .ctor(){} // RVA: 0x7FFD536BDC10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536BDDC0
        public void get_Index(){} // RVA: 0x7FFD536BDFA0
        public void set_Index(){} // RVA: 0x7FFD53613760
        public void get_HasIndex(){} // RVA: 0x7FFD53613770
        public void ClearIndex(){} // RVA: 0x7FFD53613780
        public void get_Score(){} // RVA: 0x7FFD536BE010
        public void set_Score(){} // RVA: 0x7FFD536BE080
        public void get_HasScore(){} // RVA: 0x7FFD53613810
        public void ClearScore(){} // RVA: 0x7FFD53613820
        public void get_Label(){} // RVA: 0x7FFD536BE090
        public void set_Label(){} // RVA: 0x7FFD536BE100
        public void get_HasLabel(){} // RVA: 0x7FFD5361F390
        public void ClearLabel(){} // RVA: 0x7FFD50812F70
        public void get_DisplayName(){} // RVA: 0x7FFD536BE200
        public void set_DisplayName(){} // RVA: 0x7FFD536BE270
        public void get_HasDisplayName(){} // RVA: 0x7FFD52C3E0A0
        public void ClearDisplayName(){} // RVA: 0x7FFD5361F510
        public void Equals(){} // RVA: 0x7FFD536BE3D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536BE590
        public void ToString(){} // RVA: 0x7FFD536BE6D0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536BE720
        public void CalculateSize(){} // RVA: 0x7FFD536BE800
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536BEA60
        public void .cctor(){} // RVA: 0x7FFD536BEB90
    }

    public class Detection : Object
    {
        public gBox.itionBlend<etBestGrabbingType.d_GazeOn> Parser;
        public gBox.ra Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Label;
        public gBox.PathNoRoll<string> LabelId; // 0x8
        public r>k__BackingField.resentations<string> Score; // 0x20
        public int LocationData;
        public gBox.PathNoRoll<int> FeatureTag; // 0x10
        public r>k__BackingField.resentations<int> HasFeatureTag; // 0x28
        public int TrackId;
        public gBox.PathNoRoll<float> HasTrackId; // 0x18
        public r>k__BackingField.resentations<float> DetectionId; // 0x30
        public int HasDetectionId;
        public etBestGrabbingType.Size=11893 AssociatedDetections; // 0x38
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
        public gBox.PathNoRoll<sCode>k__BackingField> _repeated_associatedDetections_codec; // 0x38
        public r>k__BackingField.resentations<sCode>k__BackingField> associatedDetections_; // 0x58
        public int DisplayNameFieldNumber;
        public gBox.PathNoRoll<string> _repeated_displayName_codec; // 0x40
        public r>k__BackingField.resentations<string> displayName_; // 0x60
        public int TimestampUsecFieldNumber;
        public long TimestampUsecDefaultValue; // 0x48
        public long timestampUsec_; // 0x68

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD536C1970
        public void get_Descriptor(){} // RVA: 0x7FFD536C19D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536C1A90
        public void .ctor(){} // RVA: 0x7FFD536C1DE0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536C22B0
        public void get_Label(){} // RVA: 0x7FFD4E36F0C0
        public void get_LabelId(){} // RVA: 0x7FFD4E36F130
        public void get_Score(){} // RVA: 0x7FFD4E5F95E0
        public void get_LocationData(){} // RVA: 0x7FFD4E5F0140
        public void set_LocationData(){} // RVA: 0x7FFD4E5F0C20
        public void get_FeatureTag(){} // RVA: 0x7FFD536C2310
        public void set_FeatureTag(){} // RVA: 0x7FFD536C2380
        public void get_HasFeatureTag(){} // RVA: 0x7FFD52C3E0B0
        public void ClearFeatureTag(){} // RVA: 0x7FFD53616D10
        public void get_TrackId(){} // RVA: 0x7FFD536C2480
        public void set_TrackId(){} // RVA: 0x7FFD536C24F0
        public void get_HasTrackId(){} // RVA: 0x7FFD53616EE0
        public void ClearTrackId(){} // RVA: 0x7FFD53616EF0
        public void get_DetectionId(){} // RVA: 0x7FFD536C25F0
        public void set_DetectionId(){} // RVA: 0x7FFD536C2660
        public void get_HasDetectionId(){} // RVA: 0x7FFD53613770
        public void ClearDetectionId(){} // RVA: 0x7FFD53613780
        public void get_AssociatedDetections(){} // RVA: 0x7FFD4E409500
        public void get_DisplayName(){} // RVA: 0x7FFD4E3DF370
        public void get_TimestampUsec(){} // RVA: 0x7FFD536C2670
        public void set_TimestampUsec(){} // RVA: 0x7FFD536C26E0
        public void get_HasTimestampUsec(){} // RVA: 0x7FFD53613810
        public void ClearTimestampUsec(){} // RVA: 0x7FFD53613820
        public void Equals(){} // RVA: 0x7FFD536C2750 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536C2A10
        public void ToString(){} // RVA: 0x7FFD536C2BD0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536C2C20
        public void CalculateSize(){} // RVA: 0x7FFD536C2EB0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536C3550
        public void .cctor(){} // RVA: 0x7FFD536C3910
    }

    public class DisposableObject : Object
    {
        public int isDisposed; // 0x10
        public bool isOwner; // 0x14
        public bool <isDisposed>k__BackingField; // 0x15
        public bool <isOwner>k__BackingField; // 0x16

        // ── Methods ──
        public void get_isDisposed(){} // RVA: 0x7FFD4E555090
        public void set_isDisposed(){} // RVA: 0x7FFD4F831DF0
        public void get_isOwner(){} // RVA: 0x7FFD4F831E30
        public void set_isOwner(){} // RVA: 0x7FFD4F831E20
        public void .ctor(){} // RVA: 0x7FFD5368A7F0
        public void Dispose(){} // RVA: 0x7FFD5368A870 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD53663E40
        public void DisposeManaged(){} // RVA: 0x7FFD4E341310
        public void DisposeUnmanaged(){} // RVA: 0x7FFD4E341310
        public void Lock(){} // RVA: 0x7FFD4F0B2220
        public void Unlock(){} // RVA: 0x7FFD4F0B2210
        public void TransferOwnership(){} // RVA: 0x7FFD5368A920
        public void ThrowIfDisposed(){} // RVA: 0x7FFD5368A930
    }

    public class FaceDetectionReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536E6830
        public void .cctor(){} // RVA: 0x7FFD536E6890
    }

    public class FlowLimiterCalculatorReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD53697820
        public void .cctor(){} // RVA: 0x7FFD53697880
    }

    public class GlCalculatorHelper : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53691F90
        public void DeleteMpPtr(){} // RVA: 0x7FFD536920D0
        public void InitializeForTest(){} // RVA: 0x7FFD53692190
        public void GetGlContext(){} // RVA: 0x7FFD536922B0
    }

    public class GlContext : MpResourceHandle
    {
        public etBestGrabbingType.DistanceNoItem _sharedPtrHandle; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD536924B0
        public void DisposeManaged(){} // RVA: 0x7FFD53692600
        public void DeleteMpPtr(){} // RVA: 0x7FFD4E341310
    }

    public class GlSyncPoint : MpResourceHandle
    {
        public etBestGrabbingType.DistanceNoItem _sharedPtrHandle; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD536927C0
        public void DisposeManaged(){} // RVA: 0x7FFD53692600
        public void DeleteMpPtr(){} // RVA: 0x7FFD4E341310
        public void Wait(){} // RVA: 0x7FFD536928F0
    }

    public class GlTextureBuffer : MpResourceHandle
    {
        // ── Methods ──
        public void DeleteMpPtr(){} // RVA: 0x7FFD4E341310
    }

    public class GlobalInstanceTable`2 : Object
    {
        public sageKind.ce maxSize;
        public URA.DateTime<T1717692208,numValuesAndNames<T1717692224>> _table;
        public int _maxSize;

        // ── Methods ──
        public void get_maxSize(){} // RVA: 0x7FFD4E079960
        public void set_maxSize(){} // RVA: 0x7FFD4E090ED0
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void ClearUnusedKeys(){} // RVA: 0x7FFD4E090980
    }

    public class Glog : Object
    {
        public bool Logtostderr;
        public int Stderrthreshold; // 0x4
        public int Minloglevel; // 0x8
        public int V; // 0xC

        // ── Methods ──
        public void set_Logtostderr(){} // RVA: 0x7FFD5368B3F0
        public void get_Stderrthreshold(){} // RVA: 0x7FFD5368B4F0
        public void set_Stderrthreshold(){} // RVA: 0x7FFD5368B550
        public void get_Minloglevel(){} // RVA: 0x7FFD5368B650
        public void set_Minloglevel(){} // RVA: 0x7FFD5368B6B0
        public void get_V(){} // RVA: 0x7FFD5368B7B0
        public void set_V(){} // RVA: 0x7FFD5368B810
        public void Initialize(){} // RVA: 0x7FFD5368B910
        public void Shutdown(){} // RVA: 0x7FFD5368B9F0
        public void .cctor(){} // RVA: 0x7FFD5368BA90
    }

    public class GpuBuffer : MpResourceHandle
    {
        // ── Methods ──
        public void DeleteMpPtr(){} // RVA: 0x7FFD53692B00
    }

    public class GpuOrigin : Object
    {
        public gBox.itionBlend<etBestGrabbingType.otobuf__SetLogHandler__PF> Parser;
        public gBox.ra Descriptor; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD536E61D0
        public void get_Descriptor(){} // RVA: 0x7FFD536E6230
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536E62F0
        public void .ctor(){} // RVA: 0x7FFD535F3F10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536E63E0
        public void Equals(){} // RVA: 0x7FFD535F41A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD535F41E0
        public void ToString(){} // RVA: 0x7FFD536E6590
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD535F4270
        public void CalculateSize(){} // RVA: 0x7FFD535F4290
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD535F4390
        public void .cctor(){} // RVA: 0x7FFD536E65E0
    }

    public class GpuResources : MpResourceHandle
    {
        public etBestGrabbingType.DistanceNoItem sharedPtr; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53692BC0
        public void DisposeManaged(){} // RVA: 0x7FFD53692600
        public void DeleteMpPtr(){} // RVA: 0x7FFD4E341310
        public void get_sharedPtr(){} // RVA: 0x7FFD53692CF0
        public void Create(){} // RVA: 0x7FFD53692D10
    }

    public class Image : MpResourceHandle
    {
        public ceRotation _VoidDeleter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5368D740 | overloaded x5
        public void DeleteMpPtr(){} // RVA: 0x7FFD5368DA00
        public void Width(){} // RVA: 0x7FFD5368DAC0
        public void Height(){} // RVA: 0x7FFD5368DB80
        public void Step(){} // RVA: 0x7FFD5368DC40
        public void ImageFormat(){} // RVA: 0x7FFD5368DD00
        public void .cctor(){} // RVA: 0x7FFD5368DDC0
    }

    public class ImageArray : ValueType
    {
        public UIntPtr _data; // 0x10
        public int _size; // 0x18

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFD53693070
    }

    public class ImageFormat : Object
    {
        public gBox.itionBlend<etBestGrabbingType.ÌÏÏÌÌÎÎÍÎÎÎÍÍÏ> Parser;
        public gBox.ra Descriptor; // 0x10

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD536C6340
        public void get_Descriptor(){} // RVA: 0x7FFD536C63A0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536C6460
        public void .ctor(){} // RVA: 0x7FFD535F3F10 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536C6550
        public void Equals(){} // RVA: 0x7FFD535F41A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD535F41E0
        public void ToString(){} // RVA: 0x7FFD536C6700
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD535F4270
        public void CalculateSize(){} // RVA: 0x7FFD535F4290
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD535F4390
        public void .cctor(){} // RVA: 0x7FFD536C6750
    }

    public class ImageFormatExtension : Object
    {
        // ── Methods ──
        public void NumberOfChannels(){} // RVA: 0x7FFD5368AFE0
        public void ByteDepth(){} // RVA: 0x7FFD5368B050
    }

    public class ImageFrame : MpResourceHandle
    {
        public uint DefaultAlignmentBoundary;
        public uint GlDefaultAlignmentBoundary; // 0x4
        public ceRotation _VoidDeleter; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5368E4B0 | overloaded x4
        public void DeleteMpPtr(){} // RVA: 0x7FFD5368E6D0
        public void VoidDeleter(){} // RVA: 0x7FFD4E341310
        public void Format(){} // RVA: 0x7FFD5368E790
        public void Width(){} // RVA: 0x7FFD5368E810
        public void Height(){} // RVA: 0x7FFD5368E890
        public void ByteDepth(){} // RVA: 0x7FFD5368E910
        public void WidthStep(){} // RVA: 0x7FFD5368E930
        public void MutablePixelData(){} // RVA: 0x7FFD5368E9B0
        public void PixelDataSize(){} // RVA: 0x7FFD5368EA30
        public void .cctor(){} // RVA: 0x7FFD5368EA60
    }

    public class InferenceCalculatorReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536990A0
        public void .cctor(){} // RVA: 0x7FFD53699100
    }

    public class InternalException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5368A9C0
    }

    public class Landmark : Object
    {
        public gBox.itionBlend<etBestGrabbingType.?> Parser;
        public gBox.ra Descriptor; // 0x10
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
        public void get_Parser(){} // RVA: 0x7FFD536C77D0
        public void get_Descriptor(){} // RVA: 0x7FFD536C7830
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536C78F0
        public void .ctor(){} // RVA: 0x7FFD536C79E0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536C7AE0
        public void get_X(){} // RVA: 0x7FFD536C7C10
        public void set_X(){} // RVA: 0x7FFD536C7C80
        public void get_HasX(){} // RVA: 0x7FFD53613770
        public void ClearX(){} // RVA: 0x7FFD53613780
        public void get_Y(){} // RVA: 0x7FFD536C7C90
        public void set_Y(){} // RVA: 0x7FFD536BE080
        public void get_HasY(){} // RVA: 0x7FFD53613810
        public void ClearY(){} // RVA: 0x7FFD53613820
        public void get_Z(){} // RVA: 0x7FFD536C7D00
        public void set_Z(){} // RVA: 0x7FFD536C7D70
        public void get_HasZ(){} // RVA: 0x7FFD53616A10
        public void ClearZ(){} // RVA: 0x7FFD53616A20
        public void get_Visibility(){} // RVA: 0x7FFD536C7D80
        public void set_Visibility(){} // RVA: 0x7FFD536C7DF0
        public void get_HasVisibility(){} // RVA: 0x7FFD53616FD0
        public void ClearVisibility(){} // RVA: 0x7FFD53616FE0
        public void get_Presence(){} // RVA: 0x7FFD536C7E00
        public void set_Presence(){} // RVA: 0x7FFD536C7E70
        public void get_HasPresence(){} // RVA: 0x7FFD53617240
        public void ClearPresence(){} // RVA: 0x7FFD53617250
        public void Equals(){} // RVA: 0x7FFD536C7EE0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536C8160
        public void ToString(){} // RVA: 0x7FFD536C8370
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536C83C0
        public void CalculateSize(){} // RVA: 0x7FFD536C84D0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536C86A0
        public void .cctor(){} // RVA: 0x7FFD536C87C0
    }

    public class ListExtension : Object
    {
        // ── Methods ──
        public void ResizeTo(){} // RVA: 0x7FFD4E096370
    }

    public class LocationData : Object
    {
        public gBox.itionBlend<etBestGrabbingType.Size=11893> Parser;
        public gBox.ra Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Format;
        public BIT_LENGTH HasFormat; // 0x8
        public BIT_LENGTH BoundingBox; // 0x1C
        public int RelativeBoundingBox;
        public Step Mask; // 0x20
        public int RelativeKeypoints;
        public PixelData relativeBoundingBox_; // 0x28
        public int MaskFieldNumber;
        public ateProto mask_; // 0x30
        public int RelativeKeypointsFieldNumber;
        public gBox.PathNoRoll<tMap> _repeated_relativeKeypoints_codec; // 0x10
        public r>k__BackingField.resentations<tMap> relativeKeypoints_; // 0x38

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD536CE8C0
        public void get_Descriptor(){} // RVA: 0x7FFD536CE920
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536CE9E0
        public void .ctor(){} // RVA: 0x7FFD536CEAF0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536CF120
        public void get_Format(){} // RVA: 0x7FFD536CF180
        public void set_Format(){} // RVA: 0x7FFD53613760
        public void get_HasFormat(){} // RVA: 0x7FFD53613770
        public void ClearFormat(){} // RVA: 0x7FFD53613780
        public void get_BoundingBox(){} // RVA: 0x7FFD4E36F0C0
        public void set_BoundingBox(){} // RVA: 0x7FFD4E36F0D0
        public void get_RelativeBoundingBox(){} // RVA: 0x7FFD4E36F130
        public void set_RelativeBoundingBox(){} // RVA: 0x7FFD4E342E90
        public void get_Mask(){} // RVA: 0x7FFD4E5F95E0
        public void set_Mask(){} // RVA: 0x7FFD4E36F890
        public void get_RelativeKeypoints(){} // RVA: 0x7FFD4E5F0140
        public void Equals(){} // RVA: 0x7FFD536CF250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536CF3D0
        public void ToString(){} // RVA: 0x7FFD536CF4B0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536CF500
        public void CalculateSize(){} // RVA: 0x7FFD536CF650
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536CFDC0
        public void .cctor(){} // RVA: 0x7FFD536CFFC0
    }

    public class MatrixData : Object
    {
        public gBox.itionBlend<etBestGrabbingType.exName> Parser;
        public gBox.ra Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int Rows; // 0x8
        public int HasRows; // 0x1C
        public int Cols; // 0xC
        public int HasCols; // 0x20
        public gBox.PathNoRoll<float> PackedData; // 0x10
        public r>k__BackingField.resentations<float> Layout; // 0x28
        public UnderPointer HasLayout; // 0x18
        public UnderPointer layout_; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD536D4C00
        public void get_Descriptor(){} // RVA: 0x7FFD536D4C60
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536D4D20
        public void .ctor(){} // RVA: 0x7FFD536D4ED0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536D5080
        public void get_Rows(){} // RVA: 0x7FFD536D5260
        public void set_Rows(){} // RVA: 0x7FFD53613760
        public void get_HasRows(){} // RVA: 0x7FFD53613770
        public void ClearRows(){} // RVA: 0x7FFD53613780
        public void get_Cols(){} // RVA: 0x7FFD536D52D0
        public void set_Cols(){} // RVA: 0x7FFD53613800
        public void get_HasCols(){} // RVA: 0x7FFD53613810
        public void ClearCols(){} // RVA: 0x7FFD53613820
        public void get_PackedData(){} // RVA: 0x7FFD4E36F130
        public void get_Layout(){} // RVA: 0x7FFD536D5340
        public void set_Layout(){} // RVA: 0x7FFD53616A00
        public void get_HasLayout(){} // RVA: 0x7FFD53616A10
        public void ClearLayout(){} // RVA: 0x7FFD53616A20
        public void Equals(){} // RVA: 0x7FFD536D5510 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536D5640
        public void ToString(){} // RVA: 0x7FFD536D56E0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536D5730
        public void CalculateSize(){} // RVA: 0x7FFD536D5860
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536D5B80
        public void .cctor(){} // RVA: 0x7FFD536D5CF0
    }

    public class MediaPipeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5368AA20
    }

    public class MediaPipeOptions : Object
    {
        public gBox.itionBlend<etBestGrabbingType.lassifications> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<etBestGrabbingType.lassifications> Descriptor; // 0x18

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD536D92B0
        public void get_Descriptor(){} // RVA: 0x7FFD536D9310
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536D93D0
        public void .ctor(){} // RVA: 0x7FFD536D94C0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536D9640
        public void Equals(){} // RVA: 0x7FFD536D98E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536D9980
        public void ToString(){} // RVA: 0x7FFD536D99F0
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536D9A40
        public void CalculateSize(){} // RVA: 0x7FFD536D9AB0
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536D9C50
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD536D9D00
    }

    public class MediaPipePluginException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5368AA80
    }

    public class MediapipeOptionsReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536D8E20
        public void .cctor(){} // RVA: 0x7FFD536D8E80
    }

    public class MpResourceHandle : DisposableObject
    {
        public UIntPtr ptr; // 0x18

        // ── Methods ──
        public void get_ptr(){} // RVA: 0x7FFD4E3447C0
        public void set_ptr(){} // RVA: 0x7FFD5368AAE0
        public void .ctor(){} // RVA: 0x7FFD51B06D30 | overloaded x2
        public void get_mpPtr(){} // RVA: 0x7FFD5368AB70
        public void ReleaseMpResource(){} // RVA: 0x7FFD5368AC00
        public void OwnsResource(){} // RVA: 0x7FFD5368AC50
        public void DisposeUnmanaged(){} // RVA: 0x7FFD5368AC70
        public void ReleaseMpPtr(){} // RVA: 0x7FFD5368ACC0
        public void DeleteMpPtr(){} // RVA: 0x7FFD4E090980
        public void MarshalStringFromNative(){} // RVA: 0x7FFD5368AE00 | overloaded x2
        public void AssertStatusOk(){} // RVA: 0x7FFD5368AEB0
        public void IsResourcePresent(){} // RVA: 0x7FFD5368AFD0
    }

    public class MpReturnCodeExtension : Object
    {
        // ── Methods ──
        public void Assert(){} // RVA: 0x7FFD53693A60
    }

    public class NativeCategory : ValueType
    {
        public int categoryName; // 0x10
        public float displayName; // 0x14
        public UIntPtr _categoryName; // 0x18
        public UIntPtr _displayName; // 0x20

        // ── Methods ──
        public void get_categoryName(){} // RVA: 0x7FFD536930D0
        public void get_displayName(){} // RVA: 0x7FFD53693140
    }

    public class NativeClassificationResult : ValueType
    {
        public UIntPtr classifications; // 0x10
        public uint classificationsCount; // 0x18
        public long timestampMs; // 0x20
        public bool hasTimestampMs; // 0x28

        // ── Methods ──
        public void get_classifications(){} // RVA: 0x7FFD53693280
        public void Dispose(){} // RVA: 0x7FFD536932E0
    }

    public class NativeDetectionResult : ValueType
    {
        public UIntPtr _detections; // 0x10
        public uint detectionsCount; // 0x18

        // ── Methods ──
        public void AsReadOnlySpan(){} // RVA: 0x7FFD536934C0
        public void Dispose(){} // RVA: 0x7FFD53693520
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
        public void get_name(){} // RVA: 0x7FFD53693660
    }

    public class NativeNormalizedKeypoint : ValueType
    {
        public float label; // 0x10
        public float y; // 0x14
        public UIntPtr _label; // 0x18
        public float score; // 0x20
        public bool hasScore; // 0x24

        // ── Methods ──
        public void get_label(){} // RVA: 0x7FFD536935F0
    }

    public class NativeRect : ValueType
    {
        public int left; // 0x10
        public int top; // 0x14
        public int bottom; // 0x18
        public int right; // 0x1C
    }

    public class OutputStreamPoller`1 : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090BF0
        public void DeleteMpPtr(){} // RVA: 0x7FFD4E090980
        public void Next(){} // RVA: 0x7FFD4E079F60
    }

    public class Packet : Object
    {
        // ── Methods ──
        public void CreateBool(){} // RVA: 0x7FFD5368EB70
        public void CreateGpuBuffer(){} // RVA: 0x7FFD5368EC80
        public void CreateGpuBufferAt(){} // RVA: 0x7FFD5368EDC0
        public void CreateImage(){} // RVA: 0x7FFD5368EF10
        public void CreateImageAt(){} // RVA: 0x7FFD5368F050
        public void CreateImageFrameAt(){} // RVA: 0x7FFD5368F1A0
        public void CreateInt(){} // RVA: 0x7FFD5368F2F0
        public void CreateProto(){} // RVA: 0x7FFD4E2ADC40
        public void CreateProtoAt(){} // RVA: 0x7FFD4E2ADC40
    }

    public class PacketFactoryOptions : Object
    {
        public gBox.itionBlend<etBestGrabbingType.nts> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<etBestGrabbingType.nts> Descriptor; // 0x18

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD536DA850
        public void get_Descriptor(){} // RVA: 0x7FFD536DA8B0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536DA970
        public void .ctor(){} // RVA: 0x7FFD536DAA60 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536DABE0
        public void Equals(){} // RVA: 0x7FFD536D98E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536D9980
        public void ToString(){} // RVA: 0x7FFD536DAE80
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536DAED0
        public void CalculateSize(){} // RVA: 0x7FFD536DAF40
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536DB0E0
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD536DB190
    }

    public class PacketFactoryReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536D9F50
        public void .cctor(){} // RVA: 0x7FFD536D9FB0
    }

    public class PacketGeneratorOptions : Object
    {
        public gBox.itionBlend<etBestGrabbingType.mp_ImageFrame__WidthStep> _Extensions;
        public gBox.ra Parser; // 0x10
        public gBox.centerTarget<etBestGrabbingType.mp_ImageFrame__WidthStep> Descriptor; // 0x18
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x20
        public bool MergeFields; // 0x8
        public bool HasMergeFields; // 0x24

        // ── Methods ──
        public void get__Extensions(){} // RVA: 0x7FFD4E3447C0
        public void get_Parser(){} // RVA: 0x7FFD536DE3E0
        public void get_Descriptor(){} // RVA: 0x7FFD536DE440
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536DE500
        public void .ctor(){} // RVA: 0x7FFD536DE5F0 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536DE780
        public void get_MergeFields(){} // RVA: 0x7FFD536DE940
        public void set_MergeFields(){} // RVA: 0x7FFD53624E30
        public void get_HasMergeFields(){} // RVA: 0x7FFD53621340
        public void ClearMergeFields(){} // RVA: 0x7FFD53621350
        public void Equals(){} // RVA: 0x7FFD536DEAC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536DEB90
        public void ToString(){} // RVA: 0x7FFD536DEC50
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536DECA0
        public void CalculateSize(){} // RVA: 0x7FFD536DED40
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536DEEF0
        public void GetExtension(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetOrInitializeExtension(){} // RVA: 0x7FFD4E078F40
        public void SetExtension(){} // RVA: 0x7FFD4E2ADC40
        public void HasExtension(){} // RVA: 0x7FFD4E079F60
        public void ClearExtension(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD536DEFC0
    }

    public class PacketGeneratorReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536DDBC0
        public void .cctor(){} // RVA: 0x7FFD536DDC20
    }

    public class PacketGetterExtension : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E0961F0 | overloaded x6
        public void WriteTo(){} // RVA: 0x7FFD4E081D80
    }

    public class PacketMap : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51B06D30 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFD5368F530
        public void At(){} // RVA: 0x7FFD4E078F40
        public void Emplace(){} // RVA: 0x7FFD4E099B30
    }

    public class Packet`1 : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFD4E090980
        public void TimestampMicroseconds(){} // RVA: 0x7FFD4E078E90
        public void IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void SwitchNativePtr(){} // RVA: 0x7FFD4E090BF0
        public void CreateForReference(){} // RVA: 0x7FFD4E087ED0
    }

    public class ProtoMessageClearExtension : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFD5368B2B0 | overloaded x3
    }

    public class Protobuf : Object
    {
        public ityMagic DefaultLogHandler;

        // ── Methods ──
        public void SetLogHandler(){} // RVA: 0x7FFD5368BB10
        public void ResetLogHandler(){} // RVA: 0x7FFD5368BBE0
        public void LogProtobufMessage(){} // RVA: 0x7FFD5368BC80
        public void .cctor(){} // RVA: 0x7FFD5368BEE0
    }

    public class Rasterization : Object
    {
        public gBox.itionBlend<etBestGrabbingType.?> Parser;
        public gBox.ra Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor;
        public gBox.PathNoRoll<onvertFromUtc> Interval; // 0x8
        public r>k__BackingField.resentations<onvertFromUtc> interval_; // 0x18

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD536BB3D0
        public void get_Descriptor(){} // RVA: 0x7FFD536BB430
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536BB4F0
        public void .ctor(){} // RVA: 0x7FFD536BB600 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536BB7A0
        public void get_Interval(){} // RVA: 0x7FFD4E3447C0
        public void Equals(){} // RVA: 0x7FFD536BBA70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD535F5360
        public void ToString(){} // RVA: 0x7FFD536BBB20
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536BBB70
        public void CalculateSize(){} // RVA: 0x7FFD536BBC30
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536BBE20
        public void .cctor(){} // RVA: 0x7FFD536BBF20
    }

    public class Rect : Object
    {
        public gBox.itionBlend<etBestGrabbingType.dRecorder> Parser;
        public gBox.ra Descriptor; // 0x10
        public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
        public int XCenter; // 0x8
        public int HasXCenter; // 0x1C
        public int YCenter; // 0xC
        public int HasYCenter; // 0x20
        public int Height; // 0x10
        public int HasHeight; // 0x24
        public int Width; // 0x14
        public int HasWidth; // 0x28
        public float Rotation; // 0x18
        public float HasRotation; // 0x2C
        public long RectId; // 0x20
        public long HasRectId; // 0x30

        // ── Methods ──
        public void get_Parser(){} // RVA: 0x7FFD536D6870
        public void get_Descriptor(){} // RVA: 0x7FFD536D68D0
        public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFD536D6990
        public void .ctor(){} // RVA: 0x7FFD536D6A80 | overloaded x2
        public void Clone(){} // RVA: 0x7FFD536D6B80
        public void get_XCenter(){} // RVA: 0x7FFD536D6CB0
        public void set_XCenter(){} // RVA: 0x7FFD53613760
        public void get_HasXCenter(){} // RVA: 0x7FFD53613770
        public void ClearXCenter(){} // RVA: 0x7FFD53613780
        public void get_YCenter(){} // RVA: 0x7FFD536D6D20
        public void set_YCenter(){} // RVA: 0x7FFD53613800
        public void get_HasYCenter(){} // RVA: 0x7FFD53613810
        public void ClearYCenter(){} // RVA: 0x7FFD53613820
        public void get_Height(){} // RVA: 0x7FFD536D6D90
        public void set_Height(){} // RVA: 0x7FFD536A34A0
        public void get_HasHeight(){} // RVA: 0x7FFD53616A10
        public void ClearHeight(){} // RVA: 0x7FFD53616A20
        public void get_Width(){} // RVA: 0x7FFD536D6E00
        public void set_Width(){} // RVA: 0x7FFD536A6700
        public void get_HasWidth(){} // RVA: 0x7FFD53616FD0
        public void ClearWidth(){} // RVA: 0x7FFD53616FE0
        public void get_Rotation(){} // RVA: 0x7FFD536D6E70
        public void set_Rotation(){} // RVA: 0x7FFD536C7E70
        public void get_HasRotation(){} // RVA: 0x7FFD53617240
        public void ClearRotation(){} // RVA: 0x7FFD53617250
        public void get_RectId(){} // RVA: 0x7FFD536D6EE0
        public void set_RectId(){} // RVA: 0x7FFD536D6F50
        public void get_HasRectId(){} // RVA: 0x7FFD536A38B0
        public void ClearRectId(){} // RVA: 0x7FFD536A38C0
        public void Equals(){} // RVA: 0x7FFD536D6FC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD536D7150
        public void ToString(){} // RVA: 0x7FFD536D7280
        public void WriteTo(){} // RVA: 0x7FFD535F0B60
        public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFD536D72D0
        public void CalculateSize(){} // RVA: 0x7FFD536D7400
        public void MergeFrom(){} // RVA: 0x7FFD535F0EA0 | overloaded x2
        public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFD536D7720
        public void .cctor(){} // RVA: 0x7FFD536D7850
    }

    public class ResourceManager : Object
    {
        public object _InitLock;
        public etBestGrabbingType.OnSerializedAttribute _Instance; // 0x8
        public Proto_At__PKc_PKc_i_ll _pathResolver; // 0x10
        public tProtoMessageLite _resourceProvider; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD536E9B40
        public void PrepareAssetAsync(){}
        public void PathToResourceAsFile(){} // RVA: 0x7FFD536EA0D0
        public void GetResourceContents(){} // RVA: 0x7FFD536EA190
        public void GetAssetNameFromPath(){} // RVA: 0x7FFD536EA560
        public void .cctor(){} // RVA: 0x7FFD536EA740
    }

    public class SafeNativeMethods : Object
    {
        // ── Methods ──
        public void absl_Status__ok(){} // RVA: 0x7FFD53693C10
        public void absl_Status__raw_code(){} // RVA: 0x7FFD53693C90
        public void mp_ImageFrame__Format(){} // RVA: 0x7FFD53693D10
        public void mp_ImageFrame__Width(){} // RVA: 0x7FFD53693D90
        public void mp_ImageFrame__Height(){} // RVA: 0x7FFD53693E10
        public void mp_ImageFrame__WidthStep(){} // RVA: 0x7FFD53693E90
        public void mp_ImageFrame__MutablePixelData(){} // RVA: 0x7FFD53693F10
        public void mp_Image__width(){} // RVA: 0x7FFD53693F90
        public void mp_Image__height(){} // RVA: 0x7FFD53694010
        public void mp_Image__step(){} // RVA: 0x7FFD53694090
        public void mp_Image__image_format(){} // RVA: 0x7FFD53694110
        public void mp_PixelWriteLock__Pixels(){} // RVA: 0x7FFD53694190
        public void mp_Packet__IsEmpty(){} // RVA: 0x7FFD53694210
        public void mp_Packet__TimestampMicroseconds(){} // RVA: 0x7FFD53694290
        public void mp_GlCalculatorHelper__GetGlContext(){} // RVA: 0x7FFD53694310
        public void mp_SharedGlContext__get(){} // RVA: 0x7FFD53694390
        public void mp_GlSyncToken__get(){} // RVA: 0x7FFD53694410
        public void mp_SharedGpuResources__get(){} // RVA: 0x7FFD53694490
        public void mp__SetCustomGlobalResourceProvider__P(){} // RVA: 0x7FFD53694510
        public void mp__SetCustomGlobalPathResolver__P(){} // RVA: 0x7FFD536945A0
    }

    public class SerializedProto : ValueType
    {
        public UIntPtr _str; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD5368C150
        public void Deserialize(){} // RVA: 0x7FFD4E2ADC40
        public void WriteTo(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SerializedProtoVector : ValueType
    {
        public UIntPtr _data; // 0x10
        public int _size; // 0x18

        // ── Methods ──
        public void Dispose(){} // RVA: 0x7FFD5368C1B0
        public void Deserialize(){} // RVA: 0x7FFD4E099B30
        public void WriteTo(){} // RVA: 0x7FFD4E0837A0
    }

    public class SharedPtrHandle : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51B06D30
        public void Get(){} // RVA: 0x7FFD4E078E90
    }

    public class Status : MpResourceHandle
    {
        public aphy<bool> _ok; // 0x20
        public aphy<int> _rawCode; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51B06D30
        public void DeleteMpPtr(){} // RVA: 0x7FFD5368FE90
        public void UnsafeAssertOk(){} // RVA: 0x7FFD5368FEF0
        public void AssertOk(){} // RVA: 0x7FFD53690010
        public void Ok(){} // RVA: 0x7FFD53690130
        public void Code(){} // RVA: 0x7FFD536901F0
        public void RawCode(){} // RVA: 0x7FFD536901F0
        public void ToString(){} // RVA: 0x7FFD53690320
    }

    public class StatusArgs : ValueType
    {
        public etBestGrabbingType.ÎÏÏÍÎÎÏÌÎÌÏÏÍÍÌÌÌÏÏÌÏ _code; // 0x10
        public UIntPtr _message; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5368FC60
        public void Ok(){} // RVA: 0x7FFD5368FCD0
        public void InvalidArgument(){} // RVA: 0x7FFD5368FD40
        public void NotFound(){} // RVA: 0x7FFD5368FDB0
        public void Internal(){} // RVA: 0x7FFD5368FE20
    }

    public class StatusHandlerReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536E1070
        public void .cctor(){} // RVA: 0x7FFD536E10D0
    }

    public class StdString : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5368C270 | overloaded x2
        public void DeleteMpPtr(){} // RVA: 0x7FFD5368C3E0
        public void Swap(){} // RVA: 0x7FFD5368C4A0
    }

    public class StreamHandlerReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536E2D40
        public void .cctor(){} // RVA: 0x7FFD536E2DA0
    }

    public class TensorsToDetectionsCalculatorReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536A1790
        public void .cctor(){} // RVA: 0x7FFD536A17F0
    }

    public class TextureFormatExtension : Object
    {
        // ── Methods ──
        public void ToImageFormat(){} // RVA: 0x7FFD536E9AD0
    }

    public class ThresholdingCalculatorReflection : Object
    {
        public ate.ination Descriptor;

        // ── Methods ──
        public void get_Descriptor(){} // RVA: 0x7FFD536A84E0
        public void .cctor(){} // RVA: 0x7FFD536A8540
    }

    public class Tool : Object
    {
        public string _TagAndNameRegex;
        public string _TagIndexNameRegex; // 0x8
        public string _TagIndexRegex; // 0x10

        // ── Methods ──
        public void GetUnusedSidePacketName(){} // RVA: 0x7FFD53690560
        public void ParseNameFromStream(){} // RVA: 0x7FFD53690980
        public void ValidateName(){} // RVA: 0x7FFD53690A00
        public void ValidateNumber(){} // RVA: 0x7FFD53690B40
        public void ValidateTag(){} // RVA: 0x7FFD53690C80
        public void ParseTagAndName(){} // RVA: 0x7FFD53690DC0
        public void ParseTagIndexName(){} // RVA: 0x7FFD53691180
        public void .cctor(){} // RVA: 0x7FFD53691770
    }

    public class UnsafeNativeMethods : Object
    {
        // ── Methods ──
        public void absl_Status__delete(){} // RVA: 0x7FFD53694630
        public void absl_Status__ToString(){} // RVA: 0x7FFD536946B0
        public void google_InitGoogleLogging__PKc(){} // RVA: 0x7FFD53694740
        public void google_ShutdownGoogleLogging(){} // RVA: 0x7FFD536947F0
        public void glog_FLAGS_logtostderr(){} // RVA: 0x7FFD53694860
        public void glog_FLAGS_stderrthreshold(){} // RVA: 0x7FFD536948E0
        public void glog_FLAGS_minloglevel(){} // RVA: 0x7FFD53694960
        public void glog_FLAGS_v(){} // RVA: 0x7FFD536949E0
        public void google_protobuf__SetLogHandler__PF(){} // RVA: 0x7FFD53694A60
        public void google_protobuf__ResetLogHandler(){} // RVA: 0x7FFD53694AF0
        public void mp_api_SerializedProtoArray__delete(){} // RVA: 0x7FFD53694B60
        public void delete_array__PKc(){} // RVA: 0x7FFD53694BF0
        public void std_string__delete(){} // RVA: 0x7FFD53694C70
        public void std_string__PKc_i(){} // RVA: 0x7FFD53694CF0
        public void std_string__swap__Rstr(){} // RVA: 0x7FFD53694D90
        public void mp_CalculatorGraph__(){} // RVA: 0x7FFD53694E20
        public void mp_CalculatorGraph__delete(){} // RVA: 0x7FFD53694EA0
        public void mp_CalculatorGraph__Initialize__PKc_i(){} // RVA: 0x7FFD53694F20
        public void mp_CalculatorGraph__ObserveOutputStream__PKc_PF_b(){} // RVA: 0x7FFD53694FE0
        public void mp_CalculatorGraph__AddOutputStreamPoller__PKc_b(){} // RVA: 0x7FFD536950D0
        public void mp_CalculatorGraph__StartRun__Rsp(){} // RVA: 0x7FFD536951B0
        public void mp_CalculatorGraph__WaitUntilDone(){} // RVA: 0x7FFD53695250
        public void mp_CalculatorGraph__AddPacketToInputStream__PKc_Ppacket(){} // RVA: 0x7FFD536952E0
        public void mp_CalculatorGraph__CloseAllPacketSources(){} // RVA: 0x7FFD536953B0
        public void mp_CalculatorGraph__SetGpuResources__SPgpu(){} // RVA: 0x7FFD53695440
        public void mp_api__ConvertFromCalculatorGraphConfigTextFormat(){} // RVA: 0x7FFD536954E0
        public void mp_ImageFrame__ui_i_i_i_Pui8_PF(){} // RVA: 0x7FFD53695590
        public void mp_ImageFrame__delete(){} // RVA: 0x7FFD53695650
        public void mp__MakeImageFramePacket_At__Pif_ll(){} // RVA: 0x7FFD536956D0
        public void mp_Packet__GetImageFrame(){} // RVA: 0x7FFD53695770
        public void mp_Image__ui_i_i_i_Pui8_PF(){} // RVA: 0x7FFD53695800
        public void mp_Image__delete(){} // RVA: 0x7FFD536958C0
        public void mp_PixelWriteLock__RI(){} // RVA: 0x7FFD53695940
        public void mp_PixelWriteLock__delete(){} // RVA: 0x7FFD536959D0
        public void mp__MakeImagePacket__PI(){} // RVA: 0x7FFD53695A50
        public void mp__MakeImagePacket_At__PI_ll(){} // RVA: 0x7FFD53695AE0
        public void mp_Packet__GetImage(){} // RVA: 0x7FFD53695B80
        public void mp_Packet__GetImageVector(){} // RVA: 0x7FFD53695C10
        public void mp_OutputStreamPoller__delete(){} // RVA: 0x7FFD53695CA0
        public void mp_OutputStreamPoller__Next_Ppacket(){} // RVA: 0x7FFD53695D20
        public void mp_Packet__(){} // RVA: 0x7FFD53695DD0
        public void mp_Packet__delete(){} // RVA: 0x7FFD53695E50
        public void mp__MakeBoolPacket__b(){} // RVA: 0x7FFD53695ED0
        public void mp__MakeIntPacket__i(){} // RVA: 0x7FFD53695F60
        public void mp__PacketFromDynamicProto__PKc_PKc_i(){} // RVA: 0x7FFD53695FF0
        public void mp__PacketFromDynamicProto_At__PKc_PKc_i_ll(){} // RVA: 0x7FFD536960D0
        public void mp_Packet__GetProtoMessageLite(){} // RVA: 0x7FFD536961C0
        public void mp_Packet__GetVectorOfProtoMessageLite(){} // RVA: 0x7FFD53696250
        public void mp_PacketMap__(){} // RVA: 0x7FFD536962E0
        public void mp_PacketMap__delete(){} // RVA: 0x7FFD53696360
        public void mp_PacketMap__emplace__PKc_Rp(){} // RVA: 0x7FFD536963E0
        public void mp_PacketMap__find__PKc(){} // RVA: 0x7FFD536964A0
        public void mp_ValidatedGraphConfig__(){} // RVA: 0x7FFD53696560
        public void mp_ValidatedGraphConfig__delete(){} // RVA: 0x7FFD536965E0
        public void mp_ValidatedGraphConfig__Initialize__Rcgc(){} // RVA: 0x7FFD53696660
        public void mp_ValidatedGraphConfig__Config(){} // RVA: 0x7FFD53696720
        public void mp_GlCalculatorHelper__(){} // RVA: 0x7FFD536967B0
        public void mp_GlCalculatorHelper__delete(){} // RVA: 0x7FFD53696830
        public void mp_GlCalculatorHelper__InitializeForTest__Pgr(){} // RVA: 0x7FFD536968B0
        public void mp_SharedGlContext__delete(){} // RVA: 0x7FFD53696940
        public void mp_GlSyncToken__delete(){} // RVA: 0x7FFD536969C0
        public void mp_GlSyncPoint__Wait(){} // RVA: 0x7FFD53696A40
        public void mp_GpuBuffer__delete(){} // RVA: 0x7FFD53696AC0
        public void mp__MakeGpuBufferPacket__Rgb(){} // RVA: 0x7FFD53696B40
        public void mp__MakeGpuBufferPacket_At__Rgb_ll(){} // RVA: 0x7FFD53696BD0
        public void mp_SharedGpuResources__delete(){} // RVA: 0x7FFD53696C70
        public void mp_GpuResources_Create__Pv(){} // RVA: 0x7FFD53696CF0
        public void mp_Packet__GetClassificationsVector(){} // RVA: 0x7FFD53696D90
        public void mp_tasks_c_components_containers_CppCloseClassificationResult(){} // RVA: 0x7FFD53696E70
        public void mp_Packet__GetDetectionResult(){} // RVA: 0x7FFD53696F30
        public void mp_tasks_c_components_containers_CppCloseDetectionResult(){} // RVA: 0x7FFD53696FC0
        public void mp_Packet__GetLandmarksVector(){} // RVA: 0x7FFD53697050
        public void mp_api_LandmarksArray__delete(){} // RVA: 0x7FFD536970E0
        public void mp_Packet__GetNormalizedLandmarksVector(){} // RVA: 0x7FFD53697170
        public void mp_api_NormalizedLandmarksArray__delete(){} // RVA: 0x7FFD53697200
        public void mp_tasks_core_TaskRunner_Create__PKc_i_PF(){} // RVA: 0x7FFD53697290
        public void mp_tasks_core_TaskRunner__delete(){} // RVA: 0x7FFD53697350
        public void mp_tasks_core_TaskRunner__Process__Ppm(){} // RVA: 0x7FFD536973D0
        public void mp_tasks_core_TaskRunner__Send__Ppm(){} // RVA: 0x7FFD53697480
        public void mp_tasks_core_TaskRunner__Close(){} // RVA: 0x7FFD53697520
        public void .cctor(){} // RVA: 0x7FFD536975B0
        public void FreeHGlobal(){} // RVA: 0x7FFD53697740
        public void mp_api__SetFreeHGlobal(){} // RVA: 0x7FFD53697790
    }

    public class ValidatedGraphConfig : MpResourceHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53691A60
        public void DeleteMpPtr(){} // RVA: 0x7FFD53691BA0
        public void Initialize(){} // RVA: 0x7FFD53691C60
        public void Config(){} // RVA: 0x7FFD53691DA0
    }

}